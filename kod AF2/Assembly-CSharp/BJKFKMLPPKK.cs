using System;
using UnityEngine;
using UnityEngine.PostProcessing;
using UnityEngine.Rendering;

// Token: 0x0200051E RID: 1310
public sealed class BJKFKMLPPKK : AJIEADKHGJM<FogModel>
{
	// Token: 0x060115FE RID: 71166 RVA: 0x007C1E9F File Offset: 0x007C009F
	public bool KMDJPIIHONJ()
	{
		return base.BBEPCCALAFC.enabled && this.AMCOGJHPPOC.PBKNAKJBLDD() && RenderSettings.fog && this.AMCOGJHPPOC.IPMGKDLKDHF();
	}

	// Token: 0x060115FF RID: 71167 RVA: 0x007C1ED2 File Offset: 0x007C00D2
	public CameraEvent DHKJAPGLHOD()
	{
		return CameraEvent.AfterDepthTexture;
	}

	// Token: 0x06011600 RID: 71168 RVA: 0x000EB372 File Offset: 0x000E9572
	public DepthTextureMode MBOFGOBKHPJ()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x06011601 RID: 71169 RVA: 0x007C1ED6 File Offset: 0x007C00D6
	public bool NHCLJOJLABJ()
	{
		return !base.BBEPCCALAFC.enabled || !this.AMCOGJHPPOC.HDBIPEDBMCC() || !RenderSettings.fog || this.AMCOGJHPPOC.GCPDMBIEAOG();
	}

	// Token: 0x06011602 RID: 71170 RVA: 0x007C1F09 File Offset: 0x007C0109
	public CameraEvent MDCELNLCNNG()
	{
		return (CameraEvent)83;
	}

