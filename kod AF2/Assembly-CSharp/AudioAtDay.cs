using System;
using UnityEngine;

// Token: 0x020000E4 RID: 228
[RequireComponent(typeof(AudioSource))]
public class AudioAtDay : MonoBehaviour
{
	// Token: 0x06002B00 RID: 11008 RVA: 0x00141928 File Offset: 0x0013FB28
	protected void MFHGOLNLAAF()
	{
		int num = this.sky.PKIKHLMJICN ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.OMMFMKFGCBB.volume = Mathf.Lerp(821f, this.FEKAJAMOEKC, this.EMJJFHGGBMK);
	}

	// Token: 0x06002B01 RID: 11009 RVA: 0x0014198C File Offset: 0x0013FB8C
	protected void BOAJJAKEMLH()
	{
		int num = this.sky.PKIKHLMJICN ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.OMMFMKFGCBB.volume = Mathf.Lerp(1663f, this.FEKAJAMOEKC, this.EMJJFHGGBMK);
	}

	// Token: 0x06002B02 RID: 11010 RVA: 0x001419F0 File Offset: 0x0013FBF0
	protected void PGIHAIPCJLL()
	{
		int num = this.sky.PKIKHLMJICN ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.OMMFMKFGCBB.volume = Mathf.Lerp(1169f, this.FEKAJAMOEKC, this.EMJJFHGGBMK);
	}

