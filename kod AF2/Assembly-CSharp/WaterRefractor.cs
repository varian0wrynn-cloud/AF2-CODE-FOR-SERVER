using System;
using UnityEngine;
using UnityStandardAssets.Water;

// Token: 0x02000296 RID: 662
public class WaterRefractor : MonoBehaviour
{
	// Token: 0x06009B78 RID: 39800 RVA: 0x0045AEB4 File Offset: 0x004590B4
	private void CAJLCEPLKJG()
	{
		this.wt = base.gameObject.GetComponent<WaterBase>();
		this.wt != null;
	}

	// Token: 0x06009B79 RID: 39801 RVA: 0x0045AED4 File Offset: 0x004590D4
	private void LIOCDEICIFD()
	{
		if (this.wt != null)
		{
			float t = (Camera.main.transform.position.y - base.gameObject.transform.position.y - this.DownHght) / (this.UpHght - this.DownHght);
			float x = Mathf.Lerp(this.minVal, this.maxVal, t);
			Vector4 vector = this.wt.sharedMaterial.GetVector("\n");
			float num = TimeController.EPCKOOOGNGK().currentWeather.rain / 1917f;
			num = Mathf.Clamp(num, 1204f, 1440f);
			vector.x = x;
			vector.y = num;
			this.wt.sharedMaterial.SetVector("crft_from", vector);
		}
	}

	// Token: 0x06009B7A RID: 39802 RVA: 0x0045AFA8 File Offset: 0x004591A8
	private void MEFOGCFJBNE()
	{
		if (this.wt != null)
		{
			float t = (Camera.main.transform.position.y - base.gameObject.transform.position.y - this.DownHght) / (this.UpHght - this.DownHght);
			float x = Mathf.Lerp(this.minVal, this.maxVal, t);
			Vector4 vector = this.wt.sharedMaterial.GetVector("_Intensity");
			float num = TimeController.EPCKOOOGNGK().currentWeather.rain / 200f;
			num = Mathf.Clamp(num, 941f, 1311f);
			vector.x = x;
			vector.y = num;
			this.wt.sharedMaterial.SetVector("SteamManager.Initialized failed", vector);
		}
	}

	// Token: 0x06009B7B RID: 39803 RVA: 0x0045B07C File Offset: 0x0045927C
	private void IGEICBNMPAD()
	{
		if (this.wt != null)
		{
			float t = (Camera.main.transform.position.y - base.gameObject.transform.position.y - this.DownHght) / (this.UpHght - this.DownHght);
			float x = Mathf.Lerp(this.minVal, this.maxVal, t);
			Vector4 vector = this.wt.sharedMaterial.GetVector("");
			float num = TimeController.BOBNPEAEECC().currentWeather.rain / 476f;
			num = Mathf.Clamp(num, 34f, 1598f);
			vector.x = x;
			vector.y = num;
			this.wt.sharedMaterial.SetVector(" This is not possible to be called for standalone input. Please check your platform and code where this is called", vector);
		}
	}

	// Token: 0x06009B7C RID: 39804 RVA: 0x0045AEB4 File Offset: 0x004590B4
	private void HHGGCBLOJGB()
	{
		this.wt = base.gameObject.GetComponent<WaterBase>();
		this.wt != null;
	}

	// Token: 0x06009B7D RID: 39805 RVA: 0x0045AEB4 File Offset: 0x004590B4
	private void LMEJKAEIDCO()
	{
		this.wt = base.gameObject.GetComponent<WaterBase>();
		this.wt != null;
	}

	// Token: 0x06009B7E RID: 39806 RVA: 0x0045B150 File Offset: 0x00459350
	private void PFPPDNHLCCA()
	{
		if (this.wt != null)
		{
			float t = (Camera.main.transform.position.y - base.gameObject.transform.position.y - this.DownHght) / (this.UpHght - this.DownHght);
			float x = Mathf.Lerp(this.minVal, this.maxVal, t);
			Vector4 vector = this.wt.sharedMaterial.GetVector(" R ");
			float num = TimeController.EPCKOOOGNGK().currentWeather.rain / 1931f;
			num = Mathf.Clamp(num, 495f, 1841f);
			vector.x = x;
			vector.y = num;
			this.wt.sharedMaterial.SetVector("NextFrame", vector);
		}
	}

