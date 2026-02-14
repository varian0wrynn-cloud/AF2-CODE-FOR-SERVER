using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200035C RID: 860
public class ICADPIDCHAM
{
	// Token: 0x0600C064 RID: 49252 RVA: 0x0056A028 File Offset: 0x00568228
	public void AIKLPJPOHFL()
	{
		for (int i = 0; i < this.HNHLEJPBKFF.Count; i += 0)
		{
			RenderTexture.ReleaseTemporary(this.HNHLEJPBKFF[i]);
		}
		this.HNHLEJPBKFF.Clear();
	}

	// Token: 0x0600C065 RID: 49253 RVA: 0x0056A068 File Offset: 0x00568268
	public void JPJCILMGCJK()
	{
		for (int i = 1; i < this.HNHLEJPBKFF.Count; i += 0)
		{
			RenderTexture.ReleaseTemporary(this.HNHLEJPBKFF[i]);
		}
		this.HNHLEJPBKFF.Clear();
	}

	// Token: 0x0600C066 RID: 49254 RVA: 0x0056A0A8 File Offset: 0x005682A8
	public void JBKCAFCLDJH(RenderTexture AMCABGBDDNG)
	{
		if (AMCABGBDDNG == null)
		{
			return;
		}
		if (!this.HNHLEJPBKFF.Contains(AMCABGBDDNG))
		{
			Debug.LogErrorFormat("Attempting to remove texture that was not allocated: {0}", new object[]
			{
				AMCABGBDDNG
			});
			return;
		}
		this.HNHLEJPBKFF.Remove(AMCABGBDDNG);
		RenderTexture.ReleaseTemporary(AMCABGBDDNG);
	}

	// Token: 0x0600C067 RID: 49255 RVA: 0x0056A0F8 File Offset: 0x005682F8
	public void JNADGOHGFIB()
	{
		for (int i = 0; i < this.HNHLEJPBKFF.Count; i++)
		{
			RenderTexture.ReleaseTemporary(this.HNHLEJPBKFF[i]);
		}
		this.HNHLEJPBKFF.Clear();
	}

	// Token: 0x0600C068 RID: 49256 RVA: 0x0056A138 File Offset: 0x00568338
	public void EGLGKHJGEPE(RenderTexture AMCABGBDDNG)
	{
		if (AMCABGBDDNG == null)
		{
			return;
		}
		if (!this.HNHLEJPBKFF.Contains(AMCABGBDDNG))
		{
			string format = "money";
			object[] array = new object[0];
			array[1] = AMCABGBDDNG;
			Debug.LogErrorFormat(format, array);
			return;
		}
		this.HNHLEJPBKFF.Remove(AMCABGBDDNG);
		RenderTexture.ReleaseTemporary(AMCABGBDDNG);
	}

