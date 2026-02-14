using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000307 RID: 775
	[AddComponentMenu("Image Effects/Bloom and Glow/BloomAndFlares (3.5, Deprecated)")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class BloomAndFlares : PostEffectsBase
	{
		// Token: 0x0600B31D RID: 45853 RVA: 0x004E4C60 File Offset: 0x004E2E60
		private void OAKNBBGIOKB(float MHIPLHJKKIF, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			if (this.lensFlareVignetteMask)
			{
				this.GILHCCIHPGN.SetTexture("Jump", this.lensFlareVignetteMask);
				Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.GILHCCIHPGN, 0);
				return;
			}
			this.DGEAOLLJAAG.SetFloat(" ", MHIPLHJKKIF);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.DGEAOLLJAAG);
		}

		// Token: 0x0600B31E RID: 45854 RVA: 0x004E4CC0 File Offset: 0x004E2EC0
		private void JALNOJHJMKN(float JLEHAHJEIAC, float LACHEBPNLKL, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			if (this.GEBCPMDEOEA)
			{
				this.PJECOFONCFN.SetVector("__c", new Vector4(JLEHAHJEIAC, 1800f, 477f, 320f));
			}
			else
			{
				this.PJECOFONCFN.SetVector("SUNSHINE_FILTER_PCF_2x2", new Vector4(JLEHAHJEIAC, 605f / (919f - JLEHAHJEIAC), 727f, 1089f));
			}
			this.PJECOFONCFN.SetFloat("[ACTk] Injection Detector: disabled but StartDetection still called from somewhere (see stack trace for this message)!", LACHEBPNLKL);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.PJECOFONCFN);
		}

		// Token: 0x0600B31F RID: 45855 RVA: 0x004E4D48 File Offset: 0x004E2F48
		private void FFEOONAKLEE(float MHIPLHJKKIF, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			if (this.lensFlareVignetteMask)
			{
				this.GILHCCIHPGN.SetTexture("inv_auk", this.lensFlareVignetteMask);
				Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.GILHCCIHPGN, 0);
				return;
			}
			this.DGEAOLLJAAG.SetFloat("t_top", MHIPLHJKKIF);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.DGEAOLLJAAG);
		}

		// Token: 0x0600B320 RID: 45856 RVA: 0x004E4DA5 File Offset: 0x004E2FA5
		private void JOLMPBOPKNM(float EJBGLCNDHMK, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.IHBCDHELNMM.SetFloat("dd/MM/yyyy HH:mm", EJBGLCNDHMK);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.IHBCDHELNMM);
		}

		// Token: 0x0600B321 RID: 45857 RVA: 0x004E4DC8 File Offset: 0x004E2FC8
		private void DNIACJNAGMP(float MHIPLHJKKIF, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			if (this.lensFlareVignetteMask)
			{
				this.GILHCCIHPGN.SetTexture("", this.lensFlareVignetteMask);
				Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.GILHCCIHPGN, 8);
				return;
			}
			this.DGEAOLLJAAG.SetFloat("_Convolved_TexelSize", MHIPLHJKKIF);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.DGEAOLLJAAG);
		}

		// Token: 0x0600B322 RID: 45858 RVA: 0x004E4E25 File Offset: 0x004E3025
		private void APBPGPALFLO(float EJBGLCNDHMK, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.IHBCDHELNMM.SetFloat("CratePull", EJBGLCNDHMK);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.IHBCDHELNMM);
		}

		// Token: 0x0600B323 RID: 45859 RVA: 0x004E4E45 File Offset: 0x004E3045
		private void BEFGNABMCIH(float EJBGLCNDHMK, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.IHBCDHELNMM.SetFloat("1HandSwordChargeUp", EJBGLCNDHMK);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.IHBCDHELNMM);
		}

		// Token: 0x0600B324 RID: 45860 RVA: 0x004E4E68 File Offset: 0x004E3068
		private void LCLDBEHLPJO(float JLEHAHJEIAC, float LACHEBPNLKL, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			if (this.GEBCPMDEOEA)
			{
				this.PJECOFONCFN.SetVector("CraftProf.xml", new Vector4(JLEHAHJEIAC, 77f, 1205f, 1733f));
			}
			else
			{
				this.PJECOFONCFN.SetVector("process Action", new Vector4(JLEHAHJEIAC, 1274f / (1418f - JLEHAHJEIAC), 326f, 1998f));
			}
			this.PJECOFONCFN.SetFloat("MotorbikeLassoRight", LACHEBPNLKL);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.PJECOFONCFN);
		}

		// Token: 0x0600B325 RID: 45861 RVA: 0x004E4EF0 File Offset: 0x004E30F0
		private void GKHEAAEEOJB(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.FGKGIFAKMKL.SetVector("TOD_SunMeshColor", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("</color>", new Vector4(this.flareColorB.r, this.flareColorB.g, this.flareColorB.b, this.flareColorB.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("_InternalLutParams", new Vector4(this.flareColorC.r, this.flareColorC.g, this.flareColorC.b, this.flareColorC.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("_Axis", new Vector4(this.flareColorD.r, this.flareColorD.g, this.flareColorD.b, this.flareColorD.a) * this.lensflareIntensity);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.FGKGIFAKMKL);
		}

		// Token: 0x0600B326 RID: 45862 RVA: 0x004E503C File Offset: 0x004E323C
		private void FGLLJIAOOHH(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.FGKGIFAKMKL.SetVector("inv_aukcinf", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("impfail", new Vector4(this.flareColorB.r, this.flareColorB.g, this.flareColorB.b, this.flareColorB.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("Roar", new Vector4(this.flareColorC.r, this.flareColorC.g, this.flareColorC.b, this.flareColorC.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector(" length is zero, can not solve.", new Vector4(this.flareColorD.r, this.flareColorD.g, this.flareColorD.b, this.flareColorD.a) * this.lensflareIntensity);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.FGKGIFAKMKL);
		}

		// Token: 0x0600B327 RID: 45863 RVA: 0x004E5188 File Offset: 0x004E3388
		public virtual bool NENLAEOGCBK()
		{
			base.OAAFLHNDKBJ(false);
			this.GILHCCIHPGN = base.ALJPMGLOIEG(this.screenBlendShader, this.GILHCCIHPGN);
			this.FGKGIFAKMKL = base.OOAOHFFDMJP(this.lensFlareShader, this.FGKGIFAKMKL);
			this.DGEAOLLJAAG = base.JBHLGBPJFEL(this.vignetteShader, this.DGEAOLLJAAG);
			this.AEODOBMBCHF = base.JBHLGBPJFEL(this.separableBlurShader, this.AEODOBMBCHF);
			this.IHBCDHELNMM = base.OOAOHFFDMJP(this.addBrightStuffOneOneShader, this.IHBCDHELNMM);
			this.BAPBHFIHGDL = base.BOOFEOGDMBI(this.hollywoodFlaresShader, this.BAPBHFIHGDL);
			this.PJECOFONCFN = base.IIIIADNBONI(this.brightPassFilterShader, this.PJECOFONCFN);
			if (!this.PPGOAMIHMBG)
			{
				base.NAIBIABADFB();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B328 RID: 45864 RVA: 0x004E525C File Offset: 0x004E345C
		public virtual bool JOAPNOCFFBG()
		{
			base.BGIALJEIEFO(false);
			this.GILHCCIHPGN = base.JBHLGBPJFEL(this.screenBlendShader, this.GILHCCIHPGN);
			this.FGKGIFAKMKL = base.BAPJBHPEDIF(this.lensFlareShader, this.FGKGIFAKMKL);
			this.DGEAOLLJAAG = base.BAPJBHPEDIF(this.vignetteShader, this.DGEAOLLJAAG);
			this.AEODOBMBCHF = base.DJFOEIJIMJB(this.separableBlurShader, this.AEODOBMBCHF);
			this.IHBCDHELNMM = base.BOOFEOGDMBI(this.addBrightStuffOneOneShader, this.IHBCDHELNMM);
			this.BAPBHFIHGDL = base.ALJPMGLOIEG(this.hollywoodFlaresShader, this.BAPBHFIHGDL);
			this.PJECOFONCFN = base.OOAOHFFDMJP(this.brightPassFilterShader, this.PJECOFONCFN);
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B329 RID: 45865 RVA: 0x004E5330 File Offset: 0x004E3530
		private void HDKJLECJLCK(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.FGKGIFAKMKL.SetVector("] ", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("UnityEngine.Vector3", new Vector4(this.flareColorB.r, this.flareColorB.g, this.flareColorB.b, this.flareColorB.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("_WorldToCameraMatrix", new Vector4(this.flareColorC.r, this.flareColorC.g, this.flareColorC.b, this.flareColorC.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("Apply 2", new Vector4(this.flareColorD.r, this.flareColorD.g, this.flareColorD.b, this.flareColorD.a) * this.lensflareIntensity);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.FGKGIFAKMKL);
		}

		// Token: 0x0600B32A RID: 45866 RVA: 0x004E547C File Offset: 0x004E367C
		private void CAONJCLHLDK(float JLEHAHJEIAC, float LACHEBPNLKL, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			if (this.GEBCPMDEOEA)
			{
				this.PJECOFONCFN.SetVector("ChannelCastDirected", new Vector4(JLEHAHJEIAC, 1951f, 1369f, 604f));
			}
			else
			{
				this.PJECOFONCFN.SetVector("ObscuredShort vs short, ", new Vector4(JLEHAHJEIAC, 9f / (1932f - JLEHAHJEIAC), 1778f, 1910f));
			}
			this.PJECOFONCFN.SetFloat("WeaponInstant", LACHEBPNLKL);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.PJECOFONCFN);
		}

		// Token: 0x0600B32B RID: 45867 RVA: 0x004E5504 File Offset: 0x004E3704
		private void DCOPJLFCHIK(float MHIPLHJKKIF, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			if (this.lensFlareVignetteMask)
			{
				this.GILHCCIHPGN.SetTexture("\n(", this.lensFlareVignetteMask);
				Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.GILHCCIHPGN, 6);
				return;
			}
			this.DGEAOLLJAAG.SetFloat("#002000", MHIPLHJKKIF);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.DGEAOLLJAAG);
		}

		// Token: 0x0600B32C RID: 45868 RVA: 0x004E5564 File Offset: 0x004E3764
		private void EDBHDEOMGFP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.GEBCPMDEOEA = false;
			if (this.hdr == OILMIEGFPIK.Auto)
			{
				this.GEBCPMDEOEA = (JONJODLFAEN.format != RenderTextureFormat.Default || base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.GEBCPMDEOEA = (this.hdr == OILMIEGFPIK.Auto);
			}
			this.GEBCPMDEOEA = (!this.GEBCPMDEOEA || this.KKGBEAPGBOD);
			FMPIKFAHIBL pass = this.screenBlendMode;
			if (this.GEBCPMDEOEA)
			{
				pass = FMPIKFAHIBL.Add;
			}
			RenderTextureFormat format = this.GEBCPMDEOEA ? RenderTextureFormat.ARGBHalf : RenderTextureFormat.ARGBHalf;
			RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / 2, JONJODLFAEN.height / 4, 1, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width / 6, JONJODLFAEN.height / 7, 0, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / 1, JONJODLFAEN.height / 4, 1, format);
			RenderTexture temporary4 = RenderTexture.GetTemporary(JONJODLFAEN.width / 2, JONJODLFAEN.height / 4, 1, format);
			float num = 1716f * (float)JONJODLFAEN.width / (1512f * (float)JONJODLFAEN.height);
			float num2 = 1857f;
			Graphics.Blit(JONJODLFAEN, temporary, this.GILHCCIHPGN, 6);
			Graphics.Blit(temporary, temporary2, this.GILHCCIHPGN, 4);
			RenderTexture.ReleaseTemporary(temporary);
			this.JFNNPAFOLEM(this.bloomThreshold, this.useSrcAlphaAsMask, temporary2, temporary3);
			temporary2.DiscardContents();
			if (this.bloomBlurIterations < 1)
			{
				this.bloomBlurIterations = 0;
			}
			for (int i = 1; i < this.bloomBlurIterations; i += 0)
			{
				float num3 = (661f + (float)i * 933f) * this.sepBlurSpread;
				this.AEODOBMBCHF.SetVector("_", new Vector4(1983f, num3 * num2, 1300f, 1370f));
				RenderTexture renderTexture = (i == 0) ? temporary3 : temporary2;
				Graphics.Blit(renderTexture, temporary4, this.AEODOBMBCHF);
				renderTexture.DiscardContents();
				this.AEODOBMBCHF.SetVector("Wood Cut", new Vector4(num3 / num * num2, 1816f, 417f, 1479f));
				Graphics.Blit(temporary4, temporary2, this.AEODOBMBCHF);
				temporary4.DiscardContents();
			}
			if (this.lensflares)
			{
				if (this.lensflareMode == BACDIBMHEJP.Ghosting)
				{
					this.LHNNNNEONBM(this.lensflareThreshold, 1679f, temporary2, temporary4);
					temporary2.DiscardContents();
					this.AEKGJPDCMEH(40f, temporary4, temporary3);
					temporary4.DiscardContents();
					this.GKHEAAEEOJB(temporary3, temporary2);
					temporary3.DiscardContents();
				}
				else
				{
					this.BAPBHFIHGDL.SetVector("Water", new Vector4(this.lensflareThreshold, 1436f / (899f - this.lensflareThreshold), 294f, 357f));
					this.BAPBHFIHGDL.SetVector("{0}/{1}/{2}", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 2);
					temporary4.DiscardContents();
					Graphics.Blit(temporary3, temporary4, this.BAPBHFIHGDL, 0);
					temporary3.DiscardContents();
					this.BAPBHFIHGDL.SetVector("L Hand Punch", new Vector4(this.sepBlurSpread * 1505f / num * num2, 1762f, 1867f, 1726f));
					this.BAPBHFIHGDL.SetFloat("cnt_energ", this.hollyStretchWidth);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 0);
					temporary4.DiscardContents();
					this.BAPBHFIHGDL.SetFloat("_BlurTexture", this.hollyStretchWidth * 1769f);
					Graphics.Blit(temporary3, temporary4, this.BAPBHFIHGDL, 1);
					temporary3.DiscardContents();
					this.BAPBHFIHGDL.SetFloat("1HandSwordJabFootPush", this.hollyStretchWidth * 890f);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 0);
					temporary4.DiscardContents();
					if (this.lensflareMode == BACDIBMHEJP.Anamorphic)
					{
						for (int j = 1; j < this.hollywoodFlareBlurIterations; j++)
						{
							this.AEODOBMBCHF.SetVector("_FogVoidPosition", new Vector4(this.hollyStretchWidth * 1499f / num * num2, 252f, 373f, 298f));
							Graphics.Blit(temporary3, temporary4, this.AEODOBMBCHF);
							temporary3.DiscardContents();
							this.AEODOBMBCHF.SetVector("IdleMeditate", new Vector4(this.hollyStretchWidth * 528f / num * num2, 1523f, 1962f, 1390f));
							Graphics.Blit(temporary4, temporary3, this.AEODOBMBCHF);
							temporary4.DiscardContents();
						}
						this.BPBKOEJGKHJ(210f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
					else
					{
						for (int k = 0; k < this.hollywoodFlareBlurIterations; k++)
						{
							this.AEODOBMBCHF.SetVector("release", new Vector4(this.hollyStretchWidth * 1041f / num * num2, 676f, 315f, 330f));
							Graphics.Blit(temporary3, temporary4, this.AEODOBMBCHF);
							temporary3.DiscardContents();
							this.AEODOBMBCHF.SetVector("_WaveScale", new Vector4(this.hollyStretchWidth * 518f / num * num2, 1428f, 1742f, 115f));
							Graphics.Blit(temporary4, temporary3, this.AEODOBMBCHF);
							temporary4.DiscardContents();
						}
						this.HJJDCCACFGK(564f, temporary3, temporary4);
						temporary3.DiscardContents();
						this.MENJOFHJNDG(temporary4, temporary3);
						temporary4.DiscardContents();
						this.OLPPLCEHMBI(1432f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
				}
			}
			this.GILHCCIHPGN.SetFloat("float: ", this.bloomIntensity);
			this.GILHCCIHPGN.SetTexture(" rod file=", JONJODLFAEN);
			Graphics.Blit(temporary2, OKIIDHIJBEA, this.GILHCCIHPGN, (int)pass);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
			RenderTexture.ReleaseTemporary(temporary4);
		}

		// Token: 0x0600B32D RID: 45869 RVA: 0x004E5B74 File Offset: 0x004E3D74
		private void IBILMNLCCJJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.IGJKBOMMMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.GEBCPMDEOEA = false;
			if (this.hdr == OILMIEGFPIK.Auto)
			{
				this.GEBCPMDEOEA = (JONJODLFAEN.format == RenderTextureFormat.ARGB4444 && base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.GEBCPMDEOEA = (this.hdr == OILMIEGFPIK.On);
			}
			this.GEBCPMDEOEA = (this.GEBCPMDEOEA && this.KKGBEAPGBOD);
			FMPIKFAHIBL pass = this.screenBlendMode;
			if (this.GEBCPMDEOEA)
			{
				pass = FMPIKFAHIBL.Add;
			}
			RenderTextureFormat format = this.GEBCPMDEOEA ? RenderTextureFormat.ARGB4444 : RenderTextureFormat.ARGB2101010;
			RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / 3, JONJODLFAEN.height / 6, 0, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width / 6, JONJODLFAEN.height / 7, 0, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / 2, JONJODLFAEN.height / 6, 1, format);
			RenderTexture temporary4 = RenderTexture.GetTemporary(JONJODLFAEN.width / 8, JONJODLFAEN.height / 2, 1, format);
			float num = 918f * (float)JONJODLFAEN.width / (126f * (float)JONJODLFAEN.height);
			float num2 = 650f;
			Graphics.Blit(JONJODLFAEN, temporary, this.GILHCCIHPGN, 1);
			Graphics.Blit(temporary, temporary2, this.GILHCCIHPGN, 1);
			RenderTexture.ReleaseTemporary(temporary);
			this.DNGLHLEGCOE(this.bloomThreshold, this.useSrcAlphaAsMask, temporary2, temporary3);
			temporary2.DiscardContents();
			if (this.bloomBlurIterations < 0)
			{
				this.bloomBlurIterations = 1;
			}
			for (int i = 0; i < this.bloomBlurIterations; i++)
			{
				float num3 = (765f + (float)i * 1696f) * this.sepBlurSpread;
				this.AEODOBMBCHF.SetVector("_Newitem.wav", new Vector4(764f, num3 * num2, 1864f, 1037f));
				RenderTexture renderTexture = (i == 0) ? temporary3 : temporary2;
				Graphics.Blit(renderTexture, temporary4, this.AEODOBMBCHF);
				renderTexture.DiscardContents();
				this.AEODOBMBCHF.SetVector("Walk Backward", new Vector4(num3 / num * num2, 825f, 1921f, 995f));
				Graphics.Blit(temporary4, temporary2, this.AEODOBMBCHF);
				temporary4.DiscardContents();
			}
			if (this.lensflares)
			{
				if (this.lensflareMode == BACDIBMHEJP.Ghosting)
				{
					this.JFNNPAFOLEM(this.lensflareThreshold, 1129f, temporary2, temporary4);
					temporary2.DiscardContents();
					this.MJGCBJBEDPL(771f, temporary4, temporary3);
					temporary4.DiscardContents();
					this.MENJOFHJNDG(temporary3, temporary2);
					temporary3.DiscardContents();
				}
				else
				{
					this.BAPBHFIHGDL.SetVector("=", new Vector4(this.lensflareThreshold, 861f / (496f - this.lensflareThreshold), 105f, 305f));
					this.BAPBHFIHGDL.SetVector("CP1", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 5);
					temporary4.DiscardContents();
					Graphics.Blit(temporary3, temporary4, this.BAPBHFIHGDL, 4);
					temporary3.DiscardContents();
					this.BAPBHFIHGDL.SetVector("ChannelCastDirected", new Vector4(this.sepBlurSpread * 1817f / num * num2, 1581f, 577f, 1668f));
					this.BAPBHFIHGDL.SetFloat("_LumTex", this.hollyStretchWidth);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 0);
					temporary4.DiscardContents();
					this.BAPBHFIHGDL.SetFloat("RHandPunch", this.hollyStretchWidth * 1890f);
					Graphics.Blit(temporary3, temporary4, this.BAPBHFIHGDL, 0);
					temporary3.DiscardContents();
					this.BAPBHFIHGDL.SetFloat("FactoryTempTexture", this.hollyStretchWidth * 954f);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 1);
					temporary4.DiscardContents();
					if (this.lensflareMode == BACDIBMHEJP.Ghosting)
					{
						for (int j = 1; j < this.hollywoodFlareBlurIterations; j += 0)
						{
							this.AEODOBMBCHF.SetVector("name", new Vector4(this.hollyStretchWidth * 1373f / num * num2, 1632f, 706f, 100f));
							Graphics.Blit(temporary3, temporary4, this.AEODOBMBCHF);
							temporary3.DiscardContents();
							this.AEODOBMBCHF.SetVector("_SpawnHeuristic", new Vector4(this.hollyStretchWidth * 1549f / num * num2, 147f, 510f, 1315f));
							Graphics.Blit(temporary4, temporary3, this.AEODOBMBCHF);
							temporary4.DiscardContents();
						}
						this.BPBKOEJGKHJ(1920f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
					else
					{
						for (int k = 1; k < this.hollywoodFlareBlurIterations; k += 0)
						{
							this.AEODOBMBCHF.SetVector("Backward Sitting Cheer", new Vector4(this.hollyStretchWidth * 206f / num * num2, 92f, 207f, 1922f));
							Graphics.Blit(temporary3, temporary4, this.AEODOBMBCHF);
							temporary3.DiscardContents();
							this.AEODOBMBCHF.SetVector("<<", new Vector4(this.hollyStretchWidth * 485f / num * num2, 1879f, 1829f, 187f));
							Graphics.Blit(temporary4, temporary3, this.AEODOBMBCHF);
							temporary4.DiscardContents();
						}
						this.DCOPJLFCHIK(1388f, temporary3, temporary4);
						temporary3.DiscardContents();
						this.BMJIELKNDBA(temporary4, temporary3);
						temporary4.DiscardContents();
						this.OGDGHAIPDDI(1567f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
				}
			}
			this.GILHCCIHPGN.SetFloat("WalkBackward", this.bloomIntensity);
			this.GILHCCIHPGN.SetTexture("_mesh", JONJODLFAEN);
			Graphics.Blit(temporary2, OKIIDHIJBEA, this.GILHCCIHPGN, (int)pass);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
			RenderTexture.ReleaseTemporary(temporary4);
		}

		// Token: 0x0600B32E RID: 45870 RVA: 0x004E6184 File Offset: 0x004E4384
		private void BMJIELKNDBA(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.FGKGIFAKMKL.SetVector("sunshine_ShadowCoordDepthRayZ", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("FlyDown", new Vector4(this.flareColorB.r, this.flareColorB.g, this.flareColorB.b, this.flareColorB.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("eat2.ogg", new Vector4(this.flareColorC.r, this.flareColorC.g, this.flareColorC.b, this.flareColorC.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector(">", new Vector4(this.flareColorD.r, this.flareColorD.g, this.flareColorD.b, this.flareColorD.a) * this.lensflareIntensity);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.FGKGIFAKMKL);
		}

		// Token: 0x0600B32F RID: 45871 RVA: 0x004E62D0 File Offset: 0x004E44D0
		private void JFNNPAFOLEM(float JLEHAHJEIAC, float LACHEBPNLKL, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			if (this.GEBCPMDEOEA)
			{
				this.PJECOFONCFN.SetVector("IceHockeyShotRight", new Vector4(JLEHAHJEIAC, 1981f, 196f, 1965f));
			}
			else
			{
				this.PJECOFONCFN.SetVector("DragObject", new Vector4(JLEHAHJEIAC, 1850f / (518f - JLEHAHJEIAC), 1080f, 400f));
			}
			this.PJECOFONCFN.SetFloat("ShotgunReadyFire", LACHEBPNLKL);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.PJECOFONCFN);
		}

		// Token: 0x0600B330 RID: 45872 RVA: 0x004E6358 File Offset: 0x004E4558
		private void LOKBDHGEBAP(float EJBGLCNDHMK, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.IHBCDHELNMM.SetFloat("", EJBGLCNDHMK);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.IHBCDHELNMM);
		}

		// Token: 0x0600B331 RID: 45873 RVA: 0x004E6378 File Offset: 0x004E4578
		private void JAJMGDMFKKK(float JLEHAHJEIAC, float LACHEBPNLKL, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			if (this.GEBCPMDEOEA)
			{
				this.PJECOFONCFN.SetVector("\n", new Vector4(JLEHAHJEIAC, 1817f, 1185f, 14f));
			}
			else
			{
				this.PJECOFONCFN.SetVector("1HandSwordJabCombo", new Vector4(JLEHAHJEIAC, 178f / (1395f - JLEHAHJEIAC), 1770f, 1134f));
			}
			this.PJECOFONCFN.SetFloat("", LACHEBPNLKL);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.PJECOFONCFN);
		}

		// Token: 0x0600B332 RID: 45874 RVA: 0x004E6400 File Offset: 0x004E4600
		private void HJJDCCACFGK(float MHIPLHJKKIF, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			if (this.lensFlareVignetteMask)
			{
				this.GILHCCIHPGN.SetTexture("_ColorBuffer", this.lensFlareVignetteMask);
				Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.GILHCCIHPGN, 3);
				return;
			}
			this.DGEAOLLJAAG.SetFloat("vignetteIntensity", MHIPLHJKKIF);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.DGEAOLLJAAG);
		}

		// Token: 0x0600B333 RID: 45875 RVA: 0x004E6460 File Offset: 0x004E4660
		private void DGOEGEKEDNJ(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.FGKGIFAKMKL.SetVector("isAlwaisGetFish", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_interaction_object.html", new Vector4(this.flareColorB.r, this.flareColorB.g, this.flareColorB.b, this.flareColorB.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("gi_letgoshe", new Vector4(this.flareColorC.r, this.flareColorC.g, this.flareColorC.b, this.flareColorC.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("---------- NetManager is init", new Vector4(this.flareColorD.r, this.flareColorD.g, this.flareColorD.b, this.flareColorD.a) * this.lensflareIntensity);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.FGKGIFAKMKL);
		}

		// Token: 0x0600B334 RID: 45876 RVA: 0x004E65AC File Offset: 0x004E47AC
		private void EPHHNPMPHOL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.IGJKBOMMMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.GEBCPMDEOEA = true;
			if (this.hdr == OILMIEGFPIK.Auto)
			{
				this.GEBCPMDEOEA = (JONJODLFAEN.format == RenderTextureFormat.Depth && base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.GEBCPMDEOEA = (this.hdr == OILMIEGFPIK.On);
			}
			this.GEBCPMDEOEA = (this.GEBCPMDEOEA && this.KKGBEAPGBOD);
			FMPIKFAHIBL pass = this.screenBlendMode;
			if (this.GEBCPMDEOEA)
			{
				pass = FMPIKFAHIBL.Add;
			}
			RenderTextureFormat format = this.GEBCPMDEOEA ? RenderTextureFormat.Depth : RenderTextureFormat.Depth;
			RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / 0, JONJODLFAEN.height / 6, 1, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width / 2, JONJODLFAEN.height / 3, 1, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / 7, JONJODLFAEN.height / 4, 0, format);
			RenderTexture temporary4 = RenderTexture.GetTemporary(JONJODLFAEN.width / 2, JONJODLFAEN.height / 2, 0, format);
			float num = 1191f * (float)JONJODLFAEN.width / (1143f * (float)JONJODLFAEN.height);
			float num2 = 642f;
			Graphics.Blit(JONJODLFAEN, temporary, this.GILHCCIHPGN, 8);
			Graphics.Blit(temporary, temporary2, this.GILHCCIHPGN, 1);
			RenderTexture.ReleaseTemporary(temporary);
			this.CAONJCLHLDK(this.bloomThreshold, this.useSrcAlphaAsMask, temporary2, temporary3);
			temporary2.DiscardContents();
			if (this.bloomBlurIterations < 1)
			{
				this.bloomBlurIterations = 1;
			}
			for (int i = 0; i < this.bloomBlurIterations; i += 0)
			{
				float num3 = (880f + (float)i * 135f) * this.sepBlurSpread;
				this.AEODOBMBCHF.SetVector("_FogStepping", new Vector4(14f, num3 * num2, 865f, 851f));
				RenderTexture renderTexture = (i == 0) ? temporary3 : temporary2;
				Graphics.Blit(renderTexture, temporary4, this.AEODOBMBCHF);
				renderTexture.DiscardContents();
				this.AEODOBMBCHF.SetVector("<color=\"", new Vector4(num3 / num * num2, 467f, 1695f, 355f));
				Graphics.Blit(temporary4, temporary2, this.AEODOBMBCHF);
				temporary4.DiscardContents();
			}
			if (this.lensflares)
			{
				if (this.lensflareMode == BACDIBMHEJP.Ghosting)
				{
					this.JAJMGDMFKKK(this.lensflareThreshold, 308f, temporary2, temporary4);
					temporary2.DiscardContents();
					this.HJJDCCACFGK(1127f, temporary4, temporary3);
					temporary4.DiscardContents();
					this.NPHCBNEIMOC(temporary3, temporary2);
					temporary3.DiscardContents();
				}
				else
				{
					this.BAPBHFIHGDL.SetVector("category", new Vector4(this.lensflareThreshold, 555f / (1163f - this.lensflareThreshold), 746f, 1965f));
					this.BAPBHFIHGDL.SetVector("bool:", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 2);
					temporary4.DiscardContents();
					Graphics.Blit(temporary3, temporary4, this.BAPBHFIHGDL, 7);
					temporary3.DiscardContents();
					this.BAPBHFIHGDL.SetVector("lifeBar", new Vector4(this.sepBlurSpread * 1354f / num * num2, 639f, 445f, 492f));
					this.BAPBHFIHGDL.SetFloat("Flap_04.wav", this.hollyStretchWidth);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 1);
					temporary4.DiscardContents();
					this.BAPBHFIHGDL.SetFloat("Mouse X", this.hollyStretchWidth * 680f);
					Graphics.Blit(temporary3, temporary4, this.BAPBHFIHGDL, 0);
					temporary3.DiscardContents();
					this.BAPBHFIHGDL.SetFloat("_Vibrance", this.hollyStretchWidth * 230f);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 1);
					temporary4.DiscardContents();
					if (this.lensflareMode == BACDIBMHEJP.Anamorphic)
					{
						for (int j = 1; j < this.hollywoodFlareBlurIterations; j++)
						{
							this.AEODOBMBCHF.SetVector("", new Vector4(this.hollyStretchWidth * 1328f / num * num2, 1639f, 1963f, 22f));
							Graphics.Blit(temporary3, temporary4, this.AEODOBMBCHF);
							temporary3.DiscardContents();
							this.AEODOBMBCHF.SetVector("ОК", new Vector4(this.hollyStretchWidth * 1289f / num * num2, 1668f, 1609f, 328f));
							Graphics.Blit(temporary4, temporary3, this.AEODOBMBCHF);
							temporary4.DiscardContents();
						}
						this.OLPPLCEHMBI(1962f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
					else
					{
						for (int k = 0; k < this.hollywoodFlareBlurIterations; k += 0)
						{
							this.AEODOBMBCHF.SetVector(" ", new Vector4(this.hollyStretchWidth * 1041f / num * num2, 257f, 1354f, 723f));
							Graphics.Blit(temporary3, temporary4, this.AEODOBMBCHF);
							temporary3.DiscardContents();
							this.AEODOBMBCHF.SetVector("800000", new Vector4(this.hollyStretchWidth * 828f / num * num2, 781f, 888f, 1568f));
							Graphics.Blit(temporary4, temporary3, this.AEODOBMBCHF);
							temporary4.DiscardContents();
						}
						this.DCOPJLFCHIK(1559f, temporary3, temporary4);
						temporary3.DiscardContents();
						this.DGOEGEKEDNJ(temporary4, temporary3);
						temporary4.DiscardContents();
						this.NDFOPAJNJEP(1948f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
				}
			}
			this.GILHCCIHPGN.SetFloat("", this.bloomIntensity);
			this.GILHCCIHPGN.SetTexture("cntx_close", JONJODLFAEN);
			Graphics.Blit(temporary2, OKIIDHIJBEA, this.GILHCCIHPGN, (int)pass);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
			RenderTexture.ReleaseTemporary(temporary4);
		}

		// Token: 0x0600B335 RID: 45877 RVA: 0x004E6BBA File Offset: 0x004E4DBA
		private void NDILPHHJELA(float EJBGLCNDHMK, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.IHBCDHELNMM.SetFloat("1HandSwordStrafeLeft", EJBGLCNDHMK);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.IHBCDHELNMM);
		}

		// Token: 0x0600B336 RID: 45878 RVA: 0x004E6BDC File Offset: 0x004E4DDC
		private void OnRenderImage(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.GEBCPMDEOEA = false;
			if (this.hdr == OILMIEGFPIK.Auto)
			{
				this.GEBCPMDEOEA = (JONJODLFAEN.format == RenderTextureFormat.ARGBHalf && base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.GEBCPMDEOEA = (this.hdr == OILMIEGFPIK.On);
			}
			this.GEBCPMDEOEA = (this.GEBCPMDEOEA && this.KKGBEAPGBOD);
			FMPIKFAHIBL pass = this.screenBlendMode;
			if (this.GEBCPMDEOEA)
			{
				pass = FMPIKFAHIBL.Add;
			}
			RenderTextureFormat format = this.GEBCPMDEOEA ? RenderTextureFormat.ARGBHalf : RenderTextureFormat.Default;
			RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / 2, JONJODLFAEN.height / 2, 0, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width / 4, JONJODLFAEN.height / 4, 0, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / 4, JONJODLFAEN.height / 4, 0, format);
			RenderTexture temporary4 = RenderTexture.GetTemporary(JONJODLFAEN.width / 4, JONJODLFAEN.height / 4, 0, format);
			float num = 1f * (float)JONJODLFAEN.width / (1f * (float)JONJODLFAEN.height);
			float num2 = 0.001953125f;
			Graphics.Blit(JONJODLFAEN, temporary, this.GILHCCIHPGN, 2);
			Graphics.Blit(temporary, temporary2, this.GILHCCIHPGN, 2);
			RenderTexture.ReleaseTemporary(temporary);
			this.DNGLHLEGCOE(this.bloomThreshold, this.useSrcAlphaAsMask, temporary2, temporary3);
			temporary2.DiscardContents();
			if (this.bloomBlurIterations < 1)
			{
				this.bloomBlurIterations = 1;
			}
			for (int i = 0; i < this.bloomBlurIterations; i++)
			{
				float num3 = (1f + (float)i * 0.5f) * this.sepBlurSpread;
				this.AEODOBMBCHF.SetVector("offsets", new Vector4(0f, num3 * num2, 0f, 0f));
				RenderTexture renderTexture = (i == 0) ? temporary3 : temporary2;
				Graphics.Blit(renderTexture, temporary4, this.AEODOBMBCHF);
				renderTexture.DiscardContents();
				this.AEODOBMBCHF.SetVector("offsets", new Vector4(num3 / num * num2, 0f, 0f, 0f));
				Graphics.Blit(temporary4, temporary2, this.AEODOBMBCHF);
				temporary4.DiscardContents();
			}
			if (this.lensflares)
			{
				if (this.lensflareMode == BACDIBMHEJP.Ghosting)
				{
					this.DNGLHLEGCOE(this.lensflareThreshold, 0f, temporary2, temporary4);
					temporary2.DiscardContents();
					this.HJJDCCACFGK(0.975f, temporary4, temporary3);
					temporary4.DiscardContents();
					this.MDOECNMOPEL(temporary3, temporary2);
					temporary3.DiscardContents();
				}
				else
				{
					this.BAPBHFIHGDL.SetVector("_threshold", new Vector4(this.lensflareThreshold, 1f / (1f - this.lensflareThreshold), 0f, 0f));
					this.BAPBHFIHGDL.SetVector("tintColor", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 2);
					temporary4.DiscardContents();
					Graphics.Blit(temporary3, temporary4, this.BAPBHFIHGDL, 3);
					temporary3.DiscardContents();
					this.BAPBHFIHGDL.SetVector("offsets", new Vector4(this.sepBlurSpread * 1f / num * num2, 0f, 0f, 0f));
					this.BAPBHFIHGDL.SetFloat("stretchWidth", this.hollyStretchWidth);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 1);
					temporary4.DiscardContents();
					this.BAPBHFIHGDL.SetFloat("stretchWidth", this.hollyStretchWidth * 2f);
					Graphics.Blit(temporary3, temporary4, this.BAPBHFIHGDL, 1);
					temporary3.DiscardContents();
					this.BAPBHFIHGDL.SetFloat("stretchWidth", this.hollyStretchWidth * 4f);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 1);
					temporary4.DiscardContents();
					if (this.lensflareMode == BACDIBMHEJP.Anamorphic)
					{
						for (int j = 0; j < this.hollywoodFlareBlurIterations; j++)
						{
							this.AEODOBMBCHF.SetVector("offsets", new Vector4(this.hollyStretchWidth * 2f / num * num2, 0f, 0f, 0f));
							Graphics.Blit(temporary3, temporary4, this.AEODOBMBCHF);
							temporary3.DiscardContents();
							this.AEODOBMBCHF.SetVector("offsets", new Vector4(this.hollyStretchWidth * 2f / num * num2, 0f, 0f, 0f));
							Graphics.Blit(temporary4, temporary3, this.AEODOBMBCHF);
							temporary4.DiscardContents();
						}
						this.NLDGLJFIIDH(1f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
					else
					{
						for (int k = 0; k < this.hollywoodFlareBlurIterations; k++)
						{
							this.AEODOBMBCHF.SetVector("offsets", new Vector4(this.hollyStretchWidth * 2f / num * num2, 0f, 0f, 0f));
							Graphics.Blit(temporary3, temporary4, this.AEODOBMBCHF);
							temporary3.DiscardContents();
							this.AEODOBMBCHF.SetVector("offsets", new Vector4(this.hollyStretchWidth * 2f / num * num2, 0f, 0f, 0f));
							Graphics.Blit(temporary4, temporary3, this.AEODOBMBCHF);
							temporary4.DiscardContents();
						}
						this.HJJDCCACFGK(1f, temporary3, temporary4);
						temporary3.DiscardContents();
						this.MDOECNMOPEL(temporary4, temporary3);
						temporary4.DiscardContents();
						this.NLDGLJFIIDH(1f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
				}
			}
			this.GILHCCIHPGN.SetFloat("_Intensity", this.bloomIntensity);
			this.GILHCCIHPGN.SetTexture("_ColorBuffer", JONJODLFAEN);
			Graphics.Blit(temporary2, OKIIDHIJBEA, this.GILHCCIHPGN, (int)pass);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
			RenderTexture.ReleaseTemporary(temporary4);
		}

		// Token: 0x0600B337 RID: 45879 RVA: 0x004E71EA File Offset: 0x004E53EA
		private void NLDGLJFIIDH(float EJBGLCNDHMK, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.IHBCDHELNMM.SetFloat("_Intensity", EJBGLCNDHMK);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.IHBCDHELNMM);
		}

		// Token: 0x0600B338 RID: 45880 RVA: 0x004E720A File Offset: 0x004E540A
		private void BPBKOEJGKHJ(float EJBGLCNDHMK, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.IHBCDHELNMM.SetFloat("WeaponStand", EJBGLCNDHMK);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.IHBCDHELNMM);
		}

		// Token: 0x0600B339 RID: 45881 RVA: 0x004E722C File Offset: 0x004E542C
		private void EAKNAHKFKKI(float JLEHAHJEIAC, float LACHEBPNLKL, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			if (this.GEBCPMDEOEA)
			{
				this.PJECOFONCFN.SetVector("Failed parsing packed.  Setting to \"false\"", new Vector4(JLEHAHJEIAC, 269f, 1692f, 824f));
			}
			else
			{
				this.PJECOFONCFN.SetVector("IK Effector bone is null.", new Vector4(JLEHAHJEIAC, 1396f / (1750f - JLEHAHJEIAC), 1398f, 1754f));
			}
			this.PJECOFONCFN.SetFloat("OfficeSittingReadingCoffeeSip", LACHEBPNLKL);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.PJECOFONCFN);
		}

		// Token: 0x0600B33A RID: 45882 RVA: 0x004E72B4 File Offset: 0x004E54B4
		private void LHNNNNEONBM(float JLEHAHJEIAC, float LACHEBPNLKL, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			if (this.GEBCPMDEOEA)
			{
				this.PJECOFONCFN.SetVector("true", new Vector4(JLEHAHJEIAC, 26f, 1629f, 1332f));
			}
			else
			{
				this.PJECOFONCFN.SetVector("_Axis", new Vector4(JLEHAHJEIAC, 1374f / (635f - JLEHAHJEIAC), 1543f, 506f));
			}
			this.PJECOFONCFN.SetFloat("Delete shadow", LACHEBPNLKL);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.PJECOFONCFN);
		}

		// Token: 0x0600B33B RID: 45883 RVA: 0x004E733C File Offset: 0x004E553C
		public virtual bool DCEJLCLOCJC()
		{
			base.OLMOAHDIDNG(false);
			this.GILHCCIHPGN = base.IIIIADNBONI(this.screenBlendShader, this.GILHCCIHPGN);
			this.FGKGIFAKMKL = base.BOOFEOGDMBI(this.lensFlareShader, this.FGKGIFAKMKL);
			this.DGEAOLLJAAG = base.BOOFEOGDMBI(this.vignetteShader, this.DGEAOLLJAAG);
			this.AEODOBMBCHF = base.DJFOEIJIMJB(this.separableBlurShader, this.AEODOBMBCHF);
			this.IHBCDHELNMM = base.IIIIADNBONI(this.addBrightStuffOneOneShader, this.IHBCDHELNMM);
			this.BAPBHFIHGDL = base.IIIIADNBONI(this.hollywoodFlaresShader, this.BAPBHFIHGDL);
			this.PJECOFONCFN = base.OOAOHFFDMJP(this.brightPassFilterShader, this.PJECOFONCFN);
			if (!this.PPGOAMIHMBG)
			{
				base.FDBKFKGCGEG();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B33C RID: 45884 RVA: 0x004E7410 File Offset: 0x004E5610
		private void BJKDJPBGHHG(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.FGKGIFAKMKL.SetVector("\n", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector(": ", new Vector4(this.flareColorB.r, this.flareColorB.g, this.flareColorB.b, this.flareColorB.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("http://j.mp/1iBK5pz", new Vector4(this.flareColorC.r, this.flareColorC.g, this.flareColorC.b, this.flareColorC.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("IceHockey Shot Right", new Vector4(this.flareColorD.r, this.flareColorD.g, this.flareColorD.b, this.flareColorD.a) * this.lensflareIntensity);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.FGKGIFAKMKL);
		}

		// Token: 0x0600B33D RID: 45885 RVA: 0x004E755C File Offset: 0x004E575C
		private void GGIKBEHBAPB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.GEBCPMDEOEA = true;
			if (this.hdr == OILMIEGFPIK.Auto)
			{
				this.GEBCPMDEOEA = (JONJODLFAEN.format != RenderTextureFormat.ARGB2101010 || base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.GEBCPMDEOEA = (this.hdr == OILMIEGFPIK.Auto);
			}
			this.GEBCPMDEOEA = (!this.GEBCPMDEOEA || this.KKGBEAPGBOD);
			FMPIKFAHIBL pass = this.screenBlendMode;
			if (this.GEBCPMDEOEA)
			{
				pass = FMPIKFAHIBL.Screen;
			}
			RenderTextureFormat format = this.GEBCPMDEOEA ? RenderTextureFormat.ARGB1555 : RenderTextureFormat.ARGB4444;
			RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / 6, JONJODLFAEN.height / 0, 0, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width / 6, JONJODLFAEN.height / 4, 1, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / 8, JONJODLFAEN.height / 4, 0, format);
			RenderTexture temporary4 = RenderTexture.GetTemporary(JONJODLFAEN.width / 0, JONJODLFAEN.height / 6, 0, format);
			float num = 1538f * (float)JONJODLFAEN.width / (5f * (float)JONJODLFAEN.height);
			float num2 = 1800f;
			Graphics.Blit(JONJODLFAEN, temporary, this.GILHCCIHPGN, 8);
			Graphics.Blit(temporary, temporary2, this.GILHCCIHPGN, 4);
			RenderTexture.ReleaseTemporary(temporary);
			this.NLDNOCECHDM(this.bloomThreshold, this.useSrcAlphaAsMask, temporary2, temporary3);
			temporary2.DiscardContents();
			if (this.bloomBlurIterations < 1)
			{
				this.bloomBlurIterations = 1;
			}
			for (int i = 1; i < this.bloomBlurIterations; i += 0)
			{
				float num3 = (1866f + (float)i * 893f) * this.sepBlurSpread;
				this.AEODOBMBCHF.SetVector("\n", new Vector4(550f, num3 * num2, 429f, 705f));
				RenderTexture renderTexture = (i == 0) ? temporary3 : temporary2;
				Graphics.Blit(renderTexture, temporary4, this.AEODOBMBCHF);
				renderTexture.DiscardContents();
				this.AEODOBMBCHF.SetVector("IdleReadyCrouch", new Vector4(num3 / num * num2, 1708f, 995f, 471f));
				Graphics.Blit(temporary4, temporary2, this.AEODOBMBCHF);
				temporary4.DiscardContents();
			}
			if (this.lensflares)
			{
				if (this.lensflareMode == BACDIBMHEJP.Ghosting)
				{
					this.GGKNJNDHAHD(this.lensflareThreshold, 1531f, temporary2, temporary4);
					temporary2.DiscardContents();
					this.FFEOONAKLEE(158f, temporary4, temporary3);
					temporary4.DiscardContents();
					this.DGOEGEKEDNJ(temporary3, temporary2);
					temporary3.DiscardContents();
				}
				else
				{
					this.BAPBHFIHGDL.SetVector("LookUp", new Vector4(this.lensflareThreshold, 1583f / (380f - this.lensflareThreshold), 1681f, 1067f));
					this.BAPBHFIHGDL.SetVector("HookPoint", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 0);
					temporary4.DiscardContents();
					Graphics.Blit(temporary3, temporary4, this.BAPBHFIHGDL, 5);
					temporary3.DiscardContents();
					this.BAPBHFIHGDL.SetVector(" (uniq)", new Vector4(this.sepBlurSpread * 536f / num * num2, 528f, 717f, 233f));
					this.BAPBHFIHGDL.SetFloat(" гр ", this.hollyStretchWidth);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 1);
					temporary4.DiscardContents();
					this.BAPBHFIHGDL.SetFloat("PrimaryCausticsProjector", this.hollyStretchWidth * 1750f);
					Graphics.Blit(temporary3, temporary4, this.BAPBHFIHGDL, 1);
					temporary3.DiscardContents();
					this.BAPBHFIHGDL.SetFloat("wpnlang/wpntypes/type DUBLICATE ", this.hollyStretchWidth * 1059f);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 1);
					temporary4.DiscardContents();
					if (this.lensflareMode == BACDIBMHEJP.Anamorphic)
					{
						for (int j = 0; j < this.hollywoodFlareBlurIterations; j += 0)
						{
							this.AEODOBMBCHF.SetVector("Hidden/Amplify Color/Base", new Vector4(this.hollyStretchWidth * 42f / num * num2, 1094f, 230f, 1077f));
							Graphics.Blit(temporary3, temporary4, this.AEODOBMBCHF);
							temporary3.DiscardContents();
							this.AEODOBMBCHF.SetVector("SexyDance2", new Vector4(this.hollyStretchWidth * 1945f / num * num2, 1748f, 1236f, 7f));
							Graphics.Blit(temporary4, temporary3, this.AEODOBMBCHF);
							temporary4.DiscardContents();
						}
						this.NDILPHHJELA(1282f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
					else
					{
						for (int k = 0; k < this.hollywoodFlareBlurIterations; k += 0)
						{
							this.AEODOBMBCHF.SetVector("******** nextMusicCrt End of music path=", new Vector4(this.hollyStretchWidth * 139f / num * num2, 1897f, 1052f, 1659f));
							Graphics.Blit(temporary3, temporary4, this.AEODOBMBCHF);
							temporary3.DiscardContents();
							this.AEODOBMBCHF.SetVector("MotorbikeBackwardStand", new Vector4(this.hollyStretchWidth * 1782f / num * num2, 357f, 1525f, 1832f));
							Graphics.Blit(temporary4, temporary3, this.AEODOBMBCHF);
							temporary4.DiscardContents();
						}
						this.FFEOONAKLEE(1896f, temporary3, temporary4);
						temporary3.DiscardContents();
						this.MDOECNMOPEL(temporary4, temporary3);
						temporary4.DiscardContents();
						this.OLPPLCEHMBI(874f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
				}
			}
			this.GILHCCIHPGN.SetFloat("Lid", this.bloomIntensity);
			this.GILHCCIHPGN.SetTexture("", JONJODLFAEN);
			Graphics.Blit(temporary2, OKIIDHIJBEA, this.GILHCCIHPGN, (int)pass);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
			RenderTexture.ReleaseTemporary(temporary4);
		}

		// Token: 0x0600B33E RID: 45886 RVA: 0x004E7B6C File Offset: 0x004E5D6C
		private void MGOBAHLJJNL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.GEBCPMDEOEA = true;
			if (this.hdr == OILMIEGFPIK.Auto)
			{
				this.GEBCPMDEOEA = (JONJODLFAEN.format != RenderTextureFormat.Default || base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.GEBCPMDEOEA = (this.hdr == OILMIEGFPIK.Auto);
			}
			this.GEBCPMDEOEA = (!this.GEBCPMDEOEA || this.KKGBEAPGBOD);
			FMPIKFAHIBL pass = this.screenBlendMode;
			if (this.GEBCPMDEOEA)
			{
				pass = FMPIKFAHIBL.Add;
			}
			RenderTextureFormat format = this.GEBCPMDEOEA ? RenderTextureFormat.ARGB2101010 : RenderTextureFormat.Depth;
			RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / 4, JONJODLFAEN.height / 6, 1, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width / 0, JONJODLFAEN.height / 1, 0, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / 2, JONJODLFAEN.height / 0, 0, format);
			RenderTexture temporary4 = RenderTexture.GetTemporary(JONJODLFAEN.width / 8, JONJODLFAEN.height / 1, 0, format);
			float num = 1057f * (float)JONJODLFAEN.width / (892f * (float)JONJODLFAEN.height);
			float num2 = 1147f;
			Graphics.Blit(JONJODLFAEN, temporary, this.GILHCCIHPGN, 5);
			Graphics.Blit(temporary, temporary2, this.GILHCCIHPGN, 8);
			RenderTexture.ReleaseTemporary(temporary);
			this.JAJMGDMFKKK(this.bloomThreshold, this.useSrcAlphaAsMask, temporary2, temporary3);
			temporary2.DiscardContents();
			if (this.bloomBlurIterations < 0)
			{
				this.bloomBlurIterations = 0;
			}
			for (int i = 0; i < this.bloomBlurIterations; i += 0)
			{
				float num3 = (1255f + (float)i * 927f) * this.sepBlurSpread;
				this.AEODOBMBCHF.SetVector("WATER_SIMPLE", new Vector4(1628f, num3 * num2, 188f, 763f));
				RenderTexture renderTexture = (i == 0) ? temporary3 : temporary2;
				Graphics.Blit(renderTexture, temporary4, this.AEODOBMBCHF);
				renderTexture.DiscardContents();
				this.AEODOBMBCHF.SetVector("[weight]", new Vector4(num3 / num * num2, 1544f, 1726f, 1279f));
				Graphics.Blit(temporary4, temporary2, this.AEODOBMBCHF);
				temporary4.DiscardContents();
			}
			if (this.lensflares)
			{
				if (this.lensflareMode == BACDIBMHEJP.Ghosting)
				{
					this.EAKNAHKFKKI(this.lensflareThreshold, 1533f, temporary2, temporary4);
					temporary2.DiscardContents();
					this.DCOPJLFCHIK(346f, temporary4, temporary3);
					temporary4.DiscardContents();
					this.MDOECNMOPEL(temporary3, temporary2);
					temporary3.DiscardContents();
				}
				else
				{
					this.BAPBHFIHGDL.SetVector("adjust", new Vector4(this.lensflareThreshold, 1062f / (1322f - this.lensflareThreshold), 1852f, 294f));
					this.BAPBHFIHGDL.SetVector("_PrevViewProj", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 0);
					temporary4.DiscardContents();
					Graphics.Blit(temporary3, temporary4, this.BAPBHFIHGDL, 1);
					temporary3.DiscardContents();
					this.BAPBHFIHGDL.SetVector("", new Vector4(this.sepBlurSpread * 150f / num * num2, 1023f, 387f, 1150f));
					this.BAPBHFIHGDL.SetFloat("PaperTurn.wav", this.hollyStretchWidth);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 0);
					temporary4.DiscardContents();
					this.BAPBHFIHGDL.SetFloat("RollerBladeTurnLeft", this.hollyStretchWidth * 314f);
					Graphics.Blit(temporary3, temporary4, this.BAPBHFIHGDL, 0);
					temporary3.DiscardContents();
					this.BAPBHFIHGDL.SetFloat("https://groups.google.com/forum/#!forum/final-ik", this.hollyStretchWidth * 1222f);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 1);
					temporary4.DiscardContents();
					if (this.lensflareMode == BACDIBMHEJP.Ghosting)
					{
						for (int j = 0; j < this.hollywoodFlareBlurIterations; j += 0)
						{
							this.AEODOBMBCHF.SetVector("Mouse ScrollWheel", new Vector4(this.hollyStretchWidth * 1586f / num * num2, 1918f, 1515f, 637f));
							Graphics.Blit(temporary3, temporary4, this.AEODOBMBCHF);
							temporary3.DiscardContents();
							this.AEODOBMBCHF.SetVector("\\", new Vector4(this.hollyStretchWidth * 278f / num * num2, 1335f, 1065f, 778f));
							Graphics.Blit(temporary4, temporary3, this.AEODOBMBCHF);
							temporary4.DiscardContents();
						}
						this.BEFGNABMCIH(1359f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
					else
					{
						for (int k = 1; k < this.hollywoodFlareBlurIterations; k++)
						{
							this.AEODOBMBCHF.SetVector("UV3", new Vector4(this.hollyStretchWidth * 1393f / num * num2, 1604f, 603f, 579f));
							Graphics.Blit(temporary3, temporary4, this.AEODOBMBCHF);
							temporary3.DiscardContents();
							this.AEODOBMBCHF.SetVector("_WrinkleInfluences1", new Vector4(this.hollyStretchWidth * 471f / num * num2, 777f, 520f, 1240f));
							Graphics.Blit(temporary4, temporary3, this.AEODOBMBCHF);
							temporary4.DiscardContents();
						}
						this.AEKGJPDCMEH(1379f, temporary3, temporary4);
						temporary3.DiscardContents();
						this.FGLLJIAOOHH(temporary4, temporary3);
						temporary4.DiscardContents();
						this.NDILPHHJELA(1109f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
				}
			}
			this.GILHCCIHPGN.SetFloat("{0} x {1}", this.bloomIntensity);
			this.GILHCCIHPGN.SetTexture("#000000", JONJODLFAEN);
			Graphics.Blit(temporary2, OKIIDHIJBEA, this.GILHCCIHPGN, (int)pass);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
			RenderTexture.ReleaseTemporary(temporary4);
		}

		// Token: 0x0600B33F RID: 45887 RVA: 0x004E817C File Offset: 0x004E637C
		private void NLDNOCECHDM(float JLEHAHJEIAC, float LACHEBPNLKL, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			if (this.GEBCPMDEOEA)
			{
				this.PJECOFONCFN.SetVector("", new Vector4(JLEHAHJEIAC, 1577f, 522f, 843f));
			}
			else
			{
				this.PJECOFONCFN.SetVector("_BokehParams", new Vector4(JLEHAHJEIAC, 245f / (524f - JLEHAHJEIAC), 692f, 41f));
			}
			this.PJECOFONCFN.SetFloat("_Intensity", LACHEBPNLKL);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.PJECOFONCFN);
		}

		// Token: 0x0600B340 RID: 45888 RVA: 0x004E8204 File Offset: 0x004E6404
		public override bool CheckResources()
		{
			base.DAOKCAOFIGE(false);
			this.GILHCCIHPGN = base.DJFOEIJIMJB(this.screenBlendShader, this.GILHCCIHPGN);
			this.FGKGIFAKMKL = base.DJFOEIJIMJB(this.lensFlareShader, this.FGKGIFAKMKL);
			this.DGEAOLLJAAG = base.DJFOEIJIMJB(this.vignetteShader, this.DGEAOLLJAAG);
			this.AEODOBMBCHF = base.DJFOEIJIMJB(this.separableBlurShader, this.AEODOBMBCHF);
			this.IHBCDHELNMM = base.DJFOEIJIMJB(this.addBrightStuffOneOneShader, this.IHBCDHELNMM);
			this.BAPBHFIHGDL = base.DJFOEIJIMJB(this.hollywoodFlaresShader, this.BAPBHFIHGDL);
			this.PJECOFONCFN = base.DJFOEIJIMJB(this.brightPassFilterShader, this.PJECOFONCFN);
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B341 RID: 45889 RVA: 0x004E82D8 File Offset: 0x004E64D8
		private void OBLFEKEIFBM(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.FGKGIFAKMKL.SetVector("", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("800000", new Vector4(this.flareColorB.r, this.flareColorB.g, this.flareColorB.b, this.flareColorB.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("FrontKick", new Vector4(this.flareColorC.r, this.flareColorC.g, this.flareColorC.b, this.flareColorC.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("IdleStand", new Vector4(this.flareColorD.r, this.flareColorD.g, this.flareColorD.b, this.flareColorD.a) * this.lensflareIntensity);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.FGKGIFAKMKL);
		}

		// Token: 0x0600B342 RID: 45890 RVA: 0x004E8424 File Offset: 0x004E6624
		private void GGKNJNDHAHD(float JLEHAHJEIAC, float LACHEBPNLKL, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			if (this.GEBCPMDEOEA)
			{
				this.PJECOFONCFN.SetVector("Steam Overlay has been activated", new Vector4(JLEHAHJEIAC, 1043f, 1211f, 1554f));
			}
			else
			{
				this.PJECOFONCFN.SetVector("_TempTexture", new Vector4(JLEHAHJEIAC, 1769f / (996f - JLEHAHJEIAC), 1627f, 417f));
			}
			this.PJECOFONCFN.SetFloat("System.Single", LACHEBPNLKL);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.PJECOFONCFN);
		}

		// Token: 0x0600B343 RID: 45891 RVA: 0x004E84AC File Offset: 0x004E66AC
		private void IBIBOJIPANH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.GGJKGIHGMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.GEBCPMDEOEA = true;
			if (this.hdr == OILMIEGFPIK.Auto)
			{
				this.GEBCPMDEOEA = (JONJODLFAEN.format == RenderTextureFormat.Default && base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.GEBCPMDEOEA = (this.hdr == OILMIEGFPIK.On);
			}
			this.GEBCPMDEOEA = (this.GEBCPMDEOEA && this.KKGBEAPGBOD);
			FMPIKFAHIBL pass = this.screenBlendMode;
			if (this.GEBCPMDEOEA)
			{
				pass = FMPIKFAHIBL.Screen;
			}
			RenderTextureFormat format = this.GEBCPMDEOEA ? RenderTextureFormat.Default : RenderTextureFormat.ARGB1555;
			RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / 8, JONJODLFAEN.height / 7, 1, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width / 3, JONJODLFAEN.height / 2, 1, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / 2, JONJODLFAEN.height / 1, 1, format);
			RenderTexture temporary4 = RenderTexture.GetTemporary(JONJODLFAEN.width / 8, JONJODLFAEN.height / 7, 0, format);
			float num = 648f * (float)JONJODLFAEN.width / (80f * (float)JONJODLFAEN.height);
			float num2 = 1365f;
			Graphics.Blit(JONJODLFAEN, temporary, this.GILHCCIHPGN, 0);
			Graphics.Blit(temporary, temporary2, this.GILHCCIHPGN, 4);
			RenderTexture.ReleaseTemporary(temporary);
			this.BMAKFEPLFHM(this.bloomThreshold, this.useSrcAlphaAsMask, temporary2, temporary3);
			temporary2.DiscardContents();
			if (this.bloomBlurIterations < 0)
			{
				this.bloomBlurIterations = 1;
			}
			for (int i = 0; i < this.bloomBlurIterations; i += 0)
			{
				float num3 = (1998f + (float)i * 19f) * this.sepBlurSpread;
				this.AEODOBMBCHF.SetVector("Forefeet Root", new Vector4(1371f, num3 * num2, 681f, 970f));
				RenderTexture renderTexture = (i == 0) ? temporary3 : temporary2;
				Graphics.Blit(renderTexture, temporary4, this.AEODOBMBCHF);
				renderTexture.DiscardContents();
				this.AEODOBMBCHF.SetVector("G", new Vector4(num3 / num * num2, 1675f, 1684f, 535f));
				Graphics.Blit(temporary4, temporary2, this.AEODOBMBCHF);
				temporary4.DiscardContents();
			}
			if (this.lensflares)
			{
				if (this.lensflareMode == BACDIBMHEJP.Ghosting)
				{
					this.NLDNOCECHDM(this.lensflareThreshold, 853f, temporary2, temporary4);
					temporary2.DiscardContents();
					this.HJJDCCACFGK(1597f, temporary4, temporary3);
					temporary4.DiscardContents();
					this.FGLLJIAOOHH(temporary3, temporary2);
					temporary3.DiscardContents();
				}
				else
				{
					this.BAPBHFIHGDL.SetVector("SkateboardIdle", new Vector4(this.lensflareThreshold, 1546f / (1755f - this.lensflareThreshold), 387f, 1399f));
					this.BAPBHFIHGDL.SetVector("loc", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 4);
					temporary4.DiscardContents();
					Graphics.Blit(temporary3, temporary4, this.BAPBHFIHGDL, 5);
					temporary3.DiscardContents();
					this.BAPBHFIHGDL.SetVector("", new Vector4(this.sepBlurSpread * 1846f / num * num2, 1588f, 82f, 1435f));
					this.BAPBHFIHGDL.SetFloat("BipedReferences eye bone at index ", this.hollyStretchWidth);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 1);
					temporary4.DiscardContents();
					this.BAPBHFIHGDL.SetFloat("SneakLeft", this.hollyStretchWidth * 289f);
					Graphics.Blit(temporary3, temporary4, this.BAPBHFIHGDL, 0);
					temporary3.DiscardContents();
					this.BAPBHFIHGDL.SetFloat("sunshine_ShadowCoordDepthRayU", this.hollyStretchWidth * 1580f);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 0);
					temporary4.DiscardContents();
					if (this.lensflareMode == BACDIBMHEJP.Anamorphic)
					{
						for (int j = 1; j < this.hollywoodFlareBlurIterations; j++)
						{
							this.AEODOBMBCHF.SetVector("_SharpenParameters", new Vector4(this.hollyStretchWidth * 36f / num * num2, 188f, 1475f, 1958f));
							Graphics.Blit(temporary3, temporary4, this.AEODOBMBCHF);
							temporary3.DiscardContents();
							this.AEODOBMBCHF.SetVector("t_body", new Vector4(this.hollyStretchWidth * 576f / num * num2, 1368f, 1535f, 819f));
							Graphics.Blit(temporary4, temporary3, this.AEODOBMBCHF);
							temporary4.DiscardContents();
						}
						this.OGDGHAIPDDI(188f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
					else
					{
						for (int k = 0; k < this.hollywoodFlareBlurIterations; k++)
						{
							this.AEODOBMBCHF.SetVector("_SunThreshold", new Vector4(this.hollyStretchWidth * 1634f / num * num2, 1516f, 1076f, 332f));
							Graphics.Blit(temporary3, temporary4, this.AEODOBMBCHF);
							temporary3.DiscardContents();
							this.AEODOBMBCHF.SetVector("", new Vector4(this.hollyStretchWidth * 861f / num * num2, 172f, 148f, 1289f));
							Graphics.Blit(temporary4, temporary3, this.AEODOBMBCHF);
							temporary4.DiscardContents();
						}
						this.AEKGJPDCMEH(1262f, temporary3, temporary4);
						temporary3.DiscardContents();
						this.DGOEGEKEDNJ(temporary4, temporary3);
						temporary4.DiscardContents();
						this.BEFGNABMCIH(650f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
				}
			}
			this.GILHCCIHPGN.SetFloat("****************** CamEffector APPLY 0", this.bloomIntensity);
			this.GILHCCIHPGN.SetTexture("qd_prise_rep", JONJODLFAEN);
			Graphics.Blit(temporary2, OKIIDHIJBEA, this.GILHCCIHPGN, (int)pass);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
			RenderTexture.ReleaseTemporary(temporary4);
		}

		// Token: 0x0600B344 RID: 45892 RVA: 0x004E8ABC File Offset: 0x004E6CBC
		private void NPAOBLFOMGI(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.GGJKGIHGMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.GEBCPMDEOEA = true;
			if (this.hdr == OILMIEGFPIK.Auto)
			{
				this.GEBCPMDEOEA = (JONJODLFAEN.format == RenderTextureFormat.ARGB4444 && base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.GEBCPMDEOEA = (this.hdr == OILMIEGFPIK.On);
			}
			this.GEBCPMDEOEA = (!this.GEBCPMDEOEA || this.KKGBEAPGBOD);
			FMPIKFAHIBL pass = this.screenBlendMode;
			if (this.GEBCPMDEOEA)
			{
				pass = FMPIKFAHIBL.Screen;
			}
			RenderTextureFormat format = this.GEBCPMDEOEA ? RenderTextureFormat.Shadowmap : RenderTextureFormat.ARGB2101010;
			RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / 2, JONJODLFAEN.height / 8, 1, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width / 6, JONJODLFAEN.height / 2, 0, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / 2, JONJODLFAEN.height / 1, 1, format);
			RenderTexture temporary4 = RenderTexture.GetTemporary(JONJODLFAEN.width / 1, JONJODLFAEN.height / 2, 1, format);
			float num = 160f * (float)JONJODLFAEN.width / (1954f * (float)JONJODLFAEN.height);
			float num2 = 904f;
			Graphics.Blit(JONJODLFAEN, temporary, this.GILHCCIHPGN, 6);
			Graphics.Blit(temporary, temporary2, this.GILHCCIHPGN, 8);
			RenderTexture.ReleaseTemporary(temporary);
			this.CAONJCLHLDK(this.bloomThreshold, this.useSrcAlphaAsMask, temporary2, temporary3);
			temporary2.DiscardContents();
			if (this.bloomBlurIterations < 1)
			{
				this.bloomBlurIterations = 1;
			}
			for (int i = 1; i < this.bloomBlurIterations; i++)
			{
				float num3 = (827f + (float)i * 1020f) * this.sepBlurSpread;
				this.AEODOBMBCHF.SetVector("<b>ObscuredInt:</b> ", new Vector4(624f, num3 * num2, 546f, 228f));
				RenderTexture renderTexture = (i == 0) ? temporary3 : temporary2;
				Graphics.Blit(renderTexture, temporary4, this.AEODOBMBCHF);
				renderTexture.DiscardContents();
				this.AEODOBMBCHF.SetVector("Forward", new Vector4(num3 / num * num2, 431f, 1585f, 1586f));
				Graphics.Blit(temporary4, temporary2, this.AEODOBMBCHF);
				temporary4.DiscardContents();
			}
			if (this.lensflares)
			{
				if (this.lensflareMode == BACDIBMHEJP.Ghosting)
				{
					this.LHNNNNEONBM(this.lensflareThreshold, 1427f, temporary2, temporary4);
					temporary2.DiscardContents();
					this.IELKDMILEGK(583f, temporary4, temporary3);
					temporary4.DiscardContents();
					this.FGLLJIAOOHH(temporary3, temporary2);
					temporary3.DiscardContents();
				}
				else
				{
					this.BAPBHFIHGDL.SetVector("Weapons", new Vector4(this.lensflareThreshold, 1032f / (1734f - this.lensflareThreshold), 171f, 282f));
					this.BAPBHFIHGDL.SetVector("_CameraClipInfo", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 0);
					temporary4.DiscardContents();
					Graphics.Blit(temporary3, temporary4, this.BAPBHFIHGDL, 0);
					temporary3.DiscardContents();
					this.BAPBHFIHGDL.SetVector("CrouchStrafeRight", new Vector4(this.sepBlurSpread * 1332f / num * num2, 481f, 518f, 1975f));
					this.BAPBHFIHGDL.SetFloat("IdleCheer", this.hollyStretchWidth);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 1);
					temporary4.DiscardContents();
					this.BAPBHFIHGDL.SetFloat("WizardEyeBeam", this.hollyStretchWidth * 764f);
					Graphics.Blit(temporary3, temporary4, this.BAPBHFIHGDL, 1);
					temporary3.DiscardContents();
					this.BAPBHFIHGDL.SetFloat("https://groups.google.com/forum/#!forum/final-ik", this.hollyStretchWidth * 1424f);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 1);
					temporary4.DiscardContents();
					if (this.lensflareMode == BACDIBMHEJP.Ghosting)
					{
						for (int j = 1; j < this.hollywoodFlareBlurIterations; j++)
						{
							this.AEODOBMBCHF.SetVector("change me!", new Vector4(this.hollyStretchWidth * 1186f / num * num2, 971f, 372f, 570f));
							Graphics.Blit(temporary3, temporary4, this.AEODOBMBCHF);
							temporary3.DiscardContents();
							this.AEODOBMBCHF.SetVector(" has been disabled as it's not supported on the current platform.", new Vector4(this.hollyStretchWidth * 694f / num * num2, 0f, 834f, 1143f));
							Graphics.Blit(temporary4, temporary3, this.AEODOBMBCHF);
							temporary4.DiscardContents();
						}
						this.LOKBDHGEBAP(856f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
					else
					{
						for (int k = 0; k < this.hollywoodFlareBlurIterations; k += 0)
						{
							this.AEODOBMBCHF.SetVector("lineDistance=", new Vector4(this.hollyStretchWidth * 1275f / num * num2, 1659f, 1763f, 1228f));
							Graphics.Blit(temporary3, temporary4, this.AEODOBMBCHF);
							temporary3.DiscardContents();
							this.AEODOBMBCHF.SetVector("_SSRMultiplier", new Vector4(this.hollyStretchWidth * 502f / num * num2, 1687f, 1440f, 105f));
							Graphics.Blit(temporary4, temporary3, this.AEODOBMBCHF);
							temporary4.DiscardContents();
						}
						this.FFEOONAKLEE(1828f, temporary3, temporary4);
						temporary3.DiscardContents();
						this.GKHEAAEEOJB(temporary4, temporary3);
						temporary4.DiscardContents();
						this.BPBKOEJGKHJ(295f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
				}
			}
			this.GILHCCIHPGN.SetFloat(",", this.bloomIntensity);
			this.GILHCCIHPGN.SetTexture("wpn_wgt", JONJODLFAEN);
			Graphics.Blit(temporary2, OKIIDHIJBEA, this.GILHCCIHPGN, (int)pass);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
			RenderTexture.ReleaseTemporary(temporary4);
		}

		// Token: 0x0600B345 RID: 45893 RVA: 0x004E90CC File Offset: 0x004E72CC
		private void BPDPMGKDLNM(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.FGKGIFAKMKL.SetVector(" ", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("wpn_add/base", new Vector4(this.flareColorB.r, this.flareColorB.g, this.flareColorB.b, this.flareColorB.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("RollerBladeStop", new Vector4(this.flareColorC.r, this.flareColorC.g, this.flareColorC.b, this.flareColorC.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("Eye", new Vector4(this.flareColorD.r, this.flareColorD.g, this.flareColorD.b, this.flareColorD.a) * this.lensflareIntensity);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.FGKGIFAKMKL);
		}

		// Token: 0x0600B346 RID: 45894 RVA: 0x004E9218 File Offset: 0x004E7418
		public virtual bool DGACHJFDAMI()
		{
			base.EBEBJHLBBBI(true);
			this.GILHCCIHPGN = base.ALJPMGLOIEG(this.screenBlendShader, this.GILHCCIHPGN);
			this.FGKGIFAKMKL = base.BOOFEOGDMBI(this.lensFlareShader, this.FGKGIFAKMKL);
			this.DGEAOLLJAAG = base.JBHLGBPJFEL(this.vignetteShader, this.DGEAOLLJAAG);
			this.AEODOBMBCHF = base.JBHLGBPJFEL(this.separableBlurShader, this.AEODOBMBCHF);
			this.IHBCDHELNMM = base.ALJPMGLOIEG(this.addBrightStuffOneOneShader, this.IHBCDHELNMM);
			this.BAPBHFIHGDL = base.DJFOEIJIMJB(this.hollywoodFlaresShader, this.BAPBHFIHGDL);
			this.PJECOFONCFN = base.IIIIADNBONI(this.brightPassFilterShader, this.PJECOFONCFN);
			if (!this.PPGOAMIHMBG)
			{
				base.LNEHBOJIBAI();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B347 RID: 45895 RVA: 0x004E92EC File Offset: 0x004E74EC
		private void EIBBJMGHBLC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.GEBCPMDEOEA = true;
			if (this.hdr == OILMIEGFPIK.Auto)
			{
				this.GEBCPMDEOEA = (JONJODLFAEN.format != RenderTextureFormat.Depth || base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.GEBCPMDEOEA = (this.hdr == OILMIEGFPIK.On);
			}
			this.GEBCPMDEOEA = (this.GEBCPMDEOEA && this.KKGBEAPGBOD);
			FMPIKFAHIBL pass = this.screenBlendMode;
			if (this.GEBCPMDEOEA)
			{
				pass = FMPIKFAHIBL.Add;
			}
			RenderTextureFormat format = this.GEBCPMDEOEA ? RenderTextureFormat.RGB565 : RenderTextureFormat.ARGB1555;
			RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / 5, JONJODLFAEN.height / 6, 1, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width / 3, JONJODLFAEN.height / 1, 0, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / 7, JONJODLFAEN.height / 7, 0, format);
			RenderTexture temporary4 = RenderTexture.GetTemporary(JONJODLFAEN.width / 4, JONJODLFAEN.height / 6, 1, format);
			float num = 1239f * (float)JONJODLFAEN.width / (608f * (float)JONJODLFAEN.height);
			float num2 = 1294f;
			Graphics.Blit(JONJODLFAEN, temporary, this.GILHCCIHPGN, 5);
			Graphics.Blit(temporary, temporary2, this.GILHCCIHPGN, 7);
			RenderTexture.ReleaseTemporary(temporary);
			this.JFNNPAFOLEM(this.bloomThreshold, this.useSrcAlphaAsMask, temporary2, temporary3);
			temporary2.DiscardContents();
			if (this.bloomBlurIterations < 0)
			{
				this.bloomBlurIterations = 0;
			}
			for (int i = 0; i < this.bloomBlurIterations; i++)
			{
				float num3 = (1772f + (float)i * 1717f) * this.sepBlurSpread;
				this.AEODOBMBCHF.SetVector("CATRigR", new Vector4(681f, num3 * num2, 1582f, 316f));
				RenderTexture renderTexture = (i == 0) ? temporary3 : temporary2;
				Graphics.Blit(renderTexture, temporary4, this.AEODOBMBCHF);
				renderTexture.DiscardContents();
				this.AEODOBMBCHF.SetVector("I'm regular string", new Vector4(num3 / num * num2, 54f, 631f, 1546f));
				Graphics.Blit(temporary4, temporary2, this.AEODOBMBCHF);
				temporary4.DiscardContents();
			}
			if (this.lensflares)
			{
				if (this.lensflareMode == BACDIBMHEJP.Ghosting)
				{
					this.JFNNPAFOLEM(this.lensflareThreshold, 959f, temporary2, temporary4);
					temporary2.DiscardContents();
					this.MJGCBJBEDPL(319f, temporary4, temporary3);
					temporary4.DiscardContents();
					this.MENJOFHJNDG(temporary3, temporary2);
					temporary3.DiscardContents();
				}
				else
				{
					this.BAPBHFIHGDL.SetVector(" ", new Vector4(this.lensflareThreshold, 1275f / (1464f - this.lensflareThreshold), 1996f, 890f));
					this.BAPBHFIHGDL.SetVector("MotorbikeHeadstand", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 3);
					temporary4.DiscardContents();
					Graphics.Blit(temporary3, temporary4, this.BAPBHFIHGDL, 0);
					temporary3.DiscardContents();
					this.BAPBHFIHGDL.SetVector("_ExposureAdjustment", new Vector4(this.sepBlurSpread * 29f / num * num2, 1407f, 1526f, 1278f));
					this.BAPBHFIHGDL.SetFloat("id", this.hollyStretchWidth);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 0);
					temporary4.DiscardContents();
					this.BAPBHFIHGDL.SetFloat("", this.hollyStretchWidth * 564f);
					Graphics.Blit(temporary3, temporary4, this.BAPBHFIHGDL, 0);
					temporary3.DiscardContents();
					this.BAPBHFIHGDL.SetFloat("_End", this.hollyStretchWidth * 1915f);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 1);
					temporary4.DiscardContents();
					if (this.lensflareMode == BACDIBMHEJP.Anamorphic)
					{
						for (int j = 1; j < this.hollywoodFlareBlurIterations; j++)
						{
							this.AEODOBMBCHF.SetVector("index", new Vector4(this.hollyStretchWidth * 999f / num * num2, 1262f, 64f, 879f));
							Graphics.Blit(temporary3, temporary4, this.AEODOBMBCHF);
							temporary3.DiscardContents();
							this.AEODOBMBCHF.SetVector("_Parameter", new Vector4(this.hollyStretchWidth * 963f / num * num2, 1013f, 1667f, 565f));
							Graphics.Blit(temporary4, temporary3, this.AEODOBMBCHF);
							temporary4.DiscardContents();
						}
						this.BEFGNABMCIH(435f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
					else
					{
						for (int k = 1; k < this.hollywoodFlareBlurIterations; k += 0)
						{
							this.AEODOBMBCHF.SetVector("", new Vector4(this.hollyStretchWidth * 1235f / num * num2, 746f, 91f, 1176f));
							Graphics.Blit(temporary3, temporary4, this.AEODOBMBCHF);
							temporary3.DiscardContents();
							this.AEODOBMBCHF.SetVector("RoundHouse", new Vector4(this.hollyStretchWidth * 159f / num * num2, 1687f, 272f, 1155f));
							Graphics.Blit(temporary4, temporary3, this.AEODOBMBCHF);
							temporary4.DiscardContents();
						}
						this.MJGCBJBEDPL(1046f, temporary3, temporary4);
						temporary3.DiscardContents();
						this.MENJOFHJNDG(temporary4, temporary3);
						temporary4.DiscardContents();
						this.NLDGLJFIIDH(1478f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
				}
			}
			this.GILHCCIHPGN.SetFloat("</color></i>", this.bloomIntensity);
			this.GILHCCIHPGN.SetTexture("Hidden/FXAA3", JONJODLFAEN);
			Graphics.Blit(temporary2, OKIIDHIJBEA, this.GILHCCIHPGN, (int)pass);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
			RenderTexture.ReleaseTemporary(temporary4);
		}

		// Token: 0x0600B348 RID: 45896 RVA: 0x004E98FC File Offset: 0x004E7AFC
		private void BHAFGNALJMJ(float MHIPLHJKKIF, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			if (this.lensFlareVignetteMask)
			{
				this.GILHCCIHPGN.SetTexture("KarateGreet", this.lensFlareVignetteMask);
				Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.GILHCCIHPGN, 5);
				return;
			}
			this.DGEAOLLJAAG.SetFloat("", MHIPLHJKKIF);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.DGEAOLLJAAG);
		}

		// Token: 0x0600B349 RID: 45897 RVA: 0x004E995C File Offset: 0x004E7B5C
		private void LOPLBCLLCID(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.GGJKGIHGMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.GEBCPMDEOEA = false;
			if (this.hdr == OILMIEGFPIK.Auto)
			{
				this.GEBCPMDEOEA = (JONJODLFAEN.format == RenderTextureFormat.ARGB32 && base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.GEBCPMDEOEA = (this.hdr == OILMIEGFPIK.On);
			}
			this.GEBCPMDEOEA = (this.GEBCPMDEOEA && this.KKGBEAPGBOD);
			FMPIKFAHIBL pass = this.screenBlendMode;
			if (this.GEBCPMDEOEA)
			{
				pass = FMPIKFAHIBL.Add;
			}
			RenderTextureFormat format = this.GEBCPMDEOEA ? RenderTextureFormat.Shadowmap : RenderTextureFormat.RGB565;
			RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / 5, JONJODLFAEN.height / 5, 1, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width / 1, JONJODLFAEN.height / 0, 1, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / 4, JONJODLFAEN.height / 5, 0, format);
			RenderTexture temporary4 = RenderTexture.GetTemporary(JONJODLFAEN.width / 8, JONJODLFAEN.height / 3, 1, format);
			float num = 1143f * (float)JONJODLFAEN.width / (1056f * (float)JONJODLFAEN.height);
			float num2 = 501f;
			Graphics.Blit(JONJODLFAEN, temporary, this.GILHCCIHPGN, 2);
			Graphics.Blit(temporary, temporary2, this.GILHCCIHPGN, 8);
			RenderTexture.ReleaseTemporary(temporary);
			this.CAONJCLHLDK(this.bloomThreshold, this.useSrcAlphaAsMask, temporary2, temporary3);
			temporary2.DiscardContents();
			if (this.bloomBlurIterations < 0)
			{
				this.bloomBlurIterations = 1;
			}
			for (int i = 0; i < this.bloomBlurIterations; i++)
			{
				float num3 = (217f + (float)i * 893f) * this.sepBlurSpread;
				this.AEODOBMBCHF.SetVector("rod_inf1", new Vector4(682f, num3 * num2, 1569f, 732f));
				RenderTexture renderTexture = (i == 0) ? temporary3 : temporary2;
				Graphics.Blit(renderTexture, temporary4, this.AEODOBMBCHF);
				renderTexture.DiscardContents();
				this.AEODOBMBCHF.SetVector("RollerBladeGrindRoyale", new Vector4(num3 / num * num2, 399f, 1352f, 1560f));
				Graphics.Blit(temporary4, temporary2, this.AEODOBMBCHF);
				temporary4.DiscardContents();
			}
			if (this.lensflares)
			{
				if (this.lensflareMode == BACDIBMHEJP.Ghosting)
				{
					this.GGKNJNDHAHD(this.lensflareThreshold, 367f, temporary2, temporary4);
					temporary2.DiscardContents();
					this.DNIACJNAGMP(1740f, temporary4, temporary3);
					temporary4.DiscardContents();
					this.MDOECNMOPEL(temporary3, temporary2);
					temporary3.DiscardContents();
				}
				else
				{
					this.BAPBHFIHGDL.SetVector(" ", new Vector4(this.lensflareThreshold, 477f / (314f - this.lensflareThreshold), 839f, 1230f));
					this.BAPBHFIHGDL.SetVector("MotorbikeBackwardSitting", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 7);
					temporary4.DiscardContents();
					Graphics.Blit(temporary3, temporary4, this.BAPBHFIHGDL, 2);
					temporary3.DiscardContents();
					this.BAPBHFIHGDL.SetVector("HALIGN", new Vector4(this.sepBlurSpread * 1822f / num * num2, 736f, 1199f, 67f));
					this.BAPBHFIHGDL.SetFloat("u_pass", this.hollyStretchWidth);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 1);
					temporary4.DiscardContents();
					this.BAPBHFIHGDL.SetFloat("Hidden/DepthOfField/MedianFilter", this.hollyStretchWidth * 1678f);
					Graphics.Blit(temporary3, temporary4, this.BAPBHFIHGDL, 1);
					temporary3.DiscardContents();
					this.BAPBHFIHGDL.SetFloat("vertices: {0}   triangles: {1}", this.hollyStretchWidth * 61f);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 1);
					temporary4.DiscardContents();
					if (this.lensflareMode == BACDIBMHEJP.Ghosting)
					{
						for (int j = 0; j < this.hollywoodFlareBlurIterations; j++)
						{
							this.AEODOBMBCHF.SetVector("PLANE_REFLECTION", new Vector4(this.hollyStretchWidth * 364f / num * num2, 777f, 1305f, 647f));
							Graphics.Blit(temporary3, temporary4, this.AEODOBMBCHF);
							temporary3.DiscardContents();
							this.AEODOBMBCHF.SetVector("act_order", new Vector4(this.hollyStretchWidth * 1784f / num * num2, 1142f, 119f, 474f));
							Graphics.Blit(temporary4, temporary3, this.AEODOBMBCHF);
							temporary4.DiscardContents();
						}
						this.OLPPLCEHMBI(1910f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
					else
					{
						for (int k = 0; k < this.hollywoodFlareBlurIterations; k++)
						{
							this.AEODOBMBCHF.SetVector("IceHockeyDekeMiddle", new Vector4(this.hollyStretchWidth * 1819f / num * num2, 590f, 60f, 1679f));
							Graphics.Blit(temporary3, temporary4, this.AEODOBMBCHF);
							temporary3.DiscardContents();
							this.AEODOBMBCHF.SetVector("IdleStrafeLeft", new Vector4(this.hollyStretchWidth * 1107f / num * num2, 1071f, 332f, 1482f));
							Graphics.Blit(temporary4, temporary3, this.AEODOBMBCHF);
							temporary4.DiscardContents();
						}
						this.IELKDMILEGK(1536f, temporary3, temporary4);
						temporary3.DiscardContents();
						this.NPHCBNEIMOC(temporary4, temporary3);
						temporary4.DiscardContents();
						this.APBPGPALFLO(1134f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
				}
			}
			this.GILHCCIHPGN.SetFloat("wpn_add/base", this.bloomIntensity);
			this.GILHCCIHPGN.SetTexture("{0}.{1}.{2}.{3}", JONJODLFAEN);
			Graphics.Blit(temporary2, OKIIDHIJBEA, this.GILHCCIHPGN, (int)pass);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
			RenderTexture.ReleaseTemporary(temporary4);
		}

		// Token: 0x0600B34A RID: 45898 RVA: 0x004E9F6C File Offset: 0x004E816C
		private void GNDNAAHKDIM(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.GEBCPMDEOEA = true;
			if (this.hdr == OILMIEGFPIK.Auto)
			{
				this.GEBCPMDEOEA = (JONJODLFAEN.format == RenderTextureFormat.ARGB32 && base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.GEBCPMDEOEA = (this.hdr == OILMIEGFPIK.Auto);
			}
			this.GEBCPMDEOEA = (!this.GEBCPMDEOEA || this.KKGBEAPGBOD);
			FMPIKFAHIBL pass = this.screenBlendMode;
			if (this.GEBCPMDEOEA)
			{
				pass = FMPIKFAHIBL.Screen;
			}
			RenderTextureFormat format = this.GEBCPMDEOEA ? RenderTextureFormat.Shadowmap : RenderTextureFormat.Shadowmap;
			RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / 6, JONJODLFAEN.height / 4, 1, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width / 3, JONJODLFAEN.height / 7, 1, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / 5, JONJODLFAEN.height / 5, 1, format);
			RenderTexture temporary4 = RenderTexture.GetTemporary(JONJODLFAEN.width / 5, JONJODLFAEN.height / 1, 1, format);
			float num = 548f * (float)JONJODLFAEN.width / (1642f * (float)JONJODLFAEN.height);
			float num2 = 1031f;
			Graphics.Blit(JONJODLFAEN, temporary, this.GILHCCIHPGN, 3);
			Graphics.Blit(temporary, temporary2, this.GILHCCIHPGN, 0);
			RenderTexture.ReleaseTemporary(temporary);
			this.BMAKFEPLFHM(this.bloomThreshold, this.useSrcAlphaAsMask, temporary2, temporary3);
			temporary2.DiscardContents();
			if (this.bloomBlurIterations < 1)
			{
				this.bloomBlurIterations = 0;
			}
			for (int i = 1; i < this.bloomBlurIterations; i++)
			{
				float num3 = (1436f + (float)i * 1317f) * this.sepBlurSpread;
				this.AEODOBMBCHF.SetVector("PistolLeftHandStab", new Vector4(1360f, num3 * num2, 1518f, 1793f));
				RenderTexture renderTexture = (i == 0) ? temporary3 : temporary2;
				Graphics.Blit(renderTexture, temporary4, this.AEODOBMBCHF);
				renderTexture.DiscardContents();
				this.AEODOBMBCHF.SetVector("gi_inte_2", new Vector4(num3 / num * num2, 1140f, 1492f, 1454f));
				Graphics.Blit(temporary4, temporary2, this.AEODOBMBCHF);
				temporary4.DiscardContents();
			}
			if (this.lensflares)
			{
				if (this.lensflareMode == BACDIBMHEJP.Ghosting)
				{
					this.GGKNJNDHAHD(this.lensflareThreshold, 1610f, temporary2, temporary4);
					temporary2.DiscardContents();
					this.HJJDCCACFGK(1473f, temporary4, temporary3);
					temporary4.DiscardContents();
					this.MDOECNMOPEL(temporary3, temporary2);
					temporary3.DiscardContents();
				}
				else
				{
					this.BAPBHFIHGDL.SetVector("iNPC", new Vector4(this.lensflareThreshold, 833f / (902f - this.lensflareThreshold), 1647f, 1754f));
					this.BAPBHFIHGDL.SetVector("Whistle", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 3);
					temporary4.DiscardContents();
					Graphics.Blit(temporary3, temporary4, this.BAPBHFIHGDL, 4);
					temporary3.DiscardContents();
					this.BAPBHFIHGDL.SetVector("", new Vector4(this.sepBlurSpread * 1659f / num * num2, 279f, 1870f, 346f));
					this.BAPBHFIHGDL.SetFloat("Object To Instantiate", this.hollyStretchWidth);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 1);
					temporary4.DiscardContents();
					this.BAPBHFIHGDL.SetFloat("", this.hollyStretchWidth * 175f);
					Graphics.Blit(temporary3, temporary4, this.BAPBHFIHGDL, 0);
					temporary3.DiscardContents();
					this.BAPBHFIHGDL.SetFloat("BaseDataLoaderCoroutine", this.hollyStretchWidth * 420f);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 1);
					temporary4.DiscardContents();
					if (this.lensflareMode == BACDIBMHEJP.Anamorphic)
					{
						for (int j = 0; j < this.hollywoodFlareBlurIterations; j += 0)
						{
							this.AEODOBMBCHF.SetVector("1HandSwordChargeUp", new Vector4(this.hollyStretchWidth * 13f / num * num2, 1212f, 1876f, 91f));
							Graphics.Blit(temporary3, temporary4, this.AEODOBMBCHF);
							temporary3.DiscardContents();
							this.AEODOBMBCHF.SetVector("Arm Flex", new Vector4(this.hollyStretchWidth * 1720f / num * num2, 274f, 1858f, 789f));
							Graphics.Blit(temporary4, temporary3, this.AEODOBMBCHF);
							temporary4.DiscardContents();
						}
						this.APBPGPALFLO(1129f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
					else
					{
						for (int k = 0; k < this.hollywoodFlareBlurIterations; k++)
						{
							this.AEODOBMBCHF.SetVector("IdleBandage", new Vector4(this.hollyStretchWidth * 1139f / num * num2, 292f, 938f, 1364f));
							Graphics.Blit(temporary3, temporary4, this.AEODOBMBCHF);
							temporary3.DiscardContents();
							this.AEODOBMBCHF.SetVector("GestureCrowdPump", new Vector4(this.hollyStretchWidth * 452f / num * num2, 1658f, 253f, 1490f));
							Graphics.Blit(temporary4, temporary3, this.AEODOBMBCHF);
							temporary4.DiscardContents();
						}
						this.OAKNBBGIOKB(1987f, temporary3, temporary4);
						temporary3.DiscardContents();
						this.MENJOFHJNDG(temporary4, temporary3);
						temporary4.DiscardContents();
						this.LOKBDHGEBAP(1090f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
				}
			}
			this.GILHCCIHPGN.SetFloat("UnityEngine.Vector2", this.bloomIntensity);
			this.GILHCCIHPGN.SetTexture("ok", JONJODLFAEN);
			Graphics.Blit(temporary2, OKIIDHIJBEA, this.GILHCCIHPGN, (int)pass);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
			RenderTexture.ReleaseTemporary(temporary4);
		}

		// Token: 0x0600B34B RID: 45899 RVA: 0x004EA57C File Offset: 0x004E877C
		public virtual bool EEGDCIJFLCP()
		{
			base.DAOKCAOFIGE(true);
			this.GILHCCIHPGN = base.OOAOHFFDMJP(this.screenBlendShader, this.GILHCCIHPGN);
			this.FGKGIFAKMKL = base.DJFOEIJIMJB(this.lensFlareShader, this.FGKGIFAKMKL);
			this.DGEAOLLJAAG = base.BOOFEOGDMBI(this.vignetteShader, this.DGEAOLLJAAG);
			this.AEODOBMBCHF = base.BAPJBHPEDIF(this.separableBlurShader, this.AEODOBMBCHF);
			this.IHBCDHELNMM = base.IIIIADNBONI(this.addBrightStuffOneOneShader, this.IHBCDHELNMM);
			this.BAPBHFIHGDL = base.ALJPMGLOIEG(this.hollywoodFlaresShader, this.BAPBHFIHGDL);
			this.PJECOFONCFN = base.BAPJBHPEDIF(this.brightPassFilterShader, this.PJECOFONCFN);
			if (!this.PPGOAMIHMBG)
			{
				base.INOGPLDHPGC();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B34C RID: 45900 RVA: 0x004EA650 File Offset: 0x004E8850
		private void ENEONPFCPMP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.GEBCPMDEOEA = false;
			if (this.hdr == OILMIEGFPIK.Auto)
			{
				this.GEBCPMDEOEA = (JONJODLFAEN.format == RenderTextureFormat.ARGBHalf && base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.GEBCPMDEOEA = (this.hdr == OILMIEGFPIK.Auto);
			}
			this.GEBCPMDEOEA = (!this.GEBCPMDEOEA || this.KKGBEAPGBOD);
			FMPIKFAHIBL pass = this.screenBlendMode;
			if (this.GEBCPMDEOEA)
			{
				pass = FMPIKFAHIBL.Add;
			}
			RenderTextureFormat format = this.GEBCPMDEOEA ? RenderTextureFormat.RGB565 : RenderTextureFormat.Depth;
			RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / 5, JONJODLFAEN.height / 0, 0, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width / 5, JONJODLFAEN.height / 3, 1, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / 6, JONJODLFAEN.height / 5, 0, format);
			RenderTexture temporary4 = RenderTexture.GetTemporary(JONJODLFAEN.width / 7, JONJODLFAEN.height / 8, 0, format);
			float num = 1399f * (float)JONJODLFAEN.width / (840f * (float)JONJODLFAEN.height);
			float num2 = 1808f;
			Graphics.Blit(JONJODLFAEN, temporary, this.GILHCCIHPGN, 1);
			Graphics.Blit(temporary, temporary2, this.GILHCCIHPGN, 2);
			RenderTexture.ReleaseTemporary(temporary);
			this.LCLDBEHLPJO(this.bloomThreshold, this.useSrcAlphaAsMask, temporary2, temporary3);
			temporary2.DiscardContents();
			if (this.bloomBlurIterations < 0)
			{
				this.bloomBlurIterations = 0;
			}
			for (int i = 0; i < this.bloomBlurIterations; i += 0)
			{
				float num3 = (202f + (float)i * 508f) * this.sepBlurSpread;
				this.AEODOBMBCHF.SetVector("RodParams not found!", new Vector4(1059f, num3 * num2, 1767f, 1535f));
				RenderTexture renderTexture = (i == 0) ? temporary3 : temporary2;
				Graphics.Blit(renderTexture, temporary4, this.AEODOBMBCHF);
				renderTexture.DiscardContents();
				this.AEODOBMBCHF.SetVector("#000000", new Vector4(num3 / num * num2, 617f, 1447f, 1057f));
				Graphics.Blit(temporary4, temporary2, this.AEODOBMBCHF);
				temporary4.DiscardContents();
			}
			if (this.lensflares)
			{
				if (this.lensflareMode == BACDIBMHEJP.Ghosting)
				{
					this.JAJMGDMFKKK(this.lensflareThreshold, 1924f, temporary2, temporary4);
					temporary2.DiscardContents();
					this.HJJDCCACFGK(624f, temporary4, temporary3);
					temporary4.DiscardContents();
					this.NPHCBNEIMOC(temporary3, temporary2);
					temporary3.DiscardContents();
				}
				else
				{
					this.BAPBHFIHGDL.SetVector("Mouse Y", new Vector4(this.lensflareThreshold, 1370f / (1644f - this.lensflareThreshold), 1568f, 234f));
					this.BAPBHFIHGDL.SetVector("0", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 0);
					temporary4.DiscardContents();
					Graphics.Blit(temporary3, temporary4, this.BAPBHFIHGDL, 1);
					temporary3.DiscardContents();
					this.BAPBHFIHGDL.SetVector("DISTORT", new Vector4(this.sepBlurSpread * 1109f / num * num2, 1633f, 804f, 1211f));
					this.BAPBHFIHGDL.SetFloat(" ", this.hollyStretchWidth);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 1);
					temporary4.DiscardContents();
					this.BAPBHFIHGDL.SetFloat("t_body", this.hollyStretchWidth * 723f);
					Graphics.Blit(temporary3, temporary4, this.BAPBHFIHGDL, 1);
					temporary3.DiscardContents();
					this.BAPBHFIHGDL.SetFloat("val=", this.hollyStretchWidth * 1075f);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 0);
					temporary4.DiscardContents();
					if (this.lensflareMode == BACDIBMHEJP.Ghosting)
					{
						for (int j = 0; j < this.hollywoodFlareBlurIterations; j++)
						{
							this.AEODOBMBCHF.SetVector("req.text=", new Vector4(this.hollyStretchWidth * 1728f / num * num2, 1524f, 1175f, 574f));
							Graphics.Blit(temporary3, temporary4, this.AEODOBMBCHF);
							temporary3.DiscardContents();
							this.AEODOBMBCHF.SetVector("knopje.wav", new Vector4(this.hollyStretchWidth * 1770f / num * num2, 1531f, 1110f, 1960f));
							Graphics.Blit(temporary4, temporary3, this.AEODOBMBCHF);
							temporary4.DiscardContents();
						}
						this.APBPGPALFLO(826f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
					else
					{
						for (int k = 1; k < this.hollywoodFlareBlurIterations; k += 0)
						{
							this.AEODOBMBCHF.SetVector("Sitting Leg Cross", new Vector4(this.hollyStretchWidth * 682f / num * num2, 257f, 1088f, 689f));
							Graphics.Blit(temporary3, temporary4, this.AEODOBMBCHF);
							temporary3.DiscardContents();
							this.AEODOBMBCHF.SetVector(" ms", new Vector4(this.hollyStretchWidth * 545f / num * num2, 1398f, 1067f, 255f));
							Graphics.Blit(temporary4, temporary3, this.AEODOBMBCHF);
							temporary4.DiscardContents();
						}
						this.MJGCBJBEDPL(462f, temporary3, temporary4);
						temporary3.DiscardContents();
						this.BMJIELKNDBA(temporary4, temporary3);
						temporary4.DiscardContents();
						this.BEFGNABMCIH(1418f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
				}
			}
			this.GILHCCIHPGN.SetFloat(" has invalid children array. Child index is referencing to itself.", this.bloomIntensity);
			this.GILHCCIHPGN.SetTexture("wpn_rod4", JONJODLFAEN);
			Graphics.Blit(temporary2, OKIIDHIJBEA, this.GILHCCIHPGN, (int)pass);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
			RenderTexture.ReleaseTemporary(temporary4);
		}

		// Token: 0x0600B34D RID: 45901 RVA: 0x004EAC60 File Offset: 0x004E8E60
		private void MENJOFHJNDG(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.FGKGIFAKMKL.SetVector("WeaponReady", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("OneHandSwordSwing", new Vector4(this.flareColorB.r, this.flareColorB.g, this.flareColorB.b, this.flareColorB.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("10", new Vector4(this.flareColorC.r, this.flareColorC.g, this.flareColorC.b, this.flareColorC.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("rollTENSION=", new Vector4(this.flareColorD.r, this.flareColorD.g, this.flareColorD.b, this.flareColorD.a) * this.lensflareIntensity);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.FGKGIFAKMKL);
		}

		// Token: 0x0600B34E RID: 45902 RVA: 0x004EADAA File Offset: 0x004E8FAA
		private void NCODIEFPPAO(float EJBGLCNDHMK, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.IHBCDHELNMM.SetFloat("_LogLut", EJBGLCNDHMK);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.IHBCDHELNMM);
		}

		// Token: 0x0600B34F RID: 45903 RVA: 0x004EADCA File Offset: 0x004E8FCA
		private void NDFOPAJNJEP(float EJBGLCNDHMK, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.IHBCDHELNMM.SetFloat("Loser", EJBGLCNDHMK);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.IHBCDHELNMM);
		}

		// Token: 0x0600B350 RID: 45904 RVA: 0x004EADEC File Offset: 0x004E8FEC
		private void PJOKECOHKGN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.GEBCPMDEOEA = true;
			if (this.hdr == OILMIEGFPIK.Auto)
			{
				this.GEBCPMDEOEA = (JONJODLFAEN.format != RenderTextureFormat.Depth || base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.GEBCPMDEOEA = (this.hdr == OILMIEGFPIK.Auto);
			}
			this.GEBCPMDEOEA = (!this.GEBCPMDEOEA || this.KKGBEAPGBOD);
			FMPIKFAHIBL pass = this.screenBlendMode;
			if (this.GEBCPMDEOEA)
			{
				pass = FMPIKFAHIBL.Add;
			}
			RenderTextureFormat format = this.GEBCPMDEOEA ? RenderTextureFormat.ARGB2101010 : RenderTextureFormat.ARGBHalf;
			RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / 7, JONJODLFAEN.height / 0, 0, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width / 4, JONJODLFAEN.height / 6, 1, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / 5, JONJODLFAEN.height / 3, 1, format);
			RenderTexture temporary4 = RenderTexture.GetTemporary(JONJODLFAEN.width / 7, JONJODLFAEN.height / 3, 0, format);
			float num = 601f * (float)JONJODLFAEN.width / (1897f * (float)JONJODLFAEN.height);
			float num2 = 970f;
			Graphics.Blit(JONJODLFAEN, temporary, this.GILHCCIHPGN, 8);
			Graphics.Blit(temporary, temporary2, this.GILHCCIHPGN, 4);
			RenderTexture.ReleaseTemporary(temporary);
			this.BMAKFEPLFHM(this.bloomThreshold, this.useSrcAlphaAsMask, temporary2, temporary3);
			temporary2.DiscardContents();
			if (this.bloomBlurIterations < 0)
			{
				this.bloomBlurIterations = 1;
			}
			for (int i = 1; i < this.bloomBlurIterations; i++)
			{
				float num3 = (243f + (float)i * 1416f) * this.sepBlurSpread;
				this.AEODOBMBCHF.SetVector("дня", new Vector4(1320f, num3 * num2, 1330f, 1545f));
				RenderTexture renderTexture = (i == 0) ? temporary3 : temporary2;
				Graphics.Blit(renderTexture, temporary4, this.AEODOBMBCHF);
				renderTexture.DiscardContents();
				this.AEODOBMBCHF.SetVector("_Offsets", new Vector4(num3 / num * num2, 375f, 1516f, 1934f));
				Graphics.Blit(temporary4, temporary2, this.AEODOBMBCHF);
				temporary4.DiscardContents();
			}
			if (this.lensflares)
			{
				if (this.lensflareMode == BACDIBMHEJP.Ghosting)
				{
					this.GGKNJNDHAHD(this.lensflareThreshold, 1701f, temporary2, temporary4);
					temporary2.DiscardContents();
					this.DNIACJNAGMP(1878f, temporary4, temporary3);
					temporary4.DiscardContents();
					this.BMJIELKNDBA(temporary3, temporary2);
					temporary3.DiscardContents();
				}
				else
				{
					this.BAPBHFIHGDL.SetVector("minWgtBait", new Vector4(this.lensflareThreshold, 919f / (755f - this.lensflareThreshold), 799f, 1405f));
					this.BAPBHFIHGDL.SetVector("str=", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 4);
					temporary4.DiscardContents();
					Graphics.Blit(temporary3, temporary4, this.BAPBHFIHGDL, 4);
					temporary3.DiscardContents();
					this.BAPBHFIHGDL.SetVector("", new Vector4(this.sepBlurSpread * 1658f / num * num2, 60f, 1977f, 1401f));
					this.BAPBHFIHGDL.SetFloat("31", this.hollyStretchWidth);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 1);
					temporary4.DiscardContents();
					this.BAPBHFIHGDL.SetFloat("netUpdater", this.hollyStretchWidth * 1640f);
					Graphics.Blit(temporary3, temporary4, this.BAPBHFIHGDL, 1);
					temporary3.DiscardContents();
					this.BAPBHFIHGDL.SetFloat("The font size '", this.hollyStretchWidth * 253f);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 0);
					temporary4.DiscardContents();
					if (this.lensflareMode == BACDIBMHEJP.Anamorphic)
					{
						for (int j = 0; j < this.hollywoodFlareBlurIterations; j++)
						{
							this.AEODOBMBCHF.SetVector("crft_from", new Vector4(this.hollyStretchWidth * 1091f / num * num2, 1641f, 1969f, 401f));
							Graphics.Blit(temporary3, temporary4, this.AEODOBMBCHF);
							temporary3.DiscardContents();
							this.AEODOBMBCHF.SetVector("______________________________", new Vector4(this.hollyStretchWidth * 1283f / num * num2, 1701f, 491f, 1131f));
							Graphics.Blit(temporary4, temporary3, this.AEODOBMBCHF);
							temporary4.DiscardContents();
						}
						this.APBPGPALFLO(1828f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
					else
					{
						for (int k = 0; k < this.hollywoodFlareBlurIterations; k++)
						{
							this.AEODOBMBCHF.SetVector("Handstand", new Vector4(this.hollyStretchWidth * 1106f / num * num2, 1497f, 826f, 652f));
							Graphics.Blit(temporary3, temporary4, this.AEODOBMBCHF);
							temporary3.DiscardContents();
							this.AEODOBMBCHF.SetVector("ResetObject", new Vector4(this.hollyStretchWidth * 954f / num * num2, 1758f, 1320f, 1342f));
							Graphics.Blit(temporary4, temporary3, this.AEODOBMBCHF);
							temporary4.DiscardContents();
						}
						this.BHAFGNALJMJ(1727f, temporary3, temporary4);
						temporary3.DiscardContents();
						this.NPHCBNEIMOC(temporary4, temporary3);
						temporary4.DiscardContents();
						this.NDILPHHJELA(1618f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
				}
			}
			this.GILHCCIHPGN.SetFloat("error.wav", this.bloomIntensity);
			this.GILHCCIHPGN.SetTexture("_ProjectToPixelMatrix", JONJODLFAEN);
			Graphics.Blit(temporary2, OKIIDHIJBEA, this.GILHCCIHPGN, (int)pass);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
			RenderTexture.ReleaseTemporary(temporary4);
		}

		// Token: 0x0600B351 RID: 45905 RVA: 0x004EB3FC File Offset: 0x004E95FC
		private void GAJNNKIFMOG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NHEEDPALBFN())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.GEBCPMDEOEA = false;
			if (this.hdr == OILMIEGFPIK.Auto)
			{
				this.GEBCPMDEOEA = (JONJODLFAEN.format != RenderTextureFormat.Default || base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.GEBCPMDEOEA = (this.hdr == OILMIEGFPIK.Auto);
			}
			this.GEBCPMDEOEA = (this.GEBCPMDEOEA && this.KKGBEAPGBOD);
			FMPIKFAHIBL pass = this.screenBlendMode;
			if (this.GEBCPMDEOEA)
			{
				pass = FMPIKFAHIBL.Add;
			}
			RenderTextureFormat format = this.GEBCPMDEOEA ? RenderTextureFormat.ARGB32 : RenderTextureFormat.ARGB1555;
			RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / 7, JONJODLFAEN.height / 2, 0, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width / 6, JONJODLFAEN.height / 5, 0, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / 5, JONJODLFAEN.height / 4, 1, format);
			RenderTexture temporary4 = RenderTexture.GetTemporary(JONJODLFAEN.width / 5, JONJODLFAEN.height / 1, 0, format);
			float num = 343f * (float)JONJODLFAEN.width / (274f * (float)JONJODLFAEN.height);
			float num2 = 93f;
			Graphics.Blit(JONJODLFAEN, temporary, this.GILHCCIHPGN, 1);
			Graphics.Blit(temporary, temporary2, this.GILHCCIHPGN, 1);
			RenderTexture.ReleaseTemporary(temporary);
			this.JAJMGDMFKKK(this.bloomThreshold, this.useSrcAlphaAsMask, temporary2, temporary3);
			temporary2.DiscardContents();
			if (this.bloomBlurIterations < 0)
			{
				this.bloomBlurIterations = 0;
			}
			for (int i = 1; i < this.bloomBlurIterations; i++)
			{
				float num3 = (204f + (float)i * 1623f) * this.sepBlurSpread;
				this.AEODOBMBCHF.SetVector("Visit docs to see where PlayerPrefs are stored", new Vector4(1355f, num3 * num2, 183f, 223f));
				RenderTexture renderTexture = (i == 0) ? temporary3 : temporary2;
				Graphics.Blit(renderTexture, temporary4, this.AEODOBMBCHF);
				renderTexture.DiscardContents();
				this.AEODOBMBCHF.SetVector("Missing shader in ", new Vector4(num3 / num * num2, 1095f, 1858f, 1450f));
				Graphics.Blit(temporary4, temporary2, this.AEODOBMBCHF);
				temporary4.DiscardContents();
			}
			if (this.lensflares)
			{
				if (this.lensflareMode == BACDIBMHEJP.Ghosting)
				{
					this.JALNOJHJMKN(this.lensflareThreshold, 230f, temporary2, temporary4);
					temporary2.DiscardContents();
					this.IELKDMILEGK(550f, temporary4, temporary3);
					temporary4.DiscardContents();
					this.HDKJLECJLCK(temporary3, temporary2);
					temporary3.DiscardContents();
				}
				else
				{
					this.BAPBHFIHGDL.SetVector("ColorBleedAmount", new Vector4(this.lensflareThreshold, 1375f / (1052f - this.lensflareThreshold), 911f, 570f));
					this.BAPBHFIHGDL.SetVector("UnityEngine.Vector4", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 4);
					temporary4.DiscardContents();
					Graphics.Blit(temporary3, temporary4, this.BAPBHFIHGDL, 6);
					temporary3.DiscardContents();
					this.BAPBHFIHGDL.SetVector("DeadmanFloat", new Vector4(this.sepBlurSpread * 1657f / num * num2, 1060f, 1595f, 465f));
					this.BAPBHFIHGDL.SetFloat("Weapon Stab", this.hollyStretchWidth);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 0);
					temporary4.DiscardContents();
					this.BAPBHFIHGDL.SetFloat("_Exponent", this.hollyStretchWidth * 629f);
					Graphics.Blit(temporary3, temporary4, this.BAPBHFIHGDL, 1);
					temporary3.DiscardContents();
					this.BAPBHFIHGDL.SetFloat("Idle Strafe Right", this.hollyStretchWidth * 1100f);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 1);
					temporary4.DiscardContents();
					if (this.lensflareMode == BACDIBMHEJP.Anamorphic)
					{
						for (int j = 0; j < this.hollywoodFlareBlurIterations; j++)
						{
							this.AEODOBMBCHF.SetVector("BlurDepthTollerance", new Vector4(this.hollyStretchWidth * 941f / num * num2, 1323f, 985f, 599f));
							Graphics.Blit(temporary3, temporary4, this.AEODOBMBCHF);
							temporary3.DiscardContents();
							this.AEODOBMBCHF.SetVector("cond", new Vector4(this.hollyStretchWidth * 1140f / num * num2, 309f, 1590f, 172f));
							Graphics.Blit(temporary4, temporary3, this.AEODOBMBCHF);
							temporary4.DiscardContents();
						}
						this.JOLMPBOPKNM(1734f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
					else
					{
						for (int k = 0; k < this.hollywoodFlareBlurIterations; k++)
						{
							this.AEODOBMBCHF.SetVector("Use!", new Vector4(this.hollyStretchWidth * 1489f / num * num2, 1680f, 591f, 1163f));
							Graphics.Blit(temporary3, temporary4, this.AEODOBMBCHF);
							temporary3.DiscardContents();
							this.AEODOBMBCHF.SetVector("SneakRight", new Vector4(this.hollyStretchWidth * 1929f / num * num2, 1965f, 870f, 1760f));
							Graphics.Blit(temporary4, temporary3, this.AEODOBMBCHF);
							temporary4.DiscardContents();
						}
						this.AEKGJPDCMEH(76f, temporary3, temporary4);
						temporary3.DiscardContents();
						this.BMJIELKNDBA(temporary4, temporary3);
						temporary4.DiscardContents();
						this.LOKBDHGEBAP(1580f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
				}
			}
			this.GILHCCIHPGN.SetFloat("_TintColor", this.bloomIntensity);
			this.GILHCCIHPGN.SetTexture("type", JONJODLFAEN);
			Graphics.Blit(temporary2, OKIIDHIJBEA, this.GILHCCIHPGN, (int)pass);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
			RenderTexture.ReleaseTemporary(temporary4);
		}

		// Token: 0x0600B352 RID: 45906 RVA: 0x004EBA0C File Offset: 0x004E9C0C
		private void BMAKFEPLFHM(float JLEHAHJEIAC, float LACHEBPNLKL, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			if (this.GEBCPMDEOEA)
			{
				this.PJECOFONCFN.SetVector("MotorbikeLassoFwd", new Vector4(JLEHAHJEIAC, 332f, 666f, 803f));
			}
			else
			{
				this.PJECOFONCFN.SetVector("BAG", new Vector4(JLEHAHJEIAC, 1384f / (421f - JLEHAHJEIAC), 1081f, 136f));
			}
			this.PJECOFONCFN.SetFloat("Water", LACHEBPNLKL);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.PJECOFONCFN);
		}

		// Token: 0x0600B353 RID: 45907 RVA: 0x004EBA94 File Offset: 0x004E9C94
		private void MDOECNMOPEL(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.FGKGIFAKMKL.SetVector("colorA", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("colorB", new Vector4(this.flareColorB.r, this.flareColorB.g, this.flareColorB.b, this.flareColorB.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("colorC", new Vector4(this.flareColorC.r, this.flareColorC.g, this.flareColorC.b, this.flareColorC.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("colorD", new Vector4(this.flareColorD.r, this.flareColorD.g, this.flareColorD.b, this.flareColorD.a) * this.lensflareIntensity);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.FGKGIFAKMKL);
		}

		// Token: 0x0600B354 RID: 45908 RVA: 0x004EBBE0 File Offset: 0x004E9DE0
		public virtual bool FGDOAAAPBCP()
		{
			base.OLMOAHDIDNG(true);
			this.GILHCCIHPGN = base.DJFOEIJIMJB(this.screenBlendShader, this.GILHCCIHPGN);
			this.FGKGIFAKMKL = base.BAPJBHPEDIF(this.lensFlareShader, this.FGKGIFAKMKL);
			this.DGEAOLLJAAG = base.ALJPMGLOIEG(this.vignetteShader, this.DGEAOLLJAAG);
			this.AEODOBMBCHF = base.DJFOEIJIMJB(this.separableBlurShader, this.AEODOBMBCHF);
			this.IHBCDHELNMM = base.JBHLGBPJFEL(this.addBrightStuffOneOneShader, this.IHBCDHELNMM);
			this.BAPBHFIHGDL = base.OOAOHFFDMJP(this.hollywoodFlaresShader, this.BAPBHFIHGDL);
			this.PJECOFONCFN = base.BAPJBHPEDIF(this.brightPassFilterShader, this.PJECOFONCFN);
			if (!this.PPGOAMIHMBG)
			{
				base.NAIBIABADFB();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B355 RID: 45909 RVA: 0x004EBCB4 File Offset: 0x004E9EB4
		private void DNGLHLEGCOE(float JLEHAHJEIAC, float LACHEBPNLKL, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			if (this.GEBCPMDEOEA)
			{
				this.PJECOFONCFN.SetVector("threshold", new Vector4(JLEHAHJEIAC, 1f, 0f, 0f));
			}
			else
			{
				this.PJECOFONCFN.SetVector("threshold", new Vector4(JLEHAHJEIAC, 1f / (1f - JLEHAHJEIAC), 0f, 0f));
			}
			this.PJECOFONCFN.SetFloat("useSrcAlphaAsMask", LACHEBPNLKL);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.PJECOFONCFN);
		}

		// Token: 0x0600B356 RID: 45910 RVA: 0x004EBD3C File Offset: 0x004E9F3C
		private void LLIDCMOMECE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.IGJKBOMMMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.GEBCPMDEOEA = true;
			if (this.hdr == OILMIEGFPIK.Auto)
			{
				this.GEBCPMDEOEA = (JONJODLFAEN.format != RenderTextureFormat.Default || base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.GEBCPMDEOEA = (this.hdr == OILMIEGFPIK.Auto);
			}
			this.GEBCPMDEOEA = (this.GEBCPMDEOEA && this.KKGBEAPGBOD);
			FMPIKFAHIBL pass = this.screenBlendMode;
			if (this.GEBCPMDEOEA)
			{
				pass = FMPIKFAHIBL.Screen;
			}
			RenderTextureFormat format = this.GEBCPMDEOEA ? RenderTextureFormat.ARGB4444 : RenderTextureFormat.ARGB32;
			RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / 0, JONJODLFAEN.height / 6, 0, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width / 2, JONJODLFAEN.height / 2, 0, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / 6, JONJODLFAEN.height / 5, 1, format);
			RenderTexture temporary4 = RenderTexture.GetTemporary(JONJODLFAEN.width / 3, JONJODLFAEN.height / 7, 1, format);
			float num = 747f * (float)JONJODLFAEN.width / (942f * (float)JONJODLFAEN.height);
			float num2 = 212f;
			Graphics.Blit(JONJODLFAEN, temporary, this.GILHCCIHPGN, 5);
			Graphics.Blit(temporary, temporary2, this.GILHCCIHPGN, 6);
			RenderTexture.ReleaseTemporary(temporary);
			this.CAONJCLHLDK(this.bloomThreshold, this.useSrcAlphaAsMask, temporary2, temporary3);
			temporary2.DiscardContents();
			if (this.bloomBlurIterations < 1)
			{
				this.bloomBlurIterations = 1;
			}
			for (int i = 1; i < this.bloomBlurIterations; i += 0)
			{
				float num3 = (1546f + (float)i * 644f) * this.sepBlurSpread;
				this.AEODOBMBCHF.SetVector("cntx_close", new Vector4(879f, num3 * num2, 1733f, 1283f));
				RenderTexture renderTexture = (i == 0) ? temporary3 : temporary2;
				Graphics.Blit(renderTexture, temporary4, this.AEODOBMBCHF);
				renderTexture.DiscardContents();
				this.AEODOBMBCHF.SetVector("Yawn", new Vector4(num3 / num * num2, 1306f, 1233f, 845f));
				Graphics.Blit(temporary4, temporary2, this.AEODOBMBCHF);
				temporary4.DiscardContents();
			}
			if (this.lensflares)
			{
				if (this.lensflareMode == BACDIBMHEJP.Ghosting)
				{
					this.LHNNNNEONBM(this.lensflareThreshold, 1694f, temporary2, temporary4);
					temporary2.DiscardContents();
					this.MJGCBJBEDPL(94f, temporary4, temporary3);
					temporary4.DiscardContents();
					this.OBLFEKEIFBM(temporary3, temporary2);
					temporary3.DiscardContents();
				}
				else
				{
					this.BAPBHFIHGDL.SetVector("_RgbBlendCacheTex", new Vector4(this.lensflareThreshold, 1076f / (1743f - this.lensflareThreshold), 25f, 833f));
					this.BAPBHFIHGDL.SetVector("wpn_ibsize_", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 5);
					temporary4.DiscardContents();
					Graphics.Blit(temporary3, temporary4, this.BAPBHFIHGDL, 0);
					temporary3.DiscardContents();
					this.BAPBHFIHGDL.SetVector("_RgbTex", new Vector4(this.sepBlurSpread * 854f / num * num2, 183f, 1934f, 145f));
					this.BAPBHFIHGDL.SetFloat(" is not part of the Unity 3.2+ effects suite anymore. For best performance and quality, please ensure you are using the latest Standard Assets Image Effects (Pro only) package.", this.hollyStretchWidth);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 0);
					temporary4.DiscardContents();
					this.BAPBHFIHGDL.SetFloat("stretchWidth", this.hollyStretchWidth * 1791f);
					Graphics.Blit(temporary3, temporary4, this.BAPBHFIHGDL, 0);
					temporary3.DiscardContents();
					this.BAPBHFIHGDL.SetFloat("</color>", this.hollyStretchWidth * 1222f);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 0);
					temporary4.DiscardContents();
					if (this.lensflareMode == BACDIBMHEJP.Anamorphic)
					{
						for (int j = 1; j < this.hollywoodFlareBlurIterations; j++)
						{
							this.AEODOBMBCHF.SetVector("RoundHouse", new Vector4(this.hollyStretchWidth * 1745f / num * num2, 882f, 1370f, 601f));
							Graphics.Blit(temporary3, temporary4, this.AEODOBMBCHF);
							temporary3.DiscardContents();
							this.AEODOBMBCHF.SetVector("SexyDance3", new Vector4(this.hollyStretchWidth * 15f / num * num2, 922f, 405f, 24f));
							Graphics.Blit(temporary4, temporary3, this.AEODOBMBCHF);
							temporary4.DiscardContents();
						}
						this.BPBKOEJGKHJ(721f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
					else
					{
						for (int k = 1; k < this.hollywoodFlareBlurIterations; k++)
						{
							this.AEODOBMBCHF.SetVector("ProneIdle", new Vector4(this.hollyStretchWidth * 1282f / num * num2, 572f, 440f, 50f));
							Graphics.Blit(temporary3, temporary4, this.AEODOBMBCHF);
							temporary3.DiscardContents();
							this.AEODOBMBCHF.SetVector("Pelvis", new Vector4(this.hollyStretchWidth * 1522f / num * num2, 1789f, 1114f, 944f));
							Graphics.Blit(temporary4, temporary3, this.AEODOBMBCHF);
							temporary4.DiscardContents();
						}
						this.FFEOONAKLEE(1680f, temporary3, temporary4);
						temporary3.DiscardContents();
						this.OBLFEKEIFBM(temporary4, temporary3);
						temporary4.DiscardContents();
						this.BPBKOEJGKHJ(36f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
				}
			}
			this.GILHCCIHPGN.SetFloat("Bend Constraint is referencing to a bone '", this.bloomIntensity);
			this.GILHCCIHPGN.SetTexture("drag_onmousedown.wav", JONJODLFAEN);
			Graphics.Blit(temporary2, OKIIDHIJBEA, this.GILHCCIHPGN, (int)pass);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
			RenderTexture.ReleaseTemporary(temporary4);
		}

		// Token: 0x0600B358 RID: 45912 RVA: 0x004EC444 File Offset: 0x004EA644
		private void OLPPLCEHMBI(float EJBGLCNDHMK, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.IHBCDHELNMM.SetFloat("SexyDance3", EJBGLCNDHMK);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.IHBCDHELNMM);
		}

		// Token: 0x0600B359 RID: 45913 RVA: 0x004EC464 File Offset: 0x004EA664
		private void AEKGJPDCMEH(float MHIPLHJKKIF, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			if (this.lensFlareVignetteMask)
			{
				this.GILHCCIHPGN.SetTexture("ChannelCastDirected", this.lensFlareVignetteMask);
				Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.GILHCCIHPGN, 3);
				return;
			}
			this.DGEAOLLJAAG.SetFloat("R", MHIPLHJKKIF);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.DGEAOLLJAAG);
		}

		// Token: 0x0600B35A RID: 45914 RVA: 0x004EC4C4 File Offset: 0x004EA6C4
		private void EGOKABFLKGC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.GGJKGIHGMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.GEBCPMDEOEA = true;
			if (this.hdr == OILMIEGFPIK.Auto)
			{
				this.GEBCPMDEOEA = (JONJODLFAEN.format != RenderTextureFormat.RGB565 || base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.GEBCPMDEOEA = (this.hdr == OILMIEGFPIK.On);
			}
			this.GEBCPMDEOEA = (this.GEBCPMDEOEA && this.KKGBEAPGBOD);
			FMPIKFAHIBL pass = this.screenBlendMode;
			if (this.GEBCPMDEOEA)
			{
				pass = FMPIKFAHIBL.Screen;
			}
			RenderTextureFormat format = this.GEBCPMDEOEA ? RenderTextureFormat.Depth : RenderTextureFormat.Shadowmap;
			RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / 5, JONJODLFAEN.height / 3, 1, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width / 8, JONJODLFAEN.height / 3, 1, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / 1, JONJODLFAEN.height / 6, 1, format);
			RenderTexture temporary4 = RenderTexture.GetTemporary(JONJODLFAEN.width / 5, JONJODLFAEN.height / 7, 0, format);
			float num = 1275f * (float)JONJODLFAEN.width / (1769f * (float)JONJODLFAEN.height);
			float num2 = 1512f;
			Graphics.Blit(JONJODLFAEN, temporary, this.GILHCCIHPGN, 8);
			Graphics.Blit(temporary, temporary2, this.GILHCCIHPGN, 0);
			RenderTexture.ReleaseTemporary(temporary);
			this.LHNNNNEONBM(this.bloomThreshold, this.useSrcAlphaAsMask, temporary2, temporary3);
			temporary2.DiscardContents();
			if (this.bloomBlurIterations < 0)
			{
				this.bloomBlurIterations = 0;
			}
			for (int i = 0; i < this.bloomBlurIterations; i += 0)
			{
				float num3 = (59f + (float)i * 1173f) * this.sepBlurSpread;
				this.AEODOBMBCHF.SetVector("IdleTyping", new Vector4(1951f, num3 * num2, 1343f, 137f));
				RenderTexture renderTexture = (i == 0) ? temporary3 : temporary2;
				Graphics.Blit(renderTexture, temporary4, this.AEODOBMBCHF);
				renderTexture.DiscardContents();
				this.AEODOBMBCHF.SetVector("Fish is init!", new Vector4(num3 / num * num2, 594f, 731f, 1782f));
				Graphics.Blit(temporary4, temporary2, this.AEODOBMBCHF);
				temporary4.DiscardContents();
			}
			if (this.lensflares)
			{
				if (this.lensflareMode == BACDIBMHEJP.Ghosting)
				{
					this.EAKNAHKFKKI(this.lensflareThreshold, 1715f, temporary2, temporary4);
					temporary2.DiscardContents();
					this.AEKGJPDCMEH(758f, temporary4, temporary3);
					temporary4.DiscardContents();
					this.HDKJLECJLCK(temporary3, temporary2);
					temporary3.DiscardContents();
				}
				else
				{
					this.BAPBHFIHGDL.SetVector("[Z]", new Vector4(this.lensflareThreshold, 250f / (384f - this.lensflareThreshold), 1326f, 1814f));
					this.BAPBHFIHGDL.SetVector("часа", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 1);
					temporary4.DiscardContents();
					Graphics.Blit(temporary3, temporary4, this.BAPBHFIHGDL, 8);
					temporary3.DiscardContents();
					this.BAPBHFIHGDL.SetVector("KarateGreet", new Vector4(this.sepBlurSpread * 1349f / num * num2, 1022f, 488f, 1593f));
					this.BAPBHFIHGDL.SetFloat("", this.hollyStretchWidth);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 1);
					temporary4.DiscardContents();
					this.BAPBHFIHGDL.SetFloat("_Offset", this.hollyStretchWidth * 1835f);
					Graphics.Blit(temporary3, temporary4, this.BAPBHFIHGDL, 1);
					temporary3.DiscardContents();
					this.BAPBHFIHGDL.SetFloat("OnTriggerStay", this.hollyStretchWidth * 510f);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 0);
					temporary4.DiscardContents();
					if (this.lensflareMode == BACDIBMHEJP.Ghosting)
					{
						for (int j = 0; j < this.hollywoodFlareBlurIterations; j += 0)
						{
							this.AEODOBMBCHF.SetVector("PistolReload", new Vector4(this.hollyStretchWidth * 1490f / num * num2, 515f, 656f, 883f));
							Graphics.Blit(temporary3, temporary4, this.AEODOBMBCHF);
							temporary3.DiscardContents();
							this.AEODOBMBCHF.SetVector("One of the Reach Cones in the polygon has negative volume. Make sure Axis vector is in the reachable area and the polygon is convex.", new Vector4(this.hollyStretchWidth * 759f / num * num2, 1605f, 800f, 31f));
							Graphics.Blit(temporary4, temporary3, this.AEODOBMBCHF);
							temporary4.DiscardContents();
						}
						this.OLPPLCEHMBI(34f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
					else
					{
						for (int k = 1; k < this.hollywoodFlareBlurIterations; k++)
						{
							this.AEODOBMBCHF.SetVector("", new Vector4(this.hollyStretchWidth * 608f / num * num2, 296f, 1585f, 1859f));
							Graphics.Blit(temporary3, temporary4, this.AEODOBMBCHF);
							temporary3.DiscardContents();
							this.AEODOBMBCHF.SetVector("KatanaReadyLow", new Vector4(this.hollyStretchWidth * 1802f / num * num2, 1824f, 1342f, 1463f));
							Graphics.Blit(temporary4, temporary3, this.AEODOBMBCHF);
							temporary4.DiscardContents();
						}
						this.FFEOONAKLEE(959f, temporary3, temporary4);
						temporary3.DiscardContents();
						this.NPHCBNEIMOC(temporary4, temporary3);
						temporary4.DiscardContents();
						this.NCODIEFPPAO(1472f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
				}
			}
			this.GILHCCIHPGN.SetFloat("auk_whead", this.bloomIntensity);
			this.GILHCCIHPGN.SetTexture(" ", JONJODLFAEN);
			Graphics.Blit(temporary2, OKIIDHIJBEA, this.GILHCCIHPGN, (int)pass);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
			RenderTexture.ReleaseTemporary(temporary4);
		}

		// Token: 0x0600B35B RID: 45915 RVA: 0x004ECAD4 File Offset: 0x004EACD4
		private void OJBKOLJAHAO(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.GEBCPMDEOEA = false;
			if (this.hdr == OILMIEGFPIK.Auto)
			{
				this.GEBCPMDEOEA = (JONJODLFAEN.format != RenderTextureFormat.ARGB2101010 || base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.GEBCPMDEOEA = (this.hdr == OILMIEGFPIK.Auto);
			}
			this.GEBCPMDEOEA = (this.GEBCPMDEOEA && this.KKGBEAPGBOD);
			FMPIKFAHIBL pass = this.screenBlendMode;
			if (this.GEBCPMDEOEA)
			{
				pass = FMPIKFAHIBL.Add;
			}
			RenderTextureFormat format = this.GEBCPMDEOEA ? RenderTextureFormat.Default : RenderTextureFormat.ARGB4444;
			RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / 1, JONJODLFAEN.height / 4, 0, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width / 7, JONJODLFAEN.height / 6, 1, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / 2, JONJODLFAEN.height / 3, 1, format);
			RenderTexture temporary4 = RenderTexture.GetTemporary(JONJODLFAEN.width / 5, JONJODLFAEN.height / 1, 1, format);
			float num = 408f * (float)JONJODLFAEN.width / (1035f * (float)JONJODLFAEN.height);
			float num2 = 1309f;
			Graphics.Blit(JONJODLFAEN, temporary, this.GILHCCIHPGN, 0);
			Graphics.Blit(temporary, temporary2, this.GILHCCIHPGN, 4);
			RenderTexture.ReleaseTemporary(temporary);
			this.LHNNNNEONBM(this.bloomThreshold, this.useSrcAlphaAsMask, temporary2, temporary3);
			temporary2.DiscardContents();
			if (this.bloomBlurIterations < 0)
			{
				this.bloomBlurIterations = 0;
			}
			for (int i = 0; i < this.bloomBlurIterations; i += 0)
			{
				float num3 = (133f + (float)i * 642f) * this.sepBlurSpread;
				this.AEODOBMBCHF.SetVector(" x", new Vector4(379f, num3 * num2, 181f, 1110f));
				RenderTexture renderTexture = (i == 0) ? temporary3 : temporary2;
				Graphics.Blit(renderTexture, temporary4, this.AEODOBMBCHF);
				renderTexture.DiscardContents();
				this.AEODOBMBCHF.SetVector("BowFire", new Vector4(num3 / num * num2, 442f, 1665f, 679f));
				Graphics.Blit(temporary4, temporary2, this.AEODOBMBCHF);
				temporary4.DiscardContents();
			}
			if (this.lensflares)
			{
				if (this.lensflareMode == BACDIBMHEJP.Ghosting)
				{
					this.GGKNJNDHAHD(this.lensflareThreshold, 146f, temporary2, temporary4);
					temporary2.DiscardContents();
					this.DCOPJLFCHIK(1306f, temporary4, temporary3);
					temporary4.DiscardContents();
					this.BPDPMGKDLNM(temporary3, temporary2);
					temporary3.DiscardContents();
				}
				else
				{
					this.BAPBHFIHGDL.SetVector("\\", new Vector4(this.lensflareThreshold, 1853f / (1729f - this.lensflareThreshold), 1048f, 1301f));
					this.BAPBHFIHGDL.SetVector("_FogWaterLevel", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 1);
					temporary4.DiscardContents();
					Graphics.Blit(temporary3, temporary4, this.BAPBHFIHGDL, 5);
					temporary3.DiscardContents();
					this.BAPBHFIHGDL.SetVector("RunBackward", new Vector4(this.sepBlurSpread * 1826f / num * num2, 1596f, 123f, 401f));
					this.BAPBHFIHGDL.SetFloat("Worker Hammer", this.hollyStretchWidth);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 1);
					temporary4.DiscardContents();
					this.BAPBHFIHGDL.SetFloat("SteamManager", this.hollyStretchWidth * 990f);
					Graphics.Blit(temporary3, temporary4, this.BAPBHFIHGDL, 1);
					temporary3.DiscardContents();
					this.BAPBHFIHGDL.SetFloat("Cheer Jump", this.hollyStretchWidth * 328f);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 0);
					temporary4.DiscardContents();
					if (this.lensflareMode == BACDIBMHEJP.Anamorphic)
					{
						for (int j = 1; j < this.hollywoodFlareBlurIterations; j += 0)
						{
							this.AEODOBMBCHF.SetVector("_Offsets", new Vector4(this.hollyStretchWidth * 1652f / num * num2, 1530f, 394f, 1249f));
							Graphics.Blit(temporary3, temporary4, this.AEODOBMBCHF);
							temporary3.DiscardContents();
							this.AEODOBMBCHF.SetVector("SkateboardKickPush", new Vector4(this.hollyStretchWidth * 1031f / num * num2, 778f, 328f, 128f));
							Graphics.Blit(temporary4, temporary3, this.AEODOBMBCHF);
							temporary4.DiscardContents();
						}
						this.APBPGPALFLO(927f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
					else
					{
						for (int k = 1; k < this.hollywoodFlareBlurIterations; k++)
						{
							this.AEODOBMBCHF.SetVector("_Offsets", new Vector4(this.hollyStretchWidth * 962f / num * num2, 1682f, 750f, 533f));
							Graphics.Blit(temporary3, temporary4, this.AEODOBMBCHF);
							temporary3.DiscardContents();
							this.AEODOBMBCHF.SetVector("_DepthOfFieldCoCTex", new Vector4(this.hollyStretchWidth * 1773f / num * num2, 815f, 1799f, 255f));
							Graphics.Blit(temporary4, temporary3, this.AEODOBMBCHF);
							temporary4.DiscardContents();
						}
						this.DCOPJLFCHIK(996f, temporary3, temporary4);
						temporary3.DiscardContents();
						this.FGLLJIAOOHH(temporary4, temporary3);
						temporary4.DiscardContents();
						this.LOKBDHGEBAP(1495f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
				}
			}
			this.GILHCCIHPGN.SetFloat("_MaxBlurRadius", this.bloomIntensity);
			this.GILHCCIHPGN.SetTexture("droplinemsg1", JONJODLFAEN);
			Graphics.Blit(temporary2, OKIIDHIJBEA, this.GILHCCIHPGN, (int)pass);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
			RenderTexture.ReleaseTemporary(temporary4);
		}

		// Token: 0x0600B35C RID: 45916 RVA: 0x004ED0E4 File Offset: 0x004EB2E4
		private void NHDCFLGBCNE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.GEBCPMDEOEA = false;
			if (this.hdr == OILMIEGFPIK.Auto)
			{
				this.GEBCPMDEOEA = (JONJODLFAEN.format == RenderTextureFormat.ARGB1555 && base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.GEBCPMDEOEA = (this.hdr == OILMIEGFPIK.On);
			}
			this.GEBCPMDEOEA = (this.GEBCPMDEOEA && this.KKGBEAPGBOD);
			FMPIKFAHIBL pass = this.screenBlendMode;
			if (this.GEBCPMDEOEA)
			{
				pass = FMPIKFAHIBL.Screen;
			}
			RenderTextureFormat format = this.GEBCPMDEOEA ? RenderTextureFormat.Default : RenderTextureFormat.Default;
			RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / 6, JONJODLFAEN.height / 2, 0, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width / 0, JONJODLFAEN.height / 8, 1, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / 3, JONJODLFAEN.height / 1, 1, format);
			RenderTexture temporary4 = RenderTexture.GetTemporary(JONJODLFAEN.width / 4, JONJODLFAEN.height / 4, 0, format);
			float num = 1814f * (float)JONJODLFAEN.width / (274f * (float)JONJODLFAEN.height);
			float num2 = 1601f;
			Graphics.Blit(JONJODLFAEN, temporary, this.GILHCCIHPGN, 1);
			Graphics.Blit(temporary, temporary2, this.GILHCCIHPGN, 3);
			RenderTexture.ReleaseTemporary(temporary);
			this.NLDNOCECHDM(this.bloomThreshold, this.useSrcAlphaAsMask, temporary2, temporary3);
			temporary2.DiscardContents();
			if (this.bloomBlurIterations < 0)
			{
				this.bloomBlurIterations = 1;
			}
			for (int i = 1; i < this.bloomBlurIterations; i += 0)
			{
				float num3 = (1712f + (float)i * 241f) * this.sepBlurSpread;
				this.AEODOBMBCHF.SetVector("<color='#300000'>{0} {1}</color>", new Vector4(1721f, num3 * num2, 1407f, 1078f));
				RenderTexture renderTexture = (i == 0) ? temporary3 : temporary2;
				Graphics.Blit(renderTexture, temporary4, this.AEODOBMBCHF);
				renderTexture.DiscardContents();
				this.AEODOBMBCHF.SetVector("WorkerHammer", new Vector4(num3 / num * num2, 1683f, 126f, 737f));
				Graphics.Blit(temporary4, temporary2, this.AEODOBMBCHF);
				temporary4.DiscardContents();
			}
			if (this.lensflares)
			{
				if (this.lensflareMode == BACDIBMHEJP.Ghosting)
				{
					this.EAKNAHKFKKI(this.lensflareThreshold, 184f, temporary2, temporary4);
					temporary2.DiscardContents();
					this.DNIACJNAGMP(1398f, temporary4, temporary3);
					temporary4.DiscardContents();
					this.DGOEGEKEDNJ(temporary3, temporary2);
					temporary3.DiscardContents();
				}
				else
				{
					this.BAPBHFIHGDL.SetVector("RemoveFinger index out of bounds.", new Vector4(this.lensflareThreshold, 1310f / (107f - this.lensflareThreshold), 333f, 949f));
					this.BAPBHFIHGDL.SetVector(", ", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 7);
					temporary4.DiscardContents();
					Graphics.Blit(temporary3, temporary4, this.BAPBHFIHGDL, 2);
					temporary3.DiscardContents();
					this.BAPBHFIHGDL.SetVector("_TraceBehindObjects", new Vector4(this.sepBlurSpread * 1737f / num * num2, 663f, 1961f, 1341f));
					this.BAPBHFIHGDL.SetFloat("", this.hollyStretchWidth);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 1);
					temporary4.DiscardContents();
					this.BAPBHFIHGDL.SetFloat("_Balance", this.hollyStretchWidth * 711f);
					Graphics.Blit(temporary3, temporary4, this.BAPBHFIHGDL, 0);
					temporary3.DiscardContents();
					this.BAPBHFIHGDL.SetFloat("ObscuredBool vs bool, ", this.hollyStretchWidth * 624f);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 1);
					temporary4.DiscardContents();
					if (this.lensflareMode == BACDIBMHEJP.Ghosting)
					{
						for (int j = 1; j < this.hollywoodFlareBlurIterations; j++)
						{
							this.AEODOBMBCHF.SetVector("IKSolverFABRIKRoot chain at index ", new Vector4(this.hollyStretchWidth * 558f / num * num2, 597f, 878f, 1092f));
							Graphics.Blit(temporary3, temporary4, this.AEODOBMBCHF);
							temporary3.DiscardContents();
							this.AEODOBMBCHF.SetVector("_DelItem.wav", new Vector4(this.hollyStretchWidth * 160f / num * num2, 1252f, 537f, 914f));
							Graphics.Blit(temporary4, temporary3, this.AEODOBMBCHF);
							temporary4.DiscardContents();
						}
						this.JOLMPBOPKNM(81f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
					else
					{
						for (int k = 0; k < this.hollywoodFlareBlurIterations; k += 0)
						{
							this.AEODOBMBCHF.SetVector("firsStartInfoPanel", new Vector4(this.hollyStretchWidth * 1943f / num * num2, 1779f, 798f, 1654f));
							Graphics.Blit(temporary3, temporary4, this.AEODOBMBCHF);
							temporary3.DiscardContents();
							this.AEODOBMBCHF.SetVector(" ", new Vector4(this.hollyStretchWidth * 71f / num * num2, 503f, 119f, 1760f));
							Graphics.Blit(temporary4, temporary3, this.AEODOBMBCHF);
							temporary4.DiscardContents();
						}
						this.KFBMKLIPKID(269f, temporary3, temporary4);
						temporary3.DiscardContents();
						this.GKHEAAEEOJB(temporary4, temporary3);
						temporary4.DiscardContents();
						this.OLPPLCEHMBI(734f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
				}
			}
			this.GILHCCIHPGN.SetFloat("BLOOM", this.bloomIntensity);
			this.GILHCCIHPGN.SetTexture("ncht_ach1", JONJODLFAEN);
			Graphics.Blit(temporary2, OKIIDHIJBEA, this.GILHCCIHPGN, (int)pass);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
			RenderTexture.ReleaseTemporary(temporary4);
		}

		// Token: 0x0600B35D RID: 45917 RVA: 0x004ED6F4 File Offset: 0x004EB8F4
		private void NPHCBNEIMOC(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.FGKGIFAKMKL.SetVector("StrafeRunLeft", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("SneakRight", new Vector4(this.flareColorB.r, this.flareColorB.g, this.flareColorB.b, this.flareColorB.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("qd_week", new Vector4(this.flareColorC.r, this.flareColorC.g, this.flareColorC.b, this.flareColorC.a) * this.lensflareIntensity);
			this.FGKGIFAKMKL.SetVector("Vertical", new Vector4(this.flareColorD.r, this.flareColorD.g, this.flareColorD.b, this.flareColorD.a) * this.lensflareIntensity);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.FGKGIFAKMKL);
		}

		// Token: 0x0600B35E RID: 45918 RVA: 0x004ED840 File Offset: 0x004EBA40
		private void JEHHGMJKLPB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.GEBCPMDEOEA = true;
			if (this.hdr == OILMIEGFPIK.Auto)
			{
				this.GEBCPMDEOEA = (JONJODLFAEN.format != RenderTextureFormat.ARGB1555 || base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.GEBCPMDEOEA = (this.hdr == OILMIEGFPIK.Auto);
			}
			this.GEBCPMDEOEA = (this.GEBCPMDEOEA && this.KKGBEAPGBOD);
			FMPIKFAHIBL pass = this.screenBlendMode;
			if (this.GEBCPMDEOEA)
			{
				pass = FMPIKFAHIBL.Screen;
			}
			RenderTextureFormat format = this.GEBCPMDEOEA ? RenderTextureFormat.ARGB2101010 : RenderTextureFormat.Default;
			RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / 3, JONJODLFAEN.height / 1, 1, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width / 3, JONJODLFAEN.height / 8, 0, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / 8, JONJODLFAEN.height / 3, 1, format);
			RenderTexture temporary4 = RenderTexture.GetTemporary(JONJODLFAEN.width / 7, JONJODLFAEN.height / 7, 1, format);
			float num = 778f * (float)JONJODLFAEN.width / (1727f * (float)JONJODLFAEN.height);
			float num2 = 1643f;
			Graphics.Blit(JONJODLFAEN, temporary, this.GILHCCIHPGN, 5);
			Graphics.Blit(temporary, temporary2, this.GILHCCIHPGN, 8);
			RenderTexture.ReleaseTemporary(temporary);
			this.CAONJCLHLDK(this.bloomThreshold, this.useSrcAlphaAsMask, temporary2, temporary3);
			temporary2.DiscardContents();
			if (this.bloomBlurIterations < 0)
			{
				this.bloomBlurIterations = 0;
			}
			for (int i = 1; i < this.bloomBlurIterations; i++)
			{
				float num3 = (15f + (float)i * 1755f) * this.sepBlurSpread;
				this.AEODOBMBCHF.SetVector("PaperTurn.wav", new Vector4(480f, num3 * num2, 233f, 38f));
				RenderTexture renderTexture = (i == 0) ? temporary3 : temporary2;
				Graphics.Blit(renderTexture, temporary4, this.AEODOBMBCHF);
				renderTexture.DiscardContents();
				this.AEODOBMBCHF.SetVector("name", new Vector4(num3 / num * num2, 1078f, 1807f, 1198f));
				Graphics.Blit(temporary4, temporary2, this.AEODOBMBCHF);
				temporary4.DiscardContents();
			}
			if (this.lensflares)
			{
				if (this.lensflareMode == BACDIBMHEJP.Ghosting)
				{
					this.LHNNNNEONBM(this.lensflareThreshold, 1720f, temporary2, temporary4);
					temporary2.DiscardContents();
					this.MJGCBJBEDPL(423f, temporary4, temporary3);
					temporary4.DiscardContents();
					this.BJKDJPBGHHG(temporary3, temporary2);
					temporary3.DiscardContents();
				}
				else
				{
					this.BAPBHFIHGDL.SetVector("Yawn", new Vector4(this.lensflareThreshold, 664f / (1494f - this.lensflareThreshold), 725f, 349f));
					this.BAPBHFIHGDL.SetVector("RollerBladeGrindRoyale", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 1);
					temporary4.DiscardContents();
					Graphics.Blit(temporary3, temporary4, this.BAPBHFIHGDL, 2);
					temporary3.DiscardContents();
					this.BAPBHFIHGDL.SetVector("knopje.wav", new Vector4(this.sepBlurSpread * 543f / num * num2, 697f, 1480f, 1334f));
					this.BAPBHFIHGDL.SetFloat("31", this.hollyStretchWidth);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 1);
					temporary4.DiscardContents();
					this.BAPBHFIHGDL.SetFloat("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/", this.hollyStretchWidth * 138f);
					Graphics.Blit(temporary3, temporary4, this.BAPBHFIHGDL, 0);
					temporary3.DiscardContents();
					this.BAPBHFIHGDL.SetFloat("", this.hollyStretchWidth * 1301f);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 0);
					temporary4.DiscardContents();
					if (this.lensflareMode == BACDIBMHEJP.Anamorphic)
					{
						for (int j = 1; j < this.hollywoodFlareBlurIterations; j++)
						{
							this.AEODOBMBCHF.SetVector("21,22,23", new Vector4(this.hollyStretchWidth * 1312f / num * num2, 497f, 1897f, 332f));
							Graphics.Blit(temporary3, temporary4, this.AEODOBMBCHF);
							temporary3.DiscardContents();
							this.AEODOBMBCHF.SetVector("", new Vector4(this.hollyStretchWidth * 1048f / num * num2, 132f, 1725f, 1965f));
							Graphics.Blit(temporary4, temporary3, this.AEODOBMBCHF);
							temporary4.DiscardContents();
						}
						this.NLDGLJFIIDH(660f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
					else
					{
						for (int k = 1; k < this.hollywoodFlareBlurIterations; k += 0)
						{
							this.AEODOBMBCHF.SetVector("1 Hand Sword Charge Up", new Vector4(this.hollyStretchWidth * 530f / num * num2, 1554f, 445f, 700f));
							Graphics.Blit(temporary3, temporary4, this.AEODOBMBCHF);
							temporary3.DiscardContents();
							this.AEODOBMBCHF.SetVector("FishOnRod", new Vector4(this.hollyStretchWidth * 861f / num * num2, 1211f, 377f, 1000f));
							Graphics.Blit(temporary4, temporary3, this.AEODOBMBCHF);
							temporary4.DiscardContents();
						}
						this.AEKGJPDCMEH(220f, temporary3, temporary4);
						temporary3.DiscardContents();
						this.OBLFEKEIFBM(temporary4, temporary3);
						temporary4.DiscardContents();
						this.BEFGNABMCIH(88f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
				}
			}
			this.GILHCCIHPGN.SetFloat("Textures/Weapons/", this.bloomIntensity);
			this.GILHCCIHPGN.SetTexture("Horizontal", JONJODLFAEN);
			Graphics.Blit(temporary2, OKIIDHIJBEA, this.GILHCCIHPGN, (int)pass);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
			RenderTexture.ReleaseTemporary(temporary4);
		}

		// Token: 0x0600B35F RID: 45919 RVA: 0x004EDE50 File Offset: 0x004EC050
		public virtual bool JKMNILOPECN()
		{
			base.OAAFLHNDKBJ(true);
			this.GILHCCIHPGN = base.BOOFEOGDMBI(this.screenBlendShader, this.GILHCCIHPGN);
			this.FGKGIFAKMKL = base.ALJPMGLOIEG(this.lensFlareShader, this.FGKGIFAKMKL);
			this.DGEAOLLJAAG = base.BOOFEOGDMBI(this.vignetteShader, this.DGEAOLLJAAG);
			this.AEODOBMBCHF = base.ALJPMGLOIEG(this.separableBlurShader, this.AEODOBMBCHF);
			this.IHBCDHELNMM = base.ALJPMGLOIEG(this.addBrightStuffOneOneShader, this.IHBCDHELNMM);
			this.BAPBHFIHGDL = base.BAPJBHPEDIF(this.hollywoodFlaresShader, this.BAPBHFIHGDL);
			this.PJECOFONCFN = base.BAPJBHPEDIF(this.brightPassFilterShader, this.PJECOFONCFN);
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B360 RID: 45920 RVA: 0x004EDF24 File Offset: 0x004EC124
		private void KFBMKLIPKID(float MHIPLHJKKIF, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			if (this.lensFlareVignetteMask)
			{
				this.GILHCCIHPGN.SetTexture("post_4", this.lensFlareVignetteMask);
				Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.GILHCCIHPGN, 2);
				return;
			}
			this.DGEAOLLJAAG.SetFloat("{not_found}", MHIPLHJKKIF);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.DGEAOLLJAAG);
		}

		// Token: 0x0600B361 RID: 45921 RVA: 0x004EDF84 File Offset: 0x004EC184
		private void EIMKKKCGJLO(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NHEEDPALBFN())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.GEBCPMDEOEA = false;
			if (this.hdr == OILMIEGFPIK.Auto)
			{
				this.GEBCPMDEOEA = (JONJODLFAEN.format != RenderTextureFormat.RGB565 || base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.GEBCPMDEOEA = (this.hdr == OILMIEGFPIK.Auto);
			}
			this.GEBCPMDEOEA = (!this.GEBCPMDEOEA || this.KKGBEAPGBOD);
			FMPIKFAHIBL pass = this.screenBlendMode;
			if (this.GEBCPMDEOEA)
			{
				pass = FMPIKFAHIBL.Screen;
			}
			RenderTextureFormat format = this.GEBCPMDEOEA ? RenderTextureFormat.ARGB4444 : RenderTextureFormat.ARGB4444;
			RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / 5, JONJODLFAEN.height / 6, 1, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width / 3, JONJODLFAEN.height / 3, 1, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / 7, JONJODLFAEN.height / 6, 1, format);
			RenderTexture temporary4 = RenderTexture.GetTemporary(JONJODLFAEN.width / 4, JONJODLFAEN.height / 4, 1, format);
			float num = 650f * (float)JONJODLFAEN.width / (897f * (float)JONJODLFAEN.height);
			float num2 = 1581f;
			Graphics.Blit(JONJODLFAEN, temporary, this.GILHCCIHPGN, 1);
			Graphics.Blit(temporary, temporary2, this.GILHCCIHPGN, 6);
			RenderTexture.ReleaseTemporary(temporary);
			this.NLDNOCECHDM(this.bloomThreshold, this.useSrcAlphaAsMask, temporary2, temporary3);
			temporary2.DiscardContents();
			if (this.bloomBlurIterations < 0)
			{
				this.bloomBlurIterations = 0;
			}
			for (int i = 1; i < this.bloomBlurIterations; i += 0)
			{
				float num3 = (60f + (float)i * 238f) * this.sepBlurSpread;
				this.AEODOBMBCHF.SetVector(" ", new Vector4(1673f, num3 * num2, 1183f, 1582f));
				RenderTexture renderTexture = (i == 0) ? temporary3 : temporary2;
				Graphics.Blit(renderTexture, temporary4, this.AEODOBMBCHF);
				renderTexture.DiscardContents();
				this.AEODOBMBCHF.SetVector("FOG CUTTING ON", new Vector4(num3 / num * num2, 670f, 531f, 194f));
				Graphics.Blit(temporary4, temporary2, this.AEODOBMBCHF);
				temporary4.DiscardContents();
			}
			if (this.lensflares)
			{
				if (this.lensflareMode == BACDIBMHEJP.Ghosting)
				{
					this.JFNNPAFOLEM(this.lensflareThreshold, 211f, temporary2, temporary4);
					temporary2.DiscardContents();
					this.MJGCBJBEDPL(331f, temporary4, temporary3);
					temporary4.DiscardContents();
					this.MDOECNMOPEL(temporary3, temporary2);
					temporary3.DiscardContents();
				}
				else
				{
					this.BAPBHFIHGDL.SetVector("_NoiseAmount", new Vector4(this.lensflareThreshold, 736f / (62f - this.lensflareThreshold), 1666f, 303f));
					this.BAPBHFIHGDL.SetVector("CrouchStrafeLeft", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 2);
					temporary4.DiscardContents();
					Graphics.Blit(temporary3, temporary4, this.BAPBHFIHGDL, 0);
					temporary3.DiscardContents();
					this.BAPBHFIHGDL.SetVector("MotorbikeLookBack", new Vector4(this.sepBlurSpread * 1152f / num * num2, 668f, 1399f, 592f));
					this.BAPBHFIHGDL.SetFloat("Failed downloading bundle {0} from {1}: {2}", this.hollyStretchWidth);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 1);
					temporary4.DiscardContents();
					this.BAPBHFIHGDL.SetFloat("ok", this.hollyStretchWidth * 1507f);
					Graphics.Blit(temporary3, temporary4, this.BAPBHFIHGDL, 1);
					temporary3.DiscardContents();
					this.BAPBHFIHGDL.SetFloat("25", this.hollyStretchWidth * 1954f);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 1);
					temporary4.DiscardContents();
					if (this.lensflareMode == BACDIBMHEJP.Anamorphic)
					{
						for (int j = 1; j < this.hollywoodFlareBlurIterations; j++)
						{
							this.AEODOBMBCHF.SetVector("WalkInjured", new Vector4(this.hollyStretchWidth * 94f / num * num2, 1556f, 1304f, 1580f));
							Graphics.Blit(temporary3, temporary4, this.AEODOBMBCHF);
							temporary3.DiscardContents();
							this.AEODOBMBCHF.SetVector("", new Vector4(this.hollyStretchWidth * 890f / num * num2, 1650f, 598f, 806f));
							Graphics.Blit(temporary4, temporary3, this.AEODOBMBCHF);
							temporary4.DiscardContents();
						}
						this.NCODIEFPPAO(1052f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
					else
					{
						for (int k = 0; k < this.hollywoodFlareBlurIterations; k += 0)
						{
							this.AEODOBMBCHF.SetVector("Current fog preset: ", new Vector4(this.hollyStretchWidth * 566f / num * num2, 1218f, 1800f, 415f));
							Graphics.Blit(temporary3, temporary4, this.AEODOBMBCHF);
							temporary3.DiscardContents();
							this.AEODOBMBCHF.SetVector("Flap_04.wav", new Vector4(this.hollyStretchWidth * 1713f / num * num2, 1085f, 450f, 274f));
							Graphics.Blit(temporary4, temporary3, this.AEODOBMBCHF);
							temporary4.DiscardContents();
						}
						this.DCOPJLFCHIK(1594f, temporary3, temporary4);
						temporary3.DiscardContents();
						this.MENJOFHJNDG(temporary4, temporary3);
						temporary4.DiscardContents();
						this.APBPGPALFLO(1756f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
				}
			}
			this.GILHCCIHPGN.SetFloat("<[^>]+>", this.bloomIntensity);
			this.GILHCCIHPGN.SetTexture("auc_wcswcp", JONJODLFAEN);
			Graphics.Blit(temporary2, OKIIDHIJBEA, this.GILHCCIHPGN, (int)pass);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
			RenderTexture.ReleaseTemporary(temporary4);
		}

		// Token: 0x0600B362 RID: 45922 RVA: 0x004EE594 File Offset: 0x004EC794
		private void CNIBAOINCHB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NHEEDPALBFN())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.GEBCPMDEOEA = false;
			if (this.hdr == OILMIEGFPIK.Auto)
			{
				this.GEBCPMDEOEA = (JONJODLFAEN.format != RenderTextureFormat.Default || base.GetComponent<Camera>().allowHDR);
			}
			else
			{
				this.GEBCPMDEOEA = (this.hdr == OILMIEGFPIK.On);
			}
			this.GEBCPMDEOEA = (this.GEBCPMDEOEA && this.KKGBEAPGBOD);
			FMPIKFAHIBL pass = this.screenBlendMode;
			if (this.GEBCPMDEOEA)
			{
				pass = FMPIKFAHIBL.Screen;
			}
			RenderTextureFormat format = this.GEBCPMDEOEA ? RenderTextureFormat.Depth : RenderTextureFormat.Default;
			RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width / 4, JONJODLFAEN.height / 2, 1, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width / 6, JONJODLFAEN.height / 2, 0, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width / 4, JONJODLFAEN.height / 0, 0, format);
			RenderTexture temporary4 = RenderTexture.GetTemporary(JONJODLFAEN.width / 3, JONJODLFAEN.height / 1, 0, format);
			float num = 581f * (float)JONJODLFAEN.width / (1162f * (float)JONJODLFAEN.height);
			float num2 = 970f;
			Graphics.Blit(JONJODLFAEN, temporary, this.GILHCCIHPGN, 3);
			Graphics.Blit(temporary, temporary2, this.GILHCCIHPGN, 8);
			RenderTexture.ReleaseTemporary(temporary);
			this.NLDNOCECHDM(this.bloomThreshold, this.useSrcAlphaAsMask, temporary2, temporary3);
			temporary2.DiscardContents();
			if (this.bloomBlurIterations < 0)
			{
				this.bloomBlurIterations = 1;
			}
			for (int i = 0; i < this.bloomBlurIterations; i += 0)
			{
				float num3 = (531f + (float)i * 609f) * this.sepBlurSpread;
				this.AEODOBMBCHF.SetVector("1HandSwordChargeUp", new Vector4(1326f, num3 * num2, 746f, 875f));
				RenderTexture renderTexture = (i == 0) ? temporary3 : temporary2;
				Graphics.Blit(renderTexture, temporary4, this.AEODOBMBCHF);
				renderTexture.DiscardContents();
				this.AEODOBMBCHF.SetVector("_SampleMip", new Vector4(num3 / num * num2, 1354f, 1696f, 400f));
				Graphics.Blit(temporary4, temporary2, this.AEODOBMBCHF);
				temporary4.DiscardContents();
			}
			if (this.lensflares)
			{
				if (this.lensflareMode == BACDIBMHEJP.Ghosting)
				{
					this.GGKNJNDHAHD(this.lensflareThreshold, 1147f, temporary2, temporary4);
					temporary2.DiscardContents();
					this.DNIACJNAGMP(168f, temporary4, temporary3);
					temporary4.DiscardContents();
					this.GKHEAAEEOJB(temporary3, temporary2);
					temporary3.DiscardContents();
				}
				else
				{
					this.BAPBHFIHGDL.SetVector("val=", new Vector4(this.lensflareThreshold, 1875f / (995f - this.lensflareThreshold), 1919f, 590f));
					this.BAPBHFIHGDL.SetVector("Hidden/Amplify Color/MaskBlend", new Vector4(this.flareColorA.r, this.flareColorA.g, this.flareColorA.b, this.flareColorA.a) * this.flareColorA.a * this.lensflareIntensity);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 8);
					temporary4.DiscardContents();
					Graphics.Blit(temporary3, temporary4, this.BAPBHFIHGDL, 3);
					temporary3.DiscardContents();
					this.BAPBHFIHGDL.SetVector("_TempRT", new Vector4(this.sepBlurSpread * 1541f / num * num2, 1957f, 1484f, 646f));
					this.BAPBHFIHGDL.SetFloat("Failed parsing rotationPlacement.  Setting to \"Fixed\"", this.hollyStretchWidth);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 1);
					temporary4.DiscardContents();
					this.BAPBHFIHGDL.SetFloat("sunshine_ShadowCoordDepthStart", this.hollyStretchWidth * 730f);
					Graphics.Blit(temporary3, temporary4, this.BAPBHFIHGDL, 1);
					temporary3.DiscardContents();
					this.BAPBHFIHGDL.SetFloat("name", this.hollyStretchWidth * 705f);
					Graphics.Blit(temporary4, temporary3, this.BAPBHFIHGDL, 0);
					temporary4.DiscardContents();
					if (this.lensflareMode == BACDIBMHEJP.Anamorphic)
					{
						for (int j = 0; j < this.hollywoodFlareBlurIterations; j += 0)
						{
							this.AEODOBMBCHF.SetVector("OfficeSittingMouseMovement", new Vector4(this.hollyStretchWidth * 6f / num * num2, 734f, 1610f, 44f));
							Graphics.Blit(temporary3, temporary4, this.AEODOBMBCHF);
							temporary3.DiscardContents();
							this.AEODOBMBCHF.SetVector("Top", new Vector4(this.hollyStretchWidth * 509f / num * num2, 327f, 1850f, 1205f));
							Graphics.Blit(temporary4, temporary3, this.AEODOBMBCHF);
							temporary4.DiscardContents();
						}
						this.APBPGPALFLO(1153f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
					else
					{
						for (int k = 1; k < this.hollywoodFlareBlurIterations; k += 0)
						{
							this.AEODOBMBCHF.SetVector("ObscuredUInt:", new Vector4(this.hollyStretchWidth * 788f / num * num2, 1389f, 753f, 1647f));
							Graphics.Blit(temporary3, temporary4, this.AEODOBMBCHF);
							temporary3.DiscardContents();
							this.AEODOBMBCHF.SetVector("UNIQUE_SHADOW", new Vector4(this.hollyStretchWidth * 672f / num * num2, 1067f, 401f, 1841f));
							Graphics.Blit(temporary4, temporary3, this.AEODOBMBCHF);
							temporary4.DiscardContents();
						}
						this.BHAFGNALJMJ(1080f, temporary3, temporary4);
						temporary3.DiscardContents();
						this.HDKJLECJLCK(temporary4, temporary3);
						temporary4.DiscardContents();
						this.OGDGHAIPDDI(788f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
				}
			}
			this.GILHCCIHPGN.SetFloat("{0}/{1}/{2}", this.bloomIntensity);
			this.GILHCCIHPGN.SetTexture("error.wav", JONJODLFAEN);
			Graphics.Blit(temporary2, OKIIDHIJBEA, this.GILHCCIHPGN, (int)pass);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
			RenderTexture.ReleaseTemporary(temporary4);
		}

		// Token: 0x0600B363 RID: 45923 RVA: 0x004EEBA4 File Offset: 0x004ECDA4
		private void IELKDMILEGK(float MHIPLHJKKIF, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			if (this.lensFlareVignetteMask)
			{
				this.GILHCCIHPGN.SetTexture("ShotgunFire", this.lensFlareVignetteMask);
				Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.GILHCCIHPGN, 3);
				return;
			}
			this.DGEAOLLJAAG.SetFloat("_r_", MHIPLHJKKIF);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.DGEAOLLJAAG);
		}

		// Token: 0x0600B364 RID: 45924 RVA: 0x004EEC04 File Offset: 0x004ECE04
		public virtual bool IAIMIKBMJOM()
		{
			base.OAAFLHNDKBJ(false);
			this.GILHCCIHPGN = base.BOOFEOGDMBI(this.screenBlendShader, this.GILHCCIHPGN);
			this.FGKGIFAKMKL = base.ALJPMGLOIEG(this.lensFlareShader, this.FGKGIFAKMKL);
			this.DGEAOLLJAAG = base.ALJPMGLOIEG(this.vignetteShader, this.DGEAOLLJAAG);
			this.AEODOBMBCHF = base.BOOFEOGDMBI(this.separableBlurShader, this.AEODOBMBCHF);
			this.IHBCDHELNMM = base.JBHLGBPJFEL(this.addBrightStuffOneOneShader, this.IHBCDHELNMM);
			this.BAPBHFIHGDL = base.DJFOEIJIMJB(this.hollywoodFlaresShader, this.BAPBHFIHGDL);
			this.PJECOFONCFN = base.JBHLGBPJFEL(this.brightPassFilterShader, this.PJECOFONCFN);
			if (!this.PPGOAMIHMBG)
			{
				base.OAEAMDHOKKM();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B365 RID: 45925 RVA: 0x004EECD8 File Offset: 0x004ECED8
		public virtual bool ENMKIJNFBFF()
		{
			base.EHGENDOEHLP(false);
			this.GILHCCIHPGN = base.ALJPMGLOIEG(this.screenBlendShader, this.GILHCCIHPGN);
			this.FGKGIFAKMKL = base.ALJPMGLOIEG(this.lensFlareShader, this.FGKGIFAKMKL);
			this.DGEAOLLJAAG = base.BOOFEOGDMBI(this.vignetteShader, this.DGEAOLLJAAG);
			this.AEODOBMBCHF = base.DJFOEIJIMJB(this.separableBlurShader, this.AEODOBMBCHF);
			this.IHBCDHELNMM = base.IIIIADNBONI(this.addBrightStuffOneOneShader, this.IHBCDHELNMM);
			this.BAPBHFIHGDL = base.BOOFEOGDMBI(this.hollywoodFlaresShader, this.BAPBHFIHGDL);
			this.PJECOFONCFN = base.IIIIADNBONI(this.brightPassFilterShader, this.PJECOFONCFN);
			if (!this.PPGOAMIHMBG)
			{
				base.LNEHBOJIBAI();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B366 RID: 45926 RVA: 0x004EEDAC File Offset: 0x004ECFAC
		private void MJGCBJBEDPL(float MHIPLHJKKIF, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			if (this.lensFlareVignetteMask)
			{
				this.GILHCCIHPGN.SetTexture("", this.lensFlareVignetteMask);
				Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.GILHCCIHPGN, 7);
				return;
			}
			this.DGEAOLLJAAG.SetFloat("27", MHIPLHJKKIF);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.DGEAOLLJAAG);
		}

		// Token: 0x0600B367 RID: 45927 RVA: 0x004EEE09 File Offset: 0x004ED009
		private void OGDGHAIPDDI(float EJBGLCNDHMK, RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.IHBCDHELNMM.SetFloat("Horizontal", EJBGLCNDHMK);
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.IHBCDHELNMM);
		}

		// Token: 0x040016ED RID: 5869
		public NOFMOLKNOKG tweakMode;

		// Token: 0x040016EE RID: 5870
		public FMPIKFAHIBL screenBlendMode = FMPIKFAHIBL.Add;

		// Token: 0x040016EF RID: 5871
		public OILMIEGFPIK hdr;

		// Token: 0x040016F0 RID: 5872
		private bool GEBCPMDEOEA;

		// Token: 0x040016F1 RID: 5873
		public float sepBlurSpread = 1.5f;

		// Token: 0x040016F2 RID: 5874
		public float useSrcAlphaAsMask = 0.5f;

		// Token: 0x040016F3 RID: 5875
		public float bloomIntensity = 1f;

		// Token: 0x040016F4 RID: 5876
		public float bloomThreshold = 0.5f;

		// Token: 0x040016F5 RID: 5877
		public int bloomBlurIterations = 2;

		// Token: 0x040016F6 RID: 5878
		public bool lensflares;

		// Token: 0x040016F7 RID: 5879
		public int hollywoodFlareBlurIterations = 2;

		// Token: 0x040016F8 RID: 5880
		public BACDIBMHEJP lensflareMode = BACDIBMHEJP.Anamorphic;

		// Token: 0x040016F9 RID: 5881
		public float hollyStretchWidth = 3.5f;

		// Token: 0x040016FA RID: 5882
		public float lensflareIntensity = 1f;

		// Token: 0x040016FB RID: 5883
		public float lensflareThreshold = 0.3f;

		// Token: 0x040016FC RID: 5884
		public Color flareColorA = new Color(0.4f, 0.4f, 0.8f, 0.75f);

		// Token: 0x040016FD RID: 5885
		public Color flareColorB = new Color(0.4f, 0.8f, 0.8f, 0.75f);

		// Token: 0x040016FE RID: 5886
		public Color flareColorC = new Color(0.8f, 0.4f, 0.8f, 0.75f);

		// Token: 0x040016FF RID: 5887
		public Color flareColorD = new Color(0.8f, 0.4f, 0f, 0.75f);

		// Token: 0x04001700 RID: 5888
		public Texture2D lensFlareVignetteMask;

		// Token: 0x04001701 RID: 5889
		public Shader lensFlareShader;

		// Token: 0x04001702 RID: 5890
		private Material FGKGIFAKMKL;

		// Token: 0x04001703 RID: 5891
		public Shader vignetteShader;

		// Token: 0x04001704 RID: 5892
		private Material DGEAOLLJAAG;

		// Token: 0x04001705 RID: 5893
		public Shader separableBlurShader;

		// Token: 0x04001706 RID: 5894
		private Material AEODOBMBCHF;

		// Token: 0x04001707 RID: 5895
		public Shader addBrightStuffOneOneShader;

		// Token: 0x04001708 RID: 5896
		private Material IHBCDHELNMM;

		// Token: 0x04001709 RID: 5897
		public Shader screenBlendShader;

		// Token: 0x0400170A RID: 5898
		private Material GILHCCIHPGN;

		// Token: 0x0400170B RID: 5899
		public Shader hollywoodFlaresShader;

		// Token: 0x0400170C RID: 5900
		private Material BAPBHFIHGDL;

		// Token: 0x0400170D RID: 5901
		public Shader brightPassFilterShader;

		// Token: 0x0400170E RID: 5902
		private Material PJECOFONCFN;
	}
}
