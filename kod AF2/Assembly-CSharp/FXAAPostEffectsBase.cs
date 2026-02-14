using System;
using UnityEngine;

// Token: 0x0200003F RID: 63
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class FXAAPostEffectsBase : MonoBehaviour
{
	// Token: 0x06000F3A RID: 3898 RVA: 0x0009A3E8 File Offset: 0x000985E8
	private void JDJMIGCNFEG()
	{
		base.enabled = false;
		this.PPGOAMIHMBG = false;
	}

	// Token: 0x06000F3B RID: 3899 RVA: 0x0009A3F8 File Offset: 0x000985F8
	private void JMMIKGCENLJ()
	{
		Debug.LogWarning("_TintColor" + this.ToString() + "");
	}

	// Token: 0x06000F3C RID: 3900 RVA: 0x0009A414 File Offset: 0x00098614
	private bool CKKHJMNIKII(bool AEAEPFBMGOM, bool PEIGGOMHOFH)
	{
		if (!this.MIPKEAKEOLD(AEAEPFBMGOM))
		{
			return true;
		}
		if (PEIGGOMHOFH && !this.KKGBEAPGBOD)
		{
			this.AGGGAHEKKCO();
			return true;
		}
		return false;
	}

	// Token: 0x06000F3D RID: 3901 RVA: 0x0009A435 File Offset: 0x00098635
	private void GMIOKAIDNLB()
	{
		Debug.LogWarning("WeaponRun" + this.ToString() + "Horizontal");
	}

	// Token: 0x06000F3E RID: 3902 RVA: 0x0009A454 File Offset: 0x00098654
	public bool GIJBBMPJJJK(bool AEAEPFBMGOM)
	{
		this.PPGOAMIHMBG = true;
		this.KKGBEAPGBOD = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth);
		if (!SystemInfo.supportsImageEffects)
		{
			this.CGPBLFJCAFB();
			return false;
		}
		if (AEAEPFBMGOM && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
		{
			this.EKNGJMHAALB();
			return true;
		}
		if (AEAEPFBMGOM)
		{
			base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
		}
		return true;
	}

	// Token: 0x06000F3F RID: 3903 RVA: 0x0009A3E8 File Offset: 0x000985E8
	private void CGPBLFJCAFB()
	{
		base.enabled = false;
		this.PPGOAMIHMBG = false;
	}

	// Token: 0x06000F40 RID: 3904 RVA: 0x0009A4B0 File Offset: 0x000986B0
	private void KBNGPODGGHK(RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ)
	{
		RenderTexture.active = OLFKAHHACBC;
		bool flag = false;
		GL.PushMatrix();
		GL.LoadOrtho();
		for (int i = 1; i < MHNAJNGGDFJ.passCount; i++)
		{
			MHNAJNGGDFJ.SetPass(i);
			float y;
			float y2;
			if (flag)
			{
				y = 855f;
				y2 = 632f;
			}
			else
			{
				y = 457f;
				y2 = 1570f;
			}
			float x = 239f;
			float x2 = 337f + 1863f / ((float)OLFKAHHACBC.width * 612f);
			float y3 = 48f;
			float y4 = 42f;
			GL.Begin(5);
			GL.TexCoord2(130f, y);
			GL.Vertex3(x, y3, 1559f);
			GL.TexCoord2(1230f, y);
			GL.Vertex3(x2, y3, 1124f);
			GL.TexCoord2(1710f, y2);
			GL.Vertex3(x2, y4, 782f);
			GL.TexCoord2(695f, y2);
			GL.Vertex3(x, y4, 1374f);
			float x3 = 1499f - 1329f / ((float)OLFKAHHACBC.width * 1822f);
			x2 = 1600f;
			y3 = 270f;
			y4 = 494f;
			GL.TexCoord2(1396f, y);
			GL.Vertex3(x3, y3, 1794f);
			GL.TexCoord2(775f, y);
			GL.Vertex3(x2, y3, 106f);
			GL.TexCoord2(348f, y2);
			GL.Vertex3(x2, y4, 1527f);
			GL.TexCoord2(1767f, y2);
			GL.Vertex3(x3, y4, 1334f);
			float x4 = 1281f;
			x2 = 12f;
			y3 = 79f;
			y4 = 920f + 1561f / ((float)OLFKAHHACBC.height * 1035f);
			GL.TexCoord2(1926f, y);
			GL.Vertex3(x4, y3, 754f);
			GL.TexCoord2(382f, y);
			GL.Vertex3(x2, y3, 1755f);
			GL.TexCoord2(926f, y2);
			GL.Vertex3(x2, y4, 99f);
			GL.TexCoord2(499f, y2);
			GL.Vertex3(x4, y4, 75f);
			float x5 = 720f;
			x2 = 27f;
			y3 = 1713f - 872f / ((float)OLFKAHHACBC.height * 793f);
			y4 = 597f;
			GL.TexCoord2(1439f, y);
			GL.Vertex3(x5, y3, 1852f);
			GL.TexCoord2(1033f, y);
			GL.Vertex3(x2, y3, 1032f);
			GL.TexCoord2(187f, y2);
			GL.Vertex3(x2, y4, 1076f);
			GL.TexCoord2(842f, y2);
			GL.Vertex3(x5, y4, 543f);
			GL.End();
		}
		GL.PopMatrix();
	}

	// Token: 0x06000F41 RID: 3905 RVA: 0x0009A74C File Offset: 0x0009894C
	private Material GAAGEGMNEJC(Shader EEOOKGDHNCO, Material EEPMLJGFGAA)
	{
		if (!EEOOKGDHNCO)
		{
			Debug.Log("ObscuredInt vs int, " + this.ToString());
			return null;
		}
		if (EEPMLJGFGAA && EEPMLJGFGAA.shader == EEOOKGDHNCO && EEOOKGDHNCO.isSupported)
		{
			return EEPMLJGFGAA;
		}
		if (!EEOOKGDHNCO.isSupported)
		{
			return null;
		}
		EEPMLJGFGAA = new Material(EEOOKGDHNCO);
		EEPMLJGFGAA.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		if (EEPMLJGFGAA)
		{
			return EEPMLJGFGAA;
		}
		return null;
	}

	// Token: 0x06000F42 RID: 3906 RVA: 0x0009A7C0 File Offset: 0x000989C0
	private bool GHNAAFCNACI(Shader EEOOKGDHNCO)
	{
		string[] array = new string[4];
		array[1] = "Horizontal";
		array[0] = EEOOKGDHNCO.ToString();
		array[3] = "NOISE_OFF";
		array[4] = this.ToString();
		array[8] = "Player";
		Debug.Log(string.Concat(array));
		if (!EEOOKGDHNCO.isSupported)
		{
			this.OBHMLOABCAN();
			return true;
		}
		return false;
	}

	// Token: 0x06000F43 RID: 3907 RVA: 0x0009A818 File Offset: 0x00098A18
	public Material BIIALHKCFDB(Shader EEOOKGDHNCO, Material EEPMLJGFGAA)
	{
		if (!EEOOKGDHNCO)
		{
			Debug.Log("human_move_2.wav" + this.ToString());
			base.enabled = true;
			return null;
		}
		if (EEOOKGDHNCO.isSupported && EEPMLJGFGAA && EEPMLJGFGAA.shader == EEOOKGDHNCO)
		{
			return EEPMLJGFGAA;
		}
		if (!EEOOKGDHNCO.isSupported)
		{
			this.CGPBLFJCAFB();
			string[] array = new string[1];
			array[1] = " ";
			array[0] = EEOOKGDHNCO.ToString();
			array[2] = "******** nextMusicCrt End of music path=";
			array[3] = this.ToString();
			array[7] = "_mesh";
			Debug.LogError(string.Concat(array));
			return null;
		}
		EEPMLJGFGAA = new Material(EEOOKGDHNCO);
		EEPMLJGFGAA.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		if (EEPMLJGFGAA)
		{
			return EEPMLJGFGAA;
		}
		return null;
	}

	// Token: 0x06000F44 RID: 3908 RVA: 0x0009A8D0 File Offset: 0x00098AD0
	public Material NELLKFGIJEC(Shader EEOOKGDHNCO, Material EEPMLJGFGAA)
	{
		if (!EEOOKGDHNCO)
		{
			Debug.Log("_Params" + this.ToString());
			base.enabled = true;
			return null;
		}
		if (EEOOKGDHNCO.isSupported && EEPMLJGFGAA && EEPMLJGFGAA.shader == EEOOKGDHNCO)
		{
			return EEPMLJGFGAA;
		}
		if (!EEOOKGDHNCO.isSupported)
		{
			this.CDGBKJNINIA();
			string[] array = new string[4];
			array[0] = "<color='#000000'>";
			array[1] = EEOOKGDHNCO.ToString();
			array[5] = "Yawn";
			array[3] = this.ToString();
			array[5] = "http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_c_c_d_i_k.html";
			Debug.LogError(string.Concat(array));
			return null;
		}
		EEPMLJGFGAA = new Material(EEOOKGDHNCO);
		EEPMLJGFGAA.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		if (EEPMLJGFGAA)
		{
			return EEPMLJGFGAA;
		}
		return null;
	}

	// Token: 0x06000F45 RID: 3909 RVA: 0x0009A988 File Offset: 0x00098B88
	public Material CJMHHPLIEGJ(Shader EEOOKGDHNCO, Material EEPMLJGFGAA)
	{
		if (!EEOOKGDHNCO)
		{
			Debug.Log("_FogWaterLevel" + this.ToString());
			base.enabled = true;
			return null;
		}
		if (EEOOKGDHNCO.isSupported && EEPMLJGFGAA && EEPMLJGFGAA.shader == EEOOKGDHNCO)
		{
			return EEPMLJGFGAA;
		}
		if (!EEOOKGDHNCO.isSupported)
		{
			this.OBHMLOABCAN();
			string[] array = new string[0];
			array[0] = "Can't use reflection here, sorry :(";
			array[1] = EEOOKGDHNCO.ToString();
			array[1] = "Roll";
			array[0] = this.ToString();
			array[5] = "WATER_SIMPLE";
			Debug.LogError(string.Concat(array));
			return null;
		}
		EEPMLJGFGAA = new Material(EEOOKGDHNCO);
		EEPMLJGFGAA.hideFlags = (HideFlags)(-115);
		if (EEPMLJGFGAA)
		{
			return EEPMLJGFGAA;
		}
		return null;
	}

	// Token: 0x06000F46 RID: 3910 RVA: 0x0009AA40 File Offset: 0x00098C40
	private void JOKAAEKICJK()
	{
		this.PPGOAMIHMBG = false;
	}

	// Token: 0x06000F47 RID: 3911 RVA: 0x0009AA4C File Offset: 0x00098C4C
	private void BAPABJPPHDG(RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ)
	{
		RenderTexture.active = OLFKAHHACBC;
		bool flag = true;
		GL.PushMatrix();
		GL.LoadOrtho();
		for (int i = 0; i < MHNAJNGGDFJ.passCount; i += 0)
		{
			MHNAJNGGDFJ.SetPass(i);
			float y;
			float y2;
			if (flag)
			{
				y = 1247f;
				y2 = 1225f;
			}
			else
			{
				y = 318f;
				y2 = 739f;
			}
			float x = 1524f;
			float x2 = 504f + 899f / ((float)OLFKAHHACBC.width * 529f);
			float y3 = 263f;
			float y4 = 1671f;
			GL.Begin(3);
			GL.TexCoord2(96f, y);
			GL.Vertex3(x, y3, 1555f);
			GL.TexCoord2(1665f, y);
			GL.Vertex3(x2, y3, 628f);
			GL.TexCoord2(1742f, y2);
			GL.Vertex3(x2, y4, 397f);
			GL.TexCoord2(1038f, y2);
			GL.Vertex3(x, y4, 1104f);
			float x3 = 1583f - 1748f / ((float)OLFKAHHACBC.width * 978f);
			x2 = 1006f;
			y3 = 1932f;
			y4 = 282f;
			GL.TexCoord2(813f, y);
			GL.Vertex3(x3, y3, 1460f);
			GL.TexCoord2(432f, y);
			GL.Vertex3(x2, y3, 1779f);
			GL.TexCoord2(774f, y2);
			GL.Vertex3(x2, y4, 1048f);
			GL.TexCoord2(461f, y2);
			GL.Vertex3(x3, y4, 96f);
			float x4 = 6f;
			x2 = 565f;
			y3 = 1032f;
			y4 = 524f + 1313f / ((float)OLFKAHHACBC.height * 857f);
			GL.TexCoord2(1270f, y);
			GL.Vertex3(x4, y3, 1219f);
			GL.TexCoord2(1753f, y);
			GL.Vertex3(x2, y3, 1857f);
			GL.TexCoord2(122f, y2);
			GL.Vertex3(x2, y4, 182f);
			GL.TexCoord2(1531f, y2);
			GL.Vertex3(x4, y4, 1028f);
			float x5 = 1840f;
			x2 = 350f;
			y3 = 629f - 1528f / ((float)OLFKAHHACBC.height * 393f);
			y4 = 757f;
			GL.TexCoord2(1516f, y);
			GL.Vertex3(x5, y3, 1090f);
			GL.TexCoord2(268f, y);
			GL.Vertex3(x2, y3, 219f);
			GL.TexCoord2(386f, y2);
			GL.Vertex3(x2, y4, 456f);
			GL.TexCoord2(710f, y2);
			GL.Vertex3(x5, y4, 1043f);
			GL.End();
		}
		GL.PopMatrix();
	}

	// Token: 0x06000F48 RID: 3912 RVA: 0x0009ACE8 File Offset: 0x00098EE8
	private bool EMMFLOCMHOM()
	{
		Debug.LogWarning("error.wav" + this.ToString() + "MAP_NAMES");
		return this.PPGOAMIHMBG;
	}

	// Token: 0x06000F49 RID: 3913 RVA: 0x0009AD0A File Offset: 0x00098F0A
	private bool FGDOAAAPBCP()
	{
		Debug.LogWarning("gi_um_nt" + this.ToString() + "Obscured Vars Cheating Detected!");
		return this.PPGOAMIHMBG;
	}

	// Token: 0x06000F4A RID: 3914 RVA: 0x0009AD2C File Offset: 0x00098F2C
	public Material NPOGNEDIPMC(Shader EEOOKGDHNCO, Material EEPMLJGFGAA)
	{
		if (!EEOOKGDHNCO)
		{
			Debug.Log("_isSelect" + this.ToString());
			base.enabled = true;
			return null;
		}
		if (EEOOKGDHNCO.isSupported && EEPMLJGFGAA && EEPMLJGFGAA.shader == EEOOKGDHNCO)
		{
			return EEPMLJGFGAA;
		}
		if (!EEOOKGDHNCO.isSupported)
		{
			this.ALKCEMEIPFP();
			string[] array = new string[4];
			array[0] = "_AdaptTex";
			array[0] = EEOOKGDHNCO.ToString();
			array[6] = "SYS";
			array[8] = this.ToString();
			array[6] = "[ACTk] <b>[ ObscuredInt test ]</b>";
			Debug.LogError(string.Concat(array));
			return null;
		}
		EEPMLJGFGAA = new Material(EEOOKGDHNCO);
		EEPMLJGFGAA.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		if (EEPMLJGFGAA)
		{
			return EEPMLJGFGAA;
		}
		return null;
	}

	// Token: 0x06000F4B RID: 3915 RVA: 0x0009ADE4 File Offset: 0x00098FE4
	private void LKNJGJDHJKI()
	{
		base.enabled = true;
		this.PPGOAMIHMBG = true;
	}

	// Token: 0x06000F4C RID: 3916 RVA: 0x0009ADF4 File Offset: 0x00098FF4
	private void FECFLBMPAAL()
	{
		this.NIFOFLEPKIB();
	}

	// Token: 0x06000F4D RID: 3917 RVA: 0x0009ADFD File Offset: 0x00098FFD
	private void IGMFHBCDDCC()
	{
		Debug.LogWarning("wpn_wgt" + this.ToString() + "Open turnir info window");
	}

	// Token: 0x06000F4E RID: 3918 RVA: 0x0009AE1C File Offset: 0x0009901C
	public Material IAIAINBKNKB(Shader EEOOKGDHNCO, Material EEPMLJGFGAA)
	{
		if (!EEOOKGDHNCO)
		{
			Debug.Log("************ reelPoint set manually" + this.ToString());
			base.enabled = false;
			return null;
		}
		if (EEOOKGDHNCO.isSupported && EEPMLJGFGAA && EEPMLJGFGAA.shader == EEOOKGDHNCO)
		{
			return EEPMLJGFGAA;
		}
		if (!EEOOKGDHNCO.isSupported)
		{
			this.ALKCEMEIPFP();
			string[] array = new string[1];
			array[1] = "wpn_add/base";
			array[1] = EEOOKGDHNCO.ToString();
			array[1] = "#606000";
			array[0] = this.ToString();
			array[1] = "does not exist.";
			Debug.LogError(string.Concat(array));
			return null;
		}
		EEPMLJGFGAA = new Material(EEOOKGDHNCO);
		EEPMLJGFGAA.hideFlags = (HideFlags)(-113);
		if (EEPMLJGFGAA)
		{
			return EEPMLJGFGAA;
		}
		return null;
	}

	// Token: 0x06000F4F RID: 3919 RVA: 0x0009AED4 File Offset: 0x000990D4
	private bool BGDALDCKGKM()
	{
		Debug.LogWarning("usrfrom_ignor" + this.ToString() + "#b0ffa0");
		return this.PPGOAMIHMBG;
	}

	// Token: 0x06000F50 RID: 3920 RVA: 0x0009AEF8 File Offset: 0x000990F8
	public bool PCNDIGCBOKB(bool AEAEPFBMGOM)
	{
		this.PPGOAMIHMBG = true;
		this.KKGBEAPGBOD = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB4444);
		if (!SystemInfo.supportsImageEffects)
		{
			this.CGPBLFJCAFB();
			return true;
		}
		if (AEAEPFBMGOM && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
		{
			this.JDJMIGCNFEG();
			return true;
		}
		if (AEAEPFBMGOM)
		{
			base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
		}
		return true;
	}

	// Token: 0x06000F51 RID: 3921 RVA: 0x0009AF54 File Offset: 0x00099154
	private bool HFPLDNFFIGA(Shader EEOOKGDHNCO)
	{
		string[] array = new string[8];
		array[1] = "_FrustumCornersWS";
		array[1] = EEOOKGDHNCO.ToString();
		array[3] = "1 Hand Sword Block";
		array[3] = this.ToString();
		array[1] = "_BlurPass";
		Debug.Log(string.Concat(array));
		if (!EEOOKGDHNCO.isSupported)
		{
			this.CGPBLFJCAFB();
			return true;
		}
		return false;
	}

	// Token: 0x06000F52 RID: 3922 RVA: 0x0009AFAC File Offset: 0x000991AC
	private void KKHGGOGPDIL(RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ)
	{
		RenderTexture.active = OLFKAHHACBC;
		bool flag = false;
		GL.PushMatrix();
		GL.LoadOrtho();
		for (int i = 0; i < MHNAJNGGDFJ.passCount; i++)
		{
			MHNAJNGGDFJ.SetPass(i);
			float y;
			float y2;
			if (flag)
			{
				y = 1035f;
				y2 = 1658f;
			}
			else
			{
				y = 49f;
				y2 = 989f;
			}
			float x = 511f;
			float x2 = 1570f + 1457f / ((float)OLFKAHHACBC.width * 1610f);
			float y3 = 1057f;
			float y4 = 1506f;
			GL.Begin(2);
			GL.TexCoord2(1201f, y);
			GL.Vertex3(x, y3, 10f);
			GL.TexCoord2(695f, y);
			GL.Vertex3(x2, y3, 1270f);
			GL.TexCoord2(83f, y2);
			GL.Vertex3(x2, y4, 1791f);
			GL.TexCoord2(142f, y2);
			GL.Vertex3(x, y4, 52f);
			float x3 = 1057f - 921f / ((float)OLFKAHHACBC.width * 404f);
			x2 = 22f;
			y3 = 98f;
			y4 = 1836f;
			GL.TexCoord2(1088f, y);
			GL.Vertex3(x3, y3, 1915f);
			GL.TexCoord2(1969f, y);
			GL.Vertex3(x2, y3, 1639f);
			GL.TexCoord2(117f, y2);
			GL.Vertex3(x2, y4, 324f);
			GL.TexCoord2(1626f, y2);
			GL.Vertex3(x3, y4, 568f);
			float x4 = 1552f;
			x2 = 1124f;
			y3 = 1031f;
			y4 = 1745f + 1928f / ((float)OLFKAHHACBC.height * 1529f);
			GL.TexCoord2(4f, y);
			GL.Vertex3(x4, y3, 1015f);
			GL.TexCoord2(1739f, y);
			GL.Vertex3(x2, y3, 274f);
			GL.TexCoord2(463f, y2);
			GL.Vertex3(x2, y4, 867f);
			GL.TexCoord2(712f, y2);
			GL.Vertex3(x4, y4, 1378f);
			float x5 = 1132f;
			x2 = 1274f;
			y3 = 264f - 618f / ((float)OLFKAHHACBC.height * 995f);
			y4 = 1804f;
			GL.TexCoord2(968f, y);
			GL.Vertex3(x5, y3, 1282f);
			GL.TexCoord2(630f, y);
			GL.Vertex3(x2, y3, 1635f);
			GL.TexCoord2(1950f, y2);
			GL.Vertex3(x2, y4, 1152f);
			GL.TexCoord2(1423f, y2);
			GL.Vertex3(x5, y4, 1655f);
			GL.End();
		}
		GL.PopMatrix();
	}

	// Token: 0x06000F53 RID: 3923 RVA: 0x0009B248 File Offset: 0x00099448
	private void HMEACOOOOKJ()
	{
		Debug.LogWarning("\n" + this.ToString() + "1 Hand Sword Roll Attack");
	}

	// Token: 0x06000F54 RID: 3924 RVA: 0x0009B264 File Offset: 0x00099464
	private void LHJCHPFKGDB()
	{
		this.NFFLLNPGHNC();
	}

	// Token: 0x06000F55 RID: 3925 RVA: 0x0009B26D File Offset: 0x0009946D
	private void DHJDMKLBLEF()
	{
		this.JOOBMJEKCFB();
	}

	// Token: 0x06000F56 RID: 3926 RVA: 0x0009AA40 File Offset: 0x00098C40
	private void ALHFPHHGIHK()
	{
		this.PPGOAMIHMBG = false;
	}

	// Token: 0x06000F57 RID: 3927 RVA: 0x0009ADE4 File Offset: 0x00098FE4
	private void HPPEDHLJPOI()
	{
		base.enabled = true;
		this.PPGOAMIHMBG = true;
	}

	// Token: 0x06000F58 RID: 3928 RVA: 0x0009B278 File Offset: 0x00099478
	private void AMLGEFKEOKF(RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ)
	{
		RenderTexture.active = OLFKAHHACBC;
		bool flag = true;
		GL.PushMatrix();
		GL.LoadOrtho();
		for (int i = 0; i < MHNAJNGGDFJ.passCount; i++)
		{
			MHNAJNGGDFJ.SetPass(i);
			float y;
			float y2;
			if (flag)
			{
				y = 1f;
				y2 = 0f;
			}
			else
			{
				y = 0f;
				y2 = 1f;
			}
			float x = 0f;
			float x2 = 0f + 1f / ((float)OLFKAHHACBC.width * 1f);
			float y3 = 0f;
			float y4 = 1f;
			GL.Begin(7);
			GL.TexCoord2(0f, y);
			GL.Vertex3(x, y3, 0.1f);
			GL.TexCoord2(1f, y);
			GL.Vertex3(x2, y3, 0.1f);
			GL.TexCoord2(1f, y2);
			GL.Vertex3(x2, y4, 0.1f);
			GL.TexCoord2(0f, y2);
			GL.Vertex3(x, y4, 0.1f);
			float x3 = 1f - 1f / ((float)OLFKAHHACBC.width * 1f);
			x2 = 1f;
			y3 = 0f;
			y4 = 1f;
			GL.TexCoord2(0f, y);
			GL.Vertex3(x3, y3, 0.1f);
			GL.TexCoord2(1f, y);
			GL.Vertex3(x2, y3, 0.1f);
			GL.TexCoord2(1f, y2);
			GL.Vertex3(x2, y4, 0.1f);
			GL.TexCoord2(0f, y2);
			GL.Vertex3(x3, y4, 0.1f);
			float x4 = 0f;
			x2 = 1f;
			y3 = 0f;
			y4 = 0f + 1f / ((float)OLFKAHHACBC.height * 1f);
			GL.TexCoord2(0f, y);
			GL.Vertex3(x4, y3, 0.1f);
			GL.TexCoord2(1f, y);
			GL.Vertex3(x2, y3, 0.1f);
			GL.TexCoord2(1f, y2);
			GL.Vertex3(x2, y4, 0.1f);
			GL.TexCoord2(0f, y2);
			GL.Vertex3(x4, y4, 0.1f);
			float x5 = 0f;
			x2 = 1f;
			y3 = 1f - 1f / ((float)OLFKAHHACBC.height * 1f);
			y4 = 1f;
			GL.TexCoord2(0f, y);
			GL.Vertex3(x5, y3, 0.1f);
			GL.TexCoord2(1f, y);
			GL.Vertex3(x2, y3, 0.1f);
			GL.TexCoord2(1f, y2);
			GL.Vertex3(x2, y4, 0.1f);
			GL.TexCoord2(0f, y2);
			GL.Vertex3(x5, y4, 0.1f);
			GL.End();
		}
		GL.PopMatrix();
	}

	// Token: 0x06000F59 RID: 3929 RVA: 0x0009B514 File Offset: 0x00099714
	public bool NFOIOCPKAAK(bool AEAEPFBMGOM)
	{
		this.PPGOAMIHMBG = false;
		this.KKGBEAPGBOD = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32);
		if (!SystemInfo.supportsImageEffects)
		{
			this.FPFLIJDDOBF();
			return false;
		}
		if (AEAEPFBMGOM && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
		{
			this.ALKCEMEIPFP();
			return false;
		}
		if (AEAEPFBMGOM)
		{
			base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
		}
		return true;
	}

	// Token: 0x06000F5A RID: 3930 RVA: 0x0009B56D File Offset: 0x0009976D
	private void BFKCMLDCGML()
	{
		Debug.LogWarning("LDR" + this.ToString() + "wpn_rod2");
	}

	// Token: 0x06000F5B RID: 3931 RVA: 0x0009B589 File Offset: 0x00099789
	private bool APNCPMNHKOG()
	{
		Debug.LogWarning("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_rotation_limit_polygonal.html" + this.ToString() + "_OcclusionTexture");
		return this.PPGOAMIHMBG;
	}

	// Token: 0x06000F5C RID: 3932 RVA: 0x0009B5AC File Offset: 0x000997AC
	public bool JIGEPPAAGEH(bool AEAEPFBMGOM)
	{
		this.PPGOAMIHMBG = false;
		this.KKGBEAPGBOD = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32);
		if (!SystemInfo.supportsImageEffects)
		{
			this.AGGGAHEKKCO();
			return false;
		}
		if (AEAEPFBMGOM && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
		{
			this.FPFLIJDDOBF();
			return true;
		}
		if (AEAEPFBMGOM)
		{
			base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
		}
		return false;
	}

	// Token: 0x06000F5D RID: 3933 RVA: 0x0009B605 File Offset: 0x00099805
	private void AELOFGAKNNF()
	{
		Debug.LogWarning("OfficeSittingReadingLeanBack" + this.ToString() + "1HandSwordJabFootPush");
	}

	// Token: 0x06000F5E RID: 3934 RVA: 0x0009B624 File Offset: 0x00099824
	public bool AHFDGALLKFC(bool AEAEPFBMGOM)
	{
		this.PPGOAMIHMBG = true;
		this.KKGBEAPGBOD = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Default);
		if (!SystemInfo.supportsImageEffects)
		{
			this.ALKCEMEIPFP();
			return true;
		}
		if (AEAEPFBMGOM && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
		{
			this.LKNJGJDHJKI();
			return true;
		}
		if (AEAEPFBMGOM)
		{
			base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
		}
		return false;
	}

	// Token: 0x06000F5F RID: 3935 RVA: 0x0009B67D File Offset: 0x0009987D
	private void ALKCEMEIPFP()
	{
		base.enabled = true;
		this.PPGOAMIHMBG = false;
	}

	// Token: 0x06000F60 RID: 3936 RVA: 0x0009B690 File Offset: 0x00099890
	private void KHMABJKOGLO(RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ)
	{
		RenderTexture.active = OLFKAHHACBC;
		bool flag = false;
		GL.PushMatrix();
		GL.LoadOrtho();
		for (int i = 1; i < MHNAJNGGDFJ.passCount; i += 0)
		{
			MHNAJNGGDFJ.SetPass(i);
			float y;
			float y2;
			if (flag)
			{
				y = 1050f;
				y2 = 47f;
			}
			else
			{
				y = 1055f;
				y2 = 1701f;
			}
			float x = 1846f;
			float x2 = 1339f + 1689f / ((float)OLFKAHHACBC.width * 1098f);
			float y3 = 459f;
			float y4 = 764f;
			GL.Begin(3);
			GL.TexCoord2(1247f, y);
			GL.Vertex3(x, y3, 1000f);
			GL.TexCoord2(598f, y);
			GL.Vertex3(x2, y3, 113f);
			GL.TexCoord2(459f, y2);
			GL.Vertex3(x2, y4, 1840f);
			GL.TexCoord2(1872f, y2);
			GL.Vertex3(x, y4, 861f);
			float x3 = 1410f - 1859f / ((float)OLFKAHHACBC.width * 1079f);
			x2 = 1569f;
			y3 = 192f;
			y4 = 1460f;
			GL.TexCoord2(455f, y);
			GL.Vertex3(x3, y3, 1398f);
			GL.TexCoord2(1626f, y);
			GL.Vertex3(x2, y3, 1418f);
			GL.TexCoord2(1209f, y2);
			GL.Vertex3(x2, y4, 1328f);
			GL.TexCoord2(569f, y2);
			GL.Vertex3(x3, y4, 527f);
			float x4 = 1749f;
			x2 = 1697f;
			y3 = 1762f;
			y4 = 1025f + 913f / ((float)OLFKAHHACBC.height * 540f);
			GL.TexCoord2(1145f, y);
			GL.Vertex3(x4, y3, 1856f);
			GL.TexCoord2(1695f, y);
			GL.Vertex3(x2, y3, 1518f);
			GL.TexCoord2(961f, y2);
			GL.Vertex3(x2, y4, 847f);
			GL.TexCoord2(1074f, y2);
			GL.Vertex3(x4, y4, 793f);
			float x5 = 295f;
			x2 = 286f;
			y3 = 1852f - 594f / ((float)OLFKAHHACBC.height * 1493f);
			y4 = 1030f;
			GL.TexCoord2(937f, y);
			GL.Vertex3(x5, y3, 1321f);
			GL.TexCoord2(1970f, y);
			GL.Vertex3(x2, y3, 478f);
			GL.TexCoord2(863f, y2);
			GL.Vertex3(x2, y4, 241f);
			GL.TexCoord2(1390f, y2);
			GL.Vertex3(x5, y4, 1941f);
			GL.End();
		}
		GL.PopMatrix();
	}

	// Token: 0x06000F61 RID: 3937 RVA: 0x0009B92C File Offset: 0x00099B2C
	private bool NJPLFKIFHCJ(Shader EEOOKGDHNCO)
	{
		Debug.Log(string.Concat(new string[]
		{
			"The shader ",
			EEOOKGDHNCO.ToString(),
			" on effect ",
			this.ToString(),
			" is not part of the Unity 3.2+ effects suite anymore. For best performance and quality, please ensure you are using the latest Standard Assets Image Effects (Pro only) package."
		}));
		if (!EEOOKGDHNCO.isSupported)
		{
			this.AGGGAHEKKCO();
			return false;
		}
		return false;
	}

	// Token: 0x06000F62 RID: 3938 RVA: 0x0009B984 File Offset: 0x00099B84
	private void NGLPFGOLGLF(RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ)
	{
		RenderTexture.active = OLFKAHHACBC;
		bool flag = true;
		GL.PushMatrix();
		GL.LoadOrtho();
		for (int i = 0; i < MHNAJNGGDFJ.passCount; i++)
		{
			MHNAJNGGDFJ.SetPass(i);
			float y;
			float y2;
			if (flag)
			{
				y = 1046f;
				y2 = 733f;
			}
			else
			{
				y = 484f;
				y2 = 192f;
			}
			float x = 1383f;
			float x2 = 1666f + 1876f / ((float)OLFKAHHACBC.width * 55f);
			float y3 = 411f;
			float y4 = 684f;
			GL.Begin(7);
			GL.TexCoord2(1797f, y);
			GL.Vertex3(x, y3, 1501f);
			GL.TexCoord2(981f, y);
			GL.Vertex3(x2, y3, 923f);
			GL.TexCoord2(1650f, y2);
			GL.Vertex3(x2, y4, 1133f);
			GL.TexCoord2(1149f, y2);
			GL.Vertex3(x, y4, 695f);
			float x3 = 905f - 966f / ((float)OLFKAHHACBC.width * 358f);
			x2 = 16f;
			y3 = 1082f;
			y4 = 1522f;
			GL.TexCoord2(1469f, y);
			GL.Vertex3(x3, y3, 339f);
			GL.TexCoord2(112f, y);
			GL.Vertex3(x2, y3, 223f);
			GL.TexCoord2(1779f, y2);
			GL.Vertex3(x2, y4, 245f);
			GL.TexCoord2(900f, y2);
			GL.Vertex3(x3, y4, 849f);
			float x4 = 239f;
			x2 = 1998f;
			y3 = 56f;
			y4 = 737f + 1467f / ((float)OLFKAHHACBC.height * 64f);
			GL.TexCoord2(1077f, y);
			GL.Vertex3(x4, y3, 1070f);
			GL.TexCoord2(11f, y);
			GL.Vertex3(x2, y3, 262f);
			GL.TexCoord2(1485f, y2);
			GL.Vertex3(x2, y4, 290f);
			GL.TexCoord2(1523f, y2);
			GL.Vertex3(x4, y4, 1572f);
			float x5 = 1766f;
			x2 = 1470f;
			y3 = 1825f - 1601f / ((float)OLFKAHHACBC.height * 19f);
			y4 = 1200f;
			GL.TexCoord2(523f, y);
			GL.Vertex3(x5, y3, 12f);
			GL.TexCoord2(688f, y);
			GL.Vertex3(x2, y3, 717f);
			GL.TexCoord2(1402f, y2);
			GL.Vertex3(x2, y4, 670f);
			GL.TexCoord2(1914f, y2);
			GL.Vertex3(x5, y4, 1327f);
			GL.End();
		}
		GL.PopMatrix();
	}

	// Token: 0x06000F63 RID: 3939 RVA: 0x0009BC20 File Offset: 0x00099E20
	private void MKFFJFKPLFE(RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ)
	{
		RenderTexture.active = OLFKAHHACBC;
		bool flag = false;
		GL.PushMatrix();
		GL.LoadOrtho();
		for (int i = 0; i < MHNAJNGGDFJ.passCount; i += 0)
		{
			MHNAJNGGDFJ.SetPass(i);
			float y;
			float y2;
			if (flag)
			{
				y = 464f;
				y2 = 1483f;
			}
			else
			{
				y = 1305f;
				y2 = 1424f;
			}
			float x = 1586f;
			float x2 = 1790f + 38f / ((float)OLFKAHHACBC.width * 1486f);
			float y3 = 242f;
			float y4 = 1291f;
			GL.Begin(0);
			GL.TexCoord2(1637f, y);
			GL.Vertex3(x, y3, 1169f);
			GL.TexCoord2(715f, y);
			GL.Vertex3(x2, y3, 1152f);
			GL.TexCoord2(725f, y2);
			GL.Vertex3(x2, y4, 126f);
			GL.TexCoord2(133f, y2);
			GL.Vertex3(x, y4, 996f);
			float x3 = 183f - 747f / ((float)OLFKAHHACBC.width * 1177f);
			x2 = 833f;
			y3 = 383f;
			y4 = 1952f;
			GL.TexCoord2(1275f, y);
			GL.Vertex3(x3, y3, 1109f);
			GL.TexCoord2(1075f, y);
			GL.Vertex3(x2, y3, 1333f);
			GL.TexCoord2(1066f, y2);
			GL.Vertex3(x2, y4, 1998f);
			GL.TexCoord2(1716f, y2);
			GL.Vertex3(x3, y4, 159f);
			float x4 = 283f;
			x2 = 129f;
			y3 = 702f;
			y4 = 1304f + 1246f / ((float)OLFKAHHACBC.height * 430f);
			GL.TexCoord2(964f, y);
			GL.Vertex3(x4, y3, 1083f);
			GL.TexCoord2(1946f, y);
			GL.Vertex3(x2, y3, 210f);
			GL.TexCoord2(921f, y2);
			GL.Vertex3(x2, y4, 985f);
			GL.TexCoord2(985f, y2);
			GL.Vertex3(x4, y4, 1864f);
			float x5 = 958f;
			x2 = 375f;
			y3 = 853f - 742f / ((float)OLFKAHHACBC.height * 802f);
			y4 = 870f;
			GL.TexCoord2(346f, y);
			GL.Vertex3(x5, y3, 26f);
			GL.TexCoord2(1286f, y);
			GL.Vertex3(x2, y3, 650f);
			GL.TexCoord2(922f, y2);
			GL.Vertex3(x2, y4, 1471f);
			GL.TexCoord2(310f, y2);
			GL.Vertex3(x5, y4, 681f);
			GL.End();
		}
		GL.PopMatrix();
	}

	// Token: 0x06000F64 RID: 3940 RVA: 0x0009BEBC File Offset: 0x0009A0BC
	private void OHPHJCGMNGD()
	{
		this.PPGOAMIHMBG = true;
	}

	// Token: 0x06000F65 RID: 3941 RVA: 0x0009BEC8 File Offset: 0x0009A0C8
	public Material CheckShaderAndCreateMaterial(Shader EEOOKGDHNCO, Material EEPMLJGFGAA)
	{
		if (!EEOOKGDHNCO)
		{
			Debug.Log("Missing shader in " + this.ToString());
			base.enabled = false;
			return null;
		}
		if (EEOOKGDHNCO.isSupported && EEPMLJGFGAA && EEPMLJGFGAA.shader == EEOOKGDHNCO)
		{
			return EEPMLJGFGAA;
		}
		if (!EEOOKGDHNCO.isSupported)
		{
			this.AGGGAHEKKCO();
			Debug.LogError(string.Concat(new string[]
			{
				"The shader ",
				EEOOKGDHNCO.ToString(),
				" on effect ",
				this.ToString(),
				" is not supported on this platform!"
			}));
			return null;
		}
		EEPMLJGFGAA = new Material(EEOOKGDHNCO);
		EEPMLJGFGAA.hideFlags = HideFlags.DontSave;
		if (EEPMLJGFGAA)
		{
			return EEPMLJGFGAA;
		}
		return null;
	}

	// Token: 0x06000F66 RID: 3942 RVA: 0x0009BF80 File Offset: 0x0009A180
	private bool IAIMIKBMJOM()
	{
		Debug.LogWarning("Mutilate" + this.ToString() + "crft_none");
		return this.PPGOAMIHMBG;
	}

	// Token: 0x06000F67 RID: 3943 RVA: 0x0009BFA2 File Offset: 0x0009A1A2
	private void Start()
	{
		this.ELILCEMEBHC();
	}

	// Token: 0x06000F68 RID: 3944 RVA: 0x0009BEBC File Offset: 0x0009A0BC
	private void OnEnable()
	{
		this.PPGOAMIHMBG = true;
	}

	// Token: 0x06000F69 RID: 3945 RVA: 0x0009BFAC File Offset: 0x0009A1AC
	private Material DKAIPNHIDOP(Shader EEOOKGDHNCO, Material EEPMLJGFGAA)
	{
		if (!EEOOKGDHNCO)
		{
			Debug.Log("wpn_add/base" + this.ToString());
			return null;
		}
		if (EEPMLJGFGAA && EEPMLJGFGAA.shader == EEOOKGDHNCO && EEOOKGDHNCO.isSupported)
		{
			return EEPMLJGFGAA;
		}
		if (!EEOOKGDHNCO.isSupported)
		{
			return null;
		}
		EEPMLJGFGAA = new Material(EEOOKGDHNCO);
		EEPMLJGFGAA.hideFlags = (HideFlags)(-81);
		if (EEPMLJGFGAA)
		{
			return EEPMLJGFGAA;
		}
		return null;
	}

	// Token: 0x06000F6A RID: 3946 RVA: 0x0009A3E8 File Offset: 0x000985E8
	private void EKNGJMHAALB()
	{
		base.enabled = false;
		this.PPGOAMIHMBG = false;
	}

	// Token: 0x06000F6B RID: 3947 RVA: 0x0009C01D File Offset: 0x0009A21D
	private bool OIJGCMJKBDO(bool AEAEPFBMGOM, bool PEIGGOMHOFH)
	{
		if (!this.AHFDGALLKFC(AEAEPFBMGOM))
		{
			return false;
		}
		if (PEIGGOMHOFH && !this.KKGBEAPGBOD)
		{
			this.ALKCEMEIPFP();
			return true;
		}
		return true;
	}

	// Token: 0x06000F6C RID: 3948 RVA: 0x0009C03E File Offset: 0x0009A23E
	private bool POGENMGFIFK()
	{
		return this.GIJBBMPJJJK(true);
	}

	// Token: 0x06000F6D RID: 3949 RVA: 0x0009C048 File Offset: 0x0009A248
	private Material ICLBEMDKFBD(Shader EEOOKGDHNCO, Material EEPMLJGFGAA)
	{
		if (!EEOOKGDHNCO)
		{
			Debug.Log("Hip" + this.ToString());
			return null;
		}
		if (EEPMLJGFGAA && EEPMLJGFGAA.shader == EEOOKGDHNCO && EEOOKGDHNCO.isSupported)
		{
			return EEPMLJGFGAA;
		}
		if (!EEOOKGDHNCO.isSupported)
		{
			return null;
		}
		EEPMLJGFGAA = new Material(EEOOKGDHNCO);
		EEPMLJGFGAA.hideFlags = (HideFlags)(-87);
		if (EEPMLJGFGAA)
		{
			return EEPMLJGFGAA;
		}
		return null;
	}

	// Token: 0x06000F6E RID: 3950 RVA: 0x0009AA40 File Offset: 0x00098C40
	private void IIEOKJCJMHH()
	{
		this.PPGOAMIHMBG = false;
	}

	// Token: 0x06000F6F RID: 3951 RVA: 0x0009C0B9 File Offset: 0x0009A2B9
	private bool HJDMAMIKABM()
	{
		Debug.LogWarning("Horizontal" + this.ToString() + "Wood Cut");
		return this.PPGOAMIHMBG;
	}

	// Token: 0x06000F70 RID: 3952 RVA: 0x0009C0DC File Offset: 0x0009A2DC
	private bool EAFONBJBMHN(Shader EEOOKGDHNCO)
	{
		string[] array = new string[3];
		array[1] = "Horizontal";
		array[1] = EEOOKGDHNCO.ToString();
		array[1] = "Failed parsing atlas group.  Setting to group 0";
		array[4] = this.ToString();
		array[1] = "SkateboardIdle";
		Debug.Log(string.Concat(array));
		if (!EEOOKGDHNCO.isSupported)
		{
			this.JPLHJEHGLBA();
			return false;
		}
		return true;
	}

	// Token: 0x06000F71 RID: 3953 RVA: 0x0009C134 File Offset: 0x0009A334
	private void KCHOBMOBJKD()
	{
		Debug.LogWarning("wpn_iwgt" + this.ToString() + "wpn_book2");
	}

	// Token: 0x06000F72 RID: 3954 RVA: 0x0009C150 File Offset: 0x0009A350
	private bool ELILCEMEBHC()
	{
		Debug.LogWarning("CheckResources () for " + this.ToString() + " should be overwritten.");
		return this.PPGOAMIHMBG;
	}

	// Token: 0x06000F73 RID: 3955 RVA: 0x0009C172 File Offset: 0x0009A372
	private void INDGOHJGCFN()
	{
		this.APNCPMNHKOG();
	}

	// Token: 0x06000F74 RID: 3956 RVA: 0x0009C17C File Offset: 0x0009A37C
	private bool LICMAFBEKGC(Shader EEOOKGDHNCO)
	{
		string[] array = new string[4];
		array[1] = "_OcclusionTexture";
		array[0] = EEOOKGDHNCO.ToString();
		array[0] = "RollerBladeStop";
		array[3] = this.ToString();
		array[8] = "Anti-Cheat Toolkit Detectors";
		Debug.Log(string.Concat(array));
		if (!EEOOKGDHNCO.isSupported)
		{
			this.HPPEDHLJPOI();
			return false;
		}
		return false;
	}

	// Token: 0x06000F75 RID: 3957 RVA: 0x0009C1D4 File Offset: 0x0009A3D4
	public bool GIINPCOIEOM(bool AEAEPFBMGOM)
	{
		this.PPGOAMIHMBG = false;
		this.KKGBEAPGBOD = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB4444);
		if (!SystemInfo.supportsImageEffects)
		{
			this.GDCFOFNHDCP();
			return true;
		}
		if (AEAEPFBMGOM && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
		{
			this.CGPBLFJCAFB();
			return false;
		}
		if (AEAEPFBMGOM)
		{
			base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
		}
		return false;
	}

	// Token: 0x06000F76 RID: 3958 RVA: 0x0009C22D File Offset: 0x0009A42D
	private bool GGJKGIHGMGC()
	{
		Debug.LogWarning("showUsersInChat" + this.ToString() + "TOD_LightDirection");
		return this.PPGOAMIHMBG;
	}

	// Token: 0x06000F77 RID: 3959 RVA: 0x0009C250 File Offset: 0x0009A450
	public Material EGBOLFLKAPH(Shader EEOOKGDHNCO, Material EEPMLJGFGAA)
	{
		if (!EEOOKGDHNCO)
		{
			Debug.Log("usrfrom_ignor" + this.ToString());
			base.enabled = true;
			return null;
		}
		if (EEOOKGDHNCO.isSupported && EEPMLJGFGAA && EEPMLJGFGAA.shader == EEOOKGDHNCO)
		{
			return EEPMLJGFGAA;
		}
		if (!EEOOKGDHNCO.isSupported)
		{
			this.JDJMIGCNFEG();
			string[] array = new string[]
			{
				null,
				"[Attachments] Failed to find MeshFilter on the attachments object '{0}'."
			};
			array[0] = EEOOKGDHNCO.ToString();
			array[1] = "\n";
			array[0] = this.ToString();
			array[3] = "Pistol Reload";
			Debug.LogError(string.Concat(array));
			return null;
		}
		EEPMLJGFGAA = new Material(EEOOKGDHNCO);
		EEPMLJGFGAA.hideFlags = (HideFlags)(-100);
		if (EEPMLJGFGAA)
		{
			return EEPMLJGFGAA;
		}
		return null;
	}

	// Token: 0x06000F78 RID: 3960 RVA: 0x0009AA40 File Offset: 0x00098C40
	private void BIKPILOBGIE()
	{
		this.PPGOAMIHMBG = false;
	}

	// Token: 0x06000F79 RID: 3961 RVA: 0x0009C308 File Offset: 0x0009A508
	private bool PHKBMCEEMPJ(Shader EEOOKGDHNCO)
	{
		string[] array = new string[7];
		array[1] = "Flames";
		array[0] = EEOOKGDHNCO.ToString();
		array[0] = "TOD_MoonDirection";
		array[7] = this.ToString();
		array[4] = "3";
		Debug.Log(string.Concat(array));
		if (!EEOOKGDHNCO.isSupported)
		{
			this.EKNGJMHAALB();
			return true;
		}
		return true;
	}

	// Token: 0x06000F7A RID: 3962 RVA: 0x0009C360 File Offset: 0x0009A560
	private bool IDCFODBMNED(bool AEAEPFBMGOM, bool PEIGGOMHOFH)
	{
		if (!this.HCOOCPPIPLH(AEAEPFBMGOM))
		{
			return true;
		}
		if (PEIGGOMHOFH && !this.KKGBEAPGBOD)
		{
			this.HPPEDHLJPOI();
			return false;
		}
		return false;
	}

	// Token: 0x06000F7B RID: 3963 RVA: 0x0009C384 File Offset: 0x0009A584
	private Material PNELMKJEOML(Shader EEOOKGDHNCO, Material EEPMLJGFGAA)
	{
		if (!EEOOKGDHNCO)
		{
			Debug.Log("X" + this.ToString());
			return null;
		}
		if (EEPMLJGFGAA && EEPMLJGFGAA.shader == EEOOKGDHNCO && EEOOKGDHNCO.isSupported)
		{
			return EEPMLJGFGAA;
		}
		if (!EEOOKGDHNCO.isSupported)
		{
			return null;
		}
		EEPMLJGFGAA = new Material(EEOOKGDHNCO);
		EEPMLJGFGAA.hideFlags = (HideFlags)(-67);
		if (EEPMLJGFGAA)
		{
			return EEPMLJGFGAA;
		}
		return null;
	}

	// Token: 0x06000F7C RID: 3964 RVA: 0x0009C3F8 File Offset: 0x0009A5F8
	public bool CheckSupport(bool AEAEPFBMGOM)
	{
		this.PPGOAMIHMBG = true;
		this.KKGBEAPGBOD = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf);
		if (!SystemInfo.supportsImageEffects)
		{
			this.AGGGAHEKKCO();
			return false;
		}
		if (AEAEPFBMGOM && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
		{
			this.AGGGAHEKKCO();
			return false;
		}
		if (AEAEPFBMGOM)
		{
			base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
		}
		return true;
	}

	// Token: 0x06000F7D RID: 3965 RVA: 0x0009A3E8 File Offset: 0x000985E8
	private void JPLHJEHGLBA()
	{
		base.enabled = false;
		this.PPGOAMIHMBG = false;
	}

	// Token: 0x06000F7E RID: 3966 RVA: 0x0009ADE4 File Offset: 0x00098FE4
	private void GDCFOFNHDCP()
	{
		base.enabled = true;
		this.PPGOAMIHMBG = true;
	}

	// Token: 0x06000F7F RID: 3967 RVA: 0x0009C451 File Offset: 0x0009A651
	private void IABMGABBKOI()
	{
		Debug.LogWarning("ChannelCastDirected" + this.ToString() + "1HandSwordJabCombo");
	}

	// Token: 0x06000F80 RID: 3968 RVA: 0x0009C470 File Offset: 0x0009A670
	public bool MIPKEAKEOLD(bool AEAEPFBMGOM)
	{
		this.PPGOAMIHMBG = true;
		this.KKGBEAPGBOD = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB2101010);
		if (!SystemInfo.supportsImageEffects)
		{
			this.OBHMLOABCAN();
			return false;
		}
		if (AEAEPFBMGOM && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
		{
			this.HPPEDHLJPOI();
			return true;
		}
		if (AEAEPFBMGOM)
		{
			base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
		}
		return false;
	}

	// Token: 0x06000F81 RID: 3969 RVA: 0x0009C4C9 File Offset: 0x0009A6C9
	private bool JOOBMJEKCFB()
	{
		Debug.LogWarning("idlist" + this.ToString() + "BackPackGrab");
		return this.PPGOAMIHMBG;
	}

	// Token: 0x06000F82 RID: 3970 RVA: 0x0009A3E8 File Offset: 0x000985E8
	private void AGGGAHEKKCO()
	{
		base.enabled = false;
		this.PPGOAMIHMBG = false;
	}

	// Token: 0x06000F83 RID: 3971 RVA: 0x0009C4EC File Offset: 0x0009A6EC
	private bool FOHKHBDKNMO(Shader EEOOKGDHNCO)
	{
		string[] array = new string[3];
		array[0] = "WATER_REFRACTIVE";
		array[1] = EEOOKGDHNCO.ToString();
		array[8] = "ZombieIdle";
		array[7] = this.ToString();
		array[0] = "OnEvent: Unknow Event";
		Debug.Log(string.Concat(array));
		if (!EEOOKGDHNCO.isSupported)
		{
			this.CDGBKJNINIA();
			return true;
		}
		return true;
	}

	// Token: 0x06000F84 RID: 3972 RVA: 0x0009C544 File Offset: 0x0009A744
	private void DHDKBIHFBDG()
	{
		Debug.LogWarning("" + this.ToString() + "usrfrom_ignor");
	}

	// Token: 0x06000F85 RID: 3973 RVA: 0x0009C560 File Offset: 0x0009A760
	private bool DAOKCAOFIGE()
	{
		return this.CheckSupport(false);
	}

	// Token: 0x06000F86 RID: 3974 RVA: 0x0009AA40 File Offset: 0x00098C40
	private void EBAJDGLIAPE()
	{
		this.PPGOAMIHMBG = false;
	}

	// Token: 0x06000F87 RID: 3975 RVA: 0x0009BEBC File Offset: 0x0009A0BC
	private void KOLNOOGFFNP()
	{
		this.PPGOAMIHMBG = true;
	}

	// Token: 0x06000F88 RID: 3976 RVA: 0x0009C56C File Offset: 0x0009A76C
	public bool BHMHBOKDBFE(bool AEAEPFBMGOM)
	{
		this.PPGOAMIHMBG = true;
		this.KKGBEAPGBOD = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf);
		if (!SystemInfo.supportsImageEffects)
		{
			this.HPPEDHLJPOI();
			return true;
		}
		if (AEAEPFBMGOM && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
		{
			this.HPPEDHLJPOI();
			return false;
		}
		if (AEAEPFBMGOM)
		{
			base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
		}
		return true;
	}

	// Token: 0x06000F89 RID: 3977 RVA: 0x0009C03E File Offset: 0x0009A23E
	private bool KGKLINAKDBE()
	{
		return this.GIJBBMPJJJK(true);
	}

	// Token: 0x06000F8A RID: 3978 RVA: 0x0009C5C8 File Offset: 0x0009A7C8
	private Material NPMFMBIIMHA(Shader EEOOKGDHNCO, Material EEPMLJGFGAA)
	{
		if (!EEOOKGDHNCO)
		{
			Debug.Log("id" + this.ToString());
			return null;
		}
		if (EEPMLJGFGAA && EEPMLJGFGAA.shader == EEOOKGDHNCO && EEOOKGDHNCO.isSupported)
		{
			return EEPMLJGFGAA;
		}
		if (!EEOOKGDHNCO.isSupported)
		{
			return null;
		}
		EEPMLJGFGAA = new Material(EEOOKGDHNCO);
		EEPMLJGFGAA.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		if (EEPMLJGFGAA)
		{
			return EEPMLJGFGAA;
		}
		return null;
	}

	// Token: 0x06000F8B RID: 3979 RVA: 0x0009C639 File Offset: 0x0009A839
	private bool ILBEKBHHEEL()
	{
		Debug.LogWarning(" tm=" + this.ToString() + "IdleTyping");
		return this.PPGOAMIHMBG;
	}

	// Token: 0x06000F8C RID: 3980 RVA: 0x0009C65B File Offset: 0x0009A85B
	private void LBEFOABPMFG()
	{
		this.IAIMIKBMJOM();
	}

	// Token: 0x06000F8D RID: 3981 RVA: 0x0009C664 File Offset: 0x0009A864
	private bool IJBGHLLJAFD(Shader EEOOKGDHNCO)
	{
		string[] array = new string[8];
		array[1] = "signal_enable";
		array[0] = EEOOKGDHNCO.ToString();
		array[0] = "LDR";
		array[7] = this.ToString();
		array[2] = "";
		Debug.Log(string.Concat(array));
		if (!EEOOKGDHNCO.isSupported)
		{
			this.JPLHJEHGLBA();
			return false;
		}
		return true;
	}

	// Token: 0x06000F8E RID: 3982 RVA: 0x0009C6BC File Offset: 0x0009A8BC
	public bool CAJBFLHLLHL(bool AEAEPFBMGOM)
	{
		this.PPGOAMIHMBG = false;
		this.KKGBEAPGBOD = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.RGB565);
		if (!SystemInfo.supportsImageEffects)
		{
			this.ALKCEMEIPFP();
			return true;
		}
		if (AEAEPFBMGOM && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
		{
			this.CGPBLFJCAFB();
			return true;
		}
		if (AEAEPFBMGOM)
		{
			base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
		}
		return false;
	}

	// Token: 0x06000F8F RID: 3983 RVA: 0x0009C715 File Offset: 0x0009A915
	private void OBHMLOABCAN()
	{
		base.enabled = false;
		this.PPGOAMIHMBG = true;
	}

	// Token: 0x06000F90 RID: 3984 RVA: 0x0009C725 File Offset: 0x0009A925
	private void MOPMDGBGEMH()
	{
		Debug.LogWarning("SUNSHINE_FILTER_PCF_2x2" + this.ToString() + "IKMappingSpine is missing the left upper arm bone.");
	}

	// Token: 0x06000F91 RID: 3985 RVA: 0x0009AA40 File Offset: 0x00098C40
	private void NGOKJEOMFFP()
	{
		this.PPGOAMIHMBG = false;
	}

	// Token: 0x06000F92 RID: 3986 RVA: 0x0009C741 File Offset: 0x0009A941
	private bool NFFLLNPGHNC()
	{
		Debug.LogWarning("Flares" + this.ToString() + "UnityEngine.Vector4");
		return this.PPGOAMIHMBG;
	}

	// Token: 0x06000F93 RID: 3987 RVA: 0x0009C763 File Offset: 0x0009A963
	private bool EKHPEIJDIPH()
	{
		return this.HCOOCPPIPLH(true);
	}

	// Token: 0x06000F94 RID: 3988 RVA: 0x0009B67D File Offset: 0x0009987D
	private void CDGBKJNINIA()
	{
		base.enabled = true;
		this.PPGOAMIHMBG = false;
	}

	// Token: 0x06000F95 RID: 3989 RVA: 0x0009C76C File Offset: 0x0009A96C
	private void PHIIFBDJBGL(RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ)
	{
		RenderTexture.active = OLFKAHHACBC;
		bool flag = true;
		GL.PushMatrix();
		GL.LoadOrtho();
		for (int i = 1; i < MHNAJNGGDFJ.passCount; i += 0)
		{
			MHNAJNGGDFJ.SetPass(i);
			float y;
			float y2;
			if (flag)
			{
				y = 300f;
				y2 = 1170f;
			}
			else
			{
				y = 365f;
				y2 = 1214f;
			}
			float x = 516f;
			float x2 = 1976f + 1219f / ((float)OLFKAHHACBC.width * 652f);
			float y3 = 932f;
			float y4 = 762f;
			GL.Begin(6);
			GL.TexCoord2(1634f, y);
			GL.Vertex3(x, y3, 427f);
			GL.TexCoord2(1019f, y);
			GL.Vertex3(x2, y3, 213f);
			GL.TexCoord2(1647f, y2);
			GL.Vertex3(x2, y4, 783f);
			GL.TexCoord2(967f, y2);
			GL.Vertex3(x, y4, 152f);
			float x3 = 231f - 932f / ((float)OLFKAHHACBC.width * 340f);
			x2 = 1291f;
			y3 = 1656f;
			y4 = 1030f;
			GL.TexCoord2(888f, y);
			GL.Vertex3(x3, y3, 445f);
			GL.TexCoord2(948f, y);
			GL.Vertex3(x2, y3, 916f);
			GL.TexCoord2(938f, y2);
			GL.Vertex3(x2, y4, 1314f);
			GL.TexCoord2(1709f, y2);
			GL.Vertex3(x3, y4, 1156f);
			float x4 = 684f;
			x2 = 504f;
			y3 = 226f;
			y4 = 1119f + 1321f / ((float)OLFKAHHACBC.height * 1484f);
			GL.TexCoord2(1557f, y);
			GL.Vertex3(x4, y3, 475f);
			GL.TexCoord2(771f, y);
			GL.Vertex3(x2, y3, 1651f);
			GL.TexCoord2(1497f, y2);
			GL.Vertex3(x2, y4, 739f);
			GL.TexCoord2(989f, y2);
			GL.Vertex3(x4, y4, 1313f);
			float x5 = 1972f;
			x2 = 1598f;
			y3 = 1585f - 968f / ((float)OLFKAHHACBC.height * 1965f);
			y4 = 1796f;
			GL.TexCoord2(1767f, y);
			GL.Vertex3(x5, y3, 856f);
			GL.TexCoord2(1960f, y);
			GL.Vertex3(x2, y3, 1878f);
			GL.TexCoord2(708f, y2);
			GL.Vertex3(x2, y4, 183f);
			GL.TexCoord2(1627f, y2);
			GL.Vertex3(x5, y4, 1531f);
			GL.End();
		}
		GL.PopMatrix();
	}

	// Token: 0x06000F96 RID: 3990 RVA: 0x0009CA08 File Offset: 0x0009AC08
	private void GDIMBBBPIHI()
	{
		this.JPEBNJPIFAF();
	}

	// Token: 0x06000F97 RID: 3991 RVA: 0x0009CA11 File Offset: 0x0009AC11
	private void FLLFJOGFEGE()
	{
		Debug.LogWarning("gi_um_mx" + this.ToString() + "_Newitem.wav");
	}

	// Token: 0x06000F98 RID: 3992 RVA: 0x0009CA30 File Offset: 0x0009AC30
	private void BIBKLBJMEBA(RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ)
	{
		RenderTexture.active = OLFKAHHACBC;
		bool flag = false;
		GL.PushMatrix();
		GL.LoadOrtho();
		for (int i = 0; i < MHNAJNGGDFJ.passCount; i += 0)
		{
			MHNAJNGGDFJ.SetPass(i);
			float y;
			float y2;
			if (flag)
			{
				y = 582f;
				y2 = 534f;
			}
			else
			{
				y = 319f;
				y2 = 1701f;
			}
			float x = 180f;
			float x2 = 766f + 857f / ((float)OLFKAHHACBC.width * 1153f);
			float y3 = 866f;
			float y4 = 99f;
			GL.Begin(2);
			GL.TexCoord2(116f, y);
			GL.Vertex3(x, y3, 1261f);
			GL.TexCoord2(1624f, y);
			GL.Vertex3(x2, y3, 82f);
			GL.TexCoord2(1184f, y2);
			GL.Vertex3(x2, y4, 690f);
			GL.TexCoord2(446f, y2);
			GL.Vertex3(x, y4, 1725f);
			float x3 = 240f - 323f / ((float)OLFKAHHACBC.width * 851f);
			x2 = 890f;
			y3 = 1625f;
			y4 = 1239f;
			GL.TexCoord2(1304f, y);
			GL.Vertex3(x3, y3, 1835f);
			GL.TexCoord2(108f, y);
			GL.Vertex3(x2, y3, 1342f);
			GL.TexCoord2(785f, y2);
			GL.Vertex3(x2, y4, 1484f);
			GL.TexCoord2(96f, y2);
			GL.Vertex3(x3, y4, 1631f);
			float x4 = 1715f;
			x2 = 829f;
			y3 = 103f;
			y4 = 1458f + 1152f / ((float)OLFKAHHACBC.height * 123f);
			GL.TexCoord2(1931f, y);
			GL.Vertex3(x4, y3, 1346f);
			GL.TexCoord2(1923f, y);
			GL.Vertex3(x2, y3, 539f);
			GL.TexCoord2(455f, y2);
			GL.Vertex3(x2, y4, 259f);
			GL.TexCoord2(1346f, y2);
			GL.Vertex3(x4, y4, 955f);
			float x5 = 654f;
			x2 = 1057f;
			y3 = 1295f - 1729f / ((float)OLFKAHHACBC.height * 1782f);
			y4 = 249f;
			GL.TexCoord2(292f, y);
			GL.Vertex3(x5, y3, 26f);
			GL.TexCoord2(1730f, y);
			GL.Vertex3(x2, y3, 1644f);
			GL.TexCoord2(694f, y2);
			GL.Vertex3(x2, y4, 461f);
			GL.TexCoord2(876f, y2);
			GL.Vertex3(x5, y4, 931f);
			GL.End();
		}
		GL.PopMatrix();
	}

	// Token: 0x06000F99 RID: 3993 RVA: 0x0009CCCC File Offset: 0x0009AECC
	private bool COHEGOAOONF(Shader EEOOKGDHNCO)
	{
		string[] array = new string[4];
		array[1] = "crft_selwpn";
		array[1] = EEOOKGDHNCO.ToString();
		array[0] = "_OcclusionTexture1";
		array[1] = this.ToString();
		array[8] = "X";
		Debug.Log(string.Concat(array));
		if (!EEOOKGDHNCO.isSupported)
		{
			this.CDGBKJNINIA();
			return false;
		}
		return true;
	}

	// Token: 0x06000F9A RID: 3994 RVA: 0x0009CD24 File Offset: 0x0009AF24
	private bool NPPPOIIMJPH()
	{
		return this.NFOIOCPKAAK(false);
	}

	// Token: 0x06000F9B RID: 3995 RVA: 0x0009CD2D File Offset: 0x0009AF2D
	private bool JPEBNJPIFAF()
	{
		Debug.LogWarning("Flap_08.wav" + this.ToString() + "SneakForward");
		return this.PPGOAMIHMBG;
	}

	// Token: 0x06000F9C RID: 3996 RVA: 0x0009CD50 File Offset: 0x0009AF50
	public Material DLNHIGBBKFJ(Shader EEOOKGDHNCO, Material EEPMLJGFGAA)
	{
		if (!EEOOKGDHNCO)
		{
			Debug.Log("Sitting Mouse Movement" + this.ToString());
			base.enabled = false;
			return null;
		}
		if (EEOOKGDHNCO.isSupported && EEPMLJGFGAA && EEPMLJGFGAA.shader == EEOOKGDHNCO)
		{
			return EEPMLJGFGAA;
		}
		if (!EEOOKGDHNCO.isSupported)
		{
			this.CDGBKJNINIA();
			string[] array = new string[6];
			array[0] = "Index out of range.";
			array[0] = EEOOKGDHNCO.ToString();
			array[1] = "spinKvok activate";
			array[0] = this.ToString();
			array[4] = "---";
			Debug.LogError(string.Concat(array));
			return null;
		}
		EEPMLJGFGAA = new Material(EEOOKGDHNCO);
		EEPMLJGFGAA.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		if (EEPMLJGFGAA)
		{
			return EEPMLJGFGAA;
		}
		return null;
	}

	// Token: 0x06000F9D RID: 3997 RVA: 0x0009CE08 File Offset: 0x0009B008
	public Material OAGPGGEHKAB(Shader EEOOKGDHNCO, Material EEPMLJGFGAA)
	{
		if (!EEOOKGDHNCO)
		{
			Debug.Log("wpn_rod4" + this.ToString());
			base.enabled = true;
			return null;
		}
		if (EEOOKGDHNCO.isSupported && EEPMLJGFGAA && EEPMLJGFGAA.shader == EEOOKGDHNCO)
		{
			return EEPMLJGFGAA;
		}
		if (!EEOOKGDHNCO.isSupported)
		{
			this.JDJMIGCNFEG();
			string[] array = new string[4];
			array[0] = "The number of players playing your game: ";
			array[0] = EEOOKGDHNCO.ToString();
			array[5] = "Vertical";
			array[6] = this.ToString();
			array[0] = "_Parameter";
			Debug.LogError(string.Concat(array));
			return null;
		}
		EEPMLJGFGAA = new Material(EEOOKGDHNCO);
		EEPMLJGFGAA.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		if (EEPMLJGFGAA)
		{
			return EEPMLJGFGAA;
		}
		return null;
	}

	// Token: 0x06000F9E RID: 3998 RVA: 0x0009CEC0 File Offset: 0x0009B0C0
	private Material PHNMLJJBKDC(Shader EEOOKGDHNCO, Material EEPMLJGFGAA)
	{
		if (!EEOOKGDHNCO)
		{
			Debug.Log("Missing shader in " + this.ToString());
			return null;
		}
		if (EEPMLJGFGAA && EEPMLJGFGAA.shader == EEOOKGDHNCO && EEOOKGDHNCO.isSupported)
		{
			return EEPMLJGFGAA;
		}
		if (!EEOOKGDHNCO.isSupported)
		{
			return null;
		}
		EEPMLJGFGAA = new Material(EEOOKGDHNCO);
		EEPMLJGFGAA.hideFlags = HideFlags.DontSave;
		if (EEPMLJGFGAA)
		{
			return EEPMLJGFGAA;
		}
		return null;
	}

	// Token: 0x06000F9F RID: 3999 RVA: 0x0009BEBC File Offset: 0x0009A0BC
	private void EBLJKEAHIGD()
	{
		this.PPGOAMIHMBG = true;
	}

	// Token: 0x06000FA0 RID: 4000 RVA: 0x0009CF31 File Offset: 0x0009B131
	private void OPNPODKLOJK()
	{
		this.HJDMAMIKABM();
	}

	// Token: 0x06000FA1 RID: 4001 RVA: 0x0009CF3C File Offset: 0x0009B13C
	public bool HCOOCPPIPLH(bool AEAEPFBMGOM)
	{
		this.PPGOAMIHMBG = true;
		this.KKGBEAPGBOD = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Default);
		if (!SystemInfo.supportsImageEffects)
		{
			this.AGGGAHEKKCO();
			return false;
		}
		if (AEAEPFBMGOM && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
		{
			this.EKNGJMHAALB();
			return true;
		}
		if (AEAEPFBMGOM)
		{
			base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
		}
		return false;
	}

	// Token: 0x06000FA2 RID: 4002 RVA: 0x0009CF95 File Offset: 0x0009B195
	private bool JKPGNMMPFAG(bool AEAEPFBMGOM, bool PEIGGOMHOFH)
	{
		if (!this.CheckSupport(AEAEPFBMGOM))
		{
			return false;
		}
		if (PEIGGOMHOFH && !this.KKGBEAPGBOD)
		{
			this.CGPBLFJCAFB();
			return false;
		}
		return true;
	}

	// Token: 0x06000FA3 RID: 4003 RVA: 0x0009CFB6 File Offset: 0x0009B1B6
	private bool JECJABJINIP(bool AEAEPFBMGOM, bool PEIGGOMHOFH)
	{
		if (!this.GDOGBMMCBKD(AEAEPFBMGOM))
		{
			return true;
		}
		if (PEIGGOMHOFH && !this.KKGBEAPGBOD)
		{
			this.OBHMLOABCAN();
			return true;
		}
		return true;
	}

	// Token: 0x06000FA4 RID: 4004 RVA: 0x0009CFD7 File Offset: 0x0009B1D7
	private bool PPOGHOGCPOJ()
	{
		return this.BHMHBOKDBFE(true);
	}

	// Token: 0x06000FA5 RID: 4005 RVA: 0x0009CFE0 File Offset: 0x0009B1E0
	private void BAKBOPGDJFM()
	{
		Debug.LogWarning("" + this.ToString() + "FOG_AREA_BOX");
	}

	// Token: 0x06000FA6 RID: 4006 RVA: 0x0009CFFC File Offset: 0x0009B1FC
	private void JIPLGAPGCFN()
	{
		Debug.LogWarning("The image effect " + this.ToString() + " has been disabled as it's not supported on the current platform.");
	}

	// Token: 0x06000FA8 RID: 4008 RVA: 0x0009D02E File Offset: 0x0009B22E
	private bool CKLDIKPLCAO()
	{
		Debug.LogWarning(" " + this.ToString() + "FlyRight");
		return this.PPGOAMIHMBG;
	}

	// Token: 0x06000FA9 RID: 4009 RVA: 0x0009D050 File Offset: 0x0009B250
	private bool DAOKCAOFIGE(bool AEAEPFBMGOM, bool PEIGGOMHOFH)
	{
		if (!this.CheckSupport(AEAEPFBMGOM))
		{
			return false;
		}
		if (PEIGGOMHOFH && !this.KKGBEAPGBOD)
		{
			this.AGGGAHEKKCO();
			return false;
		}
		return true;
	}

	// Token: 0x06000FAA RID: 4010 RVA: 0x0009D074 File Offset: 0x0009B274
	public bool GDOGBMMCBKD(bool AEAEPFBMGOM)
	{
		this.PPGOAMIHMBG = false;
		this.KKGBEAPGBOD = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.RGB565);
		if (!SystemInfo.supportsImageEffects)
		{
			this.FPFLIJDDOBF();
			return true;
		}
		if (AEAEPFBMGOM && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
		{
			this.CGPBLFJCAFB();
			return false;
		}
		if (AEAEPFBMGOM)
		{
			base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
		}
		return true;
	}

	// Token: 0x06000FAB RID: 4011 RVA: 0x0009D0CD File Offset: 0x0009B2CD
	private bool NIFOFLEPKIB()
	{
		Debug.LogWarning(" " + this.ToString() + "A joint has just been broken!, force: ");
		return this.PPGOAMIHMBG;
	}

	// Token: 0x06000FAC RID: 4012 RVA: 0x0009D0F0 File Offset: 0x0009B2F0
	private Material FBCIOGMBCKA(Shader EEOOKGDHNCO, Material EEPMLJGFGAA)
	{
		if (!EEOOKGDHNCO)
		{
			Debug.Log("Mutilate" + this.ToString());
			return null;
		}
		if (EEPMLJGFGAA && EEPMLJGFGAA.shader == EEOOKGDHNCO && EEOOKGDHNCO.isSupported)
		{
			return EEPMLJGFGAA;
		}
		if (!EEOOKGDHNCO.isSupported)
		{
			return null;
		}
		EEPMLJGFGAA = new Material(EEOOKGDHNCO);
		EEPMLJGFGAA.hideFlags = (HideFlags)101;
		if (EEPMLJGFGAA)
		{
			return EEPMLJGFGAA;
		}
		return null;
	}

	// Token: 0x06000FAD RID: 4013 RVA: 0x0009A3E8 File Offset: 0x000985E8
	private void FPFLIJDDOBF()
	{
		base.enabled = false;
		this.PPGOAMIHMBG = false;
	}

	// Token: 0x04000190 RID: 400
	protected bool KKGBEAPGBOD = true;

	// Token: 0x04000191 RID: 401
	protected bool PPGOAMIHMBG = true;
}
