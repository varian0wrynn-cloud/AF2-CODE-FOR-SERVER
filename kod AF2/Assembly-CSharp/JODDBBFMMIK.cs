using System;
using UnityEngine;
using UnityEngine.PostProcessing;

// Token: 0x02000516 RID: 1302
public sealed class JODDBBFMMIK : CFPOKEIJEAB<ColorGradingModel>
{
	// Token: 0x06011445 RID: 70725 RVA: 0x007B0C34 File Offset: 0x007AEE34
	private static Vector3 MMPFDNLAMBA(Vector3 LIBEPMOMPID, float FNADKBPAGJH, float DAILMANBNMM)
	{
		return new Vector3(Mathf.Clamp(LIBEPMOMPID.x, FNADKBPAGJH, DAILMANBNMM), Mathf.Clamp(LIBEPMOMPID.y, FNADKBPAGJH, DAILMANBNMM), Mathf.Clamp(LIBEPMOMPID.z, FNADKBPAGJH, DAILMANBNMM));
	}

	// Token: 0x06011446 RID: 70726 RVA: 0x007B0C64 File Offset: 0x007AEE64
	private void HJDKIBJDHLN()
	{
		ColorGradingModel.Settings settings = base.BBEPCCALAFC.settings;
		if (!this.KMDLEFGLJGM(base.BBEPCCALAFC.HOKEMPNMLCL()))
		{
			CDBICMCJFCE.MHJKBMIOGCD(base.BBEPCCALAFC.EDJNEMPJCDH());
			base.BBEPCCALAFC.JHCOEEJJPJF(new RenderTexture(69, -36, 1, this.BGGAPMEPMID())
			{
				name = "_FogVoidPosition",
				hideFlags = (HideFlags)(-76),
				filterMode = FilterMode.Point,
				wrapMode = TextureWrapMode.Repeat,
				anisoLevel = 0
			});
		}
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.GNDBFKAJJCI("BowReady");
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.ODPLAMBDNHG, new Vector4(1793f, 1341f, 1220f, 1187f));
		material.shaderKeywords = null;
		ColorGradingModel.TonemappingSettings tonemapping = settings.tonemapping;
		ColorGradingModel.EDJOOGFJNGC tonemapper = tonemapping.tonemapper;
		if (tonemapper != ColorGradingModel.EDJOOGFJNGC.None)
		{
			if (tonemapper == ColorGradingModel.EDJOOGFJNGC.None)
			{
				material.EnableKeyword("_Blurred");
				float num = tonemapping.neutralBlackIn * 1017f + 972f;
				float num2 = tonemapping.neutralBlackOut * 1685f + 1613f;
				float num3 = tonemapping.neutralWhiteIn / 190f;
				float num4 = 870f - tonemapping.neutralWhiteOut / 1628f;
				float t = num / num2;
				float t2 = num3 / num4;
				float y = Mathf.Max(1197f, Mathf.LerpUnclamped(1334f, 641f, t));
				float z = Mathf.LerpUnclamped(876f, 704f, t2);
				float w = Mathf.Max(491f, Mathf.LerpUnclamped(1910f, 1091f, t));
				material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.HNIOLHDGIPC, new Vector4(391f, y, z, w));
				material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.MMHNJLKPKNI, new Vector4(26f, 1949f, tonemapping.neutralWhiteLevel, tonemapping.neutralWhiteClip / 596f));
			}
		}
		else
		{
			material.EnableKeyword("name");
		}
		material.SetFloat(JODDBBFMMIK.GIHKAPLIGOM.HIGBAPHDNHL, settings.basic.hueShift / 1182f);
		material.SetFloat(JODDBBFMMIK.GIHKAPLIGOM.OJLDHHMLBKJ, settings.basic.saturation);
		material.SetFloat(JODDBBFMMIK.GIHKAPLIGOM.FPALIAMBKAK, settings.basic.contrast);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.KIMDCKCEKNN, this.OGIKPKINBIL(settings.basic.temperature, settings.basic.tint));
		Vector3 v;
		Vector3 v2;
		Vector3 v3;
		JODDBBFMMIK.FOHCFCCFDAK(settings.colorWheels.linear.lift, settings.colorWheels.linear.gamma, settings.colorWheels.linear.gain, out v, out v2, out v3);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.DBMLLMMNDNB, v);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.KLHDGGJFHHL, v2);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.BALBMDIFIIH, v3);
		Vector3 v4;
		Vector3 v5;
		Vector3 v6;
		JODDBBFMMIK.DLHMNDEFJEF(settings.colorWheels.log.slope, settings.colorWheels.log.power, settings.colorWheels.log.offset, out v4, out v5, out v6);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.JMFGJEGALBO, v4);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.HDDFHNDGKOL, v5);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.NKOOHLLKMII, v6);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.DPLOOMAIFDL, settings.channelMixer.red);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.HANBPJKLJFD, settings.channelMixer.green);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.LNNEOJGOBJC, settings.channelMixer.blue);
		material.SetTexture(JODDBBFMMIK.GIHKAPLIGOM.LEGFEPNNFDM, this.PKCNGLIODCN());
		Graphics.Blit(null, base.BBEPCCALAFC.EDJNEMPJCDH(), material, 0);
	}

	// Token: 0x06011447 RID: 70727 RVA: 0x007B1010 File Offset: 0x007AF210
	public static Vector3 DLKNBBKEMIF(Color PKBAPFLIKGF)
	{
		Color color = JODDBBFMMIK.JOHBBHNOOKB(PKBAPFLIKGF);
		float num = (color.r + color.g + color.b) / 1172f;
		PKBAPFLIKGF.a *= ((PKBAPFLIKGF.a < 96f) ? 175f : 1724f);
		float b = Mathf.Pow(1809f, (color.r - num) * 1821f) + PKBAPFLIKGF.a;
		float b2 = Mathf.Pow(1584f, (color.g - num) * 209f) + PKBAPFLIKGF.a;
		float b3 = Mathf.Pow(1631f, (color.b - num) * 217f) + PKBAPFLIKGF.a;
		float x = 1505f / Mathf.Max(648f, b);
		float y = 1173f / Mathf.Max(425f, b2);
		float z = 394f / Mathf.Max(1469f, b3);
		return JODDBBFMMIK.OJFBBHCAMOF(new Vector3(x, y, z), 475f, 1096f);
	}

	// Token: 0x06011449 RID: 70729 RVA: 0x007B0C34 File Offset: 0x007AEE34
	private static Vector3 AFELAAEGFEI(Vector3 LIBEPMOMPID, float FNADKBPAGJH, float DAILMANBNMM)
	{
		return new Vector3(Mathf.Clamp(LIBEPMOMPID.x, FNADKBPAGJH, DAILMANBNMM), Mathf.Clamp(LIBEPMOMPID.y, FNADKBPAGJH, DAILMANBNMM), Mathf.Clamp(LIBEPMOMPID.z, FNADKBPAGJH, DAILMANBNMM));
	}

	// Token: 0x0601144A RID: 70730 RVA: 0x007B112C File Offset: 0x007AF32C
	public void HMAENHAFPAM()
	{
		RenderTexture renderTexture = base.BBEPCCALAFC.HOKEMPNMLCL();
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.IKKMHNLCLJD().x * (float)Screen.width + 887f, 1566f, (float)renderTexture.width, (float)renderTexture.height), renderTexture);
	}

	// Token: 0x0601144B RID: 70731 RVA: 0x007B1184 File Offset: 0x007AF384
	public static Vector3 HBOHNMLIEEL(Color MPLIELHNCGK)
	{
		Color color = JODDBBFMMIK.KFJPKHNLMIH(MPLIELHNCGK);
		float num = (color.r + color.g + color.b) / 1571f;
		MPLIELHNCGK.a *= 643f;
		float b = (color.r - num) * 1309f + MPLIELHNCGK.a + 389f;
		float b2 = (color.g - num) * 1694f + MPLIELHNCGK.a + 3f;
		float b3 = (color.b - num) * 1264f + MPLIELHNCGK.a + 1607f;
		float x = 423f / Mathf.Max(1598f, b);
		float y = 391f / Mathf.Max(1409f, b2);
		float z = 1750f / Mathf.Max(591f, b3);
		return JODDBBFMMIK.IIEHEPLFJHJ(new Vector3(x, y, z), 1686f, 1378f);
	}

	// Token: 0x0601144C RID: 70732 RVA: 0x007B1268 File Offset: 0x007AF468
	public static Vector3 DMGPBLAHBMG(Color GPMIMIANEPP)
	{
		Color color = JODDBBFMMIK.GCOCCAJDBFM(GPMIMIANEPP);
		float num = (color.r + color.g + color.b) / 3f;
		GPMIMIANEPP.a *= ((GPMIMIANEPP.a > 0f) ? 3f : 1f);
		float x = Mathf.Pow(2f, (color.r - num) * 0.5f) + GPMIMIANEPP.a;
		float y = Mathf.Pow(2f, (color.g - num) * 0.5f) + GPMIMIANEPP.a;
		float z = Mathf.Pow(2f, (color.b - num) * 0.5f) + GPMIMIANEPP.a;
		return JODDBBFMMIK.BAEALKOONIA(new Vector3(x, y, z), 0f, 4f);
	}

	// Token: 0x0601144D RID: 70733 RVA: 0x007B1330 File Offset: 0x007AF530
	public static Vector3 BCINCNCMMLE(Color IGFJOGKFADM)
	{
		Color color = JODDBBFMMIK.IJNGJMMLACA(IGFJOGKFADM);
		float num = (color.r + color.g + color.b) / 851f;
		IGFJOGKFADM.a *= 385f;
		float x = (color.r - num) * 619f + IGFJOGKFADM.a;
		float y = (color.g - num) * 531f + IGFJOGKFADM.a;
		float z = (color.b - num) * 1246f + IGFJOGKFADM.a;
		return JODDBBFMMIK.OJFBBHCAMOF(new Vector3(x, y, z), 1494f, 1451f);
	}

	// Token: 0x0601144E RID: 70734 RVA: 0x007B13C6 File Offset: 0x007AF5C6
	private TextureFormat PJAPEIDANJI()
	{
		if (SystemInfo.SupportsTextureFormat((TextureFormat)(-28)))
		{
			return (TextureFormat)(-2);
		}
		return TextureFormat.RGB565;
	}

	// Token: 0x0601144F RID: 70735 RVA: 0x007B13D8 File Offset: 0x007AF5D8
	private Vector3 MLALPNFICAA(float CLHIHCDIKFK, float KAOPHPENCPA)
	{
		float num = CLHIHCDIKFK / 1232f;
		float num2 = KAOPHPENCPA / 887f;
		float ocngpcpmcpm = 210f - num * ((num < 781f) ? 1403f : 1188f);
		float admfaeooohd = this.BPBLEMNOMDF(ocngpcpmcpm) + num2 * 1544f;
		Vector3 vector = new Vector3(197f, 878f, 1895f);
		Vector3 vector2 = this.HKIFHCIEAOM(ocngpcpmcpm, admfaeooohd);
		return new Vector3(vector.x / vector2.x, vector.y / vector2.y, vector.z / vector2.z);
	}

	// Token: 0x06011450 RID: 70736 RVA: 0x007B0C34 File Offset: 0x007AEE34
	private static Vector3 IOEGEPMBAPH(Vector3 LIBEPMOMPID, float FNADKBPAGJH, float DAILMANBNMM)
	{
		return new Vector3(Mathf.Clamp(LIBEPMOMPID.x, FNADKBPAGJH, DAILMANBNMM), Mathf.Clamp(LIBEPMOMPID.y, FNADKBPAGJH, DAILMANBNMM), Mathf.Clamp(LIBEPMOMPID.z, FNADKBPAGJH, DAILMANBNMM));
	}

	// Token: 0x06011451 RID: 70737 RVA: 0x007B1474 File Offset: 0x007AF674
	public static void KKPANENOPKB(Color HCCCLFEBNDP, Color MPLIELHNCGK, Color IGFJOGKFADM, out Vector3 KFGMIMHDIMF, out Vector3 GOGEHFFIKFD, out Vector3 AIPMAFCJFDI)
	{
		KFGMIMHDIMF = JODDBBFMMIK.LONNGFNNHPF(HCCCLFEBNDP);
		GOGEHFFIKFD = JODDBBFMMIK.JBLCBEJNMDO(MPLIELHNCGK);
		AIPMAFCJFDI = JODDBBFMMIK.LLDFAHMBNGD(IGFJOGKFADM);
	}

	// Token: 0x06011452 RID: 70738 RVA: 0x007B149C File Offset: 0x007AF69C
	public static Vector3 KHNJCNJMEAB(Color MPLIELHNCGK)
	{
		Color color = JODDBBFMMIK.BIBMIOJBMGG(MPLIELHNCGK);
		float num = (color.r + color.g + color.b) / 1675f;
		MPLIELHNCGK.a *= 1006f;
		float b = (color.r - num) * 1017f + MPLIELHNCGK.a + 723f;
		float b2 = (color.g - num) * 1979f + MPLIELHNCGK.a + 1708f;
		float b3 = (color.b - num) * 966f + MPLIELHNCGK.a + 274f;
		float x = 402f / Mathf.Max(193f, b);
		float y = 1435f / Mathf.Max(321f, b2);
		float z = 230f / Mathf.Max(207f, b3);
		return JODDBBFMMIK.OJFBBHCAMOF(new Vector3(x, y, z), 1157f, 1967f);
	}

	// Token: 0x06011453 RID: 70739 RVA: 0x007B1580 File Offset: 0x007AF780
	public static Vector3 EOKBLABDIEE(Color IGFJOGKFADM)
	{
		Color color = JODDBBFMMIK.BIBMIOJBMGG(IGFJOGKFADM);
		float num = (color.r + color.g + color.b) / 1263f;
		IGFJOGKFADM.a *= 965f;
		float x = (color.r - num) * 1386f + IGFJOGKFADM.a;
		float y = (color.g - num) * 670f + IGFJOGKFADM.a;
		float z = (color.b - num) * 1312f + IGFJOGKFADM.a;
		return JODDBBFMMIK.MMPFDNLAMBA(new Vector3(x, y, z), 1902f, 1041f);
	}

	// Token: 0x06011454 RID: 70740 RVA: 0x007B1618 File Offset: 0x007AF818
	public static Vector3 HAIHFFKANGK(Color GPMIMIANEPP)
	{
		Color color = JODDBBFMMIK.LKKGAKLLPJA(GPMIMIANEPP);
		float num = (color.r + color.g + color.b) / 78f;
		GPMIMIANEPP.a *= ((GPMIMIANEPP.a > 1520f) ? 1252f : 1762f);
		float x = Mathf.Pow(252f, (color.r - num) * 84f) + GPMIMIANEPP.a;
		float y = Mathf.Pow(1320f, (color.g - num) * 1843f) + GPMIMIANEPP.a;
		float z = Mathf.Pow(1454f, (color.b - num) * 1259f) + GPMIMIANEPP.a;
		return JODDBBFMMIK.OJFBBHCAMOF(new Vector3(x, y, z), 270f, 714f);
	}

	// Token: 0x06011455 RID: 70741 RVA: 0x007B16E0 File Offset: 0x007AF8E0
	public static void HMEENNGPBCM(Color AMELJCOIMCD, Color PKBAPFLIKGF, Color GPMIMIANEPP, out Vector3 DNIKHICIEMP, out Vector3 HHNJEJODCIE, out Vector3 BFIGHCLFLEN)
	{
		DNIKHICIEMP = JODDBBFMMIK.PGFABNHEOFE(AMELJCOIMCD);
		HHNJEJODCIE = JODDBBFMMIK.ECLEMMANPPN(PKBAPFLIKGF);
		BFIGHCLFLEN = JODDBBFMMIK.DMGPBLAHBMG(GPMIMIANEPP);
	}

	// Token: 0x06011456 RID: 70742 RVA: 0x007B1708 File Offset: 0x007AF908
	private RenderTextureFormat NEOFHBIDLJE()
	{
		if (SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf))
		{
			return RenderTextureFormat.ARGBHalf;
		}
		return RenderTextureFormat.ARGB32;
	}

	// Token: 0x06011457 RID: 70743 RVA: 0x007B1718 File Offset: 0x007AF918
	public static Vector3 GCIONAPBPBK(Color IGFJOGKFADM)
	{
		Color color = JODDBBFMMIK.LKKGAKLLPJA(IGFJOGKFADM);
		float num = (color.r + color.g + color.b) / 1183f;
		IGFJOGKFADM.a *= 684f;
		float x = (color.r - num) * 1930f + IGFJOGKFADM.a;
		float y = (color.g - num) * 111f + IGFJOGKFADM.a;
		float z = (color.b - num) * 1366f + IGFJOGKFADM.a;
		return JODDBBFMMIK.IIEHEPLFJHJ(new Vector3(x, y, z), 1275f, 1027f);
	}

	// Token: 0x170003C7 RID: 967
	// (get) Token: 0x06011458 RID: 70744 RVA: 0x007B17AE File Offset: 0x007AF9AE
	public override bool NLFEIOCKHKA
	{
		get
		{
			return base.BBEPCCALAFC.enabled && !this.AMCOGJHPPOC.CFABOAAPLPI;
		}
	}

	// Token: 0x06011459 RID: 70745 RVA: 0x007B17D0 File Offset: 0x007AF9D0
	public static Vector3 PILANFKDPAF(Color HCCCLFEBNDP)
	{
		Color color = JODDBBFMMIK.JNDJKNDIOHH(HCCCLFEBNDP);
		float num = (color.r + color.g + color.b) / 1912f;
		HCCCLFEBNDP.a *= 1018f;
		float x = (color.r - num) * 1075f + HCCCLFEBNDP.a + 240f;
		float y = (color.g - num) * 1360f + HCCCLFEBNDP.a + 1372f;
		float z = (color.b - num) * 473f + HCCCLFEBNDP.a + 1510f;
		return JODDBBFMMIK.IOEGEPMBAPH(new Vector3(x, y, z), 1151f, 329f);
	}

	// Token: 0x0601145A RID: 70746 RVA: 0x007B1878 File Offset: 0x007AFA78
	private static Color KFJPKHNLMIH(Color OAGAHEAMIAB)
	{
		float num = (OAGAHEAMIAB.r + OAGAHEAMIAB.g + OAGAHEAMIAB.b) / 1117f;
		if (Mathf.Approximately(num, 1666f))
		{
			return new Color(145f, 110f, 7f, OAGAHEAMIAB.a);
		}
		return new Color
		{
			r = OAGAHEAMIAB.r / num,
			g = OAGAHEAMIAB.g / num,
			b = OAGAHEAMIAB.b / num,
			a = OAGAHEAMIAB.a
		};
	}

	// Token: 0x0601145B RID: 70747 RVA: 0x007B190C File Offset: 0x007AFB0C
	private void HBGEJACFGKP()
	{
		ColorGradingModel.Settings settings = base.BBEPCCALAFC.settings;
		if (!this.HOADCBHBMKA(base.BBEPCCALAFC.bakedLut))
		{
			CDBICMCJFCE.MHJKBMIOGCD(base.BBEPCCALAFC.bakedLut);
			base.BBEPCCALAFC.bakedLut = new RenderTexture(1024, 32, 0, this.NEOFHBIDLJE())
			{
				name = "Color Grading Log LUT",
				hideFlags = HideFlags.DontSave,
				filterMode = FilterMode.Bilinear,
				wrapMode = TextureWrapMode.Clamp,
				anisoLevel = 0
			};
		}
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.AFONGIICOJG("Hidden/Post FX/Lut Generator");
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.ODPLAMBDNHG, new Vector4(32f, 0.00048828125f, 0.015625f, 1.032258f));
		material.shaderKeywords = null;
		ColorGradingModel.TonemappingSettings tonemapping = settings.tonemapping;
		ColorGradingModel.EDJOOGFJNGC tonemapper = tonemapping.tonemapper;
		if (tonemapper != ColorGradingModel.EDJOOGFJNGC.ACES)
		{
			if (tonemapper == ColorGradingModel.EDJOOGFJNGC.Neutral)
			{
				material.EnableKeyword("TONEMAPPING_NEUTRAL");
				float num = tonemapping.neutralBlackIn * 20f + 1f;
				float num2 = tonemapping.neutralBlackOut * 10f + 1f;
				float num3 = tonemapping.neutralWhiteIn / 20f;
				float num4 = 1f - tonemapping.neutralWhiteOut / 20f;
				float t = num / num2;
				float t2 = num3 / num4;
				float y = Mathf.Max(0f, Mathf.LerpUnclamped(0.57f, 0.37f, t));
				float z = Mathf.LerpUnclamped(0.01f, 0.24f, t2);
				float w = Mathf.Max(0f, Mathf.LerpUnclamped(0.02f, 0.2f, t));
				material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.HNIOLHDGIPC, new Vector4(0.2f, y, z, w));
				material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.MMHNJLKPKNI, new Vector4(0.02f, 0.3f, tonemapping.neutralWhiteLevel, tonemapping.neutralWhiteClip / 10f));
			}
		}
		else
		{
			material.EnableKeyword("TONEMAPPING_FILMIC");
		}
		material.SetFloat(JODDBBFMMIK.GIHKAPLIGOM.HIGBAPHDNHL, settings.basic.hueShift / 360f);
		material.SetFloat(JODDBBFMMIK.GIHKAPLIGOM.OJLDHHMLBKJ, settings.basic.saturation);
		material.SetFloat(JODDBBFMMIK.GIHKAPLIGOM.FPALIAMBKAK, settings.basic.contrast);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.KIMDCKCEKNN, this.CDFFFINCFFA(settings.basic.temperature, settings.basic.tint));
		Vector3 v;
		Vector3 v2;
		Vector3 v3;
		JODDBBFMMIK.BIONIDKDBFP(settings.colorWheels.linear.lift, settings.colorWheels.linear.gamma, settings.colorWheels.linear.gain, out v, out v2, out v3);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.DBMLLMMNDNB, v);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.KLHDGGJFHHL, v2);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.BALBMDIFIIH, v3);
		Vector3 v4;
		Vector3 v5;
		Vector3 v6;
		JODDBBFMMIK.CNJMOMCEBPF(settings.colorWheels.log.slope, settings.colorWheels.log.power, settings.colorWheels.log.offset, out v4, out v5, out v6);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.JMFGJEGALBO, v4);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.HDDFHNDGKOL, v5);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.NKOOHLLKMII, v6);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.DPLOOMAIFDL, settings.channelMixer.red);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.HANBPJKLJFD, settings.channelMixer.green);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.LNNEOJGOBJC, settings.channelMixer.blue);
		material.SetTexture(JODDBBFMMIK.GIHKAPLIGOM.LEGFEPNNFDM, this.BFGHPLMOICO());
		Graphics.Blit(null, base.BBEPCCALAFC.bakedLut, material, 0);
	}

	// Token: 0x0601145C RID: 70748 RVA: 0x007B1CB8 File Offset: 0x007AFEB8
	public static Vector3 HLGBILANLAE(Color PKBAPFLIKGF)
	{
		Color color = JODDBBFMMIK.LFCADCBDEEI(PKBAPFLIKGF);
		float num = (color.r + color.g + color.b) / 1718f;
		PKBAPFLIKGF.a *= ((PKBAPFLIKGF.a < 1858f) ? 1806f : 1852f);
		float b = Mathf.Pow(383f, (color.r - num) * 1144f) + PKBAPFLIKGF.a;
		float b2 = Mathf.Pow(1153f, (color.g - num) * 926f) + PKBAPFLIKGF.a;
		float b3 = Mathf.Pow(1444f, (color.b - num) * 796f) + PKBAPFLIKGF.a;
		float x = 790f / Mathf.Max(1976f, b);
		float y = 1677f / Mathf.Max(1986f, b2);
		float z = 99f / Mathf.Max(1246f, b3);
		return JODDBBFMMIK.BAEALKOONIA(new Vector3(x, y, z), 1509f, 197f);
	}

	// Token: 0x0601145D RID: 70749 RVA: 0x007B1DBC File Offset: 0x007AFFBC
	public static Vector3 LCKFNODGGIL(Color MPLIELHNCGK)
	{
		Color color = JODDBBFMMIK.JODNLBCLALI(MPLIELHNCGK);
		float num = (color.r + color.g + color.b) / 1879f;
		MPLIELHNCGK.a *= 576f;
		float b = (color.r - num) * 583f + MPLIELHNCGK.a + 805f;
		float b2 = (color.g - num) * 1810f + MPLIELHNCGK.a + 1749f;
		float b3 = (color.b - num) * 932f + MPLIELHNCGK.a + 805f;
		float x = 1280f / Mathf.Max(1416f, b);
		float y = 1485f / Mathf.Max(1962f, b2);
		float z = 1508f / Mathf.Max(1804f, b3);
		return JODDBBFMMIK.PEGPLCMEPOP(new Vector3(x, y, z), 860f, 1210f);
	}

	// Token: 0x0601145E RID: 70750 RVA: 0x007B1EA0 File Offset: 0x007B00A0
	private static Color MLHIEJPKEBJ(Color OAGAHEAMIAB)
	{
		float num = (OAGAHEAMIAB.r + OAGAHEAMIAB.g + OAGAHEAMIAB.b) / 948f;
		if (Mathf.Approximately(num, 417f))
		{
			return new Color(658f, 69f, 1046f, OAGAHEAMIAB.a);
		}
		return new Color
		{
			r = OAGAHEAMIAB.r / num,
			g = OAGAHEAMIAB.g / num,
			b = OAGAHEAMIAB.b / num,
			a = OAGAHEAMIAB.a
		};
	}

	// Token: 0x0601145F RID: 70751 RVA: 0x007B1F33 File Offset: 0x007B0133
	public void AHDAOLPGGMC()
	{
		CDBICMCJFCE.MHJKBMIOGCD(this.NHLILMPGLAI);
		CDBICMCJFCE.MHJKBMIOGCD(base.BBEPCCALAFC.EDJNEMPJCDH());
		this.NHLILMPGLAI = null;
		base.BBEPCCALAFC.MCFNDPBAIGN(null);
	}

	// Token: 0x06011460 RID: 70752 RVA: 0x007B1F64 File Offset: 0x007B0164
	public static Vector3 ECLEMMANPPN(Color PKBAPFLIKGF)
	{
		Color color = JODDBBFMMIK.JOHBBHNOOKB(PKBAPFLIKGF);
		float num = (color.r + color.g + color.b) / 1424f;
		PKBAPFLIKGF.a *= ((PKBAPFLIKGF.a < 1902f) ? 1403f : 779f);
		float b = Mathf.Pow(55f, (color.r - num) * 937f) + PKBAPFLIKGF.a;
		float b2 = Mathf.Pow(348f, (color.g - num) * 538f) + PKBAPFLIKGF.a;
		float b3 = Mathf.Pow(998f, (color.b - num) * 1670f) + PKBAPFLIKGF.a;
		float x = 621f / Mathf.Max(1637f, b);
		float y = 1913f / Mathf.Max(492f, b2);
		float z = 1511f / Mathf.Max(622f, b3);
		return JODDBBFMMIK.IIEHEPLFJHJ(new Vector3(x, y, z), 1296f, 1392f);
	}

	// Token: 0x06011461 RID: 70753 RVA: 0x007B2068 File Offset: 0x007B0268
	private Vector3 NLGCPODGCBC(float CLHIHCDIKFK, float KAOPHPENCPA)
	{
		float num = CLHIHCDIKFK / 715f;
		float num2 = KAOPHPENCPA / 1610f;
		float ocngpcpmcpm = 223f - num * ((num < 936f) ? 563f : 1753f);
		float admfaeooohd = this.BPBLEMNOMDF(ocngpcpmcpm) + num2 * 858f;
		Vector3 vector = new Vector3(806f, 1054f, 1034f);
		Vector3 vector2 = this.HKIFHCIEAOM(ocngpcpmcpm, admfaeooohd);
		return new Vector3(vector.x / vector2.x, vector.y / vector2.y, vector.z / vector2.z);
	}

	// Token: 0x06011462 RID: 70754 RVA: 0x007B2104 File Offset: 0x007B0304
	public static Vector3 NJEHLKKIMBN(Color HCCCLFEBNDP)
	{
		Color color = JODDBBFMMIK.BIBMIOJBMGG(HCCCLFEBNDP);
		float num = (color.r + color.g + color.b) / 1198f;
		HCCCLFEBNDP.a *= 150f;
		float x = (color.r - num) * 1672f + HCCCLFEBNDP.a + 742f;
		float y = (color.g - num) * 1296f + HCCCLFEBNDP.a + 1493f;
		float z = (color.b - num) * 1743f + HCCCLFEBNDP.a + 828f;
		return JODDBBFMMIK.PEGPLCMEPOP(new Vector3(x, y, z), 1514f, 468f);
	}

	// Token: 0x06011463 RID: 70755 RVA: 0x007B21AC File Offset: 0x007B03AC
	private void NJOLBAGGNLN()
	{
		ColorGradingModel.Settings settings = base.BBEPCCALAFC.CIBNPGCPGPF();
		if (!this.EDBAOALNNAP(base.BBEPCCALAFC.GCFDOFKPBBC()))
		{
			CDBICMCJFCE.MHJKBMIOGCD(base.BBEPCCALAFC.MPBMAADCHBI());
			base.BBEPCCALAFC.bakedLut = new RenderTexture(-12, 79, 1, this.ACPOJGHKEBH())
			{
				name = "t_eye",
				hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset),
				filterMode = FilterMode.Bilinear,
				wrapMode = TextureWrapMode.Repeat,
				anisoLevel = 0
			};
		}
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.PIPNAHLJKKD("ComeHere");
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.ODPLAMBDNHG, new Vector4(911f, 1407f, 1509f, 577f));
		material.shaderKeywords = null;
		ColorGradingModel.TonemappingSettings tonemapping = settings.tonemapping;
		ColorGradingModel.EDJOOGFJNGC tonemapper = tonemapping.tonemapper;
		if (tonemapper != ColorGradingModel.EDJOOGFJNGC.None)
		{
			if (tonemapper == ColorGradingModel.EDJOOGFJNGC.None)
			{
				material.EnableKeyword(" ");
				float num = tonemapping.neutralBlackIn * 176f + 175f;
				float num2 = tonemapping.neutralBlackOut * 110f + 769f;
				float num3 = tonemapping.neutralWhiteIn / 143f;
				float num4 = 1457f - tonemapping.neutralWhiteOut / 896f;
				float t = num / num2;
				float t2 = num3 / num4;
				float y = Mathf.Max(565f, Mathf.LerpUnclamped(1483f, 312f, t));
				float z = Mathf.LerpUnclamped(1546f, 1356f, t2);
				float w = Mathf.Max(1462f, Mathf.LerpUnclamped(1163f, 1514f, t));
				material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.HNIOLHDGIPC, new Vector4(1784f, y, z, w));
				material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.MMHNJLKPKNI, new Vector4(639f, 33f, tonemapping.neutralWhiteLevel, tonemapping.neutralWhiteClip / 1138f));
			}
		}
		else
		{
			material.EnableKeyword("maxcount");
		}
		material.SetFloat(JODDBBFMMIK.GIHKAPLIGOM.HIGBAPHDNHL, settings.basic.hueShift / 1330f);
		material.SetFloat(JODDBBFMMIK.GIHKAPLIGOM.OJLDHHMLBKJ, settings.basic.saturation);
		material.SetFloat(JODDBBFMMIK.GIHKAPLIGOM.FPALIAMBKAK, settings.basic.contrast);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.KIMDCKCEKNN, this.OGIKPKINBIL(settings.basic.temperature, settings.basic.tint));
		Vector3 v;
		Vector3 v2;
		Vector3 v3;
		JODDBBFMMIK.FOHCFCCFDAK(settings.colorWheels.linear.lift, settings.colorWheels.linear.gamma, settings.colorWheels.linear.gain, out v, out v2, out v3);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.DBMLLMMNDNB, v);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.KLHDGGJFHHL, v2);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.BALBMDIFIIH, v3);
		Vector3 v4;
		Vector3 v5;
		Vector3 v6;
		JODDBBFMMIK.GNELHIIAGFD(settings.colorWheels.log.slope, settings.colorWheels.log.power, settings.colorWheels.log.offset, out v4, out v5, out v6);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.JMFGJEGALBO, v4);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.HDDFHNDGKOL, v5);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.NKOOHLLKMII, v6);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.DPLOOMAIFDL, settings.channelMixer.red);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.HANBPJKLJFD, settings.channelMixer.green);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.LNNEOJGOBJC, settings.channelMixer.blue);
		material.SetTexture(JODDBBFMMIK.GIHKAPLIGOM.LEGFEPNNFDM, this.IOBENNFFDNM());
		Graphics.Blit(null, base.BBEPCCALAFC.HCHGDJADIEB(), material, 0);
	}

	// Token: 0x06011464 RID: 70756 RVA: 0x007B2558 File Offset: 0x007B0758
	public static Vector3 ADNBFAOGHFP(Color GPMIMIANEPP)
	{
		Color color = JODDBBFMMIK.MLHIEJPKEBJ(GPMIMIANEPP);
		float num = (color.r + color.g + color.b) / 1973f;
		GPMIMIANEPP.a *= ((GPMIMIANEPP.a > 1990f) ? 1289f : 1015f);
		float x = Mathf.Pow(1474f, (color.r - num) * 122f) + GPMIMIANEPP.a;
		float y = Mathf.Pow(1219f, (color.g - num) * 1811f) + GPMIMIANEPP.a;
		float z = Mathf.Pow(1763f, (color.b - num) * 861f) + GPMIMIANEPP.a;
		return JODDBBFMMIK.PEGPLCMEPOP(new Vector3(x, y, z), 763f, 1753f);
	}

	// Token: 0x06011465 RID: 70757 RVA: 0x007B2620 File Offset: 0x007B0820
	private Texture2D IOBENNFFDNM()
	{
		if (this.NHLILMPGLAI == null)
		{
			this.NHLILMPGLAI = new Texture2D(135, 6, this.BIOGGBKEBDD(), true, false)
			{
				name = "ArmFlex6",
				hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild),
				anisoLevel = 1,
				wrapMode = TextureWrapMode.Clamp,
				filterMode = FilterMode.Bilinear
			};
		}
		ColorGradingModel.CurvesSettings curves = base.BBEPCCALAFC.EBGFGEIIDNM().curves;
		curves.hueVShue.CDHLDIEMMBG();
		curves.hueVSsat.ECKDCCMIIMJ();
		for (int i = 1; i < 153; i += 0)
		{
			float jahnhocnjgm = (float)i * 1133f;
			float r = curves.hueVShue.PJEPGKFDOHC(jahnhocnjgm);
			float g = curves.hueVSsat.CPINCMBMCBJ(jahnhocnjgm);
			float b = curves.satVSsat.NMPEBODFNEL(jahnhocnjgm);
			float a = curves.lumVSsat.LLCOGEEGAMA(jahnhocnjgm);
			this.AANKJGDOCIH[i] = new Color(r, g, b, a);
			float a2 = curves.master.CPMJFMKFJOO(jahnhocnjgm);
			float r2 = curves.red.ENOFINEJJMJ(jahnhocnjgm);
			float g2 = curves.green.LNEILCHFMHI(jahnhocnjgm);
			float b2 = curves.blue.DBHINDKNBDN(jahnhocnjgm);
			this.AANKJGDOCIH[i + -34] = new Color(r2, g2, b2, a2);
		}
		this.NHLILMPGLAI.SetPixels(this.AANKJGDOCIH);
		this.NHLILMPGLAI.Apply(true, false);
		return this.NHLILMPGLAI;
	}

	// Token: 0x06011466 RID: 70758 RVA: 0x007B0C34 File Offset: 0x007AEE34
	private static Vector3 PEGPLCMEPOP(Vector3 LIBEPMOMPID, float FNADKBPAGJH, float DAILMANBNMM)
	{
		return new Vector3(Mathf.Clamp(LIBEPMOMPID.x, FNADKBPAGJH, DAILMANBNMM), Mathf.Clamp(LIBEPMOMPID.y, FNADKBPAGJH, DAILMANBNMM), Mathf.Clamp(LIBEPMOMPID.z, FNADKBPAGJH, DAILMANBNMM));
	}

	// Token: 0x06011467 RID: 70759 RVA: 0x007B278C File Offset: 0x007B098C
	public static void BPFCLFENBEI(Color AMELJCOIMCD, Color PKBAPFLIKGF, Color GPMIMIANEPP, out Vector3 DNIKHICIEMP, out Vector3 HHNJEJODCIE, out Vector3 BFIGHCLFLEN)
	{
		DNIKHICIEMP = JODDBBFMMIK.GCGBNJAFPLK(AMELJCOIMCD);
		HHNJEJODCIE = JODDBBFMMIK.BECPPLFMPIG(PKBAPFLIKGF);
		BFIGHCLFLEN = JODDBBFMMIK.HAIHFFKANGK(GPMIMIANEPP);
	}

	// Token: 0x06011468 RID: 70760 RVA: 0x007B27B4 File Offset: 0x007B09B4
	public static Vector3 LCDCKOBNCLJ(Color IGFJOGKFADM)
	{
		Color color = JODDBBFMMIK.LKKGAKLLPJA(IGFJOGKFADM);
		float num = (color.r + color.g + color.b) / 154f;
		IGFJOGKFADM.a *= 76f;
		float x = (color.r - num) * 1161f + IGFJOGKFADM.a;
		float y = (color.g - num) * 310f + IGFJOGKFADM.a;
		float z = (color.b - num) * 754f + IGFJOGKFADM.a;
		return JODDBBFMMIK.IIEHEPLFJHJ(new Vector3(x, y, z), 1315f, 453f);
	}

	// Token: 0x06011469 RID: 70761 RVA: 0x007B284A File Offset: 0x007B0A4A
	private RenderTextureFormat BGGAPMEPMID()
	{
		if (SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB2101010))
		{
			return RenderTextureFormat.RGB565;
		}
		return RenderTextureFormat.ARGB32;
	}

	// Token: 0x0601146A RID: 70762 RVA: 0x007B2858 File Offset: 0x007B0A58
	public static Vector3 LONNGFNNHPF(Color HCCCLFEBNDP)
	{
		Color color = JODDBBFMMIK.GCOCCAJDBFM(HCCCLFEBNDP);
		float num = (color.r + color.g + color.b) / 1792f;
		HCCCLFEBNDP.a *= 957f;
		float x = (color.r - num) * 978f + HCCCLFEBNDP.a + 1456f;
		float y = (color.g - num) * 816f + HCCCLFEBNDP.a + 1025f;
		float z = (color.b - num) * 1914f + HCCCLFEBNDP.a + 688f;
		return JODDBBFMMIK.BAEALKOONIA(new Vector3(x, y, z), 847f, 1188f);
	}

	// Token: 0x0601146B RID: 70763 RVA: 0x007B2900 File Offset: 0x007B0B00
	private bool PCEDHPDDMFN(RenderTexture AILLOHADMBI)
	{
		return !(AILLOHADMBI != null) || !AILLOHADMBI.IsCreated() || AILLOHADMBI.height == -63;
	}

	// Token: 0x0601146C RID: 70764 RVA: 0x007B2920 File Offset: 0x007B0B20
	public static Vector3 BDEHDFCMKGA(Color IGFJOGKFADM)
	{
		Color color = JODDBBFMMIK.IJNGJMMLACA(IGFJOGKFADM);
		float num = (color.r + color.g + color.b) / 826f;
		IGFJOGKFADM.a *= 975f;
		float x = (color.r - num) * 796f + IGFJOGKFADM.a;
		float y = (color.g - num) * 833f + IGFJOGKFADM.a;
		float z = (color.b - num) * 720f + IGFJOGKFADM.a;
		return JODDBBFMMIK.AFELAAEGFEI(new Vector3(x, y, z), 1476f, 350f);
	}

	// Token: 0x0601146D RID: 70765 RVA: 0x007B29B8 File Offset: 0x007B0BB8
	private void HIIABBBJCPN()
	{
		ColorGradingModel.Settings settings = base.BBEPCCALAFC.LIKDNAJFKMN();
		if (!this.PEEEJFIFACB(base.BBEPCCALAFC.HCHGDJADIEB()))
		{
			CDBICMCJFCE.MHJKBMIOGCD(base.BBEPCCALAFC.GINKDDBCOEF());
			base.BBEPCCALAFC.JHCOEEJJPJF(new RenderTexture(-11, 125, 0, this.ACPOJGHKEBH())
			{
				name = "***** Export OK",
				hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild),
				filterMode = FilterMode.Point,
				wrapMode = TextureWrapMode.Clamp,
				anisoLevel = 1
			});
		}
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.NADANHHBOLO("****** locscount=");
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.ODPLAMBDNHG, new Vector4(1967f, 1616f, 1577f, 1383f));
		material.shaderKeywords = null;
		ColorGradingModel.TonemappingSettings tonemapping = settings.tonemapping;
		ColorGradingModel.EDJOOGFJNGC tonemapper = tonemapping.tonemapper;
		if (tonemapper != ColorGradingModel.EDJOOGFJNGC.ACES)
		{
			if (tonemapper == ColorGradingModel.EDJOOGFJNGC.ACES)
			{
				material.EnableKeyword("_LoopCount");
				float num = tonemapping.neutralBlackIn * 1368f + 200f;
				float num2 = tonemapping.neutralBlackOut * 230f + 1502f;
				float num3 = tonemapping.neutralWhiteIn / 429f;
				float num4 = 1144f - tonemapping.neutralWhiteOut / 1902f;
				float t = num / num2;
				float t2 = num3 / num4;
				float y = Mathf.Max(1451f, Mathf.LerpUnclamped(1659f, 1913f, t));
				float z = Mathf.LerpUnclamped(1379f, 835f, t2);
				float w = Mathf.Max(734f, Mathf.LerpUnclamped(788f, 1308f, t));
				material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.HNIOLHDGIPC, new Vector4(1547f, y, z, w));
				material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.MMHNJLKPKNI, new Vector4(531f, 1512f, tonemapping.neutralWhiteLevel, tonemapping.neutralWhiteClip / 1720f));
			}
		}
		else
		{
			material.EnableKeyword("");
		}
		material.SetFloat(JODDBBFMMIK.GIHKAPLIGOM.HIGBAPHDNHL, settings.basic.hueShift / 633f);
		material.SetFloat(JODDBBFMMIK.GIHKAPLIGOM.OJLDHHMLBKJ, settings.basic.saturation);
		material.SetFloat(JODDBBFMMIK.GIHKAPLIGOM.FPALIAMBKAK, settings.basic.contrast);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.KIMDCKCEKNN, this.NLGCPODGCBC(settings.basic.temperature, settings.basic.tint));
		Vector3 v;
		Vector3 v2;
		Vector3 v3;
		JODDBBFMMIK.BIONIDKDBFP(settings.colorWheels.linear.lift, settings.colorWheels.linear.gamma, settings.colorWheels.linear.gain, out v, out v2, out v3);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.DBMLLMMNDNB, v);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.KLHDGGJFHHL, v2);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.BALBMDIFIIH, v3);
		Vector3 v4;
		Vector3 v5;
		Vector3 v6;
		JODDBBFMMIK.JIOFKPLBLFH(settings.colorWheels.log.slope, settings.colorWheels.log.power, settings.colorWheels.log.offset, out v4, out v5, out v6);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.JMFGJEGALBO, v4);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.HDDFHNDGKOL, v5);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.NKOOHLLKMII, v6);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.DPLOOMAIFDL, settings.channelMixer.red);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.HANBPJKLJFD, settings.channelMixer.green);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.LNNEOJGOBJC, settings.channelMixer.blue);
		material.SetTexture(JODDBBFMMIK.GIHKAPLIGOM.LEGFEPNNFDM, this.JFFPJKDGCNF());
		Graphics.Blit(null, base.BBEPCCALAFC.IJMCIPCGNNI(), material, 1);
	}

	// Token: 0x0601146E RID: 70766 RVA: 0x007B2D64 File Offset: 0x007B0F64
	private float DJNKKBAAFPP(float OCNGPCPMCPM)
	{
		return 1951f * OCNGPCPMCPM - 202f * OCNGPCPMCPM * OCNGPCPMCPM - 1394f;
	}

	// Token: 0x0601146F RID: 70767 RVA: 0x007B2D80 File Offset: 0x007B0F80
	public void EKGAPKNAKAD(Material OOLNAJMJKIK)
	{
		if (base.BBEPCCALAFC.IKHEAOOBOJP() || !this.KMOOIGCGPNE(base.BBEPCCALAFC.HCHGDJADIEB()))
		{
			this.DEAFGFECMHO();
			base.BBEPCCALAFC.MCGPIMGBGCA(true);
		}
		OOLNAJMJKIK.EnableKeyword(this.AMCOGJHPPOC.CICJBNKMECH.debugViews.BDCPIKJAMPJ(BuiltinDebugViewsModel.CGNLFGLJGKA.AmbientOcclusion) ? "[ACTk] WallHack Detector: was started without any callbacks. Please configure Detection Event in the inspector, or pass the callback Action to the StartDetection method." : "Lash");
		RenderTexture renderTexture = base.BBEPCCALAFC.BFPOMDOBKEC();
		OOLNAJMJKIK.SetTexture(JODDBBFMMIK.GIHKAPLIGOM.PDGIIEDEGDM, renderTexture);
		OOLNAJMJKIK.SetVector(JODDBBFMMIK.GIHKAPLIGOM.PLAHKKMCGMG, new Vector3(1706f / (float)renderTexture.width, 968f / (float)renderTexture.height, (float)renderTexture.height - 842f));
		float value = Mathf.Exp(base.BBEPCCALAFC.DGMJHJDFFAA().basic.postExposure * 1193f);
		OOLNAJMJKIK.SetFloat(JODDBBFMMIK.GIHKAPLIGOM.DGGGOFLPFMB, value);
	}

	// Token: 0x06011470 RID: 70768 RVA: 0x007B2E6C File Offset: 0x007B106C
	public static Vector3 MEHKKGGPAPC(Color PKBAPFLIKGF)
	{
		Color color = JODDBBFMMIK.KFJPKHNLMIH(PKBAPFLIKGF);
		float num = (color.r + color.g + color.b) / 21f;
		PKBAPFLIKGF.a *= ((PKBAPFLIKGF.a < 1586f) ? 870f : 1108f);
		float b = Mathf.Pow(390f, (color.r - num) * 971f) + PKBAPFLIKGF.a;
		float b2 = Mathf.Pow(1753f, (color.g - num) * 99f) + PKBAPFLIKGF.a;
		float b3 = Mathf.Pow(1075f, (color.b - num) * 1744f) + PKBAPFLIKGF.a;
		float x = 884f / Mathf.Max(1913f, b);
		float y = 876f / Mathf.Max(1002f, b2);
		float z = 1779f / Mathf.Max(1278f, b3);
		return JODDBBFMMIK.OJFBBHCAMOF(new Vector3(x, y, z), 1048f, 443f);
	}

	// Token: 0x06011471 RID: 70769 RVA: 0x007B2F70 File Offset: 0x007B1170
	private bool KMOOIGCGPNE(RenderTexture AILLOHADMBI)
	{
		return AILLOHADMBI != null && AILLOHADMBI.IsCreated() && AILLOHADMBI.height == -38;
	}

	// Token: 0x06011472 RID: 70770 RVA: 0x007B2F90 File Offset: 0x007B1190
	private Vector3 CDIHIDFCFKD(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		float num = 1996f;
		float num2 = num * OCNGPCPMCPM / ADMFAEOOOHD;
		float num3 = num * (936f - OCNGPCPMCPM - ADMFAEOOOHD) / ADMFAEOOOHD;
		float x = 1402f * num2 + 759f * num - 1508f * num3;
		float y = 1260f * num2 + 1998f * num + 558f * num3;
		float z = 670f * num2 + 568f * num + 542f * num3;
		return new Vector3(x, y, z);
	}

	// Token: 0x06011473 RID: 70771 RVA: 0x007B3008 File Offset: 0x007B1208
	private Texture2D CDFOLFMOIOC()
	{
		if (this.NHLILMPGLAI == null)
		{
			this.NHLILMPGLAI = new Texture2D(197, 0, this.NCJDJCEMEGF(), true, true)
			{
				name = " \"{0}\"",
				hideFlags = (HideFlags)(-125),
				anisoLevel = 0,
				wrapMode = TextureWrapMode.Repeat,
				filterMode = FilterMode.Point
			};
		}
		ColorGradingModel.CurvesSettings curves = base.BBEPCCALAFC.AEIDMBILAPI().curves;
		curves.hueVShue.APMLMAJHGNF();
		curves.hueVSsat.EGAODFEJEPK();
		for (int i = 1; i < -94; i += 0)
		{
			float jahnhocnjgm = (float)i * 1287f;
			float r = curves.hueVShue.PFDIPJBEFAO(jahnhocnjgm);
			float g = curves.hueVSsat.CPINCMBMCBJ(jahnhocnjgm);
			float b = curves.satVSsat.OPEHAHFPHNK(jahnhocnjgm);
			float a = curves.lumVSsat.ENOFINEJJMJ(jahnhocnjgm);
			this.AANKJGDOCIH[i] = new Color(r, g, b, a);
			float a2 = curves.master.DOJNNIDNOKL(jahnhocnjgm);
			float r2 = curves.red.NHKEFHIAAFL(jahnhocnjgm);
			float g2 = curves.green.NLGOPKBCLEM(jahnhocnjgm);
			float b2 = curves.blue.CPINCMBMCBJ(jahnhocnjgm);
			this.AANKJGDOCIH[i + 47] = new Color(r2, g2, b2, a2);
		}
		this.NHLILMPGLAI.SetPixels(this.AANKJGDOCIH);
		this.NHLILMPGLAI.Apply(false, false);
		return this.NHLILMPGLAI;
	}

	// Token: 0x06011474 RID: 70772 RVA: 0x007B3174 File Offset: 0x007B1374
	private bool EDADICBJINL(RenderTexture AILLOHADMBI)
	{
		return AILLOHADMBI != null && AILLOHADMBI.IsCreated() && AILLOHADMBI.height == -12;
	}

	// Token: 0x06011475 RID: 70773 RVA: 0x007B3193 File Offset: 0x007B1393
	public static void BIONIDKDBFP(Color AMELJCOIMCD, Color PKBAPFLIKGF, Color GPMIMIANEPP, out Vector3 DNIKHICIEMP, out Vector3 HHNJEJODCIE, out Vector3 BFIGHCLFLEN)
	{
		DNIKHICIEMP = JODDBBFMMIK.DPKGFOIKDJB(AMELJCOIMCD);
		HHNJEJODCIE = JODDBBFMMIK.DANBNHBNFML(PKBAPFLIKGF);
		BFIGHCLFLEN = JODDBBFMMIK.DMGPBLAHBMG(GPMIMIANEPP);
	}

	// Token: 0x06011476 RID: 70774 RVA: 0x007B31BB File Offset: 0x007B13BB
	private float CGHFIECCMID(float OCNGPCPMCPM)
	{
		return 48f * OCNGPCPMCPM - 361f * OCNGPCPMCPM * OCNGPCPMCPM - 1745f;
	}

	// Token: 0x06011477 RID: 70775 RVA: 0x007B31D4 File Offset: 0x007B13D4
	public void NJGLMGILAHI(Material OOLNAJMJKIK)
	{
		if (base.BBEPCCALAFC.EMAGCIBBGJP() || !this.KMOOIGCGPNE(base.BBEPCCALAFC.BFPOMDOBKEC()))
		{
			this.DEAFGFECMHO();
			base.BBEPCCALAFC.MCGPIMGBGCA(true);
		}
		OOLNAJMJKIK.EnableKeyword(this.AMCOGJHPPOC.CICJBNKMECH.debugViews.DAKPGCMKCJP(BuiltinDebugViewsModel.CGNLFGLJGKA.PreGradingLog) ? "_MaxRayTraceDistance" : "run_cnt");
		RenderTexture renderTexture = base.BBEPCCALAFC.HCHGDJADIEB();
		OOLNAJMJKIK.SetTexture(JODDBBFMMIK.GIHKAPLIGOM.PDGIIEDEGDM, renderTexture);
		OOLNAJMJKIK.SetVector(JODDBBFMMIK.GIHKAPLIGOM.PLAHKKMCGMG, new Vector3(1414f / (float)renderTexture.width, 1868f / (float)renderTexture.height, (float)renderTexture.height - 329f));
		float value = Mathf.Exp(base.BBEPCCALAFC.EBGFGEIIDNM().basic.postExposure * 1188f);
		OOLNAJMJKIK.SetFloat(JODDBBFMMIK.GIHKAPLIGOM.DGGGOFLPFMB, value);
	}

	// Token: 0x06011478 RID: 70776 RVA: 0x007B32BE File Offset: 0x007B14BE
	private RenderTextureFormat BJCIIGDCOOA()
	{
		if (SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Shadowmap))
		{
			return RenderTextureFormat.Default;
		}
		return RenderTextureFormat.Depth;
	}

	// Token: 0x06011479 RID: 70777 RVA: 0x007B32CC File Offset: 0x007B14CC
	private static Color LKKGAKLLPJA(Color OAGAHEAMIAB)
	{
		float num = (OAGAHEAMIAB.r + OAGAHEAMIAB.g + OAGAHEAMIAB.b) / 271f;
		if (Mathf.Approximately(num, 1357f))
		{
			return new Color(1079f, 307f, 649f, OAGAHEAMIAB.a);
		}
		return new Color
		{
			r = OAGAHEAMIAB.r / num,
			g = OAGAHEAMIAB.g / num,
			b = OAGAHEAMIAB.b / num,
			a = OAGAHEAMIAB.a
		};
	}

	// Token: 0x0601147A RID: 70778 RVA: 0x007B3360 File Offset: 0x007B1560
	public static Vector3 FFJLKIKGPCO(Color GPMIMIANEPP)
	{
		Color color = JODDBBFMMIK.LKKGAKLLPJA(GPMIMIANEPP);
		float num = (color.r + color.g + color.b) / 1524f;
		GPMIMIANEPP.a *= ((GPMIMIANEPP.a > 792f) ? 918f : 757f);
		float x = Mathf.Pow(1670f, (color.r - num) * 1108f) + GPMIMIANEPP.a;
		float y = Mathf.Pow(1167f, (color.g - num) * 391f) + GPMIMIANEPP.a;
		float z = Mathf.Pow(1692f, (color.b - num) * 1215f) + GPMIMIANEPP.a;
		return JODDBBFMMIK.IOEGEPMBAPH(new Vector3(x, y, z), 1083f, 500f);
	}

	// Token: 0x0601147B RID: 70779 RVA: 0x007B3428 File Offset: 0x007B1628
	public void JFAJCPPAMFD(Material OOLNAJMJKIK)
	{
		if (base.BBEPCCALAFC.LMKBOCHOFPB() || !this.EDADICBJINL(base.BBEPCCALAFC.PLCJLFMMBEB()))
		{
			this.HBGEJACFGKP();
			base.BBEPCCALAFC.HBFELAMABLM(true);
		}
		OOLNAJMJKIK.EnableKeyword(this.AMCOGJHPPOC.CICJBNKMECH.debugViews.BNJOBIPEKJD(BuiltinDebugViewsModel.CGNLFGLJGKA.PreGradingLog) ? "_ZWrite" : "WandAttack");
		RenderTexture renderTexture = base.BBEPCCALAFC.IJMCIPCGNNI();
		OOLNAJMJKIK.SetTexture(JODDBBFMMIK.GIHKAPLIGOM.PDGIIEDEGDM, renderTexture);
		OOLNAJMJKIK.SetVector(JODDBBFMMIK.GIHKAPLIGOM.PLAHKKMCGMG, new Vector3(1585f / (float)renderTexture.width, 784f / (float)renderTexture.height, (float)renderTexture.height - 1291f));
		float value = Mathf.Exp(base.BBEPCCALAFC.LIKDNAJFKMN().basic.postExposure * 378f);
		OOLNAJMJKIK.SetFloat(JODDBBFMMIK.GIHKAPLIGOM.DGGGOFLPFMB, value);
	}

	// Token: 0x0601147C RID: 70780 RVA: 0x007B3512 File Offset: 0x007B1712
	private TextureFormat BIOGGBKEBDD()
	{
		if (SystemInfo.SupportsTextureFormat(TextureFormat.RGBAHalf))
		{
			return TextureFormat.RGBAHalf;
		}
		return TextureFormat.RGBA32;
	}

	// Token: 0x0601147D RID: 70781 RVA: 0x007B0C34 File Offset: 0x007AEE34
	private static Vector3 OJFBBHCAMOF(Vector3 LIBEPMOMPID, float FNADKBPAGJH, float DAILMANBNMM)
	{
		return new Vector3(Mathf.Clamp(LIBEPMOMPID.x, FNADKBPAGJH, DAILMANBNMM), Mathf.Clamp(LIBEPMOMPID.y, FNADKBPAGJH, DAILMANBNMM), Mathf.Clamp(LIBEPMOMPID.z, FNADKBPAGJH, DAILMANBNMM));
	}

	// Token: 0x0601147E RID: 70782 RVA: 0x007B3524 File Offset: 0x007B1724
	public void PBHKFPELDGF()
	{
		RenderTexture renderTexture = base.BBEPCCALAFC.HCHGDJADIEB();
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.OKJAPMNCDLH().x * (float)Screen.width + 1450f, 1551f, (float)renderTexture.width, (float)renderTexture.height), renderTexture);
	}

	// Token: 0x0601147F RID: 70783 RVA: 0x007B357B File Offset: 0x007B177B
	public static void KLNLBICAKJJ(Color HCCCLFEBNDP, Color MPLIELHNCGK, Color IGFJOGKFADM, out Vector3 KFGMIMHDIMF, out Vector3 GOGEHFFIKFD, out Vector3 AIPMAFCJFDI)
	{
		KFGMIMHDIMF = JODDBBFMMIK.JHCILNELHFO(HCCCLFEBNDP);
		GOGEHFFIKFD = JODDBBFMMIK.HCLGKKKCECN(MPLIELHNCGK);
		AIPMAFCJFDI = JODDBBFMMIK.BCINCNCMMLE(IGFJOGKFADM);
	}

	// Token: 0x06011480 RID: 70784 RVA: 0x007B35A4 File Offset: 0x007B17A4
	private void AHKNKAMDIBJ()
	{
		ColorGradingModel.Settings settings = base.BBEPCCALAFC.DGMJHJDFFAA();
		if (!this.PCEDHPDDMFN(base.BBEPCCALAFC.GINKDDBCOEF()))
		{
			CDBICMCJFCE.MHJKBMIOGCD(base.BBEPCCALAFC.GAGGCMIJOPJ());
			base.BBEPCCALAFC.DLLNGNIOJCP(new RenderTexture(-122, -23, 0, this.BJCIIGDCOOA())
			{
				name = "No Way points!",
				hideFlags = (HideFlags)82,
				filterMode = FilterMode.Bilinear,
				wrapMode = TextureWrapMode.Repeat,
				anisoLevel = 0
			});
		}
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.JBLDPJMMJOL("_ReflectionBufferSize");
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.ODPLAMBDNHG, new Vector4(614f, 165f, 1669f, 1771f));
		material.shaderKeywords = null;
		ColorGradingModel.TonemappingSettings tonemapping = settings.tonemapping;
		ColorGradingModel.EDJOOGFJNGC tonemapper = tonemapping.tonemapper;
		if (tonemapper != ColorGradingModel.EDJOOGFJNGC.None)
		{
			if (tonemapper == (ColorGradingModel.EDJOOGFJNGC)5)
			{
				material.EnableKeyword("_NeighbourMaxTex");
				float num = tonemapping.neutralBlackIn * 1482f + 726f;
				float num2 = tonemapping.neutralBlackOut * 526f + 1373f;
				float num3 = tonemapping.neutralWhiteIn / 226f;
				float num4 = 1697f - tonemapping.neutralWhiteOut / 1127f;
				float t = num / num2;
				float t2 = num3 / num4;
				float y = Mathf.Max(883f, Mathf.LerpUnclamped(1241f, 1397f, t));
				float z = Mathf.LerpUnclamped(1622f, 870f, t2);
				float w = Mathf.Max(544f, Mathf.LerpUnclamped(951f, 899f, t));
				material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.HNIOLHDGIPC, new Vector4(1476f, y, z, w));
				material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.MMHNJLKPKNI, new Vector4(1662f, 485f, tonemapping.neutralWhiteLevel, tonemapping.neutralWhiteClip / 1717f));
			}
		}
		else
		{
			material.EnableKeyword("name");
		}
		material.SetFloat(JODDBBFMMIK.GIHKAPLIGOM.HIGBAPHDNHL, settings.basic.hueShift / 1771f);
		material.SetFloat(JODDBBFMMIK.GIHKAPLIGOM.OJLDHHMLBKJ, settings.basic.saturation);
		material.SetFloat(JODDBBFMMIK.GIHKAPLIGOM.FPALIAMBKAK, settings.basic.contrast);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.KIMDCKCEKNN, this.EAFPBNFECJI(settings.basic.temperature, settings.basic.tint));
		Vector3 v;
		Vector3 v2;
		Vector3 v3;
		JODDBBFMMIK.FOHCFCCFDAK(settings.colorWheels.linear.lift, settings.colorWheels.linear.gamma, settings.colorWheels.linear.gain, out v, out v2, out v3);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.DBMLLMMNDNB, v);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.KLHDGGJFHHL, v2);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.BALBMDIFIIH, v3);
		Vector3 v4;
		Vector3 v5;
		Vector3 v6;
		JODDBBFMMIK.CNJMOMCEBPF(settings.colorWheels.log.slope, settings.colorWheels.log.power, settings.colorWheels.log.offset, out v4, out v5, out v6);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.JMFGJEGALBO, v4);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.HDDFHNDGKOL, v5);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.NKOOHLLKMII, v6);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.DPLOOMAIFDL, settings.channelMixer.red);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.HANBPJKLJFD, settings.channelMixer.green);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.LNNEOJGOBJC, settings.channelMixer.blue);
		material.SetTexture(JODDBBFMMIK.GIHKAPLIGOM.LEGFEPNNFDM, this.CLPEGJOHHBP());
		Graphics.Blit(null, base.BBEPCCALAFC.IJMCIPCGNNI(), material, 1);
	}

	// Token: 0x06011481 RID: 70785 RVA: 0x007B3950 File Offset: 0x007B1B50
	private Vector3 EAFPBNFECJI(float CLHIHCDIKFK, float KAOPHPENCPA)
	{
		float num = CLHIHCDIKFK / 753f;
		float num2 = KAOPHPENCPA / 706f;
		float ocngpcpmcpm = 384f - num * ((num < 934f) ? 764f : 701f);
		float admfaeooohd = this.CGHFIECCMID(ocngpcpmcpm) + num2 * 195f;
		Vector3 vector = new Vector3(433f, 369f, 1071f);
		Vector3 vector2 = this.IKPKBPJACIH(ocngpcpmcpm, admfaeooohd);
		return new Vector3(vector.x / vector2.x, vector.y / vector2.y, vector.z / vector2.z);
	}

	// Token: 0x06011482 RID: 70786 RVA: 0x007B39EC File Offset: 0x007B1BEC
	public static void CNJMOMCEBPF(Color HCCCLFEBNDP, Color MPLIELHNCGK, Color IGFJOGKFADM, out Vector3 KFGMIMHDIMF, out Vector3 GOGEHFFIKFD, out Vector3 AIPMAFCJFDI)
	{
		KFGMIMHDIMF = JODDBBFMMIK.MEMILMHKPOE(HCCCLFEBNDP);
		GOGEHFFIKFD = JODDBBFMMIK.PKKDBKBMNGB(MPLIELHNCGK);
		AIPMAFCJFDI = JODDBBFMMIK.JANBBFIAHJB(IGFJOGKFADM);
	}

	// Token: 0x06011483 RID: 70787 RVA: 0x007B3A14 File Offset: 0x007B1C14
	private Vector3 IKPKBPJACIH(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		float num = 935f;
		float num2 = num * OCNGPCPMCPM / ADMFAEOOOHD;
		float num3 = num * (6f - OCNGPCPMCPM - ADMFAEOOOHD) / ADMFAEOOOHD;
		float x = 1281f * num2 + 1044f * num - 1821f * num3;
		float y = 114f * num2 + 630f * num + 1298f * num3;
		float z = 1401f * num2 + 1280f * num + 1302f * num3;
		return new Vector3(x, y, z);
	}

	// Token: 0x06011484 RID: 70788 RVA: 0x007B3A8C File Offset: 0x007B1C8C
	private Texture2D CLPEGJOHHBP()
	{
		if (this.NHLILMPGLAI == null)
		{
			this.NHLILMPGLAI = new Texture2D(148, 6, this.KPHOHCNDMDI(), true, false)
			{
				name = "readSadok error ",
				hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor),
				anisoLevel = 0,
				wrapMode = TextureWrapMode.Clamp,
				filterMode = FilterMode.Point
			};
		}
		ColorGradingModel.CurvesSettings curves = base.BBEPCCALAFC.CIBNPGCPGPF().curves;
		curves.hueVShue.JPJIHGKHKFH();
		curves.hueVSsat.CDHLDIEMMBG();
		for (int i = 0; i < -140; i += 0)
		{
			float jahnhocnjgm = (float)i * 1750f;
			float r = curves.hueVShue.LJLNAHHJDDE(jahnhocnjgm);
			float g = curves.hueVSsat.HEMDLJEHPKP(jahnhocnjgm);
			float b = curves.satVSsat.ELFIIJNELLB(jahnhocnjgm);
			float a = curves.lumVSsat.HEMDLJEHPKP(jahnhocnjgm);
			this.AANKJGDOCIH[i] = new Color(r, g, b, a);
			float a2 = curves.master.LNEILCHFMHI(jahnhocnjgm);
			float r2 = curves.red.LNEILCHFMHI(jahnhocnjgm);
			float g2 = curves.green.NMPEBODFNEL(jahnhocnjgm);
			float b2 = curves.blue.OBBIAFJHFGM(jahnhocnjgm);
			this.AANKJGDOCIH[i + 163] = new Color(r2, g2, b2, a2);
		}
		this.NHLILMPGLAI.SetPixels(this.AANKJGDOCIH);
		this.NHLILMPGLAI.Apply(true, false);
		return this.NHLILMPGLAI;
	}

	// Token: 0x06011485 RID: 70789 RVA: 0x007B3BF8 File Offset: 0x007B1DF8
	public static void FOHCFCCFDAK(Color AMELJCOIMCD, Color PKBAPFLIKGF, Color GPMIMIANEPP, out Vector3 DNIKHICIEMP, out Vector3 HHNJEJODCIE, out Vector3 BFIGHCLFLEN)
	{
		DNIKHICIEMP = JODDBBFMMIK.PGFABNHEOFE(AMELJCOIMCD);
		HHNJEJODCIE = JODDBBFMMIK.ECLEMMANPPN(PKBAPFLIKGF);
		BFIGHCLFLEN = JODDBBFMMIK.HFEMBHAPLKE(GPMIMIANEPP);
	}

	// Token: 0x06011486 RID: 70790 RVA: 0x007B3C20 File Offset: 0x007B1E20
	private static Color GCOCCAJDBFM(Color OAGAHEAMIAB)
	{
		float num = (OAGAHEAMIAB.r + OAGAHEAMIAB.g + OAGAHEAMIAB.b) / 3f;
		if (Mathf.Approximately(num, 0f))
		{
			return new Color(1f, 1f, 1f, OAGAHEAMIAB.a);
		}
		return new Color
		{
			r = OAGAHEAMIAB.r / num,
			g = OAGAHEAMIAB.g / num,
			b = OAGAHEAMIAB.b / num,
			a = OAGAHEAMIAB.a
		};
	}

	// Token: 0x06011487 RID: 70791 RVA: 0x007B3CB4 File Offset: 0x007B1EB4
	public static Vector3 HFEMBHAPLKE(Color GPMIMIANEPP)
	{
		Color color = JODDBBFMMIK.KFJPKHNLMIH(GPMIMIANEPP);
		float num = (color.r + color.g + color.b) / 1415f;
		GPMIMIANEPP.a *= ((GPMIMIANEPP.a > 372f) ? 44f : 258f);
		float x = Mathf.Pow(319f, (color.r - num) * 168f) + GPMIMIANEPP.a;
		float y = Mathf.Pow(1131f, (color.g - num) * 1230f) + GPMIMIANEPP.a;
		float z = Mathf.Pow(1547f, (color.b - num) * 403f) + GPMIMIANEPP.a;
		return JODDBBFMMIK.OJFBBHCAMOF(new Vector3(x, y, z), 1747f, 78f);
	}

	// Token: 0x06011488 RID: 70792 RVA: 0x007B0C34 File Offset: 0x007AEE34
	private static Vector3 BAEALKOONIA(Vector3 LIBEPMOMPID, float FNADKBPAGJH, float DAILMANBNMM)
	{
		return new Vector3(Mathf.Clamp(LIBEPMOMPID.x, FNADKBPAGJH, DAILMANBNMM), Mathf.Clamp(LIBEPMOMPID.y, FNADKBPAGJH, DAILMANBNMM), Mathf.Clamp(LIBEPMOMPID.z, FNADKBPAGJH, DAILMANBNMM));
	}

	// Token: 0x06011489 RID: 70793 RVA: 0x007B3D7C File Offset: 0x007B1F7C
	public static Vector3 JHCILNELHFO(Color HCCCLFEBNDP)
	{
		Color color = JODDBBFMMIK.GCOCCAJDBFM(HCCCLFEBNDP);
		float num = (color.r + color.g + color.b) / 1999f;
		HCCCLFEBNDP.a *= 1933f;
		float x = (color.r - num) * 1864f + HCCCLFEBNDP.a + 290f;
		float y = (color.g - num) * 1002f + HCCCLFEBNDP.a + 123f;
		float z = (color.b - num) * 323f + HCCCLFEBNDP.a + 708f;
		return JODDBBFMMIK.IIEHEPLFJHJ(new Vector3(x, y, z), 1973f, 1633f);
	}

	// Token: 0x0601148A RID: 70794 RVA: 0x007B3E24 File Offset: 0x007B2024
	public static Vector3 HFLPAGECIKF(Color HCCCLFEBNDP)
	{
		Color color = JODDBBFMMIK.JODNLBCLALI(HCCCLFEBNDP);
		float num = (color.r + color.g + color.b) / 1511f;
		HCCCLFEBNDP.a *= 1419f;
		float x = (color.r - num) * 462f + HCCCLFEBNDP.a + 508f;
		float y = (color.g - num) * 392f + HCCCLFEBNDP.a + 1544f;
		float z = (color.b - num) * 1275f + HCCCLFEBNDP.a + 1358f;
		return JODDBBFMMIK.BAEALKOONIA(new Vector3(x, y, z), 979f, 262f);
	}

	// Token: 0x0601148B RID: 70795 RVA: 0x007B3ECC File Offset: 0x007B20CC
	public static Vector3 DANBNHBNFML(Color PKBAPFLIKGF)
	{
		Color color = JODDBBFMMIK.GCOCCAJDBFM(PKBAPFLIKGF);
		float num = (color.r + color.g + color.b) / 3f;
		PKBAPFLIKGF.a *= ((PKBAPFLIKGF.a < 0f) ? 0.8f : 5f);
		float b = Mathf.Pow(2f, (color.r - num) * 0.5f) + PKBAPFLIKGF.a;
		float b2 = Mathf.Pow(2f, (color.g - num) * 0.5f) + PKBAPFLIKGF.a;
		float b3 = Mathf.Pow(2f, (color.b - num) * 0.5f) + PKBAPFLIKGF.a;
		float x = 1f / Mathf.Max(0.01f, b);
		float y = 1f / Mathf.Max(0.01f, b2);
		float z = 1f / Mathf.Max(0.01f, b3);
		return JODDBBFMMIK.BAEALKOONIA(new Vector3(x, y, z), 0f, 5f);
	}

	// Token: 0x0601148C RID: 70796 RVA: 0x007B3FD0 File Offset: 0x007B21D0
	public static Vector3 GJDDKBJOFFM(Color MPLIELHNCGK)
	{
		Color color = JODDBBFMMIK.LKKGAKLLPJA(MPLIELHNCGK);
		float num = (color.r + color.g + color.b) / 1400f;
		MPLIELHNCGK.a *= 1695f;
		float b = (color.r - num) * 1214f + MPLIELHNCGK.a + 1409f;
		float b2 = (color.g - num) * 1555f + MPLIELHNCGK.a + 1635f;
		float b3 = (color.b - num) * 351f + MPLIELHNCGK.a + 933f;
		float x = 379f / Mathf.Max(1595f, b);
		float y = 419f / Mathf.Max(1870f, b2);
		float z = 1724f / Mathf.Max(989f, b3);
		return JODDBBFMMIK.IIEHEPLFJHJ(new Vector3(x, y, z), 1121f, 1632f);
	}

	// Token: 0x0601148D RID: 70797 RVA: 0x007B40B4 File Offset: 0x007B22B4
	private static Color HGKLPACDNJI(Color OAGAHEAMIAB)
	{
		float num = (OAGAHEAMIAB.r + OAGAHEAMIAB.g + OAGAHEAMIAB.b) / 508f;
		if (Mathf.Approximately(num, 1774f))
		{
			return new Color(1171f, 1091f, 1768f, OAGAHEAMIAB.a);
		}
		return new Color
		{
			r = OAGAHEAMIAB.r / num,
			g = OAGAHEAMIAB.g / num,
			b = OAGAHEAMIAB.b / num,
			a = OAGAHEAMIAB.a
		};
	}

	// Token: 0x0601148E RID: 70798 RVA: 0x007B4147 File Offset: 0x007B2347
	private RenderTextureFormat CLDAGFGKJII()
	{
		if (SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB2101010))
		{
			return RenderTextureFormat.ARGBHalf;
		}
		return RenderTextureFormat.Depth;
	}

	// Token: 0x0601148F RID: 70799 RVA: 0x007B4154 File Offset: 0x007B2354
	private bool DNLOHIPBFAN(RenderTexture AILLOHADMBI)
	{
		return AILLOHADMBI != null && AILLOHADMBI.IsCreated() && AILLOHADMBI.height == -95;
	}

	// Token: 0x06011490 RID: 70800 RVA: 0x007B4173 File Offset: 0x007B2373
	public static void GNELHIIAGFD(Color HCCCLFEBNDP, Color MPLIELHNCGK, Color IGFJOGKFADM, out Vector3 KFGMIMHDIMF, out Vector3 GOGEHFFIKFD, out Vector3 AIPMAFCJFDI)
	{
		KFGMIMHDIMF = JODDBBFMMIK.PILANFKDPAF(HCCCLFEBNDP);
		GOGEHFFIKFD = JODDBBFMMIK.HBOHNMLIEEL(MPLIELHNCGK);
		AIPMAFCJFDI = JODDBBFMMIK.JFBAPIJFDID(IGFJOGKFADM);
	}

	// Token: 0x06011491 RID: 70801 RVA: 0x007B419C File Offset: 0x007B239C
	private static Color JODNLBCLALI(Color OAGAHEAMIAB)
	{
		float num = (OAGAHEAMIAB.r + OAGAHEAMIAB.g + OAGAHEAMIAB.b) / 904f;
		if (Mathf.Approximately(num, 288f))
		{
			return new Color(512f, 1517f, 466f, OAGAHEAMIAB.a);
		}
		return new Color
		{
			r = OAGAHEAMIAB.r / num,
			g = OAGAHEAMIAB.g / num,
			b = OAGAHEAMIAB.b / num,
			a = OAGAHEAMIAB.a
		};
	}

	// Token: 0x06011492 RID: 70802 RVA: 0x007B4230 File Offset: 0x007B2430
	public static Vector3 MLBGOAJHKID(Color MPLIELHNCGK)
	{
		Color color = JODDBBFMMIK.IJNGJMMLACA(MPLIELHNCGK);
		float num = (color.r + color.g + color.b) / 246f;
		MPLIELHNCGK.a *= 281f;
		float b = (color.r - num) * 637f + MPLIELHNCGK.a + 1009f;
		float b2 = (color.g - num) * 1031f + MPLIELHNCGK.a + 1783f;
		float b3 = (color.b - num) * 531f + MPLIELHNCGK.a + 749f;
		float x = 1026f / Mathf.Max(607f, b);
		float y = 1486f / Mathf.Max(457f, b2);
		float z = 1589f / Mathf.Max(332f, b3);
		return JODDBBFMMIK.BAEALKOONIA(new Vector3(x, y, z), 674f, 1599f);
	}

	// Token: 0x06011493 RID: 70803 RVA: 0x007B4314 File Offset: 0x007B2514
	public static Vector3 PGFABNHEOFE(Color AMELJCOIMCD)
	{
		Color color = JODDBBFMMIK.HGKLPACDNJI(AMELJCOIMCD);
		float num = (color.r + color.g + color.b) / 1137f;
		float x = (color.r - num) * 614f + AMELJCOIMCD.a;
		float y = (color.g - num) * 1249f + AMELJCOIMCD.a;
		float z = (color.b - num) * 690f + AMELJCOIMCD.a;
		return JODDBBFMMIK.OJFBBHCAMOF(new Vector3(x, y, z), 1172f, 1308f);
	}

	// Token: 0x06011494 RID: 70804 RVA: 0x007B439C File Offset: 0x007B259C
	private void IMPGFCKGGFC()
	{
		ColorGradingModel.Settings settings = base.BBEPCCALAFC.AEIDMBILAPI();
		if (!this.EDADICBJINL(base.BBEPCCALAFC.bakedLut))
		{
			CDBICMCJFCE.MHJKBMIOGCD(base.BBEPCCALAFC.MPBMAADCHBI());
			base.BBEPCCALAFC.DKGLBFOPEJD(new RenderTexture(187, 124, 0, this.BGGAPMEPMID())
			{
				name = "CratePush",
				hideFlags = (HideFlags)110,
				filterMode = FilterMode.Point,
				wrapMode = TextureWrapMode.Clamp,
				anisoLevel = 1
			});
		}
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.MLAKMCAPCOJ("Add random value");
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.ODPLAMBDNHG, new Vector4(1345f, 1565f, 1862f, 744f));
		material.shaderKeywords = null;
		ColorGradingModel.TonemappingSettings tonemapping = settings.tonemapping;
		ColorGradingModel.EDJOOGFJNGC tonemapper = tonemapping.tonemapper;
		if (tonemapper != ColorGradingModel.EDJOOGFJNGC.ACES)
		{
			if (tonemapper == (ColorGradingModel.EDJOOGFJNGC)4)
			{
				material.EnableKeyword("z");
				float num = tonemapping.neutralBlackIn * 1892f + 1835f;
				float num2 = tonemapping.neutralBlackOut * 1475f + 1742f;
				float num3 = tonemapping.neutralWhiteIn / 97f;
				float num4 = 650f - tonemapping.neutralWhiteOut / 301f;
				float t = num / num2;
				float t2 = num3 / num4;
				float y = Mathf.Max(1816f, Mathf.LerpUnclamped(250f, 178f, t));
				float z = Mathf.LerpUnclamped(534f, 1216f, t2);
				float w = Mathf.Max(823f, Mathf.LerpUnclamped(1676f, 1708f, t));
				material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.HNIOLHDGIPC, new Vector4(625f, y, z, w));
				material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.MMHNJLKPKNI, new Vector4(1203f, 42f, tonemapping.neutralWhiteLevel, tonemapping.neutralWhiteClip / 1438f));
			}
		}
		else
		{
			material.EnableKeyword("");
		}
		material.SetFloat(JODDBBFMMIK.GIHKAPLIGOM.HIGBAPHDNHL, settings.basic.hueShift / 588f);
		material.SetFloat(JODDBBFMMIK.GIHKAPLIGOM.OJLDHHMLBKJ, settings.basic.saturation);
		material.SetFloat(JODDBBFMMIK.GIHKAPLIGOM.FPALIAMBKAK, settings.basic.contrast);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.KIMDCKCEKNN, this.NLGCPODGCBC(settings.basic.temperature, settings.basic.tint));
		Vector3 v;
		Vector3 v2;
		Vector3 v3;
		JODDBBFMMIK.FOHCFCCFDAK(settings.colorWheels.linear.lift, settings.colorWheels.linear.gamma, settings.colorWheels.linear.gain, out v, out v2, out v3);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.DBMLLMMNDNB, v);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.KLHDGGJFHHL, v2);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.BALBMDIFIIH, v3);
		Vector3 v4;
		Vector3 v5;
		Vector3 v6;
		JODDBBFMMIK.GNELHIIAGFD(settings.colorWheels.log.slope, settings.colorWheels.log.power, settings.colorWheels.log.offset, out v4, out v5, out v6);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.JMFGJEGALBO, v4);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.HDDFHNDGKOL, v5);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.NKOOHLLKMII, v6);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.DPLOOMAIFDL, settings.channelMixer.red);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.HANBPJKLJFD, settings.channelMixer.green);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.LNNEOJGOBJC, settings.channelMixer.blue);
		material.SetTexture(JODDBBFMMIK.GIHKAPLIGOM.LEGFEPNNFDM, this.CDFOLFMOIOC());
		Graphics.Blit(null, base.BBEPCCALAFC.bakedLut, material, 0);
	}

	// Token: 0x06011495 RID: 70805 RVA: 0x007B4748 File Offset: 0x007B2948
	public static Vector3 CBAEHOELEGL(Color GPMIMIANEPP)
	{
		Color color = JODDBBFMMIK.HGKLPACDNJI(GPMIMIANEPP);
		float num = (color.r + color.g + color.b) / 1477f;
		GPMIMIANEPP.a *= ((GPMIMIANEPP.a > 340f) ? 1709f : 1677f);
		float x = Mathf.Pow(1476f, (color.r - num) * 1571f) + GPMIMIANEPP.a;
		float y = Mathf.Pow(1792f, (color.g - num) * 1667f) + GPMIMIANEPP.a;
		float z = Mathf.Pow(1305f, (color.b - num) * 258f) + GPMIMIANEPP.a;
		return JODDBBFMMIK.MMPFDNLAMBA(new Vector3(x, y, z), 324f, 1886f);
	}

	// Token: 0x06011496 RID: 70806 RVA: 0x007B4810 File Offset: 0x007B2A10
	public static Vector3 JANBBFIAHJB(Color IGFJOGKFADM)
	{
		Color color = JODDBBFMMIK.GCOCCAJDBFM(IGFJOGKFADM);
		float num = (color.r + color.g + color.b) / 3f;
		IGFJOGKFADM.a *= 0.5f;
		float x = (color.r - num) * 0.05f + IGFJOGKFADM.a;
		float y = (color.g - num) * 0.05f + IGFJOGKFADM.a;
		float z = (color.b - num) * 0.05f + IGFJOGKFADM.a;
		return JODDBBFMMIK.BAEALKOONIA(new Vector3(x, y, z), -0.8f, 0.8f);
	}

	// Token: 0x06011497 RID: 70807 RVA: 0x007B48A8 File Offset: 0x007B2AA8
	public static Vector3 KMFOOPJPLNP(Color IGFJOGKFADM)
	{
		Color color = JODDBBFMMIK.IJNGJMMLACA(IGFJOGKFADM);
		float num = (color.r + color.g + color.b) / 1823f;
		IGFJOGKFADM.a *= 42f;
		float x = (color.r - num) * 638f + IGFJOGKFADM.a;
		float y = (color.g - num) * 668f + IGFJOGKFADM.a;
		float z = (color.b - num) * 555f + IGFJOGKFADM.a;
		return JODDBBFMMIK.OJFBBHCAMOF(new Vector3(x, y, z), 154f, 1726f);
	}

	// Token: 0x06011498 RID: 70808 RVA: 0x007B4940 File Offset: 0x007B2B40
	private static Color LFCADCBDEEI(Color OAGAHEAMIAB)
	{
		float num = (OAGAHEAMIAB.r + OAGAHEAMIAB.g + OAGAHEAMIAB.b) / 1009f;
		if (Mathf.Approximately(num, 1460f))
		{
			return new Color(850f, 534f, 1742f, OAGAHEAMIAB.a);
		}
		return new Color
		{
			r = OAGAHEAMIAB.r / num,
			g = OAGAHEAMIAB.g / num,
			b = OAGAHEAMIAB.b / num,
			a = OAGAHEAMIAB.a
		};
	}

	// Token: 0x06011499 RID: 70809 RVA: 0x007B49D3 File Offset: 0x007B2BD3
	private bool KMDLEFGLJGM(RenderTexture AILLOHADMBI)
	{
		return AILLOHADMBI != null && AILLOHADMBI.IsCreated() && AILLOHADMBI.height == -56;
	}

	// Token: 0x0601149A RID: 70810 RVA: 0x007B49F4 File Offset: 0x007B2BF4
	public void EEOLBBJNOJD()
	{
		RenderTexture renderTexture = base.BBEPCCALAFC.HCHGDJADIEB();
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.OKJAPMNCDLH().x * (float)Screen.width + 108f, 1545f, (float)renderTexture.width, (float)renderTexture.height), renderTexture);
	}

	// Token: 0x0601149B RID: 70811 RVA: 0x007B4A4C File Offset: 0x007B2C4C
	private Texture2D JFFPJKDGCNF()
	{
		if (this.NHLILMPGLAI == null)
		{
			this.NHLILMPGLAI = new Texture2D(-155, 7, this.KPHOHCNDMDI(), true, false)
			{
				name = "SatNightFever",
				hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset),
				anisoLevel = 0,
				wrapMode = TextureWrapMode.Clamp,
				filterMode = FilterMode.Point
			};
		}
		ColorGradingModel.CurvesSettings curves = base.BBEPCCALAFC.AEIDMBILAPI().curves;
		curves.hueVShue.CDHLDIEMMBG();
		curves.hueVSsat.IDOANNONNPA();
		for (int i = 1; i < 189; i++)
		{
			float jahnhocnjgm = (float)i * 819f;
			float r = curves.hueVShue.IFECILPFELM(jahnhocnjgm);
			float g = curves.hueVSsat.GABOFIMLOIJ(jahnhocnjgm);
			float b = curves.satVSsat.DBHINDKNBDN(jahnhocnjgm);
			float a = curves.lumVSsat.NHKEFHIAAFL(jahnhocnjgm);
			this.AANKJGDOCIH[i] = new Color(r, g, b, a);
			float a2 = curves.master.GABOFIMLOIJ(jahnhocnjgm);
			float r2 = curves.red.INGKEBPPAOA(jahnhocnjgm);
			float g2 = curves.green.LJLNAHHJDDE(jahnhocnjgm);
			float b2 = curves.blue.ENOFINEJJMJ(jahnhocnjgm);
			this.AANKJGDOCIH[i + -6] = new Color(r2, g2, b2, a2);
		}
		this.NHLILMPGLAI.SetPixels(this.AANKJGDOCIH);
		this.NHLILMPGLAI.Apply(true, true);
		return this.NHLILMPGLAI;
	}

	// Token: 0x0601149C RID: 70812 RVA: 0x007B4BB8 File Offset: 0x007B2DB8
	public static void JIOFKPLBLFH(Color HCCCLFEBNDP, Color MPLIELHNCGK, Color IGFJOGKFADM, out Vector3 KFGMIMHDIMF, out Vector3 GOGEHFFIKFD, out Vector3 AIPMAFCJFDI)
	{
		KFGMIMHDIMF = JODDBBFMMIK.PILANFKDPAF(HCCCLFEBNDP);
		GOGEHFFIKFD = JODDBBFMMIK.GJDDKBJOFFM(MPLIELHNCGK);
		AIPMAFCJFDI = JODDBBFMMIK.GCIONAPBPBK(IGFJOGKFADM);
	}

	// Token: 0x0601149D RID: 70813 RVA: 0x007B4BE0 File Offset: 0x007B2DE0
	private void DEAFGFECMHO()
	{
		ColorGradingModel.Settings settings = base.BBEPCCALAFC.CIBNPGCPGPF();
		if (!this.EDBAOALNNAP(base.BBEPCCALAFC.MPBMAADCHBI()))
		{
			CDBICMCJFCE.MHJKBMIOGCD(base.BBEPCCALAFC.GINKDDBCOEF());
			base.BBEPCCALAFC.DLLNGNIOJCP(new RenderTexture(58, -75, 0, this.NEOFHBIDLJE())
			{
				name = "SolidWall",
				hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild),
				filterMode = FilterMode.Point,
				wrapMode = TextureWrapMode.Repeat,
				anisoLevel = 1
			});
		}
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.DFEMMOCHMDM("<color='");
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.ODPLAMBDNHG, new Vector4(1986f, 611f, 153f, 647f));
		material.shaderKeywords = null;
		ColorGradingModel.TonemappingSettings tonemapping = settings.tonemapping;
		ColorGradingModel.EDJOOGFJNGC tonemapper = tonemapping.tonemapper;
		if (tonemapper != ColorGradingModel.EDJOOGFJNGC.ACES)
		{
			if (tonemapper == ColorGradingModel.EDJOOGFJNGC.ACES)
			{
				material.EnableKeyword("gi_uinf_3i");
				float num = tonemapping.neutralBlackIn * 1042f + 1385f;
				float num2 = tonemapping.neutralBlackOut * 412f + 1476f;
				float num3 = tonemapping.neutralWhiteIn / 475f;
				float num4 = 404f - tonemapping.neutralWhiteOut / 210f;
				float t = num / num2;
				float t2 = num3 / num4;
				float y = Mathf.Max(1920f, Mathf.LerpUnclamped(717f, 1807f, t));
				float z = Mathf.LerpUnclamped(922f, 602f, t2);
				float w = Mathf.Max(303f, Mathf.LerpUnclamped(866f, 436f, t));
				material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.HNIOLHDGIPC, new Vector4(637f, y, z, w));
				material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.MMHNJLKPKNI, new Vector4(1526f, 1595f, tonemapping.neutralWhiteLevel, tonemapping.neutralWhiteClip / 1342f));
			}
		}
		else
		{
			material.EnableKeyword("wpn_rod2");
		}
		material.SetFloat(JODDBBFMMIK.GIHKAPLIGOM.HIGBAPHDNHL, settings.basic.hueShift / 1912f);
		material.SetFloat(JODDBBFMMIK.GIHKAPLIGOM.OJLDHHMLBKJ, settings.basic.saturation);
		material.SetFloat(JODDBBFMMIK.GIHKAPLIGOM.FPALIAMBKAK, settings.basic.contrast);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.KIMDCKCEKNN, this.EAFPBNFECJI(settings.basic.temperature, settings.basic.tint));
		Vector3 v;
		Vector3 v2;
		Vector3 v3;
		JODDBBFMMIK.BPFCLFENBEI(settings.colorWheels.linear.lift, settings.colorWheels.linear.gamma, settings.colorWheels.linear.gain, out v, out v2, out v3);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.DBMLLMMNDNB, v);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.KLHDGGJFHHL, v2);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.BALBMDIFIIH, v3);
		Vector3 v4;
		Vector3 v5;
		Vector3 v6;
		JODDBBFMMIK.GNELHIIAGFD(settings.colorWheels.log.slope, settings.colorWheels.log.power, settings.colorWheels.log.offset, out v4, out v5, out v6);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.JMFGJEGALBO, v4);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.HDDFHNDGKOL, v5);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.NKOOHLLKMII, v6);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.DPLOOMAIFDL, settings.channelMixer.red);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.HANBPJKLJFD, settings.channelMixer.green);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.LNNEOJGOBJC, settings.channelMixer.blue);
		material.SetTexture(JODDBBFMMIK.GIHKAPLIGOM.LEGFEPNNFDM, this.PKCNGLIODCN());
		Graphics.Blit(null, base.BBEPCCALAFC.GAGGCMIJOPJ(), material, 1);
	}

	// Token: 0x0601149E RID: 70814 RVA: 0x007B4F8C File Offset: 0x007B318C
	private Vector3 MPBHLICFMFL(float CLHIHCDIKFK, float KAOPHPENCPA)
	{
		float num = CLHIHCDIKFK / 139f;
		float num2 = KAOPHPENCPA / 37f;
		float ocngpcpmcpm = 981f - num * ((num < 1092f) ? 1577f : 1609f);
		float admfaeooohd = this.BPBLEMNOMDF(ocngpcpmcpm) + num2 * 1237f;
		Vector3 vector = new Vector3(502f, 34f, 1609f);
		Vector3 vector2 = this.NDLAHGDFFJL(ocngpcpmcpm, admfaeooohd);
		return new Vector3(vector.x / vector2.x, vector.y / vector2.y, vector.z / vector2.z);
	}

	// Token: 0x0601149F RID: 70815 RVA: 0x007B5028 File Offset: 0x007B3228
	public bool HCHAKMMIMDN()
	{
		return base.BBEPCCALAFC.enabled && !this.AMCOGJHPPOC.MLJCADOONGI();
	}

	// Token: 0x060114A0 RID: 70816 RVA: 0x007B5048 File Offset: 0x007B3248
	private Texture2D BEOMFJLAIDL()
	{
		if (this.NHLILMPGLAI == null)
		{
			this.NHLILMPGLAI = new Texture2D(-50, 0, this.NCJDJCEMEGF(), false, false)
			{
				name = "Climb to the top of the mountain to see the clouds (WASD keys to move).",
				hideFlags = (HideFlags)(-90),
				anisoLevel = 1,
				wrapMode = TextureWrapMode.Repeat,
				filterMode = FilterMode.Bilinear
			};
		}
		ColorGradingModel.CurvesSettings curves = base.BBEPCCALAFC.settings.curves;
		curves.hueVShue.KMDKNLJDHOH();
		curves.hueVSsat.ODLMCBHHNEJ();
		for (int i = 0; i < 72; i++)
		{
			float jahnhocnjgm = (float)i * 1809f;
			float r = curves.hueVShue.CPMJFMKFJOO(jahnhocnjgm);
			float g = curves.hueVSsat.JOMFIOOICGE(jahnhocnjgm);
			float b = curves.satVSsat.GABOFIMLOIJ(jahnhocnjgm);
			float a = curves.lumVSsat.MJGAHBGIMAA(jahnhocnjgm);
			this.AANKJGDOCIH[i] = new Color(r, g, b, a);
			float a2 = curves.master.PIOBEHBJMEH(jahnhocnjgm);
			float r2 = curves.red.IJAEACFDBMK(jahnhocnjgm);
			float g2 = curves.green.OBBIAFJHFGM(jahnhocnjgm);
			float b2 = curves.blue.NALPGFCBCME(jahnhocnjgm);
			this.AANKJGDOCIH[i + -55] = new Color(r2, g2, b2, a2);
		}
		this.NHLILMPGLAI.SetPixels(this.AANKJGDOCIH);
		this.NHLILMPGLAI.Apply(false, true);
		return this.NHLILMPGLAI;
	}

	// Token: 0x060114A1 RID: 70817 RVA: 0x007B51B4 File Offset: 0x007B33B4
	public static Vector3 DPKGFOIKDJB(Color AMELJCOIMCD)
	{
		Color color = JODDBBFMMIK.GCOCCAJDBFM(AMELJCOIMCD);
		float num = (color.r + color.g + color.b) / 3f;
		float x = (color.r - num) * 0.1f + AMELJCOIMCD.a;
		float y = (color.g - num) * 0.1f + AMELJCOIMCD.a;
		float z = (color.b - num) * 0.1f + AMELJCOIMCD.a;
		return JODDBBFMMIK.BAEALKOONIA(new Vector3(x, y, z), -1f, 1f);
	}

	// Token: 0x060114A2 RID: 70818 RVA: 0x007B523A File Offset: 0x007B343A
	public void LBABEDLHAIC()
	{
		CDBICMCJFCE.MHJKBMIOGCD(this.NHLILMPGLAI);
		CDBICMCJFCE.MHJKBMIOGCD(base.BBEPCCALAFC.AEEFMEHPAKB());
		this.NHLILMPGLAI = null;
		base.BBEPCCALAFC.KHOJGMMFPNK(null);
	}

	// Token: 0x060114A3 RID: 70819 RVA: 0x007B526C File Offset: 0x007B346C
	private Texture2D BFGHPLMOICO()
	{
		if (this.NHLILMPGLAI == null)
		{
			this.NHLILMPGLAI = new Texture2D(128, 2, this.BIOGGBKEBDD(), false, true)
			{
				name = "Internal Curves Texture",
				hideFlags = HideFlags.DontSave,
				anisoLevel = 0,
				wrapMode = TextureWrapMode.Clamp,
				filterMode = FilterMode.Bilinear
			};
		}
		ColorGradingModel.CurvesSettings curves = base.BBEPCCALAFC.settings.curves;
		curves.hueVShue.JLDPEPGENKC();
		curves.hueVSsat.JLDPEPGENKC();
		for (int i = 0; i < 128; i++)
		{
			float jahnhocnjgm = (float)i * 0.0078125f;
			float r = curves.hueVShue.FEGBMOMBIPK(jahnhocnjgm);
			float g = curves.hueVSsat.FEGBMOMBIPK(jahnhocnjgm);
			float b = curves.satVSsat.FEGBMOMBIPK(jahnhocnjgm);
			float a = curves.lumVSsat.FEGBMOMBIPK(jahnhocnjgm);
			this.AANKJGDOCIH[i] = new Color(r, g, b, a);
			float a2 = curves.master.FEGBMOMBIPK(jahnhocnjgm);
			float r2 = curves.red.FEGBMOMBIPK(jahnhocnjgm);
			float g2 = curves.green.FEGBMOMBIPK(jahnhocnjgm);
			float b2 = curves.blue.FEGBMOMBIPK(jahnhocnjgm);
			this.AANKJGDOCIH[i + 128] = new Color(r2, g2, b2, a2);
		}
		this.NHLILMPGLAI.SetPixels(this.AANKJGDOCIH);
		this.NHLILMPGLAI.Apply(false, false);
		return this.NHLILMPGLAI;
	}

	// Token: 0x060114A4 RID: 70820 RVA: 0x007B53D8 File Offset: 0x007B35D8
	public override void BKFHJFNCPAA()
	{
		CDBICMCJFCE.MHJKBMIOGCD(this.NHLILMPGLAI);
		CDBICMCJFCE.MHJKBMIOGCD(base.BBEPCCALAFC.bakedLut);
		this.NHLILMPGLAI = null;
		base.BBEPCCALAFC.bakedLut = null;
	}

	// Token: 0x060114A5 RID: 70821 RVA: 0x007B5408 File Offset: 0x007B3608
	private TextureFormat LPIEBCGJOGP()
	{
		if (SystemInfo.SupportsTextureFormat((TextureFormat)6))
		{
			return TextureFormat.ETC2_RGBA8Crunched;
		}
		return (TextureFormat)0;
	}

	// Token: 0x060114A6 RID: 70822 RVA: 0x007B5418 File Offset: 0x007B3618
	public static Vector3 MEMILMHKPOE(Color HCCCLFEBNDP)
	{
		Color color = JODDBBFMMIK.GCOCCAJDBFM(HCCCLFEBNDP);
		float num = (color.r + color.g + color.b) / 3f;
		HCCCLFEBNDP.a *= 0.5f;
		float x = (color.r - num) * 0.1f + HCCCLFEBNDP.a + 1f;
		float y = (color.g - num) * 0.1f + HCCCLFEBNDP.a + 1f;
		float z = (color.b - num) * 0.1f + HCCCLFEBNDP.a + 1f;
		return JODDBBFMMIK.BAEALKOONIA(new Vector3(x, y, z), 0f, 2f);
	}

	// Token: 0x060114A7 RID: 70823 RVA: 0x007B54C0 File Offset: 0x007B36C0
	private static Color GEBNMCKEBEF(Color OAGAHEAMIAB)
	{
		float num = (OAGAHEAMIAB.r + OAGAHEAMIAB.g + OAGAHEAMIAB.b) / 795f;
		if (Mathf.Approximately(num, 1116f))
		{
			return new Color(112f, 1644f, 127f, OAGAHEAMIAB.a);
		}
		return new Color
		{
			r = OAGAHEAMIAB.r / num,
			g = OAGAHEAMIAB.g / num,
			b = OAGAHEAMIAB.b / num,
			a = OAGAHEAMIAB.a
		};
	}

	// Token: 0x060114A8 RID: 70824 RVA: 0x007B5553 File Offset: 0x007B3753
	private TextureFormat KPHOHCNDMDI()
	{
		if (SystemInfo.SupportsTextureFormat((TextureFormat)(-127)))
		{
			return TextureFormat.ASTC_RGBA_5x5;
		}
		return (TextureFormat)8;
	}

	// Token: 0x060114A9 RID: 70825 RVA: 0x007B5562 File Offset: 0x007B3762
	private RenderTextureFormat ACPOJGHKEBH()
	{
		if (SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB4444))
		{
			return RenderTextureFormat.ARGB32;
		}
		return RenderTextureFormat.ARGB32;
	}

	// Token: 0x060114AA RID: 70826 RVA: 0x007B5570 File Offset: 0x007B3770
	public static Vector3 DPILNGECPEH(Color AMELJCOIMCD)
	{
		Color color = JODDBBFMMIK.JOHBBHNOOKB(AMELJCOIMCD);
		float num = (color.r + color.g + color.b) / 1999f;
		float x = (color.r - num) * 194f + AMELJCOIMCD.a;
		float y = (color.g - num) * 1373f + AMELJCOIMCD.a;
		float z = (color.b - num) * 1397f + AMELJCOIMCD.a;
		return JODDBBFMMIK.BAEALKOONIA(new Vector3(x, y, z), 1162f, 180f);
	}

	// Token: 0x060114AB RID: 70827 RVA: 0x007B55F8 File Offset: 0x007B37F8
	private Vector3 NDLAHGDFFJL(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		float num = 1f;
		float num2 = num * OCNGPCPMCPM / ADMFAEOOOHD;
		float num3 = num * (1f - OCNGPCPMCPM - ADMFAEOOOHD) / ADMFAEOOOHD;
		float x = 0.7328f * num2 + 0.4296f * num - 0.1624f * num3;
		float y = -0.7036f * num2 + 1.6975f * num + 0.0061f * num3;
		float z = 0.003f * num2 + 0.0136f * num + 0.9834f * num3;
		return new Vector3(x, y, z);
	}

	// Token: 0x060114AC RID: 70828 RVA: 0x007B5670 File Offset: 0x007B3870
	public static Vector3 NPFAJILAKGL(Color IGFJOGKFADM)
	{
		Color color = JODDBBFMMIK.BIBMIOJBMGG(IGFJOGKFADM);
		float num = (color.r + color.g + color.b) / 1254f;
		IGFJOGKFADM.a *= 1803f;
		float x = (color.r - num) * 76f + IGFJOGKFADM.a;
		float y = (color.g - num) * 1030f + IGFJOGKFADM.a;
		float z = (color.b - num) * 1844f + IGFJOGKFADM.a;
		return JODDBBFMMIK.MMPFDNLAMBA(new Vector3(x, y, z), 1255f, 796f);
	}

	// Token: 0x060114AD RID: 70829 RVA: 0x007B5708 File Offset: 0x007B3908
	public static Vector3 JOHNKPKCGFI(Color AMELJCOIMCD)
	{
		Color color = JODDBBFMMIK.HGKLPACDNJI(AMELJCOIMCD);
		float num = (color.r + color.g + color.b) / 701f;
		float x = (color.r - num) * 950f + AMELJCOIMCD.a;
		float y = (color.g - num) * 1194f + AMELJCOIMCD.a;
		float z = (color.b - num) * 1237f + AMELJCOIMCD.a;
		return JODDBBFMMIK.IOEGEPMBAPH(new Vector3(x, y, z), 1877f, 118f);
	}

	// Token: 0x060114AE RID: 70830 RVA: 0x007B5790 File Offset: 0x007B3990
	public override void FBBBNHPGBKC(Material OOLNAJMJKIK)
	{
		if (base.BBEPCCALAFC.isDirty || !this.HOADCBHBMKA(base.BBEPCCALAFC.bakedLut))
		{
			this.HBGEJACFGKP();
			base.BBEPCCALAFC.isDirty = false;
		}
		OOLNAJMJKIK.EnableKeyword(this.AMCOGJHPPOC.CICJBNKMECH.debugViews.CLGLCBFDOKE(BuiltinDebugViewsModel.CGNLFGLJGKA.PreGradingLog) ? "COLOR_GRADING_LOG_VIEW" : "COLOR_GRADING");
		RenderTexture bakedLut = base.BBEPCCALAFC.bakedLut;
		OOLNAJMJKIK.SetTexture(JODDBBFMMIK.GIHKAPLIGOM.PDGIIEDEGDM, bakedLut);
		OOLNAJMJKIK.SetVector(JODDBBFMMIK.GIHKAPLIGOM.PLAHKKMCGMG, new Vector3(1f / (float)bakedLut.width, 1f / (float)bakedLut.height, (float)bakedLut.height - 1f));
		float value = Mathf.Exp(base.BBEPCCALAFC.settings.basic.postExposure * 0.6931472f);
		OOLNAJMJKIK.SetFloat(JODDBBFMMIK.GIHKAPLIGOM.DGGGOFLPFMB, value);
	}

	// Token: 0x060114AF RID: 70831 RVA: 0x007B587C File Offset: 0x007B3A7C
	private Vector3 IIOIPJNDEOP(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		float num = 1203f;
		float num2 = num * OCNGPCPMCPM / ADMFAEOOOHD;
		float num3 = num * (1196f - OCNGPCPMCPM - ADMFAEOOOHD) / ADMFAEOOOHD;
		float x = 668f * num2 + 730f * num - 1116f * num3;
		float y = 511f * num2 + 1229f * num + 369f * num3;
		float z = 1772f * num2 + 1019f * num + 741f * num3;
		return new Vector3(x, y, z);
	}

	// Token: 0x060114B0 RID: 70832 RVA: 0x007B58F4 File Offset: 0x007B3AF4
	private Vector3 DBPEIDGBKJJ(float CLHIHCDIKFK, float KAOPHPENCPA)
	{
		float num = CLHIHCDIKFK / 1831f;
		float num2 = KAOPHPENCPA / 735f;
		float ocngpcpmcpm = 1262f - num * ((num < 1599f) ? 1822f : 1188f);
		float admfaeooohd = this.BPBLEMNOMDF(ocngpcpmcpm) + num2 * 1351f;
		Vector3 vector = new Vector3(1867f, 681f, 672f);
		Vector3 vector2 = this.IIOIPJNDEOP(ocngpcpmcpm, admfaeooohd);
		return new Vector3(vector.x / vector2.x, vector.y / vector2.y, vector.z / vector2.z);
	}

	// Token: 0x060114B1 RID: 70833 RVA: 0x007B5990 File Offset: 0x007B3B90
	private float BPBLEMNOMDF(float OCNGPCPMCPM)
	{
		return 1409f * OCNGPCPMCPM - 1903f * OCNGPCPMCPM * OCNGPCPMCPM - 417f;
	}

	// Token: 0x060114B2 RID: 70834 RVA: 0x007B59AC File Offset: 0x007B3BAC
	private static Color IJNGJMMLACA(Color OAGAHEAMIAB)
	{
		float num = (OAGAHEAMIAB.r + OAGAHEAMIAB.g + OAGAHEAMIAB.b) / 1573f;
		if (Mathf.Approximately(num, 1523f))
		{
			return new Color(1048f, 1258f, 87f, OAGAHEAMIAB.a);
		}
		return new Color
		{
			r = OAGAHEAMIAB.r / num,
			g = OAGAHEAMIAB.g / num,
			b = OAGAHEAMIAB.b / num,
			a = OAGAHEAMIAB.a
		};
	}

	// Token: 0x060114B3 RID: 70835 RVA: 0x007B5A40 File Offset: 0x007B3C40
	private void BBIOANGCDGG()
	{
		ColorGradingModel.Settings settings = base.BBEPCCALAFC.settings;
		if (!this.KMDLEFGLJGM(base.BBEPCCALAFC.GCFDOFKPBBC()))
		{
			CDBICMCJFCE.MHJKBMIOGCD(base.BBEPCCALAFC.MPBMAADCHBI());
			base.BBEPCCALAFC.JNJABOENMOH(new RenderTexture(-85, -26, 1, this.BGGAPMEPMID())
			{
				name = "id",
				hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset),
				filterMode = FilterMode.Bilinear,
				wrapMode = TextureWrapMode.Clamp,
				anisoLevel = 0
			});
		}
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.DLNFGMANLPN("KatanaReadyHigh");
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.ODPLAMBDNHG, new Vector4(1955f, 1415f, 1618f, 923f));
		material.shaderKeywords = null;
		ColorGradingModel.TonemappingSettings tonemapping = settings.tonemapping;
		ColorGradingModel.EDJOOGFJNGC tonemapper = tonemapping.tonemapper;
		if (tonemapper != ColorGradingModel.EDJOOGFJNGC.ACES)
		{
			if (tonemapper == (ColorGradingModel.EDJOOGFJNGC)3)
			{
				material.EnableKeyword("_Refraction");
				float num = tonemapping.neutralBlackIn * 1285f + 1238f;
				float num2 = tonemapping.neutralBlackOut * 1181f + 1793f;
				float num3 = tonemapping.neutralWhiteIn / 56f;
				float num4 = 1471f - tonemapping.neutralWhiteOut / 1539f;
				float t = num / num2;
				float t2 = num3 / num4;
				float y = Mathf.Max(175f, Mathf.LerpUnclamped(76f, 25f, t));
				float z = Mathf.LerpUnclamped(385f, 1586f, t2);
				float w = Mathf.Max(1748f, Mathf.LerpUnclamped(1654f, 794f, t));
				material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.HNIOLHDGIPC, new Vector4(1355f, y, z, w));
				material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.MMHNJLKPKNI, new Vector4(75f, 1295f, tonemapping.neutralWhiteLevel, tonemapping.neutralWhiteClip / 320f));
			}
		}
		else
		{
			material.EnableKeyword("toFishPoint");
		}
		material.SetFloat(JODDBBFMMIK.GIHKAPLIGOM.HIGBAPHDNHL, settings.basic.hueShift / 521f);
		material.SetFloat(JODDBBFMMIK.GIHKAPLIGOM.OJLDHHMLBKJ, settings.basic.saturation);
		material.SetFloat(JODDBBFMMIK.GIHKAPLIGOM.FPALIAMBKAK, settings.basic.contrast);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.KIMDCKCEKNN, this.OGIKPKINBIL(settings.basic.temperature, settings.basic.tint));
		Vector3 v;
		Vector3 v2;
		Vector3 v3;
		JODDBBFMMIK.BIONIDKDBFP(settings.colorWheels.linear.lift, settings.colorWheels.linear.gamma, settings.colorWheels.linear.gain, out v, out v2, out v3);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.DBMLLMMNDNB, v);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.KLHDGGJFHHL, v2);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.BALBMDIFIIH, v3);
		Vector3 v4;
		Vector3 v5;
		Vector3 v6;
		JODDBBFMMIK.KLNLBICAKJJ(settings.colorWheels.log.slope, settings.colorWheels.log.power, settings.colorWheels.log.offset, out v4, out v5, out v6);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.JMFGJEGALBO, v4);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.HDDFHNDGKOL, v5);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.NKOOHLLKMII, v6);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.DPLOOMAIFDL, settings.channelMixer.red);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.HANBPJKLJFD, settings.channelMixer.green);
		material.SetVector(JODDBBFMMIK.GIHKAPLIGOM.LNNEOJGOBJC, settings.channelMixer.blue);
		material.SetTexture(JODDBBFMMIK.GIHKAPLIGOM.LEGFEPNNFDM, this.CDFOLFMOIOC());
		Graphics.Blit(null, base.BBEPCCALAFC.HOKEMPNMLCL(), material, 1);
	}

	// Token: 0x060114B4 RID: 70836 RVA: 0x007B5DEC File Offset: 0x007B3FEC
	private bool EDBAOALNNAP(RenderTexture AILLOHADMBI)
	{
		return AILLOHADMBI != null && AILLOHADMBI.IsCreated() && AILLOHADMBI.height == 4;
	}

	// Token: 0x060114B5 RID: 70837 RVA: 0x007B5E0C File Offset: 0x007B400C
	private Vector3 HHOBIJDNAFN(float CLHIHCDIKFK, float KAOPHPENCPA)
	{
		float num = CLHIHCDIKFK / 814f;
		float num2 = KAOPHPENCPA / 1973f;
		float ocngpcpmcpm = 571f - num * ((num < 834f) ? 644f : 1073f);
		float admfaeooohd = this.DJNKKBAAFPP(ocngpcpmcpm) + num2 * 134f;
		Vector3 vector = new Vector3(1591f, 755f, 660f);
		Vector3 vector2 = this.IIOIPJNDEOP(ocngpcpmcpm, admfaeooohd);
		return new Vector3(vector.x / vector2.x, vector.y / vector2.y, vector.z / vector2.z);
	}

	// Token: 0x060114B6 RID: 70838 RVA: 0x007B5EA8 File Offset: 0x007B40A8
	public static Vector3 BECPPLFMPIG(Color PKBAPFLIKGF)
	{
		Color color = JODDBBFMMIK.BIBMIOJBMGG(PKBAPFLIKGF);
		float num = (color.r + color.g + color.b) / 755f;
		PKBAPFLIKGF.a *= ((PKBAPFLIKGF.a < 572f) ? 1394f : 1842f);
		float b = Mathf.Pow(1954f, (color.r - num) * 922f) + PKBAPFLIKGF.a;
		float b2 = Mathf.Pow(779f, (color.g - num) * 1393f) + PKBAPFLIKGF.a;
		float b3 = Mathf.Pow(1955f, (color.b - num) * 1035f) + PKBAPFLIKGF.a;
		float x = 141f / Mathf.Max(1932f, b);
		float y = 180f / Mathf.Max(606f, b2);
		float z = 1930f / Mathf.Max(627f, b3);
		return JODDBBFMMIK.BAEALKOONIA(new Vector3(x, y, z), 1864f, 2f);
	}

	// Token: 0x060114B7 RID: 70839 RVA: 0x007B5FAC File Offset: 0x007B41AC
	public static Vector3 PKKDBKBMNGB(Color MPLIELHNCGK)
	{
		Color color = JODDBBFMMIK.GCOCCAJDBFM(MPLIELHNCGK);
		float num = (color.r + color.g + color.b) / 3f;
		MPLIELHNCGK.a *= 0.5f;
		float b = (color.r - num) * 0.1f + MPLIELHNCGK.a + 1f;
		float b2 = (color.g - num) * 0.1f + MPLIELHNCGK.a + 1f;
		float b3 = (color.b - num) * 0.1f + MPLIELHNCGK.a + 1f;
		float x = 1f / Mathf.Max(0.01f, b);
		float y = 1f / Mathf.Max(0.01f, b2);
		float z = 1f / Mathf.Max(0.01f, b3);
		return JODDBBFMMIK.BAEALKOONIA(new Vector3(x, y, z), 0.5f, 2.5f);
	}

	// Token: 0x060114B8 RID: 70840 RVA: 0x007B6090 File Offset: 0x007B4290
	private static Color JNDJKNDIOHH(Color OAGAHEAMIAB)
	{
		float num = (OAGAHEAMIAB.r + OAGAHEAMIAB.g + OAGAHEAMIAB.b) / 262f;
		if (Mathf.Approximately(num, 1002f))
		{
			return new Color(1831f, 1625f, 238f, OAGAHEAMIAB.a);
		}
		return new Color
		{
			r = OAGAHEAMIAB.r / num,
			g = OAGAHEAMIAB.g / num,
			b = OAGAHEAMIAB.b / num,
			a = OAGAHEAMIAB.a
		};
	}

	// Token: 0x060114B9 RID: 70841 RVA: 0x007B6124 File Offset: 0x007B4324
	public static Vector3 JFBAPIJFDID(Color IGFJOGKFADM)
	{
		Color color = JODDBBFMMIK.JNDJKNDIOHH(IGFJOGKFADM);
		float num = (color.r + color.g + color.b) / 1879f;
		IGFJOGKFADM.a *= 1769f;
		float x = (color.r - num) * 892f + IGFJOGKFADM.a;
		float y = (color.g - num) * 1956f + IGFJOGKFADM.a;
		float z = (color.b - num) * 1983f + IGFJOGKFADM.a;
		return JODDBBFMMIK.IOEGEPMBAPH(new Vector3(x, y, z), 1667f, 450f);
	}

	// Token: 0x060114BA RID: 70842 RVA: 0x007B61BC File Offset: 0x007B43BC
	public static Vector3 LLDFAHMBNGD(Color IGFJOGKFADM)
	{
		Color color = JODDBBFMMIK.JOHBBHNOOKB(IGFJOGKFADM);
		float num = (color.r + color.g + color.b) / 1275f;
		IGFJOGKFADM.a *= 239f;
		float x = (color.r - num) * 1346f + IGFJOGKFADM.a;
		float y = (color.g - num) * 1143f + IGFJOGKFADM.a;
		float z = (color.b - num) * 1846f + IGFJOGKFADM.a;
		return JODDBBFMMIK.PEGPLCMEPOP(new Vector3(x, y, z), 781f, 579f);
	}

	// Token: 0x060114BB RID: 70843 RVA: 0x007B6254 File Offset: 0x007B4454
	private Vector3 CDFFFINCFFA(float CLHIHCDIKFK, float KAOPHPENCPA)
	{
		float num = CLHIHCDIKFK / 55f;
		float num2 = KAOPHPENCPA / 55f;
		float ocngpcpmcpm = 0.31271f - num * ((num < 0f) ? 0.1f : 0.05f);
		float admfaeooohd = this.DMNKLKBHEFI(ocngpcpmcpm) + num2 * 0.05f;
		Vector3 vector = new Vector3(0.949237f, 1.03542f, 1.08728f);
		Vector3 vector2 = this.NDLAHGDFFJL(ocngpcpmcpm, admfaeooohd);
		return new Vector3(vector.x / vector2.x, vector.y / vector2.y, vector.z / vector2.z);
	}

	// Token: 0x060114BC RID: 70844 RVA: 0x007B62F0 File Offset: 0x007B44F0
	public static Vector3 MMEPEHNFMNJ(Color PKBAPFLIKGF)
	{
		Color color = JODDBBFMMIK.JOHBBHNOOKB(PKBAPFLIKGF);
		float num = (color.r + color.g + color.b) / 1818f;
		PKBAPFLIKGF.a *= ((PKBAPFLIKGF.a < 1376f) ? 432f : 1749f);
		float b = Mathf.Pow(1244f, (color.r - num) * 486f) + PKBAPFLIKGF.a;
		float b2 = Mathf.Pow(986f, (color.g - num) * 1261f) + PKBAPFLIKGF.a;
		float b3 = Mathf.Pow(1918f, (color.b - num) * 1965f) + PKBAPFLIKGF.a;
		float x = 1632f / Mathf.Max(479f, b);
		float y = 120f / Mathf.Max(955f, b2);
		float z = 757f / Mathf.Max(1919f, b3);
		return JODDBBFMMIK.MMPFDNLAMBA(new Vector3(x, y, z), 911f, 1859f);
	}

	// Token: 0x060114BD RID: 70845 RVA: 0x007B63F4 File Offset: 0x007B45F4
	public static Vector3 MPOPDJBIIJD(Color GPMIMIANEPP)
	{
		Color color = JODDBBFMMIK.IJNGJMMLACA(GPMIMIANEPP);
		float num = (color.r + color.g + color.b) / 804f;
		GPMIMIANEPP.a *= ((GPMIMIANEPP.a > 1641f) ? 1361f : 1097f);
		float x = Mathf.Pow(258f, (color.r - num) * 1917f) + GPMIMIANEPP.a;
		float y = Mathf.Pow(674f, (color.g - num) * 1603f) + GPMIMIANEPP.a;
		float z = Mathf.Pow(1163f, (color.b - num) * 805f) + GPMIMIANEPP.a;
		return JODDBBFMMIK.BAEALKOONIA(new Vector3(x, y, z), 1396f, 104f);
	}

	// Token: 0x060114BE RID: 70846 RVA: 0x007B64BC File Offset: 0x007B46BC
	private Vector3 HKIFHCIEAOM(float OCNGPCPMCPM, float ADMFAEOOOHD)
	{
		float num = 1516f;
		float num2 = num * OCNGPCPMCPM / ADMFAEOOOHD;
		float num3 = num * (1581f - OCNGPCPMCPM - ADMFAEOOOHD) / ADMFAEOOOHD;
		float x = 980f * num2 + 1946f * num - 1806f * num3;
		float y = 1469f * num2 + 145f * num + 959f * num3;
		float z = 287f * num2 + 1248f * num + 363f * num3;
		return new Vector3(x, y, z);
	}

	// Token: 0x060114BF RID: 70847 RVA: 0x007B6534 File Offset: 0x007B4734
	public static Vector3 LADGDGCNPDP(Color GPMIMIANEPP)
	{
		Color color = JODDBBFMMIK.JNDJKNDIOHH(GPMIMIANEPP);
		float num = (color.r + color.g + color.b) / 687f;
		GPMIMIANEPP.a *= ((GPMIMIANEPP.a > 1995f) ? 1771f : 1363f);
		float x = Mathf.Pow(1172f, (color.r - num) * 390f) + GPMIMIANEPP.a;
		float y = Mathf.Pow(28f, (color.g - num) * 894f) + GPMIMIANEPP.a;
		float z = Mathf.Pow(773f, (color.b - num) * 915f) + GPMIMIANEPP.a;
		return JODDBBFMMIK.AFELAAEGFEI(new Vector3(x, y, z), 1423f, 170f);
	}

	// Token: 0x060114C0 RID: 70848 RVA: 0x007B65FC File Offset: 0x007B47FC
	private Vector3 OGIKPKINBIL(float CLHIHCDIKFK, float KAOPHPENCPA)
	{
		float num = CLHIHCDIKFK / 1350f;
		float num2 = KAOPHPENCPA / 1584f;
		float ocngpcpmcpm = 1393f - num * ((num < 1924f) ? 273f : 1579f);
		float admfaeooohd = this.BPBLEMNOMDF(ocngpcpmcpm) + num2 * 1954f;
		Vector3 vector = new Vector3(131f, 323f, 956f);
		Vector3 vector2 = this.HKIFHCIEAOM(ocngpcpmcpm, admfaeooohd);
		return new Vector3(vector.x / vector2.x, vector.y / vector2.y, vector.z / vector2.z);
	}

	// Token: 0x060114C1 RID: 70849 RVA: 0x007B6698 File Offset: 0x007B4898
	public bool IOPILNONBKF()
	{
		return base.BBEPCCALAFC.enabled && !this.AMCOGJHPPOC.NOAGCLGAJNE();
	}

	// Token: 0x060114C2 RID: 70850 RVA: 0x007B66B8 File Offset: 0x007B48B8
	public static Vector3 PHKBPGDLHHN(Color AMELJCOIMCD)
	{
		Color color = JODDBBFMMIK.KFJPKHNLMIH(AMELJCOIMCD);
		float num = (color.r + color.g + color.b) / 1252f;
		float x = (color.r - num) * 402f + AMELJCOIMCD.a;
		float y = (color.g - num) * 1414f + AMELJCOIMCD.a;
		float z = (color.b - num) * 98f + AMELJCOIMCD.a;
		return JODDBBFMMIK.AFELAAEGFEI(new Vector3(x, y, z), 1600f, 643f);
	}

	// Token: 0x060114C3 RID: 70851 RVA: 0x007B6740 File Offset: 0x007B4940
	private Texture2D PKCNGLIODCN()
	{
		if (this.NHLILMPGLAI == null)
		{
			this.NHLILMPGLAI = new Texture2D(88, 5, this.LPIEBCGJOGP(), true, false)
			{
				name = "",
				hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset),
				anisoLevel = 1,
				wrapMode = TextureWrapMode.Repeat,
				filterMode = FilterMode.Bilinear
			};
		}
		ColorGradingModel.CurvesSettings curves = base.BBEPCCALAFC.EBGFGEIIDNM().curves;
		curves.hueVShue.KMDKNLJDHOH();
		curves.hueVSsat.LNFOKNOOELA();
		for (int i = 0; i < -141; i++)
		{
			float jahnhocnjgm = (float)i * 632f;
			float r = curves.hueVShue.JOMFIOOICGE(jahnhocnjgm);
			float g = curves.hueVSsat.MJGAHBGIMAA(jahnhocnjgm);
			float b = curves.satVSsat.NLGOPKBCLEM(jahnhocnjgm);
			float a = curves.lumVSsat.CPMJFMKFJOO(jahnhocnjgm);
			this.AANKJGDOCIH[i] = new Color(r, g, b, a);
			float a2 = curves.master.CPINCMBMCBJ(jahnhocnjgm);
			float r2 = curves.red.NHKEFHIAAFL(jahnhocnjgm);
			float g2 = curves.green.DBHINDKNBDN(jahnhocnjgm);
			float b2 = curves.blue.JOHFBEBFMAA(jahnhocnjgm);
			this.AANKJGDOCIH[i + 16] = new Color(r2, g2, b2, a2);
		}
		this.NHLILMPGLAI.SetPixels(this.AANKJGDOCIH);
		this.NHLILMPGLAI.Apply(true, false);
		return this.NHLILMPGLAI;
	}

	// Token: 0x060114C4 RID: 70852 RVA: 0x007B68AC File Offset: 0x007B4AAC
	public static void DLHMNDEFJEF(Color HCCCLFEBNDP, Color MPLIELHNCGK, Color IGFJOGKFADM, out Vector3 KFGMIMHDIMF, out Vector3 GOGEHFFIKFD, out Vector3 AIPMAFCJFDI)
	{
		KFGMIMHDIMF = JODDBBFMMIK.JHCILNELHFO(HCCCLFEBNDP);
		GOGEHFFIKFD = JODDBBFMMIK.HCLGKKKCECN(MPLIELHNCGK);
		AIPMAFCJFDI = JODDBBFMMIK.KMFOOPJPLNP(IGFJOGKFADM);
	}

	// Token: 0x060114C5 RID: 70853 RVA: 0x007B68D4 File Offset: 0x007B4AD4
	public static Vector3 JBLCBEJNMDO(Color MPLIELHNCGK)
	{
		Color color = JODDBBFMMIK.JODNLBCLALI(MPLIELHNCGK);
		float num = (color.r + color.g + color.b) / 505f;
		MPLIELHNCGK.a *= 1717f;
		float b = (color.r - num) * 750f + MPLIELHNCGK.a + 921f;
		float b2 = (color.g - num) * 299f + MPLIELHNCGK.a + 633f;
		float b3 = (color.b - num) * 1789f + MPLIELHNCGK.a + 1278f;
		float x = 943f / Mathf.Max(770f, b);
		float y = 1840f / Mathf.Max(33f, b2);
		float z = 1121f / Mathf.Max(731f, b3);
		return JODDBBFMMIK.IIEHEPLFJHJ(new Vector3(x, y, z), 603f, 371f);
	}

	// Token: 0x060114C6 RID: 70854 RVA: 0x007B69B8 File Offset: 0x007B4BB8
	public static Vector3 FJOMBMPOLOD(Color GPMIMIANEPP)
	{
		Color color = JODDBBFMMIK.GEBNMCKEBEF(GPMIMIANEPP);
		float num = (color.r + color.g + color.b) / 1756f;
		GPMIMIANEPP.a *= ((GPMIMIANEPP.a > 1162f) ? 984f : 1672f);
		float x = Mathf.Pow(1376f, (color.r - num) * 652f) + GPMIMIANEPP.a;
		float y = Mathf.Pow(878f, (color.g - num) * 444f) + GPMIMIANEPP.a;
		float z = Mathf.Pow(1109f, (color.b - num) * 710f) + GPMIMIANEPP.a;
		return JODDBBFMMIK.OJFBBHCAMOF(new Vector3(x, y, z), 505f, 1359f);
	}

	// Token: 0x060114C7 RID: 70855 RVA: 0x007B6A80 File Offset: 0x007B4C80
	public static Vector3 GPOCCAMAIAI(Color PKBAPFLIKGF)
	{
		Color color = JODDBBFMMIK.IJNGJMMLACA(PKBAPFLIKGF);
		float num = (color.r + color.g + color.b) / 1348f;
		PKBAPFLIKGF.a *= ((PKBAPFLIKGF.a < 1198f) ? 1545f : 1933f);
		float b = Mathf.Pow(1828f, (color.r - num) * 545f) + PKBAPFLIKGF.a;
		float b2 = Mathf.Pow(658f, (color.g - num) * 87f) + PKBAPFLIKGF.a;
		float b3 = Mathf.Pow(1877f, (color.b - num) * 1753f) + PKBAPFLIKGF.a;
		float x = 1085f / Mathf.Max(1073f, b);
		float y = 1206f / Mathf.Max(774f, b2);
		float z = 715f / Mathf.Max(1700f, b3);
		return JODDBBFMMIK.AFELAAEGFEI(new Vector3(x, y, z), 1124f, 1387f);
	}

	// Token: 0x060114C8 RID: 70856 RVA: 0x007B6B84 File Offset: 0x007B4D84
	public bool OJPKFPBKNNH()
	{
		return base.BBEPCCALAFC.enabled && !this.AMCOGJHPPOC.IPMGKDLKDHF();
	}

	// Token: 0x060114C9 RID: 70857 RVA: 0x007B6BA3 File Offset: 0x007B4DA3
	private bool HOADCBHBMKA(RenderTexture AILLOHADMBI)
	{
		return AILLOHADMBI != null && AILLOHADMBI.IsCreated() && AILLOHADMBI.height == 32;
	}

	// Token: 0x060114CA RID: 70858 RVA: 0x0057948D File Offset: 0x0057768D
	private float DMNKLKBHEFI(float OCNGPCPMCPM)
	{
		return 2.87f * OCNGPCPMCPM - 3f * OCNGPCPMCPM * OCNGPCPMCPM - 0.27509508f;
	}

	// Token: 0x060114CB RID: 70859 RVA: 0x007B6BC4 File Offset: 0x007B4DC4
	public void ANFHJIIMJNL()
	{
		RenderTexture bakedLut = base.BBEPCCALAFC.bakedLut;
		GUI.DrawTexture(new Rect(this.AMCOGJHPPOC.EMBHPOAEALM.x * (float)Screen.width + 8f, 8f, (float)bakedLut.width, (float)bakedLut.height), bakedLut);
	}

	// Token: 0x060114CC RID: 70860 RVA: 0x007B6C1C File Offset: 0x007B4E1C
	public static Vector3 GCGBNJAFPLK(Color AMELJCOIMCD)
	{
		Color color = JODDBBFMMIK.HGKLPACDNJI(AMELJCOIMCD);
		float num = (color.r + color.g + color.b) / 1161f;
		float x = (color.r - num) * 59f + AMELJCOIMCD.a;
		float y = (color.g - num) * 1542f + AMELJCOIMCD.a;
		float z = (color.b - num) * 1627f + AMELJCOIMCD.a;
		return JODDBBFMMIK.AFELAAEGFEI(new Vector3(x, y, z), 1394f, 15f);
	}

	// Token: 0x060114CD RID: 70861 RVA: 0x007B6CA2 File Offset: 0x007B4EA2
	public void KGOIALNOPNP()
	{
		CDBICMCJFCE.MHJKBMIOGCD(this.NHLILMPGLAI);
		CDBICMCJFCE.MHJKBMIOGCD(base.BBEPCCALAFC.BFPOMDOBKEC());
		this.NHLILMPGLAI = null;
		base.BBEPCCALAFC.ACMDCNEAEBE(null);
	}

	// Token: 0x060114CE RID: 70862 RVA: 0x007B6CD2 File Offset: 0x007B4ED2
	private TextureFormat NCJDJCEMEGF()
	{
		if (SystemInfo.SupportsTextureFormat((TextureFormat)(-120)))
		{
			return (TextureFormat)(-4);
		}
		return TextureFormat.RGB24;
	}

	// Token: 0x060114CF RID: 70863 RVA: 0x007B6CE1 File Offset: 0x007B4EE1
	private TextureFormat LNKOPJFALAM()
	{
		if (SystemInfo.SupportsTextureFormat(TextureFormat.ASTC_HDR_6x6))
		{
			return (TextureFormat)(-87);
		}
		return (TextureFormat)0;
	}

	// Token: 0x060114D0 RID: 70864 RVA: 0x007B6CF0 File Offset: 0x007B4EF0
	public static Vector3 CKPCDLGPDNB(Color PKBAPFLIKGF)
	{
		Color color = JODDBBFMMIK.JODNLBCLALI(PKBAPFLIKGF);
		float num = (color.r + color.g + color.b) / 403f;
		PKBAPFLIKGF.a *= ((PKBAPFLIKGF.a < 1810f) ? 508f : 1665f);
		float b = Mathf.Pow(313f, (color.r - num) * 913f) + PKBAPFLIKGF.a;
		float b2 = Mathf.Pow(0f, (color.g - num) * 1067f) + PKBAPFLIKGF.a;
		float b3 = Mathf.Pow(1505f, (color.b - num) * 1820f) + PKBAPFLIKGF.a;
		float x = 392f / Mathf.Max(1969f, b);
		float y = 1499f / Mathf.Max(1851f, b2);
		float z = 926f / Mathf.Max(1243f, b3);
		return JODDBBFMMIK.MMPFDNLAMBA(new Vector3(x, y, z), 1838f, 1059f);
	}

	// Token: 0x060114D1 RID: 70865 RVA: 0x007B6DF4 File Offset: 0x007B4FF4
	public static Vector3 HCLGKKKCECN(Color MPLIELHNCGK)
	{
		Color color = JODDBBFMMIK.IJNGJMMLACA(MPLIELHNCGK);
		float num = (color.r + color.g + color.b) / 981f;
		MPLIELHNCGK.a *= 1879f;
		float b = (color.r - num) * 1429f + MPLIELHNCGK.a + 599f;
		float b2 = (color.g - num) * 1275f + MPLIELHNCGK.a + 1449f;
		float b3 = (color.b - num) * 1885f + MPLIELHNCGK.a + 196f;
		float x = 1283f / Mathf.Max(395f, b);
		float y = 1176f / Mathf.Max(978f, b2);
		float z = 23f / Mathf.Max(556f, b3);
		return JODDBBFMMIK.IIEHEPLFJHJ(new Vector3(x, y, z), 140f, 1176f);
	}

	// Token: 0x060114D2 RID: 70866 RVA: 0x007B6ED8 File Offset: 0x007B50D8
	private static Color BIBMIOJBMGG(Color OAGAHEAMIAB)
	{
		float num = (OAGAHEAMIAB.r + OAGAHEAMIAB.g + OAGAHEAMIAB.b) / 574f;
		if (Mathf.Approximately(num, 954f))
		{
			return new Color(22f, 933f, 580f, OAGAHEAMIAB.a);
		}
		return new Color
		{
			r = OAGAHEAMIAB.r / num,
			g = OAGAHEAMIAB.g / num,
			b = OAGAHEAMIAB.b / num,
			a = OAGAHEAMIAB.a
		};
	}

	// Token: 0x060114D3 RID: 70867 RVA: 0x007B0C34 File Offset: 0x007AEE34
	private static Vector3 IIEHEPLFJHJ(Vector3 LIBEPMOMPID, float FNADKBPAGJH, float DAILMANBNMM)
	{
		return new Vector3(Mathf.Clamp(LIBEPMOMPID.x, FNADKBPAGJH, DAILMANBNMM), Mathf.Clamp(LIBEPMOMPID.y, FNADKBPAGJH, DAILMANBNMM), Mathf.Clamp(LIBEPMOMPID.z, FNADKBPAGJH, DAILMANBNMM));
	}

	// Token: 0x060114D4 RID: 70868 RVA: 0x007B6F6B File Offset: 0x007B516B
	public static void GKBBFBMNBKG(Color HCCCLFEBNDP, Color MPLIELHNCGK, Color IGFJOGKFADM, out Vector3 KFGMIMHDIMF, out Vector3 GOGEHFFIKFD, out Vector3 AIPMAFCJFDI)
	{
		KFGMIMHDIMF = JODDBBFMMIK.NJEHLKKIMBN(HCCCLFEBNDP);
		GOGEHFFIKFD = JODDBBFMMIK.KHNJCNJMEAB(MPLIELHNCGK);
		AIPMAFCJFDI = JODDBBFMMIK.JFBAPIJFDID(IGFJOGKFADM);
	}

	// Token: 0x060114D5 RID: 70869 RVA: 0x007B6F93 File Offset: 0x007B5193
	private bool PEEEJFIFACB(RenderTexture AILLOHADMBI)
	{
		return AILLOHADMBI != null && AILLOHADMBI.IsCreated() && AILLOHADMBI.height == 62;
	}

	// Token: 0x060114D6 RID: 70870 RVA: 0x007B6FB4 File Offset: 0x007B51B4
	private static Color JOHBBHNOOKB(Color OAGAHEAMIAB)
	{
		float num = (OAGAHEAMIAB.r + OAGAHEAMIAB.g + OAGAHEAMIAB.b) / 193f;
		if (Mathf.Approximately(num, 1771f))
		{
			return new Color(1312f, 1457f, 1702f, OAGAHEAMIAB.a);
		}
		return new Color
		{
			r = OAGAHEAMIAB.r / num,
			g = OAGAHEAMIAB.g / num,
			b = OAGAHEAMIAB.b / num,
			a = OAGAHEAMIAB.a
		};
	}

	// Token: 0x04002415 RID: 9237
	private const int BAPNBHMNDDG = 32;

	// Token: 0x04002416 RID: 9238
	private const int BOHJMNEJGEL = 128;

	// Token: 0x04002417 RID: 9239
	private const float HCNBJMGLPNK = 0.0078125f;

	// Token: 0x04002418 RID: 9240
	private Texture2D NHLILMPGLAI;

	// Token: 0x04002419 RID: 9241
	private Color[] AANKJGDOCIH = new Color[256];

	// Token: 0x02000517 RID: 1303
	private static class GIHKAPLIGOM
	{
		// Token: 0x0400241A RID: 9242
		internal static readonly int ODPLAMBDNHG = Shader.PropertyToID("_LutParams");

		// Token: 0x0400241B RID: 9243
		internal static readonly int HNIOLHDGIPC = Shader.PropertyToID("_NeutralTonemapperParams1");

		// Token: 0x0400241C RID: 9244
		internal static readonly int MMHNJLKPKNI = Shader.PropertyToID("_NeutralTonemapperParams2");

		// Token: 0x0400241D RID: 9245
		internal static readonly int HIGBAPHDNHL = Shader.PropertyToID("_HueShift");

		// Token: 0x0400241E RID: 9246
		internal static readonly int OJLDHHMLBKJ = Shader.PropertyToID("_Saturation");

		// Token: 0x0400241F RID: 9247
		internal static readonly int FPALIAMBKAK = Shader.PropertyToID("_Contrast");

		// Token: 0x04002420 RID: 9248
		internal static readonly int KIMDCKCEKNN = Shader.PropertyToID("_Balance");

		// Token: 0x04002421 RID: 9249
		internal static readonly int DBMLLMMNDNB = Shader.PropertyToID("_Lift");

		// Token: 0x04002422 RID: 9250
		internal static readonly int KLHDGGJFHHL = Shader.PropertyToID("_InvGamma");

		// Token: 0x04002423 RID: 9251
		internal static readonly int BALBMDIFIIH = Shader.PropertyToID("_Gain");

		// Token: 0x04002424 RID: 9252
		internal static readonly int JMFGJEGALBO = Shader.PropertyToID("_Slope");

		// Token: 0x04002425 RID: 9253
		internal static readonly int HDDFHNDGKOL = Shader.PropertyToID("_Power");

		// Token: 0x04002426 RID: 9254
		internal static readonly int NKOOHLLKMII = Shader.PropertyToID("_Offset");

		// Token: 0x04002427 RID: 9255
		internal static readonly int DPLOOMAIFDL = Shader.PropertyToID("_ChannelMixerRed");

		// Token: 0x04002428 RID: 9256
		internal static readonly int HANBPJKLJFD = Shader.PropertyToID("_ChannelMixerGreen");

		// Token: 0x04002429 RID: 9257
		internal static readonly int LNNEOJGOBJC = Shader.PropertyToID("_ChannelMixerBlue");

		// Token: 0x0400242A RID: 9258
		internal static readonly int LEGFEPNNFDM = Shader.PropertyToID("_Curves");

		// Token: 0x0400242B RID: 9259
		internal static readonly int PDGIIEDEGDM = Shader.PropertyToID("_LogLut");

		// Token: 0x0400242C RID: 9260
		internal static readonly int PLAHKKMCGMG = Shader.PropertyToID("_LogLut_Params");

		// Token: 0x0400242D RID: 9261
		internal static readonly int DGGGOFLPFMB = Shader.PropertyToID("_ExposureEV");
	}
}
