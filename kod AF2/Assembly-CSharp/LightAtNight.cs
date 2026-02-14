using System;
using UnityEngine;

// Token: 0x020000E8 RID: 232
[RequireComponent(typeof(Light))]
public class LightAtNight : MonoBehaviour
{
	// Token: 0x06002B8F RID: 11151 RVA: 0x001449BA File Offset: 0x00142BBA
	protected void AFFAJKPPMHF()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002B90 RID: 11152 RVA: 0x001449F4 File Offset: 0x00142BF4
	protected void OFPGMNGFLNH()
	{
		int num = this.sky.LADANCDAELM ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(1006f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 92f);
	}

	// Token: 0x06002B91 RID: 11153 RVA: 0x00144A74 File Offset: 0x00142C74
	protected void HMEAENGBFKC()
	{
		int num = this.sky.LADANCDAELM ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(1536f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 1584f);
	}

	// Token: 0x06002B92 RID: 11154 RVA: 0x00144AF4 File Offset: 0x00142CF4
	protected void DFFOEGHGPGP()
	{
		int num = this.sky.LADANCDAELM ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(600f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 1927f);
	}

	// Token: 0x06002B93 RID: 11155 RVA: 0x001449BA File Offset: 0x00142BBA
	protected void ANHOOJFEJJE()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002B94 RID: 11156 RVA: 0x00144B74 File Offset: 0x00142D74
	protected void LMMDHJJJNJO()
	{
		int num = this.sky.LADANCDAELM ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(332f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 928f);
	}

	// Token: 0x06002B95 RID: 11157 RVA: 0x00144BF4 File Offset: 0x00142DF4
	protected void GCNGEFBKMNC()
	{
		int num = this.sky.LADANCDAELM ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(1587f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 202f);
	}

	// Token: 0x06002B96 RID: 11158 RVA: 0x001449BA File Offset: 0x00142BBA
	protected void EHFPLKEINFO()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002B97 RID: 11159 RVA: 0x00144C74 File Offset: 0x00142E74
	protected void JLFBDOPFDDJ()
	{
		int num = this.sky.LADANCDAELM ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(570f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 1125f);
	}

	// Token: 0x06002B98 RID: 11160 RVA: 0x00144CF4 File Offset: 0x00142EF4
	protected void JPHLMNIMDHH()
	{
		int num = this.sky.LADANCDAELM ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(1618f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 208f);
	}

	// Token: 0x06002B99 RID: 11161 RVA: 0x00144D74 File Offset: 0x00142F74
	protected void HMLNMHOMMNO()
	{
		int num = this.sky.LADANCDAELM ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(153f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 1924f);
	}

	// Token: 0x06002B9A RID: 11162 RVA: 0x001449BA File Offset: 0x00142BBA
	protected void EHDPACPIBNF()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002B9B RID: 11163 RVA: 0x00144DF4 File Offset: 0x00142FF4
	protected void IGEICBNMPAD()
	{
		int num = this.sky.LADANCDAELM ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(1546f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 708f);
	}

	// Token: 0x06002B9C RID: 11164 RVA: 0x001449BA File Offset: 0x00142BBA
	protected void JLKBMEBFHBI()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002B9D RID: 11165 RVA: 0x00144E74 File Offset: 0x00143074
	protected void KMLNBHIIGKH()
	{
		int num = this.sky.LADANCDAELM ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(1767f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 633f);
	}

	// Token: 0x06002B9E RID: 11166 RVA: 0x00144EF4 File Offset: 0x001430F4
	protected void PJHEGHHOJHJ()
	{
		int num = this.sky.LADANCDAELM ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(1025f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 405f);
	}

	// Token: 0x06002B9F RID: 11167 RVA: 0x00144F74 File Offset: 0x00143174
	protected void Update()
	{
		int num = this.sky.LADANCDAELM ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(0f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 0f);
	}

	// Token: 0x06002BA0 RID: 11168 RVA: 0x001449BA File Offset: 0x00142BBA
	protected void Start()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002BA1 RID: 11169 RVA: 0x00144FF4 File Offset: 0x001431F4
	protected void AKLFCMNCPKL()
	{
		int num = this.sky.LADANCDAELM ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(376f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 488f);
	}

	// Token: 0x06002BA2 RID: 11170 RVA: 0x001449BA File Offset: 0x00142BBA
	protected void FPLHODJCJDO()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002BA3 RID: 11171 RVA: 0x001449BA File Offset: 0x00142BBA
	protected void OBJCOJEHLBE()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002BA4 RID: 11172 RVA: 0x00145074 File Offset: 0x00143274
	protected void DPGECEOMHNM()
	{
		int num = this.sky.LADANCDAELM ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(1136f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 786f);
	}

