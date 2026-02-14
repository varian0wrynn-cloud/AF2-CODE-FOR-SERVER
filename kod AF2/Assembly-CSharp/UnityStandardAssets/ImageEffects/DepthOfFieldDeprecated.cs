using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x0200031A RID: 794
	[AddComponentMenu("Image Effects/Camera/Depth of Field (deprecated)")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class DepthOfFieldDeprecated : PostEffectsBase
	{
		// Token: 0x0600B69A RID: 46746 RVA: 0x00511864 File Offset: 0x0050FA64
		private int EIBNMEAGDIM()
		{
			int result = 1;
			if (this.resolution == DepthOfFieldDeprecated.EDNECHKAFDC.Medium)
			{
				result = 2;
			}
			else if (this.resolution == DepthOfFieldDeprecated.EDNECHKAFDC.Low)
			{
				result = 2;
			}
			return result;
		}

		// Token: 0x0600B69B RID: 46747 RVA: 0x0051188C File Offset: 0x0050FA8C
		private void FNMFECJCGBP()
		{
			this.JBBAHGKAIFF = base.DJFOEIJIMJB(this.dofBlurShader, this.JBBAHGKAIFF);
			this.HOEHDBIHELI = base.DJFOEIJIMJB(this.dofShader, this.HOEHDBIHELI);
			this.bokehSupport = this.bokehShader.isSupported;
			if (this.bokeh && this.bokehSupport && this.bokehShader)
			{
				this.JNFMKGDGJEA = base.DJFOEIJIMJB(this.bokehShader, this.JNFMKGDGJEA);
			}
		}

		// Token: 0x0600B69C RID: 46748 RVA: 0x00511910 File Offset: 0x0050FB10
		private void HFPKDEPJDBK(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ, DepthOfFieldDeprecated.BMEMFJFOHOJ DPBMPHJBLBO, int AGNBHDBHKCJ, float GLJOIOBPAEP)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(LJGGOANMJAJ.width, LJGGOANMJAJ.height);
			if (DPBMPHJBLBO > (DepthOfFieldDeprecated.BMEMFJFOHOJ)0)
			{
				this.LCLPLBMOCGB(GMNLJGNOKPD, LJGGOANMJAJ, AGNBHDBHKCJ, GLJOIOBPAEP, temporary);
				if (DPBMPHJBLBO > (DepthOfFieldDeprecated.BMEMFJFOHOJ)3)
				{
					this.JBBAHGKAIFF.SetVector("_LowRez", new Vector4(58f, GLJOIOBPAEP * this.OFJHPNCEPHN, 1478f, 1131f));
					Graphics.Blit(LJGGOANMJAJ, temporary, this.JBBAHGKAIFF, AGNBHDBHKCJ);
					this.JBBAHGKAIFF.SetVector("QTaskMgr is INIT", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 87f, 1706f, 529f));
					Graphics.Blit(temporary, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
				}
			}
			else
			{
				this.JBBAHGKAIFF.SetVector("OfficeSittingHandRestFingerTap", new Vector4(1088f, GLJOIOBPAEP * this.OFJHPNCEPHN, 1246f, 1961f));
				Graphics.Blit(GMNLJGNOKPD, temporary, this.JBBAHGKAIFF, AGNBHDBHKCJ);
				this.JBBAHGKAIFF.SetVector("System.Single", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 1587f, 602f, 1444f));
				Graphics.Blit(temporary, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600B69D RID: 46749 RVA: 0x00511A50 File Offset: 0x0050FC50
		public virtual bool GFFHOHOMAMD()
		{
			base.PKDIKFGAJKM(true);
			this.JBBAHGKAIFF = base.BAPJBHPEDIF(this.dofBlurShader, this.JBBAHGKAIFF);
			this.HOEHDBIHELI = base.BAPJBHPEDIF(this.dofShader, this.HOEHDBIHELI);
			this.bokehSupport = this.bokehShader.isSupported;
			if (this.bokeh && this.bokehSupport && this.bokehShader)
			{
				this.JNFMKGDGJEA = base.BAPJBHPEDIF(this.bokehShader, this.JNFMKGDGJEA);
			}
			if (!this.PPGOAMIHMBG)
			{
				base.INOGPLDHPGC();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B69E RID: 46750 RVA: 0x00511AF0 File Offset: 0x0050FCF0
		private void AFFBIKGBBGB(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ, DepthOfFieldDeprecated.BMEMFJFOHOJ DPBMPHJBLBO, int AGNBHDBHKCJ, float GLJOIOBPAEP)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(LJGGOANMJAJ.width, LJGGOANMJAJ.height);
			if (DPBMPHJBLBO > DepthOfFieldDeprecated.BMEMFJFOHOJ.Low)
			{
				this.LCMGBONCKHA(GMNLJGNOKPD, LJGGOANMJAJ, AGNBHDBHKCJ, GLJOIOBPAEP, temporary);
				if (DPBMPHJBLBO > (DepthOfFieldDeprecated.BMEMFJFOHOJ)6)
				{
					this.JBBAHGKAIFF.SetVector("IdleDodgeLeft", new Vector4(50f, GLJOIOBPAEP * this.OFJHPNCEPHN, 708f, 645f));
					Graphics.Blit(LJGGOANMJAJ, temporary, this.JBBAHGKAIFF, AGNBHDBHKCJ);
					this.JBBAHGKAIFF.SetVector(", ", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 498f, 1169f, 128f));
					Graphics.Blit(temporary, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
				}
			}
			else
			{
				this.JBBAHGKAIFF.SetVector("No Way points!", new Vector4(237f, GLJOIOBPAEP * this.OFJHPNCEPHN, 430f, 610f));
				Graphics.Blit(GMNLJGNOKPD, temporary, this.JBBAHGKAIFF, AGNBHDBHKCJ);
				this.JBBAHGKAIFF.SetVector("IdleStand", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 1483f, 781f, 1627f));
				Graphics.Blit(temporary, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600B69F RID: 46751 RVA: 0x00511C30 File Offset: 0x0050FE30
		private void IEJJCENDNFP(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ, DepthOfFieldDeprecated.BMEMFJFOHOJ DPBMPHJBLBO, int AGNBHDBHKCJ, float GLJOIOBPAEP)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(LJGGOANMJAJ.width, LJGGOANMJAJ.height);
			if (DPBMPHJBLBO > DepthOfFieldDeprecated.BMEMFJFOHOJ.Low)
			{
				this.PHDGHMAKPEF(GMNLJGNOKPD, LJGGOANMJAJ, AGNBHDBHKCJ, GLJOIOBPAEP, temporary);
				if (DPBMPHJBLBO > DepthOfFieldDeprecated.BMEMFJFOHOJ.VeryHigh)
				{
					this.JBBAHGKAIFF.SetVector("WeaponInstant", new Vector4(1672f, GLJOIOBPAEP * this.OFJHPNCEPHN, 445f, 982f));
					Graphics.Blit(LJGGOANMJAJ, temporary, this.JBBAHGKAIFF, AGNBHDBHKCJ);
					this.JBBAHGKAIFF.SetVector("IdleDie", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 328f, 1007f, 454f));
					Graphics.Blit(temporary, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
				}
			}
			else
			{
				this.JBBAHGKAIFF.SetVector("Sun reference not set.", new Vector4(1275f, GLJOIOBPAEP * this.OFJHPNCEPHN, 607f, 172f));
				Graphics.Blit(GMNLJGNOKPD, temporary, this.JBBAHGKAIFF, AGNBHDBHKCJ);
				this.JBBAHGKAIFF.SetVector("S", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 1344f, 1042f, 1268f));
				Graphics.Blit(temporary, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600B6A0 RID: 46752 RVA: 0x00511D70 File Offset: 0x0050FF70
		private void NKPKAIIDNAL()
		{
			this.JBBAHGKAIFF = base.BAPJBHPEDIF(this.dofBlurShader, this.JBBAHGKAIFF);
			this.HOEHDBIHELI = base.BAPJBHPEDIF(this.dofShader, this.HOEHDBIHELI);
			this.bokehSupport = this.bokehShader.isSupported;
			if (this.bokeh && this.bokehSupport && this.bokehShader)
			{
				this.JNFMKGDGJEA = base.IIIIADNBONI(this.bokehShader, this.JNFMKGDGJEA);
			}
		}

		// Token: 0x0600B6A1 RID: 46753 RVA: 0x00511DF4 File Offset: 0x0050FFF4
		private void DPNOOALCHAM(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ, int AGNBHDBHKCJ, float GLJOIOBPAEP, RenderTexture KBNKJKBDCLN)
		{
			this.JBBAHGKAIFF.SetVector("Kernel", new Vector4(487f, GLJOIOBPAEP * this.OFJHPNCEPHN, 1206f, 323f));
			Graphics.Blit(GMNLJGNOKPD, KBNKJKBDCLN, this.JBBAHGKAIFF, AGNBHDBHKCJ);
			this.JBBAHGKAIFF.SetVector("</color>", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 654f, 506f, 1633f));
			Graphics.Blit(KBNKJKBDCLN, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
			this.JBBAHGKAIFF.SetVector("OfficeSittingHandRestFingerTap", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, GLJOIOBPAEP * this.OFJHPNCEPHN, 231f, 1282f));
			Graphics.Blit(LJGGOANMJAJ, KBNKJKBDCLN, this.JBBAHGKAIFF, AGNBHDBHKCJ);
			this.JBBAHGKAIFF.SetVector("PaperTurn.wav", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, -GLJOIOBPAEP * this.OFJHPNCEPHN, 82f, 732f));
			Graphics.Blit(KBNKJKBDCLN, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
		}

		// Token: 0x0600B6A2 RID: 46754 RVA: 0x00511F10 File Offset: 0x00510110
		private void DKDINEMFCJB(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.HOEHDBIHELI.SetVector("How your lives count is stored in memory when obscured:\n", new Vector4(1430f / (1199f * (float)LJGGOANMJAJ.width), 1276f / (456f * (float)LJGGOANMJAJ.height), 1234f, 62f));
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.HOEHDBIHELI, DepthOfFieldDeprecated.AKEBHPEEABH);
		}

		// Token: 0x0600B6A3 RID: 46755 RVA: 0x00511F74 File Offset: 0x00510174
		private void EGMKNHDOOED(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.HOEHDBIHELI.SetVector("", new Vector4(696f / (413f * (float)LJGGOANMJAJ.width), 685f / (968f * (float)LJGGOANMJAJ.height), 720f, 1486f));
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.HOEHDBIHELI, DepthOfFieldDeprecated.AKEBHPEEABH);
		}

		// Token: 0x0600B6A4 RID: 46756 RVA: 0x00511FD8 File Offset: 0x005101D8
		private void ANNEMHGIHAI(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.HOEHDBIHELI.SetVector("_InvRenderTargetSize", new Vector4(1f / (1f * (float)LJGGOANMJAJ.width), 1f / (1f * (float)LJGGOANMJAJ.height), 0f, 0f));
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.HOEHDBIHELI, DepthOfFieldDeprecated.AKEBHPEEABH);
		}

		// Token: 0x0600B6A5 RID: 46757 RVA: 0x0051203C File Offset: 0x0051023C
		private void NIGEOOCOIKI()
		{
			this.JBBAHGKAIFF = base.BAPJBHPEDIF(this.dofBlurShader, this.JBBAHGKAIFF);
			this.HOEHDBIHELI = base.BAPJBHPEDIF(this.dofShader, this.HOEHDBIHELI);
			this.bokehSupport = this.bokehShader.isSupported;
			if (this.bokeh && this.bokehSupport && this.bokehShader)
			{
				this.JNFMKGDGJEA = base.JBHLGBPJFEL(this.bokehShader, this.JNFMKGDGJEA);
			}
		}

		// Token: 0x0600B6A6 RID: 46758 RVA: 0x005120C0 File Offset: 0x005102C0
		private float PFDCPKFHPMI(float DFCBOEMAOIJ)
		{
			return this.OMIJMALCLAG.WorldToViewportPoint((DFCBOEMAOIJ - this.OMIJMALCLAG.nearClipPlane) * this.OMIJMALCLAG.transform.forward + this.OMIJMALCLAG.transform.position).z / (this.OMIJMALCLAG.farClipPlane - this.OMIJMALCLAG.nearClipPlane);
		}

		// Token: 0x0600B6A7 RID: 46759 RVA: 0x0051212C File Offset: 0x0051032C
		private int IADKNAAKOLM(int MAFGPALKEJE)
		{
			int num = MAFGPALKEJE;
			if (this.resolution == (DepthOfFieldDeprecated.EDNECHKAFDC)7)
			{
				num *= 3;
			}
			if (this.resolution == DepthOfFieldDeprecated.EDNECHKAFDC.Low)
			{
				num *= 0;
			}
			return num;
		}

		// Token: 0x0600B6A8 RID: 46760 RVA: 0x00512158 File Offset: 0x00510358
		private void PHDGHMAKPEF(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ, int AGNBHDBHKCJ, float GLJOIOBPAEP, RenderTexture KBNKJKBDCLN)
		{
			this.JBBAHGKAIFF.SetVector("offsets", new Vector4(0f, GLJOIOBPAEP * this.OFJHPNCEPHN, 0f, 0f));
			Graphics.Blit(GMNLJGNOKPD, KBNKJKBDCLN, this.JBBAHGKAIFF, AGNBHDBHKCJ);
			this.JBBAHGKAIFF.SetVector("offsets", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 0f, 0f, 0f));
			Graphics.Blit(KBNKJKBDCLN, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
			this.JBBAHGKAIFF.SetVector("offsets", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, GLJOIOBPAEP * this.OFJHPNCEPHN, 0f, 0f));
			Graphics.Blit(LJGGOANMJAJ, KBNKJKBDCLN, this.JBBAHGKAIFF, AGNBHDBHKCJ);
			this.JBBAHGKAIFF.SetVector("offsets", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, -GLJOIOBPAEP * this.OFJHPNCEPHN, 0f, 0f));
			Graphics.Blit(KBNKJKBDCLN, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
		}

		// Token: 0x0600B6A9 RID: 46761 RVA: 0x00512274 File Offset: 0x00510474
		private void HKLGOJKPELF()
		{
			this.JBBAHGKAIFF = base.IIIIADNBONI(this.dofBlurShader, this.JBBAHGKAIFF);
			this.HOEHDBIHELI = base.IIIIADNBONI(this.dofShader, this.HOEHDBIHELI);
			this.bokehSupport = this.bokehShader.isSupported;
			if (this.bokeh && this.bokehSupport && this.bokehShader)
			{
				this.JNFMKGDGJEA = base.IIIIADNBONI(this.bokehShader, this.JNFMKGDGJEA);
			}
		}

		// Token: 0x0600B6AA RID: 46762 RVA: 0x005122F8 File Offset: 0x005104F8
		private void KONOOFFNHCD(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ, DepthOfFieldDeprecated.BMEMFJFOHOJ DPBMPHJBLBO, int AGNBHDBHKCJ, float GLJOIOBPAEP)
		{
			this.JBBAHGKAIFF.SetTexture("\n<color='#{0}'>{1}</color> ", GMNLJGNOKPD);
			RenderTexture temporary = RenderTexture.GetTemporary(LJGGOANMJAJ.width, LJGGOANMJAJ.height);
			if (DPBMPHJBLBO > DepthOfFieldDeprecated.BMEMFJFOHOJ.Low)
			{
				this.LPPHBNBILAP(GMNLJGNOKPD, LJGGOANMJAJ, AGNBHDBHKCJ, GLJOIOBPAEP, temporary);
				if (DPBMPHJBLBO > (DepthOfFieldDeprecated.BMEMFJFOHOJ)6)
				{
					this.JBBAHGKAIFF.SetVector("\n", new Vector4(681f, GLJOIOBPAEP * this.OFJHPNCEPHN, 1856f, 433f));
					Graphics.Blit(LJGGOANMJAJ, temporary, this.JBBAHGKAIFF, AGNBHDBHKCJ);
					this.JBBAHGKAIFF.SetVector("WeaponFire", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 957f, 95f, 71f));
					Graphics.Blit(temporary, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
				}
			}
			else
			{
				this.JBBAHGKAIFF.SetVector("SecondaryCausticsProjector", new Vector4(1382f, GLJOIOBPAEP * this.OFJHPNCEPHN, 490f, 1849f));
				Graphics.Blit(GMNLJGNOKPD, temporary, this.JBBAHGKAIFF, AGNBHDBHKCJ);
				this.JBBAHGKAIFF.SetVector("_TintColor", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 686f, 1013f, 615f));
				Graphics.Blit(temporary, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600B6AC RID: 46764 RVA: 0x00512538 File Offset: 0x00510738
		private void JFLPFJFNHID()
		{
			this.JBBAHGKAIFF = base.BAPJBHPEDIF(this.dofBlurShader, this.JBBAHGKAIFF);
			this.HOEHDBIHELI = base.DJFOEIJIMJB(this.dofShader, this.HOEHDBIHELI);
			this.bokehSupport = this.bokehShader.isSupported;
			if (this.bokeh && this.bokehSupport && this.bokehShader)
			{
				this.JNFMKGDGJEA = base.OOAOHFFDMJP(this.bokehShader, this.JNFMKGDGJEA);
			}
		}

		// Token: 0x0600B6AD RID: 46765 RVA: 0x005125BC File Offset: 0x005107BC
		private int AKBJEBOOKKE()
		{
			int result = 0;
			if (this.resolution == DepthOfFieldDeprecated.EDNECHKAFDC.High)
			{
				result = 8;
			}
			else if (this.resolution == (DepthOfFieldDeprecated.EDNECHKAFDC)7)
			{
				result = 3;
			}
			return result;
		}

		// Token: 0x0600B6AE RID: 46766 RVA: 0x005125E4 File Offset: 0x005107E4
		private void BJKIFILNOHB(bool OHDMEDCBPAA, RenderTexture JONJODLFAEN, int JODELFPOKMJ, int BCGMAMHHLFF)
		{
			this.DPJPOEMKIPJ = null;
			if (OHDMEDCBPAA)
			{
				this.DPJPOEMKIPJ = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0);
			}
			this.AMJHOJBNFOM = RenderTexture.GetTemporary(JONJODLFAEN.width / JODELFPOKMJ, JONJODLFAEN.height / JODELFPOKMJ, 0);
			this.NPAPJCDHNJH = RenderTexture.GetTemporary(JONJODLFAEN.width / JODELFPOKMJ, JONJODLFAEN.height / JODELFPOKMJ, 1);
			this.PMOOKOALAEN = RenderTexture.GetTemporary(JONJODLFAEN.width / BCGMAMHHLFF, JONJODLFAEN.height / BCGMAMHHLFF, 1);
			this.MNNMCBKBBKL = null;
			this.EEKFJNKCLFF = null;
			if (this.bokeh)
			{
				this.MNNMCBKBBKL = RenderTexture.GetTemporary(JONJODLFAEN.width / (BCGMAMHHLFF * this.bokehDownsample), JONJODLFAEN.height / (BCGMAMHHLFF * this.bokehDownsample), 0, RenderTextureFormat.ARGBHalf);
				this.EEKFJNKCLFF = RenderTexture.GetTemporary(JONJODLFAEN.width / (BCGMAMHHLFF * this.bokehDownsample), JONJODLFAEN.height / (BCGMAMHHLFF * this.bokehDownsample), 0, RenderTextureFormat.ARGB1555);
				this.MNNMCBKBBKL.filterMode = FilterMode.Point;
				this.EEKFJNKCLFF.filterMode = FilterMode.Bilinear;
				RenderTexture.active = this.EEKFJNKCLFF;
				GL.Clear(false, true, new Color(1268f, 1697f, 104f, 65f));
			}
			JONJODLFAEN.filterMode = FilterMode.Point;
			this.NPAPJCDHNJH.filterMode = FilterMode.Bilinear;
			this.AMJHOJBNFOM.filterMode = FilterMode.Point;
			this.PMOOKOALAEN.filterMode = FilterMode.Point;
			if (this.DPJPOEMKIPJ)
			{
				this.DPJPOEMKIPJ.filterMode = FilterMode.Point;
			}
		}

		// Token: 0x0600B6AF RID: 46767 RVA: 0x00512764 File Offset: 0x00510964
		private void LKCMKEHCLJA(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ, DepthOfFieldDeprecated.BMEMFJFOHOJ DPBMPHJBLBO, int AGNBHDBHKCJ, float GLJOIOBPAEP)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(LJGGOANMJAJ.width, LJGGOANMJAJ.height);
			if (DPBMPHJBLBO > DepthOfFieldDeprecated.BMEMFJFOHOJ.Low)
			{
				this.GHFIMGGBFOG(GMNLJGNOKPD, LJGGOANMJAJ, AGNBHDBHKCJ, GLJOIOBPAEP, temporary);
				if (DPBMPHJBLBO > (DepthOfFieldDeprecated.BMEMFJFOHOJ)3)
				{
					this.JBBAHGKAIFF.SetVector("fshop_hd4", new Vector4(1016f, GLJOIOBPAEP * this.OFJHPNCEPHN, 160f, 1217f));
					Graphics.Blit(LJGGOANMJAJ, temporary, this.JBBAHGKAIFF, AGNBHDBHKCJ);
					this.JBBAHGKAIFF.SetVector("******* Actor fish destroy", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 109f, 1366f, 448f));
					Graphics.Blit(temporary, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
				}
			}
			else
			{
				this.JBBAHGKAIFF.SetVector("_NoiseTex", new Vector4(1211f, GLJOIOBPAEP * this.OFJHPNCEPHN, 129f, 377f));
				Graphics.Blit(GMNLJGNOKPD, temporary, this.JBBAHGKAIFF, AGNBHDBHKCJ);
				this.JBBAHGKAIFF.SetVector("IdleFly", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 81f, 1250f, 868f));
				Graphics.Blit(temporary, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600B6B0 RID: 46768 RVA: 0x005128A4 File Offset: 0x00510AA4
		private void CBOBDAPLEFC()
		{
			if (this.DPJPOEMKIPJ)
			{
				RenderTexture.ReleaseTemporary(this.DPJPOEMKIPJ);
			}
			if (this.NPAPJCDHNJH)
			{
				RenderTexture.ReleaseTemporary(this.NPAPJCDHNJH);
			}
			if (this.AMJHOJBNFOM)
			{
				RenderTexture.ReleaseTemporary(this.AMJHOJBNFOM);
			}
			if (this.PMOOKOALAEN)
			{
				RenderTexture.ReleaseTemporary(this.PMOOKOALAEN);
			}
			if (this.MNNMCBKBBKL)
			{
				RenderTexture.ReleaseTemporary(this.MNNMCBKBBKL);
			}
			if (this.EEKFJNKCLFF)
			{
				RenderTexture.ReleaseTemporary(this.EEKFJNKCLFF);
			}
		}

		// Token: 0x0600B6B1 RID: 46769 RVA: 0x00512941 File Offset: 0x00510B41
		private void PEPOOEGHCMC()
		{
			LBMNBHPBAPJ.EEILMFFBOGK();
		}

		// Token: 0x0600B6B2 RID: 46770 RVA: 0x00512948 File Offset: 0x00510B48
		private float PBEHPFICPMP(float DFCBOEMAOIJ)
		{
			return this.OMIJMALCLAG.WorldToViewportPoint((DFCBOEMAOIJ - this.OMIJMALCLAG.nearClipPlane) * this.OMIJMALCLAG.transform.forward + this.OMIJMALCLAG.transform.position).z / (this.OMIJMALCLAG.farClipPlane - this.OMIJMALCLAG.nearClipPlane);
		}

		// Token: 0x0600B6B3 RID: 46771 RVA: 0x005129B4 File Offset: 0x00510BB4
		private void PDLLLDPHHFF(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ, DepthOfFieldDeprecated.BMEMFJFOHOJ DPBMPHJBLBO, int AGNBHDBHKCJ, float GLJOIOBPAEP)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(LJGGOANMJAJ.width, LJGGOANMJAJ.height);
			if (DPBMPHJBLBO > (DepthOfFieldDeprecated.BMEMFJFOHOJ)0)
			{
				this.LCLPLBMOCGB(GMNLJGNOKPD, LJGGOANMJAJ, AGNBHDBHKCJ, GLJOIOBPAEP, temporary);
				if (DPBMPHJBLBO > DepthOfFieldDeprecated.BMEMFJFOHOJ.High)
				{
					this.JBBAHGKAIFF.SetVector("SecondaryCausticsProjector", new Vector4(1956f, GLJOIOBPAEP * this.OFJHPNCEPHN, 723f, 446f));
					Graphics.Blit(LJGGOANMJAJ, temporary, this.JBBAHGKAIFF, AGNBHDBHKCJ);
					this.JBBAHGKAIFF.SetVector("Refractive", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 499f, 996f, 153f));
					Graphics.Blit(temporary, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
				}
			}
			else
			{
				this.JBBAHGKAIFF.SetVector("box", new Vector4(551f, GLJOIOBPAEP * this.OFJHPNCEPHN, 1557f, 246f));
				Graphics.Blit(GMNLJGNOKPD, temporary, this.JBBAHGKAIFF, AGNBHDBHKCJ);
				this.JBBAHGKAIFF.SetVector("_MaxSteps", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 1135f, 321f, 325f));
				Graphics.Blit(temporary, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600B6B4 RID: 46772 RVA: 0x00512AF4 File Offset: 0x00510CF4
		private int LGDOEGKLAHD()
		{
			int result = 1;
			if (this.resolution == DepthOfFieldDeprecated.EDNECHKAFDC.Low)
			{
				result = 3;
			}
			else if (this.resolution == (DepthOfFieldDeprecated.EDNECHKAFDC)1)
			{
				result = 1;
			}
			return result;
		}

		// Token: 0x0600B6B5 RID: 46773 RVA: 0x00512B1C File Offset: 0x00510D1C
		private void LEICKKKLDAD(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NHEEDPALBFN())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.smoothness < 487f)
			{
				this.smoothness = 1233f;
			}
			this.bokeh = (this.bokeh && this.bokehSupport);
			float num = this.bokeh ? DepthOfFieldDeprecated.IHIEFLOIANN : 1006f;
			bool flag = this.quality > (DepthOfFieldDeprecated.NBLDEAGICCP)0;
			float num2 = this.focalSize / (this.OMIJMALCLAG.farClipPlane - this.OMIJMALCLAG.nearClipPlane);
			if (this.simpleTweakMode)
			{
				this.MHJDKBOLOBD = (this.objectFocus ? (this.OMIJMALCLAG.WorldToViewportPoint(this.objectFocus.position).z / this.OMIJMALCLAG.farClipPlane) : this.PFDCPKFHPMI(this.focalPoint));
				this.DINBPHKCLEB = this.MHJDKBOLOBD * this.smoothness;
				this.PKANLIIHMBF = this.DINBPHKCLEB;
				flag = (flag && this.focalPoint > this.OMIJMALCLAG.nearClipPlane + Mathf.Epsilon);
			}
			else
			{
				if (this.objectFocus)
				{
					Vector3 vector = this.OMIJMALCLAG.WorldToViewportPoint(this.objectFocus.position);
					vector.z /= this.OMIJMALCLAG.farClipPlane;
					this.MHJDKBOLOBD = vector.z;
				}
				else
				{
					this.MHJDKBOLOBD = this.BKJEENDCMCJ(this.focalZDistance);
				}
				this.DINBPHKCLEB = this.focalZStartCurve;
				this.PKANLIIHMBF = this.focalZEndCurve;
				flag = (!flag || this.focalPoint > this.OMIJMALCLAG.nearClipPlane + Mathf.Epsilon);
			}
			this.KDJDAGBLCMA = 1240f * (float)JONJODLFAEN.width / (1548f * (float)JONJODLFAEN.height);
			this.OFJHPNCEPHN = 315f;
			this.HOEHDBIHELI.SetFloat("X (R)", this.foregroundBlurExtrude);
			this.HOEHDBIHELI.SetVector("", new Vector4(this.simpleTweakMode ? (201f / this.DINBPHKCLEB) : this.DINBPHKCLEB, this.simpleTweakMode ? (1212f / this.PKANLIIHMBF) : this.PKANLIIHMBF, num2 * 1486f, this.MHJDKBOLOBD));
			this.HOEHDBIHELI.SetVector("KatanaReadyHigh", new Vector4(833f / (245f * (float)JONJODLFAEN.width), 1722f / (525f * (float)JONJODLFAEN.height), 515f, 806f));
			int num3 = this.FFBBEANNHCG();
			int bcgmamhhlff = this.EGDAGLGJLPJ(num3);
			this.LGPHHALMHNL(flag, JONJODLFAEN, num3, bcgmamhhlff);
			Graphics.Blit(JONJODLFAEN, JONJODLFAEN, this.HOEHDBIHELI, 5);
			this.NKLPIOFKHEI(JONJODLFAEN, this.AMJHOJBNFOM);
			this.PDLLLDPHHFF(this.AMJHOJBNFOM, this.AMJHOJBNFOM, (DepthOfFieldDeprecated.BMEMFJFOHOJ)0, 4, this.maxBlurSpread);
			if (this.bokeh && (DepthOfFieldDeprecated.JKENGKAOIOD.Foreground & this.bokehDestination) != (DepthOfFieldDeprecated.JKENGKAOIOD)0)
			{
				this.HOEHDBIHELI.SetVector("_ClutTex", new Vector4(this.bokehThresholdContrast, this.bokehThresholdLuminance, 1148f, 1843f));
				Graphics.Blit(this.AMJHOJBNFOM, this.EEKFJNKCLFF, this.HOEHDBIHELI, -3);
				Graphics.Blit(this.AMJHOJBNFOM, this.PMOOKOALAEN);
				this.PDLLLDPHHFF(this.PMOOKOALAEN, this.PMOOKOALAEN, this.bluriness, 1, this.maxBlurSpread * num);
			}
			else
			{
				this.MAPKKKAPIFE(this.AMJHOJBNFOM, this.PMOOKOALAEN);
				this.NENJELKIBAK(this.PMOOKOALAEN, this.PMOOKOALAEN, this.bluriness, 0, this.maxBlurSpread);
			}
			this.JBBAHGKAIFF.SetTexture("BC ", this.PMOOKOALAEN);
			this.JBBAHGKAIFF.SetTexture("1HandSwordShieldBash", this.AMJHOJBNFOM);
			Graphics.Blit(null, this.NPAPJCDHNJH, this.JBBAHGKAIFF, 3);
			if (this.bokeh && (DepthOfFieldDeprecated.JKENGKAOIOD.Background & this.bokehDestination) != (DepthOfFieldDeprecated.JKENGKAOIOD)0)
			{
				this.BPHAMHCAFKO(this.EEKFJNKCLFF, this.MNNMCBKBBKL, this.NPAPJCDHNJH);
			}
			this.HOEHDBIHELI.SetTexture("click Cancel", this.NPAPJCDHNJH);
			this.HOEHDBIHELI.SetTexture("#a0a0a0", this.AMJHOJBNFOM);
			Graphics.Blit(JONJODLFAEN, flag ? this.DPJPOEMKIPJ : OKIIDHIJBEA, this.HOEHDBIHELI, this.visualize ? 4 : 1);
			if (flag)
			{
				Graphics.Blit(this.DPJPOEMKIPJ, JONJODLFAEN, this.HOEHDBIHELI, 2);
				this.CDHKNJMEGMN(JONJODLFAEN, this.AMJHOJBNFOM);
				this.INHFFJPOLCE(this.AMJHOJBNFOM, this.AMJHOJBNFOM, DepthOfFieldDeprecated.BMEMFJFOHOJ.Low, 0, this.maxBlurSpread);
				if (this.bokeh && ((DepthOfFieldDeprecated.JKENGKAOIOD)4 & this.bokehDestination) != (DepthOfFieldDeprecated.JKENGKAOIOD)0)
				{
					this.HOEHDBIHELI.SetVector("fshop_btn1", new Vector4(this.bokehThresholdContrast * 605f, this.bokehThresholdLuminance, 1319f, 415f));
					Graphics.Blit(this.AMJHOJBNFOM, this.EEKFJNKCLFF, this.HOEHDBIHELI, -102);
					Graphics.Blit(this.AMJHOJBNFOM, this.PMOOKOALAEN);
					this.ICGFCHGLIGB(this.PMOOKOALAEN, this.PMOOKOALAEN, this.bluriness, 0, this.maxBlurSpread * num);
				}
				else
				{
					this.INHFFJPOLCE(this.AMJHOJBNFOM, this.PMOOKOALAEN, this.bluriness, 0, this.maxBlurSpread);
				}
				Graphics.Blit(this.PMOOKOALAEN, this.NPAPJCDHNJH);
				this.HOEHDBIHELI.SetTexture("wpn_dress2", this.NPAPJCDHNJH);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HOEHDBIHELI, this.visualize ? 0 : 5);
				if (this.bokeh && (DepthOfFieldDeprecated.JKENGKAOIOD.Background & this.bokehDestination) != (DepthOfFieldDeprecated.JKENGKAOIOD)0)
				{
					this.FLFEOHPMPLF(this.EEKFJNKCLFF, this.MNNMCBKBBKL, OKIIDHIJBEA);
				}
			}
			this.OBDADAIIPCB();
		}

		// Token: 0x0600B6B6 RID: 46774 RVA: 0x005130DC File Offset: 0x005112DC
		private void DOLGADOKOPK(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ, int AGNBHDBHKCJ, float GLJOIOBPAEP, RenderTexture KBNKJKBDCLN)
		{
			this.JBBAHGKAIFF.SetVector("_Offsets", new Vector4(964f, GLJOIOBPAEP * this.OFJHPNCEPHN, 1738f, 210f));
			Graphics.Blit(GMNLJGNOKPD, KBNKJKBDCLN, this.JBBAHGKAIFF, AGNBHDBHKCJ);
			this.JBBAHGKAIFF.SetVector("", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 835f, 533f, 1352f));
			Graphics.Blit(KBNKJKBDCLN, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
			this.JBBAHGKAIFF.SetVector("float: ", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, GLJOIOBPAEP * this.OFJHPNCEPHN, 1836f, 3f));
			Graphics.Blit(LJGGOANMJAJ, KBNKJKBDCLN, this.JBBAHGKAIFF, AGNBHDBHKCJ);
			this.JBBAHGKAIFF.SetVector("_Threshhold", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, -GLJOIOBPAEP * this.OFJHPNCEPHN, 248f, 1747f));
			Graphics.Blit(KBNKJKBDCLN, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
		}

		// Token: 0x0600B6B7 RID: 46775 RVA: 0x005131F8 File Offset: 0x005113F8
		private void INHFFJPOLCE(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ, DepthOfFieldDeprecated.BMEMFJFOHOJ DPBMPHJBLBO, int AGNBHDBHKCJ, float GLJOIOBPAEP)
		{
			this.JBBAHGKAIFF.SetTexture("id", GMNLJGNOKPD);
			RenderTexture temporary = RenderTexture.GetTemporary(LJGGOANMJAJ.width, LJGGOANMJAJ.height);
			if (DPBMPHJBLBO > DepthOfFieldDeprecated.BMEMFJFOHOJ.Low)
			{
				this.LCMGBONCKHA(GMNLJGNOKPD, LJGGOANMJAJ, AGNBHDBHKCJ, GLJOIOBPAEP, temporary);
				if (DPBMPHJBLBO > (DepthOfFieldDeprecated.BMEMFJFOHOJ)0)
				{
					this.JBBAHGKAIFF.SetVector("craft_data/categories/category", new Vector4(992f, GLJOIOBPAEP * this.OFJHPNCEPHN, 769f, 1494f));
					Graphics.Blit(LJGGOANMJAJ, temporary, this.JBBAHGKAIFF, AGNBHDBHKCJ);
					this.JBBAHGKAIFF.SetVector("Mouse ScrollWheel", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 1717f, 1536f, 1484f));
					Graphics.Blit(temporary, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
				}
			}
			else
			{
				this.JBBAHGKAIFF.SetVector("rewgt_msg", new Vector4(242f, GLJOIOBPAEP * this.OFJHPNCEPHN, 1583f, 132f));
				Graphics.Blit(GMNLJGNOKPD, temporary, this.JBBAHGKAIFF, AGNBHDBHKCJ);
				this.JBBAHGKAIFF.SetVector("-?-", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 1850f, 1160f, 1503f));
				Graphics.Blit(temporary, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600B6B8 RID: 46776 RVA: 0x0051334C File Offset: 0x0051154C
		private int PBBKHGIONLO()
		{
			int result = 0;
			if (this.resolution == DepthOfFieldDeprecated.EDNECHKAFDC.Low)
			{
				result = 5;
			}
			else if (this.resolution == (DepthOfFieldDeprecated.EDNECHKAFDC)5)
			{
				result = 7;
			}
			return result;
		}

		// Token: 0x0600B6B9 RID: 46777 RVA: 0x00513374 File Offset: 0x00511574
		private void BBHBPFNGPHB(RenderTexture EEECFBAIFAN, RenderTexture MMNMAEGCJBB, RenderTexture AEMBFNBJDAC)
		{
			if (this.JNFMKGDGJEA)
			{
				Mesh[] array = LBMNBHPBAPJ.DHPCGOPOGPL(MMNMAEGCJBB.width, MMNMAEGCJBB.height);
				RenderTexture.active = MMNMAEGCJBB;
				GL.Clear(false, true, new Color(0f, 0f, 0f, 0f));
				GL.PushMatrix();
				GL.LoadIdentity();
				EEECFBAIFAN.filterMode = FilterMode.Point;
				float num = (float)EEECFBAIFAN.width * 1f / ((float)EEECFBAIFAN.height * 1f);
				float num2 = 2f / (1f * (float)EEECFBAIFAN.width);
				num2 += this.bokehScale * this.maxBlurSpread * DepthOfFieldDeprecated.IHIEFLOIANN * this.OFJHPNCEPHN;
				this.JNFMKGDGJEA.SetTexture("_Source", EEECFBAIFAN);
				this.JNFMKGDGJEA.SetTexture("_MainTex", this.bokehTexture);
				this.JNFMKGDGJEA.SetVector("_ArScale", new Vector4(num2, num2 * num, 0.5f, 0.5f * num));
				this.JNFMKGDGJEA.SetFloat("_Intensity", this.bokehIntensity);
				this.JNFMKGDGJEA.SetPass(0);
				foreach (Mesh mesh in array)
				{
					if (mesh)
					{
						Graphics.DrawMeshNow(mesh, Matrix4x4.identity);
					}
				}
				GL.PopMatrix();
				Graphics.Blit(MMNMAEGCJBB, AEMBFNBJDAC, this.HOEHDBIHELI, 8);
				EEECFBAIFAN.filterMode = FilterMode.Bilinear;
			}
		}

		// Token: 0x0600B6BA RID: 46778 RVA: 0x005134D8 File Offset: 0x005116D8
		private void HLBBJFBOBCJ(bool OHDMEDCBPAA, RenderTexture JONJODLFAEN, int JODELFPOKMJ, int BCGMAMHHLFF)
		{
			this.DPJPOEMKIPJ = null;
			if (OHDMEDCBPAA)
			{
				this.DPJPOEMKIPJ = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 1);
			}
			this.AMJHOJBNFOM = RenderTexture.GetTemporary(JONJODLFAEN.width / JODELFPOKMJ, JONJODLFAEN.height / JODELFPOKMJ, 1);
			this.NPAPJCDHNJH = RenderTexture.GetTemporary(JONJODLFAEN.width / JODELFPOKMJ, JONJODLFAEN.height / JODELFPOKMJ, 0);
			this.PMOOKOALAEN = RenderTexture.GetTemporary(JONJODLFAEN.width / BCGMAMHHLFF, JONJODLFAEN.height / BCGMAMHHLFF, 0);
			this.MNNMCBKBBKL = null;
			this.EEKFJNKCLFF = null;
			if (this.bokeh)
			{
				this.MNNMCBKBBKL = RenderTexture.GetTemporary(JONJODLFAEN.width / (BCGMAMHHLFF * this.bokehDownsample), JONJODLFAEN.height / (BCGMAMHHLFF * this.bokehDownsample), 0, RenderTextureFormat.RGB565);
				this.EEKFJNKCLFF = RenderTexture.GetTemporary(JONJODLFAEN.width / (BCGMAMHHLFF * this.bokehDownsample), JONJODLFAEN.height / (BCGMAMHHLFF * this.bokehDownsample), 1, RenderTextureFormat.RGB565);
				this.MNNMCBKBBKL.filterMode = FilterMode.Bilinear;
				this.EEKFJNKCLFF.filterMode = FilterMode.Point;
				RenderTexture.active = this.EEKFJNKCLFF;
				GL.Clear(true, true, new Color(1637f, 980f, 1979f, 1733f));
			}
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			this.NPAPJCDHNJH.filterMode = FilterMode.Bilinear;
			this.AMJHOJBNFOM.filterMode = FilterMode.Point;
			this.PMOOKOALAEN.filterMode = FilterMode.Bilinear;
			if (this.DPJPOEMKIPJ)
			{
				this.DPJPOEMKIPJ.filterMode = FilterMode.Bilinear;
			}
		}

		// Token: 0x0600B6BB RID: 46779 RVA: 0x00513657 File Offset: 0x00511857
		private void OLHGBCBHDBF()
		{
			this.OMIJMALCLAG = base.GetComponent<Camera>();
			this.OMIJMALCLAG.depthTextureMode |= DepthTextureMode.None;
		}

		// Token: 0x0600B6BC RID: 46780 RVA: 0x00513678 File Offset: 0x00511878
		private void BPHAMHCAFKO(RenderTexture EEECFBAIFAN, RenderTexture MMNMAEGCJBB, RenderTexture AEMBFNBJDAC)
		{
			if (this.JNFMKGDGJEA)
			{
				Mesh[] array = LBMNBHPBAPJ.KIOOKLNIIAN(MMNMAEGCJBB.width, MMNMAEGCJBB.height);
				RenderTexture.active = MMNMAEGCJBB;
				GL.Clear(true, false, new Color(733f, 292f, 281f, 92f));
				GL.PushMatrix();
				GL.LoadIdentity();
				EEECFBAIFAN.filterMode = FilterMode.Bilinear;
				float num = (float)EEECFBAIFAN.width * 883f / ((float)EEECFBAIFAN.height * 306f);
				float num2 = 1554f / (210f * (float)EEECFBAIFAN.width);
				num2 += this.bokehScale * this.maxBlurSpread * DepthOfFieldDeprecated.IHIEFLOIANN * this.OFJHPNCEPHN;
				this.JNFMKGDGJEA.SetTexture("Try to change this Vector3 in memory:\n", EEECFBAIFAN);
				this.JNFMKGDGJEA.SetTexture("Scuba OK", this.bokehTexture);
				this.JNFMKGDGJEA.SetVector("money", new Vector4(num2, num2 * num, 383f, 321f * num));
				this.JNFMKGDGJEA.SetFloat("ClimbUp", this.bokehIntensity);
				this.JNFMKGDGJEA.SetPass(1);
				Mesh[] array2 = array;
				for (int i = 1; i < array2.Length; i += 0)
				{
					Mesh mesh = array2[i];
					if (mesh)
					{
						Graphics.DrawMeshNow(mesh, Matrix4x4.identity);
					}
				}
				GL.PopMatrix();
				Graphics.Blit(MMNMAEGCJBB, AEMBFNBJDAC, this.HOEHDBIHELI, 1);
				EEECFBAIFAN.filterMode = FilterMode.Bilinear;
			}
		}

		// Token: 0x0600B6BD RID: 46781 RVA: 0x005137DC File Offset: 0x005119DC
		private void FKIJGMFIKNM(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ, DepthOfFieldDeprecated.BMEMFJFOHOJ DPBMPHJBLBO, int AGNBHDBHKCJ, float GLJOIOBPAEP)
		{
			this.JBBAHGKAIFF.SetTexture("OfficeSittingLegCross", GMNLJGNOKPD);
			RenderTexture temporary = RenderTexture.GetTemporary(LJGGOANMJAJ.width, LJGGOANMJAJ.height);
			if (DPBMPHJBLBO > DepthOfFieldDeprecated.BMEMFJFOHOJ.Low)
			{
				this.PHDGHMAKPEF(GMNLJGNOKPD, LJGGOANMJAJ, AGNBHDBHKCJ, GLJOIOBPAEP, temporary);
				if (DPBMPHJBLBO > (DepthOfFieldDeprecated.BMEMFJFOHOJ)5)
				{
					this.JBBAHGKAIFF.SetVector("knopje.wav", new Vector4(1417f, GLJOIOBPAEP * this.OFJHPNCEPHN, 836f, 812f));
					Graphics.Blit(LJGGOANMJAJ, temporary, this.JBBAHGKAIFF, AGNBHDBHKCJ);
					this.JBBAHGKAIFF.SetVector("body", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 183f, 120f, 1058f));
					Graphics.Blit(temporary, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
				}
			}
			else
			{
				this.JBBAHGKAIFF.SetVector("WorkerHammer2", new Vector4(1180f, GLJOIOBPAEP * this.OFJHPNCEPHN, 1106f, 1394f));
				Graphics.Blit(GMNLJGNOKPD, temporary, this.JBBAHGKAIFF, AGNBHDBHKCJ);
				this.JBBAHGKAIFF.SetVector("IceHockeyIdle", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 585f, 434f, 1448f));
				Graphics.Blit(temporary, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600B6BE RID: 46782 RVA: 0x00513930 File Offset: 0x00511B30
		private void FLFEOHPMPLF(RenderTexture EEECFBAIFAN, RenderTexture MMNMAEGCJBB, RenderTexture AEMBFNBJDAC)
		{
			if (this.JNFMKGDGJEA)
			{
				Mesh[] array = LBMNBHPBAPJ.ODKEKMPIPLK(MMNMAEGCJBB.width, MMNMAEGCJBB.height);
				RenderTexture.active = MMNMAEGCJBB;
				GL.Clear(true, true, new Color(1154f, 1630f, 689f, 1386f));
				GL.PushMatrix();
				GL.LoadIdentity();
				EEECFBAIFAN.filterMode = FilterMode.Bilinear;
				float num = (float)EEECFBAIFAN.width * 1468f / ((float)EEECFBAIFAN.height * 945f);
				float num2 = 540f / (1483f * (float)EEECFBAIFAN.width);
				num2 += this.bokehScale * this.maxBlurSpread * DepthOfFieldDeprecated.IHIEFLOIANN * this.OFJHPNCEPHN;
				this.JNFMKGDGJEA.SetTexture("RunBackLeft", EEECFBAIFAN);
				this.JNFMKGDGJEA.SetTexture("GiantGrabIdle", this.bokehTexture);
				this.JNFMKGDGJEA.SetVector("<color='#80ff00'>+ </color>", new Vector4(num2, num2 * num, 1137f, 1930f * num));
				this.JNFMKGDGJEA.SetFloat("[ACTk] Are you trying to read regular PlayerPrefs data using ObscuredPrefs (key = ", this.bokehIntensity);
				this.JNFMKGDGJEA.SetPass(1);
				Mesh[] array2 = array;
				for (int i = 0; i < array2.Length; i += 0)
				{
					Mesh mesh = array2[i];
					if (mesh)
					{
						Graphics.DrawMeshNow(mesh, Matrix4x4.identity);
					}
				}
				GL.PopMatrix();
				Graphics.Blit(MMNMAEGCJBB, AEMBFNBJDAC, this.HOEHDBIHELI, 5);
				EEECFBAIFAN.filterMode = FilterMode.Point;
			}
		}

		// Token: 0x0600B6BF RID: 46783 RVA: 0x00513A94 File Offset: 0x00511C94
		private void LCLPLBMOCGB(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ, int AGNBHDBHKCJ, float GLJOIOBPAEP, RenderTexture KBNKJKBDCLN)
		{
			this.JBBAHGKAIFF.SetVector("</color>", new Vector4(1939f, GLJOIOBPAEP * this.OFJHPNCEPHN, 1331f, 714f));
			Graphics.Blit(GMNLJGNOKPD, KBNKJKBDCLN, this.JBBAHGKAIFF, AGNBHDBHKCJ);
			this.JBBAHGKAIFF.SetVector("Invalid vertex colors assigned to ", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 504f, 1562f, 1171f));
			Graphics.Blit(KBNKJKBDCLN, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
			this.JBBAHGKAIFF.SetVector(" ", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, GLJOIOBPAEP * this.OFJHPNCEPHN, 1063f, 1030f));
			Graphics.Blit(LJGGOANMJAJ, KBNKJKBDCLN, this.JBBAHGKAIFF, AGNBHDBHKCJ);
			this.JBBAHGKAIFF.SetVector("_LensCoeff", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, -GLJOIOBPAEP * this.OFJHPNCEPHN, 385f, 11f));
			Graphics.Blit(KBNKJKBDCLN, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
		}

		// Token: 0x0600B6C0 RID: 46784 RVA: 0x00513BB0 File Offset: 0x00511DB0
		private int ECEBPBIDDOL()
		{
			int result = 0;
			if (this.resolution == DepthOfFieldDeprecated.EDNECHKAFDC.Medium)
			{
				result = 6;
			}
			else if (this.resolution == (DepthOfFieldDeprecated.EDNECHKAFDC)6)
			{
				result = 1;
			}
			return result;
		}

		// Token: 0x0600B6C1 RID: 46785 RVA: 0x00513BD8 File Offset: 0x00511DD8
		public virtual bool HFFAJAAJELE()
		{
			base.PKDIKFGAJKM(false);
			this.JBBAHGKAIFF = base.ALJPMGLOIEG(this.dofBlurShader, this.JBBAHGKAIFF);
			this.HOEHDBIHELI = base.BAPJBHPEDIF(this.dofShader, this.HOEHDBIHELI);
			this.bokehSupport = this.bokehShader.isSupported;
			if (this.bokeh && this.bokehSupport && this.bokehShader)
			{
				this.JNFMKGDGJEA = base.ALJPMGLOIEG(this.bokehShader, this.JNFMKGDGJEA);
			}
			if (!this.PPGOAMIHMBG)
			{
				base.LNEHBOJIBAI();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B6C2 RID: 46786 RVA: 0x00513C78 File Offset: 0x00511E78
		public virtual bool NHNCPPAMOMD()
		{
			base.CGEGCOKMPHN(true);
			this.JBBAHGKAIFF = base.JBHLGBPJFEL(this.dofBlurShader, this.JBBAHGKAIFF);
			this.HOEHDBIHELI = base.BAPJBHPEDIF(this.dofShader, this.HOEHDBIHELI);
			this.bokehSupport = this.bokehShader.isSupported;
			if (this.bokeh && this.bokehSupport && this.bokehShader)
			{
				this.JNFMKGDGJEA = base.BAPJBHPEDIF(this.bokehShader, this.JNFMKGDGJEA);
			}
			if (!this.PPGOAMIHMBG)
			{
				base.OAEAMDHOKKM();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B6C3 RID: 46787 RVA: 0x00513D18 File Offset: 0x00511F18
		private int LPHFLBOIEBK()
		{
			int result = 0;
			if (this.resolution == DepthOfFieldDeprecated.EDNECHKAFDC.Medium)
			{
				result = 2;
			}
			else if (this.resolution == (DepthOfFieldDeprecated.EDNECHKAFDC)8)
			{
				result = 1;
			}
			return result;
		}

		// Token: 0x0600B6C4 RID: 46788 RVA: 0x00513D40 File Offset: 0x00511F40
		public virtual bool AGMCDGFGINF()
		{
			base.POJDHPJDFEM(false);
			this.JBBAHGKAIFF = base.IIIIADNBONI(this.dofBlurShader, this.JBBAHGKAIFF);
			this.HOEHDBIHELI = base.IIIIADNBONI(this.dofShader, this.HOEHDBIHELI);
			this.bokehSupport = this.bokehShader.isSupported;
			if (this.bokeh && this.bokehSupport && this.bokehShader)
			{
				this.JNFMKGDGJEA = base.ALJPMGLOIEG(this.bokehShader, this.JNFMKGDGJEA);
			}
			if (!this.PPGOAMIHMBG)
			{
				base.NAIBIABADFB();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B6C5 RID: 46789 RVA: 0x00513DE0 File Offset: 0x00511FE0
		private void ICGFCHGLIGB(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ, DepthOfFieldDeprecated.BMEMFJFOHOJ DPBMPHJBLBO, int AGNBHDBHKCJ, float GLJOIOBPAEP)
		{
			this.JBBAHGKAIFF.SetTexture("FlyBackward", GMNLJGNOKPD);
			RenderTexture temporary = RenderTexture.GetTemporary(LJGGOANMJAJ.width, LJGGOANMJAJ.height);
			if (DPBMPHJBLBO > DepthOfFieldDeprecated.BMEMFJFOHOJ.Low)
			{
				this.DOLGADOKOPK(GMNLJGNOKPD, LJGGOANMJAJ, AGNBHDBHKCJ, GLJOIOBPAEP, temporary);
				if (DPBMPHJBLBO > (DepthOfFieldDeprecated.BMEMFJFOHOJ)5)
				{
					this.JBBAHGKAIFF.SetVector("Smoking2", new Vector4(1079f, GLJOIOBPAEP * this.OFJHPNCEPHN, 1234f, 29f));
					Graphics.Blit(LJGGOANMJAJ, temporary, this.JBBAHGKAIFF, AGNBHDBHKCJ);
					this.JBBAHGKAIFF.SetVector("val", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 973f, 1923f, 1856f));
					Graphics.Blit(temporary, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
				}
			}
			else
			{
				this.JBBAHGKAIFF.SetVector("_Convolved_TexelSize", new Vector4(1397f, GLJOIOBPAEP * this.OFJHPNCEPHN, 1517f, 337f));
				Graphics.Blit(GMNLJGNOKPD, temporary, this.JBBAHGKAIFF, AGNBHDBHKCJ);
				this.JBBAHGKAIFF.SetVector("800000", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 1134f, 409f, 1604f));
				Graphics.Blit(temporary, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600B6C6 RID: 46790 RVA: 0x00513F34 File Offset: 0x00512134
		private void GGEIHKBPLGD(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ, int AGNBHDBHKCJ, float GLJOIOBPAEP, RenderTexture KBNKJKBDCLN)
		{
			this.JBBAHGKAIFF.SetVector("Idle Walk", new Vector4(176f, GLJOIOBPAEP * this.OFJHPNCEPHN, 916f, 598f));
			Graphics.Blit(GMNLJGNOKPD, KBNKJKBDCLN, this.JBBAHGKAIFF, AGNBHDBHKCJ);
			this.JBBAHGKAIFF.SetVector("no_money", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 501f, 1264f, 1643f));
			Graphics.Blit(KBNKJKBDCLN, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
			this.JBBAHGKAIFF.SetVector("Please initialize AssetBundleManifest by calling AssetBundleManager.Initialize()", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, GLJOIOBPAEP * this.OFJHPNCEPHN, 1127f, 1131f));
			Graphics.Blit(LJGGOANMJAJ, KBNKJKBDCLN, this.JBBAHGKAIFF, AGNBHDBHKCJ);
			this.JBBAHGKAIFF.SetVector("Yawn", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, -GLJOIOBPAEP * this.OFJHPNCEPHN, 462f, 777f));
			Graphics.Blit(KBNKJKBDCLN, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
		}

		// Token: 0x0600B6C7 RID: 46791 RVA: 0x00514050 File Offset: 0x00512250
		private int PDOFEIGMLMM(int MAFGPALKEJE)
		{
			int num = MAFGPALKEJE;
			if (this.resolution == DepthOfFieldDeprecated.EDNECHKAFDC.High)
			{
				num *= 2;
			}
			if (this.resolution == DepthOfFieldDeprecated.EDNECHKAFDC.Low)
			{
				num *= 2;
			}
			return num;
		}

		// Token: 0x0600B6C8 RID: 46792 RVA: 0x00513657 File Offset: 0x00511857
		private void OILHFNOFNPD()
		{
			this.OMIJMALCLAG = base.GetComponent<Camera>();
			this.OMIJMALCLAG.depthTextureMode |= DepthTextureMode.None;
		}

		// Token: 0x0600B6C9 RID: 46793 RVA: 0x0051407A File Offset: 0x0051227A
		private void BMLMKAGHDDE()
		{
			LBMNBHPBAPJ.IELAIEJJBEO();
		}

		// Token: 0x0600B6CA RID: 46794 RVA: 0x00514084 File Offset: 0x00512284
		private void KPDHFELPIDD(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ, DepthOfFieldDeprecated.BMEMFJFOHOJ DPBMPHJBLBO, int AGNBHDBHKCJ, float GLJOIOBPAEP)
		{
			this.JBBAHGKAIFF.SetTexture("Flap_04.wav", GMNLJGNOKPD);
			RenderTexture temporary = RenderTexture.GetTemporary(LJGGOANMJAJ.width, LJGGOANMJAJ.height);
			if (DPBMPHJBLBO > (DepthOfFieldDeprecated.BMEMFJFOHOJ)0)
			{
				this.DOLGADOKOPK(GMNLJGNOKPD, LJGGOANMJAJ, AGNBHDBHKCJ, GLJOIOBPAEP, temporary);
				if (DPBMPHJBLBO > (DepthOfFieldDeprecated.BMEMFJFOHOJ)0)
				{
					this.JBBAHGKAIFF.SetVector("FlyBackward", new Vector4(260f, GLJOIOBPAEP * this.OFJHPNCEPHN, 1314f, 356f));
					Graphics.Blit(LJGGOANMJAJ, temporary, this.JBBAHGKAIFF, AGNBHDBHKCJ);
					this.JBBAHGKAIFF.SetVector("IdleDodgeRight", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 1605f, 454f, 1715f));
					Graphics.Blit(temporary, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
				}
			}
			else
			{
				this.JBBAHGKAIFF.SetVector("MotorbikeHandstand", new Vector4(1109f, GLJOIOBPAEP * this.OFJHPNCEPHN, 38f, 130f));
				Graphics.Blit(GMNLJGNOKPD, temporary, this.JBBAHGKAIFF, AGNBHDBHKCJ);
				this.JBBAHGKAIFF.SetVector("RollerBladeStop", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 404f, 1484f, 1990f));
				Graphics.Blit(temporary, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600B6CB RID: 46795 RVA: 0x005141D8 File Offset: 0x005123D8
		private void NFGHHDPJCEJ(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.HOEHDBIHELI.SetVector("_FogParams", new Vector4(1808f / (786f * (float)LJGGOANMJAJ.width), 1530f / (775f * (float)LJGGOANMJAJ.height), 628f, 586f));
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.HOEHDBIHELI, DepthOfFieldDeprecated.AKEBHPEEABH);
		}

		// Token: 0x0600B6CC RID: 46796 RVA: 0x0051423C File Offset: 0x0051243C
		private int EHKLMGBCCNB(int MAFGPALKEJE)
		{
			int num = MAFGPALKEJE;
			if (this.resolution == (DepthOfFieldDeprecated.EDNECHKAFDC)0)
			{
				num *= 6;
			}
			if (this.resolution == (DepthOfFieldDeprecated.EDNECHKAFDC)5)
			{
				num *= 8;
			}
			return num;
		}

		// Token: 0x0600B6CD RID: 46797 RVA: 0x00514268 File Offset: 0x00512468
		private void LPPHBNBILAP(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ, int AGNBHDBHKCJ, float GLJOIOBPAEP, RenderTexture KBNKJKBDCLN)
		{
			this.JBBAHGKAIFF.SetVector("_Offsets", new Vector4(1367f, GLJOIOBPAEP * this.OFJHPNCEPHN, 135f, 886f));
			Graphics.Blit(GMNLJGNOKPD, KBNKJKBDCLN, this.JBBAHGKAIFF, AGNBHDBHKCJ);
			this.JBBAHGKAIFF.SetVector("", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 1793f, 515f, 1147f));
			Graphics.Blit(KBNKJKBDCLN, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
			this.JBBAHGKAIFF.SetVector("MotorbikeWheelyNoHands", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, GLJOIOBPAEP * this.OFJHPNCEPHN, 983f, 147f));
			Graphics.Blit(LJGGOANMJAJ, KBNKJKBDCLN, this.JBBAHGKAIFF, AGNBHDBHKCJ);
			this.JBBAHGKAIFF.SetVector("cht_msg4", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, -GLJOIOBPAEP * this.OFJHPNCEPHN, 1642f, 613f));
			Graphics.Blit(KBNKJKBDCLN, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
		}

		// Token: 0x0600B6CE RID: 46798 RVA: 0x00513657 File Offset: 0x00511857
		private void JAFCKIKCHGM()
		{
			this.OMIJMALCLAG = base.GetComponent<Camera>();
			this.OMIJMALCLAG.depthTextureMode |= DepthTextureMode.None;
		}

		// Token: 0x0600B6CF RID: 46799 RVA: 0x00514384 File Offset: 0x00512584
		private int EGDAGLGJLPJ(int MAFGPALKEJE)
		{
			int num = MAFGPALKEJE;
			if (this.resolution == (DepthOfFieldDeprecated.EDNECHKAFDC)1)
			{
				num *= 4;
			}
			if (this.resolution == DepthOfFieldDeprecated.EDNECHKAFDC.Low)
			{
				num *= 5;
			}
			return num;
		}

		// Token: 0x0600B6D0 RID: 46800 RVA: 0x005143AE File Offset: 0x005125AE
		private void OnEnable()
		{
			this.OMIJMALCLAG = base.GetComponent<Camera>();
			this.OMIJMALCLAG.depthTextureMode |= DepthTextureMode.Depth;
		}

		// Token: 0x0600B6D1 RID: 46801 RVA: 0x005143CF File Offset: 0x005125CF
		private void HFOPMECKKPF()
		{
			LBMNBHPBAPJ.KIHBNBACLCB();
		}

		// Token: 0x0600B6D2 RID: 46802 RVA: 0x005143D8 File Offset: 0x005125D8
		private void POOCOLFIAFN(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ, DepthOfFieldDeprecated.BMEMFJFOHOJ DPBMPHJBLBO, int AGNBHDBHKCJ, float GLJOIOBPAEP)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(LJGGOANMJAJ.width, LJGGOANMJAJ.height);
			if (DPBMPHJBLBO > DepthOfFieldDeprecated.BMEMFJFOHOJ.Low)
			{
				this.LCLPLBMOCGB(GMNLJGNOKPD, LJGGOANMJAJ, AGNBHDBHKCJ, GLJOIOBPAEP, temporary);
				if (DPBMPHJBLBO > (DepthOfFieldDeprecated.BMEMFJFOHOJ)3)
				{
					this.JBBAHGKAIFF.SetVector("RollerBladeStand", new Vector4(1379f, GLJOIOBPAEP * this.OFJHPNCEPHN, 564f, 1441f));
					Graphics.Blit(LJGGOANMJAJ, temporary, this.JBBAHGKAIFF, AGNBHDBHKCJ);
					this.JBBAHGKAIFF.SetVector(" iterations for read and write", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 96f, 877f, 194f));
					Graphics.Blit(temporary, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
				}
			}
			else
			{
				this.JBBAHGKAIFF.SetVector("KatanaReady", new Vector4(639f, GLJOIOBPAEP * this.OFJHPNCEPHN, 1409f, 1569f));
				Graphics.Blit(GMNLJGNOKPD, temporary, this.JBBAHGKAIFF, AGNBHDBHKCJ);
				this.JBBAHGKAIFF.SetVector("Giant3HitCombo2", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 936f, 1637f, 1556f));
				Graphics.Blit(temporary, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600B6D3 RID: 46803 RVA: 0x00514518 File Offset: 0x00512718
		private void ECPPLLLBALC(bool OHDMEDCBPAA, RenderTexture JONJODLFAEN, int JODELFPOKMJ, int BCGMAMHHLFF)
		{
			this.DPJPOEMKIPJ = null;
			if (OHDMEDCBPAA)
			{
				this.DPJPOEMKIPJ = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 1);
			}
			this.AMJHOJBNFOM = RenderTexture.GetTemporary(JONJODLFAEN.width / JODELFPOKMJ, JONJODLFAEN.height / JODELFPOKMJ, 0);
			this.NPAPJCDHNJH = RenderTexture.GetTemporary(JONJODLFAEN.width / JODELFPOKMJ, JONJODLFAEN.height / JODELFPOKMJ, 1);
			this.PMOOKOALAEN = RenderTexture.GetTemporary(JONJODLFAEN.width / BCGMAMHHLFF, JONJODLFAEN.height / BCGMAMHHLFF, 1);
			this.MNNMCBKBBKL = null;
			this.EEKFJNKCLFF = null;
			if (this.bokeh)
			{
				this.MNNMCBKBBKL = RenderTexture.GetTemporary(JONJODLFAEN.width / (BCGMAMHHLFF * this.bokehDownsample), JONJODLFAEN.height / (BCGMAMHHLFF * this.bokehDownsample), 0, RenderTextureFormat.ARGBHalf);
				this.EEKFJNKCLFF = RenderTexture.GetTemporary(JONJODLFAEN.width / (BCGMAMHHLFF * this.bokehDownsample), JONJODLFAEN.height / (BCGMAMHHLFF * this.bokehDownsample), 0, RenderTextureFormat.ARGB2101010);
				this.MNNMCBKBBKL.filterMode = FilterMode.Bilinear;
				this.EEKFJNKCLFF.filterMode = FilterMode.Bilinear;
				RenderTexture.active = this.EEKFJNKCLFF;
				GL.Clear(true, true, new Color(931f, 1888f, 182f, 926f));
			}
			JONJODLFAEN.filterMode = FilterMode.Point;
			this.NPAPJCDHNJH.filterMode = FilterMode.Bilinear;
			this.AMJHOJBNFOM.filterMode = FilterMode.Bilinear;
			this.PMOOKOALAEN.filterMode = FilterMode.Point;
			if (this.DPJPOEMKIPJ)
			{
				this.DPJPOEMKIPJ.filterMode = FilterMode.Bilinear;
			}
		}

		// Token: 0x0600B6D4 RID: 46804 RVA: 0x00514698 File Offset: 0x00512898
		public virtual bool JCCFBJBBHBP()
		{
			base.EHGENDOEHLP(true);
			this.JBBAHGKAIFF = base.ALJPMGLOIEG(this.dofBlurShader, this.JBBAHGKAIFF);
			this.HOEHDBIHELI = base.IIIIADNBONI(this.dofShader, this.HOEHDBIHELI);
			this.bokehSupport = this.bokehShader.isSupported;
			if (this.bokeh && this.bokehSupport && this.bokehShader)
			{
				this.JNFMKGDGJEA = base.IIIIADNBONI(this.bokehShader, this.JNFMKGDGJEA);
			}
			if (!this.PPGOAMIHMBG)
			{
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B6D5 RID: 46805 RVA: 0x00514738 File Offset: 0x00512938
		public virtual bool CGJBGGCEBAO()
		{
			base.OLMOAHDIDNG(true);
			this.JBBAHGKAIFF = base.BAPJBHPEDIF(this.dofBlurShader, this.JBBAHGKAIFF);
			this.HOEHDBIHELI = base.ALJPMGLOIEG(this.dofShader, this.HOEHDBIHELI);
			this.bokehSupport = this.bokehShader.isSupported;
			if (this.bokeh && this.bokehSupport && this.bokehShader)
			{
				this.JNFMKGDGJEA = base.ALJPMGLOIEG(this.bokehShader, this.JNFMKGDGJEA);
			}
			if (!this.PPGOAMIHMBG)
			{
				base.NAIBIABADFB();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B6D6 RID: 46806 RVA: 0x005147D8 File Offset: 0x005129D8
		private int JHJAPBEFHLF()
		{
			int result = 1;
			if (this.resolution == (DepthOfFieldDeprecated.EDNECHKAFDC)7)
			{
				result = 6;
			}
			else if (this.resolution == (DepthOfFieldDeprecated.EDNECHKAFDC)0)
			{
				result = 2;
			}
			return result;
		}

		// Token: 0x0600B6D7 RID: 46807 RVA: 0x00514800 File Offset: 0x00512A00
		private void GPDEPKAGHIM(RenderTexture EEECFBAIFAN, RenderTexture MMNMAEGCJBB, RenderTexture AEMBFNBJDAC)
		{
			if (this.JNFMKGDGJEA)
			{
				Mesh[] array = LBMNBHPBAPJ.PBNNAGFMJPA(MMNMAEGCJBB.width, MMNMAEGCJBB.height);
				RenderTexture.active = MMNMAEGCJBB;
				GL.Clear(false, true, new Color(1194f, 482f, 1021f, 280f));
				GL.PushMatrix();
				GL.LoadIdentity();
				EEECFBAIFAN.filterMode = FilterMode.Point;
				float num = (float)EEECFBAIFAN.width * 20f / ((float)EEECFBAIFAN.height * 391f);
				float num2 = 1566f / (131f * (float)EEECFBAIFAN.width);
				num2 += this.bokehScale * this.maxBlurSpread * DepthOfFieldDeprecated.IHIEFLOIANN * this.OFJHPNCEPHN;
				this.JNFMKGDGJEA.SetTexture("wpn_bait1", EEECFBAIFAN);
				this.JNFMKGDGJEA.SetTexture("CardPlayerIdle", this.bokehTexture);
				this.JNFMKGDGJEA.SetVector("invn_ver2", new Vector4(num2, num2 * num, 1030f, 617f * num));
				this.JNFMKGDGJEA.SetFloat("The image effect ", this.bokehIntensity);
				this.JNFMKGDGJEA.SetPass(1);
				foreach (Mesh mesh in array)
				{
					if (mesh)
					{
						Graphics.DrawMeshNow(mesh, Matrix4x4.identity);
					}
				}
				GL.PopMatrix();
				Graphics.Blit(MMNMAEGCJBB, AEMBFNBJDAC, this.HOEHDBIHELI, 3);
				EEECFBAIFAN.filterMode = FilterMode.Point;
			}
		}

		// Token: 0x0600B6D8 RID: 46808 RVA: 0x00514964 File Offset: 0x00512B64
		public override bool CheckResources()
		{
			base.DAOKCAOFIGE(true);
			this.JBBAHGKAIFF = base.DJFOEIJIMJB(this.dofBlurShader, this.JBBAHGKAIFF);
			this.HOEHDBIHELI = base.DJFOEIJIMJB(this.dofShader, this.HOEHDBIHELI);
			this.bokehSupport = this.bokehShader.isSupported;
			if (this.bokeh && this.bokehSupport && this.bokehShader)
			{
				this.JNFMKGDGJEA = base.DJFOEIJIMJB(this.bokehShader, this.JNFMKGDGJEA);
			}
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B6D9 RID: 46809 RVA: 0x00514A04 File Offset: 0x00512C04
		private void EDCMJAIOEOH(RenderTexture EEECFBAIFAN, RenderTexture MMNMAEGCJBB, RenderTexture AEMBFNBJDAC)
		{
			if (this.JNFMKGDGJEA)
			{
				Mesh[] array = LBMNBHPBAPJ.OHNNCGODGGJ(MMNMAEGCJBB.width, MMNMAEGCJBB.height);
				RenderTexture.active = MMNMAEGCJBB;
				GL.Clear(false, false, new Color(96f, 253f, 794f, 1920f));
				GL.PushMatrix();
				GL.LoadIdentity();
				EEECFBAIFAN.filterMode = FilterMode.Bilinear;
				float num = (float)EEECFBAIFAN.width * 569f / ((float)EEECFBAIFAN.height * 748f);
				float num2 = 930f / (375f * (float)EEECFBAIFAN.width);
				num2 += this.bokehScale * this.maxBlurSpread * DepthOfFieldDeprecated.IHIEFLOIANN * this.OFJHPNCEPHN;
				this.JNFMKGDGJEA.SetTexture("ENABLE_USER_LUT", EEECFBAIFAN);
				this.JNFMKGDGJEA.SetTexture("RunBackLeft", this.bokehTexture);
				this.JNFMKGDGJEA.SetVector("rod_inf2", new Vector4(num2, num2 * num, 1061f, 1629f * num));
				this.JNFMKGDGJEA.SetFloat(". Check the Maintenance window for your VPaint Group for more info.", this.bokehIntensity);
				this.JNFMKGDGJEA.SetPass(0);
				Mesh[] array2 = array;
				for (int i = 0; i < array2.Length; i += 0)
				{
					Mesh mesh = array2[i];
					if (mesh)
					{
						Graphics.DrawMeshNow(mesh, Matrix4x4.identity);
					}
				}
				GL.PopMatrix();
				Graphics.Blit(MMNMAEGCJBB, AEMBFNBJDAC, this.HOEHDBIHELI, 3);
				EEECFBAIFAN.filterMode = FilterMode.Point;
			}
		}

		// Token: 0x0600B6DA RID: 46810 RVA: 0x00514B68 File Offset: 0x00512D68
		private int IOCAKMCPBLK()
		{
			int result = 1;
			if (this.resolution == (DepthOfFieldDeprecated.EDNECHKAFDC)0)
			{
				result = 5;
			}
			else if (this.resolution == (DepthOfFieldDeprecated.EDNECHKAFDC)0)
			{
				result = 5;
			}
			return result;
		}

		// Token: 0x0600B6DB RID: 46811 RVA: 0x00514B90 File Offset: 0x00512D90
		public virtual bool CCMBJKDAMLO()
		{
			base.CGEGCOKMPHN(true);
			this.JBBAHGKAIFF = base.JBHLGBPJFEL(this.dofBlurShader, this.JBBAHGKAIFF);
			this.HOEHDBIHELI = base.DJFOEIJIMJB(this.dofShader, this.HOEHDBIHELI);
			this.bokehSupport = this.bokehShader.isSupported;
			if (this.bokeh && this.bokehSupport && this.bokehShader)
			{
				this.JNFMKGDGJEA = base.DJFOEIJIMJB(this.bokehShader, this.JNFMKGDGJEA);
			}
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B6DC RID: 46812 RVA: 0x00514C30 File Offset: 0x00512E30
		private void BEGMKCCOKAJ()
		{
			if (this.DPJPOEMKIPJ)
			{
				RenderTexture.ReleaseTemporary(this.DPJPOEMKIPJ);
			}
			if (this.NPAPJCDHNJH)
			{
				RenderTexture.ReleaseTemporary(this.NPAPJCDHNJH);
			}
			if (this.AMJHOJBNFOM)
			{
				RenderTexture.ReleaseTemporary(this.AMJHOJBNFOM);
			}
			if (this.PMOOKOALAEN)
			{
				RenderTexture.ReleaseTemporary(this.PMOOKOALAEN);
			}
			if (this.MNNMCBKBBKL)
			{
				RenderTexture.ReleaseTemporary(this.MNNMCBKBBKL);
			}
			if (this.EEKFJNKCLFF)
			{
				RenderTexture.ReleaseTemporary(this.EEKFJNKCLFF);
			}
		}

		// Token: 0x0600B6DD RID: 46813 RVA: 0x00514CD0 File Offset: 0x00512ED0
		private void FDLCPCDBJJH()
		{
			this.JBBAHGKAIFF = base.OOAOHFFDMJP(this.dofBlurShader, this.JBBAHGKAIFF);
			this.HOEHDBIHELI = base.BAPJBHPEDIF(this.dofShader, this.HOEHDBIHELI);
			this.bokehSupport = this.bokehShader.isSupported;
			if (this.bokeh && this.bokehSupport && this.bokehShader)
			{
				this.JNFMKGDGJEA = base.DJFOEIJIMJB(this.bokehShader, this.JNFMKGDGJEA);
			}
		}

		// Token: 0x0600B6DE RID: 46814 RVA: 0x00514D54 File Offset: 0x00512F54
		private void ODNNCACCNLE(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ, DepthOfFieldDeprecated.BMEMFJFOHOJ DPBMPHJBLBO, int AGNBHDBHKCJ, float GLJOIOBPAEP)
		{
			this.JBBAHGKAIFF.SetTexture("close", GMNLJGNOKPD);
			RenderTexture temporary = RenderTexture.GetTemporary(LJGGOANMJAJ.width, LJGGOANMJAJ.height);
			if (DPBMPHJBLBO > DepthOfFieldDeprecated.BMEMFJFOHOJ.Low)
			{
				this.PHDGHMAKPEF(GMNLJGNOKPD, LJGGOANMJAJ, AGNBHDBHKCJ, GLJOIOBPAEP, temporary);
				if (DPBMPHJBLBO > DepthOfFieldDeprecated.BMEMFJFOHOJ.VeryHigh)
				{
					this.JBBAHGKAIFF.SetVector("chatconnecthelp", new Vector4(1844f, GLJOIOBPAEP * this.OFJHPNCEPHN, 1894f, 1775f));
					Graphics.Blit(LJGGOANMJAJ, temporary, this.JBBAHGKAIFF, AGNBHDBHKCJ);
					this.JBBAHGKAIFF.SetVector("invn_rec16", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 1075f, 1502f, 1786f));
					Graphics.Blit(temporary, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
				}
			}
			else
			{
				this.JBBAHGKAIFF.SetVector("IdleDodgeRight", new Vector4(1810f, GLJOIOBPAEP * this.OFJHPNCEPHN, 1452f, 367f));
				Graphics.Blit(GMNLJGNOKPD, temporary, this.JBBAHGKAIFF, AGNBHDBHKCJ);
				this.JBBAHGKAIFF.SetVector("", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 1797f, 1794f, 198f));
				Graphics.Blit(temporary, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600B6DF RID: 46815 RVA: 0x00514EA5 File Offset: 0x005130A5
		private void FGHHAIDJNMM()
		{
			LBMNBHPBAPJ.AAHIOKIJAFH();
		}

		// Token: 0x0600B6E0 RID: 46816 RVA: 0x005143CF File Offset: 0x005125CF
		private void OnDisable()
		{
			LBMNBHPBAPJ.KIHBNBACLCB();
		}

		// Token: 0x0600B6E1 RID: 46817 RVA: 0x005143AE File Offset: 0x005125AE
		private void INEHANLJIEM()
		{
			this.OMIJMALCLAG = base.GetComponent<Camera>();
			this.OMIJMALCLAG.depthTextureMode |= DepthTextureMode.Depth;
		}

		// Token: 0x0600B6E2 RID: 46818 RVA: 0x00514EAC File Offset: 0x005130AC
		private void FEFHNAJIEJD()
		{
			this.JBBAHGKAIFF = base.DJFOEIJIMJB(this.dofBlurShader, this.JBBAHGKAIFF);
			this.HOEHDBIHELI = base.JBHLGBPJFEL(this.dofShader, this.HOEHDBIHELI);
			this.bokehSupport = this.bokehShader.isSupported;
			if (this.bokeh && this.bokehSupport && this.bokehShader)
			{
				this.JNFMKGDGJEA = base.BOOFEOGDMBI(this.bokehShader, this.JNFMKGDGJEA);
			}
		}

		// Token: 0x0600B6E3 RID: 46819 RVA: 0x00514F30 File Offset: 0x00513130
		private int DOKLINHGFLD()
		{
			int result = 1;
			if (this.resolution == DepthOfFieldDeprecated.EDNECHKAFDC.High)
			{
				result = 2;
			}
			else if (this.resolution == DepthOfFieldDeprecated.EDNECHKAFDC.High)
			{
				result = 5;
			}
			return result;
		}

		// Token: 0x0600B6E4 RID: 46820 RVA: 0x00514F58 File Offset: 0x00513158
		private float KBELECENEKO(float DFCBOEMAOIJ)
		{
			return this.OMIJMALCLAG.WorldToViewportPoint((DFCBOEMAOIJ - this.OMIJMALCLAG.nearClipPlane) * this.OMIJMALCLAG.transform.forward + this.OMIJMALCLAG.transform.position).z / (this.OMIJMALCLAG.farClipPlane - this.OMIJMALCLAG.nearClipPlane);
		}

		// Token: 0x0600B6E5 RID: 46821 RVA: 0x00514FC4 File Offset: 0x005131C4
		private void OOHDLAGKNNI()
		{
			this.JBBAHGKAIFF = base.BAPJBHPEDIF(this.dofBlurShader, this.JBBAHGKAIFF);
			this.HOEHDBIHELI = base.BAPJBHPEDIF(this.dofShader, this.HOEHDBIHELI);
			this.bokehSupport = this.bokehShader.isSupported;
			if (this.bokeh && this.bokehSupport && this.bokehShader)
			{
				this.JNFMKGDGJEA = base.BAPJBHPEDIF(this.bokehShader, this.JNFMKGDGJEA);
			}
		}

		// Token: 0x0600B6E6 RID: 46822 RVA: 0x00515048 File Offset: 0x00513248
		private void BHAMNBLCOGM()
		{
			this.JBBAHGKAIFF = base.DJFOEIJIMJB(this.dofBlurShader, this.JBBAHGKAIFF);
			this.HOEHDBIHELI = base.ALJPMGLOIEG(this.dofShader, this.HOEHDBIHELI);
			this.bokehSupport = this.bokehShader.isSupported;
			if (this.bokeh && this.bokehSupport && this.bokehShader)
			{
				this.JNFMKGDGJEA = base.IIIIADNBONI(this.bokehShader, this.JNFMKGDGJEA);
			}
		}

		// Token: 0x0600B6E7 RID: 46823 RVA: 0x005150CC File Offset: 0x005132CC
		private void MAPKKKAPIFE(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.HOEHDBIHELI.SetVector("Failed parsing organizational group.  Setting to group 0", new Vector4(1544f / (1824f * (float)LJGGOANMJAJ.width), 1098f / (8f * (float)LJGGOANMJAJ.height), 916f, 737f));
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.HOEHDBIHELI, DepthOfFieldDeprecated.AKEBHPEEABH);
		}

		// Token: 0x0600B6E8 RID: 46824 RVA: 0x00515130 File Offset: 0x00513330
		private float KOMIKNHHBML(float DFCBOEMAOIJ)
		{
			return this.OMIJMALCLAG.WorldToViewportPoint((DFCBOEMAOIJ - this.OMIJMALCLAG.nearClipPlane) * this.OMIJMALCLAG.transform.forward + this.OMIJMALCLAG.transform.position).z / (this.OMIJMALCLAG.farClipPlane - this.OMIJMALCLAG.nearClipPlane);
		}

		// Token: 0x0600B6E9 RID: 46825 RVA: 0x0051519C File Offset: 0x0051339C
		private int HKOAMGEHFMC()
		{
			int result = 1;
			if (this.resolution == DepthOfFieldDeprecated.EDNECHKAFDC.High)
			{
				result = 5;
			}
			else if (this.resolution == DepthOfFieldDeprecated.EDNECHKAFDC.High)
			{
				result = 6;
			}
			return result;
		}

		// Token: 0x0600B6EA RID: 46826 RVA: 0x005151C4 File Offset: 0x005133C4
		private void AIOCEACFFCJ(bool OHDMEDCBPAA, RenderTexture JONJODLFAEN, int JODELFPOKMJ, int BCGMAMHHLFF)
		{
			this.DPJPOEMKIPJ = null;
			if (OHDMEDCBPAA)
			{
				this.DPJPOEMKIPJ = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0);
			}
			this.AMJHOJBNFOM = RenderTexture.GetTemporary(JONJODLFAEN.width / JODELFPOKMJ, JONJODLFAEN.height / JODELFPOKMJ, 1);
			this.NPAPJCDHNJH = RenderTexture.GetTemporary(JONJODLFAEN.width / JODELFPOKMJ, JONJODLFAEN.height / JODELFPOKMJ, 0);
			this.PMOOKOALAEN = RenderTexture.GetTemporary(JONJODLFAEN.width / BCGMAMHHLFF, JONJODLFAEN.height / BCGMAMHHLFF, 0);
			this.MNNMCBKBBKL = null;
			this.EEKFJNKCLFF = null;
			if (this.bokeh)
			{
				this.MNNMCBKBBKL = RenderTexture.GetTemporary(JONJODLFAEN.width / (BCGMAMHHLFF * this.bokehDownsample), JONJODLFAEN.height / (BCGMAMHHLFF * this.bokehDownsample), 0, RenderTextureFormat.ARGB1555);
				this.EEKFJNKCLFF = RenderTexture.GetTemporary(JONJODLFAEN.width / (BCGMAMHHLFF * this.bokehDownsample), JONJODLFAEN.height / (BCGMAMHHLFF * this.bokehDownsample), 0, RenderTextureFormat.ARGB32);
				this.MNNMCBKBBKL.filterMode = FilterMode.Bilinear;
				this.EEKFJNKCLFF.filterMode = FilterMode.Point;
				RenderTexture.active = this.EEKFJNKCLFF;
				GL.Clear(true, true, new Color(1071f, 230f, 707f, 88f));
			}
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			this.NPAPJCDHNJH.filterMode = FilterMode.Point;
			this.AMJHOJBNFOM.filterMode = FilterMode.Point;
			this.PMOOKOALAEN.filterMode = FilterMode.Bilinear;
			if (this.DPJPOEMKIPJ)
			{
				this.DPJPOEMKIPJ.filterMode = FilterMode.Point;
			}
		}

		// Token: 0x0600B6EB RID: 46827 RVA: 0x00515344 File Offset: 0x00513544
		private void CBPOPNBNAKM()
		{
			if (this.DPJPOEMKIPJ)
			{
				RenderTexture.ReleaseTemporary(this.DPJPOEMKIPJ);
			}
			if (this.NPAPJCDHNJH)
			{
				RenderTexture.ReleaseTemporary(this.NPAPJCDHNJH);
			}
			if (this.AMJHOJBNFOM)
			{
				RenderTexture.ReleaseTemporary(this.AMJHOJBNFOM);
			}
			if (this.PMOOKOALAEN)
			{
				RenderTexture.ReleaseTemporary(this.PMOOKOALAEN);
			}
			if (this.MNNMCBKBBKL)
			{
				RenderTexture.ReleaseTemporary(this.MNNMCBKBBKL);
			}
			if (this.EEKFJNKCLFF)
			{
				RenderTexture.ReleaseTemporary(this.EEKFJNKCLFF);
			}
		}

		// Token: 0x0600B6EC RID: 46828 RVA: 0x005153E4 File Offset: 0x005135E4
		private int FFBBEANNHCG()
		{
			int result = 0;
			if (this.resolution == DepthOfFieldDeprecated.EDNECHKAFDC.Medium)
			{
				result = 5;
			}
			else if (this.resolution == DepthOfFieldDeprecated.EDNECHKAFDC.High)
			{
				result = 1;
			}
			return result;
		}

		// Token: 0x0600B6ED RID: 46829 RVA: 0x0051540C File Offset: 0x0051360C
		private void NKLPIOFKHEI(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.HOEHDBIHELI.SetVector("Giant2HandGrab", new Vector4(1504f / (911f * (float)LJGGOANMJAJ.width), 1173f / (92f * (float)LJGGOANMJAJ.height), 770f, 195f));
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.HOEHDBIHELI, DepthOfFieldDeprecated.AKEBHPEEABH);
		}

		// Token: 0x0600B6EE RID: 46830 RVA: 0x00515470 File Offset: 0x00513670
		private void GHFIMGGBFOG(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ, int AGNBHDBHKCJ, float GLJOIOBPAEP, RenderTexture KBNKJKBDCLN)
		{
			this.JBBAHGKAIFF.SetVector("/n", new Vector4(1319f, GLJOIOBPAEP * this.OFJHPNCEPHN, 412f, 720f));
			Graphics.Blit(GMNLJGNOKPD, KBNKJKBDCLN, this.JBBAHGKAIFF, AGNBHDBHKCJ);
			this.JBBAHGKAIFF.SetVector("prk_max", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 442f, 1400f, 1356f));
			Graphics.Blit(KBNKJKBDCLN, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
			this.JBBAHGKAIFF.SetVector("setCurrentRod curorder=", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, GLJOIOBPAEP * this.OFJHPNCEPHN, 1550f, 1595f));
			Graphics.Blit(LJGGOANMJAJ, KBNKJKBDCLN, this.JBBAHGKAIFF, AGNBHDBHKCJ);
			this.JBBAHGKAIFF.SetVector("PaperTurn.wav", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, -GLJOIOBPAEP * this.OFJHPNCEPHN, 185f, 1189f));
			Graphics.Blit(KBNKJKBDCLN, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
		}

		// Token: 0x0600B6EF RID: 46831 RVA: 0x0051558C File Offset: 0x0051378C
		private void AEOGAJIDNPK(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ, DepthOfFieldDeprecated.BMEMFJFOHOJ DPBMPHJBLBO, int AGNBHDBHKCJ, float GLJOIOBPAEP)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(LJGGOANMJAJ.width, LJGGOANMJAJ.height);
			if (DPBMPHJBLBO > (DepthOfFieldDeprecated.BMEMFJFOHOJ)0)
			{
				this.PHDGHMAKPEF(GMNLJGNOKPD, LJGGOANMJAJ, AGNBHDBHKCJ, GLJOIOBPAEP, temporary);
				if (DPBMPHJBLBO > (DepthOfFieldDeprecated.BMEMFJFOHOJ)0)
				{
					this.JBBAHGKAIFF.SetVector("", new Vector4(54f, GLJOIOBPAEP * this.OFJHPNCEPHN, 459f, 1266f));
					Graphics.Blit(LJGGOANMJAJ, temporary, this.JBBAHGKAIFF, AGNBHDBHKCJ);
					this.JBBAHGKAIFF.SetVector("steamno", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 869f, 1957f, 1410f));
					Graphics.Blit(temporary, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
				}
			}
			else
			{
				this.JBBAHGKAIFF.SetVector("fwgt_big_m", new Vector4(54f, GLJOIOBPAEP * this.OFJHPNCEPHN, 1960f, 1942f));
				Graphics.Blit(GMNLJGNOKPD, temporary, this.JBBAHGKAIFF, AGNBHDBHKCJ);
				this.JBBAHGKAIFF.SetVector("gi_letgohe", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 1458f, 1824f, 244f));
				Graphics.Blit(temporary, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600B6F0 RID: 46832 RVA: 0x005156CC File Offset: 0x005138CC
		private void JKBJBFMAFFK(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ, DepthOfFieldDeprecated.BMEMFJFOHOJ DPBMPHJBLBO, int AGNBHDBHKCJ, float GLJOIOBPAEP)
		{
			this.JBBAHGKAIFF.SetTexture("steamno", GMNLJGNOKPD);
			RenderTexture temporary = RenderTexture.GetTemporary(LJGGOANMJAJ.width, LJGGOANMJAJ.height);
			if (DPBMPHJBLBO > DepthOfFieldDeprecated.BMEMFJFOHOJ.Low)
			{
				this.LPPHBNBILAP(GMNLJGNOKPD, LJGGOANMJAJ, AGNBHDBHKCJ, GLJOIOBPAEP, temporary);
				if (DPBMPHJBLBO > (DepthOfFieldDeprecated.BMEMFJFOHOJ)7)
				{
					this.JBBAHGKAIFF.SetVector(",", new Vector4(1675f, GLJOIOBPAEP * this.OFJHPNCEPHN, 437f, 778f));
					Graphics.Blit(LJGGOANMJAJ, temporary, this.JBBAHGKAIFF, AGNBHDBHKCJ);
					this.JBBAHGKAIFF.SetVector("SwimDogPaddle", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 534f, 79f, 1135f));
					Graphics.Blit(temporary, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
				}
			}
			else
			{
				this.JBBAHGKAIFF.SetVector("SPECIAL", new Vector4(486f, GLJOIOBPAEP * this.OFJHPNCEPHN, 867f, 1067f));
				Graphics.Blit(GMNLJGNOKPD, temporary, this.JBBAHGKAIFF, AGNBHDBHKCJ);
				this.JBBAHGKAIFF.SetVector("GestureChestPumpSalute", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 1886f, 934f, 1084f));
				Graphics.Blit(temporary, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600B6F1 RID: 46833 RVA: 0x00515820 File Offset: 0x00513A20
		private void PKNBABMJLPB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.smoothness < 1157f)
			{
				this.smoothness = 205f;
			}
			this.bokeh = (!this.bokeh || this.bokehSupport);
			float num = this.bokeh ? DepthOfFieldDeprecated.IHIEFLOIANN : 805f;
			bool flag = this.quality > (DepthOfFieldDeprecated.NBLDEAGICCP)0;
			float num2 = this.focalSize / (this.OMIJMALCLAG.farClipPlane - this.OMIJMALCLAG.nearClipPlane);
			if (this.simpleTweakMode)
			{
				this.MHJDKBOLOBD = (this.objectFocus ? (this.OMIJMALCLAG.WorldToViewportPoint(this.objectFocus.position).z / this.OMIJMALCLAG.farClipPlane) : this.HPMAEMNIEDO(this.focalPoint));
				this.DINBPHKCLEB = this.MHJDKBOLOBD * this.smoothness;
				this.PKANLIIHMBF = this.DINBPHKCLEB;
				flag = (flag && this.focalPoint > this.OMIJMALCLAG.nearClipPlane + Mathf.Epsilon);
			}
			else
			{
				if (this.objectFocus)
				{
					Vector3 vector = this.OMIJMALCLAG.WorldToViewportPoint(this.objectFocus.position);
					vector.z /= this.OMIJMALCLAG.farClipPlane;
					this.MHJDKBOLOBD = vector.z;
				}
				else
				{
					this.MHJDKBOLOBD = this.PFDCPKFHPMI(this.focalZDistance);
				}
				this.DINBPHKCLEB = this.focalZStartCurve;
				this.PKANLIIHMBF = this.focalZEndCurve;
				flag = (flag && this.focalPoint > this.OMIJMALCLAG.nearClipPlane + Mathf.Epsilon);
			}
			this.KDJDAGBLCMA = 932f * (float)JONJODLFAEN.width / (1093f * (float)JONJODLFAEN.height);
			this.OFJHPNCEPHN = 949f;
			this.HOEHDBIHELI.SetFloat("wpn_tank1", this.foregroundBlurExtrude);
			this.HOEHDBIHELI.SetVector("Gesture Chest Pump Salute", new Vector4(this.simpleTweakMode ? (1912f / this.DINBPHKCLEB) : this.DINBPHKCLEB, this.simpleTweakMode ? (1868f / this.PKANLIIHMBF) : this.PKANLIIHMBF, num2 * 233f, this.MHJDKBOLOBD));
			this.HOEHDBIHELI.SetVector("Hit Point WeightCurve length is zero.", new Vector4(1521f / (932f * (float)JONJODLFAEN.width), 1427f / (234f * (float)JONJODLFAEN.height), 1990f, 1080f));
			int num3 = this.HKOAMGEHFMC();
			int bcgmamhhlff = this.PDOFEIGMLMM(num3);
			this.AIOCEACFFCJ(flag, JONJODLFAEN, num3, bcgmamhhlff);
			Graphics.Blit(JONJODLFAEN, JONJODLFAEN, this.HOEHDBIHELI, 2);
			this.MIAENDLHMFF(JONJODLFAEN, this.AMJHOJBNFOM);
			this.PDLLLDPHHFF(this.AMJHOJBNFOM, this.AMJHOJBNFOM, DepthOfFieldDeprecated.BMEMFJFOHOJ.Low, 1, this.maxBlurSpread);
			if (this.bokeh && ((DepthOfFieldDeprecated.JKENGKAOIOD)5 & this.bokehDestination) != (DepthOfFieldDeprecated.JKENGKAOIOD)0)
			{
				this.HOEHDBIHELI.SetVector("cht_maxcnt", new Vector4(this.bokehThresholdContrast, this.bokehThresholdLuminance, 1371f, 737f));
				Graphics.Blit(this.AMJHOJBNFOM, this.EEKFJNKCLFF, this.HOEHDBIHELI, -2);
				Graphics.Blit(this.AMJHOJBNFOM, this.PMOOKOALAEN);
				this.NENJELKIBAK(this.PMOOKOALAEN, this.PMOOKOALAEN, this.bluriness, 1, this.maxBlurSpread * num);
			}
			else
			{
				this.EGMKNHDOOED(this.AMJHOJBNFOM, this.PMOOKOALAEN);
				this.POOCOLFIAFN(this.PMOOKOALAEN, this.PMOOKOALAEN, this.bluriness, 1, this.maxBlurSpread);
			}
			this.JBBAHGKAIFF.SetTexture("Hidden/Post FX/Builtin Debug Views", this.PMOOKOALAEN);
			this.JBBAHGKAIFF.SetTexture("IdleWalk", this.AMJHOJBNFOM);
			Graphics.Blit(null, this.NPAPJCDHNJH, this.JBBAHGKAIFF, 0);
			if (this.bokeh && ((DepthOfFieldDeprecated.JKENGKAOIOD)6 & this.bokehDestination) != (DepthOfFieldDeprecated.JKENGKAOIOD)0)
			{
				this.EDCMJAIOEOH(this.EEKFJNKCLFF, this.MNNMCBKBBKL, this.NPAPJCDHNJH);
			}
			this.HOEHDBIHELI.SetTexture("", this.NPAPJCDHNJH);
			this.HOEHDBIHELI.SetTexture("/Localization/langsettings.xml", this.AMJHOJBNFOM);
			Graphics.Blit(JONJODLFAEN, flag ? this.DPJPOEMKIPJ : OKIIDHIJBEA, this.HOEHDBIHELI, this.visualize ? 2 : 1);
			if (flag)
			{
				Graphics.Blit(this.DPJPOEMKIPJ, JONJODLFAEN, this.HOEHDBIHELI, 0);
				this.EGMKNHDOOED(JONJODLFAEN, this.AMJHOJBNFOM);
				this.KONOOFFNHCD(this.AMJHOJBNFOM, this.AMJHOJBNFOM, DepthOfFieldDeprecated.BMEMFJFOHOJ.Low, 7, this.maxBlurSpread);
				if (this.bokeh && ((DepthOfFieldDeprecated.JKENGKAOIOD)6 & this.bokehDestination) != (DepthOfFieldDeprecated.JKENGKAOIOD)0)
				{
					this.HOEHDBIHELI.SetVector("Chest", new Vector4(this.bokehThresholdContrast * 1427f, this.bokehThresholdLuminance, 131f, 1561f));
					Graphics.Blit(this.AMJHOJBNFOM, this.EEKFJNKCLFF, this.HOEHDBIHELI, -5);
					Graphics.Blit(this.AMJHOJBNFOM, this.PMOOKOALAEN);
					this.IKBBMEPACEM(this.PMOOKOALAEN, this.PMOOKOALAEN, this.bluriness, 1, this.maxBlurSpread * num);
				}
				else
				{
					this.IKBBMEPACEM(this.AMJHOJBNFOM, this.PMOOKOALAEN, this.bluriness, 0, this.maxBlurSpread);
				}
				Graphics.Blit(this.PMOOKOALAEN, this.NPAPJCDHNJH);
				this.HOEHDBIHELI.SetTexture("OfficeSittingEyesRub", this.NPAPJCDHNJH);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HOEHDBIHELI, this.visualize ? 0 : 2);
				if (this.bokeh && ((DepthOfFieldDeprecated.JKENGKAOIOD)4 & this.bokehDestination) != (DepthOfFieldDeprecated.JKENGKAOIOD)0)
				{
					this.BBHBPFNGPHB(this.EEKFJNKCLFF, this.MNNMCBKBBKL, OKIIDHIJBEA);
				}
			}
			this.OBDADAIIPCB();
		}

		// Token: 0x0600B6F2 RID: 46834 RVA: 0x00515DE0 File Offset: 0x00513FE0
		private void AONGLILIKHH(RenderTexture EEECFBAIFAN, RenderTexture MMNMAEGCJBB, RenderTexture AEMBFNBJDAC)
		{
			if (this.JNFMKGDGJEA)
			{
				Mesh[] array = LBMNBHPBAPJ.CDPHCEKINEB(MMNMAEGCJBB.width, MMNMAEGCJBB.height);
				RenderTexture.active = MMNMAEGCJBB;
				GL.Clear(true, true, new Color(941f, 1178f, 1169f, 1f));
				GL.PushMatrix();
				GL.LoadIdentity();
				EEECFBAIFAN.filterMode = FilterMode.Bilinear;
				float num = (float)EEECFBAIFAN.width * 955f / ((float)EEECFBAIFAN.height * 1755f);
				float num2 = 1849f / (421f * (float)EEECFBAIFAN.width);
				num2 += this.bokehScale * this.maxBlurSpread * DepthOfFieldDeprecated.IHIEFLOIANN * this.OFJHPNCEPHN;
				this.JNFMKGDGJEA.SetTexture("Hidden/Post FX/Bloom", EEECFBAIFAN);
				this.JNFMKGDGJEA.SetTexture("WaveSpeed", this.bokehTexture);
				this.JNFMKGDGJEA.SetVector("_Specular", new Vector4(num2, num2 * num, 299f, 482f * num));
				this.JNFMKGDGJEA.SetFloat("<color=\"", this.bokehIntensity);
				this.JNFMKGDGJEA.SetPass(0);
				Mesh[] array2 = array;
				for (int i = 0; i < array2.Length; i += 0)
				{
					Mesh mesh = array2[i];
					if (mesh)
					{
						Graphics.DrawMeshNow(mesh, Matrix4x4.identity);
					}
				}
				GL.PopMatrix();
				Graphics.Blit(MMNMAEGCJBB, AEMBFNBJDAC, this.HOEHDBIHELI, 0);
				EEECFBAIFAN.filterMode = FilterMode.Point;
			}
		}

		// Token: 0x0600B6F3 RID: 46835 RVA: 0x00515F44 File Offset: 0x00514144
		private void LJMFKJDBINE(RenderTexture EEECFBAIFAN, RenderTexture MMNMAEGCJBB, RenderTexture AEMBFNBJDAC)
		{
			if (this.JNFMKGDGJEA)
			{
				Mesh[] array = LBMNBHPBAPJ.DJDINLIFGMH(MMNMAEGCJBB.width, MMNMAEGCJBB.height);
				RenderTexture.active = MMNMAEGCJBB;
				GL.Clear(false, false, new Color(1844f, 1145f, 1311f, 885f));
				GL.PushMatrix();
				GL.LoadIdentity();
				EEECFBAIFAN.filterMode = FilterMode.Point;
				float num = (float)EEECFBAIFAN.width * 1389f / ((float)EEECFBAIFAN.height * 1493f);
				float num2 = 1403f / (1721f * (float)EEECFBAIFAN.width);
				num2 += this.bokehScale * this.maxBlurSpread * DepthOfFieldDeprecated.IHIEFLOIANN * this.OFJHPNCEPHN;
				this.JNFMKGDGJEA.SetTexture("post_msg3", EEECFBAIFAN);
				this.JNFMKGDGJEA.SetTexture("System.Single", this.bokehTexture);
				this.JNFMKGDGJEA.SetVector("Hidden/Post FX/Builtin Debug Views", new Vector4(num2, num2 * num, 49f, 144f * num));
				this.JNFMKGDGJEA.SetFloat("craft_data/categories/category", this.bokehIntensity);
				this.JNFMKGDGJEA.SetPass(0);
				Mesh[] array2 = array;
				for (int i = 1; i < array2.Length; i++)
				{
					Mesh mesh = array2[i];
					if (mesh)
					{
						Graphics.DrawMeshNow(mesh, Matrix4x4.identity);
					}
				}
				GL.PopMatrix();
				Graphics.Blit(MMNMAEGCJBB, AEMBFNBJDAC, this.HOEHDBIHELI, 4);
				EEECFBAIFAN.filterMode = FilterMode.Point;
			}
		}

		// Token: 0x0600B6F4 RID: 46836 RVA: 0x005160A8 File Offset: 0x005142A8
		private void KHJJKPCKNKM()
		{
			LBMNBHPBAPJ.GCDKDDPCMIC();
		}

		// Token: 0x0600B6F5 RID: 46837 RVA: 0x005160AF File Offset: 0x005142AF
		private void DNBMNPKDPHC()
		{
			LBMNBHPBAPJ.OHGNEOFMBPA();
		}

		// Token: 0x0600B6F6 RID: 46838 RVA: 0x005160B8 File Offset: 0x005142B8
		private void MDDHOFALLNC(bool OHDMEDCBPAA, RenderTexture JONJODLFAEN, int JODELFPOKMJ, int BCGMAMHHLFF)
		{
			this.DPJPOEMKIPJ = null;
			if (OHDMEDCBPAA)
			{
				this.DPJPOEMKIPJ = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 1);
			}
			this.AMJHOJBNFOM = RenderTexture.GetTemporary(JONJODLFAEN.width / JODELFPOKMJ, JONJODLFAEN.height / JODELFPOKMJ, 1);
			this.NPAPJCDHNJH = RenderTexture.GetTemporary(JONJODLFAEN.width / JODELFPOKMJ, JONJODLFAEN.height / JODELFPOKMJ, 1);
			this.PMOOKOALAEN = RenderTexture.GetTemporary(JONJODLFAEN.width / BCGMAMHHLFF, JONJODLFAEN.height / BCGMAMHHLFF, 0);
			this.MNNMCBKBBKL = null;
			this.EEKFJNKCLFF = null;
			if (this.bokeh)
			{
				this.MNNMCBKBBKL = RenderTexture.GetTemporary(JONJODLFAEN.width / (BCGMAMHHLFF * this.bokehDownsample), JONJODLFAEN.height / (BCGMAMHHLFF * this.bokehDownsample), 0, RenderTextureFormat.Default);
				this.EEKFJNKCLFF = RenderTexture.GetTemporary(JONJODLFAEN.width / (BCGMAMHHLFF * this.bokehDownsample), JONJODLFAEN.height / (BCGMAMHHLFF * this.bokehDownsample), 0, RenderTextureFormat.Default);
				this.MNNMCBKBBKL.filterMode = FilterMode.Bilinear;
				this.EEKFJNKCLFF.filterMode = FilterMode.Bilinear;
				RenderTexture.active = this.EEKFJNKCLFF;
				GL.Clear(true, true, new Color(708f, 1082f, 267f, 636f));
			}
			JONJODLFAEN.filterMode = FilterMode.Point;
			this.NPAPJCDHNJH.filterMode = FilterMode.Bilinear;
			this.AMJHOJBNFOM.filterMode = FilterMode.Bilinear;
			this.PMOOKOALAEN.filterMode = FilterMode.Bilinear;
			if (this.DPJPOEMKIPJ)
			{
				this.DPJPOEMKIPJ.filterMode = FilterMode.Bilinear;
			}
		}

		// Token: 0x0600B6F7 RID: 46839 RVA: 0x00516238 File Offset: 0x00514438
		private void DIAKCGFBCOG(RenderTexture EEECFBAIFAN, RenderTexture MMNMAEGCJBB, RenderTexture AEMBFNBJDAC)
		{
			if (this.JNFMKGDGJEA)
			{
				Mesh[] array = LBMNBHPBAPJ.CFOKFLBCIGE(MMNMAEGCJBB.width, MMNMAEGCJBB.height);
				RenderTexture.active = MMNMAEGCJBB;
				GL.Clear(true, false, new Color(1087f, 1117f, 1526f, 195f));
				GL.PushMatrix();
				GL.LoadIdentity();
				EEECFBAIFAN.filterMode = FilterMode.Point;
				float num = (float)EEECFBAIFAN.width * 1650f / ((float)EEECFBAIFAN.height * 1220f);
				float num2 = 285f / (1511f * (float)EEECFBAIFAN.width);
				num2 += this.bokehScale * this.maxBlurSpread * DepthOfFieldDeprecated.IHIEFLOIANN * this.OFJHPNCEPHN;
				this.JNFMKGDGJEA.SetTexture("IKMappingSpine is missing the left thigh bone.", EEECFBAIFAN);
				this.JNFMKGDGJEA.SetTexture("wpn_bait1", this.bokehTexture);
				this.JNFMKGDGJEA.SetVector("\n", new Vector4(num2, num2 * num, 261f, 1094f * num));
				this.JNFMKGDGJEA.SetFloat("wpn_add/addoptions", this.bokehIntensity);
				this.JNFMKGDGJEA.SetPass(0);
				foreach (Mesh mesh in array)
				{
					if (mesh)
					{
						Graphics.DrawMeshNow(mesh, Matrix4x4.identity);
					}
				}
				GL.PopMatrix();
				Graphics.Blit(MMNMAEGCJBB, AEMBFNBJDAC, this.HOEHDBIHELI, 4);
				EEECFBAIFAN.filterMode = FilterMode.Point;
			}
		}

		// Token: 0x0600B6F8 RID: 46840 RVA: 0x0051639C File Offset: 0x0051459C
		private void IKBBMEPACEM(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ, DepthOfFieldDeprecated.BMEMFJFOHOJ DPBMPHJBLBO, int AGNBHDBHKCJ, float GLJOIOBPAEP)
		{
			this.JBBAHGKAIFF.SetTexture("_TapHigh", GMNLJGNOKPD);
			RenderTexture temporary = RenderTexture.GetTemporary(LJGGOANMJAJ.width, LJGGOANMJAJ.height);
			if (DPBMPHJBLBO > DepthOfFieldDeprecated.BMEMFJFOHOJ.Low)
			{
				this.PHDGHMAKPEF(GMNLJGNOKPD, LJGGOANMJAJ, AGNBHDBHKCJ, GLJOIOBPAEP, temporary);
				if (DPBMPHJBLBO > DepthOfFieldDeprecated.BMEMFJFOHOJ.High)
				{
					this.JBBAHGKAIFF.SetVector("offsets", new Vector4(0f, GLJOIOBPAEP * this.OFJHPNCEPHN, 0f, 0f));
					Graphics.Blit(LJGGOANMJAJ, temporary, this.JBBAHGKAIFF, AGNBHDBHKCJ);
					this.JBBAHGKAIFF.SetVector("offsets", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 0f, 0f, 0f));
					Graphics.Blit(temporary, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
				}
			}
			else
			{
				this.JBBAHGKAIFF.SetVector("offsets", new Vector4(0f, GLJOIOBPAEP * this.OFJHPNCEPHN, 0f, 0f));
				Graphics.Blit(GMNLJGNOKPD, temporary, this.JBBAHGKAIFF, AGNBHDBHKCJ);
				this.JBBAHGKAIFF.SetVector("offsets", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 0f, 0f, 0f));
				Graphics.Blit(temporary, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600B6F9 RID: 46841 RVA: 0x005164F0 File Offset: 0x005146F0
		private void CDHKNJMEGMN(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.HOEHDBIHELI.SetVector("harvestmsg4", new Vector4(812f / (167f * (float)LJGGOANMJAJ.width), 1396f / (992f * (float)LJGGOANMJAJ.height), 1875f, 206f));
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.HOEHDBIHELI, DepthOfFieldDeprecated.AKEBHPEEABH);
		}

		// Token: 0x0600B6FA RID: 46842 RVA: 0x00516554 File Offset: 0x00514754
		private float BKJEENDCMCJ(float DFCBOEMAOIJ)
		{
			return this.OMIJMALCLAG.WorldToViewportPoint((DFCBOEMAOIJ - this.OMIJMALCLAG.nearClipPlane) * this.OMIJMALCLAG.transform.forward + this.OMIJMALCLAG.transform.position).z / (this.OMIJMALCLAG.farClipPlane - this.OMIJMALCLAG.nearClipPlane);
		}

		// Token: 0x0600B6FB RID: 46843 RVA: 0x005165C0 File Offset: 0x005147C0
		public virtual bool BJGCEGLDHBO()
		{
			base.IDFIHFBEIKD(true);
			this.JBBAHGKAIFF = base.IIIIADNBONI(this.dofBlurShader, this.JBBAHGKAIFF);
			this.HOEHDBIHELI = base.DJFOEIJIMJB(this.dofShader, this.HOEHDBIHELI);
			this.bokehSupport = this.bokehShader.isSupported;
			if (this.bokeh && this.bokehSupport && this.bokehShader)
			{
				this.JNFMKGDGJEA = base.BOOFEOGDMBI(this.bokehShader, this.JNFMKGDGJEA);
			}
			if (!this.PPGOAMIHMBG)
			{
				base.LNEHBOJIBAI();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B6FC RID: 46844 RVA: 0x00516660 File Offset: 0x00514860
		private void OnRenderImage(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.smoothness < 0.1f)
			{
				this.smoothness = 0.1f;
			}
			this.bokeh = (this.bokeh && this.bokehSupport);
			float num = this.bokeh ? DepthOfFieldDeprecated.IHIEFLOIANN : 1f;
			bool flag = this.quality > DepthOfFieldDeprecated.NBLDEAGICCP.OnlyBackground;
			float num2 = this.focalSize / (this.OMIJMALCLAG.farClipPlane - this.OMIJMALCLAG.nearClipPlane);
			if (this.simpleTweakMode)
			{
				this.MHJDKBOLOBD = (this.objectFocus ? (this.OMIJMALCLAG.WorldToViewportPoint(this.objectFocus.position).z / this.OMIJMALCLAG.farClipPlane) : this.KBELECENEKO(this.focalPoint));
				this.DINBPHKCLEB = this.MHJDKBOLOBD * this.smoothness;
				this.PKANLIIHMBF = this.DINBPHKCLEB;
				flag = (flag && this.focalPoint > this.OMIJMALCLAG.nearClipPlane + Mathf.Epsilon);
			}
			else
			{
				if (this.objectFocus)
				{
					Vector3 vector = this.OMIJMALCLAG.WorldToViewportPoint(this.objectFocus.position);
					vector.z /= this.OMIJMALCLAG.farClipPlane;
					this.MHJDKBOLOBD = vector.z;
				}
				else
				{
					this.MHJDKBOLOBD = this.KBELECENEKO(this.focalZDistance);
				}
				this.DINBPHKCLEB = this.focalZStartCurve;
				this.PKANLIIHMBF = this.focalZEndCurve;
				flag = (flag && this.focalPoint > this.OMIJMALCLAG.nearClipPlane + Mathf.Epsilon);
			}
			this.KDJDAGBLCMA = 1f * (float)JONJODLFAEN.width / (1f * (float)JONJODLFAEN.height);
			this.OFJHPNCEPHN = 0.001953125f;
			this.HOEHDBIHELI.SetFloat("_ForegroundBlurExtrude", this.foregroundBlurExtrude);
			this.HOEHDBIHELI.SetVector("_CurveParams", new Vector4(this.simpleTweakMode ? (1f / this.DINBPHKCLEB) : this.DINBPHKCLEB, this.simpleTweakMode ? (1f / this.PKANLIIHMBF) : this.PKANLIIHMBF, num2 * 0.5f, this.MHJDKBOLOBD));
			this.HOEHDBIHELI.SetVector("_InvRenderTargetSize", new Vector4(1f / (1f * (float)JONJODLFAEN.width), 1f / (1f * (float)JONJODLFAEN.height), 0f, 0f));
			int num3 = this.EIBNMEAGDIM();
			int bcgmamhhlff = this.PDOFEIGMLMM(num3);
			this.GNGEHNGBIDL(flag, JONJODLFAEN, num3, bcgmamhhlff);
			Graphics.Blit(JONJODLFAEN, JONJODLFAEN, this.HOEHDBIHELI, 3);
			this.ANNEMHGIHAI(JONJODLFAEN, this.AMJHOJBNFOM);
			this.EHKMMJMCIEA(this.AMJHOJBNFOM, this.AMJHOJBNFOM, DepthOfFieldDeprecated.BMEMFJFOHOJ.Low, 4, this.maxBlurSpread);
			if (this.bokeh && (DepthOfFieldDeprecated.JKENGKAOIOD.Foreground & this.bokehDestination) != (DepthOfFieldDeprecated.JKENGKAOIOD)0)
			{
				this.HOEHDBIHELI.SetVector("_Threshhold", new Vector4(this.bokehThresholdContrast, this.bokehThresholdLuminance, 0.95f, 0f));
				Graphics.Blit(this.AMJHOJBNFOM, this.EEKFJNKCLFF, this.HOEHDBIHELI, 11);
				Graphics.Blit(this.AMJHOJBNFOM, this.PMOOKOALAEN);
				this.EHKMMJMCIEA(this.PMOOKOALAEN, this.PMOOKOALAEN, this.bluriness, 0, this.maxBlurSpread * num);
			}
			else
			{
				this.ANNEMHGIHAI(this.AMJHOJBNFOM, this.PMOOKOALAEN);
				this.EHKMMJMCIEA(this.PMOOKOALAEN, this.PMOOKOALAEN, this.bluriness, 0, this.maxBlurSpread);
			}
			this.JBBAHGKAIFF.SetTexture("_TapLow", this.PMOOKOALAEN);
			this.JBBAHGKAIFF.SetTexture("_TapMedium", this.AMJHOJBNFOM);
			Graphics.Blit(null, this.NPAPJCDHNJH, this.JBBAHGKAIFF, 3);
			if (this.bokeh && (DepthOfFieldDeprecated.JKENGKAOIOD.Foreground & this.bokehDestination) != (DepthOfFieldDeprecated.JKENGKAOIOD)0)
			{
				this.BBHBPFNGPHB(this.EEKFJNKCLFF, this.MNNMCBKBBKL, this.NPAPJCDHNJH);
			}
			this.HOEHDBIHELI.SetTexture("_TapLowBackground", this.NPAPJCDHNJH);
			this.HOEHDBIHELI.SetTexture("_TapMedium", this.AMJHOJBNFOM);
			Graphics.Blit(JONJODLFAEN, flag ? this.DPJPOEMKIPJ : OKIIDHIJBEA, this.HOEHDBIHELI, this.visualize ? 2 : 0);
			if (flag)
			{
				Graphics.Blit(this.DPJPOEMKIPJ, JONJODLFAEN, this.HOEHDBIHELI, 5);
				this.ANNEMHGIHAI(JONJODLFAEN, this.AMJHOJBNFOM);
				this.IKBBMEPACEM(this.AMJHOJBNFOM, this.AMJHOJBNFOM, DepthOfFieldDeprecated.BMEMFJFOHOJ.Low, 2, this.maxBlurSpread);
				if (this.bokeh && (DepthOfFieldDeprecated.JKENGKAOIOD.Foreground & this.bokehDestination) != (DepthOfFieldDeprecated.JKENGKAOIOD)0)
				{
					this.HOEHDBIHELI.SetVector("_Threshhold", new Vector4(this.bokehThresholdContrast * 0.5f, this.bokehThresholdLuminance, 0f, 0f));
					Graphics.Blit(this.AMJHOJBNFOM, this.EEKFJNKCLFF, this.HOEHDBIHELI, 11);
					Graphics.Blit(this.AMJHOJBNFOM, this.PMOOKOALAEN);
					this.IKBBMEPACEM(this.PMOOKOALAEN, this.PMOOKOALAEN, this.bluriness, 1, this.maxBlurSpread * num);
				}
				else
				{
					this.IKBBMEPACEM(this.AMJHOJBNFOM, this.PMOOKOALAEN, this.bluriness, 1, this.maxBlurSpread);
				}
				Graphics.Blit(this.PMOOKOALAEN, this.NPAPJCDHNJH);
				this.HOEHDBIHELI.SetTexture("_TapLowForeground", this.NPAPJCDHNJH);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HOEHDBIHELI, this.visualize ? 1 : 4);
				if (this.bokeh && (DepthOfFieldDeprecated.JKENGKAOIOD.Foreground & this.bokehDestination) != (DepthOfFieldDeprecated.JKENGKAOIOD)0)
				{
					this.BBHBPFNGPHB(this.EEKFJNKCLFF, this.MNNMCBKBBKL, OKIIDHIJBEA);
				}
			}
			this.CBOBDAPLEFC();
		}

		// Token: 0x0600B6FD RID: 46845 RVA: 0x00516C20 File Offset: 0x00514E20
		private float HPMAEMNIEDO(float DFCBOEMAOIJ)
		{
			return this.OMIJMALCLAG.WorldToViewportPoint((DFCBOEMAOIJ - this.OMIJMALCLAG.nearClipPlane) * this.OMIJMALCLAG.transform.forward + this.OMIJMALCLAG.transform.position).z / (this.OMIJMALCLAG.farClipPlane - this.OMIJMALCLAG.nearClipPlane);
		}

		// Token: 0x0600B6FE RID: 46846 RVA: 0x00516C8C File Offset: 0x00514E8C
		private void DLGILIAMFNP()
		{
			if (this.DPJPOEMKIPJ)
			{
				RenderTexture.ReleaseTemporary(this.DPJPOEMKIPJ);
			}
			if (this.NPAPJCDHNJH)
			{
				RenderTexture.ReleaseTemporary(this.NPAPJCDHNJH);
			}
			if (this.AMJHOJBNFOM)
			{
				RenderTexture.ReleaseTemporary(this.AMJHOJBNFOM);
			}
			if (this.PMOOKOALAEN)
			{
				RenderTexture.ReleaseTemporary(this.PMOOKOALAEN);
			}
			if (this.MNNMCBKBBKL)
			{
				RenderTexture.ReleaseTemporary(this.MNNMCBKBBKL);
			}
			if (this.EEKFJNKCLFF)
			{
				RenderTexture.ReleaseTemporary(this.EEKFJNKCLFF);
			}
		}

		// Token: 0x0600B6FF RID: 46847 RVA: 0x00516D2C File Offset: 0x00514F2C
		private void DFOACIOMGKO(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ, DepthOfFieldDeprecated.BMEMFJFOHOJ DPBMPHJBLBO, int AGNBHDBHKCJ, float GLJOIOBPAEP)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(LJGGOANMJAJ.width, LJGGOANMJAJ.height);
			if (DPBMPHJBLBO > (DepthOfFieldDeprecated.BMEMFJFOHOJ)0)
			{
				this.PHDGHMAKPEF(GMNLJGNOKPD, LJGGOANMJAJ, AGNBHDBHKCJ, GLJOIOBPAEP, temporary);
				if (DPBMPHJBLBO > DepthOfFieldDeprecated.BMEMFJFOHOJ.Low)
				{
					this.JBBAHGKAIFF.SetVector("CrouchWalk", new Vector4(1602f, GLJOIOBPAEP * this.OFJHPNCEPHN, 1050f, 1648f));
					Graphics.Blit(LJGGOANMJAJ, temporary, this.JBBAHGKAIFF, AGNBHDBHKCJ);
					this.JBBAHGKAIFF.SetVector("time_format1", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 1806f, 1715f, 1409f));
					Graphics.Blit(temporary, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
				}
			}
			else
			{
				this.JBBAHGKAIFF.SetVector("knopje.wav", new Vector4(188f, GLJOIOBPAEP * this.OFJHPNCEPHN, 664f, 863f));
				Graphics.Blit(GMNLJGNOKPD, temporary, this.JBBAHGKAIFF, AGNBHDBHKCJ);
				this.JBBAHGKAIFF.SetVector("</color>", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 1342f, 1341f, 430f));
				Graphics.Blit(temporary, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600B700 RID: 46848 RVA: 0x00516E6C File Offset: 0x0051506C
		private void IOLONNPMIAC(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.HOEHDBIHELI.SetVector("_FogHeight", new Vector4(1969f / (1410f * (float)LJGGOANMJAJ.width), 1438f / (1409f * (float)LJGGOANMJAJ.height), 1250f, 5f));
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.HOEHDBIHELI, DepthOfFieldDeprecated.AKEBHPEEABH);
		}

		// Token: 0x0600B701 RID: 46849 RVA: 0x00516ED0 File Offset: 0x005150D0
		private void GNGEHNGBIDL(bool OHDMEDCBPAA, RenderTexture JONJODLFAEN, int JODELFPOKMJ, int BCGMAMHHLFF)
		{
			this.DPJPOEMKIPJ = null;
			if (OHDMEDCBPAA)
			{
				this.DPJPOEMKIPJ = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0);
			}
			this.AMJHOJBNFOM = RenderTexture.GetTemporary(JONJODLFAEN.width / JODELFPOKMJ, JONJODLFAEN.height / JODELFPOKMJ, 0);
			this.NPAPJCDHNJH = RenderTexture.GetTemporary(JONJODLFAEN.width / JODELFPOKMJ, JONJODLFAEN.height / JODELFPOKMJ, 0);
			this.PMOOKOALAEN = RenderTexture.GetTemporary(JONJODLFAEN.width / BCGMAMHHLFF, JONJODLFAEN.height / BCGMAMHHLFF, 0);
			this.MNNMCBKBBKL = null;
			this.EEKFJNKCLFF = null;
			if (this.bokeh)
			{
				this.MNNMCBKBBKL = RenderTexture.GetTemporary(JONJODLFAEN.width / (BCGMAMHHLFF * this.bokehDownsample), JONJODLFAEN.height / (BCGMAMHHLFF * this.bokehDownsample), 0, RenderTextureFormat.ARGBHalf);
				this.EEKFJNKCLFF = RenderTexture.GetTemporary(JONJODLFAEN.width / (BCGMAMHHLFF * this.bokehDownsample), JONJODLFAEN.height / (BCGMAMHHLFF * this.bokehDownsample), 0, RenderTextureFormat.ARGBHalf);
				this.MNNMCBKBBKL.filterMode = FilterMode.Bilinear;
				this.EEKFJNKCLFF.filterMode = FilterMode.Bilinear;
				RenderTexture.active = this.EEKFJNKCLFF;
				GL.Clear(false, true, new Color(0f, 0f, 0f, 0f));
			}
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			this.NPAPJCDHNJH.filterMode = FilterMode.Bilinear;
			this.AMJHOJBNFOM.filterMode = FilterMode.Bilinear;
			this.PMOOKOALAEN.filterMode = FilterMode.Bilinear;
			if (this.DPJPOEMKIPJ)
			{
				this.DPJPOEMKIPJ.filterMode = FilterMode.Bilinear;
			}
		}

		// Token: 0x0600B702 RID: 46850 RVA: 0x0051704F File Offset: 0x0051524F
		private void OJAIBDJPLHA()
		{
			LBMNBHPBAPJ.CFPFMLJJLAL();
		}

		// Token: 0x0600B703 RID: 46851 RVA: 0x00517058 File Offset: 0x00515258
		private void GDEIAPKNLOH(RenderTexture EEECFBAIFAN, RenderTexture MMNMAEGCJBB, RenderTexture AEMBFNBJDAC)
		{
			if (this.JNFMKGDGJEA)
			{
				Mesh[] array = LBMNBHPBAPJ.FCMBLCNGAIL(MMNMAEGCJBB.width, MMNMAEGCJBB.height);
				RenderTexture.active = MMNMAEGCJBB;
				GL.Clear(true, true, new Color(754f, 98f, 92f, 917f));
				GL.PushMatrix();
				GL.LoadIdentity();
				EEECFBAIFAN.filterMode = FilterMode.Point;
				float num = (float)EEECFBAIFAN.width * 851f / ((float)EEECFBAIFAN.height * 1734f);
				float num2 = 754f / (1439f * (float)EEECFBAIFAN.width);
				num2 += this.bokehScale * this.maxBlurSpread * DepthOfFieldDeprecated.IHIEFLOIANN * this.OFJHPNCEPHN;
				this.JNFMKGDGJEA.SetTexture("SuicideHeadShot", EEECFBAIFAN);
				this.JNFMKGDGJEA.SetTexture("OneHandSwordRun", this.bokehTexture);
				this.JNFMKGDGJEA.SetVector("CD", new Vector4(num2, num2 * num, 1379f, 1948f * num));
				this.JNFMKGDGJEA.SetFloat("206000", this.bokehIntensity);
				this.JNFMKGDGJEA.SetPass(0);
				Mesh[] array2 = array;
				for (int i = 1; i < array2.Length; i += 0)
				{
					Mesh mesh = array2[i];
					if (mesh)
					{
						Graphics.DrawMeshNow(mesh, Matrix4x4.identity);
					}
				}
				GL.PopMatrix();
				Graphics.Blit(MMNMAEGCJBB, AEMBFNBJDAC, this.HOEHDBIHELI, 5);
				EEECFBAIFAN.filterMode = FilterMode.Bilinear;
			}
		}

		// Token: 0x0600B704 RID: 46852 RVA: 0x005171BC File Offset: 0x005153BC
		private void EMDOHHAACKK(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ, DepthOfFieldDeprecated.BMEMFJFOHOJ DPBMPHJBLBO, int AGNBHDBHKCJ, float GLJOIOBPAEP)
		{
			this.JBBAHGKAIFF.SetTexture("_WhiteBalance", GMNLJGNOKPD);
			RenderTexture temporary = RenderTexture.GetTemporary(LJGGOANMJAJ.width, LJGGOANMJAJ.height);
			if (DPBMPHJBLBO > (DepthOfFieldDeprecated.BMEMFJFOHOJ)0)
			{
				this.PHDGHMAKPEF(GMNLJGNOKPD, LJGGOANMJAJ, AGNBHDBHKCJ, GLJOIOBPAEP, temporary);
				if (DPBMPHJBLBO > (DepthOfFieldDeprecated.BMEMFJFOHOJ)0)
				{
					this.JBBAHGKAIFF.SetVector("WalkInjured", new Vector4(1350f, GLJOIOBPAEP * this.OFJHPNCEPHN, 1575f, 1071f));
					Graphics.Blit(LJGGOANMJAJ, temporary, this.JBBAHGKAIFF, AGNBHDBHKCJ);
					this.JBBAHGKAIFF.SetVector("_MinVelocity", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 1348f, 1098f, 78f));
					Graphics.Blit(temporary, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
				}
			}
			else
			{
				this.JBBAHGKAIFF.SetVector("Vertical", new Vector4(1627f, GLJOIOBPAEP * this.OFJHPNCEPHN, 1693f, 858f));
				Graphics.Blit(GMNLJGNOKPD, temporary, this.JBBAHGKAIFF, AGNBHDBHKCJ);
				this.JBBAHGKAIFF.SetVector("+{0}", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 1000f, 920f, 1439f));
				Graphics.Blit(temporary, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600B705 RID: 46853 RVA: 0x00517310 File Offset: 0x00515510
		private void PDPNADDNANB(RenderTexture EEECFBAIFAN, RenderTexture MMNMAEGCJBB, RenderTexture AEMBFNBJDAC)
		{
			if (this.JNFMKGDGJEA)
			{
				Mesh[] array = LBMNBHPBAPJ.CDPHCEKINEB(MMNMAEGCJBB.width, MMNMAEGCJBB.height);
				RenderTexture.active = MMNMAEGCJBB;
				GL.Clear(true, true, new Color(529f, 861f, 1733f, 410f));
				GL.PushMatrix();
				GL.LoadIdentity();
				EEECFBAIFAN.filterMode = FilterMode.Bilinear;
				float num = (float)EEECFBAIFAN.width * 843f / ((float)EEECFBAIFAN.height * 1568f);
				float num2 = 1910f / (1942f * (float)EEECFBAIFAN.width);
				num2 += this.bokehScale * this.maxBlurSpread * DepthOfFieldDeprecated.IHIEFLOIANN * this.OFJHPNCEPHN;
				this.JNFMKGDGJEA.SetTexture("D:/NET_Poligon/ServerPhotonAF2/AFCServer/assets/Data/", EEECFBAIFAN);
				this.JNFMKGDGJEA.SetTexture("_1.png", this.bokehTexture);
				this.JNFMKGDGJEA.SetVector("_SSAO", new Vector4(num2, num2 * num, 10f, 1688f * num));
				this.JNFMKGDGJEA.SetFloat("Windmill", this.bokehIntensity);
				this.JNFMKGDGJEA.SetPass(1);
				foreach (Mesh mesh in array)
				{
					if (mesh)
					{
						Graphics.DrawMeshNow(mesh, Matrix4x4.identity);
					}
				}
				GL.PopMatrix();
				Graphics.Blit(MMNMAEGCJBB, AEMBFNBJDAC, this.HOEHDBIHELI, 3);
				EEECFBAIFAN.filterMode = FilterMode.Bilinear;
			}
		}

		// Token: 0x0600B706 RID: 46854 RVA: 0x00517474 File Offset: 0x00515674
		private int PBFKBFCEBBK(int MAFGPALKEJE)
		{
			int num = MAFGPALKEJE;
			if (this.resolution == DepthOfFieldDeprecated.EDNECHKAFDC.Low)
			{
				num *= 7;
			}
			if (this.resolution == (DepthOfFieldDeprecated.EDNECHKAFDC)1)
			{
				num *= 5;
			}
			return num;
		}

		// Token: 0x0600B707 RID: 46855 RVA: 0x0051749E File Offset: 0x0051569E
		private void IOPEDDLLPPL()
		{
			LBMNBHPBAPJ.MJDKCNHFPNP();
		}

		// Token: 0x0600B708 RID: 46856 RVA: 0x005174A8 File Offset: 0x005156A8
		private void MFHHCGCHLCD()
		{
			if (this.DPJPOEMKIPJ)
			{
				RenderTexture.ReleaseTemporary(this.DPJPOEMKIPJ);
			}
			if (this.NPAPJCDHNJH)
			{
				RenderTexture.ReleaseTemporary(this.NPAPJCDHNJH);
			}
			if (this.AMJHOJBNFOM)
			{
				RenderTexture.ReleaseTemporary(this.AMJHOJBNFOM);
			}
			if (this.PMOOKOALAEN)
			{
				RenderTexture.ReleaseTemporary(this.PMOOKOALAEN);
			}
			if (this.MNNMCBKBBKL)
			{
				RenderTexture.ReleaseTemporary(this.MNNMCBKBBKL);
			}
			if (this.EEKFJNKCLFF)
			{
				RenderTexture.ReleaseTemporary(this.EEKFJNKCLFF);
			}
		}

		// Token: 0x0600B709 RID: 46857 RVA: 0x00513657 File Offset: 0x00511857
		private void EMOFOHBMJBD()
		{
			this.OMIJMALCLAG = base.GetComponent<Camera>();
			this.OMIJMALCLAG.depthTextureMode |= DepthTextureMode.None;
		}

		// Token: 0x0600B70A RID: 46858 RVA: 0x00517548 File Offset: 0x00515748
		private void OBDADAIIPCB()
		{
			if (this.DPJPOEMKIPJ)
			{
				RenderTexture.ReleaseTemporary(this.DPJPOEMKIPJ);
			}
			if (this.NPAPJCDHNJH)
			{
				RenderTexture.ReleaseTemporary(this.NPAPJCDHNJH);
			}
			if (this.AMJHOJBNFOM)
			{
				RenderTexture.ReleaseTemporary(this.AMJHOJBNFOM);
			}
			if (this.PMOOKOALAEN)
			{
				RenderTexture.ReleaseTemporary(this.PMOOKOALAEN);
			}
			if (this.MNNMCBKBBKL)
			{
				RenderTexture.ReleaseTemporary(this.MNNMCBKBBKL);
			}
			if (this.EEKFJNKCLFF)
			{
				RenderTexture.ReleaseTemporary(this.EEKFJNKCLFF);
			}
		}

		// Token: 0x0600B70B RID: 46859 RVA: 0x005175E8 File Offset: 0x005157E8
		private void EHKMMJMCIEA(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ, DepthOfFieldDeprecated.BMEMFJFOHOJ DPBMPHJBLBO, int AGNBHDBHKCJ, float GLJOIOBPAEP)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(LJGGOANMJAJ.width, LJGGOANMJAJ.height);
			if (DPBMPHJBLBO > DepthOfFieldDeprecated.BMEMFJFOHOJ.Low)
			{
				this.PHDGHMAKPEF(GMNLJGNOKPD, LJGGOANMJAJ, AGNBHDBHKCJ, GLJOIOBPAEP, temporary);
				if (DPBMPHJBLBO > DepthOfFieldDeprecated.BMEMFJFOHOJ.High)
				{
					this.JBBAHGKAIFF.SetVector("offsets", new Vector4(0f, GLJOIOBPAEP * this.OFJHPNCEPHN, 0f, 0f));
					Graphics.Blit(LJGGOANMJAJ, temporary, this.JBBAHGKAIFF, AGNBHDBHKCJ);
					this.JBBAHGKAIFF.SetVector("offsets", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 0f, 0f, 0f));
					Graphics.Blit(temporary, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
				}
			}
			else
			{
				this.JBBAHGKAIFF.SetVector("offsets", new Vector4(0f, GLJOIOBPAEP * this.OFJHPNCEPHN, 0f, 0f));
				Graphics.Blit(GMNLJGNOKPD, temporary, this.JBBAHGKAIFF, AGNBHDBHKCJ);
				this.JBBAHGKAIFF.SetVector("offsets", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 0f, 0f, 0f));
				Graphics.Blit(temporary, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600B70C RID: 46860 RVA: 0x00513657 File Offset: 0x00511857
		private void GCKFILOJHHI()
		{
			this.OMIJMALCLAG = base.GetComponent<Camera>();
			this.OMIJMALCLAG.depthTextureMode |= DepthTextureMode.None;
		}

		// Token: 0x0600B70D RID: 46861 RVA: 0x00517728 File Offset: 0x00515928
		private void NENJELKIBAK(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ, DepthOfFieldDeprecated.BMEMFJFOHOJ DPBMPHJBLBO, int AGNBHDBHKCJ, float GLJOIOBPAEP)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(LJGGOANMJAJ.width, LJGGOANMJAJ.height);
			if (DPBMPHJBLBO > DepthOfFieldDeprecated.BMEMFJFOHOJ.Low)
			{
				this.DOLGADOKOPK(GMNLJGNOKPD, LJGGOANMJAJ, AGNBHDBHKCJ, GLJOIOBPAEP, temporary);
				if (DPBMPHJBLBO > (DepthOfFieldDeprecated.BMEMFJFOHOJ)3)
				{
					this.JBBAHGKAIFF.SetVector("MotorbikeBackwardStand", new Vector4(723f, GLJOIOBPAEP * this.OFJHPNCEPHN, 218f, 1636f));
					Graphics.Blit(LJGGOANMJAJ, temporary, this.JBBAHGKAIFF, AGNBHDBHKCJ);
					this.JBBAHGKAIFF.SetVector("MotorbikeHandstand", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 1240f, 1748f, 1495f));
					Graphics.Blit(temporary, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
				}
			}
			else
			{
				this.JBBAHGKAIFF.SetVector("invn_rec28", new Vector4(134f, GLJOIOBPAEP * this.OFJHPNCEPHN, 1285f, 1613f));
				Graphics.Blit(GMNLJGNOKPD, temporary, this.JBBAHGKAIFF, AGNBHDBHKCJ);
				this.JBBAHGKAIFF.SetVector("size", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 989f, 1107f, 1161f));
				Graphics.Blit(temporary, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600B70E RID: 46862 RVA: 0x00517868 File Offset: 0x00515A68
		private int IEHACJEIEOG()
		{
			int result = 0;
			if (this.resolution == (DepthOfFieldDeprecated.EDNECHKAFDC)6)
			{
				result = 5;
			}
			else if (this.resolution == (DepthOfFieldDeprecated.EDNECHKAFDC)0)
			{
				result = 4;
			}
			return result;
		}

		// Token: 0x0600B70F RID: 46863 RVA: 0x00517890 File Offset: 0x00515A90
		private void IOCPHLHEKPO(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ, DepthOfFieldDeprecated.BMEMFJFOHOJ DPBMPHJBLBO, int AGNBHDBHKCJ, float GLJOIOBPAEP)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(LJGGOANMJAJ.width, LJGGOANMJAJ.height);
			if (DPBMPHJBLBO > (DepthOfFieldDeprecated.BMEMFJFOHOJ)0)
			{
				this.LPPHBNBILAP(GMNLJGNOKPD, LJGGOANMJAJ, AGNBHDBHKCJ, GLJOIOBPAEP, temporary);
				if (DPBMPHJBLBO > (DepthOfFieldDeprecated.BMEMFJFOHOJ)0)
				{
					this.JBBAHGKAIFF.SetVector("GiantGrabIdle", new Vector4(1369f, GLJOIOBPAEP * this.OFJHPNCEPHN, 299f, 685f));
					Graphics.Blit(LJGGOANMJAJ, temporary, this.JBBAHGKAIFF, AGNBHDBHKCJ);
					this.JBBAHGKAIFF.SetVector("IdleStun", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 1995f, 772f, 1965f));
					Graphics.Blit(temporary, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
				}
			}
			else
			{
				this.JBBAHGKAIFF.SetVector("_alfavis", new Vector4(926f, GLJOIOBPAEP * this.OFJHPNCEPHN, 957f, 1645f));
				Graphics.Blit(GMNLJGNOKPD, temporary, this.JBBAHGKAIFF, AGNBHDBHKCJ);
				this.JBBAHGKAIFF.SetVector("demoByteArray", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 982f, 883f, 1962f));
				Graphics.Blit(temporary, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600B710 RID: 46864 RVA: 0x005179D0 File Offset: 0x00515BD0
		private void PHIACAJNNIG()
		{
			LBMNBHPBAPJ.MECANJCGLHL();
		}

		// Token: 0x0600B711 RID: 46865 RVA: 0x005179D8 File Offset: 0x00515BD8
		private void KCFBDDBDFOJ(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.HOEHDBIHELI.SetVector("__c", new Vector4(1298f / (896f * (float)LJGGOANMJAJ.width), 1078f / (1955f * (float)LJGGOANMJAJ.height), 530f, 1315f));
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.HOEHDBIHELI, DepthOfFieldDeprecated.AKEBHPEEABH);
		}

		// Token: 0x0600B712 RID: 46866 RVA: 0x00517A3C File Offset: 0x00515C3C
		private int FLPNBEDDJAO()
		{
			int result = 1;
			if (this.resolution == (DepthOfFieldDeprecated.EDNECHKAFDC)0)
			{
				result = 8;
			}
			else if (this.resolution == DepthOfFieldDeprecated.EDNECHKAFDC.Medium)
			{
				result = 1;
			}
			return result;
		}

		// Token: 0x0600B713 RID: 46867 RVA: 0x00517A64 File Offset: 0x00515C64
		private float AEIAIILBCNO(float DFCBOEMAOIJ)
		{
			return this.OMIJMALCLAG.WorldToViewportPoint((DFCBOEMAOIJ - this.OMIJMALCLAG.nearClipPlane) * this.OMIJMALCLAG.transform.forward + this.OMIJMALCLAG.transform.position).z / (this.OMIJMALCLAG.farClipPlane - this.OMIJMALCLAG.nearClipPlane);
		}

		// Token: 0x0600B714 RID: 46868 RVA: 0x00517AD0 File Offset: 0x00515CD0
		private void AJMCIFICJNA()
		{
			if (this.DPJPOEMKIPJ)
			{
				RenderTexture.ReleaseTemporary(this.DPJPOEMKIPJ);
			}
			if (this.NPAPJCDHNJH)
			{
				RenderTexture.ReleaseTemporary(this.NPAPJCDHNJH);
			}
			if (this.AMJHOJBNFOM)
			{
				RenderTexture.ReleaseTemporary(this.AMJHOJBNFOM);
			}
			if (this.PMOOKOALAEN)
			{
				RenderTexture.ReleaseTemporary(this.PMOOKOALAEN);
			}
			if (this.MNNMCBKBBKL)
			{
				RenderTexture.ReleaseTemporary(this.MNNMCBKBBKL);
			}
			if (this.EEKFJNKCLFF)
			{
				RenderTexture.ReleaseTemporary(this.EEKFJNKCLFF);
			}
		}

		// Token: 0x0600B715 RID: 46869 RVA: 0x00517B70 File Offset: 0x00515D70
		private void CDFPLEOKGHK(bool OHDMEDCBPAA, RenderTexture JONJODLFAEN, int JODELFPOKMJ, int BCGMAMHHLFF)
		{
			this.DPJPOEMKIPJ = null;
			if (OHDMEDCBPAA)
			{
				this.DPJPOEMKIPJ = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 1);
			}
			this.AMJHOJBNFOM = RenderTexture.GetTemporary(JONJODLFAEN.width / JODELFPOKMJ, JONJODLFAEN.height / JODELFPOKMJ, 0);
			this.NPAPJCDHNJH = RenderTexture.GetTemporary(JONJODLFAEN.width / JODELFPOKMJ, JONJODLFAEN.height / JODELFPOKMJ, 1);
			this.PMOOKOALAEN = RenderTexture.GetTemporary(JONJODLFAEN.width / BCGMAMHHLFF, JONJODLFAEN.height / BCGMAMHHLFF, 0);
			this.MNNMCBKBBKL = null;
			this.EEKFJNKCLFF = null;
			if (this.bokeh)
			{
				this.MNNMCBKBBKL = RenderTexture.GetTemporary(JONJODLFAEN.width / (BCGMAMHHLFF * this.bokehDownsample), JONJODLFAEN.height / (BCGMAMHHLFF * this.bokehDownsample), 1, RenderTextureFormat.ARGB2101010);
				this.EEKFJNKCLFF = RenderTexture.GetTemporary(JONJODLFAEN.width / (BCGMAMHHLFF * this.bokehDownsample), JONJODLFAEN.height / (BCGMAMHHLFF * this.bokehDownsample), 0, RenderTextureFormat.ARGB2101010);
				this.MNNMCBKBBKL.filterMode = FilterMode.Point;
				this.EEKFJNKCLFF.filterMode = FilterMode.Point;
				RenderTexture.active = this.EEKFJNKCLFF;
				GL.Clear(true, true, new Color(1024f, 1050f, 242f, 95f));
			}
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			this.NPAPJCDHNJH.filterMode = FilterMode.Point;
			this.AMJHOJBNFOM.filterMode = FilterMode.Bilinear;
			this.PMOOKOALAEN.filterMode = FilterMode.Bilinear;
			if (this.DPJPOEMKIPJ)
			{
				this.DPJPOEMKIPJ.filterMode = FilterMode.Point;
			}
		}

		// Token: 0x0600B716 RID: 46870 RVA: 0x00517CF0 File Offset: 0x00515EF0
		private void AFEFPJOIELM(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ, DepthOfFieldDeprecated.BMEMFJFOHOJ DPBMPHJBLBO, int AGNBHDBHKCJ, float GLJOIOBPAEP)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(LJGGOANMJAJ.width, LJGGOANMJAJ.height);
			if (DPBMPHJBLBO > (DepthOfFieldDeprecated.BMEMFJFOHOJ)0)
			{
				this.GGEIHKBPLGD(GMNLJGNOKPD, LJGGOANMJAJ, AGNBHDBHKCJ, GLJOIOBPAEP, temporary);
				if (DPBMPHJBLBO > DepthOfFieldDeprecated.BMEMFJFOHOJ.High)
				{
					this.JBBAHGKAIFF.SetVector("turn_tminfo", new Vector4(1164f, GLJOIOBPAEP * this.OFJHPNCEPHN, 1656f, 1077f));
					Graphics.Blit(LJGGOANMJAJ, temporary, this.JBBAHGKAIFF, AGNBHDBHKCJ);
					this.JBBAHGKAIFF.SetVector("Handstand", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 1575f, 163f, 1540f));
					Graphics.Blit(temporary, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
				}
			}
			else
			{
				this.JBBAHGKAIFF.SetVector("WizardNeoBlock", new Vector4(609f, GLJOIOBPAEP * this.OFJHPNCEPHN, 369f, 247f));
				Graphics.Blit(GMNLJGNOKPD, temporary, this.JBBAHGKAIFF, AGNBHDBHKCJ);
				this.JBBAHGKAIFF.SetVector("#303030", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 1190f, 368f, 522f));
				Graphics.Blit(temporary, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600B717 RID: 46871 RVA: 0x00517E30 File Offset: 0x00516030
		private void LGPHHALMHNL(bool OHDMEDCBPAA, RenderTexture JONJODLFAEN, int JODELFPOKMJ, int BCGMAMHHLFF)
		{
			this.DPJPOEMKIPJ = null;
			if (OHDMEDCBPAA)
			{
				this.DPJPOEMKIPJ = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 1);
			}
			this.AMJHOJBNFOM = RenderTexture.GetTemporary(JONJODLFAEN.width / JODELFPOKMJ, JONJODLFAEN.height / JODELFPOKMJ, 1);
			this.NPAPJCDHNJH = RenderTexture.GetTemporary(JONJODLFAEN.width / JODELFPOKMJ, JONJODLFAEN.height / JODELFPOKMJ, 0);
			this.PMOOKOALAEN = RenderTexture.GetTemporary(JONJODLFAEN.width / BCGMAMHHLFF, JONJODLFAEN.height / BCGMAMHHLFF, 1);
			this.MNNMCBKBBKL = null;
			this.EEKFJNKCLFF = null;
			if (this.bokeh)
			{
				this.MNNMCBKBBKL = RenderTexture.GetTemporary(JONJODLFAEN.width / (BCGMAMHHLFF * this.bokehDownsample), JONJODLFAEN.height / (BCGMAMHHLFF * this.bokehDownsample), 1, RenderTextureFormat.ARGB2101010);
				this.EEKFJNKCLFF = RenderTexture.GetTemporary(JONJODLFAEN.width / (BCGMAMHHLFF * this.bokehDownsample), JONJODLFAEN.height / (BCGMAMHHLFF * this.bokehDownsample), 1, RenderTextureFormat.ARGB2101010);
				this.MNNMCBKBBKL.filterMode = FilterMode.Point;
				this.EEKFJNKCLFF.filterMode = FilterMode.Point;
				RenderTexture.active = this.EEKFJNKCLFF;
				GL.Clear(true, false, new Color(1244f, 375f, 182f, 696f));
			}
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			this.NPAPJCDHNJH.filterMode = FilterMode.Bilinear;
			this.AMJHOJBNFOM.filterMode = FilterMode.Bilinear;
			this.PMOOKOALAEN.filterMode = FilterMode.Bilinear;
			if (this.DPJPOEMKIPJ)
			{
				this.DPJPOEMKIPJ.filterMode = FilterMode.Bilinear;
			}
		}

		// Token: 0x0600B718 RID: 46872 RVA: 0x00517FB0 File Offset: 0x005161B0
		private void LCMGBONCKHA(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ, int AGNBHDBHKCJ, float GLJOIOBPAEP, RenderTexture KBNKJKBDCLN)
		{
			this.JBBAHGKAIFF.SetVector(": ", new Vector4(904f, GLJOIOBPAEP * this.OFJHPNCEPHN, 1467f, 1112f));
			Graphics.Blit(GMNLJGNOKPD, KBNKJKBDCLN, this.JBBAHGKAIFF, AGNBHDBHKCJ);
			this.JBBAHGKAIFF.SetVector("IceHockeyShotRight", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, 256f, 1436f, 1588f));
			Graphics.Blit(KBNKJKBDCLN, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
			this.JBBAHGKAIFF.SetVector("Actor_{0}_{1}_ragula", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, GLJOIOBPAEP * this.OFJHPNCEPHN, 1921f, 558f));
			Graphics.Blit(LJGGOANMJAJ, KBNKJKBDCLN, this.JBBAHGKAIFF, AGNBHDBHKCJ);
			this.JBBAHGKAIFF.SetVector("OK aukKeyMEditOk", new Vector4(GLJOIOBPAEP / this.KDJDAGBLCMA * this.OFJHPNCEPHN, -GLJOIOBPAEP * this.OFJHPNCEPHN, 1942f, 1010f));
			Graphics.Blit(KBNKJKBDCLN, LJGGOANMJAJ, this.JBBAHGKAIFF, AGNBHDBHKCJ);
		}

		// Token: 0x0600B719 RID: 46873 RVA: 0x005180CC File Offset: 0x005162CC
		private int COKEPKHALEN()
		{
			int result = 0;
			if (this.resolution == (DepthOfFieldDeprecated.EDNECHKAFDC)6)
			{
				result = 3;
			}
			else if (this.resolution == DepthOfFieldDeprecated.EDNECHKAFDC.High)
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x0600B71A RID: 46874 RVA: 0x005180F4 File Offset: 0x005162F4
		private void LBEABCKIHNM(RenderTexture EEECFBAIFAN, RenderTexture MMNMAEGCJBB, RenderTexture AEMBFNBJDAC)
		{
			if (this.JNFMKGDGJEA)
			{
				Mesh[] array = LBMNBHPBAPJ.PBNNAGFMJPA(MMNMAEGCJBB.width, MMNMAEGCJBB.height);
				RenderTexture.active = MMNMAEGCJBB;
				GL.Clear(true, false, new Color(477f, 1254f, 181f, 1867f));
				GL.PushMatrix();
				GL.LoadIdentity();
				EEECFBAIFAN.filterMode = FilterMode.Bilinear;
				float num = (float)EEECFBAIFAN.width * 617f / ((float)EEECFBAIFAN.height * 1239f);
				float num2 = 1892f / (1780f * (float)EEECFBAIFAN.width);
				num2 += this.bokehScale * this.maxBlurSpread * DepthOfFieldDeprecated.IHIEFLOIANN * this.OFJHPNCEPHN;
				this.JNFMKGDGJEA.SetTexture("* read base id=", EEECFBAIFAN);
				this.JNFMKGDGJEA.SetTexture("Bases/{0}/", this.bokehTexture);
				this.JNFMKGDGJEA.SetVector("WeaponStand", new Vector4(num2, num2 * num, 1847f, 1310f * num));
				this.JNFMKGDGJEA.SetFloat("11", this.bokehIntensity);
				this.JNFMKGDGJEA.SetPass(1);
				Mesh[] array2 = array;
				for (int i = 1; i < array2.Length; i++)
				{
					Mesh mesh = array2[i];
					if (mesh)
					{
						Graphics.DrawMeshNow(mesh, Matrix4x4.identity);
					}
				}
				GL.PopMatrix();
				Graphics.Blit(MMNMAEGCJBB, AEMBFNBJDAC, this.HOEHDBIHELI, 4);
				EEECFBAIFAN.filterMode = FilterMode.Point;
			}
		}

		// Token: 0x0600B71B RID: 46875 RVA: 0x00518258 File Offset: 0x00516458
		private void LLFANOGKPKM()
		{
			LBMNBHPBAPJ.AAKDPADNKOM();
		}

		// Token: 0x0600B71D RID: 46877 RVA: 0x00518274 File Offset: 0x00516474
		private void DHJHEGHEGOH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.IGJKBOMMMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.smoothness < 888f)
			{
				this.smoothness = 1520f;
			}
			this.bokeh = (!this.bokeh || this.bokehSupport);
			float num = this.bokeh ? DepthOfFieldDeprecated.IHIEFLOIANN : 34f;
			bool flag = this.quality > DepthOfFieldDeprecated.NBLDEAGICCP.OnlyBackground;
			float num2 = this.focalSize / (this.OMIJMALCLAG.farClipPlane - this.OMIJMALCLAG.nearClipPlane);
			if (this.simpleTweakMode)
			{
				this.MHJDKBOLOBD = (this.objectFocus ? (this.OMIJMALCLAG.WorldToViewportPoint(this.objectFocus.position).z / this.OMIJMALCLAG.farClipPlane) : this.AEIAIILBCNO(this.focalPoint));
				this.DINBPHKCLEB = this.MHJDKBOLOBD * this.smoothness;
				this.PKANLIIHMBF = this.DINBPHKCLEB;
				flag = (!flag || this.focalPoint > this.OMIJMALCLAG.nearClipPlane + Mathf.Epsilon);
			}
			else
			{
				if (this.objectFocus)
				{
					Vector3 vector = this.OMIJMALCLAG.WorldToViewportPoint(this.objectFocus.position);
					vector.z /= this.OMIJMALCLAG.farClipPlane;
					this.MHJDKBOLOBD = vector.z;
				}
				else
				{
					this.MHJDKBOLOBD = this.KOMIKNHHBML(this.focalZDistance);
				}
				this.DINBPHKCLEB = this.focalZStartCurve;
				this.PKANLIIHMBF = this.focalZEndCurve;
				flag = (flag && this.focalPoint > this.OMIJMALCLAG.nearClipPlane + Mathf.Epsilon);
			}
			this.KDJDAGBLCMA = 750f * (float)JONJODLFAEN.width / (1470f * (float)JONJODLFAEN.height);
			this.OFJHPNCEPHN = 487f;
			this.HOEHDBIHELI.SetFloat(" ", this.foregroundBlurExtrude);
			this.HOEHDBIHELI.SetVector("_MaxRayTraceDistance", new Vector4(this.simpleTweakMode ? (1864f / this.DINBPHKCLEB) : this.DINBPHKCLEB, this.simpleTweakMode ? (461f / this.PKANLIIHMBF) : this.PKANLIIHMBF, num2 * 1141f, this.MHJDKBOLOBD));
			this.HOEHDBIHELI.SetVector("_BlurRadius4", new Vector4(1804f / (223f * (float)JONJODLFAEN.width), 491f / (673f * (float)JONJODLFAEN.height), 1207f, 1796f));
			int num3 = this.DOKLINHGFLD();
			int bcgmamhhlff = this.PDOFEIGMLMM(num3);
			this.LGPHHALMHNL(flag, JONJODLFAEN, num3, bcgmamhhlff);
			Graphics.Blit(JONJODLFAEN, JONJODLFAEN, this.HOEHDBIHELI, 0);
			this.EGMKNHDOOED(JONJODLFAEN, this.AMJHOJBNFOM);
			this.LKCMKEHCLJA(this.AMJHOJBNFOM, this.AMJHOJBNFOM, (DepthOfFieldDeprecated.BMEMFJFOHOJ)0, 3, this.maxBlurSpread);
			if (this.bokeh && (DepthOfFieldDeprecated.JKENGKAOIOD.BackgroundAndForeground & this.bokehDestination) != (DepthOfFieldDeprecated.JKENGKAOIOD)0)
			{
				this.HOEHDBIHELI.SetVector("CraftProf.xml", new Vector4(this.bokehThresholdContrast, this.bokehThresholdLuminance, 1568f, 91f));
				Graphics.Blit(this.AMJHOJBNFOM, this.EEKFJNKCLFF, this.HOEHDBIHELI, 46);
				Graphics.Blit(this.AMJHOJBNFOM, this.PMOOKOALAEN);
				this.EHKMMJMCIEA(this.PMOOKOALAEN, this.PMOOKOALAEN, this.bluriness, 1, this.maxBlurSpread * num);
			}
			else
			{
				this.DKDINEMFCJB(this.AMJHOJBNFOM, this.PMOOKOALAEN);
				this.AFEFPJOIELM(this.PMOOKOALAEN, this.PMOOKOALAEN, this.bluriness, 0, this.maxBlurSpread);
			}
			this.JBBAHGKAIFF.SetTexture("money", this.PMOOKOALAEN);
			this.JBBAHGKAIFF.SetTexture("isRodOpen", this.AMJHOJBNFOM);
			Graphics.Blit(null, this.NPAPJCDHNJH, this.JBBAHGKAIFF, 1);
			if (this.bokeh && (DepthOfFieldDeprecated.JKENGKAOIOD.BackgroundAndForeground & this.bokehDestination) != (DepthOfFieldDeprecated.JKENGKAOIOD)0)
			{
				this.FLFEOHPMPLF(this.EEKFJNKCLFF, this.MNNMCBKBBKL, this.NPAPJCDHNJH);
			}
			this.HOEHDBIHELI.SetTexture("Arm Flex 3", this.NPAPJCDHNJH);
			this.HOEHDBIHELI.SetTexture("Press E to resume interaction", this.AMJHOJBNFOM);
			Graphics.Blit(JONJODLFAEN, flag ? this.DPJPOEMKIPJ : OKIIDHIJBEA, this.HOEHDBIHELI, this.visualize ? 7 : 0);
			if (flag)
			{
				Graphics.Blit(this.DPJPOEMKIPJ, JONJODLFAEN, this.HOEHDBIHELI, 6);
				this.IOLONNPMIAC(JONJODLFAEN, this.AMJHOJBNFOM);
				this.KPDHFELPIDD(this.AMJHOJBNFOM, this.AMJHOJBNFOM, (DepthOfFieldDeprecated.BMEMFJFOHOJ)0, 6, this.maxBlurSpread);
				if (this.bokeh && ((DepthOfFieldDeprecated.JKENGKAOIOD)7 & this.bokehDestination) != (DepthOfFieldDeprecated.JKENGKAOIOD)0)
				{
					this.HOEHDBIHELI.SetVector("", new Vector4(this.bokehThresholdContrast * 1691f, this.bokehThresholdLuminance, 1104f, 1746f));
					Graphics.Blit(this.AMJHOJBNFOM, this.EEKFJNKCLFF, this.HOEHDBIHELI, 97);
					Graphics.Blit(this.AMJHOJBNFOM, this.PMOOKOALAEN);
					this.ICGFCHGLIGB(this.PMOOKOALAEN, this.PMOOKOALAEN, this.bluriness, 0, this.maxBlurSpread * num);
				}
				else
				{
					this.FKIJGMFIKNM(this.AMJHOJBNFOM, this.PMOOKOALAEN, this.bluriness, 1, this.maxBlurSpread);
				}
				Graphics.Blit(this.PMOOKOALAEN, this.NPAPJCDHNJH);
				this.HOEHDBIHELI.SetTexture("IceHockeyGoalieSave2", this.NPAPJCDHNJH);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HOEHDBIHELI, this.visualize ? 1 : 3);
				if (this.bokeh && ((DepthOfFieldDeprecated.JKENGKAOIOD)8 & this.bokehDestination) != (DepthOfFieldDeprecated.JKENGKAOIOD)0)
				{
					this.FLFEOHPMPLF(this.EEKFJNKCLFF, this.MNNMCBKBBKL, OKIIDHIJBEA);
				}
			}
			this.CBOBDAPLEFC();
		}

		// Token: 0x0600B71E RID: 46878 RVA: 0x00518834 File Offset: 0x00516A34
		private void EAODOAGNHIK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.smoothness < 212f)
			{
				this.smoothness = 335f;
			}
			this.bokeh = (!this.bokeh || this.bokehSupport);
			float num = this.bokeh ? DepthOfFieldDeprecated.IHIEFLOIANN : 1261f;
			bool flag = this.quality > (DepthOfFieldDeprecated.NBLDEAGICCP)0;
			float num2 = this.focalSize / (this.OMIJMALCLAG.farClipPlane - this.OMIJMALCLAG.nearClipPlane);
			if (this.simpleTweakMode)
			{
				this.MHJDKBOLOBD = (this.objectFocus ? (this.OMIJMALCLAG.WorldToViewportPoint(this.objectFocus.position).z / this.OMIJMALCLAG.farClipPlane) : this.PFDCPKFHPMI(this.focalPoint));
				this.DINBPHKCLEB = this.MHJDKBOLOBD * this.smoothness;
				this.PKANLIIHMBF = this.DINBPHKCLEB;
				flag = (!flag || this.focalPoint > this.OMIJMALCLAG.nearClipPlane + Mathf.Epsilon);
			}
			else
			{
				if (this.objectFocus)
				{
					Vector3 vector = this.OMIJMALCLAG.WorldToViewportPoint(this.objectFocus.position);
					vector.z /= this.OMIJMALCLAG.farClipPlane;
					this.MHJDKBOLOBD = vector.z;
				}
				else
				{
					this.MHJDKBOLOBD = this.PFDCPKFHPMI(this.focalZDistance);
				}
				this.DINBPHKCLEB = this.focalZStartCurve;
				this.PKANLIIHMBF = this.focalZEndCurve;
				flag = (flag && this.focalPoint > this.OMIJMALCLAG.nearClipPlane + Mathf.Epsilon);
			}
			this.KDJDAGBLCMA = 1952f * (float)JONJODLFAEN.width / (1390f * (float)JONJODLFAEN.height);
			this.OFJHPNCEPHN = 744f;
			this.HOEHDBIHELI.SetFloat("Elephant", this.foregroundBlurExtrude);
			this.HOEHDBIHELI.SetVector("auc_reshdr", new Vector4(this.simpleTweakMode ? (884f / this.DINBPHKCLEB) : this.DINBPHKCLEB, this.simpleTweakMode ? (1517f / this.PKANLIIHMBF) : this.PKANLIIHMBF, num2 * 991f, this.MHJDKBOLOBD));
			this.HOEHDBIHELI.SetVector("demoRect", new Vector4(694f / (402f * (float)JONJODLFAEN.width), 564f / (1601f * (float)JONJODLFAEN.height), 1678f, 462f));
			int num3 = this.FFBBEANNHCG();
			int bcgmamhhlff = this.EHKLMGBCCNB(num3);
			this.MDDHOFALLNC(flag, JONJODLFAEN, num3, bcgmamhhlff);
			Graphics.Blit(JONJODLFAEN, JONJODLFAEN, this.HOEHDBIHELI, 7);
			this.IOLONNPMIAC(JONJODLFAEN, this.AMJHOJBNFOM);
			this.HFPKDEPJDBK(this.AMJHOJBNFOM, this.AMJHOJBNFOM, DepthOfFieldDeprecated.BMEMFJFOHOJ.Low, 5, this.maxBlurSpread);
			if (this.bokeh && (DepthOfFieldDeprecated.JKENGKAOIOD.Background & this.bokehDestination) != (DepthOfFieldDeprecated.JKENGKAOIOD)0)
			{
				this.HOEHDBIHELI.SetVector("fshop_fcost2", new Vector4(this.bokehThresholdContrast, this.bokehThresholdLuminance, 1470f, 1770f));
				Graphics.Blit(this.AMJHOJBNFOM, this.EEKFJNKCLFF, this.HOEHDBIHELI, 66);
				Graphics.Blit(this.AMJHOJBNFOM, this.PMOOKOALAEN);
				this.AFFBIKGBBGB(this.PMOOKOALAEN, this.PMOOKOALAEN, this.bluriness, 1, this.maxBlurSpread * num);
			}
			else
			{
				this.EGMKNHDOOED(this.AMJHOJBNFOM, this.PMOOKOALAEN);
				this.IEJJCENDNFP(this.PMOOKOALAEN, this.PMOOKOALAEN, this.bluriness, 0, this.maxBlurSpread);
			}
			this.JBBAHGKAIFF.SetTexture(", Origin} has negative volume. Make sure Axis vector is in the reachable area and the polygon is convex.", this.PMOOKOALAEN);
			this.JBBAHGKAIFF.SetTexture("</color>", this.AMJHOJBNFOM);
			Graphics.Blit(null, this.NPAPJCDHNJH, this.JBBAHGKAIFF, 7);
			if (this.bokeh && ((DepthOfFieldDeprecated.JKENGKAOIOD)8 & this.bokehDestination) != (DepthOfFieldDeprecated.JKENGKAOIOD)0)
			{
				this.PDPNADDNANB(this.EEKFJNKCLFF, this.MNNMCBKBBKL, this.NPAPJCDHNJH);
			}
			this.HOEHDBIHELI.SetTexture("</color>\n", this.NPAPJCDHNJH);
			this.HOEHDBIHELI.SetTexture("OfficeSittingReadingCoffeeSip", this.AMJHOJBNFOM);
			Graphics.Blit(JONJODLFAEN, flag ? this.DPJPOEMKIPJ : OKIIDHIJBEA, this.HOEHDBIHELI, this.visualize ? 5 : 0);
			if (flag)
			{
				Graphics.Blit(this.DPJPOEMKIPJ, JONJODLFAEN, this.HOEHDBIHELI, 1);
				this.CDHKNJMEGMN(JONJODLFAEN, this.AMJHOJBNFOM);
				this.EMDOHHAACKK(this.AMJHOJBNFOM, this.AMJHOJBNFOM, (DepthOfFieldDeprecated.BMEMFJFOHOJ)0, 3, this.maxBlurSpread);
				if (this.bokeh && (DepthOfFieldDeprecated.JKENGKAOIOD.Foreground & this.bokehDestination) != (DepthOfFieldDeprecated.JKENGKAOIOD)0)
				{
					this.HOEHDBIHELI.SetVector("droplinemsg2", new Vector4(this.bokehThresholdContrast * 717f, this.bokehThresholdLuminance, 1024f, 1182f));
					Graphics.Blit(this.AMJHOJBNFOM, this.EEKFJNKCLFF, this.HOEHDBIHELI, 37);
					Graphics.Blit(this.AMJHOJBNFOM, this.PMOOKOALAEN);
					this.FKIJGMFIKNM(this.PMOOKOALAEN, this.PMOOKOALAEN, this.bluriness, 0, this.maxBlurSpread * num);
				}
				else
				{
					this.ODNNCACCNLE(this.AMJHOJBNFOM, this.PMOOKOALAEN, this.bluriness, 0, this.maxBlurSpread);
				}
				Graphics.Blit(this.PMOOKOALAEN, this.NPAPJCDHNJH);
				this.HOEHDBIHELI.SetTexture("FlyDown", this.NPAPJCDHNJH);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HOEHDBIHELI, this.visualize ? 0 : 1);
				if (this.bokeh && ((DepthOfFieldDeprecated.JKENGKAOIOD)6 & this.bokehDestination) != (DepthOfFieldDeprecated.JKENGKAOIOD)0)
				{
					this.DIAKCGFBCOG(this.EEKFJNKCLFF, this.MNNMCBKBBKL, OKIIDHIJBEA);
				}
			}
			this.AJMCIFICJNA();
		}

		// Token: 0x0600B71F RID: 46879 RVA: 0x00518DF4 File Offset: 0x00516FF4
		private void IAPMIJOBNKG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.IGJKBOMMMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.smoothness < 1906f)
			{
				this.smoothness = 1463f;
			}
			this.bokeh = (!this.bokeh || this.bokehSupport);
			float num = this.bokeh ? DepthOfFieldDeprecated.IHIEFLOIANN : 1553f;
			bool flag = this.quality > (DepthOfFieldDeprecated.NBLDEAGICCP)0;
			float num2 = this.focalSize / (this.OMIJMALCLAG.farClipPlane - this.OMIJMALCLAG.nearClipPlane);
			if (this.simpleTweakMode)
			{
				this.MHJDKBOLOBD = (this.objectFocus ? (this.OMIJMALCLAG.WorldToViewportPoint(this.objectFocus.position).z / this.OMIJMALCLAG.farClipPlane) : this.BKJEENDCMCJ(this.focalPoint));
				this.DINBPHKCLEB = this.MHJDKBOLOBD * this.smoothness;
				this.PKANLIIHMBF = this.DINBPHKCLEB;
				flag = (flag && this.focalPoint > this.OMIJMALCLAG.nearClipPlane + Mathf.Epsilon);
			}
			else
			{
				if (this.objectFocus)
				{
					Vector3 vector = this.OMIJMALCLAG.WorldToViewportPoint(this.objectFocus.position);
					vector.z /= this.OMIJMALCLAG.farClipPlane;
					this.MHJDKBOLOBD = vector.z;
				}
				else
				{
					this.MHJDKBOLOBD = this.PBEHPFICPMP(this.focalZDistance);
				}
				this.DINBPHKCLEB = this.focalZStartCurve;
				this.PKANLIIHMBF = this.focalZEndCurve;
				flag = (!flag || this.focalPoint > this.OMIJMALCLAG.nearClipPlane + Mathf.Epsilon);
			}
			this.KDJDAGBLCMA = 1489f * (float)JONJODLFAEN.width / (424f * (float)JONJODLFAEN.height);
			this.OFJHPNCEPHN = 1178f;
			this.HOEHDBIHELI.SetFloat("preservePlayerPrefs", this.foregroundBlurExtrude);
			this.HOEHDBIHELI.SetVector("PaperTurn.wav", new Vector4(this.simpleTweakMode ? (1278f / this.DINBPHKCLEB) : this.DINBPHKCLEB, this.simpleTweakMode ? (25f / this.PKANLIIHMBF) : this.PKANLIIHMBF, num2 * 905f, this.MHJDKBOLOBD));
			this.HOEHDBIHELI.SetVector(": ", new Vector4(1248f / (363f * (float)JONJODLFAEN.width), 1620f / (1208f * (float)JONJODLFAEN.height), 846f, 0f));
			int num3 = this.EIBNMEAGDIM();
			int bcgmamhhlff = this.PBFKBFCEBBK(num3);
			this.HLBBJFBOBCJ(flag, JONJODLFAEN, num3, bcgmamhhlff);
			Graphics.Blit(JONJODLFAEN, JONJODLFAEN, this.HOEHDBIHELI, 8);
			this.KCFBDDBDFOJ(JONJODLFAEN, this.AMJHOJBNFOM);
			this.NENJELKIBAK(this.AMJHOJBNFOM, this.AMJHOJBNFOM, DepthOfFieldDeprecated.BMEMFJFOHOJ.Low, 7, this.maxBlurSpread);
			if (this.bokeh && ((DepthOfFieldDeprecated.JKENGKAOIOD)6 & this.bokehDestination) != (DepthOfFieldDeprecated.JKENGKAOIOD)0)
			{
				this.HOEHDBIHELI.SetVector("512", new Vector4(this.bokehThresholdContrast, this.bokehThresholdLuminance, 35f, 1418f));
				Graphics.Blit(this.AMJHOJBNFOM, this.EEKFJNKCLFF, this.HOEHDBIHELI, -41);
				Graphics.Blit(this.AMJHOJBNFOM, this.PMOOKOALAEN);
				this.IEJJCENDNFP(this.PMOOKOALAEN, this.PMOOKOALAEN, this.bluriness, 1, this.maxBlurSpread * num);
			}
			else
			{
				this.NFGHHDPJCEJ(this.AMJHOJBNFOM, this.PMOOKOALAEN);
				this.EHKMMJMCIEA(this.PMOOKOALAEN, this.PMOOKOALAEN, this.bluriness, 0, this.maxBlurSpread);
			}
			this.JBBAHGKAIFF.SetTexture("WorkerShovel", this.PMOOKOALAEN);
			this.JBBAHGKAIFF.SetTexture("Ankle", this.AMJHOJBNFOM);
			Graphics.Blit(null, this.NPAPJCDHNJH, this.JBBAHGKAIFF, 5);
			if (this.bokeh && ((DepthOfFieldDeprecated.JKENGKAOIOD)8 & this.bokehDestination) != (DepthOfFieldDeprecated.JKENGKAOIOD)0)
			{
				this.LBEABCKIHNM(this.EEKFJNKCLFF, this.MNNMCBKBBKL, this.NPAPJCDHNJH);
			}
			this.HOEHDBIHELI.SetTexture("", this.NPAPJCDHNJH);
			this.HOEHDBIHELI.SetTexture("Near", this.AMJHOJBNFOM);
			Graphics.Blit(JONJODLFAEN, flag ? this.DPJPOEMKIPJ : OKIIDHIJBEA, this.HOEHDBIHELI, this.visualize ? 1 : 0);
			if (flag)
			{
				Graphics.Blit(this.DPJPOEMKIPJ, JONJODLFAEN, this.HOEHDBIHELI, 7);
				this.MAPKKKAPIFE(JONJODLFAEN, this.AMJHOJBNFOM);
				this.KONOOFFNHCD(this.AMJHOJBNFOM, this.AMJHOJBNFOM, (DepthOfFieldDeprecated.BMEMFJFOHOJ)0, 0, this.maxBlurSpread);
				if (this.bokeh && (DepthOfFieldDeprecated.JKENGKAOIOD.Background & this.bokehDestination) != (DepthOfFieldDeprecated.JKENGKAOIOD)0)
				{
					this.HOEHDBIHELI.SetVector("IdleStandingJump", new Vector4(this.bokehThresholdContrast * 304f, this.bokehThresholdLuminance, 1071f, 1083f));
					Graphics.Blit(this.AMJHOJBNFOM, this.EEKFJNKCLFF, this.HOEHDBIHELI, 17);
					Graphics.Blit(this.AMJHOJBNFOM, this.PMOOKOALAEN);
					this.ICGFCHGLIGB(this.PMOOKOALAEN, this.PMOOKOALAEN, this.bluriness, 0, this.maxBlurSpread * num);
				}
				else
				{
					this.FKIJGMFIKNM(this.AMJHOJBNFOM, this.PMOOKOALAEN, this.bluriness, 1, this.maxBlurSpread);
				}
				Graphics.Blit(this.PMOOKOALAEN, this.NPAPJCDHNJH);
				this.HOEHDBIHELI.SetTexture("Close", this.NPAPJCDHNJH);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HOEHDBIHELI, this.visualize ? 0 : 8);
				if (this.bokeh && ((DepthOfFieldDeprecated.JKENGKAOIOD)0 & this.bokehDestination) != (DepthOfFieldDeprecated.JKENGKAOIOD)0)
				{
					this.GDEIAPKNLOH(this.EEKFJNKCLFF, this.MNNMCBKBBKL, OKIIDHIJBEA);
				}
			}
			this.DLGILIAMFNP();
		}

		// Token: 0x0600B720 RID: 46880 RVA: 0x005193B4 File Offset: 0x005175B4
		private void MIAENDLHMFF(RenderTexture GMNLJGNOKPD, RenderTexture LJGGOANMJAJ)
		{
			this.HOEHDBIHELI.SetVector("WizardEyeBeam", new Vector4(499f / (1659f * (float)LJGGOANMJAJ.width), 988f / (55f * (float)LJGGOANMJAJ.height), 1200f, 841f));
			Graphics.Blit(GMNLJGNOKPD, LJGGOANMJAJ, this.HOEHDBIHELI, DepthOfFieldDeprecated.AKEBHPEEABH);
		}

		// Token: 0x0600B721 RID: 46881 RVA: 0x00519418 File Offset: 0x00517618
		private int HJJCBPLBLDK()
		{
			int result = 1;
			if (this.resolution == DepthOfFieldDeprecated.EDNECHKAFDC.High)
			{
				result = 8;
			}
			else if (this.resolution == DepthOfFieldDeprecated.EDNECHKAFDC.High)
			{
				result = 6;
			}
			return result;
		}

		// Token: 0x040017AD RID: 6061
		private static int AKEBHPEEABH = 6;

		// Token: 0x040017AE RID: 6062
		private static float IHIEFLOIANN = 2f;

		// Token: 0x040017AF RID: 6063
		public DepthOfFieldDeprecated.NBLDEAGICCP quality = DepthOfFieldDeprecated.NBLDEAGICCP.OnlyBackground;

		// Token: 0x040017B0 RID: 6064
		public DepthOfFieldDeprecated.EDNECHKAFDC resolution = DepthOfFieldDeprecated.EDNECHKAFDC.Low;

		// Token: 0x040017B1 RID: 6065
		public bool simpleTweakMode = true;

		// Token: 0x040017B2 RID: 6066
		public float focalPoint = 1f;

		// Token: 0x040017B3 RID: 6067
		public float smoothness = 0.5f;

		// Token: 0x040017B4 RID: 6068
		public float focalZDistance;

		// Token: 0x040017B5 RID: 6069
		public float focalZStartCurve = 1f;

		// Token: 0x040017B6 RID: 6070
		public float focalZEndCurve = 1f;

		// Token: 0x040017B7 RID: 6071
		private float DINBPHKCLEB = 2f;

		// Token: 0x040017B8 RID: 6072
		private float PKANLIIHMBF = 2f;

		// Token: 0x040017B9 RID: 6073
		private float MHJDKBOLOBD = 0.1f;

		// Token: 0x040017BA RID: 6074
		public Transform objectFocus;

		// Token: 0x040017BB RID: 6075
		public float focalSize;

		// Token: 0x040017BC RID: 6076
		public DepthOfFieldDeprecated.BMEMFJFOHOJ bluriness = DepthOfFieldDeprecated.BMEMFJFOHOJ.High;

		// Token: 0x040017BD RID: 6077
		public float maxBlurSpread = 1.75f;

		// Token: 0x040017BE RID: 6078
		public float foregroundBlurExtrude = 1.15f;

		// Token: 0x040017BF RID: 6079
		public Shader dofBlurShader;

		// Token: 0x040017C0 RID: 6080
		private Material JBBAHGKAIFF;

		// Token: 0x040017C1 RID: 6081
		public Shader dofShader;

		// Token: 0x040017C2 RID: 6082
		private Material HOEHDBIHELI;

		// Token: 0x040017C3 RID: 6083
		public bool visualize;

		// Token: 0x040017C4 RID: 6084
		public DepthOfFieldDeprecated.JKENGKAOIOD bokehDestination = DepthOfFieldDeprecated.JKENGKAOIOD.Background;

		// Token: 0x040017C5 RID: 6085
		private float KDJDAGBLCMA = 1.25f;

		// Token: 0x040017C6 RID: 6086
		private float OFJHPNCEPHN = 0.001953125f;

		// Token: 0x040017C7 RID: 6087
		public bool bokeh;

		// Token: 0x040017C8 RID: 6088
		public bool bokehSupport = true;

		// Token: 0x040017C9 RID: 6089
		public Shader bokehShader;

		// Token: 0x040017CA RID: 6090
		public Texture2D bokehTexture;

		// Token: 0x040017CB RID: 6091
		public float bokehScale = 2.4f;

		// Token: 0x040017CC RID: 6092
		public float bokehIntensity = 0.15f;

		// Token: 0x040017CD RID: 6093
		public float bokehThresholdContrast = 0.1f;

		// Token: 0x040017CE RID: 6094
		public float bokehThresholdLuminance = 0.55f;

		// Token: 0x040017CF RID: 6095
		public int bokehDownsample = 1;

		// Token: 0x040017D0 RID: 6096
		private Material JNFMKGDGJEA;

		// Token: 0x040017D1 RID: 6097
		private Camera OMIJMALCLAG;

		// Token: 0x040017D2 RID: 6098
		private RenderTexture DPJPOEMKIPJ;

		// Token: 0x040017D3 RID: 6099
		private RenderTexture AMJHOJBNFOM;

		// Token: 0x040017D4 RID: 6100
		private RenderTexture NPAPJCDHNJH;

		// Token: 0x040017D5 RID: 6101
		private RenderTexture PMOOKOALAEN;

		// Token: 0x040017D6 RID: 6102
		private RenderTexture MNNMCBKBBKL;

		// Token: 0x040017D7 RID: 6103
		private RenderTexture EEKFJNKCLFF;

		// Token: 0x0200031B RID: 795
		public enum NBLDEAGICCP
		{
			// Token: 0x040017D9 RID: 6105
			OnlyBackground = 1,
			// Token: 0x040017DA RID: 6106
			BackgroundAndForeground
		}

		// Token: 0x0200031C RID: 796
		public enum EDNECHKAFDC
		{
			// Token: 0x040017DC RID: 6108
			High = 2,
			// Token: 0x040017DD RID: 6109
			Medium,
			// Token: 0x040017DE RID: 6110
			Low
		}

		// Token: 0x0200031D RID: 797
		public enum BMEMFJFOHOJ
		{
			// Token: 0x040017E0 RID: 6112
			Low = 1,
			// Token: 0x040017E1 RID: 6113
			High,
			// Token: 0x040017E2 RID: 6114
			VeryHigh = 4
		}

		// Token: 0x0200031E RID: 798
		public enum JKENGKAOIOD
		{
			// Token: 0x040017E4 RID: 6116
			Background = 1,
			// Token: 0x040017E5 RID: 6117
			Foreground,
			// Token: 0x040017E6 RID: 6118
			BackgroundAndForeground
		}
	}
}
