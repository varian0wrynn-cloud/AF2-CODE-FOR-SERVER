using System;
using UnityEngine;

// Token: 0x020000E6 RID: 230
[RequireComponent(typeof(AudioSource))]
public class AudioAtWeather : MonoBehaviour
{
	// Token: 0x06002B58 RID: 11096 RVA: 0x00143A20 File Offset: 0x00141C20
	protected void EDGALMCHPPH()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (this.sky.NINFILJKEFA.PHLAGOLHIMB.Weather != this.type)
		{
			this.OMMFMKFGCBB.volume = 1051f;
		}
	}

	// Token: 0x06002B59 RID: 11097 RVA: 0x00143A90 File Offset: 0x00141C90
	protected void IOGAKGCADBL()
	{
		int num = (this.sky.KMBOELAHKHL().PHLAGOLHIMB.Weather == this.type) ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.OMMFMKFGCBB.volume = Mathf.Lerp(1582f, this.FEKAJAMOEKC, this.EMJJFHGGBMK);
	}

	// Token: 0x06002B5A RID: 11098 RVA: 0x00143B04 File Offset: 0x00141D04
	protected void DFFOEGHGPGP()
	{
		int num = (this.sky.KMBOELAHKHL().PHLAGOLHIMB.Weather == this.type) ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.OMMFMKFGCBB.volume = Mathf.Lerp(416f, this.FEKAJAMOEKC, this.EMJJFHGGBMK);
	}

	// Token: 0x06002B5C RID: 11100 RVA: 0x00143B88 File Offset: 0x00141D88
	protected void OHKHOAKCENL()
	{
		int num = (this.sky.NINFILJKEFA.PHLAGOLHIMB.Weather == this.type) ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.OMMFMKFGCBB.volume = Mathf.Lerp(103f, this.FEKAJAMOEKC, this.EMJJFHGGBMK);
	}

	// Token: 0x06002B5D RID: 11101 RVA: 0x00143BFC File Offset: 0x00141DFC
	protected void BOAJJAKEMLH()
	{
		int num = (this.sky.KMBOELAHKHL().PHLAGOLHIMB.Weather == this.type) ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.OMMFMKFGCBB.volume = Mathf.Lerp(578f, this.FEKAJAMOEKC, this.EMJJFHGGBMK);
	}

	// Token: 0x06002B5E RID: 11102 RVA: 0x00143C70 File Offset: 0x00141E70
	protected void BMNJGPIPKLL()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (this.sky.NINFILJKEFA.PHLAGOLHIMB.Weather != this.type)
		{
			this.OMMFMKFGCBB.volume = 395f;
		}
	}

	// Token: 0x06002B5F RID: 11103 RVA: 0x00143CE0 File Offset: 0x00141EE0
	protected void IIKDDILLGLF()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (this.sky.NINFILJKEFA.PHLAGOLHIMB.Weather != this.type)
		{
			this.OMMFMKFGCBB.volume = 1130f;
		}
	}

	// Token: 0x06002B60 RID: 11104 RVA: 0x00143D50 File Offset: 0x00141F50
	protected void PJHEGHHOJHJ()
	{
		int num = (this.sky.KMBOELAHKHL().PHLAGOLHIMB.Weather == this.type) ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.OMMFMKFGCBB.volume = Mathf.Lerp(1209f, this.FEKAJAMOEKC, this.EMJJFHGGBMK);
	}

	// Token: 0x06002B61 RID: 11105 RVA: 0x00143DC4 File Offset: 0x00141FC4
	protected void Update()
	{
		int num = (this.sky.NINFILJKEFA.PHLAGOLHIMB.Weather == this.type) ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.OMMFMKFGCBB.volume = Mathf.Lerp(0f, this.FEKAJAMOEKC, this.EMJJFHGGBMK);
	}

	// Token: 0x06002B62 RID: 11106 RVA: 0x00143E38 File Offset: 0x00142038
	protected void AIAMIFEPALP()
	{
		int num = (this.sky.KMBOELAHKHL().PHLAGOLHIMB.Weather == this.type) ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.OMMFMKFGCBB.volume = Mathf.Lerp(1958f, this.FEKAJAMOEKC, this.EMJJFHGGBMK);
	}

	// Token: 0x06002B63 RID: 11107 RVA: 0x00143EAC File Offset: 0x001420AC
	protected void ANHOOJFEJJE()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (this.sky.KMBOELAHKHL().PHLAGOLHIMB.Weather != this.type)
		{
			this.OMMFMKFGCBB.volume = 1430f;
		}
	}

	// Token: 0x06002B64 RID: 11108 RVA: 0x00143F1C File Offset: 0x0014211C
	protected void JLFBDOPFDDJ()
	{
		int num = (this.sky.KMBOELAHKHL().PHLAGOLHIMB.Weather == this.type) ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.OMMFMKFGCBB.volume = Mathf.Lerp(1849f, this.FEKAJAMOEKC, this.EMJJFHGGBMK);
	}

	// Token: 0x06002B65 RID: 11109 RVA: 0x00143F90 File Offset: 0x00142190
	protected void Start()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (this.sky.NINFILJKEFA.PHLAGOLHIMB.Weather != this.type)
		{
			this.OMMFMKFGCBB.volume = 0f;
		}
	}

	// Token: 0x06002B66 RID: 11110 RVA: 0x00144000 File Offset: 0x00142200
	protected void AKLFCMNCPKL()
	{
		int num = (this.sky.KMBOELAHKHL().PHLAGOLHIMB.Weather == this.type) ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.OMMFMKFGCBB.volume = Mathf.Lerp(1567f, this.FEKAJAMOEKC, this.EMJJFHGGBMK);
	}

	// Token: 0x040005EC RID: 1516
	public TOD_Sky sky;

	// Token: 0x040005ED RID: 1517
	public JPFPFIFAEKJ type;

	// Token: 0x040005EE RID: 1518
	public float fadeTime = 1f;

	// Token: 0x040005EF RID: 1519
	private float EMJJFHGGBMK;

	// Token: 0x040005F0 RID: 1520
	private AudioSource OMMFMKFGCBB;

	// Token: 0x040005F1 RID: 1521
	private float FEKAJAMOEKC;
}
