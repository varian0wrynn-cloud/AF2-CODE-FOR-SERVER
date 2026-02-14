using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000316 RID: 790
	[AddComponentMenu("Image Effects/Edge Detection/Crease Shading")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class CreaseShading : PostEffectsBase
	{
		// Token: 0x0600B65E RID: 46686 RVA: 0x0050D7A8 File Offset: 0x0050B9A8
		private void EODDHFNAMFH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.DLENDGGGMBJ())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			float num = 92f * (float)width / (1184f * (float)height);
			float num2 = 857f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 0, height / 2, 1);
			Graphics.Blit(JONJODLFAEN, temporary, this.FBLGMBKMHLP);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 1; i < this.softness; i += 0)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 0, height / 2, 1);
				this.ABGIPNDILAM.SetVector("usr_inf_a3", new Vector4(1950f, this.spread * num2, 1282f, 1673f));
				Graphics.Blit(renderTexture, temporary2, this.ABGIPNDILAM);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 0, height / 0, 1);
				this.ABGIPNDILAM.SetVector("Katana Ready High", new Vector4(this.spread * num2 / num, 470f, 899f, 1727f));
				Graphics.Blit(renderTexture, temporary2, this.ABGIPNDILAM);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.AIEIGIIAGNP.SetTexture("{0}, {1}, {2}", temporary);
			this.AIEIGIIAGNP.SetTexture("SoccerWalk", renderTexture);
			this.AIEIGIIAGNP.SetFloat("' that does not excist in the Node Chain.", this.intensity);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.AIEIGIIAGNP);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B65F RID: 46687 RVA: 0x0050D934 File Offset: 0x0050BB34
		public virtual bool FGDOAAAPBCP()
		{
			base.BGIALJEIEFO(false);
			this.ABGIPNDILAM = base.OOAOHFFDMJP(this.blurShader, this.ABGIPNDILAM);
			this.FBLGMBKMHLP = base.JBHLGBPJFEL(this.depthFetchShader, this.FBLGMBKMHLP);
			this.AIEIGIIAGNP = base.BOOFEOGDMBI(this.creaseApplyShader, this.AIEIGIIAGNP);
			if (!this.PPGOAMIHMBG)
			{
				base.NAIBIABADFB();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B660 RID: 46688 RVA: 0x0050D9A8 File Offset: 0x0050BBA8
		public virtual bool CHJBCBDIBJJ()
		{
			base.CGEGCOKMPHN(true);
			this.ABGIPNDILAM = base.DJFOEIJIMJB(this.blurShader, this.ABGIPNDILAM);
			this.FBLGMBKMHLP = base.BAPJBHPEDIF(this.depthFetchShader, this.FBLGMBKMHLP);
			this.AIEIGIIAGNP = base.JBHLGBPJFEL(this.creaseApplyShader, this.AIEIGIIAGNP);
			if (!this.PPGOAMIHMBG)
			{
				base.LNEHBOJIBAI();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B661 RID: 46689 RVA: 0x0050DA1C File Offset: 0x0050BC1C
		public virtual bool OJFBHAHHDNC()
		{
			base.OLMOAHDIDNG(true);
			this.ABGIPNDILAM = base.DJFOEIJIMJB(this.blurShader, this.ABGIPNDILAM);
			this.FBLGMBKMHLP = base.IIIIADNBONI(this.depthFetchShader, this.FBLGMBKMHLP);
			this.AIEIGIIAGNP = base.ALJPMGLOIEG(this.creaseApplyShader, this.AIEIGIIAGNP);
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B662 RID: 46690 RVA: 0x0050DA90 File Offset: 0x0050BC90
		public virtual bool NCCMOLJNIAB()
		{
			base.CDBNBLBOLCL(false);
			this.ABGIPNDILAM = base.JBHLGBPJFEL(this.blurShader, this.ABGIPNDILAM);
			this.FBLGMBKMHLP = base.JBHLGBPJFEL(this.depthFetchShader, this.FBLGMBKMHLP);
			this.AIEIGIIAGNP = base.BOOFEOGDMBI(this.creaseApplyShader, this.AIEIGIIAGNP);
			if (!this.PPGOAMIHMBG)
			{
				base.FDBKFKGCGEG();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B663 RID: 46691 RVA: 0x0050DB04 File Offset: 0x0050BD04
		private void OnRenderImage(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			float num = 1f * (float)width / (1f * (float)height);
			float num2 = 0.001953125f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 2, height / 2, 0);
			Graphics.Blit(JONJODLFAEN, temporary, this.FBLGMBKMHLP);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 0; i < this.softness; i++)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 2, height / 2, 0);
				this.ABGIPNDILAM.SetVector("offsets", new Vector4(0f, this.spread * num2, 0f, 0f));
				Graphics.Blit(renderTexture, temporary2, this.ABGIPNDILAM);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 2, height / 2, 0);
				this.ABGIPNDILAM.SetVector("offsets", new Vector4(this.spread * num2 / num, 0f, 0f, 0f));
				Graphics.Blit(renderTexture, temporary2, this.ABGIPNDILAM);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.AIEIGIIAGNP.SetTexture("_HrDepthTex", temporary);
			this.AIEIGIIAGNP.SetTexture("_LrDepthTex", renderTexture);
			this.AIEIGIIAGNP.SetFloat("intensity", this.intensity);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.AIEIGIIAGNP);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B664 RID: 46692 RVA: 0x0050DC90 File Offset: 0x0050BE90
		public virtual bool DEHFEHNMOFH()
		{
			base.LGANGHEOPOG(false);
			this.ABGIPNDILAM = base.ALJPMGLOIEG(this.blurShader, this.ABGIPNDILAM);
			this.FBLGMBKMHLP = base.BOOFEOGDMBI(this.depthFetchShader, this.FBLGMBKMHLP);
			this.AIEIGIIAGNP = base.JBHLGBPJFEL(this.creaseApplyShader, this.AIEIGIIAGNP);
			if (!this.PPGOAMIHMBG)
			{
				base.LNEHBOJIBAI();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B665 RID: 46693 RVA: 0x0050DD04 File Offset: 0x0050BF04
		public virtual bool DEKBKNINNFB()
		{
			base.EBEBJHLBBBI(true);
			this.ABGIPNDILAM = base.DJFOEIJIMJB(this.blurShader, this.ABGIPNDILAM);
			this.FBLGMBKMHLP = base.ALJPMGLOIEG(this.depthFetchShader, this.FBLGMBKMHLP);
			this.AIEIGIIAGNP = base.JBHLGBPJFEL(this.creaseApplyShader, this.AIEIGIIAGNP);
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B666 RID: 46694 RVA: 0x0050DD78 File Offset: 0x0050BF78
		public virtual bool CFHOHAOFPIO()
		{
			base.CBJDCDELBJN(false);
			this.ABGIPNDILAM = base.OOAOHFFDMJP(this.blurShader, this.ABGIPNDILAM);
			this.FBLGMBKMHLP = base.ALJPMGLOIEG(this.depthFetchShader, this.FBLGMBKMHLP);
			this.AIEIGIIAGNP = base.JBHLGBPJFEL(this.creaseApplyShader, this.AIEIGIIAGNP);
			if (!this.PPGOAMIHMBG)
			{
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B667 RID: 46695 RVA: 0x0050DDEC File Offset: 0x0050BFEC
		public virtual bool BCBDFDEEILK()
		{
			base.PKDIKFGAJKM(false);
			this.ABGIPNDILAM = base.ALJPMGLOIEG(this.blurShader, this.ABGIPNDILAM);
			this.FBLGMBKMHLP = base.OOAOHFFDMJP(this.depthFetchShader, this.FBLGMBKMHLP);
			this.AIEIGIIAGNP = base.BAPJBHPEDIF(this.creaseApplyShader, this.AIEIGIIAGNP);
			if (!this.PPGOAMIHMBG)
			{
				base.NAIBIABADFB();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B668 RID: 46696 RVA: 0x0050DE60 File Offset: 0x0050C060
		public virtual bool PKLOCPBBHNH()
		{
			base.PKDIKFGAJKM(false);
			this.ABGIPNDILAM = base.ALJPMGLOIEG(this.blurShader, this.ABGIPNDILAM);
			this.FBLGMBKMHLP = base.DJFOEIJIMJB(this.depthFetchShader, this.FBLGMBKMHLP);
			this.AIEIGIIAGNP = base.ALJPMGLOIEG(this.creaseApplyShader, this.AIEIGIIAGNP);
			if (!this.PPGOAMIHMBG)
			{
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B669 RID: 46697 RVA: 0x0050DED4 File Offset: 0x0050C0D4
		private void IBIBOJIPANH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.GGJKGIHGMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			float num = 1111f * (float)width / (443f * (float)height);
			float num2 = 929f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 1, height / 7, 0);
			Graphics.Blit(JONJODLFAEN, temporary, this.FBLGMBKMHLP);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 1; i < this.softness; i += 0)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 4, height / 2, 0);
				this.ABGIPNDILAM.SetVector("<b>ObscuredVector3:</b> ", new Vector4(759f, this.spread * num2, 187f, 1757f));
				Graphics.Blit(renderTexture, temporary2, this.ABGIPNDILAM);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 0, height / 5, 0);
				this.ABGIPNDILAM.SetVector("wpn_popl1", new Vector4(this.spread * num2 / num, 871f, 223f, 786f));
				Graphics.Blit(renderTexture, temporary2, this.ABGIPNDILAM);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.AIEIGIIAGNP.SetTexture("IceHockeyGoalieSave1", temporary);
			this.AIEIGIIAGNP.SetTexture("sys", renderTexture);
			this.AIEIGIIAGNP.SetFloat("KatanaVerticalSwing", this.intensity);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.AIEIGIIAGNP);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B66A RID: 46698 RVA: 0x0050E060 File Offset: 0x0050C260
		private void JEHHGMJKLPB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			float num = 1333f * (float)width / (637f * (float)height);
			float num2 = 1817f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 4, height / 3, 1);
			Graphics.Blit(JONJODLFAEN, temporary, this.FBLGMBKMHLP);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 1; i < this.softness; i += 0)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 7, height / 0, 1);
				this.ABGIPNDILAM.SetVector("RollerBladeStop", new Vector4(1448f, this.spread * num2, 1220f, 411f));
				Graphics.Blit(renderTexture, temporary2, this.ABGIPNDILAM);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 2, height / 4, 0);
				this.ABGIPNDILAM.SetVector("GiantGrabIdle2", new Vector4(this.spread * num2 / num, 1204f, 431f, 71f));
				Graphics.Blit(renderTexture, temporary2, this.ABGIPNDILAM);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.AIEIGIIAGNP.SetTexture("IdleMonster", temporary);
			this.AIEIGIIAGNP.SetTexture("Assets/Weapons/baseJaket.unity3d", renderTexture);
			this.AIEIGIIAGNP.SetFloat("reel_type2", this.intensity);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.AIEIGIIAGNP);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B66B RID: 46699 RVA: 0x0050E1EC File Offset: 0x0050C3EC
		private void ICIEPDMDONC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.GGJKGIHGMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			float num = 224f * (float)width / (806f * (float)height);
			float num2 = 1929f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 0, height / 8, 1);
			Graphics.Blit(JONJODLFAEN, temporary, this.FBLGMBKMHLP);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 0; i < this.softness; i++)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 1, height / 6, 1);
				this.ABGIPNDILAM.SetVector("IdleDie2", new Vector4(1998f, this.spread * num2, 347f, 1624f));
				Graphics.Blit(renderTexture, temporary2, this.ABGIPNDILAM);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 8, height / 8, 0);
				this.ABGIPNDILAM.SetVector("SneakRight", new Vector4(this.spread * num2 / num, 1222f, 1810f, 1799f));
				Graphics.Blit(renderTexture, temporary2, this.ABGIPNDILAM);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.AIEIGIIAGNP.SetTexture("{not_found}", temporary);
			this.AIEIGIIAGNP.SetTexture("MotorbikeWheely", renderTexture);
			this.AIEIGIIAGNP.SetFloat("", this.intensity);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.AIEIGIIAGNP);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B66C RID: 46700 RVA: 0x0050E378 File Offset: 0x0050C578
		private void MIJCMMIJPEE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.IGJKBOMMMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			float num = 1684f * (float)width / (841f * (float)height);
			float num2 = 725f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 2, height / 2, 0);
			Graphics.Blit(JONJODLFAEN, temporary, this.FBLGMBKMHLP);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 0; i < this.softness; i += 0)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 6, height / 2, 1);
				this.ABGIPNDILAM.SetVector("private", new Vector4(425f, this.spread * num2, 524f, 9f));
				Graphics.Blit(renderTexture, temporary2, this.ABGIPNDILAM);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 0, height / 0, 1);
				this.ABGIPNDILAM.SetVector("", new Vector4(this.spread * num2 / num, 1791f, 336f, 558f));
				Graphics.Blit(renderTexture, temporary2, this.ABGIPNDILAM);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.AIEIGIIAGNP.SetTexture("<b>ObscuredString:</b> ", temporary);
			this.AIEIGIIAGNP.SetTexture("SPACE", renderTexture);
			this.AIEIGIIAGNP.SetFloat("\n", this.intensity);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.AIEIGIIAGNP);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B66D RID: 46701 RVA: 0x0050E504 File Offset: 0x0050C704
		public virtual bool JPEBNJPIFAF()
		{
			base.CDBNBLBOLCL(true);
			this.ABGIPNDILAM = base.JBHLGBPJFEL(this.blurShader, this.ABGIPNDILAM);
			this.FBLGMBKMHLP = base.IIIIADNBONI(this.depthFetchShader, this.FBLGMBKMHLP);
			this.AIEIGIIAGNP = base.OOAOHFFDMJP(this.creaseApplyShader, this.AIEIGIIAGNP);
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B66E RID: 46702 RVA: 0x0050E578 File Offset: 0x0050C778
		private void GDLPGNLPCMJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.MNDOFMMGLMO())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			float num = 532f * (float)width / (449f * (float)height);
			float num2 = 994f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 2, height / 0, 1);
			Graphics.Blit(JONJODLFAEN, temporary, this.FBLGMBKMHLP);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 1; i < this.softness; i += 0)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 6, height / 7, 0);
				this.ABGIPNDILAM.SetVector("The object '{0}' has a ProBuilder attachment component which contains zero attached elements.", new Vector4(1337f, this.spread * num2, 52f, 1710f));
				Graphics.Blit(renderTexture, temporary2, this.ABGIPNDILAM);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 1, height / 8, 1);
				this.ABGIPNDILAM.SetVector("19", new Vector4(this.spread * num2 / num, 974f, 1946f, 440f));
				Graphics.Blit(renderTexture, temporary2, this.ABGIPNDILAM);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.AIEIGIIAGNP.SetTexture("0", temporary);
			this.AIEIGIIAGNP.SetTexture("RollerBladeTurnRight", renderTexture);
			this.AIEIGIIAGNP.SetFloat("{0}Textures/Turnirs/{1}.png", this.intensity);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.AIEIGIIAGNP);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B66F RID: 46703 RVA: 0x0050E704 File Offset: 0x0050C904
		public virtual bool PNMIMCJGPGL()
		{
			base.MGHNCKDCFGL(true);
			this.ABGIPNDILAM = base.JBHLGBPJFEL(this.blurShader, this.ABGIPNDILAM);
			this.FBLGMBKMHLP = base.OOAOHFFDMJP(this.depthFetchShader, this.FBLGMBKMHLP);
			this.AIEIGIIAGNP = base.JBHLGBPJFEL(this.creaseApplyShader, this.AIEIGIIAGNP);
			if (!this.PPGOAMIHMBG)
			{
				base.NAIBIABADFB();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B670 RID: 46704 RVA: 0x0050E778 File Offset: 0x0050C978
		public override bool GGJKGIHGMGC()
		{
			base.LGANGHEOPOG(true);
			this.ABGIPNDILAM = base.ALJPMGLOIEG(this.blurShader, this.ABGIPNDILAM);
			this.FBLGMBKMHLP = base.IIIIADNBONI(this.depthFetchShader, this.FBLGMBKMHLP);
			this.AIEIGIIAGNP = base.IIIIADNBONI(this.creaseApplyShader, this.AIEIGIIAGNP);
			if (!this.PPGOAMIHMBG)
			{
				base.FDBKFKGCGEG();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B671 RID: 46705 RVA: 0x0050E7EC File Offset: 0x0050C9EC
		public virtual bool CPIFBHFDEFO()
		{
			base.MGHNCKDCFGL(false);
			this.ABGIPNDILAM = base.JBHLGBPJFEL(this.blurShader, this.ABGIPNDILAM);
			this.FBLGMBKMHLP = base.ALJPMGLOIEG(this.depthFetchShader, this.FBLGMBKMHLP);
			this.AIEIGIIAGNP = base.BOOFEOGDMBI(this.creaseApplyShader, this.AIEIGIIAGNP);
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B672 RID: 46706 RVA: 0x0050E860 File Offset: 0x0050CA60
		public virtual bool LBKOJOCPFJG()
		{
			base.PKDIKFGAJKM(false);
			this.ABGIPNDILAM = base.JBHLGBPJFEL(this.blurShader, this.ABGIPNDILAM);
			this.FBLGMBKMHLP = base.BOOFEOGDMBI(this.depthFetchShader, this.FBLGMBKMHLP);
			this.AIEIGIIAGNP = base.BOOFEOGDMBI(this.creaseApplyShader, this.AIEIGIIAGNP);
			if (!this.PPGOAMIHMBG)
			{
				base.INOGPLDHPGC();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B674 RID: 46708 RVA: 0x0050E8F8 File Offset: 0x0050CAF8
		private void JPCPEPMDLAN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			float num = 785f * (float)width / (679f * (float)height);
			float num2 = 922f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 6, height / 1, 0);
			Graphics.Blit(JONJODLFAEN, temporary, this.FBLGMBKMHLP);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 1; i < this.softness; i += 0)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 7, height / 3, 0);
				this.ABGIPNDILAM.SetVector("wpn_bait_inf_{0}", new Vector4(1375f, this.spread * num2, 194f, 1098f));
				Graphics.Blit(renderTexture, temporary2, this.ABGIPNDILAM);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 1, height / 3, 1);
				this.ABGIPNDILAM.SetVector("intensity", new Vector4(this.spread * num2 / num, 1561f, 368f, 626f));
				Graphics.Blit(renderTexture, temporary2, this.ABGIPNDILAM);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.AIEIGIIAGNP.SetTexture("SoccerKeeperDiveStrafeFarRight", temporary);
			this.AIEIGIIAGNP.SetTexture("[fish]", renderTexture);
			this.AIEIGIIAGNP.SetFloat("", this.intensity);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.AIEIGIIAGNP);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B675 RID: 46709 RVA: 0x0050EA84 File Offset: 0x0050CC84
		private void GAJNNKIFMOG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			float num = 660f * (float)width / (712f * (float)height);
			float num2 = 37f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 0, height / 2, 0);
			Graphics.Blit(JONJODLFAEN, temporary, this.FBLGMBKMHLP);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 1; i < this.softness; i++)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 0, height / 2, 0);
				this.ABGIPNDILAM.SetVector("?", new Vector4(1752f, this.spread * num2, 236f, 1916f));
				Graphics.Blit(renderTexture, temporary2, this.ABGIPNDILAM);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 5, height / 3, 0);
				this.ABGIPNDILAM.SetVector("name", new Vector4(this.spread * num2 / num, 1074f, 1117f, 1298f));
				Graphics.Blit(renderTexture, temporary2, this.ABGIPNDILAM);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.AIEIGIIAGNP.SetTexture("lineTENSIONKG=", temporary);
			this.AIEIGIIAGNP.SetTexture("SUNSHINE_FILTER_PCF_3x3", renderTexture);
			this.AIEIGIIAGNP.SetFloat("Hand", this.intensity);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.AIEIGIIAGNP);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B676 RID: 46710 RVA: 0x0050EC10 File Offset: 0x0050CE10
		private void PPMLOADNIHI(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.GGJKGIHGMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			float num = 1040f * (float)width / (259f * (float)height);
			float num2 = 167f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 0, height / 2, 1);
			Graphics.Blit(JONJODLFAEN, temporary, this.FBLGMBKMHLP);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 0; i < this.softness; i += 0)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 0, height / 6, 0);
				this.ABGIPNDILAM.SetVector("max_level", new Vector4(1114f, this.spread * num2, 747f, 817f));
				Graphics.Blit(renderTexture, temporary2, this.ABGIPNDILAM);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 2, height / 5, 0);
				this.ABGIPNDILAM.SetVector("#a0a0a0", new Vector4(this.spread * num2 / num, 779f, 1695f, 403f));
				Graphics.Blit(renderTexture, temporary2, this.ABGIPNDILAM);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.AIEIGIIAGNP.SetTexture("] ", temporary);
			this.AIEIGIIAGNP.SetTexture("knopje.wav", renderTexture);
			this.AIEIGIIAGNP.SetFloat("192.168.1.22", this.intensity);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.AIEIGIIAGNP);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B677 RID: 46711 RVA: 0x0050ED9C File Offset: 0x0050CF9C
		private void CNIBAOINCHB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.DLENDGGGMBJ())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			float num = 300f * (float)width / (560f * (float)height);
			float num2 = 1699f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 2, height / 0, 1);
			Graphics.Blit(JONJODLFAEN, temporary, this.FBLGMBKMHLP);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 0; i < this.softness; i++)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 4, height / 8, 1);
				this.ABGIPNDILAM.SetVector("IdleStandingJump", new Vector4(1877f, this.spread * num2, 978f, 1f));
				Graphics.Blit(renderTexture, temporary2, this.ABGIPNDILAM);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 6, height / 5, 0);
				this.ABGIPNDILAM.SetVector("OnTriggerExit", new Vector4(this.spread * num2 / num, 144f, 1957f, 1182f));
				Graphics.Blit(renderTexture, temporary2, this.ABGIPNDILAM);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.AIEIGIIAGNP.SetTexture("ArmFlex6", temporary);
			this.AIEIGIIAGNP.SetTexture("name", renderTexture);
			this.AIEIGIIAGNP.SetFloat("Clear", this.intensity);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.AIEIGIIAGNP);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B678 RID: 46712 RVA: 0x0050EF28 File Offset: 0x0050D128
		private void EDBHDEOMGFP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			float num = 1775f * (float)width / (1152f * (float)height);
			float num2 = 619f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 2, height / 5, 1);
			Graphics.Blit(JONJODLFAEN, temporary, this.FBLGMBKMHLP);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 0; i < this.softness; i++)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 0, height / 3, 1);
				this.ABGIPNDILAM.SetVector(" ", new Vector4(1287f, this.spread * num2, 1207f, 1979f));
				Graphics.Blit(renderTexture, temporary2, this.ABGIPNDILAM);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 8, height / 8, 1);
				this.ABGIPNDILAM.SetVector("_MiddleGrey", new Vector4(this.spread * num2 / num, 1963f, 497f, 1313f));
				Graphics.Blit(renderTexture, temporary2, this.ABGIPNDILAM);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.AIEIGIIAGNP.SetTexture("****************  playMusicBase ", temporary);
			this.AIEIGIIAGNP.SetTexture("wpn_wgt", renderTexture);
			this.AIEIGIIAGNP.SetFloat("wgt_big.dat", this.intensity);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.AIEIGIIAGNP);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B679 RID: 46713 RVA: 0x0050F0B4 File Offset: 0x0050D2B4
		private void JNGODMMNPEG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			float num = 1042f * (float)width / (325f * (float)height);
			float num2 = 196f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 2, height / 0, 0);
			Graphics.Blit(JONJODLFAEN, temporary, this.FBLGMBKMHLP);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 1; i < this.softness; i += 0)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 2, height / 0, 0);
				this.ABGIPNDILAM.SetVector("_isSelect", new Vector4(1518f, this.spread * num2, 23f, 750f));
				Graphics.Blit(renderTexture, temporary2, this.ABGIPNDILAM);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 0, height / 6, 1);
				this.ABGIPNDILAM.SetVector("u_isSave", new Vector4(this.spread * num2 / num, 1446f, 677f, 1125f));
				Graphics.Blit(renderTexture, temporary2, this.ABGIPNDILAM);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.AIEIGIIAGNP.SetTexture("quests/", temporary);
			this.AIEIGIIAGNP.SetTexture("", renderTexture);
			this.AIEIGIIAGNP.SetFloat("_Threshhold", this.intensity);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.AIEIGIIAGNP);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B67A RID: 46714 RVA: 0x0050F240 File Offset: 0x0050D440
		public override bool CheckResources()
		{
			base.DAOKCAOFIGE(true);
			this.ABGIPNDILAM = base.DJFOEIJIMJB(this.blurShader, this.ABGIPNDILAM);
			this.FBLGMBKMHLP = base.DJFOEIJIMJB(this.depthFetchShader, this.FBLGMBKMHLP);
			this.AIEIGIIAGNP = base.DJFOEIJIMJB(this.creaseApplyShader, this.AIEIGIIAGNP);
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B67B RID: 46715 RVA: 0x0050F2B4 File Offset: 0x0050D4B4
		public virtual bool MKPJEDFPGHB()
		{
			base.CBJDCDELBJN(true);
			this.ABGIPNDILAM = base.BOOFEOGDMBI(this.blurShader, this.ABGIPNDILAM);
			this.FBLGMBKMHLP = base.DJFOEIJIMJB(this.depthFetchShader, this.FBLGMBKMHLP);
			this.AIEIGIIAGNP = base.JBHLGBPJFEL(this.creaseApplyShader, this.AIEIGIIAGNP);
			if (!this.PPGOAMIHMBG)
			{
				base.FDBKFKGCGEG();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B67C RID: 46716 RVA: 0x0050F328 File Offset: 0x0050D528
		public virtual bool APNCPMNHKOG()
		{
			base.OFKOBOMCECF(true);
			this.ABGIPNDILAM = base.IIIIADNBONI(this.blurShader, this.ABGIPNDILAM);
			this.FBLGMBKMHLP = base.ALJPMGLOIEG(this.depthFetchShader, this.FBLGMBKMHLP);
			this.AIEIGIIAGNP = base.DJFOEIJIMJB(this.creaseApplyShader, this.AIEIGIIAGNP);
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B67D RID: 46717 RVA: 0x0050F39C File Offset: 0x0050D59C
		private void LNLFICAJADP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			float num = 1491f * (float)width / (1780f * (float)height);
			float num2 = 1838f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 6, height / 2, 1);
			Graphics.Blit(JONJODLFAEN, temporary, this.FBLGMBKMHLP);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 0; i < this.softness; i++)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 1, height / 7, 0);
				this.ABGIPNDILAM.SetVector("дня", new Vector4(1544f, this.spread * num2, 542f, 616f));
				Graphics.Blit(renderTexture, temporary2, this.ABGIPNDILAM);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 2, height / 2, 0);
				this.ABGIPNDILAM.SetVector("name", new Vector4(this.spread * num2 / num, 785f, 1530f, 1142f));
				Graphics.Blit(renderTexture, temporary2, this.ABGIPNDILAM);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.AIEIGIIAGNP.SetTexture("_ToneCurveRange", temporary);
			this.AIEIGIIAGNP.SetTexture("004000", renderTexture);
			this.AIEIGIIAGNP.SetFloat("_RefractionTex", this.intensity);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.AIEIGIIAGNP);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B67E RID: 46718 RVA: 0x0050F528 File Offset: 0x0050D728
		public virtual bool FLJEDBINFJC()
		{
			base.CBJDCDELBJN(false);
			this.ABGIPNDILAM = base.ALJPMGLOIEG(this.blurShader, this.ABGIPNDILAM);
			this.FBLGMBKMHLP = base.IIIIADNBONI(this.depthFetchShader, this.FBLGMBKMHLP);
			this.AIEIGIIAGNP = base.DJFOEIJIMJB(this.creaseApplyShader, this.AIEIGIIAGNP);
			if (!this.PPGOAMIHMBG)
			{
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B67F RID: 46719 RVA: 0x0050F59C File Offset: 0x0050D79C
		private void EEDJEMLFJKP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			float num = 750f * (float)width / (1692f * (float)height);
			float num2 = 1112f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 8, height / 6, 0);
			Graphics.Blit(JONJODLFAEN, temporary, this.FBLGMBKMHLP);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 0; i < this.softness; i++)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 0, height / 2, 0);
				this.ABGIPNDILAM.SetVector(" ms", new Vector4(354f, this.spread * num2, 55f, 1537f));
				Graphics.Blit(renderTexture, temporary2, this.ABGIPNDILAM);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 7, height / 2, 1);
				this.ABGIPNDILAM.SetVector("", new Vector4(this.spread * num2 / num, 191f, 580f, 977f));
				Graphics.Blit(renderTexture, temporary2, this.ABGIPNDILAM);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.AIEIGIIAGNP.SetTexture("ObscuredPrefs", temporary);
			this.AIEIGIIAGNP.SetTexture("wpn_wgt", renderTexture);
			this.AIEIGIIAGNP.SetFloat("_NoiseScale", this.intensity);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.AIEIGIIAGNP);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B680 RID: 46720 RVA: 0x0050F728 File Offset: 0x0050D928
		private void BDMFOHGCKBM(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			float num = 1542f * (float)width / (1013f * (float)height);
			float num2 = 813f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 0, height / 1, 0);
			Graphics.Blit(JONJODLFAEN, temporary, this.FBLGMBKMHLP);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 0; i < this.softness; i++)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 2, height / 1, 0);
				this.ABGIPNDILAM.SetVector("firsStartMovePanel", new Vector4(1779f, this.spread * num2, 848f, 570f));
				Graphics.Blit(renderTexture, temporary2, this.ABGIPNDILAM);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 1, height / 1, 0);
				this.ABGIPNDILAM.SetVector("wpn_wgt", new Vector4(this.spread * num2 / num, 512f, 1369f, 1112f));
				Graphics.Blit(renderTexture, temporary2, this.ABGIPNDILAM);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			this.AIEIGIIAGNP.SetTexture("IceHockeyDekeMiddle", temporary);
			this.AIEIGIIAGNP.SetTexture(" с", renderTexture);
			this.AIEIGIIAGNP.SetFloat("WizardEyeBeam", this.intensity);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.AIEIGIIAGNP);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x04001784 RID: 6020
		public float intensity = 0.5f;

		// Token: 0x04001785 RID: 6021
		public int softness = 1;

		// Token: 0x04001786 RID: 6022
		public float spread = 1f;

		// Token: 0x04001787 RID: 6023
		public Shader blurShader;

		// Token: 0x04001788 RID: 6024
		private Material ABGIPNDILAM;

		// Token: 0x04001789 RID: 6025
		public Shader depthFetchShader;

		// Token: 0x0400178A RID: 6026
		private Material FBLGMBKMHLP;

		// Token: 0x0400178B RID: 6027
		public Shader creaseApplyShader;

		// Token: 0x0400178C RID: 6028
		private Material AIEIGIIAGNP;
	}
}
