using System;
using UnityEngine;

// Token: 0x020000EB RID: 235
[RequireComponent(typeof(ParticleSystem))]
public class ParticleAtDay : MonoBehaviour
{
	// Token: 0x06002BE8 RID: 11240 RVA: 0x00145DF0 File Offset: 0x00143FF0
	protected void DPGECEOMHNM()
	{
		int num = this.sky.PKIKHLMJICN ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(379f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002BE9 RID: 11241 RVA: 0x00145E51 File Offset: 0x00144051
	protected void Start()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002BEA RID: 11242 RVA: 0x00145E88 File Offset: 0x00144088
	protected void IGEICBNMPAD()
	{
		int num = this.sky.PKIKHLMJICN ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(932f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002BEB RID: 11243 RVA: 0x00145EEC File Offset: 0x001440EC
	protected void KJJBBLDJHPD()
	{
		int num = this.sky.PKIKHLMJICN ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(987f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002BEC RID: 11244 RVA: 0x00145F50 File Offset: 0x00144150
	protected void LMMDHJJJNJO()
	{
		int num = this.sky.PKIKHLMJICN ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(817f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002BED RID: 11245 RVA: 0x00145FB4 File Offset: 0x001441B4
	protected void HCDJABMBDFF()
	{
		int num = this.sky.PKIKHLMJICN ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(142f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002BEE RID: 11246 RVA: 0x00145E51 File Offset: 0x00144051
	protected void CGFDDFHECLJ()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002BEF RID: 11247 RVA: 0x00145E51 File Offset: 0x00144051
	protected void LHJCHPFKGDB()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002BF0 RID: 11248 RVA: 0x00146018 File Offset: 0x00144218
	protected void FJEEADNCKAG()
	{
		int num = this.sky.PKIKHLMJICN ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(143f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002BF1 RID: 11249 RVA: 0x0014607C File Offset: 0x0014427C
	protected void MEFOGCFJBNE()
	{
		int num = this.sky.PKIKHLMJICN ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(740f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002BF2 RID: 11250 RVA: 0x00145E51 File Offset: 0x00144051
	protected void BMNJGPIPKLL()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002BF3 RID: 11251 RVA: 0x001460E0 File Offset: 0x001442E0
	protected void AIAMIFEPALP()
	{
		int num = this.sky.PKIKHLMJICN ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(10f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002BF4 RID: 11252 RVA: 0x00146144 File Offset: 0x00144344
	protected void IOGAKGCADBL()
	{
		int num = this.sky.PKIKHLMJICN ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(1066f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002BF5 RID: 11253 RVA: 0x001461A8 File Offset: 0x001443A8
	protected void GDBBAMFMKII()
	{
		int num = this.sky.PKIKHLMJICN ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(1879f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002BF6 RID: 11254 RVA: 0x0014620C File Offset: 0x0014440C
	protected void EMFOECIPBIP()
	{
		int num = this.sky.PKIKHLMJICN ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(1248f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002BF7 RID: 11255 RVA: 0x00145E51 File Offset: 0x00144051
	protected void JCELICPHGEP()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002BF8 RID: 11256 RVA: 0x00145E51 File Offset: 0x00144051
	protected void CAJLCEPLKJG()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002BF9 RID: 11257 RVA: 0x00145E51 File Offset: 0x00144051
	protected void GDIMBBBPIHI()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002BFA RID: 11258 RVA: 0x00145E51 File Offset: 0x00144051
	protected void EHDPACPIBNF()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002BFB RID: 11259 RVA: 0x00146270 File Offset: 0x00144470
	protected void MPLCAGFGEBO()
	{
		int num = this.sky.PKIKHLMJICN ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(1724f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002BFC RID: 11260 RVA: 0x001462D4 File Offset: 0x001444D4
	protected void DEGCCLNOEKJ()
	{
		int num = this.sky.PKIKHLMJICN ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(1224f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002BFD RID: 11261 RVA: 0x00146338 File Offset: 0x00144538
	protected void LFJHDHPJOPE()
	{
		int num = this.sky.PKIKHLMJICN ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(1469f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002BFE RID: 11262 RVA: 0x0014639C File Offset: 0x0014459C
	protected void PFPPDNHLCCA()
	{
		int num = this.sky.PKIKHLMJICN ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(1969f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002BFF RID: 11263 RVA: 0x00145E51 File Offset: 0x00144051
	protected void BJHGPFGBFKF()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C00 RID: 11264 RVA: 0x00146400 File Offset: 0x00144600
	protected void LBGKAMLLACN()
	{
		int num = this.sky.PKIKHLMJICN ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(1979f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C01 RID: 11265 RVA: 0x00145E51 File Offset: 0x00144051
	protected void CLHGHANANNL()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C02 RID: 11266 RVA: 0x00145E51 File Offset: 0x00144051
	protected void AFFAJKPPMHF()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C03 RID: 11267 RVA: 0x00145E51 File Offset: 0x00144051
	protected void KFGKKLAKFGH()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C04 RID: 11268 RVA: 0x00146464 File Offset: 0x00144664
	protected void HONIFOPBBKC()
	{
		int num = this.sky.PKIKHLMJICN ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(1270f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C05 RID: 11269 RVA: 0x001464C8 File Offset: 0x001446C8
	protected void BOAJJAKEMLH()
	{
		int num = this.sky.PKIKHLMJICN ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(845f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C06 RID: 11270 RVA: 0x00145E51 File Offset: 0x00144051
	protected void ANHOOJFEJJE()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C07 RID: 11271 RVA: 0x00145E51 File Offset: 0x00144051
	protected void PNJHMJNFPLP()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C08 RID: 11272 RVA: 0x00145E51 File Offset: 0x00144051
	protected void FECFLBMPAAL()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C09 RID: 11273 RVA: 0x0014652C File Offset: 0x0014472C
	protected void LACNPNKHCAA()
	{
		int num = this.sky.PKIKHLMJICN ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(1025f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C0A RID: 11274 RVA: 0x00145E51 File Offset: 0x00144051
	protected void HHGGCBLOJGB()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C0B RID: 11275 RVA: 0x00145E51 File Offset: 0x00144051
	protected void CGNGBFFGGBP()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C0C RID: 11276 RVA: 0x00146590 File Offset: 0x00144790
	protected void DFFOEGHGPGP()
	{
		int num = this.sky.PKIKHLMJICN ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(555f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C0D RID: 11277 RVA: 0x00145E51 File Offset: 0x00144051
	protected void BBFPILBIMKC()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C0E RID: 11278 RVA: 0x001465F4 File Offset: 0x001447F4
	protected void NMMGHFDLNOE()
	{
		int num = this.sky.PKIKHLMJICN ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(111f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C0F RID: 11279 RVA: 0x00146658 File Offset: 0x00144858
	protected void HAIMGCDKPDC()
	{
		int num = this.sky.PKIKHLMJICN ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(1579f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C10 RID: 11280 RVA: 0x001466BC File Offset: 0x001448BC
	protected void LBOONMDONCF()
	{
		int num = this.sky.PKIKHLMJICN ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(1130f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C11 RID: 11281 RVA: 0x00146720 File Offset: 0x00144920
	protected void PAKOHKKBKHD()
	{
		int num = this.sky.PKIKHLMJICN ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(1148f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C12 RID: 11282 RVA: 0x00145E51 File Offset: 0x00144051
	protected void FJGIBCHABIG()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C13 RID: 11283 RVA: 0x00146784 File Offset: 0x00144984
	protected void AKLFCMNCPKL()
	{
		int num = this.sky.PKIKHLMJICN ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(1188f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C14 RID: 11284 RVA: 0x00145E51 File Offset: 0x00144051
	protected void LMEJKAEIDCO()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C15 RID: 11285 RVA: 0x00145E51 File Offset: 0x00144051
	protected void CGMHGDEKDEP()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C16 RID: 11286 RVA: 0x001467E8 File Offset: 0x001449E8
	protected void HMEAENGBFKC()
	{
		int num = this.sky.PKIKHLMJICN ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(1160f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C17 RID: 11287 RVA: 0x00145E51 File Offset: 0x00144051
	protected void FIJKDFIMELM()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C18 RID: 11288 RVA: 0x00145E51 File Offset: 0x00144051
	protected void IJOCHELLKJH()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C1A RID: 11290 RVA: 0x00145E51 File Offset: 0x00144051
	protected void KKCFKEDABLB()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C1B RID: 11291 RVA: 0x0014685C File Offset: 0x00144A5C
	protected void Update()
	{
		int num = this.sky.PKIKHLMJICN ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(0f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C1C RID: 11292 RVA: 0x00145E51 File Offset: 0x00144051
	protected void PMDPLLIBJAF()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C1D RID: 11293 RVA: 0x00145E51 File Offset: 0x00144051
	protected void ADLHNBEDHMJ()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C1E RID: 11294 RVA: 0x00145E51 File Offset: 0x00144051
	protected void JLKBMEBFHBI()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C1F RID: 11295 RVA: 0x00145E51 File Offset: 0x00144051
	protected void PBMPJPIMJBF()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C20 RID: 11296 RVA: 0x00145E51 File Offset: 0x00144051
	protected void JHFAHBIIJDC()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C21 RID: 11297 RVA: 0x001468C0 File Offset: 0x00144AC0
	protected void KOLCEBEIHKP()
	{
		int num = this.sky.PKIKHLMJICN ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(1216f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C22 RID: 11298 RVA: 0x00145E51 File Offset: 0x00144051
	protected void FEBIICIMLHA()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C23 RID: 11299 RVA: 0x00145E51 File Offset: 0x00144051
	protected void KIEIPFFEDHC()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C24 RID: 11300 RVA: 0x00146924 File Offset: 0x00144B24
	protected void KBMKHLDOIKP()
	{
		int num = this.sky.PKIKHLMJICN ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(1168f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C25 RID: 11301 RVA: 0x00146988 File Offset: 0x00144B88
	protected void CBBLGEDCJBF()
	{
		int num = this.sky.PKIKHLMJICN ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(581f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C26 RID: 11302 RVA: 0x00145E51 File Offset: 0x00144051
	protected void HDFCIACDDEK()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C27 RID: 11303 RVA: 0x001469EC File Offset: 0x00144BEC
	protected void GCNGEFBKMNC()
	{
		int num = this.sky.PKIKHLMJICN ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(442f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C28 RID: 11304 RVA: 0x00145E51 File Offset: 0x00144051
	protected void IMABGALEMBI()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C29 RID: 11305 RVA: 0x00145E51 File Offset: 0x00144051
	protected void DDEBDCGNCPC()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C2A RID: 11306 RVA: 0x00145E51 File Offset: 0x00144051
	protected void MODJFGGIAHD()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C2B RID: 11307 RVA: 0x00145E51 File Offset: 0x00144051
	protected void DGDGMFDPEHO()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C2C RID: 11308 RVA: 0x00145E51 File Offset: 0x00144051
	protected void DHJDMKLBLEF()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C2D RID: 11309 RVA: 0x00145E51 File Offset: 0x00144051
	protected void DNLFEOECBKI()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C2E RID: 11310 RVA: 0x00145E51 File Offset: 0x00144051
	protected void LHHKDNILMDI()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C2F RID: 11311 RVA: 0x00145E51 File Offset: 0x00144051
	protected void CPNOBMNKPNC()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C30 RID: 11312 RVA: 0x00146A50 File Offset: 0x00144C50
	protected void DKOIOBMMAGN()
	{
		int num = this.sky.PKIKHLMJICN ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(921f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C31 RID: 11313 RVA: 0x00146AB4 File Offset: 0x00144CB4
	protected void PJHEGHHOJHJ()
	{
		int num = this.sky.PKIKHLMJICN ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(1178f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C32 RID: 11314 RVA: 0x00145E51 File Offset: 0x00144051
	protected void OBJCOJEHLBE()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C33 RID: 11315 RVA: 0x00145E51 File Offset: 0x00144051
	protected void OLBDJCFPKFG()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C34 RID: 11316 RVA: 0x00145E51 File Offset: 0x00144051
	protected void LPNDCJKAKEA()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C35 RID: 11317 RVA: 0x00146B18 File Offset: 0x00144D18
	protected void HMLNMHOMMNO()
	{
		int num = this.sky.PKIKHLMJICN ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(954f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C36 RID: 11318 RVA: 0x00146B7C File Offset: 0x00144D7C
	protected void IKHCCAANGOP()
	{
		int num = this.sky.PKIKHLMJICN ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(821f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C37 RID: 11319 RVA: 0x00146BE0 File Offset: 0x00144DE0
	protected void IDMCOLDDNCF()
	{
		int num = this.sky.PKIKHLMJICN ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(542f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C38 RID: 11320 RVA: 0x00145E51 File Offset: 0x00144051
	protected void JPHBPEAMNHB()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.FHAJLOBLOMA = base.GetComponent<ParticleSystem>();
		this.HKLFMDAAFCA = this.FHAJLOBLOMA.emissionRate;
	}

	// Token: 0x06002C39 RID: 11321 RVA: 0x00146C44 File Offset: 0x00144E44
	protected void FOHLAIIMNFB()
	{
		int num = this.sky.PKIKHLMJICN ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(1911f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x06002C3A RID: 11322 RVA: 0x00146CA8 File Offset: 0x00144EA8
	protected void FKHAKIKPFFO()
	{
		int num = this.sky.PKIKHLMJICN ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.FHAJLOBLOMA.emissionRate = Mathf.Lerp(250f, this.HKLFMDAAFCA, this.EMJJFHGGBMK);
	}

	// Token: 0x04000604 RID: 1540
	public TOD_Sky sky;

	// Token: 0x04000605 RID: 1541
	public float fadeTime = 1f;

	// Token: 0x04000606 RID: 1542
	private float EMJJFHGGBMK;

	// Token: 0x04000607 RID: 1543
	private ParticleSystem FHAJLOBLOMA;

	// Token: 0x04000608 RID: 1544
	private float HKLFMDAAFCA;
}