	// Token: 0x06002BA5 RID: 11173 RVA: 0x001450F4 File Offset: 0x001432F4
	protected void FJEEADNCKAG()
	{
		int num = this.sky.LADANCDAELM ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(1333f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 1650f);
	}

	// Token: 0x06002BA6 RID: 11174 RVA: 0x001449BA File Offset: 0x00142BBA
	protected void NOKJMMDMJNO()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002BA7 RID: 11175 RVA: 0x001449BA File Offset: 0x00142BBA
	protected void DHJDMKLBLEF()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002BA8 RID: 11176 RVA: 0x001449BA File Offset: 0x00142BBA
	protected void HHGGCBLOJGB()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002BA9 RID: 11177 RVA: 0x00145174 File Offset: 0x00143374
	protected void KJJBBLDJHPD()
	{
		int num = this.sky.LADANCDAELM ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(1446f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 1450f);
	}

	// Token: 0x06002BAA RID: 11178 RVA: 0x001449BA File Offset: 0x00142BBA
	protected void CBLGFOFHNPJ()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002BAB RID: 11179 RVA: 0x001449BA File Offset: 0x00142BBA
	protected void CPNOBMNKPNC()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002BAC RID: 11180 RVA: 0x001451F4 File Offset: 0x001433F4
	protected void MEFOGCFJBNE()
	{
		int num = this.sky.LADANCDAELM ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(745f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 137f);
	}

	// Token: 0x06002BAD RID: 11181 RVA: 0x001449BA File Offset: 0x00142BBA
	protected void BMNJGPIPKLL()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002BAE RID: 11182 RVA: 0x001449BA File Offset: 0x00142BBA
	protected void LMEJKAEIDCO()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002BAF RID: 11183 RVA: 0x00145274 File Offset: 0x00143474
	protected void AMDMCKIFBPA()
	{
		int num = this.sky.LADANCDAELM ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(1482f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 1578f);
	}

	// Token: 0x06002BB0 RID: 11184 RVA: 0x001449BA File Offset: 0x00142BBA
	protected void IMABGALEMBI()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002BB1 RID: 11185 RVA: 0x001449BA File Offset: 0x00142BBA
	protected void BJHGPFGBFKF()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002BB2 RID: 11186 RVA: 0x001449BA File Offset: 0x00142BBA
	protected void KFGKKLAKFGH()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002BB3 RID: 11187 RVA: 0x001449BA File Offset: 0x00142BBA
	protected void MODJFGGIAHD()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002BB5 RID: 11189 RVA: 0x00145308 File Offset: 0x00143508
	protected void JIFOELPAEHG()
	{
		int num = this.sky.LADANCDAELM ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(295f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 532f);
	}

	// Token: 0x06002BB6 RID: 11190 RVA: 0x001449BA File Offset: 0x00142BBA
	protected void ONIHHFLOJMN()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002BB7 RID: 11191 RVA: 0x00145388 File Offset: 0x00143588
	protected void AIAMIFEPALP()
	{
		int num = this.sky.LADANCDAELM ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(1947f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 1827f);
	}

	// Token: 0x06002BB8 RID: 11192 RVA: 0x001449BA File Offset: 0x00142BBA
	protected void HDFCIACDDEK()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002BB9 RID: 11193 RVA: 0x00145408 File Offset: 0x00143608
	protected void IKHCCAANGOP()
	{
		int num = this.sky.LADANCDAELM ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(889f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 1506f);
	}

	// Token: 0x06002BBA RID: 11194 RVA: 0x001449BA File Offset: 0x00142BBA
	protected void INDGOHJGCFN()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002BBB RID: 11195 RVA: 0x00145488 File Offset: 0x00143688
	protected void CJHBCHBOLBI()
	{
		int num = this.sky.LADANCDAELM ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(590f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 1176f);
	}

	// Token: 0x06002BBC RID: 11196 RVA: 0x00145508 File Offset: 0x00143708
	protected void HAIMGCDKPDC()
	{
		int num = this.sky.LADANCDAELM ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(1369f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 1443f);
	}

	// Token: 0x040005F7 RID: 1527
	public TOD_Sky sky;

	// Token: 0x040005F8 RID: 1528
	public float fadeTime = 1f;

	// Token: 0x040005F9 RID: 1529
	private float EMJJFHGGBMK;

	// Token: 0x040005FA RID: 1530
	private Light KGGCLGADNIM;

	// Token: 0x040005FB RID: 1531
	private float PFPFCIIIANB;
}
