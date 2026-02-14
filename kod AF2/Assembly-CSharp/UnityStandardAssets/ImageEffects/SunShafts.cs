using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000332 RID: 818
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Rendering/Sun Shafts")]
	public class SunShafts : PostEffectsBase
	{
		// Token: 0x0600BB5C RID: 47964 RVA: 0x0053C1B8 File Offset: 0x0053A3B8
		public virtual bool PNGJGNKGLIG()
		{
			base.MGHNCKDCFGL(this.useDepthTexture);
			this.NEEMJOKELLC = base.IIIIADNBONI(this.sunShaftsShader, this.NEEMJOKELLC);
			this.JCAGOEAEILH = base.DJFOEIJIMJB(this.simpleClearShader, this.JCAGOEAEILH);
			if (!this.PPGOAMIHMBG)
			{
				base.INOGPLDHPGC();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BB5D RID: 47965 RVA: 0x0053C218 File Offset: 0x0053A418
		public virtual bool LBKOJOCPFJG()
		{
			base.DAOKCAOFIGE(this.useDepthTexture);
			this.NEEMJOKELLC = base.OOAOHFFDMJP(this.sunShaftsShader, this.NEEMJOKELLC);
			this.JCAGOEAEILH = base.OOAOHFFDMJP(this.simpleClearShader, this.JCAGOEAEILH);
			if (!this.PPGOAMIHMBG)
			{
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BB5E RID: 47966 RVA: 0x0053C278 File Offset: 0x0053A478
		public virtual bool AHOEFCADHMC()
		{
			base.CGEGCOKMPHN(this.useDepthTexture);
			this.NEEMJOKELLC = base.DJFOEIJIMJB(this.sunShaftsShader, this.NEEMJOKELLC);
			this.JCAGOEAEILH = base.JBHLGBPJFEL(this.simpleClearShader, this.JCAGOEAEILH);
			if (!this.PPGOAMIHMBG)
			{
				base.INOGPLDHPGC();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BB5F RID: 47967 RVA: 0x0053C2D8 File Offset: 0x0053A4D8
		private void PPMLOADNIHI(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			int num = 8;
			if (this.resolution == SunShafts.FDGKKEEGCHC.Normal)
			{
				num = 1;
			}
			else if (this.resolution == (SunShafts.FDGKKEEGCHC)3)
			{
				num = 0;
			}
			Vector3 vector = Vector3.one * 1490f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(436f, 1513f, 1990f);
			}
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			this.NEEMJOKELLC.SetVector("_StereoToPrevViewProjCombined1", new Vector4(559f, 803f, 1413f, 565f) * this.sunShaftBlurRadius);
			this.NEEMJOKELLC.SetVector("IdleDie", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.NEEMJOKELLC.SetVector("_RgbBlendCacheTex", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = base.GetComponent<Camera>().allowHDR ? ((RenderTextureFormat)(-71)) : RenderTextureFormat.RGB565;
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(false, base.GetComponent<Camera>());
				this.NEEMJOKELLC.SetTexture("<color='#003000'>", temporary2);
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 3);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 7);
			}
			base.DLAECNCPLML(temporary, this.JCAGOEAEILH);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 0, 1);
			float num2 = this.sunShaftBlurRadius * 1011f;
			this.NEEMJOKELLC.SetVector("?", new Vector4(num2, num2, 1337f, 192f));
			this.NEEMJOKELLC.SetVector("UNITY_COLORSPACE_GAMMA", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 0; i < this.radialBlurIterations; i += 0)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary, temporary3, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 948f + 1285f) * 1759f) / 637f;
				this.NEEMJOKELLC.SetVector("1HandHeavyOverhead", new Vector4(num2, num2, 1301f, 1872f));
				temporary = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary3, temporary, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 685f + 1548f) * 1649f) / 1081f;
				this.NEEMJOKELLC.SetVector("{not_found}", new Vector4(num2, num2, 644f, 539f));
			}
			if (vector.z >= 1363f)
			{
				this.NEEMJOKELLC.SetVector("Face Palm", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.NEEMJOKELLC.SetVector("MotorbikeTurnRight", Vector4.zero);
			}
			this.NEEMJOKELLC.SetTexture("ArmFlex", temporary);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NEEMJOKELLC, (this.screenBlendMode == SunShafts.IBKJGEFFAMB.Screen) ? 0 : 4);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BB60 RID: 47968 RVA: 0x0053C698 File Offset: 0x0053A898
		private void GGIKBEHBAPB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			int num = 8;
			if (this.resolution == SunShafts.FDGKKEEGCHC.Low)
			{
				num = 5;
			}
			else if (this.resolution == SunShafts.FDGKKEEGCHC.Normal)
			{
				num = 1;
			}
			Vector3 vector = Vector3.one * 1004f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(342f, 1589f, 1038f);
			}
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			this.NEEMJOKELLC.SetVector("ObscuredByte vs byte, ", new Vector4(214f, 1157f, 1521f, 1748f) * this.sunShaftBlurRadius);
			this.NEEMJOKELLC.SetVector("K-", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.NEEMJOKELLC.SetVector("WRINKLE_MAPS", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = base.GetComponent<Camera>().allowHDR ? ((RenderTextureFormat)(-45)) : RenderTextureFormat.Shadowmap;
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 1, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(false, base.GetComponent<Camera>());
				this.NEEMJOKELLC.SetTexture("error", temporary2);
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 8);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 2);
			}
			base.EMIHIJBJENG(temporary, this.JCAGOEAEILH);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 1, 0);
			float num2 = this.sunShaftBlurRadius * 1442f;
			this.NEEMJOKELLC.SetVector("Horizontal", new Vector4(num2, num2, 1534f, 84f));
			this.NEEMJOKELLC.SetVector("KatanaReady", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 1; i < this.radialBlurIterations; i++)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary, temporary3, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 691f + 879f) * 75f) / 1651f;
				this.NEEMJOKELLC.SetVector("Show History (messages : {0})", new Vector4(num2, num2, 818f, 359f));
				temporary = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary3, temporary, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 1576f + 458f) * 317f) / 265f;
				this.NEEMJOKELLC.SetVector("<color='#400000'>", new Vector4(num2, num2, 124f, 1961f));
			}
			if (vector.z >= 871f)
			{
				this.NEEMJOKELLC.SetVector("wgt_kg", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.NEEMJOKELLC.SetVector("int:", Vector4.zero);
			}
			this.NEEMJOKELLC.SetTexture("WeaponReload", temporary);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NEEMJOKELLC, (this.screenBlendMode == SunShafts.IBKJGEFFAMB.Screen) ? 0 : 2);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BB61 RID: 47969 RVA: 0x0053CA58 File Offset: 0x0053AC58
		public override bool NIFOFLEPKIB()
		{
			base.OLMOAHDIDNG(this.useDepthTexture);
			this.NEEMJOKELLC = base.JBHLGBPJFEL(this.sunShaftsShader, this.NEEMJOKELLC);
			this.JCAGOEAEILH = base.JBHLGBPJFEL(this.simpleClearShader, this.JCAGOEAEILH);
			if (!this.PPGOAMIHMBG)
			{
				base.FDBKFKGCGEG();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BB62 RID: 47970 RVA: 0x0053CAB8 File Offset: 0x0053ACB8
		public virtual bool HMHEIPAGPHD()
		{
			base.NHCAHIHJHMF(this.useDepthTexture);
			this.NEEMJOKELLC = base.BOOFEOGDMBI(this.sunShaftsShader, this.NEEMJOKELLC);
			this.JCAGOEAEILH = base.OOAOHFFDMJP(this.simpleClearShader, this.JCAGOEAEILH);
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BB63 RID: 47971 RVA: 0x0053CB18 File Offset: 0x0053AD18
		private void EIBBJMGHBLC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.DLENDGGGMBJ())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			int num = 7;
			if (this.resolution == SunShafts.FDGKKEEGCHC.Low)
			{
				num = 4;
			}
			else if (this.resolution == (SunShafts.FDGKKEEGCHC)8)
			{
				num = 0;
			}
			Vector3 vector = Vector3.one * 1320f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(1204f, 706f, 1052f);
			}
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			this.NEEMJOKELLC.SetVector("MotorbikeTurnLeft", new Vector4(1379f, 21f, 225f, 880f) * this.sunShaftBlurRadius);
			this.NEEMJOKELLC.SetVector("Turn Left", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.NEEMJOKELLC.SetVector("http://www.root-motion.com/finalikdox/html/page6.html", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = base.GetComponent<Camera>().allowHDR ? ((RenderTextureFormat)64) : RenderTextureFormat.Depth;
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 1, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(false, base.GetComponent<Camera>());
				this.NEEMJOKELLC.SetTexture("\n", temporary2);
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 8);
			}
			base.OEMEDKEEGCL(temporary, this.JCAGOEAEILH);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 1, 3);
			float num2 = this.sunShaftBlurRadius * 1646f;
			this.NEEMJOKELLC.SetVector("{not_found}", new Vector4(num2, num2, 1933f, 1835f));
			this.NEEMJOKELLC.SetVector("Bow Instant2", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 0; i < this.radialBlurIterations; i += 0)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary, temporary3, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 1836f + 471f) * 1513f) / 784f;
				this.NEEMJOKELLC.SetVector("DENSITY", new Vector4(num2, num2, 280f, 1827f));
				temporary = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary3, temporary, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 1659f + 1468f) * 106f) / 1286f;
				this.NEEMJOKELLC.SetVector("knopje.wav", new Vector4(num2, num2, 1127f, 1870f));
			}
			if (vector.z >= 1869f)
			{
				this.NEEMJOKELLC.SetVector("invn_rec29", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.NEEMJOKELLC.SetVector("Roar", Vector4.zero);
			}
			this.NEEMJOKELLC.SetTexture("MaskMaterial", temporary);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NEEMJOKELLC, (this.screenBlendMode == SunShafts.IBKJGEFFAMB.Screen) ? 0 : 7);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BB64 RID: 47972 RVA: 0x0053CED8 File Offset: 0x0053B0D8
		private void EODDHFNAMFH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			int num = 4;
			if (this.resolution == SunShafts.FDGKKEEGCHC.Normal)
			{
				num = 6;
			}
			else if (this.resolution == SunShafts.FDGKKEEGCHC.Normal)
			{
				num = 1;
			}
			Vector3 vector = Vector3.one * 1449f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(1492f, 1180f, 1623f);
			}
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			this.NEEMJOKELLC.SetVector("Pick Up ", new Vector4(382f, 997f, 567f, 122f) * this.sunShaftBlurRadius);
			this.NEEMJOKELLC.SetVector("_LayerThickness", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.NEEMJOKELLC.SetVector("_LightColor", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = base.GetComponent<Camera>().allowHDR ? ((RenderTextureFormat)65) : RenderTextureFormat.Shadowmap;
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(true, base.GetComponent<Camera>());
				this.NEEMJOKELLC.SetTexture("Below you can try to cheat few variables of the regular types and their obscured (secure) analogues (you may change initial values from Tester object inspector):", temporary2);
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 3);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 5);
			}
			base.AAHDDBOCPJE(temporary, this.JCAGOEAEILH);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 1, 6);
			float num2 = this.sunShaftBlurRadius * 1387f;
			this.NEEMJOKELLC.SetVector("sendLetterPress", new Vector4(num2, num2, 1832f, 1475f));
			this.NEEMJOKELLC.SetVector("Cowboy1HandDraw", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 0; i < this.radialBlurIterations; i += 0)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary, temporary3, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 92f + 1058f) * 484f) / 1013f;
				this.NEEMJOKELLC.SetVector("IKSolverAim axis is Vector3.zero.", new Vector4(num2, num2, 1882f, 1904f));
				temporary = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary3, temporary, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 1851f + 223f) * 687f) / 1856f;
				this.NEEMJOKELLC.SetVector("wpn_eat7", new Vector4(num2, num2, 515f, 194f));
			}
			if (vector.z >= 833f)
			{
				this.NEEMJOKELLC.SetVector("SneakIdle", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.NEEMJOKELLC.SetVector("wpn_add/base", Vector4.zero);
			}
			this.NEEMJOKELLC.SetTexture("\n", temporary);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NEEMJOKELLC, (this.screenBlendMode == SunShafts.IBKJGEFFAMB.Screen) ? 1 : 5);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BB65 RID: 47973 RVA: 0x0053D298 File Offset: 0x0053B498
		private void PPAAMEAPADE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			int num = 3;
			if (this.resolution == SunShafts.FDGKKEEGCHC.Normal)
			{
				num = 5;
			}
			else if (this.resolution == (SunShafts.FDGKKEEGCHC)3)
			{
				num = 1;
			}
			Vector3 vector = Vector3.one * 1541f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(604f, 1034f, 590f);
			}
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			this.NEEMJOKELLC.SetVector("RodParams not found!", new Vector4(817f, 1775f, 657f, 259f) * this.sunShaftBlurRadius);
			this.NEEMJOKELLC.SetVector("https://groups.google.com/forum/#!forum/final-ik", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.NEEMJOKELLC.SetVector("", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = base.GetComponent<Camera>().allowHDR ? ((RenderTextureFormat)(-97)) : RenderTextureFormat.Default;
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(false, base.GetComponent<Camera>());
				this.NEEMJOKELLC.SetTexture("SatNightFever", temporary2);
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 7);
			}
			base.PEOKGNODBLK(temporary, this.JCAGOEAEILH);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 0, 2);
			float num2 = this.sunShaftBlurRadius * 142f;
			this.NEEMJOKELLC.SetVector("004000", new Vector4(num2, num2, 735f, 1356f));
			this.NEEMJOKELLC.SetVector("lastConfirmLic", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 1; i < this.radialBlurIterations; i++)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary, temporary3, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 955f + 1851f) * 1455f) / 740f;
				this.NEEMJOKELLC.SetVector("</color>", new Vector4(num2, num2, 1769f, 1802f));
				temporary = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary3, temporary, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 850f + 960f) * 548f) / 1938f;
				this.NEEMJOKELLC.SetVector("fshop_fcost2", new Vector4(num2, num2, 518f, 1644f));
			}
			if (vector.z >= 1374f)
			{
				this.NEEMJOKELLC.SetVector("IceHockey Goalie Save 2", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.NEEMJOKELLC.SetVector("\n", Vector4.zero);
			}
			this.NEEMJOKELLC.SetTexture("_ColorBuffer", temporary);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NEEMJOKELLC, (this.screenBlendMode == SunShafts.IBKJGEFFAMB.Screen) ? 0 : 1);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BB66 RID: 47974 RVA: 0x0053D658 File Offset: 0x0053B858
		public virtual bool BGNOLJBJGEL()
		{
			base.POJDHPJDFEM(this.useDepthTexture);
			this.NEEMJOKELLC = base.BAPJBHPEDIF(this.sunShaftsShader, this.NEEMJOKELLC);
			this.JCAGOEAEILH = base.ALJPMGLOIEG(this.simpleClearShader, this.JCAGOEAEILH);
			if (!this.PPGOAMIHMBG)
			{
				base.INOGPLDHPGC();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BB67 RID: 47975 RVA: 0x0053D6B8 File Offset: 0x0053B8B8
		private void HOACOEINOJB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NHEEDPALBFN())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			int num = 7;
			if (this.resolution == SunShafts.FDGKKEEGCHC.Low)
			{
				num = 7;
			}
			else if (this.resolution == SunShafts.FDGKKEEGCHC.Low)
			{
				num = 0;
			}
			Vector3 vector = Vector3.one * 137f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(32f, 202f, 615f);
			}
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			this.NEEMJOKELLC.SetVector("RollerBladeFrontFlip", new Vector4(290f, 828f, 564f, 1598f) * this.sunShaftBlurRadius);
			this.NEEMJOKELLC.SetVector("Error via pay request", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.NEEMJOKELLC.SetVector(" length is zero, can not solve.", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = base.GetComponent<Camera>().allowHDR ? ((RenderTextureFormat)(-21)) : RenderTextureFormat.ARGB32;
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(false, base.GetComponent<Camera>());
				this.NEEMJOKELLC.SetTexture("Collaps all foldouts", temporary2);
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 2);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 0);
			}
			base.AAHDDBOCPJE(temporary, this.JCAGOEAEILH);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 1, 1);
			float num2 = this.sunShaftBlurRadius * 1927f;
			this.NEEMJOKELLC.SetVector("index", new Vector4(num2, num2, 1858f, 1434f));
			this.NEEMJOKELLC.SetVector("lifeBar", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 1; i < this.radialBlurIterations; i++)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary, temporary3, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 126f + 1636f) * 864f) / 591f;
				this.NEEMJOKELLC.SetVector("OfficeSittingHandRestFingerTap", new Vector4(num2, num2, 1088f, 1203f));
				temporary = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary3, temporary, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 1823f + 702f) * 754f) / 1017f;
				this.NEEMJOKELLC.SetVector("+ACVolumeProxy", new Vector4(num2, num2, 421f, 531f));
			}
			if (vector.z >= 513f)
			{
				this.NEEMJOKELLC.SetVector("_ScreenEdgeFading", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.NEEMJOKELLC.SetVector("UIChat_fontInterval", Vector4.zero);
			}
			this.NEEMJOKELLC.SetTexture("BipedReferences limb is completely stretched out in the initial pose. IK solver can not calculate the default bend plane for the limb. Please make sure you character's limbs are at least slightly bent in the initial pose. First bone: ", temporary);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NEEMJOKELLC, (this.screenBlendMode == SunShafts.IBKJGEFFAMB.Screen) ? 0 : 7);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BB68 RID: 47976 RVA: 0x0053DA78 File Offset: 0x0053BC78
		public virtual bool JCCFBJBBHBP()
		{
			base.CBJDCDELBJN(this.useDepthTexture);
			this.NEEMJOKELLC = base.DJFOEIJIMJB(this.sunShaftsShader, this.NEEMJOKELLC);
			this.JCAGOEAEILH = base.BOOFEOGDMBI(this.simpleClearShader, this.JCAGOEAEILH);
			if (!this.PPGOAMIHMBG)
			{
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BB69 RID: 47977 RVA: 0x0053DAD8 File Offset: 0x0053BCD8
		private void HNPNJCMJKKK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			int num = 7;
			if (this.resolution == SunShafts.FDGKKEEGCHC.Low)
			{
				num = 6;
			}
			else if (this.resolution == (SunShafts.FDGKKEEGCHC)7)
			{
				num = 0;
			}
			Vector3 vector = Vector3.one * 1559f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(833f, 180f, 50f);
			}
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			this.NEEMJOKELLC.SetVector("#> _Wrinkles Occlusion Camera < ", new Vector4(1033f, 100f, 1039f, 784f) * this.sunShaftBlurRadius);
			this.NEEMJOKELLC.SetVector("Prone Locomotion", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.NEEMJOKELLC.SetVector("_FresnelFade", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = base.GetComponent<Camera>().allowHDR ? ((RenderTextureFormat)(-74)) : RenderTextureFormat.ARGB32;
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 1, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(true, base.GetComponent<Camera>());
				this.NEEMJOKELLC.SetTexture("connect already used", temporary2);
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 5);
			}
			base.AAHDDBOCPJE(temporary, this.JCAGOEAEILH);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 0, 0);
			float num2 = this.sunShaftBlurRadius * 1332f;
			this.NEEMJOKELLC.SetVector("IdleTyping", new Vector4(num2, num2, 995f, 713f));
			this.NEEMJOKELLC.SetVector("_Histogram", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 1; i < this.radialBlurIterations; i++)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary, temporary3, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 606f + 1897f) * 1422f) / 1290f;
				this.NEEMJOKELLC.SetVector("Climb to the top of the mountain to see the clouds (WASD keys to move).", new Vector4(num2, num2, 193f, 880f));
				temporary = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary3, temporary, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 702f + 706f) * 50f) / 950f;
				this.NEEMJOKELLC.SetVector("RunBackLeft", new Vector4(num2, num2, 345f, 1834f));
			}
			if (vector.z >= 1347f)
			{
				this.NEEMJOKELLC.SetVector("NextFrame", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.NEEMJOKELLC.SetVector(",", Vector4.zero);
			}
			this.NEEMJOKELLC.SetTexture("#02C85F", temporary);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NEEMJOKELLC, (this.screenBlendMode == SunShafts.IBKJGEFFAMB.Screen) ? 0 : 1);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BB6A RID: 47978 RVA: 0x0053DE98 File Offset: 0x0053C098
		private void ALNHCIOIBPP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.MNDOFMMGLMO())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			int num = 0;
			if (this.resolution == SunShafts.FDGKKEEGCHC.Normal)
			{
				num = 5;
			}
			else if (this.resolution == SunShafts.FDGKKEEGCHC.High)
			{
				num = 0;
			}
			Vector3 vector = Vector3.one * 429f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(1709f, 681f, 798f);
			}
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			this.NEEMJOKELLC.SetVector("Flap_04.wav", new Vector4(567f, 737f, 14f, 1893f) * this.sunShaftBlurRadius);
			this.NEEMJOKELLC.SetVector(" x", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.NEEMJOKELLC.SetVector("isMoving", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = base.GetComponent<Camera>().allowHDR ? ((RenderTextureFormat)121) : RenderTextureFormat.Default;
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 1, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(true, base.GetComponent<Camera>());
				this.NEEMJOKELLC.SetTexture("_History3LumaTex", temporary2);
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 4);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 2);
			}
			base.EMIHIJBJENG(temporary, this.JCAGOEAEILH);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 1, 3);
			float num2 = this.sunShaftBlurRadius * 400f;
			this.NEEMJOKELLC.SetVector("IdleWalk", new Vector4(num2, num2, 1965f, 881f));
			this.NEEMJOKELLC.SetVector("id", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 0; i < this.radialBlurIterations; i += 0)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary, temporary3, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 1774f + 860f) * 638f) / 107f;
				this.NEEMJOKELLC.SetVector("_TintColor", new Vector4(num2, num2, 935f, 20f));
				temporary = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary3, temporary, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 653f + 557f) * 158f) / 423f;
				this.NEEMJOKELLC.SetVector("KneesIdle", new Vector4(num2, num2, 701f, 1525f));
			}
			if (vector.z >= 1664f)
			{
				this.NEEMJOKELLC.SetVector("INTERFACE", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.NEEMJOKELLC.SetVector("ClimbUp", Vector4.zero);
			}
			this.NEEMJOKELLC.SetTexture("Bow Idle", temporary);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NEEMJOKELLC, (this.screenBlendMode == SunShafts.IBKJGEFFAMB.Screen) ? 0 : 1);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BB6B RID: 47979 RVA: 0x0053E258 File Offset: 0x0053C458
		public virtual bool LNHMJPEKJPH()
		{
			base.OFKOBOMCECF(this.useDepthTexture);
			this.NEEMJOKELLC = base.BAPJBHPEDIF(this.sunShaftsShader, this.NEEMJOKELLC);
			this.JCAGOEAEILH = base.IIIIADNBONI(this.simpleClearShader, this.JCAGOEAEILH);
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BB6C RID: 47980 RVA: 0x0053E2B8 File Offset: 0x0053C4B8
		private void OnRenderImage(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			int num = 4;
			if (this.resolution == SunShafts.FDGKKEEGCHC.Normal)
			{
				num = 2;
			}
			else if (this.resolution == SunShafts.FDGKKEEGCHC.High)
			{
				num = 1;
			}
			Vector3 vector = Vector3.one * 0.5f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(0.5f, 0.5f, 0f);
			}
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			this.NEEMJOKELLC.SetVector("_BlurRadius4", new Vector4(1f, 1f, 0f, 0f) * this.sunShaftBlurRadius);
			this.NEEMJOKELLC.SetVector("_SunPosition", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.NEEMJOKELLC.SetVector("_SunThreshold", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = base.GetComponent<Camera>().allowHDR ? RenderTextureFormat.DefaultHDR : RenderTextureFormat.Default;
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(false, base.GetComponent<Camera>());
				this.NEEMJOKELLC.SetTexture("_Skybox", temporary2);
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 3);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 2);
			}
			base.AMLGEFKEOKF(temporary, this.JCAGOEAEILH);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 1, 4);
			float num2 = this.sunShaftBlurRadius * 0.0013020834f;
			this.NEEMJOKELLC.SetVector("_BlurRadius4", new Vector4(num2, num2, 0f, 0f));
			this.NEEMJOKELLC.SetVector("_SunPosition", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 0; i < this.radialBlurIterations; i++)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary, temporary3, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 2f + 1f) * 6f) / 768f;
				this.NEEMJOKELLC.SetVector("_BlurRadius4", new Vector4(num2, num2, 0f, 0f));
				temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary3, temporary, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 2f + 2f) * 6f) / 768f;
				this.NEEMJOKELLC.SetVector("_BlurRadius4", new Vector4(num2, num2, 0f, 0f));
			}
			if (vector.z >= 0f)
			{
				this.NEEMJOKELLC.SetVector("_SunColor", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.NEEMJOKELLC.SetVector("_SunColor", Vector4.zero);
			}
			this.NEEMJOKELLC.SetTexture("_ColorBuffer", temporary);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NEEMJOKELLC, (this.screenBlendMode == SunShafts.IBKJGEFFAMB.Screen) ? 0 : 4);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BB6D RID: 47981 RVA: 0x0053E678 File Offset: 0x0053C878
		public virtual bool MANMIKHECBF()
		{
			base.OLMOAHDIDNG(this.useDepthTexture);
			this.NEEMJOKELLC = base.JBHLGBPJFEL(this.sunShaftsShader, this.NEEMJOKELLC);
			this.JCAGOEAEILH = base.DJFOEIJIMJB(this.simpleClearShader, this.JCAGOEAEILH);
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BB6E RID: 47982 RVA: 0x0053E6D8 File Offset: 0x0053C8D8
		public virtual bool ILBEKBHHEEL()
		{
			base.MGHNCKDCFGL(this.useDepthTexture);
			this.NEEMJOKELLC = base.ALJPMGLOIEG(this.sunShaftsShader, this.NEEMJOKELLC);
			this.JCAGOEAEILH = base.ALJPMGLOIEG(this.simpleClearShader, this.JCAGOEAEILH);
			if (!this.PPGOAMIHMBG)
			{
				base.OAEAMDHOKKM();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BB6F RID: 47983 RVA: 0x0053E738 File Offset: 0x0053C938
		private void FIMIGEPIBFO(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			int num = 2;
			if (this.resolution == SunShafts.FDGKKEEGCHC.Low)
			{
				num = 5;
			}
			else if (this.resolution == (SunShafts.FDGKKEEGCHC)8)
			{
				num = 1;
			}
			Vector3 vector = Vector3.one * 984f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(1247f, 1222f, 273f);
			}
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			this.NEEMJOKELLC.SetVector("wpn_line2", new Vector4(266f, 405f, 6f, 923f) * this.sunShaftBlurRadius);
			this.NEEMJOKELLC.SetVector("RemoveFinger index out of bounds.", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.NEEMJOKELLC.SetVector("wpn_rec1", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = base.GetComponent<Camera>().allowHDR ? ((RenderTextureFormat)122) : RenderTextureFormat.Shadowmap;
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(false, base.GetComponent<Camera>());
				this.NEEMJOKELLC.SetTexture("ClimbRight", temporary2);
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 4);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 0);
			}
			base.DLAECNCPLML(temporary, this.JCAGOEAEILH);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 0, 5);
			float num2 = this.sunShaftBlurRadius * 544f;
			this.NEEMJOKELLC.SetVector("_DelItem.wav", new Vector4(num2, num2, 770f, 149f));
			this.NEEMJOKELLC.SetVector("Flap_07.wav", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 0; i < this.radialBlurIterations; i += 0)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary, temporary3, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 350f + 274f) * 1754f) / 582f;
				this.NEEMJOKELLC.SetVector("*************157 baseid=", new Vector4(num2, num2, 1172f, 1039f));
				temporary = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary3, temporary, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 747f + 1885f) * 1611f) / 993f;
				this.NEEMJOKELLC.SetVector("crft_from", new Vector4(num2, num2, 1050f, 611f));
			}
			if (vector.z >= 1283f)
			{
				this.NEEMJOKELLC.SetVector("WorkerHammer2", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.NEEMJOKELLC.SetVector("[Y]", Vector4.zero);
			}
			this.NEEMJOKELLC.SetTexture("U", temporary);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NEEMJOKELLC, (this.screenBlendMode == SunShafts.IBKJGEFFAMB.Screen) ? 1 : 0);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BB70 RID: 47984 RVA: 0x0053EAF8 File Offset: 0x0053CCF8
		public virtual bool CGJBGGCEBAO()
		{
			base.EBEBJHLBBBI(this.useDepthTexture);
			this.NEEMJOKELLC = base.JBHLGBPJFEL(this.sunShaftsShader, this.NEEMJOKELLC);
			this.JCAGOEAEILH = base.IIIIADNBONI(this.simpleClearShader, this.JCAGOEAEILH);
			if (!this.PPGOAMIHMBG)
			{
				base.FDBKFKGCGEG();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BB71 RID: 47985 RVA: 0x0053EB58 File Offset: 0x0053CD58
		private void JPCPEPMDLAN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			int num = 6;
			if (this.resolution == SunShafts.FDGKKEEGCHC.Low)
			{
				num = 5;
			}
			else if (this.resolution == SunShafts.FDGKKEEGCHC.Low)
			{
				num = 0;
			}
			Vector3 vector = Vector3.one * 1032f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(1096f, 1913f, 1304f);
			}
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			this.NEEMJOKELLC.SetVector("IdleStrafeLeft", new Vector4(1033f, 8f, 1540f, 295f) * this.sunShaftBlurRadius);
			this.NEEMJOKELLC.SetVector("' that does not excist in the Node Chain.", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.NEEMJOKELLC.SetVector("\n", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = base.GetComponent<Camera>().allowHDR ? ((RenderTextureFormat)(-105)) : RenderTextureFormat.Default;
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(false, base.GetComponent<Camera>());
				this.NEEMJOKELLC.SetTexture("error.wav", temporary2);
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 6);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 6);
			}
			base.AAHDDBOCPJE(temporary, this.JCAGOEAEILH);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 0, 3);
			float num2 = this.sunShaftBlurRadius * 685f;
			this.NEEMJOKELLC.SetVector("", new Vector4(num2, num2, 1963f, 661f));
			this.NEEMJOKELLC.SetVector("Wizard 2 Hand Throw", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 0; i < this.radialBlurIterations; i += 0)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary, temporary3, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 593f + 1260f) * 1504f) / 953f;
				this.NEEMJOKELLC.SetVector("_ColorBuffer", new Vector4(num2, num2, 641f, 1075f));
				temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary3, temporary, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 1760f + 1f) * 1703f) / 973f;
				this.NEEMJOKELLC.SetVector("Shader not found ({0})", new Vector4(num2, num2, 669f, 53f));
			}
			if (vector.z >= 1909f)
			{
				this.NEEMJOKELLC.SetVector("Giant2HandSlamIdle", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.NEEMJOKELLC.SetVector("buykey", Vector4.zero);
			}
			this.NEEMJOKELLC.SetTexture("demoLong", temporary);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NEEMJOKELLC, (this.screenBlendMode == SunShafts.IBKJGEFFAMB.Screen) ? 1 : 1);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BB72 RID: 47986 RVA: 0x0053EF18 File Offset: 0x0053D118
		public virtual bool HHCKHLDCKMF()
		{
			base.AHFDGALLKFC(this.useDepthTexture);
			this.NEEMJOKELLC = base.BOOFEOGDMBI(this.sunShaftsShader, this.NEEMJOKELLC);
			this.JCAGOEAEILH = base.OOAOHFFDMJP(this.simpleClearShader, this.JCAGOEAEILH);
			if (!this.PPGOAMIHMBG)
			{
				base.INOGPLDHPGC();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BB73 RID: 47987 RVA: 0x0053EF78 File Offset: 0x0053D178
		public override bool GGJKGIHGMGC()
		{
			base.AHFDGALLKFC(this.useDepthTexture);
			this.NEEMJOKELLC = base.DJFOEIJIMJB(this.sunShaftsShader, this.NEEMJOKELLC);
			this.JCAGOEAEILH = base.OOAOHFFDMJP(this.simpleClearShader, this.JCAGOEAEILH);
			if (!this.PPGOAMIHMBG)
			{
				base.FDBKFKGCGEG();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BB74 RID: 47988 RVA: 0x0053EFD8 File Offset: 0x0053D1D8
		public virtual bool PPJAMONPAPC()
		{
			base.CGEGCOKMPHN(this.useDepthTexture);
			this.NEEMJOKELLC = base.DJFOEIJIMJB(this.sunShaftsShader, this.NEEMJOKELLC);
			this.JCAGOEAEILH = base.IIIIADNBONI(this.simpleClearShader, this.JCAGOEAEILH);
			if (!this.PPGOAMIHMBG)
			{
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BB75 RID: 47989 RVA: 0x0053F038 File Offset: 0x0053D238
		public virtual bool JOGGNPOMFKJ()
		{
			base.DAOKCAOFIGE(this.useDepthTexture);
			this.NEEMJOKELLC = base.DJFOEIJIMJB(this.sunShaftsShader, this.NEEMJOKELLC);
			this.JCAGOEAEILH = base.BOOFEOGDMBI(this.simpleClearShader, this.JCAGOEAEILH);
			if (!this.PPGOAMIHMBG)
			{
				base.OAEAMDHOKKM();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BB76 RID: 47990 RVA: 0x0053F098 File Offset: 0x0053D298
		private void MMLCIGHEHJJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.MNDOFMMGLMO())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			int num = 5;
			if (this.resolution == SunShafts.FDGKKEEGCHC.Normal)
			{
				num = 5;
			}
			else if (this.resolution == (SunShafts.FDGKKEEGCHC)3)
			{
				num = 1;
			}
			Vector3 vector = Vector3.one * 76f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(1608f, 1865f, 807f);
			}
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			this.NEEMJOKELLC.SetVector("Wizard1HandThrow", new Vector4(645f, 957f, 1671f, 1220f) * this.sunShaftBlurRadius);
			this.NEEMJOKELLC.SetVector("{0:0} сек{1}", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.NEEMJOKELLC.SetVector(" ", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = base.GetComponent<Camera>().allowHDR ? ((RenderTextureFormat)(-76)) : RenderTextureFormat.ARGBHalf;
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(true, base.GetComponent<Camera>());
				this.NEEMJOKELLC.SetTexture("stretchWidth", temporary2);
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 2);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 3);
			}
			base.CKGFJOJLAJP(temporary, this.JCAGOEAEILH);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 0, 7);
			float num2 = this.sunShaftBlurRadius * 284f;
			this.NEEMJOKELLC.SetVector("_SSRMultiplier", new Vector4(num2, num2, 1259f, 1192f));
			this.NEEMJOKELLC.SetVector("SneakBackward", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 0; i < this.radialBlurIterations; i++)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary, temporary3, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 1468f + 605f) * 511f) / 684f;
				this.NEEMJOKELLC.SetVector("Flares", new Vector4(num2, num2, 1583f, 1860f));
				temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary3, temporary, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 754f + 717f) * 1225f) / 1235f;
				this.NEEMJOKELLC.SetVector("WoodSaw", new Vector4(num2, num2, 1833f, 783f));
			}
			if (vector.z >= 1044f)
			{
				this.NEEMJOKELLC.SetVector("_Balance", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.NEEMJOKELLC.SetVector("[Steamworks.NET] DllCheck Test returned false, One or more of the Steamworks binaries seems to be the wrong version.", Vector4.zero);
			}
			this.NEEMJOKELLC.SetTexture(" material. Effect disabled.", temporary);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NEEMJOKELLC, (this.screenBlendMode == SunShafts.IBKJGEFFAMB.Screen) ? 1 : 7);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BB77 RID: 47991 RVA: 0x0053F458 File Offset: 0x0053D658
		private void JNGODMMNPEG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			int num = 8;
			if (this.resolution == SunShafts.FDGKKEEGCHC.Low)
			{
				num = 7;
			}
			else if (this.resolution == (SunShafts.FDGKKEEGCHC)8)
			{
				num = 0;
			}
			Vector3 vector = Vector3.one * 893f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(119f, 1641f, 849f);
			}
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			this.NEEMJOKELLC.SetVector(" ", new Vector4(245f, 842f, 185f, 1541f) * this.sunShaftBlurRadius);
			this.NEEMJOKELLC.SetVector("msgClick", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.NEEMJOKELLC.SetVector("Mouse Y", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = base.GetComponent<Camera>().allowHDR ? ((RenderTextureFormat)74) : RenderTextureFormat.Depth;
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 1, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(true, base.GetComponent<Camera>());
				this.NEEMJOKELLC.SetTexture("Shader not found ({0})", temporary2);
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 3);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 3);
			}
			base.CKGFJOJLAJP(temporary, this.JCAGOEAEILH);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 1, 1);
			float num2 = this.sunShaftBlurRadius * 225f;
			this.NEEMJOKELLC.SetVector("first bone position is the same as second bone position.", new Vector4(num2, num2, 376f, 1103f));
			this.NEEMJOKELLC.SetVector("BowInstant2", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 1; i < this.radialBlurIterations; i++)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary, temporary3, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 1765f + 294f) * 1459f) / 706f;
				this.NEEMJOKELLC.SetVector("Crawl Locomotion", new Vector4(num2, num2, 866f, 1881f));
				temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary3, temporary, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 936f + 1635f) * 1808f) / 1440f;
				this.NEEMJOKELLC.SetVector("BendGoal is deprecated, you can now a bend goal from the custom inspector of the LimbIK component.", new Vector4(num2, num2, 975f, 1892f));
			}
			if (vector.z >= 17f)
			{
				this.NEEMJOKELLC.SetVector("/", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.NEEMJOKELLC.SetVector("CrouchStrafeLeft", Vector4.zero);
			}
			this.NEEMJOKELLC.SetTexture("", temporary);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NEEMJOKELLC, (this.screenBlendMode == SunShafts.IBKJGEFFAMB.Screen) ? 1 : 8);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BB78 RID: 47992 RVA: 0x0053F818 File Offset: 0x0053DA18
		private void IECKNMCHKCA(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.DLENDGGGMBJ())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			int num = 5;
			if (this.resolution == SunShafts.FDGKKEEGCHC.Low)
			{
				num = 7;
			}
			else if (this.resolution == SunShafts.FDGKKEEGCHC.Normal)
			{
				num = 0;
			}
			Vector3 vector = Vector3.one * 689f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(166f, 181f, 241f);
			}
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			this.NEEMJOKELLC.SetVector("Flares", new Vector4(257f, 384f, 338f, 1809f) * this.sunShaftBlurRadius);
			this.NEEMJOKELLC.SetVector("ShotgunReloadMagazine", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.NEEMJOKELLC.SetVector("[sysname]", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = base.GetComponent<Camera>().allowHDR ? ((RenderTextureFormat)(-48)) : RenderTextureFormat.ARGBHalf;
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(false, base.GetComponent<Camera>());
				this.NEEMJOKELLC.SetTexture(" %\n", temporary2);
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 5);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 7);
			}
			base.PEOKGNODBLK(temporary, this.JCAGOEAEILH);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 0, 2);
			float num2 = this.sunShaftBlurRadius * 1227f;
			this.NEEMJOKELLC.SetVector("_ScreenSize", new Vector4(num2, num2, 1312f, 919f));
			this.NEEMJOKELLC.SetVector("<color=\"", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 0; i < this.radialBlurIterations; i += 0)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary, temporary3, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 1115f + 1536f) * 1004f) / 517f;
				this.NEEMJOKELLC.SetVector("StaffHeal", new Vector4(num2, num2, 222f, 872f));
				temporary = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary3, temporary, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 503f + 922f) * 156f) / 286f;
				this.NEEMJOKELLC.SetVector("_camScale", new Vector4(num2, num2, 1336f, 242f));
			}
			if (vector.z >= 1878f)
			{
				this.NEEMJOKELLC.SetVector("-no info-", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.NEEMJOKELLC.SetVector(" ", Vector4.zero);
			}
			this.NEEMJOKELLC.SetTexture("", temporary);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NEEMJOKELLC, (this.screenBlendMode == SunShafts.IBKJGEFFAMB.Screen) ? 1 : 1);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BB79 RID: 47993 RVA: 0x0053FBD8 File Offset: 0x0053DDD8
		private void NPAOBLFOMGI(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			int num = 5;
			if (this.resolution == SunShafts.FDGKKEEGCHC.Low)
			{
				num = 8;
			}
			else if (this.resolution == SunShafts.FDGKKEEGCHC.High)
			{
				num = 0;
			}
			Vector3 vector = Vector3.one * 606f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(499f, 617f, 1399f);
			}
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			this.NEEMJOKELLC.SetVector("aptek.ogg", new Vector4(851f, 545f, 37f, 1529f) * this.sunShaftBlurRadius);
			this.NEEMJOKELLC.SetVector("white", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.NEEMJOKELLC.SetVector("bool: ", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = base.GetComponent<Camera>().allowHDR ? RenderTextureFormat.ARGBFloat : RenderTextureFormat.Default;
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 1, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(false, base.GetComponent<Camera>());
				this.NEEMJOKELLC.SetTexture("_InternalLutParams", temporary2);
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 3);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 1);
			}
			base.PEOKGNODBLK(temporary, this.JCAGOEAEILH);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 0, 6);
			float num2 = this.sunShaftBlurRadius * 698f;
			this.NEEMJOKELLC.SetVector("cntx_drop", new Vector4(num2, num2, 232f, 338f));
			this.NEEMJOKELLC.SetVector("", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 1; i < this.radialBlurIterations; i += 0)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary, temporary3, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 45f + 1807f) * 1328f) / 1057f;
				this.NEEMJOKELLC.SetVector("http://steamcommunity.com/sharedfiles/filedetails/?id=788064774", new Vector4(num2, num2, 966f, 1924f));
				temporary = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary3, temporary, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 1332f + 1396f) * 681f) / 1531f;
				this.NEEMJOKELLC.SetVector("Internal Curves Texture", new Vector4(num2, num2, 1944f, 1069f));
			}
			if (vector.z >= 1398f)
			{
				this.NEEMJOKELLC.SetVector("<color='#80a0ff'>{0}</color>", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.NEEMJOKELLC.SetVector("_BloomTex", Vector4.zero);
			}
			this.NEEMJOKELLC.SetTexture("wpn_add/base", temporary);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NEEMJOKELLC, (this.screenBlendMode == SunShafts.IBKJGEFFAMB.Screen) ? 1 : 7);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BB7A RID: 47994 RVA: 0x0053FF98 File Offset: 0x0053E198
		private void EPHHNPMPHOL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NHEEDPALBFN())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			int num = 3;
			if (this.resolution == SunShafts.FDGKKEEGCHC.Low)
			{
				num = 4;
			}
			else if (this.resolution == (SunShafts.FDGKKEEGCHC)6)
			{
				num = 1;
			}
			Vector3 vector = Vector3.one * 788f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(617f, 1857f, 643f);
			}
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			this.NEEMJOKELLC.SetVector("OK auk2KeyMEditOk---2", new Vector4(1295f, 883f, 1890f, 780f) * this.sunShaftBlurRadius);
			this.NEEMJOKELLC.SetVector("shop_t5", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.NEEMJOKELLC.SetVector("Pistol Quick Stab", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = base.GetComponent<Camera>().allowHDR ? ((RenderTextureFormat)(-2)) : RenderTextureFormat.ARGBHalf;
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 1, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(false, base.GetComponent<Camera>());
				this.NEEMJOKELLC.SetTexture("LINEAR", temporary2);
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 7);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 3);
			}
			base.PEOKGNODBLK(temporary, this.JCAGOEAEILH);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 0, 1);
			float num2 = this.sunShaftBlurRadius * 1691f;
			this.NEEMJOKELLC.SetVector("lineDistance=", new Vector4(num2, num2, 1179f, 944f));
			this.NEEMJOKELLC.SetVector("_Power", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 0; i < this.radialBlurIterations; i += 0)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary, temporary3, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 113f + 1534f) * 1979f) / 1219f;
				this.NEEMJOKELLC.SetVector("CodeStage.AntiCheat.ObscuredTypes", new Vector4(num2, num2, 668f, 980f));
				temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary3, temporary, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 1250f + 426f) * 589f) / 1370f;
				this.NEEMJOKELLC.SetVector("TOD_SpaceBrightness", new Vector4(num2, num2, 1889f, 1588f));
			}
			if (vector.z >= 1418f)
			{
				this.NEEMJOKELLC.SetVector("KneesIdle", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.NEEMJOKELLC.SetVector("PistolReload", Vector4.zero);
			}
			this.NEEMJOKELLC.SetTexture("money", temporary);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NEEMJOKELLC, (this.screenBlendMode == SunShafts.IBKJGEFFAMB.Screen) ? 0 : 0);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BB7B RID: 47995 RVA: 0x00540358 File Offset: 0x0053E558
		private void DHBJPMCMCJJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.GGJKGIHGMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			int num = 0;
			if (this.resolution == SunShafts.FDGKKEEGCHC.Low)
			{
				num = 8;
			}
			else if (this.resolution == (SunShafts.FDGKKEEGCHC)4)
			{
				num = 1;
			}
			Vector3 vector = Vector3.one * 885f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(281f, 1761f, 274f);
			}
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			this.NEEMJOKELLC.SetVector("_TileMaxLoop", new Vector4(870f, 575f, 1959f, 668f) * this.sunShaftBlurRadius);
			this.NEEMJOKELLC.SetVector("_TapMedium", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.NEEMJOKELLC.SetVector("No Template! ID=", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = base.GetComponent<Camera>().allowHDR ? RenderTextureFormat.Shadowmap : RenderTextureFormat.Shadowmap;
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 1, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(true, base.GetComponent<Camera>());
				this.NEEMJOKELLC.SetTexture("3", temporary2);
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 7);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 3);
			}
			base.CKGFJOJLAJP(temporary, this.JCAGOEAEILH);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 0, 5);
			float num2 = this.sunShaftBlurRadius * 1548f;
			this.NEEMJOKELLC.SetVector("IdleMouthWipe", new Vector4(num2, num2, 1347f, 360f));
			this.NEEMJOKELLC.SetVector("wpn_eat6", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 0; i < this.radialBlurIterations; i += 0)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary, temporary3, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 1904f + 1736f) * 700f) / 1984f;
				this.NEEMJOKELLC.SetVector("[", new Vector4(num2, num2, 327f, 1322f));
				temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary3, temporary, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 676f + 822f) * 316f) / 1176f;
				this.NEEMJOKELLC.SetVector("ObscuredUInt:", new Vector4(num2, num2, 619f, 1653f));
			}
			if (vector.z >= 982f)
			{
				this.NEEMJOKELLC.SetVector("wdeep", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.NEEMJOKELLC.SetVector("ObscuredShort:", Vector4.zero);
			}
			this.NEEMJOKELLC.SetTexture("wpnend", temporary);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NEEMJOKELLC, (this.screenBlendMode == SunShafts.IBKJGEFFAMB.Screen) ? 1 : 0);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BB7C RID: 47996 RVA: 0x00540718 File Offset: 0x0053E918
		public virtual bool JOAPNOCFFBG()
		{
			base.OAAFLHNDKBJ(this.useDepthTexture);
			this.NEEMJOKELLC = base.DJFOEIJIMJB(this.sunShaftsShader, this.NEEMJOKELLC);
			this.JCAGOEAEILH = base.BAPJBHPEDIF(this.simpleClearShader, this.JCAGOEAEILH);
			if (!this.PPGOAMIHMBG)
			{
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BB7D RID: 47997 RVA: 0x00540778 File Offset: 0x0053E978
		public virtual bool DEHFEHNMOFH()
		{
			base.OFKOBOMCECF(this.useDepthTexture);
			this.NEEMJOKELLC = base.IIIIADNBONI(this.sunShaftsShader, this.NEEMJOKELLC);
			this.JCAGOEAEILH = base.BOOFEOGDMBI(this.simpleClearShader, this.JCAGOEAEILH);
			if (!this.PPGOAMIHMBG)
			{
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BB7E RID: 47998 RVA: 0x005407D8 File Offset: 0x0053E9D8
		private void LOPLBCLLCID(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			int num = 2;
			if (this.resolution == SunShafts.FDGKKEEGCHC.Low)
			{
				num = 7;
			}
			else if (this.resolution == (SunShafts.FDGKKEEGCHC)8)
			{
				num = 1;
			}
			Vector3 vector = Vector3.one * 579f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(993f, 152f, 342f);
			}
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			this.NEEMJOKELLC.SetVector(" has invalid dimensions.", new Vector4(1484f, 1027f, 289f, 722f) * this.sunShaftBlurRadius);
			this.NEEMJOKELLC.SetVector("wpn_add/addoptions", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.NEEMJOKELLC.SetVector("{0}Textures/Turnirs/{1}.png", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = base.GetComponent<Camera>().allowHDR ? ((RenderTextureFormat)(-79)) : RenderTextureFormat.ARGB1555;
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(true, base.GetComponent<Camera>());
				this.NEEMJOKELLC.SetTexture("?", temporary2);
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 2);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 3);
			}
			base.OEMEDKEEGCL(temporary, this.JCAGOEAEILH);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 0, 6);
			float num2 = this.sunShaftBlurRadius * 142f;
			this.NEEMJOKELLC.SetVector("Hidden/Post FX/Eye Adaptation", new Vector4(num2, num2, 627f, 542f));
			this.NEEMJOKELLC.SetVector("", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 1; i < this.radialBlurIterations; i++)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary, temporary3, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 1540f + 967f) * 1136f) / 1368f;
				this.NEEMJOKELLC.SetVector("Keeper Jump", new Vector4(num2, num2, 1063f, 1865f));
				temporary = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary3, temporary, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 1197f + 595f) * 522f) / 394f;
				this.NEEMJOKELLC.SetVector("\n", new Vector4(num2, num2, 1541f, 1742f));
			}
			if (vector.z >= 971f)
			{
				this.NEEMJOKELLC.SetVector("Speed hack detected!", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.NEEMJOKELLC.SetVector(" ", Vector4.zero);
			}
			this.NEEMJOKELLC.SetTexture("", temporary);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NEEMJOKELLC, (this.screenBlendMode == SunShafts.IBKJGEFFAMB.Screen) ? 1 : 6);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BB7F RID: 47999 RVA: 0x00540B98 File Offset: 0x0053ED98
		public virtual bool HMDBGMDFHKH()
		{
			base.DAOKCAOFIGE(this.useDepthTexture);
			this.NEEMJOKELLC = base.BOOFEOGDMBI(this.sunShaftsShader, this.NEEMJOKELLC);
			this.JCAGOEAEILH = base.OOAOHFFDMJP(this.simpleClearShader, this.JCAGOEAEILH);
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BB80 RID: 48000 RVA: 0x00540BF8 File Offset: 0x0053EDF8
		private void MAIGIEENOEJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			int num = 8;
			if (this.resolution == SunShafts.FDGKKEEGCHC.Normal)
			{
				num = 0;
			}
			else if (this.resolution == (SunShafts.FDGKKEEGCHC)3)
			{
				num = 0;
			}
			Vector3 vector = Vector3.one * 1777f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(663f, 87f, 1252f);
			}
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			this.NEEMJOKELLC.SetVector("RoundHouse", new Vector4(1191f, 113f, 1434f, 201f) * this.sunShaftBlurRadius);
			this.NEEMJOKELLC.SetVector("bs_lev", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.NEEMJOKELLC.SetVector("Walk Backward", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = base.GetComponent<Camera>().allowHDR ? ((RenderTextureFormat)60) : RenderTextureFormat.Depth;
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(false, base.GetComponent<Camera>());
				this.NEEMJOKELLC.SetTexture("isMove", temporary2);
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 6);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 2);
			}
			base.KMBFKPFKKFL(temporary, this.JCAGOEAEILH);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 0, 7);
			float num2 = this.sunShaftBlurRadius * 414f;
			this.NEEMJOKELLC.SetVector("#url Sound ", new Vector4(num2, num2, 1410f, 225f));
			this.NEEMJOKELLC.SetVector("Mouse Y", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 1; i < this.radialBlurIterations; i++)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary, temporary3, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 301f + 1500f) * 1821f) / 345f;
				this.NEEMJOKELLC.SetVector("_FresnelFade", new Vector4(num2, num2, 1214f, 689f));
				temporary = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary3, temporary, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 1310f + 406f) * 339f) / 1332f;
				this.NEEMJOKELLC.SetVector("AssetBundleServerURL", new Vector4(num2, num2, 1661f, 1365f));
			}
			if (vector.z >= 1950f)
			{
				this.NEEMJOKELLC.SetVector("no result template ", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.NEEMJOKELLC.SetVector(" tm=", Vector4.zero);
			}
			this.NEEMJOKELLC.SetTexture("Swim Idle", temporary);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NEEMJOKELLC, (this.screenBlendMode == SunShafts.IBKJGEFFAMB.Screen) ? 0 : 4);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BB81 RID: 48001 RVA: 0x00540FB8 File Offset: 0x0053F1B8
		public virtual bool KCGEMCLLBHM()
		{
			base.POJDHPJDFEM(this.useDepthTexture);
			this.NEEMJOKELLC = base.OOAOHFFDMJP(this.sunShaftsShader, this.NEEMJOKELLC);
			this.JCAGOEAEILH = base.BAPJBHPEDIF(this.simpleClearShader, this.JCAGOEAEILH);
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BB82 RID: 48002 RVA: 0x00541018 File Offset: 0x0053F218
		private void MFEOIGILLPF(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			int num = 1;
			if (this.resolution == SunShafts.FDGKKEEGCHC.Normal)
			{
				num = 7;
			}
			else if (this.resolution == (SunShafts.FDGKKEEGCHC)6)
			{
				num = 1;
			}
			Vector3 vector = Vector3.one * 1284f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(252f, 647f, 930f);
			}
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			this.NEEMJOKELLC.SetVector("Window test", new Vector4(958f, 234f, 1195f, 219f) * this.sunShaftBlurRadius);
			this.NEEMJOKELLC.SetVector("{0} {1}", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.NEEMJOKELLC.SetVector("<color='#400000'>", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = base.GetComponent<Camera>().allowHDR ? ((RenderTextureFormat)(-51)) : RenderTextureFormat.Default;
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 1, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(true, base.GetComponent<Camera>());
				this.NEEMJOKELLC.SetTexture("Pointing", temporary2);
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 4);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 6);
			}
			base.AMLGEFKEOKF(temporary, this.JCAGOEAEILH);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 1, 6);
			float num2 = this.sunShaftBlurRadius * 129f;
			this.NEEMJOKELLC.SetVector("_SunColor", new Vector4(num2, num2, 893f, 527f));
			this.NEEMJOKELLC.SetVector("type", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 0; i < this.radialBlurIterations; i += 0)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary, temporary3, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 953f + 366f) * 715f) / 880f;
				this.NEEMJOKELLC.SetVector("  ", new Vector4(num2, num2, 270f, 177f));
				temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary3, temporary, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 359f + 912f) * 1038f) / 1323f;
				this.NEEMJOKELLC.SetVector("_TrNewLider.ogg", new Vector4(num2, num2, 357f, 1197f));
			}
			if (vector.z >= 670f)
			{
				this.NEEMJOKELLC.SetVector("Bases/{0}/", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.NEEMJOKELLC.SetVector("</color>", Vector4.zero);
			}
			this.NEEMJOKELLC.SetTexture("wpn_wgt", temporary);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NEEMJOKELLC, (this.screenBlendMode == SunShafts.IBKJGEFFAMB.Screen) ? 0 : 0);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BB84 RID: 48004 RVA: 0x00541448 File Offset: 0x0053F648
		private void EBLFIONBNIO(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.IGJKBOMMMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			int num = 8;
			if (this.resolution == SunShafts.FDGKKEEGCHC.Normal)
			{
				num = 7;
			}
			else if (this.resolution == SunShafts.FDGKKEEGCHC.Normal)
			{
				num = 1;
			}
			Vector3 vector = Vector3.one * 865f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(937f, 1814f, 813f);
			}
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			this.NEEMJOKELLC.SetVector("restype_", new Vector4(885f, 794f, 1197f, 699f) * this.sunShaftBlurRadius);
			this.NEEMJOKELLC.SetVector("GestureHandUp", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.NEEMJOKELLC.SetVector("gi_inte_3", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = base.GetComponent<Camera>().allowHDR ? RenderTextureFormat.RGFloat : RenderTextureFormat.ARGB2101010;
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(true, base.GetComponent<Camera>());
				this.NEEMJOKELLC.SetTexture("name", temporary2);
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 7);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 8);
			}
			base.AMLGEFKEOKF(temporary, this.JCAGOEAEILH);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 1, 7);
			float num2 = this.sunShaftBlurRadius * 1848f;
			this.NEEMJOKELLC.SetVector("_CosPower", new Vector4(num2, num2, 1091f, 453f));
			this.NEEMJOKELLC.SetVector("The root node, the left thigh and the right thigh bones should ideally form a triangle that is as close to equilateral as possible. Currently the root node bone seems to be very close to the line between the left thigh and the right thigh bones. This might cause unwanted behaviour like the hip turning upside down when pulled by an effector.Please set the root node bone to be one of the higher bones in the spine.", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 0; i < this.radialBlurIterations; i += 0)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary, temporary3, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 1502f + 990f) * 1574f) / 344f;
				this.NEEMJOKELLC.SetVector("IceHockeySlapShot", new Vector4(num2, num2, 1810f, 1885f));
				temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary3, temporary, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 1919f + 1687f) * 767f) / 1865f;
				this.NEEMJOKELLC.SetVector("http://www.root-motion.com/finalikdox/html/page12.html", new Vector4(num2, num2, 146f, 1704f));
			}
			if (vector.z >= 301f)
			{
				this.NEEMJOKELLC.SetVector("Loading ", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.NEEMJOKELLC.SetVector("Cells", Vector4.zero);
			}
			this.NEEMJOKELLC.SetTexture("invn_rec9", temporary);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NEEMJOKELLC, (this.screenBlendMode == SunShafts.IBKJGEFFAMB.Screen) ? 1 : 8);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BB85 RID: 48005 RVA: 0x00541808 File Offset: 0x0053FA08
		private void GAJNNKIFMOG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.GGJKGIHGMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			int num = 4;
			if (this.resolution == SunShafts.FDGKKEEGCHC.Normal)
			{
				num = 3;
			}
			else if (this.resolution == (SunShafts.FDGKKEEGCHC)7)
			{
				num = 1;
			}
			Vector3 vector = Vector3.one * 162f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(1743f, 745f, 1777f);
			}
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			this.NEEMJOKELLC.SetVector("readTurnir STATUS", new Vector4(927f, 487f, 322f, 295f) * this.sunShaftBlurRadius);
			this.NEEMJOKELLC.SetVector("MotorbikeShootBack", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.NEEMJOKELLC.SetVector("cht_msg25", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = base.GetComponent<Camera>().allowHDR ? ((RenderTextureFormat)(-88)) : RenderTextureFormat.ARGBHalf;
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 1, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(true, base.GetComponent<Camera>());
				this.NEEMJOKELLC.SetTexture("error.wav", temporary2);
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 5);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 7);
			}
			base.EMIHIJBJENG(temporary, this.JCAGOEAEILH);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 0, 1);
			float num2 = this.sunShaftBlurRadius * 433f;
			this.NEEMJOKELLC.SetVector("no_change", new Vector4(num2, num2, 196f, 29f));
			this.NEEMJOKELLC.SetVector("Invalid vertex colors assigned to ", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 1; i < this.radialBlurIterations; i += 0)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary, temporary3, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 1572f + 1533f) * 1872f) / 1577f;
				this.NEEMJOKELLC.SetVector("gameComplete", new Vector4(num2, num2, 264f, 846f));
				temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary3, temporary, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 642f + 291f) * 1710f) / 931f;
				this.NEEMJOKELLC.SetVector("Crate Pull", new Vector4(num2, num2, 269f, 1600f));
			}
			if (vector.z >= 446f)
			{
				this.NEEMJOKELLC.SetVector("Start.tif", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.NEEMJOKELLC.SetVector("e806f6", Vector4.zero);
			}
			this.NEEMJOKELLC.SetTexture("[ACTk] <b>[ ObscuredString test ]</b>", temporary);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NEEMJOKELLC, (this.screenBlendMode == SunShafts.IBKJGEFFAMB.Screen) ? 0 : 0);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BB86 RID: 48006 RVA: 0x00541BC8 File Offset: 0x0053FDC8
		private void ENEONPFCPMP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.GGJKGIHGMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			int num = 7;
			if (this.resolution == SunShafts.FDGKKEEGCHC.Low)
			{
				num = 0;
			}
			else if (this.resolution == (SunShafts.FDGKKEEGCHC)4)
			{
				num = 0;
			}
			Vector3 vector = Vector3.one * 456f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(791f, 1546f, 830f);
			}
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			this.NEEMJOKELLC.SetVector("", new Vector4(440f, 783f, 1834f, 1111f) * this.sunShaftBlurRadius);
			this.NEEMJOKELLC.SetVector("LOC_NAMES", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.NEEMJOKELLC.SetVector(" ", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = base.GetComponent<Camera>().allowHDR ? ((RenderTextureFormat)(-125)) : RenderTextureFormat.Depth;
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 1, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(true, base.GetComponent<Camera>());
				this.NEEMJOKELLC.SetTexture("SwimDogPaddle", temporary2);
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 8);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 7);
			}
			base.KMBFKPFKKFL(temporary, this.JCAGOEAEILH);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 0, 7);
			float num2 = this.sunShaftBlurRadius * 28f;
			this.NEEMJOKELLC.SetVector("pempty=0", new Vector4(num2, num2, 1057f, 209f));
			this.NEEMJOKELLC.SetVector("_TextureSize", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 1; i < this.radialBlurIterations; i++)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary, temporary3, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 1255f + 118f) * 1109f) / 1026f;
				this.NEEMJOKELLC.SetVector("selColor", new Vector4(num2, num2, 2f, 1526f));
				temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary3, temporary, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 1255f + 833f) * 1173f) / 87f;
				this.NEEMJOKELLC.SetVector("_PixelsPerMeterAtOneMeter", new Vector4(num2, num2, 858f, 1290f));
			}
			if (vector.z >= 1961f)
			{
				this.NEEMJOKELLC.SetVector(" has been disabled as it requires a depth texture.", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.NEEMJOKELLC.SetVector("_Transparency", Vector4.zero);
			}
			this.NEEMJOKELLC.SetTexture("****************  playMusicBase ", temporary);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NEEMJOKELLC, (this.screenBlendMode == SunShafts.IBKJGEFFAMB.Screen) ? 0 : 5);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BB87 RID: 48007 RVA: 0x00541F88 File Offset: 0x00540188
		private void LEICKKKLDAD(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.GGJKGIHGMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			int num = 1;
			if (this.resolution == SunShafts.FDGKKEEGCHC.Normal)
			{
				num = 7;
			}
			else if (this.resolution == (SunShafts.FDGKKEEGCHC)8)
			{
				num = 1;
			}
			Vector3 vector = Vector3.one * 265f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(291f, 797f, 1240f);
			}
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			this.NEEMJOKELLC.SetVector("WoodCut", new Vector4(1101f, 669f, 822f, 560f) * this.sunShaftBlurRadius);
			this.NEEMJOKELLC.SetVector("BaseMaterial", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.NEEMJOKELLC.SetVector("CardPlayerIdle", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = base.GetComponent<Camera>().allowHDR ? ((RenderTextureFormat)93) : RenderTextureFormat.Default;
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 1, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(false, base.GetComponent<Camera>());
				this.NEEMJOKELLC.SetTexture("WorkerPickaxe2", temporary2);
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 4);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 4);
			}
			base.AMLGEFKEOKF(temporary, this.JCAGOEAEILH);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 0, 2);
			float num2 = this.sunShaftBlurRadius * 599f;
			this.NEEMJOKELLC.SetVector(" ms", new Vector4(num2, num2, 1898f, 1433f));
			this.NEEMJOKELLC.SetVector("1 Hand Heavy Swing", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 1; i < this.radialBlurIterations; i++)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary, temporary3, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 1770f + 329f) * 1483f) / 1068f;
				this.NEEMJOKELLC.SetVector("collar", new Vector4(num2, num2, 1502f, 800f));
				temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary3, temporary, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 645f + 1600f) * 1032f) / 163f;
				this.NEEMJOKELLC.SetVector("ShotgunReadyFire", new Vector4(num2, num2, 1890f, 4f));
			}
			if (vector.z >= 1307f)
			{
				this.NEEMJOKELLC.SetVector("LocationGui.getI is null", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.NEEMJOKELLC.SetVector("PrimaryCausticsProjector", Vector4.zero);
			}
			this.NEEMJOKELLC.SetTexture("No Way points!", temporary);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NEEMJOKELLC, (this.screenBlendMode == SunShafts.IBKJGEFFAMB.Screen) ? 0 : 8);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BB88 RID: 48008 RVA: 0x00542348 File Offset: 0x00540548
		private void BDMFOHGCKBM(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.IGJKBOMMMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			int num = 5;
			if (this.resolution == SunShafts.FDGKKEEGCHC.Low)
			{
				num = 2;
			}
			else if (this.resolution == SunShafts.FDGKKEEGCHC.High)
			{
				num = 0;
			}
			Vector3 vector = Vector3.one * 1808f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(848f, 1183f, 1933f);
			}
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			this.NEEMJOKELLC.SetVector("_WrinkleOcclusionMap2", new Vector4(1764f, 615f, 1052f, 957f) * this.sunShaftBlurRadius);
			this.NEEMJOKELLC.SetVector("NadeThrow", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.NEEMJOKELLC.SetVector("ComeHere", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = base.GetComponent<Camera>().allowHDR ? ((RenderTextureFormat)(-127)) : RenderTextureFormat.Shadowmap;
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(false, base.GetComponent<Camera>());
				this.NEEMJOKELLC.SetTexture(" ms", temporary2);
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 5);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 3);
			}
			base.KMBFKPFKKFL(temporary, this.JCAGOEAEILH);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 1, 6);
			float num2 = this.sunShaftBlurRadius * 1419f;
			this.NEEMJOKELLC.SetVector("No load asset ", new Vector4(num2, num2, 1682f, 738f));
			this.NEEMJOKELLC.SetVector("Roller Blade Front Flip", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 1; i < this.radialBlurIterations; i += 0)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary, temporary3, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 1866f + 1925f) * 763f) / 1911f;
				this.NEEMJOKELLC.SetVector("_FrustumCornersWS", new Vector4(num2, num2, 1674f, 478f));
				temporary = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary3, temporary, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 1382f + 1876f) * 173f) / 1833f;
				this.NEEMJOKELLC.SetVector("\n", new Vector4(num2, num2, 1456f, 1646f));
			}
			if (vector.z >= 1750f)
			{
				this.NEEMJOKELLC.SetVector("ff2000", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.NEEMJOKELLC.SetVector("idlist", Vector4.zero);
			}
			this.NEEMJOKELLC.SetTexture("_info", temporary);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NEEMJOKELLC, (this.screenBlendMode == SunShafts.IBKJGEFFAMB.Screen) ? 1 : 5);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BB89 RID: 48009 RVA: 0x00542708 File Offset: 0x00540908
		public virtual bool DPCKBGJGNAK()
		{
			base.CDBNBLBOLCL(this.useDepthTexture);
			this.NEEMJOKELLC = base.BAPJBHPEDIF(this.sunShaftsShader, this.NEEMJOKELLC);
			this.JCAGOEAEILH = base.BOOFEOGDMBI(this.simpleClearShader, this.JCAGOEAEILH);
			if (!this.PPGOAMIHMBG)
			{
				base.FDBKFKGCGEG();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BB8A RID: 48010 RVA: 0x00542768 File Offset: 0x00540968
		private void HGBMMLPBFAL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.GGJKGIHGMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			int num = 3;
			if (this.resolution == SunShafts.FDGKKEEGCHC.Low)
			{
				num = 6;
			}
			else if (this.resolution == (SunShafts.FDGKKEEGCHC)6)
			{
				num = 1;
			}
			Vector3 vector = Vector3.one * 992f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(617f, 472f, 81f);
			}
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			this.NEEMJOKELLC.SetVector("invn_rec3", new Vector4(1630f, 646f, 184f, 337f) * this.sunShaftBlurRadius);
			this.NEEMJOKELLC.SetVector("#02C85F", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.NEEMJOKELLC.SetVector("fire on", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = base.GetComponent<Camera>().allowHDR ? ((RenderTextureFormat)117) : RenderTextureFormat.ARGB1555;
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(true, base.GetComponent<Camera>());
				this.NEEMJOKELLC.SetTexture("_FogColor", temporary2);
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 2);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 8);
			}
			base.CKGFJOJLAJP(temporary, this.JCAGOEAEILH);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 0, 8);
			float num2 = this.sunShaftBlurRadius * 410f;
			this.NEEMJOKELLC.SetVector("PoplDrop", new Vector4(num2, num2, 1828f, 1526f));
			this.NEEMJOKELLC.SetVector("[Attachments] Failed to find MeshFilter on the attachments object '{0}'.", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 0; i < this.radialBlurIterations; i += 0)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary, temporary3, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 1949f + 1286f) * 1078f) / 387f;
				this.NEEMJOKELLC.SetVector("Unknow CMD:", new Vector4(num2, num2, 390f, 1259f));
				temporary = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary3, temporary, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 1572f + 424f) * 16f) / 218f;
				this.NEEMJOKELLC.SetVector("_VelocityScale", new Vector4(num2, num2, 448f, 1533f));
			}
			if (vector.z >= 1881f)
			{
				this.NEEMJOKELLC.SetVector(" ", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.NEEMJOKELLC.SetVector("1=", Vector4.zero);
			}
			this.NEEMJOKELLC.SetTexture("post_9", temporary);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NEEMJOKELLC, (this.screenBlendMode == SunShafts.IBKJGEFFAMB.Screen) ? 1 : 5);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BB8B RID: 48011 RVA: 0x00542B28 File Offset: 0x00540D28
		private void OJBKOLJAHAO(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.MNDOFMMGLMO())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			int num = 4;
			if (this.resolution == SunShafts.FDGKKEEGCHC.Low)
			{
				num = 3;
			}
			else if (this.resolution == (SunShafts.FDGKKEEGCHC)5)
			{
				num = 0;
			}
			Vector3 vector = Vector3.one * 999f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(1488f, 333f, 175f);
			}
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			this.NEEMJOKELLC.SetVector("Unarmed", new Vector4(348f, 74f, 185f, 665f) * this.sunShaftBlurRadius);
			this.NEEMJOKELLC.SetVector("", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.NEEMJOKELLC.SetVector("{0} {1}", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = base.GetComponent<Camera>().allowHDR ? ((RenderTextureFormat)33) : RenderTextureFormat.ARGB32;
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(true, base.GetComponent<Camera>());
				this.NEEMJOKELLC.SetTexture("No klev! shance=", temporary2);
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 5);
			}
			base.DLAECNCPLML(temporary, this.JCAGOEAEILH);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 0, 1);
			float num2 = this.sunShaftBlurRadius * 144f;
			this.NEEMJOKELLC.SetVector("_MinVelocity", new Vector4(num2, num2, 1329f, 974f));
			this.NEEMJOKELLC.SetVector(".", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 1; i < this.radialBlurIterations; i++)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary, temporary3, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 489f + 800f) * 602f) / 807f;
				this.NEEMJOKELLC.SetVector("money", new Vector4(num2, num2, 591f, 622f));
				temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary3, temporary, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 1213f + 1603f) * 520f) / 397f;
				this.NEEMJOKELLC.SetVector("WizardNeoBlock", new Vector4(num2, num2, 687f, 1186f));
			}
			if (vector.z >= 1934f)
			{
				this.NEEMJOKELLC.SetVector("fshop_header", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.NEEMJOKELLC.SetVector("\n\n ", Vector4.zero);
			}
			this.NEEMJOKELLC.SetTexture("some kind of resizing horror", temporary);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NEEMJOKELLC, (this.screenBlendMode == SunShafts.IBKJGEFFAMB.Screen) ? 1 : 7);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BB8C RID: 48012 RVA: 0x00542EE8 File Offset: 0x005410E8
		private void EGOKABFLKGC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.DLENDGGGMBJ())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			int num = 8;
			if (this.resolution == SunShafts.FDGKKEEGCHC.Normal)
			{
				num = 3;
			}
			else if (this.resolution == SunShafts.FDGKKEEGCHC.High)
			{
				num = 1;
			}
			Vector3 vector = Vector3.one * 1737f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(1590f, 696f, 1f);
			}
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			this.NEEMJOKELLC.SetVector("Pricorm count=", new Vector4(1864f, 70f, 880f, 1456f) * this.sunShaftBlurRadius);
			this.NEEMJOKELLC.SetVector("", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.NEEMJOKELLC.SetVector("ClimbLeft", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = base.GetComponent<Camera>().allowHDR ? ((RenderTextureFormat)(-116)) : RenderTextureFormat.Shadowmap;
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(false, base.GetComponent<Camera>());
				this.NEEMJOKELLC.SetTexture("#url Sound ", temporary2);
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 6);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 3);
			}
			base.DLAECNCPLML(temporary, this.JCAGOEAEILH);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 1, 7);
			float num2 = this.sunShaftBlurRadius * 1119f;
			this.NEEMJOKELLC.SetVector("WateringCanWatering", new Vector4(num2, num2, 1510f, 1901f));
			this.NEEMJOKELLC.SetVector("selectTitulId=", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 0; i < this.radialBlurIterations; i += 0)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary, temporary3, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 1374f + 309f) * 1339f) / 1333f;
				this.NEEMJOKELLC.SetVector("time", new Vector4(num2, num2, 1521f, 81f));
				temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary3, temporary, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 1075f + 1836f) * 379f) / 594f;
				this.NEEMJOKELLC.SetVector("1HandSwordStrafeLeft", new Vector4(num2, num2, 1954f, 1868f));
			}
			if (vector.z >= 1895f)
			{
				this.NEEMJOKELLC.SetVector("MotorbikeHeartAttack", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.NEEMJOKELLC.SetVector("BAG", Vector4.zero);
			}
			this.NEEMJOKELLC.SetTexture("MovementZ", temporary);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NEEMJOKELLC, (this.screenBlendMode == SunShafts.IBKJGEFFAMB.Screen) ? 1 : 1);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BB8D RID: 48013 RVA: 0x005432A8 File Offset: 0x005414A8
		private void BIJMHMEDHDC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.MNDOFMMGLMO())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			int num = 0;
			if (this.resolution == SunShafts.FDGKKEEGCHC.Normal)
			{
				num = 8;
			}
			else if (this.resolution == (SunShafts.FDGKKEEGCHC)3)
			{
				num = 0;
			}
			Vector3 vector = Vector3.one * 777f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(1642f, 1742f, 108f);
			}
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			this.NEEMJOKELLC.SetVector("ArmFlex3", new Vector4(73f, 640f, 443f, 1960f) * this.sunShaftBlurRadius);
			this.NEEMJOKELLC.SetVector("Flap_00.wav", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.NEEMJOKELLC.SetVector("Can only get root and pelvis positions from IKSolverVR. GetPosition index out of range.", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = base.GetComponent<Camera>().allowHDR ? ((RenderTextureFormat)63) : RenderTextureFormat.ARGB32;
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(false, base.GetComponent<Camera>());
				this.NEEMJOKELLC.SetTexture(" \n", temporary2);
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 3);
			}
			base.AMLGEFKEOKF(temporary, this.JCAGOEAEILH);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 1, 3);
			float num2 = this.sunShaftBlurRadius * 903f;
			this.NEEMJOKELLC.SetVector("level", new Vector4(num2, num2, 1610f, 842f));
			this.NEEMJOKELLC.SetVector("<color='#a060ff'>{0}</color>: {1}", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 0; i < this.radialBlurIterations; i += 0)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary, temporary3, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 1445f + 1502f) * 1255f) / 1398f;
				this.NEEMJOKELLC.SetVector("_", new Vector4(num2, num2, 168f, 107f));
				temporary = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary3, temporary, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 1031f + 359f) * 243f) / 1152f;
				this.NEEMJOKELLC.SetVector("OfficeSittingLegCross", new Vector4(num2, num2, 55f, 310f));
			}
			if (vector.z >= 1268f)
			{
				this.NEEMJOKELLC.SetVector("", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.NEEMJOKELLC.SetVector("SkateForward", Vector4.zero);
			}
			this.NEEMJOKELLC.SetTexture("Skateboard", temporary);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NEEMJOKELLC, (this.screenBlendMode == SunShafts.IBKJGEFFAMB.Screen) ? 1 : 5);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BB8E RID: 48014 RVA: 0x00543668 File Offset: 0x00541868
		public virtual bool CHJBCBDIBJJ()
		{
			base.PKDIKFGAJKM(this.useDepthTexture);
			this.NEEMJOKELLC = base.JBHLGBPJFEL(this.sunShaftsShader, this.NEEMJOKELLC);
			this.JCAGOEAEILH = base.BAPJBHPEDIF(this.simpleClearShader, this.JCAGOEAEILH);
			if (!this.PPGOAMIHMBG)
			{
				base.OAEAMDHOKKM();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BB8F RID: 48015 RVA: 0x005436C8 File Offset: 0x005418C8
		private void GFBELBBAJGD(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.GGJKGIHGMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			int num = 0;
			if (this.resolution == SunShafts.FDGKKEEGCHC.Normal)
			{
				num = 3;
			}
			else if (this.resolution == (SunShafts.FDGKKEEGCHC)3)
			{
				num = 0;
			}
			Vector3 vector = Vector3.one * 310f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(280f, 1227f, 1671f);
			}
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			this.NEEMJOKELLC.SetVector("Biped's root Transform's position should be at ground level relative to the character (at the character's feet not at it's pelvis).", new Vector4(685f, 635f, 1650f, 1284f) * this.sunShaftBlurRadius);
			this.NEEMJOKELLC.SetVector("Flares", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.NEEMJOKELLC.SetVector(" ", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = base.GetComponent<Camera>().allowHDR ? ((RenderTextureFormat)83) : RenderTextureFormat.Default;
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(false, base.GetComponent<Camera>());
				this.NEEMJOKELLC.SetTexture("_OcclusionTexture", temporary2);
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 8);
			}
			base.KMBFKPFKKFL(temporary, this.JCAGOEAEILH);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 1, 0);
			float num2 = this.sunShaftBlurRadius * 1441f;
			this.NEEMJOKELLC.SetVector("walk", new Vector4(num2, num2, 671f, 85f));
			this.NEEMJOKELLC.SetVector("_ZCurve", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 1; i < this.radialBlurIterations; i++)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary, temporary3, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 1994f + 793f) * 1029f) / 1780f;
				this.NEEMJOKELLC.SetVector("Tenkoku DynamicSky", new Vector4(num2, num2, 1608f, 1407f));
				temporary = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary3, temporary, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 90f + 438f) * 1018f) / 1692f;
				this.NEEMJOKELLC.SetVector("_noinfo", new Vector4(num2, num2, 704f, 815f));
			}
			if (vector.z >= 250f)
			{
				this.NEEMJOKELLC.SetVector("Idle Come Here", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.NEEMJOKELLC.SetVector("_FarCorner", Vector4.zero);
			}
			this.NEEMJOKELLC.SetTexture("}", temporary);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NEEMJOKELLC, (this.screenBlendMode == SunShafts.IBKJGEFFAMB.Screen) ? 0 : 1);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BB90 RID: 48016 RVA: 0x00543A88 File Offset: 0x00541C88
		private void NPNOACPLOCB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.GGJKGIHGMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			int num = 8;
			if (this.resolution == SunShafts.FDGKKEEGCHC.Low)
			{
				num = 0;
			}
			else if (this.resolution == SunShafts.FDGKKEEGCHC.Normal)
			{
				num = 1;
			}
			Vector3 vector = Vector3.one * 1722f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(1723f, 532f, 1411f);
			}
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			this.NEEMJOKELLC.SetVector("FOG_EXP", new Vector4(1039f, 711f, 905f, 94f) * this.sunShaftBlurRadius);
			this.NEEMJOKELLC.SetVector("_FinalBlendParameters", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.NEEMJOKELLC.SetVector("RunBackward", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = base.GetComponent<Camera>().allowHDR ? ((RenderTextureFormat)(-3)) : RenderTextureFormat.RGB565;
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(true, base.GetComponent<Camera>());
				this.NEEMJOKELLC.SetTexture("IKMappingLimb is referencing to a bone '", temporary2);
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 4);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 6);
			}
			base.AMLGEFKEOKF(temporary, this.JCAGOEAEILH);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 1, 7);
			float num2 = this.sunShaftBlurRadius * 1893f;
			this.NEEMJOKELLC.SetVector("CrouchStrafeRight", new Vector4(num2, num2, 1837f, 813f));
			this.NEEMJOKELLC.SetVector("_History3Weight", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 1; i < this.radialBlurIterations; i++)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary, temporary3, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 1722f + 161f) * 726f) / 270f;
				this.NEEMJOKELLC.SetVector("<.*?>", new Vector4(num2, num2, 364f, 1123f));
				temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary3, temporary, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 505f + 662f) * 1483f) / 1326f;
				this.NEEMJOKELLC.SetVector("", new Vector4(num2, num2, 497f, 536f));
			}
			if (vector.z >= 1938f)
			{
				this.NEEMJOKELLC.SetVector("StaffStand", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.NEEMJOKELLC.SetVector("No Mask", Vector4.zero);
			}
			this.NEEMJOKELLC.SetTexture("IceHockeyGoalieReady", temporary);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NEEMJOKELLC, (this.screenBlendMode == SunShafts.IBKJGEFFAMB.Screen) ? 1 : 0);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BB91 RID: 48017 RVA: 0x00543E48 File Offset: 0x00542048
		public virtual bool OJFBHAHHDNC()
		{
			base.POJDHPJDFEM(this.useDepthTexture);
			this.NEEMJOKELLC = base.JBHLGBPJFEL(this.sunShaftsShader, this.NEEMJOKELLC);
			this.JCAGOEAEILH = base.DJFOEIJIMJB(this.simpleClearShader, this.JCAGOEAEILH);
			if (!this.PPGOAMIHMBG)
			{
				base.FDBKFKGCGEG();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BB92 RID: 48018 RVA: 0x00543EA8 File Offset: 0x005420A8
		private void JHHHJFOOFII(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			int num = 2;
			if (this.resolution == SunShafts.FDGKKEEGCHC.Normal)
			{
				num = 2;
			}
			else if (this.resolution == (SunShafts.FDGKKEEGCHC)4)
			{
				num = 0;
			}
			Vector3 vector = Vector3.one * 1246f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(1664f, 1387f, 176f);
			}
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			this.NEEMJOKELLC.SetVector("WATER_SIMPLE", new Vector4(1111f, 1759f, 1864f, 1175f) * this.sunShaftBlurRadius);
			this.NEEMJOKELLC.SetVector("Jump", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.NEEMJOKELLC.SetVector("?", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = base.GetComponent<Camera>().allowHDR ? ((RenderTextureFormat)(-27)) : RenderTextureFormat.ARGBHalf;
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(true, base.GetComponent<Camera>());
				this.NEEMJOKELLC.SetTexture("FacePalm", temporary2);
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 8);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 6);
			}
			base.DLAECNCPLML(temporary, this.JCAGOEAEILH);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 1, 8);
			float num2 = this.sunShaftBlurRadius * 748f;
			this.NEEMJOKELLC.SetVector("DropType", new Vector4(num2, num2, 666f, 1852f));
			this.NEEMJOKELLC.SetVector("GiantEat", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 1; i < this.radialBlurIterations; i++)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary, temporary3, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 271f + 392f) * 1316f) / 388f;
				this.NEEMJOKELLC.SetVector("turn_state", new Vector4(num2, num2, 1728f, 227f));
				temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary3, temporary, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 1166f + 781f) * 877f) / 152f;
				this.NEEMJOKELLC.SetVector("root", new Vector4(num2, num2, 1630f, 1937f));
			}
			if (vector.z >= 166f)
			{
				this.NEEMJOKELLC.SetVector("_Intensity", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.NEEMJOKELLC.SetVector("1=", Vector4.zero);
			}
			this.NEEMJOKELLC.SetTexture("CUSTOM_COLOR_ON", temporary);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NEEMJOKELLC, (this.screenBlendMode == SunShafts.IBKJGEFFAMB.Screen) ? 1 : 1);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BB93 RID: 48019 RVA: 0x00544268 File Offset: 0x00542468
		private void JEHHGMJKLPB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			int num = 2;
			if (this.resolution == SunShafts.FDGKKEEGCHC.Low)
			{
				num = 0;
			}
			else if (this.resolution == (SunShafts.FDGKKEEGCHC)8)
			{
				num = 0;
			}
			Vector3 vector = Vector3.one * 1376f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(1678f, 503f, 465f);
			}
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			this.NEEMJOKELLC.SetVector(" гр ", new Vector4(1388f, 709f, 1146f, 686f) * this.sunShaftBlurRadius);
			this.NEEMJOKELLC.SetVector("Reflection", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.NEEMJOKELLC.SetVector("_HalfResolution", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = base.GetComponent<Camera>().allowHDR ? ((RenderTextureFormat)(-120)) : RenderTextureFormat.ARGB2101010;
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 1, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(true, base.GetComponent<Camera>());
				this.NEEMJOKELLC.SetTexture("", temporary2);
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 5);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 3);
			}
			base.EMIHIJBJENG(temporary, this.JCAGOEAEILH);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 0, 2);
			float num2 = this.sunShaftBlurRadius * 63f;
			this.NEEMJOKELLC.SetVector("MotorbikeWheely", new Vector4(num2, num2, 33f, 1914f));
			this.NEEMJOKELLC.SetVector("wpn_add/base", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 1; i < this.radialBlurIterations; i++)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary, temporary3, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 822f + 1394f) * 973f) / 1134f;
				this.NEEMJOKELLC.SetVector(" ms", new Vector4(num2, num2, 172f, 1971f));
				temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary3, temporary, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 1364f + 1730f) * 653f) / 653f;
				this.NEEMJOKELLC.SetVector("+{0}", new Vector4(num2, num2, 1849f, 726f));
			}
			if (vector.z >= 449f)
			{
				this.NEEMJOKELLC.SetVector("SUNSHINE_FILTER_PCF_3x3", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.NEEMJOKELLC.SetVector("wpn_wgt", Vector4.zero);
			}
			this.NEEMJOKELLC.SetTexture("auk_swtcost", temporary);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NEEMJOKELLC, (this.screenBlendMode == SunShafts.IBKJGEFFAMB.Screen) ? 1 : 6);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BB94 RID: 48020 RVA: 0x00544628 File Offset: 0x00542828
		public virtual bool KPDPMCNDNOA()
		{
			base.DAOKCAOFIGE(this.useDepthTexture);
			this.NEEMJOKELLC = base.IIIIADNBONI(this.sunShaftsShader, this.NEEMJOKELLC);
			this.JCAGOEAEILH = base.BAPJBHPEDIF(this.simpleClearShader, this.JCAGOEAEILH);
			if (!this.PPGOAMIHMBG)
			{
				base.OAEAMDHOKKM();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BB95 RID: 48021 RVA: 0x00544688 File Offset: 0x00542888
		public virtual bool POKDAEAADAC()
		{
			base.MGHNCKDCFGL(this.useDepthTexture);
			this.NEEMJOKELLC = base.ALJPMGLOIEG(this.sunShaftsShader, this.NEEMJOKELLC);
			this.JCAGOEAEILH = base.JBHLGBPJFEL(this.simpleClearShader, this.JCAGOEAEILH);
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BB96 RID: 48022 RVA: 0x005446E8 File Offset: 0x005428E8
		private void PKNBABMJLPB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.GGJKGIHGMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			int num = 3;
			if (this.resolution == SunShafts.FDGKKEEGCHC.Normal)
			{
				num = 2;
			}
			else if (this.resolution == (SunShafts.FDGKKEEGCHC)7)
			{
				num = 0;
			}
			Vector3 vector = Vector3.one * 481f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(945f, 1010f, 1656f);
			}
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			this.NEEMJOKELLC.SetVector("ОК", new Vector4(1542f, 1680f, 44f, 819f) * this.sunShaftBlurRadius);
			this.NEEMJOKELLC.SetVector("[fish]", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.NEEMJOKELLC.SetVector("_TreatBackfaceHitAsMiss", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = base.GetComponent<Camera>().allowHDR ? ((RenderTextureFormat)63) : RenderTextureFormat.ARGB2101010;
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(false, base.GetComponent<Camera>());
				this.NEEMJOKELLC.SetTexture("<color='#001020'><i>", temporary2);
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 8);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 8);
			}
			base.AAHDDBOCPJE(temporary, this.JCAGOEAEILH);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 0, 5);
			float num2 = this.sunShaftBlurRadius * 1117f;
			this.NEEMJOKELLC.SetVector("Ready Fight", new Vector4(num2, num2, 1832f, 1615f));
			this.NEEMJOKELLC.SetVector("_BaseTex", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 0; i < this.radialBlurIterations; i += 0)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary, temporary3, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 739f + 1791f) * 983f) / 607f;
				this.NEEMJOKELLC.SetVector(" ms", new Vector4(num2, num2, 1956f, 73f));
				temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary3, temporary, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 213f + 1673f) * 172f) / 569f;
				this.NEEMJOKELLC.SetVector("===== ObscuredVector3Test =====\n", new Vector4(num2, num2, 788f, 405f));
			}
			if (vector.z >= 981f)
			{
				this.NEEMJOKELLC.SetVector("", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.NEEMJOKELLC.SetVector("", Vector4.zero);
			}
			this.NEEMJOKELLC.SetTexture("128", temporary);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NEEMJOKELLC, (this.screenBlendMode == SunShafts.IBKJGEFFAMB.Screen) ? 1 : 0);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BB97 RID: 48023 RVA: 0x00544AA8 File Offset: 0x00542CA8
		public override bool CheckResources()
		{
			base.DAOKCAOFIGE(this.useDepthTexture);
			this.NEEMJOKELLC = base.DJFOEIJIMJB(this.sunShaftsShader, this.NEEMJOKELLC);
			this.JCAGOEAEILH = base.DJFOEIJIMJB(this.simpleClearShader, this.JCAGOEAEILH);
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BB98 RID: 48024 RVA: 0x00544B08 File Offset: 0x00542D08
		private void MGOBAHLJJNL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			int num = 7;
			if (this.resolution == SunShafts.FDGKKEEGCHC.Normal)
			{
				num = 3;
			}
			else if (this.resolution == SunShafts.FDGKKEEGCHC.Low)
			{
				num = 1;
			}
			Vector3 vector = Vector3.one * 820f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(1288f, 1507f, 1908f);
			}
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			this.NEEMJOKELLC.SetVector("OfficeSitting", new Vector4(1901f, 372f, 865f, 1325f) * this.sunShaftBlurRadius);
			this.NEEMJOKELLC.SetVector("_isSelect", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.NEEMJOKELLC.SetVector("_TaaParams", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = base.GetComponent<Camera>().allowHDR ? ((RenderTextureFormat)(-2)) : RenderTextureFormat.Shadowmap;
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(false, base.GetComponent<Camera>());
				this.NEEMJOKELLC.SetTexture("Nub", temporary2);
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 2);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 3);
			}
			base.EMIHIJBJENG(temporary, this.JCAGOEAEILH);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 1, 2);
			float num2 = this.sunShaftBlurRadius * 143f;
			this.NEEMJOKELLC.SetVector("WoodSaw", new Vector4(num2, num2, 1991f, 624f));
			this.NEEMJOKELLC.SetVector("Whistle", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 1; i < this.radialBlurIterations; i += 0)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary, temporary3, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 1713f + 294f) * 1393f) / 969f;
				this.NEEMJOKELLC.SetVector("wpn_eat5", new Vector4(num2, num2, 211f, 1070f));
				temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary3, temporary, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 1457f + 1597f) * 408f) / 1919f;
				this.NEEMJOKELLC.SetVector("IdleStrafeRight", new Vector4(num2, num2, 1457f, 1885f));
			}
			if (vector.z >= 517f)
			{
				this.NEEMJOKELLC.SetVector("error.wav", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.NEEMJOKELLC.SetVector("", Vector4.zero);
			}
			this.NEEMJOKELLC.SetTexture("800000", temporary);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NEEMJOKELLC, (this.screenBlendMode == SunShafts.IBKJGEFFAMB.Screen) ? 1 : 8);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BB99 RID: 48025 RVA: 0x00544EC8 File Offset: 0x005430C8
		private void NBJKFLNHFOF(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			int num = 0;
			if (this.resolution == SunShafts.FDGKKEEGCHC.Normal)
			{
				num = 8;
			}
			else if (this.resolution == (SunShafts.FDGKKEEGCHC)5)
			{
				num = 0;
			}
			Vector3 vector = Vector3.one * 1973f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(809f, 433f, 147f);
			}
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			this.NEEMJOKELLC.SetVector("crft_crft", new Vector4(1479f, 220f, 26f, 361f) * this.sunShaftBlurRadius);
			this.NEEMJOKELLC.SetVector("#0080ff", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.NEEMJOKELLC.SetVector(", ", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = base.GetComponent<Camera>().allowHDR ? ((RenderTextureFormat)(-64)) : RenderTextureFormat.Depth;
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 1, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(false, base.GetComponent<Camera>());
				this.NEEMJOKELLC.SetTexture("IceHockeyShotRight", temporary2);
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 8);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 1);
			}
			base.KMBFKPFKKFL(temporary, this.JCAGOEAEILH);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 0, 0);
			float num2 = this.sunShaftBlurRadius * 763f;
			this.NEEMJOKELLC.SetVector("KatanaReady", new Vector4(num2, num2, 247f, 1747f));
			this.NEEMJOKELLC.SetVector("isRodInWater", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 1; i < this.radialBlurIterations; i += 0)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary, temporary3, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 854f + 107f) * 1566f) / 438f;
				this.NEEMJOKELLC.SetVector("KatanaReady", new Vector4(num2, num2, 691f, 543f));
				temporary = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary3, temporary, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 1462f + 647f) * 781f) / 548f;
				this.NEEMJOKELLC.SetVector("WATER_VERTEX_DISPLACEMENT_ON", new Vector4(num2, num2, 708f, 1512f));
			}
			if (vector.z >= 313f)
			{
				this.NEEMJOKELLC.SetVector("_MaxCoC", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.NEEMJOKELLC.SetVector("Move camera around freely with WASD and mouse.", Vector4.zero);
			}
			this.NEEMJOKELLC.SetTexture("WpnTemplateMgr is init", temporary);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NEEMJOKELLC, (this.screenBlendMode == SunShafts.IBKJGEFFAMB.Screen) ? 1 : 8);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BB9A RID: 48026 RVA: 0x00545288 File Offset: 0x00543488
		private void BMJCNICLDEK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.GGJKGIHGMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			int num = 2;
			if (this.resolution == SunShafts.FDGKKEEGCHC.Normal)
			{
				num = 2;
			}
			else if (this.resolution == SunShafts.FDGKKEEGCHC.Low)
			{
				num = 0;
			}
			Vector3 vector = Vector3.one * 937f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(19f, 420f, 366f);
			}
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			this.NEEMJOKELLC.SetVector("Sewing", new Vector4(1274f, 1358f, 157f, 1809f) * this.sunShaftBlurRadius);
			this.NEEMJOKELLC.SetVector("", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.NEEMJOKELLC.SetVector("wpn_chair3", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = base.GetComponent<Camera>().allowHDR ? ((RenderTextureFormat)(-60)) : RenderTextureFormat.ARGB4444;
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 1, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(true, base.GetComponent<Camera>());
				this.NEEMJOKELLC.SetTexture("_BokehParams", temporary2);
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 5);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 6);
			}
			base.OEMEDKEEGCL(temporary, this.JCAGOEAEILH);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 0, 5);
			float num2 = this.sunShaftBlurRadius * 334f;
			this.NEEMJOKELLC.SetVector("cht_msg3", new Vector4(num2, num2, 1537f, 543f));
			this.NEEMJOKELLC.SetVector("type_", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 0; i < this.radialBlurIterations; i += 0)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary, temporary3, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 1753f + 1481f) * 1977f) / 1118f;
				this.NEEMJOKELLC.SetVector("IdleKeepBack", new Vector4(num2, num2, 524f, 627f));
				temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary3, temporary, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 367f + 455f) * 237f) / 1267f;
				this.NEEMJOKELLC.SetVector("Seat Stand Wheely", new Vector4(num2, num2, 42f, 417f));
			}
			if (vector.z >= 753f)
			{
				this.NEEMJOKELLC.SetVector("<color='#003000'>", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.NEEMJOKELLC.SetVector("Hidden/FXAA3", Vector4.zero);
			}
			this.NEEMJOKELLC.SetTexture("_DitheringTexture", temporary);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NEEMJOKELLC, (this.screenBlendMode == SunShafts.IBKJGEFFAMB.Screen) ? 1 : 4);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BB9B RID: 48027 RVA: 0x00545648 File Offset: 0x00543848
		public virtual bool LKFFFIBABBF()
		{
			base.CBJDCDELBJN(this.useDepthTexture);
			this.NEEMJOKELLC = base.BAPJBHPEDIF(this.sunShaftsShader, this.NEEMJOKELLC);
			this.JCAGOEAEILH = base.ALJPMGLOIEG(this.simpleClearShader, this.JCAGOEAEILH);
			if (!this.PPGOAMIHMBG)
			{
				base.OAEAMDHOKKM();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BB9C RID: 48028 RVA: 0x005456A8 File Offset: 0x005438A8
		public virtual bool GEHBEOAIAKA()
		{
			base.MGHNCKDCFGL(this.useDepthTexture);
			this.NEEMJOKELLC = base.BOOFEOGDMBI(this.sunShaftsShader, this.NEEMJOKELLC);
			this.JCAGOEAEILH = base.OOAOHFFDMJP(this.simpleClearShader, this.JCAGOEAEILH);
			if (!this.PPGOAMIHMBG)
			{
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BB9D RID: 48029 RVA: 0x00545708 File Offset: 0x00543908
		public virtual bool PDMJHKLDPLC()
		{
			base.BGIALJEIEFO(this.useDepthTexture);
			this.NEEMJOKELLC = base.OOAOHFFDMJP(this.sunShaftsShader, this.NEEMJOKELLC);
			this.JCAGOEAEILH = base.OOAOHFFDMJP(this.simpleClearShader, this.JCAGOEAEILH);
			if (!this.PPGOAMIHMBG)
			{
				base.FDBKFKGCGEG();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BB9E RID: 48030 RVA: 0x00545768 File Offset: 0x00543968
		private void JMFAMACDLNN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.MNDOFMMGLMO())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			int num = 4;
			if (this.resolution == SunShafts.FDGKKEEGCHC.Low)
			{
				num = 3;
			}
			else if (this.resolution == (SunShafts.FDGKKEEGCHC)7)
			{
				num = 0;
			}
			Vector3 vector = Vector3.one * 708f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(480f, 1253f, 927f);
			}
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			this.NEEMJOKELLC.SetVector("_BlurSize", new Vector4(1955f, 1502f, 1312f, 1981f) * this.sunShaftBlurRadius);
			this.NEEMJOKELLC.SetVector("_WrinkleInfluences1", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.NEEMJOKELLC.SetVector("[X]", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = base.GetComponent<Camera>().allowHDR ? ((RenderTextureFormat)68) : RenderTextureFormat.Depth;
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 1, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(false, base.GetComponent<Camera>());
				this.NEEMJOKELLC.SetTexture("error.wav", temporary2);
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 2);
			}
			base.KMBFKPFKKFL(temporary, this.JCAGOEAEILH);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 1, 8);
			float num2 = this.sunShaftBlurRadius * 910f;
			this.NEEMJOKELLC.SetVector("BowFire", new Vector4(num2, num2, 1220f, 258f));
			this.NEEMJOKELLC.SetVector("simple", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 1; i < this.radialBlurIterations; i++)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary, temporary3, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 60f + 346f) * 1868f) / 46f;
				this.NEEMJOKELLC.SetVector("Sexy Dance 2", new Vector4(num2, num2, 99f, 1480f));
				temporary = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary3, temporary, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 101f + 992f) * 1353f) / 1503f;
				this.NEEMJOKELLC.SetVector("ArmFlex6", new Vector4(num2, num2, 945f, 627f));
			}
			if (vector.z >= 1445f)
			{
				this.NEEMJOKELLC.SetVector("iPoint", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.NEEMJOKELLC.SetVector("Hidden/Post FX/Blit", Vector4.zero);
			}
			this.NEEMJOKELLC.SetTexture("enableFog", temporary);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NEEMJOKELLC, (this.screenBlendMode == SunShafts.IBKJGEFFAMB.Screen) ? 0 : 8);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BB9F RID: 48031 RVA: 0x00545B28 File Offset: 0x00543D28
		public virtual bool FGDOAAAPBCP()
		{
			base.CDBNBLBOLCL(this.useDepthTexture);
			this.NEEMJOKELLC = base.DJFOEIJIMJB(this.sunShaftsShader, this.NEEMJOKELLC);
			this.JCAGOEAEILH = base.ALJPMGLOIEG(this.simpleClearShader, this.JCAGOEAEILH);
			if (!this.PPGOAMIHMBG)
			{
				base.NAIBIABADFB();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBA0 RID: 48032 RVA: 0x00545B88 File Offset: 0x00543D88
		private void MIJCMMIJPEE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			int num = 0;
			if (this.resolution == SunShafts.FDGKKEEGCHC.Low)
			{
				num = 6;
			}
			else if (this.resolution == SunShafts.FDGKKEEGCHC.Low)
			{
				num = 1;
			}
			Vector3 vector = Vector3.one * 1652f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(747f, 287f, 474f);
			}
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			this.NEEMJOKELLC.SetVector("knopje.wav", new Vector4(1606f, 1075f, 1628f, 937f) * this.sunShaftBlurRadius);
			this.NEEMJOKELLC.SetVector("Crate Push", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.NEEMJOKELLC.SetVector("SecondaryCausticsProjector", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = base.GetComponent<Camera>().allowHDR ? ((RenderTextureFormat)(-14)) : RenderTextureFormat.RGB565;
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(true, base.GetComponent<Camera>());
				this.NEEMJOKELLC.SetTexture("FrontKick", temporary2);
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 7);
			}
			base.EMIHIJBJENG(temporary, this.JCAGOEAEILH);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 0, 6);
			float num2 = this.sunShaftBlurRadius * 1840f;
			this.NEEMJOKELLC.SetVector("<color='#300000'>{0} {1}</color>", new Vector4(num2, num2, 1975f, 905f));
			this.NEEMJOKELLC.SetVector("NextFrame", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 0; i < this.radialBlurIterations; i++)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary, temporary3, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 1821f + 1332f) * 154f) / 1759f;
				this.NEEMJOKELLC.SetVector("SoccerKeeperDiveStrafeFarLeft", new Vector4(num2, num2, 570f, 1940f));
				temporary = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary3, temporary, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 1450f + 1035f) * 1218f) / 1757f;
				this.NEEMJOKELLC.SetVector("8 samples", new Vector4(num2, num2, 1914f, 621f));
			}
			if (vector.z >= 50f)
			{
				this.NEEMJOKELLC.SetVector("En", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.NEEMJOKELLC.SetVector("wpn_tank2", Vector4.zero);
			}
			this.NEEMJOKELLC.SetTexture("demoUint", temporary);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NEEMJOKELLC, (this.screenBlendMode == SunShafts.IBKJGEFFAMB.Screen) ? 0 : 6);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BBA1 RID: 48033 RVA: 0x00545F48 File Offset: 0x00544148
		private void EDBHDEOMGFP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NHEEDPALBFN())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			int num = 2;
			if (this.resolution == SunShafts.FDGKKEEGCHC.Low)
			{
				num = 4;
			}
			else if (this.resolution == (SunShafts.FDGKKEEGCHC)3)
			{
				num = 0;
			}
			Vector3 vector = Vector3.one * 518f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(13f, 313f, 1381f);
			}
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			this.NEEMJOKELLC.SetVector("", new Vector4(785f, 550f, 1198f, 1063f) * this.sunShaftBlurRadius);
			this.NEEMJOKELLC.SetVector("KarateGreet", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.NEEMJOKELLC.SetVector("OneHandSwordBackSwing", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = base.GetComponent<Camera>().allowHDR ? ((RenderTextureFormat)(-34)) : RenderTextureFormat.Depth;
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(false, base.GetComponent<Camera>());
				this.NEEMJOKELLC.SetTexture("Hip", temporary2);
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 4);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 4);
			}
			base.DLAECNCPLML(temporary, this.JCAGOEAEILH);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 0, 2);
			float num2 = this.sunShaftBlurRadius * 32f;
			this.NEEMJOKELLC.SetVector(" ms", new Vector4(num2, num2, 18f, 1773f));
			this.NEEMJOKELLC.SetVector("_BilateralUpsampling", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 1; i < this.radialBlurIterations; i += 0)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary, temporary3, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 735f + 1230f) * 1217f) / 1854f;
				this.NEEMJOKELLC.SetVector("_FogData2", new Vector4(num2, num2, 647f, 767f));
				temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary3, temporary, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 87f + 847f) * 1151f) / 773f;
				this.NEEMJOKELLC.SetVector("{0}/{1}", new Vector4(num2, num2, 495f, 522f));
			}
			if (vector.z >= 1977f)
			{
				this.NEEMJOKELLC.SetVector("BlurDepthTollerance", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.NEEMJOKELLC.SetVector("IceHockeyIdle", Vector4.zero);
			}
			this.NEEMJOKELLC.SetTexture("CrouchStrafeLeft", temporary);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NEEMJOKELLC, (this.screenBlendMode == SunShafts.IBKJGEFFAMB.Screen) ? 1 : 3);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BBA2 RID: 48034 RVA: 0x00546308 File Offset: 0x00544508
		private void PHFJDPLOKJK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			int num = 2;
			if (this.resolution == SunShafts.FDGKKEEGCHC.Normal)
			{
				num = 7;
			}
			else if (this.resolution == SunShafts.FDGKKEEGCHC.Normal)
			{
				num = 1;
			}
			Vector3 vector = Vector3.one * 1936f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(1625f, 434f, 1371f);
			}
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			this.NEEMJOKELLC.SetVector("IdleReadyLook", new Vector4(321f, 284f, 1792f, 474f) * this.sunShaftBlurRadius);
			this.NEEMJOKELLC.SetVector("OneHandSwordReady", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.NEEMJOKELLC.SetVector("** Panel save position", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = base.GetComponent<Camera>().allowHDR ? ((RenderTextureFormat)74) : RenderTextureFormat.Default;
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(true, base.GetComponent<Camera>());
				this.NEEMJOKELLC.SetTexture("LHandWeight", temporary2);
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 3);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 1);
			}
			base.AAHDDBOCPJE(temporary, this.JCAGOEAEILH);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 1, 0);
			float num2 = this.sunShaftBlurRadius * 1822f;
			this.NEEMJOKELLC.SetVector("<color='#200080'>", new Vector4(num2, num2, 1128f, 850f));
			this.NEEMJOKELLC.SetVector("act_orderb_", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 0; i < this.radialBlurIterations; i += 0)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary, temporary3, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 1423f + 370f) * 35f) / 1007f;
				this.NEEMJOKELLC.SetVector("Demo 2 scene: move with WASD. Advance to find the rotating sign which will make the fog disappear.", new Vector4(num2, num2, 914f, 1334f));
				temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary3, temporary, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 1590f + 110f) * 1322f) / 856f;
				this.NEEMJOKELLC.SetVector("_Offsets", new Vector4(num2, num2, 1707f, 869f));
			}
			if (vector.z >= 558f)
			{
				this.NEEMJOKELLC.SetVector(" ", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.NEEMJOKELLC.SetVector("fish/", Vector4.zero);
			}
			this.NEEMJOKELLC.SetTexture("error.wav", temporary);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NEEMJOKELLC, (this.screenBlendMode == SunShafts.IBKJGEFFAMB.Screen) ? 0 : 8);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BBA3 RID: 48035 RVA: 0x005466C8 File Offset: 0x005448C8
		public virtual bool BAPNBLIHPLB()
		{
			base.OAAFLHNDKBJ(this.useDepthTexture);
			this.NEEMJOKELLC = base.IIIIADNBONI(this.sunShaftsShader, this.NEEMJOKELLC);
			this.JCAGOEAEILH = base.JBHLGBPJFEL(this.simpleClearShader, this.JCAGOEAEILH);
			if (!this.PPGOAMIHMBG)
			{
				base.FDBKFKGCGEG();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBA4 RID: 48036 RVA: 0x00546728 File Offset: 0x00544928
		public virtual bool NOCHDCDPIID()
		{
			base.OFKOBOMCECF(this.useDepthTexture);
			this.NEEMJOKELLC = base.ALJPMGLOIEG(this.sunShaftsShader, this.NEEMJOKELLC);
			this.JCAGOEAEILH = base.BAPJBHPEDIF(this.simpleClearShader, this.JCAGOEAEILH);
			if (!this.PPGOAMIHMBG)
			{
				base.LNEHBOJIBAI();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBA5 RID: 48037 RVA: 0x00546788 File Offset: 0x00544988
		private void ICAFCFEMCCK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			int num = 2;
			if (this.resolution == SunShafts.FDGKKEEGCHC.Low)
			{
				num = 3;
			}
			else if (this.resolution == (SunShafts.FDGKKEEGCHC)8)
			{
				num = 1;
			}
			Vector3 vector = Vector3.one * 1519f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(171f, 1328f, 1452f);
			}
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			this.NEEMJOKELLC.SetVector("Game saved using ObscuredPrefs. Try to find and change saved data now! ;)", new Vector4(276f, 1521f, 303f, 122f) * this.sunShaftBlurRadius);
			this.NEEMJOKELLC.SetVector("", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.NEEMJOKELLC.SetVector("RollerBladeGrindRoyale", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = base.GetComponent<Camera>().allowHDR ? ((RenderTextureFormat)(-32)) : RenderTextureFormat.RGB565;
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 1, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(true, base.GetComponent<Camera>());
				this.NEEMJOKELLC.SetTexture("Cloth_05_00.wav", temporary2);
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 8);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 1);
			}
			base.PEOKGNODBLK(temporary, this.JCAGOEAEILH);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 1, 5);
			float num2 = this.sunShaftBlurRadius * 1166f;
			this.NEEMJOKELLC.SetVector("inv_money", new Vector4(num2, num2, 1877f, 1290f));
			this.NEEMJOKELLC.SetVector("Cloth_05_00.wav", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 0; i < this.radialBlurIterations; i++)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary, temporary3, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 330f + 1313f) * 601f) / 171f;
				this.NEEMJOKELLC.SetVector("no_perk", new Vector4(num2, num2, 1545f, 230f));
				temporary = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary3, temporary, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 1453f + 1500f) * 1731f) / 867f;
				this.NEEMJOKELLC.SetVector("rod.lineDistance = ", new Vector4(num2, num2, 1352f, 1737f));
			}
			if (vector.z >= 1047f)
			{
				this.NEEMJOKELLC.SetVector("_Density", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.NEEMJOKELLC.SetVector("GestureCrowdPump", Vector4.zero);
			}
			this.NEEMJOKELLC.SetTexture("weight", temporary);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NEEMJOKELLC, (this.screenBlendMode == SunShafts.IBKJGEFFAMB.Screen) ? 1 : 7);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BBA6 RID: 48038 RVA: 0x00546B48 File Offset: 0x00544D48
		private void PMHDOMMHBPG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			int num = 1;
			if (this.resolution == SunShafts.FDGKKEEGCHC.Normal)
			{
				num = 6;
			}
			else if (this.resolution == (SunShafts.FDGKKEEGCHC)8)
			{
				num = 1;
			}
			Vector3 vector = Vector3.one * 448f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(1296f, 796f, 749f);
			}
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			this.NEEMJOKELLC.SetVector(" on effect ", new Vector4(1928f, 1299f, 1323f, 728f) * this.sunShaftBlurRadius);
			this.NEEMJOKELLC.SetVector("TOD_Sky2World", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.NEEMJOKELLC.SetVector("CrawlLocomotion", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = base.GetComponent<Camera>().allowHDR ? ((RenderTextureFormat)(-101)) : RenderTextureFormat.ARGB1555;
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(true, base.GetComponent<Camera>());
				this.NEEMJOKELLC.SetTexture("QUEST CMD ", temporary2);
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 3);
			}
			base.DLAECNCPLML(temporary, this.JCAGOEAEILH);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 1, 0);
			float num2 = this.sunShaftBlurRadius * 1532f;
			this.NEEMJOKELLC.SetVector("dd\\/MM\\/yyyy HH:mm", new Vector4(num2, num2, 1509f, 16f));
			this.NEEMJOKELLC.SetVector("pf2m", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 0; i < this.radialBlurIterations; i++)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary, temporary3, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 626f + 727f) * 1612f) / 969f;
				this.NEEMJOKELLC.SetVector("_ColorBuffer", new Vector4(num2, num2, 147f, 1225f));
				temporary = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary3, temporary, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 1787f + 139f) * 1259f) / 1672f;
				this.NEEMJOKELLC.SetVector(" гр ", new Vector4(num2, num2, 14f, 92f));
			}
			if (vector.z >= 243f)
			{
				this.NEEMJOKELLC.SetVector("move", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.NEEMJOKELLC.SetVector("No Cell wpn.cell=", Vector4.zero);
			}
			this.NEEMJOKELLC.SetTexture("{0}", temporary);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NEEMJOKELLC, (this.screenBlendMode == SunShafts.IBKJGEFFAMB.Screen) ? 0 : 5);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BBA7 RID: 48039 RVA: 0x00546F08 File Offset: 0x00545108
		public virtual bool NAEJFOJDLCC()
		{
			base.OLMOAHDIDNG(this.useDepthTexture);
			this.NEEMJOKELLC = base.DJFOEIJIMJB(this.sunShaftsShader, this.NEEMJOKELLC);
			this.JCAGOEAEILH = base.OOAOHFFDMJP(this.simpleClearShader, this.JCAGOEAEILH);
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBA8 RID: 48040 RVA: 0x00546F68 File Offset: 0x00545168
		private void FEKDECGCLCJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.GGJKGIHGMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			int num = 6;
			if (this.resolution == SunShafts.FDGKKEEGCHC.Low)
			{
				num = 2;
			}
			else if (this.resolution == SunShafts.FDGKKEEGCHC.Normal)
			{
				num = 0;
			}
			Vector3 vector = Vector3.one * 887f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(694f, 354f, 554f);
			}
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			this.NEEMJOKELLC.SetVector("act_orderb_", new Vector4(721f, 608f, 1332f, 448f) * this.sunShaftBlurRadius);
			this.NEEMJOKELLC.SetVector("error: mainAsset is null", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.NEEMJOKELLC.SetVector("<color='{2}'>{0}: {1}</color>", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = base.GetComponent<Camera>().allowHDR ? ((RenderTextureFormat)(-126)) : RenderTextureFormat.Shadowmap;
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 1, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(true, base.GetComponent<Camera>());
				this.NEEMJOKELLC.SetTexture("IdleMonster", temporary2);
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 6);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 3);
			}
			base.EMIHIJBJENG(temporary, this.JCAGOEAEILH);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 1, 0);
			float num2 = this.sunShaftBlurRadius * 1758f;
			this.NEEMJOKELLC.SetVector("", new Vector4(num2, num2, 467f, 1454f));
			this.NEEMJOKELLC.SetVector("ushort:", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 0; i < this.radialBlurIterations; i += 0)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary, temporary3, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 1172f + 112f) * 1586f) / 565f;
				this.NEEMJOKELLC.SetVector("Show History (messages : {0})", new Vector4(num2, num2, 1458f, 1140f));
				temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary3, temporary, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 1768f + 1092f) * 1211f) / 1832f;
				this.NEEMJOKELLC.SetVector("</color>\n", new Vector4(num2, num2, 1936f, 134f));
			}
			if (vector.z >= 1366f)
			{
				this.NEEMJOKELLC.SetVector("SwimDogPaddle", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.NEEMJOKELLC.SetVector("_LerpAmount", Vector4.zero);
			}
			this.NEEMJOKELLC.SetTexture("#02C85F", temporary);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NEEMJOKELLC, (this.screenBlendMode == SunShafts.IBKJGEFFAMB.Screen) ? 1 : 4);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BBA9 RID: 48041 RVA: 0x00547328 File Offset: 0x00545528
		public virtual bool NKJMMEKEFEI()
		{
			base.EBEBJHLBBBI(this.useDepthTexture);
			this.NEEMJOKELLC = base.DJFOEIJIMJB(this.sunShaftsShader, this.NEEMJOKELLC);
			this.JCAGOEAEILH = base.DJFOEIJIMJB(this.simpleClearShader, this.JCAGOEAEILH);
			if (!this.PPGOAMIHMBG)
			{
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBAA RID: 48042 RVA: 0x00547388 File Offset: 0x00545588
		private void AOKONFCALDF(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			int num = 1;
			if (this.resolution == SunShafts.FDGKKEEGCHC.Low)
			{
				num = 0;
			}
			else if (this.resolution == SunShafts.FDGKKEEGCHC.High)
			{
				num = 0;
			}
			Vector3 vector = Vector3.one * 548f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(588f, 1488f, 1644f);
			}
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			this.NEEMJOKELLC.SetVector("", new Vector4(1978f, 167f, 1436f, 783f) * this.sunShaftBlurRadius);
			this.NEEMJOKELLC.SetVector("crft_from", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.NEEMJOKELLC.SetVector("wpn_onlyw", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = base.GetComponent<Camera>().allowHDR ? ((RenderTextureFormat)(-87)) : RenderTextureFormat.ARGB4444;
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(false, base.GetComponent<Camera>());
				this.NEEMJOKELLC.SetTexture("OfficeSittingReadingPageFlip", temporary2);
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 8);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 0);
			}
			base.PEOKGNODBLK(temporary, this.JCAGOEAEILH);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 0, 6);
			float num2 = this.sunShaftBlurRadius * 1662f;
			this.NEEMJOKELLC.SetVector("{not_found}", new Vector4(num2, num2, 1536f, 1658f));
			this.NEEMJOKELLC.SetVector("Idle Dodge Left", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 0; i < this.radialBlurIterations; i += 0)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary, temporary3, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 1043f + 732f) * 955f) / 1192f;
				this.NEEMJOKELLC.SetVector("inv already open", new Vector4(num2, num2, 199f, 1297f));
				temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary3, temporary, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 1065f + 402f) * 633f) / 469f;
				this.NEEMJOKELLC.SetVector("_Gain", new Vector4(num2, num2, 1551f, 8f));
			}
			if (vector.z >= 969f)
			{
				this.NEEMJOKELLC.SetVector("", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.NEEMJOKELLC.SetVector("holesFree", Vector4.zero);
			}
			this.NEEMJOKELLC.SetTexture("SoundMgr is init part 1", temporary);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NEEMJOKELLC, (this.screenBlendMode == SunShafts.IBKJGEFFAMB.Screen) ? 0 : 8);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BBAB RID: 48043 RVA: 0x00547748 File Offset: 0x00545948
		public virtual bool DCEJLCLOCJC()
		{
			base.DAOKCAOFIGE(this.useDepthTexture);
			this.NEEMJOKELLC = base.OOAOHFFDMJP(this.sunShaftsShader, this.NEEMJOKELLC);
			this.JCAGOEAEILH = base.DJFOEIJIMJB(this.simpleClearShader, this.JCAGOEAEILH);
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBAC RID: 48044 RVA: 0x005477A8 File Offset: 0x005459A8
		public virtual bool PKLOCPBBHNH()
		{
			base.OFKOBOMCECF(this.useDepthTexture);
			this.NEEMJOKELLC = base.BAPJBHPEDIF(this.sunShaftsShader, this.NEEMJOKELLC);
			this.JCAGOEAEILH = base.BAPJBHPEDIF(this.simpleClearShader, this.JCAGOEAEILH);
			if (!this.PPGOAMIHMBG)
			{
				base.NAIBIABADFB();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBAD RID: 48045 RVA: 0x00547808 File Offset: 0x00545A08
		private void EFEHHALJILL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.DLENDGGGMBJ())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			int num = 0;
			if (this.resolution == SunShafts.FDGKKEEGCHC.Normal)
			{
				num = 8;
			}
			else if (this.resolution == SunShafts.FDGKKEEGCHC.Normal)
			{
				num = 1;
			}
			Vector3 vector = Vector3.one * 1059f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(1000f, 1814f, 892f);
			}
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			this.NEEMJOKELLC.SetVector("_Overlay", new Vector4(1958f, 251f, 765f, 321f) * this.sunShaftBlurRadius);
			this.NEEMJOKELLC.SetVector("MotorbikeTurnLeft", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.NEEMJOKELLC.SetVector("level", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = base.GetComponent<Camera>().allowHDR ? ((RenderTextureFormat)(-6)) : RenderTextureFormat.ARGB32;
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(true, base.GetComponent<Camera>());
				this.NEEMJOKELLC.SetTexture(", point ", temporary2);
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 5);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 3);
			}
			base.AAHDDBOCPJE(temporary, this.JCAGOEAEILH);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 1, 7);
			float num2 = this.sunShaftBlurRadius * 1954f;
			this.NEEMJOKELLC.SetVector(" ", new Vector4(num2, num2, 1046f, 238f));
			this.NEEMJOKELLC.SetVector("RollerBladeCrossoverLeft", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 1; i < this.radialBlurIterations; i++)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary, temporary3, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 167f + 758f) * 1976f) / 1257f;
				this.NEEMJOKELLC.SetVector("inv_bonus", new Vector4(num2, num2, 390f, 34f));
				temporary = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary3, temporary, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 792f + 309f) * 663f) / 924f;
				this.NEEMJOKELLC.SetVector("shop_wl", new Vector4(num2, num2, 1111f, 209f));
			}
			if (vector.z >= 1304f)
			{
				this.NEEMJOKELLC.SetVector("CraftProf.xml", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.NEEMJOKELLC.SetVector("' is not a valid integer", Vector4.zero);
			}
			this.NEEMJOKELLC.SetTexture("CheckResources () for ", temporary);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NEEMJOKELLC, (this.screenBlendMode == SunShafts.IBKJGEFFAMB.Screen) ? 0 : 1);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BBAE RID: 48046 RVA: 0x00547BC8 File Offset: 0x00545DC8
		private void DNPIJGHMNGK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			int num = 5;
			if (this.resolution == SunShafts.FDGKKEEGCHC.Low)
			{
				num = 3;
			}
			else if (this.resolution == (SunShafts.FDGKKEEGCHC)3)
			{
				num = 1;
			}
			Vector3 vector = Vector3.one * 296f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(1492f, 1385f, 1491f);
			}
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			this.NEEMJOKELLC.SetVector("CrawlLocomotion", new Vector4(1127f, 1718f, 666f, 12f) * this.sunShaftBlurRadius);
			this.NEEMJOKELLC.SetVector("?", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.NEEMJOKELLC.SetVector("_Offsets", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = base.GetComponent<Camera>().allowHDR ? ((RenderTextureFormat)(-19)) : RenderTextureFormat.ARGB1555;
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 1, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(false, base.GetComponent<Camera>());
				this.NEEMJOKELLC.SetTexture("DITHERING", temporary2);
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 5);
			}
			base.AMLGEFKEOKF(temporary, this.JCAGOEAEILH);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 1, 0);
			float num2 = this.sunShaftBlurRadius * 122f;
			this.NEEMJOKELLC.SetVector("lifeBar", new Vector4(num2, num2, 1823f, 1237f));
			this.NEEMJOKELLC.SetVector("#606000", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 1; i < this.radialBlurIterations; i++)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary, temporary3, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 1280f + 1921f) * 1949f) / 1478f;
				this.NEEMJOKELLC.SetVector("1HandSwordShieldBash", new Vector4(num2, num2, 71f, 962f));
				temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary3, temporary, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 1752f + 1714f) * 1289f) / 755f;
				this.NEEMJOKELLC.SetVector("_NormalAndOcclusion", new Vector4(num2, num2, 797f, 1083f));
			}
			if (vector.z >= 1511f)
			{
				this.NEEMJOKELLC.SetVector("", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.NEEMJOKELLC.SetVector(",", Vector4.zero);
			}
			this.NEEMJOKELLC.SetTexture("release", temporary);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NEEMJOKELLC, (this.screenBlendMode == SunShafts.IBKJGEFFAMB.Screen) ? 0 : 6);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BBAF RID: 48047 RVA: 0x00547F88 File Offset: 0x00546188
		public virtual bool DPGLLLMLAAB()
		{
			base.AHFDGALLKFC(this.useDepthTexture);
			this.NEEMJOKELLC = base.IIIIADNBONI(this.sunShaftsShader, this.NEEMJOKELLC);
			this.JCAGOEAEILH = base.ALJPMGLOIEG(this.simpleClearShader, this.JCAGOEAEILH);
			if (!this.PPGOAMIHMBG)
			{
				base.NAIBIABADFB();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBB0 RID: 48048 RVA: 0x00547FE8 File Offset: 0x005461E8
		private void NHDCFLGBCNE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.IGJKBOMMMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			int num = 0;
			if (this.resolution == SunShafts.FDGKKEEGCHC.Normal)
			{
				num = 3;
			}
			else if (this.resolution == (SunShafts.FDGKKEEGCHC)8)
			{
				num = 0;
			}
			Vector3 vector = Vector3.one * 1062f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(971f, 1251f, 240f);
			}
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			this.NEEMJOKELLC.SetVector("[ProBuilder Attachments] Please disable the following option in the Unity preferences:", new Vector4(586f, 820f, 1014f, 1046f) * this.sunShaftBlurRadius);
			this.NEEMJOKELLC.SetVector("_FogAlpha", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.NEEMJOKELLC.SetVector("_ReflectionTex", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = base.GetComponent<Camera>().allowHDR ? ((RenderTextureFormat)120) : RenderTextureFormat.Depth;
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 1, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(false, base.GetComponent<Camera>());
				this.NEEMJOKELLC.SetTexture("ObscuredUShort:", temporary2);
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 8);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 1);
			}
			base.EMIHIJBJENG(temporary, this.JCAGOEAEILH);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 0, 8);
			float num2 = this.sunShaftBlurRadius * 1013f;
			this.NEEMJOKELLC.SetVector("x", new Vector4(num2, num2, 1333f, 1444f));
			this.NEEMJOKELLC.SetVector("PER_VERTEX", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 1; i < this.radialBlurIterations; i += 0)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary, temporary3, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 906f + 815f) * 1255f) / 1937f;
				this.NEEMJOKELLC.SetVector("Failed parsing default rotation values.  Using defaults.", new Vector4(num2, num2, 1494f, 1187f));
				temporary = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary3, temporary, this.NEEMJOKELLC, 0);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 1667f + 946f) * 1749f) / 844f;
				this.NEEMJOKELLC.SetVector("GiantGrabIdle2", new Vector4(num2, num2, 1262f, 627f));
			}
			if (vector.z >= 1792f)
			{
				this.NEEMJOKELLC.SetVector("Perks", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.NEEMJOKELLC.SetVector("+ACVolumeProxy", Vector4.zero);
			}
			this.NEEMJOKELLC.SetTexture("CD", temporary);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NEEMJOKELLC, (this.screenBlendMode == SunShafts.IBKJGEFFAMB.Screen) ? 1 : 0);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BBB1 RID: 48049 RVA: 0x005483A8 File Offset: 0x005465A8
		public virtual bool IAIMIKBMJOM()
		{
			base.POJDHPJDFEM(this.useDepthTexture);
			this.NEEMJOKELLC = base.IIIIADNBONI(this.sunShaftsShader, this.NEEMJOKELLC);
			this.JCAGOEAEILH = base.BAPJBHPEDIF(this.simpleClearShader, this.JCAGOEAEILH);
			if (!this.PPGOAMIHMBG)
			{
				base.NAIBIABADFB();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBB2 RID: 48050 RVA: 0x00548408 File Offset: 0x00546608
		public virtual bool FCIOAHEKFIG()
		{
			base.BGIALJEIEFO(this.useDepthTexture);
			this.NEEMJOKELLC = base.IIIIADNBONI(this.sunShaftsShader, this.NEEMJOKELLC);
			this.JCAGOEAEILH = base.OOAOHFFDMJP(this.simpleClearShader, this.JCAGOEAEILH);
			if (!this.PPGOAMIHMBG)
			{
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBB3 RID: 48051 RVA: 0x00548468 File Offset: 0x00546668
		private void IBILMNLCCJJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			int num = 7;
			if (this.resolution == SunShafts.FDGKKEEGCHC.Low)
			{
				num = 5;
			}
			else if (this.resolution == (SunShafts.FDGKKEEGCHC)5)
			{
				num = 0;
			}
			Vector3 vector = Vector3.one * 45f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(833f, 1790f, 839f);
			}
			int width = JONJODLFAEN.width / num;
			int height = JONJODLFAEN.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			this.NEEMJOKELLC.SetVector("maxdeep", new Vector4(1908f, 1191f, 1954f, 574f) * this.sunShaftBlurRadius);
			this.NEEMJOKELLC.SetVector("IdleReady", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.NEEMJOKELLC.SetVector("Textures/Weapons/", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = base.GetComponent<Camera>().allowHDR ? ((RenderTextureFormat)(-85)) : RenderTextureFormat.ARGB1555;
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(false, base.GetComponent<Camera>());
				this.NEEMJOKELLC.SetTexture("", temporary2);
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 4);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.NEEMJOKELLC, 1);
			}
			base.KMBFKPFKKFL(temporary, this.JCAGOEAEILH);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 1, 7);
			float num2 = this.sunShaftBlurRadius * 1075f;
			this.NEEMJOKELLC.SetVector("Giant 2 Hand Slam Idle", new Vector4(num2, num2, 1070f, 1130f));
			this.NEEMJOKELLC.SetVector("gi_nl4", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 0; i < this.radialBlurIterations; i++)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary, temporary3, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 1027f + 903f) * 787f) / 836f;
				this.NEEMJOKELLC.SetVector("Original lives count: ", new Vector4(num2, num2, 1029f, 1003f));
				temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary3, temporary, this.NEEMJOKELLC, 1);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 684f + 807f) * 1960f) / 1108f;
				this.NEEMJOKELLC.SetVector("lifeBar", new Vector4(num2, num2, 1773f, 604f));
			}
			if (vector.z >= 1006f)
			{
				this.NEEMJOKELLC.SetVector("_FogAlpha", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.NEEMJOKELLC.SetVector("startB", Vector4.zero);
			}
			this.NEEMJOKELLC.SetTexture("wpn_rod3", temporary);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NEEMJOKELLC, (this.screenBlendMode == SunShafts.IBKJGEFFAMB.Screen) ? 1 : 3);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BBB4 RID: 48052 RVA: 0x00548828 File Offset: 0x00546A28
		public virtual bool NFFLLNPGHNC()
		{
			base.PKDIKFGAJKM(this.useDepthTexture);
			this.NEEMJOKELLC = base.JBHLGBPJFEL(this.sunShaftsShader, this.NEEMJOKELLC);
			this.JCAGOEAEILH = base.ALJPMGLOIEG(this.simpleClearShader, this.JCAGOEAEILH);
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BBB5 RID: 48053 RVA: 0x00548888 File Offset: 0x00546A88
		public virtual bool KHEPGGOEGIA()
		{
			base.NHCAHIHJHMF(this.useDepthTexture);
			this.NEEMJOKELLC = base.OOAOHFFDMJP(this.sunShaftsShader, this.NEEMJOKELLC);
			this.JCAGOEAEILH = base.BOOFEOGDMBI(this.simpleClearShader, this.JCAGOEAEILH);
			if (!this.PPGOAMIHMBG)
			{
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x04001858 RID: 6232
		public SunShafts.FDGKKEEGCHC resolution = SunShafts.FDGKKEEGCHC.Normal;

		// Token: 0x04001859 RID: 6233
		public SunShafts.IBKJGEFFAMB screenBlendMode;

		// Token: 0x0400185A RID: 6234
		public Transform sunTransform;

		// Token: 0x0400185B RID: 6235
		public int radialBlurIterations = 2;

		// Token: 0x0400185C RID: 6236
		public Color sunColor = Color.white;

		// Token: 0x0400185D RID: 6237
		public Color sunThreshold = new Color(0.87f, 0.74f, 0.65f);

		// Token: 0x0400185E RID: 6238
		public float sunShaftBlurRadius = 2.5f;

		// Token: 0x0400185F RID: 6239
		public float sunShaftIntensity = 1.15f;

		// Token: 0x04001860 RID: 6240
		public float maxRadius = 0.75f;

		// Token: 0x04001861 RID: 6241
		public bool useDepthTexture = true;

		// Token: 0x04001862 RID: 6242
		public Shader sunShaftsShader;

		// Token: 0x04001863 RID: 6243
		private Material NEEMJOKELLC;

		// Token: 0x04001864 RID: 6244
		public Shader simpleClearShader;

		// Token: 0x04001865 RID: 6245
		private Material JCAGOEAEILH;

		// Token: 0x02000333 RID: 819
		public enum FDGKKEEGCHC
		{
			// Token: 0x04001867 RID: 6247
			Low,
			// Token: 0x04001868 RID: 6248
			Normal,
			// Token: 0x04001869 RID: 6249
			High
		}

		// Token: 0x02000334 RID: 820
		public enum IBKJGEFFAMB
		{
			// Token: 0x0400186B RID: 6251
			Screen,
			// Token: 0x0400186C RID: 6252
			Add
		}
	}
}
