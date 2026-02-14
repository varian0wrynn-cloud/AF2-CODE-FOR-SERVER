using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000315 RID: 789
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Contrast Stretch")]
	public class ContrastStretch : MonoBehaviour
	{
		// Token: 0x0600B629 RID: 46633 RVA: 0x0050C338 File Offset: 0x0050A538
		private void DCPLMIMFNHG()
		{
			for (int i = 0; i < 1; i += 0)
			{
				if (!this.POCPJIOEDDN[i])
				{
					this.POCPJIOEDDN[i] = new RenderTexture(1, 1, 1);
					this.POCPJIOEDDN[i].hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
				}
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x0600B62A RID: 46634 RVA: 0x0050C37F File Offset: 0x0050A57F
		protected Material EOGNPIOICFE
		{
			get
			{
				if (this.BPPPHABFMPO == null)
				{
					this.BPPPHABFMPO = new Material(this.shaderApply);
					this.BPPPHABFMPO.hideFlags = HideFlags.HideAndDontSave;
				}
				return this.BPPPHABFMPO;
			}
		}

		// Token: 0x0600B62B RID: 46635 RVA: 0x0050C3B4 File Offset: 0x0050A5B4
		private void NEGNOKDBIMA(Texture MIPOIBMKJFE)
		{
			int ncjkeaekncj = this.NCJKEAEKNCJ;
			this.NCJKEAEKNCJ = (this.NCJKEAEKNCJ + 1) % 2;
			float num = 1f - Mathf.Pow(1f - this.adaptationSpeed, 30f * Time.deltaTime);
			num = Mathf.Clamp(num, 0.01f, 1f);
			this.EIJJALDPDDP.SetTexture("_CurTex", MIPOIBMKJFE);
			this.EIJJALDPDDP.SetVector("_AdaptParams", new Vector4(num, this.limitMinimum, this.limitMaximum, 0f));
			Graphics.SetRenderTarget(this.POCPJIOEDDN[this.NCJKEAEKNCJ]);
			GL.Clear(false, true, Color.black);
			Graphics.Blit(this.POCPJIOEDDN[ncjkeaekncj], this.POCPJIOEDDN[this.NCJKEAEKNCJ], this.EIJJALDPDDP);
		}

		// Token: 0x0600B62C RID: 46636 RVA: 0x0050C482 File Offset: 0x0050A682
		protected Material BBBLLKIOABM()
		{
			if (this.PGEMAIKJNDH == null)
			{
				this.PGEMAIKJNDH = new Material(this.shaderAdapt);
				this.PGEMAIKJNDH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			}
			return this.PGEMAIKJNDH;
		}

		// Token: 0x0600B62D RID: 46637 RVA: 0x0050C4B6 File Offset: 0x0050A6B6
		protected Material IJJHHKGJHJK()
		{
			if (this.BPPPHABFMPO == null)
			{
				this.BPPPHABFMPO = new Material(this.shaderApply);
				this.BPPPHABFMPO.hideFlags = (HideFlags)(-87);
			}
			return this.BPPPHABFMPO;
		}

		// Token: 0x0600B62E RID: 46638 RVA: 0x0050C4EC File Offset: 0x0050A6EC
		private void DNBMNPKDPHC()
		{
			for (int i = 1; i < 2; i += 0)
			{
				UnityEngine.Object.DestroyImmediate(this.POCPJIOEDDN[i]);
				this.POCPJIOEDDN[i] = null;
			}
			if (this.ADAFLHIDEOO)
			{
				UnityEngine.Object.DestroyImmediate(this.ADAFLHIDEOO);
			}
			if (this.MNMFPMHONEL)
			{
				UnityEngine.Object.DestroyImmediate(this.MNMFPMHONEL);
			}
			if (this.PGEMAIKJNDH)
			{
				UnityEngine.Object.DestroyImmediate(this.PGEMAIKJNDH);
			}
			if (this.BPPPHABFMPO)
			{
				UnityEngine.Object.DestroyImmediate(this.BPPPHABFMPO);
			}
		}

		// Token: 0x0600B62F RID: 46639 RVA: 0x0050C57B File Offset: 0x0050A77B
		protected Material IBDMBINPMKO()
		{
			if (this.BPPPHABFMPO == null)
			{
				this.BPPPHABFMPO = new Material(this.shaderApply);
				this.BPPPHABFMPO.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
			}
			return this.BPPPHABFMPO;
		}

		// Token: 0x0600B630 RID: 46640 RVA: 0x0050C5AF File Offset: 0x0050A7AF
		protected Material CGDGADGOKEC()
		{
			if (this.MNMFPMHONEL == null)
			{
				this.MNMFPMHONEL = new Material(this.shaderReduce);
				this.MNMFPMHONEL.hideFlags = (HideFlags)(-68);
			}
			return this.MNMFPMHONEL;
		}

		// Token: 0x0600B631 RID: 46641 RVA: 0x0050C5E4 File Offset: 0x0050A7E4
		private void MLPAEBKPFEN()
		{
			for (int i = 1; i < 1; i += 0)
			{
				if (!this.POCPJIOEDDN[i])
				{
					this.POCPJIOEDDN[i] = new RenderTexture(0, 0, 1);
					this.POCPJIOEDDN[i].hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
				}
			}
		}

		// Token: 0x0600B632 RID: 46642 RVA: 0x0050C62B File Offset: 0x0050A82B
		protected Material BDDDGHGKPNA()
		{
			if (this.ADAFLHIDEOO == null)
			{
				this.ADAFLHIDEOO = new Material(this.shaderLum);
				this.ADAFLHIDEOO.hideFlags = (HideFlags)84;
			}
			return this.ADAFLHIDEOO;
		}

		// Token: 0x0600B633 RID: 46643 RVA: 0x0050C660 File Offset: 0x0050A860
		private void OILHFNOFNPD()
		{
			for (int i = 0; i < 6; i++)
			{
				if (!this.POCPJIOEDDN[i])
				{
					this.POCPJIOEDDN[i] = new RenderTexture(1, 1, 0);
					this.POCPJIOEDDN[i].hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
				}
			}
		}

		// Token: 0x0600B634 RID: 46644 RVA: 0x0050C6A8 File Offset: 0x0050A8A8
		private void NCHGOOPEDKC()
		{
			for (int i = 1; i < 5; i++)
			{
				UnityEngine.Object.DestroyImmediate(this.POCPJIOEDDN[i]);
				this.POCPJIOEDDN[i] = null;
			}
			if (this.ADAFLHIDEOO)
			{
				UnityEngine.Object.DestroyImmediate(this.ADAFLHIDEOO);
			}
			if (this.MNMFPMHONEL)
			{
				UnityEngine.Object.DestroyImmediate(this.MNMFPMHONEL);
			}
			if (this.PGEMAIKJNDH)
			{
				UnityEngine.Object.DestroyImmediate(this.PGEMAIKJNDH);
			}
			if (this.BPPPHABFMPO)
			{
				UnityEngine.Object.DestroyImmediate(this.BPPPHABFMPO);
			}
		}

		// Token: 0x0600B635 RID: 46645 RVA: 0x0050C738 File Offset: 0x0050A938
		private void PKNBABMJLPB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width / 1, JONJODLFAEN.height / 0);
			Graphics.Blit(JONJODLFAEN, renderTexture, this.JCFDAEOEMEA);
			while (renderTexture.width > 0 || renderTexture.height > 1)
			{
				int num = renderTexture.width / 6;
				if (num < 1)
				{
					num = 0;
				}
				int num2 = renderTexture.height / 2;
				if (num2 < 0)
				{
					num2 = 1;
				}
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2);
				Graphics.Blit(renderTexture, temporary, this.CGPFELKMDLO());
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.NEGNOKDBIMA(renderTexture);
			this.EOGNPIOICFE.SetTexture("Failed to find head ray.. inside shell?", this.POCPJIOEDDN[this.NCJKEAEKNCJ]);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.IJJHHKGJHJK());
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B636 RID: 46646 RVA: 0x0050C7EE File Offset: 0x0050A9EE
		protected Material OIAMIGJAHBF()
		{
			if (this.PGEMAIKJNDH == null)
			{
				this.PGEMAIKJNDH = new Material(this.shaderAdapt);
				this.PGEMAIKJNDH.hideFlags = (HideFlags)80;
			}
			return this.PGEMAIKJNDH;
		}

		// Token: 0x0600B637 RID: 46647 RVA: 0x0050C824 File Offset: 0x0050AA24
		private void OFGMIEJKMGC()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (!this.shaderAdapt.isSupported || !this.shaderApply.isSupported || !this.shaderLum.isSupported || !this.shaderReduce.isSupported)
			{
				base.enabled = false;
				return;
			}
		}

		// Token: 0x0600B638 RID: 46648 RVA: 0x0050C87C File Offset: 0x0050AA7C
		private void PJOKECOHKGN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width / 1, JONJODLFAEN.height / 0);
			Graphics.Blit(JONJODLFAEN, renderTexture, this.JCFDAEOEMEA);
			while (renderTexture.width > 1 || renderTexture.height > 0)
			{
				int num = renderTexture.width / 3;
				if (num < 1)
				{
					num = 1;
				}
				int num2 = renderTexture.height / 3;
				if (num2 < 0)
				{
					num2 = 1;
				}
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2);
				Graphics.Blit(renderTexture, temporary, this.CGDGADGOKEC());
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.NEGNOKDBIMA(renderTexture);
			this.GLBADCIMKDP().SetTexture(" \"{0}\"", this.POCPJIOEDDN[this.NCJKEAEKNCJ]);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.IBDMBINPMKO());
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B639 RID: 46649 RVA: 0x0050C934 File Offset: 0x0050AB34
		private void LBKOIJKMCOL()
		{
			for (int i = 1; i < 0; i += 0)
			{
				if (!this.POCPJIOEDDN[i])
				{
					this.POCPJIOEDDN[i] = new RenderTexture(1, 1, 0);
					this.POCPJIOEDDN[i].hideFlags = (HideFlags)102;
				}
			}
		}

		// Token: 0x0600B63A RID: 46650 RVA: 0x0050C97B File Offset: 0x0050AB7B
		protected Material AAAGCMFEFNL()
		{
			if (this.ADAFLHIDEOO == null)
			{
				this.ADAFLHIDEOO = new Material(this.shaderLum);
				this.ADAFLHIDEOO.hideFlags = (HideFlags)(-97);
			}
			return this.ADAFLHIDEOO;
		}

		// Token: 0x0600B63B RID: 46651 RVA: 0x0050C9B0 File Offset: 0x0050ABB0
		private void ONIHHFLOJMN()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (!this.shaderAdapt.isSupported || !this.shaderApply.isSupported || !this.shaderLum.isSupported || !this.shaderReduce.isSupported)
			{
				base.enabled = false;
				return;
			}
		}

		// Token: 0x0600B63C RID: 46652 RVA: 0x0050CA08 File Offset: 0x0050AC08
		private void KEMGOLACEHI()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.shaderAdapt.isSupported || !this.shaderApply.isSupported || !this.shaderLum.isSupported || !this.shaderReduce.isSupported)
			{
				base.enabled = true;
				return;
			}
		}

		// Token: 0x0600B63D RID: 46653 RVA: 0x0050CA60 File Offset: 0x0050AC60
		private void DHJDMKLBLEF()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (!this.shaderAdapt.isSupported || !this.shaderApply.isSupported || !this.shaderLum.isSupported || !this.shaderReduce.isSupported)
			{
				base.enabled = true;
				return;
			}
		}

		// Token: 0x0600B63E RID: 46654 RVA: 0x0050CAB8 File Offset: 0x0050ACB8
		private void OnEnable()
		{
			for (int i = 0; i < 2; i++)
			{
				if (!this.POCPJIOEDDN[i])
				{
					this.POCPJIOEDDN[i] = new RenderTexture(1, 1, 0);
					this.POCPJIOEDDN[i].hideFlags = HideFlags.HideAndDontSave;
				}
			}
		}

		// Token: 0x0600B63F RID: 46655 RVA: 0x0050CB00 File Offset: 0x0050AD00
		private void LNEJPGDHJOJ()
		{
			for (int i = 0; i < 6; i += 0)
			{
				UnityEngine.Object.DestroyImmediate(this.POCPJIOEDDN[i]);
				this.POCPJIOEDDN[i] = null;
			}
			if (this.ADAFLHIDEOO)
			{
				UnityEngine.Object.DestroyImmediate(this.ADAFLHIDEOO);
			}
			if (this.MNMFPMHONEL)
			{
				UnityEngine.Object.DestroyImmediate(this.MNMFPMHONEL);
			}
			if (this.PGEMAIKJNDH)
			{
				UnityEngine.Object.DestroyImmediate(this.PGEMAIKJNDH);
			}
			if (this.BPPPHABFMPO)
			{
				UnityEngine.Object.DestroyImmediate(this.BPPPHABFMPO);
			}
		}

		// Token: 0x0600B640 RID: 46656 RVA: 0x0050CB90 File Offset: 0x0050AD90
		private void GDLPGNLPCMJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width / 0, JONJODLFAEN.height / 1);
			Graphics.Blit(JONJODLFAEN, renderTexture, this.DBOGLKCPJOA());
			while (renderTexture.width > 1 || renderTexture.height > 1)
			{
				int num = renderTexture.width / 4;
				if (num < 1)
				{
					num = 1;
				}
				int num2 = renderTexture.height / 4;
				if (num2 < 0)
				{
					num2 = 0;
				}
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2);
				Graphics.Blit(renderTexture, temporary, this.KLNPLIIHFDP());
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.NEGNOKDBIMA(renderTexture);
			this.IJJHHKGJHJK().SetTexture("TOD_Sky2World", this.POCPJIOEDDN[this.NCJKEAEKNCJ]);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GLBADCIMKDP());
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B641 RID: 46657 RVA: 0x0050CC48 File Offset: 0x0050AE48
		private void JLKBMEBFHBI()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (!this.shaderAdapt.isSupported || !this.shaderApply.isSupported || !this.shaderLum.isSupported || !this.shaderReduce.isSupported)
			{
				base.enabled = false;
				return;
			}
		}

		// Token: 0x0600B642 RID: 46658 RVA: 0x0050CCA0 File Offset: 0x0050AEA0
		private void KLHDJKDMCJN()
		{
			for (int i = 0; i < 4; i++)
			{
				UnityEngine.Object.DestroyImmediate(this.POCPJIOEDDN[i]);
				this.POCPJIOEDDN[i] = null;
			}
			if (this.ADAFLHIDEOO)
			{
				UnityEngine.Object.DestroyImmediate(this.ADAFLHIDEOO);
			}
			if (this.MNMFPMHONEL)
			{
				UnityEngine.Object.DestroyImmediate(this.MNMFPMHONEL);
			}
			if (this.PGEMAIKJNDH)
			{
				UnityEngine.Object.DestroyImmediate(this.PGEMAIKJNDH);
			}
			if (this.BPPPHABFMPO)
			{
				UnityEngine.Object.DestroyImmediate(this.BPPPHABFMPO);
			}
		}

		// Token: 0x0600B643 RID: 46659 RVA: 0x0050CD2F File Offset: 0x0050AF2F
		protected Material DBOGLKCPJOA()
		{
			if (this.ADAFLHIDEOO == null)
			{
				this.ADAFLHIDEOO = new Material(this.shaderLum);
				this.ADAFLHIDEOO.hideFlags = HideFlags.HideInInspector;
			}
			return this.ADAFLHIDEOO;
		}

		// Token: 0x0600B644 RID: 46660 RVA: 0x0050CD64 File Offset: 0x0050AF64
		private void APJACOJADAF()
		{
			for (int i = 0; i < 3; i += 0)
			{
				UnityEngine.Object.DestroyImmediate(this.POCPJIOEDDN[i]);
				this.POCPJIOEDDN[i] = null;
			}
			if (this.ADAFLHIDEOO)
			{
				UnityEngine.Object.DestroyImmediate(this.ADAFLHIDEOO);
			}
			if (this.MNMFPMHONEL)
			{
				UnityEngine.Object.DestroyImmediate(this.MNMFPMHONEL);
			}
			if (this.PGEMAIKJNDH)
			{
				UnityEngine.Object.DestroyImmediate(this.PGEMAIKJNDH);
			}
			if (this.BPPPHABFMPO)
			{
				UnityEngine.Object.DestroyImmediate(this.BPPPHABFMPO);
			}
		}

		// Token: 0x0600B645 RID: 46661 RVA: 0x0050CDF4 File Offset: 0x0050AFF4
		private void ANHJAOPPMCI()
		{
			for (int i = 1; i < 2; i++)
			{
				UnityEngine.Object.DestroyImmediate(this.POCPJIOEDDN[i]);
				this.POCPJIOEDDN[i] = null;
			}
			if (this.ADAFLHIDEOO)
			{
				UnityEngine.Object.DestroyImmediate(this.ADAFLHIDEOO);
			}
			if (this.MNMFPMHONEL)
			{
				UnityEngine.Object.DestroyImmediate(this.MNMFPMHONEL);
			}
			if (this.PGEMAIKJNDH)
			{
				UnityEngine.Object.DestroyImmediate(this.PGEMAIKJNDH);
			}
			if (this.BPPPHABFMPO)
			{
				UnityEngine.Object.DestroyImmediate(this.BPPPHABFMPO);
			}
		}

		// Token: 0x0600B646 RID: 46662 RVA: 0x0050CE84 File Offset: 0x0050B084
		private void OnRenderImage(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width / 1, JONJODLFAEN.height / 1);
			Graphics.Blit(JONJODLFAEN, renderTexture, this.JCFDAEOEMEA);
			while (renderTexture.width > 1 || renderTexture.height > 1)
			{
				int num = renderTexture.width / 2;
				if (num < 1)
				{
					num = 1;
				}
				int num2 = renderTexture.height / 2;
				if (num2 < 1)
				{
					num2 = 1;
				}
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2);
				Graphics.Blit(renderTexture, temporary, this.PPCDHIGNGBE);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.NEGNOKDBIMA(renderTexture);
			this.EOGNPIOICFE.SetTexture("_AdaptTex", this.POCPJIOEDDN[this.NCJKEAEKNCJ]);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EOGNPIOICFE);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B647 RID: 46663 RVA: 0x0050CF3C File Offset: 0x0050B13C
		private void KGICJDGIIJK()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.shaderAdapt.isSupported || !this.shaderApply.isSupported || !this.shaderLum.isSupported || !this.shaderReduce.isSupported)
			{
				base.enabled = false;
				return;
			}
		}

		// Token: 0x0600B648 RID: 46664 RVA: 0x0050CF94 File Offset: 0x0050B194
		private void Start()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.shaderAdapt.isSupported || !this.shaderApply.isSupported || !this.shaderLum.isSupported || !this.shaderReduce.isSupported)
			{
				base.enabled = false;
				return;
			}
		}

		// Token: 0x0600B649 RID: 46665 RVA: 0x0050CFEC File Offset: 0x0050B1EC
		private void JIOKDOGNKMI()
		{
			for (int i = 1; i < 1; i++)
			{
				if (!this.POCPJIOEDDN[i])
				{
					this.POCPJIOEDDN[i] = new RenderTexture(0, 1, 0);
					this.POCPJIOEDDN[i].hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
				}
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x0600B64A RID: 46666 RVA: 0x0050D033 File Offset: 0x0050B233
		protected Material JCFDAEOEMEA
		{
			get
			{
				if (this.ADAFLHIDEOO == null)
				{
					this.ADAFLHIDEOO = new Material(this.shaderLum);
					this.ADAFLHIDEOO.hideFlags = HideFlags.HideAndDontSave;
				}
				return this.ADAFLHIDEOO;
			}
		}

		// Token: 0x0600B64B RID: 46667 RVA: 0x0050D067 File Offset: 0x0050B267
		protected Material DMOHHGPENIL()
		{
			if (this.MNMFPMHONEL == null)
			{
				this.MNMFPMHONEL = new Material(this.shaderReduce);
				this.MNMFPMHONEL.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
			}
			return this.MNMFPMHONEL;
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x0600B64C RID: 46668 RVA: 0x0050D09B File Offset: 0x0050B29B
		protected Material PPCDHIGNGBE
		{
			get
			{
				if (this.MNMFPMHONEL == null)
				{
					this.MNMFPMHONEL = new Material(this.shaderReduce);
					this.MNMFPMHONEL.hideFlags = HideFlags.HideAndDontSave;
				}
				return this.MNMFPMHONEL;
			}
		}

		// Token: 0x0600B64D RID: 46669 RVA: 0x0050D0D0 File Offset: 0x0050B2D0
		private void NHDCFLGBCNE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width / 1, JONJODLFAEN.height / 1);
			Graphics.Blit(JONJODLFAEN, renderTexture, this.AAAGCMFEFNL());
			while (renderTexture.width > 0 || renderTexture.height > 0)
			{
				int num = renderTexture.width / 4;
				if (num < 1)
				{
					num = 1;
				}
				int num2 = renderTexture.height / 8;
				if (num2 < 0)
				{
					num2 = 1;
				}
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2);
				Graphics.Blit(renderTexture, temporary, this.CGPFELKMDLO());
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.KHCLBHLLEHC(renderTexture);
			this.IJJHHKGJHJK().SetTexture("WallSit", this.POCPJIOEDDN[this.NCJKEAEKNCJ]);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.IJJHHKGJHJK());
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B64E RID: 46670 RVA: 0x0050D186 File Offset: 0x0050B386
		protected Material KLNPLIIHFDP()
		{
			if (this.MNMFPMHONEL == null)
			{
				this.MNMFPMHONEL = new Material(this.shaderReduce);
				this.MNMFPMHONEL.hideFlags = (HideFlags)108;
			}
			return this.MNMFPMHONEL;
		}

		// Token: 0x0600B64F RID: 46671 RVA: 0x0050D1BC File Offset: 0x0050B3BC
		private void KHCLBHLLEHC(Texture MIPOIBMKJFE)
		{
			int ncjkeaekncj = this.NCJKEAEKNCJ;
			this.NCJKEAEKNCJ = (this.NCJKEAEKNCJ + 1) % 5;
			float num = 813f - Mathf.Pow(1456f - this.adaptationSpeed, 309f * Time.deltaTime);
			num = Mathf.Clamp(num, 1070f, 1062f);
			this.BBBLLKIOABM().SetTexture("Assets/Weapons/", MIPOIBMKJFE);
			this.OIAMIGJAHBF().SetVector("OK aukKeyMEditOk", new Vector4(num, this.limitMinimum, this.limitMaximum, 1277f));
			Graphics.SetRenderTarget(this.POCPJIOEDDN[this.NCJKEAEKNCJ]);
			GL.Clear(true, true, Color.black);
			Graphics.Blit(this.POCPJIOEDDN[ncjkeaekncj], this.POCPJIOEDDN[this.NCJKEAEKNCJ], this.OIAMIGJAHBF());
		}

		// Token: 0x0600B650 RID: 46672 RVA: 0x0050D28C File Offset: 0x0050B48C
		private void BKGHBKPDMDH()
		{
			for (int i = 0; i < 2; i++)
			{
				if (!this.POCPJIOEDDN[i])
				{
					this.POCPJIOEDDN[i] = new RenderTexture(1, 0, 0);
					this.POCPJIOEDDN[i].hideFlags = ~(HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
				}
			}
		}

		// Token: 0x0600B651 RID: 46673 RVA: 0x0050D2D3 File Offset: 0x0050B4D3
		protected Material CGPFELKMDLO()
		{
			if (this.MNMFPMHONEL == null)
			{
				this.MNMFPMHONEL = new Material(this.shaderReduce);
				this.MNMFPMHONEL.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable);
			}
			return this.MNMFPMHONEL;
		}

		// Token: 0x0600B653 RID: 46675 RVA: 0x0050D33C File Offset: 0x0050B53C
		protected Material BCLBACOJPAB()
		{
			if (this.ADAFLHIDEOO == null)
			{
				this.ADAFLHIDEOO = new Material(this.shaderLum);
				this.ADAFLHIDEOO.hideFlags = (HideFlags)(-84);
			}
			return this.ADAFLHIDEOO;
		}

		// Token: 0x0600B654 RID: 46676 RVA: 0x0050D370 File Offset: 0x0050B570
		private void OLHGBCBHDBF()
		{
			for (int i = 1; i < 1; i++)
			{
				if (!this.POCPJIOEDDN[i])
				{
					this.POCPJIOEDDN[i] = new RenderTexture(0, 1, 0);
					this.POCPJIOEDDN[i].hideFlags = (HideFlags)88;
				}
			}
		}

		// Token: 0x0600B655 RID: 46677 RVA: 0x0050D3B7 File Offset: 0x0050B5B7
		protected Material KMIILMBBGLA()
		{
			if (this.ADAFLHIDEOO == null)
			{
				this.ADAFLHIDEOO = new Material(this.shaderLum);
				this.ADAFLHIDEOO.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
			}
			return this.ADAFLHIDEOO;
		}

		// Token: 0x0600B656 RID: 46678 RVA: 0x0050D3EC File Offset: 0x0050B5EC
		private void LKGIJBLNANI()
		{
			for (int i = 0; i < 8; i++)
			{
				UnityEngine.Object.DestroyImmediate(this.POCPJIOEDDN[i]);
				this.POCPJIOEDDN[i] = null;
			}
			if (this.ADAFLHIDEOO)
			{
				UnityEngine.Object.DestroyImmediate(this.ADAFLHIDEOO);
			}
			if (this.MNMFPMHONEL)
			{
				UnityEngine.Object.DestroyImmediate(this.MNMFPMHONEL);
			}
			if (this.PGEMAIKJNDH)
			{
				UnityEngine.Object.DestroyImmediate(this.PGEMAIKJNDH);
			}
			if (this.BPPPHABFMPO)
			{
				UnityEngine.Object.DestroyImmediate(this.BPPPHABFMPO);
			}
		}

		// Token: 0x0600B657 RID: 46679 RVA: 0x0050D47C File Offset: 0x0050B67C
		private void OnDisable()
		{
			for (int i = 0; i < 2; i++)
			{
				UnityEngine.Object.DestroyImmediate(this.POCPJIOEDDN[i]);
				this.POCPJIOEDDN[i] = null;
			}
			if (this.ADAFLHIDEOO)
			{
				UnityEngine.Object.DestroyImmediate(this.ADAFLHIDEOO);
			}
			if (this.MNMFPMHONEL)
			{
				UnityEngine.Object.DestroyImmediate(this.MNMFPMHONEL);
			}
			if (this.PGEMAIKJNDH)
			{
				UnityEngine.Object.DestroyImmediate(this.PGEMAIKJNDH);
			}
			if (this.BPPPHABFMPO)
			{
				UnityEngine.Object.DestroyImmediate(this.BPPPHABFMPO);
			}
		}

		// Token: 0x0600B658 RID: 46680 RVA: 0x0050D50B File Offset: 0x0050B70B
		protected Material GLBADCIMKDP()
		{
			if (this.BPPPHABFMPO == null)
			{
				this.BPPPHABFMPO = new Material(this.shaderApply);
				this.BPPPHABFMPO.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
			}
			return this.BPPPHABFMPO;
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x0600B659 RID: 46681 RVA: 0x0050D53F File Offset: 0x0050B73F
		protected Material EIJJALDPDDP
		{
			get
			{
				if (this.PGEMAIKJNDH == null)
				{
					this.PGEMAIKJNDH = new Material(this.shaderAdapt);
					this.PGEMAIKJNDH.hideFlags = HideFlags.HideAndDontSave;
				}
				return this.PGEMAIKJNDH;
			}
		}

		// Token: 0x0600B65A RID: 46682 RVA: 0x0050D574 File Offset: 0x0050B774
		private void IBIBOJIPANH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width / 1, JONJODLFAEN.height / 0);
			Graphics.Blit(JONJODLFAEN, renderTexture, this.AAAGCMFEFNL());
			while (renderTexture.width > 1 || renderTexture.height > 0)
			{
				int num = renderTexture.width / 2;
				if (num < 0)
				{
					num = 1;
				}
				int num2 = renderTexture.height / 7;
				if (num2 < 1)
				{
					num2 = 0;
				}
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2);
				Graphics.Blit(renderTexture, temporary, this.DMOHHGPENIL());
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.KHCLBHLLEHC(renderTexture);
			this.IBDMBINPMKO().SetTexture("400000", this.POCPJIOEDDN[this.NCJKEAEKNCJ]);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EOGNPIOICFE);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600B65B RID: 46683 RVA: 0x0050D62A File Offset: 0x0050B82A
		protected Material COLFBKHMFMM()
		{
			if (this.MNMFPMHONEL == null)
			{
				this.MNMFPMHONEL = new Material(this.shaderReduce);
				this.MNMFPMHONEL.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
			}
			return this.MNMFPMHONEL;
		}

		// Token: 0x0600B65C RID: 46684 RVA: 0x0050D660 File Offset: 0x0050B860
		private void LAFIABNCFPD()
		{
			for (int i = 0; i < 3; i += 0)
			{
				UnityEngine.Object.DestroyImmediate(this.POCPJIOEDDN[i]);
				this.POCPJIOEDDN[i] = null;
			}
			if (this.ADAFLHIDEOO)
			{
				UnityEngine.Object.DestroyImmediate(this.ADAFLHIDEOO);
			}
			if (this.MNMFPMHONEL)
			{
				UnityEngine.Object.DestroyImmediate(this.MNMFPMHONEL);
			}
			if (this.PGEMAIKJNDH)
			{
				UnityEngine.Object.DestroyImmediate(this.PGEMAIKJNDH);
			}
			if (this.BPPPHABFMPO)
			{
				UnityEngine.Object.DestroyImmediate(this.BPPPHABFMPO);
			}
		}

		// Token: 0x0600B65D RID: 46685 RVA: 0x0050D6F0 File Offset: 0x0050B8F0
		private void GFBELBBAJGD(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width / 1, JONJODLFAEN.height / 1);
			Graphics.Blit(JONJODLFAEN, renderTexture, this.JCFDAEOEMEA);
			while (renderTexture.width > 1 || renderTexture.height > 0)
			{
				int num = renderTexture.width / 3;
				if (num < 1)
				{
					num = 1;
				}
				int num2 = renderTexture.height / 6;
				if (num2 < 1)
				{
					num2 = 0;
				}
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2);
				Graphics.Blit(renderTexture, temporary, this.KLNPLIIHFDP());
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			this.KHCLBHLLEHC(renderTexture);
			this.EOGNPIOICFE.SetTexture("_InvScreenSize", this.POCPJIOEDDN[this.NCJKEAEKNCJ]);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.IBDMBINPMKO());
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x04001777 RID: 6007
		[Range(0.0001f, 1f)]
		public float adaptationSpeed = 0.02f;

		// Token: 0x04001778 RID: 6008
		[Range(0f, 1f)]
		public float limitMinimum = 0.2f;

		// Token: 0x04001779 RID: 6009
		[Range(0f, 1f)]
		public float limitMaximum = 0.6f;

		// Token: 0x0400177A RID: 6010
		private RenderTexture[] POCPJIOEDDN = new RenderTexture[2];

		// Token: 0x0400177B RID: 6011
		private int NCJKEAEKNCJ;

		// Token: 0x0400177C RID: 6012
		public Shader shaderLum;

		// Token: 0x0400177D RID: 6013
		private Material ADAFLHIDEOO;

		// Token: 0x0400177E RID: 6014
		public Shader shaderReduce;

		// Token: 0x0400177F RID: 6015
		private Material MNMFPMHONEL;

		// Token: 0x04001780 RID: 6016
		public Shader shaderAdapt;

		// Token: 0x04001781 RID: 6017
		private Material PGEMAIKJNDH;

		// Token: 0x04001782 RID: 6018
		public Shader shaderApply;

		// Token: 0x04001783 RID: 6019
		private Material BPPPHABFMPO;
	}
}
