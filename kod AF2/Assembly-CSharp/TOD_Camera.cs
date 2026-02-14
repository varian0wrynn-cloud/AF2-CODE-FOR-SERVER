using System;
using UnityEngine;

// Token: 0x020000BE RID: 190
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
[AddComponentMenu("Time of Day/Camera Main Script")]
public class TOD_Camera : MonoBehaviour
{
	// Token: 0x06002813 RID: 10259 RVA: 0x00119CAC File Offset: 0x00117EAC
	protected void KGGJHGNEHGM()
	{
		this.PHDAGKLKGLL = base.GetComponent<Camera>();
		this.FDIPPFFNOPI = base.GetComponent<Transform>();
		if (!this.sky)
		{
			this.sky = (UnityEngine.Object.FindObjectOfType(typeof(TOD_Sky)) as TOD_Sky);
		}
	}

	// Token: 0x06002814 RID: 10260 RVA: 0x00119CF8 File Offset: 0x00117EF8
	public void AOKHNGHFCHF()
	{
		if (!this.sky || !this.sky.FPAKOLIPIND)
		{
			return;
		}
		Vector3 position = this.FDIPPFFNOPI.position + this.FDIPPFFNOPI.rotation * this.DomePosOffset;
		this.sky.NINFILJKEFA.JDGNBEHCGAL.position = position;
	}

	// Token: 0x06002815 RID: 10261 RVA: 0x00119D5D File Offset: 0x00117F5D
	protected void KPHHOEJCMMO()
	{
		if (this.DomeScaleToFarClip)
		{
			this.HIAPPFJFLDJ();
		}
		if (this.DomePosToCamera)
		{
			this.DELCPAPKODA();
		}
	}

	// Token: 0x06002816 RID: 10262 RVA: 0x00119D7B File Offset: 0x00117F7B
	protected void OnPreCull()
	{
		if (this.DomeScaleToFarClip)
		{
			this.DoDomeScaleToFarClip();
		}
		if (this.DomePosToCamera)
		{
			this.DoDomePosToCamera();
		}
	}

	// Token: 0x06002817 RID: 10263 RVA: 0x00119D9C File Offset: 0x00117F9C
	public void BMEGGKPPNLM()
	{
		if (!this.sky || !this.sky.FPAKOLIPIND)
		{
			return;
		}
		float num = this.DomeScaleFactor * this.PHDAGKLKGLL.farClipPlane;
		Vector3 localScale = new Vector3(num, num, num);
		this.sky.KMBOELAHKHL().JDGNBEHCGAL.localScale = localScale;
	}

	// Token: 0x06002818 RID: 10264 RVA: 0x00119DF7 File Offset: 0x00117FF7
	internal bool HHCELGPODNH()
	{
		return !this.PHDAGKLKGLL || this.PHDAGKLKGLL.allowHDR;
	}

	// Token: 0x06002819 RID: 10265 RVA: 0x00119E14 File Offset: 0x00118014
	public void BODMHDBKNJB()
	{
		if (!this.sky || !this.sky.FPAKOLIPIND)
		{
			return;
		}
		float num = this.DomeScaleFactor * this.PHDAGKLKGLL.farClipPlane;
		Vector3 localScale = new Vector3(num, num, num);
		this.sky.NINFILJKEFA.JDGNBEHCGAL.localScale = localScale;
	}

	// Token: 0x0600281B RID: 10267 RVA: 0x00119E9C File Offset: 0x0011809C
	public void MLHGFKMOKJM()
	{
		if (!this.sky || !this.sky.FPAKOLIPIND)
		{
			return;
		}
		float num = this.DomeScaleFactor * this.PHDAGKLKGLL.farClipPlane;
		Vector3 localScale = new Vector3(num, num, num);
		this.sky.NINFILJKEFA.JDGNBEHCGAL.localScale = localScale;
	}

	// Token: 0x0600281C RID: 10268 RVA: 0x00119EF8 File Offset: 0x001180F8
	protected void OJJKNBMONMD()
	{
		this.PHDAGKLKGLL = base.GetComponent<Camera>();
		this.FDIPPFFNOPI = base.GetComponent<Transform>();
		if (!this.sky)
		{
			this.sky = (UnityEngine.Object.FindObjectOfType(typeof(TOD_Sky)) as TOD_Sky);
		}
	}

