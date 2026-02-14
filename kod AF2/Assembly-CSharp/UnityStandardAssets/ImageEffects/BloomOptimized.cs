using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000308 RID: 776
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Bloom and Glow/Bloom (Optimized)")]
	public class BloomOptimized : PostEffectsBase
	{
		// Token: 0x0600B368 RID: 45928 RVA: 0x004EEE29 File Offset: 0x004ED029
		public virtual bool EMMFLOCMHOM()
		{
			base.CDBNBLBOLCL(false);
			this.JFKENOANJNK = base.BAPJBHPEDIF(this.fastBloomShader, this.JFKENOANJNK);
			if (!this.PPGOAMIHMBG)
			{
				base.FDBKFKGCGEG();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B369 RID: 45929 RVA: 0x004EEE5F File Offset: 0x004ED05F
		private void LLFANOGKPKM()
		{
			if (this.JFKENOANJNK)
			{
				UnityEngine.Object.DestroyImmediate(this.JFKENOANJNK);
			}
		}

		// Token: 0x0600B36A RID: 45930 RVA: 0x004EEE7C File Offset: 0x004ED07C
		private void JKANPDKFMIF(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int num = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 5 : 8;
			float num2 = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 1260f : 81f;
			this.JFKENOANJNK.SetVector("Couldn't get avatar.", new Vector4(this.blurSize * num2, 319f, this.threshold, this.intensity));
			JONJODLFAEN.filterMode = FilterMode.Point;
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.JFKENOANJNK, 1);
			int num3 = (this.blurType == BloomOptimized.BEPEOJMJFAD.Standard) ? 1 : 7;
			for (int i = 1; i < this.blurIterations; i++)
			{
				this.JFKENOANJNK.SetVector("__c", new Vector4(this.blurSize * num2 + (float)i * 1849f, 364f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 8 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 6 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.JFKENOANJNK.SetTexture("System.Single", renderTexture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JFKENOANJNK, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B36B RID: 45931 RVA: 0x004EEE5F File Offset: 0x004ED05F
		private void DAIKHLLJCPL()
		{
			if (this.JFKENOANJNK)
			{
				UnityEngine.Object.DestroyImmediate(this.JFKENOANJNK);
			}
		}

		// Token: 0x0600B36C RID: 45932 RVA: 0x004EEE5F File Offset: 0x004ED05F
		private void ACJNCDAHJDE()
		{
			if (this.JFKENOANJNK)
			{
				UnityEngine.Object.DestroyImmediate(this.JFKENOANJNK);
			}
		}

		// Token: 0x0600B36D RID: 45933 RVA: 0x004EF01D File Offset: 0x004ED21D
		public virtual bool JNAKCOFNEMP()
		{
			base.AHFDGALLKFC(true);
			this.JFKENOANJNK = base.IIIIADNBONI(this.fastBloomShader, this.JFKENOANJNK);
			if (!this.PPGOAMIHMBG)
			{
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B36E RID: 45934 RVA: 0x004EF054 File Offset: 0x004ED254
		private void OOPLKCEGELE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int num = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 2 : 1;
			float num2 = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 1021f : 500f;
			this.JFKENOANJNK.SetVector("IdleMouthWipe", new Vector4(this.blurSize * num2, 788f, this.threshold, this.intensity));
			JONJODLFAEN.filterMode = FilterMode.Point;
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.JFKENOANJNK, 0);
			int num3 = (this.blurType == BloomOptimized.BEPEOJMJFAD.Standard) ? 1 : 7;
			for (int i = 0; i < this.blurIterations; i++)
			{
				this.JFKENOANJNK.SetVector("btn_cancel", new Vector4(this.blurSize * num2 + (float)i * 1018f, 867f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 7 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 0 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.JFKENOANJNK.SetTexture("sys", renderTexture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JFKENOANJNK, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B36F RID: 45935 RVA: 0x004EEE5F File Offset: 0x004ED05F
		private void CCCAOGJKJOD()
		{
			if (this.JFKENOANJNK)
			{
				UnityEngine.Object.DestroyImmediate(this.JFKENOANJNK);
			}
		}

		// Token: 0x0600B370 RID: 45936 RVA: 0x004EF1F8 File Offset: 0x004ED3F8
		private void MAIGIEENOEJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int num = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 1 : 7;
			float num2 = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 1005f : 1246f;
			this.JFKENOANJNK.SetVector("", new Vector4(this.blurSize * num2, 343f, this.threshold, this.intensity));
			JONJODLFAEN.filterMode = FilterMode.Point;
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.JFKENOANJNK, 0);
			int num3 = (this.blurType == BloomOptimized.BEPEOJMJFAD.Standard) ? 1 : 1;
			for (int i = 1; i < this.blurIterations; i += 0)
			{
				this.JFKENOANJNK.SetVector("prov_sob_", new Vector4(this.blurSize * num2 + (float)i * 1939f, 530f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 8 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 4 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.JFKENOANJNK.SetTexture("_EdgeSharpness", renderTexture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JFKENOANJNK, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B371 RID: 45937 RVA: 0x004EF399 File Offset: 0x004ED599
		public override bool PKHJBLJFIBF()
		{
			base.NHCAHIHJHMF(false);
			this.JFKENOANJNK = base.BOOFEOGDMBI(this.fastBloomShader, this.JFKENOANJNK);
			if (!this.PPGOAMIHMBG)
			{
				base.OAEAMDHOKKM();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B372 RID: 45938 RVA: 0x004EF3D0 File Offset: 0x004ED5D0
		private void IECKNMCHKCA(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.DLENDGGGMBJ())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int num = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 5 : 0;
			float num2 = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 163f : 784f;
			this.JFKENOANJNK.SetVector("http://j.mp/1FRAL5L", new Vector4(this.blurSize * num2, 1187f, this.threshold, this.intensity));
			JONJODLFAEN.filterMode = FilterMode.Point;
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.JFKENOANJNK, 1);
			int num3 = (this.blurType == BloomOptimized.BEPEOJMJFAD.Standard) ? 1 : 8;
			for (int i = 0; i < this.blurIterations; i += 0)
			{
				this.JFKENOANJNK.SetVector("RollerBladeFrontFlip", new Vector4(this.blurSize * num2 + (float)i * 1812f, 1771f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 3 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 2 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.JFKENOANJNK.SetTexture("error.wav", renderTexture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JFKENOANJNK, 0);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B373 RID: 45939 RVA: 0x004EEE5F File Offset: 0x004ED05F
		private void FFIBIADBGJB()
		{
			if (this.JFKENOANJNK)
			{
				UnityEngine.Object.DestroyImmediate(this.JFKENOANJNK);
			}
		}

		// Token: 0x0600B374 RID: 45940 RVA: 0x004EF574 File Offset: 0x004ED774
		private void BLKHLFAMJMJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int num = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 3 : 0;
			float num2 = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 462f : 957f;
			this.JFKENOANJNK.SetVector("_HitTime", new Vector4(this.blurSize * num2, 84f, this.threshold, this.intensity));
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.JFKENOANJNK, 0);
			int num3 = (this.blurType == BloomOptimized.BEPEOJMJFAD.Standard) ? 0 : 2;
			for (int i = 1; i < this.blurIterations; i += 0)
			{
				this.JFKENOANJNK.SetVector("_InverseProj", new Vector4(this.blurSize * num2 + (float)i * 1353f, 1680f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 1 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 6 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.JFKENOANJNK.SetTexture("/", renderTexture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JFKENOANJNK, 0);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B375 RID: 45941 RVA: 0x004EF718 File Offset: 0x004ED918
		private void PKNBABMJLPB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.DLENDGGGMBJ())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int num = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 4 : 5;
			float num2 = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 1958f : 720f;
			this.JFKENOANJNK.SetVector("Idle Mouth Wipe", new Vector4(this.blurSize * num2, 740f, this.threshold, this.intensity));
			JONJODLFAEN.filterMode = FilterMode.Point;
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.JFKENOANJNK, 0);
			int num3 = (this.blurType == BloomOptimized.BEPEOJMJFAD.Standard) ? 0 : 5;
			for (int i = 0; i < this.blurIterations; i += 0)
			{
				this.JFKENOANJNK.SetVector("FlyDown", new Vector4(this.blurSize * num2 + (float)i * 1819f, 1727f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 4 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 4 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.JFKENOANJNK.SetTexture("sadokfull2", renderTexture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JFKENOANJNK, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B376 RID: 45942 RVA: 0x004EF8BC File Offset: 0x004EDABC
		private void JEHHGMJKLPB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NHEEDPALBFN())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int num = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 2 : 4;
			float num2 = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 169f : 1425f;
			this.JFKENOANJNK.SetVector("Forefeet Root", new Vector4(this.blurSize * num2, 1441f, this.threshold, this.intensity));
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.JFKENOANJNK, 0);
			int num3 = (this.blurType == BloomOptimized.BEPEOJMJFAD.Standard) ? 1 : 8;
			for (int i = 1; i < this.blurIterations; i++)
			{
				this.JFKENOANJNK.SetVector("", new Vector4(this.blurSize * num2 + (float)i * 707f, 1076f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 3 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 4 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.JFKENOANJNK.SetTexture("{0:F2}, {1:F2}, {2:F2}", renderTexture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JFKENOANJNK, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B377 RID: 45943 RVA: 0x004EEE5F File Offset: 0x004ED05F
		private void LNNKANCIIFM()
		{
			if (this.JFKENOANJNK)
			{
				UnityEngine.Object.DestroyImmediate(this.JFKENOANJNK);
			}
		}

		// Token: 0x0600B378 RID: 45944 RVA: 0x004EFA5D File Offset: 0x004EDC5D
		public virtual bool NEOHPOGEHNF()
		{
			base.EHGENDOEHLP(false);
			this.JFKENOANJNK = base.ALJPMGLOIEG(this.fastBloomShader, this.JFKENOANJNK);
			if (!this.PPGOAMIHMBG)
			{
				base.INOGPLDHPGC();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B379 RID: 45945 RVA: 0x004EEE5F File Offset: 0x004ED05F
		private void DCPLDAKDDBG()
		{
			if (this.JFKENOANJNK)
			{
				UnityEngine.Object.DestroyImmediate(this.JFKENOANJNK);
			}
		}

		// Token: 0x0600B37A RID: 45946 RVA: 0x004EFA93 File Offset: 0x004EDC93
		public override bool MNDOFMMGLMO()
		{
			base.CDBNBLBOLCL(true);
			this.JFKENOANJNK = base.BOOFEOGDMBI(this.fastBloomShader, this.JFKENOANJNK);
			if (!this.PPGOAMIHMBG)
			{
				base.OAEAMDHOKKM();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B37B RID: 45947 RVA: 0x004EEE5F File Offset: 0x004ED05F
		private void PEPOOEGHCMC()
		{
			if (this.JFKENOANJNK)
			{
				UnityEngine.Object.DestroyImmediate(this.JFKENOANJNK);
			}
		}

		// Token: 0x0600B37C RID: 45948 RVA: 0x004EEE5F File Offset: 0x004ED05F
		private void FKPHBAOKEOF()
		{
			if (this.JFKENOANJNK)
			{
				UnityEngine.Object.DestroyImmediate(this.JFKENOANJNK);
			}
		}

		// Token: 0x0600B37D RID: 45949 RVA: 0x004EFAC9 File Offset: 0x004EDCC9
		public virtual bool HOADDNNBMMM()
		{
			base.CDBNBLBOLCL(true);
			this.JFKENOANJNK = base.OOAOHFFDMJP(this.fastBloomShader, this.JFKENOANJNK);
			if (!this.PPGOAMIHMBG)
			{
				base.INOGPLDHPGC();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B37E RID: 45950 RVA: 0x004EEE5F File Offset: 0x004ED05F
		private void PIPJPGGEFOL()
		{
			if (this.JFKENOANJNK)
			{
				UnityEngine.Object.DestroyImmediate(this.JFKENOANJNK);
			}
		}

		// Token: 0x0600B37F RID: 45951 RVA: 0x004EFAFF File Offset: 0x004EDCFF
		public virtual bool OJFBHAHHDNC()
		{
			base.MGHNCKDCFGL(false);
			this.JFKENOANJNK = base.ALJPMGLOIEG(this.fastBloomShader, this.JFKENOANJNK);
			if (!this.PPGOAMIHMBG)
			{
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B380 RID: 45952 RVA: 0x004EFB38 File Offset: 0x004EDD38
		private void BPCBJBDPKPK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int num = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 2 : 1;
			float num2 = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 533f : 971f;
			this.JFKENOANJNK.SetVector("_SampleMip", new Vector4(this.blurSize * num2, 963f, this.threshold, this.intensity));
			JONJODLFAEN.filterMode = FilterMode.Point;
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.JFKENOANJNK, 0);
			int num3 = (this.blurType == BloomOptimized.BEPEOJMJFAD.Standard) ? 0 : 6;
			for (int i = 1; i < this.blurIterations; i += 0)
			{
				this.JFKENOANJNK.SetVector("1HandSwordChargeHeavyBash", new Vector4(this.blurSize * num2 + (float)i * 567f, 1504f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 6 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 8 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.JFKENOANJNK.SetTexture("id", renderTexture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JFKENOANJNK, 0);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B381 RID: 45953 RVA: 0x004EFCD9 File Offset: 0x004EDED9
		public virtual bool HHCKHLDCKMF()
		{
			base.IDFIHFBEIKD(false);
			this.JFKENOANJNK = base.BAPJBHPEDIF(this.fastBloomShader, this.JFKENOANJNK);
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B382 RID: 45954 RVA: 0x004EEE5F File Offset: 0x004ED05F
		private void LKGIJBLNANI()
		{
			if (this.JFKENOANJNK)
			{
				UnityEngine.Object.DestroyImmediate(this.JFKENOANJNK);
			}
		}

		// Token: 0x0600B383 RID: 45955 RVA: 0x004EFD10 File Offset: 0x004EDF10
		private void MLOBCILJIEC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NHEEDPALBFN())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int num = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 6 : 5;
			float num2 = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 1667f : 1043f;
			this.JFKENOANJNK.SetVector("TAA History", new Vector4(this.blurSize * num2, 330f, this.threshold, this.intensity));
			JONJODLFAEN.filterMode = FilterMode.Point;
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.JFKENOANJNK, 0);
			int num3 = (this.blurType == BloomOptimized.BEPEOJMJFAD.Standard) ? 1 : 1;
			for (int i = 1; i < this.blurIterations; i += 0)
			{
				this.JFKENOANJNK.SetVector("MotorbikeHeadstand", new Vector4(this.blurSize * num2 + (float)i * 907f, 440f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 5 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 6 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.JFKENOANJNK.SetTexture("wpn_iwgt", renderTexture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JFKENOANJNK, 0);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B384 RID: 45956 RVA: 0x004EFEB4 File Offset: 0x004EE0B4
		private void MIJCMMIJPEE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int num = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 0 : 4;
			float num2 = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 1875f : 79f;
			this.JFKENOANJNK.SetVector("type_", new Vector4(this.blurSize * num2, 1190f, this.threshold, this.intensity));
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.JFKENOANJNK, 0);
			int num3 = (this.blurType == BloomOptimized.BEPEOJMJFAD.Standard) ? 1 : 8;
			for (int i = 0; i < this.blurIterations; i += 0)
			{
				this.JFKENOANJNK.SetVector("Loading ", new Vector4(this.blurSize * num2 + (float)i * 1137f, 1443f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 3 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 5 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.JFKENOANJNK.SetTexture("F key to change fog style, T to toggle fog on/off, C to toggle fog cutting", renderTexture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JFKENOANJNK, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B385 RID: 45957 RVA: 0x004EEE5F File Offset: 0x004ED05F
		private void HACJAOEBLFG()
		{
			if (this.JFKENOANJNK)
			{
				UnityEngine.Object.DestroyImmediate(this.JFKENOANJNK);
			}
		}

		// Token: 0x0600B386 RID: 45958 RVA: 0x004F0055 File Offset: 0x004EE255
		public virtual bool GCJBGCOJALG()
		{
			base.CDBNBLBOLCL(false);
			this.JFKENOANJNK = base.OOAOHFFDMJP(this.fastBloomShader, this.JFKENOANJNK);
			if (!this.PPGOAMIHMBG)
			{
				base.NAIBIABADFB();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B387 RID: 45959 RVA: 0x004EEE5F File Offset: 0x004ED05F
		private void CALFOKBIBIG()
		{
			if (this.JFKENOANJNK)
			{
				UnityEngine.Object.DestroyImmediate(this.JFKENOANJNK);
			}
		}

		// Token: 0x0600B388 RID: 45960 RVA: 0x004F008C File Offset: 0x004EE28C
		private void MCCMFFLILNN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int num = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 4 : 4;
			float num2 = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 126f : 791f;
			this.JFKENOANJNK.SetVector("wpn_rem4", new Vector4(this.blurSize * num2, 149f, this.threshold, this.intensity));
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.JFKENOANJNK, 1);
			int num3 = (this.blurType == BloomOptimized.BEPEOJMJFAD.Standard) ? 0 : 2;
			for (int i = 1; i < this.blurIterations; i++)
			{
				this.JFKENOANJNK.SetVector("FactoryTempTexture", new Vector4(this.blurSize * num2 + (float)i * 1255f, 1935f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 1 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 1 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.JFKENOANJNK.SetTexture("", renderTexture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JFKENOANJNK, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B389 RID: 45961 RVA: 0x004EEE5F File Offset: 0x004ED05F
		private void ONPDNGNNBIG()
		{
			if (this.JFKENOANJNK)
			{
				UnityEngine.Object.DestroyImmediate(this.JFKENOANJNK);
			}
		}

		// Token: 0x0600B38A RID: 45962 RVA: 0x004EEE5F File Offset: 0x004ED05F
		private void GJHFJOGOFEI()
		{
			if (this.JFKENOANJNK)
			{
				UnityEngine.Object.DestroyImmediate(this.JFKENOANJNK);
			}
		}

		// Token: 0x0600B38B RID: 45963 RVA: 0x004EEE5F File Offset: 0x004ED05F
		private void APJACOJADAF()
		{
			if (this.JFKENOANJNK)
			{
				UnityEngine.Object.DestroyImmediate(this.JFKENOANJNK);
			}
		}

		// Token: 0x0600B38C RID: 45964 RVA: 0x004EEE5F File Offset: 0x004ED05F
		private void NOLGMGLINIJ()
		{
			if (this.JFKENOANJNK)
			{
				UnityEngine.Object.DestroyImmediate(this.JFKENOANJNK);
			}
		}

		// Token: 0x0600B38D RID: 45965 RVA: 0x004F0230 File Offset: 0x004EE430
		private void MFEOIGILLPF(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int num = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 0 : 6;
			float num2 = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 1979f : 1386f;
			this.JFKENOANJNK.SetVector("noworkpoints", new Vector4(this.blurSize * num2, 921f, this.threshold, this.intensity));
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.JFKENOANJNK, 1);
			int num3 = (this.blurType == BloomOptimized.BEPEOJMJFAD.Standard) ? 0 : 0;
			for (int i = 1; i < this.blurIterations; i++)
			{
				this.JFKENOANJNK.SetVector("21,22,23", new Vector4(this.blurSize * num2 + (float)i * 583f, 747f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 6 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 4 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.JFKENOANJNK.SetTexture("minimalLevel", renderTexture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JFKENOANJNK, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B38E RID: 45966 RVA: 0x004F03D1 File Offset: 0x004EE5D1
		public virtual bool BGNOLJBJGEL()
		{
			base.DAOKCAOFIGE(true);
			this.JFKENOANJNK = base.JBHLGBPJFEL(this.fastBloomShader, this.JFKENOANJNK);
			if (!this.PPGOAMIHMBG)
			{
				base.FDBKFKGCGEG();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B38F RID: 45967 RVA: 0x004EEE5F File Offset: 0x004ED05F
		private void BAAAOKJHGAO()
		{
			if (this.JFKENOANJNK)
			{
				UnityEngine.Object.DestroyImmediate(this.JFKENOANJNK);
			}
		}

		// Token: 0x0600B390 RID: 45968 RVA: 0x004EEE5F File Offset: 0x004ED05F
		private void IICFAPMJLCN()
		{
			if (this.JFKENOANJNK)
			{
				UnityEngine.Object.DestroyImmediate(this.JFKENOANJNK);
			}
		}

		// Token: 0x0600B391 RID: 45969 RVA: 0x004F0408 File Offset: 0x004EE608
		private void EIBBJMGHBLC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.DLENDGGGMBJ())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int num = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 5 : 2;
			float num2 = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 1899f : 1189f;
			this.JFKENOANJNK.SetVector("_Overlay", new Vector4(this.blurSize * num2, 805f, this.threshold, this.intensity));
			JONJODLFAEN.filterMode = FilterMode.Point;
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.JFKENOANJNK, 0);
			int num3 = (this.blurType == BloomOptimized.BEPEOJMJFAD.Standard) ? 1 : 5;
			for (int i = 1; i < this.blurIterations; i++)
			{
				this.JFKENOANJNK.SetVector("_NoiseTex", new Vector4(this.blurSize * num2 + (float)i * 1057f, 43f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 0 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 7 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.JFKENOANJNK.SetTexture("_ChromaticAberration_Spectrum", renderTexture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JFKENOANJNK, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B392 RID: 45970 RVA: 0x004F05AC File Offset: 0x004EE7AC
		private void LLIDCMOMECE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.GGJKGIHGMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int num = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 2 : 7;
			float num2 = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 1777f : 1808f;
			this.JFKENOANJNK.SetVector("Unable to create Lightmap", new Vector4(this.blurSize * num2, 265f, this.threshold, this.intensity));
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.JFKENOANJNK, 0);
			int num3 = (this.blurType == BloomOptimized.BEPEOJMJFAD.Standard) ? 1 : 4;
			for (int i = 0; i < this.blurIterations; i++)
			{
				this.JFKENOANJNK.SetVector("OneHandSwordBlock", new Vector4(this.blurSize * num2 + (float)i * 308f, 888f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 8 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 3 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.JFKENOANJNK.SetTexture("System.Boolean", renderTexture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JFKENOANJNK, 0);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B393 RID: 45971 RVA: 0x004EEE5F File Offset: 0x004ED05F
		private void OnDisable()
		{
			if (this.JFKENOANJNK)
			{
				UnityEngine.Object.DestroyImmediate(this.JFKENOANJNK);
			}
		}

		// Token: 0x0600B394 RID: 45972 RVA: 0x004F074D File Offset: 0x004EE94D
		public virtual bool ENMKIJNFBFF()
		{
			base.NHCAHIHJHMF(true);
			this.JFKENOANJNK = base.BAPJBHPEDIF(this.fastBloomShader, this.JFKENOANJNK);
			if (!this.PPGOAMIHMBG)
			{
				base.OAEAMDHOKKM();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B395 RID: 45973 RVA: 0x004F0783 File Offset: 0x004EE983
		public virtual bool ANEEEKFNKGI()
		{
			base.CGEGCOKMPHN(false);
			this.JFKENOANJNK = base.BAPJBHPEDIF(this.fastBloomShader, this.JFKENOANJNK);
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B396 RID: 45974 RVA: 0x004EEE5F File Offset: 0x004ED05F
		private void BMLMKAGHDDE()
		{
			if (this.JFKENOANJNK)
			{
				UnityEngine.Object.DestroyImmediate(this.JFKENOANJNK);
			}
		}

		// Token: 0x0600B397 RID: 45975 RVA: 0x004EEE5F File Offset: 0x004ED05F
		private void FLFFEJFEPHF()
		{
			if (this.JFKENOANJNK)
			{
				UnityEngine.Object.DestroyImmediate(this.JFKENOANJNK);
			}
		}

		// Token: 0x0600B398 RID: 45976 RVA: 0x004F07BC File Offset: 0x004EE9BC
		private void NDLHGBEKICF(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NHEEDPALBFN())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int num = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 3 : 8;
			float num2 = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 107f : 442f;
			this.JFKENOANJNK.SetVector("Ankle", new Vector4(this.blurSize * num2, 194f, this.threshold, this.intensity));
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.JFKENOANJNK, 0);
			int num3 = (this.blurType == BloomOptimized.BEPEOJMJFAD.Standard) ? 0 : 4;
			for (int i = 0; i < this.blurIterations; i++)
			{
				this.JFKENOANJNK.SetVector("big_count", new Vector4(this.blurSize * num2 + (float)i * 699f, 1286f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 6 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 5 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.JFKENOANJNK.SetTexture("Noise & Grain effect failing as noise texture is not assigned. please assign.", renderTexture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JFKENOANJNK, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B399 RID: 45977 RVA: 0x004F0960 File Offset: 0x004EEB60
		private void BIJMHMEDHDC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int num = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 5 : 2;
			float num2 = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 1433f : 632f;
			this.JFKENOANJNK.SetVector("get 1401 cmd", new Vector4(this.blurSize * num2, 161f, this.threshold, this.intensity));
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.JFKENOANJNK, 0);
			int num3 = (this.blurType == BloomOptimized.BEPEOJMJFAD.Standard) ? 0 : 4;
			for (int i = 0; i < this.blurIterations; i += 0)
			{
				this.JFKENOANJNK.SetVector("OnRodChangeClck 5", new Vector4(this.blurSize * num2 + (float)i * 29f, 572f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 1 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 3 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.JFKENOANJNK.SetTexture("fwgt_trof_w", renderTexture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JFKENOANJNK, 0);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B39A RID: 45978 RVA: 0x004EEE5F File Offset: 0x004ED05F
		private void HGHMNMOCPJC()
		{
			if (this.JFKENOANJNK)
			{
				UnityEngine.Object.DestroyImmediate(this.JFKENOANJNK);
			}
		}

		// Token: 0x0600B39B RID: 45979 RVA: 0x004F0B04 File Offset: 0x004EED04
		private void OnRenderImage(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int num = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 4 : 2;
			float num2 = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 0.5f : 1f;
			this.JFKENOANJNK.SetVector("_Parameter", new Vector4(this.blurSize * num2, 0f, this.threshold, this.intensity));
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.JFKENOANJNK, 1);
			int num3 = (this.blurType == BloomOptimized.BEPEOJMJFAD.Standard) ? 0 : 2;
			for (int i = 0; i < this.blurIterations; i++)
			{
				this.JFKENOANJNK.SetVector("_Parameter", new Vector4(this.blurSize * num2 + (float)i * 1f, 0f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 2 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 3 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.JFKENOANJNK.SetTexture("_Bloom", renderTexture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JFKENOANJNK, 0);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B39C RID: 45980 RVA: 0x004F0CA5 File Offset: 0x004EEEA5
		public virtual bool CPIFBHFDEFO()
		{
			base.NHCAHIHJHMF(false);
			this.JFKENOANJNK = base.JBHLGBPJFEL(this.fastBloomShader, this.JFKENOANJNK);
			if (!this.PPGOAMIHMBG)
			{
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B39D RID: 45981 RVA: 0x004F0CDB File Offset: 0x004EEEDB
		public virtual bool CFHOHAOFPIO()
		{
			base.NHCAHIHJHMF(false);
			this.JFKENOANJNK = base.ALJPMGLOIEG(this.fastBloomShader, this.JFKENOANJNK);
			if (!this.PPGOAMIHMBG)
			{
				base.OAEAMDHOKKM();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B39E RID: 45982 RVA: 0x004F0D14 File Offset: 0x004EEF14
		private void AAOCJNKMKML(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.IGJKBOMMMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int num = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 8 : 3;
			float num2 = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 451f : 1458f;
			this.JFKENOANJNK.SetVector("Failed to load AssetBundle ", new Vector4(this.blurSize * num2, 945f, this.threshold, this.intensity));
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.JFKENOANJNK, 0);
			int num3 = (this.blurType == BloomOptimized.BEPEOJMJFAD.Standard) ? 0 : 8;
			for (int i = 1; i < this.blurIterations; i += 0)
			{
				this.JFKENOANJNK.SetVector("Add random value", new Vector4(this.blurSize * num2 + (float)i * 1358f, 1726f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 6 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 4 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.JFKENOANJNK.SetTexture("", renderTexture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JFKENOANJNK, 0);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B39F RID: 45983 RVA: 0x004EEE5F File Offset: 0x004ED05F
		private void FGHHAIDJNMM()
		{
			if (this.JFKENOANJNK)
			{
				UnityEngine.Object.DestroyImmediate(this.JFKENOANJNK);
			}
		}

		// Token: 0x0600B3A0 RID: 45984 RVA: 0x004F0EB5 File Offset: 0x004EF0B5
		public virtual bool DCEJLCLOCJC()
		{
			base.MGHNCKDCFGL(false);
			this.JFKENOANJNK = base.ALJPMGLOIEG(this.fastBloomShader, this.JFKENOANJNK);
			if (!this.PPGOAMIHMBG)
			{
				base.INOGPLDHPGC();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B3A1 RID: 45985 RVA: 0x004F0EEC File Offset: 0x004EF0EC
		private void CCIHPHKDIJL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NHEEDPALBFN())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int num = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 7 : 3;
			float num2 = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 1899f : 1961f;
			this.JFKENOANJNK.SetVector("_SampleCount", new Vector4(this.blurSize * num2, 437f, this.threshold, this.intensity));
			JONJODLFAEN.filterMode = FilterMode.Point;
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.JFKENOANJNK, 1);
			int num3 = (this.blurType == BloomOptimized.BEPEOJMJFAD.Standard) ? 0 : 6;
			for (int i = 0; i < this.blurIterations; i++)
			{
				this.JFKENOANJNK.SetVector("_ExposureAdjustment", new Vector4(this.blurSize * num2 + (float)i * 1587f, 634f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 6 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 4 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.JFKENOANJNK.SetTexture(": ", renderTexture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JFKENOANJNK, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B3A2 RID: 45986 RVA: 0x004F108D File Offset: 0x004EF28D
		public virtual bool MKPJEDFPGHB()
		{
			base.IDFIHFBEIKD(false);
			this.JFKENOANJNK = base.OOAOHFFDMJP(this.fastBloomShader, this.JFKENOANJNK);
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B3A4 RID: 45988 RVA: 0x004F10F4 File Offset: 0x004EF2F4
		private void PLOEFNMCMEF(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int num = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 7 : 5;
			float num2 = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 297f : 1188f;
			this.JFKENOANJNK.SetVector("TextureLoaderCoroutine", new Vector4(this.blurSize * num2, 1691f, this.threshold, this.intensity));
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.JFKENOANJNK, 0);
			int num3 = (this.blurType == BloomOptimized.BEPEOJMJFAD.Standard) ? 0 : 3;
			for (int i = 1; i < this.blurIterations; i++)
			{
				this.JFKENOANJNK.SetVector("Mouse X", new Vector4(this.blurSize * num2 + (float)i * 1002f, 614f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 8 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 5 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.JFKENOANJNK.SetTexture("Flares", renderTexture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JFKENOANJNK, 0);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B3A5 RID: 45989 RVA: 0x004F1298 File Offset: 0x004EF498
		private void LENELHOAKID(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.DLENDGGGMBJ())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int num = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 0 : 5;
			float num2 = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 573f : 1451f;
			this.JFKENOANJNK.SetVector("https://www.youtube.com/watch?v=r5jiZnsDH3M", new Vector4(this.blurSize * num2, 946f, this.threshold, this.intensity));
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.JFKENOANJNK, 1);
			int num3 = (this.blurType == BloomOptimized.BEPEOJMJFAD.Standard) ? 1 : 1;
			for (int i = 0; i < this.blurIterations; i += 0)
			{
				this.JFKENOANJNK.SetVector("1/", new Vector4(this.blurSize * num2 + (float)i * 678f, 1870f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 6 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 0 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.JFKENOANJNK.SetTexture("Vertical", renderTexture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JFKENOANJNK, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B3A6 RID: 45990 RVA: 0x004F1439 File Offset: 0x004EF639
		public virtual bool FCIOAHEKFIG()
		{
			base.POJDHPJDFEM(true);
			this.JFKENOANJNK = base.DJFOEIJIMJB(this.fastBloomShader, this.JFKENOANJNK);
			if (!this.PPGOAMIHMBG)
			{
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B3A7 RID: 45991 RVA: 0x004F146F File Offset: 0x004EF66F
		public virtual bool GHHPENCNBFP()
		{
			base.CGEGCOKMPHN(false);
			this.JFKENOANJNK = base.ALJPMGLOIEG(this.fastBloomShader, this.JFKENOANJNK);
			if (!this.PPGOAMIHMBG)
			{
				base.INOGPLDHPGC();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B3A8 RID: 45992 RVA: 0x004F14A8 File Offset: 0x004EF6A8
		private void DLOGCPJNGLM(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int num = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 6 : 5;
			float num2 = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 1489f : 1851f;
			this.JFKENOANJNK.SetVector("UNITY DEBUG", new Vector4(this.blurSize * num2, 278f, this.threshold, this.intensity));
			JONJODLFAEN.filterMode = FilterMode.Point;
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.JFKENOANJNK, 1);
			int num3 = (this.blurType == BloomOptimized.BEPEOJMJFAD.Standard) ? 1 : 7;
			for (int i = 0; i < this.blurIterations; i++)
			{
				this.JFKENOANJNK.SetVector("_MainTex", new Vector4(this.blurSize * num2 + (float)i * 1803f, 844f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 1 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 4 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.JFKENOANJNK.SetTexture("Отпущена рыба", renderTexture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JFKENOANJNK, 0);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B3A9 RID: 45993 RVA: 0x004F1649 File Offset: 0x004EF849
		public virtual bool CFODPFPIHIF()
		{
			base.OAAFLHNDKBJ(false);
			this.JFKENOANJNK = base.JBHLGBPJFEL(this.fastBloomShader, this.JFKENOANJNK);
			if (!this.PPGOAMIHMBG)
			{
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B3AA RID: 45994 RVA: 0x004EEE5F File Offset: 0x004ED05F
		private void BABMAHFKPMO()
		{
			if (this.JFKENOANJNK)
			{
				UnityEngine.Object.DestroyImmediate(this.JFKENOANJNK);
			}
		}

		// Token: 0x0600B3AB RID: 45995 RVA: 0x004F167F File Offset: 0x004EF87F
		public virtual bool PMIIFKOHBGD()
		{
			base.PKDIKFGAJKM(false);
			this.JFKENOANJNK = base.JBHLGBPJFEL(this.fastBloomShader, this.JFKENOANJNK);
			if (!this.PPGOAMIHMBG)
			{
				base.LNEHBOJIBAI();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B3AC RID: 45996 RVA: 0x004F16B5 File Offset: 0x004EF8B5
		public virtual bool DKMLGBCDFLG()
		{
			base.LGANGHEOPOG(true);
			this.JFKENOANJNK = base.DJFOEIJIMJB(this.fastBloomShader, this.JFKENOANJNK);
			if (!this.PPGOAMIHMBG)
			{
				base.INOGPLDHPGC();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B3AD RID: 45997 RVA: 0x004F16EC File Offset: 0x004EF8EC
		private void HHLIKPOMGPF(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.DLENDGGGMBJ())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int num = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 2 : 4;
			float num2 = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 1190f : 104f;
			this.JFKENOANJNK.SetVector("FistPump", new Vector4(this.blurSize * num2, 1625f, this.threshold, this.intensity));
			JONJODLFAEN.filterMode = FilterMode.Point;
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.JFKENOANJNK, 1);
			int num3 = (this.blurType == BloomOptimized.BEPEOJMJFAD.Standard) ? 1 : 0;
			for (int i = 0; i < this.blurIterations; i += 0)
			{
				this.JFKENOANJNK.SetVector("<.*?>", new Vector4(this.blurSize * num2 + (float)i * 124f, 1950f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 3 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 6 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.JFKENOANJNK.SetTexture("error.wav", renderTexture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JFKENOANJNK, 0);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B3AE RID: 45998 RVA: 0x004F188D File Offset: 0x004EFA8D
		public virtual bool MKPFGONOOBM()
		{
			base.CBJDCDELBJN(true);
			this.JFKENOANJNK = base.JBHLGBPJFEL(this.fastBloomShader, this.JFKENOANJNK);
			if (!this.PPGOAMIHMBG)
			{
				base.FDBKFKGCGEG();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B3AF RID: 45999 RVA: 0x004EEE5F File Offset: 0x004ED05F
		private void AHDAOLPGGMC()
		{
			if (this.JFKENOANJNK)
			{
				UnityEngine.Object.DestroyImmediate(this.JFKENOANJNK);
			}
		}

		// Token: 0x0600B3B0 RID: 46000 RVA: 0x004F18C3 File Offset: 0x004EFAC3
		public virtual bool JKMNILOPECN()
		{
			base.DAOKCAOFIGE(true);
			this.JFKENOANJNK = base.BAPJBHPEDIF(this.fastBloomShader, this.JFKENOANJNK);
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B3B1 RID: 46001 RVA: 0x004EEE5F File Offset: 0x004ED05F
		private void KHJJKPCKNKM()
		{
			if (this.JFKENOANJNK)
			{
				UnityEngine.Object.DestroyImmediate(this.JFKENOANJNK);
			}
		}

		// Token: 0x0600B3B2 RID: 46002 RVA: 0x004F18F9 File Offset: 0x004EFAF9
		public virtual bool HMHEIPAGPHD()
		{
			base.EBEBJHLBBBI(false);
			this.JFKENOANJNK = base.JBHLGBPJFEL(this.fastBloomShader, this.JFKENOANJNK);
			if (!this.PPGOAMIHMBG)
			{
				base.LNEHBOJIBAI();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B3B3 RID: 46003 RVA: 0x004F192F File Offset: 0x004EFB2F
		public virtual bool PEMCIGGIKBL()
		{
			base.POJDHPJDFEM(false);
			this.JFKENOANJNK = base.ALJPMGLOIEG(this.fastBloomShader, this.JFKENOANJNK);
			if (!this.PPGOAMIHMBG)
			{
				base.FDBKFKGCGEG();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B3B4 RID: 46004 RVA: 0x004F1965 File Offset: 0x004EFB65
		public override bool NIFOFLEPKIB()
		{
			base.CBJDCDELBJN(false);
			this.JFKENOANJNK = base.BOOFEOGDMBI(this.fastBloomShader, this.JFKENOANJNK);
			if (!this.PPGOAMIHMBG)
			{
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B3B5 RID: 46005 RVA: 0x004EEE5F File Offset: 0x004ED05F
		private void MLPCBOGCEEO()
		{
			if (this.JFKENOANJNK)
			{
				UnityEngine.Object.DestroyImmediate(this.JFKENOANJNK);
			}
		}

		// Token: 0x0600B3B6 RID: 46006 RVA: 0x004F199C File Offset: 0x004EFB9C
		private void MDJKFPDGLKD(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int num = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 8 : 8;
			float num2 = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 364f : 263f;
			this.JFKENOANJNK.SetVector("double: ", new Vector4(this.blurSize * num2, 978f, this.threshold, this.intensity));
			JONJODLFAEN.filterMode = FilterMode.Point;
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.JFKENOANJNK, 1);
			int num3 = (this.blurType == BloomOptimized.BEPEOJMJFAD.Standard) ? 1 : 8;
			for (int i = 1; i < this.blurIterations; i += 0)
			{
				this.JFKENOANJNK.SetVector("GiantGrabIdle2", new Vector4(this.blurSize * num2 + (float)i * 1945f, 809f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 6 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 6 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.JFKENOANJNK.SetTexture("1 Hand Sword Jab", renderTexture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JFKENOANJNK, 0);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B3B7 RID: 46007 RVA: 0x004EEE5F File Offset: 0x004ED05F
		private void GDCAKFIINFI()
		{
			if (this.JFKENOANJNK)
			{
				UnityEngine.Object.DestroyImmediate(this.JFKENOANJNK);
			}
		}

		// Token: 0x0600B3B8 RID: 46008 RVA: 0x004F1B40 File Offset: 0x004EFD40
		private void FIMIGEPIBFO(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int num = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 6 : 2;
			float num2 = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 1591f : 1092f;
			this.JFKENOANJNK.SetVector("", new Vector4(this.blurSize * num2, 98f, this.threshold, this.intensity));
			JONJODLFAEN.filterMode = FilterMode.Point;
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.JFKENOANJNK, 1);
			int num3 = (this.blurType == BloomOptimized.BEPEOJMJFAD.Standard) ? 1 : 4;
			for (int i = 0; i < this.blurIterations; i += 0)
			{
				this.JFKENOANJNK.SetVector("stretchWidth", new Vector4(this.blurSize * num2 + (float)i * 976f, 1755f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 1 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 1 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.JFKENOANJNK.SetTexture("reel_type2", renderTexture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JFKENOANJNK, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B3B9 RID: 46009 RVA: 0x004EEE5F File Offset: 0x004ED05F
		private void OKGEFINHFFL()
		{
			if (this.JFKENOANJNK)
			{
				UnityEngine.Object.DestroyImmediate(this.JFKENOANJNK);
			}
		}

		// Token: 0x0600B3BA RID: 46010 RVA: 0x004F1CE4 File Offset: 0x004EFEE4
		private void LEICKKKLDAD(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.MNDOFMMGLMO())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int num = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 0 : 0;
			float num2 = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 1027f : 1453f;
			this.JFKENOANJNK.SetVector("A", new Vector4(this.blurSize * num2, 1598f, this.threshold, this.intensity));
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.JFKENOANJNK, 1);
			int num3 = (this.blurType == BloomOptimized.BEPEOJMJFAD.Standard) ? 1 : 6;
			for (int i = 1; i < this.blurIterations; i += 0)
			{
				this.JFKENOANJNK.SetVector("OnChatMessage", new Vector4(this.blurSize * num2 + (float)i * 1198f, 1430f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 4 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 3 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.JFKENOANJNK.SetTexture("SexyDance3", renderTexture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JFKENOANJNK, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B3BB RID: 46011 RVA: 0x004F1E88 File Offset: 0x004F0088
		private void NHDCFLGBCNE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.IGJKBOMMMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int num = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 4 : 1;
			float num2 = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 415f : 328f;
			this.JFKENOANJNK.SetVector("1HandSwordJabFootPush", new Vector4(this.blurSize * num2, 1800f, this.threshold, this.intensity));
			JONJODLFAEN.filterMode = FilterMode.Point;
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.JFKENOANJNK, 0);
			int num3 = (this.blurType == BloomOptimized.BEPEOJMJFAD.Standard) ? 0 : 3;
			for (int i = 0; i < this.blurIterations; i++)
			{
				this.JFKENOANJNK.SetVector("RollerBladeGrindRoyale", new Vector4(this.blurSize * num2 + (float)i * 1149f, 792f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 7 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 5 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.JFKENOANJNK.SetTexture("", renderTexture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JFKENOANJNK, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B3BC RID: 46012 RVA: 0x004F2029 File Offset: 0x004F0229
		public virtual bool PDMJHKLDPLC()
		{
			base.OFKOBOMCECF(true);
			this.JFKENOANJNK = base.OOAOHFFDMJP(this.fastBloomShader, this.JFKENOANJNK);
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B3BD RID: 46013 RVA: 0x004F205F File Offset: 0x004F025F
		public virtual bool HMDBGMDFHKH()
		{
			base.BGIALJEIEFO(false);
			this.JFKENOANJNK = base.IIIIADNBONI(this.fastBloomShader, this.JFKENOANJNK);
			if (!this.PPGOAMIHMBG)
			{
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B3BE RID: 46014 RVA: 0x004EEE5F File Offset: 0x004ED05F
		private void EHKCHPFDNCA()
		{
			if (this.JFKENOANJNK)
			{
				UnityEngine.Object.DestroyImmediate(this.JFKENOANJNK);
			}
		}

		// Token: 0x0600B3BF RID: 46015 RVA: 0x004F2095 File Offset: 0x004F0295
		public virtual bool NFFLLNPGHNC()
		{
			base.CGEGCOKMPHN(true);
			this.JFKENOANJNK = base.ALJPMGLOIEG(this.fastBloomShader, this.JFKENOANJNK);
			if (!this.PPGOAMIHMBG)
			{
				base.FDBKFKGCGEG();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B3C0 RID: 46016 RVA: 0x004F20CB File Offset: 0x004F02CB
		public virtual bool FGENCAKNJAI()
		{
			base.BGIALJEIEFO(false);
			this.JFKENOANJNK = base.ALJPMGLOIEG(this.fastBloomShader, this.JFKENOANJNK);
			if (!this.PPGOAMIHMBG)
			{
				base.FDBKFKGCGEG();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B3C1 RID: 46017 RVA: 0x004F2104 File Offset: 0x004F0304
		private void GDGPNFLCNEG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.IGJKBOMMMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int num = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 1 : 7;
			float num2 = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 178f : 245f;
			this.JFKENOANJNK.SetVector("Actor_{0}_{1}_ragula", new Vector4(this.blurSize * num2, 128f, this.threshold, this.intensity));
			JONJODLFAEN.filterMode = FilterMode.Point;
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.JFKENOANJNK, 1);
			int num3 = (this.blurType == BloomOptimized.BEPEOJMJFAD.Standard) ? 1 : 2;
			for (int i = 1; i < this.blurIterations; i++)
			{
				this.JFKENOANJNK.SetVector("Animator unassigned in AnimationWarping", new Vector4(this.blurSize * num2 + (float)i * 438f, 1085f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 0 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 6 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.JFKENOANJNK.SetTexture("No hit from ", renderTexture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JFKENOANJNK, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B3C2 RID: 46018 RVA: 0x004EEE5F File Offset: 0x004ED05F
		private void IDFEHJKAJAM()
		{
			if (this.JFKENOANJNK)
			{
				UnityEngine.Object.DestroyImmediate(this.JFKENOANJNK);
			}
		}

		// Token: 0x0600B3C3 RID: 46019 RVA: 0x004F22A5 File Offset: 0x004F04A5
		public virtual bool NOCHDCDPIID()
		{
			base.NHCAHIHJHMF(false);
			this.JFKENOANJNK = base.BOOFEOGDMBI(this.fastBloomShader, this.JFKENOANJNK);
			if (!this.PPGOAMIHMBG)
			{
				base.FDBKFKGCGEG();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B3C4 RID: 46020 RVA: 0x004EEE5F File Offset: 0x004ED05F
		private void IFJEIFBOPCI()
		{
			if (this.JFKENOANJNK)
			{
				UnityEngine.Object.DestroyImmediate(this.JFKENOANJNK);
			}
		}

		// Token: 0x0600B3C5 RID: 46021 RVA: 0x004F22DC File Offset: 0x004F04DC
		private void EDBHDEOMGFP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int num = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 6 : 8;
			float num2 = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 503f : 1757f;
			this.JFKENOANJNK.SetVector("X", new Vector4(this.blurSize * num2, 458f, this.threshold, this.intensity));
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.JFKENOANJNK, 1);
			int num3 = (this.blurType == BloomOptimized.BEPEOJMJFAD.Standard) ? 1 : 0;
			for (int i = 0; i < this.blurIterations; i++)
			{
				this.JFKENOANJNK.SetVector("ArmFlex4", new Vector4(this.blurSize * num2 + (float)i * 315f, 1986f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 8 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 5 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.JFKENOANJNK.SetTexture("No klev! shance=", renderTexture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JFKENOANJNK, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B3C6 RID: 46022 RVA: 0x004F247D File Offset: 0x004F067D
		public virtual bool PNMIMCJGPGL()
		{
			base.POJDHPJDFEM(false);
			this.JFKENOANJNK = base.IIIIADNBONI(this.fastBloomShader, this.JFKENOANJNK);
			if (!this.PPGOAMIHMBG)
			{
				base.OAEAMDHOKKM();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B3C7 RID: 46023 RVA: 0x004F24B3 File Offset: 0x004F06B3
		public override bool CheckResources()
		{
			base.DAOKCAOFIGE(false);
			this.JFKENOANJNK = base.DJFOEIJIMJB(this.fastBloomShader, this.JFKENOANJNK);
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B3C8 RID: 46024 RVA: 0x004EEE5F File Offset: 0x004ED05F
		private void MKLCOEALFBI()
		{
			if (this.JFKENOANJNK)
			{
				UnityEngine.Object.DestroyImmediate(this.JFKENOANJNK);
			}
		}

		// Token: 0x0600B3C9 RID: 46025 RVA: 0x004F24E9 File Offset: 0x004F06E9
		public virtual bool AGAGDKHKPCJ()
		{
			base.IDFIHFBEIKD(false);
			this.JFKENOANJNK = base.JBHLGBPJFEL(this.fastBloomShader, this.JFKENOANJNK);
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B3CA RID: 46026 RVA: 0x004EEE5F File Offset: 0x004ED05F
		private void JCEKLINBCDB()
		{
			if (this.JFKENOANJNK)
			{
				UnityEngine.Object.DestroyImmediate(this.JFKENOANJNK);
			}
		}

		// Token: 0x0600B3CB RID: 46027 RVA: 0x004EEE5F File Offset: 0x004ED05F
		private void DGCMCCCLLGA()
		{
			if (this.JFKENOANJNK)
			{
				UnityEngine.Object.DestroyImmediate(this.JFKENOANJNK);
			}
		}

		// Token: 0x0600B3CC RID: 46028 RVA: 0x004EEE5F File Offset: 0x004ED05F
		private void GKIGMDPGAIP()
		{
			if (this.JFKENOANJNK)
			{
				UnityEngine.Object.DestroyImmediate(this.JFKENOANJNK);
			}
		}

		// Token: 0x0600B3CD RID: 46029 RVA: 0x004EEE5F File Offset: 0x004ED05F
		private void KMCACLNKBFP()
		{
			if (this.JFKENOANJNK)
			{
				UnityEngine.Object.DestroyImmediate(this.JFKENOANJNK);
			}
		}

		// Token: 0x0600B3CE RID: 46030 RVA: 0x004F251F File Offset: 0x004F071F
		public virtual bool ILBEKBHHEEL()
		{
			base.AHFDGALLKFC(false);
			this.JFKENOANJNK = base.ALJPMGLOIEG(this.fastBloomShader, this.JFKENOANJNK);
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B3CF RID: 46031 RVA: 0x004F2555 File Offset: 0x004F0755
		public override bool NHEEDPALBFN()
		{
			base.OFKOBOMCECF(true);
			this.JFKENOANJNK = base.DJFOEIJIMJB(this.fastBloomShader, this.JFKENOANJNK);
			if (!this.PPGOAMIHMBG)
			{
				base.FDBKFKGCGEG();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B3D0 RID: 46032 RVA: 0x004EEE5F File Offset: 0x004ED05F
		private void DFLLLNDKNBB()
		{
			if (this.JFKENOANJNK)
			{
				UnityEngine.Object.DestroyImmediate(this.JFKENOANJNK);
			}
		}

		// Token: 0x0600B3D1 RID: 46033 RVA: 0x004EEE5F File Offset: 0x004ED05F
		private void JKDCKHECHEJ()
		{
			if (this.JFKENOANJNK)
			{
				UnityEngine.Object.DestroyImmediate(this.JFKENOANJNK);
			}
		}

		// Token: 0x0600B3D2 RID: 46034 RVA: 0x004EEE5F File Offset: 0x004ED05F
		private void KIMKMJMMLLB()
		{
			if (this.JFKENOANJNK)
			{
				UnityEngine.Object.DestroyImmediate(this.JFKENOANJNK);
			}
		}

		// Token: 0x0600B3D3 RID: 46035 RVA: 0x004F258C File Offset: 0x004F078C
		private void PPAAMEAPADE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.MNDOFMMGLMO())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int num = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 5 : 8;
			float num2 = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 72f : 926f;
			this.JFKENOANJNK.SetVector(": ", new Vector4(this.blurSize * num2, 214f, this.threshold, this.intensity));
			JONJODLFAEN.filterMode = FilterMode.Point;
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.JFKENOANJNK, 0);
			int num3 = (this.blurType == BloomOptimized.BEPEOJMJFAD.Standard) ? 0 : 5;
			for (int i = 1; i < this.blurIterations; i += 0)
			{
				this.JFKENOANJNK.SetVector("Gesture Cut Throat", new Vector4(this.blurSize * num2 + (float)i * 1268f, 890f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 3 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 6 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.JFKENOANJNK.SetTexture("Crouch180", renderTexture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JFKENOANJNK, 0);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B3D4 RID: 46036 RVA: 0x004F272D File Offset: 0x004F092D
		public virtual bool NMFMDENKNFN()
		{
			base.OAAFLHNDKBJ(false);
			this.JFKENOANJNK = base.BAPJBHPEDIF(this.fastBloomShader, this.JFKENOANJNK);
			if (!this.PPGOAMIHMBG)
			{
				base.LNEHBOJIBAI();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B3D5 RID: 46037 RVA: 0x004EEE5F File Offset: 0x004ED05F
		private void PLBMFJMPMKL()
		{
			if (this.JFKENOANJNK)
			{
				UnityEngine.Object.DestroyImmediate(this.JFKENOANJNK);
			}
		}

		// Token: 0x0600B3D6 RID: 46038 RVA: 0x004F2764 File Offset: 0x004F0964
		private void PHFJDPLOKJK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int num = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 4 : 0;
			float num2 = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 705f : 390f;
			this.JFKENOANJNK.SetVector("_Offsets", new Vector4(this.blurSize * num2, 1697f, this.threshold, this.intensity));
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Point;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.JFKENOANJNK, 0);
			int num3 = (this.blurType == BloomOptimized.BEPEOJMJFAD.Standard) ? 1 : 6;
			for (int i = 0; i < this.blurIterations; i++)
			{
				this.JFKENOANJNK.SetVector("Forward", new Vector4(this.blurSize * num2 + (float)i * 754f, 806f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 5 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 7 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.JFKENOANJNK.SetTexture("IdleFight", renderTexture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JFKENOANJNK, 0);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B3D7 RID: 46039 RVA: 0x004F2905 File Offset: 0x004F0B05
		public override bool GGJKGIHGMGC()
		{
			base.NHCAHIHJHMF(true);
			this.JFKENOANJNK = base.IIIIADNBONI(this.fastBloomShader, this.JFKENOANJNK);
			if (!this.PPGOAMIHMBG)
			{
				base.LNEHBOJIBAI();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B3D8 RID: 46040 RVA: 0x004EEE5F File Offset: 0x004ED05F
		private void EKLDFELNMFP()
		{
			if (this.JFKENOANJNK)
			{
				UnityEngine.Object.DestroyImmediate(this.JFKENOANJNK);
			}
		}

		// Token: 0x0600B3D9 RID: 46041 RVA: 0x004EEE5F File Offset: 0x004ED05F
		private void AHMFIGNLJOB()
		{
			if (this.JFKENOANJNK)
			{
				UnityEngine.Object.DestroyImmediate(this.JFKENOANJNK);
			}
		}

		// Token: 0x0600B3DA RID: 46042 RVA: 0x004F293C File Offset: 0x004F0B3C
		private void JOFOEKABLBF(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int num = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 4 : 0;
			float num2 = (this.MNNMDGCANBI == BloomOptimized.CAGMECEAONP.Low) ? 1312f : 81f;
			this.JFKENOANJNK.SetVector("OK", new Vector4(this.blurSize * num2, 525f, this.threshold, this.intensity));
			JONJODLFAEN.filterMode = FilterMode.Point;
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(JONJODLFAEN, renderTexture, this.JFKENOANJNK, 0);
			int num3 = (this.blurType == BloomOptimized.BEPEOJMJFAD.Standard) ? 1 : 3;
			for (int i = 1; i < this.blurIterations; i += 0)
			{
				this.JFKENOANJNK.SetVector("fshop_hd3", new Vector4(this.blurSize * num2 + (float)i * 537f, 1397f, this.threshold, this.intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 4 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 1, JONJODLFAEN.format);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(renderTexture, temporary, this.JFKENOANJNK, 6 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.JFKENOANJNK.SetTexture("USE_CORNER_DETECTION", renderTexture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JFKENOANJNK, 0);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0400170F RID: 5903
		[Range(0f, 1.5f)]
		public float threshold = 0.25f;

		// Token: 0x04001710 RID: 5904
		[Range(0f, 2.5f)]
		public float intensity = 0.75f;

		// Token: 0x04001711 RID: 5905
		[Range(0.25f, 5.5f)]
		public float blurSize = 1f;

		// Token: 0x04001712 RID: 5906
		private BloomOptimized.CAGMECEAONP MNNMDGCANBI;

		// Token: 0x04001713 RID: 5907
		[Range(1f, 4f)]
		public int blurIterations = 1;

		// Token: 0x04001714 RID: 5908
		public BloomOptimized.BEPEOJMJFAD blurType;

		// Token: 0x04001715 RID: 5909
		public Shader fastBloomShader;

		// Token: 0x04001716 RID: 5910
		private Material JFKENOANJNK;

		// Token: 0x02000309 RID: 777
		public enum CAGMECEAONP
		{
			// Token: 0x04001718 RID: 5912
			Low,
			// Token: 0x04001719 RID: 5913
			High
		}

		// Token: 0x0200030A RID: 778
		public enum BEPEOJMJFAD
		{
			// Token: 0x0400171B RID: 5915
			Standard,
			// Token: 0x0400171C RID: 5916
			Sgx
		}
	}
}