	// Token: 0x06009B7F RID: 39807 RVA: 0x0045AEB4 File Offset: 0x004590B4
	private void KEMGOLACEHI()
	{
		this.wt = base.gameObject.GetComponent<WaterBase>();
		this.wt != null;
	}

	// Token: 0x06009B80 RID: 39808 RVA: 0x0045B224 File Offset: 0x00459424
	private void LDDIGEMBDNF()
	{
		if (this.wt != null)
		{
			float t = (Camera.main.transform.position.y - base.gameObject.transform.position.y - this.DownHght) / (this.UpHght - this.DownHght);
			float x = Mathf.Lerp(this.minVal, this.maxVal, t);
			Vector4 vector = this.wt.sharedMaterial.GetVector("Materials/DFGWithSky");
			float num = TimeController.IKGFHGKKCPG.currentWeather.rain / 592f;
			num = Mathf.Clamp(num, 959f, 1111f);
			vector.x = x;
			vector.y = num;
			this.wt.sharedMaterial.SetVector("SkateboardIdle", vector);
		}
	}

	// Token: 0x06009B81 RID: 39809 RVA: 0x0045AEB4 File Offset: 0x004590B4
	private void KGICJDGIIJK()
	{
		this.wt = base.gameObject.GetComponent<WaterBase>();
		this.wt != null;
	}

	// Token: 0x06009B82 RID: 39810 RVA: 0x0045B2F8 File Offset: 0x004594F8
	private void AIAMIFEPALP()
	{
		if (this.wt != null)
		{
			float t = (Camera.main.transform.position.y - base.gameObject.transform.position.y - this.DownHght) / (this.UpHght - this.DownHght);
			float x = Mathf.Lerp(this.minVal, this.maxVal, t);
			Vector4 vector = this.wt.sharedMaterial.GetVector("SexyDance3");
			float num = TimeController.EKEBHIJMEML().currentWeather.rain / 0f;
			num = Mathf.Clamp(num, 1399f, 52f);
			vector.x = x;
			vector.y = num;
			this.wt.sharedMaterial.SetVector("_NoiseAmount", vector);
		}
	}

	// Token: 0x06009B83 RID: 39811 RVA: 0x0045AEB4 File Offset: 0x004590B4
	private void KKCFKEDABLB()
	{
		this.wt = base.gameObject.GetComponent<WaterBase>();
		this.wt != null;
	}

	// Token: 0x06009B84 RID: 39812 RVA: 0x0045AEB4 File Offset: 0x004590B4
	private void PFNPOHMMJDN()
	{
		this.wt = base.gameObject.GetComponent<WaterBase>();
		this.wt != null;
	}

	// Token: 0x06009B85 RID: 39813 RVA: 0x0045B3CC File Offset: 0x004595CC
	private void PJHEGHHOJHJ()
	{
		if (this.wt != null)
		{
			float t = (Camera.main.transform.position.y - base.gameObject.transform.position.y - this.DownHght) / (this.UpHght - this.DownHght);
			float x = Mathf.Lerp(this.minVal, this.maxVal, t);
			Vector4 vector = this.wt.sharedMaterial.GetVector("_FadeDistance");
			float num = TimeController.KOJCECHBHLO().currentWeather.rain / 179f;
			num = Mathf.Clamp(num, 1200f, 1694f);
			vector.x = x;
			vector.y = num;
			this.wt.sharedMaterial.SetVector("fshop_msg1", vector);
		}
	}

