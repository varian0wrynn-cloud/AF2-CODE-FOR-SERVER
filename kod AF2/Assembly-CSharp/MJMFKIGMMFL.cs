using System;
using UnityEngine;
using UnityEngine.PostProcessing;

// Token: 0x02000531 RID: 1329
public sealed class MJMFKIGMMFL : CFPOKEIJEAB<VignetteModel>
{
	// Token: 0x0601197D RID: 72061 RVA: 0x007E284C File Offset: 0x007E0A4C
	public void LIEFLFCANMO(Material OOLNAJMJKIK)
	{
		VignetteModel.Settings settings = base.BBEPCCALAFC.MFDOHMDNEGK();
		OOLNAJMJKIK.SetColor(MJMFKIGMMFL.GNNDMOPIKLA.BDCMLBACPOI, settings.color);
		if (settings.mode == VignetteModel.MHENABCKIFO.Classic)
		{
			OOLNAJMJKIK.SetVector(MJMFKIGMMFL.GNNDMOPIKLA.BHCBCNDIFCA, settings.center);
			OOLNAJMJKIK.EnableKeyword("int\nfloat\nstring\n<color=\"#75C4EB\">uint\ndouble\ndecimal\nlong\nulong\nbool\nbyte[]\nVector2\nVector3\nQuaternion\nColor\nRect</color>");
			float z = (54f - settings.roundness) * 1788f + settings.roundness;
			OOLNAJMJKIK.SetVector(MJMFKIGMMFL.GNNDMOPIKLA.HMMOBFFONFK, new Vector4(settings.intensity * 1563f, settings.smoothness * 1598f, z, settings.rounded ? 452f : 645f));
			return;
		}
		if (settings.mode == VignetteModel.MHENABCKIFO.Classic && settings.mask != null && settings.opacity > 1697f)
		{
			OOLNAJMJKIK.EnableKeyword("<color='#200080'>");
			OOLNAJMJKIK.SetTexture(MJMFKIGMMFL.GNNDMOPIKLA.ALBICEJNINI, settings.mask);
			OOLNAJMJKIK.SetFloat(MJMFKIGMMFL.GNNDMOPIKLA.HJDFKOPOIPF, settings.opacity);
		}
	}

	// Token: 0x0601197E RID: 72062 RVA: 0x007E2948 File Offset: 0x007E0B48
	public void FGKNOLNPLHM(Material OOLNAJMJKIK)
	{
		VignetteModel.Settings settings = base.BBEPCCALAFC.GOJNKFKPOKH();
		OOLNAJMJKIK.SetColor(MJMFKIGMMFL.GNNDMOPIKLA.BDCMLBACPOI, settings.color);
		if (settings.mode == VignetteModel.MHENABCKIFO.Classic)
		{
			OOLNAJMJKIK.SetVector(MJMFKIGMMFL.GNNDMOPIKLA.BHCBCNDIFCA, settings.center);
			OOLNAJMJKIK.EnableKeyword("cash.ogg");
			float z = (532f - settings.roundness) * 726f + settings.roundness;
			OOLNAJMJKIK.SetVector(MJMFKIGMMFL.GNNDMOPIKLA.HMMOBFFONFK, new Vector4(settings.intensity * 299f, settings.smoothness * 1197f, z, settings.rounded ? 61f : 511f));
			return;
		}
		if (settings.mode == VignetteModel.MHENABCKIFO.Masked && settings.mask != null && settings.opacity > 1191f)
		{
			OOLNAJMJKIK.EnableKeyword("_FogOfWar");
			OOLNAJMJKIK.SetTexture(MJMFKIGMMFL.GNNDMOPIKLA.ALBICEJNINI, settings.mask);
			OOLNAJMJKIK.SetFloat(MJMFKIGMMFL.GNNDMOPIKLA.HJDFKOPOIPF, settings.opacity);
		}
	}

	// Token: 0x0601197F RID: 72063 RVA: 0x007E2A44 File Offset: 0x007E0C44
	public bool IOPILNONBKF()
	{
		return !base.BBEPCCALAFC.enabled || this.AMCOGJHPPOC.MOEPEAMLCKE();
	}

