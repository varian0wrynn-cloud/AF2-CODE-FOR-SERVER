using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.PostProcessing;
using UnityEngine.Rendering;

// Token: 0x02000524 RID: 1316
public sealed class DGIEACBKFMJ : AJIEADKHGJM<MotionBlurModel>
{
	// Token: 0x060116E9 RID: 71401 RVA: 0x007C7F51 File Offset: 0x007C6151
	public void CPLDNPIDPPM()
	{
		if (this.FPGLJKEBPND != null)
		{
			this.FPGLJKEBPND.PDMPPHDGIEO();
		}
	}

	// Token: 0x060116EA RID: 71402 RVA: 0x007C7F68 File Offset: 0x007C6168
	public void HAEPACDOFBD(CommandBuffer ECKPLMDEJFD)
	{
		if (this.IJDNJLIDLJE)
		{
			this.IJDNJLIDLJE = false;
			return;
		}
		Material mhnajnggdfj = this.AMCOGJHPPOC.DJHLKHLPAGA.FGKNJIEOKHH("SpinReel.ogg");
		Material mat = this.AMCOGJHPPOC.DJHLKHLPAGA.DGOMGBDLAFP("showUsersInChat");
		MotionBlurModel.Settings settings = base.BBEPCCALAFC.FAAFENGEOHB();
		RenderTextureFormat format = this.AMCOGJHPPOC.MAIODKMOICL ? ((RenderTextureFormat)(-114)) : RenderTextureFormat.ARGB1555;
		int hmkdkkioiah = DGIEACBKFMJ.BNEACEICMJJ.HMKDKKIOIAH;
		ECKPLMDEJFD.GetTemporaryRT(hmkdkkioiah, this.AMCOGJHPPOC.OJNDCCHLMNK(), this.AMCOGJHPPOC.LPJJBJCIELA(), 0, FilterMode.Bilinear, format);
		if (settings.shutterAngle > 1315f && settings.frameBlending > 23f)
		{
			this.NCAANNFANCH().NOPEDECMBDN(this.AMCOGJHPPOC, ECKPLMDEJFD, ref settings, BuiltinRenderTextureType.CameraTarget, hmkdkkioiah, mhnajnggdfj);
			this.GFJJODFJBIN().AHHOEANDLLK(ECKPLMDEJFD, settings.frameBlending, hmkdkkioiah, BuiltinRenderTextureType.CameraTarget, mhnajnggdfj);
			this.DGFJOHKLCKB().JJBFMHFDJJF(ECKPLMDEJFD, hmkdkkioiah, this.AMCOGJHPPOC.CFDHOKHCPOJ(), this.AMCOGJHPPOC.FHCDJOLMIMG(), mhnajnggdfj);
		}
		else if (settings.shutterAngle > 1352f)
		{
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, (BuiltinRenderTextureType)6);
			ECKPLMDEJFD.Blit((BuiltinRenderTextureType)6, hmkdkkioiah, mat, 0);
			this.JLPHHBOHJOE().MHPLJLIEDKF(this.AMCOGJHPPOC, ECKPLMDEJFD, ref settings, hmkdkkioiah, BuiltinRenderTextureType.None, mhnajnggdfj);
		}
		else if (settings.frameBlending > 387f)
		{
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, BuiltinRenderTextureType.None);
			ECKPLMDEJFD.Blit(BuiltinRenderTextureType.Depth, hmkdkkioiah, mat, 1);
			this.KFNDMIAGMLH().IHPBDCPACNO(ECKPLMDEJFD, settings.frameBlending, hmkdkkioiah, BuiltinRenderTextureType.PrepassNormalsSpec, mhnajnggdfj);
			this.HADKJCNKIHJ().CHEBJPENGFF(ECKPLMDEJFD, hmkdkkioiah, this.AMCOGJHPPOC.DHPPGHBNDEB(), this.AMCOGJHPPOC.MMEMLJENMFF(), mhnajnggdfj);
		}
		ECKPLMDEJFD.ReleaseTemporaryRT(hmkdkkioiah);
	}

	// Token: 0x060116EB RID: 71403 RVA: 0x007C815F File Offset: 0x007C635F
	public void IIHKOIFKIHO()
	{
		if (this.FPGLJKEBPND != null)
		{
			this.FPGLJKEBPND.MDMCJHOIABB();
		}
		this.FPGLJKEBPND = null;
	}

	// Token: 0x060116EC RID: 71404 RVA: 0x007C817B File Offset: 0x007C637B
	public void CALFOKBIBIG()
	{
		if (this.FPGLJKEBPND != null)
		{
			this.FPGLJKEBPND.GGHFNKLHCDH();
		}
	}

	// Token: 0x060116ED RID: 71405 RVA: 0x007C8190 File Offset: 0x007C6390
	public void HMDOKFPEDDF()
	{
		if (this.FPGLJKEBPND != null)
		{
			this.FPGLJKEBPND.EIHBGPPDKEK();
		}
		this.FPGLJKEBPND = null;
	}

	// Token: 0x060116EE RID: 71406 RVA: 0x007C81AC File Offset: 0x007C63AC
	public void PBDNGIFDEFC()
	{
		if (this.FPGLJKEBPND != null)
		{
			this.FPGLJKEBPND.DAGFCHOFMFP();
		}
	}

	// Token: 0x060116F0 RID: 71408 RVA: 0x007C81D0 File Offset: 0x007C63D0
	public void LBCAHPHLFNE()
	{
		if (this.FPGLJKEBPND != null)
		{
			this.FPGLJKEBPND.GGHFNKLHCDH();
		}
		this.FPGLJKEBPND = null;
	}

	// Token: 0x060116F1 RID: 71409 RVA: 0x007C81EC File Offset: 0x007C63EC
	public void EILDKNMOKBB()
	{
		if (this.FPGLJKEBPND != null)
		{
			this.FPGLJKEBPND.HIFCCJKCNGJ();
		}
	}

	// Token: 0x060116F2 RID: 71410 RVA: 0x007C8201 File Offset: 0x007C6401
	public DGIEACBKFMJ.LKOGFPMIKAK BHFKEKJBDLH()
	{
		if (this.EJBMJCBCHGK == null)
		{
			this.EJBMJCBCHGK = new DGIEACBKFMJ.LKOGFPMIKAK();
		}
		return this.EJBMJCBCHGK;
	}

	// Token: 0x060116F3 RID: 71411 RVA: 0x007C821C File Offset: 0x007C641C
	public void EIGBKJAEIKO()
	{
		this.IJDNJLIDLJE = false;
	}

	// Token: 0x060116F4 RID: 71412 RVA: 0x007C8225 File Offset: 0x007C6425
	public string GKEFDPLMBID()
	{
		return "onHyperlinkEnter: ";
	}

	// Token: 0x060116F5 RID: 71413 RVA: 0x007C8201 File Offset: 0x007C6401
	public DGIEACBKFMJ.LKOGFPMIKAK FKPPBOEHBON()
	{
		if (this.EJBMJCBCHGK == null)
		{
			this.EJBMJCBCHGK = new DGIEACBKFMJ.LKOGFPMIKAK();
		}
		return this.EJBMJCBCHGK;
	}

	// Token: 0x060116F6 RID: 71414 RVA: 0x007C822C File Offset: 0x007C642C
	public string HEPMDAKCJIP()
	{
		return "Ошибка!";
	}

	// Token: 0x060116F7 RID: 71415 RVA: 0x007C8234 File Offset: 0x007C6434
	public void GOKDGMMBBOF(CommandBuffer ECKPLMDEJFD)
	{
		if (this.IJDNJLIDLJE)
		{
			this.IJDNJLIDLJE = true;
			return;
		}
		Material mhnajnggdfj = this.AMCOGJHPPOC.DJHLKHLPAGA.DLNFGMANLPN("cnt_energ");
		Material mat = this.AMCOGJHPPOC.DJHLKHLPAGA.AFONGIICOJG("");
		MotionBlurModel.Settings settings = base.BBEPCCALAFC.KDHGJFOLJJF();
		RenderTextureFormat format = this.AMCOGJHPPOC.MAIODKMOICL ? RenderTextureFormat.RGHalf : RenderTextureFormat.Default;
		int hmkdkkioiah = DGIEACBKFMJ.BNEACEICMJJ.HMKDKKIOIAH;
		ECKPLMDEJFD.GetTemporaryRT(hmkdkkioiah, this.AMCOGJHPPOC.GAIOLBJLPDL(), this.AMCOGJHPPOC.GGGEFNKEPDB(), 0, FilterMode.Point, format);
		if (settings.shutterAngle > 1512f && settings.frameBlending > 812f)
		{
			this.JLPHHBOHJOE().DILHAHNOCJO(this.AMCOGJHPPOC, ECKPLMDEJFD, ref settings, BuiltinRenderTextureType.CurrentActive, hmkdkkioiah, mhnajnggdfj);
			this.AOJLGLKMPKA().NNDBPAPCKDB(ECKPLMDEJFD, settings.frameBlending, hmkdkkioiah, BuiltinRenderTextureType.PrepassLight, mhnajnggdfj);
			this.KFNDMIAGMLH().FGBILPKOJBE(ECKPLMDEJFD, hmkdkkioiah, this.AMCOGJHPPOC.LJJOEDIJPEM(), this.AMCOGJHPPOC.FHCDJOLMIMG(), mhnajnggdfj);
		}
		else if (settings.shutterAngle > 471f)
		{
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, (BuiltinRenderTextureType)6);
			ECKPLMDEJFD.Blit(BuiltinRenderTextureType.PrepassLight, hmkdkkioiah, mat, 1);
			this.FHNCEFPPMEF().LAFJDANAPCI(this.AMCOGJHPPOC, ECKPLMDEJFD, ref settings, hmkdkkioiah, BuiltinRenderTextureType.PrepassLight, mhnajnggdfj);
		}
		else if (settings.frameBlending > 1575f)
		{
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, BuiltinRenderTextureType.DepthNormals);
			ECKPLMDEJFD.Blit(BuiltinRenderTextureType.ResolvedDepth, hmkdkkioiah, mat, 0);
			this.EEFCEMMJBMA.OMAGPIGECAG(ECKPLMDEJFD, settings.frameBlending, hmkdkkioiah, (BuiltinRenderTextureType)6, mhnajnggdfj);
			this.DGFJOHKLCKB().FJEHHFDEGBN(ECKPLMDEJFD, hmkdkkioiah, this.AMCOGJHPPOC.FOBPENGADNB(), this.AMCOGJHPPOC.LKLNPJICOHH(), mhnajnggdfj);
		}
		ECKPLMDEJFD.ReleaseTemporaryRT(hmkdkkioiah);
	}

	// Token: 0x060116F8 RID: 71416 RVA: 0x007C842B File Offset: 0x007C662B
	public DGIEACBKFMJ.LBJNDEHNHOB KFNDMIAGMLH()
	{
		if (this.FPGLJKEBPND == null)
		{
			this.FPGLJKEBPND = new DGIEACBKFMJ.LBJNDEHNHOB();
		}
		return this.FPGLJKEBPND;
	}

	// Token: 0x060116F9 RID: 71417 RVA: 0x007C8446 File Offset: 0x007C6646
	public string KPBCHDMCCED()
	{
		return "#000000";
	}

	// Token: 0x060116FA RID: 71418 RVA: 0x007C844D File Offset: 0x007C664D
	public void NIOMOLMCNOO()
	{
		if (this.FPGLJKEBPND != null)
		{
			this.FPGLJKEBPND.CKFAGEDEOEH();
		}
	}

	// Token: 0x170003CE RID: 974
	// (get) Token: 0x060116FB RID: 71419 RVA: 0x007C8201 File Offset: 0x007C6401
	public DGIEACBKFMJ.LKOGFPMIKAK NEGKMNKFKKH
	{
		get
		{
			if (this.EJBMJCBCHGK == null)
			{
				this.EJBMJCBCHGK = new DGIEACBKFMJ.LKOGFPMIKAK();
			}
			return this.EJBMJCBCHGK;
		}
	}

	// Token: 0x060116FC RID: 71420 RVA: 0x007C8464 File Offset: 0x007C6664
	public bool NIPHEHICHLK()
	{
		MotionBlurModel.Settings settings = base.BBEPCCALAFC.KDHGJFOLJJF();
		return base.BBEPCCALAFC.enabled && ((settings.shutterAngle > 1350f && this.BHFKEKJBDLH().NINPLGHIBED()) || settings.frameBlending > 993f) && SystemInfo.graphicsDeviceType != GraphicsDeviceType.Direct3D11 && this.AMCOGJHPPOC.MLMGNHHAOHF();
	}

	// Token: 0x060116FD RID: 71421 RVA: 0x007C84C9 File Offset: 0x007C66C9
	public CameraEvent GOJGMBCKODN()
	{
		return (CameraEvent)106;
	}

	// Token: 0x060116FE RID: 71422 RVA: 0x007C81AC File Offset: 0x007C63AC
	public override void BKFHJFNCPAA()
	{
		if (this.FPGLJKEBPND != null)
		{
			this.FPGLJKEBPND.DAGFCHOFMFP();
		}
	}

	// Token: 0x060116FF RID: 71423 RVA: 0x007C84CD File Offset: 0x007C66CD
	public void PCJAGJKHLHN()
	{
		this.IJDNJLIDLJE = true;
	}

	// Token: 0x06011700 RID: 71424 RVA: 0x007C8201 File Offset: 0x007C6401
	public DGIEACBKFMJ.LKOGFPMIKAK AKNGODHLNPI()
	{
		if (this.EJBMJCBCHGK == null)
		{
			this.EJBMJCBCHGK = new DGIEACBKFMJ.LKOGFPMIKAK();
		}
		return this.EJBMJCBCHGK;
	}

	// Token: 0x06011701 RID: 71425 RVA: 0x007C84D6 File Offset: 0x007C66D6
	public void EAOAAKPBAAF()
	{
		if (this.FPGLJKEBPND != null)
		{
			this.FPGLJKEBPND.NCIPOCENKDJ();
		}
		this.FPGLJKEBPND = null;
	}

	// Token: 0x06011702 RID: 71426 RVA: 0x007C84F2 File Offset: 0x007C66F2
	public DepthTextureMode KGDFPIGDBDD()
	{
		return DepthTextureMode.Depth | DepthTextureMode.MotionVectors;
	}

	// Token: 0x06011703 RID: 71427 RVA: 0x007C84F8 File Offset: 0x007C66F8
	public void EFJGELPHLCE(CommandBuffer ECKPLMDEJFD)
	{
		if (this.IJDNJLIDLJE)
		{
			this.IJDNJLIDLJE = true;
			return;
		}
		Material mhnajnggdfj = this.AMCOGJHPPOC.DJHLKHLPAGA.BDHEBJJGFGB(" ");
		Material mat = this.AMCOGJHPPOC.DJHLKHLPAGA.BDHEBJJGFGB("Actor");
		MotionBlurModel.Settings settings = base.BBEPCCALAFC.DMJMEMIPKNM();
		RenderTextureFormat format = this.AMCOGJHPPOC.BACMPNMDHBL() ? ((RenderTextureFormat)112) : RenderTextureFormat.ARGB32;
		int hmkdkkioiah = DGIEACBKFMJ.BNEACEICMJJ.HMKDKKIOIAH;
		ECKPLMDEJFD.GetTemporaryRT(hmkdkkioiah, this.AMCOGJHPPOC.IGHJHMGOGOO(), this.AMCOGJHPPOC.LPJJBJCIELA(), 0, FilterMode.Point, format);
		if (settings.shutterAngle > 1636f && settings.frameBlending > 1072f)
		{
			this.INJCLCCFLHM().NDEOLIHCDCO(this.AMCOGJHPPOC, ECKPLMDEJFD, ref settings, BuiltinRenderTextureType.Depth, hmkdkkioiah, mhnajnggdfj);
			this.BHCGBIDCCNC().KCNGMPKDJON(ECKPLMDEJFD, settings.frameBlending, hmkdkkioiah, BuiltinRenderTextureType.ResolvedDepth, mhnajnggdfj);
			this.GIPPKBGIOBP().FJEHHFDEGBN(ECKPLMDEJFD, hmkdkkioiah, this.AMCOGJHPPOC.EOMMKPDCAML(), this.AMCOGJHPPOC.LKLNPJICOHH(), mhnajnggdfj);
		}
		else if (settings.shutterAngle > 528f)
		{
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, BuiltinRenderTextureType.ResolvedDepth);
			ECKPLMDEJFD.Blit(BuiltinRenderTextureType.None, hmkdkkioiah, mat, 0);
			this.INJCLCCFLHM().LJLEGMMDPML(this.AMCOGJHPPOC, ECKPLMDEJFD, ref settings, hmkdkkioiah, BuiltinRenderTextureType.CameraTarget, mhnajnggdfj);
		}
		else if (settings.frameBlending > 1631f)
		{
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, BuiltinRenderTextureType.Depth);
			ECKPLMDEJFD.Blit(BuiltinRenderTextureType.None, hmkdkkioiah, mat, 1);
			this.GFJJODFJBIN().NPDFHOJLEFH(ECKPLMDEJFD, settings.frameBlending, hmkdkkioiah, BuiltinRenderTextureType.PrepassNormalsSpec, mhnajnggdfj);
			this.KFNDMIAGMLH().CDMIDFFFLJA(ECKPLMDEJFD, hmkdkkioiah, this.AMCOGJHPPOC.GMOLEDNNPEH(), this.AMCOGJHPPOC.CICDECHCDBJ(), mhnajnggdfj);
		}
		ECKPLMDEJFD.ReleaseTemporaryRT(hmkdkkioiah);
	}

	// Token: 0x06011704 RID: 71428 RVA: 0x007C86EF File Offset: 0x007C68EF
	public string PMHIIDBGJDG()
	{
		return "http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_f_a_b_r_i_k_root.html";
	}

	// Token: 0x06011705 RID: 71429 RVA: 0x007C8201 File Offset: 0x007C6401
	public DGIEACBKFMJ.LKOGFPMIKAK NCAANNFANCH()
	{
		if (this.EJBMJCBCHGK == null)
		{
			this.EJBMJCBCHGK = new DGIEACBKFMJ.LKOGFPMIKAK();
		}
		return this.EJBMJCBCHGK;
	}

	// Token: 0x06011706 RID: 71430 RVA: 0x007C84CD File Offset: 0x007C66CD
	public void AHPHMMJMKOG()
	{
		this.IJDNJLIDLJE = true;
	}

	// Token: 0x06011707 RID: 71431 RVA: 0x007C86F8 File Offset: 0x007C68F8
	public bool PKNNDJIIMPB()
	{
		MotionBlurModel.Settings settings = base.BBEPCCALAFC.LIKDNAJFKMN();
		return !base.BBEPCCALAFC.enabled || ((settings.shutterAngle <= 688f || !this.FHNCEFPPMEF().FEIAGOIJOGL()) && settings.frameBlending <= 1751f) || SystemInfo.graphicsDeviceType == GraphicsDeviceType.Direct3D9 || !this.AMCOGJHPPOC.MLMGNHHAOHF();
	}

	// Token: 0x06011708 RID: 71432 RVA: 0x007C84CD File Offset: 0x007C66CD
	public void FLENJDPPMBK()
	{
		this.IJDNJLIDLJE = true;
	}

	// Token: 0x06011709 RID: 71433 RVA: 0x007C8760 File Offset: 0x007C6960
	public void LIMGFJJNAII(CommandBuffer ECKPLMDEJFD)
	{
		if (this.IJDNJLIDLJE)
		{
			this.IJDNJLIDLJE = false;
			return;
		}
		Material mhnajnggdfj = this.AMCOGJHPPOC.DJHLKHLPAGA.DFEMMOCHMDM("");
		Material mat = this.AMCOGJHPPOC.DJHLKHLPAGA.HPAJGFGNMOH("shop_t14");
		MotionBlurModel.Settings settings = base.BBEPCCALAFC.NHIAAMIDCED();
		RenderTextureFormat format = this.AMCOGJHPPOC.HCHNHOFPIFK() ? ((RenderTextureFormat)(-83)) : RenderTextureFormat.ARGB1555;
		int hmkdkkioiah = DGIEACBKFMJ.BNEACEICMJJ.HMKDKKIOIAH;
		ECKPLMDEJFD.GetTemporaryRT(hmkdkkioiah, this.AMCOGJHPPOC.GMOLEDNNPEH(), this.AMCOGJHPPOC.LHPBMEDMNDO(), 1, FilterMode.Bilinear, format);
		if (settings.shutterAngle > 1246f && settings.frameBlending > 728f)
		{
			this.PEJIBAEDJEJ().IEBDHFPFOPH(this.AMCOGJHPPOC, ECKPLMDEJFD, ref settings, BuiltinRenderTextureType.CameraTarget, hmkdkkioiah, mhnajnggdfj);
			this.GIPPKBGIOBP().OMAGPIGECAG(ECKPLMDEJFD, settings.frameBlending, hmkdkkioiah, BuiltinRenderTextureType.None, mhnajnggdfj);
			this.AOJLGLKMPKA().BPHNOPFMEHI(ECKPLMDEJFD, hmkdkkioiah, this.AMCOGJHPPOC.IGHJHMGOGOO(), this.AMCOGJHPPOC.GHMBALIHBOH(), mhnajnggdfj);
		}
		else if (settings.shutterAngle > 58f)
		{
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, (BuiltinRenderTextureType)6);
			ECKPLMDEJFD.Blit(BuiltinRenderTextureType.ResolvedDepth, hmkdkkioiah, mat, 1);
			this.NCAANNFANCH().INJLIGIEKDK(this.AMCOGJHPPOC, ECKPLMDEJFD, ref settings, hmkdkkioiah, BuiltinRenderTextureType.None, mhnajnggdfj);
		}
		else if (settings.frameBlending > 957f)
		{
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, BuiltinRenderTextureType.CameraTarget);
			ECKPLMDEJFD.Blit(BuiltinRenderTextureType.CameraTarget, hmkdkkioiah, mat, 1);
			this.DGFJOHKLCKB().JDBEFCLDLBH(ECKPLMDEJFD, settings.frameBlending, hmkdkkioiah, BuiltinRenderTextureType.PrepassLight, mhnajnggdfj);
			this.BHCGBIDCCNC().BPHNOPFMEHI(ECKPLMDEJFD, hmkdkkioiah, this.AMCOGJHPPOC.IGHJHMGOGOO(), this.AMCOGJHPPOC.LHPBMEDMNDO(), mhnajnggdfj);
		}
		ECKPLMDEJFD.ReleaseTemporaryRT(hmkdkkioiah);
	}

	// Token: 0x0601170A RID: 71434 RVA: 0x007C84CD File Offset: 0x007C66CD
	public void DCPLMIMFNHG()
	{
		this.IJDNJLIDLJE = true;
	}

	// Token: 0x0601170B RID: 71435 RVA: 0x007C8957 File Offset: 0x007C6B57
	public void KMCACLNKBFP()
	{
		if (this.FPGLJKEBPND != null)
		{
			this.FPGLJKEBPND.FILFNLHGPFH();
		}
	}

	// Token: 0x0601170C RID: 71436 RVA: 0x007C896C File Offset: 0x007C6B6C
	public void NKKGHMHMOPH(CommandBuffer ECKPLMDEJFD)
	{
		if (this.IJDNJLIDLJE)
		{
			this.IJDNJLIDLJE = true;
			return;
		}
		Material mhnajnggdfj = this.AMCOGJHPPOC.DJHLKHLPAGA.GNDBFKAJJCI("");
		Material mat = this.AMCOGJHPPOC.DJHLKHLPAGA.OAJBECLLIEP("{not_found}");
		MotionBlurModel.Settings settings = base.BBEPCCALAFC.BMKMJEEBFHM();
		RenderTextureFormat format = this.AMCOGJHPPOC.DLFNPFAGPFC() ? RenderTextureFormat.RGHalf : RenderTextureFormat.ARGBHalf;
		int hmkdkkioiah = DGIEACBKFMJ.BNEACEICMJJ.HMKDKKIOIAH;
		ECKPLMDEJFD.GetTemporaryRT(hmkdkkioiah, this.AMCOGJHPPOC.NMCCGCOKKFA(), this.AMCOGJHPPOC.MMEMLJENMFF(), 0, FilterMode.Bilinear, format);
		if (settings.shutterAngle > 1153f && settings.frameBlending > 9f)
		{
			this.AKNGODHLNPI().DDBDBLAAKEJ(this.AMCOGJHPPOC, ECKPLMDEJFD, ref settings, BuiltinRenderTextureType.CameraTarget, hmkdkkioiah, mhnajnggdfj);
			this.AOJLGLKMPKA().KCNGMPKDJON(ECKPLMDEJFD, settings.frameBlending, hmkdkkioiah, BuiltinRenderTextureType.CameraTarget, mhnajnggdfj);
			this.EEFCEMMJBMA.FJEHHFDEGBN(ECKPLMDEJFD, hmkdkkioiah, this.AMCOGJHPPOC.GAIOLBJLPDL(), this.AMCOGJHPPOC.MMEMLJENMFF(), mhnajnggdfj);
		}
		else if (settings.shutterAngle > 1328f)
		{
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, BuiltinRenderTextureType.PrepassLight);
			ECKPLMDEJFD.Blit(BuiltinRenderTextureType.DepthNormals, hmkdkkioiah, mat, 1);
			this.FHNCEFPPMEF().MHPLJLIEDKF(this.AMCOGJHPPOC, ECKPLMDEJFD, ref settings, hmkdkkioiah, BuiltinRenderTextureType.CameraTarget, mhnajnggdfj);
		}
		else if (settings.frameBlending > 1360f)
		{
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, BuiltinRenderTextureType.CurrentActive);
			ECKPLMDEJFD.Blit((BuiltinRenderTextureType)6, hmkdkkioiah, mat, 0);
			this.HADKJCNKIHJ().IJACFGOAPLA(ECKPLMDEJFD, settings.frameBlending, hmkdkkioiah, BuiltinRenderTextureType.Depth, mhnajnggdfj);
			this.GIPPKBGIOBP().FJEHHFDEGBN(ECKPLMDEJFD, hmkdkkioiah, this.AMCOGJHPPOC.NMEBEEHCALN, this.AMCOGJHPPOC.NIEGJHLHEEB(), mhnajnggdfj);
		}
		ECKPLMDEJFD.ReleaseTemporaryRT(hmkdkkioiah);
	}

	// Token: 0x0601170D RID: 71437 RVA: 0x007C821C File Offset: 0x007C641C
	public void CCGIGJMJCDH()
	{
		this.IJDNJLIDLJE = false;
	}

	// Token: 0x0601170E RID: 71438 RVA: 0x007C8B63 File Offset: 0x007C6D63
	public string LMAHNMKGMFI()
	{
		return "IdleStrafeLeft";
	}

	// Token: 0x0601170F RID: 71439 RVA: 0x007C2B44 File Offset: 0x007C0D44
	public override CameraEvent POJFLMAFHEI()
	{
		return CameraEvent.BeforeImageEffects;
	}

	// Token: 0x06011710 RID: 71440 RVA: 0x007C84CD File Offset: 0x007C66CD
	public override void ADBAOPJBGHG()
	{
		this.IJDNJLIDLJE = true;
	}

	// Token: 0x06011711 RID: 71441 RVA: 0x007C842B File Offset: 0x007C662B
	public DGIEACBKFMJ.LBJNDEHNHOB HADKJCNKIHJ()
	{
		if (this.FPGLJKEBPND == null)
		{
			this.FPGLJKEBPND = new DGIEACBKFMJ.LBJNDEHNHOB();
		}
		return this.FPGLJKEBPND;
	}

	// Token: 0x06011712 RID: 71442 RVA: 0x007C8B6A File Offset: 0x007C6D6A
	public DepthTextureMode HDEDPBLMCBL()
	{
		return DepthTextureMode.MotionVectors;
	}

	// Token: 0x06011713 RID: 71443 RVA: 0x007C8B6D File Offset: 0x007C6D6D
	public void DNCDIBNCPLF()
	{
		if (this.FPGLJKEBPND != null)
		{
			this.FPGLJKEBPND.PPFAGLDPCIJ();
		}
		this.FPGLJKEBPND = null;
	}

	// Token: 0x06011714 RID: 71444 RVA: 0x007C8B8C File Offset: 0x007C6D8C
	public bool BJAIILKMCBK()
	{
		MotionBlurModel.Settings settings = base.BBEPCCALAFC.EFCLGKFCEMI();
		return !base.BBEPCCALAFC.enabled || ((settings.shutterAngle <= 1307f || !this.AKNGODHLNPI().BDGGKFDOBMH()) && settings.frameBlending <= 1541f) || SystemInfo.graphicsDeviceType == GraphicsDeviceType.Direct3D11 || this.AMCOGJHPPOC.NOAGCLGAJNE();
	}

	// Token: 0x06011715 RID: 71445 RVA: 0x007C8BF4 File Offset: 0x007C6DF4
	public bool LKCGDJDKBIN()
	{
		MotionBlurModel.Settings settings = base.BBEPCCALAFC.settings;
		return base.BBEPCCALAFC.enabled && ((settings.shutterAngle > 921f && this.BHFKEKJBDLH().AOAPBHPOFKJ()) || settings.frameBlending > 94f) && SystemInfo.graphicsDeviceType != GraphicsDeviceType.Xbox360 && this.AMCOGJHPPOC.MLJCADOONGI();
	}

	// Token: 0x06011716 RID: 71446 RVA: 0x007C8201 File Offset: 0x007C6401
	public DGIEACBKFMJ.LKOGFPMIKAK LGJOJOJKBJH()
	{
		if (this.EJBMJCBCHGK == null)
		{
			this.EJBMJCBCHGK = new DGIEACBKFMJ.LKOGFPMIKAK();
		}
		return this.EJBMJCBCHGK;
	}

	// Token: 0x06011717 RID: 71447 RVA: 0x007C842B File Offset: 0x007C662B
	public DGIEACBKFMJ.LBJNDEHNHOB BHCGBIDCCNC()
	{
		if (this.FPGLJKEBPND == null)
		{
			this.FPGLJKEBPND = new DGIEACBKFMJ.LBJNDEHNHOB();
		}
		return this.FPGLJKEBPND;
	}

	// Token: 0x06011718 RID: 71448 RVA: 0x007C821C File Offset: 0x007C641C
	public void CABDFNIKOOI()
	{
		this.IJDNJLIDLJE = false;
	}

	// Token: 0x170003D0 RID: 976
	// (get) Token: 0x06011719 RID: 71449 RVA: 0x007C8C5C File Offset: 0x007C6E5C
	public override bool NLFEIOCKHKA
	{
		get
		{
			MotionBlurModel.Settings settings = base.BBEPCCALAFC.settings;
			return base.BBEPCCALAFC.enabled && ((settings.shutterAngle > 0f && this.NEGKMNKFKKH.MLBELGPBEFK()) || settings.frameBlending > 0f) && SystemInfo.graphicsDeviceType != GraphicsDeviceType.OpenGLES2 && !this.AMCOGJHPPOC.CFABOAAPLPI;
		}
	}

	// Token: 0x0601171A RID: 71450 RVA: 0x007C8CC1 File Offset: 0x007C6EC1
	public void GDCAKFIINFI()
	{
		if (this.FPGLJKEBPND != null)
		{
			this.FPGLJKEBPND.CILKJPLLJKH();
		}
	}

	// Token: 0x0601171B RID: 71451 RVA: 0x007C84F2 File Offset: 0x007C66F2
	public override DepthTextureMode PPAJFNGHBCF()
	{
		return DepthTextureMode.Depth | DepthTextureMode.MotionVectors;
	}

	// Token: 0x0601171C RID: 71452 RVA: 0x007C8CD8 File Offset: 0x007C6ED8
	public void PEJMALGJLFH(CommandBuffer ECKPLMDEJFD)
	{
		if (this.IJDNJLIDLJE)
		{
			this.IJDNJLIDLJE = false;
			return;
		}
		Material mhnajnggdfj = this.AMCOGJHPPOC.DJHLKHLPAGA.HPAJGFGNMOH("buykey");
		Material mat = this.AMCOGJHPPOC.DJHLKHLPAGA.MLAKMCAPCOJ("int: ");
		MotionBlurModel.Settings settings = base.BBEPCCALAFC.MJAFCPCECCL();
		RenderTextureFormat format = this.AMCOGJHPPOC.JFIIMCOAHFG() ? ((RenderTextureFormat)(-29)) : RenderTextureFormat.Shadowmap;
		int hmkdkkioiah = DGIEACBKFMJ.BNEACEICMJJ.HMKDKKIOIAH;
		ECKPLMDEJFD.GetTemporaryRT(hmkdkkioiah, this.AMCOGJHPPOC.EOMMKPDCAML(), this.AMCOGJHPPOC.LHPBMEDMNDO(), 0, FilterMode.Point, format);
		if (settings.shutterAngle > 635f && settings.frameBlending > 1229f)
		{
			this.NEGKMNKFKKH.AOEEJJKNENM(this.AMCOGJHPPOC, ECKPLMDEJFD, ref settings, BuiltinRenderTextureType.PrepassNormalsSpec, hmkdkkioiah, mhnajnggdfj);
			this.HADKJCNKIHJ().JDBEFCLDLBH(ECKPLMDEJFD, settings.frameBlending, hmkdkkioiah, BuiltinRenderTextureType.CurrentActive, mhnajnggdfj);
			this.BHCGBIDCCNC().FGBILPKOJBE(ECKPLMDEJFD, hmkdkkioiah, this.AMCOGJHPPOC.IGHJHMGOGOO(), this.AMCOGJHPPOC.LKLNPJICOHH(), mhnajnggdfj);
		}
		else if (settings.shutterAngle > 1639f)
		{
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, BuiltinRenderTextureType.PrepassNormalsSpec);
			ECKPLMDEJFD.Blit(BuiltinRenderTextureType.None, hmkdkkioiah, mat, 1);
			this.JLPHHBOHJOE().GJDMCPHLELD(this.AMCOGJHPPOC, ECKPLMDEJFD, ref settings, hmkdkkioiah, BuiltinRenderTextureType.DepthNormals, mhnajnggdfj);
		}
		else if (settings.frameBlending > 1249f)
		{
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, (BuiltinRenderTextureType)6);
			ECKPLMDEJFD.Blit(BuiltinRenderTextureType.PrepassLight, hmkdkkioiah, mat, 1);
			this.KFNDMIAGMLH().HJBMEANCAHP(ECKPLMDEJFD, settings.frameBlending, hmkdkkioiah, BuiltinRenderTextureType.CameraTarget, mhnajnggdfj);
			this.GKGAENCEDGK().BPHNOPFMEHI(ECKPLMDEJFD, hmkdkkioiah, this.AMCOGJHPPOC.OJNDCCHLMNK(), this.AMCOGJHPPOC.HJOKFIGACEC(), mhnajnggdfj);
		}
		ECKPLMDEJFD.ReleaseTemporaryRT(hmkdkkioiah);
	}

	// Token: 0x0601171D RID: 71453 RVA: 0x007C8ECF File Offset: 0x007C70CF
	public CameraEvent EEIMGDHPEHK()
	{
		return (CameraEvent)61;
	}

	// Token: 0x0601171E RID: 71454 RVA: 0x007C8ED3 File Offset: 0x007C70D3
	public void EHKCHPFDNCA()
	{
		if (this.FPGLJKEBPND != null)
		{
			this.FPGLJKEBPND.LPMNIGCLDED();
		}
	}

	// Token: 0x0601171F RID: 71455 RVA: 0x007C8EE8 File Offset: 0x007C70E8
	public string JEFOMLDHDGO()
	{
		return "OfficeSittingReadingLeanBack";
	}

	// Token: 0x06011720 RID: 71456 RVA: 0x007C8EEF File Offset: 0x007C70EF
	public CameraEvent HICBBLJNLNK()
	{
		return (CameraEvent)(-31);
	}

	// Token: 0x06011721 RID: 71457 RVA: 0x007C842B File Offset: 0x007C662B
	public DGIEACBKFMJ.LBJNDEHNHOB GKGAENCEDGK()
	{
		if (this.FPGLJKEBPND == null)
		{
			this.FPGLJKEBPND = new DGIEACBKFMJ.LBJNDEHNHOB();
		}
		return this.FPGLJKEBPND;
	}

	// Token: 0x06011722 RID: 71458 RVA: 0x007C8EF3 File Offset: 0x007C70F3
	public void KJAKKAMNEPG()
	{
		if (this.FPGLJKEBPND != null)
		{
			this.FPGLJKEBPND.HAKBCPBCEJJ();
		}
	}

	// Token: 0x06011723 RID: 71459 RVA: 0x007C8CC1 File Offset: 0x007C6EC1
	public void LAFIABNCFPD()
	{
		if (this.FPGLJKEBPND != null)
		{
			this.FPGLJKEBPND.CILKJPLLJKH();
		}
	}

	// Token: 0x06011724 RID: 71460 RVA: 0x007C821C File Offset: 0x007C641C
	public void CCMOKEDKMNJ()
	{
		this.IJDNJLIDLJE = false;
	}

	// Token: 0x06011725 RID: 71461 RVA: 0x000EADB7 File Offset: 0x000E8FB7
	public DepthTextureMode JPPBBACPJAB()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x06011726 RID: 71462 RVA: 0x007C8201 File Offset: 0x007C6401
	public DGIEACBKFMJ.LKOGFPMIKAK PEJIBAEDJEJ()
	{
		if (this.EJBMJCBCHGK == null)
		{
			this.EJBMJCBCHGK = new DGIEACBKFMJ.LKOGFPMIKAK();
		}
		return this.EJBMJCBCHGK;
	}

	// Token: 0x06011727 RID: 71463 RVA: 0x007C815F File Offset: 0x007C635F
	public void MIOPKCEHLFH()
	{
		if (this.FPGLJKEBPND != null)
		{
			this.FPGLJKEBPND.MDMCJHOIABB();
		}
		this.FPGLJKEBPND = null;
	}

	// Token: 0x06011728 RID: 71464 RVA: 0x007C8F08 File Offset: 0x007C7108
	public CameraEvent BOAJNCFIPHP()
	{
		return (CameraEvent)89;
	}

	// Token: 0x06011729 RID: 71465 RVA: 0x007C8F0C File Offset: 0x007C710C
	public bool FNHNEJNNKOJ()
	{
		MotionBlurModel.Settings settings = base.BBEPCCALAFC.CNAAMGCNGHF();
		return !base.BBEPCCALAFC.enabled || ((settings.shutterAngle <= 1848f || !this.NCAANNFANCH().NOIJGHJJCPL()) && settings.frameBlending <= 828f) || SystemInfo.graphicsDeviceType == GraphicsDeviceType.Xbox360 || !this.AMCOGJHPPOC.IPMGKDLKDHF();
	}

	// Token: 0x0601172A RID: 71466 RVA: 0x007C8F74 File Offset: 0x007C7174
	public void LKPCPEJDPHN(CommandBuffer ECKPLMDEJFD)
	{
		if (this.IJDNJLIDLJE)
		{
			this.IJDNJLIDLJE = false;
			return;
		}
		Material mhnajnggdfj = this.AMCOGJHPPOC.DJHLKHLPAGA.PIPNAHLJKKD("tech");
		Material mat = this.AMCOGJHPPOC.DJHLKHLPAGA.PIPNAHLJKKD("RollerBladeRoll");
		MotionBlurModel.Settings settings = base.BBEPCCALAFC.KBKJIODBLGM();
		RenderTextureFormat format = this.AMCOGJHPPOC.JFIIMCOAHFG() ? RenderTextureFormat.RInt : RenderTextureFormat.RGB565;
		int hmkdkkioiah = DGIEACBKFMJ.BNEACEICMJJ.HMKDKKIOIAH;
		ECKPLMDEJFD.GetTemporaryRT(hmkdkkioiah, this.AMCOGJHPPOC.OJNDCCHLMNK(), this.AMCOGJHPPOC.MMEMLJENMFF(), 1, FilterMode.Point, format);
		if (settings.shutterAngle > 104f && settings.frameBlending > 1824f)
		{
			this.INJCLCCFLHM().LAFJDANAPCI(this.AMCOGJHPPOC, ECKPLMDEJFD, ref settings, BuiltinRenderTextureType.DepthNormals, hmkdkkioiah, mhnajnggdfj);
			this.AOJLGLKMPKA().IJACFGOAPLA(ECKPLMDEJFD, settings.frameBlending, hmkdkkioiah, BuiltinRenderTextureType.ResolvedDepth, mhnajnggdfj);
			this.AOJLGLKMPKA().FJEHHFDEGBN(ECKPLMDEJFD, hmkdkkioiah, this.AMCOGJHPPOC.KJDPLLFIIBK(), this.AMCOGJHPPOC.CICDECHCDBJ(), mhnajnggdfj);
		}
		else if (settings.shutterAngle > 1197f)
		{
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, BuiltinRenderTextureType.CameraTarget);
			ECKPLMDEJFD.Blit(BuiltinRenderTextureType.PrepassLight, hmkdkkioiah, mat, 0);
			this.AKNGODHLNPI().FHACGOMJPCK(this.AMCOGJHPPOC, ECKPLMDEJFD, ref settings, hmkdkkioiah, BuiltinRenderTextureType.DepthNormals, mhnajnggdfj);
		}
		else if (settings.frameBlending > 1202f)
		{
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, BuiltinRenderTextureType.PrepassLight);
			ECKPLMDEJFD.Blit(BuiltinRenderTextureType.PrepassLight, hmkdkkioiah, mat, 0);
			this.EEFCEMMJBMA.FDGKFBDLHIG(ECKPLMDEJFD, settings.frameBlending, hmkdkkioiah, BuiltinRenderTextureType.ResolvedDepth, mhnajnggdfj);
			this.GDFHLHMJECF().FGBILPKOJBE(ECKPLMDEJFD, hmkdkkioiah, this.AMCOGJHPPOC.PAHBMDOJHKK(), this.AMCOGJHPPOC.KNKKIHDHBFD(), mhnajnggdfj);
		}
		ECKPLMDEJFD.ReleaseTemporaryRT(hmkdkkioiah);
	}

	// Token: 0x0601172B RID: 71467 RVA: 0x007C842B File Offset: 0x007C662B
	public DGIEACBKFMJ.LBJNDEHNHOB GFJJODFJBIN()
	{
		if (this.FPGLJKEBPND == null)
		{
			this.FPGLJKEBPND = new DGIEACBKFMJ.LBJNDEHNHOB();
		}
		return this.FPGLJKEBPND;
	}

	// Token: 0x0601172C RID: 71468 RVA: 0x007C916C File Offset: 0x007C736C
	public bool KMDJPIIHONJ()
	{
		MotionBlurModel.Settings settings = base.BBEPCCALAFC.FAAFENGEOHB();
		return base.BBEPCCALAFC.enabled && ((settings.shutterAngle > 1332f && this.BHFKEKJBDLH().PGEOBFCALMJ()) || settings.frameBlending > 358f) && SystemInfo.graphicsDeviceType != (GraphicsDeviceType)7 && this.AMCOGJHPPOC.ANFINECKHNH();
	}

	// Token: 0x0601172D RID: 71469 RVA: 0x007C91D1 File Offset: 0x007C73D1
	public override string KPGFOFFHPOO()
	{
		return "Motion Blur";
	}

	// Token: 0x0601172E RID: 71470 RVA: 0x007C91D8 File Offset: 0x007C73D8
	public bool OEDNBNLAJMA()
	{
		MotionBlurModel.Settings settings = base.BBEPCCALAFC.KOMEDFGKGGE();
		return !base.BBEPCCALAFC.enabled || ((settings.shutterAngle <= 841f || !this.LGJOJOJKBJH().PGEOBFCALMJ()) && settings.frameBlending <= 80f) || SystemInfo.graphicsDeviceType == (GraphicsDeviceType)7 || !this.AMCOGJHPPOC.NOAGCLGAJNE();
	}

	// Token: 0x0601172F RID: 71471 RVA: 0x007C923D File Offset: 0x007C743D
	public void GGNPNBDONAI()
	{
		if (this.FPGLJKEBPND != null)
		{
			this.FPGLJKEBPND.DAGFCHOFMFP();
		}
		this.FPGLJKEBPND = null;
	}

	// Token: 0x06011730 RID: 71472 RVA: 0x007C8B6A File Offset: 0x007C6D6A
	public DepthTextureMode GGIEEAMIGPM()
	{
		return DepthTextureMode.MotionVectors;
	}

	// Token: 0x06011731 RID: 71473 RVA: 0x007C8EF3 File Offset: 0x007C70F3
	public void LNNKANCIIFM()
	{
		if (this.FPGLJKEBPND != null)
		{
			this.FPGLJKEBPND.HAKBCPBCEJJ();
		}
	}

	// Token: 0x06011732 RID: 71474 RVA: 0x007C84CD File Offset: 0x007C66CD
	public void KGGJHGNEHGM()
	{
		this.IJDNJLIDLJE = true;
	}

	// Token: 0x06011733 RID: 71475 RVA: 0x007C842B File Offset: 0x007C662B
	public DGIEACBKFMJ.LBJNDEHNHOB GIPPKBGIOBP()
	{
		if (this.FPGLJKEBPND == null)
		{
			this.FPGLJKEBPND = new DGIEACBKFMJ.LBJNDEHNHOB();
		}
		return this.FPGLJKEBPND;
	}

	// Token: 0x06011734 RID: 71476 RVA: 0x007C9259 File Offset: 0x007C7459
	public void NOLGMGLINIJ()
	{
		if (this.FPGLJKEBPND != null)
		{
			this.FPGLJKEBPND.PPFAGLDPCIJ();
		}
	}

	// Token: 0x06011735 RID: 71477 RVA: 0x007C926E File Offset: 0x007C746E
	public string ABDHLLMHNKI()
	{
		return "Block";
	}

	// Token: 0x06011736 RID: 71478 RVA: 0x007C9275 File Offset: 0x007C7475
	public string GHIEILHCJCL()
	{
		return "DealerFan";
	}

	// Token: 0x06011737 RID: 71479 RVA: 0x007C923D File Offset: 0x007C743D
	public void GHAMPDBLEPC()
	{
		if (this.FPGLJKEBPND != null)
		{
			this.FPGLJKEBPND.DAGFCHOFMFP();
		}
		this.FPGLJKEBPND = null;
	}

	// Token: 0x06011738 RID: 71480 RVA: 0x007C927C File Offset: 0x007C747C
	public void FEPGHFFNJHK()
	{
		if (this.FPGLJKEBPND != null)
		{
			this.FPGLJKEBPND.CKFAGEDEOEH();
		}
		this.FPGLJKEBPND = null;
	}

	// Token: 0x06011739 RID: 71481 RVA: 0x007C927C File Offset: 0x007C747C
	public void JAJPNDNNMEN()
	{
		if (this.FPGLJKEBPND != null)
		{
			this.FPGLJKEBPND.CKFAGEDEOEH();
		}
		this.FPGLJKEBPND = null;
	}

	// Token: 0x0601173A RID: 71482 RVA: 0x007C842B File Offset: 0x007C662B
	public DGIEACBKFMJ.LBJNDEHNHOB GDFHLHMJECF()
	{
		if (this.FPGLJKEBPND == null)
		{
			this.FPGLJKEBPND = new DGIEACBKFMJ.LBJNDEHNHOB();
		}
		return this.FPGLJKEBPND;
	}

	// Token: 0x0601173B RID: 71483 RVA: 0x007C8B6A File Offset: 0x007C6D6A
	public DepthTextureMode CBEICJIJKCI()
	{
		return DepthTextureMode.MotionVectors;
	}

	// Token: 0x0601173C RID: 71484 RVA: 0x007C9298 File Offset: 0x007C7498
	public void JJHCGFKFJKH()
	{
		if (this.FPGLJKEBPND != null)
		{
			this.FPGLJKEBPND.FILFNLHGPFH();
		}
		this.FPGLJKEBPND = null;
	}

	// Token: 0x0601173D RID: 71485 RVA: 0x007C84D6 File Offset: 0x007C66D6
	public void KHCEDCDKGMH()
	{
		if (this.FPGLJKEBPND != null)
		{
			this.FPGLJKEBPND.NCIPOCENKDJ();
		}
		this.FPGLJKEBPND = null;
	}

	// Token: 0x0601173E RID: 71486 RVA: 0x007C92B4 File Offset: 0x007C74B4
	public void ANHJAOPPMCI()
	{
		if (this.FPGLJKEBPND != null)
		{
			this.FPGLJKEBPND.JFMFEDPJFPD();
		}
	}

	// Token: 0x0601173F RID: 71487 RVA: 0x007C92CC File Offset: 0x007C74CC
	public bool MGOPKGFOEMG()
	{
		MotionBlurModel.Settings settings = base.BBEPCCALAFC.EFCLGKFCEMI();
		return !base.BBEPCCALAFC.enabled || ((settings.shutterAngle <= 643f || !this.BHFKEKJBDLH().FEBMKGJGMOA()) && settings.frameBlending <= 1489f) || SystemInfo.graphicsDeviceType == GraphicsDeviceType.OpenGLES2 || !this.AMCOGJHPPOC.HALNOLGLEOJ();
	}

	// Token: 0x06011740 RID: 71488 RVA: 0x007C9331 File Offset: 0x007C7531
	public CameraEvent JONIJFJOPFG()
	{
		return (CameraEvent)(-63);
	}

	// Token: 0x06011741 RID: 71489 RVA: 0x007C7F51 File Offset: 0x007C6151
	public void OEIIHELBMFG()
	{
		if (this.FPGLJKEBPND != null)
		{
			this.FPGLJKEBPND.PDMPPHDGIEO();
		}
	}

	// Token: 0x06011742 RID: 71490 RVA: 0x007C8B6A File Offset: 0x007C6D6A
	public DepthTextureMode KEMBAHKFDDE()
	{
		return DepthTextureMode.MotionVectors;
	}

	// Token: 0x06011743 RID: 71491 RVA: 0x007C9338 File Offset: 0x007C7538
	public void LDIMLLBNBPE(CommandBuffer ECKPLMDEJFD)
	{
		if (this.IJDNJLIDLJE)
		{
			this.IJDNJLIDLJE = false;
			return;
		}
		Material mhnajnggdfj = this.AMCOGJHPPOC.DJHLKHLPAGA.ACEOHEODOMJ("Flares");
		Material mat = this.AMCOGJHPPOC.DJHLKHLPAGA.ACEOHEODOMJ("*********read ");
		MotionBlurModel.Settings settings = base.BBEPCCALAFC.MNIFHEEFLNH();
		RenderTextureFormat format = this.AMCOGJHPPOC.BLMBFAOCMNK() ? ((RenderTextureFormat)70) : RenderTextureFormat.RGB565;
		int hmkdkkioiah = DGIEACBKFMJ.BNEACEICMJJ.HMKDKKIOIAH;
		ECKPLMDEJFD.GetTemporaryRT(hmkdkkioiah, this.AMCOGJHPPOC.OCNEHBGMHGB(), this.AMCOGJHPPOC.GGGEFNKEPDB(), 1, FilterMode.Point, format);
		if (settings.shutterAngle > 1488f && settings.frameBlending > 354f)
		{
			this.JLPHHBOHJOE().BBKHKPMLHEE(this.AMCOGJHPPOC, ECKPLMDEJFD, ref settings, BuiltinRenderTextureType.ResolvedDepth, hmkdkkioiah, mhnajnggdfj);
			this.GKGAENCEDGK().DMHMNAPJOMO(ECKPLMDEJFD, settings.frameBlending, hmkdkkioiah, (BuiltinRenderTextureType)6, mhnajnggdfj);
			this.GKGAENCEDGK().CBDHBMPFHMJ(ECKPLMDEJFD, hmkdkkioiah, this.AMCOGJHPPOC.NMCCGCOKKFA(), this.AMCOGJHPPOC.NIEGJHLHEEB(), mhnajnggdfj);
		}
		else if (settings.shutterAngle > 1083f)
		{
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, (BuiltinRenderTextureType)6);
			ECKPLMDEJFD.Blit(BuiltinRenderTextureType.Depth, hmkdkkioiah, mat, 0);
			this.LGJOJOJKBJH().FAECMGEMDFA(this.AMCOGJHPPOC, ECKPLMDEJFD, ref settings, hmkdkkioiah, BuiltinRenderTextureType.DepthNormals, mhnajnggdfj);
		}
		else if (settings.frameBlending > 1084f)
		{
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, BuiltinRenderTextureType.PrepassNormalsSpec);
			ECKPLMDEJFD.Blit((BuiltinRenderTextureType)6, hmkdkkioiah, mat, 1);
			this.GKGAENCEDGK().PPCOBPHPNBL(ECKPLMDEJFD, settings.frameBlending, hmkdkkioiah, BuiltinRenderTextureType.ResolvedDepth, mhnajnggdfj);
			this.GFJJODFJBIN().NGNHPGLIPKE(ECKPLMDEJFD, hmkdkkioiah, this.AMCOGJHPPOC.DJGCPIEOAFC(), this.AMCOGJHPPOC.GGGEFNKEPDB(), mhnajnggdfj);
		}
		ECKPLMDEJFD.ReleaseTemporaryRT(hmkdkkioiah);
	}

	// Token: 0x06011744 RID: 71492 RVA: 0x007C952F File Offset: 0x007C772F
	public CameraEvent AGLNKIPKOAD()
	{
		return (CameraEvent)(-16);
	}

	// Token: 0x06011745 RID: 71493 RVA: 0x007C9534 File Offset: 0x007C7734
	public bool ABDJCLLOHFB()
	{
		MotionBlurModel.Settings settings = base.BBEPCCALAFC.HBGIDHBLFHE();
		return base.BBEPCCALAFC.enabled && ((settings.shutterAngle > 1107f && this.AKNGODHLNPI().BHBHLNEJOIH()) || settings.frameBlending > 116f) && SystemInfo.graphicsDeviceType != GraphicsDeviceType.PlayStation3 && this.AMCOGJHPPOC.CHJAIAPCMDC();
	}

	// Token: 0x06011746 RID: 71494 RVA: 0x007C9599 File Offset: 0x007C7799
	public void CCCAOGJKJOD()
	{
		if (this.FPGLJKEBPND != null)
		{
			this.FPGLJKEBPND.DMNLGGGNEBD();
		}
	}

	// Token: 0x06011747 RID: 71495 RVA: 0x007C81AC File Offset: 0x007C63AC
	public void GBAEKFJBEFM()
	{
		if (this.FPGLJKEBPND != null)
		{
			this.FPGLJKEBPND.DAGFCHOFMFP();
		}
	}

	// Token: 0x06011748 RID: 71496 RVA: 0x007C95B0 File Offset: 0x007C77B0
	public void GKMLAGHBMAL(CommandBuffer ECKPLMDEJFD)
	{
		if (this.IJDNJLIDLJE)
		{
			this.IJDNJLIDLJE = false;
			return;
		}
		Material mhnajnggdfj = this.AMCOGJHPPOC.DJHLKHLPAGA.OFIEMCNMGHM("MotorbikeHeadstand");
		Material mat = this.AMCOGJHPPOC.DJHLKHLPAGA.DLNFGMANLPN("ZombieCrawl");
		MotionBlurModel.Settings settings = base.BBEPCCALAFC.MIBJNGOAOFD();
		RenderTextureFormat format = this.AMCOGJHPPOC.ANPIAKEADME() ? ((RenderTextureFormat)(-31)) : RenderTextureFormat.Shadowmap;
		int hmkdkkioiah = DGIEACBKFMJ.BNEACEICMJJ.HMKDKKIOIAH;
		ECKPLMDEJFD.GetTemporaryRT(hmkdkkioiah, this.AMCOGJHPPOC.OCNEHBGMHGB(), this.AMCOGJHPPOC.LPJJBJCIELA(), 1, FilterMode.Bilinear, format);
		if (settings.shutterAngle > 1359f && settings.frameBlending > 1587f)
		{
			this.LGJOJOJKBJH().NDEOLIHCDCO(this.AMCOGJHPPOC, ECKPLMDEJFD, ref settings, BuiltinRenderTextureType.None, hmkdkkioiah, mhnajnggdfj);
			this.HADKJCNKIHJ().FDGKFBDLHIG(ECKPLMDEJFD, settings.frameBlending, hmkdkkioiah, BuiltinRenderTextureType.ResolvedDepth, mhnajnggdfj);
			this.GFJJODFJBIN().JJBFMHFDJJF(ECKPLMDEJFD, hmkdkkioiah, this.AMCOGJHPPOC.IBPMMKDPDEO(), this.AMCOGJHPPOC.ILLKFNCFGMP, mhnajnggdfj);
		}
		else if (settings.shutterAngle > 190f)
		{
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, BuiltinRenderTextureType.None);
			ECKPLMDEJFD.Blit(BuiltinRenderTextureType.CameraTarget, hmkdkkioiah, mat, 1);
			this.PEJIBAEDJEJ().LJLEGMMDPML(this.AMCOGJHPPOC, ECKPLMDEJFD, ref settings, hmkdkkioiah, BuiltinRenderTextureType.PrepassNormalsSpec, mhnajnggdfj);
		}
		else if (settings.frameBlending > 1641f)
		{
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, BuiltinRenderTextureType.CurrentActive);
			ECKPLMDEJFD.Blit(BuiltinRenderTextureType.PrepassNormalsSpec, hmkdkkioiah, mat, 0);
			this.GIPPKBGIOBP().PPCOBPHPNBL(ECKPLMDEJFD, settings.frameBlending, hmkdkkioiah, BuiltinRenderTextureType.ResolvedDepth, mhnajnggdfj);
			this.GDFHLHMJECF().CCGKAKJHOMM(ECKPLMDEJFD, hmkdkkioiah, this.AMCOGJHPPOC.PAHBMDOJHKK(), this.AMCOGJHPPOC.GHMBALIHBOH(), mhnajnggdfj);
		}
		ECKPLMDEJFD.ReleaseTemporaryRT(hmkdkkioiah);
	}

	// Token: 0x06011749 RID: 71497 RVA: 0x007C97A7 File Offset: 0x007C79A7
	public CameraEvent PBAJFEPKOCI()
	{
		return (CameraEvent)115;
	}

	// Token: 0x0601174A RID: 71498 RVA: 0x007C842B File Offset: 0x007C662B
	public DGIEACBKFMJ.LBJNDEHNHOB AOJLGLKMPKA()
	{
		if (this.FPGLJKEBPND == null)
		{
			this.FPGLJKEBPND = new DGIEACBKFMJ.LBJNDEHNHOB();
		}
		return this.FPGLJKEBPND;
	}

	// Token: 0x0601174B RID: 71499 RVA: 0x007C8B6D File Offset: 0x007C6D6D
	public void FLABNMEJAEC()
	{
		if (this.FPGLJKEBPND != null)
		{
			this.FPGLJKEBPND.PPFAGLDPCIJ();
		}
		this.FPGLJKEBPND = null;
	}

	// Token: 0x0601174C RID: 71500 RVA: 0x007C8201 File Offset: 0x007C6401
	public DGIEACBKFMJ.LKOGFPMIKAK INJCLCCFLHM()
	{
		if (this.EJBMJCBCHGK == null)
		{
			this.EJBMJCBCHGK = new DGIEACBKFMJ.LKOGFPMIKAK();
		}
		return this.EJBMJCBCHGK;
	}

	// Token: 0x0601174D RID: 71501 RVA: 0x007C84CD File Offset: 0x007C66CD
	public void EBAJDGLIAPE()
	{
		this.IJDNJLIDLJE = true;
	}

	// Token: 0x0601174E RID: 71502 RVA: 0x007C97AB File Offset: 0x007C79AB
	public string MEHDCJGDJNN()
	{
		return "<color='#001040'>";
	}

	// Token: 0x0601174F RID: 71503 RVA: 0x007C97B2 File Offset: 0x007C79B2
	public string KPGMDEMDHFJ()
	{
		return " has been unloaded successfully";
	}

	// Token: 0x06011750 RID: 71504 RVA: 0x007C8201 File Offset: 0x007C6401
	public DGIEACBKFMJ.LKOGFPMIKAK LDFBJLJNEDM()
	{
		if (this.EJBMJCBCHGK == null)
		{
			this.EJBMJCBCHGK = new DGIEACBKFMJ.LKOGFPMIKAK();
		}
		return this.EJBMJCBCHGK;
	}

	// Token: 0x06011751 RID: 71505 RVA: 0x007C9298 File Offset: 0x007C7498
	public void OGDKPBNOBND()
	{
		if (this.FPGLJKEBPND != null)
		{
			this.FPGLJKEBPND.FILFNLHGPFH();
		}
		this.FPGLJKEBPND = null;
	}

	// Token: 0x06011752 RID: 71506 RVA: 0x007C97B9 File Offset: 0x007C79B9
	public CameraEvent GAMKHMOFHIA()
	{
		return CameraEvent.BeforeDepthNormalsTexture;
	}

	// Token: 0x06011753 RID: 71507 RVA: 0x007C97BD File Offset: 0x007C79BD
	public void LLLBNNNNFPJ()
	{
		if (this.FPGLJKEBPND != null)
		{
			this.FPGLJKEBPND.CFJLAKAECMF();
		}
	}

	// Token: 0x06011754 RID: 71508 RVA: 0x007C7F51 File Offset: 0x007C6151
	public void LBABEDLHAIC()
	{
		if (this.FPGLJKEBPND != null)
		{
			this.FPGLJKEBPND.PDMPPHDGIEO();
		}
	}

	// Token: 0x06011755 RID: 71509 RVA: 0x007C84CD File Offset: 0x007C66CD
	public void LEKDBOJGNEG()
	{
		this.IJDNJLIDLJE = true;
	}

	// Token: 0x06011756 RID: 71510 RVA: 0x007C97D4 File Offset: 0x007C79D4
	public bool EFOGKBEBNHC()
	{
		MotionBlurModel.Settings settings = base.BBEPCCALAFC.settings;
		return !base.BBEPCCALAFC.enabled || ((settings.shutterAngle <= 1651f || !this.LGJOJOJKBJH().FDGCFHEJKAK()) && settings.frameBlending <= 393f) || SystemInfo.graphicsDeviceType == GraphicsDeviceType.Xbox360 || this.AMCOGJHPPOC.GCPDMBIEAOG();
	}

	// Token: 0x06011757 RID: 71511 RVA: 0x007C983C File Offset: 0x007C7A3C
	public override void DNELHGGBBOO(CommandBuffer ECKPLMDEJFD)
	{
		if (this.IJDNJLIDLJE)
		{
			this.IJDNJLIDLJE = false;
			return;
		}
		Material mhnajnggdfj = this.AMCOGJHPPOC.DJHLKHLPAGA.AFONGIICOJG("Hidden/Post FX/Motion Blur");
		Material mat = this.AMCOGJHPPOC.DJHLKHLPAGA.AFONGIICOJG("Hidden/Post FX/Blit");
		MotionBlurModel.Settings settings = base.BBEPCCALAFC.settings;
		RenderTextureFormat format = this.AMCOGJHPPOC.MAIODKMOICL ? RenderTextureFormat.DefaultHDR : RenderTextureFormat.Default;
		int hmkdkkioiah = DGIEACBKFMJ.BNEACEICMJJ.HMKDKKIOIAH;
		ECKPLMDEJFD.GetTemporaryRT(hmkdkkioiah, this.AMCOGJHPPOC.NMEBEEHCALN, this.AMCOGJHPPOC.ILLKFNCFGMP, 0, FilterMode.Point, format);
		if (settings.shutterAngle > 0f && settings.frameBlending > 0f)
		{
			this.NEGKMNKFKKH.FEHDGELLGIG(this.AMCOGJHPPOC, ECKPLMDEJFD, ref settings, BuiltinRenderTextureType.CameraTarget, hmkdkkioiah, mhnajnggdfj);
			this.EEFCEMMJBMA.AHHOEANDLLK(ECKPLMDEJFD, settings.frameBlending, hmkdkkioiah, BuiltinRenderTextureType.CameraTarget, mhnajnggdfj);
			this.EEFCEMMJBMA.KABENKAHGNG(ECKPLMDEJFD, hmkdkkioiah, this.AMCOGJHPPOC.NMEBEEHCALN, this.AMCOGJHPPOC.ILLKFNCFGMP, mhnajnggdfj);
		}
		else if (settings.shutterAngle > 0f)
		{
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, BuiltinRenderTextureType.CameraTarget);
			ECKPLMDEJFD.Blit(BuiltinRenderTextureType.CameraTarget, hmkdkkioiah, mat, 0);
			this.NEGKMNKFKKH.FEHDGELLGIG(this.AMCOGJHPPOC, ECKPLMDEJFD, ref settings, hmkdkkioiah, BuiltinRenderTextureType.CameraTarget, mhnajnggdfj);
		}
		else if (settings.frameBlending > 0f)
		{
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, BuiltinRenderTextureType.CameraTarget);
			ECKPLMDEJFD.Blit(BuiltinRenderTextureType.CameraTarget, hmkdkkioiah, mat, 0);
			this.EEFCEMMJBMA.AHHOEANDLLK(ECKPLMDEJFD, settings.frameBlending, hmkdkkioiah, BuiltinRenderTextureType.CameraTarget, mhnajnggdfj);
			this.EEFCEMMJBMA.KABENKAHGNG(ECKPLMDEJFD, hmkdkkioiah, this.AMCOGJHPPOC.NMEBEEHCALN, this.AMCOGJHPPOC.ILLKFNCFGMP, mhnajnggdfj);
		}
		ECKPLMDEJFD.ReleaseTemporaryRT(hmkdkkioiah);
	}

	// Token: 0x170003CF RID: 975
	// (get) Token: 0x06011758 RID: 71512 RVA: 0x007C842B File Offset: 0x007C662B
	public DGIEACBKFMJ.LBJNDEHNHOB EEFCEMMJBMA
	{
		get
		{
			if (this.FPGLJKEBPND == null)
			{
				this.FPGLJKEBPND = new DGIEACBKFMJ.LBJNDEHNHOB();
			}
			return this.FPGLJKEBPND;
		}
	}

	// Token: 0x06011759 RID: 71513 RVA: 0x007C8201 File Offset: 0x007C6401
	public DGIEACBKFMJ.LKOGFPMIKAK JLPHHBOHJOE()
	{
		if (this.EJBMJCBCHGK == null)
		{
			this.EJBMJCBCHGK = new DGIEACBKFMJ.LKOGFPMIKAK();
		}
		return this.EJBMJCBCHGK;
	}

	// Token: 0x0601175A RID: 71514 RVA: 0x007C9A33 File Offset: 0x007C7C33
	public string EALBCFONJIH()
	{
		return " cm";
	}

	// Token: 0x0601175B RID: 71515 RVA: 0x007C842B File Offset: 0x007C662B
	public DGIEACBKFMJ.LBJNDEHNHOB DGFJOHKLCKB()
	{
		if (this.FPGLJKEBPND == null)
		{
			this.FPGLJKEBPND = new DGIEACBKFMJ.LBJNDEHNHOB();
		}
		return this.FPGLJKEBPND;
	}

	// Token: 0x0601175C RID: 71516 RVA: 0x007C821C File Offset: 0x007C641C
	public void ENHOALKJFJF()
	{
		this.IJDNJLIDLJE = false;
	}

	// Token: 0x0601175D RID: 71517 RVA: 0x007C8B6A File Offset: 0x007C6D6A
	public DepthTextureMode DPCKJICEDMB()
	{
		return DepthTextureMode.MotionVectors;
	}

	// Token: 0x0601175E RID: 71518 RVA: 0x007C8201 File Offset: 0x007C6401
	public DGIEACBKFMJ.LKOGFPMIKAK CNILCEEKEBC()
	{
		if (this.EJBMJCBCHGK == null)
		{
			this.EJBMJCBCHGK = new DGIEACBKFMJ.LKOGFPMIKAK();
		}
		return this.EJBMJCBCHGK;
	}

	// Token: 0x0601175F RID: 71519 RVA: 0x006FB113 File Offset: 0x006F9313
	public DepthTextureMode LNIIANBLLPG()
	{
		return DepthTextureMode.DepthNormals;
	}

	// Token: 0x06011760 RID: 71520 RVA: 0x007C8201 File Offset: 0x007C6401
	public DGIEACBKFMJ.LKOGFPMIKAK FHNCEFPPMEF()
	{
		if (this.EJBMJCBCHGK == null)
		{
			this.EJBMJCBCHGK = new DGIEACBKFMJ.LKOGFPMIKAK();
		}
		return this.EJBMJCBCHGK;
	}

	// Token: 0x06011761 RID: 71521 RVA: 0x007C9A3C File Offset: 0x007C7C3C
	public bool JKJAOLDEFIM()
	{
		MotionBlurModel.Settings settings = base.BBEPCCALAFC.DJKEIONCLCG();
		return base.BBEPCCALAFC.enabled && ((settings.shutterAngle > 205f && this.FKPPBOEHBON().FACAJNEALHD()) || settings.frameBlending > 342f) && SystemInfo.graphicsDeviceType != GraphicsDeviceType.Null && this.AMCOGJHPPOC.GCPDMBIEAOG();
	}

	// Token: 0x0400245F RID: 9311
	private DGIEACBKFMJ.LKOGFPMIKAK EJBMJCBCHGK;

	// Token: 0x04002460 RID: 9312
	private DGIEACBKFMJ.LBJNDEHNHOB FPGLJKEBPND;

	// Token: 0x04002461 RID: 9313
	private bool IJDNJLIDLJE = true;

	// Token: 0x02000525 RID: 1317
	private static class BNEACEICMJJ
	{
		// Token: 0x04002462 RID: 9314
		internal static readonly int DPKAFOKLEFB = Shader.PropertyToID("_VelocityScale");

		// Token: 0x04002463 RID: 9315
		internal static readonly int CNNDNFOCNLL = Shader.PropertyToID("_MaxBlurRadius");

		// Token: 0x04002464 RID: 9316
		internal static readonly int GKIHDBILOGH = Shader.PropertyToID("_RcpMaxBlurRadius");

		// Token: 0x04002465 RID: 9317
		internal static readonly int MHGPJFICGCM = Shader.PropertyToID("_VelocityTex");

		// Token: 0x04002466 RID: 9318
		internal static readonly int OCMLEEAPHNB = Shader.PropertyToID("_MainTex");

		// Token: 0x04002467 RID: 9319
		internal static readonly int BLFKIJIHINM = Shader.PropertyToID("_Tile2RT");

		// Token: 0x04002468 RID: 9320
		internal static readonly int DIJJOECCPLG = Shader.PropertyToID("_Tile4RT");

		// Token: 0x04002469 RID: 9321
		internal static readonly int ANAHOKMNLOL = Shader.PropertyToID("_Tile8RT");

		// Token: 0x0400246A RID: 9322
		internal static readonly int BOHEBEODDKP = Shader.PropertyToID("_TileMaxOffs");

		// Token: 0x0400246B RID: 9323
		internal static readonly int NOCHFIOAOLP = Shader.PropertyToID("_TileMaxLoop");

		// Token: 0x0400246C RID: 9324
		internal static readonly int BLFOBDBELPB = Shader.PropertyToID("_TileVRT");

		// Token: 0x0400246D RID: 9325
		internal static readonly int EOIBFPOIBNA = Shader.PropertyToID("_NeighborMaxTex");

		// Token: 0x0400246E RID: 9326
		internal static readonly int CJPHOJJBPAG = Shader.PropertyToID("_LoopCount");

		// Token: 0x0400246F RID: 9327
		internal static readonly int HMKDKKIOIAH = Shader.PropertyToID("_TempRT");

		// Token: 0x04002470 RID: 9328
		internal static readonly int BLFGBMABCDD = Shader.PropertyToID("_History1LumaTex");

		// Token: 0x04002471 RID: 9329
		internal static readonly int CBPAGKBAJOA = Shader.PropertyToID("_History2LumaTex");

		// Token: 0x04002472 RID: 9330
		internal static readonly int MGLGOEBKGBH = Shader.PropertyToID("_History3LumaTex");

		// Token: 0x04002473 RID: 9331
		internal static readonly int OGLDBPOENDA = Shader.PropertyToID("_History4LumaTex");

		// Token: 0x04002474 RID: 9332
		internal static readonly int NOJOHHNDGMP = Shader.PropertyToID("_History1ChromaTex");

		// Token: 0x04002475 RID: 9333
		internal static readonly int FIOHBAMANML = Shader.PropertyToID("_History2ChromaTex");

		// Token: 0x04002476 RID: 9334
		internal static readonly int OEHBOEONAHA = Shader.PropertyToID("_History3ChromaTex");

		// Token: 0x04002477 RID: 9335
		internal static readonly int MHKCFNDJIKO = Shader.PropertyToID("_History4ChromaTex");

		// Token: 0x04002478 RID: 9336
		internal static readonly int FALIJINHBJO = Shader.PropertyToID("_History1Weight");

		// Token: 0x04002479 RID: 9337
		internal static readonly int AKBJKGAKCED = Shader.PropertyToID("_History2Weight");

		// Token: 0x0400247A RID: 9338
		internal static readonly int NCJLKCPLCOK = Shader.PropertyToID("_History3Weight");

		// Token: 0x0400247B RID: 9339
		internal static readonly int DIOCPBCLICL = Shader.PropertyToID("_History4Weight");
	}

	// Token: 0x02000526 RID: 1318
	private enum KKHEGOFOKCD
	{
		// Token: 0x0400247D RID: 9341
		VelocitySetup,
		// Token: 0x0400247E RID: 9342
		TileMax1,
		// Token: 0x0400247F RID: 9343
		TileMax2,
		// Token: 0x04002480 RID: 9344
		TileMaxV,
		// Token: 0x04002481 RID: 9345
		NeighborMax,
		// Token: 0x04002482 RID: 9346
		Reconstruction,
		// Token: 0x04002483 RID: 9347
		FrameCompression,
		// Token: 0x04002484 RID: 9348
		FrameBlendingChroma,
		// Token: 0x04002485 RID: 9349
		FrameBlendingRaw
	}

	// Token: 0x02000527 RID: 1319
	public class LKOGFPMIKAK
	{
		// Token: 0x06011763 RID: 71523 RVA: 0x007C9C37 File Offset: 0x007C7E37
		public bool CHGFLDMAOFH()
		{
			return SystemInfo.supportsMotionVectors;
		}

		// Token: 0x06011764 RID: 71524 RVA: 0x007C9C3E File Offset: 0x007C7E3E
		private void JDGOKICKMHB()
		{
			if (!SystemInfo.SupportsRenderTextureFormat(this.CNECCCNBHKB))
			{
				this.CNECCCNBHKB = RenderTextureFormat.ARGB32;
			}
		}

		// Token: 0x06011765 RID: 71525 RVA: 0x007C9C3E File Offset: 0x007C7E3E
		private void GIBKDJOMLGC()
		{
			if (!SystemInfo.SupportsRenderTextureFormat(this.CNECCCNBHKB))
			{
				this.CNECCCNBHKB = RenderTextureFormat.ARGB32;
			}
		}

		// Token: 0x06011766 RID: 71526 RVA: 0x007C9C3E File Offset: 0x007C7E3E
		private void OPLLOLNGBAD()
		{
			if (!SystemInfo.SupportsRenderTextureFormat(this.CNECCCNBHKB))
			{
				this.CNECCCNBHKB = RenderTextureFormat.ARGB32;
			}
		}

		// Token: 0x06011767 RID: 71527 RVA: 0x007C9C54 File Offset: 0x007C7E54
		public void PPDEAHJJKPB(NGEENBGMFFM AMCOGJHPPOC, CommandBuffer ECKPLMDEJFD, ref MotionBlurModel.Settings GBEIKNIFNHL, RenderTargetIdentifier JONJODLFAEN, RenderTargetIdentifier OKIIDHIJBEA, Material MHNAJNGGDFJ)
		{
			int num = (int)(130f * (float)AMCOGJHPPOC.NIEGJHLHEEB() / 1407f);
			int num2 = ((num - 0) / 7 + 1) * 8;
			float value = GBEIKNIFNHL.shutterAngle / 1449f;
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.DPKAFOKLEFB, value);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CNNDNFOCNLL, (float)num);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.GKIHDBILOGH, 783f / (float)num);
			int mhgpjficgcm = DGIEACBKFMJ.BNEACEICMJJ.MHGPJFICGCM;
			ECKPLMDEJFD.GetTemporaryRT(mhgpjficgcm, AMCOGJHPPOC.FOBPENGADNB(), AMCOGJHPPOC.KNKKIHDHBFD(), 0, FilterMode.Point, this.CNECCCNBHKB, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.Blit(null, mhgpjficgcm, MHNAJNGGDFJ, 1);
			int blfkijihinm = DGIEACBKFMJ.BNEACEICMJJ.BLFKIJIHINM;
			ECKPLMDEJFD.GetTemporaryRT(blfkijihinm, AMCOGJHPPOC.LJJOEDIJPEM() / 1, AMCOGJHPPOC.GHMBALIHBOH() / 7, 0, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, mhgpjficgcm);
			ECKPLMDEJFD.Blit(mhgpjficgcm, blfkijihinm, MHNAJNGGDFJ, 1);
			int dijjoeccplg = DGIEACBKFMJ.BNEACEICMJJ.DIJJOECCPLG;
			ECKPLMDEJFD.GetTemporaryRT(dijjoeccplg, AMCOGJHPPOC.GAIOLBJLPDL() / 8, AMCOGJHPPOC.MMEMLJENMFF() / 7, 0, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfkijihinm);
			ECKPLMDEJFD.Blit(blfkijihinm, dijjoeccplg, MHNAJNGGDFJ, 1);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfkijihinm);
			int anahokmnlol = DGIEACBKFMJ.BNEACEICMJJ.ANAHOKMNLOL;
			ECKPLMDEJFD.GetTemporaryRT(anahokmnlol, AMCOGJHPPOC.NMCCGCOKKFA() / 8, AMCOGJHPPOC.LPJJBJCIELA() / 8, 1, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, dijjoeccplg);
			ECKPLMDEJFD.Blit(dijjoeccplg, anahokmnlol, MHNAJNGGDFJ, 1);
			ECKPLMDEJFD.ReleaseTemporaryRT(dijjoeccplg);
			Vector2 v = Vector2.one * ((float)num2 / 639f - 447f) * 456f;
			ECKPLMDEJFD.SetGlobalVector(DGIEACBKFMJ.BNEACEICMJJ.BOHEBEODDKP, v);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.NOCHFIOAOLP, (float)((int)((float)num2 / 1846f)));
			int blfobdbelpb = DGIEACBKFMJ.BNEACEICMJJ.BLFOBDBELPB;
			ECKPLMDEJFD.GetTemporaryRT(blfobdbelpb, AMCOGJHPPOC.FOBPENGADNB() / num2, AMCOGJHPPOC.HJOKFIGACEC() / num2, 0, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, anahokmnlol);
			ECKPLMDEJFD.Blit(anahokmnlol, blfobdbelpb, MHNAJNGGDFJ, 3);
			ECKPLMDEJFD.ReleaseTemporaryRT(anahokmnlol);
			int eoibfpoibna = DGIEACBKFMJ.BNEACEICMJJ.EOIBFPOIBNA;
			int width = AMCOGJHPPOC.DJGCPIEOAFC() / num2;
			int height = AMCOGJHPPOC.ILLKFNCFGMP / num2;
			ECKPLMDEJFD.GetTemporaryRT(eoibfpoibna, width, height, 0, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfobdbelpb);
			ECKPLMDEJFD.Blit(blfobdbelpb, eoibfpoibna, MHNAJNGGDFJ, 2);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfobdbelpb);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CJPHOJJBPAG, (float)Mathf.Clamp(GBEIKNIFNHL.sampleCount / 3, 0, -29));
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
			ECKPLMDEJFD.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, 3);
			ECKPLMDEJFD.ReleaseTemporaryRT(mhgpjficgcm);
			ECKPLMDEJFD.ReleaseTemporaryRT(eoibfpoibna);
		}

		// Token: 0x06011768 RID: 71528 RVA: 0x007C9C37 File Offset: 0x007C7E37
		public bool LKKDEAFMAFE()
		{
			return SystemInfo.supportsMotionVectors;
		}

		// Token: 0x06011769 RID: 71529 RVA: 0x007C9C3E File Offset: 0x007C7E3E
		private void ELOPJCIODNM()
		{
			if (!SystemInfo.SupportsRenderTextureFormat(this.CNECCCNBHKB))
			{
				this.CNECCCNBHKB = RenderTextureFormat.ARGB32;
			}
		}

		// Token: 0x0601176A RID: 71530 RVA: 0x007C9C37 File Offset: 0x007C7E37
		public bool FDGCFHEJKAK()
		{
			return SystemInfo.supportsMotionVectors;
		}

		// Token: 0x0601176B RID: 71531 RVA: 0x007C9F38 File Offset: 0x007C8138
		public void HINEHNNHJHD(NGEENBGMFFM AMCOGJHPPOC, CommandBuffer ECKPLMDEJFD, ref MotionBlurModel.Settings GBEIKNIFNHL, RenderTargetIdentifier JONJODLFAEN, RenderTargetIdentifier OKIIDHIJBEA, Material MHNAJNGGDFJ)
		{
			int num = (int)(1277f * (float)AMCOGJHPPOC.KNKKIHDHBFD() / 173f);
			int num2 = ((num - 0) / 0 + 1) * 6;
			float value = GBEIKNIFNHL.shutterAngle / 1f;
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.DPKAFOKLEFB, value);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CNNDNFOCNLL, (float)num);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.GKIHDBILOGH, 1726f / (float)num);
			int mhgpjficgcm = DGIEACBKFMJ.BNEACEICMJJ.MHGPJFICGCM;
			ECKPLMDEJFD.GetTemporaryRT(mhgpjficgcm, AMCOGJHPPOC.IGHJHMGOGOO(), AMCOGJHPPOC.KNKKIHDHBFD(), 0, FilterMode.Bilinear, this.CNECCCNBHKB, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.Blit(null, mhgpjficgcm, MHNAJNGGDFJ, 0);
			int blfkijihinm = DGIEACBKFMJ.BNEACEICMJJ.BLFKIJIHINM;
			ECKPLMDEJFD.GetTemporaryRT(blfkijihinm, AMCOGJHPPOC.GAIOLBJLPDL() / 2, AMCOGJHPPOC.CICDECHCDBJ() / 4, 0, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, mhgpjficgcm);
			ECKPLMDEJFD.Blit(mhgpjficgcm, blfkijihinm, MHNAJNGGDFJ, 1);
			int dijjoeccplg = DGIEACBKFMJ.BNEACEICMJJ.DIJJOECCPLG;
			ECKPLMDEJFD.GetTemporaryRT(dijjoeccplg, AMCOGJHPPOC.PAHBMDOJHKK() / 5, AMCOGJHPPOC.LHPBMEDMNDO() / 0, 1, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfkijihinm);
			ECKPLMDEJFD.Blit(blfkijihinm, dijjoeccplg, MHNAJNGGDFJ, 6);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfkijihinm);
			int anahokmnlol = DGIEACBKFMJ.BNEACEICMJJ.ANAHOKMNLOL;
			ECKPLMDEJFD.GetTemporaryRT(anahokmnlol, AMCOGJHPPOC.CFDHOKHCPOJ() / 8, AMCOGJHPPOC.MMEMLJENMFF() / 7, 1, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, dijjoeccplg);
			ECKPLMDEJFD.Blit(dijjoeccplg, anahokmnlol, MHNAJNGGDFJ, 0);
			ECKPLMDEJFD.ReleaseTemporaryRT(dijjoeccplg);
			Vector2 v = Vector2.one * ((float)num2 / 455f - 525f) * 1158f;
			ECKPLMDEJFD.SetGlobalVector(DGIEACBKFMJ.BNEACEICMJJ.BOHEBEODDKP, v);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.NOCHFIOAOLP, (float)((int)((float)num2 / 1868f)));
			int blfobdbelpb = DGIEACBKFMJ.BNEACEICMJJ.BLFOBDBELPB;
			ECKPLMDEJFD.GetTemporaryRT(blfobdbelpb, AMCOGJHPPOC.LBAMMHHGCGL() / num2, AMCOGJHPPOC.LPJJBJCIELA() / num2, 1, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, anahokmnlol);
			ECKPLMDEJFD.Blit(anahokmnlol, blfobdbelpb, MHNAJNGGDFJ, 0);
			ECKPLMDEJFD.ReleaseTemporaryRT(anahokmnlol);
			int eoibfpoibna = DGIEACBKFMJ.BNEACEICMJJ.EOIBFPOIBNA;
			int width = AMCOGJHPPOC.FOBPENGADNB() / num2;
			int height = AMCOGJHPPOC.LHPBMEDMNDO() / num2;
			ECKPLMDEJFD.GetTemporaryRT(eoibfpoibna, width, height, 1, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfobdbelpb);
			ECKPLMDEJFD.Blit(blfobdbelpb, eoibfpoibna, MHNAJNGGDFJ, 4);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfobdbelpb);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CJPHOJJBPAG, (float)Mathf.Clamp(GBEIKNIFNHL.sampleCount / 5, 1, -115));
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
			ECKPLMDEJFD.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, 4);
			ECKPLMDEJFD.ReleaseTemporaryRT(mhgpjficgcm);
			ECKPLMDEJFD.ReleaseTemporaryRT(eoibfpoibna);
		}

		// Token: 0x0601176C RID: 71532 RVA: 0x007CA21C File Offset: 0x007C841C
		public void LJLEGMMDPML(NGEENBGMFFM AMCOGJHPPOC, CommandBuffer ECKPLMDEJFD, ref MotionBlurModel.Settings GBEIKNIFNHL, RenderTargetIdentifier JONJODLFAEN, RenderTargetIdentifier OKIIDHIJBEA, Material MHNAJNGGDFJ)
		{
			int num = (int)(216f * (float)AMCOGJHPPOC.NIEGJHLHEEB() / 535f);
			int num2 = ((num - 0) / 6 + 0) * 3;
			float value = GBEIKNIFNHL.shutterAngle / 1526f;
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.DPKAFOKLEFB, value);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CNNDNFOCNLL, (float)num);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.GKIHDBILOGH, 1147f / (float)num);
			int mhgpjficgcm = DGIEACBKFMJ.BNEACEICMJJ.MHGPJFICGCM;
			ECKPLMDEJFD.GetTemporaryRT(mhgpjficgcm, AMCOGJHPPOC.FOBPENGADNB(), AMCOGJHPPOC.GHMBALIHBOH(), 0, FilterMode.Bilinear, this.CNECCCNBHKB, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.Blit(null, mhgpjficgcm, MHNAJNGGDFJ, 1);
			int blfkijihinm = DGIEACBKFMJ.BNEACEICMJJ.BLFKIJIHINM;
			ECKPLMDEJFD.GetTemporaryRT(blfkijihinm, AMCOGJHPPOC.IGHJHMGOGOO() / 8, AMCOGJHPPOC.FHCDJOLMIMG() / 7, 1, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, mhgpjficgcm);
			ECKPLMDEJFD.Blit(mhgpjficgcm, blfkijihinm, MHNAJNGGDFJ, 0);
			int dijjoeccplg = DGIEACBKFMJ.BNEACEICMJJ.DIJJOECCPLG;
			ECKPLMDEJFD.GetTemporaryRT(dijjoeccplg, AMCOGJHPPOC.OCNEHBGMHGB() / 2, AMCOGJHPPOC.LKLNPJICOHH() / 8, 0, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfkijihinm);
			ECKPLMDEJFD.Blit(blfkijihinm, dijjoeccplg, MHNAJNGGDFJ, 1);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfkijihinm);
			int anahokmnlol = DGIEACBKFMJ.BNEACEICMJJ.ANAHOKMNLOL;
			ECKPLMDEJFD.GetTemporaryRT(anahokmnlol, AMCOGJHPPOC.NMEBEEHCALN / 7, AMCOGJHPPOC.HJOKFIGACEC() / 4, 0, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, dijjoeccplg);
			ECKPLMDEJFD.Blit(dijjoeccplg, anahokmnlol, MHNAJNGGDFJ, 5);
			ECKPLMDEJFD.ReleaseTemporaryRT(dijjoeccplg);
			Vector2 v = Vector2.one * ((float)num2 / 1174f - 660f) * 930f;
			ECKPLMDEJFD.SetGlobalVector(DGIEACBKFMJ.BNEACEICMJJ.BOHEBEODDKP, v);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.NOCHFIOAOLP, (float)((int)((float)num2 / 1279f)));
			int blfobdbelpb = DGIEACBKFMJ.BNEACEICMJJ.BLFOBDBELPB;
			ECKPLMDEJFD.GetTemporaryRT(blfobdbelpb, AMCOGJHPPOC.DHPPGHBNDEB() / num2, AMCOGJHPPOC.NIEGJHLHEEB() / num2, 0, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, anahokmnlol);
			ECKPLMDEJFD.Blit(anahokmnlol, blfobdbelpb, MHNAJNGGDFJ, 3);
			ECKPLMDEJFD.ReleaseTemporaryRT(anahokmnlol);
			int eoibfpoibna = DGIEACBKFMJ.BNEACEICMJJ.EOIBFPOIBNA;
			int width = AMCOGJHPPOC.DHPPGHBNDEB() / num2;
			int height = AMCOGJHPPOC.FHCDJOLMIMG() / num2;
			ECKPLMDEJFD.GetTemporaryRT(eoibfpoibna, width, height, 0, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfobdbelpb);
			ECKPLMDEJFD.Blit(blfobdbelpb, eoibfpoibna, MHNAJNGGDFJ, 3);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfobdbelpb);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CJPHOJJBPAG, (float)Mathf.Clamp(GBEIKNIFNHL.sampleCount / 4, 0, 4));
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
			ECKPLMDEJFD.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, 4);
			ECKPLMDEJFD.ReleaseTemporaryRT(mhgpjficgcm);
			ECKPLMDEJFD.ReleaseTemporaryRT(eoibfpoibna);
		}

		// Token: 0x0601176D RID: 71533 RVA: 0x007CA4FE File Offset: 0x007C86FE
		private void POADOGMPEJH()
		{
			if (!SystemInfo.SupportsRenderTextureFormat(this.CNECCCNBHKB))
			{
				this.CNECCCNBHKB = RenderTextureFormat.Depth;
			}
		}

		// Token: 0x0601176E RID: 71534 RVA: 0x007CA514 File Offset: 0x007C8714
		public void GHPCEOAHPNE(NGEENBGMFFM AMCOGJHPPOC, CommandBuffer ECKPLMDEJFD, ref MotionBlurModel.Settings GBEIKNIFNHL, RenderTargetIdentifier JONJODLFAEN, RenderTargetIdentifier OKIIDHIJBEA, Material MHNAJNGGDFJ)
		{
			int num = (int)(1129f * (float)AMCOGJHPPOC.KNKKIHDHBFD() / 251f);
			int num2 = ((num - 0) / 8 + 1) * 8;
			float value = GBEIKNIFNHL.shutterAngle / 1071f;
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.DPKAFOKLEFB, value);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CNNDNFOCNLL, (float)num);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.GKIHDBILOGH, 1309f / (float)num);
			int mhgpjficgcm = DGIEACBKFMJ.BNEACEICMJJ.MHGPJFICGCM;
			ECKPLMDEJFD.GetTemporaryRT(mhgpjficgcm, AMCOGJHPPOC.IBPMMKDPDEO(), AMCOGJHPPOC.LPJJBJCIELA(), 0, FilterMode.Point, this.CNECCCNBHKB, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.Blit(null, mhgpjficgcm, MHNAJNGGDFJ, 0);
			int blfkijihinm = DGIEACBKFMJ.BNEACEICMJJ.BLFKIJIHINM;
			ECKPLMDEJFD.GetTemporaryRT(blfkijihinm, AMCOGJHPPOC.OJNDCCHLMNK() / 0, AMCOGJHPPOC.HJOKFIGACEC() / 2, 1, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, mhgpjficgcm);
			ECKPLMDEJFD.Blit(mhgpjficgcm, blfkijihinm, MHNAJNGGDFJ, 0);
			int dijjoeccplg = DGIEACBKFMJ.BNEACEICMJJ.DIJJOECCPLG;
			ECKPLMDEJFD.GetTemporaryRT(dijjoeccplg, AMCOGJHPPOC.IBPMMKDPDEO() / 0, AMCOGJHPPOC.LPJJBJCIELA() / 2, 1, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfkijihinm);
			ECKPLMDEJFD.Blit(blfkijihinm, dijjoeccplg, MHNAJNGGDFJ, 0);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfkijihinm);
			int anahokmnlol = DGIEACBKFMJ.BNEACEICMJJ.ANAHOKMNLOL;
			ECKPLMDEJFD.GetTemporaryRT(anahokmnlol, AMCOGJHPPOC.IGHJHMGOGOO() / 6, AMCOGJHPPOC.GHMBALIHBOH() / 7, 1, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, dijjoeccplg);
			ECKPLMDEJFD.Blit(dijjoeccplg, anahokmnlol, MHNAJNGGDFJ, 6);
			ECKPLMDEJFD.ReleaseTemporaryRT(dijjoeccplg);
			Vector2 v = Vector2.one * ((float)num2 / 817f - 1367f) * 365f;
			ECKPLMDEJFD.SetGlobalVector(DGIEACBKFMJ.BNEACEICMJJ.BOHEBEODDKP, v);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.NOCHFIOAOLP, (float)((int)((float)num2 / 385f)));
			int blfobdbelpb = DGIEACBKFMJ.BNEACEICMJJ.BLFOBDBELPB;
			ECKPLMDEJFD.GetTemporaryRT(blfobdbelpb, AMCOGJHPPOC.CFDHOKHCPOJ() / num2, AMCOGJHPPOC.CICDECHCDBJ() / num2, 0, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, anahokmnlol);
			ECKPLMDEJFD.Blit(anahokmnlol, blfobdbelpb, MHNAJNGGDFJ, 6);
			ECKPLMDEJFD.ReleaseTemporaryRT(anahokmnlol);
			int eoibfpoibna = DGIEACBKFMJ.BNEACEICMJJ.EOIBFPOIBNA;
			int width = AMCOGJHPPOC.CFDHOKHCPOJ() / num2;
			int height = AMCOGJHPPOC.HJOKFIGACEC() / num2;
			ECKPLMDEJFD.GetTemporaryRT(eoibfpoibna, width, height, 1, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfobdbelpb);
			ECKPLMDEJFD.Blit(blfobdbelpb, eoibfpoibna, MHNAJNGGDFJ, 5);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfobdbelpb);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CJPHOJJBPAG, (float)Mathf.Clamp(GBEIKNIFNHL.sampleCount / 5, 0, -11));
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
			ECKPLMDEJFD.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, 6);
			ECKPLMDEJFD.ReleaseTemporaryRT(mhgpjficgcm);
			ECKPLMDEJFD.ReleaseTemporaryRT(eoibfpoibna);
		}

		// Token: 0x0601176F RID: 71535 RVA: 0x007CA7F8 File Offset: 0x007C89F8
		public void GNINJDNAMOI(NGEENBGMFFM AMCOGJHPPOC, CommandBuffer ECKPLMDEJFD, ref MotionBlurModel.Settings GBEIKNIFNHL, RenderTargetIdentifier JONJODLFAEN, RenderTargetIdentifier OKIIDHIJBEA, Material MHNAJNGGDFJ)
		{
			int num = (int)(851f * (float)AMCOGJHPPOC.ILLKFNCFGMP / 564f);
			int num2 = ((num - 1) / 3 + 1) * 2;
			float value = GBEIKNIFNHL.shutterAngle / 1305f;
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.DPKAFOKLEFB, value);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CNNDNFOCNLL, (float)num);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.GKIHDBILOGH, 1645f / (float)num);
			int mhgpjficgcm = DGIEACBKFMJ.BNEACEICMJJ.MHGPJFICGCM;
			ECKPLMDEJFD.GetTemporaryRT(mhgpjficgcm, AMCOGJHPPOC.KJDPLLFIIBK(), AMCOGJHPPOC.HJOKFIGACEC(), 0, FilterMode.Bilinear, this.CNECCCNBHKB, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.Blit(null, mhgpjficgcm, MHNAJNGGDFJ, 1);
			int blfkijihinm = DGIEACBKFMJ.BNEACEICMJJ.BLFKIJIHINM;
			ECKPLMDEJFD.GetTemporaryRT(blfkijihinm, AMCOGJHPPOC.NMCCGCOKKFA() / 1, AMCOGJHPPOC.FHCDJOLMIMG() / 1, 0, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, mhgpjficgcm);
			ECKPLMDEJFD.Blit(mhgpjficgcm, blfkijihinm, MHNAJNGGDFJ, 0);
			int dijjoeccplg = DGIEACBKFMJ.BNEACEICMJJ.DIJJOECCPLG;
			ECKPLMDEJFD.GetTemporaryRT(dijjoeccplg, AMCOGJHPPOC.LJJOEDIJPEM() / 1, AMCOGJHPPOC.GGGEFNKEPDB() / 8, 0, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfkijihinm);
			ECKPLMDEJFD.Blit(blfkijihinm, dijjoeccplg, MHNAJNGGDFJ, 1);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfkijihinm);
			int anahokmnlol = DGIEACBKFMJ.BNEACEICMJJ.ANAHOKMNLOL;
			ECKPLMDEJFD.GetTemporaryRT(anahokmnlol, AMCOGJHPPOC.KJDPLLFIIBK() / 7, AMCOGJHPPOC.GGGEFNKEPDB() / 1, 0, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, dijjoeccplg);
			ECKPLMDEJFD.Blit(dijjoeccplg, anahokmnlol, MHNAJNGGDFJ, 0);
			ECKPLMDEJFD.ReleaseTemporaryRT(dijjoeccplg);
			Vector2 v = Vector2.one * ((float)num2 / 1177f - 1764f) * 1929f;
			ECKPLMDEJFD.SetGlobalVector(DGIEACBKFMJ.BNEACEICMJJ.BOHEBEODDKP, v);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.NOCHFIOAOLP, (float)((int)((float)num2 / 1060f)));
			int blfobdbelpb = DGIEACBKFMJ.BNEACEICMJJ.BLFOBDBELPB;
			ECKPLMDEJFD.GetTemporaryRT(blfobdbelpb, AMCOGJHPPOC.NMEBEEHCALN / num2, AMCOGJHPPOC.KNKKIHDHBFD() / num2, 0, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, anahokmnlol);
			ECKPLMDEJFD.Blit(anahokmnlol, blfobdbelpb, MHNAJNGGDFJ, 5);
			ECKPLMDEJFD.ReleaseTemporaryRT(anahokmnlol);
			int eoibfpoibna = DGIEACBKFMJ.BNEACEICMJJ.EOIBFPOIBNA;
			int width = AMCOGJHPPOC.OCNEHBGMHGB() / num2;
			int height = AMCOGJHPPOC.LPJJBJCIELA() / num2;
			ECKPLMDEJFD.GetTemporaryRT(eoibfpoibna, width, height, 0, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfobdbelpb);
			ECKPLMDEJFD.Blit(blfobdbelpb, eoibfpoibna, MHNAJNGGDFJ, 0);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfobdbelpb);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CJPHOJJBPAG, (float)Mathf.Clamp(GBEIKNIFNHL.sampleCount / 4, 0, 15));
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
			ECKPLMDEJFD.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, 1);
			ECKPLMDEJFD.ReleaseTemporaryRT(mhgpjficgcm);
			ECKPLMDEJFD.ReleaseTemporaryRT(eoibfpoibna);
		}

		// Token: 0x06011770 RID: 71536 RVA: 0x007CAADC File Offset: 0x007C8CDC
		public void PGGPBNOMGBA(NGEENBGMFFM AMCOGJHPPOC, CommandBuffer ECKPLMDEJFD, ref MotionBlurModel.Settings GBEIKNIFNHL, RenderTargetIdentifier JONJODLFAEN, RenderTargetIdentifier OKIIDHIJBEA, Material MHNAJNGGDFJ)
		{
			int num = (int)(790f * (float)AMCOGJHPPOC.NIEGJHLHEEB() / 95f);
			int num2 = ((num - 0) / 6 + 0) * 4;
			float value = GBEIKNIFNHL.shutterAngle / 1642f;
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.DPKAFOKLEFB, value);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CNNDNFOCNLL, (float)num);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.GKIHDBILOGH, 1262f / (float)num);
			int mhgpjficgcm = DGIEACBKFMJ.BNEACEICMJJ.MHGPJFICGCM;
			ECKPLMDEJFD.GetTemporaryRT(mhgpjficgcm, AMCOGJHPPOC.GMOLEDNNPEH(), AMCOGJHPPOC.GGGEFNKEPDB(), 0, FilterMode.Point, this.CNECCCNBHKB, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.Blit(null, mhgpjficgcm, MHNAJNGGDFJ, 0);
			int blfkijihinm = DGIEACBKFMJ.BNEACEICMJJ.BLFKIJIHINM;
			ECKPLMDEJFD.GetTemporaryRT(blfkijihinm, AMCOGJHPPOC.NMCCGCOKKFA() / 8, AMCOGJHPPOC.ILLKFNCFGMP / 1, 0, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, mhgpjficgcm);
			ECKPLMDEJFD.Blit(mhgpjficgcm, blfkijihinm, MHNAJNGGDFJ, 0);
			int dijjoeccplg = DGIEACBKFMJ.BNEACEICMJJ.DIJJOECCPLG;
			ECKPLMDEJFD.GetTemporaryRT(dijjoeccplg, AMCOGJHPPOC.LBAMMHHGCGL() / 7, AMCOGJHPPOC.HJOKFIGACEC() / 3, 0, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfkijihinm);
			ECKPLMDEJFD.Blit(blfkijihinm, dijjoeccplg, MHNAJNGGDFJ, 3);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfkijihinm);
			int anahokmnlol = DGIEACBKFMJ.BNEACEICMJJ.ANAHOKMNLOL;
			ECKPLMDEJFD.GetTemporaryRT(anahokmnlol, AMCOGJHPPOC.LJJOEDIJPEM() / 5, AMCOGJHPPOC.FHCDJOLMIMG() / 3, 0, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, dijjoeccplg);
			ECKPLMDEJFD.Blit(dijjoeccplg, anahokmnlol, MHNAJNGGDFJ, 3);
			ECKPLMDEJFD.ReleaseTemporaryRT(dijjoeccplg);
			Vector2 v = Vector2.one * ((float)num2 / 694f - 427f) * 162f;
			ECKPLMDEJFD.SetGlobalVector(DGIEACBKFMJ.BNEACEICMJJ.BOHEBEODDKP, v);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.NOCHFIOAOLP, (float)((int)((float)num2 / 390f)));
			int blfobdbelpb = DGIEACBKFMJ.BNEACEICMJJ.BLFOBDBELPB;
			ECKPLMDEJFD.GetTemporaryRT(blfobdbelpb, AMCOGJHPPOC.DJGCPIEOAFC() / num2, AMCOGJHPPOC.LHPBMEDMNDO() / num2, 1, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, anahokmnlol);
			ECKPLMDEJFD.Blit(anahokmnlol, blfobdbelpb, MHNAJNGGDFJ, 5);
			ECKPLMDEJFD.ReleaseTemporaryRT(anahokmnlol);
			int eoibfpoibna = DGIEACBKFMJ.BNEACEICMJJ.EOIBFPOIBNA;
			int width = AMCOGJHPPOC.EOMMKPDCAML() / num2;
			int height = AMCOGJHPPOC.NIEGJHLHEEB() / num2;
			ECKPLMDEJFD.GetTemporaryRT(eoibfpoibna, width, height, 0, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfobdbelpb);
			ECKPLMDEJFD.Blit(blfobdbelpb, eoibfpoibna, MHNAJNGGDFJ, 5);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfobdbelpb);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CJPHOJJBPAG, (float)Mathf.Clamp(GBEIKNIFNHL.sampleCount / 8, 1, -28));
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
			ECKPLMDEJFD.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, 8);
			ECKPLMDEJFD.ReleaseTemporaryRT(mhgpjficgcm);
			ECKPLMDEJFD.ReleaseTemporaryRT(eoibfpoibna);
		}

		// Token: 0x06011771 RID: 71537 RVA: 0x007CADC0 File Offset: 0x007C8FC0
		public void MHPLJLIEDKF(NGEENBGMFFM AMCOGJHPPOC, CommandBuffer ECKPLMDEJFD, ref MotionBlurModel.Settings GBEIKNIFNHL, RenderTargetIdentifier JONJODLFAEN, RenderTargetIdentifier OKIIDHIJBEA, Material MHNAJNGGDFJ)
		{
			int num = (int)(950f * (float)AMCOGJHPPOC.GHMBALIHBOH() / 1177f);
			int num2 = ((num - 0) / 1 + 0) * 2;
			float value = GBEIKNIFNHL.shutterAngle / 1186f;
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.DPKAFOKLEFB, value);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CNNDNFOCNLL, (float)num);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.GKIHDBILOGH, 1061f / (float)num);
			int mhgpjficgcm = DGIEACBKFMJ.BNEACEICMJJ.MHGPJFICGCM;
			ECKPLMDEJFD.GetTemporaryRT(mhgpjficgcm, AMCOGJHPPOC.DJGCPIEOAFC(), AMCOGJHPPOC.ILLKFNCFGMP, 0, FilterMode.Point, this.CNECCCNBHKB, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.Blit(null, mhgpjficgcm, MHNAJNGGDFJ, 0);
			int blfkijihinm = DGIEACBKFMJ.BNEACEICMJJ.BLFKIJIHINM;
			ECKPLMDEJFD.GetTemporaryRT(blfkijihinm, AMCOGJHPPOC.OJNDCCHLMNK() / 5, AMCOGJHPPOC.MMEMLJENMFF() / 2, 1, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, mhgpjficgcm);
			ECKPLMDEJFD.Blit(mhgpjficgcm, blfkijihinm, MHNAJNGGDFJ, 1);
			int dijjoeccplg = DGIEACBKFMJ.BNEACEICMJJ.DIJJOECCPLG;
			ECKPLMDEJFD.GetTemporaryRT(dijjoeccplg, AMCOGJHPPOC.LBAMMHHGCGL() / 0, AMCOGJHPPOC.ILLKFNCFGMP / 1, 1, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfkijihinm);
			ECKPLMDEJFD.Blit(blfkijihinm, dijjoeccplg, MHNAJNGGDFJ, 7);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfkijihinm);
			int anahokmnlol = DGIEACBKFMJ.BNEACEICMJJ.ANAHOKMNLOL;
			ECKPLMDEJFD.GetTemporaryRT(anahokmnlol, AMCOGJHPPOC.KJDPLLFIIBK() / 1, AMCOGJHPPOC.MMEMLJENMFF() / 8, 1, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, dijjoeccplg);
			ECKPLMDEJFD.Blit(dijjoeccplg, anahokmnlol, MHNAJNGGDFJ, 8);
			ECKPLMDEJFD.ReleaseTemporaryRT(dijjoeccplg);
			Vector2 v = Vector2.one * ((float)num2 / 1503f - 1956f) * 1181f;
			ECKPLMDEJFD.SetGlobalVector(DGIEACBKFMJ.BNEACEICMJJ.BOHEBEODDKP, v);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.NOCHFIOAOLP, (float)((int)((float)num2 / 992f)));
			int blfobdbelpb = DGIEACBKFMJ.BNEACEICMJJ.BLFOBDBELPB;
			ECKPLMDEJFD.GetTemporaryRT(blfobdbelpb, AMCOGJHPPOC.LJJOEDIJPEM() / num2, AMCOGJHPPOC.GGGEFNKEPDB() / num2, 1, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, anahokmnlol);
			ECKPLMDEJFD.Blit(anahokmnlol, blfobdbelpb, MHNAJNGGDFJ, 1);
			ECKPLMDEJFD.ReleaseTemporaryRT(anahokmnlol);
			int eoibfpoibna = DGIEACBKFMJ.BNEACEICMJJ.EOIBFPOIBNA;
			int width = AMCOGJHPPOC.LJJOEDIJPEM() / num2;
			int height = AMCOGJHPPOC.KNKKIHDHBFD() / num2;
			ECKPLMDEJFD.GetTemporaryRT(eoibfpoibna, width, height, 1, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfobdbelpb);
			ECKPLMDEJFD.Blit(blfobdbelpb, eoibfpoibna, MHNAJNGGDFJ, 5);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfobdbelpb);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CJPHOJJBPAG, (float)Mathf.Clamp(GBEIKNIFNHL.sampleCount / 0, 1, -123));
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
			ECKPLMDEJFD.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, 4);
			ECKPLMDEJFD.ReleaseTemporaryRT(mhgpjficgcm);
			ECKPLMDEJFD.ReleaseTemporaryRT(eoibfpoibna);
		}

		// Token: 0x06011772 RID: 71538 RVA: 0x007CB0A4 File Offset: 0x007C92A4
		public void BEFAECLBEJP(NGEENBGMFFM AMCOGJHPPOC, CommandBuffer ECKPLMDEJFD, ref MotionBlurModel.Settings GBEIKNIFNHL, RenderTargetIdentifier JONJODLFAEN, RenderTargetIdentifier OKIIDHIJBEA, Material MHNAJNGGDFJ)
		{
			int num = (int)(1602f * (float)AMCOGJHPPOC.KNKKIHDHBFD() / 464f);
			int num2 = ((num - 0) / 6 + 0) * 8;
			float value = GBEIKNIFNHL.shutterAngle / 1935f;
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.DPKAFOKLEFB, value);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CNNDNFOCNLL, (float)num);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.GKIHDBILOGH, 422f / (float)num);
			int mhgpjficgcm = DGIEACBKFMJ.BNEACEICMJJ.MHGPJFICGCM;
			ECKPLMDEJFD.GetTemporaryRT(mhgpjficgcm, AMCOGJHPPOC.OCNEHBGMHGB(), AMCOGJHPPOC.LPJJBJCIELA(), 0, FilterMode.Point, this.CNECCCNBHKB, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.Blit(null, mhgpjficgcm, MHNAJNGGDFJ, 0);
			int blfkijihinm = DGIEACBKFMJ.BNEACEICMJJ.BLFKIJIHINM;
			ECKPLMDEJFD.GetTemporaryRT(blfkijihinm, AMCOGJHPPOC.PAHBMDOJHKK() / 3, AMCOGJHPPOC.GGGEFNKEPDB() / 5, 0, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, mhgpjficgcm);
			ECKPLMDEJFD.Blit(mhgpjficgcm, blfkijihinm, MHNAJNGGDFJ, 0);
			int dijjoeccplg = DGIEACBKFMJ.BNEACEICMJJ.DIJJOECCPLG;
			ECKPLMDEJFD.GetTemporaryRT(dijjoeccplg, AMCOGJHPPOC.OCNEHBGMHGB() / 1, AMCOGJHPPOC.ILLKFNCFGMP / 7, 0, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfkijihinm);
			ECKPLMDEJFD.Blit(blfkijihinm, dijjoeccplg, MHNAJNGGDFJ, 2);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfkijihinm);
			int anahokmnlol = DGIEACBKFMJ.BNEACEICMJJ.ANAHOKMNLOL;
			ECKPLMDEJFD.GetTemporaryRT(anahokmnlol, AMCOGJHPPOC.LBAMMHHGCGL() / 0, AMCOGJHPPOC.KNKKIHDHBFD() / 8, 1, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, dijjoeccplg);
			ECKPLMDEJFD.Blit(dijjoeccplg, anahokmnlol, MHNAJNGGDFJ, 5);
			ECKPLMDEJFD.ReleaseTemporaryRT(dijjoeccplg);
			Vector2 v = Vector2.one * ((float)num2 / 1743f - 266f) * 137f;
			ECKPLMDEJFD.SetGlobalVector(DGIEACBKFMJ.BNEACEICMJJ.BOHEBEODDKP, v);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.NOCHFIOAOLP, (float)((int)((float)num2 / 332f)));
			int blfobdbelpb = DGIEACBKFMJ.BNEACEICMJJ.BLFOBDBELPB;
			ECKPLMDEJFD.GetTemporaryRT(blfobdbelpb, AMCOGJHPPOC.DHPPGHBNDEB() / num2, AMCOGJHPPOC.GHMBALIHBOH() / num2, 0, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, anahokmnlol);
			ECKPLMDEJFD.Blit(anahokmnlol, blfobdbelpb, MHNAJNGGDFJ, 2);
			ECKPLMDEJFD.ReleaseTemporaryRT(anahokmnlol);
			int eoibfpoibna = DGIEACBKFMJ.BNEACEICMJJ.EOIBFPOIBNA;
			int width = AMCOGJHPPOC.CFDHOKHCPOJ() / num2;
			int height = AMCOGJHPPOC.GHMBALIHBOH() / num2;
			ECKPLMDEJFD.GetTemporaryRT(eoibfpoibna, width, height, 1, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfobdbelpb);
			ECKPLMDEJFD.Blit(blfobdbelpb, eoibfpoibna, MHNAJNGGDFJ, 2);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfobdbelpb);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CJPHOJJBPAG, (float)Mathf.Clamp(GBEIKNIFNHL.sampleCount / 0, 1, -10));
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
			ECKPLMDEJFD.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, 4);
			ECKPLMDEJFD.ReleaseTemporaryRT(mhgpjficgcm);
			ECKPLMDEJFD.ReleaseTemporaryRT(eoibfpoibna);
		}

		// Token: 0x06011773 RID: 71539 RVA: 0x007CB388 File Offset: 0x007C9588
		public void AOEEJJKNENM(NGEENBGMFFM AMCOGJHPPOC, CommandBuffer ECKPLMDEJFD, ref MotionBlurModel.Settings GBEIKNIFNHL, RenderTargetIdentifier JONJODLFAEN, RenderTargetIdentifier OKIIDHIJBEA, Material MHNAJNGGDFJ)
		{
			int num = (int)(1224f * (float)AMCOGJHPPOC.LPJJBJCIELA() / 1060f);
			int num2 = ((num - 1) / 0 + 1) * 8;
			float value = GBEIKNIFNHL.shutterAngle / 1822f;
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.DPKAFOKLEFB, value);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CNNDNFOCNLL, (float)num);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.GKIHDBILOGH, 1671f / (float)num);
			int mhgpjficgcm = DGIEACBKFMJ.BNEACEICMJJ.MHGPJFICGCM;
			ECKPLMDEJFD.GetTemporaryRT(mhgpjficgcm, AMCOGJHPPOC.NMCCGCOKKFA(), AMCOGJHPPOC.GHMBALIHBOH(), 0, FilterMode.Point, this.CNECCCNBHKB, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.Blit(null, mhgpjficgcm, MHNAJNGGDFJ, 1);
			int blfkijihinm = DGIEACBKFMJ.BNEACEICMJJ.BLFKIJIHINM;
			ECKPLMDEJFD.GetTemporaryRT(blfkijihinm, AMCOGJHPPOC.NMCCGCOKKFA() / 0, AMCOGJHPPOC.NIEGJHLHEEB() / 8, 1, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, mhgpjficgcm);
			ECKPLMDEJFD.Blit(mhgpjficgcm, blfkijihinm, MHNAJNGGDFJ, 1);
			int dijjoeccplg = DGIEACBKFMJ.BNEACEICMJJ.DIJJOECCPLG;
			ECKPLMDEJFD.GetTemporaryRT(dijjoeccplg, AMCOGJHPPOC.EOMMKPDCAML() / 6, AMCOGJHPPOC.CICDECHCDBJ() / 6, 1, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfkijihinm);
			ECKPLMDEJFD.Blit(blfkijihinm, dijjoeccplg, MHNAJNGGDFJ, 0);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfkijihinm);
			int anahokmnlol = DGIEACBKFMJ.BNEACEICMJJ.ANAHOKMNLOL;
			ECKPLMDEJFD.GetTemporaryRT(anahokmnlol, AMCOGJHPPOC.OJNDCCHLMNK() / 7, AMCOGJHPPOC.LKLNPJICOHH() / 1, 0, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, dijjoeccplg);
			ECKPLMDEJFD.Blit(dijjoeccplg, anahokmnlol, MHNAJNGGDFJ, 1);
			ECKPLMDEJFD.ReleaseTemporaryRT(dijjoeccplg);
			Vector2 v = Vector2.one * ((float)num2 / 1264f - 1305f) * 1218f;
			ECKPLMDEJFD.SetGlobalVector(DGIEACBKFMJ.BNEACEICMJJ.BOHEBEODDKP, v);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.NOCHFIOAOLP, (float)((int)((float)num2 / 477f)));
			int blfobdbelpb = DGIEACBKFMJ.BNEACEICMJJ.BLFOBDBELPB;
			ECKPLMDEJFD.GetTemporaryRT(blfobdbelpb, AMCOGJHPPOC.LBAMMHHGCGL() / num2, AMCOGJHPPOC.MMEMLJENMFF() / num2, 0, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, anahokmnlol);
			ECKPLMDEJFD.Blit(anahokmnlol, blfobdbelpb, MHNAJNGGDFJ, 4);
			ECKPLMDEJFD.ReleaseTemporaryRT(anahokmnlol);
			int eoibfpoibna = DGIEACBKFMJ.BNEACEICMJJ.EOIBFPOIBNA;
			int width = AMCOGJHPPOC.LBAMMHHGCGL() / num2;
			int height = AMCOGJHPPOC.NIEGJHLHEEB() / num2;
			ECKPLMDEJFD.GetTemporaryRT(eoibfpoibna, width, height, 0, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfobdbelpb);
			ECKPLMDEJFD.Blit(blfobdbelpb, eoibfpoibna, MHNAJNGGDFJ, 3);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfobdbelpb);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CJPHOJJBPAG, (float)Mathf.Clamp(GBEIKNIFNHL.sampleCount / 4, 1, -116));
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
			ECKPLMDEJFD.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, 5);
			ECKPLMDEJFD.ReleaseTemporaryRT(mhgpjficgcm);
			ECKPLMDEJFD.ReleaseTemporaryRT(eoibfpoibna);
		}

		// Token: 0x06011774 RID: 71540 RVA: 0x007C9C3E File Offset: 0x007C7E3E
		private void LFFNICOIPFH()
		{
			if (!SystemInfo.SupportsRenderTextureFormat(this.CNECCCNBHKB))
			{
				this.CNECCCNBHKB = RenderTextureFormat.ARGB32;
			}
		}

		// Token: 0x06011775 RID: 71541 RVA: 0x007CB66C File Offset: 0x007C986C
		public void FAECMGEMDFA(NGEENBGMFFM AMCOGJHPPOC, CommandBuffer ECKPLMDEJFD, ref MotionBlurModel.Settings GBEIKNIFNHL, RenderTargetIdentifier JONJODLFAEN, RenderTargetIdentifier OKIIDHIJBEA, Material MHNAJNGGDFJ)
		{
			int num = (int)(1744f * (float)AMCOGJHPPOC.CICDECHCDBJ() / 552f);
			int num2 = ((num - 0) / 5 + 1) * 4;
			float value = GBEIKNIFNHL.shutterAngle / 340f;
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.DPKAFOKLEFB, value);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CNNDNFOCNLL, (float)num);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.GKIHDBILOGH, 1204f / (float)num);
			int mhgpjficgcm = DGIEACBKFMJ.BNEACEICMJJ.MHGPJFICGCM;
			ECKPLMDEJFD.GetTemporaryRT(mhgpjficgcm, AMCOGJHPPOC.PAHBMDOJHKK(), AMCOGJHPPOC.GGGEFNKEPDB(), 1, FilterMode.Point, this.CNECCCNBHKB, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.Blit(null, mhgpjficgcm, MHNAJNGGDFJ, 0);
			int blfkijihinm = DGIEACBKFMJ.BNEACEICMJJ.BLFKIJIHINM;
			ECKPLMDEJFD.GetTemporaryRT(blfkijihinm, AMCOGJHPPOC.KDBADMLHBNP() / 1, AMCOGJHPPOC.MMEMLJENMFF() / 5, 1, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, mhgpjficgcm);
			ECKPLMDEJFD.Blit(mhgpjficgcm, blfkijihinm, MHNAJNGGDFJ, 1);
			int dijjoeccplg = DGIEACBKFMJ.BNEACEICMJJ.DIJJOECCPLG;
			ECKPLMDEJFD.GetTemporaryRT(dijjoeccplg, AMCOGJHPPOC.NMEBEEHCALN / 0, AMCOGJHPPOC.FHCDJOLMIMG() / 7, 0, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfkijihinm);
			ECKPLMDEJFD.Blit(blfkijihinm, dijjoeccplg, MHNAJNGGDFJ, 1);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfkijihinm);
			int anahokmnlol = DGIEACBKFMJ.BNEACEICMJJ.ANAHOKMNLOL;
			ECKPLMDEJFD.GetTemporaryRT(anahokmnlol, AMCOGJHPPOC.KJDPLLFIIBK() / 8, AMCOGJHPPOC.GHMBALIHBOH() / 0, 1, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, dijjoeccplg);
			ECKPLMDEJFD.Blit(dijjoeccplg, anahokmnlol, MHNAJNGGDFJ, 7);
			ECKPLMDEJFD.ReleaseTemporaryRT(dijjoeccplg);
			Vector2 v = Vector2.one * ((float)num2 / 750f - 1833f) * 249f;
			ECKPLMDEJFD.SetGlobalVector(DGIEACBKFMJ.BNEACEICMJJ.BOHEBEODDKP, v);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.NOCHFIOAOLP, (float)((int)((float)num2 / 20f)));
			int blfobdbelpb = DGIEACBKFMJ.BNEACEICMJJ.BLFOBDBELPB;
			ECKPLMDEJFD.GetTemporaryRT(blfobdbelpb, AMCOGJHPPOC.LBAMMHHGCGL() / num2, AMCOGJHPPOC.GHMBALIHBOH() / num2, 0, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, anahokmnlol);
			ECKPLMDEJFD.Blit(anahokmnlol, blfobdbelpb, MHNAJNGGDFJ, 7);
			ECKPLMDEJFD.ReleaseTemporaryRT(anahokmnlol);
			int eoibfpoibna = DGIEACBKFMJ.BNEACEICMJJ.EOIBFPOIBNA;
			int width = AMCOGJHPPOC.IGHJHMGOGOO() / num2;
			int height = AMCOGJHPPOC.ILLKFNCFGMP / num2;
			ECKPLMDEJFD.GetTemporaryRT(eoibfpoibna, width, height, 1, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfobdbelpb);
			ECKPLMDEJFD.Blit(blfobdbelpb, eoibfpoibna, MHNAJNGGDFJ, 7);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfobdbelpb);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CJPHOJJBPAG, (float)Mathf.Clamp(GBEIKNIFNHL.sampleCount / 7, 0, -31));
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
			ECKPLMDEJFD.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, 1);
			ECKPLMDEJFD.ReleaseTemporaryRT(mhgpjficgcm);
			ECKPLMDEJFD.ReleaseTemporaryRT(eoibfpoibna);
		}

		// Token: 0x06011776 RID: 71542 RVA: 0x007CA4FE File Offset: 0x007C86FE
		private void FJFDLAFAOLC()
		{
			if (!SystemInfo.SupportsRenderTextureFormat(this.CNECCCNBHKB))
			{
				this.CNECCCNBHKB = RenderTextureFormat.Depth;
			}
		}

		// Token: 0x06011777 RID: 71543 RVA: 0x007CA4FE File Offset: 0x007C86FE
		private void AJEODGMFABF()
		{
			if (!SystemInfo.SupportsRenderTextureFormat(this.CNECCCNBHKB))
			{
				this.CNECCCNBHKB = RenderTextureFormat.Depth;
			}
		}

		// Token: 0x06011778 RID: 71544 RVA: 0x007C9C37 File Offset: 0x007C7E37
		public bool LFIBOGAMHNN()
		{
			return SystemInfo.supportsMotionVectors;
		}

		// Token: 0x06011779 RID: 71545 RVA: 0x007C9C37 File Offset: 0x007C7E37
		public bool FACAJNEALHD()
		{
			return SystemInfo.supportsMotionVectors;
		}

		// Token: 0x0601177A RID: 71546 RVA: 0x007C9C37 File Offset: 0x007C7E37
		public bool FEBMKGJGMOA()
		{
			return SystemInfo.supportsMotionVectors;
		}

		// Token: 0x0601177B RID: 71547 RVA: 0x007CB950 File Offset: 0x007C9B50
		public void BBKHKPMLHEE(NGEENBGMFFM AMCOGJHPPOC, CommandBuffer ECKPLMDEJFD, ref MotionBlurModel.Settings GBEIKNIFNHL, RenderTargetIdentifier JONJODLFAEN, RenderTargetIdentifier OKIIDHIJBEA, Material MHNAJNGGDFJ)
		{
			int num = (int)(950f * (float)AMCOGJHPPOC.LHPBMEDMNDO() / 1045f);
			int num2 = ((num - 0) / 7 + 0) * 8;
			float value = GBEIKNIFNHL.shutterAngle / 1600f;
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.DPKAFOKLEFB, value);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CNNDNFOCNLL, (float)num);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.GKIHDBILOGH, 673f / (float)num);
			int mhgpjficgcm = DGIEACBKFMJ.BNEACEICMJJ.MHGPJFICGCM;
			ECKPLMDEJFD.GetTemporaryRT(mhgpjficgcm, AMCOGJHPPOC.NMEBEEHCALN, AMCOGJHPPOC.KNKKIHDHBFD(), 1, FilterMode.Bilinear, this.CNECCCNBHKB, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.Blit(null, mhgpjficgcm, MHNAJNGGDFJ, 1);
			int blfkijihinm = DGIEACBKFMJ.BNEACEICMJJ.BLFKIJIHINM;
			ECKPLMDEJFD.GetTemporaryRT(blfkijihinm, AMCOGJHPPOC.FOBPENGADNB() / 8, AMCOGJHPPOC.ILLKFNCFGMP / 0, 1, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, mhgpjficgcm);
			ECKPLMDEJFD.Blit(mhgpjficgcm, blfkijihinm, MHNAJNGGDFJ, 1);
			int dijjoeccplg = DGIEACBKFMJ.BNEACEICMJJ.DIJJOECCPLG;
			ECKPLMDEJFD.GetTemporaryRT(dijjoeccplg, AMCOGJHPPOC.IBPMMKDPDEO() / 4, AMCOGJHPPOC.GGGEFNKEPDB() / 2, 1, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfkijihinm);
			ECKPLMDEJFD.Blit(blfkijihinm, dijjoeccplg, MHNAJNGGDFJ, 2);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfkijihinm);
			int anahokmnlol = DGIEACBKFMJ.BNEACEICMJJ.ANAHOKMNLOL;
			ECKPLMDEJFD.GetTemporaryRT(anahokmnlol, AMCOGJHPPOC.IGHJHMGOGOO() / 4, AMCOGJHPPOC.LKLNPJICOHH() / 8, 1, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, dijjoeccplg);
			ECKPLMDEJFD.Blit(dijjoeccplg, anahokmnlol, MHNAJNGGDFJ, 0);
			ECKPLMDEJFD.ReleaseTemporaryRT(dijjoeccplg);
			Vector2 v = Vector2.one * ((float)num2 / 179f - 684f) * 1983f;
			ECKPLMDEJFD.SetGlobalVector(DGIEACBKFMJ.BNEACEICMJJ.BOHEBEODDKP, v);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.NOCHFIOAOLP, (float)((int)((float)num2 / 1917f)));
			int blfobdbelpb = DGIEACBKFMJ.BNEACEICMJJ.BLFOBDBELPB;
			ECKPLMDEJFD.GetTemporaryRT(blfobdbelpb, AMCOGJHPPOC.EOMMKPDCAML() / num2, AMCOGJHPPOC.MMEMLJENMFF() / num2, 0, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, anahokmnlol);
			ECKPLMDEJFD.Blit(anahokmnlol, blfobdbelpb, MHNAJNGGDFJ, 3);
			ECKPLMDEJFD.ReleaseTemporaryRT(anahokmnlol);
			int eoibfpoibna = DGIEACBKFMJ.BNEACEICMJJ.EOIBFPOIBNA;
			int width = AMCOGJHPPOC.DJGCPIEOAFC() / num2;
			int height = AMCOGJHPPOC.LHPBMEDMNDO() / num2;
			ECKPLMDEJFD.GetTemporaryRT(eoibfpoibna, width, height, 1, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfobdbelpb);
			ECKPLMDEJFD.Blit(blfobdbelpb, eoibfpoibna, MHNAJNGGDFJ, 7);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfobdbelpb);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CJPHOJJBPAG, (float)Mathf.Clamp(GBEIKNIFNHL.sampleCount / 3, 0, -115));
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
			ECKPLMDEJFD.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, 2);
			ECKPLMDEJFD.ReleaseTemporaryRT(mhgpjficgcm);
			ECKPLMDEJFD.ReleaseTemporaryRT(eoibfpoibna);
		}

		// Token: 0x0601177C RID: 71548 RVA: 0x007C9C37 File Offset: 0x007C7E37
		public bool GMMFJCMNCPH()
		{
			return SystemInfo.supportsMotionVectors;
		}

		// Token: 0x0601177D RID: 71549 RVA: 0x007CA4FE File Offset: 0x007C86FE
		private void KELFONAAGPN()
		{
			if (!SystemInfo.SupportsRenderTextureFormat(this.CNECCCNBHKB))
			{
				this.CNECCCNBHKB = RenderTextureFormat.Depth;
			}
		}

		// Token: 0x0601177E RID: 71550 RVA: 0x007C9C37 File Offset: 0x007C7E37
		public bool BFJJIEDHHLI()
		{
			return SystemInfo.supportsMotionVectors;
		}

		// Token: 0x0601177F RID: 71551 RVA: 0x007CBC34 File Offset: 0x007C9E34
		public void HABOJHIPFLP(NGEENBGMFFM AMCOGJHPPOC, CommandBuffer ECKPLMDEJFD, ref MotionBlurModel.Settings GBEIKNIFNHL, RenderTargetIdentifier JONJODLFAEN, RenderTargetIdentifier OKIIDHIJBEA, Material MHNAJNGGDFJ)
		{
			int num = (int)(218f * (float)AMCOGJHPPOC.NIEGJHLHEEB() / 313f);
			int num2 = ((num - 0) / 3 + 1) * 7;
			float value = GBEIKNIFNHL.shutterAngle / 1014f;
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.DPKAFOKLEFB, value);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CNNDNFOCNLL, (float)num);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.GKIHDBILOGH, 1194f / (float)num);
			int mhgpjficgcm = DGIEACBKFMJ.BNEACEICMJJ.MHGPJFICGCM;
			ECKPLMDEJFD.GetTemporaryRT(mhgpjficgcm, AMCOGJHPPOC.FOBPENGADNB(), AMCOGJHPPOC.NIEGJHLHEEB(), 0, FilterMode.Point, this.CNECCCNBHKB, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.Blit(null, mhgpjficgcm, MHNAJNGGDFJ, 0);
			int blfkijihinm = DGIEACBKFMJ.BNEACEICMJJ.BLFKIJIHINM;
			ECKPLMDEJFD.GetTemporaryRT(blfkijihinm, AMCOGJHPPOC.DHPPGHBNDEB() / 2, AMCOGJHPPOC.GHMBALIHBOH() / 0, 1, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, mhgpjficgcm);
			ECKPLMDEJFD.Blit(mhgpjficgcm, blfkijihinm, MHNAJNGGDFJ, 1);
			int dijjoeccplg = DGIEACBKFMJ.BNEACEICMJJ.DIJJOECCPLG;
			ECKPLMDEJFD.GetTemporaryRT(dijjoeccplg, AMCOGJHPPOC.OCNEHBGMHGB() / 1, AMCOGJHPPOC.LKLNPJICOHH() / 3, 1, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfkijihinm);
			ECKPLMDEJFD.Blit(blfkijihinm, dijjoeccplg, MHNAJNGGDFJ, 5);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfkijihinm);
			int anahokmnlol = DGIEACBKFMJ.BNEACEICMJJ.ANAHOKMNLOL;
			ECKPLMDEJFD.GetTemporaryRT(anahokmnlol, AMCOGJHPPOC.GMOLEDNNPEH() / 1, AMCOGJHPPOC.LHPBMEDMNDO() / 1, 0, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, dijjoeccplg);
			ECKPLMDEJFD.Blit(dijjoeccplg, anahokmnlol, MHNAJNGGDFJ, 0);
			ECKPLMDEJFD.ReleaseTemporaryRT(dijjoeccplg);
			Vector2 v = Vector2.one * ((float)num2 / 521f - 1481f) * 1080f;
			ECKPLMDEJFD.SetGlobalVector(DGIEACBKFMJ.BNEACEICMJJ.BOHEBEODDKP, v);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.NOCHFIOAOLP, (float)((int)((float)num2 / 447f)));
			int blfobdbelpb = DGIEACBKFMJ.BNEACEICMJJ.BLFOBDBELPB;
			ECKPLMDEJFD.GetTemporaryRT(blfobdbelpb, AMCOGJHPPOC.GAIOLBJLPDL() / num2, AMCOGJHPPOC.LHPBMEDMNDO() / num2, 1, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, anahokmnlol);
			ECKPLMDEJFD.Blit(anahokmnlol, blfobdbelpb, MHNAJNGGDFJ, 4);
			ECKPLMDEJFD.ReleaseTemporaryRT(anahokmnlol);
			int eoibfpoibna = DGIEACBKFMJ.BNEACEICMJJ.EOIBFPOIBNA;
			int width = AMCOGJHPPOC.LBAMMHHGCGL() / num2;
			int height = AMCOGJHPPOC.KNKKIHDHBFD() / num2;
			ECKPLMDEJFD.GetTemporaryRT(eoibfpoibna, width, height, 1, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfobdbelpb);
			ECKPLMDEJFD.Blit(blfobdbelpb, eoibfpoibna, MHNAJNGGDFJ, 1);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfobdbelpb);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CJPHOJJBPAG, (float)Mathf.Clamp(GBEIKNIFNHL.sampleCount / 8, 1, 16));
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
			ECKPLMDEJFD.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, 1);
			ECKPLMDEJFD.ReleaseTemporaryRT(mhgpjficgcm);
			ECKPLMDEJFD.ReleaseTemporaryRT(eoibfpoibna);
		}

		// Token: 0x06011780 RID: 71552 RVA: 0x007C9C37 File Offset: 0x007C7E37
		public bool PGEOBFCALMJ()
		{
			return SystemInfo.supportsMotionVectors;
		}

		// Token: 0x06011781 RID: 71553 RVA: 0x007C9C37 File Offset: 0x007C7E37
		public bool AOAPBHPOFKJ()
		{
			return SystemInfo.supportsMotionVectors;
		}

		// Token: 0x06011782 RID: 71554 RVA: 0x007C9C37 File Offset: 0x007C7E37
		public bool PKJKBKLFJNC()
		{
			return SystemInfo.supportsMotionVectors;
		}

		// Token: 0x06011783 RID: 71555 RVA: 0x007C9C3E File Offset: 0x007C7E3E
		private void PJJKJGDNEBE()
		{
			if (!SystemInfo.SupportsRenderTextureFormat(this.CNECCCNBHKB))
			{
				this.CNECCCNBHKB = RenderTextureFormat.ARGB32;
			}
		}

		// Token: 0x06011784 RID: 71556 RVA: 0x007C9C37 File Offset: 0x007C7E37
		public bool CLLIHBKHPEC()
		{
			return SystemInfo.supportsMotionVectors;
		}

		// Token: 0x06011785 RID: 71557 RVA: 0x007C9C37 File Offset: 0x007C7E37
		public bool IMKHGAMDDAC()
		{
			return SystemInfo.supportsMotionVectors;
		}

		// Token: 0x06011786 RID: 71558 RVA: 0x007CBF18 File Offset: 0x007CA118
		public void EHDDKKPBFGO(NGEENBGMFFM AMCOGJHPPOC, CommandBuffer ECKPLMDEJFD, ref MotionBlurModel.Settings GBEIKNIFNHL, RenderTargetIdentifier JONJODLFAEN, RenderTargetIdentifier OKIIDHIJBEA, Material MHNAJNGGDFJ)
		{
			int num = (int)(1712f * (float)AMCOGJHPPOC.LHPBMEDMNDO() / 16f);
			int num2 = ((num - 1) / 4 + 1) * 8;
			float value = GBEIKNIFNHL.shutterAngle / 1218f;
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.DPKAFOKLEFB, value);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CNNDNFOCNLL, (float)num);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.GKIHDBILOGH, 239f / (float)num);
			int mhgpjficgcm = DGIEACBKFMJ.BNEACEICMJJ.MHGPJFICGCM;
			ECKPLMDEJFD.GetTemporaryRT(mhgpjficgcm, AMCOGJHPPOC.IBPMMKDPDEO(), AMCOGJHPPOC.KNKKIHDHBFD(), 0, FilterMode.Point, this.CNECCCNBHKB, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.Blit(null, mhgpjficgcm, MHNAJNGGDFJ, 1);
			int blfkijihinm = DGIEACBKFMJ.BNEACEICMJJ.BLFKIJIHINM;
			ECKPLMDEJFD.GetTemporaryRT(blfkijihinm, AMCOGJHPPOC.FOBPENGADNB() / 3, AMCOGJHPPOC.HJOKFIGACEC() / 1, 1, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, mhgpjficgcm);
			ECKPLMDEJFD.Blit(mhgpjficgcm, blfkijihinm, MHNAJNGGDFJ, 1);
			int dijjoeccplg = DGIEACBKFMJ.BNEACEICMJJ.DIJJOECCPLG;
			ECKPLMDEJFD.GetTemporaryRT(dijjoeccplg, AMCOGJHPPOC.LBAMMHHGCGL() / 6, AMCOGJHPPOC.NIEGJHLHEEB() / 6, 1, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfkijihinm);
			ECKPLMDEJFD.Blit(blfkijihinm, dijjoeccplg, MHNAJNGGDFJ, 3);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfkijihinm);
			int anahokmnlol = DGIEACBKFMJ.BNEACEICMJJ.ANAHOKMNLOL;
			ECKPLMDEJFD.GetTemporaryRT(anahokmnlol, AMCOGJHPPOC.IBPMMKDPDEO() / 2, AMCOGJHPPOC.ILLKFNCFGMP / 7, 1, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, dijjoeccplg);
			ECKPLMDEJFD.Blit(dijjoeccplg, anahokmnlol, MHNAJNGGDFJ, 6);
			ECKPLMDEJFD.ReleaseTemporaryRT(dijjoeccplg);
			Vector2 v = Vector2.one * ((float)num2 / 361f - 1792f) * 887f;
			ECKPLMDEJFD.SetGlobalVector(DGIEACBKFMJ.BNEACEICMJJ.BOHEBEODDKP, v);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.NOCHFIOAOLP, (float)((int)((float)num2 / 338f)));
			int blfobdbelpb = DGIEACBKFMJ.BNEACEICMJJ.BLFOBDBELPB;
			ECKPLMDEJFD.GetTemporaryRT(blfobdbelpb, AMCOGJHPPOC.IGHJHMGOGOO() / num2, AMCOGJHPPOC.HJOKFIGACEC() / num2, 1, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, anahokmnlol);
			ECKPLMDEJFD.Blit(anahokmnlol, blfobdbelpb, MHNAJNGGDFJ, 3);
			ECKPLMDEJFD.ReleaseTemporaryRT(anahokmnlol);
			int eoibfpoibna = DGIEACBKFMJ.BNEACEICMJJ.EOIBFPOIBNA;
			int width = AMCOGJHPPOC.KJDPLLFIIBK() / num2;
			int height = AMCOGJHPPOC.HJOKFIGACEC() / num2;
			ECKPLMDEJFD.GetTemporaryRT(eoibfpoibna, width, height, 1, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfobdbelpb);
			ECKPLMDEJFD.Blit(blfobdbelpb, eoibfpoibna, MHNAJNGGDFJ, 8);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfobdbelpb);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CJPHOJJBPAG, (float)Mathf.Clamp(GBEIKNIFNHL.sampleCount / 0, 0, 41));
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
			ECKPLMDEJFD.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, 1);
			ECKPLMDEJFD.ReleaseTemporaryRT(mhgpjficgcm);
			ECKPLMDEJFD.ReleaseTemporaryRT(eoibfpoibna);
		}

		// Token: 0x06011787 RID: 71559 RVA: 0x007CC1FC File Offset: 0x007CA3FC
		public void FEHDGELLGIG(NGEENBGMFFM AMCOGJHPPOC, CommandBuffer ECKPLMDEJFD, ref MotionBlurModel.Settings GBEIKNIFNHL, RenderTargetIdentifier JONJODLFAEN, RenderTargetIdentifier OKIIDHIJBEA, Material MHNAJNGGDFJ)
		{
			int num = (int)(5f * (float)AMCOGJHPPOC.ILLKFNCFGMP / 100f);
			int num2 = ((num - 1) / 8 + 1) * 8;
			float value = GBEIKNIFNHL.shutterAngle / 360f;
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.DPKAFOKLEFB, value);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CNNDNFOCNLL, (float)num);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.GKIHDBILOGH, 1f / (float)num);
			int mhgpjficgcm = DGIEACBKFMJ.BNEACEICMJJ.MHGPJFICGCM;
			ECKPLMDEJFD.GetTemporaryRT(mhgpjficgcm, AMCOGJHPPOC.NMEBEEHCALN, AMCOGJHPPOC.ILLKFNCFGMP, 0, FilterMode.Point, this.CNECCCNBHKB, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.Blit(null, mhgpjficgcm, MHNAJNGGDFJ, 0);
			int blfkijihinm = DGIEACBKFMJ.BNEACEICMJJ.BLFKIJIHINM;
			ECKPLMDEJFD.GetTemporaryRT(blfkijihinm, AMCOGJHPPOC.NMEBEEHCALN / 2, AMCOGJHPPOC.ILLKFNCFGMP / 2, 0, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, mhgpjficgcm);
			ECKPLMDEJFD.Blit(mhgpjficgcm, blfkijihinm, MHNAJNGGDFJ, 1);
			int dijjoeccplg = DGIEACBKFMJ.BNEACEICMJJ.DIJJOECCPLG;
			ECKPLMDEJFD.GetTemporaryRT(dijjoeccplg, AMCOGJHPPOC.NMEBEEHCALN / 4, AMCOGJHPPOC.ILLKFNCFGMP / 4, 0, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfkijihinm);
			ECKPLMDEJFD.Blit(blfkijihinm, dijjoeccplg, MHNAJNGGDFJ, 2);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfkijihinm);
			int anahokmnlol = DGIEACBKFMJ.BNEACEICMJJ.ANAHOKMNLOL;
			ECKPLMDEJFD.GetTemporaryRT(anahokmnlol, AMCOGJHPPOC.NMEBEEHCALN / 8, AMCOGJHPPOC.ILLKFNCFGMP / 8, 0, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, dijjoeccplg);
			ECKPLMDEJFD.Blit(dijjoeccplg, anahokmnlol, MHNAJNGGDFJ, 2);
			ECKPLMDEJFD.ReleaseTemporaryRT(dijjoeccplg);
			Vector2 v = Vector2.one * ((float)num2 / 8f - 1f) * -0.5f;
			ECKPLMDEJFD.SetGlobalVector(DGIEACBKFMJ.BNEACEICMJJ.BOHEBEODDKP, v);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.NOCHFIOAOLP, (float)((int)((float)num2 / 8f)));
			int blfobdbelpb = DGIEACBKFMJ.BNEACEICMJJ.BLFOBDBELPB;
			ECKPLMDEJFD.GetTemporaryRT(blfobdbelpb, AMCOGJHPPOC.NMEBEEHCALN / num2, AMCOGJHPPOC.ILLKFNCFGMP / num2, 0, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, anahokmnlol);
			ECKPLMDEJFD.Blit(anahokmnlol, blfobdbelpb, MHNAJNGGDFJ, 3);
			ECKPLMDEJFD.ReleaseTemporaryRT(anahokmnlol);
			int eoibfpoibna = DGIEACBKFMJ.BNEACEICMJJ.EOIBFPOIBNA;
			int width = AMCOGJHPPOC.NMEBEEHCALN / num2;
			int height = AMCOGJHPPOC.ILLKFNCFGMP / num2;
			ECKPLMDEJFD.GetTemporaryRT(eoibfpoibna, width, height, 0, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfobdbelpb);
			ECKPLMDEJFD.Blit(blfobdbelpb, eoibfpoibna, MHNAJNGGDFJ, 4);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfobdbelpb);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CJPHOJJBPAG, (float)Mathf.Clamp(GBEIKNIFNHL.sampleCount / 2, 1, 64));
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
			ECKPLMDEJFD.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, 5);
			ECKPLMDEJFD.ReleaseTemporaryRT(mhgpjficgcm);
			ECKPLMDEJFD.ReleaseTemporaryRT(eoibfpoibna);
		}

		// Token: 0x06011788 RID: 71560 RVA: 0x007C9C37 File Offset: 0x007C7E37
		public bool NINPLGHIBED()
		{
			return SystemInfo.supportsMotionVectors;
		}

		// Token: 0x06011789 RID: 71561 RVA: 0x007CC4E0 File Offset: 0x007CA6E0
		public void KCMBCMBKMMB(NGEENBGMFFM AMCOGJHPPOC, CommandBuffer ECKPLMDEJFD, ref MotionBlurModel.Settings GBEIKNIFNHL, RenderTargetIdentifier JONJODLFAEN, RenderTargetIdentifier OKIIDHIJBEA, Material MHNAJNGGDFJ)
		{
			int num = (int)(106f * (float)AMCOGJHPPOC.CICDECHCDBJ() / 1007f);
			int num2 = ((num - 1) / 8 + 1) * 2;
			float value = GBEIKNIFNHL.shutterAngle / 1279f;
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.DPKAFOKLEFB, value);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CNNDNFOCNLL, (float)num);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.GKIHDBILOGH, 202f / (float)num);
			int mhgpjficgcm = DGIEACBKFMJ.BNEACEICMJJ.MHGPJFICGCM;
			ECKPLMDEJFD.GetTemporaryRT(mhgpjficgcm, AMCOGJHPPOC.DJGCPIEOAFC(), AMCOGJHPPOC.HJOKFIGACEC(), 1, FilterMode.Bilinear, this.CNECCCNBHKB, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.Blit(null, mhgpjficgcm, MHNAJNGGDFJ, 0);
			int blfkijihinm = DGIEACBKFMJ.BNEACEICMJJ.BLFKIJIHINM;
			ECKPLMDEJFD.GetTemporaryRT(blfkijihinm, AMCOGJHPPOC.DHPPGHBNDEB() / 0, AMCOGJHPPOC.FHCDJOLMIMG() / 1, 0, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, mhgpjficgcm);
			ECKPLMDEJFD.Blit(mhgpjficgcm, blfkijihinm, MHNAJNGGDFJ, 0);
			int dijjoeccplg = DGIEACBKFMJ.BNEACEICMJJ.DIJJOECCPLG;
			ECKPLMDEJFD.GetTemporaryRT(dijjoeccplg, AMCOGJHPPOC.PAHBMDOJHKK() / 2, AMCOGJHPPOC.KNKKIHDHBFD() / 8, 0, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfkijihinm);
			ECKPLMDEJFD.Blit(blfkijihinm, dijjoeccplg, MHNAJNGGDFJ, 6);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfkijihinm);
			int anahokmnlol = DGIEACBKFMJ.BNEACEICMJJ.ANAHOKMNLOL;
			ECKPLMDEJFD.GetTemporaryRT(anahokmnlol, AMCOGJHPPOC.NMEBEEHCALN / 7, AMCOGJHPPOC.ILLKFNCFGMP / 1, 0, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, dijjoeccplg);
			ECKPLMDEJFD.Blit(dijjoeccplg, anahokmnlol, MHNAJNGGDFJ, 5);
			ECKPLMDEJFD.ReleaseTemporaryRT(dijjoeccplg);
			Vector2 v = Vector2.one * ((float)num2 / 1702f - 1576f) * 1604f;
			ECKPLMDEJFD.SetGlobalVector(DGIEACBKFMJ.BNEACEICMJJ.BOHEBEODDKP, v);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.NOCHFIOAOLP, (float)((int)((float)num2 / 1080f)));
			int blfobdbelpb = DGIEACBKFMJ.BNEACEICMJJ.BLFOBDBELPB;
			ECKPLMDEJFD.GetTemporaryRT(blfobdbelpb, AMCOGJHPPOC.KDBADMLHBNP() / num2, AMCOGJHPPOC.LHPBMEDMNDO() / num2, 0, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, anahokmnlol);
			ECKPLMDEJFD.Blit(anahokmnlol, blfobdbelpb, MHNAJNGGDFJ, 1);
			ECKPLMDEJFD.ReleaseTemporaryRT(anahokmnlol);
			int eoibfpoibna = DGIEACBKFMJ.BNEACEICMJJ.EOIBFPOIBNA;
			int width = AMCOGJHPPOC.PAHBMDOJHKK() / num2;
			int height = AMCOGJHPPOC.CICDECHCDBJ() / num2;
			ECKPLMDEJFD.GetTemporaryRT(eoibfpoibna, width, height, 0, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfobdbelpb);
			ECKPLMDEJFD.Blit(blfobdbelpb, eoibfpoibna, MHNAJNGGDFJ, 1);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfobdbelpb);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CJPHOJJBPAG, (float)Mathf.Clamp(GBEIKNIFNHL.sampleCount / 4, 0, 36));
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
			ECKPLMDEJFD.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, 6);
			ECKPLMDEJFD.ReleaseTemporaryRT(mhgpjficgcm);
			ECKPLMDEJFD.ReleaseTemporaryRT(eoibfpoibna);
		}

		// Token: 0x0601178A RID: 71562 RVA: 0x007CA4FE File Offset: 0x007C86FE
		private void KMGHEGBOAML()
		{
			if (!SystemInfo.SupportsRenderTextureFormat(this.CNECCCNBHKB))
			{
				this.CNECCCNBHKB = RenderTextureFormat.Depth;
			}
		}

		// Token: 0x0601178B RID: 71563 RVA: 0x007CA4FE File Offset: 0x007C86FE
		private void PKEFGBLHLKI()
		{
			if (!SystemInfo.SupportsRenderTextureFormat(this.CNECCCNBHKB))
			{
				this.CNECCCNBHKB = RenderTextureFormat.Depth;
			}
		}

		// Token: 0x0601178C RID: 71564 RVA: 0x007CC7C4 File Offset: 0x007CA9C4
		public void INIEOFCNFNN(NGEENBGMFFM AMCOGJHPPOC, CommandBuffer ECKPLMDEJFD, ref MotionBlurModel.Settings GBEIKNIFNHL, RenderTargetIdentifier JONJODLFAEN, RenderTargetIdentifier OKIIDHIJBEA, Material MHNAJNGGDFJ)
		{
			int num = (int)(1415f * (float)AMCOGJHPPOC.NIEGJHLHEEB() / 1157f);
			int num2 = ((num - 1) / 2 + 1) * 1;
			float value = GBEIKNIFNHL.shutterAngle / 1367f;
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.DPKAFOKLEFB, value);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CNNDNFOCNLL, (float)num);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.GKIHDBILOGH, 1558f / (float)num);
			int mhgpjficgcm = DGIEACBKFMJ.BNEACEICMJJ.MHGPJFICGCM;
			ECKPLMDEJFD.GetTemporaryRT(mhgpjficgcm, AMCOGJHPPOC.PAHBMDOJHKK(), AMCOGJHPPOC.CICDECHCDBJ(), 1, FilterMode.Bilinear, this.CNECCCNBHKB, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.Blit(null, mhgpjficgcm, MHNAJNGGDFJ, 1);
			int blfkijihinm = DGIEACBKFMJ.BNEACEICMJJ.BLFKIJIHINM;
			ECKPLMDEJFD.GetTemporaryRT(blfkijihinm, AMCOGJHPPOC.DJGCPIEOAFC() / 0, AMCOGJHPPOC.GHMBALIHBOH() / 1, 0, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, mhgpjficgcm);
			ECKPLMDEJFD.Blit(mhgpjficgcm, blfkijihinm, MHNAJNGGDFJ, 0);
			int dijjoeccplg = DGIEACBKFMJ.BNEACEICMJJ.DIJJOECCPLG;
			ECKPLMDEJFD.GetTemporaryRT(dijjoeccplg, AMCOGJHPPOC.OCNEHBGMHGB() / 1, AMCOGJHPPOC.LHPBMEDMNDO() / 5, 0, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfkijihinm);
			ECKPLMDEJFD.Blit(blfkijihinm, dijjoeccplg, MHNAJNGGDFJ, 1);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfkijihinm);
			int anahokmnlol = DGIEACBKFMJ.BNEACEICMJJ.ANAHOKMNLOL;
			ECKPLMDEJFD.GetTemporaryRT(anahokmnlol, AMCOGJHPPOC.LJJOEDIJPEM() / 2, AMCOGJHPPOC.FHCDJOLMIMG() / 8, 1, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, dijjoeccplg);
			ECKPLMDEJFD.Blit(dijjoeccplg, anahokmnlol, MHNAJNGGDFJ, 4);
			ECKPLMDEJFD.ReleaseTemporaryRT(dijjoeccplg);
			Vector2 v = Vector2.one * ((float)num2 / 1444f - 339f) * 476f;
			ECKPLMDEJFD.SetGlobalVector(DGIEACBKFMJ.BNEACEICMJJ.BOHEBEODDKP, v);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.NOCHFIOAOLP, (float)((int)((float)num2 / 1811f)));
			int blfobdbelpb = DGIEACBKFMJ.BNEACEICMJJ.BLFOBDBELPB;
			ECKPLMDEJFD.GetTemporaryRT(blfobdbelpb, AMCOGJHPPOC.OCNEHBGMHGB() / num2, AMCOGJHPPOC.LPJJBJCIELA() / num2, 1, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, anahokmnlol);
			ECKPLMDEJFD.Blit(anahokmnlol, blfobdbelpb, MHNAJNGGDFJ, 4);
			ECKPLMDEJFD.ReleaseTemporaryRT(anahokmnlol);
			int eoibfpoibna = DGIEACBKFMJ.BNEACEICMJJ.EOIBFPOIBNA;
			int width = AMCOGJHPPOC.KJDPLLFIIBK() / num2;
			int height = AMCOGJHPPOC.LHPBMEDMNDO() / num2;
			ECKPLMDEJFD.GetTemporaryRT(eoibfpoibna, width, height, 1, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfobdbelpb);
			ECKPLMDEJFD.Blit(blfobdbelpb, eoibfpoibna, MHNAJNGGDFJ, 6);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfobdbelpb);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CJPHOJJBPAG, (float)Mathf.Clamp(GBEIKNIFNHL.sampleCount / 6, 0, 77));
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
			ECKPLMDEJFD.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, 4);
			ECKPLMDEJFD.ReleaseTemporaryRT(mhgpjficgcm);
			ECKPLMDEJFD.ReleaseTemporaryRT(eoibfpoibna);
		}

		// Token: 0x0601178D RID: 71565 RVA: 0x007CA4FE File Offset: 0x007C86FE
		private void PMIBLKBCPHP()
		{
			if (!SystemInfo.SupportsRenderTextureFormat(this.CNECCCNBHKB))
			{
				this.CNECCCNBHKB = RenderTextureFormat.Depth;
			}
		}

		// Token: 0x0601178E RID: 71566 RVA: 0x007C9C3E File Offset: 0x007C7E3E
		private void FIAHHLPGBCM()
		{
			if (!SystemInfo.SupportsRenderTextureFormat(this.CNECCCNBHKB))
			{
				this.CNECCCNBHKB = RenderTextureFormat.ARGB32;
			}
		}

		// Token: 0x0601178F RID: 71567 RVA: 0x007C9C3E File Offset: 0x007C7E3E
		private void CGDDPOFALFC()
		{
			if (!SystemInfo.SupportsRenderTextureFormat(this.CNECCCNBHKB))
			{
				this.CNECCCNBHKB = RenderTextureFormat.ARGB32;
			}
		}

		// Token: 0x06011790 RID: 71568 RVA: 0x007C9C37 File Offset: 0x007C7E37
		public bool MAFGGMHPLDC()
		{
			return SystemInfo.supportsMotionVectors;
		}

		// Token: 0x06011791 RID: 71569 RVA: 0x007CCAA8 File Offset: 0x007CACA8
		public void INJLIGIEKDK(NGEENBGMFFM AMCOGJHPPOC, CommandBuffer ECKPLMDEJFD, ref MotionBlurModel.Settings GBEIKNIFNHL, RenderTargetIdentifier JONJODLFAEN, RenderTargetIdentifier OKIIDHIJBEA, Material MHNAJNGGDFJ)
		{
			int num = (int)(1185f * (float)AMCOGJHPPOC.GGGEFNKEPDB() / 1890f);
			int num2 = ((num - 1) / 0 + 0) * 3;
			float value = GBEIKNIFNHL.shutterAngle / 1572f;
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.DPKAFOKLEFB, value);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CNNDNFOCNLL, (float)num);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.GKIHDBILOGH, 383f / (float)num);
			int mhgpjficgcm = DGIEACBKFMJ.BNEACEICMJJ.MHGPJFICGCM;
			ECKPLMDEJFD.GetTemporaryRT(mhgpjficgcm, AMCOGJHPPOC.OCNEHBGMHGB(), AMCOGJHPPOC.NIEGJHLHEEB(), 1, FilterMode.Bilinear, this.CNECCCNBHKB, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.Blit(null, mhgpjficgcm, MHNAJNGGDFJ, 0);
			int blfkijihinm = DGIEACBKFMJ.BNEACEICMJJ.BLFKIJIHINM;
			ECKPLMDEJFD.GetTemporaryRT(blfkijihinm, AMCOGJHPPOC.KDBADMLHBNP() / 4, AMCOGJHPPOC.LPJJBJCIELA() / 3, 1, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, mhgpjficgcm);
			ECKPLMDEJFD.Blit(mhgpjficgcm, blfkijihinm, MHNAJNGGDFJ, 1);
			int dijjoeccplg = DGIEACBKFMJ.BNEACEICMJJ.DIJJOECCPLG;
			ECKPLMDEJFD.GetTemporaryRT(dijjoeccplg, AMCOGJHPPOC.DHPPGHBNDEB() / 6, AMCOGJHPPOC.CICDECHCDBJ() / 5, 0, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfkijihinm);
			ECKPLMDEJFD.Blit(blfkijihinm, dijjoeccplg, MHNAJNGGDFJ, 7);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfkijihinm);
			int anahokmnlol = DGIEACBKFMJ.BNEACEICMJJ.ANAHOKMNLOL;
			ECKPLMDEJFD.GetTemporaryRT(anahokmnlol, AMCOGJHPPOC.GAIOLBJLPDL() / 6, AMCOGJHPPOC.HJOKFIGACEC() / 7, 0, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, dijjoeccplg);
			ECKPLMDEJFD.Blit(dijjoeccplg, anahokmnlol, MHNAJNGGDFJ, 5);
			ECKPLMDEJFD.ReleaseTemporaryRT(dijjoeccplg);
			Vector2 v = Vector2.one * ((float)num2 / 295f - 1706f) * 1291f;
			ECKPLMDEJFD.SetGlobalVector(DGIEACBKFMJ.BNEACEICMJJ.BOHEBEODDKP, v);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.NOCHFIOAOLP, (float)((int)((float)num2 / 394f)));
			int blfobdbelpb = DGIEACBKFMJ.BNEACEICMJJ.BLFOBDBELPB;
			ECKPLMDEJFD.GetTemporaryRT(blfobdbelpb, AMCOGJHPPOC.PAHBMDOJHKK() / num2, AMCOGJHPPOC.NIEGJHLHEEB() / num2, 0, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, anahokmnlol);
			ECKPLMDEJFD.Blit(anahokmnlol, blfobdbelpb, MHNAJNGGDFJ, 8);
			ECKPLMDEJFD.ReleaseTemporaryRT(anahokmnlol);
			int eoibfpoibna = DGIEACBKFMJ.BNEACEICMJJ.EOIBFPOIBNA;
			int width = AMCOGJHPPOC.IGHJHMGOGOO() / num2;
			int height = AMCOGJHPPOC.GHMBALIHBOH() / num2;
			ECKPLMDEJFD.GetTemporaryRT(eoibfpoibna, width, height, 1, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfobdbelpb);
			ECKPLMDEJFD.Blit(blfobdbelpb, eoibfpoibna, MHNAJNGGDFJ, 2);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfobdbelpb);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CJPHOJJBPAG, (float)Mathf.Clamp(GBEIKNIFNHL.sampleCount / 7, 1, 94));
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
			ECKPLMDEJFD.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, 0);
			ECKPLMDEJFD.ReleaseTemporaryRT(mhgpjficgcm);
			ECKPLMDEJFD.ReleaseTemporaryRT(eoibfpoibna);
		}

		// Token: 0x06011792 RID: 71570 RVA: 0x007C9C3E File Offset: 0x007C7E3E
		private void LEKPGNGBBJP()
		{
			if (!SystemInfo.SupportsRenderTextureFormat(this.CNECCCNBHKB))
			{
				this.CNECCCNBHKB = RenderTextureFormat.ARGB32;
			}
		}

		// Token: 0x06011793 RID: 71571 RVA: 0x007C9C37 File Offset: 0x007C7E37
		public bool BHJCAJKEJPF()
		{
			return SystemInfo.supportsMotionVectors;
		}

		// Token: 0x06011794 RID: 71572 RVA: 0x007C9C3E File Offset: 0x007C7E3E
		private void KIHHJHMOCPA()
		{
			if (!SystemInfo.SupportsRenderTextureFormat(this.CNECCCNBHKB))
			{
				this.CNECCCNBHKB = RenderTextureFormat.ARGB32;
			}
		}

		// Token: 0x06011795 RID: 71573 RVA: 0x007C9C3E File Offset: 0x007C7E3E
		private void MKDDOJKIGDL()
		{
			if (!SystemInfo.SupportsRenderTextureFormat(this.CNECCCNBHKB))
			{
				this.CNECCCNBHKB = RenderTextureFormat.ARGB32;
			}
		}

		// Token: 0x06011796 RID: 71574 RVA: 0x007CCD8C File Offset: 0x007CAF8C
		public void DILHAHNOCJO(NGEENBGMFFM AMCOGJHPPOC, CommandBuffer ECKPLMDEJFD, ref MotionBlurModel.Settings GBEIKNIFNHL, RenderTargetIdentifier JONJODLFAEN, RenderTargetIdentifier OKIIDHIJBEA, Material MHNAJNGGDFJ)
		{
			int num = (int)(1936f * (float)AMCOGJHPPOC.CICDECHCDBJ() / 409f);
			int num2 = ((num - 0) / 4 + 1) * 2;
			float value = GBEIKNIFNHL.shutterAngle / 501f;
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.DPKAFOKLEFB, value);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CNNDNFOCNLL, (float)num);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.GKIHDBILOGH, 1617f / (float)num);
			int mhgpjficgcm = DGIEACBKFMJ.BNEACEICMJJ.MHGPJFICGCM;
			ECKPLMDEJFD.GetTemporaryRT(mhgpjficgcm, AMCOGJHPPOC.LJJOEDIJPEM(), AMCOGJHPPOC.MMEMLJENMFF(), 1, FilterMode.Point, this.CNECCCNBHKB, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.Blit(null, mhgpjficgcm, MHNAJNGGDFJ, 0);
			int blfkijihinm = DGIEACBKFMJ.BNEACEICMJJ.BLFKIJIHINM;
			ECKPLMDEJFD.GetTemporaryRT(blfkijihinm, AMCOGJHPPOC.KJDPLLFIIBK() / 1, AMCOGJHPPOC.GGGEFNKEPDB() / 7, 1, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, mhgpjficgcm);
			ECKPLMDEJFD.Blit(mhgpjficgcm, blfkijihinm, MHNAJNGGDFJ, 1);
			int dijjoeccplg = DGIEACBKFMJ.BNEACEICMJJ.DIJJOECCPLG;
			ECKPLMDEJFD.GetTemporaryRT(dijjoeccplg, AMCOGJHPPOC.EOMMKPDCAML() / 8, AMCOGJHPPOC.LKLNPJICOHH() / 4, 0, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfkijihinm);
			ECKPLMDEJFD.Blit(blfkijihinm, dijjoeccplg, MHNAJNGGDFJ, 3);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfkijihinm);
			int anahokmnlol = DGIEACBKFMJ.BNEACEICMJJ.ANAHOKMNLOL;
			ECKPLMDEJFD.GetTemporaryRT(anahokmnlol, AMCOGJHPPOC.KJDPLLFIIBK() / 1, AMCOGJHPPOC.MMEMLJENMFF() / 8, 0, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, dijjoeccplg);
			ECKPLMDEJFD.Blit(dijjoeccplg, anahokmnlol, MHNAJNGGDFJ, 3);
			ECKPLMDEJFD.ReleaseTemporaryRT(dijjoeccplg);
			Vector2 v = Vector2.one * ((float)num2 / 487f - 806f) * 144f;
			ECKPLMDEJFD.SetGlobalVector(DGIEACBKFMJ.BNEACEICMJJ.BOHEBEODDKP, v);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.NOCHFIOAOLP, (float)((int)((float)num2 / 580f)));
			int blfobdbelpb = DGIEACBKFMJ.BNEACEICMJJ.BLFOBDBELPB;
			ECKPLMDEJFD.GetTemporaryRT(blfobdbelpb, AMCOGJHPPOC.FOBPENGADNB() / num2, AMCOGJHPPOC.NIEGJHLHEEB() / num2, 0, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, anahokmnlol);
			ECKPLMDEJFD.Blit(anahokmnlol, blfobdbelpb, MHNAJNGGDFJ, 3);
			ECKPLMDEJFD.ReleaseTemporaryRT(anahokmnlol);
			int eoibfpoibna = DGIEACBKFMJ.BNEACEICMJJ.EOIBFPOIBNA;
			int width = AMCOGJHPPOC.FOBPENGADNB() / num2;
			int height = AMCOGJHPPOC.FHCDJOLMIMG() / num2;
			ECKPLMDEJFD.GetTemporaryRT(eoibfpoibna, width, height, 0, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfobdbelpb);
			ECKPLMDEJFD.Blit(blfobdbelpb, eoibfpoibna, MHNAJNGGDFJ, 5);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfobdbelpb);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CJPHOJJBPAG, (float)Mathf.Clamp(GBEIKNIFNHL.sampleCount / 4, 1, -25));
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
			ECKPLMDEJFD.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, 7);
			ECKPLMDEJFD.ReleaseTemporaryRT(mhgpjficgcm);
			ECKPLMDEJFD.ReleaseTemporaryRT(eoibfpoibna);
		}

		// Token: 0x06011797 RID: 71575 RVA: 0x007C9C37 File Offset: 0x007C7E37
		public bool MGEJKHMHBLD()
		{
			return SystemInfo.supportsMotionVectors;
		}

		// Token: 0x06011798 RID: 71576 RVA: 0x007C9C37 File Offset: 0x007C7E37
		public bool CDGJCJHMDDL()
		{
			return SystemInfo.supportsMotionVectors;
		}

		// Token: 0x06011799 RID: 71577 RVA: 0x007C9C37 File Offset: 0x007C7E37
		public bool DGNBAAHOKNK()
		{
			return SystemInfo.supportsMotionVectors;
		}

		// Token: 0x0601179A RID: 71578 RVA: 0x007C9C37 File Offset: 0x007C7E37
		public bool JILMOIOBANL()
		{
			return SystemInfo.supportsMotionVectors;
		}

		// Token: 0x0601179B RID: 71579 RVA: 0x007CD070 File Offset: 0x007CB270
		public void LAFJDANAPCI(NGEENBGMFFM AMCOGJHPPOC, CommandBuffer ECKPLMDEJFD, ref MotionBlurModel.Settings GBEIKNIFNHL, RenderTargetIdentifier JONJODLFAEN, RenderTargetIdentifier OKIIDHIJBEA, Material MHNAJNGGDFJ)
		{
			int num = (int)(160f * (float)AMCOGJHPPOC.FHCDJOLMIMG() / 488f);
			int num2 = ((num - 0) / 3 + 0) * 3;
			float value = GBEIKNIFNHL.shutterAngle / 560f;
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.DPKAFOKLEFB, value);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CNNDNFOCNLL, (float)num);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.GKIHDBILOGH, 1631f / (float)num);
			int mhgpjficgcm = DGIEACBKFMJ.BNEACEICMJJ.MHGPJFICGCM;
			ECKPLMDEJFD.GetTemporaryRT(mhgpjficgcm, AMCOGJHPPOC.KJDPLLFIIBK(), AMCOGJHPPOC.LKLNPJICOHH(), 0, FilterMode.Point, this.CNECCCNBHKB, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.Blit(null, mhgpjficgcm, MHNAJNGGDFJ, 0);
			int blfkijihinm = DGIEACBKFMJ.BNEACEICMJJ.BLFKIJIHINM;
			ECKPLMDEJFD.GetTemporaryRT(blfkijihinm, AMCOGJHPPOC.LBAMMHHGCGL() / 2, AMCOGJHPPOC.LHPBMEDMNDO() / 3, 1, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, mhgpjficgcm);
			ECKPLMDEJFD.Blit(mhgpjficgcm, blfkijihinm, MHNAJNGGDFJ, 1);
			int dijjoeccplg = DGIEACBKFMJ.BNEACEICMJJ.DIJJOECCPLG;
			ECKPLMDEJFD.GetTemporaryRT(dijjoeccplg, AMCOGJHPPOC.GMOLEDNNPEH() / 6, AMCOGJHPPOC.FHCDJOLMIMG() / 3, 1, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfkijihinm);
			ECKPLMDEJFD.Blit(blfkijihinm, dijjoeccplg, MHNAJNGGDFJ, 6);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfkijihinm);
			int anahokmnlol = DGIEACBKFMJ.BNEACEICMJJ.ANAHOKMNLOL;
			ECKPLMDEJFD.GetTemporaryRT(anahokmnlol, AMCOGJHPPOC.OJNDCCHLMNK() / 7, AMCOGJHPPOC.KNKKIHDHBFD() / 6, 1, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, dijjoeccplg);
			ECKPLMDEJFD.Blit(dijjoeccplg, anahokmnlol, MHNAJNGGDFJ, 0);
			ECKPLMDEJFD.ReleaseTemporaryRT(dijjoeccplg);
			Vector2 v = Vector2.one * ((float)num2 / 546f - 1745f) * 551f;
			ECKPLMDEJFD.SetGlobalVector(DGIEACBKFMJ.BNEACEICMJJ.BOHEBEODDKP, v);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.NOCHFIOAOLP, (float)((int)((float)num2 / 1642f)));
			int blfobdbelpb = DGIEACBKFMJ.BNEACEICMJJ.BLFOBDBELPB;
			ECKPLMDEJFD.GetTemporaryRT(blfobdbelpb, AMCOGJHPPOC.GAIOLBJLPDL() / num2, AMCOGJHPPOC.LKLNPJICOHH() / num2, 1, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, anahokmnlol);
			ECKPLMDEJFD.Blit(anahokmnlol, blfobdbelpb, MHNAJNGGDFJ, 1);
			ECKPLMDEJFD.ReleaseTemporaryRT(anahokmnlol);
			int eoibfpoibna = DGIEACBKFMJ.BNEACEICMJJ.EOIBFPOIBNA;
			int width = AMCOGJHPPOC.LBAMMHHGCGL() / num2;
			int height = AMCOGJHPPOC.HJOKFIGACEC() / num2;
			ECKPLMDEJFD.GetTemporaryRT(eoibfpoibna, width, height, 1, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfobdbelpb);
			ECKPLMDEJFD.Blit(blfobdbelpb, eoibfpoibna, MHNAJNGGDFJ, 8);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfobdbelpb);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CJPHOJJBPAG, (float)Mathf.Clamp(GBEIKNIFNHL.sampleCount / 6, 0, -127));
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
			ECKPLMDEJFD.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, 4);
			ECKPLMDEJFD.ReleaseTemporaryRT(mhgpjficgcm);
			ECKPLMDEJFD.ReleaseTemporaryRT(eoibfpoibna);
		}

		// Token: 0x0601179C RID: 71580 RVA: 0x007CA4FE File Offset: 0x007C86FE
		private void GKALKLLBBEC()
		{
			if (!SystemInfo.SupportsRenderTextureFormat(this.CNECCCNBHKB))
			{
				this.CNECCCNBHKB = RenderTextureFormat.Depth;
			}
		}

		// Token: 0x0601179D RID: 71581 RVA: 0x007C9C37 File Offset: 0x007C7E37
		public bool LKDDGLBEPLF()
		{
			return SystemInfo.supportsMotionVectors;
		}

		// Token: 0x0601179E RID: 71582 RVA: 0x007C9C3E File Offset: 0x007C7E3E
		private void DGCMIKJDMHD()
		{
			if (!SystemInfo.SupportsRenderTextureFormat(this.CNECCCNBHKB))
			{
				this.CNECCCNBHKB = RenderTextureFormat.ARGB32;
			}
		}

		// Token: 0x0601179F RID: 71583 RVA: 0x007C9C37 File Offset: 0x007C7E37
		public bool FBNCJFGAGGM()
		{
			return SystemInfo.supportsMotionVectors;
		}

		// Token: 0x060117A0 RID: 71584 RVA: 0x007CD354 File Offset: 0x007CB554
		public void FHACGOMJPCK(NGEENBGMFFM AMCOGJHPPOC, CommandBuffer ECKPLMDEJFD, ref MotionBlurModel.Settings GBEIKNIFNHL, RenderTargetIdentifier JONJODLFAEN, RenderTargetIdentifier OKIIDHIJBEA, Material MHNAJNGGDFJ)
		{
			int num = (int)(637f * (float)AMCOGJHPPOC.LPJJBJCIELA() / 1029f);
			int num2 = ((num - 1) / 0 + 0) * 0;
			float value = GBEIKNIFNHL.shutterAngle / 980f;
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.DPKAFOKLEFB, value);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CNNDNFOCNLL, (float)num);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.GKIHDBILOGH, 1059f / (float)num);
			int mhgpjficgcm = DGIEACBKFMJ.BNEACEICMJJ.MHGPJFICGCM;
			ECKPLMDEJFD.GetTemporaryRT(mhgpjficgcm, AMCOGJHPPOC.FOBPENGADNB(), AMCOGJHPPOC.NIEGJHLHEEB(), 0, FilterMode.Point, this.CNECCCNBHKB, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.Blit(null, mhgpjficgcm, MHNAJNGGDFJ, 1);
			int blfkijihinm = DGIEACBKFMJ.BNEACEICMJJ.BLFKIJIHINM;
			ECKPLMDEJFD.GetTemporaryRT(blfkijihinm, AMCOGJHPPOC.LBAMMHHGCGL() / 5, AMCOGJHPPOC.CICDECHCDBJ() / 4, 1, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, mhgpjficgcm);
			ECKPLMDEJFD.Blit(mhgpjficgcm, blfkijihinm, MHNAJNGGDFJ, 0);
			int dijjoeccplg = DGIEACBKFMJ.BNEACEICMJJ.DIJJOECCPLG;
			ECKPLMDEJFD.GetTemporaryRT(dijjoeccplg, AMCOGJHPPOC.LJJOEDIJPEM() / 5, AMCOGJHPPOC.KNKKIHDHBFD() / 0, 0, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfkijihinm);
			ECKPLMDEJFD.Blit(blfkijihinm, dijjoeccplg, MHNAJNGGDFJ, 2);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfkijihinm);
			int anahokmnlol = DGIEACBKFMJ.BNEACEICMJJ.ANAHOKMNLOL;
			ECKPLMDEJFD.GetTemporaryRT(anahokmnlol, AMCOGJHPPOC.EOMMKPDCAML() / 4, AMCOGJHPPOC.LPJJBJCIELA() / 8, 0, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, dijjoeccplg);
			ECKPLMDEJFD.Blit(dijjoeccplg, anahokmnlol, MHNAJNGGDFJ, 8);
			ECKPLMDEJFD.ReleaseTemporaryRT(dijjoeccplg);
			Vector2 v = Vector2.one * ((float)num2 / 808f - 1619f) * 748f;
			ECKPLMDEJFD.SetGlobalVector(DGIEACBKFMJ.BNEACEICMJJ.BOHEBEODDKP, v);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.NOCHFIOAOLP, (float)((int)((float)num2 / 1492f)));
			int blfobdbelpb = DGIEACBKFMJ.BNEACEICMJJ.BLFOBDBELPB;
			ECKPLMDEJFD.GetTemporaryRT(blfobdbelpb, AMCOGJHPPOC.GAIOLBJLPDL() / num2, AMCOGJHPPOC.LPJJBJCIELA() / num2, 1, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, anahokmnlol);
			ECKPLMDEJFD.Blit(anahokmnlol, blfobdbelpb, MHNAJNGGDFJ, 6);
			ECKPLMDEJFD.ReleaseTemporaryRT(anahokmnlol);
			int eoibfpoibna = DGIEACBKFMJ.BNEACEICMJJ.EOIBFPOIBNA;
			int width = AMCOGJHPPOC.OCNEHBGMHGB() / num2;
			int height = AMCOGJHPPOC.GHMBALIHBOH() / num2;
			ECKPLMDEJFD.GetTemporaryRT(eoibfpoibna, width, height, 1, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfobdbelpb);
			ECKPLMDEJFD.Blit(blfobdbelpb, eoibfpoibna, MHNAJNGGDFJ, 2);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfobdbelpb);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CJPHOJJBPAG, (float)Mathf.Clamp(GBEIKNIFNHL.sampleCount / 2, 0, -4));
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
			ECKPLMDEJFD.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, 8);
			ECKPLMDEJFD.ReleaseTemporaryRT(mhgpjficgcm);
			ECKPLMDEJFD.ReleaseTemporaryRT(eoibfpoibna);
		}

		// Token: 0x060117A1 RID: 71585 RVA: 0x007CD636 File Offset: 0x007CB836
		public LKOGFPMIKAK()
		{
			this.LFFNICOIPFH();
		}

		// Token: 0x060117A2 RID: 71586 RVA: 0x007C9C37 File Offset: 0x007C7E37
		public bool NHICIEDKAED()
		{
			return SystemInfo.supportsMotionVectors;
		}

		// Token: 0x060117A3 RID: 71587 RVA: 0x007C9C37 File Offset: 0x007C7E37
		public bool MLBELGPBEFK()
		{
			return SystemInfo.supportsMotionVectors;
		}

		// Token: 0x060117A4 RID: 71588 RVA: 0x007C9C37 File Offset: 0x007C7E37
		public bool MIGLMFAHACN()
		{
			return SystemInfo.supportsMotionVectors;
		}

		// Token: 0x060117A5 RID: 71589 RVA: 0x007C9C37 File Offset: 0x007C7E37
		public bool NOIJGHJJCPL()
		{
			return SystemInfo.supportsMotionVectors;
		}

		// Token: 0x060117A6 RID: 71590 RVA: 0x007C9C3E File Offset: 0x007C7E3E
		private void HMCIDFHBNIG()
		{
			if (!SystemInfo.SupportsRenderTextureFormat(this.CNECCCNBHKB))
			{
				this.CNECCCNBHKB = RenderTextureFormat.ARGB32;
			}
		}

		// Token: 0x060117A7 RID: 71591 RVA: 0x007C9C37 File Offset: 0x007C7E37
		public bool BHBHLNEJOIH()
		{
			return SystemInfo.supportsMotionVectors;
		}

		// Token: 0x060117A8 RID: 71592 RVA: 0x007CD654 File Offset: 0x007CB854
		public void GGDFMFPKCEM(NGEENBGMFFM AMCOGJHPPOC, CommandBuffer ECKPLMDEJFD, ref MotionBlurModel.Settings GBEIKNIFNHL, RenderTargetIdentifier JONJODLFAEN, RenderTargetIdentifier OKIIDHIJBEA, Material MHNAJNGGDFJ)
		{
			int num = (int)(323f * (float)AMCOGJHPPOC.NIEGJHLHEEB() / 443f);
			int num2 = ((num - 0) / 3 + 1) * 3;
			float value = GBEIKNIFNHL.shutterAngle / 1667f;
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.DPKAFOKLEFB, value);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CNNDNFOCNLL, (float)num);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.GKIHDBILOGH, 478f / (float)num);
			int mhgpjficgcm = DGIEACBKFMJ.BNEACEICMJJ.MHGPJFICGCM;
			ECKPLMDEJFD.GetTemporaryRT(mhgpjficgcm, AMCOGJHPPOC.GMOLEDNNPEH(), AMCOGJHPPOC.KNKKIHDHBFD(), 0, FilterMode.Point, this.CNECCCNBHKB, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.Blit(null, mhgpjficgcm, MHNAJNGGDFJ, 1);
			int blfkijihinm = DGIEACBKFMJ.BNEACEICMJJ.BLFKIJIHINM;
			ECKPLMDEJFD.GetTemporaryRT(blfkijihinm, AMCOGJHPPOC.KDBADMLHBNP() / 3, AMCOGJHPPOC.HJOKFIGACEC() / 2, 1, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, mhgpjficgcm);
			ECKPLMDEJFD.Blit(mhgpjficgcm, blfkijihinm, MHNAJNGGDFJ, 1);
			int dijjoeccplg = DGIEACBKFMJ.BNEACEICMJJ.DIJJOECCPLG;
			ECKPLMDEJFD.GetTemporaryRT(dijjoeccplg, AMCOGJHPPOC.IBPMMKDPDEO() / 2, AMCOGJHPPOC.GGGEFNKEPDB() / 0, 0, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfkijihinm);
			ECKPLMDEJFD.Blit(blfkijihinm, dijjoeccplg, MHNAJNGGDFJ, 6);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfkijihinm);
			int anahokmnlol = DGIEACBKFMJ.BNEACEICMJJ.ANAHOKMNLOL;
			ECKPLMDEJFD.GetTemporaryRT(anahokmnlol, AMCOGJHPPOC.PAHBMDOJHKK() / 6, AMCOGJHPPOC.LHPBMEDMNDO() / 2, 1, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, dijjoeccplg);
			ECKPLMDEJFD.Blit(dijjoeccplg, anahokmnlol, MHNAJNGGDFJ, 2);
			ECKPLMDEJFD.ReleaseTemporaryRT(dijjoeccplg);
			Vector2 v = Vector2.one * ((float)num2 / 50f - 205f) * 540f;
			ECKPLMDEJFD.SetGlobalVector(DGIEACBKFMJ.BNEACEICMJJ.BOHEBEODDKP, v);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.NOCHFIOAOLP, (float)((int)((float)num2 / 1413f)));
			int blfobdbelpb = DGIEACBKFMJ.BNEACEICMJJ.BLFOBDBELPB;
			ECKPLMDEJFD.GetTemporaryRT(blfobdbelpb, AMCOGJHPPOC.CFDHOKHCPOJ() / num2, AMCOGJHPPOC.MMEMLJENMFF() / num2, 1, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, anahokmnlol);
			ECKPLMDEJFD.Blit(anahokmnlol, blfobdbelpb, MHNAJNGGDFJ, 7);
			ECKPLMDEJFD.ReleaseTemporaryRT(anahokmnlol);
			int eoibfpoibna = DGIEACBKFMJ.BNEACEICMJJ.EOIBFPOIBNA;
			int width = AMCOGJHPPOC.NMCCGCOKKFA() / num2;
			int height = AMCOGJHPPOC.LHPBMEDMNDO() / num2;
			ECKPLMDEJFD.GetTemporaryRT(eoibfpoibna, width, height, 0, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfobdbelpb);
			ECKPLMDEJFD.Blit(blfobdbelpb, eoibfpoibna, MHNAJNGGDFJ, 4);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfobdbelpb);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CJPHOJJBPAG, (float)Mathf.Clamp(GBEIKNIFNHL.sampleCount / 4, 1, 108));
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
			ECKPLMDEJFD.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, 2);
			ECKPLMDEJFD.ReleaseTemporaryRT(mhgpjficgcm);
			ECKPLMDEJFD.ReleaseTemporaryRT(eoibfpoibna);
		}

		// Token: 0x060117A9 RID: 71593 RVA: 0x007CD938 File Offset: 0x007CBB38
		public void LCPINEFKLED(NGEENBGMFFM AMCOGJHPPOC, CommandBuffer ECKPLMDEJFD, ref MotionBlurModel.Settings GBEIKNIFNHL, RenderTargetIdentifier JONJODLFAEN, RenderTargetIdentifier OKIIDHIJBEA, Material MHNAJNGGDFJ)
		{
			int num = (int)(1895f * (float)AMCOGJHPPOC.LPJJBJCIELA() / 582f);
			int num2 = ((num - 1) / 2 + 0) * 7;
			float value = GBEIKNIFNHL.shutterAngle / 1272f;
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.DPKAFOKLEFB, value);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CNNDNFOCNLL, (float)num);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.GKIHDBILOGH, 1982f / (float)num);
			int mhgpjficgcm = DGIEACBKFMJ.BNEACEICMJJ.MHGPJFICGCM;
			ECKPLMDEJFD.GetTemporaryRT(mhgpjficgcm, AMCOGJHPPOC.PAHBMDOJHKK(), AMCOGJHPPOC.FHCDJOLMIMG(), 0, FilterMode.Point, this.CNECCCNBHKB, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.Blit(null, mhgpjficgcm, MHNAJNGGDFJ, 0);
			int blfkijihinm = DGIEACBKFMJ.BNEACEICMJJ.BLFKIJIHINM;
			ECKPLMDEJFD.GetTemporaryRT(blfkijihinm, AMCOGJHPPOC.GMOLEDNNPEH() / 4, AMCOGJHPPOC.MMEMLJENMFF() / 1, 0, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, mhgpjficgcm);
			ECKPLMDEJFD.Blit(mhgpjficgcm, blfkijihinm, MHNAJNGGDFJ, 0);
			int dijjoeccplg = DGIEACBKFMJ.BNEACEICMJJ.DIJJOECCPLG;
			ECKPLMDEJFD.GetTemporaryRT(dijjoeccplg, AMCOGJHPPOC.IBPMMKDPDEO() / 7, AMCOGJHPPOC.LPJJBJCIELA() / 4, 1, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfkijihinm);
			ECKPLMDEJFD.Blit(blfkijihinm, dijjoeccplg, MHNAJNGGDFJ, 3);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfkijihinm);
			int anahokmnlol = DGIEACBKFMJ.BNEACEICMJJ.ANAHOKMNLOL;
			ECKPLMDEJFD.GetTemporaryRT(anahokmnlol, AMCOGJHPPOC.KDBADMLHBNP() / 7, AMCOGJHPPOC.LKLNPJICOHH() / 8, 1, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, dijjoeccplg);
			ECKPLMDEJFD.Blit(dijjoeccplg, anahokmnlol, MHNAJNGGDFJ, 8);
			ECKPLMDEJFD.ReleaseTemporaryRT(dijjoeccplg);
			Vector2 v = Vector2.one * ((float)num2 / 649f - 1329f) * 1567f;
			ECKPLMDEJFD.SetGlobalVector(DGIEACBKFMJ.BNEACEICMJJ.BOHEBEODDKP, v);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.NOCHFIOAOLP, (float)((int)((float)num2 / 156f)));
			int blfobdbelpb = DGIEACBKFMJ.BNEACEICMJJ.BLFOBDBELPB;
			ECKPLMDEJFD.GetTemporaryRT(blfobdbelpb, AMCOGJHPPOC.KJDPLLFIIBK() / num2, AMCOGJHPPOC.ILLKFNCFGMP / num2, 1, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, anahokmnlol);
			ECKPLMDEJFD.Blit(anahokmnlol, blfobdbelpb, MHNAJNGGDFJ, 1);
			ECKPLMDEJFD.ReleaseTemporaryRT(anahokmnlol);
			int eoibfpoibna = DGIEACBKFMJ.BNEACEICMJJ.EOIBFPOIBNA;
			int width = AMCOGJHPPOC.DJGCPIEOAFC() / num2;
			int height = AMCOGJHPPOC.MMEMLJENMFF() / num2;
			ECKPLMDEJFD.GetTemporaryRT(eoibfpoibna, width, height, 1, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfobdbelpb);
			ECKPLMDEJFD.Blit(blfobdbelpb, eoibfpoibna, MHNAJNGGDFJ, 0);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfobdbelpb);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CJPHOJJBPAG, (float)Mathf.Clamp(GBEIKNIFNHL.sampleCount / 5, 0, 28));
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
			ECKPLMDEJFD.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, 0);
			ECKPLMDEJFD.ReleaseTemporaryRT(mhgpjficgcm);
			ECKPLMDEJFD.ReleaseTemporaryRT(eoibfpoibna);
		}

		// Token: 0x060117AA RID: 71594 RVA: 0x007C9C37 File Offset: 0x007C7E37
		public bool CJMIFJCKFFD()
		{
			return SystemInfo.supportsMotionVectors;
		}

		// Token: 0x060117AB RID: 71595 RVA: 0x007C9C37 File Offset: 0x007C7E37
		public bool FEIAGOIJOGL()
		{
			return SystemInfo.supportsMotionVectors;
		}

		// Token: 0x060117AC RID: 71596 RVA: 0x007CDC1C File Offset: 0x007CBE1C
		public void OHMLNPIIOIC(NGEENBGMFFM AMCOGJHPPOC, CommandBuffer ECKPLMDEJFD, ref MotionBlurModel.Settings GBEIKNIFNHL, RenderTargetIdentifier JONJODLFAEN, RenderTargetIdentifier OKIIDHIJBEA, Material MHNAJNGGDFJ)
		{
			int num = (int)(405f * (float)AMCOGJHPPOC.FHCDJOLMIMG() / 865f);
			int num2 = ((num - 0) / 6 + 0) * 2;
			float value = GBEIKNIFNHL.shutterAngle / 1292f;
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.DPKAFOKLEFB, value);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CNNDNFOCNLL, (float)num);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.GKIHDBILOGH, 1706f / (float)num);
			int mhgpjficgcm = DGIEACBKFMJ.BNEACEICMJJ.MHGPJFICGCM;
			ECKPLMDEJFD.GetTemporaryRT(mhgpjficgcm, AMCOGJHPPOC.DHPPGHBNDEB(), AMCOGJHPPOC.CICDECHCDBJ(), 1, FilterMode.Point, this.CNECCCNBHKB, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.Blit(null, mhgpjficgcm, MHNAJNGGDFJ, 0);
			int blfkijihinm = DGIEACBKFMJ.BNEACEICMJJ.BLFKIJIHINM;
			ECKPLMDEJFD.GetTemporaryRT(blfkijihinm, AMCOGJHPPOC.NMCCGCOKKFA() / 3, AMCOGJHPPOC.FHCDJOLMIMG() / 3, 1, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, mhgpjficgcm);
			ECKPLMDEJFD.Blit(mhgpjficgcm, blfkijihinm, MHNAJNGGDFJ, 1);
			int dijjoeccplg = DGIEACBKFMJ.BNEACEICMJJ.DIJJOECCPLG;
			ECKPLMDEJFD.GetTemporaryRT(dijjoeccplg, AMCOGJHPPOC.NMCCGCOKKFA() / 5, AMCOGJHPPOC.ILLKFNCFGMP / 8, 0, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfkijihinm);
			ECKPLMDEJFD.Blit(blfkijihinm, dijjoeccplg, MHNAJNGGDFJ, 6);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfkijihinm);
			int anahokmnlol = DGIEACBKFMJ.BNEACEICMJJ.ANAHOKMNLOL;
			ECKPLMDEJFD.GetTemporaryRT(anahokmnlol, AMCOGJHPPOC.OJNDCCHLMNK() / 0, AMCOGJHPPOC.FHCDJOLMIMG() / 1, 0, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, dijjoeccplg);
			ECKPLMDEJFD.Blit(dijjoeccplg, anahokmnlol, MHNAJNGGDFJ, 5);
			ECKPLMDEJFD.ReleaseTemporaryRT(dijjoeccplg);
			Vector2 v = Vector2.one * ((float)num2 / 328f - 130f) * 1883f;
			ECKPLMDEJFD.SetGlobalVector(DGIEACBKFMJ.BNEACEICMJJ.BOHEBEODDKP, v);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.NOCHFIOAOLP, (float)((int)((float)num2 / 997f)));
			int blfobdbelpb = DGIEACBKFMJ.BNEACEICMJJ.BLFOBDBELPB;
			ECKPLMDEJFD.GetTemporaryRT(blfobdbelpb, AMCOGJHPPOC.NMCCGCOKKFA() / num2, AMCOGJHPPOC.LKLNPJICOHH() / num2, 0, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, anahokmnlol);
			ECKPLMDEJFD.Blit(anahokmnlol, blfobdbelpb, MHNAJNGGDFJ, 2);
			ECKPLMDEJFD.ReleaseTemporaryRT(anahokmnlol);
			int eoibfpoibna = DGIEACBKFMJ.BNEACEICMJJ.EOIBFPOIBNA;
			int width = AMCOGJHPPOC.DHPPGHBNDEB() / num2;
			int height = AMCOGJHPPOC.LKLNPJICOHH() / num2;
			ECKPLMDEJFD.GetTemporaryRT(eoibfpoibna, width, height, 1, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfobdbelpb);
			ECKPLMDEJFD.Blit(blfobdbelpb, eoibfpoibna, MHNAJNGGDFJ, 3);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfobdbelpb);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CJPHOJJBPAG, (float)Mathf.Clamp(GBEIKNIFNHL.sampleCount / 3, 0, 84));
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
			ECKPLMDEJFD.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, 2);
			ECKPLMDEJFD.ReleaseTemporaryRT(mhgpjficgcm);
			ECKPLMDEJFD.ReleaseTemporaryRT(eoibfpoibna);
		}

		// Token: 0x060117AD RID: 71597 RVA: 0x007CDF00 File Offset: 0x007CC100
		public void LCHLMFBIOFO(NGEENBGMFFM AMCOGJHPPOC, CommandBuffer ECKPLMDEJFD, ref MotionBlurModel.Settings GBEIKNIFNHL, RenderTargetIdentifier JONJODLFAEN, RenderTargetIdentifier OKIIDHIJBEA, Material MHNAJNGGDFJ)
		{
			int num = (int)(1424f * (float)AMCOGJHPPOC.LPJJBJCIELA() / 472f);
			int num2 = ((num - 1) / 3 + 0) * 0;
			float value = GBEIKNIFNHL.shutterAngle / 404f;
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.DPKAFOKLEFB, value);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CNNDNFOCNLL, (float)num);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.GKIHDBILOGH, 529f / (float)num);
			int mhgpjficgcm = DGIEACBKFMJ.BNEACEICMJJ.MHGPJFICGCM;
			ECKPLMDEJFD.GetTemporaryRT(mhgpjficgcm, AMCOGJHPPOC.LJJOEDIJPEM(), AMCOGJHPPOC.MMEMLJENMFF(), 0, FilterMode.Bilinear, this.CNECCCNBHKB, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.Blit(null, mhgpjficgcm, MHNAJNGGDFJ, 1);
			int blfkijihinm = DGIEACBKFMJ.BNEACEICMJJ.BLFKIJIHINM;
			ECKPLMDEJFD.GetTemporaryRT(blfkijihinm, AMCOGJHPPOC.GAIOLBJLPDL() / 5, AMCOGJHPPOC.KNKKIHDHBFD() / 2, 1, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, mhgpjficgcm);
			ECKPLMDEJFD.Blit(mhgpjficgcm, blfkijihinm, MHNAJNGGDFJ, 0);
			int dijjoeccplg = DGIEACBKFMJ.BNEACEICMJJ.DIJJOECCPLG;
			ECKPLMDEJFD.GetTemporaryRT(dijjoeccplg, AMCOGJHPPOC.PAHBMDOJHKK() / 7, AMCOGJHPPOC.KNKKIHDHBFD() / 5, 0, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfkijihinm);
			ECKPLMDEJFD.Blit(blfkijihinm, dijjoeccplg, MHNAJNGGDFJ, 3);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfkijihinm);
			int anahokmnlol = DGIEACBKFMJ.BNEACEICMJJ.ANAHOKMNLOL;
			ECKPLMDEJFD.GetTemporaryRT(anahokmnlol, AMCOGJHPPOC.KJDPLLFIIBK() / 0, AMCOGJHPPOC.KNKKIHDHBFD() / 0, 1, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, dijjoeccplg);
			ECKPLMDEJFD.Blit(dijjoeccplg, anahokmnlol, MHNAJNGGDFJ, 3);
			ECKPLMDEJFD.ReleaseTemporaryRT(dijjoeccplg);
			Vector2 v = Vector2.one * ((float)num2 / 935f - 675f) * 1175f;
			ECKPLMDEJFD.SetGlobalVector(DGIEACBKFMJ.BNEACEICMJJ.BOHEBEODDKP, v);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.NOCHFIOAOLP, (float)((int)((float)num2 / 512f)));
			int blfobdbelpb = DGIEACBKFMJ.BNEACEICMJJ.BLFOBDBELPB;
			ECKPLMDEJFD.GetTemporaryRT(blfobdbelpb, AMCOGJHPPOC.GMOLEDNNPEH() / num2, AMCOGJHPPOC.ILLKFNCFGMP / num2, 0, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, anahokmnlol);
			ECKPLMDEJFD.Blit(anahokmnlol, blfobdbelpb, MHNAJNGGDFJ, 2);
			ECKPLMDEJFD.ReleaseTemporaryRT(anahokmnlol);
			int eoibfpoibna = DGIEACBKFMJ.BNEACEICMJJ.EOIBFPOIBNA;
			int width = AMCOGJHPPOC.PAHBMDOJHKK() / num2;
			int height = AMCOGJHPPOC.LHPBMEDMNDO() / num2;
			ECKPLMDEJFD.GetTemporaryRT(eoibfpoibna, width, height, 1, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfobdbelpb);
			ECKPLMDEJFD.Blit(blfobdbelpb, eoibfpoibna, MHNAJNGGDFJ, 7);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfobdbelpb);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CJPHOJJBPAG, (float)Mathf.Clamp(GBEIKNIFNHL.sampleCount / 8, 1, -95));
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
			ECKPLMDEJFD.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, 8);
			ECKPLMDEJFD.ReleaseTemporaryRT(mhgpjficgcm);
			ECKPLMDEJFD.ReleaseTemporaryRT(eoibfpoibna);
		}

		// Token: 0x060117AE RID: 71598 RVA: 0x007CA4FE File Offset: 0x007C86FE
		private void KHEDIBGAOBC()
		{
			if (!SystemInfo.SupportsRenderTextureFormat(this.CNECCCNBHKB))
			{
				this.CNECCCNBHKB = RenderTextureFormat.Depth;
			}
		}

		// Token: 0x060117AF RID: 71599 RVA: 0x007C9C3E File Offset: 0x007C7E3E
		private void MJHGPFGPCAF()
		{
			if (!SystemInfo.SupportsRenderTextureFormat(this.CNECCCNBHKB))
			{
				this.CNECCCNBHKB = RenderTextureFormat.ARGB32;
			}
		}

		// Token: 0x060117B0 RID: 71600 RVA: 0x007C9C3E File Offset: 0x007C7E3E
		private void GOGOOBCCGGC()
		{
			if (!SystemInfo.SupportsRenderTextureFormat(this.CNECCCNBHKB))
			{
				this.CNECCCNBHKB = RenderTextureFormat.ARGB32;
			}
		}

		// Token: 0x060117B1 RID: 71601 RVA: 0x007CE1E4 File Offset: 0x007CC3E4
		public void DDBDBLAAKEJ(NGEENBGMFFM AMCOGJHPPOC, CommandBuffer ECKPLMDEJFD, ref MotionBlurModel.Settings GBEIKNIFNHL, RenderTargetIdentifier JONJODLFAEN, RenderTargetIdentifier OKIIDHIJBEA, Material MHNAJNGGDFJ)
		{
			int num = (int)(1521f * (float)AMCOGJHPPOC.GHMBALIHBOH() / 922f);
			int num2 = ((num - 1) / 5 + 1) * 8;
			float value = GBEIKNIFNHL.shutterAngle / 108f;
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.DPKAFOKLEFB, value);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CNNDNFOCNLL, (float)num);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.GKIHDBILOGH, 503f / (float)num);
			int mhgpjficgcm = DGIEACBKFMJ.BNEACEICMJJ.MHGPJFICGCM;
			ECKPLMDEJFD.GetTemporaryRT(mhgpjficgcm, AMCOGJHPPOC.CFDHOKHCPOJ(), AMCOGJHPPOC.ILLKFNCFGMP, 0, FilterMode.Point, this.CNECCCNBHKB, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.Blit(null, mhgpjficgcm, MHNAJNGGDFJ, 1);
			int blfkijihinm = DGIEACBKFMJ.BNEACEICMJJ.BLFKIJIHINM;
			ECKPLMDEJFD.GetTemporaryRT(blfkijihinm, AMCOGJHPPOC.DHPPGHBNDEB() / 0, AMCOGJHPPOC.KNKKIHDHBFD() / 4, 1, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, mhgpjficgcm);
			ECKPLMDEJFD.Blit(mhgpjficgcm, blfkijihinm, MHNAJNGGDFJ, 0);
			int dijjoeccplg = DGIEACBKFMJ.BNEACEICMJJ.DIJJOECCPLG;
			ECKPLMDEJFD.GetTemporaryRT(dijjoeccplg, AMCOGJHPPOC.DJGCPIEOAFC() / 3, AMCOGJHPPOC.CICDECHCDBJ() / 4, 0, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfkijihinm);
			ECKPLMDEJFD.Blit(blfkijihinm, dijjoeccplg, MHNAJNGGDFJ, 4);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfkijihinm);
			int anahokmnlol = DGIEACBKFMJ.BNEACEICMJJ.ANAHOKMNLOL;
			ECKPLMDEJFD.GetTemporaryRT(anahokmnlol, AMCOGJHPPOC.LBAMMHHGCGL() / 8, AMCOGJHPPOC.GHMBALIHBOH() / 7, 1, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, dijjoeccplg);
			ECKPLMDEJFD.Blit(dijjoeccplg, anahokmnlol, MHNAJNGGDFJ, 1);
			ECKPLMDEJFD.ReleaseTemporaryRT(dijjoeccplg);
			Vector2 v = Vector2.one * ((float)num2 / 501f - 1077f) * 1011f;
			ECKPLMDEJFD.SetGlobalVector(DGIEACBKFMJ.BNEACEICMJJ.BOHEBEODDKP, v);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.NOCHFIOAOLP, (float)((int)((float)num2 / 413f)));
			int blfobdbelpb = DGIEACBKFMJ.BNEACEICMJJ.BLFOBDBELPB;
			ECKPLMDEJFD.GetTemporaryRT(blfobdbelpb, AMCOGJHPPOC.NMEBEEHCALN / num2, AMCOGJHPPOC.GHMBALIHBOH() / num2, 1, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, anahokmnlol);
			ECKPLMDEJFD.Blit(anahokmnlol, blfobdbelpb, MHNAJNGGDFJ, 7);
			ECKPLMDEJFD.ReleaseTemporaryRT(anahokmnlol);
			int eoibfpoibna = DGIEACBKFMJ.BNEACEICMJJ.EOIBFPOIBNA;
			int width = AMCOGJHPPOC.EOMMKPDCAML() / num2;
			int height = AMCOGJHPPOC.LPJJBJCIELA() / num2;
			ECKPLMDEJFD.GetTemporaryRT(eoibfpoibna, width, height, 0, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfobdbelpb);
			ECKPLMDEJFD.Blit(blfobdbelpb, eoibfpoibna, MHNAJNGGDFJ, 5);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfobdbelpb);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CJPHOJJBPAG, (float)Mathf.Clamp(GBEIKNIFNHL.sampleCount / 1, 1, -82));
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
			ECKPLMDEJFD.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, 8);
			ECKPLMDEJFD.ReleaseTemporaryRT(mhgpjficgcm);
			ECKPLMDEJFD.ReleaseTemporaryRT(eoibfpoibna);
		}

		// Token: 0x060117B2 RID: 71602 RVA: 0x007CE4C8 File Offset: 0x007CC6C8
		public void OKNCLAIIEGM(NGEENBGMFFM AMCOGJHPPOC, CommandBuffer ECKPLMDEJFD, ref MotionBlurModel.Settings GBEIKNIFNHL, RenderTargetIdentifier JONJODLFAEN, RenderTargetIdentifier OKIIDHIJBEA, Material MHNAJNGGDFJ)
		{
			int num = (int)(43f * (float)AMCOGJHPPOC.MMEMLJENMFF() / 1560f);
			int num2 = ((num - 0) / 6 + 0) * 5;
			float value = GBEIKNIFNHL.shutterAngle / 1455f;
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.DPKAFOKLEFB, value);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CNNDNFOCNLL, (float)num);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.GKIHDBILOGH, 1888f / (float)num);
			int mhgpjficgcm = DGIEACBKFMJ.BNEACEICMJJ.MHGPJFICGCM;
			ECKPLMDEJFD.GetTemporaryRT(mhgpjficgcm, AMCOGJHPPOC.LJJOEDIJPEM(), AMCOGJHPPOC.GGGEFNKEPDB(), 1, FilterMode.Bilinear, this.CNECCCNBHKB, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.Blit(null, mhgpjficgcm, MHNAJNGGDFJ, 1);
			int blfkijihinm = DGIEACBKFMJ.BNEACEICMJJ.BLFKIJIHINM;
			ECKPLMDEJFD.GetTemporaryRT(blfkijihinm, AMCOGJHPPOC.LJJOEDIJPEM() / 0, AMCOGJHPPOC.CICDECHCDBJ() / 7, 1, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, mhgpjficgcm);
			ECKPLMDEJFD.Blit(mhgpjficgcm, blfkijihinm, MHNAJNGGDFJ, 0);
			int dijjoeccplg = DGIEACBKFMJ.BNEACEICMJJ.DIJJOECCPLG;
			ECKPLMDEJFD.GetTemporaryRT(dijjoeccplg, AMCOGJHPPOC.GAIOLBJLPDL() / 3, AMCOGJHPPOC.HJOKFIGACEC() / 6, 0, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfkijihinm);
			ECKPLMDEJFD.Blit(blfkijihinm, dijjoeccplg, MHNAJNGGDFJ, 1);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfkijihinm);
			int anahokmnlol = DGIEACBKFMJ.BNEACEICMJJ.ANAHOKMNLOL;
			ECKPLMDEJFD.GetTemporaryRT(anahokmnlol, AMCOGJHPPOC.KDBADMLHBNP() / 0, AMCOGJHPPOC.NIEGJHLHEEB() / 1, 0, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, dijjoeccplg);
			ECKPLMDEJFD.Blit(dijjoeccplg, anahokmnlol, MHNAJNGGDFJ, 7);
			ECKPLMDEJFD.ReleaseTemporaryRT(dijjoeccplg);
			Vector2 v = Vector2.one * ((float)num2 / 221f - 1272f) * 370f;
			ECKPLMDEJFD.SetGlobalVector(DGIEACBKFMJ.BNEACEICMJJ.BOHEBEODDKP, v);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.NOCHFIOAOLP, (float)((int)((float)num2 / 1566f)));
			int blfobdbelpb = DGIEACBKFMJ.BNEACEICMJJ.BLFOBDBELPB;
			ECKPLMDEJFD.GetTemporaryRT(blfobdbelpb, AMCOGJHPPOC.DHPPGHBNDEB() / num2, AMCOGJHPPOC.KNKKIHDHBFD() / num2, 0, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, anahokmnlol);
			ECKPLMDEJFD.Blit(anahokmnlol, blfobdbelpb, MHNAJNGGDFJ, 5);
			ECKPLMDEJFD.ReleaseTemporaryRT(anahokmnlol);
			int eoibfpoibna = DGIEACBKFMJ.BNEACEICMJJ.EOIBFPOIBNA;
			int width = AMCOGJHPPOC.DHPPGHBNDEB() / num2;
			int height = AMCOGJHPPOC.KNKKIHDHBFD() / num2;
			ECKPLMDEJFD.GetTemporaryRT(eoibfpoibna, width, height, 0, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfobdbelpb);
			ECKPLMDEJFD.Blit(blfobdbelpb, eoibfpoibna, MHNAJNGGDFJ, 6);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfobdbelpb);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CJPHOJJBPAG, (float)Mathf.Clamp(GBEIKNIFNHL.sampleCount / 6, 1, -56));
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
			ECKPLMDEJFD.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, 0);
			ECKPLMDEJFD.ReleaseTemporaryRT(mhgpjficgcm);
			ECKPLMDEJFD.ReleaseTemporaryRT(eoibfpoibna);
		}

		// Token: 0x060117B3 RID: 71603 RVA: 0x007C9C37 File Offset: 0x007C7E37
		public bool HJPCDDOIPFK()
		{
			return SystemInfo.supportsMotionVectors;
		}

		// Token: 0x060117B4 RID: 71604 RVA: 0x007C9C37 File Offset: 0x007C7E37
		public bool LBDDEHBPBNJ()
		{
			return SystemInfo.supportsMotionVectors;
		}

		// Token: 0x060117B5 RID: 71605 RVA: 0x007CE7AC File Offset: 0x007CC9AC
		public void GJDMCPHLELD(NGEENBGMFFM AMCOGJHPPOC, CommandBuffer ECKPLMDEJFD, ref MotionBlurModel.Settings GBEIKNIFNHL, RenderTargetIdentifier JONJODLFAEN, RenderTargetIdentifier OKIIDHIJBEA, Material MHNAJNGGDFJ)
		{
			int num = (int)(1312f * (float)AMCOGJHPPOC.CICDECHCDBJ() / 1523f);
			int num2 = ((num - 0) / 1 + 0) * 6;
			float value = GBEIKNIFNHL.shutterAngle / 1985f;
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.DPKAFOKLEFB, value);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CNNDNFOCNLL, (float)num);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.GKIHDBILOGH, 428f / (float)num);
			int mhgpjficgcm = DGIEACBKFMJ.BNEACEICMJJ.MHGPJFICGCM;
			ECKPLMDEJFD.GetTemporaryRT(mhgpjficgcm, AMCOGJHPPOC.KJDPLLFIIBK(), AMCOGJHPPOC.GGGEFNKEPDB(), 0, FilterMode.Point, this.CNECCCNBHKB, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.Blit(null, mhgpjficgcm, MHNAJNGGDFJ, 1);
			int blfkijihinm = DGIEACBKFMJ.BNEACEICMJJ.BLFKIJIHINM;
			ECKPLMDEJFD.GetTemporaryRT(blfkijihinm, AMCOGJHPPOC.GAIOLBJLPDL() / 6, AMCOGJHPPOC.LKLNPJICOHH() / 4, 0, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, mhgpjficgcm);
			ECKPLMDEJFD.Blit(mhgpjficgcm, blfkijihinm, MHNAJNGGDFJ, 1);
			int dijjoeccplg = DGIEACBKFMJ.BNEACEICMJJ.DIJJOECCPLG;
			ECKPLMDEJFD.GetTemporaryRT(dijjoeccplg, AMCOGJHPPOC.GMOLEDNNPEH() / 1, AMCOGJHPPOC.NIEGJHLHEEB() / 7, 0, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfkijihinm);
			ECKPLMDEJFD.Blit(blfkijihinm, dijjoeccplg, MHNAJNGGDFJ, 3);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfkijihinm);
			int anahokmnlol = DGIEACBKFMJ.BNEACEICMJJ.ANAHOKMNLOL;
			ECKPLMDEJFD.GetTemporaryRT(anahokmnlol, AMCOGJHPPOC.IGHJHMGOGOO() / 2, AMCOGJHPPOC.CICDECHCDBJ() / 7, 1, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, dijjoeccplg);
			ECKPLMDEJFD.Blit(dijjoeccplg, anahokmnlol, MHNAJNGGDFJ, 7);
			ECKPLMDEJFD.ReleaseTemporaryRT(dijjoeccplg);
			Vector2 v = Vector2.one * ((float)num2 / 1551f - 1508f) * 615f;
			ECKPLMDEJFD.SetGlobalVector(DGIEACBKFMJ.BNEACEICMJJ.BOHEBEODDKP, v);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.NOCHFIOAOLP, (float)((int)((float)num2 / 1868f)));
			int blfobdbelpb = DGIEACBKFMJ.BNEACEICMJJ.BLFOBDBELPB;
			ECKPLMDEJFD.GetTemporaryRT(blfobdbelpb, AMCOGJHPPOC.DJGCPIEOAFC() / num2, AMCOGJHPPOC.NIEGJHLHEEB() / num2, 0, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, anahokmnlol);
			ECKPLMDEJFD.Blit(anahokmnlol, blfobdbelpb, MHNAJNGGDFJ, 8);
			ECKPLMDEJFD.ReleaseTemporaryRT(anahokmnlol);
			int eoibfpoibna = DGIEACBKFMJ.BNEACEICMJJ.EOIBFPOIBNA;
			int width = AMCOGJHPPOC.GAIOLBJLPDL() / num2;
			int height = AMCOGJHPPOC.MMEMLJENMFF() / num2;
			ECKPLMDEJFD.GetTemporaryRT(eoibfpoibna, width, height, 0, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfobdbelpb);
			ECKPLMDEJFD.Blit(blfobdbelpb, eoibfpoibna, MHNAJNGGDFJ, 5);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfobdbelpb);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CJPHOJJBPAG, (float)Mathf.Clamp(GBEIKNIFNHL.sampleCount / 4, 0, 112));
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
			ECKPLMDEJFD.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, 5);
			ECKPLMDEJFD.ReleaseTemporaryRT(mhgpjficgcm);
			ECKPLMDEJFD.ReleaseTemporaryRT(eoibfpoibna);
		}

		// Token: 0x060117B6 RID: 71606 RVA: 0x007C9C37 File Offset: 0x007C7E37
		public bool IFOHNHCCKEM()
		{
			return SystemInfo.supportsMotionVectors;
		}

		// Token: 0x060117B7 RID: 71607 RVA: 0x007C9C3E File Offset: 0x007C7E3E
		private void IBIKCGJPBDD()
		{
			if (!SystemInfo.SupportsRenderTextureFormat(this.CNECCCNBHKB))
			{
				this.CNECCCNBHKB = RenderTextureFormat.ARGB32;
			}
		}

		// Token: 0x060117B8 RID: 71608 RVA: 0x007C9C37 File Offset: 0x007C7E37
		public bool MEEFONBDFLO()
		{
			return SystemInfo.supportsMotionVectors;
		}

		// Token: 0x060117B9 RID: 71609 RVA: 0x007CEA90 File Offset: 0x007CCC90
		public void IEBDHFPFOPH(NGEENBGMFFM AMCOGJHPPOC, CommandBuffer ECKPLMDEJFD, ref MotionBlurModel.Settings GBEIKNIFNHL, RenderTargetIdentifier JONJODLFAEN, RenderTargetIdentifier OKIIDHIJBEA, Material MHNAJNGGDFJ)
		{
			int num = (int)(554f * (float)AMCOGJHPPOC.CICDECHCDBJ() / 1211f);
			int num2 = ((num - 1) / 4 + 1) * 6;
			float value = GBEIKNIFNHL.shutterAngle / 1279f;
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.DPKAFOKLEFB, value);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CNNDNFOCNLL, (float)num);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.GKIHDBILOGH, 1394f / (float)num);
			int mhgpjficgcm = DGIEACBKFMJ.BNEACEICMJJ.MHGPJFICGCM;
			ECKPLMDEJFD.GetTemporaryRT(mhgpjficgcm, AMCOGJHPPOC.LBAMMHHGCGL(), AMCOGJHPPOC.KNKKIHDHBFD(), 0, FilterMode.Point, this.CNECCCNBHKB, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.Blit(null, mhgpjficgcm, MHNAJNGGDFJ, 1);
			int blfkijihinm = DGIEACBKFMJ.BNEACEICMJJ.BLFKIJIHINM;
			ECKPLMDEJFD.GetTemporaryRT(blfkijihinm, AMCOGJHPPOC.PAHBMDOJHKK() / 5, AMCOGJHPPOC.HJOKFIGACEC() / 7, 1, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, mhgpjficgcm);
			ECKPLMDEJFD.Blit(mhgpjficgcm, blfkijihinm, MHNAJNGGDFJ, 0);
			int dijjoeccplg = DGIEACBKFMJ.BNEACEICMJJ.DIJJOECCPLG;
			ECKPLMDEJFD.GetTemporaryRT(dijjoeccplg, AMCOGJHPPOC.GMOLEDNNPEH() / 5, AMCOGJHPPOC.GGGEFNKEPDB() / 5, 1, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfkijihinm);
			ECKPLMDEJFD.Blit(blfkijihinm, dijjoeccplg, MHNAJNGGDFJ, 6);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfkijihinm);
			int anahokmnlol = DGIEACBKFMJ.BNEACEICMJJ.ANAHOKMNLOL;
			ECKPLMDEJFD.GetTemporaryRT(anahokmnlol, AMCOGJHPPOC.GMOLEDNNPEH() / 8, AMCOGJHPPOC.LPJJBJCIELA() / 4, 1, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, dijjoeccplg);
			ECKPLMDEJFD.Blit(dijjoeccplg, anahokmnlol, MHNAJNGGDFJ, 2);
			ECKPLMDEJFD.ReleaseTemporaryRT(dijjoeccplg);
			Vector2 v = Vector2.one * ((float)num2 / 238f - 1626f) * 811f;
			ECKPLMDEJFD.SetGlobalVector(DGIEACBKFMJ.BNEACEICMJJ.BOHEBEODDKP, v);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.NOCHFIOAOLP, (float)((int)((float)num2 / 932f)));
			int blfobdbelpb = DGIEACBKFMJ.BNEACEICMJJ.BLFOBDBELPB;
			ECKPLMDEJFD.GetTemporaryRT(blfobdbelpb, AMCOGJHPPOC.EOMMKPDCAML() / num2, AMCOGJHPPOC.LHPBMEDMNDO() / num2, 0, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, anahokmnlol);
			ECKPLMDEJFD.Blit(anahokmnlol, blfobdbelpb, MHNAJNGGDFJ, 6);
			ECKPLMDEJFD.ReleaseTemporaryRT(anahokmnlol);
			int eoibfpoibna = DGIEACBKFMJ.BNEACEICMJJ.EOIBFPOIBNA;
			int width = AMCOGJHPPOC.KDBADMLHBNP() / num2;
			int height = AMCOGJHPPOC.GHMBALIHBOH() / num2;
			ECKPLMDEJFD.GetTemporaryRT(eoibfpoibna, width, height, 0, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfobdbelpb);
			ECKPLMDEJFD.Blit(blfobdbelpb, eoibfpoibna, MHNAJNGGDFJ, 0);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfobdbelpb);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CJPHOJJBPAG, (float)Mathf.Clamp(GBEIKNIFNHL.sampleCount / 3, 1, -52));
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
			ECKPLMDEJFD.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, 2);
			ECKPLMDEJFD.ReleaseTemporaryRT(mhgpjficgcm);
			ECKPLMDEJFD.ReleaseTemporaryRT(eoibfpoibna);
		}

		// Token: 0x060117BA RID: 71610 RVA: 0x007CA4FE File Offset: 0x007C86FE
		private void LBGNNIBLFIB()
		{
			if (!SystemInfo.SupportsRenderTextureFormat(this.CNECCCNBHKB))
			{
				this.CNECCCNBHKB = RenderTextureFormat.Depth;
			}
		}

		// Token: 0x060117BB RID: 71611 RVA: 0x007CED74 File Offset: 0x007CCF74
		public void NDEOLIHCDCO(NGEENBGMFFM AMCOGJHPPOC, CommandBuffer ECKPLMDEJFD, ref MotionBlurModel.Settings GBEIKNIFNHL, RenderTargetIdentifier JONJODLFAEN, RenderTargetIdentifier OKIIDHIJBEA, Material MHNAJNGGDFJ)
		{
			int num = (int)(1392f * (float)AMCOGJHPPOC.FHCDJOLMIMG() / 746f);
			int num2 = ((num - 0) / 5 + 1) * 7;
			float value = GBEIKNIFNHL.shutterAngle / 417f;
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.DPKAFOKLEFB, value);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CNNDNFOCNLL, (float)num);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.GKIHDBILOGH, 418f / (float)num);
			int mhgpjficgcm = DGIEACBKFMJ.BNEACEICMJJ.MHGPJFICGCM;
			ECKPLMDEJFD.GetTemporaryRT(mhgpjficgcm, AMCOGJHPPOC.EOMMKPDCAML(), AMCOGJHPPOC.LHPBMEDMNDO(), 1, FilterMode.Point, this.CNECCCNBHKB, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.Blit(null, mhgpjficgcm, MHNAJNGGDFJ, 0);
			int blfkijihinm = DGIEACBKFMJ.BNEACEICMJJ.BLFKIJIHINM;
			ECKPLMDEJFD.GetTemporaryRT(blfkijihinm, AMCOGJHPPOC.KJDPLLFIIBK() / 8, AMCOGJHPPOC.GHMBALIHBOH() / 1, 1, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, mhgpjficgcm);
			ECKPLMDEJFD.Blit(mhgpjficgcm, blfkijihinm, MHNAJNGGDFJ, 1);
			int dijjoeccplg = DGIEACBKFMJ.BNEACEICMJJ.DIJJOECCPLG;
			ECKPLMDEJFD.GetTemporaryRT(dijjoeccplg, AMCOGJHPPOC.NMCCGCOKKFA() / 2, AMCOGJHPPOC.NIEGJHLHEEB() / 6, 0, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfkijihinm);
			ECKPLMDEJFD.Blit(blfkijihinm, dijjoeccplg, MHNAJNGGDFJ, 7);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfkijihinm);
			int anahokmnlol = DGIEACBKFMJ.BNEACEICMJJ.ANAHOKMNLOL;
			ECKPLMDEJFD.GetTemporaryRT(anahokmnlol, AMCOGJHPPOC.IGHJHMGOGOO() / 8, AMCOGJHPPOC.GHMBALIHBOH() / 4, 1, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, dijjoeccplg);
			ECKPLMDEJFD.Blit(dijjoeccplg, anahokmnlol, MHNAJNGGDFJ, 0);
			ECKPLMDEJFD.ReleaseTemporaryRT(dijjoeccplg);
			Vector2 v = Vector2.one * ((float)num2 / 394f - 716f) * 746f;
			ECKPLMDEJFD.SetGlobalVector(DGIEACBKFMJ.BNEACEICMJJ.BOHEBEODDKP, v);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.NOCHFIOAOLP, (float)((int)((float)num2 / 1826f)));
			int blfobdbelpb = DGIEACBKFMJ.BNEACEICMJJ.BLFOBDBELPB;
			ECKPLMDEJFD.GetTemporaryRT(blfobdbelpb, AMCOGJHPPOC.IGHJHMGOGOO() / num2, AMCOGJHPPOC.LKLNPJICOHH() / num2, 1, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, anahokmnlol);
			ECKPLMDEJFD.Blit(anahokmnlol, blfobdbelpb, MHNAJNGGDFJ, 7);
			ECKPLMDEJFD.ReleaseTemporaryRT(anahokmnlol);
			int eoibfpoibna = DGIEACBKFMJ.BNEACEICMJJ.EOIBFPOIBNA;
			int width = AMCOGJHPPOC.KDBADMLHBNP() / num2;
			int height = AMCOGJHPPOC.ILLKFNCFGMP / num2;
			ECKPLMDEJFD.GetTemporaryRT(eoibfpoibna, width, height, 1, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfobdbelpb);
			ECKPLMDEJFD.Blit(blfobdbelpb, eoibfpoibna, MHNAJNGGDFJ, 8);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfobdbelpb);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CJPHOJJBPAG, (float)Mathf.Clamp(GBEIKNIFNHL.sampleCount / 4, 0, 116));
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
			ECKPLMDEJFD.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, 8);
			ECKPLMDEJFD.ReleaseTemporaryRT(mhgpjficgcm);
			ECKPLMDEJFD.ReleaseTemporaryRT(eoibfpoibna);
		}

		// Token: 0x060117BC RID: 71612 RVA: 0x007CF058 File Offset: 0x007CD258
		public void NOPEDECMBDN(NGEENBGMFFM AMCOGJHPPOC, CommandBuffer ECKPLMDEJFD, ref MotionBlurModel.Settings GBEIKNIFNHL, RenderTargetIdentifier JONJODLFAEN, RenderTargetIdentifier OKIIDHIJBEA, Material MHNAJNGGDFJ)
		{
			int num = (int)(954f * (float)AMCOGJHPPOC.GGGEFNKEPDB() / 342f);
			int num2 = ((num - 0) / 2 + 1) * 8;
			float value = GBEIKNIFNHL.shutterAngle / 1113f;
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.DPKAFOKLEFB, value);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CNNDNFOCNLL, (float)num);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.GKIHDBILOGH, 556f / (float)num);
			int mhgpjficgcm = DGIEACBKFMJ.BNEACEICMJJ.MHGPJFICGCM;
			ECKPLMDEJFD.GetTemporaryRT(mhgpjficgcm, AMCOGJHPPOC.LBAMMHHGCGL(), AMCOGJHPPOC.LPJJBJCIELA(), 1, FilterMode.Bilinear, this.CNECCCNBHKB, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.Blit(null, mhgpjficgcm, MHNAJNGGDFJ, 1);
			int blfkijihinm = DGIEACBKFMJ.BNEACEICMJJ.BLFKIJIHINM;
			ECKPLMDEJFD.GetTemporaryRT(blfkijihinm, AMCOGJHPPOC.GAIOLBJLPDL() / 7, AMCOGJHPPOC.LHPBMEDMNDO() / 3, 1, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, mhgpjficgcm);
			ECKPLMDEJFD.Blit(mhgpjficgcm, blfkijihinm, MHNAJNGGDFJ, 0);
			int dijjoeccplg = DGIEACBKFMJ.BNEACEICMJJ.DIJJOECCPLG;
			ECKPLMDEJFD.GetTemporaryRT(dijjoeccplg, AMCOGJHPPOC.FOBPENGADNB() / 2, AMCOGJHPPOC.LHPBMEDMNDO() / 0, 0, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfkijihinm);
			ECKPLMDEJFD.Blit(blfkijihinm, dijjoeccplg, MHNAJNGGDFJ, 2);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfkijihinm);
			int anahokmnlol = DGIEACBKFMJ.BNEACEICMJJ.ANAHOKMNLOL;
			ECKPLMDEJFD.GetTemporaryRT(anahokmnlol, AMCOGJHPPOC.KJDPLLFIIBK() / 5, AMCOGJHPPOC.CICDECHCDBJ() / 1, 1, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, dijjoeccplg);
			ECKPLMDEJFD.Blit(dijjoeccplg, anahokmnlol, MHNAJNGGDFJ, 6);
			ECKPLMDEJFD.ReleaseTemporaryRT(dijjoeccplg);
			Vector2 v = Vector2.one * ((float)num2 / 635f - 1191f) * 578f;
			ECKPLMDEJFD.SetGlobalVector(DGIEACBKFMJ.BNEACEICMJJ.BOHEBEODDKP, v);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.NOCHFIOAOLP, (float)((int)((float)num2 / 1021f)));
			int blfobdbelpb = DGIEACBKFMJ.BNEACEICMJJ.BLFOBDBELPB;
			ECKPLMDEJFD.GetTemporaryRT(blfobdbelpb, AMCOGJHPPOC.EOMMKPDCAML() / num2, AMCOGJHPPOC.LPJJBJCIELA() / num2, 1, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, anahokmnlol);
			ECKPLMDEJFD.Blit(anahokmnlol, blfobdbelpb, MHNAJNGGDFJ, 3);
			ECKPLMDEJFD.ReleaseTemporaryRT(anahokmnlol);
			int eoibfpoibna = DGIEACBKFMJ.BNEACEICMJJ.EOIBFPOIBNA;
			int width = AMCOGJHPPOC.LJJOEDIJPEM() / num2;
			int height = AMCOGJHPPOC.CICDECHCDBJ() / num2;
			ECKPLMDEJFD.GetTemporaryRT(eoibfpoibna, width, height, 1, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfobdbelpb);
			ECKPLMDEJFD.Blit(blfobdbelpb, eoibfpoibna, MHNAJNGGDFJ, 3);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfobdbelpb);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CJPHOJJBPAG, (float)Mathf.Clamp(GBEIKNIFNHL.sampleCount / 3, 0, 67));
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
			ECKPLMDEJFD.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, 4);
			ECKPLMDEJFD.ReleaseTemporaryRT(mhgpjficgcm);
			ECKPLMDEJFD.ReleaseTemporaryRT(eoibfpoibna);
		}

		// Token: 0x060117BD RID: 71613 RVA: 0x007CA4FE File Offset: 0x007C86FE
		private void BIJIOBINCAE()
		{
			if (!SystemInfo.SupportsRenderTextureFormat(this.CNECCCNBHKB))
			{
				this.CNECCCNBHKB = RenderTextureFormat.Depth;
			}
		}

		// Token: 0x060117BE RID: 71614 RVA: 0x007CA4FE File Offset: 0x007C86FE
		private void JDCJBGCHDJC()
		{
			if (!SystemInfo.SupportsRenderTextureFormat(this.CNECCCNBHKB))
			{
				this.CNECCCNBHKB = RenderTextureFormat.Depth;
			}
		}

		// Token: 0x060117BF RID: 71615 RVA: 0x007CF33C File Offset: 0x007CD53C
		public void JLHAONFBGJI(NGEENBGMFFM AMCOGJHPPOC, CommandBuffer ECKPLMDEJFD, ref MotionBlurModel.Settings GBEIKNIFNHL, RenderTargetIdentifier JONJODLFAEN, RenderTargetIdentifier OKIIDHIJBEA, Material MHNAJNGGDFJ)
		{
			int num = (int)(1533f * (float)AMCOGJHPPOC.LPJJBJCIELA() / 1063f);
			int num2 = ((num - 0) / 2 + 1) * 1;
			float value = GBEIKNIFNHL.shutterAngle / 974f;
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.DPKAFOKLEFB, value);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CNNDNFOCNLL, (float)num);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.GKIHDBILOGH, 617f / (float)num);
			int mhgpjficgcm = DGIEACBKFMJ.BNEACEICMJJ.MHGPJFICGCM;
			ECKPLMDEJFD.GetTemporaryRT(mhgpjficgcm, AMCOGJHPPOC.NMEBEEHCALN, AMCOGJHPPOC.HJOKFIGACEC(), 0, FilterMode.Bilinear, this.CNECCCNBHKB, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.Blit(null, mhgpjficgcm, MHNAJNGGDFJ, 0);
			int blfkijihinm = DGIEACBKFMJ.BNEACEICMJJ.BLFKIJIHINM;
			ECKPLMDEJFD.GetTemporaryRT(blfkijihinm, AMCOGJHPPOC.OJNDCCHLMNK() / 6, AMCOGJHPPOC.HJOKFIGACEC() / 2, 1, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, mhgpjficgcm);
			ECKPLMDEJFD.Blit(mhgpjficgcm, blfkijihinm, MHNAJNGGDFJ, 0);
			int dijjoeccplg = DGIEACBKFMJ.BNEACEICMJJ.DIJJOECCPLG;
			ECKPLMDEJFD.GetTemporaryRT(dijjoeccplg, AMCOGJHPPOC.EOMMKPDCAML() / 1, AMCOGJHPPOC.GGGEFNKEPDB() / 7, 0, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfkijihinm);
			ECKPLMDEJFD.Blit(blfkijihinm, dijjoeccplg, MHNAJNGGDFJ, 7);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfkijihinm);
			int anahokmnlol = DGIEACBKFMJ.BNEACEICMJJ.ANAHOKMNLOL;
			ECKPLMDEJFD.GetTemporaryRT(anahokmnlol, AMCOGJHPPOC.OJNDCCHLMNK() / 7, AMCOGJHPPOC.MMEMLJENMFF() / 8, 1, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, dijjoeccplg);
			ECKPLMDEJFD.Blit(dijjoeccplg, anahokmnlol, MHNAJNGGDFJ, 4);
			ECKPLMDEJFD.ReleaseTemporaryRT(dijjoeccplg);
			Vector2 v = Vector2.one * ((float)num2 / 532f - 974f) * 116f;
			ECKPLMDEJFD.SetGlobalVector(DGIEACBKFMJ.BNEACEICMJJ.BOHEBEODDKP, v);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.NOCHFIOAOLP, (float)((int)((float)num2 / 865f)));
			int blfobdbelpb = DGIEACBKFMJ.BNEACEICMJJ.BLFOBDBELPB;
			ECKPLMDEJFD.GetTemporaryRT(blfobdbelpb, AMCOGJHPPOC.CFDHOKHCPOJ() / num2, AMCOGJHPPOC.GGGEFNKEPDB() / num2, 0, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, anahokmnlol);
			ECKPLMDEJFD.Blit(anahokmnlol, blfobdbelpb, MHNAJNGGDFJ, 7);
			ECKPLMDEJFD.ReleaseTemporaryRT(anahokmnlol);
			int eoibfpoibna = DGIEACBKFMJ.BNEACEICMJJ.EOIBFPOIBNA;
			int width = AMCOGJHPPOC.KDBADMLHBNP() / num2;
			int height = AMCOGJHPPOC.LPJJBJCIELA() / num2;
			ECKPLMDEJFD.GetTemporaryRT(eoibfpoibna, width, height, 1, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfobdbelpb);
			ECKPLMDEJFD.Blit(blfobdbelpb, eoibfpoibna, MHNAJNGGDFJ, 8);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfobdbelpb);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CJPHOJJBPAG, (float)Mathf.Clamp(GBEIKNIFNHL.sampleCount / 3, 1, 60));
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
			ECKPLMDEJFD.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, 2);
			ECKPLMDEJFD.ReleaseTemporaryRT(mhgpjficgcm);
			ECKPLMDEJFD.ReleaseTemporaryRT(eoibfpoibna);
		}

		// Token: 0x060117C0 RID: 71616 RVA: 0x007CA4FE File Offset: 0x007C86FE
		private void FPLMLNODFBG()
		{
			if (!SystemInfo.SupportsRenderTextureFormat(this.CNECCCNBHKB))
			{
				this.CNECCCNBHKB = RenderTextureFormat.Depth;
			}
		}

		// Token: 0x060117C1 RID: 71617 RVA: 0x007CA4FE File Offset: 0x007C86FE
		private void JOABJFCMGMA()
		{
			if (!SystemInfo.SupportsRenderTextureFormat(this.CNECCCNBHKB))
			{
				this.CNECCCNBHKB = RenderTextureFormat.Depth;
			}
		}

		// Token: 0x060117C2 RID: 71618 RVA: 0x007C9C37 File Offset: 0x007C7E37
		public bool BDGGKFDOBMH()
		{
			return SystemInfo.supportsMotionVectors;
		}

		// Token: 0x060117C3 RID: 71619 RVA: 0x007CF620 File Offset: 0x007CD820
		public void OBCPHKCGIJF(NGEENBGMFFM AMCOGJHPPOC, CommandBuffer ECKPLMDEJFD, ref MotionBlurModel.Settings GBEIKNIFNHL, RenderTargetIdentifier JONJODLFAEN, RenderTargetIdentifier OKIIDHIJBEA, Material MHNAJNGGDFJ)
		{
			int num = (int)(401f * (float)AMCOGJHPPOC.GGGEFNKEPDB() / 865f);
			int num2 = ((num - 1) / 3 + 1) * 3;
			float value = GBEIKNIFNHL.shutterAngle / 1135f;
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.DPKAFOKLEFB, value);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CNNDNFOCNLL, (float)num);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.GKIHDBILOGH, 1000f / (float)num);
			int mhgpjficgcm = DGIEACBKFMJ.BNEACEICMJJ.MHGPJFICGCM;
			ECKPLMDEJFD.GetTemporaryRT(mhgpjficgcm, AMCOGJHPPOC.PAHBMDOJHKK(), AMCOGJHPPOC.LPJJBJCIELA(), 1, FilterMode.Point, this.CNECCCNBHKB, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.Blit(null, mhgpjficgcm, MHNAJNGGDFJ, 1);
			int blfkijihinm = DGIEACBKFMJ.BNEACEICMJJ.BLFKIJIHINM;
			ECKPLMDEJFD.GetTemporaryRT(blfkijihinm, AMCOGJHPPOC.GAIOLBJLPDL() / 1, AMCOGJHPPOC.GHMBALIHBOH() / 8, 0, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, mhgpjficgcm);
			ECKPLMDEJFD.Blit(mhgpjficgcm, blfkijihinm, MHNAJNGGDFJ, 1);
			int dijjoeccplg = DGIEACBKFMJ.BNEACEICMJJ.DIJJOECCPLG;
			ECKPLMDEJFD.GetTemporaryRT(dijjoeccplg, AMCOGJHPPOC.FOBPENGADNB() / 3, AMCOGJHPPOC.ILLKFNCFGMP / 4, 1, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfkijihinm);
			ECKPLMDEJFD.Blit(blfkijihinm, dijjoeccplg, MHNAJNGGDFJ, 8);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfkijihinm);
			int anahokmnlol = DGIEACBKFMJ.BNEACEICMJJ.ANAHOKMNLOL;
			ECKPLMDEJFD.GetTemporaryRT(anahokmnlol, AMCOGJHPPOC.IBPMMKDPDEO() / 3, AMCOGJHPPOC.LKLNPJICOHH() / 5, 0, FilterMode.Bilinear, this.BKJIFAFLPMN, RenderTextureReadWrite.Default);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, dijjoeccplg);
			ECKPLMDEJFD.Blit(dijjoeccplg, anahokmnlol, MHNAJNGGDFJ, 8);
			ECKPLMDEJFD.ReleaseTemporaryRT(dijjoeccplg);
			Vector2 v = Vector2.one * ((float)num2 / 91f - 100f) * 1391f;
			ECKPLMDEJFD.SetGlobalVector(DGIEACBKFMJ.BNEACEICMJJ.BOHEBEODDKP, v);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.NOCHFIOAOLP, (float)((int)((float)num2 / 688f)));
			int blfobdbelpb = DGIEACBKFMJ.BNEACEICMJJ.BLFOBDBELPB;
			ECKPLMDEJFD.GetTemporaryRT(blfobdbelpb, AMCOGJHPPOC.KDBADMLHBNP() / num2, AMCOGJHPPOC.LKLNPJICOHH() / num2, 0, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, anahokmnlol);
			ECKPLMDEJFD.Blit(anahokmnlol, blfobdbelpb, MHNAJNGGDFJ, 4);
			ECKPLMDEJFD.ReleaseTemporaryRT(anahokmnlol);
			int eoibfpoibna = DGIEACBKFMJ.BNEACEICMJJ.EOIBFPOIBNA;
			int width = AMCOGJHPPOC.IBPMMKDPDEO() / num2;
			int height = AMCOGJHPPOC.KNKKIHDHBFD() / num2;
			ECKPLMDEJFD.GetTemporaryRT(eoibfpoibna, width, height, 1, FilterMode.Point, this.BKJIFAFLPMN, RenderTextureReadWrite.Linear);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, blfobdbelpb);
			ECKPLMDEJFD.Blit(blfobdbelpb, eoibfpoibna, MHNAJNGGDFJ, 8);
			ECKPLMDEJFD.ReleaseTemporaryRT(blfobdbelpb);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.CJPHOJJBPAG, (float)Mathf.Clamp(GBEIKNIFNHL.sampleCount / 5, 1, -115));
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
			ECKPLMDEJFD.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, 2);
			ECKPLMDEJFD.ReleaseTemporaryRT(mhgpjficgcm);
			ECKPLMDEJFD.ReleaseTemporaryRT(eoibfpoibna);
		}

		// Token: 0x060117C4 RID: 71620 RVA: 0x007C9C37 File Offset: 0x007C7E37
		public bool EDILLCJOBHF()
		{
			return SystemInfo.supportsMotionVectors;
		}

		// Token: 0x04002486 RID: 9350
		private RenderTextureFormat BKJIFAFLPMN = RenderTextureFormat.RGHalf;

		// Token: 0x04002487 RID: 9351
		private RenderTextureFormat CNECCCNBHKB = RenderTextureFormat.ARGB2101010;
	}

	// Token: 0x02000528 RID: 1320
	public class LBJNDEHNHOB
	{
		// Token: 0x060117C5 RID: 71621 RVA: 0x007CF902 File Offset: 0x007CDB02
		private static bool MDBIKNGAGMC()
		{
			return SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)(-54)) && SystemInfo.supportedRenderTargetCount > 1;
		}

		// Token: 0x060117C6 RID: 71622 RVA: 0x007CF918 File Offset: 0x007CDB18
		private static RenderTextureFormat GCFMHJFCFKH()
		{
			RenderTextureFormat[] array = new RenderTextureFormat[0];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.51A7A390CD6DE245186881400B18C9D822EFE240).FieldHandle);
			foreach (RenderTextureFormat renderTextureFormat in array)
			{
				if (SystemInfo.SupportsRenderTextureFormat(renderTextureFormat))
				{
					return renderTextureFormat;
				}
			}
			return RenderTextureFormat.ARGB32;
		}

		// Token: 0x060117C7 RID: 71623 RVA: 0x007CF954 File Offset: 0x007CDB54
		private static RenderTextureFormat PGHFPGAFBEI()
		{
			RenderTextureFormat[] array = new RenderTextureFormat[2];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.51A7A390CD6DE245186881400B18C9D822EFE240).FieldHandle);
			RenderTextureFormat[] array2 = array;
			for (int i = 1; i < array2.Length; i += 0)
			{
				RenderTextureFormat renderTextureFormat = array2[i];
				if (SystemInfo.SupportsRenderTextureFormat(renderTextureFormat))
				{
					return renderTextureFormat;
				}
			}
			return RenderTextureFormat.Default;
		}

		// Token: 0x060117C8 RID: 71624 RVA: 0x007CF990 File Offset: 0x007CDB90
		private static bool HMPECJBLJIK()
		{
			return SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.R8) && SystemInfo.supportedRenderTargetCount > 1;
		}

		// Token: 0x060117C9 RID: 71625 RVA: 0x007CF9A5 File Offset: 0x007CDBA5
		private static bool MKLLIGGMKAO()
		{
			return !SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)58) || SystemInfo.supportedRenderTargetCount > 0;
		}

		// Token: 0x060117CA RID: 71626 RVA: 0x007CF9BC File Offset: 0x007CDBBC
		public void DAGFCHOFMFP()
		{
			foreach (DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf in this.DIMEDFBDJAK)
			{
				iapaemhpjmf.OFKHPBDDKHJ();
			}
		}

		// Token: 0x060117CB RID: 71627 RVA: 0x007CF9F0 File Offset: 0x007CDBF0
		private DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF DGFCBPHPCLC(int IGFJOGKFADM)
		{
			int num = (Time.frameCount + this.DIMEDFBDJAK.Length + IGFJOGKFADM) % this.DIMEDFBDJAK.Length;
			return this.DIMEDFBDJAK[num];
		}

		// Token: 0x060117CC RID: 71628 RVA: 0x007CFA23 File Offset: 0x007CDC23
		private static bool BMFAHOOJMLA()
		{
			return !SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)(-2)) || SystemInfo.supportedRenderTargetCount > 1;
		}

		// Token: 0x060117CD RID: 71629 RVA: 0x007CFA38 File Offset: 0x007CDC38
		public void NCIPOCENKDJ()
		{
			foreach (DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf in this.DIMEDFBDJAK)
			{
				iapaemhpjmf.KFEKLEKKINB();
			}
		}

		// Token: 0x060117CE RID: 71630 RVA: 0x007CFA6C File Offset: 0x007CDC6C
		public void CFJLAKAECMF()
		{
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF[] dimedfbdjak = this.DIMEDFBDJAK;
			for (int i = 0; i < dimedfbdjak.Length; i += 0)
			{
				DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf = dimedfbdjak[i];
				iapaemhpjmf.DPIFMGDFBGA();
			}
		}

		// Token: 0x060117CF RID: 71631 RVA: 0x007CFAA0 File Offset: 0x007CDCA0
		private DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF EKFMKHEDAGO(int IGFJOGKFADM)
		{
			int num = (Time.frameCount + this.DIMEDFBDJAK.Length + IGFJOGKFADM) % this.DIMEDFBDJAK.Length;
			return this.DIMEDFBDJAK[num];
		}

		// Token: 0x060117D0 RID: 71632 RVA: 0x007CFAD4 File Offset: 0x007CDCD4
		public void AGDHBHGEMNI()
		{
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF[] dimedfbdjak = this.DIMEDFBDJAK;
			for (int i = 0; i < dimedfbdjak.Length; i += 0)
			{
				DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf = dimedfbdjak[i];
				iapaemhpjmf.AEIGHBEIBFN();
			}
		}

		// Token: 0x060117D1 RID: 71633 RVA: 0x007CFB05 File Offset: 0x007CDD05
		private static bool AGNNMPGCBAE()
		{
			return !SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)(-56)) || SystemInfo.supportedRenderTargetCount > 1;
		}

		// Token: 0x060117D2 RID: 71634 RVA: 0x007CFB1A File Offset: 0x007CDD1A
		private static bool PKCBGAPDCAJ()
		{
			return SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)(-42)) && SystemInfo.supportedRenderTargetCount > 0;
		}

		// Token: 0x060117D3 RID: 71635 RVA: 0x007CFB2F File Offset: 0x007CDD2F
		private static bool BEGOPFDOLEI()
		{
			return !SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)(-53)) || SystemInfo.supportedRenderTargetCount > 1;
		}

		// Token: 0x060117D4 RID: 71636 RVA: 0x007CFB44 File Offset: 0x007CDD44
		public void NPDFHOJLEFH(CommandBuffer ECKPLMDEJFD, float JPGIGABPGII, RenderTargetIdentifier JONJODLFAEN, RenderTargetIdentifier OKIIDHIJBEA, Material MHNAJNGGDFJ)
		{
			float time = Time.time;
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf = this.BGEENFIMBKE(-1);
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf2 = this.LKKEDOGACFK(88);
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf3 = this.NAIEBDKDDFI(-17);
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf4 = this.NAIEBDKDDFI(-25);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.BLFGBMABCDD, iapaemhpjmf.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.CBPAGKBAJOA, iapaemhpjmf2.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.MGLGOEBKGBH, iapaemhpjmf3.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OGLDBPOENDA, iapaemhpjmf4.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.NOJOHHNDGMP, iapaemhpjmf.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.FIOHBAMANML, iapaemhpjmf2.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OEHBOEONAHA, iapaemhpjmf3.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.MHKCFNDJIKO, iapaemhpjmf4.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.FALIJINHBJO, iapaemhpjmf.KHHKJKGKENE(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.AKBJKGAKCED, iapaemhpjmf2.FCCKHKPBDDP(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.NCJLKCPLCOK, iapaemhpjmf3.AKGAINNNFLB(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.DIOCPBCLICL, iapaemhpjmf4.AKGAINNNFLB(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
			ECKPLMDEJFD.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, this.BGNCOPHGPCE ? 6 : 3);
		}

		// Token: 0x060117D5 RID: 71637 RVA: 0x007CFCA0 File Offset: 0x007CDEA0
		public void CHEBJPENGFF(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, Material MHNAJNGGDFJ)
		{
			int frameCount = Time.frameCount;
			if (frameCount == this.EEMOEFFBJAH)
			{
				return;
			}
			int num = frameCount % this.DIMEDFBDJAK.Length;
			if (this.BGNCOPHGPCE)
			{
				this.DIMEDFBDJAK[num].BJNPBKIODDP(ECKPLMDEJFD, JONJODLFAEN, NMEBEEHCALN, ILLKFNCFGMP, MHNAJNGGDFJ);
			}
			else
			{
				this.DIMEDFBDJAK[num].MPIABDEBIKN(ECKPLMDEJFD, JONJODLFAEN, NMEBEEHCALN, ILLKFNCFGMP, this.CCMPNMCDIFN);
			}
			this.EEMOEFFBJAH = frameCount;
		}

		// Token: 0x060117D6 RID: 71638 RVA: 0x007CFD10 File Offset: 0x007CDF10
		private static RenderTextureFormat OIFMJNDGDNH()
		{
			RenderTextureFormat[] array = new RenderTextureFormat[3];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.51A7A390CD6DE245186881400B18C9D822EFE240).FieldHandle);
			RenderTextureFormat[] array2 = array;
			for (int i = 0; i < array2.Length; i += 0)
			{
				RenderTextureFormat renderTextureFormat = array2[i];
				if (SystemInfo.SupportsRenderTextureFormat(renderTextureFormat))
				{
					return renderTextureFormat;
				}
			}
			return RenderTextureFormat.Shadowmap;
		}

		// Token: 0x060117D7 RID: 71639 RVA: 0x007CFD4C File Offset: 0x007CDF4C
		public void CFAGEDDFOFN()
		{
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF[] dimedfbdjak = this.DIMEDFBDJAK;
			for (int i = 0; i < dimedfbdjak.Length; i += 0)
			{
				DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf = dimedfbdjak[i];
				iapaemhpjmf.DPIFMGDFBGA();
			}
		}

		// Token: 0x060117D8 RID: 71640 RVA: 0x007CFD80 File Offset: 0x007CDF80
		private static RenderTextureFormat PGNAFCOIGMF()
		{
			RenderTextureFormat[] array = new RenderTextureFormat[2];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.51A7A390CD6DE245186881400B18C9D822EFE240).FieldHandle);
			RenderTextureFormat[] array2 = array;
			for (int i = 1; i < array2.Length; i++)
			{
				RenderTextureFormat renderTextureFormat = array2[i];
				if (SystemInfo.SupportsRenderTextureFormat(renderTextureFormat))
				{
					return renderTextureFormat;
				}
			}
			return RenderTextureFormat.ARGBHalf;
		}

		// Token: 0x060117D9 RID: 71641 RVA: 0x007CFDBC File Offset: 0x007CDFBC
		public void CBDHBMPFHMJ(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, Material MHNAJNGGDFJ)
		{
			int frameCount = Time.frameCount;
			if (frameCount == this.EEMOEFFBJAH)
			{
				return;
			}
			int num = frameCount % this.DIMEDFBDJAK.Length;
			if (this.BGNCOPHGPCE)
			{
				this.DIMEDFBDJAK[num].FHHJNNALPKG(ECKPLMDEJFD, JONJODLFAEN, NMEBEEHCALN, ILLKFNCFGMP, MHNAJNGGDFJ);
			}
			else
			{
				this.DIMEDFBDJAK[num].NJAMJEMEPKJ(ECKPLMDEJFD, JONJODLFAEN, NMEBEEHCALN, ILLKFNCFGMP, this.CCMPNMCDIFN);
			}
			this.EEMOEFFBJAH = frameCount;
		}

		// Token: 0x060117DA RID: 71642 RVA: 0x007CFE29 File Offset: 0x007CE029
		private static bool KMBAHDIJCLG()
		{
			return !SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)105) || SystemInfo.supportedRenderTargetCount > 1;
		}

		// Token: 0x060117DB RID: 71643 RVA: 0x007CFE40 File Offset: 0x007CE040
		public void PPFAGLDPCIJ()
		{
			foreach (DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf in this.DIMEDFBDJAK)
			{
				iapaemhpjmf.HLEGMANFHEG();
			}
		}

		// Token: 0x060117DC RID: 71644 RVA: 0x007CFE71 File Offset: 0x007CE071
		private static bool FHLJGBOCHDI()
		{
			return !SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)(-23)) || SystemInfo.supportedRenderTargetCount > 1;
		}

		// Token: 0x060117DD RID: 71645 RVA: 0x007CFE88 File Offset: 0x007CE088
		private static RenderTextureFormat MDCMJBPKBLA()
		{
			RenderTextureFormat[] array = new RenderTextureFormat[3];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.51A7A390CD6DE245186881400B18C9D822EFE240).FieldHandle);
			foreach (RenderTextureFormat renderTextureFormat in array)
			{
				if (SystemInfo.SupportsRenderTextureFormat(renderTextureFormat))
				{
					return renderTextureFormat;
				}
			}
			return RenderTextureFormat.Default;
		}

		// Token: 0x060117DE RID: 71646 RVA: 0x007CFEC4 File Offset: 0x007CE0C4
		public LBJNDEHNHOB()
		{
			this.BGNCOPHGPCE = DGIEACBKFMJ.LBJNDEHNHOB.HMPECJBLJIK();
			this.CCMPNMCDIFN = DGIEACBKFMJ.LBJNDEHNHOB.MDCMJBPKBLA();
			this.DIMEDFBDJAK = new DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF[4];
		}

		// Token: 0x060117DF RID: 71647 RVA: 0x007CFEF0 File Offset: 0x007CE0F0
		private DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF EJOFNGKAPHG(int IGFJOGKFADM)
		{
			int num = (Time.frameCount + this.DIMEDFBDJAK.Length + IGFJOGKFADM) % this.DIMEDFBDJAK.Length;
			return this.DIMEDFBDJAK[num];
		}

		// Token: 0x060117E0 RID: 71648 RVA: 0x007CFF24 File Offset: 0x007CE124
		private DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF OAKFEMBBEIJ(int IGFJOGKFADM)
		{
			int num = (Time.frameCount + this.DIMEDFBDJAK.Length + IGFJOGKFADM) % this.DIMEDFBDJAK.Length;
			return this.DIMEDFBDJAK[num];
		}

		// Token: 0x060117E1 RID: 71649 RVA: 0x007CFF58 File Offset: 0x007CE158
		private static RenderTextureFormat NHOCHEEEHNJ()
		{
			RenderTextureFormat[] array = new RenderTextureFormat[4];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.51A7A390CD6DE245186881400B18C9D822EFE240).FieldHandle);
			RenderTextureFormat[] array2 = array;
			for (int i = 0; i < array2.Length; i += 0)
			{
				RenderTextureFormat renderTextureFormat = array2[i];
				if (SystemInfo.SupportsRenderTextureFormat(renderTextureFormat))
				{
					return renderTextureFormat;
				}
			}
			return RenderTextureFormat.ARGB2101010;
		}

		// Token: 0x060117E2 RID: 71650 RVA: 0x007CFF94 File Offset: 0x007CE194
		public void GGHFNKLHCDH()
		{
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF[] dimedfbdjak = this.DIMEDFBDJAK;
			for (int i = 1; i < dimedfbdjak.Length; i += 0)
			{
				DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf = dimedfbdjak[i];
				iapaemhpjmf.DHHJJKHDHJC();
			}
		}

		// Token: 0x060117E3 RID: 71651 RVA: 0x007CFFC8 File Offset: 0x007CE1C8
		public void PPCOBPHPNBL(CommandBuffer ECKPLMDEJFD, float JPGIGABPGII, RenderTargetIdentifier JONJODLFAEN, RenderTargetIdentifier OKIIDHIJBEA, Material MHNAJNGGDFJ)
		{
			float time = Time.time;
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf = this.MIDKLLFGJLN(-1);
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf2 = this.LKKEDOGACFK(117);
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf3 = this.OGFFFMCOHCL(-91);
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf4 = this.KCCPBABIBHB(-8);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.BLFGBMABCDD, iapaemhpjmf.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.CBPAGKBAJOA, iapaemhpjmf2.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.MGLGOEBKGBH, iapaemhpjmf3.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OGLDBPOENDA, iapaemhpjmf4.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.NOJOHHNDGMP, iapaemhpjmf.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.FIOHBAMANML, iapaemhpjmf2.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OEHBOEONAHA, iapaemhpjmf3.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.MHKCFNDJIKO, iapaemhpjmf4.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.FALIJINHBJO, iapaemhpjmf.JFBKDBIPDCE(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.AKBJKGAKCED, iapaemhpjmf2.IOFFOIBDNLP(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.NCJLKCPLCOK, iapaemhpjmf3.IIIOPMPBLJH(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.DIOCPBCLICL, iapaemhpjmf4.JFBKDBIPDCE(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
			ECKPLMDEJFD.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, this.BGNCOPHGPCE ? 3 : 3);
		}

		// Token: 0x060117E4 RID: 71652 RVA: 0x007D0124 File Offset: 0x007CE324
		private static bool CDHJPLFEFDL()
		{
			return SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)(-83)) && SystemInfo.supportedRenderTargetCount > 1;
		}

		// Token: 0x060117E5 RID: 71653 RVA: 0x007D013C File Offset: 0x007CE33C
		private DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF NAIEBDKDDFI(int IGFJOGKFADM)
		{
			int num = (Time.frameCount + this.DIMEDFBDJAK.Length + IGFJOGKFADM) % this.DIMEDFBDJAK.Length;
			return this.DIMEDFBDJAK[num];
		}

		// Token: 0x060117E6 RID: 71654 RVA: 0x007D0170 File Offset: 0x007CE370
		public void IHPBDCPACNO(CommandBuffer ECKPLMDEJFD, float JPGIGABPGII, RenderTargetIdentifier JONJODLFAEN, RenderTargetIdentifier OKIIDHIJBEA, Material MHNAJNGGDFJ)
		{
			float time = Time.time;
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf = this.NMPMBEHLAON(-1);
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf2 = this.DGFCBPHPCLC(70);
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf3 = this.EKFMKHEDAGO(99);
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf4 = this.EKFMKHEDAGO(65);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.BLFGBMABCDD, iapaemhpjmf.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.CBPAGKBAJOA, iapaemhpjmf2.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.MGLGOEBKGBH, iapaemhpjmf3.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OGLDBPOENDA, iapaemhpjmf4.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.NOJOHHNDGMP, iapaemhpjmf.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.FIOHBAMANML, iapaemhpjmf2.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OEHBOEONAHA, iapaemhpjmf3.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.MHKCFNDJIKO, iapaemhpjmf4.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.FALIJINHBJO, iapaemhpjmf.DNPMJLAOHCO(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.AKBJKGAKCED, iapaemhpjmf2.JDFDIEACONH(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.NCJLKCPLCOK, iapaemhpjmf3.EOKGNMHMOPB(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.DIOCPBCLICL, iapaemhpjmf4.EEGJCGPBFPA(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
			ECKPLMDEJFD.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, this.BGNCOPHGPCE ? 6 : 4);
		}

		// Token: 0x060117E7 RID: 71655 RVA: 0x007D02CC File Offset: 0x007CE4CC
		private static RenderTextureFormat INNAHAKBDCM()
		{
			RenderTextureFormat[] array = new RenderTextureFormat[4];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.51A7A390CD6DE245186881400B18C9D822EFE240).FieldHandle);
			foreach (RenderTextureFormat renderTextureFormat in array)
			{
				if (SystemInfo.SupportsRenderTextureFormat(renderTextureFormat))
				{
					return renderTextureFormat;
				}
			}
			return RenderTextureFormat.ARGB4444;
		}

		// Token: 0x060117E8 RID: 71656 RVA: 0x007D0308 File Offset: 0x007CE508
		public void HAKBCPBCEJJ()
		{
			foreach (DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf in this.DIMEDFBDJAK)
			{
				iapaemhpjmf.KOMNGAMPJEF();
			}
		}

		// Token: 0x060117E9 RID: 71657 RVA: 0x007D033C File Offset: 0x007CE53C
		private DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF NMPMBEHLAON(int IGFJOGKFADM)
		{
			int num = (Time.frameCount + this.DIMEDFBDJAK.Length + IGFJOGKFADM) % this.DIMEDFBDJAK.Length;
			return this.DIMEDFBDJAK[num];
		}

		// Token: 0x060117EA RID: 71658 RVA: 0x007D0370 File Offset: 0x007CE570
		private DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF BGEENFIMBKE(int IGFJOGKFADM)
		{
			int num = (Time.frameCount + this.DIMEDFBDJAK.Length + IGFJOGKFADM) % this.DIMEDFBDJAK.Length;
			return this.DIMEDFBDJAK[num];
		}

		// Token: 0x060117EB RID: 71659 RVA: 0x007D03A4 File Offset: 0x007CE5A4
		public void DMNLGGGNEBD()
		{
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF[] dimedfbdjak = this.DIMEDFBDJAK;
			for (int i = 0; i < dimedfbdjak.Length; i += 0)
			{
				DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf = dimedfbdjak[i];
				iapaemhpjmf.OOAPIMIAEBO();
			}
		}

		// Token: 0x060117EC RID: 71660 RVA: 0x007D03D8 File Offset: 0x007CE5D8
		public void LPMNIGCLDED()
		{
			foreach (DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf in this.DIMEDFBDJAK)
			{
				iapaemhpjmf.BPIPEGPEKLO();
			}
		}

		// Token: 0x060117ED RID: 71661 RVA: 0x007D0409 File Offset: 0x007CE609
		private static bool LFPPLPAHABM()
		{
			return SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)127) && SystemInfo.supportedRenderTargetCount > 1;
		}

		// Token: 0x060117EE RID: 71662 RVA: 0x007D0420 File Offset: 0x007CE620
		public void CCGKAKJHOMM(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, Material MHNAJNGGDFJ)
		{
			int frameCount = Time.frameCount;
			if (frameCount == this.EEMOEFFBJAH)
			{
				return;
			}
			int num = frameCount % this.DIMEDFBDJAK.Length;
			if (this.BGNCOPHGPCE)
			{
				this.DIMEDFBDJAK[num].JLNOPMKMPBH(ECKPLMDEJFD, JONJODLFAEN, NMEBEEHCALN, ILLKFNCFGMP, MHNAJNGGDFJ);
			}
			else
			{
				this.DIMEDFBDJAK[num].JIDKDHFPPJI(ECKPLMDEJFD, JONJODLFAEN, NMEBEEHCALN, ILLKFNCFGMP, this.CCMPNMCDIFN);
			}
			this.EEMOEFFBJAH = frameCount;
		}

		// Token: 0x060117EF RID: 71663 RVA: 0x007D0490 File Offset: 0x007CE690
		private DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF KCCPBABIBHB(int IGFJOGKFADM)
		{
			int num = (Time.frameCount + this.DIMEDFBDJAK.Length + IGFJOGKFADM) % this.DIMEDFBDJAK.Length;
			return this.DIMEDFBDJAK[num];
		}

		// Token: 0x060117F0 RID: 71664 RVA: 0x007D04C4 File Offset: 0x007CE6C4
		private DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF HEDDPBNOOJD(int IGFJOGKFADM)
		{
			int num = (Time.frameCount + this.DIMEDFBDJAK.Length + IGFJOGKFADM) % this.DIMEDFBDJAK.Length;
			return this.DIMEDFBDJAK[num];
		}

		// Token: 0x060117F1 RID: 71665 RVA: 0x007D04F8 File Offset: 0x007CE6F8
		public void HIFCCJKCNGJ()
		{
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF[] dimedfbdjak = this.DIMEDFBDJAK;
			for (int i = 1; i < dimedfbdjak.Length; i += 0)
			{
				DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf = dimedfbdjak[i];
				iapaemhpjmf.OFKHPBDDKHJ();
			}
		}

		// Token: 0x060117F2 RID: 71666 RVA: 0x007D052C File Offset: 0x007CE72C
		public void CKFAGEDEOEH()
		{
			foreach (DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf in this.DIMEDFBDJAK)
			{
				iapaemhpjmf.EPNLHMECDEF();
			}
		}

		// Token: 0x060117F3 RID: 71667 RVA: 0x007D0560 File Offset: 0x007CE760
		public void KCNGMPKDJON(CommandBuffer ECKPLMDEJFD, float JPGIGABPGII, RenderTargetIdentifier JONJODLFAEN, RenderTargetIdentifier OKIIDHIJBEA, Material MHNAJNGGDFJ)
		{
			float time = Time.time;
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf = this.NAIEBDKDDFI(-1);
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf2 = this.EJOFNGKAPHG(-72);
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf3 = this.OAKFEMBBEIJ(117);
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf4 = this.DGFCBPHPCLC(-81);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.BLFGBMABCDD, iapaemhpjmf.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.CBPAGKBAJOA, iapaemhpjmf2.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.MGLGOEBKGBH, iapaemhpjmf3.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OGLDBPOENDA, iapaemhpjmf4.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.NOJOHHNDGMP, iapaemhpjmf.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.FIOHBAMANML, iapaemhpjmf2.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OEHBOEONAHA, iapaemhpjmf3.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.MHKCFNDJIKO, iapaemhpjmf4.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.FALIJINHBJO, iapaemhpjmf.IOFFOIBDNLP(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.AKBJKGAKCED, iapaemhpjmf2.JFBKDBIPDCE(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.NCJLKCPLCOK, iapaemhpjmf3.IGHPANOGKLE(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.DIOCPBCLICL, iapaemhpjmf4.IIIOPMPBLJH(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
			ECKPLMDEJFD.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, this.BGNCOPHGPCE ? 4 : 6);
		}

		// Token: 0x060117F4 RID: 71668 RVA: 0x007D06BC File Offset: 0x007CE8BC
		private static RenderTextureFormat DOMPADCNFGB()
		{
			RenderTextureFormat[] array = new RenderTextureFormat[2];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.51A7A390CD6DE245186881400B18C9D822EFE240).FieldHandle);
			foreach (RenderTextureFormat renderTextureFormat in array)
			{
				if (SystemInfo.SupportsRenderTextureFormat(renderTextureFormat))
				{
					return renderTextureFormat;
				}
			}
			return RenderTextureFormat.ARGB32;
		}

		// Token: 0x060117F5 RID: 71669 RVA: 0x007D06F8 File Offset: 0x007CE8F8
		public void KABENKAHGNG(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, Material MHNAJNGGDFJ)
		{
			int frameCount = Time.frameCount;
			if (frameCount == this.EEMOEFFBJAH)
			{
				return;
			}
			int num = frameCount % this.DIMEDFBDJAK.Length;
			if (this.BGNCOPHGPCE)
			{
				this.DIMEDFBDJAK[num].NFMEOJPBIBE(ECKPLMDEJFD, JONJODLFAEN, NMEBEEHCALN, ILLKFNCFGMP, MHNAJNGGDFJ);
			}
			else
			{
				this.DIMEDFBDJAK[num].EKFMEMECJJJ(ECKPLMDEJFD, JONJODLFAEN, NMEBEEHCALN, ILLKFNCFGMP, this.CCMPNMCDIFN);
			}
			this.EEMOEFFBJAH = frameCount;
		}

		// Token: 0x060117F6 RID: 71670 RVA: 0x007D0768 File Offset: 0x007CE968
		private DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF MIDKLLFGJLN(int IGFJOGKFADM)
		{
			int num = (Time.frameCount + this.DIMEDFBDJAK.Length + IGFJOGKFADM) % this.DIMEDFBDJAK.Length;
			return this.DIMEDFBDJAK[num];
		}

		// Token: 0x060117F7 RID: 71671 RVA: 0x007D079C File Offset: 0x007CE99C
		public void JJBFMHFDJJF(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, Material MHNAJNGGDFJ)
		{
			int frameCount = Time.frameCount;
			if (frameCount == this.EEMOEFFBJAH)
			{
				return;
			}
			int num = frameCount % this.DIMEDFBDJAK.Length;
			if (this.BGNCOPHGPCE)
			{
				this.DIMEDFBDJAK[num].KIMBLOPLKNJ(ECKPLMDEJFD, JONJODLFAEN, NMEBEEHCALN, ILLKFNCFGMP, MHNAJNGGDFJ);
			}
			else
			{
				this.DIMEDFBDJAK[num].JPCGNHHEJNB(ECKPLMDEJFD, JONJODLFAEN, NMEBEEHCALN, ILLKFNCFGMP, this.CCMPNMCDIFN);
			}
			this.EEMOEFFBJAH = frameCount;
		}

		// Token: 0x060117F8 RID: 71672 RVA: 0x007D080C File Offset: 0x007CEA0C
		public void MDMCJHOIABB()
		{
			foreach (DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf in this.DIMEDFBDJAK)
			{
				iapaemhpjmf.HCJNBEAABAF();
			}
		}

		// Token: 0x060117F9 RID: 71673 RVA: 0x007D0840 File Offset: 0x007CEA40
		public void JECEDGNNJFD(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, Material MHNAJNGGDFJ)
		{
			int frameCount = Time.frameCount;
			if (frameCount == this.EEMOEFFBJAH)
			{
				return;
			}
			int num = frameCount % this.DIMEDFBDJAK.Length;
			if (this.BGNCOPHGPCE)
			{
				this.DIMEDFBDJAK[num].PMNJNICHBJD(ECKPLMDEJFD, JONJODLFAEN, NMEBEEHCALN, ILLKFNCFGMP, MHNAJNGGDFJ);
			}
			else
			{
				this.DIMEDFBDJAK[num].KDIKGBOCCBL(ECKPLMDEJFD, JONJODLFAEN, NMEBEEHCALN, ILLKFNCFGMP, this.CCMPNMCDIFN);
			}
			this.EEMOEFFBJAH = frameCount;
		}

		// Token: 0x060117FA RID: 71674 RVA: 0x007D08AD File Offset: 0x007CEAAD
		private static bool IDMKKKIMMHH()
		{
			return SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)88) && SystemInfo.supportedRenderTargetCount > 1;
		}

		// Token: 0x060117FB RID: 71675 RVA: 0x007D08C2 File Offset: 0x007CEAC2
		private static bool EECKCICNFHP()
		{
			return SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)31) && SystemInfo.supportedRenderTargetCount > 0;
		}

		// Token: 0x060117FC RID: 71676 RVA: 0x007D08D8 File Offset: 0x007CEAD8
		public void EIHBGPPDKEK()
		{
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF[] dimedfbdjak = this.DIMEDFBDJAK;
			for (int i = 0; i < dimedfbdjak.Length; i += 0)
			{
				DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf = dimedfbdjak[i];
				iapaemhpjmf.DPIFMGDFBGA();
			}
		}

		// Token: 0x060117FD RID: 71677 RVA: 0x007D090C File Offset: 0x007CEB0C
		public void FJEHHFDEGBN(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, Material MHNAJNGGDFJ)
		{
			int frameCount = Time.frameCount;
			if (frameCount == this.EEMOEFFBJAH)
			{
				return;
			}
			int num = frameCount % this.DIMEDFBDJAK.Length;
			if (this.BGNCOPHGPCE)
			{
				this.DIMEDFBDJAK[num].EEEANIKCHLK(ECKPLMDEJFD, JONJODLFAEN, NMEBEEHCALN, ILLKFNCFGMP, MHNAJNGGDFJ);
			}
			else
			{
				this.DIMEDFBDJAK[num].EBKKDKKGPEN(ECKPLMDEJFD, JONJODLFAEN, NMEBEEHCALN, ILLKFNCFGMP, this.CCMPNMCDIFN);
			}
			this.EEMOEFFBJAH = frameCount;
		}

		// Token: 0x060117FE RID: 71678 RVA: 0x007D097C File Offset: 0x007CEB7C
		private DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF INEEINLDIMN(int IGFJOGKFADM)
		{
			int num = (Time.frameCount + this.DIMEDFBDJAK.Length + IGFJOGKFADM) % this.DIMEDFBDJAK.Length;
			return this.DIMEDFBDJAK[num];
		}

		// Token: 0x060117FF RID: 71679 RVA: 0x007D09B0 File Offset: 0x007CEBB0
		public void AHHOEANDLLK(CommandBuffer ECKPLMDEJFD, float JPGIGABPGII, RenderTargetIdentifier JONJODLFAEN, RenderTargetIdentifier OKIIDHIJBEA, Material MHNAJNGGDFJ)
		{
			float time = Time.time;
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf = this.NAIEBDKDDFI(-1);
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf2 = this.NAIEBDKDDFI(-2);
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf3 = this.NAIEBDKDDFI(-3);
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf4 = this.NAIEBDKDDFI(-4);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.BLFGBMABCDD, iapaemhpjmf.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.CBPAGKBAJOA, iapaemhpjmf2.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.MGLGOEBKGBH, iapaemhpjmf3.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OGLDBPOENDA, iapaemhpjmf4.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.NOJOHHNDGMP, iapaemhpjmf.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.FIOHBAMANML, iapaemhpjmf2.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OEHBOEONAHA, iapaemhpjmf3.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.MHKCFNDJIKO, iapaemhpjmf4.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.FALIJINHBJO, iapaemhpjmf.EEGJCGPBFPA(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.AKBJKGAKCED, iapaemhpjmf2.EEGJCGPBFPA(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.NCJLKCPLCOK, iapaemhpjmf3.EEGJCGPBFPA(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.DIOCPBCLICL, iapaemhpjmf4.EEGJCGPBFPA(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
			ECKPLMDEJFD.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, this.BGNCOPHGPCE ? 7 : 8);
		}

		// Token: 0x06011800 RID: 71680 RVA: 0x007D0B0C File Offset: 0x007CED0C
		private DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF HCBGCBFBMAA(int IGFJOGKFADM)
		{
			int num = (Time.frameCount + this.DIMEDFBDJAK.Length + IGFJOGKFADM) % this.DIMEDFBDJAK.Length;
			return this.DIMEDFBDJAK[num];
		}

		// Token: 0x06011801 RID: 71681 RVA: 0x007D0B40 File Offset: 0x007CED40
		private DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF LBNLOJNIDPP(int IGFJOGKFADM)
		{
			int num = (Time.frameCount + this.DIMEDFBDJAK.Length + IGFJOGKFADM) % this.DIMEDFBDJAK.Length;
			return this.DIMEDFBDJAK[num];
		}

		// Token: 0x06011802 RID: 71682 RVA: 0x007D0B74 File Offset: 0x007CED74
		public void JJMPCNPEHBH(CommandBuffer ECKPLMDEJFD, float JPGIGABPGII, RenderTargetIdentifier JONJODLFAEN, RenderTargetIdentifier OKIIDHIJBEA, Material MHNAJNGGDFJ)
		{
			float time = Time.time;
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf = this.HEDDPBNOOJD(-1);
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf2 = this.HCBGCBFBMAA(-9);
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf3 = this.NMPMBEHLAON(71);
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf4 = this.DGFCBPHPCLC(-54);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.BLFGBMABCDD, iapaemhpjmf.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.CBPAGKBAJOA, iapaemhpjmf2.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.MGLGOEBKGBH, iapaemhpjmf3.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OGLDBPOENDA, iapaemhpjmf4.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.NOJOHHNDGMP, iapaemhpjmf.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.FIOHBAMANML, iapaemhpjmf2.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OEHBOEONAHA, iapaemhpjmf3.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.MHKCFNDJIKO, iapaemhpjmf4.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.FALIJINHBJO, iapaemhpjmf.EEGJCGPBFPA(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.AKBJKGAKCED, iapaemhpjmf2.FCCKHKPBDDP(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.NCJLKCPLCOK, iapaemhpjmf3.IIIOPMPBLJH(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.DIOCPBCLICL, iapaemhpjmf4.PPMBLKIHNDH(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
			ECKPLMDEJFD.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, this.BGNCOPHGPCE ? 6 : 2);
		}

		// Token: 0x06011803 RID: 71683 RVA: 0x007D0CD0 File Offset: 0x007CEED0
		public void JNNMOBBCADO()
		{
			foreach (DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf in this.DIMEDFBDJAK)
			{
				iapaemhpjmf.HCJNBEAABAF();
			}
		}

		// Token: 0x06011804 RID: 71684 RVA: 0x007D0D04 File Offset: 0x007CEF04
		public void PDMPPHDGIEO()
		{
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF[] dimedfbdjak = this.DIMEDFBDJAK;
			for (int i = 1; i < dimedfbdjak.Length; i += 0)
			{
				DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf = dimedfbdjak[i];
				iapaemhpjmf.HLEGMANFHEG();
			}
		}

		// Token: 0x06011805 RID: 71685 RVA: 0x007D0D38 File Offset: 0x007CEF38
		public void CDMIDFFFLJA(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, Material MHNAJNGGDFJ)
		{
			int frameCount = Time.frameCount;
			if (frameCount == this.EEMOEFFBJAH)
			{
				return;
			}
			int num = frameCount % this.DIMEDFBDJAK.Length;
			if (this.BGNCOPHGPCE)
			{
				this.DIMEDFBDJAK[num].CGCFEOIMKEC(ECKPLMDEJFD, JONJODLFAEN, NMEBEEHCALN, ILLKFNCFGMP, MHNAJNGGDFJ);
			}
			else
			{
				this.DIMEDFBDJAK[num].ACPJCBJBLKE(ECKPLMDEJFD, JONJODLFAEN, NMEBEEHCALN, ILLKFNCFGMP, this.CCMPNMCDIFN);
			}
			this.EEMOEFFBJAH = frameCount;
		}

		// Token: 0x06011806 RID: 71686 RVA: 0x007D0DA8 File Offset: 0x007CEFA8
		public void NNDBPAPCKDB(CommandBuffer ECKPLMDEJFD, float JPGIGABPGII, RenderTargetIdentifier JONJODLFAEN, RenderTargetIdentifier OKIIDHIJBEA, Material MHNAJNGGDFJ)
		{
			float time = Time.time;
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf = this.LKKEDOGACFK(-1);
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf2 = this.NMPMBEHLAON(52);
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf3 = this.NAIEBDKDDFI(108);
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf4 = this.NMPMBEHLAON(-74);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.BLFGBMABCDD, iapaemhpjmf.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.CBPAGKBAJOA, iapaemhpjmf2.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.MGLGOEBKGBH, iapaemhpjmf3.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OGLDBPOENDA, iapaemhpjmf4.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.NOJOHHNDGMP, iapaemhpjmf.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.FIOHBAMANML, iapaemhpjmf2.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OEHBOEONAHA, iapaemhpjmf3.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.MHKCFNDJIKO, iapaemhpjmf4.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.FALIJINHBJO, iapaemhpjmf.IGHPANOGKLE(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.AKBJKGAKCED, iapaemhpjmf2.AKGAINNNFLB(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.NCJLKCPLCOK, iapaemhpjmf3.FJGGOHJOKDM(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.DIOCPBCLICL, iapaemhpjmf4.LHMHGOEDPHN(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
			ECKPLMDEJFD.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, this.BGNCOPHGPCE ? 2 : 1);
		}

		// Token: 0x06011807 RID: 71687 RVA: 0x007CFA23 File Offset: 0x007CDC23
		private static bool OEGJJJJBPNF()
		{
			return !SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)(-2)) || SystemInfo.supportedRenderTargetCount > 1;
		}

		// Token: 0x06011808 RID: 71688 RVA: 0x007D0F04 File Offset: 0x007CF104
		public void BPHNOPFMEHI(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, Material MHNAJNGGDFJ)
		{
			int frameCount = Time.frameCount;
			if (frameCount == this.EEMOEFFBJAH)
			{
				return;
			}
			int num = frameCount % this.DIMEDFBDJAK.Length;
			if (this.BGNCOPHGPCE)
			{
				this.DIMEDFBDJAK[num].PMNJNICHBJD(ECKPLMDEJFD, JONJODLFAEN, NMEBEEHCALN, ILLKFNCFGMP, MHNAJNGGDFJ);
			}
			else
			{
				this.DIMEDFBDJAK[num].GACEPIEIBLG(ECKPLMDEJFD, JONJODLFAEN, NMEBEEHCALN, ILLKFNCFGMP, this.CCMPNMCDIFN);
			}
			this.EEMOEFFBJAH = frameCount;
		}

		// Token: 0x06011809 RID: 71689 RVA: 0x007D0F74 File Offset: 0x007CF174
		public void FDGKFBDLHIG(CommandBuffer ECKPLMDEJFD, float JPGIGABPGII, RenderTargetIdentifier JONJODLFAEN, RenderTargetIdentifier OKIIDHIJBEA, Material MHNAJNGGDFJ)
		{
			float time = Time.time;
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf = this.NAIEBDKDDFI(-1);
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf2 = this.LBNLOJNIDPP(-22);
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf3 = this.LKKEDOGACFK(104);
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf4 = this.LKKEDOGACFK(-79);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.BLFGBMABCDD, iapaemhpjmf.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.CBPAGKBAJOA, iapaemhpjmf2.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.MGLGOEBKGBH, iapaemhpjmf3.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OGLDBPOENDA, iapaemhpjmf4.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.NOJOHHNDGMP, iapaemhpjmf.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.FIOHBAMANML, iapaemhpjmf2.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OEHBOEONAHA, iapaemhpjmf3.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.MHKCFNDJIKO, iapaemhpjmf4.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.FALIJINHBJO, iapaemhpjmf.LHMHGOEDPHN(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.AKBJKGAKCED, iapaemhpjmf2.IGHPANOGKLE(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.NCJLKCPLCOK, iapaemhpjmf3.LDGJBGEGCEH(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.DIOCPBCLICL, iapaemhpjmf4.FCCKHKPBDDP(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
			ECKPLMDEJFD.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, this.BGNCOPHGPCE ? 1 : 0);
		}

		// Token: 0x0601180A RID: 71690 RVA: 0x007D10D0 File Offset: 0x007CF2D0
		private static bool CODCDMNIMGK()
		{
			return SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)(-70)) && SystemInfo.supportedRenderTargetCount > 0;
		}

		// Token: 0x0601180B RID: 71691 RVA: 0x007D10E8 File Offset: 0x007CF2E8
		private DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF LKKEDOGACFK(int IGFJOGKFADM)
		{
			int num = (Time.frameCount + this.DIMEDFBDJAK.Length + IGFJOGKFADM) % this.DIMEDFBDJAK.Length;
			return this.DIMEDFBDJAK[num];
		}

		// Token: 0x0601180C RID: 71692 RVA: 0x007D111C File Offset: 0x007CF31C
		public void HFNDGONFKEO()
		{
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF[] dimedfbdjak = this.DIMEDFBDJAK;
			for (int i = 0; i < dimedfbdjak.Length; i += 0)
			{
				DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf = dimedfbdjak[i];
				iapaemhpjmf.AEIGHBEIBFN();
			}
		}

		// Token: 0x0601180D RID: 71693 RVA: 0x007D1150 File Offset: 0x007CF350
		public void JDBEFCLDLBH(CommandBuffer ECKPLMDEJFD, float JPGIGABPGII, RenderTargetIdentifier JONJODLFAEN, RenderTargetIdentifier OKIIDHIJBEA, Material MHNAJNGGDFJ)
		{
			float time = Time.time;
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf = this.HCBGCBFBMAA(-1);
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf2 = this.BGEENFIMBKE(-26);
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf3 = this.OAKFEMBBEIJ(-7);
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf4 = this.OAKFEMBBEIJ(34);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.BLFGBMABCDD, iapaemhpjmf.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.CBPAGKBAJOA, iapaemhpjmf2.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.MGLGOEBKGBH, iapaemhpjmf3.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OGLDBPOENDA, iapaemhpjmf4.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.NOJOHHNDGMP, iapaemhpjmf.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.FIOHBAMANML, iapaemhpjmf2.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OEHBOEONAHA, iapaemhpjmf3.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.MHKCFNDJIKO, iapaemhpjmf4.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.FALIJINHBJO, iapaemhpjmf.JDFDIEACONH(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.AKBJKGAKCED, iapaemhpjmf2.DNPMJLAOHCO(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.NCJLKCPLCOK, iapaemhpjmf3.FJGGOHJOKDM(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.DIOCPBCLICL, iapaemhpjmf4.LHMHGOEDPHN(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
			ECKPLMDEJFD.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, this.BGNCOPHGPCE ? 2 : 3);
		}

		// Token: 0x0601180E RID: 71694 RVA: 0x007D12AC File Offset: 0x007CF4AC
		public void CILKJPLLJKH()
		{
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF[] dimedfbdjak = this.DIMEDFBDJAK;
			for (int i = 0; i < dimedfbdjak.Length; i += 0)
			{
				DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf = dimedfbdjak[i];
				iapaemhpjmf.KFEKLEKKINB();
			}
		}

		// Token: 0x0601180F RID: 71695 RVA: 0x007D12E0 File Offset: 0x007CF4E0
		public void OMAGPIGECAG(CommandBuffer ECKPLMDEJFD, float JPGIGABPGII, RenderTargetIdentifier JONJODLFAEN, RenderTargetIdentifier OKIIDHIJBEA, Material MHNAJNGGDFJ)
		{
			float time = Time.time;
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf = this.DGFCBPHPCLC(-1);
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf2 = this.OGFFFMCOHCL(63);
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf3 = this.BGEENFIMBKE(5);
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf4 = this.EJOFNGKAPHG(113);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.BLFGBMABCDD, iapaemhpjmf.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.CBPAGKBAJOA, iapaemhpjmf2.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.MGLGOEBKGBH, iapaemhpjmf3.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OGLDBPOENDA, iapaemhpjmf4.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.NOJOHHNDGMP, iapaemhpjmf.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.FIOHBAMANML, iapaemhpjmf2.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OEHBOEONAHA, iapaemhpjmf3.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.MHKCFNDJIKO, iapaemhpjmf4.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.FALIJINHBJO, iapaemhpjmf.PPMBLKIHNDH(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.AKBJKGAKCED, iapaemhpjmf2.LHMHGOEDPHN(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.NCJLKCPLCOK, iapaemhpjmf3.FCCKHKPBDDP(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.DIOCPBCLICL, iapaemhpjmf4.DNPMJLAOHCO(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
			ECKPLMDEJFD.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, this.BGNCOPHGPCE ? 3 : 0);
		}

		// Token: 0x06011810 RID: 71696 RVA: 0x007D143C File Offset: 0x007CF63C
		public void HJBMEANCAHP(CommandBuffer ECKPLMDEJFD, float JPGIGABPGII, RenderTargetIdentifier JONJODLFAEN, RenderTargetIdentifier OKIIDHIJBEA, Material MHNAJNGGDFJ)
		{
			float time = Time.time;
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf = this.EKFMKHEDAGO(-1);
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf2 = this.OGFFFMCOHCL(-66);
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf3 = this.NMPMBEHLAON(-86);
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf4 = this.LKKEDOGACFK(-45);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.BLFGBMABCDD, iapaemhpjmf.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.CBPAGKBAJOA, iapaemhpjmf2.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.MGLGOEBKGBH, iapaemhpjmf3.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OGLDBPOENDA, iapaemhpjmf4.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.NOJOHHNDGMP, iapaemhpjmf.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.FIOHBAMANML, iapaemhpjmf2.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OEHBOEONAHA, iapaemhpjmf3.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.MHKCFNDJIKO, iapaemhpjmf4.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.FALIJINHBJO, iapaemhpjmf.FCCKHKPBDDP(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.AKBJKGAKCED, iapaemhpjmf2.KHHKJKGKENE(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.NCJLKCPLCOK, iapaemhpjmf3.AKGAINNNFLB(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.DIOCPBCLICL, iapaemhpjmf4.MDLPKPEJBKI(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
			ECKPLMDEJFD.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, this.BGNCOPHGPCE ? 8 : 6);
		}

		// Token: 0x06011811 RID: 71697 RVA: 0x007D1598 File Offset: 0x007CF798
		public void FILFNLHGPFH()
		{
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF[] dimedfbdjak = this.DIMEDFBDJAK;
			for (int i = 0; i < dimedfbdjak.Length; i += 0)
			{
				DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf = dimedfbdjak[i];
				iapaemhpjmf.EPNLHMECDEF();
			}
		}

		// Token: 0x06011812 RID: 71698 RVA: 0x007D15CC File Offset: 0x007CF7CC
		public void FOFEPAPOPOE(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, Material MHNAJNGGDFJ)
		{
			int frameCount = Time.frameCount;
			if (frameCount == this.EEMOEFFBJAH)
			{
				return;
			}
			int num = frameCount % this.DIMEDFBDJAK.Length;
			if (this.BGNCOPHGPCE)
			{
				this.DIMEDFBDJAK[num].PMNJNICHBJD(ECKPLMDEJFD, JONJODLFAEN, NMEBEEHCALN, ILLKFNCFGMP, MHNAJNGGDFJ);
			}
			else
			{
				this.DIMEDFBDJAK[num].DNAMLLCOLDD(ECKPLMDEJFD, JONJODLFAEN, NMEBEEHCALN, ILLKFNCFGMP, this.CCMPNMCDIFN);
			}
			this.EEMOEFFBJAH = frameCount;
		}

		// Token: 0x06011813 RID: 71699 RVA: 0x007D163C File Offset: 0x007CF83C
		public void IGGDOEEPILF(CommandBuffer ECKPLMDEJFD, float JPGIGABPGII, RenderTargetIdentifier JONJODLFAEN, RenderTargetIdentifier OKIIDHIJBEA, Material MHNAJNGGDFJ)
		{
			float time = Time.time;
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf = this.INEEINLDIMN(-1);
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf2 = this.NAIEBDKDDFI(-79);
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf3 = this.NMPMBEHLAON(76);
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf4 = this.NMPMBEHLAON(-75);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.BLFGBMABCDD, iapaemhpjmf.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.CBPAGKBAJOA, iapaemhpjmf2.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.MGLGOEBKGBH, iapaemhpjmf3.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OGLDBPOENDA, iapaemhpjmf4.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.NOJOHHNDGMP, iapaemhpjmf.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.FIOHBAMANML, iapaemhpjmf2.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OEHBOEONAHA, iapaemhpjmf3.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.MHKCFNDJIKO, iapaemhpjmf4.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.FALIJINHBJO, iapaemhpjmf.JDFDIEACONH(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.AKBJKGAKCED, iapaemhpjmf2.JDFDIEACONH(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.NCJLKCPLCOK, iapaemhpjmf3.EOKGNMHMOPB(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.DIOCPBCLICL, iapaemhpjmf4.DNPMJLAOHCO(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
			ECKPLMDEJFD.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, this.BGNCOPHGPCE ? 2 : 3);
		}

		// Token: 0x06011814 RID: 71700 RVA: 0x007D1798 File Offset: 0x007CF998
		private static RenderTextureFormat BKFPPBCAFFM()
		{
			RenderTextureFormat[] array = new RenderTextureFormat[4];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.51A7A390CD6DE245186881400B18C9D822EFE240).FieldHandle);
			RenderTextureFormat[] array2 = array;
			for (int i = 1; i < array2.Length; i++)
			{
				RenderTextureFormat renderTextureFormat = array2[i];
				if (SystemInfo.SupportsRenderTextureFormat(renderTextureFormat))
				{
					return renderTextureFormat;
				}
			}
			return RenderTextureFormat.Depth;
		}

		// Token: 0x06011815 RID: 71701 RVA: 0x007D17D4 File Offset: 0x007CF9D4
		public void JFMFEDPJFPD()
		{
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF[] dimedfbdjak = this.DIMEDFBDJAK;
			for (int i = 0; i < dimedfbdjak.Length; i += 0)
			{
				DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf = dimedfbdjak[i];
				iapaemhpjmf.DHHJJKHDHJC();
			}
		}

		// Token: 0x06011816 RID: 71702 RVA: 0x007D1808 File Offset: 0x007CFA08
		public void MLOJDJLKBOB()
		{
			foreach (DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf in this.DIMEDFBDJAK)
			{
				iapaemhpjmf.BPIPEGPEKLO();
			}
		}

		// Token: 0x06011817 RID: 71703 RVA: 0x007D183C File Offset: 0x007CFA3C
		public void BJJNFHEGDFF(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, Material MHNAJNGGDFJ)
		{
			int frameCount = Time.frameCount;
			if (frameCount == this.EEMOEFFBJAH)
			{
				return;
			}
			int num = frameCount % this.DIMEDFBDJAK.Length;
			if (this.BGNCOPHGPCE)
			{
				this.DIMEDFBDJAK[num].NFMEOJPBIBE(ECKPLMDEJFD, JONJODLFAEN, NMEBEEHCALN, ILLKFNCFGMP, MHNAJNGGDFJ);
			}
			else
			{
				this.DIMEDFBDJAK[num].JPCGNHHEJNB(ECKPLMDEJFD, JONJODLFAEN, NMEBEEHCALN, ILLKFNCFGMP, this.CCMPNMCDIFN);
			}
			this.EEMOEFFBJAH = frameCount;
		}

		// Token: 0x06011818 RID: 71704 RVA: 0x007D18AC File Offset: 0x007CFAAC
		private static RenderTextureFormat PAPNMKPLEDP()
		{
			RenderTextureFormat[] array = new RenderTextureFormat[8];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.51A7A390CD6DE245186881400B18C9D822EFE240).FieldHandle);
			RenderTextureFormat[] array2 = array;
			for (int i = 1; i < array2.Length; i += 0)
			{
				RenderTextureFormat renderTextureFormat = array2[i];
				if (SystemInfo.SupportsRenderTextureFormat(renderTextureFormat))
				{
					return renderTextureFormat;
				}
			}
			return RenderTextureFormat.Default;
		}

		// Token: 0x06011819 RID: 71705 RVA: 0x007D18E8 File Offset: 0x007CFAE8
		private DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF OGFFFMCOHCL(int IGFJOGKFADM)
		{
			int num = (Time.frameCount + this.DIMEDFBDJAK.Length + IGFJOGKFADM) % this.DIMEDFBDJAK.Length;
			return this.DIMEDFBDJAK[num];
		}

		// Token: 0x0601181A RID: 71706 RVA: 0x007D191C File Offset: 0x007CFB1C
		public void NGNHPGLIPKE(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, Material MHNAJNGGDFJ)
		{
			int frameCount = Time.frameCount;
			if (frameCount == this.EEMOEFFBJAH)
			{
				return;
			}
			int num = frameCount % this.DIMEDFBDJAK.Length;
			if (this.BGNCOPHGPCE)
			{
				this.DIMEDFBDJAK[num].KIMBLOPLKNJ(ECKPLMDEJFD, JONJODLFAEN, NMEBEEHCALN, ILLKFNCFGMP, MHNAJNGGDFJ);
			}
			else
			{
				this.DIMEDFBDJAK[num].KDIKGBOCCBL(ECKPLMDEJFD, JONJODLFAEN, NMEBEEHCALN, ILLKFNCFGMP, this.CCMPNMCDIFN);
			}
			this.EEMOEFFBJAH = frameCount;
		}

		// Token: 0x0601181B RID: 71707 RVA: 0x007D198C File Offset: 0x007CFB8C
		private static RenderTextureFormat MKMNCFLEIGN()
		{
			RenderTextureFormat[] array = new RenderTextureFormat[3];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.51A7A390CD6DE245186881400B18C9D822EFE240).FieldHandle);
			RenderTextureFormat[] array2 = array;
			for (int i = 1; i < array2.Length; i += 0)
			{
				RenderTextureFormat renderTextureFormat = array2[i];
				if (SystemInfo.SupportsRenderTextureFormat(renderTextureFormat))
				{
					return renderTextureFormat;
				}
			}
			return RenderTextureFormat.ARGB2101010;
		}

		// Token: 0x0601181C RID: 71708 RVA: 0x007D19C8 File Offset: 0x007CFBC8
		public void DMHMNAPJOMO(CommandBuffer ECKPLMDEJFD, float JPGIGABPGII, RenderTargetIdentifier JONJODLFAEN, RenderTargetIdentifier OKIIDHIJBEA, Material MHNAJNGGDFJ)
		{
			float time = Time.time;
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf = this.HCBGCBFBMAA(-1);
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf2 = this.KCCPBABIBHB(77);
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf3 = this.OAKFEMBBEIJ(105);
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf4 = this.EKFMKHEDAGO(37);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.BLFGBMABCDD, iapaemhpjmf.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.CBPAGKBAJOA, iapaemhpjmf2.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.MGLGOEBKGBH, iapaemhpjmf3.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OGLDBPOENDA, iapaemhpjmf4.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.NOJOHHNDGMP, iapaemhpjmf.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.FIOHBAMANML, iapaemhpjmf2.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OEHBOEONAHA, iapaemhpjmf3.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.MHKCFNDJIKO, iapaemhpjmf4.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.FALIJINHBJO, iapaemhpjmf.PPMBLKIHNDH(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.AKBJKGAKCED, iapaemhpjmf2.KHHKJKGKENE(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.NCJLKCPLCOK, iapaemhpjmf3.IOILOHKDLEL(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.DIOCPBCLICL, iapaemhpjmf4.LHMHGOEDPHN(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
			ECKPLMDEJFD.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, this.BGNCOPHGPCE ? 8 : 4);
		}

		// Token: 0x0601181D RID: 71709 RVA: 0x007D1B24 File Offset: 0x007CFD24
		public void FGBILPKOJBE(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, Material MHNAJNGGDFJ)
		{
			int frameCount = Time.frameCount;
			if (frameCount == this.EEMOEFFBJAH)
			{
				return;
			}
			int num = frameCount % this.DIMEDFBDJAK.Length;
			if (this.BGNCOPHGPCE)
			{
				this.DIMEDFBDJAK[num].PMNJNICHBJD(ECKPLMDEJFD, JONJODLFAEN, NMEBEEHCALN, ILLKFNCFGMP, MHNAJNGGDFJ);
			}
			else
			{
				this.DIMEDFBDJAK[num].NJAMJEMEPKJ(ECKPLMDEJFD, JONJODLFAEN, NMEBEEHCALN, ILLKFNCFGMP, this.CCMPNMCDIFN);
			}
			this.EEMOEFFBJAH = frameCount;
		}

		// Token: 0x0601181E RID: 71710 RVA: 0x007D1B94 File Offset: 0x007CFD94
		public void IJACFGOAPLA(CommandBuffer ECKPLMDEJFD, float JPGIGABPGII, RenderTargetIdentifier JONJODLFAEN, RenderTargetIdentifier OKIIDHIJBEA, Material MHNAJNGGDFJ)
		{
			float time = Time.time;
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf = this.OGFFFMCOHCL(-1);
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf2 = this.EKFMKHEDAGO(-56);
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf3 = this.EKFMKHEDAGO(-74);
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf4 = this.INEEINLDIMN(-94);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.BLFGBMABCDD, iapaemhpjmf.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.CBPAGKBAJOA, iapaemhpjmf2.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.MGLGOEBKGBH, iapaemhpjmf3.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OGLDBPOENDA, iapaemhpjmf4.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.NOJOHHNDGMP, iapaemhpjmf.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.FIOHBAMANML, iapaemhpjmf2.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OEHBOEONAHA, iapaemhpjmf3.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.MHKCFNDJIKO, iapaemhpjmf4.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.FALIJINHBJO, iapaemhpjmf.LHMHGOEDPHN(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.AKBJKGAKCED, iapaemhpjmf2.EEGJCGPBFPA(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.NCJLKCPLCOK, iapaemhpjmf3.EEGJCGPBFPA(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.DIOCPBCLICL, iapaemhpjmf4.DNPMJLAOHCO(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
			ECKPLMDEJFD.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, this.BGNCOPHGPCE ? 2 : 1);
		}

		// Token: 0x0601181F RID: 71711 RVA: 0x007D1CF0 File Offset: 0x007CFEF0
		private static RenderTextureFormat KODOGMAJHMP()
		{
			RenderTextureFormat[] array = new RenderTextureFormat[0];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.51A7A390CD6DE245186881400B18C9D822EFE240).FieldHandle);
			RenderTextureFormat[] array2 = array;
			for (int i = 1; i < array2.Length; i++)
			{
				RenderTextureFormat renderTextureFormat = array2[i];
				if (SystemInfo.SupportsRenderTextureFormat(renderTextureFormat))
				{
					return renderTextureFormat;
				}
			}
			return RenderTextureFormat.Depth;
		}

		// Token: 0x06011820 RID: 71712 RVA: 0x007D1D2C File Offset: 0x007CFF2C
		public void HGENPIBALKA(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, Material MHNAJNGGDFJ)
		{
			int frameCount = Time.frameCount;
			if (frameCount == this.EEMOEFFBJAH)
			{
				return;
			}
			int num = frameCount % this.DIMEDFBDJAK.Length;
			if (this.BGNCOPHGPCE)
			{
				this.DIMEDFBDJAK[num].ACDJIFFOODF(ECKPLMDEJFD, JONJODLFAEN, NMEBEEHCALN, ILLKFNCFGMP, MHNAJNGGDFJ);
			}
			else
			{
				this.DIMEDFBDJAK[num].NJAMJEMEPKJ(ECKPLMDEJFD, JONJODLFAEN, NMEBEEHCALN, ILLKFNCFGMP, this.CCMPNMCDIFN);
			}
			this.EEMOEFFBJAH = frameCount;
		}

		// Token: 0x06011821 RID: 71713 RVA: 0x007D1D9C File Offset: 0x007CFF9C
		private static RenderTextureFormat MGMGLPOEOIC()
		{
			RenderTextureFormat[] array = new RenderTextureFormat[6];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.51A7A390CD6DE245186881400B18C9D822EFE240).FieldHandle);
			RenderTextureFormat[] array2 = array;
			for (int i = 1; i < array2.Length; i += 0)
			{
				RenderTextureFormat renderTextureFormat = array2[i];
				if (SystemInfo.SupportsRenderTextureFormat(renderTextureFormat))
				{
					return renderTextureFormat;
				}
			}
			return RenderTextureFormat.RGB565;
		}

		// Token: 0x06011822 RID: 71714 RVA: 0x007D1DD8 File Offset: 0x007CFFD8
		public void DONGAPGMKFB(CommandBuffer ECKPLMDEJFD, float JPGIGABPGII, RenderTargetIdentifier JONJODLFAEN, RenderTargetIdentifier OKIIDHIJBEA, Material MHNAJNGGDFJ)
		{
			float time = Time.time;
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf = this.NMPMBEHLAON(-1);
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf2 = this.KCCPBABIBHB(-73);
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf3 = this.NAIEBDKDDFI(37);
			DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF iapaemhpjmf4 = this.NAIEBDKDDFI(-64);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.BLFGBMABCDD, iapaemhpjmf.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.CBPAGKBAJOA, iapaemhpjmf2.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.MGLGOEBKGBH, iapaemhpjmf3.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OGLDBPOENDA, iapaemhpjmf4.JNBJMFLOHAM);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.NOJOHHNDGMP, iapaemhpjmf.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.FIOHBAMANML, iapaemhpjmf2.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OEHBOEONAHA, iapaemhpjmf3.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.MHKCFNDJIKO, iapaemhpjmf4.EHOBLPKPENF);
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.FALIJINHBJO, iapaemhpjmf.MDLPKPEJBKI(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.AKBJKGAKCED, iapaemhpjmf2.IGHPANOGKLE(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.NCJLKCPLCOK, iapaemhpjmf3.MDLPKPEJBKI(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalFloat(DGIEACBKFMJ.BNEACEICMJJ.DIOCPBCLICL, iapaemhpjmf4.IOILOHKDLEL(JPGIGABPGII, time));
			ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
			ECKPLMDEJFD.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, this.BGNCOPHGPCE ? 8 : 2);
		}

		// Token: 0x06011823 RID: 71715 RVA: 0x007D1F34 File Offset: 0x007D0134
		private static bool PHEKBGHCFDB()
		{
			return !SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)(-73)) || SystemInfo.supportedRenderTargetCount > 0;
		}

		// Token: 0x04002488 RID: 9352
		private bool BGNCOPHGPCE;

		// Token: 0x04002489 RID: 9353
		private RenderTextureFormat CCMPNMCDIFN;

		// Token: 0x0400248A RID: 9354
		private DGIEACBKFMJ.LBJNDEHNHOB.IAPAEMHPJMF[] DIMEDFBDJAK;

		// Token: 0x0400248B RID: 9355
		private int EEMOEFFBJAH;

		// Token: 0x02000529 RID: 1321
		private struct IAPAEMHPJMF
		{
			// Token: 0x06011824 RID: 71716 RVA: 0x007D1F4C File Offset: 0x007D014C
			public float JFBKDBIPDCE(float JPGIGABPGII, float OGIMHFCCIGH)
			{
				if (Mathf.Approximately(this.ANMILMGHLJI, 100f))
				{
					return 1936f;
				}
				float num = Mathf.Lerp(798f, 1341f, JPGIGABPGII);
				return Mathf.Exp((this.ANMILMGHLJI - OGIMHFCCIGH) * num);
			}

			// Token: 0x06011825 RID: 71717 RVA: 0x007D1F94 File Offset: 0x007D0194
			public void LDGLFLEMPOF(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, Material MHNAJNGGDFJ)
			{
				this.KLOJCIBDJIJ();
				this.JNBJMFLOHAM = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 1, (RenderTextureFormat)32, RenderTextureReadWrite.Linear);
				this.EHOBLPKPENF = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 1, (RenderTextureFormat)(-104), RenderTextureReadWrite.Default);
				this.JNBJMFLOHAM.filterMode = FilterMode.Bilinear;
				this.EHOBLPKPENF.filterMode = FilterMode.Point;
				if (this.AKNMAGILBHJ == null)
				{
					this.AKNMAGILBHJ = new RenderTargetIdentifier[6];
				}
				this.AKNMAGILBHJ[1] = this.JNBJMFLOHAM;
				this.AKNMAGILBHJ[0] = this.EHOBLPKPENF;
				ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
				ECKPLMDEJFD.SetRenderTarget(this.AKNMAGILBHJ, this.JNBJMFLOHAM);
				ECKPLMDEJFD.DrawMesh(CDBICMCJFCE.BHBBKCJAMNO, Matrix4x4.identity, MHNAJNGGDFJ, 0, 5);
				this.ANMILMGHLJI = Time.time;
			}

			// Token: 0x06011826 RID: 71718 RVA: 0x007D2068 File Offset: 0x007D0268
			public void NFMEOJPBIBE(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, Material MHNAJNGGDFJ)
			{
				this.OFKHPBDDKHJ();
				this.JNBJMFLOHAM = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 0, RenderTextureFormat.R8, RenderTextureReadWrite.Linear);
				this.EHOBLPKPENF = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 0, RenderTextureFormat.R8, RenderTextureReadWrite.Linear);
				this.JNBJMFLOHAM.filterMode = FilterMode.Point;
				this.EHOBLPKPENF.filterMode = FilterMode.Point;
				if (this.AKNMAGILBHJ == null)
				{
					this.AKNMAGILBHJ = new RenderTargetIdentifier[2];
				}
				this.AKNMAGILBHJ[0] = this.JNBJMFLOHAM;
				this.AKNMAGILBHJ[1] = this.EHOBLPKPENF;
				ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
				ECKPLMDEJFD.SetRenderTarget(this.AKNMAGILBHJ, this.JNBJMFLOHAM);
				ECKPLMDEJFD.DrawMesh(CDBICMCJFCE.BHBBKCJAMNO, Matrix4x4.identity, MHNAJNGGDFJ, 0, 6);
				this.ANMILMGHLJI = Time.time;
			}

			// Token: 0x06011827 RID: 71719 RVA: 0x007D213C File Offset: 0x007D033C
			public void ADOFEDJHAPP(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, RenderTextureFormat LJCEDKCLBDB)
			{
				this.BPIPEGPEKLO();
				this.JNBJMFLOHAM = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 1, LJCEDKCLBDB);
				this.JNBJMFLOHAM.filterMode = FilterMode.Point;
				ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
				ECKPLMDEJFD.Blit(JONJODLFAEN, this.JNBJMFLOHAM);
				this.ANMILMGHLJI = Time.time;
			}

			// Token: 0x06011828 RID: 71720 RVA: 0x007D2198 File Offset: 0x007D0398
			public float PPMBLKIHNDH(float JPGIGABPGII, float OGIMHFCCIGH)
			{
				if (Mathf.Approximately(this.ANMILMGHLJI, 1517f))
				{
					return 883f;
				}
				float num = Mathf.Lerp(1792f, 751f, JPGIGABPGII);
				return Mathf.Exp((this.ANMILMGHLJI - OGIMHFCCIGH) * num);
			}

			// Token: 0x06011829 RID: 71721 RVA: 0x007D21E0 File Offset: 0x007D03E0
			public void PMGJCGJEGKN(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, Material MHNAJNGGDFJ)
			{
				this.EPNLHMECDEF();
				this.JNBJMFLOHAM = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 1, (RenderTextureFormat)(-75), RenderTextureReadWrite.Default);
				this.EHOBLPKPENF = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 0, (RenderTextureFormat)(-30), RenderTextureReadWrite.Linear);
				this.JNBJMFLOHAM.filterMode = FilterMode.Bilinear;
				this.EHOBLPKPENF.filterMode = FilterMode.Bilinear;
				if (this.AKNMAGILBHJ == null)
				{
					this.AKNMAGILBHJ = new RenderTargetIdentifier[4];
				}
				this.AKNMAGILBHJ[0] = this.JNBJMFLOHAM;
				this.AKNMAGILBHJ[1] = this.EHOBLPKPENF;
				ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
				ECKPLMDEJFD.SetRenderTarget(this.AKNMAGILBHJ, this.JNBJMFLOHAM);
				ECKPLMDEJFD.DrawMesh(CDBICMCJFCE.BHBBKCJAMNO, Matrix4x4.identity, MHNAJNGGDFJ, 0, 7);
				this.ANMILMGHLJI = Time.time;
			}

			// Token: 0x0601182A RID: 71722 RVA: 0x007D22B4 File Offset: 0x007D04B4
			public float LHMHGOEDPHN(float JPGIGABPGII, float OGIMHFCCIGH)
			{
				if (Mathf.Approximately(this.ANMILMGHLJI, 485f))
				{
					return 1950f;
				}
				float num = Mathf.Lerp(330f, 1370f, JPGIGABPGII);
				return Mathf.Exp((this.ANMILMGHLJI - OGIMHFCCIGH) * num);
			}

			// Token: 0x0601182B RID: 71723 RVA: 0x007D22FC File Offset: 0x007D04FC
			public void DGEJEFIBFJP()
			{
				if (this.JNBJMFLOHAM != null)
				{
					RenderTexture.ReleaseTemporary(this.JNBJMFLOHAM);
				}
				if (this.EHOBLPKPENF != null)
				{
					RenderTexture.ReleaseTemporary(this.EHOBLPKPENF);
				}
				this.JNBJMFLOHAM = null;
				this.EHOBLPKPENF = null;
			}

			// Token: 0x0601182C RID: 71724 RVA: 0x007D234C File Offset: 0x007D054C
			public void AEIGHBEIBFN()
			{
				if (this.JNBJMFLOHAM != null)
				{
					RenderTexture.ReleaseTemporary(this.JNBJMFLOHAM);
				}
				if (this.EHOBLPKPENF != null)
				{
					RenderTexture.ReleaseTemporary(this.EHOBLPKPENF);
				}
				this.JNBJMFLOHAM = null;
				this.EHOBLPKPENF = null;
			}

			// Token: 0x0601182D RID: 71725 RVA: 0x007D239C File Offset: 0x007D059C
			public float DNPMJLAOHCO(float JPGIGABPGII, float OGIMHFCCIGH)
			{
				if (Mathf.Approximately(this.ANMILMGHLJI, 1275f))
				{
					return 1186f;
				}
				float num = Mathf.Lerp(1272f, 1759f, JPGIGABPGII);
				return Mathf.Exp((this.ANMILMGHLJI - OGIMHFCCIGH) * num);
			}

			// Token: 0x0601182E RID: 71726 RVA: 0x007D23E4 File Offset: 0x007D05E4
			public void EKFMEMECJJJ(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, RenderTextureFormat LJCEDKCLBDB)
			{
				this.OFKHPBDDKHJ();
				this.JNBJMFLOHAM = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 0, LJCEDKCLBDB);
				this.JNBJMFLOHAM.filterMode = FilterMode.Point;
				ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
				ECKPLMDEJFD.Blit(JONJODLFAEN, this.JNBJMFLOHAM);
				this.ANMILMGHLJI = Time.time;
			}

			// Token: 0x0601182F RID: 71727 RVA: 0x007D2440 File Offset: 0x007D0640
			public void FIDKLNFIGOA(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, RenderTextureFormat LJCEDKCLBDB)
			{
				this.DPIFMGDFBGA();
				this.JNBJMFLOHAM = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 0, LJCEDKCLBDB);
				this.JNBJMFLOHAM.filterMode = FilterMode.Bilinear;
				ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
				ECKPLMDEJFD.Blit(JONJODLFAEN, this.JNBJMFLOHAM);
				this.ANMILMGHLJI = Time.time;
			}

			// Token: 0x06011830 RID: 71728 RVA: 0x007D249C File Offset: 0x007D069C
			public void KEGPIBLIDGJ()
			{
				if (this.JNBJMFLOHAM != null)
				{
					RenderTexture.ReleaseTemporary(this.JNBJMFLOHAM);
				}
				if (this.EHOBLPKPENF != null)
				{
					RenderTexture.ReleaseTemporary(this.EHOBLPKPENF);
				}
				this.JNBJMFLOHAM = null;
				this.EHOBLPKPENF = null;
			}

			// Token: 0x06011831 RID: 71729 RVA: 0x007D24EC File Offset: 0x007D06EC
			public void ACDJIFFOODF(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, Material MHNAJNGGDFJ)
			{
				this.KOMNGAMPJEF();
				this.JNBJMFLOHAM = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 0, (RenderTextureFormat)(-44), RenderTextureReadWrite.Default);
				this.EHOBLPKPENF = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 1, (RenderTextureFormat)87, RenderTextureReadWrite.Default);
				this.JNBJMFLOHAM.filterMode = FilterMode.Point;
				this.EHOBLPKPENF.filterMode = FilterMode.Bilinear;
				if (this.AKNMAGILBHJ == null)
				{
					this.AKNMAGILBHJ = new RenderTargetIdentifier[0];
				}
				this.AKNMAGILBHJ[1] = this.JNBJMFLOHAM;
				this.AKNMAGILBHJ[1] = this.EHOBLPKPENF;
				ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
				ECKPLMDEJFD.SetRenderTarget(this.AKNMAGILBHJ, this.JNBJMFLOHAM);
				ECKPLMDEJFD.DrawMesh(CDBICMCJFCE.BHBBKCJAMNO, Matrix4x4.identity, MHNAJNGGDFJ, 1, 6);
				this.ANMILMGHLJI = Time.time;
			}

			// Token: 0x06011832 RID: 71730 RVA: 0x007D25C0 File Offset: 0x007D07C0
			public void POPKLNJHICJ()
			{
				if (this.JNBJMFLOHAM != null)
				{
					RenderTexture.ReleaseTemporary(this.JNBJMFLOHAM);
				}
				if (this.EHOBLPKPENF != null)
				{
					RenderTexture.ReleaseTemporary(this.EHOBLPKPENF);
				}
				this.JNBJMFLOHAM = null;
				this.EHOBLPKPENF = null;
			}

			// Token: 0x06011833 RID: 71731 RVA: 0x007D2610 File Offset: 0x007D0810
			public void FALPPMEHJLK()
			{
				if (this.JNBJMFLOHAM != null)
				{
					RenderTexture.ReleaseTemporary(this.JNBJMFLOHAM);
				}
				if (this.EHOBLPKPENF != null)
				{
					RenderTexture.ReleaseTemporary(this.EHOBLPKPENF);
				}
				this.JNBJMFLOHAM = null;
				this.EHOBLPKPENF = null;
			}

			// Token: 0x06011834 RID: 71732 RVA: 0x007D2660 File Offset: 0x007D0860
			public void PMIKDPGIOBG(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, RenderTextureFormat LJCEDKCLBDB)
			{
				this.PKNMHMFNAGP();
				this.JNBJMFLOHAM = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 0, LJCEDKCLBDB);
				this.JNBJMFLOHAM.filterMode = FilterMode.Point;
				ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
				ECKPLMDEJFD.Blit(JONJODLFAEN, this.JNBJMFLOHAM);
				this.ANMILMGHLJI = Time.time;
			}

			// Token: 0x06011835 RID: 71733 RVA: 0x007D26BC File Offset: 0x007D08BC
			public void NJAMJEMEPKJ(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, RenderTextureFormat LJCEDKCLBDB)
			{
				this.DHHJJKHDHJC();
				this.JNBJMFLOHAM = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 0, LJCEDKCLBDB);
				this.JNBJMFLOHAM.filterMode = FilterMode.Bilinear;
				ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
				ECKPLMDEJFD.Blit(JONJODLFAEN, this.JNBJMFLOHAM);
				this.ANMILMGHLJI = Time.time;
			}

			// Token: 0x06011836 RID: 71734 RVA: 0x007D2718 File Offset: 0x007D0918
			public void HLEGMANFHEG()
			{
				if (this.JNBJMFLOHAM != null)
				{
					RenderTexture.ReleaseTemporary(this.JNBJMFLOHAM);
				}
				if (this.EHOBLPKPENF != null)
				{
					RenderTexture.ReleaseTemporary(this.EHOBLPKPENF);
				}
				this.JNBJMFLOHAM = null;
				this.EHOBLPKPENF = null;
			}

			// Token: 0x06011837 RID: 71735 RVA: 0x007D2768 File Offset: 0x007D0968
			public void GOMDFCMHFBE(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, RenderTextureFormat LJCEDKCLBDB)
			{
				this.HCJNBEAABAF();
				this.JNBJMFLOHAM = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 1, LJCEDKCLBDB);
				this.JNBJMFLOHAM.filterMode = FilterMode.Bilinear;
				ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
				ECKPLMDEJFD.Blit(JONJODLFAEN, this.JNBJMFLOHAM);
				this.ANMILMGHLJI = Time.time;
			}

			// Token: 0x06011838 RID: 71736 RVA: 0x007D27C4 File Offset: 0x007D09C4
			public void CGCFEOIMKEC(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, Material MHNAJNGGDFJ)
			{
				this.KPJDEDNCOGD();
				this.JNBJMFLOHAM = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 0, (RenderTextureFormat)54, RenderTextureReadWrite.Linear);
				this.EHOBLPKPENF = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 0, (RenderTextureFormat)95, RenderTextureReadWrite.Default);
				this.JNBJMFLOHAM.filterMode = FilterMode.Point;
				this.EHOBLPKPENF.filterMode = FilterMode.Bilinear;
				if (this.AKNMAGILBHJ == null)
				{
					this.AKNMAGILBHJ = new RenderTargetIdentifier[1];
				}
				this.AKNMAGILBHJ[1] = this.JNBJMFLOHAM;
				this.AKNMAGILBHJ[1] = this.EHOBLPKPENF;
				ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
				ECKPLMDEJFD.SetRenderTarget(this.AKNMAGILBHJ, this.JNBJMFLOHAM);
				ECKPLMDEJFD.DrawMesh(CDBICMCJFCE.BHBBKCJAMNO, Matrix4x4.identity, MHNAJNGGDFJ, 1, 0);
				this.ANMILMGHLJI = Time.time;
			}

			// Token: 0x06011839 RID: 71737 RVA: 0x007D2898 File Offset: 0x007D0A98
			public void ACPJCBJBLKE(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, RenderTextureFormat LJCEDKCLBDB)
			{
				this.AEIGHBEIBFN();
				this.JNBJMFLOHAM = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 0, LJCEDKCLBDB);
				this.JNBJMFLOHAM.filterMode = FilterMode.Point;
				ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
				ECKPLMDEJFD.Blit(JONJODLFAEN, this.JNBJMFLOHAM);
				this.ANMILMGHLJI = Time.time;
			}

			// Token: 0x0601183A RID: 71738 RVA: 0x007D28F4 File Offset: 0x007D0AF4
			public void OPEGDCJMDFM(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, Material MHNAJNGGDFJ)
			{
				this.FALPPMEHJLK();
				this.JNBJMFLOHAM = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 0, (RenderTextureFormat)(-75), RenderTextureReadWrite.Linear);
				this.EHOBLPKPENF = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 1, (RenderTextureFormat)(-34), RenderTextureReadWrite.Default);
				this.JNBJMFLOHAM.filterMode = FilterMode.Bilinear;
				this.EHOBLPKPENF.filterMode = FilterMode.Bilinear;
				if (this.AKNMAGILBHJ == null)
				{
					this.AKNMAGILBHJ = new RenderTargetIdentifier[6];
				}
				this.AKNMAGILBHJ[0] = this.JNBJMFLOHAM;
				this.AKNMAGILBHJ[1] = this.EHOBLPKPENF;
				ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
				ECKPLMDEJFD.SetRenderTarget(this.AKNMAGILBHJ, this.JNBJMFLOHAM);
				ECKPLMDEJFD.DrawMesh(CDBICMCJFCE.BHBBKCJAMNO, Matrix4x4.identity, MHNAJNGGDFJ, 0, 1);
				this.ANMILMGHLJI = Time.time;
			}

			// Token: 0x0601183B RID: 71739 RVA: 0x007D29C8 File Offset: 0x007D0BC8
			public void FHHJNNALPKG(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, Material MHNAJNGGDFJ)
			{
				this.DGEJEFIBFJP();
				this.JNBJMFLOHAM = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 1, (RenderTextureFormat)21, RenderTextureReadWrite.Linear);
				this.EHOBLPKPENF = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 1, (RenderTextureFormat)68, RenderTextureReadWrite.Default);
				this.JNBJMFLOHAM.filterMode = FilterMode.Bilinear;
				this.EHOBLPKPENF.filterMode = FilterMode.Bilinear;
				if (this.AKNMAGILBHJ == null)
				{
					this.AKNMAGILBHJ = new RenderTargetIdentifier[4];
				}
				this.AKNMAGILBHJ[1] = this.JNBJMFLOHAM;
				this.AKNMAGILBHJ[1] = this.EHOBLPKPENF;
				ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
				ECKPLMDEJFD.SetRenderTarget(this.AKNMAGILBHJ, this.JNBJMFLOHAM);
				ECKPLMDEJFD.DrawMesh(CDBICMCJFCE.BHBBKCJAMNO, Matrix4x4.identity, MHNAJNGGDFJ, 0, 4);
				this.ANMILMGHLJI = Time.time;
			}

			// Token: 0x0601183C RID: 71740 RVA: 0x007D2A9C File Offset: 0x007D0C9C
			public void OFKHPBDDKHJ()
			{
				if (this.JNBJMFLOHAM != null)
				{
					RenderTexture.ReleaseTemporary(this.JNBJMFLOHAM);
				}
				if (this.EHOBLPKPENF != null)
				{
					RenderTexture.ReleaseTemporary(this.EHOBLPKPENF);
				}
				this.JNBJMFLOHAM = null;
				this.EHOBLPKPENF = null;
			}

			// Token: 0x0601183D RID: 71741 RVA: 0x007D2AEC File Offset: 0x007D0CEC
			public void OKILDJDJHIB(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, Material MHNAJNGGDFJ)
			{
				this.OOAPIMIAEBO();
				this.JNBJMFLOHAM = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 1, (RenderTextureFormat)(-105), RenderTextureReadWrite.Linear);
				this.EHOBLPKPENF = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 0, (RenderTextureFormat)21, RenderTextureReadWrite.Default);
				this.JNBJMFLOHAM.filterMode = FilterMode.Bilinear;
				this.EHOBLPKPENF.filterMode = FilterMode.Bilinear;
				if (this.AKNMAGILBHJ == null)
				{
					this.AKNMAGILBHJ = new RenderTargetIdentifier[4];
				}
				this.AKNMAGILBHJ[1] = this.JNBJMFLOHAM;
				this.AKNMAGILBHJ[1] = this.EHOBLPKPENF;
				ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
				ECKPLMDEJFD.SetRenderTarget(this.AKNMAGILBHJ, this.JNBJMFLOHAM);
				ECKPLMDEJFD.DrawMesh(CDBICMCJFCE.BHBBKCJAMNO, Matrix4x4.identity, MHNAJNGGDFJ, 1, 7);
				this.ANMILMGHLJI = Time.time;
			}

			// Token: 0x0601183E RID: 71742 RVA: 0x007D2BC0 File Offset: 0x007D0DC0
			public float JDFDIEACONH(float JPGIGABPGII, float OGIMHFCCIGH)
			{
				if (Mathf.Approximately(this.ANMILMGHLJI, 1151f))
				{
					return 1374f;
				}
				float num = Mathf.Lerp(1688f, 686f, JPGIGABPGII);
				return Mathf.Exp((this.ANMILMGHLJI - OGIMHFCCIGH) * num);
			}

			// Token: 0x0601183F RID: 71743 RVA: 0x007D2C08 File Offset: 0x007D0E08
			public float AKGAINNNFLB(float JPGIGABPGII, float OGIMHFCCIGH)
			{
				if (Mathf.Approximately(this.ANMILMGHLJI, 1878f))
				{
					return 1643f;
				}
				float num = Mathf.Lerp(1305f, 154f, JPGIGABPGII);
				return Mathf.Exp((this.ANMILMGHLJI - OGIMHFCCIGH) * num);
			}

			// Token: 0x06011840 RID: 71744 RVA: 0x007D2C50 File Offset: 0x007D0E50
			public void KOMNGAMPJEF()
			{
				if (this.JNBJMFLOHAM != null)
				{
					RenderTexture.ReleaseTemporary(this.JNBJMFLOHAM);
				}
				if (this.EHOBLPKPENF != null)
				{
					RenderTexture.ReleaseTemporary(this.EHOBLPKPENF);
				}
				this.JNBJMFLOHAM = null;
				this.EHOBLPKPENF = null;
			}

			// Token: 0x06011841 RID: 71745 RVA: 0x007D2CA0 File Offset: 0x007D0EA0
			public float MDLPKPEJBKI(float JPGIGABPGII, float OGIMHFCCIGH)
			{
				if (Mathf.Approximately(this.ANMILMGHLJI, 1202f))
				{
					return 1432f;
				}
				float num = Mathf.Lerp(548f, 1191f, JPGIGABPGII);
				return Mathf.Exp((this.ANMILMGHLJI - OGIMHFCCIGH) * num);
			}

			// Token: 0x06011842 RID: 71746 RVA: 0x007D2CE8 File Offset: 0x007D0EE8
			public void EBKKDKKGPEN(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, RenderTextureFormat LJCEDKCLBDB)
			{
				this.KEGPIBLIDGJ();
				this.JNBJMFLOHAM = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 1, LJCEDKCLBDB);
				this.JNBJMFLOHAM.filterMode = FilterMode.Point;
				ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
				ECKPLMDEJFD.Blit(JONJODLFAEN, this.JNBJMFLOHAM);
				this.ANMILMGHLJI = Time.time;
			}

			// Token: 0x06011843 RID: 71747 RVA: 0x007D2D44 File Offset: 0x007D0F44
			public void ENJMKKOFIBE(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, RenderTextureFormat LJCEDKCLBDB)
			{
				this.KFEKLEKKINB();
				this.JNBJMFLOHAM = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 1, LJCEDKCLBDB);
				this.JNBJMFLOHAM.filterMode = FilterMode.Bilinear;
				ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
				ECKPLMDEJFD.Blit(JONJODLFAEN, this.JNBJMFLOHAM);
				this.ANMILMGHLJI = Time.time;
			}

			// Token: 0x06011844 RID: 71748 RVA: 0x007D2DA0 File Offset: 0x007D0FA0
			public void BIFBBGILMMB(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, Material MHNAJNGGDFJ)
			{
				this.OOAPIMIAEBO();
				this.JNBJMFLOHAM = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 1, (RenderTextureFormat)(-9), RenderTextureReadWrite.Default);
				this.EHOBLPKPENF = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 1, (RenderTextureFormat)(-58), RenderTextureReadWrite.Default);
				this.JNBJMFLOHAM.filterMode = FilterMode.Bilinear;
				this.EHOBLPKPENF.filterMode = FilterMode.Point;
				if (this.AKNMAGILBHJ == null)
				{
					this.AKNMAGILBHJ = new RenderTargetIdentifier[2];
				}
				this.AKNMAGILBHJ[0] = this.JNBJMFLOHAM;
				this.AKNMAGILBHJ[1] = this.EHOBLPKPENF;
				ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
				ECKPLMDEJFD.SetRenderTarget(this.AKNMAGILBHJ, this.JNBJMFLOHAM);
				ECKPLMDEJFD.DrawMesh(CDBICMCJFCE.BHBBKCJAMNO, Matrix4x4.identity, MHNAJNGGDFJ, 1, 1);
				this.ANMILMGHLJI = Time.time;
			}

			// Token: 0x06011845 RID: 71749 RVA: 0x007D2E74 File Offset: 0x007D1074
			public void BPIPEGPEKLO()
			{
				if (this.JNBJMFLOHAM != null)
				{
					RenderTexture.ReleaseTemporary(this.JNBJMFLOHAM);
				}
				if (this.EHOBLPKPENF != null)
				{
					RenderTexture.ReleaseTemporary(this.EHOBLPKPENF);
				}
				this.JNBJMFLOHAM = null;
				this.EHOBLPKPENF = null;
			}

			// Token: 0x06011846 RID: 71750 RVA: 0x007D2EC4 File Offset: 0x007D10C4
			public void JLNOPMKMPBH(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, Material MHNAJNGGDFJ)
			{
				this.OOAPIMIAEBO();
				this.JNBJMFLOHAM = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 1, (RenderTextureFormat)105, RenderTextureReadWrite.Default);
				this.EHOBLPKPENF = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 0, (RenderTextureFormat)119, RenderTextureReadWrite.Default);
				this.JNBJMFLOHAM.filterMode = FilterMode.Bilinear;
				this.EHOBLPKPENF.filterMode = FilterMode.Point;
				if (this.AKNMAGILBHJ == null)
				{
					this.AKNMAGILBHJ = new RenderTargetIdentifier[8];
				}
				this.AKNMAGILBHJ[1] = this.JNBJMFLOHAM;
				this.AKNMAGILBHJ[0] = this.EHOBLPKPENF;
				ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
				ECKPLMDEJFD.SetRenderTarget(this.AKNMAGILBHJ, this.JNBJMFLOHAM);
				ECKPLMDEJFD.DrawMesh(CDBICMCJFCE.BHBBKCJAMNO, Matrix4x4.identity, MHNAJNGGDFJ, 0, 4);
				this.ANMILMGHLJI = Time.time;
			}

			// Token: 0x06011847 RID: 71751 RVA: 0x007D2F98 File Offset: 0x007D1198
			public float IIIOPMPBLJH(float JPGIGABPGII, float OGIMHFCCIGH)
			{
				if (Mathf.Approximately(this.ANMILMGHLJI, 1080f))
				{
					return 734f;
				}
				float num = Mathf.Lerp(1291f, 1139f, JPGIGABPGII);
				return Mathf.Exp((this.ANMILMGHLJI - OGIMHFCCIGH) * num);
			}

			// Token: 0x06011848 RID: 71752 RVA: 0x007D2FE0 File Offset: 0x007D11E0
			public float KHHKJKGKENE(float JPGIGABPGII, float OGIMHFCCIGH)
			{
				if (Mathf.Approximately(this.ANMILMGHLJI, 1358f))
				{
					return 1576f;
				}
				float num = Mathf.Lerp(358f, 289f, JPGIGABPGII);
				return Mathf.Exp((this.ANMILMGHLJI - OGIMHFCCIGH) * num);
			}

			// Token: 0x06011849 RID: 71753 RVA: 0x007D3028 File Offset: 0x007D1228
			public void DEGAHLNIMMI()
			{
				if (this.JNBJMFLOHAM != null)
				{
					RenderTexture.ReleaseTemporary(this.JNBJMFLOHAM);
				}
				if (this.EHOBLPKPENF != null)
				{
					RenderTexture.ReleaseTemporary(this.EHOBLPKPENF);
				}
				this.JNBJMFLOHAM = null;
				this.EHOBLPKPENF = null;
			}

			// Token: 0x0601184A RID: 71754 RVA: 0x007D3078 File Offset: 0x007D1278
			public float FJGGOHJOKDM(float JPGIGABPGII, float OGIMHFCCIGH)
			{
				if (Mathf.Approximately(this.ANMILMGHLJI, 455f))
				{
					return 1425f;
				}
				float num = Mathf.Lerp(363f, 1079f, JPGIGABPGII);
				return Mathf.Exp((this.ANMILMGHLJI - OGIMHFCCIGH) * num);
			}

			// Token: 0x0601184B RID: 71755 RVA: 0x007D30C0 File Offset: 0x007D12C0
			public void KPDKCAAIMIN(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, Material MHNAJNGGDFJ)
			{
				this.DHHJJKHDHJC();
				this.JNBJMFLOHAM = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 1, (RenderTextureFormat)49, RenderTextureReadWrite.Linear);
				this.EHOBLPKPENF = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 0, (RenderTextureFormat)(-67), RenderTextureReadWrite.Default);
				this.JNBJMFLOHAM.filterMode = FilterMode.Bilinear;
				this.EHOBLPKPENF.filterMode = FilterMode.Bilinear;
				if (this.AKNMAGILBHJ == null)
				{
					this.AKNMAGILBHJ = new RenderTargetIdentifier[3];
				}
				this.AKNMAGILBHJ[1] = this.JNBJMFLOHAM;
				this.AKNMAGILBHJ[0] = this.EHOBLPKPENF;
				ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
				ECKPLMDEJFD.SetRenderTarget(this.AKNMAGILBHJ, this.JNBJMFLOHAM);
				ECKPLMDEJFD.DrawMesh(CDBICMCJFCE.BHBBKCJAMNO, Matrix4x4.identity, MHNAJNGGDFJ, 0, 1);
				this.ANMILMGHLJI = Time.time;
			}

			// Token: 0x0601184C RID: 71756 RVA: 0x007D3194 File Offset: 0x007D1394
			public void KDIKGBOCCBL(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, RenderTextureFormat LJCEDKCLBDB)
			{
				this.DEGAHLNIMMI();
				this.JNBJMFLOHAM = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 1, LJCEDKCLBDB);
				this.JNBJMFLOHAM.filterMode = FilterMode.Point;
				ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
				ECKPLMDEJFD.Blit(JONJODLFAEN, this.JNBJMFLOHAM);
				this.ANMILMGHLJI = Time.time;
			}

			// Token: 0x0601184D RID: 71757 RVA: 0x007D31F0 File Offset: 0x007D13F0
			public void PMNJNICHBJD(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, Material MHNAJNGGDFJ)
			{
				this.PKNMHMFNAGP();
				this.JNBJMFLOHAM = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 1, (RenderTextureFormat)(-16), RenderTextureReadWrite.Default);
				this.EHOBLPKPENF = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 0, (RenderTextureFormat)(-25), RenderTextureReadWrite.Default);
				this.JNBJMFLOHAM.filterMode = FilterMode.Bilinear;
				this.EHOBLPKPENF.filterMode = FilterMode.Point;
				if (this.AKNMAGILBHJ == null)
				{
					this.AKNMAGILBHJ = new RenderTargetIdentifier[3];
				}
				this.AKNMAGILBHJ[1] = this.JNBJMFLOHAM;
				this.AKNMAGILBHJ[0] = this.EHOBLPKPENF;
				ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
				ECKPLMDEJFD.SetRenderTarget(this.AKNMAGILBHJ, this.JNBJMFLOHAM);
				ECKPLMDEJFD.DrawMesh(CDBICMCJFCE.BHBBKCJAMNO, Matrix4x4.identity, MHNAJNGGDFJ, 1, 7);
				this.ANMILMGHLJI = Time.time;
			}

			// Token: 0x0601184E RID: 71758 RVA: 0x007D32C4 File Offset: 0x007D14C4
			public float IOFFOIBDNLP(float JPGIGABPGII, float OGIMHFCCIGH)
			{
				if (Mathf.Approximately(this.ANMILMGHLJI, 1689f))
				{
					return 1831f;
				}
				float num = Mathf.Lerp(709f, 93f, JPGIGABPGII);
				return Mathf.Exp((this.ANMILMGHLJI - OGIMHFCCIGH) * num);
			}

			// Token: 0x0601184F RID: 71759 RVA: 0x007D330C File Offset: 0x007D150C
			public float IOILOHKDLEL(float JPGIGABPGII, float OGIMHFCCIGH)
			{
				if (Mathf.Approximately(this.ANMILMGHLJI, 1281f))
				{
					return 1709f;
				}
				float num = Mathf.Lerp(917f, 653f, JPGIGABPGII);
				return Mathf.Exp((this.ANMILMGHLJI - OGIMHFCCIGH) * num);
			}

			// Token: 0x06011850 RID: 71760 RVA: 0x007D3354 File Offset: 0x007D1554
			public void DPIFMGDFBGA()
			{
				if (this.JNBJMFLOHAM != null)
				{
					RenderTexture.ReleaseTemporary(this.JNBJMFLOHAM);
				}
				if (this.EHOBLPKPENF != null)
				{
					RenderTexture.ReleaseTemporary(this.EHOBLPKPENF);
				}
				this.JNBJMFLOHAM = null;
				this.EHOBLPKPENF = null;
			}

			// Token: 0x06011851 RID: 71761 RVA: 0x007D33A4 File Offset: 0x007D15A4
			public void KPJDEDNCOGD()
			{
				if (this.JNBJMFLOHAM != null)
				{
					RenderTexture.ReleaseTemporary(this.JNBJMFLOHAM);
				}
				if (this.EHOBLPKPENF != null)
				{
					RenderTexture.ReleaseTemporary(this.EHOBLPKPENF);
				}
				this.JNBJMFLOHAM = null;
				this.EHOBLPKPENF = null;
			}

			// Token: 0x06011852 RID: 71762 RVA: 0x007D33F4 File Offset: 0x007D15F4
			public void DNAMLLCOLDD(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, RenderTextureFormat LJCEDKCLBDB)
			{
				this.KLOJCIBDJIJ();
				this.JNBJMFLOHAM = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 1, LJCEDKCLBDB);
				this.JNBJMFLOHAM.filterMode = FilterMode.Bilinear;
				ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
				ECKPLMDEJFD.Blit(JONJODLFAEN, this.JNBJMFLOHAM);
				this.ANMILMGHLJI = Time.time;
			}

			// Token: 0x06011853 RID: 71763 RVA: 0x007D3450 File Offset: 0x007D1650
			public void HCJNBEAABAF()
			{
				if (this.JNBJMFLOHAM != null)
				{
					RenderTexture.ReleaseTemporary(this.JNBJMFLOHAM);
				}
				if (this.EHOBLPKPENF != null)
				{
					RenderTexture.ReleaseTemporary(this.EHOBLPKPENF);
				}
				this.JNBJMFLOHAM = null;
				this.EHOBLPKPENF = null;
			}

			// Token: 0x06011854 RID: 71764 RVA: 0x007D34A0 File Offset: 0x007D16A0
			public void LPFBCFKJGAK(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, Material MHNAJNGGDFJ)
			{
				this.KOMNGAMPJEF();
				this.JNBJMFLOHAM = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 0, (RenderTextureFormat)(-107), RenderTextureReadWrite.Default);
				this.EHOBLPKPENF = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 0, (RenderTextureFormat)(-119), RenderTextureReadWrite.Default);
				this.JNBJMFLOHAM.filterMode = FilterMode.Bilinear;
				this.EHOBLPKPENF.filterMode = FilterMode.Point;
				if (this.AKNMAGILBHJ == null)
				{
					this.AKNMAGILBHJ = new RenderTargetIdentifier[8];
				}
				this.AKNMAGILBHJ[1] = this.JNBJMFLOHAM;
				this.AKNMAGILBHJ[0] = this.EHOBLPKPENF;
				ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
				ECKPLMDEJFD.SetRenderTarget(this.AKNMAGILBHJ, this.JNBJMFLOHAM);
				ECKPLMDEJFD.DrawMesh(CDBICMCJFCE.BHBBKCJAMNO, Matrix4x4.identity, MHNAJNGGDFJ, 0, 1);
				this.ANMILMGHLJI = Time.time;
			}

			// Token: 0x06011855 RID: 71765 RVA: 0x007D3574 File Offset: 0x007D1774
			public void PKNMHMFNAGP()
			{
				if (this.JNBJMFLOHAM != null)
				{
					RenderTexture.ReleaseTemporary(this.JNBJMFLOHAM);
				}
				if (this.EHOBLPKPENF != null)
				{
					RenderTexture.ReleaseTemporary(this.EHOBLPKPENF);
				}
				this.JNBJMFLOHAM = null;
				this.EHOBLPKPENF = null;
			}

			// Token: 0x06011856 RID: 71766 RVA: 0x007D35C4 File Offset: 0x007D17C4
			public void EBALFFJGGKF(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, RenderTextureFormat LJCEDKCLBDB)
			{
				this.OFKHPBDDKHJ();
				this.JNBJMFLOHAM = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 0, LJCEDKCLBDB);
				this.JNBJMFLOHAM.filterMode = FilterMode.Point;
				ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
				ECKPLMDEJFD.Blit(JONJODLFAEN, this.JNBJMFLOHAM);
				this.ANMILMGHLJI = Time.time;
			}

			// Token: 0x06011857 RID: 71767 RVA: 0x007D3620 File Offset: 0x007D1820
			public void OOGHOPOLNDB()
			{
				if (this.JNBJMFLOHAM != null)
				{
					RenderTexture.ReleaseTemporary(this.JNBJMFLOHAM);
				}
				if (this.EHOBLPKPENF != null)
				{
					RenderTexture.ReleaseTemporary(this.EHOBLPKPENF);
				}
				this.JNBJMFLOHAM = null;
				this.EHOBLPKPENF = null;
			}

			// Token: 0x06011858 RID: 71768 RVA: 0x007D3670 File Offset: 0x007D1870
			public void LCECJJGCMKJ(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, Material MHNAJNGGDFJ)
			{
				this.BPIPEGPEKLO();
				this.JNBJMFLOHAM = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 0, (RenderTextureFormat)(-33), RenderTextureReadWrite.Linear);
				this.EHOBLPKPENF = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 1, (RenderTextureFormat)(-36), RenderTextureReadWrite.Linear);
				this.JNBJMFLOHAM.filterMode = FilterMode.Point;
				this.EHOBLPKPENF.filterMode = FilterMode.Bilinear;
				if (this.AKNMAGILBHJ == null)
				{
					this.AKNMAGILBHJ = new RenderTargetIdentifier[2];
				}
				this.AKNMAGILBHJ[0] = this.JNBJMFLOHAM;
				this.AKNMAGILBHJ[0] = this.EHOBLPKPENF;
				ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
				ECKPLMDEJFD.SetRenderTarget(this.AKNMAGILBHJ, this.JNBJMFLOHAM);
				ECKPLMDEJFD.DrawMesh(CDBICMCJFCE.BHBBKCJAMNO, Matrix4x4.identity, MHNAJNGGDFJ, 1, 7);
				this.ANMILMGHLJI = Time.time;
			}

			// Token: 0x06011859 RID: 71769 RVA: 0x007D3744 File Offset: 0x007D1944
			public void EEEANIKCHLK(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, Material MHNAJNGGDFJ)
			{
				this.BPIPEGPEKLO();
				this.JNBJMFLOHAM = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 1, RenderTextureFormat.ARGB4444, RenderTextureReadWrite.Default);
				this.EHOBLPKPENF = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 0, (RenderTextureFormat)43, RenderTextureReadWrite.Linear);
				this.JNBJMFLOHAM.filterMode = FilterMode.Bilinear;
				this.EHOBLPKPENF.filterMode = FilterMode.Point;
				if (this.AKNMAGILBHJ == null)
				{
					this.AKNMAGILBHJ = new RenderTargetIdentifier[3];
				}
				this.AKNMAGILBHJ[0] = this.JNBJMFLOHAM;
				this.AKNMAGILBHJ[1] = this.EHOBLPKPENF;
				ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
				ECKPLMDEJFD.SetRenderTarget(this.AKNMAGILBHJ, this.JNBJMFLOHAM);
				ECKPLMDEJFD.DrawMesh(CDBICMCJFCE.BHBBKCJAMNO, Matrix4x4.identity, MHNAJNGGDFJ, 0, 6);
				this.ANMILMGHLJI = Time.time;
			}

			// Token: 0x0601185A RID: 71770 RVA: 0x007D3818 File Offset: 0x007D1A18
			public void KFEKLEKKINB()
			{
				if (this.JNBJMFLOHAM != null)
				{
					RenderTexture.ReleaseTemporary(this.JNBJMFLOHAM);
				}
				if (this.EHOBLPKPENF != null)
				{
					RenderTexture.ReleaseTemporary(this.EHOBLPKPENF);
				}
				this.JNBJMFLOHAM = null;
				this.EHOBLPKPENF = null;
			}

			// Token: 0x0601185B RID: 71771 RVA: 0x007D3868 File Offset: 0x007D1A68
			public void DIDIKNIHGMA(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, RenderTextureFormat LJCEDKCLBDB)
			{
				this.KLOJCIBDJIJ();
				this.JNBJMFLOHAM = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 1, LJCEDKCLBDB);
				this.JNBJMFLOHAM.filterMode = FilterMode.Bilinear;
				ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
				ECKPLMDEJFD.Blit(JONJODLFAEN, this.JNBJMFLOHAM);
				this.ANMILMGHLJI = Time.time;
			}

			// Token: 0x0601185C RID: 71772 RVA: 0x007D38C4 File Offset: 0x007D1AC4
			public void KLOJCIBDJIJ()
			{
				if (this.JNBJMFLOHAM != null)
				{
					RenderTexture.ReleaseTemporary(this.JNBJMFLOHAM);
				}
				if (this.EHOBLPKPENF != null)
				{
					RenderTexture.ReleaseTemporary(this.EHOBLPKPENF);
				}
				this.JNBJMFLOHAM = null;
				this.EHOBLPKPENF = null;
			}

			// Token: 0x0601185D RID: 71773 RVA: 0x007D3914 File Offset: 0x007D1B14
			public void BJNPBKIODDP(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, Material MHNAJNGGDFJ)
			{
				this.KLOJCIBDJIJ();
				this.JNBJMFLOHAM = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 1, RenderTextureFormat.RGInt, RenderTextureReadWrite.Default);
				this.EHOBLPKPENF = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 1, (RenderTextureFormat)(-16), RenderTextureReadWrite.Linear);
				this.JNBJMFLOHAM.filterMode = FilterMode.Bilinear;
				this.EHOBLPKPENF.filterMode = FilterMode.Point;
				if (this.AKNMAGILBHJ == null)
				{
					this.AKNMAGILBHJ = new RenderTargetIdentifier[1];
				}
				this.AKNMAGILBHJ[0] = this.JNBJMFLOHAM;
				this.AKNMAGILBHJ[1] = this.EHOBLPKPENF;
				ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
				ECKPLMDEJFD.SetRenderTarget(this.AKNMAGILBHJ, this.JNBJMFLOHAM);
				ECKPLMDEJFD.DrawMesh(CDBICMCJFCE.BHBBKCJAMNO, Matrix4x4.identity, MHNAJNGGDFJ, 0, 6);
				this.ANMILMGHLJI = Time.time;
			}

			// Token: 0x0601185E RID: 71774 RVA: 0x007D39E8 File Offset: 0x007D1BE8
			public float EOKGNMHMOPB(float JPGIGABPGII, float OGIMHFCCIGH)
			{
				if (Mathf.Approximately(this.ANMILMGHLJI, 33f))
				{
					return 734f;
				}
				float num = Mathf.Lerp(1261f, 856f, JPGIGABPGII);
				return Mathf.Exp((this.ANMILMGHLJI - OGIMHFCCIGH) * num);
			}

			// Token: 0x0601185F RID: 71775 RVA: 0x007D3A30 File Offset: 0x007D1C30
			public float LDGJBGEGCEH(float JPGIGABPGII, float OGIMHFCCIGH)
			{
				if (Mathf.Approximately(this.ANMILMGHLJI, 1381f))
				{
					return 1214f;
				}
				float num = Mathf.Lerp(72f, 1961f, JPGIGABPGII);
				return Mathf.Exp((this.ANMILMGHLJI - OGIMHFCCIGH) * num);
			}

			// Token: 0x06011860 RID: 71776 RVA: 0x007D3A78 File Offset: 0x007D1C78
			public float IGHPANOGKLE(float JPGIGABPGII, float OGIMHFCCIGH)
			{
				if (Mathf.Approximately(this.ANMILMGHLJI, 1620f))
				{
					return 1146f;
				}
				float num = Mathf.Lerp(792f, 556f, JPGIGABPGII);
				return Mathf.Exp((this.ANMILMGHLJI - OGIMHFCCIGH) * num);
			}

			// Token: 0x06011861 RID: 71777 RVA: 0x007D3AC0 File Offset: 0x007D1CC0
			public void OHFIHGNDMBD(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, Material MHNAJNGGDFJ)
			{
				this.DGEJEFIBFJP();
				this.JNBJMFLOHAM = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 1, (RenderTextureFormat)(-5), RenderTextureReadWrite.Linear);
				this.EHOBLPKPENF = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 1, (RenderTextureFormat)(-47), RenderTextureReadWrite.Linear);
				this.JNBJMFLOHAM.filterMode = FilterMode.Point;
				this.EHOBLPKPENF.filterMode = FilterMode.Point;
				if (this.AKNMAGILBHJ == null)
				{
					this.AKNMAGILBHJ = new RenderTargetIdentifier[4];
				}
				this.AKNMAGILBHJ[1] = this.JNBJMFLOHAM;
				this.AKNMAGILBHJ[0] = this.EHOBLPKPENF;
				ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
				ECKPLMDEJFD.SetRenderTarget(this.AKNMAGILBHJ, this.JNBJMFLOHAM);
				ECKPLMDEJFD.DrawMesh(CDBICMCJFCE.BHBBKCJAMNO, Matrix4x4.identity, MHNAJNGGDFJ, 1, 4);
				this.ANMILMGHLJI = Time.time;
			}

			// Token: 0x06011862 RID: 71778 RVA: 0x007D3B94 File Offset: 0x007D1D94
			public void DHHJJKHDHJC()
			{
				if (this.JNBJMFLOHAM != null)
				{
					RenderTexture.ReleaseTemporary(this.JNBJMFLOHAM);
				}
				if (this.EHOBLPKPENF != null)
				{
					RenderTexture.ReleaseTemporary(this.EHOBLPKPENF);
				}
				this.JNBJMFLOHAM = null;
				this.EHOBLPKPENF = null;
			}

			// Token: 0x06011863 RID: 71779 RVA: 0x007D3BE4 File Offset: 0x007D1DE4
			public void GACEPIEIBLG(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, RenderTextureFormat LJCEDKCLBDB)
			{
				this.KEGPIBLIDGJ();
				this.JNBJMFLOHAM = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 0, LJCEDKCLBDB);
				this.JNBJMFLOHAM.filterMode = FilterMode.Bilinear;
				ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
				ECKPLMDEJFD.Blit(JONJODLFAEN, this.JNBJMFLOHAM);
				this.ANMILMGHLJI = Time.time;
			}

			// Token: 0x06011864 RID: 71780 RVA: 0x007D3C40 File Offset: 0x007D1E40
			public void GHDNONCJJDG(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, Material MHNAJNGGDFJ)
			{
				this.KPJDEDNCOGD();
				this.JNBJMFLOHAM = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 0, (RenderTextureFormat)(-9), RenderTextureReadWrite.Linear);
				this.EHOBLPKPENF = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 0, (RenderTextureFormat)78, RenderTextureReadWrite.Linear);
				this.JNBJMFLOHAM.filterMode = FilterMode.Point;
				this.EHOBLPKPENF.filterMode = FilterMode.Bilinear;
				if (this.AKNMAGILBHJ == null)
				{
					this.AKNMAGILBHJ = new RenderTargetIdentifier[2];
				}
				this.AKNMAGILBHJ[1] = this.JNBJMFLOHAM;
				this.AKNMAGILBHJ[0] = this.EHOBLPKPENF;
				ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
				ECKPLMDEJFD.SetRenderTarget(this.AKNMAGILBHJ, this.JNBJMFLOHAM);
				ECKPLMDEJFD.DrawMesh(CDBICMCJFCE.BHBBKCJAMNO, Matrix4x4.identity, MHNAJNGGDFJ, 0, 0);
				this.ANMILMGHLJI = Time.time;
			}

			// Token: 0x06011865 RID: 71781 RVA: 0x007D3D14 File Offset: 0x007D1F14
			public float FCCKHKPBDDP(float JPGIGABPGII, float OGIMHFCCIGH)
			{
				if (Mathf.Approximately(this.ANMILMGHLJI, 193f))
				{
					return 1145f;
				}
				float num = Mathf.Lerp(420f, 1350f, JPGIGABPGII);
				return Mathf.Exp((this.ANMILMGHLJI - OGIMHFCCIGH) * num);
			}

			// Token: 0x06011866 RID: 71782 RVA: 0x007D3D5C File Offset: 0x007D1F5C
			public void JPCGNHHEJNB(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, RenderTextureFormat LJCEDKCLBDB)
			{
				this.KOMNGAMPJEF();
				this.JNBJMFLOHAM = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 0, LJCEDKCLBDB);
				this.JNBJMFLOHAM.filterMode = FilterMode.Point;
				ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
				ECKPLMDEJFD.Blit(JONJODLFAEN, this.JNBJMFLOHAM);
				this.ANMILMGHLJI = Time.time;
			}

			// Token: 0x06011867 RID: 71783 RVA: 0x007D3DB8 File Offset: 0x007D1FB8
			public void MPIABDEBIKN(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, RenderTextureFormat LJCEDKCLBDB)
			{
				this.DEGAHLNIMMI();
				this.JNBJMFLOHAM = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 0, LJCEDKCLBDB);
				this.JNBJMFLOHAM.filterMode = FilterMode.Point;
				ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
				ECKPLMDEJFD.Blit(JONJODLFAEN, this.JNBJMFLOHAM);
				this.ANMILMGHLJI = Time.time;
			}

			// Token: 0x06011868 RID: 71784 RVA: 0x007D3E14 File Offset: 0x007D2014
			public float EEGJCGPBFPA(float JPGIGABPGII, float OGIMHFCCIGH)
			{
				if (Mathf.Approximately(this.ANMILMGHLJI, 0f))
				{
					return 0f;
				}
				float num = Mathf.Lerp(80f, 16f, JPGIGABPGII);
				return Mathf.Exp((this.ANMILMGHLJI - OGIMHFCCIGH) * num);
			}

			// Token: 0x06011869 RID: 71785 RVA: 0x007D3E5C File Offset: 0x007D205C
			public void OOAPIMIAEBO()
			{
				if (this.JNBJMFLOHAM != null)
				{
					RenderTexture.ReleaseTemporary(this.JNBJMFLOHAM);
				}
				if (this.EHOBLPKPENF != null)
				{
					RenderTexture.ReleaseTemporary(this.EHOBLPKPENF);
				}
				this.JNBJMFLOHAM = null;
				this.EHOBLPKPENF = null;
			}

			// Token: 0x0601186A RID: 71786 RVA: 0x007D3EAC File Offset: 0x007D20AC
			public void JIDKDHFPPJI(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, RenderTextureFormat LJCEDKCLBDB)
			{
				this.KPJDEDNCOGD();
				this.JNBJMFLOHAM = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 0, LJCEDKCLBDB);
				this.JNBJMFLOHAM.filterMode = FilterMode.Bilinear;
				ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
				ECKPLMDEJFD.Blit(JONJODLFAEN, this.JNBJMFLOHAM);
				this.ANMILMGHLJI = Time.time;
			}

			// Token: 0x0601186B RID: 71787 RVA: 0x007D3F08 File Offset: 0x007D2108
			public void APPJJGEPFAI(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, RenderTextureFormat LJCEDKCLBDB)
			{
				this.KPJDEDNCOGD();
				this.JNBJMFLOHAM = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 1, LJCEDKCLBDB);
				this.JNBJMFLOHAM.filterMode = FilterMode.Point;
				ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
				ECKPLMDEJFD.Blit(JONJODLFAEN, this.JNBJMFLOHAM);
				this.ANMILMGHLJI = Time.time;
			}

			// Token: 0x0601186C RID: 71788 RVA: 0x007D3F64 File Offset: 0x007D2164
			public void LGGCAHEIPHP(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, Material MHNAJNGGDFJ)
			{
				this.KPJDEDNCOGD();
				this.JNBJMFLOHAM = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 1, (RenderTextureFormat)(-87), RenderTextureReadWrite.Default);
				this.EHOBLPKPENF = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 1, (RenderTextureFormat)76, RenderTextureReadWrite.Linear);
				this.JNBJMFLOHAM.filterMode = FilterMode.Point;
				this.EHOBLPKPENF.filterMode = FilterMode.Bilinear;
				if (this.AKNMAGILBHJ == null)
				{
					this.AKNMAGILBHJ = new RenderTargetIdentifier[0];
				}
				this.AKNMAGILBHJ[1] = this.JNBJMFLOHAM;
				this.AKNMAGILBHJ[0] = this.EHOBLPKPENF;
				ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
				ECKPLMDEJFD.SetRenderTarget(this.AKNMAGILBHJ, this.JNBJMFLOHAM);
				ECKPLMDEJFD.DrawMesh(CDBICMCJFCE.BHBBKCJAMNO, Matrix4x4.identity, MHNAJNGGDFJ, 1, 5);
				this.ANMILMGHLJI = Time.time;
			}

			// Token: 0x0601186D RID: 71789 RVA: 0x007D4038 File Offset: 0x007D2238
			public void EPNLHMECDEF()
			{
				if (this.JNBJMFLOHAM != null)
				{
					RenderTexture.ReleaseTemporary(this.JNBJMFLOHAM);
				}
				if (this.EHOBLPKPENF != null)
				{
					RenderTexture.ReleaseTemporary(this.EHOBLPKPENF);
				}
				this.JNBJMFLOHAM = null;
				this.EHOBLPKPENF = null;
			}

			// Token: 0x0601186E RID: 71790 RVA: 0x007D4088 File Offset: 0x007D2288
			public void KIMBLOPLKNJ(CommandBuffer ECKPLMDEJFD, RenderTargetIdentifier JONJODLFAEN, int NMEBEEHCALN, int ILLKFNCFGMP, Material MHNAJNGGDFJ)
			{
				this.DHHJJKHDHJC();
				this.JNBJMFLOHAM = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 0, RenderTextureFormat.ARGB64, RenderTextureReadWrite.Linear);
				this.EHOBLPKPENF = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, 1, (RenderTextureFormat)(-50), RenderTextureReadWrite.Default);
				this.JNBJMFLOHAM.filterMode = FilterMode.Point;
				this.EHOBLPKPENF.filterMode = FilterMode.Point;
				if (this.AKNMAGILBHJ == null)
				{
					this.AKNMAGILBHJ = new RenderTargetIdentifier[7];
				}
				this.AKNMAGILBHJ[1] = this.JNBJMFLOHAM;
				this.AKNMAGILBHJ[0] = this.EHOBLPKPENF;
				ECKPLMDEJFD.SetGlobalTexture(DGIEACBKFMJ.BNEACEICMJJ.OCMLEEAPHNB, JONJODLFAEN);
				ECKPLMDEJFD.SetRenderTarget(this.AKNMAGILBHJ, this.JNBJMFLOHAM);
				ECKPLMDEJFD.DrawMesh(CDBICMCJFCE.BHBBKCJAMNO, Matrix4x4.identity, MHNAJNGGDFJ, 1, 7);
				this.ANMILMGHLJI = Time.time;
			}

			// Token: 0x0400248C RID: 9356
			public RenderTexture JNBJMFLOHAM;

			// Token: 0x0400248D RID: 9357
			public RenderTexture EHOBLPKPENF;

			// Token: 0x0400248E RID: 9358
			private float ANMILMGHLJI;

			// Token: 0x0400248F RID: 9359
			private RenderTargetIdentifier[] AKNMAGILBHJ;
		}
	}
}