	// Token: 0x0600281D RID: 10269 RVA: 0x00119F44 File Offset: 0x00118144
	protected void IBOMADDAFAO()
	{
		this.PHDAGKLKGLL = base.GetComponent<Camera>();
		this.FDIPPFFNOPI = base.GetComponent<Transform>();
		if (!this.sky)
		{
			this.sky = (UnityEngine.Object.FindObjectOfType(typeof(TOD_Sky)) as TOD_Sky);
		}
	}

	// Token: 0x0600281E RID: 10270 RVA: 0x00119F90 File Offset: 0x00118190
	public void HIAPPFJFLDJ()
	{
		if (!this.sky || !this.sky.FPAKOLIPIND)
		{
			return;
		}
		float num = this.DomeScaleFactor * this.PHDAGKLKGLL.farClipPlane;
		Vector3 localScale = new Vector3(num, num, num);
		this.sky.KMBOELAHKHL().JDGNBEHCGAL.localScale = localScale;
	}

	// Token: 0x0600281F RID: 10271 RVA: 0x00119FEB File Offset: 0x001181EB
	protected void BMLPMLFEANM()
	{
		if (this.DomeScaleToFarClip)
		{
			this.BODMHDBKNJB();
		}
		if (this.DomePosToCamera)
		{
			this.DoDomePosToCamera();
		}
	}

	// Token: 0x06002820 RID: 10272 RVA: 0x0011A009 File Offset: 0x00118209
	protected void DEBICMDIFFF()
	{
		if (this.DomeScaleToFarClip)
		{
			this.HIAPPFJFLDJ();
		}
		if (this.DomePosToCamera)
		{
			this.AOKHNGHFCHF();
		}
	}

	// Token: 0x06002821 RID: 10273 RVA: 0x00119DF7 File Offset: 0x00117FF7
	internal bool IDAJBIGDGKA()
	{
		return !this.PHDAGKLKGLL || this.PHDAGKLKGLL.allowHDR;
	}

	// Token: 0x06002822 RID: 10274 RVA: 0x0011A028 File Offset: 0x00118228
	protected void JIOKDOGNKMI()
	{
		this.PHDAGKLKGLL = base.GetComponent<Camera>();
		this.FDIPPFFNOPI = base.GetComponent<Transform>();
		if (!this.sky)
		{
			this.sky = (UnityEngine.Object.FindObjectOfType(typeof(TOD_Sky)) as TOD_Sky);
		}
	}

	// Token: 0x1700008B RID: 139
	// (get) Token: 0x06002823 RID: 10275 RVA: 0x0011A074 File Offset: 0x00118274
	internal bool DHLBNFEMPJE
	{
		get
		{
			return this.PHDAGKLKGLL && this.PHDAGKLKGLL.allowHDR;
		}
	}

	// Token: 0x06002824 RID: 10276 RVA: 0x0011A090 File Offset: 0x00118290
	protected void Update()
	{
		this.sky.NINFILJKEFA.MHJDBKALKDF = this;
	}

	// Token: 0x06002825 RID: 10277 RVA: 0x0011A0A3 File Offset: 0x001182A3
	protected void OnValidate()
	{
		this.DomeScaleFactor = Mathf.Clamp(this.DomeScaleFactor, 0.01f, 1f);
	}

	// Token: 0x06002826 RID: 10278 RVA: 0x0011A0C0 File Offset: 0x001182C0
	public void DoDomePosToCamera()
	{
		if (!this.sky || !this.sky.FPAKOLIPIND)
		{
			return;
		}
		Vector3 position = this.FDIPPFFNOPI.position + this.FDIPPFFNOPI.rotation * this.DomePosOffset;
		this.sky.NINFILJKEFA.JDGNBEHCGAL.position = position;
	}

	// Token: 0x06002827 RID: 10279 RVA: 0x0011A125 File Offset: 0x00118325
	protected void GADEKIGKJJI()
	{
		this.DomeScaleFactor = Mathf.Clamp(this.DomeScaleFactor, 1441f, 305f);
	}