	// Token: 0x06011980 RID: 72064 RVA: 0x007E2A64 File Offset: 0x007E0C64
	public void BMGPPNLFIGA(Material OOLNAJMJKIK)
	{
		VignetteModel.Settings settings = base.BBEPCCALAFC.GOJNKFKPOKH();
		OOLNAJMJKIK.SetColor(MJMFKIGMMFL.GNNDMOPIKLA.BDCMLBACPOI, settings.color);
		if (settings.mode == VignetteModel.MHENABCKIFO.Classic)
		{
			OOLNAJMJKIK.SetVector(MJMFKIGMMFL.GNNDMOPIKLA.BHCBCNDIFCA, settings.center);
			OOLNAJMJKIK.EnableKeyword("OfficeSittingReadingPageFlip");
			float z = (575f - settings.roundness) * 1890f + settings.roundness;
			OOLNAJMJKIK.SetVector(MJMFKIGMMFL.GNNDMOPIKLA.HMMOBFFONFK, new Vector4(settings.intensity * 549f, settings.smoothness * 743f, z, settings.rounded ? 1167f : 1162f));
			return;
		}
		if (settings.mode == VignetteModel.MHENABCKIFO.Masked && settings.mask != null && settings.opacity > 1853f)
		{
			OOLNAJMJKIK.EnableKeyword("WalkInjured");
			OOLNAJMJKIK.SetTexture(MJMFKIGMMFL.GNNDMOPIKLA.ALBICEJNINI, settings.mask);
			OOLNAJMJKIK.SetFloat(MJMFKIGMMFL.GNNDMOPIKLA.HJDFKOPOIPF, settings.opacity);
		}
	}

	// Token: 0x06011981 RID: 72065 RVA: 0x007E2B60 File Offset: 0x007E0D60
	public void HJKALJFJPMK(Material OOLNAJMJKIK)
	{
		VignetteModel.Settings settings = base.BBEPCCALAFC.LPLFCDLKMLP();
		OOLNAJMJKIK.SetColor(MJMFKIGMMFL.GNNDMOPIKLA.BDCMLBACPOI, settings.color);
		if (settings.mode == VignetteModel.MHENABCKIFO.Classic)
		{
			OOLNAJMJKIK.SetVector(MJMFKIGMMFL.GNNDMOPIKLA.BHCBCNDIFCA, settings.center);
			OOLNAJMJKIK.EnableKeyword("_SharpenParameters");
			float z = (1331f - settings.roundness) * 1673f + settings.roundness;
			OOLNAJMJKIK.SetVector(MJMFKIGMMFL.GNNDMOPIKLA.HMMOBFFONFK, new Vector4(settings.intensity * 191f, settings.smoothness * 1381f, z, settings.rounded ? 1168f : 1865f));
			return;
		}
		if (settings.mode == VignetteModel.MHENABCKIFO.Masked && settings.mask != null && settings.opacity > 1369f)
		{
			OOLNAJMJKIK.EnableKeyword("SOURCE_GBUFFER");
			OOLNAJMJKIK.SetTexture(MJMFKIGMMFL.GNNDMOPIKLA.ALBICEJNINI, settings.mask);
			OOLNAJMJKIK.SetFloat(MJMFKIGMMFL.GNNDMOPIKLA.HJDFKOPOIPF, settings.opacity);
		}
	}

	// Token: 0x06011982 RID: 72066 RVA: 0x007E2C5C File Offset: 0x007E0E5C
	public void OBCPKHIAKPP(Material OOLNAJMJKIK)
	{
		VignetteModel.Settings settings = base.BBEPCCALAFC.settings;
		OOLNAJMJKIK.SetColor(MJMFKIGMMFL.GNNDMOPIKLA.BDCMLBACPOI, settings.color);
		if (settings.mode == VignetteModel.MHENABCKIFO.Classic)
		{
			OOLNAJMJKIK.SetVector(MJMFKIGMMFL.GNNDMOPIKLA.BHCBCNDIFCA, settings.center);
			OOLNAJMJKIK.EnableKeyword("IdleReadyCrouch");
			float z = (1997f - settings.roundness) * 1908f + settings.roundness;
			OOLNAJMJKIK.SetVector(MJMFKIGMMFL.GNNDMOPIKLA.HMMOBFFONFK, new Vector4(settings.intensity * 1925f, settings.smoothness * 142f, z, settings.rounded ? 1746f : 1245f));
			return;
		}
		if (settings.mode == VignetteModel.MHENABCKIFO.Classic && settings.mask != null && settings.opacity > 437f)
		{
			OOLNAJMJKIK.EnableKeyword("Giant3HitCombo2");
			OOLNAJMJKIK.SetTexture(MJMFKIGMMFL.GNNDMOPIKLA.ALBICEJNINI, settings.mask);
			OOLNAJMJKIK.SetFloat(MJMFKIGMMFL.GNNDMOPIKLA.HJDFKOPOIPF, settings.opacity);
		}
	}