	// Token: 0x06009B86 RID: 39814 RVA: 0x0045B4A0 File Offset: 0x004596A0
	private void GCNGEFBKMNC()
	{
		if (this.wt != null)
		{
			float t = (Camera.main.transform.position.y - base.gameObject.transform.position.y - this.DownHght) / (this.UpHght - this.DownHght);
			float x = Mathf.Lerp(this.minVal, this.maxVal, t);
			Vector4 vector = this.wt.sharedMaterial.GetVector("{0:0.0%}");
			float num = TimeController.EPCKOOOGNGK().currentWeather.rain / 246f;
			num = Mathf.Clamp(num, 1737f, 1279f);
			vector.x = x;
			vector.y = num;
			this.wt.sharedMaterial.SetVector("food_draw.ogg", vector);
		}
	}

	// Token: 0x06009B87 RID: 39815 RVA: 0x0045B574 File Offset: 0x00459774
	private void JOHDLNOKCOK()
	{
		if (this.wt != null)
		{
			float t = (Camera.main.transform.position.y - base.gameObject.transform.position.y - this.DownHght) / (this.UpHght - this.DownHght);
			float x = Mathf.Lerp(this.minVal, this.maxVal, t);
			Vector4 vector = this.wt.sharedMaterial.GetVector(": ");
			float num = TimeController.KOJCECHBHLO().currentWeather.rain / 1438f;
			num = Mathf.Clamp(num, 1630f, 810f);
			vector.x = x;
			vector.y = num;
			this.wt.sharedMaterial.SetVector("gi_um_8", vector);
		}
	}

	// Token: 0x06009B88 RID: 39816 RVA: 0x0045AEB4 File Offset: 0x004590B4
	private void ANHOOJFEJJE()
	{
		this.wt = base.gameObject.GetComponent<WaterBase>();
		this.wt != null;
	}

	// Token: 0x06009B89 RID: 39817 RVA: 0x0045AEB4 File Offset: 0x004590B4
	private void Start()
	{
		this.wt = base.gameObject.GetComponent<WaterBase>();
		this.wt != null;
	}

	// Token: 0x06009B8A RID: 39818 RVA: 0x0045B648 File Offset: 0x00459848
	private void KMLNBHIIGKH()
	{
		if (this.wt != null)
		{
			float t = (Camera.main.transform.position.y - base.gameObject.transform.position.y - this.DownHght) / (this.UpHght - this.DownHght);
			float x = Mathf.Lerp(this.minVal, this.maxVal, t);
			Vector4 vector = this.wt.sharedMaterial.GetVector("demoVector3");
			float num = TimeController.EPCKOOOGNGK().currentWeather.rain / 28f;
			num = Mathf.Clamp(num, 1675f, 1059f);
			vector.x = x;
			vector.y = num;
			this.wt.sharedMaterial.SetVector("+{0}", vector);
		}
	}

	// Token: 0x06009B8B RID: 39819 RVA: 0x0045B71C File Offset: 0x0045991C
	private void CBBLGEDCJBF()
	{
		if (this.wt != null)
		{
			float t = (Camera.main.transform.position.y - base.gameObject.transform.position.y - this.DownHght) / (this.UpHght - this.DownHght);
			float x = Mathf.Lerp(this.minVal, this.maxVal, t);
			Vector4 vector = this.wt.sharedMaterial.GetVector(" %\n");
			float num = TimeController.IKGFHGKKCPG.currentWeather.rain / 592f;
			num = Mathf.Clamp(num, 1222f, 1418f);
			vector.x = x;
			vector.y = num;
			this.wt.sharedMaterial.SetVector("Index out of range.", vector);
		}
	}

	// Token: 0x06009B8C RID: 39820 RVA: 0x0045B7F0 File Offset: 0x004599F0
	private void OPDCJCFMIPE()
	{
		if (this.wt != null)
		{
			float t = (Camera.main.transform.position.y - base.gameObject.transform.position.y - this.DownHght) / (this.UpHght - this.DownHght);
			float x = Mathf.Lerp(this.minVal, this.maxVal, t);
			Vector4 vector = this.wt.sharedMaterial.GetVector("");
			float num = TimeController.EKEBHIJMEML().currentWeather.rain / 719f;
			num = Mathf.Clamp(num, 1077f, 1981f);
			vector.x = x;
			vector.y = num;
			this.wt.sharedMaterial.SetVector("UnityEngine.Color", vector);
		}
	}

