using System;
using UnityEngine;

// Token: 0x020000E5 RID: 229
[RequireComponent(typeof(AudioSource))]
public class AudioAtNight : MonoBehaviour
{
	// Token: 0x06002B1E RID: 11038 RVA: 0x0014244C File Offset: 0x0014064C
	protected void BMNJGPIPKLL()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (!this.sky.LADANCDAELM)
		{
			this.OMMFMKFGCBB.volume = 1358f;
		}
	}

	// Token: 0x06002B1F RID: 11039 RVA: 0x001424AC File Offset: 0x001406AC
	protected void IMABGALEMBI()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (!this.sky.LADANCDAELM)
		{
			this.OMMFMKFGCBB.volume = 884f;
		}
	}

	// Token: 0x06002B20 RID: 11040 RVA: 0x0014250C File Offset: 0x0014070C
	protected void Update()
	{
		int num = this.sky.LADANCDAELM ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.OMMFMKFGCBB.volume = Mathf.Lerp(0f, this.FEKAJAMOEKC, this.EMJJFHGGBMK);
	}

	// Token: 0x06002B21 RID: 11041 RVA: 0x00142570 File Offset: 0x00140770
	protected void AOCDDBNBADJ()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (!this.sky.LADANCDAELM)
		{
			this.OMMFMKFGCBB.volume = 43f;
		}
	}

	// Token: 0x06002B22 RID: 11042 RVA: 0x001425D0 File Offset: 0x001407D0
	protected void KJJBBLDJHPD()
	{
		int num = this.sky.LADANCDAELM ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.OMMFMKFGCBB.volume = Mathf.Lerp(1494f, this.FEKAJAMOEKC, this.EMJJFHGGBMK);
	}

	// Token: 0x06002B23 RID: 11043 RVA: 0x00142634 File Offset: 0x00140834
	protected void CBBLGEDCJBF()
	{
		int num = this.sky.LADANCDAELM ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.OMMFMKFGCBB.volume = Mathf.Lerp(1866f, this.FEKAJAMOEKC, this.EMJJFHGGBMK);
	}

	// Token: 0x06002B24 RID: 11044 RVA: 0x00142698 File Offset: 0x00140898
	protected void ONIHHFLOJMN()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (!this.sky.LADANCDAELM)
		{
			this.OMMFMKFGCBB.volume = 1507f;
		}
	}

	// Token: 0x06002B25 RID: 11045 RVA: 0x001426F8 File Offset: 0x001408F8
	protected void FJEEADNCKAG()
	{
		int num = this.sky.LADANCDAELM ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.OMMFMKFGCBB.volume = Mathf.Lerp(77f, this.FEKAJAMOEKC, this.EMJJFHGGBMK);
	}

	// Token: 0x06002B26 RID: 11046 RVA: 0x0014275C File Offset: 0x0014095C
	protected void IEOICHPKEMD()
	{
		int num = this.sky.LADANCDAELM ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.OMMFMKFGCBB.volume = Mathf.Lerp(75f, this.FEKAJAMOEKC, this.EMJJFHGGBMK);
	}

	// Token: 0x06002B27 RID: 11047 RVA: 0x001427C0 File Offset: 0x001409C0
	protected void FFIGGPHAIBP()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (!this.sky.LADANCDAELM)
		{
			this.OMMFMKFGCBB.volume = 826f;
		}
	}

	// Token: 0x06002B28 RID: 11048 RVA: 0x00142820 File Offset: 0x00140A20
	protected void AKLFCMNCPKL()
	{
		int num = this.sky.LADANCDAELM ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.OMMFMKFGCBB.volume = Mathf.Lerp(81f, this.FEKAJAMOEKC, this.EMJJFHGGBMK);
	}

	// Token: 0x06002B29 RID: 11049 RVA: 0x00142884 File Offset: 0x00140A84
	protected void DHJDMKLBLEF()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (!this.sky.LADANCDAELM)
		{
			this.OMMFMKFGCBB.volume = 1021f;
		}
	}

	// Token: 0x06002B2A RID: 11050 RVA: 0x001428E4 File Offset: 0x00140AE4
	protected void NOKJMMDMJNO()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (!this.sky.LADANCDAELM)
		{
			this.OMMFMKFGCBB.volume = 202f;
		}
	}

	// Token: 0x06002B2B RID: 11051 RVA: 0x00142944 File Offset: 0x00140B44
	protected void AIAMIFEPALP()
	{
		int num = this.sky.LADANCDAELM ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.OMMFMKFGCBB.volume = Mathf.Lerp(634f, this.FEKAJAMOEKC, this.EMJJFHGGBMK);
	}

	// Token: 0x06002B2C RID: 11052 RVA: 0x001429A8 File Offset: 0x00140BA8
	protected void EFJDBBDMPMC()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (!this.sky.LADANCDAELM)
		{
			this.OMMFMKFGCBB.volume = 1836f;
		}
	}

	// Token: 0x06002B2D RID: 11053 RVA: 0x00142A08 File Offset: 0x00140C08
	protected void PMKOAHMNBBG()
	{
		int num = this.sky.LADANCDAELM ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.OMMFMKFGCBB.volume = Mathf.Lerp(30f, this.FEKAJAMOEKC, this.EMJJFHGGBMK);
	}

	// Token: 0x06002B2E RID: 11054 RVA: 0x00142A6C File Offset: 0x00140C6C
	protected void OPNPODKLOJK()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (!this.sky.LADANCDAELM)
		{
			this.OMMFMKFGCBB.volume = 1580f;
		}
	}

	// Token: 0x06002B2F RID: 11055 RVA: 0x00142ACC File Offset: 0x00140CCC
	protected void ANHOOJFEJJE()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (!this.sky.LADANCDAELM)
		{
			this.OMMFMKFGCBB.volume = 174f;
		}
	}

	// Token: 0x06002B30 RID: 11056 RVA: 0x00142B2C File Offset: 0x00140D2C
	protected void PJHEGHHOJHJ()
	{
		int num = this.sky.LADANCDAELM ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.OMMFMKFGCBB.volume = Mathf.Lerp(446f, this.FEKAJAMOEKC, this.EMJJFHGGBMK);
	}

	// Token: 0x06002B31 RID: 11057 RVA: 0x00142B90 File Offset: 0x00140D90
	protected void GDIMBBBPIHI()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (!this.sky.LADANCDAELM)
		{
			this.OMMFMKFGCBB.volume = 753f;
		}
	}

	// Token: 0x06002B32 RID: 11058 RVA: 0x00142BF0 File Offset: 0x00140DF0
	protected void AIFIEAGFIMM()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (!this.sky.LADANCDAELM)
		{
			this.OMMFMKFGCBB.volume = 73f;
		}
	}

	// Token: 0x06002B33 RID: 11059 RVA: 0x00142C50 File Offset: 0x00140E50
	protected void DEGCCLNOEKJ()
	{
		int num = this.sky.LADANCDAELM ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.OMMFMKFGCBB.volume = Mathf.Lerp(1237f, this.FEKAJAMOEKC, this.EMJJFHGGBMK);
	}

	// Token: 0x06002B34 RID: 11060 RVA: 0x00142CB4 File Offset: 0x00140EB4
	protected void LDDIGEMBDNF()
	{
		int num = this.sky.LADANCDAELM ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.OMMFMKFGCBB.volume = Mathf.Lerp(1989f, this.FEKAJAMOEKC, this.EMJJFHGGBMK);
	}

	// Token: 0x06002B35 RID: 11061 RVA: 0x00142D18 File Offset: 0x00140F18
	protected void EDGALMCHPPH()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (!this.sky.LADANCDAELM)
		{
			this.OMMFMKFGCBB.volume = 414f;
		}
	}

	// Token: 0x06002B36 RID: 11062 RVA: 0x00142D78 File Offset: 0x00140F78
	protected void LMEJKAEIDCO()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (!this.sky.LADANCDAELM)
		{
			this.OMMFMKFGCBB.volume = 433f;
		}
	}

	// Token: 0x06002B37 RID: 11063 RVA: 0x00142DD8 File Offset: 0x00140FD8
	protected void PFNOEACNHON()
	{
		int num = this.sky.LADANCDAELM ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.OMMFMKFGCBB.volume = Mathf.Lerp(480f, this.FEKAJAMOEKC, this.EMJJFHGGBMK);
	}

	// Token: 0x06002B38 RID: 11064 RVA: 0x00142E3C File Offset: 0x0014103C
	protected void HHGGCBLOJGB()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (!this.sky.LADANCDAELM)
		{
			this.OMMFMKFGCBB.volume = 405f;
		}
	}

	// Token: 0x06002B39 RID: 11065 RVA: 0x00142E9C File Offset: 0x0014109C
	protected void CGFDDFHECLJ()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (!this.sky.LADANCDAELM)
		{
			this.OMMFMKFGCBB.volume = 594f;
		}
	}

	// Token: 0x06002B3A RID: 11066 RVA: 0x00142EFC File Offset: 0x001410FC
	protected void PNAAHEFHPCL()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (!this.sky.LADANCDAELM)
		{
			this.OMMFMKFGCBB.volume = 908f;
		}
	}

	// Token: 0x06002B3B RID: 11067 RVA: 0x00142F5C File Offset: 0x0014115C
	protected void JPHLMNIMDHH()
	{
		int num = this.sky.LADANCDAELM ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.OMMFMKFGCBB.volume = Mathf.Lerp(14f, this.FEKAJAMOEKC, this.EMJJFHGGBMK);
	}

	// Token: 0x06002B3C RID: 11068 RVA: 0x00142FC0 File Offset: 0x001411C0
	protected void MODJFGGIAHD()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (!this.sky.LADANCDAELM)
		{
			this.OMMFMKFGCBB.volume = 1395f;
		}
	}

	// Token: 0x06002B3D RID: 11069 RVA: 0x00143020 File Offset: 0x00141220
	protected void EHDPACPIBNF()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (!this.sky.LADANCDAELM)
		{
			this.OMMFMKFGCBB.volume = 1092f;
		}
	}

	// Token: 0x06002B3E RID: 11070 RVA: 0x00143080 File Offset: 0x00141280
	protected void NCALLFHEAGJ()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (!this.sky.LADANCDAELM)
		{
			this.OMMFMKFGCBB.volume = 919f;
		}
	}

	// Token: 0x06002B3F RID: 11071 RVA: 0x001430E0 File Offset: 0x001412E0
	protected void EMFOECIPBIP()
	{
		int num = this.sky.LADANCDAELM ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.OMMFMKFGCBB.volume = Mathf.Lerp(1091f, this.FEKAJAMOEKC, this.EMJJFHGGBMK);
	}

	// Token: 0x06002B40 RID: 11072 RVA: 0x00143144 File Offset: 0x00141344
	protected void EMHGNEMIGII()
	{
		int num = this.sky.LADANCDAELM ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.OMMFMKFGCBB.volume = Mathf.Lerp(1922f, this.FEKAJAMOEKC, this.EMJJFHGGBMK);
	}

	// Token: 0x06002B41 RID: 11073 RVA: 0x001431A8 File Offset: 0x001413A8
	protected void CGMHGDEKDEP()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (!this.sky.LADANCDAELM)
		{
			this.OMMFMKFGCBB.volume = 603f;
		}
	}

	// Token: 0x06002B42 RID: 11074 RVA: 0x00143208 File Offset: 0x00141408
	protected void DFFOEGHGPGP()
	{
		int num = this.sky.LADANCDAELM ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.OMMFMKFGCBB.volume = Mathf.Lerp(1770f, this.FEKAJAMOEKC, this.EMJJFHGGBMK);
	}

	// Token: 0x06002B43 RID: 11075 RVA: 0x0014326C File Offset: 0x0014146C
	protected void AAEFACEGJMB()
	{
		int num = this.sky.LADANCDAELM ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.OMMFMKFGCBB.volume = Mathf.Lerp(462f, this.FEKAJAMOEKC, this.EMJJFHGGBMK);
	}

	// Token: 0x06002B44 RID: 11076 RVA: 0x001432D0 File Offset: 0x001414D0
	protected void BJHGPFGBFKF()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (!this.sky.LADANCDAELM)
		{
			this.OMMFMKFGCBB.volume = 1809f;
		}
	}

	// Token: 0x06002B45 RID: 11077 RVA: 0x00143330 File Offset: 0x00141530
	protected void PBMPJPIMJBF()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (!this.sky.LADANCDAELM)
		{
			this.OMMFMKFGCBB.volume = 1395f;
		}
	}

	// Token: 0x06002B46 RID: 11078 RVA: 0x00143390 File Offset: 0x00141590
	protected void GCNGEFBKMNC()
	{
		int num = this.sky.LADANCDAELM ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.OMMFMKFGCBB.volume = Mathf.Lerp(716f, this.FEKAJAMOEKC, this.EMJJFHGGBMK);
	}

	// Token: 0x06002B47 RID: 11079 RVA: 0x001433F4 File Offset: 0x001415F4
	protected void FOHLAIIMNFB()
	{
		int num = this.sky.LADANCDAELM ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.OMMFMKFGCBB.volume = Mathf.Lerp(193f, this.FEKAJAMOEKC, this.EMJJFHGGBMK);
	}

	// Token: 0x06002B48 RID: 11080 RVA: 0x00143458 File Offset: 0x00141658
	protected void CJHBCHBOLBI()
	{
		int num = this.sky.LADANCDAELM ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.OMMFMKFGCBB.volume = Mathf.Lerp(788f, this.FEKAJAMOEKC, this.EMJJFHGGBMK);
	}

	// Token: 0x06002B49 RID: 11081 RVA: 0x001434BC File Offset: 0x001416BC
	protected void LBGKAMLLACN()
	{
		int num = this.sky.LADANCDAELM ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.OMMFMKFGCBB.volume = Mathf.Lerp(656f, this.FEKAJAMOEKC, this.EMJJFHGGBMK);
	}

	// Token: 0x06002B4B RID: 11083 RVA: 0x00143530 File Offset: 0x00141730
	protected void IOGAKGCADBL()
	{
		int num = this.sky.LADANCDAELM ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.OMMFMKFGCBB.volume = Mathf.Lerp(1806f, this.FEKAJAMOEKC, this.EMJJFHGGBMK);
	}

	// Token: 0x06002B4C RID: 11084 RVA: 0x00143594 File Offset: 0x00141794
	protected void KGICJDGIIJK()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (!this.sky.LADANCDAELM)
		{
			this.OMMFMKFGCBB.volume = 1231f;
		}
	}

	// Token: 0x06002B4D RID: 11085 RVA: 0x001435F4 File Offset: 0x001417F4
	protected void CLHGHANANNL()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (!this.sky.LADANCDAELM)
		{
			this.OMMFMKFGCBB.volume = 641f;
		}
	}

	// Token: 0x06002B4E RID: 11086 RVA: 0x00143654 File Offset: 0x00141854
	protected void CPNOBMNKPNC()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (!this.sky.LADANCDAELM)
		{
			this.OMMFMKFGCBB.volume = 1136f;
		}
	}

	// Token: 0x06002B4F RID: 11087 RVA: 0x001436B4 File Offset: 0x001418B4
	protected void OBJCOJEHLBE()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (!this.sky.LADANCDAELM)
		{
			this.OMMFMKFGCBB.volume = 1846f;
		}
	}

	// Token: 0x06002B50 RID: 11088 RVA: 0x00143714 File Offset: 0x00141914
	protected void KKCFKEDABLB()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (!this.sky.LADANCDAELM)
		{
			this.OMMFMKFGCBB.volume = 351f;
		}
	}

	// Token: 0x06002B51 RID: 11089 RVA: 0x00143774 File Offset: 0x00141974
	protected void JLFBDOPFDDJ()
	{
		int num = this.sky.LADANCDAELM ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.OMMFMKFGCBB.volume = Mathf.Lerp(1693f, this.FEKAJAMOEKC, this.EMJJFHGGBMK);
	}

	// Token: 0x06002B52 RID: 11090 RVA: 0x001437D8 File Offset: 0x001419D8
	protected void Start()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (!this.sky.LADANCDAELM)
		{
			this.OMMFMKFGCBB.volume = 0f;
		}
	}

	// Token: 0x06002B53 RID: 11091 RVA: 0x00143838 File Offset: 0x00141A38
	protected void DGEIACONKCJ()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (!this.sky.LADANCDAELM)
		{
			this.OMMFMKFGCBB.volume = 485f;
		}
	}

	// Token: 0x06002B54 RID: 11092 RVA: 0x00143898 File Offset: 0x00141A98
	protected void EHFPLKEINFO()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (!this.sky.LADANCDAELM)
		{
			this.OMMFMKFGCBB.volume = 1163f;
		}
	}

	// Token: 0x06002B55 RID: 11093 RVA: 0x001438F8 File Offset: 0x00141AF8
	protected void MEFOGCFJBNE()
	{
		int num = this.sky.LADANCDAELM ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.OMMFMKFGCBB.volume = Mathf.Lerp(1956f, this.FEKAJAMOEKC, this.EMJJFHGGBMK);
	}

	// Token: 0x06002B56 RID: 11094 RVA: 0x0014395C File Offset: 0x00141B5C
	protected void AMDMCKIFBPA()
	{
		int num = this.sky.LADANCDAELM ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.OMMFMKFGCBB.volume = Mathf.Lerp(139f, this.FEKAJAMOEKC, this.EMJJFHGGBMK);
	}

	// Token: 0x06002B57 RID: 11095 RVA: 0x001439C0 File Offset: 0x00141BC0
	protected void KFGKKLAKFGH()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.OMMFMKFGCBB = base.GetComponent<AudioSource>();
		this.FEKAJAMOEKC = this.OMMFMKFGCBB.volume;
		if (!this.sky.LADANCDAELM)
		{
			this.OMMFMKFGCBB.volume = 1882f;
		}
	}

	// Token: 0x040005E7 RID: 1511
	public TOD_Sky sky;

	// Token: 0x040005E8 RID: 1512
	public float fadeTime = 1f;

	// Token: 0x040005E9 RID: 1513
	private float EMJJFHGGBMK;

	// Token: 0x040005EA RID: 1514
	private AudioSource OMMFMKFGCBB;

	// Token: 0x040005EB RID: 1515
	private float FEKAJAMOEKC;
}