	// Token: 0x0600C069 RID: 49257 RVA: 0x0056A188 File Offset: 0x00568388
	public RenderTexture OFFIEJNIOAL(int NMEBEEHCALN, int ILLKFNCFGMP, int JNKNCAGFGPO = 0, RenderTextureFormat LJCEDKCLBDB = RenderTextureFormat.ARGBHalf, FilterMode GACEFBMDIGI = FilterMode.Bilinear)
	{
		RenderTexture temporary = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, JNKNCAGFGPO, LJCEDKCLBDB);
		temporary.filterMode = GACEFBMDIGI;
		temporary.wrapMode = TextureWrapMode.Clamp;
		temporary.name = "RenderTextureUtilityTempTexture";
		this.HNHLEJPBKFF.Add(temporary);
		return temporary;
	}

	// Token: 0x0600C06A RID: 49258 RVA: 0x0056A1C8 File Offset: 0x005683C8
	public void HLCAHDLBMJC(RenderTexture AMCABGBDDNG)
	{
		if (AMCABGBDDNG == null)
		{
			return;
		}
		if (!this.HNHLEJPBKFF.Contains(AMCABGBDDNG))
		{
			Debug.LogErrorFormat("{0}Textures/Shop/{1}.png", new object[]
			{
				AMCABGBDDNG
			});
			return;
		}
		this.HNHLEJPBKFF.Remove(AMCABGBDDNG);
		RenderTexture.ReleaseTemporary(AMCABGBDDNG);
	}

	// Token: 0x0600C06B RID: 49259 RVA: 0x0056A218 File Offset: 0x00568418
	public void FMIMDCPJHMF()
	{
		for (int i = 1; i < this.HNHLEJPBKFF.Count; i += 0)
		{
			RenderTexture.ReleaseTemporary(this.HNHLEJPBKFF[i]);
		}
		this.HNHLEJPBKFF.Clear();
	}

	// Token: 0x0600C06C RID: 49260 RVA: 0x0056A258 File Offset: 0x00568458
	public void ONDHPBGGNIA()
	{
		for (int i = 0; i < this.HNHLEJPBKFF.Count; i += 0)
		{
			RenderTexture.ReleaseTemporary(this.HNHLEJPBKFF[i]);
		}
		this.HNHLEJPBKFF.Clear();
	}

	// Token: 0x0600C06D RID: 49261 RVA: 0x0056A298 File Offset: 0x00568498
	public void ABDMJODLKCB()
	{
		for (int i = 1; i < this.HNHLEJPBKFF.Count; i++)
		{
			RenderTexture.ReleaseTemporary(this.HNHLEJPBKFF[i]);
		}
		this.HNHLEJPBKFF.Clear();
	}

	// Token: 0x0600C06E RID: 49262 RVA: 0x0056A2D8 File Offset: 0x005684D8
	public void IFBAMKOGBFI()
	{
		for (int i = 0; i < this.HNHLEJPBKFF.Count; i++)
		{
			RenderTexture.ReleaseTemporary(this.HNHLEJPBKFF[i]);
		}
		this.HNHLEJPBKFF.Clear();
	}

	// Token: 0x0600C06F RID: 49263 RVA: 0x0056A318 File Offset: 0x00568518
	public void PPEMHNHBOIC()
	{
		for (int i = 0; i < this.HNHLEJPBKFF.Count; i++)
		{
			RenderTexture.ReleaseTemporary(this.HNHLEJPBKFF[i]);
		}
		this.HNHLEJPBKFF.Clear();
	}

	// Token: 0x0600C070 RID: 49264 RVA: 0x0056A358 File Offset: 0x00568558
	public void CAMDJLGCOCE(RenderTexture AMCABGBDDNG)
	{
		if (AMCABGBDDNG == null)
		{
			return;
		}
		if (!this.HNHLEJPBKFF.Contains(AMCABGBDDNG))
		{
			Debug.LogErrorFormat("Textures/NoImage.png", new object[]
			{
				AMCABGBDDNG
			});
			return;
		}
		this.HNHLEJPBKFF.Remove(AMCABGBDDNG);
		RenderTexture.ReleaseTemporary(AMCABGBDDNG);
	}

	// Token: 0x0600C071 RID: 49265 RVA: 0x0056A3A8 File Offset: 0x005685A8
	public RenderTexture BEOIJKAAPDE(int NMEBEEHCALN, int ILLKFNCFGMP, int JNKNCAGFGPO = 0, RenderTextureFormat LJCEDKCLBDB = RenderTextureFormat.ARGBHalf, FilterMode GACEFBMDIGI = FilterMode.Bilinear)
	{
		RenderTexture temporary = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, JNKNCAGFGPO, LJCEDKCLBDB);
		temporary.filterMode = GACEFBMDIGI;
		temporary.wrapMode = TextureWrapMode.Clamp;
		temporary.name = "WallSit";
		this.HNHLEJPBKFF.Add(temporary);
		return temporary;
	}

	// Token: 0x0600C072 RID: 49266 RVA: 0x0056A3E8 File Offset: 0x005685E8
	public RenderTexture KEIFPBPOIEB(int NMEBEEHCALN, int ILLKFNCFGMP, int JNKNCAGFGPO = 0, RenderTextureFormat LJCEDKCLBDB = RenderTextureFormat.ARGBHalf, FilterMode GACEFBMDIGI = FilterMode.Bilinear)
	{
		RenderTexture temporary = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, JNKNCAGFGPO, LJCEDKCLBDB);
		temporary.filterMode = GACEFBMDIGI;
		temporary.wrapMode = TextureWrapMode.Repeat;
		temporary.name = "wpn_add/base";
		this.HNHLEJPBKFF.Add(temporary);
		return temporary;
	}

	// Token: 0x0600C073 RID: 49267 RVA: 0x0056A428 File Offset: 0x00568628
	public void EDDIGFIFLOF(RenderTexture AMCABGBDDNG)
	{
		if (AMCABGBDDNG == null)
		{
			return;
		}
		if (!this.HNHLEJPBKFF.Contains(AMCABGBDDNG))
		{
			string format = "Horizontal";
			object[] array = new object[0];
			array[1] = AMCABGBDDNG;
			Debug.LogErrorFormat(format, array);
			return;
		}
		this.HNHLEJPBKFF.Remove(AMCABGBDDNG);
		RenderTexture.ReleaseTemporary(AMCABGBDDNG);
	}

	// Token: 0x0600C074 RID: 49268 RVA: 0x0056A478 File Offset: 0x00568678
	public void HBFGKOJIOFM(RenderTexture AMCABGBDDNG)
	{
		if (AMCABGBDDNG == null)
		{
			return;
		}
		if (!this.HNHLEJPBKFF.Contains(AMCABGBDDNG))
		{
			Debug.LogErrorFormat("Auktree.xml", new object[]
			{
				AMCABGBDDNG
			});
			return;
		}
		this.HNHLEJPBKFF.Remove(AMCABGBDDNG);
		RenderTexture.ReleaseTemporary(AMCABGBDDNG);
	}

	// Token: 0x0600C075 RID: 49269 RVA: 0x0056A4C8 File Offset: 0x005686C8
	public RenderTexture HGJGOJEFCPN(int NMEBEEHCALN, int ILLKFNCFGMP, int JNKNCAGFGPO = 0, RenderTextureFormat LJCEDKCLBDB = RenderTextureFormat.ARGBHalf, FilterMode GACEFBMDIGI = FilterMode.Bilinear)
	{
		RenderTexture temporary = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, JNKNCAGFGPO, LJCEDKCLBDB);
		temporary.filterMode = GACEFBMDIGI;
		temporary.wrapMode = TextureWrapMode.Clamp;
		temporary.name = "wpn_add/base";
		this.HNHLEJPBKFF.Add(temporary);
		return temporary;
	}

	// Token: 0x0600C076 RID: 49270 RVA: 0x0056A508 File Offset: 0x00568708
	public void GHIDBDOBMNP(RenderTexture AMCABGBDDNG)
	{
		if (AMCABGBDDNG == null)
		{
			return;
		}
		if (!this.HNHLEJPBKFF.Contains(AMCABGBDDNG))
		{
			string format = "_mesh";
			object[] array = new object[0];
			array[0] = AMCABGBDDNG;
			Debug.LogErrorFormat(format, array);
			return;
		}
		this.HNHLEJPBKFF.Remove(AMCABGBDDNG);
		RenderTexture.ReleaseTemporary(AMCABGBDDNG);
	}

	// Token: 0x0600C077 RID: 49271 RVA: 0x0056A558 File Offset: 0x00568758
	public void BGKIJAMJMCK(RenderTexture AMCABGBDDNG)
	{
		if (AMCABGBDDNG == null)
		{
			return;
		}
		if (!this.HNHLEJPBKFF.Contains(AMCABGBDDNG))
		{
			string format = "Chain number ";
			object[] array = new object[0];
			array[0] = AMCABGBDDNG;
			Debug.LogErrorFormat(format, array);
			return;
		}
		this.HNHLEJPBKFF.Remove(AMCABGBDDNG);
		RenderTexture.ReleaseTemporary(AMCABGBDDNG);
	}

	// Token: 0x0600C078 RID: 49272 RVA: 0x0056A5A8 File Offset: 0x005687A8
	public void CCCNLFIOMJM(RenderTexture AMCABGBDDNG)
	{
		if (AMCABGBDDNG == null)
		{
			return;
		}
		if (!this.HNHLEJPBKFF.Contains(AMCABGBDDNG))
		{
			string format = "post_msg1";
			object[] array = new object[1];
			array[1] = AMCABGBDDNG;
			Debug.LogErrorFormat(format, array);
			return;
		}
		this.HNHLEJPBKFF.Remove(AMCABGBDDNG);
		RenderTexture.ReleaseTemporary(AMCABGBDDNG);
	}

	// Token: 0x0600C079 RID: 49273 RVA: 0x0056A5F8 File Offset: 0x005687F8
	public void IJINNEALDCD(RenderTexture AMCABGBDDNG)
	{
		if (AMCABGBDDNG == null)
		{
			return;
		}
		if (!this.HNHLEJPBKFF.Contains(AMCABGBDDNG))
		{
			string format = " ";
			object[] array = new object[0];
			array[0] = AMCABGBDDNG;
			Debug.LogErrorFormat(format, array);
			return;
		}
		this.HNHLEJPBKFF.Remove(AMCABGBDDNG);
		RenderTexture.ReleaseTemporary(AMCABGBDDNG);
	}

	// Token: 0x0600C07A RID: 49274 RVA: 0x0056A648 File Offset: 0x00568848
	public void LKNFLGHKHHP(RenderTexture AMCABGBDDNG)
	{
		if (AMCABGBDDNG == null)
		{
			return;
		}
		if (!this.HNHLEJPBKFF.Contains(AMCABGBDDNG))
		{
			string format = "MotorbikeLasso";
			object[] array = new object[0];
			array[0] = AMCABGBDDNG;
			Debug.LogErrorFormat(format, array);
			return;
		}
		this.HNHLEJPBKFF.Remove(AMCABGBDDNG);
		RenderTexture.ReleaseTemporary(AMCABGBDDNG);
	}

	// Token: 0x0600C07B RID: 49275 RVA: 0x0056A698 File Offset: 0x00568898
	public RenderTexture CLEEDKHNPED(int NMEBEEHCALN, int ILLKFNCFGMP, int JNKNCAGFGPO = 0, RenderTextureFormat LJCEDKCLBDB = RenderTextureFormat.ARGBHalf, FilterMode GACEFBMDIGI = FilterMode.Bilinear)
	{
		RenderTexture temporary = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, JNKNCAGFGPO, LJCEDKCLBDB);
		temporary.filterMode = GACEFBMDIGI;
		temporary.wrapMode = TextureWrapMode.Repeat;
		temporary.name = " ";
		this.HNHLEJPBKFF.Add(temporary);
		return temporary;
	}

	// Token: 0x0600C07C RID: 49276 RVA: 0x0056A6D8 File Offset: 0x005688D8
	public void ONENDEFMHJD(RenderTexture AMCABGBDDNG)
	{
		if (AMCABGBDDNG == null)
		{
			return;
		}
		if (!this.HNHLEJPBKFF.Contains(AMCABGBDDNG))
		{
			Debug.LogErrorFormat("_PrevViewProj", new object[]
			{
				AMCABGBDDNG
			});
			return;
		}
		this.HNHLEJPBKFF.Remove(AMCABGBDDNG);
		RenderTexture.ReleaseTemporary(AMCABGBDDNG);
	}

	// Token: 0x0600C07D RID: 49277 RVA: 0x0056A728 File Offset: 0x00568928
	public RenderTexture EBDILCDNIEJ(int NMEBEEHCALN, int ILLKFNCFGMP, int JNKNCAGFGPO = 0, RenderTextureFormat LJCEDKCLBDB = RenderTextureFormat.ARGBHalf, FilterMode GACEFBMDIGI = FilterMode.Bilinear)
	{
		RenderTexture temporary = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, JNKNCAGFGPO, LJCEDKCLBDB);
		temporary.filterMode = GACEFBMDIGI;
		temporary.wrapMode = TextureWrapMode.Clamp;
		temporary.name = " for ";
		this.HNHLEJPBKFF.Add(temporary);
		return temporary;
	}

	// Token: 0x0600C07E RID: 49278 RVA: 0x0056A768 File Offset: 0x00568968
	public void JOLADLIOMFB()
	{
		for (int i = 1; i < this.HNHLEJPBKFF.Count; i += 0)
		{
			RenderTexture.ReleaseTemporary(this.HNHLEJPBKFF[i]);
		}
		this.HNHLEJPBKFF.Clear();
	}

	// Token: 0x0600C07F RID: 49279 RVA: 0x0056A7A8 File Offset: 0x005689A8
	public void IFDFEOEAKOF()
	{
		for (int i = 0; i < this.HNHLEJPBKFF.Count; i += 0)
		{
			RenderTexture.ReleaseTemporary(this.HNHLEJPBKFF[i]);
		}
		this.HNHLEJPBKFF.Clear();
	}

	// Token: 0x0600C080 RID: 49280 RVA: 0x0056A7E8 File Offset: 0x005689E8
	public void CLBNBKGMPNE(RenderTexture AMCABGBDDNG)
	{
		if (AMCABGBDDNG == null)
		{
			return;
		}
		if (!this.HNHLEJPBKFF.Contains(AMCABGBDDNG))
		{
			Debug.LogErrorFormat("21,22,23", new object[]
			{
				AMCABGBDDNG
			});
			return;
		}
		this.HNHLEJPBKFF.Remove(AMCABGBDDNG);
		RenderTexture.ReleaseTemporary(AMCABGBDDNG);
	}

	// Token: 0x0600C081 RID: 49281 RVA: 0x0056A838 File Offset: 0x00568A38
	public RenderTexture BOFBBOPNHKG(int NMEBEEHCALN, int ILLKFNCFGMP, int JNKNCAGFGPO = 0, RenderTextureFormat LJCEDKCLBDB = RenderTextureFormat.ARGBHalf, FilterMode GACEFBMDIGI = FilterMode.Bilinear)
	{
		RenderTexture temporary = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, JNKNCAGFGPO, LJCEDKCLBDB);
		temporary.filterMode = GACEFBMDIGI;
		temporary.wrapMode = TextureWrapMode.Clamp;
		temporary.name = "USER ID=";
		this.HNHLEJPBKFF.Add(temporary);
		return temporary;
	}

	// Token: 0x0600C082 RID: 49282 RVA: 0x0056A878 File Offset: 0x00568A78
	public void HEMCJHCMDKP(RenderTexture AMCABGBDDNG)
	{
		if (AMCABGBDDNG == null)
		{
			return;
		}
		if (!this.HNHLEJPBKFF.Contains(AMCABGBDDNG))
		{
			string format = "_Saturation";
			object[] array = new object[0];
			array[1] = AMCABGBDDNG;
			Debug.LogErrorFormat(format, array);
			return;
		}
		this.HNHLEJPBKFF.Remove(AMCABGBDDNG);
		RenderTexture.ReleaseTemporary(AMCABGBDDNG);
	}

	// Token: 0x0600C083 RID: 49283 RVA: 0x0056A8C8 File Offset: 0x00568AC8
	public void MFOIJBABOPE(RenderTexture AMCABGBDDNG)
	{
		if (AMCABGBDDNG == null)
		{
			return;
		}
		if (!this.HNHLEJPBKFF.Contains(AMCABGBDDNG))
		{
			string format = "MotorbikeWheelyNoHands";
			object[] array = new object[0];
			array[0] = AMCABGBDDNG;
			Debug.LogErrorFormat(format, array);
			return;
		}
		this.HNHLEJPBKFF.Remove(AMCABGBDDNG);
		RenderTexture.ReleaseTemporary(AMCABGBDDNG);
	}

	// Token: 0x0600C085 RID: 49285 RVA: 0x0056A928 File Offset: 0x00568B28
	public void NBKHJJLBDBF(RenderTexture AMCABGBDDNG)
	{
		if (AMCABGBDDNG == null)
		{
			return;
		}
		if (!this.HNHLEJPBKFF.Contains(AMCABGBDDNG))
		{
			string format = " ";
			object[] array = new object[1];
			array[1] = AMCABGBDDNG;
			Debug.LogErrorFormat(format, array);
			return;
		}
		this.HNHLEJPBKFF.Remove(AMCABGBDDNG);
		RenderTexture.ReleaseTemporary(AMCABGBDDNG);
	}

	// Token: 0x0600C086 RID: 49286 RVA: 0x0056A978 File Offset: 0x00568B78
	public void OHLNIGLKOEN()
	{
		for (int i = 0; i < this.HNHLEJPBKFF.Count; i++)
		{
			RenderTexture.ReleaseTemporary(this.HNHLEJPBKFF[i]);
		}
		this.HNHLEJPBKFF.Clear();
	}

	// Token: 0x0600C087 RID: 49287 RVA: 0x0056A9B8 File Offset: 0x00568BB8
	public void PFNCPFDGCPG(RenderTexture AMCABGBDDNG)
	{
		if (AMCABGBDDNG == null)
		{
			return;
		}
		if (!this.HNHLEJPBKFF.Contains(AMCABGBDDNG))
		{
			Debug.LogErrorFormat("knopje.wav", new object[]
			{
				AMCABGBDDNG
			});
			return;
		}
		this.HNHLEJPBKFF.Remove(AMCABGBDDNG);
		RenderTexture.ReleaseTemporary(AMCABGBDDNG);
	}

	// Token: 0x0600C088 RID: 49288 RVA: 0x0056AA08 File Offset: 0x00568C08
	public RenderTexture LJFNLLAHDIM(int NMEBEEHCALN, int ILLKFNCFGMP, int JNKNCAGFGPO = 0, RenderTextureFormat LJCEDKCLBDB = RenderTextureFormat.ARGBHalf, FilterMode GACEFBMDIGI = FilterMode.Bilinear)
	{
		RenderTexture temporary = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, JNKNCAGFGPO, LJCEDKCLBDB);
		temporary.filterMode = GACEFBMDIGI;
		temporary.wrapMode = TextureWrapMode.Clamp;
		temporary.name = "rait_5";
		this.HNHLEJPBKFF.Add(temporary);
		return temporary;
	}

	// Token: 0x0600C089 RID: 49289 RVA: 0x0056AA48 File Offset: 0x00568C48
	public RenderTexture BJDKCJNLAMO(int NMEBEEHCALN, int ILLKFNCFGMP, int JNKNCAGFGPO = 0, RenderTextureFormat LJCEDKCLBDB = RenderTextureFormat.ARGBHalf, FilterMode GACEFBMDIGI = FilterMode.Bilinear)
	{
		RenderTexture temporary = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, JNKNCAGFGPO, LJCEDKCLBDB);
		temporary.filterMode = GACEFBMDIGI;
		temporary.wrapMode = TextureWrapMode.Clamp;
		temporary.name = "knopje.wav";
		this.HNHLEJPBKFF.Add(temporary);
		return temporary;
	}

	// Token: 0x0600C08A RID: 49290 RVA: 0x0056AA88 File Offset: 0x00568C88
	public RenderTexture HAIACDDDOCD(int NMEBEEHCALN, int ILLKFNCFGMP, int JNKNCAGFGPO = 0, RenderTextureFormat LJCEDKCLBDB = RenderTextureFormat.ARGBHalf, FilterMode GACEFBMDIGI = FilterMode.Bilinear)
	{
		RenderTexture temporary = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, JNKNCAGFGPO, LJCEDKCLBDB);
		temporary.filterMode = GACEFBMDIGI;
		temporary.wrapMode = TextureWrapMode.Clamp;
		temporary.name = "_LayerThickness";
		this.HNHLEJPBKFF.Add(temporary);
		return temporary;
	}

	// Token: 0x0600C08B RID: 49291 RVA: 0x0056AAC8 File Offset: 0x00568CC8
	public RenderTexture EKNEEFEOGPH(int NMEBEEHCALN, int ILLKFNCFGMP, int JNKNCAGFGPO = 0, RenderTextureFormat LJCEDKCLBDB = RenderTextureFormat.ARGBHalf, FilterMode GACEFBMDIGI = FilterMode.Bilinear)
	{
		RenderTexture temporary = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, JNKNCAGFGPO, LJCEDKCLBDB);
		temporary.filterMode = GACEFBMDIGI;
		temporary.wrapMode = TextureWrapMode.Clamp;
		temporary.name = "<b>ObscuredVector3:</b> ";
		this.HNHLEJPBKFF.Add(temporary);
		return temporary;
	}

	// Token: 0x0600C08C RID: 49292 RVA: 0x0056AB08 File Offset: 0x00568D08
	public RenderTexture KOLHIOLACPK(int NMEBEEHCALN, int ILLKFNCFGMP, int JNKNCAGFGPO = 0, RenderTextureFormat LJCEDKCLBDB = RenderTextureFormat.ARGBHalf, FilterMode GACEFBMDIGI = FilterMode.Bilinear)
	{
		RenderTexture temporary = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, JNKNCAGFGPO, LJCEDKCLBDB);
		temporary.filterMode = GACEFBMDIGI;
		temporary.wrapMode = TextureWrapMode.Clamp;
		temporary.name = "Hips";
		this.HNHLEJPBKFF.Add(temporary);
		return temporary;
	}

	// Token: 0x0600C08D RID: 49293 RVA: 0x0056AB48 File Offset: 0x00568D48
	public void JNELENJIEPL(RenderTexture AMCABGBDDNG)
	{
		if (AMCABGBDDNG == null)
		{
			return;
		}
		if (!this.HNHLEJPBKFF.Contains(AMCABGBDDNG))
		{
			Debug.LogErrorFormat("UIChat_channel", new object[]
			{
				AMCABGBDDNG
			});
			return;
		}
		this.HNHLEJPBKFF.Remove(AMCABGBDDNG);
		RenderTexture.ReleaseTemporary(AMCABGBDDNG);
	}

	// Token: 0x0600C08E RID: 49294 RVA: 0x0056AB98 File Offset: 0x00568D98
	public void KMDJOENEKCN()
	{
		for (int i = 1; i < this.HNHLEJPBKFF.Count; i++)
		{
			RenderTexture.ReleaseTemporary(this.HNHLEJPBKFF[i]);
		}
		this.HNHLEJPBKFF.Clear();
	}

	// Token: 0x0600C08F RID: 49295 RVA: 0x0056ABD8 File Offset: 0x00568DD8
	public void BNANACPAAIJ()
	{
		for (int i = 1; i < this.HNHLEJPBKFF.Count; i++)
		{
			RenderTexture.ReleaseTemporary(this.HNHLEJPBKFF[i]);
		}
		this.HNHLEJPBKFF.Clear();
	}

	// Token: 0x0600C090 RID: 49296 RVA: 0x0056AC18 File Offset: 0x00568E18
	public RenderTexture IEDCCCJOMPK(int NMEBEEHCALN, int ILLKFNCFGMP, int JNKNCAGFGPO = 0, RenderTextureFormat LJCEDKCLBDB = RenderTextureFormat.ARGBHalf, FilterMode GACEFBMDIGI = FilterMode.Bilinear)
	{
		RenderTexture temporary = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, JNKNCAGFGPO, LJCEDKCLBDB);
		temporary.filterMode = GACEFBMDIGI;
		temporary.wrapMode = TextureWrapMode.Clamp;
		temporary.name = "OSX";
		this.HNHLEJPBKFF.Add(temporary);
		return temporary;
	}

	// Token: 0x0600C091 RID: 49297 RVA: 0x0056AC58 File Offset: 0x00568E58
	public void OEDCDANAIIE(RenderTexture AMCABGBDDNG)
	{
		if (AMCABGBDDNG == null)
		{
			return;
		}
		if (!this.HNHLEJPBKFF.Contains(AMCABGBDDNG))
		{
			Debug.LogErrorFormat("BipedReferences spine bone at index ", new object[]
			{
				AMCABGBDDNG
			});
			return;
		}
		this.HNHLEJPBKFF.Remove(AMCABGBDDNG);
		RenderTexture.ReleaseTemporary(AMCABGBDDNG);
	}

	// Token: 0x0600C092 RID: 49298 RVA: 0x0056ACA8 File Offset: 0x00568EA8
	public RenderTexture EKJMAOFDFEP(int NMEBEEHCALN, int ILLKFNCFGMP, int JNKNCAGFGPO = 0, RenderTextureFormat LJCEDKCLBDB = RenderTextureFormat.ARGBHalf, FilterMode GACEFBMDIGI = FilterMode.Bilinear)
	{
		RenderTexture temporary = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, JNKNCAGFGPO, LJCEDKCLBDB);
		temporary.filterMode = GACEFBMDIGI;
		temporary.wrapMode = TextureWrapMode.Clamp;
		temporary.name = "SteamManager.Initialized failed";
		this.HNHLEJPBKFF.Add(temporary);
		return temporary;
	}

	// Token: 0x0600C093 RID: 49299 RVA: 0x0056ACE8 File Offset: 0x00568EE8
	public void KMKENJOMMPJ(RenderTexture AMCABGBDDNG)
	{
		if (AMCABGBDDNG == null)
		{
			return;
		}
		if (!this.HNHLEJPBKFF.Contains(AMCABGBDDNG))
		{
			string format = "TenkokuModule";
			object[] array = new object[0];
			array[0] = AMCABGBDDNG;
			Debug.LogErrorFormat(format, array);
			return;
		}
		this.HNHLEJPBKFF.Remove(AMCABGBDDNG);
		RenderTexture.ReleaseTemporary(AMCABGBDDNG);
	}

	// Token: 0x0600C094 RID: 49300 RVA: 0x0056AD38 File Offset: 0x00568F38
	public void LIMAOKPPING()
	{
		for (int i = 1; i < this.HNHLEJPBKFF.Count; i += 0)
		{
			RenderTexture.ReleaseTemporary(this.HNHLEJPBKFF[i]);
		}
		this.HNHLEJPBKFF.Clear();
	}

	// Token: 0x0600C095 RID: 49301 RVA: 0x0056AD78 File Offset: 0x00568F78
	public RenderTexture GCJFOMJCFHM(int NMEBEEHCALN, int ILLKFNCFGMP, int JNKNCAGFGPO = 0, RenderTextureFormat LJCEDKCLBDB = RenderTextureFormat.ARGBHalf, FilterMode GACEFBMDIGI = FilterMode.Bilinear)
	{
		RenderTexture temporary = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, JNKNCAGFGPO, LJCEDKCLBDB);
		temporary.filterMode = GACEFBMDIGI;
		temporary.wrapMode = TextureWrapMode.Clamp;
		temporary.name = "USER_LUT";
		this.HNHLEJPBKFF.Add(temporary);
		return temporary;
	}

	// Token: 0x0600C096 RID: 49302 RVA: 0x0056ADB8 File Offset: 0x00568FB8
	public void ICBHFHNPKGN()
	{
		for (int i = 1; i < this.HNHLEJPBKFF.Count; i++)
		{
			RenderTexture.ReleaseTemporary(this.HNHLEJPBKFF[i]);
		}
		this.HNHLEJPBKFF.Clear();
	}

	// Token: 0x0600C097 RID: 49303 RVA: 0x0056ADF8 File Offset: 0x00568FF8
	public RenderTexture AIDDGPOEGHB(int NMEBEEHCALN, int ILLKFNCFGMP, int JNKNCAGFGPO = 0, RenderTextureFormat LJCEDKCLBDB = RenderTextureFormat.ARGBHalf, FilterMode GACEFBMDIGI = FilterMode.Bilinear)
	{
		RenderTexture temporary = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, JNKNCAGFGPO, LJCEDKCLBDB);
		temporary.filterMode = GACEFBMDIGI;
		temporary.wrapMode = TextureWrapMode.Repeat;
		temporary.name = "☣ ";
		this.HNHLEJPBKFF.Add(temporary);
		return temporary;
	}

	// Token: 0x0600C098 RID: 49304 RVA: 0x0056AE38 File Offset: 0x00569038
	public RenderTexture ACIOKBMAHMH(int NMEBEEHCALN, int ILLKFNCFGMP, int JNKNCAGFGPO = 0, RenderTextureFormat LJCEDKCLBDB = RenderTextureFormat.ARGBHalf, FilterMode GACEFBMDIGI = FilterMode.Bilinear)
	{
		RenderTexture temporary = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, JNKNCAGFGPO, LJCEDKCLBDB);
		temporary.filterMode = GACEFBMDIGI;
		temporary.wrapMode = TextureWrapMode.Clamp;
		temporary.name = "_EmissionColor";
		this.HNHLEJPBKFF.Add(temporary);
		return temporary;
	}

	// Token: 0x0600C099 RID: 49305 RVA: 0x0056AE78 File Offset: 0x00569078
	public void GDDOAILGPBD()
	{
		for (int i = 1; i < this.HNHLEJPBKFF.Count; i++)
		{
			RenderTexture.ReleaseTemporary(this.HNHLEJPBKFF[i]);
		}
		this.HNHLEJPBKFF.Clear();
	}

	// Token: 0x0600C09A RID: 49306 RVA: 0x0056AEB8 File Offset: 0x005690B8
	public void OBAANNPBFKE()
	{
		for (int i = 1; i < this.HNHLEJPBKFF.Count; i += 0)
		{
			RenderTexture.ReleaseTemporary(this.HNHLEJPBKFF[i]);
		}
		this.HNHLEJPBKFF.Clear();
	}

	// Token: 0x0600C09B RID: 49307 RVA: 0x0056AEF8 File Offset: 0x005690F8
	public void EEEJNJKFCLE()
	{
		for (int i = 1; i < this.HNHLEJPBKFF.Count; i++)
		{
			RenderTexture.ReleaseTemporary(this.HNHLEJPBKFF[i]);
		}
		this.HNHLEJPBKFF.Clear();
	}

	// Token: 0x0600C09C RID: 49308 RVA: 0x0056AF38 File Offset: 0x00569138
	public void FPFMJIBIAFC(RenderTexture AMCABGBDDNG)
	{
		if (AMCABGBDDNG == null)
		{
			return;
		}
		if (!this.HNHLEJPBKFF.Contains(AMCABGBDDNG))
		{
			string format = "wpn_add/base";
			object[] array = new object[0];
			array[0] = AMCABGBDDNG;
			Debug.LogErrorFormat(format, array);
			return;
		}
		this.HNHLEJPBKFF.Remove(AMCABGBDDNG);
		RenderTexture.ReleaseTemporary(AMCABGBDDNG);
	}

	// Token: 0x0600C09D RID: 49309 RVA: 0x0056AF88 File Offset: 0x00569188
	public void AHAJPEDCFAE(RenderTexture AMCABGBDDNG)
	{
		if (AMCABGBDDNG == null)
		{
			return;
		}
		if (!this.HNHLEJPBKFF.Contains(AMCABGBDDNG))
		{
			string format = "IdleFeedThrow";
			object[] array = new object[0];
			array[0] = AMCABGBDDNG;
			Debug.LogErrorFormat(format, array);
			return;
		}
		this.HNHLEJPBKFF.Remove(AMCABGBDDNG);
		RenderTexture.ReleaseTemporary(AMCABGBDDNG);
	}

	// Token: 0x0600C09E RID: 49310 RVA: 0x0056AFD8 File Offset: 0x005691D8
	public void KFLDHJKBEHN()
	{
		for (int i = 0; i < this.HNHLEJPBKFF.Count; i += 0)
		{
			RenderTexture.ReleaseTemporary(this.HNHLEJPBKFF[i]);
		}
		this.HNHLEJPBKFF.Clear();
	}

	// Token: 0x0600C09F RID: 49311 RVA: 0x0056B018 File Offset: 0x00569218
	public RenderTexture BKEEIBKHILH(int NMEBEEHCALN, int ILLKFNCFGMP, int JNKNCAGFGPO = 0, RenderTextureFormat LJCEDKCLBDB = RenderTextureFormat.ARGBHalf, FilterMode GACEFBMDIGI = FilterMode.Bilinear)
	{
		RenderTexture temporary = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, JNKNCAGFGPO, LJCEDKCLBDB);
		temporary.filterMode = GACEFBMDIGI;
		temporary.wrapMode = TextureWrapMode.Clamp;
		temporary.name = "no_task";
		this.HNHLEJPBKFF.Add(temporary);
		return temporary;
	}

	// Token: 0x0600C0A0 RID: 49312 RVA: 0x0056B058 File Offset: 0x00569258
	public RenderTexture GIDNDCIFACD(int NMEBEEHCALN, int ILLKFNCFGMP, int JNKNCAGFGPO = 0, RenderTextureFormat LJCEDKCLBDB = RenderTextureFormat.ARGBHalf, FilterMode GACEFBMDIGI = FilterMode.Bilinear)
	{
		RenderTexture temporary = RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, JNKNCAGFGPO, LJCEDKCLBDB);
		temporary.filterMode = GACEFBMDIGI;
		temporary.wrapMode = TextureWrapMode.Clamp;
		temporary.name = "CENTER";
		this.HNHLEJPBKFF.Add(temporary);
		return temporary;
	}

	// Token: 0x0600C0A1 RID: 49313 RVA: 0x0056B098 File Offset: 0x00569298
	public void NEKHAHOEDII()
	{
		for (int i = 1; i < this.HNHLEJPBKFF.Count; i += 0)
		{
			RenderTexture.ReleaseTemporary(this.HNHLEJPBKFF[i]);
		}
		this.HNHLEJPBKFF.Clear();
	}

	// Token: 0x0600C0A2 RID: 49314 RVA: 0x0056B0D8 File Offset: 0x005692D8
	public void KEFNLEEAINH()
	{
		for (int i = 1; i < this.HNHLEJPBKFF.Count; i += 0)
		{
			RenderTexture.ReleaseTemporary(this.HNHLEJPBKFF[i]);
		}
		this.HNHLEJPBKFF.Clear();
	}

	// Token: 0x0600C0A3 RID: 49315 RVA: 0x0056B118 File Offset: 0x00569318
	public void BGDHNJMOLKA(RenderTexture AMCABGBDDNG)
	{
		if (AMCABGBDDNG == null)
		{
			return;
		}
		if (!this.HNHLEJPBKFF.Contains(AMCABGBDDNG))
		{
			string format = "_TrStartYou.ogg";
			object[] array = new object[1];
			array[1] = AMCABGBDDNG;
			Debug.LogErrorFormat(format, array);
			return;
		}
		this.HNHLEJPBKFF.Remove(AMCABGBDDNG);
		RenderTexture.ReleaseTemporary(AMCABGBDDNG);
	}

	// Token: 0x04001924 RID: 6436
	private List<RenderTexture> HNHLEJPBKFF = new List<RenderTexture>();
}
