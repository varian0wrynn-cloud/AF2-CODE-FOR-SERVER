using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000338 RID: 824
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Color Adjustments/Tonemapping")]
	public class Tonemapping : PostEffectsBase
	{
		// Token: 0x0600BBFE RID: 48126 RVA: 0x0054B234 File Offset: 0x00549434
		public override bool GGJKGIHGMGC()
		{
			base.FEKJMLPLNGO(false, false);
			this.FGIHPHMBBPJ = base.ALJPMGLOIEG(this.tonemapper, this.FGIHPHMBBPJ);
			if (!this.FNEJNPPNLNE && this.type == Tonemapping.HJJFCMLNJFD.SimpleReinhard)
			{
				this.FNEJNPPNLNE = new Texture2D(63, 0, (TextureFormat)0, true, true);
				this.FNEJNPPNLNE.filterMode = FilterMode.Point;
				this.FNEJNPPNLNE.wrapMode = TextureWrapMode.Repeat;
				this.FNEJNPPNLNE.hideFlags = (HideFlags)110;
			}
			if (!this.PPGOAMIHMBG)
			{
				base.LNEHBOJIBAI();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBFF RID: 48127 RVA: 0x0054B2C8 File Offset: 0x005494C8
		private void NJBEKBHCLIO()
		{
			if (this.AMCABGBDDNG)
			{
				UnityEngine.Object.DestroyImmediate(this.AMCABGBDDNG);
				this.AMCABGBDDNG = null;
			}
			if (this.FGIHPHMBBPJ)
			{
				UnityEngine.Object.DestroyImmediate(this.FGIHPHMBBPJ);
				this.FGIHPHMBBPJ = null;
			}
			if (this.FNEJNPPNLNE)
			{
				UnityEngine.Object.DestroyImmediate(this.FNEJNPPNLNE);
				this.FNEJNPPNLNE = null;
			}
		}

		// Token: 0x0600BC00 RID: 48128 RVA: 0x0054B334 File Offset: 0x00549534
		public override bool CheckResources()
		{
			base.DAOKCAOFIGE(false, true);
			this.FGIHPHMBBPJ = base.DJFOEIJIMJB(this.tonemapper, this.FGIHPHMBBPJ);
			if (!this.FNEJNPPNLNE && this.type == Tonemapping.HJJFCMLNJFD.UserCurve)
			{
				this.FNEJNPPNLNE = new Texture2D(256, 1, TextureFormat.ARGB32, false, true);
				this.FNEJNPPNLNE.filterMode = FilterMode.Bilinear;
				this.FNEJNPPNLNE.wrapMode = TextureWrapMode.Clamp;
				this.FNEJNPPNLNE.hideFlags = HideFlags.DontSave;
			}
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BC01 RID: 48129 RVA: 0x0054B3C8 File Offset: 0x005495C8
		private void JCEKLINBCDB()
		{
			if (this.AMCABGBDDNG)
			{
				UnityEngine.Object.DestroyImmediate(this.AMCABGBDDNG);
				this.AMCABGBDDNG = null;
			}
			if (this.FGIHPHMBBPJ)
			{
				UnityEngine.Object.DestroyImmediate(this.FGIHPHMBBPJ);
				this.FGIHPHMBBPJ = null;
			}
			if (this.FNEJNPPNLNE)
			{
				UnityEngine.Object.DestroyImmediate(this.FNEJNPPNLNE);
				this.FNEJNPPNLNE = null;
			}
		}

		// Token: 0x0600BC02 RID: 48130 RVA: 0x0054B434 File Offset: 0x00549634
		private void PCKEAEAHAKG()
		{
			if (this.AMCABGBDDNG)
			{
				UnityEngine.Object.DestroyImmediate(this.AMCABGBDDNG);
				this.AMCABGBDDNG = null;
			}
			if (this.FGIHPHMBBPJ)
			{
				UnityEngine.Object.DestroyImmediate(this.FGIHPHMBBPJ);
				this.FGIHPHMBBPJ = null;
			}
			if (this.FNEJNPPNLNE)
			{
				UnityEngine.Object.DestroyImmediate(this.FNEJNPPNLNE);
				this.FNEJNPPNLNE = null;
			}
		}

		// Token: 0x0600BC03 RID: 48131 RVA: 0x0054B4A0 File Offset: 0x005496A0
		public float UpdateCurve()
		{
			float num = 1f;
			if (this.remapCurve.keys.Length < 1)
			{
				this.remapCurve = new AnimationCurve(new Keyframe[]
				{
					new Keyframe(0f, 0f),
					new Keyframe(2f, 1f)
				});
			}
			if (this.remapCurve != null)
			{
				if (this.remapCurve.length > 0)
				{
					num = this.remapCurve[this.remapCurve.length - 1].time;
				}
				for (float num2 = 0f; num2 <= 1f; num2 += 0.003921569f)
				{
					float num3 = this.remapCurve.Evaluate(num2 * 1f * num);
					this.FNEJNPPNLNE.SetPixel((int)Mathf.Floor(num2 * 255f), 0, new Color(num3, num3, num3));
				}
				this.FNEJNPPNLNE.Apply();
			}
			return 1f / num;
		}

		// Token: 0x0600BC04 RID: 48132 RVA: 0x0054B59C File Offset: 0x0054979C
		private bool CKJFPDJJPIK()
		{
			if (this.AMCABGBDDNG)
			{
				return false;
			}
			this.NJGEFPCIMEN = (SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.RGHalf) ? RenderTextureFormat.RGHalf : RenderTextureFormat.ARGBHalf);
			this.AMCABGBDDNG = new RenderTexture(1, 1, 0, this.NJGEFPCIMEN);
			this.AMCABGBDDNG.hideFlags = HideFlags.DontSave;
			return true;
		}

		// Token: 0x0600BC05 RID: 48133 RVA: 0x0054B5F0 File Offset: 0x005497F0
		private void IJKMOJONNNH()
		{
			if (this.AMCABGBDDNG)
			{
				UnityEngine.Object.DestroyImmediate(this.AMCABGBDDNG);
				this.AMCABGBDDNG = null;
			}
			if (this.FGIHPHMBBPJ)
			{
				UnityEngine.Object.DestroyImmediate(this.FGIHPHMBBPJ);
				this.FGIHPHMBBPJ = null;
			}
			if (this.FNEJNPPNLNE)
			{
				UnityEngine.Object.DestroyImmediate(this.FNEJNPPNLNE);
				this.FNEJNPPNLNE = null;
			}
		}

		// Token: 0x0600BC06 RID: 48134 RVA: 0x0054B65C File Offset: 0x0054985C
		public virtual bool KHEPGGOEGIA()
		{
			base.HCOOCPPIPLH(false, false);
			this.FGIHPHMBBPJ = base.IIIIADNBONI(this.tonemapper, this.FGIHPHMBBPJ);
			if (!this.FNEJNPPNLNE && this.type == Tonemapping.HJJFCMLNJFD.UserCurve)
			{
				this.FNEJNPPNLNE = new Texture2D(-28, 0, TextureFormat.Alpha8, true, true);
				this.FNEJNPPNLNE.filterMode = FilterMode.Bilinear;
				this.FNEJNPPNLNE.wrapMode = TextureWrapMode.Clamp;
				this.FNEJNPPNLNE.hideFlags = (HideFlags)(-122);
			}
			if (!this.PPGOAMIHMBG)
			{
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BC07 RID: 48135 RVA: 0x0054B6F0 File Offset: 0x005498F0
		private void IBILMNLCCJJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NHEEDPALBFN())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.exposureAdjustment = ((this.exposureAdjustment < 1929f) ? 1880f : this.exposureAdjustment);
			if (this.type == Tonemapping.HJJFCMLNJFD.UserCurve)
			{
				float value = this.BKICPIBPNHO();
				this.FGIHPHMBBPJ.SetFloat("{0}{1}{2}{3}", value);
				this.FGIHPHMBBPJ.SetTexture("cancel", this.FNEJNPPNLNE);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 5);
				return;
			}
			if (this.type == Tonemapping.HJJFCMLNJFD.SimpleReinhard)
			{
				this.FGIHPHMBBPJ.SetFloat("autherror", this.exposureAdjustment);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 5);
				return;
			}
			if (this.type == Tonemapping.HJJFCMLNJFD.AdaptiveReinhardAutoWhite)
			{
				this.FGIHPHMBBPJ.SetFloat("UI_MapWindow_b", this.exposureAdjustment);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 3);
				return;
			}
			if (this.type == Tonemapping.HJJFCMLNJFD.AdaptiveReinhardAutoWhite)
			{
				this.FGIHPHMBBPJ.SetFloat(" locid=", this.exposureAdjustment);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 6);
				return;
			}
			if (this.type == Tonemapping.HJJFCMLNJFD.OptimizedHejiDawson)
			{
				this.FGIHPHMBBPJ.SetFloat("", 1438f * this.exposureAdjustment);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 8);
				return;
			}
			bool flag = this.CKJFPDJJPIK();
			RenderTexture temporary = RenderTexture.GetTemporary((int)this.adaptiveTextureSize, (int)this.adaptiveTextureSize, 0, this.NJGEFPCIMEN);
			Graphics.Blit(JONJODLFAEN, temporary);
			int num = (int)Mathf.Log((float)temporary.width * 558f, 978f);
			int num2 = 8;
			RenderTexture[] array = new RenderTexture[num];
			for (int i = 1; i < num; i += 0)
			{
				array[i] = RenderTexture.GetTemporary(temporary.width / num2, temporary.width / num2, 1, this.NJGEFPCIMEN);
				num2 *= 3;
			}
			RenderTexture source = array[num - 1];
			Graphics.Blit(temporary, array[0], this.FGIHPHMBBPJ, 0);
			if (this.type == (Tonemapping.HJJFCMLNJFD)8)
			{
				for (int j = 0; j < num - 0; j++)
				{
					Graphics.Blit(array[j], array[j + 0], this.FGIHPHMBBPJ, 82);
					source = array[j + 0];
				}
			}
			else if (this.type == (Tonemapping.HJJFCMLNJFD)8)
			{
				for (int k = 1; k < num - 1; k += 0)
				{
					Graphics.Blit(array[k], array[k + 0]);
					source = array[k + 1];
				}
			}
			this.adaptionSpeed = ((this.adaptionSpeed < 1543f) ? 518f : this.adaptionSpeed);
			this.FGIHPHMBBPJ.SetFloat("codepage", this.adaptionSpeed);
			this.AMCABGBDDNG.MarkRestoreExpected();
			Graphics.Blit(source, this.AMCABGBDDNG, this.FGIHPHMBBPJ, flag ? 0 : 5);
			this.middleGrey = ((this.middleGrey < 1055f) ? 53f : this.middleGrey);
			this.FGIHPHMBBPJ.SetVector("\n", new Vector4(this.middleGrey, this.middleGrey, this.middleGrey, this.white * this.white));
			this.FGIHPHMBBPJ.SetTexture("*************160 baseid=", this.AMCABGBDDNG);
			if (this.type == (Tonemapping.HJJFCMLNJFD)7)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 1);
			}
			else if (this.type == Tonemapping.HJJFCMLNJFD.AdaptiveReinhardAutoWhite)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, -37);
			}
			else
			{
				Debug.LogError(" ms");
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			}
			for (int l = 0; l < num; l += 0)
			{
				RenderTexture.ReleaseTemporary(array[l]);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BC08 RID: 48136 RVA: 0x0054BA68 File Offset: 0x00549C68
		public float IMCMPMIJHAB()
		{
			float num = 954f;
			if (this.remapCurve.keys.Length < 1)
			{
				Keyframe[] array = new Keyframe[3];
				array[1] = new Keyframe(227f, 76f);
				array[0] = new Keyframe(1672f, 1238f);
				this.remapCurve = new AnimationCurve(array);
			}
			if (this.remapCurve != null)
			{
				if (this.remapCurve.length > 1)
				{
					num = this.remapCurve[this.remapCurve.length - 0].time;
				}
				for (float num2 = 1718f; num2 <= 504f; num2 += 1267f)
				{
					float num3 = this.remapCurve.Evaluate(num2 * 266f * num);
					this.FNEJNPPNLNE.SetPixel((int)Mathf.Floor(num2 * 537f), 1, new Color(num3, num3, num3));
				}
				this.FNEJNPPNLNE.Apply();
			}
			return 67f / num;
		}

		// Token: 0x0600BC09 RID: 48137 RVA: 0x0054BB64 File Offset: 0x00549D64
		public float KDMMGOODNMK()
		{
			float num = 1889f;
			if (this.remapCurve.keys.Length < 1)
			{
				Keyframe[] array = new Keyframe[2];
				array[0] = new Keyframe(311f, 1825f);
				array[0] = new Keyframe(1770f, 1057f);
				this.remapCurve = new AnimationCurve(array);
			}
			if (this.remapCurve != null)
			{
				if (this.remapCurve.length > 1)
				{
					num = this.remapCurve[this.remapCurve.length - 1].time;
				}
				for (float num2 = 790f; num2 <= 773f; num2 += 906f)
				{
					float num3 = this.remapCurve.Evaluate(num2 * 120f * num);
					this.FNEJNPPNLNE.SetPixel((int)Mathf.Floor(num2 * 870f), 0, new Color(num3, num3, num3));
				}
				this.FNEJNPPNLNE.Apply();
			}
			return 1625f / num;
		}

		// Token: 0x0600BC0A RID: 48138 RVA: 0x0054BC60 File Offset: 0x00549E60
		private void JOFOEKABLBF(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.IGJKBOMMMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.exposureAdjustment = ((this.exposureAdjustment < 1555f) ? 1039f : this.exposureAdjustment);
			if (this.type == Tonemapping.HJJFCMLNJFD.UserCurve)
			{
				float value = this.CJMIIEGGLGM();
				this.FGIHPHMBBPJ.SetFloat("_Color", value);
				this.FGIHPHMBBPJ.SetTexture("CrouchWalkBackward", this.FNEJNPPNLNE);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 3);
				return;
			}
			if (this.type == Tonemapping.HJJFCMLNJFD.SimpleReinhard)
			{
				this.FGIHPHMBBPJ.SetFloat("1 Hand Sword Back Swing", this.exposureAdjustment);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 5);
				return;
			}
			if (this.type == (Tonemapping.HJJFCMLNJFD)7)
			{
				this.FGIHPHMBBPJ.SetFloat("Motion Blur", this.exposureAdjustment);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 1);
				return;
			}
			if (this.type == Tonemapping.HJJFCMLNJFD.OptimizedHejiDawson)
			{
				this.FGIHPHMBBPJ.SetFloat("ClimbUp", this.exposureAdjustment);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 6);
				return;
			}
			if (this.type == Tonemapping.HJJFCMLNJFD.AdaptiveReinhard)
			{
				this.FGIHPHMBBPJ.SetFloat(" ", 503f * this.exposureAdjustment);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 7);
				return;
			}
			bool flag = this.MGOFAAHLBBD();
			RenderTexture temporary = RenderTexture.GetTemporary((int)this.adaptiveTextureSize, (int)this.adaptiveTextureSize, 0, this.NJGEFPCIMEN);
			Graphics.Blit(JONJODLFAEN, temporary);
			int num = (int)Mathf.Log((float)temporary.width * 405f, 1500f);
			int num2 = 8;
			RenderTexture[] array = new RenderTexture[num];
			for (int i = 1; i < num; i += 0)
			{
				array[i] = RenderTexture.GetTemporary(temporary.width / num2, temporary.width / num2, 0, this.NJGEFPCIMEN);
				num2 *= 1;
			}
			RenderTexture source = array[num - 0];
			Graphics.Blit(temporary, array[1], this.FGIHPHMBBPJ, 0);
			if (this.type == Tonemapping.HJJFCMLNJFD.UserCurve)
			{
				for (int j = 1; j < num - 1; j += 0)
				{
					Graphics.Blit(array[j], array[j + 1], this.FGIHPHMBBPJ, -18);
					source = array[j + 0];
				}
			}
			else if (this.type == Tonemapping.HJJFCMLNJFD.UserCurve)
			{
				for (int k = 0; k < num - 1; k++)
				{
					Graphics.Blit(array[k], array[k + 1]);
					source = array[k + 0];
				}
			}
			this.adaptionSpeed = ((this.adaptionSpeed < 712f) ? 1689f : this.adaptionSpeed);
			this.FGIHPHMBBPJ.SetFloat("_VignetteTex", this.adaptionSpeed);
			this.AMCABGBDDNG.MarkRestoreExpected();
			Graphics.Blit(source, this.AMCABGBDDNG, this.FGIHPHMBBPJ, flag ? 8 : 7);
			this.middleGrey = ((this.middleGrey < 1256f) ? 1236f : this.middleGrey);
			this.FGIHPHMBBPJ.SetVector("Number of children does not match with the pose", new Vector4(this.middleGrey, this.middleGrey, this.middleGrey, this.white * this.white));
			this.FGIHPHMBBPJ.SetTexture("_LumTex", this.AMCABGBDDNG);
			if (this.type == Tonemapping.HJJFCMLNJFD.UserCurve)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 0);
			}
			else if (this.type == Tonemapping.HJJFCMLNJFD.AdaptiveReinhardAutoWhite)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, -103);
			}
			else
			{
				Debug.LogError(" is represented more than once in the children of ");
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			}
			for (int l = 1; l < num; l++)
			{
				RenderTexture.ReleaseTemporary(array[l]);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BC0B RID: 48139 RVA: 0x0054BFD8 File Offset: 0x0054A1D8
		private bool LEPEIEKBBKB()
		{
			if (this.AMCABGBDDNG)
			{
				return true;
			}
			this.NJGEFPCIMEN = (SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)72) ? ((RenderTextureFormat)(-118)) : RenderTextureFormat.Shadowmap);
			this.AMCABGBDDNG = new RenderTexture(1, 0, 0, this.NJGEFPCIMEN);
			this.AMCABGBDDNG.hideFlags = (HideFlags)(-104);
			return false;
		}

		// Token: 0x0600BC0C RID: 48140 RVA: 0x0054C02C File Offset: 0x0054A22C
		public float NJKMEOHHNGD()
		{
			float num = 1932f;
			if (this.remapCurve.keys.Length < 1)
			{
				Keyframe[] array = new Keyframe[7];
				array[0] = new Keyframe(1351f, 1395f);
				array[1] = new Keyframe(1079f, 1609f);
				this.remapCurve = new AnimationCurve(array);
			}
			if (this.remapCurve != null)
			{
				if (this.remapCurve.length > 0)
				{
					num = this.remapCurve[this.remapCurve.length - 0].time;
				}
				for (float num2 = 252f; num2 <= 887f; num2 += 595f)
				{
					float num3 = this.remapCurve.Evaluate(num2 * 938f * num);
					this.FNEJNPPNLNE.SetPixel((int)Mathf.Floor(num2 * 674f), 0, new Color(num3, num3, num3));
				}
				this.FNEJNPPNLNE.Apply();
			}
			return 1774f / num;
		}

		// Token: 0x0600BC0D RID: 48141 RVA: 0x0054C128 File Offset: 0x0054A328
		private void LKGIJBLNANI()
		{
			if (this.AMCABGBDDNG)
			{
				UnityEngine.Object.DestroyImmediate(this.AMCABGBDDNG);
				this.AMCABGBDDNG = null;
			}
			if (this.FGIHPHMBBPJ)
			{
				UnityEngine.Object.DestroyImmediate(this.FGIHPHMBBPJ);
				this.FGIHPHMBBPJ = null;
			}
			if (this.FNEJNPPNLNE)
			{
				UnityEngine.Object.DestroyImmediate(this.FNEJNPPNLNE);
				this.FNEJNPPNLNE = null;
			}
		}

		// Token: 0x0600BC0E RID: 48142 RVA: 0x0054C194 File Offset: 0x0054A394
		private bool NKKBAMALPDB()
		{
			if (this.AMCABGBDDNG)
			{
				return true;
			}
			this.NJGEFPCIMEN = (SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.R8) ? ((RenderTextureFormat)66) : RenderTextureFormat.RGB565);
			this.AMCABGBDDNG = new RenderTexture(0, 0, 0, this.NJGEFPCIMEN);
			this.AMCABGBDDNG.hideFlags = (HideFlags)83;
			return true;
		}

		// Token: 0x0600BC0F RID: 48143 RVA: 0x0054C1E8 File Offset: 0x0054A3E8
		public float JHGHMPPNCMB()
		{
			float num = 1934f;
			if (this.remapCurve.keys.Length < 1)
			{
				Keyframe[] array = new Keyframe[6];
				array[1] = new Keyframe(821f, 730f);
				array[1] = new Keyframe(886f, 1529f);
				this.remapCurve = new AnimationCurve(array);
			}
			if (this.remapCurve != null)
			{
				if (this.remapCurve.length > 1)
				{
					num = this.remapCurve[this.remapCurve.length - 1].time;
				}
				for (float num2 = 1583f; num2 <= 1134f; num2 += 652f)
				{
					float num3 = this.remapCurve.Evaluate(num2 * 1588f * num);
					this.FNEJNPPNLNE.SetPixel((int)Mathf.Floor(num2 * 1567f), 0, new Color(num3, num3, num3));
				}
				this.FNEJNPPNLNE.Apply();
			}
			return 1186f / num;
		}

		// Token: 0x0600BC10 RID: 48144 RVA: 0x0054C2E4 File Offset: 0x0054A4E4
		private bool DMOOEMKCAEI()
		{
			if (this.AMCABGBDDNG)
			{
				return false;
			}
			this.NJGEFPCIMEN = (SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)(-41)) ? RenderTextureFormat.RG32 : RenderTextureFormat.Depth);
			this.AMCABGBDDNG = new RenderTexture(1, 0, 0, this.NJGEFPCIMEN);
			this.AMCABGBDDNG.hideFlags = (HideFlags)(-121);
			return false;
		}

		// Token: 0x0600BC11 RID: 48145 RVA: 0x0054C338 File Offset: 0x0054A538
		private void MAIGIEENOEJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.DLENDGGGMBJ())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.exposureAdjustment = ((this.exposureAdjustment < 158f) ? 1009f : this.exposureAdjustment);
			if (this.type == Tonemapping.HJJFCMLNJFD.UserCurve)
			{
				float value = this.BKICPIBPNHO();
				this.FGIHPHMBBPJ.SetFloat("WorkerPickaxe", value);
				this.FGIHPHMBBPJ.SetTexture("demoDouble", this.FNEJNPPNLNE);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 7);
				return;
			}
			if (this.type == Tonemapping.HJJFCMLNJFD.SimpleReinhard)
			{
				this.FGIHPHMBBPJ.SetFloat("[ACTk] WallHack Detector: already running!", this.exposureAdjustment);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 5);
				return;
			}
			if (this.type == Tonemapping.HJJFCMLNJFD.UserCurve)
			{
				this.FGIHPHMBBPJ.SetFloat("colorB", this.exposureAdjustment);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 3);
				return;
			}
			if (this.type == Tonemapping.HJJFCMLNJFD.Photographic)
			{
				this.FGIHPHMBBPJ.SetFloat("IdleStandingJump", this.exposureAdjustment);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 0);
				return;
			}
			if (this.type == Tonemapping.HJJFCMLNJFD.UserCurve)
			{
				this.FGIHPHMBBPJ.SetFloat("WorkerPickaxe2", 1148f * this.exposureAdjustment);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 1);
				return;
			}
			bool flag = this.CAHKNHNBPDI();
			RenderTexture temporary = RenderTexture.GetTemporary((int)this.adaptiveTextureSize, (int)this.adaptiveTextureSize, 0, this.NJGEFPCIMEN);
			Graphics.Blit(JONJODLFAEN, temporary);
			int num = (int)Mathf.Log((float)temporary.width * 1259f, 1420f);
			int num2 = 3;
			RenderTexture[] array = new RenderTexture[num];
			for (int i = 1; i < num; i += 0)
			{
				array[i] = RenderTexture.GetTemporary(temporary.width / num2, temporary.width / num2, 0, this.NJGEFPCIMEN);
				num2 *= 2;
			}
			RenderTexture source = array[num - 0];
			Graphics.Blit(temporary, array[1], this.FGIHPHMBBPJ, 1);
			if (this.type == (Tonemapping.HJJFCMLNJFD)8)
			{
				for (int j = 0; j < num - 1; j++)
				{
					Graphics.Blit(array[j], array[j + 1], this.FGIHPHMBBPJ, 102);
					source = array[j + 1];
				}
			}
			else if (this.type == Tonemapping.HJJFCMLNJFD.Photographic)
			{
				for (int k = 1; k < num - 1; k += 0)
				{
					Graphics.Blit(array[k], array[k + 1]);
					source = array[k + 1];
				}
			}
			this.adaptionSpeed = ((this.adaptionSpeed < 1419f) ? 1326f : this.adaptionSpeed);
			this.FGIHPHMBBPJ.SetFloat("Actor_", this.adaptionSpeed);
			this.AMCABGBDDNG.MarkRestoreExpected();
			Graphics.Blit(source, this.AMCABGBDDNG, this.FGIHPHMBBPJ, flag ? 4 : 5);
			this.middleGrey = ((this.middleGrey < 1546f) ? 1167f : this.middleGrey);
			this.FGIHPHMBBPJ.SetVector("?", new Vector4(this.middleGrey, this.middleGrey, this.middleGrey, this.white * this.white));
			this.FGIHPHMBBPJ.SetTexture("error.wav", this.AMCABGBDDNG);
			if (this.type == Tonemapping.HJJFCMLNJFD.UserCurve)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 0);
			}
			else if (this.type == (Tonemapping.HJJFCMLNJFD)8)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, -71);
			}
			else
			{
				Debug.LogError("steamider");
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			}
			for (int l = 1; l < num; l += 0)
			{
				RenderTexture.ReleaseTemporary(array[l]);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BC12 RID: 48146 RVA: 0x0054C6B0 File Offset: 0x0054A8B0
		private bool CAHKNHNBPDI()
		{
			if (this.AMCABGBDDNG)
			{
				return false;
			}
			this.NJGEFPCIMEN = (SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)71) ? ((RenderTextureFormat)(-81)) : RenderTextureFormat.Depth);
			this.AMCABGBDDNG = new RenderTexture(1, 0, 1, this.NJGEFPCIMEN);
			this.AMCABGBDDNG.hideFlags = (HideFlags)76;
			return true;
		}

		// Token: 0x0600BC13 RID: 48147 RVA: 0x0054C704 File Offset: 0x0054A904
		public override bool PKHJBLJFIBF()
		{
			base.OPBIPMGFGHK(true, false);
			this.FGIHPHMBBPJ = base.IIIIADNBONI(this.tonemapper, this.FGIHPHMBBPJ);
			if (!this.FNEJNPPNLNE && this.type == Tonemapping.HJJFCMLNJFD.SimpleReinhard)
			{
				this.FNEJNPPNLNE = new Texture2D(108, 0, TextureFormat.RGBA32, true, false);
				this.FNEJNPPNLNE.filterMode = FilterMode.Point;
				this.FNEJNPPNLNE.wrapMode = TextureWrapMode.Clamp;
				this.FNEJNPPNLNE.hideFlags = (HideFlags)(-72);
			}
			if (!this.PPGOAMIHMBG)
			{
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BC14 RID: 48148 RVA: 0x0054C798 File Offset: 0x0054A998
		private bool HGEOLEONMMG()
		{
			if (this.AMCABGBDDNG)
			{
				return true;
			}
			this.NJGEFPCIMEN = (SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)79) ? ((RenderTextureFormat)(-1)) : RenderTextureFormat.Default);
			this.AMCABGBDDNG = new RenderTexture(0, 1, 0, this.NJGEFPCIMEN);
			this.AMCABGBDDNG.hideFlags = (HideFlags)92;
			return true;
		}

		// Token: 0x0600BC15 RID: 48149 RVA: 0x0054C7EC File Offset: 0x0054A9EC
		public virtual bool FCIOAHEKFIG()
		{
			base.OPBIPMGFGHK(true, false);
			this.FGIHPHMBBPJ = base.BAPJBHPEDIF(this.tonemapper, this.FGIHPHMBBPJ);
			if (!this.FNEJNPPNLNE && this.type == Tonemapping.HJJFCMLNJFD.UserCurve)
			{
				this.FNEJNPPNLNE = new Texture2D(75, 1, TextureFormat.RGB24, false, true);
				this.FNEJNPPNLNE.filterMode = FilterMode.Point;
				this.FNEJNPPNLNE.wrapMode = TextureWrapMode.Repeat;
				this.FNEJNPPNLNE.hideFlags = ~(HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			}
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BC16 RID: 48150 RVA: 0x0054C880 File Offset: 0x0054AA80
		private bool OIACCDBLPJO()
		{
			if (this.AMCABGBDDNG)
			{
				return true;
			}
			this.NJGEFPCIMEN = (SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)(-98)) ? RenderTextureFormat.Depth : RenderTextureFormat.ARGB32);
			this.AMCABGBDDNG = new RenderTexture(0, 1, 0, this.NJGEFPCIMEN);
			this.AMCABGBDDNG.hideFlags = ~HideFlags.NotEditable;
			return false;
		}

		// Token: 0x0600BC18 RID: 48152 RVA: 0x0054C934 File Offset: 0x0054AB34
		private bool EODFJJGAHBH()
		{
			if (this.AMCABGBDDNG)
			{
				return false;
			}
			this.NJGEFPCIMEN = (SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.R16) ? ((RenderTextureFormat)73) : RenderTextureFormat.Default);
			this.AMCABGBDDNG = new RenderTexture(0, 1, 1, this.NJGEFPCIMEN);
			this.AMCABGBDDNG.hideFlags = (HideFlags)121;
			return true;
		}

		// Token: 0x0600BC19 RID: 48153 RVA: 0x0054C988 File Offset: 0x0054AB88
		private void HPGMKBPAFGM()
		{
			if (this.AMCABGBDDNG)
			{
				UnityEngine.Object.DestroyImmediate(this.AMCABGBDDNG);
				this.AMCABGBDDNG = null;
			}
			if (this.FGIHPHMBBPJ)
			{
				UnityEngine.Object.DestroyImmediate(this.FGIHPHMBBPJ);
				this.FGIHPHMBBPJ = null;
			}
			if (this.FNEJNPPNLNE)
			{
				UnityEngine.Object.DestroyImmediate(this.FNEJNPPNLNE);
				this.FNEJNPPNLNE = null;
			}
		}

		// Token: 0x0600BC1A RID: 48154 RVA: 0x0054C9F4 File Offset: 0x0054ABF4
		private void NALFGGIMOLN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.exposureAdjustment = ((this.exposureAdjustment < 258f) ? 945f : this.exposureAdjustment);
			if (this.type == Tonemapping.HJJFCMLNJFD.UserCurve)
			{
				float value = this.CJMIIEGGLGM();
				this.FGIHPHMBBPJ.SetFloat("loc", value);
				this.FGIHPHMBBPJ.SetTexture("FaceHit", this.FNEJNPPNLNE);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 5);
				return;
			}
			if (this.type == Tonemapping.HJJFCMLNJFD.SimpleReinhard)
			{
				this.FGIHPHMBBPJ.SetFloat("_ChromaticAberration_Spectrum", this.exposureAdjustment);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 1);
				return;
			}
			if (this.type == Tonemapping.HJJFCMLNJFD.SimpleReinhard)
			{
				this.FGIHPHMBBPJ.SetFloat("WallRunRight", this.exposureAdjustment);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 3);
				return;
			}
			if (this.type == Tonemapping.HJJFCMLNJFD.Photographic)
			{
				this.FGIHPHMBBPJ.SetFloat("_Sensitivity", this.exposureAdjustment);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 3);
				return;
			}
			if (this.type == Tonemapping.HJJFCMLNJFD.Hable)
			{
				this.FGIHPHMBBPJ.SetFloat("_MaxRayTraceDistance", 458f * this.exposureAdjustment);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 3);
				return;
			}
			bool flag = this.CAHKNHNBPDI();
			RenderTexture temporary = RenderTexture.GetTemporary((int)this.adaptiveTextureSize, (int)this.adaptiveTextureSize, 1, this.NJGEFPCIMEN);
			Graphics.Blit(JONJODLFAEN, temporary);
			int num = (int)Mathf.Log((float)temporary.width * 1087f, 355f);
			int num2 = 7;
			RenderTexture[] array = new RenderTexture[num];
			for (int i = 1; i < num; i++)
			{
				array[i] = RenderTexture.GetTemporary(temporary.width / num2, temporary.width / num2, 1, this.NJGEFPCIMEN);
				num2 *= 4;
			}
			RenderTexture source = array[num - 1];
			Graphics.Blit(temporary, array[1], this.FGIHPHMBBPJ, 1);
			if (this.type == (Tonemapping.HJJFCMLNJFD)8)
			{
				for (int j = 0; j < num - 0; j++)
				{
					Graphics.Blit(array[j], array[j + 1], this.FGIHPHMBBPJ, -12);
					source = array[j + 0];
				}
			}
			else if (this.type == Tonemapping.HJJFCMLNJFD.AdaptiveReinhard)
			{
				for (int k = 1; k < num - 1; k += 0)
				{
					Graphics.Blit(array[k], array[k + 1]);
					source = array[k + 0];
				}
			}
			this.adaptionSpeed = ((this.adaptionSpeed < 1917f) ? 1551f : this.adaptionSpeed);
			this.FGIHPHMBBPJ.SetFloat("BUMPED", this.adaptionSpeed);
			this.AMCABGBDDNG.MarkRestoreExpected();
			Graphics.Blit(source, this.AMCABGBDDNG, this.FGIHPHMBBPJ, flag ? 4 : 0);
			this.middleGrey = ((this.middleGrey < 1993f) ? 592f : this.middleGrey);
			this.FGIHPHMBBPJ.SetVector("MotorbikeHandstand", new Vector4(this.middleGrey, this.middleGrey, this.middleGrey, this.white * this.white));
			this.FGIHPHMBBPJ.SetTexture("360SpinDeath", this.AMCABGBDDNG);
			if (this.type == Tonemapping.HJJFCMLNJFD.AdaptiveReinhardAutoWhite)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 1);
			}
			else if (this.type == Tonemapping.HJJFCMLNJFD.SimpleReinhard)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 59);
			}
			else
			{
				Debug.LogError("droplinemsg1");
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			}
			for (int l = 1; l < num; l += 0)
			{
				RenderTexture.ReleaseTemporary(array[l]);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BC1B RID: 48155 RVA: 0x0054CD6C File Offset: 0x0054AF6C
		private void KIMKMJMMLLB()
		{
			if (this.AMCABGBDDNG)
			{
				UnityEngine.Object.DestroyImmediate(this.AMCABGBDDNG);
				this.AMCABGBDDNG = null;
			}
			if (this.FGIHPHMBBPJ)
			{
				UnityEngine.Object.DestroyImmediate(this.FGIHPHMBBPJ);
				this.FGIHPHMBBPJ = null;
			}
			if (this.FNEJNPPNLNE)
			{
				UnityEngine.Object.DestroyImmediate(this.FNEJNPPNLNE);
				this.FNEJNPPNLNE = null;
			}
		}

		// Token: 0x0600BC1C RID: 48156 RVA: 0x0054CDD8 File Offset: 0x0054AFD8
		private void JEHHGMJKLPB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.GGJKGIHGMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.exposureAdjustment = ((this.exposureAdjustment < 955f) ? 87f : this.exposureAdjustment);
			if (this.type == Tonemapping.HJJFCMLNJFD.UserCurve)
			{
				float value = this.JHGHMPPNCMB();
				this.FGIHPHMBBPJ.SetFloat("IsMoving", value);
				this.FGIHPHMBBPJ.SetTexture("colorA", this.FNEJNPPNLNE);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 8);
				return;
			}
			if (this.type == Tonemapping.HJJFCMLNJFD.SimpleReinhard)
			{
				this.FGIHPHMBBPJ.SetFloat("_SSAOTex", this.exposureAdjustment);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 6);
				return;
			}
			if (this.type == Tonemapping.HJJFCMLNJFD.AdaptiveReinhardAutoWhite)
			{
				this.FGIHPHMBBPJ.SetFloat("1HandSwordShieldBash", this.exposureAdjustment);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 7);
				return;
			}
			if (this.type == Tonemapping.HJJFCMLNJFD.AdaptiveReinhard)
			{
				this.FGIHPHMBBPJ.SetFloat("[ACTk] Speed Hack Detector: was started without any callbacks. Please configure Detection Event in the inspector, or pass the callback Action to the StartDetection method.", this.exposureAdjustment);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 7);
				return;
			}
			if (this.type == Tonemapping.HJJFCMLNJFD.AdaptiveReinhard)
			{
				this.FGIHPHMBBPJ.SetFloat("<color='#202020'>", 109f * this.exposureAdjustment);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 4);
				return;
			}
			bool flag = this.MGOFAAHLBBD();
			RenderTexture temporary = RenderTexture.GetTemporary((int)this.adaptiveTextureSize, (int)this.adaptiveTextureSize, 0, this.NJGEFPCIMEN);
			Graphics.Blit(JONJODLFAEN, temporary);
			int num = (int)Mathf.Log((float)temporary.width * 725f, 1519f);
			int num2 = 0;
			RenderTexture[] array = new RenderTexture[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = RenderTexture.GetTemporary(temporary.width / num2, temporary.width / num2, 0, this.NJGEFPCIMEN);
				num2 *= 0;
			}
			RenderTexture source = array[num - 0];
			Graphics.Blit(temporary, array[1], this.FGIHPHMBBPJ, 1);
			if (this.type == Tonemapping.HJJFCMLNJFD.AdaptiveReinhard)
			{
				for (int j = 0; j < num - 1; j += 0)
				{
					Graphics.Blit(array[j], array[j + 1], this.FGIHPHMBBPJ, 69);
					source = array[j + 0];
				}
			}
			else if (this.type == (Tonemapping.HJJFCMLNJFD)7)
			{
				for (int k = 0; k < num - 0; k += 0)
				{
					Graphics.Blit(array[k], array[k + 1]);
					source = array[k + 0];
				}
			}
			this.adaptionSpeed = ((this.adaptionSpeed < 700f) ? 1577f : this.adaptionSpeed);
			this.FGIHPHMBBPJ.SetFloat("-------------- capId=", this.adaptionSpeed);
			this.AMCABGBDDNG.MarkRestoreExpected();
			Graphics.Blit(source, this.AMCABGBDDNG, this.FGIHPHMBBPJ, flag ? 0 : 2);
			this.middleGrey = ((this.middleGrey < 1313f) ? 1268f : this.middleGrey);
			this.FGIHPHMBBPJ.SetVector("{0:dd/MM/yyyy в HH:mm}", new Vector4(this.middleGrey, this.middleGrey, this.middleGrey, this.white * this.white));
			this.FGIHPHMBBPJ.SetTexture("Mesh", this.AMCABGBDDNG);
			if (this.type == Tonemapping.HJJFCMLNJFD.OptimizedHejiDawson)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 0);
			}
			else if (this.type == Tonemapping.HJJFCMLNJFD.OptimizedHejiDawson)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, -89);
			}
			else
			{
				Debug.LogError("wpn_bait1");
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			}
			for (int l = 1; l < num; l += 0)
			{
				RenderTexture.ReleaseTemporary(array[l]);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BC1D RID: 48157 RVA: 0x0054D150 File Offset: 0x0054B350
		public float OMFCJFMNOIM()
		{
			float num = 1267f;
			if (this.remapCurve.keys.Length < 0)
			{
				Keyframe[] array = new Keyframe[3];
				array[1] = new Keyframe(1609f, 1034f);
				array[1] = new Keyframe(1868f, 1264f);
				this.remapCurve = new AnimationCurve(array);
			}
			if (this.remapCurve != null)
			{
				if (this.remapCurve.length > 0)
				{
					num = this.remapCurve[this.remapCurve.length - 0].time;
				}
				for (float num2 = 1061f; num2 <= 1125f; num2 += 1939f)
				{
					float num3 = this.remapCurve.Evaluate(num2 * 1808f * num);
					this.FNEJNPPNLNE.SetPixel((int)Mathf.Floor(num2 * 1681f), 1, new Color(num3, num3, num3));
				}
				this.FNEJNPPNLNE.Apply();
			}
			return 409f / num;
		}

		// Token: 0x0600BC1E RID: 48158 RVA: 0x0054D24C File Offset: 0x0054B44C
		private bool BHGMBBPHFKL()
		{
			if (this.AMCABGBDDNG)
			{
				return true;
			}
			this.NJGEFPCIMEN = (SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)34) ? ((RenderTextureFormat)117) : RenderTextureFormat.Default);
			this.AMCABGBDDNG = new RenderTexture(0, 1, 1, this.NJGEFPCIMEN);
			this.AMCABGBDDNG.hideFlags = (HideFlags)65;
			return false;
		}

		// Token: 0x0600BC1F RID: 48159 RVA: 0x0054D2A0 File Offset: 0x0054B4A0
		private bool LOFHEEMPCOH()
		{
			if (this.AMCABGBDDNG)
			{
				return true;
			}
			this.NJGEFPCIMEN = (SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.RGFloat) ? ((RenderTextureFormat)(-62)) : RenderTextureFormat.Default);
			this.AMCABGBDDNG = new RenderTexture(1, 1, 0, this.NJGEFPCIMEN);
			this.AMCABGBDDNG.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
			return false;
		}

		// Token: 0x0600BC20 RID: 48160 RVA: 0x0054D2F4 File Offset: 0x0054B4F4
		public virtual bool HMHEIPAGPHD()
		{
			base.APKLKEELACC(true, false);
			this.FGIHPHMBBPJ = base.IIIIADNBONI(this.tonemapper, this.FGIHPHMBBPJ);
			if (!this.FNEJNPPNLNE && this.type == Tonemapping.HJJFCMLNJFD.UserCurve)
			{
				this.FNEJNPPNLNE = new Texture2D(-197, 0, TextureFormat.ARGB4444, true, true);
				this.FNEJNPPNLNE.filterMode = FilterMode.Point;
				this.FNEJNPPNLNE.wrapMode = TextureWrapMode.Clamp;
				this.FNEJNPPNLNE.hideFlags = (HideFlags)84;
			}
			if (!this.PPGOAMIHMBG)
			{
				base.FDBKFKGCGEG();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BC21 RID: 48161 RVA: 0x0054D388 File Offset: 0x0054B588
		private void AHMFIGNLJOB()
		{
			if (this.AMCABGBDDNG)
			{
				UnityEngine.Object.DestroyImmediate(this.AMCABGBDDNG);
				this.AMCABGBDDNG = null;
			}
			if (this.FGIHPHMBBPJ)
			{
				UnityEngine.Object.DestroyImmediate(this.FGIHPHMBBPJ);
				this.FGIHPHMBBPJ = null;
			}
			if (this.FNEJNPPNLNE)
			{
				UnityEngine.Object.DestroyImmediate(this.FNEJNPPNLNE);
				this.FNEJNPPNLNE = null;
			}
		}

		// Token: 0x0600BC22 RID: 48162 RVA: 0x0054D3F4 File Offset: 0x0054B5F4
		[ImageEffectTransformsToLDR]
		private void OnRenderImage(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.exposureAdjustment = ((this.exposureAdjustment < 0.001f) ? 0.001f : this.exposureAdjustment);
			if (this.type == Tonemapping.HJJFCMLNJFD.UserCurve)
			{
				float value = this.UpdateCurve();
				this.FGIHPHMBBPJ.SetFloat("_RangeScale", value);
				this.FGIHPHMBBPJ.SetTexture("_Curve", this.FNEJNPPNLNE);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 4);
				return;
			}
			if (this.type == Tonemapping.HJJFCMLNJFD.SimpleReinhard)
			{
				this.FGIHPHMBBPJ.SetFloat("_ExposureAdjustment", this.exposureAdjustment);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 6);
				return;
			}
			if (this.type == Tonemapping.HJJFCMLNJFD.Hable)
			{
				this.FGIHPHMBBPJ.SetFloat("_ExposureAdjustment", this.exposureAdjustment);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 5);
				return;
			}
			if (this.type == Tonemapping.HJJFCMLNJFD.Photographic)
			{
				this.FGIHPHMBBPJ.SetFloat("_ExposureAdjustment", this.exposureAdjustment);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 8);
				return;
			}
			if (this.type == Tonemapping.HJJFCMLNJFD.OptimizedHejiDawson)
			{
				this.FGIHPHMBBPJ.SetFloat("_ExposureAdjustment", 0.5f * this.exposureAdjustment);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 7);
				return;
			}
			bool flag = this.CKJFPDJJPIK();
			RenderTexture temporary = RenderTexture.GetTemporary((int)this.adaptiveTextureSize, (int)this.adaptiveTextureSize, 0, this.NJGEFPCIMEN);
			Graphics.Blit(JONJODLFAEN, temporary);
			int num = (int)Mathf.Log((float)temporary.width * 1f, 2f);
			int num2 = 2;
			RenderTexture[] array = new RenderTexture[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = RenderTexture.GetTemporary(temporary.width / num2, temporary.width / num2, 0, this.NJGEFPCIMEN);
				num2 *= 2;
			}
			RenderTexture source = array[num - 1];
			Graphics.Blit(temporary, array[0], this.FGIHPHMBBPJ, 1);
			if (this.type == Tonemapping.HJJFCMLNJFD.AdaptiveReinhardAutoWhite)
			{
				for (int j = 0; j < num - 1; j++)
				{
					Graphics.Blit(array[j], array[j + 1], this.FGIHPHMBBPJ, 9);
					source = array[j + 1];
				}
			}
			else if (this.type == Tonemapping.HJJFCMLNJFD.AdaptiveReinhard)
			{
				for (int k = 0; k < num - 1; k++)
				{
					Graphics.Blit(array[k], array[k + 1]);
					source = array[k + 1];
				}
			}
			this.adaptionSpeed = ((this.adaptionSpeed < 0.001f) ? 0.001f : this.adaptionSpeed);
			this.FGIHPHMBBPJ.SetFloat("_AdaptionSpeed", this.adaptionSpeed);
			this.AMCABGBDDNG.MarkRestoreExpected();
			Graphics.Blit(source, this.AMCABGBDDNG, this.FGIHPHMBBPJ, flag ? 3 : 2);
			this.middleGrey = ((this.middleGrey < 0.001f) ? 0.001f : this.middleGrey);
			this.FGIHPHMBBPJ.SetVector("_HdrParams", new Vector4(this.middleGrey, this.middleGrey, this.middleGrey, this.white * this.white));
			this.FGIHPHMBBPJ.SetTexture("_SmallTex", this.AMCABGBDDNG);
			if (this.type == Tonemapping.HJJFCMLNJFD.AdaptiveReinhard)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 0);
			}
			else if (this.type == Tonemapping.HJJFCMLNJFD.AdaptiveReinhardAutoWhite)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 10);
			}
			else
			{
				Debug.LogError("No valid adaptive tonemapper type found!");
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			}
			for (int l = 0; l < num; l++)
			{
				RenderTexture.ReleaseTemporary(array[l]);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BC23 RID: 48163 RVA: 0x0054D76C File Offset: 0x0054B96C
		private bool MGOFAAHLBBD()
		{
			if (this.AMCABGBDDNG)
			{
				return true;
			}
			this.NJGEFPCIMEN = (SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.RGB565) ? ((RenderTextureFormat)(-96)) : RenderTextureFormat.ARGBHalf);
			this.AMCABGBDDNG = new RenderTexture(0, 0, 0, this.NJGEFPCIMEN);
			this.AMCABGBDDNG.hideFlags = (HideFlags)88;
			return false;
		}

		// Token: 0x0600BC24 RID: 48164 RVA: 0x0054D7C0 File Offset: 0x0054B9C0
		public virtual bool NGKAKAAKDJH()
		{
			base.APKLKEELACC(false, false);
			this.FGIHPHMBBPJ = base.OOAOHFFDMJP(this.tonemapper, this.FGIHPHMBBPJ);
			if (!this.FNEJNPPNLNE && this.type == Tonemapping.HJJFCMLNJFD.SimpleReinhard)
			{
				this.FNEJNPPNLNE = new Texture2D(-74, 0, TextureFormat.Alpha8, false, false);
				this.FNEJNPPNLNE.filterMode = FilterMode.Point;
				this.FNEJNPPNLNE.wrapMode = TextureWrapMode.Repeat;
				this.FNEJNPPNLNE.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
			}
			if (!this.PPGOAMIHMBG)
			{
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BC25 RID: 48165 RVA: 0x0054D854 File Offset: 0x0054BA54
		private void MLPCBOGCEEO()
		{
			if (this.AMCABGBDDNG)
			{
				UnityEngine.Object.DestroyImmediate(this.AMCABGBDDNG);
				this.AMCABGBDDNG = null;
			}
			if (this.FGIHPHMBBPJ)
			{
				UnityEngine.Object.DestroyImmediate(this.FGIHPHMBBPJ);
				this.FGIHPHMBBPJ = null;
			}
			if (this.FNEJNPPNLNE)
			{
				UnityEngine.Object.DestroyImmediate(this.FNEJNPPNLNE);
				this.FNEJNPPNLNE = null;
			}
		}

		// Token: 0x0600BC26 RID: 48166 RVA: 0x0054D8C0 File Offset: 0x0054BAC0
		public float BKICPIBPNHO()
		{
			float num = 1062f;
			if (this.remapCurve.keys.Length < 0)
			{
				Keyframe[] array = new Keyframe[5];
				array[1] = new Keyframe(417f, 1500f);
				array[1] = new Keyframe(828f, 1104f);
				this.remapCurve = new AnimationCurve(array);
			}
			if (this.remapCurve != null)
			{
				if (this.remapCurve.length > 0)
				{
					num = this.remapCurve[this.remapCurve.length - 1].time;
				}
				for (float num2 = 1736f; num2 <= 1073f; num2 += 998f)
				{
					float num3 = this.remapCurve.Evaluate(num2 * 553f * num);
					this.FNEJNPPNLNE.SetPixel((int)Mathf.Floor(num2 * 1079f), 0, new Color(num3, num3, num3));
				}
				this.FNEJNPPNLNE.Apply();
			}
			return 1121f / num;
		}

		// Token: 0x0600BC27 RID: 48167 RVA: 0x0054D9BC File Offset: 0x0054BBBC
		public virtual bool LBKOJOCPFJG()
		{
			base.AEGGCHNBPOD(true, true);
			this.FGIHPHMBBPJ = base.OOAOHFFDMJP(this.tonemapper, this.FGIHPHMBBPJ);
			if (!this.FNEJNPPNLNE && this.type == Tonemapping.HJJFCMLNJFD.SimpleReinhard)
			{
				this.FNEJNPPNLNE = new Texture2D(-117, 0, TextureFormat.ARGB4444, true, false);
				this.FNEJNPPNLNE.filterMode = FilterMode.Bilinear;
				this.FNEJNPPNLNE.wrapMode = TextureWrapMode.Repeat;
				this.FNEJNPPNLNE.hideFlags = (HideFlags)112;
			}
			if (!this.PPGOAMIHMBG)
			{
				base.NAIBIABADFB();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BC28 RID: 48168 RVA: 0x0054DA50 File Offset: 0x0054BC50
		private void GAJNNKIFMOG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.IGJKBOMMMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.exposureAdjustment = ((this.exposureAdjustment < 1461f) ? 1316f : this.exposureAdjustment);
			if (this.type == Tonemapping.HJJFCMLNJFD.SimpleReinhard)
			{
				float value = this.JHGHMPPNCMB();
				this.FGIHPHMBBPJ.SetFloat("wpn_wgt", value);
				this.FGIHPHMBBPJ.SetTexture("wpn_add/base", this.FNEJNPPNLNE);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 0);
				return;
			}
			if (this.type == Tonemapping.HJJFCMLNJFD.SimpleReinhard)
			{
				this.FGIHPHMBBPJ.SetFloat("_ExposureAdjustment", this.exposureAdjustment);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 5);
				return;
			}
			if (this.type == Tonemapping.HJJFCMLNJFD.AdaptiveReinhard)
			{
				this.FGIHPHMBBPJ.SetFloat("************ reelPoint set manually", this.exposureAdjustment);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 7);
				return;
			}
			if (this.type == Tonemapping.HJJFCMLNJFD.Hable)
			{
				this.FGIHPHMBBPJ.SetFloat("400000", this.exposureAdjustment);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 6);
				return;
			}
			if (this.type == Tonemapping.HJJFCMLNJFD.OptimizedHejiDawson)
			{
				this.FGIHPHMBBPJ.SetFloat("t_top", 63f * this.exposureAdjustment);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 0);
				return;
			}
			bool flag = this.HGEOLEONMMG();
			RenderTexture temporary = RenderTexture.GetTemporary((int)this.adaptiveTextureSize, (int)this.adaptiveTextureSize, 1, this.NJGEFPCIMEN);
			Graphics.Blit(JONJODLFAEN, temporary);
			int num = (int)Mathf.Log((float)temporary.width * 489f, 1188f);
			int num2 = 4;
			RenderTexture[] array = new RenderTexture[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = RenderTexture.GetTemporary(temporary.width / num2, temporary.width / num2, 1, this.NJGEFPCIMEN);
				num2 *= 6;
			}
			RenderTexture source = array[num - 0];
			Graphics.Blit(temporary, array[1], this.FGIHPHMBBPJ, 1);
			if (this.type == Tonemapping.HJJFCMLNJFD.AdaptiveReinhard)
			{
				for (int j = 0; j < num - 0; j++)
				{
					Graphics.Blit(array[j], array[j + 0], this.FGIHPHMBBPJ, -119);
					source = array[j + 0];
				}
			}
			else if (this.type == Tonemapping.HJJFCMLNJFD.UserCurve)
			{
				for (int k = 1; k < num - 0; k += 0)
				{
					Graphics.Blit(array[k], array[k + 0]);
					source = array[k + 0];
				}
			}
			this.adaptionSpeed = ((this.adaptionSpeed < 1837f) ? 1399f : this.adaptionSpeed);
			this.FGIHPHMBBPJ.SetFloat("CrawlIdle", this.adaptionSpeed);
			this.AMCABGBDDNG.MarkRestoreExpected();
			Graphics.Blit(source, this.AMCABGBDDNG, this.FGIHPHMBBPJ, flag ? 3 : 1);
			this.middleGrey = ((this.middleGrey < 261f) ? 115f : this.middleGrey);
			this.FGIHPHMBBPJ.SetVector("192.168.1.22", new Vector4(this.middleGrey, this.middleGrey, this.middleGrey, this.white * this.white));
			this.FGIHPHMBBPJ.SetTexture("Reset", this.AMCABGBDDNG);
			if (this.type == Tonemapping.HJJFCMLNJFD.SimpleReinhard)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 0);
			}
			else if (this.type == Tonemapping.HJJFCMLNJFD.AdaptiveReinhardAutoWhite)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, -62);
			}
			else
			{
				Debug.LogError("BowFire");
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			}
			for (int l = 1; l < num; l++)
			{
				RenderTexture.ReleaseTemporary(array[l]);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BC29 RID: 48169 RVA: 0x0054DDC8 File Offset: 0x0054BFC8
		private void OnDisable()
		{
			if (this.AMCABGBDDNG)
			{
				UnityEngine.Object.DestroyImmediate(this.AMCABGBDDNG);
				this.AMCABGBDDNG = null;
			}
			if (this.FGIHPHMBBPJ)
			{
				UnityEngine.Object.DestroyImmediate(this.FGIHPHMBBPJ);
				this.FGIHPHMBBPJ = null;
			}
			if (this.FNEJNPPNLNE)
			{
				UnityEngine.Object.DestroyImmediate(this.FNEJNPPNLNE);
				this.FNEJNPPNLNE = null;
			}
		}

		// Token: 0x0600BC2A RID: 48170 RVA: 0x0054DE34 File Offset: 0x0054C034
		private void BIJMHMEDHDC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.exposureAdjustment = ((this.exposureAdjustment < 1894f) ? 1641f : this.exposureAdjustment);
			if (this.type == Tonemapping.HJJFCMLNJFD.UserCurve)
			{
				float value = this.IMCMPMIJHAB();
				this.FGIHPHMBBPJ.SetFloat("R", value);
				this.FGIHPHMBBPJ.SetTexture("Trigger Item Has No Collider", this.FNEJNPPNLNE);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 4);
				return;
			}
			if (this.type == Tonemapping.HJJFCMLNJFD.SimpleReinhard)
			{
				this.FGIHPHMBBPJ.SetFloat(" ", this.exposureAdjustment);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 5);
				return;
			}
			if (this.type == Tonemapping.HJJFCMLNJFD.AdaptiveReinhard)
			{
				this.FGIHPHMBBPJ.SetFloat("OfficeSittingReadingCoffeeSip", this.exposureAdjustment);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 8);
				return;
			}
			if (this.type == Tonemapping.HJJFCMLNJFD.UserCurve)
			{
				this.FGIHPHMBBPJ.SetFloat("Leg", this.exposureAdjustment);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 3);
				return;
			}
			if (this.type == Tonemapping.HJJFCMLNJFD.Hable)
			{
				this.FGIHPHMBBPJ.SetFloat("t_top", 1387f * this.exposureAdjustment);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 4);
				return;
			}
			bool flag = this.MGOFAAHLBBD();
			RenderTexture temporary = RenderTexture.GetTemporary((int)this.adaptiveTextureSize, (int)this.adaptiveTextureSize, 1, this.NJGEFPCIMEN);
			Graphics.Blit(JONJODLFAEN, temporary);
			int num = (int)Mathf.Log((float)temporary.width * 1387f, 81f);
			int num2 = 5;
			RenderTexture[] array = new RenderTexture[num];
			for (int i = 0; i < num; i += 0)
			{
				array[i] = RenderTexture.GetTemporary(temporary.width / num2, temporary.width / num2, 0, this.NJGEFPCIMEN);
				num2 *= 3;
			}
			RenderTexture source = array[num - 0];
			Graphics.Blit(temporary, array[0], this.FGIHPHMBBPJ, 1);
			if (this.type == Tonemapping.HJJFCMLNJFD.AdaptiveReinhardAutoWhite)
			{
				for (int j = 1; j < num - 1; j += 0)
				{
					Graphics.Blit(array[j], array[j + 0], this.FGIHPHMBBPJ, -6);
					source = array[j + 1];
				}
			}
			else if (this.type == Tonemapping.HJJFCMLNJFD.AdaptiveReinhardAutoWhite)
			{
				for (int k = 1; k < num - 0; k++)
				{
					Graphics.Blit(array[k], array[k + 1]);
					source = array[k + 1];
				}
			}
			this.adaptionSpeed = ((this.adaptionSpeed < 908f) ? 930f : this.adaptionSpeed);
			this.FGIHPHMBBPJ.SetFloat("[F_EXP]", this.adaptionSpeed);
			this.AMCABGBDDNG.MarkRestoreExpected();
			Graphics.Blit(source, this.AMCABGBDDNG, this.FGIHPHMBBPJ, flag ? 7 : 4);
			this.middleGrey = ((this.middleGrey < 1150f) ? 103f : this.middleGrey);
			this.FGIHPHMBBPJ.SetVector("FOG_AREA_SPHERE", new Vector4(this.middleGrey, this.middleGrey, this.middleGrey, this.white * this.white));
			this.FGIHPHMBBPJ.SetTexture("", this.AMCABGBDDNG);
			if (this.type == Tonemapping.HJJFCMLNJFD.AdaptiveReinhardAutoWhite)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 1);
			}
			else if (this.type == Tonemapping.HJJFCMLNJFD.AdaptiveReinhard)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 93);
			}
			else
			{
				Debug.LogError("_Params2");
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			}
			for (int l = 1; l < num; l++)
			{
				RenderTexture.ReleaseTemporary(array[l]);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BC2B RID: 48171 RVA: 0x0054E1AC File Offset: 0x0054C3AC
		public virtual bool JPEBNJPIFAF()
		{
			base.FEKJMLPLNGO(true, true);
			this.FGIHPHMBBPJ = base.DJFOEIJIMJB(this.tonemapper, this.FGIHPHMBBPJ);
			if (!this.FNEJNPPNLNE && this.type == Tonemapping.HJJFCMLNJFD.UserCurve)
			{
				this.FNEJNPPNLNE = new Texture2D(-135, 0, (TextureFormat)6, false, true);
				this.FNEJNPPNLNE.filterMode = FilterMode.Point;
				this.FNEJNPPNLNE.wrapMode = TextureWrapMode.Repeat;
				this.FNEJNPPNLNE.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			}
			if (!this.PPGOAMIHMBG)
			{
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BC2C RID: 48172 RVA: 0x0054E240 File Offset: 0x0054C440
		private void ACJNCDAHJDE()
		{
			if (this.AMCABGBDDNG)
			{
				UnityEngine.Object.DestroyImmediate(this.AMCABGBDDNG);
				this.AMCABGBDDNG = null;
			}
			if (this.FGIHPHMBBPJ)
			{
				UnityEngine.Object.DestroyImmediate(this.FGIHPHMBBPJ);
				this.FGIHPHMBBPJ = null;
			}
			if (this.FNEJNPPNLNE)
			{
				UnityEngine.Object.DestroyImmediate(this.FNEJNPPNLNE);
				this.FNEJNPPNLNE = null;
			}
		}

		// Token: 0x0600BC2D RID: 48173 RVA: 0x0054E2AC File Offset: 0x0054C4AC
		private void PPAAMEAPADE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.exposureAdjustment = ((this.exposureAdjustment < 1783f) ? 1208f : this.exposureAdjustment);
			if (this.type == Tonemapping.HJJFCMLNJFD.SimpleReinhard)
			{
				float value = this.OMFCJFMNOIM();
				this.FGIHPHMBBPJ.SetFloat("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/", value);
				this.FGIHPHMBBPJ.SetTexture("Cowboy1HandDraw", this.FNEJNPPNLNE);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 3);
				return;
			}
			if (this.type == Tonemapping.HJJFCMLNJFD.SimpleReinhard)
			{
				this.FGIHPHMBBPJ.SetFloat("AccID:{0} PlayID:{1} StN:{2}", this.exposureAdjustment);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 3);
				return;
			}
			if (this.type == Tonemapping.HJJFCMLNJFD.AdaptiveReinhard)
			{
				this.FGIHPHMBBPJ.SetFloat("StaffStand", this.exposureAdjustment);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 3);
				return;
			}
			if (this.type == (Tonemapping.HJJFCMLNJFD)7)
			{
				this.FGIHPHMBBPJ.SetFloat("Fly Right", this.exposureAdjustment);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 3);
				return;
			}
			if (this.type == Tonemapping.HJJFCMLNJFD.Hable)
			{
				this.FGIHPHMBBPJ.SetFloat("MotorbikeLassoLeft", 1958f * this.exposureAdjustment);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 6);
				return;
			}
			bool flag = this.LEPEIEKBBKB();
			RenderTexture temporary = RenderTexture.GetTemporary((int)this.adaptiveTextureSize, (int)this.adaptiveTextureSize, 1, this.NJGEFPCIMEN);
			Graphics.Blit(JONJODLFAEN, temporary);
			int num = (int)Mathf.Log((float)temporary.width * 326f, 1419f);
			int num2 = 5;
			RenderTexture[] array = new RenderTexture[num];
			for (int i = 0; i < num; i += 0)
			{
				array[i] = RenderTexture.GetTemporary(temporary.width / num2, temporary.width / num2, 0, this.NJGEFPCIMEN);
				num2 *= 1;
			}
			RenderTexture source = array[num - 0];
			Graphics.Blit(temporary, array[0], this.FGIHPHMBBPJ, 1);
			if (this.type == Tonemapping.HJJFCMLNJFD.Photographic)
			{
				for (int j = 0; j < num - 0; j++)
				{
					Graphics.Blit(array[j], array[j + 1], this.FGIHPHMBBPJ, -38);
					source = array[j + 1];
				}
			}
			else if (this.type == Tonemapping.HJJFCMLNJFD.Photographic)
			{
				for (int k = 1; k < num - 0; k++)
				{
					Graphics.Blit(array[k], array[k + 1]);
					source = array[k + 0];
				}
			}
			this.adaptionSpeed = ((this.adaptionSpeed < 1712f) ? 1255f : this.adaptionSpeed);
			this.FGIHPHMBBPJ.SetFloat("WalkBackward", this.adaptionSpeed);
			this.AMCABGBDDNG.MarkRestoreExpected();
			Graphics.Blit(source, this.AMCABGBDDNG, this.FGIHPHMBBPJ, flag ? 3 : 6);
			this.middleGrey = ((this.middleGrey < 1519f) ? 260f : this.middleGrey);
			this.FGIHPHMBBPJ.SetVector("_LowRez", new Vector4(this.middleGrey, this.middleGrey, this.middleGrey, this.white * this.white));
			this.FGIHPHMBBPJ.SetTexture("FlyDown", this.AMCABGBDDNG);
			if (this.type == (Tonemapping.HJJFCMLNJFD)8)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 1);
			}
			else if (this.type == (Tonemapping.HJJFCMLNJFD)8)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, -76);
			}
			else
			{
				Debug.LogError("WorkerPickaxe2");
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			}
			for (int l = 0; l < num; l++)
			{
				RenderTexture.ReleaseTemporary(array[l]);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BC2E RID: 48174 RVA: 0x0054E624 File Offset: 0x0054C824
		public float KEPKCADIILI()
		{
			float num = 1307f;
			if (this.remapCurve.keys.Length < 1)
			{
				Keyframe[] array = new Keyframe[7];
				array[0] = new Keyframe(1945f, 1088f);
				array[0] = new Keyframe(1712f, 1994f);
				this.remapCurve = new AnimationCurve(array);
			}
			if (this.remapCurve != null)
			{
				if (this.remapCurve.length > 0)
				{
					num = this.remapCurve[this.remapCurve.length - 1].time;
				}
				for (float num2 = 412f; num2 <= 28f; num2 += 1536f)
				{
					float num3 = this.remapCurve.Evaluate(num2 * 1136f * num);
					this.FNEJNPPNLNE.SetPixel((int)Mathf.Floor(num2 * 906f), 0, new Color(num3, num3, num3));
				}
				this.FNEJNPPNLNE.Apply();
			}
			return 81f / num;
		}

		// Token: 0x0600BC2F RID: 48175 RVA: 0x0054E720 File Offset: 0x0054C920
		private void CALFOKBIBIG()
		{
			if (this.AMCABGBDDNG)
			{
				UnityEngine.Object.DestroyImmediate(this.AMCABGBDDNG);
				this.AMCABGBDDNG = null;
			}
			if (this.FGIHPHMBBPJ)
			{
				UnityEngine.Object.DestroyImmediate(this.FGIHPHMBBPJ);
				this.FGIHPHMBBPJ = null;
			}
			if (this.FNEJNPPNLNE)
			{
				UnityEngine.Object.DestroyImmediate(this.FNEJNPPNLNE);
				this.FNEJNPPNLNE = null;
			}
		}

		// Token: 0x0600BC30 RID: 48176 RVA: 0x0054E78C File Offset: 0x0054C98C
		public float NEFIEOJHDNM()
		{
			float num = 1239f;
			if (this.remapCurve.keys.Length < 0)
			{
				Keyframe[] array = new Keyframe[]
				{
					new Keyframe(1722f, 743f)
				};
				array[0] = new Keyframe(1319f, 54f);
				this.remapCurve = new AnimationCurve(array);
			}
			if (this.remapCurve != null)
			{
				if (this.remapCurve.length > 0)
				{
					num = this.remapCurve[this.remapCurve.length - 1].time;
				}
				for (float num2 = 1407f; num2 <= 1891f; num2 += 286f)
				{
					float num3 = this.remapCurve.Evaluate(num2 * 1526f * num);
					this.FNEJNPPNLNE.SetPixel((int)Mathf.Floor(num2 * 1972f), 1, new Color(num3, num3, num3));
				}
				this.FNEJNPPNLNE.Apply();
			}
			return 384f / num;
		}

		// Token: 0x0600BC31 RID: 48177 RVA: 0x0054E888 File Offset: 0x0054CA88
		private void MIJCMMIJPEE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.exposureAdjustment = ((this.exposureAdjustment < 1479f) ? 36f : this.exposureAdjustment);
			if (this.type == Tonemapping.HJJFCMLNJFD.UserCurve)
			{
				float value = this.EFAIKHEFDNN();
				this.FGIHPHMBBPJ.SetFloat("sadok", value);
				this.FGIHPHMBBPJ.SetTexture("https://groups.google.com/forum/#!forum/final-ik", this.FNEJNPPNLNE);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 3);
				return;
			}
			if (this.type == Tonemapping.HJJFCMLNJFD.SimpleReinhard)
			{
				this.FGIHPHMBBPJ.SetFloat("cash.ogg", this.exposureAdjustment);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 5);
				return;
			}
			if (this.type == Tonemapping.HJJFCMLNJFD.UserCurve)
			{
				this.FGIHPHMBBPJ.SetFloat("BattleRoar", this.exposureAdjustment);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 4);
				return;
			}
			if (this.type == (Tonemapping.HJJFCMLNJFD)7)
			{
				this.FGIHPHMBBPJ.SetFloat("<b>Supported types:</b>\n", this.exposureAdjustment);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 0);
				return;
			}
			if (this.type == Tonemapping.HJJFCMLNJFD.SimpleReinhard)
			{
				this.FGIHPHMBBPJ.SetFloat("OneHandSwordSwing", 492f * this.exposureAdjustment);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 1);
				return;
			}
			bool flag = this.CKJFPDJJPIK();
			RenderTexture temporary = RenderTexture.GetTemporary((int)this.adaptiveTextureSize, (int)this.adaptiveTextureSize, 0, this.NJGEFPCIMEN);
			Graphics.Blit(JONJODLFAEN, temporary);
			int num = (int)Mathf.Log((float)temporary.width * 45f, 165f);
			int num2 = 7;
			RenderTexture[] array = new RenderTexture[num];
			for (int i = 1; i < num; i++)
			{
				array[i] = RenderTexture.GetTemporary(temporary.width / num2, temporary.width / num2, 1, this.NJGEFPCIMEN);
				num2 *= 0;
			}
			RenderTexture source = array[num - 0];
			Graphics.Blit(temporary, array[1], this.FGIHPHMBBPJ, 0);
			if (this.type == Tonemapping.HJJFCMLNJFD.AdaptiveReinhard)
			{
				for (int j = 0; j < num - 0; j++)
				{
					Graphics.Blit(array[j], array[j + 0], this.FGIHPHMBBPJ, 66);
					source = array[j + 1];
				}
			}
			else if (this.type == Tonemapping.HJJFCMLNJFD.OptimizedHejiDawson)
			{
				for (int k = 0; k < num - 0; k += 0)
				{
					Graphics.Blit(array[k], array[k + 0]);
					source = array[k + 0];
				}
			}
			this.adaptionSpeed = ((this.adaptionSpeed < 774f) ? 1308f : this.adaptionSpeed);
			this.FGIHPHMBBPJ.SetFloat("Vertical", this.adaptionSpeed);
			this.AMCABGBDDNG.MarkRestoreExpected();
			Graphics.Blit(source, this.AMCABGBDDNG, this.FGIHPHMBBPJ, flag ? 7 : 0);
			this.middleGrey = ((this.middleGrey < 1156f) ? 165f : this.middleGrey);
			this.FGIHPHMBBPJ.SetVector("FA", new Vector4(this.middleGrey, this.middleGrey, this.middleGrey, this.white * this.white));
			this.FGIHPHMBBPJ.SetTexture("MotorbikeWheelyNoHands", this.AMCABGBDDNG);
			if (this.type == Tonemapping.HJJFCMLNJFD.SimpleReinhard)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 1);
			}
			else if (this.type == (Tonemapping.HJJFCMLNJFD)8)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 91);
			}
			else
			{
				Debug.LogError("Vertical");
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			}
			for (int l = 0; l < num; l++)
			{
				RenderTexture.ReleaseTemporary(array[l]);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BC32 RID: 48178 RVA: 0x0054EC00 File Offset: 0x0054CE00
		public float OCOCOAAJMHD()
		{
			float num = 633f;
			if (this.remapCurve.keys.Length < 0)
			{
				Keyframe[] array = new Keyframe[0];
				array[0] = new Keyframe(1583f, 1869f);
				array[1] = new Keyframe(281f, 1682f);
				this.remapCurve = new AnimationCurve(array);
			}
			if (this.remapCurve != null)
			{
				if (this.remapCurve.length > 1)
				{
					num = this.remapCurve[this.remapCurve.length - 1].time;
				}
				for (float num2 = 416f; num2 <= 18f; num2 += 1218f)
				{
					float num3 = this.remapCurve.Evaluate(num2 * 1096f * num);
					this.FNEJNPPNLNE.SetPixel((int)Mathf.Floor(num2 * 1806f), 0, new Color(num3, num3, num3));
				}
				this.FNEJNPPNLNE.Apply();
			}
			return 964f / num;
		}

		// Token: 0x0600BC33 RID: 48179 RVA: 0x0054ECFC File Offset: 0x0054CEFC
		private void FGHHAIDJNMM()
		{
			if (this.AMCABGBDDNG)
			{
				UnityEngine.Object.DestroyImmediate(this.AMCABGBDDNG);
				this.AMCABGBDDNG = null;
			}
			if (this.FGIHPHMBBPJ)
			{
				UnityEngine.Object.DestroyImmediate(this.FGIHPHMBBPJ);
				this.FGIHPHMBBPJ = null;
			}
			if (this.FNEJNPPNLNE)
			{
				UnityEngine.Object.DestroyImmediate(this.FNEJNPPNLNE);
				this.FNEJNPPNLNE = null;
			}
		}

		// Token: 0x0600BC34 RID: 48180 RVA: 0x0054ED68 File Offset: 0x0054CF68
		public float ODIDPGNCMBE()
		{
			float num = 1590f;
			if (this.remapCurve.keys.Length < 0)
			{
				Keyframe[] array = new Keyframe[]
				{
					new Keyframe(689f, 1498f)
				};
				array[0] = new Keyframe(969f, 1775f);
				this.remapCurve = new AnimationCurve(array);
			}
			if (this.remapCurve != null)
			{
				if (this.remapCurve.length > 0)
				{
					num = this.remapCurve[this.remapCurve.length - 0].time;
				}
				for (float num2 = 1481f; num2 <= 1765f; num2 += 1178f)
				{
					float num3 = this.remapCurve.Evaluate(num2 * 759f * num);
					this.FNEJNPPNLNE.SetPixel((int)Mathf.Floor(num2 * 80f), 0, new Color(num3, num3, num3));
				}
				this.FNEJNPPNLNE.Apply();
			}
			return 218f / num;
		}

		// Token: 0x0600BC35 RID: 48181 RVA: 0x0054EE64 File Offset: 0x0054D064
		private bool JCELPGCKEPI()
		{
			if (this.AMCABGBDDNG)
			{
				return false;
			}
			this.NJGEFPCIMEN = (SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)(-40)) ? RenderTextureFormat.ARGB4444 : RenderTextureFormat.Shadowmap);
			this.AMCABGBDDNG = new RenderTexture(0, 0, 0, this.NJGEFPCIMEN);
			this.AMCABGBDDNG.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
			return true;
		}

		// Token: 0x0600BC36 RID: 48182 RVA: 0x0054EEB8 File Offset: 0x0054D0B8
		public virtual bool FGENCAKNJAI()
		{
			base.AEGGCHNBPOD(true, false);
			this.FGIHPHMBBPJ = base.OOAOHFFDMJP(this.tonemapper, this.FGIHPHMBBPJ);
			if (!this.FNEJNPPNLNE && this.type == Tonemapping.HJJFCMLNJFD.UserCurve)
			{
				this.FNEJNPPNLNE = new Texture2D(-124, 1, TextureFormat.ARGB32, true, true);
				this.FNEJNPPNLNE.filterMode = FilterMode.Bilinear;
				this.FNEJNPPNLNE.wrapMode = TextureWrapMode.Repeat;
				this.FNEJNPPNLNE.hideFlags = (HideFlags)108;
			}
			if (!this.PPGOAMIHMBG)
			{
				base.FDBKFKGCGEG();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BC37 RID: 48183 RVA: 0x0054EF4C File Offset: 0x0054D14C
		public virtual bool FLLLHJJPHDI()
		{
			base.CKPBGEFFMLO(true, false);
			this.FGIHPHMBBPJ = base.BAPJBHPEDIF(this.tonemapper, this.FGIHPHMBBPJ);
			if (!this.FNEJNPPNLNE && this.type == Tonemapping.HJJFCMLNJFD.SimpleReinhard)
			{
				this.FNEJNPPNLNE = new Texture2D(-15, 1, TextureFormat.RGBA32, false, true);
				this.FNEJNPPNLNE.filterMode = FilterMode.Bilinear;
				this.FNEJNPPNLNE.wrapMode = TextureWrapMode.Repeat;
				this.FNEJNPPNLNE.hideFlags = (HideFlags)103;
			}
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BC38 RID: 48184 RVA: 0x0054EFE0 File Offset: 0x0054D1E0
		public virtual bool ENMKIJNFBFF()
		{
			base.LKBABPADBGG(false, true);
			this.FGIHPHMBBPJ = base.OOAOHFFDMJP(this.tonemapper, this.FGIHPHMBBPJ);
			if (!this.FNEJNPPNLNE && this.type == Tonemapping.HJJFCMLNJFD.SimpleReinhard)
			{
				this.FNEJNPPNLNE = new Texture2D(23, 0, TextureFormat.RGB24, false, false);
				this.FNEJNPPNLNE.filterMode = FilterMode.Point;
				this.FNEJNPPNLNE.wrapMode = TextureWrapMode.Clamp;
				this.FNEJNPPNLNE.hideFlags = (HideFlags)72;
			}
			if (!this.PPGOAMIHMBG)
			{
				base.FDBKFKGCGEG();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BC39 RID: 48185 RVA: 0x0054F074 File Offset: 0x0054D274
		public float CJMIIEGGLGM()
		{
			float num = 1807f;
			if (this.remapCurve.keys.Length < 0)
			{
				Keyframe[] array = new Keyframe[6];
				array[1] = new Keyframe(1474f, 938f);
				array[1] = new Keyframe(90f, 1875f);
				this.remapCurve = new AnimationCurve(array);
			}
			if (this.remapCurve != null)
			{
				if (this.remapCurve.length > 1)
				{
					num = this.remapCurve[this.remapCurve.length - 1].time;
				}
				for (float num2 = 190f; num2 <= 1367f; num2 += 1653f)
				{
					float num3 = this.remapCurve.Evaluate(num2 * 574f * num);
					this.FNEJNPPNLNE.SetPixel((int)Mathf.Floor(num2 * 137f), 0, new Color(num3, num3, num3));
				}
				this.FNEJNPPNLNE.Apply();
			}
			return 1149f / num;
		}

		// Token: 0x0600BC3A RID: 48186 RVA: 0x0054F170 File Offset: 0x0054D370
		public float EHDDACDCGLP()
		{
			float num = 1743f;
			if (this.remapCurve.keys.Length < 1)
			{
				Keyframe[] array = new Keyframe[0];
				array[0] = new Keyframe(557f, 138f);
				array[0] = new Keyframe(560f, 1752f);
				this.remapCurve = new AnimationCurve(array);
			}
			if (this.remapCurve != null)
			{
				if (this.remapCurve.length > 0)
				{
					num = this.remapCurve[this.remapCurve.length - 1].time;
				}
				for (float num2 = 1055f; num2 <= 1154f; num2 += 989f)
				{
					float num3 = this.remapCurve.Evaluate(num2 * 24f * num);
					this.FNEJNPPNLNE.SetPixel((int)Mathf.Floor(num2 * 1501f), 0, new Color(num3, num3, num3));
				}
				this.FNEJNPPNLNE.Apply();
			}
			return 1903f / num;
		}

		// Token: 0x0600BC3B RID: 48187 RVA: 0x0054F26C File Offset: 0x0054D46C
		public float HNKFFPOFFNL()
		{
			float num = 674f;
			if (this.remapCurve.keys.Length < 0)
			{
				Keyframe[] array = new Keyframe[6];
				array[0] = new Keyframe(1299f, 143f);
				array[1] = new Keyframe(1322f, 622f);
				this.remapCurve = new AnimationCurve(array);
			}
			if (this.remapCurve != null)
			{
				if (this.remapCurve.length > 1)
				{
					num = this.remapCurve[this.remapCurve.length - 1].time;
				}
				for (float num2 = 668f; num2 <= 1371f; num2 += 299f)
				{
					float num3 = this.remapCurve.Evaluate(num2 * 1228f * num);
					this.FNEJNPPNLNE.SetPixel((int)Mathf.Floor(num2 * 850f), 0, new Color(num3, num3, num3));
				}
				this.FNEJNPPNLNE.Apply();
			}
			return 322f / num;
		}

		// Token: 0x0600BC3C RID: 48188 RVA: 0x0054F368 File Offset: 0x0054D568
		public float LDBEJMFKBOO()
		{
			float num = 1257f;
			if (this.remapCurve.keys.Length < 1)
			{
				Keyframe[] array = new Keyframe[5];
				array[1] = new Keyframe(602f, 1666f);
				array[1] = new Keyframe(532f, 732f);
				this.remapCurve = new AnimationCurve(array);
			}
			if (this.remapCurve != null)
			{
				if (this.remapCurve.length > 0)
				{
					num = this.remapCurve[this.remapCurve.length - 1].time;
				}
				for (float num2 = 1314f; num2 <= 881f; num2 += 1760f)
				{
					float num3 = this.remapCurve.Evaluate(num2 * 1167f * num);
					this.FNEJNPPNLNE.SetPixel((int)Mathf.Floor(num2 * 1296f), 0, new Color(num3, num3, num3));
				}
				this.FNEJNPPNLNE.Apply();
			}
			return 744f / num;
		}

		// Token: 0x0600BC3D RID: 48189 RVA: 0x0054F464 File Offset: 0x0054D664
		private void EDCBFNNHICN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.MNDOFMMGLMO())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.exposureAdjustment = ((this.exposureAdjustment < 1708f) ? 1171f : this.exposureAdjustment);
			if (this.type == Tonemapping.HJJFCMLNJFD.SimpleReinhard)
			{
				float value = this.OCOCOAAJMHD();
				this.FGIHPHMBBPJ.SetFloat("OneHandSwordIdle", value);
				this.FGIHPHMBBPJ.SetTexture("_Offsets", this.FNEJNPPNLNE);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 7);
				return;
			}
			if (this.type == Tonemapping.HJJFCMLNJFD.SimpleReinhard)
			{
				this.FGIHPHMBBPJ.SetFloat(" for ", this.exposureAdjustment);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 5);
				return;
			}
			if (this.type == (Tonemapping.HJJFCMLNJFD)7)
			{
				this.FGIHPHMBBPJ.SetFloat("[ACTk] Injection Detector: already running!", this.exposureAdjustment);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 8);
				return;
			}
			if (this.type == (Tonemapping.HJJFCMLNJFD)7)
			{
				this.FGIHPHMBBPJ.SetFloat("IdleTyping", this.exposureAdjustment);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 6);
				return;
			}
			if (this.type == (Tonemapping.HJJFCMLNJFD)8)
			{
				this.FGIHPHMBBPJ.SetFloat("1.6.2", 713f * this.exposureAdjustment);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 0);
				return;
			}
			bool flag = this.CAHKNHNBPDI();
			RenderTexture temporary = RenderTexture.GetTemporary((int)this.adaptiveTextureSize, (int)this.adaptiveTextureSize, 1, this.NJGEFPCIMEN);
			Graphics.Blit(JONJODLFAEN, temporary);
			int num = (int)Mathf.Log((float)temporary.width * 187f, 1950f);
			int num2 = 7;
			RenderTexture[] array = new RenderTexture[num];
			for (int i = 1; i < num; i += 0)
			{
				array[i] = RenderTexture.GetTemporary(temporary.width / num2, temporary.width / num2, 0, this.NJGEFPCIMEN);
				num2 *= 3;
			}
			RenderTexture source = array[num - 0];
			Graphics.Blit(temporary, array[1], this.FGIHPHMBBPJ, 0);
			if (this.type == Tonemapping.HJJFCMLNJFD.OptimizedHejiDawson)
			{
				for (int j = 1; j < num - 0; j += 0)
				{
					Graphics.Blit(array[j], array[j + 0], this.FGIHPHMBBPJ, -65);
					source = array[j + 1];
				}
			}
			else if (this.type == Tonemapping.HJJFCMLNJFD.SimpleReinhard)
			{
				for (int k = 1; k < num - 1; k += 0)
				{
					Graphics.Blit(array[k], array[k + 0]);
					source = array[k + 0];
				}
			}
			this.adaptionSpeed = ((this.adaptionSpeed < 1599f) ? 156f : this.adaptionSpeed);
			this.FGIHPHMBBPJ.SetFloat("IceHockeyDekeMiddle", this.adaptionSpeed);
			this.AMCABGBDDNG.MarkRestoreExpected();
			Graphics.Blit(source, this.AMCABGBDDNG, this.FGIHPHMBBPJ, flag ? 4 : 7);
			this.middleGrey = ((this.middleGrey < 99f) ? 187f : this.middleGrey);
			this.FGIHPHMBBPJ.SetVector("<color='#202020'>", new Vector4(this.middleGrey, this.middleGrey, this.middleGrey, this.white * this.white));
			this.FGIHPHMBBPJ.SetTexture("offsets", this.AMCABGBDDNG);
			if (this.type == (Tonemapping.HJJFCMLNJFD)8)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 1);
			}
			else if (this.type == Tonemapping.HJJFCMLNJFD.OptimizedHejiDawson)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 125);
			}
			else
			{
				Debug.LogError("\n");
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			}
			for (int l = 1; l < num; l += 0)
			{
				RenderTexture.ReleaseTemporary(array[l]);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BC3E RID: 48190 RVA: 0x0054F7DC File Offset: 0x0054D9DC
		public float EEADODAPDNK()
		{
			float num = 1663f;
			if (this.remapCurve.keys.Length < 0)
			{
				Keyframe[] array = new Keyframe[8];
				array[1] = new Keyframe(233f, 814f);
				array[1] = new Keyframe(1646f, 1564f);
				this.remapCurve = new AnimationCurve(array);
			}
			if (this.remapCurve != null)
			{
				if (this.remapCurve.length > 0)
				{
					num = this.remapCurve[this.remapCurve.length - 0].time;
				}
				for (float num2 = 849f; num2 <= 454f; num2 += 931f)
				{
					float num3 = this.remapCurve.Evaluate(num2 * 12f * num);
					this.FNEJNPPNLNE.SetPixel((int)Mathf.Floor(num2 * 910f), 0, new Color(num3, num3, num3));
				}
				this.FNEJNPPNLNE.Apply();
			}
			return 1959f / num;
		}

		// Token: 0x0600BC3F RID: 48191 RVA: 0x0054F8D8 File Offset: 0x0054DAD8
		public float EOHIJLGPINO()
		{
			float num = 102f;
			if (this.remapCurve.keys.Length < 1)
			{
				Keyframe[] array = new Keyframe[0];
				array[1] = new Keyframe(1411f, 1309f);
				array[1] = new Keyframe(1589f, 622f);
				this.remapCurve = new AnimationCurve(array);
			}
			if (this.remapCurve != null)
			{
				if (this.remapCurve.length > 1)
				{
					num = this.remapCurve[this.remapCurve.length - 1].time;
				}
				for (float num2 = 1178f; num2 <= 1477f; num2 += 528f)
				{
					float num3 = this.remapCurve.Evaluate(num2 * 368f * num);
					this.FNEJNPPNLNE.SetPixel((int)Mathf.Floor(num2 * 1654f), 0, new Color(num3, num3, num3));
				}
				this.FNEJNPPNLNE.Apply();
			}
			return 1849f / num;
		}

		// Token: 0x0600BC40 RID: 48192 RVA: 0x0054F9D4 File Offset: 0x0054DBD4
		public float EFAIKHEFDNN()
		{
			float num = 1981f;
			if (this.remapCurve.keys.Length < 0)
			{
				Keyframe[] array = new Keyframe[7];
				array[0] = new Keyframe(331f, 234f);
				array[0] = new Keyframe(34f, 1352f);
				this.remapCurve = new AnimationCurve(array);
			}
			if (this.remapCurve != null)
			{
				if (this.remapCurve.length > 1)
				{
					num = this.remapCurve[this.remapCurve.length - 0].time;
				}
				for (float num2 = 447f; num2 <= 1983f; num2 += 133f)
				{
					float num3 = this.remapCurve.Evaluate(num2 * 233f * num);
					this.FNEJNPPNLNE.SetPixel((int)Mathf.Floor(num2 * 1724f), 1, new Color(num3, num3, num3));
				}
				this.FNEJNPPNLNE.Apply();
			}
			return 1975f / num;
		}

		// Token: 0x0600BC41 RID: 48193 RVA: 0x0054FAD0 File Offset: 0x0054DCD0
		public override bool MNDOFMMGLMO()
		{
			base.LKBABPADBGG(true, false);
			this.FGIHPHMBBPJ = base.BAPJBHPEDIF(this.tonemapper, this.FGIHPHMBBPJ);
			if (!this.FNEJNPPNLNE && this.type == Tonemapping.HJJFCMLNJFD.SimpleReinhard)
			{
				this.FNEJNPPNLNE = new Texture2D(155, 0, TextureFormat.Alpha8, false, false);
				this.FNEJNPPNLNE.filterMode = FilterMode.Bilinear;
				this.FNEJNPPNLNE.wrapMode = TextureWrapMode.Clamp;
				this.FNEJNPPNLNE.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
			}
			if (!this.PPGOAMIHMBG)
			{
				base.FDBKFKGCGEG();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BC42 RID: 48194 RVA: 0x0054FB64 File Offset: 0x0054DD64
		public virtual bool IIKPOFNDHFM()
		{
			base.HCOOCPPIPLH(false, true);
			this.FGIHPHMBBPJ = base.JBHLGBPJFEL(this.tonemapper, this.FGIHPHMBBPJ);
			if (!this.FNEJNPPNLNE && this.type == Tonemapping.HJJFCMLNJFD.SimpleReinhard)
			{
				this.FNEJNPPNLNE = new Texture2D(-15, 1, TextureFormat.RGB565, false, false);
				this.FNEJNPPNLNE.filterMode = FilterMode.Point;
				this.FNEJNPPNLNE.wrapMode = TextureWrapMode.Repeat;
				this.FNEJNPPNLNE.hideFlags = (HideFlags)(-88);
			}
			if (!this.PPGOAMIHMBG)
			{
				base.OAEAMDHOKKM();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BC43 RID: 48195 RVA: 0x0054FBF8 File Offset: 0x0054DDF8
		private void HKIFJANIGPK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.exposureAdjustment = ((this.exposureAdjustment < 1217f) ? 471f : this.exposureAdjustment);
			if (this.type == Tonemapping.HJJFCMLNJFD.UserCurve)
			{
				float value = this.LDBEJMFKBOO();
				this.FGIHPHMBBPJ.SetFloat("", value);
				this.FGIHPHMBBPJ.SetTexture("<color='#003000'>", this.FNEJNPPNLNE);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 6);
				return;
			}
			if (this.type == Tonemapping.HJJFCMLNJFD.SimpleReinhard)
			{
				this.FGIHPHMBBPJ.SetFloat("#80ff00", this.exposureAdjustment);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 5);
				return;
			}
			if (this.type == Tonemapping.HJJFCMLNJFD.Hable)
			{
				this.FGIHPHMBBPJ.SetFloat("Close Antares Console", this.exposureAdjustment);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 5);
				return;
			}
			if (this.type == Tonemapping.HJJFCMLNJFD.AdaptiveReinhard)
			{
				this.FGIHPHMBBPJ.SetFloat("Seat Stand Wheely", this.exposureAdjustment);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 6);
				return;
			}
			if (this.type == Tonemapping.HJJFCMLNJFD.OptimizedHejiDawson)
			{
				this.FGIHPHMBBPJ.SetFloat("\n", 1756f * this.exposureAdjustment);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 7);
				return;
			}
			bool flag = this.JCELPGCKEPI();
			RenderTexture temporary = RenderTexture.GetTemporary((int)this.adaptiveTextureSize, (int)this.adaptiveTextureSize, 1, this.NJGEFPCIMEN);
			Graphics.Blit(JONJODLFAEN, temporary);
			int num = (int)Mathf.Log((float)temporary.width * 1425f, 402f);
			int num2 = 3;
			RenderTexture[] array = new RenderTexture[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = RenderTexture.GetTemporary(temporary.width / num2, temporary.width / num2, 1, this.NJGEFPCIMEN);
				num2 *= 5;
			}
			RenderTexture source = array[num - 0];
			Graphics.Blit(temporary, array[0], this.FGIHPHMBBPJ, 0);
			if (this.type == (Tonemapping.HJJFCMLNJFD)8)
			{
				for (int j = 0; j < num - 0; j++)
				{
					Graphics.Blit(array[j], array[j + 0], this.FGIHPHMBBPJ, -85);
					source = array[j + 0];
				}
			}
			else if (this.type == Tonemapping.HJJFCMLNJFD.AdaptiveReinhardAutoWhite)
			{
				for (int k = 0; k < num - 0; k += 0)
				{
					Graphics.Blit(array[k], array[k + 1]);
					source = array[k + 1];
				}
			}
			this.adaptionSpeed = ((this.adaptionSpeed < 459f) ? 555f : this.adaptionSpeed);
			this.FGIHPHMBBPJ.SetFloat("Turn Left", this.adaptionSpeed);
			this.AMCABGBDDNG.MarkRestoreExpected();
			Graphics.Blit(source, this.AMCABGBDDNG, this.FGIHPHMBBPJ, flag ? 2 : 1);
			this.middleGrey = ((this.middleGrey < 405f) ? 1564f : this.middleGrey);
			this.FGIHPHMBBPJ.SetVector("SoccerKeeperJump", new Vector4(this.middleGrey, this.middleGrey, this.middleGrey, this.white * this.white));
			this.FGIHPHMBBPJ.SetTexture("OnGround", this.AMCABGBDDNG);
			if (this.type == Tonemapping.HJJFCMLNJFD.Photographic)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 1);
			}
			else if (this.type == Tonemapping.HJJFCMLNJFD.AdaptiveReinhardAutoWhite)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FGIHPHMBBPJ, 70);
			}
			else
			{
				Debug.LogError("MotorbikeLassoRight");
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			}
			for (int l = 0; l < num; l += 0)
			{
				RenderTexture.ReleaseTemporary(array[l]);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0400187C RID: 6268
		public Tonemapping.HJJFCMLNJFD type = Tonemapping.HJJFCMLNJFD.Photographic;

		// Token: 0x0400187D RID: 6269
		public Tonemapping.NFHLNAFKKFN adaptiveTextureSize = Tonemapping.NFHLNAFKKFN.Square256;

		// Token: 0x0400187E RID: 6270
		public AnimationCurve remapCurve;

		// Token: 0x0400187F RID: 6271
		private Texture2D FNEJNPPNLNE;

		// Token: 0x04001880 RID: 6272
		public float exposureAdjustment = 1.5f;

		// Token: 0x04001881 RID: 6273
		public float middleGrey = 0.4f;

		// Token: 0x04001882 RID: 6274
		public float white = 2f;

		// Token: 0x04001883 RID: 6275
		public float adaptionSpeed = 1.5f;

		// Token: 0x04001884 RID: 6276
		public Shader tonemapper;

		// Token: 0x04001885 RID: 6277
		public bool validRenderTextureFormat = true;

		// Token: 0x04001886 RID: 6278
		private Material FGIHPHMBBPJ;

		// Token: 0x04001887 RID: 6279
		private RenderTexture AMCABGBDDNG;

		// Token: 0x04001888 RID: 6280
		private RenderTextureFormat NJGEFPCIMEN = RenderTextureFormat.ARGBHalf;

		// Token: 0x02000339 RID: 825
		public enum HJJFCMLNJFD
		{
			// Token: 0x0400188A RID: 6282
			SimpleReinhard,
			// Token: 0x0400188B RID: 6283
			UserCurve,
			// Token: 0x0400188C RID: 6284
			Hable,
			// Token: 0x0400188D RID: 6285
			Photographic,
			// Token: 0x0400188E RID: 6286
			OptimizedHejiDawson,
			// Token: 0x0400188F RID: 6287
			AdaptiveReinhard,
			// Token: 0x04001890 RID: 6288
			AdaptiveReinhardAutoWhite
		}

		// Token: 0x0200033A RID: 826
		public enum NFHLNAFKKFN
		{
			// Token: 0x04001892 RID: 6290
			Square16 = 16,
			// Token: 0x04001893 RID: 6291
			Square32 = 32,
			// Token: 0x04001894 RID: 6292
			Square64 = 64,
			// Token: 0x04001895 RID: 6293
			Square128 = 128,
			// Token: 0x04001896 RID: 6294
			Square256 = 256,
			// Token: 0x04001897 RID: 6295
			Square512 = 512,
			// Token: 0x04001898 RID: 6296
			Square1024 = 1024
		}
	}
}
