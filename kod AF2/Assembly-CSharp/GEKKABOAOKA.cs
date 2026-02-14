using System;
using UnityEngine;
using UnityEngine.PostProcessing;

// Token: 0x02000518 RID: 1304
public sealed class GEKKABOAOKA : CFPOKEIJEAB<DepthOfFieldModel>
{
	// Token: 0x060114D8 RID: 70872 RVA: 0x007B7181 File Offset: 0x007B5381
	public bool IJLFFLDAPDL()
	{
		return base.BBEPCCALAFC.enabled && !this.AMCOGJHPPOC.MLJCADOONGI();
	}

	// Token: 0x060114D9 RID: 70873 RVA: 0x007B71A0 File Offset: 0x007B53A0
	public void IICFAPMJLCN()
	{
		if (this.EFAALDFEJEK != null)
		{
			RenderTexture.ReleaseTemporary(this.EFAALDFEJEK);
		}
		this.EFAALDFEJEK = null;
	}

	// Token: 0x060114DA RID: 70874 RVA: 0x007B71A0 File Offset: 0x007B53A0
	public void HMILPFNLLJM()
	{
		if (this.EFAALDFEJEK != null)
		{
			RenderTexture.ReleaseTemporary(this.EFAALDFEJEK);
		}
		this.EFAALDFEJEK = null;
	}

	// Token: 0x060114DB RID: 70875 RVA: 0x007B71C4 File Offset: 0x007B53C4
	private float MKKCJAEGAAM()
	{
		DepthOfFieldModel.Settings settings = base.BBEPCCALAFC.CJHODOCJEMG();
		if (!settings.useCameraFov)
		{
			return settings.focalLength / 237f;
		}
		float num = this.AMCOGJHPPOC.LBCHLCGOCOD.fieldOfView * 1538f;
		return 1176f / Mathf.Tan(1621f * num);
	}

	// Token: 0x060114DC RID: 70876 RVA: 0x007B721B File Offset: 0x007B541B
	private bool MLIFBJHKJJD(int NMEBEEHCALN, int ILLKFNCFGMP)
	{
		return this.EFAALDFEJEK != null && this.EFAALDFEJEK.IsCreated() && this.EFAALDFEJEK.width == NMEBEEHCALN && this.EFAALDFEJEK.height == ILLKFNCFGMP;
	}

