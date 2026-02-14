using System;
using UnityEngine;

// Token: 0x0200003E RID: 62
[RequireComponent(typeof(Camera))]
[AddComponentMenu("Image Effects/FXAA")]
[ExecuteInEditMode]
public class FXAA : FXAAPostEffectsBase
{
	// Token: 0x06000EFE RID: 3838 RVA: 0x000995CF File Offset: 0x000977CF
	private void KFLDADCECHL()
	{
		if (this.LCBKJGFGGGF == null)
		{
			this.LCBKJGFGGGF = base.CJMHHPLIEGJ(this.BAKBIMBKKNP, this.LCBKJGFGGGF);
		}
	}

	// Token: 0x06000EFF RID: 3839 RVA: 0x000995F7 File Offset: 0x000977F7
	private void GKEBOCIFFBO()
	{
		if (this.LCBKJGFGGGF == null)
		{
			this.LCBKJGFGGGF = base.NPOGNEDIPMC(this.BAKBIMBKKNP, this.LCBKJGFGGGF);
		}
	}

	// Token: 0x06000F00 RID: 3840 RVA: 0x0009961F File Offset: 0x0009781F
	private void CFOAAPOPFAE()
	{
		if (this.LCBKJGFGGGF == null)
		{
			this.LCBKJGFGGGF = base.NELLKFGIJEC(this.BAKBIMBKKNP, this.LCBKJGFGGGF);
		}
	}

	// Token: 0x06000F01 RID: 3841 RVA: 0x00099647 File Offset: 0x00097847
	private void FDLCPCDBJJH()
	{
		if (this.LCBKJGFGGGF == null)
		{
			this.LCBKJGFGGGF = base.CheckShaderAndCreateMaterial(this.BAKBIMBKKNP, this.LCBKJGFGGGF);
		}
	}

	// Token: 0x06000F02 RID: 3842 RVA: 0x0009966F File Offset: 0x0009786F
	private void CBLGFOFHNPJ()
	{
		this.BAKBIMBKKNP = Shader.Find("Downsamp");
		this.NGIFNENNHIJ();
		base.CAJBFLHLLHL(false);
	}

	// Token: 0x06000F03 RID: 3843 RVA: 0x0009968F File Offset: 0x0009788F
	private void LMEJKAEIDCO()
	{
		this.BAKBIMBKKNP = Shader.Find("CardPlayerIdle");
		this.JLKEMPAHAMA();
		base.CheckSupport(true);
	}

