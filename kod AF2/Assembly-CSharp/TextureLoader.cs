using System;
using System.Collections;
using System.IO;
using UnityEngine;

// Token: 0x02000291 RID: 657
public class TextureLoader : MonoBehaviour
{
	// Token: 0x060099C6 RID: 39366 RVA: 0x004450D4 File Offset: 0x004432D4
	public void APKGGJDDOOM(CKNLPGEPGGF.IAPCJOBDCEH JACEPAEHGPM)
	{
		this.texcontainer = JACEPAEHGPM;
		if (!File.Exists(this.texcontainer.ALBOCLBFNNI.Substring(4)))
		{
			this.texcontainer.OINDOLGBLOC = false;
			this.texcontainer.FHMMOMPDCNL();
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.StartCoroutine("Transform is null.");
	}

	// Token: 0x060099C7 RID: 39367 RVA: 0x00445130 File Offset: 0x00443330
	public void OBCCOKCHKDA(CKNLPGEPGGF.IAPCJOBDCEH JACEPAEHGPM)
	{
		this.texcontainer = JACEPAEHGPM;
		if (!File.Exists(this.texcontainer.ALBOCLBFNNI.Substring(7)))
		{
			this.texcontainer.OINDOLGBLOC = true;
			this.texcontainer.EBIIBBHKAAK();
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.StartCoroutine("");
	}

	// Token: 0x060099C8 RID: 39368 RVA: 0x0044518C File Offset: 0x0044338C
	public void PAAHNMNCDJA(CKNLPGEPGGF.IAPCJOBDCEH JACEPAEHGPM)
	{
		this.texcontainer = JACEPAEHGPM;
		if (!File.Exists(this.texcontainer.ALBOCLBFNNI.Substring(5)))
		{
			this.texcontainer.OINDOLGBLOC = true;
			this.texcontainer.EBIIBBHKAAK();
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.StartCoroutine("rotTime is NaN");
	}

	// Token: 0x060099C9 RID: 39369 RVA: 0x004451E7 File Offset: 0x004433E7
	private IEnumerator HCEGOBMCHFD()
	{
		this.texcontainer.PMJIHPFGCGJ = true;
		base.gameObject.name = "TextureLoader: " + this.texcontainer.ALBOCLBFNNI;
		WWW www = new WWW(this.texcontainer.ALBOCLBFNNI);
		yield return www;
		this.texcontainer.PMJIHPFGCGJ = false;
		this.texcontainer.KEDGAOBCNJG = new Texture2D(4, 4, TextureFormat.ARGB32, false, false);
		if (www.isDone)
		{
			www.LoadImageIntoTexture(this.texcontainer.KEDGAOBCNJG);
			this.texcontainer.KEDGAOBCNJG.filterMode = this.texcontainer.OECLFHEEHEG;
			this.texcontainer.KEDGAOBCNJG.Apply();
			this.tex = this.texcontainer.KEDGAOBCNJG;
			this.texcontainer.OINDOLGBLOC = true;
			this.texcontainer.IALKJFLJBCP();
		}
		string error = www.error;
		www.Dispose();
		www = null;
		GC.Collect();
		UnityEngine.Object.Destroy(base.gameObject);
		yield break;
	}

	// Token: 0x060099CA RID: 39370 RVA: 0x004451F8 File Offset: 0x004433F8
	public void GPKOJMNCOBO(CKNLPGEPGGF.IAPCJOBDCEH JACEPAEHGPM)
	{
		this.texcontainer = JACEPAEHGPM;
		if (!File.Exists(this.texcontainer.ALBOCLBFNNI.Substring(5)))
		{
			this.texcontainer.OINDOLGBLOC = true;
			this.texcontainer.EBIIBBHKAAK();
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.StartCoroutine("MotorbikeAirWalk");
	}

	// Token: 0x060099CB RID: 39371 RVA: 0x004451E7 File Offset: 0x004433E7
	private IEnumerator JHIPNNOOGLJ()
	{
		this.texcontainer.PMJIHPFGCGJ = true;
		base.gameObject.name = "TextureLoader: " + this.texcontainer.ALBOCLBFNNI;
		www = new WWW(this.texcontainer.ALBOCLBFNNI);
		yield return www;
		this.texcontainer.PMJIHPFGCGJ = false;
		this.texcontainer.KEDGAOBCNJG = new Texture2D(4, 4, TextureFormat.ARGB32, false, false);
		if (www.isDone)
		{
			www.LoadImageIntoTexture(this.texcontainer.KEDGAOBCNJG);
			this.texcontainer.KEDGAOBCNJG.filterMode = this.texcontainer.OECLFHEEHEG;
			this.texcontainer.KEDGAOBCNJG.Apply();
			this.tex = this.texcontainer.KEDGAOBCNJG;
			this.texcontainer.OINDOLGBLOC = true;
			this.texcontainer.IALKJFLJBCP();
		}
		string error = www.error;
		www.Dispose();
		www = null;
		GC.Collect();
		UnityEngine.Object.Destroy(base.gameObject);
		yield break;
	}

	// Token: 0x060099CC RID: 39372 RVA: 0x00445254 File Offset: 0x00443454
	public void MBGOMLIBBBL(CKNLPGEPGGF.IAPCJOBDCEH JACEPAEHGPM)
	{
		this.texcontainer = JACEPAEHGPM;
		if (!File.Exists(this.texcontainer.ALBOCLBFNNI.Substring(8)))
		{
			this.texcontainer.OINDOLGBLOC = true;
			this.texcontainer.FBCJONKDLDC();
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.StartCoroutine("System.Boolean");
	}

	// Token: 0x060099CD RID: 39373 RVA: 0x004452B0 File Offset: 0x004434B0
	public void LHJBFHLDGIA(CKNLPGEPGGF.IAPCJOBDCEH JACEPAEHGPM)
	{
		this.texcontainer = JACEPAEHGPM;
		if (!File.Exists(this.texcontainer.ALBOCLBFNNI.Substring(4)))
		{
			this.texcontainer.OINDOLGBLOC = false;
			this.texcontainer.JNFNCLMDLKA();
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.StartCoroutine("Hidden/ACTk/WallHackTexture");
	}

	// Token: 0x060099CE RID: 39374 RVA: 0x0044530C File Offset: 0x0044350C
	public void MPBHGKEPBIH(CKNLPGEPGGF.IAPCJOBDCEH JACEPAEHGPM)
	{
		this.texcontainer = JACEPAEHGPM;
		if (!File.Exists(this.texcontainer.ALBOCLBFNNI.Substring(3)))
		{
			this.texcontainer.OINDOLGBLOC = true;
			this.texcontainer.JHOMNOPGPIL();
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.StartCoroutine("_Specular");
	}

	// Token: 0x060099CF RID: 39375 RVA: 0x00445368 File Offset: 0x00443568
	public void EDDDFPHIENE(CKNLPGEPGGF.IAPCJOBDCEH JACEPAEHGPM)
	{
		this.texcontainer = JACEPAEHGPM;
		if (!File.Exists(this.texcontainer.ALBOCLBFNNI.Substring(0)))
		{
			this.texcontainer.OINDOLGBLOC = true;
			this.texcontainer.FHMMOMPDCNL();
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.StartCoroutine("wpn_bait_sz");
	}

	// Token: 0x060099D0 RID: 39376 RVA: 0x004453C4 File Offset: 0x004435C4
	public void KONDCHOAOHD(CKNLPGEPGGF.IAPCJOBDCEH JACEPAEHGPM)
	{
		this.texcontainer = JACEPAEHGPM;
		if (!File.Exists(this.texcontainer.ALBOCLBFNNI.Substring(0)))
		{
			this.texcontainer.OINDOLGBLOC = true;
			this.texcontainer.EDIOFJIFBFB();
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.StartCoroutine("_AdaptParams");
	}

	// Token: 0x060099D1 RID: 39377 RVA: 0x0044541F File Offset: 0x0044361F
	private IEnumerator GFPFKAFELJB()
	{
		TextureLoader.HBFOOIAFNIL hbfooiafnil = new TextureLoader.HBFOOIAFNIL(1);
		hbfooiafnil.AENJLLPLILM = this;
		return hbfooiafnil;
	}

	// Token: 0x060099D2 RID: 39378 RVA: 0x00445430 File Offset: 0x00443630
	public void MEPMGEPINFB(CKNLPGEPGGF.IAPCJOBDCEH JACEPAEHGPM)
	{
		this.texcontainer = JACEPAEHGPM;
		if (!File.Exists(this.texcontainer.ALBOCLBFNNI.Substring(2)))
		{
			this.texcontainer.OINDOLGBLOC = false;
			this.texcontainer.CMBHNGAAAEE();
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.StartCoroutine("MotorbikeBackwardSittingCheer");
	}

	// Token: 0x060099D3 RID: 39379 RVA: 0x0044548C File Offset: 0x0044368C
	public void NBGLKKMBELN(CKNLPGEPGGF.IAPCJOBDCEH JACEPAEHGPM)
	{
		this.texcontainer = JACEPAEHGPM;
		if (!File.Exists(this.texcontainer.ALBOCLBFNNI.Substring(8)))
		{
			this.texcontainer.OINDOLGBLOC = false;
			this.texcontainer.ONCLONDJKGC();
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.StartCoroutine("UIChat_channel");
	}

	// Token: 0x060099D4 RID: 39380 RVA: 0x004454E8 File Offset: 0x004436E8
	public void MOHFJDPLDKF(CKNLPGEPGGF.IAPCJOBDCEH JACEPAEHGPM)
	{
		this.texcontainer = JACEPAEHGPM;
		if (!File.Exists(this.texcontainer.ALBOCLBFNNI.Substring(7)))
		{
			this.texcontainer.OINDOLGBLOC = false;
			this.texcontainer.FHMMOMPDCNL();
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.StartCoroutine("money2.wav");
	}

	// Token: 0x060099D5 RID: 39381 RVA: 0x0044541F File Offset: 0x0044361F
	private IEnumerator LHHIDCHMJKD()
	{
		TextureLoader.HBFOOIAFNIL hbfooiafnil = new TextureLoader.HBFOOIAFNIL(1);
		hbfooiafnil.AENJLLPLILM = this;
		return hbfooiafnil;
	}

	// Token: 0x060099D6 RID: 39382 RVA: 0x004451E7 File Offset: 0x004433E7
	private IEnumerator GOBCDNNJELB()
	{
		this.texcontainer.PMJIHPFGCGJ = true;
		base.gameObject.name = "TextureLoader: " + this.texcontainer.ALBOCLBFNNI;
		www = new WWW(this.texcontainer.ALBOCLBFNNI);
		yield return www;
		this.texcontainer.PMJIHPFGCGJ = false;
		this.texcontainer.KEDGAOBCNJG = new Texture2D(4, 4, TextureFormat.ARGB32, false, false);
		if (www.isDone)
		{
			www.LoadImageIntoTexture(this.texcontainer.KEDGAOBCNJG);
			this.texcontainer.KEDGAOBCNJG.filterMode = this.texcontainer.OECLFHEEHEG;
			this.texcontainer.KEDGAOBCNJG.Apply();
			this.tex = this.texcontainer.KEDGAOBCNJG;
			this.texcontainer.OINDOLGBLOC = true;
			this.texcontainer.IALKJFLJBCP();
		}
		string error = www.error;
		www.Dispose();
		www = null;
		GC.Collect();
		UnityEngine.Object.Destroy(base.gameObject);
		yield break;
	}

	// Token: 0x060099D7 RID: 39383 RVA: 0x0044541F File Offset: 0x0044361F
	private IEnumerator ICNENMGKNIA()
	{
		TextureLoader.HBFOOIAFNIL hbfooiafnil = new TextureLoader.HBFOOIAFNIL(1);
		hbfooiafnil.AENJLLPLILM = this;
		return hbfooiafnil;
	}

	// Token: 0x060099D8 RID: 39384 RVA: 0x004451E7 File Offset: 0x004433E7
	private IEnumerator MBNKEPIKDHN()
	{
		this.texcontainer.PMJIHPFGCGJ = true;
		base.gameObject.name = "TextureLoader: " + this.texcontainer.ALBOCLBFNNI;
		www = new WWW(this.texcontainer.ALBOCLBFNNI);
		yield return www;
		this.texcontainer.PMJIHPFGCGJ = false;
		this.texcontainer.KEDGAOBCNJG = new Texture2D(4, 4, TextureFormat.ARGB32, false, false);
		if (www.isDone)
		{
			www.LoadImageIntoTexture(this.texcontainer.KEDGAOBCNJG);
			this.texcontainer.KEDGAOBCNJG.filterMode = this.texcontainer.OECLFHEEHEG;
			this.texcontainer.KEDGAOBCNJG.Apply();
			this.tex = this.texcontainer.KEDGAOBCNJG;
			this.texcontainer.OINDOLGBLOC = true;
			this.texcontainer.IALKJFLJBCP();
		}
		string error = www.error;
		www.Dispose();
		www = null;
		GC.Collect();
		UnityEngine.Object.Destroy(base.gameObject);
		yield break;
	}

	// Token: 0x060099D9 RID: 39385 RVA: 0x00445544 File Offset: 0x00443744
	public void load(CKNLPGEPGGF.IAPCJOBDCEH JACEPAEHGPM)
	{
		this.texcontainer = JACEPAEHGPM;
		if (!File.Exists(this.texcontainer.ALBOCLBFNNI.Substring(7)))
		{
			this.texcontainer.OINDOLGBLOC = true;
			this.texcontainer.IALKJFLJBCP();
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.StartCoroutine("ALCFMPMMHGF");
	}

	// Token: 0x060099DA RID: 39386 RVA: 0x0044541F File Offset: 0x0044361F
	private IEnumerator DPPGMNBOKDJ()
	{
		TextureLoader.HBFOOIAFNIL hbfooiafnil = new TextureLoader.HBFOOIAFNIL(1);
		hbfooiafnil.AENJLLPLILM = this;
		return hbfooiafnil;
	}

	// Token: 0x060099DB RID: 39387 RVA: 0x0044541F File Offset: 0x0044361F
	private IEnumerator HHMFOOKKJAL()
	{
		TextureLoader.HBFOOIAFNIL hbfooiafnil = new TextureLoader.HBFOOIAFNIL(1);
		hbfooiafnil.AENJLLPLILM = this;
		return hbfooiafnil;
	}

	// Token: 0x060099DC RID: 39388 RVA: 0x004455A0 File Offset: 0x004437A0
	public void GHMIFDHOMJC(CKNLPGEPGGF.IAPCJOBDCEH JACEPAEHGPM)
	{
		this.texcontainer = JACEPAEHGPM;
		if (!File.Exists(this.texcontainer.ALBOCLBFNNI.Substring(0)))
		{
			this.texcontainer.OINDOLGBLOC = true;
			this.texcontainer.FHMMOMPDCNL();
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.StartCoroutine("money");
	}

	// Token: 0x060099DD RID: 39389 RVA: 0x004451E7 File Offset: 0x004433E7
	private IEnumerator FHONPDNFMMO()
	{
		this.texcontainer.PMJIHPFGCGJ = true;
		base.gameObject.name = "TextureLoader: " + this.texcontainer.ALBOCLBFNNI;
		www = new WWW(this.texcontainer.ALBOCLBFNNI);
		yield return www;
		this.texcontainer.PMJIHPFGCGJ = false;
		this.texcontainer.KEDGAOBCNJG = new Texture2D(4, 4, TextureFormat.ARGB32, false, false);
		if (www.isDone)
		{
			www.LoadImageIntoTexture(this.texcontainer.KEDGAOBCNJG);
			this.texcontainer.KEDGAOBCNJG.filterMode = this.texcontainer.OECLFHEEHEG;
			this.texcontainer.KEDGAOBCNJG.Apply();
			this.tex = this.texcontainer.KEDGAOBCNJG;
			this.texcontainer.OINDOLGBLOC = true;
			this.texcontainer.IALKJFLJBCP();
		}
		string error = www.error;
		www.Dispose();
		www = null;
		GC.Collect();
		UnityEngine.Object.Destroy(base.gameObject);
		yield break;
	}

	// Token: 0x060099DE RID: 39390 RVA: 0x004455FC File Offset: 0x004437FC
	public void DHCNKDCAEKB(CKNLPGEPGGF.IAPCJOBDCEH JACEPAEHGPM)
	{
		this.texcontainer = JACEPAEHGPM;
		if (!File.Exists(this.texcontainer.ALBOCLBFNNI.Substring(3)))
		{
			this.texcontainer.OINDOLGBLOC = true;
			this.texcontainer.OJFNGJKLOGM();
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.StartCoroutine("WalkDehydrated");
	}

	// Token: 0x060099DF RID: 39391 RVA: 0x0044541F File Offset: 0x0044361F
	private IEnumerator GAHCAOCEGAC()
	{
		TextureLoader.HBFOOIAFNIL hbfooiafnil = new TextureLoader.HBFOOIAFNIL(1);
		hbfooiafnil.AENJLLPLILM = this;
		return hbfooiafnil;
	}

	// Token: 0x060099E0 RID: 39392 RVA: 0x004451E7 File Offset: 0x004433E7
	private IEnumerator ECNBEICGHAL()
	{
		this.texcontainer.PMJIHPFGCGJ = true;
		base.gameObject.name = "TextureLoader: " + this.texcontainer.ALBOCLBFNNI;
		www = new WWW(this.texcontainer.ALBOCLBFNNI);
		yield return www;
		this.texcontainer.PMJIHPFGCGJ = false;
		this.texcontainer.KEDGAOBCNJG = new Texture2D(4, 4, TextureFormat.ARGB32, false, false);
		if (www.isDone)
		{
			www.LoadImageIntoTexture(this.texcontainer.KEDGAOBCNJG);
			this.texcontainer.KEDGAOBCNJG.filterMode = this.texcontainer.OECLFHEEHEG;
			this.texcontainer.KEDGAOBCNJG.Apply();
			this.tex = this.texcontainer.KEDGAOBCNJG;
			this.texcontainer.OINDOLGBLOC = true;
			this.texcontainer.IALKJFLJBCP();
		}
		string error = www.error;
		www.Dispose();
		www = null;
		GC.Collect();
		UnityEngine.Object.Destroy(base.gameObject);
		yield break;
	}

	// Token: 0x060099E1 RID: 39393 RVA: 0x004451E7 File Offset: 0x004433E7
	private IEnumerator AIPFLAIDCMF()
	{
		this.texcontainer.PMJIHPFGCGJ = true;
		base.gameObject.name = "TextureLoader: " + this.texcontainer.ALBOCLBFNNI;
		www = new WWW(this.texcontainer.ALBOCLBFNNI);
		yield return www;
		this.texcontainer.PMJIHPFGCGJ = false;
		this.texcontainer.KEDGAOBCNJG = new Texture2D(4, 4, TextureFormat.ARGB32, false, false);
		if (www.isDone)
		{
			www.LoadImageIntoTexture(this.texcontainer.KEDGAOBCNJG);
			this.texcontainer.KEDGAOBCNJG.filterMode = this.texcontainer.OECLFHEEHEG;
			this.texcontainer.KEDGAOBCNJG.Apply();
			this.tex = this.texcontainer.KEDGAOBCNJG;
			this.texcontainer.OINDOLGBLOC = true;
			this.texcontainer.IALKJFLJBCP();
		}
		string error = www.error;
		www.Dispose();
		www = null;
		GC.Collect();
		UnityEngine.Object.Destroy(base.gameObject);
		yield break;
	}

	// Token: 0x060099E2 RID: 39394 RVA: 0x00445658 File Offset: 0x00443858
	public void MKLABJOONHH(CKNLPGEPGGF.IAPCJOBDCEH JACEPAEHGPM)
	{
		this.texcontainer = JACEPAEHGPM;
		if (!File.Exists(this.texcontainer.ALBOCLBFNNI.Substring(1)))
		{
			this.texcontainer.OINDOLGBLOC = false;
			this.texcontainer.IALKJFLJBCP();
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.StartCoroutine("Giant2HandGrab");
	}

	// Token: 0x060099E3 RID: 39395 RVA: 0x004451E7 File Offset: 0x004433E7
	private IEnumerator APLFLLJGMAO()
	{
		this.texcontainer.PMJIHPFGCGJ = true;
		base.gameObject.name = "TextureLoader: " + this.texcontainer.ALBOCLBFNNI;
		www = new WWW(this.texcontainer.ALBOCLBFNNI);
		yield return www;
		this.texcontainer.PMJIHPFGCGJ = false;
		this.texcontainer.KEDGAOBCNJG = new Texture2D(4, 4, TextureFormat.ARGB32, false, false);
		if (www.isDone)
		{
			www.LoadImageIntoTexture(this.texcontainer.KEDGAOBCNJG);
			this.texcontainer.KEDGAOBCNJG.filterMode = this.texcontainer.OECLFHEEHEG;
			this.texcontainer.KEDGAOBCNJG.Apply();
			this.tex = this.texcontainer.KEDGAOBCNJG;
			this.texcontainer.OINDOLGBLOC = true;
			this.texcontainer.IALKJFLJBCP();
		}
		string error = www.error;
		www.Dispose();
		www = null;
		GC.Collect();
		UnityEngine.Object.Destroy(base.gameObject);
		yield break;
	}

	// Token: 0x060099E4 RID: 39396 RVA: 0x0044541F File Offset: 0x0044361F
	private IEnumerator DOHPKOEIFPK()
	{
		TextureLoader.HBFOOIAFNIL hbfooiafnil = new TextureLoader.HBFOOIAFNIL(1);
		hbfooiafnil.AENJLLPLILM = this;
		return hbfooiafnil;
	}

	// Token: 0x060099E5 RID: 39397 RVA: 0x004456B4 File Offset: 0x004438B4
	public void FAEJFDJKMBN(CKNLPGEPGGF.IAPCJOBDCEH JACEPAEHGPM)
	{
		this.texcontainer = JACEPAEHGPM;
		if (!File.Exists(this.texcontainer.ALBOCLBFNNI.Substring(2)))
		{
			this.texcontainer.OINDOLGBLOC = true;
			this.texcontainer.FHMMOMPDCNL();
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.StartCoroutine("Sounds/Hit");
	}

	// Token: 0x060099E6 RID: 39398 RVA: 0x00445710 File Offset: 0x00443910
	public void HKLMPNIIAKG(CKNLPGEPGGF.IAPCJOBDCEH JACEPAEHGPM)
	{
		this.texcontainer = JACEPAEHGPM;
		if (!File.Exists(this.texcontainer.ALBOCLBFNNI.Substring(0)))
		{
			this.texcontainer.OINDOLGBLOC = false;
			this.texcontainer.JHOMNOPGPIL();
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.StartCoroutine("Low adminlevel!");
	}

	// Token: 0x060099E7 RID: 39399 RVA: 0x0044576C File Offset: 0x0044396C
	public void EMNKDANKGMO(CKNLPGEPGGF.IAPCJOBDCEH JACEPAEHGPM)
	{
		this.texcontainer = JACEPAEHGPM;
		if (!File.Exists(this.texcontainer.ALBOCLBFNNI.Substring(7)))
		{
			this.texcontainer.OINDOLGBLOC = false;
			this.texcontainer.LEMNPOFGDGC();
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.StartCoroutine("#mem Sound ");
	}

	// Token: 0x060099E8 RID: 39400 RVA: 0x004457C8 File Offset: 0x004439C8
	public void GPOGHEDNKJB(CKNLPGEPGGF.IAPCJOBDCEH JACEPAEHGPM)
	{
		this.texcontainer = JACEPAEHGPM;
		if (!File.Exists(this.texcontainer.ALBOCLBFNNI.Substring(6)))
		{
			this.texcontainer.OINDOLGBLOC = false;
			this.texcontainer.IALKJFLJBCP();
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.StartCoroutine("WizardNeoBlock");
	}

	// Token: 0x060099E9 RID: 39401 RVA: 0x0044541F File Offset: 0x0044361F
	private IEnumerator NOJLNNNJPME()
	{
		TextureLoader.HBFOOIAFNIL hbfooiafnil = new TextureLoader.HBFOOIAFNIL(1);
		hbfooiafnil.AENJLLPLILM = this;
		return hbfooiafnil;
	}

	// Token: 0x060099EA RID: 39402 RVA: 0x004451E7 File Offset: 0x004433E7
	private IEnumerator MEJILIGNIGD()
	{
		this.texcontainer.PMJIHPFGCGJ = true;
		base.gameObject.name = "TextureLoader: " + this.texcontainer.ALBOCLBFNNI;
		www = new WWW(this.texcontainer.ALBOCLBFNNI);
		yield return www;
		this.texcontainer.PMJIHPFGCGJ = false;
		this.texcontainer.KEDGAOBCNJG = new Texture2D(4, 4, TextureFormat.ARGB32, false, false);
		if (www.isDone)
		{
			www.LoadImageIntoTexture(this.texcontainer.KEDGAOBCNJG);
			this.texcontainer.KEDGAOBCNJG.filterMode = this.texcontainer.OECLFHEEHEG;
			this.texcontainer.KEDGAOBCNJG.Apply();
			this.tex = this.texcontainer.KEDGAOBCNJG;
			this.texcontainer.OINDOLGBLOC = true;
			this.texcontainer.IALKJFLJBCP();
		}
		string error = www.error;
		www.Dispose();
		www = null;
		GC.Collect();
		UnityEngine.Object.Destroy(base.gameObject);
		yield break;
	}

	// Token: 0x060099EB RID: 39403 RVA: 0x004451E7 File Offset: 0x004433E7
	private IEnumerator CLECEDJOGDL()
	{
		this.texcontainer.PMJIHPFGCGJ = true;
		base.gameObject.name = "TextureLoader: " + this.texcontainer.ALBOCLBFNNI;
		www = new WWW(this.texcontainer.ALBOCLBFNNI);
		yield return www;
		this.texcontainer.PMJIHPFGCGJ = false;
		this.texcontainer.KEDGAOBCNJG = new Texture2D(4, 4, TextureFormat.ARGB32, false, false);
		if (www.isDone)
		{
			www.LoadImageIntoTexture(this.texcontainer.KEDGAOBCNJG);
			this.texcontainer.KEDGAOBCNJG.filterMode = this.texcontainer.OECLFHEEHEG;
			this.texcontainer.KEDGAOBCNJG.Apply();
			this.tex = this.texcontainer.KEDGAOBCNJG;
			this.texcontainer.OINDOLGBLOC = true;
			this.texcontainer.IALKJFLJBCP();
		}
		string error = www.error;
		www.Dispose();
		www = null;
		GC.Collect();
		UnityEngine.Object.Destroy(base.gameObject);
		yield break;
	}

	// Token: 0x060099EC RID: 39404 RVA: 0x004451E7 File Offset: 0x004433E7
	private IEnumerator OJNCMMPLEBM()
	{
		this.texcontainer.PMJIHPFGCGJ = true;
		base.gameObject.name = "TextureLoader: " + this.texcontainer.ALBOCLBFNNI;
		www = new WWW(this.texcontainer.ALBOCLBFNNI);
		yield return www;
		this.texcontainer.PMJIHPFGCGJ = false;
		this.texcontainer.KEDGAOBCNJG = new Texture2D(4, 4, TextureFormat.ARGB32, false, false);
		if (www.isDone)
		{
			www.LoadImageIntoTexture(this.texcontainer.KEDGAOBCNJG);
			this.texcontainer.KEDGAOBCNJG.filterMode = this.texcontainer.OECLFHEEHEG;
			this.texcontainer.KEDGAOBCNJG.Apply();
			this.tex = this.texcontainer.KEDGAOBCNJG;
			this.texcontainer.OINDOLGBLOC = true;
			this.texcontainer.IALKJFLJBCP();
		}
		string error = www.error;
		www.Dispose();
		www = null;
		GC.Collect();
		UnityEngine.Object.Destroy(base.gameObject);
		yield break;
	}

	// Token: 0x060099ED RID: 39405 RVA: 0x0044541F File Offset: 0x0044361F
	private IEnumerator KPMKBGFJJKJ()
	{
		TextureLoader.HBFOOIAFNIL hbfooiafnil = new TextureLoader.HBFOOIAFNIL(1);
		hbfooiafnil.AENJLLPLILM = this;
		return hbfooiafnil;
	}

	// Token: 0x060099EE RID: 39406 RVA: 0x00445824 File Offset: 0x00443A24
	public void OMINEFBGIHP(CKNLPGEPGGF.IAPCJOBDCEH JACEPAEHGPM)
	{
		this.texcontainer = JACEPAEHGPM;
		if (!File.Exists(this.texcontainer.ALBOCLBFNNI.Substring(4)))
		{
			this.texcontainer.OINDOLGBLOC = false;
			this.texcontainer.FHMMOMPDCNL();
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.StartCoroutine("1 Hand Sword");
	}

	// Token: 0x060099EF RID: 39407 RVA: 0x00445880 File Offset: 0x00443A80
	public void OJBKBNPDJHJ(CKNLPGEPGGF.IAPCJOBDCEH JACEPAEHGPM)
	{
		this.texcontainer = JACEPAEHGPM;
		if (!File.Exists(this.texcontainer.ALBOCLBFNNI.Substring(6)))
		{
			this.texcontainer.OINDOLGBLOC = true;
			this.texcontainer.FBCJONKDLDC();
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.StartCoroutine("");
	}

	// Token: 0x060099F1 RID: 39409 RVA: 0x0044541F File Offset: 0x0044361F
	private IEnumerator MEDJCDMNNAD()
	{
		TextureLoader.HBFOOIAFNIL hbfooiafnil = new TextureLoader.HBFOOIAFNIL(1);
		hbfooiafnil.AENJLLPLILM = this;
		return hbfooiafnil;
	}

	// Token: 0x060099F2 RID: 39410 RVA: 0x0044541F File Offset: 0x0044361F
	private IEnumerator BECNILCKBHF()
	{
		TextureLoader.HBFOOIAFNIL hbfooiafnil = new TextureLoader.HBFOOIAFNIL(1);
		hbfooiafnil.AENJLLPLILM = this;
		return hbfooiafnil;
	}

	// Token: 0x060099F3 RID: 39411 RVA: 0x004458DC File Offset: 0x00443ADC
	public void EOMOHJPLFLM(CKNLPGEPGGF.IAPCJOBDCEH JACEPAEHGPM)
	{
		this.texcontainer = JACEPAEHGPM;
		if (!File.Exists(this.texcontainer.ALBOCLBFNNI.Substring(6)))
		{
			this.texcontainer.OINDOLGBLOC = false;
			this.texcontainer.ONCLONDJKGC();
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.StartCoroutine("ENABLE_COLOR_GRADING");
	}

	// Token: 0x060099F4 RID: 39412 RVA: 0x004451E7 File Offset: 0x004433E7
	private IEnumerator NIJHFEFMBHP()
	{
		this.texcontainer.PMJIHPFGCGJ = true;
		base.gameObject.name = "TextureLoader: " + this.texcontainer.ALBOCLBFNNI;
		www = new WWW(this.texcontainer.ALBOCLBFNNI);
		yield return www;
		this.texcontainer.PMJIHPFGCGJ = false;
		this.texcontainer.KEDGAOBCNJG = new Texture2D(4, 4, TextureFormat.ARGB32, false, false);
		if (www.isDone)
		{
			www.LoadImageIntoTexture(this.texcontainer.KEDGAOBCNJG);
			this.texcontainer.KEDGAOBCNJG.filterMode = this.texcontainer.OECLFHEEHEG;
			this.texcontainer.KEDGAOBCNJG.Apply();
			this.tex = this.texcontainer.KEDGAOBCNJG;
			this.texcontainer.OINDOLGBLOC = true;
			this.texcontainer.IALKJFLJBCP();
		}
		string error = www.error;
		www.Dispose();
		www = null;
		GC.Collect();
		UnityEngine.Object.Destroy(base.gameObject);
		yield break;
	}

	// Token: 0x060099F5 RID: 39413 RVA: 0x0044541F File Offset: 0x0044361F
	private IEnumerator BPBDBPKJLFA()
	{
		TextureLoader.HBFOOIAFNIL hbfooiafnil = new TextureLoader.HBFOOIAFNIL(1);
		hbfooiafnil.AENJLLPLILM = this;
		return hbfooiafnil;
	}

	// Token: 0x060099F6 RID: 39414 RVA: 0x004451E7 File Offset: 0x004433E7
	private IEnumerator LJGCEGHKCME()
	{
		this.texcontainer.PMJIHPFGCGJ = true;
		base.gameObject.name = "TextureLoader: " + this.texcontainer.ALBOCLBFNNI;
		www = new WWW(this.texcontainer.ALBOCLBFNNI);
		yield return www;
		this.texcontainer.PMJIHPFGCGJ = false;
		this.texcontainer.KEDGAOBCNJG = new Texture2D(4, 4, TextureFormat.ARGB32, false, false);
		if (www.isDone)
		{
			www.LoadImageIntoTexture(this.texcontainer.KEDGAOBCNJG);
			this.texcontainer.KEDGAOBCNJG.filterMode = this.texcontainer.OECLFHEEHEG;
			this.texcontainer.KEDGAOBCNJG.Apply();
			this.tex = this.texcontainer.KEDGAOBCNJG;
			this.texcontainer.OINDOLGBLOC = true;
			this.texcontainer.IALKJFLJBCP();
		}
		string error = www.error;
		www.Dispose();
		www = null;
		GC.Collect();
		UnityEngine.Object.Destroy(base.gameObject);
		yield break;
	}

	// Token: 0x060099F7 RID: 39415 RVA: 0x00445938 File Offset: 0x00443B38
	public void FJNGBEPBAKE(CKNLPGEPGGF.IAPCJOBDCEH JACEPAEHGPM)
	{
		this.texcontainer = JACEPAEHGPM;
		if (!File.Exists(this.texcontainer.ALBOCLBFNNI.Substring(1)))
		{
			this.texcontainer.OINDOLGBLOC = true;
			this.texcontainer.NDHKCMCNMFO();
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.StartCoroutine("PistolInstant");
	}

	// Token: 0x060099F8 RID: 39416 RVA: 0x0044541F File Offset: 0x0044361F
	private IEnumerator LOLCAEODLAD()
	{
		TextureLoader.HBFOOIAFNIL hbfooiafnil = new TextureLoader.HBFOOIAFNIL(1);
		hbfooiafnil.AENJLLPLILM = this;
		return hbfooiafnil;
	}

	// Token: 0x060099F9 RID: 39417 RVA: 0x0044541F File Offset: 0x0044361F
	private IEnumerator NDILDFNBNLJ()
	{
		TextureLoader.HBFOOIAFNIL hbfooiafnil = new TextureLoader.HBFOOIAFNIL(1);
		hbfooiafnil.AENJLLPLILM = this;
		return hbfooiafnil;
	}

	// Token: 0x060099FA RID: 39418 RVA: 0x00445994 File Offset: 0x00443B94
	public void COJCDJGPGDN(CKNLPGEPGGF.IAPCJOBDCEH JACEPAEHGPM)
	{
		this.texcontainer = JACEPAEHGPM;
		if (!File.Exists(this.texcontainer.ALBOCLBFNNI.Substring(6)))
		{
			this.texcontainer.OINDOLGBLOC = false;
			this.texcontainer.JHOMNOPGPIL();
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.StartCoroutine("https://groups.google.com/forum/#!forum/final-ik");
	}

	// Token: 0x060099FB RID: 39419 RVA: 0x004459F0 File Offset: 0x00443BF0
	public void IJLMBMMBFAC(CKNLPGEPGGF.IAPCJOBDCEH JACEPAEHGPM)
	{
		this.texcontainer = JACEPAEHGPM;
		if (!File.Exists(this.texcontainer.ALBOCLBFNNI.Substring(8)))
		{
			this.texcontainer.OINDOLGBLOC = true;
			this.texcontainer.EBIIBBHKAAK();
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.StartCoroutine("");
	}

	// Token: 0x060099FC RID: 39420 RVA: 0x00445A4C File Offset: 0x00443C4C
	public void NCEOOAKLDAG(CKNLPGEPGGF.IAPCJOBDCEH JACEPAEHGPM)
	{
		this.texcontainer = JACEPAEHGPM;
		if (!File.Exists(this.texcontainer.ALBOCLBFNNI.Substring(8)))
		{
			this.texcontainer.OINDOLGBLOC = false;
			this.texcontainer.IICGEOOFMKL();
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.StartCoroutine("ClimbRight");
	}

	// Token: 0x060099FD RID: 39421 RVA: 0x00445AA8 File Offset: 0x00443CA8
	public void PJGEONLNFLB(CKNLPGEPGGF.IAPCJOBDCEH JACEPAEHGPM)
	{
		this.texcontainer = JACEPAEHGPM;
		if (!File.Exists(this.texcontainer.ALBOCLBFNNI.Substring(7)))
		{
			this.texcontainer.OINDOLGBLOC = false;
			this.texcontainer.MHFLMGOIBBA();
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.StartCoroutine("BowInstant2");
	}

	// Token: 0x060099FE RID: 39422 RVA: 0x004451E7 File Offset: 0x004433E7
	private IEnumerator MJNIEGNLKMJ()
	{
		this.texcontainer.PMJIHPFGCGJ = true;
		base.gameObject.name = "TextureLoader: " + this.texcontainer.ALBOCLBFNNI;
		www = new WWW(this.texcontainer.ALBOCLBFNNI);
		yield return www;
		this.texcontainer.PMJIHPFGCGJ = false;
		this.texcontainer.KEDGAOBCNJG = new Texture2D(4, 4, TextureFormat.ARGB32, false, false);
		if (www.isDone)
		{
			www.LoadImageIntoTexture(this.texcontainer.KEDGAOBCNJG);
			this.texcontainer.KEDGAOBCNJG.filterMode = this.texcontainer.OECLFHEEHEG;
			this.texcontainer.KEDGAOBCNJG.Apply();
			this.tex = this.texcontainer.KEDGAOBCNJG;
			this.texcontainer.OINDOLGBLOC = true;
			this.texcontainer.IALKJFLJBCP();
		}
		string error = www.error;
		www.Dispose();
		www = null;
		GC.Collect();
		UnityEngine.Object.Destroy(base.gameObject);
		yield break;
	}

	// Token: 0x060099FF RID: 39423 RVA: 0x0044541F File Offset: 0x0044361F
	private IEnumerator IOPNDKAEGDD()
	{
		TextureLoader.HBFOOIAFNIL hbfooiafnil = new TextureLoader.HBFOOIAFNIL(1);
		hbfooiafnil.AENJLLPLILM = this;
		return hbfooiafnil;
	}

	// Token: 0x06009A00 RID: 39424 RVA: 0x00445B04 File Offset: 0x00443D04
	public void GOCNNPOGAOH(CKNLPGEPGGF.IAPCJOBDCEH JACEPAEHGPM)
	{
		this.texcontainer = JACEPAEHGPM;
		if (!File.Exists(this.texcontainer.ALBOCLBFNNI.Substring(8)))
		{
			this.texcontainer.OINDOLGBLOC = true;
			this.texcontainer.NDHKCMCNMFO();
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.StartCoroutine("Hand ");
	}

	// Token: 0x06009A01 RID: 39425 RVA: 0x0044541F File Offset: 0x0044361F
	private IEnumerator OIKPPHBLPLK()
	{
		TextureLoader.HBFOOIAFNIL hbfooiafnil = new TextureLoader.HBFOOIAFNIL(1);
		hbfooiafnil.AENJLLPLILM = this;
		return hbfooiafnil;
	}

	// Token: 0x06009A02 RID: 39426 RVA: 0x00445B60 File Offset: 0x00443D60
	public void EEIEGIKGPCJ(CKNLPGEPGGF.IAPCJOBDCEH JACEPAEHGPM)
	{
		this.texcontainer = JACEPAEHGPM;
		if (!File.Exists(this.texcontainer.ALBOCLBFNNI.Substring(4)))
		{
			this.texcontainer.OINDOLGBLOC = false;
			this.texcontainer.OJFNGJKLOGM();
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.StartCoroutine("TOD_kScale");
	}

	// Token: 0x06009A03 RID: 39427 RVA: 0x00445BBC File Offset: 0x00443DBC
	public void DNEAOCJCMMK(CKNLPGEPGGF.IAPCJOBDCEH JACEPAEHGPM)
	{
		this.texcontainer = JACEPAEHGPM;
		if (!File.Exists(this.texcontainer.ALBOCLBFNNI.Substring(3)))
		{
			this.texcontainer.OINDOLGBLOC = true;
			this.texcontainer.NDHKCMCNMFO();
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.StartCoroutine("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_aim_i_k.html");
	}

	// Token: 0x06009A04 RID: 39428 RVA: 0x004451E7 File Offset: 0x004433E7
	private IEnumerator AIEDGDJNOBA()
	{
		this.texcontainer.PMJIHPFGCGJ = true;
		base.gameObject.name = "TextureLoader: " + this.texcontainer.ALBOCLBFNNI;
		www = new WWW(this.texcontainer.ALBOCLBFNNI);
		yield return www;
		this.texcontainer.PMJIHPFGCGJ = false;
		this.texcontainer.KEDGAOBCNJG = new Texture2D(4, 4, TextureFormat.ARGB32, false, false);
		if (www.isDone)
		{
			www.LoadImageIntoTexture(this.texcontainer.KEDGAOBCNJG);
			this.texcontainer.KEDGAOBCNJG.filterMode = this.texcontainer.OECLFHEEHEG;
			this.texcontainer.KEDGAOBCNJG.Apply();
			this.tex = this.texcontainer.KEDGAOBCNJG;
			this.texcontainer.OINDOLGBLOC = true;
			this.texcontainer.IALKJFLJBCP();
		}
		string error = www.error;
		www.Dispose();
		www = null;
		GC.Collect();
		UnityEngine.Object.Destroy(base.gameObject);
		yield break;
	}

	// Token: 0x06009A05 RID: 39429 RVA: 0x004451E7 File Offset: 0x004433E7
	private IEnumerator AAPEMEDMBDN()
	{
		this.texcontainer.PMJIHPFGCGJ = true;
		base.gameObject.name = "TextureLoader: " + this.texcontainer.ALBOCLBFNNI;
		www = new WWW(this.texcontainer.ALBOCLBFNNI);
		yield return www;
		this.texcontainer.PMJIHPFGCGJ = false;
		this.texcontainer.KEDGAOBCNJG = new Texture2D(4, 4, TextureFormat.ARGB32, false, false);
		if (www.isDone)
		{
			www.LoadImageIntoTexture(this.texcontainer.KEDGAOBCNJG);
			this.texcontainer.KEDGAOBCNJG.filterMode = this.texcontainer.OECLFHEEHEG;
			this.texcontainer.KEDGAOBCNJG.Apply();
			this.tex = this.texcontainer.KEDGAOBCNJG;
			this.texcontainer.OINDOLGBLOC = true;
			this.texcontainer.IALKJFLJBCP();
		}
		string error = www.error;
		www.Dispose();
		www = null;
		GC.Collect();
		UnityEngine.Object.Destroy(base.gameObject);
		yield break;
	}

	// Token: 0x06009A06 RID: 39430 RVA: 0x0044541F File Offset: 0x0044361F
	private IEnumerator FLDKNABKJFK()
	{
		TextureLoader.HBFOOIAFNIL hbfooiafnil = new TextureLoader.HBFOOIAFNIL(1);
		hbfooiafnil.AENJLLPLILM = this;
		return hbfooiafnil;
	}

	// Token: 0x06009A07 RID: 39431 RVA: 0x004451E7 File Offset: 0x004433E7
	private IEnumerator MNFHEDBOEPM()
	{
		this.texcontainer.PMJIHPFGCGJ = true;
		base.gameObject.name = "TextureLoader: " + this.texcontainer.ALBOCLBFNNI;
		www = new WWW(this.texcontainer.ALBOCLBFNNI);
		yield return www;
		this.texcontainer.PMJIHPFGCGJ = false;
		this.texcontainer.KEDGAOBCNJG = new Texture2D(4, 4, TextureFormat.ARGB32, false, false);
		if (www.isDone)
		{
			www.LoadImageIntoTexture(this.texcontainer.KEDGAOBCNJG);
			this.texcontainer.KEDGAOBCNJG.filterMode = this.texcontainer.OECLFHEEHEG;
			this.texcontainer.KEDGAOBCNJG.Apply();
			this.tex = this.texcontainer.KEDGAOBCNJG;
			this.texcontainer.OINDOLGBLOC = true;
			this.texcontainer.IALKJFLJBCP();
		}
		string error = www.error;
		www.Dispose();
		www = null;
		GC.Collect();
		UnityEngine.Object.Destroy(base.gameObject);
		yield break;
	}

	// Token: 0x06009A08 RID: 39432 RVA: 0x00445C18 File Offset: 0x00443E18
	public void NOOHBCIHLKG(CKNLPGEPGGF.IAPCJOBDCEH JACEPAEHGPM)
	{
		this.texcontainer = JACEPAEHGPM;
		if (!File.Exists(this.texcontainer.ALBOCLBFNNI.Substring(0)))
		{
			this.texcontainer.OINDOLGBLOC = true;
			this.texcontainer.FBCJONKDLDC();
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.StartCoroutine("|");
	}

	// Token: 0x06009A09 RID: 39433 RVA: 0x00445C74 File Offset: 0x00443E74
	public void GBEJBOOHGLE(CKNLPGEPGGF.IAPCJOBDCEH JACEPAEHGPM)
	{
		this.texcontainer = JACEPAEHGPM;
		if (!File.Exists(this.texcontainer.ALBOCLBFNNI.Substring(1)))
		{
			this.texcontainer.OINDOLGBLOC = false;
			this.texcontainer.JHOMNOPGPIL();
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.StartCoroutine("GiantGrabThrow");
	}

	// Token: 0x06009A0A RID: 39434 RVA: 0x004451E7 File Offset: 0x004433E7
	private IEnumerator BKKIJHJJMPO()
	{
		this.texcontainer.PMJIHPFGCGJ = true;
		base.gameObject.name = "TextureLoader: " + this.texcontainer.ALBOCLBFNNI;
		www = new WWW(this.texcontainer.ALBOCLBFNNI);
		yield return www;
		this.texcontainer.PMJIHPFGCGJ = false;
		this.texcontainer.KEDGAOBCNJG = new Texture2D(4, 4, TextureFormat.ARGB32, false, false);
		if (www.isDone)
		{
			www.LoadImageIntoTexture(this.texcontainer.KEDGAOBCNJG);
			this.texcontainer.KEDGAOBCNJG.filterMode = this.texcontainer.OECLFHEEHEG;
			this.texcontainer.KEDGAOBCNJG.Apply();
			this.tex = this.texcontainer.KEDGAOBCNJG;
			this.texcontainer.OINDOLGBLOC = true;
			this.texcontainer.IALKJFLJBCP();
		}
		string error = www.error;
		www.Dispose();
		www = null;
		GC.Collect();
		UnityEngine.Object.Destroy(base.gameObject);
		yield break;
	}

	// Token: 0x06009A0B RID: 39435 RVA: 0x00445CD0 File Offset: 0x00443ED0
	public void IHKFLMEKLGH(CKNLPGEPGGF.IAPCJOBDCEH JACEPAEHGPM)
	{
		this.texcontainer = JACEPAEHGPM;
		if (!File.Exists(this.texcontainer.ALBOCLBFNNI.Substring(5)))
		{
			this.texcontainer.OINDOLGBLOC = true;
			this.texcontainer.IICGEOOFMKL();
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.StartCoroutine("RunningDance");
	}

	// Token: 0x06009A0C RID: 39436 RVA: 0x00445D2C File Offset: 0x00443F2C
	public void JLCBDJCEAOI(CKNLPGEPGGF.IAPCJOBDCEH JACEPAEHGPM)
	{
		this.texcontainer = JACEPAEHGPM;
		if (!File.Exists(this.texcontainer.ALBOCLBFNNI.Substring(3)))
		{
			this.texcontainer.OINDOLGBLOC = false;
			this.texcontainer.NDHKCMCNMFO();
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.StartCoroutine("");
	}

	// Token: 0x06009A0D RID: 39437 RVA: 0x0044541F File Offset: 0x0044361F
	private IEnumerator OAEPHFKANJK()
	{
		TextureLoader.HBFOOIAFNIL hbfooiafnil = new TextureLoader.HBFOOIAFNIL(1);
		hbfooiafnil.AENJLLPLILM = this;
		return hbfooiafnil;
	}

	// Token: 0x06009A0E RID: 39438 RVA: 0x00445D88 File Offset: 0x00443F88
	public void CHBIJJLDEDL(CKNLPGEPGGF.IAPCJOBDCEH JACEPAEHGPM)
	{
		this.texcontainer = JACEPAEHGPM;
		if (!File.Exists(this.texcontainer.ALBOCLBFNNI.Substring(7)))
		{
			this.texcontainer.OINDOLGBLOC = false;
			this.texcontainer.MPLNOLEPEJC();
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.StartCoroutine("_WaveOffset");
	}

	// Token: 0x06009A0F RID: 39439 RVA: 0x0044541F File Offset: 0x0044361F
	private IEnumerator FBJEKCKEGHI()
	{
		TextureLoader.HBFOOIAFNIL hbfooiafnil = new TextureLoader.HBFOOIAFNIL(1);
		hbfooiafnil.AENJLLPLILM = this;
		return hbfooiafnil;
	}

	// Token: 0x06009A10 RID: 39440 RVA: 0x0044541F File Offset: 0x0044361F
	private IEnumerator LOKBEGBABJP()
	{
		TextureLoader.HBFOOIAFNIL hbfooiafnil = new TextureLoader.HBFOOIAFNIL(1);
		hbfooiafnil.AENJLLPLILM = this;
		return hbfooiafnil;
	}

	// Token: 0x06009A11 RID: 39441 RVA: 0x00445DE4 File Offset: 0x00443FE4
	public void DILOKGPAMOB(CKNLPGEPGGF.IAPCJOBDCEH JACEPAEHGPM)
	{
		this.texcontainer = JACEPAEHGPM;
		if (!File.Exists(this.texcontainer.ALBOCLBFNNI.Substring(3)))
		{
			this.texcontainer.OINDOLGBLOC = true;
			this.texcontainer.EBIIBBHKAAK();
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.StartCoroutine("none id=");
	}

	// Token: 0x06009A12 RID: 39442 RVA: 0x00445E40 File Offset: 0x00444040
	public void KPFMLLGBJAD(CKNLPGEPGGF.IAPCJOBDCEH JACEPAEHGPM)
	{
		this.texcontainer = JACEPAEHGPM;
		if (!File.Exists(this.texcontainer.ALBOCLBFNNI.Substring(2)))
		{
			this.texcontainer.OINDOLGBLOC = true;
			this.texcontainer.EDIOFJIFBFB();
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.StartCoroutine("gameComplete");
	}

	// Token: 0x06009A13 RID: 39443 RVA: 0x004451E7 File Offset: 0x004433E7
	private IEnumerator HBFHCOODGDE()
	{
		this.texcontainer.PMJIHPFGCGJ = true;
		base.gameObject.name = "TextureLoader: " + this.texcontainer.ALBOCLBFNNI;
		www = new WWW(this.texcontainer.ALBOCLBFNNI);
		yield return www;
		this.texcontainer.PMJIHPFGCGJ = false;
		this.texcontainer.KEDGAOBCNJG = new Texture2D(4, 4, TextureFormat.ARGB32, false, false);
		if (www.isDone)
		{
			www.LoadImageIntoTexture(this.texcontainer.KEDGAOBCNJG);
			this.texcontainer.KEDGAOBCNJG.filterMode = this.texcontainer.OECLFHEEHEG;
			this.texcontainer.KEDGAOBCNJG.Apply();
			this.tex = this.texcontainer.KEDGAOBCNJG;
			this.texcontainer.OINDOLGBLOC = true;
			this.texcontainer.IALKJFLJBCP();
		}
		string error = www.error;
		www.Dispose();
		www = null;
		GC.Collect();
		UnityEngine.Object.Destroy(base.gameObject);
		yield break;
	}

	// Token: 0x06009A14 RID: 39444 RVA: 0x00445E9C File Offset: 0x0044409C
	public void DPBNPPKEPIP(CKNLPGEPGGF.IAPCJOBDCEH JACEPAEHGPM)
	{
		this.texcontainer = JACEPAEHGPM;
		if (!File.Exists(this.texcontainer.ALBOCLBFNNI.Substring(7)))
		{
			this.texcontainer.OINDOLGBLOC = false;
			this.texcontainer.LEMNPOFGDGC();
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.StartCoroutine("Vertical");
	}

	// Token: 0x06009A15 RID: 39445 RVA: 0x00445EF8 File Offset: 0x004440F8
	public void HOLMNGFNJON(CKNLPGEPGGF.IAPCJOBDCEH JACEPAEHGPM)
	{
		this.texcontainer = JACEPAEHGPM;
		if (!File.Exists(this.texcontainer.ALBOCLBFNNI.Substring(0)))
		{
			this.texcontainer.OINDOLGBLOC = false;
			this.texcontainer.JNFNCLMDLKA();
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.StartCoroutine("cht_maxcnt");
	}

	// Token: 0x06009A16 RID: 39446 RVA: 0x004451E7 File Offset: 0x004433E7
	private IEnumerator NAAHPNPJLPL()
	{
		this.texcontainer.PMJIHPFGCGJ = true;
		base.gameObject.name = "TextureLoader: " + this.texcontainer.ALBOCLBFNNI;
		www = new WWW(this.texcontainer.ALBOCLBFNNI);
		yield return www;
		this.texcontainer.PMJIHPFGCGJ = false;
		this.texcontainer.KEDGAOBCNJG = new Texture2D(4, 4, TextureFormat.ARGB32, false, false);
		if (www.isDone)
		{
			www.LoadImageIntoTexture(this.texcontainer.KEDGAOBCNJG);
			this.texcontainer.KEDGAOBCNJG.filterMode = this.texcontainer.OECLFHEEHEG;
			this.texcontainer.KEDGAOBCNJG.Apply();
			this.tex = this.texcontainer.KEDGAOBCNJG;
			this.texcontainer.OINDOLGBLOC = true;
			this.texcontainer.IALKJFLJBCP();
		}
		string error = www.error;
		www.Dispose();
		www = null;
		GC.Collect();
		UnityEngine.Object.Destroy(base.gameObject);
		yield break;
	}

	// Token: 0x06009A17 RID: 39447 RVA: 0x00445F54 File Offset: 0x00444154
	public void DOBCNHDAHHI(CKNLPGEPGGF.IAPCJOBDCEH JACEPAEHGPM)
	{
		this.texcontainer = JACEPAEHGPM;
		if (!File.Exists(this.texcontainer.ALBOCLBFNNI.Substring(6)))
		{
			this.texcontainer.OINDOLGBLOC = true;
			this.texcontainer.EBIIBBHKAAK();
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.StartCoroutine("Missing shader for image effect {0}");
	}

	// Token: 0x06009A18 RID: 39448 RVA: 0x0044541F File Offset: 0x0044361F
	private IEnumerator HDOBCBMEDJC()
	{
		TextureLoader.HBFOOIAFNIL hbfooiafnil = new TextureLoader.HBFOOIAFNIL(1);
		hbfooiafnil.AENJLLPLILM = this;
		return hbfooiafnil;
	}

	// Token: 0x06009A19 RID: 39449 RVA: 0x004451E7 File Offset: 0x004433E7
	private IEnumerator ALCFMPMMHGF()
	{
		this.texcontainer.PMJIHPFGCGJ = true;
		base.gameObject.name = "TextureLoader: " + this.texcontainer.ALBOCLBFNNI;
		www = new WWW(this.texcontainer.ALBOCLBFNNI);
		yield return www;
		this.texcontainer.PMJIHPFGCGJ = false;
		this.texcontainer.KEDGAOBCNJG = new Texture2D(4, 4, TextureFormat.ARGB32, false, false);
		if (www.isDone)
		{
			www.LoadImageIntoTexture(this.texcontainer.KEDGAOBCNJG);
			this.texcontainer.KEDGAOBCNJG.filterMode = this.texcontainer.OECLFHEEHEG;
			this.texcontainer.KEDGAOBCNJG.Apply();
			this.tex = this.texcontainer.KEDGAOBCNJG;
			this.texcontainer.OINDOLGBLOC = true;
			this.texcontainer.IALKJFLJBCP();
		}
		string error = www.error;
		www.Dispose();
		www = null;
		GC.Collect();
		UnityEngine.Object.Destroy(base.gameObject);
		yield break;
	}

	// Token: 0x06009A1A RID: 39450 RVA: 0x00445FB0 File Offset: 0x004441B0
	public void FCLIOHBDCFD(CKNLPGEPGGF.IAPCJOBDCEH JACEPAEHGPM)
	{
		this.texcontainer = JACEPAEHGPM;
		if (!File.Exists(this.texcontainer.ALBOCLBFNNI.Substring(2)))
		{
			this.texcontainer.OINDOLGBLOC = true;
			this.texcontainer.JNFNCLMDLKA();
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.StartCoroutine("OneHandSwordSwing");
	}

	// Token: 0x06009A1B RID: 39451 RVA: 0x0044541F File Offset: 0x0044361F
	private IEnumerator JGKAMJNJHLK()
	{
		TextureLoader.HBFOOIAFNIL hbfooiafnil = new TextureLoader.HBFOOIAFNIL(1);
		hbfooiafnil.AENJLLPLILM = this;
		return hbfooiafnil;
	}

	// Token: 0x06009A1C RID: 39452 RVA: 0x0044600C File Offset: 0x0044420C
	public void CAKMPLFHCHE(CKNLPGEPGGF.IAPCJOBDCEH JACEPAEHGPM)
	{
		this.texcontainer = JACEPAEHGPM;
		if (!File.Exists(this.texcontainer.ALBOCLBFNNI.Substring(6)))
		{
			this.texcontainer.OINDOLGBLOC = true;
			this.texcontainer.FBCJONKDLDC();
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		base.StartCoroutine("<[^>]+>");
	}

	// Token: 0x06009A1D RID: 39453 RVA: 0x0044541F File Offset: 0x0044361F
	private IEnumerator JKHAEJLKKNM()
	{
		TextureLoader.HBFOOIAFNIL hbfooiafnil = new TextureLoader.HBFOOIAFNIL(1);
		hbfooiafnil.AENJLLPLILM = this;
		return hbfooiafnil;
	}

	// Token: 0x06009A1E RID: 39454 RVA: 0x0044541F File Offset: 0x0044361F
	private IEnumerator ODLNDJEELBJ()
	{
		TextureLoader.HBFOOIAFNIL hbfooiafnil = new TextureLoader.HBFOOIAFNIL(1);
		hbfooiafnil.AENJLLPLILM = this;
		return hbfooiafnil;
	}

	// Token: 0x06009A1F RID: 39455 RVA: 0x004451E7 File Offset: 0x004433E7
	private IEnumerator KOLKAFNLICK()
	{
		this.texcontainer.PMJIHPFGCGJ = true;
		base.gameObject.name = "TextureLoader: " + this.texcontainer.ALBOCLBFNNI;
		www = new WWW(this.texcontainer.ALBOCLBFNNI);
		yield return www;
		this.texcontainer.PMJIHPFGCGJ = false;
		this.texcontainer.KEDGAOBCNJG = new Texture2D(4, 4, TextureFormat.ARGB32, false, false);
		if (www.isDone)
		{
			www.LoadImageIntoTexture(this.texcontainer.KEDGAOBCNJG);
			this.texcontainer.KEDGAOBCNJG.filterMode = this.texcontainer.OECLFHEEHEG;
			this.texcontainer.KEDGAOBCNJG.Apply();
			this.tex = this.texcontainer.KEDGAOBCNJG;
			this.texcontainer.OINDOLGBLOC = true;
			this.texcontainer.IALKJFLJBCP();
		}
		string error = www.error;
		www.Dispose();
		www = null;
		GC.Collect();
		UnityEngine.Object.Destroy(base.gameObject);
		yield break;
	}

	// Token: 0x06009A20 RID: 39456 RVA: 0x004451E7 File Offset: 0x004433E7
	private IEnumerator DNAADNMNFMP()
	{
		this.texcontainer.PMJIHPFGCGJ = true;
		base.gameObject.name = "TextureLoader: " + this.texcontainer.ALBOCLBFNNI;
		www = new WWW(this.texcontainer.ALBOCLBFNNI);
		yield return www;
		this.texcontainer.PMJIHPFGCGJ = false;
		this.texcontainer.KEDGAOBCNJG = new Texture2D(4, 4, TextureFormat.ARGB32, false, false);
		if (www.isDone)
		{
			www.LoadImageIntoTexture(this.texcontainer.KEDGAOBCNJG);
			this.texcontainer.KEDGAOBCNJG.filterMode = this.texcontainer.OECLFHEEHEG;
			this.texcontainer.KEDGAOBCNJG.Apply();
			this.tex = this.texcontainer.KEDGAOBCNJG;
			this.texcontainer.OINDOLGBLOC = true;
			this.texcontainer.IALKJFLJBCP();
		}
		string error = www.error;
		www.Dispose();
		www = null;
		GC.Collect();
		UnityEngine.Object.Destroy(base.gameObject);
		yield break;
	}

	// Token: 0x06009A21 RID: 39457 RVA: 0x0044541F File Offset: 0x0044361F
	private IEnumerator LGJLPLIDGHC()
	{
		TextureLoader.HBFOOIAFNIL hbfooiafnil = new TextureLoader.HBFOOIAFNIL(1);
		hbfooiafnil.AENJLLPLILM = this;
		return hbfooiafnil;
	}

	// Token: 0x0400141A RID: 5146
	public CKNLPGEPGGF.IAPCJOBDCEH texcontainer;

	// Token: 0x0400141B RID: 5147
	public Texture tex;

	// Token: 0x0400141C RID: 5148
	public bool is3D;
}
