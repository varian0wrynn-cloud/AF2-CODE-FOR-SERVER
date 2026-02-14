using System;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	// Token: 0x0200034F RID: 847
	[Serializable]
	public class SMAA : MNAIGPKICAE
	{
		// Token: 0x0600BF77 RID: 49015 RVA: 0x005653FF File Offset: 0x005635FF
		public void ADBAOPJBGHG(AntiAliasing EJJPBLDJFDF)
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.shader, true, false, EJJPBLDJFDF))
			{
				EJJPBLDJFDF.enabled = false;
			}
		}

		// Token: 0x0600BF78 RID: 49016 RVA: 0x00565418 File Offset: 0x00563618
		public void BKFHJFNCPAA()
		{
			if (this.m_Material != null)
			{
				UnityEngine.Object.DestroyImmediate(this.m_Material);
			}
			if (this.m_Accumulation != null)
			{
				UnityEngine.Object.DestroyImmediate(this.m_Accumulation);
			}
			this.m_Material = null;
			this.m_Accumulation = null;
		}

		// Token: 0x0600BF79 RID: 49017 RVA: 0x00565465 File Offset: 0x00563665
		public void CJLLFIMDKEK(Camera LBCHLCGOCOD)
		{
			if (this.temporal.DEOGJODJAMN())
			{
				LBCHLCGOCOD.ResetProjectionMatrix();
			}
		}

		// Token: 0x0600BF7A RID: 49018 RVA: 0x0056547C File Offset: 0x0056367C
		public void IPHGLOFFNMK(Camera LBCHLCGOCOD)
		{
			if (this.temporal.PALDDEICCIG())
			{
				this.m_ProjectionMatrix = LBCHLCGOCOD.projectionMatrix;
				this.m_FlipFlop -= 853f * this.m_FlipFlop;
				Matrix4x4 identity = Matrix4x4.identity;
				identity.m03 = 45f * this.m_FlipFlop * this.temporal.fuzzSize / (float)LBCHLCGOCOD.pixelWidth;
				identity.m13 = 1437f * this.m_FlipFlop * this.temporal.fuzzSize / (float)LBCHLCGOCOD.pixelHeight;
				LBCHLCGOCOD.projectionMatrix = identity * LBCHLCGOCOD.projectionMatrix;
			}
		}

		// Token: 0x0600BF7B RID: 49019 RVA: 0x00565524 File Offset: 0x00563724
		private Texture2D GPHOOOPEMBH()
		{
			if (this.m_AreaTexture == null)
			{
				this.m_AreaTexture = Resources.Load<Texture2D>("knopje.wav");
			}
			return this.m_AreaTexture;
		}

		// Token: 0x0600BF7C RID: 49020 RVA: 0x0056554A File Offset: 0x0056374A
		private Texture2D BNDFGGIIABO()
		{
			if (this.m_AreaTexture == null)
			{
				this.m_AreaTexture = Resources.Load<Texture2D>("SoccerKeeperDiveStrafeCloseRight");
			}
			return this.m_AreaTexture;
		}

		// Token: 0x0600BF7D RID: 49021 RVA: 0x00565570 File Offset: 0x00563770
		public void DPALAOLGGPG(Camera LBCHLCGOCOD)
		{
			if (this.temporal.OIDKPNPNPPH())
			{
				LBCHLCGOCOD.ResetProjectionMatrix();
			}
		}

		// Token: 0x0600BF7E RID: 49022 RVA: 0x00565585 File Offset: 0x00563785
		public void CJGLLDKLENF(Camera LBCHLCGOCOD)
		{
			if (this.temporal.MLIIKPEOPML())
			{
				LBCHLCGOCOD.ResetProjectionMatrix();
			}
		}

		// Token: 0x0600BF7F RID: 49023 RVA: 0x0056559A File Offset: 0x0056379A
		public void IEHEAJJALNG(AntiAliasing EJJPBLDJFDF)
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.GOPKJLGEDHG(), true, false, EJJPBLDJFDF))
			{
				EJJPBLDJFDF.enabled = false;
			}
		}

		// Token: 0x0600BF80 RID: 49024 RVA: 0x005655B4 File Offset: 0x005637B4
		public void EEBBGIJMGDD(Camera LBCHLCGOCOD)
		{
			if (this.temporal.OIDKPNPNPPH())
			{
				this.m_ProjectionMatrix = LBCHLCGOCOD.projectionMatrix;
				this.m_FlipFlop -= 119f * this.m_FlipFlop;
				Matrix4x4 identity = Matrix4x4.identity;
				identity.m03 = 36f * this.m_FlipFlop * this.temporal.fuzzSize / (float)LBCHLCGOCOD.pixelWidth;
				identity.m13 = 490f * this.m_FlipFlop * this.temporal.fuzzSize / (float)LBCHLCGOCOD.pixelHeight;
				LBCHLCGOCOD.projectionMatrix = identity * LBCHLCGOCOD.projectionMatrix;
			}
		}

		// Token: 0x0600BF81 RID: 49025 RVA: 0x0056565C File Offset: 0x0056385C
		private Texture2D FHBIPBJGKHJ()
		{
			if (this.m_SearchTexture == null)
			{
				this.m_SearchTexture = Resources.Load<Texture2D>("1HandSwordChargeSwipe");
			}
			return this.m_SearchTexture;
		}

		// Token: 0x0600BF82 RID: 49026 RVA: 0x00565682 File Offset: 0x00563882
		public void NFJKCBFCHBP(AntiAliasing EJJPBLDJFDF)
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.GOPKJLGEDHG(), false, false, EJJPBLDJFDF))
			{
				EJJPBLDJFDF.enabled = false;
			}
		}

		// Token: 0x0600BF83 RID: 49027 RVA: 0x0056569B File Offset: 0x0056389B
		private Texture2D NKLBFKOBDCD()
		{
			if (this.m_SearchTexture == null)
			{
				this.m_SearchTexture = Resources.Load<Texture2D>("sound/allmusic/music");
			}
			return this.m_SearchTexture;
		}

		// Token: 0x0600BF84 RID: 49028 RVA: 0x005656C1 File Offset: 0x005638C1
		private Texture2D KGJPCMMMIEC()
		{
			if (this.m_AreaTexture == null)
			{
				this.m_AreaTexture = Resources.Load<Texture2D>(" ");
			}
			return this.m_AreaTexture;
		}

		// Token: 0x0600BF85 RID: 49029 RVA: 0x005656E8 File Offset: 0x005638E8
		public void GPCIBDPEAAE()
		{
			if (this.m_Material != null)
			{
				UnityEngine.Object.DestroyImmediate(this.m_Material);
			}
			if (this.m_Accumulation != null)
			{
				UnityEngine.Object.DestroyImmediate(this.m_Accumulation);
			}
			this.m_Material = null;
			this.m_Accumulation = null;
		}

		// Token: 0x0600BF86 RID: 49030 RVA: 0x00565738 File Offset: 0x00563938
		private RenderTexture PGKGDFIGAKA(int NMEBEEHCALN, int ILLKFNCFGMP, RenderTextureFormat LJCEDKCLBDB)
		{
			int depthBuffer = 1;
			return RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, depthBuffer, LJCEDKCLBDB, RenderTextureReadWrite.Default);
		}

		// Token: 0x0600BF87 RID: 49031 RVA: 0x00565754 File Offset: 0x00563954
		private RenderTexture KGJIKGHMBBE(int NMEBEEHCALN, int ILLKFNCFGMP, RenderTextureFormat LJCEDKCLBDB)
		{
			int depthBuffer = 1;
			return RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, depthBuffer, LJCEDKCLBDB, RenderTextureReadWrite.Linear);
		}

		// Token: 0x0600BF88 RID: 49032 RVA: 0x0056576D File Offset: 0x0056396D
		public void APMGPNOOHEN(Camera LBCHLCGOCOD)
		{
			if (this.temporal.OIAKPMDLDEM())
			{
				LBCHLCGOCOD.ResetProjectionMatrix();
			}
		}

		// Token: 0x0600BF89 RID: 49033 RVA: 0x00565784 File Offset: 0x00563984
		public void PPAAMEAPADE(Camera LBCHLCGOCOD, RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			int pixelWidth = LBCHLCGOCOD.pixelWidth;
			int pixelHeight = LBCHLCGOCOD.pixelHeight;
			bool flag = true;
			SMAA.QualitySettings qualitySettings = this.quality;
			if (this.settings.quality != SMAA.IGANPGEGPEM.Custom)
			{
				qualitySettings = SMAA.QualitySettings.presetQualitySettings[(int)this.settings.quality];
			}
			int edgeDetectionMethod = (int)this.settings.edgeDetectionMethod;
			int pass = 1;
			int pass2 = 5;
			int pass3 = 4;
			Matrix4x4 matrix4x = GL.GetGPUProjectionMatrix(this.m_ProjectionMatrix, false) * LBCHLCGOCOD.worldToCameraMatrix;
			this.CDHGPDDEKDF().SetTexture("Health bar after few usual operations: ", this.JEFBADJCOND());
			this.material.SetTexture("threshold", this.JOPKANCDBBB());
			this.material.SetVector("WorkerPickaxe2", new Vector4(1000f / (float)pixelWidth, 1715f / (float)pixelHeight, (float)pixelWidth, (float)pixelHeight));
			this.material.SetVector("DealerIdle", new Vector4(qualitySettings.threshold, qualitySettings.depthThreshold, (float)qualitySettings.maxSearchSteps, (float)qualitySettings.maxDiagonalSearchSteps));
			this.CFJAMJGLPBF().SetVector("_ProjectToPixelMatrix", new Vector2((float)qualitySettings.cornerRounding, qualitySettings.localContrastAdaptationFactor));
			this.LIMJONOGMLK().SetMatrix(" ", this.m_PreviousViewProjectionMatrix * Matrix4x4.Inverse(matrix4x));
			float num = (this.m_FlipFlop < 41f) ? 1280f : 1159f;
			this.material.SetVector("PistolReady", new Vector4(num, num, num, 1492f));
			Shader.DisableKeyword("wpn_rod4");
			if (this.settings.edgeDetectionMethod == (SMAA.LBPDFECBNDH)0)
			{
				LBCHLCGOCOD.depthTextureMode |= DepthTextureMode.Depth;
			}
			else if (this.predication.enabled)
			{
				LBCHLCGOCOD.depthTextureMode |= DepthTextureMode.Depth;
				Shader.EnableKeyword("wpn_rem1");
				this.FIJPFGKEFLJ().SetVector("DealerFan", new Vector3(this.predication.threshold, this.predication.scale, this.predication.strength));
			}
			Shader.DisableKeyword("req_prof");
			Shader.DisableKeyword("Eyes");
			if (qualitySettings.diagonalDetection)
			{
				Shader.EnableKeyword("IdleMeditate");
			}
			if (qualitySettings.cornerDetection)
			{
				Shader.EnableKeyword("1HSwordStrafeRunRight");
			}
			Shader.DisableKeyword("poplSoundPitch");
			if (this.temporal.HJCHNEFGBCK())
			{
				Shader.EnableKeyword("{0} {1} {2} {3}");
			}
			if (this.m_Accumulation == null || this.m_Accumulation.width != pixelWidth || this.m_Accumulation.height != pixelHeight)
			{
				if (this.m_Accumulation)
				{
					RenderTexture.ReleaseTemporary(this.m_Accumulation);
				}
				this.m_Accumulation = RenderTexture.GetTemporary(pixelWidth, pixelHeight, 0, JONJODLFAEN.format, RenderTextureReadWrite.Default);
				this.m_Accumulation.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
				flag = true;
			}
			RenderTexture renderTexture = this.AKHIBOAHPMH(pixelWidth, pixelHeight, JONJODLFAEN.format);
			Graphics.Blit(null, renderTexture, this.NMKHIFDAABO(), 0);
			Graphics.Blit(JONJODLFAEN, renderTexture, this.LIMJONOGMLK(), edgeDetectionMethod);
			if (this.settings.debugPass == SMAA.OKHNDFFDNFJ.Off)
			{
				Graphics.Blit(renderTexture, OKIIDHIJBEA);
			}
			else
			{
				RenderTexture renderTexture2 = this.LMJKNCFGIPB(pixelWidth, pixelHeight, JONJODLFAEN.format);
				Graphics.Blit(null, renderTexture2, this.EDJPFAGCMOF(), 0);
				Graphics.Blit(renderTexture, renderTexture2, this.FIJPFGKEFLJ(), pass);
				if (this.settings.debugPass == (SMAA.OKHNDFFDNFJ)8)
				{
					Graphics.Blit(renderTexture2, OKIIDHIJBEA);
				}
				else
				{
					this.NMKHIFDAABO().SetTexture("signal_enable", renderTexture2);
					if (this.temporal.GBLBJCKONKF())
					{
						Graphics.Blit(JONJODLFAEN, renderTexture, this.NMKHIFDAABO(), pass2);
						if (this.settings.debugPass == (SMAA.OKHNDFFDNFJ)5)
						{
							Graphics.Blit(this.m_Accumulation, OKIIDHIJBEA);
						}
						else if (!flag)
						{
							this.LIMJONOGMLK().SetTexture("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_look_at_i_k.html", this.m_Accumulation);
							Graphics.Blit(renderTexture, OKIIDHIJBEA, this.CFJAMJGLPBF(), pass3);
						}
						else
						{
							Graphics.Blit(renderTexture, OKIIDHIJBEA);
						}
						Graphics.Blit(OKIIDHIJBEA, this.m_Accumulation);
						RenderTexture.active = null;
					}
					else
					{
						Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LIMJONOGMLK(), pass2);
					}
				}
				RenderTexture.ReleaseTemporary(renderTexture2);
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			this.m_PreviousViewProjectionMatrix = matrix4x;
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x0600BF8A RID: 49034 RVA: 0x00565B96 File Offset: 0x00563D96
		private Texture2D searchTexture
		{
			get
			{
				if (this.m_SearchTexture == null)
				{
					this.m_SearchTexture = Resources.Load<Texture2D>("SearchTex");
				}
				return this.m_SearchTexture;
			}
		}

		// Token: 0x0600BF8B RID: 49035 RVA: 0x00565BBC File Offset: 0x00563DBC
		private Texture2D BNEKGHIKMPH()
		{
			if (this.m_AreaTexture == null)
			{
				this.m_AreaTexture = Resources.Load<Texture2D>("invn_rec12");
			}
			return this.m_AreaTexture;
		}

		// Token: 0x0600BF8C RID: 49036 RVA: 0x00565BE4 File Offset: 0x00563DE4
		public void MKLCOEALFBI()
		{
			if (this.m_Material != null)
			{
				UnityEngine.Object.DestroyImmediate(this.m_Material);
			}
			if (this.m_Accumulation != null)
			{
				UnityEngine.Object.DestroyImmediate(this.m_Accumulation);
			}
			this.m_Material = null;
			this.m_Accumulation = null;
		}

		// Token: 0x0600BF8D RID: 49037 RVA: 0x00565C31 File Offset: 0x00563E31
		private Texture2D OBLANIBLPHC()
		{
			if (this.m_AreaTexture == null)
			{
				this.m_AreaTexture = Resources.Load<Texture2D>("---------- NetManager is init");
			}
			return this.m_AreaTexture;
		}

		// Token: 0x0600BF8E RID: 49038 RVA: 0x00565C58 File Offset: 0x00563E58
		public void IBIBOJIPANH(Camera LBCHLCGOCOD, RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			int pixelWidth = LBCHLCGOCOD.pixelWidth;
			int pixelHeight = LBCHLCGOCOD.pixelHeight;
			bool flag = true;
			SMAA.QualitySettings qualitySettings = this.quality;
			if (this.settings.quality != (SMAA.IGANPGEGPEM)7)
			{
				qualitySettings = SMAA.QualitySettings.presetQualitySettings[(int)this.settings.quality];
			}
			int edgeDetectionMethod = (int)this.settings.edgeDetectionMethod;
			int pass = 3;
			int pass2 = 6;
			int pass3 = 5;
			Matrix4x4 matrix4x = GL.GetGPUProjectionMatrix(this.m_ProjectionMatrix, false) * LBCHLCGOCOD.worldToCameraMatrix;
			this.CDHGPDDEKDF().SetTexture("_OcclusionBlurTexture", this.KGJPCMMMIEC());
			this.EDJPFAGCMOF().SetTexture("HA", this.searchTexture);
			this.LIMJONOGMLK().SetVector("{0}-{1}={2}", new Vector4(417f / (float)pixelWidth, 1584f / (float)pixelHeight, (float)pixelWidth, (float)pixelHeight));
			this.FIJPFGKEFLJ().SetVector("ok", new Vector4(qualitySettings.threshold, qualitySettings.depthThreshold, (float)qualitySettings.maxSearchSteps, (float)qualitySettings.maxDiagonalSearchSteps));
			this.NMKHIFDAABO().SetVector("post_10", new Vector2((float)qualitySettings.cornerRounding, qualitySettings.localContrastAdaptationFactor));
			this.EDJPFAGCMOF().SetMatrix("\n", this.m_PreviousViewProjectionMatrix * Matrix4x4.Inverse(matrix4x));
			float num = (this.m_FlipFlop < 726f) ? 1656f : 653f;
			this.FIJPFGKEFLJ().SetVector("ClimbUp", new Vector4(num, num, num, 447f));
			Shader.DisableKeyword("_CosPower");
			if (this.settings.edgeDetectionMethod == (SMAA.LBPDFECBNDH)5)
			{
				LBCHLCGOCOD.depthTextureMode |= DepthTextureMode.Depth;
			}
			else if (this.predication.enabled)
			{
				LBCHLCGOCOD.depthTextureMode |= DepthTextureMode.None;
				Shader.EnableKeyword("KatanaNinjaDraw");
				this.NMKHIFDAABO().SetVector("_WrinkleOcclusionStrengths", new Vector3(this.predication.threshold, this.predication.scale, this.predication.strength));
			}
			Shader.DisableKeyword("_Intensity");
			Shader.DisableKeyword("quests/achivments_name/qd");
			if (qualitySettings.diagonalDetection)
			{
				Shader.EnableKeyword("IdleButtonPress");
			}
			if (qualitySettings.cornerDetection)
			{
				Shader.EnableKeyword("AssetLoader: ");
			}
			Shader.DisableKeyword("******** ChatPanelPos ");
			if (this.temporal.DEDDDKAPPEF())
			{
				Shader.EnableKeyword("intensity");
			}
			if (this.m_Accumulation == null || this.m_Accumulation.width != pixelWidth || this.m_Accumulation.height != pixelHeight)
			{
				if (this.m_Accumulation)
				{
					RenderTexture.ReleaseTemporary(this.m_Accumulation);
				}
				this.m_Accumulation = RenderTexture.GetTemporary(pixelWidth, pixelHeight, 0, JONJODLFAEN.format, RenderTextureReadWrite.Linear);
				this.m_Accumulation.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
				flag = true;
			}
			RenderTexture renderTexture = this.GFCBEBIINPL(pixelWidth, pixelHeight, JONJODLFAEN.format);
			Graphics.Blit(null, renderTexture, this.CDHGPDDEKDF(), 0);
			Graphics.Blit(JONJODLFAEN, renderTexture, this.MFJAILMGELI(), edgeDetectionMethod);
			if (this.settings.debugPass == SMAA.OKHNDFFDNFJ.Edges)
			{
				Graphics.Blit(renderTexture, OKIIDHIJBEA);
			}
			else
			{
				RenderTexture renderTexture2 = this.MFPNHDFLIAI(pixelWidth, pixelHeight, JONJODLFAEN.format);
				Graphics.Blit(null, renderTexture2, this.LIMJONOGMLK(), 1);
				Graphics.Blit(renderTexture, renderTexture2, this.CDHGPDDEKDF(), pass);
				if (this.settings.debugPass == SMAA.OKHNDFFDNFJ.Weights)
				{
					Graphics.Blit(renderTexture2, OKIIDHIJBEA);
				}
				else
				{
					this.material.SetTexture("Windmill", renderTexture2);
					if (this.temporal.DEOGJODJAMN())
					{
						Graphics.Blit(JONJODLFAEN, renderTexture, this.MFJAILMGELI(), pass2);
						if (this.settings.debugPass == SMAA.OKHNDFFDNFJ.Edges)
						{
							Graphics.Blit(this.m_Accumulation, OKIIDHIJBEA);
						}
						else if (!flag)
						{
							this.CFJAMJGLPBF().SetTexture("WeaponReadyFire", this.m_Accumulation);
							Graphics.Blit(renderTexture, OKIIDHIJBEA, this.MFJAILMGELI(), pass3);
						}
						else
						{
							Graphics.Blit(renderTexture, OKIIDHIJBEA);
						}
						Graphics.Blit(OKIIDHIJBEA, this.m_Accumulation);
						RenderTexture.active = null;
					}
					else
					{
						Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LONGCFJAKBH(), pass2);
					}
				}
				RenderTexture.ReleaseTemporary(renderTexture2);
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			this.m_PreviousViewProjectionMatrix = matrix4x;
		}

		// Token: 0x0600BF8F RID: 49039 RVA: 0x0056606C File Offset: 0x0056426C
		public void IDLPAPLFPLJ(Camera LBCHLCGOCOD, RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			int pixelWidth = LBCHLCGOCOD.pixelWidth;
			int pixelHeight = LBCHLCGOCOD.pixelHeight;
			bool flag = true;
			SMAA.QualitySettings qualitySettings = this.quality;
			if (this.settings.quality != SMAA.IGANPGEGPEM.High)
			{
				qualitySettings = SMAA.QualitySettings.presetQualitySettings[(int)this.settings.quality];
			}
			int edgeDetectionMethod = (int)this.settings.edgeDetectionMethod;
			int pass = 0;
			int pass2 = 6;
			int pass3 = 2;
			Matrix4x4 matrix4x = GL.GetGPUProjectionMatrix(this.m_ProjectionMatrix, false) * LBCHLCGOCOD.worldToCameraMatrix;
			this.EDJPFAGCMOF().SetTexture("act_orderb_1", this.areaTexture);
			this.CFJAMJGLPBF().SetTexture("KatanaReady", this.CEINBGEEBNH());
			this.LONGCFJAKBH().SetVector("****************  playNextMusic ", new Vector4(1190f / (float)pixelWidth, 835f / (float)pixelHeight, (float)pixelWidth, (float)pixelHeight));
			this.EDJPFAGCMOF().SetVector("cht_msg2", new Vector4(qualitySettings.threshold, qualitySettings.depthThreshold, (float)qualitySettings.maxSearchSteps, (float)qualitySettings.maxDiagonalSearchSteps));
			this.FIJPFGKEFLJ().SetVector("wgt_big.dat", new Vector2((float)qualitySettings.cornerRounding, qualitySettings.localContrastAdaptationFactor));
			this.FIJPFGKEFLJ().SetMatrix("fishwgt", this.m_PreviousViewProjectionMatrix * Matrix4x4.Inverse(matrix4x));
			float num = (this.m_FlipFlop < 38f) ? 680f : 1508f;
			this.CDHGPDDEKDF().SetVector("ok", new Vector4(num, num, num, 1092f));
			Shader.DisableKeyword("ObscuredInt vs int, ");
			if (this.settings.edgeDetectionMethod == SMAA.LBPDFECBNDH.Depth)
			{
				LBCHLCGOCOD.depthTextureMode |= DepthTextureMode.Depth;
			}
			else if (this.predication.enabled)
			{
				LBCHLCGOCOD.depthTextureMode |= DepthTextureMode.None;
				Shader.EnableKeyword("Hidden/Post FX/Temporal Anti-aliasing");
				this.LONGCFJAKBH().SetVector("repair.ogg", new Vector3(this.predication.threshold, this.predication.scale, this.predication.strength));
			}
			Shader.DisableKeyword(" шт.");
			Shader.DisableKeyword("error");
			if (qualitySettings.diagonalDetection)
			{
				Shader.EnableKeyword("_Source");
			}
			if (qualitySettings.cornerDetection)
			{
				Shader.EnableKeyword("PistolFire");
			}
			Shader.DisableKeyword("__c");
			if (this.temporal.MLIIKPEOPML())
			{
				Shader.EnableKeyword("ZombieWalk");
			}
			if (this.m_Accumulation == null || this.m_Accumulation.width != pixelWidth || this.m_Accumulation.height != pixelHeight)
			{
				if (this.m_Accumulation)
				{
					RenderTexture.ReleaseTemporary(this.m_Accumulation);
				}
				this.m_Accumulation = RenderTexture.GetTemporary(pixelWidth, pixelHeight, 0, JONJODLFAEN.format, RenderTextureReadWrite.Linear);
				this.m_Accumulation.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
				flag = false;
			}
			RenderTexture renderTexture = this.LMJKNCFGIPB(pixelWidth, pixelHeight, JONJODLFAEN.format);
			Graphics.Blit(null, renderTexture, this.NMKHIFDAABO(), 1);
			Graphics.Blit(JONJODLFAEN, renderTexture, this.LIMJONOGMLK(), edgeDetectionMethod);
			if (this.settings.debugPass == SMAA.OKHNDFFDNFJ.Off)
			{
				Graphics.Blit(renderTexture, OKIIDHIJBEA);
			}
			else
			{
				RenderTexture renderTexture2 = this.KGJIKGHMBBE(pixelWidth, pixelHeight, JONJODLFAEN.format);
				Graphics.Blit(null, renderTexture2, this.EDJPFAGCMOF(), 0);
				Graphics.Blit(renderTexture, renderTexture2, this.LIMJONOGMLK(), pass);
				if (this.settings.debugPass == (SMAA.OKHNDFFDNFJ)6)
				{
					Graphics.Blit(renderTexture2, OKIIDHIJBEA);
				}
				else
				{
					this.NMKHIFDAABO().SetTexture("<color='#808080'>[{2}]</color> <color='#c0c0c0'>{0}</color>: {1}", renderTexture2);
					if (this.temporal.OIAKPMDLDEM())
					{
						Graphics.Blit(JONJODLFAEN, renderTexture, this.LIMJONOGMLK(), pass2);
						if (this.settings.debugPass == SMAA.OKHNDFFDNFJ.Off)
						{
							Graphics.Blit(this.m_Accumulation, OKIIDHIJBEA);
						}
						else if (!flag)
						{
							this.LIMJONOGMLK().SetTexture("noworkpoints", this.m_Accumulation);
							Graphics.Blit(renderTexture, OKIIDHIJBEA, this.material, pass3);
						}
						else
						{
							Graphics.Blit(renderTexture, OKIIDHIJBEA);
						}
						Graphics.Blit(OKIIDHIJBEA, this.m_Accumulation);
						RenderTexture.active = null;
					}
					else
					{
						Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LONGCFJAKBH(), pass2);
					}
				}
				RenderTexture.ReleaseTemporary(renderTexture2);
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			this.m_PreviousViewProjectionMatrix = matrix4x;
		}

		// Token: 0x0600BF90 RID: 49040 RVA: 0x0056647E File Offset: 0x0056467E
		private Material FIJPFGKEFLJ()
		{
			if (this.m_Material == null)
			{
				this.m_Material = OOFCHDPCJIJ.DJFOEIJIMJB(this.shader);
			}
			return this.m_Material;
		}

		// Token: 0x0600BF91 RID: 49041 RVA: 0x005664A5 File Offset: 0x005646A5
		public void BKGHBKPDMDH(AntiAliasing EJJPBLDJFDF)
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.JNFKIDLCJFH(), true, false, EJJPBLDJFDF))
			{
				EJJPBLDJFDF.enabled = true;
			}
		}

		// Token: 0x0600BF92 RID: 49042 RVA: 0x005664BE File Offset: 0x005646BE
		public void ADAAFIBDJAO(Camera LBCHLCGOCOD)
		{
			if (this.temporal.PALDDEICCIG())
			{
				LBCHLCGOCOD.ResetProjectionMatrix();
			}
		}

		// Token: 0x0600BF93 RID: 49043 RVA: 0x005664D4 File Offset: 0x005646D4
		public void KLKCKFDGMJN()
		{
			if (this.m_Material != null)
			{
				UnityEngine.Object.DestroyImmediate(this.m_Material);
			}
			if (this.m_Accumulation != null)
			{
				UnityEngine.Object.DestroyImmediate(this.m_Accumulation);
			}
			this.m_Material = null;
			this.m_Accumulation = null;
		}

		// Token: 0x0600BF94 RID: 49044 RVA: 0x00566521 File Offset: 0x00564721
		public void FLPMJFEGJLG(AntiAliasing EJJPBLDJFDF)
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.shader, false, false, EJJPBLDJFDF))
			{
				EJJPBLDJFDF.enabled = false;
			}
		}

		// Token: 0x0600BF95 RID: 49045 RVA: 0x0056653C File Offset: 0x0056473C
		public void HPGMKBPAFGM()
		{
			if (this.m_Material != null)
			{
				UnityEngine.Object.DestroyImmediate(this.m_Material);
			}
			if (this.m_Accumulation != null)
			{
				UnityEngine.Object.DestroyImmediate(this.m_Accumulation);
			}
			this.m_Material = null;
			this.m_Accumulation = null;
		}

		// Token: 0x0600BF96 RID: 49046 RVA: 0x0056658C File Offset: 0x0056478C
		public void OGAHGKEICEO(Camera LBCHLCGOCOD)
		{
			if (this.temporal.HCNPAKGDBDP())
			{
				this.m_ProjectionMatrix = LBCHLCGOCOD.projectionMatrix;
				this.m_FlipFlop -= 1343f * this.m_FlipFlop;
				Matrix4x4 identity = Matrix4x4.identity;
				identity.m03 = 552f * this.m_FlipFlop * this.temporal.fuzzSize / (float)LBCHLCGOCOD.pixelWidth;
				identity.m13 = 1838f * this.m_FlipFlop * this.temporal.fuzzSize / (float)LBCHLCGOCOD.pixelHeight;
				LBCHLCGOCOD.projectionMatrix = identity * LBCHLCGOCOD.projectionMatrix;
			}
		}

		// Token: 0x0600BF97 RID: 49047 RVA: 0x00566634 File Offset: 0x00564834
		public void NEAHNADAEMI(Camera LBCHLCGOCOD)
		{
			if (this.temporal.NNKBEIDBBCA())
			{
				this.m_ProjectionMatrix = LBCHLCGOCOD.projectionMatrix;
				this.m_FlipFlop -= 54f * this.m_FlipFlop;
				Matrix4x4 identity = Matrix4x4.identity;
				identity.m03 = 264f * this.m_FlipFlop * this.temporal.fuzzSize / (float)LBCHLCGOCOD.pixelWidth;
				identity.m13 = 1192f * this.m_FlipFlop * this.temporal.fuzzSize / (float)LBCHLCGOCOD.pixelHeight;
				LBCHLCGOCOD.projectionMatrix = identity * LBCHLCGOCOD.projectionMatrix;
			}
		}

		// Token: 0x0600BF98 RID: 49048 RVA: 0x005666DC File Offset: 0x005648DC
		private RenderTexture LMJKNCFGIPB(int NMEBEEHCALN, int ILLKFNCFGMP, RenderTextureFormat LJCEDKCLBDB)
		{
			int depthBuffer = 0;
			return RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, depthBuffer, LJCEDKCLBDB, RenderTextureReadWrite.Default);
		}

		// Token: 0x0600BF99 RID: 49049 RVA: 0x005666F8 File Offset: 0x005648F8
		public void IOPEDDLLPPL()
		{
			if (this.m_Material != null)
			{
				UnityEngine.Object.DestroyImmediate(this.m_Material);
			}
			if (this.m_Accumulation != null)
			{
				UnityEngine.Object.DestroyImmediate(this.m_Accumulation);
			}
			this.m_Material = null;
			this.m_Accumulation = null;
		}

		// Token: 0x0600BF9A RID: 49050 RVA: 0x00566748 File Offset: 0x00564948
		private RenderTexture ELOOHMNOPJI(int NMEBEEHCALN, int ILLKFNCFGMP, RenderTextureFormat LJCEDKCLBDB)
		{
			int depthBuffer = 1;
			return RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, depthBuffer, LJCEDKCLBDB, RenderTextureReadWrite.Linear);
		}

		// Token: 0x0600BF9B RID: 49051 RVA: 0x00566764 File Offset: 0x00564964
		public void IFNADJCIPCC(Camera LBCHLCGOCOD)
		{
			if (this.temporal.DGDJJNNOJBF())
			{
				this.m_ProjectionMatrix = LBCHLCGOCOD.projectionMatrix;
				this.m_FlipFlop -= 1004f * this.m_FlipFlop;
				Matrix4x4 identity = Matrix4x4.identity;
				identity.m03 = 1241f * this.m_FlipFlop * this.temporal.fuzzSize / (float)LBCHLCGOCOD.pixelWidth;
				identity.m13 = 1560f * this.m_FlipFlop * this.temporal.fuzzSize / (float)LBCHLCGOCOD.pixelHeight;
				LBCHLCGOCOD.projectionMatrix = identity * LBCHLCGOCOD.projectionMatrix;
			}
		}

		// Token: 0x0600BF9C RID: 49052 RVA: 0x0056680C File Offset: 0x00564A0C
		public void HDMDLPFMGNM(Camera LBCHLCGOCOD)
		{
			if (this.temporal.DLFLNMMLFLB())
			{
				this.m_ProjectionMatrix = LBCHLCGOCOD.projectionMatrix;
				this.m_FlipFlop -= 558f * this.m_FlipFlop;
				Matrix4x4 identity = Matrix4x4.identity;
				identity.m03 = 716f * this.m_FlipFlop * this.temporal.fuzzSize / (float)LBCHLCGOCOD.pixelWidth;
				identity.m13 = 1132f * this.m_FlipFlop * this.temporal.fuzzSize / (float)LBCHLCGOCOD.pixelHeight;
				LBCHLCGOCOD.projectionMatrix = identity * LBCHLCGOCOD.projectionMatrix;
			}
		}

		// Token: 0x0600BF9D RID: 49053 RVA: 0x005668B4 File Offset: 0x00564AB4
		public void DHFIJAIMEBL(Camera LBCHLCGOCOD)
		{
			if (this.temporal.DGDJJNNOJBF())
			{
				LBCHLCGOCOD.ResetProjectionMatrix();
			}
		}

		// Token: 0x0600BF9E RID: 49054 RVA: 0x005668CC File Offset: 0x00564ACC
		public void ONGDKJCBPNA(Camera LBCHLCGOCOD)
		{
			if (this.temporal.JNBGAPLBABH())
			{
				this.m_ProjectionMatrix = LBCHLCGOCOD.projectionMatrix;
				this.m_FlipFlop -= 1452f * this.m_FlipFlop;
				Matrix4x4 identity = Matrix4x4.identity;
				identity.m03 = 1153f * this.m_FlipFlop * this.temporal.fuzzSize / (float)LBCHLCGOCOD.pixelWidth;
				identity.m13 = 173f * this.m_FlipFlop * this.temporal.fuzzSize / (float)LBCHLCGOCOD.pixelHeight;
				LBCHLCGOCOD.projectionMatrix = identity * LBCHLCGOCOD.projectionMatrix;
			}
		}

		// Token: 0x0600BF9F RID: 49055 RVA: 0x00566974 File Offset: 0x00564B74
		private Texture2D CCCMBHLHJKC()
		{
			if (this.m_AreaTexture == null)
			{
				this.m_AreaTexture = Resources.Load<Texture2D>("Screen Space Reflections");
			}
			return this.m_AreaTexture;
		}

		// Token: 0x0600BFA0 RID: 49056 RVA: 0x0056699C File Offset: 0x00564B9C
		public void NOLGMGLINIJ()
		{
			if (this.m_Material != null)
			{
				UnityEngine.Object.DestroyImmediate(this.m_Material);
			}
			if (this.m_Accumulation != null)
			{
				UnityEngine.Object.DestroyImmediate(this.m_Accumulation);
			}
			this.m_Material = null;
			this.m_Accumulation = null;
		}

		// Token: 0x0600BFA1 RID: 49057 RVA: 0x005669E9 File Offset: 0x00564BE9
		private Material MFJAILMGELI()
		{
			if (this.m_Material == null)
			{
				this.m_Material = OOFCHDPCJIJ.DJFOEIJIMJB(this.KOAFBOEOBLI());
			}
			return this.m_Material;
		}

		// Token: 0x0600BFA2 RID: 49058 RVA: 0x00566A10 File Offset: 0x00564C10
		public void EEHJEDIFHJI(AntiAliasing EJJPBLDJFDF)
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.JNFKIDLCJFH(), true, false, EJJPBLDJFDF))
			{
				EJJPBLDJFDF.enabled = false;
			}
		}

		// Token: 0x0600BFA3 RID: 49059 RVA: 0x00566A2C File Offset: 0x00564C2C
		private RenderTexture MFPNHDFLIAI(int NMEBEEHCALN, int ILLKFNCFGMP, RenderTextureFormat LJCEDKCLBDB)
		{
			int depthBuffer = 1;
			return RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, depthBuffer, LJCEDKCLBDB, RenderTextureReadWrite.Linear);
		}

		// Token: 0x0600BFA4 RID: 49060 RVA: 0x005669E9 File Offset: 0x00564BE9
		private Material LIMJONOGMLK()
		{
			if (this.m_Material == null)
			{
				this.m_Material = OOFCHDPCJIJ.DJFOEIJIMJB(this.KOAFBOEOBLI());
			}
			return this.m_Material;
		}

		// Token: 0x0600BFA5 RID: 49061 RVA: 0x00566A45 File Offset: 0x00564C45
		public void JEEFIADOHNP(Camera LBCHLCGOCOD)
		{
			if (this.temporal.DLFLNMMLFLB())
			{
				LBCHLCGOCOD.ResetProjectionMatrix();
			}
		}

		// Token: 0x0600BFA6 RID: 49062 RVA: 0x00566A5A File Offset: 0x00564C5A
		public void NKKHCJDLMII(AntiAliasing EJJPBLDJFDF)
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.GOPKJLGEDHG(), true, false, EJJPBLDJFDF))
			{
				EJJPBLDJFDF.enabled = true;
			}
		}

		// Token: 0x0600BFA7 RID: 49063 RVA: 0x00566A73 File Offset: 0x00564C73
		private Texture2D LPKIIINMMNL()
		{
			if (this.m_SearchTexture == null)
			{
				this.m_SearchTexture = Resources.Load<Texture2D>("text");
			}
			return this.m_SearchTexture;
		}

		// Token: 0x0600BFA8 RID: 49064 RVA: 0x00566A9C File Offset: 0x00564C9C
		public void BPDNFFGPMPP()
		{
			if (this.m_Material != null)
			{
				UnityEngine.Object.DestroyImmediate(this.m_Material);
			}
			if (this.m_Accumulation != null)
			{
				UnityEngine.Object.DestroyImmediate(this.m_Accumulation);
			}
			this.m_Material = null;
			this.m_Accumulation = null;
		}

		// Token: 0x0600BFA9 RID: 49065 RVA: 0x00566AEC File Offset: 0x00564CEC
		public void HHDGLCOOOOI(Camera LBCHLCGOCOD)
		{
			if (this.temporal.DEDDDKAPPEF())
			{
				this.m_ProjectionMatrix = LBCHLCGOCOD.projectionMatrix;
				this.m_FlipFlop -= 987f * this.m_FlipFlop;
				Matrix4x4 identity = Matrix4x4.identity;
				identity.m03 = 914f * this.m_FlipFlop * this.temporal.fuzzSize / (float)LBCHLCGOCOD.pixelWidth;
				identity.m13 = 812f * this.m_FlipFlop * this.temporal.fuzzSize / (float)LBCHLCGOCOD.pixelHeight;
				LBCHLCGOCOD.projectionMatrix = identity * LBCHLCGOCOD.projectionMatrix;
			}
		}

		// Token: 0x0600BFAA RID: 49066 RVA: 0x0056576D File Offset: 0x0056396D
		public void EKHNOGEBFJN(Camera LBCHLCGOCOD)
		{
			if (this.temporal.OIAKPMDLDEM())
			{
				LBCHLCGOCOD.ResetProjectionMatrix();
			}
		}

		// Token: 0x0600BFAB RID: 49067 RVA: 0x00566B94 File Offset: 0x00564D94
		private RenderTexture AKHIBOAHPMH(int NMEBEEHCALN, int ILLKFNCFGMP, RenderTextureFormat LJCEDKCLBDB)
		{
			int depthBuffer = 0;
			return RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, depthBuffer, LJCEDKCLBDB, RenderTextureReadWrite.Default);
		}

		// Token: 0x0600BFAC RID: 49068 RVA: 0x00566BB0 File Offset: 0x00564DB0
		public void LLLBNNNNFPJ()
		{
			if (this.m_Material != null)
			{
				UnityEngine.Object.DestroyImmediate(this.m_Material);
			}
			if (this.m_Accumulation != null)
			{
				UnityEngine.Object.DestroyImmediate(this.m_Accumulation);
			}
			this.m_Material = null;
			this.m_Accumulation = null;
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x0600BFAD RID: 49069 RVA: 0x00566BFD File Offset: 0x00564DFD
		private Texture2D areaTexture
		{
			get
			{
				if (this.m_AreaTexture == null)
				{
					this.m_AreaTexture = Resources.Load<Texture2D>("AreaTex");
				}
				return this.m_AreaTexture;
			}
		}

		// Token: 0x0600BFAE RID: 49070 RVA: 0x00566C23 File Offset: 0x00564E23
		private Material LONGCFJAKBH()
		{
			if (this.m_Material == null)
			{
				this.m_Material = OOFCHDPCJIJ.DJFOEIJIMJB(this.LOKBBEDAFJM());
			}
			return this.m_Material;
		}

		// Token: 0x0600BFAF RID: 49071 RVA: 0x00566C4C File Offset: 0x00564E4C
		public void JPCPEPMDLAN(Camera LBCHLCGOCOD, RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			int pixelWidth = LBCHLCGOCOD.pixelWidth;
			int pixelHeight = LBCHLCGOCOD.pixelHeight;
			bool flag = false;
			SMAA.QualitySettings qualitySettings = this.quality;
			if (this.settings.quality != (SMAA.IGANPGEGPEM)7)
			{
				qualitySettings = SMAA.QualitySettings.presetQualitySettings[(int)this.settings.quality];
			}
			int edgeDetectionMethod = (int)this.settings.edgeDetectionMethod;
			int pass = 4;
			int pass2 = 8;
			int pass3 = 5;
			Matrix4x4 matrix4x = GL.GetGPUProjectionMatrix(this.m_ProjectionMatrix, false) * LBCHLCGOCOD.worldToCameraMatrix;
			this.material.SetTexture("IdleWalk", this.HAPIFFBKBFO());
			this.EDJPFAGCMOF().SetTexture("Sitting Idle", this.CIKAGBEEBOO());
			this.LIMJONOGMLK().SetVector("autherror", new Vector4(1807f / (float)pixelWidth, 1102f / (float)pixelHeight, (float)pixelWidth, (float)pixelHeight));
			this.CDHGPDDEKDF().SetVector("PistolReady", new Vector4(qualitySettings.threshold, qualitySettings.depthThreshold, (float)qualitySettings.maxSearchSteps, (float)qualitySettings.maxDiagonalSearchSteps));
			this.NMKHIFDAABO().SetVector("_HueShift", new Vector2((float)qualitySettings.cornerRounding, qualitySettings.localContrastAdaptationFactor));
			this.FIJPFGKEFLJ().SetMatrix("VA ", this.m_PreviousViewProjectionMatrix * Matrix4x4.Inverse(matrix4x));
			float num = (this.m_FlipFlop < 615f) ? 1659f : 1330f;
			this.material.SetVector("<[^>]*>", new Vector4(num, num, num, 1045f));
			Shader.DisableKeyword("VIGNETTE_FILMIC");
			if (this.settings.edgeDetectionMethod == (SMAA.LBPDFECBNDH)0)
			{
				LBCHLCGOCOD.depthTextureMode |= DepthTextureMode.None;
			}
			else if (this.predication.enabled)
			{
				LBCHLCGOCOD.depthTextureMode |= DepthTextureMode.None;
				Shader.EnableKeyword("{0:F2}, {1:F2}, {2:F2}, {3:F2}");
				this.LONGCFJAKBH().SetVector("MotorbikeTurnRight", new Vector3(this.predication.threshold, this.predication.scale, this.predication.strength));
			}
			Shader.DisableKeyword("");
			Shader.DisableKeyword("act_order");
			if (qualitySettings.diagonalDetection)
			{
				Shader.EnableKeyword("ok");
			}
			if (qualitySettings.cornerDetection)
			{
				Shader.EnableKeyword("#02C85F");
			}
			Shader.DisableKeyword("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
			if (this.temporal.NKAFLGHGBMB())
			{
				Shader.EnableKeyword("_UnderwaterMode");
			}
			if (this.m_Accumulation == null || this.m_Accumulation.width != pixelWidth || this.m_Accumulation.height != pixelHeight)
			{
				if (this.m_Accumulation)
				{
					RenderTexture.ReleaseTemporary(this.m_Accumulation);
				}
				this.m_Accumulation = RenderTexture.GetTemporary(pixelWidth, pixelHeight, 1, JONJODLFAEN.format, RenderTextureReadWrite.Default);
				this.m_Accumulation.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
				flag = false;
			}
			RenderTexture renderTexture = this.MLOFFFNFIJA(pixelWidth, pixelHeight, JONJODLFAEN.format);
			Graphics.Blit(null, renderTexture, this.MFJAILMGELI(), 0);
			Graphics.Blit(JONJODLFAEN, renderTexture, this.EDJPFAGCMOF(), edgeDetectionMethod);
			if (this.settings.debugPass == SMAA.OKHNDFFDNFJ.Edges)
			{
				Graphics.Blit(renderTexture, OKIIDHIJBEA);
			}
			else
			{
				RenderTexture renderTexture2 = this.GFCBEBIINPL(pixelWidth, pixelHeight, JONJODLFAEN.format);
				Graphics.Blit(null, renderTexture2, this.EDJPFAGCMOF(), 1);
				Graphics.Blit(renderTexture, renderTexture2, this.CDHGPDDEKDF(), pass);
				if (this.settings.debugPass == SMAA.OKHNDFFDNFJ.Off)
				{
					Graphics.Blit(renderTexture2, OKIIDHIJBEA);
				}
				else
				{
					this.FIJPFGKEFLJ().SetTexture("WeaponRunBackward", renderTexture2);
					if (this.temporal.DGNKCDKNEKA())
					{
						Graphics.Blit(JONJODLFAEN, renderTexture, this.NMKHIFDAABO(), pass2);
						if (this.settings.debugPass == (SMAA.OKHNDFFDNFJ)4)
						{
							Graphics.Blit(this.m_Accumulation, OKIIDHIJBEA);
						}
						else if (!flag)
						{
							this.NMKHIFDAABO().SetTexture("inv_invheader", this.m_Accumulation);
							Graphics.Blit(renderTexture, OKIIDHIJBEA, this.LIMJONOGMLK(), pass3);
						}
						else
						{
							Graphics.Blit(renderTexture, OKIIDHIJBEA);
						}
						Graphics.Blit(OKIIDHIJBEA, this.m_Accumulation);
						RenderTexture.active = null;
					}
					else
					{
						Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FIJPFGKEFLJ(), pass2);
					}
				}
				RenderTexture.ReleaseTemporary(renderTexture2);
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			this.m_PreviousViewProjectionMatrix = matrix4x;
		}

		// Token: 0x0600BFB0 RID: 49072 RVA: 0x00567060 File Offset: 0x00565260
		public void AHGKFHDKAOE(Camera LBCHLCGOCOD)
		{
			if (this.temporal.OKDDFMDDHON())
			{
				this.m_ProjectionMatrix = LBCHLCGOCOD.projectionMatrix;
				this.m_FlipFlop -= 768f * this.m_FlipFlop;
				Matrix4x4 identity = Matrix4x4.identity;
				identity.m03 = 1930f * this.m_FlipFlop * this.temporal.fuzzSize / (float)LBCHLCGOCOD.pixelWidth;
				identity.m13 = 1677f * this.m_FlipFlop * this.temporal.fuzzSize / (float)LBCHLCGOCOD.pixelHeight;
				LBCHLCGOCOD.projectionMatrix = identity * LBCHLCGOCOD.projectionMatrix;
			}
		}

		// Token: 0x0600BFB1 RID: 49073 RVA: 0x00567108 File Offset: 0x00565308
		public void OEMNNJHHGCI(Camera LBCHLCGOCOD)
		{
			if (this.temporal.HNBNMFPPAPN())
			{
				this.m_ProjectionMatrix = LBCHLCGOCOD.projectionMatrix;
				this.m_FlipFlop -= 2f * this.m_FlipFlop;
				Matrix4x4 identity = Matrix4x4.identity;
				identity.m03 = 0.25f * this.m_FlipFlop * this.temporal.fuzzSize / (float)LBCHLCGOCOD.pixelWidth;
				identity.m13 = -0.25f * this.m_FlipFlop * this.temporal.fuzzSize / (float)LBCHLCGOCOD.pixelHeight;
				LBCHLCGOCOD.projectionMatrix = identity * LBCHLCGOCOD.projectionMatrix;
			}
		}

		// Token: 0x0600BFB2 RID: 49074 RVA: 0x005671B0 File Offset: 0x005653B0
		public void LMDPGEDNHNK(Camera LBCHLCGOCOD)
		{
			if (this.temporal.HJCHNEFGBCK())
			{
				LBCHLCGOCOD.ResetProjectionMatrix();
			}
		}

		// Token: 0x0600BFB3 RID: 49075 RVA: 0x005671C5 File Offset: 0x005653C5
		private Texture2D JOMIMBBHMMJ()
		{
			if (this.m_AreaTexture == null)
			{
				this.m_AreaTexture = Resources.Load<Texture2D>("The 'VAlign' command requires an alignment parameter of ? (default) or B (bottom).");
			}
			return this.m_AreaTexture;
		}

		// Token: 0x0600BFB4 RID: 49076 RVA: 0x005671EC File Offset: 0x005653EC
		private RenderTexture FNNILOJBEMA(int NMEBEEHCALN, int ILLKFNCFGMP, RenderTextureFormat LJCEDKCLBDB)
		{
			int depthBuffer = 0;
			return RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, depthBuffer, LJCEDKCLBDB, RenderTextureReadWrite.Default);
		}

		// Token: 0x0600BFB5 RID: 49077 RVA: 0x00567205 File Offset: 0x00565405
		public void IDGIPDDGDFN(AntiAliasing EJJPBLDJFDF)
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.CLHPPJPLKMM(), true, false, EJJPBLDJFDF))
			{
				EJJPBLDJFDF.enabled = true;
			}
		}

		// Token: 0x0600BFB6 RID: 49078 RVA: 0x00567220 File Offset: 0x00565420
		public void HOACOEINOJB(Camera LBCHLCGOCOD, RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			int pixelWidth = LBCHLCGOCOD.pixelWidth;
			int pixelHeight = LBCHLCGOCOD.pixelHeight;
			bool flag = false;
			SMAA.QualitySettings qualitySettings = this.quality;
			if (this.settings.quality != SMAA.IGANPGEGPEM.Low)
			{
				qualitySettings = SMAA.QualitySettings.presetQualitySettings[(int)this.settings.quality];
			}
			int edgeDetectionMethod = (int)this.settings.edgeDetectionMethod;
			int pass = 5;
			int pass2 = 0;
			int pass3 = 4;
			Matrix4x4 matrix4x = GL.GetGPUProjectionMatrix(this.m_ProjectionMatrix, false) * LBCHLCGOCOD.worldToCameraMatrix;
			this.EDJPFAGCMOF().SetTexture("", this.GPHOOOPEMBH());
			this.MFJAILMGELI().SetTexture("", this.NKLBFKOBDCD());
			this.MFJAILMGELI().SetVector("Crouch Walk Backward", new Vector4(1293f / (float)pixelWidth, 1309f / (float)pixelHeight, (float)pixelWidth, (float)pixelHeight));
			this.material.SetVector("IdleSad", new Vector4(qualitySettings.threshold, qualitySettings.depthThreshold, (float)qualitySettings.maxSearchSteps, (float)qualitySettings.maxDiagonalSearchSteps));
			this.LIMJONOGMLK().SetVector("Mouse X", new Vector2((float)qualitySettings.cornerRounding, qualitySettings.localContrastAdaptationFactor));
			this.material.SetMatrix("/", this.m_PreviousViewProjectionMatrix * Matrix4x4.Inverse(matrix4x));
			float num = (this.m_FlipFlop < 529f) ? 1038f : 1685f;
			this.CFJAMJGLPBF().SetVector("wpn_add/base", new Vector4(num, num, num, 1225f));
			Shader.DisableKeyword("gi_fridgiceno");
			if (this.settings.edgeDetectionMethod == (SMAA.LBPDFECBNDH)8)
			{
				LBCHLCGOCOD.depthTextureMode |= DepthTextureMode.Depth;
			}
			else if (this.predication.enabled)
			{
				LBCHLCGOCOD.depthTextureMode |= DepthTextureMode.None;
				Shader.EnableKeyword("Crouch180");
				this.material.SetVector("1 Hand Sword Strafe Right", new Vector3(this.predication.threshold, this.predication.scale, this.predication.strength));
			}
			Shader.DisableKeyword("mask=");
			Shader.DisableKeyword(" ");
			if (qualitySettings.diagonalDetection)
			{
				Shader.EnableKeyword("Hidden/Amplify Color/Blend");
			}
			if (qualitySettings.cornerDetection)
			{
				Shader.EnableKeyword("OfficeSitting45DegLeg");
			}
			Shader.DisableKeyword("Mouse Y");
			if (this.temporal.DGNKCDKNEKA())
			{
				Shader.EnableKeyword("SoccerSprint");
			}
			if (this.m_Accumulation == null || this.m_Accumulation.width != pixelWidth || this.m_Accumulation.height != pixelHeight)
			{
				if (this.m_Accumulation)
				{
					RenderTexture.ReleaseTemporary(this.m_Accumulation);
				}
				this.m_Accumulation = RenderTexture.GetTemporary(pixelWidth, pixelHeight, 0, JONJODLFAEN.format, RenderTextureReadWrite.Linear);
				this.m_Accumulation.hideFlags = (HideFlags)(-66);
				flag = true;
			}
			RenderTexture renderTexture = this.GMGJOGPPHEP(pixelWidth, pixelHeight, JONJODLFAEN.format);
			Graphics.Blit(null, renderTexture, this.CFJAMJGLPBF(), 1);
			Graphics.Blit(JONJODLFAEN, renderTexture, this.FIJPFGKEFLJ(), edgeDetectionMethod);
			if (this.settings.debugPass == SMAA.OKHNDFFDNFJ.Edges)
			{
				Graphics.Blit(renderTexture, OKIIDHIJBEA);
			}
			else
			{
				RenderTexture renderTexture2 = this.KGJIKGHMBBE(pixelWidth, pixelHeight, JONJODLFAEN.format);
				Graphics.Blit(null, renderTexture2, this.EDJPFAGCMOF(), 0);
				Graphics.Blit(renderTexture, renderTexture2, this.CFJAMJGLPBF(), pass);
				if (this.settings.debugPass == (SMAA.OKHNDFFDNFJ)4)
				{
					Graphics.Blit(renderTexture2, OKIIDHIJBEA);
				}
				else
				{
					this.CDHGPDDEKDF().SetTexture("SwimFreestyle", renderTexture2);
					if (this.temporal.MCKDDKPIJFG())
					{
						Graphics.Blit(JONJODLFAEN, renderTexture, this.EDJPFAGCMOF(), pass2);
						if (this.settings.debugPass == (SMAA.OKHNDFFDNFJ)8)
						{
							Graphics.Blit(this.m_Accumulation, OKIIDHIJBEA);
						}
						else if (!flag)
						{
							this.MFJAILMGELI().SetTexture("t_eye", this.m_Accumulation);
							Graphics.Blit(renderTexture, OKIIDHIJBEA, this.CDHGPDDEKDF(), pass3);
						}
						else
						{
							Graphics.Blit(renderTexture, OKIIDHIJBEA);
						}
						Graphics.Blit(OKIIDHIJBEA, this.m_Accumulation);
						RenderTexture.active = null;
					}
					else
					{
						Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LIMJONOGMLK(), pass2);
					}
				}
				RenderTexture.ReleaseTemporary(renderTexture2);
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			this.m_PreviousViewProjectionMatrix = matrix4x;
		}

		// Token: 0x0600BFB7 RID: 49079 RVA: 0x00567634 File Offset: 0x00565834
		public void EOMGNPFHPBD(Camera LBCHLCGOCOD, RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			int pixelWidth = LBCHLCGOCOD.pixelWidth;
			int pixelHeight = LBCHLCGOCOD.pixelHeight;
			bool flag = true;
			SMAA.QualitySettings qualitySettings = this.quality;
			if (this.settings.quality != (SMAA.IGANPGEGPEM)6)
			{
				qualitySettings = SMAA.QualitySettings.presetQualitySettings[(int)this.settings.quality];
			}
			int edgeDetectionMethod = (int)this.settings.edgeDetectionMethod;
			int pass = 4;
			int pass2 = 4;
			int pass3 = 3;
			Matrix4x4 matrix4x = GL.GetGPUProjectionMatrix(this.m_ProjectionMatrix, false) * LBCHLCGOCOD.worldToCameraMatrix;
			this.LIMJONOGMLK().SetTexture("BendGoal is deprecated, you can now a bend goal from the custom inspector of the LimbIK component.", this.GPHOOOPEMBH());
			this.LONGCFJAKBH().SetTexture("", this.CEINBGEEBNH());
			this.LONGCFJAKBH().SetVector("_Threshold", new Vector4(1776f / (float)pixelWidth, 94f / (float)pixelHeight, (float)pixelWidth, (float)pixelHeight));
			this.EDJPFAGCMOF().SetVector("IdleSadHips", new Vector4(qualitySettings.threshold, qualitySettings.depthThreshold, (float)qualitySettings.maxSearchSteps, (float)qualitySettings.maxDiagonalSearchSteps));
			this.EDJPFAGCMOF().SetVector("HYPERLINK", new Vector2((float)qualitySettings.cornerRounding, qualitySettings.localContrastAdaptationFactor));
			this.CDHGPDDEKDF().SetMatrix("[LH &]", this.m_PreviousViewProjectionMatrix * Matrix4x4.Inverse(matrix4x));
			float num = (this.m_FlipFlop < 768f) ? 1357f : 718f;
			this.NMKHIFDAABO().SetVector("******** ChatPanelPos ", new Vector4(num, num, num, 729f));
			Shader.DisableKeyword("exitmsg_3");
			if (this.settings.edgeDetectionMethod == SMAA.LBPDFECBNDH.Luma)
			{
				LBCHLCGOCOD.depthTextureMode |= DepthTextureMode.Depth;
			}
			else if (this.predication.enabled)
			{
				LBCHLCGOCOD.depthTextureMode |= DepthTextureMode.None;
				Shader.EnableKeyword("_camHue");
				this.material.SetVector("Tail", new Vector3(this.predication.threshold, this.predication.scale, this.predication.strength));
			}
			Shader.DisableKeyword("TOD_MoonCloudColor");
			Shader.DisableKeyword("ObscuredPrefs vs PlayerPrefs, ");
			if (qualitySettings.diagonalDetection)
			{
				Shader.EnableKeyword("MotorbikeSuperman");
			}
			if (qualitySettings.cornerDetection)
			{
				Shader.EnableKeyword("");
			}
			Shader.DisableKeyword("_ReflectionTex");
			if (this.temporal.NKAFLGHGBMB())
			{
				Shader.EnableKeyword("null");
			}
			if (this.m_Accumulation == null || this.m_Accumulation.width != pixelWidth || this.m_Accumulation.height != pixelHeight)
			{
				if (this.m_Accumulation)
				{
					RenderTexture.ReleaseTemporary(this.m_Accumulation);
				}
				this.m_Accumulation = RenderTexture.GetTemporary(pixelWidth, pixelHeight, 1, JONJODLFAEN.format, RenderTextureReadWrite.Default);
				this.m_Accumulation.hideFlags = (HideFlags)74;
				flag = false;
			}
			RenderTexture renderTexture = this.GKEPDDJLNDI(pixelWidth, pixelHeight, JONJODLFAEN.format);
			Graphics.Blit(null, renderTexture, this.MFJAILMGELI(), 0);
			Graphics.Blit(JONJODLFAEN, renderTexture, this.MFJAILMGELI(), edgeDetectionMethod);
			if (this.settings.debugPass == SMAA.OKHNDFFDNFJ.Off)
			{
				Graphics.Blit(renderTexture, OKIIDHIJBEA);
			}
			else
			{
				RenderTexture renderTexture2 = this.AAPIEJGLGJC(pixelWidth, pixelHeight, JONJODLFAEN.format);
				Graphics.Blit(null, renderTexture2, this.LIMJONOGMLK(), 0);
				Graphics.Blit(renderTexture, renderTexture2, this.NMKHIFDAABO(), pass);
				if (this.settings.debugPass == SMAA.OKHNDFFDNFJ.Weights)
				{
					Graphics.Blit(renderTexture2, OKIIDHIJBEA);
				}
				else
				{
					this.CFJAMJGLPBF().SetTexture("CraftProf.xml", renderTexture2);
					if (this.temporal.GBLBJCKONKF())
					{
						Graphics.Blit(JONJODLFAEN, renderTexture, this.FIJPFGKEFLJ(), pass2);
						if (this.settings.debugPass == SMAA.OKHNDFFDNFJ.Accumulation)
						{
							Graphics.Blit(this.m_Accumulation, OKIIDHIJBEA);
						}
						else if (!flag)
						{
							this.MFJAILMGELI().SetTexture("_MainTex", this.m_Accumulation);
							Graphics.Blit(renderTexture, OKIIDHIJBEA, this.material, pass3);
						}
						else
						{
							Graphics.Blit(renderTexture, OKIIDHIJBEA);
						}
						Graphics.Blit(OKIIDHIJBEA, this.m_Accumulation);
						RenderTexture.active = null;
					}
					else
					{
						Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.CFJAMJGLPBF(), pass2);
					}
				}
				RenderTexture.ReleaseTemporary(renderTexture2);
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			this.m_PreviousViewProjectionMatrix = matrix4x;
		}

		// Token: 0x0600BFB8 RID: 49080 RVA: 0x00567A46 File Offset: 0x00565C46
		public void AMAMLEMHNOJ(Camera LBCHLCGOCOD)
		{
			if (this.temporal.APLLJAJPHPA())
			{
				LBCHLCGOCOD.ResetProjectionMatrix();
			}
		}

		// Token: 0x0600BFB9 RID: 49081 RVA: 0x00567A5C File Offset: 0x00565C5C
		public void ELOEBKBLKEE(Camera LBCHLCGOCOD)
		{
			if (this.temporal.DGNKCDKNEKA())
			{
				this.m_ProjectionMatrix = LBCHLCGOCOD.projectionMatrix;
				this.m_FlipFlop -= 230f * this.m_FlipFlop;
				Matrix4x4 identity = Matrix4x4.identity;
				identity.m03 = 11f * this.m_FlipFlop * this.temporal.fuzzSize / (float)LBCHLCGOCOD.pixelWidth;
				identity.m13 = 452f * this.m_FlipFlop * this.temporal.fuzzSize / (float)LBCHLCGOCOD.pixelHeight;
				LBCHLCGOCOD.projectionMatrix = identity * LBCHLCGOCOD.projectionMatrix;
			}
		}

		// Token: 0x0600BFBA RID: 49082 RVA: 0x00567B04 File Offset: 0x00565D04
		public void FOKJAIOLDGA(Camera LBCHLCGOCOD)
		{
			if (this.temporal.BLNCDIMJODK())
			{
				this.m_ProjectionMatrix = LBCHLCGOCOD.projectionMatrix;
				this.m_FlipFlop -= 1842f * this.m_FlipFlop;
				Matrix4x4 identity = Matrix4x4.identity;
				identity.m03 = 1463f * this.m_FlipFlop * this.temporal.fuzzSize / (float)LBCHLCGOCOD.pixelWidth;
				identity.m13 = 1100f * this.m_FlipFlop * this.temporal.fuzzSize / (float)LBCHLCGOCOD.pixelHeight;
				LBCHLCGOCOD.projectionMatrix = identity * LBCHLCGOCOD.projectionMatrix;
			}
		}

		// Token: 0x0600BFBB RID: 49083 RVA: 0x00567BAC File Offset: 0x00565DAC
		private RenderTexture AAPIEJGLGJC(int NMEBEEHCALN, int ILLKFNCFGMP, RenderTextureFormat LJCEDKCLBDB)
		{
			int depthBuffer = 1;
			return RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, depthBuffer, LJCEDKCLBDB, RenderTextureReadWrite.Default);
		}

		// Token: 0x0600BFBC RID: 49084 RVA: 0x00567BC8 File Offset: 0x00565DC8
		public void PPMHJHCELEO(Camera LBCHLCGOCOD)
		{
			if (this.temporal.HJCHNEFGBCK())
			{
				this.m_ProjectionMatrix = LBCHLCGOCOD.projectionMatrix;
				this.m_FlipFlop -= 1608f * this.m_FlipFlop;
				Matrix4x4 identity = Matrix4x4.identity;
				identity.m03 = 918f * this.m_FlipFlop * this.temporal.fuzzSize / (float)LBCHLCGOCOD.pixelWidth;
				identity.m13 = 1202f * this.m_FlipFlop * this.temporal.fuzzSize / (float)LBCHLCGOCOD.pixelHeight;
				LBCHLCGOCOD.projectionMatrix = identity * LBCHLCGOCOD.projectionMatrix;
			}
		}

		// Token: 0x0600BFBD RID: 49085 RVA: 0x00567C70 File Offset: 0x00565E70
		private Texture2D GDABAPEFBHL()
		{
			if (this.m_AreaTexture == null)
			{
				this.m_AreaTexture = Resources.Load<Texture2D>("PLANE_REFLECTION");
			}
			return this.m_AreaTexture;
		}

		// Token: 0x0600BFBE RID: 49086 RVA: 0x00567C98 File Offset: 0x00565E98
		private RenderTexture GFCBEBIINPL(int NMEBEEHCALN, int ILLKFNCFGMP, RenderTextureFormat LJCEDKCLBDB)
		{
			int depthBuffer = 0;
			return RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, depthBuffer, LJCEDKCLBDB, RenderTextureReadWrite.Default);
		}

		// Token: 0x0600BFBF RID: 49087 RVA: 0x00567CB1 File Offset: 0x00565EB1
		public void GEKDJDMHMKC(Camera LBCHLCGOCOD)
		{
			if (this.temporal.HNBNMFPPAPN())
			{
				LBCHLCGOCOD.ResetProjectionMatrix();
			}
		}

		// Token: 0x0600BFC0 RID: 49088 RVA: 0x00567CC6 File Offset: 0x00565EC6
		public void IDNCCNHJPGL(Camera LBCHLCGOCOD)
		{
			if (this.temporal.ADPPKPBNKPE())
			{
				LBCHLCGOCOD.ResetProjectionMatrix();
			}
		}

		// Token: 0x0600BFC1 RID: 49089 RVA: 0x00567CDC File Offset: 0x00565EDC
		public void EPOJLAKECDD(Camera LBCHLCGOCOD)
		{
			if (this.temporal.BGJKBMKGLPH())
			{
				this.m_ProjectionMatrix = LBCHLCGOCOD.projectionMatrix;
				this.m_FlipFlop -= 1615f * this.m_FlipFlop;
				Matrix4x4 identity = Matrix4x4.identity;
				identity.m03 = 843f * this.m_FlipFlop * this.temporal.fuzzSize / (float)LBCHLCGOCOD.pixelWidth;
				identity.m13 = 1178f * this.m_FlipFlop * this.temporal.fuzzSize / (float)LBCHLCGOCOD.pixelHeight;
				LBCHLCGOCOD.projectionMatrix = identity * LBCHLCGOCOD.projectionMatrix;
			}
		}

		// Token: 0x0600BFC2 RID: 49090 RVA: 0x00567D84 File Offset: 0x00565F84
		public void OJHPOCALAMK(Camera LBCHLCGOCOD)
		{
			if (this.temporal.DMFNBGKALII())
			{
				LBCHLCGOCOD.ResetProjectionMatrix();
			}
		}

		// Token: 0x0600BFC3 RID: 49091 RVA: 0x00567D9C File Offset: 0x00565F9C
		private RenderTexture GKEPDDJLNDI(int NMEBEEHCALN, int ILLKFNCFGMP, RenderTextureFormat LJCEDKCLBDB)
		{
			int depthBuffer = 1;
			return RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, depthBuffer, LJCEDKCLBDB, RenderTextureReadWrite.Linear);
		}

		// Token: 0x0600BFC4 RID: 49092 RVA: 0x00567DB8 File Offset: 0x00565FB8
		public void EACKHNENAML()
		{
			if (this.m_Material != null)
			{
				UnityEngine.Object.DestroyImmediate(this.m_Material);
			}
			if (this.m_Accumulation != null)
			{
				UnityEngine.Object.DestroyImmediate(this.m_Accumulation);
			}
			this.m_Material = null;
			this.m_Accumulation = null;
		}

		// Token: 0x0600BFC5 RID: 49093 RVA: 0x0056559A File Offset: 0x0056379A
		public void MNKOLABGENB(AntiAliasing EJJPBLDJFDF)
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.GOPKJLGEDHG(), true, false, EJJPBLDJFDF))
			{
				EJJPBLDJFDF.enabled = false;
			}
		}

		// Token: 0x0600BFC6 RID: 49094 RVA: 0x00567E08 File Offset: 0x00566008
		private RenderTexture EEFGOMEBACA(int NMEBEEHCALN, int ILLKFNCFGMP, RenderTextureFormat LJCEDKCLBDB)
		{
			int depthBuffer = 1;
			return RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, depthBuffer, LJCEDKCLBDB, RenderTextureReadWrite.Linear);
		}

		// Token: 0x0600BFC7 RID: 49095 RVA: 0x00567E24 File Offset: 0x00566024
		public void ODIMHGKLJCM(Camera LBCHLCGOCOD)
		{
			if (this.temporal.HJCHNEFGBCK())
			{
				this.m_ProjectionMatrix = LBCHLCGOCOD.projectionMatrix;
				this.m_FlipFlop -= 1302f * this.m_FlipFlop;
				Matrix4x4 identity = Matrix4x4.identity;
				identity.m03 = 1560f * this.m_FlipFlop * this.temporal.fuzzSize / (float)LBCHLCGOCOD.pixelWidth;
				identity.m13 = 1681f * this.m_FlipFlop * this.temporal.fuzzSize / (float)LBCHLCGOCOD.pixelHeight;
				LBCHLCGOCOD.projectionMatrix = identity * LBCHLCGOCOD.projectionMatrix;
			}
		}

		// Token: 0x0600BFC8 RID: 49096 RVA: 0x00567ECC File Offset: 0x005660CC
		private RenderTexture MLOFFFNFIJA(int NMEBEEHCALN, int ILLKFNCFGMP, RenderTextureFormat LJCEDKCLBDB)
		{
			int depthBuffer = 1;
			return RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, depthBuffer, LJCEDKCLBDB, RenderTextureReadWrite.Default);
		}

		// Token: 0x0600BFC9 RID: 49097 RVA: 0x00567EE5 File Offset: 0x005660E5
		public void MLMLCANNEMA(Camera LBCHLCGOCOD)
		{
			if (this.temporal.HCNPAKGDBDP())
			{
				LBCHLCGOCOD.ResetProjectionMatrix();
			}
		}

		// Token: 0x0600BFCA RID: 49098 RVA: 0x00567EFA File Offset: 0x005660FA
		private Texture2D EDGCLGKGIPN()
		{
			if (this.m_AreaTexture == null)
			{
				this.m_AreaTexture = Resources.Load<Texture2D>("WATER_EDGEBLEND_OFF");
			}
			return this.m_AreaTexture;
		}

		// Token: 0x0600BFCC RID: 49100 RVA: 0x00567F70 File Offset: 0x00566170
		public Shader CLHPPJPLKMM()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("FireBreath");
			}
			return this.m_Shader;
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x0600BFCD RID: 49101 RVA: 0x00567F96 File Offset: 0x00566196
		public Shader shader
		{
			get
			{
				if (this.m_Shader == null)
				{
					this.m_Shader = Shader.Find("Hidden/Subpixel Morphological Anti-aliasing");
				}
				return this.m_Shader;
			}
		}

		// Token: 0x0600BFCE RID: 49102 RVA: 0x00567FBC File Offset: 0x005661BC
		public void DHFLFGBENBF(AntiAliasing EJJPBLDJFDF)
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.GLEKFBOEOJJ(), false, true, EJJPBLDJFDF))
			{
				EJJPBLDJFDF.enabled = false;
			}
		}

		// Token: 0x0600BFCF RID: 49103 RVA: 0x00567FD5 File Offset: 0x005661D5
		public Shader GOPKJLGEDHG()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("FISHES");
			}
			return this.m_Shader;
		}

		// Token: 0x0600BFD0 RID: 49104 RVA: 0x00567FFB File Offset: 0x005661FB
		private Texture2D FKCFJHLFKIC()
		{
			if (this.m_SearchTexture == null)
			{
				this.m_SearchTexture = Resources.Load<Texture2D>(" ");
			}
			return this.m_SearchTexture;
		}

		// Token: 0x0600BFD1 RID: 49105 RVA: 0x00568024 File Offset: 0x00566224
		public void PDLCGJMHDHE(Camera LBCHLCGOCOD)
		{
			if (this.temporal.PALDDEICCIG())
			{
				this.m_ProjectionMatrix = LBCHLCGOCOD.projectionMatrix;
				this.m_FlipFlop -= 949f * this.m_FlipFlop;
				Matrix4x4 identity = Matrix4x4.identity;
				identity.m03 = 555f * this.m_FlipFlop * this.temporal.fuzzSize / (float)LBCHLCGOCOD.pixelWidth;
				identity.m13 = 819f * this.m_FlipFlop * this.temporal.fuzzSize / (float)LBCHLCGOCOD.pixelHeight;
				LBCHLCGOCOD.projectionMatrix = identity * LBCHLCGOCOD.projectionMatrix;
			}
		}

		// Token: 0x0600BFD2 RID: 49106 RVA: 0x00567EE5 File Offset: 0x005660E5
		public void DNLBFILCMBM(Camera LBCHLCGOCOD)
		{
			if (this.temporal.HCNPAKGDBDP())
			{
				LBCHLCGOCOD.ResetProjectionMatrix();
			}
		}

		// Token: 0x0600BFD3 RID: 49107 RVA: 0x005680CC File Offset: 0x005662CC
		private Texture2D AODOOKLMNDE()
		{
			if (this.m_SearchTexture == null)
			{
				this.m_SearchTexture = Resources.Load<Texture2D>("IceHockeyShotRight");
			}
			return this.m_SearchTexture;
		}

		// Token: 0x0600BFD4 RID: 49108 RVA: 0x005680F4 File Offset: 0x005662F4
		private RenderTexture MOBBBGKOJJB(int NMEBEEHCALN, int ILLKFNCFGMP, RenderTextureFormat LJCEDKCLBDB)
		{
			int depthBuffer = 0;
			return RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, depthBuffer, LJCEDKCLBDB, RenderTextureReadWrite.Linear);
		}

		// Token: 0x0600BFD5 RID: 49109 RVA: 0x0056810D File Offset: 0x0056630D
		private Material CFJAMJGLPBF()
		{
			if (this.m_Material == null)
			{
				this.m_Material = OOFCHDPCJIJ.DJFOEIJIMJB(this.JNFKIDLCJFH());
			}
			return this.m_Material;
		}

		// Token: 0x0600BFD6 RID: 49110 RVA: 0x00568134 File Offset: 0x00566334
		private RenderTexture HBDGPOCJKAJ(int NMEBEEHCALN, int ILLKFNCFGMP, RenderTextureFormat LJCEDKCLBDB)
		{
			int depthBuffer = 1;
			return RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, depthBuffer, LJCEDKCLBDB, RenderTextureReadWrite.Linear);
		}

		// Token: 0x0600BFD7 RID: 49111 RVA: 0x0056814D File Offset: 0x0056634D
		public void FMELNEBFOHP(Camera LBCHLCGOCOD)
		{
			if (this.temporal.NNKBEIDBBCA())
			{
				LBCHLCGOCOD.ResetProjectionMatrix();
			}
		}

		// Token: 0x0600BFD8 RID: 49112 RVA: 0x00568162 File Offset: 0x00566362
		public void OBIPAJDKIHF(AntiAliasing EJJPBLDJFDF)
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.LOKBBEDAFJM(), true, false, EJJPBLDJFDF))
			{
				EJJPBLDJFDF.enabled = true;
			}
		}

		// Token: 0x0600BFD9 RID: 49113 RVA: 0x0056817B File Offset: 0x0056637B
		private Material EDJPFAGCMOF()
		{
			if (this.m_Material == null)
			{
				this.m_Material = OOFCHDPCJIJ.DJFOEIJIMJB(this.GOPKJLGEDHG());
			}
			return this.m_Material;
		}

		// Token: 0x0600BFDA RID: 49114 RVA: 0x005681A2 File Offset: 0x005663A2
		private Texture2D CEINBGEEBNH()
		{
			if (this.m_SearchTexture == null)
			{
				this.m_SearchTexture = Resources.Load<Texture2D>("SixStep");
			}
			return this.m_SearchTexture;
		}

		// Token: 0x0600BFDB RID: 49115 RVA: 0x005681C8 File Offset: 0x005663C8
		public Shader KOAFBOEOBLI()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("20");
			}
			return this.m_Shader;
		}

		// Token: 0x0600BFDC RID: 49116 RVA: 0x005681F0 File Offset: 0x005663F0
		public void EFJBGANEFLM(Camera LBCHLCGOCOD)
		{
			if (this.temporal.DGDJJNNOJBF())
			{
				this.m_ProjectionMatrix = LBCHLCGOCOD.projectionMatrix;
				this.m_FlipFlop -= 461f * this.m_FlipFlop;
				Matrix4x4 identity = Matrix4x4.identity;
				identity.m03 = 940f * this.m_FlipFlop * this.temporal.fuzzSize / (float)LBCHLCGOCOD.pixelWidth;
				identity.m13 = 62f * this.m_FlipFlop * this.temporal.fuzzSize / (float)LBCHLCGOCOD.pixelHeight;
				LBCHLCGOCOD.projectionMatrix = identity * LBCHLCGOCOD.projectionMatrix;
			}
		}

		// Token: 0x0600BFDD RID: 49117 RVA: 0x00568298 File Offset: 0x00566498
		private RenderTexture GBJFAFPCCHL(int NMEBEEHCALN, int ILLKFNCFGMP, RenderTextureFormat LJCEDKCLBDB)
		{
			int depthBuffer = 1;
			return RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, depthBuffer, LJCEDKCLBDB, RenderTextureReadWrite.Linear);
		}

		// Token: 0x0600BFDE RID: 49118 RVA: 0x005682B4 File Offset: 0x005664B4
		private RenderTexture GMGJOGPPHEP(int NMEBEEHCALN, int ILLKFNCFGMP, RenderTextureFormat LJCEDKCLBDB)
		{
			int depthBuffer = 0;
			return RenderTexture.GetTemporary(NMEBEEHCALN, ILLKFNCFGMP, depthBuffer, LJCEDKCLBDB, RenderTextureReadWrite.Linear);
		}

		// Token: 0x0600BFDF RID: 49119 RVA: 0x005682CD File Offset: 0x005664CD
		public void APPOBIOMMPG(AntiAliasing EJJPBLDJFDF)
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.LOKBBEDAFJM(), false, true, EJJPBLDJFDF))
			{
				EJJPBLDJFDF.enabled = true;
			}
		}

		// Token: 0x0600BFE0 RID: 49120 RVA: 0x005682E6 File Offset: 0x005664E6
		public void DKGAOLLKDPD(AntiAliasing EJJPBLDJFDF)
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.CLHPPJPLKMM(), true, true, EJJPBLDJFDF))
			{
				EJJPBLDJFDF.enabled = false;
			}
		}

		// Token: 0x0600BFE1 RID: 49121 RVA: 0x005682FF File Offset: 0x005664FF
		public Shader LOKBBEDAFJM()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("");
			}
			return this.m_Shader;
		}

		// Token: 0x0600BFE2 RID: 49122 RVA: 0x00568325 File Offset: 0x00566525
		private Texture2D JHDCALDEGAD()
		{
			if (this.m_AreaTexture == null)
			{
				this.m_AreaTexture = Resources.Load<Texture2D>("_Bloom_Settings");
			}
			return this.m_AreaTexture;
		}

		// Token: 0x0600BFE3 RID: 49123 RVA: 0x0056834C File Offset: 0x0056654C
		public void BPPEDFOAHLK(Camera LBCHLCGOCOD, RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			int pixelWidth = LBCHLCGOCOD.pixelWidth;
			int pixelHeight = LBCHLCGOCOD.pixelHeight;
			bool flag = false;
			SMAA.QualitySettings qualitySettings = this.quality;
			if (this.settings.quality != SMAA.IGANPGEGPEM.Custom)
			{
				qualitySettings = SMAA.QualitySettings.presetQualitySettings[(int)this.settings.quality];
			}
			int edgeDetectionMethod = (int)this.settings.edgeDetectionMethod;
			int pass = 4;
			int pass2 = 5;
			int pass3 = 6;
			Matrix4x4 matrix4x = GL.GetGPUProjectionMatrix(this.m_ProjectionMatrix, true) * LBCHLCGOCOD.worldToCameraMatrix;
			this.material.SetTexture("_AreaTex", this.areaTexture);
			this.material.SetTexture("_SearchTex", this.searchTexture);
			this.material.SetVector("_Metrics", new Vector4(1f / (float)pixelWidth, 1f / (float)pixelHeight, (float)pixelWidth, (float)pixelHeight));
			this.material.SetVector("_Params1", new Vector4(qualitySettings.threshold, qualitySettings.depthThreshold, (float)qualitySettings.maxSearchSteps, (float)qualitySettings.maxDiagonalSearchSteps));
			this.material.SetVector("_Params2", new Vector2((float)qualitySettings.cornerRounding, qualitySettings.localContrastAdaptationFactor));
			this.material.SetMatrix("_ReprojectionMatrix", this.m_PreviousViewProjectionMatrix * Matrix4x4.Inverse(matrix4x));
			float num = (this.m_FlipFlop < 0f) ? 2f : 1f;
			this.material.SetVector("_SubsampleIndices", new Vector4(num, num, num, 0f));
			Shader.DisableKeyword("USE_PREDICATION");
			if (this.settings.edgeDetectionMethod == SMAA.LBPDFECBNDH.Depth)
			{
				LBCHLCGOCOD.depthTextureMode |= DepthTextureMode.Depth;
			}
			else if (this.predication.enabled)
			{
				LBCHLCGOCOD.depthTextureMode |= DepthTextureMode.Depth;
				Shader.EnableKeyword("USE_PREDICATION");
				this.material.SetVector("_Params3", new Vector3(this.predication.threshold, this.predication.scale, this.predication.strength));
			}
			Shader.DisableKeyword("USE_DIAG_SEARCH");
			Shader.DisableKeyword("USE_CORNER_DETECTION");
			if (qualitySettings.diagonalDetection)
			{
				Shader.EnableKeyword("USE_DIAG_SEARCH");
			}
			if (qualitySettings.cornerDetection)
			{
				Shader.EnableKeyword("USE_CORNER_DETECTION");
			}
			Shader.DisableKeyword("USE_UV_BASED_REPROJECTION");
			if (this.temporal.HNBNMFPPAPN())
			{
				Shader.EnableKeyword("USE_UV_BASED_REPROJECTION");
			}
			if (this.m_Accumulation == null || this.m_Accumulation.width != pixelWidth || this.m_Accumulation.height != pixelHeight)
			{
				if (this.m_Accumulation)
				{
					RenderTexture.ReleaseTemporary(this.m_Accumulation);
				}
				this.m_Accumulation = RenderTexture.GetTemporary(pixelWidth, pixelHeight, 0, JONJODLFAEN.format, RenderTextureReadWrite.Linear);
				this.m_Accumulation.hideFlags = HideFlags.HideAndDontSave;
				flag = true;
			}
			RenderTexture renderTexture = this.GMGJOGPPHEP(pixelWidth, pixelHeight, JONJODLFAEN.format);
			Graphics.Blit(null, renderTexture, this.material, 0);
			Graphics.Blit(JONJODLFAEN, renderTexture, this.material, edgeDetectionMethod);
			if (this.settings.debugPass == SMAA.OKHNDFFDNFJ.Edges)
			{
				Graphics.Blit(renderTexture, OKIIDHIJBEA);
			}
			else
			{
				RenderTexture renderTexture2 = this.GMGJOGPPHEP(pixelWidth, pixelHeight, JONJODLFAEN.format);
				Graphics.Blit(null, renderTexture2, this.material, 0);
				Graphics.Blit(renderTexture, renderTexture2, this.material, pass);
				if (this.settings.debugPass == SMAA.OKHNDFFDNFJ.Weights)
				{
					Graphics.Blit(renderTexture2, OKIIDHIJBEA);
				}
				else
				{
					this.material.SetTexture("_BlendTex", renderTexture2);
					if (this.temporal.HNBNMFPPAPN())
					{
						Graphics.Blit(JONJODLFAEN, renderTexture, this.material, pass2);
						if (this.settings.debugPass == SMAA.OKHNDFFDNFJ.Accumulation)
						{
							Graphics.Blit(this.m_Accumulation, OKIIDHIJBEA);
						}
						else if (!flag)
						{
							this.material.SetTexture("_AccumulationTex", this.m_Accumulation);
							Graphics.Blit(renderTexture, OKIIDHIJBEA, this.material, pass3);
						}
						else
						{
							Graphics.Blit(renderTexture, OKIIDHIJBEA);
						}
						Graphics.Blit(OKIIDHIJBEA, this.m_Accumulation);
						RenderTexture.active = null;
					}
					else
					{
						Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.material, pass2);
					}
				}
				RenderTexture.ReleaseTemporary(renderTexture2);
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			this.m_PreviousViewProjectionMatrix = matrix4x;
		}

		// Token: 0x0600BFE4 RID: 49124 RVA: 0x00568760 File Offset: 0x00566960
		public void JCOOPIFFNNH(Camera LBCHLCGOCOD, RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			int pixelWidth = LBCHLCGOCOD.pixelWidth;
			int pixelHeight = LBCHLCGOCOD.pixelHeight;
			bool flag = true;
			SMAA.QualitySettings qualitySettings = this.quality;
			if (this.settings.quality != (SMAA.IGANPGEGPEM)7)
			{
				qualitySettings = SMAA.QualitySettings.presetQualitySettings[(int)this.settings.quality];
			}
			int edgeDetectionMethod = (int)this.settings.edgeDetectionMethod;
			int pass = 6;
			int pass2 = 2;
			int pass3 = 0;
			Matrix4x4 matrix4x = GL.GetGPUProjectionMatrix(this.m_ProjectionMatrix, false) * LBCHLCGOCOD.worldToCameraMatrix;
			this.NMKHIFDAABO().SetTexture("WalkInjured", this.KGJPCMMMIEC());
			this.EDJPFAGCMOF().SetTexture("WeaponStrafeRunRight", this.AODOOKLMNDE());
			this.LONGCFJAKBH().SetVector("RollerBladeFrontFlip", new Vector4(357f / (float)pixelWidth, 1339f / (float)pixelHeight, (float)pixelWidth, (float)pixelHeight));
			this.material.SetVector("index", new Vector4(qualitySettings.threshold, qualitySettings.depthThreshold, (float)qualitySettings.maxSearchSteps, (float)qualitySettings.maxDiagonalSearchSteps));
			this.NMKHIFDAABO().SetVector("time", new Vector2((float)qualitySettings.cornerRounding, qualitySettings.localContrastAdaptationFactor));
			this.LONGCFJAKBH().SetMatrix("sunshine_ShadowFadeParams", this.m_PreviousViewProjectionMatrix * Matrix4x4.Inverse(matrix4x));
			float num = (this.m_FlipFlop < 295f) ? 350f : 309f;
			this.LIMJONOGMLK().SetVector("", new Vector4(num, num, num, 1742f));
			Shader.DisableKeyword("");
			if (this.settings.edgeDetectionMethod == (SMAA.LBPDFECBNDH)4)
			{
				LBCHLCGOCOD.depthTextureMode |= DepthTextureMode.None;
			}
			else if (this.predication.enabled)
			{
				LBCHLCGOCOD.depthTextureMode |= DepthTextureMode.None;
				Shader.EnableKeyword("BattleRoar");
				this.material.SetVector("Spine", new Vector3(this.predication.threshold, this.predication.scale, this.predication.strength));
			}
			Shader.DisableKeyword("isRagulaSet");
			Shader.DisableKeyword("setCurrentProfil sm=");
			if (qualitySettings.diagonalDetection)
			{
				Shader.EnableKeyword("</color>");
			}
			if (qualitySettings.cornerDetection)
			{
				Shader.EnableKeyword("CrouchStrafeRight");
			}
			Shader.DisableKeyword("auk_pstinf");
			if (this.temporal.BLNCDIMJODK())
			{
				Shader.EnableKeyword("_R_");
			}
			if (this.m_Accumulation == null || this.m_Accumulation.width != pixelWidth || this.m_Accumulation.height != pixelHeight)
			{
				if (this.m_Accumulation)
				{
					RenderTexture.ReleaseTemporary(this.m_Accumulation);
				}
				this.m_Accumulation = RenderTexture.GetTemporary(pixelWidth, pixelHeight, 1, JONJODLFAEN.format, RenderTextureReadWrite.Linear);
				this.m_Accumulation.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
				flag = true;
			}
			RenderTexture renderTexture = this.GFCBEBIINPL(pixelWidth, pixelHeight, JONJODLFAEN.format);
			Graphics.Blit(null, renderTexture, this.LIMJONOGMLK(), 0);
			Graphics.Blit(JONJODLFAEN, renderTexture, this.EDJPFAGCMOF(), edgeDetectionMethod);
			if (this.settings.debugPass == SMAA.OKHNDFFDNFJ.Edges)
			{
				Graphics.Blit(renderTexture, OKIIDHIJBEA);
			}
			else
			{
				RenderTexture renderTexture2 = this.MOBBBGKOJJB(pixelWidth, pixelHeight, JONJODLFAEN.format);
				Graphics.Blit(null, renderTexture2, this.EDJPFAGCMOF(), 0);
				Graphics.Blit(renderTexture, renderTexture2, this.CFJAMJGLPBF(), pass);
				if (this.settings.debugPass == (SMAA.OKHNDFFDNFJ)4)
				{
					Graphics.Blit(renderTexture2, OKIIDHIJBEA);
				}
				else
				{
					this.FIJPFGKEFLJ().SetTexture("CUSTOM_COLOR_OFF", renderTexture2);
					if (this.temporal.DLFLNMMLFLB())
					{
						Graphics.Blit(JONJODLFAEN, renderTexture, this.NMKHIFDAABO(), pass2);
						if (this.settings.debugPass == (SMAA.OKHNDFFDNFJ)7)
						{
							Graphics.Blit(this.m_Accumulation, OKIIDHIJBEA);
						}
						else if (!flag)
						{
							this.CFJAMJGLPBF().SetTexture("result=OK", this.m_Accumulation);
							Graphics.Blit(renderTexture, OKIIDHIJBEA, this.NMKHIFDAABO(), pass3);
						}
						else
						{
							Graphics.Blit(renderTexture, OKIIDHIJBEA);
						}
						Graphics.Blit(OKIIDHIJBEA, this.m_Accumulation);
						RenderTexture.active = null;
					}
					else
					{
						Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LIMJONOGMLK(), pass2);
					}
				}
				RenderTexture.ReleaseTemporary(renderTexture2);
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			this.m_PreviousViewProjectionMatrix = matrix4x;
		}

		// Token: 0x0600BFE5 RID: 49125 RVA: 0x00568B72 File Offset: 0x00566D72
		private Texture2D JOPKANCDBBB()
		{
			if (this.m_SearchTexture == null)
			{
				this.m_SearchTexture = Resources.Load<Texture2D>("BUMPED");
			}
			return this.m_SearchTexture;
		}

		// Token: 0x0600BFE6 RID: 49126 RVA: 0x00566C23 File Offset: 0x00564E23
		private Material CDHGPDDEKDF()
		{
			if (this.m_Material == null)
			{
				this.m_Material = OOFCHDPCJIJ.DJFOEIJIMJB(this.LOKBBEDAFJM());
			}
			return this.m_Material;
		}

		// Token: 0x0600BFE7 RID: 49127 RVA: 0x00568B98 File Offset: 0x00566D98
		private Texture2D HAPIFFBKBFO()
		{
			if (this.m_AreaTexture == null)
			{
				this.m_AreaTexture = Resources.Load<Texture2D>("Noise & Grain effect failing as noise texture is not assigned. please assign.");
			}
			return this.m_AreaTexture;
		}

		// Token: 0x0600BFE8 RID: 49128 RVA: 0x00568BBE File Offset: 0x00566DBE
		public void ENHOALKJFJF(AntiAliasing EJJPBLDJFDF)
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.KOAFBOEOBLI(), false, false, EJJPBLDJFDF))
			{
				EJJPBLDJFDF.enabled = false;
			}
		}

		// Token: 0x0600BFE9 RID: 49129 RVA: 0x00568BD7 File Offset: 0x00566DD7
		public Shader GLEKFBOEOJJ()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find(" %\n");
			}
			return this.m_Shader;
		}

		// Token: 0x0600BFEA RID: 49130 RVA: 0x00568BFD File Offset: 0x00566DFD
		private Texture2D JEFBADJCOND()
		{
			if (this.m_AreaTexture == null)
			{
				this.m_AreaTexture = Resources.Load<Texture2D>("_AdaptationMax");
			}
			return this.m_AreaTexture;
		}

		// Token: 0x0600BFEB RID: 49131 RVA: 0x00568C23 File Offset: 0x00566E23
		public Shader IPCDMGELBNI()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("KatanaReadyHigh");
			}
			return this.m_Shader;
		}

		// Token: 0x0600BFEC RID: 49132 RVA: 0x00568C4C File Offset: 0x00566E4C
		public void NBOEOIPCPON(Camera LBCHLCGOCOD)
		{
			if (this.temporal.HCNPAKGDBDP())
			{
				this.m_ProjectionMatrix = LBCHLCGOCOD.projectionMatrix;
				this.m_FlipFlop -= 652f * this.m_FlipFlop;
				Matrix4x4 identity = Matrix4x4.identity;
				identity.m03 = 1862f * this.m_FlipFlop * this.temporal.fuzzSize / (float)LBCHLCGOCOD.pixelWidth;
				identity.m13 = 1374f * this.m_FlipFlop * this.temporal.fuzzSize / (float)LBCHLCGOCOD.pixelHeight;
				LBCHLCGOCOD.projectionMatrix = identity * LBCHLCGOCOD.projectionMatrix;
			}
		}

		// Token: 0x0600BFED RID: 49133 RVA: 0x00568CF4 File Offset: 0x00566EF4
		public void JOKAAEKICJK(AntiAliasing EJJPBLDJFDF)
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.GLEKFBOEOJJ(), false, true, EJJPBLDJFDF))
			{
				EJJPBLDJFDF.enabled = true;
			}
		}

		// Token: 0x0600BFEE RID: 49134 RVA: 0x0056576D File Offset: 0x0056396D
		public void EHNPGGMJBCP(Camera LBCHLCGOCOD)
		{
			if (this.temporal.OIAKPMDLDEM())
			{
				LBCHLCGOCOD.ResetProjectionMatrix();
			}
		}

		// Token: 0x0600BFEF RID: 49135 RVA: 0x00568D0D File Offset: 0x00566F0D
		private Texture2D HEJJBOGJHIE()
		{
			if (this.m_AreaTexture == null)
			{
				this.m_AreaTexture = Resources.Load<Texture2D>("MotorbikeTurnRight");
			}
			return this.m_AreaTexture;
		}

		// Token: 0x0600BFF0 RID: 49136 RVA: 0x00568D33 File Offset: 0x00566F33
		public Shader JNFKIDLCJFH()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("-U");
			}
			return this.m_Shader;
		}

		// Token: 0x0600BFF1 RID: 49137 RVA: 0x00568D59 File Offset: 0x00566F59
		private Texture2D BACFNDFHDMB()
		{
			if (this.m_AreaTexture == null)
			{
				this.m_AreaTexture = Resources.Load<Texture2D>("SoccerKeeperDiveStrafeCloseLeft");
			}
			return this.m_AreaTexture;
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x0600BFF2 RID: 49138 RVA: 0x0056647E File Offset: 0x0056467E
		private Material material
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

		// Token: 0x0600BFF3 RID: 49139 RVA: 0x005669E9 File Offset: 0x00564BE9
		private Material NMKHIFDAABO()
		{
			if (this.m_Material == null)
			{
				this.m_Material = OOFCHDPCJIJ.DJFOEIJIMJB(this.KOAFBOEOBLI());
			}
			return this.m_Material;
		}

		// Token: 0x0600BFF4 RID: 49140 RVA: 0x00568D7F File Offset: 0x00566F7F
		private Texture2D EKIHHDEEIPE()
		{
			if (this.m_SearchTexture == null)
			{
				this.m_SearchTexture = Resources.Load<Texture2D>(",");
			}
			return this.m_SearchTexture;
		}

		// Token: 0x0600BFF5 RID: 49141 RVA: 0x00568DA5 File Offset: 0x00566FA5
		private Texture2D CIKAGBEEBOO()
		{
			if (this.m_SearchTexture == null)
			{
				this.m_SearchTexture = Resources.Load<Texture2D>("ObscuredBool vs bool, ");
			}
			return this.m_SearchTexture;
		}

		// Token: 0x040018F6 RID: 6390
		[SMAA.DCJCLGBJFBK]
		public SMAA.GlobalSettings settings = SMAA.GlobalSettings.defaultSettings;

		// Token: 0x040018F7 RID: 6391
		[SMAA.BDHMHLJGIHG]
		public SMAA.QualitySettings quality = SMAA.QualitySettings.presetQualitySettings[2];

		// Token: 0x040018F8 RID: 6392
		[SMAA.BDHMHLJGIHG]
		public SMAA.PredicationSettings predication = SMAA.PredicationSettings.defaultSettings;

		// Token: 0x040018F9 RID: 6393
		[SMAA.EFDBMMOHNKG]
		[SMAA.BDHMHLJGIHG]
		public SMAA.TemporalSettings temporal = SMAA.TemporalSettings.defaultSettings;

		// Token: 0x040018FA RID: 6394
		private Matrix4x4 m_ProjectionMatrix;

		// Token: 0x040018FB RID: 6395
		private Matrix4x4 m_PreviousViewProjectionMatrix;

		// Token: 0x040018FC RID: 6396
		private float m_FlipFlop = 1f;

		// Token: 0x040018FD RID: 6397
		private RenderTexture m_Accumulation;

		// Token: 0x040018FE RID: 6398
		private Shader m_Shader;

		// Token: 0x040018FF RID: 6399
		private Texture2D m_AreaTexture;

		// Token: 0x04001900 RID: 6400
		private Texture2D m_SearchTexture;

		// Token: 0x04001901 RID: 6401
		private Material m_Material;

		// Token: 0x02000350 RID: 848
		[AttributeUsage(AttributeTargets.Field)]
		public class BDHMHLJGIHG : Attribute
		{
		}

		// Token: 0x02000351 RID: 849
		[AttributeUsage(AttributeTargets.Field)]
		public class DCJCLGBJFBK : Attribute
		{
		}

		// Token: 0x02000352 RID: 850
		[AttributeUsage(AttributeTargets.Field)]
		public class EFDBMMOHNKG : Attribute
		{
		}

		// Token: 0x02000353 RID: 851
		public enum OKHNDFFDNFJ
		{
			// Token: 0x04001903 RID: 6403
			Off,
			// Token: 0x04001904 RID: 6404
			Edges,
			// Token: 0x04001905 RID: 6405
			Weights,
			// Token: 0x04001906 RID: 6406
			Accumulation
		}

		// Token: 0x02000354 RID: 852
		public enum IGANPGEGPEM
		{
			// Token: 0x04001908 RID: 6408
			Low,
			// Token: 0x04001909 RID: 6409
			Medium,
			// Token: 0x0400190A RID: 6410
			High,
			// Token: 0x0400190B RID: 6411
			Ultra,
			// Token: 0x0400190C RID: 6412
			Custom
		}

		// Token: 0x02000355 RID: 853
		public enum LBPDFECBNDH
		{
			// Token: 0x0400190E RID: 6414
			Luma = 1,
			// Token: 0x0400190F RID: 6415
			Color,
			// Token: 0x04001910 RID: 6416
			Depth
		}

		// Token: 0x02000356 RID: 854
		[Serializable]
		public struct GlobalSettings
		{
			// Token: 0x0600BFF9 RID: 49145 RVA: 0x00568DD4 File Offset: 0x00566FD4
			public static SMAA.GlobalSettings MJLLLKFIDOE()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.OKHNDFFDNFJ.Off,
					quality = (SMAA.IGANPGEGPEM)8,
					edgeDetectionMethod = (SMAA.LBPDFECBNDH)7
				};
			}

			// Token: 0x17000297 RID: 663
			// (get) Token: 0x0600BFFA RID: 49146 RVA: 0x00568E04 File Offset: 0x00567004
			public static SMAA.GlobalSettings defaultSettings
			{
				get
				{
					return new SMAA.GlobalSettings
					{
						debugPass = SMAA.OKHNDFFDNFJ.Off,
						quality = SMAA.IGANPGEGPEM.High,
						edgeDetectionMethod = SMAA.LBPDFECBNDH.Color
					};
				}
			}

			// Token: 0x0600BFFB RID: 49147 RVA: 0x00568E34 File Offset: 0x00567034
			public static SMAA.GlobalSettings JPGMEJNEOCC()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.OKHNDFFDNFJ.Edges,
					quality = SMAA.IGANPGEGPEM.Low,
					edgeDetectionMethod = (SMAA.LBPDFECBNDH)0
				};
			}

			// Token: 0x0600BFFC RID: 49148 RVA: 0x00568E64 File Offset: 0x00567064
			public static SMAA.GlobalSettings HLLBKJENCLA()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.OKHNDFFDNFJ.Edges,
					quality = (SMAA.IGANPGEGPEM)7,
					edgeDetectionMethod = (SMAA.LBPDFECBNDH)4
				};
			}

			// Token: 0x0600BFFD RID: 49149 RVA: 0x00568E94 File Offset: 0x00567094
			public static SMAA.GlobalSettings COINKHKLJAP()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.OKHNDFFDNFJ.Off,
					quality = SMAA.IGANPGEGPEM.Custom,
					edgeDetectionMethod = (SMAA.LBPDFECBNDH)0
				};
			}

			// Token: 0x0600BFFE RID: 49150 RVA: 0x00568EC4 File Offset: 0x005670C4
			public static SMAA.GlobalSettings OCIMBHLOOGC()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.OKHNDFFDNFJ.Edges,
					quality = SMAA.IGANPGEGPEM.Ultra,
					edgeDetectionMethod = (SMAA.LBPDFECBNDH)4
				};
			}

			// Token: 0x0600BFFF RID: 49151 RVA: 0x00568EF4 File Offset: 0x005670F4
			public static SMAA.GlobalSettings MKEJGGFNILJ()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.OKHNDFFDNFJ.Edges,
					quality = (SMAA.IGANPGEGPEM)8,
					edgeDetectionMethod = SMAA.LBPDFECBNDH.Color
				};
			}

			// Token: 0x0600C000 RID: 49152 RVA: 0x00568F24 File Offset: 0x00567124
			public static SMAA.GlobalSettings GDKPNHJPBKJ()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.OKHNDFFDNFJ.Edges,
					quality = (SMAA.IGANPGEGPEM)6,
					edgeDetectionMethod = (SMAA.LBPDFECBNDH)0
				};
			}

			// Token: 0x0600C001 RID: 49153 RVA: 0x00568F54 File Offset: 0x00567154
			public static SMAA.GlobalSettings NLCHLENDMLI()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.OKHNDFFDNFJ.Edges,
					quality = SMAA.IGANPGEGPEM.Ultra,
					edgeDetectionMethod = SMAA.LBPDFECBNDH.Depth
				};
			}

			// Token: 0x0600C002 RID: 49154 RVA: 0x00568F84 File Offset: 0x00567184
			public static SMAA.GlobalSettings MDGIIBPIGJC()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.OKHNDFFDNFJ.Edges,
					quality = SMAA.IGANPGEGPEM.Medium,
					edgeDetectionMethod = (SMAA.LBPDFECBNDH)5
				};
			}

			// Token: 0x0600C003 RID: 49155 RVA: 0x00568FB4 File Offset: 0x005671B4
			public static SMAA.GlobalSettings CGGMKBADCBM()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.OKHNDFFDNFJ.Off,
					quality = (SMAA.IGANPGEGPEM)8,
					edgeDetectionMethod = (SMAA.LBPDFECBNDH)4
				};
			}

			// Token: 0x0600C004 RID: 49156 RVA: 0x00568FE4 File Offset: 0x005671E4
			public static SMAA.GlobalSettings MEFEDCEEAMK()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.OKHNDFFDNFJ.Off,
					quality = SMAA.IGANPGEGPEM.High,
					edgeDetectionMethod = (SMAA.LBPDFECBNDH)8
				};
			}

			// Token: 0x0600C005 RID: 49157 RVA: 0x00569014 File Offset: 0x00567214
			public static SMAA.GlobalSettings OOFOKHIDMDG()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.OKHNDFFDNFJ.Edges,
					quality = SMAA.IGANPGEGPEM.Medium,
					edgeDetectionMethod = (SMAA.LBPDFECBNDH)5
				};
			}

			// Token: 0x0600C006 RID: 49158 RVA: 0x00569044 File Offset: 0x00567244
			public static SMAA.GlobalSettings MDDFLLOCDEA()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.OKHNDFFDNFJ.Off,
					quality = (SMAA.IGANPGEGPEM)5,
					edgeDetectionMethod = (SMAA.LBPDFECBNDH)8
				};
			}

			// Token: 0x0600C007 RID: 49159 RVA: 0x00569074 File Offset: 0x00567274
			public static SMAA.GlobalSettings IGIKNGLDPJB()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.OKHNDFFDNFJ.Edges,
					quality = SMAA.IGANPGEGPEM.Low,
					edgeDetectionMethod = (SMAA.LBPDFECBNDH)0
				};
			}

			// Token: 0x0600C008 RID: 49160 RVA: 0x005690A4 File Offset: 0x005672A4
			public static SMAA.GlobalSettings FBBLPICJODA()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.OKHNDFFDNFJ.Edges,
					quality = (SMAA.IGANPGEGPEM)8,
					edgeDetectionMethod = (SMAA.LBPDFECBNDH)0
				};
			}

			// Token: 0x0600C009 RID: 49161 RVA: 0x005690D4 File Offset: 0x005672D4
			public static SMAA.GlobalSettings NJJBBDIFPKH()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.OKHNDFFDNFJ.Off,
					quality = (SMAA.IGANPGEGPEM)6,
					edgeDetectionMethod = (SMAA.LBPDFECBNDH)0
				};
			}

			// Token: 0x04001911 RID: 6417
			[Tooltip("Use this to fine tune your settings when working in Custom quality mode. \"Accumulation\" only works when \"Temporal Filtering\" is enabled.")]
			public SMAA.OKHNDFFDNFJ debugPass;

			// Token: 0x04001912 RID: 6418
			[Tooltip("Low: 60% of the quality.\nMedium: 80% of the quality.\nHigh: 95% of the quality.\nUltra: 99% of the quality (overkill).")]
			public SMAA.IGANPGEGPEM quality;

			// Token: 0x04001913 RID: 6419
			[Tooltip("You've three edge detection methods to choose from: luma, color or depth.\nThey represent different quality/performance and anti-aliasing/sharpness tradeoffs, so our recommendation is for you to choose the one that best suits your particular scenario:\n\n- Depth edge detection is usually the fastest but it may miss some edges.\n- Luma edge detection is usually more expensive than depth edge detection, but catches visible edges that depth edge detection can miss.\n- Color edge detection is usually the most expensive one but catches chroma-only edges.")]
			public SMAA.LBPDFECBNDH edgeDetectionMethod;
		}

		// Token: 0x02000357 RID: 855
		[Serializable]
		public struct QualitySettings
		{
			// Token: 0x04001914 RID: 6420
			[Tooltip("Enables/Disables diagonal processing.")]
			public bool diagonalDetection;

			// Token: 0x04001915 RID: 6421
			[Tooltip("Enables/Disables corner detection. Leave this on to avoid blurry corners.")]
			public bool cornerDetection;

			// Token: 0x04001916 RID: 6422
			[Range(0f, 0.5f)]
			[Tooltip("Specifies the threshold or sensitivity to edges. Lowering this value you will be able to detect more edges at the expense of performance.\n0.1 is a reasonable value, and allows to catch most visible edges. 0.05 is a rather overkill value, that allows to catch 'em all.")]
			public float threshold;

			// Token: 0x04001917 RID: 6423
			[BKALGGGLDHJ(0.0001f)]
			[Tooltip("Specifies the threshold for depth edge detection. Lowering this value you will be able to detect more edges at the expense of performance.")]
			public float depthThreshold;

			// Token: 0x04001918 RID: 6424
			[Range(0f, 112f)]
			[Tooltip("Specifies the maximum steps performed in the horizontal/vertical pattern searches, at each side of the pixel.\nIn number of pixels, it's actually the double. So the maximum line length perfectly handled by, for example 16, is 64 (by perfectly, we meant that longer lines won't look as good, but still antialiased).")]
			public int maxSearchSteps;

			// Token: 0x04001919 RID: 6425
			[Range(0f, 20f)]
			[Tooltip("Specifies the maximum steps performed in the diagonal pattern searches, at each side of the pixel. In this case we jump one pixel at time, instead of two.\nOn high-end machines it is cheap (between a 0.8x and 0.9x slower for 16 steps), but it can have a significant impact on older machines.")]
			public int maxDiagonalSearchSteps;

			// Token: 0x0400191A RID: 6426
			[Range(0f, 100f)]
			[Tooltip("Specifies how much sharp corners will be rounded.")]
			public int cornerRounding;

			// Token: 0x0400191B RID: 6427
			[BKALGGGLDHJ(0f)]
			[Tooltip("If there is an neighbor edge that has a local contrast factor times bigger contrast than current edge, current edge will be discarded.\nThis allows to eliminate spurious crossing edges, and is based on the fact that, if there is too much contrast in a direction, that will hide perceptually contrast in the other neighbors.")]
			public float localContrastAdaptationFactor;

			// Token: 0x0400191C RID: 6428
			public static SMAA.QualitySettings[] presetQualitySettings = new SMAA.QualitySettings[]
			{
				new SMAA.QualitySettings
				{
					diagonalDetection = false,
					cornerDetection = false,
					threshold = 0.15f,
					depthThreshold = 0.01f,
					maxSearchSteps = 4,
					maxDiagonalSearchSteps = 8,
					cornerRounding = 25,
					localContrastAdaptationFactor = 2f
				},
				new SMAA.QualitySettings
				{
					diagonalDetection = false,
					cornerDetection = false,
					threshold = 0.1f,
					depthThreshold = 0.01f,
					maxSearchSteps = 8,
					maxDiagonalSearchSteps = 8,
					cornerRounding = 25,
					localContrastAdaptationFactor = 2f
				},
				new SMAA.QualitySettings
				{
					diagonalDetection = true,
					cornerDetection = true,
					threshold = 0.1f,
					depthThreshold = 0.01f,
					maxSearchSteps = 16,
					maxDiagonalSearchSteps = 8,
					cornerRounding = 25,
					localContrastAdaptationFactor = 2f
				},
				new SMAA.QualitySettings
				{
					diagonalDetection = true,
					cornerDetection = true,
					threshold = 0.05f,
					depthThreshold = 0.01f,
					maxSearchSteps = 32,
					maxDiagonalSearchSteps = 16,
					cornerRounding = 25,
					localContrastAdaptationFactor = 2f
				}
			};
		}

		// Token: 0x02000358 RID: 856
		[Serializable]
		public struct TemporalSettings
		{
			// Token: 0x0600C00B RID: 49163 RVA: 0x00569294 File Offset: 0x00567494
			public static SMAA.TemporalSettings ONOHCMFHKHG()
			{
				return new SMAA.TemporalSettings
				{
					enabled = false,
					fuzzSize = 1145f
				};
			}

			// Token: 0x0600C00C RID: 49164 RVA: 0x005692BE File Offset: 0x005674BE
			public bool DGDJJNNOJBF()
			{
				return this.enabled;
			}

			// Token: 0x0600C00D RID: 49165 RVA: 0x005692BE File Offset: 0x005674BE
			public bool DEOGJODJAMN()
			{
				return this.enabled;
			}

			// Token: 0x0600C00E RID: 49166 RVA: 0x005692BE File Offset: 0x005674BE
			public bool ADPPKPBNKPE()
			{
				return this.enabled;
			}

			// Token: 0x0600C00F RID: 49167 RVA: 0x005692BE File Offset: 0x005674BE
			public bool DMFNBGKALII()
			{
				return this.enabled;
			}

			// Token: 0x0600C010 RID: 49168 RVA: 0x005692C8 File Offset: 0x005674C8
			public static SMAA.TemporalSettings JIIODGEMCMH()
			{
				return new SMAA.TemporalSettings
				{
					enabled = true,
					fuzzSize = 797f
				};
			}

			// Token: 0x0600C011 RID: 49169 RVA: 0x005692BE File Offset: 0x005674BE
			public bool JNBGAPLBABH()
			{
				return this.enabled;
			}

			// Token: 0x0600C012 RID: 49170 RVA: 0x005692BE File Offset: 0x005674BE
			public bool OIAKPMDLDEM()
			{
				return this.enabled;
			}

			// Token: 0x0600C013 RID: 49171 RVA: 0x005692BE File Offset: 0x005674BE
			public bool CDHBNHAKIHO()
			{
				return this.enabled;
			}

			// Token: 0x0600C014 RID: 49172 RVA: 0x005692F4 File Offset: 0x005674F4
			public static SMAA.TemporalSettings ILFHFFCIBPJ()
			{
				return new SMAA.TemporalSettings
				{
					enabled = true,
					fuzzSize = 753f
				};
			}

			// Token: 0x0600C015 RID: 49173 RVA: 0x00569320 File Offset: 0x00567520
			public static SMAA.TemporalSettings BFFANDBCLFI()
			{
				return new SMAA.TemporalSettings
				{
					enabled = true,
					fuzzSize = 941f
				};
			}

			// Token: 0x0600C016 RID: 49174 RVA: 0x005692BE File Offset: 0x005674BE
			public bool HNBNMFPPAPN()
			{
				return this.enabled;
			}

			// Token: 0x0600C017 RID: 49175 RVA: 0x0056934C File Offset: 0x0056754C
			public static SMAA.TemporalSettings DBGPLELNOMP()
			{
				return new SMAA.TemporalSettings
				{
					enabled = false,
					fuzzSize = 1004f
				};
			}

			// Token: 0x0600C018 RID: 49176 RVA: 0x005692BE File Offset: 0x005674BE
			public bool HJCHNEFGBCK()
			{
				return this.enabled;
			}

			// Token: 0x0600C019 RID: 49177 RVA: 0x00569378 File Offset: 0x00567578
			public static SMAA.TemporalSettings MDDFLLOCDEA()
			{
				return new SMAA.TemporalSettings
				{
					enabled = true,
					fuzzSize = 44f
				};
			}

			// Token: 0x0600C01A RID: 49178 RVA: 0x005692BE File Offset: 0x005674BE
			public bool PALDDEICCIG()
			{
				return this.enabled;
			}

			// Token: 0x0600C01B RID: 49179 RVA: 0x005692BE File Offset: 0x005674BE
			public bool JJEOLOEIJCF()
			{
				return this.enabled;
			}

			// Token: 0x0600C01C RID: 49180 RVA: 0x005692BE File Offset: 0x005674BE
			public bool BLNCDIMJODK()
			{
				return this.enabled;
			}

			// Token: 0x0600C01D RID: 49181 RVA: 0x005692BE File Offset: 0x005674BE
			public bool HCNPAKGDBDP()
			{
				return this.enabled;
			}

			// Token: 0x0600C01E RID: 49182 RVA: 0x005693A4 File Offset: 0x005675A4
			public static SMAA.TemporalSettings JJMHFAELDJK()
			{
				return new SMAA.TemporalSettings
				{
					enabled = false,
					fuzzSize = 1199f
				};
			}

			// Token: 0x0600C01F RID: 49183 RVA: 0x005693D0 File Offset: 0x005675D0
			public static SMAA.TemporalSettings NMGNPHGAGGA()
			{
				return new SMAA.TemporalSettings
				{
					enabled = true,
					fuzzSize = 1023f
				};
			}

			// Token: 0x0600C020 RID: 49184 RVA: 0x005692BE File Offset: 0x005674BE
			public bool OKDDFMDDHON()
			{
				return this.enabled;
			}

			// Token: 0x0600C021 RID: 49185 RVA: 0x005693FC File Offset: 0x005675FC
			public static SMAA.TemporalSettings KGGHGENABDN()
			{
				return new SMAA.TemporalSettings
				{
					enabled = false,
					fuzzSize = 392f
				};
			}

			// Token: 0x0600C022 RID: 49186 RVA: 0x00569428 File Offset: 0x00567628
			public static SMAA.TemporalSettings JPGMEJNEOCC()
			{
				return new SMAA.TemporalSettings
				{
					enabled = true,
					fuzzSize = 1941f
				};
			}

			// Token: 0x0600C023 RID: 49187 RVA: 0x00569454 File Offset: 0x00567654
			public static SMAA.TemporalSettings NPEIGPHIHFP()
			{
				return new SMAA.TemporalSettings
				{
					enabled = false,
					fuzzSize = 928f
				};
			}

			// Token: 0x0600C024 RID: 49188 RVA: 0x00569480 File Offset: 0x00567680
			public static SMAA.TemporalSettings COJPKDJKJAM()
			{
				return new SMAA.TemporalSettings
				{
					enabled = false,
					fuzzSize = 135f
				};
			}

			// Token: 0x0600C025 RID: 49189 RVA: 0x005694AC File Offset: 0x005676AC
			public static SMAA.TemporalSettings HIPJDBACJDH()
			{
				return new SMAA.TemporalSettings
				{
					enabled = true,
					fuzzSize = 804f
				};
			}

			// Token: 0x0600C026 RID: 49190 RVA: 0x005694D8 File Offset: 0x005676D8
			public static SMAA.TemporalSettings DHCNIDFOOPO()
			{
				return new SMAA.TemporalSettings
				{
					enabled = true,
					fuzzSize = 1165f
				};
			}

			// Token: 0x17000298 RID: 664
			// (get) Token: 0x0600C027 RID: 49191 RVA: 0x00569504 File Offset: 0x00567704
			public static SMAA.TemporalSettings defaultSettings
			{
				get
				{
					return new SMAA.TemporalSettings
					{
						enabled = false,
						fuzzSize = 2f
					};
				}
			}

			// Token: 0x0600C028 RID: 49192 RVA: 0x00569530 File Offset: 0x00567730
			public static SMAA.TemporalSettings FBBLPICJODA()
			{
				return new SMAA.TemporalSettings
				{
					enabled = true,
					fuzzSize = 1364f
				};
			}

			// Token: 0x0600C029 RID: 49193 RVA: 0x005692BE File Offset: 0x005674BE
			public bool APLLJAJPHPA()
			{
				return this.enabled;
			}

			// Token: 0x0600C02A RID: 49194 RVA: 0x005692BE File Offset: 0x005674BE
			public bool DGNKCDKNEKA()
			{
				return this.enabled;
			}

			// Token: 0x0600C02B RID: 49195 RVA: 0x005692BE File Offset: 0x005674BE
			public bool BGJKBMKGLPH()
			{
				return this.enabled;
			}

			// Token: 0x0600C02C RID: 49196 RVA: 0x0056955C File Offset: 0x0056775C
			public static SMAA.TemporalSettings CGGMKBADCBM()
			{
				return new SMAA.TemporalSettings
				{
					enabled = true,
					fuzzSize = 1885f
				};
			}

			// Token: 0x0600C02D RID: 49197 RVA: 0x005692BE File Offset: 0x005674BE
			public bool GBLBJCKONKF()
			{
				return this.enabled;
			}

			// Token: 0x0600C02E RID: 49198 RVA: 0x00569588 File Offset: 0x00567788
			public static SMAA.TemporalSettings JGNKGPFJFHO()
			{
				return new SMAA.TemporalSettings
				{
					enabled = true,
					fuzzSize = 20f
				};
			}

			// Token: 0x0600C02F RID: 49199 RVA: 0x005695B4 File Offset: 0x005677B4
			public static SMAA.TemporalSettings MEFEDCEEAMK()
			{
				return new SMAA.TemporalSettings
				{
					enabled = true,
					fuzzSize = 1287f
				};
			}

			// Token: 0x0600C030 RID: 49200 RVA: 0x005695E0 File Offset: 0x005677E0
			public static SMAA.TemporalSettings MDDBLMDKDAO()
			{
				return new SMAA.TemporalSettings
				{
					enabled = true,
					fuzzSize = 225f
				};
			}

			// Token: 0x0600C031 RID: 49201 RVA: 0x005692BE File Offset: 0x005674BE
			public bool NNKBEIDBBCA()
			{
				return this.enabled;
			}

			// Token: 0x0600C032 RID: 49202 RVA: 0x0056960C File Offset: 0x0056780C
			public static SMAA.TemporalSettings MKEJGGFNILJ()
			{
				return new SMAA.TemporalSettings
				{
					enabled = false,
					fuzzSize = 1176f
				};
			}

			// Token: 0x0600C033 RID: 49203 RVA: 0x005692BE File Offset: 0x005674BE
			public bool DLFLNMMLFLB()
			{
				return this.enabled;
			}

			// Token: 0x0600C034 RID: 49204 RVA: 0x005692BE File Offset: 0x005674BE
			public bool NKAFLGHGBMB()
			{
				return this.enabled;
			}

			// Token: 0x0600C035 RID: 49205 RVA: 0x00569638 File Offset: 0x00567838
			public static SMAA.TemporalSettings NNNMNENCOBC()
			{
				return new SMAA.TemporalSettings
				{
					enabled = false,
					fuzzSize = 95f
				};
			}

			// Token: 0x0600C036 RID: 49206 RVA: 0x00569664 File Offset: 0x00567864
			public static SMAA.TemporalSettings DCMDLNNCGAC()
			{
				return new SMAA.TemporalSettings
				{
					enabled = true,
					fuzzSize = 1585f
				};
			}

			// Token: 0x0600C037 RID: 49207 RVA: 0x005692BE File Offset: 0x005674BE
			public bool MCKDDKPIJFG()
			{
				return this.enabled;
			}

			// Token: 0x0600C038 RID: 49208 RVA: 0x00569690 File Offset: 0x00567890
			public static SMAA.TemporalSettings IGIKNGLDPJB()
			{
				return new SMAA.TemporalSettings
				{
					enabled = false,
					fuzzSize = 1898f
				};
			}

			// Token: 0x0600C039 RID: 49209 RVA: 0x005696BC File Offset: 0x005678BC
			public static SMAA.TemporalSettings GDKPNHJPBKJ()
			{
				return new SMAA.TemporalSettings
				{
					enabled = false,
					fuzzSize = 1792f
				};
			}

			// Token: 0x0600C03A RID: 49210 RVA: 0x005696E8 File Offset: 0x005678E8
			public static SMAA.TemporalSettings JACPKLDIIKG()
			{
				return new SMAA.TemporalSettings
				{
					enabled = false,
					fuzzSize = 1701f
				};
			}

			// Token: 0x0600C03B RID: 49211 RVA: 0x005692BE File Offset: 0x005674BE
			public bool OIDKPNPNPPH()
			{
				return this.enabled;
			}

			// Token: 0x0600C03C RID: 49212 RVA: 0x00569714 File Offset: 0x00567914
			public static SMAA.TemporalSettings MEBNDNNHNMB()
			{
				return new SMAA.TemporalSettings
				{
					enabled = true,
					fuzzSize = 1467f
				};
			}

			// Token: 0x0600C03D RID: 49213 RVA: 0x00569740 File Offset: 0x00567940
			public static SMAA.TemporalSettings ADJNPGFJGJI()
			{
				return new SMAA.TemporalSettings
				{
					enabled = true,
					fuzzSize = 1380f
				};
			}

			// Token: 0x0600C03E RID: 49214 RVA: 0x0056976C File Offset: 0x0056796C
			public static SMAA.TemporalSettings KIEDLNGCIJC()
			{
				return new SMAA.TemporalSettings
				{
					enabled = true,
					fuzzSize = 1511f
				};
			}

			// Token: 0x0600C03F RID: 49215 RVA: 0x00569798 File Offset: 0x00567998
			public static SMAA.TemporalSettings HMDLEIJHKEP()
			{
				return new SMAA.TemporalSettings
				{
					enabled = true,
					fuzzSize = 480f
				};
			}

			// Token: 0x0600C040 RID: 49216 RVA: 0x005697C4 File Offset: 0x005679C4
			public static SMAA.TemporalSettings GCAMLJAKCPF()
			{
				return new SMAA.TemporalSettings
				{
					enabled = false,
					fuzzSize = 582f
				};
			}

			// Token: 0x0600C041 RID: 49217 RVA: 0x005697F0 File Offset: 0x005679F0
			public static SMAA.TemporalSettings OOFOKHIDMDG()
			{
				return new SMAA.TemporalSettings
				{
					enabled = true,
					fuzzSize = 740f
				};
			}

			// Token: 0x0600C042 RID: 49218 RVA: 0x005692BE File Offset: 0x005674BE
			public bool MLIIKPEOPML()
			{
				return this.enabled;
			}

			// Token: 0x0600C043 RID: 49219 RVA: 0x005692BE File Offset: 0x005674BE
			public bool IEBFJBKKEIG()
			{
				return this.enabled;
			}

			// Token: 0x0600C044 RID: 49220 RVA: 0x005692BE File Offset: 0x005674BE
			public bool DEDDDKAPPEF()
			{
				return this.enabled;
			}

			// Token: 0x0400191D RID: 6429
			[Tooltip("Temporal filtering makes it possible for the SMAA algorithm to benefit from minute subpixel information available that has been accumulated over many frames.")]
			public bool enabled;

			// Token: 0x0400191E RID: 6430
			[Range(0.5f, 10f)]
			[Tooltip("The size of the fuzz-displacement (jitter) in pixels applied to the camera's perspective projection matrix.\nUsed for 2x temporal anti-aliasing.")]
			public float fuzzSize;
		}

		// Token: 0x02000359 RID: 857
		[Serializable]
		public struct PredicationSettings
		{
			// Token: 0x0600C045 RID: 49221 RVA: 0x0056981C File Offset: 0x00567A1C
			public static SMAA.PredicationSettings NNNMNENCOBC()
			{
				return new SMAA.PredicationSettings
				{
					enabled = true,
					threshold = 841f,
					scale = 31f,
					strength = 770f
				};
			}

			// Token: 0x0600C046 RID: 49222 RVA: 0x00569860 File Offset: 0x00567A60
			public static SMAA.PredicationSettings MDDFLLOCDEA()
			{
				return new SMAA.PredicationSettings
				{
					enabled = false,
					threshold = 479f,
					scale = 170f,
					strength = 1344f
				};
			}

			// Token: 0x0600C047 RID: 49223 RVA: 0x005698A4 File Offset: 0x00567AA4
			public static SMAA.PredicationSettings PIAJOHPDMNA()
			{
				return new SMAA.PredicationSettings
				{
					enabled = false,
					threshold = 965f,
					scale = 367f,
					strength = 153f
				};
			}

			// Token: 0x0600C048 RID: 49224 RVA: 0x005698E8 File Offset: 0x00567AE8
			public static SMAA.PredicationSettings AAPKKAPOLKH()
			{
				return new SMAA.PredicationSettings
				{
					enabled = true,
					threshold = 1257f,
					scale = 1174f,
					strength = 193f
				};
			}

			// Token: 0x0600C049 RID: 49225 RVA: 0x0056992C File Offset: 0x00567B2C
			public static SMAA.PredicationSettings COINKHKLJAP()
			{
				return new SMAA.PredicationSettings
				{
					enabled = false,
					threshold = 975f,
					scale = 123f,
					strength = 1367f
				};
			}

			// Token: 0x0600C04A RID: 49226 RVA: 0x00569970 File Offset: 0x00567B70
			public static SMAA.PredicationSettings FBBLPICJODA()
			{
				return new SMAA.PredicationSettings
				{
					enabled = true,
					threshold = 830f,
					scale = 989f,
					strength = 1702f
				};
			}

			// Token: 0x0600C04B RID: 49227 RVA: 0x005699B4 File Offset: 0x00567BB4
			public static SMAA.PredicationSettings MGIIIBAJNIE()
			{
				return new SMAA.PredicationSettings
				{
					enabled = false,
					threshold = 1373f,
					scale = 422f,
					strength = 196f
				};
			}

			// Token: 0x17000299 RID: 665
			// (get) Token: 0x0600C04C RID: 49228 RVA: 0x005699F8 File Offset: 0x00567BF8
			public static SMAA.PredicationSettings defaultSettings
			{
				get
				{
					return new SMAA.PredicationSettings
					{
						enabled = false,
						threshold = 0.01f,
						scale = 2f,
						strength = 0.4f
					};
				}
			}

			// Token: 0x0600C04D RID: 49229 RVA: 0x00569A3C File Offset: 0x00567C3C
			public static SMAA.PredicationSettings NJJBBDIFPKH()
			{
				return new SMAA.PredicationSettings
				{
					enabled = false,
					threshold = 373f,
					scale = 197f,
					strength = 534f
				};
			}

			// Token: 0x0600C04E RID: 49230 RVA: 0x00569A80 File Offset: 0x00567C80
			public static SMAA.PredicationSettings MKEJGGFNILJ()
			{
				return new SMAA.PredicationSettings
				{
					enabled = true,
					threshold = 1986f,
					scale = 64f,
					strength = 245f
				};
			}

			// Token: 0x0600C04F RID: 49231 RVA: 0x00569AC4 File Offset: 0x00567CC4
			public static SMAA.PredicationSettings NLCHLENDMLI()
			{
				return new SMAA.PredicationSettings
				{
					enabled = false,
					threshold = 198f,
					scale = 228f,
					strength = 85f
				};
			}

			// Token: 0x0600C050 RID: 49232 RVA: 0x00569B08 File Offset: 0x00567D08
			public static SMAA.PredicationSettings OOKKEMFPNBJ()
			{
				return new SMAA.PredicationSettings
				{
					enabled = true,
					threshold = 73f,
					scale = 1894f,
					strength = 174f
				};
			}

			// Token: 0x0600C051 RID: 49233 RVA: 0x00569B4C File Offset: 0x00567D4C
			public static SMAA.PredicationSettings DHCNIDFOOPO()
			{
				return new SMAA.PredicationSettings
				{
					enabled = true,
					threshold = 1881f,
					scale = 239f,
					strength = 271f
				};
			}

			// Token: 0x0600C052 RID: 49234 RVA: 0x00569B90 File Offset: 0x00567D90
			public static SMAA.PredicationSettings OOFOKHIDMDG()
			{
				return new SMAA.PredicationSettings
				{
					enabled = true,
					threshold = 627f,
					scale = 1749f,
					strength = 666f
				};
			}

			// Token: 0x0600C053 RID: 49235 RVA: 0x00569BD4 File Offset: 0x00567DD4
			public static SMAA.PredicationSettings GDKPNHJPBKJ()
			{
				return new SMAA.PredicationSettings
				{
					enabled = true,
					threshold = 1466f,
					scale = 277f,
					strength = 554f
				};
			}

			// Token: 0x0600C054 RID: 49236 RVA: 0x00569C18 File Offset: 0x00567E18
			public static SMAA.PredicationSettings HLLBKJENCLA()
			{
				return new SMAA.PredicationSettings
				{
					enabled = false,
					threshold = 889f,
					scale = 1021f,
					strength = 1235f
				};
			}

			// Token: 0x0600C055 RID: 49237 RVA: 0x00569C5C File Offset: 0x00567E5C
			public static SMAA.PredicationSettings OCIMBHLOOGC()
			{
				return new SMAA.PredicationSettings
				{
					enabled = false,
					threshold = 1177f,
					scale = 993f,
					strength = 1320f
				};
			}

			// Token: 0x0600C056 RID: 49238 RVA: 0x00569CA0 File Offset: 0x00567EA0
			public static SMAA.PredicationSettings MEFEDCEEAMK()
			{
				return new SMAA.PredicationSettings
				{
					enabled = false,
					threshold = 997f,
					scale = 362f,
					strength = 1116f
				};
			}

			// Token: 0x0600C057 RID: 49239 RVA: 0x00569CE4 File Offset: 0x00567EE4
			public static SMAA.PredicationSettings DELLGIGMFLC()
			{
				return new SMAA.PredicationSettings
				{
					enabled = false,
					threshold = 364f,
					scale = 149f,
					strength = 1119f
				};
			}

			// Token: 0x0600C058 RID: 49240 RVA: 0x00569D28 File Offset: 0x00567F28
			public static SMAA.PredicationSettings MDDBLMDKDAO()
			{
				return new SMAA.PredicationSettings
				{
					enabled = true,
					threshold = 1030f,
					scale = 1737f,
					strength = 399f
				};
			}

			// Token: 0x0600C059 RID: 49241 RVA: 0x00569D6C File Offset: 0x00567F6C
			public static SMAA.PredicationSettings HMDLEIJHKEP()
			{
				return new SMAA.PredicationSettings
				{
					enabled = true,
					threshold = 1530f,
					scale = 523f,
					strength = 1972f
				};
			}

			// Token: 0x0600C05A RID: 49242 RVA: 0x00569DB0 File Offset: 0x00567FB0
			public static SMAA.PredicationSettings MJLLLKFIDOE()
			{
				return new SMAA.PredicationSettings
				{
					enabled = true,
					threshold = 1553f,
					scale = 576f,
					strength = 10f
				};
			}

			// Token: 0x0600C05B RID: 49243 RVA: 0x00569DF4 File Offset: 0x00567FF4
			public static SMAA.PredicationSettings FMLMIDJIEOP()
			{
				return new SMAA.PredicationSettings
				{
					enabled = true,
					threshold = 570f,
					scale = 1363f,
					strength = 1513f
				};
			}

			// Token: 0x0600C05C RID: 49244 RVA: 0x00569E38 File Offset: 0x00568038
			public static SMAA.PredicationSettings MDGIIBPIGJC()
			{
				return new SMAA.PredicationSettings
				{
					enabled = true,
					threshold = 539f,
					scale = 592f,
					strength = 169f
				};
			}

			// Token: 0x0600C05D RID: 49245 RVA: 0x00569E7C File Offset: 0x0056807C
			public static SMAA.PredicationSettings IGIKNGLDPJB()
			{
				return new SMAA.PredicationSettings
				{
					enabled = true,
					threshold = 317f,
					scale = 59f,
					strength = 421f
				};
			}

			// Token: 0x0600C05E RID: 49246 RVA: 0x00569EC0 File Offset: 0x005680C0
			public static SMAA.PredicationSettings CGGMKBADCBM()
			{
				return new SMAA.PredicationSettings
				{
					enabled = false,
					threshold = 1302f,
					scale = 1242f,
					strength = 905f
				};
			}

			// Token: 0x0600C05F RID: 49247 RVA: 0x00569F04 File Offset: 0x00568104
			public static SMAA.PredicationSettings JPGMEJNEOCC()
			{
				return new SMAA.PredicationSettings
				{
					enabled = false,
					threshold = 801f,
					scale = 1651f,
					strength = 1625f
				};
			}

			// Token: 0x0400191F RID: 6431
			[Tooltip("Predicated thresholding allows to better preserve texture details and to improve performance, by decreasing the number of detected edges using an additional buffer (the detph buffer).\nIt locally decreases the luma or color threshold if an edge is found in an additional buffer (so the global threshold can be higher).")]
			public bool enabled;

			// Token: 0x04001920 RID: 6432
			[Tooltip("Threshold to be used in the additional predication buffer.")]
			[BKALGGGLDHJ(0.0001f)]
			public float threshold;

			// Token: 0x04001921 RID: 6433
			[Range(1f, 5f)]
			[Tooltip("How much to scale the global threshold used for luma or color edge detection when using predication.")]
			public float scale;

			// Token: 0x04001922 RID: 6434
			[Range(0f, 1f)]
			[Tooltip("How much to locally decrease the threshold.")]
			public float strength;
		}
	}
}
