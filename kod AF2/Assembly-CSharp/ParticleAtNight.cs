using System;
using UnityEngine;

// Token: 0x020000EC RID: 236
[RequireComponent(typeof(ParticleSystem))]
public class ParticleAtNight : MonoBehaviour
{
	// Token: 0x06002C3B RID: 11323 RVA: 0x00146D09 File Offset: 0x00144F09
	protected void MKNPFMEMOJO()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C3C RID: 11324 RVA: 0x00146D40 File Offset: 0x00144F40
	protected void FJEEADNCKAG()
	{
		int num = this.sky.LADANCDAELM ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(1775f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C3D RID: 11325 RVA: 0x00146D09 File Offset: 0x00144F09
	protected void EDGALMCHPPH()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C3E RID: 11326 RVA: 0x00146D09 File Offset: 0x00144F09
	protected void Start()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C3F RID: 11327 RVA: 0x00146D09 File Offset: 0x00144F09
	protected void ELFLOPJDAKK()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C40 RID: 11328 RVA: 0x00146D09 File Offset: 0x00144F09
	protected void IIKDDILLGLF()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C41 RID: 11329 RVA: 0x00146DA4 File Offset: 0x00144FA4
	protected void CJHBCHBOLBI()
	{
		int num = this.sky.LADANCDAELM ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(344f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C42 RID: 11330 RVA: 0x00146D09 File Offset: 0x00144F09
	protected void DGEIACONKCJ()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C44 RID: 11332 RVA: 0x00146E18 File Offset: 0x00145018
	protected void KMLNBHIIGKH()
	{
		int num = this.sky.LADANCDAELM ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(725f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C45 RID: 11333 RVA: 0x00146E7C File Offset: 0x0014507C
	protected void JPHLMNIMDHH()
	{
		int num = this.sky.LADANCDAELM ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(1744f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C46 RID: 11334 RVA: 0x00146D09 File Offset: 0x00144F09
	protected void KEMGOLACEHI()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C47 RID: 11335 RVA: 0x00146EE0 File Offset: 0x001450E0
	protected void OPDCJCFMIPE()
	{
		int num = this.sky.LADANCDAELM ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(1506f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C48 RID: 11336 RVA: 0x00146F44 File Offset: 0x00145144
	protected void IOGAKGCADBL()
	{
		int num = this.sky.LADANCDAELM ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(1351f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C49 RID: 11337 RVA: 0x00146D09 File Offset: 0x00144F09
	protected void NCALLFHEAGJ()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C4A RID: 11338 RVA: 0x00146D09 File Offset: 0x00144F09
	protected void OFGMIEJKMGC()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C4B RID: 11339 RVA: 0x00146FA8 File Offset: 0x001451A8
	protected void LIOCDEICIFD()
	{
		int num = this.sky.LADANCDAELM ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(1300f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C4C RID: 11340 RVA: 0x0014700C File Offset: 0x0014520C
	protected void PFPPDNHLCCA()
	{
		int num = this.sky.LADANCDAELM ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(1405f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C4D RID: 11341 RVA: 0x00147070 File Offset: 0x00145270
	protected void LBGKAMLLACN()
	{
		int num = this.sky.LADANCDAELM ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(507f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C4E RID: 11342 RVA: 0x001470D4 File Offset: 0x001452D4
	protected void OHKHOAKCENL()
	{
		int num = this.sky.LADANCDAELM ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(553f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C4F RID: 11343 RVA: 0x00146D09 File Offset: 0x00144F09
	protected void IAAOGAPJDID()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C50 RID: 11344 RVA: 0x00147138 File Offset: 0x00145338
	protected void AMDMCKIFBPA()
	{
		int num = this.sky.LADANCDAELM ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(1052f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C51 RID: 11345 RVA: 0x0014719C File Offset: 0x0014539C
	protected void PJHEGHHOJHJ()
	{
		int num = this.sky.LADANCDAELM ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(1382f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C52 RID: 11346 RVA: 0x00147200 File Offset: 0x00145400
	protected void FPLNDDMFFKG()
	{
		int num = this.sky.LADANCDAELM ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(69f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C53 RID: 11347 RVA: 0x00146D09 File Offset: 0x00144F09
	protected void AOCDDBNBADJ()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C54 RID: 11348 RVA: 0x00146D09 File Offset: 0x00144F09
	protected void FIJKDFIMELM()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C55 RID: 11349 RVA: 0x00146D09 File Offset: 0x00144F09
	protected void KFGKKLAKFGH()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C56 RID: 11350 RVA: 0x00147264 File Offset: 0x00145464
	protected void OFPGMNGFLNH()
	{
		int num = this.sky.LADANCDAELM ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(875f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C57 RID: 11351 RVA: 0x00146D09 File Offset: 0x00144F09
	protected void ANHOOJFEJJE()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C58 RID: 11352 RVA: 0x001472C8 File Offset: 0x001454C8
	protected void CBBLGEDCJBF()
	{
		int num = this.sky.LADANCDAELM ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(408f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C59 RID: 11353 RVA: 0x0014732C File Offset: 0x0014552C
	protected void DPGECEOMHNM()
	{
		int num = this.sky.LADANCDAELM ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(1724f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C5A RID: 11354 RVA: 0x00146D09 File Offset: 0x00144F09
	protected void AFFAJKPPMHF()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C5B RID: 11355 RVA: 0x00147390 File Offset: 0x00145590
	protected void MFHGOLNLAAF()
	{
		int num = this.sky.LADANCDAELM ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(450f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C5C RID: 11356 RVA: 0x001473F4 File Offset: 0x001455F4
	protected void LDDIGEMBDNF()
	{
		int num = this.sky.LADANCDAELM ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(364f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C5D RID: 11357 RVA: 0x00146D09 File Offset: 0x00144F09
	protected void ONIHHFLOJMN()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C5E RID: 11358 RVA: 0x00147458 File Offset: 0x00145658
	protected void Update()
	{
		int num = this.sky.LADANCDAELM ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(0f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C5F RID: 11359 RVA: 0x00146D09 File Offset: 0x00144F09
	protected void HHGGCBLOJGB()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C60 RID: 11360 RVA: 0x001474BC File Offset: 0x001456BC
	protected void BNKJNBIDPME()
	{
		int num = this.sky.LADANCDAELM ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(708f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C61 RID: 11361 RVA: 0x00147520 File Offset: 0x00145720
	protected void PNBGJBMJLFM()
	{
		int num = this.sky.LADANCDAELM ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(151f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C62 RID: 11362 RVA: 0x00146D09 File Offset: 0x00144F09
	protected void KGICJDGIIJK()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x04000609 RID: 1545
	public TOD_Sky sky;

	// Token: 0x0400060A RID: 1546
	public float fadeTime = 1f;

	// Token: 0x0400060B RID: 1547
	private float EMJJFHGGBMK;

	// Token: 0x0400060C RID: 1548
	private ParticleSystem FHAJLOBLOMA;

	// Token: 0x0400060D RID: 1549
	private float HKLFMDAAFCA;
}
