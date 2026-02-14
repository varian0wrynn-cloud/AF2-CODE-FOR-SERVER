using System;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	// Token: 0x02000349 RID: 841
	[Serializable]
	public class FXAA : MNAIGPKICAE
	{
		// Token: 0x0600BF0A RID: 48906 RVA: 0x0056468C File Offset: 0x0056288C
		public void DHJHEGHEGOH(Camera LBCHLCGOCOD, RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.CJOMCEBOFKB().SetVector("u_UniqueShadowMatrix", new Vector3(this.preset.qualitySettings.subpixelAliasingRemovalAmount, this.preset.qualitySettings.edgeDetectionThreshold, this.preset.qualitySettings.minimumRequiredLuminance));
			this.CDHGPDDEKDF().SetVector("", new Vector4(this.preset.consoleSettings.subpixelSpreadAmount, this.preset.consoleSettings.edgeSharpnessAmount, this.preset.consoleSettings.edgeDetectionThreshold, this.preset.consoleSettings.minimumRequiredLuminance));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.MFJAILMGELI(), 0);
		}

		// Token: 0x0600BF0B RID: 48907 RVA: 0x00564746 File Offset: 0x00562946
		public bool DAPDMPGLGID()
		{
			return this.<validSourceFormat>k__BackingField;
		}

		// Token: 0x0600BF0C RID: 48908 RVA: 0x0056474E File Offset: 0x0056294E
		public void APJACOJADAF()
		{
			if (this.m_Material != null)
			{
				UnityEngine.Object.DestroyImmediate(this.m_Material);
			}
		}

		// Token: 0x0600BF0D RID: 48909 RVA: 0x00022FCC File Offset: 0x000211CC
		public void GEKDJDMHMKC(Camera LBCHLCGOCOD)
		{
		}

		// Token: 0x0600BF0E RID: 48910 RVA: 0x00022FCC File Offset: 0x000211CC
		public void EPOJLAKECDD(Camera LBCHLCGOCOD)
		{
		}

		// Token: 0x0600BF0F RID: 48911 RVA: 0x00564769 File Offset: 0x00562969
		private Shader NOPIBPGHFFB()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("FlyDown");
			}
			return this.m_Shader;
		}

		// Token: 0x0600BF10 RID: 48912 RVA: 0x00564746 File Offset: 0x00562946
		public bool LBINIFADPNE()
		{
			return this.<validSourceFormat>k__BackingField;
		}

		// Token: 0x0600BF11 RID: 48913 RVA: 0x0056478F File Offset: 0x0056298F
		public void INEHANLJIEM(AntiAliasing EJJPBLDJFDF)
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.NOPIBPGHFFB(), false, true, EJJPBLDJFDF))
			{
				EJJPBLDJFDF.enabled = true;
			}
		}

		// Token: 0x0600BF12 RID: 48914 RVA: 0x00564746 File Offset: 0x00562946
		public bool CPNPHHEKLEI()
		{
			return this.<validSourceFormat>k__BackingField;
		}

		// Token: 0x0600BF13 RID: 48915 RVA: 0x005647A8 File Offset: 0x005629A8
		public void KDOIOPJDJPL(AntiAliasing EJJPBLDJFDF)
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.FKCEGCLBKLL(), false, false, EJJPBLDJFDF))
			{
				EJJPBLDJFDF.enabled = false;
			}
		}

		// Token: 0x0600BF14 RID: 48916 RVA: 0x005647C1 File Offset: 0x005629C1
		private void CEKNLOEBIOL(bool DCCPCBLODIG)
		{
			this.<validSourceFormat>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600BF15 RID: 48917 RVA: 0x005647CA File Offset: 0x005629CA
		public void ADBAOPJBGHG(AntiAliasing EJJPBLDJFDF)
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.shader, true, false, EJJPBLDJFDF))
			{
				EJJPBLDJFDF.enabled = false;
			}
		}

		// Token: 0x0600BF16 RID: 48918 RVA: 0x0056474E File Offset: 0x0056294E
		public void GPCIBDPEAAE()
		{
			if (this.m_Material != null)
			{
				UnityEngine.Object.DestroyImmediate(this.m_Material);
			}
		}

		// Token: 0x0600BF17 RID: 48919 RVA: 0x00022FCC File Offset: 0x000211CC
		public void OEMNNJHHGCI(Camera LBCHLCGOCOD)
		{
		}

		// Token: 0x0600BF18 RID: 48920 RVA: 0x00022FCC File Offset: 0x000211CC
		public void ELOEBKBLKEE(Camera LBCHLCGOCOD)
		{
		}

		// Token: 0x0600BF19 RID: 48921 RVA: 0x005647E3 File Offset: 0x005629E3
		public void OJJKNBMONMD(AntiAliasing EJJPBLDJFDF)
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.PLOGCHLJKKE(), false, false, EJJPBLDJFDF))
			{
				EJJPBLDJFDF.enabled = false;
			}
		}

		// Token: 0x0600BF1A RID: 48922 RVA: 0x00022FCC File Offset: 0x000211CC
		public void GKEJIOGFFJL(Camera LBCHLCGOCOD)
		{
		}

		// Token: 0x0600BF1B RID: 48923 RVA: 0x005647C1 File Offset: 0x005629C1
		private void BEBOHGPHNGH(bool DCCPCBLODIG)
		{
			this.<validSourceFormat>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600BF1C RID: 48924 RVA: 0x005647FC File Offset: 0x005629FC
		public void MIJCMMIJPEE(Camera LBCHLCGOCOD, RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.MFJAILMGELI().SetVector("1HandSwordChargeSwipe", new Vector3(this.preset.qualitySettings.subpixelAliasingRemovalAmount, this.preset.qualitySettings.edgeDetectionThreshold, this.preset.qualitySettings.minimumRequiredLuminance));
			this.material.SetVector("Face Hit", new Vector4(this.preset.consoleSettings.subpixelSpreadAmount, this.preset.consoleSettings.edgeSharpnessAmount, this.preset.consoleSettings.edgeDetectionThreshold, this.preset.consoleSettings.minimumRequiredLuminance));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.DNCJDOFOENA(), 0);
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x0600BF21 RID: 48929 RVA: 0x00564746 File Offset: 0x00562946
		// (set) Token: 0x0600BF1D RID: 48925 RVA: 0x005647C1 File Offset: 0x005629C1
		public bool validSourceFormat { get; private set; }

		// Token: 0x0600BF1E RID: 48926 RVA: 0x005648B6 File Offset: 0x00562AB6
		public Material CJOMCEBOFKB()
		{
			if (this.m_Material == null)
			{
				this.m_Material = OOFCHDPCJIJ.DJFOEIJIMJB(this.PLOGCHLJKKE());
			}
			return this.m_Material;
		}

		// Token: 0x0600BF1F RID: 48927 RVA: 0x00022FCC File Offset: 0x000211CC
		public void IEBABOKHKPC(Camera LBCHLCGOCOD)
		{
		}

		// Token: 0x0600BF20 RID: 48928 RVA: 0x00564746 File Offset: 0x00562946
		public bool IPGKGDFIOHN()
		{
			return this.<validSourceFormat>k__BackingField;
		}

		// Token: 0x0600BF22 RID: 48930 RVA: 0x005648E0 File Offset: 0x00562AE0
		public void MAIGIEENOEJ(Camera LBCHLCGOCOD, RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.CDHGPDDEKDF().SetVector("_MainTex", new Vector3(this.preset.qualitySettings.subpixelAliasingRemovalAmount, this.preset.qualitySettings.edgeDetectionThreshold, this.preset.qualitySettings.minimumRequiredLuminance));
			this.material.SetVector("<b>ObscuredString:</b> ", new Vector4(this.preset.consoleSettings.subpixelSpreadAmount, this.preset.consoleSettings.edgeSharpnessAmount, this.preset.consoleSettings.edgeDetectionThreshold, this.preset.consoleSettings.minimumRequiredLuminance));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.DNCJDOFOENA(), 1);
		}

		// Token: 0x0600BF23 RID: 48931 RVA: 0x0056499A File Offset: 0x00562B9A
		public Material DNCJDOFOENA()
		{
			if (this.m_Material == null)
			{
				this.m_Material = OOFCHDPCJIJ.DJFOEIJIMJB(this.MOPEFIMBOED());
			}
			return this.m_Material;
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x0600BF24 RID: 48932 RVA: 0x005649C1 File Offset: 0x00562BC1
		public Material material
		{
			get
			{
				if (this.m_Material == null)
				{
					this.m_Material = OOFCHDPCJIJ.DJFOEIJIMJB(this.shader);
				}
				return this.m_Material;
			}
		}

		// Token: 0x0600BF25 RID: 48933 RVA: 0x00564746 File Offset: 0x00562946
		public bool LLCKJGOOKKB()
		{
			return this.<validSourceFormat>k__BackingField;
		}

		// Token: 0x0600BF26 RID: 48934 RVA: 0x005649E8 File Offset: 0x00562BE8
		public void BPPEDFOAHLK(Camera LBCHLCGOCOD, RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.material.SetVector("_QualitySettings", new Vector3(this.preset.qualitySettings.subpixelAliasingRemovalAmount, this.preset.qualitySettings.edgeDetectionThreshold, this.preset.qualitySettings.minimumRequiredLuminance));
			this.material.SetVector("_ConsoleSettings", new Vector4(this.preset.consoleSettings.subpixelSpreadAmount, this.preset.consoleSettings.edgeSharpnessAmount, this.preset.consoleSettings.edgeDetectionThreshold, this.preset.consoleSettings.minimumRequiredLuminance));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.material, 0);
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x0600BF27 RID: 48935 RVA: 0x00564AA2 File Offset: 0x00562CA2
		private Shader shader
		{
			get
			{
				if (this.m_Shader == null)
				{
					this.m_Shader = Shader.Find("Hidden/Fast Approximate Anti-aliasing");
				}
				return this.m_Shader;
			}
		}

		// Token: 0x0600BF28 RID: 48936 RVA: 0x00564AC8 File Offset: 0x00562CC8
		public void EKMKDLLLGFB(Camera LBCHLCGOCOD, RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.DNCJDOFOENA().SetVector("OfficeSittingReadingPageFlip", new Vector3(this.preset.qualitySettings.subpixelAliasingRemovalAmount, this.preset.qualitySettings.edgeDetectionThreshold, this.preset.qualitySettings.minimumRequiredLuminance));
			this.DNCJDOFOENA().SetVector("R", new Vector4(this.preset.consoleSettings.subpixelSpreadAmount, this.preset.consoleSettings.edgeSharpnessAmount, this.preset.consoleSettings.edgeDetectionThreshold, this.preset.consoleSettings.minimumRequiredLuminance));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.DNCJDOFOENA(), 1);
		}

		// Token: 0x0600BF29 RID: 48937 RVA: 0x00022FCC File Offset: 0x000211CC
		public void IGCJBOFOEFM(Camera LBCHLCGOCOD)
		{
		}

		// Token: 0x0600BF2A RID: 48938 RVA: 0x00564B82 File Offset: 0x00562D82
		public Material CDHGPDDEKDF()
		{
			if (this.m_Material == null)
			{
				this.m_Material = OOFCHDPCJIJ.DJFOEIJIMJB(this.FKCEGCLBKLL());
			}
			return this.m_Material;
		}

		// Token: 0x0600BF2B RID: 48939 RVA: 0x00564BAC File Offset: 0x00562DAC
		public void LLIDCMOMECE(Camera LBCHLCGOCOD, RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.LIPNFBCMPCG().SetVector("MAP_NAMES", new Vector3(this.preset.qualitySettings.subpixelAliasingRemovalAmount, this.preset.qualitySettings.edgeDetectionThreshold, this.preset.qualitySettings.minimumRequiredLuminance));
			this.CDHGPDDEKDF().SetVector(", point ", new Vector4(this.preset.consoleSettings.subpixelSpreadAmount, this.preset.consoleSettings.edgeSharpnessAmount, this.preset.consoleSettings.edgeDetectionThreshold, this.preset.consoleSettings.minimumRequiredLuminance));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.MFJAILMGELI(), 1);
		}

		// Token: 0x0600BF2C RID: 48940 RVA: 0x005647C1 File Offset: 0x005629C1
		private void DBJOKMGJBDK(bool DCCPCBLODIG)
		{
			this.<validSourceFormat>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600BF2D RID: 48941 RVA: 0x00022FCC File Offset: 0x000211CC
		public void BMLPMLFEANM(Camera LBCHLCGOCOD)
		{
		}

		// Token: 0x0600BF2E RID: 48942 RVA: 0x00022FCC File Offset: 0x000211CC
		public void JFJJDDLDPOJ(Camera LBCHLCGOCOD)
		{
		}

		// Token: 0x0600BF2F RID: 48943 RVA: 0x00564C66 File Offset: 0x00562E66
		public void DLDOPAGLPPO(AntiAliasing EJJPBLDJFDF)
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.LOFDIJNNCNK(), false, false, EJJPBLDJFDF))
			{
				EJJPBLDJFDF.enabled = false;
			}
		}

		// Token: 0x0600BF30 RID: 48944 RVA: 0x0056474E File Offset: 0x0056294E
		public void BKFHJFNCPAA()
		{
			if (this.m_Material != null)
			{
				UnityEngine.Object.DestroyImmediate(this.m_Material);
			}
		}

		// Token: 0x0600BF31 RID: 48945 RVA: 0x005647C1 File Offset: 0x005629C1
		private void ABEIGOPNBAB(bool DCCPCBLODIG)
		{
			this.<validSourceFormat>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600BF32 RID: 48946 RVA: 0x00564C7F File Offset: 0x00562E7F
		private Shader FKCEGCLBKLL()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("PersonManFisher");
			}
			return this.m_Shader;
		}

		// Token: 0x0600BF33 RID: 48947 RVA: 0x005649C1 File Offset: 0x00562BC1
		public Material HGIJAMABJMC()
		{
			if (this.m_Material == null)
			{
				this.m_Material = OOFCHDPCJIJ.DJFOEIJIMJB(this.shader);
			}
			return this.m_Material;
		}

		// Token: 0x0600BF34 RID: 48948 RVA: 0x005647C1 File Offset: 0x005629C1
		private void NHMIIOJDMNL(bool DCCPCBLODIG)
		{
			this.<validSourceFormat>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600BF35 RID: 48949 RVA: 0x005647C1 File Offset: 0x005629C1
		private void FGNDCGILJFB(bool DCCPCBLODIG)
		{
			this.<validSourceFormat>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600BF36 RID: 48950 RVA: 0x005647C1 File Offset: 0x005629C1
		private void DBOPPNENMAI(bool DCCPCBLODIG)
		{
			this.<validSourceFormat>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600BF37 RID: 48951 RVA: 0x00564CA5 File Offset: 0x00562EA5
		public Material LIPNFBCMPCG()
		{
			if (this.m_Material == null)
			{
				this.m_Material = OOFCHDPCJIJ.DJFOEIJIMJB(this.IEAFBGDNPNF());
			}
			return this.m_Material;
		}

		// Token: 0x0600BF38 RID: 48952 RVA: 0x00022FCC File Offset: 0x000211CC
		public void ADAAFIBDJAO(Camera LBCHLCGOCOD)
		{
		}

		// Token: 0x0600BF39 RID: 48953 RVA: 0x0056474E File Offset: 0x0056294E
		public void KLHDJKDMCJN()
		{
			if (this.m_Material != null)
			{
				UnityEngine.Object.DestroyImmediate(this.m_Material);
			}
		}

		// Token: 0x0600BF3B RID: 48955 RVA: 0x005647C1 File Offset: 0x005629C1
		private void IEMNHLKPJCN(bool DCCPCBLODIG)
		{
			this.<validSourceFormat>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600BF3C RID: 48956 RVA: 0x005647C1 File Offset: 0x005629C1
		private void HAIKPKGEHIA(bool DCCPCBLODIG)
		{
			this.<validSourceFormat>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600BF3D RID: 48957 RVA: 0x00564CDF File Offset: 0x00562EDF
		private Shader LOFDIJNNCNK()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("RollerBladeJump");
			}
			return this.m_Shader;
		}

		// Token: 0x0600BF3E RID: 48958 RVA: 0x00564D05 File Offset: 0x00562F05
		private Shader KPIAFEFGHIP()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("droplinemsg2");
			}
			return this.m_Shader;
		}

		// Token: 0x0600BF3F RID: 48959 RVA: 0x00564D2C File Offset: 0x00562F2C
		public void JPCPEPMDLAN(Camera LBCHLCGOCOD, RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.DNCJDOFOENA().SetVector("_ToPrevViewProjCombined", new Vector3(this.preset.qualitySettings.subpixelAliasingRemovalAmount, this.preset.qualitySettings.edgeDetectionThreshold, this.preset.qualitySettings.minimumRequiredLuminance));
			this.CDHGPDDEKDF().SetVector("", new Vector4(this.preset.consoleSettings.subpixelSpreadAmount, this.preset.consoleSettings.edgeSharpnessAmount, this.preset.consoleSettings.edgeDetectionThreshold, this.preset.consoleSettings.minimumRequiredLuminance));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.MFJAILMGELI(), 1);
		}

		// Token: 0x0600BF40 RID: 48960 RVA: 0x00564746 File Offset: 0x00562946
		public bool MCMNGKDMDEG()
		{
			return this.<validSourceFormat>k__BackingField;
		}

		// Token: 0x0600BF41 RID: 48961 RVA: 0x00564DE6 File Offset: 0x00562FE6
		private Shader MOPEFIMBOED()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("Right Hand Effector needs a Target in this demo.");
			}
			return this.m_Shader;
		}

		// Token: 0x0600BF42 RID: 48962 RVA: 0x00564E0C File Offset: 0x0056300C
		public void MLOBCILJIEC(Camera LBCHLCGOCOD, RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.CDHGPDDEKDF().SetVector("C", new Vector3(this.preset.qualitySettings.subpixelAliasingRemovalAmount, this.preset.qualitySettings.edgeDetectionThreshold, this.preset.qualitySettings.minimumRequiredLuminance));
			this.LIPNFBCMPCG().SetVector("DefaultLut", new Vector4(this.preset.consoleSettings.subpixelSpreadAmount, this.preset.consoleSettings.edgeSharpnessAmount, this.preset.consoleSettings.edgeDetectionThreshold, this.preset.consoleSettings.minimumRequiredLuminance));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.CJOMCEBOFKB(), 1);
		}

		// Token: 0x0600BF43 RID: 48963 RVA: 0x0056474E File Offset: 0x0056294E
		public void EILDKNMOKBB()
		{
			if (this.m_Material != null)
			{
				UnityEngine.Object.DestroyImmediate(this.m_Material);
			}
		}

		// Token: 0x0600BF44 RID: 48964 RVA: 0x0056474E File Offset: 0x0056294E
		public void CCCAOGJKJOD()
		{
			if (this.m_Material != null)
			{
				UnityEngine.Object.DestroyImmediate(this.m_Material);
			}
		}

		// Token: 0x0600BF45 RID: 48965 RVA: 0x005647C1 File Offset: 0x005629C1
		private void HJEEKOINOJM(bool DCCPCBLODIG)
		{
			this.<validSourceFormat>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600BF46 RID: 48966 RVA: 0x0056474E File Offset: 0x0056294E
		public void AHMFIGNLJOB()
		{
			if (this.m_Material != null)
			{
				UnityEngine.Object.DestroyImmediate(this.m_Material);
			}
		}

		// Token: 0x0600BF47 RID: 48967 RVA: 0x00564EC8 File Offset: 0x005630C8
		public void JNGODMMNPEG(Camera LBCHLCGOCOD, RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.DNCJDOFOENA().SetVector("WorkerShovel2", new Vector3(this.preset.qualitySettings.subpixelAliasingRemovalAmount, this.preset.qualitySettings.edgeDetectionThreshold, this.preset.qualitySettings.minimumRequiredLuminance));
			this.material.SetVector("Apply out GAME 1", new Vector4(this.preset.consoleSettings.subpixelSpreadAmount, this.preset.consoleSettings.edgeSharpnessAmount, this.preset.consoleSettings.edgeDetectionThreshold, this.preset.consoleSettings.minimumRequiredLuminance));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.DNCJDOFOENA(), 0);
		}

		// Token: 0x0600BF48 RID: 48968 RVA: 0x00564746 File Offset: 0x00562946
		public bool OCEGJJHICDK()
		{
			return this.<validSourceFormat>k__BackingField;
		}

		// Token: 0x0600BF49 RID: 48969 RVA: 0x00564F82 File Offset: 0x00563182
		public Material MFJAILMGELI()
		{
			if (this.m_Material == null)
			{
				this.m_Material = OOFCHDPCJIJ.DJFOEIJIMJB(this.NOPIBPGHFFB());
			}
			return this.m_Material;
		}

		// Token: 0x0600BF4A RID: 48970 RVA: 0x00564746 File Offset: 0x00562946
		public bool HAJJEKKOAFA()
		{
			return this.<validSourceFormat>k__BackingField;
		}

		// Token: 0x0600BF4B RID: 48971 RVA: 0x00564FA9 File Offset: 0x005631A9
		public void CALDPCOLDNO(AntiAliasing EJJPBLDJFDF)
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.IEAFBGDNPNF(), false, true, EJJPBLDJFDF))
			{
				EJJPBLDJFDF.enabled = false;
			}
		}

		// Token: 0x0600BF4D RID: 48973 RVA: 0x00564746 File Offset: 0x00562946
		public bool DKHLHLJDNGC()
		{
			return this.<validSourceFormat>k__BackingField;
		}

		// Token: 0x0600BF4E RID: 48974 RVA: 0x00565018 File Offset: 0x00563218
		private Shader IEAFBGDNPNF()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("MotorbikeHandstand");
			}
			return this.m_Shader;
		}

		// Token: 0x0600BF4F RID: 48975 RVA: 0x0056474E File Offset: 0x0056294E
		public void LLLBNNNNFPJ()
		{
			if (this.m_Material != null)
			{
				UnityEngine.Object.DestroyImmediate(this.m_Material);
			}
		}

		// Token: 0x0600BF50 RID: 48976 RVA: 0x0056503E File Offset: 0x0056323E
		private Shader PLOGCHLJKKE()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("Idle Keep Back");
			}
			return this.m_Shader;
		}

		// Token: 0x0600BF51 RID: 48977 RVA: 0x00565064 File Offset: 0x00563264
		public void OOGPDGBACLC(AntiAliasing EJJPBLDJFDF)
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.LOFDIJNNCNK(), true, true, EJJPBLDJFDF))
			{
				EJJPBLDJFDF.enabled = true;
			}
		}

		// Token: 0x0600BF52 RID: 48978 RVA: 0x0056474E File Offset: 0x0056294E
		public void DFLLLNDKNBB()
		{
			if (this.m_Material != null)
			{
				UnityEngine.Object.DestroyImmediate(this.m_Material);
			}
		}

		// Token: 0x0600BF53 RID: 48979 RVA: 0x00022FCC File Offset: 0x000211CC
		public void JPFADDECBNB(Camera LBCHLCGOCOD)
		{
		}

		// Token: 0x0600BF54 RID: 48980 RVA: 0x00565080 File Offset: 0x00563280
		public void PPAAMEAPADE(Camera LBCHLCGOCOD, RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.CDHGPDDEKDF().SetVector("\n", new Vector3(this.preset.qualitySettings.subpixelAliasingRemovalAmount, this.preset.qualitySettings.edgeDetectionThreshold, this.preset.qualitySettings.minimumRequiredLuminance));
			this.HGIJAMABJMC().SetVector("soft", new Vector4(this.preset.consoleSettings.subpixelSpreadAmount, this.preset.consoleSettings.edgeSharpnessAmount, this.preset.consoleSettings.edgeDetectionThreshold, this.preset.consoleSettings.minimumRequiredLuminance));
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.MFJAILMGELI(), 1);
		}

		// Token: 0x0600BF55 RID: 48981 RVA: 0x0056474E File Offset: 0x0056294E
		public void PBDNGIFDEFC()
		{
			if (this.m_Material != null)
			{
				UnityEngine.Object.DestroyImmediate(this.m_Material);
			}
		}

		// Token: 0x040018E3 RID: 6371
		private Shader m_Shader;

		// Token: 0x040018E4 RID: 6372
		private Material m_Material;

		// Token: 0x040018E5 RID: 6373
		[SerializeField]
		[HideInInspector]
		public FXAA.Preset preset = FXAA.Preset.defaultPreset;

		// Token: 0x040018E6 RID: 6374
		public static FXAA.Preset[] availablePresets = new FXAA.Preset[]
		{
			FXAA.Preset.extremePerformancePreset,
			FXAA.Preset.performancePreset,
			FXAA.Preset.defaultPreset,
			FXAA.Preset.qualityPreset,
			FXAA.Preset.extremeQualityPreset
		};

		// Token: 0x0200034A RID: 842
		[Serializable]
		public struct QualitySettings
		{
			// Token: 0x040018E8 RID: 6376
			[Tooltip("The amount of desired sub-pixel aliasing removal. Effects the sharpeness of the output.")]
			[Range(0f, 1f)]
			public float subpixelAliasingRemovalAmount;

			// Token: 0x040018E9 RID: 6377
			[Tooltip("The minimum amount of local contrast required to qualify a region as containing an edge.")]
			[Range(0.063f, 0.333f)]
			public float edgeDetectionThreshold;

			// Token: 0x040018EA RID: 6378
			[Range(0f, 0.0833f)]
			[Tooltip("Local contrast adaptation value to disallow the algorithm from executing on the darker regions.")]
			public float minimumRequiredLuminance;
		}

		// Token: 0x0200034B RID: 843
		[Serializable]
		public struct ConsoleSettings
		{
			// Token: 0x040018EB RID: 6379
			[Range(0.33f, 0.5f)]
			[Tooltip("The amount of spread applied to the sampling coordinates while sampling for subpixel information.")]
			public float subpixelSpreadAmount;

			// Token: 0x040018EC RID: 6380
			[Tooltip("This value dictates how sharp the edges in the image are kept; a higher value implies sharper edges.")]
			[Range(2f, 8f)]
			public float edgeSharpnessAmount;

			// Token: 0x040018ED RID: 6381
			[Range(0.125f, 0.25f)]
			[Tooltip("The minimum amount of local contrast required to qualify a region as containing an edge.")]
			public float edgeDetectionThreshold;

			// Token: 0x040018EE RID: 6382
			[Range(0.04f, 0.06f)]
			[Tooltip("Local contrast adaptation value to disallow the algorithm from executing on the darker regions.")]
			public float minimumRequiredLuminance;
		}

		// Token: 0x0200034C RID: 844
		[Serializable]
		public struct Preset
		{
			// Token: 0x0600BF56 RID: 48982 RVA: 0x0056513A File Offset: 0x0056333A
			public static FXAA.Preset JKBHFNOEFMA()
			{
				return FXAA.Preset.s_ExtremeQuality;
			}

			// Token: 0x0600BF57 RID: 48983 RVA: 0x00565141 File Offset: 0x00563341
			public static FXAA.Preset MJOFJOEFGEN()
			{
				return FXAA.Preset.s_Performance;
			}

			// Token: 0x1700028E RID: 654
			// (get) Token: 0x0600BF58 RID: 48984 RVA: 0x00565148 File Offset: 0x00563348
			public static FXAA.Preset extremePerformancePreset
			{
				get
				{
					return FXAA.Preset.s_ExtremePerformance;
				}
			}

			// Token: 0x0600BF59 RID: 48985 RVA: 0x00565141 File Offset: 0x00563341
			public static FXAA.Preset GEOFPMPPBGD()
			{
				return FXAA.Preset.s_Performance;
			}

			// Token: 0x0600BF5A RID: 48986 RVA: 0x00565141 File Offset: 0x00563341
			public static FXAA.Preset JOJIHDLCEMK()
			{
				return FXAA.Preset.s_Performance;
			}

			// Token: 0x0600BF5B RID: 48987 RVA: 0x0056514F File Offset: 0x0056334F
			public static FXAA.Preset EJMFICNBGJI()
			{
				return FXAA.Preset.s_Quality;
			}

			// Token: 0x17000290 RID: 656
			// (get) Token: 0x0600BF5C RID: 48988 RVA: 0x00565156 File Offset: 0x00563356
			public static FXAA.Preset defaultPreset
			{
				get
				{
					return FXAA.Preset.s_Default;
				}
			}

			// Token: 0x0600BF5D RID: 48989 RVA: 0x00565156 File Offset: 0x00563356
			public static FXAA.Preset LCPFIPBCHGC()
			{
				return FXAA.Preset.s_Default;
			}

			// Token: 0x0600BF5F RID: 48991 RVA: 0x00565156 File Offset: 0x00563356
			public static FXAA.Preset MBMDJADDAGC()
			{
				return FXAA.Preset.s_Default;
			}

			// Token: 0x0600BF60 RID: 48992 RVA: 0x0056513A File Offset: 0x0056333A
			public static FXAA.Preset IMHIDPAGJEA()
			{
				return FXAA.Preset.s_ExtremeQuality;
			}

			// Token: 0x0600BF61 RID: 48993 RVA: 0x00565156 File Offset: 0x00563356
			public static FXAA.Preset ADCAFOHAPBA()
			{
				return FXAA.Preset.s_Default;
			}

			// Token: 0x0600BF62 RID: 48994 RVA: 0x00565141 File Offset: 0x00563341
			public static FXAA.Preset FEJLHPJDBAP()
			{
				return FXAA.Preset.s_Performance;
			}

			// Token: 0x0600BF63 RID: 48995 RVA: 0x00565141 File Offset: 0x00563341
			public static FXAA.Preset POMDMJOEPBE()
			{
				return FXAA.Preset.s_Performance;
			}

			// Token: 0x17000292 RID: 658
			// (get) Token: 0x0600BF64 RID: 48996 RVA: 0x0056513A File Offset: 0x0056333A
			public static FXAA.Preset extremeQualityPreset
			{
				get
				{
					return FXAA.Preset.s_ExtremeQuality;
				}
			}

			// Token: 0x0600BF65 RID: 48997 RVA: 0x00565141 File Offset: 0x00563341
			public static FXAA.Preset BFCEKHKLIMD()
			{
				return FXAA.Preset.s_Performance;
			}

			// Token: 0x17000291 RID: 657
			// (get) Token: 0x0600BF66 RID: 48998 RVA: 0x0056514F File Offset: 0x0056334F
			public static FXAA.Preset qualityPreset
			{
				get
				{
					return FXAA.Preset.s_Quality;
				}
			}

			// Token: 0x1700028F RID: 655
			// (get) Token: 0x0600BF67 RID: 48999 RVA: 0x00565141 File Offset: 0x00563341
			public static FXAA.Preset performancePreset
			{
				get
				{
					return FXAA.Preset.s_Performance;
				}
			}

			// Token: 0x0600BF68 RID: 49000 RVA: 0x00565156 File Offset: 0x00563356
			public static FXAA.Preset AMIOKCACMLB()
			{
				return FXAA.Preset.s_Default;
			}

			// Token: 0x0600BF69 RID: 49001 RVA: 0x00565148 File Offset: 0x00563348
			public static FXAA.Preset KGLLGDIAAAG()
			{
				return FXAA.Preset.s_ExtremePerformance;
			}

			// Token: 0x0600BF6A RID: 49002 RVA: 0x0056514F File Offset: 0x0056334F
			public static FXAA.Preset AILMOIMJMKH()
			{
				return FXAA.Preset.s_Quality;
			}

			// Token: 0x0600BF6B RID: 49003 RVA: 0x00565141 File Offset: 0x00563341
			public static FXAA.Preset HPMEOPNFPBM()
			{
				return FXAA.Preset.s_Performance;
			}

			// Token: 0x0600BF6C RID: 49004 RVA: 0x0056514F File Offset: 0x0056334F
			public static FXAA.Preset CJNGDNJLCDG()
			{
				return FXAA.Preset.s_Quality;
			}

			// Token: 0x0600BF6D RID: 49005 RVA: 0x0056513A File Offset: 0x0056333A
			public static FXAA.Preset LMGCDFHBKJA()
			{
				return FXAA.Preset.s_ExtremeQuality;
			}

			// Token: 0x0600BF6E RID: 49006 RVA: 0x00565141 File Offset: 0x00563341
			public static FXAA.Preset JBGHJGJPJIA()
			{
				return FXAA.Preset.s_Performance;
			}

			// Token: 0x0600BF6F RID: 49007 RVA: 0x0056513A File Offset: 0x0056333A
			public static FXAA.Preset IHCCLMPALEC()
			{
				return FXAA.Preset.s_ExtremeQuality;
			}

			// Token: 0x0600BF70 RID: 49008 RVA: 0x00565148 File Offset: 0x00563348
			public static FXAA.Preset PJHAJKAALBL()
			{
				return FXAA.Preset.s_ExtremePerformance;
			}

			// Token: 0x040018EF RID: 6383
			[FXAA.Preset.EAFBGGADPGG]
			public FXAA.QualitySettings qualitySettings;

			// Token: 0x040018F0 RID: 6384
			[FXAA.Preset.EAFBGGADPGG]
			public FXAA.ConsoleSettings consoleSettings;

			// Token: 0x040018F1 RID: 6385
			private static readonly FXAA.Preset s_ExtremePerformance = new FXAA.Preset
			{
				qualitySettings = new FXAA.QualitySettings
				{
					subpixelAliasingRemovalAmount = 0f,
					edgeDetectionThreshold = 0.333f,
					minimumRequiredLuminance = 0.0833f
				},
				consoleSettings = new FXAA.ConsoleSettings
				{
					subpixelSpreadAmount = 0.33f,
					edgeSharpnessAmount = 8f,
					edgeDetectionThreshold = 0.25f,
					minimumRequiredLuminance = 0.06f
				}
			};

			// Token: 0x040018F2 RID: 6386
			private static readonly FXAA.Preset s_Performance = new FXAA.Preset
			{
				qualitySettings = new FXAA.QualitySettings
				{
					subpixelAliasingRemovalAmount = 0.25f,
					edgeDetectionThreshold = 0.25f,
					minimumRequiredLuminance = 0.0833f
				},
				consoleSettings = new FXAA.ConsoleSettings
				{
					subpixelSpreadAmount = 0.33f,
					edgeSharpnessAmount = 8f,
					edgeDetectionThreshold = 0.125f,
					minimumRequiredLuminance = 0.06f
				}
			};

			// Token: 0x040018F3 RID: 6387
			private static readonly FXAA.Preset s_Default = new FXAA.Preset
			{
				qualitySettings = new FXAA.QualitySettings
				{
					subpixelAliasingRemovalAmount = 0.75f,
					edgeDetectionThreshold = 0.166f,
					minimumRequiredLuminance = 0.0833f
				},
				consoleSettings = new FXAA.ConsoleSettings
				{
					subpixelSpreadAmount = 0.5f,
					edgeSharpnessAmount = 8f,
					edgeDetectionThreshold = 0.125f,
					minimumRequiredLuminance = 0.05f
				}
			};

			// Token: 0x040018F4 RID: 6388
			private static readonly FXAA.Preset s_Quality = new FXAA.Preset
			{
				qualitySettings = new FXAA.QualitySettings
				{
					subpixelAliasingRemovalAmount = 1f,
					edgeDetectionThreshold = 0.125f,
					minimumRequiredLuminance = 0.0625f
				},
				consoleSettings = new FXAA.ConsoleSettings
				{
					subpixelSpreadAmount = 0.5f,
					edgeSharpnessAmount = 4f,
					edgeDetectionThreshold = 0.125f,
					minimumRequiredLuminance = 0.04f
				}
			};

			// Token: 0x040018F5 RID: 6389
			private static readonly FXAA.Preset s_ExtremeQuality = new FXAA.Preset
			{
				qualitySettings = new FXAA.QualitySettings
				{
					subpixelAliasingRemovalAmount = 1f,
					edgeDetectionThreshold = 0.063f,
					minimumRequiredLuminance = 0.0312f
				},
				consoleSettings = new FXAA.ConsoleSettings
				{
					subpixelSpreadAmount = 0.5f,
					edgeSharpnessAmount = 2f,
					edgeDetectionThreshold = 0.125f,
					minimumRequiredLuminance = 0.04f
				}
			};

			// Token: 0x0200034D RID: 845
			[AttributeUsage(AttributeTargets.Field)]
			public class EAFBGGADPGG : PropertyAttribute
			{
			}
		}
	}
}
