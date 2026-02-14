using System;
using UnityEngine;

// Token: 0x020000E7 RID: 231
[RequireComponent(typeof(Light))]
public class LightAtDay : MonoBehaviour
{
	// Token: 0x06002B67 RID: 11111 RVA: 0x00144071 File Offset: 0x00142271
	protected void BMNJGPIPKLL()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002B69 RID: 11113 RVA: 0x001440BC File Offset: 0x001422BC
	protected void BJOICAKCPLI()
	{
		int num = this.sky.PKIKHLMJICN ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(326f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 1869f);
	}

	// Token: 0x06002B6A RID: 11114 RVA: 0x00144071 File Offset: 0x00142271
	protected void DGEIACONKCJ()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002B6B RID: 11115 RVA: 0x00144071 File Offset: 0x00142271
	protected void IIKDDILLGLF()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002B6C RID: 11116 RVA: 0x00144071 File Offset: 0x00142271
	protected void FPLHODJCJDO()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002B6D RID: 11117 RVA: 0x00144071 File Offset: 0x00142271
	protected void KEMGOLACEHI()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002B6E RID: 11118 RVA: 0x0014413C File Offset: 0x0014233C
	protected void FJEEADNCKAG()
	{
		int num = this.sky.PKIKHLMJICN ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(399f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 954f);
	}

	// Token: 0x06002B6F RID: 11119 RVA: 0x00144071 File Offset: 0x00142271
	protected void EFJDBBDMPMC()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002B70 RID: 11120 RVA: 0x00144071 File Offset: 0x00142271
	protected void EDGALMCHPPH()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002B71 RID: 11121 RVA: 0x00144071 File Offset: 0x00142271
	protected void BJHGPFGBFKF()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002B72 RID: 11122 RVA: 0x00144071 File Offset: 0x00142271
	protected void AFFAJKPPMHF()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002B73 RID: 11123 RVA: 0x00144071 File Offset: 0x00142271
	protected void CAJLCEPLKJG()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002B74 RID: 11124 RVA: 0x001441BC File Offset: 0x001423BC
	protected void CBBLGEDCJBF()
	{
		int num = this.sky.PKIKHLMJICN ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(97f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 1474f);
	}

	// Token: 0x06002B75 RID: 11125 RVA: 0x00144071 File Offset: 0x00142271
	protected void LMEJKAEIDCO()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002B76 RID: 11126 RVA: 0x00144071 File Offset: 0x00142271
	protected void AOCDDBNBADJ()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002B77 RID: 11127 RVA: 0x00144071 File Offset: 0x00142271
	protected void MODJFGGIAHD()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002B78 RID: 11128 RVA: 0x0014423C File Offset: 0x0014243C
	protected void IOGAKGCADBL()
	{
		int num = this.sky.PKIKHLMJICN ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(1256f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 1214f);
	}

	// Token: 0x06002B79 RID: 11129 RVA: 0x00144071 File Offset: 0x00142271
	protected void NCALLFHEAGJ()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002B7A RID: 11130 RVA: 0x001442BC File Offset: 0x001424BC
	protected void Update()
	{
		int num = this.sky.PKIKHLMJICN ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(0f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 0f);
	}

	// Token: 0x06002B7B RID: 11131 RVA: 0x00144071 File Offset: 0x00142271
	protected void KFGKKLAKFGH()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002B7C RID: 11132 RVA: 0x0014433C File Offset: 0x0014253C
	protected void HAIMGCDKPDC()
	{
		int num = this.sky.PKIKHLMJICN ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(1960f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 1734f);
	}

	// Token: 0x06002B7D RID: 11133 RVA: 0x001443BC File Offset: 0x001425BC
	protected void PFPPDNHLCCA()
	{
		int num = this.sky.PKIKHLMJICN ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(1001f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 877f);
	}

	// Token: 0x06002B7E RID: 11134 RVA: 0x0014443C File Offset: 0x0014263C
	protected void OPDCJCFMIPE()
	{
		int num = this.sky.PKIKHLMJICN ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(1023f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 392f);
	}

	// Token: 0x06002B7F RID: 11135 RVA: 0x001444BC File Offset: 0x001426BC
	protected void JLFBDOPFDDJ()
	{
		int num = this.sky.PKIKHLMJICN ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(1581f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 915f);
	}

