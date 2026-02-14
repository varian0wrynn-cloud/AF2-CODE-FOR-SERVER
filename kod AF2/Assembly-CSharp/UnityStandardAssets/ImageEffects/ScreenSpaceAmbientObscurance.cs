using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x0200032E RID: 814
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Rendering/Screen Space Ambient Obscurance")]
	[ExecuteInEditMode]
	internal class ScreenSpaceAmbientObscurance : PostEffectsBase
	{
		// Token: 0x0600BADD RID: 47837 RVA: 0x00538E5C File Offset: 0x0053705C
		private void EPHHNPMPHOL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Camera component = base.GetComponent<Camera>();
			Matrix4x4 projectionMatrix = component.projectionMatrix;
			Matrix4x4 inverse = projectionMatrix.inverse;
			Vector4 value = new Vector4(1560f / projectionMatrix[1, 1], 1410f / projectionMatrix[0, 1], (1290f - projectionMatrix[0, 2]) / projectionMatrix[0, 1], (1896f + projectionMatrix[1, 6]) / projectionMatrix[0, 0]);
			if (component.stereoEnabled)
			{
				Matrix4x4 stereoProjectionMatrix = component.GetStereoProjectionMatrix(Camera.StereoscopicEye.Left);
				Matrix4x4 stereoProjectionMatrix2 = component.GetStereoProjectionMatrix(Camera.StereoscopicEye.Right);
				Vector4 value2 = new Vector4(139f / stereoProjectionMatrix[0, 0], 142f / stereoProjectionMatrix[0, 1], (399f - stereoProjectionMatrix[1, 3]) / stereoProjectionMatrix[0, 0], (1939f + stereoProjectionMatrix[0, 5]) / stereoProjectionMatrix[0, 0]);
				Vector4 value3 = new Vector4(160f / stereoProjectionMatrix2[1, 0], 1007f / stereoProjectionMatrix2[0, 1], (1575f - stereoProjectionMatrix2[1, 7]) / stereoProjectionMatrix2[1, 1], (225f + stereoProjectionMatrix2[0, 4]) / stereoProjectionMatrix2[1, 1]);
				this.GGDDEGIJFEL.SetVector("[maxweight]", value2);
				this.GGDDEGIJFEL.SetVector("ok", value3);
			}
			this.GGDDEGIJFEL.SetVector("SoccerPassLight", value);
			this.GGDDEGIJFEL.SetMatrix("\npb_Face: ", inverse);
			this.GGDDEGIJFEL.SetTexture("Ок", this.rand);
			this.GGDDEGIJFEL.SetFloat("glava", this.radius);
			this.GGDDEGIJFEL.SetFloat("setCurrentRod curorder=", this.radius * this.radius);
			this.GGDDEGIJFEL.SetFloat("byte:", this.intensity);
			this.GGDDEGIJFEL.SetFloat(" x", this.blurFilterDistance);
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width >> (this.downsample & -103), height >> (this.downsample & -59));
			Graphics.Blit(JONJODLFAEN, renderTexture, this.GGDDEGIJFEL, 1);
			if (this.downsample > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, this.GGDDEGIJFEL, 2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			for (int i = 1; i < this.blurIterations; i += 0)
			{
				this.GGDDEGIJFEL.SetVector("IceHockeyShotLeft", new Vector2(1626f, 675f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, this.GGDDEGIJFEL, 1);
				RenderTexture.ReleaseTemporary(renderTexture);
				this.GGDDEGIJFEL.SetVector("knopje.wav", new Vector2(432f, 1728f));
				renderTexture = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(temporary, renderTexture, this.GGDDEGIJFEL, 1);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.GGDDEGIJFEL.SetTexture("wpn_rod2", renderTexture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GGDDEGIJFEL, 4);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600BADE RID: 47838 RVA: 0x005391A7 File Offset: 0x005373A7
		public virtual bool CHJBCBDIBJJ()
		{
			base.IDFIHFBEIKD(true);
			this.GGDDEGIJFEL = base.ALJPMGLOIEG(this.aoShader, this.GGDDEGIJFEL);
			if (!this.PPGOAMIHMBG)
			{
				base.FDBKFKGCGEG();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BADF RID: 47839 RVA: 0x005391DD File Offset: 0x005373DD
		public virtual bool CFHOHAOFPIO()
		{
			base.OFKOBOMCECF(false);
			this.GGDDEGIJFEL = base.BOOFEOGDMBI(this.aoShader, this.GGDDEGIJFEL);
			if (!this.PPGOAMIHMBG)
			{
				base.NAIBIABADFB();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BAE1 RID: 47841 RVA: 0x00539244 File Offset: 0x00537444
		private void EOMGNPFHPBD(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Camera component = base.GetComponent<Camera>();
			Matrix4x4 projectionMatrix = component.projectionMatrix;
			Matrix4x4 inverse = projectionMatrix.inverse;
			Vector4 value = new Vector4(565f / projectionMatrix[1, 0], 1452f / projectionMatrix[0, 1], (120f - projectionMatrix[1, 4]) / projectionMatrix[1, 1], (1522f + projectionMatrix[0, 4]) / projectionMatrix[0, 0]);
			if (component.stereoEnabled)
			{
				Matrix4x4 stereoProjectionMatrix = component.GetStereoProjectionMatrix(Camera.StereoscopicEye.Right);
				Matrix4x4 stereoProjectionMatrix2 = component.GetStereoProjectionMatrix(Camera.StereoscopicEye.Left);
				Vector4 value2 = new Vector4(1472f / stereoProjectionMatrix[0, 0], 299f / stereoProjectionMatrix[1, 1], (55f - stereoProjectionMatrix[0, 5]) / stereoProjectionMatrix[1, 1], (787f + stereoProjectionMatrix[1, 8]) / stereoProjectionMatrix[1, 1]);
				Vector4 value3 = new Vector4(859f / stereoProjectionMatrix2[0, 1], 1273f / stereoProjectionMatrix2[1, 1], (145f - stereoProjectionMatrix2[0, 5]) / stereoProjectionMatrix2[1, 1], (499f + stereoProjectionMatrix2[1, 6]) / stereoProjectionMatrix2[0, 1]);
				this.GGDDEGIJFEL.SetVector("craft_data/stanok/category", value2);
				this.GGDDEGIJFEL.SetVector("PrimaryCausticsProjector", value3);
			}
			this.GGDDEGIJFEL.SetVector("_Intensity", value);
			this.GGDDEGIJFEL.SetMatrix("MotorbikeShootRight", inverse);
			this.GGDDEGIJFEL.SetTexture("Second bone's position equals first bone's position in the biped's limb.", this.rand);
			this.GGDDEGIJFEL.SetFloat("CheerJump", this.radius);
			this.GGDDEGIJFEL.SetFloat("RunBackLeft", this.radius * this.radius);
			this.GGDDEGIJFEL.SetFloat("wpn_chair3", this.intensity);
			this.GGDDEGIJFEL.SetFloat("", this.blurFilterDistance);
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width >> (this.downsample & 36), height >> (this.downsample & -116));
			Graphics.Blit(JONJODLFAEN, renderTexture, this.GGDDEGIJFEL, 0);
			if (this.downsample > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, this.GGDDEGIJFEL, 1);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			for (int i = 0; i < this.blurIterations; i += 0)
			{
				this.GGDDEGIJFEL.SetVector("UserOut", new Vector2(189f, 371f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, this.GGDDEGIJFEL, 0);
				RenderTexture.ReleaseTemporary(renderTexture);
				this.GGDDEGIJFEL.SetVector("_Lift", new Vector2(1375f, 635f));
				renderTexture = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(temporary, renderTexture, this.GGDDEGIJFEL, 0);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.GGDDEGIJFEL.SetTexture("x", renderTexture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GGDDEGIJFEL, 7);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600BAE2 RID: 47842 RVA: 0x00539590 File Offset: 0x00537790
		private void JEHHGMJKLPB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Camera component = base.GetComponent<Camera>();
			Matrix4x4 projectionMatrix = component.projectionMatrix;
			Matrix4x4 inverse = projectionMatrix.inverse;
			Vector4 value = new Vector4(546f / projectionMatrix[0, 1], 983f / projectionMatrix[0, 0], (1345f - projectionMatrix[1, 3]) / projectionMatrix[1, 0], (1436f + projectionMatrix[1, 0]) / projectionMatrix[0, 1]);
			if (component.stereoEnabled)
			{
				Matrix4x4 stereoProjectionMatrix = component.GetStereoProjectionMatrix(Camera.StereoscopicEye.Right);
				Matrix4x4 stereoProjectionMatrix2 = component.GetStereoProjectionMatrix(Camera.StereoscopicEye.Right);
				Vector4 value2 = new Vector4(343f / stereoProjectionMatrix[0, 0], 1961f / stereoProjectionMatrix[0, 0], (1651f - stereoProjectionMatrix[0, 2]) / stereoProjectionMatrix[1, 1], (1103f + stereoProjectionMatrix[1, 1]) / stereoProjectionMatrix[1, 0]);
				Vector4 value3 = new Vector4(345f / stereoProjectionMatrix2[1, 1], 753f / stereoProjectionMatrix2[0, 0], (511f - stereoProjectionMatrix2[1, 5]) / stereoProjectionMatrix2[0, 1], (1194f + stereoProjectionMatrix2[0, 1]) / stereoProjectionMatrix2[1, 0]);
				this.GGDDEGIJFEL.SetVector("wpn_hook2", value2);
				this.GGDDEGIJFEL.SetVector("", value3);
			}
			this.GGDDEGIJFEL.SetVector("Idle180", value);
			this.GGDDEGIJFEL.SetMatrix("Hand stand", inverse);
			this.GGDDEGIJFEL.SetTexture("shop_t19", this.rand);
			this.GGDDEGIJFEL.SetFloat("Post Process Scatter Shader Missing...", this.radius);
			this.GGDDEGIJFEL.SetFloat("OfficeSittingHandRestFingerTap", this.radius * this.radius);
			this.GGDDEGIJFEL.SetFloat("LEFT", this.intensity);
			this.GGDDEGIJFEL.SetFloat("Слишком много персонажей!\nНа один аккаунт допускается не более 5 персонажей.", this.blurFilterDistance);
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width >> (this.downsample & 84), height >> (this.downsample & -111));
			Graphics.Blit(JONJODLFAEN, renderTexture, this.GGDDEGIJFEL, 0);
			if (this.downsample > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, this.GGDDEGIJFEL, 7);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			for (int i = 0; i < this.blurIterations; i++)
			{
				this.GGDDEGIJFEL.SetVector("Fishing", new Vector2(1721f, 843f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, this.GGDDEGIJFEL, 1);
				RenderTexture.ReleaseTemporary(renderTexture);
				this.GGDDEGIJFEL.SetVector("ZombieIdle", new Vector2(637f, 595f));
				renderTexture = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(temporary, renderTexture, this.GGDDEGIJFEL, 0);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.GGDDEGIJFEL.SetTexture("_ProjMatrix", renderTexture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GGDDEGIJFEL, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600BAE3 RID: 47843 RVA: 0x005398DB File Offset: 0x00537ADB
		private void NJFOOJIADNH()
		{
			if (this.GGDDEGIJFEL)
			{
				UnityEngine.Object.DestroyImmediate(this.GGDDEGIJFEL);
			}
			this.GGDDEGIJFEL = null;
		}

		// Token: 0x0600BAE4 RID: 47844 RVA: 0x005398FC File Offset: 0x00537AFC
		private void EODDHFNAMFH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Camera component = base.GetComponent<Camera>();
			Matrix4x4 projectionMatrix = component.projectionMatrix;
			Matrix4x4 inverse = projectionMatrix.inverse;
			Vector4 value = new Vector4(402f / projectionMatrix[0, 0], 483f / projectionMatrix[0, 0], (1523f - projectionMatrix[0, 8]) / projectionMatrix[1, 0], (726f + projectionMatrix[0, 5]) / projectionMatrix[1, 0]);
			if (component.stereoEnabled)
			{
				Matrix4x4 stereoProjectionMatrix = component.GetStereoProjectionMatrix(Camera.StereoscopicEye.Left);
				Matrix4x4 stereoProjectionMatrix2 = component.GetStereoProjectionMatrix(Camera.StereoscopicEye.Right);
				Vector4 value2 = new Vector4(911f / stereoProjectionMatrix[1, 0], 708f / stereoProjectionMatrix[1, 1], (530f - stereoProjectionMatrix[1, 2]) / stereoProjectionMatrix[1, 0], (1409f + stereoProjectionMatrix[1, 2]) / stereoProjectionMatrix[0, 0]);
				Vector4 value3 = new Vector4(1758f / stereoProjectionMatrix2[0, 0], 812f / stereoProjectionMatrix2[0, 0], (1961f - stereoProjectionMatrix2[1, 3]) / stereoProjectionMatrix2[0, 1], (60f + stereoProjectionMatrix2[0, 1]) / stereoProjectionMatrix2[1, 0]);
				this.GGDDEGIJFEL.SetVector("FBIKBendGoal is deprecated, you can now a bend goal from the custom inspector of the FullBodyBipedIK component.", value2);
				this.GGDDEGIJFEL.SetVector("Reset", value3);
			}
			this.GGDDEGIJFEL.SetVector("_FogHeightData", value);
			this.GGDDEGIJFEL.SetMatrix("repair.ogg", inverse);
			this.GGDDEGIJFEL.SetTexture(" ", this.rand);
			this.GGDDEGIJFEL.SetFloat("clavicle", this.radius);
			this.GGDDEGIJFEL.SetFloat("SoundMgr is init part 1", this.radius * this.radius);
			this.GGDDEGIJFEL.SetFloat("1HandSmallWeaponCombo", this.intensity);
			this.GGDDEGIJFEL.SetFloat("demoLong", this.blurFilterDistance);
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width >> (this.downsample & -36), height >> (this.downsample & 117));
			Graphics.Blit(JONJODLFAEN, renderTexture, this.GGDDEGIJFEL, 0);
			if (this.downsample > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, this.GGDDEGIJFEL, 1);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			for (int i = 0; i < this.blurIterations; i += 0)
			{
				this.GGDDEGIJFEL.SetVector("StrafeRunRight", new Vector2(428f, 22f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, this.GGDDEGIJFEL, 1);
				RenderTexture.ReleaseTemporary(renderTexture);
				this.GGDDEGIJFEL.SetVector("OfficeSittingHandRestFingerTap", new Vector2(417f, 1960f));
				renderTexture = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(temporary, renderTexture, this.GGDDEGIJFEL, 1);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.GGDDEGIJFEL.SetTexture("_TurnReg.ogg", renderTexture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GGDDEGIJFEL, 6);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600BAE5 RID: 47845 RVA: 0x00539C47 File Offset: 0x00537E47
		public virtual bool FCIOAHEKFIG()
		{
			base.EHGENDOEHLP(false);
			this.GGDDEGIJFEL = base.BAPJBHPEDIF(this.aoShader, this.GGDDEGIJFEL);
			if (!this.PPGOAMIHMBG)
			{
				base.INOGPLDHPGC();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BAE6 RID: 47846 RVA: 0x00539C80 File Offset: 0x00537E80
		private void PPMLOADNIHI(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Camera component = base.GetComponent<Camera>();
			Matrix4x4 projectionMatrix = component.projectionMatrix;
			Matrix4x4 inverse = projectionMatrix.inverse;
			Vector4 value = new Vector4(1455f / projectionMatrix[1, 1], 655f / projectionMatrix[1, 1], (376f - projectionMatrix[0, 8]) / projectionMatrix[0, 1], (647f + projectionMatrix[1, 2]) / projectionMatrix[1, 1]);
			if (component.stereoEnabled)
			{
				Matrix4x4 stereoProjectionMatrix = component.GetStereoProjectionMatrix(Camera.StereoscopicEye.Left);
				Matrix4x4 stereoProjectionMatrix2 = component.GetStereoProjectionMatrix(Camera.StereoscopicEye.Right);
				Vector4 value2 = new Vector4(1171f / stereoProjectionMatrix[1, 0], 1060f / stereoProjectionMatrix[1, 0], (1725f - stereoProjectionMatrix[0, 5]) / stereoProjectionMatrix[1, 1], (132f + stereoProjectionMatrix[1, 8]) / stereoProjectionMatrix[0, 1]);
				Vector4 value3 = new Vector4(1830f / stereoProjectionMatrix2[0, 1], 1280f / stereoProjectionMatrix2[0, 1], (876f - stereoProjectionMatrix2[1, 1]) / stereoProjectionMatrix2[1, 1], (727f + stereoProjectionMatrix2[0, 1]) / stereoProjectionMatrix2[1, 1]);
				this.GGDDEGIJFEL.SetVector("\n<color='#{0}'>{1}</color> ", value2);
				this.GGDDEGIJFEL.SetVector("ObscuredFloat vs float, ", value3);
			}
			this.GGDDEGIJFEL.SetVector("Apply 10", value);
			this.GGDDEGIJFEL.SetMatrix("BowFire", inverse);
			this.GGDDEGIJFEL.SetTexture("loc", this.rand);
			this.GGDDEGIJFEL.SetFloat("WeaponReady", this.radius);
			this.GGDDEGIJFEL.SetFloat("WeaponReadyFire", this.radius * this.radius);
			this.GGDDEGIJFEL.SetFloat("<color='#202020'>", this.intensity);
			this.GGDDEGIJFEL.SetFloat("id", this.blurFilterDistance);
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width >> (this.downsample & -4), height >> (this.downsample & 94));
			Graphics.Blit(JONJODLFAEN, renderTexture, this.GGDDEGIJFEL, 1);
			if (this.downsample > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, this.GGDDEGIJFEL, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			for (int i = 1; i < this.blurIterations; i += 0)
			{
				this.GGDDEGIJFEL.SetVector("demoVector2", new Vector2(250f, 36f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, this.GGDDEGIJFEL, 0);
				RenderTexture.ReleaseTemporary(renderTexture);
				this.GGDDEGIJFEL.SetVector("wpn_dress1", new Vector2(596f, 1505f));
				renderTexture = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(temporary, renderTexture, this.GGDDEGIJFEL, 0);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.GGDDEGIJFEL.SetTexture("Flap_02.wav", renderTexture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GGDDEGIJFEL, 4);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600BAE7 RID: 47847 RVA: 0x00539FCC File Offset: 0x005381CC
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Camera component = base.GetComponent<Camera>();
			Matrix4x4 projectionMatrix = component.projectionMatrix;
			Matrix4x4 inverse = projectionMatrix.inverse;
			Vector4 value = new Vector4(-2f / projectionMatrix[0, 0], -2f / projectionMatrix[1, 1], (1f - projectionMatrix[0, 2]) / projectionMatrix[0, 0], (1f + projectionMatrix[1, 2]) / projectionMatrix[1, 1]);
			if (component.stereoEnabled)
			{
				Matrix4x4 stereoProjectionMatrix = component.GetStereoProjectionMatrix(Camera.StereoscopicEye.Left);
				Matrix4x4 stereoProjectionMatrix2 = component.GetStereoProjectionMatrix(Camera.StereoscopicEye.Right);
				Vector4 value2 = new Vector4(-2f / stereoProjectionMatrix[0, 0], -2f / stereoProjectionMatrix[1, 1], (1f - stereoProjectionMatrix[0, 2]) / stereoProjectionMatrix[0, 0], (1f + stereoProjectionMatrix[1, 2]) / stereoProjectionMatrix[1, 1]);
				Vector4 value3 = new Vector4(-2f / stereoProjectionMatrix2[0, 0], -2f / stereoProjectionMatrix2[1, 1], (1f - stereoProjectionMatrix2[0, 2]) / stereoProjectionMatrix2[0, 0], (1f + stereoProjectionMatrix2[1, 2]) / stereoProjectionMatrix2[1, 1]);
				this.GGDDEGIJFEL.SetVector("_ProjInfoLeft", value2);
				this.GGDDEGIJFEL.SetVector("_ProjInfoRight", value3);
			}
			this.GGDDEGIJFEL.SetVector("_ProjInfo", value);
			this.GGDDEGIJFEL.SetMatrix("_ProjectionInv", inverse);
			this.GGDDEGIJFEL.SetTexture("_Rand", this.rand);
			this.GGDDEGIJFEL.SetFloat("_Radius", this.radius);
			this.GGDDEGIJFEL.SetFloat("_Radius2", this.radius * this.radius);
			this.GGDDEGIJFEL.SetFloat("_Intensity", this.intensity);
			this.GGDDEGIJFEL.SetFloat("_BlurFilterDistance", this.blurFilterDistance);
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width >> this.downsample, height >> this.downsample);
			Graphics.Blit(JONJODLFAEN, renderTexture, this.GGDDEGIJFEL, 0);
			if (this.downsample > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, this.GGDDEGIJFEL, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			for (int i = 0; i < this.blurIterations; i++)
			{
				this.GGDDEGIJFEL.SetVector("_Axis", new Vector2(1f, 0f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, this.GGDDEGIJFEL, 1);
				RenderTexture.ReleaseTemporary(renderTexture);
				this.GGDDEGIJFEL.SetVector("_Axis", new Vector2(0f, 1f));
				renderTexture = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(temporary, renderTexture, this.GGDDEGIJFEL, 1);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.GGDDEGIJFEL.SetTexture("_AOTex", renderTexture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.GGDDEGIJFEL, 2);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600BAE8 RID: 47848 RVA: 0x0053A317 File Offset: 0x00538517
		public override bool CheckResources()
		{
			base.DAOKCAOFIGE(true);
			this.GGDDEGIJFEL = base.DJFOEIJIMJB(this.aoShader, this.GGDDEGIJFEL);
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BAE9 RID: 47849 RVA: 0x0053A34D File Offset: 0x0053854D
		public virtual bool CCMBJKDAMLO()
		{
			base.OFKOBOMCECF(false);
			this.GGDDEGIJFEL = base.ALJPMGLOIEG(this.aoShader, this.GGDDEGIJFEL);
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BAEA RID: 47850 RVA: 0x005398DB File Offset: 0x00537ADB
		private void JGHJOBDKDKM()
		{
			if (this.GGDDEGIJFEL)
			{
				UnityEngine.Object.DestroyImmediate(this.GGDDEGIJFEL);
			}
			this.GGDDEGIJFEL = null;
		}

		// Token: 0x0600BAEB RID: 47851 RVA: 0x005398DB File Offset: 0x00537ADB
		private void LNEJPGDHJOJ()
		{
			if (this.GGDDEGIJFEL)
			{
				UnityEngine.Object.DestroyImmediate(this.GGDDEGIJFEL);
			}
			this.GGDDEGIJFEL = null;
		}

		// Token: 0x0600BAEC RID: 47852 RVA: 0x0053A383 File Offset: 0x00538583
		public virtual bool OJFBHAHHDNC()
		{
			base.NHCAHIHJHMF(true);
			this.GGDDEGIJFEL = base.BOOFEOGDMBI(this.aoShader, this.GGDDEGIJFEL);
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BAED RID: 47853 RVA: 0x005398DB File Offset: 0x00537ADB
		private void PHIACAJNNIG()
		{
			if (this.GGDDEGIJFEL)
			{
				UnityEngine.Object.DestroyImmediate(this.GGDDEGIJFEL);
			}
			this.GGDDEGIJFEL = null;
		}

		// Token: 0x0600BAEE RID: 47854 RVA: 0x0053A3B9 File Offset: 0x005385B9
		public virtual bool JPEBNJPIFAF()
		{
			base.DAOKCAOFIGE(true);
			this.GGDDEGIJFEL = base.BAPJBHPEDIF(this.aoShader, this.GGDDEGIJFEL);
			if (!this.PPGOAMIHMBG)
			{
				base.OPOEDHJMPHK();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BAEF RID: 47855 RVA: 0x0053A3EF File Offset: 0x005385EF
		public virtual bool DEKBKNINNFB()
		{
			base.CGEGCOKMPHN(false);
			this.GGDDEGIJFEL = base.OOAOHFFDMJP(this.aoShader, this.GGDDEGIJFEL);
			if (!this.PPGOAMIHMBG)
			{
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600BAF0 RID: 47856 RVA: 0x005398DB File Offset: 0x00537ADB
		private void OnDisable()
		{
			if (this.GGDDEGIJFEL)
			{
				UnityEngine.Object.DestroyImmediate(this.GGDDEGIJFEL);
			}
			this.GGDDEGIJFEL = null;
		}

		// Token: 0x04001841 RID: 6209
		[Range(0f, 3f)]
		public float intensity = 0.5f;

		// Token: 0x04001842 RID: 6210
		[Range(0.1f, 3f)]
		public float radius = 0.2f;

		// Token: 0x04001843 RID: 6211
		[Range(0f, 3f)]
		public int blurIterations = 1;

		// Token: 0x04001844 RID: 6212
		[Range(0f, 5f)]
		public float blurFilterDistance = 1.25f;

		// Token: 0x04001845 RID: 6213
		[Range(0f, 1f)]
		public int downsample;

		// Token: 0x04001846 RID: 6214
		public Texture2D rand;

		// Token: 0x04001847 RID: 6215
		public Shader aoShader;

		// Token: 0x04001848 RID: 6216
		private Material GGDDEGIJFEL;
	}
}