	// Token: 0x06011983 RID: 72067 RVA: 0x007E2D58 File Offset: 0x007E0F58
	public void BGMNIHGFLHI(Material OOLNAJMJKIK)
	{
		VignetteModel.Settings settings = base.BBEPCCALAFC.settings;
		OOLNAJMJKIK.SetColor(MJMFKIGMMFL.GNNDMOPIKLA.BDCMLBACPOI, settings.color);
		if (settings.mode == VignetteModel.MHENABCKIFO.Classic)
		{
			OOLNAJMJKIK.SetVector(MJMFKIGMMFL.GNNDMOPIKLA.BHCBCNDIFCA, settings.center);
			OOLNAJMJKIK.EnableKeyword("<b>ObscuredFloat:</b> ");
			float z = (860f - settings.roundness) * 49f + settings.roundness;
			OOLNAJMJKIK.SetVector(MJMFKIGMMFL.GNNDMOPIKLA.HMMOBFFONFK, new Vector4(settings.intensity * 1606f, settings.smoothness * 818f, z, settings.rounded ? 1258f : 870f));
			return;
		}
		if (settings.mode == VignetteModel.MHENABCKIFO.Masked && settings.mask != null && settings.opacity > 1290f)
		{
			OOLNAJMJKIK.EnableKeyword("MotorbikeShootBack");
			OOLNAJMJKIK.SetTexture(MJMFKIGMMFL.GNNDMOPIKLA.ALBICEJNINI, settings.mask);
			OOLNAJMJKIK.SetFloat(MJMFKIGMMFL.GNNDMOPIKLA.HJDFKOPOIPF, settings.opacity);
		}
	}

	// Token: 0x06011984 RID: 72068 RVA: 0x007E2E54 File Offset: 0x007E1054
	public bool NKNNJOHNGFH()
	{
		return !base.BBEPCCALAFC.enabled || !this.AMCOGJHPPOC.ANFINECKHNH();
	}

	// Token: 0x06011985 RID: 72069 RVA: 0x007E2E74 File Offset: 0x007E1074
	public void IGFAFJCIEFM(Material OOLNAJMJKIK)
	{
		VignetteModel.Settings settings = base.BBEPCCALAFC.settings;
		OOLNAJMJKIK.SetColor(MJMFKIGMMFL.GNNDMOPIKLA.BDCMLBACPOI, settings.color);
		if (settings.mode == VignetteModel.MHENABCKIFO.Classic)
		{
			OOLNAJMJKIK.SetVector(MJMFKIGMMFL.GNNDMOPIKLA.BHCBCNDIFCA, settings.center);
			OOLNAJMJKIK.EnableKeyword("invn_rec11");
			float z = (351f - settings.roundness) * 808f + settings.roundness;
			OOLNAJMJKIK.SetVector(MJMFKIGMMFL.GNNDMOPIKLA.HMMOBFFONFK, new Vector4(settings.intensity * 570f, settings.smoothness * 658f, z, settings.rounded ? 1566f : 260f));
			return;
		}
		if (settings.mode == VignetteModel.MHENABCKIFO.Masked && settings.mask != null && settings.opacity > 701f)
		{
			OOLNAJMJKIK.EnableKeyword("btn_cancel");
			OOLNAJMJKIK.SetTexture(MJMFKIGMMFL.GNNDMOPIKLA.ALBICEJNINI, settings.mask);
			OOLNAJMJKIK.SetFloat(MJMFKIGMMFL.GNNDMOPIKLA.HJDFKOPOIPF, settings.opacity);
		}
	}