	// Token: 0x06011603 RID: 71171 RVA: 0x000EADB7 File Offset: 0x000E8FB7
	public override DepthTextureMode PPAJFNGHBCF()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x06011604 RID: 71172 RVA: 0x007C1F10 File Offset: 0x007C0110
	public void PIPLMJAOLGL(CommandBuffer ECKPLMDEJFD)
	{
		FogModel.Settings settings = base.BBEPCCALAFC.FAOHPPLCMFD();
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.ACEOHEODOMJ("Calf");
		material.shaderKeywords = null;
		Color value = CDBICMCJFCE.AIDPGNAEOMF ? RenderSettings.fogColor.linear : RenderSettings.fogColor;
		material.SetColor(BJKFKMLPPKK.LBDKMKJPLOG.BOCBPADFMLH, value);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.INEPNGJKCOF, RenderSettings.fogDensity);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.FAAPIGHAFHJ, RenderSettings.fogStartDistance);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.HGKPMOLMOHH, RenderSettings.fogEndDistance);
		switch (RenderSettings.fogMode)
		{
		case FogMode.Linear:
			material.EnableKeyword("\n");
			break;
		case FogMode.Exponential:
			material.EnableKeyword("_MainTex");
			break;
		case FogMode.ExponentialSquared:
			material.EnableKeyword("_ReflectionTexture0");
			break;
		}
		RenderTextureFormat format = this.AMCOGJHPPOC.NNILENLPFDO() ? RenderTextureFormat.Shadowmap : RenderTextureFormat.Default;
		ECKPLMDEJFD.GetTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, this.AMCOGJHPPOC.LJJOEDIJPEM(), this.AMCOGJHPPOC.GHMBALIHBOH(), 104, FilterMode.Point, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.PrepassLight, BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
		ECKPLMDEJFD.Blit(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, BuiltinRenderTextureType.Depth, material, settings.excludeSkybox ? 1 : 0);
		ECKPLMDEJFD.ReleaseTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
	}

	// Token: 0x06011605 RID: 71173 RVA: 0x007C2060 File Offset: 0x007C0260
	public void OGHHDCIBCKD(CommandBuffer ECKPLMDEJFD)
	{
		FogModel.Settings settings = base.BBEPCCALAFC.DMJMEMIPKNM();
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.HPAJGFGNMOH("CraftProf.xml");
		material.shaderKeywords = null;
		Color value = CDBICMCJFCE.AIDPGNAEOMF ? RenderSettings.fogColor.linear : RenderSettings.fogColor;
		material.SetColor(BJKFKMLPPKK.LBDKMKJPLOG.BOCBPADFMLH, value);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.INEPNGJKCOF, RenderSettings.fogDensity);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.FAAPIGHAFHJ, RenderSettings.fogStartDistance);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.HGKPMOLMOHH, RenderSettings.fogEndDistance);
		switch (RenderSettings.fogMode)
		{
		case FogMode.Linear:
			material.EnableKeyword("_DstBlend");
			break;
		case FogMode.Exponential:
			material.EnableKeyword("SneakLeft");
			break;
		case FogMode.ExponentialSquared:
			material.EnableKeyword("abcd");
			break;
		}
		RenderTextureFormat format = this.AMCOGJHPPOC.FPIAHOMIEJP() ? ((RenderTextureFormat)(-121)) : RenderTextureFormat.ARGB4444;
		ECKPLMDEJFD.GetTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, this.AMCOGJHPPOC.CFDHOKHCPOJ(), this.AMCOGJHPPOC.ILLKFNCFGMP, 37, FilterMode.Bilinear, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.DepthNormals, BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
		ECKPLMDEJFD.Blit(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, BuiltinRenderTextureType.DepthNormals, material, settings.excludeSkybox ? 0 : 0);
		ECKPLMDEJFD.ReleaseTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
	}

	// Token: 0x06011606 RID: 71174 RVA: 0x007C21AE File Offset: 0x007C03AE
	public CameraEvent DOPDFKGDPIA()
	{
		return (CameraEvent)(-57);
	}

	// Token: 0x06011607 RID: 71175 RVA: 0x007C21B2 File Offset: 0x007C03B2
	public string PMHIIDBGJDG()
	{
		return "ShotgunReloadChamber";
	}

	// Token: 0x06011608 RID: 71176 RVA: 0x007C21B9 File Offset: 0x007C03B9
	public bool NEBBCDKDNOE()
	{
		return !base.BBEPCCALAFC.enabled || !this.AMCOGJHPPOC.MDGMGJOKFCL() || !RenderSettings.fog || this.AMCOGJHPPOC.ANFINECKHNH();
	}

	// Token: 0x06011609 RID: 71177 RVA: 0x007C21EC File Offset: 0x007C03EC
	public string PBCDAEFPOAD()
	{
		return "delaccconfirm";
	}

	// Token: 0x0601160A RID: 71178 RVA: 0x007C21F3 File Offset: 0x007C03F3
	public string NMKIECJGKLK()
	{
		return "[/quote]";
	}

	// Token: 0x0601160B RID: 71179 RVA: 0x007C21FA File Offset: 0x007C03FA
	public bool PKNNDJIIMPB()
	{
		return base.BBEPCCALAFC.enabled && this.AMCOGJHPPOC.LEIJCKEIMGH() && RenderSettings.fog && !this.AMCOGJHPPOC.MLJCADOONGI();
	}

	// Token: 0x0601160C RID: 71180 RVA: 0x007C2230 File Offset: 0x007C0430
	public void EEHCLNALFGH(CommandBuffer ECKPLMDEJFD)
	{
		FogModel.Settings settings = base.BBEPCCALAFC.KOMEDFGKGGE();
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.JNKAJCFJHIP("_camHue");
		material.shaderKeywords = null;
		Color value = CDBICMCJFCE.AIDPGNAEOMF ? RenderSettings.fogColor.linear : RenderSettings.fogColor;
		material.SetColor(BJKFKMLPPKK.LBDKMKJPLOG.BOCBPADFMLH, value);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.INEPNGJKCOF, RenderSettings.fogDensity);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.FAAPIGHAFHJ, RenderSettings.fogStartDistance);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.HGKPMOLMOHH, RenderSettings.fogEndDistance);
		switch (RenderSettings.fogMode)
		{
		case FogMode.Linear:
			material.EnableKeyword("</color>");
			break;
		case FogMode.Exponential:
			material.EnableKeyword("cht_msg4");
			break;
		case FogMode.ExponentialSquared:
			material.EnableKeyword("name");
			break;
		}
		RenderTextureFormat format = this.AMCOGJHPPOC.PIGJFLMCLBC() ? ((RenderTextureFormat)32) : RenderTextureFormat.ARGB32;
		ECKPLMDEJFD.GetTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, this.AMCOGJHPPOC.LJJOEDIJPEM(), this.AMCOGJHPPOC.LKLNPJICOHH(), -125, FilterMode.Bilinear, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.PrepassLight, BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
		ECKPLMDEJFD.Blit(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, BuiltinRenderTextureType.CameraTarget, material, settings.excludeSkybox ? 1 : 0);
		ECKPLMDEJFD.ReleaseTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
	}

	// Token: 0x0601160D RID: 71181 RVA: 0x000EADB7 File Offset: 0x000E8FB7
	public DepthTextureMode LOIKOGHIIGG()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x0601160E RID: 71182 RVA: 0x007C237E File Offset: 0x007C057E
	public string DAGCFAPFAHA()
	{
		return "https://www.youtube.com/watch?v=eP9-zycoHLk";
	}

	// Token: 0x0601160F RID: 71183 RVA: 0x007C2385 File Offset: 0x007C0585
	public bool LPPEEIGELKA()
	{
		return base.BBEPCCALAFC.enabled && this.AMCOGJHPPOC.OFHANPNPEEJ() && RenderSettings.fog && !this.AMCOGJHPPOC.POJLMOPEBLN();
	}

	// Token: 0x06011610 RID: 71184 RVA: 0x007C23B8 File Offset: 0x007C05B8
	public CameraEvent PFNAGKCMMJE()
	{
		return (CameraEvent)(-28);
	}

	// Token: 0x06011611 RID: 71185 RVA: 0x000EB372 File Offset: 0x000E9572
	public DepthTextureMode CIOAGALLBDC()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x06011612 RID: 71186 RVA: 0x007C23BC File Offset: 0x007C05BC
	public void GEGJIDKHEDG(CommandBuffer ECKPLMDEJFD)
	{
		FogModel.Settings settings = base.BBEPCCALAFC.KFELKKMJJHI();
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.NADANHHBOLO("SwimDogPaddle");
		material.shaderKeywords = null;
		Color value = CDBICMCJFCE.AIDPGNAEOMF ? RenderSettings.fogColor.linear : RenderSettings.fogColor;
		material.SetColor(BJKFKMLPPKK.LBDKMKJPLOG.BOCBPADFMLH, value);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.INEPNGJKCOF, RenderSettings.fogDensity);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.FAAPIGHAFHJ, RenderSettings.fogStartDistance);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.HGKPMOLMOHH, RenderSettings.fogEndDistance);
		switch (RenderSettings.fogMode)
		{
		case (FogMode)0:
			material.EnableKeyword("---------- NetManager is init");
			break;
		case FogMode.Linear:
			material.EnableKeyword("_TrStartYou.ogg");
			break;
		case FogMode.Exponential:
			material.EnableKeyword("crft_selwpn");
			break;
		}
		RenderTextureFormat format = this.AMCOGJHPPOC.DLFNPFAGPFC() ? ((RenderTextureFormat)46) : RenderTextureFormat.ARGB1555;
		ECKPLMDEJFD.GetTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, this.AMCOGJHPPOC.KDBADMLHBNP(), this.AMCOGJHPPOC.HJOKFIGACEC(), -73, FilterMode.Bilinear, format);
		ECKPLMDEJFD.Blit((BuiltinRenderTextureType)6, BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
		ECKPLMDEJFD.Blit(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, BuiltinRenderTextureType.CurrentActive, material, settings.excludeSkybox ? 0 : 0);
		ECKPLMDEJFD.ReleaseTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
	}

	// Token: 0x06011613 RID: 71187 RVA: 0x000EADB7 File Offset: 0x000E8FB7
	public DepthTextureMode OKIFBAHGNMI()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x06011614 RID: 71188 RVA: 0x007C250C File Offset: 0x007C070C
	public void GIGMPGOOJAI(CommandBuffer ECKPLMDEJFD)
	{
		FogModel.Settings settings = base.BBEPCCALAFC.FHNOKJFHJJJ();
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.NADANHHBOLO("\n");
		material.shaderKeywords = null;
		Color value = CDBICMCJFCE.AIDPGNAEOMF ? RenderSettings.fogColor.linear : RenderSettings.fogColor;
		material.SetColor(BJKFKMLPPKK.LBDKMKJPLOG.BOCBPADFMLH, value);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.INEPNGJKCOF, RenderSettings.fogDensity);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.FAAPIGHAFHJ, RenderSettings.fogStartDistance);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.HGKPMOLMOHH, RenderSettings.fogEndDistance);
		switch (RenderSettings.fogMode)
		{
		case FogMode.Linear:
			material.EnableKeyword(", ");
			break;
		case FogMode.Exponential:
			material.EnableKeyword("othermenu");
			break;
		case FogMode.ExponentialSquared:
			material.EnableKeyword("_Gain");
			break;
		}
		RenderTextureFormat format = this.AMCOGJHPPOC.MAIODKMOICL ? ((RenderTextureFormat)(-50)) : RenderTextureFormat.ARGBHalf;
		ECKPLMDEJFD.GetTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, this.AMCOGJHPPOC.LJJOEDIJPEM(), this.AMCOGJHPPOC.GHMBALIHBOH(), -25, FilterMode.Bilinear, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.ResolvedDepth, BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
		ECKPLMDEJFD.Blit(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, BuiltinRenderTextureType.CameraTarget, material, settings.excludeSkybox ? 1 : 0);
		ECKPLMDEJFD.ReleaseTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
	}

	// Token: 0x06011615 RID: 71189 RVA: 0x007C265A File Offset: 0x007C085A
	public string NEFIKBBKFFI()
	{
		return "StShopWindow";
	}

	// Token: 0x06011616 RID: 71190 RVA: 0x007C2661 File Offset: 0x007C0861
	public CameraEvent HICBBLJNLNK()
	{
		return (CameraEvent)25;
	}

	// Token: 0x06011617 RID: 71191 RVA: 0x007C2665 File Offset: 0x007C0865
	public CameraEvent HMMNOLEIOFB()
	{
		return (CameraEvent)(-121);
	}

	// Token: 0x06011618 RID: 71192 RVA: 0x007C2669 File Offset: 0x007C0869
	public bool KCMKDGLNNPM()
	{
		return !base.BBEPCCALAFC.enabled || !this.AMCOGJHPPOC.KOIKCDLDJPD() || !RenderSettings.fog || !this.AMCOGJHPPOC.MOEPEAMLCKE();
	}

	// Token: 0x06011619 RID: 71193 RVA: 0x000EB372 File Offset: 0x000E9572
	public DepthTextureMode JNKKPIIAMBD()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x0601161A RID: 71194 RVA: 0x007C269C File Offset: 0x007C089C
	public CameraEvent KMMEEGPFLMA()
	{
		return (CameraEvent)(-51);
	}

	// Token: 0x0601161B RID: 71195 RVA: 0x007C26A0 File Offset: 0x007C08A0
	public void BOLICCLIPOB(CommandBuffer ECKPLMDEJFD)
	{
		FogModel.Settings settings = base.BBEPCCALAFC.PNNGLBOIIMH();
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.MLFKHMPHIGN("post_1");
		material.shaderKeywords = null;
		Color value = CDBICMCJFCE.AIDPGNAEOMF ? RenderSettings.fogColor.linear : RenderSettings.fogColor;
		material.SetColor(BJKFKMLPPKK.LBDKMKJPLOG.BOCBPADFMLH, value);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.INEPNGJKCOF, RenderSettings.fogDensity);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.FAAPIGHAFHJ, RenderSettings.fogStartDistance);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.HGKPMOLMOHH, RenderSettings.fogEndDistance);
		switch (RenderSettings.fogMode)
		{
		case FogMode.Linear:
			material.EnableKeyword("IdleDie");
			break;
		case FogMode.Exponential:
			material.EnableKeyword(" <b>®</b></color> ");
			break;
		case FogMode.ExponentialSquared:
			material.EnableKeyword("clavicle");
			break;
		}
		RenderTextureFormat format = this.AMCOGJHPPOC.JFIIMCOAHFG() ? ((RenderTextureFormat)(-39)) : RenderTextureFormat.Depth;
		ECKPLMDEJFD.GetTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, this.AMCOGJHPPOC.LJJOEDIJPEM(), this.AMCOGJHPPOC.LPJJBJCIELA(), 22, FilterMode.Point, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.None, BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
		ECKPLMDEJFD.Blit(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, BuiltinRenderTextureType.PrepassLight, material, settings.excludeSkybox ? 1 : 1);
		ECKPLMDEJFD.ReleaseTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
	}

	// Token: 0x0601161C RID: 71196 RVA: 0x000EB372 File Offset: 0x000E9572
	public DepthTextureMode JPPBBACPJAB()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x0601161D RID: 71197 RVA: 0x007C27EE File Offset: 0x007C09EE
	public CameraEvent DBCHOMGEHMO()
	{
		return (CameraEvent)124;
	}

	// Token: 0x0601161E RID: 71198 RVA: 0x007C27F2 File Offset: 0x007C09F2
	public bool MJPDFPDEDHN()
	{
		return !base.BBEPCCALAFC.enabled || !this.AMCOGJHPPOC.GLJKDPBAPKJ || !RenderSettings.fog || !this.AMCOGJHPPOC.HALNOLGLEOJ();
	}

	// Token: 0x0601161F RID: 71199 RVA: 0x007C2828 File Offset: 0x007C0A28
	public void BAMLNGPPPMC(CommandBuffer ECKPLMDEJFD)
	{
		FogModel.Settings settings = base.BBEPCCALAFC.FHOBFCBNPOC();
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.OFIEMCNMGHM("");
		material.shaderKeywords = null;
		Color value = CDBICMCJFCE.AIDPGNAEOMF ? RenderSettings.fogColor.linear : RenderSettings.fogColor;
		material.SetColor(BJKFKMLPPKK.LBDKMKJPLOG.BOCBPADFMLH, value);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.INEPNGJKCOF, RenderSettings.fogDensity);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.FAAPIGHAFHJ, RenderSettings.fogStartDistance);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.HGKPMOLMOHH, RenderSettings.fogEndDistance);
		switch (RenderSettings.fogMode)
		{
		case FogMode.Linear:
			material.EnableKeyword("_INFO");
			break;
		case FogMode.Exponential:
			material.EnableKeyword("☣ ");
			break;
		case FogMode.ExponentialSquared:
			material.EnableKeyword("root");
			break;
		}
		RenderTextureFormat format = this.AMCOGJHPPOC.HCHNHOFPIFK() ? ((RenderTextureFormat)(-118)) : RenderTextureFormat.ARGB4444;
		ECKPLMDEJFD.GetTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, this.AMCOGJHPPOC.OJNDCCHLMNK(), this.AMCOGJHPPOC.HJOKFIGACEC(), -41, FilterMode.Bilinear, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.CurrentActive, BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
		ECKPLMDEJFD.Blit(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, (BuiltinRenderTextureType)6, material, settings.excludeSkybox ? 1 : 0);
		ECKPLMDEJFD.ReleaseTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
	}

	// Token: 0x06011620 RID: 71200 RVA: 0x000EADB7 File Offset: 0x000E8FB7
	public DepthTextureMode KKECMCDBNJG()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x06011621 RID: 71201 RVA: 0x000EB372 File Offset: 0x000E9572
	public DepthTextureMode IKLLDGGEDBC()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x170003CB RID: 971
	// (get) Token: 0x06011622 RID: 71202 RVA: 0x007C2976 File Offset: 0x007C0B76
	public override bool NLFEIOCKHKA
	{
		get
		{
			return base.BBEPCCALAFC.enabled && this.AMCOGJHPPOC.GLJKDPBAPKJ && RenderSettings.fog && !this.AMCOGJHPPOC.CFABOAAPLPI;
		}
	}

	// Token: 0x06011623 RID: 71203 RVA: 0x007C29A9 File Offset: 0x007C0BA9
	public CameraEvent EJJAHMOIOEO()
	{
		return (CameraEvent)107;
	}

	// Token: 0x06011625 RID: 71205 RVA: 0x000EB372 File Offset: 0x000E9572
	public DepthTextureMode ONDDNAKPJNI()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x06011626 RID: 71206 RVA: 0x007C29B5 File Offset: 0x007C0BB5
	public CameraEvent KCALGPIMBHE()
	{
		return (CameraEvent)76;
	}

	// Token: 0x06011627 RID: 71207 RVA: 0x000EB372 File Offset: 0x000E9572
	public DepthTextureMode DDNBCODMMCP()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x06011628 RID: 71208 RVA: 0x000EADB7 File Offset: 0x000E8FB7
	public DepthTextureMode GGGLFFGBDLM()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x06011629 RID: 71209 RVA: 0x007C29BC File Offset: 0x007C0BBC
	public void LNDMCHDBKDF(CommandBuffer ECKPLMDEJFD)
	{
		FogModel.Settings settings = base.BBEPCCALAFC.KHHBMADLJLH();
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.GJOHODHDPDN("{0}");
		material.shaderKeywords = null;
		Color value = CDBICMCJFCE.AIDPGNAEOMF ? RenderSettings.fogColor.linear : RenderSettings.fogColor;
		material.SetColor(BJKFKMLPPKK.LBDKMKJPLOG.BOCBPADFMLH, value);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.INEPNGJKCOF, RenderSettings.fogDensity);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.FAAPIGHAFHJ, RenderSettings.fogStartDistance);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.HGKPMOLMOHH, RenderSettings.fogEndDistance);
		switch (RenderSettings.fogMode)
		{
		case FogMode.Linear:
			material.EnableKeyword("1");
			break;
		case FogMode.Exponential:
			material.EnableKeyword("PaperTurn.wav");
			break;
		case FogMode.ExponentialSquared:
			material.EnableKeyword("GiantGrabIdle");
			break;
		}
		RenderTextureFormat format = this.AMCOGJHPPOC.NNILENLPFDO() ? ((RenderTextureFormat)101) : RenderTextureFormat.ARGB32;
		ECKPLMDEJFD.GetTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, this.AMCOGJHPPOC.OCNEHBGMHGB(), this.AMCOGJHPPOC.LKLNPJICOHH(), 82, FilterMode.Point, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.PrepassLight, BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
		ECKPLMDEJFD.Blit(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, BuiltinRenderTextureType.DepthNormals, material, settings.excludeSkybox ? 0 : 0);
		ECKPLMDEJFD.ReleaseTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
	}

	// Token: 0x0601162A RID: 71210 RVA: 0x007C2B0A File Offset: 0x007C0D0A
	public bool EFOGKBEBNHC()
	{
		return base.BBEPCCALAFC.enabled && this.AMCOGJHPPOC.KFIJMIGOJEJ() && RenderSettings.fog && !this.AMCOGJHPPOC.HKJHMGJGNHJ();
	}

	// Token: 0x0601162B RID: 71211 RVA: 0x007C2B3D File Offset: 0x007C0D3D
	public string AJMINCEJCAD()
	{
		return "achive_text";
	}

	// Token: 0x0601162C RID: 71212 RVA: 0x007C2B44 File Offset: 0x007C0D44
	public CameraEvent FHAJEKFKIFO()
	{
		return CameraEvent.BeforeImageEffects;
	}

	// Token: 0x0601162D RID: 71213 RVA: 0x007C2B48 File Offset: 0x007C0D48
	public string EHDBEKEJCIB()
	{
		return "WeaponStrafeRunRight";
	}

	// Token: 0x0601162E RID: 71214 RVA: 0x000EB372 File Offset: 0x000E9572
	public DepthTextureMode APIPFLOFHAB()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x0601162F RID: 71215 RVA: 0x007C2B4F File Offset: 0x007C0D4F
	public CameraEvent NNLPEKLCPKN()
	{
		return (CameraEvent)(-117);
	}

	// Token: 0x06011630 RID: 71216 RVA: 0x007C2B54 File Offset: 0x007C0D54
	public void DJBADNDMBAG(CommandBuffer ECKPLMDEJFD)
	{
		FogModel.Settings settings = base.BBEPCCALAFC.HFHIAGLALPI();
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.HPAJGFGNMOH("CCDIK not found!");
		material.shaderKeywords = null;
		Color value = CDBICMCJFCE.AIDPGNAEOMF ? RenderSettings.fogColor.linear : RenderSettings.fogColor;
		material.SetColor(BJKFKMLPPKK.LBDKMKJPLOG.BOCBPADFMLH, value);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.INEPNGJKCOF, RenderSettings.fogDensity);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.FAAPIGHAFHJ, RenderSettings.fogStartDistance);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.HGKPMOLMOHH, RenderSettings.fogEndDistance);
		switch (RenderSettings.fogMode)
		{
		case (FogMode)0:
			material.EnableKeyword("_NoiseTex");
			break;
		case FogMode.Linear:
			material.EnableKeyword("demoColor");
			break;
		case FogMode.Exponential:
			material.EnableKeyword("demoByteArray");
			break;
		}
		RenderTextureFormat format = this.AMCOGJHPPOC.FPIAHOMIEJP() ? ((RenderTextureFormat)(-8)) : RenderTextureFormat.ARGB2101010;
		ECKPLMDEJFD.GetTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, this.AMCOGJHPPOC.KDBADMLHBNP(), this.AMCOGJHPPOC.FHCDJOLMIMG(), -55, FilterMode.Point, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.PrepassNormalsSpec, BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
		ECKPLMDEJFD.Blit(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, (BuiltinRenderTextureType)6, material, settings.excludeSkybox ? 0 : 0);
		ECKPLMDEJFD.ReleaseTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
	}

	// Token: 0x06011631 RID: 71217 RVA: 0x000EADB7 File Offset: 0x000E8FB7
	public DepthTextureMode EGKCKLLKDOJ()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x06011632 RID: 71218 RVA: 0x007C2CA2 File Offset: 0x007C0EA2
	public bool GINFOAMILDE()
	{
		return base.BBEPCCALAFC.enabled && this.AMCOGJHPPOC.GLJKDPBAPKJ && RenderSettings.fog && !this.AMCOGJHPPOC.HKJHMGJGNHJ();
	}

	// Token: 0x06011633 RID: 71219 RVA: 0x007C2CD8 File Offset: 0x007C0ED8
	public void DGPJLAOONIK(CommandBuffer ECKPLMDEJFD)
	{
		FogModel.Settings settings = base.BBEPCCALAFC.LMEKEGJMPBN();
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.DLNFGMANLPN("gi_fs_itm");
		material.shaderKeywords = null;
		Color value = CDBICMCJFCE.AIDPGNAEOMF ? RenderSettings.fogColor.linear : RenderSettings.fogColor;
		material.SetColor(BJKFKMLPPKK.LBDKMKJPLOG.BOCBPADFMLH, value);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.INEPNGJKCOF, RenderSettings.fogDensity);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.FAAPIGHAFHJ, RenderSettings.fogStartDistance);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.HGKPMOLMOHH, RenderSettings.fogEndDistance);
		switch (RenderSettings.fogMode)
		{
		case FogMode.Linear:
			material.EnableKeyword("http://www.root-motion.com/finalikdox/html/page7.html");
			break;
		case FogMode.Exponential:
			material.EnableKeyword("OPEN CONSTRUCT");
			break;
		case FogMode.ExponentialSquared:
			material.EnableKeyword("");
			break;
		}
		RenderTextureFormat format = this.AMCOGJHPPOC.OEGOBDJNFOO() ? RenderTextureFormat.ARGB64 : RenderTextureFormat.ARGB4444;
		ECKPLMDEJFD.GetTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, this.AMCOGJHPPOC.IGHJHMGOGOO(), this.AMCOGJHPPOC.CICDECHCDBJ(), -62, FilterMode.Point, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.PrepassNormalsSpec, BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
		ECKPLMDEJFD.Blit(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, BuiltinRenderTextureType.ResolvedDepth, material, settings.excludeSkybox ? 0 : 0);
		ECKPLMDEJFD.ReleaseTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
	}

	// Token: 0x06011634 RID: 71220 RVA: 0x000EB372 File Offset: 0x000E9572
	public DepthTextureMode FFLADCCBOLM()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x06011635 RID: 71221 RVA: 0x000EB372 File Offset: 0x000E9572
	public DepthTextureMode AHCAOHDOENP()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x06011636 RID: 71222 RVA: 0x007C2E28 File Offset: 0x007C1028
	public void MKPENFJBJBG(CommandBuffer ECKPLMDEJFD)
	{
		FogModel.Settings settings = base.BBEPCCALAFC.IHEEFJOMFKE();
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.HPAJGFGNMOH("_TrNewLider.ogg");
		material.shaderKeywords = null;
		Color value = CDBICMCJFCE.AIDPGNAEOMF ? RenderSettings.fogColor.linear : RenderSettings.fogColor;
		material.SetColor(BJKFKMLPPKK.LBDKMKJPLOG.BOCBPADFMLH, value);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.INEPNGJKCOF, RenderSettings.fogDensity);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.FAAPIGHAFHJ, RenderSettings.fogStartDistance);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.HGKPMOLMOHH, RenderSettings.fogEndDistance);
		switch (RenderSettings.fogMode)
		{
		case FogMode.Linear:
			material.EnableKeyword("1HandSmallWeaponCombo");
			break;
		case FogMode.Exponential:
			material.EnableKeyword(" x");
			break;
		case FogMode.ExponentialSquared:
			material.EnableKeyword("_HorizonColor");
			break;
		}
		RenderTextureFormat format = this.AMCOGJHPPOC.PIGJFLMCLBC() ? ((RenderTextureFormat)(-30)) : RenderTextureFormat.ARGB2101010;
		ECKPLMDEJFD.GetTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, this.AMCOGJHPPOC.DHPPGHBNDEB(), this.AMCOGJHPPOC.HJOKFIGACEC(), -49, FilterMode.Point, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.ResolvedDepth, BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
		ECKPLMDEJFD.Blit(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, BuiltinRenderTextureType.CurrentActive, material, settings.excludeSkybox ? 1 : 0);
		ECKPLMDEJFD.ReleaseTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
	}

	// Token: 0x06011637 RID: 71223 RVA: 0x007C2F78 File Offset: 0x007C1178
	public void EDEABFMIAHI(CommandBuffer ECKPLMDEJFD)
	{
		FogModel.Settings settings = base.BBEPCCALAFC.JOAPKCFMLDO();
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.PIPNAHLJKKD("_info");
		material.shaderKeywords = null;
		Color value = CDBICMCJFCE.AIDPGNAEOMF ? RenderSettings.fogColor.linear : RenderSettings.fogColor;
		material.SetColor(BJKFKMLPPKK.LBDKMKJPLOG.BOCBPADFMLH, value);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.INEPNGJKCOF, RenderSettings.fogDensity);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.FAAPIGHAFHJ, RenderSettings.fogStartDistance);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.HGKPMOLMOHH, RenderSettings.fogEndDistance);
		switch (RenderSettings.fogMode)
		{
		case (FogMode)0:
			material.EnableKeyword("fshop_header");
			break;
		case FogMode.Linear:
			material.EnableKeyword("");
			break;
		case FogMode.Exponential:
			material.EnableKeyword("");
			break;
		}
		RenderTextureFormat format = this.AMCOGJHPPOC.JFIIMCOAHFG() ? ((RenderTextureFormat)54) : RenderTextureFormat.Depth;
		ECKPLMDEJFD.GetTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, this.AMCOGJHPPOC.NMCCGCOKKFA(), this.AMCOGJHPPOC.GHMBALIHBOH(), -78, FilterMode.Bilinear, format);
		ECKPLMDEJFD.Blit((BuiltinRenderTextureType)6, BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
		ECKPLMDEJFD.Blit(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, BuiltinRenderTextureType.CurrentActive, material, settings.excludeSkybox ? 0 : 0);
		ECKPLMDEJFD.ReleaseTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
	}

	// Token: 0x06011638 RID: 71224 RVA: 0x000EADB7 File Offset: 0x000E8FB7
	public DepthTextureMode HKFPGOAPEBL()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x06011639 RID: 71225 RVA: 0x007C30C6 File Offset: 0x007C12C6
	public bool EFIFCCPAGHI()
	{
		return !base.BBEPCCALAFC.enabled || !this.AMCOGJHPPOC.KOIKCDLDJPD() || !RenderSettings.fog || !this.AMCOGJHPPOC.CFABOAAPLPI;
	}

	// Token: 0x0601163A RID: 71226 RVA: 0x007C30F9 File Offset: 0x007C12F9
	public string GGBAALBEJAF()
	{
		return "delacc";
	}

	// Token: 0x0601163B RID: 71227 RVA: 0x000EADB7 File Offset: 0x000E8FB7
	public DepthTextureMode NCMLEHGFLOD()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x0601163C RID: 71228 RVA: 0x007C3100 File Offset: 0x007C1300
	public void JKLCICLJMBA(CommandBuffer ECKPLMDEJFD)
	{
		FogModel.Settings settings = base.BBEPCCALAFC.KENLLEDCEHC();
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.JKBKMPBBGBA("_Axis");
		material.shaderKeywords = null;
		Color value = CDBICMCJFCE.AIDPGNAEOMF ? RenderSettings.fogColor.linear : RenderSettings.fogColor;
		material.SetColor(BJKFKMLPPKK.LBDKMKJPLOG.BOCBPADFMLH, value);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.INEPNGJKCOF, RenderSettings.fogDensity);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.FAAPIGHAFHJ, RenderSettings.fogStartDistance);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.HGKPMOLMOHH, RenderSettings.fogEndDistance);
		switch (RenderSettings.fogMode)
		{
		case (FogMode)0:
			material.EnableKeyword("shop_t12");
			break;
		case FogMode.Linear:
			material.EnableKeyword("MotorbikeLassoFwd");
			break;
		case FogMode.Exponential:
			material.EnableKeyword("Bone");
			break;
		}
		RenderTextureFormat format = this.AMCOGJHPPOC.NNILENLPFDO() ? RenderTextureFormat.R8 : RenderTextureFormat.ARGB4444;
		ECKPLMDEJFD.GetTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, this.AMCOGJHPPOC.NMEBEEHCALN, this.AMCOGJHPPOC.CICDECHCDBJ(), 16, FilterMode.Bilinear, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.PrepassNormalsSpec, BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
		ECKPLMDEJFD.Blit(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, BuiltinRenderTextureType.PrepassNormalsSpec, material, settings.excludeSkybox ? 0 : 1);
		ECKPLMDEJFD.ReleaseTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
	}

	// Token: 0x0601163D RID: 71229 RVA: 0x007C324E File Offset: 0x007C144E
	public CameraEvent BGIGEICKJIH()
	{
		return (CameraEvent)(-12);
	}

	// Token: 0x0601163E RID: 71230 RVA: 0x007C3252 File Offset: 0x007C1452
	public override string KPGFOFFHPOO()
	{
		return "Fog";
	}

	// Token: 0x0601163F RID: 71231 RVA: 0x007C3259 File Offset: 0x007C1459
	public CameraEvent AGGFGEDHCMK()
	{
		return (CameraEvent)111;
	}

	// Token: 0x06011640 RID: 71232 RVA: 0x007C3260 File Offset: 0x007C1460
	public override void DNELHGGBBOO(CommandBuffer ECKPLMDEJFD)
	{
		FogModel.Settings settings = base.BBEPCCALAFC.settings;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.AFONGIICOJG("Hidden/Post FX/Fog");
		material.shaderKeywords = null;
		Color value = CDBICMCJFCE.AIDPGNAEOMF ? RenderSettings.fogColor.linear : RenderSettings.fogColor;
		material.SetColor(BJKFKMLPPKK.LBDKMKJPLOG.BOCBPADFMLH, value);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.INEPNGJKCOF, RenderSettings.fogDensity);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.FAAPIGHAFHJ, RenderSettings.fogStartDistance);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.HGKPMOLMOHH, RenderSettings.fogEndDistance);
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
		RenderTextureFormat format = this.AMCOGJHPPOC.MAIODKMOICL ? RenderTextureFormat.DefaultHDR : RenderTextureFormat.Default;
		ECKPLMDEJFD.GetTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, this.AMCOGJHPPOC.NMEBEEHCALN, this.AMCOGJHPPOC.ILLKFNCFGMP, 24, FilterMode.Bilinear, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.CameraTarget, BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
		ECKPLMDEJFD.Blit(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, BuiltinRenderTextureType.CameraTarget, material, settings.excludeSkybox ? 1 : 0);
		ECKPLMDEJFD.ReleaseTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
	}

	// Token: 0x06011641 RID: 71233 RVA: 0x007C33B0 File Offset: 0x007C15B0
	public void ACBMHAJOACB(CommandBuffer ECKPLMDEJFD)
	{
		FogModel.Settings settings = base.BBEPCCALAFC.EFCLGKFCEMI();
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.JKBKMPBBGBA("\n");
		material.shaderKeywords = null;
		Color value = CDBICMCJFCE.AIDPGNAEOMF ? RenderSettings.fogColor.linear : RenderSettings.fogColor;
		material.SetColor(BJKFKMLPPKK.LBDKMKJPLOG.BOCBPADFMLH, value);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.INEPNGJKCOF, RenderSettings.fogDensity);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.FAAPIGHAFHJ, RenderSettings.fogStartDistance);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.HGKPMOLMOHH, RenderSettings.fogEndDistance);
		switch (RenderSettings.fogMode)
		{
		case (FogMode)0:
			material.EnableKeyword("MotorbikeIdle");
			break;
		case FogMode.Linear:
			material.EnableKeyword("cntx_improve");
			break;
		case FogMode.Exponential:
			material.EnableKeyword("_Offsets");
			break;
		}
		RenderTextureFormat format = this.AMCOGJHPPOC.BLMBFAOCMNK() ? ((RenderTextureFormat)112) : RenderTextureFormat.ARGB4444;
		ECKPLMDEJFD.GetTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, this.AMCOGJHPPOC.IBPMMKDPDEO(), this.AMCOGJHPPOC.FHCDJOLMIMG(), -49, FilterMode.Bilinear, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.ResolvedDepth, BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
		ECKPLMDEJFD.Blit(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, BuiltinRenderTextureType.PrepassNormalsSpec, material, settings.excludeSkybox ? 0 : 0);
		ECKPLMDEJFD.ReleaseTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
	}

	// Token: 0x06011642 RID: 71234 RVA: 0x007C3500 File Offset: 0x007C1700
	public void JCGMBPEBIJF(CommandBuffer ECKPLMDEJFD)
	{
		FogModel.Settings settings = base.BBEPCCALAFC.OHGKBJANAKK();
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.NLFMCBBJHBD("The 'VAlign' command requires an alignment parameter of ? (default) or B (bottom).");
		material.shaderKeywords = null;
		Color value = CDBICMCJFCE.AIDPGNAEOMF ? RenderSettings.fogColor.linear : RenderSettings.fogColor;
		material.SetColor(BJKFKMLPPKK.LBDKMKJPLOG.BOCBPADFMLH, value);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.INEPNGJKCOF, RenderSettings.fogDensity);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.FAAPIGHAFHJ, RenderSettings.fogStartDistance);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.HGKPMOLMOHH, RenderSettings.fogEndDistance);
		switch (RenderSettings.fogMode)
		{
		case (FogMode)0:
			material.EnableKeyword("IK Effector is referencing to a bone '");
			break;
		case FogMode.Linear:
			material.EnableKeyword("R");
			break;
		case FogMode.Exponential:
			material.EnableKeyword("\n");
			break;
		}
		RenderTextureFormat format = this.AMCOGJHPPOC.NNILENLPFDO() ? ((RenderTextureFormat)(-52)) : RenderTextureFormat.Depth;
		ECKPLMDEJFD.GetTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, this.AMCOGJHPPOC.OJNDCCHLMNK(), this.AMCOGJHPPOC.CICDECHCDBJ(), -104, FilterMode.Bilinear, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.Depth, BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
		ECKPLMDEJFD.Blit(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, BuiltinRenderTextureType.CameraTarget, material, settings.excludeSkybox ? 0 : 0);
		ECKPLMDEJFD.ReleaseTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
	}

	// Token: 0x06011643 RID: 71235 RVA: 0x007C3650 File Offset: 0x007C1850
	public void CEIHOOLJPFP(CommandBuffer ECKPLMDEJFD)
	{
		FogModel.Settings settings = base.BBEPCCALAFC.BOLPFGAMAED();
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.HJFNEOFMJEJ("GestureCrowdPump");
		material.shaderKeywords = null;
		Color value = CDBICMCJFCE.AIDPGNAEOMF ? RenderSettings.fogColor.linear : RenderSettings.fogColor;
		material.SetColor(BJKFKMLPPKK.LBDKMKJPLOG.BOCBPADFMLH, value);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.INEPNGJKCOF, RenderSettings.fogDensity);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.FAAPIGHAFHJ, RenderSettings.fogStartDistance);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.HGKPMOLMOHH, RenderSettings.fogEndDistance);
		switch (RenderSettings.fogMode)
		{
		case FogMode.Linear:
			material.EnableKeyword("_alfavis");
			break;
		case FogMode.Exponential:
			material.EnableKeyword("ComeHere");
			break;
		case FogMode.ExponentialSquared:
			material.EnableKeyword(" should be overwritten.");
			break;
		}
		RenderTextureFormat format = this.AMCOGJHPPOC.BLMBFAOCMNK() ? ((RenderTextureFormat)60) : RenderTextureFormat.ARGBHalf;
		ECKPLMDEJFD.GetTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, this.AMCOGJHPPOC.NMCCGCOKKFA(), this.AMCOGJHPPOC.LPJJBJCIELA(), -113, FilterMode.Point, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.PrepassNormalsSpec, BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
		ECKPLMDEJFD.Blit(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, BuiltinRenderTextureType.None, material, settings.excludeSkybox ? 1 : 0);
		ECKPLMDEJFD.ReleaseTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
	}

	// Token: 0x06011644 RID: 71236 RVA: 0x007C379E File Offset: 0x007C199E
	public bool EABMDBKOBAF()
	{
		return base.BBEPCCALAFC.enabled && this.AMCOGJHPPOC.BMHMGNLEOED() && RenderSettings.fog && this.AMCOGJHPPOC.CHJAIAPCMDC();
	}

	// Token: 0x06011645 RID: 71237 RVA: 0x007C37D1 File Offset: 0x007C19D1
	public bool HMAFCBLHOPA()
	{
		return !base.BBEPCCALAFC.enabled || !this.AMCOGJHPPOC.GNOBCFOKNME() || !RenderSettings.fog || !this.AMCOGJHPPOC.MLJCADOONGI();
	}

	// Token: 0x06011646 RID: 71238 RVA: 0x007C3804 File Offset: 0x007C1A04
	public CameraEvent PBAFJDEGFDO()
	{
		return (CameraEvent)36;
	}

	// Token: 0x06011647 RID: 71239 RVA: 0x007C3808 File Offset: 0x007C1A08
	public CameraEvent KKCAOIBNKFI()
	{
		return (CameraEvent)(-78);
	}

	// Token: 0x06011648 RID: 71240 RVA: 0x007C380C File Offset: 0x007C1A0C
	public void LDIMLLBNBPE(CommandBuffer ECKPLMDEJFD)
	{
		FogModel.Settings settings = base.BBEPCCALAFC.AKCKLMKNOPD();
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.EIJMKFHFKDG(".unity3d");
		material.shaderKeywords = null;
		Color value = CDBICMCJFCE.AIDPGNAEOMF ? RenderSettings.fogColor.linear : RenderSettings.fogColor;
		material.SetColor(BJKFKMLPPKK.LBDKMKJPLOG.BOCBPADFMLH, value);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.INEPNGJKCOF, RenderSettings.fogDensity);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.FAAPIGHAFHJ, RenderSettings.fogStartDistance);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.HGKPMOLMOHH, RenderSettings.fogEndDistance);
		switch (RenderSettings.fogMode)
		{
		case (FogMode)0:
			material.EnableKeyword("Game saved with regular PlayerPrefs. Try to find and change saved data now (it's easy)!");
			break;
		case FogMode.Linear:
			material.EnableKeyword("_RayStepSize");
			break;
		case FogMode.Exponential:
			material.EnableKeyword("13");
			break;
		}
		RenderTextureFormat format = this.AMCOGJHPPOC.NNILENLPFDO() ? ((RenderTextureFormat)(-10)) : RenderTextureFormat.Shadowmap;
		ECKPLMDEJFD.GetTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, this.AMCOGJHPPOC.NMCCGCOKKFA(), this.AMCOGJHPPOC.NIEGJHLHEEB(), -107, FilterMode.Point, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.PrepassLight, BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
		ECKPLMDEJFD.Blit(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, BuiltinRenderTextureType.PrepassNormalsSpec, material, settings.excludeSkybox ? 0 : 1);
		ECKPLMDEJFD.ReleaseTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
	}

	// Token: 0x06011649 RID: 71241 RVA: 0x007C395A File Offset: 0x007C1B5A
	public CameraEvent APLFOBMBLAK()
	{
		return (CameraEvent)(-55);
	}

	// Token: 0x0601164A RID: 71242 RVA: 0x007C395E File Offset: 0x007C1B5E
	public CameraEvent KMLPPCLLMON()
	{
		return (CameraEvent)(-5);
	}

	// Token: 0x0601164B RID: 71243 RVA: 0x007C3962 File Offset: 0x007C1B62
	public string JEHPCMAJFMF()
	{
		return "Arm Flex 2";
	}

	// Token: 0x0601164C RID: 71244 RVA: 0x007C3969 File Offset: 0x007C1B69
	public CameraEvent FAFMJNHLGFP()
	{
		return (CameraEvent)60;
	}

	// Token: 0x0601164D RID: 71245 RVA: 0x007C3970 File Offset: 0x007C1B70
	public void BCOIGMACEFM(CommandBuffer ECKPLMDEJFD)
	{
		FogModel.Settings settings = base.BBEPCCALAFC.MPHDFJAHKAK();
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.OJFALDJIOHN("BlackSmithHammer");
		material.shaderKeywords = null;
		Color value = CDBICMCJFCE.AIDPGNAEOMF ? RenderSettings.fogColor.linear : RenderSettings.fogColor;
		material.SetColor(BJKFKMLPPKK.LBDKMKJPLOG.BOCBPADFMLH, value);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.INEPNGJKCOF, RenderSettings.fogDensity);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.FAAPIGHAFHJ, RenderSettings.fogStartDistance);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.HGKPMOLMOHH, RenderSettings.fogEndDistance);
		switch (RenderSettings.fogMode)
		{
		case FogMode.Linear:
			material.EnableKeyword("");
			break;
		case FogMode.Exponential:
			material.EnableKeyword("wpn_eat5");
			break;
		case FogMode.ExponentialSquared:
			material.EnableKeyword("isRun");
			break;
		}
		RenderTextureFormat format = this.AMCOGJHPPOC.OEGOBDJNFOO() ? ((RenderTextureFormat)(-72)) : RenderTextureFormat.ARGB2101010;
		ECKPLMDEJFD.GetTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, this.AMCOGJHPPOC.GMOLEDNNPEH(), this.AMCOGJHPPOC.CICDECHCDBJ(), 5, FilterMode.Bilinear, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.PrepassLight, BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
		ECKPLMDEJFD.Blit(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, BuiltinRenderTextureType.ResolvedDepth, material, settings.excludeSkybox ? 1 : 1);
		ECKPLMDEJFD.ReleaseTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
	}

	// Token: 0x0601164E RID: 71246 RVA: 0x007C3ABE File Offset: 0x007C1CBE
	public bool PPHKJEHAHKE()
	{
		return base.BBEPCCALAFC.enabled && this.AMCOGJHPPOC.PBKNAKJBLDD() && RenderSettings.fog && this.AMCOGJHPPOC.MLJCADOONGI();
	}

	// Token: 0x0601164F RID: 71247 RVA: 0x007C3AF1 File Offset: 0x007C1CF1
	public CameraEvent DFBCCHLBPAD()
	{
		return (CameraEvent)72;
	}

	// Token: 0x06011650 RID: 71248 RVA: 0x000EADB7 File Offset: 0x000E8FB7
	public DepthTextureMode GOMAGPIHEFP()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x06011651 RID: 71249 RVA: 0x007C3AF5 File Offset: 0x007C1CF5
	public string NNNIKGEDFAA()
	{
		return "---";
	}

	// Token: 0x06011652 RID: 71250 RVA: 0x007C3AFC File Offset: 0x007C1CFC
	public void AGHEPPNHCEA(CommandBuffer ECKPLMDEJFD)
	{
		FogModel.Settings settings = base.BBEPCCALAFC.DMJMEMIPKNM();
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.BDHEBJJGFGB("_ZTest");
		material.shaderKeywords = null;
		Color value = CDBICMCJFCE.AIDPGNAEOMF ? RenderSettings.fogColor.linear : RenderSettings.fogColor;
		material.SetColor(BJKFKMLPPKK.LBDKMKJPLOG.BOCBPADFMLH, value);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.INEPNGJKCOF, RenderSettings.fogDensity);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.FAAPIGHAFHJ, RenderSettings.fogStartDistance);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.HGKPMOLMOHH, RenderSettings.fogEndDistance);
		switch (RenderSettings.fogMode)
		{
		case (FogMode)0:
			material.EnableKeyword("upRodState");
			break;
		case FogMode.Linear:
			material.EnableKeyword(" is represented multiple times in BipedReferences eyes.");
			break;
		case FogMode.Exponential:
			material.EnableKeyword("MotorbikeHandstand");
			break;
		}
		RenderTextureFormat format = this.AMCOGJHPPOC.DLFNPFAGPFC() ? ((RenderTextureFormat)98) : RenderTextureFormat.Shadowmap;
		ECKPLMDEJFD.GetTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, this.AMCOGJHPPOC.GMOLEDNNPEH(), this.AMCOGJHPPOC.ILLKFNCFGMP, -21, FilterMode.Bilinear, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.ResolvedDepth, BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
		ECKPLMDEJFD.Blit(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, BuiltinRenderTextureType.CameraTarget, material, settings.excludeSkybox ? 0 : 0);
		ECKPLMDEJFD.ReleaseTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
	}

	// Token: 0x06011653 RID: 71251 RVA: 0x007C3C4C File Offset: 0x007C1E4C
	public void LOLMIIIFMDO(CommandBuffer ECKPLMDEJFD)
	{
		FogModel.Settings settings = base.BBEPCCALAFC.HFHIAGLALPI();
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.JKBKMPBBGBA("\n");
		material.shaderKeywords = null;
		Color value = CDBICMCJFCE.AIDPGNAEOMF ? RenderSettings.fogColor.linear : RenderSettings.fogColor;
		material.SetColor(BJKFKMLPPKK.LBDKMKJPLOG.BOCBPADFMLH, value);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.INEPNGJKCOF, RenderSettings.fogDensity);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.FAAPIGHAFHJ, RenderSettings.fogStartDistance);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.HGKPMOLMOHH, RenderSettings.fogEndDistance);
		switch (RenderSettings.fogMode)
		{
		case FogMode.Linear:
			material.EnableKeyword("_CenterRadius");
			break;
		case FogMode.Exponential:
			material.EnableKeyword("RollerBladeFrontFlip");
			break;
		case FogMode.ExponentialSquared:
			material.EnableKeyword("Hidden/Amplify Color/MaskBlend");
			break;
		}
		RenderTextureFormat format = this.AMCOGJHPPOC.OEGOBDJNFOO() ? ((RenderTextureFormat)(-99)) : RenderTextureFormat.ARGB2101010;
		ECKPLMDEJFD.GetTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, this.AMCOGJHPPOC.PAHBMDOJHKK(), this.AMCOGJHPPOC.LHPBMEDMNDO(), -120, FilterMode.Point, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.CurrentActive, BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
		ECKPLMDEJFD.Blit(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, BuiltinRenderTextureType.DepthNormals, material, settings.excludeSkybox ? 1 : 0);
		ECKPLMDEJFD.ReleaseTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
	}

	// Token: 0x06011654 RID: 71252 RVA: 0x000EB372 File Offset: 0x000E9572
	public DepthTextureMode LHFBLDHGOML()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x06011655 RID: 71253 RVA: 0x007C3D9A File Offset: 0x007C1F9A
	public CameraEvent JPHKPNBMKKB()
	{
		return (CameraEvent)(-114);
	}

	// Token: 0x06011656 RID: 71254 RVA: 0x007C3D9E File Offset: 0x007C1F9E
	public string LPDENGOCAOA()
	{
		return "fishcatch";
	}

	// Token: 0x06011657 RID: 71255 RVA: 0x007C3DA5 File Offset: 0x007C1FA5
	public string GKEFDPLMBID()
	{
		return "<b>ObscuredInt:</b> ";
	}

	// Token: 0x06011658 RID: 71256 RVA: 0x007C3DAC File Offset: 0x007C1FAC
	public string FOOCNEKGNML()
	{
		return "UnityEngine.Vector3";
	}

	// Token: 0x06011659 RID: 71257 RVA: 0x007C3DB3 File Offset: 0x007C1FB3
	public bool GBGLDDNCIGM()
	{
		return base.BBEPCCALAFC.enabled && this.AMCOGJHPPOC.PBKNAKJBLDD() && RenderSettings.fog && !this.AMCOGJHPPOC.DBAMKBECNIJ();
	}

	// Token: 0x0601165A RID: 71258 RVA: 0x007C3DE6 File Offset: 0x007C1FE6
	public string DCHECMKFOBN()
	{
		return "id";
	}

	// Token: 0x0601165B RID: 71259 RVA: 0x000EB372 File Offset: 0x000E9572
	public DepthTextureMode LJCGALJCPGP()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x0601165C RID: 71260 RVA: 0x007C3DED File Offset: 0x007C1FED
	public bool BJAIILKMCBK()
	{
		return base.BBEPCCALAFC.enabled && this.AMCOGJHPPOC.EKDILDKALON() && RenderSettings.fog && this.AMCOGJHPPOC.HALNOLGLEOJ();
	}

	// Token: 0x0601165D RID: 71261 RVA: 0x007C3E20 File Offset: 0x007C2020
	public bool LKCGDJDKBIN()
	{
		return !base.BBEPCCALAFC.enabled || !this.AMCOGJHPPOC.MDGMGJOKFCL() || !RenderSettings.fog || this.AMCOGJHPPOC.MLMGNHHAOHF();
	}

	// Token: 0x0601165E RID: 71262 RVA: 0x007C3E53 File Offset: 0x007C2053
	public bool DCPAEFLBLIB()
	{
		return base.BBEPCCALAFC.enabled && this.AMCOGJHPPOC.EKDILDKALON() && RenderSettings.fog && !this.AMCOGJHPPOC.FBCBNOGGGOH();
	}

	// Token: 0x0601165F RID: 71263 RVA: 0x007C3E88 File Offset: 0x007C2088
	public void HAEPACDOFBD(CommandBuffer ECKPLMDEJFD)
	{
		FogModel.Settings settings = base.BBEPCCALAFC.LMHFNCJGBMG();
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.HJFNEOFMJEJ("fshop_ks2");
		material.shaderKeywords = null;
		Color value = CDBICMCJFCE.AIDPGNAEOMF ? RenderSettings.fogColor.linear : RenderSettings.fogColor;
		material.SetColor(BJKFKMLPPKK.LBDKMKJPLOG.BOCBPADFMLH, value);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.INEPNGJKCOF, RenderSettings.fogDensity);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.FAAPIGHAFHJ, RenderSettings.fogStartDistance);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.HGKPMOLMOHH, RenderSettings.fogEndDistance);
		switch (RenderSettings.fogMode)
		{
		case (FogMode)0:
			material.EnableKeyword("{0} x {1}");
			break;
		case FogMode.Linear:
			material.EnableKeyword("<color='#a0ff60'>");
			break;
		case FogMode.Exponential:
			material.EnableKeyword("__Refraction");
			break;
		}
		RenderTextureFormat format = this.AMCOGJHPPOC.OEGOBDJNFOO() ? ((RenderTextureFormat)37) : RenderTextureFormat.ARGBHalf;
		ECKPLMDEJFD.GetTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, this.AMCOGJHPPOC.CFDHOKHCPOJ(), this.AMCOGJHPPOC.KNKKIHDHBFD(), 123, FilterMode.Point, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.CameraTarget, BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
		ECKPLMDEJFD.Blit(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, BuiltinRenderTextureType.PrepassNormalsSpec, material, settings.excludeSkybox ? 0 : 1);
		ECKPLMDEJFD.ReleaseTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
	}

	// Token: 0x06011660 RID: 71264 RVA: 0x007C3FD6 File Offset: 0x007C21D6
	public CameraEvent ACPGLJEKDFH()
	{
		return (CameraEvent)(-39);
	}

	// Token: 0x06011661 RID: 71265 RVA: 0x007C3FDA File Offset: 0x007C21DA
	public bool DEAIFFEHCND()
	{
		return !base.BBEPCCALAFC.enabled || !this.AMCOGJHPPOC.KOIKCDLDJPD() || !RenderSettings.fog || this.AMCOGJHPPOC.AFIPEFLJBBM();
	}

	// Token: 0x06011662 RID: 71266 RVA: 0x007C400D File Offset: 0x007C220D
	public string MICLKMFCNAE()
	{
		return "_Sensitivity";
	}

	// Token: 0x06011663 RID: 71267 RVA: 0x007C4014 File Offset: 0x007C2214
	public bool HKCMJIIALMC()
	{
		return !base.BBEPCCALAFC.enabled || !this.AMCOGJHPPOC.JLOKIEPCEGB() || !RenderSettings.fog || this.AMCOGJHPPOC.HALNOLGLEOJ();
	}

	// Token: 0x06011664 RID: 71268 RVA: 0x007C4048 File Offset: 0x007C2248
	public void JBLMKJKCNOK(CommandBuffer ECKPLMDEJFD)
	{
		FogModel.Settings settings = base.BBEPCCALAFC.OGAEBMPHAJF();
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.JKBKMPBBGBA("Roller Blade Grind Royale");
		material.shaderKeywords = null;
		Color value = CDBICMCJFCE.AIDPGNAEOMF ? RenderSettings.fogColor.linear : RenderSettings.fogColor;
		material.SetColor(BJKFKMLPPKK.LBDKMKJPLOG.BOCBPADFMLH, value);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.INEPNGJKCOF, RenderSettings.fogDensity);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.FAAPIGHAFHJ, RenderSettings.fogStartDistance);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.HGKPMOLMOHH, RenderSettings.fogEndDistance);
		switch (RenderSettings.fogMode)
		{
		case (FogMode)0:
			material.EnableKeyword("Warp index out of range.");
			break;
		case FogMode.Linear:
			material.EnableKeyword("_Histogram");
			break;
		case FogMode.Exponential:
			material.EnableKeyword("pf2m");
			break;
		}
		RenderTextureFormat format = this.AMCOGJHPPOC.BLMBFAOCMNK() ? ((RenderTextureFormat)46) : RenderTextureFormat.ARGB2101010;
		ECKPLMDEJFD.GetTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, this.AMCOGJHPPOC.GAIOLBJLPDL(), this.AMCOGJHPPOC.GGGEFNKEPDB(), 35, FilterMode.Bilinear, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.DepthNormals, BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
		ECKPLMDEJFD.Blit(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, BuiltinRenderTextureType.PrepassLight, material, settings.excludeSkybox ? 1 : 0);
		ECKPLMDEJFD.ReleaseTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
	}

	// Token: 0x06011665 RID: 71269 RVA: 0x007C4198 File Offset: 0x007C2398
	public void CGOACMAKFLI(CommandBuffer ECKPLMDEJFD)
	{
		FogModel.Settings settings = base.BBEPCCALAFC.PNNGLBOIIMH();
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.GJOHODHDPDN("Apply 3");
		material.shaderKeywords = null;
		Color value = CDBICMCJFCE.AIDPGNAEOMF ? RenderSettings.fogColor.linear : RenderSettings.fogColor;
		material.SetColor(BJKFKMLPPKK.LBDKMKJPLOG.BOCBPADFMLH, value);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.INEPNGJKCOF, RenderSettings.fogDensity);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.FAAPIGHAFHJ, RenderSettings.fogStartDistance);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.HGKPMOLMOHH, RenderSettings.fogEndDistance);
		switch (RenderSettings.fogMode)
		{
		case FogMode.Linear:
			material.EnableKeyword("IceHockeyShotLeft");
			break;
		case FogMode.Exponential:
			material.EnableKeyword("Name: ");
			break;
		case FogMode.ExponentialSquared:
			material.EnableKeyword("demoUint");
			break;
		}
		RenderTextureFormat format = this.AMCOGJHPPOC.OEGOBDJNFOO() ? ((RenderTextureFormat)(-89)) : RenderTextureFormat.ARGB2101010;
		ECKPLMDEJFD.GetTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, this.AMCOGJHPPOC.KJDPLLFIIBK(), this.AMCOGJHPPOC.NIEGJHLHEEB(), 31, FilterMode.Bilinear, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.DepthNormals, BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
		ECKPLMDEJFD.Blit(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, BuiltinRenderTextureType.PrepassNormalsSpec, material, settings.excludeSkybox ? 1 : 1);
		ECKPLMDEJFD.ReleaseTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
	}

	// Token: 0x06011666 RID: 71270 RVA: 0x007C42E8 File Offset: 0x007C24E8
	public void JDPJILECNNO(CommandBuffer ECKPLMDEJFD)
	{
		FogModel.Settings settings = base.BBEPCCALAFC.FHNBLOAHNPD();
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.IBMKEBEEFKP("WATER_REFLECTIVE");
		material.shaderKeywords = null;
		Color value = CDBICMCJFCE.AIDPGNAEOMF ? RenderSettings.fogColor.linear : RenderSettings.fogColor;
		material.SetColor(BJKFKMLPPKK.LBDKMKJPLOG.BOCBPADFMLH, value);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.INEPNGJKCOF, RenderSettings.fogDensity);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.FAAPIGHAFHJ, RenderSettings.fogStartDistance);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.HGKPMOLMOHH, RenderSettings.fogEndDistance);
		switch (RenderSettings.fogMode)
		{
		case (FogMode)0:
			material.EnableKeyword("wpn_eat1");
			break;
		case FogMode.Linear:
			material.EnableKeyword("wpn_cat1");
			break;
		case FogMode.Exponential:
			material.EnableKeyword("BowIdle");
			break;
		}
		RenderTextureFormat format = this.AMCOGJHPPOC.DLFNPFAGPFC() ? ((RenderTextureFormat)(-11)) : RenderTextureFormat.ARGB32;
		ECKPLMDEJFD.GetTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, this.AMCOGJHPPOC.GAIOLBJLPDL(), this.AMCOGJHPPOC.ILLKFNCFGMP, 126, FilterMode.Point, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.PrepassLight, BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
		ECKPLMDEJFD.Blit(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, BuiltinRenderTextureType.PrepassNormalsSpec, material, settings.excludeSkybox ? 0 : 1);
		ECKPLMDEJFD.ReleaseTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
	}

	// Token: 0x06011667 RID: 71271 RVA: 0x000FAFB0 File Offset: 0x000F91B0
	public string KJLIJBNDFBM()
	{
		return "";
	}

	// Token: 0x06011668 RID: 71272 RVA: 0x007C4436 File Offset: 0x007C2636
	public string PJFGEOKEJHF()
	{
		return "isFishOnRod";
	}

	// Token: 0x06011669 RID: 71273 RVA: 0x007C443D File Offset: 0x007C263D
	public bool MMBPGFLCCMI()
	{
		return base.BBEPCCALAFC.enabled && this.AMCOGJHPPOC.HDBIPEDBMCC() && RenderSettings.fog && !this.AMCOGJHPPOC.ANFINECKHNH();
	}

	// Token: 0x0601166A RID: 71274 RVA: 0x007C4470 File Offset: 0x007C2670
	public void LAICNEEFELF(CommandBuffer ECKPLMDEJFD)
	{
		FogModel.Settings settings = base.BBEPCCALAFC.BDPNPPMLHBM();
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.EIJMKFHFKDG("");
		material.shaderKeywords = null;
		Color value = CDBICMCJFCE.AIDPGNAEOMF ? RenderSettings.fogColor.linear : RenderSettings.fogColor;
		material.SetColor(BJKFKMLPPKK.LBDKMKJPLOG.BOCBPADFMLH, value);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.INEPNGJKCOF, RenderSettings.fogDensity);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.FAAPIGHAFHJ, RenderSettings.fogStartDistance);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.HGKPMOLMOHH, RenderSettings.fogEndDistance);
		switch (RenderSettings.fogMode)
		{
		case (FogMode)0:
			material.EnableKeyword("id");
			break;
		case FogMode.Linear:
			material.EnableKeyword("gi_letgoshe");
			break;
		case FogMode.Exponential:
			material.EnableKeyword("RHandPunch");
			break;
		}
		RenderTextureFormat format = this.AMCOGJHPPOC.NNILENLPFDO() ? ((RenderTextureFormat)69) : RenderTextureFormat.Depth;
		ECKPLMDEJFD.GetTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, this.AMCOGJHPPOC.OCNEHBGMHGB(), this.AMCOGJHPPOC.LHPBMEDMNDO(), -82, FilterMode.Bilinear, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.PrepassLight, BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
		ECKPLMDEJFD.Blit(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, BuiltinRenderTextureType.Depth, material, settings.excludeSkybox ? 1 : 1);
		ECKPLMDEJFD.ReleaseTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
	}

	// Token: 0x0601166B RID: 71275 RVA: 0x007C45C0 File Offset: 0x007C27C0
	public void NPJAONOOLHC(CommandBuffer ECKPLMDEJFD)
	{
		FogModel.Settings settings = base.BBEPCCALAFC.DOJLILFGNFM();
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.BDHEBJJGFGB("#url Sound ");
		material.shaderKeywords = null;
		Color value = CDBICMCJFCE.AIDPGNAEOMF ? RenderSettings.fogColor.linear : RenderSettings.fogColor;
		material.SetColor(BJKFKMLPPKK.LBDKMKJPLOG.BOCBPADFMLH, value);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.INEPNGJKCOF, RenderSettings.fogDensity);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.FAAPIGHAFHJ, RenderSettings.fogStartDistance);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.HGKPMOLMOHH, RenderSettings.fogEndDistance);
		switch (RenderSettings.fogMode)
		{
		case FogMode.Linear:
			material.EnableKeyword("");
			break;
		case FogMode.Exponential:
			material.EnableKeyword("rod_inf1");
			break;
		case FogMode.ExponentialSquared:
			material.EnableKeyword("_SampleMip");
			break;
		}
		RenderTextureFormat format = this.AMCOGJHPPOC.BACMPNMDHBL() ? ((RenderTextureFormat)72) : RenderTextureFormat.ARGBHalf;
		ECKPLMDEJFD.GetTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, this.AMCOGJHPPOC.GAIOLBJLPDL(), this.AMCOGJHPPOC.KNKKIHDHBFD(), -80, FilterMode.Bilinear, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.DepthNormals, BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
		ECKPLMDEJFD.Blit(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, BuiltinRenderTextureType.PrepassNormalsSpec, material, settings.excludeSkybox ? 1 : 0);
		ECKPLMDEJFD.ReleaseTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
	}

	// Token: 0x0601166C RID: 71276 RVA: 0x000EB372 File Offset: 0x000E9572
	public DepthTextureMode PNCFJENEMDP()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x0601166D RID: 71277 RVA: 0x007C4710 File Offset: 0x007C2910
	public void IJNNFEEEEII(CommandBuffer ECKPLMDEJFD)
	{
		FogModel.Settings settings = base.BBEPCCALAFC.FHOBFCBNPOC();
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.NNKCNLCNDNC("qname_");
		material.shaderKeywords = null;
		Color value = CDBICMCJFCE.AIDPGNAEOMF ? RenderSettings.fogColor.linear : RenderSettings.fogColor;
		material.SetColor(BJKFKMLPPKK.LBDKMKJPLOG.BOCBPADFMLH, value);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.INEPNGJKCOF, RenderSettings.fogDensity);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.FAAPIGHAFHJ, RenderSettings.fogStartDistance);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.HGKPMOLMOHH, RenderSettings.fogEndDistance);
		switch (RenderSettings.fogMode)
		{
		case FogMode.Linear:
			material.EnableKeyword("Cheer Knees");
			break;
		case FogMode.Exponential:
			material.EnableKeyword("inv_impr");
			break;
		case FogMode.ExponentialSquared:
			material.EnableKeyword("_DstBlend");
			break;
		}
		RenderTextureFormat format = this.AMCOGJHPPOC.BLMBFAOCMNK() ? ((RenderTextureFormat)(-11)) : RenderTextureFormat.ARGB32;
		ECKPLMDEJFD.GetTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, this.AMCOGJHPPOC.DJGCPIEOAFC(), this.AMCOGJHPPOC.CICDECHCDBJ(), 32, FilterMode.Bilinear, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.CameraTarget, BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
		ECKPLMDEJFD.Blit(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, BuiltinRenderTextureType.Depth, material, settings.excludeSkybox ? 0 : 1);
		ECKPLMDEJFD.ReleaseTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
	}

	// Token: 0x0601166E RID: 71278 RVA: 0x007C485E File Offset: 0x007C2A5E
	public CameraEvent AKGMEICBPLJ()
	{
		return (CameraEvent)(-75);
	}

	// Token: 0x0601166F RID: 71279 RVA: 0x000EADB7 File Offset: 0x000E8FB7
	public DepthTextureMode KPDMEKCECJD()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x06011670 RID: 71280 RVA: 0x000EADB7 File Offset: 0x000E8FB7
	public DepthTextureMode DPCKJICEDMB()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x06011671 RID: 71281 RVA: 0x007C4862 File Offset: 0x007C2A62
	public bool DLCMLAOJBFA()
	{
		return !base.BBEPCCALAFC.enabled || !this.AMCOGJHPPOC.PBKNAKJBLDD() || !RenderSettings.fog || this.AMCOGJHPPOC.DBAMKBECNIJ();
	}

	// Token: 0x06011672 RID: 71282 RVA: 0x000EADB7 File Offset: 0x000E8FB7
	public DepthTextureMode HDEDPBLMCBL()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x06011673 RID: 71283 RVA: 0x007A3649 File Offset: 0x007A1849
	public string CFHFEACMNJH()
	{
		return " ";
	}

	// Token: 0x06011674 RID: 71284 RVA: 0x007C4895 File Offset: 0x007C2A95
	public bool HCHAKMMIMDN()
	{
		return !base.BBEPCCALAFC.enabled || !this.AMCOGJHPPOC.JLOKIEPCEGB() || !RenderSettings.fog || !this.AMCOGJHPPOC.ACEEFEFOCDF();
	}

	// Token: 0x06011675 RID: 71285 RVA: 0x007C48C8 File Offset: 0x007C2AC8
	public void NMHNMMAHBKI(CommandBuffer ECKPLMDEJFD)
	{
		FogModel.Settings settings = base.BBEPCCALAFC.LIKDNAJFKMN();
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.LNIKJLLFLAO("_Offsets");
		material.shaderKeywords = null;
		Color value = CDBICMCJFCE.AIDPGNAEOMF ? RenderSettings.fogColor.linear : RenderSettings.fogColor;
		material.SetColor(BJKFKMLPPKK.LBDKMKJPLOG.BOCBPADFMLH, value);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.INEPNGJKCOF, RenderSettings.fogDensity);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.FAAPIGHAFHJ, RenderSettings.fogStartDistance);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.HGKPMOLMOHH, RenderSettings.fogEndDistance);
		switch (RenderSettings.fogMode)
		{
		case (FogMode)0:
			material.EnableKeyword("invn_rec7");
			break;
		case FogMode.Linear:
			material.EnableKeyword("btn_cancel");
			break;
		case FogMode.Exponential:
			material.EnableKeyword("_DayToNight");
			break;
		}
		RenderTextureFormat format = this.AMCOGJHPPOC.ANPIAKEADME() ? ((RenderTextureFormat)(-104)) : RenderTextureFormat.RGB565;
		ECKPLMDEJFD.GetTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, this.AMCOGJHPPOC.NMEBEEHCALN, this.AMCOGJHPPOC.HJOKFIGACEC(), -92, FilterMode.Point, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.PrepassLight, BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
		ECKPLMDEJFD.Blit(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, BuiltinRenderTextureType.Depth, material, settings.excludeSkybox ? 0 : 0);
		ECKPLMDEJFD.ReleaseTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
	}

	// Token: 0x06011676 RID: 71286 RVA: 0x007C4A18 File Offset: 0x007C2C18
	public void DNHJDHHPNGL(CommandBuffer ECKPLMDEJFD)
	{
		FogModel.Settings settings = base.BBEPCCALAFC.KHHBMADLJLH();
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.DGOMGBDLAFP("ObscuredBool vs bool, ");
		material.shaderKeywords = null;
		Color value = CDBICMCJFCE.AIDPGNAEOMF ? RenderSettings.fogColor.linear : RenderSettings.fogColor;
		material.SetColor(BJKFKMLPPKK.LBDKMKJPLOG.BOCBPADFMLH, value);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.INEPNGJKCOF, RenderSettings.fogDensity);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.FAAPIGHAFHJ, RenderSettings.fogStartDistance);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.HGKPMOLMOHH, RenderSettings.fogEndDistance);
		switch (RenderSettings.fogMode)
		{
		case (FogMode)0:
			material.EnableKeyword("__c");
			break;
		case FogMode.Linear:
			material.EnableKeyword("name");
			break;
		case FogMode.Exponential:
			material.EnableKeyword("FaceHit");
			break;
		}
		RenderTextureFormat format = this.AMCOGJHPPOC.BACMPNMDHBL() ? ((RenderTextureFormat)(-78)) : RenderTextureFormat.ARGB2101010;
		ECKPLMDEJFD.GetTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, this.AMCOGJHPPOC.GAIOLBJLPDL(), this.AMCOGJHPPOC.GGGEFNKEPDB(), 114, FilterMode.Bilinear, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.Depth, BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
		ECKPLMDEJFD.Blit(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, BuiltinRenderTextureType.ResolvedDepth, material, settings.excludeSkybox ? 0 : 0);
		ECKPLMDEJFD.ReleaseTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
	}

	// Token: 0x06011677 RID: 71287 RVA: 0x007C4B68 File Offset: 0x007C2D68
	public void DKCHOPLIFNE(CommandBuffer ECKPLMDEJFD)
	{
		FogModel.Settings settings = base.BBEPCCALAFC.JCNCKIKPIKG();
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.PIPNAHLJKKD("<color='#FF8C42'>[{2}]</color> <color='#FF8C42'>{0}: {1}</color>");
		material.shaderKeywords = null;
		Color value = CDBICMCJFCE.AIDPGNAEOMF ? RenderSettings.fogColor.linear : RenderSettings.fogColor;
		material.SetColor(BJKFKMLPPKK.LBDKMKJPLOG.BOCBPADFMLH, value);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.INEPNGJKCOF, RenderSettings.fogDensity);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.FAAPIGHAFHJ, RenderSettings.fogStartDistance);
		material.SetFloat(BJKFKMLPPKK.LBDKMKJPLOG.HGKPMOLMOHH, RenderSettings.fogEndDistance);
		switch (RenderSettings.fogMode)
		{
		case (FogMode)0:
			material.EnableKeyword("double: ");
			break;
		case FogMode.Linear:
			material.EnableKeyword("The font '");
			break;
		case FogMode.Exponential:
			material.EnableKeyword("_TintColor");
			break;
		}
		RenderTextureFormat format = this.AMCOGJHPPOC.ANPIAKEADME() ? ((RenderTextureFormat)(-127)) : RenderTextureFormat.ARGB2101010;
		ECKPLMDEJFD.GetTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, this.AMCOGJHPPOC.DHPPGHBNDEB(), this.AMCOGJHPPOC.FHCDJOLMIMG(), 99, FilterMode.Point, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.CameraTarget, BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
		ECKPLMDEJFD.Blit(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH, BuiltinRenderTextureType.PrepassLight, material, settings.excludeSkybox ? 1 : 0);
		ECKPLMDEJFD.ReleaseTemporaryRT(BJKFKMLPPKK.LBDKMKJPLOG.HMKDKKIOIAH);
	}

	// Token: 0x06011678 RID: 71288 RVA: 0x007C4CB6 File Offset: 0x007C2EB6
	public override CameraEvent POJFLMAFHEI()
	{
		return CameraEvent.AfterImageEffectsOpaque;
	}

	// Token: 0x04002452 RID: 9298
	private static string GOFANCALMLK = "Hidden/Post FX/Fog";

	// Token: 0x0200051F RID: 1311
	private static class LBDKMKJPLOG
	{
		// Token: 0x04002453 RID: 9299
		internal static readonly int BOCBPADFMLH = Shader.PropertyToID("_FogColor");

		// Token: 0x04002454 RID: 9300
		internal static readonly int INEPNGJKCOF = Shader.PropertyToID("_Density");

		// Token: 0x04002455 RID: 9301
		internal static readonly int FAAPIGHAFHJ = Shader.PropertyToID("_Start");

		// Token: 0x04002456 RID: 9302
		internal static readonly int HGKPMOLMOHH = Shader.PropertyToID("_End");

		// Token: 0x04002457 RID: 9303
		internal static readonly int HMKDKKIOIAH = Shader.PropertyToID("_TempRT");
	}
}
