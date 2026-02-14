using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000310 RID: 784
	[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (Curves, Saturation)")]
	[ExecuteInEditMode]
	public class ColorCorrectionCurves : PostEffectsBase
	{
		// Token: 0x0600B4D9 RID: 46297 RVA: 0x004FFCF6 File Offset: 0x004FDEF6
		private void LBEFOABPMFG()
		{
			base.KABLGPBGKBJ();
			this.KEGMOAALLHK = false;
		}

		// Token: 0x0600B4DA RID: 46298 RVA: 0x004FFD05 File Offset: 0x004FDF05
		private void KKJJHKHDPIB()
		{
			this.ELLNPCALPKF();
		}

		// Token: 0x0600B4DB RID: 46299 RVA: 0x004FFD10 File Offset: 0x004FDF10
		private void MCCMFFLILNN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.GGJKGIHGMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.KEGMOAALLHK)
			{
				this.HLPHPFJANJB();
				this.KEGMOAALLHK = true;
			}
			if (this.useDepthCorrection)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			RenderTexture renderTexture = OKIIDHIJBEA;
			if (this.selectiveCc)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
			}
			if (this.useDepthCorrection)
			{
				this.KNHGHJNBEMN.SetTexture("wpn_rec3", this.ADMHJLIOEAD);
				this.KNHGHJNBEMN.SetTexture("gi_uinf_2i", this.NMDKEMKAOJA);
				this.KNHGHJNBEMN.SetTexture("cntx_close", this.LCDFFHCHPGC);
				this.KNHGHJNBEMN.SetFloat("shop_t8", this.saturation);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.KNHGHJNBEMN);
			}
			else
			{
				this.IAHELJAHCED.SetTexture("_", this.ADMHJLIOEAD);
				this.IAHELJAHCED.SetFloat(".unity3d", this.saturation);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.IAHELJAHCED);
			}
			if (this.selectiveCc)
			{
				this.IBBKCHHBMAP.SetColor(" L ", this.selectiveFromColor);
				this.IBBKCHHBMAP.SetColor("Idle Meditate", this.selectiveToColor);
				Graphics.Blit(renderTexture, OKIIDHIJBEA, this.IBBKCHHBMAP);
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600B4DC RID: 46300 RVA: 0x004FFE68 File Offset: 0x004FE068
		public virtual bool CALNGBIFBDM()
		{
			base.CGEGCOKMPHN(this.mode == ColorCorrectionCurves.CGIEPIJKBID.Advanced);
			this.IAHELJAHCED = base.JBHLGBPJFEL(this.simpleColorCorrectionCurvesShader, this.IAHELJAHCED);
			this.KNHGHJNBEMN = base.IIIIADNBONI(this.colorCorrectionCurvesShader, this.KNHGHJNBEMN);
			this.IBBKCHHBMAP = base.BOOFEOGDMBI(this.colorCorrectionSelectiveShader, this.IBBKCHHBMAP);
			if (!this.ADMHJLIOEAD)
			{
				this.ADMHJLIOEAD = new Texture2D(-53, 1, TextureFormat.RGBA32, true, false);
			}
			if (!this.LCDFFHCHPGC)
			{
				this.LCDFFHCHPGC = new Texture2D(170, 3, (TextureFormat)8, true, false);
			}
			if (!this.NMDKEMKAOJA)
			{
				this.NMDKEMKAOJA = new Texture2D(133, 0, TextureFormat.Alpha8, true, true);
			}
			this.ADMHJLIOEAD.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
			this.LCDFFHCHPGC.hideFlags = (HideFlags)68;
			this.NMDKEMKAOJA.hideFlags = (HideFlags)93;
			this.ADMHJLIOEAD.wrapMode = TextureWrapMode.Clamp;
			this.LCDFFHCHPGC.wrapMode = TextureWrapMode.Repeat;
			this.NMDKEMKAOJA.wrapMode = TextureWrapMode.Clamp;
			if (!this.PPGOAMIHMBG)
			{
				base.FDBKFKGCGEG();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B4DD RID: 46301 RVA: 0x004FFF90 File Offset: 0x004FE190
		public virtual bool POKDAEAADAC()
		{
			base.BGIALJEIEFO(this.mode == ColorCorrectionCurves.CGIEPIJKBID.Simple);
			this.IAHELJAHCED = base.IIIIADNBONI(this.simpleColorCorrectionCurvesShader, this.IAHELJAHCED);
			this.KNHGHJNBEMN = base.OOAOHFFDMJP(this.colorCorrectionCurvesShader, this.KNHGHJNBEMN);
			this.IBBKCHHBMAP = base.OOAOHFFDMJP(this.colorCorrectionSelectiveShader, this.IBBKCHHBMAP);
			if (!this.ADMHJLIOEAD)
			{
				this.ADMHJLIOEAD = new Texture2D(132, 8, TextureFormat.ARGB32, true, true);
			}
			if (!this.LCDFFHCHPGC)
			{
				this.LCDFFHCHPGC = new Texture2D(-65, 3, TextureFormat.RGB24, true, false);
			}
			if (!this.NMDKEMKAOJA)
			{
				this.NMDKEMKAOJA = new Texture2D(-146, 0, TextureFormat.Alpha8, true, true);
			}
			this.ADMHJLIOEAD.hideFlags = (HideFlags)(-118);
			this.LCDFFHCHPGC.hideFlags = (HideFlags)99;
			this.NMDKEMKAOJA.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
			this.ADMHJLIOEAD.wrapMode = TextureWrapMode.Clamp;
			this.LCDFFHCHPGC.wrapMode = TextureWrapMode.Clamp;
			this.NMDKEMKAOJA.wrapMode = TextureWrapMode.Clamp;
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B4DE RID: 46302 RVA: 0x005000B7 File Offset: 0x004FE2B7
		private void NCALLFHEAGJ()
		{
			base.FFIGGPHAIBP();
			this.KEGMOAALLHK = false;
		}

		// Token: 0x0600B4DF RID: 46303 RVA: 0x005000C6 File Offset: 0x004FE2C6
		private void DIBOKDBMKJI()
		{
			base.APPLKMOGAMJ();
			this.KEGMOAALLHK = true;
		}

		// Token: 0x0600B4E0 RID: 46304 RVA: 0x005000D8 File Offset: 0x004FE2D8
		public virtual bool HBJMLLLCNBF()
		{
			base.EHGENDOEHLP(this.mode == ColorCorrectionCurves.CGIEPIJKBID.Advanced);
			this.IAHELJAHCED = base.JBHLGBPJFEL(this.simpleColorCorrectionCurvesShader, this.IAHELJAHCED);
			this.KNHGHJNBEMN = base.DJFOEIJIMJB(this.colorCorrectionCurvesShader, this.KNHGHJNBEMN);
			this.IBBKCHHBMAP = base.BAPJBHPEDIF(this.colorCorrectionSelectiveShader, this.IBBKCHHBMAP);
			if (!this.ADMHJLIOEAD)
			{
				this.ADMHJLIOEAD = new Texture2D(66, 0, (TextureFormat)6, false, false);
			}
			if (!this.LCDFFHCHPGC)
			{
				this.LCDFFHCHPGC = new Texture2D(-1, 0, TextureFormat.Alpha8, true, true);
			}
			if (!this.NMDKEMKAOJA)
			{
				this.NMDKEMKAOJA = new Texture2D(-59, 1, (TextureFormat)8, true, false);
			}
			this.ADMHJLIOEAD.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
			this.LCDFFHCHPGC.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
			this.NMDKEMKAOJA.hideFlags = (HideFlags)(-72);
			this.ADMHJLIOEAD.wrapMode = TextureWrapMode.Repeat;
			this.LCDFFHCHPGC.wrapMode = TextureWrapMode.Repeat;
			this.NMDKEMKAOJA.wrapMode = TextureWrapMode.Clamp;
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B4E1 RID: 46305 RVA: 0x00500200 File Offset: 0x004FE400
		private void HHLIKPOMGPF(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.IGJKBOMMMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.KEGMOAALLHK)
			{
				this.NJLGHHNNICL();
				this.KEGMOAALLHK = false;
			}
			if (this.useDepthCorrection)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			RenderTexture renderTexture = OKIIDHIJBEA;
			if (this.selectiveCc)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
			}
			if (this.useDepthCorrection)
			{
				this.KNHGHJNBEMN.SetTexture("https://groups.google.com/forum/#!forum/final-ik", this.ADMHJLIOEAD);
				this.KNHGHJNBEMN.SetTexture("_L_", this.NMDKEMKAOJA);
				this.KNHGHJNBEMN.SetTexture("Gesture Hand Up", this.LCDFFHCHPGC);
				this.KNHGHJNBEMN.SetFloat("holes_max", this.saturation);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.KNHGHJNBEMN);
			}
			else
			{
				this.IAHELJAHCED.SetTexture("Wizard1HandThrow", this.ADMHJLIOEAD);
				this.IAHELJAHCED.SetFloat(" ", this.saturation);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.IAHELJAHCED);
			}
			if (this.selectiveCc)
			{
				this.IBBKCHHBMAP.SetColor("MotorbikeWheelyNoHands", this.selectiveFromColor);
				this.IBBKCHHBMAP.SetColor("Anchore Left_", this.selectiveToColor);
				Graphics.Blit(renderTexture, OKIIDHIJBEA, this.IBBKCHHBMAP);
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600B4E2 RID: 46306 RVA: 0x00022FCC File Offset: 0x000211CC
		private void DIDFCBLHFNF()
		{
		}

		// Token: 0x0600B4E3 RID: 46307 RVA: 0x00500358 File Offset: 0x004FE558
		private void EHFPLKEINFO()
		{
			base.GGBMJFNGHMC();
			this.KEGMOAALLHK = true;
		}

		// Token: 0x0600B4E4 RID: 46308 RVA: 0x00500367 File Offset: 0x004FE567
		private void MEFCLBONEPJ()
		{
			this.JNPCNOCKOJF();
		}

		// Token: 0x0600B4E5 RID: 46309 RVA: 0x0050036F File Offset: 0x004FE56F
		private void CPNOBMNKPNC()
		{
			base.KABLGPBGKBJ();
			this.KEGMOAALLHK = true;
		}

		// Token: 0x0600B4E6 RID: 46310 RVA: 0x00022FCC File Offset: 0x000211CC
		private void HCMHMFHMPHN()
		{
		}

		// Token: 0x0600B4E7 RID: 46311 RVA: 0x00500380 File Offset: 0x004FE580
		private void IONGMCBMPIB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.DLENDGGGMBJ())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.KEGMOAALLHK)
			{
				this.BDDBECDBEDP();
				this.KEGMOAALLHK = false;
			}
			if (this.useDepthCorrection)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			RenderTexture renderTexture = OKIIDHIJBEA;
			if (this.selectiveCc)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
			}
			if (this.useDepthCorrection)
			{
				this.KNHGHJNBEMN.SetTexture("__c", this.ADMHJLIOEAD);
				this.KNHGHJNBEMN.SetTexture("<color=\"", this.NMDKEMKAOJA);
				this.KNHGHJNBEMN.SetTexture("wpn_add/base", this.LCDFFHCHPGC);
				this.KNHGHJNBEMN.SetFloat("", this.saturation);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.KNHGHJNBEMN);
			}
			else
			{
				this.IAHELJAHCED.SetTexture("_Skybox", this.ADMHJLIOEAD);
				this.IAHELJAHCED.SetFloat("StaffHeal", this.saturation);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.IAHELJAHCED);
			}
			if (this.selectiveCc)
			{
				this.IBBKCHHBMAP.SetColor("currentCount=", this.selectiveFromColor);
				this.IBBKCHHBMAP.SetColor("Flashlight", this.selectiveToColor);
				Graphics.Blit(renderTexture, OKIIDHIJBEA, this.IBBKCHHBMAP);
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600B4E8 RID: 46312 RVA: 0x005004D8 File Offset: 0x004FE6D8
		private void LHJCHPFKGDB()
		{
			base.CKIGGCAHAFD();
			this.KEGMOAALLHK = true;
		}

		// Token: 0x0600B4E9 RID: 46313 RVA: 0x004FFD05 File Offset: 0x004FDF05
		private void NHHFCCEPPDL()
		{
			this.ELLNPCALPKF();
		}

		// Token: 0x0600B4EA RID: 46314 RVA: 0x005004E8 File Offset: 0x004FE6E8
		private void JCOOPIFFNNH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.IGJKBOMMMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.KEGMOAALLHK)
			{
				this.UpdateParameters();
				this.KEGMOAALLHK = false;
			}
			if (this.useDepthCorrection)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			RenderTexture renderTexture = OKIIDHIJBEA;
			if (this.selectiveCc)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
			}
			if (this.useDepthCorrection)
			{
				this.KNHGHJNBEMN.SetTexture("Rect: ", this.ADMHJLIOEAD);
				this.KNHGHJNBEMN.SetTexture("CratePull", this.NMDKEMKAOJA);
				this.KNHGHJNBEMN.SetTexture(" ", this.LCDFFHCHPGC);
				this.KNHGHJNBEMN.SetFloat("SneakForward", this.saturation);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.KNHGHJNBEMN);
			}
			else
			{
				this.IAHELJAHCED.SetTexture("cntx_resauk", this.ADMHJLIOEAD);
				this.IAHELJAHCED.SetFloat("req_prof", this.saturation);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.IAHELJAHCED);
			}
			if (this.selectiveCc)
			{
				this.IBBKCHHBMAP.SetColor("repair.ogg", this.selectiveFromColor);
				this.IBBKCHHBMAP.SetColor(", ", this.selectiveToColor);
				Graphics.Blit(renderTexture, OKIIDHIJBEA, this.IBBKCHHBMAP);
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600B4EB RID: 46315 RVA: 0x00022FCC File Offset: 0x000211CC
		private void CKGJEIDEJCH()
		{
		}

		// Token: 0x0600B4EC RID: 46316 RVA: 0x00500640 File Offset: 0x004FE840
		private void IJFPHGEFOLF()
		{
			base.OBJCOJEHLBE();
			this.KEGMOAALLHK = false;
		}

		// Token: 0x0600B4ED RID: 46317 RVA: 0x00500650 File Offset: 0x004FE850
		public void CDMBILDBHGE()
		{
			this.GGJKGIHGMGC();
			if (this.redChannel != null && this.greenChannel != null && this.blueChannel != null)
			{
				for (float num = 1136f; num <= 1338f; num += 1261f)
				{
					float num2 = Mathf.Clamp(this.redChannel.Evaluate(num), 459f, 1355f);
					float num3 = Mathf.Clamp(this.greenChannel.Evaluate(num), 1396f, 16f);
					float num4 = Mathf.Clamp(this.blueChannel.Evaluate(num), 1596f, 499f);
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 1422f), 0, new Color(num2, num2, num2));
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 11f), 1, new Color(num3, num3, num3));
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 913f), 3, new Color(num4, num4, num4));
					float num5 = Mathf.Clamp(this.zCurve.Evaluate(num), 1934f, 1241f);
					this.NMDKEMKAOJA.SetPixel((int)Mathf.Floor(num * 1493f), 0, new Color(num5, num5, num5));
					num2 = Mathf.Clamp(this.depthRedChannel.Evaluate(num), 993f, 1070f);
					num3 = Mathf.Clamp(this.depthGreenChannel.Evaluate(num), 1000f, 1880f);
					num4 = Mathf.Clamp(this.depthBlueChannel.Evaluate(num), 270f, 839f);
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 629f), 0, new Color(num2, num2, num2));
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 1744f), 1, new Color(num3, num3, num3));
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 63f), 7, new Color(num4, num4, num4));
				}
				this.ADMHJLIOEAD.Apply();
				this.LCDFFHCHPGC.Apply();
				this.NMDKEMKAOJA.Apply();
			}
		}

		// Token: 0x0600B4EE RID: 46318 RVA: 0x00500874 File Offset: 0x004FEA74
		public virtual bool AHMAHFLOJBM()
		{
			base.OAAFLHNDKBJ(this.mode == ColorCorrectionCurves.CGIEPIJKBID.Simple);
			this.IAHELJAHCED = base.IIIIADNBONI(this.simpleColorCorrectionCurvesShader, this.IAHELJAHCED);
			this.KNHGHJNBEMN = base.DJFOEIJIMJB(this.colorCorrectionCurvesShader, this.KNHGHJNBEMN);
			this.IBBKCHHBMAP = base.ALJPMGLOIEG(this.colorCorrectionSelectiveShader, this.IBBKCHHBMAP);
			if (!this.ADMHJLIOEAD)
			{
				this.ADMHJLIOEAD = new Texture2D(-73, 7, (TextureFormat)0, false, true);
			}
			if (!this.LCDFFHCHPGC)
			{
				this.LCDFFHCHPGC = new Texture2D(-4, 4, TextureFormat.RGB24, true, false);
			}
			if (!this.NMDKEMKAOJA)
			{
				this.NMDKEMKAOJA = new Texture2D(59, 0, (TextureFormat)8, true, false);
			}
			this.ADMHJLIOEAD.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
			this.LCDFFHCHPGC.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			this.NMDKEMKAOJA.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
			this.ADMHJLIOEAD.wrapMode = TextureWrapMode.Repeat;
			this.LCDFFHCHPGC.wrapMode = TextureWrapMode.Clamp;
			this.NMDKEMKAOJA.wrapMode = TextureWrapMode.Repeat;
			if (!this.PPGOAMIHMBG)
			{
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B4EF RID: 46319 RVA: 0x0050099C File Offset: 0x004FEB9C
		private void ALNHCIOIBPP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.GGJKGIHGMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.KEGMOAALLHK)
			{
				this.MLMBOAKJFKB();
				this.KEGMOAALLHK = false;
			}
			if (this.useDepthCorrection)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			RenderTexture renderTexture = OKIIDHIJBEA;
			if (this.selectiveCc)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
			}
			if (this.useDepthCorrection)
			{
				this.KNHGHJNBEMN.SetTexture("-", this.ADMHJLIOEAD);
				this.KNHGHJNBEMN.SetTexture("BlackSmithHammer", this.NMDKEMKAOJA);
				this.KNHGHJNBEMN.SetTexture("?", this.LCDFFHCHPGC);
				this.KNHGHJNBEMN.SetFloat("gameComplete", this.saturation);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.KNHGHJNBEMN);
			}
			else
			{
				this.IAHELJAHCED.SetTexture("BowFire", this.ADMHJLIOEAD);
				this.IAHELJAHCED.SetFloat("IK.Disable() is deprecated. Use enabled = false instead", this.saturation);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.IAHELJAHCED);
			}
			if (this.selectiveCc)
			{
				this.IBBKCHHBMAP.SetColor("_HitPosition", this.selectiveFromColor);
				this.IBBKCHHBMAP.SetColor("#2080ff", this.selectiveToColor);
				Graphics.Blit(renderTexture, OKIIDHIJBEA, this.IBBKCHHBMAP);
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600B4F0 RID: 46320 RVA: 0x00500AF4 File Offset: 0x004FECF4
		private void LHMNFJBJBJM()
		{
			base.OLBDJCFPKFG();
			this.KEGMOAALLHK = true;
		}

		// Token: 0x0600B4F1 RID: 46321 RVA: 0x00022FCC File Offset: 0x000211CC
		private void JIGAFDHOFKL()
		{
		}

		// Token: 0x0600B4F2 RID: 46322 RVA: 0x00500B03 File Offset: 0x004FED03
		private void ALLPKCLIFHB()
		{
			this.PLDFOBJOHKO();
		}

		// Token: 0x0600B4F3 RID: 46323 RVA: 0x00500B0B File Offset: 0x004FED0B
		private void ONIHHFLOJMN()
		{
			base.IAAOGAPJDID();
			this.KEGMOAALLHK = false;
		}

		// Token: 0x0600B4F4 RID: 46324 RVA: 0x00500B1A File Offset: 0x004FED1A
		private void GLFNJMPAOIL()
		{
			this.DMNEOLILBGB();
		}

		// Token: 0x0600B4F5 RID: 46325 RVA: 0x00500B24 File Offset: 0x004FED24
		public virtual bool JOOBMJEKCFB()
		{
			base.EHGENDOEHLP(this.mode == ColorCorrectionCurves.CGIEPIJKBID.Advanced);
			this.IAHELJAHCED = base.OOAOHFFDMJP(this.simpleColorCorrectionCurvesShader, this.IAHELJAHCED);
			this.KNHGHJNBEMN = base.IIIIADNBONI(this.colorCorrectionCurvesShader, this.KNHGHJNBEMN);
			this.IBBKCHHBMAP = base.BOOFEOGDMBI(this.colorCorrectionSelectiveShader, this.IBBKCHHBMAP);
			if (!this.ADMHJLIOEAD)
			{
				this.ADMHJLIOEAD = new Texture2D(-42, 4, TextureFormat.RGB565, true, false);
			}
			if (!this.LCDFFHCHPGC)
			{
				this.LCDFFHCHPGC = new Texture2D(-125, 0, (TextureFormat)8, true, false);
			}
			if (!this.NMDKEMKAOJA)
			{
				this.NMDKEMKAOJA = new Texture2D(-24, 1, TextureFormat.RGB24, false, true);
			}
			this.ADMHJLIOEAD.hideFlags = (HideFlags)(-109);
			this.LCDFFHCHPGC.hideFlags = HideFlags.DontSaveInEditor;
			this.NMDKEMKAOJA.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			this.ADMHJLIOEAD.wrapMode = TextureWrapMode.Repeat;
			this.LCDFFHCHPGC.wrapMode = TextureWrapMode.Clamp;
			this.NMDKEMKAOJA.wrapMode = TextureWrapMode.Repeat;
			if (!this.PPGOAMIHMBG)
			{
				base.INOGPLDHPGC();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B4F6 RID: 46326 RVA: 0x00500C4C File Offset: 0x004FEE4C
		private void EAODOAGNHIK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.KEGMOAALLHK)
			{
				this.GAIMMCKHHLN();
				this.KEGMOAALLHK = false;
			}
			if (this.useDepthCorrection)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			RenderTexture renderTexture = OKIIDHIJBEA;
			if (this.selectiveCc)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
			}
			if (this.useDepthCorrection)
			{
				this.KNHGHJNBEMN.SetTexture("wpn_wgt", this.ADMHJLIOEAD);
				this.KNHGHJNBEMN.SetTexture("FISHES", this.NMDKEMKAOJA);
				this.KNHGHJNBEMN.SetTexture("WizardPowerUp", this.LCDFFHCHPGC);
				this.KNHGHJNBEMN.SetFloat("<color='#ff8000'>- </color>", this.saturation);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.KNHGHJNBEMN);
			}
			else
			{
				this.IAHELJAHCED.SetTexture("] is null.", this.ADMHJLIOEAD);
				this.IAHELJAHCED.SetFloat("Make sure you are not placing 2 or more FBBIK effectors of the same chain to exactly the same position.", this.saturation);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.IAHELJAHCED);
			}
			if (this.selectiveCc)
			{
				this.IBBKCHHBMAP.SetColor("_Overlay", this.selectiveFromColor);
				this.IBBKCHHBMAP.SetColor("Obscured Vars Cheating Detected!", this.selectiveToColor);
				Graphics.Blit(renderTexture, OKIIDHIJBEA, this.IBBKCHHBMAP);
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600B4F7 RID: 46327 RVA: 0x00500DA4 File Offset: 0x004FEFA4
		public virtual bool PKLOCPBBHNH()
		{
			base.OAAFLHNDKBJ(this.mode == ColorCorrectionCurves.CGIEPIJKBID.Advanced);
			this.IAHELJAHCED = base.DJFOEIJIMJB(this.simpleColorCorrectionCurvesShader, this.IAHELJAHCED);
			this.KNHGHJNBEMN = base.OOAOHFFDMJP(this.colorCorrectionCurvesShader, this.KNHGHJNBEMN);
			this.IBBKCHHBMAP = base.JBHLGBPJFEL(this.colorCorrectionSelectiveShader, this.IBBKCHHBMAP);
			if (!this.ADMHJLIOEAD)
			{
				this.ADMHJLIOEAD = new Texture2D(-78, 4, TextureFormat.ARGB4444, false, false);
			}
			if (!this.LCDFFHCHPGC)
			{
				this.LCDFFHCHPGC = new Texture2D(64, 8, TextureFormat.Alpha8, false, false);
			}
			if (!this.NMDKEMKAOJA)
			{
				this.NMDKEMKAOJA = new Texture2D(121, 0, TextureFormat.Alpha8, false, true);
			}
			this.ADMHJLIOEAD.hideFlags = (HideFlags)(-1);
			this.LCDFFHCHPGC.hideFlags = (HideFlags)87;
			this.NMDKEMKAOJA.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			this.ADMHJLIOEAD.wrapMode = TextureWrapMode.Clamp;
			this.LCDFFHCHPGC.wrapMode = TextureWrapMode.Repeat;
			this.NMDKEMKAOJA.wrapMode = TextureWrapMode.Repeat;
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B4F8 RID: 46328 RVA: 0x00500ECB File Offset: 0x004FF0CB
		private void BGCLAKJHAFK()
		{
			base.GGBMJFNGHMC();
			this.KEGMOAALLHK = false;
		}

		// Token: 0x0600B4F9 RID: 46329 RVA: 0x00500EDC File Offset: 0x004FF0DC
		public void BMIBKAMOOAB()
		{
			this.NHEEDPALBFN();
			if (this.redChannel != null && this.greenChannel != null && this.blueChannel != null)
			{
				for (float num = 1765f; num <= 155f; num += 147f)
				{
					float num2 = Mathf.Clamp(this.redChannel.Evaluate(num), 1871f, 1406f);
					float num3 = Mathf.Clamp(this.greenChannel.Evaluate(num), 1896f, 1196f);
					float num4 = Mathf.Clamp(this.blueChannel.Evaluate(num), 750f, 209f);
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 1376f), 0, new Color(num2, num2, num2));
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 1215f), 0, new Color(num3, num3, num3));
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 1939f), 1, new Color(num4, num4, num4));
					float num5 = Mathf.Clamp(this.zCurve.Evaluate(num), 1507f, 513f);
					this.NMDKEMKAOJA.SetPixel((int)Mathf.Floor(num * 977f), 0, new Color(num5, num5, num5));
					num2 = Mathf.Clamp(this.depthRedChannel.Evaluate(num), 282f, 1607f);
					num3 = Mathf.Clamp(this.depthGreenChannel.Evaluate(num), 1571f, 1311f);
					num4 = Mathf.Clamp(this.depthBlueChannel.Evaluate(num), 72f, 334f);
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 1294f), 0, new Color(num2, num2, num2));
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 437f), 0, new Color(num3, num3, num3));
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 1565f), 8, new Color(num4, num4, num4));
				}
				this.ADMHJLIOEAD.Apply();
				this.LCDFFHCHPGC.Apply();
				this.NMDKEMKAOJA.Apply();
			}
		}

		// Token: 0x0600B4FA RID: 46330 RVA: 0x005010FF File Offset: 0x004FF2FF
		private void FEBIICIMLHA()
		{
			base.CKIGGCAHAFD();
			this.KEGMOAALLHK = false;
		}

		// Token: 0x0600B4FB RID: 46331 RVA: 0x0050110E File Offset: 0x004FF30E
		private new void FFIGGPHAIBP()
		{
			base.IAAOGAPJDID();
			this.KEGMOAALLHK = true;
		}

		// Token: 0x0600B4FC RID: 46332 RVA: 0x00501120 File Offset: 0x004FF320
		private void EIMKKKCGJLO(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.KEGMOAALLHK)
			{
				this.IBMJDDKGHBP();
				this.KEGMOAALLHK = false;
			}
			if (this.useDepthCorrection)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			RenderTexture renderTexture = OKIIDHIJBEA;
			if (this.selectiveCc)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
			}
			if (this.useDepthCorrection)
			{
				this.KNHGHJNBEMN.SetTexture("autherror", this.ADMHJLIOEAD);
				this.KNHGHJNBEMN.SetTexture("", this.NMDKEMKAOJA);
				this.KNHGHJNBEMN.SetTexture("_SrcBlend", this.LCDFFHCHPGC);
				this.KNHGHJNBEMN.SetFloat("BlackSmithHammer", this.saturation);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.KNHGHJNBEMN);
			}
			else
			{
				this.IAHELJAHCED.SetTexture("wpn_add/base", this.ADMHJLIOEAD);
				this.IAHELJAHCED.SetFloat("_", this.saturation);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.IAHELJAHCED);
			}
			if (this.selectiveCc)
			{
				this.IBBKCHHBMAP.SetColor("wpn_eat8", this.selectiveFromColor);
				this.IBBKCHHBMAP.SetColor("linebreak.ogg", this.selectiveToColor);
				Graphics.Blit(renderTexture, OKIIDHIJBEA, this.IBBKCHHBMAP);
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600B4FD RID: 46333 RVA: 0x00501278 File Offset: 0x004FF478
		private void FECFLBMPAAL()
		{
			base.Start();
			this.KEGMOAALLHK = true;
		}

		// Token: 0x0600B4FE RID: 46334 RVA: 0x00500B0B File Offset: 0x004FED0B
		private void GHCMIKGJPJD()
		{
			base.IAAOGAPJDID();
			this.KEGMOAALLHK = false;
		}

		// Token: 0x0600B4FF RID: 46335 RVA: 0x00501288 File Offset: 0x004FF488
		private void IMPMHDDEOJN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.KEGMOAALLHK)
			{
				this.HLPHPFJANJB();
				this.KEGMOAALLHK = true;
			}
			if (this.useDepthCorrection)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			RenderTexture renderTexture = OKIIDHIJBEA;
			if (this.selectiveCc)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
			}
			if (this.useDepthCorrection)
			{
				this.KNHGHJNBEMN.SetTexture("", this.ADMHJLIOEAD);
				this.KNHGHJNBEMN.SetTexture("Manifest: ", this.NMDKEMKAOJA);
				this.KNHGHJNBEMN.SetTexture("RollerBladeStand", this.LCDFFHCHPGC);
				this.KNHGHJNBEMN.SetFloat("?", this.saturation);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.KNHGHJNBEMN);
			}
			else
			{
				this.IAHELJAHCED.SetTexture("Active Process ", this.ADMHJLIOEAD);
				this.IAHELJAHCED.SetFloat("SoccerPassHeavy", this.saturation);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.IAHELJAHCED);
			}
			if (this.selectiveCc)
			{
				this.IBBKCHHBMAP.SetColor("Adjust", this.selectiveFromColor);
				this.IBBKCHHBMAP.SetColor("Giant Grab Throw 2", this.selectiveToColor);
				Graphics.Blit(renderTexture, OKIIDHIJBEA, this.IBBKCHHBMAP);
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600B500 RID: 46336 RVA: 0x005013E0 File Offset: 0x004FF5E0
		private void OCNAECBANNG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NHEEDPALBFN())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.KEGMOAALLHK)
			{
				this.HGJHELLIFDO();
				this.KEGMOAALLHK = true;
			}
			if (this.useDepthCorrection)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			RenderTexture renderTexture = OKIIDHIJBEA;
			if (this.selectiveCc)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
			}
			if (this.useDepthCorrection)
			{
				this.KNHGHJNBEMN.SetTexture("_ChannelMixerBlue", this.ADMHJLIOEAD);
				this.KNHGHJNBEMN.SetTexture("\n", this.NMDKEMKAOJA);
				this.KNHGHJNBEMN.SetTexture("(Org: ", this.LCDFFHCHPGC);
				this.KNHGHJNBEMN.SetFloat("Location ", this.saturation);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.KNHGHJNBEMN);
			}
			else
			{
				this.IAHELJAHCED.SetTexture("RollerBladeStop", this.ADMHJLIOEAD);
				this.IAHELJAHCED.SetFloat("SneakIdle", this.saturation);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.IAHELJAHCED);
			}
			if (this.selectiveCc)
			{
				this.IBBKCHHBMAP.SetColor("LOC_NAMES", this.selectiveFromColor);
				this.IBBKCHHBMAP.SetColor("crft_btn2", this.selectiveToColor);
				Graphics.Blit(renderTexture, OKIIDHIJBEA, this.IBBKCHHBMAP);
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600B501 RID: 46337 RVA: 0x00022FCC File Offset: 0x000211CC
		private void Awake()
		{
		}

		// Token: 0x0600B503 RID: 46339 RVA: 0x00501728 File Offset: 0x004FF928
		public void ELLNPCALPKF()
		{
			this.PKHJBLJFIBF();
			if (this.redChannel != null && this.greenChannel != null && this.blueChannel != null)
			{
				for (float num = 853f; num <= 1576f; num += 643f)
				{
					float num2 = Mathf.Clamp(this.redChannel.Evaluate(num), 817f, 1964f);
					float num3 = Mathf.Clamp(this.greenChannel.Evaluate(num), 1555f, 1966f);
					float num4 = Mathf.Clamp(this.blueChannel.Evaluate(num), 1993f, 118f);
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 452f), 1, new Color(num2, num2, num2));
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 463f), 1, new Color(num3, num3, num3));
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 1061f), 1, new Color(num4, num4, num4));
					float num5 = Mathf.Clamp(this.zCurve.Evaluate(num), 1518f, 1475f);
					this.NMDKEMKAOJA.SetPixel((int)Mathf.Floor(num * 1765f), 0, new Color(num5, num5, num5));
					num2 = Mathf.Clamp(this.depthRedChannel.Evaluate(num), 1321f, 946f);
					num3 = Mathf.Clamp(this.depthGreenChannel.Evaluate(num), 786f, 1038f);
					num4 = Mathf.Clamp(this.depthBlueChannel.Evaluate(num), 1800f, 1845f);
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 1692f), 1, new Color(num2, num2, num2));
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 111f), 0, new Color(num3, num3, num3));
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 759f), 7, new Color(num4, num4, num4));
				}
				this.ADMHJLIOEAD.Apply();
				this.LCDFFHCHPGC.Apply();
				this.NMDKEMKAOJA.Apply();
			}
		}

		// Token: 0x0600B504 RID: 46340 RVA: 0x0050194B File Offset: 0x004FFB4B
		private void GHLKHNEKJKD()
		{
			this.EJDOCAKMDON();
		}

		// Token: 0x0600B505 RID: 46341 RVA: 0x00501953 File Offset: 0x004FFB53
		private void MLOHFJBLIIO()
		{
			this.GAIMMCKHHLN();
		}

		// Token: 0x0600B506 RID: 46342 RVA: 0x0050195C File Offset: 0x004FFB5C
		private void EKMKDLLLGFB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.KEGMOAALLHK)
			{
				this.NJLGHHNNICL();
				this.KEGMOAALLHK = false;
			}
			if (this.useDepthCorrection)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			RenderTexture renderTexture = OKIIDHIJBEA;
			if (this.selectiveCc)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
			}
			if (this.useDepthCorrection)
			{
				this.KNHGHJNBEMN.SetTexture("<color='#60a0ff'>{0}</color>\n<color='#ffff60'>Всего выловлено: <color='#ffffa0'>{1}</color> шт Общим весом <color='#ffffa0'>{2}</color>\nЛичный рекорд <color='#ffffa0'>{3}</color> </color>", this.ADMHJLIOEAD);
				this.KNHGHJNBEMN.SetTexture("t_shoes", this.NMDKEMKAOJA);
				this.KNHGHJNBEMN.SetTexture("{0:F2}, {1:F2}", this.LCDFFHCHPGC);
				this.KNHGHJNBEMN.SetFloat("bases/base_{0}", this.saturation);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.KNHGHJNBEMN);
			}
			else
			{
				this.IAHELJAHCED.SetTexture("", this.ADMHJLIOEAD);
				this.IAHELJAHCED.SetFloat("OfficeSittingReading", this.saturation);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.IAHELJAHCED);
			}
			if (this.selectiveCc)
			{
				this.IBBKCHHBMAP.SetColor("_Grain_Params1", this.selectiveFromColor);
				this.IBBKCHHBMAP.SetColor("rod_inf1", this.selectiveToColor);
				Graphics.Blit(renderTexture, OKIIDHIJBEA, this.IBBKCHHBMAP);
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600B507 RID: 46343 RVA: 0x00501AB4 File Offset: 0x004FFCB4
		private void DNPIJGHMNGK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.DLENDGGGMBJ())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.KEGMOAALLHK)
			{
				this.DMNEOLILBGB();
				this.KEGMOAALLHK = false;
			}
			if (this.useDepthCorrection)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			RenderTexture renderTexture = OKIIDHIJBEA;
			if (this.selectiveCc)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
			}
			if (this.useDepthCorrection)
			{
				this.KNHGHJNBEMN.SetTexture("1 H Sword Charge Heavy Bash", this.ADMHJLIOEAD);
				this.KNHGHJNBEMN.SetTexture("gi_letgoshe", this.NMDKEMKAOJA);
				this.KNHGHJNBEMN.SetTexture("CrouchWalkBackward", this.LCDFFHCHPGC);
				this.KNHGHJNBEMN.SetFloat("LUX_GAMMA", this.saturation);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.KNHGHJNBEMN);
			}
			else
			{
				this.IAHELJAHCED.SetTexture("action", this.ADMHJLIOEAD);
				this.IAHELJAHCED.SetFloat("[X]", this.saturation);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.IAHELJAHCED);
			}
			if (this.selectiveCc)
			{
				this.IBBKCHHBMAP.SetColor("", this.selectiveFromColor);
				this.IBBKCHHBMAP.SetColor("**********  158 pointid=", this.selectiveToColor);
				Graphics.Blit(renderTexture, OKIIDHIJBEA, this.IBBKCHHBMAP);
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600B508 RID: 46344 RVA: 0x00501278 File Offset: 0x004FF478
		private new void Start()
		{
			base.Start();
			this.KEGMOAALLHK = true;
		}

		// Token: 0x0600B509 RID: 46345 RVA: 0x00022FCC File Offset: 0x000211CC
		private void CBBIADNKMLI()
		{
		}

		// Token: 0x0600B50A RID: 46346 RVA: 0x00501C0C File Offset: 0x004FFE0C
		private void IJOCHELLKJH()
		{
			base.FFIGGPHAIBP();
			this.KEGMOAALLHK = true;
		}

		// Token: 0x0600B50B RID: 46347 RVA: 0x00501C1C File Offset: 0x004FFE1C
		public virtual bool FLLLHJJPHDI()
		{
			base.PKDIKFGAJKM(this.mode == ColorCorrectionCurves.CGIEPIJKBID.Advanced);
			this.IAHELJAHCED = base.OOAOHFFDMJP(this.simpleColorCorrectionCurvesShader, this.IAHELJAHCED);
			this.KNHGHJNBEMN = base.OOAOHFFDMJP(this.colorCorrectionCurvesShader, this.KNHGHJNBEMN);
			this.IBBKCHHBMAP = base.ALJPMGLOIEG(this.colorCorrectionSelectiveShader, this.IBBKCHHBMAP);
			if (!this.ADMHJLIOEAD)
			{
				this.ADMHJLIOEAD = new Texture2D(30, 2, TextureFormat.ARGB4444, false, false);
			}
			if (!this.LCDFFHCHPGC)
			{
				this.LCDFFHCHPGC = new Texture2D(-148, 1, TextureFormat.RGB24, false, false);
			}
			if (!this.NMDKEMKAOJA)
			{
				this.NMDKEMKAOJA = new Texture2D(44, 1, TextureFormat.Alpha8, true, true);
			}
			this.ADMHJLIOEAD.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			this.LCDFFHCHPGC.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
			this.NMDKEMKAOJA.hideFlags = (HideFlags)113;
			this.ADMHJLIOEAD.wrapMode = TextureWrapMode.Clamp;
			this.LCDFFHCHPGC.wrapMode = TextureWrapMode.Clamp;
			this.NMDKEMKAOJA.wrapMode = TextureWrapMode.Clamp;
			if (!this.PPGOAMIHMBG)
			{
				base.LNEHBOJIBAI();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B50C RID: 46348 RVA: 0x00501D44 File Offset: 0x004FFF44
		public virtual bool JKMNILOPECN()
		{
			base.LGANGHEOPOG(this.mode == ColorCorrectionCurves.CGIEPIJKBID.Simple);
			this.IAHELJAHCED = base.DJFOEIJIMJB(this.simpleColorCorrectionCurvesShader, this.IAHELJAHCED);
			this.KNHGHJNBEMN = base.BOOFEOGDMBI(this.colorCorrectionCurvesShader, this.KNHGHJNBEMN);
			this.IBBKCHHBMAP = base.BOOFEOGDMBI(this.colorCorrectionSelectiveShader, this.IBBKCHHBMAP);
			if (!this.ADMHJLIOEAD)
			{
				this.ADMHJLIOEAD = new Texture2D(94, 1, TextureFormat.RGB565, false, true);
			}
			if (!this.LCDFFHCHPGC)
			{
				this.LCDFFHCHPGC = new Texture2D(-141, 7, TextureFormat.RGB565, true, false);
			}
			if (!this.NMDKEMKAOJA)
			{
				this.NMDKEMKAOJA = new Texture2D(174, 0, (TextureFormat)0, true, false);
			}
			this.ADMHJLIOEAD.hideFlags = HideFlags.HideAndDontSave;
			this.LCDFFHCHPGC.hideFlags = (HideFlags)(-90);
			this.NMDKEMKAOJA.hideFlags = (HideFlags)(-88);
			this.ADMHJLIOEAD.wrapMode = TextureWrapMode.Repeat;
			this.LCDFFHCHPGC.wrapMode = TextureWrapMode.Clamp;
			this.NMDKEMKAOJA.wrapMode = TextureWrapMode.Clamp;
			if (!this.PPGOAMIHMBG)
			{
				base.INOGPLDHPGC();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B50D RID: 46349 RVA: 0x00501E6C File Offset: 0x0050006C
		private void LGKJKHBJFCP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.KEGMOAALLHK)
			{
				this.EJDOCAKMDON();
				this.KEGMOAALLHK = false;
			}
			if (this.useDepthCorrection)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			RenderTexture renderTexture = OKIIDHIJBEA;
			if (this.selectiveCc)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
			}
			if (this.useDepthCorrection)
			{
				this.KNHGHJNBEMN.SetTexture("IdleReadyCrouch", this.ADMHJLIOEAD);
				this.KNHGHJNBEMN.SetTexture("", this.NMDKEMKAOJA);
				this.KNHGHJNBEMN.SetTexture("", this.LCDFFHCHPGC);
				this.KNHGHJNBEMN.SetFloat("Climb to the top of the mountain to see the clouds (WASD keys to move).", this.saturation);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.KNHGHJNBEMN);
			}
			else
			{
				this.IAHELJAHCED.SetTexture("cntx_close", this.ADMHJLIOEAD);
				this.IAHELJAHCED.SetFloat("byte:", this.saturation);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.IAHELJAHCED);
			}
			if (this.selectiveCc)
			{
				this.IBBKCHHBMAP.SetColor("SAMPLES_VERY_LOW", this.selectiveFromColor);
				this.IBBKCHHBMAP.SetColor("GrounderIK does not support FullBodyBipedIK, use CCDIK, FABRIK, LimbIK or TrigonometricIK instead. If you want to use FullBodyBipedIK, use the GrounderFBBIK component.", this.selectiveToColor);
				Graphics.Blit(renderTexture, OKIIDHIJBEA, this.IBBKCHHBMAP);
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600B50E RID: 46350 RVA: 0x00501FC4 File Offset: 0x005001C4
		private void OnRenderImage(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.KEGMOAALLHK)
			{
				this.UpdateParameters();
				this.KEGMOAALLHK = false;
			}
			if (this.useDepthCorrection)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			RenderTexture renderTexture = OKIIDHIJBEA;
			if (this.selectiveCc)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
			}
			if (this.useDepthCorrection)
			{
				this.KNHGHJNBEMN.SetTexture("_RgbTex", this.ADMHJLIOEAD);
				this.KNHGHJNBEMN.SetTexture("_ZCurve", this.NMDKEMKAOJA);
				this.KNHGHJNBEMN.SetTexture("_RgbDepthTex", this.LCDFFHCHPGC);
				this.KNHGHJNBEMN.SetFloat("_Saturation", this.saturation);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.KNHGHJNBEMN);
			}
			else
			{
				this.IAHELJAHCED.SetTexture("_RgbTex", this.ADMHJLIOEAD);
				this.IAHELJAHCED.SetFloat("_Saturation", this.saturation);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.IAHELJAHCED);
			}
			if (this.selectiveCc)
			{
				this.IBBKCHHBMAP.SetColor("selColor", this.selectiveFromColor);
				this.IBBKCHHBMAP.SetColor("targetColor", this.selectiveToColor);
				Graphics.Blit(renderTexture, OKIIDHIJBEA, this.IBBKCHHBMAP);
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600B50F RID: 46351 RVA: 0x0050211C File Offset: 0x0050031C
		private void BCIGENDLOJL()
		{
			this.HGPBMONAEKB();
		}

		// Token: 0x0600B510 RID: 46352 RVA: 0x00022FCC File Offset: 0x000211CC
		private void ECOOMJKPKCC()
		{
		}

		// Token: 0x0600B511 RID: 46353 RVA: 0x00502124 File Offset: 0x00500324
		public void HGPBMONAEKB()
		{
			this.BOFHDNBNAOA();
			if (this.redChannel != null && this.greenChannel != null && this.blueChannel != null)
			{
				for (float num = 1579f; num <= 724f; num += 1079f)
				{
					float num2 = Mathf.Clamp(this.redChannel.Evaluate(num), 1370f, 810f);
					float num3 = Mathf.Clamp(this.greenChannel.Evaluate(num), 109f, 1912f);
					float num4 = Mathf.Clamp(this.blueChannel.Evaluate(num), 1937f, 824f);
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 555f), 1, new Color(num2, num2, num2));
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 1763f), 0, new Color(num3, num3, num3));
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 251f), 0, new Color(num4, num4, num4));
					float num5 = Mathf.Clamp(this.zCurve.Evaluate(num), 1022f, 537f);
					this.NMDKEMKAOJA.SetPixel((int)Mathf.Floor(num * 855f), 0, new Color(num5, num5, num5));
					num2 = Mathf.Clamp(this.depthRedChannel.Evaluate(num), 783f, 840f);
					num3 = Mathf.Clamp(this.depthGreenChannel.Evaluate(num), 1910f, 1520f);
					num4 = Mathf.Clamp(this.depthBlueChannel.Evaluate(num), 156f, 79f);
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 214f), 1, new Color(num2, num2, num2));
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 233f), 1, new Color(num3, num3, num3));
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 416f), 6, new Color(num4, num4, num4));
				}
				this.ADMHJLIOEAD.Apply();
				this.LCDFFHCHPGC.Apply();
				this.NMDKEMKAOJA.Apply();
			}
		}

		// Token: 0x0600B512 RID: 46354 RVA: 0x00502347 File Offset: 0x00500547
		private void KEIILPMCFEO()
		{
			base.CKGPEFOKKNL();
			this.KEGMOAALLHK = true;
		}

		// Token: 0x0600B513 RID: 46355 RVA: 0x00502356 File Offset: 0x00500556
		private void CJIGAIMNONC()
		{
			this.CDMBILDBHGE();
		}

		// Token: 0x0600B514 RID: 46356 RVA: 0x00502360 File Offset: 0x00500560
		public void DMNEOLILBGB()
		{
			this.BOFHDNBNAOA();
			if (this.redChannel != null && this.greenChannel != null && this.blueChannel != null)
			{
				for (float num = 1832f; num <= 1377f; num += 400f)
				{
					float num2 = Mathf.Clamp(this.redChannel.Evaluate(num), 804f, 460f);
					float num3 = Mathf.Clamp(this.greenChannel.Evaluate(num), 1459f, 1961f);
					float num4 = Mathf.Clamp(this.blueChannel.Evaluate(num), 1542f, 1271f);
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 198f), 1, new Color(num2, num2, num2));
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 1022f), 1, new Color(num3, num3, num3));
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 1225f), 0, new Color(num4, num4, num4));
					float num5 = Mathf.Clamp(this.zCurve.Evaluate(num), 1176f, 746f);
					this.NMDKEMKAOJA.SetPixel((int)Mathf.Floor(num * 186f), 1, new Color(num5, num5, num5));
					num2 = Mathf.Clamp(this.depthRedChannel.Evaluate(num), 1974f, 1013f);
					num3 = Mathf.Clamp(this.depthGreenChannel.Evaluate(num), 1754f, 743f);
					num4 = Mathf.Clamp(this.depthBlueChannel.Evaluate(num), 1654f, 1562f);
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 163f), 1, new Color(num2, num2, num2));
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 1787f), 1, new Color(num3, num3, num3));
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 310f), 6, new Color(num4, num4, num4));
				}
				this.ADMHJLIOEAD.Apply();
				this.LCDFFHCHPGC.Apply();
				this.NMDKEMKAOJA.Apply();
			}
		}

		// Token: 0x0600B515 RID: 46357 RVA: 0x00502583 File Offset: 0x00500783
		private void LFAAGBJGEAI()
		{
			this.BDDBECDBEDP();
		}

		// Token: 0x0600B516 RID: 46358 RVA: 0x00022FCC File Offset: 0x000211CC
		private void CJCGPPJADJL()
		{
		}

		// Token: 0x0600B517 RID: 46359 RVA: 0x00022FCC File Offset: 0x000211CC
		private void COOHBKKNOLG()
		{
		}

		// Token: 0x0600B518 RID: 46360 RVA: 0x0050258C File Offset: 0x0050078C
		private void EFEHHALJILL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.KEGMOAALLHK)
			{
				this.DMNEOLILBGB();
				this.KEGMOAALLHK = false;
			}
			if (this.useDepthCorrection)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			RenderTexture renderTexture = OKIIDHIJBEA;
			if (this.selectiveCc)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
			}
			if (this.useDepthCorrection)
			{
				this.KNHGHJNBEMN.SetTexture("Detects common types of wall hack cheating: walking through the walls (Rigidbody and CharacterController modules), shooting through the walls (Raycast module), looking through the walls (Wireframe module).", this.ADMHJLIOEAD);
				this.KNHGHJNBEMN.SetTexture("chan_head", this.NMDKEMKAOJA);
				this.KNHGHJNBEMN.SetTexture("TOD_kBetaMie", this.LCDFFHCHPGC);
				this.KNHGHJNBEMN.SetFloat("_ReflectionTex", this.saturation);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.KNHGHJNBEMN);
			}
			else
			{
				this.IAHELJAHCED.SetTexture("<color='#002030'>+{0} {1}</color>", this.ADMHJLIOEAD);
				this.IAHELJAHCED.SetFloat("PistolReady", this.saturation);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.IAHELJAHCED);
			}
			if (this.selectiveCc)
			{
				this.IBBKCHHBMAP.SetColor("cash.ogg", this.selectiveFromColor);
				this.IBBKCHHBMAP.SetColor("SoccerRun", this.selectiveToColor);
				Graphics.Blit(renderTexture, OKIIDHIJBEA, this.IBBKCHHBMAP);
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600B519 RID: 46361 RVA: 0x005026E4 File Offset: 0x005008E4
		public virtual bool DPGLLLMLAAB()
		{
			base.EHGENDOEHLP(this.mode == ColorCorrectionCurves.CGIEPIJKBID.Advanced);
			this.IAHELJAHCED = base.IIIIADNBONI(this.simpleColorCorrectionCurvesShader, this.IAHELJAHCED);
			this.KNHGHJNBEMN = base.JBHLGBPJFEL(this.colorCorrectionCurvesShader, this.KNHGHJNBEMN);
			this.IBBKCHHBMAP = base.JBHLGBPJFEL(this.colorCorrectionSelectiveShader, this.IBBKCHHBMAP);
			if (!this.ADMHJLIOEAD)
			{
				this.ADMHJLIOEAD = new Texture2D(195, 6, TextureFormat.RGBA32, false, true);
			}
			if (!this.LCDFFHCHPGC)
			{
				this.LCDFFHCHPGC = new Texture2D(193, 8, TextureFormat.RGB565, false, false);
			}
			if (!this.NMDKEMKAOJA)
			{
				this.NMDKEMKAOJA = new Texture2D(-36, 1, TextureFormat.ARGB4444, true, true);
			}
			this.ADMHJLIOEAD.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			this.LCDFFHCHPGC.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable);
			this.NMDKEMKAOJA.hideFlags = (HideFlags)120;
			this.ADMHJLIOEAD.wrapMode = TextureWrapMode.Repeat;
			this.LCDFFHCHPGC.wrapMode = TextureWrapMode.Repeat;
			this.NMDKEMKAOJA.wrapMode = TextureWrapMode.Repeat;
			if (!this.PPGOAMIHMBG)
			{
				base.INOGPLDHPGC();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B51A RID: 46362 RVA: 0x0050280C File Offset: 0x00500A0C
		public void BDDBECDBEDP()
		{
			this.MNDOFMMGLMO();
			if (this.redChannel != null && this.greenChannel != null && this.blueChannel != null)
			{
				for (float num = 1119f; num <= 1265f; num += 666f)
				{
					float num2 = Mathf.Clamp(this.redChannel.Evaluate(num), 1291f, 712f);
					float num3 = Mathf.Clamp(this.greenChannel.Evaluate(num), 1863f, 381f);
					float num4 = Mathf.Clamp(this.blueChannel.Evaluate(num), 1363f, 350f);
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 1794f), 1, new Color(num2, num2, num2));
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 207f), 1, new Color(num3, num3, num3));
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 179f), 3, new Color(num4, num4, num4));
					float num5 = Mathf.Clamp(this.zCurve.Evaluate(num), 1527f, 1633f);
					this.NMDKEMKAOJA.SetPixel((int)Mathf.Floor(num * 593f), 1, new Color(num5, num5, num5));
					num2 = Mathf.Clamp(this.depthRedChannel.Evaluate(num), 1785f, 1709f);
					num3 = Mathf.Clamp(this.depthGreenChannel.Evaluate(num), 342f, 1750f);
					num4 = Mathf.Clamp(this.depthBlueChannel.Evaluate(num), 880f, 1621f);
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 1502f), 0, new Color(num2, num2, num2));
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 1769f), 1, new Color(num3, num3, num3));
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 409f), 4, new Color(num4, num4, num4));
				}
				this.ADMHJLIOEAD.Apply();
				this.LCDFFHCHPGC.Apply();
				this.NMDKEMKAOJA.Apply();
			}
		}

		// Token: 0x0600B51B RID: 46363 RVA: 0x00502A2F File Offset: 0x00500C2F
		private void IDKLAJEFJDG()
		{
			this.UpdateParameters();
		}

		// Token: 0x0600B51C RID: 46364 RVA: 0x00502A38 File Offset: 0x00500C38
		public virtual bool LKFFFIBABBF()
		{
			base.DAOKCAOFIGE(this.mode == ColorCorrectionCurves.CGIEPIJKBID.Simple);
			this.IAHELJAHCED = base.BOOFEOGDMBI(this.simpleColorCorrectionCurvesShader, this.IAHELJAHCED);
			this.KNHGHJNBEMN = base.BAPJBHPEDIF(this.colorCorrectionCurvesShader, this.KNHGHJNBEMN);
			this.IBBKCHHBMAP = base.IIIIADNBONI(this.colorCorrectionSelectiveShader, this.IBBKCHHBMAP);
			if (!this.ADMHJLIOEAD)
			{
				this.ADMHJLIOEAD = new Texture2D(102, 8, TextureFormat.RGB24, true, true);
			}
			if (!this.LCDFFHCHPGC)
			{
				this.LCDFFHCHPGC = new Texture2D(-152, 7, TextureFormat.Alpha8, true, true);
			}
			if (!this.NMDKEMKAOJA)
			{
				this.NMDKEMKAOJA = new Texture2D(-84, 1, TextureFormat.Alpha8, false, true);
			}
			this.ADMHJLIOEAD.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			this.LCDFFHCHPGC.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
			this.NMDKEMKAOJA.hideFlags = (HideFlags)70;
			this.ADMHJLIOEAD.wrapMode = TextureWrapMode.Clamp;
			this.LCDFFHCHPGC.wrapMode = TextureWrapMode.Clamp;
			this.NMDKEMKAOJA.wrapMode = TextureWrapMode.Repeat;
			if (!this.PPGOAMIHMBG)
			{
				base.LNEHBOJIBAI();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B51D RID: 46365 RVA: 0x00500ECB File Offset: 0x004FF0CB
		private void FNBGGJJLIGG()
		{
			base.GGBMJFNGHMC();
			this.KEGMOAALLHK = false;
		}

		// Token: 0x0600B51E RID: 46366 RVA: 0x00502B60 File Offset: 0x00500D60
		private void DHBJPMCMCJJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.KEGMOAALLHK)
			{
				this.HGPBMONAEKB();
				this.KEGMOAALLHK = true;
			}
			if (this.useDepthCorrection)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			RenderTexture renderTexture = OKIIDHIJBEA;
			if (this.selectiveCc)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
			}
			if (this.useDepthCorrection)
			{
				this.KNHGHJNBEMN.SetTexture("Antares", this.ADMHJLIOEAD);
				this.KNHGHJNBEMN.SetTexture("<b>Obscured types:</b>\n<color=\"#75C4EB\">", this.NMDKEMKAOJA);
				this.KNHGHJNBEMN.SetTexture("'>  > ", this.LCDFFHCHPGC);
				this.KNHGHJNBEMN.SetFloat("_LerpRgbTex", this.saturation);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.KNHGHJNBEMN);
			}
			else
			{
				this.IAHELJAHCED.SetTexture("WorkerShovel", this.ADMHJLIOEAD);
				this.IAHELJAHCED.SetFloat(" ", this.saturation);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.IAHELJAHCED);
			}
			if (this.selectiveCc)
			{
				this.IBBKCHHBMAP.SetColor("Identity LUT", this.selectiveFromColor);
				this.IBBKCHHBMAP.SetColor("getfish", this.selectiveToColor);
				Graphics.Blit(renderTexture, OKIIDHIJBEA, this.IBBKCHHBMAP);
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600B51F RID: 46367 RVA: 0x00502356 File Offset: 0x00500556
		private void LEABKMEPJKM()
		{
			this.CDMBILDBHGE();
		}

		// Token: 0x0600B520 RID: 46368 RVA: 0x00502CB8 File Offset: 0x00500EB8
		public void PLDFOBJOHKO()
		{
			this.BOFHDNBNAOA();
			if (this.redChannel != null && this.greenChannel != null && this.blueChannel != null)
			{
				for (float num = 23f; num <= 1044f; num += 1313f)
				{
					float num2 = Mathf.Clamp(this.redChannel.Evaluate(num), 1783f, 1003f);
					float num3 = Mathf.Clamp(this.greenChannel.Evaluate(num), 1220f, 165f);
					float num4 = Mathf.Clamp(this.blueChannel.Evaluate(num), 1846f, 1988f);
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 1903f), 1, new Color(num2, num2, num2));
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 1700f), 1, new Color(num3, num3, num3));
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 418f), 3, new Color(num4, num4, num4));
					float num5 = Mathf.Clamp(this.zCurve.Evaluate(num), 483f, 974f);
					this.NMDKEMKAOJA.SetPixel((int)Mathf.Floor(num * 306f), 0, new Color(num5, num5, num5));
					num2 = Mathf.Clamp(this.depthRedChannel.Evaluate(num), 445f, 437f);
					num3 = Mathf.Clamp(this.depthGreenChannel.Evaluate(num), 1704f, 520f);
					num4 = Mathf.Clamp(this.depthBlueChannel.Evaluate(num), 1305f, 1402f);
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 72f), 1, new Color(num2, num2, num2));
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 1192f), 0, new Color(num3, num3, num3));
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 1472f), 0, new Color(num4, num4, num4));
				}
				this.ADMHJLIOEAD.Apply();
				this.LCDFFHCHPGC.Apply();
				this.NMDKEMKAOJA.Apply();
			}
		}

		// Token: 0x0600B521 RID: 46369 RVA: 0x00502EDC File Offset: 0x005010DC
		public void UpdateParameters()
		{
			this.CheckResources();
			if (this.redChannel != null && this.greenChannel != null && this.blueChannel != null)
			{
				for (float num = 0f; num <= 1f; num += 0.003921569f)
				{
					float num2 = Mathf.Clamp(this.redChannel.Evaluate(num), 0f, 1f);
					float num3 = Mathf.Clamp(this.greenChannel.Evaluate(num), 0f, 1f);
					float num4 = Mathf.Clamp(this.blueChannel.Evaluate(num), 0f, 1f);
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 255f), 0, new Color(num2, num2, num2));
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 255f), 1, new Color(num3, num3, num3));
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 255f), 2, new Color(num4, num4, num4));
					float num5 = Mathf.Clamp(this.zCurve.Evaluate(num), 0f, 1f);
					this.NMDKEMKAOJA.SetPixel((int)Mathf.Floor(num * 255f), 0, new Color(num5, num5, num5));
					num2 = Mathf.Clamp(this.depthRedChannel.Evaluate(num), 0f, 1f);
					num3 = Mathf.Clamp(this.depthGreenChannel.Evaluate(num), 0f, 1f);
					num4 = Mathf.Clamp(this.depthBlueChannel.Evaluate(num), 0f, 1f);
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 255f), 0, new Color(num2, num2, num2));
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 255f), 1, new Color(num3, num3, num3));
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 255f), 2, new Color(num4, num4, num4));
				}
				this.ADMHJLIOEAD.Apply();
				this.LCDFFHCHPGC.Apply();
				this.NMDKEMKAOJA.Apply();
			}
		}

		// Token: 0x0600B522 RID: 46370 RVA: 0x00022FCC File Offset: 0x000211CC
		private void CNKLGMCHEBM()
		{
		}

		// Token: 0x0600B523 RID: 46371 RVA: 0x00022FCC File Offset: 0x000211CC
		private void GFFOMGLOMAC()
		{
		}

		// Token: 0x0600B524 RID: 46372 RVA: 0x00502356 File Offset: 0x00500556
		private void NDMKCOEOAAI()
		{
			this.CDMBILDBHGE();
		}

		// Token: 0x0600B525 RID: 46373 RVA: 0x00022FCC File Offset: 0x000211CC
		private void BDHBAJMJGLK()
		{
		}

		// Token: 0x0600B526 RID: 46374 RVA: 0x00022FCC File Offset: 0x000211CC
		private void HBOJKOIJJDM()
		{
		}

		// Token: 0x0600B527 RID: 46375 RVA: 0x005030FF File Offset: 0x005012FF
		private void JLKBMEBFHBI()
		{
			base.APPLKMOGAMJ();
			this.KEGMOAALLHK = false;
		}

		// Token: 0x0600B528 RID: 46376 RVA: 0x00503110 File Offset: 0x00501310
		public virtual bool LNHMJPEKJPH()
		{
			base.CDBNBLBOLCL(this.mode == ColorCorrectionCurves.CGIEPIJKBID.Simple);
			this.IAHELJAHCED = base.JBHLGBPJFEL(this.simpleColorCorrectionCurvesShader, this.IAHELJAHCED);
			this.KNHGHJNBEMN = base.DJFOEIJIMJB(this.colorCorrectionCurvesShader, this.KNHGHJNBEMN);
			this.IBBKCHHBMAP = base.IIIIADNBONI(this.colorCorrectionSelectiveShader, this.IBBKCHHBMAP);
			if (!this.ADMHJLIOEAD)
			{
				this.ADMHJLIOEAD = new Texture2D(-30, 4, TextureFormat.RGB565, false, false);
			}
			if (!this.LCDFFHCHPGC)
			{
				this.LCDFFHCHPGC = new Texture2D(-188, 6, (TextureFormat)8, true, false);
			}
			if (!this.NMDKEMKAOJA)
			{
				this.NMDKEMKAOJA = new Texture2D(79, 0, (TextureFormat)6, true, false);
			}
			this.ADMHJLIOEAD.hideFlags = (HideFlags)(-124);
			this.LCDFFHCHPGC.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
			this.NMDKEMKAOJA.hideFlags = (HideFlags)(-82);
			this.ADMHJLIOEAD.wrapMode = TextureWrapMode.Clamp;
			this.LCDFFHCHPGC.wrapMode = TextureWrapMode.Clamp;
			this.NMDKEMKAOJA.wrapMode = TextureWrapMode.Repeat;
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B529 RID: 46377 RVA: 0x00503237 File Offset: 0x00501437
		private void OPNPODKLOJK()
		{
			base.EFJDBBDMPMC();
			this.KEGMOAALLHK = false;
		}

		// Token: 0x0600B52A RID: 46378 RVA: 0x00503248 File Offset: 0x00501448
		public virtual bool FCIOAHEKFIG()
		{
			base.OLMOAHDIDNG(this.mode == ColorCorrectionCurves.CGIEPIJKBID.Advanced);
			this.IAHELJAHCED = base.BAPJBHPEDIF(this.simpleColorCorrectionCurvesShader, this.IAHELJAHCED);
			this.KNHGHJNBEMN = base.BOOFEOGDMBI(this.colorCorrectionCurvesShader, this.KNHGHJNBEMN);
			this.IBBKCHHBMAP = base.DJFOEIJIMJB(this.colorCorrectionSelectiveShader, this.IBBKCHHBMAP);
			if (!this.ADMHJLIOEAD)
			{
				this.ADMHJLIOEAD = new Texture2D(170, 3, (TextureFormat)6, true, false);
			}
			if (!this.LCDFFHCHPGC)
			{
				this.LCDFFHCHPGC = new Texture2D(125, 6, (TextureFormat)0, false, true);
			}
			if (!this.NMDKEMKAOJA)
			{
				this.NMDKEMKAOJA = new Texture2D(41, 1, TextureFormat.Alpha8, false, false);
			}
			this.ADMHJLIOEAD.hideFlags = (HideFlags)88;
			this.LCDFFHCHPGC.hideFlags = (HideFlags)(-99);
			this.NMDKEMKAOJA.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			this.ADMHJLIOEAD.wrapMode = TextureWrapMode.Clamp;
			this.LCDFFHCHPGC.wrapMode = TextureWrapMode.Repeat;
			this.NMDKEMKAOJA.wrapMode = TextureWrapMode.Clamp;
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B52B RID: 46379 RVA: 0x00502347 File Offset: 0x00500547
		private void NOKJMMDMJNO()
		{
			base.CKGPEFOKKNL();
			this.KEGMOAALLHK = true;
		}

		// Token: 0x0600B52C RID: 46380 RVA: 0x00500640 File Offset: 0x004FE840
		private void GDIMBBBPIHI()
		{
			base.OBJCOJEHLBE();
			this.KEGMOAALLHK = false;
		}

		// Token: 0x0600B52D RID: 46381 RVA: 0x00503237 File Offset: 0x00501437
		private void PFNPOHMMJDN()
		{
			base.EFJDBBDMPMC();
			this.KEGMOAALLHK = false;
		}

		// Token: 0x0600B52E RID: 46382 RVA: 0x0050336F File Offset: 0x0050156F
		private void LCBIFGKANMD()
		{
			base.EFJDBBDMPMC();
			this.KEGMOAALLHK = true;
		}

		// Token: 0x0600B52F RID: 46383 RVA: 0x00503380 File Offset: 0x00501580
		private void JEHHGMJKLPB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NHEEDPALBFN())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.KEGMOAALLHK)
			{
				this.JNPCNOCKOJF();
				this.KEGMOAALLHK = true;
			}
			if (this.useDepthCorrection)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			RenderTexture renderTexture = OKIIDHIJBEA;
			if (this.selectiveCc)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
			}
			if (this.useDepthCorrection)
			{
				this.KNHGHJNBEMN.SetTexture("", this.ADMHJLIOEAD);
				this.KNHGHJNBEMN.SetTexture("<color='#a060ff'>{0}</color>: {1}", this.NMDKEMKAOJA);
				this.KNHGHJNBEMN.SetTexture("PistolLeftHandStab", this.LCDFFHCHPGC);
				this.KNHGHJNBEMN.SetFloat("IceHockeySlapShot", this.saturation);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.KNHGHJNBEMN);
			}
			else
			{
				this.IAHELJAHCED.SetTexture("UIChat_fontInterval", this.ADMHJLIOEAD);
				this.IAHELJAHCED.SetFloat("/", this.saturation);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.IAHELJAHCED);
			}
			if (this.selectiveCc)
			{
				this.IBBKCHHBMAP.SetColor("UnityEngine.Vector2", this.selectiveFromColor);
				this.IBBKCHHBMAP.SetColor("_NoisePerChannel", this.selectiveToColor);
				Graphics.Blit(renderTexture, OKIIDHIJBEA, this.IBBKCHHBMAP);
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600B530 RID: 46384 RVA: 0x005034D8 File Offset: 0x005016D8
		private void GHJHBHOMELE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.GGJKGIHGMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.KEGMOAALLHK)
			{
				this.UpdateParameters();
				this.KEGMOAALLHK = true;
			}
			if (this.useDepthCorrection)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			RenderTexture renderTexture = OKIIDHIJBEA;
			if (this.selectiveCc)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
			}
			if (this.useDepthCorrection)
			{
				this.KNHGHJNBEMN.SetTexture("WalkDehydrated", this.ADMHJLIOEAD);
				this.KNHGHJNBEMN.SetTexture("MovementZ", this.NMDKEMKAOJA);
				this.KNHGHJNBEMN.SetTexture("StartRigidModule", this.LCDFFHCHPGC);
				this.KNHGHJNBEMN.SetFloat("{0:D2}:{1:D2}", this.saturation);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.KNHGHJNBEMN);
			}
			else
			{
				this.IAHELJAHCED.SetTexture("SoccerKeeperStrafeLeft", this.ADMHJLIOEAD);
				this.IAHELJAHCED.SetFloat("camouflage_intens", this.saturation);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.IAHELJAHCED);
			}
			if (this.selectiveCc)
			{
				this.IBBKCHHBMAP.SetColor("WallRunRight", this.selectiveFromColor);
				this.IBBKCHHBMAP.SetColor("360SpinDeath", this.selectiveToColor);
				Graphics.Blit(renderTexture, OKIIDHIJBEA, this.IBBKCHHBMAP);
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600B531 RID: 46385 RVA: 0x00503630 File Offset: 0x00501830
		public void MLMBOAKJFKB()
		{
			this.NIFOFLEPKIB();
			if (this.redChannel != null && this.greenChannel != null && this.blueChannel != null)
			{
				for (float num = 1046f; num <= 1028f; num += 374f)
				{
					float num2 = Mathf.Clamp(this.redChannel.Evaluate(num), 823f, 548f);
					float num3 = Mathf.Clamp(this.greenChannel.Evaluate(num), 766f, 1848f);
					float num4 = Mathf.Clamp(this.blueChannel.Evaluate(num), 951f, 1969f);
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 1706f), 1, new Color(num2, num2, num2));
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 485f), 0, new Color(num3, num3, num3));
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 777f), 1, new Color(num4, num4, num4));
					float num5 = Mathf.Clamp(this.zCurve.Evaluate(num), 1809f, 1044f);
					this.NMDKEMKAOJA.SetPixel((int)Mathf.Floor(num * 420f), 1, new Color(num5, num5, num5));
					num2 = Mathf.Clamp(this.depthRedChannel.Evaluate(num), 1789f, 768f);
					num3 = Mathf.Clamp(this.depthGreenChannel.Evaluate(num), 224f, 1578f);
					num4 = Mathf.Clamp(this.depthBlueChannel.Evaluate(num), 329f, 1569f);
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 923f), 0, new Color(num2, num2, num2));
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 1339f), 1, new Color(num3, num3, num3));
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 1320f), 4, new Color(num4, num4, num4));
				}
				this.ADMHJLIOEAD.Apply();
				this.LCDFFHCHPGC.Apply();
				this.NMDKEMKAOJA.Apply();
			}
		}

		// Token: 0x0600B532 RID: 46386 RVA: 0x00503854 File Offset: 0x00501A54
		private void MIJCMMIJPEE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.KEGMOAALLHK)
			{
				this.DMNEOLILBGB();
				this.KEGMOAALLHK = false;
			}
			if (this.useDepthCorrection)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			RenderTexture renderTexture = OKIIDHIJBEA;
			if (this.selectiveCc)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
			}
			if (this.useDepthCorrection)
			{
				this.KNHGHJNBEMN.SetTexture("", this.ADMHJLIOEAD);
				this.KNHGHJNBEMN.SetTexture("<color='#60a0ff'>{0}</color>\n<color='#ffff60'>Всего выловлено: <color='#ffffa0'>{1}</color> шт Общим весом <color='#ffffa0'>{2}</color>\nЛичный рекорд <color='#ffffa0'>{3}</color> </color>", this.NMDKEMKAOJA);
				this.KNHGHJNBEMN.SetTexture("cntx_close", this.LCDFFHCHPGC);
				this.KNHGHJNBEMN.SetFloat("Flares", this.saturation);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.KNHGHJNBEMN);
			}
			else
			{
				this.IAHELJAHCED.SetTexture("Horizontal", this.ADMHJLIOEAD);
				this.IAHELJAHCED.SetFloat("wpn_onlym", this.saturation);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.IAHELJAHCED);
			}
			if (this.selectiveCc)
			{
				this.IBBKCHHBMAP.SetColor("-none: ", this.selectiveFromColor);
				this.IBBKCHHBMAP.SetColor("wpn_add/addoptions", this.selectiveToColor);
				Graphics.Blit(renderTexture, OKIIDHIJBEA, this.IBBKCHHBMAP);
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600B533 RID: 46387 RVA: 0x00022FCC File Offset: 0x000211CC
		private void PFKOLCOAPCN()
		{
		}

		// Token: 0x0600B534 RID: 46388 RVA: 0x00501953 File Offset: 0x004FFB53
		private void CFENINOPJAP()
		{
			this.GAIMMCKHHLN();
		}

		// Token: 0x0600B535 RID: 46389 RVA: 0x005039AC File Offset: 0x00501BAC
		private void PJOKECOHKGN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.GGJKGIHGMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.KEGMOAALLHK)
			{
				this.EOPCBNJKAPP();
				this.KEGMOAALLHK = true;
			}
			if (this.useDepthCorrection)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			RenderTexture renderTexture = OKIIDHIJBEA;
			if (this.selectiveCc)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
			}
			if (this.useDepthCorrection)
			{
				this.KNHGHJNBEMN.SetTexture("<color='#206000'>", this.ADMHJLIOEAD);
				this.KNHGHJNBEMN.SetTexture("WorkerHammer2", this.NMDKEMKAOJA);
				this.KNHGHJNBEMN.SetTexture("<color='#000030'>", this.LCDFFHCHPGC);
				this.KNHGHJNBEMN.SetFloat("reel_type", this.saturation);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.KNHGHJNBEMN);
			}
			else
			{
				this.IAHELJAHCED.SetTexture("inv already open", this.ADMHJLIOEAD);
				this.IAHELJAHCED.SetFloat("H ", this.saturation);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.IAHELJAHCED);
			}
			if (this.selectiveCc)
			{
				this.IBBKCHHBMAP.SetColor("PLANE_REFLECTION", this.selectiveFromColor);
				this.IBBKCHHBMAP.SetColor("gi_tit_ch", this.selectiveToColor);
				Graphics.Blit(renderTexture, OKIIDHIJBEA, this.IBBKCHHBMAP);
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600B536 RID: 46390 RVA: 0x00022FCC File Offset: 0x000211CC
		private void KKBJCEMFEEI()
		{
		}

		// Token: 0x0600B537 RID: 46391 RVA: 0x005000C6 File Offset: 0x004FE2C6
		private void CHDJGEOFHEE()
		{
			base.APPLKMOGAMJ();
			this.KEGMOAALLHK = true;
		}

		// Token: 0x0600B538 RID: 46392 RVA: 0x00503B04 File Offset: 0x00501D04
		private void NBJKFLNHFOF(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.KEGMOAALLHK)
			{
				this.HGPBMONAEKB();
				this.KEGMOAALLHK = false;
			}
			if (this.useDepthCorrection)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			RenderTexture renderTexture = OKIIDHIJBEA;
			if (this.selectiveCc)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
			}
			if (this.useDepthCorrection)
			{
				this.KNHGHJNBEMN.SetTexture("SoccerWalk", this.ADMHJLIOEAD);
				this.KNHGHJNBEMN.SetTexture("_ReflectionTexture4", this.NMDKEMKAOJA);
				this.KNHGHJNBEMN.SetTexture("PrimaryCausticsProjector", this.LCDFFHCHPGC);
				this.KNHGHJNBEMN.SetFloat("_Refraction", this.saturation);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.KNHGHJNBEMN);
			}
			else
			{
				this.IAHELJAHCED.SetTexture("_TapHigh", this.ADMHJLIOEAD);
				this.IAHELJAHCED.SetFloat("RollerBladeJump", this.saturation);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.IAHELJAHCED);
			}
			if (this.selectiveCc)
			{
				this.IBBKCHHBMAP.SetColor("crft_selwpn", this.selectiveFromColor);
				this.IBBKCHHBMAP.SetColor("LookUp", this.selectiveToColor);
				Graphics.Blit(renderTexture, OKIIDHIJBEA, this.IBBKCHHBMAP);
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600B539 RID: 46393 RVA: 0x00503C5C File Offset: 0x00501E5C
		public void NJLGHHNNICL()
		{
			this.NIFOFLEPKIB();
			if (this.redChannel != null && this.greenChannel != null && this.blueChannel != null)
			{
				for (float num = 964f; num <= 1869f; num += 162f)
				{
					float num2 = Mathf.Clamp(this.redChannel.Evaluate(num), 1500f, 447f);
					float num3 = Mathf.Clamp(this.greenChannel.Evaluate(num), 321f, 727f);
					float num4 = Mathf.Clamp(this.blueChannel.Evaluate(num), 206f, 1272f);
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 1855f), 0, new Color(num2, num2, num2));
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 97f), 1, new Color(num3, num3, num3));
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 1841f), 1, new Color(num4, num4, num4));
					float num5 = Mathf.Clamp(this.zCurve.Evaluate(num), 280f, 513f);
					this.NMDKEMKAOJA.SetPixel((int)Mathf.Floor(num * 676f), 0, new Color(num5, num5, num5));
					num2 = Mathf.Clamp(this.depthRedChannel.Evaluate(num), 574f, 1266f);
					num3 = Mathf.Clamp(this.depthGreenChannel.Evaluate(num), 237f, 1606f);
					num4 = Mathf.Clamp(this.depthBlueChannel.Evaluate(num), 443f, 1665f);
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 1246f), 0, new Color(num2, num2, num2));
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 1780f), 0, new Color(num3, num3, num3));
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 950f), 8, new Color(num4, num4, num4));
				}
				this.ADMHJLIOEAD.Apply();
				this.LCDFFHCHPGC.Apply();
				this.NMDKEMKAOJA.Apply();
			}
		}

		// Token: 0x0600B53A RID: 46394 RVA: 0x00503E80 File Offset: 0x00502080
		public virtual bool DKMLGBCDFLG()
		{
			base.CDBNBLBOLCL(this.mode == ColorCorrectionCurves.CGIEPIJKBID.Simple);
			this.IAHELJAHCED = base.BAPJBHPEDIF(this.simpleColorCorrectionCurvesShader, this.IAHELJAHCED);
			this.KNHGHJNBEMN = base.BAPJBHPEDIF(this.colorCorrectionCurvesShader, this.KNHGHJNBEMN);
			this.IBBKCHHBMAP = base.DJFOEIJIMJB(this.colorCorrectionSelectiveShader, this.IBBKCHHBMAP);
			if (!this.ADMHJLIOEAD)
			{
				this.ADMHJLIOEAD = new Texture2D(30, 0, (TextureFormat)8, true, false);
			}
			if (!this.LCDFFHCHPGC)
			{
				this.LCDFFHCHPGC = new Texture2D(7, 7, TextureFormat.RGBA32, false, false);
			}
			if (!this.NMDKEMKAOJA)
			{
				this.NMDKEMKAOJA = new Texture2D(-46, 1, TextureFormat.ARGB4444, false, false);
			}
			this.ADMHJLIOEAD.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
			this.LCDFFHCHPGC.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
			this.NMDKEMKAOJA.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			this.ADMHJLIOEAD.wrapMode = TextureWrapMode.Repeat;
			this.LCDFFHCHPGC.wrapMode = TextureWrapMode.Repeat;
			this.NMDKEMKAOJA.wrapMode = TextureWrapMode.Clamp;
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B53B RID: 46395 RVA: 0x00503FA8 File Offset: 0x005021A8
		private void EFPADLBDKCC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.MNDOFMMGLMO())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.KEGMOAALLHK)
			{
				this.GAIMMCKHHLN();
				this.KEGMOAALLHK = false;
			}
			if (this.useDepthCorrection)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			RenderTexture renderTexture = OKIIDHIJBEA;
			if (this.selectiveCc)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
			}
			if (this.useDepthCorrection)
			{
				this.KNHGHJNBEMN.SetTexture("post_5", this.ADMHJLIOEAD);
				this.KNHGHJNBEMN.SetTexture("ZombieCrawl", this.NMDKEMKAOJA);
				this.KNHGHJNBEMN.SetTexture("WeaponFire", this.LCDFFHCHPGC);
				this.KNHGHJNBEMN.SetFloat("</color>", this.saturation);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.KNHGHJNBEMN);
			}
			else
			{
				this.IAHELJAHCED.SetTexture("", this.ADMHJLIOEAD);
				this.IAHELJAHCED.SetFloat("RollerBladeFrontFlip", this.saturation);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.IAHELJAHCED);
			}
			if (this.selectiveCc)
			{
				this.IBBKCHHBMAP.SetColor(" ", this.selectiveFromColor);
				this.IBBKCHHBMAP.SetColor("priceCr", this.selectiveToColor);
				Graphics.Blit(renderTexture, OKIIDHIJBEA, this.IBBKCHHBMAP);
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600B53C RID: 46396 RVA: 0x00502A2F File Offset: 0x00500C2F
		private void CDDMOLLDGLK()
		{
			this.UpdateParameters();
		}

		// Token: 0x0600B53D RID: 46397 RVA: 0x0050336F File Offset: 0x0050156F
		private void BMNJGPIPKLL()
		{
			base.EFJDBBDMPMC();
			this.KEGMOAALLHK = true;
		}

		// Token: 0x0600B53E RID: 46398 RVA: 0x00500B03 File Offset: 0x004FED03
		private void MBGEKAFAOOE()
		{
			this.PLDFOBJOHKO();
		}

		// Token: 0x0600B53F RID: 46399 RVA: 0x00022FCC File Offset: 0x000211CC
		private void MBKLIKGAKJB()
		{
		}

		// Token: 0x0600B540 RID: 46400 RVA: 0x00502583 File Offset: 0x00500783
		private void BHNMPBLEJPF()
		{
			this.BDDBECDBEDP();
		}

		// Token: 0x0600B541 RID: 46401 RVA: 0x00504100 File Offset: 0x00502300
		public void HLPHPFJANJB()
		{
			this.IGJKBOMMMGC();
			if (this.redChannel != null && this.greenChannel != null && this.blueChannel != null)
			{
				for (float num = 1436f; num <= 1597f; num += 804f)
				{
					float num2 = Mathf.Clamp(this.redChannel.Evaluate(num), 716f, 1254f);
					float num3 = Mathf.Clamp(this.greenChannel.Evaluate(num), 1625f, 154f);
					float num4 = Mathf.Clamp(this.blueChannel.Evaluate(num), 509f, 1102f);
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 649f), 0, new Color(num2, num2, num2));
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 665f), 1, new Color(num3, num3, num3));
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 531f), 1, new Color(num4, num4, num4));
					float num5 = Mathf.Clamp(this.zCurve.Evaluate(num), 371f, 482f);
					this.NMDKEMKAOJA.SetPixel((int)Mathf.Floor(num * 1598f), 0, new Color(num5, num5, num5));
					num2 = Mathf.Clamp(this.depthRedChannel.Evaluate(num), 1461f, 1015f);
					num3 = Mathf.Clamp(this.depthGreenChannel.Evaluate(num), 937f, 1476f);
					num4 = Mathf.Clamp(this.depthBlueChannel.Evaluate(num), 903f, 439f);
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 357f), 0, new Color(num2, num2, num2));
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 327f), 1, new Color(num3, num3, num3));
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 1940f), 1, new Color(num4, num4, num4));
				}
				this.ADMHJLIOEAD.Apply();
				this.LCDFFHCHPGC.Apply();
				this.NMDKEMKAOJA.Apply();
			}
		}

		// Token: 0x0600B542 RID: 46402 RVA: 0x00502356 File Offset: 0x00500556
		private void BAPNPHGNEOJ()
		{
			this.CDMBILDBHGE();
		}

		// Token: 0x0600B543 RID: 46403 RVA: 0x00504324 File Offset: 0x00502524
		public void JNPCNOCKOJF()
		{
			this.PKHJBLJFIBF();
			if (this.redChannel != null && this.greenChannel != null && this.blueChannel != null)
			{
				for (float num = 476f; num <= 846f; num += 1688f)
				{
					float num2 = Mathf.Clamp(this.redChannel.Evaluate(num), 938f, 1590f);
					float num3 = Mathf.Clamp(this.greenChannel.Evaluate(num), 1349f, 1668f);
					float num4 = Mathf.Clamp(this.blueChannel.Evaluate(num), 527f, 1141f);
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 1735f), 1, new Color(num2, num2, num2));
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 157f), 1, new Color(num3, num3, num3));
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 121f), 6, new Color(num4, num4, num4));
					float num5 = Mathf.Clamp(this.zCurve.Evaluate(num), 1748f, 1543f);
					this.NMDKEMKAOJA.SetPixel((int)Mathf.Floor(num * 298f), 0, new Color(num5, num5, num5));
					num2 = Mathf.Clamp(this.depthRedChannel.Evaluate(num), 1416f, 931f);
					num3 = Mathf.Clamp(this.depthGreenChannel.Evaluate(num), 274f, 115f);
					num4 = Mathf.Clamp(this.depthBlueChannel.Evaluate(num), 1127f, 1645f);
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 416f), 1, new Color(num2, num2, num2));
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 835f), 1, new Color(num3, num3, num3));
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 1569f), 5, new Color(num4, num4, num4));
				}
				this.ADMHJLIOEAD.Apply();
				this.LCDFFHCHPGC.Apply();
				this.NMDKEMKAOJA.Apply();
			}
		}

		// Token: 0x0600B544 RID: 46404 RVA: 0x00504548 File Offset: 0x00502748
		public void HGJHELLIFDO()
		{
			this.CheckResources();
			if (this.redChannel != null && this.greenChannel != null && this.blueChannel != null)
			{
				for (float num = 480f; num <= 1758f; num += 1353f)
				{
					float num2 = Mathf.Clamp(this.redChannel.Evaluate(num), 866f, 1378f);
					float num3 = Mathf.Clamp(this.greenChannel.Evaluate(num), 668f, 1950f);
					float num4 = Mathf.Clamp(this.blueChannel.Evaluate(num), 872f, 1493f);
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 781f), 0, new Color(num2, num2, num2));
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 1809f), 0, new Color(num3, num3, num3));
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 767f), 4, new Color(num4, num4, num4));
					float num5 = Mathf.Clamp(this.zCurve.Evaluate(num), 214f, 110f);
					this.NMDKEMKAOJA.SetPixel((int)Mathf.Floor(num * 554f), 1, new Color(num5, num5, num5));
					num2 = Mathf.Clamp(this.depthRedChannel.Evaluate(num), 235f, 1649f);
					num3 = Mathf.Clamp(this.depthGreenChannel.Evaluate(num), 225f, 554f);
					num4 = Mathf.Clamp(this.depthBlueChannel.Evaluate(num), 896f, 891f);
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 28f), 1, new Color(num2, num2, num2));
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 1227f), 1, new Color(num3, num3, num3));
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 1524f), 3, new Color(num4, num4, num4));
				}
				this.ADMHJLIOEAD.Apply();
				this.LCDFFHCHPGC.Apply();
				this.NMDKEMKAOJA.Apply();
			}
		}

		// Token: 0x0600B545 RID: 46405 RVA: 0x00022FCC File Offset: 0x000211CC
		private void CEBAOOAIADJ()
		{
		}

		// Token: 0x0600B546 RID: 46406 RVA: 0x0050476C File Offset: 0x0050296C
		private void PHFJDPLOKJK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.KEGMOAALLHK)
			{
				this.EOPCBNJKAPP();
				this.KEGMOAALLHK = false;
			}
			if (this.useDepthCorrection)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			RenderTexture renderTexture = OKIIDHIJBEA;
			if (this.selectiveCc)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
			}
			if (this.useDepthCorrection)
			{
				this.KNHGHJNBEMN.SetTexture("_RgbTex", this.ADMHJLIOEAD);
				this.KNHGHJNBEMN.SetTexture("\n", this.NMDKEMKAOJA);
				this.KNHGHJNBEMN.SetTexture(" for ", this.LCDFFHCHPGC);
				this.KNHGHJNBEMN.SetFloat("Vertical", this.saturation);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.KNHGHJNBEMN);
			}
			else
			{
				this.IAHELJAHCED.SetTexture("", this.ADMHJLIOEAD);
				this.IAHELJAHCED.SetFloat("Mid", this.saturation);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.IAHELJAHCED);
			}
			if (this.selectiveCc)
			{
				this.IBBKCHHBMAP.SetColor(".unity3d", this.selectiveFromColor);
				this.IBBKCHHBMAP.SetColor("Textures/alphaDemo", this.selectiveToColor);
				Graphics.Blit(renderTexture, OKIIDHIJBEA, this.IBBKCHHBMAP);
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600B547 RID: 46407 RVA: 0x005048C4 File Offset: 0x00502AC4
		public virtual bool AHOEFCADHMC()
		{
			base.OLMOAHDIDNG(this.mode == ColorCorrectionCurves.CGIEPIJKBID.Advanced);
			this.IAHELJAHCED = base.ALJPMGLOIEG(this.simpleColorCorrectionCurvesShader, this.IAHELJAHCED);
			this.KNHGHJNBEMN = base.DJFOEIJIMJB(this.colorCorrectionCurvesShader, this.KNHGHJNBEMN);
			this.IBBKCHHBMAP = base.BAPJBHPEDIF(this.colorCorrectionSelectiveShader, this.IBBKCHHBMAP);
			if (!this.ADMHJLIOEAD)
			{
				this.ADMHJLIOEAD = new Texture2D(98, 4, (TextureFormat)6, true, false);
			}
			if (!this.LCDFFHCHPGC)
			{
				this.LCDFFHCHPGC = new Texture2D(2, 4, (TextureFormat)0, true, false);
			}
			if (!this.NMDKEMKAOJA)
			{
				this.NMDKEMKAOJA = new Texture2D(-31, 0, TextureFormat.ARGB32, true, true);
			}
			this.ADMHJLIOEAD.hideFlags = ~HideFlags.DontSaveInEditor;
			this.LCDFFHCHPGC.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
			this.NMDKEMKAOJA.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable);
			this.ADMHJLIOEAD.wrapMode = TextureWrapMode.Repeat;
			this.LCDFFHCHPGC.wrapMode = TextureWrapMode.Clamp;
			this.NMDKEMKAOJA.wrapMode = TextureWrapMode.Clamp;
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B548 RID: 46408 RVA: 0x005049EC File Offset: 0x00502BEC
		private void KHHBBMHGMIH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.DLENDGGGMBJ())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.KEGMOAALLHK)
			{
				this.BDDBECDBEDP();
				this.KEGMOAALLHK = false;
			}
			if (this.useDepthCorrection)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			RenderTexture renderTexture = OKIIDHIJBEA;
			if (this.selectiveCc)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
			}
			if (this.useDepthCorrection)
			{
				this.KNHGHJNBEMN.SetTexture("COLOR", this.ADMHJLIOEAD);
				this.KNHGHJNBEMN.SetTexture("WaveSpeed", this.NMDKEMKAOJA);
				this.KNHGHJNBEMN.SetTexture("dummy", this.LCDFFHCHPGC);
				this.KNHGHJNBEMN.SetFloat(" ", this.saturation);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.KNHGHJNBEMN);
			}
			else
			{
				this.IAHELJAHCED.SetTexture("Antares/point", this.ADMHJLIOEAD);
				this.IAHELJAHCED.SetFloat("WizardOverhead", this.saturation);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.IAHELJAHCED);
			}
			if (this.selectiveCc)
			{
				this.IBBKCHHBMAP.SetColor("id", this.selectiveFromColor);
				this.IBBKCHHBMAP.SetColor("10", this.selectiveToColor);
				Graphics.Blit(renderTexture, OKIIDHIJBEA, this.IBBKCHHBMAP);
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600B549 RID: 46409 RVA: 0x00504B44 File Offset: 0x00502D44
		public void EOPCBNJKAPP()
		{
			this.MNDOFMMGLMO();
			if (this.redChannel != null && this.greenChannel != null && this.blueChannel != null)
			{
				for (float num = 1175f; num <= 1548f; num += 1956f)
				{
					float num2 = Mathf.Clamp(this.redChannel.Evaluate(num), 611f, 1517f);
					float num3 = Mathf.Clamp(this.greenChannel.Evaluate(num), 1940f, 750f);
					float num4 = Mathf.Clamp(this.blueChannel.Evaluate(num), 1249f, 941f);
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 1575f), 1, new Color(num2, num2, num2));
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 1874f), 1, new Color(num3, num3, num3));
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 1994f), 2, new Color(num4, num4, num4));
					float num5 = Mathf.Clamp(this.zCurve.Evaluate(num), 1834f, 196f);
					this.NMDKEMKAOJA.SetPixel((int)Mathf.Floor(num * 1178f), 1, new Color(num5, num5, num5));
					num2 = Mathf.Clamp(this.depthRedChannel.Evaluate(num), 1494f, 766f);
					num3 = Mathf.Clamp(this.depthGreenChannel.Evaluate(num), 1004f, 1813f);
					num4 = Mathf.Clamp(this.depthBlueChannel.Evaluate(num), 416f, 1156f);
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 1697f), 1, new Color(num2, num2, num2));
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 717f), 0, new Color(num3, num3, num3));
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 580f), 2, new Color(num4, num4, num4));
				}
				this.ADMHJLIOEAD.Apply();
				this.LCDFFHCHPGC.Apply();
				this.NMDKEMKAOJA.Apply();
			}
		}

		// Token: 0x0600B54A RID: 46410 RVA: 0x00500AF4 File Offset: 0x004FECF4
		private void CAJLCEPLKJG()
		{
			base.OLBDJCFPKFG();
			this.KEGMOAALLHK = true;
		}

		// Token: 0x0600B54B RID: 46411 RVA: 0x00504D68 File Offset: 0x00502F68
		public virtual bool ENMKIJNFBFF()
		{
			base.POJDHPJDFEM(this.mode == ColorCorrectionCurves.CGIEPIJKBID.Simple);
			this.IAHELJAHCED = base.BOOFEOGDMBI(this.simpleColorCorrectionCurvesShader, this.IAHELJAHCED);
			this.KNHGHJNBEMN = base.DJFOEIJIMJB(this.colorCorrectionCurvesShader, this.KNHGHJNBEMN);
			this.IBBKCHHBMAP = base.IIIIADNBONI(this.colorCorrectionSelectiveShader, this.IBBKCHHBMAP);
			if (!this.ADMHJLIOEAD)
			{
				this.ADMHJLIOEAD = new Texture2D(43, 3, TextureFormat.RGB24, true, true);
			}
			if (!this.LCDFFHCHPGC)
			{
				this.LCDFFHCHPGC = new Texture2D(154, 3, TextureFormat.Alpha8, false, false);
			}
			if (!this.NMDKEMKAOJA)
			{
				this.NMDKEMKAOJA = new Texture2D(-14, 0, (TextureFormat)0, true, true);
			}
			this.ADMHJLIOEAD.hideFlags = (HideFlags)(-92);
			this.LCDFFHCHPGC.hideFlags = (HideFlags)70;
			this.NMDKEMKAOJA.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			this.ADMHJLIOEAD.wrapMode = TextureWrapMode.Clamp;
			this.LCDFFHCHPGC.wrapMode = TextureWrapMode.Clamp;
			this.NMDKEMKAOJA.wrapMode = TextureWrapMode.Repeat;
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B54C RID: 46412 RVA: 0x005004D8 File Offset: 0x004FE6D8
		private void PMDPLLIBJAF()
		{
			base.CKIGGCAHAFD();
			this.KEGMOAALLHK = true;
		}

		// Token: 0x0600B54D RID: 46413 RVA: 0x00022FCC File Offset: 0x000211CC
		private void PJMCFJBFLIH()
		{
		}

		// Token: 0x0600B54E RID: 46414 RVA: 0x00504E90 File Offset: 0x00503090
		public void GAIMMCKHHLN()
		{
			this.MNDOFMMGLMO();
			if (this.redChannel != null && this.greenChannel != null && this.blueChannel != null)
			{
				for (float num = 1173f; num <= 1073f; num += 942f)
				{
					float num2 = Mathf.Clamp(this.redChannel.Evaluate(num), 902f, 513f);
					float num3 = Mathf.Clamp(this.greenChannel.Evaluate(num), 1993f, 907f);
					float num4 = Mathf.Clamp(this.blueChannel.Evaluate(num), 1553f, 97f);
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 45f), 0, new Color(num2, num2, num2));
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 1310f), 0, new Color(num3, num3, num3));
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 852f), 7, new Color(num4, num4, num4));
					float num5 = Mathf.Clamp(this.zCurve.Evaluate(num), 79f, 634f);
					this.NMDKEMKAOJA.SetPixel((int)Mathf.Floor(num * 1908f), 0, new Color(num5, num5, num5));
					num2 = Mathf.Clamp(this.depthRedChannel.Evaluate(num), 1041f, 509f);
					num3 = Mathf.Clamp(this.depthGreenChannel.Evaluate(num), 363f, 1157f);
					num4 = Mathf.Clamp(this.depthBlueChannel.Evaluate(num), 1424f, 1060f);
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 175f), 1, new Color(num2, num2, num2));
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 394f), 0, new Color(num3, num3, num3));
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 1505f), 6, new Color(num4, num4, num4));
				}
				this.ADMHJLIOEAD.Apply();
				this.LCDFFHCHPGC.Apply();
				this.NMDKEMKAOJA.Apply();
			}
		}

		// Token: 0x0600B54F RID: 46415 RVA: 0x005050B4 File Offset: 0x005032B4
		public override bool CheckResources()
		{
			base.DAOKCAOFIGE(this.mode == ColorCorrectionCurves.CGIEPIJKBID.Advanced);
			this.IAHELJAHCED = base.DJFOEIJIMJB(this.simpleColorCorrectionCurvesShader, this.IAHELJAHCED);
			this.KNHGHJNBEMN = base.DJFOEIJIMJB(this.colorCorrectionCurvesShader, this.KNHGHJNBEMN);
			this.IBBKCHHBMAP = base.DJFOEIJIMJB(this.colorCorrectionSelectiveShader, this.IBBKCHHBMAP);
			if (!this.ADMHJLIOEAD)
			{
				this.ADMHJLIOEAD = new Texture2D(256, 4, TextureFormat.ARGB32, false, true);
			}
			if (!this.LCDFFHCHPGC)
			{
				this.LCDFFHCHPGC = new Texture2D(256, 4, TextureFormat.ARGB32, false, true);
			}
			if (!this.NMDKEMKAOJA)
			{
				this.NMDKEMKAOJA = new Texture2D(256, 1, TextureFormat.ARGB32, false, true);
			}
			this.ADMHJLIOEAD.hideFlags = HideFlags.DontSave;
			this.LCDFFHCHPGC.hideFlags = HideFlags.DontSave;
			this.NMDKEMKAOJA.hideFlags = HideFlags.DontSave;
			this.ADMHJLIOEAD.wrapMode = TextureWrapMode.Clamp;
			this.LCDFFHCHPGC.wrapMode = TextureWrapMode.Clamp;
			this.NMDKEMKAOJA.wrapMode = TextureWrapMode.Clamp;
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B550 RID: 46416 RVA: 0x005051DC File Offset: 0x005033DC
		private void AHMKJAIPKMF(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.DLENDGGGMBJ())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.KEGMOAALLHK)
			{
				this.CDMBILDBHGE();
				this.KEGMOAALLHK = false;
			}
			if (this.useDepthCorrection)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			RenderTexture renderTexture = OKIIDHIJBEA;
			if (this.selectiveCc)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
			}
			if (this.useDepthCorrection)
			{
				this.KNHGHJNBEMN.SetTexture("wpn_add/addperks/addPerk", this.ADMHJLIOEAD);
				this.KNHGHJNBEMN.SetTexture("wpn_add/addoptions", this.NMDKEMKAOJA);
				this.KNHGHJNBEMN.SetTexture("Head", this.LCDFFHCHPGC);
				this.KNHGHJNBEMN.SetFloat("Sitting Leg Cross", this.saturation);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.KNHGHJNBEMN);
			}
			else
			{
				this.IAHELJAHCED.SetTexture("_BlurRadius4", this.ADMHJLIOEAD);
				this.IAHELJAHCED.SetFloat("Windows", this.saturation);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.IAHELJAHCED);
			}
			if (this.selectiveCc)
			{
				this.IBBKCHHBMAP.SetColor("RunBackward", this.selectiveFromColor);
				this.IBBKCHHBMAP.SetColor("click Refresh currentQcat=", this.selectiveToColor);
				Graphics.Blit(renderTexture, OKIIDHIJBEA, this.IBBKCHHBMAP);
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600B551 RID: 46417 RVA: 0x00505334 File Offset: 0x00503534
		public virtual bool MIJKIPKJPCO()
		{
			base.EBEBJHLBBBI(this.mode == ColorCorrectionCurves.CGIEPIJKBID.Advanced);
			this.IAHELJAHCED = base.ALJPMGLOIEG(this.simpleColorCorrectionCurvesShader, this.IAHELJAHCED);
			this.KNHGHJNBEMN = base.BOOFEOGDMBI(this.colorCorrectionCurvesShader, this.KNHGHJNBEMN);
			this.IBBKCHHBMAP = base.BOOFEOGDMBI(this.colorCorrectionSelectiveShader, this.IBBKCHHBMAP);
			if (!this.ADMHJLIOEAD)
			{
				this.ADMHJLIOEAD = new Texture2D(-30, 8, (TextureFormat)8, true, false);
			}
			if (!this.LCDFFHCHPGC)
			{
				this.LCDFFHCHPGC = new Texture2D(53, 6, TextureFormat.RGB24, true, true);
			}
			if (!this.NMDKEMKAOJA)
			{
				this.NMDKEMKAOJA = new Texture2D(162, 0, TextureFormat.RGB24, false, true);
			}
			this.ADMHJLIOEAD.hideFlags = (HideFlags)(-66);
			this.LCDFFHCHPGC.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			this.NMDKEMKAOJA.hideFlags = (HideFlags)(-104);
			this.ADMHJLIOEAD.wrapMode = TextureWrapMode.Repeat;
			this.LCDFFHCHPGC.wrapMode = TextureWrapMode.Clamp;
			this.NMDKEMKAOJA.wrapMode = TextureWrapMode.Repeat;
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B552 RID: 46418 RVA: 0x00022FCC File Offset: 0x000211CC
		private void CHHMFDFHFAA()
		{
		}

		// Token: 0x0600B553 RID: 46419 RVA: 0x0050545C File Offset: 0x0050365C
		public void IBMJDDKGHBP()
		{
			this.NHEEDPALBFN();
			if (this.redChannel != null && this.greenChannel != null && this.blueChannel != null)
			{
				for (float num = 1173f; num <= 1413f; num += 842f)
				{
					float num2 = Mathf.Clamp(this.redChannel.Evaluate(num), 1684f, 833f);
					float num3 = Mathf.Clamp(this.greenChannel.Evaluate(num), 846f, 1571f);
					float num4 = Mathf.Clamp(this.blueChannel.Evaluate(num), 555f, 1460f);
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 1310f), 1, new Color(num2, num2, num2));
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 1323f), 0, new Color(num3, num3, num3));
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 277f), 5, new Color(num4, num4, num4));
					float num5 = Mathf.Clamp(this.zCurve.Evaluate(num), 669f, 187f);
					this.NMDKEMKAOJA.SetPixel((int)Mathf.Floor(num * 407f), 0, new Color(num5, num5, num5));
					num2 = Mathf.Clamp(this.depthRedChannel.Evaluate(num), 559f, 493f);
					num3 = Mathf.Clamp(this.depthGreenChannel.Evaluate(num), 1373f, 1529f);
					num4 = Mathf.Clamp(this.depthBlueChannel.Evaluate(num), 544f, 1433f);
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 662f), 1, new Color(num2, num2, num2));
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 1034f), 1, new Color(num3, num3, num3));
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 1390f), 2, new Color(num4, num4, num4));
				}
				this.ADMHJLIOEAD.Apply();
				this.LCDFFHCHPGC.Apply();
				this.NMDKEMKAOJA.Apply();
			}
		}

		// Token: 0x0600B554 RID: 46420 RVA: 0x0050567F File Offset: 0x0050387F
		private void GPPOEGIFLGF()
		{
			this.HLPHPFJANJB();
		}

		// Token: 0x0600B555 RID: 46421 RVA: 0x00505687 File Offset: 0x00503887
		private void PNOHGOJEJKL()
		{
			base.OLBDJCFPKFG();
			this.KEGMOAALLHK = false;
		}

		// Token: 0x0600B556 RID: 46422 RVA: 0x00505696 File Offset: 0x00503896
		private void EDGALMCHPPH()
		{
			base.OBJCOJEHLBE();
			this.KEGMOAALLHK = true;
		}

		// Token: 0x0600B557 RID: 46423 RVA: 0x00022FCC File Offset: 0x000211CC
		private void NOKBLBJFPBC()
		{
		}

		// Token: 0x0600B558 RID: 46424 RVA: 0x005056A8 File Offset: 0x005038A8
		public virtual bool BGDALDCKGKM()
		{
			base.AHFDGALLKFC(this.mode == ColorCorrectionCurves.CGIEPIJKBID.Advanced);
			this.IAHELJAHCED = base.BAPJBHPEDIF(this.simpleColorCorrectionCurvesShader, this.IAHELJAHCED);
			this.KNHGHJNBEMN = base.BOOFEOGDMBI(this.colorCorrectionCurvesShader, this.KNHGHJNBEMN);
			this.IBBKCHHBMAP = base.IIIIADNBONI(this.colorCorrectionSelectiveShader, this.IBBKCHHBMAP);
			if (!this.ADMHJLIOEAD)
			{
				this.ADMHJLIOEAD = new Texture2D(-146, 7, TextureFormat.Alpha8, true, true);
			}
			if (!this.LCDFFHCHPGC)
			{
				this.LCDFFHCHPGC = new Texture2D(-66, 1, TextureFormat.ARGB4444, true, false);
			}
			if (!this.NMDKEMKAOJA)
			{
				this.NMDKEMKAOJA = new Texture2D(-123, 1, TextureFormat.Alpha8, true, false);
			}
			this.ADMHJLIOEAD.hideFlags = (HideFlags)93;
			this.LCDFFHCHPGC.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			this.NMDKEMKAOJA.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			this.ADMHJLIOEAD.wrapMode = TextureWrapMode.Repeat;
			this.LCDFFHCHPGC.wrapMode = TextureWrapMode.Repeat;
			this.NMDKEMKAOJA.wrapMode = TextureWrapMode.Repeat;
			if (!this.PPGOAMIHMBG)
			{
				base.FDBKFKGCGEG();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B559 RID: 46425 RVA: 0x005057D0 File Offset: 0x005039D0
		public void EJDOCAKMDON()
		{
			this.DLENDGGGMBJ();
			if (this.redChannel != null && this.greenChannel != null && this.blueChannel != null)
			{
				for (float num = 411f; num <= 1719f; num += 516f)
				{
					float num2 = Mathf.Clamp(this.redChannel.Evaluate(num), 1550f, 942f);
					float num3 = Mathf.Clamp(this.greenChannel.Evaluate(num), 1959f, 1259f);
					float num4 = Mathf.Clamp(this.blueChannel.Evaluate(num), 1268f, 1896f);
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 1671f), 1, new Color(num2, num2, num2));
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 1568f), 1, new Color(num3, num3, num3));
					this.ADMHJLIOEAD.SetPixel((int)Mathf.Floor(num * 1696f), 4, new Color(num4, num4, num4));
					float num5 = Mathf.Clamp(this.zCurve.Evaluate(num), 1036f, 977f);
					this.NMDKEMKAOJA.SetPixel((int)Mathf.Floor(num * 8f), 1, new Color(num5, num5, num5));
					num2 = Mathf.Clamp(this.depthRedChannel.Evaluate(num), 373f, 269f);
					num3 = Mathf.Clamp(this.depthGreenChannel.Evaluate(num), 623f, 1185f);
					num4 = Mathf.Clamp(this.depthBlueChannel.Evaluate(num), 622f, 782f);
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 718f), 0, new Color(num2, num2, num2));
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 930f), 1, new Color(num3, num3, num3));
					this.LCDFFHCHPGC.SetPixel((int)Mathf.Floor(num * 972f), 4, new Color(num4, num4, num4));
				}
				this.ADMHJLIOEAD.Apply();
				this.LCDFFHCHPGC.Apply();
				this.NMDKEMKAOJA.Apply();
			}
		}

		// Token: 0x0600B55A RID: 46426 RVA: 0x00500B03 File Offset: 0x004FED03
		private void NFHFOGKEBMN()
		{
			this.PLDFOBJOHKO();
		}

		// Token: 0x0600B55B RID: 46427 RVA: 0x005059F4 File Offset: 0x00503BF4
		public virtual bool HKEDGJELFGD()
		{
			base.NHCAHIHJHMF(this.mode == ColorCorrectionCurves.CGIEPIJKBID.Simple);
			this.IAHELJAHCED = base.JBHLGBPJFEL(this.simpleColorCorrectionCurvesShader, this.IAHELJAHCED);
			this.KNHGHJNBEMN = base.OOAOHFFDMJP(this.colorCorrectionCurvesShader, this.KNHGHJNBEMN);
			this.IBBKCHHBMAP = base.JBHLGBPJFEL(this.colorCorrectionSelectiveShader, this.IBBKCHHBMAP);
			if (!this.ADMHJLIOEAD)
			{
				this.ADMHJLIOEAD = new Texture2D(-22, 1, TextureFormat.ARGB32, false, false);
			}
			if (!this.LCDFFHCHPGC)
			{
				this.LCDFFHCHPGC = new Texture2D(160, 3, TextureFormat.RGB565, true, true);
			}
			if (!this.NMDKEMKAOJA)
			{
				this.NMDKEMKAOJA = new Texture2D(-82, 1, TextureFormat.RGB565, true, true);
			}
			this.ADMHJLIOEAD.hideFlags = (HideFlags)77;
			this.LCDFFHCHPGC.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
			this.NMDKEMKAOJA.hideFlags = (HideFlags)(-115);
			this.ADMHJLIOEAD.wrapMode = TextureWrapMode.Clamp;
			this.LCDFFHCHPGC.wrapMode = TextureWrapMode.Clamp;
			this.NMDKEMKAOJA.wrapMode = TextureWrapMode.Repeat;
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B55C RID: 46428 RVA: 0x00505B1C File Offset: 0x00503D1C
		public virtual bool IAIMIKBMJOM()
		{
			base.PKDIKFGAJKM(this.mode == ColorCorrectionCurves.CGIEPIJKBID.Simple);
			this.IAHELJAHCED = base.OOAOHFFDMJP(this.simpleColorCorrectionCurvesShader, this.IAHELJAHCED);
			this.KNHGHJNBEMN = base.JBHLGBPJFEL(this.colorCorrectionCurvesShader, this.KNHGHJNBEMN);
			this.IBBKCHHBMAP = base.OOAOHFFDMJP(this.colorCorrectionSelectiveShader, this.IBBKCHHBMAP);
			if (!this.ADMHJLIOEAD)
			{
				this.ADMHJLIOEAD = new Texture2D(-197, 8, TextureFormat.RGBA32, true, false);
			}
			if (!this.LCDFFHCHPGC)
			{
				this.LCDFFHCHPGC = new Texture2D(-54, 3, TextureFormat.RGBA32, false, false);
			}
			if (!this.NMDKEMKAOJA)
			{
				this.NMDKEMKAOJA = new Texture2D(-114, 1, TextureFormat.Alpha8, true, false);
			}
			this.ADMHJLIOEAD.hideFlags = (HideFlags)(-125);
			this.LCDFFHCHPGC.hideFlags = ~(HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			this.NMDKEMKAOJA.hideFlags = (HideFlags)113;
			this.ADMHJLIOEAD.wrapMode = TextureWrapMode.Clamp;
			this.LCDFFHCHPGC.wrapMode = TextureWrapMode.Repeat;
			this.NMDKEMKAOJA.wrapMode = TextureWrapMode.Clamp;
			if (!this.PPGOAMIHMBG)
			{
				base.INOGPLDHPGC();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x04001750 RID: 5968
		public AnimationCurve redChannel = new AnimationCurve(new Keyframe[]
		{
			new Keyframe(0f, 0f),
			new Keyframe(1f, 1f)
		});

		// Token: 0x04001751 RID: 5969
		public AnimationCurve greenChannel = new AnimationCurve(new Keyframe[]
		{
			new Keyframe(0f, 0f),
			new Keyframe(1f, 1f)
		});

		// Token: 0x04001752 RID: 5970
		public AnimationCurve blueChannel = new AnimationCurve(new Keyframe[]
		{
			new Keyframe(0f, 0f),
			new Keyframe(1f, 1f)
		});

		// Token: 0x04001753 RID: 5971
		public bool useDepthCorrection;

		// Token: 0x04001754 RID: 5972
		public AnimationCurve zCurve = new AnimationCurve(new Keyframe[]
		{
			new Keyframe(0f, 0f),
			new Keyframe(1f, 1f)
		});

		// Token: 0x04001755 RID: 5973
		public AnimationCurve depthRedChannel = new AnimationCurve(new Keyframe[]
		{
			new Keyframe(0f, 0f),
			new Keyframe(1f, 1f)
		});

		// Token: 0x04001756 RID: 5974
		public AnimationCurve depthGreenChannel = new AnimationCurve(new Keyframe[]
		{
			new Keyframe(0f, 0f),
			new Keyframe(1f, 1f)
		});

		// Token: 0x04001757 RID: 5975
		public AnimationCurve depthBlueChannel = new AnimationCurve(new Keyframe[]
		{
			new Keyframe(0f, 0f),
			new Keyframe(1f, 1f)
		});

		// Token: 0x04001758 RID: 5976
		private Material IAHELJAHCED;

		// Token: 0x04001759 RID: 5977
		private Material KNHGHJNBEMN;

		// Token: 0x0400175A RID: 5978
		private Material IBBKCHHBMAP;

		// Token: 0x0400175B RID: 5979
		private Texture2D ADMHJLIOEAD;

		// Token: 0x0400175C RID: 5980
		private Texture2D LCDFFHCHPGC;

		// Token: 0x0400175D RID: 5981
		private Texture2D NMDKEMKAOJA;

		// Token: 0x0400175E RID: 5982
		public float saturation = 1f;

		// Token: 0x0400175F RID: 5983
		public bool selectiveCc;

		// Token: 0x04001760 RID: 5984
		public Color selectiveFromColor = Color.white;

		// Token: 0x04001761 RID: 5985
		public Color selectiveToColor = Color.white;

		// Token: 0x04001762 RID: 5986
		public ColorCorrectionCurves.CGIEPIJKBID mode;

		// Token: 0x04001763 RID: 5987
		public bool updateTextures = true;

		// Token: 0x04001764 RID: 5988
		public Shader colorCorrectionCurvesShader;

		// Token: 0x04001765 RID: 5989
		public Shader simpleColorCorrectionCurvesShader;

		// Token: 0x04001766 RID: 5990
		public Shader colorCorrectionSelectiveShader;

		// Token: 0x04001767 RID: 5991
		private bool KEGMOAALLHK = true;

		// Token: 0x02000311 RID: 785
		public enum CGIEPIJKBID
		{
			// Token: 0x04001769 RID: 5993
			Simple,
			// Token: 0x0400176A RID: 5994
			Advanced
		}
	}
}