	// Token: 0x06002828 RID: 10280 RVA: 0x0011A142 File Offset: 0x00118342
	protected void IGCJBOFOEFM()
	{
		if (this.DomeScaleToFarClip)
		{
			this.BMEGGKPPNLM();
		}
		if (this.DomePosToCamera)
		{
			this.AOKHNGHFCHF();
		}
	}

	// Token: 0x06002829 RID: 10281 RVA: 0x0011A160 File Offset: 0x00118360
	public void JLFLADFBBMO()
	{
		if (!this.sky || !this.sky.FPAKOLIPIND)
		{
			return;
		}
		float num = this.DomeScaleFactor * this.PHDAGKLKGLL.farClipPlane;
		Vector3 localScale = new Vector3(num, num, num);
		this.sky.NINFILJKEFA.JDGNBEHCGAL.localScale = localScale;
	}

	// Token: 0x0600282A RID: 10282 RVA: 0x0011A1BC File Offset: 0x001183BC
	protected void CALDPCOLDNO()
	{
		this.PHDAGKLKGLL = base.GetComponent<Camera>();
		this.FDIPPFFNOPI = base.GetComponent<Transform>();
		if (!this.sky)
		{
			this.sky = (UnityEngine.Object.FindObjectOfType(typeof(TOD_Sky)) as TOD_Sky);
		}
	}

	// Token: 0x0600282B RID: 10283 RVA: 0x0011A208 File Offset: 0x00118408
	protected void DJKIPAPPKAJ()
	{
		if (this.DomeScaleToFarClip)
		{
			this.BMEGGKPPNLM();
		}
		if (this.DomePosToCamera)
		{
			this.FCAPHPMHGKA();
		}
	}

	// Token: 0x0600282C RID: 10284 RVA: 0x00119DF7 File Offset: 0x00117FF7
	internal bool PBACGFLPHBA()
	{
		return !this.PHDAGKLKGLL || this.PHDAGKLKGLL.allowHDR;
	}

	// Token: 0x0600282D RID: 10285 RVA: 0x0011A228 File Offset: 0x00118428
	public void DELCPAPKODA()
	{
		if (!this.sky || !this.sky.FPAKOLIPIND)
		{
			return;
		}
		Vector3 position = this.FDIPPFFNOPI.position + this.FDIPPFFNOPI.rotation * this.DomePosOffset;
		this.sky.KMBOELAHKHL().JDGNBEHCGAL.position = position;
	}

	// Token: 0x0600282E RID: 10286 RVA: 0x0011A290 File Offset: 0x00118490
	protected void JAFCKIKCHGM()
	{
		this.PHDAGKLKGLL = base.GetComponent<Camera>();
		this.FDIPPFFNOPI = base.GetComponent<Transform>();
		if (!this.sky)
		{
			this.sky = (UnityEngine.Object.FindObjectOfType(typeof(TOD_Sky)) as TOD_Sky);
		}
	}

	// Token: 0x0600282F RID: 10287 RVA: 0x0011A2DC File Offset: 0x001184DC
	public void FCAPHPMHGKA()
	{
		if (!this.sky || !this.sky.PNFINJHPEHJ())
		{
			return;
		}
		Vector3 position = this.FDIPPFFNOPI.position + this.FDIPPFFNOPI.rotation * this.DomePosOffset;
		this.sky.NINFILJKEFA.JDGNBEHCGAL.position = position;
	}

	// Token: 0x06002830 RID: 10288 RVA: 0x0011A341 File Offset: 0x00118541
	protected void IIKFLLIMFJF()
	{
		if (this.DomeScaleToFarClip)
		{
			this.DoDomeScaleToFarClip();
		}
		if (this.DomePosToCamera)
		{
			this.KIOPIFNENIO();
		}
	}

	// Token: 0x06002831 RID: 10289 RVA: 0x0011A35F File Offset: 0x0011855F
	protected void HDMDLPFMGNM()
	{
		if (this.DomeScaleToFarClip)
		{
			this.MLHGFKMOKJM();
		}
		if (this.DomePosToCamera)
		{
			this.DELCPAPKODA();
		}
	}

