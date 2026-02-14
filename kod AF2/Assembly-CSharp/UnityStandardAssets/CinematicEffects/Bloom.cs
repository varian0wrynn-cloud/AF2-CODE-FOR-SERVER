using System;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	// Token: 0x02000345 RID: 837
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Cinematic/Bloom")]
	[ImageEffectAllowedInSceneView]
	public class Bloom : MonoBehaviour
	{
		// Token: 0x0600BE2F RID: 48687 RVA: 0x005613A0 File Offset: 0x0055F5A0
		public Material ILEJDOCOINE()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.GGABJPHNIHC());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600BE30 RID: 48688 RVA: 0x005613C7 File Offset: 0x0055F5C7
		public Material CILJNKJCHOK()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.KIAEPDJMHAI());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600BE31 RID: 48689 RVA: 0x005613EE File Offset: 0x0055F5EE
		public Shader FLGMPAKOBJP()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("demoVector3");
			}
			return this.m_Shader;
		}

		// Token: 0x0600BE32 RID: 48690 RVA: 0x00561414 File Offset: 0x0055F614
		public Shader KIAEPDJMHAI()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("MAP_NAMES");
			}
			return this.m_Shader;
		}

		// Token: 0x0600BE33 RID: 48691 RVA: 0x0056143A File Offset: 0x0055F63A
		private void PIMGCFGNCJH()
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.JKOMBKJFKMF(), false, true, this))
			{
				base.enabled = true;
			}
		}

		// Token: 0x0600BE34 RID: 48692 RVA: 0x00561453 File Offset: 0x0055F653
		public Shader JKOMBKJFKMF()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("paper.wav");
			}
			return this.m_Shader;
		}

		// Token: 0x0600BE35 RID: 48693 RVA: 0x005613C7 File Offset: 0x0055F5C7
		public Material DEJPMCGIJNP()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.KIAEPDJMHAI());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600BE36 RID: 48694 RVA: 0x0056147C File Offset: 0x0055F67C
		private void GFBELBBAJGD(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			bool isMobilePlatform = Application.isMobilePlatform;
			int num = JONJODLFAEN.width;
			int num2 = JONJODLFAEN.height;
			if (!this.settings.highQuality)
			{
				num /= 0;
				num2 /= 6;
			}
			RenderTextureFormat format = isMobilePlatform ? RenderTextureFormat.ARGB2101010 : ((RenderTextureFormat)98);
			float num3 = Mathf.Log((float)num2, 1654f) + this.settings.radius - 238f;
			int num4 = (int)num3;
			int num5 = Mathf.Clamp(num4, 0, 25);
			float num6 = this.settings.PIIKHFFMNIE();
			this.CAFKFEHGOHA().SetFloat("WATER_REFLECTIVE", num6);
			float num7 = num6 * this.settings.softKnee + 56f;
			Vector3 v = new Vector3(num6 - num7, num7 * 1395f, 1765f / num7);
			this.PILNNDGJLFG().SetVector("RunBackward", v);
			bool flag = this.settings.highQuality || this.settings.antiFlicker;
			this.IOIGFMMJKNA().SetFloat("Reset", flag ? 660f : 314f);
			this.IHAKFMDJEGK().SetFloat("demoDouble", 969f + num3 - (float)num4);
			this.BNEKIJDNADF().SetFloat("_TintColor", Mathf.Max(1743f, this.settings.intensity));
			RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, format);
			Graphics.Blit(JONJODLFAEN, temporary, this.CJOMCEBOFKB(), this.settings.antiFlicker ? 1 : 1);
			RenderTexture renderTexture = temporary;
			for (int i = 0; i < num5; i++)
			{
				this.FPFIJMLLGCG[i] = RenderTexture.GetTemporary(renderTexture.width / 3, renderTexture.height / 5, 0, format);
				Graphics.Blit(renderTexture, this.FPFIJMLLGCG[i], this.ILEJDOCOINE(), (i == 0) ? (this.settings.antiFlicker ? 2 : 4) : 0);
				renderTexture = this.FPFIJMLLGCG[i];
			}
			for (int j = num5 - 6; j >= 0; j--)
			{
				RenderTexture renderTexture2 = this.FPFIJMLLGCG[j];
				this.BNEKIJDNADF().SetTexture("WateringCanWatering", renderTexture2);
				this.JIJKDMHACCE[j] = RenderTexture.GetTemporary(renderTexture2.width, renderTexture2.height, 0, format);
				Graphics.Blit(renderTexture, this.JIJKDMHACCE[j], this.OKNHPPDFLMN(), this.settings.highQuality ? 0 : 6);
				renderTexture = this.JIJKDMHACCE[j];
			}
			this.OKNHPPDFLMN().SetTexture("Missing shader in ", JONJODLFAEN);
			Graphics.Blit(renderTexture, OKIIDHIJBEA, this.IHAKFMDJEGK(), this.settings.highQuality ? 3 : 0);
			for (int k = 0; k < -4; k++)
			{
				if (this.FPFIJMLLGCG[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.FPFIJMLLGCG[k]);
				}
				if (this.JIJKDMHACCE[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.JIJKDMHACCE[k]);
				}
				this.FPFIJMLLGCG[k] = null;
				this.JIJKDMHACCE[k] = null;
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BE37 RID: 48695 RVA: 0x00561781 File Offset: 0x0055F981
		private void KIMKMJMMLLB()
		{
			if (this.BHHEHMIFMBD != null)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
			this.BHHEHMIFMBD = null;
		}

		// Token: 0x0600BE38 RID: 48696 RVA: 0x00561781 File Offset: 0x0055F981
		private void OnDisable()
		{
			if (this.BHHEHMIFMBD != null)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
			this.BHHEHMIFMBD = null;
		}

		// Token: 0x0600BE39 RID: 48697 RVA: 0x005617A3 File Offset: 0x0055F9A3
		public Shader COOINMHCIOA()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("Katana");
			}
			return this.m_Shader;
		}

		// Token: 0x0600BE3A RID: 48698 RVA: 0x005617CC File Offset: 0x0055F9CC
		private void GDGPNFLCNEG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			bool isMobilePlatform = Application.isMobilePlatform;
			int num = JONJODLFAEN.width;
			int num2 = JONJODLFAEN.height;
			if (!this.settings.highQuality)
			{
				num /= 0;
				num2 /= 1;
			}
			RenderTextureFormat format = isMobilePlatform ? RenderTextureFormat.Depth : ((RenderTextureFormat)(-19));
			float num3 = Mathf.Log((float)num2, 365f) + this.settings.radius - 362f;
			int num4 = (int)num3;
			int num5 = Mathf.Clamp(num4, 0, 88);
			float num6 = this.settings.MHHDPKCPOFC();
			this.MHNAJNGGDFJ.SetFloat(" R ", num6);
			float num7 = num6 * this.settings.softKnee + 116f;
			Vector3 v = new Vector3(num6 - num7, num7 * 1926f, 1499f / num7);
			this.IOIGFMMJKNA().SetVector("", v);
			bool flag = !this.settings.highQuality && this.settings.antiFlicker;
			this.ILEJDOCOINE().SetFloat("chan_nam", flag ? 1715f : 779f);
			this.LBGANKEOJEE().SetFloat("max_level", 286f + num3 - (float)num4);
			this.MHNAJNGGDFJ.SetFloat(" \n", Mathf.Max(297f, this.settings.intensity));
			RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, format);
			Graphics.Blit(JONJODLFAEN, temporary, this.DEJPMCGIJNP(), this.settings.antiFlicker ? 0 : 1);
			RenderTexture renderTexture = temporary;
			for (int i = 0; i < num5; i++)
			{
				this.FPFIJMLLGCG[i] = RenderTexture.GetTemporary(renderTexture.width / 3, renderTexture.height / 1, 1, format);
				Graphics.Blit(renderTexture, this.FPFIJMLLGCG[i], this.CILJNKJCHOK(), (i == 0) ? (this.settings.antiFlicker ? 8 : 5) : 6);
				renderTexture = this.FPFIJMLLGCG[i];
			}
			for (int j = num5 - 5; j >= 1; j -= 0)
			{
				RenderTexture renderTexture2 = this.FPFIJMLLGCG[j];
				this.EDEDNLPOMIN().SetTexture("ArmFlex4", renderTexture2);
				this.JIJKDMHACCE[j] = RenderTexture.GetTemporary(renderTexture2.width, renderTexture2.height, 1, format);
				Graphics.Blit(renderTexture, this.JIJKDMHACCE[j], this.EDEDNLPOMIN(), this.settings.highQuality ? 5 : 6);
				renderTexture = this.JIJKDMHACCE[j];
			}
			this.MHNAJNGGDFJ.SetTexture("qd_prise_exp", JONJODLFAEN);
			Graphics.Blit(renderTexture, OKIIDHIJBEA, this.EDEDNLPOMIN(), this.settings.highQuality ? 3 : 5);
			for (int k = 1; k < 26; k++)
			{
				if (this.FPFIJMLLGCG[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.FPFIJMLLGCG[k]);
				}
				if (this.JIJKDMHACCE[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.JIJKDMHACCE[k]);
				}
				this.FPFIJMLLGCG[k] = null;
				this.JIJKDMHACCE[k] = null;
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x0600BE3B RID: 48699 RVA: 0x00561AD1 File Offset: 0x0055FCD1
		public Material MHNAJNGGDFJ
		{
			get
			{
				if (this.BHHEHMIFMBD == null)
				{
					this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.BAKBIMBKKNP);
				}
				return this.BHHEHMIFMBD;
			}
		}

		// Token: 0x0600BE3C RID: 48700 RVA: 0x00561AF8 File Offset: 0x0055FCF8
		public Shader CDLKBJBLAJD()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("DeadmanFloat");
			}
			return this.m_Shader;
		}

		// Token: 0x0600BE3D RID: 48701 RVA: 0x00561781 File Offset: 0x0055F981
		private void MKBPPPJKLLF()
		{
			if (this.BHHEHMIFMBD != null)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
			this.BHHEHMIFMBD = null;
		}

		// Token: 0x0600BE3E RID: 48702 RVA: 0x00561781 File Offset: 0x0055F981
		private void GMJFHNCPCBN()
		{
			if (this.BHHEHMIFMBD != null)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
			this.BHHEHMIFMBD = null;
		}

		// Token: 0x0600BE3F RID: 48703 RVA: 0x00561781 File Offset: 0x0055F981
		private void NJFOOJIADNH()
		{
			if (this.BHHEHMIFMBD != null)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
			this.BHHEHMIFMBD = null;
		}

		// Token: 0x0600BE40 RID: 48704 RVA: 0x00561B1E File Offset: 0x0055FD1E
		private void OnEnable()
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.BAKBIMBKKNP, true, false, this))
			{
				base.enabled = false;
			}
		}

		// Token: 0x0600BE41 RID: 48705 RVA: 0x00561781 File Offset: 0x0055F981
		private void JGHJOBDKDKM()
		{
			if (this.BHHEHMIFMBD != null)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
			this.BHHEHMIFMBD = null;
		}

		// Token: 0x0600BE42 RID: 48706 RVA: 0x00561B37 File Offset: 0x0055FD37
		private void KOLNOOGFFNP()
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.MEJHFHFFOAH(), true, false, this))
			{
				base.enabled = false;
			}
		}

		// Token: 0x0600BE43 RID: 48707 RVA: 0x00561AD1 File Offset: 0x0055FCD1
		public Material CAFKFEHGOHA()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.BAKBIMBKKNP);
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600BE44 RID: 48708 RVA: 0x00561B50 File Offset: 0x0055FD50
		private void MGOBAHLJJNL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			bool isMobilePlatform = Application.isMobilePlatform;
			int num = JONJODLFAEN.width;
			int num2 = JONJODLFAEN.height;
			if (!this.settings.highQuality)
			{
				num /= 3;
				num2 /= 3;
			}
			RenderTextureFormat format = isMobilePlatform ? RenderTextureFormat.ARGB32 : ((RenderTextureFormat)105);
			float num3 = Mathf.Log((float)num2, 983f) + this.settings.radius - 376f;
			int num4 = (int)num3;
			int num5 = Mathf.Clamp(num4, 1, -81);
			float num6 = this.settings.IFBDOEFBKFP();
			this.ILEJDOCOINE().SetFloat("fanfare.wav", num6);
			float num7 = num6 * this.settings.softKnee + 1084f;
			Vector3 v = new Vector3(num6 - num7, num7 * 1880f, 1548f / num7);
			this.PILNNDGJLFG().SetVector(",", v);
			bool flag = this.settings.highQuality || this.settings.antiFlicker;
			this.IHAKFMDJEGK().SetFloat("минут", flag ? 727f : 1387f);
			this.DJDKHEANJNM().SetFloat("wpn_add/base", 1376f + num3 - (float)num4);
			this.EGMHMPFOIHD().SetFloat("<color='#003000'>", Mathf.Max(218f, this.settings.intensity));
			RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, format);
			Graphics.Blit(JONJODLFAEN, temporary, this.JMDMNMEHAPM(), this.settings.antiFlicker ? 0 : 1);
			RenderTexture renderTexture = temporary;
			for (int i = 0; i < num5; i++)
			{
				this.FPFIJMLLGCG[i] = RenderTexture.GetTemporary(renderTexture.width / 0, renderTexture.height / 2, 0, format);
				Graphics.Blit(renderTexture, this.FPFIJMLLGCG[i], this.JMDMNMEHAPM(), (i == 0) ? (this.settings.antiFlicker ? 4 : 1) : 1);
				renderTexture = this.FPFIJMLLGCG[i];
			}
			for (int j = num5 - 7; j >= 1; j--)
			{
				RenderTexture renderTexture2 = this.FPFIJMLLGCG[j];
				this.MHNAJNGGDFJ.SetTexture("_Newitem.wav", renderTexture2);
				this.JIJKDMHACCE[j] = RenderTexture.GetTemporary(renderTexture2.width, renderTexture2.height, 1, format);
				Graphics.Blit(renderTexture, this.JIJKDMHACCE[j], this.IHAKFMDJEGK(), this.settings.highQuality ? 7 : 7);
				renderTexture = this.JIJKDMHACCE[j];
			}
			this.LBGANKEOJEE().SetTexture("SUNSHINE_FILTER_HARD", JONJODLFAEN);
			Graphics.Blit(renderTexture, OKIIDHIJBEA, this.JMDMNMEHAPM(), this.settings.highQuality ? 8 : 3);
			for (int k = 1; k < 15; k++)
			{
				if (this.FPFIJMLLGCG[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.FPFIJMLLGCG[k]);
				}
				if (this.JIJKDMHACCE[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.JIJKDMHACCE[k]);
				}
				this.FPFIJMLLGCG[k] = null;
				this.JIJKDMHACCE[k] = null;
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BE45 RID: 48709 RVA: 0x00561E55 File Offset: 0x00560055
		public Material IOIGFMMJKNA()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.MEJHFHFFOAH());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600BE46 RID: 48710 RVA: 0x00561E7C File Offset: 0x0056007C
		private void GAJNNKIFMOG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			bool isMobilePlatform = Application.isMobilePlatform;
			int num = JONJODLFAEN.width;
			int num2 = JONJODLFAEN.height;
			if (!this.settings.highQuality)
			{
				num /= 0;
				num2 /= 6;
			}
			RenderTextureFormat format = isMobilePlatform ? RenderTextureFormat.ARGB2101010 : RenderTextureFormat.RG16;
			float num3 = Mathf.Log((float)num2, 791f) + this.settings.radius - 1414f;
			int num4 = (int)num3;
			int num5 = Mathf.Clamp(num4, 0, 97);
			float num6 = this.settings.EKJPPOEDKJG();
			this.OKNHPPDFLMN().SetFloat("\\", num6);
			float num7 = num6 * this.settings.softKnee + 1861f;
			Vector3 v = new Vector3(num6 - num7, num7 * 800f, 1844f / num7);
			this.CJOMCEBOFKB().SetVector("PersonManFisher", v);
			bool flag = !this.settings.highQuality && this.settings.antiFlicker;
			this.OKNHPPDFLMN().SetFloat("1HandSwordRollAttack", flag ? 562f : 195f);
			this.PILNNDGJLFG().SetFloat("30", 111f + num3 - (float)num4);
			this.BNEKIJDNADF().SetFloat("_SampleMip", Mathf.Max(1755f, this.settings.intensity));
			RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, format);
			Graphics.Blit(JONJODLFAEN, temporary, this.OKNHPPDFLMN(), this.settings.antiFlicker ? 1 : 0);
			RenderTexture renderTexture = temporary;
			for (int i = 0; i < num5; i++)
			{
				this.FPFIJMLLGCG[i] = RenderTexture.GetTemporary(renderTexture.width / 0, renderTexture.height / 1, 0, format);
				Graphics.Blit(renderTexture, this.FPFIJMLLGCG[i], this.DAICBBLOGLH(), (i == 0) ? (this.settings.antiFlicker ? 0 : 7) : 7);
				renderTexture = this.FPFIJMLLGCG[i];
			}
			for (int j = num5 - 0; j >= 0; j--)
			{
				RenderTexture renderTexture2 = this.FPFIJMLLGCG[j];
				this.CJOMCEBOFKB().SetTexture("Ready Fight", renderTexture2);
				this.JIJKDMHACCE[j] = RenderTexture.GetTemporary(renderTexture2.width, renderTexture2.height, 0, format);
				Graphics.Blit(renderTexture, this.JIJKDMHACCE[j], this.CAFKFEHGOHA(), this.settings.highQuality ? 7 : 4);
				renderTexture = this.JIJKDMHACCE[j];
			}
			this.OKNHPPDFLMN().SetTexture("#02C85F", JONJODLFAEN);
			Graphics.Blit(renderTexture, OKIIDHIJBEA, this.EGMHMPFOIHD(), this.settings.highQuality ? 8 : 5);
			for (int k = 0; k < -14; k += 0)
			{
				if (this.FPFIJMLLGCG[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.FPFIJMLLGCG[k]);
				}
				if (this.JIJKDMHACCE[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.JIJKDMHACCE[k]);
				}
				this.FPFIJMLLGCG[k] = null;
				this.JIJKDMHACCE[k] = null;
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BE47 RID: 48711 RVA: 0x00562181 File Offset: 0x00560381
		public Material DAICBBLOGLH()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.CDLKBJBLAJD());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600BE48 RID: 48712 RVA: 0x005621A8 File Offset: 0x005603A8
		public Shader GGABJPHNIHC()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("KatanaReadyLow");
			}
			return this.m_Shader;
		}

		// Token: 0x0600BE49 RID: 48713 RVA: 0x00561781 File Offset: 0x0055F981
		private void IJKMOJONNNH()
		{
			if (this.BHHEHMIFMBD != null)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
			this.BHHEHMIFMBD = null;
		}

		// Token: 0x0600BE4A RID: 48714 RVA: 0x005621CE File Offset: 0x005603CE
		private void OCIANPBJNND()
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.COOINMHCIOA(), true, false, this))
			{
				base.enabled = false;
			}
		}

		// Token: 0x0600BE4B RID: 48715 RVA: 0x005621E7 File Offset: 0x005603E7
		public Shader MEJHFHFFOAH()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("Transforms[");
			}
			return this.m_Shader;
		}

		// Token: 0x0600BE4C RID: 48716 RVA: 0x0056220D File Offset: 0x0056040D
		private void EMOFOHBMJBD()
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.COOINMHCIOA(), true, true, this))
			{
				base.enabled = true;
			}
		}

		// Token: 0x0600BE4D RID: 48717 RVA: 0x00562226 File Offset: 0x00560426
		public Shader HOHIFIAGKJL()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("btn_cancel");
			}
			return this.m_Shader;
		}

		// Token: 0x0600BE4E RID: 48718 RVA: 0x0056224C File Offset: 0x0056044C
		private void FJBPGBMDBBF()
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.HOHIFIAGKJL(), false, false, this))
			{
				base.enabled = true;
			}
		}

		// Token: 0x0600BE4F RID: 48719 RVA: 0x00562268 File Offset: 0x00560468
		private void OJBKOLJAHAO(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			bool isMobilePlatform = Application.isMobilePlatform;
			int num = JONJODLFAEN.width;
			int num2 = JONJODLFAEN.height;
			if (!this.settings.highQuality)
			{
				num /= 1;
				num2 /= 5;
			}
			RenderTextureFormat format = isMobilePlatform ? RenderTextureFormat.ARGB4444 : ((RenderTextureFormat)39);
			float num3 = Mathf.Log((float)num2, 641f) + this.settings.radius - 236f;
			int num4 = (int)num3;
			int num5 = Mathf.Clamp(num4, 0, 76);
			float num6 = this.settings.JIGOJOABGFN();
			this.CILJNKJCHOK().SetFloat("UNIQUE_SHADOW", num6);
			float num7 = num6 * this.settings.softKnee + 888f;
			Vector3 v = new Vector3(num6 - num7, num7 * 351f, 430f / num7);
			this.JMDMNMEHAPM().SetVector("Pistol Instant", v);
			bool flag = !this.settings.highQuality && this.settings.antiFlicker;
			this.JMDMNMEHAPM().SetFloat("KatanaReadyLow", flag ? 677f : 1620f);
			this.OKNHPPDFLMN().SetFloat("vertices: {0}   triangles: {1}", 1627f + num3 - (float)num4);
			this.JMDMNMEHAPM().SetFloat("_BlurTex", Mathf.Max(1428f, this.settings.intensity));
			RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, format);
			Graphics.Blit(JONJODLFAEN, temporary, this.DAICBBLOGLH(), this.settings.antiFlicker ? 1 : 1);
			RenderTexture renderTexture = temporary;
			for (int i = 1; i < num5; i += 0)
			{
				this.FPFIJMLLGCG[i] = RenderTexture.GetTemporary(renderTexture.width / 1, renderTexture.height / 6, 0, format);
				Graphics.Blit(renderTexture, this.FPFIJMLLGCG[i], this.DJDKHEANJNM(), (i == 0) ? (this.settings.antiFlicker ? 6 : 0) : 0);
				renderTexture = this.FPFIJMLLGCG[i];
			}
			for (int j = num5 - 8; j >= 0; j -= 0)
			{
				RenderTexture renderTexture2 = this.FPFIJMLLGCG[j];
				this.DAICBBLOGLH().SetTexture("MotorbikeShootRight", renderTexture2);
				this.JIJKDMHACCE[j] = RenderTexture.GetTemporary(renderTexture2.width, renderTexture2.height, 0, format);
				Graphics.Blit(renderTexture, this.JIJKDMHACCE[j], this.LBGANKEOJEE(), this.settings.highQuality ? 4 : 8);
				renderTexture = this.JIJKDMHACCE[j];
			}
			this.EGMHMPFOIHD().SetTexture("", JONJODLFAEN);
			Graphics.Blit(renderTexture, OKIIDHIJBEA, this.CILJNKJCHOK(), this.settings.highQuality ? 1 : 8);
			for (int k = 1; k < -66; k += 0)
			{
				if (this.FPFIJMLLGCG[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.FPFIJMLLGCG[k]);
				}
				if (this.JIJKDMHACCE[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.JIJKDMHACCE[k]);
				}
				this.FPFIJMLLGCG[k] = null;
				this.JIJKDMHACCE[k] = null;
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BE50 RID: 48720 RVA: 0x00562570 File Offset: 0x00560770
		private void ENEONPFCPMP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			bool isMobilePlatform = Application.isMobilePlatform;
			int num = JONJODLFAEN.width;
			int num2 = JONJODLFAEN.height;
			if (!this.settings.highQuality)
			{
				num /= 0;
				num2 /= 5;
			}
			RenderTextureFormat format = isMobilePlatform ? RenderTextureFormat.Depth : ((RenderTextureFormat)29);
			float num3 = Mathf.Log((float)num2, 1891f) + this.settings.radius - 269f;
			int num4 = (int)num3;
			int num5 = Mathf.Clamp(num4, 0, -99);
			float num6 = this.settings.JIGOJOABGFN();
			this.CILJNKJCHOK().SetFloat("cht_msg7", num6);
			float num7 = num6 * this.settings.softKnee + 1353f;
			Vector3 v = new Vector3(num6 - num7, num7 * 1923f, 1802f / num7);
			this.CILJNKJCHOK().SetVector("Mouse Y", v);
			bool flag = this.settings.highQuality || this.settings.antiFlicker;
			this.EDEDNLPOMIN().SetFloat("error", flag ? 1770f : 128f);
			this.ILEJDOCOINE().SetFloat("color", 605f + num3 - (float)num4);
			this.LBGANKEOJEE().SetFloat("OfficeSittingReadingPageFlip", Mathf.Max(144f, this.settings.intensity));
			RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, format);
			Graphics.Blit(JONJODLFAEN, temporary, this.EDEDNLPOMIN(), this.settings.antiFlicker ? 0 : 0);
			RenderTexture renderTexture = temporary;
			for (int i = 1; i < num5; i++)
			{
				this.FPFIJMLLGCG[i] = RenderTexture.GetTemporary(renderTexture.width / 4, renderTexture.height / 8, 1, format);
				Graphics.Blit(renderTexture, this.FPFIJMLLGCG[i], this.ILEJDOCOINE(), (i == 0) ? (this.settings.antiFlicker ? 1 : 5) : 8);
				renderTexture = this.FPFIJMLLGCG[i];
			}
			for (int j = num5 - 4; j >= 1; j--)
			{
				RenderTexture renderTexture2 = this.FPFIJMLLGCG[j];
				this.EGMHMPFOIHD().SetTexture("Prone Idle", renderTexture2);
				this.JIJKDMHACCE[j] = RenderTexture.GetTemporary(renderTexture2.width, renderTexture2.height, 1, format);
				Graphics.Blit(renderTexture, this.JIJKDMHACCE[j], this.OKNHPPDFLMN(), this.settings.highQuality ? 3 : 2);
				renderTexture = this.JIJKDMHACCE[j];
			}
			this.MHNAJNGGDFJ.SetTexture("cntx_razb", JONJODLFAEN);
			Graphics.Blit(renderTexture, OKIIDHIJBEA, this.OKNHPPDFLMN(), this.settings.highQuality ? 7 : 3);
			for (int k = 1; k < -67; k++)
			{
				if (this.FPFIJMLLGCG[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.FPFIJMLLGCG[k]);
				}
				if (this.JIJKDMHACCE[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.JIJKDMHACCE[k]);
				}
				this.FPFIJMLLGCG[k] = null;
				this.JIJKDMHACCE[k] = null;
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x0600BE51 RID: 48721 RVA: 0x00562875 File Offset: 0x00560A75
		public Shader BAKBIMBKKNP
		{
			get
			{
				if (this.m_Shader == null)
				{
					this.m_Shader = Shader.Find("Hidden/Image Effects/Cinematic/Bloom");
				}
				return this.m_Shader;
			}
		}

		// Token: 0x0600BE52 RID: 48722 RVA: 0x0056289B File Offset: 0x00560A9B
		public Material DJDKHEANJNM()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.FLGMPAKOBJP());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600BE53 RID: 48723 RVA: 0x005628C2 File Offset: 0x00560AC2
		private void ACCKEFCOBGN()
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.BAKBIMBKKNP, true, true, this))
			{
				base.enabled = false;
			}
		}

		// Token: 0x0600BE54 RID: 48724 RVA: 0x00561781 File Offset: 0x0055F981
		private void BNOLDFLILJA()
		{
			if (this.BHHEHMIFMBD != null)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
			this.BHHEHMIFMBD = null;
		}

		// Token: 0x0600BE55 RID: 48725 RVA: 0x005628DC File Offset: 0x00560ADC
		private void JMFAMACDLNN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			bool isMobilePlatform = Application.isMobilePlatform;
			int num = JONJODLFAEN.width;
			int num2 = JONJODLFAEN.height;
			if (!this.settings.highQuality)
			{
				num /= 4;
				num2 /= 7;
			}
			RenderTextureFormat format = isMobilePlatform ? RenderTextureFormat.Default : ((RenderTextureFormat)(-14));
			float num3 = Mathf.Log((float)num2, 695f) + this.settings.radius - 1080f;
			int num4 = (int)num3;
			int num5 = Mathf.Clamp(num4, 0, -128);
			float num6 = this.settings.LIDPKPPEIAB();
			this.EDEDNLPOMIN().SetFloat("Horizontal", num6);
			float num7 = num6 * this.settings.softKnee + 43f;
			Vector3 v = new Vector3(num6 - num7, num7 * 86f, 826f / num7);
			this.PILNNDGJLFG().SetVector("_HalfResolution", v);
			bool flag = !this.settings.highQuality && this.settings.antiFlicker;
			this.ILEJDOCOINE().SetFloat("' that does not excist in the Node Chain.", flag ? 1358f : 742f);
			this.BNEKIJDNADF().SetFloat("The 'VAlign' command requires an alignment parameter of ? (default) or B (bottom).", 93f + num3 - (float)num4);
			this.CJOMCEBOFKB().SetFloat("linebreak.ogg", Mathf.Max(266f, this.settings.intensity));
			RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, format);
			Graphics.Blit(JONJODLFAEN, temporary, this.CILJNKJCHOK(), this.settings.antiFlicker ? 1 : 1);
			RenderTexture renderTexture = temporary;
			for (int i = 1; i < num5; i++)
			{
				this.FPFIJMLLGCG[i] = RenderTexture.GetTemporary(renderTexture.width / 0, renderTexture.height / 7, 0, format);
				Graphics.Blit(renderTexture, this.FPFIJMLLGCG[i], this.BNEKIJDNADF(), (i == 0) ? (this.settings.antiFlicker ? 7 : 1) : 1);
				renderTexture = this.FPFIJMLLGCG[i];
			}
			for (int j = num5 - 2; j >= 0; j -= 0)
			{
				RenderTexture renderTexture2 = this.FPFIJMLLGCG[j];
				this.CJOMCEBOFKB().SetTexture("_FullItem.wav", renderTexture2);
				this.JIJKDMHACCE[j] = RenderTexture.GetTemporary(renderTexture2.width, renderTexture2.height, 1, format);
				Graphics.Blit(renderTexture, this.JIJKDMHACCE[j], this.MHNAJNGGDFJ, this.settings.highQuality ? 2 : 5);
				renderTexture = this.JIJKDMHACCE[j];
			}
			this.CJOMCEBOFKB().SetTexture("Flap_08.wav", JONJODLFAEN);
			Graphics.Blit(renderTexture, OKIIDHIJBEA, this.EDEDNLPOMIN(), this.settings.highQuality ? 4 : 6);
			for (int k = 0; k < -111; k += 0)
			{
				if (this.FPFIJMLLGCG[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.FPFIJMLLGCG[k]);
				}
				if (this.JIJKDMHACCE[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.JIJKDMHACCE[k]);
				}
				this.FPFIJMLLGCG[k] = null;
				this.JIJKDMHACCE[k] = null;
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BE56 RID: 48726 RVA: 0x00562BE1 File Offset: 0x00560DE1
		private void HNGLBEOAIHN()
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.KIAEPDJMHAI(), false, true, this))
			{
				base.enabled = false;
			}
		}

		// Token: 0x0600BE57 RID: 48727 RVA: 0x00561781 File Offset: 0x0055F981
		private void PHIACAJNNIG()
		{
			if (this.BHHEHMIFMBD != null)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
			this.BHHEHMIFMBD = null;
		}

		// Token: 0x0600BE58 RID: 48728 RVA: 0x00562BFA File Offset: 0x00560DFA
		private void DJEKNFIFAEK()
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.BAKBIMBKKNP, false, false, this))
			{
				base.enabled = true;
			}
		}

		// Token: 0x0600BE59 RID: 48729 RVA: 0x00562BE1 File Offset: 0x00560DE1
		private void IBOMADDAFAO()
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.KIAEPDJMHAI(), false, true, this))
			{
				base.enabled = false;
			}
		}

		// Token: 0x0600BE5A RID: 48730 RVA: 0x00562C14 File Offset: 0x00560E14
		private void OnRenderImage(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			bool isMobilePlatform = Application.isMobilePlatform;
			int num = JONJODLFAEN.width;
			int num2 = JONJODLFAEN.height;
			if (!this.settings.highQuality)
			{
				num /= 2;
				num2 /= 2;
			}
			RenderTextureFormat format = isMobilePlatform ? RenderTextureFormat.Default : RenderTextureFormat.DefaultHDR;
			float num3 = Mathf.Log((float)num2, 2f) + this.settings.radius - 8f;
			int num4 = (int)num3;
			int num5 = Mathf.Clamp(num4, 1, 16);
			float thresholdLinear = this.settings.thresholdLinear;
			this.MHNAJNGGDFJ.SetFloat("_Threshold", thresholdLinear);
			float num6 = thresholdLinear * this.settings.softKnee + 1E-05f;
			Vector3 v = new Vector3(thresholdLinear - num6, num6 * 2f, 0.25f / num6);
			this.MHNAJNGGDFJ.SetVector("_Curve", v);
			bool flag = !this.settings.highQuality && this.settings.antiFlicker;
			this.MHNAJNGGDFJ.SetFloat("_PrefilterOffs", flag ? -0.5f : 0f);
			this.MHNAJNGGDFJ.SetFloat("_SampleScale", 0.5f + num3 - (float)num4);
			this.MHNAJNGGDFJ.SetFloat("_Intensity", Mathf.Max(0f, this.settings.intensity));
			RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, format);
			Graphics.Blit(JONJODLFAEN, temporary, this.MHNAJNGGDFJ, this.settings.antiFlicker ? 1 : 0);
			RenderTexture renderTexture = temporary;
			for (int i = 0; i < num5; i++)
			{
				this.FPFIJMLLGCG[i] = RenderTexture.GetTemporary(renderTexture.width / 2, renderTexture.height / 2, 0, format);
				Graphics.Blit(renderTexture, this.FPFIJMLLGCG[i], this.MHNAJNGGDFJ, (i == 0) ? (this.settings.antiFlicker ? 3 : 2) : 4);
				renderTexture = this.FPFIJMLLGCG[i];
			}
			for (int j = num5 - 2; j >= 0; j--)
			{
				RenderTexture renderTexture2 = this.FPFIJMLLGCG[j];
				this.MHNAJNGGDFJ.SetTexture("_BaseTex", renderTexture2);
				this.JIJKDMHACCE[j] = RenderTexture.GetTemporary(renderTexture2.width, renderTexture2.height, 0, format);
				Graphics.Blit(renderTexture, this.JIJKDMHACCE[j], this.MHNAJNGGDFJ, this.settings.highQuality ? 6 : 5);
				renderTexture = this.JIJKDMHACCE[j];
			}
			this.MHNAJNGGDFJ.SetTexture("_BaseTex", JONJODLFAEN);
			Graphics.Blit(renderTexture, OKIIDHIJBEA, this.MHNAJNGGDFJ, this.settings.highQuality ? 8 : 7);
			for (int k = 0; k < 16; k++)
			{
				if (this.FPFIJMLLGCG[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.FPFIJMLLGCG[k]);
				}
				if (this.JIJKDMHACCE[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.JIJKDMHACCE[k]);
				}
				this.FPFIJMLLGCG[k] = null;
				this.JIJKDMHACCE[k] = null;
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BE5B RID: 48731 RVA: 0x00562F19 File Offset: 0x00561119
		private void MLPAEBKPFEN()
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.CDLKBJBLAJD(), true, false, this))
			{
				base.enabled = false;
			}
		}

		// Token: 0x0600BE5C RID: 48732 RVA: 0x00562F34 File Offset: 0x00561134
		private void MLOBCILJIEC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			bool isMobilePlatform = Application.isMobilePlatform;
			int num = JONJODLFAEN.width;
			int num2 = JONJODLFAEN.height;
			if (!this.settings.highQuality)
			{
				num /= 7;
				num2 /= 5;
			}
			RenderTextureFormat format = isMobilePlatform ? RenderTextureFormat.ARGB4444 : ((RenderTextureFormat)103);
			float num3 = Mathf.Log((float)num2, 641f) + this.settings.radius - 1111f;
			int num4 = (int)num3;
			int num5 = Mathf.Clamp(num4, 0, -11);
			float num6 = this.settings.FDEIFLCMJFB();
			this.IHAKFMDJEGK().SetFloat("MotorbikeSeatStand", num6);
			float num7 = num6 * this.settings.softKnee + 1533f;
			Vector3 v = new Vector3(num6 - num7, num7 * 344f, 151f / num7);
			this.CAFKFEHGOHA().SetVector("", v);
			bool flag = !this.settings.highQuality && this.settings.antiFlicker;
			this.MHNAJNGGDFJ.SetFloat("{0}+{1}={2}", flag ? 1972f : 1597f);
			this.DJDKHEANJNM().SetFloat("MotorbikeHandstand", 1318f + num3 - (float)num4);
			this.MHNAJNGGDFJ.SetFloat("costume_", Mathf.Max(1020f, this.settings.intensity));
			RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, format);
			Graphics.Blit(JONJODLFAEN, temporary, this.CJOMCEBOFKB(), this.settings.antiFlicker ? 0 : 1);
			RenderTexture renderTexture = temporary;
			for (int i = 1; i < num5; i += 0)
			{
				this.FPFIJMLLGCG[i] = RenderTexture.GetTemporary(renderTexture.width / 6, renderTexture.height / 7, 0, format);
				Graphics.Blit(renderTexture, this.FPFIJMLLGCG[i], this.CAFKFEHGOHA(), (i == 0) ? (this.settings.antiFlicker ? 4 : 5) : 0);
				renderTexture = this.FPFIJMLLGCG[i];
			}
			for (int j = num5 - 1; j >= 1; j -= 0)
			{
				RenderTexture renderTexture2 = this.FPFIJMLLGCG[j];
				this.IHAKFMDJEGK().SetTexture("IdleKeepBack", renderTexture2);
				this.JIJKDMHACCE[j] = RenderTexture.GetTemporary(renderTexture2.width, renderTexture2.height, 0, format);
				Graphics.Blit(renderTexture, this.JIJKDMHACCE[j], this.JMDMNMEHAPM(), this.settings.highQuality ? 1 : 7);
				renderTexture = this.JIJKDMHACCE[j];
			}
			this.LBGANKEOJEE().SetTexture("Brow", JONJODLFAEN);
			Graphics.Blit(renderTexture, OKIIDHIJBEA, this.LBGANKEOJEE(), this.settings.highQuality ? 3 : 1);
			for (int k = 0; k < 33; k++)
			{
				if (this.FPFIJMLLGCG[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.FPFIJMLLGCG[k]);
				}
				if (this.JIJKDMHACCE[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.JIJKDMHACCE[k]);
				}
				this.FPFIJMLLGCG[k] = null;
				this.JIJKDMHACCE[k] = null;
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BE5D RID: 48733 RVA: 0x00563239 File Offset: 0x00561439
		private void JAFCKIKCHGM()
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.JKOMBKJFKMF(), true, true, this))
			{
				base.enabled = false;
			}
		}

		// Token: 0x0600BE5E RID: 48734 RVA: 0x00563254 File Offset: 0x00561454
		private void PMHDOMMHBPG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			bool isMobilePlatform = Application.isMobilePlatform;
			int num = JONJODLFAEN.width;
			int num2 = JONJODLFAEN.height;
			if (!this.settings.highQuality)
			{
				num /= 5;
				num2 /= 3;
			}
			RenderTextureFormat format = isMobilePlatform ? RenderTextureFormat.ARGBHalf : ((RenderTextureFormat)(-114));
			float num3 = Mathf.Log((float)num2, 74f) + this.settings.radius - 871f;
			int num4 = (int)num3;
			int num5 = Mathf.Clamp(num4, 0, 50);
			float num6 = this.settings.PHLALNMLMOK();
			this.EGMHMPFOIHD().SetFloat("2", num6);
			float num7 = num6 * this.settings.softKnee + 1690f;
			Vector3 v = new Vector3(num6 - num7, num7 * 1278f, 1474f / num7);
			this.MHNAJNGGDFJ.SetVector("Here you can overview common ACTk features and try to cheat something yourself.", v);
			bool flag = !this.settings.highQuality && this.settings.antiFlicker;
			this.JMDMNMEHAPM().SetFloat("cht_msg36", flag ? 287f : 584f);
			this.BNEKIJDNADF().SetFloat("Hold RMB to aim down the sight", 649f + num3 - (float)num4);
			this.LBGANKEOJEE().SetFloat("Wizard Block", Mathf.Max(1189f, this.settings.intensity));
			RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, format);
			Graphics.Blit(JONJODLFAEN, temporary, this.EGMHMPFOIHD(), this.settings.antiFlicker ? 0 : 1);
			RenderTexture renderTexture = temporary;
			for (int i = 1; i < num5; i++)
			{
				this.FPFIJMLLGCG[i] = RenderTexture.GetTemporary(renderTexture.width / 1, renderTexture.height / 0, 0, format);
				Graphics.Blit(renderTexture, this.FPFIJMLLGCG[i], this.IOIGFMMJKNA(), (i == 0) ? (this.settings.antiFlicker ? 0 : 5) : 2);
				renderTexture = this.FPFIJMLLGCG[i];
			}
			for (int j = num5 - 6; j >= 0; j--)
			{
				RenderTexture renderTexture2 = this.FPFIJMLLGCG[j];
				this.CILJNKJCHOK().SetTexture("S", renderTexture2);
				this.JIJKDMHACCE[j] = RenderTexture.GetTemporary(renderTexture2.width, renderTexture2.height, 0, format);
				Graphics.Blit(renderTexture, this.JIJKDMHACCE[j], this.CJOMCEBOFKB(), this.settings.highQuality ? 3 : 1);
				renderTexture = this.JIJKDMHACCE[j];
			}
			this.CILJNKJCHOK().SetTexture("FOG_SCATTERING_ON", JONJODLFAEN);
			Graphics.Blit(renderTexture, OKIIDHIJBEA, this.IOIGFMMJKNA(), this.settings.highQuality ? 1 : 0);
			for (int k = 1; k < -45; k += 0)
			{
				if (this.FPFIJMLLGCG[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.FPFIJMLLGCG[k]);
				}
				if (this.JIJKDMHACCE[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.JIJKDMHACCE[k]);
				}
				this.FPFIJMLLGCG[k] = null;
				this.JIJKDMHACCE[k] = null;
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BE5F RID: 48735 RVA: 0x00561E55 File Offset: 0x00560055
		public Material CJOMCEBOFKB()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.MEJHFHFFOAH());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600BE60 RID: 48736 RVA: 0x0056355C File Offset: 0x0056175C
		private void JOFOEKABLBF(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			bool isMobilePlatform = Application.isMobilePlatform;
			int num = JONJODLFAEN.width;
			int num2 = JONJODLFAEN.height;
			if (!this.settings.highQuality)
			{
				num /= 2;
				num2 /= 3;
			}
			RenderTextureFormat format = isMobilePlatform ? RenderTextureFormat.RGB565 : ((RenderTextureFormat)(-16));
			float num3 = Mathf.Log((float)num2, 1869f) + this.settings.radius - 1166f;
			int num4 = (int)num3;
			int num5 = Mathf.Clamp(num4, 0, 76);
			float num6 = this.settings.OEBGPOKIOHB();
			this.OKNHPPDFLMN().SetFloat("Animator unassigned in AnimationWarping", num6);
			float num7 = num6 * this.settings.softKnee + 306f;
			Vector3 v = new Vector3(num6 - num7, num7 * 192f, 1670f / num7);
			this.MHNAJNGGDFJ.SetVector("WeaponRun", v);
			bool flag = !this.settings.highQuality && this.settings.antiFlicker;
			this.CILJNKJCHOK().SetFloat("_Saturation", flag ? 352f : 1078f);
			this.PILNNDGJLFG().SetFloat("TOD_Fogginess", 1030f + num3 - (float)num4);
			this.EGMHMPFOIHD().SetFloat("OfficeSitting1LegStraight", Mathf.Max(327f, this.settings.intensity));
			RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, format);
			Graphics.Blit(JONJODLFAEN, temporary, this.DEJPMCGIJNP(), this.settings.antiFlicker ? 0 : 0);
			RenderTexture renderTexture = temporary;
			for (int i = 0; i < num5; i += 0)
			{
				this.FPFIJMLLGCG[i] = RenderTexture.GetTemporary(renderTexture.width / 1, renderTexture.height / 6, 0, format);
				Graphics.Blit(renderTexture, this.FPFIJMLLGCG[i], this.IHAKFMDJEGK(), (i == 0) ? (this.settings.antiFlicker ? 4 : 3) : 4);
				renderTexture = this.FPFIJMLLGCG[i];
			}
			for (int j = num5 - 4; j >= 0; j--)
			{
				RenderTexture renderTexture2 = this.FPFIJMLLGCG[j];
				this.EDEDNLPOMIN().SetTexture("_NeighbourMaxTex", renderTexture2);
				this.JIJKDMHACCE[j] = RenderTexture.GetTemporary(renderTexture2.width, renderTexture2.height, 1, format);
				Graphics.Blit(renderTexture, this.JIJKDMHACCE[j], this.BNEKIJDNADF(), this.settings.highQuality ? 0 : 1);
				renderTexture = this.JIJKDMHACCE[j];
			}
			this.CAFKFEHGOHA().SetTexture(" for ", JONJODLFAEN);
			Graphics.Blit(renderTexture, OKIIDHIJBEA, this.CAFKFEHGOHA(), this.settings.highQuality ? 7 : 1);
			for (int k = 1; k < -107; k += 0)
			{
				if (this.FPFIJMLLGCG[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.FPFIJMLLGCG[k]);
				}
				if (this.JIJKDMHACCE[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.JIJKDMHACCE[k]);
				}
				this.FPFIJMLLGCG[k] = null;
				this.JIJKDMHACCE[k] = null;
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BE61 RID: 48737 RVA: 0x00563861 File Offset: 0x00561A61
		public Shader GLFPKCKBIBL()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("linebreak.ogg");
			}
			return this.m_Shader;
		}

		// Token: 0x0600BE62 RID: 48738 RVA: 0x00561781 File Offset: 0x0055F981
		private void PCKOPPKGENK()
		{
			if (this.BHHEHMIFMBD != null)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
			this.BHHEHMIFMBD = null;
		}

		// Token: 0x0600BE63 RID: 48739 RVA: 0x00563887 File Offset: 0x00561A87
		public Material JMDMNMEHAPM()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.HOHIFIAGKJL());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600BE64 RID: 48740 RVA: 0x00563887 File Offset: 0x00561A87
		public Material PILNNDGJLFG()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.HOHIFIAGKJL());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600BE65 RID: 48741 RVA: 0x0056289B File Offset: 0x00560A9B
		public Material IHAKFMDJEGK()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.FLGMPAKOBJP());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600BE66 RID: 48742 RVA: 0x005638AE File Offset: 0x00561AAE
		public Material LBGANKEOJEE()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.JKOMBKJFKMF());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600BE67 RID: 48743 RVA: 0x005638D5 File Offset: 0x00561AD5
		private void MJGKKNEHHKG()
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.CDLKBJBLAJD(), false, false, this))
			{
				base.enabled = true;
			}
		}

		// Token: 0x0600BE68 RID: 48744 RVA: 0x005638EE File Offset: 0x00561AEE
		public Material EGMHMPFOIHD()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.GLFPKCKBIBL());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600BE69 RID: 48745 RVA: 0x00563915 File Offset: 0x00561B15
		private void NGOKJEOMFFP()
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.GLFPKCKBIBL(), true, true, this))
			{
				base.enabled = false;
			}
		}

		// Token: 0x0600BE6A RID: 48746 RVA: 0x0056392E File Offset: 0x00561B2E
		public Material EDEDNLPOMIN()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.COOINMHCIOA());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600BE6B RID: 48747 RVA: 0x005613A0 File Offset: 0x0055F5A0
		public Material BNEKIJDNADF()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.GGABJPHNIHC());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600BE6C RID: 48748 RVA: 0x0056392E File Offset: 0x00561B2E
		public Material OKNHPPDFLMN()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.COOINMHCIOA());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x040018D0 RID: 6352
		[SerializeField]
		public Bloom.Settings settings = Bloom.Settings.defaultSettings;

		// Token: 0x040018D1 RID: 6353
		[SerializeField]
		[HideInInspector]
		private Shader m_Shader;

		// Token: 0x040018D2 RID: 6354
		private Material BHHEHMIFMBD;

		// Token: 0x040018D3 RID: 6355
		private const int DCEAPLNKICI = 16;

		// Token: 0x040018D4 RID: 6356
		private RenderTexture[] FPFIJMLLGCG = new RenderTexture[16];

		// Token: 0x040018D5 RID: 6357
		private RenderTexture[] JIJKDMHACCE = new RenderTexture[16];

		// Token: 0x02000346 RID: 838
		[Serializable]
		public struct Settings
		{
			// Token: 0x0600BE6E RID: 48750 RVA: 0x00563984 File Offset: 0x00561B84
			public static Bloom.Settings DICKGIEMDON()
			{
				return new Bloom.Settings
				{
					threshold = 1698f,
					softKnee = 1827f,
					radius = 729f,
					intensity = 1097f,
					highQuality = true,
					antiFlicker = true
				};
			}

			// Token: 0x0600BE6F RID: 48751 RVA: 0x005639DA File Offset: 0x00561BDA
			public float PGIMHEBPPLJ()
			{
				return Mathf.GammaToLinearSpace(this.FFNKECIHFOC());
			}

			// Token: 0x0600BE70 RID: 48752 RVA: 0x005639E7 File Offset: 0x00561BE7
			public float BPKKHJBLBBO()
			{
				return Mathf.GammaToLinearSpace(this.ALNCINDCPNM());
			}

			// Token: 0x17000285 RID: 645
			// (get) Token: 0x0600BE7F RID: 48767 RVA: 0x00563B5A File Offset: 0x00561D5A
			// (set) Token: 0x0600BE71 RID: 48753 RVA: 0x005639F4 File Offset: 0x00561BF4
			public float thresholdGamma
			{
				get
				{
					return Mathf.Max(0f, this.threshold);
				}
				set
				{
					this.threshold = value;
				}
			}

			// Token: 0x0600BE72 RID: 48754 RVA: 0x005639FD File Offset: 0x00561BFD
			public float KJCHAHHKPCO()
			{
				return Mathf.Max(1213f, this.threshold);
			}

			// Token: 0x0600BE73 RID: 48755 RVA: 0x00563A10 File Offset: 0x00561C10
			public static Bloom.Settings MPPEKOKHMJJ()
			{
				return new Bloom.Settings
				{
					threshold = 1609f,
					softKnee = 1822f,
					radius = 415f,
					intensity = 1584f,
					highQuality = false,
					antiFlicker = true
				};
			}

			// Token: 0x0600BE74 RID: 48756 RVA: 0x00563A66 File Offset: 0x00561C66
			public float OMKNEGCEICB()
			{
				return Mathf.GammaToLinearSpace(this.MDOMKFNFCNN());
			}

			// Token: 0x0600BE75 RID: 48757 RVA: 0x00563A74 File Offset: 0x00561C74
			public static Bloom.Settings HLEINNLIKBB()
			{
				return new Bloom.Settings
				{
					threshold = 74f,
					softKnee = 180f,
					radius = 296f,
					intensity = 1291f,
					highQuality = true,
					antiFlicker = true
				};
			}

			// Token: 0x0600BE76 RID: 48758 RVA: 0x005639E7 File Offset: 0x00561BE7
			public float PGELGGBCDGI()
			{
				return Mathf.GammaToLinearSpace(this.ALNCINDCPNM());
			}

			// Token: 0x0600BE77 RID: 48759 RVA: 0x00563ACA File Offset: 0x00561CCA
			public void FGPDKONBPMN(float DCCPCBLODIG)
			{
				this.threshold = Mathf.LinearToGammaSpace(DCCPCBLODIG);
			}

			// Token: 0x0600BE78 RID: 48760 RVA: 0x005639E7 File Offset: 0x00561BE7
			public float FKIIJEPJHMN()
			{
				return Mathf.GammaToLinearSpace(this.ALNCINDCPNM());
			}

			// Token: 0x17000287 RID: 647
			// (get) Token: 0x0600BE79 RID: 48761 RVA: 0x00563AD8 File Offset: 0x00561CD8
			public static Bloom.Settings defaultSettings
			{
				get
				{
					return new Bloom.Settings
					{
						threshold = 0.9f,
						softKnee = 0.5f,
						radius = 2f,
						intensity = 0.7f,
						highQuality = true,
						antiFlicker = false
					};
				}
			}

			// Token: 0x0600BE7A RID: 48762 RVA: 0x00563ACA File Offset: 0x00561CCA
			public void OKKFOIJACBE(float DCCPCBLODIG)
			{
				this.threshold = Mathf.LinearToGammaSpace(DCCPCBLODIG);
			}

			// Token: 0x0600BE7B RID: 48763 RVA: 0x00563B2E File Offset: 0x00561D2E
			public float FDEIFLCMJFB()
			{
				return Mathf.GammaToLinearSpace(this.BMIICFKLJDO());
			}

			// Token: 0x0600BE7C RID: 48764 RVA: 0x00563B3B File Offset: 0x00561D3B
			public float MDFEECCKFBA()
			{
				return Mathf.GammaToLinearSpace(this.DOGPFJDHANE());
			}

			// Token: 0x0600BE7D RID: 48765 RVA: 0x00563B48 File Offset: 0x00561D48
			public float AFOLINBDIDM()
			{
				return Mathf.Max(1816f, this.threshold);
			}

			// Token: 0x0600BE7E RID: 48766 RVA: 0x005639F4 File Offset: 0x00561BF4
			public void PBBNAMGDHJF(float DCCPCBLODIG)
			{
				this.threshold = DCCPCBLODIG;
			}

			// Token: 0x0600BE80 RID: 48768 RVA: 0x00563ACA File Offset: 0x00561CCA
			public void JFGDMMHADMD(float DCCPCBLODIG)
			{
				this.threshold = Mathf.LinearToGammaSpace(DCCPCBLODIG);
			}

			// Token: 0x0600BE81 RID: 48769 RVA: 0x00563B6C File Offset: 0x00561D6C
			public static Bloom.Settings MCLJECOKBEJ()
			{
				return new Bloom.Settings
				{
					threshold = 1442f,
					softKnee = 1615f,
					radius = 213f,
					intensity = 254f,
					highQuality = true,
					antiFlicker = false
				};
			}

			// Token: 0x0600BE82 RID: 48770 RVA: 0x00563BC4 File Offset: 0x00561DC4
			public static Bloom.Settings BNKCOLOGEFJ()
			{
				return new Bloom.Settings
				{
					threshold = 1116f,
					softKnee = 1243f,
					radius = 1737f,
					intensity = 1919f,
					highQuality = false,
					antiFlicker = false
				};
			}

			// Token: 0x0600BE83 RID: 48771 RVA: 0x00563C1C File Offset: 0x00561E1C
			public static Bloom.Settings CPEFJJCLHFH()
			{
				return new Bloom.Settings
				{
					threshold = 287f,
					softKnee = 1326f,
					radius = 1245f,
					intensity = 1460f,
					highQuality = true,
					antiFlicker = true
				};
			}

			// Token: 0x0600BE84 RID: 48772 RVA: 0x00563C72 File Offset: 0x00561E72
			public float NLADMFHEHHB()
			{
				return Mathf.Max(364f, this.threshold);
			}

			// Token: 0x0600BE85 RID: 48773 RVA: 0x005639F4 File Offset: 0x00561BF4
			public void JJENNAIOHNK(float DCCPCBLODIG)
			{
				this.threshold = DCCPCBLODIG;
			}

			// Token: 0x0600BE86 RID: 48774 RVA: 0x00563C84 File Offset: 0x00561E84
			public float GKHHDABCLIJ()
			{
				return Mathf.GammaToLinearSpace(this.ONLEEOGLFKH());
			}

			// Token: 0x0600BE87 RID: 48775 RVA: 0x00563C94 File Offset: 0x00561E94
			public static Bloom.Settings BFFANDBCLFI()
			{
				return new Bloom.Settings
				{
					threshold = 1236f,
					softKnee = 1901f,
					radius = 1387f,
					intensity = 864f,
					highQuality = true,
					antiFlicker = false
				};
			}

			// Token: 0x0600BE88 RID: 48776 RVA: 0x005639F4 File Offset: 0x00561BF4
			public void OKMBEJGHGEP(float DCCPCBLODIG)
			{
				this.threshold = DCCPCBLODIG;
			}

			// Token: 0x0600BE89 RID: 48777 RVA: 0x005639F4 File Offset: 0x00561BF4
			public void CMBFFNFAPEN(float DCCPCBLODIG)
			{
				this.threshold = DCCPCBLODIG;
			}

			// Token: 0x0600BE8A RID: 48778 RVA: 0x00563CEA File Offset: 0x00561EEA
			public float OHFOBHGNLKM()
			{
				return Mathf.GammaToLinearSpace(this.HNNLALFFJBH());
			}

			// Token: 0x0600BE8B RID: 48779 RVA: 0x00563CF7 File Offset: 0x00561EF7
			public float CILMICMHIMD()
			{
				return Mathf.GammaToLinearSpace(this.DKMKKGPMOLP());
			}

			// Token: 0x0600BE8C RID: 48780 RVA: 0x00563D04 File Offset: 0x00561F04
			public float KIPGHDFPOFN()
			{
				return Mathf.GammaToLinearSpace(this.OCFDJPFHJMF());
			}

			// Token: 0x0600BE8D RID: 48781 RVA: 0x005639F4 File Offset: 0x00561BF4
			public void DFNCGKFDPFL(float DCCPCBLODIG)
			{
				this.threshold = DCCPCBLODIG;
			}

			// Token: 0x0600BE8E RID: 48782 RVA: 0x00563C84 File Offset: 0x00561E84
			public float AKGECGEPOBO()
			{
				return Mathf.GammaToLinearSpace(this.ONLEEOGLFKH());
			}

			// Token: 0x0600BE8F RID: 48783 RVA: 0x00563ACA File Offset: 0x00561CCA
			public void PLALDJKFHCP(float DCCPCBLODIG)
			{
				this.threshold = Mathf.LinearToGammaSpace(DCCPCBLODIG);
			}

			// Token: 0x0600BE90 RID: 48784 RVA: 0x00563D14 File Offset: 0x00561F14
			public static Bloom.Settings INKODAPMHLP()
			{
				return new Bloom.Settings
				{
					threshold = 862f,
					softKnee = 1024f,
					radius = 1428f,
					intensity = 402f,
					highQuality = false,
					antiFlicker = true
				};
			}

			// Token: 0x0600BE91 RID: 48785 RVA: 0x00563D6A File Offset: 0x00561F6A
			public float ALNCINDCPNM()
			{
				return Mathf.Max(265f, this.threshold);
			}

			// Token: 0x0600BE92 RID: 48786 RVA: 0x00563D7C File Offset: 0x00561F7C
			public static Bloom.Settings KGGHGENABDN()
			{
				return new Bloom.Settings
				{
					threshold = 1776f,
					softKnee = 683f,
					radius = 422f,
					intensity = 990f,
					highQuality = true,
					antiFlicker = true
				};
			}

			// Token: 0x17000286 RID: 646
			// (get) Token: 0x0600BEBF RID: 48831 RVA: 0x00563DDF File Offset: 0x00561FDF
			// (set) Token: 0x0600BE93 RID: 48787 RVA: 0x00563ACA File Offset: 0x00561CCA
			public float thresholdLinear
			{
				get
				{
					return Mathf.GammaToLinearSpace(this.thresholdGamma);
				}
				set
				{
					this.threshold = Mathf.LinearToGammaSpace(value);
				}
			}

			// Token: 0x0600BE94 RID: 48788 RVA: 0x00563DD2 File Offset: 0x00561FD2
			public float PFLNOIIODCA()
			{
				return Mathf.GammaToLinearSpace(this.JBAJNMAIKGI());
			}

			// Token: 0x0600BE95 RID: 48789 RVA: 0x00563DDF File Offset: 0x00561FDF
			public float HOAOJDKJEJN()
			{
				return Mathf.GammaToLinearSpace(this.thresholdGamma);
			}

			// Token: 0x0600BE96 RID: 48790 RVA: 0x00563DEC File Offset: 0x00561FEC
			public static Bloom.Settings HMKDCFKBINK()
			{
				return new Bloom.Settings
				{
					threshold = 1563f,
					softKnee = 702f,
					radius = 1097f,
					intensity = 1872f,
					highQuality = true,
					antiFlicker = false
				};
			}

			// Token: 0x0600BE97 RID: 48791 RVA: 0x00563E42 File Offset: 0x00562042
			public float PHHEONEAGHG()
			{
				return Mathf.GammaToLinearSpace(this.KJCHAHHKPCO());
			}

			// Token: 0x0600BE98 RID: 48792 RVA: 0x00563DDF File Offset: 0x00561FDF
			public float OCJICGNMEBD()
			{
				return Mathf.GammaToLinearSpace(this.thresholdGamma);
			}

			// Token: 0x0600BE99 RID: 48793 RVA: 0x00563E4F File Offset: 0x0056204F
			public float HPFEBIKDJJA()
			{
				return Mathf.Max(1960f, this.threshold);
			}

			// Token: 0x0600BE9A RID: 48794 RVA: 0x00563B2E File Offset: 0x00561D2E
			public float OKBAPIDLINL()
			{
				return Mathf.GammaToLinearSpace(this.BMIICFKLJDO());
			}

			// Token: 0x0600BE9B RID: 48795 RVA: 0x00563ACA File Offset: 0x00561CCA
			public void PNCNOLEOPOB(float DCCPCBLODIG)
			{
				this.threshold = Mathf.LinearToGammaSpace(DCCPCBLODIG);
			}

			// Token: 0x0600BE9C RID: 48796 RVA: 0x005639F4 File Offset: 0x00561BF4
			public void FFGPCGDBNFE(float DCCPCBLODIG)
			{
				this.threshold = DCCPCBLODIG;
			}

			// Token: 0x0600BE9D RID: 48797 RVA: 0x00563E61 File Offset: 0x00562061
			public float DOGPFJDHANE()
			{
				return Mathf.Max(1663f, this.threshold);
			}

			// Token: 0x0600BE9E RID: 48798 RVA: 0x00563B2E File Offset: 0x00561D2E
			public float MHHDPKCPOFC()
			{
				return Mathf.GammaToLinearSpace(this.BMIICFKLJDO());
			}

			// Token: 0x0600BE9F RID: 48799 RVA: 0x005639F4 File Offset: 0x00561BF4
			public void JJOLJOMPFEK(float DCCPCBLODIG)
			{
				this.threshold = DCCPCBLODIG;
			}

			// Token: 0x0600BEA0 RID: 48800 RVA: 0x00563E74 File Offset: 0x00562074
			public static Bloom.Settings GDHOHBHNEKC()
			{
				return new Bloom.Settings
				{
					threshold = 1755f,
					softKnee = 125f,
					radius = 178f,
					intensity = 705f,
					highQuality = true,
					antiFlicker = true
				};
			}

			// Token: 0x0600BEA1 RID: 48801 RVA: 0x00563ACA File Offset: 0x00561CCA
			public void MKLBAKFHPAG(float DCCPCBLODIG)
			{
				this.threshold = Mathf.LinearToGammaSpace(DCCPCBLODIG);
			}

			// Token: 0x0600BEA2 RID: 48802 RVA: 0x005639F4 File Offset: 0x00561BF4
			public void OFLFOPHJCGL(float DCCPCBLODIG)
			{
				this.threshold = DCCPCBLODIG;
			}

			// Token: 0x0600BEA3 RID: 48803 RVA: 0x005639F4 File Offset: 0x00561BF4
			public void IALNPBGEHCD(float DCCPCBLODIG)
			{
				this.threshold = DCCPCBLODIG;
			}

			// Token: 0x0600BEA4 RID: 48804 RVA: 0x00563ACA File Offset: 0x00561CCA
			public void APBPHGKKIGA(float DCCPCBLODIG)
			{
				this.threshold = Mathf.LinearToGammaSpace(DCCPCBLODIG);
			}

			// Token: 0x0600BEA5 RID: 48805 RVA: 0x00563ACA File Offset: 0x00561CCA
			public void BAHIEJJMPFN(float DCCPCBLODIG)
			{
				this.threshold = Mathf.LinearToGammaSpace(DCCPCBLODIG);
			}

			// Token: 0x0600BEA6 RID: 48806 RVA: 0x00563ECA File Offset: 0x005620CA
			public float HENCBJAKEGD()
			{
				return Mathf.GammaToLinearSpace(this.IPKFOGEILMO());
			}

			// Token: 0x0600BEA7 RID: 48807 RVA: 0x00563CEA File Offset: 0x00561EEA
			public float OGMKIPJCANK()
			{
				return Mathf.GammaToLinearSpace(this.HNNLALFFJBH());
			}

			// Token: 0x0600BEA8 RID: 48808 RVA: 0x00563ED7 File Offset: 0x005620D7
			public float MNNENOHJEOF()
			{
				return Mathf.Max(496f, this.threshold);
			}

			// Token: 0x0600BEA9 RID: 48809 RVA: 0x00563EEC File Offset: 0x005620EC
			public static Bloom.Settings PNOEKODJPPM()
			{
				return new Bloom.Settings
				{
					threshold = 1600f,
					softKnee = 476f,
					radius = 1504f,
					intensity = 37f,
					highQuality = true,
					antiFlicker = false
				};
			}

			// Token: 0x0600BEAA RID: 48810 RVA: 0x005639F4 File Offset: 0x00561BF4
			public void FLPFCLDHMCA(float DCCPCBLODIG)
			{
				this.threshold = DCCPCBLODIG;
			}

			// Token: 0x0600BEAB RID: 48811 RVA: 0x00563F42 File Offset: 0x00562142
			public float OEBGPOKIOHB()
			{
				return Mathf.GammaToLinearSpace(this.MNNENOHJEOF());
			}

			// Token: 0x0600BEAC RID: 48812 RVA: 0x00563F4F File Offset: 0x0056214F
			public float IPKFOGEILMO()
			{
				return Mathf.Max(186f, this.threshold);
			}

			// Token: 0x0600BEAD RID: 48813 RVA: 0x005639F4 File Offset: 0x00561BF4
			public void LEGIDIHGAGJ(float DCCPCBLODIG)
			{
				this.threshold = DCCPCBLODIG;
			}

			// Token: 0x0600BEAE RID: 48814 RVA: 0x00563F61 File Offset: 0x00562161
			public float DKMKKGPMOLP()
			{
				return Mathf.Max(1015f, this.threshold);
			}

			// Token: 0x0600BEAF RID: 48815 RVA: 0x00563F74 File Offset: 0x00562174
			public static Bloom.Settings JDBFJOJBCFD()
			{
				return new Bloom.Settings
				{
					threshold = 1455f,
					softKnee = 1850f,
					radius = 1170f,
					intensity = 344f,
					highQuality = false,
					antiFlicker = true
				};
			}

			// Token: 0x0600BEB0 RID: 48816 RVA: 0x00563FCC File Offset: 0x005621CC
			public static Bloom.Settings JKJFKBDBKIK()
			{
				return new Bloom.Settings
				{
					threshold = 1737f,
					softKnee = 1402f,
					radius = 1566f,
					intensity = 843f,
					highQuality = true,
					antiFlicker = true
				};
			}

			// Token: 0x0600BEB1 RID: 48817 RVA: 0x00563B2E File Offset: 0x00561D2E
			public float NILLLHICICL()
			{
				return Mathf.GammaToLinearSpace(this.BMIICFKLJDO());
			}

			// Token: 0x0600BEB2 RID: 48818 RVA: 0x005639F4 File Offset: 0x00561BF4
			public void ACAGLEBBCEJ(float DCCPCBLODIG)
			{
				this.threshold = DCCPCBLODIG;
			}

			// Token: 0x0600BEB3 RID: 48819 RVA: 0x00564024 File Offset: 0x00562224
			public static Bloom.Settings CFDEGKLCMJB()
			{
				return new Bloom.Settings
				{
					threshold = 703f,
					softKnee = 823f,
					radius = 1430f,
					intensity = 299f,
					highQuality = false,
					antiFlicker = true
				};
			}

			// Token: 0x0600BEB4 RID: 48820 RVA: 0x005639F4 File Offset: 0x00561BF4
			public void CEILHBGBGEE(float DCCPCBLODIG)
			{
				this.threshold = DCCPCBLODIG;
			}

			// Token: 0x0600BEB5 RID: 48821 RVA: 0x0056407C File Offset: 0x0056227C
			public static Bloom.Settings ALMDBBDOPCB()
			{
				return new Bloom.Settings
				{
					threshold = 1686f,
					softKnee = 1475f,
					radius = 1738f,
					intensity = 817f,
					highQuality = false,
					antiFlicker = true
				};
			}

			// Token: 0x0600BEB6 RID: 48822 RVA: 0x005640D4 File Offset: 0x005622D4
			public static Bloom.Settings OJPFNCGOHDM()
			{
				return new Bloom.Settings
				{
					threshold = 299f,
					softKnee = 630f,
					radius = 627f,
					intensity = 1844f,
					highQuality = false,
					antiFlicker = true
				};
			}

			// Token: 0x0600BEB7 RID: 48823 RVA: 0x0056412C File Offset: 0x0056232C
			public static Bloom.Settings FOIBEMMLGFL()
			{
				return new Bloom.Settings
				{
					threshold = 594f,
					softKnee = 289f,
					radius = 1841f,
					intensity = 1174f,
					highQuality = false,
					antiFlicker = true
				};
			}

			// Token: 0x0600BEB8 RID: 48824 RVA: 0x005639F4 File Offset: 0x00561BF4
			public void NAPBFHKIOAO(float DCCPCBLODIG)
			{
				this.threshold = DCCPCBLODIG;
			}

			// Token: 0x0600BEB9 RID: 48825 RVA: 0x005639F4 File Offset: 0x00561BF4
			public void CKKAMCJDHOM(float DCCPCBLODIG)
			{
				this.threshold = DCCPCBLODIG;
			}

			// Token: 0x0600BEBA RID: 48826 RVA: 0x005639F4 File Offset: 0x00561BF4
			public void JJCPCJFCKOF(float DCCPCBLODIG)
			{
				this.threshold = DCCPCBLODIG;
			}

			// Token: 0x0600BEBB RID: 48827 RVA: 0x005639F4 File Offset: 0x00561BF4
			public void JPCKMHFEDGH(float DCCPCBLODIG)
			{
				this.threshold = DCCPCBLODIG;
			}

			// Token: 0x0600BEBC RID: 48828 RVA: 0x00564182 File Offset: 0x00562382
			public float PICHICCFILI()
			{
				return Mathf.Max(1786f, this.threshold);
			}

			// Token: 0x0600BEBD RID: 48829 RVA: 0x00563DD2 File Offset: 0x00561FD2
			public float PIIKHFFMNIE()
			{
				return Mathf.GammaToLinearSpace(this.JBAJNMAIKGI());
			}

			// Token: 0x0600BEBE RID: 48830 RVA: 0x005639F4 File Offset: 0x00561BF4
			public void BAECCNLEOLK(float DCCPCBLODIG)
			{
				this.threshold = DCCPCBLODIG;
			}

			// Token: 0x0600BEC0 RID: 48832 RVA: 0x00564194 File Offset: 0x00562394
			public float KCODGLMFJDO()
			{
				return Mathf.Max(1035f, this.threshold);
			}

			// Token: 0x0600BEC1 RID: 48833 RVA: 0x005639F4 File Offset: 0x00561BF4
			public void FFCDDFOONOG(float DCCPCBLODIG)
			{
				this.threshold = DCCPCBLODIG;
			}

			// Token: 0x0600BEC2 RID: 48834 RVA: 0x00563B3B File Offset: 0x00561D3B
			public float AMMBHJJDFLG()
			{
				return Mathf.GammaToLinearSpace(this.DOGPFJDHANE());
			}

			// Token: 0x0600BEC3 RID: 48835 RVA: 0x00563DDF File Offset: 0x00561FDF
			public float DIMOBPNBFKM()
			{
				return Mathf.GammaToLinearSpace(this.thresholdGamma);
			}

			// Token: 0x0600BEC4 RID: 48836 RVA: 0x005639F4 File Offset: 0x00561BF4
			public void NJGDDKJKIKO(float DCCPCBLODIG)
			{
				this.threshold = DCCPCBLODIG;
			}

			// Token: 0x0600BEC5 RID: 48837 RVA: 0x005641A6 File Offset: 0x005623A6
			public float MNBKFJGMNAP()
			{
				return Mathf.GammaToLinearSpace(this.PICHICCFILI());
			}

			// Token: 0x0600BEC6 RID: 48838 RVA: 0x005641B3 File Offset: 0x005623B3
			public float OCFDJPFHJMF()
			{
				return Mathf.Max(1738f, this.threshold);
			}

			// Token: 0x0600BEC7 RID: 48839 RVA: 0x005641C5 File Offset: 0x005623C5
			public float PLGMNJKGNHH()
			{
				return Mathf.Max(456f, this.threshold);
			}

			// Token: 0x0600BEC8 RID: 48840 RVA: 0x005641D7 File Offset: 0x005623D7
			public float CODPLMPHGDK()
			{
				return Mathf.GammaToLinearSpace(this.HPFEBIKDJJA());
			}

			// Token: 0x0600BEC9 RID: 48841 RVA: 0x005641E4 File Offset: 0x005623E4
			public static Bloom.Settings LKFMGJKJHBI()
			{
				return new Bloom.Settings
				{
					threshold = 1469f,
					softKnee = 1600f,
					radius = 1616f,
					intensity = 1404f,
					highQuality = false,
					antiFlicker = false
				};
			}

			// Token: 0x0600BECA RID: 48842 RVA: 0x00563C84 File Offset: 0x00561E84
			public float PHLALNMLMOK()
			{
				return Mathf.GammaToLinearSpace(this.ONLEEOGLFKH());
			}

			// Token: 0x0600BECB RID: 48843 RVA: 0x0056423A File Offset: 0x0056243A
			public float ONLEEOGLFKH()
			{
				return Mathf.Max(1222f, this.threshold);
			}

			// Token: 0x0600BECC RID: 48844 RVA: 0x0056424C File Offset: 0x0056244C
			public static Bloom.Settings MDDFLLOCDEA()
			{
				return new Bloom.Settings
				{
					threshold = 902f,
					softKnee = 65f,
					radius = 1511f,
					intensity = 342f,
					highQuality = true,
					antiFlicker = true
				};
			}

			// Token: 0x0600BECD RID: 48845 RVA: 0x00563DD2 File Offset: 0x00561FD2
			public float MPNELPEJKJJ()
			{
				return Mathf.GammaToLinearSpace(this.JBAJNMAIKGI());
			}

			// Token: 0x0600BECE RID: 48846 RVA: 0x005642A4 File Offset: 0x005624A4
			public static Bloom.Settings FDJGAAIOLCD()
			{
				return new Bloom.Settings
				{
					threshold = 74f,
					softKnee = 1738f,
					radius = 1634f,
					intensity = 1314f,
					highQuality = true,
					antiFlicker = true
				};
			}

			// Token: 0x0600BECF RID: 48847 RVA: 0x005642FC File Offset: 0x005624FC
			public static Bloom.Settings BAMKFDHJPLO()
			{
				return new Bloom.Settings
				{
					threshold = 1787f,
					softKnee = 1052f,
					radius = 68f,
					intensity = 494f,
					highQuality = true,
					antiFlicker = true
				};
			}

			// Token: 0x0600BED0 RID: 48848 RVA: 0x00563CF7 File Offset: 0x00561EF7
			public float LDBGGPOAJDI()
			{
				return Mathf.GammaToLinearSpace(this.DKMKKGPMOLP());
			}

			// Token: 0x0600BED1 RID: 48849 RVA: 0x00563ACA File Offset: 0x00561CCA
			public void GPGBDFEEBKD(float DCCPCBLODIG)
			{
				this.threshold = Mathf.LinearToGammaSpace(DCCPCBLODIG);
			}

			// Token: 0x0600BED2 RID: 48850 RVA: 0x005639F4 File Offset: 0x00561BF4
			public void GDCKMGAECPD(float DCCPCBLODIG)
			{
				this.threshold = DCCPCBLODIG;
			}

			// Token: 0x0600BED3 RID: 48851 RVA: 0x005639F4 File Offset: 0x00561BF4
			public void MOEEIBPDIEH(float DCCPCBLODIG)
			{
				this.threshold = DCCPCBLODIG;
			}

			// Token: 0x0600BED4 RID: 48852 RVA: 0x00563CF7 File Offset: 0x00561EF7
			public float JMCMDNFNKMN()
			{
				return Mathf.GammaToLinearSpace(this.DKMKKGPMOLP());
			}

			// Token: 0x0600BED5 RID: 48853 RVA: 0x00564352 File Offset: 0x00562552
			public float BMIICFKLJDO()
			{
				return Mathf.Max(335f, this.threshold);
			}

			// Token: 0x0600BED6 RID: 48854 RVA: 0x00563CF7 File Offset: 0x00561EF7
			public float FJNMBNFAHJB()
			{
				return Mathf.GammaToLinearSpace(this.DKMKKGPMOLP());
			}

			// Token: 0x0600BED7 RID: 48855 RVA: 0x00563B3B File Offset: 0x00561D3B
			public float LIDPKPPEIAB()
			{
				return Mathf.GammaToLinearSpace(this.DOGPFJDHANE());
			}

			// Token: 0x0600BED8 RID: 48856 RVA: 0x00564364 File Offset: 0x00562564
			public static Bloom.Settings JGNKGPFJFHO()
			{
				return new Bloom.Settings
				{
					threshold = 786f,
					softKnee = 391f,
					radius = 581f,
					intensity = 1449f,
					highQuality = false,
					antiFlicker = false
				};
			}

			// Token: 0x0600BED9 RID: 48857 RVA: 0x005639F4 File Offset: 0x00561BF4
			public void GJNIADJLKIA(float DCCPCBLODIG)
			{
				this.threshold = DCCPCBLODIG;
			}

			// Token: 0x0600BEDA RID: 48858 RVA: 0x005643BA File Offset: 0x005625BA
			public float IFBDOEFBKFP()
			{
				return Mathf.GammaToLinearSpace(this.PLGMNJKGNHH());
			}

			// Token: 0x0600BEDB RID: 48859 RVA: 0x005639E7 File Offset: 0x00561BE7
			public float EKJPPOEDKJG()
			{
				return Mathf.GammaToLinearSpace(this.ALNCINDCPNM());
			}

			// Token: 0x0600BEDC RID: 48860 RVA: 0x00563B3B File Offset: 0x00561D3B
			public float JIGOJOABGFN()
			{
				return Mathf.GammaToLinearSpace(this.DOGPFJDHANE());
			}

			// Token: 0x0600BEDD RID: 48861 RVA: 0x005643C7 File Offset: 0x005625C7
			public float NNLMDEFFPMD()
			{
				return Mathf.Max(1848f, this.threshold);
			}

			// Token: 0x0600BEDE RID: 48862 RVA: 0x005639F4 File Offset: 0x00561BF4
			public void FKIKCEEIKMM(float DCCPCBLODIG)
			{
				this.threshold = DCCPCBLODIG;
			}

			// Token: 0x0600BEDF RID: 48863 RVA: 0x00563DD2 File Offset: 0x00561FD2
			public float CBGNLIAKPII()
			{
				return Mathf.GammaToLinearSpace(this.JBAJNMAIKGI());
			}

			// Token: 0x0600BEE0 RID: 48864 RVA: 0x005643D9 File Offset: 0x005625D9
			public float HNNLALFFJBH()
			{
				return Mathf.Max(606f, this.threshold);
			}

			// Token: 0x0600BEE1 RID: 48865 RVA: 0x005639F4 File Offset: 0x00561BF4
			public void OMEOKEMHPOF(float DCCPCBLODIG)
			{
				this.threshold = DCCPCBLODIG;
			}

			// Token: 0x0600BEE2 RID: 48866 RVA: 0x005639F4 File Offset: 0x00561BF4
			public void CDIPMHEPGHI(float DCCPCBLODIG)
			{
				this.threshold = DCCPCBLODIG;
			}

			// Token: 0x0600BEE3 RID: 48867 RVA: 0x005639E7 File Offset: 0x00561BE7
			public float LFHCHCKDFKJ()
			{
				return Mathf.GammaToLinearSpace(this.ALNCINDCPNM());
			}

			// Token: 0x0600BEE4 RID: 48868 RVA: 0x005643EB File Offset: 0x005625EB
			public float FFNKECIHFOC()
			{
				return Mathf.Max(293f, this.threshold);
			}

			// Token: 0x0600BEE5 RID: 48869 RVA: 0x005639F4 File Offset: 0x00561BF4
			public void CFFGMLJLAKN(float DCCPCBLODIG)
			{
				this.threshold = DCCPCBLODIG;
			}

			// Token: 0x0600BEE6 RID: 48870 RVA: 0x00563ACA File Offset: 0x00561CCA
			public void HPJCJKEBDEH(float DCCPCBLODIG)
			{
				this.threshold = Mathf.LinearToGammaSpace(DCCPCBLODIG);
			}

			// Token: 0x0600BEE7 RID: 48871 RVA: 0x005643FD File Offset: 0x005625FD
			public float MDOMKFNFCNN()
			{
				return Mathf.Max(1200f, this.threshold);
			}

			// Token: 0x0600BEE8 RID: 48872 RVA: 0x0056440F File Offset: 0x0056260F
			public float JBAJNMAIKGI()
			{
				return Mathf.Max(1191f, this.threshold);
			}

			// Token: 0x0600BEE9 RID: 48873 RVA: 0x005639F4 File Offset: 0x00561BF4
			public void JCAEPHOJHOB(float DCCPCBLODIG)
			{
				this.threshold = DCCPCBLODIG;
			}

			// Token: 0x0600BEEA RID: 48874 RVA: 0x00564424 File Offset: 0x00562624
			public static Bloom.Settings IGIKNGLDPJB()
			{
				return new Bloom.Settings
				{
					threshold = 196f,
					softKnee = 1616f,
					radius = 1990f,
					intensity = 1016f,
					highQuality = false,
					antiFlicker = false
				};
			}

			// Token: 0x0600BEEB RID: 48875 RVA: 0x005643BA File Offset: 0x005625BA
			public float PLMEBOGCABC()
			{
				return Mathf.GammaToLinearSpace(this.PLGMNJKGNHH());
			}

			// Token: 0x040018D6 RID: 6358
			[SerializeField]
			[Tooltip("Filters out pixels under this level of brightness.")]
			public float threshold;

			// Token: 0x040018D7 RID: 6359
			[SerializeField]
			[Range(0f, 1f)]
			[Tooltip("Makes transition between under/over-threshold gradual.")]
			public float softKnee;

			// Token: 0x040018D8 RID: 6360
			[SerializeField]
			[Range(1f, 7f)]
			[Tooltip("Changes extent of veiling effects in a screen resolution-independent fashion.")]
			public float radius;

			// Token: 0x040018D9 RID: 6361
			[SerializeField]
			[Tooltip("Blend factor of the result image.")]
			public float intensity;

			// Token: 0x040018DA RID: 6362
			[Tooltip("Controls filter quality and buffer resolution.")]
			[SerializeField]
			public bool highQuality;

			// Token: 0x040018DB RID: 6363
			[Tooltip("Reduces flashing noise with an additional filter.")]
			[SerializeField]
			public bool antiFlicker;
		}
	}
}