	// Token: 0x06002B80 RID: 11136 RVA: 0x0014453C File Offset: 0x0014273C
	protected void OFPGMNGFLNH()
	{
		int num = this.sky.PKIKHLMJICN ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(1397f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 1147f);
	}

	// Token: 0x06002B81 RID: 11137 RVA: 0x00144071 File Offset: 0x00142271
	protected void CGMHGDEKDEP()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002B82 RID: 11138 RVA: 0x00144071 File Offset: 0x00142271
	protected void MKNPFMEMOJO()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002B83 RID: 11139 RVA: 0x001445BC File Offset: 0x001427BC
	protected void PNBGJBMJLFM()
	{
		int num = this.sky.PKIKHLMJICN ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(746f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 429f);
	}

	// Token: 0x06002B84 RID: 11140 RVA: 0x00144071 File Offset: 0x00142271
	protected void PMDPLLIBJAF()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002B85 RID: 11141 RVA: 0x0014463C File Offset: 0x0014283C
	protected void GCNGEFBKMNC()
	{
		int num = this.sky.PKIKHLMJICN ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(845f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 413f);
	}

	// Token: 0x06002B86 RID: 11142 RVA: 0x001446BC File Offset: 0x001428BC
	protected void PJHEGHHOJHJ()
	{
		int num = this.sky.PKIKHLMJICN ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(1164f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 98f);
	}

	// Token: 0x06002B87 RID: 11143 RVA: 0x0014473C File Offset: 0x0014293C
	protected void LDDIGEMBDNF()
	{
		int num = this.sky.PKIKHLMJICN ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(1825f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 896f);
	}

	// Token: 0x06002B88 RID: 11144 RVA: 0x00144071 File Offset: 0x00142271
	protected void LPNDCJKAKEA()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002B89 RID: 11145 RVA: 0x001447BC File Offset: 0x001429BC
	protected void PGIHAIPCJLL()
	{
		int num = this.sky.PKIKHLMJICN ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(1474f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 90f);
	}

	// Token: 0x06002B8A RID: 11146 RVA: 0x00144071 File Offset: 0x00142271
	protected void ELFLOPJDAKK()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002B8B RID: 11147 RVA: 0x00144071 File Offset: 0x00142271
	protected void Start()
	{
		if (!this.sky)
		{
			this.sky = TOD_Sky.ELOBJGIDGCP;
		}
		this.KGGCLGADNIM = base.GetComponent<Light>();
		this.PFPFCIIIANB = this.KGGCLGADNIM.intensity;
	}

	// Token: 0x06002B8C RID: 11148 RVA: 0x0014483C File Offset: 0x00142A3C
	protected void BOAJJAKEMLH()
	{
		int num = this.sky.PKIKHLMJICN ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(1464f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 963f);
	}

	// Token: 0x06002B8D RID: 11149 RVA: 0x001448BC File Offset: 0x00142ABC
	protected void AKLFCMNCPKL()
	{
		int num = this.sky.PKIKHLMJICN ? 0 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(1026f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 641f);
	}

	// Token: 0x06002B8E RID: 11150 RVA: 0x0014493C File Offset: 0x00142B3C
	protected void OHKHOAKCENL()
	{
		int num = this.sky.PKIKHLMJICN ? 1 : -1;
		this.EMJJFHGGBMK = Mathf.Clamp01(this.EMJJFHGGBMK + (float)num * Time.deltaTime / this.fadeTime);
		this.KGGCLGADNIM.intensity = Mathf.Lerp(1632f, this.PFPFCIIIANB, this.EMJJFHGGBMK);
		this.KGGCLGADNIM.enabled = (this.KGGCLGADNIM.intensity > 1184f);
	}

	// Token: 0x040005F2 RID: 1522
	public TOD_Sky sky;

	// Token: 0x040005F3 RID: 1523
	public float fadeTime = 1f;

	// Token: 0x040005F4 RID: 1524
	private float EMJJFHGGBMK;

	// Token: 0x040005F5 RID: 1525
	private Light KGGCLGADNIM;

	// Token: 0x040005F6 RID: 1526
	private float PFPFCIIIANB;
}
