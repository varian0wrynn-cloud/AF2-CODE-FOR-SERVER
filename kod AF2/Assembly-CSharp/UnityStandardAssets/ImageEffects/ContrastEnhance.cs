using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000314 RID: 788
	[AddComponentMenu("Image Effects/Color Adjustments/Contrast Enhance (Unsharp Mask)")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class ContrastEnhance : PostEffectsBase
	{
		// Token: 0x0600B5FE RID: 46590 RVA: 0x00509F54 File Offset: 0x00508154
		private void PKNBABMJLPB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NHEEDPALBFN())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 1, height / 2, 0);
			Graphics.Blit(JONJODLFAEN, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 0, height / 1, 1);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.AEODOBMBCHF.SetVector("- none -", new Vector4(1148f, this.blurSpread * 209f / (float)temporary2.height, 1606f, 1967f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 2, height / 2, 1);
			Graphics.Blit(temporary2, temporary3, this.AEODOBMBCHF);
			RenderTexture.ReleaseTemporary(temporary2);
			this.AEODOBMBCHF.SetVector("StrafeRunRight", new Vector4(this.blurSpread * 681f / (float)temporary2.width, 172f, 712f, 542f));
			temporary2 = RenderTexture.GetTemporary(width / 2, height / 4, 1);
			Graphics.Blit(temporary3, temporary2, this.AEODOBMBCHF);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HOEGCEJPHLO.SetTexture("I'm obscured string", temporary2);
			this.HOEGCEJPHLO.SetFloat("IdleRun", this.intensity);
			this.HOEGCEJPHLO.SetFloat("IdleDrink", this.threshold);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HOEGCEJPHLO);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x0600B5FF RID: 46591 RVA: 0x0050A0AC File Offset: 0x005082AC
		public virtual bool FGENCAKNJAI()
		{
			base.CDBNBLBOLCL(false);
			this.HOEGCEJPHLO = base.OOAOHFFDMJP(this.contrastCompositeShader, this.HOEGCEJPHLO);
			this.AEODOBMBCHF = base.OOAOHFFDMJP(this.separableBlurShader, this.AEODOBMBCHF);
			if (!this.PPGOAMIHMBG)
			{
				base.OAEAMDHOKKM();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B600 RID: 46592 RVA: 0x0050A108 File Offset: 0x00508308
		private void JOFOEKABLBF(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 7, height / 0, 0);
			Graphics.Blit(JONJODLFAEN, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 8, height / 8, 1);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.AEODOBMBCHF.SetVector("#606000", new Vector4(188f, this.blurSpread * 806f / (float)temporary2.height, 1976f, 1542f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 7, height / 3, 1);
			Graphics.Blit(temporary2, temporary3, this.AEODOBMBCHF);
			RenderTexture.ReleaseTemporary(temporary2);
			this.AEODOBMBCHF.SetVector(":", new Vector4(this.blurSpread * 1527f / (float)temporary2.width, 1725f, 167f, 1837f));
			temporary2 = RenderTexture.GetTemporary(width / 5, height / 6, 1);
			Graphics.Blit(temporary3, temporary2, this.AEODOBMBCHF);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HOEGCEJPHLO.SetTexture("batechange.ogg", temporary2);
			this.HOEGCEJPHLO.SetFloat("1 Hand Sword Strafe Left", this.intensity);
			this.HOEGCEJPHLO.SetFloat("newHour", this.threshold);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HOEGCEJPHLO);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x0600B601 RID: 46593 RVA: 0x0050A260 File Offset: 0x00508460
		public virtual bool DGACHJFDAMI()
		{
			base.POJDHPJDFEM(false);
			this.HOEGCEJPHLO = base.ALJPMGLOIEG(this.contrastCompositeShader, this.HOEGCEJPHLO);
			this.AEODOBMBCHF = base.IIIIADNBONI(this.separableBlurShader, this.AEODOBMBCHF);
			if (!this.PPGOAMIHMBG)
			{
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B602 RID: 46594 RVA: 0x0050A2BC File Offset: 0x005084BC
		private void ICIEPDMDONC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 7, height / 0, 1);
			Graphics.Blit(JONJODLFAEN, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 1, height / 8, 1);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.AEODOBMBCHF.SetVector("Отпущено {0} рыб, общим весом \n<color='#a000ff'>{1}</color>\nПолучено {2} опыта", new Vector4(626f, this.blurSpread * 1629f / (float)temporary2.height, 934f, 1401f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 4, height / 3, 1);
			Graphics.Blit(temporary2, temporary3, this.AEODOBMBCHF);
			RenderTexture.ReleaseTemporary(temporary2);
			this.AEODOBMBCHF.SetVector("https://groups.google.com/forum/#!forum/final-ik", new Vector4(this.blurSpread * 176f / (float)temporary2.width, 1062f, 1008f, 1192f));
			temporary2 = RenderTexture.GetTemporary(width / 4, height / 3, 1);
			Graphics.Blit(temporary3, temporary2, this.AEODOBMBCHF);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HOEGCEJPHLO.SetTexture("SwimFreestyle", temporary2);
			this.HOEGCEJPHLO.SetFloat("Crouch Walk Backward", this.intensity);
			this.HOEGCEJPHLO.SetFloat("BlendCacheMaterial", this.threshold);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HOEGCEJPHLO);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x0600B603 RID: 46595 RVA: 0x0050A414 File Offset: 0x00508614
		private void JHHHJFOOFII(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 8, height / 1, 0);
			Graphics.Blit(JONJODLFAEN, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 4, height / 1, 1);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.AEODOBMBCHF.SetVector("_SecondTex", new Vector4(1172f, this.blurSpread * 1298f / (float)temporary2.height, 1734f, 686f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 2, height / 4, 0);
			Graphics.Blit(temporary2, temporary3, this.AEODOBMBCHF);
			RenderTexture.ReleaseTemporary(temporary2);
			this.AEODOBMBCHF.SetVector("wpn_wgt", new Vector4(this.blurSpread * 1786f / (float)temporary2.width, 1591f, 329f, 239f));
			temporary2 = RenderTexture.GetTemporary(width / 7, height / 4, 1);
			Graphics.Blit(temporary3, temporary2, this.AEODOBMBCHF);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HOEGCEJPHLO.SetTexture("Flashlight", temporary2);
			this.HOEGCEJPHLO.SetFloat("Bone", this.intensity);
			this.HOEGCEJPHLO.SetFloat("Smoking 1", this.threshold);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HOEGCEJPHLO);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x0600B604 RID: 46596 RVA: 0x0050A56C File Offset: 0x0050876C
		public override bool CheckResources()
		{
			base.DAOKCAOFIGE(false);
			this.HOEGCEJPHLO = base.DJFOEIJIMJB(this.contrastCompositeShader, this.HOEGCEJPHLO);
			this.AEODOBMBCHF = base.DJFOEIJIMJB(this.separableBlurShader, this.AEODOBMBCHF);
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B605 RID: 46597 RVA: 0x0050A5C8 File Offset: 0x005087C8
		public virtual bool CPIFBHFDEFO()
		{
			base.DAOKCAOFIGE(false);
			this.HOEGCEJPHLO = base.BAPJBHPEDIF(this.contrastCompositeShader, this.HOEGCEJPHLO);
			this.AEODOBMBCHF = base.JBHLGBPJFEL(this.separableBlurShader, this.AEODOBMBCHF);
			if (!this.PPGOAMIHMBG)
			{
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B606 RID: 46598 RVA: 0x0050A624 File Offset: 0x00508824
		private void MGOBAHLJJNL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 7, height / 6, 1);
			Graphics.Blit(JONJODLFAEN, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 6, height / 3, 0);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.AEODOBMBCHF.SetVector(")", new Vector4(1534f, this.blurSpread * 25f / (float)temporary2.height, 1069f, 825f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 6, height / 2, 1);
			Graphics.Blit(temporary2, temporary3, this.AEODOBMBCHF);
			RenderTexture.ReleaseTemporary(temporary2);
			this.AEODOBMBCHF.SetVector("default", new Vector4(this.blurSpread * 1240f / (float)temporary2.width, 296f, 579f, 1414f));
			temporary2 = RenderTexture.GetTemporary(width / 7, height / 3, 0);
			Graphics.Blit(temporary3, temporary2, this.AEODOBMBCHF);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HOEGCEJPHLO.SetTexture("Worker Hammer 2", temporary2);
			this.HOEGCEJPHLO.SetFloat("exitmsg_2", this.intensity);
			this.HOEGCEJPHLO.SetFloat("</color>", this.threshold);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HOEGCEJPHLO);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x0600B607 RID: 46599 RVA: 0x0050A77C File Offset: 0x0050897C
		public virtual bool BGNOLJBJGEL()
		{
			base.BGIALJEIEFO(false);
			this.HOEGCEJPHLO = base.BOOFEOGDMBI(this.contrastCompositeShader, this.HOEGCEJPHLO);
			this.AEODOBMBCHF = base.JBHLGBPJFEL(this.separableBlurShader, this.AEODOBMBCHF);
			if (!this.PPGOAMIHMBG)
			{
				base.NAIBIABADFB();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B608 RID: 46600 RVA: 0x0050A7D8 File Offset: 0x005089D8
		private void IBIBOJIPANH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 1, height / 8, 1);
			Graphics.Blit(JONJODLFAEN, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 8, height / 8, 0);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.AEODOBMBCHF.SetVector("maxspd", new Vector4(1819f, this.blurSpread * 1669f / (float)temporary2.height, 1631f, 1428f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 5, height / 8, 0);
			Graphics.Blit(temporary2, temporary3, this.AEODOBMBCHF);
			RenderTexture.ReleaseTemporary(temporary2);
			this.AEODOBMBCHF.SetVector("crft_selwpn", new Vector4(this.blurSpread * 777f / (float)temporary2.width, 579f, 1168f, 1848f));
			temporary2 = RenderTexture.GetTemporary(width / 7, height / 1, 1);
			Graphics.Blit(temporary3, temporary2, this.AEODOBMBCHF);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HOEGCEJPHLO.SetTexture("******** nextMusicCrt End of music path=", temporary2);
			this.HOEGCEJPHLO.SetFloat("pf3m", this.intensity);
			this.HOEGCEJPHLO.SetFloat("connect already used", this.threshold);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HOEGCEJPHLO);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x0600B609 RID: 46601 RVA: 0x0050A930 File Offset: 0x00508B30
		private void JPCPEPMDLAN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.MNDOFMMGLMO())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 8, height / 4, 0);
			Graphics.Blit(JONJODLFAEN, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 5, height / 2, 0);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.AEODOBMBCHF.SetVector("</color>", new Vector4(448f, this.blurSpread * 1420f / (float)temporary2.height, 1381f, 1911f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 0, height / 7, 1);
			Graphics.Blit(temporary2, temporary3, this.AEODOBMBCHF);
			RenderTexture.ReleaseTemporary(temporary2);
			this.AEODOBMBCHF.SetVector("Identity LUT", new Vector4(this.blurSpread * 779f / (float)temporary2.width, 1924f, 732f, 1252f));
			temporary2 = RenderTexture.GetTemporary(width / 4, height / 3, 0);
			Graphics.Blit(temporary3, temporary2, this.AEODOBMBCHF);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HOEGCEJPHLO.SetTexture("</color>", temporary2);
			this.HOEGCEJPHLO.SetFloat("SoccerTackle", this.intensity);
			this.HOEGCEJPHLO.SetFloat("IdleFight", this.threshold);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HOEGCEJPHLO);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x0600B60A RID: 46602 RVA: 0x0050AA88 File Offset: 0x00508C88
		public virtual bool ENMKIJNFBFF()
		{
			base.BGIALJEIEFO(false);
			this.HOEGCEJPHLO = base.ALJPMGLOIEG(this.contrastCompositeShader, this.HOEGCEJPHLO);
			this.AEODOBMBCHF = base.ALJPMGLOIEG(this.separableBlurShader, this.AEODOBMBCHF);
			if (!this.PPGOAMIHMBG)
			{
				base.INOGPLDHPGC();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B60B RID: 46603 RVA: 0x0050AAE4 File Offset: 0x00508CE4
		public virtual bool KKLBJANNNOH()
		{
			base.EBEBJHLBBBI(false);
			this.HOEGCEJPHLO = base.BAPJBHPEDIF(this.contrastCompositeShader, this.HOEGCEJPHLO);
			this.AEODOBMBCHF = base.BAPJBHPEDIF(this.separableBlurShader, this.AEODOBMBCHF);
			if (!this.PPGOAMIHMBG)
			{
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B60C RID: 46604 RVA: 0x0050AB40 File Offset: 0x00508D40
		public virtual bool AHMAHFLOJBM()
		{
			base.PKDIKFGAJKM(false);
			this.HOEGCEJPHLO = base.DJFOEIJIMJB(this.contrastCompositeShader, this.HOEGCEJPHLO);
			this.AEODOBMBCHF = base.OOAOHFFDMJP(this.separableBlurShader, this.AEODOBMBCHF);
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B60D RID: 46605 RVA: 0x0050AB9C File Offset: 0x00508D9C
		private void GAJNNKIFMOG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NHEEDPALBFN())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 2, height / 4, 1);
			Graphics.Blit(JONJODLFAEN, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 3, height / 6, 1);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.AEODOBMBCHF.SetVector("", new Vector4(1205f, this.blurSpread * 615f / (float)temporary2.height, 1873f, 826f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 5, height / 8, 1);
			Graphics.Blit(temporary2, temporary3, this.AEODOBMBCHF);
			RenderTexture.ReleaseTemporary(temporary2);
			this.AEODOBMBCHF.SetVector("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_grounder_biped_i_k.html", new Vector4(this.blurSpread * 1537f / (float)temporary2.width, 1144f, 1412f, 980f));
			temporary2 = RenderTexture.GetTemporary(width / 2, height / 3, 1);
			Graphics.Blit(temporary3, temporary2, this.AEODOBMBCHF);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HOEGCEJPHLO.SetTexture("Apply 10", temporary2);
			this.HOEGCEJPHLO.SetFloat("calcSonar", this.intensity);
			this.HOEGCEJPHLO.SetFloat("Grounded Strafe", this.threshold);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HOEGCEJPHLO);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x0600B60E RID: 46606 RVA: 0x0050ACF4 File Offset: 0x00508EF4
		public virtual bool JPEBNJPIFAF()
		{
			base.MGHNCKDCFGL(false);
			this.HOEGCEJPHLO = base.OOAOHFFDMJP(this.contrastCompositeShader, this.HOEGCEJPHLO);
			this.AEODOBMBCHF = base.ALJPMGLOIEG(this.separableBlurShader, this.AEODOBMBCHF);
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B60F RID: 46607 RVA: 0x0050AD50 File Offset: 0x00508F50
		public virtual bool NGKAKAAKDJH()
		{
			base.IDFIHFBEIKD(false);
			this.HOEGCEJPHLO = base.JBHLGBPJFEL(this.contrastCompositeShader, this.HOEGCEJPHLO);
			this.AEODOBMBCHF = base.JBHLGBPJFEL(this.separableBlurShader, this.AEODOBMBCHF);
			if (!this.PPGOAMIHMBG)
			{
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B610 RID: 46608 RVA: 0x0050ADAC File Offset: 0x00508FAC
		private void PJOKECOHKGN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 2, height / 0, 1);
			Graphics.Blit(JONJODLFAEN, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 5, height / 0, 1);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.AEODOBMBCHF.SetVector("closePodsak", new Vector4(1706f, this.blurSpread * 1159f / (float)temporary2.height, 1752f, 130f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 2, height / 1, 1);
			Graphics.Blit(temporary2, temporary3, this.AEODOBMBCHF);
			RenderTexture.ReleaseTemporary(temporary2);
			this.AEODOBMBCHF.SetVector("IdleMonster", new Vector4(this.blurSpread * 772f / (float)temporary2.width, 1137f, 573f, 925f));
			temporary2 = RenderTexture.GetTemporary(width / 4, height / 2, 1);
			Graphics.Blit(temporary3, temporary2, this.AEODOBMBCHF);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HOEGCEJPHLO.SetTexture("RollerBladeTurnLeft", temporary2);
			this.HOEGCEJPHLO.SetFloat("Roll", this.intensity);
			this.HOEGCEJPHLO.SetFloat("Censor OK. Object:", this.threshold);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HOEGCEJPHLO);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x0600B611 RID: 46609 RVA: 0x0050AF04 File Offset: 0x00509104
		public virtual bool AGMCDGFGINF()
		{
			base.EHGENDOEHLP(false);
			this.HOEGCEJPHLO = base.JBHLGBPJFEL(this.contrastCompositeShader, this.HOEGCEJPHLO);
			this.AEODOBMBCHF = base.OOAOHFFDMJP(this.separableBlurShader, this.AEODOBMBCHF);
			if (!this.PPGOAMIHMBG)
			{
				base.INOGPLDHPGC();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B612 RID: 46610 RVA: 0x0050AF60 File Offset: 0x00509160
		private void OJBKOLJAHAO(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 4, height / 3, 0);
			Graphics.Blit(JONJODLFAEN, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 1, height / 5, 0);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.AEODOBMBCHF.SetVector("fish/", new Vector4(1251f, this.blurSpread * 881f / (float)temporary2.height, 1158f, 368f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 7, height / 1, 1);
			Graphics.Blit(temporary2, temporary3, this.AEODOBMBCHF);
			RenderTexture.ReleaseTemporary(temporary2);
			this.AEODOBMBCHF.SetVector("repair.ogg", new Vector4(this.blurSpread * 1780f / (float)temporary2.width, 1625f, 578f, 857f));
			temporary2 = RenderTexture.GetTemporary(width / 6, height / 4, 0);
			Graphics.Blit(temporary3, temporary2, this.AEODOBMBCHF);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HOEGCEJPHLO.SetTexture("ldGo not found", temporary2);
			this.HOEGCEJPHLO.SetFloat("choldposy", this.intensity);
			this.HOEGCEJPHLO.SetFloat("_NormalAndRoughnessTexture", this.threshold);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HOEGCEJPHLO);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x0600B613 RID: 46611 RVA: 0x0050B0B8 File Offset: 0x005092B8
		private void EFEHHALJILL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.IGJKBOMMMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 5, height / 6, 1);
			Graphics.Blit(JONJODLFAEN, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 7, height / 5, 1);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.AEODOBMBCHF.SetVector("wpn_eat1", new Vector4(1055f, this.blurSpread * 1131f / (float)temporary2.height, 316f, 719f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 8, height / 7, 1);
			Graphics.Blit(temporary2, temporary3, this.AEODOBMBCHF);
			RenderTexture.ReleaseTemporary(temporary2);
			this.AEODOBMBCHF.SetVector("StaffHeal", new Vector4(this.blurSpread * 957f / (float)temporary2.width, 1168f, 191f, 259f));
			temporary2 = RenderTexture.GetTemporary(width / 7, height / 2, 1);
			Graphics.Blit(temporary3, temporary2, this.AEODOBMBCHF);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HOEGCEJPHLO.SetTexture("DepthCurveLut", temporary2);
			this.HOEGCEJPHLO.SetFloat("crft_crft", this.intensity);
			this.HOEGCEJPHLO.SetFloat("wpn_rem1", this.threshold);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HOEGCEJPHLO);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x0600B614 RID: 46612 RVA: 0x0050B210 File Offset: 0x00509410
		private void BIJMHMEDHDC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 7, height / 4, 1);
			Graphics.Blit(JONJODLFAEN, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 3, height / 3, 1);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.AEODOBMBCHF.SetVector("Low adminlevel!", new Vector4(1896f, this.blurSpread * 277f / (float)temporary2.height, 345f, 1552f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 3, height / 2, 1);
			Graphics.Blit(temporary2, temporary3, this.AEODOBMBCHF);
			RenderTexture.ReleaseTemporary(temporary2);
			this.AEODOBMBCHF.SetVector("Curve", new Vector4(this.blurSpread * 220f / (float)temporary2.width, 885f, 1647f, 282f));
			temporary2 = RenderTexture.GetTemporary(width / 4, height / 3, 1);
			Graphics.Blit(temporary3, temporary2, this.AEODOBMBCHF);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HOEGCEJPHLO.SetTexture("wpn_hookf", temporary2);
			this.HOEGCEJPHLO.SetFloat("ApplePick", this.intensity);
			this.HOEGCEJPHLO.SetFloat("", this.threshold);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HOEGCEJPHLO);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x0600B615 RID: 46613 RVA: 0x0050B368 File Offset: 0x00509568
		private void EODDHFNAMFH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 8, height / 0, 1);
			Graphics.Blit(JONJODLFAEN, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 1, height / 4, 1);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.AEODOBMBCHF.SetVector("Cloth_07.wav", new Vector4(872f, this.blurSpread * 1918f / (float)temporary2.height, 1230f, 1461f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 2, height / 2, 0);
			Graphics.Blit(temporary2, temporary3, this.AEODOBMBCHF);
			RenderTexture.ReleaseTemporary(temporary2);
			this.AEODOBMBCHF.SetVector("-L-", new Vector4(this.blurSpread * 1659f / (float)temporary2.width, 705f, 846f, 1233f));
			temporary2 = RenderTexture.GetTemporary(width / 6, height / 2, 0);
			Graphics.Blit(temporary3, temporary2, this.AEODOBMBCHF);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HOEGCEJPHLO.SetTexture("\n", temporary2);
			this.HOEGCEJPHLO.SetFloat("USE_PREDICATION", this.intensity);
			this.HOEGCEJPHLO.SetFloat("crft_none", this.threshold);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HOEGCEJPHLO);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x0600B617 RID: 46615 RVA: 0x0050B4E0 File Offset: 0x005096E0
		public virtual bool POKDAEAADAC()
		{
			base.IDFIHFBEIKD(true);
			this.HOEGCEJPHLO = base.BAPJBHPEDIF(this.contrastCompositeShader, this.HOEGCEJPHLO);
			this.AEODOBMBCHF = base.DJFOEIJIMJB(this.separableBlurShader, this.AEODOBMBCHF);
			if (!this.PPGOAMIHMBG)
			{
				base.FDBKFKGCGEG();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B618 RID: 46616 RVA: 0x0050B53C File Offset: 0x0050973C
		private void EPHHNPMPHOL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.GGJKGIHGMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 7, height / 3, 0);
			Graphics.Blit(JONJODLFAEN, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 0, height / 1, 1);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.AEODOBMBCHF.SetVector("rollSoundIndex", new Vector4(1408f, this.blurSpread * 1507f / (float)temporary2.height, 1892f, 96f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 3, height / 7, 0);
			Graphics.Blit(temporary2, temporary3, this.AEODOBMBCHF);
			RenderTexture.ReleaseTemporary(temporary2);
			this.AEODOBMBCHF.SetVector("", new Vector4(this.blurSpread * 968f / (float)temporary2.width, 1550f, 1033f, 1395f));
			temporary2 = RenderTexture.GetTemporary(width / 6, height / 4, 1);
			Graphics.Blit(temporary3, temporary2, this.AEODOBMBCHF);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HOEGCEJPHLO.SetTexture("Tonemapper curve texture", temporary2);
			this.HOEGCEJPHLO.SetFloat("category", this.intensity);
			this.HOEGCEJPHLO.SetFloat("17,18,19,20,29,33", this.threshold);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HOEGCEJPHLO);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x0600B619 RID: 46617 RVA: 0x0050B694 File Offset: 0x00509894
		private void NPAOBLFOMGI(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NHEEDPALBFN())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 2, height / 7, 0);
			Graphics.Blit(JONJODLFAEN, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 8, height / 2, 0);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.AEODOBMBCHF.SetVector(" ", new Vector4(1673f, this.blurSpread * 803f / (float)temporary2.height, 1688f, 810f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 1, height / 8, 0);
			Graphics.Blit(temporary2, temporary3, this.AEODOBMBCHF);
			RenderTexture.ReleaseTemporary(temporary2);
			this.AEODOBMBCHF.SetVector("inv_buymsg", new Vector4(this.blurSpread * 334f / (float)temporary2.width, 1516f, 1230f, 1569f));
			temporary2 = RenderTexture.GetTemporary(width / 1, height / 5, 1);
			Graphics.Blit(temporary3, temporary2, this.AEODOBMBCHF);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HOEGCEJPHLO.SetTexture("", temporary2);
			this.HOEGCEJPHLO.SetFloat("Cloth_05_00.wav", this.intensity);
			this.HOEGCEJPHLO.SetFloat("gi_uinf_4i", this.threshold);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HOEGCEJPHLO);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x0600B61A RID: 46618 RVA: 0x0050B7EC File Offset: 0x005099EC
		private void GFBELBBAJGD(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 8, height / 5, 1);
			Graphics.Blit(JONJODLFAEN, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 2, height / 4, 0);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.AEODOBMBCHF.SetVector("fishDown SHANCE", new Vector4(30f, this.blurSpread * 214f / (float)temporary2.height, 176f, 1295f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 1, height / 0, 0);
			Graphics.Blit(temporary2, temporary3, this.AEODOBMBCHF);
			RenderTexture.ReleaseTemporary(temporary2);
			this.AEODOBMBCHF.SetVector("Load", new Vector4(this.blurSpread * 788f / (float)temporary2.width, 775f, 1816f, 277f));
			temporary2 = RenderTexture.GetTemporary(width / 4, height / 3, 1);
			Graphics.Blit(temporary3, temporary2, this.AEODOBMBCHF);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HOEGCEJPHLO.SetTexture(" ms", temporary2);
			this.HOEGCEJPHLO.SetFloat("ROPE dst=", this.intensity);
			this.HOEGCEJPHLO.SetFloat("ragulaFider", this.threshold);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HOEGCEJPHLO);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x0600B61B RID: 46619 RVA: 0x0050B944 File Offset: 0x00509B44
		private void PNEFMGMHLJE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NHEEDPALBFN())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 4, height / 3, 0);
			Graphics.Blit(JONJODLFAEN, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 4, height / 0, 1);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.AEODOBMBCHF.SetVector("?", new Vector4(1903f, this.blurSpread * 1518f / (float)temporary2.height, 1965f, 1893f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 2, height / 3, 0);
			Graphics.Blit(temporary2, temporary3, this.AEODOBMBCHF);
			RenderTexture.ReleaseTemporary(temporary2);
			this.AEODOBMBCHF.SetVector("Giant2HandSlamIdle", new Vector4(this.blurSpread * 901f / (float)temporary2.width, 512f, 476f, 1333f));
			temporary2 = RenderTexture.GetTemporary(width / 6, height / 2, 0);
			Graphics.Blit(temporary3, temporary2, this.AEODOBMBCHF);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HOEGCEJPHLO.SetTexture("7", temporary2);
			this.HOEGCEJPHLO.SetFloat("MotorbikeShootFwd", this.intensity);
			this.HOEGCEJPHLO.SetFloat("newletter", this.threshold);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HOEGCEJPHLO);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x0600B61C RID: 46620 RVA: 0x0050BA9C File Offset: 0x00509C9C
		public virtual bool OLEILCHLACC()
		{
			base.EBEBJHLBBBI(false);
			this.HOEGCEJPHLO = base.ALJPMGLOIEG(this.contrastCompositeShader, this.HOEGCEJPHLO);
			this.AEODOBMBCHF = base.JBHLGBPJFEL(this.separableBlurShader, this.AEODOBMBCHF);
			if (!this.PPGOAMIHMBG)
			{
				base.FDBKFKGCGEG();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B61D RID: 46621 RVA: 0x0050BAF8 File Offset: 0x00509CF8
		public virtual bool FCIOAHEKFIG()
		{
			base.OLMOAHDIDNG(true);
			this.HOEGCEJPHLO = base.BOOFEOGDMBI(this.contrastCompositeShader, this.HOEGCEJPHLO);
			this.AEODOBMBCHF = base.ALJPMGLOIEG(this.separableBlurShader, this.AEODOBMBCHF);
			if (!this.PPGOAMIHMBG)
			{
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B61E RID: 46622 RVA: 0x0050BB54 File Offset: 0x00509D54
		public override bool MNDOFMMGLMO()
		{
			base.OFKOBOMCECF(false);
			this.HOEGCEJPHLO = base.JBHLGBPJFEL(this.contrastCompositeShader, this.HOEGCEJPHLO);
			this.AEODOBMBCHF = base.BAPJBHPEDIF(this.separableBlurShader, this.AEODOBMBCHF);
			if (!this.PPGOAMIHMBG)
			{
				base.INOGPLDHPGC();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B61F RID: 46623 RVA: 0x0050BBB0 File Offset: 0x00509DB0
		public virtual bool JOAPNOCFFBG()
		{
			base.OAAFLHNDKBJ(true);
			this.HOEGCEJPHLO = base.BOOFEOGDMBI(this.contrastCompositeShader, this.HOEGCEJPHLO);
			this.AEODOBMBCHF = base.OOAOHFFDMJP(this.separableBlurShader, this.AEODOBMBCHF);
			if (!this.PPGOAMIHMBG)
			{
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B620 RID: 46624 RVA: 0x0050BC0C File Offset: 0x00509E0C
		public virtual bool APNCPMNHKOG()
		{
			base.IDFIHFBEIKD(false);
			this.HOEGCEJPHLO = base.JBHLGBPJFEL(this.contrastCompositeShader, this.HOEGCEJPHLO);
			this.AEODOBMBCHF = base.JBHLGBPJFEL(this.separableBlurShader, this.AEODOBMBCHF);
			if (!this.PPGOAMIHMBG)
			{
				base.INOGPLDHPGC();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B621 RID: 46625 RVA: 0x0050BC68 File Offset: 0x00509E68
		private void EOMGNPFHPBD(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.MNDOFMMGLMO())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 2, height / 1, 1);
			Graphics.Blit(JONJODLFAEN, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 7, height / 2, 1);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.AEODOBMBCHF.SetVector("post_21", new Vector4(621f, this.blurSpread * 112f / (float)temporary2.height, 718f, 491f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 2, height / 2, 1);
			Graphics.Blit(temporary2, temporary3, this.AEODOBMBCHF);
			RenderTexture.ReleaseTemporary(temporary2);
			this.AEODOBMBCHF.SetVector("prk_max", new Vector4(this.blurSpread * 916f / (float)temporary2.width, 492f, 1781f, 873f));
			temporary2 = RenderTexture.GetTemporary(width / 4, height / 3, 1);
			Graphics.Blit(temporary3, temporary2, this.AEODOBMBCHF);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HOEGCEJPHLO.SetTexture("Image Effects are not supported on this platform.", temporary2);
			this.HOEGCEJPHLO.SetFloat("_Radius", this.intensity);
			this.HOEGCEJPHLO.SetFloat("CrouchStrafeLeft", this.threshold);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HOEGCEJPHLO);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x0600B622 RID: 46626 RVA: 0x0050BDC0 File Offset: 0x00509FC0
		private void OnRenderImage(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 2, height / 2, 0);
			Graphics.Blit(JONJODLFAEN, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 4, height / 4, 0);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.AEODOBMBCHF.SetVector("offsets", new Vector4(0f, this.blurSpread * 1f / (float)temporary2.height, 0f, 0f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 4, height / 4, 0);
			Graphics.Blit(temporary2, temporary3, this.AEODOBMBCHF);
			RenderTexture.ReleaseTemporary(temporary2);
			this.AEODOBMBCHF.SetVector("offsets", new Vector4(this.blurSpread * 1f / (float)temporary2.width, 0f, 0f, 0f));
			temporary2 = RenderTexture.GetTemporary(width / 4, height / 4, 0);
			Graphics.Blit(temporary3, temporary2, this.AEODOBMBCHF);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HOEGCEJPHLO.SetTexture("_MainTexBlurred", temporary2);
			this.HOEGCEJPHLO.SetFloat("intensity", this.intensity);
			this.HOEGCEJPHLO.SetFloat("threshold", this.threshold);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HOEGCEJPHLO);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x0600B623 RID: 46627 RVA: 0x0050BF18 File Offset: 0x0050A118
		public virtual bool DEHFEHNMOFH()
		{
			base.NHCAHIHJHMF(true);
			this.HOEGCEJPHLO = base.ALJPMGLOIEG(this.contrastCompositeShader, this.HOEGCEJPHLO);
			this.AEODOBMBCHF = base.DJFOEIJIMJB(this.separableBlurShader, this.AEODOBMBCHF);
			if (!this.PPGOAMIHMBG)
			{
				base.OAEAMDHOKKM();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B624 RID: 46628 RVA: 0x0050BF74 File Offset: 0x0050A174
		public virtual bool LFFHBBCPHJE()
		{
			base.OLMOAHDIDNG(true);
			this.HOEGCEJPHLO = base.DJFOEIJIMJB(this.contrastCompositeShader, this.HOEGCEJPHLO);
			this.AEODOBMBCHF = base.IIIIADNBONI(this.separableBlurShader, this.AEODOBMBCHF);
			if (!this.PPGOAMIHMBG)
			{
				base.NAIBIABADFB();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B625 RID: 46629 RVA: 0x0050BFD0 File Offset: 0x0050A1D0
		private void ALNHCIOIBPP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 6, height / 8, 0);
			Graphics.Blit(JONJODLFAEN, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 3, height / 3, 1);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.AEODOBMBCHF.SetVector(" locid=", new Vector4(1011f, this.blurSpread * 1039f / (float)temporary2.height, 488f, 83f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 1, height / 2, 1);
			Graphics.Blit(temporary2, temporary3, this.AEODOBMBCHF);
			RenderTexture.ReleaseTemporary(temporary2);
			this.AEODOBMBCHF.SetVector("wpn_drop", new Vector4(this.blurSpread * 233f / (float)temporary2.width, 790f, 1204f, 1053f));
			temporary2 = RenderTexture.GetTemporary(width / 3, height / 8, 1);
			Graphics.Blit(temporary3, temporary2, this.AEODOBMBCHF);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HOEGCEJPHLO.SetTexture("1 Hand Sword Strafe Left", temporary2);
			this.HOEGCEJPHLO.SetFloat("Root Node bone is null, can not initiate the solver.", this.intensity);
			this.HOEGCEJPHLO.SetFloat("Label", this.threshold);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HOEGCEJPHLO);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x0600B626 RID: 46630 RVA: 0x0050C128 File Offset: 0x0050A328
		public virtual bool DPCKBGJGNAK()
		{
			base.EBEBJHLBBBI(false);
			this.HOEGCEJPHLO = base.BOOFEOGDMBI(this.contrastCompositeShader, this.HOEGCEJPHLO);
			this.AEODOBMBCHF = base.BOOFEOGDMBI(this.separableBlurShader, this.AEODOBMBCHF);
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B627 RID: 46631 RVA: 0x0050C184 File Offset: 0x0050A384
		private void DHJHEGHEGOH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 2, height / 8, 0);
			Graphics.Blit(JONJODLFAEN, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 8, height / 2, 1);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			this.AEODOBMBCHF.SetVector("CM", new Vector4(397f, this.blurSpread * 1007f / (float)temporary2.height, 1085f, 1198f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 6, height / 3, 1);
			Graphics.Blit(temporary2, temporary3, this.AEODOBMBCHF);
			RenderTexture.ReleaseTemporary(temporary2);
			this.AEODOBMBCHF.SetVector("t_much", new Vector4(this.blurSpread * 359f / (float)temporary2.width, 1495f, 429f, 100f));
			temporary2 = RenderTexture.GetTemporary(width / 6, height / 5, 0);
			Graphics.Blit(temporary3, temporary2, this.AEODOBMBCHF);
			RenderTexture.ReleaseTemporary(temporary3);
			this.HOEGCEJPHLO.SetTexture("name", temporary2);
			this.HOEGCEJPHLO.SetFloat("StormStrike", this.intensity);
			this.HOEGCEJPHLO.SetFloat("<color='#c0c080'>", this.threshold);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HOEGCEJPHLO);
			RenderTexture.ReleaseTemporary(temporary2);
		}

		// Token: 0x0600B628 RID: 46632 RVA: 0x0050C2DC File Offset: 0x0050A4DC
		public virtual bool CHJBCBDIBJJ()
		{
			base.EBEBJHLBBBI(false);
			this.HOEGCEJPHLO = base.BOOFEOGDMBI(this.contrastCompositeShader, this.HOEGCEJPHLO);
			this.AEODOBMBCHF = base.JBHLGBPJFEL(this.separableBlurShader, this.AEODOBMBCHF);
			if (!this.PPGOAMIHMBG)
			{
				base.OAEAMDHOKKM();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x04001770 RID: 6000
		[Range(0f, 1f)]
		public float intensity = 0.5f;

		// Token: 0x04001771 RID: 6001
		[Range(0f, 0.999f)]
		public float threshold;

		// Token: 0x04001772 RID: 6002
		private Material AEODOBMBCHF;

		// Token: 0x04001773 RID: 6003
		private Material HOEGCEJPHLO;

		// Token: 0x04001774 RID: 6004
		[Range(0f, 1f)]
		public float blurSpread = 1f;

		// Token: 0x04001775 RID: 6005
		public Shader separableBlurShader;

		// Token: 0x04001776 RID: 6006
		public Shader contrastCompositeShader;
	}
}
