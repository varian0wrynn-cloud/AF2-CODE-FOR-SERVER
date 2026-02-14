using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x020002FD RID: 765
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Bloom and Glow/Bloom")]
	public class Bloom : PostEffectsBase
	{
		// Token: 0x0600B2F7 RID: 45815 RVA: 0x004E309A File Offset: 0x004E129A
		private void LCECMBOEGIM(float JLEHAHJEIAC, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.PJECOFONCFN.SetVector("auc_wcstc", new Vector4(JLEHAHJEIAC, JLEHAHJEIAC, JLEHAHJEIAC, JLEHAHJEIAC));
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.PJECOFONCFN, 0);
		}

		// Token: 0x0600B2F8 RID: 45816 RVA: 0x004E30C4 File Offset: 0x004E12C4
		public virtual bool APNCPMNHKOG()
		{
			base.OLMOAHDIDNG(false);
			this.GILHCCIHPGN = base.DJFOEIJIMJB(this.screenBlendShader, this.GILHCCIHPGN);
			this.FGKGIFAKMKL = base.BOOFEOGDMBI(this.lensFlareShader, this.FGKGIFAKMKL);
			this.GMELFMBEPNK = base.BOOFEOGDMBI(this.blurAndFlaresShader, this.GMELFMBEPNK);
			this.PJECOFONCFN = base.DJFOEIJIMJB(this.brightPassFilterShader, this.PJECOFONCFN);
			if (!this.PPGOAMIHMBG)
			{
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B2F9 RID: 45817 RVA: 0x004E314D File Offset: 0x004E134D
		private void JNICBDJEOAC(float JLEHAHJEIAC, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.PJECOFONCFN.SetVector("BattleRoar", new Vector4(JLEHAHJEIAC, JLEHAHJEIAC, JLEHAHJEIAC, JLEHAHJEIAC));
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.PJECOFONCFN, 0);
		}

		// Token: 0x0600B2FB RID: 45819 RVA: 0x004E3278 File Offset: 0x004E1478
		public virtual bool OJFBHAHHDNC()
		{
			base.EHGENDOEHLP(false);
			this.GILHCCIHPGN = base.DJFOEIJIMJB(this.screenBlendShader, this.GILHCCIHPGN);
			this.FGKGIFAKMKL = base.OOAOHFFDMJP(this.lensFlareShader, this.FGKGIFAKMKL);
			this.GMELFMBEPNK = base.ALJPMGLOIEG(this.blurAndFlaresShader, this.GMELFMBEPNK);
			this.PJECOFONCFN = base.JBHLGBPJFEL(this.brightPassFilterShader, this.PJECOFONCFN);
			if (!this.PPGOAMIHMBG)
			{
				base.OAEAMDHOKKM();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B2FC RID: 45820 RVA: 0x004E3304 File Offset: 0x004E1504
		public void OnRenderImage(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.GEBCPMDEOEA = false;
			if (this.hdr == Bloom.MJILBJJNNHP.Auto)
			{
				this.GEBCPMDEOEA = (JONJODLFAEN.format == RenderTextureFormat.ARGBHalf && base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.GEBCPMDEOEA = (this.hdr == Bloom.MJILBJJNNHP.On);
			}
			this.GEBCPMDEOEA = (this.GEBCPMDEOEA && this.KKGBEAPGBOD);
			Bloom.IGBEHECLGJO igbeheclgjo = this.screenBlendMode;
			if (this.GEBCPMDEOEA)
			{
				igbeheclgjo = Bloom.IGBEHECLGJO.Add;
			}
			RenderTextureFormat format = this.GEBCPMDEOEA ? RenderTextureFormat.ARGBHalf : RenderTextureFormat.Default;
			int width = JONJODLFAEN.width / 2;
			int height = JONJODLFAEN.height / 2;
			int width2 = JONJODLFAEN.width / 4;
			int height2 = JONJODLFAEN.height / 4;
			float num = 1f * (float)JONJODLFAEN.width / (1f * (float)JONJODLFAEN.height);
			float num2 = 0.001953125f;
			RenderTexture temporary = RenderTexture.GetTemporary(width2, height2, 0, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0, format);
			if (this.quality > Bloom.OFHOJEKJJDI.Cheap)
			{
				Graphics.Blit(JONJODLFAEN, temporary2, this.GILHCCIHPGN, 2);
				RenderTexture temporary3 = RenderTexture.GetTemporary(width2, height2, 0, format);
				Graphics.Blit(temporary2, temporary3, this.GILHCCIHPGN, 2);
				Graphics.Blit(temporary3, temporary, this.GILHCCIHPGN, 6);
				RenderTexture.ReleaseTemporary(temporary3);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary2);
				Graphics.Blit(temporary2, temporary, this.GILHCCIHPGN, 6);
			}
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width2, height2, 0, format);
			this.DNGLHLEGCOE(this.bloomThreshold * this.bloomThresholdColor, temporary, renderTexture);
			if (this.bloomBlurIterations < 1)
			{
				this.bloomBlurIterations = 1;
			}
			else if (this.bloomBlurIterations > 10)
			{
				this.bloomBlurIterations = 10;
			}
			for (int i = 0; i < this.bloomBlurIterations; i++)
			{
				float num3 = (1f + (float)i * 0.25f) * this.sepBlurSpread;
				RenderTexture temporary4 = RenderTexture.GetTemporary(width2, height2, 0, format);
				this.GMELFMBEPNK.SetVector("_Offsets", new Vector4(0f, num3 * num2, 0f, 0f));
				Graphics.Blit(renderTexture, temporary4, this.GMELFMBEPNK, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary4;
				temporary4 = RenderTexture.GetTemporary(width2, height2, 0, format);
				this.GMELFMBEPNK.SetVector("_Offsets", new Vector4(num3 / num * num2, 0f, 0f, 0f));
				Graphics.Blit(renderTexture, temporary4, this.GMELFMBEPNK, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary4;
				if (this.quality > Bloom.OFHOJEKJJDI.Cheap)
				{
					if (i == 0)
					{
						Graphics.SetRenderTarget(temporary);
						GL.Clear(false, true, Color.black);
						Graphics.Blit(renderTexture, temporary);
					}
					else
					{
						temporary.MarkRestoreExpected();
						Graphics.Blit(renderTexture, temporary, this.GILHCCIHPGN, 10);
					}
				}
			}
			if (this.quality > Bloom.OFHOJEKJJDI.Cheap)
			{
				Graphics.SetRenderTarget(renderTexture);
				GL.Clear(false, true, Color.black);
				Graphics.Blit(temporary, renderTexture, this.GILHCCIHPGN, 6);
			}
			if (this.lensflareIntensity > Mathf.Epsilon)
			{
				RenderTexture temporary5 = RenderTexture.GetTemporary(width2, height2, 0, format);
				if (this.lensflareMode == Bloom.OLJDJLIHCAA.Ghosting)
				{
					this.DNGLHLEGCOE(this.lensflareThreshold, renderTexture, temporary5);
					if (this.quality > Bloom.OFHOJEKJJDI.Cheap)
					{
						this.GMELFMBEPNK.SetVector("_Offsets", new Vector4(0f, 1.5f / (1f * (float)temporary.height), 0f, 0f));
						Graphics.SetRenderTarget(temporary);
						GL.Clear(false, true, Color.black);
						Graphics.Blit(temporary5, temporary, this.GMELFMBEPNK, 4);
						this.GMELFMBEPNK.SetVector("_Offsets", new Vector4(1.5f / (1f * (float)temporary.width), 0f, 0f, 0f));
						Graphics.SetRenderTarget(temporary5);
						GL.Clear(false, true, Color.black);
						Graphics.Blit(temporary, temporary5, this.GMELFMBEPNK, 4);
					}
					this.HJJDCCACFGK(0.975f, temporary5, temporary5);
					this.MDOECNMOPEL(temporary5, renderTexture);
				}
				else
				{
					float num4 = 1f * Mathf.Cos(this.flareRotation);
					float num5 = 1f * Mathf.Sin(this.flareRotation);
					float num6 = this.hollyStretchWidth * 1f / num * num2;
					this.GMELFMBEPNK.SetVector("_Offsets", new Vector4(num4, num5, 0f, 0f));
					this.GMELFMBEPNK.SetVector("_Threshhold", new Vector4(this.lensflareThreshold, 1f, 0f, 0f));
					this.GMELFMBEPNK.SetVector("_TintColor", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					this.GMELFMBEPNK.SetFloat("_Saturation", this.lensFlareSaturation);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, this.GMELFMBEPNK, 2);
					temporary5.DiscardContents();
					Graphics.Blit(temporary, temporary5, this.GMELFMBEPNK, 3);
					this.GMELFMBEPNK.SetVector("_Offsets", new Vector4(num4 * num6, num5 * num6, 0f, 0f));
					this.GMELFMBEPNK.SetFloat("_StretchWidth", this.hollyStretchWidth);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, this.GMELFMBEPNK, 1);
					this.GMELFMBEPNK.SetFloat("_StretchWidth", this.hollyStretchWidth * 2f);
					temporary5.DiscardContents();
					Graphics.Blit(temporary, temporary5, this.GMELFMBEPNK, 1);
					this.GMELFMBEPNK.SetFloat("_StretchWidth", this.hollyStretchWidth * 4f);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, this.GMELFMBEPNK, 1);
					for (int j = 0; j < this.hollywoodFlareBlurIterations; j++)
					{
						num6 = this.hollyStretchWidth * 2f / num * num2;
						this.GMELFMBEPNK.SetVector("_Offsets", new Vector4(num6 * num4, num6 * num5, 0f, 0f));
						temporary5.DiscardContents();
						Graphics.Blit(temporary, temporary5, this.GMELFMBEPNK, 4);
						this.GMELFMBEPNK.SetVector("_Offsets", new Vector4(num6 * num4, num6 * num5, 0f, 0f));
						temporary.DiscardContents();
						Graphics.Blit(temporary5, temporary, this.GMELFMBEPNK, 4);
					}
					if (this.lensflareMode == Bloom.OLJDJLIHCAA.Anamorphic)
					{
						this.NLDGLJFIIDH(1f, temporary, renderTexture);
					}
					else
					{
						this.HJJDCCACFGK(1f, temporary, temporary5);
						this.MDOECNMOPEL(temporary5, temporary);
						this.NLDGLJFIIDH(1f, temporary, renderTexture);
					}
				}
				RenderTexture.ReleaseTemporary(temporary5);
			}
			int pass = (int)igbeheclgjo;
			this.GILHCCIHPGN.SetFloat("_Intensity", this.bloomIntensity);
			this.GILHCCIHPGN.SetTexture("_ColorBuffer", JONJODLFAEN);
			if (this.quality > Bloom.OFHOJEKJJDI.Cheap)
			{
				RenderTexture temporary6 = RenderTexture.GetTemporary(width, height, 0, format);
				Graphics.Blit(renderTexture, temporary6);
				Graphics.Blit(temporary6, OKIIDHIJBEA, this.GILHCCIHPGN, pass);
				RenderTexture.ReleaseTemporary(temporary6);
			}
			else
			{
				Graphics.Blit(renderTexture, OKIIDHIJBEA, this.GILHCCIHPGN, pass);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B2FD RID: 45821 RVA: 0x004E3A66 File Offset: 0x004E1C66
		private void CAONJCLHLDK(float JLEHAHJEIAC, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.PJECOFONCFN.SetVector(" \n", new Vector4(JLEHAHJEIAC, JLEHAHJEIAC, JLEHAHJEIAC, JLEHAHJEIAC));
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.PJECOFONCFN, 1);
		}

		// Token: 0x0600B2FE RID: 45822 RVA: 0x004E3A8F File Offset: 0x004E1C8F
		private void OAIKPOFFLKA(float JLEHAHJEIAC, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.PJECOFONCFN.SetVector("inv_rl", new Vector4(JLEHAHJEIAC, JLEHAHJEIAC, JLEHAHJEIAC, JLEHAHJEIAC));
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.PJECOFONCFN, 0);
		}

		// Token: 0x0600B2FF RID: 45823 RVA: 0x004E3AB8 File Offset: 0x004E1CB8
		private void DMKKIEPEGEH(float JLEHAHJEIAC, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.PJECOFONCFN.SetVector("Hand", new Vector4(JLEHAHJEIAC, JLEHAHJEIAC, JLEHAHJEIAC, JLEHAHJEIAC));
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.PJECOFONCFN, 0);
		}

		// Token: 0x0600B300 RID: 45824 RVA: 0x004E3AE4 File Offset: 0x004E1CE4
		public virtual bool CHJBCBDIBJJ()
		{
			base.CBJDCDELBJN(true);
			this.GILHCCIHPGN = base.JBHLGBPJFEL(this.screenBlendShader, this.GILHCCIHPGN);
			this.FGKGIFAKMKL = base.ALJPMGLOIEG(this.lensFlareShader, this.FGKGIFAKMKL);
			this.GMELFMBEPNK = base.ALJPMGLOIEG(this.blurAndFlaresShader, this.GMELFMBEPNK);
			this.PJECOFONCFN = base.JBHLGBPJFEL(this.brightPassFilterShader, this.PJECOFONCFN);
			if (!this.PPGOAMIHMBG)
			{
				base.LNEHBOJIBAI();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B301 RID: 45825 RVA: 0x004E3B70 File Offset: 0x004E1D70
		private void JONCIKNNFNG(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.FGKGIFAKMKL.SetVector("crft_from", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("sadokfull2", new Vector4(this.flareColorB.r, this.flareColorB.g, this.flareColorB.b, this.flareColorB.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("IdleStrafeLeft", new Vector4(this.flareColorC.r, this.flareColorC.g, this.flareColorC.b, this.flareColorC.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("rbon", new Vector4(this.flareColorD.r, this.flareColorD.g, this.flareColorD.b, this.flareColorD.a) * this.lensflareIntensity);
			LJGGOANMJAJ.MarkRestoreExpected();
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.FGKGIFAKMKL);
		}

		// Token: 0x0600B302 RID: 45826 RVA: 0x004E3CC0 File Offset: 0x004E1EC0
		public virtual bool FCIOAHEKFIG()
		{
			base.OFKOBOMCECF(false);
			this.GILHCCIHPGN = base.DJFOEIJIMJB(this.screenBlendShader, this.GILHCCIHPGN);
			this.FGKGIFAKMKL = base.IIIIADNBONI(this.lensFlareShader, this.FGKGIFAKMKL);
			this.GMELFMBEPNK = base.DJFOEIJIMJB(this.blurAndFlaresShader, this.GMELFMBEPNK);
			this.PJECOFONCFN = base.OOAOHFFDMJP(this.brightPassFilterShader, this.PJECOFONCFN);
			if (!this.PPGOAMIHMBG)
			{
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B303 RID: 45827 RVA: 0x004E3D4C File Offset: 0x004E1F4C
		public override bool CheckResources()
		{
			base.DAOKCAOFIGE(false);
			this.GILHCCIHPGN = base.DJFOEIJIMJB(this.screenBlendShader, this.GILHCCIHPGN);
			this.FGKGIFAKMKL = base.DJFOEIJIMJB(this.lensFlareShader, this.FGKGIFAKMKL);
			this.GMELFMBEPNK = base.DJFOEIJIMJB(this.blurAndFlaresShader, this.GMELFMBEPNK);
			this.PJECOFONCFN = base.DJFOEIJIMJB(this.brightPassFilterShader, this.PJECOFONCFN);
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B304 RID: 45828 RVA: 0x004E3DD8 File Offset: 0x004E1FD8
		private void FEALEECNPCB(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.FGKGIFAKMKL.SetVector("_TintColor", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("_BgColor", new Vector4(this.flareColorB.r, this.flareColorB.g, this.flareColorB.b, this.flareColorB.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("a", new Vector4(this.flareColorC.r, this.flareColorC.g, this.flareColorC.b, this.flareColorC.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("http://af-2.ru/?q=store", new Vector4(this.flareColorD.r, this.flareColorD.g, this.flareColorD.b, this.flareColorD.a) * this.lensflareIntensity);
			LJGGOANMJAJ.MarkRestoreExpected();
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.FGKGIFAKMKL);
		}

		// Token: 0x0600B305 RID: 45829 RVA: 0x004E3F28 File Offset: 0x004E2128
		private void FELGDCDJCDO(float MHIPLHJKKIF, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			if (this.lensFlareVignetteMask)
			{
				this.GILHCCIHPGN.SetTexture("Loser", this.lensFlareVignetteMask);
				LJGGOANMJAJ.MarkRestoreExpected();
				Graphics.Blit((GMNLJGNOKPD == LJGGOANMJAJ) ? null : GMNLJGNOKPD, LJGGOANMJAJ, this.GILHCCIHPGN, (GMNLJGNOKPD == LJGGOANMJAJ) ? 2 : 0);
				return;
			}
			if (GMNLJGNOKPD != LJGGOANMJAJ)
			{
				Graphics.SetRenderTarget(LJGGOANMJAJ);
				GL.Clear(false, false, Color.black);
				Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ);
			}
		}

		// Token: 0x0600B306 RID: 45830 RVA: 0x004E3FA7 File Offset: 0x004E21A7
		private void LHNNNNEONBM(Color ENBEFAKEBDG, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.PJECOFONCFN.SetVector("RunBackRight", ENBEFAKEBDG);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.PJECOFONCFN, 0);
		}

		// Token: 0x0600B307 RID: 45831 RVA: 0x004E3FD0 File Offset: 0x004E21D0
		private void ENJEJGGOOCC(float MHIPLHJKKIF, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			if (this.lensFlareVignetteMask)
			{
				this.GILHCCIHPGN.SetTexture("_Offsets", this.lensFlareVignetteMask);
				LJGGOANMJAJ.MarkRestoreExpected();
				Graphics.Blit((GMNLJGNOKPD == LJGGOANMJAJ) ? null : GMNLJGNOKPD, LJGGOANMJAJ, this.GILHCCIHPGN, (GMNLJGNOKPD == LJGGOANMJAJ) ? 8 : 0);
				return;
			}
			if (GMNLJGNOKPD != LJGGOANMJAJ)
			{
				Graphics.SetRenderTarget(LJGGOANMJAJ);
				GL.Clear(false, true, Color.black);
				Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ);
			}
		}

		// Token: 0x0600B308 RID: 45832 RVA: 0x004E404F File Offset: 0x004E224F
		private void PMOMFKOBBKI(float EJBGLCNDHMK, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.GILHCCIHPGN.SetFloat("", EJBGLCNDHMK);
			LJGGOANMJAJ.MarkRestoreExpected();
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.GILHCCIHPGN, -72);
		}

		// Token: 0x0600B309 RID: 45833 RVA: 0x004E4077 File Offset: 0x004E2277
		private void MLDCHKJCPJH(Color ENBEFAKEBDG, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.PJECOFONCFN.SetVector("null", ENBEFAKEBDG);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.PJECOFONCFN, 1);
		}

		// Token: 0x0600B30A RID: 45834 RVA: 0x004E40A0 File Offset: 0x004E22A0
		private void MDOECNMOPEL(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.FGKGIFAKMKL.SetVector("colorA", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("colorB", new Vector4(this.flareColorB.r, this.flareColorB.g, this.flareColorB.b, this.flareColorB.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("colorC", new Vector4(this.flareColorC.r, this.flareColorC.g, this.flareColorC.b, this.flareColorC.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("colorD", new Vector4(this.flareColorD.r, this.flareColorD.g, this.flareColorD.b, this.flareColorD.a) * this.lensflareIntensity);
			LJGGOANMJAJ.MarkRestoreExpected();
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.FGKGIFAKMKL);
		}

		// Token: 0x0600B30B RID: 45835 RVA: 0x004E41F0 File Offset: 0x004E23F0
		private void NLDGLJFIIDH(float EJBGLCNDHMK, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.GILHCCIHPGN.SetFloat("_Intensity", EJBGLCNDHMK);
			LJGGOANMJAJ.MarkRestoreExpected();
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.GILHCCIHPGN, 9);
		}

		// Token: 0x0600B30C RID: 45836 RVA: 0x004E4218 File Offset: 0x004E2418
		private void DFLLJDJBLLC(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.FGKGIFAKMKL.SetVector("PaperTurn.wav", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("WallSit", new Vector4(this.flareColorB.r, this.flareColorB.g, this.flareColorB.b, this.flareColorB.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("_RotationMatrix", new Vector4(this.flareColorC.r, this.flareColorC.g, this.flareColorC.b, this.flareColorC.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("isRodInWater", new Vector4(this.flareColorD.r, this.flareColorD.g, this.flareColorD.b, this.flareColorD.a) * this.lensflareIntensity);
			LJGGOANMJAJ.MarkRestoreExpected();
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.FGKGIFAKMKL);
		}

		// Token: 0x0600B30D RID: 45837 RVA: 0x004E4368 File Offset: 0x004E2568
		private void FMBCLKCEKOD(Color ENBEFAKEBDG, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.PJECOFONCFN.SetVector("NadeThrow", ENBEFAKEBDG);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.PJECOFONCFN, 1);
		}

		// Token: 0x0600B30E RID: 45838 RVA: 0x004E438E File Offset: 0x004E258E
		private void INIJECFAOGB(float JLEHAHJEIAC, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.PJECOFONCFN.SetVector("SoccerKeeperJump", new Vector4(JLEHAHJEIAC, JLEHAHJEIAC, JLEHAHJEIAC, JLEHAHJEIAC));
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.PJECOFONCFN, 1);
		}

		// Token: 0x0600B30F RID: 45839 RVA: 0x004E43B7 File Offset: 0x004E25B7
		private void CODMHGEFKPH(Color ENBEFAKEBDG, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.PJECOFONCFN.SetVector("qd_refresh", ENBEFAKEBDG);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.PJECOFONCFN, 1);
		}

		// Token: 0x0600B310 RID: 45840 RVA: 0x004E43E0 File Offset: 0x004E25E0
		private void FEEDIDJPPDC(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.FGKGIFAKMKL.SetVector("crft_from", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("--", new Vector4(this.flareColorB.r, this.flareColorB.g, this.flareColorB.b, this.flareColorB.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("The root node, the left upper arm and the right upper arm bones should ideally form a triangle that is as close to equilateral as possible. Currently the root node bone seems to be very close to the line between the left upper arm and the right upper arm bones. This might cause unwanted behaviour like the spine turning upside down when pulled by a hand effector.Please set the root node bone to be one of the lower bones in the spine.", new Vector4(this.flareColorC.r, this.flareColorC.g, this.flareColorC.b, this.flareColorC.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("", new Vector4(this.flareColorD.r, this.flareColorD.g, this.flareColorD.b, this.flareColorD.a) * this.lensflareIntensity);
			LJGGOANMJAJ.MarkRestoreExpected();
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.FGKGIFAKMKL);
		}

		// Token: 0x0600B311 RID: 45841 RVA: 0x004E4530 File Offset: 0x004E2730
		private void OGOBCJJNICK(float JLEHAHJEIAC, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.PJECOFONCFN.SetVector("\n", new Vector4(JLEHAHJEIAC, JLEHAHJEIAC, JLEHAHJEIAC, JLEHAHJEIAC));
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.PJECOFONCFN, 0);
		}

		// Token: 0x0600B312 RID: 45842 RVA: 0x004E4559 File Offset: 0x004E2759
		private void DNGLHLEGCOE(float JLEHAHJEIAC, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.PJECOFONCFN.SetVector("_Threshhold", new Vector4(JLEHAHJEIAC, JLEHAHJEIAC, JLEHAHJEIAC, JLEHAHJEIAC));
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.PJECOFONCFN, 0);
		}

		// Token: 0x0600B313 RID: 45843 RVA: 0x004E4582 File Offset: 0x004E2782
		private void PODCJEEAMLK(float JLEHAHJEIAC, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.PJECOFONCFN.SetVector("bool:", new Vector4(JLEHAHJEIAC, JLEHAHJEIAC, JLEHAHJEIAC, JLEHAHJEIAC));
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.PJECOFONCFN, 1);
		}

		// Token: 0x0600B314 RID: 45844 RVA: 0x004E45AC File Offset: 0x004E27AC
		private void LPMPAMMHAHN(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.FGKGIFAKMKL.SetVector("exitmsg_2", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector(" ", new Vector4(this.flareColorB.r, this.flareColorB.g, this.flareColorB.b, this.flareColorB.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector(" ", new Vector4(this.flareColorC.r, this.flareColorC.g, this.flareColorC.b, this.flareColorC.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("ShotgunReloadMagazine", new Vector4(this.flareColorD.r, this.flareColorD.g, this.flareColorD.b, this.flareColorD.a) * this.lensflareIntensity);
			LJGGOANMJAJ.MarkRestoreExpected();
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.FGKGIFAKMKL);
		}

		// Token: 0x0600B315 RID: 45845 RVA: 0x004E46FC File Offset: 0x004E28FC
		private void DGOEGEKEDNJ(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.FGKGIFAKMKL.SetVector("PistolFire", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector(" ", new Vector4(this.flareColorB.r, this.flareColorB.g, this.flareColorB.b, this.flareColorB.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("*************157 baseid=", new Vector4(this.flareColorC.r, this.flareColorC.g, this.flareColorC.b, this.flareColorC.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("SUNSHINE_FILTER_PCF_3x3", new Vector4(this.flareColorD.r, this.flareColorD.g, this.flareColorD.b, this.flareColorD.a) * this.lensflareIntensity);
			LJGGOANMJAJ.MarkRestoreExpected();
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.FGKGIFAKMKL);
		}

		// Token: 0x0600B316 RID: 45846 RVA: 0x004E484C File Offset: 0x004E2A4C
		private void IJNNEGKGIGJ(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.FGKGIFAKMKL.SetVector("_ZWrite", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("_HeightParams", new Vector4(this.flareColorB.r, this.flareColorB.g, this.flareColorB.b, this.flareColorB.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("Delete", new Vector4(this.flareColorC.r, this.flareColorC.g, this.flareColorC.b, this.flareColorC.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("craft_time", new Vector4(this.flareColorD.r, this.flareColorD.g, this.flareColorD.b, this.flareColorD.a) * this.lensflareIntensity);
			LJGGOANMJAJ.MarkRestoreExpected();
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.FGKGIFAKMKL);
		}

		// Token: 0x0600B317 RID: 45847 RVA: 0x004E499C File Offset: 0x004E2B9C
		private void DNGLHLEGCOE(Color ENBEFAKEBDG, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.PJECOFONCFN.SetVector("_Threshhold", ENBEFAKEBDG);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.PJECOFONCFN, 1);
		}

		// Token: 0x0600B318 RID: 45848 RVA: 0x004E49C4 File Offset: 0x004E2BC4
		private void BMGBHABGPHE(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.FGKGIFAKMKL.SetVector("WorkerHammer2", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("#000000", new Vector4(this.flareColorB.r, this.flareColorB.g, this.flareColorB.b, this.flareColorB.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("IdleStun", new Vector4(this.flareColorC.r, this.flareColorC.g, this.flareColorC.b, this.flareColorC.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("Cloth_05_00.wav", new Vector4(this.flareColorD.r, this.flareColorD.g, this.flareColorD.b, this.flareColorD.a) * this.lensflareIntensity);
			LJGGOANMJAJ.MarkRestoreExpected();
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.FGKGIFAKMKL);
		}

		// Token: 0x0600B319 RID: 45849 RVA: 0x004E4B14 File Offset: 0x004E2D14
		private void HJJDCCACFGK(float MHIPLHJKKIF, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			if (this.lensFlareVignetteMask)
			{
				this.GILHCCIHPGN.SetTexture("_ColorBuffer", this.lensFlareVignetteMask);
				LJGGOANMJAJ.MarkRestoreExpected();
				Graphics.Blit((GMNLJGNOKPD == LJGGOANMJAJ) ? null : GMNLJGNOKPD, LJGGOANMJAJ, this.GILHCCIHPGN, (GMNLJGNOKPD == LJGGOANMJAJ) ? 7 : 3);
				return;
			}
			if (GMNLJGNOKPD != LJGGOANMJAJ)
			{
				Graphics.SetRenderTarget(LJGGOANMJAJ);
				GL.Clear(false, true, Color.black);
				Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ);
			}
		}

		// Token: 0x0600B31A RID: 45850 RVA: 0x004E4B93 File Offset: 0x004E2D93
		private void PELAHPLLABH(Color ENBEFAKEBDG, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.PJECOFONCFN.SetVector("Fly Down", ENBEFAKEBDG);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.PJECOFONCFN, 0);
		}

		// Token: 0x0600B31B RID: 45851 RVA: 0x004E4BB9 File Offset: 0x004E2DB9
		private void JHPHNCKIPPI(Color ENBEFAKEBDG, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.PJECOFONCFN.SetVector(" ", ENBEFAKEBDG);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.PJECOFONCFN, 0);
		}

		// Token: 0x0600B31C RID: 45852 RVA: 0x004E4BE0 File Offset: 0x004E2DE0
		private void FDKBDMJMIPB(float MHIPLHJKKIF, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			if (this.lensFlareVignetteMask)
			{
				this.GILHCCIHPGN.SetTexture("OfficeSittingReadingCoffeeSip", this.lensFlareVignetteMask);
				LJGGOANMJAJ.MarkRestoreExpected();
				Graphics.Blit((GMNLJGNOKPD == LJGGOANMJAJ) ? null : GMNLJGNOKPD, LJGGOANMJAJ, this.GILHCCIHPGN, (GMNLJGNOKPD == LJGGOANMJAJ) ? 0 : 3);
				return;
			}
			if (GMNLJGNOKPD != LJGGOANMJAJ)
			{
				Graphics.SetRenderTarget(LJGGOANMJAJ);
				GL.Clear(false, true, Color.black);
				Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ);
			}
		}

		// Token: 0x040016B0 RID: 5808
		public Bloom.GFOPOHDIEJN tweakMode;

		// Token: 0x040016B1 RID: 5809
		public Bloom.IGBEHECLGJO screenBlendMode = Bloom.IGBEHECLGJO.Add;

		// Token: 0x040016B2 RID: 5810
		public Bloom.MJILBJJNNHP hdr;

		// Token: 0x040016B3 RID: 5811
		private bool GEBCPMDEOEA;

		// Token: 0x040016B4 RID: 5812
		public float sepBlurSpread = 2.5f;

		// Token: 0x040016B5 RID: 5813
		public Bloom.OFHOJEKJJDI quality = Bloom.OFHOJEKJJDI.High;

		// Token: 0x040016B6 RID: 5814
		public float bloomIntensity = 0.5f;

		// Token: 0x040016B7 RID: 5815
		public float bloomThreshold = 0.5f;

		// Token: 0x040016B8 RID: 5816
		public Color bloomThresholdColor = Color.white;

		// Token: 0x040016B9 RID: 5817
		public int bloomBlurIterations = 2;

		// Token: 0x040016BA RID: 5818
		public int hollywoodFlareBlurIterations = 2;

		// Token: 0x040016BB RID: 5819
		public float flareRotation;

		// Token: 0x040016BC RID: 5820
		public Bloom.OLJDJLIHCAA lensflareMode = Bloom.OLJDJLIHCAA.Anamorphic;

		// Token: 0x040016BD RID: 5821
		public float hollyStretchWidth = 2.5f;

		// Token: 0x040016BE RID: 5822
		public float lensflareIntensity;

		// Token: 0x040016BF RID: 5823
		public float lensflareThreshold = 0.3f;

		// Token: 0x040016C0 RID: 5824
		public float lensFlareSaturation = 0.75f;

		// Token: 0x040016C1 RID: 5825
		public Color flareColorA = new Color(0.4f, 0.4f, 0.8f, 0.75f);

		// Token: 0x040016C2 RID: 5826
		public Color flareColorB = new Color(0.4f, 0.8f, 0.8f, 0.75f);

		// Token: 0x040016C3 RID: 5827
		public Color flareColorC = new Color(0.8f, 0.4f, 0.8f, 0.75f);

		// Token: 0x040016C4 RID: 5828
		public Color flareColorD = new Color(0.8f, 0.4f, 0f, 0.75f);

		// Token: 0x040016C5 RID: 5829
		public Texture2D lensFlareVignetteMask;

		// Token: 0x040016C6 RID: 5830
		public Shader lensFlareShader;

		// Token: 0x040016C7 RID: 5831
		private Material FGKGIFAKMKL;

		// Token: 0x040016C8 RID: 5832
		public Shader screenBlendShader;

		// Token: 0x040016C9 RID: 5833
		private Material GILHCCIHPGN;

		// Token: 0x040016CA RID: 5834
		public Shader blurAndFlaresShader;

		// Token: 0x040016CB RID: 5835
		private Material GMELFMBEPNK;

		// Token: 0x040016CC RID: 5836
		public Shader brightPassFilterShader;

		// Token: 0x040016CD RID: 5837
		private Material PJECOFONCFN;

		// Token: 0x020002FE RID: 766
		public enum OLJDJLIHCAA
		{
			// Token: 0x040016CF RID: 5839
			Ghosting,
			// Token: 0x040016D0 RID: 5840
			Anamorphic,
			// Token: 0x040016D1 RID: 5841
			Combined
		}

		// Token: 0x020002FF RID: 767
		public enum GFOPOHDIEJN
		{
			// Token: 0x040016D3 RID: 5843
			Basic,
			// Token: 0x040016D4 RID: 5844
			Complex
		}

		// Token: 0x02000300 RID: 768
		public enum MJILBJJNNHP
		{
			// Token: 0x040016D6 RID: 5846
			Auto,
			// Token: 0x040016D7 RID: 5847
			On,
			// Token: 0x040016D8 RID: 5848
			Off
		}

		// Token: 0x02000301 RID: 769
		public enum IGBEHECLGJO
		{
			// Token: 0x040016DA RID: 5850
			Screen,
			// Token: 0x040016DB RID: 5851
			Add
		}

		// Token: 0x02000302 RID: 770
		public enum OFHOJEKJJDI
		{
			// Token: 0x040016DD RID: 5853
			Cheap,
			// Token: 0x040016DE RID: 5854
			High
		}
	}
}
