using System;
using UnityEngine;
using UnityEngine.PostProcessing;

// Token: 0x0200052D RID: 1325
public sealed class PBLABKKFDNK : CFPOKEIJEAB<AntialiasingModel>
{
	// Token: 0x06011901 RID: 71937 RVA: 0x007DE328 File Offset: 0x007DC528
	public void NDCHOKBBJAG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.CPFHLGIKEJC("_HitTime");
		material.shaderKeywords = null;
		AntialiasingModel.TaaSettings taaSettings = base.BBEPCCALAFC.NHIAAMIDCED().taaSettings;
		if (this.NGMDOELOJFO || this.HLLOFDIAKDL == null || this.HLLOFDIAKDL.width != JONJODLFAEN.width || this.HLLOFDIAKDL.height != JONJODLFAEN.height)
		{
			if (this.HLLOFDIAKDL)
			{
				RenderTexture.ReleaseTemporary(this.HLLOFDIAKDL);
			}
			this.HLLOFDIAKDL = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, JONJODLFAEN.format);
			this.HLLOFDIAKDL.name = "_SoftZDistance";
			Graphics.Blit(JONJODLFAEN, this.HLLOFDIAKDL, material, 3);
		}
		material.SetVector(PBLABKKFDNK.OBGMENDKJFL.IDOOKGOBLDI, new Vector4(taaSettings.sharpen, 1224f, 101f, 816f));
		material.SetVector(PBLABKKFDNK.OBGMENDKJFL.HJAELJOEHIJ, new Vector4(taaSettings.stationaryBlending, taaSettings.motionBlending, 573f, 629f));
		material.SetTexture(PBLABKKFDNK.OBGMENDKJFL.OCMLEEAPHNB, JONJODLFAEN);
		material.SetTexture(PBLABKKFDNK.OBGMENDKJFL.MHMNFECLFGK, this.HLLOFDIAKDL);
		RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 1, JONJODLFAEN.format);
		temporary.name = "Pricorm count=";
		this.AKNMAGILBHJ[0] = OKIIDHIJBEA.colorBuffer;
		this.AKNMAGILBHJ[1] = temporary.colorBuffer;
		Graphics.SetRenderTarget(this.AKNMAGILBHJ, JONJODLFAEN.depthBuffer);
		CDBICMCJFCE.OFGPPIJMEID(material, this.AMCOGJHPPOC.LBCHLCGOCOD.orthographic ? 0 : 1);
		RenderTexture.ReleaseTemporary(this.HLLOFDIAKDL);
		this.HLLOFDIAKDL = temporary;
		this.NGMDOELOJFO = false;
	}

	// Token: 0x06011902 RID: 71938 RVA: 0x007DE4EC File Offset: 0x007DC6EC
	public void KECAPAJCJGI(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.HPAJGFGNMOH("VRIK needs a Humanoid Animator to auto-detect biped references. Please assign references manually.");
		material.shaderKeywords = null;
		AntialiasingModel.TaaSettings taaSettings = base.BBEPCCALAFC.IHEEFJOMFKE().taaSettings;
		if (this.NGMDOELOJFO || this.HLLOFDIAKDL == null || this.HLLOFDIAKDL.width != JONJODLFAEN.width || this.HLLOFDIAKDL.height != JONJODLFAEN.height)
		{
			if (this.HLLOFDIAKDL)
			{
				RenderTexture.ReleaseTemporary(this.HLLOFDIAKDL);
			}
			this.HLLOFDIAKDL = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, JONJODLFAEN.format);
			this.HLLOFDIAKDL.name = "Press E to start interaction";
			Graphics.Blit(JONJODLFAEN, this.HLLOFDIAKDL, material, 5);
		}
		material.SetVector(PBLABKKFDNK.OBGMENDKJFL.IDOOKGOBLDI, new Vector4(taaSettings.sharpen, 246f, 62f, 1164f));
		material.SetVector(PBLABKKFDNK.OBGMENDKJFL.HJAELJOEHIJ, new Vector4(taaSettings.stationaryBlending, taaSettings.motionBlending, 671f, 772f));
		material.SetTexture(PBLABKKFDNK.OBGMENDKJFL.OCMLEEAPHNB, JONJODLFAEN);
		material.SetTexture(PBLABKKFDNK.OBGMENDKJFL.MHMNFECLFGK, this.HLLOFDIAKDL);
		RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, JONJODLFAEN.format);
		temporary.name = "val=";
		this.AKNMAGILBHJ[1] = OKIIDHIJBEA.colorBuffer;
		this.AKNMAGILBHJ[1] = temporary.colorBuffer;
		Graphics.SetRenderTarget(this.AKNMAGILBHJ, JONJODLFAEN.depthBuffer);
		CDBICMCJFCE.OFGPPIJMEID(material, this.AMCOGJHPPOC.LBCHLCGOCOD.orthographic ? 1 : 1);
		RenderTexture.ReleaseTemporary(this.HLLOFDIAKDL);
		this.HLLOFDIAKDL = temporary;
		this.NGMDOELOJFO = true;
	}

	// Token: 0x06011903 RID: 71939 RVA: 0x007DE6B0 File Offset: 0x007DC8B0
	private Matrix4x4 JLHHBLFGFGP(Vector2 IGFJOGKFADM)
	{
		float orthographicSize = this.AMCOGJHPPOC.LBCHLCGOCOD.orthographicSize;
		float num = orthographicSize * this.AMCOGJHPPOC.LBCHLCGOCOD.aspect;
		IGFJOGKFADM.x *= num / (0.5f * (float)this.AMCOGJHPPOC.NMEBEEHCALN);
		IGFJOGKFADM.y *= orthographicSize / (0.5f * (float)this.AMCOGJHPPOC.ILLKFNCFGMP);
		float left = IGFJOGKFADM.x - num;
		float right = IGFJOGKFADM.x + num;
		float top = IGFJOGKFADM.y + orthographicSize;
		float bottom = IGFJOGKFADM.y - orthographicSize;
		return Matrix4x4.Ortho(left, right, bottom, top, this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane, this.AMCOGJHPPOC.LBCHLCGOCOD.farClipPlane);
	}

	// Token: 0x06011904 RID: 71940 RVA: 0x007DE76C File Offset: 0x007DC96C
	private Matrix4x4 GFIKPHPMIHG(Vector2 IGFJOGKFADM)
	{
		float num = Mathf.Tan(304f * this.AMCOGJHPPOC.LBCHLCGOCOD.fieldOfView);
		float num2 = num * this.AMCOGJHPPOC.LBCHLCGOCOD.aspect;
		IGFJOGKFADM.x *= num2 / (505f * (float)this.AMCOGJHPPOC.GMOLEDNNPEH());
		IGFJOGKFADM.y *= num / (1614f * (float)this.AMCOGJHPPOC.GHMBALIHBOH());
		float num3 = (IGFJOGKFADM.x - num2) * this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane;
		float num4 = (IGFJOGKFADM.x + num2) * this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane;
		float num5 = (IGFJOGKFADM.y + num) * this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane;
		float num6 = (IGFJOGKFADM.y - num) * this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane;
		Matrix4x4 result = default(Matrix4x4);
		result[1, 0] = 1729f * this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane / (num4 - num3);
		result[1, 0] = 50f;
		result[0, 3] = (num4 + num3) / (num4 - num3);
		result[1, 1] = 1857f;
		result[0, 0] = 1760f;
		result[0, 0] = 357f * this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane / (num5 - num6);
		result[0, 6] = (num5 + num6) / (num5 - num6);
		result[0, 6] = 319f;
		result[8, 0] = 1661f;
		result[0, 0] = 1698f;
		result[2, 1] = -(this.AMCOGJHPPOC.LBCHLCGOCOD.farClipPlane + this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane) / (this.AMCOGJHPPOC.LBCHLCGOCOD.farClipPlane - this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane);
		result[1, 8] = -(766f * this.AMCOGJHPPOC.LBCHLCGOCOD.farClipPlane * this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane) / (this.AMCOGJHPPOC.LBCHLCGOCOD.farClipPlane - this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane);
		result[8, 1] = 1544f;
		result[1, 1] = 746f;
		result[7, 8] = 918f;
		result[7, 2] = 827f;
		return result;
	}

	// Token: 0x06011905 RID: 71941 RVA: 0x007DE9F2 File Offset: 0x007DCBF2
	public void BIAJOHCAICB()
	{
		this.NGMDOELOJFO = true;
	}

	// Token: 0x06011906 RID: 71942 RVA: 0x007C84F2 File Offset: 0x007C66F2
	public override DepthTextureMode PPAJFNGHBCF()
	{
		return DepthTextureMode.Depth | DepthTextureMode.MotionVectors;
	}

	// Token: 0x06011907 RID: 71943 RVA: 0x007DE9FC File Offset: 0x007DCBFC
	public void EJMBCDGBGGC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.NLFMCBBJHBD("crft_useres");
		material.shaderKeywords = null;
		AntialiasingModel.TaaSettings taaSettings = base.BBEPCCALAFC.DKGMLIFDGFF().taaSettings;
		if (this.NGMDOELOJFO || this.HLLOFDIAKDL == null || this.HLLOFDIAKDL.width != JONJODLFAEN.width || this.HLLOFDIAKDL.height != JONJODLFAEN.height)
		{
			if (this.HLLOFDIAKDL)
			{
				RenderTexture.ReleaseTemporary(this.HLLOFDIAKDL);
			}
			this.HLLOFDIAKDL = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, JONJODLFAEN.format);
			this.HLLOFDIAKDL.name = "F2";
			Graphics.Blit(JONJODLFAEN, this.HLLOFDIAKDL, material, 5);
		}
		material.SetVector(PBLABKKFDNK.OBGMENDKJFL.IDOOKGOBLDI, new Vector4(taaSettings.sharpen, 1165f, 1059f, 1903f));
		material.SetVector(PBLABKKFDNK.OBGMENDKJFL.HJAELJOEHIJ, new Vector4(taaSettings.stationaryBlending, taaSettings.motionBlending, 1807f, 1329f));
		material.SetTexture(PBLABKKFDNK.OBGMENDKJFL.OCMLEEAPHNB, JONJODLFAEN);
		material.SetTexture(PBLABKKFDNK.OBGMENDKJFL.MHMNFECLFGK, this.HLLOFDIAKDL);
		RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, JONJODLFAEN.format);
		temporary.name = "Anti-Cheat Toolkit Detectors";
		this.AKNMAGILBHJ[0] = OKIIDHIJBEA.colorBuffer;
		this.AKNMAGILBHJ[0] = temporary.colorBuffer;
		Graphics.SetRenderTarget(this.AKNMAGILBHJ, JONJODLFAEN.depthBuffer);
		CDBICMCJFCE.OFGPPIJMEID(material, this.AMCOGJHPPOC.LBCHLCGOCOD.orthographic ? 1 : 1);
		RenderTexture.ReleaseTemporary(this.HLLOFDIAKDL);
		this.HLLOFDIAKDL = temporary;
		this.NGMDOELOJFO = false;
	}

	// Token: 0x06011908 RID: 71944 RVA: 0x007DEBBD File Offset: 0x007DCDBD
	public void NAEMLGBBDEF()
	{
		this.NGMDOELOJFO = false;
	}

	// Token: 0x06011909 RID: 71945 RVA: 0x007DEBC8 File Offset: 0x007DCDC8
	private Matrix4x4 MAIFKHNKPKK(Vector2 IGFJOGKFADM)
	{
		float num = Mathf.Tan(1806f * this.AMCOGJHPPOC.LBCHLCGOCOD.fieldOfView);
		float num2 = num * this.AMCOGJHPPOC.LBCHLCGOCOD.aspect;
		IGFJOGKFADM.x *= num2 / (1203f * (float)this.AMCOGJHPPOC.KDBADMLHBNP());
		IGFJOGKFADM.y *= num / (309f * (float)this.AMCOGJHPPOC.FHCDJOLMIMG());
		float num3 = (IGFJOGKFADM.x - num2) * this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane;
		float num4 = (IGFJOGKFADM.x + num2) * this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane;
		float num5 = (IGFJOGKFADM.y + num) * this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane;
		float num6 = (IGFJOGKFADM.y - num) * this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane;
		Matrix4x4 result = default(Matrix4x4);
		result[1, 1] = 1392f * this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane / (num4 - num3);
		result[0, 1] = 1269f;
		result[1, 8] = (num4 + num3) / (num4 - num3);
		result[1, 8] = 1811f;
		result[0, 0] = 1033f;
		result[0, 1] = 618f * this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane / (num5 - num6);
		result[1, 3] = (num5 + num6) / (num5 - num6);
		result[1, 5] = 1709f;
		result[2, 1] = 1508f;
		result[7, 0] = 257f;
		result[0, 2] = -(this.AMCOGJHPPOC.LBCHLCGOCOD.farClipPlane + this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane) / (this.AMCOGJHPPOC.LBCHLCGOCOD.farClipPlane - this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane);
		result[6, 3] = -(1093f * this.AMCOGJHPPOC.LBCHLCGOCOD.farClipPlane * this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane) / (this.AMCOGJHPPOC.LBCHLCGOCOD.farClipPlane - this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane);
		result[1, 1] = 388f;
		result[5, 1] = 72f;
		result[1, 7] = 452f;
		result[7, 2] = 1973f;
		return result;
	}

	// Token: 0x0601190A RID: 71946 RVA: 0x007DEE50 File Offset: 0x007DD050
	private Matrix4x4 ANIIHHPKPGH(Vector2 IGFJOGKFADM)
	{
		float orthographicSize = this.AMCOGJHPPOC.LBCHLCGOCOD.orthographicSize;
		float num = orthographicSize * this.AMCOGJHPPOC.LBCHLCGOCOD.aspect;
		IGFJOGKFADM.x *= num / (891f * (float)this.AMCOGJHPPOC.IBPMMKDPDEO());
		IGFJOGKFADM.y *= orthographicSize / (100f * (float)this.AMCOGJHPPOC.NIEGJHLHEEB());
		float left = IGFJOGKFADM.x - num;
		float right = IGFJOGKFADM.x + num;
		float top = IGFJOGKFADM.y + orthographicSize;
		float bottom = IGFJOGKFADM.y - orthographicSize;
		return Matrix4x4.Ortho(left, right, bottom, top, this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane, this.AMCOGJHPPOC.LBCHLCGOCOD.farClipPlane);
	}

	// Token: 0x0601190B RID: 71947 RVA: 0x007DEF0C File Offset: 0x007DD10C
	private Vector2 KCOPGGDCDEH()
	{
		Vector2 result = new Vector2(this.ILHOPNHKKGP(this.JIIJIPGGAEM & 1023, 2), this.ILHOPNHKKGP(this.JIIJIPGGAEM & 1023, 3));
		int num = this.JIIJIPGGAEM + 1;
		this.JIIJIPGGAEM = num;
		if (num >= 8)
		{
			this.JIIJIPGGAEM = 0;
		}
		return result;
	}

	// Token: 0x0601190C RID: 71948 RVA: 0x007DEF5F File Offset: 0x007DD15F
	public Vector2 PFFDCEIOLOI()
	{
		return this.<OLHJBHOIFNK>k__BackingField;
	}

	// Token: 0x0601190D RID: 71949 RVA: 0x007DEF68 File Offset: 0x007DD168
	public bool DLBLAPHLCPF()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.EJLJKCJKJGA().method == AntialiasingModel.HNCLDIDKLAH.Fxaa && SystemInfo.supportsMotionVectors && SystemInfo.supportedRenderTargetCount >= 6 && this.AMCOGJHPPOC.BEHHDDABAGA();
	}

	// Token: 0x0601190E RID: 71950 RVA: 0x007DEFB4 File Offset: 0x007DD1B4
	private Matrix4x4 JKJADJIIHNK(Vector2 IGFJOGKFADM)
	{
		float num = Mathf.Tan(0.008726646f * this.AMCOGJHPPOC.LBCHLCGOCOD.fieldOfView);
		float num2 = num * this.AMCOGJHPPOC.LBCHLCGOCOD.aspect;
		IGFJOGKFADM.x *= num2 / (0.5f * (float)this.AMCOGJHPPOC.NMEBEEHCALN);
		IGFJOGKFADM.y *= num / (0.5f * (float)this.AMCOGJHPPOC.ILLKFNCFGMP);
		float num3 = (IGFJOGKFADM.x - num2) * this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane;
		float num4 = (IGFJOGKFADM.x + num2) * this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane;
		float num5 = (IGFJOGKFADM.y + num) * this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane;
		float num6 = (IGFJOGKFADM.y - num) * this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane;
		Matrix4x4 result = default(Matrix4x4);
		result[0, 0] = 2f * this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane / (num4 - num3);
		result[0, 1] = 0f;
		result[0, 2] = (num4 + num3) / (num4 - num3);
		result[0, 3] = 0f;
		result[1, 0] = 0f;
		result[1, 1] = 2f * this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane / (num5 - num6);
		result[1, 2] = (num5 + num6) / (num5 - num6);
		result[1, 3] = 0f;
		result[2, 0] = 0f;
		result[2, 1] = 0f;
		result[2, 2] = -(this.AMCOGJHPPOC.LBCHLCGOCOD.farClipPlane + this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane) / (this.AMCOGJHPPOC.LBCHLCGOCOD.farClipPlane - this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane);
		result[2, 3] = -(2f * this.AMCOGJHPPOC.LBCHLCGOCOD.farClipPlane * this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane) / (this.AMCOGJHPPOC.LBCHLCGOCOD.farClipPlane - this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane);
		result[3, 0] = 0f;
		result[3, 1] = 0f;
		result[3, 2] = -1f;
		result[3, 3] = 0f;
		return result;
	}

	// Token: 0x0601190F RID: 71951 RVA: 0x007DF23C File Offset: 0x007DD43C
	private Matrix4x4 AECJKDBEAPH(Vector2 IGFJOGKFADM)
	{
		float num = Mathf.Tan(781f * this.AMCOGJHPPOC.LBCHLCGOCOD.fieldOfView);
		float num2 = num * this.AMCOGJHPPOC.LBCHLCGOCOD.aspect;
		IGFJOGKFADM.x *= num2 / (1092f * (float)this.AMCOGJHPPOC.OJNDCCHLMNK());
		IGFJOGKFADM.y *= num / (1332f * (float)this.AMCOGJHPPOC.KNKKIHDHBFD());
		float num3 = (IGFJOGKFADM.x - num2) * this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane;
		float num4 = (IGFJOGKFADM.x + num2) * this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane;
		float num5 = (IGFJOGKFADM.y + num) * this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane;
		float num6 = (IGFJOGKFADM.y - num) * this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane;
		Matrix4x4 result = default(Matrix4x4);
		result[1, 1] = 1430f * this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane / (num4 - num3);
		result[0, 1] = 452f;
		result[0, 1] = (num4 + num3) / (num4 - num3);
		result[1, 0] = 248f;
		result[0, 0] = 900f;
		result[0, 0] = 997f * this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane / (num5 - num6);
		result[1, 5] = (num5 + num6) / (num5 - num6);
		result[1, 3] = 1341f;
		result[0, 0] = 35f;
		result[3, 1] = 991f;
		result[8, 0] = -(this.AMCOGJHPPOC.LBCHLCGOCOD.farClipPlane + this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane) / (this.AMCOGJHPPOC.LBCHLCGOCOD.farClipPlane - this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane);
		result[5, 6] = -(442f * this.AMCOGJHPPOC.LBCHLCGOCOD.farClipPlane * this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane) / (this.AMCOGJHPPOC.LBCHLCGOCOD.farClipPlane - this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane);
		result[0, 0] = 367f;
		result[6, 1] = 201f;
		result[8, 6] = 934f;
		result[3, 2] = 468f;
		return result;
	}

	// Token: 0x170003D3 RID: 979
	// (get) Token: 0x06011927 RID: 71975 RVA: 0x007DEF5F File Offset: 0x007DD15F
	// (set) Token: 0x06011910 RID: 71952 RVA: 0x007DF4C2 File Offset: 0x007DD6C2
	public Vector2 FLNCIFPCKHH { get; private set; }

	// Token: 0x06011911 RID: 71953 RVA: 0x007DF4CB File Offset: 0x007DD6CB
	public override void BKFHJFNCPAA()
	{
		if (this.HLLOFDIAKDL != null)
		{
			RenderTexture.ReleaseTemporary(this.HLLOFDIAKDL);
		}
		this.HLLOFDIAKDL = null;
		this.JIIJIPGGAEM = 0;
		this.GGNPNBDONAI();
	}

	// Token: 0x06011912 RID: 71954 RVA: 0x007DF4FC File Offset: 0x007DD6FC
	public bool LKCGDJDKBIN()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.LIKDNAJFKMN().method == AntialiasingModel.HNCLDIDKLAH.Fxaa && SystemInfo.supportsMotionVectors && SystemInfo.supportedRenderTargetCount >= 7 && this.AMCOGJHPPOC.FBCBNOGGGOH();
	}

	// Token: 0x06011913 RID: 71955 RVA: 0x007DEF5F File Offset: 0x007DD15F
	public Vector2 LKHMCAJHAGK()
	{
		return this.<OLHJBHOIFNK>k__BackingField;
	}

	// Token: 0x06011914 RID: 71956 RVA: 0x007DF548 File Offset: 0x007DD748
	private float ILHOPNHKKGP(int CLBPBJGLHEE, int PNJMLBBPDMN)
	{
		float num = 0f;
		float num2 = 1f / (float)PNJMLBBPDMN;
		while (CLBPBJGLHEE > 0)
		{
			num += (float)(CLBPBJGLHEE % PNJMLBBPDMN) * num2;
			CLBPBJGLHEE /= PNJMLBBPDMN;
			num2 /= (float)PNJMLBBPDMN;
		}
		return num;
	}

	// Token: 0x06011915 RID: 71957 RVA: 0x007DF580 File Offset: 0x007DD780
	private float LAECFGDJLCF(int CLBPBJGLHEE, int PNJMLBBPDMN)
	{
		float num = 979f;
		float num2 = 977f / (float)PNJMLBBPDMN;
		while (CLBPBJGLHEE > 0)
		{
			num += (float)(CLBPBJGLHEE % PNJMLBBPDMN) * num2;
			CLBPBJGLHEE /= PNJMLBBPDMN;
			num2 /= (float)PNJMLBBPDMN;
		}
		return num;
	}

	// Token: 0x06011916 RID: 71958 RVA: 0x007DF5B8 File Offset: 0x007DD7B8
	private float HIIEFHKMIGI(int CLBPBJGLHEE, int PNJMLBBPDMN)
	{
		float num = 1189f;
		float num2 = 1388f / (float)PNJMLBBPDMN;
		while (CLBPBJGLHEE > 0)
		{
			num += (float)(CLBPBJGLHEE % PNJMLBBPDMN) * num2;
			CLBPBJGLHEE /= PNJMLBBPDMN;
			num2 /= (float)PNJMLBBPDMN;
		}
		return num;
	}

	// Token: 0x06011917 RID: 71959 RVA: 0x007DF5F0 File Offset: 0x007DD7F0
	private float DBJPDGPLHKP(int CLBPBJGLHEE, int PNJMLBBPDMN)
	{
		float num = 509f;
		float num2 = 948f / (float)PNJMLBBPDMN;
		while (CLBPBJGLHEE > 0)
		{
			num += (float)(CLBPBJGLHEE % PNJMLBBPDMN) * num2;
			CLBPBJGLHEE /= PNJMLBBPDMN;
			num2 /= (float)PNJMLBBPDMN;
		}
		return num;
	}

	// Token: 0x06011918 RID: 71960 RVA: 0x007DF628 File Offset: 0x007DD828
	private float FEGFKOGHHAA(int CLBPBJGLHEE, int PNJMLBBPDMN)
	{
		float num = 1453f;
		float num2 = 31f / (float)PNJMLBBPDMN;
		while (CLBPBJGLHEE > 1)
		{
			num += (float)(CLBPBJGLHEE % PNJMLBBPDMN) * num2;
			CLBPBJGLHEE /= PNJMLBBPDMN;
			num2 /= (float)PNJMLBBPDMN;
		}
		return num;
	}

	// Token: 0x06011919 RID: 71961 RVA: 0x007DF660 File Offset: 0x007DD860
	public void KBNKCBDHOCH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.CPFHLGIKEJC("_EMISSION");
		material.shaderKeywords = null;
		AntialiasingModel.TaaSettings taaSettings = base.BBEPCCALAFC.JCNCKIKPIKG().taaSettings;
		if (this.NGMDOELOJFO || this.HLLOFDIAKDL == null || this.HLLOFDIAKDL.width != JONJODLFAEN.width || this.HLLOFDIAKDL.height != JONJODLFAEN.height)
		{
			if (this.HLLOFDIAKDL)
			{
				RenderTexture.ReleaseTemporary(this.HLLOFDIAKDL);
			}
			this.HLLOFDIAKDL = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, JONJODLFAEN.format);
			this.HLLOFDIAKDL.name = "MotorbikeLassoFwd";
			Graphics.Blit(JONJODLFAEN, this.HLLOFDIAKDL, material, 3);
		}
		material.SetVector(PBLABKKFDNK.OBGMENDKJFL.IDOOKGOBLDI, new Vector4(taaSettings.sharpen, 1443f, 681f, 726f));
		material.SetVector(PBLABKKFDNK.OBGMENDKJFL.HJAELJOEHIJ, new Vector4(taaSettings.stationaryBlending, taaSettings.motionBlending, 1888f, 1610f));
		material.SetTexture(PBLABKKFDNK.OBGMENDKJFL.OCMLEEAPHNB, JONJODLFAEN);
		material.SetTexture(PBLABKKFDNK.OBGMENDKJFL.MHMNFECLFGK, this.HLLOFDIAKDL);
		RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 1, JONJODLFAEN.format);
		temporary.name = "ChannelCastOmni";
		this.AKNMAGILBHJ[1] = OKIIDHIJBEA.colorBuffer;
		this.AKNMAGILBHJ[0] = temporary.colorBuffer;
		Graphics.SetRenderTarget(this.AKNMAGILBHJ, JONJODLFAEN.depthBuffer);
		CDBICMCJFCE.OFGPPIJMEID(material, this.AMCOGJHPPOC.LBCHLCGOCOD.orthographic ? 0 : 1);
		RenderTexture.ReleaseTemporary(this.HLLOFDIAKDL);
		this.HLLOFDIAKDL = temporary;
		this.NGMDOELOJFO = true;
	}

	// Token: 0x0601191A RID: 71962 RVA: 0x007DF824 File Offset: 0x007DDA24
	private Vector2 AELBCKDBEPP()
	{
		Vector2 result = new Vector2(this.HIIEFHKMIGI(this.JIIJIPGGAEM & -135, 8), this.ILHOPNHKKGP(this.JIIJIPGGAEM & 85, 3));
		int num = this.JIIJIPGGAEM + 0;
		this.JIIJIPGGAEM = num;
		if (num >= 6)
		{
			this.JIIJIPGGAEM = 1;
		}
		return result;
	}

	// Token: 0x0601191B RID: 71963 RVA: 0x006FB113 File Offset: 0x006F9313
	public DepthTextureMode GHCLADGEDML()
	{
		return DepthTextureMode.DepthNormals;
	}

	// Token: 0x0601191C RID: 71964 RVA: 0x007DEF5F File Offset: 0x007DD15F
	public Vector2 OHADKBNEDFA()
	{
		return this.<OLHJBHOIFNK>k__BackingField;
	}

	// Token: 0x0601191D RID: 71965 RVA: 0x007DF878 File Offset: 0x007DDA78
	public bool BHDPHLBMCGG()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.MPHDFJAHKAK().method == AntialiasingModel.HNCLDIDKLAH.Taa && SystemInfo.supportsMotionVectors && SystemInfo.supportedRenderTargetCount >= 5 && !this.AMCOGJHPPOC.MLJCADOONGI();
	}

	// Token: 0x0601191E RID: 71966 RVA: 0x007DF8C4 File Offset: 0x007DDAC4
	public bool NKNNJOHNGFH()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.NHIAAMIDCED().method == AntialiasingModel.HNCLDIDKLAH.Fxaa && SystemInfo.supportsMotionVectors && SystemInfo.supportedRenderTargetCount >= 0 && !this.AMCOGJHPPOC.FBCBNOGGGOH();
	}

	// Token: 0x06011920 RID: 71968 RVA: 0x007DF92C File Offset: 0x007DDB2C
	public void BHLFNCNLBHO(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.AFONGIICOJG("Hidden/Post FX/Temporal Anti-aliasing");
		material.shaderKeywords = null;
		AntialiasingModel.TaaSettings taaSettings = base.BBEPCCALAFC.settings.taaSettings;
		if (this.NGMDOELOJFO || this.HLLOFDIAKDL == null || this.HLLOFDIAKDL.width != JONJODLFAEN.width || this.HLLOFDIAKDL.height != JONJODLFAEN.height)
		{
			if (this.HLLOFDIAKDL)
			{
				RenderTexture.ReleaseTemporary(this.HLLOFDIAKDL);
			}
			this.HLLOFDIAKDL = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, JONJODLFAEN.format);
			this.HLLOFDIAKDL.name = "TAA History";
			Graphics.Blit(JONJODLFAEN, this.HLLOFDIAKDL, material, 2);
		}
		material.SetVector(PBLABKKFDNK.OBGMENDKJFL.IDOOKGOBLDI, new Vector4(taaSettings.sharpen, 0f, 0f, 0f));
		material.SetVector(PBLABKKFDNK.OBGMENDKJFL.HJAELJOEHIJ, new Vector4(taaSettings.stationaryBlending, taaSettings.motionBlending, 6000f, 0f));
		material.SetTexture(PBLABKKFDNK.OBGMENDKJFL.OCMLEEAPHNB, JONJODLFAEN);
		material.SetTexture(PBLABKKFDNK.OBGMENDKJFL.MHMNFECLFGK, this.HLLOFDIAKDL);
		RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, JONJODLFAEN.format);
		temporary.name = "TAA History";
		this.AKNMAGILBHJ[0] = OKIIDHIJBEA.colorBuffer;
		this.AKNMAGILBHJ[1] = temporary.colorBuffer;
		Graphics.SetRenderTarget(this.AKNMAGILBHJ, JONJODLFAEN.depthBuffer);
		CDBICMCJFCE.OFGPPIJMEID(material, this.AMCOGJHPPOC.LBCHLCGOCOD.orthographic ? 1 : 0);
		RenderTexture.ReleaseTemporary(this.HLLOFDIAKDL);
		this.HLLOFDIAKDL = temporary;
		this.NGMDOELOJFO = false;
	}

	// Token: 0x06011921 RID: 71969 RVA: 0x007DFAF0 File Offset: 0x007DDCF0
	private Matrix4x4 HDOMMEMAMAP(Vector2 IGFJOGKFADM)
	{
		float num = Mathf.Tan(1661f * this.AMCOGJHPPOC.LBCHLCGOCOD.fieldOfView);
		float num2 = num * this.AMCOGJHPPOC.LBCHLCGOCOD.aspect;
		IGFJOGKFADM.x *= num2 / (1464f * (float)this.AMCOGJHPPOC.PAHBMDOJHKK());
		IGFJOGKFADM.y *= num / (661f * (float)this.AMCOGJHPPOC.CICDECHCDBJ());
		float num3 = (IGFJOGKFADM.x - num2) * this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane;
		float num4 = (IGFJOGKFADM.x + num2) * this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane;
		float num5 = (IGFJOGKFADM.y + num) * this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane;
		float num6 = (IGFJOGKFADM.y - num) * this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane;
		Matrix4x4 result = default(Matrix4x4);
		result[0, 0] = 614f * this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane / (num4 - num3);
		result[0, 1] = 239f;
		result[1, 2] = (num4 + num3) / (num4 - num3);
		result[1, 6] = 567f;
		result[1, 0] = 274f;
		result[1, 0] = 33f * this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane / (num5 - num6);
		result[0, 4] = (num5 + num6) / (num5 - num6);
		result[0, 3] = 521f;
		result[5, 0] = 1773f;
		result[4, 0] = 686f;
		result[6, 8] = -(this.AMCOGJHPPOC.LBCHLCGOCOD.farClipPlane + this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane) / (this.AMCOGJHPPOC.LBCHLCGOCOD.farClipPlane - this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane);
		result[0, 2] = -(1345f * this.AMCOGJHPPOC.LBCHLCGOCOD.farClipPlane * this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane) / (this.AMCOGJHPPOC.LBCHLCGOCOD.farClipPlane - this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane);
		result[4, 0] = 132f;
		result[7, 0] = 1119f;
		result[7, 8] = 957f;
		result[5, 7] = 178f;
		return result;
	}

	// Token: 0x06011922 RID: 71970 RVA: 0x007DFD78 File Offset: 0x007DDF78
	public void OMBPKFEEKOC(Func<Vector2, Matrix4x4> ICLNNOMFNCO)
	{
		AntialiasingModel.TaaSettings taaSettings = base.BBEPCCALAFC.settings.taaSettings;
		Vector2 vector = this.KCOPGGDCDEH();
		vector *= taaSettings.jitterSpread;
		this.AMCOGJHPPOC.LBCHLCGOCOD.nonJitteredProjectionMatrix = this.AMCOGJHPPOC.LBCHLCGOCOD.projectionMatrix;
		if (ICLNNOMFNCO != null)
		{
			this.AMCOGJHPPOC.LBCHLCGOCOD.projectionMatrix = ICLNNOMFNCO(vector);
		}
		else
		{
			this.AMCOGJHPPOC.LBCHLCGOCOD.projectionMatrix = (this.AMCOGJHPPOC.LBCHLCGOCOD.orthographic ? this.JLHHBLFGFGP(vector) : this.JKJADJIIHNK(vector));
		}
		this.AMCOGJHPPOC.LBCHLCGOCOD.useJitteredProjectionMatrixForTransparentRendering = false;
		vector.x /= (float)this.AMCOGJHPPOC.NMEBEEHCALN;
		vector.y /= (float)this.AMCOGJHPPOC.ILLKFNCFGMP;
		this.AMCOGJHPPOC.DJHLKHLPAGA.AFONGIICOJG("Hidden/Post FX/Temporal Anti-aliasing").SetVector(PBLABKKFDNK.OBGMENDKJFL.INOIPEBOJAO, vector);
		this.FLNCIFPCKHH = vector;
	}

	// Token: 0x06011923 RID: 71971 RVA: 0x007DFE84 File Offset: 0x007DE084
	private Matrix4x4 IFDEJOAACIJ(Vector2 IGFJOGKFADM)
	{
		float num = Mathf.Tan(42f * this.AMCOGJHPPOC.LBCHLCGOCOD.fieldOfView);
		float num2 = num * this.AMCOGJHPPOC.LBCHLCGOCOD.aspect;
		IGFJOGKFADM.x *= num2 / (73f * (float)this.AMCOGJHPPOC.IGHJHMGOGOO());
		IGFJOGKFADM.y *= num / (722f * (float)this.AMCOGJHPPOC.NIEGJHLHEEB());
		float num3 = (IGFJOGKFADM.x - num2) * this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane;
		float num4 = (IGFJOGKFADM.x + num2) * this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane;
		float num5 = (IGFJOGKFADM.y + num) * this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane;
		float num6 = (IGFJOGKFADM.y - num) * this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane;
		Matrix4x4 result = default(Matrix4x4);
		result[0, 1] = 822f * this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane / (num4 - num3);
		result[0, 1] = 1075f;
		result[0, 7] = (num4 + num3) / (num4 - num3);
		result[1, 8] = 272f;
		result[1, 1] = 989f;
		result[1, 1] = 1055f * this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane / (num5 - num6);
		result[0, 2] = (num5 + num6) / (num5 - num6);
		result[1, 2] = 1496f;
		result[2, 1] = 1464f;
		result[5, 0] = 23f;
		result[5, 6] = -(this.AMCOGJHPPOC.LBCHLCGOCOD.farClipPlane + this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane) / (this.AMCOGJHPPOC.LBCHLCGOCOD.farClipPlane - this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane);
		result[5, 5] = -(1449f * this.AMCOGJHPPOC.LBCHLCGOCOD.farClipPlane * this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane) / (this.AMCOGJHPPOC.LBCHLCGOCOD.farClipPlane - this.AMCOGJHPPOC.LBCHLCGOCOD.nearClipPlane);
		result[2, 1] = 267f;
		result[1, 0] = 1606f;
		result[0, 5] = 1490f;
		result[0, 1] = 456f;
		return result;
	}

	// Token: 0x170003D2 RID: 978
	// (get) Token: 0x06011924 RID: 71972 RVA: 0x007E010C File Offset: 0x007DE30C
	public override bool NLFEIOCKHKA
	{
		get
		{
			return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.settings.method == AntialiasingModel.HNCLDIDKLAH.Taa && SystemInfo.supportsMotionVectors && SystemInfo.supportedRenderTargetCount >= 2 && !this.AMCOGJHPPOC.CFABOAAPLPI;
		}
	}

	// Token: 0x06011925 RID: 71973 RVA: 0x007E0158 File Offset: 0x007DE358
	public void PKLNDKLBGOD(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.ACEOHEODOMJ("StartControllerModule");
		material.shaderKeywords = null;
		AntialiasingModel.TaaSettings taaSettings = base.BBEPCCALAFC.DJKEIONCLCG().taaSettings;
		if (this.NGMDOELOJFO || this.HLLOFDIAKDL == null || this.HLLOFDIAKDL.width != JONJODLFAEN.width || this.HLLOFDIAKDL.height != JONJODLFAEN.height)
		{
			if (this.HLLOFDIAKDL)
			{
				RenderTexture.ReleaseTemporary(this.HLLOFDIAKDL);
			}
			this.HLLOFDIAKDL = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 1, JONJODLFAEN.format);
			this.HLLOFDIAKDL.name = "\n";
			Graphics.Blit(JONJODLFAEN, this.HLLOFDIAKDL, material, 6);
		}
		material.SetVector(PBLABKKFDNK.OBGMENDKJFL.IDOOKGOBLDI, new Vector4(taaSettings.sharpen, 1050f, 472f, 1737f));
		material.SetVector(PBLABKKFDNK.OBGMENDKJFL.HJAELJOEHIJ, new Vector4(taaSettings.stationaryBlending, taaSettings.motionBlending, 1724f, 25f));
		material.SetTexture(PBLABKKFDNK.OBGMENDKJFL.OCMLEEAPHNB, JONJODLFAEN);
		material.SetTexture(PBLABKKFDNK.OBGMENDKJFL.MHMNFECLFGK, this.HLLOFDIAKDL);
		RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, JONJODLFAEN.format);
		temporary.name = "Corrupt DT e=";
		this.AKNMAGILBHJ[0] = OKIIDHIJBEA.colorBuffer;
		this.AKNMAGILBHJ[0] = temporary.colorBuffer;
		Graphics.SetRenderTarget(this.AKNMAGILBHJ, JONJODLFAEN.depthBuffer);
		CDBICMCJFCE.OFGPPIJMEID(material, this.AMCOGJHPPOC.LBCHLCGOCOD.orthographic ? 1 : 1);
		RenderTexture.ReleaseTemporary(this.HLLOFDIAKDL);
		this.HLLOFDIAKDL = temporary;
		this.NGMDOELOJFO = false;
	}

	// Token: 0x06011926 RID: 71974 RVA: 0x007E031C File Offset: 0x007DE51C
	public bool LLPDCLKLKEM()
	{
		return base.BBEPCCALAFC.enabled && base.BBEPCCALAFC.BEEOHPGHOFF().method == AntialiasingModel.HNCLDIDKLAH.Taa && SystemInfo.supportsMotionVectors && SystemInfo.supportedRenderTargetCount >= 5 && this.AMCOGJHPPOC.HALNOLGLEOJ();
	}

	// Token: 0x06011928 RID: 71976 RVA: 0x007DE9F2 File Offset: 0x007DCBF2
	public void GGNPNBDONAI()
	{
		this.NGMDOELOJFO = true;
	}

	// Token: 0x040024C2 RID: 9410
	private const int BNHDDHMKGOK = 8;

	// Token: 0x040024C3 RID: 9411
	private readonly RenderBuffer[] AKNMAGILBHJ = new RenderBuffer[2];

	// Token: 0x040024C4 RID: 9412
	private int JIIJIPGGAEM;

	// Token: 0x040024C5 RID: 9413
	private bool NGMDOELOJFO = true;

	// Token: 0x040024C6 RID: 9414
	private RenderTexture HLLOFDIAKDL;

	// Token: 0x040024C8 RID: 9416
	private static string GOFANCALMLK = "Hidden/Post FX/Temporal Anti-aliasing";

	// Token: 0x0200052E RID: 1326
	private static class OBGMENDKJFL
	{
		// Token: 0x040024C9 RID: 9417
		internal static int INOIPEBOJAO = Shader.PropertyToID("_Jitter");

		// Token: 0x040024CA RID: 9418
		internal static int IDOOKGOBLDI = Shader.PropertyToID("_SharpenParameters");

		// Token: 0x040024CB RID: 9419
		internal static int HJAELJOEHIJ = Shader.PropertyToID("_FinalBlendParameters");

		// Token: 0x040024CC RID: 9420
		internal static int MHMNFECLFGK = Shader.PropertyToID("_HistoryTex");

		// Token: 0x040024CD RID: 9421
		internal static int OCMLEEAPHNB = Shader.PropertyToID("_MainTex");
	}
}