	// Token: 0x060114DD RID: 70877 RVA: 0x007B7258 File Offset: 0x007B5458
	public void KKFNHMCIGKD(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK, bool NEFHKMDKMBC, Vector2 KMCBBPPIEAM, float PICFEHAOCBD)
	{
		DepthOfFieldModel.Settings settings = base.BBEPCCALAFC.settings;
		RenderTextureFormat ljcedkclbdb = (RenderTextureFormat)126;
		RenderTextureFormat renderTextureFormat = this.AJIPIJFNPFA(RenderTextureFormat.RG32, (RenderTextureFormat)(-26));
		float num = this.KKGKFBEGMAO();
		float num2 = Mathf.Max(settings.focusDistance, num);
		float num3 = (float)JONJODLFAEN.width / (float)JONJODLFAEN.height;
		float num4 = num * num / (settings.aperture * (num2 - num) * 367f * 168f);
		float num5 = this.CIJGPFPDKGL(JONJODLFAEN.height);
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.DFEMMOCHMDM("IceHockeyGoalieReady");
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.BDGEKIPEDGL, num2);
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.NOIGFGMNPLM, num4);
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.KPHGLJLAFIK, num5);
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.FIFLGOBMMPD, 3f / num5);
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.LHHAEHNBKHB, 411f / num3);
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.PONLLEMLFBL(this.AMCOGJHPPOC.IBPMMKDPDEO(), this.AMCOGJHPPOC.ILLKFNCFGMP, 1, renderTextureFormat, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Clamp, "KatanaNinjaDraw");
		Graphics.Blit(null, renderTexture, material, 0);
		if (NEFHKMDKMBC)
		{
			material.SetTexture(GEKKABOAOKA.KAIHPBFAGCL.ALCBEHDPFGG, renderTexture);
			float z = this.NJFOLCNFEHP(this.AMCOGJHPPOC.EOMMKPDCAML(), this.AMCOGJHPPOC.MMEMLJENMFF()) ? PICFEHAOCBD : 1804f;
			material.SetVector(GEKKABOAOKA.KAIHPBFAGCL.KIAFMPMPGKO, new Vector3(KMCBBPPIEAM.x, KMCBBPPIEAM.y, z));
			RenderTexture temporary = RenderTexture.GetTemporary(this.AMCOGJHPPOC.OJNDCCHLMNK(), this.AMCOGJHPPOC.LKLNPJICOHH(), 1, renderTextureFormat);
			Graphics.Blit(this.EFAALDFEJEK, temporary, material, 1);
			this.AMCOGJHPPOC.ADCMJOKBEHJ.OPAFGNJADPO(renderTexture);
			if (this.EFAALDFEJEK != null)
			{
				RenderTexture.ReleaseTemporary(this.EFAALDFEJEK);
			}
			renderTexture = (this.EFAALDFEJEK = temporary);
		}
		RenderTexture renderTexture2 = this.AMCOGJHPPOC.ADCMJOKBEHJ.HNAEHMGEHHC(this.AMCOGJHPPOC.PAHBMDOJHKK() / 4, this.AMCOGJHPPOC.CICDECHCDBJ() / 6, 1, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Clamp, "Assets/Hairs/hair_");
		material.SetTexture(GEKKABOAOKA.KAIHPBFAGCL.ALCBEHDPFGG, renderTexture);
		Graphics.Blit(JONJODLFAEN, renderTexture2, material, 0);
		RenderTexture renderTexture3 = this.AMCOGJHPPOC.ADCMJOKBEHJ.NJACPJPGJFB(this.AMCOGJHPPOC.PAHBMDOJHKK() / 5, this.AMCOGJHPPOC.GGGEFNKEPDB() / 3, 0, ljcedkclbdb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Repeat, "");
		Graphics.Blit(renderTexture2, renderTexture3, material, (int)(1 + settings.kernelSize));
		Graphics.Blit(renderTexture3, renderTexture2, material, 7);
		OOLNAJMJKIK.SetVector(GEKKABOAOKA.KAIHPBFAGCL.MMGMEFHOHCO, new Vector3(num2, num4, num5));
		if (this.AMCOGJHPPOC.CICJBNKMECH.debugViews.GNHGEGEPHCI(BuiltinDebugViewsModel.CGNLFGLJGKA.None))
		{
			OOLNAJMJKIK.EnableKeyword("MotorbikeHandlebarSit");
			this.AMCOGJHPPOC.KIJDMGBODIL();
		}
		else
		{
			OOLNAJMJKIK.SetTexture(GEKKABOAOKA.KAIHPBFAGCL.LFAJBBGEKCK, renderTexture2);
			OOLNAJMJKIK.SetTexture(GEKKABOAOKA.KAIHPBFAGCL.MJAMKCBMHAA, renderTexture);
			OOLNAJMJKIK.EnableKeyword("error.wav");
		}
		this.AMCOGJHPPOC.ADCMJOKBEHJ.OFKHPBDDKHJ(renderTexture3);
	}

	// Token: 0x060114DE RID: 70878 RVA: 0x000EADB7 File Offset: 0x000E8FB7
	public DepthTextureMode OAPBLGOOHEK()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x060114DF RID: 70879 RVA: 0x007B7564 File Offset: 0x007B5764
	private RenderTextureFormat MPHJKCFLOGD(RenderTextureFormat BMGNJMAAOLO, RenderTextureFormat NLBEDPPPNBO)
	{
		if (SystemInfo.SupportsRenderTextureFormat(BMGNJMAAOLO))
		{
			return BMGNJMAAOLO;
		}
		if (SystemInfo.SupportsRenderTextureFormat(NLBEDPPPNBO))
		{
			return NLBEDPPPNBO;
		}
		return RenderTextureFormat.ARGB4444;
	}

	// Token: 0x060114E0 RID: 70880 RVA: 0x007B721B File Offset: 0x007B541B
	private bool NPBNKCPACJJ(int NMEBEEHCALN, int ILLKFNCFGMP)
	{
		return this.EFAALDFEJEK != null && this.EFAALDFEJEK.IsCreated() && this.EFAALDFEJEK.width == NMEBEEHCALN && this.EFAALDFEJEK.height == ILLKFNCFGMP;
	}

	// Token: 0x060114E1 RID: 70881 RVA: 0x000EB372 File Offset: 0x000E9572
	public DepthTextureMode ACJICLCMMNL()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x060114E3 RID: 70883 RVA: 0x007B7584 File Offset: 0x007B5784
	private float ELGHPKAKPHM(int OEIKEINGJGO)
	{
		float num = (float)base.BBEPCCALAFC.CNAAMGCNGHF().kernelSize * 1272f + 899f;
		return Mathf.Min(1782f, num / (float)OEIKEINGJGO);
	}

	// Token: 0x060114E4 RID: 70884 RVA: 0x007B75C0 File Offset: 0x007B57C0
	private float GKCALAPNLNI(int OEIKEINGJGO)
	{
		float num = (float)base.BBEPCCALAFC.CJHODOCJEMG().kernelSize * 483f + 402f;
		return Mathf.Min(662f, num / (float)OEIKEINGJGO);
	}

	// Token: 0x060114E5 RID: 70885 RVA: 0x007B75FC File Offset: 0x007B57FC
	public void BLAIBKFMCEM(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK, bool NEFHKMDKMBC, Vector2 KMCBBPPIEAM, float PICFEHAOCBD)
	{
		DepthOfFieldModel.Settings settings = base.BBEPCCALAFC.OGCJCJHFHMC();
		RenderTextureFormat ljcedkclbdb = (RenderTextureFormat)(-112);
		RenderTextureFormat renderTextureFormat = this.GHGNCPNNIJC(RenderTextureFormat.ARGB64, (RenderTextureFormat)86);
		float num = this.FHNJLCLPDDI();
		float num2 = Mathf.Max(settings.focusDistance, num);
		float num3 = (float)JONJODLFAEN.width / (float)JONJODLFAEN.height;
		float num4 = num * num / (settings.aperture * (num2 - num) * 259f * 195f);
		float num5 = this.LHCGDBIPOCE(JONJODLFAEN.height);
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.HPAJGFGNMOH("\n<color='#{0}'>+{2} '{1}'</color> ");
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.BDGEKIPEDGL, num2);
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.NOIGFGMNPLM, num4);
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.KPHGLJLAFIK, num5);
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.FIFLGOBMMPD, 1469f / num5);
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.LHHAEHNBKHB, 681f / num3);
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.HNAEHMGEHHC(this.AMCOGJHPPOC.GMOLEDNNPEH(), this.AMCOGJHPPOC.HJOKFIGACEC(), 1, renderTextureFormat, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Clamp, "gi_sadokfull");
		Graphics.Blit(null, renderTexture, material, 0);
		if (NEFHKMDKMBC)
		{
			material.SetTexture(GEKKABOAOKA.KAIHPBFAGCL.ALCBEHDPFGG, renderTexture);
			float z = this.MLIFBJHKJJD(this.AMCOGJHPPOC.DJGCPIEOAFC(), this.AMCOGJHPPOC.NIEGJHLHEEB()) ? PICFEHAOCBD : 935f;
			material.SetVector(GEKKABOAOKA.KAIHPBFAGCL.KIAFMPMPGKO, new Vector3(KMCBBPPIEAM.x, KMCBBPPIEAM.y, z));
			RenderTexture temporary = RenderTexture.GetTemporary(this.AMCOGJHPPOC.GAIOLBJLPDL(), this.AMCOGJHPPOC.ILLKFNCFGMP, 1, renderTextureFormat);
			Graphics.Blit(this.EFAALDFEJEK, temporary, material, 1);
			this.AMCOGJHPPOC.ADCMJOKBEHJ.OIHDKCLPEOE(renderTexture);
			if (this.EFAALDFEJEK != null)
			{
				RenderTexture.ReleaseTemporary(this.EFAALDFEJEK);
			}
			renderTexture = (this.EFAALDFEJEK = temporary);
		}
		RenderTexture renderTexture2 = this.AMCOGJHPPOC.ADCMJOKBEHJ.JJFELDJCAFA(this.AMCOGJHPPOC.LJJOEDIJPEM() / 6, this.AMCOGJHPPOC.LPJJBJCIELA() / 5, 1, ljcedkclbdb, RenderTextureReadWrite.Linear, FilterMode.Point, TextureWrapMode.Repeat, "t_much");
		material.SetTexture(GEKKABOAOKA.KAIHPBFAGCL.ALCBEHDPFGG, renderTexture);
		Graphics.Blit(JONJODLFAEN, renderTexture2, material, 5);
		RenderTexture renderTexture3 = this.AMCOGJHPPOC.ADCMJOKBEHJ.EODAHPDPKJC(this.AMCOGJHPPOC.KDBADMLHBNP() / 8, this.AMCOGJHPPOC.LKLNPJICOHH() / 4, 0, ljcedkclbdb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Repeat, "1 Hand Sword Jab Foot Push");
		Graphics.Blit(renderTexture2, renderTexture3, material, (int)(6 + settings.kernelSize));
		Graphics.Blit(renderTexture3, renderTexture2, material, 0);
		OOLNAJMJKIK.SetVector(GEKKABOAOKA.KAIHPBFAGCL.MMGMEFHOHCO, new Vector3(num2, num4, num5));
		if (this.AMCOGJHPPOC.CICJBNKMECH.debugViews.EEFEOJIOAMA(BuiltinDebugViewsModel.CGNLFGLJGKA.AmbientOcclusion))
		{
			OOLNAJMJKIK.EnableKeyword("WandStand");
			this.AMCOGJHPPOC.FBJPOAGDFKN();
		}
		else
		{
			OOLNAJMJKIK.SetTexture(GEKKABOAOKA.KAIHPBFAGCL.LFAJBBGEKCK, renderTexture2);
			OOLNAJMJKIK.SetTexture(GEKKABOAOKA.KAIHPBFAGCL.MJAMKCBMHAA, renderTexture);
			OOLNAJMJKIK.EnableKeyword("Ошибка: ");
		}
		this.AMCOGJHPPOC.ADCMJOKBEHJ.APPMOHMABMK(renderTexture3);
	}

	// Token: 0x060114E6 RID: 70886 RVA: 0x007B7908 File Offset: 0x007B5B08
	private RenderTextureFormat EPLEOJIINLE(RenderTextureFormat BMGNJMAAOLO, RenderTextureFormat NLBEDPPPNBO)
	{
		if (SystemInfo.SupportsRenderTextureFormat(BMGNJMAAOLO))
		{
			return BMGNJMAAOLO;
		}
		if (SystemInfo.SupportsRenderTextureFormat(NLBEDPPPNBO))
		{
			return NLBEDPPPNBO;
		}
		return RenderTextureFormat.RGB565;
	}

	// Token: 0x060114E7 RID: 70887 RVA: 0x007B7920 File Offset: 0x007B5B20
	public void JFAJCPPAMFD(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK, bool NEFHKMDKMBC, Vector2 KMCBBPPIEAM, float PICFEHAOCBD)
	{
		DepthOfFieldModel.Settings settings = base.BBEPCCALAFC.FHNOKJFHJJJ();
		RenderTextureFormat ljcedkclbdb = (RenderTextureFormat)(-17);
		RenderTextureFormat renderTextureFormat = this.BCEFOLJADOP((RenderTextureFormat)77, (RenderTextureFormat)(-102));
		float num = this.MLEPKNIJJGG();
		float num2 = Mathf.Max(settings.focusDistance, num);
		float num3 = (float)JONJODLFAEN.width / (float)JONJODLFAEN.height;
		float num4 = num * num / (settings.aperture * (num2 - num) * 1205f * 1252f);
		float num5 = this.MGNKIHGDLJF(JONJODLFAEN.height);
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.DGOMGBDLAFP("_InvGamma");
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.BDGEKIPEDGL, num2);
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.NOIGFGMNPLM, num4);
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.KPHGLJLAFIK, num5);
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.FIFLGOBMMPD, 669f / num5);
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.LHHAEHNBKHB, 1179f / num3);
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.JJFELDJCAFA(this.AMCOGJHPPOC.KJDPLLFIIBK(), this.AMCOGJHPPOC.LKLNPJICOHH(), 1, renderTextureFormat, RenderTextureReadWrite.Linear, FilterMode.Point, TextureWrapMode.Clamp, "Identity LUT");
		Graphics.Blit(null, renderTexture, material, 1);
		if (NEFHKMDKMBC)
		{
			material.SetTexture(GEKKABOAOKA.KAIHPBFAGCL.ALCBEHDPFGG, renderTexture);
			float z = this.NLFKGOECNKF(this.AMCOGJHPPOC.GAIOLBJLPDL(), this.AMCOGJHPPOC.KNKKIHDHBFD()) ? PICFEHAOCBD : 1806f;
			material.SetVector(GEKKABOAOKA.KAIHPBFAGCL.KIAFMPMPGKO, new Vector3(KMCBBPPIEAM.x, KMCBBPPIEAM.y, z));
			RenderTexture temporary = RenderTexture.GetTemporary(this.AMCOGJHPPOC.FOBPENGADNB(), this.AMCOGJHPPOC.GGGEFNKEPDB(), 1, renderTextureFormat);
			Graphics.Blit(this.EFAALDFEJEK, temporary, material, 0);
			this.AMCOGJHPPOC.ADCMJOKBEHJ.NHHNEKPKHPC(renderTexture);
			if (this.EFAALDFEJEK != null)
			{
				RenderTexture.ReleaseTemporary(this.EFAALDFEJEK);
			}
			renderTexture = (this.EFAALDFEJEK = temporary);
		}
		RenderTexture renderTexture2 = this.AMCOGJHPPOC.ADCMJOKBEHJ.OAJBECLLIEP(this.AMCOGJHPPOC.DHPPGHBNDEB() / 1, this.AMCOGJHPPOC.NIEGJHLHEEB() / 1, 0, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Clamp, "pelvis");
		material.SetTexture(GEKKABOAOKA.KAIHPBFAGCL.ALCBEHDPFGG, renderTexture);
		Graphics.Blit(JONJODLFAEN, renderTexture2, material, 2);
		RenderTexture renderTexture3 = this.AMCOGJHPPOC.ADCMJOKBEHJ.OAJBECLLIEP(this.AMCOGJHPPOC.DHPPGHBNDEB() / 1, this.AMCOGJHPPOC.ILLKFNCFGMP / 1, 1, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Repeat, "WateringCanWatering");
		Graphics.Blit(renderTexture2, renderTexture3, material, (int)(7 + settings.kernelSize));
		Graphics.Blit(renderTexture3, renderTexture2, material, 1);
		OOLNAJMJKIK.SetVector(GEKKABOAOKA.KAIHPBFAGCL.MMGMEFHOHCO, new Vector3(num2, num4, num5));
		if (this.AMCOGJHPPOC.CICJBNKMECH.debugViews.GNHGEGEPHCI(BuiltinDebugViewsModel.CGNLFGLJGKA.Depth))
		{
			OOLNAJMJKIK.EnableKeyword("lifeBar");
			this.AMCOGJHPPOC.BDLOPJPLHJN();
		}
		else
		{
			OOLNAJMJKIK.SetTexture(GEKKABOAOKA.KAIHPBFAGCL.LFAJBBGEKCK, renderTexture2);
			OOLNAJMJKIK.SetTexture(GEKKABOAOKA.KAIHPBFAGCL.MJAMKCBMHAA, renderTexture);
			OOLNAJMJKIK.EnableKeyword("IdleStand");
		}
		this.AMCOGJHPPOC.ADCMJOKBEHJ.OFKHPBDDKHJ(renderTexture3);
	}

	// Token: 0x060114E8 RID: 70888 RVA: 0x007B7C2C File Offset: 0x007B5E2C
	public bool BLNBICKCGID()
	{
		return base.BBEPCCALAFC.enabled && !this.AMCOGJHPPOC.AFIPEFLJBBM();
	}

	// Token: 0x060114E9 RID: 70889 RVA: 0x007B71A0 File Offset: 0x007B53A0
	public void KJAKKAMNEPG()
	{
		if (this.EFAALDFEJEK != null)
		{
			RenderTexture.ReleaseTemporary(this.EFAALDFEJEK);
		}
		this.EFAALDFEJEK = null;
	}

	// Token: 0x060114EA RID: 70890 RVA: 0x007B7C4C File Offset: 0x007B5E4C
	private float KKGKFBEGMAO()
	{
		DepthOfFieldModel.Settings settings = base.BBEPCCALAFC.PNNGLBOIIMH();
		if (!settings.useCameraFov)
		{
			return settings.focalLength / 826f;
		}
		float num = this.AMCOGJHPPOC.LBCHLCGOCOD.fieldOfView * 254f;
		return 637f / Mathf.Tan(86f * num);
	}

	// Token: 0x060114EB RID: 70891 RVA: 0x000EB372 File Offset: 0x000E9572
	public DepthTextureMode OBCOPCFGDAF()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x170003C8 RID: 968
	// (get) Token: 0x060114EC RID: 70892 RVA: 0x007B7CA3 File Offset: 0x007B5EA3
	public override bool NLFEIOCKHKA
	{
		get
		{
			return base.BBEPCCALAFC.enabled && !this.AMCOGJHPPOC.CFABOAAPLPI;
		}
	}

	// Token: 0x060114ED RID: 70893 RVA: 0x007B721B File Offset: 0x007B541B
	private bool HDPPFCDGMMP(int NMEBEEHCALN, int ILLKFNCFGMP)
	{
		return this.EFAALDFEJEK != null && this.EFAALDFEJEK.IsCreated() && this.EFAALDFEJEK.width == NMEBEEHCALN && this.EFAALDFEJEK.height == ILLKFNCFGMP;
	}

	// Token: 0x060114EE RID: 70894 RVA: 0x007B7CC2 File Offset: 0x007B5EC2
	private RenderTextureFormat GLOAIPNHKCK(RenderTextureFormat BMGNJMAAOLO, RenderTextureFormat NLBEDPPPNBO)
	{
		if (SystemInfo.SupportsRenderTextureFormat(BMGNJMAAOLO))
		{
			return BMGNJMAAOLO;
		}
		if (SystemInfo.SupportsRenderTextureFormat(NLBEDPPPNBO))
		{
			return NLBEDPPPNBO;
		}
		return RenderTextureFormat.Default;
	}

	// Token: 0x060114EF RID: 70895 RVA: 0x007B7CDC File Offset: 0x007B5EDC
	public void BJOBKDALIPB(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK, bool NEFHKMDKMBC, Vector2 KMCBBPPIEAM, float PICFEHAOCBD)
	{
		DepthOfFieldModel.Settings settings = base.BBEPCCALAFC.FNFNGEGDCCE();
		RenderTextureFormat ljcedkclbdb = (RenderTextureFormat)(-23);
		RenderTextureFormat renderTextureFormat = this.INOAHHLCNOK((RenderTextureFormat)51, (RenderTextureFormat)(-1));
		float num = this.KKGKFBEGMAO();
		float num2 = Mathf.Max(settings.focusDistance, num);
		float num3 = (float)JONJODLFAEN.width / (float)JONJODLFAEN.height;
		float num4 = num * num / (settings.aperture * (num2 - num) * 986f * 1460f);
		float num5 = this.PLLGBIHBCNJ(JONJODLFAEN.height);
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.NNKCNLCNDNC("linebreak.ogg");
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.BDGEKIPEDGL, num2);
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.NOIGFGMNPLM, num4);
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.KPHGLJLAFIK, num5);
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.FIFLGOBMMPD, 1100f / num5);
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.LHHAEHNBKHB, 1158f / num3);
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.AFONGIICOJG(this.AMCOGJHPPOC.IBPMMKDPDEO(), this.AMCOGJHPPOC.ILLKFNCFGMP, 1, renderTextureFormat, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Repeat, "demoUint");
		Graphics.Blit(null, renderTexture, material, 1);
		if (NEFHKMDKMBC)
		{
			material.SetTexture(GEKKABOAOKA.KAIHPBFAGCL.ALCBEHDPFGG, renderTexture);
			float z = this.BHDICPIPCKK(this.AMCOGJHPPOC.IBPMMKDPDEO(), this.AMCOGJHPPOC.LPJJBJCIELA()) ? PICFEHAOCBD : 42f;
			material.SetVector(GEKKABOAOKA.KAIHPBFAGCL.KIAFMPMPGKO, new Vector3(KMCBBPPIEAM.x, KMCBBPPIEAM.y, z));
			RenderTexture temporary = RenderTexture.GetTemporary(this.AMCOGJHPPOC.GAIOLBJLPDL(), this.AMCOGJHPPOC.GHMBALIHBOH(), 0, renderTextureFormat);
			Graphics.Blit(this.EFAALDFEJEK, temporary, material, 1);
			this.AMCOGJHPPOC.ADCMJOKBEHJ.OPAFGNJADPO(renderTexture);
			if (this.EFAALDFEJEK != null)
			{
				RenderTexture.ReleaseTemporary(this.EFAALDFEJEK);
			}
			renderTexture = (this.EFAALDFEJEK = temporary);
		}
		RenderTexture renderTexture2 = this.AMCOGJHPPOC.ADCMJOKBEHJ.AFONGIICOJG(this.AMCOGJHPPOC.GAIOLBJLPDL() / 3, this.AMCOGJHPPOC.NIEGJHLHEEB() / 6, 0, ljcedkclbdb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Clamp, "Materials/DFGDesktopPlus");
		material.SetTexture(GEKKABOAOKA.KAIHPBFAGCL.ALCBEHDPFGG, renderTexture);
		Graphics.Blit(JONJODLFAEN, renderTexture2, material, 4);
		RenderTexture renderTexture3 = this.AMCOGJHPPOC.ADCMJOKBEHJ.AFONGIICOJG(this.AMCOGJHPPOC.NMEBEEHCALN / 6, this.AMCOGJHPPOC.GGGEFNKEPDB() / 4, 0, ljcedkclbdb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Repeat, "[HA ");
		Graphics.Blit(renderTexture2, renderTexture3, material, (int)(2 + settings.kernelSize));
		Graphics.Blit(renderTexture3, renderTexture2, material, 7);
		OOLNAJMJKIK.SetVector(GEKKABOAOKA.KAIHPBFAGCL.MMGMEFHOHCO, new Vector3(num2, num4, num5));
		if (this.AMCOGJHPPOC.CICJBNKMECH.debugViews.DOHGPGNMDLM(BuiltinDebugViewsModel.CGNLFGLJGKA.None))
		{
			OOLNAJMJKIK.EnableKeyword("wpn_wgt");
			this.AMCOGJHPPOC.FIMOHJBPLBA();
		}
		else
		{
			OOLNAJMJKIK.SetTexture(GEKKABOAOKA.KAIHPBFAGCL.LFAJBBGEKCK, renderTexture2);
			OOLNAJMJKIK.SetTexture(GEKKABOAOKA.KAIHPBFAGCL.MJAMKCBMHAA, renderTexture);
			OOLNAJMJKIK.EnableKeyword("Play: `{0}` {1}");
		}
		this.AMCOGJHPPOC.ADCMJOKBEHJ.IKEIEMKIEKG(renderTexture3);
	}

	// Token: 0x060114F0 RID: 70896 RVA: 0x007B7FE8 File Offset: 0x007B61E8
	public bool FNHNEJNNKOJ()
	{
		return base.BBEPCCALAFC.enabled && !this.AMCOGJHPPOC.IPMGKDLKDHF();
	}

	// Token: 0x060114F1 RID: 70897 RVA: 0x007B8008 File Offset: 0x007B6208
	private float MGNKIHGDLJF(int OEIKEINGJGO)
	{
		float num = (float)base.BBEPCCALAFC.CJHODOCJEMG().kernelSize * 60f + 1654f;
		return Mathf.Min(519f, num / (float)OEIKEINGJGO);
	}

	// Token: 0x060114F2 RID: 70898 RVA: 0x000EADB7 File Offset: 0x000E8FB7
	public DepthTextureMode BINFFFPDOCC()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x060114F3 RID: 70899 RVA: 0x007B721B File Offset: 0x007B541B
	private bool BJLCLGINNJL(int NMEBEEHCALN, int ILLKFNCFGMP)
	{
		return this.EFAALDFEJEK != null && this.EFAALDFEJEK.IsCreated() && this.EFAALDFEJEK.width == NMEBEEHCALN && this.EFAALDFEJEK.height == ILLKFNCFGMP;
	}

	// Token: 0x060114F4 RID: 70900 RVA: 0x007B8044 File Offset: 0x007B6244
	private float LHCGDBIPOCE(int OEIKEINGJGO)
	{
		float num = (float)base.BBEPCCALAFC.LIKDNAJFKMN().kernelSize * 843f + 425f;
		return Mathf.Min(1185f, num / (float)OEIKEINGJGO);
	}

	// Token: 0x060114F5 RID: 70901 RVA: 0x000EADB7 File Offset: 0x000E8FB7
	public DepthTextureMode CPHMEIGDBDG()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x060114F6 RID: 70902 RVA: 0x007B8080 File Offset: 0x007B6280
	private float CBBLIEFBJAE()
	{
		DepthOfFieldModel.Settings settings = base.BBEPCCALAFC.JODGENBPIKL();
		if (!settings.useCameraFov)
		{
			return settings.focalLength / 84f;
		}
		float num = this.AMCOGJHPPOC.LBCHLCGOCOD.fieldOfView * 1821f;
		return 1851f / Mathf.Tan(1904f * num);
	}

	// Token: 0x060114F7 RID: 70903 RVA: 0x007B80D8 File Offset: 0x007B62D8
	private float PLLGBIHBCNJ(int OEIKEINGJGO)
	{
		float num = (float)base.BBEPCCALAFC.FNFNGEGDCCE().kernelSize * 1265f + 1253f;
		return Mathf.Min(512f, num / (float)OEIKEINGJGO);
	}

	// Token: 0x060114F8 RID: 70904 RVA: 0x007B8111 File Offset: 0x007B6311
	public bool COFPLHIAINI()
	{
		return base.BBEPCCALAFC.enabled && this.AMCOGJHPPOC.POJLMOPEBLN();
	}

	// Token: 0x060114F9 RID: 70905 RVA: 0x007B8130 File Offset: 0x007B6330
	private bool NLFKGOECNKF(int NMEBEEHCALN, int ILLKFNCFGMP)
	{
		return !(this.EFAALDFEJEK != null) || !this.EFAALDFEJEK.IsCreated() || this.EFAALDFEJEK.width != NMEBEEHCALN || this.EFAALDFEJEK.height == ILLKFNCFGMP;
	}

	// Token: 0x060114FA RID: 70906 RVA: 0x007B816C File Offset: 0x007B636C
	public void NHBCEMCDCLL(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK, bool NEFHKMDKMBC, Vector2 KMCBBPPIEAM, float PICFEHAOCBD)
	{
		DepthOfFieldModel.Settings settings = base.BBEPCCALAFC.JODGENBPIKL();
		RenderTextureFormat ljcedkclbdb = (RenderTextureFormat)56;
		RenderTextureFormat renderTextureFormat = this.NONHEGODJMN(RenderTextureFormat.RInt, (RenderTextureFormat)(-54));
		float num = this.FHNJLCLPDDI();
		float num2 = Mathf.Max(settings.focusDistance, num);
		float num3 = (float)JONJODLFAEN.width / (float)JONJODLFAEN.height;
		float num4 = num * num / (settings.aperture * (num2 - num) * 271f * 1162f);
		float num5 = this.NKMBCAPOKCF(JONJODLFAEN.height);
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.FGKNJIEOKHH("userForceMagnitude=");
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.BDGEKIPEDGL, num2);
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.NOIGFGMNPLM, num4);
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.KPHGLJLAFIK, num5);
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.FIFLGOBMMPD, 688f / num5);
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.LHHAEHNBKHB, 224f / num3);
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.EODAHPDPKJC(this.AMCOGJHPPOC.OCNEHBGMHGB(), this.AMCOGJHPPOC.HJOKFIGACEC(), 1, renderTextureFormat, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Repeat, "_PixelsPerMeterAtOneMeter");
		Graphics.Blit(null, renderTexture, material, 1);
		if (NEFHKMDKMBC)
		{
			material.SetTexture(GEKKABOAOKA.KAIHPBFAGCL.ALCBEHDPFGG, renderTexture);
			float z = this.NJFOLCNFEHP(this.AMCOGJHPPOC.CFDHOKHCPOJ(), this.AMCOGJHPPOC.FHCDJOLMIMG()) ? PICFEHAOCBD : 148f;
			material.SetVector(GEKKABOAOKA.KAIHPBFAGCL.KIAFMPMPGKO, new Vector3(KMCBBPPIEAM.x, KMCBBPPIEAM.y, z));
			RenderTexture temporary = RenderTexture.GetTemporary(this.AMCOGJHPPOC.OCNEHBGMHGB(), this.AMCOGJHPPOC.GGGEFNKEPDB(), 0, renderTextureFormat);
			Graphics.Blit(this.EFAALDFEJEK, temporary, material, 0);
			this.AMCOGJHPPOC.ADCMJOKBEHJ.AEIGHBEIBFN(renderTexture);
			if (this.EFAALDFEJEK != null)
			{
				RenderTexture.ReleaseTemporary(this.EFAALDFEJEK);
			}
			renderTexture = (this.EFAALDFEJEK = temporary);
		}
		RenderTexture renderTexture2 = this.AMCOGJHPPOC.ADCMJOKBEHJ.HJFNEOFMJEJ(this.AMCOGJHPPOC.LJJOEDIJPEM() / 3, this.AMCOGJHPPOC.CICDECHCDBJ() / 4, 0, ljcedkclbdb, RenderTextureReadWrite.Linear, FilterMode.Point, TextureWrapMode.Clamp, "No fish in fishModelData modelid=");
		material.SetTexture(GEKKABOAOKA.KAIHPBFAGCL.ALCBEHDPFGG, renderTexture);
		Graphics.Blit(JONJODLFAEN, renderTexture2, material, 1);
		RenderTexture renderTexture3 = this.AMCOGJHPPOC.ADCMJOKBEHJ.PONLLEMLFBL(this.AMCOGJHPPOC.GAIOLBJLPDL() / 1, this.AMCOGJHPPOC.CICDECHCDBJ() / 8, 1, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Clamp, "DealerIdle");
		Graphics.Blit(renderTexture2, renderTexture3, material, (int)(5 + settings.kernelSize));
		Graphics.Blit(renderTexture3, renderTexture2, material, 0);
		OOLNAJMJKIK.SetVector(GEKKABOAOKA.KAIHPBFAGCL.MMGMEFHOHCO, new Vector3(num2, num4, num5));
		if (this.AMCOGJHPPOC.CICJBNKMECH.debugViews.DOHGPGNMDLM(BuiltinDebugViewsModel.CGNLFGLJGKA.Depth))
		{
			OOLNAJMJKIK.EnableKeyword("wpn_dress2");
			this.AMCOGJHPPOC.ACOPJCLCHIL();
		}
		else
		{
			OOLNAJMJKIK.SetTexture(GEKKABOAOKA.KAIHPBFAGCL.LFAJBBGEKCK, renderTexture2);
			OOLNAJMJKIK.SetTexture(GEKKABOAOKA.KAIHPBFAGCL.MJAMKCBMHAA, renderTexture);
			OOLNAJMJKIK.EnableKeyword("  Balls Fired: ");
		}
		this.AMCOGJHPPOC.ADCMJOKBEHJ.NHHNEKPKHPC(renderTexture3);
	}

	// Token: 0x060114FB RID: 70907 RVA: 0x007B8478 File Offset: 0x007B6678
	private float JJKJEFHJPNJ(int OEIKEINGJGO)
	{
		float num = (float)base.BBEPCCALAFC.PPJLJIIHAAK().kernelSize * 1775f + 1967f;
		return Mathf.Min(1967f, num / (float)OEIKEINGJGO);
	}

	// Token: 0x060114FC RID: 70908 RVA: 0x007B84B1 File Offset: 0x007B66B1
	private RenderTextureFormat AJIPIJFNPFA(RenderTextureFormat BMGNJMAAOLO, RenderTextureFormat NLBEDPPPNBO)
	{
		if (SystemInfo.SupportsRenderTextureFormat(BMGNJMAAOLO))
		{
			return BMGNJMAAOLO;
		}
		if (SystemInfo.SupportsRenderTextureFormat(NLBEDPPPNBO))
		{
			return NLBEDPPPNBO;
		}
		return RenderTextureFormat.ARGB2101010;
	}

	// Token: 0x060114FD RID: 70909 RVA: 0x007B84C8 File Offset: 0x007B66C8
	public void PMCPADOBJGI(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK, bool NEFHKMDKMBC, Vector2 KMCBBPPIEAM, float PICFEHAOCBD)
	{
		DepthOfFieldModel.Settings settings = base.BBEPCCALAFC.HFHIAGLALPI();
		RenderTextureFormat ljcedkclbdb = (RenderTextureFormat)(-113);
		RenderTextureFormat renderTextureFormat = this.BMAALFIGHBH((RenderTextureFormat)(-10), (RenderTextureFormat)(-120));
		float num = this.HOJHFPBODJO();
		float num2 = Mathf.Max(settings.focusDistance, num);
		float num3 = (float)JONJODLFAEN.width / (float)JONJODLFAEN.height;
		float num4 = num * num / (settings.aperture * (num2 - num) * 804f * 1506f);
		float num5 = this.IDNJEMGLLOF(JONJODLFAEN.height);
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.OJFALDJIOHN("wpn_chair2");
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.BDGEKIPEDGL, num2);
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.NOIGFGMNPLM, num4);
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.KPHGLJLAFIK, num5);
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.FIFLGOBMMPD, 1368f / num5);
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.LHHAEHNBKHB, 348f / num3);
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.OAJBECLLIEP(this.AMCOGJHPPOC.NMCCGCOKKFA(), this.AMCOGJHPPOC.GHMBALIHBOH(), 1, renderTextureFormat, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Clamp, "wpn_rod1");
		Graphics.Blit(null, renderTexture, material, 1);
		if (NEFHKMDKMBC)
		{
			material.SetTexture(GEKKABOAOKA.KAIHPBFAGCL.ALCBEHDPFGG, renderTexture);
			float z = this.BJLCLGINNJL(this.AMCOGJHPPOC.FOBPENGADNB(), this.AMCOGJHPPOC.CICDECHCDBJ()) ? PICFEHAOCBD : 217f;
			material.SetVector(GEKKABOAOKA.KAIHPBFAGCL.KIAFMPMPGKO, new Vector3(KMCBBPPIEAM.x, KMCBBPPIEAM.y, z));
			RenderTexture temporary = RenderTexture.GetTemporary(this.AMCOGJHPPOC.DHPPGHBNDEB(), this.AMCOGJHPPOC.FHCDJOLMIMG(), 0, renderTextureFormat);
			Graphics.Blit(this.EFAALDFEJEK, temporary, material, 1);
			this.AMCOGJHPPOC.ADCMJOKBEHJ.GMBHOMBKHOF(renderTexture);
			if (this.EFAALDFEJEK != null)
			{
				RenderTexture.ReleaseTemporary(this.EFAALDFEJEK);
			}
			renderTexture = (this.EFAALDFEJEK = temporary);
		}
		RenderTexture renderTexture2 = this.AMCOGJHPPOC.ADCMJOKBEHJ.EODAHPDPKJC(this.AMCOGJHPPOC.OJNDCCHLMNK() / 2, this.AMCOGJHPPOC.MMEMLJENMFF() / 5, 0, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Clamp, "_Source");
		material.SetTexture(GEKKABOAOKA.KAIHPBFAGCL.ALCBEHDPFGG, renderTexture);
		Graphics.Blit(JONJODLFAEN, renderTexture2, material, 7);
		RenderTexture renderTexture3 = this.AMCOGJHPPOC.ADCMJOKBEHJ.DJFOKFPMPDM(this.AMCOGJHPPOC.OJNDCCHLMNK() / 8, this.AMCOGJHPPOC.GGGEFNKEPDB() / 5, 1, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Repeat, "Giant2HandGrab");
		Graphics.Blit(renderTexture2, renderTexture3, material, (int)(0 + settings.kernelSize));
		Graphics.Blit(renderTexture3, renderTexture2, material, 0);
		OOLNAJMJKIK.SetVector(GEKKABOAOKA.KAIHPBFAGCL.MMGMEFHOHCO, new Vector3(num2, num4, num5));
		if (this.AMCOGJHPPOC.CICJBNKMECH.debugViews.PNJNAECPOON(BuiltinDebugViewsModel.CGNLFGLJGKA.LogLut))
		{
			OOLNAJMJKIK.EnableKeyword("WeaponStrafeRunRight");
			this.AMCOGJHPPOC.JCNEOEEHBNP();
		}
		else
		{
			OOLNAJMJKIK.SetTexture(GEKKABOAOKA.KAIHPBFAGCL.LFAJBBGEKCK, renderTexture2);
			OOLNAJMJKIK.SetTexture(GEKKABOAOKA.KAIHPBFAGCL.MJAMKCBMHAA, renderTexture);
			OOLNAJMJKIK.EnableKeyword("Crouch180");
		}
		this.AMCOGJHPPOC.ADCMJOKBEHJ.OIHDKCLPEOE(renderTexture3);
	}

	// Token: 0x060114FE RID: 70910 RVA: 0x007B87D4 File Offset: 0x007B69D4
	public void JJJAPCHFEIF(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK, bool NEFHKMDKMBC, Vector2 KMCBBPPIEAM, float PICFEHAOCBD)
	{
		DepthOfFieldModel.Settings settings = base.BBEPCCALAFC.PNNGLBOIIMH();
		RenderTextureFormat ljcedkclbdb = (RenderTextureFormat)122;
		RenderTextureFormat renderTextureFormat = this.BCEFOLJADOP(RenderTextureFormat.RHalf, (RenderTextureFormat)(-66));
		float num = this.HOJHFPBODJO();
		float num2 = Mathf.Max(settings.focusDistance, num);
		float num3 = (float)JONJODLFAEN.width / (float)JONJODLFAEN.height;
		float num4 = num * num / (settings.aperture * (num2 - num) * 425f * 1988f);
		float num5 = this.NNMLKKIKLHD(JONJODLFAEN.height);
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.MLFKHMPHIGN("and |assert |break |class |continue |def |del |elif |else |except |exec |finally |for |from |global |if |import |in |is |lambda |not |or |pass |print |raise |return |try |while |yield |None |True |False ");
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.BDGEKIPEDGL, num2);
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.NOIGFGMNPLM, num4);
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.KPHGLJLAFIK, num5);
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.FIFLGOBMMPD, 1024f / num5);
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.LHHAEHNBKHB, 835f / num3);
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.EODAHPDPKJC(this.AMCOGJHPPOC.NMEBEEHCALN, this.AMCOGJHPPOC.LKLNPJICOHH(), 1, renderTextureFormat, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Repeat, "I");
		Graphics.Blit(null, renderTexture, material, 1);
		if (NEFHKMDKMBC)
		{
			material.SetTexture(GEKKABOAOKA.KAIHPBFAGCL.ALCBEHDPFGG, renderTexture);
			float z = this.NLFKGOECNKF(this.AMCOGJHPPOC.EOMMKPDCAML(), this.AMCOGJHPPOC.ILLKFNCFGMP) ? PICFEHAOCBD : 879f;
			material.SetVector(GEKKABOAOKA.KAIHPBFAGCL.KIAFMPMPGKO, new Vector3(KMCBBPPIEAM.x, KMCBBPPIEAM.y, z));
			RenderTexture temporary = RenderTexture.GetTemporary(this.AMCOGJHPPOC.PAHBMDOJHKK(), this.AMCOGJHPPOC.LHPBMEDMNDO(), 1, renderTextureFormat);
			Graphics.Blit(this.EFAALDFEJEK, temporary, material, 1);
			this.AMCOGJHPPOC.ADCMJOKBEHJ.PDIDDBBOGPI(renderTexture);
			if (this.EFAALDFEJEK != null)
			{
				RenderTexture.ReleaseTemporary(this.EFAALDFEJEK);
			}
			renderTexture = (this.EFAALDFEJEK = temporary);
		}
		RenderTexture renderTexture2 = this.AMCOGJHPPOC.ADCMJOKBEHJ.HPAJGFGNMOH(this.AMCOGJHPPOC.GMOLEDNNPEH() / 5, this.AMCOGJHPPOC.CICDECHCDBJ() / 1, 0, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Repeat, "RollerBladeCrossoverRight");
		material.SetTexture(GEKKABOAOKA.KAIHPBFAGCL.ALCBEHDPFGG, renderTexture);
		Graphics.Blit(JONJODLFAEN, renderTexture2, material, 0);
		RenderTexture renderTexture3 = this.AMCOGJHPPOC.ADCMJOKBEHJ.JJFELDJCAFA(this.AMCOGJHPPOC.NMEBEEHCALN / 8, this.AMCOGJHPPOC.GHMBALIHBOH() / 4, 1, ljcedkclbdb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Repeat, "<<");
		Graphics.Blit(renderTexture2, renderTexture3, material, (int)(0 + settings.kernelSize));
		Graphics.Blit(renderTexture3, renderTexture2, material, 7);
		OOLNAJMJKIK.SetVector(GEKKABOAOKA.KAIHPBFAGCL.MMGMEFHOHCO, new Vector3(num2, num4, num5));
		if (this.AMCOGJHPPOC.CICJBNKMECH.debugViews.BGKOOHLKCNJ(BuiltinDebugViewsModel.CGNLFGLJGKA.LogLut))
		{
			OOLNAJMJKIK.EnableKeyword("post_19");
			this.AMCOGJHPPOC.BDLOPJPLHJN();
		}
		else
		{
			OOLNAJMJKIK.SetTexture(GEKKABOAOKA.KAIHPBFAGCL.LFAJBBGEKCK, renderTexture2);
			OOLNAJMJKIK.SetTexture(GEKKABOAOKA.KAIHPBFAGCL.MJAMKCBMHAA, renderTexture);
			OOLNAJMJKIK.EnableKeyword("Sewing");
		}
		this.AMCOGJHPPOC.ADCMJOKBEHJ.AEIGHBEIBFN(renderTexture3);
	}

	// Token: 0x060114FF RID: 70911 RVA: 0x007B8AE0 File Offset: 0x007B6CE0
	private RenderTextureFormat INOAHHLCNOK(RenderTextureFormat BMGNJMAAOLO, RenderTextureFormat NLBEDPPPNBO)
	{
		if (SystemInfo.SupportsRenderTextureFormat(BMGNJMAAOLO))
		{
			return BMGNJMAAOLO;
		}
		if (SystemInfo.SupportsRenderTextureFormat(NLBEDPPPNBO))
		{
			return NLBEDPPPNBO;
		}
		return RenderTextureFormat.ARGB1555;
	}

	// Token: 0x06011500 RID: 70912 RVA: 0x007B8AF7 File Offset: 0x007B6CF7
	public bool FOFBPEDDNHC()
	{
		return !base.BBEPCCALAFC.enabled || !this.AMCOGJHPPOC.MLMGNHHAOHF();
	}

	// Token: 0x06011501 RID: 70913 RVA: 0x007B8B16 File Offset: 0x007B6D16
	private RenderTextureFormat KINFHLCBKCM(RenderTextureFormat BMGNJMAAOLO, RenderTextureFormat NLBEDPPPNBO)
	{
		if (SystemInfo.SupportsRenderTextureFormat(BMGNJMAAOLO))
		{
			return BMGNJMAAOLO;
		}
		if (SystemInfo.SupportsRenderTextureFormat(NLBEDPPPNBO))
		{
			return NLBEDPPPNBO;
		}
		return RenderTextureFormat.Shadowmap;
	}

	// Token: 0x06011502 RID: 70914 RVA: 0x007B8B30 File Offset: 0x007B6D30
	private float JHKFIJHDBPA()
	{
		DepthOfFieldModel.Settings settings = base.BBEPCCALAFC.BEEOHPGHOFF();
		if (!settings.useCameraFov)
		{
			return settings.focalLength / 810f;
		}
		float num = this.AMCOGJHPPOC.LBCHLCGOCOD.fieldOfView * 1009f;
		return 330f / Mathf.Tan(1701f * num);
	}

	// Token: 0x06011503 RID: 70915 RVA: 0x007B8B87 File Offset: 0x007B6D87
	private RenderTextureFormat OMPDDKDPGEH(RenderTextureFormat BMGNJMAAOLO, RenderTextureFormat NLBEDPPPNBO)
	{
		if (SystemInfo.SupportsRenderTextureFormat(BMGNJMAAOLO))
		{
			return BMGNJMAAOLO;
		}
		if (SystemInfo.SupportsRenderTextureFormat(NLBEDPPPNBO))
		{
			return NLBEDPPPNBO;
		}
		return RenderTextureFormat.ARGB32;
	}

	// Token: 0x06011504 RID: 70916 RVA: 0x007B71A0 File Offset: 0x007B53A0
	public void LBABEDLHAIC()
	{
		if (this.EFAALDFEJEK != null)
		{
			RenderTexture.ReleaseTemporary(this.EFAALDFEJEK);
		}
		this.EFAALDFEJEK = null;
	}

	// Token: 0x06011505 RID: 70917 RVA: 0x007B8BA0 File Offset: 0x007B6DA0
	private float MGIJFOIKDOH()
	{
		DepthOfFieldModel.Settings settings = base.BBEPCCALAFC.KPDHPKHEDDM();
		if (!settings.useCameraFov)
		{
			return settings.focalLength / 1110f;
		}
		float num = this.AMCOGJHPPOC.LBCHLCGOCOD.fieldOfView * 1289f;
		return 1419f / Mathf.Tan(1768f * num);
	}

	// Token: 0x06011506 RID: 70918 RVA: 0x007B8BF8 File Offset: 0x007B6DF8
	private float IDNJEMGLLOF(int OEIKEINGJGO)
	{
		float num = (float)base.BBEPCCALAFC.FNFNGEGDCCE().kernelSize * 704f + 461f;
		return Mathf.Min(792f, num / (float)OEIKEINGJGO);
	}

	// Token: 0x06011507 RID: 70919 RVA: 0x007B71A0 File Offset: 0x007B53A0
	public void GMJFHNCPCBN()
	{
		if (this.EFAALDFEJEK != null)
		{
			RenderTexture.ReleaseTemporary(this.EFAALDFEJEK);
		}
		this.EFAALDFEJEK = null;
	}

	// Token: 0x06011508 RID: 70920 RVA: 0x007B8C34 File Offset: 0x007B6E34
	private float PNIDCOHCDJF()
	{
		DepthOfFieldModel.Settings settings = base.BBEPCCALAFC.CJHODOCJEMG();
		if (!settings.useCameraFov)
		{
			return settings.focalLength / 994f;
		}
		float num = this.AMCOGJHPPOC.LBCHLCGOCOD.fieldOfView * 764f;
		return 1628f / Mathf.Tan(915f * num);
	}

	// Token: 0x06011509 RID: 70921 RVA: 0x000EB372 File Offset: 0x000E9572
	public DepthTextureMode GGGLFFGBDLM()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x0601150A RID: 70922 RVA: 0x007B8C8C File Offset: 0x007B6E8C
	public void LJOHBCBNIPM(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK, bool NEFHKMDKMBC, Vector2 KMCBBPPIEAM, float PICFEHAOCBD)
	{
		DepthOfFieldModel.Settings settings = base.BBEPCCALAFC.KFELKKMJJHI();
		RenderTextureFormat ljcedkclbdb = (RenderTextureFormat)73;
		RenderTextureFormat renderTextureFormat = this.OGOBPCJFBFL((RenderTextureFormat)61, (RenderTextureFormat)116);
		float num = this.MKKCJAEGAAM();
		float num2 = Mathf.Max(settings.focusDistance, num);
		float num3 = (float)JONJODLFAEN.width / (float)JONJODLFAEN.height;
		float num4 = num * num / (settings.aperture * (num2 - num) * 66f * 1872f);
		float num5 = this.GKCALAPNLNI(JONJODLFAEN.height);
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.ACEOHEODOMJ("MotorbikeShootBack");
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.BDGEKIPEDGL, num2);
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.NOIGFGMNPLM, num4);
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.KPHGLJLAFIK, num5);
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.FIFLGOBMMPD, 1296f / num5);
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.LHHAEHNBKHB, 1954f / num3);
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.EODAHPDPKJC(this.AMCOGJHPPOC.DJGCPIEOAFC(), this.AMCOGJHPPOC.GHMBALIHBOH(), 0, renderTextureFormat, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Repeat, "_ReflectionBufferSize");
		Graphics.Blit(null, renderTexture, material, 1);
		if (NEFHKMDKMBC)
		{
			material.SetTexture(GEKKABOAOKA.KAIHPBFAGCL.ALCBEHDPFGG, renderTexture);
			float z = this.MLIFBJHKJJD(this.AMCOGJHPPOC.EOMMKPDCAML(), this.AMCOGJHPPOC.LKLNPJICOHH()) ? PICFEHAOCBD : 1326f;
			material.SetVector(GEKKABOAOKA.KAIHPBFAGCL.KIAFMPMPGKO, new Vector3(KMCBBPPIEAM.x, KMCBBPPIEAM.y, z));
			RenderTexture temporary = RenderTexture.GetTemporary(this.AMCOGJHPPOC.NMCCGCOKKFA(), this.AMCOGJHPPOC.FHCDJOLMIMG(), 0, renderTextureFormat);
			Graphics.Blit(this.EFAALDFEJEK, temporary, material, 0);
			this.AMCOGJHPPOC.ADCMJOKBEHJ.NHHNEKPKHPC(renderTexture);
			if (this.EFAALDFEJEK != null)
			{
				RenderTexture.ReleaseTemporary(this.EFAALDFEJEK);
			}
			renderTexture = (this.EFAALDFEJEK = temporary);
		}
		RenderTexture renderTexture2 = this.AMCOGJHPPOC.ADCMJOKBEHJ.HJFNEOFMJEJ(this.AMCOGJHPPOC.KDBADMLHBNP() / 7, this.AMCOGJHPPOC.KNKKIHDHBFD() / 6, 1, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Clamp, "russian");
		material.SetTexture(GEKKABOAOKA.KAIHPBFAGCL.ALCBEHDPFGG, renderTexture);
		Graphics.Blit(JONJODLFAEN, renderTexture2, material, 2);
		RenderTexture renderTexture3 = this.AMCOGJHPPOC.ADCMJOKBEHJ.HJFNEOFMJEJ(this.AMCOGJHPPOC.CFDHOKHCPOJ() / 5, this.AMCOGJHPPOC.FHCDJOLMIMG() / 3, 1, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Point, TextureWrapMode.Clamp, "knopje.wav");
		Graphics.Blit(renderTexture2, renderTexture3, material, (int)(6 + settings.kernelSize));
		Graphics.Blit(renderTexture3, renderTexture2, material, 1);
		OOLNAJMJKIK.SetVector(GEKKABOAOKA.KAIHPBFAGCL.MMGMEFHOHCO, new Vector3(num2, num4, num5));
		if (this.AMCOGJHPPOC.CICJBNKMECH.debugViews.DOHGPGNMDLM(BuiltinDebugViewsModel.CGNLFGLJGKA.EyeAdaptation))
		{
			OOLNAJMJKIK.EnableKeyword("float: ");
			this.AMCOGJHPPOC.FIMOHJBPLBA();
		}
		else
		{
			OOLNAJMJKIK.SetTexture(GEKKABOAOKA.KAIHPBFAGCL.LFAJBBGEKCK, renderTexture2);
			OOLNAJMJKIK.SetTexture(GEKKABOAOKA.KAIHPBFAGCL.MJAMKCBMHAA, renderTexture);
			OOLNAJMJKIK.EnableKeyword("");
		}
		this.AMCOGJHPPOC.ADCMJOKBEHJ.APPMOHMABMK(renderTexture3);
	}

	// Token: 0x0601150B RID: 70923 RVA: 0x007B8F98 File Offset: 0x007B7198
	private float CIJGPFPDKGL(int OEIKEINGJGO)
	{
		float num = (float)base.BBEPCCALAFC.COCGBMLPIPH().kernelSize * 1226f + 153f;
		return Mathf.Min(750f, num / (float)OEIKEINGJGO);
	}

	// Token: 0x0601150C RID: 70924 RVA: 0x000EADB7 File Offset: 0x000E8FB7
	public override DepthTextureMode PPAJFNGHBCF()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x0601150D RID: 70925 RVA: 0x007B8FD1 File Offset: 0x007B71D1
	public bool KCMKDGLNNPM()
	{
		return !base.BBEPCCALAFC.enabled || this.AMCOGJHPPOC.IPMGKDLKDHF();
	}

	// Token: 0x0601150E RID: 70926 RVA: 0x000EB372 File Offset: 0x000E9572
	public DepthTextureMode CPMPEEDIPLL()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x0601150F RID: 70927 RVA: 0x007B84B1 File Offset: 0x007B66B1
	private RenderTextureFormat OGOBPCJFBFL(RenderTextureFormat BMGNJMAAOLO, RenderTextureFormat NLBEDPPPNBO)
	{
		if (SystemInfo.SupportsRenderTextureFormat(BMGNJMAAOLO))
		{
			return BMGNJMAAOLO;
		}
		if (SystemInfo.SupportsRenderTextureFormat(NLBEDPPPNBO))
		{
			return NLBEDPPPNBO;
		}
		return RenderTextureFormat.ARGB2101010;
	}

	// Token: 0x06011510 RID: 70928 RVA: 0x007B7CC2 File Offset: 0x007B5EC2
	private RenderTextureFormat CPDAICFMGHF(RenderTextureFormat BMGNJMAAOLO, RenderTextureFormat NLBEDPPPNBO)
	{
		if (SystemInfo.SupportsRenderTextureFormat(BMGNJMAAOLO))
		{
			return BMGNJMAAOLO;
		}
		if (SystemInfo.SupportsRenderTextureFormat(NLBEDPPPNBO))
		{
			return NLBEDPPPNBO;
		}
		return RenderTextureFormat.Default;
	}

	// Token: 0x06011511 RID: 70929 RVA: 0x007B721B File Offset: 0x007B541B
	private bool OHEKELCAGLC(int NMEBEEHCALN, int ILLKFNCFGMP)
	{
		return this.EFAALDFEJEK != null && this.EFAALDFEJEK.IsCreated() && this.EFAALDFEJEK.width == NMEBEEHCALN && this.EFAALDFEJEK.height == ILLKFNCFGMP;
	}

	// Token: 0x06011512 RID: 70930 RVA: 0x007B8FF0 File Offset: 0x007B71F0
	private float APPPFNIMJLL(int OEIKEINGJGO)
	{
		float num = (float)base.BBEPCCALAFC.settings.kernelSize * 4f + 6f;
		return Mathf.Min(0.05f, num / (float)OEIKEINGJGO);
	}

	// Token: 0x06011513 RID: 70931 RVA: 0x007B9029 File Offset: 0x007B7229
	public bool GHDPKCBBAON()
	{
		return base.BBEPCCALAFC.enabled && !this.AMCOGJHPPOC.MLMGNHHAOHF();
	}

	// Token: 0x06011514 RID: 70932 RVA: 0x007B9048 File Offset: 0x007B7248
	private RenderTextureFormat NONHEGODJMN(RenderTextureFormat BMGNJMAAOLO, RenderTextureFormat NLBEDPPPNBO)
	{
		if (SystemInfo.SupportsRenderTextureFormat(BMGNJMAAOLO))
		{
			return BMGNJMAAOLO;
		}
		if (SystemInfo.SupportsRenderTextureFormat(NLBEDPPPNBO))
		{
			return NLBEDPPPNBO;
		}
		return RenderTextureFormat.Depth;
	}

	// Token: 0x06011515 RID: 70933 RVA: 0x007B9060 File Offset: 0x007B7260
	public void AEHIJMPNBDP(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK, bool NEFHKMDKMBC, Vector2 KMCBBPPIEAM, float PICFEHAOCBD)
	{
		DepthOfFieldModel.Settings settings = base.BBEPCCALAFC.LIKDNAJFKMN();
		RenderTextureFormat ljcedkclbdb = (RenderTextureFormat)(-62);
		RenderTextureFormat renderTextureFormat = this.BMAALFIGHBH((RenderTextureFormat)39, (RenderTextureFormat)32);
		float num = this.PNIDCOHCDJF();
		float num2 = Mathf.Max(settings.focusDistance, num);
		float num3 = (float)JONJODLFAEN.width / (float)JONJODLFAEN.height;
		float num4 = num * num / (settings.aperture * (num2 - num) * 293f * 1992f);
		float num5 = this.LHCGDBIPOCE(JONJODLFAEN.height);
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.OJFALDJIOHN("404040");
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.BDGEKIPEDGL, num2);
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.NOIGFGMNPLM, num4);
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.KPHGLJLAFIK, num5);
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.FIFLGOBMMPD, 1083f / num5);
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.LHHAEHNBKHB, 1009f / num3);
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.HJFNEOFMJEJ(this.AMCOGJHPPOC.IGHJHMGOGOO(), this.AMCOGJHPPOC.MMEMLJENMFF(), 1, renderTextureFormat, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Repeat, "");
		Graphics.Blit(null, renderTexture, material, 0);
		if (NEFHKMDKMBC)
		{
			material.SetTexture(GEKKABOAOKA.KAIHPBFAGCL.ALCBEHDPFGG, renderTexture);
			float z = this.NPBNKCPACJJ(this.AMCOGJHPPOC.EOMMKPDCAML(), this.AMCOGJHPPOC.LHPBMEDMNDO()) ? PICFEHAOCBD : 1622f;
			material.SetVector(GEKKABOAOKA.KAIHPBFAGCL.KIAFMPMPGKO, new Vector3(KMCBBPPIEAM.x, KMCBBPPIEAM.y, z));
			RenderTexture temporary = RenderTexture.GetTemporary(this.AMCOGJHPPOC.GAIOLBJLPDL(), this.AMCOGJHPPOC.KNKKIHDHBFD(), 0, renderTextureFormat);
			Graphics.Blit(this.EFAALDFEJEK, temporary, material, 0);
			this.AMCOGJHPPOC.ADCMJOKBEHJ.PDIDDBBOGPI(renderTexture);
			if (this.EFAALDFEJEK != null)
			{
				RenderTexture.ReleaseTemporary(this.EFAALDFEJEK);
			}
			renderTexture = (this.EFAALDFEJEK = temporary);
		}
		RenderTexture renderTexture2 = this.AMCOGJHPPOC.ADCMJOKBEHJ.PONLLEMLFBL(this.AMCOGJHPPOC.GMOLEDNNPEH() / 4, this.AMCOGJHPPOC.NIEGJHLHEEB() / 2, 1, ljcedkclbdb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Clamp, "DEPTH_OF_FIELD");
		material.SetTexture(GEKKABOAOKA.KAIHPBFAGCL.ALCBEHDPFGG, renderTexture);
		Graphics.Blit(JONJODLFAEN, renderTexture2, material, 7);
		RenderTexture renderTexture3 = this.AMCOGJHPPOC.ADCMJOKBEHJ.CGAACPIAKHP(this.AMCOGJHPPOC.GMOLEDNNPEH() / 7, this.AMCOGJHPPOC.KNKKIHDHBFD() / 5, 1, ljcedkclbdb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Repeat, "RunBackRight");
		Graphics.Blit(renderTexture2, renderTexture3, material, (int)(6 + settings.kernelSize));
		Graphics.Blit(renderTexture3, renderTexture2, material, 3);
		OOLNAJMJKIK.SetVector(GEKKABOAOKA.KAIHPBFAGCL.MMGMEFHOHCO, new Vector3(num2, num4, num5));
		if (this.AMCOGJHPPOC.CICJBNKMECH.debugViews.DAKPGCMKCJP(BuiltinDebugViewsModel.CGNLFGLJGKA.LogLut))
		{
			OOLNAJMJKIK.EnableKeyword(" ");
			this.AMCOGJHPPOC.CDPLIOCHOGE();
		}
		else
		{
			OOLNAJMJKIK.SetTexture(GEKKABOAOKA.KAIHPBFAGCL.LFAJBBGEKCK, renderTexture2);
			OOLNAJMJKIK.SetTexture(GEKKABOAOKA.KAIHPBFAGCL.MJAMKCBMHAA, renderTexture);
			OOLNAJMJKIK.EnableKeyword("MotorbikeWheelyNoHands");
		}
		this.AMCOGJHPPOC.ADCMJOKBEHJ.PDIDDBBOGPI(renderTexture3);
	}

	// Token: 0x06011516 RID: 70934 RVA: 0x007B936C File Offset: 0x007B756C
	public bool JOOIEAIMIGG()
	{
		return base.BBEPCCALAFC.enabled && this.AMCOGJHPPOC.HKJHMGJGNHJ();
	}

	// Token: 0x06011517 RID: 70935 RVA: 0x007B938C File Offset: 0x007B758C
	public void JKHFDFNHEPN(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK, bool NEFHKMDKMBC, Vector2 KMCBBPPIEAM, float PICFEHAOCBD)
	{
		DepthOfFieldModel.Settings settings = base.BBEPCCALAFC.DJKEIONCLCG();
		RenderTextureFormat ljcedkclbdb = (RenderTextureFormat)(-46);
		RenderTextureFormat renderTextureFormat = this.MPHJKCFLOGD((RenderTextureFormat)(-53), (RenderTextureFormat)(-2));
		float num = this.NEIBNKCHHLJ();
		float num2 = Mathf.Max(settings.focusDistance, num);
		float num3 = (float)JONJODLFAEN.width / (float)JONJODLFAEN.height;
		float num4 = num * num / (settings.aperture * (num2 - num) * 1635f * 838f);
		float num5 = this.CIDLKFODOLM(JONJODLFAEN.height);
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.ACEOHEODOMJ("signal_tone");
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.BDGEKIPEDGL, num2);
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.NOIGFGMNPLM, num4);
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.KPHGLJLAFIK, num5);
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.FIFLGOBMMPD, 247f / num5);
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.LHHAEHNBKHB, 838f / num3);
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.PDFEEEAPMDC(this.AMCOGJHPPOC.OCNEHBGMHGB(), this.AMCOGJHPPOC.ILLKFNCFGMP, 1, renderTextureFormat, RenderTextureReadWrite.Linear, FilterMode.Point, TextureWrapMode.Clamp, "_SecondTex");
		Graphics.Blit(null, renderTexture, material, 0);
		if (NEFHKMDKMBC)
		{
			material.SetTexture(GEKKABOAOKA.KAIHPBFAGCL.ALCBEHDPFGG, renderTexture);
			float z = this.MLIFBJHKJJD(this.AMCOGJHPPOC.EOMMKPDCAML(), this.AMCOGJHPPOC.NIEGJHLHEEB()) ? PICFEHAOCBD : 146f;
			material.SetVector(GEKKABOAOKA.KAIHPBFAGCL.KIAFMPMPGKO, new Vector3(KMCBBPPIEAM.x, KMCBBPPIEAM.y, z));
			RenderTexture temporary = RenderTexture.GetTemporary(this.AMCOGJHPPOC.KDBADMLHBNP(), this.AMCOGJHPPOC.CICDECHCDBJ(), 1, renderTextureFormat);
			Graphics.Blit(this.EFAALDFEJEK, temporary, material, 1);
			this.AMCOGJHPPOC.ADCMJOKBEHJ.OPAFGNJADPO(renderTexture);
			if (this.EFAALDFEJEK != null)
			{
				RenderTexture.ReleaseTemporary(this.EFAALDFEJEK);
			}
			renderTexture = (this.EFAALDFEJEK = temporary);
		}
		RenderTexture renderTexture2 = this.AMCOGJHPPOC.ADCMJOKBEHJ.KJOHFKLIJHE(this.AMCOGJHPPOC.IGHJHMGOGOO() / 3, this.AMCOGJHPPOC.HJOKFIGACEC() / 0, 0, ljcedkclbdb, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Clamp, "__a");
		material.SetTexture(GEKKABOAOKA.KAIHPBFAGCL.ALCBEHDPFGG, renderTexture);
		Graphics.Blit(JONJODLFAEN, renderTexture2, material, 6);
		RenderTexture renderTexture3 = this.AMCOGJHPPOC.ADCMJOKBEHJ.KJOHFKLIJHE(this.AMCOGJHPPOC.NMEBEEHCALN / 2, this.AMCOGJHPPOC.CICDECHCDBJ() / 7, 1, ljcedkclbdb, RenderTextureReadWrite.Linear, FilterMode.Point, TextureWrapMode.Repeat, "Whistle");
		Graphics.Blit(renderTexture2, renderTexture3, material, (int)(7 + settings.kernelSize));
		Graphics.Blit(renderTexture3, renderTexture2, material, 8);
		OOLNAJMJKIK.SetVector(GEKKABOAOKA.KAIHPBFAGCL.MMGMEFHOHCO, new Vector3(num2, num4, num5));
		if (this.AMCOGJHPPOC.CICJBNKMECH.debugViews.GNHGEGEPHCI(BuiltinDebugViewsModel.CGNLFGLJGKA.AmbientOcclusion))
		{
			OOLNAJMJKIK.EnableKeyword("DealerShuffle");
			this.AMCOGJHPPOC.AAKGEKANKEE();
		}
		else
		{
			OOLNAJMJKIK.SetTexture(GEKKABOAOKA.KAIHPBFAGCL.LFAJBBGEKCK, renderTexture2);
			OOLNAJMJKIK.SetTexture(GEKKABOAOKA.KAIHPBFAGCL.MJAMKCBMHAA, renderTexture);
			OOLNAJMJKIK.EnableKeyword("_WorldToCameraMatrix");
		}
		this.AMCOGJHPPOC.ADCMJOKBEHJ.PKNMHMFNAGP(renderTexture3);
	}

	// Token: 0x06011518 RID: 70936 RVA: 0x000EB372 File Offset: 0x000E9572
	public DepthTextureMode EFMEIMAODDG()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x06011519 RID: 70937 RVA: 0x007B7564 File Offset: 0x007B5764
	private RenderTextureFormat BMAALFIGHBH(RenderTextureFormat BMGNJMAAOLO, RenderTextureFormat NLBEDPPPNBO)
	{
		if (SystemInfo.SupportsRenderTextureFormat(BMGNJMAAOLO))
		{
			return BMGNJMAAOLO;
		}
		if (SystemInfo.SupportsRenderTextureFormat(NLBEDPPPNBO))
		{
			return NLBEDPPPNBO;
		}
		return RenderTextureFormat.ARGB4444;
	}

	// Token: 0x0601151A RID: 70938 RVA: 0x007B9698 File Offset: 0x007B7898
	public bool IGOEANBMAIK()
	{
		return !base.BBEPCCALAFC.enabled || !this.AMCOGJHPPOC.IPMGKDLKDHF();
	}

	// Token: 0x0601151B RID: 70939 RVA: 0x007B84B1 File Offset: 0x007B66B1
	private RenderTextureFormat GHCILDCBGEH(RenderTextureFormat BMGNJMAAOLO, RenderTextureFormat NLBEDPPPNBO)
	{
		if (SystemInfo.SupportsRenderTextureFormat(BMGNJMAAOLO))
		{
			return BMGNJMAAOLO;
		}
		if (SystemInfo.SupportsRenderTextureFormat(NLBEDPPPNBO))
		{
			return NLBEDPPPNBO;
		}
		return RenderTextureFormat.ARGB2101010;
	}

	// Token: 0x0601151C RID: 70940 RVA: 0x007B96B8 File Offset: 0x007B78B8
	private float HOJHFPBODJO()
	{
		DepthOfFieldModel.Settings settings = base.BBEPCCALAFC.KFELKKMJJHI();
		if (!settings.useCameraFov)
		{
			return settings.focalLength / 1771f;
		}
		float num = this.AMCOGJHPPOC.LBCHLCGOCOD.fieldOfView * 889f;
		return 1454f / Mathf.Tan(1081f * num);
	}

	// Token: 0x0601151D RID: 70941 RVA: 0x007B970F File Offset: 0x007B790F
	private RenderTextureFormat DKAKCLNFFMK(RenderTextureFormat BMGNJMAAOLO, RenderTextureFormat NLBEDPPPNBO)
	{
		if (SystemInfo.SupportsRenderTextureFormat(BMGNJMAAOLO))
		{
			return BMGNJMAAOLO;
		}
		if (SystemInfo.SupportsRenderTextureFormat(NLBEDPPPNBO))
		{
			return NLBEDPPPNBO;
		}
		return RenderTextureFormat.ARGBHalf;
	}

	// Token: 0x0601151E RID: 70942 RVA: 0x007B71A0 File Offset: 0x007B53A0
	public void PHIACAJNNIG()
	{
		if (this.EFAALDFEJEK != null)
		{
			RenderTexture.ReleaseTemporary(this.EFAALDFEJEK);
		}
		this.EFAALDFEJEK = null;
	}

	// Token: 0x0601151F RID: 70943 RVA: 0x007B71A0 File Offset: 0x007B53A0
	public void LLFANOGKPKM()
	{
		if (this.EFAALDFEJEK != null)
		{
			RenderTexture.ReleaseTemporary(this.EFAALDFEJEK);
		}
		this.EFAALDFEJEK = null;
	}

	// Token: 0x06011520 RID: 70944 RVA: 0x007B9728 File Offset: 0x007B7928
	private float NEIBNKCHHLJ()
	{
		DepthOfFieldModel.Settings settings = base.BBEPCCALAFC.settings;
		if (!settings.useCameraFov)
		{
			return settings.focalLength / 1000f;
		}
		float num = this.AMCOGJHPPOC.LBCHLCGOCOD.fieldOfView * 0.017453292f;
		return 0.012f / Mathf.Tan(0.5f * num);
	}

	// Token: 0x06011521 RID: 70945 RVA: 0x007B71A0 File Offset: 0x007B53A0
	public void KHJJKPCKNKM()
	{
		if (this.EFAALDFEJEK != null)
		{
			RenderTexture.ReleaseTemporary(this.EFAALDFEJEK);
		}
		this.EFAALDFEJEK = null;
	}

	// Token: 0x06011522 RID: 70946 RVA: 0x007B977F File Offset: 0x007B797F
	public bool MNIFEJMMKOD()
	{
		return base.BBEPCCALAFC.enabled && this.AMCOGJHPPOC.IPMGKDLKDHF();
	}

	// Token: 0x06011523 RID: 70947 RVA: 0x007B71A0 File Offset: 0x007B53A0
	public void BMLMKAGHDDE()
	{
		if (this.EFAALDFEJEK != null)
		{
			RenderTexture.ReleaseTemporary(this.EFAALDFEJEK);
		}
		this.EFAALDFEJEK = null;
	}

	// Token: 0x06011524 RID: 70948 RVA: 0x007B979E File Offset: 0x007B799E
	public bool DCPAEFLBLIB()
	{
		return !base.BBEPCCALAFC.enabled || !this.AMCOGJHPPOC.HKJHMGJGNHJ();
	}

	// Token: 0x06011525 RID: 70949 RVA: 0x007B97C0 File Offset: 0x007B79C0
	private float FHNJLCLPDDI()
	{
		DepthOfFieldModel.Settings settings = base.BBEPCCALAFC.KIDPDEOKGGK();
		if (!settings.useCameraFov)
		{
			return settings.focalLength / 236f;
		}
		float num = this.AMCOGJHPPOC.LBCHLCGOCOD.fieldOfView * 1158f;
		return 1950f / Mathf.Tan(1402f * num);
	}

	// Token: 0x06011526 RID: 70950 RVA: 0x007B9817 File Offset: 0x007B7A17
	public bool ADGEPKBOKIL()
	{
		return base.BBEPCCALAFC.enabled && this.AMCOGJHPPOC.GCPDMBIEAOG();
	}

	// Token: 0x06011527 RID: 70951 RVA: 0x007B8130 File Offset: 0x007B6330
	private bool BHDICPIPCKK(int NMEBEEHCALN, int ILLKFNCFGMP)
	{
		return !(this.EFAALDFEJEK != null) || !this.EFAALDFEJEK.IsCreated() || this.EFAALDFEJEK.width != NMEBEEHCALN || this.EFAALDFEJEK.height == ILLKFNCFGMP;
	}

	// Token: 0x06011528 RID: 70952 RVA: 0x007B9838 File Offset: 0x007B7A38
	private float MLEPKNIJJGG()
	{
		DepthOfFieldModel.Settings settings = base.BBEPCCALAFC.COCGBMLPIPH();
		if (!settings.useCameraFov)
		{
			return settings.focalLength / 1799f;
		}
		float num = this.AMCOGJHPPOC.LBCHLCGOCOD.fieldOfView * 1008f;
		return 30f / Mathf.Tan(390f * num);
	}

	// Token: 0x06011529 RID: 70953 RVA: 0x007B9890 File Offset: 0x007B7A90
	public void FBBBNHPGBKC(RenderTexture JONJODLFAEN, Material OOLNAJMJKIK, bool NEFHKMDKMBC, Vector2 KMCBBPPIEAM, float PICFEHAOCBD)
	{
		DepthOfFieldModel.Settings settings = base.BBEPCCALAFC.settings;
		RenderTextureFormat ljcedkclbdb = RenderTextureFormat.DefaultHDR;
		RenderTextureFormat renderTextureFormat = this.CPDAICFMGHF(RenderTextureFormat.R8, RenderTextureFormat.RHalf);
		float num = this.NEIBNKCHHLJ();
		float num2 = Mathf.Max(settings.focusDistance, num);
		float num3 = (float)JONJODLFAEN.width / (float)JONJODLFAEN.height;
		float num4 = num * num / (settings.aperture * (num2 - num) * 0.024f * 2f);
		float num5 = this.APPPFNIMJLL(JONJODLFAEN.height);
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.AFONGIICOJG("Hidden/Post FX/Depth Of Field");
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.BDGEKIPEDGL, num2);
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.NOIGFGMNPLM, num4);
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.KPHGLJLAFIK, num5);
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.FIFLGOBMMPD, 1f / num5);
		material.SetFloat(GEKKABOAOKA.KAIHPBFAGCL.LHHAEHNBKHB, 1f / num3);
		RenderTexture renderTexture = this.AMCOGJHPPOC.ADCMJOKBEHJ.AFONGIICOJG(this.AMCOGJHPPOC.NMEBEEHCALN, this.AMCOGJHPPOC.ILLKFNCFGMP, 0, renderTextureFormat, RenderTextureReadWrite.Linear, FilterMode.Bilinear, TextureWrapMode.Clamp, "FactoryTempTexture");
		Graphics.Blit(null, renderTexture, material, 0);
		if (NEFHKMDKMBC)
		{
			material.SetTexture(GEKKABOAOKA.KAIHPBFAGCL.ALCBEHDPFGG, renderTexture);
			float z = this.HDPPFCDGMMP(this.AMCOGJHPPOC.NMEBEEHCALN, this.AMCOGJHPPOC.ILLKFNCFGMP) ? PICFEHAOCBD : 0f;
			material.SetVector(GEKKABOAOKA.KAIHPBFAGCL.KIAFMPMPGKO, new Vector3(KMCBBPPIEAM.x, KMCBBPPIEAM.y, z));
			RenderTexture temporary = RenderTexture.GetTemporary(this.AMCOGJHPPOC.NMEBEEHCALN, this.AMCOGJHPPOC.ILLKFNCFGMP, 0, renderTextureFormat);
			Graphics.Blit(this.EFAALDFEJEK, temporary, material, 1);
			this.AMCOGJHPPOC.ADCMJOKBEHJ.OFKHPBDDKHJ(renderTexture);
			if (this.EFAALDFEJEK != null)
			{
				RenderTexture.ReleaseTemporary(this.EFAALDFEJEK);
			}
			renderTexture = (this.EFAALDFEJEK = temporary);
		}
		RenderTexture renderTexture2 = this.AMCOGJHPPOC.ADCMJOKBEHJ.AFONGIICOJG(this.AMCOGJHPPOC.NMEBEEHCALN / 2, this.AMCOGJHPPOC.ILLKFNCFGMP / 2, 0, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Clamp, "FactoryTempTexture");
		material.SetTexture(GEKKABOAOKA.KAIHPBFAGCL.ALCBEHDPFGG, renderTexture);
		Graphics.Blit(JONJODLFAEN, renderTexture2, material, 2);
		RenderTexture renderTexture3 = this.AMCOGJHPPOC.ADCMJOKBEHJ.AFONGIICOJG(this.AMCOGJHPPOC.NMEBEEHCALN / 2, this.AMCOGJHPPOC.ILLKFNCFGMP / 2, 0, ljcedkclbdb, RenderTextureReadWrite.Default, FilterMode.Bilinear, TextureWrapMode.Clamp, "FactoryTempTexture");
		Graphics.Blit(renderTexture2, renderTexture3, material, (int)(3 + settings.kernelSize));
		Graphics.Blit(renderTexture3, renderTexture2, material, 7);
		OOLNAJMJKIK.SetVector(GEKKABOAOKA.KAIHPBFAGCL.MMGMEFHOHCO, new Vector3(num2, num4, num5));
		if (this.AMCOGJHPPOC.CICJBNKMECH.debugViews.CLGLCBFDOKE(BuiltinDebugViewsModel.CGNLFGLJGKA.FocusPlane))
		{
			OOLNAJMJKIK.EnableKeyword("DEPTH_OF_FIELD_COC_VIEW");
			this.AMCOGJHPPOC.FIMOHJBPLBA();
		}
		else
		{
			OOLNAJMJKIK.SetTexture(GEKKABOAOKA.KAIHPBFAGCL.LFAJBBGEKCK, renderTexture2);
			OOLNAJMJKIK.SetTexture(GEKKABOAOKA.KAIHPBFAGCL.MJAMKCBMHAA, renderTexture);
			OOLNAJMJKIK.EnableKeyword("DEPTH_OF_FIELD");
		}
		this.AMCOGJHPPOC.ADCMJOKBEHJ.OFKHPBDDKHJ(renderTexture3);
	}

	// Token: 0x0601152A RID: 70954 RVA: 0x007B9B9C File Offset: 0x007B7D9C
	public bool EABMDBKOBAF()
	{
		return base.BBEPCCALAFC.enabled && !this.AMCOGJHPPOC.ACEEFEFOCDF();
	}

	// Token: 0x0601152B RID: 70955 RVA: 0x007B9BBC File Offset: 0x007B7DBC
	private float IJKINMGBGFM(int OEIKEINGJGO)
	{
		float num = (float)base.BBEPCCALAFC.KJJCHIFFFIJ().kernelSize * 413f + 1256f;
		return Mathf.Min(339f, num / (float)OEIKEINGJGO);
	}

	// Token: 0x0601152C RID: 70956 RVA: 0x007B9BF8 File Offset: 0x007B7DF8
	private float NNMLKKIKLHD(int OEIKEINGJGO)
	{
		float num = (float)base.BBEPCCALAFC.KDHGJFOLJJF().kernelSize * 1614f + 66f;
		return Mathf.Min(237f, num / (float)OEIKEINGJGO);
	}

	// Token: 0x0601152D RID: 70957 RVA: 0x007B8AE0 File Offset: 0x007B6CE0
	private RenderTextureFormat BCEFOLJADOP(RenderTextureFormat BMGNJMAAOLO, RenderTextureFormat NLBEDPPPNBO)
	{
		if (SystemInfo.SupportsRenderTextureFormat(BMGNJMAAOLO))
		{
			return BMGNJMAAOLO;
		}
		if (SystemInfo.SupportsRenderTextureFormat(NLBEDPPPNBO))
		{
			return NLBEDPPPNBO;
		}
		return RenderTextureFormat.ARGB1555;
	}

	// Token: 0x0601152E RID: 70958 RVA: 0x007B9C31 File Offset: 0x007B7E31
	public bool FOFBLGFDDAB()
	{
		return base.BBEPCCALAFC.enabled && this.AMCOGJHPPOC.FBCBNOGGGOH();
	}

	// Token: 0x0601152F RID: 70959 RVA: 0x007B9C50 File Offset: 0x007B7E50
	public bool PLHOMLDDDHI()
	{
		return base.BBEPCCALAFC.enabled && this.AMCOGJHPPOC.HFIFOAPFKBG();
	}

	// Token: 0x06011530 RID: 70960 RVA: 0x007B8B87 File Offset: 0x007B6D87
	private RenderTextureFormat GHGNCPNNIJC(RenderTextureFormat BMGNJMAAOLO, RenderTextureFormat NLBEDPPPNBO)
	{
		if (SystemInfo.SupportsRenderTextureFormat(BMGNJMAAOLO))
		{
			return BMGNJMAAOLO;
		}
		if (SystemInfo.SupportsRenderTextureFormat(NLBEDPPPNBO))
		{
			return NLBEDPPPNBO;
		}
		return RenderTextureFormat.ARGB32;
	}

	// Token: 0x06011531 RID: 70961 RVA: 0x007B71A0 File Offset: 0x007B53A0
	public override void BKFHJFNCPAA()
	{
		if (this.EFAALDFEJEK != null)
		{
			RenderTexture.ReleaseTemporary(this.EFAALDFEJEK);
		}
		this.EFAALDFEJEK = null;
	}

	// Token: 0x06011532 RID: 70962 RVA: 0x007B9C6F File Offset: 0x007B7E6F
	public bool BJAIILKMCBK()
	{
		return !base.BBEPCCALAFC.enabled || !this.AMCOGJHPPOC.ODNAHJKPHKA();
	}

	// Token: 0x06011533 RID: 70963 RVA: 0x007B9C90 File Offset: 0x007B7E90
	private float CIDLKFODOLM(int OEIKEINGJGO)
	{
		float num = (float)base.BBEPCCALAFC.EFCLGKFCEMI().kernelSize * 862f + 1460f;
		return Mathf.Min(1274f, num / (float)OEIKEINGJGO);
	}

	// Token: 0x06011534 RID: 70964 RVA: 0x007B8130 File Offset: 0x007B6330
	private bool NJFOLCNFEHP(int NMEBEEHCALN, int ILLKFNCFGMP)
	{
		return !(this.EFAALDFEJEK != null) || !this.EFAALDFEJEK.IsCreated() || this.EFAALDFEJEK.width != NMEBEEHCALN || this.EFAALDFEJEK.height == ILLKFNCFGMP;
	}

	// Token: 0x06011535 RID: 70965 RVA: 0x007B71A0 File Offset: 0x007B53A0
	public void EALKANLKOHI()
	{
		if (this.EFAALDFEJEK != null)
		{
			RenderTexture.ReleaseTemporary(this.EFAALDFEJEK);
		}
		this.EFAALDFEJEK = null;
	}

	// Token: 0x06011536 RID: 70966 RVA: 0x000EB372 File Offset: 0x000E9572
	public DepthTextureMode IFCDFMAIPJH()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x06011537 RID: 70967 RVA: 0x007B9CCC File Offset: 0x007B7ECC
	private float NHJHFJFKKBH(int OEIKEINGJGO)
	{
		float num = (float)base.BBEPCCALAFC.KDHGJFOLJJF().kernelSize * 1747f + 312f;
		return Mathf.Min(953f, num / (float)OEIKEINGJGO);
	}

	// Token: 0x06011538 RID: 70968 RVA: 0x007B9D08 File Offset: 0x007B7F08
	private float NKMBCAPOKCF(int OEIKEINGJGO)
	{
		float num = (float)base.BBEPCCALAFC.KFELKKMJJHI().kernelSize * 168f + 929f;
		return Mathf.Min(1059f, num / (float)OEIKEINGJGO);
	}

	// Token: 0x06011539 RID: 70969 RVA: 0x007B71A0 File Offset: 0x007B53A0
	public void NCHGOOPEDKC()
	{
		if (this.EFAALDFEJEK != null)
		{
			RenderTexture.ReleaseTemporary(this.EFAALDFEJEK);
		}
		this.EFAALDFEJEK = null;
	}

	// Token: 0x0601153A RID: 70970 RVA: 0x007B9D44 File Offset: 0x007B7F44
	private float OAIBALJPOBM(int OEIKEINGJGO)
	{
		float num = (float)base.BBEPCCALAFC.FNFNGEGDCCE().kernelSize * 489f + 1883f;
		return Mathf.Min(1424f, num / (float)OEIKEINGJGO);
	}

	// Token: 0x0400242E RID: 9262
	private RenderTexture EFAALDFEJEK;

	// Token: 0x0400242F RID: 9263
	private const float JJICOGGLANP = 0.024f;

	// Token: 0x04002430 RID: 9264
	private static string GOFANCALMLK = "Hidden/Post FX/Depth Of Field";

	// Token: 0x02000519 RID: 1305
	private static class KAIHPBFAGCL
	{
		// Token: 0x04002431 RID: 9265
		internal static readonly int LFAJBBGEKCK = Shader.PropertyToID("_DepthOfFieldTex");

		// Token: 0x04002432 RID: 9266
		internal static readonly int MJAMKCBMHAA = Shader.PropertyToID("_DepthOfFieldCoCTex");

		// Token: 0x04002433 RID: 9267
		internal static readonly int BDGEKIPEDGL = Shader.PropertyToID("_Distance");

		// Token: 0x04002434 RID: 9268
		internal static readonly int NOIGFGMNPLM = Shader.PropertyToID("_LensCoeff");

		// Token: 0x04002435 RID: 9269
		internal static readonly int KPHGLJLAFIK = Shader.PropertyToID("_MaxCoC");

		// Token: 0x04002436 RID: 9270
		internal static readonly int FIFLGOBMMPD = Shader.PropertyToID("_RcpMaxCoC");

		// Token: 0x04002437 RID: 9271
		internal static readonly int LHHAEHNBKHB = Shader.PropertyToID("_RcpAspect");

		// Token: 0x04002438 RID: 9272
		internal static readonly int OCMLEEAPHNB = Shader.PropertyToID("_MainTex");

		// Token: 0x04002439 RID: 9273
		internal static readonly int ALCBEHDPFGG = Shader.PropertyToID("_CoCTex");

		// Token: 0x0400243A RID: 9274
		internal static readonly int KIAFMPMPGKO = Shader.PropertyToID("_TaaParams");

		// Token: 0x0400243B RID: 9275
		internal static readonly int MMGMEFHOHCO = Shader.PropertyToID("_DepthOfFieldParams");
	}
}
