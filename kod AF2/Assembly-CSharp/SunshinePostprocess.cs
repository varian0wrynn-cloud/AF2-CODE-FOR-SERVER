using System;
using UnityEngine;

// Token: 0x0200009B RID: 155
[ExecuteInEditMode]
public class SunshinePostprocess : MonoBehaviour
{
	// Token: 0x06002100 RID: 8448 RVA: 0x000F67C2 File Offset: 0x000F49C2
	private void OJJKNBMONMD()
	{
		this.GPNFCFOEKMP = base.GetComponent<SunshineCamera>();
	}

	// Token: 0x06002101 RID: 8449 RVA: 0x000F67D0 File Offset: 0x000F49D0
	public static void Blit(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA, Material MHNAJNGGDFJ, int INEBKEDAPPN)
	{
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, INEBKEDAPPN);
	}

	// Token: 0x06002102 RID: 8450 RVA: 0x000F67D0 File Offset: 0x000F49D0
	public static void GAOOMGPDHJI(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA, Material MHNAJNGGDFJ, int INEBKEDAPPN)
	{
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, INEBKEDAPPN);
	}

	// Token: 0x06002103 RID: 8451 RVA: 0x000F67C2 File Offset: 0x000F49C2
	private void KOAEBJLNOLI()
	{
		this.GPNFCFOEKMP = base.GetComponent<SunshineCamera>();
	}

	// Token: 0x06002104 RID: 8452 RVA: 0x000F67C2 File Offset: 0x000F49C2
	private void KOLNOOGFFNP()
	{
		this.GPNFCFOEKMP = base.GetComponent<SunshineCamera>();
	}

	// Token: 0x06002105 RID: 8453 RVA: 0x000F67D0 File Offset: 0x000F49D0
	public static void ENLBGOAJLNH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA, Material MHNAJNGGDFJ, int INEBKEDAPPN)
	{
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, INEBKEDAPPN);
	}

	// Token: 0x06002106 RID: 8454 RVA: 0x000F67DC File Offset: 0x000F49DC
	private void NPAOBLFOMGI(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (this.GPNFCFOEKMP == null)
		{
			this.GPNFCFOEKMP = base.GetComponent<SunshineCamera>();
		}
		if (this.GPNFCFOEKMP != null && this.GPNFCFOEKMP.enabled)
		{
			this.GPNFCFOEKMP.AFFOJJDDEOB(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
		base.enabled = false;
	}

	// Token: 0x06002107 RID: 8455 RVA: 0x000F67C2 File Offset: 0x000F49C2
	private void OnEnable()
	{
		this.GPNFCFOEKMP = base.GetComponent<SunshineCamera>();
	}

	// Token: 0x06002108 RID: 8456 RVA: 0x000F67D0 File Offset: 0x000F49D0
	public static void PIGDHOBCJBJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA, Material MHNAJNGGDFJ, int INEBKEDAPPN)
	{
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, INEBKEDAPPN);
	}

	// Token: 0x06002109 RID: 8457 RVA: 0x000F683C File Offset: 0x000F4A3C
	private void OnRenderImage(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (this.GPNFCFOEKMP == null)
		{
			this.GPNFCFOEKMP = base.GetComponent<SunshineCamera>();
		}
		if (this.GPNFCFOEKMP != null && this.GPNFCFOEKMP.enabled)
		{
			this.GPNFCFOEKMP.OnPostProcess(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
		base.enabled = false;
	}

	// Token: 0x0600210A RID: 8458 RVA: 0x000F67D0 File Offset: 0x000F49D0
	public static void NLEBCJALNAF(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA, Material MHNAJNGGDFJ, int INEBKEDAPPN)
	{
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, INEBKEDAPPN);
	}

	// Token: 0x0600210B RID: 8459 RVA: 0x000F67D0 File Offset: 0x000F49D0
	public static void OGAPNKKPFOB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA, Material MHNAJNGGDFJ, int INEBKEDAPPN)
	{
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, INEBKEDAPPN);
	}

	// Token: 0x0600210C RID: 8460 RVA: 0x000F67D0 File Offset: 0x000F49D0
	public static void AJIGAFKEEHB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA, Material MHNAJNGGDFJ, int INEBKEDAPPN)
	{
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, INEBKEDAPPN);
	}

	// Token: 0x0600210D RID: 8461 RVA: 0x000F689C File Offset: 0x000F4A9C
	private void EDCBFNNHICN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (this.GPNFCFOEKMP == null)
		{
			this.GPNFCFOEKMP = base.GetComponent<SunshineCamera>();
		}
		if (this.GPNFCFOEKMP != null && this.GPNFCFOEKMP.enabled)
		{
			this.GPNFCFOEKMP.ELHIFBKMGEG(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
		base.enabled = false;
	}

	// Token: 0x0600210E RID: 8462 RVA: 0x000F67D0 File Offset: 0x000F49D0
	public static void JIPLNFFBLIM(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA, Material MHNAJNGGDFJ, int INEBKEDAPPN)
	{
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, INEBKEDAPPN);
	}

	// Token: 0x0600210F RID: 8463 RVA: 0x000F68FC File Offset: 0x000F4AFC
	private void ALNHCIOIBPP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (this.GPNFCFOEKMP == null)
		{
			this.GPNFCFOEKMP = base.GetComponent<SunshineCamera>();
		}
		if (this.GPNFCFOEKMP != null && this.GPNFCFOEKMP.enabled)
		{
			this.GPNFCFOEKMP.CCFFELLGGPA(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
		base.enabled = true;
	}

	// Token: 0x06002110 RID: 8464 RVA: 0x000F695C File Offset: 0x000F4B5C
	private void EOMGNPFHPBD(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (this.GPNFCFOEKMP == null)
		{
			this.GPNFCFOEKMP = base.GetComponent<SunshineCamera>();
		}
		if (this.GPNFCFOEKMP != null && this.GPNFCFOEKMP.enabled)
		{
			this.GPNFCFOEKMP.OnPostProcess(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
		base.enabled = true;
	}

	// Token: 0x06002111 RID: 8465 RVA: 0x000F67D0 File Offset: 0x000F49D0
	public static void ICDCCJNKAMO(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA, Material MHNAJNGGDFJ, int INEBKEDAPPN)
	{
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, INEBKEDAPPN);
	}

	// Token: 0x06002112 RID: 8466 RVA: 0x000F67D0 File Offset: 0x000F49D0
	public static void OHCEOEJGOII(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA, Material MHNAJNGGDFJ, int INEBKEDAPPN)
	{
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, INEBKEDAPPN);
	}

	// Token: 0x06002113 RID: 8467 RVA: 0x000F67C2 File Offset: 0x000F49C2
	private void JAFCKIKCHGM()
	{
		this.GPNFCFOEKMP = base.GetComponent<SunshineCamera>();
	}

	// Token: 0x06002114 RID: 8468 RVA: 0x000F67C2 File Offset: 0x000F49C2
	private void DCPLMIMFNHG()
	{
		this.GPNFCFOEKMP = base.GetComponent<SunshineCamera>();
	}

	// Token: 0x06002115 RID: 8469 RVA: 0x000F67D0 File Offset: 0x000F49D0
	public static void CGDKCJCPMLP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA, Material MHNAJNGGDFJ, int INEBKEDAPPN)
	{
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, INEBKEDAPPN);
	}

	// Token: 0x06002116 RID: 8470 RVA: 0x000F67D0 File Offset: 0x000F49D0
	public static void KKMMEIEIDJD(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA, Material MHNAJNGGDFJ, int INEBKEDAPPN)
	{
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, INEBKEDAPPN);
	}

	// Token: 0x06002117 RID: 8471 RVA: 0x000F67C2 File Offset: 0x000F49C2
	private void MLPAEBKPFEN()
	{
		this.GPNFCFOEKMP = base.GetComponent<SunshineCamera>();
	}

	// Token: 0x06002118 RID: 8472 RVA: 0x000F69BC File Offset: 0x000F4BBC
	private void JHHHJFOOFII(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (this.GPNFCFOEKMP == null)
		{
			this.GPNFCFOEKMP = base.GetComponent<SunshineCamera>();
		}
		if (this.GPNFCFOEKMP != null && this.GPNFCFOEKMP.enabled)
		{
			this.GPNFCFOEKMP.ELHIFBKMGEG(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
		base.enabled = false;
	}

	// Token: 0x06002119 RID: 8473 RVA: 0x000F6A1C File Offset: 0x000F4C1C
	private void EFEHHALJILL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (this.GPNFCFOEKMP == null)
		{
			this.GPNFCFOEKMP = base.GetComponent<SunshineCamera>();
		}
		if (this.GPNFCFOEKMP != null && this.GPNFCFOEKMP.enabled)
		{
			this.GPNFCFOEKMP.PJKJFHCHAHC(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
		base.enabled = true;
	}

	// Token: 0x0600211B RID: 8475 RVA: 0x000F67D0 File Offset: 0x000F49D0
	public static void PELMNIFPDKC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA, Material MHNAJNGGDFJ, int INEBKEDAPPN)
	{
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, MHNAJNGGDFJ, INEBKEDAPPN);
	}

	// Token: 0x0600211C RID: 8476 RVA: 0x000F67C2 File Offset: 0x000F49C2
	private void LCJGCMFMMFG()
	{
		this.GPNFCFOEKMP = base.GetComponent<SunshineCamera>();
	}

	// Token: 0x040003EA RID: 1002
	private SunshineCamera GPNFCFOEKMP;
}
