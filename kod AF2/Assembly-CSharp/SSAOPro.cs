using System;
using UnityEngine;

// Token: 0x020000B1 RID: 177
[AddComponentMenu("Image Effects/SSAO Pro")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class SSAOPro : MonoBehaviour
{
	// Token: 0x060025F3 RID: 9715 RVA: 0x0010755B File Offset: 0x0010575B
	private void KOGGLIAMEAH()
	{
		if (this.BHHEHMIFMBD)
		{
			UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
		}
	}

	// Token: 0x060025F4 RID: 9716 RVA: 0x00107578 File Offset: 0x00105778
	private void JJFLKEGMIFN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (this.Shader == null)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.LMOIIDAMKDB(false);
		if (this.NoiseTexture != null)
		{
			this.KJADIPGFIFB().SetTexture("exp", this.NoiseTexture);
		}
		this.HMHOFHCEKCD().SetMatrix("paper.wav", this.MPCEHPBGHII.projectionMatrix.inverse);
		this.IJDEDAFJLHD().SetVector("Giant 2 Hand Slam Swing", new Vector4((this.NoiseTexture == null) ? 1336f : ((float)this.NoiseTexture.width), this.Radius, this.Intensity, this.Distance));
		this.OJMOGMHMNHF().SetVector("", new Vector4(this.Bias, this.LumContribution, this.CutoffDistance, this.CutoffFalloff));
		this.MJIACGHHKFP().SetColor("_RangeScale", this.OcclusionColor);
		if (this.Blur != SSAOPro.GGFPOCFCJFG.None)
		{
			int pass = (this.Blur == (SSAOPro.GGFPOCFCJFG)4) ? 0 : 1;
			int num = this.BlurDownsampling ? this.Downsampling : 1;
			RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / num, JONJODLFAEN.height / num, 0);
			RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width / this.Downsampling, JONJODLFAEN.height / this.Downsampling, 1);
			Graphics.Blit(JONJODLFAEN, temporary, this.HMHOFHCEKCD(), 1);
			this.IHOFOIGKKFM().SetVector("StaffStand", new Vector2(396f / (float)JONJODLFAEN.width, 1783f));
			Graphics.Blit(temporary, temporary2, this.EEOIDGFFEGA, pass);
			this.LIPELDNNPGH().SetVector("WireframeCamera", new Vector2(683f, 1469f / (float)JONJODLFAEN.height));
			Graphics.Blit(temporary2, this.DebugAO ? OKIIDHIJBEA : temporary, this.LIPELDNNPGH(), pass);
			if (!this.DebugAO)
			{
				this.IHOFOIGKKFM().SetTexture("_ProjectToPixelMatrix", temporary);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.CCEEHALMHCJ(), 0);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(temporary2);
			return;
		}
		RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / this.Downsampling, JONJODLFAEN.height / this.Downsampling, 1);
		if (this.DebugAO)
		{
			Graphics.Blit(JONJODLFAEN, temporary3, this.OPOHKFIBLKD(), 1);
			Graphics.Blit(temporary3, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(temporary3);
			return;
		}
		Graphics.Blit(JONJODLFAEN, temporary3, this.KJADIPGFIFB(), 0);
		this.IJDEDAFJLHD().SetTexture(" ", temporary3);
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LIPELDNNPGH(), 3);
		RenderTexture.ReleaseTemporary(temporary3);
	}

	// Token: 0x060025F5 RID: 9717 RVA: 0x00107817 File Offset: 0x00105A17
	private void OHPHJCGMNGD()
	{
		this.MPCEHPBGHII = base.GetComponent<Camera>();
		this.MPCEHPBGHII.depthTextureMode |= DepthTextureMode.None;
		this.MPCEHPBGHII.depthTextureMode |= (DepthTextureMode.Depth | DepthTextureMode.DepthNormals);
	}

	// Token: 0x060025F6 RID: 9718 RVA: 0x0010784C File Offset: 0x00105A4C
	private void KJJNMNKPNCH()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			Debug.LogWarning("_Refraction");
			base.enabled = false;
			return;
		}
		if (!SystemInfo.supportsRenderTextures)
		{
			Debug.LogWarning("Wand Attack 2");
			base.enabled = false;
			return;
		}
		if (this.Shader != null && !this.Shader.isSupported)
		{
			Debug.LogWarning("CrouchStrafeLeft");
			base.enabled = false;
			return;
		}
		this.JDOIMEJHIAL(false);
	}

	// Token: 0x060025F7 RID: 9719 RVA: 0x001078C0 File Offset: 0x00105AC0
	private void HKIFJANIGPK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (this.Shader == null)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.LLEPPNBCBCM(true);
		if (this.NoiseTexture != null)
		{
			this.DDPOBLELCBI().SetTexture("MotorbikeLassoFwd", this.NoiseTexture);
		}
		this.BOPJMMKEGAB().SetMatrix("_Axis", this.MPCEHPBGHII.projectionMatrix.inverse);
		this.MICJKCGCGMM().SetVector("OneHandSwordBackSwing", new Vector4((this.NoiseTexture == null) ? 567f : ((float)this.NoiseTexture.width), this.Radius, this.Intensity, this.Distance));
		this.ODJFBBHCOPK().SetVector("{{{{{0},{1}}}}}", new Vector4(this.Bias, this.LumContribution, this.CutoffDistance, this.CutoffFalloff));
		this.HMHOFHCEKCD().SetColor("<b>Injection Detector</b>", this.OcclusionColor);
		if (this.Blur != SSAOPro.GGFPOCFCJFG.None)
		{
			int pass = (this.Blur == (SSAOPro.GGFPOCFCJFG)7) ? 0 : 0;
			int num = this.BlurDownsampling ? this.Downsampling : 0;
			RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / num, JONJODLFAEN.height / num, 0);
			RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width / this.Downsampling, JONJODLFAEN.height / this.Downsampling, 1);
			Graphics.Blit(JONJODLFAEN, temporary, this.OPOHKFIBLKD(), 1);
			this.BJPHIFABDFF().SetVector("KatanaNinjaDraw", new Vector2(1553f / (float)JONJODLFAEN.width, 46f));
			Graphics.Blit(temporary, temporary2, this.KJADIPGFIFB(), pass);
			this.FEJDCIEKEAG().SetVector("money", new Vector2(628f, 1604f / (float)JONJODLFAEN.height));
			Graphics.Blit(temporary2, this.DebugAO ? OKIIDHIJBEA : temporary, this.ODJFBBHCOPK(), pass);
			if (!this.DebugAO)
			{
				this.KJADIPGFIFB().SetTexture("MotorbikeSeatStand", temporary);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.BJPHIFABDFF(), 7);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(temporary2);
			return;
		}
		RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / this.Downsampling, JONJODLFAEN.height / this.Downsampling, 1);
		if (this.DebugAO)
		{
			Graphics.Blit(JONJODLFAEN, temporary3, this.JDFOPIGJADF(), 1);
			Graphics.Blit(temporary3, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(temporary3);
			return;
		}
		Graphics.Blit(JONJODLFAEN, temporary3, this.LKNPLIGGIAP(), 0);
		this.FEJDCIEKEAG().SetTexture("podsek action!", temporary3);
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LIPELDNNPGH(), 4);
		RenderTexture.ReleaseTemporary(temporary3);
	}

	// Token: 0x060025F8 RID: 9720 RVA: 0x00107B5F File Offset: 0x00105D5F
	private void OPLLGBIPEKL()
	{
		this.MPCEHPBGHII = base.GetComponent<Camera>();
		this.MPCEHPBGHII.depthTextureMode |= DepthTextureMode.None;
		this.MPCEHPBGHII.depthTextureMode |= DepthTextureMode.Depth;
	}

	// Token: 0x060025F9 RID: 9721 RVA: 0x00107B93 File Offset: 0x00105D93
	public Material CCEEHALMHCJ()
	{
		if (this.BHHEHMIFMBD == null)
		{
			this.BHHEHMIFMBD = new Material(this.Shader);
			this.BHHEHMIFMBD.hideFlags = (HideFlags)(-82);
		}
		return this.BHHEHMIFMBD;
	}

	// Token: 0x060025FA RID: 9722 RVA: 0x00107BC7 File Offset: 0x00105DC7
	public Material MICJKCGCGMM()
	{
		if (this.BHHEHMIFMBD == null)
		{
			this.BHHEHMIFMBD = new Material(this.Shader);
			this.BHHEHMIFMBD.hideFlags = (HideFlags)70;
		}
		return this.BHHEHMIFMBD;
	}

	// Token: 0x060025FB RID: 9723 RVA: 0x0010755B File Offset: 0x0010575B
	private void DBKDHMONHNB()
	{
		if (this.BHHEHMIFMBD)
		{
			UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
		}
	}

	// Token: 0x060025FC RID: 9724 RVA: 0x00107BFC File Offset: 0x00105DFC
	private void IFAEDEGLCPB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (this.Shader == null)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.JDOIMEJHIAL(true);
		if (this.NoiseTexture != null)
		{
			this.BJPHIFABDFF().SetTexture("wpn_add/base", this.NoiseTexture);
		}
		this.OJMOGMHMNHF().SetMatrix("0x", this.MPCEHPBGHII.projectionMatrix.inverse);
		this.AHLHNIFNGJM().SetVector("IceHockeyPassLeft", new Vector4((this.NoiseTexture == null) ? 1995f : ((float)this.NoiseTexture.width), this.Radius, this.Intensity, this.Distance));
		this.OPOHKFIBLKD().SetVector("_Curve", new Vector4(this.Bias, this.LumContribution, this.CutoffDistance, this.CutoffFalloff));
		this.BPIEFJGNJNI().SetColor("holesAll", this.OcclusionColor);
		if (this.Blur != SSAOPro.GGFPOCFCJFG.None)
		{
			int pass = (this.Blur == SSAOPro.GGFPOCFCJFG.Gaussian) ? 6 : 0;
			int num = this.BlurDownsampling ? this.Downsampling : 1;
			RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / num, JONJODLFAEN.height / num, 0);
			RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width / this.Downsampling, JONJODLFAEN.height / this.Downsampling, 1);
			Graphics.Blit(JONJODLFAEN, temporary, this.CCEEHALMHCJ(), 0);
			this.JDFOPIGJADF().SetVector("NextFrame", new Vector2(1208f / (float)JONJODLFAEN.width, 1962f));
			Graphics.Blit(temporary, temporary2, this.HMHOFHCEKCD(), pass);
			this.HLEBIDENKCJ().SetVector("Horizontal", new Vector2(1748f, 478f / (float)JONJODLFAEN.height));
			Graphics.Blit(temporary2, this.DebugAO ? OKIIDHIJBEA : temporary, this.BHAGEJIOHFB(), pass);
			if (!this.DebugAO)
			{
				this.IJDEDAFJLHD().SetTexture("BipedReferences contains one or more missing Transforms.", temporary);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.MICJKCGCGMM(), 5);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(temporary2);
			return;
		}
		RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / this.Downsampling, JONJODLFAEN.height / this.Downsampling, 0);
		if (this.DebugAO)
		{
			Graphics.Blit(JONJODLFAEN, temporary3, this.IHOFOIGKKFM(), 0);
			Graphics.Blit(temporary3, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(temporary3);
			return;
		}
		Graphics.Blit(JONJODLFAEN, temporary3, this.IHOFOIGKKFM(), 0);
		this.DDPOBLELCBI().SetTexture("Hidden/TonemappingColorGrading", temporary3);
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LIPELDNNPGH(), 7);
		RenderTexture.ReleaseTemporary(temporary3);
	}

	// Token: 0x060025FD RID: 9725 RVA: 0x00107E9C File Offset: 0x0010609C
	private void BDMFOHGCKBM(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (this.Shader == null)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.LMOIIDAMKDB(false);
		if (this.NoiseTexture != null)
		{
			this.KJADIPGFIFB().SetTexture("wpn_hook3", this.NoiseTexture);
		}
		this.IJDEDAFJLHD().SetMatrix("wpn_wgt", this.MPCEHPBGHII.projectionMatrix.inverse);
		this.IHOFOIGKKFM().SetVector("?", new Vector4((this.NoiseTexture == null) ? 820f : ((float)this.NoiseTexture.width), this.Radius, this.Intensity, this.Distance));
		this.FEJDCIEKEAG().SetVector("string:", new Vector4(this.Bias, this.LumContribution, this.CutoffDistance, this.CutoffFalloff));
		this.HLEBIDENKCJ().SetColor("Pointing", this.OcclusionColor);
		if (this.Blur != SSAOPro.GGFPOCFCJFG.None)
		{
			int pass = (this.Blur == SSAOPro.GGFPOCFCJFG.None) ? 7 : 0;
			int num = this.BlurDownsampling ? this.Downsampling : 1;
			RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / num, JONJODLFAEN.height / num, 0);
			RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width / this.Downsampling, JONJODLFAEN.height / this.Downsampling, 0);
			Graphics.Blit(JONJODLFAEN, temporary, this.LIPELDNNPGH(), 1);
			this.LIPELDNNPGH().SetVector("[Z]", new Vector2(1194f / (float)JONJODLFAEN.width, 1170f));
			Graphics.Blit(temporary, temporary2, this.LKNPLIGGIAP(), pass);
			this.BHAGEJIOHFB().SetVector("KatanaReady", new Vector2(836f, 1737f / (float)JONJODLFAEN.height));
			Graphics.Blit(temporary2, this.DebugAO ? OKIIDHIJBEA : temporary, this.BOPJMMKEGAB(), pass);
			if (!this.DebugAO)
			{
				this.HMHOFHCEKCD().SetTexture("KatanaVerticalSwing", temporary);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.IJDEDAFJLHD(), 2);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(temporary2);
			return;
		}
		RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / this.Downsampling, JONJODLFAEN.height / this.Downsampling, 0);
		if (this.DebugAO)
		{
			Graphics.Blit(JONJODLFAEN, temporary3, this.BHAGEJIOHFB(), 0);
			Graphics.Blit(temporary3, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(temporary3);
			return;
		}
		Graphics.Blit(JONJODLFAEN, temporary3, this.BHAGEJIOHFB(), 1);
		this.ODJFBBHCOPK().SetTexture("UpHillWalk", temporary3);
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.BJPHIFABDFF(), 7);
		RenderTexture.ReleaseTemporary(temporary3);
	}

	// Token: 0x060025FE RID: 9726 RVA: 0x0010813C File Offset: 0x0010633C
	private void HHLIKPOMGPF(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (this.Shader == null)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.DFBGBPHFEGA(true);
		if (this.NoiseTexture != null)
		{
			this.LIPELDNNPGH().SetTexture("KatanaReady", this.NoiseTexture);
		}
		this.FEJDCIEKEAG().SetMatrix("LINEAR", this.MPCEHPBGHII.projectionMatrix.inverse);
		this.MICJKCGCGMM().SetVector("GestureCrowdPump", new Vector4((this.NoiseTexture == null) ? 396f : ((float)this.NoiseTexture.width), this.Radius, this.Intensity, this.Distance));
		this.EEOIDGFFEGA.SetVector("WorkerShovel", new Vector4(this.Bias, this.LumContribution, this.CutoffDistance, this.CutoffFalloff));
		this.OPOHKFIBLKD().SetColor("CrouchWalk", this.OcclusionColor);
		if (this.Blur != SSAOPro.GGFPOCFCJFG.None)
		{
			int pass = (this.Blur == (SSAOPro.GGFPOCFCJFG)3) ? 3 : 0;
			int num = this.BlurDownsampling ? this.Downsampling : 1;
			RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / num, JONJODLFAEN.height / num, 1);
			RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width / this.Downsampling, JONJODLFAEN.height / this.Downsampling, 1);
			Graphics.Blit(JONJODLFAEN, temporary, this.HMHOFHCEKCD(), 1);
			this.LIPELDNNPGH().SetVector("\n", new Vector2(1620f / (float)JONJODLFAEN.width, 473f));
			Graphics.Blit(temporary, temporary2, this.LKNPLIGGIAP(), pass);
			this.HLEBIDENKCJ().SetVector("_FogSkyHaze", new Vector2(1141f, 1070f / (float)JONJODLFAEN.height));
			Graphics.Blit(temporary2, this.DebugAO ? OKIIDHIJBEA : temporary, this.HLEBIDENKCJ(), pass);
			if (!this.DebugAO)
			{
				this.FEJDCIEKEAG().SetTexture("", temporary);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.BOPJMMKEGAB(), 3);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(temporary2);
			return;
		}
		RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / this.Downsampling, JONJODLFAEN.height / this.Downsampling, 1);
		if (this.DebugAO)
		{
			Graphics.Blit(JONJODLFAEN, temporary3, this.OJMOGMHMNHF(), 0);
			Graphics.Blit(temporary3, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(temporary3);
			return;
		}
		Graphics.Blit(JONJODLFAEN, temporary3, this.OJMOGMHMNHF(), 1);
		this.DDPOBLELCBI().SetTexture("<color='#800000'>Вы потеряли леску: ", temporary3);
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.IHOFOIGKKFM(), 7);
		RenderTexture.ReleaseTemporary(temporary3);
	}

	// Token: 0x060025FF RID: 9727 RVA: 0x0010755B File Offset: 0x0010575B
	private void FBMJIALKPEB()
	{
		if (this.BHHEHMIFMBD)
		{
			UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
		}
	}

	// Token: 0x06002600 RID: 9728 RVA: 0x001083DC File Offset: 0x001065DC
	private void CKGPEFOKKNL()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			Debug.LogWarning("Vertical");
			base.enabled = true;
			return;
		}
		if (!SystemInfo.supportsRenderTextures)
		{
			Debug.LogWarning("Katana 45Deg Swing");
			base.enabled = false;
			return;
		}
		if (this.Shader != null && !this.Shader.isSupported)
		{
			Debug.LogWarning("_FullItem.wav");
			base.enabled = false;
			return;
		}
		this.IMDKJHFEMEL(true);
	}

	// Token: 0x06002601 RID: 9729 RVA: 0x00108450 File Offset: 0x00106650
	private void HNPNJCMJKKK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (this.Shader == null)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.LMOIIDAMKDB(false);
		if (this.NoiseTexture != null)
		{
			this.CCEEHALMHCJ().SetTexture("sound/allmusic/music", this.NoiseTexture);
		}
		this.ODJFBBHCOPK().SetMatrix("error.wav", this.MPCEHPBGHII.projectionMatrix.inverse);
		this.KJADIPGFIFB().SetVector("level", new Vector4((this.NoiseTexture == null) ? 841f : ((float)this.NoiseTexture.width), this.Radius, this.Intensity, this.Distance));
		this.BJPHIFABDFF().SetVector("lineTENSIONKGFRIC=", new Vector4(this.Bias, this.LumContribution, this.CutoffDistance, this.CutoffFalloff));
		this.BPIEFJGNJNI().SetColor("_Sensitivity", this.OcclusionColor);
		if (this.Blur != SSAOPro.GGFPOCFCJFG.None)
		{
			int pass = (this.Blur == (SSAOPro.GGFPOCFCJFG)6) ? 4 : 1;
			int num = this.BlurDownsampling ? this.Downsampling : 0;
			RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / num, JONJODLFAEN.height / num, 0);
			RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width / this.Downsampling, JONJODLFAEN.height / this.Downsampling, 1);
			Graphics.Blit(JONJODLFAEN, temporary, this.AHLHNIFNGJM(), 1);
			this.BOPJMMKEGAB().SetVector("FishbragContainer", new Vector2(1264f / (float)JONJODLFAEN.width, 1423f));
			Graphics.Blit(temporary, temporary2, this.MJIACGHHKFP(), pass);
			this.OPOHKFIBLKD().SetVector("wpn_rod1", new Vector2(423f, 1439f / (float)JONJODLFAEN.height));
			Graphics.Blit(temporary2, this.DebugAO ? OKIIDHIJBEA : temporary, this.DDPOBLELCBI(), pass);
			if (!this.DebugAO)
			{
				this.ODJFBBHCOPK().SetTexture("Mouse X", temporary);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.MICJKCGCGMM(), 4);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(temporary2);
			return;
		}
		RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / this.Downsampling, JONJODLFAEN.height / this.Downsampling, 1);
		if (this.DebugAO)
		{
			Graphics.Blit(JONJODLFAEN, temporary3, this.AHLHNIFNGJM(), 1);
			Graphics.Blit(temporary3, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(temporary3);
			return;
		}
		Graphics.Blit(JONJODLFAEN, temporary3, this.LIPELDNNPGH(), 0);
		this.FEJDCIEKEAG().SetTexture("_MaxCoC", temporary3);
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KJADIPGFIFB(), 4);
		RenderTexture.ReleaseTemporary(temporary3);
	}

	// Token: 0x06002602 RID: 9730 RVA: 0x0010755B File Offset: 0x0010575B
	private void LOPDJDDGDMH()
	{
		if (this.BHHEHMIFMBD)
		{
			UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
		}
	}

	// Token: 0x06002603 RID: 9731 RVA: 0x001086EF File Offset: 0x001068EF
	private void NJJFDKFNBCL()
	{
		this.MPCEHPBGHII = base.GetComponent<Camera>();
		this.MPCEHPBGHII.depthTextureMode |= DepthTextureMode.Depth;
		this.MPCEHPBGHII.depthTextureMode |= (DepthTextureMode.Depth | DepthTextureMode.DepthNormals | DepthTextureMode.MotionVectors);
	}

	// Token: 0x06002604 RID: 9732 RVA: 0x00108723 File Offset: 0x00106923
	public Material DDPOBLELCBI()
	{
		if (this.BHHEHMIFMBD == null)
		{
			this.BHHEHMIFMBD = new Material(this.Shader);
			this.BHHEHMIFMBD.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BHHEHMIFMBD;
	}

	// Token: 0x06002605 RID: 9733 RVA: 0x0010755B File Offset: 0x0010575B
	private void GEMFFFCAJHK()
	{
		if (this.BHHEHMIFMBD)
		{
			UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
		}
	}

	// Token: 0x06002606 RID: 9734 RVA: 0x00107817 File Offset: 0x00105A17
	private void EMOFOHBMJBD()
	{
		this.MPCEHPBGHII = base.GetComponent<Camera>();
		this.MPCEHPBGHII.depthTextureMode |= DepthTextureMode.None;
		this.MPCEHPBGHII.depthTextureMode |= (DepthTextureMode.Depth | DepthTextureMode.DepthNormals);
	}

	// Token: 0x06002607 RID: 9735 RVA: 0x00108757 File Offset: 0x00106957
	private void OnEnable()
	{
		this.MPCEHPBGHII = base.GetComponent<Camera>();
		this.MPCEHPBGHII.depthTextureMode |= DepthTextureMode.Depth;
		this.MPCEHPBGHII.depthTextureMode |= DepthTextureMode.DepthNormals;
	}

	// Token: 0x06002608 RID: 9736 RVA: 0x00107817 File Offset: 0x00105A17
	private void BGKOJIDABKB()
	{
		this.MPCEHPBGHII = base.GetComponent<Camera>();
		this.MPCEHPBGHII.depthTextureMode |= DepthTextureMode.None;
		this.MPCEHPBGHII.depthTextureMode |= (DepthTextureMode.Depth | DepthTextureMode.DepthNormals);
	}

	// Token: 0x06002609 RID: 9737 RVA: 0x0010878C File Offset: 0x0010698C
	private void JLKBMEBFHBI()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			Debug.LogWarning("F1");
			base.enabled = true;
			return;
		}
		if (!SystemInfo.supportsRenderTextures)
		{
			Debug.LogWarning("WeaponReadyFire");
			base.enabled = false;
			return;
		}
		if (this.Shader != null && !this.Shader.isSupported)
		{
			Debug.LogWarning("_info");
			base.enabled = false;
			return;
		}
		this.JOEJPDFEKJE(true);
	}

	// Token: 0x0600260A RID: 9738 RVA: 0x00108800 File Offset: 0x00106A00
	private void LMOIIDAMKDB(bool PGEDLDMLBBE)
	{
		if (!PGEDLDMLBBE && this.GBEMNBGEHHH == (this.NoiseTexture != null) && this.AJNJEFMAFLI == this.CutoffEnabled && this.DNFACHHPHCC == this.LumContribution && this.LJFONAEFPOH == this.OcclusionColor && this.CBIPODLCGOH == this.Samples)
		{
			return;
		}
		Material material = this.FEJDCIEKEAG();
		string[] array = new string[7];
		array[1] = ((this.NoiseTexture != null) ? "IdleMeditate" : "_WrinkleInfluences1");
		array[1] = (this.CutoffEnabled ? "_rcIn.ogg" : "");
		array[8] = ((this.LumContribution > 47f) ? "move" : "http://www.root-motion.com/finalikdox/html/page5.html");
		array[7] = ((this.OcclusionColor == Color.black) ? " <b>®</b></color> " : "Right Hand Effector needs a Target in this demo.");
		array[5] = ((this.Samples == SSAOPro.GPEHFPFDJAF.Low) ? "_TrNewLider.ogg" : ((this.Samples == SSAOPro.GPEHFPFDJAF.VeryLow) ? ".png" : ((this.Samples == SSAOPro.GPEHFPFDJAF.High) ? "Backward Stand" : "ui_default_close.wav")));
		material.shaderKeywords = array;
		this.GBEMNBGEHHH = (this.NoiseTexture != null);
		this.AJNJEFMAFLI = this.CutoffEnabled;
		this.DNFACHHPHCC = this.LumContribution;
		this.LJFONAEFPOH = this.OcclusionColor;
		this.CBIPODLCGOH = this.Samples;
	}

	// Token: 0x0600260B RID: 9739 RVA: 0x00108960 File Offset: 0x00106B60
	private void INMELBNDFAJ(bool PGEDLDMLBBE)
	{
		if (!PGEDLDMLBBE && this.GBEMNBGEHHH == (this.NoiseTexture != null) && this.AJNJEFMAFLI == this.CutoffEnabled && this.DNFACHHPHCC == this.LumContribution && this.LJFONAEFPOH == this.OcclusionColor && this.CBIPODLCGOH == this.Samples)
		{
			return;
		}
		Material material = this.IJDEDAFJLHD();
		string[] array = new string[0];
		array[0] = ((this.NoiseTexture != null) ? "BowInstant" : "_ToneCurve");
		array[0] = (this.CutoffEnabled ? "_WrinkleOcclusionMap3" : "Roller Blade Skate Fwd");
		array[5] = ((this.LumContribution > 392f) ? "reel_type2" : "RollerBladeStop");
		array[2] = ((this.OcclusionColor == Color.black) ? "_MidGrey" : "_Color");
		array[7] = ((this.Samples == SSAOPro.GPEHFPFDJAF.Low) ? "auc_wsbor" : ((this.Samples == SSAOPro.GPEHFPFDJAF.VeryLow) ? "</color>\n" : ((this.Samples == SSAOPro.GPEHFPFDJAF.Low) ? "auk stavka result: " : "crft_to")));
		material.shaderKeywords = array;
		this.GBEMNBGEHHH = (this.NoiseTexture != null);
		this.AJNJEFMAFLI = this.CutoffEnabled;
		this.DNFACHHPHCC = this.LumContribution;
		this.LJFONAEFPOH = this.OcclusionColor;
		this.CBIPODLCGOH = this.Samples;
	}

	// Token: 0x0600260C RID: 9740 RVA: 0x00108AC0 File Offset: 0x00106CC0
	private void LMEJKAEIDCO()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			Debug.LogWarning("MotorbikeAirWalk");
			base.enabled = true;
			return;
		}
		if (!SystemInfo.supportsRenderTextures)
		{
			Debug.LogWarning("MotorbikeLassoLeft");
			base.enabled = true;
			return;
		}
		if (this.Shader != null && !this.Shader.isSupported)
		{
			Debug.LogWarning("_Offsets");
			base.enabled = true;
			return;
		}
		this.IMDKJHFEMEL(true);
	}

	// Token: 0x0600260D RID: 9741 RVA: 0x00108B33 File Offset: 0x00106D33
	private void BBAGNFIALFG()
	{
		this.MPCEHPBGHII = base.GetComponent<Camera>();
		this.MPCEHPBGHII.depthTextureMode |= DepthTextureMode.Depth;
		this.MPCEHPBGHII.depthTextureMode |= (DepthTextureMode.Depth | DepthTextureMode.DepthNormals);
	}

	// Token: 0x0600260E RID: 9742 RVA: 0x0010755B File Offset: 0x0010575B
	private void JJHAIFDONLP()
	{
		if (this.BHHEHMIFMBD)
		{
			UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
		}
	}

	// Token: 0x0600260F RID: 9743 RVA: 0x00108B67 File Offset: 0x00106D67
	public Material LKNPLIGGIAP()
	{
		if (this.BHHEHMIFMBD == null)
		{
			this.BHHEHMIFMBD = new Material(this.Shader);
			this.BHHEHMIFMBD.hideFlags = (HideFlags)89;
		}
		return this.BHHEHMIFMBD;
	}

	// Token: 0x06002610 RID: 9744 RVA: 0x0010755B File Offset: 0x0010575B
	private void ECIAEIEKCCF()
	{
		if (this.BHHEHMIFMBD)
		{
			UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
		}
	}

	// Token: 0x06002611 RID: 9745 RVA: 0x00108B9C File Offset: 0x00106D9C
	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (this.Shader == null)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.DLNNOLELPBO(false);
		if (this.NoiseTexture != null)
		{
			this.EEOIDGFFEGA.SetTexture("_NoiseTex", this.NoiseTexture);
		}
		this.EEOIDGFFEGA.SetMatrix("_InverseProj", this.MPCEHPBGHII.projectionMatrix.inverse);
		this.EEOIDGFFEGA.SetVector("_Params1", new Vector4((this.NoiseTexture == null) ? 0f : ((float)this.NoiseTexture.width), this.Radius, this.Intensity, this.Distance));
		this.EEOIDGFFEGA.SetVector("_Params2", new Vector4(this.Bias, this.LumContribution, this.CutoffDistance, this.CutoffFalloff));
		this.EEOIDGFFEGA.SetColor("_OcclusionColor", this.OcclusionColor);
		if (this.Blur != SSAOPro.GGFPOCFCJFG.None)
		{
			int pass = (this.Blur == SSAOPro.GGFPOCFCJFG.Bilateral) ? 2 : 1;
			int num = this.BlurDownsampling ? this.Downsampling : 1;
			RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / num, JONJODLFAEN.height / num, 0);
			RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width / this.Downsampling, JONJODLFAEN.height / this.Downsampling, 0);
			Graphics.Blit(JONJODLFAEN, temporary, this.EEOIDGFFEGA, 0);
			this.EEOIDGFFEGA.SetVector("_Direction", new Vector2(1f / (float)JONJODLFAEN.width, 0f));
			Graphics.Blit(temporary, temporary2, this.EEOIDGFFEGA, pass);
			this.EEOIDGFFEGA.SetVector("_Direction", new Vector2(0f, 1f / (float)JONJODLFAEN.height));
			Graphics.Blit(temporary2, this.DebugAO ? OKIIDHIJBEA : temporary, this.EEOIDGFFEGA, pass);
			if (!this.DebugAO)
			{
				this.EEOIDGFFEGA.SetTexture("_SSAOTex", temporary);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EEOIDGFFEGA, 3);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(temporary2);
			return;
		}
		RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / this.Downsampling, JONJODLFAEN.height / this.Downsampling, 0);
		if (this.DebugAO)
		{
			Graphics.Blit(JONJODLFAEN, temporary3, this.EEOIDGFFEGA, 0);
			Graphics.Blit(temporary3, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(temporary3);
			return;
		}
		Graphics.Blit(JONJODLFAEN, temporary3, this.EEOIDGFFEGA, 0);
		this.EEOIDGFFEGA.SetTexture("_SSAOTex", temporary3);
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EEOIDGFFEGA, 3);
		RenderTexture.ReleaseTemporary(temporary3);
	}

	// Token: 0x06002612 RID: 9746 RVA: 0x00108E3C File Offset: 0x0010703C
	private void KFGKKLAKFGH()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			Debug.LogWarning("_LowRez");
			base.enabled = false;
			return;
		}
		if (!SystemInfo.supportsRenderTextures)
		{
			Debug.LogWarning("Msg error");
			base.enabled = true;
			return;
		}
		if (this.Shader != null && !this.Shader.isSupported)
		{
			Debug.LogWarning("Ошибка!");
			base.enabled = true;
			return;
		}
		this.LBDNBJEAMMC(true);
	}

	// Token: 0x06002613 RID: 9747 RVA: 0x0010755B File Offset: 0x0010575B
	private void DMPJOEHFABC()
	{
		if (this.BHHEHMIFMBD)
		{
			UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
		}
	}

	// Token: 0x06002614 RID: 9748 RVA: 0x0010755B File Offset: 0x0010575B
	private void PMPBNLCGLCK()
	{
		if (this.BHHEHMIFMBD)
		{
			UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
		}
	}

	// Token: 0x06002615 RID: 9749 RVA: 0x0010755B File Offset: 0x0010575B
	private void MCPKECOLINL()
	{
		if (this.BHHEHMIFMBD)
		{
			UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
		}
	}

	// Token: 0x06002616 RID: 9750 RVA: 0x00108EB0 File Offset: 0x001070B0
	private void NCALLFHEAGJ()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			Debug.LogWarning("implevel");
			base.enabled = true;
			return;
		}
		if (!SystemInfo.supportsRenderTextures)
		{
			Debug.LogWarning("WateringCan");
			base.enabled = false;
			return;
		}
		if (this.Shader != null && !this.Shader.isSupported)
		{
			Debug.LogWarning("_FogSkyColor");
			base.enabled = false;
			return;
		}
		this.DFBGBPHFEGA(true);
	}

	// Token: 0x06002617 RID: 9751 RVA: 0x00108F24 File Offset: 0x00107124
	private void MNPGIEOOOCK(bool PGEDLDMLBBE)
	{
		if (!PGEDLDMLBBE && this.GBEMNBGEHHH == (this.NoiseTexture != null) && this.AJNJEFMAFLI == this.CutoffEnabled && this.DNFACHHPHCC == this.LumContribution && this.LJFONAEFPOH == this.OcclusionColor && this.CBIPODLCGOH == this.Samples)
		{
			return;
		}
		Material material = this.ODJFBBHCOPK();
		string[] array = new string[3];
		array[1] = ((this.NoiseTexture != null) ? "<color='#808080'>[{2}]</color> <color='#a0ffa0'>{0}</color>: {1}" : "HH:mm");
		array[1] = (this.CutoffEnabled ? "soft" : "_History3LumaTex");
		array[1] = ((this.LumContribution > 28f) ? "palm" : "NadeThrow");
		array[0] = ((this.OcclusionColor == Color.black) ? "auk_pbuykey" : "dragWeapon = null 3");
		array[5] = ((this.Samples == SSAOPro.GPEHFPFDJAF.Low) ? "SkateboardIdle" : ((this.Samples == SSAOPro.GPEHFPFDJAF.VeryLow) ? "+{0}" : ((this.Samples == SSAOPro.GPEHFPFDJAF.Medium) ? "VaderChoke" : "_FogSkyColor")));
		material.shaderKeywords = array;
		this.GBEMNBGEHHH = (this.NoiseTexture != null);
		this.AJNJEFMAFLI = this.CutoffEnabled;
		this.DNFACHHPHCC = this.LumContribution;
		this.LJFONAEFPOH = this.OcclusionColor;
		this.CBIPODLCGOH = this.Samples;
	}

	// Token: 0x06002618 RID: 9752 RVA: 0x00109082 File Offset: 0x00107282
	public Material IHOFOIGKKFM()
	{
		if (this.BHHEHMIFMBD == null)
		{
			this.BHHEHMIFMBD = new Material(this.Shader);
			this.BHHEHMIFMBD.hideFlags = (HideFlags)(-72);
		}
		return this.BHHEHMIFMBD;
	}

	// Token: 0x06002619 RID: 9753 RVA: 0x001090B8 File Offset: 0x001072B8
	private void FHMFEHDKIGK(bool PGEDLDMLBBE)
	{
		if (!PGEDLDMLBBE && this.GBEMNBGEHHH == (this.NoiseTexture != null) && this.AJNJEFMAFLI == this.CutoffEnabled && this.DNFACHHPHCC == this.LumContribution && this.LJFONAEFPOH == this.OcclusionColor && this.CBIPODLCGOH == this.Samples)
		{
			return;
		}
		Material material = this.AHLHNIFNGJM();
		string[] array = new string[8];
		array[1] = ((this.NoiseTexture != null) ? "SoccerKeeperStrafeRight" : "shop_t8");
		array[1] = (this.CutoffEnabled ? "" : "http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		array[2] = ((this.LumContribution > 513f) ? "PaperTurn.wav" : "usr_inf_a3");
		array[7] = ((this.OcclusionColor == Color.black) ? "FOG_HAZE_ON" : "<color='#003000'>");
		array[1] = ((this.Samples == SSAOPro.GPEHFPFDJAF.Low) ? "IdleReady" : ((this.Samples == (SSAOPro.GPEHFPFDJAF)4) ? "_Offsets" : ((this.Samples == SSAOPro.GPEHFPFDJAF.Low) ? "" : "txt")));
		material.shaderKeywords = array;
		this.GBEMNBGEHHH = (this.NoiseTexture != null);
		this.AJNJEFMAFLI = this.CutoffEnabled;
		this.DNFACHHPHCC = this.LumContribution;
		this.LJFONAEFPOH = this.OcclusionColor;
		this.CBIPODLCGOH = this.Samples;
	}

	// Token: 0x0600261A RID: 9754 RVA: 0x00109216 File Offset: 0x00107416
	private void FDMGAGCBBDP()
	{
		this.MPCEHPBGHII = base.GetComponent<Camera>();
		this.MPCEHPBGHII.depthTextureMode |= DepthTextureMode.None;
		this.MPCEHPBGHII.depthTextureMode |= (DepthTextureMode)8;
	}

	// Token: 0x0600261B RID: 9755 RVA: 0x0010755B File Offset: 0x0010575B
	private void PGCPOCKJFGP()
	{
		if (this.BHHEHMIFMBD)
		{
			UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
		}
	}

	// Token: 0x0600261C RID: 9756 RVA: 0x0010924C File Offset: 0x0010744C
	private void PLBDELOIINH()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			Debug.LogWarning("_StereoToPrevViewProjCombined1");
			base.enabled = true;
			return;
		}
		if (!SystemInfo.supportsRenderTextures)
		{
			Debug.LogWarning("wpn_chair3");
			base.enabled = true;
			return;
		}
		if (this.Shader != null && !this.Shader.isSupported)
		{
			Debug.LogWarning("");
			base.enabled = false;
			return;
		}
		this.HEAKELNLFOG(false);
	}

	// Token: 0x0600261D RID: 9757 RVA: 0x001092C0 File Offset: 0x001074C0
	private void JHHHJFOOFII(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (this.Shader == null)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.LMOIIDAMKDB(false);
		if (this.NoiseTexture != null)
		{
			this.BOPJMMKEGAB().SetTexture(" ?", this.NoiseTexture);
		}
		this.CCEEHALMHCJ().SetMatrix("OfficeSittingMouseMovement", this.MPCEHPBGHII.projectionMatrix.inverse);
		this.JDFOPIGJADF().SetVector("ОК", new Vector4((this.NoiseTexture == null) ? 1940f : ((float)this.NoiseTexture.width), this.Radius, this.Intensity, this.Distance));
		this.HMHOFHCEKCD().SetVector("", new Vector4(this.Bias, this.LumContribution, this.CutoffDistance, this.CutoffFalloff));
		this.BPIEFJGNJNI().SetColor(")?", this.OcclusionColor);
		if (this.Blur != SSAOPro.GGFPOCFCJFG.None)
		{
			int pass = (this.Blur == (SSAOPro.GGFPOCFCJFG)3) ? 1 : 1;
			int num = this.BlurDownsampling ? this.Downsampling : 1;
			RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / num, JONJODLFAEN.height / num, 0);
			RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width / this.Downsampling, JONJODLFAEN.height / this.Downsampling, 1);
			Graphics.Blit(JONJODLFAEN, temporary, this.BHAGEJIOHFB(), 1);
			this.HMHOFHCEKCD().SetVector("StrafeRunRight", new Vector2(338f / (float)JONJODLFAEN.width, 1945f));
			Graphics.Blit(temporary, temporary2, this.KJADIPGFIFB(), pass);
			this.HMHOFHCEKCD().SetVector("ShotgunReloadChamber", new Vector2(1415f, 1965f / (float)JONJODLFAEN.height));
			Graphics.Blit(temporary2, this.DebugAO ? OKIIDHIJBEA : temporary, this.LKNPLIGGIAP(), pass);
			if (!this.DebugAO)
			{
				this.BOPJMMKEGAB().SetTexture("_camRotate", temporary);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.CCEEHALMHCJ(), 0);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(temporary2);
			return;
		}
		RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / this.Downsampling, JONJODLFAEN.height / this.Downsampling, 0);
		if (this.DebugAO)
		{
			Graphics.Blit(JONJODLFAEN, temporary3, this.OPOHKFIBLKD(), 0);
			Graphics.Blit(temporary3, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(temporary3);
			return;
		}
		Graphics.Blit(JONJODLFAEN, temporary3, this.FEJDCIEKEAG(), 1);
		this.OPOHKFIBLKD().SetTexture("crft_cnt", temporary3);
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LIPELDNNPGH(), 3);
		RenderTexture.ReleaseTemporary(temporary3);
	}

	// Token: 0x0600261E RID: 9758 RVA: 0x00109560 File Offset: 0x00107760
	private void GAJNNKIFMOG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (this.Shader == null)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.JOEJPDFEKJE(false);
		if (this.NoiseTexture != null)
		{
			this.HLEBIDENKCJ().SetTexture("invn_ver3", this.NoiseTexture);
		}
		this.KJADIPGFIFB().SetMatrix("1 Hand Sword Ready", this.MPCEHPBGHII.projectionMatrix.inverse);
		this.EEOIDGFFEGA.SetVector("\n", new Vector4((this.NoiseTexture == null) ? 192f : ((float)this.NoiseTexture.width), this.Radius, this.Intensity, this.Distance));
		this.BPIEFJGNJNI().SetVector("", new Vector4(this.Bias, this.LumContribution, this.CutoffDistance, this.CutoffFalloff));
		this.FEJDCIEKEAG().SetColor("Try to change this Vector3 in memory:\n", this.OcclusionColor);
		if (this.Blur != SSAOPro.GGFPOCFCJFG.None)
		{
			int pass = (this.Blur == (SSAOPro.GGFPOCFCJFG)6) ? 5 : 1;
			int num = this.BlurDownsampling ? this.Downsampling : 0;
			RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / num, JONJODLFAEN.height / num, 0);
			RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width / this.Downsampling, JONJODLFAEN.height / this.Downsampling, 1);
			Graphics.Blit(JONJODLFAEN, temporary, this.EEOIDGFFEGA, 1);
			this.IJDEDAFJLHD().SetVector("BowInstant", new Vector2(86f / (float)JONJODLFAEN.width, 1470f));
			Graphics.Blit(temporary, temporary2, this.BHAGEJIOHFB(), pass);
			this.FEJDCIEKEAG().SetVector("F ", new Vector2(68f, 1256f / (float)JONJODLFAEN.height));
			Graphics.Blit(temporary2, this.DebugAO ? OKIIDHIJBEA : temporary, this.CCEEHALMHCJ(), pass);
			if (!this.DebugAO)
			{
				this.BPIEFJGNJNI().SetTexture("name", temporary);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.BPIEFJGNJNI(), 0);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(temporary2);
			return;
		}
		RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / this.Downsampling, JONJODLFAEN.height / this.Downsampling, 1);
		if (this.DebugAO)
		{
			Graphics.Blit(JONJODLFAEN, temporary3, this.CCEEHALMHCJ(), 0);
			Graphics.Blit(temporary3, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(temporary3);
			return;
		}
		Graphics.Blit(JONJODLFAEN, temporary3, this.LKNPLIGGIAP(), 1);
		this.DDPOBLELCBI().SetTexture("prov_sob_", temporary3);
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LIPELDNNPGH(), 5);
		RenderTexture.ReleaseTemporary(temporary3);
	}

	// Token: 0x0600261F RID: 9759 RVA: 0x0010755B File Offset: 0x0010575B
	private void IDADGNCMLID()
	{
		if (this.BHHEHMIFMBD)
		{
			UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
		}
	}

	// Token: 0x06002620 RID: 9760 RVA: 0x0010755B File Offset: 0x0010575B
	private void JOPKEFJOKIM()
	{
		if (this.BHHEHMIFMBD)
		{
			UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
		}
	}

	// Token: 0x06002621 RID: 9761 RVA: 0x00109800 File Offset: 0x00107A00
	private void LBDNBJEAMMC(bool PGEDLDMLBBE)
	{
		if (!PGEDLDMLBBE && this.GBEMNBGEHHH == (this.NoiseTexture != null) && this.AJNJEFMAFLI == this.CutoffEnabled && this.DNFACHHPHCC == this.LumContribution && this.LJFONAEFPOH == this.OcclusionColor && this.CBIPODLCGOH == this.Samples)
		{
			return;
		}
		Material material = this.ODJFBBHCOPK();
		string[] array = new string[5];
		array[1] = ((this.NoiseTexture != null) ? "BackPackOff" : "cht_msg26");
		array[0] = (this.CutoffEnabled ? "_WaterLevel" : "</color>");
		array[0] = ((this.LumContribution > 914f) ? "wpn_add/base" : "bs_lev");
		array[3] = ((this.OcclusionColor == Color.black) ? "IdleStand" : "offsets");
		array[5] = ((this.Samples == SSAOPro.GPEHFPFDJAF.VeryLow) ? "BaseMaterial" : ((this.Samples == (SSAOPro.GPEHFPFDJAF)8) ? "_BlendTex" : ((this.Samples == (SSAOPro.GPEHFPFDJAF)4) ? "release" : "1HandSwordStrafeLeft")));
		material.shaderKeywords = array;
		this.GBEMNBGEHHH = (this.NoiseTexture != null);
		this.AJNJEFMAFLI = this.CutoffEnabled;
		this.DNFACHHPHCC = this.LumContribution;
		this.LJFONAEFPOH = this.OcclusionColor;
		this.CBIPODLCGOH = this.Samples;
	}

	// Token: 0x06002622 RID: 9762 RVA: 0x0010755B File Offset: 0x0010575B
	private void DAJCCMDCMIK()
	{
		if (this.BHHEHMIFMBD)
		{
			UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
		}
	}

	// Token: 0x06002623 RID: 9763 RVA: 0x00109960 File Offset: 0x00107B60
	private void CGFDDFHECLJ()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			Debug.LogWarning("USE_MASK");
			base.enabled = true;
			return;
		}
		if (!SystemInfo.supportsRenderTextures)
		{
			Debug.LogWarning("FOG_EXP");
			base.enabled = true;
			return;
		}
		if (this.Shader != null && !this.Shader.isSupported)
		{
			Debug.LogWarning("IceHockeyShotRight");
			base.enabled = true;
			return;
		}
		this.KIGKPIEPKPA(true);
	}

	// Token: 0x06002624 RID: 9764 RVA: 0x0010755B File Offset: 0x0010575B
	private void MGCCMKOJCCF()
	{
		if (this.BHHEHMIFMBD)
		{
			UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
		}
	}

	// Token: 0x06002625 RID: 9765 RVA: 0x001099D3 File Offset: 0x00107BD3
	private void DHFLFGBENBF()
	{
		this.MPCEHPBGHII = base.GetComponent<Camera>();
		this.MPCEHPBGHII.depthTextureMode |= DepthTextureMode.None;
		this.MPCEHPBGHII.depthTextureMode |= DepthTextureMode.None;
	}

	// Token: 0x06002626 RID: 9766 RVA: 0x0010755B File Offset: 0x0010575B
	private void ODMIGNCLMKI()
	{
		if (this.BHHEHMIFMBD)
		{
			UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
		}
	}

	// Token: 0x06002627 RID: 9767 RVA: 0x00109A08 File Offset: 0x00107C08
	private void IMPMHDDEOJN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (this.Shader == null)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.INMELBNDFAJ(true);
		if (this.NoiseTexture != null)
		{
			this.BPIEFJGNJNI().SetTexture("", this.NoiseTexture);
		}
		this.LKNPLIGGIAP().SetMatrix("' is not a valid integer", this.MPCEHPBGHII.projectionMatrix.inverse);
		this.IJDEDAFJLHD().SetVector("SneakLeft", new Vector4((this.NoiseTexture == null) ? 1163f : ((float)this.NoiseTexture.width), this.Radius, this.Intensity, this.Distance));
		this.IHOFOIGKKFM().SetVector("qcmd=", new Vector4(this.Bias, this.LumContribution, this.CutoffDistance, this.CutoffFalloff));
		this.IJDEDAFJLHD().SetColor("&", this.OcclusionColor);
		if (this.Blur != SSAOPro.GGFPOCFCJFG.None)
		{
			int pass = (this.Blur == SSAOPro.GGFPOCFCJFG.Bilateral) ? 1 : 1;
			int num = this.BlurDownsampling ? this.Downsampling : 1;
			RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / num, JONJODLFAEN.height / num, 0);
			RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width / this.Downsampling, JONJODLFAEN.height / this.Downsampling, 0);
			Graphics.Blit(JONJODLFAEN, temporary, this.BPIEFJGNJNI(), 1);
			this.BPIEFJGNJNI().SetVector("_LowRez", new Vector2(388f / (float)JONJODLFAEN.width, 463f));
			Graphics.Blit(temporary, temporary2, this.DDPOBLELCBI(), pass);
			this.BPIEFJGNJNI().SetVector("USE_DIAG_SEARCH", new Vector2(832f, 1420f / (float)JONJODLFAEN.height));
			Graphics.Blit(temporary2, this.DebugAO ? OKIIDHIJBEA : temporary, this.AHLHNIFNGJM(), pass);
			if (!this.DebugAO)
			{
				this.AHLHNIFNGJM().SetTexture("_Bloom", temporary);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HLEBIDENKCJ(), 1);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(temporary2);
			return;
		}
		RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / this.Downsampling, JONJODLFAEN.height / this.Downsampling, 0);
		if (this.DebugAO)
		{
			Graphics.Blit(JONJODLFAEN, temporary3, this.IJDEDAFJLHD(), 0);
			Graphics.Blit(temporary3, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(temporary3);
			return;
		}
		Graphics.Blit(JONJODLFAEN, temporary3, this.IJDEDAFJLHD(), 0);
		this.BPIEFJGNJNI().SetTexture("heavy", temporary3);
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.MICJKCGCGMM(), 8);
		RenderTexture.ReleaseTemporary(temporary3);
	}

	// Token: 0x06002628 RID: 9768 RVA: 0x00109CA8 File Offset: 0x00107EA8
	private void EOAKCELKDOP(bool PGEDLDMLBBE)
	{
		if (!PGEDLDMLBBE && this.GBEMNBGEHHH == (this.NoiseTexture != null) && this.AJNJEFMAFLI == this.CutoffEnabled && this.DNFACHHPHCC == this.LumContribution && this.LJFONAEFPOH == this.OcclusionColor && this.CBIPODLCGOH == this.Samples)
		{
			return;
		}
		Material material = this.DDPOBLELCBI();
		string[] array = new string[0];
		array[1] = ((this.NoiseTexture != null) ? "fshop_hd4" : "wpn_eat8");
		array[1] = (this.CutoffEnabled ? "</color>" : "Delete shadow");
		array[7] = ((this.LumContribution > 1581f) ? "Keeper Strafe Right" : "<color='#003000'>+{0} {1}</color>");
		array[0] = ((this.OcclusionColor == Color.black) ? "-none: " : "");
		array[5] = ((this.Samples == SSAOPro.GPEHFPFDJAF.Low) ? "\n" : ((this.Samples == (SSAOPro.GPEHFPFDJAF)7) ? "post_4" : ((this.Samples == SSAOPro.GPEHFPFDJAF.High) ? "16 samples" : " on layer ")));
		material.shaderKeywords = array;
		this.GBEMNBGEHHH = (this.NoiseTexture != null);
		this.AJNJEFMAFLI = this.CutoffEnabled;
		this.DNFACHHPHCC = this.LumContribution;
		this.LJFONAEFPOH = this.OcclusionColor;
		this.CBIPODLCGOH = this.Samples;
	}

	// Token: 0x06002629 RID: 9769 RVA: 0x00109E08 File Offset: 0x00108008
	private void Start()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			Debug.LogWarning("Image Effects are not supported on this platform.");
			base.enabled = false;
			return;
		}
		if (!SystemInfo.supportsRenderTextures)
		{
			Debug.LogWarning("RenderTextures are not supported on this platform.");
			base.enabled = false;
			return;
		}
		if (this.Shader != null && !this.Shader.isSupported)
		{
			Debug.LogWarning("Unsupported shader.");
			base.enabled = false;
			return;
		}
		this.DLNNOLELPBO(true);
	}

	// Token: 0x17000088 RID: 136
	// (get) Token: 0x0600262A RID: 9770 RVA: 0x00109E7B File Offset: 0x0010807B
	public Material EEOIDGFFEGA
	{
		get
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = new Material(this.Shader);
				this.BHHEHMIFMBD.hideFlags = HideFlags.HideAndDontSave;
			}
			return this.BHHEHMIFMBD;
		}
	}

	// Token: 0x0600262B RID: 9771 RVA: 0x00109EAF File Offset: 0x001080AF
	public Material OJMOGMHMNHF()
	{
		if (this.BHHEHMIFMBD == null)
		{
			this.BHHEHMIFMBD = new Material(this.Shader);
			this.BHHEHMIFMBD.hideFlags = (HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BHHEHMIFMBD;
	}

	// Token: 0x0600262C RID: 9772 RVA: 0x00109EE3 File Offset: 0x001080E3
	public Material HLEBIDENKCJ()
	{
		if (this.BHHEHMIFMBD == null)
		{
			this.BHHEHMIFMBD = new Material(this.Shader);
			this.BHHEHMIFMBD.hideFlags = (HideFlags)(-65);
		}
		return this.BHHEHMIFMBD;
	}

	// Token: 0x0600262D RID: 9773 RVA: 0x00109F18 File Offset: 0x00108118
	private void KIGKPIEPKPA(bool PGEDLDMLBBE)
	{
		if (!PGEDLDMLBBE && this.GBEMNBGEHHH == (this.NoiseTexture != null) && this.AJNJEFMAFLI == this.CutoffEnabled && this.DNFACHHPHCC == this.LumContribution && this.LJFONAEFPOH == this.OcclusionColor && this.CBIPODLCGOH == this.Samples)
		{
			return;
		}
		Material material = this.BHAGEJIOHFB();
		string[] array = new string[1];
		array[1] = ((this.NoiseTexture != null) ? "FlyLeft" : "TOD_MoonHaloColor");
		array[1] = (this.CutoffEnabled ? "BAG" : "WizardPowerUp");
		array[4] = ((this.LumContribution > 1238f) ? "</color></i>" : " x");
		array[8] = ((this.OcclusionColor == Color.black) ? "StaffStand" : "IdleStandingJump");
		array[4] = ((this.Samples == SSAOPro.GPEHFPFDJAF.VeryLow) ? "Drop " : ((this.Samples == (SSAOPro.GPEHFPFDJAF)8) ? "DoActivateTrigger" : ((this.Samples == (SSAOPro.GPEHFPFDJAF)7) ? "SkateboardIdle" : "[Steamworks.NET] DllCheck Test returned false, One or more of the Steamworks binaries seems to be the wrong version.")));
		material.shaderKeywords = array;
		this.GBEMNBGEHHH = (this.NoiseTexture != null);
		this.AJNJEFMAFLI = this.CutoffEnabled;
		this.DNFACHHPHCC = this.LumContribution;
		this.LJFONAEFPOH = this.OcclusionColor;
		this.CBIPODLCGOH = this.Samples;
	}

	// Token: 0x0600262E RID: 9774 RVA: 0x00107817 File Offset: 0x00105A17
	private void CIDFLCGOBKO()
	{
		this.MPCEHPBGHII = base.GetComponent<Camera>();
		this.MPCEHPBGHII.depthTextureMode |= DepthTextureMode.None;
		this.MPCEHPBGHII.depthTextureMode |= (DepthTextureMode.Depth | DepthTextureMode.DepthNormals);
	}

	// Token: 0x0600262F RID: 9775 RVA: 0x0010755B File Offset: 0x0010575B
	private void EDFBGLOHBDG()
	{
		if (this.BHHEHMIFMBD)
		{
			UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
		}
	}

	// Token: 0x06002630 RID: 9776 RVA: 0x0010A076 File Offset: 0x00108276
	public Material BOPJMMKEGAB()
	{
		if (this.BHHEHMIFMBD == null)
		{
			this.BHHEHMIFMBD = new Material(this.Shader);
			this.BHHEHMIFMBD.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BHHEHMIFMBD;
	}

	// Token: 0x06002631 RID: 9777 RVA: 0x0010755B File Offset: 0x0010575B
	private void MPJEHEBNLDH()
	{
		if (this.BHHEHMIFMBD)
		{
			UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
		}
	}

	// Token: 0x06002632 RID: 9778 RVA: 0x0010A0AA File Offset: 0x001082AA
	public Material AHLHNIFNGJM()
	{
		if (this.BHHEHMIFMBD == null)
		{
			this.BHHEHMIFMBD = new Material(this.Shader);
			this.BHHEHMIFMBD.hideFlags = (HideFlags)64;
		}
		return this.BHHEHMIFMBD;
	}

	// Token: 0x06002633 RID: 9779 RVA: 0x0010755B File Offset: 0x0010575B
	private void OFGKOKEGLFM()
	{
		if (this.BHHEHMIFMBD)
		{
			UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
		}
	}

	// Token: 0x06002634 RID: 9780 RVA: 0x0010A0E0 File Offset: 0x001082E0
	private void DFBGBPHFEGA(bool PGEDLDMLBBE)
	{
		if (!PGEDLDMLBBE && this.GBEMNBGEHHH == (this.NoiseTexture != null) && this.AJNJEFMAFLI == this.CutoffEnabled && this.DNFACHHPHCC == this.LumContribution && this.LJFONAEFPOH == this.OcclusionColor && this.CBIPODLCGOH == this.Samples)
		{
			return;
		}
		Material material = this.ODJFBBHCOPK();
		string[] array = new string[0];
		array[1] = ((this.NoiseTexture != null) ? "http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/" : "[ACTk] A decimal must be created from exactly 16 bytes");
		array[0] = (this.CutoffEnabled ? "21" : "_NeighborMaxTex");
		array[2] = ((this.LumContribution > 1923f) ? "pempty" : "WizardBlock");
		array[0] = ((this.OcclusionColor == Color.black) ? "_Slope" : "4096");
		array[7] = ((this.Samples == SSAOPro.GPEHFPFDJAF.Low) ? "ZombieWalk" : ((this.Samples == (SSAOPro.GPEHFPFDJAF)8) ? "error" : ((this.Samples == (SSAOPro.GPEHFPFDJAF)4) ? "inv_icost" : "CardPlayerLook")));
		material.shaderKeywords = array;
		this.GBEMNBGEHHH = (this.NoiseTexture != null);
		this.AJNJEFMAFLI = this.CutoffEnabled;
		this.DNFACHHPHCC = this.LumContribution;
		this.LJFONAEFPOH = this.OcclusionColor;
		this.CBIPODLCGOH = this.Samples;
	}

	// Token: 0x06002635 RID: 9781 RVA: 0x0010755B File Offset: 0x0010575B
	private void LPNHJCGGBPH()
	{
		if (this.BHHEHMIFMBD)
		{
			UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
		}
	}

	// Token: 0x06002636 RID: 9782 RVA: 0x0010A240 File Offset: 0x00108440
	private void ALNHCIOIBPP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (this.Shader == null)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.NLMFLNHMBDP(false);
		if (this.NoiseTexture != null)
		{
			this.OPOHKFIBLKD().SetTexture("минут", this.NoiseTexture);
		}
		this.BJPHIFABDFF().SetMatrix("SYS", this.MPCEHPBGHII.projectionMatrix.inverse);
		this.DDPOBLELCBI().SetVector("gi_nach", new Vector4((this.NoiseTexture == null) ? 570f : ((float)this.NoiseTexture.width), this.Radius, this.Intensity, this.Distance));
		this.HLEBIDENKCJ().SetVector("ProneIdle", new Vector4(this.Bias, this.LumContribution, this.CutoffDistance, this.CutoffFalloff));
		this.CCEEHALMHCJ().SetColor(",", this.OcclusionColor);
		if (this.Blur != SSAOPro.GGFPOCFCJFG.None)
		{
			int pass = (this.Blur == (SSAOPro.GGFPOCFCJFG)6) ? 8 : 0;
			int num = this.BlurDownsampling ? this.Downsampling : 0;
			RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / num, JONJODLFAEN.height / num, 0);
			RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width / this.Downsampling, JONJODLFAEN.height / this.Downsampling, 0);
			Graphics.Blit(JONJODLFAEN, temporary, this.LIPELDNNPGH(), 0);
			this.BOPJMMKEGAB().SetVector("FrontKick", new Vector2(996f / (float)JONJODLFAEN.width, 1767f));
			Graphics.Blit(temporary, temporary2, this.OPOHKFIBLKD(), pass);
			this.EEOIDGFFEGA.SetVector("X", new Vector2(482f, 1277f / (float)JONJODLFAEN.height));
			Graphics.Blit(temporary2, this.DebugAO ? OKIIDHIJBEA : temporary, this.BHAGEJIOHFB(), pass);
			if (!this.DebugAO)
			{
				this.LKNPLIGGIAP().SetTexture("Sound/", temporary);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KJADIPGFIFB(), 2);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(temporary2);
			return;
		}
		RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / this.Downsampling, JONJODLFAEN.height / this.Downsampling, 1);
		if (this.DebugAO)
		{
			Graphics.Blit(JONJODLFAEN, temporary3, this.EEOIDGFFEGA, 0);
			Graphics.Blit(temporary3, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(temporary3);
			return;
		}
		Graphics.Blit(JONJODLFAEN, temporary3, this.BPIEFJGNJNI(), 0);
		this.HLEBIDENKCJ().SetTexture("<b>ObscuredFloat:</b> ", temporary3);
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.CCEEHALMHCJ(), 2);
		RenderTexture.ReleaseTemporary(temporary3);
	}

	// Token: 0x06002637 RID: 9783 RVA: 0x0010A4DF File Offset: 0x001086DF
	public Material IJDEDAFJLHD()
	{
		if (this.BHHEHMIFMBD == null)
		{
			this.BHHEHMIFMBD = new Material(this.Shader);
			this.BHHEHMIFMBD.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BHHEHMIFMBD;
	}

	// Token: 0x06002638 RID: 9784 RVA: 0x0010755B File Offset: 0x0010575B
	private void GPKHKLEINDH()
	{
		if (this.BHHEHMIFMBD)
		{
			UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
		}
	}

	// Token: 0x06002639 RID: 9785 RVA: 0x0010755B File Offset: 0x0010575B
	private void OMMABEIOBBK()
	{
		if (this.BHHEHMIFMBD)
		{
			UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
		}
	}

	// Token: 0x0600263A RID: 9786 RVA: 0x0010A513 File Offset: 0x00108713
	public Material HMHOFHCEKCD()
	{
		if (this.BHHEHMIFMBD == null)
		{
			this.BHHEHMIFMBD = new Material(this.Shader);
			this.BHHEHMIFMBD.hideFlags = (HideFlags)93;
		}
		return this.BHHEHMIFMBD;
	}

	// Token: 0x0600263B RID: 9787 RVA: 0x0010A548 File Offset: 0x00108748
	private void ELADFDNPOOI()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			Debug.LogWarning("_HitPointTexture");
			base.enabled = true;
			return;
		}
		if (!SystemInfo.supportsRenderTextures)
		{
			Debug.LogWarning("SYS");
			base.enabled = true;
			return;
		}
		if (this.Shader != null && !this.Shader.isSupported)
		{
			Debug.LogWarning("isend");
			base.enabled = false;
			return;
		}
		this.DNCIPJOINAC(true);
	}

	// Token: 0x0600263C RID: 9788 RVA: 0x0010A5BB File Offset: 0x001087BB
	public Material BPIEFJGNJNI()
	{
		if (this.BHHEHMIFMBD == null)
		{
			this.BHHEHMIFMBD = new Material(this.Shader);
			this.BHHEHMIFMBD.hideFlags = (HideFlags)65;
		}
		return this.BHHEHMIFMBD;
	}

	// Token: 0x0600263D RID: 9789 RVA: 0x0010A5F0 File Offset: 0x001087F0
	private void EFCCCKGCOCB()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			Debug.LogWarning("Crouch 180");
			base.enabled = true;
			return;
		}
		if (!SystemInfo.supportsRenderTextures)
		{
			Debug.LogWarning("DestroyNow");
			base.enabled = true;
			return;
		}
		if (this.Shader != null && !this.Shader.isSupported)
		{
			Debug.LogWarning("SoccerKeeperJump");
			base.enabled = true;
			return;
		}
		this.LMOIIDAMKDB(false);
	}

	// Token: 0x0600263E RID: 9790 RVA: 0x0010A664 File Offset: 0x00108864
	private void JOEJPDFEKJE(bool PGEDLDMLBBE)
	{
		if (!PGEDLDMLBBE && this.GBEMNBGEHHH == (this.NoiseTexture != null) && this.AJNJEFMAFLI == this.CutoffEnabled && this.DNFACHHPHCC == this.LumContribution && this.LJFONAEFPOH == this.OcclusionColor && this.CBIPODLCGOH == this.Samples)
		{
			return;
		}
		Material material = this.FEJDCIEKEAG();
		string[] array = new string[5];
		array[0] = ((this.NoiseTexture != null) ? "" : "");
		array[0] = (this.CutoffEnabled ? "titul_" : "IdleStand");
		array[4] = ((this.LumContribution > 507f) ? "isJamp" : "1HandSwordChargeSwipe");
		array[4] = ((this.OcclusionColor == Color.black) ? "WizardNeoBlock" : "colorA");
		array[7] = ((this.Samples == SSAOPro.GPEHFPFDJAF.Low) ? " " : ((this.Samples == SSAOPro.GPEHFPFDJAF.VeryLow) ? " " : ((this.Samples == (SSAOPro.GPEHFPFDJAF)8) ? "_ScaleOffsetRes" : "RoundHouse")));
		material.shaderKeywords = array;
		this.GBEMNBGEHHH = (this.NoiseTexture != null);
		this.AJNJEFMAFLI = this.CutoffEnabled;
		this.DNFACHHPHCC = this.LumContribution;
		this.LJFONAEFPOH = this.OcclusionColor;
		this.CBIPODLCGOH = this.Samples;
	}

	// Token: 0x0600263F RID: 9791 RVA: 0x0010A7C4 File Offset: 0x001089C4
	private void EJOAPOGPBFM()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			Debug.LogWarning("");
			base.enabled = false;
			return;
		}
		if (!SystemInfo.supportsRenderTextures)
		{
			Debug.LogWarning(" ");
			base.enabled = false;
			return;
		}
		if (this.Shader != null && !this.Shader.isSupported)
		{
			Debug.LogWarning("str=");
			base.enabled = false;
			return;
		}
		this.NLMFLNHMBDP(false);
	}

	// Token: 0x06002640 RID: 9792 RVA: 0x0010A837 File Offset: 0x00108A37
	public Material LIPELDNNPGH()
	{
		if (this.BHHEHMIFMBD == null)
		{
			this.BHHEHMIFMBD = new Material(this.Shader);
			this.BHHEHMIFMBD.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BHHEHMIFMBD;
	}

	// Token: 0x06002641 RID: 9793 RVA: 0x0010A86C File Offset: 0x00108A6C
	private void LLEPPNBCBCM(bool PGEDLDMLBBE)
	{
		if (!PGEDLDMLBBE && this.GBEMNBGEHHH == (this.NoiseTexture != null) && this.AJNJEFMAFLI == this.CutoffEnabled && this.DNFACHHPHCC == this.LumContribution && this.LJFONAEFPOH == this.OcclusionColor && this.CBIPODLCGOH == this.Samples)
		{
			return;
		}
		Material material = this.BPIEFJGNJNI();
		string[] array = new string[5];
		array[1] = ((this.NoiseTexture != null) ? "(game main)" : "fshop_hd4");
		array[1] = (this.CutoffEnabled ? "RandomSound" : "Fly Right");
		array[1] = ((this.LumContribution > 1034f) ? "" : "Giant 3 Hit Combo");
		array[6] = ((this.OcclusionColor == Color.black) ? "1" : "FlyBackward");
		array[1] = ((this.Samples == SSAOPro.GPEHFPFDJAF.Low) ? "post_19" : ((this.Samples == SSAOPro.GPEHFPFDJAF.VeryLow) ? "wgt_gr" : ((this.Samples == (SSAOPro.GPEHFPFDJAF)4) ? "isBrag" : "This script need an Image with a readbale Texture2D to work.")));
		material.shaderKeywords = array;
		this.GBEMNBGEHHH = (this.NoiseTexture != null);
		this.AJNJEFMAFLI = this.CutoffEnabled;
		this.DNFACHHPHCC = this.LumContribution;
		this.LJFONAEFPOH = this.OcclusionColor;
		this.CBIPODLCGOH = this.Samples;
	}

	// Token: 0x06002642 RID: 9794 RVA: 0x0010A9CC File Offset: 0x00108BCC
	private void DNCIPJOINAC(bool PGEDLDMLBBE)
	{
		if (!PGEDLDMLBBE && this.GBEMNBGEHHH == (this.NoiseTexture != null) && this.AJNJEFMAFLI == this.CutoffEnabled && this.DNFACHHPHCC == this.LumContribution && this.LJFONAEFPOH == this.OcclusionColor && this.CBIPODLCGOH == this.Samples)
		{
			return;
		}
		Material material = this.CCEEHALMHCJ();
		string[] array = new string[6];
		array[0] = ((this.NoiseTexture != null) ? " " : "_MiddleGrey");
		array[0] = (this.CutoffEnabled ? "_FogDensity" : "Wizard2HandThrow");
		array[2] = ((this.LumContribution > 67f) ? "fider_Medium_" : " for ");
		array[8] = ((this.OcclusionColor == Color.black) ? "OfficeSittingEyesRub" : "to channel = ");
		array[4] = ((this.Samples == SSAOPro.GPEHFPFDJAF.VeryLow) ? "OneHandSwordSwing" : ((this.Samples == SSAOPro.GPEHFPFDJAF.VeryLow) ? "gi_uinf_3i" : ((this.Samples == (SSAOPro.GPEHFPFDJAF)6) ? "_LightColor" : "")));
		material.shaderKeywords = array;
		this.GBEMNBGEHHH = (this.NoiseTexture != null);
		this.AJNJEFMAFLI = this.CutoffEnabled;
		this.DNFACHHPHCC = this.LumContribution;
		this.LJFONAEFPOH = this.OcclusionColor;
		this.CBIPODLCGOH = this.Samples;
	}

	// Token: 0x06002643 RID: 9795 RVA: 0x0010AB2C File Offset: 0x00108D2C
	private void AHMKJAIPKMF(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (this.Shader == null)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.INMELBNDFAJ(true);
		if (this.NoiseTexture != null)
		{
			this.LIPELDNNPGH().SetTexture("", this.NoiseTexture);
		}
		this.KJADIPGFIFB().SetMatrix("costwpn=", this.MPCEHPBGHII.projectionMatrix.inverse);
		this.HLEBIDENKCJ().SetVector("qd_tasktime", new Vector4((this.NoiseTexture == null) ? 746f : ((float)this.NoiseTexture.width), this.Radius, this.Intensity, this.Distance));
		this.FEJDCIEKEAG().SetVector("ScatterIntensityVolumeSky", new Vector4(this.Bias, this.LumContribution, this.CutoffDistance, this.CutoffFalloff));
		this.IJDEDAFJLHD().SetColor("★{0}", this.OcclusionColor);
		if (this.Blur != SSAOPro.GGFPOCFCJFG.None)
		{
			int pass = (this.Blur == (SSAOPro.GGFPOCFCJFG)4) ? 0 : 1;
			int num = this.BlurDownsampling ? this.Downsampling : 0;
			RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / num, JONJODLFAEN.height / num, 1);
			RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width / this.Downsampling, JONJODLFAEN.height / this.Downsampling, 1);
			Graphics.Blit(JONJODLFAEN, temporary, this.LIPELDNNPGH(), 1);
			this.MJIACGHHKFP().SetVector(" ", new Vector2(1501f / (float)JONJODLFAEN.width, 268f));
			Graphics.Blit(temporary, temporary2, this.ODJFBBHCOPK(), pass);
			this.EEOIDGFFEGA.SetVector("_info", new Vector2(1602f, 1148f / (float)JONJODLFAEN.height));
			Graphics.Blit(temporary2, this.DebugAO ? OKIIDHIJBEA : temporary, this.BPIEFJGNJNI(), pass);
			if (!this.DebugAO)
			{
				this.CCEEHALMHCJ().SetTexture("OnTriggerEnter", temporary);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.CCEEHALMHCJ(), 1);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(temporary2);
			return;
		}
		RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / this.Downsampling, JONJODLFAEN.height / this.Downsampling, 0);
		if (this.DebugAO)
		{
			Graphics.Blit(JONJODLFAEN, temporary3, this.EEOIDGFFEGA, 1);
			Graphics.Blit(temporary3, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(temporary3);
			return;
		}
		Graphics.Blit(JONJODLFAEN, temporary3, this.CCEEHALMHCJ(), 0);
		this.OPOHKFIBLKD().SetTexture("IdleStun", temporary3);
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.ODJFBBHCOPK(), 7);
		RenderTexture.ReleaseTemporary(temporary3);
	}

	// Token: 0x06002644 RID: 9796 RVA: 0x0010ADCC File Offset: 0x00108FCC
	private void GNDNAAHKDIM(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (this.Shader == null)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.NLMFLNHMBDP(false);
		if (this.NoiseTexture != null)
		{
			this.KJADIPGFIFB().SetTexture(" ", this.NoiseTexture);
		}
		this.MICJKCGCGMM().SetMatrix("***** Export OK", this.MPCEHPBGHII.projectionMatrix.inverse);
		this.FEJDCIEKEAG().SetVector("KatanaReadyLow", new Vector4((this.NoiseTexture == null) ? 240f : ((float)this.NoiseTexture.width), this.Radius, this.Intensity, this.Distance));
		this.IJDEDAFJLHD().SetVector("The 'color' command requires a color parameter of RRGGBBAA:\n", new Vector4(this.Bias, this.LumContribution, this.CutoffDistance, this.CutoffFalloff));
		this.CCEEHALMHCJ().SetColor("UIChat_channel", this.OcclusionColor);
		if (this.Blur != SSAOPro.GGFPOCFCJFG.None)
		{
			int pass = (this.Blur == (SSAOPro.GGFPOCFCJFG)3) ? 5 : 0;
			int num = this.BlurDownsampling ? this.Downsampling : 1;
			RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / num, JONJODLFAEN.height / num, 1);
			RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width / this.Downsampling, JONJODLFAEN.height / this.Downsampling, 1);
			Graphics.Blit(JONJODLFAEN, temporary, this.LKNPLIGGIAP(), 1);
			this.BJPHIFABDFF().SetVector("wpn_add/base", new Vector2(859f / (float)JONJODLFAEN.width, 881f));
			Graphics.Blit(temporary, temporary2, this.ODJFBBHCOPK(), pass);
			this.KJADIPGFIFB().SetVector("1", new Vector2(961f, 1604f / (float)JONJODLFAEN.height));
			Graphics.Blit(temporary2, this.DebugAO ? OKIIDHIJBEA : temporary, this.OJMOGMHMNHF(), pass);
			if (!this.DebugAO)
			{
				this.LKNPLIGGIAP().SetTexture("#b0ffa0", temporary);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EEOIDGFFEGA, 3);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(temporary2);
			return;
		}
		RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / this.Downsampling, JONJODLFAEN.height / this.Downsampling, 0);
		if (this.DebugAO)
		{
			Graphics.Blit(JONJODLFAEN, temporary3, this.LIPELDNNPGH(), 1);
			Graphics.Blit(temporary3, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(temporary3);
			return;
		}
		Graphics.Blit(JONJODLFAEN, temporary3, this.JDFOPIGJADF(), 0);
		this.HLEBIDENKCJ().SetTexture("chnam3", temporary3);
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.OJMOGMHMNHF(), 3);
		RenderTexture.ReleaseTemporary(temporary3);
	}

	// Token: 0x06002645 RID: 9797 RVA: 0x0010B06C File Offset: 0x0010926C
	private void JHAKJAMBNAH()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			Debug.LogWarning("Tenkoku DynamicSky");
			base.enabled = true;
			return;
		}
		if (!SystemInfo.supportsRenderTextures)
		{
			Debug.LogWarning("knopje.wav");
			base.enabled = false;
			return;
		}
		if (this.Shader != null && !this.Shader.isSupported)
		{
			Debug.LogWarning("cht_msg37");
			base.enabled = true;
			return;
		}
		this.IMDKJHFEMEL(false);
	}

	// Token: 0x06002646 RID: 9798 RVA: 0x0010755B File Offset: 0x0010575B
	private void GBANNFDMGDD()
	{
		if (this.BHHEHMIFMBD)
		{
			UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
		}
	}

	// Token: 0x06002647 RID: 9799 RVA: 0x00108B33 File Offset: 0x00106D33
	private void JIOKDOGNKMI()
	{
		this.MPCEHPBGHII = base.GetComponent<Camera>();
		this.MPCEHPBGHII.depthTextureMode |= DepthTextureMode.Depth;
		this.MPCEHPBGHII.depthTextureMode |= (DepthTextureMode.Depth | DepthTextureMode.DepthNormals);
	}

	// Token: 0x06002648 RID: 9800 RVA: 0x0010B0E0 File Offset: 0x001092E0
	private void NLMFLNHMBDP(bool PGEDLDMLBBE)
	{
		if (!PGEDLDMLBBE && this.GBEMNBGEHHH == (this.NoiseTexture != null) && this.AJNJEFMAFLI == this.CutoffEnabled && this.DNFACHHPHCC == this.LumContribution && this.LJFONAEFPOH == this.OcclusionColor && this.CBIPODLCGOH == this.Samples)
		{
			return;
		}
		Material material = this.IHOFOIGKKFM();
		string[] array = new string[8];
		array[1] = ((this.NoiseTexture != null) ? "readActorData" : "Cloth_01.wav");
		array[1] = (this.CutoffEnabled ? "" : "Arm Flex 2");
		array[5] = ((this.LumContribution > 1647f) ? "" : "_CoCTex");
		array[1] = ((this.OcclusionColor == Color.black) ? "_UserLutTex" : "calf");
		array[0] = ((this.Samples == SSAOPro.GPEHFPFDJAF.Low) ? "Idle 90 Deg Turns" : ((this.Samples == (SSAOPro.GPEHFPFDJAF)4) ? "<color='#202020'>" : ((this.Samples == SSAOPro.GPEHFPFDJAF.Medium) ? "The image effect " : "ChannelCastOmni")));
		material.shaderKeywords = array;
		this.GBEMNBGEHHH = (this.NoiseTexture != null);
		this.AJNJEFMAFLI = this.CutoffEnabled;
		this.DNFACHHPHCC = this.LumContribution;
		this.LJFONAEFPOH = this.OcclusionColor;
		this.CBIPODLCGOH = this.Samples;
	}

	// Token: 0x06002649 RID: 9801 RVA: 0x0010B240 File Offset: 0x00109440
	private void JDOIMEJHIAL(bool PGEDLDMLBBE)
	{
		if (!PGEDLDMLBBE && this.GBEMNBGEHHH == (this.NoiseTexture != null) && this.AJNJEFMAFLI == this.CutoffEnabled && this.DNFACHHPHCC == this.LumContribution && this.LJFONAEFPOH == this.OcclusionColor && this.CBIPODLCGOH == this.Samples)
		{
			return;
		}
		Material material = this.KJADIPGFIFB();
		string[] array = new string[4];
		array[0] = ((this.NoiseTexture != null) ? "Bone 1 of a BipedReferences limb is null." : "FULLNAME");
		array[0] = (this.CutoffEnabled ? "Post Process Scatter Shader Missing..." : "#606000");
		array[3] = ((this.LumContribution > 656f) ? "CrawlIdle" : "123");
		array[8] = ((this.OcclusionColor == Color.black) ? "inv_nodur" : "Pointing");
		array[3] = ((this.Samples == SSAOPro.GPEHFPFDJAF.VeryLow) ? "[Y]" : ((this.Samples == (SSAOPro.GPEHFPFDJAF)6) ? "<color='#000000'>--------------------------------------------------------</color>" : ((this.Samples == (SSAOPro.GPEHFPFDJAF)7) ? "Space reference not set." : "ElvisLegsLoop")));
		material.shaderKeywords = array;
		this.GBEMNBGEHHH = (this.NoiseTexture != null);
		this.AJNJEFMAFLI = this.CutoffEnabled;
		this.DNFACHHPHCC = this.LumContribution;
		this.LJFONAEFPOH = this.OcclusionColor;
		this.CBIPODLCGOH = this.Samples;
	}

	// Token: 0x0600264A RID: 9802 RVA: 0x0010755B File Offset: 0x0010575B
	private void DNFMEMNJADK()
	{
		if (this.BHHEHMIFMBD)
		{
			UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
		}
	}

	// Token: 0x0600264B RID: 9803 RVA: 0x0010B39E File Offset: 0x0010959E
	public Material OPOHKFIBLKD()
	{
		if (this.BHHEHMIFMBD == null)
		{
			this.BHHEHMIFMBD = new Material(this.Shader);
			this.BHHEHMIFMBD.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BHHEHMIFMBD;
	}

	// Token: 0x0600264D RID: 9805 RVA: 0x0010755B File Offset: 0x0010575B
	private void GFDKADNHNBF()
	{
		if (this.BHHEHMIFMBD)
		{
			UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
		}
	}

	// Token: 0x0600264E RID: 9806 RVA: 0x0010755B File Offset: 0x0010575B
	private void DDPDBLBONEA()
	{
		if (this.BHHEHMIFMBD)
		{
			UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
		}
	}

	// Token: 0x0600264F RID: 9807 RVA: 0x0010B460 File Offset: 0x00109660
	private void GOJAEFGPNNI(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (this.Shader == null)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.KIGKPIEPKPA(true);
		if (this.NoiseTexture != null)
		{
			this.DDPOBLELCBI().SetTexture("**********  dropPrikormEvnt", this.NoiseTexture);
		}
		this.LIPELDNNPGH().SetMatrix("inv_impr", this.MPCEHPBGHII.projectionMatrix.inverse);
		this.BJPHIFABDFF().SetVector("Left arm 'Wrist To Palm Axis' needs to be set in VRIK. Please select the hand bone, set it to the axis that points from the wrist towards the palm. If the arrow points away from the palm, axis must be negative.", new Vector4((this.NoiseTexture == null) ? 1509f : ((float)this.NoiseTexture.width), this.Radius, this.Intensity, this.Distance));
		this.DDPOBLELCBI().SetVector("RunBackRight", new Vector4(this.Bias, this.LumContribution, this.CutoffDistance, this.CutoffFalloff));
		this.FEJDCIEKEAG().SetColor("demoVector3", this.OcclusionColor);
		if (this.Blur != SSAOPro.GGFPOCFCJFG.None)
		{
			int pass = (this.Blur == (SSAOPro.GGFPOCFCJFG)3) ? 3 : 0;
			int num = this.BlurDownsampling ? this.Downsampling : 1;
			RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / num, JONJODLFAEN.height / num, 0);
			RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width / this.Downsampling, JONJODLFAEN.height / this.Downsampling, 0);
			Graphics.Blit(JONJODLFAEN, temporary, this.DDPOBLELCBI(), 0);
			this.BHAGEJIOHFB().SetVector("Fish is init!", new Vector2(1394f / (float)JONJODLFAEN.width, 1266f));
			Graphics.Blit(temporary, temporary2, this.DDPOBLELCBI(), pass);
			this.BJPHIFABDFF().SetVector("", new Vector2(750f, 410f / (float)JONJODLFAEN.height));
			Graphics.Blit(temporary2, this.DebugAO ? OKIIDHIJBEA : temporary, this.BHAGEJIOHFB(), pass);
			if (!this.DebugAO)
			{
				this.CCEEHALMHCJ().SetTexture("ZombieIdle", temporary);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.CCEEHALMHCJ(), 6);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(temporary2);
			return;
		}
		RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / this.Downsampling, JONJODLFAEN.height / this.Downsampling, 1);
		if (this.DebugAO)
		{
			Graphics.Blit(JONJODLFAEN, temporary3, this.IHOFOIGKKFM(), 0);
			Graphics.Blit(temporary3, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(temporary3);
			return;
		}
		Graphics.Blit(JONJODLFAEN, temporary3, this.LIPELDNNPGH(), 0);
		this.OPOHKFIBLKD().SetTexture("The given 2D texture ", temporary3);
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KJADIPGFIFB(), 0);
		RenderTexture.ReleaseTemporary(temporary3);
	}

	// Token: 0x06002650 RID: 9808 RVA: 0x0010B700 File Offset: 0x00109900
	private void HEAKELNLFOG(bool PGEDLDMLBBE)
	{
		if (!PGEDLDMLBBE && this.GBEMNBGEHHH == (this.NoiseTexture != null) && this.AJNJEFMAFLI == this.CutoffEnabled && this.DNFACHHPHCC == this.LumContribution && this.LJFONAEFPOH == this.OcclusionColor && this.CBIPODLCGOH == this.Samples)
		{
			return;
		}
		Material material = this.IJDEDAFJLHD();
		string[] array = new string[4];
		array[0] = ((this.NoiseTexture != null) ? "Run Back Right" : "");
		array[1] = (this.CutoffEnabled ? "StaffHeal" : "");
		array[6] = ((this.LumContribution > 1360f) ? "inv_impr" : "http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		array[8] = ((this.OcclusionColor == Color.black) ? "bag" : "wgt_gr");
		array[7] = ((this.Samples == SSAOPro.GPEHFPFDJAF.VeryLow) ? "Low adminlevel!" : ((this.Samples == (SSAOPro.GPEHFPFDJAF)5) ? "short:" : ((this.Samples == SSAOPro.GPEHFPFDJAF.High) ? "FlyUp" : "u_isSave")));
		material.shaderKeywords = array;
		this.GBEMNBGEHHH = (this.NoiseTexture != null);
		this.AJNJEFMAFLI = this.CutoffEnabled;
		this.DNFACHHPHCC = this.LumContribution;
		this.LJFONAEFPOH = this.OcclusionColor;
		this.CBIPODLCGOH = this.Samples;
	}

	// Token: 0x06002651 RID: 9809 RVA: 0x0010B85E File Offset: 0x00109A5E
	public Material JDFOPIGJADF()
	{
		if (this.BHHEHMIFMBD == null)
		{
			this.BHHEHMIFMBD = new Material(this.Shader);
			this.BHHEHMIFMBD.hideFlags = (HideFlags)(-90);
		}
		return this.BHHEHMIFMBD;
	}

	// Token: 0x06002652 RID: 9810 RVA: 0x00109E7B File Offset: 0x0010807B
	public Material FEJDCIEKEAG()
	{
		if (this.BHHEHMIFMBD == null)
		{
			this.BHHEHMIFMBD = new Material(this.Shader);
			this.BHHEHMIFMBD.hideFlags = HideFlags.HideAndDontSave;
		}
		return this.BHHEHMIFMBD;
	}

	// Token: 0x06002653 RID: 9811 RVA: 0x0010755B File Offset: 0x0010575B
	private void OBMPEBPAOFJ()
	{
		if (this.BHHEHMIFMBD)
		{
			UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
		}
	}

	// Token: 0x06002654 RID: 9812 RVA: 0x0010B894 File Offset: 0x00109A94
	private void MGOBAHLJJNL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (this.Shader == null)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.LMOIIDAMKDB(false);
		if (this.NoiseTexture != null)
		{
			this.LIPELDNNPGH().SetTexture("_Gain", this.NoiseTexture);
		}
		this.DDPOBLELCBI().SetMatrix("auk_pbuykey", this.MPCEHPBGHII.projectionMatrix.inverse);
		this.ODJFBBHCOPK().SetVector("RGBA(", new Vector4((this.NoiseTexture == null) ? 1012f : ((float)this.NoiseTexture.width), this.Radius, this.Intensity, this.Distance));
		this.LIPELDNNPGH().SetVector(" ms", new Vector4(this.Bias, this.LumContribution, this.CutoffDistance, this.CutoffFalloff));
		this.FEJDCIEKEAG().SetColor("OfficeSittingBack", this.OcclusionColor);
		if (this.Blur != SSAOPro.GGFPOCFCJFG.None)
		{
			int pass = (this.Blur == SSAOPro.GGFPOCFCJFG.Bilateral) ? 6 : 0;
			int num = this.BlurDownsampling ? this.Downsampling : 0;
			RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / num, JONJODLFAEN.height / num, 0);
			RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width / this.Downsampling, JONJODLFAEN.height / this.Downsampling, 0);
			Graphics.Blit(JONJODLFAEN, temporary, this.MJIACGHHKFP(), 0);
			this.DDPOBLELCBI().SetVector("_BlurCoe", new Vector2(85f / (float)JONJODLFAEN.width, 901f));
			Graphics.Blit(temporary, temporary2, this.BPIEFJGNJNI(), pass);
			this.LKNPLIGGIAP().SetVector("_Parameter", new Vector2(1122f, 1569f / (float)JONJODLFAEN.height));
			Graphics.Blit(temporary2, this.DebugAO ? OKIIDHIJBEA : temporary, this.BPIEFJGNJNI(), pass);
			if (!this.DebugAO)
			{
				this.LIPELDNNPGH().SetTexture("WandStand", temporary);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.ODJFBBHCOPK(), 3);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(temporary2);
			return;
		}
		RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / this.Downsampling, JONJODLFAEN.height / this.Downsampling, 1);
		if (this.DebugAO)
		{
			Graphics.Blit(JONJODLFAEN, temporary3, this.IHOFOIGKKFM(), 0);
			Graphics.Blit(temporary3, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(temporary3);
			return;
		}
		Graphics.Blit(JONJODLFAEN, temporary3, this.HLEBIDENKCJ(), 1);
		this.LKNPLIGGIAP().SetTexture("droplinemsg2", temporary3);
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.OPOHKFIBLKD(), 1);
		RenderTexture.ReleaseTemporary(temporary3);
	}

	// Token: 0x06002655 RID: 9813 RVA: 0x0010BB33 File Offset: 0x00109D33
	private void KOLNOOGFFNP()
	{
		this.MPCEHPBGHII = base.GetComponent<Camera>();
		this.MPCEHPBGHII.depthTextureMode |= DepthTextureMode.None;
		this.MPCEHPBGHII.depthTextureMode |= (DepthTextureMode.Depth | DepthTextureMode.DepthNormals | DepthTextureMode.MotionVectors);
	}

	// Token: 0x06002656 RID: 9814 RVA: 0x00108B33 File Offset: 0x00106D33
	private void AKPLEHHPKGC()
	{
		this.MPCEHPBGHII = base.GetComponent<Camera>();
		this.MPCEHPBGHII.depthTextureMode |= DepthTextureMode.Depth;
		this.MPCEHPBGHII.depthTextureMode |= (DepthTextureMode.Depth | DepthTextureMode.DepthNormals);
	}

	// Token: 0x06002657 RID: 9815 RVA: 0x0010BB68 File Offset: 0x00109D68
	private void BIJMHMEDHDC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (this.Shader == null)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.FHMFEHDKIGK(false);
		if (this.NoiseTexture != null)
		{
			this.AHLHNIFNGJM().SetTexture("WeaponFire", this.NoiseTexture);
		}
		this.OPOHKFIBLKD().SetMatrix("OfficeSittingReading", this.MPCEHPBGHII.projectionMatrix.inverse);
		this.DDPOBLELCBI().SetVector("LINEAR", new Vector4((this.NoiseTexture == null) ? 186f : ((float)this.NoiseTexture.width), this.Radius, this.Intensity, this.Distance));
		this.MJIACGHHKFP().SetVector("_Balance", new Vector4(this.Bias, this.LumContribution, this.CutoffDistance, this.CutoffFalloff));
		this.AHLHNIFNGJM().SetColor("_SpecCubeIBL", this.OcclusionColor);
		if (this.Blur != SSAOPro.GGFPOCFCJFG.None)
		{
			int pass = (this.Blur == (SSAOPro.GGFPOCFCJFG)6) ? 2 : 0;
			int num = this.BlurDownsampling ? this.Downsampling : 0;
			RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / num, JONJODLFAEN.height / num, 1);
			RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width / this.Downsampling, JONJODLFAEN.height / this.Downsampling, 1);
			Graphics.Blit(JONJODLFAEN, temporary, this.EEOIDGFFEGA, 0);
			this.LIPELDNNPGH().SetVector("", new Vector2(560f / (float)JONJODLFAEN.width, 1063f));
			Graphics.Blit(temporary, temporary2, this.OJMOGMHMNHF(), pass);
			this.BHAGEJIOHFB().SetVector("infmsg_exp", new Vector2(848f, 1672f / (float)JONJODLFAEN.height));
			Graphics.Blit(temporary2, this.DebugAO ? OKIIDHIJBEA : temporary, this.OPOHKFIBLKD(), pass);
			if (!this.DebugAO)
			{
				this.BOPJMMKEGAB().SetTexture("Отмена", temporary);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.IJDEDAFJLHD(), 7);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(temporary2);
			return;
		}
		RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / this.Downsampling, JONJODLFAEN.height / this.Downsampling, 0);
		if (this.DebugAO)
		{
			Graphics.Blit(JONJODLFAEN, temporary3, this.BHAGEJIOHFB(), 0);
			Graphics.Blit(temporary3, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(temporary3);
			return;
		}
		Graphics.Blit(JONJODLFAEN, temporary3, this.LIPELDNNPGH(), 1);
		this.BHAGEJIOHFB().SetTexture("Button Left Hand", temporary3);
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.AHLHNIFNGJM(), 4);
		RenderTexture.ReleaseTemporary(temporary3);
	}

	// Token: 0x06002658 RID: 9816 RVA: 0x00109216 File Offset: 0x00107416
	private void ACCKEFCOBGN()
	{
		this.MPCEHPBGHII = base.GetComponent<Camera>();
		this.MPCEHPBGHII.depthTextureMode |= DepthTextureMode.None;
		this.MPCEHPBGHII.depthTextureMode |= (DepthTextureMode)8;
	}

	// Token: 0x06002659 RID: 9817 RVA: 0x0010BE08 File Offset: 0x0010A008
	private void NJLOPOBJHAC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (this.Shader == null)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.FHMFEHDKIGK(false);
		if (this.NoiseTexture != null)
		{
			this.CCEEHALMHCJ().SetTexture("invn_rec29", this.NoiseTexture);
		}
		this.KJADIPGFIFB().SetMatrix("Attempting to remove a RenderTexture that was not allocated: {0}", this.MPCEHPBGHII.projectionMatrix.inverse);
		this.HLEBIDENKCJ().SetVector("OfficeSittingHandRestFingerTap", new Vector4((this.NoiseTexture == null) ? 878f : ((float)this.NoiseTexture.width), this.Radius, this.Intensity, this.Distance));
		this.BPIEFJGNJNI().SetVector("The 'font attribute' command requires a font parameter of U (underline on), -U (underline off), S (strikethrough on) or -S (strikethrough off).", new Vector4(this.Bias, this.LumContribution, this.CutoffDistance, this.CutoffFalloff));
		this.BPIEFJGNJNI().SetColor("MotorbikeHeartAttack", this.OcclusionColor);
		if (this.Blur != SSAOPro.GGFPOCFCJFG.None)
		{
			int pass = (this.Blur == (SSAOPro.GGFPOCFCJFG)8) ? 8 : 0;
			int num = this.BlurDownsampling ? this.Downsampling : 0;
			RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / num, JONJODLFAEN.height / num, 1);
			RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width / this.Downsampling, JONJODLFAEN.height / this.Downsampling, 1);
			Graphics.Blit(JONJODLFAEN, temporary, this.JDFOPIGJADF(), 1);
			this.CCEEHALMHCJ().SetVector("AntaresController", new Vector2(1868f / (float)JONJODLFAEN.width, 29f));
			Graphics.Blit(temporary, temporary2, this.MICJKCGCGMM(), pass);
			this.ODJFBBHCOPK().SetVector("", new Vector2(641f, 653f / (float)JONJODLFAEN.height));
			Graphics.Blit(temporary2, this.DebugAO ? OKIIDHIJBEA : temporary, this.HMHOFHCEKCD(), pass);
			if (!this.DebugAO)
			{
				this.IJDEDAFJLHD().SetTexture("auc_toauk", temporary);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.AHLHNIFNGJM(), 0);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(temporary2);
			return;
		}
		RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / this.Downsampling, JONJODLFAEN.height / this.Downsampling, 0);
		if (this.DebugAO)
		{
			Graphics.Blit(JONJODLFAEN, temporary3, this.KJADIPGFIFB(), 0);
			Graphics.Blit(temporary3, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(temporary3);
			return;
		}
		Graphics.Blit(JONJODLFAEN, temporary3, this.KJADIPGFIFB(), 0);
		this.BHAGEJIOHFB().SetTexture("crft_cnt", temporary3);
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.ODJFBBHCOPK(), 8);
		RenderTexture.ReleaseTemporary(temporary3);
	}

	// Token: 0x0600265A RID: 9818 RVA: 0x0010755B File Offset: 0x0010575B
	private void OnDestroy()
	{
		if (this.BHHEHMIFMBD)
		{
			UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
		}
	}

	// Token: 0x0600265B RID: 9819 RVA: 0x0010C0A8 File Offset: 0x0010A2A8
	private void EFPADLBDKCC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (this.Shader == null)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.LMOIIDAMKDB(true);
		if (this.NoiseTexture != null)
		{
			this.HMHOFHCEKCD().SetTexture("{0}", this.NoiseTexture);
		}
		this.CCEEHALMHCJ().SetMatrix("IdleFly", this.MPCEHPBGHII.projectionMatrix.inverse);
		this.MICJKCGCGMM().SetVector("BaseLogic", new Vector4((this.NoiseTexture == null) ? 987f : ((float)this.NoiseTexture.width), this.Radius, this.Intensity, this.Distance));
		this.CCEEHALMHCJ().SetVector("OfficeSittingEyesRub", new Vector4(this.Bias, this.LumContribution, this.CutoffDistance, this.CutoffFalloff));
		this.DDPOBLELCBI().SetColor("En", this.OcclusionColor);
		if (this.Blur != SSAOPro.GGFPOCFCJFG.None)
		{
			int pass = (this.Blur == (SSAOPro.GGFPOCFCJFG)4) ? 5 : 1;
			int num = this.BlurDownsampling ? this.Downsampling : 1;
			RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / num, JONJODLFAEN.height / num, 1);
			RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width / this.Downsampling, JONJODLFAEN.height / this.Downsampling, 1);
			Graphics.Blit(JONJODLFAEN, temporary, this.BOPJMMKEGAB(), 1);
			this.AHLHNIFNGJM().SetVector(">", new Vector2(1566f / (float)JONJODLFAEN.width, 1569f));
			Graphics.Blit(temporary, temporary2, this.DDPOBLELCBI(), pass);
			this.OPOHKFIBLKD().SetVector("_BokehParams", new Vector2(1730f, 35f / (float)JONJODLFAEN.height));
			Graphics.Blit(temporary2, this.DebugAO ? OKIIDHIJBEA : temporary, this.IHOFOIGKKFM(), pass);
			if (!this.DebugAO)
			{
				this.IHOFOIGKKFM().SetTexture("bool:", temporary);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.BOPJMMKEGAB(), 1);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(temporary2);
			return;
		}
		RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / this.Downsampling, JONJODLFAEN.height / this.Downsampling, 0);
		if (this.DebugAO)
		{
			Graphics.Blit(JONJODLFAEN, temporary3, this.HMHOFHCEKCD(), 0);
			Graphics.Blit(temporary3, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(temporary3);
			return;
		}
		Graphics.Blit(JONJODLFAEN, temporary3, this.OPOHKFIBLKD(), 1);
		this.AHLHNIFNGJM().SetTexture("SUNSHINE_FILTER_PCF_4x4", temporary3);
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.BHAGEJIOHFB(), 6);
		RenderTexture.ReleaseTemporary(temporary3);
	}

	// Token: 0x0600265C RID: 9820 RVA: 0x0010C348 File Offset: 0x0010A548
	private void IMDKJHFEMEL(bool PGEDLDMLBBE)
	{
		if (!PGEDLDMLBBE && this.GBEMNBGEHHH == (this.NoiseTexture != null) && this.AJNJEFMAFLI == this.CutoffEnabled && this.DNFACHHPHCC == this.LumContribution && this.LJFONAEFPOH == this.OcclusionColor && this.CBIPODLCGOH == this.Samples)
		{
			return;
		}
		Material material = this.LIPELDNNPGH();
		string[] array = new string[4];
		array[0] = ((this.NoiseTexture != null) ? "error.wav" : "_Axis");
		array[1] = (this.CutoffEnabled ? "tech" : "wpn_eat1");
		array[0] = ((this.LumContribution > 1300f) ? "MotorbikeSeatStand" : "ProneIdle");
		array[4] = ((this.OcclusionColor == Color.black) ? "Pointing" : "http://af-2.ru/?q=store");
		array[0] = ((this.Samples == SSAOPro.GPEHFPFDJAF.VeryLow) ? "{{{{{0},{1}}}}}" : ((this.Samples == (SSAOPro.GPEHFPFDJAF)8) ? "WizardOverhead" : ((this.Samples == SSAOPro.GPEHFPFDJAF.VeryLow) ? "_FogAlpha" : "exitmsg_3")));
		material.shaderKeywords = array;
		this.GBEMNBGEHHH = (this.NoiseTexture != null);
		this.AJNJEFMAFLI = this.CutoffEnabled;
		this.DNFACHHPHCC = this.LumContribution;
		this.LJFONAEFPOH = this.OcclusionColor;
		this.CBIPODLCGOH = this.Samples;
	}

	// Token: 0x0600265D RID: 9821 RVA: 0x0010755B File Offset: 0x0010575B
	private void MIEEAACIPJH()
	{
		if (this.BHHEHMIFMBD)
		{
			UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
		}
	}

	// Token: 0x0600265E RID: 9822 RVA: 0x00108B33 File Offset: 0x00106D33
	private void EKOENFCHNKL()
	{
		this.MPCEHPBGHII = base.GetComponent<Camera>();
		this.MPCEHPBGHII.depthTextureMode |= DepthTextureMode.Depth;
		this.MPCEHPBGHII.depthTextureMode |= (DepthTextureMode.Depth | DepthTextureMode.DepthNormals);
	}

	// Token: 0x0600265F RID: 9823 RVA: 0x0010C4A6 File Offset: 0x0010A6A6
	private void CCMOKEDKMNJ()
	{
		this.MPCEHPBGHII = base.GetComponent<Camera>();
		this.MPCEHPBGHII.depthTextureMode |= DepthTextureMode.None;
		this.MPCEHPBGHII.depthTextureMode |= DepthTextureMode.DepthNormals;
	}

	// Token: 0x06002660 RID: 9824 RVA: 0x0010755B File Offset: 0x0010575B
	private void MECEHFDKHPF()
	{
		if (this.BHHEHMIFMBD)
		{
			UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
		}
	}

	// Token: 0x06002661 RID: 9825 RVA: 0x0010C4DC File Offset: 0x0010A6DC
	private void GDLPGNLPCMJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (this.Shader == null)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.FHMFEHDKIGK(true);
		if (this.NoiseTexture != null)
		{
			this.BHAGEJIOHFB().SetTexture("Keeper Strafe Left", this.NoiseTexture);
		}
		this.OPOHKFIBLKD().SetMatrix("FOG_EXP2", this.MPCEHPBGHII.projectionMatrix.inverse);
		this.HMHOFHCEKCD().SetVector("wpn_eat8", new Vector4((this.NoiseTexture == null) ? 284f : ((float)this.NoiseTexture.width), this.Radius, this.Intensity, this.Distance));
		this.OJMOGMHMNHF().SetVector("Quadruped", new Vector4(this.Bias, this.LumContribution, this.CutoffDistance, this.CutoffFalloff));
		this.BHAGEJIOHFB().SetColor("_OcclusionTexture1", this.OcclusionColor);
		if (this.Blur != SSAOPro.GGFPOCFCJFG.None)
		{
			int pass = (this.Blur == (SSAOPro.GGFPOCFCJFG)4) ? 8 : 1;
			int num = this.BlurDownsampling ? this.Downsampling : 1;
			RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / num, JONJODLFAEN.height / num, 0);
			RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width / this.Downsampling, JONJODLFAEN.height / this.Downsampling, 0);
			Graphics.Blit(JONJODLFAEN, temporary, this.IHOFOIGKKFM(), 0);
			this.BOPJMMKEGAB().SetVector("--", new Vector2(1070f / (float)JONJODLFAEN.width, 1016f));
			Graphics.Blit(temporary, temporary2, this.ODJFBBHCOPK(), pass);
			this.OPOHKFIBLKD().SetVector("openPodsak", new Vector2(6f, 925f / (float)JONJODLFAEN.height));
			Graphics.Blit(temporary2, this.DebugAO ? OKIIDHIJBEA : temporary, this.LIPELDNNPGH(), pass);
			if (!this.DebugAO)
			{
				this.FEJDCIEKEAG().SetTexture("\n", temporary);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.IHOFOIGKKFM(), 2);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(temporary2);
			return;
		}
		RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / this.Downsampling, JONJODLFAEN.height / this.Downsampling, 0);
		if (this.DebugAO)
		{
			Graphics.Blit(JONJODLFAEN, temporary3, this.OJMOGMHMNHF(), 0);
			Graphics.Blit(temporary3, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(temporary3);
			return;
		}
		Graphics.Blit(JONJODLFAEN, temporary3, this.KJADIPGFIFB(), 1);
		this.JDFOPIGJADF().SetTexture("collar", temporary3);
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.OPOHKFIBLKD(), 6);
		RenderTexture.ReleaseTemporary(temporary3);
	}

	// Token: 0x06002662 RID: 9826 RVA: 0x0010C77C File Offset: 0x0010A97C
	private void PKNBABMJLPB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (this.Shader == null)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.JDOIMEJHIAL(true);
		if (this.NoiseTexture != null)
		{
			this.HLEBIDENKCJ().SetTexture("#ffffff", this.NoiseTexture);
		}
		this.FEJDCIEKEAG().SetMatrix(" is null.", this.MPCEHPBGHII.projectionMatrix.inverse);
		this.CCEEHALMHCJ().SetVector("_Bloom_DirtTex", new Vector4((this.NoiseTexture == null) ? 1592f : ((float)this.NoiseTexture.width), this.Radius, this.Intensity, this.Distance));
		this.BPIEFJGNJNI().SetVector("OneHandSwordBackSwing", new Vector4(this.Bias, this.LumContribution, this.CutoffDistance, this.CutoffFalloff));
		this.MJIACGHHKFP().SetColor("<.*?>", this.OcclusionColor);
		if (this.Blur != SSAOPro.GGFPOCFCJFG.None)
		{
			int pass = (this.Blur == (SSAOPro.GGFPOCFCJFG)8) ? 0 : 1;
			int num = this.BlurDownsampling ? this.Downsampling : 0;
			RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / num, JONJODLFAEN.height / num, 1);
			RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width / this.Downsampling, JONJODLFAEN.height / this.Downsampling, 0);
			Graphics.Blit(JONJODLFAEN, temporary, this.BJPHIFABDFF(), 1);
			this.EEOIDGFFEGA.SetVector("ROPE dst=", new Vector2(1928f / (float)JONJODLFAEN.width, 679f));
			Graphics.Blit(temporary, temporary2, this.ODJFBBHCOPK(), pass);
			this.OPOHKFIBLKD().SetVector("Vertical", new Vector2(1700f, 965f / (float)JONJODLFAEN.height));
			Graphics.Blit(temporary2, this.DebugAO ? OKIIDHIJBEA : temporary, this.EEOIDGFFEGA, pass);
			if (!this.DebugAO)
			{
				this.FEJDCIEKEAG().SetTexture(" has been disabled as it's not supported on the current platform.", temporary);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LIPELDNNPGH(), 1);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(temporary2);
			return;
		}
		RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / this.Downsampling, JONJODLFAEN.height / this.Downsampling, 1);
		if (this.DebugAO)
		{
			Graphics.Blit(JONJODLFAEN, temporary3, this.BOPJMMKEGAB(), 1);
			Graphics.Blit(temporary3, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(temporary3);
			return;
		}
		Graphics.Blit(JONJODLFAEN, temporary3, this.ODJFBBHCOPK(), 0);
		this.MICJKCGCGMM().SetTexture("wpn_bait_typ_{0}", temporary3);
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.MICJKCGCGMM(), 1);
		RenderTexture.ReleaseTemporary(temporary3);
	}

	// Token: 0x06002663 RID: 9827 RVA: 0x00108757 File Offset: 0x00106957
	private void FALFMIAEIJC()
	{
		this.MPCEHPBGHII = base.GetComponent<Camera>();
		this.MPCEHPBGHII.depthTextureMode |= DepthTextureMode.Depth;
		this.MPCEHPBGHII.depthTextureMode |= DepthTextureMode.DepthNormals;
	}

	// Token: 0x06002664 RID: 9828 RVA: 0x0010CA1C File Offset: 0x0010AC1C
	private void IDLPAPLFPLJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (this.Shader == null)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.DFBGBPHFEGA(true);
		if (this.NoiseTexture != null)
		{
			this.DDPOBLELCBI().SetTexture("Bases/Base_1.unity3d", this.NoiseTexture);
		}
		this.BPIEFJGNJNI().SetMatrix("MotorbikeHandlebarSit", this.MPCEHPBGHII.projectionMatrix.inverse);
		this.BOPJMMKEGAB().SetVector("ProneLocomotion", new Vector4((this.NoiseTexture == null) ? 1908f : ((float)this.NoiseTexture.width), this.Radius, this.Intensity, this.Distance));
		this.OPOHKFIBLKD().SetVector("{0}\n{1}", new Vector4(this.Bias, this.LumContribution, this.CutoffDistance, this.CutoffFalloff));
		this.LKNPLIGGIAP().SetColor("_BlurPass", this.OcclusionColor);
		if (this.Blur != SSAOPro.GGFPOCFCJFG.None)
		{
			int pass = (this.Blur == SSAOPro.GGFPOCFCJFG.Gaussian) ? 8 : 0;
			int num = this.BlurDownsampling ? this.Downsampling : 1;
			RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / num, JONJODLFAEN.height / num, 1);
			RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width / this.Downsampling, JONJODLFAEN.height / this.Downsampling, 1);
			Graphics.Blit(JONJODLFAEN, temporary, this.CCEEHALMHCJ(), 1);
			this.BOPJMMKEGAB().SetVector("0 сек", new Vector2(1817f / (float)JONJODLFAEN.width, 1292f));
			Graphics.Blit(temporary, temporary2, this.OPOHKFIBLKD(), pass);
			this.IJDEDAFJLHD().SetVector(" гр ", new Vector2(1916f, 1113f / (float)JONJODLFAEN.height));
			Graphics.Blit(temporary2, this.DebugAO ? OKIIDHIJBEA : temporary, this.BPIEFJGNJNI(), pass);
			if (!this.DebugAO)
			{
				this.DDPOBLELCBI().SetTexture("http://www.root-motion.com/finalikdox/html/page11.html", temporary);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JDFOPIGJADF(), 3);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(temporary2);
			return;
		}
		RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / this.Downsampling, JONJODLFAEN.height / this.Downsampling, 0);
		if (this.DebugAO)
		{
			Graphics.Blit(JONJODLFAEN, temporary3, this.LKNPLIGGIAP(), 1);
			Graphics.Blit(temporary3, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(temporary3);
			return;
		}
		Graphics.Blit(JONJODLFAEN, temporary3, this.LIPELDNNPGH(), 1);
		this.AHLHNIFNGJM().SetTexture("Bend Constraint is referencing to a bone '", temporary3);
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.OJMOGMHMNHF(), 2);
		RenderTexture.ReleaseTemporary(temporary3);
	}

	// Token: 0x06002665 RID: 9829 RVA: 0x0010CCBB File Offset: 0x0010AEBB
	private void MOJBLBHKCCM()
	{
		this.MPCEHPBGHII = base.GetComponent<Camera>();
		this.MPCEHPBGHII.depthTextureMode |= DepthTextureMode.Depth;
		this.MPCEHPBGHII.depthTextureMode |= DepthTextureMode.MotionVectors;
	}

	// Token: 0x06002666 RID: 9830 RVA: 0x0010CCF0 File Offset: 0x0010AEF0
	private void DLNNOLELPBO(bool PGEDLDMLBBE)
	{
		if (!PGEDLDMLBBE && this.GBEMNBGEHHH == (this.NoiseTexture != null) && this.AJNJEFMAFLI == this.CutoffEnabled && this.DNFACHHPHCC == this.LumContribution && this.LJFONAEFPOH == this.OcclusionColor && this.CBIPODLCGOH == this.Samples)
		{
			return;
		}
		this.EEOIDGFFEGA.shaderKeywords = new string[]
		{
			(this.NoiseTexture != null) ? "NOISE_ON" : "NOISE_OFF",
			this.CutoffEnabled ? "DISTANCE_CUTOFF_ON" : "DISTANCE_CUTOFF_OFF",
			(this.LumContribution > 0.0001f) ? "LUM_CONTRIB_ON" : "LUM_CONTRIB_OFF",
			(this.OcclusionColor == Color.black) ? "CUSTOM_COLOR_OFF" : "CUSTOM_COLOR_ON",
			(this.Samples == SSAOPro.GPEHFPFDJAF.Low) ? "SAMPLES_LOW" : ((this.Samples == SSAOPro.GPEHFPFDJAF.Medium) ? "SAMPLES_MEDIUM" : ((this.Samples == SSAOPro.GPEHFPFDJAF.High) ? "SAMPLES_HIGH" : "SAMPLES_VERY_LOW"))
		};
		this.GBEMNBGEHHH = (this.NoiseTexture != null);
		this.AJNJEFMAFLI = this.CutoffEnabled;
		this.DNFACHHPHCC = this.LumContribution;
		this.LJFONAEFPOH = this.OcclusionColor;
		this.CBIPODLCGOH = this.Samples;
	}

	// Token: 0x06002667 RID: 9831 RVA: 0x0010CE4E File Offset: 0x0010B04E
	public Material ODJFBBHCOPK()
	{
		if (this.BHHEHMIFMBD == null)
		{
			this.BHHEHMIFMBD = new Material(this.Shader);
			this.BHHEHMIFMBD.hideFlags = (HideFlags)96;
		}
		return this.BHHEHMIFMBD;
	}

	// Token: 0x06002668 RID: 9832 RVA: 0x00108B67 File Offset: 0x00106D67
	public Material BJPHIFABDFF()
	{
		if (this.BHHEHMIFMBD == null)
		{
			this.BHHEHMIFMBD = new Material(this.Shader);
			this.BHHEHMIFMBD.hideFlags = (HideFlags)89;
		}
		return this.BHHEHMIFMBD;
	}

	// Token: 0x06002669 RID: 9833 RVA: 0x0010CE82 File Offset: 0x0010B082
	public Material BHAGEJIOHFB()
	{
		if (this.BHHEHMIFMBD == null)
		{
			this.BHHEHMIFMBD = new Material(this.Shader);
			this.BHHEHMIFMBD.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BHHEHMIFMBD;
	}

	// Token: 0x0600266A RID: 9834 RVA: 0x0010755B File Offset: 0x0010575B
	private void CHGHJOFGPGH()
	{
		if (this.BHHEHMIFMBD)
		{
			UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
		}
	}

	// Token: 0x0600266B RID: 9835 RVA: 0x0010CEB6 File Offset: 0x0010B0B6
	public Material KJADIPGFIFB()
	{
		if (this.BHHEHMIFMBD == null)
		{
			this.BHHEHMIFMBD = new Material(this.Shader);
			this.BHHEHMIFMBD.hideFlags = (HideFlags)117;
		}
		return this.BHHEHMIFMBD;
	}

	// Token: 0x0600266C RID: 9836 RVA: 0x0010CEEA File Offset: 0x0010B0EA
	private void APPOBIOMMPG()
	{
		this.MPCEHPBGHII = base.GetComponent<Camera>();
		this.MPCEHPBGHII.depthTextureMode |= DepthTextureMode.Depth;
		this.MPCEHPBGHII.depthTextureMode |= (DepthTextureMode.Depth | DepthTextureMode.MotionVectors);
	}

	// Token: 0x0600266D RID: 9837 RVA: 0x0010CF20 File Offset: 0x0010B120
	private void EODDHFNAMFH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (this.Shader == null)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.HEAKELNLFOG(true);
		if (this.NoiseTexture != null)
		{
			this.BOPJMMKEGAB().SetTexture("ComeHere", this.NoiseTexture);
		}
		this.HMHOFHCEKCD().SetMatrix("'", this.MPCEHPBGHII.projectionMatrix.inverse);
		this.HLEBIDENKCJ().SetVector("WeaponStrafeRunRight", new Vector4((this.NoiseTexture == null) ? 1979f : ((float)this.NoiseTexture.width), this.Radius, this.Intensity, this.Distance));
		this.MJIACGHHKFP().SetVector("<color='#405000'>", new Vector4(this.Bias, this.LumContribution, this.CutoffDistance, this.CutoffFalloff));
		this.LIPELDNNPGH().SetColor("Vertical", this.OcclusionColor);
		if (this.Blur != SSAOPro.GGFPOCFCJFG.None)
		{
			int pass = (this.Blur == (SSAOPro.GGFPOCFCJFG)4) ? 8 : 0;
			int num = this.BlurDownsampling ? this.Downsampling : 0;
			RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / num, JONJODLFAEN.height / num, 1);
			RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width / this.Downsampling, JONJODLFAEN.height / this.Downsampling, 0);
			Graphics.Blit(JONJODLFAEN, temporary, this.HMHOFHCEKCD(), 1);
			this.DDPOBLELCBI().SetVector("Ignore Raycast", new Vector2(489f / (float)JONJODLFAEN.width, 1828f));
			Graphics.Blit(temporary, temporary2, this.MJIACGHHKFP(), pass);
			this.CCEEHALMHCJ().SetVector("_OcclusionTexture", new Vector2(368f, 713f / (float)JONJODLFAEN.height));
			Graphics.Blit(temporary2, this.DebugAO ? OKIIDHIJBEA : temporary, this.DDPOBLELCBI(), pass);
			if (!this.DebugAO)
			{
				this.ODJFBBHCOPK().SetTexture("WallRunLeft", temporary);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.DDPOBLELCBI(), 2);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(temporary2);
			return;
		}
		RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / this.Downsampling, JONJODLFAEN.height / this.Downsampling, 1);
		if (this.DebugAO)
		{
			Graphics.Blit(JONJODLFAEN, temporary3, this.HMHOFHCEKCD(), 1);
			Graphics.Blit(temporary3, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(temporary3);
			return;
		}
		Graphics.Blit(JONJODLFAEN, temporary3, this.MJIACGHHKFP(), 0);
		this.BHAGEJIOHFB().SetTexture("TOD_kSun", temporary3);
		Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.ODJFBBHCOPK(), 6);
		RenderTexture.ReleaseTemporary(temporary3);
	}

	// Token: 0x0600266E RID: 9838 RVA: 0x0010D1BF File Offset: 0x0010B3BF
	public Material MJIACGHHKFP()
	{
		if (this.BHHEHMIFMBD == null)
		{
			this.BHHEHMIFMBD = new Material(this.Shader);
			this.BHHEHMIFMBD.hideFlags = (HideFlags)(-112);
		}
		return this.BHHEHMIFMBD;
	}

	// Token: 0x0600266F RID: 9839 RVA: 0x0010755B File Offset: 0x0010575B
	private void IEHOIMHFICG()
	{
		if (this.BHHEHMIFMBD)
		{
			UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
		}
	}

	// Token: 0x06002670 RID: 9840 RVA: 0x0010D1F4 File Offset: 0x0010B3F4
	private void EHFPLKEINFO()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			Debug.LogWarning(" ");
			base.enabled = true;
			return;
		}
		if (!SystemInfo.supportsRenderTextures)
		{
			Debug.LogWarning("{not_found}");
			base.enabled = false;
			return;
		}
		if (this.Shader != null && !this.Shader.isSupported)
		{
			Debug.LogWarning("MotorbikeAirWalk");
			base.enabled = true;
			return;
		}
		this.LMOIIDAMKDB(false);
	}

	// Token: 0x06002671 RID: 9841 RVA: 0x0010755B File Offset: 0x0010575B
	private void ICIIKJJJOEJ()
	{
		if (this.BHHEHMIFMBD)
		{
			UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
		}
	}

	// Token: 0x04000433 RID: 1075
	public Texture2D NoiseTexture;

	// Token: 0x04000434 RID: 1076
	public SSAOPro.GPEHFPFDJAF Samples = SSAOPro.GPEHFPFDJAF.Medium;

	// Token: 0x04000435 RID: 1077
	[Range(1f, 4f)]
	public int Downsampling = 1;

	// Token: 0x04000436 RID: 1078
	[Range(0.005f, 2f)]
	public float Radius = 0.45f;

	// Token: 0x04000437 RID: 1079
	[Range(0f, 16f)]
	public float Intensity = 2f;

	// Token: 0x04000438 RID: 1080
	[Range(0f, 10f)]
	public float Distance = 1f;

	// Token: 0x04000439 RID: 1081
	[Range(0f, 1f)]
	public float Bias = 0.025f;

	// Token: 0x0400043A RID: 1082
	[Range(0f, 1f)]
	public float LumContribution = 0.7f;

	// Token: 0x0400043B RID: 1083
	public Color OcclusionColor = Color.black;

	// Token: 0x0400043C RID: 1084
	public bool CutoffEnabled;

	// Token: 0x0400043D RID: 1085
	public float CutoffDistance = 500f;

	// Token: 0x0400043E RID: 1086
	public float CutoffFalloff = 75f;

	// Token: 0x0400043F RID: 1087
	public SSAOPro.GGFPOCFCJFG Blur;

	// Token: 0x04000440 RID: 1088
	public bool BlurDownsampling;

	// Token: 0x04000441 RID: 1089
	public bool DebugAO;

	// Token: 0x04000442 RID: 1090
	public Shader Shader;

	// Token: 0x04000443 RID: 1091
	protected Material BHHEHMIFMBD;

	// Token: 0x04000444 RID: 1092
	protected Camera MPCEHPBGHII;

	// Token: 0x04000445 RID: 1093
	private bool GBEMNBGEHHH;

	// Token: 0x04000446 RID: 1094
	private bool AJNJEFMAFLI;

	// Token: 0x04000447 RID: 1095
	private float DNFACHHPHCC;

	// Token: 0x04000448 RID: 1096
	private Color LJFONAEFPOH = Color.black;

	// Token: 0x04000449 RID: 1097
	private SSAOPro.GPEHFPFDJAF CBIPODLCGOH = SSAOPro.GPEHFPFDJAF.Medium;

	// Token: 0x020000B2 RID: 178
	public enum GGFPOCFCJFG
	{
		// Token: 0x0400044B RID: 1099
		None,
		// Token: 0x0400044C RID: 1100
		Gaussian,
		// Token: 0x0400044D RID: 1101
		Bilateral
	}

	// Token: 0x020000B3 RID: 179
	public enum GPEHFPFDJAF
	{
		// Token: 0x0400044F RID: 1103
		VeryLow,
		// Token: 0x04000450 RID: 1104
		Low,
		// Token: 0x04000451 RID: 1105
		Medium,
		// Token: 0x04000452 RID: 1106
		High
	}
}