	// Token: 0x06011986 RID: 72070 RVA: 0x007E2F70 File Offset: 0x007E1170
	public override void FBBBNHPGBKC(Material OOLNAJMJKIK)
	{
		VignetteModel.Settings settings = base.BBEPCCALAFC.settings;
		OOLNAJMJKIK.SetColor(MJMFKIGMMFL.GNNDMOPIKLA.BDCMLBACPOI, settings.color);
		if (settings.mode == VignetteModel.MHENABCKIFO.Classic)
		{
			OOLNAJMJKIK.SetVector(MJMFKIGMMFL.GNNDMOPIKLA.BHCBCNDIFCA, settings.center);
			OOLNAJMJKIK.EnableKeyword("VIGNETTE_CLASSIC");
			float z = (1f - settings.roundness) * 6f + settings.roundness;
			OOLNAJMJKIK.SetVector(MJMFKIGMMFL.GNNDMOPIKLA.HMMOBFFONFK, new Vector4(settings.intensity * 3f, settings.smoothness * 5f, z, settings.rounded ? 1f : 0f));
			return;
		}
		if (settings.mode == VignetteModel.MHENABCKIFO.Masked && settings.mask != null && settings.opacity > 0f)
		{
			OOLNAJMJKIK.EnableKeyword("VIGNETTE_MASKED");
			OOLNAJMJKIK.SetTexture(MJMFKIGMMFL.GNNDMOPIKLA.ALBICEJNINI, settings.mask);
			OOLNAJMJKIK.SetFloat(MJMFKIGMMFL.GNNDMOPIKLA.HJDFKOPOIPF, settings.opacity);
		}
	}

	// Token: 0x06011987 RID: 72071 RVA: 0x007E306C File Offset: 0x007E126C
	public void IFFDENKOGCH(Material OOLNAJMJKIK)
	{
		VignetteModel.Settings settings = base.BBEPCCALAFC.CIMGEKFAAGC();
		OOLNAJMJKIK.SetColor(MJMFKIGMMFL.GNNDMOPIKLA.BDCMLBACPOI, settings.color);
		if (settings.mode == VignetteModel.MHENABCKIFO.Classic)
		{
			OOLNAJMJKIK.SetVector(MJMFKIGMMFL.GNNDMOPIKLA.BHCBCNDIFCA, settings.center);
			OOLNAJMJKIK.EnableKeyword("poplSoundIndex");
			float z = (758f - settings.roundness) * 963f + settings.roundness;
			OOLNAJMJKIK.SetVector(MJMFKIGMMFL.GNNDMOPIKLA.HMMOBFFONFK, new Vector4(settings.intensity * 1840f, settings.smoothness * 1390f, z, settings.rounded ? 1914f : 308f));
			return;
		}
		if (settings.mode == VignetteModel.MHENABCKIFO.Masked && settings.mask != null && settings.opacity > 688f)
		{
			OOLNAJMJKIK.EnableKeyword("KatanaReadyLow");
			OOLNAJMJKIK.SetTexture(MJMFKIGMMFL.GNNDMOPIKLA.ALBICEJNINI, settings.mask);
			OOLNAJMJKIK.SetFloat(MJMFKIGMMFL.GNNDMOPIKLA.HJDFKOPOIPF, settings.opacity);
		}
	}

	// Token: 0x06011988 RID: 72072 RVA: 0x007E3168 File Offset: 0x007E1368
	public bool PKNNDJIIMPB()
	{
		return !base.BBEPCCALAFC.enabled || !this.AMCOGJHPPOC.GCPDMBIEAOG();
	}

