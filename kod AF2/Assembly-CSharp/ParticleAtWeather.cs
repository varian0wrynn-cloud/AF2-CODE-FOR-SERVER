using System;
using UnityEngine;

// Token: 0x020000ED RID: 237
[RequireComponent(typeof(ParticleSystem))]
public class ParticleAtWeather : MonoBehaviour
{
	// Token: 0x06002C63 RID: 11363 RVA: 0x00147581 File Offset: 0x00145781
	protected void LMEJKAEIDCO()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C64 RID: 11364 RVA: 0x001475B8 File Offset: 0x001457B8
	protected void CJHBCHBOLBI()
	{
		int num = (this.sky.KMBOELAHKHL().PHLAGOLHIMB.Weather == this.type) ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(1276f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C65 RID: 11365 RVA: 0x0014762C File Offset: 0x0014582C
	protected void AMDMCKIFBPA()
	{
		int num = (this.sky.KMBOELAHKHL().PHLAGOLHIMB.Weather == this.type) ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(1815f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C66 RID: 11366 RVA: 0x00147581 File Offset: 0x00145781
	protected void ANHOOJFEJJE()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C67 RID: 11367 RVA: 0x001476A0 File Offset: 0x001458A0
	protected void Update()
	{
		int num = (this.sky.NINFILJKEFA.PHLAGOLHIMB.Weather == this.type) ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(0f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C68 RID: 11368 RVA: 0x00147581 File Offset: 0x00145781
	protected void EDGALMCHPPH()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C69 RID: 11369 RVA: 0x00147714 File Offset: 0x00145914
	protected void BOAJJAKEMLH()
	{
		int num = (this.sky.NINFILJKEFA.PHLAGOLHIMB.Weather == this.type) ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(725f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C6A RID: 11370 RVA: 0x00147788 File Offset: 0x00145988
	protected void IOGAKGCADBL()
	{
		int num = (this.sky.NINFILJKEFA.PHLAGOLHIMB.Weather == this.type) ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(936f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C6C RID: 11372 RVA: 0x0014780C File Offset: 0x00145A0C
	protected void CBBLGEDCJBF()
	{
		int num = (this.sky.KMBOELAHKHL().PHLAGOLHIMB.Weather == this.type) ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(1319f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C6D RID: 11373 RVA: 0x00147581 File Offset: 0x00145781
	protected void NCALLFHEAGJ()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C6E RID: 11374 RVA: 0x00147880 File Offset: 0x00145A80
	protected void JLFBDOPFDDJ()
	{
		int num = (this.sky.NINFILJKEFA.PHLAGOLHIMB.Weather == this.type) ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(621f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C6F RID: 11375 RVA: 0x00147581 File Offset: 0x00145781
	protected void OFGMIEJKMGC()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C70 RID: 11376 RVA: 0x001478F4 File Offset: 0x00145AF4
	protected void LDDIGEMBDNF()
	{
		int num = (this.sky.NINFILJKEFA.PHLAGOLHIMB.Weather == this.type) ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(656f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C71 RID: 11377 RVA: 0x00147968 File Offset: 0x00145B68
	protected void AIAMIFEPALP()
	{
		int num = (this.sky.NINFILJKEFA.PHLAGOLHIMB.Weather == this.type) ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(843f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C72 RID: 11378 RVA: 0x00147581 File Offset: 0x00145781
	protected void KEMGOLACEHI()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C73 RID: 11379 RVA: 0x00147581 File Offset: 0x00145781
	protected void IIKDDILLGLF()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C74 RID: 11380 RVA: 0x001479DC File Offset: 0x00145BDC
	protected void HAIMGCDKPDC()
	{
		int num = (this.sky.KMBOELAHKHL().PHLAGOLHIMB.Weather == this.type) ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(134f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C75 RID: 11381 RVA: 0x00147581 File Offset: 0x00145781
	protected void Start()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C76 RID: 11382 RVA: 0x00147A50 File Offset: 0x00145C50
	protected void FJEEADNCKAG()
	{
		int num = (this.sky.NINFILJKEFA.PHLAGOLHIMB.Weather == this.type) ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(409f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C77 RID: 11383 RVA: 0x00147AC4 File Offset: 0x00145CC4
	protected void LBGKAMLLACN()
	{
		int num = (this.sky.KMBOELAHKHL().PHLAGOLHIMB.Weather == this.type) ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(654f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C78 RID: 11384 RVA: 0x00147B38 File Offset: 0x00145D38
	protected void KMLNBHIIGKH()
	{
		int num = (this.sky.KMBOELAHKHL().PHLAGOLHIMB.Weather == this.type) ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(867f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C79 RID: 11385 RVA: 0x00147BAC File Offset: 0x00145DAC
	protected void OHKHOAKCENL()
	{
		int num = (this.sky.KMBOELAHKHL().PHLAGOLHIMB.Weather == this.type) ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(745f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C7A RID: 11386 RVA: 0x00147C20 File Offset: 0x00145E20
	protected void PMKOAHMNBBG()
	{
		int num = (this.sky.KMBOELAHKHL().PHLAGOLHIMB.Weather == this.type) ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(431f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C7B RID: 11387 RVA: 0x00147C94 File Offset: 0x00145E94
	protected void OFPGMNGFLNH()
	{
		int num = (this.sky.KMBOELAHKHL().PHLAGOLHIMB.Weather == this.type) ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(625f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C7C RID: 11388 RVA: 0x00147D08 File Offset: 0x00145F08
	protected void JPHLMNIMDHH()
	{
		int num = (this.sky.NINFILJKEFA.PHLAGOLHIMB.Weather == this.type) ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(603f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C7D RID: 11389 RVA: 0x00147581 File Offset: 0x00145781
	protected void MCHAAIIHOKD()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C7E RID: 11390 RVA: 0x00147D7C File Offset: 0x00145F7C
	protected void OPDCJCFMIPE()
	{
		int num = (this.sky.KMBOELAHKHL().PHLAGOLHIMB.Weather == this.type) ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(1166f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C7F RID: 11391 RVA: 0x00147DF0 File Offset: 0x00145FF0
	protected void PFPPDNHLCCA()
	{
		int num = (this.sky.KMBOELAHKHL().PHLAGOLHIMB.Weather == this.type) ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(679f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C80 RID: 11392 RVA: 0x00147E64 File Offset: 0x00146064
	protected void LMMDHJJJNJO()
	{
		int num = (this.sky.KMBOELAHKHL().PHLAGOLHIMB.Weather == this.type) ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(710f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C81 RID: 11393 RVA: 0x00147ED8 File Offset: 0x001460D8
	protected void BJOICAKCPLI()
	{
		int num = (this.sky.KMBOELAHKHL().PHLAGOLHIMB.Weather == this.type) ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(1489f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C82 RID: 11394 RVA: 0x00147581 File Offset: 0x00145781
	protected void BMNJGPIPKLL()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x0400060E RID: 1550
	public TOD_Sky sky;

	// Token: 0x0400060F RID: 1551
	public JPFPFIFAEKJ type;

	// Token: 0x04000610 RID: 1552
	public float fadeTime = 1f;

	// Token: 0x04000611 RID: 1553
	private float EMJJFHGGBMK;

	// Token: 0x04000612 RID: 1554
	private ParticleSystem FHAJLOBLOMA;

	// Token: 0x04000613 RID: 1555
	private float HKLFMDAAFCA;
}
