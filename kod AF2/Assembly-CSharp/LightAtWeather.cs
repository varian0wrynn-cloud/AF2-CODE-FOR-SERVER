using System;
using UnityEngine;

// Token: 0x020000E9 RID: 233
[RequireComponent(typeof(Light))]
public class LightAtWeather : MonoBehaviour
{
	// Token: 0x06002BBD RID: 11197 RVA: 0x00145588 File Offset: 0x00143788
	protected void AMDMCKIFBPA()
	{
		int num = (this.sky.NINFILJKEFA.PHLAGOLHIMB.Weather == this.type) ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(299f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 1363f);
	}

	// Token: 0x06002BBE RID: 11198 RVA: 0x00145616 File Offset: 0x00143816
	protected void BMNJGPIPKLL()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002BBF RID: 11199 RVA: 0x00145650 File Offset: 0x00143850
	protected void Update()
	{
		int num = (this.sky.NINFILJKEFA.PHLAGOLHIMB.Weather == this.type) ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(0f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 0f);
	}

	// Token: 0x06002BC0 RID: 11200 RVA: 0x001456E0 File Offset: 0x001438E0
	protected void CJHBCHBOLBI()
	{
		int num = (this.sky.KMBOELAHKHL().PHLAGOLHIMB.Weather == this.type) ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(297f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 35f);
	}

	// Token: 0x06002BC1 RID: 11201 RVA: 0x00145770 File Offset: 0x00143970
	protected void KJJBBLDJHPD()
	{
		int num = (this.sky.KMBOELAHKHL().PHLAGOLHIMB.Weather == this.type) ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(455f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 1800f);
	}

	// Token: 0x06002BC2 RID: 11202 RVA: 0x00145616 File Offset: 0x00143816
	protected void ELFLOPJDAKK()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002BC3 RID: 11203 RVA: 0x00145616 File Offset: 0x00143816
	protected void KEMGOLACEHI()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002BC4 RID: 11204 RVA: 0x00145616 File Offset: 0x00143816
	protected void FPLHODJCJDO()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002BC5 RID: 11205 RVA: 0x00145616 File Offset: 0x00143816
	protected void CPNOBMNKPNC()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002BC6 RID: 11206 RVA: 0x00145616 File Offset: 0x00143816
	protected void HDFCIACDDEK()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002BC7 RID: 11207 RVA: 0x00145800 File Offset: 0x00143A00
	protected void JPHLMNIMDHH()
	{
		int num = (this.sky.NINFILJKEFA.PHLAGOLHIMB.Weather == this.type) ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(1608f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 1540f);
	}

	// Token: 0x06002BC8 RID: 11208 RVA: 0x00145890 File Offset: 0x00143A90
	protected void PJHEGHHOJHJ()
	{
		int num = (this.sky.NINFILJKEFA.PHLAGOLHIMB.Weather == this.type) ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(744f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 952f);
	}

	// Token: 0x06002BC9 RID: 11209 RVA: 0x00145920 File Offset: 0x00143B20
	protected void JLFBDOPFDDJ()
	{
		int num = (this.sky.NINFILJKEFA.PHLAGOLHIMB.Weather == this.type) ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(659f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 1278f);
	}

	// Token: 0x06002BCA RID: 11210 RVA: 0x00145616 File Offset: 0x00143816
	protected void INDGOHJGCFN()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002BCB RID: 11211 RVA: 0x00145616 File Offset: 0x00143816
	protected void Start()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002BCC RID: 11212 RVA: 0x00145616 File Offset: 0x00143816
	protected void OFGMIEJKMGC()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002BCD RID: 11213 RVA: 0x00145616 File Offset: 0x00143816
	protected void CBLGFOFHNPJ()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002BCF RID: 11215 RVA: 0x001459C4 File Offset: 0x00143BC4
	protected void OHKHOAKCENL()
	{
		int num = (this.sky.KMBOELAHKHL().PHLAGOLHIMB.Weather == this.type) ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(342f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 37f);
	}

	// Token: 0x06002BD0 RID: 11216 RVA: 0x00145A54 File Offset: 0x00143C54
	protected void BJOICAKCPLI()
	{
		int num = (this.sky.NINFILJKEFA.PHLAGOLHIMB.Weather == this.type) ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(1047f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 1007f);
	}

	// Token: 0x06002BD1 RID: 11217 RVA: 0x00145616 File Offset: 0x00143816
	protected void EHFPLKEINFO()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002BD2 RID: 11218 RVA: 0x00145AE4 File Offset: 0x00143CE4
	protected void IGEICBNMPAD()
	{
		int num = (this.sky.NINFILJKEFA.PHLAGOLHIMB.Weather == this.type) ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(477f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 1620f);
	}

	// Token: 0x06002BD3 RID: 11219 RVA: 0x00145B74 File Offset: 0x00143D74
	protected void OFPGMNGFLNH()
	{
		int num = (this.sky.KMBOELAHKHL().PHLAGOLHIMB.Weather == this.type) ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(95f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 1527f);
	}

	// Token: 0x06002BD4 RID: 11220 RVA: 0x00145616 File Offset: 0x00143816
	protected void LMEJKAEIDCO()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002BD5 RID: 11221 RVA: 0x00145616 File Offset: 0x00143816
	protected void AOCDDBNBADJ()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002BD6 RID: 11222 RVA: 0x00145C04 File Offset: 0x00143E04
	protected void FJEEADNCKAG()
	{
		int num = (this.sky.KMBOELAHKHL().PHLAGOLHIMB.Weather == this.type) ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(1107f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 1775f);
	}

	// Token: 0x06002BD7 RID: 11223 RVA: 0x00145C94 File Offset: 0x00143E94
	protected void PMKOAHMNBBG()
	{
		int num = (this.sky.KMBOELAHKHL().PHLAGOLHIMB.Weather == this.type) ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(1622f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 551f);
	}

	// Token: 0x06002BD8 RID: 11224 RVA: 0x00145616 File Offset: 0x00143816
	protected void ANHOOJFEJJE()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002BD9 RID: 11225 RVA: 0x00145616 File Offset: 0x00143816
	protected void ONIHHFLOJMN()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002BDA RID: 11226 RVA: 0x00145D24 File Offset: 0x00143F24
	protected void HMEAENGBFKC()
	{
		int num = (this.sky.KMBOELAHKHL().PHLAGOLHIMB.Weather == this.type) ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(243f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 841f);
	}

	// Token: 0x040005FC RID: 1532
	public TOD_Sky sky;

	// Token: 0x040005FD RID: 1533
	public JPFPFIFAEKJ type;

	// Token: 0x040005FE RID: 1534
	public float fadeTime = 1f;

	// Token: 0x040005FF RID: 1535
	private float EMJJFHGGBMK;

	// Token: 0x04000600 RID: 1536
	private Light KGGCLGADNIM;

	// Token: 0x04000601 RID: 1537
	private float PFPFCIIIANB;
}
