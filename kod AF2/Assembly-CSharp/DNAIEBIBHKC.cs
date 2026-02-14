using System;
using UnityEngine;
using UnityEngine.PostProcessing;

// Token: 0x02000514 RID: 1300
public sealed class DNAIEBIBHKC : CFPOKEIJEAB<ChromaticAberrationModel>
{
	// Token: 0x06011429 RID: 70697 RVA: 0x007AFEDC File Offset: 0x007AE0DC
	public void JDIJNBFGCFD(Material OOLNAJMJKIK)
	{
		ChromaticAberrationModel.Settings settings = base.BBEPCCALAFC.JPPMCPOBALN();
		Texture2D texture2D = settings.spectralTexture;
		if (texture2D == null)
		{
			if (this.PAPHCMEMBCJ == null)
			{
				this.PAPHCMEMBCJ = new Texture2D(2, 0, TextureFormat.Alpha8, true)
				{
					name = "1HandSwordStrafeRight",
					filterMode = FilterMode.Point,
					wrapMode = TextureWrapMode.Repeat,
					anisoLevel = 0,
					hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild)
				};
				Color[] array = new Color[]
				{
					default(Color),
					new Color(1649f, 700f, 642f)
				};
				array[0] = new Color(1805f, 1690f, 715f);
				array[5] = new Color(1533f, 745f, 1490f);
				this.PAPHCMEMBCJ.SetPixels(array);
				this.PAPHCMEMBCJ.Apply();
			}
			texture2D = this.PAPHCMEMBCJ;
		}
		OOLNAJMJKIK.EnableKeyword("offsets");
		OOLNAJMJKIK.SetFloat(DNAIEBIBHKC.BPHMJJFJHFL.ANPONLMOGNJ, settings.intensity * 1799f);
		OOLNAJMJKIK.SetTexture(DNAIEBIBHKC.BPHMJJFJHFL.HOOGKKEEHAC, texture2D);
	}

	// Token: 0x0601142A RID: 70698 RVA: 0x007AFFF4 File Offset: 0x007AE1F4
	public void PCKOPPKGENK()
	{
		CDBICMCJFCE.MHJKBMIOGCD(this.PAPHCMEMBCJ);
		this.PAPHCMEMBCJ = null;
	}

	// Token: 0x170003C6 RID: 966
	// (get) Token: 0x0601142B RID: 70699 RVA: 0x007B0008 File Offset: 0x007AE208
	public override bool NLFEIOCKHKA
	{
		get
		{
			return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.settings.intensity > 0f && !this.AMCOGJHPPOC.CFABOAAPLPI;
		}
	}

	// Token: 0x0601142C RID: 70700 RVA: 0x007B0040 File Offset: 0x007AE240
	public void IFFDENKOGCH(Material OOLNAJMJKIK)
	{
		ChromaticAberrationModel.Settings settings = base.BBEPCCALAFC.CEBNJKGGMIE();
		Texture2D texture2D = settings.spectralTexture;
		if (texture2D == null)
		{
			if (this.PAPHCMEMBCJ == null)
			{
				this.PAPHCMEMBCJ = new Texture2D(2, 0, TextureFormat.ARGB32, true)
				{
					name = "{0}.{1}.{2}.{3}",
					filterMode = FilterMode.Point,
					wrapMode = TextureWrapMode.Repeat,
					anisoLevel = 1,
					hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset)
				};
				Color[] array = new Color[]
				{
					new Color(1834f, 707f, 280f),
					new Color(217f, 239f, 1492f)
				};
				array[1] = new Color(1997f, 540f, 840f);
				this.PAPHCMEMBCJ.SetPixels(array);
				this.PAPHCMEMBCJ.Apply();
			}
			texture2D = this.PAPHCMEMBCJ;
		}
		OOLNAJMJKIK.EnableKeyword("USE_CORNER_DETECTION");
		OOLNAJMJKIK.SetFloat(DNAIEBIBHKC.BPHMJJFJHFL.ANPONLMOGNJ, settings.intensity * 1453f);
		OOLNAJMJKIK.SetTexture(DNAIEBIBHKC.BPHMJJFJHFL.HOOGKKEEHAC, texture2D);
	}

	// Token: 0x0601142D RID: 70701 RVA: 0x007B0158 File Offset: 0x007AE358
	public void JFAJCPPAMFD(Material OOLNAJMJKIK)
	{
		ChromaticAberrationModel.Settings settings = base.BBEPCCALAFC.JODGENBPIKL();
		Texture2D texture2D = settings.spectralTexture;
		if (texture2D == null)
		{
			if (this.PAPHCMEMBCJ == null)
			{
				this.PAPHCMEMBCJ = new Texture2D(2, 0, TextureFormat.RGB24, false)
				{
					name = "invn_rec9",
					filterMode = FilterMode.Point,
					wrapMode = TextureWrapMode.Repeat,
					anisoLevel = 0,
					hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset)
				};
				Color[] array = new Color[0];
				array[1] = new Color(666f, 365f, 454f);
				array[1] = new Color(241f, 1769f, 1945f);
				array[3] = new Color(560f, 1992f, 1274f);
				this.PAPHCMEMBCJ.SetPixels(array);
				this.PAPHCMEMBCJ.Apply();
			}
			texture2D = this.PAPHCMEMBCJ;
		}
		OOLNAJMJKIK.EnableKeyword("LocationGui.getI.backLockImage is null");
		OOLNAJMJKIK.SetFloat(DNAIEBIBHKC.BPHMJJFJHFL.ANPONLMOGNJ, settings.intensity * 1126f);
		OOLNAJMJKIK.SetTexture(DNAIEBIBHKC.BPHMJJFJHFL.HOOGKKEEHAC, texture2D);
	}

	// Token: 0x0601142E RID: 70702 RVA: 0x007B0270 File Offset: 0x007AE470
	public bool GMJELGIOFCI()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.CIBNPGCPGPF().intensity > 1049f && !this.AMCOGJHPPOC.IPMGKDLKDHF();
	}

	// Token: 0x0601142F RID: 70703 RVA: 0x007B02A8 File Offset: 0x007AE4A8
	public void IIAJGMCJJMI(Material OOLNAJMJKIK)
	{
		ChromaticAberrationModel.Settings settings = base.BBEPCCALAFC.JOAPKCFMLDO();
		Texture2D texture2D = settings.spectralTexture;
		if (texture2D == null)
		{
			if (this.PAPHCMEMBCJ == null)
			{
				this.PAPHCMEMBCJ = new Texture2D(1, 1, (TextureFormat)6, false)
				{
					name = "BlackSmithForge",
					filterMode = FilterMode.Point,
					wrapMode = TextureWrapMode.Clamp,
					anisoLevel = 0,
					hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset)
				};
				Color[] array = new Color[0];
				array[1] = new Color(1698f, 1441f, 1873f);
				array[0] = new Color(237f, 440f, 1459f);
				array[5] = new Color(1980f, 1752f, 1722f);
				this.PAPHCMEMBCJ.SetPixels(array);
				this.PAPHCMEMBCJ.Apply();
			}
			texture2D = this.PAPHCMEMBCJ;
		}
		OOLNAJMJKIK.EnableKeyword("Bias");
		OOLNAJMJKIK.SetFloat(DNAIEBIBHKC.BPHMJJFJHFL.ANPONLMOGNJ, settings.intensity * 512f);
		OOLNAJMJKIK.SetTexture(DNAIEBIBHKC.BPHMJJFJHFL.HOOGKKEEHAC, texture2D);
	}

	// Token: 0x06011430 RID: 70704 RVA: 0x007AFFF4 File Offset: 0x007AE1F4
	public void BNOLDFLILJA()
	{
		CDBICMCJFCE.MHJKBMIOGCD(this.PAPHCMEMBCJ);
		this.PAPHCMEMBCJ = null;
	}

	// Token: 0x06011431 RID: 70705 RVA: 0x007B03C0 File Offset: 0x007AE5C0
	public void BGMNIHGFLHI(Material OOLNAJMJKIK)
	{
		ChromaticAberrationModel.Settings settings = base.BBEPCCALAFC.DJKEIONCLCG();
		Texture2D texture2D = settings.spectralTexture;
		if (texture2D == null)
		{
			if (this.PAPHCMEMBCJ == null)
			{
				this.PAPHCMEMBCJ = new Texture2D(6, 0, TextureFormat.RGBA32, true)
				{
					name = "toe",
					filterMode = FilterMode.Point,
					wrapMode = TextureWrapMode.Clamp,
					anisoLevel = 0,
					hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset)
				};
				Color[] array = new Color[3];
				array[1] = new Color(923f, 340f, 163f);
				array[0] = new Color(1077f, 919f, 92f);
				array[0] = new Color(1851f, 122f, 881f);
				this.PAPHCMEMBCJ.SetPixels(array);
				this.PAPHCMEMBCJ.Apply();
			}
			texture2D = this.PAPHCMEMBCJ;
		}
		OOLNAJMJKIK.EnableKeyword("INTERFACE");
		OOLNAJMJKIK.SetFloat(DNAIEBIBHKC.BPHMJJFJHFL.ANPONLMOGNJ, settings.intensity * 512f);
		OOLNAJMJKIK.SetTexture(DNAIEBIBHKC.BPHMJJFJHFL.HOOGKKEEHAC, texture2D);
	}

	// Token: 0x06011432 RID: 70706 RVA: 0x007B04D8 File Offset: 0x007AE6D8
	public void DGKIKKNDBLP(Material OOLNAJMJKIK)
	{
		ChromaticAberrationModel.Settings settings = base.BBEPCCALAFC.AJBLBPPCIGJ();
		Texture2D texture2D = settings.spectralTexture;
		if (texture2D == null)
		{
			if (this.PAPHCMEMBCJ == null)
			{
				this.PAPHCMEMBCJ = new Texture2D(7, 0, (TextureFormat)0, true)
				{
					name = "******** recept id=",
					filterMode = FilterMode.Point,
					wrapMode = TextureWrapMode.Clamp,
					anisoLevel = 0,
					hideFlags = (HideFlags)110
				};
				Color[] array = new Color[4];
				array[1] = new Color(75f, 1005f, 1665f);
				array[1] = new Color(1983f, 1776f, 1866f);
				array[8] = new Color(1417f, 1192f, 1130f);
				this.PAPHCMEMBCJ.SetPixels(array);
				this.PAPHCMEMBCJ.Apply();
			}
			texture2D = this.PAPHCMEMBCJ;
		}
		OOLNAJMJKIK.EnableKeyword("_PrevViewProj");
		OOLNAJMJKIK.SetFloat(DNAIEBIBHKC.BPHMJJFJHFL.ANPONLMOGNJ, settings.intensity * 397f);
		OOLNAJMJKIK.SetTexture(DNAIEBIBHKC.BPHMJJFJHFL.HOOGKKEEHAC, texture2D);
	}

	// Token: 0x06011433 RID: 70707 RVA: 0x007B05F0 File Offset: 0x007AE7F0
	public void BIPMAJKBJGB(Material OOLNAJMJKIK)
	{
		ChromaticAberrationModel.Settings settings = base.BBEPCCALAFC.OMEONLBAJME();
		Texture2D texture2D = settings.spectralTexture;
		if (texture2D == null)
		{
			if (this.PAPHCMEMBCJ == null)
			{
				this.PAPHCMEMBCJ = new Texture2D(2, 1, TextureFormat.ARGB4444, true)
				{
					name = "_WaterLevel",
					filterMode = FilterMode.Point,
					wrapMode = TextureWrapMode.Clamp,
					anisoLevel = 1,
					hideFlags = (HideFlags)116
				};
				Color[] array = new Color[0];
				array[1] = new Color(1357f, 53f, 1199f);
				array[0] = new Color(1301f, 171f, 1602f);
				array[7] = new Color(1190f, 171f, 931f);
				this.PAPHCMEMBCJ.SetPixels(array);
				this.PAPHCMEMBCJ.Apply();
			}
			texture2D = this.PAPHCMEMBCJ;
		}
		OOLNAJMJKIK.EnableKeyword("inv_auklotinf");
		OOLNAJMJKIK.SetFloat(DNAIEBIBHKC.BPHMJJFJHFL.ANPONLMOGNJ, settings.intensity * 197f);
		OOLNAJMJKIK.SetTexture(DNAIEBIBHKC.BPHMJJFJHFL.HOOGKKEEHAC, texture2D);
	}

	// Token: 0x06011434 RID: 70708 RVA: 0x007AFFF4 File Offset: 0x007AE1F4
	public void NJBEKBHCLIO()
	{
		CDBICMCJFCE.MHJKBMIOGCD(this.PAPHCMEMBCJ);
		this.PAPHCMEMBCJ = null;
	}

	// Token: 0x06011435 RID: 70709 RVA: 0x007AFFF4 File Offset: 0x007AE1F4
	public void AHMFIGNLJOB()
	{
		CDBICMCJFCE.MHJKBMIOGCD(this.PAPHCMEMBCJ);
		this.PAPHCMEMBCJ = null;
	}

	// Token: 0x06011436 RID: 70710 RVA: 0x007B0708 File Offset: 0x007AE908
	public override void FBBBNHPGBKC(Material OOLNAJMJKIK)
	{
		ChromaticAberrationModel.Settings settings = base.BBEPCCALAFC.settings;
		Texture2D texture2D = settings.spectralTexture;
		if (texture2D == null)
		{
			if (this.PAPHCMEMBCJ == null)
			{
				this.PAPHCMEMBCJ = new Texture2D(3, 1, TextureFormat.RGB24, false)
				{
					name = "Chromatic Aberration Spectrum Lookup",
					filterMode = FilterMode.Bilinear,
					wrapMode = TextureWrapMode.Clamp,
					anisoLevel = 0,
					hideFlags = HideFlags.DontSave
				};
				Color[] pixels = new Color[]
				{
					new Color(1f, 0f, 0f),
					new Color(0f, 1f, 0f),
					new Color(0f, 0f, 1f)
				};
				this.PAPHCMEMBCJ.SetPixels(pixels);
				this.PAPHCMEMBCJ.Apply();
			}
			texture2D = this.PAPHCMEMBCJ;
		}
		OOLNAJMJKIK.EnableKeyword("CHROMATIC_ABERRATION");
		OOLNAJMJKIK.SetFloat(DNAIEBIBHKC.BPHMJJFJHFL.ANPONLMOGNJ, settings.intensity * 0.03f);
		OOLNAJMJKIK.SetTexture(DNAIEBIBHKC.BPHMJJFJHFL.HOOGKKEEHAC, texture2D);
	}

	// Token: 0x06011437 RID: 70711 RVA: 0x007AFFF4 File Offset: 0x007AE1F4
	public override void BKFHJFNCPAA()
	{
		CDBICMCJFCE.MHJKBMIOGCD(this.PAPHCMEMBCJ);
		this.PAPHCMEMBCJ = null;
	}

	// Token: 0x06011438 RID: 70712 RVA: 0x007AFFF4 File Offset: 0x007AE1F4
	public void LKGIJBLNANI()
	{
		CDBICMCJFCE.MHJKBMIOGCD(this.PAPHCMEMBCJ);
		this.PAPHCMEMBCJ = null;
	}

	// Token: 0x06011439 RID: 70713 RVA: 0x007B0820 File Offset: 0x007AEA20
	public void HLMCKNMCOKP(Material OOLNAJMJKIK)
	{
		ChromaticAberrationModel.Settings settings = base.BBEPCCALAFC.BIGGHOCNJNB();
		Texture2D texture2D = settings.spectralTexture;
		if (texture2D == null)
		{
			if (this.PAPHCMEMBCJ == null)
			{
				this.PAPHCMEMBCJ = new Texture2D(1, 0, TextureFormat.RGB24, false)
				{
					name = "_BlurDirectionPacked",
					filterMode = FilterMode.Point,
					wrapMode = TextureWrapMode.Repeat,
					anisoLevel = 0,
					hideFlags = (HideFlags)99
				};
				Color[] array = new Color[3];
				array[0] = new Color(606f, 661f, 1950f);
				array[1] = new Color(251f, 315f, 516f);
				array[6] = new Color(784f, 629f, 25f);
				this.PAPHCMEMBCJ.SetPixels(array);
				this.PAPHCMEMBCJ.Apply();
			}
			texture2D = this.PAPHCMEMBCJ;
		}
		OOLNAJMJKIK.EnableKeyword("nowpn");
		OOLNAJMJKIK.SetFloat(DNAIEBIBHKC.BPHMJJFJHFL.ANPONLMOGNJ, settings.intensity * 737f);
		OOLNAJMJKIK.SetTexture(DNAIEBIBHKC.BPHMJJFJHFL.HOOGKKEEHAC, texture2D);
	}

	// Token: 0x0601143A RID: 70714 RVA: 0x007AFFF4 File Offset: 0x007AE1F4
	public void LAFIABNCFPD()
	{
		CDBICMCJFCE.MHJKBMIOGCD(this.PAPHCMEMBCJ);
		this.PAPHCMEMBCJ = null;
	}

	// Token: 0x0601143B RID: 70715 RVA: 0x007AFFF4 File Offset: 0x007AE1F4
	public void PIPJPGGEFOL()
	{
		CDBICMCJFCE.MHJKBMIOGCD(this.PAPHCMEMBCJ);
		this.PAPHCMEMBCJ = null;
	}

	// Token: 0x0601143C RID: 70716 RVA: 0x007AFFF4 File Offset: 0x007AE1F4
	public void MLPCBOGCEEO()
	{
		CDBICMCJFCE.MHJKBMIOGCD(this.PAPHCMEMBCJ);
		this.PAPHCMEMBCJ = null;
	}

	// Token: 0x0601143D RID: 70717 RVA: 0x007B0938 File Offset: 0x007AEB38
	public bool BHDPHLBMCGG()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.NKJEFFLKMJA().intensity > 696f && !this.AMCOGJHPPOC.IPMGKDLKDHF();
	}

	// Token: 0x0601143E RID: 70718 RVA: 0x007B096E File Offset: 0x007AEB6E
	public bool DLBLAPHLCPF()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.FENHJBHKCAG().intensity > 919f && this.AMCOGJHPPOC.HKJHMGJGNHJ();
	}

	// Token: 0x0601143F RID: 70719 RVA: 0x007B09A4 File Offset: 0x007AEBA4
	public void HJKALJFJPMK(Material OOLNAJMJKIK)
	{
		ChromaticAberrationModel.Settings settings = base.BBEPCCALAFC.GOJNKFKPOKH();
		Texture2D texture2D = settings.spectralTexture;
		if (texture2D == null)
		{
			if (this.PAPHCMEMBCJ == null)
			{
				this.PAPHCMEMBCJ = new Texture2D(4, 1, TextureFormat.ARGB32, false)
				{
					name = "1HandHeavySwing",
					filterMode = FilterMode.Point,
					wrapMode = TextureWrapMode.Clamp,
					anisoLevel = 0,
					hideFlags = (HideFlags)100
				};
				Color[] array = new Color[0];
				array[1] = new Color(365f, 116f, 610f);
				array[1] = new Color(1484f, 1440f, 1801f);
				array[4] = new Color(1611f, 1102f, 266f);
				this.PAPHCMEMBCJ.SetPixels(array);
				this.PAPHCMEMBCJ.Apply();
			}
			texture2D = this.PAPHCMEMBCJ;
		}
		OOLNAJMJKIK.EnableKeyword("wpn_eat5");
		OOLNAJMJKIK.SetFloat(DNAIEBIBHKC.BPHMJJFJHFL.ANPONLMOGNJ, settings.intensity * 1164f);
		OOLNAJMJKIK.SetTexture(DNAIEBIBHKC.BPHMJJFJHFL.HOOGKKEEHAC, texture2D);
	}

	// Token: 0x06011440 RID: 70720 RVA: 0x007AFFF4 File Offset: 0x007AE1F4
	public void IABPIBODNNG()
	{
		CDBICMCJFCE.MHJKBMIOGCD(this.PAPHCMEMBCJ);
		this.PAPHCMEMBCJ = null;
	}

	// Token: 0x06011441 RID: 70721 RVA: 0x007B0ABC File Offset: 0x007AECBC
	public bool IOPILNONBKF()
	{
		return !base.BBEPCCALAFC.enabled || base.BBEPCCALAFC.LIKDNAJFKMN().intensity <= 1578f || this.AMCOGJHPPOC.ANFINECKHNH();
	}

	// Token: 0x06011442 RID: 70722 RVA: 0x007B0AF4 File Offset: 0x007AECF4
	public void IGFAFJCIEFM(Material OOLNAJMJKIK)
	{
		ChromaticAberrationModel.Settings settings = base.BBEPCCALAFC.JODGENBPIKL();
		Texture2D texture2D = settings.spectralTexture;
		if (texture2D == null)
		{
			if (this.PAPHCMEMBCJ == null)
			{
				this.PAPHCMEMBCJ = new Texture2D(3, 0, TextureFormat.RGB565, false)
				{
					name = "---------- DebugReturn ",
					filterMode = FilterMode.Point,
					wrapMode = TextureWrapMode.Clamp,
					anisoLevel = 1,
					hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset)
				};
				Color[] array = new Color[8];
				array[1] = new Color(1744f, 284f, 1531f);
				array[1] = new Color(877f, 351f, 1503f);
				array[0] = new Color(937f, 973f, 1110f);
				this.PAPHCMEMBCJ.SetPixels(array);
				this.PAPHCMEMBCJ.Apply();
			}
			texture2D = this.PAPHCMEMBCJ;
		}
		OOLNAJMJKIK.EnableKeyword("wpn_chair1");
		OOLNAJMJKIK.SetFloat(DNAIEBIBHKC.BPHMJJFJHFL.ANPONLMOGNJ, settings.intensity * 1164f);
		OOLNAJMJKIK.SetTexture(DNAIEBIBHKC.BPHMJJFJHFL.HOOGKKEEHAC, texture2D);
	}

	// Token: 0x04002412 RID: 9234
	private Texture2D PAPHCMEMBCJ;

	// Token: 0x02000515 RID: 1301
	private static class BPHMJJFJHFL
	{
		// Token: 0x04002413 RID: 9235
		internal static readonly int ANPONLMOGNJ = Shader.PropertyToID("_ChromaticAberration_Amount");

		// Token: 0x04002414 RID: 9236
		internal static readonly int HOOGKKEEHAC = Shader.PropertyToID("_ChromaticAberration_Spectrum");
	}
}
