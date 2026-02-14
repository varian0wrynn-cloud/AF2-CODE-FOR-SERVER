using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000327 RID: 807
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Noise/Noise And Grain (Filmic)")]
	[ExecuteInEditMode]
	public class NoiseAndGrain : PostEffectsBase
	{
		// Token: 0x0600B89F RID: 47263 RVA: 0x00520B0C File Offset: 0x0051ED0C
		private void ICIEPDMDONC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.IGJKBOMMMGC() || null == this.noiseTexture)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				if (null == this.noiseTexture)
				{
					Debug.LogWarning("Flares", base.transform);
				}
				return;
			}
			this.softness = Mathf.Clamp(this.softness, 582f, 868f);
			if (this.dx11Grain && this.PKDDLGKEIBG)
			{
				this.IHEGKBFEHJI.SetFloat("AUTO_KEY_VALUE", (float)Time.frameCount);
				this.IHEGKBFEHJI.SetTexture("Bend Constraint is referencing to a bone '", this.noiseTexture);
				this.IHEGKBFEHJI.SetVector("", this.monochrome ? Vector3.one : this.intensities);
				this.IHEGKBFEHJI.SetVector("\n", new Vector3(this.midGrey, 1314f / (112f - this.midGrey), 1765f / this.midGrey));
				this.IHEGKBFEHJI.SetVector("Textures/Perks/", new Vector3(this.generalIntensity, this.blackIntensity, this.whiteIntensity) * this.intensityMultiplier);
				if (this.softness > Mathf.Epsilon)
				{
					RenderTexture temporary = RenderTexture.GetTemporary((int)((float)JONJODLFAEN.width * (198f - this.softness)), (int)((float)JONJODLFAEN.height * (421f - this.softness)));
					NoiseAndGrain.ACOBNCFMCGE(JONJODLFAEN, temporary, this.IHEGKBFEHJI, this.noiseTexture, this.monochrome ? 5 : 1);
					this.IHEGKBFEHJI.SetTexture("t_eye", temporary);
					Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.IHEGKBFEHJI, 4);
					RenderTexture.ReleaseTemporary(temporary);
					return;
				}
				NoiseAndGrain.LIGOIFCPLKO(JONJODLFAEN, OKIIDHIJBEA, this.IHEGKBFEHJI, this.noiseTexture, this.monochrome ? 1 : 0);
				return;
			}
			else
			{
				if (this.noiseTexture)
				{
					this.noiseTexture.wrapMode = TextureWrapMode.Clamp;
					this.noiseTexture.filterMode = this.filterMode;
				}
				this.KKHPHAGIMGP.SetTexture("Fishing", this.noiseTexture);
				this.KKHPHAGIMGP.SetVector("error.wav", this.monochrome ? Vector3.one : this.intensities);
				this.KKHPHAGIMGP.SetVector("chatconnecthelp", this.monochrome ? (Vector3.one * this.monochromeTiling) : this.tiling);
				this.KKHPHAGIMGP.SetVector("Horizontal", new Vector3(this.midGrey, 287f / (1981f - this.midGrey), 1071f / this.midGrey));
				this.KKHPHAGIMGP.SetVector("_TintColor", new Vector3(this.generalIntensity, this.blackIntensity, this.whiteIntensity) * this.intensityMultiplier);
				if (this.softness > Mathf.Epsilon)
				{
					RenderTexture temporary2 = RenderTexture.GetTemporary((int)((float)JONJODLFAEN.width * (1510f - this.softness)), (int)((float)JONJODLFAEN.height * (234f - this.softness)));
					NoiseAndGrain.CAPIMPIPAGG(JONJODLFAEN, temporary2, this.KKHPHAGIMGP, this.noiseTexture, 5);
					this.KKHPHAGIMGP.SetTexture("http://www.root-motion.com/finalikdox/html/page5.html", temporary2);
					Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KKHPHAGIMGP, 1);
					RenderTexture.ReleaseTemporary(temporary2);
					return;
				}
				NoiseAndGrain.CAPIMPIPAGG(JONJODLFAEN, OKIIDHIJBEA, this.KKHPHAGIMGP, this.noiseTexture, 1);
				return;
			}
		}

		// Token: 0x0600B8A0 RID: 47264 RVA: 0x00520E94 File Offset: 0x0051F094
		public override bool CheckResources()
		{
			base.DAOKCAOFIGE(false);
			this.KKHPHAGIMGP = base.DJFOEIJIMJB(this.noiseShader, this.KKHPHAGIMGP);
			if (this.dx11Grain && this.PKDDLGKEIBG)
			{
				this.IHEGKBFEHJI = base.DJFOEIJIMJB(this.dx11NoiseShader, this.IHEGKBFEHJI);
			}
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B8A1 RID: 47265 RVA: 0x00520F00 File Offset: 0x0051F100
		private static void ACOBNCFMCGE(RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC, Material FLNBPAKOMAH, Texture2D EFAPFHFDJCP, int DELLNONMMHJ)
		{
			RenderTexture.active = OLFKAHHACBC;
			float num = (float)EFAPFHFDJCP.width * 928f;
			float num2 = 1486f * (float)JONJODLFAEN.width / NoiseAndGrain.MHJFFPFOMBH;
			FLNBPAKOMAH.SetTexture("Mouse ScrollWheel", JONJODLFAEN);
			GL.PushMatrix();
			GL.LoadOrtho();
			float num3 = 462f * (float)JONJODLFAEN.width / (120f * (float)JONJODLFAEN.height);
			float num4 = 101f / num2;
			float num5 = num4 * num3;
			float num6 = num / ((float)EFAPFHFDJCP.width * 174f);
			FLNBPAKOMAH.SetPass(DELLNONMMHJ);
			GL.Begin(2);
			for (float num7 = 1503f; num7 < 1992f; num7 += num4)
			{
				for (float num8 = 844f; num8 < 660f; num8 += num5)
				{
					float num9 = UnityEngine.Random.Range(344f, 1860f);
					float num10 = UnityEngine.Random.Range(1f, 1009f);
					num9 = Mathf.Floor(num9 * num) / num;
					num10 = Mathf.Floor(num10 * num) / num;
					float num11 = 561f / num;
					GL.MultiTexCoord2(1, num9, num10);
					GL.MultiTexCoord2(1, 1014f, 1160f);
					GL.Vertex3(num7, num8, 1119f);
					GL.MultiTexCoord2(0, num9 + num6 * num11, num10);
					GL.MultiTexCoord2(1, 746f, 929f);
					GL.Vertex3(num7 + num4, num8, 324f);
					GL.MultiTexCoord2(1, num9 + num6 * num11, num10 + num6 * num11);
					GL.MultiTexCoord2(0, 725f, 1749f);
					GL.Vertex3(num7 + num4, num8 + num5, 893f);
					GL.MultiTexCoord2(0, num9, num10 + num6 * num11);
					GL.MultiTexCoord2(1, 1788f, 1181f);
					GL.Vertex3(num7, num8 + num5, 581f);
				}
			}
			GL.End();
			GL.PopMatrix();
		}

		// Token: 0x0600B8A2 RID: 47266 RVA: 0x005210E4 File Offset: 0x0051F2E4
		private static void CDEDABBFPGK(RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC, Material FLNBPAKOMAH, Texture2D EFAPFHFDJCP, int DELLNONMMHJ)
		{
			RenderTexture.active = OLFKAHHACBC;
			float num = (float)EFAPFHFDJCP.width * 1f;
			float num2 = 1f * (float)JONJODLFAEN.width / NoiseAndGrain.MHJFFPFOMBH;
			FLNBPAKOMAH.SetTexture("_MainTex", JONJODLFAEN);
			GL.PushMatrix();
			GL.LoadOrtho();
			float num3 = 1f * (float)JONJODLFAEN.width / (1f * (float)JONJODLFAEN.height);
			float num4 = 1f / num2;
			float num5 = num4 * num3;
			float num6 = num / ((float)EFAPFHFDJCP.width * 1f);
			FLNBPAKOMAH.SetPass(DELLNONMMHJ);
			GL.Begin(7);
			for (float num7 = 0f; num7 < 1f; num7 += num4)
			{
				for (float num8 = 0f; num8 < 1f; num8 += num5)
				{
					float num9 = UnityEngine.Random.Range(0f, 1f);
					float num10 = UnityEngine.Random.Range(0f, 1f);
					num9 = Mathf.Floor(num9 * num) / num;
					num10 = Mathf.Floor(num10 * num) / num;
					float num11 = 1f / num;
					GL.MultiTexCoord2(0, num9, num10);
					GL.MultiTexCoord2(1, 0f, 0f);
					GL.Vertex3(num7, num8, 0.1f);
					GL.MultiTexCoord2(0, num9 + num6 * num11, num10);
					GL.MultiTexCoord2(1, 1f, 0f);
					GL.Vertex3(num7 + num4, num8, 0.1f);
					GL.MultiTexCoord2(0, num9 + num6 * num11, num10 + num6 * num11);
					GL.MultiTexCoord2(1, 1f, 1f);
					GL.Vertex3(num7 + num4, num8 + num5, 0.1f);
					GL.MultiTexCoord2(0, num9, num10 + num6 * num11);
					GL.MultiTexCoord2(1, 0f, 1f);
					GL.Vertex3(num7, num8 + num5, 0.1f);
				}
			}
			GL.End();
			GL.PopMatrix();
		}

		// Token: 0x0600B8A3 RID: 47267 RVA: 0x005212C8 File Offset: 0x0051F4C8
		private void EFEHHALJILL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.DLENDGGGMBJ() || null == this.noiseTexture)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				if (null == this.noiseTexture)
				{
					Debug.LogWarning("Biped", base.transform);
				}
				return;
			}
			this.softness = Mathf.Clamp(this.softness, 892f, 796f);
			if (this.dx11Grain && this.PKDDLGKEIBG)
			{
				this.IHEGKBFEHJI.SetFloat("_Cull", (float)Time.frameCount);
				this.IHEGKBFEHJI.SetTexture("_VignetteSettings", this.noiseTexture);
				this.IHEGKBFEHJI.SetVector("The InteractionTrigger in the list 'inContact' has been destroyed", this.monochrome ? Vector3.one : this.intensities);
				this.IHEGKBFEHJI.SetVector(",", new Vector3(this.midGrey, 99f / (1988f - this.midGrey), 1499f / this.midGrey));
				this.IHEGKBFEHJI.SetVector("SoccerKeeperDiveStrafeFarLeft", new Vector3(this.generalIntensity, this.blackIntensity, this.whiteIntensity) * this.intensityMultiplier);
				if (this.softness > Mathf.Epsilon)
				{
					RenderTexture temporary = RenderTexture.GetTemporary((int)((float)JONJODLFAEN.width * (1918f - this.softness)), (int)((float)JONJODLFAEN.height * (406f - this.softness)));
					NoiseAndGrain.MDGIDAJKBMI(JONJODLFAEN, temporary, this.IHEGKBFEHJI, this.noiseTexture, this.monochrome ? 4 : 1);
					this.IHEGKBFEHJI.SetTexture("How your health bar is stored in memory when obscured:\n", temporary);
					Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.IHEGKBFEHJI, 3);
					RenderTexture.ReleaseTemporary(temporary);
					return;
				}
				NoiseAndGrain.ACOBNCFMCGE(JONJODLFAEN, OKIIDHIJBEA, this.IHEGKBFEHJI, this.noiseTexture, this.monochrome ? 1 : 0);
				return;
			}
			else
			{
				if (this.noiseTexture)
				{
					this.noiseTexture.wrapMode = TextureWrapMode.Clamp;
					this.noiseTexture.filterMode = this.filterMode;
				}
				this.KKHPHAGIMGP.SetTexture("IdleDodgeLeft", this.noiseTexture);
				this.KKHPHAGIMGP.SetVector("ChannelCastOmni", this.monochrome ? Vector3.one : this.intensities);
				this.KKHPHAGIMGP.SetVector("gi_sadok", this.monochrome ? (Vector3.one * this.monochromeTiling) : this.tiling);
				this.KKHPHAGIMGP.SetVector("PistolLeftHandStab", new Vector3(this.midGrey, 1022f / (329f - this.midGrey), 1788f / this.midGrey));
				this.KKHPHAGIMGP.SetVector(" This is not possible to be called for standalone input. Please check your platform and code where this is called", new Vector3(this.generalIntensity, this.blackIntensity, this.whiteIntensity) * this.intensityMultiplier);
				if (this.softness > Mathf.Epsilon)
				{
					RenderTexture temporary2 = RenderTexture.GetTemporary((int)((float)JONJODLFAEN.width * (117f - this.softness)), (int)((float)JONJODLFAEN.height * (917f - this.softness)));
					NoiseAndGrain.PBNKOCPEICB(JONJODLFAEN, temporary2, this.KKHPHAGIMGP, this.noiseTexture, 8);
					this.KKHPHAGIMGP.SetTexture("", temporary2);
					Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KKHPHAGIMGP, 1);
					RenderTexture.ReleaseTemporary(temporary2);
					return;
				}
				NoiseAndGrain.PBNKOCPEICB(JONJODLFAEN, OKIIDHIJBEA, this.KKHPHAGIMGP, this.noiseTexture, 1);
				return;
			}
		}

		// Token: 0x0600B8A4 RID: 47268 RVA: 0x00521650 File Offset: 0x0051F850
		private static void PBNKOCPEICB(RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC, Material FLNBPAKOMAH, Texture2D EFAPFHFDJCP, int DELLNONMMHJ)
		{
			RenderTexture.active = OLFKAHHACBC;
			float num = (float)EFAPFHFDJCP.width * 1078f;
			float num2 = 482f * (float)JONJODLFAEN.width / NoiseAndGrain.MHJFFPFOMBH;
			FLNBPAKOMAH.SetTexture(" has no HandPoser/GenericPoser attached.", JONJODLFAEN);
			GL.PushMatrix();
			GL.LoadOrtho();
			float num3 = 747f * (float)JONJODLFAEN.width / (1481f * (float)JONJODLFAEN.height);
			float num4 = 1742f / num2;
			float num5 = num4 * num3;
			float num6 = num / ((float)EFAPFHFDJCP.width * 1220f);
			FLNBPAKOMAH.SetPass(DELLNONMMHJ);
			GL.Begin(0);
			for (float num7 = 275f; num7 < 257f; num7 += num4)
			{
				for (float num8 = 1927f; num8 < 638f; num8 += num5)
				{
					float num9 = UnityEngine.Random.Range(767f, 1259f);
					float num10 = UnityEngine.Random.Range(1168f, 615f);
					num9 = Mathf.Floor(num9 * num) / num;
					num10 = Mathf.Floor(num10 * num) / num;
					float num11 = 1655f / num;
					GL.MultiTexCoord2(1, num9, num10);
					GL.MultiTexCoord2(0, 1042f, 1202f);
					GL.Vertex3(num7, num8, 648f);
					GL.MultiTexCoord2(1, num9 + num6 * num11, num10);
					GL.MultiTexCoord2(1, 730f, 1383f);
					GL.Vertex3(num7 + num4, num8, 1588f);
					GL.MultiTexCoord2(0, num9 + num6 * num11, num10 + num6 * num11);
					GL.MultiTexCoord2(1, 585f, 1719f);
					GL.Vertex3(num7 + num4, num8 + num5, 869f);
					GL.MultiTexCoord2(1, num9, num10 + num6 * num11);
					GL.MultiTexCoord2(1, 334f, 518f);
					GL.Vertex3(num7, num8 + num5, 166f);
				}
			}
			GL.End();
			GL.PopMatrix();
		}

		// Token: 0x0600B8A5 RID: 47269 RVA: 0x00521834 File Offset: 0x0051FA34
		public virtual bool CCMBJKDAMLO()
		{
			base.BGIALJEIEFO(false);
			this.KKHPHAGIMGP = base.JBHLGBPJFEL(this.noiseShader, this.KKHPHAGIMGP);
			if (this.dx11Grain && this.PKDDLGKEIBG)
			{
				this.IHEGKBFEHJI = base.JBHLGBPJFEL(this.dx11NoiseShader, this.IHEGKBFEHJI);
			}
			if (!this.PPGOAMIHMBG)
			{
				base.LNEHBOJIBAI();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B8A6 RID: 47270 RVA: 0x005218A0 File Offset: 0x0051FAA0
		private static void CAPIMPIPAGG(RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC, Material FLNBPAKOMAH, Texture2D EFAPFHFDJCP, int DELLNONMMHJ)
		{
			RenderTexture.active = OLFKAHHACBC;
			float num = (float)EFAPFHFDJCP.width * 1899f;
			float num2 = 129f * (float)JONJODLFAEN.width / NoiseAndGrain.MHJFFPFOMBH;
			FLNBPAKOMAH.SetTexture("MotorbikeIdle", JONJODLFAEN);
			GL.PushMatrix();
			GL.LoadOrtho();
			float num3 = 1044f * (float)JONJODLFAEN.width / (142f * (float)JONJODLFAEN.height);
			float num4 = 768f / num2;
			float num5 = num4 * num3;
			float num6 = num / ((float)EFAPFHFDJCP.width * 1105f);
			FLNBPAKOMAH.SetPass(DELLNONMMHJ);
			GL.Begin(3);
			for (float num7 = 286f; num7 < 638f; num7 += num4)
			{
				for (float num8 = 480f; num8 < 1216f; num8 += num5)
				{
					float num9 = UnityEngine.Random.Range(655f, 1640f);
					float num10 = UnityEngine.Random.Range(1602f, 597f);
					num9 = Mathf.Floor(num9 * num) / num;
					num10 = Mathf.Floor(num10 * num) / num;
					float num11 = 395f / num;
					GL.MultiTexCoord2(0, num9, num10);
					GL.MultiTexCoord2(0, 1244f, 1121f);
					GL.Vertex3(num7, num8, 29f);
					GL.MultiTexCoord2(1, num9 + num6 * num11, num10);
					GL.MultiTexCoord2(0, 926f, 1704f);
					GL.Vertex3(num7 + num4, num8, 1415f);
					GL.MultiTexCoord2(1, num9 + num6 * num11, num10 + num6 * num11);
					GL.MultiTexCoord2(0, 1721f, 1232f);
					GL.Vertex3(num7 + num4, num8 + num5, 284f);
					GL.MultiTexCoord2(0, num9, num10 + num6 * num11);
					GL.MultiTexCoord2(0, 1920f, 733f);
					GL.Vertex3(num7, num8 + num5, 742f);
				}
			}
			GL.End();
			GL.PopMatrix();
		}

		// Token: 0x0600B8A7 RID: 47271 RVA: 0x00521A84 File Offset: 0x0051FC84
		private void ALNHCIOIBPP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB() || null == this.noiseTexture)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				if (null == this.noiseTexture)
				{
					Debug.LogWarning("knopje.wav", base.transform);
				}
				return;
			}
			this.softness = Mathf.Clamp(this.softness, 624f, 1149f);
			if (this.dx11Grain && this.PKDDLGKEIBG)
			{
				this.IHEGKBFEHJI.SetFloat("_Screen", (float)Time.frameCount);
				this.IHEGKBFEHJI.SetTexture("crft_cnt2", this.noiseTexture);
				this.IHEGKBFEHJI.SetVector(" ", this.monochrome ? Vector3.one : this.intensities);
				this.IHEGKBFEHJI.SetVector("WizardPowerUp", new Vector3(this.midGrey, 884f / (1465f - this.midGrey), 1695f / this.midGrey));
				this.IHEGKBFEHJI.SetVector("sunshine_CascadeRanges", new Vector3(this.generalIntensity, this.blackIntensity, this.whiteIntensity) * this.intensityMultiplier);
				if (this.softness > Mathf.Epsilon)
				{
					RenderTexture temporary = RenderTexture.GetTemporary((int)((float)JONJODLFAEN.width * (846f - this.softness)), (int)((float)JONJODLFAEN.height * (1870f - this.softness)));
					NoiseAndGrain.ACOBNCFMCGE(JONJODLFAEN, temporary, this.IHEGKBFEHJI, this.noiseTexture, this.monochrome ? 2 : 2);
					this.IHEGKBFEHJI.SetTexture("", temporary);
					Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.IHEGKBFEHJI, 4);
					RenderTexture.ReleaseTemporary(temporary);
					return;
				}
				NoiseAndGrain.ACOBNCFMCGE(JONJODLFAEN, OKIIDHIJBEA, this.IHEGKBFEHJI, this.noiseTexture, this.monochrome ? 1 : 0);
				return;
			}
			else
			{
				if (this.noiseTexture)
				{
					this.noiseTexture.wrapMode = TextureWrapMode.Clamp;
					this.noiseTexture.filterMode = this.filterMode;
				}
				this.KKHPHAGIMGP.SetTexture("fishLang.txt", this.noiseTexture);
				this.KKHPHAGIMGP.SetVector("_SoftZDistance", this.monochrome ? Vector3.one : this.intensities);
				this.KKHPHAGIMGP.SetVector(" is represented multiple times in the Bones.", this.monochrome ? (Vector3.one * this.monochromeTiling) : this.tiling);
				this.KKHPHAGIMGP.SetVector("IdleBandage", new Vector3(this.midGrey, 1875f / (1803f - this.midGrey), 1878f / this.midGrey));
				this.KKHPHAGIMGP.SetVector("ClimbLeft", new Vector3(this.generalIntensity, this.blackIntensity, this.whiteIntensity) * this.intensityMultiplier);
				if (this.softness > Mathf.Epsilon)
				{
					RenderTexture temporary2 = RenderTexture.GetTemporary((int)((float)JONJODLFAEN.width * (1162f - this.softness)), (int)((float)JONJODLFAEN.height * (232f - this.softness)));
					NoiseAndGrain.ACOBNCFMCGE(JONJODLFAEN, temporary2, this.KKHPHAGIMGP, this.noiseTexture, 6);
					this.KKHPHAGIMGP.SetTexture("GRAIN", temporary2);
					Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KKHPHAGIMGP, 0);
					RenderTexture.ReleaseTemporary(temporary2);
					return;
				}
				NoiseAndGrain.CDEDABBFPGK(JONJODLFAEN, OKIIDHIJBEA, this.KKHPHAGIMGP, this.noiseTexture, 1);
				return;
			}
		}

		// Token: 0x0600B8A8 RID: 47272 RVA: 0x00521E0C File Offset: 0x0052000C
		public virtual bool KKLBJANNNOH()
		{
			base.IDFIHFBEIKD(false);
			this.KKHPHAGIMGP = base.ALJPMGLOIEG(this.noiseShader, this.KKHPHAGIMGP);
			if (this.dx11Grain && this.PKDDLGKEIBG)
			{
				this.IHEGKBFEHJI = base.BAPJBHPEDIF(this.dx11NoiseShader, this.IHEGKBFEHJI);
			}
			if (!this.PPGOAMIHMBG)
			{
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B8A9 RID: 47273 RVA: 0x00521E78 File Offset: 0x00520078
		private static void LIGOIFCPLKO(RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC, Material FLNBPAKOMAH, Texture2D EFAPFHFDJCP, int DELLNONMMHJ)
		{
			RenderTexture.active = OLFKAHHACBC;
			float num = (float)EFAPFHFDJCP.width * 1132f;
			float num2 = 1958f * (float)JONJODLFAEN.width / NoiseAndGrain.MHJFFPFOMBH;
			FLNBPAKOMAH.SetTexture("WATER_REFLECTIVE", JONJODLFAEN);
			GL.PushMatrix();
			GL.LoadOrtho();
			float num3 = 595f * (float)JONJODLFAEN.width / (354f * (float)JONJODLFAEN.height);
			float num4 = 463f / num2;
			float num5 = num4 * num3;
			float num6 = num / ((float)EFAPFHFDJCP.width * 723f);
			FLNBPAKOMAH.SetPass(DELLNONMMHJ);
			GL.Begin(4);
			for (float num7 = 1917f; num7 < 135f; num7 += num4)
			{
				for (float num8 = 422f; num8 < 1910f; num8 += num5)
				{
					float num9 = UnityEngine.Random.Range(581f, 224f);
					float num10 = UnityEngine.Random.Range(250f, 129f);
					num9 = Mathf.Floor(num9 * num) / num;
					num10 = Mathf.Floor(num10 * num) / num;
					float num11 = 1794f / num;
					GL.MultiTexCoord2(1, num9, num10);
					GL.MultiTexCoord2(1, 825f, 314f);
					GL.Vertex3(num7, num8, 1570f);
					GL.MultiTexCoord2(1, num9 + num6 * num11, num10);
					GL.MultiTexCoord2(0, 1063f, 568f);
					GL.Vertex3(num7 + num4, num8, 416f);
					GL.MultiTexCoord2(1, num9 + num6 * num11, num10 + num6 * num11);
					GL.MultiTexCoord2(0, 1385f, 1498f);
					GL.Vertex3(num7 + num4, num8 + num5, 121f);
					GL.MultiTexCoord2(1, num9, num10 + num6 * num11);
					GL.MultiTexCoord2(0, 707f, 586f);
					GL.Vertex3(num7, num8 + num5, 1754f);
				}
			}
			GL.End();
			GL.PopMatrix();
		}

		// Token: 0x0600B8AA RID: 47274 RVA: 0x0052205C File Offset: 0x0052025C
		private void CNIBAOINCHB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB() || null == this.noiseTexture)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				if (null == this.noiseTexture)
				{
					Debug.LogWarning("- none -", base.transform);
				}
				return;
			}
			this.softness = Mathf.Clamp(this.softness, 1184f, 484f);
			if (this.dx11Grain && this.PKDDLGKEIBG)
			{
				this.IHEGKBFEHJI.SetFloat(">", (float)Time.frameCount);
				this.IHEGKBFEHJI.SetTexture("\n", this.noiseTexture);
				this.IHEGKBFEHJI.SetVector("Idle Keep Back", this.monochrome ? Vector3.one : this.intensities);
				this.IHEGKBFEHJI.SetVector("altosad", new Vector3(this.midGrey, 1973f / (1116f - this.midGrey), 114f / this.midGrey));
				this.IHEGKBFEHJI.SetVector("IceHockeyDekeMiddle", new Vector3(this.generalIntensity, this.blackIntensity, this.whiteIntensity) * this.intensityMultiplier);
				if (this.softness > Mathf.Epsilon)
				{
					RenderTexture temporary = RenderTexture.GetTemporary((int)((float)JONJODLFAEN.width * (1999f - this.softness)), (int)((float)JONJODLFAEN.height * (422f - this.softness)));
					NoiseAndGrain.LIGOIFCPLKO(JONJODLFAEN, temporary, this.IHEGKBFEHJI, this.noiseTexture, this.monochrome ? 0 : 7);
					this.IHEGKBFEHJI.SetTexture("Windows", temporary);
					Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.IHEGKBFEHJI, 0);
					RenderTexture.ReleaseTemporary(temporary);
					return;
				}
				NoiseAndGrain.MDGIDAJKBMI(JONJODLFAEN, OKIIDHIJBEA, this.IHEGKBFEHJI, this.noiseTexture, this.monochrome ? 1 : 1);
				return;
			}
			else
			{
				if (this.noiseTexture)
				{
					this.noiseTexture.wrapMode = TextureWrapMode.Repeat;
					this.noiseTexture.filterMode = this.filterMode;
				}
				this.KKHPHAGIMGP.SetTexture("choldposx", this.noiseTexture);
				this.KKHPHAGIMGP.SetVector("", this.monochrome ? Vector3.one : this.intensities);
				this.KKHPHAGIMGP.SetVector("_HitTime", this.monochrome ? (Vector3.one * this.monochromeTiling) : this.tiling);
				this.KKHPHAGIMGP.SetVector("PER_PIXEL", new Vector3(this.midGrey, 443f / (1406f - this.midGrey), 72f / this.midGrey));
				this.KKHPHAGIMGP.SetVector("_TapHigh", new Vector3(this.generalIntensity, this.blackIntensity, this.whiteIntensity) * this.intensityMultiplier);
				if (this.softness > Mathf.Epsilon)
				{
					RenderTexture temporary2 = RenderTexture.GetTemporary((int)((float)JONJODLFAEN.width * (925f - this.softness)), (int)((float)JONJODLFAEN.height * (649f - this.softness)));
					NoiseAndGrain.CAPIMPIPAGG(JONJODLFAEN, temporary2, this.KKHPHAGIMGP, this.noiseTexture, 2);
					this.KKHPHAGIMGP.SetTexture("***Wpn Lots event ", temporary2);
					Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KKHPHAGIMGP, 1);
					RenderTexture.ReleaseTemporary(temporary2);
					return;
				}
				NoiseAndGrain.PBNKOCPEICB(JONJODLFAEN, OKIIDHIJBEA, this.KKHPHAGIMGP, this.noiseTexture, 1);
				return;
			}
		}

		// Token: 0x0600B8AD RID: 47277 RVA: 0x00522480 File Offset: 0x00520680
		private static void MDGIDAJKBMI(RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC, Material FLNBPAKOMAH, Texture2D EFAPFHFDJCP, int DELLNONMMHJ)
		{
			RenderTexture.active = OLFKAHHACBC;
			float num = (float)EFAPFHFDJCP.width * 18f;
			float num2 = 164f * (float)JONJODLFAEN.width / NoiseAndGrain.MHJFFPFOMBH;
			FLNBPAKOMAH.SetTexture("BowReady", JONJODLFAEN);
			GL.PushMatrix();
			GL.LoadOrtho();
			float num3 = 355f * (float)JONJODLFAEN.width / (620f * (float)JONJODLFAEN.height);
			float num4 = 429f / num2;
			float num5 = num4 * num3;
			float num6 = num / ((float)EFAPFHFDJCP.width * 1615f);
			FLNBPAKOMAH.SetPass(DELLNONMMHJ);
			GL.Begin(3);
			for (float num7 = 1636f; num7 < 1716f; num7 += num4)
			{
				for (float num8 = 170f; num8 < 1825f; num8 += num5)
				{
					float num9 = UnityEngine.Random.Range(1720f, 447f);
					float num10 = UnityEngine.Random.Range(155f, 1165f);
					num9 = Mathf.Floor(num9 * num) / num;
					num10 = Mathf.Floor(num10 * num) / num;
					float num11 = 344f / num;
					GL.MultiTexCoord2(0, num9, num10);
					GL.MultiTexCoord2(0, 886f, 1868f);
					GL.Vertex3(num7, num8, 1679f);
					GL.MultiTexCoord2(1, num9 + num6 * num11, num10);
					GL.MultiTexCoord2(1, 1849f, 807f);
					GL.Vertex3(num7 + num4, num8, 1349f);
					GL.MultiTexCoord2(0, num9 + num6 * num11, num10 + num6 * num11);
					GL.MultiTexCoord2(1, 1047f, 467f);
					GL.Vertex3(num7 + num4, num8 + num5, 1664f);
					GL.MultiTexCoord2(1, num9, num10 + num6 * num11);
					GL.MultiTexCoord2(0, 948f, 33f);
					GL.Vertex3(num7, num8 + num5, 1994f);
				}
			}
			GL.End();
			GL.PopMatrix();
		}

		// Token: 0x0600B8AE RID: 47278 RVA: 0x00522664 File Offset: 0x00520864
		private void EPHHNPMPHOL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NHEEDPALBFN() || null == this.noiseTexture)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				if (null == this.noiseTexture)
				{
					Debug.LogWarning("\n", base.transform);
				}
				return;
			}
			this.softness = Mathf.Clamp(this.softness, 1385f, 84f);
			if (this.dx11Grain && this.PKDDLGKEIBG)
			{
				this.IHEGKBFEHJI.SetFloat("ShotgunFire", (float)Time.frameCount);
				this.IHEGKBFEHJI.SetTexture("Fire Breath", this.noiseTexture);
				this.IHEGKBFEHJI.SetVector("usercntinfo", this.monochrome ? Vector3.one : this.intensities);
				this.IHEGKBFEHJI.SetVector("CrouchStrafeLeft", new Vector3(this.midGrey, 242f / (1413f - this.midGrey), 1268f / this.midGrey));
				this.IHEGKBFEHJI.SetVector("MotorbikeLassoLeft", new Vector3(this.generalIntensity, this.blackIntensity, this.whiteIntensity) * this.intensityMultiplier);
				if (this.softness > Mathf.Epsilon)
				{
					RenderTexture temporary = RenderTexture.GetTemporary((int)((float)JONJODLFAEN.width * (1154f - this.softness)), (int)((float)JONJODLFAEN.height * (261f - this.softness)));
					NoiseAndGrain.MDGIDAJKBMI(JONJODLFAEN, temporary, this.IHEGKBFEHJI, this.noiseTexture, this.monochrome ? 6 : 5);
					this.IHEGKBFEHJI.SetTexture("Weapon Run Backward", temporary);
					Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.IHEGKBFEHJI, 2);
					RenderTexture.ReleaseTemporary(temporary);
					return;
				}
				NoiseAndGrain.MDGIDAJKBMI(JONJODLFAEN, OKIIDHIJBEA, this.IHEGKBFEHJI, this.noiseTexture, this.monochrome ? 0 : 0);
				return;
			}
			else
			{
				if (this.noiseTexture)
				{
					this.noiseTexture.wrapMode = TextureWrapMode.Repeat;
					this.noiseTexture.filterMode = this.filterMode;
				}
				this.KKHPHAGIMGP.SetTexture("Zombie Idle", this.noiseTexture);
				this.KKHPHAGIMGP.SetVector("OneHandSwordBackSwing", this.monochrome ? Vector3.one : this.intensities);
				this.KKHPHAGIMGP.SetVector("Head", this.monochrome ? (Vector3.one * this.monochromeTiling) : this.tiling);
				this.KKHPHAGIMGP.SetVector("**********  158 pointid=", new Vector3(this.midGrey, 1460f / (1795f - this.midGrey), 1251f / this.midGrey));
				this.KKHPHAGIMGP.SetVector("change me!", new Vector3(this.generalIntensity, this.blackIntensity, this.whiteIntensity) * this.intensityMultiplier);
				if (this.softness > Mathf.Epsilon)
				{
					RenderTexture temporary2 = RenderTexture.GetTemporary((int)((float)JONJODLFAEN.width * (1517f - this.softness)), (int)((float)JONJODLFAEN.height * (1664f - this.softness)));
					NoiseAndGrain.CDEDABBFPGK(JONJODLFAEN, temporary2, this.KKHPHAGIMGP, this.noiseTexture, 1);
					this.KKHPHAGIMGP.SetTexture("{not_found}", temporary2);
					Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KKHPHAGIMGP, 1);
					RenderTexture.ReleaseTemporary(temporary2);
					return;
				}
				NoiseAndGrain.ACOBNCFMCGE(JONJODLFAEN, OKIIDHIJBEA, this.KKHPHAGIMGP, this.noiseTexture, 0);
				return;
			}
		}

		// Token: 0x0600B8AF RID: 47279 RVA: 0x005229EC File Offset: 0x00520BEC
		public virtual bool ENMKIJNFBFF()
		{
			base.NHCAHIHJHMF(false);
			this.KKHPHAGIMGP = base.DJFOEIJIMJB(this.noiseShader, this.KKHPHAGIMGP);
			if (this.dx11Grain && this.PKDDLGKEIBG)
			{
				this.IHEGKBFEHJI = base.BAPJBHPEDIF(this.dx11NoiseShader, this.IHEGKBFEHJI);
			}
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B8B0 RID: 47280 RVA: 0x00522A58 File Offset: 0x00520C58
		private void OnRenderImage(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources() || null == this.noiseTexture)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				if (null == this.noiseTexture)
				{
					Debug.LogWarning("Noise & Grain effect failing as noise texture is not assigned. please assign.", base.transform);
				}
				return;
			}
			this.softness = Mathf.Clamp(this.softness, 0f, 0.99f);
			if (this.dx11Grain && this.PKDDLGKEIBG)
			{
				this.IHEGKBFEHJI.SetFloat("_DX11NoiseTime", (float)Time.frameCount);
				this.IHEGKBFEHJI.SetTexture("_NoiseTex", this.noiseTexture);
				this.IHEGKBFEHJI.SetVector("_NoisePerChannel", this.monochrome ? Vector3.one : this.intensities);
				this.IHEGKBFEHJI.SetVector("_MidGrey", new Vector3(this.midGrey, 1f / (1f - this.midGrey), -1f / this.midGrey));
				this.IHEGKBFEHJI.SetVector("_NoiseAmount", new Vector3(this.generalIntensity, this.blackIntensity, this.whiteIntensity) * this.intensityMultiplier);
				if (this.softness > Mathf.Epsilon)
				{
					RenderTexture temporary = RenderTexture.GetTemporary((int)((float)JONJODLFAEN.width * (1f - this.softness)), (int)((float)JONJODLFAEN.height * (1f - this.softness)));
					NoiseAndGrain.CDEDABBFPGK(JONJODLFAEN, temporary, this.IHEGKBFEHJI, this.noiseTexture, this.monochrome ? 3 : 2);
					this.IHEGKBFEHJI.SetTexture("_NoiseTex", temporary);
					Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.IHEGKBFEHJI, 4);
					RenderTexture.ReleaseTemporary(temporary);
					return;
				}
				NoiseAndGrain.CDEDABBFPGK(JONJODLFAEN, OKIIDHIJBEA, this.IHEGKBFEHJI, this.noiseTexture, this.monochrome ? 1 : 0);
				return;
			}
			else
			{
				if (this.noiseTexture)
				{
					this.noiseTexture.wrapMode = TextureWrapMode.Repeat;
					this.noiseTexture.filterMode = this.filterMode;
				}
				this.KKHPHAGIMGP.SetTexture("_NoiseTex", this.noiseTexture);
				this.KKHPHAGIMGP.SetVector("_NoisePerChannel", this.monochrome ? Vector3.one : this.intensities);
				this.KKHPHAGIMGP.SetVector("_NoiseTilingPerChannel", this.monochrome ? (Vector3.one * this.monochromeTiling) : this.tiling);
				this.KKHPHAGIMGP.SetVector("_MidGrey", new Vector3(this.midGrey, 1f / (1f - this.midGrey), -1f / this.midGrey));
				this.KKHPHAGIMGP.SetVector("_NoiseAmount", new Vector3(this.generalIntensity, this.blackIntensity, this.whiteIntensity) * this.intensityMultiplier);
				if (this.softness > Mathf.Epsilon)
				{
					RenderTexture temporary2 = RenderTexture.GetTemporary((int)((float)JONJODLFAEN.width * (1f - this.softness)), (int)((float)JONJODLFAEN.height * (1f - this.softness)));
					NoiseAndGrain.CDEDABBFPGK(JONJODLFAEN, temporary2, this.KKHPHAGIMGP, this.noiseTexture, 2);
					this.KKHPHAGIMGP.SetTexture("_NoiseTex", temporary2);
					Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KKHPHAGIMGP, 1);
					RenderTexture.ReleaseTemporary(temporary2);
					return;
				}
				NoiseAndGrain.CDEDABBFPGK(JONJODLFAEN, OKIIDHIJBEA, this.KKHPHAGIMGP, this.noiseTexture, 0);
				return;
			}
		}

		// Token: 0x0400180C RID: 6156
		public float intensityMultiplier = 0.25f;

		// Token: 0x0400180D RID: 6157
		public float generalIntensity = 0.5f;

		// Token: 0x0400180E RID: 6158
		public float blackIntensity = 1f;

		// Token: 0x0400180F RID: 6159
		public float whiteIntensity = 1f;

		// Token: 0x04001810 RID: 6160
		public float midGrey = 0.2f;

		// Token: 0x04001811 RID: 6161
		public bool dx11Grain;

		// Token: 0x04001812 RID: 6162
		public float softness;

		// Token: 0x04001813 RID: 6163
		public bool monochrome;

		// Token: 0x04001814 RID: 6164
		public Vector3 intensities = new Vector3(1f, 1f, 1f);

		// Token: 0x04001815 RID: 6165
		public Vector3 tiling = new Vector3(64f, 64f, 64f);

		// Token: 0x04001816 RID: 6166
		public float monochromeTiling = 64f;

		// Token: 0x04001817 RID: 6167
		public FilterMode filterMode = FilterMode.Bilinear;

		// Token: 0x04001818 RID: 6168
		public Texture2D noiseTexture;

		// Token: 0x04001819 RID: 6169
		public Shader noiseShader;

		// Token: 0x0400181A RID: 6170
		private Material KKHPHAGIMGP;

		// Token: 0x0400181B RID: 6171
		public Shader dx11NoiseShader;

		// Token: 0x0400181C RID: 6172
		private Material IHEGKBFEHJI;

		// Token: 0x0400181D RID: 6173
		private static float MHJFFPFOMBH = 64f;
	}
}