	// Token: 0x06000F04 RID: 3844 RVA: 0x000996B0 File Offset: 0x000978B0
	public void PNEFMGMHLJE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		this.CFOAAPOPFAE();
		float num = 1351f / (float)Screen.width;
		float num2 = 1385f / (float)Screen.height;
		this.LCBKJGFGGGF.SetVector("value", new Vector4(num, num2, 544f, 1559f));
		this.LCBKJGFGGGF.SetVector("", new Vector4(num * 1092f, num2 * 799f, num * 1621f, num2 * 780f));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LCBKJGFGGGF);
	}

	// Token: 0x06000F05 RID: 3845 RVA: 0x0009973C File Offset: 0x0009793C
	private void AOCDDBNBADJ()
	{
		this.BAKBIMBKKNP = Shader.Find("Level load event");
		this.MPPKIGPJEHP();
		base.GIJBBMPJJJK(false);
	}

	// Token: 0x06000F06 RID: 3846 RVA: 0x0009975C File Offset: 0x0009795C
	public void EOMGNPFHPBD(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		this.DJNAAFKOJJP();
		float num = 1159f / (float)Screen.width;
		float num2 = 888f / (float)Screen.height;
		this.LCBKJGFGGGF.SetVector(" ms", new Vector4(num, num2, 1864f, 906f));
		this.LCBKJGFGGGF.SetVector("knopje.wav", new Vector4(num * 579f, num2 * 1295f, num * 229f, num2 * 1053f));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LCBKJGFGGGF);
	}

	// Token: 0x06000F07 RID: 3847 RVA: 0x000997E8 File Offset: 0x000979E8
	public void OJBKOLJAHAO(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		this.FDLCPCDBJJH();
		float num = 1719f / (float)Screen.width;
		float num2 = 1447f / (float)Screen.height;
		this.LCBKJGFGGGF.SetVector("PaperTurn.wav", new Vector4(num, num2, 1867f, 1547f));
		this.LCBKJGFGGGF.SetVector("elbow", new Vector4(num * 223f, num2 * 867f, num * 1889f, num2 * 84f));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LCBKJGFGGGF);
	}

	// Token: 0x06000F08 RID: 3848 RVA: 0x00099874 File Offset: 0x00097A74
	private void DHJDMKLBLEF()
	{
		this.BAKBIMBKKNP = Shader.Find("--");
		this.LECPACMHLLG();
		base.JIGEPPAAGEH(true);
	}

	// Token: 0x06000F09 RID: 3849 RVA: 0x00099647 File Offset: 0x00097847
	private void FNMFECJCGBP()
	{
		if (this.LCBKJGFGGGF == null)
		{
			this.LCBKJGFGGGF = base.CheckShaderAndCreateMaterial(this.BAKBIMBKKNP, this.LCBKJGFGGGF);
		}
	}

	// Token: 0x06000F0A RID: 3850 RVA: 0x00099894 File Offset: 0x00097A94
	private void NELHMAMLGGN()
	{
		if (this.LCBKJGFGGGF == null)
		{
			this.LCBKJGFGGGF = base.EGBOLFLKAPH(this.BAKBIMBKKNP, this.LCBKJGFGGGF);
		}
	}

	// Token: 0x06000F0B RID: 3851 RVA: 0x000998BC File Offset: 0x00097ABC
	public void EFEHHALJILL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		this.FNPNALCONDH();
		float num = 1814f / (float)Screen.width;
		float num2 = 214f / (float)Screen.height;
		this.LCBKJGFGGGF.SetVector("{0:0} ч{1}, ", new Vector4(num, num2, 855f, 720f));
		this.LCBKJGFGGGF.SetVector("getfish", new Vector4(num * 1118f, num2 * 1673f, num * 1265f, num2 * 290f));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LCBKJGFGGGF);
	}

	// Token: 0x06000F0C RID: 3852 RVA: 0x00099948 File Offset: 0x00097B48
	private void EKIMLFPCNIF()
	{
		if (this.LCBKJGFGGGF == null)
		{
			this.LCBKJGFGGGF = base.IAIAINBKNKB(this.BAKBIMBKKNP, this.LCBKJGFGGGF);
		}
	}

	// Token: 0x06000F0D RID: 3853 RVA: 0x00099970 File Offset: 0x00097B70
	public void BIJMHMEDHDC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		this.JLKEMPAHAMA();
		float num = 1890f / (float)Screen.width;
		float num2 = 280f / (float)Screen.height;
		this.LCBKJGFGGGF.SetVector("References has no spine bones assigned, can not initiate the solver.", new Vector4(num, num2, 457f, 692f));
		this.LCBKJGFGGGF.SetVector(" has been unloaded successfully", new Vector4(num * 1618f, num2 * 1755f, num * 31f, num2 * 312f));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LCBKJGFGGGF);
	}

	// Token: 0x06000F0E RID: 3854 RVA: 0x000995F7 File Offset: 0x000977F7
	private void NFOFBAPIJPI()
	{
		if (this.LCBKJGFGGGF == null)
		{
			this.LCBKJGFGGGF = base.NPOGNEDIPMC(this.BAKBIMBKKNP, this.LCBKJGFGGGF);
		}
	}

	// Token: 0x06000F0F RID: 3855 RVA: 0x000999FC File Offset: 0x00097BFC
	public void PMHDOMMHBPG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		this.AGPPKKGLKAE();
		float num = 1664f / (float)Screen.width;
		float num2 = 349f / (float)Screen.height;
		this.LCBKJGFGGGF.SetVector("C", new Vector4(num, num2, 1062f, 889f));
		this.LCBKJGFGGGF.SetVector("[Attachments] Failed to find ProBuilder object on the attachments object '{0}'.", new Vector4(num * 241f, num2 * 1292f, num * 115f, num2 * 1293f));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LCBKJGFGGGF);
	}

	// Token: 0x06000F10 RID: 3856 RVA: 0x00099A88 File Offset: 0x00097C88
	public void JPCPEPMDLAN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		this.NGIFNENNHIJ();
		float num = 1748f / (float)Screen.width;
		float num2 = 1598f / (float)Screen.height;
		this.LCBKJGFGGGF.SetVector("pempty=0", new Vector4(num, num2, 894f, 1780f));
		this.LCBKJGFGGGF.SetVector("tid", new Vector4(num * 1786f, num2 * 1570f, num * 236f, num2 * 1319f));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LCBKJGFGGGF);
	}

	// Token: 0x06000F11 RID: 3857 RVA: 0x00099B14 File Offset: 0x00097D14
	public void HGBMMLPBFAL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		this.GCNAPIPDMLN();
		float num = 663f / (float)Screen.width;
		float num2 = 1411f / (float)Screen.height;
		this.LCBKJGFGGGF.SetVector("isLocalServer", new Vector4(num, num2, 825f, 120f));
		this.LCBKJGFGGGF.SetVector("catch2.ogg", new Vector4(num * 404f, num2 * 351f, num * 507f, num2 * 201f));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LCBKJGFGGGF);
	}

	// Token: 0x06000F12 RID: 3858 RVA: 0x00099BA0 File Offset: 0x00097DA0
	private void MKNPFMEMOJO()
	{
		this.BAKBIMBKKNP = Shader.Find("[ACTk] WallHack Detector: can't be started since it doesn't exists in scene or not yet initialized!");
		this.ABKPKGLIFGP();
		base.GIJBBMPJJJK(true);
	}

	// Token: 0x06000F13 RID: 3859 RVA: 0x000995F7 File Offset: 0x000977F7
	private void NCEFKCHPKFF()
	{
		if (this.LCBKJGFGGGF == null)
		{
			this.LCBKJGFGGGF = base.NPOGNEDIPMC(this.BAKBIMBKKNP, this.LCBKJGFGGGF);
		}
	}

	// Token: 0x06000F14 RID: 3860 RVA: 0x00099894 File Offset: 0x00097A94
	private void ABKPKGLIFGP()
	{
		if (this.LCBKJGFGGGF == null)
		{
			this.LCBKJGFGGGF = base.EGBOLFLKAPH(this.BAKBIMBKKNP, this.LCBKJGFGGGF);
		}
	}

	// Token: 0x06000F15 RID: 3861 RVA: 0x00099BC0 File Offset: 0x00097DC0
	public void GNDNAAHKDIM(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		this.ABKPKGLIFGP();
		float num = 1761f / (float)Screen.width;
		float num2 = 1163f / (float)Screen.height;
		this.LCBKJGFGGGF.SetVector(" ?", new Vector4(num, num2, 413f, 1661f));
		this.LCBKJGFGGGF.SetVector("does not exist.", new Vector4(num * 1370f, num2 * 1141f, num * 772f, num2 * 1932f));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LCBKJGFGGGF);
	}

	// Token: 0x06000F16 RID: 3862 RVA: 0x00099C4C File Offset: 0x00097E4C
	private void AGPPKKGLKAE()
	{
		if (this.LCBKJGFGGGF == null)
		{
			this.LCBKJGFGGGF = base.OAGPGGEHKAB(this.BAKBIMBKKNP, this.LCBKJGFGGGF);
		}
	}

	// Token: 0x06000F17 RID: 3863 RVA: 0x00099C74 File Offset: 0x00097E74
	private void EHFPLKEINFO()
	{
		this.BAKBIMBKKNP = Shader.Find("_DepthOfFieldParams");
		this.JFLPFJFNHID();
		base.CAJBFLHLLHL(false);
	}

	// Token: 0x06000F18 RID: 3864 RVA: 0x0009961F File Offset: 0x0009781F
	private void GCNAPIPDMLN()
	{
		if (this.LCBKJGFGGGF == null)
		{
			this.LCBKJGFGGGF = base.NELLKFGIJEC(this.BAKBIMBKKNP, this.LCBKJGFGGGF);
		}
	}

	// Token: 0x06000F19 RID: 3865 RVA: 0x00099894 File Offset: 0x00097A94
	private void FNPNALCONDH()
	{
		if (this.LCBKJGFGGGF == null)
		{
			this.LCBKJGFGGGF = base.EGBOLFLKAPH(this.BAKBIMBKKNP, this.LCBKJGFGGGF);
		}
	}

	// Token: 0x06000F1A RID: 3866 RVA: 0x00099C94 File Offset: 0x00097E94
	public void EGOKABFLKGC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		this.MPPKIGPJEHP();
		float num = 1799f / (float)Screen.width;
		float num2 = 327f / (float)Screen.height;
		this.LCBKJGFGGGF.SetVector("CrouchWalk", new Vector4(num, num2, 1329f, 419f));
		this.LCBKJGFGGGF.SetVector("<color=\"", new Vector4(num * 281f, num2 * 1253f, num * 827f, num2 * 614f));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LCBKJGFGGGF);
	}

	// Token: 0x06000F1B RID: 3867 RVA: 0x0009961F File Offset: 0x0009781F
	private void MPPKIGPJEHP()
	{
		if (this.LCBKJGFGGGF == null)
		{
			this.LCBKJGFGGGF = base.NELLKFGIJEC(this.BAKBIMBKKNP, this.LCBKJGFGGGF);
		}
	}

	// Token: 0x06000F1C RID: 3868 RVA: 0x00099D20 File Offset: 0x00097F20
	private void PFNPOHMMJDN()
	{
		this.BAKBIMBKKNP = Shader.Find("Didn't expect existing render texture: ");
		this.LDFFHHACBDH();
		base.JIGEPPAAGEH(false);
	}

	// Token: 0x06000F1D RID: 3869 RVA: 0x00099D40 File Offset: 0x00097F40
	private void Start()
	{
		this.BAKBIMBKKNP = Shader.Find("Hidden/FXAA3");
		this.FNMFECJCGBP();
		base.CheckSupport(false);
	}

	// Token: 0x06000F1E RID: 3870 RVA: 0x0009961F File Offset: 0x0009781F
	private void JLKEMPAHAMA()
	{
		if (this.LCBKJGFGGGF == null)
		{
			this.LCBKJGFGGGF = base.NELLKFGIJEC(this.BAKBIMBKKNP, this.LCBKJGFGGGF);
		}
	}

	// Token: 0x06000F1F RID: 3871 RVA: 0x00099D60 File Offset: 0x00097F60
	private void DJNAAFKOJJP()
	{
		if (this.LCBKJGFGGGF == null)
		{
			this.LCBKJGFGGGF = base.BIIALHKCFDB(this.BAKBIMBKKNP, this.LCBKJGFGGGF);
		}
	}

	// Token: 0x06000F20 RID: 3872 RVA: 0x00099D88 File Offset: 0x00097F88
	public void OnRenderImage(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		this.FNMFECJCGBP();
		float num = 1f / (float)Screen.width;
		float num2 = 1f / (float)Screen.height;
		this.LCBKJGFGGGF.SetVector("_rcpFrame", new Vector4(num, num2, 0f, 0f));
		this.LCBKJGFGGGF.SetVector("_rcpFrameOpt", new Vector4(num * 2f, num2 * 2f, num * 0.5f, num2 * 0.5f));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LCBKJGFGGGF);
	}

	// Token: 0x06000F21 RID: 3873 RVA: 0x0009961F File Offset: 0x0009781F
	private void JJAGENBBDPP()
	{
		if (this.LCBKJGFGGGF == null)
		{
			this.LCBKJGFGGGF = base.NELLKFGIJEC(this.BAKBIMBKKNP, this.LCBKJGFGGGF);
		}
	}

	// Token: 0x06000F22 RID: 3874 RVA: 0x00099E14 File Offset: 0x00098014
	public void KHHBBMHGMIH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		this.GCNAPIPDMLN();
		float num = 1914f / (float)Screen.width;
		float num2 = 1422f / (float)Screen.height;
		this.LCBKJGFGGGF.SetVector("</color>", new Vector4(num, num2, 587f, 41f));
		this.LCBKJGFGGGF.SetVector("https://www.youtube.com/watch?v=sQfB2RcT1T4&index=14&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6", new Vector4(num * 1323f, num2 * 1631f, num * 1089f, num2 * 589f));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LCBKJGFGGGF);
	}

	// Token: 0x06000F23 RID: 3875 RVA: 0x000995CF File Offset: 0x000977CF
	private void NGIFNENNHIJ()
	{
		if (this.LCBKJGFGGGF == null)
		{
			this.LCBKJGFGGGF = base.CJMHHPLIEGJ(this.BAKBIMBKKNP, this.LCBKJGFGGGF);
		}
	}

	// Token: 0x06000F24 RID: 3876 RVA: 0x00099EA0 File Offset: 0x000980A0
	public void EPHHNPMPHOL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		this.GCNAPIPDMLN();
		float num = 429f / (float)Screen.width;
		float num2 = 869f / (float)Screen.height;
		this.LCBKJGFGGGF.SetVector("<color='#003000'>{0}</color>", new Vector4(num, num2, 1020f, 829f));
		this.LCBKJGFGGGF.SetVector("1HandSwordStrafeRight", new Vector4(num * 820f, num2 * 108f, num * 773f, num2 * 1888f));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LCBKJGFGGGF);
	}

	// Token: 0x06000F25 RID: 3877 RVA: 0x00099F2C File Offset: 0x0009812C
	private void BMNJGPIPKLL()
	{
		this.BAKBIMBKKNP = Shader.Find("");
		this.CFOAAPOPFAE();
		base.HCOOCPPIPLH(false);
	}

	// Token: 0x06000F26 RID: 3878 RVA: 0x00099F4C File Offset: 0x0009814C
	private void PMDPLLIBJAF()
	{
		this.BAKBIMBKKNP = Shader.Find("CCDIK not found!");
		this.GCNAPIPDMLN();
		base.GDOGBMMCBKD(true);
	}

	// Token: 0x06000F27 RID: 3879 RVA: 0x00099F6C File Offset: 0x0009816C
	public void EDCBFNNHICN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		this.LDFFHHACBDH();
		float num = 290f / (float)Screen.width;
		float num2 = 720f / (float)Screen.height;
		this.LCBKJGFGGGF.SetVector("none id=", new Vector4(num, num2, 321f, 1170f));
		this.LCBKJGFGGGF.SetVector("_isSelect", new Vector4(num * 602f, num2 * 1201f, num * 869f, num2 * 763f));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LCBKJGFGGGF);
	}

	// Token: 0x06000F28 RID: 3880 RVA: 0x00099FF8 File Offset: 0x000981F8
	private void BJHGPFGBFKF()
	{
		this.BAKBIMBKKNP = Shader.Find("auk_wset");
		this.NGIFNENNHIJ();
		base.GIJBBMPJJJK(false);
	}

	// Token: 0x06000F29 RID: 3881 RVA: 0x0009A018 File Offset: 0x00098218
	public void GAJNNKIFMOG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		this.JJAGENBBDPP();
		float num = 399f / (float)Screen.width;
		float num2 = 1732f / (float)Screen.height;
		this.LCBKJGFGGGF.SetVector("#b0ffa0", new Vector4(num, num2, 577f, 1796f));
		this.LCBKJGFGGGF.SetVector("WeaponReadyFire", new Vector4(num * 851f, num2 * 767f, num * 309f, num2 * 1215f));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LCBKJGFGGGF);
	}

	// Token: 0x06000F2A RID: 3882 RVA: 0x0009A0A4 File Offset: 0x000982A4
	public void PHFJDPLOKJK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		this.NELHMAMLGGN();
		float num = 40f / (float)Screen.width;
		float num2 = 1386f / (float)Screen.height;
		this.LCBKJGFGGGF.SetVector("usr_inf_a4", new Vector4(num, num2, 1428f, 1557f));
		this.LCBKJGFGGGF.SetVector("ui_default_click.wav", new Vector4(num * 1423f, num2 * 771f, num * 1359f, num2 * 1662f));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LCBKJGFGGGF);
	}

	// Token: 0x06000F2B RID: 3883 RVA: 0x000995F7 File Offset: 0x000977F7
	private void JFLPFJFNHID()
	{
		if (this.LCBKJGFGGGF == null)
		{
			this.LCBKJGFGGGF = base.NPOGNEDIPMC(this.BAKBIMBKKNP, this.LCBKJGFGGGF);
		}
	}

	// Token: 0x06000F2C RID: 3884 RVA: 0x0009A130 File Offset: 0x00098330
	public void EBLFIONBNIO(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		this.NCEFKCHPKFF();
		float num = 191f / (float)Screen.width;
		float num2 = 1647f / (float)Screen.height;
		this.LCBKJGFGGGF.SetVector("value", new Vector4(num, num2, 1345f, 1853f));
		this.LCBKJGFGGGF.SetVector("1HandSwordRollAttack", new Vector4(num * 39f, num2 * 412f, num * 1952f, num2 * 12f));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LCBKJGFGGGF);
	}

	// Token: 0x06000F2D RID: 3885 RVA: 0x00099C4C File Offset: 0x00097E4C
	private void CIICPEIPKJD()
	{
		if (this.LCBKJGFGGGF == null)
		{
			this.LCBKJGFGGGF = base.OAGPGGEHKAB(this.BAKBIMBKKNP, this.LCBKJGFGGGF);
		}
	}

	// Token: 0x06000F2E RID: 3886 RVA: 0x00099C4C File Offset: 0x00097E4C
	private void LDFFHHACBDH()
	{
		if (this.LCBKJGFGGGF == null)
		{
			this.LCBKJGFGGGF = base.OAGPGGEHKAB(this.BAKBIMBKKNP, this.LCBKJGFGGGF);
		}
	}

	// Token: 0x06000F2F RID: 3887 RVA: 0x0009A1BC File Offset: 0x000983BC
	public void CNIBAOINCHB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		this.LECPACMHLLG();
		float num = 371f / (float)Screen.width;
		float num2 = 1174f / (float)Screen.height;
		this.LCBKJGFGGGF.SetVector("_rcIn.ogg", new Vector4(num, num2, 1892f, 300f));
		this.LCBKJGFGGGF.SetVector("Sitting Reading Page Flip", new Vector4(num * 117f, num2 * 1757f, num * 248f, num2 * 909f));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LCBKJGFGGGF);
	}

	// Token: 0x06000F30 RID: 3888 RVA: 0x0009A248 File Offset: 0x00098448
	private void NOKJMMDMJNO()
	{
		this.BAKBIMBKKNP = Shader.Find("wpn_eat6");
		this.NCEFKCHPKFF();
		base.BHMHBOKDBFE(true);
	}

	// Token: 0x06000F31 RID: 3889 RVA: 0x000995F7 File Offset: 0x000977F7
	private void LECPACMHLLG()
	{
		if (this.LCBKJGFGGGF == null)
		{
			this.LCBKJGFGGGF = base.NPOGNEDIPMC(this.BAKBIMBKKNP, this.LCBKJGFGGGF);
		}
	}

	// Token: 0x06000F32 RID: 3890 RVA: 0x0009A268 File Offset: 0x00098468
	private void CPNOBMNKPNC()
	{
		this.BAKBIMBKKNP = Shader.Find("Чат очищен");
		this.MPPKIGPJEHP();
		base.JIGEPPAAGEH(true);
	}

	// Token: 0x06000F33 RID: 3891 RVA: 0x0009A288 File Offset: 0x00098488
	private void IMABGALEMBI()
	{
		this.BAKBIMBKKNP = Shader.Find("reel_type");
		this.NGIFNENNHIJ();
		base.JIGEPPAAGEH(false);
	}

	// Token: 0x06000F35 RID: 3893 RVA: 0x0009A2B0 File Offset: 0x000984B0
	public void LENELHOAKID(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		this.JLKEMPAHAMA();
		float num = 1401f / (float)Screen.width;
		float num2 = 1548f / (float)Screen.height;
		this.LCBKJGFGGGF.SetVector("WoodSaw", new Vector4(num, num2, 622f, 1425f));
		this.LCBKJGFGGGF.SetVector("\n", new Vector4(num * 1231f, num2 * 567f, num * 1118f, num2 * 1627f));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LCBKJGFGGGF);
	}

	// Token: 0x06000F36 RID: 3894 RVA: 0x000995CF File Offset: 0x000977CF
	private void KIIFHALCGED()
	{
		if (this.LCBKJGFGGGF == null)
		{
			this.LCBKJGFGGGF = base.CJMHHPLIEGJ(this.BAKBIMBKKNP, this.LCBKJGFGGGF);
		}
	}

	// Token: 0x06000F37 RID: 3895 RVA: 0x000995F7 File Offset: 0x000977F7
	private void OOHDLAGKNNI()
	{
		if (this.LCBKJGFGGGF == null)
		{
			this.LCBKJGFGGGF = base.NPOGNEDIPMC(this.BAKBIMBKKNP, this.LCBKJGFGGGF);
		}
	}

	// Token: 0x06000F38 RID: 3896 RVA: 0x0009A33C File Offset: 0x0009853C
	public void GDGPNFLCNEG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		this.EKIMLFPCNIF();
		float num = 46f / (float)Screen.width;
		float num2 = 196f / (float)Screen.height;
		this.LCBKJGFGGGF.SetVector(" ", new Vector4(num, num2, 894f, 423f));
		this.LCBKJGFGGGF.SetVector("wpn_onlym", new Vector4(num * 1074f, num2 * 415f, num * 1310f, num2 * 734f));
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LCBKJGFGGGF);
	}

	// Token: 0x06000F39 RID: 3897 RVA: 0x0009A3C8 File Offset: 0x000985C8
	private void IAAOGAPJDID()
	{
		this.BAKBIMBKKNP = Shader.Find("UIPCam_pos");
		this.KIIFHALCGED();
		base.GDOGBMMCBKD(true);
	}

	// Token: 0x0400018E RID: 398
	private Shader BAKBIMBKKNP;

	// Token: 0x0400018F RID: 399
	private Material LCBKJGFGGGF;
}