	// Token: 0x06009B8D RID: 39821 RVA: 0x0045AEB4 File Offset: 0x004590B4
	private void FPLHODJCJDO()
	{
		this.wt = base.gameObject.GetComponent<WaterBase>();
		this.wt != null;
	}

	// Token: 0x06009B8E RID: 39822 RVA: 0x0045AEB4 File Offset: 0x004590B4
	private void INDGOHJGCFN()
	{
		this.wt = base.gameObject.GetComponent<WaterBase>();
		this.wt != null;
	}

	// Token: 0x06009B8F RID: 39823 RVA: 0x0045AEB4 File Offset: 0x004590B4
	private void OFGMIEJKMGC()
	{
		this.wt = base.gameObject.GetComponent<WaterBase>();
		this.wt != null;
	}

	// Token: 0x06009B91 RID: 39825 RVA: 0x0045AEB4 File Offset: 0x004590B4
	private void AFFAJKPPMHF()
	{
		this.wt = base.gameObject.GetComponent<WaterBase>();
		this.wt != null;
	}

	// Token: 0x06009B92 RID: 39826 RVA: 0x0045AEB4 File Offset: 0x004590B4
	private void IIKDDILLGLF()
	{
		this.wt = base.gameObject.GetComponent<WaterBase>();
		this.wt != null;
	}

	// Token: 0x06009B93 RID: 39827 RVA: 0x0045B8E4 File Offset: 0x00459AE4
	private void Update()
	{
		if (this.wt != null)
		{
			float t = (Camera.main.transform.position.y - base.gameObject.transform.position.y - this.DownHght) / (this.UpHght - this.DownHght);
			float x = Mathf.Lerp(this.minVal, this.maxVal, t);
			Vector4 vector = this.wt.sharedMaterial.GetVector("_DistortParams");
			float num = TimeController.IKGFHGKKCPG.currentWeather.rain / 2f;
			num = Mathf.Clamp(num, 0.56f, 3.2f);
			vector.x = x;
			vector.y = num;
			this.wt.sharedMaterial.SetVector("_DistortParams", vector);
		}
	}

	// Token: 0x06009B94 RID: 39828 RVA: 0x0045AEB4 File Offset: 0x004590B4
	private void PMDPLLIBJAF()
	{
		this.wt = base.gameObject.GetComponent<WaterBase>();
		this.wt != null;
	}

	// Token: 0x06009B95 RID: 39829 RVA: 0x0045B9B8 File Offset: 0x00459BB8
	private void JPHLMNIMDHH()
	{
		if (this.wt != null)
		{
			float t = (Camera.main.transform.position.y - base.gameObject.transform.position.y - this.DownHght) / (this.UpHght - this.DownHght);
			float x = Mathf.Lerp(this.minVal, this.maxVal, t);
			Vector4 vector = this.wt.sharedMaterial.GetVector("_Intensity");
			float num = TimeController.EPCKOOOGNGK().currentWeather.rain / 523f;
			num = Mathf.Clamp(num, 449f, 1382f);
			vector.x = x;
			vector.y = num;
			this.wt.sharedMaterial.SetVector("simple", vector);
		}
	}

	// Token: 0x06009B96 RID: 39830 RVA: 0x0045BA8C File Offset: 0x00459C8C
	private void BNKJNBIDPME()
	{
		if (this.wt != null)
		{
			float t = (Camera.main.transform.position.y - base.gameObject.transform.position.y - this.DownHght) / (this.UpHght - this.DownHght);
			float x = Mathf.Lerp(this.minVal, this.maxVal, t);
			Vector4 vector = this.wt.sharedMaterial.GetVector("Sitting Reading Page Flip");
			float num = TimeController.EPCKOOOGNGK().currentWeather.rain / 198f;
			num = Mathf.Clamp(num, 1538f, 856f);
			vector.x = x;
			vector.y = num;
			this.wt.sharedMaterial.SetVector("UNDISTORT", vector);
		}
	}

