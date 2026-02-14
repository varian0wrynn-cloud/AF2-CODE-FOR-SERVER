using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x020002FC RID: 764
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Other/Antialiasing")]
	public class Antialiasing : PostEffectsBase
	{
		// Token: 0x0600B2A4 RID: 45732 RVA: 0x004DD5B4 File Offset: 0x004DB7B4
		public Material OOMDGHECOFL()
		{
			Material result;
			switch (this.mode)
			{
			case GIHPHDGBIIG.FXAA2:
				result = this.PIANCPDFNFA;
				break;
			case GIHPHDGBIIG.FXAA3Console:
				result = this.LPNAOMKDNPM;
				break;
			case GIHPHDGBIIG.FXAA1PresetA:
				result = this.EPAFEOKHFAC;
				break;
			case GIHPHDGBIIG.FXAA1PresetB:
				result = this.KJJLPJBLECA;
				break;
			case GIHPHDGBIIG.NFAA:
				result = this.HJPNPFOCKNH;
				break;
			case GIHPHDGBIIG.SSAA:
				result = this.KGHMBEHHMHG;
				break;
			case GIHPHDGBIIG.DLAA:
				result = this.ILKIBIDOMBK;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x0600B2A5 RID: 45733 RVA: 0x004DD630 File Offset: 0x004DB830
		public virtual bool NEOHPOGEHNF()
		{
			base.PKDIKFGAJKM(false);
			this.EPAFEOKHFAC = base.FJMGOIOPENE(this.shaderFXAAPreset2, this.EPAFEOKHFAC);
			this.KJJLPJBLECA = base.LBFLGMNPKHN(this.shaderFXAAPreset3, this.KJJLPJBLECA);
			this.PIANCPDFNFA = base.JAODCGBEAIF(this.shaderFXAAII, this.PIANCPDFNFA);
			this.LPNAOMKDNPM = base.PAGPIKMKGLP(this.shaderFXAAIII, this.LPNAOMKDNPM);
			this.HJPNPFOCKNH = base.DLDCFEJJBBI(this.nfaaShader, this.HJPNPFOCKNH);
			this.KGHMBEHHMHG = base.LBFLGMNPKHN(this.ssaaShader, this.KGHMBEHHMHG);
			this.ILKIBIDOMBK = base.PHNMLJJBKDC(this.dlaaShader, this.ILKIBIDOMBK);
			if (!this.ssaaShader.isSupported)
			{
				base.AGGGAHEKKCO();
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B2A6 RID: 45734 RVA: 0x004DD70C File Offset: 0x004DB90C
		public virtual bool KPDPMCNDNOA()
		{
			base.CGEGCOKMPHN(true);
			this.EPAFEOKHFAC = base.IBKIBFDHBKA(this.shaderFXAAPreset2, this.EPAFEOKHFAC);
			this.KJJLPJBLECA = base.LBFLGMNPKHN(this.shaderFXAAPreset3, this.KJJLPJBLECA);
			this.PIANCPDFNFA = base.PHNMLJJBKDC(this.shaderFXAAII, this.PIANCPDFNFA);
			this.LPNAOMKDNPM = base.IBKIBFDHBKA(this.shaderFXAAIII, this.LPNAOMKDNPM);
			this.HJPNPFOCKNH = base.DLDCFEJJBBI(this.nfaaShader, this.HJPNPFOCKNH);
			this.KGHMBEHHMHG = base.PAGPIKMKGLP(this.ssaaShader, this.KGHMBEHHMHG);
			this.ILKIBIDOMBK = base.PAGPIKMKGLP(this.dlaaShader, this.ILKIBIDOMBK);
			if (!this.ssaaShader.isSupported)
			{
				base.OCGNIJDNOOM();
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B2A7 RID: 45735 RVA: 0x004DD7E8 File Offset: 0x004DB9E8
		public Material BKDFMLGOPJL()
		{
			Material result;
			switch (this.mode)
			{
			case GIHPHDGBIIG.FXAA2:
				result = this.PIANCPDFNFA;
				break;
			case GIHPHDGBIIG.FXAA3Console:
				result = this.LPNAOMKDNPM;
				break;
			case GIHPHDGBIIG.FXAA1PresetA:
				result = this.EPAFEOKHFAC;
				break;
			case GIHPHDGBIIG.FXAA1PresetB:
				result = this.KJJLPJBLECA;
				break;
			case GIHPHDGBIIG.NFAA:
				result = this.HJPNPFOCKNH;
				break;
			case GIHPHDGBIIG.SSAA:
				result = this.KGHMBEHHMHG;
				break;
			case GIHPHDGBIIG.DLAA:
				result = this.ILKIBIDOMBK;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x0600B2A8 RID: 45736 RVA: 0x004DD864 File Offset: 0x004DBA64
		public Material CurrentAAMaterial()
		{
			Material result;
			switch (this.mode)
			{
			case GIHPHDGBIIG.FXAA2:
				result = this.PIANCPDFNFA;
				break;
			case GIHPHDGBIIG.FXAA3Console:
				result = this.LPNAOMKDNPM;
				break;
			case GIHPHDGBIIG.FXAA1PresetA:
				result = this.EPAFEOKHFAC;
				break;
			case GIHPHDGBIIG.FXAA1PresetB:
				result = this.KJJLPJBLECA;
				break;
			case GIHPHDGBIIG.NFAA:
				result = this.HJPNPFOCKNH;
				break;
			case GIHPHDGBIIG.SSAA:
				result = this.KGHMBEHHMHG;
				break;
			case GIHPHDGBIIG.DLAA:
				result = this.ILKIBIDOMBK;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x0600B2A9 RID: 45737 RVA: 0x004DD8E0 File Offset: 0x004DBAE0
		public Material OLKAKPPAJNN()
		{
			Material result;
			switch (this.mode)
			{
			case GIHPHDGBIIG.FXAA2:
				result = this.PIANCPDFNFA;
				break;
			case GIHPHDGBIIG.FXAA3Console:
				result = this.LPNAOMKDNPM;
				break;
			case GIHPHDGBIIG.FXAA1PresetA:
				result = this.EPAFEOKHFAC;
				break;
			case GIHPHDGBIIG.FXAA1PresetB:
				result = this.KJJLPJBLECA;
				break;
			case GIHPHDGBIIG.NFAA:
				result = this.HJPNPFOCKNH;
				break;
			case GIHPHDGBIIG.SSAA:
				result = this.KGHMBEHHMHG;
				break;
			case GIHPHDGBIIG.DLAA:
				result = this.ILKIBIDOMBK;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x0600B2AA RID: 45738 RVA: 0x004DD95C File Offset: 0x004DBB5C
		public void OnRenderImage(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA3Console && this.LPNAOMKDNPM != null)
			{
				this.LPNAOMKDNPM.SetFloat("_EdgeThresholdMin", this.edgeThresholdMin);
				this.LPNAOMKDNPM.SetFloat("_EdgeThreshold", this.edgeThreshold);
				this.LPNAOMKDNPM.SetFloat("_EdgeSharpness", this.edgeSharpness);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LPNAOMKDNPM);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA1PresetB && this.KJJLPJBLECA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KJJLPJBLECA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA1PresetA && this.EPAFEOKHFAC != null)
			{
				JONJODLFAEN.anisoLevel = 4;
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EPAFEOKHFAC);
				JONJODLFAEN.anisoLevel = 0;
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.PIANCPDFNFA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PIANCPDFNFA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.SSAA && this.KGHMBEHHMHG != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KGHMBEHHMHG);
				return;
			}
			if (this.mode == GIHPHDGBIIG.DLAA && this.ILKIBIDOMBK != null)
			{
				JONJODLFAEN.anisoLevel = 0;
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
				Graphics.Blit(JONJODLFAEN, temporary, this.ILKIBIDOMBK, 0);
				Graphics.Blit(temporary, OKIIDHIJBEA, this.ILKIBIDOMBK, this.dlaaSharp ? 2 : 1);
				RenderTexture.ReleaseTemporary(temporary);
				return;
			}
			if (this.mode == GIHPHDGBIIG.NFAA && this.HJPNPFOCKNH != null)
			{
				JONJODLFAEN.anisoLevel = 0;
				this.HJPNPFOCKNH.SetFloat("_OffsetScale", this.offsetScale);
				this.HJPNPFOCKNH.SetFloat("_BlurRadius", this.blurRadius);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HJPNPFOCKNH, this.showGeneratedNormals ? 1 : 0);
				return;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
		}

		// Token: 0x0600B2AB RID: 45739 RVA: 0x004DDB4C File Offset: 0x004DBD4C
		public void IBIBOJIPANH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.LPNAOMKDNPM != null)
			{
				this.LPNAOMKDNPM.SetFloat("eat2.ogg", this.edgeThresholdMin);
				this.LPNAOMKDNPM.SetFloat("IdleSpew", this.edgeThreshold);
				this.LPNAOMKDNPM.SetFloat("Please assign all Bones to the IK solver.", this.edgeSharpness);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LPNAOMKDNPM);
				return;
			}
			if (this.mode == GIHPHDGBIIG.SSAA && this.KJJLPJBLECA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KJJLPJBLECA);
				return;
			}
			if (this.mode == (GIHPHDGBIIG)7 && this.EPAFEOKHFAC != null)
			{
				JONJODLFAEN.anisoLevel = 5;
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EPAFEOKHFAC);
				JONJODLFAEN.anisoLevel = 0;
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.PIANCPDFNFA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PIANCPDFNFA);
				return;
			}
			if (this.mode == (GIHPHDGBIIG)8 && this.KGHMBEHHMHG != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KGHMBEHHMHG);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA1PresetA && this.ILKIBIDOMBK != null)
			{
				JONJODLFAEN.anisoLevel = 1;
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
				Graphics.Blit(JONJODLFAEN, temporary, this.ILKIBIDOMBK, 1);
				Graphics.Blit(temporary, OKIIDHIJBEA, this.ILKIBIDOMBK, this.dlaaSharp ? 2 : 0);
				RenderTexture.ReleaseTemporary(temporary);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA1PresetA && this.HJPNPFOCKNH != null)
			{
				JONJODLFAEN.anisoLevel = 1;
				this.HJPNPFOCKNH.SetFloat("VRIK needs a Humanoid Animator to auto-detect biped references. Please assign references manually.", this.offsetScale);
				this.HJPNPFOCKNH.SetFloat("16", this.blurRadius);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HJPNPFOCKNH, this.showGeneratedNormals ? 0 : 1);
				return;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
		}

		// Token: 0x0600B2AC RID: 45740 RVA: 0x004DDD3C File Offset: 0x004DBF3C
		public virtual bool JOGGNPOMFKJ()
		{
			base.IDFIHFBEIKD(false);
			this.EPAFEOKHFAC = base.IBKIBFDHBKA(this.shaderFXAAPreset2, this.EPAFEOKHFAC);
			this.KJJLPJBLECA = base.DLDCFEJJBBI(this.shaderFXAAPreset3, this.KJJLPJBLECA);
			this.PIANCPDFNFA = base.IBKIBFDHBKA(this.shaderFXAAII, this.PIANCPDFNFA);
			this.LPNAOMKDNPM = base.DLDCFEJJBBI(this.shaderFXAAIII, this.LPNAOMKDNPM);
			this.HJPNPFOCKNH = base.FJMGOIOPENE(this.nfaaShader, this.HJPNPFOCKNH);
			this.KGHMBEHHMHG = base.JAODCGBEAIF(this.ssaaShader, this.KGHMBEHHMHG);
			this.ILKIBIDOMBK = base.PAGPIKMKGLP(this.dlaaShader, this.ILKIBIDOMBK);
			if (!this.ssaaShader.isSupported)
			{
				base.OCGNIJDNOOM();
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B2AD RID: 45741 RVA: 0x004DDE18 File Offset: 0x004DC018
		public void DHJHEGHEGOH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA3Console && this.LPNAOMKDNPM != null)
			{
				this.LPNAOMKDNPM.SetFloat("%", this.edgeThresholdMin);
				this.LPNAOMKDNPM.SetFloat("*** Perks is init", this.edgeThreshold);
				this.LPNAOMKDNPM.SetFloat("WallSit", this.edgeSharpness);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LPNAOMKDNPM);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.KJJLPJBLECA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KJJLPJBLECA);
				return;
			}
			if (this.mode == (GIHPHDGBIIG)7 && this.EPAFEOKHFAC != null)
			{
				JONJODLFAEN.anisoLevel = 5;
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EPAFEOKHFAC);
				JONJODLFAEN.anisoLevel = 1;
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.PIANCPDFNFA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PIANCPDFNFA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA1PresetB && this.KGHMBEHHMHG != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KGHMBEHHMHG);
				return;
			}
			if (this.mode == (GIHPHDGBIIG)8 && this.ILKIBIDOMBK != null)
			{
				JONJODLFAEN.anisoLevel = 1;
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
				Graphics.Blit(JONJODLFAEN, temporary, this.ILKIBIDOMBK, 0);
				Graphics.Blit(temporary, OKIIDHIJBEA, this.ILKIBIDOMBK, this.dlaaSharp ? 2 : 1);
				RenderTexture.ReleaseTemporary(temporary);
				return;
			}
			if (this.mode == (GIHPHDGBIIG)7 && this.HJPNPFOCKNH != null)
			{
				JONJODLFAEN.anisoLevel = 0;
				this.HJPNPFOCKNH.SetFloat("knopje.wav", this.offsetScale);
				this.HJPNPFOCKNH.SetFloat("Bases/{0}/", this.blurRadius);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HJPNPFOCKNH, this.showGeneratedNormals ? 1 : 0);
				return;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
		}

		// Token: 0x0600B2AE RID: 45742 RVA: 0x004DE008 File Offset: 0x004DC208
		public void HKIFJANIGPK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.LPNAOMKDNPM != null)
			{
				this.LPNAOMKDNPM.SetFloat("_MaxRadiusOrKInPaper", this.edgeThresholdMin);
				this.LPNAOMKDNPM.SetFloat("wpn_chair3", this.edgeThreshold);
				this.LPNAOMKDNPM.SetFloat("Apply 10", this.edgeSharpness);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LPNAOMKDNPM);
				return;
			}
			if (this.mode == (GIHPHDGBIIG)8 && this.KJJLPJBLECA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KJJLPJBLECA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.DLAA && this.EPAFEOKHFAC != null)
			{
				JONJODLFAEN.anisoLevel = 8;
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EPAFEOKHFAC);
				JONJODLFAEN.anisoLevel = 1;
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.PIANCPDFNFA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PIANCPDFNFA);
				return;
			}
			if (this.mode == (GIHPHDGBIIG)7 && this.KGHMBEHHMHG != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KGHMBEHHMHG);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.ILKIBIDOMBK != null)
			{
				JONJODLFAEN.anisoLevel = 0;
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
				Graphics.Blit(JONJODLFAEN, temporary, this.ILKIBIDOMBK, 0);
				Graphics.Blit(temporary, OKIIDHIJBEA, this.ILKIBIDOMBK, this.dlaaSharp ? 5 : 1);
				RenderTexture.ReleaseTemporary(temporary);
				return;
			}
			if (this.mode == (GIHPHDGBIIG)7 && this.HJPNPFOCKNH != null)
			{
				JONJODLFAEN.anisoLevel = 0;
				this.HJPNPFOCKNH.SetFloat("OfficeSittingReading", this.offsetScale);
				this.HJPNPFOCKNH.SetFloat("from friend", this.blurRadius);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HJPNPFOCKNH, this.showGeneratedNormals ? 0 : 0);
				return;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
		}

		// Token: 0x0600B2AF RID: 45743 RVA: 0x004DE1F8 File Offset: 0x004DC3F8
		public void DNPIJGHMNGK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.LPNAOMKDNPM != null)
			{
				this.LPNAOMKDNPM.SetFloat("OfficeSittingLegCross", this.edgeThresholdMin);
				this.LPNAOMKDNPM.SetFloat("Error key=", this.edgeThreshold);
				this.LPNAOMKDNPM.SetFloat("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_rotation_limit_angle.html", this.edgeSharpness);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LPNAOMKDNPM);
				return;
			}
			if (this.mode == GIHPHDGBIIG.NFAA && this.KJJLPJBLECA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KJJLPJBLECA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA3Console && this.EPAFEOKHFAC != null)
			{
				JONJODLFAEN.anisoLevel = 5;
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EPAFEOKHFAC);
				JONJODLFAEN.anisoLevel = 1;
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.PIANCPDFNFA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PIANCPDFNFA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.DLAA && this.KGHMBEHHMHG != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KGHMBEHHMHG);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA3Console && this.ILKIBIDOMBK != null)
			{
				JONJODLFAEN.anisoLevel = 1;
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
				Graphics.Blit(JONJODLFAEN, temporary, this.ILKIBIDOMBK, 0);
				Graphics.Blit(temporary, OKIIDHIJBEA, this.ILKIBIDOMBK, this.dlaaSharp ? 1 : 1);
				RenderTexture.ReleaseTemporary(temporary);
				return;
			}
			if (this.mode == GIHPHDGBIIG.NFAA && this.HJPNPFOCKNH != null)
			{
				JONJODLFAEN.anisoLevel = 0;
				this.HJPNPFOCKNH.SetFloat("invn_rec2", this.offsetScale);
				this.HJPNPFOCKNH.SetFloat("Original string:\n", this.blurRadius);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HJPNPFOCKNH, this.showGeneratedNormals ? 1 : 1);
				return;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
		}

		// Token: 0x0600B2B0 RID: 45744 RVA: 0x004DE3E8 File Offset: 0x004DC5E8
		public void EIBBJMGHBLC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.LPNAOMKDNPM != null)
			{
				this.LPNAOMKDNPM.SetFloat("_camHue", this.edgeThresholdMin);
				this.LPNAOMKDNPM.SetFloat(" %\n", this.edgeThreshold);
				this.LPNAOMKDNPM.SetFloat("_INFO", this.edgeSharpness);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LPNAOMKDNPM);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA1PresetB && this.KJJLPJBLECA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KJJLPJBLECA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.DLAA && this.EPAFEOKHFAC != null)
			{
				JONJODLFAEN.anisoLevel = 1;
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EPAFEOKHFAC);
				JONJODLFAEN.anisoLevel = 1;
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.PIANCPDFNFA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PIANCPDFNFA);
				return;
			}
			if (this.mode == (GIHPHDGBIIG)7 && this.KGHMBEHHMHG != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KGHMBEHHMHG);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.ILKIBIDOMBK != null)
			{
				JONJODLFAEN.anisoLevel = 0;
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
				Graphics.Blit(JONJODLFAEN, temporary, this.ILKIBIDOMBK, 0);
				Graphics.Blit(temporary, OKIIDHIJBEA, this.ILKIBIDOMBK, this.dlaaSharp ? 0 : 1);
				RenderTexture.ReleaseTemporary(temporary);
				return;
			}
			if (this.mode == (GIHPHDGBIIG)7 && this.HJPNPFOCKNH != null)
			{
				JONJODLFAEN.anisoLevel = 1;
				this.HJPNPFOCKNH.SetFloat("selpersbtn", this.offsetScale);
				this.HJPNPFOCKNH.SetFloat("SoccerPassHeavy", this.blurRadius);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HJPNPFOCKNH, this.showGeneratedNormals ? 1 : 0);
				return;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
		}

		// Token: 0x0600B2B1 RID: 45745 RVA: 0x004DE5D8 File Offset: 0x004DC7D8
		public virtual bool JOAPNOCFFBG()
		{
			base.EHGENDOEHLP(true);
			this.EPAFEOKHFAC = base.FJMGOIOPENE(this.shaderFXAAPreset2, this.EPAFEOKHFAC);
			this.KJJLPJBLECA = base.FJMGOIOPENE(this.shaderFXAAPreset3, this.KJJLPJBLECA);
			this.PIANCPDFNFA = base.FJMGOIOPENE(this.shaderFXAAII, this.PIANCPDFNFA);
			this.LPNAOMKDNPM = base.PAGPIKMKGLP(this.shaderFXAAIII, this.LPNAOMKDNPM);
			this.HJPNPFOCKNH = base.JAODCGBEAIF(this.nfaaShader, this.HJPNPFOCKNH);
			this.KGHMBEHHMHG = base.IBKIBFDHBKA(this.ssaaShader, this.KGHMBEHHMHG);
			this.ILKIBIDOMBK = base.LBFLGMNPKHN(this.dlaaShader, this.ILKIBIDOMBK);
			if (!this.ssaaShader.isSupported)
			{
				base.OBHMLOABCAN();
				base.NAIBIABADFB();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B2B2 RID: 45746 RVA: 0x004DE6B4 File Offset: 0x004DC8B4
		public Material LOJPCKBHDCO()
		{
			Material result;
			switch (this.mode)
			{
			case GIHPHDGBIIG.FXAA2:
				result = this.PIANCPDFNFA;
				break;
			case GIHPHDGBIIG.FXAA3Console:
				result = this.LPNAOMKDNPM;
				break;
			case GIHPHDGBIIG.FXAA1PresetA:
				result = this.EPAFEOKHFAC;
				break;
			case GIHPHDGBIIG.FXAA1PresetB:
				result = this.KJJLPJBLECA;
				break;
			case GIHPHDGBIIG.NFAA:
				result = this.HJPNPFOCKNH;
				break;
			case GIHPHDGBIIG.SSAA:
				result = this.KGHMBEHHMHG;
				break;
			case GIHPHDGBIIG.DLAA:
				result = this.ILKIBIDOMBK;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x0600B2B3 RID: 45747 RVA: 0x004DE730 File Offset: 0x004DC930
		public virtual bool IIKPOFNDHFM()
		{
			base.POJDHPJDFEM(true);
			this.EPAFEOKHFAC = base.DLDCFEJJBBI(this.shaderFXAAPreset2, this.EPAFEOKHFAC);
			this.KJJLPJBLECA = base.FJMGOIOPENE(this.shaderFXAAPreset3, this.KJJLPJBLECA);
			this.PIANCPDFNFA = base.LBFLGMNPKHN(this.shaderFXAAII, this.PIANCPDFNFA);
			this.LPNAOMKDNPM = base.FJMGOIOPENE(this.shaderFXAAIII, this.LPNAOMKDNPM);
			this.HJPNPFOCKNH = base.LBFLGMNPKHN(this.nfaaShader, this.HJPNPFOCKNH);
			this.KGHMBEHHMHG = base.JAODCGBEAIF(this.ssaaShader, this.KGHMBEHHMHG);
			this.ILKIBIDOMBK = base.PAGPIKMKGLP(this.dlaaShader, this.ILKIBIDOMBK);
			if (!this.ssaaShader.isSupported)
			{
				base.OCGNIJDNOOM();
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B2B4 RID: 45748 RVA: 0x004DE80C File Offset: 0x004DCA0C
		public virtual bool POCBDMNELOB()
		{
			base.EHGENDOEHLP(true);
			this.EPAFEOKHFAC = base.FJMGOIOPENE(this.shaderFXAAPreset2, this.EPAFEOKHFAC);
			this.KJJLPJBLECA = base.FJMGOIOPENE(this.shaderFXAAPreset3, this.KJJLPJBLECA);
			this.PIANCPDFNFA = base.LBFLGMNPKHN(this.shaderFXAAII, this.PIANCPDFNFA);
			this.LPNAOMKDNPM = base.PHNMLJJBKDC(this.shaderFXAAIII, this.LPNAOMKDNPM);
			this.HJPNPFOCKNH = base.JAODCGBEAIF(this.nfaaShader, this.HJPNPFOCKNH);
			this.KGHMBEHHMHG = base.PHNMLJJBKDC(this.ssaaShader, this.KGHMBEHHMHG);
			this.ILKIBIDOMBK = base.LBFLGMNPKHN(this.dlaaShader, this.ILKIBIDOMBK);
			if (!this.ssaaShader.isSupported)
			{
				base.FEFCOCIEFAK();
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B2B5 RID: 45749 RVA: 0x004DE8E8 File Offset: 0x004DCAE8
		public virtual bool NGKAKAAKDJH()
		{
			base.EBEBJHLBBBI(false);
			this.EPAFEOKHFAC = base.DLDCFEJJBBI(this.shaderFXAAPreset2, this.EPAFEOKHFAC);
			this.KJJLPJBLECA = base.IBKIBFDHBKA(this.shaderFXAAPreset3, this.KJJLPJBLECA);
			this.PIANCPDFNFA = base.LBFLGMNPKHN(this.shaderFXAAII, this.PIANCPDFNFA);
			this.LPNAOMKDNPM = base.IBKIBFDHBKA(this.shaderFXAAIII, this.LPNAOMKDNPM);
			this.HJPNPFOCKNH = base.DLDCFEJJBBI(this.nfaaShader, this.HJPNPFOCKNH);
			this.KGHMBEHHMHG = base.PAGPIKMKGLP(this.ssaaShader, this.KGHMBEHHMHG);
			this.ILKIBIDOMBK = base.PHNMLJJBKDC(this.dlaaShader, this.ILKIBIDOMBK);
			if (!this.ssaaShader.isSupported)
			{
				base.OBHMLOABCAN();
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B2B6 RID: 45750 RVA: 0x004DE9C4 File Offset: 0x004DCBC4
		public Material MBOGEGCHMCH()
		{
			Material result;
			switch (this.mode)
			{
			case GIHPHDGBIIG.FXAA2:
				result = this.PIANCPDFNFA;
				break;
			case GIHPHDGBIIG.FXAA3Console:
				result = this.LPNAOMKDNPM;
				break;
			case GIHPHDGBIIG.FXAA1PresetA:
				result = this.EPAFEOKHFAC;
				break;
			case GIHPHDGBIIG.FXAA1PresetB:
				result = this.KJJLPJBLECA;
				break;
			case GIHPHDGBIIG.NFAA:
				result = this.HJPNPFOCKNH;
				break;
			case GIHPHDGBIIG.SSAA:
				result = this.KGHMBEHHMHG;
				break;
			case GIHPHDGBIIG.DLAA:
				result = this.ILKIBIDOMBK;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x0600B2B7 RID: 45751 RVA: 0x004DEA40 File Offset: 0x004DCC40
		public virtual bool BCBDFDEEILK()
		{
			base.EHGENDOEHLP(true);
			this.EPAFEOKHFAC = base.FJMGOIOPENE(this.shaderFXAAPreset2, this.EPAFEOKHFAC);
			this.KJJLPJBLECA = base.PHNMLJJBKDC(this.shaderFXAAPreset3, this.KJJLPJBLECA);
			this.PIANCPDFNFA = base.LBFLGMNPKHN(this.shaderFXAAII, this.PIANCPDFNFA);
			this.LPNAOMKDNPM = base.FJMGOIOPENE(this.shaderFXAAIII, this.LPNAOMKDNPM);
			this.HJPNPFOCKNH = base.PAGPIKMKGLP(this.nfaaShader, this.HJPNPFOCKNH);
			this.KGHMBEHHMHG = base.FJMGOIOPENE(this.ssaaShader, this.KGHMBEHHMHG);
			this.ILKIBIDOMBK = base.IBKIBFDHBKA(this.dlaaShader, this.ILKIBIDOMBK);
			if (!this.ssaaShader.isSupported)
			{
				base.OBHMLOABCAN();
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B2B8 RID: 45752 RVA: 0x004DEB1C File Offset: 0x004DCD1C
		public virtual bool APNCPMNHKOG()
		{
			base.LGANGHEOPOG(false);
			this.EPAFEOKHFAC = base.IBKIBFDHBKA(this.shaderFXAAPreset2, this.EPAFEOKHFAC);
			this.KJJLPJBLECA = base.LBFLGMNPKHN(this.shaderFXAAPreset3, this.KJJLPJBLECA);
			this.PIANCPDFNFA = base.LBFLGMNPKHN(this.shaderFXAAII, this.PIANCPDFNFA);
			this.LPNAOMKDNPM = base.LBFLGMNPKHN(this.shaderFXAAIII, this.LPNAOMKDNPM);
			this.HJPNPFOCKNH = base.FJMGOIOPENE(this.nfaaShader, this.HJPNPFOCKNH);
			this.KGHMBEHHMHG = base.PAGPIKMKGLP(this.ssaaShader, this.KGHMBEHHMHG);
			this.ILKIBIDOMBK = base.FJMGOIOPENE(this.dlaaShader, this.ILKIBIDOMBK);
			if (!this.ssaaShader.isSupported)
			{
				base.AGGGAHEKKCO();
				base.NAIBIABADFB();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B2B9 RID: 45753 RVA: 0x004DEBF8 File Offset: 0x004DCDF8
		public virtual bool CFHOHAOFPIO()
		{
			base.CGEGCOKMPHN(true);
			this.EPAFEOKHFAC = base.PHNMLJJBKDC(this.shaderFXAAPreset2, this.EPAFEOKHFAC);
			this.KJJLPJBLECA = base.IBKIBFDHBKA(this.shaderFXAAPreset3, this.KJJLPJBLECA);
			this.PIANCPDFNFA = base.LBFLGMNPKHN(this.shaderFXAAII, this.PIANCPDFNFA);
			this.LPNAOMKDNPM = base.IBKIBFDHBKA(this.shaderFXAAIII, this.LPNAOMKDNPM);
			this.HJPNPFOCKNH = base.DLDCFEJJBBI(this.nfaaShader, this.HJPNPFOCKNH);
			this.KGHMBEHHMHG = base.PAGPIKMKGLP(this.ssaaShader, this.KGHMBEHHMHG);
			this.ILKIBIDOMBK = base.JAODCGBEAIF(this.dlaaShader, this.ILKIBIDOMBK);
			if (!this.ssaaShader.isSupported)
			{
				base.AGGGAHEKKCO();
				base.NAIBIABADFB();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B2BA RID: 45754 RVA: 0x004DECD4 File Offset: 0x004DCED4
		public void PJOKECOHKGN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.IGJKBOMMMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA3Console && this.LPNAOMKDNPM != null)
			{
				this.LPNAOMKDNPM.SetFloat("repair.ogg", this.edgeThresholdMin);
				this.LPNAOMKDNPM.SetFloat("KatanaReadyLow", this.edgeThreshold);
				this.LPNAOMKDNPM.SetFloat("act_orderb_2", this.edgeSharpness);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LPNAOMKDNPM);
				return;
			}
			if (this.mode == (GIHPHDGBIIG)7 && this.KJJLPJBLECA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KJJLPJBLECA);
				return;
			}
			if (this.mode == (GIHPHDGBIIG)7 && this.EPAFEOKHFAC != null)
			{
				JONJODLFAEN.anisoLevel = 8;
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EPAFEOKHFAC);
				JONJODLFAEN.anisoLevel = 0;
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.PIANCPDFNFA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PIANCPDFNFA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA1PresetA && this.KGHMBEHHMHG != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KGHMBEHHMHG);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA3Console && this.ILKIBIDOMBK != null)
			{
				JONJODLFAEN.anisoLevel = 1;
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
				Graphics.Blit(JONJODLFAEN, temporary, this.ILKIBIDOMBK, 0);
				Graphics.Blit(temporary, OKIIDHIJBEA, this.ILKIBIDOMBK, this.dlaaSharp ? 1 : 1);
				RenderTexture.ReleaseTemporary(temporary);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA1PresetB && this.HJPNPFOCKNH != null)
			{
				JONJODLFAEN.anisoLevel = 1;
				this.HJPNPFOCKNH.SetFloat(" ", this.offsetScale);
				this.HJPNPFOCKNH.SetFloat("gamma", this.blurRadius);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HJPNPFOCKNH, this.showGeneratedNormals ? 1 : 0);
				return;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
		}

		// Token: 0x0600B2BB RID: 45755 RVA: 0x004DEEC4 File Offset: 0x004DD0C4
		public Material MKCDJCNKNML()
		{
			Material result;
			switch (this.mode)
			{
			case GIHPHDGBIIG.FXAA2:
				result = this.PIANCPDFNFA;
				break;
			case GIHPHDGBIIG.FXAA3Console:
				result = this.LPNAOMKDNPM;
				break;
			case GIHPHDGBIIG.FXAA1PresetA:
				result = this.EPAFEOKHFAC;
				break;
			case GIHPHDGBIIG.FXAA1PresetB:
				result = this.KJJLPJBLECA;
				break;
			case GIHPHDGBIIG.NFAA:
				result = this.HJPNPFOCKNH;
				break;
			case GIHPHDGBIIG.SSAA:
				result = this.KGHMBEHHMHG;
				break;
			case GIHPHDGBIIG.DLAA:
				result = this.ILKIBIDOMBK;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x0600B2BC RID: 45756 RVA: 0x004DEF40 File Offset: 0x004DD140
		public virtual bool CHJBCBDIBJJ()
		{
			base.BGIALJEIEFO(false);
			this.EPAFEOKHFAC = base.JAODCGBEAIF(this.shaderFXAAPreset2, this.EPAFEOKHFAC);
			this.KJJLPJBLECA = base.PHNMLJJBKDC(this.shaderFXAAPreset3, this.KJJLPJBLECA);
			this.PIANCPDFNFA = base.PHNMLJJBKDC(this.shaderFXAAII, this.PIANCPDFNFA);
			this.LPNAOMKDNPM = base.LBFLGMNPKHN(this.shaderFXAAIII, this.LPNAOMKDNPM);
			this.HJPNPFOCKNH = base.IBKIBFDHBKA(this.nfaaShader, this.HJPNPFOCKNH);
			this.KGHMBEHHMHG = base.PHNMLJJBKDC(this.ssaaShader, this.KGHMBEHHMHG);
			this.ILKIBIDOMBK = base.DLDCFEJJBBI(this.dlaaShader, this.ILKIBIDOMBK);
			if (!this.ssaaShader.isSupported)
			{
				base.AGGGAHEKKCO();
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B2BD RID: 45757 RVA: 0x004DF01C File Offset: 0x004DD21C
		public void ALNHCIOIBPP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA3Console && this.LPNAOMKDNPM != null)
			{
				this.LPNAOMKDNPM.SetFloat("F ", this.edgeThresholdMin);
				this.LPNAOMKDNPM.SetFloat("t_much", this.edgeThreshold);
				this.LPNAOMKDNPM.SetFloat("[fish]", this.edgeSharpness);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LPNAOMKDNPM);
				return;
			}
			if (this.mode == GIHPHDGBIIG.NFAA && this.KJJLPJBLECA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KJJLPJBLECA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.EPAFEOKHFAC != null)
			{
				JONJODLFAEN.anisoLevel = 1;
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EPAFEOKHFAC);
				JONJODLFAEN.anisoLevel = 0;
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.PIANCPDFNFA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PIANCPDFNFA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.KGHMBEHHMHG != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KGHMBEHHMHG);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA3Console && this.ILKIBIDOMBK != null)
			{
				JONJODLFAEN.anisoLevel = 0;
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
				Graphics.Blit(JONJODLFAEN, temporary, this.ILKIBIDOMBK, 1);
				Graphics.Blit(temporary, OKIIDHIJBEA, this.ILKIBIDOMBK, this.dlaaSharp ? 7 : 0);
				RenderTexture.ReleaseTemporary(temporary);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.HJPNPFOCKNH != null)
			{
				JONJODLFAEN.anisoLevel = 1;
				this.HJPNPFOCKNH.SetFloat("", this.offsetScale);
				this.HJPNPFOCKNH.SetFloat("WpnTemplateMgr is init", this.blurRadius);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HJPNPFOCKNH, this.showGeneratedNormals ? 1 : 0);
				return;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
		}

		// Token: 0x0600B2BE RID: 45758 RVA: 0x004DF20C File Offset: 0x004DD40C
		public virtual bool DCEJLCLOCJC()
		{
			base.PKDIKFGAJKM(true);
			this.EPAFEOKHFAC = base.IBKIBFDHBKA(this.shaderFXAAPreset2, this.EPAFEOKHFAC);
			this.KJJLPJBLECA = base.IBKIBFDHBKA(this.shaderFXAAPreset3, this.KJJLPJBLECA);
			this.PIANCPDFNFA = base.FJMGOIOPENE(this.shaderFXAAII, this.PIANCPDFNFA);
			this.LPNAOMKDNPM = base.FJMGOIOPENE(this.shaderFXAAIII, this.LPNAOMKDNPM);
			this.HJPNPFOCKNH = base.PAGPIKMKGLP(this.nfaaShader, this.HJPNPFOCKNH);
			this.KGHMBEHHMHG = base.JAODCGBEAIF(this.ssaaShader, this.KGHMBEHHMHG);
			this.ILKIBIDOMBK = base.LBFLGMNPKHN(this.dlaaShader, this.ILKIBIDOMBK);
			if (!this.ssaaShader.isSupported)
			{
				base.FEFCOCIEFAK();
				base.FDBKFKGCGEG();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B2BF RID: 45759 RVA: 0x004DF2E8 File Offset: 0x004DD4E8
		public Material PGGOCLFAICH()
		{
			Material result;
			switch (this.mode)
			{
			case GIHPHDGBIIG.FXAA2:
				result = this.PIANCPDFNFA;
				break;
			case GIHPHDGBIIG.FXAA3Console:
				result = this.LPNAOMKDNPM;
				break;
			case GIHPHDGBIIG.FXAA1PresetA:
				result = this.EPAFEOKHFAC;
				break;
			case GIHPHDGBIIG.FXAA1PresetB:
				result = this.KJJLPJBLECA;
				break;
			case GIHPHDGBIIG.NFAA:
				result = this.HJPNPFOCKNH;
				break;
			case GIHPHDGBIIG.SSAA:
				result = this.KGHMBEHHMHG;
				break;
			case GIHPHDGBIIG.DLAA:
				result = this.ILKIBIDOMBK;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x0600B2C0 RID: 45760 RVA: 0x004DF364 File Offset: 0x004DD564
		public void NPAOBLFOMGI(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.DLENDGGGMBJ())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA3Console && this.LPNAOMKDNPM != null)
			{
				this.LPNAOMKDNPM.SetFloat("holes_max", this.edgeThresholdMin);
				this.LPNAOMKDNPM.SetFloat("Select", this.edgeThreshold);
				this.LPNAOMKDNPM.SetFloat("error.wav", this.edgeSharpness);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LPNAOMKDNPM);
				return;
			}
			if (this.mode == (GIHPHDGBIIG)8 && this.KJJLPJBLECA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KJJLPJBLECA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.SSAA && this.EPAFEOKHFAC != null)
			{
				JONJODLFAEN.anisoLevel = 4;
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EPAFEOKHFAC);
				JONJODLFAEN.anisoLevel = 0;
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.PIANCPDFNFA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PIANCPDFNFA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.KGHMBEHHMHG != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KGHMBEHHMHG);
				return;
			}
			if (this.mode == (GIHPHDGBIIG)8 && this.ILKIBIDOMBK != null)
			{
				JONJODLFAEN.anisoLevel = 1;
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
				Graphics.Blit(JONJODLFAEN, temporary, this.ILKIBIDOMBK, 0);
				Graphics.Blit(temporary, OKIIDHIJBEA, this.ILKIBIDOMBK, this.dlaaSharp ? 1 : 0);
				RenderTexture.ReleaseTemporary(temporary);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA1PresetB && this.HJPNPFOCKNH != null)
			{
				JONJODLFAEN.anisoLevel = 0;
				this.HJPNPFOCKNH.SetFloat("Загрузка: ", this.offsetScale);
				this.HJPNPFOCKNH.SetFloat("Tenkoku DynamicSky", this.blurRadius);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HJPNPFOCKNH, this.showGeneratedNormals ? 0 : 0);
				return;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
		}

		// Token: 0x0600B2C1 RID: 45761 RVA: 0x004DF554 File Offset: 0x004DD754
		public virtual bool JCCFBJBBHBP()
		{
			base.BGIALJEIEFO(false);
			this.EPAFEOKHFAC = base.FJMGOIOPENE(this.shaderFXAAPreset2, this.EPAFEOKHFAC);
			this.KJJLPJBLECA = base.JAODCGBEAIF(this.shaderFXAAPreset3, this.KJJLPJBLECA);
			this.PIANCPDFNFA = base.DLDCFEJJBBI(this.shaderFXAAII, this.PIANCPDFNFA);
			this.LPNAOMKDNPM = base.PHNMLJJBKDC(this.shaderFXAAIII, this.LPNAOMKDNPM);
			this.HJPNPFOCKNH = base.FJMGOIOPENE(this.nfaaShader, this.HJPNPFOCKNH);
			this.KGHMBEHHMHG = base.LBFLGMNPKHN(this.ssaaShader, this.KGHMBEHHMHG);
			this.ILKIBIDOMBK = base.DLDCFEJJBBI(this.dlaaShader, this.ILKIBIDOMBK);
			if (!this.ssaaShader.isSupported)
			{
				base.OCGNIJDNOOM();
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B2C2 RID: 45762 RVA: 0x004DF630 File Offset: 0x004DD830
		public void IAPMIJOBNKG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.IGJKBOMMMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA3Console && this.LPNAOMKDNPM != null)
			{
				this.LPNAOMKDNPM.SetFloat("H:mm:ss", this.edgeThresholdMin);
				this.LPNAOMKDNPM.SetFloat("", this.edgeThreshold);
				this.LPNAOMKDNPM.SetFloat("Projector reference not set.", this.edgeSharpness);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LPNAOMKDNPM);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA1PresetA && this.KJJLPJBLECA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KJJLPJBLECA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.NFAA && this.EPAFEOKHFAC != null)
			{
				JONJODLFAEN.anisoLevel = 5;
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EPAFEOKHFAC);
				JONJODLFAEN.anisoLevel = 1;
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.PIANCPDFNFA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PIANCPDFNFA);
				return;
			}
			if (this.mode == (GIHPHDGBIIG)7 && this.KGHMBEHHMHG != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KGHMBEHHMHG);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA1PresetB && this.ILKIBIDOMBK != null)
			{
				JONJODLFAEN.anisoLevel = 1;
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
				Graphics.Blit(JONJODLFAEN, temporary, this.ILKIBIDOMBK, 1);
				Graphics.Blit(temporary, OKIIDHIJBEA, this.ILKIBIDOMBK, this.dlaaSharp ? 3 : 1);
				RenderTexture.ReleaseTemporary(temporary);
				return;
			}
			if (this.mode == (GIHPHDGBIIG)8 && this.HJPNPFOCKNH != null)
			{
				JONJODLFAEN.anisoLevel = 0;
				this.HJPNPFOCKNH.SetFloat("OfficeSittingReadingLeanBack", this.offsetScale);
				this.HJPNPFOCKNH.SetFloat("gi_um_9", this.blurRadius);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HJPNPFOCKNH, this.showGeneratedNormals ? 1 : 0);
				return;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
		}

		// Token: 0x0600B2C3 RID: 45763 RVA: 0x004DF820 File Offset: 0x004DDA20
		public void JNGODMMNPEG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.LPNAOMKDNPM != null)
			{
				this.LPNAOMKDNPM.SetFloat("^(", this.edgeThresholdMin);
				this.LPNAOMKDNPM.SetFloat("MotorbikeLassoFwd", this.edgeThreshold);
				this.LPNAOMKDNPM.SetFloat("http://www.root-motion.com/finalikdox/html/page5.html", this.edgeSharpness);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LPNAOMKDNPM);
				return;
			}
			if (this.mode == (GIHPHDGBIIG)7 && this.KJJLPJBLECA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KJJLPJBLECA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA1PresetB && this.EPAFEOKHFAC != null)
			{
				JONJODLFAEN.anisoLevel = 5;
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EPAFEOKHFAC);
				JONJODLFAEN.anisoLevel = 0;
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.PIANCPDFNFA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PIANCPDFNFA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA1PresetA && this.KGHMBEHHMHG != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KGHMBEHHMHG);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA3Console && this.ILKIBIDOMBK != null)
			{
				JONJODLFAEN.anisoLevel = 0;
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
				Graphics.Blit(JONJODLFAEN, temporary, this.ILKIBIDOMBK, 0);
				Graphics.Blit(temporary, OKIIDHIJBEA, this.ILKIBIDOMBK, this.dlaaSharp ? 4 : 0);
				RenderTexture.ReleaseTemporary(temporary);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.HJPNPFOCKNH != null)
			{
				JONJODLFAEN.anisoLevel = 1;
				this.HJPNPFOCKNH.SetFloat("rod_inf1", this.offsetScale);
				this.HJPNPFOCKNH.SetFloat(", Origin} has negative volume. Make sure Axis vector is in the reachable area and the polygon is convex.", this.blurRadius);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HJPNPFOCKNH, this.showGeneratedNormals ? 1 : 1);
				return;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
		}

		// Token: 0x0600B2C4 RID: 45764 RVA: 0x004DFA10 File Offset: 0x004DDC10
		public void GNDNAAHKDIM(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA3Console && this.LPNAOMKDNPM != null)
			{
				this.LPNAOMKDNPM.SetFloat("Autoclear", this.edgeThresholdMin);
				this.LPNAOMKDNPM.SetFloat("Bot", this.edgeThreshold);
				this.LPNAOMKDNPM.SetFloat("wpn_hookf", this.edgeSharpness);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LPNAOMKDNPM);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA1PresetB && this.KJJLPJBLECA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KJJLPJBLECA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA3Console && this.EPAFEOKHFAC != null)
			{
				JONJODLFAEN.anisoLevel = 2;
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EPAFEOKHFAC);
				JONJODLFAEN.anisoLevel = 0;
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.PIANCPDFNFA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PIANCPDFNFA);
				return;
			}
			if (this.mode == (GIHPHDGBIIG)7 && this.KGHMBEHHMHG != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KGHMBEHHMHG);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA1PresetB && this.ILKIBIDOMBK != null)
			{
				JONJODLFAEN.anisoLevel = 1;
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
				Graphics.Blit(JONJODLFAEN, temporary, this.ILKIBIDOMBK, 0);
				Graphics.Blit(temporary, OKIIDHIJBEA, this.ILKIBIDOMBK, this.dlaaSharp ? 8 : 1);
				RenderTexture.ReleaseTemporary(temporary);
				return;
			}
			if (this.mode == (GIHPHDGBIIG)7 && this.HJPNPFOCKNH != null)
			{
				JONJODLFAEN.anisoLevel = 0;
				this.HJPNPFOCKNH.SetFloat("KatanaReady", this.offsetScale);
				this.HJPNPFOCKNH.SetFloat("---", this.blurRadius);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HJPNPFOCKNH, this.showGeneratedNormals ? 0 : 1);
				return;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
		}

		// Token: 0x0600B2C5 RID: 45765 RVA: 0x004DFC00 File Offset: 0x004DDE00
		public void EODDHFNAMFH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.GGJKGIHGMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.LPNAOMKDNPM != null)
			{
				this.LPNAOMKDNPM.SetFloat("GrounderIK does not support FullBodyBipedIK, use CCDIK, FABRIK, LimbIK or TrigonometricIK instead. If you want to use FullBodyBipedIK, use the GrounderFBBIK component.", this.edgeThresholdMin);
				this.LPNAOMKDNPM.SetFloat(" ", this.edgeThreshold);
				this.LPNAOMKDNPM.SetFloat("VALIGN", this.edgeSharpness);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LPNAOMKDNPM);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.KJJLPJBLECA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KJJLPJBLECA);
				return;
			}
			if (this.mode == (GIHPHDGBIIG)8 && this.EPAFEOKHFAC != null)
			{
				JONJODLFAEN.anisoLevel = 6;
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EPAFEOKHFAC);
				JONJODLFAEN.anisoLevel = 1;
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.PIANCPDFNFA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PIANCPDFNFA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.SSAA && this.KGHMBEHHMHG != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KGHMBEHHMHG);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA1PresetA && this.ILKIBIDOMBK != null)
			{
				JONJODLFAEN.anisoLevel = 1;
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
				Graphics.Blit(JONJODLFAEN, temporary, this.ILKIBIDOMBK, 1);
				Graphics.Blit(temporary, OKIIDHIJBEA, this.ILKIBIDOMBK, this.dlaaSharp ? 3 : 1);
				RenderTexture.ReleaseTemporary(temporary);
				return;
			}
			if (this.mode == GIHPHDGBIIG.NFAA && this.HJPNPFOCKNH != null)
			{
				JONJODLFAEN.anisoLevel = 1;
				this.HJPNPFOCKNH.SetFloat("/ n", this.offsetScale);
				this.HJPNPFOCKNH.SetFloat("", this.blurRadius);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HJPNPFOCKNH, this.showGeneratedNormals ? 1 : 0);
				return;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
		}

		// Token: 0x0600B2C6 RID: 45766 RVA: 0x004DFDF0 File Offset: 0x004DDFF0
		public virtual bool AGMCDGFGINF()
		{
			base.DAOKCAOFIGE(true);
			this.EPAFEOKHFAC = base.DLDCFEJJBBI(this.shaderFXAAPreset2, this.EPAFEOKHFAC);
			this.KJJLPJBLECA = base.IBKIBFDHBKA(this.shaderFXAAPreset3, this.KJJLPJBLECA);
			this.PIANCPDFNFA = base.JAODCGBEAIF(this.shaderFXAAII, this.PIANCPDFNFA);
			this.LPNAOMKDNPM = base.PAGPIKMKGLP(this.shaderFXAAIII, this.LPNAOMKDNPM);
			this.HJPNPFOCKNH = base.PHNMLJJBKDC(this.nfaaShader, this.HJPNPFOCKNH);
			this.KGHMBEHHMHG = base.JAODCGBEAIF(this.ssaaShader, this.KGHMBEHHMHG);
			this.ILKIBIDOMBK = base.LBFLGMNPKHN(this.dlaaShader, this.ILKIBIDOMBK);
			if (!this.ssaaShader.isSupported)
			{
				base.OCGNIJDNOOM();
				base.INOGPLDHPGC();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B2C7 RID: 45767 RVA: 0x004DFECC File Offset: 0x004DE0CC
		public virtual bool PPJAMONPAPC()
		{
			base.OLMOAHDIDNG(false);
			this.EPAFEOKHFAC = base.FJMGOIOPENE(this.shaderFXAAPreset2, this.EPAFEOKHFAC);
			this.KJJLPJBLECA = base.FJMGOIOPENE(this.shaderFXAAPreset3, this.KJJLPJBLECA);
			this.PIANCPDFNFA = base.DLDCFEJJBBI(this.shaderFXAAII, this.PIANCPDFNFA);
			this.LPNAOMKDNPM = base.LBFLGMNPKHN(this.shaderFXAAIII, this.LPNAOMKDNPM);
			this.HJPNPFOCKNH = base.FJMGOIOPENE(this.nfaaShader, this.HJPNPFOCKNH);
			this.KGHMBEHHMHG = base.LBFLGMNPKHN(this.ssaaShader, this.KGHMBEHHMHG);
			this.ILKIBIDOMBK = base.DLDCFEJJBBI(this.dlaaShader, this.ILKIBIDOMBK);
			if (!this.ssaaShader.isSupported)
			{
				base.FEFCOCIEFAK();
				base.NAIBIABADFB();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B2C8 RID: 45768 RVA: 0x004DFFA8 File Offset: 0x004DE1A8
		public Material KBEJJBCGLJG()
		{
			Material result;
			switch (this.mode)
			{
			case GIHPHDGBIIG.FXAA2:
				result = this.PIANCPDFNFA;
				break;
			case GIHPHDGBIIG.FXAA3Console:
				result = this.LPNAOMKDNPM;
				break;
			case GIHPHDGBIIG.FXAA1PresetA:
				result = this.EPAFEOKHFAC;
				break;
			case GIHPHDGBIIG.FXAA1PresetB:
				result = this.KJJLPJBLECA;
				break;
			case GIHPHDGBIIG.NFAA:
				result = this.HJPNPFOCKNH;
				break;
			case GIHPHDGBIIG.SSAA:
				result = this.KGHMBEHHMHG;
				break;
			case GIHPHDGBIIG.DLAA:
				result = this.ILKIBIDOMBK;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x0600B2C9 RID: 45769 RVA: 0x004E0024 File Offset: 0x004DE224
		public virtual bool KCGEMCLLBHM()
		{
			base.AHFDGALLKFC(true);
			this.EPAFEOKHFAC = base.IBKIBFDHBKA(this.shaderFXAAPreset2, this.EPAFEOKHFAC);
			this.KJJLPJBLECA = base.JAODCGBEAIF(this.shaderFXAAPreset3, this.KJJLPJBLECA);
			this.PIANCPDFNFA = base.DLDCFEJJBBI(this.shaderFXAAII, this.PIANCPDFNFA);
			this.LPNAOMKDNPM = base.FJMGOIOPENE(this.shaderFXAAIII, this.LPNAOMKDNPM);
			this.HJPNPFOCKNH = base.JAODCGBEAIF(this.nfaaShader, this.HJPNPFOCKNH);
			this.KGHMBEHHMHG = base.PHNMLJJBKDC(this.ssaaShader, this.KGHMBEHHMHG);
			this.ILKIBIDOMBK = base.PAGPIKMKGLP(this.dlaaShader, this.ILKIBIDOMBK);
			if (!this.ssaaShader.isSupported)
			{
				base.OBHMLOABCAN();
				base.FDBKFKGCGEG();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B2CA RID: 45770 RVA: 0x004E0100 File Offset: 0x004DE300
		public Material OAGKCCBNNOI()
		{
			Material result;
			switch (this.mode)
			{
			case GIHPHDGBIIG.FXAA2:
				result = this.PIANCPDFNFA;
				break;
			case GIHPHDGBIIG.FXAA3Console:
				result = this.LPNAOMKDNPM;
				break;
			case GIHPHDGBIIG.FXAA1PresetA:
				result = this.EPAFEOKHFAC;
				break;
			case GIHPHDGBIIG.FXAA1PresetB:
				result = this.KJJLPJBLECA;
				break;
			case GIHPHDGBIIG.NFAA:
				result = this.HJPNPFOCKNH;
				break;
			case GIHPHDGBIIG.SSAA:
				result = this.KGHMBEHHMHG;
				break;
			case GIHPHDGBIIG.DLAA:
				result = this.ILKIBIDOMBK;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x0600B2CB RID: 45771 RVA: 0x004E017C File Offset: 0x004DE37C
		public Material KANNFNDHNJP()
		{
			Material result;
			switch (this.mode)
			{
			case GIHPHDGBIIG.FXAA2:
				result = this.PIANCPDFNFA;
				break;
			case GIHPHDGBIIG.FXAA3Console:
				result = this.LPNAOMKDNPM;
				break;
			case GIHPHDGBIIG.FXAA1PresetA:
				result = this.EPAFEOKHFAC;
				break;
			case GIHPHDGBIIG.FXAA1PresetB:
				result = this.KJJLPJBLECA;
				break;
			case GIHPHDGBIIG.NFAA:
				result = this.HJPNPFOCKNH;
				break;
			case GIHPHDGBIIG.SSAA:
				result = this.KGHMBEHHMHG;
				break;
			case GIHPHDGBIIG.DLAA:
				result = this.ILKIBIDOMBK;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x0600B2CC RID: 45772 RVA: 0x004E01F8 File Offset: 0x004DE3F8
		public Material NIEFDGMAINF()
		{
			Material result;
			switch (this.mode)
			{
			case GIHPHDGBIIG.FXAA2:
				result = this.PIANCPDFNFA;
				break;
			case GIHPHDGBIIG.FXAA3Console:
				result = this.LPNAOMKDNPM;
				break;
			case GIHPHDGBIIG.FXAA1PresetA:
				result = this.EPAFEOKHFAC;
				break;
			case GIHPHDGBIIG.FXAA1PresetB:
				result = this.KJJLPJBLECA;
				break;
			case GIHPHDGBIIG.NFAA:
				result = this.HJPNPFOCKNH;
				break;
			case GIHPHDGBIIG.SSAA:
				result = this.KGHMBEHHMHG;
				break;
			case GIHPHDGBIIG.DLAA:
				result = this.ILKIBIDOMBK;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x0600B2CD RID: 45773 RVA: 0x004E0274 File Offset: 0x004DE474
		public void ENEONPFCPMP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.LPNAOMKDNPM != null)
			{
				this.LPNAOMKDNPM.SetFloat("newletter", this.edgeThresholdMin);
				this.LPNAOMKDNPM.SetFloat("Materials/DFGWithSky", this.edgeThreshold);
				this.LPNAOMKDNPM.SetFloat("Move around with WASD keys. Press C to enable free look camera", this.edgeSharpness);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LPNAOMKDNPM);
				return;
			}
			if (this.mode == GIHPHDGBIIG.SSAA && this.KJJLPJBLECA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KJJLPJBLECA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.NFAA && this.EPAFEOKHFAC != null)
			{
				JONJODLFAEN.anisoLevel = 0;
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EPAFEOKHFAC);
				JONJODLFAEN.anisoLevel = 0;
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.PIANCPDFNFA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PIANCPDFNFA);
				return;
			}
			if (this.mode == (GIHPHDGBIIG)7 && this.KGHMBEHHMHG != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KGHMBEHHMHG);
				return;
			}
			if (this.mode == GIHPHDGBIIG.NFAA && this.ILKIBIDOMBK != null)
			{
				JONJODLFAEN.anisoLevel = 1;
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
				Graphics.Blit(JONJODLFAEN, temporary, this.ILKIBIDOMBK, 0);
				Graphics.Blit(temporary, OKIIDHIJBEA, this.ILKIBIDOMBK, this.dlaaSharp ? 3 : 0);
				RenderTexture.ReleaseTemporary(temporary);
				return;
			}
			if (this.mode == (GIHPHDGBIIG)7 && this.HJPNPFOCKNH != null)
			{
				JONJODLFAEN.anisoLevel = 0;
				this.HJPNPFOCKNH.SetFloat("TOD_kBetaMie", this.offsetScale);
				this.HJPNPFOCKNH.SetFloat("btn_cancel", this.blurRadius);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HJPNPFOCKNH, this.showGeneratedNormals ? 0 : 1);
				return;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
		}

		// Token: 0x0600B2CE RID: 45774 RVA: 0x004E0464 File Offset: 0x004DE664
		public Material MOMBDLBAGKI()
		{
			Material result;
			switch (this.mode)
			{
			case GIHPHDGBIIG.FXAA2:
				result = this.PIANCPDFNFA;
				break;
			case GIHPHDGBIIG.FXAA3Console:
				result = this.LPNAOMKDNPM;
				break;
			case GIHPHDGBIIG.FXAA1PresetA:
				result = this.EPAFEOKHFAC;
				break;
			case GIHPHDGBIIG.FXAA1PresetB:
				result = this.KJJLPJBLECA;
				break;
			case GIHPHDGBIIG.NFAA:
				result = this.HJPNPFOCKNH;
				break;
			case GIHPHDGBIIG.SSAA:
				result = this.KGHMBEHHMHG;
				break;
			case GIHPHDGBIIG.DLAA:
				result = this.ILKIBIDOMBK;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x0600B2CF RID: 45775 RVA: 0x004E04E0 File Offset: 0x004DE6E0
		public virtual bool DPGLLLMLAAB()
		{
			base.LGANGHEOPOG(true);
			this.EPAFEOKHFAC = base.PAGPIKMKGLP(this.shaderFXAAPreset2, this.EPAFEOKHFAC);
			this.KJJLPJBLECA = base.FJMGOIOPENE(this.shaderFXAAPreset3, this.KJJLPJBLECA);
			this.PIANCPDFNFA = base.JAODCGBEAIF(this.shaderFXAAII, this.PIANCPDFNFA);
			this.LPNAOMKDNPM = base.PAGPIKMKGLP(this.shaderFXAAIII, this.LPNAOMKDNPM);
			this.HJPNPFOCKNH = base.FJMGOIOPENE(this.nfaaShader, this.HJPNPFOCKNH);
			this.KGHMBEHHMHG = base.PHNMLJJBKDC(this.ssaaShader, this.KGHMBEHHMHG);
			this.ILKIBIDOMBK = base.LBFLGMNPKHN(this.dlaaShader, this.ILKIBIDOMBK);
			if (!this.ssaaShader.isSupported)
			{
				base.OBHMLOABCAN();
				base.LNEHBOJIBAI();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B2D0 RID: 45776 RVA: 0x004E05BC File Offset: 0x004DE7BC
		public virtual bool CCMBJKDAMLO()
		{
			base.OAAFLHNDKBJ(false);
			this.EPAFEOKHFAC = base.IBKIBFDHBKA(this.shaderFXAAPreset2, this.EPAFEOKHFAC);
			this.KJJLPJBLECA = base.FJMGOIOPENE(this.shaderFXAAPreset3, this.KJJLPJBLECA);
			this.PIANCPDFNFA = base.FJMGOIOPENE(this.shaderFXAAII, this.PIANCPDFNFA);
			this.LPNAOMKDNPM = base.IBKIBFDHBKA(this.shaderFXAAIII, this.LPNAOMKDNPM);
			this.HJPNPFOCKNH = base.PAGPIKMKGLP(this.nfaaShader, this.HJPNPFOCKNH);
			this.KGHMBEHHMHG = base.DLDCFEJJBBI(this.ssaaShader, this.KGHMBEHHMHG);
			this.ILKIBIDOMBK = base.JAODCGBEAIF(this.dlaaShader, this.ILKIBIDOMBK);
			if (!this.ssaaShader.isSupported)
			{
				base.OBHMLOABCAN();
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B2D1 RID: 45777 RVA: 0x004E0698 File Offset: 0x004DE898
		public void EOMGNPFHPBD(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.MNDOFMMGLMO())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA3Console && this.LPNAOMKDNPM != null)
			{
				this.LPNAOMKDNPM.SetFloat("no_time_period", this.edgeThresholdMin);
				this.LPNAOMKDNPM.SetFloat("StaffHeal", this.edgeThreshold);
				this.LPNAOMKDNPM.SetFloat("_StretchWidth", this.edgeSharpness);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LPNAOMKDNPM);
				return;
			}
			if (this.mode == GIHPHDGBIIG.SSAA && this.KJJLPJBLECA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KJJLPJBLECA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA3Console && this.EPAFEOKHFAC != null)
			{
				JONJODLFAEN.anisoLevel = 6;
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EPAFEOKHFAC);
				JONJODLFAEN.anisoLevel = 1;
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.PIANCPDFNFA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PIANCPDFNFA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA1PresetB && this.KGHMBEHHMHG != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KGHMBEHHMHG);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.ILKIBIDOMBK != null)
			{
				JONJODLFAEN.anisoLevel = 1;
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
				Graphics.Blit(JONJODLFAEN, temporary, this.ILKIBIDOMBK, 0);
				Graphics.Blit(temporary, OKIIDHIJBEA, this.ILKIBIDOMBK, this.dlaaSharp ? 3 : 0);
				RenderTexture.ReleaseTemporary(temporary);
				return;
			}
			if (this.mode == (GIHPHDGBIIG)7 && this.HJPNPFOCKNH != null)
			{
				JONJODLFAEN.anisoLevel = 1;
				this.HJPNPFOCKNH.SetFloat("Null", this.offsetScale);
				this.HJPNPFOCKNH.SetFloat("IK unassigned in FABRIKChain.", this.blurRadius);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HJPNPFOCKNH, this.showGeneratedNormals ? 1 : 1);
				return;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
		}

		// Token: 0x0600B2D2 RID: 45778 RVA: 0x004E0888 File Offset: 0x004DEA88
		public virtual bool BGNOLJBJGEL()
		{
			base.NHCAHIHJHMF(true);
			this.EPAFEOKHFAC = base.DLDCFEJJBBI(this.shaderFXAAPreset2, this.EPAFEOKHFAC);
			this.KJJLPJBLECA = base.JAODCGBEAIF(this.shaderFXAAPreset3, this.KJJLPJBLECA);
			this.PIANCPDFNFA = base.PAGPIKMKGLP(this.shaderFXAAII, this.PIANCPDFNFA);
			this.LPNAOMKDNPM = base.PHNMLJJBKDC(this.shaderFXAAIII, this.LPNAOMKDNPM);
			this.HJPNPFOCKNH = base.IBKIBFDHBKA(this.nfaaShader, this.HJPNPFOCKNH);
			this.KGHMBEHHMHG = base.PHNMLJJBKDC(this.ssaaShader, this.KGHMBEHHMHG);
			this.ILKIBIDOMBK = base.JAODCGBEAIF(this.dlaaShader, this.ILKIBIDOMBK);
			if (!this.ssaaShader.isSupported)
			{
				base.OBHMLOABCAN();
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B2D3 RID: 45779 RVA: 0x004E0964 File Offset: 0x004DEB64
		public Material JOGMOLPBAKG()
		{
			Material result;
			switch (this.mode)
			{
			case GIHPHDGBIIG.FXAA2:
				result = this.PIANCPDFNFA;
				break;
			case GIHPHDGBIIG.FXAA3Console:
				result = this.LPNAOMKDNPM;
				break;
			case GIHPHDGBIIG.FXAA1PresetA:
				result = this.EPAFEOKHFAC;
				break;
			case GIHPHDGBIIG.FXAA1PresetB:
				result = this.KJJLPJBLECA;
				break;
			case GIHPHDGBIIG.NFAA:
				result = this.HJPNPFOCKNH;
				break;
			case GIHPHDGBIIG.SSAA:
				result = this.KGHMBEHHMHG;
				break;
			case GIHPHDGBIIG.DLAA:
				result = this.ILKIBIDOMBK;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x0600B2D4 RID: 45780 RVA: 0x004E09E0 File Offset: 0x004DEBE0
		public virtual bool KHEPGGOEGIA()
		{
			base.CBJDCDELBJN(false);
			this.EPAFEOKHFAC = base.PAGPIKMKGLP(this.shaderFXAAPreset2, this.EPAFEOKHFAC);
			this.KJJLPJBLECA = base.PAGPIKMKGLP(this.shaderFXAAPreset3, this.KJJLPJBLECA);
			this.PIANCPDFNFA = base.LBFLGMNPKHN(this.shaderFXAAII, this.PIANCPDFNFA);
			this.LPNAOMKDNPM = base.PHNMLJJBKDC(this.shaderFXAAIII, this.LPNAOMKDNPM);
			this.HJPNPFOCKNH = base.PHNMLJJBKDC(this.nfaaShader, this.HJPNPFOCKNH);
			this.KGHMBEHHMHG = base.PHNMLJJBKDC(this.ssaaShader, this.KGHMBEHHMHG);
			this.ILKIBIDOMBK = base.FJMGOIOPENE(this.dlaaShader, this.ILKIBIDOMBK);
			if (!this.ssaaShader.isSupported)
			{
				base.OCGNIJDNOOM();
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B2D5 RID: 45781 RVA: 0x004E0ABC File Offset: 0x004DECBC
		public virtual bool POKDAEAADAC()
		{
			base.MGHNCKDCFGL(true);
			this.EPAFEOKHFAC = base.IBKIBFDHBKA(this.shaderFXAAPreset2, this.EPAFEOKHFAC);
			this.KJJLPJBLECA = base.DLDCFEJJBBI(this.shaderFXAAPreset3, this.KJJLPJBLECA);
			this.PIANCPDFNFA = base.DLDCFEJJBBI(this.shaderFXAAII, this.PIANCPDFNFA);
			this.LPNAOMKDNPM = base.PHNMLJJBKDC(this.shaderFXAAIII, this.LPNAOMKDNPM);
			this.HJPNPFOCKNH = base.PAGPIKMKGLP(this.nfaaShader, this.HJPNPFOCKNH);
			this.KGHMBEHHMHG = base.PHNMLJJBKDC(this.ssaaShader, this.KGHMBEHHMHG);
			this.ILKIBIDOMBK = base.PAGPIKMKGLP(this.dlaaShader, this.ILKIBIDOMBK);
			if (!this.ssaaShader.isSupported)
			{
				base.FEFCOCIEFAK();
				base.OAEAMDHOKKM();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B2D6 RID: 45782 RVA: 0x004E0B98 File Offset: 0x004DED98
		public virtual bool FGENCAKNJAI()
		{
			base.OFKOBOMCECF(false);
			this.EPAFEOKHFAC = base.IBKIBFDHBKA(this.shaderFXAAPreset2, this.EPAFEOKHFAC);
			this.KJJLPJBLECA = base.DLDCFEJJBBI(this.shaderFXAAPreset3, this.KJJLPJBLECA);
			this.PIANCPDFNFA = base.LBFLGMNPKHN(this.shaderFXAAII, this.PIANCPDFNFA);
			this.LPNAOMKDNPM = base.IBKIBFDHBKA(this.shaderFXAAIII, this.LPNAOMKDNPM);
			this.HJPNPFOCKNH = base.DLDCFEJJBBI(this.nfaaShader, this.HJPNPFOCKNH);
			this.KGHMBEHHMHG = base.PHNMLJJBKDC(this.ssaaShader, this.KGHMBEHHMHG);
			this.ILKIBIDOMBK = base.JAODCGBEAIF(this.dlaaShader, this.ILKIBIDOMBK);
			if (!this.ssaaShader.isSupported)
			{
				base.OBHMLOABCAN();
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B2D7 RID: 45783 RVA: 0x004E0C74 File Offset: 0x004DEE74
		public Material ELCMGEFMDEC()
		{
			Material result;
			switch (this.mode)
			{
			case GIHPHDGBIIG.FXAA2:
				result = this.PIANCPDFNFA;
				break;
			case GIHPHDGBIIG.FXAA3Console:
				result = this.LPNAOMKDNPM;
				break;
			case GIHPHDGBIIG.FXAA1PresetA:
				result = this.EPAFEOKHFAC;
				break;
			case GIHPHDGBIIG.FXAA1PresetB:
				result = this.KJJLPJBLECA;
				break;
			case GIHPHDGBIIG.NFAA:
				result = this.HJPNPFOCKNH;
				break;
			case GIHPHDGBIIG.SSAA:
				result = this.KGHMBEHHMHG;
				break;
			case GIHPHDGBIIG.DLAA:
				result = this.ILKIBIDOMBK;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x0600B2D8 RID: 45784 RVA: 0x004E0CF0 File Offset: 0x004DEEF0
		public void GHJHBHOMELE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.LPNAOMKDNPM != null)
			{
				this.LPNAOMKDNPM.SetFloat("OneHandSwordReady", this.edgeThresholdMin);
				this.LPNAOMKDNPM.SetFloat("_Cull", this.edgeThreshold);
				this.LPNAOMKDNPM.SetFloat("Head stand", this.edgeSharpness);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LPNAOMKDNPM);
				return;
			}
			if (this.mode == GIHPHDGBIIG.NFAA && this.KJJLPJBLECA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KJJLPJBLECA);
				return;
			}
			if (this.mode == (GIHPHDGBIIG)8 && this.EPAFEOKHFAC != null)
			{
				JONJODLFAEN.anisoLevel = 2;
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EPAFEOKHFAC);
				JONJODLFAEN.anisoLevel = 1;
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.PIANCPDFNFA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PIANCPDFNFA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.NFAA && this.KGHMBEHHMHG != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KGHMBEHHMHG);
				return;
			}
			if (this.mode == (GIHPHDGBIIG)7 && this.ILKIBIDOMBK != null)
			{
				JONJODLFAEN.anisoLevel = 1;
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
				Graphics.Blit(JONJODLFAEN, temporary, this.ILKIBIDOMBK, 1);
				Graphics.Blit(temporary, OKIIDHIJBEA, this.ILKIBIDOMBK, this.dlaaSharp ? 8 : 0);
				RenderTexture.ReleaseTemporary(temporary);
				return;
			}
			if (this.mode == GIHPHDGBIIG.SSAA && this.HJPNPFOCKNH != null)
			{
				JONJODLFAEN.anisoLevel = 0;
				this.HJPNPFOCKNH.SetFloat("MotorbikeWheely", this.offsetScale);
				this.HJPNPFOCKNH.SetFloat("Thumb", this.blurRadius);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HJPNPFOCKNH, this.showGeneratedNormals ? 0 : 0);
				return;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
		}

		// Token: 0x0600B2D9 RID: 45785 RVA: 0x004E0EE0 File Offset: 0x004DF0E0
		public virtual bool FGDOAAAPBCP()
		{
			base.EHGENDOEHLP(true);
			this.EPAFEOKHFAC = base.JAODCGBEAIF(this.shaderFXAAPreset2, this.EPAFEOKHFAC);
			this.KJJLPJBLECA = base.PHNMLJJBKDC(this.shaderFXAAPreset3, this.KJJLPJBLECA);
			this.PIANCPDFNFA = base.DLDCFEJJBBI(this.shaderFXAAII, this.PIANCPDFNFA);
			this.LPNAOMKDNPM = base.IBKIBFDHBKA(this.shaderFXAAIII, this.LPNAOMKDNPM);
			this.HJPNPFOCKNH = base.PAGPIKMKGLP(this.nfaaShader, this.HJPNPFOCKNH);
			this.KGHMBEHHMHG = base.DLDCFEJJBBI(this.ssaaShader, this.KGHMBEHHMHG);
			this.ILKIBIDOMBK = base.DLDCFEJJBBI(this.dlaaShader, this.ILKIBIDOMBK);
			if (!this.ssaaShader.isSupported)
			{
				base.OBHMLOABCAN();
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B2DA RID: 45786 RVA: 0x004E0FBC File Offset: 0x004DF1BC
		public void GFBELBBAJGD(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA3Console && this.LPNAOMKDNPM != null)
			{
				this.LPNAOMKDNPM.SetFloat("UIPCam_size", this.edgeThresholdMin);
				this.LPNAOMKDNPM.SetFloat(" is represented multiple times in the Bones.", this.edgeThreshold);
				this.LPNAOMKDNPM.SetFloat("_ZWrite", this.edgeSharpness);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LPNAOMKDNPM);
				return;
			}
			if (this.mode == GIHPHDGBIIG.NFAA && this.KJJLPJBLECA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KJJLPJBLECA);
				return;
			}
			if (this.mode == (GIHPHDGBIIG)8 && this.EPAFEOKHFAC != null)
			{
				JONJODLFAEN.anisoLevel = 2;
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EPAFEOKHFAC);
				JONJODLFAEN.anisoLevel = 1;
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.PIANCPDFNFA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PIANCPDFNFA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.KGHMBEHHMHG != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KGHMBEHHMHG);
				return;
			}
			if (this.mode == GIHPHDGBIIG.DLAA && this.ILKIBIDOMBK != null)
			{
				JONJODLFAEN.anisoLevel = 0;
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
				Graphics.Blit(JONJODLFAEN, temporary, this.ILKIBIDOMBK, 0);
				Graphics.Blit(temporary, OKIIDHIJBEA, this.ILKIBIDOMBK, this.dlaaSharp ? 4 : 1);
				RenderTexture.ReleaseTemporary(temporary);
				return;
			}
			if (this.mode == GIHPHDGBIIG.SSAA && this.HJPNPFOCKNH != null)
			{
				JONJODLFAEN.anisoLevel = 0;
				this.HJPNPFOCKNH.SetFloat("sys", this.offsetScale);
				this.HJPNPFOCKNH.SetFloat("startB", this.blurRadius);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HJPNPFOCKNH, this.showGeneratedNormals ? 1 : 0);
				return;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
		}

		// Token: 0x0600B2DB RID: 45787 RVA: 0x004E11AC File Offset: 0x004DF3AC
		public void JEHHGMJKLPB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NHEEDPALBFN())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA3Console && this.LPNAOMKDNPM != null)
			{
				this.LPNAOMKDNPM.SetFloat(" Atlas: ", this.edgeThresholdMin);
				this.LPNAOMKDNPM.SetFloat("", this.edgeThreshold);
				this.LPNAOMKDNPM.SetFloat("dress", this.edgeSharpness);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LPNAOMKDNPM);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA1PresetA && this.KJJLPJBLECA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KJJLPJBLECA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA1PresetA && this.EPAFEOKHFAC != null)
			{
				JONJODLFAEN.anisoLevel = 0;
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EPAFEOKHFAC);
				JONJODLFAEN.anisoLevel = 1;
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.PIANCPDFNFA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PIANCPDFNFA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA3Console && this.KGHMBEHHMHG != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KGHMBEHHMHG);
				return;
			}
			if (this.mode == GIHPHDGBIIG.NFAA && this.ILKIBIDOMBK != null)
			{
				JONJODLFAEN.anisoLevel = 1;
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
				Graphics.Blit(JONJODLFAEN, temporary, this.ILKIBIDOMBK, 1);
				Graphics.Blit(temporary, OKIIDHIJBEA, this.ILKIBIDOMBK, this.dlaaSharp ? 8 : 1);
				RenderTexture.ReleaseTemporary(temporary);
				return;
			}
			if (this.mode == GIHPHDGBIIG.NFAA && this.HJPNPFOCKNH != null)
			{
				JONJODLFAEN.anisoLevel = 0;
				this.HJPNPFOCKNH.SetFloat("_Distortion", this.offsetScale);
				this.HJPNPFOCKNH.SetFloat("_SpawnHeuristic", this.blurRadius);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HJPNPFOCKNH, this.showGeneratedNormals ? 1 : 0);
				return;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
		}

		// Token: 0x0600B2DC RID: 45788 RVA: 0x004E139C File Offset: 0x004DF59C
		public void LIKPOPLLIDJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.IGJKBOMMMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA3Console && this.LPNAOMKDNPM != null)
			{
				this.LPNAOMKDNPM.SetFloat("Roller Crossover Right", this.edgeThresholdMin);
				this.LPNAOMKDNPM.SetFloat("_Screen", this.edgeThreshold);
				this.LPNAOMKDNPM.SetFloat("0x", this.edgeSharpness);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LPNAOMKDNPM);
				return;
			}
			if (this.mode == GIHPHDGBIIG.NFAA && this.KJJLPJBLECA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KJJLPJBLECA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.NFAA && this.EPAFEOKHFAC != null)
			{
				JONJODLFAEN.anisoLevel = 5;
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EPAFEOKHFAC);
				JONJODLFAEN.anisoLevel = 1;
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.PIANCPDFNFA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PIANCPDFNFA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA1PresetB && this.KGHMBEHHMHG != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KGHMBEHHMHG);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA1PresetB && this.ILKIBIDOMBK != null)
			{
				JONJODLFAEN.anisoLevel = 1;
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
				Graphics.Blit(JONJODLFAEN, temporary, this.ILKIBIDOMBK, 1);
				Graphics.Blit(temporary, OKIIDHIJBEA, this.ILKIBIDOMBK, this.dlaaSharp ? 1 : 1);
				RenderTexture.ReleaseTemporary(temporary);
				return;
			}
			if (this.mode == GIHPHDGBIIG.SSAA && this.HJPNPFOCKNH != null)
			{
				JONJODLFAEN.anisoLevel = 1;
				this.HJPNPFOCKNH.SetFloat("_mesh", this.offsetScale);
				this.HJPNPFOCKNH.SetFloat("invn_rec12", this.blurRadius);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HJPNPFOCKNH, this.showGeneratedNormals ? 1 : 1);
				return;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
		}

		// Token: 0x0600B2DD RID: 45789 RVA: 0x004E158C File Offset: 0x004DF78C
		public virtual bool NFFLLNPGHNC()
		{
			base.CDBNBLBOLCL(true);
			this.EPAFEOKHFAC = base.PHNMLJJBKDC(this.shaderFXAAPreset2, this.EPAFEOKHFAC);
			this.KJJLPJBLECA = base.DLDCFEJJBBI(this.shaderFXAAPreset3, this.KJJLPJBLECA);
			this.PIANCPDFNFA = base.FJMGOIOPENE(this.shaderFXAAII, this.PIANCPDFNFA);
			this.LPNAOMKDNPM = base.LBFLGMNPKHN(this.shaderFXAAIII, this.LPNAOMKDNPM);
			this.HJPNPFOCKNH = base.IBKIBFDHBKA(this.nfaaShader, this.HJPNPFOCKNH);
			this.KGHMBEHHMHG = base.LBFLGMNPKHN(this.ssaaShader, this.KGHMBEHHMHG);
			this.ILKIBIDOMBK = base.IBKIBFDHBKA(this.dlaaShader, this.ILKIBIDOMBK);
			if (!this.ssaaShader.isSupported)
			{
				base.OCGNIJDNOOM();
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B2DE RID: 45790 RVA: 0x004E1668 File Offset: 0x004DF868
		public Material AHPBBCENBML()
		{
			Material result;
			switch (this.mode)
			{
			case GIHPHDGBIIG.FXAA2:
				result = this.PIANCPDFNFA;
				break;
			case GIHPHDGBIIG.FXAA3Console:
				result = this.LPNAOMKDNPM;
				break;
			case GIHPHDGBIIG.FXAA1PresetA:
				result = this.EPAFEOKHFAC;
				break;
			case GIHPHDGBIIG.FXAA1PresetB:
				result = this.KJJLPJBLECA;
				break;
			case GIHPHDGBIIG.NFAA:
				result = this.HJPNPFOCKNH;
				break;
			case GIHPHDGBIIG.SSAA:
				result = this.KGHMBEHHMHG;
				break;
			case GIHPHDGBIIG.DLAA:
				result = this.ILKIBIDOMBK;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x0600B2E0 RID: 45792 RVA: 0x004E1738 File Offset: 0x004DF938
		public Material GPLICDGFKAM()
		{
			Material result;
			switch (this.mode)
			{
			case GIHPHDGBIIG.FXAA2:
				result = this.PIANCPDFNFA;
				break;
			case GIHPHDGBIIG.FXAA3Console:
				result = this.LPNAOMKDNPM;
				break;
			case GIHPHDGBIIG.FXAA1PresetA:
				result = this.EPAFEOKHFAC;
				break;
			case GIHPHDGBIIG.FXAA1PresetB:
				result = this.KJJLPJBLECA;
				break;
			case GIHPHDGBIIG.NFAA:
				result = this.HJPNPFOCKNH;
				break;
			case GIHPHDGBIIG.SSAA:
				result = this.KGHMBEHHMHG;
				break;
			case GIHPHDGBIIG.DLAA:
				result = this.ILKIBIDOMBK;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x0600B2E1 RID: 45793 RVA: 0x004E17B4 File Offset: 0x004DF9B4
		public void LLIDCMOMECE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.LPNAOMKDNPM != null)
			{
				this.LPNAOMKDNPM.SetFloat("LookUp", this.edgeThresholdMin);
				this.LPNAOMKDNPM.SetFloat(" ", this.edgeThreshold);
				this.LPNAOMKDNPM.SetFloat("Horizontal", this.edgeSharpness);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LPNAOMKDNPM);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA1PresetA && this.KJJLPJBLECA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KJJLPJBLECA);
				return;
			}
			if (this.mode == (GIHPHDGBIIG)8 && this.EPAFEOKHFAC != null)
			{
				JONJODLFAEN.anisoLevel = 1;
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EPAFEOKHFAC);
				JONJODLFAEN.anisoLevel = 1;
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.PIANCPDFNFA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PIANCPDFNFA);
				return;
			}
			if (this.mode == (GIHPHDGBIIG)7 && this.KGHMBEHHMHG != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KGHMBEHHMHG);
				return;
			}
			if (this.mode == GIHPHDGBIIG.DLAA && this.ILKIBIDOMBK != null)
			{
				JONJODLFAEN.anisoLevel = 1;
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
				Graphics.Blit(JONJODLFAEN, temporary, this.ILKIBIDOMBK, 1);
				Graphics.Blit(temporary, OKIIDHIJBEA, this.ILKIBIDOMBK, this.dlaaSharp ? 0 : 1);
				RenderTexture.ReleaseTemporary(temporary);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA1PresetB && this.HJPNPFOCKNH != null)
			{
				JONJODLFAEN.anisoLevel = 1;
				this.HJPNPFOCKNH.SetFloat("id", this.offsetScale);
				this.HJPNPFOCKNH.SetFloat("UnityEngine.Vector3", this.blurRadius);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HJPNPFOCKNH, this.showGeneratedNormals ? 1 : 0);
				return;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
		}

		// Token: 0x0600B2E2 RID: 45794 RVA: 0x004E19A4 File Offset: 0x004DFBA4
		public Material KOGEBMDFBND()
		{
			Material result;
			switch (this.mode)
			{
			case GIHPHDGBIIG.FXAA2:
				result = this.PIANCPDFNFA;
				break;
			case GIHPHDGBIIG.FXAA3Console:
				result = this.LPNAOMKDNPM;
				break;
			case GIHPHDGBIIG.FXAA1PresetA:
				result = this.EPAFEOKHFAC;
				break;
			case GIHPHDGBIIG.FXAA1PresetB:
				result = this.KJJLPJBLECA;
				break;
			case GIHPHDGBIIG.NFAA:
				result = this.HJPNPFOCKNH;
				break;
			case GIHPHDGBIIG.SSAA:
				result = this.KGHMBEHHMHG;
				break;
			case GIHPHDGBIIG.DLAA:
				result = this.ILKIBIDOMBK;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x0600B2E3 RID: 45795 RVA: 0x004E1A20 File Offset: 0x004DFC20
		public Material DDCEJKFGLIO()
		{
			Material result;
			switch (this.mode)
			{
			case GIHPHDGBIIG.FXAA2:
				result = this.PIANCPDFNFA;
				break;
			case GIHPHDGBIIG.FXAA3Console:
				result = this.LPNAOMKDNPM;
				break;
			case GIHPHDGBIIG.FXAA1PresetA:
				result = this.EPAFEOKHFAC;
				break;
			case GIHPHDGBIIG.FXAA1PresetB:
				result = this.KJJLPJBLECA;
				break;
			case GIHPHDGBIIG.NFAA:
				result = this.HJPNPFOCKNH;
				break;
			case GIHPHDGBIIG.SSAA:
				result = this.KGHMBEHHMHG;
				break;
			case GIHPHDGBIIG.DLAA:
				result = this.ILKIBIDOMBK;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x0600B2E4 RID: 45796 RVA: 0x004E1A9C File Offset: 0x004DFC9C
		public virtual bool HGBPBGGAFOP()
		{
			base.OLMOAHDIDNG(false);
			this.EPAFEOKHFAC = base.FJMGOIOPENE(this.shaderFXAAPreset2, this.EPAFEOKHFAC);
			this.KJJLPJBLECA = base.JAODCGBEAIF(this.shaderFXAAPreset3, this.KJJLPJBLECA);
			this.PIANCPDFNFA = base.PAGPIKMKGLP(this.shaderFXAAII, this.PIANCPDFNFA);
			this.LPNAOMKDNPM = base.JAODCGBEAIF(this.shaderFXAAIII, this.LPNAOMKDNPM);
			this.HJPNPFOCKNH = base.JAODCGBEAIF(this.nfaaShader, this.HJPNPFOCKNH);
			this.KGHMBEHHMHG = base.JAODCGBEAIF(this.ssaaShader, this.KGHMBEHHMHG);
			this.ILKIBIDOMBK = base.FJMGOIOPENE(this.dlaaShader, this.ILKIBIDOMBK);
			if (!this.ssaaShader.isSupported)
			{
				base.FEFCOCIEFAK();
				base.LNEHBOJIBAI();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B2E5 RID: 45797 RVA: 0x004E1B78 File Offset: 0x004DFD78
		public void PMHDOMMHBPG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA3Console && this.LPNAOMKDNPM != null)
			{
				this.LPNAOMKDNPM.SetFloat(" is not supported on this platform!", this.edgeThresholdMin);
				this.LPNAOMKDNPM.SetFloat("BowFire2", this.edgeThreshold);
				this.LPNAOMKDNPM.SetFloat("\n", this.edgeSharpness);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LPNAOMKDNPM);
				return;
			}
			if (this.mode == GIHPHDGBIIG.DLAA && this.KJJLPJBLECA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KJJLPJBLECA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.EPAFEOKHFAC != null)
			{
				JONJODLFAEN.anisoLevel = 2;
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EPAFEOKHFAC);
				JONJODLFAEN.anisoLevel = 0;
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.PIANCPDFNFA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PIANCPDFNFA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA1PresetB && this.KGHMBEHHMHG != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KGHMBEHHMHG);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA1PresetA && this.ILKIBIDOMBK != null)
			{
				JONJODLFAEN.anisoLevel = 1;
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
				Graphics.Blit(JONJODLFAEN, temporary, this.ILKIBIDOMBK, 0);
				Graphics.Blit(temporary, OKIIDHIJBEA, this.ILKIBIDOMBK, this.dlaaSharp ? 4 : 1);
				RenderTexture.ReleaseTemporary(temporary);
				return;
			}
			if (this.mode == (GIHPHDGBIIG)8 && this.HJPNPFOCKNH != null)
			{
				JONJODLFAEN.anisoLevel = 0;
				this.HJPNPFOCKNH.SetFloat("_Jitter", this.offsetScale);
				this.HJPNPFOCKNH.SetFloat("Fist Pump", this.blurRadius);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HJPNPFOCKNH, this.showGeneratedNormals ? 1 : 0);
				return;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
		}

		// Token: 0x0600B2E6 RID: 45798 RVA: 0x004E1D68 File Offset: 0x004DFF68
		public Material MHNMJPILNHK()
		{
			Material result;
			switch (this.mode)
			{
			case GIHPHDGBIIG.FXAA2:
				result = this.PIANCPDFNFA;
				break;
			case GIHPHDGBIIG.FXAA3Console:
				result = this.LPNAOMKDNPM;
				break;
			case GIHPHDGBIIG.FXAA1PresetA:
				result = this.EPAFEOKHFAC;
				break;
			case GIHPHDGBIIG.FXAA1PresetB:
				result = this.KJJLPJBLECA;
				break;
			case GIHPHDGBIIG.NFAA:
				result = this.HJPNPFOCKNH;
				break;
			case GIHPHDGBIIG.SSAA:
				result = this.KGHMBEHHMHG;
				break;
			case GIHPHDGBIIG.DLAA:
				result = this.ILKIBIDOMBK;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x0600B2E7 RID: 45799 RVA: 0x004E1DE4 File Offset: 0x004DFFE4
		public Material CAGHFJPCDIK()
		{
			Material result;
			switch (this.mode)
			{
			case GIHPHDGBIIG.FXAA2:
				result = this.PIANCPDFNFA;
				break;
			case GIHPHDGBIIG.FXAA3Console:
				result = this.LPNAOMKDNPM;
				break;
			case GIHPHDGBIIG.FXAA1PresetA:
				result = this.EPAFEOKHFAC;
				break;
			case GIHPHDGBIIG.FXAA1PresetB:
				result = this.KJJLPJBLECA;
				break;
			case GIHPHDGBIIG.NFAA:
				result = this.HJPNPFOCKNH;
				break;
			case GIHPHDGBIIG.SSAA:
				result = this.KGHMBEHHMHG;
				break;
			case GIHPHDGBIIG.DLAA:
				result = this.ILKIBIDOMBK;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x0600B2E8 RID: 45800 RVA: 0x004E1E60 File Offset: 0x004E0060
		public void JECCAAPKJCK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.DLENDGGGMBJ())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA3Console && this.LPNAOMKDNPM != null)
			{
				this.LPNAOMKDNPM.SetFloat("repair.ogg", this.edgeThresholdMin);
				this.LPNAOMKDNPM.SetFloat("#403000", this.edgeThreshold);
				this.LPNAOMKDNPM.SetFloat("_DiffCubeIBL", this.edgeSharpness);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LPNAOMKDNPM);
				return;
			}
			if (this.mode == GIHPHDGBIIG.DLAA && this.KJJLPJBLECA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KJJLPJBLECA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.SSAA && this.EPAFEOKHFAC != null)
			{
				JONJODLFAEN.anisoLevel = 4;
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EPAFEOKHFAC);
				JONJODLFAEN.anisoLevel = 0;
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.PIANCPDFNFA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PIANCPDFNFA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA3Console && this.KGHMBEHHMHG != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KGHMBEHHMHG);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA3Console && this.ILKIBIDOMBK != null)
			{
				JONJODLFAEN.anisoLevel = 1;
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
				Graphics.Blit(JONJODLFAEN, temporary, this.ILKIBIDOMBK, 0);
				Graphics.Blit(temporary, OKIIDHIJBEA, this.ILKIBIDOMBK, this.dlaaSharp ? 6 : 0);
				RenderTexture.ReleaseTemporary(temporary);
				return;
			}
			if (this.mode == GIHPHDGBIIG.NFAA && this.HJPNPFOCKNH != null)
			{
				JONJODLFAEN.anisoLevel = 1;
				this.HJPNPFOCKNH.SetFloat("0 сек", this.offsetScale);
				this.HJPNPFOCKNH.SetFloat("ok", this.blurRadius);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HJPNPFOCKNH, this.showGeneratedNormals ? 0 : 1);
				return;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
		}

		// Token: 0x0600B2E9 RID: 45801 RVA: 0x004E2050 File Offset: 0x004E0250
		public void NPNOACPLOCB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.IGJKBOMMMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA3Console && this.LPNAOMKDNPM != null)
			{
				this.LPNAOMKDNPM.SetFloat("wpn_eat7", this.edgeThresholdMin);
				this.LPNAOMKDNPM.SetFloat("RenderType", this.edgeThreshold);
				this.LPNAOMKDNPM.SetFloat("SneakBackward", this.edgeSharpness);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LPNAOMKDNPM);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA3Console && this.KJJLPJBLECA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KJJLPJBLECA);
				return;
			}
			if (this.mode == (GIHPHDGBIIG)7 && this.EPAFEOKHFAC != null)
			{
				JONJODLFAEN.anisoLevel = 2;
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EPAFEOKHFAC);
				JONJODLFAEN.anisoLevel = 0;
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.PIANCPDFNFA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PIANCPDFNFA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA3Console && this.KGHMBEHHMHG != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KGHMBEHHMHG);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.ILKIBIDOMBK != null)
			{
				JONJODLFAEN.anisoLevel = 1;
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
				Graphics.Blit(JONJODLFAEN, temporary, this.ILKIBIDOMBK, 1);
				Graphics.Blit(temporary, OKIIDHIJBEA, this.ILKIBIDOMBK, this.dlaaSharp ? 6 : 0);
				RenderTexture.ReleaseTemporary(temporary);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.HJPNPFOCKNH != null)
			{
				JONJODLFAEN.anisoLevel = 1;
				this.HJPNPFOCKNH.SetFloat("Mouse X", this.offsetScale);
				this.HJPNPFOCKNH.SetFloat("_MiddleGrey", this.blurRadius);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HJPNPFOCKNH, this.showGeneratedNormals ? 0 : 1);
				return;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
		}

		// Token: 0x0600B2EA RID: 45802 RVA: 0x004E2240 File Offset: 0x004E0440
		public Material LGEBPCNMOIC()
		{
			Material result;
			switch (this.mode)
			{
			case GIHPHDGBIIG.FXAA2:
				result = this.PIANCPDFNFA;
				break;
			case GIHPHDGBIIG.FXAA3Console:
				result = this.LPNAOMKDNPM;
				break;
			case GIHPHDGBIIG.FXAA1PresetA:
				result = this.EPAFEOKHFAC;
				break;
			case GIHPHDGBIIG.FXAA1PresetB:
				result = this.KJJLPJBLECA;
				break;
			case GIHPHDGBIIG.NFAA:
				result = this.HJPNPFOCKNH;
				break;
			case GIHPHDGBIIG.SSAA:
				result = this.KGHMBEHHMHG;
				break;
			case GIHPHDGBIIG.DLAA:
				result = this.ILKIBIDOMBK;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x0600B2EB RID: 45803 RVA: 0x004E22BC File Offset: 0x004E04BC
		public Material HELJHAGIKNL()
		{
			Material result;
			switch (this.mode)
			{
			case GIHPHDGBIIG.FXAA2:
				result = this.PIANCPDFNFA;
				break;
			case GIHPHDGBIIG.FXAA3Console:
				result = this.LPNAOMKDNPM;
				break;
			case GIHPHDGBIIG.FXAA1PresetA:
				result = this.EPAFEOKHFAC;
				break;
			case GIHPHDGBIIG.FXAA1PresetB:
				result = this.KJJLPJBLECA;
				break;
			case GIHPHDGBIIG.NFAA:
				result = this.HJPNPFOCKNH;
				break;
			case GIHPHDGBIIG.SSAA:
				result = this.KGHMBEHHMHG;
				break;
			case GIHPHDGBIIG.DLAA:
				result = this.ILKIBIDOMBK;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x0600B2EC RID: 45804 RVA: 0x004E2338 File Offset: 0x004E0538
		public virtual bool CFODPFPIHIF()
		{
			base.IDFIHFBEIKD(false);
			this.EPAFEOKHFAC = base.LBFLGMNPKHN(this.shaderFXAAPreset2, this.EPAFEOKHFAC);
			this.KJJLPJBLECA = base.IBKIBFDHBKA(this.shaderFXAAPreset3, this.KJJLPJBLECA);
			this.PIANCPDFNFA = base.JAODCGBEAIF(this.shaderFXAAII, this.PIANCPDFNFA);
			this.LPNAOMKDNPM = base.DLDCFEJJBBI(this.shaderFXAAIII, this.LPNAOMKDNPM);
			this.HJPNPFOCKNH = base.IBKIBFDHBKA(this.nfaaShader, this.HJPNPFOCKNH);
			this.KGHMBEHHMHG = base.FJMGOIOPENE(this.ssaaShader, this.KGHMBEHHMHG);
			this.ILKIBIDOMBK = base.PHNMLJJBKDC(this.dlaaShader, this.ILKIBIDOMBK);
			if (!this.ssaaShader.isSupported)
			{
				base.FEFCOCIEFAK();
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B2ED RID: 45805 RVA: 0x004E2414 File Offset: 0x004E0614
		public virtual bool KFLGCBLCKJD()
		{
			base.EHGENDOEHLP(false);
			this.EPAFEOKHFAC = base.PHNMLJJBKDC(this.shaderFXAAPreset2, this.EPAFEOKHFAC);
			this.KJJLPJBLECA = base.FJMGOIOPENE(this.shaderFXAAPreset3, this.KJJLPJBLECA);
			this.PIANCPDFNFA = base.PAGPIKMKGLP(this.shaderFXAAII, this.PIANCPDFNFA);
			this.LPNAOMKDNPM = base.PAGPIKMKGLP(this.shaderFXAAIII, this.LPNAOMKDNPM);
			this.HJPNPFOCKNH = base.LBFLGMNPKHN(this.nfaaShader, this.HJPNPFOCKNH);
			this.KGHMBEHHMHG = base.JAODCGBEAIF(this.ssaaShader, this.KGHMBEHHMHG);
			this.ILKIBIDOMBK = base.LBFLGMNPKHN(this.dlaaShader, this.ILKIBIDOMBK);
			if (!this.ssaaShader.isSupported)
			{
				base.OBHMLOABCAN();
				base.NAIBIABADFB();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B2EE RID: 45806 RVA: 0x004E24F0 File Offset: 0x004E06F0
		public Material COLCHHEBIHG()
		{
			Material result;
			switch (this.mode)
			{
			case GIHPHDGBIIG.FXAA2:
				result = this.PIANCPDFNFA;
				break;
			case GIHPHDGBIIG.FXAA3Console:
				result = this.LPNAOMKDNPM;
				break;
			case GIHPHDGBIIG.FXAA1PresetA:
				result = this.EPAFEOKHFAC;
				break;
			case GIHPHDGBIIG.FXAA1PresetB:
				result = this.KJJLPJBLECA;
				break;
			case GIHPHDGBIIG.NFAA:
				result = this.HJPNPFOCKNH;
				break;
			case GIHPHDGBIIG.SSAA:
				result = this.KGHMBEHHMHG;
				break;
			case GIHPHDGBIIG.DLAA:
				result = this.ILKIBIDOMBK;
				break;
			default:
				result = null;
				break;
			}
			return result;
		}

		// Token: 0x0600B2EF RID: 45807 RVA: 0x004E256C File Offset: 0x004E076C
		public virtual bool AGAGDKHKPCJ()
		{
			base.CDBNBLBOLCL(true);
			this.EPAFEOKHFAC = base.LBFLGMNPKHN(this.shaderFXAAPreset2, this.EPAFEOKHFAC);
			this.KJJLPJBLECA = base.FJMGOIOPENE(this.shaderFXAAPreset3, this.KJJLPJBLECA);
			this.PIANCPDFNFA = base.IBKIBFDHBKA(this.shaderFXAAII, this.PIANCPDFNFA);
			this.LPNAOMKDNPM = base.PAGPIKMKGLP(this.shaderFXAAIII, this.LPNAOMKDNPM);
			this.HJPNPFOCKNH = base.LBFLGMNPKHN(this.nfaaShader, this.HJPNPFOCKNH);
			this.KGHMBEHHMHG = base.PAGPIKMKGLP(this.ssaaShader, this.KGHMBEHHMHG);
			this.ILKIBIDOMBK = base.LBFLGMNPKHN(this.dlaaShader, this.ILKIBIDOMBK);
			if (!this.ssaaShader.isSupported)
			{
				base.FEFCOCIEFAK();
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B2F0 RID: 45808 RVA: 0x004E2648 File Offset: 0x004E0848
		public void EIMKKKCGJLO(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA3Console && this.LPNAOMKDNPM != null)
			{
				this.LPNAOMKDNPM.SetFloat("", this.edgeThresholdMin);
				this.LPNAOMKDNPM.SetFloat("PistolReady", this.edgeThreshold);
				this.LPNAOMKDNPM.SetFloat("WorkerHammer2", this.edgeSharpness);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LPNAOMKDNPM);
				return;
			}
			if (this.mode == (GIHPHDGBIIG)7 && this.KJJLPJBLECA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KJJLPJBLECA);
				return;
			}
			if (this.mode == (GIHPHDGBIIG)7 && this.EPAFEOKHFAC != null)
			{
				JONJODLFAEN.anisoLevel = 5;
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EPAFEOKHFAC);
				JONJODLFAEN.anisoLevel = 1;
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.PIANCPDFNFA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PIANCPDFNFA);
				return;
			}
			if (this.mode == (GIHPHDGBIIG)8 && this.KGHMBEHHMHG != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KGHMBEHHMHG);
				return;
			}
			if (this.mode == GIHPHDGBIIG.SSAA && this.ILKIBIDOMBK != null)
			{
				JONJODLFAEN.anisoLevel = 1;
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
				Graphics.Blit(JONJODLFAEN, temporary, this.ILKIBIDOMBK, 0);
				Graphics.Blit(temporary, OKIIDHIJBEA, this.ILKIBIDOMBK, this.dlaaSharp ? 3 : 1);
				RenderTexture.ReleaseTemporary(temporary);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.HJPNPFOCKNH != null)
			{
				JONJODLFAEN.anisoLevel = 1;
				this.HJPNPFOCKNH.SetFloat("***Lots ", this.offsetScale);
				this.HJPNPFOCKNH.SetFloat("_WrinkleInfluences0", this.blurRadius);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HJPNPFOCKNH, this.showGeneratedNormals ? 1 : 1);
				return;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
		}

		// Token: 0x0600B2F1 RID: 45809 RVA: 0x004E2838 File Offset: 0x004E0A38
		public virtual bool DPCKBGJGNAK()
		{
			base.CGEGCOKMPHN(false);
			this.EPAFEOKHFAC = base.PHNMLJJBKDC(this.shaderFXAAPreset2, this.EPAFEOKHFAC);
			this.KJJLPJBLECA = base.PAGPIKMKGLP(this.shaderFXAAPreset3, this.KJJLPJBLECA);
			this.PIANCPDFNFA = base.DLDCFEJJBBI(this.shaderFXAAII, this.PIANCPDFNFA);
			this.LPNAOMKDNPM = base.PAGPIKMKGLP(this.shaderFXAAIII, this.LPNAOMKDNPM);
			this.HJPNPFOCKNH = base.PHNMLJJBKDC(this.nfaaShader, this.HJPNPFOCKNH);
			this.KGHMBEHHMHG = base.PAGPIKMKGLP(this.ssaaShader, this.KGHMBEHHMHG);
			this.ILKIBIDOMBK = base.LBFLGMNPKHN(this.dlaaShader, this.ILKIBIDOMBK);
			if (!this.ssaaShader.isSupported)
			{
				base.FEFCOCIEFAK();
				base.FDBKFKGCGEG();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B2F2 RID: 45810 RVA: 0x004E2914 File Offset: 0x004E0B14
		public virtual bool LFFHBBCPHJE()
		{
			base.DAOKCAOFIGE(false);
			this.EPAFEOKHFAC = base.LBFLGMNPKHN(this.shaderFXAAPreset2, this.EPAFEOKHFAC);
			this.KJJLPJBLECA = base.JAODCGBEAIF(this.shaderFXAAPreset3, this.KJJLPJBLECA);
			this.PIANCPDFNFA = base.PAGPIKMKGLP(this.shaderFXAAII, this.PIANCPDFNFA);
			this.LPNAOMKDNPM = base.PAGPIKMKGLP(this.shaderFXAAIII, this.LPNAOMKDNPM);
			this.HJPNPFOCKNH = base.PAGPIKMKGLP(this.nfaaShader, this.HJPNPFOCKNH);
			this.KGHMBEHHMHG = base.DLDCFEJJBBI(this.ssaaShader, this.KGHMBEHHMHG);
			this.ILKIBIDOMBK = base.FJMGOIOPENE(this.dlaaShader, this.ILKIBIDOMBK);
			if (!this.ssaaShader.isSupported)
			{
				base.OCGNIJDNOOM();
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B2F3 RID: 45811 RVA: 0x004E29F0 File Offset: 0x004E0BF0
		public override bool CheckResources()
		{
			base.DAOKCAOFIGE(false);
			this.EPAFEOKHFAC = base.PHNMLJJBKDC(this.shaderFXAAPreset2, this.EPAFEOKHFAC);
			this.KJJLPJBLECA = base.PHNMLJJBKDC(this.shaderFXAAPreset3, this.KJJLPJBLECA);
			this.PIANCPDFNFA = base.PHNMLJJBKDC(this.shaderFXAAII, this.PIANCPDFNFA);
			this.LPNAOMKDNPM = base.PHNMLJJBKDC(this.shaderFXAAIII, this.LPNAOMKDNPM);
			this.HJPNPFOCKNH = base.PHNMLJJBKDC(this.nfaaShader, this.HJPNPFOCKNH);
			this.KGHMBEHHMHG = base.PHNMLJJBKDC(this.ssaaShader, this.KGHMBEHHMHG);
			this.ILKIBIDOMBK = base.PHNMLJJBKDC(this.dlaaShader, this.ILKIBIDOMBK);
			if (!this.ssaaShader.isSupported)
			{
				base.AGGGAHEKKCO();
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B2F4 RID: 45812 RVA: 0x004E2ACC File Offset: 0x004E0CCC
		public void PLOEFNMCMEF(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.MNDOFMMGLMO())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.LPNAOMKDNPM != null)
			{
				this.LPNAOMKDNPM.SetFloat("_Power", this.edgeThresholdMin);
				this.LPNAOMKDNPM.SetFloat("uierror6.wav", this.edgeThreshold);
				this.LPNAOMKDNPM.SetFloat("Flashlight", this.edgeSharpness);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LPNAOMKDNPM);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA1PresetB && this.KJJLPJBLECA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KJJLPJBLECA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.DLAA && this.EPAFEOKHFAC != null)
			{
				JONJODLFAEN.anisoLevel = 1;
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EPAFEOKHFAC);
				JONJODLFAEN.anisoLevel = 1;
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.PIANCPDFNFA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PIANCPDFNFA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA1PresetA && this.KGHMBEHHMHG != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KGHMBEHHMHG);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA1PresetA && this.ILKIBIDOMBK != null)
			{
				JONJODLFAEN.anisoLevel = 0;
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
				Graphics.Blit(JONJODLFAEN, temporary, this.ILKIBIDOMBK, 0);
				Graphics.Blit(temporary, OKIIDHIJBEA, this.ILKIBIDOMBK, this.dlaaSharp ? 7 : 1);
				RenderTexture.ReleaseTemporary(temporary);
				return;
			}
			if (this.mode == GIHPHDGBIIG.DLAA && this.HJPNPFOCKNH != null)
			{
				JONJODLFAEN.anisoLevel = 1;
				this.HJPNPFOCKNH.SetFloat("ClimbUp", this.offsetScale);
				this.HJPNPFOCKNH.SetFloat("FishModel", this.blurRadius);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HJPNPFOCKNH, this.showGeneratedNormals ? 0 : 0);
				return;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
		}

		// Token: 0x0600B2F5 RID: 45813 RVA: 0x004E2CBC File Offset: 0x004E0EBC
		public void EGOKABFLKGC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA3Console && this.LPNAOMKDNPM != null)
			{
				this.LPNAOMKDNPM.SetFloat("Sitting Reading Page Flip", this.edgeThresholdMin);
				this.LPNAOMKDNPM.SetFloat("+{0}", this.edgeThreshold);
				this.LPNAOMKDNPM.SetFloat("WorkerHammer", this.edgeSharpness);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LPNAOMKDNPM);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA3Console && this.KJJLPJBLECA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KJJLPJBLECA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.DLAA && this.EPAFEOKHFAC != null)
			{
				JONJODLFAEN.anisoLevel = 8;
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EPAFEOKHFAC);
				JONJODLFAEN.anisoLevel = 1;
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.PIANCPDFNFA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PIANCPDFNFA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA3Console && this.KGHMBEHHMHG != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KGHMBEHHMHG);
				return;
			}
			if (this.mode == GIHPHDGBIIG.NFAA && this.ILKIBIDOMBK != null)
			{
				JONJODLFAEN.anisoLevel = 1;
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
				Graphics.Blit(JONJODLFAEN, temporary, this.ILKIBIDOMBK, 1);
				Graphics.Blit(temporary, OKIIDHIJBEA, this.ILKIBIDOMBK, this.dlaaSharp ? 5 : 1);
				RenderTexture.ReleaseTemporary(temporary);
				return;
			}
			if (this.mode == GIHPHDGBIIG.NFAA && this.HJPNPFOCKNH != null)
			{
				JONJODLFAEN.anisoLevel = 0;
				this.HJPNPFOCKNH.SetFloat("_info", this.offsetScale);
				this.HJPNPFOCKNH.SetFloat("", this.blurRadius);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HJPNPFOCKNH, this.showGeneratedNormals ? 1 : 0);
				return;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
		}

		// Token: 0x0600B2F6 RID: 45814 RVA: 0x004E2EAC File Offset: 0x004E10AC
		public void JMFAMACDLNN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.LPNAOMKDNPM != null)
			{
				this.LPNAOMKDNPM.SetFloat("Criticals", this.edgeThresholdMin);
				this.LPNAOMKDNPM.SetFloat("_ToneCurveRange", this.edgeThreshold);
				this.LPNAOMKDNPM.SetFloat("neck", this.edgeSharpness);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LPNAOMKDNPM);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA1PresetB && this.KJJLPJBLECA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KJJLPJBLECA);
				return;
			}
			if (this.mode == (GIHPHDGBIIG)7 && this.EPAFEOKHFAC != null)
			{
				JONJODLFAEN.anisoLevel = 3;
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EPAFEOKHFAC);
				JONJODLFAEN.anisoLevel = 0;
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA2 && this.PIANCPDFNFA != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.PIANCPDFNFA);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA3Console && this.KGHMBEHHMHG != null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KGHMBEHHMHG);
				return;
			}
			if (this.mode == GIHPHDGBIIG.FXAA3Console && this.ILKIBIDOMBK != null)
			{
				JONJODLFAEN.anisoLevel = 1;
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height);
				Graphics.Blit(JONJODLFAEN, temporary, this.ILKIBIDOMBK, 1);
				Graphics.Blit(temporary, OKIIDHIJBEA, this.ILKIBIDOMBK, this.dlaaSharp ? 2 : 0);
				RenderTexture.ReleaseTemporary(temporary);
				return;
			}
			if (this.mode == GIHPHDGBIIG.NFAA && this.HJPNPFOCKNH != null)
			{
				JONJODLFAEN.anisoLevel = 0;
				this.HJPNPFOCKNH.SetFloat("_Color", this.offsetScale);
				this.HJPNPFOCKNH.SetFloat("sunshine_ShadowCoordDepthRayU", this.blurRadius);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HJPNPFOCKNH, this.showGeneratedNormals ? 1 : 1);
				return;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
		}

		// Token: 0x0400169A RID: 5786
		public GIHPHDGBIIG mode = GIHPHDGBIIG.FXAA3Console;

		// Token: 0x0400169B RID: 5787
		public bool showGeneratedNormals;

		// Token: 0x0400169C RID: 5788
		public float offsetScale = 0.2f;

		// Token: 0x0400169D RID: 5789
		public float blurRadius = 18f;

		// Token: 0x0400169E RID: 5790
		public float edgeThresholdMin = 0.05f;

		// Token: 0x0400169F RID: 5791
		public float edgeThreshold = 0.2f;

		// Token: 0x040016A0 RID: 5792
		public float edgeSharpness = 4f;

		// Token: 0x040016A1 RID: 5793
		public bool dlaaSharp;

		// Token: 0x040016A2 RID: 5794
		public Shader ssaaShader;

		// Token: 0x040016A3 RID: 5795
		private Material KGHMBEHHMHG;

		// Token: 0x040016A4 RID: 5796
		public Shader dlaaShader;

		// Token: 0x040016A5 RID: 5797
		private Material ILKIBIDOMBK;

		// Token: 0x040016A6 RID: 5798
		public Shader nfaaShader;

		// Token: 0x040016A7 RID: 5799
		private Material HJPNPFOCKNH;

		// Token: 0x040016A8 RID: 5800
		public Shader shaderFXAAPreset2;

		// Token: 0x040016A9 RID: 5801
		private Material EPAFEOKHFAC;

		// Token: 0x040016AA RID: 5802
		public Shader shaderFXAAPreset3;

		// Token: 0x040016AB RID: 5803
		private Material KJJLPJBLECA;

		// Token: 0x040016AC RID: 5804
		public Shader shaderFXAAII;

		// Token: 0x040016AD RID: 5805
		private Material PIANCPDFNFA;

		// Token: 0x040016AE RID: 5806
		public Shader shaderFXAAIII;

		// Token: 0x040016AF RID: 5807
		private Material LPNAOMKDNPM;
	}
}