	// Token: 0x06002832 RID: 10290 RVA: 0x0011A380 File Offset: 0x00118580
	public void DoDomeScaleToFarClip()
	{
		if (!this.sky || !this.sky.FPAKOLIPIND)
		{
			return;
		}
		float num = this.DomeScaleFactor * this.PHDAGKLKGLL.farClipPlane;
		Vector3 localScale = new Vector3(num, num, num);
		this.sky.NINFILJKEFA.JDGNBEHCGAL.localScale = localScale;
	}

	// Token: 0x06002833 RID: 10291 RVA: 0x0011A3DC File Offset: 0x001185DC
	protected void NJCODNNAFEG()
	{
		this.PHDAGKLKGLL = base.GetComponent<Camera>();
		this.FDIPPFFNOPI = base.GetComponent<Transform>();
		if (!this.sky)
		{
			this.sky = (UnityEngine.Object.FindObjectOfType(typeof(TOD_Sky)) as TOD_Sky);
		}
	}

	// Token: 0x06002834 RID: 10292 RVA: 0x0011A428 File Offset: 0x00118628
	protected void EGFBHADIHGL()
	{
		this.DomeScaleFactor = Mathf.Clamp(this.DomeScaleFactor, 1693f, 312f);
	}

	// Token: 0x06002835 RID: 10293 RVA: 0x0011A090 File Offset: 0x00118290
	protected void OHKHOAKCENL()
	{
		this.sky.NINFILJKEFA.MHJDBKALKDF = this;
	}

	// Token: 0x06002836 RID: 10294 RVA: 0x0011A445 File Offset: 0x00118645
	protected void LFBDHBBLHLJ()
	{
		if (this.DomeScaleToFarClip)
		{
			this.BODMHDBKNJB();
		}
		if (this.DomePosToCamera)
		{
			this.FCAPHPMHGKA();
		}
	}

	// Token: 0x06002837 RID: 10295 RVA: 0x0011A464 File Offset: 0x00118664
	protected void OnEnable()
	{
		this.PHDAGKLKGLL = base.GetComponent<Camera>();
		this.FDIPPFFNOPI = base.GetComponent<Transform>();
		if (!this.sky)
		{
			this.sky = (UnityEngine.Object.FindObjectOfType(typeof(TOD_Sky)) as TOD_Sky);
		}
	}

	// Token: 0x06002838 RID: 10296 RVA: 0x0011A4B0 File Offset: 0x001186B0
	protected void LFOEELGABIN()
	{
		this.DomeScaleFactor = Mathf.Clamp(this.DomeScaleFactor, 1792f, 1169f);
	}

	// Token: 0x06002839 RID: 10297 RVA: 0x0011A090 File Offset: 0x00118290
	protected void FJEEADNCKAG()
	{
		this.sky.NINFILJKEFA.MHJDBKALKDF = this;
	}

	// Token: 0x0600283A RID: 10298 RVA: 0x0011A4D0 File Offset: 0x001186D0
	public void KIOPIFNENIO()
	{
		if (!this.sky || !this.sky.PNFINJHPEHJ())
		{
			return;
		}
		Vector3 position = this.FDIPPFFNOPI.position + this.FDIPPFFNOPI.rotation * this.DomePosOffset;
		this.sky.NINFILJKEFA.JDGNBEHCGAL.position = position;
	}

	// Token: 0x0400048A RID: 1162
	public TOD_Sky sky;

	// Token: 0x0400048B RID: 1163
	public bool DomePosToCamera = true;

	// Token: 0x0400048C RID: 1164
	public Vector3 DomePosOffset = Vector3.zero;

	// Token: 0x0400048D RID: 1165
	public bool DomeScaleToFarClip = true;

	// Token: 0x0400048E RID: 1166
	public float DomeScaleFactor = 0.95f;

	// Token: 0x0400048F RID: 1167
	private Camera PHDAGKLKGLL;

	// Token: 0x04000490 RID: 1168
	private Transform FDIPPFFNOPI;
}