	// Token: 0x06009B97 RID: 39831 RVA: 0x0045BB60 File Offset: 0x00459D60
	private void JLFBDOPFDDJ()
	{
		if (this.wt != null)
		{
			float t = (Camera.main.transform.position.y - base.gameObject.transform.position.y - this.DownHght) / (this.UpHght - this.DownHght);
			float x = Mathf.Lerp(this.minVal, this.maxVal, t);
			Vector4 vector = this.wt.sharedMaterial.GetVector("id");
			float num = TimeController.EKEBHIJMEML().currentWeather.rain / 1514f;
			num = Mathf.Clamp(num, 1637f, 1263f);
			vector.x = x;
			vector.y = num;
			this.wt.sharedMaterial.SetVector("1HandSwordStrafeRight", vector);
		}
	}

	// Token: 0x06009B98 RID: 39832 RVA: 0x0045BC34 File Offset: 0x00459E34
	private void LMMDHJJJNJO()
	{
		if (this.wt != null)
		{
			float t = (Camera.main.transform.position.y - base.gameObject.transform.position.y - this.DownHght) / (this.UpHght - this.DownHght);
			float x = Mathf.Lerp(this.minVal, this.maxVal, t);
			Vector4 vector = this.wt.sharedMaterial.GetVector("cntx_close");
			float num = TimeController.KOJCECHBHLO().currentWeather.rain / 1615f;
			num = Mathf.Clamp(num, 338f, 959f);
			vector.x = x;
			vector.y = num;
			this.wt.sharedMaterial.SetVector("Cheer Jump", vector);
		}
	}

	// Token: 0x06009B99 RID: 39833 RVA: 0x0045BD08 File Offset: 0x00459F08
	private void BOAJJAKEMLH()
	{
		if (this.wt != null)
		{
			float t = (Camera.main.transform.position.y - base.gameObject.transform.position.y - this.DownHght) / (this.UpHght - this.DownHght);
			float x = Mathf.Lerp(this.minVal, this.maxVal, t);
			Vector4 vector = this.wt.sharedMaterial.GetVector("MotorbikeTurnLeft");
			float num = TimeController.KOJCECHBHLO().currentWeather.rain / 1165f;
			num = Mathf.Clamp(num, 956f, 1745f);
			vector.x = x;
			vector.y = num;
			this.wt.sharedMaterial.SetVector("tid", vector);
		}
	}

	// Token: 0x06009B9A RID: 39834 RVA: 0x0045AEB4 File Offset: 0x004590B4
	private void EFJDBBDMPMC()
	{
		this.wt = base.gameObject.GetComponent<WaterBase>();
		this.wt != null;
	}

	// Token: 0x06009B9B RID: 39835 RVA: 0x0045BDDC File Offset: 0x00459FDC
	private void HMEAENGBFKC()
	{
		if (this.wt != null)
		{
			float t = (Camera.main.transform.position.y - base.gameObject.transform.position.y - this.DownHght) / (this.UpHght - this.DownHght);
			float x = Mathf.Lerp(this.minVal, this.maxVal, t);
			Vector4 vector = this.wt.sharedMaterial.GetVector("#000000");
			float num = TimeController.EKEBHIJMEML().currentWeather.rain / 1850f;
			num = Mathf.Clamp(num, 1481f, 762f);
			vector.x = x;
			vector.y = num;
			this.wt.sharedMaterial.SetVector("repair.ogg", vector);
		}
	}

	// Token: 0x06009B9C RID: 39836 RVA: 0x0045AEB4 File Offset: 0x004590B4
	private void OBJCOJEHLBE()
	{
		this.wt = base.gameObject.GetComponent<WaterBase>();
		this.wt != null;
	}

	// Token: 0x0400143B RID: 5179
	public WaterBase wt;

	// Token: 0x0400143C RID: 5180
	public float minVal;

	// Token: 0x0400143D RID: 5181
	public float maxVal;

	// Token: 0x0400143E RID: 5182
	public float DownHght = 1f;

	// Token: 0x0400143F RID: 5183
	public float UpHght = 3f;
}
