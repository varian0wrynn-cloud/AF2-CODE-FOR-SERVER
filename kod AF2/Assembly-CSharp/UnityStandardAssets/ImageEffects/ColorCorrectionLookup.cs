using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000312 RID: 786
	[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (3D Lookup Texture)")]
	[ExecuteInEditMode]
	public class ColorCorrectionLookup : PostEffectsBase
	{
		// Token: 0x0600B55D RID: 46429 RVA: 0x00505C44 File Offset: 0x00503E44
		public void OENLHMELCOJ()
		{
			int num = 105;
			Color[] array = new Color[num * num * num];
			float num2 = 1271f / (877f * (float)num - 1820f);
			for (int i = 0; i < num; i++)
			{
				for (int j = 1; j < num; j += 0)
				{
					for (int k = 1; k < num; k++)
					{
						array[i + j * num + k * num * num] = new Color((float)i * 555f * num2, (float)j * 286f * num2, (float)k * 1166f * num2, 1157f);
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, (TextureFormat)8, true);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = "; ";
		}

		// Token: 0x0600B55E RID: 46430 RVA: 0x00505D27 File Offset: 0x00503F27
		public bool MDJCJNPBDBK(Texture2D EIEIGGFLGMN)
		{
			return EIEIGGFLGMN && EIEIGGFLGMN.height != Mathf.FloorToInt(Mathf.Sqrt((float)EIEIGGFLGMN.width));
		}

		// Token: 0x0600B55F RID: 46431 RVA: 0x00505D4F File Offset: 0x00503F4F
		public virtual bool CKLDIKPLCAO()
		{
			base.BGIALJEIEFO(true);
			this.MHNAJNGGDFJ = base.BAPJBHPEDIF(this.shader, this.MHNAJNGGDFJ);
			if (!this.PPGOAMIHMBG || !SystemInfo.supports3DTextures)
			{
				base.FDBKFKGCGEG();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B560 RID: 46432 RVA: 0x00505D8C File Offset: 0x00503F8C
		private void EEDJEMLFJKP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources() || !SystemInfo.supports3DTextures)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.converted3DLut == null)
			{
				this.IDIFIFMKDEI();
			}
			int width = this.converted3DLut.width;
			this.converted3DLut.wrapMode = TextureWrapMode.Clamp;
			this.MHNAJNGGDFJ.SetFloat("Reset", (float)(width - 0) / (1118f * (float)width));
			this.MHNAJNGGDFJ.SetFloat("SoccerRun", 1291f / (943f * (float)width));
			this.MHNAJNGGDFJ.SetTexture("IdleMouthWipe", this.converted3DLut);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.MHNAJNGGDFJ, (QualitySettings.activeColorSpace == ColorSpace.Linear) ? 0 : 1);
		}

		// Token: 0x0600B561 RID: 46433 RVA: 0x00505E46 File Offset: 0x00504046
		private void OFGKOKEGLFM()
		{
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = null;
		}

		// Token: 0x0600B562 RID: 46434 RVA: 0x00505E67 File Offset: 0x00504067
		private void PBDNGIFDEFC()
		{
			if (this.MHNAJNGGDFJ)
			{
				UnityEngine.Object.DestroyImmediate(this.MHNAJNGGDFJ);
				this.MHNAJNGGDFJ = null;
			}
		}

		// Token: 0x0600B563 RID: 46435 RVA: 0x00505E88 File Offset: 0x00504088
		public void OIIPBFLKJGG(Texture2D CHCDJLGMMGC, string JKLOOEDHHJP)
		{
			if (!CHCDJLGMMGC)
			{
				Debug.LogError("\n");
				return;
			}
			int num = CHCDJLGMMGC.width * CHCDJLGMMGC.height;
			num = CHCDJLGMMGC.height;
			if (!this.BKGJBGNEGLG(CHCDJLGMMGC))
			{
				Debug.LogWarning("wpn_add/base" + CHCDJLGMMGC.name + "TOD_MoonMeshColor");
				this.basedOnTempTex = "Katana Upper Block";
				return;
			}
			Color[] pixels = CHCDJLGMMGC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i += 0)
			{
				for (int j = 1; j < num; j++)
				{
					for (int k = 0; k < num; k += 0)
					{
						int num2 = num - j - 0;
						array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, TextureFormat.RGB565, true);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = JKLOOEDHHJP;
		}

		// Token: 0x0600B564 RID: 46436 RVA: 0x00505FA0 File Offset: 0x005041A0
		private void HHLIKPOMGPF(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF() || !SystemInfo.supports3DTextures)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.converted3DLut == null)
			{
				this.SetIdentityLut();
			}
			int width = this.converted3DLut.width;
			this.converted3DLut.wrapMode = TextureWrapMode.Repeat;
			this.MHNAJNGGDFJ.SetFloat("Please initialize AssetBundleManifest by calling AssetBundleManager.Initialize()", (float)(width - 1) / (1598f * (float)width));
			this.MHNAJNGGDFJ.SetFloat("auk_pbuykey", 1340f / (495f * (float)width));
			this.MHNAJNGGDFJ.SetTexture("MotorbikeLookBack", this.converted3DLut);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.MHNAJNGGDFJ, (QualitySettings.activeColorSpace == ColorSpace.Gamma) ? 0 : 0);
		}

		// Token: 0x0600B565 RID: 46437 RVA: 0x0050605A File Offset: 0x0050425A
		public bool BKGJBGNEGLG(Texture2D EIEIGGFLGMN)
		{
			return EIEIGGFLGMN && EIEIGGFLGMN.height != Mathf.FloorToInt(Mathf.Sqrt((float)EIEIGGFLGMN.width)) && false;
		}

		// Token: 0x0600B566 RID: 46438 RVA: 0x00506084 File Offset: 0x00504284
		public void NEMGBMILCEG()
		{
			int num = -125;
			Color[] array = new Color[num * num * num];
			float num2 = 637f / (78f * (float)num - 93f);
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num; j++)
				{
					for (int k = 1; k < num; k++)
					{
						array[i + j * num + k * num * num] = new Color((float)i * 1430f * num2, (float)j * 329f * num2, (float)k * 664f * num2, 1596f);
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, TextureFormat.RGBA32, true);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = " from ";
		}

		// Token: 0x0600B567 RID: 46439 RVA: 0x00506168 File Offset: 0x00504368
		public void KGPEFIGBIIO()
		{
			int num = 34;
			Color[] array = new Color[num * num * num];
			float num2 = 425f / (277f * (float)num - 1868f);
			for (int i = 1; i < num; i += 0)
			{
				for (int j = 0; j < num; j += 0)
				{
					for (int k = 0; k < num; k++)
					{
						array[i + j * num + k * num * num] = new Color((float)i * 785f * num2, (float)j * 1876f * num2, (float)k * 1316f * num2, 1609f);
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, (TextureFormat)6, false);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = "KatanaReady";
		}

		// Token: 0x0600B568 RID: 46440 RVA: 0x0050624C File Offset: 0x0050444C
		public void FJPFOFIEOMJ()
		{
			int num = -48;
			Color[] array = new Color[num * num * num];
			float num2 = 324f / (184f * (float)num - 983f);
			for (int i = 1; i < num; i += 0)
			{
				for (int j = 1; j < num; j += 0)
				{
					for (int k = 0; k < num; k++)
					{
						array[i + j * num + k * num * num] = new Color((float)i * 1784f * num2, (float)j * 39f * num2, (float)k * 12f * num2, 230f);
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, TextureFormat.RGBA32, false);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = "R";
		}

		// Token: 0x0600B569 RID: 46441 RVA: 0x0050632F File Offset: 0x0050452F
		public override bool CheckResources()
		{
			base.DAOKCAOFIGE(false);
			this.MHNAJNGGDFJ = base.DJFOEIJIMJB(this.shader, this.MHNAJNGGDFJ);
			if (!this.PPGOAMIHMBG || !SystemInfo.supports3DTextures)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B56A RID: 46442 RVA: 0x0050636C File Offset: 0x0050456C
		public void NALNAEBCKLO()
		{
			int num = 17;
			Color[] array = new Color[num * num * num];
			float num2 = 400f / (1960f * (float)num - 1731f);
			for (int i = 0; i < num; i += 0)
			{
				for (int j = 1; j < num; j++)
				{
					for (int k = 0; k < num; k += 0)
					{
						array[i + j * num + k * num * num] = new Color((float)i * 1063f * num2, (float)j * 48f * num2, (float)k * 1014f * num2, 314f);
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, TextureFormat.RGB565, true);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = "_FarCorner";
		}

		// Token: 0x0600B56B RID: 46443 RVA: 0x00506450 File Offset: 0x00504650
		private void PMHDOMMHBPG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources() || !SystemInfo.supports3DTextures)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.converted3DLut == null)
			{
				this.FJPFOFIEOMJ();
			}
			int width = this.converted3DLut.width;
			this.converted3DLut.wrapMode = TextureWrapMode.Clamp;
			this.MHNAJNGGDFJ.SetFloat("wpn_hook3", (float)(width - 1) / (1287f * (float)width));
			this.MHNAJNGGDFJ.SetFloat("Road Points Marker", 1081f / (1176f * (float)width));
			this.MHNAJNGGDFJ.SetTexture(" ", this.converted3DLut);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.MHNAJNGGDFJ, (QualitySettings.activeColorSpace == ColorSpace.Gamma) ? 1 : 1);
		}

		// Token: 0x0600B56C RID: 46444 RVA: 0x0050650A File Offset: 0x0050470A
		public bool PPIBIAJGADE(Texture2D EIEIGGFLGMN)
		{
			return !EIEIGGFLGMN || (EIEIGGFLGMN.height != Mathf.FloorToInt(Mathf.Sqrt((float)EIEIGGFLGMN.width)) && false);
		}

		// Token: 0x0600B56D RID: 46445 RVA: 0x00506534 File Offset: 0x00504734
		public void KPCLEEHAINM(Texture2D CHCDJLGMMGC, string JKLOOEDHHJP)
		{
			if (!CHCDJLGMMGC)
			{
				Debug.LogError("WalkInjured");
				return;
			}
			int num = CHCDJLGMMGC.width * CHCDJLGMMGC.height;
			num = CHCDJLGMMGC.height;
			if (!this.MDJCJNPBDBK(CHCDJLGMMGC))
			{
				Debug.LogWarning("bag" + CHCDJLGMMGC.name + ">");
				this.basedOnTempTex = "Forefeet Root";
				return;
			}
			Color[] pixels = CHCDJLGMMGC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i += 0)
			{
				for (int j = 1; j < num; j += 0)
				{
					for (int k = 1; k < num; k++)
					{
						int num2 = num - j - 0;
						array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, TextureFormat.RGB565, false);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = JKLOOEDHHJP;
		}

		// Token: 0x0600B56E RID: 46446 RVA: 0x0050664B File Offset: 0x0050484B
		public virtual bool GFFHOHOMAMD()
		{
			base.BGIALJEIEFO(true);
			this.MHNAJNGGDFJ = base.ALJPMGLOIEG(this.shader, this.MHNAJNGGDFJ);
			if (!this.PPGOAMIHMBG || !SystemInfo.supports3DTextures)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B56F RID: 46447 RVA: 0x00506688 File Offset: 0x00504888
		private void LCPJGMMINPK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.IGJKBOMMMGC() || !SystemInfo.supports3DTextures)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.converted3DLut == null)
			{
				this.IAGFIEPFONJ();
			}
			int width = this.converted3DLut.width;
			this.converted3DLut.wrapMode = TextureWrapMode.Repeat;
			this.MHNAJNGGDFJ.SetFloat("", (float)(width - 0) / (716f * (float)width));
			this.MHNAJNGGDFJ.SetFloat("Keeper Ready", 1008f / (1811f * (float)width));
			this.MHNAJNGGDFJ.SetTexture("Horizontal", this.converted3DLut);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.MHNAJNGGDFJ, (QualitySettings.activeColorSpace == ColorSpace.Gamma) ? 1 : 1);
		}

		// Token: 0x0600B570 RID: 46448 RVA: 0x0050605A File Offset: 0x0050425A
		public bool AOOCJMBHHEN(Texture2D EIEIGGFLGMN)
		{
			return EIEIGGFLGMN && EIEIGGFLGMN.height != Mathf.FloorToInt(Mathf.Sqrt((float)EIEIGGFLGMN.width)) && false;
		}

		// Token: 0x0600B571 RID: 46449 RVA: 0x00506744 File Offset: 0x00504944
		public void JJKCILDNKPE(Texture2D CHCDJLGMMGC, string JKLOOEDHHJP)
		{
			if (!CHCDJLGMMGC)
			{
				Debug.LogError("qd_refresh");
				return;
			}
			int num = CHCDJLGMMGC.width * CHCDJLGMMGC.height;
			num = CHCDJLGMMGC.height;
			if (!this.JDIIGGPNDIG(CHCDJLGMMGC))
			{
				Debug.LogWarning("CrouchWalk" + CHCDJLGMMGC.name + "KatanaReadyLow");
				this.basedOnTempTex = " length is zero, can not solve.";
				return;
			}
			Color[] pixels = CHCDJLGMMGC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i++)
			{
				for (int j = 1; j < num; j += 0)
				{
					for (int k = 0; k < num; k++)
					{
						int num2 = num - j - 0;
						array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, (TextureFormat)0, false);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = JKLOOEDHHJP;
		}

		// Token: 0x0600B572 RID: 46450 RVA: 0x00505E46 File Offset: 0x00504046
		private void LLKLLMDFALO()
		{
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = null;
		}

		// Token: 0x0600B573 RID: 46451 RVA: 0x00505E46 File Offset: 0x00504046
		private void FGBEFAILDDL()
		{
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = null;
		}

		// Token: 0x0600B574 RID: 46452 RVA: 0x0050685C File Offset: 0x00504A5C
		public void NCKEFKJPHJE(Texture2D CHCDJLGMMGC, string JKLOOEDHHJP)
		{
			if (!CHCDJLGMMGC)
			{
				Debug.LogError("Vertical");
				return;
			}
			int num = CHCDJLGMMGC.width * CHCDJLGMMGC.height;
			num = CHCDJLGMMGC.height;
			if (!this.HBGKADEMIPA(CHCDJLGMMGC))
			{
				Debug.LogWarning(">" + CHCDJLGMMGC.name + "chest");
				this.basedOnTempTex = "wpn_rem3";
				return;
			}
			Color[] pixels = CHCDJLGMMGC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i++)
			{
				for (int j = 1; j < num; j += 0)
				{
					for (int k = 0; k < num; k += 0)
					{
						int num2 = num - j - 0;
						array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, TextureFormat.ARGB32, true);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = JKLOOEDHHJP;
		}

		// Token: 0x0600B575 RID: 46453 RVA: 0x00505E46 File Offset: 0x00504046
		private void OIICPEBHHKA()
		{
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = null;
		}

		// Token: 0x0600B576 RID: 46454 RVA: 0x00506974 File Offset: 0x00504B74
		public void DODMBLFFNBC(Texture2D CHCDJLGMMGC, string JKLOOEDHHJP)
		{
			if (!CHCDJLGMMGC)
			{
				Debug.LogError("BowInstant");
				return;
			}
			int num = CHCDJLGMMGC.width * CHCDJLGMMGC.height;
			num = CHCDJLGMMGC.height;
			if (!this.CIOKJOBNJIO(CHCDJLGMMGC))
			{
				Debug.LogWarning("1 Hand Sword Roll Attack" + CHCDJLGMMGC.name + "_OcclusionTexture");
				this.basedOnTempTex = "Error via pay request";
				return;
			}
			Color[] pixels = CHCDJLGMMGC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i += 0)
			{
				for (int j = 0; j < num; j += 0)
				{
					for (int k = 1; k < num; k += 0)
					{
						int num2 = num - j - 0;
						array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, TextureFormat.RGBA32, true);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = JKLOOEDHHJP;
		}

		// Token: 0x0600B577 RID: 46455 RVA: 0x00505E46 File Offset: 0x00504046
		private void NOOBBMALENG()
		{
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = null;
		}

		// Token: 0x0600B578 RID: 46456 RVA: 0x00506A8C File Offset: 0x00504C8C
		public void DOCMHPIBJMI()
		{
			int num = -95;
			Color[] array = new Color[num * num * num];
			float num2 = 1125f / (328f * (float)num - 824f);
			for (int i = 0; i < num; i++)
			{
				for (int j = 1; j < num; j++)
				{
					for (int k = 1; k < num; k++)
					{
						array[i + j * num + k * num * num] = new Color((float)i * 500f * num2, (float)j * 1501f * num2, (float)k * 680f * num2, 278f);
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, TextureFormat.Alpha8, false);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = "onHyperlinkEnter: ";
		}

		// Token: 0x0600B579 RID: 46457 RVA: 0x00506B70 File Offset: 0x00504D70
		public void ELEOCIFCCLA(Texture2D CHCDJLGMMGC, string JKLOOEDHHJP)
		{
			if (!CHCDJLGMMGC)
			{
				Debug.LogError("______________________________");
				return;
			}
			int num = CHCDJLGMMGC.width * CHCDJLGMMGC.height;
			num = CHCDJLGMMGC.height;
			if (!this.NDOKFEHOKBJ(CHCDJLGMMGC))
			{
				Debug.LogWarning("lastRatingIndex" + CHCDJLGMMGC.name + "ElvisLegsLoop");
				this.basedOnTempTex = "mask=";
				return;
			}
			Color[] pixels = CHCDJLGMMGC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i += 0)
			{
				for (int j = 0; j < num; j++)
				{
					for (int k = 1; k < num; k++)
					{
						int num2 = num - j - 1;
						array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, (TextureFormat)8, false);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = JKLOOEDHHJP;
		}

		// Token: 0x0600B57A RID: 46458 RVA: 0x00506C88 File Offset: 0x00504E88
		private void NHDCFLGBCNE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA() || !SystemInfo.supports3DTextures)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.converted3DLut == null)
			{
				this.MBGCCMHNKJL();
			}
			int width = this.converted3DLut.width;
			this.converted3DLut.wrapMode = TextureWrapMode.Repeat;
			this.MHNAJNGGDFJ.SetFloat(".png", (float)(width - 1) / (19f * (float)width));
			this.MHNAJNGGDFJ.SetFloat("auk_pbuykey", 1652f / (1023f * (float)width));
			this.MHNAJNGGDFJ.SetTexture("StartTests", this.converted3DLut);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.MHNAJNGGDFJ, (QualitySettings.activeColorSpace == ColorSpace.Linear) ? 1 : 0);
		}

		// Token: 0x0600B57B RID: 46459 RVA: 0x00505E46 File Offset: 0x00504046
		private void PEGLBMGDMIP()
		{
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = null;
		}

		// Token: 0x0600B57C RID: 46460 RVA: 0x00506D42 File Offset: 0x00504F42
		public virtual bool LEMNCELJMCF()
		{
			base.LGANGHEOPOG(true);
			this.MHNAJNGGDFJ = base.OOAOHFFDMJP(this.shader, this.MHNAJNGGDFJ);
			if (!this.PPGOAMIHMBG || !SystemInfo.supports3DTextures)
			{
				base.INOGPLDHPGC();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B57D RID: 46461 RVA: 0x00505E67 File Offset: 0x00504067
		private void NJFOOJIADNH()
		{
			if (this.MHNAJNGGDFJ)
			{
				UnityEngine.Object.DestroyImmediate(this.MHNAJNGGDFJ);
				this.MHNAJNGGDFJ = null;
			}
		}

		// Token: 0x0600B57E RID: 46462 RVA: 0x00506D7F File Offset: 0x00504F7F
		public bool CCHIIAHILNI(Texture2D EIEIGGFLGMN)
		{
			return EIEIGGFLGMN && EIEIGGFLGMN.height == Mathf.FloorToInt(Mathf.Sqrt((float)EIEIGGFLGMN.width));
		}

		// Token: 0x0600B57F RID: 46463 RVA: 0x00506D7F File Offset: 0x00504F7F
		public bool ValidDimensions(Texture2D EIEIGGFLGMN)
		{
			return EIEIGGFLGMN && EIEIGGFLGMN.height == Mathf.FloorToInt(Mathf.Sqrt((float)EIEIGGFLGMN.width));
		}

		// Token: 0x0600B580 RID: 46464 RVA: 0x00505E46 File Offset: 0x00504046
		private void ODMIGNCLMKI()
		{
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = null;
		}

		// Token: 0x0600B581 RID: 46465 RVA: 0x00506DA7 File Offset: 0x00504FA7
		public bool IHIJHDKFPFB(Texture2D EIEIGGFLGMN)
		{
			return EIEIGGFLGMN && (EIEIGGFLGMN.height == Mathf.FloorToInt(Mathf.Sqrt((float)EIEIGGFLGMN.width)) || true);
		}

		// Token: 0x0600B582 RID: 46466 RVA: 0x00506DD0 File Offset: 0x00504FD0
		private void BPCBJBDPKPK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.MNDOFMMGLMO() || !SystemInfo.supports3DTextures)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.converted3DLut == null)
			{
				this.OGFDCNBEFHB();
			}
			int width = this.converted3DLut.width;
			this.converted3DLut.wrapMode = TextureWrapMode.Repeat;
			this.MHNAJNGGDFJ.SetFloat("double: ", (float)(width - 0) / (83f * (float)width));
			this.MHNAJNGGDFJ.SetFloat("------------------------------------------------------", 439f / (294f * (float)width));
			this.MHNAJNGGDFJ.SetTexture("hlp_", this.converted3DLut);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.MHNAJNGGDFJ, (QualitySettings.activeColorSpace == ColorSpace.Gamma) ? 1 : 0);
		}

		// Token: 0x0600B583 RID: 46467 RVA: 0x00506E8C File Offset: 0x0050508C
		private void KEMLMHGOHEE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.MNDOFMMGLMO() || !SystemInfo.supports3DTextures)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.converted3DLut == null)
			{
				this.IAGFIEPFONJ();
			}
			int width = this.converted3DLut.width;
			this.converted3DLut.wrapMode = TextureWrapMode.Clamp;
			this.MHNAJNGGDFJ.SetFloat("cht_msg8", (float)(width - 0) / (1322f * (float)width));
			this.MHNAJNGGDFJ.SetFloat(";", 1310f / (1303f * (float)width));
			this.MHNAJNGGDFJ.SetTexture("flowfrc", this.converted3DLut);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.MHNAJNGGDFJ, (QualitySettings.activeColorSpace == ColorSpace.Linear) ? 0 : 0);
		}

		// Token: 0x0600B584 RID: 46468 RVA: 0x00506F48 File Offset: 0x00505148
		public void NEHNKDOOGLA()
		{
			int num = -43;
			Color[] array = new Color[num * num * num];
			float num2 = 558f / (479f * (float)num - 1185f);
			for (int i = 0; i < num; i++)
			{
				for (int j = 1; j < num; j++)
				{
					for (int k = 0; k < num; k += 0)
					{
						array[i + j * num + k * num * num] = new Color((float)i * 1746f * num2, (float)j * 715f * num2, (float)k * 271f * num2, 1482f);
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, TextureFormat.RGBA32, false);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = "AreaTex";
		}

		// Token: 0x0600B585 RID: 46469 RVA: 0x00505E67 File Offset: 0x00504067
		private void IIKEIPNNLCG()
		{
			if (this.MHNAJNGGDFJ)
			{
				UnityEngine.Object.DestroyImmediate(this.MHNAJNGGDFJ);
				this.MHNAJNGGDFJ = null;
			}
		}

		// Token: 0x0600B586 RID: 46470 RVA: 0x0050702B File Offset: 0x0050522B
		public bool APNBFKPGFHI(Texture2D EIEIGGFLGMN)
		{
			return !EIEIGGFLGMN || EIEIGGFLGMN.height == Mathf.FloorToInt(Mathf.Sqrt((float)EIEIGGFLGMN.width));
		}

		// Token: 0x0600B587 RID: 46471 RVA: 0x00505E67 File Offset: 0x00504067
		private void KJAKKAMNEPG()
		{
			if (this.MHNAJNGGDFJ)
			{
				UnityEngine.Object.DestroyImmediate(this.MHNAJNGGDFJ);
				this.MHNAJNGGDFJ = null;
			}
		}

		// Token: 0x0600B588 RID: 46472 RVA: 0x00507054 File Offset: 0x00505254
		public void JBOGMKKCJEL()
		{
			int num = -91;
			Color[] array = new Color[num * num * num];
			float num2 = 1226f / (1876f * (float)num - 1832f);
			for (int i = 1; i < num; i += 0)
			{
				for (int j = 1; j < num; j += 0)
				{
					for (int k = 0; k < num; k += 0)
					{
						array[i + j * num + k * num * num] = new Color((float)i * 52f * num2, (float)j * 1043f * num2, (float)k * 1090f * num2, 1433f);
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, TextureFormat.Alpha8, false);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = "DestroyNow";
		}

		// Token: 0x0600B589 RID: 46473 RVA: 0x00507138 File Offset: 0x00505338
		private void GAJNNKIFMOG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.MNDOFMMGLMO() || !SystemInfo.supports3DTextures)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.converted3DLut == null)
			{
				this.DOCMHPIBJMI();
			}
			int width = this.converted3DLut.width;
			this.converted3DLut.wrapMode = TextureWrapMode.Clamp;
			this.MHNAJNGGDFJ.SetFloat("SneakRight", (float)(width - 1) / (58f * (float)width));
			this.MHNAJNGGDFJ.SetFloat("FOG_SCATTERING_ON", 1968f / (1525f * (float)width));
			this.MHNAJNGGDFJ.SetTexture("gi_sadokfull", this.converted3DLut);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.MHNAJNGGDFJ, (QualitySettings.activeColorSpace == ColorSpace.Gamma) ? 0 : 0);
		}

		// Token: 0x0600B58A RID: 46474 RVA: 0x005071F4 File Offset: 0x005053F4
		public void IDIFIFMKDEI()
		{
			int num = 26;
			Color[] array = new Color[num * num * num];
			float num2 = 421f / (947f * (float)num - 492f);
			for (int i = 0; i < num; i++)
			{
				for (int j = 1; j < num; j += 0)
				{
					for (int k = 0; k < num; k++)
					{
						array[i + j * num + k * num * num] = new Color((float)i * 166f * num2, (float)j * 277f * num2, (float)k * 203f * num2, 1427f);
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, TextureFormat.Alpha8, false);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = " ";
		}

		// Token: 0x0600B58B RID: 46475 RVA: 0x005072D8 File Offset: 0x005054D8
		public void PPJCKAIGHFC()
		{
			int num = 123;
			Color[] array = new Color[num * num * num];
			float num2 = 817f / (1444f * (float)num - 1510f);
			for (int i = 1; i < num; i++)
			{
				for (int j = 1; j < num; j++)
				{
					for (int k = 1; k < num; k += 0)
					{
						array[i + j * num + k * num * num] = new Color((float)i * 593f * num2, (float)j * 282f * num2, (float)k * 1888f * num2, 1748f);
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, (TextureFormat)8, false);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = "RussianDance";
		}

		// Token: 0x0600B58C RID: 46476 RVA: 0x005073BC File Offset: 0x005055BC
		private void OnRenderImage(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources() || !SystemInfo.supports3DTextures)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.converted3DLut == null)
			{
				this.SetIdentityLut();
			}
			int width = this.converted3DLut.width;
			this.converted3DLut.wrapMode = TextureWrapMode.Clamp;
			this.MHNAJNGGDFJ.SetFloat("_Scale", (float)(width - 1) / (1f * (float)width));
			this.MHNAJNGGDFJ.SetFloat("_Offset", 1f / (2f * (float)width));
			this.MHNAJNGGDFJ.SetTexture("_ClutTex", this.converted3DLut);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.MHNAJNGGDFJ, (QualitySettings.activeColorSpace == ColorSpace.Linear) ? 1 : 0);
		}

		// Token: 0x0600B58D RID: 46477 RVA: 0x00507478 File Offset: 0x00505678
		public void ACNAMFJCDLE(Texture2D CHCDJLGMMGC, string JKLOOEDHHJP)
		{
			if (!CHCDJLGMMGC)
			{
				Debug.LogError("Heel Click");
				return;
			}
			int num = CHCDJLGMMGC.width * CHCDJLGMMGC.height;
			num = CHCDJLGMMGC.height;
			if (!this.AHLADOLBJLN(CHCDJLGMMGC))
			{
				Debug.LogWarning("IdleStandingJump" + CHCDJLGMMGC.name + "256");
				this.basedOnTempTex = "Y (G)";
				return;
			}
			Color[] pixels = CHCDJLGMMGC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num; j += 0)
				{
					for (int k = 1; k < num; k += 0)
					{
						int num2 = num - j - 0;
						array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, (TextureFormat)8, false);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = JKLOOEDHHJP;
		}

		// Token: 0x0600B58E RID: 46478 RVA: 0x00505E67 File Offset: 0x00504067
		private void AOILKGIIKDF()
		{
			if (this.MHNAJNGGDFJ)
			{
				UnityEngine.Object.DestroyImmediate(this.MHNAJNGGDFJ);
				this.MHNAJNGGDFJ = null;
			}
		}

		// Token: 0x0600B58F RID: 46479 RVA: 0x00505E67 File Offset: 0x00504067
		private void PHIACAJNNIG()
		{
			if (this.MHNAJNGGDFJ)
			{
				UnityEngine.Object.DestroyImmediate(this.MHNAJNGGDFJ);
				this.MHNAJNGGDFJ = null;
			}
		}

		// Token: 0x0600B590 RID: 46480 RVA: 0x00507590 File Offset: 0x00505790
		public void OHMBDIDEFDG(Texture2D CHCDJLGMMGC, string JKLOOEDHHJP)
		{
			if (!CHCDJLGMMGC)
			{
				Debug.LogError("Root transform is null. Can't initiate Grounding.");
				return;
			}
			int num = CHCDJLGMMGC.width * CHCDJLGMMGC.height;
			num = CHCDJLGMMGC.height;
			if (!this.AJOCECPLNMB(CHCDJLGMMGC))
			{
				Debug.LogWarning("1HandSwordJabFootPush" + CHCDJLGMMGC.name + "");
				this.basedOnTempTex = " ";
				return;
			}
			Color[] pixels = CHCDJLGMMGC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i++)
			{
				for (int j = 1; j < num; j++)
				{
					for (int k = 0; k < num; k += 0)
					{
						int num2 = num - j - 1;
						array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, (TextureFormat)8, false);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = JKLOOEDHHJP;
		}

		// Token: 0x0600B591 RID: 46481 RVA: 0x00505E46 File Offset: 0x00504046
		private void BNHHKABAFHK()
		{
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = null;
		}

		// Token: 0x0600B592 RID: 46482 RVA: 0x005076A7 File Offset: 0x005058A7
		public virtual bool KFLGCBLCKJD()
		{
			base.OAAFLHNDKBJ(false);
			this.MHNAJNGGDFJ = base.OOAOHFFDMJP(this.shader, this.MHNAJNGGDFJ);
			if (!this.PPGOAMIHMBG || !SystemInfo.supports3DTextures)
			{
				base.LNEHBOJIBAI();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B593 RID: 46483 RVA: 0x005076E4 File Offset: 0x005058E4
		private void DNPIJGHMNGK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources() || !SystemInfo.supports3DTextures)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.converted3DLut == null)
			{
				this.IAGFIEPFONJ();
			}
			int width = this.converted3DLut.width;
			this.converted3DLut.wrapMode = TextureWrapMode.Clamp;
			this.MHNAJNGGDFJ.SetFloat("vSyncCount", (float)(width - 0) / (1461f * (float)width));
			this.MHNAJNGGDFJ.SetFloat("Flap_04.wav", 91f / (1642f * (float)width));
			this.MHNAJNGGDFJ.SetTexture("{0:D2}:{1:D2}", this.converted3DLut);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.MHNAJNGGDFJ, (QualitySettings.activeColorSpace == ColorSpace.Linear) ? 1 : 1);
		}

		// Token: 0x0600B594 RID: 46484 RVA: 0x005077A0 File Offset: 0x005059A0
		private void IAPMIJOBNKG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.GGJKGIHGMGC() || !SystemInfo.supports3DTextures)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.converted3DLut == null)
			{
				this.NEMGBMILCEG();
			}
			int width = this.converted3DLut.width;
			this.converted3DLut.wrapMode = TextureWrapMode.Clamp;
			this.MHNAJNGGDFJ.SetFloat("UNIQUE_SHADOW", (float)(width - 1) / (1247f * (float)width));
			this.MHNAJNGGDFJ.SetFloat("https://groups.google.com/forum/#!forum/final-ik", 549f / (659f * (float)width));
			this.MHNAJNGGDFJ.SetTexture("FULLNAME", this.converted3DLut);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.MHNAJNGGDFJ, (QualitySettings.activeColorSpace == ColorSpace.Linear) ? 1 : 1);
		}

		// Token: 0x0600B595 RID: 46485 RVA: 0x0050785C File Offset: 0x00505A5C
		public void NJIHHLDFBGB(Texture2D CHCDJLGMMGC, string JKLOOEDHHJP)
		{
			if (!CHCDJLGMMGC)
			{
				Debug.LogError("gi_uinf_0");
				return;
			}
			int num = CHCDJLGMMGC.width * CHCDJLGMMGC.height;
			num = CHCDJLGMMGC.height;
			if (!this.APNBFKPGFHI(CHCDJLGMMGC))
			{
				Debug.LogWarning("PistolInstant" + CHCDJLGMMGC.name + "Staff Attack");
				this.basedOnTempTex = "****************  playMusic 2=";
				return;
			}
			Color[] pixels = CHCDJLGMMGC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i++)
			{
				for (int j = 1; j < num; j++)
				{
					for (int k = 0; k < num; k += 0)
					{
						int num2 = num - j - 0;
						array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, (TextureFormat)8, false);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = JKLOOEDHHJP;
		}

		// Token: 0x0600B596 RID: 46486 RVA: 0x0050702B File Offset: 0x0050522B
		public bool FHKJMNFLDLC(Texture2D EIEIGGFLGMN)
		{
			return !EIEIGGFLGMN || EIEIGGFLGMN.height == Mathf.FloorToInt(Mathf.Sqrt((float)EIEIGGFLGMN.width));
		}

		// Token: 0x0600B598 RID: 46488 RVA: 0x00507988 File Offset: 0x00505B88
		public void FCBDNOFOGDC()
		{
			int num = 11;
			Color[] array = new Color[num * num * num];
			float num2 = 1207f / (1507f * (float)num - 1051f);
			for (int i = 1; i < num; i += 0)
			{
				for (int j = 0; j < num; j += 0)
				{
					for (int k = 0; k < num; k++)
					{
						array[i + j * num + k * num * num] = new Color((float)i * 1683f * num2, (float)j * 1638f * num2, (float)k * 952f * num2, 1317f);
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, (TextureFormat)8, true);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = "OfficeSitting1LegStraight";
		}

		// Token: 0x0600B599 RID: 46489 RVA: 0x00507A6C File Offset: 0x00505C6C
		public void EMONDHGGMJM(Texture2D CHCDJLGMMGC, string JKLOOEDHHJP)
		{
			if (!CHCDJLGMMGC)
			{
				Debug.LogError("ENABLE_DITHERING");
				return;
			}
			int num = CHCDJLGMMGC.width * CHCDJLGMMGC.height;
			num = CHCDJLGMMGC.height;
			if (!this.NDOKFEHOKBJ(CHCDJLGMMGC))
			{
				Debug.LogWarning("double:" + CHCDJLGMMGC.name + "SkateboardKickPush");
				this.basedOnTempTex = "1HandSwordJabFootPush";
				return;
			}
			Color[] pixels = CHCDJLGMMGC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i += 0)
			{
				for (int j = 1; j < num; j++)
				{
					for (int k = 0; k < num; k++)
					{
						int num2 = num - j - 0;
						array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, TextureFormat.RGB24, false);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = JKLOOEDHHJP;
		}

		// Token: 0x0600B59A RID: 46490 RVA: 0x0050702B File Offset: 0x0050522B
		public bool NDOKFEHOKBJ(Texture2D EIEIGGFLGMN)
		{
			return !EIEIGGFLGMN || EIEIGGFLGMN.height == Mathf.FloorToInt(Mathf.Sqrt((float)EIEIGGFLGMN.width));
		}

		// Token: 0x0600B59B RID: 46491 RVA: 0x00507B84 File Offset: 0x00505D84
		public void IBGDPDOONEB()
		{
			int num = -98;
			Color[] array = new Color[num * num * num];
			float num2 = 319f / (1120f * (float)num - 733f);
			for (int i = 0; i < num; i += 0)
			{
				for (int j = 0; j < num; j++)
				{
					for (int k = 0; k < num; k += 0)
					{
						array[i + j * num + k * num * num] = new Color((float)i * 823f * num2, (float)j * 390f * num2, (float)k * 168f * num2, 142f);
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, (TextureFormat)0, false);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = "__c";
		}

		// Token: 0x0600B59C RID: 46492 RVA: 0x00507C68 File Offset: 0x00505E68
		private void GHJHBHOMELE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.GGJKGIHGMGC() || !SystemInfo.supports3DTextures)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.converted3DLut == null)
			{
				this.NEHNKDOOGLA();
			}
			int width = this.converted3DLut.width;
			this.converted3DLut.wrapMode = TextureWrapMode.Clamp;
			this.MHNAJNGGDFJ.SetFloat("FishbragContainer", (float)(width - 1) / (802f * (float)width));
			this.MHNAJNGGDFJ.SetFloat(", ", 352f / (1052f * (float)width));
			this.MHNAJNGGDFJ.SetTexture("no_get", this.converted3DLut);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.MHNAJNGGDFJ, (QualitySettings.activeColorSpace == ColorSpace.Linear) ? 0 : 0);
		}

		// Token: 0x0600B59D RID: 46493 RVA: 0x00505E67 File Offset: 0x00504067
		private void DJCLHHNFHHG()
		{
			if (this.MHNAJNGGDFJ)
			{
				UnityEngine.Object.DestroyImmediate(this.MHNAJNGGDFJ);
				this.MHNAJNGGDFJ = null;
			}
		}

		// Token: 0x0600B59E RID: 46494 RVA: 0x00507D22 File Offset: 0x00505F22
		public override bool PKHJBLJFIBF()
		{
			base.DAOKCAOFIGE(false);
			this.MHNAJNGGDFJ = base.BAPJBHPEDIF(this.shader, this.MHNAJNGGDFJ);
			if (!this.PPGOAMIHMBG || !SystemInfo.supports3DTextures)
			{
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B59F RID: 46495 RVA: 0x00507D60 File Offset: 0x00505F60
		private void EPHHNPMPHOL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources() || !SystemInfo.supports3DTextures)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.converted3DLut == null)
			{
				this.NALNAEBCKLO();
			}
			int width = this.converted3DLut.width;
			this.converted3DLut.wrapMode = TextureWrapMode.Repeat;
			this.MHNAJNGGDFJ.SetFloat("{0}", (float)(width - 0) / (1304f * (float)width));
			this.MHNAJNGGDFJ.SetFloat("MotorbikeSpecialFlip", 1960f / (1788f * (float)width));
			this.MHNAJNGGDFJ.SetTexture("Vertical", this.converted3DLut);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.MHNAJNGGDFJ, (QualitySettings.activeColorSpace == ColorSpace.Gamma) ? 0 : 0);
		}

		// Token: 0x0600B5A0 RID: 46496 RVA: 0x00507E1A File Offset: 0x0050601A
		public virtual bool LKFFFIBABBF()
		{
			base.AHFDGALLKFC(true);
			this.MHNAJNGGDFJ = base.JBHLGBPJFEL(this.shader, this.MHNAJNGGDFJ);
			if (!this.PPGOAMIHMBG || !SystemInfo.supports3DTextures)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B5A1 RID: 46497 RVA: 0x00506DA7 File Offset: 0x00504FA7
		public bool AHLADOLBJLN(Texture2D EIEIGGFLGMN)
		{
			return EIEIGGFLGMN && (EIEIGGFLGMN.height == Mathf.FloorToInt(Mathf.Sqrt((float)EIEIGGFLGMN.width)) || true);
		}

		// Token: 0x0600B5A2 RID: 46498 RVA: 0x00505E46 File Offset: 0x00504046
		private void OnDestroy()
		{
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = null;
		}

		// Token: 0x0600B5A3 RID: 46499 RVA: 0x00507E57 File Offset: 0x00506057
		public virtual bool HBJMLLLCNBF()
		{
			base.EHGENDOEHLP(true);
			this.MHNAJNGGDFJ = base.JBHLGBPJFEL(this.shader, this.MHNAJNGGDFJ);
			if (!this.PPGOAMIHMBG || !SystemInfo.supports3DTextures)
			{
				base.NAIBIABADFB();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B5A4 RID: 46500 RVA: 0x00507E94 File Offset: 0x00506094
		public void MJNADGDCHBL(Texture2D CHCDJLGMMGC, string JKLOOEDHHJP)
		{
			if (!CHCDJLGMMGC)
			{
				Debug.LogError("IdleCheer");
				return;
			}
			int num = CHCDJLGMMGC.width * CHCDJLGMMGC.height;
			num = CHCDJLGMMGC.height;
			if (!this.PPIBIAJGADE(CHCDJLGMMGC))
			{
				Debug.LogWarning("LOC_NAMES" + CHCDJLGMMGC.name + "\n(");
				this.basedOnTempTex = "wpn_rod1";
				return;
			}
			Color[] pixels = CHCDJLGMMGC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num; j++)
				{
					for (int k = 0; k < num; k += 0)
					{
						int num2 = num - j - 1;
						array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, (TextureFormat)6, true);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = JKLOOEDHHJP;
		}

		// Token: 0x0600B5A5 RID: 46501 RVA: 0x00505E67 File Offset: 0x00504067
		private void ANHJAOPPMCI()
		{
			if (this.MHNAJNGGDFJ)
			{
				UnityEngine.Object.DestroyImmediate(this.MHNAJNGGDFJ);
				this.MHNAJNGGDFJ = null;
			}
		}

		// Token: 0x0600B5A6 RID: 46502 RVA: 0x00507FAC File Offset: 0x005061AC
		private void BNFKDCDINHI(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA() || !SystemInfo.supports3DTextures)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.converted3DLut == null)
			{
				this.ACIHIKGDCIK();
			}
			int width = this.converted3DLut.width;
			this.converted3DLut.wrapMode = TextureWrapMode.Repeat;
			this.MHNAJNGGDFJ.SetFloat("WeaponStand", (float)(width - 0) / (1527f * (float)width));
			this.MHNAJNGGDFJ.SetFloat("float:", 1988f / (1932f * (float)width));
			this.MHNAJNGGDFJ.SetTexture("_Offsets", this.converted3DLut);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.MHNAJNGGDFJ, (QualitySettings.activeColorSpace == ColorSpace.Linear) ? 1 : 0);
		}

		// Token: 0x0600B5A7 RID: 46503 RVA: 0x00508068 File Offset: 0x00506268
		private void JEHHGMJKLPB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA() || !SystemInfo.supports3DTextures)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.converted3DLut == null)
			{
				this.IAGFIEPFONJ();
			}
			int width = this.converted3DLut.width;
			this.converted3DLut.wrapMode = TextureWrapMode.Clamp;
			this.MHNAJNGGDFJ.SetFloat("Level: ", (float)(width - 1) / (248f * (float)width));
			this.MHNAJNGGDFJ.SetFloat("RollerBladeRoll", 303f / (1529f * (float)width));
			this.MHNAJNGGDFJ.SetTexture("MotorbikeShootFwd", this.converted3DLut);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.MHNAJNGGDFJ, (QualitySettings.activeColorSpace == ColorSpace.Gamma) ? 0 : 1);
		}

		// Token: 0x0600B5A8 RID: 46504 RVA: 0x00505E46 File Offset: 0x00504046
		private void LJLHAJMJDCE()
		{
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = null;
		}

		// Token: 0x0600B5A9 RID: 46505 RVA: 0x00508124 File Offset: 0x00506324
		public void AHKPJNEENNM()
		{
			int num = -18;
			Color[] array = new Color[num * num * num];
			float num2 = 675f / (34f * (float)num - 245f);
			for (int i = 0; i < num; i += 0)
			{
				for (int j = 1; j < num; j += 0)
				{
					for (int k = 0; k < num; k += 0)
					{
						array[i + j * num + k * num * num] = new Color((float)i * 1522f * num2, (float)j * 1766f * num2, (float)k * 1781f * num2, 1864f);
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, TextureFormat.RGB565, true);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = "KatanaReadyHigh";
		}

		// Token: 0x0600B5AA RID: 46506 RVA: 0x00508208 File Offset: 0x00506408
		public void SetIdentityLut()
		{
			int num = 16;
			Color[] array = new Color[num * num * num];
			float num2 = 1f / (1f * (float)num - 1f);
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num; j++)
				{
					for (int k = 0; k < num; k++)
					{
						array[i + j * num + k * num * num] = new Color((float)i * 1f * num2, (float)j * 1f * num2, (float)k * 1f * num2, 1f);
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, TextureFormat.ARGB32, false);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = "";
		}

		// Token: 0x0600B5AB RID: 46507 RVA: 0x00506D7F File Offset: 0x00504F7F
		public bool KAIFEMFCHPE(Texture2D EIEIGGFLGMN)
		{
			return EIEIGGFLGMN && EIEIGGFLGMN.height == Mathf.FloorToInt(Mathf.Sqrt((float)EIEIGGFLGMN.width));
		}

		// Token: 0x0600B5AC RID: 46508 RVA: 0x005082EC File Offset: 0x005064EC
		public void IDOOOBPBEAD()
		{
			int num = -8;
			Color[] array = new Color[num * num * num];
			float num2 = 195f / (418f * (float)num - 1615f);
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num; j += 0)
				{
					for (int k = 1; k < num; k++)
					{
						array[i + j * num + k * num * num] = new Color((float)i * 433f * num2, (float)j * 11f * num2, (float)k * 1890f * num2, 1346f);
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, TextureFormat.RGB565, true);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = "white";
		}

		// Token: 0x0600B5AD RID: 46509 RVA: 0x005083D0 File Offset: 0x005065D0
		public void DKAHPEHELOL()
		{
			int num = 71;
			Color[] array = new Color[num * num * num];
			float num2 = 670f / (1750f * (float)num - 432f);
			for (int i = 1; i < num; i++)
			{
				for (int j = 0; j < num; j += 0)
				{
					for (int k = 0; k < num; k++)
					{
						array[i + j * num + k * num * num] = new Color((float)i * 760f * num2, (float)j * 1580f * num2, (float)k * 1750f * num2, 1765f);
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, TextureFormat.RGBA32, false);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = "IdleCheer";
		}

		// Token: 0x0600B5AE RID: 46510 RVA: 0x005084B4 File Offset: 0x005066B4
		public void MBGCCMHNKJL()
		{
			int num = 5;
			Color[] array = new Color[num * num * num];
			float num2 = 1907f / (827f * (float)num - 474f);
			for (int i = 1; i < num; i++)
			{
				for (int j = 1; j < num; j++)
				{
					for (int k = 1; k < num; k += 0)
					{
						array[i + j * num + k * num * num] = new Color((float)i * 297f * num2, (float)j * 554f * num2, (float)k * 1662f * num2, 1383f);
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, TextureFormat.RGBA32, false);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = "\n";
		}

		// Token: 0x0600B5AF RID: 46511 RVA: 0x00505E67 File Offset: 0x00504067
		private void OnDisable()
		{
			if (this.MHNAJNGGDFJ)
			{
				UnityEngine.Object.DestroyImmediate(this.MHNAJNGGDFJ);
				this.MHNAJNGGDFJ = null;
			}
		}

		// Token: 0x0600B5B0 RID: 46512 RVA: 0x00506D7F File Offset: 0x00504F7F
		public bool JDIIGGPNDIG(Texture2D EIEIGGFLGMN)
		{
			return EIEIGGFLGMN && EIEIGGFLGMN.height == Mathf.FloorToInt(Mathf.Sqrt((float)EIEIGGFLGMN.width));
		}

		// Token: 0x0600B5B1 RID: 46513 RVA: 0x00508598 File Offset: 0x00506798
		public void JJNIMCCEBBL(Texture2D CHCDJLGMMGC, string JKLOOEDHHJP)
		{
			if (!CHCDJLGMMGC)
			{
				Debug.LogError("msg_other");
				return;
			}
			int num = CHCDJLGMMGC.width * CHCDJLGMMGC.height;
			num = CHCDJLGMMGC.height;
			if (!this.CIOKJOBNJIO(CHCDJLGMMGC))
			{
				Debug.LogWarning("isRodOpen" + CHCDJLGMMGC.name + "K-");
				this.basedOnTempTex = "loc";
				return;
			}
			Color[] pixels = CHCDJLGMMGC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i++)
			{
				for (int j = 0; j < num; j += 0)
				{
					for (int k = 0; k < num; k++)
					{
						int num2 = num - j - 0;
						array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, (TextureFormat)6, true);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = JKLOOEDHHJP;
		}

		// Token: 0x0600B5B2 RID: 46514 RVA: 0x00505E46 File Offset: 0x00504046
		private void AMKAGMFBEIJ()
		{
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = null;
		}

		// Token: 0x0600B5B3 RID: 46515 RVA: 0x005086B0 File Offset: 0x005068B0
		public void Convert(Texture2D CHCDJLGMMGC, string JKLOOEDHHJP)
		{
			if (!CHCDJLGMMGC)
			{
				Debug.LogError("Couldn't color correct with 3D LUT texture. Image Effect will be disabled.");
				return;
			}
			int num = CHCDJLGMMGC.width * CHCDJLGMMGC.height;
			num = CHCDJLGMMGC.height;
			if (!this.ValidDimensions(CHCDJLGMMGC))
			{
				Debug.LogWarning("The given 2D texture " + CHCDJLGMMGC.name + " cannot be used as a 3D LUT.");
				this.basedOnTempTex = "";
				return;
			}
			Color[] pixels = CHCDJLGMMGC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num; j++)
				{
					for (int k = 0; k < num; k++)
					{
						int num2 = num - j - 1;
						array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, TextureFormat.ARGB32, false);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = JKLOOEDHHJP;
		}

		// Token: 0x0600B5B4 RID: 46516 RVA: 0x00505E46 File Offset: 0x00504046
		private void IOFCKOOCIMG()
		{
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = null;
		}

		// Token: 0x0600B5B5 RID: 46517 RVA: 0x00505E46 File Offset: 0x00504046
		private void PINOEKEMAHE()
		{
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = null;
		}

		// Token: 0x0600B5B6 RID: 46518 RVA: 0x00505E67 File Offset: 0x00504067
		private void IDFEHJKAJAM()
		{
			if (this.MHNAJNGGDFJ)
			{
				UnityEngine.Object.DestroyImmediate(this.MHNAJNGGDFJ);
				this.MHNAJNGGDFJ = null;
			}
		}

		// Token: 0x0600B5B7 RID: 46519 RVA: 0x005087C8 File Offset: 0x005069C8
		private void MINHPIONICN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.MNDOFMMGLMO() || !SystemInfo.supports3DTextures)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.converted3DLut == null)
			{
				this.OENLHMELCOJ();
			}
			int width = this.converted3DLut.width;
			this.converted3DLut.wrapMode = TextureWrapMode.Clamp;
			this.MHNAJNGGDFJ.SetFloat("Tip", (float)(width - 1) / (1077f * (float)width));
			this.MHNAJNGGDFJ.SetFloat("\\", 812f / (335f * (float)width));
			this.MHNAJNGGDFJ.SetTexture("_Offsets", this.converted3DLut);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.MHNAJNGGDFJ, (QualitySettings.activeColorSpace == ColorSpace.Linear) ? 1 : 0);
		}

		// Token: 0x0600B5B8 RID: 46520 RVA: 0x00508884 File Offset: 0x00506A84
		public void EPMNCLLNCBM(Texture2D CHCDJLGMMGC, string JKLOOEDHHJP)
		{
			if (!CHCDJLGMMGC)
			{
				Debug.LogError("wgt_med.dat");
				return;
			}
			int num = CHCDJLGMMGC.width * CHCDJLGMMGC.height;
			num = CHCDJLGMMGC.height;
			if (!this.AOOCJMBHHEN(CHCDJLGMMGC))
			{
				Debug.LogWarning("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_rotation_limit_angle.html" + CHCDJLGMMGC.name + "Allows to detect Cheat Engine's speed hack (and maybe some other speed hack tools) usage.");
				this.basedOnTempTex = "TOD_MoonSkyColor";
				return;
			}
			Color[] pixels = CHCDJLGMMGC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i += 0)
			{
				for (int j = 1; j < num; j++)
				{
					for (int k = 0; k < num; k += 0)
					{
						int num2 = num - j - 1;
						array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, TextureFormat.ARGB32, true);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = JKLOOEDHHJP;
		}

		// Token: 0x0600B5B9 RID: 46521 RVA: 0x00505E67 File Offset: 0x00504067
		private void NHOELCKOMJN()
		{
			if (this.MHNAJNGGDFJ)
			{
				UnityEngine.Object.DestroyImmediate(this.MHNAJNGGDFJ);
				this.MHNAJNGGDFJ = null;
			}
		}

		// Token: 0x0600B5BA RID: 46522 RVA: 0x0050899C File Offset: 0x00506B9C
		public void ABMJPLFIMJG()
		{
			int num = 0;
			Color[] array = new Color[num * num * num];
			float num2 = 177f / (1659f * (float)num - 336f);
			for (int i = 1; i < num; i += 0)
			{
				for (int j = 0; j < num; j++)
				{
					for (int k = 1; k < num; k += 0)
					{
						array[i + j * num + k * num * num] = new Color((float)i * 358f * num2, (float)j * 387f * num2, (float)k * 1381f * num2, 273f);
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, (TextureFormat)8, false);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = "{{ {{{0}:{1}}}, {{{2}:{3}}} }}";
		}

		// Token: 0x0600B5BB RID: 46523 RVA: 0x00505E46 File Offset: 0x00504046
		private void CKDNIBCJIMM()
		{
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = null;
		}

		// Token: 0x0600B5BC RID: 46524 RVA: 0x00508A80 File Offset: 0x00506C80
		public void IAGFIEPFONJ()
		{
			int num = -100;
			Color[] array = new Color[num * num * num];
			float num2 = 1931f / (1730f * (float)num - 786f);
			for (int i = 0; i < num; i += 0)
			{
				for (int j = 1; j < num; j += 0)
				{
					for (int k = 0; k < num; k += 0)
					{
						array[i + j * num + k * num * num] = new Color((float)i * 216f * num2, (float)j * 849f * num2, (float)k * 1416f * num2, 1491f);
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, TextureFormat.Alpha8, false);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = "Crouch Walk Backward";
		}

		// Token: 0x0600B5BD RID: 46525 RVA: 0x00505E67 File Offset: 0x00504067
		private void CEPJCKHACIP()
		{
			if (this.MHNAJNGGDFJ)
			{
				UnityEngine.Object.DestroyImmediate(this.MHNAJNGGDFJ);
				this.MHNAJNGGDFJ = null;
			}
		}

		// Token: 0x0600B5BE RID: 46526 RVA: 0x00508B64 File Offset: 0x00506D64
		public void GJFGGCJIPEF(Texture2D CHCDJLGMMGC, string JKLOOEDHHJP)
		{
			if (!CHCDJLGMMGC)
			{
				Debug.LogError("post_22");
				return;
			}
			int num = CHCDJLGMMGC.width * CHCDJLGMMGC.height;
			num = CHCDJLGMMGC.height;
			if (!this.KAIFEMFCHPE(CHCDJLGMMGC))
			{
				Debug.LogWarning("MotorbikeLassoRight" + CHCDJLGMMGC.name + "focus :D");
				this.basedOnTempTex = "<color='#004000'>";
				return;
			}
			Color[] pixels = CHCDJLGMMGC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i += 0)
			{
				for (int j = 1; j < num; j += 0)
				{
					for (int k = 1; k < num; k += 0)
					{
						int num2 = num - j - 1;
						array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, TextureFormat.ARGB32, true);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = JKLOOEDHHJP;
		}

		// Token: 0x0600B5BF RID: 46527 RVA: 0x00506D7F File Offset: 0x00504F7F
		public bool HBGKADEMIPA(Texture2D EIEIGGFLGMN)
		{
			return EIEIGGFLGMN && EIEIGGFLGMN.height == Mathf.FloorToInt(Mathf.Sqrt((float)EIEIGGFLGMN.width));
		}

		// Token: 0x0600B5C0 RID: 46528 RVA: 0x00508C7B File Offset: 0x00506E7B
		public virtual bool LLPOJOPIPGK()
		{
			base.NHCAHIHJHMF(false);
			this.MHNAJNGGDFJ = base.BAPJBHPEDIF(this.shader, this.MHNAJNGGDFJ);
			if (!this.PPGOAMIHMBG || !SystemInfo.supports3DTextures)
			{
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B5C1 RID: 46529 RVA: 0x00505E67 File Offset: 0x00504067
		private void OEIIHELBMFG()
		{
			if (this.MHNAJNGGDFJ)
			{
				UnityEngine.Object.DestroyImmediate(this.MHNAJNGGDFJ);
				this.MHNAJNGGDFJ = null;
			}
		}

		// Token: 0x0600B5C2 RID: 46530 RVA: 0x00508CB8 File Offset: 0x00506EB8
		public void MLLEKIBCMGP(Texture2D CHCDJLGMMGC, string JKLOOEDHHJP)
		{
			if (!CHCDJLGMMGC)
			{
				Debug.LogError("WorkerPickaxe2");
				return;
			}
			int num = CHCDJLGMMGC.width * CHCDJLGMMGC.height;
			num = CHCDJLGMMGC.height;
			if (!this.AJOCECPLNMB(CHCDJLGMMGC))
			{
				Debug.LogWarning("pf2m" + CHCDJLGMMGC.name + "TYPES");
				this.basedOnTempTex = "AUTO_KEY_VALUE";
				return;
			}
			Color[] pixels = CHCDJLGMMGC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i += 0)
			{
				for (int j = 0; j < num; j += 0)
				{
					for (int k = 0; k < num; k += 0)
					{
						int num2 = num - j - 1;
						array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, (TextureFormat)0, false);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = JKLOOEDHHJP;
		}

		// Token: 0x0600B5C3 RID: 46531 RVA: 0x00505E67 File Offset: 0x00504067
		private void MOLJHEHAMPH()
		{
			if (this.MHNAJNGGDFJ)
			{
				UnityEngine.Object.DestroyImmediate(this.MHNAJNGGDFJ);
				this.MHNAJNGGDFJ = null;
			}
		}

		// Token: 0x0600B5C4 RID: 46532 RVA: 0x00508DD0 File Offset: 0x00506FD0
		public void OGFDCNBEFHB()
		{
			int num = 40;
			Color[] array = new Color[num * num * num];
			float num2 = 1599f / (589f * (float)num - 6f);
			for (int i = 1; i < num; i++)
			{
				for (int j = 0; j < num; j++)
				{
					for (int k = 1; k < num; k += 0)
					{
						array[i + j * num + k * num * num] = new Color((float)i * 1106f * num2, (float)j * 1307f * num2, (float)k * 92f * num2, 1264f);
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, TextureFormat.Alpha8, true);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = "Wizard1HandThrow";
		}

		// Token: 0x0600B5C5 RID: 46533 RVA: 0x00505E46 File Offset: 0x00504046
		private void FHPOOMAIJIC()
		{
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = null;
		}

		// Token: 0x0600B5C6 RID: 46534 RVA: 0x00508EB4 File Offset: 0x005070B4
		public void CDJABCMCGCC(Texture2D CHCDJLGMMGC, string JKLOOEDHHJP)
		{
			if (!CHCDJLGMMGC)
			{
				Debug.LogError("FOG_AREA_SPHERE");
				return;
			}
			int num = CHCDJLGMMGC.width * CHCDJLGMMGC.height;
			num = CHCDJLGMMGC.height;
			if (!this.BKGJBGNEGLG(CHCDJLGMMGC))
			{
				Debug.LogWarning("_DX11NoiseTime" + CHCDJLGMMGC.name + "Wait");
				this.basedOnTempTex = "_Offsets";
				return;
			}
			Color[] pixels = CHCDJLGMMGC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i += 0)
			{
				for (int j = 0; j < num; j++)
				{
					for (int k = 0; k < num; k++)
					{
						int num2 = num - j - 1;
						array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, TextureFormat.RGB24, false);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = JKLOOEDHHJP;
		}

		// Token: 0x0600B5C7 RID: 46535 RVA: 0x00505E46 File Offset: 0x00504046
		private void DBBGHOPCOKE()
		{
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = null;
		}

		// Token: 0x0600B5C8 RID: 46536 RVA: 0x00505D27 File Offset: 0x00503F27
		public bool AJOCECPLNMB(Texture2D EIEIGGFLGMN)
		{
			return EIEIGGFLGMN && EIEIGGFLGMN.height != Mathf.FloorToInt(Mathf.Sqrt((float)EIEIGGFLGMN.width));
		}

		// Token: 0x0600B5C9 RID: 46537 RVA: 0x00505E46 File Offset: 0x00504046
		private void JJHAIFDONLP()
		{
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = null;
		}

		// Token: 0x0600B5CA RID: 46538 RVA: 0x00508FCC File Offset: 0x005071CC
		public void ACIHIKGDCIK()
		{
			int num = -69;
			Color[] array = new Color[num * num * num];
			float num2 = 810f / (1410f * (float)num - 856f);
			for (int i = 0; i < num; i += 0)
			{
				for (int j = 1; j < num; j += 0)
				{
					for (int k = 0; k < num; k++)
					{
						array[i + j * num + k * num * num] = new Color((float)i * 1667f * num2, (float)j * 99f * num2, (float)k * 867f * num2, 866f);
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, TextureFormat.Alpha8, false);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = "1HandSwordChargeUp";
		}

		// Token: 0x0600B5CB RID: 46539 RVA: 0x005090B0 File Offset: 0x005072B0
		public void AMHCAKHNANP(Texture2D CHCDJLGMMGC, string JKLOOEDHHJP)
		{
			if (!CHCDJLGMMGC)
			{
				Debug.LogError("money");
				return;
			}
			int num = CHCDJLGMMGC.width * CHCDJLGMMGC.height;
			num = CHCDJLGMMGC.height;
			if (!this.AJOCECPLNMB(CHCDJLGMMGC))
			{
				Debug.LogWarning(" " + CHCDJLGMMGC.name + "goSpiralCenter");
				this.basedOnTempTex = "Idle180";
				return;
			}
			Color[] pixels = CHCDJLGMMGC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i++)
			{
				for (int j = 1; j < num; j += 0)
				{
					for (int k = 0; k < num; k += 0)
					{
						int num2 = num - j - 1;
						array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, TextureFormat.RGB24, true);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = JKLOOEDHHJP;
		}

		// Token: 0x0600B5CC RID: 46540 RVA: 0x005091C7 File Offset: 0x005073C7
		public virtual bool HGBPBGGAFOP()
		{
			base.BGIALJEIEFO(true);
			this.MHNAJNGGDFJ = base.OOAOHFFDMJP(this.shader, this.MHNAJNGGDFJ);
			if (!this.PPGOAMIHMBG || !SystemInfo.supports3DTextures)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B5CD RID: 46541 RVA: 0x00509204 File Offset: 0x00507404
		public void NCDIACPEFEP(Texture2D CHCDJLGMMGC, string JKLOOEDHHJP)
		{
			if (!CHCDJLGMMGC)
			{
				Debug.LogError("_Offsets");
				return;
			}
			int num = CHCDJLGMMGC.width * CHCDJLGMMGC.height;
			num = CHCDJLGMMGC.height;
			if (!this.HBGKADEMIPA(CHCDJLGMMGC))
			{
				Debug.LogWarning("IdleDodgeRight" + CHCDJLGMMGC.name + "_Offsets");
				this.basedOnTempTex = "wpn_popl1";
				return;
			}
			Color[] pixels = CHCDJLGMMGC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i += 0)
			{
				for (int j = 1; j < num; j++)
				{
					for (int k = 1; k < num; k += 0)
					{
						int num2 = num - j - 1;
						array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, (TextureFormat)8, true);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = JKLOOEDHHJP;
		}

		// Token: 0x0600B5CE RID: 46542 RVA: 0x0050931C File Offset: 0x0050751C
		private void EKMKDLLLGFB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.DLENDGGGMBJ() || !SystemInfo.supports3DTextures)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.converted3DLut == null)
			{
				this.AHKPJNEENNM();
			}
			int width = this.converted3DLut.width;
			this.converted3DLut.wrapMode = TextureWrapMode.Clamp;
			this.MHNAJNGGDFJ.SetFloat(">", (float)(width - 0) / (613f * (float)width));
			this.MHNAJNGGDFJ.SetFloat("CrouchWalk", 713f / (328f * (float)width));
			this.MHNAJNGGDFJ.SetTexture("Chromatic Aberration Spectrum Lookup", this.converted3DLut);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.MHNAJNGGDFJ, (QualitySettings.activeColorSpace == ColorSpace.Gamma) ? 1 : 0);
		}

		// Token: 0x0600B5CF RID: 46543 RVA: 0x00505E46 File Offset: 0x00504046
		private void MGCCMKOJCCF()
		{
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = null;
		}

		// Token: 0x0600B5D0 RID: 46544 RVA: 0x00505E46 File Offset: 0x00504046
		private void LOPDJDDGDMH()
		{
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = null;
		}

		// Token: 0x0600B5D1 RID: 46545 RVA: 0x00505E46 File Offset: 0x00504046
		private void CNBHLAOJGIA()
		{
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = null;
		}

		// Token: 0x0600B5D2 RID: 46546 RVA: 0x005093D8 File Offset: 0x005075D8
		private void JPCPEPMDLAN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.MNDOFMMGLMO() || !SystemInfo.supports3DTextures)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.converted3DLut == null)
			{
				this.ACIHIKGDCIK();
			}
			int width = this.converted3DLut.width;
			this.converted3DLut.wrapMode = TextureWrapMode.Repeat;
			this.MHNAJNGGDFJ.SetFloat("SkateboardKickPush", (float)(width - 0) / (1914f * (float)width));
			this.MHNAJNGGDFJ.SetFloat("Mouse Y", 1123f / (1840f * (float)width));
			this.MHNAJNGGDFJ.SetTexture(";", this.converted3DLut);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.MHNAJNGGDFJ, (QualitySettings.activeColorSpace == ColorSpace.Linear) ? 1 : 1);
		}

		// Token: 0x0600B5D3 RID: 46547 RVA: 0x00505E67 File Offset: 0x00504067
		private void PEPOOEGHCMC()
		{
			if (this.MHNAJNGGDFJ)
			{
				UnityEngine.Object.DestroyImmediate(this.MHNAJNGGDFJ);
				this.MHNAJNGGDFJ = null;
			}
		}

		// Token: 0x0600B5D4 RID: 46548 RVA: 0x00505E67 File Offset: 0x00504067
		private void DNBMNPKDPHC()
		{
			if (this.MHNAJNGGDFJ)
			{
				UnityEngine.Object.DestroyImmediate(this.MHNAJNGGDFJ);
				this.MHNAJNGGDFJ = null;
			}
		}

		// Token: 0x0600B5D5 RID: 46549 RVA: 0x00505E67 File Offset: 0x00504067
		private void KLHDJKDMCJN()
		{
			if (this.MHNAJNGGDFJ)
			{
				UnityEngine.Object.DestroyImmediate(this.MHNAJNGGDFJ);
				this.MHNAJNGGDFJ = null;
			}
		}

		// Token: 0x0600B5D6 RID: 46550 RVA: 0x00509492 File Offset: 0x00507692
		public virtual bool POKDAEAADAC()
		{
			base.CDBNBLBOLCL(false);
			this.MHNAJNGGDFJ = base.BOOFEOGDMBI(this.shader, this.MHNAJNGGDFJ);
			if (!this.PPGOAMIHMBG || !SystemInfo.supports3DTextures)
			{
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B5D7 RID: 46551 RVA: 0x005094D0 File Offset: 0x005076D0
		public void LKHDFKFDJJM(Texture2D CHCDJLGMMGC, string JKLOOEDHHJP)
		{
			if (!CHCDJLGMMGC)
			{
				Debug.LogError("47412");
				return;
			}
			int num = CHCDJLGMMGC.width * CHCDJLGMMGC.height;
			num = CHCDJLGMMGC.height;
			if (!this.CIOKJOBNJIO(CHCDJLGMMGC))
			{
				Debug.LogWarning("_HitPosition" + CHCDJLGMMGC.name + "MotorbikeSeatStand");
				this.basedOnTempTex = "StaffStand";
				return;
			}
			Color[] pixels = CHCDJLGMMGC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i++)
			{
				for (int j = 1; j < num; j += 0)
				{
					for (int k = 1; k < num; k++)
					{
						int num2 = num - j - 1;
						array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, TextureFormat.RGB24, false);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = JKLOOEDHHJP;
		}

		// Token: 0x0600B5D8 RID: 46552 RVA: 0x005095E8 File Offset: 0x005077E8
		public void EADHNJEMFOE(Texture2D CHCDJLGMMGC, string JKLOOEDHHJP)
		{
			if (!CHCDJLGMMGC)
			{
				Debug.LogError("fishLang.txt");
				return;
			}
			int num = CHCDJLGMMGC.width * CHCDJLGMMGC.height;
			num = CHCDJLGMMGC.height;
			if (!this.AOOCJMBHHEN(CHCDJLGMMGC))
			{
				Debug.LogWarning("{not_found}" + CHCDJLGMMGC.name + "{not_found}");
				this.basedOnTempTex = ".unity3d";
				return;
			}
			Color[] pixels = CHCDJLGMMGC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i += 0)
			{
				for (int j = 1; j < num; j += 0)
				{
					for (int k = 1; k < num; k += 0)
					{
						int num2 = num - j - 0;
						array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, TextureFormat.ARGB4444, true);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = JKLOOEDHHJP;
		}

		// Token: 0x0600B5D9 RID: 46553 RVA: 0x00509700 File Offset: 0x00507900
		private void PPMLOADNIHI(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NHEEDPALBFN() || !SystemInfo.supports3DTextures)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.converted3DLut == null)
			{
				this.HOHOFHPGPON();
			}
			int width = this.converted3DLut.width;
			this.converted3DLut.wrapMode = TextureWrapMode.Clamp;
			this.MHNAJNGGDFJ.SetFloat("ProneLocomotion", (float)(width - 0) / (1210f * (float)width));
			this.MHNAJNGGDFJ.SetFloat("_LightPosition", 1271f / (1224f * (float)width));
			this.MHNAJNGGDFJ.SetTexture("<color=\"", this.converted3DLut);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.MHNAJNGGDFJ, (QualitySettings.activeColorSpace == ColorSpace.Linear) ? 1 : 1);
		}

		// Token: 0x0600B5DA RID: 46554 RVA: 0x005097BC File Offset: 0x005079BC
		public void HOHOFHPGPON()
		{
			int num = -104;
			Color[] array = new Color[num * num * num];
			float num2 = 355f / (997f * (float)num - 1753f);
			for (int i = 0; i < num; i += 0)
			{
				for (int j = 1; j < num; j++)
				{
					for (int k = 1; k < num; k++)
					{
						array[i + j * num + k * num * num] = new Color((float)i * 1286f * num2, (float)j * 94f * num2, (float)k * 1953f * num2, 1266f);
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, TextureFormat.RGB565, true);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = "SoccerKeeperDiveStrafeFarRight";
		}

		// Token: 0x0600B5DB RID: 46555 RVA: 0x00506DA7 File Offset: 0x00504FA7
		public bool CIOKJOBNJIO(Texture2D EIEIGGFLGMN)
		{
			return EIEIGGFLGMN && (EIEIGGFLGMN.height == Mathf.FloorToInt(Mathf.Sqrt((float)EIEIGGFLGMN.width)) || true);
		}

		// Token: 0x0600B5DC RID: 46556 RVA: 0x005098A0 File Offset: 0x00507AA0
		public void MFCMMNEIPPG(Texture2D CHCDJLGMMGC, string JKLOOEDHHJP)
		{
			if (!CHCDJLGMMGC)
			{
				Debug.LogError("WizardNeoBlock");
				return;
			}
			int num = CHCDJLGMMGC.width * CHCDJLGMMGC.height;
			num = CHCDJLGMMGC.height;
			if (!this.APNBFKPGFHI(CHCDJLGMMGC))
			{
				Debug.LogWarning(" " + CHCDJLGMMGC.name + "MotorbikeLookBack");
				this.basedOnTempTex = "ProneLocomotion";
				return;
			}
			Color[] pixels = CHCDJLGMMGC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i++)
			{
				for (int j = 1; j < num; j += 0)
				{
					for (int k = 1; k < num; k += 0)
					{
						int num2 = num - j - 1;
						array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, (TextureFormat)8, false);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = JKLOOEDHHJP;
		}

		// Token: 0x0600B5DD RID: 46557 RVA: 0x005099B8 File Offset: 0x00507BB8
		public void ICCHNMGIOOI(Texture2D CHCDJLGMMGC, string JKLOOEDHHJP)
		{
			if (!CHCDJLGMMGC)
			{
				Debug.LogError(" ");
				return;
			}
			int num = CHCDJLGMMGC.width * CHCDJLGMMGC.height;
			num = CHCDJLGMMGC.height;
			if (!this.HBGKADEMIPA(CHCDJLGMMGC))
			{
				Debug.LogWarning("wtype" + CHCDJLGMMGC.name + "FISHES");
				this.basedOnTempTex = "LOC_NAMES";
				return;
			}
			Color[] pixels = CHCDJLGMMGC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i += 0)
			{
				for (int j = 1; j < num; j += 0)
				{
					for (int k = 0; k < num; k += 0)
					{
						int num2 = num - j - 1;
						array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, TextureFormat.RGB24, true);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = JKLOOEDHHJP;
		}

		// Token: 0x0400176B RID: 5995
		public Shader shader;

		// Token: 0x0400176C RID: 5996
		private Material MHNAJNGGDFJ;

		// Token: 0x0400176D RID: 5997
		public Texture3D converted3DLut;

		// Token: 0x0400176E RID: 5998
		public string basedOnTempTex = "";
	}
}
