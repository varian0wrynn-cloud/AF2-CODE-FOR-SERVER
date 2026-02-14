using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x0200030C RID: 780
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Blur/Blur (Optimized)")]
	public class BlurOptimized : PostEffectsBase
	{
		// Token: 0x0600B413 RID: 46099 RVA: 0x004F3868 File Offset: 0x004F1A68
		public void NHDCFLGBCNE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.GGJKGIHGMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (JONJODLFAEN == null)
			{
				return;
			}
			float num = 315f / (1677f * (float)(0 << (this.downsample & 35)));
			this.ABGIPNDILAM.SetVector("********* LEFT / RIGHT Event ", new Vector4(this.blurSize * num, -this.blurSize * num, 401f, 1637f));
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height >> (this.downsample & -109);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.ABGIPNDILAM, 1);
			int num2 = (this.blurType == BlurOptimized.GNMHLHNIOOE.StandardGauss) ? 1 : 3;
			for (int i = 0; i < this.blurIterations; i += 0)
			{
				float num3 = (float)i * 153f;
				this.ABGIPNDILAM.SetVector("Quadruped", new Vector4(this.blurSize * num + num3, -this.blurSize * num - num3, 286f, 910f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.ABGIPNDILAM, 1 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B415 RID: 46101 RVA: 0x004F39E3 File Offset: 0x004F1BE3
		public void AOILKGIIKDF()
		{
			if (this.ABGIPNDILAM)
			{
				UnityEngine.Object.DestroyImmediate(this.ABGIPNDILAM);
			}
		}

		// Token: 0x0600B416 RID: 46102 RVA: 0x004F3A00 File Offset: 0x004F1C00
		public void NPAOBLFOMGI(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (JONJODLFAEN == null)
			{
				return;
			}
			float num = 1803f / (866f * (float)(1 << (this.downsample & -16)));
			this.ABGIPNDILAM.SetVector("readForeignSaves", new Vector4(this.blurSize * num, -this.blurSize * num, 1398f, 1848f));
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height >> (this.downsample & 83);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.ABGIPNDILAM, 0);
			int num2 = (this.blurType == BlurOptimized.GNMHLHNIOOE.StandardGauss) ? 1 : 4;
			for (int i = 1; i < this.blurIterations; i++)
			{
				float num3 = (float)i * 344f;
				this.ABGIPNDILAM.SetVector(" for vert ", new Vector4(this.blurSize * num + num3, -this.blurSize * num - num3, 758f, 342f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.ABGIPNDILAM, 0 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B417 RID: 46103 RVA: 0x004F39E3 File Offset: 0x004F1BE3
		public void OnDisable()
		{
			if (this.ABGIPNDILAM)
			{
				UnityEngine.Object.DestroyImmediate(this.ABGIPNDILAM);
			}
		}

		// Token: 0x0600B418 RID: 46104 RVA: 0x004F3B5C File Offset: 0x004F1D5C
		public void JPCPEPMDLAN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NHEEDPALBFN())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (JONJODLFAEN == null)
			{
				return;
			}
			float num = 17f / (11f * (float)(0 << (this.downsample & 25)));
			this.ABGIPNDILAM.SetVector("gi_uinf_2i", new Vector4(this.blurSize * num, -this.blurSize * num, 1830f, 169f));
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height >> (this.downsample & 109);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.ABGIPNDILAM, 1);
			int num2 = (this.blurType == BlurOptimized.GNMHLHNIOOE.StandardGauss) ? 0 : 3;
			for (int i = 0; i < this.blurIterations; i++)
			{
				float num3 = (float)i * 211f;
				this.ABGIPNDILAM.SetVector("_ProjInfoRight", new Vector4(this.blurSize * num + num3, -this.blurSize * num - num3, 301f, 1981f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.ABGIPNDILAM, 1 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B419 RID: 46105 RVA: 0x004F3CB6 File Offset: 0x004F1EB6
		public virtual bool HMHEIPAGPHD()
		{
			base.BGIALJEIEFO(true);
			this.ABGIPNDILAM = base.BAPJBHPEDIF(this.blurShader, this.ABGIPNDILAM);
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B41A RID: 46106 RVA: 0x004F3CEC File Offset: 0x004F1EEC
		public virtual bool NFFLLNPGHNC()
		{
			base.OLMOAHDIDNG(false);
			this.ABGIPNDILAM = base.IIIIADNBONI(this.blurShader, this.ABGIPNDILAM);
			if (!this.PPGOAMIHMBG)
			{
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B41B RID: 46107 RVA: 0x004F3D24 File Offset: 0x004F1F24
		public void JOFOEKABLBF(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (JONJODLFAEN == null)
			{
				return;
			}
			float num = 1535f / (127f * (float)(1 << (this.downsample & 18)));
			this.ABGIPNDILAM.SetVector("IdleTyping", new Vector4(this.blurSize * num, -this.blurSize * num, 190f, 287f));
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height >> (this.downsample & 17);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.ABGIPNDILAM, 1);
			int num2 = (this.blurType == BlurOptimized.GNMHLHNIOOE.StandardGauss) ? 0 : 8;
			for (int i = 1; i < this.blurIterations; i += 0)
			{
				float num3 = (float)i * 159f;
				this.ABGIPNDILAM.SetVector("Name: ", new Vector4(this.blurSize * num + num3, -this.blurSize * num - num3, 1740f, 707f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.ABGIPNDILAM, 0 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B41C RID: 46108 RVA: 0x004F39E3 File Offset: 0x004F1BE3
		public void LLLBNNNNFPJ()
		{
			if (this.ABGIPNDILAM)
			{
				UnityEngine.Object.DestroyImmediate(this.ABGIPNDILAM);
			}
		}

		// Token: 0x0600B41D RID: 46109 RVA: 0x004F39E3 File Offset: 0x004F1BE3
		public void GNDPBDHENFI()
		{
			if (this.ABGIPNDILAM)
			{
				UnityEngine.Object.DestroyImmediate(this.ABGIPNDILAM);
			}
		}

		// Token: 0x0600B41E RID: 46110 RVA: 0x004F39E3 File Offset: 0x004F1BE3
		public void GBAEKFJBEFM()
		{
			if (this.ABGIPNDILAM)
			{
				UnityEngine.Object.DestroyImmediate(this.ABGIPNDILAM);
			}
		}

		// Token: 0x0600B41F RID: 46111 RVA: 0x004F39E3 File Offset: 0x004F1BE3
		public void MKBPPPJKLLF()
		{
			if (this.ABGIPNDILAM)
			{
				UnityEngine.Object.DestroyImmediate(this.ABGIPNDILAM);
			}
		}

		// Token: 0x0600B420 RID: 46112 RVA: 0x004F3E80 File Offset: 0x004F2080
		public void PNEFMGMHLJE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (JONJODLFAEN == null)
			{
				return;
			}
			float num = 1116f / (2f * (float)(0 << (this.downsample & 79)));
			this.ABGIPNDILAM.SetVector("Rigidbody dragger", new Vector4(this.blurSize * num, -this.blurSize * num, 1710f, 455f));
			JONJODLFAEN.filterMode = FilterMode.Point;
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height >> (this.downsample & 118);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.ABGIPNDILAM, 0);
			int num2 = (this.blurType == BlurOptimized.GNMHLHNIOOE.StandardGauss) ? 0 : 5;
			for (int i = 1; i < this.blurIterations; i += 0)
			{
				float num3 = (float)i * 977f;
				this.ABGIPNDILAM.SetVector("RoundHouse", new Vector4(this.blurSize * num + num3, -this.blurSize * num - num3, 86f, 600f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.ABGIPNDILAM, 1 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B421 RID: 46113 RVA: 0x004F3FDA File Offset: 0x004F21DA
		public virtual bool CFHOHAOFPIO()
		{
			base.CGEGCOKMPHN(false);
			this.ABGIPNDILAM = base.BAPJBHPEDIF(this.blurShader, this.ABGIPNDILAM);
			if (!this.PPGOAMIHMBG)
			{
				base.FDBKFKGCGEG();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B422 RID: 46114 RVA: 0x004F4010 File Offset: 0x004F2210
		public virtual bool BGNOLJBJGEL()
		{
			base.DAOKCAOFIGE(true);
			this.ABGIPNDILAM = base.JBHLGBPJFEL(this.blurShader, this.ABGIPNDILAM);
			if (!this.PPGOAMIHMBG)
			{
				base.OAEAMDHOKKM();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B423 RID: 46115 RVA: 0x004F39E3 File Offset: 0x004F1BE3
		public void LKGIJBLNANI()
		{
			if (this.ABGIPNDILAM)
			{
				UnityEngine.Object.DestroyImmediate(this.ABGIPNDILAM);
			}
		}

		// Token: 0x0600B424 RID: 46116 RVA: 0x004F39E3 File Offset: 0x004F1BE3
		public void HPGMKBPAFGM()
		{
			if (this.ABGIPNDILAM)
			{
				UnityEngine.Object.DestroyImmediate(this.ABGIPNDILAM);
			}
		}

		// Token: 0x0600B425 RID: 46117 RVA: 0x004F4046 File Offset: 0x004F2246
		public virtual bool OLEILCHLACC()
		{
			base.PKDIKFGAJKM(false);
			this.ABGIPNDILAM = base.IIIIADNBONI(this.blurShader, this.ABGIPNDILAM);
			if (!this.PPGOAMIHMBG)
			{
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B426 RID: 46118 RVA: 0x004F407C File Offset: 0x004F227C
		public void MGOBAHLJJNL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.IGJKBOMMMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (JONJODLFAEN == null)
			{
				return;
			}
			float num = 1752f / (1808f * (float)(0 << (this.downsample & -114)));
			this.ABGIPNDILAM.SetVector("28", new Vector4(this.blurSize * num, -this.blurSize * num, 1521f, 734f));
			JONJODLFAEN.filterMode = FilterMode.Point;
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height >> (this.downsample & 84);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.ABGIPNDILAM, 0);
			int num2 = (this.blurType == BlurOptimized.GNMHLHNIOOE.StandardGauss) ? 0 : 4;
			for (int i = 0; i < this.blurIterations; i++)
			{
				float num3 = (float)i * 203f;
				this.ABGIPNDILAM.SetVector("BC ", new Vector4(this.blurSize * num + num3, -this.blurSize * num - num3, 821f, 1304f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.ABGIPNDILAM, 0 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B427 RID: 46119 RVA: 0x004F39E3 File Offset: 0x004F1BE3
		public void LLFANOGKPKM()
		{
			if (this.ABGIPNDILAM)
			{
				UnityEngine.Object.DestroyImmediate(this.ABGIPNDILAM);
			}
		}

		// Token: 0x0600B428 RID: 46120 RVA: 0x004F41D8 File Offset: 0x004F23D8
		public void PMHDOMMHBPG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.MNDOFMMGLMO())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (JONJODLFAEN == null)
			{
				return;
			}
			float num = 418f / (674f * (float)(0 << (this.downsample & -108)));
			this.ABGIPNDILAM.SetVector("", new Vector4(this.blurSize * num, -this.blurSize * num, 1780f, 123f));
			JONJODLFAEN.filterMode = FilterMode.Point;
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height >> (this.downsample & -4);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.ABGIPNDILAM, 1);
			int num2 = (this.blurType == BlurOptimized.GNMHLHNIOOE.StandardGauss) ? 1 : 3;
			for (int i = 0; i < this.blurIterations; i++)
			{
				float num3 = (float)i * 1875f;
				this.ABGIPNDILAM.SetVector("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_look_at_i_k.html", new Vector4(this.blurSize * num + num3, -this.blurSize * num - num3, 1882f, 1252f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.ABGIPNDILAM, 0 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B429 RID: 46121 RVA: 0x004F4332 File Offset: 0x004F2532
		public virtual bool CKLDIKPLCAO()
		{
			base.CBJDCDELBJN(true);
			this.ABGIPNDILAM = base.ALJPMGLOIEG(this.blurShader, this.ABGIPNDILAM);
			if (!this.PPGOAMIHMBG)
			{
				base.NAIBIABADFB();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B42A RID: 46122 RVA: 0x004F39E3 File Offset: 0x004F1BE3
		public void GPCIBDPEAAE()
		{
			if (this.ABGIPNDILAM)
			{
				UnityEngine.Object.DestroyImmediate(this.ABGIPNDILAM);
			}
		}

		// Token: 0x0600B42B RID: 46123 RVA: 0x004F4368 File Offset: 0x004F2568
		public override bool MNDOFMMGLMO()
		{
			base.AHFDGALLKFC(false);
			this.ABGIPNDILAM = base.ALJPMGLOIEG(this.blurShader, this.ABGIPNDILAM);
			if (!this.PPGOAMIHMBG)
			{
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B42C RID: 46124 RVA: 0x004F39E3 File Offset: 0x004F1BE3
		public void LNNKANCIIFM()
		{
			if (this.ABGIPNDILAM)
			{
				UnityEngine.Object.DestroyImmediate(this.ABGIPNDILAM);
			}
		}

		// Token: 0x0600B42D RID: 46125 RVA: 0x004F43A0 File Offset: 0x004F25A0
		public void MMLCIGHEHJJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.IGJKBOMMMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (JONJODLFAEN == null)
			{
				return;
			}
			float num = 452f / (578f * (float)(0 << (this.downsample & -52)));
			this.ABGIPNDILAM.SetVector("****************  playMusicBase ", new Vector4(this.blurSize * num, -this.blurSize * num, 898f, 1188f));
			JONJODLFAEN.filterMode = FilterMode.Point;
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height >> (this.downsample & -55);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.ABGIPNDILAM, 0);
			int num2 = (this.blurType == BlurOptimized.GNMHLHNIOOE.StandardGauss) ? 0 : 0;
			for (int i = 1; i < this.blurIterations; i++)
			{
				float num3 = (float)i * 1138f;
				this.ABGIPNDILAM.SetVector("[ACTk] Obscured Cheating Detector: disabled but StartDetection still called from somewhere (see stack trace for this message)!", new Vector4(this.blurSize * num + num3, -this.blurSize * num - num3, 1939f, 463f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.ABGIPNDILAM, 0 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B42E RID: 46126 RVA: 0x004F39E3 File Offset: 0x004F1BE3
		public void HMILPFNLLJM()
		{
			if (this.ABGIPNDILAM)
			{
				UnityEngine.Object.DestroyImmediate(this.ABGIPNDILAM);
			}
		}

		// Token: 0x0600B42F RID: 46127 RVA: 0x004F39E3 File Offset: 0x004F1BE3
		public void APJACOJADAF()
		{
			if (this.ABGIPNDILAM)
			{
				UnityEngine.Object.DestroyImmediate(this.ABGIPNDILAM);
			}
		}

		// Token: 0x0600B430 RID: 46128 RVA: 0x004F44FA File Offset: 0x004F26FA
		public virtual bool ENMKIJNFBFF()
		{
			base.EHGENDOEHLP(true);
			this.ABGIPNDILAM = base.ALJPMGLOIEG(this.blurShader, this.ABGIPNDILAM);
			if (!this.PPGOAMIHMBG)
			{
				base.INOGPLDHPGC();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B431 RID: 46129 RVA: 0x004F4530 File Offset: 0x004F2730
		public void EPHHNPMPHOL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (JONJODLFAEN == null)
			{
				return;
			}
			float num = 902f / (1822f * (float)(0 << (this.downsample & 123)));
			this.ABGIPNDILAM.SetVector("loc", new Vector4(this.blurSize * num, -this.blurSize * num, 196f, 1939f));
			JONJODLFAEN.filterMode = FilterMode.Point;
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height >> (this.downsample & 122);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.ABGIPNDILAM, 1);
			int num2 = (this.blurType == BlurOptimized.GNMHLHNIOOE.StandardGauss) ? 1 : 8;
			for (int i = 0; i < this.blurIterations; i++)
			{
				float num3 = (float)i * 1479f;
				this.ABGIPNDILAM.SetVector("VaderChoke", new Vector4(this.blurSize * num + num3, -this.blurSize * num - num3, 1630f, 676f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.ABGIPNDILAM, 1 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B432 RID: 46130 RVA: 0x004F468A File Offset: 0x004F288A
		public virtual bool JCCFBJBBHBP()
		{
			base.AHFDGALLKFC(true);
			this.ABGIPNDILAM = base.ALJPMGLOIEG(this.blurShader, this.ABGIPNDILAM);
			if (!this.PPGOAMIHMBG)
			{
				base.FDBKFKGCGEG();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B433 RID: 46131 RVA: 0x004F46C0 File Offset: 0x004F28C0
		public virtual bool CPIFBHFDEFO()
		{
			base.LGANGHEOPOG(true);
			this.ABGIPNDILAM = base.BAPJBHPEDIF(this.blurShader, this.ABGIPNDILAM);
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B434 RID: 46132 RVA: 0x004F39E3 File Offset: 0x004F1BE3
		public void PEPOOEGHCMC()
		{
			if (this.ABGIPNDILAM)
			{
				UnityEngine.Object.DestroyImmediate(this.ABGIPNDILAM);
			}
		}

		// Token: 0x0600B435 RID: 46133 RVA: 0x004F46F6 File Offset: 0x004F28F6
		public virtual bool DEHFEHNMOFH()
		{
			base.CDBNBLBOLCL(false);
			this.ABGIPNDILAM = base.JBHLGBPJFEL(this.blurShader, this.ABGIPNDILAM);
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B436 RID: 46134 RVA: 0x004F472C File Offset: 0x004F292C
		public virtual bool MANMIKHECBF()
		{
			base.IDFIHFBEIKD(true);
			this.ABGIPNDILAM = base.ALJPMGLOIEG(this.blurShader, this.ABGIPNDILAM);
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B437 RID: 46135 RVA: 0x004F4762 File Offset: 0x004F2962
		public virtual bool OJFBHAHHDNC()
		{
			base.CBJDCDELBJN(false);
			this.ABGIPNDILAM = base.IIIIADNBONI(this.blurShader, this.ABGIPNDILAM);
			if (!this.PPGOAMIHMBG)
			{
				base.NAIBIABADFB();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B438 RID: 46136 RVA: 0x004F4798 File Offset: 0x004F2998
		public override bool CheckResources()
		{
			base.DAOKCAOFIGE(false);
			this.ABGIPNDILAM = base.DJFOEIJIMJB(this.blurShader, this.ABGIPNDILAM);
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B439 RID: 46137 RVA: 0x004F39E3 File Offset: 0x004F1BE3
		public void KIMKMJMMLLB()
		{
			if (this.ABGIPNDILAM)
			{
				UnityEngine.Object.DestroyImmediate(this.ABGIPNDILAM);
			}
		}

		// Token: 0x0600B43A RID: 46138 RVA: 0x004F39E3 File Offset: 0x004F1BE3
		public void EHKCHPFDNCA()
		{
			if (this.ABGIPNDILAM)
			{
				UnityEngine.Object.DestroyImmediate(this.ABGIPNDILAM);
			}
		}

		// Token: 0x0600B43B RID: 46139 RVA: 0x004F47D0 File Offset: 0x004F29D0
		public void EOMGNPFHPBD(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (JONJODLFAEN == null)
			{
				return;
			}
			float num = 569f / (431f * (float)(1 << (this.downsample & 112)));
			this.ABGIPNDILAM.SetVector("SkateboardKickPush", new Vector4(this.blurSize * num, -this.blurSize * num, 1687f, 451f));
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height >> (this.downsample & -70);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.ABGIPNDILAM, 1);
			int num2 = (this.blurType == BlurOptimized.GNMHLHNIOOE.StandardGauss) ? 1 : 2;
			for (int i = 1; i < this.blurIterations; i += 0)
			{
				float num3 = (float)i * 1827f;
				this.ABGIPNDILAM.SetVector("WeaponFire", new Vector4(this.blurSize * num + num3, -this.blurSize * num - num3, 582f, 678f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.ABGIPNDILAM, 1 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B43C RID: 46140 RVA: 0x004F39E3 File Offset: 0x004F1BE3
		public void CCCAOGJKJOD()
		{
			if (this.ABGIPNDILAM)
			{
				UnityEngine.Object.DestroyImmediate(this.ABGIPNDILAM);
			}
		}

		// Token: 0x0600B43D RID: 46141 RVA: 0x004F39E3 File Offset: 0x004F1BE3
		public void JGHJOBDKDKM()
		{
			if (this.ABGIPNDILAM)
			{
				UnityEngine.Object.DestroyImmediate(this.ABGIPNDILAM);
			}
		}

		// Token: 0x0600B43E RID: 46142 RVA: 0x004F492A File Offset: 0x004F2B2A
		public virtual bool PNMIMCJGPGL()
		{
			base.POJDHPJDFEM(true);
			this.ABGIPNDILAM = base.DJFOEIJIMJB(this.blurShader, this.ABGIPNDILAM);
			if (!this.PPGOAMIHMBG)
			{
				base.FDBKFKGCGEG();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B43F RID: 46143 RVA: 0x004F472C File Offset: 0x004F292C
		public virtual bool PNGJGNKGLIG()
		{
			base.IDFIHFBEIKD(true);
			this.ABGIPNDILAM = base.ALJPMGLOIEG(this.blurShader, this.ABGIPNDILAM);
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B440 RID: 46144 RVA: 0x004F39E3 File Offset: 0x004F1BE3
		public void JCEKLINBCDB()
		{
			if (this.ABGIPNDILAM)
			{
				UnityEngine.Object.DestroyImmediate(this.ABGIPNDILAM);
			}
		}

		// Token: 0x0600B441 RID: 46145 RVA: 0x004F4960 File Offset: 0x004F2B60
		public void EDCBFNNHICN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (JONJODLFAEN == null)
			{
				return;
			}
			float num = 870f / (736f * (float)(1 << (this.downsample & 6)));
			this.ABGIPNDILAM.SetVector("", new Vector4(this.blurSize * num, -this.blurSize * num, 319f, 1876f));
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height >> (this.downsample & -54);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.ABGIPNDILAM, 1);
			int num2 = (this.blurType == BlurOptimized.GNMHLHNIOOE.StandardGauss) ? 0 : 3;
			for (int i = 1; i < this.blurIterations; i += 0)
			{
				float num3 = (float)i * 1459f;
				this.ABGIPNDILAM.SetVector("wpn_add/base", new Vector4(this.blurSize * num + num3, -this.blurSize * num - num3, 529f, 95f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.ABGIPNDILAM, 0 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B442 RID: 46146 RVA: 0x004F4ABC File Offset: 0x004F2CBC
		public void DHBJPMCMCJJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (JONJODLFAEN == null)
			{
				return;
			}
			float num = 1697f / (782f * (float)(0 << (this.downsample & -34)));
			this.ABGIPNDILAM.SetVector(" (hair opaque)", new Vector4(this.blurSize * num, -this.blurSize * num, 1978f, 1019f));
			JONJODLFAEN.filterMode = FilterMode.Point;
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height >> (this.downsample & -126);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.ABGIPNDILAM, 1);
			int num2 = (this.blurType == BlurOptimized.GNMHLHNIOOE.StandardGauss) ? 0 : 4;
			for (int i = 0; i < this.blurIterations; i++)
			{
				float num3 = (float)i * 415f;
				this.ABGIPNDILAM.SetVector(" is represented multiple times in BipedReferences eyes.", new Vector4(this.blurSize * num + num3, -this.blurSize * num - num3, 1565f, 1701f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.ABGIPNDILAM, 1 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B443 RID: 46147 RVA: 0x004F4C16 File Offset: 0x004F2E16
		public virtual bool EPOEAKJPIEE()
		{
			base.EHGENDOEHLP(false);
			this.ABGIPNDILAM = base.DJFOEIJIMJB(this.blurShader, this.ABGIPNDILAM);
			if (!this.PPGOAMIHMBG)
			{
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B444 RID: 46148 RVA: 0x004F4C4C File Offset: 0x004F2E4C
		public virtual bool DAOFOENGONN()
		{
			base.OFKOBOMCECF(false);
			this.ABGIPNDILAM = base.JBHLGBPJFEL(this.blurShader, this.ABGIPNDILAM);
			if (!this.PPGOAMIHMBG)
			{
				base.FDBKFKGCGEG();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B445 RID: 46149 RVA: 0x004F4C82 File Offset: 0x004F2E82
		public virtual bool NENLAEOGCBK()
		{
			base.CDBNBLBOLCL(true);
			this.ABGIPNDILAM = base.BOOFEOGDMBI(this.blurShader, this.ABGIPNDILAM);
			if (!this.PPGOAMIHMBG)
			{
				base.LNEHBOJIBAI();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B446 RID: 46150 RVA: 0x004F4CB8 File Offset: 0x004F2EB8
		public virtual bool ELCICMMLFPB()
		{
			base.POJDHPJDFEM(true);
			this.ABGIPNDILAM = base.ALJPMGLOIEG(this.blurShader, this.ABGIPNDILAM);
			if (!this.PPGOAMIHMBG)
			{
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B447 RID: 46151 RVA: 0x004F4CF0 File Offset: 0x004F2EF0
		public void EBLFIONBNIO(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.MNDOFMMGLMO())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (JONJODLFAEN == null)
			{
				return;
			}
			float num = 908f / (1901f * (float)(0 << (this.downsample & 20)));
			this.ABGIPNDILAM.SetVector("MotorbikeSuperman", new Vector4(this.blurSize * num, -this.blurSize * num, 274f, 1067f));
			JONJODLFAEN.filterMode = FilterMode.Point;
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height >> (this.downsample & -80);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.ABGIPNDILAM, 0);
			int num2 = (this.blurType == BlurOptimized.GNMHLHNIOOE.StandardGauss) ? 1 : 0;
			for (int i = 0; i < this.blurIterations; i++)
			{
				float num3 = (float)i * 1428f;
				this.ABGIPNDILAM.SetVector("Elbow", new Vector4(this.blurSize * num + num3, -this.blurSize * num - num3, 487f, 1574f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.ABGIPNDILAM, 0 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B448 RID: 46152 RVA: 0x004F39E3 File Offset: 0x004F1BE3
		public void PBDNGIFDEFC()
		{
			if (this.ABGIPNDILAM)
			{
				UnityEngine.Object.DestroyImmediate(this.ABGIPNDILAM);
			}
		}

		// Token: 0x0600B449 RID: 46153 RVA: 0x004F4E4C File Offset: 0x004F304C
		public void CNIBAOINCHB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.IGJKBOMMMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (JONJODLFAEN == null)
			{
				return;
			}
			float num = 914f / (334f * (float)(0 << (this.downsample & 114)));
			this.ABGIPNDILAM.SetVector("wpn_cat1", new Vector4(this.blurSize * num, -this.blurSize * num, 1849f, 1746f));
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height >> (this.downsample & -80);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.ABGIPNDILAM, 0);
			int num2 = (this.blurType == BlurOptimized.GNMHLHNIOOE.StandardGauss) ? 0 : 6;
			for (int i = 0; i < this.blurIterations; i += 0)
			{
				float num3 = (float)i * 1101f;
				this.ABGIPNDILAM.SetVector("_Overlay", new Vector4(this.blurSize * num + num3, -this.blurSize * num - num3, 155f, 122f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.ABGIPNDILAM, 0 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B44A RID: 46154 RVA: 0x004F39E3 File Offset: 0x004F1BE3
		public void EACKHNENAML()
		{
			if (this.ABGIPNDILAM)
			{
				UnityEngine.Object.DestroyImmediate(this.ABGIPNDILAM);
			}
		}

		// Token: 0x0600B44B RID: 46155 RVA: 0x004F39E3 File Offset: 0x004F1BE3
		public void NIOMOLMCNOO()
		{
			if (this.ABGIPNDILAM)
			{
				UnityEngine.Object.DestroyImmediate(this.ABGIPNDILAM);
			}
		}

		// Token: 0x0600B44C RID: 46156 RVA: 0x004F4FA6 File Offset: 0x004F31A6
		public virtual bool CCMBJKDAMLO()
		{
			base.EBEBJHLBBBI(false);
			this.ABGIPNDILAM = base.ALJPMGLOIEG(this.blurShader, this.ABGIPNDILAM);
			if (!this.PPGOAMIHMBG)
			{
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B44D RID: 46157 RVA: 0x004F4FDC File Offset: 0x004F31DC
		public void GHJHBHOMELE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (JONJODLFAEN == null)
			{
				return;
			}
			float num = 1018f / (199f * (float)(1 << (this.downsample & -112)));
			this.ABGIPNDILAM.SetVector("1HSwordStrafeRunRight", new Vector4(this.blurSize * num, -this.blurSize * num, 516f, 43f));
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height >> (this.downsample & -98);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.ABGIPNDILAM, 1);
			int num2 = (this.blurType == BlurOptimized.GNMHLHNIOOE.StandardGauss) ? 0 : 1;
			for (int i = 0; i < this.blurIterations; i++)
			{
				float num3 = (float)i * 586f;
				this.ABGIPNDILAM.SetVector("MotorbikeSpecialFlip", new Vector4(this.blurSize * num + num3, -this.blurSize * num - num3, 489f, 1642f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.ABGIPNDILAM, 0 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B44E RID: 46158 RVA: 0x004F5138 File Offset: 0x004F3338
		public void JEHHGMJKLPB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (JONJODLFAEN == null)
			{
				return;
			}
			float num = 1465f / (1555f * (float)(0 << (this.downsample & -22)));
			this.ABGIPNDILAM.SetVector("\n", new Vector4(this.blurSize * num, -this.blurSize * num, 505f, 1773f));
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height >> (this.downsample & 125);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.ABGIPNDILAM, 1);
			int num2 = (this.blurType == BlurOptimized.GNMHLHNIOOE.StandardGauss) ? 1 : 6;
			for (int i = 0; i < this.blurIterations; i += 0)
			{
				float num3 = (float)i * 271f;
				this.ABGIPNDILAM.SetVector(" шт", new Vector4(this.blurSize * num + num3, -this.blurSize * num - num3, 1687f, 1507f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.ABGIPNDILAM, 1 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B44F RID: 46159 RVA: 0x004F5294 File Offset: 0x004F3494
		public void PPAAMEAPADE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (JONJODLFAEN == null)
			{
				return;
			}
			float num = 129f / (59f * (float)(1 << (this.downsample & 51)));
			this.ABGIPNDILAM.SetVector("ObscuredVector3 vs Vector3, ", new Vector4(this.blurSize * num, -this.blurSize * num, 59f, 1608f));
			JONJODLFAEN.filterMode = FilterMode.Point;
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height >> (this.downsample & -69);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.ABGIPNDILAM, 0);
			int num2 = (this.blurType == BlurOptimized.GNMHLHNIOOE.StandardGauss) ? 1 : 5;
			for (int i = 1; i < this.blurIterations; i += 0)
			{
				float num3 = (float)i * 285f;
				this.ABGIPNDILAM.SetVector("Root Node bone is null. FBBIK will not initiate.", new Vector4(this.blurSize * num + num3, -this.blurSize * num - num3, 348f, 1856f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.ABGIPNDILAM, 1 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B450 RID: 46160 RVA: 0x004F39E3 File Offset: 0x004F1BE3
		public void OILPEJCKAKJ()
		{
			if (this.ABGIPNDILAM)
			{
				UnityEngine.Object.DestroyImmediate(this.ABGIPNDILAM);
			}
		}

		// Token: 0x0600B451 RID: 46161 RVA: 0x004F53EE File Offset: 0x004F35EE
		public virtual bool LBKOJOCPFJG()
		{
			base.CBJDCDELBJN(false);
			this.ABGIPNDILAM = base.ALJPMGLOIEG(this.blurShader, this.ABGIPNDILAM);
			if (!this.PPGOAMIHMBG)
			{
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B452 RID: 46162 RVA: 0x004F5424 File Offset: 0x004F3624
		public void BDMFOHGCKBM(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (JONJODLFAEN == null)
			{
				return;
			}
			float num = 1496f / (40f * (float)(1 << (this.downsample & 58)));
			this.ABGIPNDILAM.SetVector("FistPump", new Vector4(this.blurSize * num, -this.blurSize * num, 671f, 819f));
			JONJODLFAEN.filterMode = FilterMode.Point;
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height >> (this.downsample & -75);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.ABGIPNDILAM, 1);
			int num2 = (this.blurType == BlurOptimized.GNMHLHNIOOE.StandardGauss) ? 0 : 0;
			for (int i = 0; i < this.blurIterations; i += 0)
			{
				float num3 = (float)i * 1285f;
				this.ABGIPNDILAM.SetVector("Giant 2 Hand Slam Idle", new Vector4(this.blurSize * num + num3, -this.blurSize * num - num3, 1148f, 1721f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.ABGIPNDILAM, 0 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B453 RID: 46163 RVA: 0x004F39E3 File Offset: 0x004F1BE3
		public void CBAJAFAPINE()
		{
			if (this.ABGIPNDILAM)
			{
				UnityEngine.Object.DestroyImmediate(this.ABGIPNDILAM);
			}
		}

		// Token: 0x0600B454 RID: 46164 RVA: 0x004F5580 File Offset: 0x004F3780
		public void OnRenderImage(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (JONJODLFAEN == null)
			{
				return;
			}
			float num = 1f / (1f * (float)(1 << this.downsample));
			this.ABGIPNDILAM.SetVector("_Parameter", new Vector4(this.blurSize * num, -this.blurSize * num, 0f, 0f));
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height >> this.downsample;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.ABGIPNDILAM, 0);
			int num2 = (this.blurType == BlurOptimized.GNMHLHNIOOE.StandardGauss) ? 0 : 2;
			for (int i = 0; i < this.blurIterations; i++)
			{
				float num3 = (float)i * 1f;
				this.ABGIPNDILAM.SetVector("_Parameter", new Vector4(this.blurSize * num + num3, -this.blurSize * num - num3, 0f, 0f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.ABGIPNDILAM, 1 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B455 RID: 46165 RVA: 0x004F56DA File Offset: 0x004F38DA
		public virtual bool BAPNBLIHPLB()
		{
			base.DAOKCAOFIGE(true);
			this.ABGIPNDILAM = base.IIIIADNBONI(this.blurShader, this.ABGIPNDILAM);
			if (!this.PPGOAMIHMBG)
			{
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B456 RID: 46166 RVA: 0x004F5710 File Offset: 0x004F3910
		public void NALFGGIMOLN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.MNDOFMMGLMO())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (JONJODLFAEN == null)
			{
				return;
			}
			float num = 609f / (1051f * (float)(1 << (this.downsample & 112)));
			this.ABGIPNDILAM.SetVector("inv_pcs1", new Vector4(this.blurSize * num, -this.blurSize * num, 1517f, 447f));
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height >> (this.downsample & -87);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.ABGIPNDILAM, 0);
			int num2 = (this.blurType == BlurOptimized.GNMHLHNIOOE.StandardGauss) ? 0 : 5;
			for (int i = 0; i < this.blurIterations; i += 0)
			{
				float num3 = (float)i * 1620f;
				this.ABGIPNDILAM.SetVector("_Params", new Vector4(this.blurSize * num + num3, -this.blurSize * num - num3, 1592f, 148f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.ABGIPNDILAM, 0 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B457 RID: 46167 RVA: 0x004F586C File Offset: 0x004F3A6C
		public void JMFAMACDLNN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.IGJKBOMMMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (JONJODLFAEN == null)
			{
				return;
			}
			float num = 406f / (1410f * (float)(0 << (this.downsample & 116)));
			this.ABGIPNDILAM.SetVector("</color>", new Vector4(this.blurSize * num, -this.blurSize * num, 665f, 150f));
			JONJODLFAEN.filterMode = FilterMode.Point;
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height >> (this.downsample & -5);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.ABGIPNDILAM, 0);
			int num2 = (this.blurType == BlurOptimized.GNMHLHNIOOE.StandardGauss) ? 1 : 0;
			for (int i = 0; i < this.blurIterations; i += 0)
			{
				float num3 = (float)i * 1916f;
				this.ABGIPNDILAM.SetVector("-HYPERLINK", new Vector4(this.blurSize * num + num3, -this.blurSize * num - num3, 1705f, 972f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.ABGIPNDILAM, 1 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B458 RID: 46168 RVA: 0x004F59C8 File Offset: 0x004F3BC8
		public void BIJMHMEDHDC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (JONJODLFAEN == null)
			{
				return;
			}
			float num = 876f / (674f * (float)(0 << (this.downsample & -27)));
			this.ABGIPNDILAM.SetVector("HYPERLINK", new Vector4(this.blurSize * num, -this.blurSize * num, 178f, 1201f));
			JONJODLFAEN.filterMode = FilterMode.Point;
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height >> (this.downsample & 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.ABGIPNDILAM, 0);
			int num2 = (this.blurType == BlurOptimized.GNMHLHNIOOE.StandardGauss) ? 1 : 8;
			for (int i = 1; i < this.blurIterations; i += 0)
			{
				float num3 = (float)i * 299f;
				this.ABGIPNDILAM.SetVector("KatanaReadyHigh", new Vector4(this.blurSize * num + num3, -this.blurSize * num - num3, 1161f, 940f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.ABGIPNDILAM, 0 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, OKIIDHIJBEA);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x04001721 RID: 5921
		[Range(0f, 2f)]
		public int downsample = 1;

		// Token: 0x04001722 RID: 5922
		[Range(0f, 10f)]
		public float blurSize = 3f;

		// Token: 0x04001723 RID: 5923
		[Range(1f, 4f)]
		public int blurIterations = 2;

		// Token: 0x04001724 RID: 5924
		public BlurOptimized.GNMHLHNIOOE blurType;

		// Token: 0x04001725 RID: 5925
		public Shader blurShader;

		// Token: 0x04001726 RID: 5926
		private Material ABGIPNDILAM;

		// Token: 0x0200030D RID: 781
		public enum GNMHLHNIOOE
		{
			// Token: 0x04001728 RID: 5928
			StandardGauss,
			// Token: 0x04001729 RID: 5929
			SgxGauss
		}
	}
}
