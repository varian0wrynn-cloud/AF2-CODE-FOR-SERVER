using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000335 RID: 821
	[AddComponentMenu("Image Effects/Camera/Tilt Shift (Lens Blur)")]
	[RequireComponent(typeof(Camera))]
	internal class TiltShift : PostEffectsBase
	{
		// Token: 0x0600BBB6 RID: 48054 RVA: 0x005488E8 File Offset: 0x00546AE8
		private void GGIKBEHBAPB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.PFGNPENMJJH.SetFloat("WorkerShovel2", (this.maxBlurSize < 1109f) ? 423f : this.maxBlurSize);
			this.PFGNPENMJJH.SetFloat(" шт", this.blurArea);
			JONJODLFAEN.filterMode = FilterMode.Point;
			RenderTexture renderTexture = OKIIDHIJBEA;
			if ((float)this.downsample > 344f)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width >> (this.downsample & -69), JONJODLFAEN.height >> (this.downsample & -52), 0, JONJODLFAEN.format);
				renderTexture.filterMode = FilterMode.Bilinear;
			}
			int num = (int)this.quality;
			num *= 6;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.PFGNPENMJJH, (this.mode == TiltShift.LDNGIJLDOCO.TiltShiftMode) ? num : (num + 1));
			if (this.downsample > 1)
			{
				this.PFGNPENMJJH.SetTexture("MotorbikeBackwardSittingCheer", renderTexture);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PFGNPENMJJH, 8);
			}
			if (renderTexture != OKIIDHIJBEA)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600BBB7 RID: 48055 RVA: 0x005489ED File Offset: 0x00546BED
		public virtual bool APNCPMNHKOG()
		{
			base.CBJDCDELBJN(false);
			this.PFGNPENMJJH = base.BOOFEOGDMBI(this.tiltShiftShader, this.PFGNPENMJJH);
			if (!this.PPGOAMIHMBG)
			{
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBB8 RID: 48056 RVA: 0x00548A24 File Offset: 0x00546C24
		private void JNGODMMNPEG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.PFGNPENMJJH.SetFloat("", (this.maxBlurSize < 1247f) ? 680f : this.maxBlurSize);
			this.PFGNPENMJJH.SetFloat("_Offsets", this.blurArea);
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			RenderTexture renderTexture = OKIIDHIJBEA;
			if ((float)this.downsample > 1913f)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width >> (this.downsample & 62), JONJODLFAEN.height >> (this.downsample & 35), 0, JONJODLFAEN.format);
				renderTexture.filterMode = FilterMode.Bilinear;
			}
			int num = (int)this.quality;
			num *= 5;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.PFGNPENMJJH, (this.mode == TiltShift.LDNGIJLDOCO.TiltShiftMode) ? num : (num + 1));
			if (this.downsample > 1)
			{
				this.PFGNPENMJJH.SetTexture("ProneIdle", renderTexture);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PFGNPENMJJH, 3);
			}
			if (renderTexture != OKIIDHIJBEA)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600BBB9 RID: 48057 RVA: 0x00548B29 File Offset: 0x00546D29
		public virtual bool DHBPAOGJPFE()
		{
			base.BGIALJEIEFO(true);
			this.PFGNPENMJJH = base.BAPJBHPEDIF(this.tiltShiftShader, this.PFGNPENMJJH);
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBBA RID: 48058 RVA: 0x00548B5F File Offset: 0x00546D5F
		public virtual bool AHMAHFLOJBM()
		{
			base.MGHNCKDCFGL(false);
			this.PFGNPENMJJH = base.IIIIADNBONI(this.tiltShiftShader, this.PFGNPENMJJH);
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBBB RID: 48059 RVA: 0x00548B95 File Offset: 0x00546D95
		public virtual bool DEHFEHNMOFH()
		{
			base.OFKOBOMCECF(false);
			this.PFGNPENMJJH = base.OOAOHFFDMJP(this.tiltShiftShader, this.PFGNPENMJJH);
			if (!this.PPGOAMIHMBG)
			{
				base.INOGPLDHPGC();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBBC RID: 48060 RVA: 0x00548BCC File Offset: 0x00546DCC
		private void MAIGIEENOEJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.PFGNPENMJJH.SetFloat("Lasso Back", (this.maxBlurSize < 598f) ? 1166f : this.maxBlurSize);
			this.PFGNPENMJJH.SetFloat("_FinalBlendParameters", this.blurArea);
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			RenderTexture renderTexture = OKIIDHIJBEA;
			if ((float)this.downsample > 1152f)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width >> (this.downsample & 17), JONJODLFAEN.height >> (this.downsample & 127), 1, JONJODLFAEN.format);
				renderTexture.filterMode = FilterMode.Point;
			}
			int num = (int)this.quality;
			num *= 0;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.PFGNPENMJJH, (this.mode == TiltShift.LDNGIJLDOCO.TiltShiftMode) ? num : (num + 1));
			if (this.downsample > 1)
			{
				this.PFGNPENMJJH.SetTexture("SkateForward", renderTexture);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PFGNPENMJJH, 5);
			}
			if (renderTexture != OKIIDHIJBEA)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600BBBD RID: 48061 RVA: 0x00548CD1 File Offset: 0x00546ED1
		public virtual bool OJFBHAHHDNC()
		{
			base.LGANGHEOPOG(true);
			this.PFGNPENMJJH = base.BOOFEOGDMBI(this.tiltShiftShader, this.PFGNPENMJJH);
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBBE RID: 48062 RVA: 0x00548D07 File Offset: 0x00546F07
		public virtual bool ELCICMMLFPB()
		{
			base.DAOKCAOFIGE(false);
			this.PFGNPENMJJH = base.DJFOEIJIMJB(this.tiltShiftShader, this.PFGNPENMJJH);
			if (!this.PPGOAMIHMBG)
			{
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBBF RID: 48063 RVA: 0x00548D3D File Offset: 0x00546F3D
		public override bool CheckResources()
		{
			base.DAOKCAOFIGE(false);
			this.PFGNPENMJJH = base.DJFOEIJIMJB(this.tiltShiftShader, this.PFGNPENMJJH);
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBC0 RID: 48064 RVA: 0x00548D73 File Offset: 0x00546F73
		public virtual bool FGDOAAAPBCP()
		{
			base.CBJDCDELBJN(false);
			this.PFGNPENMJJH = base.OOAOHFFDMJP(this.tiltShiftShader, this.PFGNPENMJJH);
			if (!this.PPGOAMIHMBG)
			{
				base.OAEAMDHOKKM();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBC1 RID: 48065 RVA: 0x00548DA9 File Offset: 0x00546FA9
		public virtual bool DGACHJFDAMI()
		{
			base.CBJDCDELBJN(true);
			this.PFGNPENMJJH = base.IIIIADNBONI(this.tiltShiftShader, this.PFGNPENMJJH);
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBC2 RID: 48066 RVA: 0x00548DDF File Offset: 0x00546FDF
		public virtual bool CGJBGGCEBAO()
		{
			base.OFKOBOMCECF(false);
			this.PFGNPENMJJH = base.JBHLGBPJFEL(this.tiltShiftShader, this.PFGNPENMJJH);
			if (!this.PPGOAMIHMBG)
			{
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBC3 RID: 48067 RVA: 0x00548E15 File Offset: 0x00547015
		public virtual bool HMHEIPAGPHD()
		{
			base.IDFIHFBEIKD(false);
			this.PFGNPENMJJH = base.OOAOHFFDMJP(this.tiltShiftShader, this.PFGNPENMJJH);
			if (!this.PPGOAMIHMBG)
			{
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBC4 RID: 48068 RVA: 0x00548E4C File Offset: 0x0054704C
		private void GAJNNKIFMOG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.PFGNPENMJJH.SetFloat("Near", (this.maxBlurSize < 419f) ? 1308f : this.maxBlurSize);
			this.PFGNPENMJJH.SetFloat(" not found in resource", this.blurArea);
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			RenderTexture renderTexture = OKIIDHIJBEA;
			if ((float)this.downsample > 1879f)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width >> (this.downsample & 39), JONJODLFAEN.height >> (this.downsample & 113), 1, JONJODLFAEN.format);
				renderTexture.filterMode = FilterMode.Bilinear;
			}
			int num = (int)this.quality;
			num *= 3;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.PFGNPENMJJH, (this.mode == TiltShift.LDNGIJLDOCO.TiltShiftMode) ? num : (num + 0));
			if (this.downsample > 0)
			{
				this.PFGNPENMJJH.SetTexture("(", renderTexture);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PFGNPENMJJH, 8);
			}
			if (renderTexture != OKIIDHIJBEA)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600BBC5 RID: 48069 RVA: 0x00548F51 File Offset: 0x00547151
		public virtual bool DAOFOENGONN()
		{
			base.EHGENDOEHLP(true);
			this.PFGNPENMJJH = base.IIIIADNBONI(this.tiltShiftShader, this.PFGNPENMJJH);
			if (!this.PPGOAMIHMBG)
			{
				base.LNEHBOJIBAI();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBC6 RID: 48070 RVA: 0x00548F88 File Offset: 0x00547188
		private void DHJHEGHEGOH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.PFGNPENMJJH.SetFloat("Foot", (this.maxBlurSize < 881f) ? 328f : this.maxBlurSize);
			this.PFGNPENMJJH.SetFloat("firsStartInfoPanel", this.blurArea);
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			RenderTexture renderTexture = OKIIDHIJBEA;
			if ((float)this.downsample > 617f)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width >> (this.downsample & 81), JONJODLFAEN.height >> (this.downsample & -9), 1, JONJODLFAEN.format);
				renderTexture.filterMode = FilterMode.Bilinear;
			}
			int num = (int)this.quality;
			num *= 1;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.PFGNPENMJJH, (this.mode == TiltShift.LDNGIJLDOCO.TiltShiftMode) ? num : (num + 0));
			if (this.downsample > 0)
			{
				this.PFGNPENMJJH.SetTexture("u_pin", renderTexture);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PFGNPENMJJH, 2);
			}
			if (renderTexture != OKIIDHIJBEA)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600BBC7 RID: 48071 RVA: 0x0054908D File Offset: 0x0054728D
		public virtual bool DPCKBGJGNAK()
		{
			base.DAOKCAOFIGE(true);
			this.PFGNPENMJJH = base.IIIIADNBONI(this.tiltShiftShader, this.PFGNPENMJJH);
			if (!this.PPGOAMIHMBG)
			{
				base.FDBKFKGCGEG();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBC8 RID: 48072 RVA: 0x005490C3 File Offset: 0x005472C3
		public override bool NIFOFLEPKIB()
		{
			base.POJDHPJDFEM(false);
			this.PFGNPENMJJH = base.OOAOHFFDMJP(this.tiltShiftShader, this.PFGNPENMJJH);
			if (!this.PPGOAMIHMBG)
			{
				base.LNEHBOJIBAI();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBC9 RID: 48073 RVA: 0x005490FC File Offset: 0x005472FC
		private void PHFJDPLOKJK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.PFGNPENMJJH.SetFloat("[F_EXP]", (this.maxBlurSize < 1385f) ? 1463f : this.maxBlurSize);
			this.PFGNPENMJJH.SetFloat("IX", this.blurArea);
			JONJODLFAEN.filterMode = FilterMode.Point;
			RenderTexture renderTexture = OKIIDHIJBEA;
			if ((float)this.downsample > 1828f)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width >> (this.downsample & -4), JONJODLFAEN.height >> (this.downsample & 41), 1, JONJODLFAEN.format);
				renderTexture.filterMode = FilterMode.Bilinear;
			}
			int num = (int)this.quality;
			num *= 0;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.PFGNPENMJJH, (this.mode == TiltShift.LDNGIJLDOCO.TiltShiftMode) ? num : (num + 1));
			if (this.downsample > 0)
			{
				this.PFGNPENMJJH.SetTexture("IdleReadyLook", renderTexture);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PFGNPENMJJH, 5);
			}
			if (renderTexture != OKIIDHIJBEA)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600BBCA RID: 48074 RVA: 0x00549204 File Offset: 0x00547404
		private void PKNBABMJLPB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.PFGNPENMJJH.SetFloat(" on layer ", (this.maxBlurSize < 505f) ? 1266f : this.maxBlurSize);
			this.PFGNPENMJJH.SetFloat("LDR", this.blurArea);
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			RenderTexture renderTexture = OKIIDHIJBEA;
			if ((float)this.downsample > 32f)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width >> (this.downsample & 108), JONJODLFAEN.height >> (this.downsample & 81), 1, JONJODLFAEN.format);
				renderTexture.filterMode = FilterMode.Bilinear;
			}
			int num = (int)this.quality;
			num *= 0;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.PFGNPENMJJH, (this.mode == TiltShift.LDNGIJLDOCO.TiltShiftMode) ? num : (num + 1));
			if (this.downsample > 0)
			{
				this.PFGNPENMJJH.SetTexture("intensity", renderTexture);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PFGNPENMJJH, 3);
			}
			if (renderTexture != OKIIDHIJBEA)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600BBCB RID: 48075 RVA: 0x00549309 File Offset: 0x00547509
		public virtual bool CFODPFPIHIF()
		{
			base.CBJDCDELBJN(true);
			this.PFGNPENMJJH = base.JBHLGBPJFEL(this.tiltShiftShader, this.PFGNPENMJJH);
			if (!this.PPGOAMIHMBG)
			{
				base.INOGPLDHPGC();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBCC RID: 48076 RVA: 0x0054933F File Offset: 0x0054753F
		public virtual bool EEGDCIJFLCP()
		{
			base.POJDHPJDFEM(true);
			this.PFGNPENMJJH = base.OOAOHFFDMJP(this.tiltShiftShader, this.PFGNPENMJJH);
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBCD RID: 48077 RVA: 0x00549375 File Offset: 0x00547575
		public virtual bool DCEJLCLOCJC()
		{
			base.IDFIHFBEIKD(false);
			this.PFGNPENMJJH = base.BOOFEOGDMBI(this.tiltShiftShader, this.PFGNPENMJJH);
			if (!this.PPGOAMIHMBG)
			{
				base.NAIBIABADFB();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBCE RID: 48078 RVA: 0x005493AB File Offset: 0x005475AB
		public virtual bool NCCMOLJNIAB()
		{
			base.EHGENDOEHLP(true);
			this.PFGNPENMJJH = base.ALJPMGLOIEG(this.tiltShiftShader, this.PFGNPENMJJH);
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBCF RID: 48079 RVA: 0x005493E1 File Offset: 0x005475E1
		public virtual bool JPEBNJPIFAF()
		{
			base.POJDHPJDFEM(false);
			this.PFGNPENMJJH = base.OOAOHFFDMJP(this.tiltShiftShader, this.PFGNPENMJJH);
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBD0 RID: 48080 RVA: 0x00549418 File Offset: 0x00547618
		private void NPNOACPLOCB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.PFGNPENMJJH.SetFloat("Staff Attack", (this.maxBlurSize < 833f) ? 294f : this.maxBlurSize);
			this.PFGNPENMJJH.SetFloat("post_4", this.blurArea);
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			RenderTexture renderTexture = OKIIDHIJBEA;
			if ((float)this.downsample > 1839f)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width >> this.downsample, JONJODLFAEN.height >> (this.downsample & -48), 0, JONJODLFAEN.format);
				renderTexture.filterMode = FilterMode.Bilinear;
			}
			int num = (int)this.quality;
			num *= 8;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.PFGNPENMJJH, (this.mode == TiltShift.LDNGIJLDOCO.TiltShiftMode) ? num : (num + 1));
			if (this.downsample > 0)
			{
				this.PFGNPENMJJH.SetTexture("ExposureIBL", renderTexture);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PFGNPENMJJH, 8);
			}
			if (renderTexture != OKIIDHIJBEA)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600BBD1 RID: 48081 RVA: 0x00549520 File Offset: 0x00547720
		private void MGOBAHLJJNL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.MNDOFMMGLMO())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.PFGNPENMJJH.SetFloat("WATER_EDGEBLEND_OFF", (this.maxBlurSize < 258f) ? 1639f : this.maxBlurSize);
			this.PFGNPENMJJH.SetFloat("PostFX - {0}", this.blurArea);
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			RenderTexture renderTexture = OKIIDHIJBEA;
			if ((float)this.downsample > 1124f)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width >> (this.downsample & 33), JONJODLFAEN.height >> (this.downsample & 18), 1, JONJODLFAEN.format);
				renderTexture.filterMode = FilterMode.Bilinear;
			}
			int num = (int)this.quality;
			num *= 3;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.PFGNPENMJJH, (this.mode == TiltShift.LDNGIJLDOCO.TiltShiftMode) ? num : (num + 1));
			if (this.downsample > 0)
			{
				this.PFGNPENMJJH.SetTexture("Vertical", renderTexture);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PFGNPENMJJH, 3);
			}
			if (renderTexture != OKIIDHIJBEA)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600BBD2 RID: 48082 RVA: 0x00549625 File Offset: 0x00547825
		public virtual bool POKDAEAADAC()
		{
			base.MGHNCKDCFGL(false);
			this.PFGNPENMJJH = base.IIIIADNBONI(this.tiltShiftShader, this.PFGNPENMJJH);
			if (!this.PPGOAMIHMBG)
			{
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBD3 RID: 48083 RVA: 0x0054965B File Offset: 0x0054785B
		public virtual bool GEHBEOAIAKA()
		{
			base.POJDHPJDFEM(false);
			this.PFGNPENMJJH = base.ALJPMGLOIEG(this.tiltShiftShader, this.PFGNPENMJJH);
			if (!this.PPGOAMIHMBG)
			{
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBD4 RID: 48084 RVA: 0x00549691 File Offset: 0x00547891
		public virtual bool NENLAEOGCBK()
		{
			base.PKDIKFGAJKM(true);
			this.PFGNPENMJJH = base.ALJPMGLOIEG(this.tiltShiftShader, this.PFGNPENMJJH);
			if (!this.PPGOAMIHMBG)
			{
				base.FDBKFKGCGEG();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBD5 RID: 48085 RVA: 0x005496C7 File Offset: 0x005478C7
		public virtual bool KPDPMCNDNOA()
		{
			base.AHFDGALLKFC(false);
			this.PFGNPENMJJH = base.BAPJBHPEDIF(this.tiltShiftShader, this.PFGNPENMJJH);
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBD6 RID: 48086 RVA: 0x00549700 File Offset: 0x00547900
		private void EFEHHALJILL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.PFGNPENMJJH.SetFloat("No IK assigned in HitReaction", (this.maxBlurSize < 1365f) ? 223f : this.maxBlurSize);
			this.PFGNPENMJJH.SetFloat("_TrEndWin.ogg", this.blurArea);
			JONJODLFAEN.filterMode = FilterMode.Point;
			RenderTexture renderTexture = OKIIDHIJBEA;
			if ((float)this.downsample > 1286f)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width >> (this.downsample & -128), JONJODLFAEN.height >> (this.downsample & -95), 1, JONJODLFAEN.format);
				renderTexture.filterMode = FilterMode.Point;
			}
			int num = (int)this.quality;
			num *= 3;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.PFGNPENMJJH, (this.mode == TiltShift.LDNGIJLDOCO.TiltShiftMode) ? num : (num + 1));
			if (this.downsample > 0)
			{
				this.PFGNPENMJJH.SetTexture("repair.ogg", renderTexture);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PFGNPENMJJH, 4);
			}
			if (renderTexture != OKIIDHIJBEA)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600BBD7 RID: 48087 RVA: 0x00549805 File Offset: 0x00547A05
		public virtual bool KKLBJANNNOH()
		{
			base.PKDIKFGAJKM(false);
			this.PFGNPENMJJH = base.BOOFEOGDMBI(this.tiltShiftShader, this.PFGNPENMJJH);
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBD8 RID: 48088 RVA: 0x0054983C File Offset: 0x00547A3C
		private void EKMKDLLLGFB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.PFGNPENMJJH.SetFloat("Autoclear", (this.maxBlurSize < 1754f) ? 340f : this.maxBlurSize);
			this.PFGNPENMJJH.SetFloat("Loot", this.blurArea);
			JONJODLFAEN.filterMode = FilterMode.Point;
			RenderTexture renderTexture = OKIIDHIJBEA;
			if ((float)this.downsample > 1252f)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width >> (this.downsample & 105), JONJODLFAEN.height >> (this.downsample & 23), 1, JONJODLFAEN.format);
				renderTexture.filterMode = FilterMode.Bilinear;
			}
			int num = (int)this.quality;
			num *= 5;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.PFGNPENMJJH, (this.mode == TiltShift.LDNGIJLDOCO.TiltShiftMode) ? num : (num + 0));
			if (this.downsample > 1)
			{
				this.PFGNPENMJJH.SetTexture("<color='#200080'>", renderTexture);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PFGNPENMJJH, 1);
			}
			if (renderTexture != OKIIDHIJBEA)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600BBD9 RID: 48089 RVA: 0x00549944 File Offset: 0x00547B44
		private void FEAGGDCEGFE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.PFGNPENMJJH.SetFloat("move", (this.maxBlurSize < 1813f) ? 1379f : this.maxBlurSize);
			this.PFGNPENMJJH.SetFloat("OfficeSittingReading", this.blurArea);
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			RenderTexture renderTexture = OKIIDHIJBEA;
			if ((float)this.downsample > 1292f)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width >> (this.downsample & 46), JONJODLFAEN.height >> (this.downsample & -102), 1, JONJODLFAEN.format);
				renderTexture.filterMode = FilterMode.Point;
			}
			int num = (int)this.quality;
			num *= 5;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.PFGNPENMJJH, (this.mode == TiltShift.LDNGIJLDOCO.TiltShiftMode) ? num : (num + 0));
			if (this.downsample > 0)
			{
				this.PFGNPENMJJH.SetTexture(" no woman version! ", renderTexture);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PFGNPENMJJH, 4);
			}
			if (renderTexture != OKIIDHIJBEA)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600BBDA RID: 48090 RVA: 0x00549A4C File Offset: 0x00547C4C
		private void HLLKILIIBGD(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.GGJKGIHGMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.PFGNPENMJJH.SetFloat("NprPhysPoint", (this.maxBlurSize < 882f) ? 1113f : this.maxBlurSize);
			this.PFGNPENMJJH.SetFloat("", this.blurArea);
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			RenderTexture renderTexture = OKIIDHIJBEA;
			if ((float)this.downsample > 448f)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width >> (this.downsample & -22), JONJODLFAEN.height >> (this.downsample & -66), 0, JONJODLFAEN.format);
				renderTexture.filterMode = FilterMode.Point;
			}
			int num = (int)this.quality;
			num *= 2;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.PFGNPENMJJH, (this.mode == TiltShift.LDNGIJLDOCO.TiltShiftMode) ? num : (num + 0));
			if (this.downsample > 0)
			{
				this.PFGNPENMJJH.SetTexture("Joint_", renderTexture);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PFGNPENMJJH, 6);
			}
			if (renderTexture != OKIIDHIJBEA)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600BBDB RID: 48091 RVA: 0x00549B51 File Offset: 0x00547D51
		public virtual bool FCIOAHEKFIG()
		{
			base.LGANGHEOPOG(true);
			this.PFGNPENMJJH = base.DJFOEIJIMJB(this.tiltShiftShader, this.PFGNPENMJJH);
			if (!this.PPGOAMIHMBG)
			{
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBDC RID: 48092 RVA: 0x00549B88 File Offset: 0x00547D88
		private void DLOGCPJNGLM(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.PFGNPENMJJH.SetFloat("gi_fridgice", (this.maxBlurSize < 412f) ? 212f : this.maxBlurSize);
			this.PFGNPENMJJH.SetFloat("_DistortParams", this.blurArea);
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			RenderTexture renderTexture = OKIIDHIJBEA;
			if ((float)this.downsample > 1220f)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width >> (this.downsample & 36), JONJODLFAEN.height >> (this.downsample & 30), 0, JONJODLFAEN.format);
				renderTexture.filterMode = FilterMode.Point;
			}
			int num = (int)this.quality;
			num *= 4;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.PFGNPENMJJH, (this.mode == TiltShift.LDNGIJLDOCO.TiltShiftMode) ? num : (num + 1));
			if (this.downsample > 1)
			{
				this.PFGNPENMJJH.SetTexture("ShootRaycastModule", renderTexture);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PFGNPENMJJH, 5);
			}
			if (renderTexture != OKIIDHIJBEA)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600BBDD RID: 48093 RVA: 0x00549C90 File Offset: 0x00547E90
		private void FEKDECGCLCJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.PFGNPENMJJH.SetFloat("OneHandSwordIdle", (this.maxBlurSize < 526f) ? 177f : this.maxBlurSize);
			this.PFGNPENMJJH.SetFloat("SkateboardIdle", this.blurArea);
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			RenderTexture renderTexture = OKIIDHIJBEA;
			if ((float)this.downsample > 123f)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width >> (this.downsample & -49), JONJODLFAEN.height >> (this.downsample & -24), 0, JONJODLFAEN.format);
				renderTexture.filterMode = FilterMode.Bilinear;
			}
			int num = (int)this.quality;
			num *= 0;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.PFGNPENMJJH, (this.mode == TiltShift.LDNGIJLDOCO.TiltShiftMode) ? num : (num + 0));
			if (this.downsample > 1)
			{
				this.PFGNPENMJJH.SetTexture("Flap_02.wav", renderTexture);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PFGNPENMJJH, 0);
			}
			if (renderTexture != OKIIDHIJBEA)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600BBDE RID: 48094 RVA: 0x00549D98 File Offset: 0x00547F98
		private void MIJCMMIJPEE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.PFGNPENMJJH.SetFloat("KatanaReadyLow", (this.maxBlurSize < 1057f) ? 51f : this.maxBlurSize);
			this.PFGNPENMJJH.SetFloat("I'm regular string", this.blurArea);
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			RenderTexture renderTexture = OKIIDHIJBEA;
			if ((float)this.downsample > 1663f)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width >> (this.downsample & 15), JONJODLFAEN.height >> (this.downsample & 70), 1, JONJODLFAEN.format);
				renderTexture.filterMode = FilterMode.Point;
			}
			int num = (int)this.quality;
			num *= 0;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.PFGNPENMJJH, (this.mode == TiltShift.LDNGIJLDOCO.TiltShiftMode) ? num : (num + 1));
			if (this.downsample > 1)
			{
				this.PFGNPENMJJH.SetTexture("costume_", renderTexture);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PFGNPENMJJH, 5);
			}
			if (renderTexture != OKIIDHIJBEA)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600BBDF RID: 48095 RVA: 0x00549EA0 File Offset: 0x005480A0
		private void IOFFNEIOBEL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.PFGNPENMJJH.SetFloat(" ms", (this.maxBlurSize < 1135f) ? 146f : this.maxBlurSize);
			this.PFGNPENMJJH.SetFloat("error.wav", this.blurArea);
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			RenderTexture renderTexture = OKIIDHIJBEA;
			if ((float)this.downsample > 1437f)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width >> (this.downsample & -91), JONJODLFAEN.height >> (this.downsample & 63), 0, JONJODLFAEN.format);
				renderTexture.filterMode = FilterMode.Bilinear;
			}
			int num = (int)this.quality;
			num *= 5;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.PFGNPENMJJH, (this.mode == TiltShift.LDNGIJLDOCO.TiltShiftMode) ? num : (num + 1));
			if (this.downsample > 1)
			{
				this.PFGNPENMJJH.SetTexture("****** FlyIcon tmpl is null id=", renderTexture);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PFGNPENMJJH, 8);
			}
			if (renderTexture != OKIIDHIJBEA)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600BBE0 RID: 48096 RVA: 0x00549FA8 File Offset: 0x005481A8
		private void EBLFIONBNIO(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NHEEDPALBFN())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.PFGNPENMJJH.SetFloat("SixStep", (this.maxBlurSize < 445f) ? 118f : this.maxBlurSize);
			this.PFGNPENMJJH.SetFloat("wpn_eat7", this.blurArea);
			JONJODLFAEN.filterMode = FilterMode.Point;
			RenderTexture renderTexture = OKIIDHIJBEA;
			if ((float)this.downsample > 620f)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width >> (this.downsample & 125), JONJODLFAEN.height >> (this.downsample & 43), 1, JONJODLFAEN.format);
				renderTexture.filterMode = FilterMode.Point;
			}
			int num = (int)this.quality;
			num *= 6;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.PFGNPENMJJH, (this.mode == TiltShift.LDNGIJLDOCO.TiltShiftMode) ? num : (num + 0));
			if (this.downsample > 0)
			{
				this.PFGNPENMJJH.SetTexture("fish/", renderTexture);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PFGNPENMJJH, 7);
			}
			if (renderTexture != OKIIDHIJBEA)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600BBE1 RID: 48097 RVA: 0x0054A0AD File Offset: 0x005482AD
		public virtual bool NGKAKAAKDJH()
		{
			base.AHFDGALLKFC(true);
			this.PFGNPENMJJH = base.DJFOEIJIMJB(this.tiltShiftShader, this.PFGNPENMJJH);
			if (!this.PPGOAMIHMBG)
			{
				base.NAIBIABADFB();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBE2 RID: 48098 RVA: 0x0054A0E3 File Offset: 0x005482E3
		public virtual bool CHJBCBDIBJJ()
		{
			base.CGEGCOKMPHN(true);
			this.PFGNPENMJJH = base.OOAOHFFDMJP(this.tiltShiftShader, this.PFGNPENMJJH);
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBE3 RID: 48099 RVA: 0x0054A11C File Offset: 0x0054831C
		private void EIMKKKCGJLO(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NHEEDPALBFN())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.PFGNPENMJJH.SetFloat("IdleCheer", (this.maxBlurSize < 1247f) ? 82f : this.maxBlurSize);
			this.PFGNPENMJJH.SetFloat("t_bottom", this.blurArea);
			JONJODLFAEN.filterMode = FilterMode.Point;
			RenderTexture renderTexture = OKIIDHIJBEA;
			if ((float)this.downsample > 666f)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width >> (this.downsample & -56), JONJODLFAEN.height >> (this.downsample & -31), 1, JONJODLFAEN.format);
				renderTexture.filterMode = FilterMode.Point;
			}
			int num = (int)this.quality;
			num *= 0;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.PFGNPENMJJH, (this.mode == TiltShift.LDNGIJLDOCO.TiltShiftMode) ? num : (num + 0));
			if (this.downsample > 1)
			{
				this.PFGNPENMJJH.SetTexture("KatanaReady", renderTexture);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PFGNPENMJJH, 7);
			}
			if (renderTexture != OKIIDHIJBEA)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600BBE4 RID: 48100 RVA: 0x0054A224 File Offset: 0x00548424
		private void GFBELBBAJGD(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.PFGNPENMJJH.SetFloat("1HandSwordJabFootPush", (this.maxBlurSize < 688f) ? 1945f : this.maxBlurSize);
			this.PFGNPENMJJH.SetFloat(" locid=", this.blurArea);
			JONJODLFAEN.filterMode = FilterMode.Point;
			RenderTexture renderTexture = OKIIDHIJBEA;
			if ((float)this.downsample > 97f)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width >> (this.downsample & 24), JONJODLFAEN.height >> (this.downsample & 60), 1, JONJODLFAEN.format);
				renderTexture.filterMode = FilterMode.Point;
			}
			int num = (int)this.quality;
			num *= 0;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.PFGNPENMJJH, (this.mode == TiltShift.LDNGIJLDOCO.TiltShiftMode) ? num : (num + 1));
			if (this.downsample > 0)
			{
				this.PFGNPENMJJH.SetTexture("wpn_bait_sz", renderTexture);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PFGNPENMJJH, 6);
			}
			if (renderTexture != OKIIDHIJBEA)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600BBE5 RID: 48101 RVA: 0x0054A32C File Offset: 0x0054852C
		private void PLOEFNMCMEF(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.PFGNPENMJJH.SetFloat("", (this.maxBlurSize < 52f) ? 122f : this.maxBlurSize);
			this.PFGNPENMJJH.SetFloat("isRagulaSet", this.blurArea);
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			RenderTexture renderTexture = OKIIDHIJBEA;
			if ((float)this.downsample > 550f)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width >> (this.downsample & 49), JONJODLFAEN.height >> (this.downsample & 23), 0, JONJODLFAEN.format);
				renderTexture.filterMode = FilterMode.Point;
			}
			int num = (int)this.quality;
			num *= 6;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.PFGNPENMJJH, (this.mode == TiltShift.LDNGIJLDOCO.TiltShiftMode) ? num : (num + 1));
			if (this.downsample > 0)
			{
				this.PFGNPENMJJH.SetTexture("WorkerShovel", renderTexture);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PFGNPENMJJH, 2);
			}
			if (renderTexture != OKIIDHIJBEA)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600BBE6 RID: 48102 RVA: 0x0054A434 File Offset: 0x00548634
		private void EDBHDEOMGFP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.PFGNPENMJJH.SetFloat("UnityEngine.Vector3", (this.maxBlurSize < 62f) ? 1939f : this.maxBlurSize);
			this.PFGNPENMJJH.SetFloat("HDR", this.blurArea);
			JONJODLFAEN.filterMode = FilterMode.Point;
			RenderTexture renderTexture = OKIIDHIJBEA;
			if ((float)this.downsample > 13f)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width >> (this.downsample & -9), JONJODLFAEN.height >> (this.downsample & 39), 1, JONJODLFAEN.format);
				renderTexture.filterMode = FilterMode.Point;
			}
			int num = (int)this.quality;
			num *= 6;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.PFGNPENMJJH, (this.mode == TiltShift.LDNGIJLDOCO.TiltShiftMode) ? num : (num + 1));
			if (this.downsample > 1)
			{
				this.PFGNPENMJJH.SetTexture("<[^>]+>", renderTexture);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PFGNPENMJJH, 0);
			}
			if (renderTexture != OKIIDHIJBEA)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600BBE7 RID: 48103 RVA: 0x0054A539 File Offset: 0x00548739
		public virtual bool JKMNILOPECN()
		{
			base.CDBNBLBOLCL(true);
			this.PFGNPENMJJH = base.ALJPMGLOIEG(this.tiltShiftShader, this.PFGNPENMJJH);
			if (!this.PPGOAMIHMBG)
			{
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBE8 RID: 48104 RVA: 0x0054A570 File Offset: 0x00548770
		private void EOMGNPFHPBD(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.PFGNPENMJJH.SetFloat("_FoamContrast", (this.maxBlurSize < 1111f) ? 118f : this.maxBlurSize);
			this.PFGNPENMJJH.SetFloat("human_move_2.wav", this.blurArea);
			JONJODLFAEN.filterMode = FilterMode.Point;
			RenderTexture renderTexture = OKIIDHIJBEA;
			if ((float)this.downsample > 1527f)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width >> (this.downsample & -107), JONJODLFAEN.height >> (this.downsample & 56), 0, JONJODLFAEN.format);
				renderTexture.filterMode = FilterMode.Point;
			}
			int num = (int)this.quality;
			num *= 7;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.PFGNPENMJJH, (this.mode == TiltShift.LDNGIJLDOCO.TiltShiftMode) ? num : (num + 1));
			if (this.downsample > 1)
			{
				this.PFGNPENMJJH.SetTexture("", renderTexture);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PFGNPENMJJH, 1);
			}
			if (renderTexture != OKIIDHIJBEA)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600BBE9 RID: 48105 RVA: 0x0054A678 File Offset: 0x00548878
		private void IBIBOJIPANH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.GGJKGIHGMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.PFGNPENMJJH.SetFloat("BlackSmithHammer", (this.maxBlurSize < 427f) ? 782f : this.maxBlurSize);
			this.PFGNPENMJJH.SetFloat("_DstBlend", this.blurArea);
			JONJODLFAEN.filterMode = FilterMode.Point;
			RenderTexture renderTexture = OKIIDHIJBEA;
			if ((float)this.downsample > 179f)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width >> (this.downsample & 32), JONJODLFAEN.height >> (this.downsample & -46), 0, JONJODLFAEN.format);
				renderTexture.filterMode = FilterMode.Point;
			}
			int num = (int)this.quality;
			num *= 2;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.PFGNPENMJJH, (this.mode == TiltShift.LDNGIJLDOCO.TiltShiftMode) ? num : (num + 0));
			if (this.downsample > 1)
			{
				this.PFGNPENMJJH.SetTexture(".png", renderTexture);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PFGNPENMJJH, 5);
			}
			if (renderTexture != OKIIDHIJBEA)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600BBEA RID: 48106 RVA: 0x0054A77D File Offset: 0x0054897D
		public virtual bool HHCKHLDCKMF()
		{
			base.CGEGCOKMPHN(true);
			this.PFGNPENMJJH = base.BAPJBHPEDIF(this.tiltShiftShader, this.PFGNPENMJJH);
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBEB RID: 48107 RVA: 0x0054A7B3 File Offset: 0x005489B3
		public virtual bool DGLPHOKKFDC()
		{
			base.OFKOBOMCECF(true);
			this.PFGNPENMJJH = base.BAPJBHPEDIF(this.tiltShiftShader, this.PFGNPENMJJH);
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBEC RID: 48108 RVA: 0x0054A7E9 File Offset: 0x005489E9
		public virtual bool DKMLGBCDFLG()
		{
			base.BGIALJEIEFO(false);
			this.PFGNPENMJJH = base.JBHLGBPJFEL(this.tiltShiftShader, this.PFGNPENMJJH);
			if (!this.PPGOAMIHMBG)
			{
				base.INOGPLDHPGC();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBED RID: 48109 RVA: 0x0054A81F File Offset: 0x00548A1F
		public virtual bool MKPJEDFPGHB()
		{
			base.DAOKCAOFIGE(true);
			this.PFGNPENMJJH = base.OOAOHFFDMJP(this.tiltShiftShader, this.PFGNPENMJJH);
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBEE RID: 48110 RVA: 0x0054A858 File Offset: 0x00548A58
		private void JMFAMACDLNN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.MNDOFMMGLMO())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.PFGNPENMJJH.SetFloat(" ms", (this.maxBlurSize < 1647f) ? 13f : this.maxBlurSize);
			this.PFGNPENMJJH.SetFloat(" x", this.blurArea);
			JONJODLFAEN.filterMode = FilterMode.Point;
			RenderTexture renderTexture = OKIIDHIJBEA;
			if ((float)this.downsample > 835f)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width >> (this.downsample & -81), JONJODLFAEN.height >> (this.downsample & -21), 1, JONJODLFAEN.format);
				renderTexture.filterMode = FilterMode.Point;
			}
			int num = (int)this.quality;
			num *= 0;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.PFGNPENMJJH, (this.mode == TiltShift.LDNGIJLDOCO.TiltShiftMode) ? num : (num + 1));
			if (this.downsample > 1)
			{
				this.PFGNPENMJJH.SetTexture("[Attachments] Failed to find ProBuilder object on the attachments object '{0}'.", renderTexture);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PFGNPENMJJH, 6);
			}
			if (renderTexture != OKIIDHIJBEA)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600BBEF RID: 48111 RVA: 0x0054A95D File Offset: 0x00548B5D
		public virtual bool AHOEFCADHMC()
		{
			base.NHCAHIHJHMF(false);
			this.PFGNPENMJJH = base.ALJPMGLOIEG(this.tiltShiftShader, this.PFGNPENMJJH);
			if (!this.PPGOAMIHMBG)
			{
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBF0 RID: 48112 RVA: 0x0054A994 File Offset: 0x00548B94
		private void LOPLBCLLCID(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.PFGNPENMJJH.SetFloat("bool: ", (this.maxBlurSize < 23f) ? 1554f : this.maxBlurSize);
			this.PFGNPENMJJH.SetFloat("_SunPosition", this.blurArea);
			JONJODLFAEN.filterMode = FilterMode.Point;
			RenderTexture renderTexture = OKIIDHIJBEA;
			if ((float)this.downsample > 1942f)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width >> (this.downsample & -108), JONJODLFAEN.height >> (this.downsample & 74), 0, JONJODLFAEN.format);
				renderTexture.filterMode = FilterMode.Bilinear;
			}
			int num = (int)this.quality;
			num *= 4;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.PFGNPENMJJH, (this.mode == TiltShift.LDNGIJLDOCO.TiltShiftMode) ? num : (num + 0));
			if (this.downsample > 0)
			{
				this.PFGNPENMJJH.SetTexture("money", renderTexture);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PFGNPENMJJH, 1);
			}
			if (renderTexture != OKIIDHIJBEA)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600BBF1 RID: 48113 RVA: 0x0054AA99 File Offset: 0x00548C99
		public override bool GGJKGIHGMGC()
		{
			base.OFKOBOMCECF(true);
			this.PFGNPENMJJH = base.ALJPMGLOIEG(this.tiltShiftShader, this.PFGNPENMJJH);
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBF2 RID: 48114 RVA: 0x0054AACF File Offset: 0x00548CCF
		public virtual bool PNMIMCJGPGL()
		{
			base.OAAFLHNDKBJ(false);
			this.PFGNPENMJJH = base.JBHLGBPJFEL(this.tiltShiftShader, this.PFGNPENMJJH);
			if (!this.PPGOAMIHMBG)
			{
				base.NAIBIABADFB();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBF3 RID: 48115 RVA: 0x0054AB08 File Offset: 0x00548D08
		private void EEDJEMLFJKP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.PFGNPENMJJH.SetFloat("move", (this.maxBlurSize < 617f) ? 862f : this.maxBlurSize);
			this.PFGNPENMJJH.SetFloat("_camHue", this.blurArea);
			JONJODLFAEN.filterMode = FilterMode.Point;
			RenderTexture renderTexture = OKIIDHIJBEA;
			if ((float)this.downsample > 1415f)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width >> (this.downsample & 111), JONJODLFAEN.height >> (this.downsample & 52), 1, JONJODLFAEN.format);
				renderTexture.filterMode = FilterMode.Bilinear;
			}
			int num = (int)this.quality;
			num *= 1;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.PFGNPENMJJH, (this.mode == TiltShift.LDNGIJLDOCO.TiltShiftMode) ? num : (num + 0));
			if (this.downsample > 1)
			{
				this.PFGNPENMJJH.SetTexture("SUNSHINE_FILTER_PCF_4x4", renderTexture);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PFGNPENMJJH, 1);
			}
			if (renderTexture != OKIIDHIJBEA)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600BBF4 RID: 48116 RVA: 0x0054AC10 File Offset: 0x00548E10
		private void ENEONPFCPMP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.MNDOFMMGLMO())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.PFGNPENMJJH.SetFloat("invn_rec9", (this.maxBlurSize < 1489f) ? 1162f : this.maxBlurSize);
			this.PFGNPENMJJH.SetFloat("", this.blurArea);
			JONJODLFAEN.filterMode = FilterMode.Point;
			RenderTexture renderTexture = OKIIDHIJBEA;
			if ((float)this.downsample > 748f)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width >> (this.downsample & -79), JONJODLFAEN.height >> (this.downsample & -111), 0, JONJODLFAEN.format);
				renderTexture.filterMode = FilterMode.Bilinear;
			}
			int num = (int)this.quality;
			num *= 8;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.PFGNPENMJJH, (this.mode == TiltShift.LDNGIJLDOCO.TiltShiftMode) ? num : (num + 1));
			if (this.downsample > 1)
			{
				this.PFGNPENMJJH.SetTexture("OneHandSwordBackSwing", renderTexture);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PFGNPENMJJH, 3);
			}
			if (renderTexture != OKIIDHIJBEA)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600BBF5 RID: 48117 RVA: 0x0054AD15 File Offset: 0x00548F15
		public virtual bool CKLDIKPLCAO()
		{
			base.IDFIHFBEIKD(false);
			this.PFGNPENMJJH = base.ALJPMGLOIEG(this.tiltShiftShader, this.PFGNPENMJJH);
			if (!this.PPGOAMIHMBG)
			{
				base.INOGPLDHPGC();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBF6 RID: 48118 RVA: 0x0054AD4B File Offset: 0x00548F4B
		public virtual bool ENMKIJNFBFF()
		{
			base.CGEGCOKMPHN(false);
			this.PFGNPENMJJH = base.JBHLGBPJFEL(this.tiltShiftShader, this.PFGNPENMJJH);
			if (!this.PPGOAMIHMBG)
			{
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBF7 RID: 48119 RVA: 0x0054AD84 File Offset: 0x00548F84
		private void IAPMIJOBNKG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.PFGNPENMJJH.SetFloat("Vertical", (this.maxBlurSize < 1005f) ? 1137f : this.maxBlurSize);
			this.PFGNPENMJJH.SetFloat("", this.blurArea);
			JONJODLFAEN.filterMode = FilterMode.Point;
			RenderTexture renderTexture = OKIIDHIJBEA;
			if ((float)this.downsample > 1656f)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width >> (this.downsample & 5), JONJODLFAEN.height >> (this.downsample & -128), 1, JONJODLFAEN.format);
				renderTexture.filterMode = FilterMode.Point;
			}
			int num = (int)this.quality;
			num *= 8;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.PFGNPENMJJH, (this.mode == TiltShift.LDNGIJLDOCO.TiltShiftMode) ? num : (num + 1));
			if (this.downsample > 1)
			{
				this.PFGNPENMJJH.SetTexture("_Params1", renderTexture);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PFGNPENMJJH, 6);
			}
			if (renderTexture != OKIIDHIJBEA)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600BBF8 RID: 48120 RVA: 0x0054AE89 File Offset: 0x00549089
		public virtual bool FLJEDBINFJC()
		{
			base.AHFDGALLKFC(true);
			this.PFGNPENMJJH = base.IIIIADNBONI(this.tiltShiftShader, this.PFGNPENMJJH);
			if (!this.PPGOAMIHMBG)
			{
				base.INOGPLDHPGC();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBFA RID: 48122 RVA: 0x0054AEE4 File Offset: 0x005490E4
		public virtual bool BCBDFDEEILK()
		{
			base.NHCAHIHJHMF(true);
			this.PFGNPENMJJH = base.OOAOHFFDMJP(this.tiltShiftShader, this.PFGNPENMJJH);
			if (!this.PPGOAMIHMBG)
			{
				base.NAIBIABADFB();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBFB RID: 48123 RVA: 0x0054AF1C File Offset: 0x0054911C
		private void GDLPGNLPCMJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.PFGNPENMJJH.SetFloat("_BlurDirectionPacked", (this.maxBlurSize < 603f) ? 677f : this.maxBlurSize);
			this.PFGNPENMJJH.SetFloat("SoccerSprint", this.blurArea);
			JONJODLFAEN.filterMode = FilterMode.Point;
			RenderTexture renderTexture = OKIIDHIJBEA;
			if ((float)this.downsample > 574f)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width >> (this.downsample & -67), JONJODLFAEN.height >> (this.downsample & -56), 1, JONJODLFAEN.format);
				renderTexture.filterMode = FilterMode.Bilinear;
			}
			int num = (int)this.quality;
			num *= 6;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.PFGNPENMJJH, (this.mode == TiltShift.LDNGIJLDOCO.TiltShiftMode) ? num : (num + 0));
			if (this.downsample > 0)
			{
				this.PFGNPENMJJH.SetTexture("MotorbikeLasso", renderTexture);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PFGNPENMJJH, 2);
			}
			if (renderTexture != OKIIDHIJBEA)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600BBFC RID: 48124 RVA: 0x0054B024 File Offset: 0x00549224
		private void OnRenderImage(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.PFGNPENMJJH.SetFloat("_BlurSize", (this.maxBlurSize < 0f) ? 0f : this.maxBlurSize);
			this.PFGNPENMJJH.SetFloat("_BlurArea", this.blurArea);
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			RenderTexture renderTexture = OKIIDHIJBEA;
			if ((float)this.downsample > 0f)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width >> this.downsample, JONJODLFAEN.height >> this.downsample, 0, JONJODLFAEN.format);
				renderTexture.filterMode = FilterMode.Bilinear;
			}
			int num = (int)this.quality;
			num *= 2;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.PFGNPENMJJH, (this.mode == TiltShift.LDNGIJLDOCO.TiltShiftMode) ? num : (num + 1));
			if (this.downsample > 0)
			{
				this.PFGNPENMJJH.SetTexture("_Blurred", renderTexture);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PFGNPENMJJH, 8);
			}
			if (renderTexture != OKIIDHIJBEA)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600BBFD RID: 48125 RVA: 0x0054B12C File Offset: 0x0054932C
		private void GDGPNFLCNEG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.GGJKGIHGMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.PFGNPENMJJH.SetFloat("_NoisePerChannel", (this.maxBlurSize < 1257f) ? 825f : this.maxBlurSize);
			this.PFGNPENMJJH.SetFloat("FOG CUTTING ON", this.blurArea);
			JONJODLFAEN.filterMode = FilterMode.Point;
			RenderTexture renderTexture = OKIIDHIJBEA;
			if ((float)this.downsample > 140f)
			{
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width >> (this.downsample & -42), JONJODLFAEN.height >> (this.downsample & -40), 1, JONJODLFAEN.format);
				renderTexture.filterMode = FilterMode.Point;
			}
			int num = (int)this.quality;
			num *= 3;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.PFGNPENMJJH, (this.mode == TiltShift.LDNGIJLDOCO.TiltShiftMode) ? num : (num + 1));
			if (this.downsample > 0)
			{
				this.PFGNPENMJJH.SetTexture("act_orderb_", renderTexture);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PFGNPENMJJH, 5);
			}
			if (renderTexture != OKIIDHIJBEA)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0400186D RID: 6253
		public TiltShift.LDNGIJLDOCO mode;

		// Token: 0x0400186E RID: 6254
		public TiltShift.EKFNCOIALJO quality = TiltShift.EKFNCOIALJO.Normal;

		// Token: 0x0400186F RID: 6255
		[Range(0f, 15f)]
		public float blurArea = 1f;

		// Token: 0x04001870 RID: 6256
		[Range(0f, 25f)]
		public float maxBlurSize = 5f;

		// Token: 0x04001871 RID: 6257
		[Range(0f, 1f)]
		public int downsample;

		// Token: 0x04001872 RID: 6258
		public Shader tiltShiftShader;

		// Token: 0x04001873 RID: 6259
		private Material PFGNPENMJJH;

		// Token: 0x02000336 RID: 822
		public enum LDNGIJLDOCO
		{
			// Token: 0x04001875 RID: 6261
			TiltShiftMode,
			// Token: 0x04001876 RID: 6262
			IrisMode
		}

		// Token: 0x02000337 RID: 823
		public enum EKFNCOIALJO
		{
			// Token: 0x04001878 RID: 6264
			Preview,
			// Token: 0x04001879 RID: 6265
			Low,
			// Token: 0x0400187A RID: 6266
			Normal,
			// Token: 0x0400187B RID: 6267
			High
		}
	}
}
