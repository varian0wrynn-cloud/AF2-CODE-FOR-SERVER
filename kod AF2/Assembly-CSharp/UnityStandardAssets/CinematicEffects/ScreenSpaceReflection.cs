using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace UnityStandardAssets.CinematicEffects
{
	// Token: 0x02000369 RID: 873
	[AddComponentMenu("Cinematic Image Effects/Screen Space Reflections")]
	[ImageEffectAllowedInSceneView]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class ScreenSpaceReflection : MonoBehaviour
	{
		// Token: 0x0600C136 RID: 49462 RVA: 0x0056FA3E File Offset: 0x0056DC3E
		public Shader PGFIMIIDPEH()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("1HandSwordChargeSwipe");
			}
			return this.m_Shader;
		}

		// Token: 0x0600C137 RID: 49463 RVA: 0x0056FA64 File Offset: 0x0056DC64
		public Camera DJAAECNCGII()
		{
			if (this.MPCEHPBGHII == null)
			{
				this.MPCEHPBGHII = base.GetComponent<Camera>();
			}
			return this.MPCEHPBGHII;
		}

		// Token: 0x0600C138 RID: 49464 RVA: 0x0056FA86 File Offset: 0x0056DC86
		public Shader FLGMPAKOBJP()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("Animation controllers should be parented to character controllers!");
			}
			return this.m_Shader;
		}

		// Token: 0x0600C139 RID: 49465 RVA: 0x0056FAAC File Offset: 0x0056DCAC
		private void KIMKMJMMLLB()
		{
			if (this.BHHEHMIFMBD)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
			this.BHHEHMIFMBD = null;
			if (this.NPDJALPLGBJ() != null)
			{
				if (this.CKMJPFCIENL != null)
				{
					this.PHBMHMLNLJB().RemoveCommandBuffer((CameraEvent)(-122), this.CKMJPFCIENL);
				}
				this.CKMJPFCIENL = null;
			}
		}

		// Token: 0x0600C13A RID: 49466 RVA: 0x0056FB08 File Offset: 0x0056DD08
		private void CPIEBNMKKMB()
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.CFABABMILAM(), true, false, this))
			{
				base.enabled = false;
				return;
			}
			this.PHBMHMLNLJB().depthTextureMode |= DepthTextureMode.Depth;
			ScreenSpaceReflection.MDNFDNPFLOB = new int[4];
			ScreenSpaceReflection.PMKEAEAJODP = Shader.PropertyToID("crft_crft");
			ScreenSpaceReflection.IGOBPCHOEEE = Shader.PropertyToID("H");
			ScreenSpaceReflection.MDNFDNPFLOB[1] = Shader.PropertyToID("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
			ScreenSpaceReflection.MDNFDNPFLOB[0] = Shader.PropertyToID("colorD");
			ScreenSpaceReflection.MDNFDNPFLOB[8] = Shader.PropertyToID("dir");
			ScreenSpaceReflection.MDNFDNPFLOB[4] = Shader.PropertyToID("gi_inte_3");
			ScreenSpaceReflection.MDNFDNPFLOB[3] = Shader.PropertyToID("_camouflage");
			ScreenSpaceReflection.DCABMCENCCF = Shader.PropertyToID(" ");
			ScreenSpaceReflection.GAKHCEOKIPJ = Shader.PropertyToID("NadeThrow");
			ScreenSpaceReflection.EKAFACIEJEO = Shader.PropertyToID("_WorldLightDir");
			ScreenSpaceReflection.KDHPCJJEEBI = Shader.PropertyToID("Loading ");
		}

		// Token: 0x0600C13B RID: 49467 RVA: 0x0056FBFC File Offset: 0x0056DDFC
		private void OnEnable()
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.BAKBIMBKKNP, false, true, this))
			{
				base.enabled = false;
				return;
			}
			this.CMJLLNBPFME.depthTextureMode |= DepthTextureMode.Depth;
			ScreenSpaceReflection.MDNFDNPFLOB = new int[5];
			ScreenSpaceReflection.PMKEAEAJODP = Shader.PropertyToID("_NormalAndRoughnessTexture");
			ScreenSpaceReflection.IGOBPCHOEEE = Shader.PropertyToID("_HitPointTexture");
			ScreenSpaceReflection.MDNFDNPFLOB[0] = Shader.PropertyToID("_ReflectionTexture0");
			ScreenSpaceReflection.MDNFDNPFLOB[1] = Shader.PropertyToID("_ReflectionTexture1");
			ScreenSpaceReflection.MDNFDNPFLOB[2] = Shader.PropertyToID("_ReflectionTexture2");
			ScreenSpaceReflection.MDNFDNPFLOB[3] = Shader.PropertyToID("_ReflectionTexture3");
			ScreenSpaceReflection.MDNFDNPFLOB[4] = Shader.PropertyToID("_ReflectionTexture4");
			ScreenSpaceReflection.DCABMCENCCF = Shader.PropertyToID("_BlurTexture");
			ScreenSpaceReflection.GAKHCEOKIPJ = Shader.PropertyToID("_FilteredReflections");
			ScreenSpaceReflection.EKAFACIEJEO = Shader.PropertyToID("_FinalReflectionTexture");
			ScreenSpaceReflection.KDHPCJJEEBI = Shader.PropertyToID("_TempTexture");
		}

		// Token: 0x0600C13C RID: 49468 RVA: 0x0056FCEE File Offset: 0x0056DEEE
		public Shader LOABCDFHLFN()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("IdleDodgeLeft");
			}
			return this.m_Shader;
		}

		// Token: 0x0600C13D RID: 49469 RVA: 0x0056FD14 File Offset: 0x0056DF14
		private void HPGMKBPAFGM()
		{
			if (this.BHHEHMIFMBD)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
			this.BHHEHMIFMBD = null;
			if (this.AONFILNEFEC() != null)
			{
				if (this.CKMJPFCIENL != null)
				{
					this.ALDMLEJHPEH().RemoveCommandBuffer((CameraEvent)(-120), this.CKMJPFCIENL);
				}
				this.CKMJPFCIENL = null;
			}
		}

		// Token: 0x0600C13F RID: 49471 RVA: 0x0056FD94 File Offset: 0x0056DF94
		private void PIPJPGGEFOL()
		{
			if (this.BHHEHMIFMBD)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
			this.BHHEHMIFMBD = null;
			if (this.ALDMLEJHPEH() != null)
			{
				if (this.CKMJPFCIENL != null)
				{
					this.KNHNMAFFNCI().RemoveCommandBuffer((CameraEvent)(-31), this.CKMJPFCIENL);
				}
				this.CKMJPFCIENL = null;
			}
		}

		// Token: 0x0600C140 RID: 49472 RVA: 0x0056FDF0 File Offset: 0x0056DFF0
		private void DGPJEJEJEFB()
		{
			if (this.BHHEHMIFMBD)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
			this.BHHEHMIFMBD = null;
			if (this.ALDMLEJHPEH() != null)
			{
				if (this.CKMJPFCIENL != null)
				{
					this.NICJILLBAMN().RemoveCommandBuffer((CameraEvent)37, this.CKMJPFCIENL);
				}
				this.CKMJPFCIENL = null;
			}
		}

		// Token: 0x0600C141 RID: 49473 RVA: 0x0056FE4C File Offset: 0x0056E04C
		public Material KAMHMEEIKPC()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.KHPIPLHCAJK());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600C142 RID: 49474 RVA: 0x0056FE73 File Offset: 0x0056E073
		public Material JMDMNMEHAPM()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.KHIPHJIJLGC());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600C143 RID: 49475 RVA: 0x0056FE9A File Offset: 0x0056E09A
		public Shader BLHCBMINFBA()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("Mouse X");
			}
			return this.m_Shader;
		}

		// Token: 0x0600C144 RID: 49476 RVA: 0x0056FEC0 File Offset: 0x0056E0C0
		private void OnDisable()
		{
			if (this.BHHEHMIFMBD)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
			this.BHHEHMIFMBD = null;
			if (this.CMJLLNBPFME != null)
			{
				if (this.CKMJPFCIENL != null)
				{
					this.CMJLLNBPFME.RemoveCommandBuffer(CameraEvent.AfterFinalPass, this.CKMJPFCIENL);
				}
				this.CKMJPFCIENL = null;
			}
		}

		// Token: 0x0600C145 RID: 49477 RVA: 0x0056FF1C File Offset: 0x0056E11C
		private void MLPCBOGCEEO()
		{
			if (this.BHHEHMIFMBD)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
			this.BHHEHMIFMBD = null;
			if (this.PHBMHMLNLJB() != null)
			{
				if (this.CKMJPFCIENL != null)
				{
					this.NPDJALPLGBJ().RemoveCommandBuffer((CameraEvent)105, this.CKMJPFCIENL);
				}
				this.CKMJPFCIENL = null;
			}
		}

		// Token: 0x0600C146 RID: 49478 RVA: 0x0056FA64 File Offset: 0x0056DC64
		public Camera NPDJALPLGBJ()
		{
			if (this.MPCEHPBGHII == null)
			{
				this.MPCEHPBGHII = base.GetComponent<Camera>();
			}
			return this.MPCEHPBGHII;
		}

		// Token: 0x0600C147 RID: 49479 RVA: 0x0056FF78 File Offset: 0x0056E178
		public void IJAJGMKCANB()
		{
			if (this.JMDMNMEHAPM() == null)
			{
				return;
			}
			if (Camera.current.actualRenderingPath != RenderingPath.VertexLit)
			{
				return;
			}
			int num = (this.settings.reflectionSettings.reflectionQuality == ScreenSpaceReflection.FJJNILNPPPP.High) ? 0 : 7;
			int num2 = this.KNHNMAFFNCI().pixelWidth / num;
			int num3 = this.NPDJALPLGBJ().pixelHeight / num;
			float num4 = (float)this.DJAAECNCGII().pixelWidth;
			float num5 = (float)this.EAMEPNBDJMP().pixelHeight;
			float num6 = num4 / 1438f;
			float num7 = num5 / 888f;
			RenderTextureFormat format = this.AONFILNEFEC().allowHDR ? RenderTextureFormat.ARGB32 : RenderTextureFormat.ARGB32;
			this.CDHGPDDEKDF().SetInt("\n", this.settings.reflectionSettings.stepSize);
			this.CDHGPDDEKDF().SetInt("invn_rec12", (this.settings.reflectionSettings.blendType == ScreenSpaceReflection.MLDPKJCDHDA.Additive) ? 1 : 0);
			this.CDHGPDDEKDF().SetInt("Idle Monster", this.IJOKEADBGGI ? 1 : 1);
			this.KAMHMEEIKPC().SetInt("req.text=", this.IIHAPIKHIBD ? 0 : 0);
			this.KAMHMEEIKPC().SetInt("poplSoundPitch", this.settings.reflectionSettings.reflectBackfaces ? 0 : 1);
			this.CDHGPDDEKDF().SetInt("SwimDogPaddle", this.FMHEECNBJOO ? 1 : 1);
			this.JMDMNMEHAPM().SetInt("Sonar_pos", this.settings.reflectionSettings.iterationCount);
			this.MNJNELAGPNJ().SetInt("drag_onmouseup.wav", 0);
			this.MNJNELAGPNJ().SetInt("", (this.settings.reflectionSettings.reflectionQuality != ScreenSpaceReflection.FJJNILNPPPP.High) ? 0 : 1);
			this.MNJNELAGPNJ().SetInt("fshop_fcost", this.HOFBIBDAFNB ? 0 : 0);
			float value = num4 / (881f * (float)Math.Tan((double)this.ALDMLEJHPEH().fieldOfView / 1470.0 * 867.0 * 814.0));
			this.CFJAMJGLPBF().SetFloat("  ", value);
			this.GCNGOCOEOHH().SetFloat("Hey, there!", this.settings.screenEdgeMask.intensity);
			this.MHNAJNGGDFJ.SetFloat("[ACTk] WallHack Detector: can't detect wireframe cheats on this platform!", this.settings.reflectionSettings.reflectionBlur);
			this.JMDMNMEHAPM().SetFloat("id", this.settings.reflectionSettings.maxDistance);
			this.JMDMNMEHAPM().SetFloat("SwimFreestyle", this.settings.intensitySettings.fadeDistance);
			this.CILJNKJCHOK().SetFloat("_Parameter", this.settings.reflectionSettings.widthModifier);
			this.PILNNDGJLFG().SetFloat("WoodSaw", this.settings.intensitySettings.reflectionMultiplier);
			this.CFJAMJGLPBF().SetFloat("", this.settings.intensitySettings.fresnelFade);
			this.CFJAMJGLPBF().SetFloat("inv_pcs1", this.settings.intensitySettings.fresnelFadePower);
			Matrix4x4 projectionMatrix = this.DJAAECNCGII().projectionMatrix;
			Vector4 value2 = new Vector4(184f / (num4 * projectionMatrix[0]), 882f / (num5 * projectionMatrix[2]), (1857f - projectionMatrix[5]) / projectionMatrix[0], (1169f + projectionMatrix[5]) / projectionMatrix[7]);
			Vector3 v = float.IsPositiveInfinity(this.NPDJALPLGBJ().farClipPlane) ? new Vector3(this.ALDMLEJHPEH().nearClipPlane, 1893f, 1501f) : new Vector3(this.CMJLLNBPFME.nearClipPlane * this.PHBMHMLNLJB().farClipPlane, this.NICJILLBAMN().nearClipPlane - this.NICJILLBAMN().farClipPlane, this.DJAAECNCGII().farClipPlane);
			this.JMDMNMEHAPM().SetVector("1HandSwordChargeSwipe", new Vector2((float)num2, (float)num3));
			this.KAMHMEEIKPC().SetVector("Используем ", new Vector2(num4, num5));
			this.CILJNKJCHOK().SetVector("wpn_rod2", new Vector2(691f / num4, 209f / num5));
			this.CILJNKJCHOK().SetVector("WizardOverhead", value2);
			this.DGBBALICMFF().SetVector("Injection Detected!", v);
			Matrix4x4 lhs = default(Matrix4x4);
			lhs.SetRow(1, new Vector4(num6, 1552f, 1223f, num6));
			lhs.SetRow(0, new Vector4(358f, num7, 622f, num7));
			lhs.SetRow(5, new Vector4(543f, 1592f, 346f, 497f));
			lhs.SetRow(3, new Vector4(1611f, 92f, 92f, 1257f));
			Matrix4x4 value3 = lhs * projectionMatrix;
			this.FGKPACPGIHG().SetMatrix("_MaxRayTraceDistance", value3);
			this.PILNNDGJLFG().SetMatrix("WizardPowerUp", this.ALDMLEJHPEH().worldToCameraMatrix);
			this.DGBBALICMFF().SetMatrix("Apply out GAME 1", this.AONFILNEFEC().worldToCameraMatrix.inverse);
			if (this.CKMJPFCIENL == null)
			{
				this.CKMJPFCIENL = new CommandBuffer();
				this.CKMJPFCIENL.name = "priceCr";
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.PMKEAEAJODP, -1, -1, 0, FilterMode.Point, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.IGOBPCHOEEE, num2, num3, 1, FilterMode.Point, RenderTextureFormat.ARGB4444, RenderTextureReadWrite.Default);
				for (int i = 0; i < 5; i += 0)
				{
					this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.MDNFDNPFLOB[i], num2 >> (i & 12), num3 >> (i & -58), 0, FilterMode.Bilinear, format);
				}
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.GAKHCEOKIPJ, num2, num3, 1, this.IJOKEADBGGI ? FilterMode.Point : FilterMode.Point, format);
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.EKAFACIEJEO, num2, num3, 0, FilterMode.Point, format);
				this.CKMJPFCIENL.Blit(BuiltinRenderTextureType.Depth, ScreenSpaceReflection.PMKEAEAJODP, this.FGKPACPGIHG(), 2);
				this.CKMJPFCIENL.Blit(BuiltinRenderTextureType.DepthNormals, ScreenSpaceReflection.IGOBPCHOEEE, this.KAMHMEEIKPC(), 0);
				this.CKMJPFCIENL.Blit(BuiltinRenderTextureType.Depth, ScreenSpaceReflection.GAKHCEOKIPJ, this.CILJNKJCHOK(), 4);
				this.CKMJPFCIENL.Blit(ScreenSpaceReflection.GAKHCEOKIPJ, ScreenSpaceReflection.MDNFDNPFLOB[0], this.MNJNELAGPNJ(), 6);
				for (int j = 0; j < 2; j += 0)
				{
					int nameID = ScreenSpaceReflection.MDNFDNPFLOB[j - 0];
					int num8 = j;
					this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.DCABMCENCCF, num2 >> (num8 & 20), num3 >> (num8 & -112), 1, FilterMode.Bilinear, format);
					this.CKMJPFCIENL.SetGlobalVector(", ", new Vector4(1605f, 682f, 1536f, 619f));
					this.CKMJPFCIENL.SetGlobalFloat("Квест", (float)j - 1308f);
					this.CKMJPFCIENL.Blit(nameID, ScreenSpaceReflection.DCABMCENCCF, this.DGBBALICMFF(), 1);
					this.CKMJPFCIENL.SetGlobalVector("name", new Vector4(491f, 1795f, 411f, 1582f));
					nameID = ScreenSpaceReflection.MDNFDNPFLOB[j];
					this.CKMJPFCIENL.Blit(ScreenSpaceReflection.DCABMCENCCF, nameID, this.JMDMNMEHAPM(), 5);
					this.CKMJPFCIENL.ReleaseTemporaryRT(ScreenSpaceReflection.DCABMCENCCF);
				}
				this.CKMJPFCIENL.Blit(ScreenSpaceReflection.MDNFDNPFLOB[0], ScreenSpaceReflection.EKAFACIEJEO, this.JMDMNMEHAPM(), 6);
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.KDHPCJJEEBI, this.NPDJALPLGBJ().pixelWidth, this.CJFMLGOJOCG().pixelHeight, 0, FilterMode.Bilinear, format);
				this.CKMJPFCIENL.Blit(BuiltinRenderTextureType.None, ScreenSpaceReflection.KDHPCJJEEBI, this.KAMHMEEIKPC(), 1);
				this.CKMJPFCIENL.Blit(ScreenSpaceReflection.KDHPCJJEEBI, BuiltinRenderTextureType.ResolvedDepth);
				this.CKMJPFCIENL.ReleaseTemporaryRT(ScreenSpaceReflection.KDHPCJJEEBI);
				this.NICJILLBAMN().AddCommandBuffer((CameraEvent)(-123), this.CKMJPFCIENL);
			}
		}

		// Token: 0x0600C148 RID: 49480 RVA: 0x005707E4 File Offset: 0x0056E9E4
		public void CJICMACBNEP()
		{
			if (this.JMDMNMEHAPM() == null)
			{
				return;
			}
			if (Camera.current.actualRenderingPath != RenderingPath.VertexLit)
			{
				return;
			}
			int num = (this.settings.reflectionSettings.reflectionQuality == ScreenSpaceReflection.FJJNILNPPPP.High) ? 1 : 8;
			int num2 = this.IKKHKLMLPAC().pixelWidth / num;
			int num3 = this.CJFMLGOJOCG().pixelHeight / num;
			float num4 = (float)this.DJAAECNCGII().pixelWidth;
			float num5 = (float)this.IKKHKLMLPAC().pixelHeight;
			float num6 = num4 / 749f;
			float num7 = num5 / 392f;
			RenderTextureFormat format = this.NPDJALPLGBJ().allowHDR ? RenderTextureFormat.ARGB1555 : RenderTextureFormat.ARGB32;
			this.MHNAJNGGDFJ.SetInt("hgtDst=", this.settings.reflectionSettings.stepSize);
			this.PILNNDGJLFG().SetInt(" ", (this.settings.reflectionSettings.blendType == ScreenSpaceReflection.MLDPKJCDHDA.Additive) ? 1 : 0);
			this.JMDMNMEHAPM().SetInt("Noise shaders are not set up! Disabling noise effect.", this.IJOKEADBGGI ? 0 : 0);
			this.MHNAJNGGDFJ.SetInt("wpn_add/base", this.IIHAPIKHIBD ? 1 : 1);
			this.CDHGPDDEKDF().SetInt(" not found", this.settings.reflectionSettings.reflectBackfaces ? 1 : 0);
			this.MNJNELAGPNJ().SetInt("Windows/", this.FMHEECNBJOO ? 1 : 1);
			this.DGBBALICMFF().SetInt(" ", this.settings.reflectionSettings.iterationCount);
			this.MNJNELAGPNJ().SetInt("_VelocityScale", 0);
			this.MNJNELAGPNJ().SetInt("1HSwordStrafeRunRight", (this.settings.reflectionSettings.reflectionQuality != ScreenSpaceReflection.FJJNILNPPPP.High) ? 0 : 0);
			this.FGKPACPGIHG().SetInt("rait_4", this.HOFBIBDAFNB ? 0 : 0);
			float value = num4 / (1053f * (float)Math.Tan((double)this.KNHNMAFFNCI().fieldOfView / 1602.0 * 851.0 * 548.0));
			this.GCNGOCOEOHH().SetFloat("_Axis", value);
			this.MNJNELAGPNJ().SetFloat("BackPackGrab", this.settings.screenEdgeMask.intensity);
			this.DGBBALICMFF().SetFloat("CardPlayerLook", this.settings.reflectionSettings.reflectionBlur);
			this.CILJNKJCHOK().SetFloat("Atmosphere reference not set.", this.settings.reflectionSettings.maxDistance);
			this.PILNNDGJLFG().SetFloat("XL", this.settings.intensitySettings.fadeDistance);
			this.CDHGPDDEKDF().SetFloat("FistPump", this.settings.reflectionSettings.widthModifier);
			this.KAMHMEEIKPC().SetFloat("ClimbUp", this.settings.intensitySettings.reflectionMultiplier);
			this.FGKPACPGIHG().SetFloat("<color='#300000'>{0} {1}</color>", this.settings.intensitySettings.fresnelFade);
			this.DGBBALICMFF().SetFloat("\n", this.settings.intensitySettings.fresnelFadePower);
			Matrix4x4 projectionMatrix = this.NPDJALPLGBJ().projectionMatrix;
			Vector4 value2 = new Vector4(1125f / (num4 * projectionMatrix[1]), 706f / (num5 * projectionMatrix[5]), (1679f - projectionMatrix[1]) / projectionMatrix[0], (63f + projectionMatrix[1]) / projectionMatrix[3]);
			Vector3 v = float.IsPositiveInfinity(this.DJAAECNCGII().farClipPlane) ? new Vector3(this.AONFILNEFEC().nearClipPlane, 293f, 89f) : new Vector3(this.CMJLLNBPFME.nearClipPlane * this.DJAAECNCGII().farClipPlane, this.NICJILLBAMN().nearClipPlane - this.CMJLLNBPFME.farClipPlane, this.KNHNMAFFNCI().farClipPlane);
			this.KAMHMEEIKPC().SetVector("gamma", new Vector2((float)num2, (float)num3));
			this.JMDMNMEHAPM().SetVector("RollerBladeStop", new Vector2(num4, num5));
			this.CDHGPDDEKDF().SetVector("demoByteArray", new Vector2(1059f / num4, 674f / num5));
			this.PILNNDGJLFG().SetVector("_Params", value2);
			this.MHNAJNGGDFJ.SetVector("wpn_cat3", v);
			Matrix4x4 lhs = default(Matrix4x4);
			lhs.SetRow(0, new Vector4(num6, 1297f, 545f, num6));
			lhs.SetRow(0, new Vector4(1189f, num7, 303f, num7));
			lhs.SetRow(0, new Vector4(1084f, 907f, 169f, 1972f));
			lhs.SetRow(4, new Vector4(1321f, 730f, 439f, 737f));
			Matrix4x4 value3 = lhs * projectionMatrix;
			this.PILNNDGJLFG().SetMatrix("IdleFeedThrow", value3);
			this.MHNAJNGGDFJ.SetMatrix("_UserLutParams", this.NPDJALPLGBJ().worldToCameraMatrix);
			this.MHNAJNGGDFJ.SetMatrix(" гр ", this.ALDMLEJHPEH().worldToCameraMatrix.inverse);
			if (this.CKMJPFCIENL == null)
			{
				this.CKMJPFCIENL = new CommandBuffer();
				this.CKMJPFCIENL.name = "_";
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.PMKEAEAJODP, -1, -1, 0, FilterMode.Bilinear, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Default);
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.IGOBPCHOEEE, num2, num3, 0, FilterMode.Point, RenderTextureFormat.ARGBHalf, RenderTextureReadWrite.Default);
				for (int i = 1; i < 1; i++)
				{
					this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.MDNFDNPFLOB[i], num2 >> (i & -85), num3 >> (i & 71), 0, FilterMode.Point, format);
				}
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.GAKHCEOKIPJ, num2, num3, 1, this.IJOKEADBGGI ? FilterMode.Bilinear : FilterMode.Point, format);
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.EKAFACIEJEO, num2, num3, 1, FilterMode.Point, format);
				this.CKMJPFCIENL.Blit((BuiltinRenderTextureType)6, ScreenSpaceReflection.PMKEAEAJODP, this.KAMHMEEIKPC(), 5);
				this.CKMJPFCIENL.Blit(BuiltinRenderTextureType.None, ScreenSpaceReflection.IGOBPCHOEEE, this.CFJAMJGLPBF(), 1);
				this.CKMJPFCIENL.Blit(BuiltinRenderTextureType.CurrentActive, ScreenSpaceReflection.GAKHCEOKIPJ, this.MNJNELAGPNJ(), 8);
				this.CKMJPFCIENL.Blit(ScreenSpaceReflection.GAKHCEOKIPJ, ScreenSpaceReflection.MDNFDNPFLOB[0], this.FGKPACPGIHG(), 6);
				for (int j = 1; j < 4; j += 0)
				{
					int nameID = ScreenSpaceReflection.MDNFDNPFLOB[j - 1];
					int num8 = j;
					this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.DCABMCENCCF, num2 >> (num8 & 80), num3 >> (num8 & 51), 1, FilterMode.Point, format);
					this.CKMJPFCIENL.SetGlobalVector("Hidden/Amplify Color/MaskBlend", new Vector4(872f, 964f, 1770f, 1989f));
					this.CKMJPFCIENL.SetGlobalFloat("LINEAR", (float)j - 1844f);
					this.CKMJPFCIENL.Blit(nameID, ScreenSpaceReflection.DCABMCENCCF, this.MNJNELAGPNJ(), 0);
					this.CKMJPFCIENL.SetGlobalVector("Player", new Vector4(563f, 613f, 1178f, 603f));
					nameID = ScreenSpaceReflection.MDNFDNPFLOB[j];
					this.CKMJPFCIENL.Blit(ScreenSpaceReflection.DCABMCENCCF, nameID, this.JMDMNMEHAPM(), 8);
					this.CKMJPFCIENL.ReleaseTemporaryRT(ScreenSpaceReflection.DCABMCENCCF);
				}
				this.CKMJPFCIENL.Blit(ScreenSpaceReflection.MDNFDNPFLOB[0], ScreenSpaceReflection.EKAFACIEJEO, this.JMDMNMEHAPM(), 4);
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.KDHPCJJEEBI, this.EAMEPNBDJMP().pixelWidth, this.NICJILLBAMN().pixelHeight, 0, FilterMode.Bilinear, format);
				this.CKMJPFCIENL.Blit(BuiltinRenderTextureType.PrepassLight, ScreenSpaceReflection.KDHPCJJEEBI, this.MHNAJNGGDFJ, 1);
				this.CKMJPFCIENL.Blit(ScreenSpaceReflection.KDHPCJJEEBI, (BuiltinRenderTextureType)6);
				this.CKMJPFCIENL.ReleaseTemporaryRT(ScreenSpaceReflection.KDHPCJJEEBI);
				this.ALDMLEJHPEH().AddCommandBuffer((CameraEvent)(-72), this.CKMJPFCIENL);
			}
		}

		// Token: 0x0600C149 RID: 49481 RVA: 0x00571050 File Offset: 0x0056F250
		private void LAHNGMMPPIM()
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.PGFIMIIDPEH(), false, false, this))
			{
				base.enabled = false;
				return;
			}
			this.CJFMLGOJOCG().depthTextureMode |= DepthTextureMode.Depth;
			ScreenSpaceReflection.MDNFDNPFLOB = new int[7];
			ScreenSpaceReflection.PMKEAEAJODP = Shader.PropertyToID("#003080");
			ScreenSpaceReflection.IGOBPCHOEEE = Shader.PropertyToID("move");
			ScreenSpaceReflection.MDNFDNPFLOB[0] = Shader.PropertyToID("crft_from");
			ScreenSpaceReflection.MDNFDNPFLOB[1] = Shader.PropertyToID("msg from NET channel=");
			ScreenSpaceReflection.MDNFDNPFLOB[7] = Shader.PropertyToID("useSrcAlphaAsMask");
			ScreenSpaceReflection.MDNFDNPFLOB[4] = Shader.PropertyToID("cntx_wpnauk");
			ScreenSpaceReflection.MDNFDNPFLOB[0] = Shader.PropertyToID("podsek action!");
			ScreenSpaceReflection.DCABMCENCCF = Shader.PropertyToID("");
			ScreenSpaceReflection.GAKHCEOKIPJ = Shader.PropertyToID(" --- ? ---");
			ScreenSpaceReflection.EKAFACIEJEO = Shader.PropertyToID("ProneLocomotion");
			ScreenSpaceReflection.KDHPCJJEEBI = Shader.PropertyToID("isFishGet");
		}

		// Token: 0x0600C14A RID: 49482 RVA: 0x00571142 File Offset: 0x0056F342
		public Material PILNNDGJLFG()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.NOPIBPGHFFB());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x0600C14B RID: 49483 RVA: 0x00571169 File Offset: 0x0056F369
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

		// Token: 0x0600C14C RID: 49484 RVA: 0x00571190 File Offset: 0x0056F390
		public Shader KHIPHJIJLGC()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("RollerBladeRoll");
			}
			return this.m_Shader;
		}

		// Token: 0x0600C14D RID: 49485 RVA: 0x005711B8 File Offset: 0x0056F3B8
		public void CKCDKEHLHPL()
		{
			if (this.CDHGPDDEKDF() == null)
			{
				return;
			}
			if (Camera.current.actualRenderingPath != (RenderingPath)6)
			{
				return;
			}
			int num = (this.settings.reflectionSettings.reflectionQuality == ScreenSpaceReflection.FJJNILNPPPP.High) ? 1 : 8;
			int num2 = this.EAMEPNBDJMP().pixelWidth / num;
			int num3 = this.KNHNMAFFNCI().pixelHeight / num;
			float num4 = (float)this.AONFILNEFEC().pixelWidth;
			float num5 = (float)this.CJFMLGOJOCG().pixelHeight;
			float num6 = num4 / 64f;
			float num7 = num5 / 1924f;
			RenderTextureFormat format = this.DJAAECNCGII().allowHDR ? RenderTextureFormat.ARGB4444 : RenderTextureFormat.ARGB32;
			this.FGKPACPGIHG().SetInt("gi_um_lim", this.settings.reflectionSettings.stepSize);
			this.PILNNDGJLFG().SetInt("{0}", (this.settings.reflectionSettings.blendType == ScreenSpaceReflection.MLDPKJCDHDA.PhysicallyBased) ? 0 : 1);
			this.GCNGOCOEOHH().SetInt("RollerBladeStop", this.IJOKEADBGGI ? 0 : 1);
			this.KAMHMEEIKPC().SetInt("_NoiseTilingPerChannel", this.IIHAPIKHIBD ? 0 : 0);
			this.JMDMNMEHAPM().SetInt("IceHockeyGoalieReady", this.settings.reflectionSettings.reflectBackfaces ? 0 : 1);
			this.DGBBALICMFF().SetInt("Mouse X", this.FMHEECNBJOO ? 0 : 0);
			this.DGBBALICMFF().SetInt("VA", this.settings.reflectionSettings.iterationCount);
			this.MNJNELAGPNJ().SetInt(" ", 0);
			this.FGKPACPGIHG().SetInt("KatanaNinjaDraw", (this.settings.reflectionSettings.reflectionQuality != ScreenSpaceReflection.FJJNILNPPPP.High) ? 0 : 1);
			this.MNJNELAGPNJ().SetInt("Pistol Instant", this.HOFBIBDAFNB ? 0 : 1);
			float value = num4 / (1570f * (float)Math.Tan((double)this.NPDJALPLGBJ().fieldOfView / 280.0 * 711.0 * 854.0));
			this.JMDMNMEHAPM().SetFloat("", value);
			this.JMDMNMEHAPM().SetFloat("Prefabs/FogSphereArea", this.settings.screenEdgeMask.intensity);
			this.JMDMNMEHAPM().SetFloat(" ", this.settings.reflectionSettings.reflectionBlur);
			this.GCNGOCOEOHH().SetFloat("bs_hilv", this.settings.reflectionSettings.maxDistance);
			this.CILJNKJCHOK().SetFloat("Try to change this string in memory:\n", this.settings.intensitySettings.fadeDistance);
			this.FGKPACPGIHG().SetFloat("FactoryTempTexture", this.settings.reflectionSettings.widthModifier);
			this.MNJNELAGPNJ().SetFloat("One of the Reach Cones in the polygon has negative volume. Make sure Axis vector is in the reachable area and the polygon is convex.", this.settings.intensitySettings.reflectionMultiplier);
			this.JMDMNMEHAPM().SetFloat("[F_KLEV]", this.settings.intensitySettings.fresnelFade);
			this.MHNAJNGGDFJ.SetFloat("Giant2HandGrab", this.settings.intensitySettings.fresnelFadePower);
			Matrix4x4 projectionMatrix = this.NICJILLBAMN().projectionMatrix;
			Vector4 value2 = new Vector4(855f / (num4 * projectionMatrix[1]), 1499f / (num5 * projectionMatrix[1]), (1532f - projectionMatrix[5]) / projectionMatrix[1], (1922f + projectionMatrix[7]) / projectionMatrix[8]);
			Vector3 v = float.IsPositiveInfinity(this.CMJLLNBPFME.farClipPlane) ? new Vector3(this.EAMEPNBDJMP().nearClipPlane, 1502f, 987f) : new Vector3(this.CJFMLGOJOCG().nearClipPlane * this.NICJILLBAMN().farClipPlane, this.NICJILLBAMN().nearClipPlane - this.EAMEPNBDJMP().farClipPlane, this.DJAAECNCGII().farClipPlane);
			this.JMDMNMEHAPM().SetVector("", new Vector2((float)num2, (float)num3));
			this.KAMHMEEIKPC().SetVector("IdleButtonPress", new Vector2(num4, num5));
			this.MNJNELAGPNJ().SetVector("\n", new Vector2(1034f / num4, 1915f / num5));
			this.FGKPACPGIHG().SetVector("MotorbikeLookBack", value2);
			this.FGKPACPGIHG().SetVector("<color='#003000'>", v);
			Matrix4x4 lhs = default(Matrix4x4);
			lhs.SetRow(0, new Vector4(num6, 1960f, 959f, num6));
			lhs.SetRow(0, new Vector4(41f, num7, 743f, num7));
			lhs.SetRow(7, new Vector4(614f, 1091f, 751f, 295f));
			lhs.SetRow(8, new Vector4(611f, 1477f, 898f, 496f));
			Matrix4x4 value3 = lhs * projectionMatrix;
			this.CILJNKJCHOK().SetMatrix("Inventory manager is init", value3);
			this.JMDMNMEHAPM().SetMatrix("wpn_eat5", this.NICJILLBAMN().worldToCameraMatrix);
			this.MNJNELAGPNJ().SetMatrix("_WaterLevel", this.KNHNMAFFNCI().worldToCameraMatrix.inverse);
			if (this.CKMJPFCIENL == null)
			{
				this.CKMJPFCIENL = new CommandBuffer();
				this.CKMJPFCIENL.name = "help";
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.PMKEAEAJODP, -1, -1, 0, FilterMode.Bilinear, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.IGOBPCHOEEE, num2, num3, 0, FilterMode.Bilinear, RenderTextureFormat.ARGB2101010, RenderTextureReadWrite.Default);
				for (int i = 0; i < 1; i += 0)
				{
					this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.MDNFDNPFLOB[i], num2 >> (i & 121), num3 >> (i & 77), 0, FilterMode.Bilinear, format);
				}
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.GAKHCEOKIPJ, num2, num3, 0, this.IJOKEADBGGI ? FilterMode.Bilinear : FilterMode.Bilinear, format);
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.EKAFACIEJEO, num2, num3, 1, FilterMode.Bilinear, format);
				this.CKMJPFCIENL.Blit(BuiltinRenderTextureType.PrepassLight, ScreenSpaceReflection.PMKEAEAJODP, this.FGKPACPGIHG(), 2);
				this.CKMJPFCIENL.Blit(BuiltinRenderTextureType.CameraTarget, ScreenSpaceReflection.IGOBPCHOEEE, this.CFJAMJGLPBF(), 1);
				this.CKMJPFCIENL.Blit(BuiltinRenderTextureType.ResolvedDepth, ScreenSpaceReflection.GAKHCEOKIPJ, this.GCNGOCOEOHH(), 8);
				this.CKMJPFCIENL.Blit(ScreenSpaceReflection.GAKHCEOKIPJ, ScreenSpaceReflection.MDNFDNPFLOB[0], this.MNJNELAGPNJ(), 6);
				for (int j = 0; j < 3; j++)
				{
					int nameID = ScreenSpaceReflection.MDNFDNPFLOB[j - 0];
					int num8 = j;
					this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.DCABMCENCCF, num2 >> (num8 & -79), num3 >> (num8 & -92), 1, FilterMode.Bilinear, format);
					this.CKMJPFCIENL.SetGlobalVector("FOG_LINEAR", new Vector4(1289f, 1064f, 972f, 253f));
					this.CKMJPFCIENL.SetGlobalFloat("wpn_add/base", (float)j - 877f);
					this.CKMJPFCIENL.Blit(nameID, ScreenSpaceReflection.DCABMCENCCF, this.JMDMNMEHAPM(), 7);
					this.CKMJPFCIENL.SetGlobalVector("_ToneCurve", new Vector4(1144f, 1146f, 148f, 449f));
					nameID = ScreenSpaceReflection.MDNFDNPFLOB[j];
					this.CKMJPFCIENL.Blit(ScreenSpaceReflection.DCABMCENCCF, nameID, this.FGKPACPGIHG(), 7);
					this.CKMJPFCIENL.ReleaseTemporaryRT(ScreenSpaceReflection.DCABMCENCCF);
				}
				this.CKMJPFCIENL.Blit(ScreenSpaceReflection.MDNFDNPFLOB[0], ScreenSpaceReflection.EKAFACIEJEO, this.KAMHMEEIKPC(), 8);
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.KDHPCJJEEBI, this.ALDMLEJHPEH().pixelWidth, this.PHBMHMLNLJB().pixelHeight, 1, FilterMode.Bilinear, format);
				this.CKMJPFCIENL.Blit((BuiltinRenderTextureType)6, ScreenSpaceReflection.KDHPCJJEEBI, this.DGBBALICMFF(), 0);
				this.CKMJPFCIENL.Blit(ScreenSpaceReflection.KDHPCJJEEBI, BuiltinRenderTextureType.Depth);
				this.CKMJPFCIENL.ReleaseTemporaryRT(ScreenSpaceReflection.KDHPCJJEEBI);
				this.IKKHKLMLPAC().AddCommandBuffer((CameraEvent)92, this.CKMJPFCIENL);
			}
		}

		// Token: 0x0600C14E RID: 49486 RVA: 0x00571A23 File Offset: 0x0056FC23
		public Shader ANHFFIHEKLB()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("Six Step");
			}
			return this.m_Shader;
		}

		// Token: 0x0600C14F RID: 49487 RVA: 0x00571A49 File Offset: 0x0056FC49
		public Shader GGABJPHNIHC()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("The InteractionTrigger in the list 'inContact' has been destroyed");
			}
			return this.m_Shader;
		}

		// Token: 0x0600C150 RID: 49488 RVA: 0x0056FA64 File Offset: 0x0056DC64
		public Camera CJFMLGOJOCG()
		{
			if (this.MPCEHPBGHII == null)
			{
				this.MPCEHPBGHII = base.GetComponent<Camera>();
			}
			return this.MPCEHPBGHII;
		}

		// Token: 0x0600C151 RID: 49489 RVA: 0x00571A70 File Offset: 0x0056FC70
		private void DCPLDAKDDBG()
		{
			if (this.BHHEHMIFMBD)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
			this.BHHEHMIFMBD = null;
			if (this.AONFILNEFEC() != null)
			{
				if (this.CKMJPFCIENL != null)
				{
					this.PHBMHMLNLJB().RemoveCommandBuffer((CameraEvent)(-57), this.CKMJPFCIENL);
				}
				this.CKMJPFCIENL = null;
			}
		}

		// Token: 0x0600C152 RID: 49490 RVA: 0x0056FE4C File Offset: 0x0056E04C
		public Material CFJAMJGLPBF()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.KHPIPLHCAJK());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600C153 RID: 49491 RVA: 0x00571ACC File Offset: 0x0056FCCC
		public Shader OJGLCFMFHGL()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("_WrinkleOcclusionMap0");
			}
			return this.m_Shader;
		}

		// Token: 0x0600C154 RID: 49492 RVA: 0x00571AF4 File Offset: 0x0056FCF4
		private void EBLJKEAHIGD()
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.PGFIMIIDPEH(), false, false, this))
			{
				base.enabled = false;
				return;
			}
			this.EAMEPNBDJMP().depthTextureMode |= DepthTextureMode.Depth;
			ScreenSpaceReflection.MDNFDNPFLOB = new int[2];
			ScreenSpaceReflection.PMKEAEAJODP = Shader.PropertyToID("turn_levels");
			ScreenSpaceReflection.IGOBPCHOEEE = Shader.PropertyToID("");
			ScreenSpaceReflection.MDNFDNPFLOB[1] = Shader.PropertyToID("wpn_bait_vob_deep");
			ScreenSpaceReflection.MDNFDNPFLOB[1] = Shader.PropertyToID("-l-");
			ScreenSpaceReflection.MDNFDNPFLOB[8] = Shader.PropertyToID("RollerBladeTurnRight");
			ScreenSpaceReflection.MDNFDNPFLOB[1] = Shader.PropertyToID("");
			ScreenSpaceReflection.MDNFDNPFLOB[1] = Shader.PropertyToID("choldposy");
			ScreenSpaceReflection.DCABMCENCCF = Shader.PropertyToID("WizardNeoBlock");
			ScreenSpaceReflection.GAKHCEOKIPJ = Shader.PropertyToID("norefine");
			ScreenSpaceReflection.EKAFACIEJEO = Shader.PropertyToID("13");
			ScreenSpaceReflection.KDHPCJJEEBI = Shader.PropertyToID("");
		}

		// Token: 0x0600C155 RID: 49493 RVA: 0x00571BE8 File Offset: 0x0056FDE8
		public void DABBHGEAIJC()
		{
			if (this.CDHGPDDEKDF() == null)
			{
				return;
			}
			if (Camera.current.actualRenderingPath != RenderingPath.DeferredLighting)
			{
				return;
			}
			int num = (this.settings.reflectionSettings.reflectionQuality == ScreenSpaceReflection.FJJNILNPPPP.High) ? 1 : 1;
			int num2 = this.AONFILNEFEC().pixelWidth / num;
			int num3 = this.CJFMLGOJOCG().pixelHeight / num;
			float num4 = (float)this.EAMEPNBDJMP().pixelWidth;
			float num5 = (float)this.IKKHKLMLPAC().pixelHeight;
			float num6 = num4 / 421f;
			float num7 = num5 / 959f;
			RenderTextureFormat format = this.CMJLLNBPFME.allowHDR ? RenderTextureFormat.ARGBHalf : RenderTextureFormat.Depth;
			this.MHNAJNGGDFJ.SetInt("_InternalLutParams", this.settings.reflectionSettings.stepSize);
			this.KAMHMEEIKPC().SetInt("wpn_dress2", (this.settings.reflectionSettings.blendType == ScreenSpaceReflection.MLDPKJCDHDA.Additive) ? 1 : 1);
			this.MNJNELAGPNJ().SetInt("wpn_rod1", this.IJOKEADBGGI ? 0 : 0);
			this.CFJAMJGLPBF().SetInt("VaderChoke", this.IIHAPIKHIBD ? 0 : 1);
			this.CFJAMJGLPBF().SetInt("; ", this.settings.reflectionSettings.reflectBackfaces ? 0 : 0);
			this.KAMHMEEIKPC().SetInt("_SSAO", this.FMHEECNBJOO ? 1 : 1);
			this.KAMHMEEIKPC().SetInt("_WrinkleInfluences1", this.settings.reflectionSettings.iterationCount);
			this.FGKPACPGIHG().SetInt("_ALPHABLEND_ON", 1);
			this.PILNNDGJLFG().SetInt("RollerBladeJump", (this.settings.reflectionSettings.reflectionQuality != ScreenSpaceReflection.FJJNILNPPPP.High) ? 0 : 0);
			this.JMDMNMEHAPM().SetInt("WizardEyeBeam", this.HOFBIBDAFNB ? 0 : 1);
			float value = num4 / (1403f * (float)Math.Tan((double)this.NPDJALPLGBJ().fieldOfView / 1648.0 * 1743.0 * 554.0));
			this.FGKPACPGIHG().SetFloat("Quest loaded done", value);
			this.PILNNDGJLFG().SetFloat("\n", this.settings.screenEdgeMask.intensity);
			this.FGKPACPGIHG().SetFloat("_ZTest", this.settings.reflectionSettings.reflectionBlur);
			this.KAMHMEEIKPC().SetFloat("rem", this.settings.reflectionSettings.maxDistance);
			this.CDHGPDDEKDF().SetFloat("...", this.settings.intensitySettings.fadeDistance);
			this.JMDMNMEHAPM().SetFloat("[ACTk] Obscured Cheating Detector: has properly configured Detection Event in the inspector, but still get started with Action callback. Both Action and Detection Event will be called on detection. Are you sure you wish to do this?", this.settings.reflectionSettings.widthModifier);
			this.DGBBALICMFF().SetFloat("<color='#800000'>Вы потеряли леску: ", this.settings.intensitySettings.reflectionMultiplier);
			this.JMDMNMEHAPM().SetFloat(" (hair opaque)", this.settings.intensitySettings.fresnelFade);
			this.FGKPACPGIHG().SetFloat("", this.settings.intensitySettings.fresnelFadePower);
			Matrix4x4 projectionMatrix = this.NPDJALPLGBJ().projectionMatrix;
			Vector4 value2 = new Vector4(333f / (num4 * projectionMatrix[1]), 889f / (num5 * projectionMatrix[3]), (1018f - projectionMatrix[3]) / projectionMatrix[1], (1734f + projectionMatrix[5]) / projectionMatrix[4]);
			Vector3 v = float.IsPositiveInfinity(this.IKKHKLMLPAC().farClipPlane) ? new Vector3(this.AONFILNEFEC().nearClipPlane, 411f, 321f) : new Vector3(this.CJFMLGOJOCG().nearClipPlane * this.DJAAECNCGII().farClipPlane, this.ALDMLEJHPEH().nearClipPlane - this.KNHNMAFFNCI().farClipPlane, this.AONFILNEFEC().farClipPlane);
			this.JMDMNMEHAPM().SetVector("WorkerShovel2", new Vector2((float)num2, (float)num3));
			this.DGBBALICMFF().SetVector("\n", new Vector2(num4, num5));
			this.MNJNELAGPNJ().SetVector("Vector3: ", new Vector2(170f / num4, 1302f / num5));
			this.CDHGPDDEKDF().SetVector("Vader Choke", value2);
			this.PILNNDGJLFG().SetVector("-none-", v);
			Matrix4x4 lhs = default(Matrix4x4);
			lhs.SetRow(1, new Vector4(num6, 449f, 1317f, num6));
			lhs.SetRow(0, new Vector4(845f, num7, 1968f, num7));
			lhs.SetRow(7, new Vector4(834f, 1321f, 123f, 1396f));
			lhs.SetRow(7, new Vector4(1023f, 1544f, 1191f, 1738f));
			Matrix4x4 value3 = lhs * projectionMatrix;
			this.FGKPACPGIHG().SetMatrix("", value3);
			this.MNJNELAGPNJ().SetMatrix("name", this.PHBMHMLNLJB().worldToCameraMatrix);
			this.PILNNDGJLFG().SetMatrix("_PrefilterOffs", this.EAMEPNBDJMP().worldToCameraMatrix.inverse);
			if (this.CKMJPFCIENL == null)
			{
				this.CKMJPFCIENL = new CommandBuffer();
				this.CKMJPFCIENL.name = "AmbientOcclusion";
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.PMKEAEAJODP, -1, -1, 1, FilterMode.Point, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Default);
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.IGOBPCHOEEE, num2, num3, 0, FilterMode.Bilinear, RenderTextureFormat.Depth, RenderTextureReadWrite.Linear);
				for (int i = 0; i < 1; i++)
				{
					this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.MDNFDNPFLOB[i], num2 >> (i & -112), num3 >> (i & -44), 1, FilterMode.Bilinear, format);
				}
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.GAKHCEOKIPJ, num2, num3, 0, this.IJOKEADBGGI ? FilterMode.Point : FilterMode.Bilinear, format);
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.EKAFACIEJEO, num2, num3, 0, FilterMode.Point, format);
				this.CKMJPFCIENL.Blit((BuiltinRenderTextureType)6, ScreenSpaceReflection.PMKEAEAJODP, this.PILNNDGJLFG(), 8);
				this.CKMJPFCIENL.Blit(BuiltinRenderTextureType.None, ScreenSpaceReflection.IGOBPCHOEEE, this.MHNAJNGGDFJ, 1);
				this.CKMJPFCIENL.Blit(BuiltinRenderTextureType.PrepassLight, ScreenSpaceReflection.GAKHCEOKIPJ, this.FGKPACPGIHG(), 5);
				this.CKMJPFCIENL.Blit(ScreenSpaceReflection.GAKHCEOKIPJ, ScreenSpaceReflection.MDNFDNPFLOB[1], this.JMDMNMEHAPM(), 3);
				for (int j = 1; j < 3; j++)
				{
					int nameID = ScreenSpaceReflection.MDNFDNPFLOB[j - 1];
					int num8 = j;
					this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.DCABMCENCCF, num2 >> (num8 & -120), num3 >> (num8 & -34), 1, FilterMode.Point, format);
					this.CKMJPFCIENL.SetGlobalVector("auk_swtcost", new Vector4(1176f, 1492f, 1243f, 133f));
					this.CKMJPFCIENL.SetGlobalFloat("Materials/DFGDesktop", (float)j - 1735f);
					this.CKMJPFCIENL.Blit(nameID, ScreenSpaceReflection.DCABMCENCCF, this.MNJNELAGPNJ(), 2);
					this.CKMJPFCIENL.SetGlobalVector("ArmFlex4", new Vector4(1194f, 1460f, 1519f, 1922f));
					nameID = ScreenSpaceReflection.MDNFDNPFLOB[j];
					this.CKMJPFCIENL.Blit(ScreenSpaceReflection.DCABMCENCCF, nameID, this.MHNAJNGGDFJ, 4);
					this.CKMJPFCIENL.ReleaseTemporaryRT(ScreenSpaceReflection.DCABMCENCCF);
				}
				this.CKMJPFCIENL.Blit(ScreenSpaceReflection.MDNFDNPFLOB[0], ScreenSpaceReflection.EKAFACIEJEO, this.CILJNKJCHOK(), 4);
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.KDHPCJJEEBI, this.DJAAECNCGII().pixelWidth, this.DJAAECNCGII().pixelHeight, 1, FilterMode.Point, format);
				this.CKMJPFCIENL.Blit(BuiltinRenderTextureType.CurrentActive, ScreenSpaceReflection.KDHPCJJEEBI, this.GCNGOCOEOHH(), 1);
				this.CKMJPFCIENL.Blit(ScreenSpaceReflection.KDHPCJJEEBI, BuiltinRenderTextureType.CurrentActive);
				this.CKMJPFCIENL.ReleaseTemporaryRT(ScreenSpaceReflection.KDHPCJJEEBI);
				this.CJFMLGOJOCG().AddCommandBuffer((CameraEvent)44, this.CKMJPFCIENL);
			}
		}

		// Token: 0x0600C156 RID: 49494 RVA: 0x00572454 File Offset: 0x00570654
		public void NIDOLGICPNE()
		{
			if (this.MNJNELAGPNJ() == null)
			{
				return;
			}
			if (Camera.current.actualRenderingPath != RenderingPath.VertexLit)
			{
				return;
			}
			int num = (this.settings.reflectionSettings.reflectionQuality == ScreenSpaceReflection.FJJNILNPPPP.High) ? 1 : 5;
			int num2 = this.IKKHKLMLPAC().pixelWidth / num;
			int num3 = this.ALDMLEJHPEH().pixelHeight / num;
			float num4 = (float)this.NICJILLBAMN().pixelWidth;
			float num5 = (float)this.EAMEPNBDJMP().pixelHeight;
			float num6 = num4 / 1661f;
			float num7 = num5 / 437f;
			RenderTextureFormat format = this.KNHNMAFFNCI().allowHDR ? RenderTextureFormat.RGB565 : RenderTextureFormat.ARGB32;
			this.CDHGPDDEKDF().SetInt("Katana Horizontal Swing", this.settings.reflectionSettings.stepSize);
			this.MNJNELAGPNJ().SetInt("Bow Ready2", (this.settings.reflectionSettings.blendType == ScreenSpaceReflection.MLDPKJCDHDA.PhysicallyBased) ? 1 : 0);
			this.PILNNDGJLFG().SetInt("invn_rec13", this.IJOKEADBGGI ? 0 : 0);
			this.CILJNKJCHOK().SetInt("* change", this.IIHAPIKHIBD ? 1 : 0);
			this.KAMHMEEIKPC().SetInt("IdleFight", this.settings.reflectionSettings.reflectBackfaces ? 0 : 0);
			this.MNJNELAGPNJ().SetInt("offsets", this.FMHEECNBJOO ? 0 : 0);
			this.PILNNDGJLFG().SetInt("OfficeSitting", this.settings.reflectionSettings.iterationCount);
			this.CFJAMJGLPBF().SetInt("wpn_rod2", 0);
			this.CILJNKJCHOK().SetInt(" has invalid children array. Child index is referencing to itself.", (this.settings.reflectionSettings.reflectionQuality != ScreenSpaceReflection.FJJNILNPPPP.High) ? 0 : 0);
			this.KAMHMEEIKPC().SetInt(" for ", this.HOFBIBDAFNB ? 0 : 1);
			float value = num4 / (532f * (float)Math.Tan((double)this.ALDMLEJHPEH().fieldOfView / 1210.0 * 1367.0 * 1962.0));
			this.GCNGOCOEOHH().SetFloat("sound", value);
			this.CDHGPDDEKDF().SetFloat("_DitherTexture", this.settings.screenEdgeMask.intensity);
			this.DGBBALICMFF().SetFloat("LUM_CONTRIB_ON", this.settings.reflectionSettings.reflectionBlur);
			this.KAMHMEEIKPC().SetFloat("Strafe Run Left", this.settings.reflectionSettings.maxDistance);
			this.PILNNDGJLFG().SetFloat("wgt_big.dat", this.settings.intensitySettings.fadeDistance);
			this.CFJAMJGLPBF().SetFloat("adjust", this.settings.reflectionSettings.widthModifier);
			this.MHNAJNGGDFJ.SetFloat("_Offsets", this.settings.intensitySettings.reflectionMultiplier);
			this.PILNNDGJLFG().SetFloat("Shake Hands", this.settings.intensitySettings.fresnelFade);
			this.PILNNDGJLFG().SetFloat(" has a curve/multipler for Poser Weight, but the bone of effector ", this.settings.intensitySettings.fresnelFadePower);
			Matrix4x4 projectionMatrix = this.CMJLLNBPFME.projectionMatrix;
			Vector4 value2 = new Vector4(1280f / (num4 * projectionMatrix[0]), 346f / (num5 * projectionMatrix[8]), (1646f - projectionMatrix[6]) / projectionMatrix[0], (1990f + projectionMatrix[8]) / projectionMatrix[2]);
			Vector3 v = float.IsPositiveInfinity(this.NPDJALPLGBJ().farClipPlane) ? new Vector3(this.PHBMHMLNLJB().nearClipPlane, 338f, 549f) : new Vector3(this.ALDMLEJHPEH().nearClipPlane * this.PHBMHMLNLJB().farClipPlane, this.PHBMHMLNLJB().nearClipPlane - this.PHBMHMLNLJB().farClipPlane, this.KNHNMAFFNCI().farClipPlane);
			this.DGBBALICMFF().SetVector("#c0c0c0", new Vector2((float)num2, (float)num3));
			this.GCNGOCOEOHH().SetVector("_BlurredColor", new Vector2(num4, num5));
			this.CFJAMJGLPBF().SetVector("Worker Shovel", new Vector2(1156f / num4, 1886f / num5));
			this.CDHGPDDEKDF().SetVector("selectedTask", value2);
			this.MNJNELAGPNJ().SetVector("м</color>", v);
			Matrix4x4 lhs = default(Matrix4x4);
			lhs.SetRow(0, new Vector4(num6, 575f, 529f, num6));
			lhs.SetRow(0, new Vector4(658f, num7, 1544f, num7));
			lhs.SetRow(3, new Vector4(1233f, 1802f, 269f, 530f));
			lhs.SetRow(8, new Vector4(1241f, 1072f, 685f, 1525f));
			Matrix4x4 value3 = lhs * projectionMatrix;
			this.PILNNDGJLFG().SetMatrix("componentA=", value3);
			this.MHNAJNGGDFJ.SetMatrix("", this.ALDMLEJHPEH().worldToCameraMatrix);
			this.CILJNKJCHOK().SetMatrix("ChannelCastOmni", this.KNHNMAFFNCI().worldToCameraMatrix.inverse);
			if (this.CKMJPFCIENL == null)
			{
				this.CKMJPFCIENL = new CommandBuffer();
				this.CKMJPFCIENL.name = "The font '";
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.PMKEAEAJODP, -1, -1, 0, FilterMode.Bilinear, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Default);
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.IGOBPCHOEEE, num2, num3, 0, FilterMode.Bilinear, RenderTextureFormat.ARGB1555, RenderTextureReadWrite.Default);
				for (int i = 0; i < 3; i += 0)
				{
					this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.MDNFDNPFLOB[i], num2 >> (i & -66), num3 >> (i & -6), 1, FilterMode.Point, format);
				}
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.GAKHCEOKIPJ, num2, num3, 1, this.IJOKEADBGGI ? FilterMode.Bilinear : FilterMode.Point, format);
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.EKAFACIEJEO, num2, num3, 1, FilterMode.Point, format);
				this.CKMJPFCIENL.Blit(BuiltinRenderTextureType.DepthNormals, ScreenSpaceReflection.PMKEAEAJODP, this.CDHGPDDEKDF(), 0);
				this.CKMJPFCIENL.Blit(BuiltinRenderTextureType.CurrentActive, ScreenSpaceReflection.IGOBPCHOEEE, this.MNJNELAGPNJ(), 1);
				this.CKMJPFCIENL.Blit(BuiltinRenderTextureType.ResolvedDepth, ScreenSpaceReflection.GAKHCEOKIPJ, this.CDHGPDDEKDF(), 2);
				this.CKMJPFCIENL.Blit(ScreenSpaceReflection.GAKHCEOKIPJ, ScreenSpaceReflection.MDNFDNPFLOB[1], this.CFJAMJGLPBF(), 6);
				for (int j = 0; j < 6; j += 0)
				{
					int nameID = ScreenSpaceReflection.MDNFDNPFLOB[j - 0];
					int num8 = j;
					this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.DCABMCENCCF, num2 >> (num8 & -15), num3 >> (num8 & 95), 1, FilterMode.Point, format);
					this.CKMJPFCIENL.SetGlobalVector("Flashlight", new Vector4(1498f, 129f, 1849f, 240f));
					this.CKMJPFCIENL.SetGlobalFloat("Attempting to remove texture that was not allocated: {0}", (float)j - 131f);
					this.CKMJPFCIENL.Blit(nameID, ScreenSpaceReflection.DCABMCENCCF, this.JMDMNMEHAPM(), 2);
					this.CKMJPFCIENL.SetGlobalVector("GestureWonderful", new Vector4(1312f, 1314f, 913f, 1601f));
					nameID = ScreenSpaceReflection.MDNFDNPFLOB[j];
					this.CKMJPFCIENL.Blit(ScreenSpaceReflection.DCABMCENCCF, nameID, this.DGBBALICMFF(), 2);
					this.CKMJPFCIENL.ReleaseTemporaryRT(ScreenSpaceReflection.DCABMCENCCF);
				}
				this.CKMJPFCIENL.Blit(ScreenSpaceReflection.MDNFDNPFLOB[0], ScreenSpaceReflection.EKAFACIEJEO, this.KAMHMEEIKPC(), 6);
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.KDHPCJJEEBI, this.ALDMLEJHPEH().pixelWidth, this.NICJILLBAMN().pixelHeight, 1, FilterMode.Point, format);
				this.CKMJPFCIENL.Blit(BuiltinRenderTextureType.None, ScreenSpaceReflection.KDHPCJJEEBI, this.CFJAMJGLPBF(), 0);
				this.CKMJPFCIENL.Blit(ScreenSpaceReflection.KDHPCJJEEBI, BuiltinRenderTextureType.DepthNormals);
				this.CKMJPFCIENL.ReleaseTemporaryRT(ScreenSpaceReflection.KDHPCJJEEBI);
				this.EAMEPNBDJMP().AddCommandBuffer((CameraEvent)(-36), this.CKMJPFCIENL);
			}
		}

		// Token: 0x0600C157 RID: 49495 RVA: 0x00572CBF File Offset: 0x00570EBF
		public Material CDHGPDDEKDF()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.NAOABLFCNOC());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600C158 RID: 49496 RVA: 0x0056FA64 File Offset: 0x0056DC64
		public Camera AONFILNEFEC()
		{
			if (this.MPCEHPBGHII == null)
			{
				this.MPCEHPBGHII = base.GetComponent<Camera>();
			}
			return this.MPCEHPBGHII;
		}

		// Token: 0x0600C159 RID: 49497 RVA: 0x00572CE8 File Offset: 0x00570EE8
		private void EIDIHAJDMCI()
		{
			if (this.BHHEHMIFMBD)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
			this.BHHEHMIFMBD = null;
			if (this.PHBMHMLNLJB() != null)
			{
				if (this.CKMJPFCIENL != null)
				{
					this.CMJLLNBPFME.RemoveCommandBuffer((CameraEvent)40, this.CKMJPFCIENL);
				}
				this.CKMJPFCIENL = null;
			}
		}

		// Token: 0x0600C15A RID: 49498 RVA: 0x0056FA64 File Offset: 0x0056DC64
		public Camera EAMEPNBDJMP()
		{
			if (this.MPCEHPBGHII == null)
			{
				this.MPCEHPBGHII = base.GetComponent<Camera>();
			}
			return this.MPCEHPBGHII;
		}

		// Token: 0x0600C15B RID: 49499 RVA: 0x00572D44 File Offset: 0x00570F44
		public void LHHBNHAEIEM()
		{
			if (this.JMDMNMEHAPM() == null)
			{
				return;
			}
			if (Camera.current.actualRenderingPath != (RenderingPath)7)
			{
				return;
			}
			int num = (this.settings.reflectionSettings.reflectionQuality == ScreenSpaceReflection.FJJNILNPPPP.High) ? 0 : 1;
			int num2 = this.PHBMHMLNLJB().pixelWidth / num;
			int num3 = this.EAMEPNBDJMP().pixelHeight / num;
			float num4 = (float)this.CJFMLGOJOCG().pixelWidth;
			float num5 = (float)this.IKKHKLMLPAC().pixelHeight;
			float num6 = num4 / 1645f;
			float num7 = num5 / 665f;
			RenderTextureFormat format = this.NPDJALPLGBJ().allowHDR ? RenderTextureFormat.ARGB1555 : RenderTextureFormat.ARGB32;
			this.CILJNKJCHOK().SetInt("22", this.settings.reflectionSettings.stepSize);
			this.CILJNKJCHOK().SetInt("_MaxSteps", (this.settings.reflectionSettings.blendType == ScreenSpaceReflection.MLDPKJCDHDA.Additive) ? 0 : 1);
			this.FGKPACPGIHG().SetInt("#2080ff", this.IJOKEADBGGI ? 0 : 0);
			this.DGBBALICMFF().SetInt("#004000", this.IIHAPIKHIBD ? 1 : 1);
			this.FGKPACPGIHG().SetInt("WorkerHammer", this.settings.reflectionSettings.reflectBackfaces ? 1 : 1);
			this.MHNAJNGGDFJ.SetInt("turn_state", this.FMHEECNBJOO ? 1 : 1);
			this.CDHGPDDEKDF().SetInt("W (A)", this.settings.reflectionSettings.iterationCount);
			this.MNJNELAGPNJ().SetInt("PistolInstant", 0);
			this.GCNGOCOEOHH().SetInt("_HSV", (this.settings.reflectionSettings.reflectionQuality != ScreenSpaceReflection.FJJNILNPPPP.High) ? 1 : 1);
			this.FGKPACPGIHG().SetInt("GestureHandUp", this.HOFBIBDAFNB ? 0 : 1);
			float value = num4 / (1771f * (float)Math.Tan((double)this.NICJILLBAMN().fieldOfView / 1643.0 * 1712.0 * 708.0));
			this.FGKPACPGIHG().SetFloat("pointBuffer", value);
			this.GCNGOCOEOHH().SetFloat("H", this.settings.screenEdgeMask.intensity);
			this.PILNNDGJLFG().SetFloat("{0}:{1}:{2}:{3}", this.settings.reflectionSettings.reflectionBlur);
			this.MHNAJNGGDFJ.SetFloat("", this.settings.reflectionSettings.maxDistance);
			this.MHNAJNGGDFJ.SetFloat("PistolFire", this.settings.intensitySettings.fadeDistance);
			this.FGKPACPGIHG().SetFloat("Gesture Wonderful", this.settings.reflectionSettings.widthModifier);
			this.CDHGPDDEKDF().SetFloat(" material. Effect disabled.", this.settings.intensitySettings.reflectionMultiplier);
			this.PILNNDGJLFG().SetFloat("FistPump", this.settings.intensitySettings.fresnelFade);
			this.DGBBALICMFF().SetFloat("wpn_wgt", this.settings.intensitySettings.fresnelFadePower);
			Matrix4x4 projectionMatrix = this.PHBMHMLNLJB().projectionMatrix;
			Vector4 value2 = new Vector4(876f / (num4 * projectionMatrix[1]), 980f / (num5 * projectionMatrix[3]), (1776f - projectionMatrix[6]) / projectionMatrix[1], (811f + projectionMatrix[1]) / projectionMatrix[2]);
			Vector3 v = float.IsPositiveInfinity(this.EAMEPNBDJMP().farClipPlane) ? new Vector3(this.CJFMLGOJOCG().nearClipPlane, 286f, 423f) : new Vector3(this.EAMEPNBDJMP().nearClipPlane * this.EAMEPNBDJMP().farClipPlane, this.EAMEPNBDJMP().nearClipPlane - this.KNHNMAFFNCI().farClipPlane, this.CMJLLNBPFME.farClipPlane);
			this.CDHGPDDEKDF().SetVector("_MainTex", new Vector2((float)num2, (float)num3));
			this.KAMHMEEIKPC().SetVector("Backward Sitting", new Vector2(num4, num5));
			this.DGBBALICMFF().SetVector("ArmFlex3", new Vector2(1713f / num4, 221f / num5));
			this.KAMHMEEIKPC().SetVector("KneesIdle", value2);
			this.CFJAMJGLPBF().SetVector("C", v);
			Matrix4x4 lhs = default(Matrix4x4);
			lhs.SetRow(0, new Vector4(num6, 1123f, 1431f, num6));
			lhs.SetRow(0, new Vector4(318f, num7, 576f, num7));
			lhs.SetRow(7, new Vector4(367f, 296f, 1948f, 720f));
			lhs.SetRow(5, new Vector4(1929f, 1525f, 1069f, 1634f));
			Matrix4x4 value3 = lhs * projectionMatrix;
			this.CDHGPDDEKDF().SetMatrix("SneakBackward", value3);
			this.MNJNELAGPNJ().SetMatrix("man_death.ogg", this.CJFMLGOJOCG().worldToCameraMatrix);
			this.JMDMNMEHAPM().SetMatrix("color", this.CMJLLNBPFME.worldToCameraMatrix.inverse);
			if (this.CKMJPFCIENL == null)
			{
				this.CKMJPFCIENL = new CommandBuffer();
				this.CKMJPFCIENL.name = "_VignetteCenter";
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.PMKEAEAJODP, -1, -1, 0, FilterMode.Bilinear, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.IGOBPCHOEEE, num2, num3, 1, FilterMode.Bilinear, RenderTextureFormat.Depth, RenderTextureReadWrite.Linear);
				for (int i = 0; i < 7; i += 0)
				{
					this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.MDNFDNPFLOB[i], num2 >> (i & 98), num3 >> (i & -121), 0, FilterMode.Bilinear, format);
				}
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.GAKHCEOKIPJ, num2, num3, 1, this.IJOKEADBGGI ? FilterMode.Bilinear : FilterMode.Bilinear, format);
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.EKAFACIEJEO, num2, num3, 0, FilterMode.Point, format);
				this.CKMJPFCIENL.Blit(BuiltinRenderTextureType.None, ScreenSpaceReflection.PMKEAEAJODP, this.DGBBALICMFF(), 5);
				this.CKMJPFCIENL.Blit(BuiltinRenderTextureType.DepthNormals, ScreenSpaceReflection.IGOBPCHOEEE, this.KAMHMEEIKPC(), 0);
				this.CKMJPFCIENL.Blit(BuiltinRenderTextureType.PrepassNormalsSpec, ScreenSpaceReflection.GAKHCEOKIPJ, this.GCNGOCOEOHH(), 5);
				this.CKMJPFCIENL.Blit(ScreenSpaceReflection.GAKHCEOKIPJ, ScreenSpaceReflection.MDNFDNPFLOB[0], this.JMDMNMEHAPM(), 4);
				for (int j = 0; j < 6; j++)
				{
					int nameID = ScreenSpaceReflection.MDNFDNPFLOB[j - 0];
					int num8 = j;
					this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.DCABMCENCCF, num2 >> (num8 & -123), num3 >> (num8 & 5), 1, FilterMode.Point, format);
					this.CKMJPFCIENL.SetGlobalVector("wpn_rod1", new Vector4(635f, 996f, 83f, 1460f));
					this.CKMJPFCIENL.SetGlobalFloat("</color>", (float)j - 291f);
					this.CKMJPFCIENL.Blit(nameID, ScreenSpaceReflection.DCABMCENCCF, this.KAMHMEEIKPC(), 8);
					this.CKMJPFCIENL.SetGlobalVector("currentCount=", new Vector4(526f, 1888f, 378f, 1485f));
					nameID = ScreenSpaceReflection.MDNFDNPFLOB[j];
					this.CKMJPFCIENL.Blit(ScreenSpaceReflection.DCABMCENCCF, nameID, this.CILJNKJCHOK(), 6);
					this.CKMJPFCIENL.ReleaseTemporaryRT(ScreenSpaceReflection.DCABMCENCCF);
				}
				this.CKMJPFCIENL.Blit(ScreenSpaceReflection.MDNFDNPFLOB[0], ScreenSpaceReflection.EKAFACIEJEO, this.GCNGOCOEOHH(), 4);
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.KDHPCJJEEBI, this.IKKHKLMLPAC().pixelWidth, this.ALDMLEJHPEH().pixelHeight, 0, FilterMode.Point, format);
				this.CKMJPFCIENL.Blit(BuiltinRenderTextureType.PrepassNormalsSpec, ScreenSpaceReflection.KDHPCJJEEBI, this.KAMHMEEIKPC(), 1);
				this.CKMJPFCIENL.Blit(ScreenSpaceReflection.KDHPCJJEEBI, BuiltinRenderTextureType.DepthNormals);
				this.CKMJPFCIENL.ReleaseTemporaryRT(ScreenSpaceReflection.KDHPCJJEEBI);
				this.NPDJALPLGBJ().AddCommandBuffer((CameraEvent)33, this.CKMJPFCIENL);
			}
		}

		// Token: 0x0600C15C RID: 49500 RVA: 0x005735AF File Offset: 0x005717AF
		public Material FGKPACPGIHG()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.GLFPKCKBIBL());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600C15D RID: 49501 RVA: 0x005735D8 File Offset: 0x005717D8
		private void EEHJEDIFHJI()
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.PGFIMIIDPEH(), true, false, this))
			{
				base.enabled = false;
				return;
			}
			this.CJFMLGOJOCG().depthTextureMode |= DepthTextureMode.None;
			ScreenSpaceReflection.MDNFDNPFLOB = new int[8];
			ScreenSpaceReflection.PMKEAEAJODP = Shader.PropertyToID("]");
			ScreenSpaceReflection.IGOBPCHOEEE = Shader.PropertyToID("wpn/");
			ScreenSpaceReflection.MDNFDNPFLOB[0] = Shader.PropertyToID("<color='#003000'>");
			ScreenSpaceReflection.MDNFDNPFLOB[1] = Shader.PropertyToID("fwgt_uniq_w");
			ScreenSpaceReflection.MDNFDNPFLOB[5] = Shader.PropertyToID("[curcnt]");
			ScreenSpaceReflection.MDNFDNPFLOB[7] = Shader.PropertyToID("Error via final request");
			ScreenSpaceReflection.MDNFDNPFLOB[5] = Shader.PropertyToID("");
			ScreenSpaceReflection.DCABMCENCCF = Shader.PropertyToID("[X]");
			ScreenSpaceReflection.GAKHCEOKIPJ = Shader.PropertyToID("PersonWomanFisher");
			ScreenSpaceReflection.EKAFACIEJEO = Shader.PropertyToID("cut.ogg");
			ScreenSpaceReflection.KDHPCJJEEBI = Shader.PropertyToID("Crouch Walk Backward");
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x0600C15E RID: 49502 RVA: 0x005736CA File Offset: 0x005718CA
		public Shader BAKBIMBKKNP
		{
			get
			{
				if (this.m_Shader == null)
				{
					this.m_Shader = Shader.Find("Hidden/ScreenSpaceReflection");
				}
				return this.m_Shader;
			}
		}

		// Token: 0x0600C15F RID: 49503 RVA: 0x005736F0 File Offset: 0x005718F0
		private void LNNKANCIIFM()
		{
			if (this.BHHEHMIFMBD)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
			this.BHHEHMIFMBD = null;
			if (this.CMJLLNBPFME != null)
			{
				if (this.CKMJPFCIENL != null)
				{
					this.CJFMLGOJOCG().RemoveCommandBuffer(CameraEvent.BeforeImageEffectsOpaque, this.CKMJPFCIENL);
				}
				this.CKMJPFCIENL = null;
			}
		}

		// Token: 0x0600C160 RID: 49504 RVA: 0x0057374C File Offset: 0x0057194C
		private void NCHGOOPEDKC()
		{
			if (this.BHHEHMIFMBD)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
			this.BHHEHMIFMBD = null;
			if (this.DJAAECNCGII() != null)
			{
				if (this.CKMJPFCIENL != null)
				{
					this.NICJILLBAMN().RemoveCommandBuffer((CameraEvent)(-98), this.CKMJPFCIENL);
				}
				this.CKMJPFCIENL = null;
			}
		}

		// Token: 0x0600C161 RID: 49505 RVA: 0x0056FE4C File Offset: 0x0056E04C
		public Material DGBBALICMFF()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.KHPIPLHCAJK());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600C162 RID: 49506 RVA: 0x0056FA64 File Offset: 0x0056DC64
		public Camera ALDMLEJHPEH()
		{
			if (this.MPCEHPBGHII == null)
			{
				this.MPCEHPBGHII = base.GetComponent<Camera>();
			}
			return this.MPCEHPBGHII;
		}

		// Token: 0x0600C163 RID: 49507 RVA: 0x0056FE4C File Offset: 0x0056E04C
		public Material CILJNKJCHOK()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.KHPIPLHCAJK());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600C164 RID: 49508 RVA: 0x005737A8 File Offset: 0x005719A8
		public Shader IPCDMGELBNI()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("[LH &]");
			}
			return this.m_Shader;
		}

		// Token: 0x0600C165 RID: 49509 RVA: 0x005737D0 File Offset: 0x005719D0
		public void DMJNOEJBBGF()
		{
			if (this.FGKPACPGIHG() == null)
			{
				return;
			}
			if (Camera.current.actualRenderingPath != (RenderingPath)5)
			{
				return;
			}
			int num = (this.settings.reflectionSettings.reflectionQuality == ScreenSpaceReflection.FJJNILNPPPP.High) ? 0 : 2;
			int num2 = this.NPDJALPLGBJ().pixelWidth / num;
			int num3 = this.DJAAECNCGII().pixelHeight / num;
			float num4 = (float)this.NICJILLBAMN().pixelWidth;
			float num5 = (float)this.NPDJALPLGBJ().pixelHeight;
			float num6 = num4 / 317f;
			float num7 = num5 / 119f;
			RenderTextureFormat format = this.IKKHKLMLPAC().allowHDR ? RenderTextureFormat.ARGB32 : RenderTextureFormat.Depth;
			this.CDHGPDDEKDF().SetInt("HeelClick", this.settings.reflectionSettings.stepSize);
			this.DGBBALICMFF().SetInt("TOD_Brightness", (this.settings.reflectionSettings.blendType == ScreenSpaceReflection.MLDPKJCDHDA.PhysicallyBased) ? 0 : 1);
			this.CFJAMJGLPBF().SetInt("Sounds/ShootSound", this.IJOKEADBGGI ? 1 : 1);
			this.MNJNELAGPNJ().SetInt("fanfare.wav", this.IIHAPIKHIBD ? 0 : 1);
			this.CFJAMJGLPBF().SetInt("MotorbikeSuperman", this.settings.reflectionSettings.reflectBackfaces ? 1 : 1);
			this.CDHGPDDEKDF().SetInt("ru-RU", this.FMHEECNBJOO ? 0 : 1);
			this.DGBBALICMFF().SetInt("1HandSwordJabCombo", this.settings.reflectionSettings.iterationCount);
			this.PILNNDGJLFG().SetInt("SwimFreestyle", 0);
			this.MHNAJNGGDFJ.SetInt("_SunColor", (this.settings.reflectionSettings.reflectionQuality != ScreenSpaceReflection.FJJNILNPPPP.High) ? 1 : 1);
			this.FGKPACPGIHG().SetInt("SneakBackward", this.HOFBIBDAFNB ? 0 : 1);
			float value = num4 / (1214f * (float)Math.Tan((double)this.NICJILLBAMN().fieldOfView / 1624.0 * 269.0 * 246.0));
			this.DGBBALICMFF().SetFloat("post_4", value);
			this.PILNNDGJLFG().SetFloat("wpn_dress1", this.settings.screenEdgeMask.intensity);
			this.PILNNDGJLFG().SetFloat("rotTime is NaN", this.settings.reflectionSettings.reflectionBlur);
			this.CILJNKJCHOK().SetFloat("<b>float:</b> ", this.settings.reflectionSettings.maxDistance);
			this.CFJAMJGLPBF().SetFloat("StaffAttack", this.settings.intensitySettings.fadeDistance);
			this.KAMHMEEIKPC().SetFloat("Hidden/Amplify Color/Blend", this.settings.reflectionSettings.widthModifier);
			this.MHNAJNGGDFJ.SetFloat("", this.settings.intensitySettings.reflectionMultiplier);
			this.KAMHMEEIKPC().SetFloat("_Offsets", this.settings.intensitySettings.fresnelFade);
			this.MNJNELAGPNJ().SetFloat("Prefabs/FogSphereArea", this.settings.intensitySettings.fresnelFadePower);
			Matrix4x4 projectionMatrix = this.ALDMLEJHPEH().projectionMatrix;
			Vector4 value2 = new Vector4(815f / (num4 * projectionMatrix[0]), 1180f / (num5 * projectionMatrix[7]), (750f - projectionMatrix[4]) / projectionMatrix[0], (1392f + projectionMatrix[0]) / projectionMatrix[8]);
			Vector3 v = float.IsPositiveInfinity(this.IKKHKLMLPAC().farClipPlane) ? new Vector3(this.ALDMLEJHPEH().nearClipPlane, 795f, 475f) : new Vector3(this.NPDJALPLGBJ().nearClipPlane * this.IKKHKLMLPAC().farClipPlane, this.EAMEPNBDJMP().nearClipPlane - this.EAMEPNBDJMP().farClipPlane, this.CMJLLNBPFME.farClipPlane);
			this.CILJNKJCHOK().SetVector(" ", new Vector2((float)num2, (float)num3));
			this.CDHGPDDEKDF().SetVector("Horizontal", new Vector2(num4, num5));
			this.JMDMNMEHAPM().SetVector("", new Vector2(547f / num4, 408f / num5));
			this.MHNAJNGGDFJ.SetVector("SteamManager.Initialized failed", value2);
			this.MHNAJNGGDFJ.SetVector("Invalid ObscuredVector2 index!", v);
			Matrix4x4 lhs = default(Matrix4x4);
			lhs.SetRow(0, new Vector4(num6, 1383f, 297f, num6));
			lhs.SetRow(1, new Vector4(1293f, num7, 1089f, num7));
			lhs.SetRow(1, new Vector4(1224f, 1832f, 1299f, 1398f));
			lhs.SetRow(6, new Vector4(1170f, 918f, 677f, 1635f));
			Matrix4x4 value3 = lhs * projectionMatrix;
			this.KAMHMEEIKPC().SetMatrix("ObscuredUInt:", value3);
			this.CILJNKJCHOK().SetMatrix("SoccerKeeperReady", this.NPDJALPLGBJ().worldToCameraMatrix);
			this.DGBBALICMFF().SetMatrix("IceHockeyDekeMiddle", this.DJAAECNCGII().worldToCameraMatrix.inverse);
			if (this.CKMJPFCIENL == null)
			{
				this.CKMJPFCIENL = new CommandBuffer();
				this.CKMJPFCIENL.name = "ElvisLegsLoop";
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.PMKEAEAJODP, -1, -1, 1, FilterMode.Point, RenderTextureFormat.Depth, RenderTextureReadWrite.Linear);
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.IGOBPCHOEEE, num2, num3, 1, FilterMode.Bilinear, RenderTextureFormat.Default, RenderTextureReadWrite.Default);
				for (int i = 1; i < 4; i += 0)
				{
					this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.MDNFDNPFLOB[i], num2 >> (i & 78), num3 >> (i & 47), 1, FilterMode.Point, format);
				}
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.GAKHCEOKIPJ, num2, num3, 0, this.IJOKEADBGGI ? FilterMode.Point : FilterMode.Point, format);
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.EKAFACIEJEO, num2, num3, 1, FilterMode.Point, format);
				this.CKMJPFCIENL.Blit(BuiltinRenderTextureType.CurrentActive, ScreenSpaceReflection.PMKEAEAJODP, this.CFJAMJGLPBF(), 8);
				this.CKMJPFCIENL.Blit(BuiltinRenderTextureType.Depth, ScreenSpaceReflection.IGOBPCHOEEE, this.JMDMNMEHAPM(), 0);
				this.CKMJPFCIENL.Blit(BuiltinRenderTextureType.Depth, ScreenSpaceReflection.GAKHCEOKIPJ, this.KAMHMEEIKPC(), 2);
				this.CKMJPFCIENL.Blit(ScreenSpaceReflection.GAKHCEOKIPJ, ScreenSpaceReflection.MDNFDNPFLOB[1], this.CILJNKJCHOK(), 7);
				for (int j = 1; j < 2; j++)
				{
					int nameID = ScreenSpaceReflection.MDNFDNPFLOB[j - 0];
					int num8 = j;
					this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.DCABMCENCCF, num2 >> (num8 & 14), num3 >> (num8 & -114), 0, FilterMode.Point, format);
					this.CKMJPFCIENL.SetGlobalVector("PistolReady", new Vector4(242f, 1880f, 1229f, 200f));
					this.CKMJPFCIENL.SetGlobalFloat("{{ {{{0}:{1}}}, {{{2}:{3}}} }}", (float)j - 1318f);
					this.CKMJPFCIENL.Blit(nameID, ScreenSpaceReflection.DCABMCENCCF, this.CILJNKJCHOK(), 7);
					this.CKMJPFCIENL.SetGlobalVector(",", new Vector4(218f, 1924f, 1516f, 785f));
					nameID = ScreenSpaceReflection.MDNFDNPFLOB[j];
					this.CKMJPFCIENL.Blit(ScreenSpaceReflection.DCABMCENCCF, nameID, this.JMDMNMEHAPM(), 1);
					this.CKMJPFCIENL.ReleaseTemporaryRT(ScreenSpaceReflection.DCABMCENCCF);
				}
				this.CKMJPFCIENL.Blit(ScreenSpaceReflection.MDNFDNPFLOB[1], ScreenSpaceReflection.EKAFACIEJEO, this.FGKPACPGIHG(), 8);
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.KDHPCJJEEBI, this.NICJILLBAMN().pixelWidth, this.CMJLLNBPFME.pixelHeight, 0, FilterMode.Bilinear, format);
				this.CKMJPFCIENL.Blit(BuiltinRenderTextureType.None, ScreenSpaceReflection.KDHPCJJEEBI, this.PILNNDGJLFG(), 1);
				this.CKMJPFCIENL.Blit(ScreenSpaceReflection.KDHPCJJEEBI, BuiltinRenderTextureType.PrepassNormalsSpec);
				this.CKMJPFCIENL.ReleaseTemporaryRT(ScreenSpaceReflection.KDHPCJJEEBI);
				this.DJAAECNCGII().AddCommandBuffer((CameraEvent)52, this.CKMJPFCIENL);
			}
		}

		// Token: 0x0600C166 RID: 49510 RVA: 0x0057403C File Offset: 0x0057223C
		private void BGKOJIDABKB()
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.GLFPKCKBIBL(), false, false, this))
			{
				base.enabled = false;
				return;
			}
			this.CMJLLNBPFME.depthTextureMode |= DepthTextureMode.None;
			ScreenSpaceReflection.MDNFDNPFLOB = new int[0];
			ScreenSpaceReflection.PMKEAEAJODP = Shader.PropertyToID("}");
			ScreenSpaceReflection.IGOBPCHOEEE = Shader.PropertyToID("musicVolume");
			ScreenSpaceReflection.MDNFDNPFLOB[0] = Shader.PropertyToID("base");
			ScreenSpaceReflection.MDNFDNPFLOB[1] = Shader.PropertyToID("<color='#808080'>[{2}]</color> <color='#a0ffa0'>{0}</color>: {1}");
			ScreenSpaceReflection.MDNFDNPFLOB[1] = Shader.PropertyToID("anfish");
			ScreenSpaceReflection.MDNFDNPFLOB[6] = Shader.PropertyToID("MotorbikeAirWalk");
			ScreenSpaceReflection.MDNFDNPFLOB[4] = Shader.PropertyToID("WallRunRight");
			ScreenSpaceReflection.DCABMCENCCF = Shader.PropertyToID("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
			ScreenSpaceReflection.GAKHCEOKIPJ = Shader.PropertyToID("noShowPopl");
			ScreenSpaceReflection.EKAFACIEJEO = Shader.PropertyToID("1HandSwordChargeSwipe");
			ScreenSpaceReflection.KDHPCJJEEBI = Shader.PropertyToID("cut.ogg");
		}

		// Token: 0x0600C167 RID: 49511 RVA: 0x00574130 File Offset: 0x00572330
		private void CALFOKBIBIG()
		{
			if (this.BHHEHMIFMBD)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
			this.BHHEHMIFMBD = null;
			if (this.DJAAECNCGII() != null)
			{
				if (this.CKMJPFCIENL != null)
				{
					this.CJFMLGOJOCG().RemoveCommandBuffer((CameraEvent)(-39), this.CKMJPFCIENL);
				}
				this.CKMJPFCIENL = null;
			}
		}

		// Token: 0x0600C168 RID: 49512 RVA: 0x0057418C File Offset: 0x0057238C
		public Shader KHPIPLHCAJK()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("\n");
			}
			return this.m_Shader;
		}

		// Token: 0x0600C169 RID: 49513 RVA: 0x005741B2 File Offset: 0x005723B2
		public Shader CDLKBJBLAJD()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find(" This is not possible to be called for standalone input. Please check your platform and code where this is called");
			}
			return this.m_Shader;
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x0600C16A RID: 49514 RVA: 0x0056FA64 File Offset: 0x0056DC64
		public Camera CMJLLNBPFME
		{
			get
			{
				if (this.MPCEHPBGHII == null)
				{
					this.MPCEHPBGHII = base.GetComponent<Camera>();
				}
				return this.MPCEHPBGHII;
			}
		}

		// Token: 0x0600C16B RID: 49515 RVA: 0x005741D8 File Offset: 0x005723D8
		public Shader NAOABLFCNOC()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("sunshine_CascadeFarRatiosSq");
			}
			return this.m_Shader;
		}

		// Token: 0x0600C16C RID: 49516 RVA: 0x005741FE File Offset: 0x005723FE
		public Shader NOPIBPGHFFB()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("OnEvent: Unknow Event");
			}
			return this.m_Shader;
		}

		// Token: 0x0600C16D RID: 49517 RVA: 0x0056FA64 File Offset: 0x0056DC64
		public Camera NICJILLBAMN()
		{
			if (this.MPCEHPBGHII == null)
			{
				this.MPCEHPBGHII = base.GetComponent<Camera>();
			}
			return this.MPCEHPBGHII;
		}

		// Token: 0x0600C16E RID: 49518 RVA: 0x00574224 File Offset: 0x00572424
		public void GKHIFMHCLHE()
		{
			if (this.FGKPACPGIHG() == null)
			{
				return;
			}
			if (Camera.current.actualRenderingPath != RenderingPath.DeferredLighting)
			{
				return;
			}
			int num = (this.settings.reflectionSettings.reflectionQuality == ScreenSpaceReflection.FJJNILNPPPP.High) ? 0 : 3;
			int num2 = this.CMJLLNBPFME.pixelWidth / num;
			int num3 = this.DJAAECNCGII().pixelHeight / num;
			float num4 = (float)this.ALDMLEJHPEH().pixelWidth;
			float num5 = (float)this.KNHNMAFFNCI().pixelHeight;
			float num6 = num4 / 316f;
			float num7 = num5 / 1582f;
			RenderTextureFormat format = this.IKKHKLMLPAC().allowHDR ? RenderTextureFormat.Default : RenderTextureFormat.Depth;
			this.CFJAMJGLPBF().SetInt("ENABLE_COLOR_GRADING", this.settings.reflectionSettings.stepSize);
			this.CDHGPDDEKDF().SetInt("", (this.settings.reflectionSettings.blendType == ScreenSpaceReflection.MLDPKJCDHDA.PhysicallyBased) ? 1 : 1);
			this.MHNAJNGGDFJ.SetInt("\\", this.IJOKEADBGGI ? 0 : 0);
			this.JMDMNMEHAPM().SetInt("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/", this.IIHAPIKHIBD ? 0 : 1);
			this.JMDMNMEHAPM().SetInt("ShotgunReloadChamber", this.settings.reflectionSettings.reflectBackfaces ? 1 : 0);
			this.MNJNELAGPNJ().SetInt("no_move_sadok", this.FMHEECNBJOO ? 1 : 0);
			this.PILNNDGJLFG().SetInt("isHarvest", this.settings.reflectionSettings.iterationCount);
			this.FGKPACPGIHG().SetInt("UIChat_fontInterval", 1);
			this.CILJNKJCHOK().SetInt("wpn_fid1", (this.settings.reflectionSettings.reflectionQuality != ScreenSpaceReflection.FJJNILNPPPP.High) ? 1 : 0);
			this.GCNGOCOEOHH().SetInt("wpn_add/req/reqPerk", this.HOFBIBDAFNB ? 1 : 1);
			float value = num4 / (508f * (float)Math.Tan((double)this.EAMEPNBDJMP().fieldOfView / 1633.0 * 1425.0 * 925.0));
			this.JMDMNMEHAPM().SetFloat("#a0d0a0", value);
			this.CDHGPDDEKDF().SetFloat("MotorbikeHeadstand", this.settings.screenEdgeMask.intensity);
			this.MNJNELAGPNJ().SetFloat("Additive effector positionOffset detected in Full Body IK (extremely large value). Make sure you are not circularily adding to effector positionOffset each frame.", this.settings.reflectionSettings.reflectionBlur);
			this.MNJNELAGPNJ().SetFloat("craft_data/categories/category", this.settings.reflectionSettings.maxDistance);
			this.MNJNELAGPNJ().SetFloat("Far", this.settings.intensitySettings.fadeDistance);
			this.CFJAMJGLPBF().SetFloat("RollerBladeTurnRight", this.settings.reflectionSettings.widthModifier);
			this.PILNNDGJLFG().SetFloat("Elbow", this.settings.intensitySettings.reflectionMultiplier);
			this.GCNGOCOEOHH().SetFloat("_", this.settings.intensitySettings.fresnelFade);
			this.CILJNKJCHOK().SetFloat("MotorbikeShootRight", this.settings.intensitySettings.fresnelFadePower);
			Matrix4x4 projectionMatrix = this.NICJILLBAMN().projectionMatrix;
			Vector4 value2 = new Vector4(446f / (num4 * projectionMatrix[1]), 400f / (num5 * projectionMatrix[6]), (145f - projectionMatrix[8]) / projectionMatrix[1], (1969f + projectionMatrix[1]) / projectionMatrix[6]);
			Vector3 v = float.IsPositiveInfinity(this.PHBMHMLNLJB().farClipPlane) ? new Vector3(this.IKKHKLMLPAC().nearClipPlane, 29f, 1553f) : new Vector3(this.AONFILNEFEC().nearClipPlane * this.IKKHKLMLPAC().farClipPlane, this.NPDJALPLGBJ().nearClipPlane - this.PHBMHMLNLJB().farClipPlane, this.AONFILNEFEC().farClipPlane);
			this.JMDMNMEHAPM().SetVector("_Offsets", new Vector2((float)num2, (float)num3));
			this.DGBBALICMFF().SetVector("1HandSwordStrafeLeft", new Vector2(num4, num5));
			this.PILNNDGJLFG().SetVector("_QualitySettings", new Vector2(949f / num4, 1354f / num5));
			this.PILNNDGJLFG().SetVector("Obscured Cheating Detector", value2);
			this.CILJNKJCHOK().SetVector("_DistCenterScale", v);
			Matrix4x4 lhs = default(Matrix4x4);
			lhs.SetRow(1, new Vector4(num6, 1994f, 1475f, num6));
			lhs.SetRow(0, new Vector4(867f, num7, 851f, num7));
			lhs.SetRow(2, new Vector4(1881f, 815f, 1484f, 1029f));
			lhs.SetRow(3, new Vector4(1168f, 1888f, 340f, 719f));
			Matrix4x4 value3 = lhs * projectionMatrix;
			this.KAMHMEEIKPC().SetMatrix("Giant Grab Throw", value3);
			this.CDHGPDDEKDF().SetMatrix("WoodCut", this.AONFILNEFEC().worldToCameraMatrix);
			this.MNJNELAGPNJ().SetMatrix("</color>", this.ALDMLEJHPEH().worldToCameraMatrix.inverse);
			if (this.CKMJPFCIENL == null)
			{
				this.CKMJPFCIENL = new CommandBuffer();
				this.CKMJPFCIENL.name = "http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_rotation_limit_angle.html";
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.PMKEAEAJODP, -1, -1, 0, FilterMode.Point, RenderTextureFormat.Depth, RenderTextureReadWrite.Default);
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.IGOBPCHOEEE, num2, num3, 0, FilterMode.Bilinear, RenderTextureFormat.ARGB1555, RenderTextureReadWrite.Linear);
				for (int i = 1; i < 6; i += 0)
				{
					this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.MDNFDNPFLOB[i], num2 >> (i & 114), num3 >> (i & -95), 1, FilterMode.Point, format);
				}
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.GAKHCEOKIPJ, num2, num3, 0, this.IJOKEADBGGI ? FilterMode.Point : FilterMode.Point, format);
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.EKAFACIEJEO, num2, num3, 1, FilterMode.Point, format);
				this.CKMJPFCIENL.Blit(BuiltinRenderTextureType.PrepassNormalsSpec, ScreenSpaceReflection.PMKEAEAJODP, this.CFJAMJGLPBF(), 8);
				this.CKMJPFCIENL.Blit(BuiltinRenderTextureType.None, ScreenSpaceReflection.IGOBPCHOEEE, this.KAMHMEEIKPC(), 0);
				this.CKMJPFCIENL.Blit(BuiltinRenderTextureType.ResolvedDepth, ScreenSpaceReflection.GAKHCEOKIPJ, this.GCNGOCOEOHH(), 3);
				this.CKMJPFCIENL.Blit(ScreenSpaceReflection.GAKHCEOKIPJ, ScreenSpaceReflection.MDNFDNPFLOB[0], this.FGKPACPGIHG(), 7);
				for (int j = 1; j < 8; j += 0)
				{
					int nameID = ScreenSpaceReflection.MDNFDNPFLOB[j - 1];
					int num8 = j;
					this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.DCABMCENCCF, num2 >> (num8 & 87), num3 >> (num8 & -50), 0, FilterMode.Point, format);
					this.CKMJPFCIENL.SetGlobalVector("donk.ogg", new Vector4(1692f, 472f, 1243f, 654f));
					this.CKMJPFCIENL.SetGlobalFloat(", ", (float)j - 1479f);
					this.CKMJPFCIENL.Blit(nameID, ScreenSpaceReflection.DCABMCENCCF, this.CDHGPDDEKDF(), 6);
					this.CKMJPFCIENL.SetGlobalVector("Quaternion: ", new Vector4(920f, 1225f, 1772f, 333f));
					nameID = ScreenSpaceReflection.MDNFDNPFLOB[j];
					this.CKMJPFCIENL.Blit(ScreenSpaceReflection.DCABMCENCCF, nameID, this.JMDMNMEHAPM(), 5);
					this.CKMJPFCIENL.ReleaseTemporaryRT(ScreenSpaceReflection.DCABMCENCCF);
				}
				this.CKMJPFCIENL.Blit(ScreenSpaceReflection.MDNFDNPFLOB[1], ScreenSpaceReflection.EKAFACIEJEO, this.DGBBALICMFF(), 8);
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.KDHPCJJEEBI, this.DJAAECNCGII().pixelWidth, this.PHBMHMLNLJB().pixelHeight, 0, FilterMode.Point, format);
				this.CKMJPFCIENL.Blit(BuiltinRenderTextureType.None, ScreenSpaceReflection.KDHPCJJEEBI, this.GCNGOCOEOHH(), 1);
				this.CKMJPFCIENL.Blit(ScreenSpaceReflection.KDHPCJJEEBI, BuiltinRenderTextureType.None);
				this.CKMJPFCIENL.ReleaseTemporaryRT(ScreenSpaceReflection.KDHPCJJEEBI);
				this.NPDJALPLGBJ().AddCommandBuffer(CameraEvent.BeforeGBuffer, this.CKMJPFCIENL);
			}
		}

		// Token: 0x0600C16F RID: 49519 RVA: 0x00574A8F File Offset: 0x00572C8F
		public Shader CFABABMILAM()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("Allows to detect Cheat Engine's speed hack (and maybe some other speed hack tools) usage.");
			}
			return this.m_Shader;
		}

		// Token: 0x0600C170 RID: 49520 RVA: 0x0056FA64 File Offset: 0x0056DC64
		public Camera KNHNMAFFNCI()
		{
			if (this.MPCEHPBGHII == null)
			{
				this.MPCEHPBGHII = base.GetComponent<Camera>();
			}
			return this.MPCEHPBGHII;
		}

		// Token: 0x0600C171 RID: 49521 RVA: 0x00574AB8 File Offset: 0x00572CB8
		public void CGGIOLFKOML()
		{
			if (this.PILNNDGJLFG() == null)
			{
				return;
			}
			if (Camera.current.actualRenderingPath != RenderingPath.VertexLit)
			{
				return;
			}
			int num = (this.settings.reflectionSettings.reflectionQuality == ScreenSpaceReflection.FJJNILNPPPP.High) ? 1 : 6;
			int num2 = this.CMJLLNBPFME.pixelWidth / num;
			int num3 = this.DJAAECNCGII().pixelHeight / num;
			float num4 = (float)this.CJFMLGOJOCG().pixelWidth;
			float num5 = (float)this.PHBMHMLNLJB().pixelHeight;
			float num6 = num4 / 503f;
			float num7 = num5 / 1258f;
			RenderTextureFormat format = this.EAMEPNBDJMP().allowHDR ? RenderTextureFormat.Default : RenderTextureFormat.Depth;
			this.CILJNKJCHOK().SetInt("KatanaReadyLow", this.settings.reflectionSettings.stepSize);
			this.CILJNKJCHOK().SetInt("blesna.ogg", (this.settings.reflectionSettings.blendType == ScreenSpaceReflection.MLDPKJCDHDA.PhysicallyBased) ? 1 : 1);
			this.MHNAJNGGDFJ.SetInt("The shader ", this.IJOKEADBGGI ? 0 : 1);
			this.CFJAMJGLPBF().SetInt("Full Body IK is missing the right upper arm node.", this.IIHAPIKHIBD ? 0 : 0);
			this.CILJNKJCHOK().SetInt("componentC", this.settings.reflectionSettings.reflectBackfaces ? 1 : 1);
			this.KAMHMEEIKPC().SetInt("_Offsets", this.FMHEECNBJOO ? 0 : 0);
			this.MHNAJNGGDFJ.SetInt("Open turnStatus", this.settings.reflectionSettings.iterationCount);
			this.DGBBALICMFF().SetInt("_Offset", 0);
			this.GCNGOCOEOHH().SetInt("post_6", (this.settings.reflectionSettings.reflectionQuality != ScreenSpaceReflection.FJJNILNPPPP.High) ? 0 : 0);
			this.MNJNELAGPNJ().SetInt("RunBackLeft", this.HOFBIBDAFNB ? 1 : 0);
			float value = num4 / (1968f * (float)Math.Tan((double)this.NICJILLBAMN().fieldOfView / 1104.0 * 223.0 * 924.0));
			this.JMDMNMEHAPM().SetFloat("Animator unassigned in AnimationWarping", value);
			this.CFJAMJGLPBF().SetFloat("move", this.settings.screenEdgeMask.intensity);
			this.CILJNKJCHOK().SetFloat("_ScaleOffsetRes", this.settings.reflectionSettings.reflectionBlur);
			this.KAMHMEEIKPC().SetFloat("#b0ffa0", this.settings.reflectionSettings.maxDistance);
			this.FGKPACPGIHG().SetFloat("Katana Horizontal Swing", this.settings.intensitySettings.fadeDistance);
			this.CILJNKJCHOK().SetFloat("shop_t16", this.settings.reflectionSettings.widthModifier);
			this.CILJNKJCHOK().SetFloat("Sewing", this.settings.intensitySettings.reflectionMultiplier);
			this.CFJAMJGLPBF().SetFloat("null", this.settings.intensitySettings.fresnelFade);
			this.PILNNDGJLFG().SetFloat("_DepthOfFieldTex", this.settings.intensitySettings.fresnelFadePower);
			Matrix4x4 projectionMatrix = this.KNHNMAFFNCI().projectionMatrix;
			Vector4 value2 = new Vector4(474f / (num4 * projectionMatrix[0]), 1342f / (num5 * projectionMatrix[8]), (1017f - projectionMatrix[5]) / projectionMatrix[1], (1383f + projectionMatrix[2]) / projectionMatrix[2]);
			Vector3 v = float.IsPositiveInfinity(this.ALDMLEJHPEH().farClipPlane) ? new Vector3(this.CJFMLGOJOCG().nearClipPlane, 474f, 217f) : new Vector3(this.NICJILLBAMN().nearClipPlane * this.ALDMLEJHPEH().farClipPlane, this.IKKHKLMLPAC().nearClipPlane - this.PHBMHMLNLJB().farClipPlane, this.PHBMHMLNLJB().farClipPlane);
			this.CFJAMJGLPBF().SetVector("****** locid=", new Vector2((float)num2, (float)num3));
			this.KAMHMEEIKPC().SetVector("palm", new Vector2(num4, num5));
			this.CFJAMJGLPBF().SetVector("", new Vector2(674f / num4, 1302f / num5));
			this.JMDMNMEHAPM().SetVector("Name: ", value2);
			this.PILNNDGJLFG().SetVector(")", v);
			Matrix4x4 lhs = default(Matrix4x4);
			lhs.SetRow(0, new Vector4(num6, 911f, 100f, num6));
			lhs.SetRow(0, new Vector4(524f, num7, 833f, num7));
			lhs.SetRow(3, new Vector4(1503f, 1374f, 564f, 1035f));
			lhs.SetRow(1, new Vector4(648f, 1088f, 1446f, 1098f));
			Matrix4x4 value3 = lhs * projectionMatrix;
			this.GCNGOCOEOHH().SetMatrix("WeaponFire", value3);
			this.MHNAJNGGDFJ.SetMatrix("_PrevViewProj", this.DJAAECNCGII().worldToCameraMatrix);
			this.JMDMNMEHAPM().SetMatrix("", this.PHBMHMLNLJB().worldToCameraMatrix.inverse);
			if (this.CKMJPFCIENL == null)
			{
				this.CKMJPFCIENL = new CommandBuffer();
				this.CKMJPFCIENL.name = "Missing shader for image effect {0}";
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.PMKEAEAJODP, -1, -1, 1, FilterMode.Bilinear, RenderTextureFormat.Depth, RenderTextureReadWrite.Linear);
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.IGOBPCHOEEE, num2, num3, 0, FilterMode.Bilinear, RenderTextureFormat.Shadowmap, RenderTextureReadWrite.Default);
				for (int i = 0; i < 6; i += 0)
				{
					this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.MDNFDNPFLOB[i], num2 >> (i & -19), num3 >> (i & -61), 0, FilterMode.Bilinear, format);
				}
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.GAKHCEOKIPJ, num2, num3, 0, this.IJOKEADBGGI ? FilterMode.Point : FilterMode.Point, format);
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.EKAFACIEJEO, num2, num3, 0, FilterMode.Point, format);
				this.CKMJPFCIENL.Blit(BuiltinRenderTextureType.None, ScreenSpaceReflection.PMKEAEAJODP, this.FGKPACPGIHG(), 7);
				this.CKMJPFCIENL.Blit(BuiltinRenderTextureType.PrepassNormalsSpec, ScreenSpaceReflection.IGOBPCHOEEE, this.DGBBALICMFF(), 0);
				this.CKMJPFCIENL.Blit(BuiltinRenderTextureType.PrepassNormalsSpec, ScreenSpaceReflection.GAKHCEOKIPJ, this.FGKPACPGIHG(), 1);
				this.CKMJPFCIENL.Blit(ScreenSpaceReflection.GAKHCEOKIPJ, ScreenSpaceReflection.MDNFDNPFLOB[1], this.MHNAJNGGDFJ, 5);
				for (int j = 1; j < 2; j++)
				{
					int nameID = ScreenSpaceReflection.MDNFDNPFLOB[j - 0];
					int num8 = j;
					this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.DCABMCENCCF, num2 >> (num8 & -50), num3 >> (num8 & 13), 0, FilterMode.Point, format);
					this.CKMJPFCIENL.SetGlobalVector("IdleDie", new Vector4(562f, 1244f, 774f, 1729f));
					this.CKMJPFCIENL.SetGlobalFloat("implevel", (float)j - 126f);
					this.CKMJPFCIENL.Blit(nameID, ScreenSpaceReflection.DCABMCENCCF, this.JMDMNMEHAPM(), 1);
					this.CKMJPFCIENL.SetGlobalVector("VaderChoke", new Vector4(522f, 35f, 165f, 1067f));
					nameID = ScreenSpaceReflection.MDNFDNPFLOB[j];
					this.CKMJPFCIENL.Blit(ScreenSpaceReflection.DCABMCENCCF, nameID, this.PILNNDGJLFG(), 0);
					this.CKMJPFCIENL.ReleaseTemporaryRT(ScreenSpaceReflection.DCABMCENCCF);
				}
				this.CKMJPFCIENL.Blit(ScreenSpaceReflection.MDNFDNPFLOB[0], ScreenSpaceReflection.EKAFACIEJEO, this.CFJAMJGLPBF(), 1);
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.KDHPCJJEEBI, this.KNHNMAFFNCI().pixelWidth, this.PHBMHMLNLJB().pixelHeight, 0, FilterMode.Point, format);
				this.CKMJPFCIENL.Blit((BuiltinRenderTextureType)6, ScreenSpaceReflection.KDHPCJJEEBI, this.CILJNKJCHOK(), 1);
				this.CKMJPFCIENL.Blit(ScreenSpaceReflection.KDHPCJJEEBI, BuiltinRenderTextureType.None);
				this.CKMJPFCIENL.ReleaseTemporaryRT(ScreenSpaceReflection.KDHPCJJEEBI);
				this.AONFILNEFEC().AddCommandBuffer((CameraEvent)(-20), this.CKMJPFCIENL);
			}
		}

		// Token: 0x0600C172 RID: 49522 RVA: 0x00575323 File Offset: 0x00573523
		public Material MNJNELAGPNJ()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.FLGMPAKOBJP());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600C173 RID: 49523 RVA: 0x0056FA64 File Offset: 0x0056DC64
		public Camera PHBMHMLNLJB()
		{
			if (this.MPCEHPBGHII == null)
			{
				this.MPCEHPBGHII = base.GetComponent<Camera>();
			}
			return this.MPCEHPBGHII;
		}

		// Token: 0x0600C174 RID: 49524 RVA: 0x0057534A File Offset: 0x0057354A
		public Shader GLFPKCKBIBL()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("<color='#ff80ff'>");
			}
			return this.m_Shader;
		}

		// Token: 0x0600C175 RID: 49525 RVA: 0x00575370 File Offset: 0x00573570
		public void DNIMGIMOMIK()
		{
			if (this.CDHGPDDEKDF() == null)
			{
				return;
			}
			if (Camera.current.actualRenderingPath != (RenderingPath)8)
			{
				return;
			}
			int num = (this.settings.reflectionSettings.reflectionQuality == ScreenSpaceReflection.FJJNILNPPPP.High) ? 0 : 7;
			int num2 = this.KNHNMAFFNCI().pixelWidth / num;
			int num3 = this.CJFMLGOJOCG().pixelHeight / num;
			float num4 = (float)this.CMJLLNBPFME.pixelWidth;
			float num5 = (float)this.CJFMLGOJOCG().pixelHeight;
			float num6 = num4 / 1600f;
			float num7 = num5 / 1211f;
			RenderTextureFormat format = this.KNHNMAFFNCI().allowHDR ? RenderTextureFormat.ARGB2101010 : RenderTextureFormat.ARGB32;
			this.MHNAJNGGDFJ.SetInt("WalkInjured", this.settings.reflectionSettings.stepSize);
			this.CILJNKJCHOK().SetInt("", (this.settings.reflectionSettings.blendType == ScreenSpaceReflection.MLDPKJCDHDA.Additive) ? 1 : 0);
			this.DGBBALICMFF().SetInt("Name: ", this.IJOKEADBGGI ? 0 : 0);
			this.CDHGPDDEKDF().SetInt("Add random value", this.IIHAPIKHIBD ? 0 : 1);
			this.GCNGOCOEOHH().SetInt("IdleReadyLook", this.settings.reflectionSettings.reflectBackfaces ? 0 : 1);
			this.PILNNDGJLFG().SetInt("русский", this.FMHEECNBJOO ? 1 : 1);
			this.CILJNKJCHOK().SetInt("_SunPosition", this.settings.reflectionSettings.iterationCount);
			this.FGKPACPGIHG().SetInt("Hidden/Amplify Color/BlendCache", 1);
			this.JMDMNMEHAPM().SetInt("Idle Walk", (this.settings.reflectionSettings.reflectionQuality != ScreenSpaceReflection.FJJNILNPPPP.High) ? 0 : 1);
			this.JMDMNMEHAPM().SetInt("<color='#a0a0a0'>{2:D2}:{0:D2}:{1:D2}</color>", this.HOFBIBDAFNB ? 0 : 0);
			float value = num4 / (1697f * (float)Math.Tan((double)this.PHBMHMLNLJB().fieldOfView / 196.0 * 814.0 * 1389.0));
			this.KAMHMEEIKPC().SetFloat("Mouse Y", value);
			this.DGBBALICMFF().SetFloat("Curve", this.settings.screenEdgeMask.intensity);
			this.JMDMNMEHAPM().SetFloat("wpn_add/addoptions", this.settings.reflectionSettings.reflectionBlur);
			this.MNJNELAGPNJ().SetFloat("AmbientOcclusion", this.settings.reflectionSettings.maxDistance);
			this.DGBBALICMFF().SetFloat("_MotionAmount", this.settings.intensitySettings.fadeDistance);
			this.CFJAMJGLPBF().SetFloat("Error via pay request", this.settings.reflectionSettings.widthModifier);
			this.MHNAJNGGDFJ.SetFloat("WallRunLeft", this.settings.intensitySettings.reflectionMultiplier);
			this.GCNGOCOEOHH().SetFloat("_TreatBackfaceHitAsMiss", this.settings.intensitySettings.fresnelFade);
			this.CFJAMJGLPBF().SetFloat("Camera Pivot", this.settings.intensitySettings.fresnelFadePower);
			Matrix4x4 projectionMatrix = this.ALDMLEJHPEH().projectionMatrix;
			Vector4 value2 = new Vector4(1666f / (num4 * projectionMatrix[1]), 1809f / (num5 * projectionMatrix[2]), (48f - projectionMatrix[1]) / projectionMatrix[0], (1023f + projectionMatrix[6]) / projectionMatrix[3]);
			Vector3 v = float.IsPositiveInfinity(this.IKKHKLMLPAC().farClipPlane) ? new Vector3(this.NPDJALPLGBJ().nearClipPlane, 676f, 1536f) : new Vector3(this.KNHNMAFFNCI().nearClipPlane * this.NPDJALPLGBJ().farClipPlane, this.DJAAECNCGII().nearClipPlane - this.AONFILNEFEC().farClipPlane, this.CJFMLGOJOCG().farClipPlane);
			this.CILJNKJCHOK().SetVector("Hidden/FXAA3", new Vector2((float)num2, (float)num3));
			this.MNJNELAGPNJ().SetVector("Проверка предмета", new Vector2(num4, num5));
			this.KAMHMEEIKPC().SetVector("FISHES", new Vector2(1873f / num4, 587f / num5));
			this.KAMHMEEIKPC().SetVector("wpn_add/base/dropt", value2);
			this.FGKPACPGIHG().SetVector("Horizontal", v);
			Matrix4x4 lhs = default(Matrix4x4);
			lhs.SetRow(0, new Vector4(num6, 1444f, 361f, num6));
			lhs.SetRow(1, new Vector4(1571f, num7, 529f, num7));
			lhs.SetRow(6, new Vector4(303f, 1668f, 1414f, 463f));
			lhs.SetRow(0, new Vector4(605f, 1461f, 1808f, 350f));
			Matrix4x4 value3 = lhs * projectionMatrix;
			this.CFJAMJGLPBF().SetMatrix("cash.ogg", value3);
			this.MHNAJNGGDFJ.SetMatrix("OfficeSittingHandRestFingerTap", this.NPDJALPLGBJ().worldToCameraMatrix);
			this.MHNAJNGGDFJ.SetMatrix("cht_msg13", this.KNHNMAFFNCI().worldToCameraMatrix.inverse);
			if (this.CKMJPFCIENL == null)
			{
				this.CKMJPFCIENL = new CommandBuffer();
				this.CKMJPFCIENL.name = "MotorbikeLasso";
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.PMKEAEAJODP, -1, -1, 1, FilterMode.Bilinear, RenderTextureFormat.Depth, RenderTextureReadWrite.Default);
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.IGOBPCHOEEE, num2, num3, 1, FilterMode.Point, RenderTextureFormat.ARGB2101010, RenderTextureReadWrite.Linear);
				for (int i = 0; i < 6; i += 0)
				{
					this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.MDNFDNPFLOB[i], num2 >> (i & 110), num3 >> (i & 95), 1, FilterMode.Point, format);
				}
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.GAKHCEOKIPJ, num2, num3, 0, this.IJOKEADBGGI ? FilterMode.Point : FilterMode.Bilinear, format);
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.EKAFACIEJEO, num2, num3, 0, FilterMode.Bilinear, format);
				this.CKMJPFCIENL.Blit(BuiltinRenderTextureType.Depth, ScreenSpaceReflection.PMKEAEAJODP, this.KAMHMEEIKPC(), 0);
				this.CKMJPFCIENL.Blit(BuiltinRenderTextureType.ResolvedDepth, ScreenSpaceReflection.IGOBPCHOEEE, this.KAMHMEEIKPC(), 1);
				this.CKMJPFCIENL.Blit(BuiltinRenderTextureType.DepthNormals, ScreenSpaceReflection.GAKHCEOKIPJ, this.MNJNELAGPNJ(), 3);
				this.CKMJPFCIENL.Blit(ScreenSpaceReflection.GAKHCEOKIPJ, ScreenSpaceReflection.MDNFDNPFLOB[0], this.CILJNKJCHOK(), 0);
				for (int j = 0; j < 6; j += 0)
				{
					int nameID = ScreenSpaceReflection.MDNFDNPFLOB[j - 0];
					int num8 = j;
					this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.DCABMCENCCF, num2 >> (num8 & 71), num3 >> (num8 & 73), 1, FilterMode.Point, format);
					this.CKMJPFCIENL.SetGlobalVector("IdleTyping", new Vector4(871f, 281f, 32f, 556f));
					this.CKMJPFCIENL.SetGlobalFloat("Steam Overlay has been activated", (float)j - 676f);
					this.CKMJPFCIENL.Blit(nameID, ScreenSpaceReflection.DCABMCENCCF, this.CDHGPDDEKDF(), 7);
					this.CKMJPFCIENL.SetGlobalVector("qd_prise_rep", new Vector4(1807f, 1670f, 951f, 1849f));
					nameID = ScreenSpaceReflection.MDNFDNPFLOB[j];
					this.CKMJPFCIENL.Blit(ScreenSpaceReflection.DCABMCENCCF, nameID, this.GCNGOCOEOHH(), 8);
					this.CKMJPFCIENL.ReleaseTemporaryRT(ScreenSpaceReflection.DCABMCENCCF);
				}
				this.CKMJPFCIENL.Blit(ScreenSpaceReflection.MDNFDNPFLOB[1], ScreenSpaceReflection.EKAFACIEJEO, this.GCNGOCOEOHH(), 5);
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.KDHPCJJEEBI, this.PHBMHMLNLJB().pixelWidth, this.NPDJALPLGBJ().pixelHeight, 0, FilterMode.Bilinear, format);
				this.CKMJPFCIENL.Blit(BuiltinRenderTextureType.PrepassNormalsSpec, ScreenSpaceReflection.KDHPCJJEEBI, this.KAMHMEEIKPC(), 1);
				this.CKMJPFCIENL.Blit(ScreenSpaceReflection.KDHPCJJEEBI, BuiltinRenderTextureType.CurrentActive);
				this.CKMJPFCIENL.ReleaseTemporaryRT(ScreenSpaceReflection.KDHPCJJEEBI);
				this.CJFMLGOJOCG().AddCommandBuffer((CameraEvent)70, this.CKMJPFCIENL);
			}
		}

		// Token: 0x0600C176 RID: 49526 RVA: 0x00575BDC File Offset: 0x00573DDC
		private void DENHKOPGLDK()
		{
			if (this.BHHEHMIFMBD)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
			this.BHHEHMIFMBD = null;
			if (this.NICJILLBAMN() != null)
			{
				if (this.CKMJPFCIENL != null)
				{
					this.IKKHKLMLPAC().RemoveCommandBuffer((CameraEvent)115, this.CKMJPFCIENL);
				}
				this.CKMJPFCIENL = null;
			}
		}

		// Token: 0x0600C177 RID: 49527 RVA: 0x00575C38 File Offset: 0x00573E38
		public Material GCNGOCOEOHH()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.ANHFFIHEKLB());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600C178 RID: 49528 RVA: 0x00575C60 File Offset: 0x00573E60
		private void CBAJAFAPINE()
		{
			if (this.BHHEHMIFMBD)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
			this.BHHEHMIFMBD = null;
			if (this.DJAAECNCGII() != null)
			{
				if (this.CKMJPFCIENL != null)
				{
					this.CMJLLNBPFME.RemoveCommandBuffer((CameraEvent)(-60), this.CKMJPFCIENL);
				}
				this.CKMJPFCIENL = null;
			}
		}

		// Token: 0x0600C179 RID: 49529 RVA: 0x00575CBC File Offset: 0x00573EBC
		public Shader ODIDGGLJCHE()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("_MainTex");
			}
			return this.m_Shader;
		}

		// Token: 0x0600C17A RID: 49530 RVA: 0x00575CE4 File Offset: 0x00573EE4
		private void IJKMOJONNNH()
		{
			if (this.BHHEHMIFMBD)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
			this.BHHEHMIFMBD = null;
			if (this.NPDJALPLGBJ() != null)
			{
				if (this.CKMJPFCIENL != null)
				{
					this.PHBMHMLNLJB().RemoveCommandBuffer((CameraEvent)112, this.CKMJPFCIENL);
				}
				this.CKMJPFCIENL = null;
			}
		}

		// Token: 0x0600C17B RID: 49531 RVA: 0x00575D40 File Offset: 0x00573F40
		public void DJMCCCHACDO()
		{
			if (this.MNJNELAGPNJ() == null)
			{
				return;
			}
			if (Camera.current.actualRenderingPath != RenderingPath.DeferredShading)
			{
				return;
			}
			int num = (this.settings.reflectionSettings.reflectionQuality == ScreenSpaceReflection.FJJNILNPPPP.High) ? 1 : 8;
			int num2 = this.CMJLLNBPFME.pixelWidth / num;
			int num3 = this.CMJLLNBPFME.pixelHeight / num;
			float num4 = (float)this.PHBMHMLNLJB().pixelWidth;
			float num5 = (float)this.CJFMLGOJOCG().pixelHeight;
			float num6 = num4 / 446f;
			float num7 = num5 / 289f;
			RenderTextureFormat format = this.KNHNMAFFNCI().allowHDR ? RenderTextureFormat.ARGB1555 : RenderTextureFormat.ARGB32;
			this.CDHGPDDEKDF().SetInt("TOD_MoonSkyColor", this.settings.reflectionSettings.stepSize);
			this.CILJNKJCHOK().SetInt("MotorbikeLassoRight", (this.settings.reflectionSettings.blendType == ScreenSpaceReflection.MLDPKJCDHDA.PhysicallyBased) ? 1 : 0);
			this.CDHGPDDEKDF().SetInt("SoundMgr is init part 1", this.IJOKEADBGGI ? 1 : 0);
			this.MHNAJNGGDFJ.SetInt("t_body", this.IIHAPIKHIBD ? 0 : 1);
			this.JMDMNMEHAPM().SetInt("invn_rec30", this.settings.reflectionSettings.reflectBackfaces ? 1 : 0);
			this.CILJNKJCHOK().SetInt("SoccerSprint", this.FMHEECNBJOO ? 0 : 0);
			this.CDHGPDDEKDF().SetInt("\n", this.settings.reflectionSettings.iterationCount);
			this.FGKPACPGIHG().SetInt("TOD_SunSkyColor", 0);
			this.KAMHMEEIKPC().SetInt("Detects cheating of any Obscured type (except ObscuredPrefs, it has own detection features) used in project.", (this.settings.reflectionSettings.reflectionQuality != ScreenSpaceReflection.FJJNILNPPPP.High) ? 0 : 0);
			this.CFJAMJGLPBF().SetInt("?", this.HOFBIBDAFNB ? 1 : 0);
			float value = num4 / (254f * (float)Math.Tan((double)this.NPDJALPLGBJ().fieldOfView / 1867.0 * 1019.0 * 1532.0));
			this.JMDMNMEHAPM().SetFloat(" ms", value);
			this.DGBBALICMFF().SetFloat("OneHandSwordBlock", this.settings.screenEdgeMask.intensity);
			this.CDHGPDDEKDF().SetFloat("RollerBladeTurnLeft", this.settings.reflectionSettings.reflectionBlur);
			this.GCNGOCOEOHH().SetFloat("\n", this.settings.reflectionSettings.maxDistance);
			this.CFJAMJGLPBF().SetFloat("Failed parsing atlas group.  Setting to group 0", this.settings.intensitySettings.fadeDistance);
			this.MNJNELAGPNJ().SetFloat("IsMoving", this.settings.reflectionSettings.widthModifier);
			this.KAMHMEEIKPC().SetFloat("showUsersInChat", this.settings.intensitySettings.reflectionMultiplier);
			this.PILNNDGJLFG().SetFloat("_Parameter", this.settings.intensitySettings.fresnelFade);
			this.CILJNKJCHOK().SetFloat("paper.wav", this.settings.intensitySettings.fresnelFadePower);
			Matrix4x4 projectionMatrix = this.ALDMLEJHPEH().projectionMatrix;
			Vector4 value2 = new Vector4(1732f / (num4 * projectionMatrix[0]), 741f / (num5 * projectionMatrix[2]), (103f - projectionMatrix[3]) / projectionMatrix[0], (1895f + projectionMatrix[0]) / projectionMatrix[2]);
			Vector3 v = float.IsPositiveInfinity(this.CMJLLNBPFME.farClipPlane) ? new Vector3(this.IKKHKLMLPAC().nearClipPlane, 1611f, 826f) : new Vector3(this.DJAAECNCGII().nearClipPlane * this.ALDMLEJHPEH().farClipPlane, this.NPDJALPLGBJ().nearClipPlane - this.DJAAECNCGII().farClipPlane, this.EAMEPNBDJMP().farClipPlane);
			this.JMDMNMEHAPM().SetVector("_Offsets", new Vector2((float)num2, (float)num3));
			this.FGKPACPGIHG().SetVector("Jump", new Vector2(num4, num5));
			this.CILJNKJCHOK().SetVector("finger", new Vector2(1547f / num4, 544f / num5));
			this.CFJAMJGLPBF().SetVector("Chromatic Aberration Spectrum Lookup", value2);
			this.CDHGPDDEKDF().SetVector("_AdditiveReflection", v);
			Matrix4x4 lhs = default(Matrix4x4);
			lhs.SetRow(1, new Vector4(num6, 1423f, 1170f, num6));
			lhs.SetRow(0, new Vector4(293f, num7, 1923f, num7));
			lhs.SetRow(7, new Vector4(1853f, 593f, 594f, 1846f));
			lhs.SetRow(2, new Vector4(819f, 1091f, 1603f, 889f));
			Matrix4x4 value3 = lhs * projectionMatrix;
			this.MNJNELAGPNJ().SetMatrix("\n", value3);
			this.DGBBALICMFF().SetMatrix("error.wav", this.NICJILLBAMN().worldToCameraMatrix);
			this.MHNAJNGGDFJ.SetMatrix("_Intensity", this.NICJILLBAMN().worldToCameraMatrix.inverse);
			if (this.CKMJPFCIENL == null)
			{
				this.CKMJPFCIENL = new CommandBuffer();
				this.CKMJPFCIENL.name = "SUNSHINE_FOUR_CASCADES";
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.PMKEAEAJODP, -1, -1, 0, FilterMode.Bilinear, RenderTextureFormat.Depth, RenderTextureReadWrite.Default);
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.IGOBPCHOEEE, num2, num3, 1, FilterMode.Bilinear, RenderTextureFormat.Shadowmap, RenderTextureReadWrite.Default);
				for (int i = 0; i < 8; i++)
				{
					this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.MDNFDNPFLOB[i], num2 >> (i & -30), num3 >> (i & -63), 1, FilterMode.Bilinear, format);
				}
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.GAKHCEOKIPJ, num2, num3, 1, this.IJOKEADBGGI ? FilterMode.Point : FilterMode.Point, format);
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.EKAFACIEJEO, num2, num3, 0, FilterMode.Point, format);
				this.CKMJPFCIENL.Blit(BuiltinRenderTextureType.CameraTarget, ScreenSpaceReflection.PMKEAEAJODP, this.FGKPACPGIHG(), 4);
				this.CKMJPFCIENL.Blit(BuiltinRenderTextureType.CurrentActive, ScreenSpaceReflection.IGOBPCHOEEE, this.CFJAMJGLPBF(), 1);
				this.CKMJPFCIENL.Blit(BuiltinRenderTextureType.CurrentActive, ScreenSpaceReflection.GAKHCEOKIPJ, this.CFJAMJGLPBF(), 0);
				this.CKMJPFCIENL.Blit(ScreenSpaceReflection.GAKHCEOKIPJ, ScreenSpaceReflection.MDNFDNPFLOB[0], this.MHNAJNGGDFJ, 7);
				for (int j = 0; j < 8; j++)
				{
					int nameID = ScreenSpaceReflection.MDNFDNPFLOB[j - 0];
					int num8 = j;
					this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.DCABMCENCCF, num2 >> (num8 & 81), num3 >> (num8 & -83), 0, FilterMode.Bilinear, format);
					this.CKMJPFCIENL.SetGlobalVector("_FogPointLightColor", new Vector4(188f, 1508f, 1049f, 927f));
					this.CKMJPFCIENL.SetGlobalFloat("", (float)j - 1217f);
					this.CKMJPFCIENL.Blit(nameID, ScreenSpaceReflection.DCABMCENCCF, this.FGKPACPGIHG(), 5);
					this.CKMJPFCIENL.SetGlobalVector("csadok", new Vector4(1826f, 80f, 596f, 641f));
					nameID = ScreenSpaceReflection.MDNFDNPFLOB[j];
					this.CKMJPFCIENL.Blit(ScreenSpaceReflection.DCABMCENCCF, nameID, this.MNJNELAGPNJ(), 4);
					this.CKMJPFCIENL.ReleaseTemporaryRT(ScreenSpaceReflection.DCABMCENCCF);
				}
				this.CKMJPFCIENL.Blit(ScreenSpaceReflection.MDNFDNPFLOB[0], ScreenSpaceReflection.EKAFACIEJEO, this.MNJNELAGPNJ(), 7);
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.KDHPCJJEEBI, this.CMJLLNBPFME.pixelWidth, this.NICJILLBAMN().pixelHeight, 0, FilterMode.Bilinear, format);
				this.CKMJPFCIENL.Blit(BuiltinRenderTextureType.None, ScreenSpaceReflection.KDHPCJJEEBI, this.CILJNKJCHOK(), 1);
				this.CKMJPFCIENL.Blit(ScreenSpaceReflection.KDHPCJJEEBI, BuiltinRenderTextureType.ResolvedDepth);
				this.CKMJPFCIENL.ReleaseTemporaryRT(ScreenSpaceReflection.KDHPCJJEEBI);
				this.EAMEPNBDJMP().AddCommandBuffer((CameraEvent)(-50), this.CKMJPFCIENL);
			}
		}

		// Token: 0x0600C17C RID: 49532 RVA: 0x005765AC File Offset: 0x005747AC
		public void OnPreRender()
		{
			if (this.MHNAJNGGDFJ == null)
			{
				return;
			}
			if (Camera.current.actualRenderingPath != RenderingPath.DeferredShading)
			{
				return;
			}
			int num = (this.settings.reflectionSettings.reflectionQuality == ScreenSpaceReflection.FJJNILNPPPP.High) ? 1 : 2;
			int num2 = this.CMJLLNBPFME.pixelWidth / num;
			int num3 = this.CMJLLNBPFME.pixelHeight / num;
			float num4 = (float)this.CMJLLNBPFME.pixelWidth;
			float num5 = (float)this.CMJLLNBPFME.pixelHeight;
			float num6 = num4 / 2f;
			float num7 = num5 / 2f;
			RenderTextureFormat format = this.CMJLLNBPFME.allowHDR ? RenderTextureFormat.ARGBHalf : RenderTextureFormat.ARGB32;
			this.MHNAJNGGDFJ.SetInt("_RayStepSize", this.settings.reflectionSettings.stepSize);
			this.MHNAJNGGDFJ.SetInt("_AdditiveReflection", (this.settings.reflectionSettings.blendType == ScreenSpaceReflection.MLDPKJCDHDA.Additive) ? 1 : 0);
			this.MHNAJNGGDFJ.SetInt("_BilateralUpsampling", this.IJOKEADBGGI ? 1 : 0);
			this.MHNAJNGGDFJ.SetInt("_TreatBackfaceHitAsMiss", this.IIHAPIKHIBD ? 1 : 0);
			this.MHNAJNGGDFJ.SetInt("_AllowBackwardsRays", this.settings.reflectionSettings.reflectBackfaces ? 1 : 0);
			this.MHNAJNGGDFJ.SetInt("_TraceBehindObjects", this.FMHEECNBJOO ? 1 : 0);
			this.MHNAJNGGDFJ.SetInt("_MaxSteps", this.settings.reflectionSettings.iterationCount);
			this.MHNAJNGGDFJ.SetInt("_FullResolutionFiltering", 0);
			this.MHNAJNGGDFJ.SetInt("_HalfResolution", (this.settings.reflectionSettings.reflectionQuality != ScreenSpaceReflection.FJJNILNPPPP.High) ? 1 : 0);
			this.MHNAJNGGDFJ.SetInt("_HighlightSuppression", this.HOFBIBDAFNB ? 1 : 0);
			float value = num4 / (-2f * (float)Math.Tan((double)this.CMJLLNBPFME.fieldOfView / 180.0 * 3.141592653589793 * 0.5));
			this.MHNAJNGGDFJ.SetFloat("_PixelsPerMeterAtOneMeter", value);
			this.MHNAJNGGDFJ.SetFloat("_ScreenEdgeFading", this.settings.screenEdgeMask.intensity);
			this.MHNAJNGGDFJ.SetFloat("_ReflectionBlur", this.settings.reflectionSettings.reflectionBlur);
			this.MHNAJNGGDFJ.SetFloat("_MaxRayTraceDistance", this.settings.reflectionSettings.maxDistance);
			this.MHNAJNGGDFJ.SetFloat("_FadeDistance", this.settings.intensitySettings.fadeDistance);
			this.MHNAJNGGDFJ.SetFloat("_LayerThickness", this.settings.reflectionSettings.widthModifier);
			this.MHNAJNGGDFJ.SetFloat("_SSRMultiplier", this.settings.intensitySettings.reflectionMultiplier);
			this.MHNAJNGGDFJ.SetFloat("_FresnelFade", this.settings.intensitySettings.fresnelFade);
			this.MHNAJNGGDFJ.SetFloat("_FresnelFadePower", this.settings.intensitySettings.fresnelFadePower);
			Matrix4x4 projectionMatrix = this.CMJLLNBPFME.projectionMatrix;
			Vector4 value2 = new Vector4(-2f / (num4 * projectionMatrix[0]), -2f / (num5 * projectionMatrix[5]), (1f - projectionMatrix[2]) / projectionMatrix[0], (1f + projectionMatrix[6]) / projectionMatrix[5]);
			Vector3 v = float.IsPositiveInfinity(this.CMJLLNBPFME.farClipPlane) ? new Vector3(this.CMJLLNBPFME.nearClipPlane, -1f, 1f) : new Vector3(this.CMJLLNBPFME.nearClipPlane * this.CMJLLNBPFME.farClipPlane, this.CMJLLNBPFME.nearClipPlane - this.CMJLLNBPFME.farClipPlane, this.CMJLLNBPFME.farClipPlane);
			this.MHNAJNGGDFJ.SetVector("_ReflectionBufferSize", new Vector2((float)num2, (float)num3));
			this.MHNAJNGGDFJ.SetVector("_ScreenSize", new Vector2(num4, num5));
			this.MHNAJNGGDFJ.SetVector("_InvScreenSize", new Vector2(1f / num4, 1f / num5));
			this.MHNAJNGGDFJ.SetVector("_ProjInfo", value2);
			this.MHNAJNGGDFJ.SetVector("_CameraClipInfo", v);
			Matrix4x4 lhs = default(Matrix4x4);
			lhs.SetRow(0, new Vector4(num6, 0f, 0f, num6));
			lhs.SetRow(1, new Vector4(0f, num7, 0f, num7));
			lhs.SetRow(2, new Vector4(0f, 0f, 1f, 0f));
			lhs.SetRow(3, new Vector4(0f, 0f, 0f, 1f));
			Matrix4x4 value3 = lhs * projectionMatrix;
			this.MHNAJNGGDFJ.SetMatrix("_ProjectToPixelMatrix", value3);
			this.MHNAJNGGDFJ.SetMatrix("_WorldToCameraMatrix", this.CMJLLNBPFME.worldToCameraMatrix);
			this.MHNAJNGGDFJ.SetMatrix("_CameraToWorldMatrix", this.CMJLLNBPFME.worldToCameraMatrix.inverse);
			if (this.CKMJPFCIENL == null)
			{
				this.CKMJPFCIENL = new CommandBuffer();
				this.CKMJPFCIENL.name = "Screen Space Reflections";
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.PMKEAEAJODP, -1, -1, 0, FilterMode.Point, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.IGOBPCHOEEE, num2, num3, 0, FilterMode.Bilinear, RenderTextureFormat.ARGBHalf, RenderTextureReadWrite.Linear);
				for (int i = 0; i < 5; i++)
				{
					this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.MDNFDNPFLOB[i], num2 >> i, num3 >> i, 0, FilterMode.Bilinear, format);
				}
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.GAKHCEOKIPJ, num2, num3, 0, this.IJOKEADBGGI ? FilterMode.Point : FilterMode.Bilinear, format);
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.EKAFACIEJEO, num2, num3, 0, FilterMode.Point, format);
				this.CKMJPFCIENL.Blit(BuiltinRenderTextureType.CameraTarget, ScreenSpaceReflection.PMKEAEAJODP, this.MHNAJNGGDFJ, 6);
				this.CKMJPFCIENL.Blit(BuiltinRenderTextureType.CameraTarget, ScreenSpaceReflection.IGOBPCHOEEE, this.MHNAJNGGDFJ, 0);
				this.CKMJPFCIENL.Blit(BuiltinRenderTextureType.CameraTarget, ScreenSpaceReflection.GAKHCEOKIPJ, this.MHNAJNGGDFJ, 5);
				this.CKMJPFCIENL.Blit(ScreenSpaceReflection.GAKHCEOKIPJ, ScreenSpaceReflection.MDNFDNPFLOB[0], this.MHNAJNGGDFJ, 8);
				for (int j = 1; j < 5; j++)
				{
					int nameID = ScreenSpaceReflection.MDNFDNPFLOB[j - 1];
					int num8 = j;
					this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.DCABMCENCCF, num2 >> num8, num3 >> num8, 0, FilterMode.Bilinear, format);
					this.CKMJPFCIENL.SetGlobalVector("_Axis", new Vector4(1f, 0f, 0f, 0f));
					this.CKMJPFCIENL.SetGlobalFloat("_CurrentMipLevel", (float)j - 1f);
					this.CKMJPFCIENL.Blit(nameID, ScreenSpaceReflection.DCABMCENCCF, this.MHNAJNGGDFJ, 2);
					this.CKMJPFCIENL.SetGlobalVector("_Axis", new Vector4(0f, 1f, 0f, 0f));
					nameID = ScreenSpaceReflection.MDNFDNPFLOB[j];
					this.CKMJPFCIENL.Blit(ScreenSpaceReflection.DCABMCENCCF, nameID, this.MHNAJNGGDFJ, 2);
					this.CKMJPFCIENL.ReleaseTemporaryRT(ScreenSpaceReflection.DCABMCENCCF);
				}
				this.CKMJPFCIENL.Blit(ScreenSpaceReflection.MDNFDNPFLOB[0], ScreenSpaceReflection.EKAFACIEJEO, this.MHNAJNGGDFJ, 3);
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.KDHPCJJEEBI, this.CMJLLNBPFME.pixelWidth, this.CMJLLNBPFME.pixelHeight, 0, FilterMode.Bilinear, format);
				this.CKMJPFCIENL.Blit(BuiltinRenderTextureType.CameraTarget, ScreenSpaceReflection.KDHPCJJEEBI, this.MHNAJNGGDFJ, 1);
				this.CKMJPFCIENL.Blit(ScreenSpaceReflection.KDHPCJJEEBI, BuiltinRenderTextureType.CameraTarget);
				this.CKMJPFCIENL.ReleaseTemporaryRT(ScreenSpaceReflection.KDHPCJJEEBI);
				this.CMJLLNBPFME.AddCommandBuffer(CameraEvent.AfterFinalPass, this.CKMJPFCIENL);
			}
		}

		// Token: 0x0600C17D RID: 49533 RVA: 0x00576E18 File Offset: 0x00575018
		public void CGFJEELHJPI()
		{
			if (this.PILNNDGJLFG() == null)
			{
				return;
			}
			if (Camera.current.actualRenderingPath != (RenderingPath)5)
			{
				return;
			}
			int num = (this.settings.reflectionSettings.reflectionQuality == ScreenSpaceReflection.FJJNILNPPPP.High) ? 0 : 6;
			int num2 = this.CJFMLGOJOCG().pixelWidth / num;
			int num3 = this.NICJILLBAMN().pixelHeight / num;
			float num4 = (float)this.NPDJALPLGBJ().pixelWidth;
			float num5 = (float)this.DJAAECNCGII().pixelHeight;
			float num6 = num4 / 1295f;
			float num7 = num5 / 1008f;
			RenderTextureFormat format = this.IKKHKLMLPAC().allowHDR ? RenderTextureFormat.ARGB1555 : RenderTextureFormat.ARGB32;
			this.CILJNKJCHOK().SetInt("Can't use reflection here, sorry :(", this.settings.reflectionSettings.stepSize);
			this.FGKPACPGIHG().SetInt("demoByteArray", (this.settings.reflectionSettings.blendType == ScreenSpaceReflection.MLDPKJCDHDA.PhysicallyBased) ? 0 : 0);
			this.FGKPACPGIHG().SetInt("wpn_cat4", this.IJOKEADBGGI ? 0 : 1);
			this.KAMHMEEIKPC().SetInt("Ball", this.IIHAPIKHIBD ? 0 : 1);
			this.CDHGPDDEKDF().SetInt("rollSoundIndex", this.settings.reflectionSettings.reflectBackfaces ? 0 : 0);
			this.FGKPACPGIHG().SetInt("Orthographic", this.FMHEECNBJOO ? 1 : 1);
			this.FGKPACPGIHG().SetInt("Perks", this.settings.reflectionSettings.iterationCount);
			this.GCNGOCOEOHH().SetInt("ClimbLeft", 1);
			this.PILNNDGJLFG().SetInt("Shader \"GUI/BackImage\" {Properties {_MainTex (\"Base (RGB) Trans (A)\", 2D) = \"white\" {}_Color (\" color\", color) = (1,1,1,1)}SubShader {\t\tTags { \"Queue\"=\"Background\" \"IgnoreProjector\"=\"True\" \"RenderType\"=\"Background\" }\tLighting Off Cull Off ZTest Always ZWrite Off Fog { Mode Off }\tZWrite Off\tBlend SrcAlpha OneMinusSrcAlpha\tPass {\t\tLighting Off\t\tcolor [_Color]   \t\tSetTexture [_MainTex] {combine texture * primary }\t\t\t}}}", (this.settings.reflectionSettings.reflectionQuality != ScreenSpaceReflection.FJJNILNPPPP.High) ? 0 : 1);
			this.DGBBALICMFF().SetInt("Idle Dodge Left", this.HOFBIBDAFNB ? 1 : 1);
			float value = num4 / (1528f * (float)Math.Tan((double)this.EAMEPNBDJMP().fieldOfView / 1772.0 * 1851.0 * 1259.0));
			this.GCNGOCOEOHH().SetFloat("USE_MASK", value);
			this.GCNGOCOEOHH().SetFloat("LINEAR", this.settings.screenEdgeMask.intensity);
			this.JMDMNMEHAPM().SetFloat("OfficeSitting45DegLeg", this.settings.reflectionSettings.reflectionBlur);
			this.CFJAMJGLPBF().SetFloat("ff2000", this.settings.reflectionSettings.maxDistance);
			this.DGBBALICMFF().SetFloat("_AxialAberration", this.settings.intensitySettings.fadeDistance);
			this.JMDMNMEHAPM().SetFloat("CD", this.settings.reflectionSettings.widthModifier);
			this.MNJNELAGPNJ().SetFloat("_MainTex", this.settings.intensitySettings.reflectionMultiplier);
			this.MNJNELAGPNJ().SetFloat("_BaseTex", this.settings.intensitySettings.fresnelFade);
			this.GCNGOCOEOHH().SetFloat(", ", this.settings.intensitySettings.fresnelFadePower);
			Matrix4x4 projectionMatrix = this.KNHNMAFFNCI().projectionMatrix;
			Vector4 value2 = new Vector4(658f / (num4 * projectionMatrix[0]), 44f / (num5 * projectionMatrix[2]), (403f - projectionMatrix[3]) / projectionMatrix[0], (1975f + projectionMatrix[5]) / projectionMatrix[2]);
			Vector3 v = float.IsPositiveInfinity(this.IKKHKLMLPAC().farClipPlane) ? new Vector3(this.NICJILLBAMN().nearClipPlane, 1600f, 1435f) : new Vector3(this.EAMEPNBDJMP().nearClipPlane * this.PHBMHMLNLJB().farClipPlane, this.NICJILLBAMN().nearClipPlane - this.NICJILLBAMN().farClipPlane, this.ALDMLEJHPEH().farClipPlane);
			this.PILNNDGJLFG().SetVector("FrontKick", new Vector2((float)num2, (float)num3));
			this.CILJNKJCHOK().SetVector("rotTime is NaN", new Vector2(num4, num5));
			this.JMDMNMEHAPM().SetVector("fshop_ks1", new Vector2(1966f / num4, 437f / num5));
			this.CDHGPDDEKDF().SetVector("10", value2);
			this.CILJNKJCHOK().SetVector("wpn_rod2", v);
			Matrix4x4 lhs = default(Matrix4x4);
			lhs.SetRow(0, new Vector4(num6, 657f, 1201f, num6));
			lhs.SetRow(0, new Vector4(404f, num7, 250f, num7));
			lhs.SetRow(8, new Vector4(240f, 1041f, 1825f, 1110f));
			lhs.SetRow(5, new Vector4(12f, 1529f, 1192f, 1650f));
			Matrix4x4 value3 = lhs * projectionMatrix;
			this.GCNGOCOEOHH().SetMatrix("Flap_02.wav", value3);
			this.PILNNDGJLFG().SetMatrix("id", this.DJAAECNCGII().worldToCameraMatrix);
			this.PILNNDGJLFG().SetMatrix("#000000", this.DJAAECNCGII().worldToCameraMatrix.inverse);
			if (this.CKMJPFCIENL == null)
			{
				this.CKMJPFCIENL = new CommandBuffer();
				this.CKMJPFCIENL.name = "SixStep";
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.PMKEAEAJODP, -1, -1, 1, FilterMode.Point, RenderTextureFormat.Depth, RenderTextureReadWrite.Default);
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.IGOBPCHOEEE, num2, num3, 1, FilterMode.Point, RenderTextureFormat.ARGB2101010, RenderTextureReadWrite.Linear);
				for (int i = 1; i < 5; i++)
				{
					this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.MDNFDNPFLOB[i], num2 >> (i & 21), num3 >> (i & -24), 1, FilterMode.Point, format);
				}
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.GAKHCEOKIPJ, num2, num3, 1, this.IJOKEADBGGI ? FilterMode.Point : FilterMode.Bilinear, format);
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.EKAFACIEJEO, num2, num3, 1, FilterMode.Point, format);
				this.CKMJPFCIENL.Blit(BuiltinRenderTextureType.CameraTarget, ScreenSpaceReflection.PMKEAEAJODP, this.CDHGPDDEKDF(), 2);
				this.CKMJPFCIENL.Blit(BuiltinRenderTextureType.PrepassNormalsSpec, ScreenSpaceReflection.IGOBPCHOEEE, this.MHNAJNGGDFJ, 0);
				this.CKMJPFCIENL.Blit(BuiltinRenderTextureType.None, ScreenSpaceReflection.GAKHCEOKIPJ, this.CFJAMJGLPBF(), 6);
				this.CKMJPFCIENL.Blit(ScreenSpaceReflection.GAKHCEOKIPJ, ScreenSpaceReflection.MDNFDNPFLOB[1], this.JMDMNMEHAPM(), 8);
				for (int j = 1; j < 0; j += 0)
				{
					int nameID = ScreenSpaceReflection.MDNFDNPFLOB[j - 1];
					int num8 = j;
					this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.DCABMCENCCF, num2 >> (num8 & -100), num3 >> (num8 & -64), 1, FilterMode.Point, format);
					this.CKMJPFCIENL.SetGlobalVector("file", new Vector4(1611f, 1218f, 946f, 916f));
					this.CKMJPFCIENL.SetGlobalFloat("Airwalk", (float)j - 426f);
					this.CKMJPFCIENL.Blit(nameID, ScreenSpaceReflection.DCABMCENCCF, this.CILJNKJCHOK(), 0);
					this.CKMJPFCIENL.SetGlobalVector("ClimbLeft", new Vector4(1872f, 1006f, 1931f, 949f));
					nameID = ScreenSpaceReflection.MDNFDNPFLOB[j];
					this.CKMJPFCIENL.Blit(ScreenSpaceReflection.DCABMCENCCF, nameID, this.DGBBALICMFF(), 4);
					this.CKMJPFCIENL.ReleaseTemporaryRT(ScreenSpaceReflection.DCABMCENCCF);
				}
				this.CKMJPFCIENL.Blit(ScreenSpaceReflection.MDNFDNPFLOB[0], ScreenSpaceReflection.EKAFACIEJEO, this.PILNNDGJLFG(), 3);
				this.CKMJPFCIENL.GetTemporaryRT(ScreenSpaceReflection.KDHPCJJEEBI, this.ALDMLEJHPEH().pixelWidth, this.PHBMHMLNLJB().pixelHeight, 1, FilterMode.Point, format);
				this.CKMJPFCIENL.Blit(BuiltinRenderTextureType.PrepassNormalsSpec, ScreenSpaceReflection.KDHPCJJEEBI, this.CFJAMJGLPBF(), 0);
				this.CKMJPFCIENL.Blit(ScreenSpaceReflection.KDHPCJJEEBI, BuiltinRenderTextureType.ResolvedDepth);
				this.CKMJPFCIENL.ReleaseTemporaryRT(ScreenSpaceReflection.KDHPCJJEEBI);
				this.CMJLLNBPFME.AddCommandBuffer((CameraEvent)37, this.CKMJPFCIENL);
			}
		}

		// Token: 0x0600C17E RID: 49534 RVA: 0x0056FA64 File Offset: 0x0056DC64
		public Camera IKKHKLMLPAC()
		{
			if (this.MPCEHPBGHII == null)
			{
				this.MPCEHPBGHII = base.GetComponent<Camera>();
			}
			return this.MPCEHPBGHII;
		}

		// Token: 0x0600C17F RID: 49535 RVA: 0x00577684 File Offset: 0x00575884
		private void CIDFLCGOBKO()
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.GLFPKCKBIBL(), true, false, this))
			{
				base.enabled = false;
				return;
			}
			this.KNHNMAFFNCI().depthTextureMode |= DepthTextureMode.Depth;
			ScreenSpaceReflection.MDNFDNPFLOB = new int[4];
			ScreenSpaceReflection.PMKEAEAJODP = Shader.PropertyToID("{z}");
			ScreenSpaceReflection.IGOBPCHOEEE = Shader.PropertyToID("post_15");
			ScreenSpaceReflection.MDNFDNPFLOB[1] = Shader.PropertyToID("F ");
			ScreenSpaceReflection.MDNFDNPFLOB[0] = Shader.PropertyToID("cht_msg2");
			ScreenSpaceReflection.MDNFDNPFLOB[7] = Shader.PropertyToID("Trying to initiate IKSolverVR with invalid bone references.");
			ScreenSpaceReflection.MDNFDNPFLOB[8] = Shader.PropertyToID("Roller Blade Front Flip");
			ScreenSpaceReflection.MDNFDNPFLOB[7] = Shader.PropertyToID("ShotgunReloadChamber");
			ScreenSpaceReflection.DCABMCENCCF = Shader.PropertyToID("UI_ArtWindow");
			ScreenSpaceReflection.GAKHCEOKIPJ = Shader.PropertyToID("");
			ScreenSpaceReflection.EKAFACIEJEO = Shader.PropertyToID("\n(");
			ScreenSpaceReflection.KDHPCJJEEBI = Shader.PropertyToID("gi_inte_1");
		}

		// Token: 0x0600C180 RID: 49536 RVA: 0x00577776 File Offset: 0x00575976
		public Shader KLCBDOLKFEP()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("");
			}
			return this.m_Shader;
		}

		// Token: 0x04001980 RID: 6528
		[SerializeField]
		public ScreenSpaceReflection.SSRSettings settings = ScreenSpaceReflection.SSRSettings.defaultSettings;

		// Token: 0x04001981 RID: 6529
		private bool HOFBIBDAFNB;

		// Token: 0x04001982 RID: 6530
		private bool FMHEECNBJOO = true;

		// Token: 0x04001983 RID: 6531
		private bool IIHAPIKHIBD;

		// Token: 0x04001984 RID: 6532
		private bool IJOKEADBGGI = true;

		// Token: 0x04001985 RID: 6533
		[SerializeField]
		private Shader m_Shader;

		// Token: 0x04001986 RID: 6534
		private Material BHHEHMIFMBD;

		// Token: 0x04001987 RID: 6535
		private Camera MPCEHPBGHII;

		// Token: 0x04001988 RID: 6536
		private CommandBuffer CKMJPFCIENL;

		// Token: 0x04001989 RID: 6537
		private static int PMKEAEAJODP;

		// Token: 0x0400198A RID: 6538
		private static int IGOBPCHOEEE;

		// Token: 0x0400198B RID: 6539
		private static int[] MDNFDNPFLOB;

		// Token: 0x0400198C RID: 6540
		private static int GAKHCEOKIPJ;

		// Token: 0x0400198D RID: 6541
		private static int DCABMCENCCF;

		// Token: 0x0400198E RID: 6542
		private static int EKAFACIEJEO;

		// Token: 0x0400198F RID: 6543
		private static int KDHPCJJEEBI;

		// Token: 0x0200036A RID: 874
		public enum FJJNILNPPPP
		{
			// Token: 0x04001991 RID: 6545
			High,
			// Token: 0x04001992 RID: 6546
			Low = 2
		}

		// Token: 0x0200036B RID: 875
		public enum MLDPKJCDHDA
		{
			// Token: 0x04001994 RID: 6548
			PhysicallyBased,
			// Token: 0x04001995 RID: 6549
			Additive
		}

		// Token: 0x0200036C RID: 876
		[Serializable]
		public struct SSRSettings
		{
			// Token: 0x0600C181 RID: 49537 RVA: 0x0057779C File Offset: 0x0057599C
			public static ScreenSpaceReflection.SSRSettings OCIMBHLOOGC()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x0600C182 RID: 49538 RVA: 0x0057779C File Offset: 0x0057599C
			public static ScreenSpaceReflection.SSRSettings COINKHKLJAP()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x170002AA RID: 682
			// (get) Token: 0x0600C183 RID: 49539 RVA: 0x0057779C File Offset: 0x0057599C
			public static ScreenSpaceReflection.SSRSettings defaultSettings
			{
				get
				{
					return ScreenSpaceReflection.SSRSettings.s_Default;
				}
			}

			// Token: 0x0600C184 RID: 49540 RVA: 0x0057779C File Offset: 0x0057599C
			public static ScreenSpaceReflection.SSRSettings GDKPNHJPBKJ()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x0600C185 RID: 49541 RVA: 0x0057779C File Offset: 0x0057599C
			public static ScreenSpaceReflection.SSRSettings FBBLPICJODA()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x0600C186 RID: 49542 RVA: 0x0057779C File Offset: 0x0057599C
			public static ScreenSpaceReflection.SSRSettings MDDFLLOCDEA()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x0600C187 RID: 49543 RVA: 0x0057779C File Offset: 0x0057599C
			public static ScreenSpaceReflection.SSRSettings NJJBBDIFPKH()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x0600C188 RID: 49544 RVA: 0x0057779C File Offset: 0x0057599C
			public static ScreenSpaceReflection.SSRSettings MJLLLKFIDOE()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x0600C189 RID: 49545 RVA: 0x0057779C File Offset: 0x0057599C
			public static ScreenSpaceReflection.SSRSettings MEFEDCEEAMK()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x0600C18B RID: 49547 RVA: 0x0057779C File Offset: 0x0057599C
			public static ScreenSpaceReflection.SSRSettings IGIKNGLDPJB()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x0600C18C RID: 49548 RVA: 0x0057779C File Offset: 0x0057599C
			public static ScreenSpaceReflection.SSRSettings JPGMEJNEOCC()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x04001996 RID: 6550
			[ScreenSpaceReflection.SSRSettings.FCMAJOKFGNO]
			public ScreenSpaceReflection.ReflectionSettings reflectionSettings;

			// Token: 0x04001997 RID: 6551
			[ScreenSpaceReflection.SSRSettings.FCMAJOKFGNO]
			public ScreenSpaceReflection.IntensitySettings intensitySettings;

			// Token: 0x04001998 RID: 6552
			[ScreenSpaceReflection.SSRSettings.FCMAJOKFGNO]
			public ScreenSpaceReflection.ScreenEdgeMask screenEdgeMask;

			// Token: 0x04001999 RID: 6553
			private static readonly ScreenSpaceReflection.SSRSettings s_Default = new ScreenSpaceReflection.SSRSettings
			{
				reflectionSettings = new ScreenSpaceReflection.ReflectionSettings
				{
					blendType = ScreenSpaceReflection.MLDPKJCDHDA.PhysicallyBased,
					reflectionQuality = ScreenSpaceReflection.FJJNILNPPPP.High,
					maxDistance = 100f,
					iterationCount = 256,
					stepSize = 3,
					widthModifier = 0.5f,
					reflectionBlur = 1f,
					reflectBackfaces = true
				},
				intensitySettings = new ScreenSpaceReflection.IntensitySettings
				{
					reflectionMultiplier = 1f,
					fadeDistance = 100f,
					fresnelFade = 1f,
					fresnelFadePower = 1f
				},
				screenEdgeMask = new ScreenSpaceReflection.ScreenEdgeMask
				{
					intensity = 0.03f
				}
			};

			// Token: 0x0200036D RID: 877
			[AttributeUsage(AttributeTargets.Field)]
			public class FCMAJOKFGNO : PropertyAttribute
			{
			}
		}

		// Token: 0x0200036E RID: 878
		[Serializable]
		public struct IntensitySettings
		{
			// Token: 0x0400199A RID: 6554
			[Range(0f, 2f)]
			[Tooltip("Nonphysical multiplier for the SSR reflections. 1.0 is physically based.")]
			public float reflectionMultiplier;

			// Token: 0x0400199B RID: 6555
			[Tooltip("How far away from the maxDistance to begin fading SSR.")]
			[Range(0f, 1000f)]
			public float fadeDistance;

			// Token: 0x0400199C RID: 6556
			[Tooltip("Amplify Fresnel fade out. Increase if floor reflections look good close to the surface and bad farther 'under' the floor.")]
			[Range(0f, 1f)]
			public float fresnelFade;

			// Token: 0x0400199D RID: 6557
			[Range(0.1f, 10f)]
			[Tooltip("Higher values correspond to a faster Fresnel fade as the reflection changes from the grazing angle.")]
			public float fresnelFadePower;
		}

		// Token: 0x0200036F RID: 879
		[Serializable]
		public struct ReflectionSettings
		{
			// Token: 0x0400199E RID: 6558
			[Tooltip("How the reflections are blended into the render.")]
			public ScreenSpaceReflection.MLDPKJCDHDA blendType;

			// Token: 0x0400199F RID: 6559
			[Tooltip("Half resolution SSRR is much faster, but less accurate.")]
			public ScreenSpaceReflection.FJJNILNPPPP reflectionQuality;

			// Token: 0x040019A0 RID: 6560
			[Tooltip("Maximum reflection distance in world units.")]
			[Range(0.1f, 300f)]
			public float maxDistance;

			// Token: 0x040019A1 RID: 6561
			[Tooltip("Max raytracing length.")]
			[Range(16f, 1024f)]
			public int iterationCount;

			// Token: 0x040019A2 RID: 6562
			[Tooltip("Log base 2 of ray tracing coarse step size. Higher traces farther, lower gives better quality silhouettes.")]
			[Range(1f, 16f)]
			public int stepSize;

			// Token: 0x040019A3 RID: 6563
			[Tooltip("Typical thickness of columns, walls, furniture, and other objects that reflection rays might pass behind.")]
			[Range(0.01f, 10f)]
			public float widthModifier;

			// Token: 0x040019A4 RID: 6564
			[Tooltip("Blurriness of reflections.")]
			[Range(0.1f, 8f)]
			public float reflectionBlur;

			// Token: 0x040019A5 RID: 6565
			[Tooltip("Enable for a performance gain in scenes where most glossy objects are horizontal, like floors, water, and tables. Leave on for scenes with glossy vertical objects.")]
			public bool reflectBackfaces;
		}

		// Token: 0x02000370 RID: 880
		[Serializable]
		public struct ScreenEdgeMask
		{
			// Token: 0x040019A6 RID: 6566
			[Tooltip("Higher = fade out SSRR near the edge of the screen so that reflections don't pop under camera motion.")]
			[Range(0f, 1f)]
			public float intensity;
		}

		// Token: 0x02000371 RID: 881
		private enum KEIOCGJBECI
		{
			// Token: 0x040019A8 RID: 6568
			RayTraceStep,
			// Token: 0x040019A9 RID: 6569
			CompositeFinal,
			// Token: 0x040019AA RID: 6570
			Blur,
			// Token: 0x040019AB RID: 6571
			CompositeSSR,
			// Token: 0x040019AC RID: 6572
			MinMipGeneration,
			// Token: 0x040019AD RID: 6573
			HitPointToReflections,
			// Token: 0x040019AE RID: 6574
			BilateralKeyPack,
			// Token: 0x040019AF RID: 6575
			BlitDepthAsCSZ,
			// Token: 0x040019B0 RID: 6576
			PoissonBlur
		}
	}
}