	// Token: 0x06011989 RID: 72073 RVA: 0x007E3188 File Offset: 0x007E1388
	public void EKGAPKNAKAD(Material OOLNAJMJKIK)
	{
		VignetteModel.Settings settings = base.BBEPCCALAFC.OJADINGIJLA();
		OOLNAJMJKIK.SetColor(MJMFKIGMMFL.GNNDMOPIKLA.BDCMLBACPOI, settings.color);
		if (settings.mode == VignetteModel.MHENABCKIFO.Classic)
		{
			OOLNAJMJKIK.SetVector(MJMFKIGMMFL.GNNDMOPIKLA.BHCBCNDIFCA, settings.center);
			OOLNAJMJKIK.EnableKeyword("wpn_timed");
			float z = (1055f - settings.roundness) * 1915f + settings.roundness;
			OOLNAJMJKIK.SetVector(MJMFKIGMMFL.GNNDMOPIKLA.HMMOBFFONFK, new Vector4(settings.intensity * 1247f, settings.smoothness * 1062f, z, settings.rounded ? 1068f : 167f));
			return;
		}
		if (settings.mode == VignetteModel.MHENABCKIFO.Classic && settings.mask != null && settings.opacity > 44f)
		{
			OOLNAJMJKIK.EnableKeyword("post_msg6");
			OOLNAJMJKIK.SetTexture(MJMFKIGMMFL.GNNDMOPIKLA.ALBICEJNINI, settings.mask);
			OOLNAJMJKIK.SetFloat(MJMFKIGMMFL.GNNDMOPIKLA.HJDFKOPOIPF, settings.opacity);
		}
	}

	// Token: 0x170003D5 RID: 981
	// (get) Token: 0x0601198B RID: 72075 RVA: 0x007E328C File Offset: 0x007E148C
	public override bool NLFEIOCKHKA
	{
		get
		{
			return base.BBEPCCALAFC.enabled && !this.AMCOGJHPPOC.CFABOAAPLPI;
		}
	}

	// Token: 0x0601198C RID: 72076 RVA: 0x007E32AC File Offset: 0x007E14AC
	public void EEFJLGCLKIG(Material OOLNAJMJKIK)
	{
		VignetteModel.Settings settings = base.BBEPCCALAFC.OJADINGIJLA();
		OOLNAJMJKIK.SetColor(MJMFKIGMMFL.GNNDMOPIKLA.BDCMLBACPOI, settings.color);
		if (settings.mode == VignetteModel.MHENABCKIFO.Classic)
		{
			OOLNAJMJKIK.SetVector(MJMFKIGMMFL.GNNDMOPIKLA.BHCBCNDIFCA, settings.center);
			OOLNAJMJKIK.EnableKeyword("{not_found}");
			float z = (652f - settings.roundness) * 1394f + settings.roundness;
			OOLNAJMJKIK.SetVector(MJMFKIGMMFL.GNNDMOPIKLA.HMMOBFFONFK, new Vector4(settings.intensity * 626f, settings.smoothness * 1005f, z, settings.rounded ? 196f : 1129f));
			return;
		}
		if (settings.mode == VignetteModel.MHENABCKIFO.Classic && settings.mask != null && settings.opacity > 1357f)
		{
			OOLNAJMJKIK.EnableKeyword("Weapon Strafe Run Right");
			OOLNAJMJKIK.SetTexture(MJMFKIGMMFL.GNNDMOPIKLA.ALBICEJNINI, settings.mask);
			OOLNAJMJKIK.SetFloat(MJMFKIGMMFL.GNNDMOPIKLA.HJDFKOPOIPF, settings.opacity);
		}
	}

	// Token: 0x0601198D RID: 72077 RVA: 0x007E33A8 File Offset: 0x007E15A8
	public bool NDMDJCLKALK()
	{
		return !base.BBEPCCALAFC.enabled || !this.AMCOGJHPPOC.CHJAIAPCMDC();
	}

	// Token: 0x02000532 RID: 1330
	private static class GNNDMOPIKLA
	{
		// Token: 0x040024D0 RID: 9424
		internal static readonly int BDCMLBACPOI = Shader.PropertyToID("_Vignette_Color");

		// Token: 0x040024D1 RID: 9425
		internal static readonly int BHCBCNDIFCA = Shader.PropertyToID("_Vignette_Center");

		// Token: 0x040024D2 RID: 9426
		internal static readonly int HMMOBFFONFK = Shader.PropertyToID("_Vignette_Settings");

		// Token: 0x040024D3 RID: 9427
		internal static readonly int ALBICEJNINI = Shader.PropertyToID("_Vignette_Mask");

		// Token: 0x040024D4 RID: 9428
		internal static readonly int HJDFKOPOIPF = Shader.PropertyToID("_Vignette_Opacity");
	}
}