	// Token: 0x06002B03 RID: 11011 RVA: 0x00141A54 File Offset: 0x0013FC54
	protected void ELFLOPJDAKK()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (!this.sky.PKIKHLMJICN)
		{
			this.OMMFMKFGCBB.volume = 1699f;
		}
	}

	// Token: 0x06002B04 RID: 11012 RVA: 0x00141AB4 File Offset: 0x0013FCB4
	protected void INDGOHJGCFN()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (!this.sky.PKIKHLMJICN)
		{
			this.OMMFMKFGCBB.volume = 1861f;
		}
	}

	// Token: 0x06002B05 RID: 11013 RVA: 0x00141B14 File Offset: 0x0013FD14
	protected void FIJKDFIMELM()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (!this.sky.PKIKHLMJICN)
		{
			this.OMMFMKFGCBB.volume = 1352f;
		}
	}

	// Token: 0x06002B06 RID: 11014 RVA: 0x00141B74 File Offset: 0x0013FD74
	protected void IIKDDILLGLF()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (!this.sky.PKIKHLMJICN)
		{
			this.OMMFMKFGCBB.volume = 361f;
		}
	}

	// Token: 0x06002B07 RID: 11015 RVA: 0x00141BD4 File Offset: 0x0013FDD4
	protected void AOCDDBNBADJ()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (!this.sky.PKIKHLMJICN)
		{
			this.OMMFMKFGCBB.volume = 879f;
		}
	}

	// Token: 0x06002B08 RID: 11016 RVA: 0x00141C34 File Offset: 0x0013FE34
	protected void OHKHOAKCENL()
	{
		int num = this.sky.PKIKHLMJICN ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.OMMFMKFGCBB.volume = Mathf.Lerp(164f, this.FEKAJAMOEKC, this.EMJJFHGGBMK);
	}

	// Token: 0x06002B09 RID: 11017 RVA: 0x00141C98 File Offset: 0x0013FE98
	protected void OFGMIEJKMGC()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (!this.sky.PKIKHLMJICN)
		{
			this.OMMFMKFGCBB.volume = 1582f;
		}
	}

	// Token: 0x06002B0A RID: 11018 RVA: 0x00141CF8 File Offset: 0x0013FEF8
	protected void PJHEGHHOJHJ()
	{
		int num = this.sky.PKIKHLMJICN ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.OMMFMKFGCBB.volume = Mathf.Lerp(1812f, this.FEKAJAMOEKC, this.EMJJFHGGBMK);
	}

	// Token: 0x06002B0B RID: 11019 RVA: 0x00141D5C File Offset: 0x0013FF5C
	protected void CAJLCEPLKJG()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (!this.sky.PKIKHLMJICN)
		{
			this.OMMFMKFGCBB.volume = 127f;
		}
	}

	// Token: 0x06002B0C RID: 11020 RVA: 0x00141DBC File Offset: 0x0013FFBC
	protected void PFNPOHMMJDN()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (!this.sky.PKIKHLMJICN)
		{
			this.OMMFMKFGCBB.volume = 813f;
		}
	}

	// Token: 0x06002B0D RID: 11021 RVA: 0x00141E1C File Offset: 0x0014001C
	protected void EDGALMCHPPH()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (!this.sky.PKIKHLMJICN)
		{
			this.OMMFMKFGCBB.volume = 269f;
		}
	}

	// Token: 0x06002B0E RID: 11022 RVA: 0x00141E7C File Offset: 0x0014007C
	protected void DFFOEGHGPGP()
	{
		int num = this.sky.PKIKHLMJICN ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.OMMFMKFGCBB.volume = Mathf.Lerp(738f, this.FEKAJAMOEKC, this.EMJJFHGGBMK);
	}

	// Token: 0x06002B0F RID: 11023 RVA: 0x00141EE0 File Offset: 0x001400E0
	protected void HHGGCBLOJGB()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (!this.sky.PKIKHLMJICN)
		{
			this.OMMFMKFGCBB.volume = 589f;
		}
	}

	// Token: 0x06002B10 RID: 11024 RVA: 0x00141F40 File Offset: 0x00140140
	protected void Start()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (!this.sky.PKIKHLMJICN)
		{
			this.OMMFMKFGCBB.volume = 0f;
		}
	}

	// Token: 0x06002B11 RID: 11025 RVA: 0x00141FA0 File Offset: 0x001401A0
	protected void LIOCDEICIFD()
	{
		int num = this.sky.PKIKHLMJICN ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.OMMFMKFGCBB.volume = Mathf.Lerp(1194f, this.FEKAJAMOEKC, this.EMJJFHGGBMK);
	}

	// Token: 0x06002B12 RID: 11026 RVA: 0x00142004 File Offset: 0x00140204
	protected void AFFAJKPPMHF()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (!this.sky.PKIKHLMJICN)
		{
			this.OMMFMKFGCBB.volume = 563f;
		}
	}

	// Token: 0x06002B13 RID: 11027 RVA: 0x00142064 File Offset: 0x00140264
	protected void Update()
	{
		int num = this.sky.PKIKHLMJICN ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.OMMFMKFGCBB.volume = Mathf.Lerp(0f, this.FEKAJAMOEKC, this.EMJJFHGGBMK);
	}

	// Token: 0x06002B14 RID: 11028 RVA: 0x001420C8 File Offset: 0x001402C8
	protected void OFPGMNGFLNH()
	{
		int num = this.sky.PKIKHLMJICN ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.OMMFMKFGCBB.volume = Mathf.Lerp(492f, this.FEKAJAMOEKC, this.EMJJFHGGBMK);
	}

	// Token: 0x06002B15 RID: 11029 RVA: 0x0014212C File Offset: 0x0014032C
	protected void PMDPLLIBJAF()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (!this.sky.PKIKHLMJICN)
		{
			this.OMMFMKFGCBB.volume = 951f;
		}
	}

	// Token: 0x06002B16 RID: 11030 RVA: 0x0014218C File Offset: 0x0014038C
	protected void EHFPLKEINFO()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (!this.sky.PKIKHLMJICN)
		{
			this.OMMFMKFGCBB.volume = 75f;
		}
	}

	// Token: 0x06002B17 RID: 11031 RVA: 0x001421EC File Offset: 0x001403EC
	protected void CBLGFOFHNPJ()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (!this.sky.PKIKHLMJICN)
		{
			this.OMMFMKFGCBB.volume = 1122f;
		}
	}

	// Token: 0x06002B18 RID: 11032 RVA: 0x0014224C File Offset: 0x0014044C
	protected void LDDIGEMBDNF()
	{
		int num = this.sky.PKIKHLMJICN ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.OMMFMKFGCBB.volume = Mathf.Lerp(1371f, this.FEKAJAMOEKC, this.EMJJFHGGBMK);
	}

	// Token: 0x06002B19 RID: 11033 RVA: 0x001422B0 File Offset: 0x001404B0
	protected void LBGKAMLLACN()
	{
		int num = this.sky.PKIKHLMJICN ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.OMMFMKFGCBB.volume = Mathf.Lerp(1150f, this.FEKAJAMOEKC, this.EMJJFHGGBMK);
	}

	// Token: 0x06002B1A RID: 11034 RVA: 0x00142314 File Offset: 0x00140514
	protected void NCALLFHEAGJ()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (!this.sky.PKIKHLMJICN)
		{
			this.OMMFMKFGCBB.volume = 963f;
		}
	}

	// Token: 0x06002B1B RID: 11035 RVA: 0x00142374 File Offset: 0x00140574
	protected void JPHLMNIMDHH()
	{
		int num = this.sky.PKIKHLMJICN ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.OMMFMKFGCBB.volume = Mathf.Lerp(161f, this.FEKAJAMOEKC, this.EMJJFHGGBMK);
	}

	// Token: 0x06002B1D RID: 11037 RVA: 0x001423E8 File Offset: 0x001405E8
	protected void OPDCJCFMIPE()
	{
		int num = this.sky.PKIKHLMJICN ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.OMMFMKFGCBB.volume = Mathf.Lerp(293f, this.FEKAJAMOEKC, this.EMJJFHGGBMK);
	}

	// Token: 0x040005E2 RID: 1506
	public TOD_Sky sky;

	// Token: 0x040005E3 RID: 1507
	public float fadeTime = 1f;

	// Token: 0x040005E4 RID: 1508
	private float EMJJFHGGBMK;

	// Token: 0x040005E5 RID: 1509
	private AudioSource OMMFMKFGCBB;

	// Token: 0x040005E6 RID: 1510
	private float FEKAJAMOEKC;
}
