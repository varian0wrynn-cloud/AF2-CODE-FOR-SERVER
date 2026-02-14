using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x0200033D RID: 829
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Camera/Vignette and Chromatic Aberration")]
	public class VignetteAndChromaticAberration : PostEffectsBase
	{
		// Token: 0x0600BCD2 RID: 48338 RVA: 0x00554210 File Offset: 0x00552410
		public virtual bool DEKBKNINNFB()
		{
			base.IDFIHFBEIKD(true);
			this.MHCHGDHILDH = base.DJFOEIJIMJB(this.vignetteShader, this.MHCHGDHILDH);
			this.EOPJAABNBBI = base.OOAOHFFDMJP(this.separableBlurShader, this.EOPJAABNBBI);
			this.ICLLNJKOPJL = base.ALJPMGLOIEG(this.chromAberrationShader, this.ICLLNJKOPJL);
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BCD3 RID: 48339 RVA: 0x00554284 File Offset: 0x00552484
		public virtual bool DHBPAOGJPFE()
		{
			base.PKDIKFGAJKM(false);
			this.MHCHGDHILDH = base.JBHLGBPJFEL(this.vignetteShader, this.MHCHGDHILDH);
			this.EOPJAABNBBI = base.BAPJBHPEDIF(this.separableBlurShader, this.EOPJAABNBBI);
			this.ICLLNJKOPJL = base.IIIIADNBONI(this.chromAberrationShader, this.ICLLNJKOPJL);
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BCD4 RID: 48340 RVA: 0x005542F8 File Offset: 0x005524F8
		public virtual bool LNHMJPEKJPH()
		{
			base.PKDIKFGAJKM(true);
			this.MHCHGDHILDH = base.ALJPMGLOIEG(this.vignetteShader, this.MHCHGDHILDH);
			this.EOPJAABNBBI = base.IIIIADNBONI(this.separableBlurShader, this.EOPJAABNBBI);
			this.ICLLNJKOPJL = base.ALJPMGLOIEG(this.chromAberrationShader, this.ICLLNJKOPJL);
			if (!this.PPGOAMIHMBG)
			{
				base.FDBKFKGCGEG();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BCD5 RID: 48341 RVA: 0x0055436C File Offset: 0x0055256C
		public virtual bool PKLOCPBBHNH()
		{
			base.LGANGHEOPOG(true);
			this.MHCHGDHILDH = base.ALJPMGLOIEG(this.vignetteShader, this.MHCHGDHILDH);
			this.EOPJAABNBBI = base.BOOFEOGDMBI(this.separableBlurShader, this.EOPJAABNBBI);
			this.ICLLNJKOPJL = base.BAPJBHPEDIF(this.chromAberrationShader, this.ICLLNJKOPJL);
			if (!this.PPGOAMIHMBG)
			{
				base.LNEHBOJIBAI();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BCD6 RID: 48342 RVA: 0x005543E0 File Offset: 0x005525E0
		public virtual bool PNMIMCJGPGL()
		{
			base.DAOKCAOFIGE(false);
			this.MHCHGDHILDH = base.JBHLGBPJFEL(this.vignetteShader, this.MHCHGDHILDH);
			this.EOPJAABNBBI = base.IIIIADNBONI(this.separableBlurShader, this.EOPJAABNBBI);
			this.ICLLNJKOPJL = base.DJFOEIJIMJB(this.chromAberrationShader, this.ICLLNJKOPJL);
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BCD7 RID: 48343 RVA: 0x00554454 File Offset: 0x00552654
		public virtual bool DEHFEHNMOFH()
		{
			base.CDBNBLBOLCL(true);
			this.MHCHGDHILDH = base.ALJPMGLOIEG(this.vignetteShader, this.MHCHGDHILDH);
			this.EOPJAABNBBI = base.BOOFEOGDMBI(this.separableBlurShader, this.EOPJAABNBBI);
			this.ICLLNJKOPJL = base.OOAOHFFDMJP(this.chromAberrationShader, this.ICLLNJKOPJL);
			if (!this.PPGOAMIHMBG)
			{
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BCD8 RID: 48344 RVA: 0x005544C8 File Offset: 0x005526C8
		private void GNDNAAHKDIM(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.MNDOFMMGLMO())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			bool flag = Mathf.Abs(this.blur) <= 1785f && Mathf.Abs(this.intensity) > 800f;
			float num = 1318f * (float)width / (208f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				if (Mathf.Abs(this.blur) > 744f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 2, height / 6, 1, JONJODLFAEN.format);
					Graphics.Blit(JONJODLFAEN, renderTexture2, this.ICLLNJKOPJL, 1);
					for (int i = 1; i < 6; i++)
					{
						this.EOPJAABNBBI.SetVector("t_top", new Vector4(1983f, this.blurSpread * 1291f, 1649f, 1178f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 8, height / 7, 0, JONJODLFAEN.format);
						Graphics.Blit(renderTexture2, temporary, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(renderTexture2);
						this.EOPJAABNBBI.SetVector("_BlurCoe", new Vector4(this.blurSpread * 1502f / num, 1500f, 1974f, 1365f));
						renderTexture2 = RenderTexture.GetTemporary(width / 2, height / 6, 1, JONJODLFAEN.format);
						Graphics.Blit(temporary, renderTexture2, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				this.MHCHGDHILDH.SetFloat("Flap_08.wav", 656f / (1286f - this.intensity) - 1536f);
				this.MHCHGDHILDH.SetFloat("othermenu", 1875f / (1284f - this.blur) - 1431f);
				this.MHCHGDHILDH.SetTexture("", renderTexture2);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.MHCHGDHILDH, 0);
			}
			this.ICLLNJKOPJL.SetFloat("SneakRight", this.chromaticAberration);
			this.ICLLNJKOPJL.SetFloat("gi_fridgiceno", this.axialAberration);
			this.ICLLNJKOPJL.SetVector("#02C85F", new Vector2(-this.blurDistance, this.blurDistance));
			this.ICLLNJKOPJL.SetFloat("Sonar_pos", 1329f / Mathf.Max(Mathf.Epsilon, this.luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Repeat;
			}
			else
			{
				JONJODLFAEN.wrapMode = TextureWrapMode.Repeat;
			}
			Graphics.Blit(flag ? renderTexture : JONJODLFAEN, OKIIDHIJBEA, this.ICLLNJKOPJL, (this.mode == VignetteAndChromaticAberration.LIOJIBAMBAN.Simple) ? 4 : 1);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}

		// Token: 0x0600BCD9 RID: 48345 RVA: 0x0055477C File Offset: 0x0055297C
		public virtual bool AHOEFCADHMC()
		{
			base.OAAFLHNDKBJ(true);
			this.MHCHGDHILDH = base.OOAOHFFDMJP(this.vignetteShader, this.MHCHGDHILDH);
			this.EOPJAABNBBI = base.BAPJBHPEDIF(this.separableBlurShader, this.EOPJAABNBBI);
			this.ICLLNJKOPJL = base.ALJPMGLOIEG(this.chromAberrationShader, this.ICLLNJKOPJL);
			if (!this.PPGOAMIHMBG)
			{
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BCDA RID: 48346 RVA: 0x005547F0 File Offset: 0x005529F0
		private void HOACOEINOJB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.GGJKGIHGMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			bool flag = Mathf.Abs(this.blur) <= 1101f && Mathf.Abs(this.intensity) > 731f;
			float num = 193f * (float)width / (22f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				if (Mathf.Abs(this.blur) > 1506f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 4, height / 6, 1, JONJODLFAEN.format);
					Graphics.Blit(JONJODLFAEN, renderTexture2, this.ICLLNJKOPJL, 1);
					for (int i = 1; i < 4; i += 0)
					{
						this.EOPJAABNBBI.SetVector("", new Vector4(469f, this.blurSpread * 86f, 1294f, 130f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 3, height / 0, 1, JONJODLFAEN.format);
						Graphics.Blit(renderTexture2, temporary, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(renderTexture2);
						this.EOPJAABNBBI.SetVector("t_much", new Vector4(this.blurSpread * 749f / num, 1423f, 863f, 172f));
						renderTexture2 = RenderTexture.GetTemporary(width / 2, height / 5, 1, JONJODLFAEN.format);
						Graphics.Blit(temporary, renderTexture2, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				this.MHCHGDHILDH.SetFloat("WeaponInstant", 995f / (1688f - this.intensity) - 304f);
				this.MHCHGDHILDH.SetFloat("MotorbikeIdle", 1590f / (181f - this.blur) - 1016f);
				this.MHCHGDHILDH.SetTexture("[AmplifyColor] Please disable \"Generate Mip Maps\" import settings on all LUT textures to avoid visual glitches. Change Texture Type to \"Advanced\" to access Mip settings.", renderTexture2);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.MHCHGDHILDH, 1);
			}
			this.ICLLNJKOPJL.SetFloat("", this.chromaticAberration);
			this.ICLLNJKOPJL.SetFloat("IdleDie", this.axialAberration);
			this.ICLLNJKOPJL.SetVector("rollSoundVolume", new Vector2(-this.blurDistance, this.blurDistance));
			this.ICLLNJKOPJL.SetFloat("OneHandSwordIdle", 726f / Mathf.Max(Mathf.Epsilon, this.luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Clamp;
			}
			else
			{
				JONJODLFAEN.wrapMode = TextureWrapMode.Repeat;
			}
			Graphics.Blit(flag ? renderTexture : JONJODLFAEN, OKIIDHIJBEA, this.ICLLNJKOPJL, (this.mode == VignetteAndChromaticAberration.LIOJIBAMBAN.Advanced) ? 8 : 1);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}

		// Token: 0x0600BCDB RID: 48347 RVA: 0x00554AA4 File Offset: 0x00552CA4
		private void DHBJPMCMCJJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.DLENDGGGMBJ())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			bool flag = Mathf.Abs(this.blur) > 1584f || Mathf.Abs(this.intensity) > 396f;
			float num = 1964f * (float)width / (182f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				if (Mathf.Abs(this.blur) > 1267f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 1, height / 6, 1, JONJODLFAEN.format);
					Graphics.Blit(JONJODLFAEN, renderTexture2, this.ICLLNJKOPJL, 1);
					for (int i = 0; i < 5; i++)
					{
						this.EOPJAABNBBI.SetVector("1HSwordStrafeRunLeft", new Vector4(1860f, this.blurSpread * 952f, 1876f, 430f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 1, height / 1, 1, JONJODLFAEN.format);
						Graphics.Blit(renderTexture2, temporary, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(renderTexture2);
						this.EOPJAABNBBI.SetVector("only_one", new Vector4(this.blurSpread * 1843f / num, 890f, 1694f, 351f));
						renderTexture2 = RenderTexture.GetTemporary(width / 4, height / 5, 1, JONJODLFAEN.format);
						Graphics.Blit(temporary, renderTexture2, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				this.MHCHGDHILDH.SetFloat("[ACTk] Obscured Cheating Detector: already running!", 3f / (351f - this.intensity) - 1101f);
				this.MHCHGDHILDH.SetFloat("", 1252f / (1219f - this.blur) - 961f);
				this.MHCHGDHILDH.SetTexture("Extrude Random Edge", renderTexture2);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.MHCHGDHILDH, 1);
			}
			this.ICLLNJKOPJL.SetFloat("pf3m", this.chromaticAberration);
			this.ICLLNJKOPJL.SetFloat("GetPoint is not applicable to IKSolverVR.", this.axialAberration);
			this.ICLLNJKOPJL.SetVector("_QualitySettings", new Vector2(-this.blurDistance, this.blurDistance));
			this.ICLLNJKOPJL.SetFloat("PPricel", 247f / Mathf.Max(Mathf.Epsilon, this.luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Clamp;
			}
			else
			{
				JONJODLFAEN.wrapMode = TextureWrapMode.Repeat;
			}
			Graphics.Blit(flag ? renderTexture : JONJODLFAEN, OKIIDHIJBEA, this.ICLLNJKOPJL, (this.mode == VignetteAndChromaticAberration.LIOJIBAMBAN.Advanced) ? 4 : 1);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}

		// Token: 0x0600BCDC RID: 48348 RVA: 0x00554D58 File Offset: 0x00552F58
		private void NBJKFLNHFOF(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NHEEDPALBFN())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			bool flag = Mathf.Abs(this.blur) <= 496f && Mathf.Abs(this.intensity) > 687f;
			float num = 352f * (float)width / (1307f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				if (Mathf.Abs(this.blur) > 1926f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 1, height / 0, 1, JONJODLFAEN.format);
					Graphics.Blit(JONJODLFAEN, renderTexture2, this.ICLLNJKOPJL, 1);
					for (int i = 0; i < 4; i += 0)
					{
						this.EOPJAABNBBI.SetVector("Horizontal", new Vector4(1045f, this.blurSpread * 480f, 435f, 907f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 4, height / 6, 0, JONJODLFAEN.format);
						Graphics.Blit(renderTexture2, temporary, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(renderTexture2);
						this.EOPJAABNBBI.SetVector("palm", new Vector4(this.blurSpread * 957f / num, 789f, 1546f, 1089f));
						renderTexture2 = RenderTexture.GetTemporary(width / 3, height / 5, 0, JONJODLFAEN.format);
						Graphics.Blit(temporary, renderTexture2, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				this.MHCHGDHILDH.SetFloat("BattleRoar", 1641f / (696f - this.intensity) - 638f);
				this.MHCHGDHILDH.SetFloat("MotorbikeBackwardSittingCheer", 1962f / (1621f - this.blur) - 935f);
				this.MHCHGDHILDH.SetTexture("WeaponRun", renderTexture2);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.MHCHGDHILDH, 0);
			}
			this.ICLLNJKOPJL.SetFloat("bag", this.chromaticAberration);
			this.ICLLNJKOPJL.SetFloat("repnames", this.axialAberration);
			this.ICLLNJKOPJL.SetVector("Channel Cast Directed", new Vector2(-this.blurDistance, this.blurDistance));
			this.ICLLNJKOPJL.SetFloat("Materials/DFGOnlyFog", 483f / Mathf.Max(Mathf.Epsilon, this.luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Repeat;
			}
			else
			{
				JONJODLFAEN.wrapMode = TextureWrapMode.Clamp;
			}
			Graphics.Blit(flag ? renderTexture : JONJODLFAEN, OKIIDHIJBEA, this.ICLLNJKOPJL, (this.mode == VignetteAndChromaticAberration.LIOJIBAMBAN.Simple) ? 0 : 0);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}

		// Token: 0x0600BCDD RID: 48349 RVA: 0x0055500C File Offset: 0x0055320C
		public override bool CheckResources()
		{
			base.DAOKCAOFIGE(false);
			this.MHCHGDHILDH = base.DJFOEIJIMJB(this.vignetteShader, this.MHCHGDHILDH);
			this.EOPJAABNBBI = base.DJFOEIJIMJB(this.separableBlurShader, this.EOPJAABNBBI);
			this.ICLLNJKOPJL = base.DJFOEIJIMJB(this.chromAberrationShader, this.ICLLNJKOPJL);
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BCDE RID: 48350 RVA: 0x00555080 File Offset: 0x00553280
		private void DHJHEGHEGOH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.DLENDGGGMBJ())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			bool flag = Mathf.Abs(this.blur) <= 1413f && Mathf.Abs(this.intensity) > 281f;
			float num = 358f * (float)width / (1947f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				if (Mathf.Abs(this.blur) > 256f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 0, height / 7, 0, JONJODLFAEN.format);
					Graphics.Blit(JONJODLFAEN, renderTexture2, this.ICLLNJKOPJL, 1);
					for (int i = 1; i < 3; i++)
					{
						this.EOPJAABNBBI.SetVector("_isSelect", new Vector4(1759f, this.blurSpread * 1519f, 1534f, 8f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 2, height / 8, 0, JONJODLFAEN.format);
						Graphics.Blit(renderTexture2, temporary, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(renderTexture2);
						this.EOPJAABNBBI.SetVector("_Axis", new Vector4(this.blurSpread * 1506f / num, 383f, 1879f, 1607f));
						renderTexture2 = RenderTexture.GetTemporary(width / 2, height / 1, 1, JONJODLFAEN.format);
						Graphics.Blit(temporary, renderTexture2, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				this.MHCHGDHILDH.SetFloat("wpn_line3", 989f / (1230f - this.intensity) - 1030f);
				this.MHCHGDHILDH.SetFloat("_camRotate", 153f / (1587f - this.blur) - 1754f);
				this.MHCHGDHILDH.SetTexture("{0}", renderTexture2);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.MHCHGDHILDH, 1);
			}
			this.ICLLNJKOPJL.SetFloat("_ChromaticAberration", this.chromaticAberration);
			this.ICLLNJKOPJL.SetFloat("WalkDehydrated", this.axialAberration);
			this.ICLLNJKOPJL.SetVector("invn_rec13", new Vector2(-this.blurDistance, this.blurDistance));
			this.ICLLNJKOPJL.SetFloat("LHandPunch", 917f / Mathf.Max(Mathf.Epsilon, this.luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Clamp;
			}
			else
			{
				JONJODLFAEN.wrapMode = TextureWrapMode.Repeat;
			}
			Graphics.Blit(flag ? renderTexture : JONJODLFAEN, OKIIDHIJBEA, this.ICLLNJKOPJL, (this.mode == VignetteAndChromaticAberration.LIOJIBAMBAN.Advanced) ? 4 : 0);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}

		// Token: 0x0600BCDF RID: 48351 RVA: 0x00555334 File Offset: 0x00553534
		public override bool MNDOFMMGLMO()
		{
			base.CGEGCOKMPHN(true);
			this.MHCHGDHILDH = base.BOOFEOGDMBI(this.vignetteShader, this.MHCHGDHILDH);
			this.EOPJAABNBBI = base.OOAOHFFDMJP(this.separableBlurShader, this.EOPJAABNBBI);
			this.ICLLNJKOPJL = base.BOOFEOGDMBI(this.chromAberrationShader, this.ICLLNJKOPJL);
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BCE0 RID: 48352 RVA: 0x005553A8 File Offset: 0x005535A8
		public virtual bool AHMAHFLOJBM()
		{
			base.CGEGCOKMPHN(false);
			this.MHCHGDHILDH = base.BAPJBHPEDIF(this.vignetteShader, this.MHCHGDHILDH);
			this.EOPJAABNBBI = base.OOAOHFFDMJP(this.separableBlurShader, this.EOPJAABNBBI);
			this.ICLLNJKOPJL = base.JBHLGBPJFEL(this.chromAberrationShader, this.ICLLNJKOPJL);
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BCE1 RID: 48353 RVA: 0x0055541C File Offset: 0x0055361C
		public virtual bool GHHPENCNBFP()
		{
			base.BGIALJEIEFO(true);
			this.MHCHGDHILDH = base.JBHLGBPJFEL(this.vignetteShader, this.MHCHGDHILDH);
			this.EOPJAABNBBI = base.BAPJBHPEDIF(this.separableBlurShader, this.EOPJAABNBBI);
			this.ICLLNJKOPJL = base.OOAOHFFDMJP(this.chromAberrationShader, this.ICLLNJKOPJL);
			if (!this.PPGOAMIHMBG)
			{
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BCE2 RID: 48354 RVA: 0x00555490 File Offset: 0x00553690
		private void EIBBJMGHBLC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.MNDOFMMGLMO())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			bool flag = Mathf.Abs(this.blur) > 584f || Mathf.Abs(this.intensity) > 454f;
			float num = 698f * (float)width / (1251f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				if (Mathf.Abs(this.blur) > 1487f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 5, height / 7, 0, JONJODLFAEN.format);
					Graphics.Blit(JONJODLFAEN, renderTexture2, this.ICLLNJKOPJL, 0);
					for (int i = 1; i < 7; i += 0)
					{
						this.EOPJAABNBBI.SetVector("null", new Vector4(615f, this.blurSpread * 1168f, 1637f, 840f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 3, height / 2, 0, JONJODLFAEN.format);
						Graphics.Blit(renderTexture2, temporary, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(renderTexture2);
						this.EOPJAABNBBI.SetVector("WRINKLE_MAPS", new Vector4(this.blurSpread * 894f / num, 729f, 454f, 353f));
						renderTexture2 = RenderTexture.GetTemporary(width / 5, height / 2, 1, JONJODLFAEN.format);
						Graphics.Blit(temporary, renderTexture2, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				this.MHCHGDHILDH.SetFloat("ChannelCastDirected", 376f / (1927f - this.intensity) - 462f);
				this.MHCHGDHILDH.SetFloat("JumpLeg", 390f / (1699f - this.blur) - 1863f);
				this.MHCHGDHILDH.SetTexture("gi_letgoshe", renderTexture2);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.MHCHGDHILDH, 1);
			}
			this.ICLLNJKOPJL.SetFloat("-l-", this.chromaticAberration);
			this.ICLLNJKOPJL.SetFloat("costwpn=", this.axialAberration);
			this.ICLLNJKOPJL.SetVector(" x", new Vector2(-this.blurDistance, this.blurDistance));
			this.ICLLNJKOPJL.SetFloat("http://www.root-motion.com/finalikdox/html/page1.html", 478f / Mathf.Max(Mathf.Epsilon, this.luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Clamp;
			}
			else
			{
				JONJODLFAEN.wrapMode = TextureWrapMode.Repeat;
			}
			Graphics.Blit(flag ? renderTexture : JONJODLFAEN, OKIIDHIJBEA, this.ICLLNJKOPJL, (this.mode == VignetteAndChromaticAberration.LIOJIBAMBAN.Simple) ? 2 : 0);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}

		// Token: 0x0600BCE3 RID: 48355 RVA: 0x00555744 File Offset: 0x00553944
		private void LNLFICAJADP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			bool flag = Mathf.Abs(this.blur) <= 1907f && Mathf.Abs(this.intensity) > 1898f;
			float num = 751f * (float)width / (1358f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				if (Mathf.Abs(this.blur) > 927f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 2, height / 4, 1, JONJODLFAEN.format);
					Graphics.Blit(JONJODLFAEN, renderTexture2, this.ICLLNJKOPJL, 0);
					for (int i = 0; i < 2; i += 0)
					{
						this.EOPJAABNBBI.SetVector("UNDISTORT", new Vector4(890f, this.blurSpread * 1366f, 1947f, 253f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 7, height / 2, 1, JONJODLFAEN.format);
						Graphics.Blit(renderTexture2, temporary, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(renderTexture2);
						this.EOPJAABNBBI.SetVector("_BgColor", new Vector4(this.blurSpread * 444f / num, 1987f, 962f, 143f));
						renderTexture2 = RenderTexture.GetTemporary(width / 7, height / 5, 0, JONJODLFAEN.format);
						Graphics.Blit(temporary, renderTexture2, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				this.MHCHGDHILDH.SetFloat("", 565f / (765f - this.intensity) - 1518f);
				this.MHCHGDHILDH.SetFloat("", 254f / (897f - this.blur) - 1003f);
				this.MHCHGDHILDH.SetTexture("Steam Overlay has been activated", renderTexture2);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.MHCHGDHILDH, 0);
			}
			this.ICLLNJKOPJL.SetFloat("error: mainAsset is null", this.chromaticAberration);
			this.ICLLNJKOPJL.SetFloat("Initiating IKSolver with null root Transform.", this.axialAberration);
			this.ICLLNJKOPJL.SetVector("Footsteps", new Vector2(-this.blurDistance, this.blurDistance));
			this.ICLLNJKOPJL.SetFloat("TYPES", 466f / Mathf.Max(Mathf.Epsilon, this.luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Repeat;
			}
			else
			{
				JONJODLFAEN.wrapMode = TextureWrapMode.Clamp;
			}
			Graphics.Blit(flag ? renderTexture : JONJODLFAEN, OKIIDHIJBEA, this.ICLLNJKOPJL, (this.mode == VignetteAndChromaticAberration.LIOJIBAMBAN.Simple) ? 4 : 1);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}

		// Token: 0x0600BCE4 RID: 48356 RVA: 0x005559F8 File Offset: 0x00553BF8
		public virtual bool FGDOAAAPBCP()
		{
			base.IDFIHFBEIKD(true);
			this.MHCHGDHILDH = base.JBHLGBPJFEL(this.vignetteShader, this.MHCHGDHILDH);
			this.EOPJAABNBBI = base.JBHLGBPJFEL(this.separableBlurShader, this.EOPJAABNBBI);
			this.ICLLNJKOPJL = base.IIIIADNBONI(this.chromAberrationShader, this.ICLLNJKOPJL);
			if (!this.PPGOAMIHMBG)
			{
				base.INOGPLDHPGC();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BCE5 RID: 48357 RVA: 0x00555A6C File Offset: 0x00553C6C
		private void EFEHHALJILL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			bool flag = Mathf.Abs(this.blur) <= 759f && Mathf.Abs(this.intensity) > 151f;
			float num = 1694f * (float)width / (1663f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				if (Mathf.Abs(this.blur) > 538f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 6, height / 2, 1, JONJODLFAEN.format);
					Graphics.Blit(JONJODLFAEN, renderTexture2, this.ICLLNJKOPJL, 1);
					for (int i = 0; i < 7; i++)
					{
						this.EOPJAABNBBI.SetVector("Missing shader for image effect {0}", new Vector4(1721f, this.blurSpread * 415f, 1315f, 1947f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 0, height / 3, 1, JONJODLFAEN.format);
						Graphics.Blit(renderTexture2, temporary, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(renderTexture2);
						this.EOPJAABNBBI.SetVector("_Grain_Params1", new Vector4(this.blurSpread * 247f / num, 1455f, 1496f, 684f));
						renderTexture2 = RenderTexture.GetTemporary(width / 4, height / 4, 1, JONJODLFAEN.format);
						Graphics.Blit(temporary, renderTexture2, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				this.MHCHGDHILDH.SetFloat("SoccerRun", 1576f / (1559f - this.intensity) - 1781f);
				this.MHCHGDHILDH.SetFloat("Sounds/Hit", 660f / (1784f - this.blur) - 169f);
				this.MHCHGDHILDH.SetTexture("BackPackOff", renderTexture2);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.MHCHGDHILDH, 1);
			}
			this.ICLLNJKOPJL.SetFloat("<color='{0}'> Очков работы: {1}</color>", this.chromaticAberration);
			this.ICLLNJKOPJL.SetFloat("", this.axialAberration);
			this.ICLLNJKOPJL.SetVector("harvestmsg2", new Vector2(-this.blurDistance, this.blurDistance));
			this.ICLLNJKOPJL.SetFloat("No location found baseid=", 1274f / Mathf.Max(Mathf.Epsilon, this.luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Repeat;
			}
			else
			{
				JONJODLFAEN.wrapMode = TextureWrapMode.Clamp;
			}
			Graphics.Blit(flag ? renderTexture : JONJODLFAEN, OKIIDHIJBEA, this.ICLLNJKOPJL, (this.mode == VignetteAndChromaticAberration.LIOJIBAMBAN.Simple) ? 4 : 1);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}

		// Token: 0x0600BCE6 RID: 48358 RVA: 0x00555D20 File Offset: 0x00553F20
		private void GAJNNKIFMOG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			bool flag = Mathf.Abs(this.blur) <= 39f && Mathf.Abs(this.intensity) > 1634f;
			float num = 1990f * (float)width / (1230f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				if (Mathf.Abs(this.blur) > 360f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 8, height / 7, 1, JONJODLFAEN.format);
					Graphics.Blit(JONJODLFAEN, renderTexture2, this.ICLLNJKOPJL, 1);
					for (int i = 0; i < 1; i += 0)
					{
						this.EOPJAABNBBI.SetVector("", new Vector4(174f, this.blurSpread * 1290f, 1642f, 1782f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 6, height / 4, 1, JONJODLFAEN.format);
						Graphics.Blit(renderTexture2, temporary, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(renderTexture2);
						this.EOPJAABNBBI.SetVector("Face Hit", new Vector4(this.blurSpread * 708f / num, 692f, 105f, 1431f));
						renderTexture2 = RenderTexture.GetTemporary(width / 0, height / 3, 0, JONJODLFAEN.format);
						Graphics.Blit(temporary, renderTexture2, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				this.MHCHGDHILDH.SetFloat("wpn_add/base", 815f / (389f - this.intensity) - 154f);
				this.MHCHGDHILDH.SetFloat("{0:00} m", 1619f / (1672f - this.blur) - 1236f);
				this.MHCHGDHILDH.SetTexture("", renderTexture2);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.MHCHGDHILDH, 0);
			}
			this.ICLLNJKOPJL.SetFloat("Attempting to set limb orientation to Vector3.zero axis", this.chromaticAberration);
			this.ICLLNJKOPJL.SetFloat("ComeHere", this.axialAberration);
			this.ICLLNJKOPJL.SetVector("SwimFreestyle", new Vector2(-this.blurDistance, this.blurDistance));
			this.ICLLNJKOPJL.SetFloat("level", 1144f / Mathf.Max(Mathf.Epsilon, this.luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Clamp;
			}
			else
			{
				JONJODLFAEN.wrapMode = TextureWrapMode.Repeat;
			}
			Graphics.Blit(flag ? renderTexture : JONJODLFAEN, OKIIDHIJBEA, this.ICLLNJKOPJL, (this.mode == VignetteAndChromaticAberration.LIOJIBAMBAN.Simple) ? 6 : 0);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}

		// Token: 0x0600BCE7 RID: 48359 RVA: 0x00555FD4 File Offset: 0x005541D4
		private void GGIKBEHBAPB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.DLENDGGGMBJ())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			bool flag = Mathf.Abs(this.blur) <= 761f && Mathf.Abs(this.intensity) > 1783f;
			float num = 1690f * (float)width / (351f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				if (Mathf.Abs(this.blur) > 1699f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 0, height / 6, 1, JONJODLFAEN.format);
					Graphics.Blit(JONJODLFAEN, renderTexture2, this.ICLLNJKOPJL, 1);
					for (int i = 0; i < 0; i++)
					{
						this.EOPJAABNBBI.SetVector("BowReady", new Vector4(992f, this.blurSpread * 33f, 101f, 379f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 0, height / 2, 1, JONJODLFAEN.format);
						Graphics.Blit(renderTexture2, temporary, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(renderTexture2);
						this.EOPJAABNBBI.SetVector("B", new Vector4(this.blurSpread * 835f / num, 179f, 1012f, 1044f));
						renderTexture2 = RenderTexture.GetTemporary(width / 5, height / 4, 0, JONJODLFAEN.format);
						Graphics.Blit(temporary, renderTexture2, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				this.MHCHGDHILDH.SetFloat("_Downsample", 1926f / (384f - this.intensity) - 1814f);
				this.MHCHGDHILDH.SetFloat("_BlurParams", 1212f / (740f - this.blur) - 613f);
				this.MHCHGDHILDH.SetTexture("_Refraction", renderTexture2);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.MHCHGDHILDH, 0);
			}
			this.ICLLNJKOPJL.SetFloat("MotorbikeHeadstand", this.chromaticAberration);
			this.ICLLNJKOPJL.SetFloat("<color='#001040'>", this.axialAberration);
			this.ICLLNJKOPJL.SetVector("IdleButtonPress", new Vector2(-this.blurDistance, this.blurDistance));
			this.ICLLNJKOPJL.SetFloat("BowInstant", 1110f / Mathf.Max(Mathf.Epsilon, this.luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Clamp;
			}
			else
			{
				JONJODLFAEN.wrapMode = TextureWrapMode.Clamp;
			}
			Graphics.Blit(flag ? renderTexture : JONJODLFAEN, OKIIDHIJBEA, this.ICLLNJKOPJL, (this.mode == VignetteAndChromaticAberration.LIOJIBAMBAN.Advanced) ? 4 : 0);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}

		// Token: 0x0600BCE8 RID: 48360 RVA: 0x00556288 File Offset: 0x00554488
		public virtual bool IAIMIKBMJOM()
		{
			base.AHFDGALLKFC(false);
			this.MHCHGDHILDH = base.BAPJBHPEDIF(this.vignetteShader, this.MHCHGDHILDH);
			this.EOPJAABNBBI = base.ALJPMGLOIEG(this.separableBlurShader, this.EOPJAABNBBI);
			this.ICLLNJKOPJL = base.BAPJBHPEDIF(this.chromAberrationShader, this.ICLLNJKOPJL);
			if (!this.PPGOAMIHMBG)
			{
				base.OAEAMDHOKKM();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BCE9 RID: 48361 RVA: 0x005562FC File Offset: 0x005544FC
		private void BMJCNICLDEK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			bool flag = Mathf.Abs(this.blur) <= 653f && Mathf.Abs(this.intensity) > 1125f;
			float num = 1617f * (float)width / (1538f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				if (Mathf.Abs(this.blur) > 1242f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 5, height / 2, 0, JONJODLFAEN.format);
					Graphics.Blit(JONJODLFAEN, renderTexture2, this.ICLLNJKOPJL, 1);
					for (int i = 1; i < 3; i += 0)
					{
						this.EOPJAABNBBI.SetVector("*********read ", new Vector4(1622f, this.blurSpread * 1942f, 1579f, 1076f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 3, height / 2, 0, JONJODLFAEN.format);
						Graphics.Blit(renderTexture2, temporary, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(renderTexture2);
						this.EOPJAABNBBI.SetVector("ObscuredString vs string, ", new Vector4(this.blurSpread * 394f / num, 800f, 1418f, 774f));
						renderTexture2 = RenderTexture.GetTemporary(width / 3, height / 5, 1, JONJODLFAEN.format);
						Graphics.Blit(temporary, renderTexture2, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				this.MHCHGDHILDH.SetFloat("choldposx", 218f / (137f - this.intensity) - 1746f);
				this.MHCHGDHILDH.SetFloat("USE_CORNER_DETECTION", 516f / (71f - this.blur) - 1021f);
				this.MHCHGDHILDH.SetTexture("\n", renderTexture2);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.MHCHGDHILDH, 0);
			}
			this.ICLLNJKOPJL.SetFloat("BowFire", this.chromaticAberration);
			this.ICLLNJKOPJL.SetFloat("Finished", this.axialAberration);
			this.ICLLNJKOPJL.SetVector("ObscuredPrefs vs PlayerPrefs, ", new Vector2(-this.blurDistance, this.blurDistance));
			this.ICLLNJKOPJL.SetFloat("KneesIdle", 1805f / Mathf.Max(Mathf.Epsilon, this.luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Clamp;
			}
			else
			{
				JONJODLFAEN.wrapMode = TextureWrapMode.Repeat;
			}
			Graphics.Blit(flag ? renderTexture : JONJODLFAEN, OKIIDHIJBEA, this.ICLLNJKOPJL, (this.mode == VignetteAndChromaticAberration.LIOJIBAMBAN.Advanced) ? 3 : 0);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}

		// Token: 0x0600BCEA RID: 48362 RVA: 0x005565B0 File Offset: 0x005547B0
		public virtual bool HMHEIPAGPHD()
		{
			base.DAOKCAOFIGE(false);
			this.MHCHGDHILDH = base.JBHLGBPJFEL(this.vignetteShader, this.MHCHGDHILDH);
			this.EOPJAABNBBI = base.DJFOEIJIMJB(this.separableBlurShader, this.EOPJAABNBBI);
			this.ICLLNJKOPJL = base.BOOFEOGDMBI(this.chromAberrationShader, this.ICLLNJKOPJL);
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BCEB RID: 48363 RVA: 0x00556624 File Offset: 0x00554824
		public virtual bool ENMKIJNFBFF()
		{
			base.DAOKCAOFIGE(false);
			this.MHCHGDHILDH = base.JBHLGBPJFEL(this.vignetteShader, this.MHCHGDHILDH);
			this.EOPJAABNBBI = base.DJFOEIJIMJB(this.separableBlurShader, this.EOPJAABNBBI);
			this.ICLLNJKOPJL = base.IIIIADNBONI(this.chromAberrationShader, this.ICLLNJKOPJL);
			if (!this.PPGOAMIHMBG)
			{
				base.FDBKFKGCGEG();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BCEC RID: 48364 RVA: 0x00556698 File Offset: 0x00554898
		private void LEICKKKLDAD(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.DLENDGGGMBJ())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			bool flag = Mathf.Abs(this.blur) > 1656f || Mathf.Abs(this.intensity) > 131f;
			float num = 1514f * (float)width / (896f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				if (Mathf.Abs(this.blur) > 260f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 8, height / 8, 1, JONJODLFAEN.format);
					Graphics.Blit(JONJODLFAEN, renderTexture2, this.ICLLNJKOPJL, 1);
					for (int i = 0; i < 4; i++)
					{
						this.EOPJAABNBBI.SetVector("__MirrorDeep", new Vector4(1274f, this.blurSpread * 1401f, 895f, 1794f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 6, height / 1, 1, JONJODLFAEN.format);
						Graphics.Blit(renderTexture2, temporary, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(renderTexture2);
						this.EOPJAABNBBI.SetVector("man_death.ogg", new Vector4(this.blurSpread * 1718f / num, 1433f, 1820f, 1619f));
						renderTexture2 = RenderTexture.GetTemporary(width / 6, height / 5, 0, JONJODLFAEN.format);
						Graphics.Blit(temporary, renderTexture2, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				this.MHCHGDHILDH.SetFloat("selectedTask", 1806f / (312f - this.intensity) - 844f);
				this.MHCHGDHILDH.SetFloat("_ThirdTex", 561f / (211f - this.blur) - 1183f);
				this.MHCHGDHILDH.SetTexture("", renderTexture2);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.MHCHGDHILDH, 0);
			}
			this.ICLLNJKOPJL.SetFloat("", this.chromaticAberration);
			this.ICLLNJKOPJL.SetFloat("lifeBar", this.axialAberration);
			this.ICLLNJKOPJL.SetVector("BAG", new Vector2(-this.blurDistance, this.blurDistance));
			this.ICLLNJKOPJL.SetFloat("> ", 556f / Mathf.Max(Mathf.Epsilon, this.luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Clamp;
			}
			else
			{
				JONJODLFAEN.wrapMode = TextureWrapMode.Clamp;
			}
			Graphics.Blit(flag ? renderTexture : JONJODLFAEN, OKIIDHIJBEA, this.ICLLNJKOPJL, (this.mode == VignetteAndChromaticAberration.LIOJIBAMBAN.Simple) ? 6 : 0);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}

		// Token: 0x0600BCED RID: 48365 RVA: 0x0055694C File Offset: 0x00554B4C
		public virtual bool KHEPGGOEGIA()
		{
			base.LGANGHEOPOG(false);
			this.MHCHGDHILDH = base.BAPJBHPEDIF(this.vignetteShader, this.MHCHGDHILDH);
			this.EOPJAABNBBI = base.JBHLGBPJFEL(this.separableBlurShader, this.EOPJAABNBBI);
			this.ICLLNJKOPJL = base.IIIIADNBONI(this.chromAberrationShader, this.ICLLNJKOPJL);
			if (!this.PPGOAMIHMBG)
			{
				base.NAIBIABADFB();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BCEE RID: 48366 RVA: 0x005569C0 File Offset: 0x00554BC0
		private void GDGPNFLCNEG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.IGJKBOMMMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			bool flag = Mathf.Abs(this.blur) <= 559f && Mathf.Abs(this.intensity) > 1816f;
			float num = 1299f * (float)width / (77f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				if (Mathf.Abs(this.blur) > 1760f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 7, height / 6, 0, JONJODLFAEN.format);
					Graphics.Blit(JONJODLFAEN, renderTexture2, this.ICLLNJKOPJL, 1);
					for (int i = 0; i < 8; i += 0)
					{
						this.EOPJAABNBBI.SetVector("", new Vector4(363f, this.blurSpread * 1329f, 557f, 1416f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 1, height / 7, 1, JONJODLFAEN.format);
						Graphics.Blit(renderTexture2, temporary, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(renderTexture2);
						this.EOPJAABNBBI.SetVector("", new Vector4(this.blurSpread * 264f / num, 684f, 1568f, 418f));
						renderTexture2 = RenderTexture.GetTemporary(width / 2, height / 2, 0, JONJODLFAEN.format);
						Graphics.Blit(temporary, renderTexture2, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				this.MHCHGDHILDH.SetFloat("IdleTurns", 1424f / (111f - this.intensity) - 1097f);
				this.MHCHGDHILDH.SetFloat("wpn_rod4", 1720f / (1143f - this.blur) - 575f);
				this.MHCHGDHILDH.SetTexture("Citates.xml", renderTexture2);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.MHCHGDHILDH, 1);
			}
			this.ICLLNJKOPJL.SetFloat("X", this.chromaticAberration);
			this.ICLLNJKOPJL.SetFloat("textAsset is NULL! Path: Cells", this.axialAberration);
			this.ICLLNJKOPJL.SetVector("invn_rec20", new Vector2(-this.blurDistance, this.blurDistance));
			this.ICLLNJKOPJL.SetFloat("__MirrorReflection", 1994f / Mathf.Max(Mathf.Epsilon, this.luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Repeat;
			}
			else
			{
				JONJODLFAEN.wrapMode = TextureWrapMode.Repeat;
			}
			Graphics.Blit(flag ? renderTexture : JONJODLFAEN, OKIIDHIJBEA, this.ICLLNJKOPJL, (this.mode == VignetteAndChromaticAberration.LIOJIBAMBAN.Simple) ? 1 : 1);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}

		// Token: 0x0600BCEF RID: 48367 RVA: 0x00556C74 File Offset: 0x00554E74
		private void LGKJKHBJFCP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NHEEDPALBFN())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			bool flag = Mathf.Abs(this.blur) <= 1478f && Mathf.Abs(this.intensity) > 1521f;
			float num = 1832f * (float)width / (1811f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				if (Mathf.Abs(this.blur) > 1815f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 2, height / 3, 1, JONJODLFAEN.format);
					Graphics.Blit(JONJODLFAEN, renderTexture2, this.ICLLNJKOPJL, 1);
					for (int i = 0; i < 6; i += 0)
					{
						this.EOPJAABNBBI.SetVector("Horizontal", new Vector4(1926f, this.blurSpread * 1173f, 719f, 1355f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 6, height / 0, 1, JONJODLFAEN.format);
						Graphics.Blit(renderTexture2, temporary, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(renderTexture2);
						this.EOPJAABNBBI.SetVector(".png", new Vector4(this.blurSpread * 1835f / num, 371f, 1392f, 96f));
						renderTexture2 = RenderTexture.GetTemporary(width / 0, height / 0, 0, JONJODLFAEN.format);
						Graphics.Blit(temporary, renderTexture2, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				this.MHCHGDHILDH.SetFloat("wpn_line3", 1284f / (1585f - this.intensity) - 167f);
				this.MHCHGDHILDH.SetFloat("Mouse X", 310f / (1493f - this.blur) - 1151f);
				this.MHCHGDHILDH.SetTexture("", renderTexture2);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.MHCHGDHILDH, 0);
			}
			this.ICLLNJKOPJL.SetFloat("cht_msg2", this.chromaticAberration);
			this.ICLLNJKOPJL.SetFloat("cntx_wpnauk", this.axialAberration);
			this.ICLLNJKOPJL.SetVector("Walk Dehydrated", new Vector2(-this.blurDistance, this.blurDistance));
			this.ICLLNJKOPJL.SetFloat(",", 315f / Mathf.Max(Mathf.Epsilon, this.luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Repeat;
			}
			else
			{
				JONJODLFAEN.wrapMode = TextureWrapMode.Clamp;
			}
			Graphics.Blit(flag ? renderTexture : JONJODLFAEN, OKIIDHIJBEA, this.ICLLNJKOPJL, (this.mode == VignetteAndChromaticAberration.LIOJIBAMBAN.Simple) ? 7 : 0);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}

		// Token: 0x0600BCF0 RID: 48368 RVA: 0x00556F28 File Offset: 0x00555128
		public virtual bool POKDAEAADAC()
		{
			base.EBEBJHLBBBI(false);
			this.MHCHGDHILDH = base.OOAOHFFDMJP(this.vignetteShader, this.MHCHGDHILDH);
			this.EOPJAABNBBI = base.BOOFEOGDMBI(this.separableBlurShader, this.EOPJAABNBBI);
			this.ICLLNJKOPJL = base.JBHLGBPJFEL(this.chromAberrationShader, this.ICLLNJKOPJL);
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BCF1 RID: 48369 RVA: 0x00556F9C File Offset: 0x0055519C
		private void FEAGGDCEGFE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.DLENDGGGMBJ())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			bool flag = Mathf.Abs(this.blur) > 503f || Mathf.Abs(this.intensity) > 659f;
			float num = 461f * (float)width / (1901f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				if (Mathf.Abs(this.blur) > 325f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 8, height / 3, 0, JONJODLFAEN.format);
					Graphics.Blit(JONJODLFAEN, renderTexture2, this.ICLLNJKOPJL, 1);
					for (int i = 0; i < 3; i += 0)
					{
						this.EOPJAABNBBI.SetVector(" \"{0}\"", new Vector4(1766f, this.blurSpread * 543f, 416f, 1230f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 7, height / 0, 1, JONJODLFAEN.format);
						Graphics.Blit(renderTexture2, temporary, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(renderTexture2);
						this.EOPJAABNBBI.SetVector("cht_delfrendmsg", new Vector4(this.blurSpread * 1610f / num, 1407f, 1779f, 905f));
						renderTexture2 = RenderTexture.GetTemporary(width / 5, height / 6, 0, JONJODLFAEN.format);
						Graphics.Blit(temporary, renderTexture2, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				this.MHCHGDHILDH.SetFloat("_NoisePerChannel", 257f / (575f - this.intensity) - 1932f);
				this.MHCHGDHILDH.SetFloat("\n", 914f / (1366f - this.blur) - 1428f);
				this.MHCHGDHILDH.SetTexture("offsets", renderTexture2);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.MHCHGDHILDH, 0);
			}
			this.ICLLNJKOPJL.SetFloat("cht_msg25", this.chromaticAberration);
			this.ICLLNJKOPJL.SetFloat("_BlurVector", this.axialAberration);
			this.ICLLNJKOPJL.SetVector("error", new Vector2(-this.blurDistance, this.blurDistance));
			this.ICLLNJKOPJL.SetFloat("", 1206f / Mathf.Max(Mathf.Epsilon, this.luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Repeat;
			}
			else
			{
				JONJODLFAEN.wrapMode = TextureWrapMode.Repeat;
			}
			Graphics.Blit(flag ? renderTexture : JONJODLFAEN, OKIIDHIJBEA, this.ICLLNJKOPJL, (this.mode == VignetteAndChromaticAberration.LIOJIBAMBAN.Advanced) ? 3 : 0);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}

		// Token: 0x0600BCF2 RID: 48370 RVA: 0x00557250 File Offset: 0x00555450
		public virtual bool OJFBHAHHDNC()
		{
			base.AHFDGALLKFC(true);
			this.MHCHGDHILDH = base.JBHLGBPJFEL(this.vignetteShader, this.MHCHGDHILDH);
			this.EOPJAABNBBI = base.DJFOEIJIMJB(this.separableBlurShader, this.EOPJAABNBBI);
			this.ICLLNJKOPJL = base.DJFOEIJIMJB(this.chromAberrationShader, this.ICLLNJKOPJL);
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BCF3 RID: 48371 RVA: 0x005572C4 File Offset: 0x005554C4
		public override bool PKHJBLJFIBF()
		{
			base.CGEGCOKMPHN(false);
			this.MHCHGDHILDH = base.BOOFEOGDMBI(this.vignetteShader, this.MHCHGDHILDH);
			this.EOPJAABNBBI = base.DJFOEIJIMJB(this.separableBlurShader, this.EOPJAABNBBI);
			this.ICLLNJKOPJL = base.BAPJBHPEDIF(this.chromAberrationShader, this.ICLLNJKOPJL);
			if (!this.PPGOAMIHMBG)
			{
				base.LNEHBOJIBAI();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BCF4 RID: 48372 RVA: 0x00557338 File Offset: 0x00555538
		public virtual bool HHCKHLDCKMF()
		{
			base.CBJDCDELBJN(true);
			this.MHCHGDHILDH = base.BOOFEOGDMBI(this.vignetteShader, this.MHCHGDHILDH);
			this.EOPJAABNBBI = base.BOOFEOGDMBI(this.separableBlurShader, this.EOPJAABNBBI);
			this.ICLLNJKOPJL = base.OOAOHFFDMJP(this.chromAberrationShader, this.ICLLNJKOPJL);
			if (!this.PPGOAMIHMBG)
			{
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BCF5 RID: 48373 RVA: 0x005573AC File Offset: 0x005555AC
		public virtual bool NAEJFOJDLCC()
		{
			base.CDBNBLBOLCL(false);
			this.MHCHGDHILDH = base.JBHLGBPJFEL(this.vignetteShader, this.MHCHGDHILDH);
			this.EOPJAABNBBI = base.DJFOEIJIMJB(this.separableBlurShader, this.EOPJAABNBBI);
			this.ICLLNJKOPJL = base.BAPJBHPEDIF(this.chromAberrationShader, this.ICLLNJKOPJL);
			if (!this.PPGOAMIHMBG)
			{
				base.NAIBIABADFB();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BCF6 RID: 48374 RVA: 0x00557420 File Offset: 0x00555620
		public virtual bool JCCFBJBBHBP()
		{
			base.POJDHPJDFEM(true);
			this.MHCHGDHILDH = base.IIIIADNBONI(this.vignetteShader, this.MHCHGDHILDH);
			this.EOPJAABNBBI = base.BAPJBHPEDIF(this.separableBlurShader, this.EOPJAABNBBI);
			this.ICLLNJKOPJL = base.IIIIADNBONI(this.chromAberrationShader, this.ICLLNJKOPJL);
			if (!this.PPGOAMIHMBG)
			{
				base.LNEHBOJIBAI();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BCF7 RID: 48375 RVA: 0x00557494 File Offset: 0x00555694
		public virtual bool DCEJLCLOCJC()
		{
			base.EHGENDOEHLP(false);
			this.MHCHGDHILDH = base.OOAOHFFDMJP(this.vignetteShader, this.MHCHGDHILDH);
			this.EOPJAABNBBI = base.BOOFEOGDMBI(this.separableBlurShader, this.EOPJAABNBBI);
			this.ICLLNJKOPJL = base.JBHLGBPJFEL(this.chromAberrationShader, this.ICLLNJKOPJL);
			if (!this.PPGOAMIHMBG)
			{
				base.LNEHBOJIBAI();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BCF8 RID: 48376 RVA: 0x00557508 File Offset: 0x00555708
		public override bool NIFOFLEPKIB()
		{
			base.EBEBJHLBBBI(true);
			this.MHCHGDHILDH = base.JBHLGBPJFEL(this.vignetteShader, this.MHCHGDHILDH);
			this.EOPJAABNBBI = base.DJFOEIJIMJB(this.separableBlurShader, this.EOPJAABNBBI);
			this.ICLLNJKOPJL = base.ALJPMGLOIEG(this.chromAberrationShader, this.ICLLNJKOPJL);
			if (!this.PPGOAMIHMBG)
			{
				base.OAEAMDHOKKM();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BCF9 RID: 48377 RVA: 0x0055757C File Offset: 0x0055577C
		public virtual bool APNCPMNHKOG()
		{
			base.BGIALJEIEFO(true);
			this.MHCHGDHILDH = base.JBHLGBPJFEL(this.vignetteShader, this.MHCHGDHILDH);
			this.EOPJAABNBBI = base.JBHLGBPJFEL(this.separableBlurShader, this.EOPJAABNBBI);
			this.ICLLNJKOPJL = base.JBHLGBPJFEL(this.chromAberrationShader, this.ICLLNJKOPJL);
			if (!this.PPGOAMIHMBG)
			{
				base.LNEHBOJIBAI();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BCFA RID: 48378 RVA: 0x005575F0 File Offset: 0x005557F0
		private void PMHDOMMHBPG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			bool flag = Mathf.Abs(this.blur) <= 1301f && Mathf.Abs(this.intensity) > 1555f;
			float num = 1507f * (float)width / (1416f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				if (Mathf.Abs(this.blur) > 1918f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 4, height / 5, 1, JONJODLFAEN.format);
					Graphics.Blit(JONJODLFAEN, renderTexture2, this.ICLLNJKOPJL, 1);
					for (int i = 1; i < 0; i++)
					{
						this.EOPJAABNBBI.SetVector("Hidden/DepthOfField/DepthOfField", new Vector4(1049f, this.blurSpread * 1802f, 32f, 1845f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 8, height / 7, 0, JONJODLFAEN.format);
						Graphics.Blit(renderTexture2, temporary, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(renderTexture2);
						this.EOPJAABNBBI.SetVector("FacePalm", new Vector4(this.blurSpread * 573f / num, 432f, 743f, 322f));
						renderTexture2 = RenderTexture.GetTemporary(width / 2, height / 0, 1, JONJODLFAEN.format);
						Graphics.Blit(temporary, renderTexture2, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				this.MHCHGDHILDH.SetFloat("DISTORT", 1610f / (1839f - this.intensity) - 1662f);
				this.MHCHGDHILDH.SetFloat("===== ObscuredVector3Test =====\n", 1873f / (968f - this.blur) - 712f);
				this.MHCHGDHILDH.SetTexture("", renderTexture2);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.MHCHGDHILDH, 0);
			}
			this.ICLLNJKOPJL.SetFloat("/Sound/Music/MusicList.xml", this.chromaticAberration);
			this.ICLLNJKOPJL.SetFloat("_DepthExponent", this.axialAberration);
			this.ICLLNJKOPJL.SetVector("Invalid ObscuredVector3 index!", new Vector2(-this.blurDistance, this.blurDistance));
			this.ICLLNJKOPJL.SetFloat("TOD_kBetaMie", 1074f / Mathf.Max(Mathf.Epsilon, this.luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Repeat;
			}
			else
			{
				JONJODLFAEN.wrapMode = TextureWrapMode.Repeat;
			}
			Graphics.Blit(flag ? renderTexture : JONJODLFAEN, OKIIDHIJBEA, this.ICLLNJKOPJL, (this.mode == VignetteAndChromaticAberration.LIOJIBAMBAN.Advanced) ? 8 : 1);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}

		// Token: 0x0600BCFB RID: 48379 RVA: 0x005578A4 File Offset: 0x00555AA4
		private void PHFJDPLOKJK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			bool flag = Mathf.Abs(this.blur) > 932f || Mathf.Abs(this.intensity) > 1111f;
			float num = 25f * (float)width / (1785f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				if (Mathf.Abs(this.blur) > 1072f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 2, height / 5, 0, JONJODLFAEN.format);
					Graphics.Blit(JONJODLFAEN, renderTexture2, this.ICLLNJKOPJL, 1);
					for (int i = 1; i < 0; i++)
					{
						this.EOPJAABNBBI.SetVector("_OcclusionColor", new Vector4(1045f, this.blurSpread * 1356f, 520f, 1384f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 0, height / 4, 1, JONJODLFAEN.format);
						Graphics.Blit(renderTexture2, temporary, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(renderTexture2);
						this.EOPJAABNBBI.SetVector("auk_pbuykey", new Vector4(this.blurSpread * 984f / num, 1146f, 1382f, 165f));
						renderTexture2 = RenderTexture.GetTemporary(width / 2, height / 0, 1, JONJODLFAEN.format);
						Graphics.Blit(temporary, renderTexture2, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				this.MHCHGDHILDH.SetFloat("USE_DEPTH", 1039f / (1363f - this.intensity) - 1649f);
				this.MHCHGDHILDH.SetFloat("[^а-яА-Я\\d_]", 925f / (282f - this.blur) - 1105f);
				this.MHCHGDHILDH.SetTexture("IdleDie", renderTexture2);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.MHCHGDHILDH, 0);
			}
			this.ICLLNJKOPJL.SetFloat("+ EXP for FISH=", this.chromaticAberration);
			this.ICLLNJKOPJL.SetFloat("Handstand", this.axialAberration);
			this.ICLLNJKOPJL.SetVector("Flap_04.wav", new Vector2(-this.blurDistance, this.blurDistance));
			this.ICLLNJKOPJL.SetFloat("\"{0}\"", 375f / Mathf.Max(Mathf.Epsilon, this.luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Repeat;
			}
			else
			{
				JONJODLFAEN.wrapMode = TextureWrapMode.Repeat;
			}
			Graphics.Blit(flag ? renderTexture : JONJODLFAEN, OKIIDHIJBEA, this.ICLLNJKOPJL, (this.mode == VignetteAndChromaticAberration.LIOJIBAMBAN.Simple) ? 5 : 0);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}

		// Token: 0x0600BCFC RID: 48380 RVA: 0x00557B58 File Offset: 0x00555D58
		public virtual bool NFFLLNPGHNC()
		{
			base.DAOKCAOFIGE(true);
			this.MHCHGDHILDH = base.BAPJBHPEDIF(this.vignetteShader, this.MHCHGDHILDH);
			this.EOPJAABNBBI = base.DJFOEIJIMJB(this.separableBlurShader, this.EOPJAABNBBI);
			this.ICLLNJKOPJL = base.BAPJBHPEDIF(this.chromAberrationShader, this.ICLLNJKOPJL);
			if (!this.PPGOAMIHMBG)
			{
				base.LNEHBOJIBAI();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BCFD RID: 48381 RVA: 0x00557BCC File Offset: 0x00555DCC
		public virtual bool CKLDIKPLCAO()
		{
			base.PKDIKFGAJKM(false);
			this.MHCHGDHILDH = base.BAPJBHPEDIF(this.vignetteShader, this.MHCHGDHILDH);
			this.EOPJAABNBBI = base.JBHLGBPJFEL(this.separableBlurShader, this.EOPJAABNBBI);
			this.ICLLNJKOPJL = base.OOAOHFFDMJP(this.chromAberrationShader, this.ICLLNJKOPJL);
			if (!this.PPGOAMIHMBG)
			{
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BCFE RID: 48382 RVA: 0x00557C40 File Offset: 0x00555E40
		private void ENEONPFCPMP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			bool flag = Mathf.Abs(this.blur) > 667f || Mathf.Abs(this.intensity) > 168f;
			float num = 1603f * (float)width / (1934f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				if (Mathf.Abs(this.blur) > 1100f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 1, height / 7, 0, JONJODLFAEN.format);
					Graphics.Blit(JONJODLFAEN, renderTexture2, this.ICLLNJKOPJL, 1);
					for (int i = 1; i < 6; i++)
					{
						this.EOPJAABNBBI.SetVector("Finished", new Vector4(555f, this.blurSpread * 563f, 1360f, 820f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 6, height / 7, 0, JONJODLFAEN.format);
						Graphics.Blit(renderTexture2, temporary, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(renderTexture2);
						this.EOPJAABNBBI.SetVector("1HandSwordJabCombo", new Vector4(this.blurSpread * 630f / num, 119f, 263f, 1800f));
						renderTexture2 = RenderTexture.GetTemporary(width / 8, height / 7, 0, JONJODLFAEN.format);
						Graphics.Blit(temporary, renderTexture2, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				this.MHCHGDHILDH.SetFloat("_CosPower", 149f / (605f - this.intensity) - 440f);
				this.MHCHGDHILDH.SetFloat("HitWeight", 1646f / (1706f - this.blur) - 1608f);
				this.MHCHGDHILDH.SetTexture("wpn_rod2", renderTexture2);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.MHCHGDHILDH, 1);
			}
			this.ICLLNJKOPJL.SetFloat("{z}", this.chromaticAberration);
			this.ICLLNJKOPJL.SetFloat("{not_found}", this.axialAberration);
			this.ICLLNJKOPJL.SetVector("post_msg3", new Vector2(-this.blurDistance, this.blurDistance));
			this.ICLLNJKOPJL.SetFloat("demoDouble", 1301f / Mathf.Max(Mathf.Epsilon, this.luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Repeat;
			}
			else
			{
				JONJODLFAEN.wrapMode = TextureWrapMode.Clamp;
			}
			Graphics.Blit(flag ? renderTexture : JONJODLFAEN, OKIIDHIJBEA, this.ICLLNJKOPJL, (this.mode == VignetteAndChromaticAberration.LIOJIBAMBAN.Simple) ? 0 : 0);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}

		// Token: 0x0600BCFF RID: 48383 RVA: 0x00557EF4 File Offset: 0x005560F4
		private void NHDCFLGBCNE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			bool flag = Mathf.Abs(this.blur) > 942f || Mathf.Abs(this.intensity) > 577f;
			float num = 883f * (float)width / (1670f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				if (Mathf.Abs(this.blur) > 1814f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 0, height / 5, 1, JONJODLFAEN.format);
					Graphics.Blit(JONJODLFAEN, renderTexture2, this.ICLLNJKOPJL, 0);
					for (int i = 1; i < 5; i += 0)
					{
						this.EOPJAABNBBI.SetVector("{0,-28}{1,-28}{2,-28}{3,-28}{4,-28}{5,-28}{6,-28}", new Vector4(1214f, this.blurSpread * 1790f, 1090f, 618f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 8, height / 8, 1, JONJODLFAEN.format);
						Graphics.Blit(renderTexture2, temporary, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(renderTexture2);
						this.EOPJAABNBBI.SetVector("Lives count: ", new Vector4(this.blurSpread * 1643f / num, 335f, 1075f, 254f));
						renderTexture2 = RenderTexture.GetTemporary(width / 4, height / 3, 1, JONJODLFAEN.format);
						Graphics.Blit(temporary, renderTexture2, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				this.MHCHGDHILDH.SetFloat("_FogColor2", 246f / (1312f - this.intensity) - 1016f);
				this.MHCHGDHILDH.SetFloat("bool: ", 1387f / (1317f - this.blur) - 276f);
				this.MHCHGDHILDH.SetTexture("===== ObscuredVector3Test =====\n", renderTexture2);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.MHCHGDHILDH, 0);
			}
			this.ICLLNJKOPJL.SetFloat("Hidden/Image Effects/Cinematic/AmbientOcclusion", this.chromaticAberration);
			this.ICLLNJKOPJL.SetFloat("1HandSwordChargeUp", this.axialAberration);
			this.ICLLNJKOPJL.SetVector("", new Vector2(-this.blurDistance, this.blurDistance));
			this.ICLLNJKOPJL.SetFloat("KatanaVerticalSwing", 201f / Mathf.Max(Mathf.Epsilon, this.luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Repeat;
			}
			else
			{
				JONJODLFAEN.wrapMode = TextureWrapMode.Repeat;
			}
			Graphics.Blit(flag ? renderTexture : JONJODLFAEN, OKIIDHIJBEA, this.ICLLNJKOPJL, (this.mode == VignetteAndChromaticAberration.LIOJIBAMBAN.Simple) ? 1 : 0);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}

		// Token: 0x0600BD00 RID: 48384 RVA: 0x005581A8 File Offset: 0x005563A8
		public virtual bool BAPNBLIHPLB()
		{
			base.CDBNBLBOLCL(true);
			this.MHCHGDHILDH = base.ALJPMGLOIEG(this.vignetteShader, this.MHCHGDHILDH);
			this.EOPJAABNBBI = base.OOAOHFFDMJP(this.separableBlurShader, this.EOPJAABNBBI);
			this.ICLLNJKOPJL = base.DJFOEIJIMJB(this.chromAberrationShader, this.ICLLNJKOPJL);
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BD01 RID: 48385 RVA: 0x0055821C File Offset: 0x0055641C
		private void EBLFIONBNIO(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			bool flag = Mathf.Abs(this.blur) <= 886f && Mathf.Abs(this.intensity) > 1814f;
			float num = 950f * (float)width / (1740f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				if (Mathf.Abs(this.blur) > 254f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 7, height / 5, 0, JONJODLFAEN.format);
					Graphics.Blit(JONJODLFAEN, renderTexture2, this.ICLLNJKOPJL, 1);
					for (int i = 0; i < 4; i += 0)
					{
						this.EOPJAABNBBI.SetVector("ScubaSwim", new Vector4(1531f, this.blurSpread * 1039f, 470f, 1259f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 0, height / 7, 0, JONJODLFAEN.format);
						Graphics.Blit(renderTexture2, temporary, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(renderTexture2);
						this.EOPJAABNBBI.SetVector("", new Vector4(this.blurSpread * 138f / num, 1033f, 309f, 1218f));
						renderTexture2 = RenderTexture.GetTemporary(width / 8, height / 0, 1, JONJODLFAEN.format);
						Graphics.Blit(temporary, renderTexture2, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				this.MHCHGDHILDH.SetFloat("ArmFlex3", 1769f / (486f - this.intensity) - 1418f);
				this.MHCHGDHILDH.SetFloat("buykey", 189f / (236f - this.blur) - 150f);
				this.MHCHGDHILDH.SetTexture("{0}\n{1}", renderTexture2);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.MHCHGDHILDH, 1);
			}
			this.ICLLNJKOPJL.SetFloat("gi_um_lim", this.chromaticAberration);
			this.ICLLNJKOPJL.SetFloat("noworkpoints", this.axialAberration);
			this.ICLLNJKOPJL.SetVector("error.wav", new Vector2(-this.blurDistance, this.blurDistance));
			this.ICLLNJKOPJL.SetFloat("LookAT Point", 1702f / Mathf.Max(Mathf.Epsilon, this.luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Repeat;
			}
			else
			{
				JONJODLFAEN.wrapMode = TextureWrapMode.Clamp;
			}
			Graphics.Blit(flag ? renderTexture : JONJODLFAEN, OKIIDHIJBEA, this.ICLLNJKOPJL, (this.mode == VignetteAndChromaticAberration.LIOJIBAMBAN.Advanced) ? 6 : 1);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}

		// Token: 0x0600BD02 RID: 48386 RVA: 0x005584D0 File Offset: 0x005566D0
		public virtual bool CFODPFPIHIF()
		{
			base.MGHNCKDCFGL(true);
			this.MHCHGDHILDH = base.BAPJBHPEDIF(this.vignetteShader, this.MHCHGDHILDH);
			this.EOPJAABNBBI = base.DJFOEIJIMJB(this.separableBlurShader, this.EOPJAABNBBI);
			this.ICLLNJKOPJL = base.JBHLGBPJFEL(this.chromAberrationShader, this.ICLLNJKOPJL);
			if (!this.PPGOAMIHMBG)
			{
				base.INOGPLDHPGC();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BD03 RID: 48387 RVA: 0x00558544 File Offset: 0x00556744
		private void MAIGIEENOEJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			bool flag = Mathf.Abs(this.blur) > 722f || Mathf.Abs(this.intensity) > 293f;
			float num = 534f * (float)width / (294f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				if (Mathf.Abs(this.blur) > 714f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 3, height / 6, 1, JONJODLFAEN.format);
					Graphics.Blit(JONJODLFAEN, renderTexture2, this.ICLLNJKOPJL, 1);
					for (int i = 1; i < 0; i++)
					{
						this.EOPJAABNBBI.SetVector(" ", new Vector4(367f, this.blurSpread * 515f, 532f, 1619f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 7, height / 7, 1, JONJODLFAEN.format);
						Graphics.Blit(renderTexture2, temporary, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(renderTexture2);
						this.EOPJAABNBBI.SetVector("#ff80ff", new Vector4(this.blurSpread * 1157f / num, 268f, 1971f, 37f));
						renderTexture2 = RenderTexture.GetTemporary(width / 5, height / 3, 1, JONJODLFAEN.format);
						Graphics.Blit(temporary, renderTexture2, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				this.MHCHGDHILDH.SetFloat("1 Hand Sword Jab ready strafe left", 1066f / (101f - this.intensity) - 37f);
				this.MHCHGDHILDH.SetFloat("_Gain", 1130f / (354f - this.blur) - 563f);
				this.MHCHGDHILDH.SetTexture("KatanaReady", renderTexture2);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.MHCHGDHILDH, 0);
			}
			this.ICLLNJKOPJL.SetFloat("SoccerSprint", this.chromaticAberration);
			this.ICLLNJKOPJL.SetFloat("Mid", this.axialAberration);
			this.ICLLNJKOPJL.SetVector("http://www.root-motion.com/finalikdox/html/page10.html", new Vector2(-this.blurDistance, this.blurDistance));
			this.ICLLNJKOPJL.SetFloat("Jump", 1452f / Mathf.Max(Mathf.Epsilon, this.luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Clamp;
			}
			else
			{
				JONJODLFAEN.wrapMode = TextureWrapMode.Clamp;
			}
			Graphics.Blit(flag ? renderTexture : JONJODLFAEN, OKIIDHIJBEA, this.ICLLNJKOPJL, (this.mode == VignetteAndChromaticAberration.LIOJIBAMBAN.Advanced) ? 8 : 1);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}

		// Token: 0x0600BD04 RID: 48388 RVA: 0x005587F8 File Offset: 0x005569F8
		private void IBILMNLCCJJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			bool flag = Mathf.Abs(this.blur) <= 1877f && Mathf.Abs(this.intensity) > 1185f;
			float num = 983f * (float)width / (87f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				if (Mathf.Abs(this.blur) > 1193f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 0, height / 8, 1, JONJODLFAEN.format);
					Graphics.Blit(JONJODLFAEN, renderTexture2, this.ICLLNJKOPJL, 1);
					for (int i = 0; i < 4; i += 0)
					{
						this.EOPJAABNBBI.SetVector("#02C85F", new Vector4(1064f, this.blurSpread * 1132f, 1864f, 1174f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 3, height / 0, 0, JONJODLFAEN.format);
						Graphics.Blit(renderTexture2, temporary, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(renderTexture2);
						this.EOPJAABNBBI.SetVector("8192", new Vector4(this.blurSpread * 1669f / num, 238f, 21f, 391f));
						renderTexture2 = RenderTexture.GetTemporary(width / 3, height / 8, 1, JONJODLFAEN.format);
						Graphics.Blit(temporary, renderTexture2, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				this.MHCHGDHILDH.SetFloat("CraftProf.xml", 675f / (1336f - this.intensity) - 750f);
				this.MHCHGDHILDH.SetFloat("LH", 1527f / (1172f - this.blur) - 1540f);
				this.MHCHGDHILDH.SetTexture(" locid=", renderTexture2);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.MHCHGDHILDH, 0);
			}
			this.ICLLNJKOPJL.SetFloat("NprPhysPoint", this.chromaticAberration);
			this.ICLLNJKOPJL.SetFloat("Flashlight", this.axialAberration);
			this.ICLLNJKOPJL.SetVector("crft_cnt", new Vector2(-this.blurDistance, this.blurDistance));
			this.ICLLNJKOPJL.SetFloat("", 661f / Mathf.Max(Mathf.Epsilon, this.luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Repeat;
			}
			else
			{
				JONJODLFAEN.wrapMode = TextureWrapMode.Clamp;
			}
			Graphics.Blit(flag ? renderTexture : JONJODLFAEN, OKIIDHIJBEA, this.ICLLNJKOPJL, (this.mode == VignetteAndChromaticAberration.LIOJIBAMBAN.Simple) ? 5 : 1);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}

		// Token: 0x0600BD05 RID: 48389 RVA: 0x00558AAC File Offset: 0x00556CAC
		private void MIJCMMIJPEE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			bool flag = Mathf.Abs(this.blur) <= 222f && Mathf.Abs(this.intensity) > 1461f;
			float num = 864f * (float)width / (311f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				if (Mathf.Abs(this.blur) > 462f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 8, height / 4, 1, JONJODLFAEN.format);
					Graphics.Blit(JONJODLFAEN, renderTexture2, this.ICLLNJKOPJL, 1);
					for (int i = 1; i < 6; i++)
					{
						this.EOPJAABNBBI.SetVector("3", new Vector4(230f, this.blurSpread * 737f, 767f, 487f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 6, height / 2, 0, JONJODLFAEN.format);
						Graphics.Blit(renderTexture2, temporary, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(renderTexture2);
						this.EOPJAABNBBI.SetVector("Player", new Vector4(this.blurSpread * 558f / num, 846f, 1528f, 1344f));
						renderTexture2 = RenderTexture.GetTemporary(width / 8, height / 2, 0, JONJODLFAEN.format);
						Graphics.Blit(temporary, renderTexture2, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				this.MHCHGDHILDH.SetFloat("ArmFlex4", 811f / (624f - this.intensity) - 1864f);
				this.MHCHGDHILDH.SetFloat("_WrinkleOcclusionMap1", 1948f / (1228f - this.blur) - 625f);
				this.MHCHGDHILDH.SetTexture("", renderTexture2);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.MHCHGDHILDH, 1);
			}
			this.ICLLNJKOPJL.SetFloat("gi_uinf_4", this.chromaticAberration);
			this.ICLLNJKOPJL.SetFloat(" ", this.axialAberration);
			this.ICLLNJKOPJL.SetVector("_Offsets", new Vector2(-this.blurDistance, this.blurDistance));
			this.ICLLNJKOPJL.SetFloat("Anti-Cheat Toolkit Detectors", 249f / Mathf.Max(Mathf.Epsilon, this.luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Repeat;
			}
			else
			{
				JONJODLFAEN.wrapMode = TextureWrapMode.Repeat;
			}
			Graphics.Blit(flag ? renderTexture : JONJODLFAEN, OKIIDHIJBEA, this.ICLLNJKOPJL, (this.mode == VignetteAndChromaticAberration.LIOJIBAMBAN.Simple) ? 0 : 1);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}

		// Token: 0x0600BD06 RID: 48390 RVA: 0x00558D60 File Offset: 0x00556F60
		public virtual bool POCBDMNELOB()
		{
			base.OAAFLHNDKBJ(false);
			this.MHCHGDHILDH = base.OOAOHFFDMJP(this.vignetteShader, this.MHCHGDHILDH);
			this.EOPJAABNBBI = base.ALJPMGLOIEG(this.separableBlurShader, this.EOPJAABNBBI);
			this.ICLLNJKOPJL = base.BAPJBHPEDIF(this.chromAberrationShader, this.ICLLNJKOPJL);
			if (!this.PPGOAMIHMBG)
			{
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BD07 RID: 48391 RVA: 0x00558DD4 File Offset: 0x00556FD4
		public virtual bool EMMFLOCMHOM()
		{
			base.EHGENDOEHLP(false);
			this.MHCHGDHILDH = base.JBHLGBPJFEL(this.vignetteShader, this.MHCHGDHILDH);
			this.EOPJAABNBBI = base.IIIIADNBONI(this.separableBlurShader, this.EOPJAABNBBI);
			this.ICLLNJKOPJL = base.BAPJBHPEDIF(this.chromAberrationShader, this.ICLLNJKOPJL);
			if (!this.PPGOAMIHMBG)
			{
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BD08 RID: 48392 RVA: 0x00558E48 File Offset: 0x00557048
		public override bool GGJKGIHGMGC()
		{
			base.AHFDGALLKFC(true);
			this.MHCHGDHILDH = base.ALJPMGLOIEG(this.vignetteShader, this.MHCHGDHILDH);
			this.EOPJAABNBBI = base.IIIIADNBONI(this.separableBlurShader, this.EOPJAABNBBI);
			this.ICLLNJKOPJL = base.JBHLGBPJFEL(this.chromAberrationShader, this.ICLLNJKOPJL);
			if (!this.PPGOAMIHMBG)
			{
				base.OAEAMDHOKKM();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BD09 RID: 48393 RVA: 0x00558EBC File Offset: 0x005570BC
		public virtual bool CPIFBHFDEFO()
		{
			base.OFKOBOMCECF(false);
			this.MHCHGDHILDH = base.JBHLGBPJFEL(this.vignetteShader, this.MHCHGDHILDH);
			this.EOPJAABNBBI = base.BOOFEOGDMBI(this.separableBlurShader, this.EOPJAABNBBI);
			this.ICLLNJKOPJL = base.BAPJBHPEDIF(this.chromAberrationShader, this.ICLLNJKOPJL);
			if (!this.PPGOAMIHMBG)
			{
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BD0A RID: 48394 RVA: 0x00558F30 File Offset: 0x00557130
		private void CNIBAOINCHB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.IGJKBOMMMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			bool flag = Mathf.Abs(this.blur) <= 516f && Mathf.Abs(this.intensity) > 1147f;
			float num = 960f * (float)width / (1299f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				if (Mathf.Abs(this.blur) > 47f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 2, height / 3, 0, JONJODLFAEN.format);
					Graphics.Blit(JONJODLFAEN, renderTexture2, this.ICLLNJKOPJL, 0);
					for (int i = 1; i < 2; i += 0)
					{
						this.EOPJAABNBBI.SetVector("#FF4040", new Vector4(23f, this.blurSpread * 697f, 359f, 808f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 5, height / 1, 1, JONJODLFAEN.format);
						Graphics.Blit(renderTexture2, temporary, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(renderTexture2);
						this.EOPJAABNBBI.SetVector("MotorbikeLassoRight", new Vector4(this.blurSpread * 1916f / num, 1013f, 1800f, 1499f));
						renderTexture2 = RenderTexture.GetTemporary(width / 3, height / 0, 0, JONJODLFAEN.format);
						Graphics.Blit(temporary, renderTexture2, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				this.MHCHGDHILDH.SetFloat("Level: ", 1076f / (575f - this.intensity) - 1476f);
				this.MHCHGDHILDH.SetFloat("BAG", 1099f / (1031f - this.blur) - 56f);
				this.MHCHGDHILDH.SetTexture("\n", renderTexture2);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.MHCHGDHILDH, 1);
			}
			this.ICLLNJKOPJL.SetFloat("_NAME", this.chromaticAberration);
			this.ICLLNJKOPJL.SetFloat("Curve texture", this.axialAberration);
			this.ICLLNJKOPJL.SetVector("textAsset is NULL! Path: Weapons", new Vector2(-this.blurDistance, this.blurDistance));
			this.ICLLNJKOPJL.SetFloat("isMove", 1167f / Mathf.Max(Mathf.Epsilon, this.luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Clamp;
			}
			else
			{
				JONJODLFAEN.wrapMode = TextureWrapMode.Repeat;
			}
			Graphics.Blit(flag ? renderTexture : JONJODLFAEN, OKIIDHIJBEA, this.ICLLNJKOPJL, (this.mode == VignetteAndChromaticAberration.LIOJIBAMBAN.Simple) ? 8 : 1);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}

		// Token: 0x0600BD0C RID: 48396 RVA: 0x0055923C File Offset: 0x0055743C
		private void EDCBFNNHICN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			bool flag = Mathf.Abs(this.blur) <= 1830f && Mathf.Abs(this.intensity) > 1975f;
			float num = 1271f * (float)width / (1737f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				if (Mathf.Abs(this.blur) > 1119f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 1, height / 7, 1, JONJODLFAEN.format);
					Graphics.Blit(JONJODLFAEN, renderTexture2, this.ICLLNJKOPJL, 0);
					for (int i = 0; i < 0; i++)
					{
						this.EOPJAABNBBI.SetVector("BAG", new Vector4(1423f, this.blurSpread * 682f, 1588f, 336f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 3, height / 2, 0, JONJODLFAEN.format);
						Graphics.Blit(renderTexture2, temporary, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(renderTexture2);
						this.EOPJAABNBBI.SetVector("_PrefilterOffs", new Vector4(this.blurSpread * 599f / num, 1032f, 210f, 1482f));
						renderTexture2 = RenderTexture.GetTemporary(width / 0, height / 3, 0, JONJODLFAEN.format);
						Graphics.Blit(temporary, renderTexture2, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				this.MHCHGDHILDH.SetFloat("", 1254f / (525f - this.intensity) - 1226f);
				this.MHCHGDHILDH.SetFloat("string: ", 1710f / (110f - this.blur) - 194f);
				this.MHCHGDHILDH.SetTexture("Saves protection", renderTexture2);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.MHCHGDHILDH, 1);
			}
			this.ICLLNJKOPJL.SetFloat("Climb Right", this.chromaticAberration);
			this.ICLLNJKOPJL.SetFloat("Smoking1", this.axialAberration);
			this.ICLLNJKOPJL.SetVector("CrawlLocomotion", new Vector2(-this.blurDistance, this.blurDistance));
			this.ICLLNJKOPJL.SetFloat("ArmFlex3", 1867f / Mathf.Max(Mathf.Epsilon, this.luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Repeat;
			}
			else
			{
				JONJODLFAEN.wrapMode = TextureWrapMode.Clamp;
			}
			Graphics.Blit(flag ? renderTexture : JONJODLFAEN, OKIIDHIJBEA, this.ICLLNJKOPJL, (this.mode == VignetteAndChromaticAberration.LIOJIBAMBAN.Advanced) ? 5 : 1);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}

		// Token: 0x0600BD0D RID: 48397 RVA: 0x005594F0 File Offset: 0x005576F0
		private void OnRenderImage(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			bool flag = Mathf.Abs(this.blur) > 0f || Mathf.Abs(this.intensity) > 0f;
			float num = 1f * (float)width / (1f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				if (Mathf.Abs(this.blur) > 0f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 2, height / 2, 0, JONJODLFAEN.format);
					Graphics.Blit(JONJODLFAEN, renderTexture2, this.ICLLNJKOPJL, 0);
					for (int i = 0; i < 2; i++)
					{
						this.EOPJAABNBBI.SetVector("offsets", new Vector4(0f, this.blurSpread * 0.001953125f, 0f, 0f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 2, height / 2, 0, JONJODLFAEN.format);
						Graphics.Blit(renderTexture2, temporary, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(renderTexture2);
						this.EOPJAABNBBI.SetVector("offsets", new Vector4(this.blurSpread * 0.001953125f / num, 0f, 0f, 0f));
						renderTexture2 = RenderTexture.GetTemporary(width / 2, height / 2, 0, JONJODLFAEN.format);
						Graphics.Blit(temporary, renderTexture2, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				this.MHCHGDHILDH.SetFloat("_Intensity", 1f / (1f - this.intensity) - 1f);
				this.MHCHGDHILDH.SetFloat("_Blur", 1f / (1f - this.blur) - 1f);
				this.MHCHGDHILDH.SetTexture("_VignetteTex", renderTexture2);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.MHCHGDHILDH, 0);
			}
			this.ICLLNJKOPJL.SetFloat("_ChromaticAberration", this.chromaticAberration);
			this.ICLLNJKOPJL.SetFloat("_AxialAberration", this.axialAberration);
			this.ICLLNJKOPJL.SetVector("_BlurDistance", new Vector2(-this.blurDistance, this.blurDistance));
			this.ICLLNJKOPJL.SetFloat("_Luminance", 1f / Mathf.Max(Mathf.Epsilon, this.luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Clamp;
			}
			else
			{
				JONJODLFAEN.wrapMode = TextureWrapMode.Clamp;
			}
			Graphics.Blit(flag ? renderTexture : JONJODLFAEN, OKIIDHIJBEA, this.ICLLNJKOPJL, (this.mode == VignetteAndChromaticAberration.LIOJIBAMBAN.Advanced) ? 2 : 1);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}

		// Token: 0x0600BD0E RID: 48398 RVA: 0x005597A4 File Offset: 0x005579A4
		public virtual bool DAOFOENGONN()
		{
			base.EBEBJHLBBBI(false);
			this.MHCHGDHILDH = base.BOOFEOGDMBI(this.vignetteShader, this.MHCHGDHILDH);
			this.EOPJAABNBBI = base.ALJPMGLOIEG(this.separableBlurShader, this.EOPJAABNBBI);
			this.ICLLNJKOPJL = base.BAPJBHPEDIF(this.chromAberrationShader, this.ICLLNJKOPJL);
			if (!this.PPGOAMIHMBG)
			{
				base.LNEHBOJIBAI();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BD0F RID: 48399 RVA: 0x00559818 File Offset: 0x00557A18
		private void HNPNJCMJKKK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			bool flag = Mathf.Abs(this.blur) <= 1358f && Mathf.Abs(this.intensity) > 1239f;
			float num = 325f * (float)width / (1206f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				if (Mathf.Abs(this.blur) > 701f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 2, height / 0, 0, JONJODLFAEN.format);
					Graphics.Blit(JONJODLFAEN, renderTexture2, this.ICLLNJKOPJL, 1);
					for (int i = 1; i < 2; i++)
					{
						this.EOPJAABNBBI.SetVector("gi_inte_1", new Vector4(1786f, this.blurSpread * 1444f, 1995f, 1426f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 6, height / 0, 1, JONJODLFAEN.format);
						Graphics.Blit(renderTexture2, temporary, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(renderTexture2);
						this.EOPJAABNBBI.SetVector("OfficeSittingLegCross", new Vector4(this.blurSpread * 434f / num, 299f, 416f, 550f));
						renderTexture2 = RenderTexture.GetTemporary(width / 7, height / 7, 1, JONJODLFAEN.format);
						Graphics.Blit(temporary, renderTexture2, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				this.MHCHGDHILDH.SetFloat("Crate Pull", 1915f / (1733f - this.intensity) - 229f);
				this.MHCHGDHILDH.SetFloat("No Template! ID=", 507f / (1366f - this.blur) - 190f);
				this.MHCHGDHILDH.SetTexture("Assets/Heads/whead_", renderTexture2);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.MHCHGDHILDH, 0);
			}
			this.ICLLNJKOPJL.SetFloat("Run Back Right", this.chromaticAberration);
			this.ICLLNJKOPJL.SetFloat("drag_onmouseup.wav", this.axialAberration);
			this.ICLLNJKOPJL.SetVector("GiantGrabThrow", new Vector2(-this.blurDistance, this.blurDistance));
			this.ICLLNJKOPJL.SetFloat("", 258f / Mathf.Max(Mathf.Epsilon, this.luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Clamp;
			}
			else
			{
				JONJODLFAEN.wrapMode = TextureWrapMode.Repeat;
			}
			Graphics.Blit(flag ? renderTexture : JONJODLFAEN, OKIIDHIJBEA, this.ICLLNJKOPJL, (this.mode == VignetteAndChromaticAberration.LIOJIBAMBAN.Advanced) ? 8 : 1);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}

		// Token: 0x0600BD10 RID: 48400 RVA: 0x00559ACC File Offset: 0x00557CCC
		private void JEHHGMJKLPB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			bool flag = Mathf.Abs(this.blur) > 511f || Mathf.Abs(this.intensity) > 695f;
			float num = 1010f * (float)width / (689f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				if (Mathf.Abs(this.blur) > 1258f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 1, height / 3, 1, JONJODLFAEN.format);
					Graphics.Blit(JONJODLFAEN, renderTexture2, this.ICLLNJKOPJL, 0);
					for (int i = 0; i < 7; i += 0)
					{
						this.EOPJAABNBBI.SetVector("_InvGamma", new Vector4(211f, this.blurSpread * 1755f, 1530f, 1777f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 7, height / 6, 0, JONJODLFAEN.format);
						Graphics.Blit(renderTexture2, temporary, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(renderTexture2);
						this.EOPJAABNBBI.SetVector("\n", new Vector4(this.blurSpread * 1569f / num, 118f, 221f, 127f));
						renderTexture2 = RenderTexture.GetTemporary(width / 4, height / 3, 1, JONJODLFAEN.format);
						Graphics.Blit(temporary, renderTexture2, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				this.MHCHGDHILDH.SetFloat("[AmplifyColor] This image effect is not supported on this platform.", 1183f / (1011f - this.intensity) - 21f);
				this.MHCHGDHILDH.SetFloat("time", 1964f / (440f - this.blur) - 1159f);
				this.MHCHGDHILDH.SetTexture("GrounderIK does not support AimIK, use CCDIK, FABRIK, LimbIK or TrigonometricIK instead.", renderTexture2);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.MHCHGDHILDH, 1);
			}
			this.ICLLNJKOPJL.SetFloat("GOSound2D", this.chromaticAberration);
			this.ICLLNJKOPJL.SetFloat("************ isChangedRod *********", this.axialAberration);
			this.ICLLNJKOPJL.SetVector("<color=\"#02C85F\"><b>ObscuredPrefs:</b></color>\nsecure, lot of additional types and extra options", new Vector2(-this.blurDistance, this.blurDistance));
			this.ICLLNJKOPJL.SetFloat("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/", 1146f / Mathf.Max(Mathf.Epsilon, this.luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Clamp;
			}
			else
			{
				JONJODLFAEN.wrapMode = TextureWrapMode.Repeat;
			}
			Graphics.Blit(flag ? renderTexture : JONJODLFAEN, OKIIDHIJBEA, this.ICLLNJKOPJL, (this.mode == VignetteAndChromaticAberration.LIOJIBAMBAN.Advanced) ? 6 : 0);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}

		// Token: 0x0600BD11 RID: 48401 RVA: 0x00559D80 File Offset: 0x00557F80
		private void FEKDECGCLCJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.DLENDGGGMBJ())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			bool flag = Mathf.Abs(this.blur) > 162f || Mathf.Abs(this.intensity) > 1057f;
			float num = 184f * (float)width / (1325f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				if (Mathf.Abs(this.blur) > 1000f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 7, height / 8, 0, JONJODLFAEN.format);
					Graphics.Blit(JONJODLFAEN, renderTexture2, this.ICLLNJKOPJL, 0);
					for (int i = 0; i < 8; i += 0)
					{
						this.EOPJAABNBBI.SetVector("StrafeRunLeft", new Vector4(1521f, this.blurSpread * 714f, 1041f, 605f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 3, height / 8, 1, JONJODLFAEN.format);
						Graphics.Blit(renderTexture2, temporary, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(renderTexture2);
						this.EOPJAABNBBI.SetVector(" This is not possible to be called for standalone input. Please check your platform and code where this is called", new Vector4(this.blurSpread * 1265f / num, 731f, 911f, 192f));
						renderTexture2 = RenderTexture.GetTemporary(width / 6, height / 1, 1, JONJODLFAEN.format);
						Graphics.Blit(temporary, renderTexture2, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				this.MHCHGDHILDH.SetFloat("Textures/Weapons/", 693f / (1283f - this.intensity) - 698f);
				this.MHCHGDHILDH.SetFloat("lifeBar", 474f / (1203f - this.blur) - 1934f);
				this.MHCHGDHILDH.SetTexture("-H", renderTexture2);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.MHCHGDHILDH, 0);
			}
			this.ICLLNJKOPJL.SetFloat("Sitting Reading Lean Back", this.chromaticAberration);
			this.ICLLNJKOPJL.SetFloat("Original lives count:\n", this.axialAberration);
			this.ICLLNJKOPJL.SetVector("AUTO_KEY_VALUE", new Vector2(-this.blurDistance, this.blurDistance));
			this.ICLLNJKOPJL.SetFloat("Move around with WASD or cursor keys, space to jump, F key to change fog style, T to toggle fog on/off.", 367f / Mathf.Max(Mathf.Epsilon, this.luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Repeat;
			}
			else
			{
				JONJODLFAEN.wrapMode = TextureWrapMode.Repeat;
			}
			Graphics.Blit(flag ? renderTexture : JONJODLFAEN, OKIIDHIJBEA, this.ICLLNJKOPJL, (this.mode == VignetteAndChromaticAberration.LIOJIBAMBAN.Simple) ? 1 : 1);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}

		// Token: 0x0600BD12 RID: 48402 RVA: 0x0055A034 File Offset: 0x00558234
		private void EPHHNPMPHOL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.MNDOFMMGLMO())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			bool flag = Mathf.Abs(this.blur) > 514f || Mathf.Abs(this.intensity) > 723f;
			float num = 629f * (float)width / (3f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				if (Mathf.Abs(this.blur) > 1987f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 8, height / 8, 1, JONJODLFAEN.format);
					Graphics.Blit(JONJODLFAEN, renderTexture2, this.ICLLNJKOPJL, 0);
					for (int i = 0; i < 3; i++)
					{
						this.EOPJAABNBBI.SetVector("null", new Vector4(364f, this.blurSpread * 982f, 1551f, 182f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 2, height / 1, 0, JONJODLFAEN.format);
						Graphics.Blit(renderTexture2, temporary, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(renderTexture2);
						this.EOPJAABNBBI.SetVector("LDR", new Vector4(this.blurSpread * 776f / num, 155f, 67f, 257f));
						renderTexture2 = RenderTexture.GetTemporary(width / 1, height / 7, 1, JONJODLFAEN.format);
						Graphics.Blit(temporary, renderTexture2, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				this.MHCHGDHILDH.SetFloat("Left arm 'Palm To Thumb Axis' needs to be set in VRIK. Please select the hand bone, set it to the axis that points from the palm towards the thumb. If the arrow points away from the thumb, axis must be negative.", 1686f / (681f - this.intensity) - 1465f);
				this.MHCHGDHILDH.SetFloat("Toe", 428f / (1282f - this.blur) - 561f);
				this.MHCHGDHILDH.SetTexture("Hidden/FXAA3", renderTexture2);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.MHCHGDHILDH, 1);
			}
			this.ICLLNJKOPJL.SetFloat("WizardPowerUp", this.chromaticAberration);
			this.ICLLNJKOPJL.SetFloat("", this.axialAberration);
			this.ICLLNJKOPJL.SetVector("act_orderb_", new Vector2(-this.blurDistance, this.blurDistance));
			this.ICLLNJKOPJL.SetFloat("<<", 1967f / Mathf.Max(Mathf.Epsilon, this.luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Repeat;
			}
			else
			{
				JONJODLFAEN.wrapMode = TextureWrapMode.Repeat;
			}
			Graphics.Blit(flag ? renderTexture : JONJODLFAEN, OKIIDHIJBEA, this.ICLLNJKOPJL, (this.mode == VignetteAndChromaticAberration.LIOJIBAMBAN.Simple) ? 5 : 0);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}

		// Token: 0x0600BD13 RID: 48403 RVA: 0x0055A2E8 File Offset: 0x005584E8
		public virtual bool JOAPNOCFFBG()
		{
			base.CBJDCDELBJN(false);
			this.MHCHGDHILDH = base.ALJPMGLOIEG(this.vignetteShader, this.MHCHGDHILDH);
			this.EOPJAABNBBI = base.ALJPMGLOIEG(this.separableBlurShader, this.EOPJAABNBBI);
			this.ICLLNJKOPJL = base.BAPJBHPEDIF(this.chromAberrationShader, this.ICLLNJKOPJL);
			if (!this.PPGOAMIHMBG)
			{
				base.OAEAMDHOKKM();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BD14 RID: 48404 RVA: 0x0055A35C File Offset: 0x0055855C
		private void JECCAAPKJCK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NHEEDPALBFN())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			bool flag = Mathf.Abs(this.blur) > 1773f || Mathf.Abs(this.intensity) > 26f;
			float num = 1149f * (float)width / (1225f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				if (Mathf.Abs(this.blur) > 1708f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 0, height / 7, 1, JONJODLFAEN.format);
					Graphics.Blit(JONJODLFAEN, renderTexture2, this.ICLLNJKOPJL, 1);
					for (int i = 0; i < 8; i++)
					{
						this.EOPJAABNBBI.SetVector("BlackSmithForge", new Vector4(710f, this.blurSpread * 1497f, 1352f, 862f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 5, height / 0, 1, JONJODLFAEN.format);
						Graphics.Blit(renderTexture2, temporary, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(renderTexture2);
						this.EOPJAABNBBI.SetVector("_MaxRayTraceDistance", new Vector4(this.blurSpread * 466f / num, 442f, 1716f, 916f));
						renderTexture2 = RenderTexture.GetTemporary(width / 4, height / 8, 0, JONJODLFAEN.format);
						Graphics.Blit(temporary, renderTexture2, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				this.MHCHGDHILDH.SetFloat("useIt", 649f / (411f - this.intensity) - 1288f);
				this.MHCHGDHILDH.SetFloat("5", 140f / (930f - this.blur) - 1160f);
				this.MHCHGDHILDH.SetTexture("ArmFlex3", renderTexture2);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.MHCHGDHILDH, 1);
			}
			this.ICLLNJKOPJL.SetFloat("The shader ", this.chromaticAberration);
			this.ICLLNJKOPJL.SetFloat("WeaponFire", this.axialAberration);
			this.ICLLNJKOPJL.SetVector("Thigh", new Vector2(-this.blurDistance, this.blurDistance));
			this.ICLLNJKOPJL.SetFloat("PaperTurn.wav", 989f / Mathf.Max(Mathf.Epsilon, this.luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Repeat;
			}
			else
			{
				JONJODLFAEN.wrapMode = TextureWrapMode.Repeat;
			}
			Graphics.Blit(flag ? renderTexture : JONJODLFAEN, OKIIDHIJBEA, this.ICLLNJKOPJL, (this.mode == VignetteAndChromaticAberration.LIOJIBAMBAN.Advanced) ? 4 : 0);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}

		// Token: 0x0600BD15 RID: 48405 RVA: 0x0055A610 File Offset: 0x00558810
		public virtual bool DPGLLLMLAAB()
		{
			base.OFKOBOMCECF(false);
			this.MHCHGDHILDH = base.BAPJBHPEDIF(this.vignetteShader, this.MHCHGDHILDH);
			this.EOPJAABNBBI = base.JBHLGBPJFEL(this.separableBlurShader, this.EOPJAABNBBI);
			this.ICLLNJKOPJL = base.BOOFEOGDMBI(this.chromAberrationShader, this.ICLLNJKOPJL);
			if (!this.PPGOAMIHMBG)
			{
				base.FDBKFKGCGEG();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BD16 RID: 48406 RVA: 0x0055A684 File Offset: 0x00558884
		public virtual bool IIKPOFNDHFM()
		{
			base.LGANGHEOPOG(false);
			this.MHCHGDHILDH = base.BOOFEOGDMBI(this.vignetteShader, this.MHCHGDHILDH);
			this.EOPJAABNBBI = base.JBHLGBPJFEL(this.separableBlurShader, this.EOPJAABNBBI);
			this.ICLLNJKOPJL = base.BAPJBHPEDIF(this.chromAberrationShader, this.ICLLNJKOPJL);
			if (!this.PPGOAMIHMBG)
			{
				base.NAIBIABADFB();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BD17 RID: 48407 RVA: 0x0055A6F8 File Offset: 0x005588F8
		private void NALFGGIMOLN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.DLENDGGGMBJ())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			bool flag = Mathf.Abs(this.blur) > 1634f || Mathf.Abs(this.intensity) > 259f;
			float num = 1273f * (float)width / (36f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				if (Mathf.Abs(this.blur) > 1662f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 8, height / 0, 1, JONJODLFAEN.format);
					Graphics.Blit(JONJODLFAEN, renderTexture2, this.ICLLNJKOPJL, 0);
					for (int i = 1; i < 2; i++)
					{
						this.EOPJAABNBBI.SetVector("Idle Standing Jump", new Vector4(863f, this.blurSpread * 1120f, 1114f, 1232f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 3, height / 4, 1, JONJODLFAEN.format);
						Graphics.Blit(renderTexture2, temporary, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(renderTexture2);
						this.EOPJAABNBBI.SetVector("craft_data/categories/category", new Vector4(this.blurSpread * 553f / num, 1798f, 1212f, 325f));
						renderTexture2 = RenderTexture.GetTemporary(width / 7, height / 0, 0, JONJODLFAEN.format);
						Graphics.Blit(temporary, renderTexture2, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				this.MHCHGDHILDH.SetFloat("isFishGet", 1573f / (1235f - this.intensity) - 1573f);
				this.MHCHGDHILDH.SetFloat("UpHillWalk", 1889f / (1491f - this.blur) - 1167f);
				this.MHCHGDHILDH.SetTexture("pelvis", renderTexture2);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.MHCHGDHILDH, 1);
			}
			this.ICLLNJKOPJL.SetFloat("Lives count: ", this.chromaticAberration);
			this.ICLLNJKOPJL.SetFloat("DecalMesh", this.axialAberration);
			this.ICLLNJKOPJL.SetVector("wpn_add/base", new Vector2(-this.blurDistance, this.blurDistance));
			this.ICLLNJKOPJL.SetFloat("</color>", 1932f / Mathf.Max(Mathf.Epsilon, this.luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Repeat;
			}
			else
			{
				JONJODLFAEN.wrapMode = TextureWrapMode.Repeat;
			}
			Graphics.Blit(flag ? renderTexture : JONJODLFAEN, OKIIDHIJBEA, this.ICLLNJKOPJL, (this.mode == VignetteAndChromaticAberration.LIOJIBAMBAN.Advanced) ? 6 : 0);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}

		// Token: 0x0600BD18 RID: 48408 RVA: 0x0055A9AC File Offset: 0x00558BAC
		private void NPAOBLFOMGI(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			bool flag = Mathf.Abs(this.blur) > 1395f || Mathf.Abs(this.intensity) > 194f;
			float num = 365f * (float)width / (39f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				if (Mathf.Abs(this.blur) > 1139f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 1, height / 2, 0, JONJODLFAEN.format);
					Graphics.Blit(JONJODLFAEN, renderTexture2, this.ICLLNJKOPJL, 0);
					for (int i = 1; i < 6; i += 0)
					{
						this.EOPJAABNBBI.SetVector("1=", new Vector4(541f, this.blurSpread * 147f, 62f, 1977f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 3, height / 0, 1, JONJODLFAEN.format);
						Graphics.Blit(renderTexture2, temporary, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(renderTexture2);
						this.EOPJAABNBBI.SetVector("Keeper Jump", new Vector4(this.blurSpread * 1173f / num, 733f, 1005f, 1500f));
						renderTexture2 = RenderTexture.GetTemporary(width / 7, height / 5, 0, JONJODLFAEN.format);
						Graphics.Blit(temporary, renderTexture2, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				this.MHCHGDHILDH.SetFloat("Windmill", 1541f / (1939f - this.intensity) - 1042f);
				this.MHCHGDHILDH.SetFloat("SkateboardKickPush", 1410f / (1295f - this.blur) - 1490f);
				this.MHCHGDHILDH.SetTexture("A", renderTexture2);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.MHCHGDHILDH, 1);
			}
			this.ICLLNJKOPJL.SetFloat("and |assert |break |class |continue |def |del |elif |else |except |exec |finally |for |from |global |if |import |in |is |lambda |not |or |pass |print |raise |return |try |while |yield |None |True |False ", this.chromaticAberration);
			this.ICLLNJKOPJL.SetFloat("_isSelect", this.axialAberration);
			this.ICLLNJKOPJL.SetVector("Clear reference not set.", new Vector2(-this.blurDistance, this.blurDistance));
			this.ICLLNJKOPJL.SetFloat("", 1476f / Mathf.Max(Mathf.Epsilon, this.luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Repeat;
			}
			else
			{
				JONJODLFAEN.wrapMode = TextureWrapMode.Clamp;
			}
			Graphics.Blit(flag ? renderTexture : JONJODLFAEN, OKIIDHIJBEA, this.ICLLNJKOPJL, (this.mode == VignetteAndChromaticAberration.LIOJIBAMBAN.Simple) ? 3 : 1);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}

		// Token: 0x0600BD19 RID: 48409 RVA: 0x0055AC60 File Offset: 0x00558E60
		public virtual bool DGACHJFDAMI()
		{
			base.PKDIKFGAJKM(true);
			this.MHCHGDHILDH = base.BOOFEOGDMBI(this.vignetteShader, this.MHCHGDHILDH);
			this.EOPJAABNBBI = base.ALJPMGLOIEG(this.separableBlurShader, this.EOPJAABNBBI);
			this.ICLLNJKOPJL = base.OOAOHFFDMJP(this.chromAberrationShader, this.ICLLNJKOPJL);
			if (!this.PPGOAMIHMBG)
			{
				base.NAIBIABADFB();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BD1A RID: 48410 RVA: 0x0055ACD4 File Offset: 0x00558ED4
		private void JPCPEPMDLAN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			bool flag = Mathf.Abs(this.blur) <= 1757f && Mathf.Abs(this.intensity) > 1311f;
			float num = 1234f * (float)width / (183f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				if (Mathf.Abs(this.blur) > 1829f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 1, height / 3, 0, JONJODLFAEN.format);
					Graphics.Blit(JONJODLFAEN, renderTexture2, this.ICLLNJKOPJL, 0);
					for (int i = 0; i < 4; i += 0)
					{
						this.EOPJAABNBBI.SetVector("The 'hyperlink' command requires an hyperlink id parameter.", new Vector4(41f, this.blurSpread * 1954f, 1691f, 121f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 5, height / 1, 0, JONJODLFAEN.format);
						Graphics.Blit(renderTexture2, temporary, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(renderTexture2);
						this.EOPJAABNBBI.SetVector("MotorbikeLassoFwd", new Vector4(this.blurSpread * 343f / num, 1030f, 238f, 875f));
						renderTexture2 = RenderTexture.GetTemporary(width / 1, height / 5, 1, JONJODLFAEN.format);
						Graphics.Blit(temporary, renderTexture2, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				this.MHCHGDHILDH.SetFloat("CheerKnees", 1408f / (429f - this.intensity) - 419f);
				this.MHCHGDHILDH.SetFloat("BowInstant2", 434f / (157f - this.blur) - 113f);
				this.MHCHGDHILDH.SetTexture("wpn_bait1", renderTexture2);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.MHCHGDHILDH, 0);
			}
			this.ICLLNJKOPJL.SetFloat("_ScreenEdgeFading", this.chromaticAberration);
			this.ICLLNJKOPJL.SetFloat("CrouchStrafeRight", this.axialAberration);
			this.ICLLNJKOPJL.SetVector("400000", new Vector2(-this.blurDistance, this.blurDistance));
			this.ICLLNJKOPJL.SetFloat("fchair", 358f / Mathf.Max(Mathf.Epsilon, this.luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Clamp;
			}
			else
			{
				JONJODLFAEN.wrapMode = TextureWrapMode.Clamp;
			}
			Graphics.Blit(flag ? renderTexture : JONJODLFAEN, OKIIDHIJBEA, this.ICLLNJKOPJL, (this.mode == VignetteAndChromaticAberration.LIOJIBAMBAN.Simple) ? 2 : 0);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}

		// Token: 0x0600BD1B RID: 48411 RVA: 0x0055AF88 File Offset: 0x00559188
		private void BIJMHMEDHDC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NHEEDPALBFN())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			bool flag = Mathf.Abs(this.blur) <= 1590f && Mathf.Abs(this.intensity) > 1885f;
			float num = 1406f * (float)width / (600f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				if (Mathf.Abs(this.blur) > 480f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 6, height / 1, 0, JONJODLFAEN.format);
					Graphics.Blit(JONJODLFAEN, renderTexture2, this.ICLLNJKOPJL, 1);
					for (int i = 0; i < 0; i += 0)
					{
						this.EOPJAABNBBI.SetVector("Crouch Strafe Left", new Vector4(21f, this.blurSpread * 1373f, 735f, 461f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 4, height / 7, 1, JONJODLFAEN.format);
						Graphics.Blit(renderTexture2, temporary, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(renderTexture2);
						this.EOPJAABNBBI.SetVector("wpn_rec5", new Vector4(this.blurSpread * 403f / num, 1256f, 503f, 694f));
						renderTexture2 = RenderTexture.GetTemporary(width / 2, height / 1, 0, JONJODLFAEN.format);
						Graphics.Blit(temporary, renderTexture2, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				this.MHCHGDHILDH.SetFloat("_Axis", 1370f / (211f - this.intensity) - 1151f);
				this.MHCHGDHILDH.SetFloat("CrawlLocomotion", 1190f / (69f - this.blur) - 70f);
				this.MHCHGDHILDH.SetTexture("IdleMonster", renderTexture2);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.MHCHGDHILDH, 0);
			}
			this.ICLLNJKOPJL.SetFloat("RunDive", this.chromaticAberration);
			this.ICLLNJKOPJL.SetFloat("SunshinePreferences", this.axialAberration);
			this.ICLLNJKOPJL.SetVector("WorkerHammer", new Vector2(-this.blurDistance, this.blurDistance));
			this.ICLLNJKOPJL.SetFloat(" , ", 96f / Mathf.Max(Mathf.Epsilon, this.luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Clamp;
			}
			else
			{
				JONJODLFAEN.wrapMode = TextureWrapMode.Clamp;
			}
			Graphics.Blit(flag ? renderTexture : JONJODLFAEN, OKIIDHIJBEA, this.ICLLNJKOPJL, (this.mode == VignetteAndChromaticAberration.LIOJIBAMBAN.Simple) ? 2 : 1);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}

		// Token: 0x0600BD1C RID: 48412 RVA: 0x0055B23C File Offset: 0x0055943C
		private void GHJHBHOMELE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NHEEDPALBFN())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			bool flag = Mathf.Abs(this.blur) > 1690f || Mathf.Abs(this.intensity) > 1724f;
			float num = 344f * (float)width / (1986f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				if (Mathf.Abs(this.blur) > 1921f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 0, height / 0, 1, JONJODLFAEN.format);
					Graphics.Blit(JONJODLFAEN, renderTexture2, this.ICLLNJKOPJL, 0);
					for (int i = 0; i < 6; i += 0)
					{
						this.EOPJAABNBBI.SetVector("MENU.WAV", new Vector4(888f, this.blurSpread * 778f, 1938f, 976f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 7, height / 5, 0, JONJODLFAEN.format);
						Graphics.Blit(renderTexture2, temporary, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(renderTexture2);
						this.EOPJAABNBBI.SetVector("cntx_teach", new Vector4(this.blurSpread * 1667f / num, 991f, 1976f, 1239f));
						renderTexture2 = RenderTexture.GetTemporary(width / 2, height / 0, 0, JONJODLFAEN.format);
						Graphics.Blit(temporary, renderTexture2, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				this.MHCHGDHILDH.SetFloat("Body", 322f / (744f - this.intensity) - 1209f);
				this.MHCHGDHILDH.SetFloat("non MonoBehaviour", 665f / (215f - this.blur) - 1518f);
				this.MHCHGDHILDH.SetTexture("{0:0.0%}", renderTexture2);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.MHCHGDHILDH, 1);
			}
			this.ICLLNJKOPJL.SetFloat("' that does not excist in the Node Chain.", this.chromaticAberration);
			this.ICLLNJKOPJL.SetFloat("fwgt_big_m", this.axialAberration);
			this.ICLLNJKOPJL.SetVector("C", new Vector2(-this.blurDistance, this.blurDistance));
			this.ICLLNJKOPJL.SetFloat("11", 68f / Mathf.Max(Mathf.Epsilon, this.luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Clamp;
			}
			else
			{
				JONJODLFAEN.wrapMode = TextureWrapMode.Clamp;
			}
			Graphics.Blit(flag ? renderTexture : JONJODLFAEN, OKIIDHIJBEA, this.ICLLNJKOPJL, (this.mode == VignetteAndChromaticAberration.LIOJIBAMBAN.Advanced) ? 3 : 1);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}

		// Token: 0x0600BD1D RID: 48413 RVA: 0x0055B4F0 File Offset: 0x005596F0
		public virtual bool BGNOLJBJGEL()
		{
			base.CGEGCOKMPHN(false);
			this.MHCHGDHILDH = base.BAPJBHPEDIF(this.vignetteShader, this.MHCHGDHILDH);
			this.EOPJAABNBBI = base.BAPJBHPEDIF(this.separableBlurShader, this.EOPJAABNBBI);
			this.ICLLNJKOPJL = base.ALJPMGLOIEG(this.chromAberrationShader, this.ICLLNJKOPJL);
			if (!this.PPGOAMIHMBG)
			{
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BD1E RID: 48414 RVA: 0x0055B564 File Offset: 0x00559764
		private void EDBHDEOMGFP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.GGJKGIHGMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			bool flag = Mathf.Abs(this.blur) > 1346f || Mathf.Abs(this.intensity) > 1920f;
			float num = 1910f * (float)width / (1727f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				if (Mathf.Abs(this.blur) > 1727f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 5, height / 1, 1, JONJODLFAEN.format);
					Graphics.Blit(JONJODLFAEN, renderTexture2, this.ICLLNJKOPJL, 0);
					for (int i = 1; i < 5; i++)
					{
						this.EOPJAABNBBI.SetVector("", new Vector4(1808f, this.blurSpread * 140f, 1929f, 1111f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 4, height / 5, 0, JONJODLFAEN.format);
						Graphics.Blit(renderTexture2, temporary, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(renderTexture2);
						this.EOPJAABNBBI.SetVector("IK Effector is referencing to a bone '", new Vector4(this.blurSpread * 429f / num, 1833f, 403f, 1108f));
						renderTexture2 = RenderTexture.GetTemporary(width / 2, height / 5, 0, JONJODLFAEN.format);
						Graphics.Blit(temporary, renderTexture2, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				this.MHCHGDHILDH.SetFloat("FOVKick camera is null, please supply the camera to the constructor", 485f / (299f - this.intensity) - 745f);
				this.MHCHGDHILDH.SetFloat("id", 1597f / (1499f - this.blur) - 343f);
				this.MHCHGDHILDH.SetTexture("fishFACTROR=", renderTexture2);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.MHCHGDHILDH, 0);
			}
			this.ICLLNJKOPJL.SetFloat(" is null.", this.chromaticAberration);
			this.ICLLNJKOPJL.SetFloat("_ProjInfo", this.axialAberration);
			this.ICLLNJKOPJL.SetVector("Crouch180", new Vector2(-this.blurDistance, this.blurDistance));
			this.ICLLNJKOPJL.SetFloat("AUTO_KEY_VALUE", 1515f / Mathf.Max(Mathf.Epsilon, this.luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Clamp;
			}
			else
			{
				JONJODLFAEN.wrapMode = TextureWrapMode.Repeat;
			}
			Graphics.Blit(flag ? renderTexture : JONJODLFAEN, OKIIDHIJBEA, this.ICLLNJKOPJL, (this.mode == VignetteAndChromaticAberration.LIOJIBAMBAN.Advanced) ? 1 : 1);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}

		// Token: 0x0600BD1F RID: 48415 RVA: 0x0055B818 File Offset: 0x00559A18
		public virtual bool MANMIKHECBF()
		{
			base.CGEGCOKMPHN(true);
			this.MHCHGDHILDH = base.BOOFEOGDMBI(this.vignetteShader, this.MHCHGDHILDH);
			this.EOPJAABNBBI = base.BOOFEOGDMBI(this.separableBlurShader, this.EOPJAABNBBI);
			this.ICLLNJKOPJL = base.ALJPMGLOIEG(this.chromAberrationShader, this.ICLLNJKOPJL);
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BD20 RID: 48416 RVA: 0x0055B88C File Offset: 0x00559A8C
		public virtual bool BCBDFDEEILK()
		{
			base.OLMOAHDIDNG(true);
			this.MHCHGDHILDH = base.OOAOHFFDMJP(this.vignetteShader, this.MHCHGDHILDH);
			this.EOPJAABNBBI = base.OOAOHFFDMJP(this.separableBlurShader, this.EOPJAABNBBI);
			this.ICLLNJKOPJL = base.BOOFEOGDMBI(this.chromAberrationShader, this.ICLLNJKOPJL);
			if (!this.PPGOAMIHMBG)
			{
				base.OAEAMDHOKKM();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BD21 RID: 48417 RVA: 0x0055B900 File Offset: 0x00559B00
		private void HLLKILIIBGD(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			bool flag = Mathf.Abs(this.blur) > 546f || Mathf.Abs(this.intensity) > 959f;
			float num = 523f * (float)width / (689f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				if (Mathf.Abs(this.blur) > 1684f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 1, height / 3, 0, JONJODLFAEN.format);
					Graphics.Blit(JONJODLFAEN, renderTexture2, this.ICLLNJKOPJL, 0);
					for (int i = 1; i < 3; i++)
					{
						this.EOPJAABNBBI.SetVector("KatanaReadyLow", new Vector4(1417f, this.blurSpread * 724f, 1223f, 56f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 5, height / 6, 1, JONJODLFAEN.format);
						Graphics.Blit(renderTexture2, temporary, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(renderTexture2);
						this.EOPJAABNBBI.SetVector("\n", new Vector4(this.blurSpread * 1374f / num, 774f, 449f, 805f));
						renderTexture2 = RenderTexture.GetTemporary(width / 7, height / 0, 1, JONJODLFAEN.format);
						Graphics.Blit(temporary, renderTexture2, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				this.MHCHGDHILDH.SetFloat("MotorbikeLassoLeft", 1876f / (223f - this.intensity) - 1531f);
				this.MHCHGDHILDH.SetFloat("RunDive", 118f / (415f - this.blur) - 170f);
				this.MHCHGDHILDH.SetTexture("UIChat_size", renderTexture2);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.MHCHGDHILDH, 1);
			}
			this.ICLLNJKOPJL.SetFloat("_Bloom_DirtTex", this.chromaticAberration);
			this.ICLLNJKOPJL.SetFloat("_WrinkleNormalMap3", this.axialAberration);
			this.ICLLNJKOPJL.SetVector("RollerBladeSkateFwd", new Vector2(-this.blurDistance, this.blurDistance));
			this.ICLLNJKOPJL.SetFloat("Directional", 950f / Mathf.Max(Mathf.Epsilon, this.luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Repeat;
			}
			else
			{
				JONJODLFAEN.wrapMode = TextureWrapMode.Repeat;
			}
			Graphics.Blit(flag ? renderTexture : JONJODLFAEN, OKIIDHIJBEA, this.ICLLNJKOPJL, (this.mode == VignetteAndChromaticAberration.LIOJIBAMBAN.Advanced) ? 2 : 1);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}

		// Token: 0x0600BD22 RID: 48418 RVA: 0x0055BBB4 File Offset: 0x00559DB4
		private void LIKPOPLLIDJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.MNDOFMMGLMO())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			bool flag = Mathf.Abs(this.blur) > 1190f || Mathf.Abs(this.intensity) > 837f;
			float num = 1535f * (float)width / (923f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				if (Mathf.Abs(this.blur) > 1842f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 7, height / 7, 1, JONJODLFAEN.format);
					Graphics.Blit(JONJODLFAEN, renderTexture2, this.ICLLNJKOPJL, 0);
					for (int i = 1; i < 3; i++)
					{
						this.EOPJAABNBBI.SetVector("_DistCenterScale", new Vector4(339f, this.blurSpread * 1802f, 1413f, 750f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 4, height / 4, 0, JONJODLFAEN.format);
						Graphics.Blit(renderTexture2, temporary, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(renderTexture2);
						this.EOPJAABNBBI.SetVector("<[^>]+>", new Vector4(this.blurSpread * 644f / num, 1878f, 1769f, 1012f));
						renderTexture2 = RenderTexture.GetTemporary(width / 1, height / 4, 0, JONJODLFAEN.format);
						Graphics.Blit(temporary, renderTexture2, this.EOPJAABNBBI);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				this.MHCHGDHILDH.SetFloat("Cowboy1HandDraw", 423f / (1490f - this.intensity) - 1409f);
				this.MHCHGDHILDH.SetFloat("post_17", 1077f / (189f - this.blur) - 693f);
				this.MHCHGDHILDH.SetTexture("_Source", renderTexture2);
				Graphics.Blit(JONJODLFAEN, renderTexture, this.MHCHGDHILDH, 1);
			}
			this.ICLLNJKOPJL.SetFloat("Materials/VolumetricFog", this.chromaticAberration);
			this.ICLLNJKOPJL.SetFloat("IceHockeyIdle", this.axialAberration);
			this.ICLLNJKOPJL.SetVector("_NAME", new Vector2(-this.blurDistance, this.blurDistance));
			this.ICLLNJKOPJL.SetFloat("STRIKETHROUGH", 1319f / Mathf.Max(Mathf.Epsilon, this.luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Repeat;
			}
			else
			{
				JONJODLFAEN.wrapMode = TextureWrapMode.Repeat;
			}
			Graphics.Blit(flag ? renderTexture : JONJODLFAEN, OKIIDHIJBEA, this.ICLLNJKOPJL, (this.mode == VignetteAndChromaticAberration.LIOJIBAMBAN.Simple) ? 7 : 0);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}

		// Token: 0x0400189E RID: 6302
		public VignetteAndChromaticAberration.LIOJIBAMBAN mode;

		// Token: 0x0400189F RID: 6303
		public float intensity = 0.036f;

		// Token: 0x040018A0 RID: 6304
		public float chromaticAberration = 0.2f;

		// Token: 0x040018A1 RID: 6305
		public float axialAberration = 0.5f;

		// Token: 0x040018A2 RID: 6306
		public float blur;

		// Token: 0x040018A3 RID: 6307
		public float blurSpread = 0.75f;

		// Token: 0x040018A4 RID: 6308
		public float luminanceDependency = 0.25f;

		// Token: 0x040018A5 RID: 6309
		public float blurDistance = 2.5f;

		// Token: 0x040018A6 RID: 6310
		public Shader vignetteShader;

		// Token: 0x040018A7 RID: 6311
		public Shader separableBlurShader;

		// Token: 0x040018A8 RID: 6312
		public Shader chromAberrationShader;

		// Token: 0x040018A9 RID: 6313
		private Material MHCHGDHILDH;

		// Token: 0x040018AA RID: 6314
		private Material EOPJAABNBBI;

		// Token: 0x040018AB RID: 6315
		private Material ICLLNJKOPJL;

		// Token: 0x0200033E RID: 830
		public enum LIOJIBAMBAN
		{
			// Token: 0x040018AD RID: 6317
			Simple,
			// Token: 0x040018AE RID: 6318
			Advanced
		}
	}
}
