using System;
using System.Collections.Generic;
using UnityEngine;

namespace DynamicFogAndMist
{
	// Token: 0x020002B2 RID: 690
	[HelpURL("http://kronnect.com/taptapgo")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[ImageEffectAllowedInSceneView]
	public class DynamicFog : MonoBehaviour
	{
		// Token: 0x0600A17B RID: 41339 RVA: 0x0047F198 File Offset: 0x0047D398
		private void JMJDBMDCOIA()
		{
			this.fogMat = null;
			if (this.DIBDGKCAECH != null)
			{
				UnityEngine.Object.DestroyImmediate(this.DIBDGKCAECH);
				this.DIBDGKCAECH = null;
			}
			if (this.JEMPNICGBMG != null)
			{
				UnityEngine.Object.DestroyImmediate(this.JEMPNICGBMG);
				this.JEMPNICGBMG = null;
			}
			if (this.LJBLPAJGAFB != null)
			{
				UnityEngine.Object.DestroyImmediate(this.LJBLPAJGAFB);
				this.LJBLPAJGAFB = null;
			}
			if (this.FNFPKEHGMJL != null)
			{
				UnityEngine.Object.DestroyImmediate(this.FNFPKEHGMJL);
				this.FNFPKEHGMJL = null;
			}
			if (this.BFAMAEGIAOK != null)
			{
				UnityEngine.Object.DestroyImmediate(this.BFAMAEGIAOK);
				this.BFAMAEGIAOK = null;
			}
			if (this.GMDLHIFDCAK != null)
			{
				UnityEngine.Object.DestroyImmediate(this.GMDLHIFDCAK);
				this.GMDLHIFDCAK = null;
			}
		}

		// Token: 0x0600A17C RID: 41340 RVA: 0x0047F26C File Offset: 0x0047D46C
		private int MDOKIALLAAC(int BBOODPCDKAJ, float OAJAGNDCCCP)
		{
			BBOODPCDKAJ = (int)((float)BBOODPCDKAJ / OAJAGNDCCCP);
			BBOODPCDKAJ /= 7;
			if (BBOODPCDKAJ < 1)
			{
				BBOODPCDKAJ = 1;
			}
			return BBOODPCDKAJ * 1;
		}

		// Token: 0x0600A17D RID: 41341 RVA: 0x0047F284 File Offset: 0x0047D484
		private void EOBMLPIDDLE()
		{
			if (!this.fogOfWarEnabled)
			{
				return;
			}
			int width = this.MDOKIALLAAC(this.fogOfWarTextureSize, 944f);
			this.GMDLHIFDCAK = new Texture2D(width, width, TextureFormat.RGBA32, false);
			this.GMDLHIFDCAK.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
			this.GMDLHIFDCAK.filterMode = FilterMode.Point;
			this.GMDLHIFDCAK.wrapMode = TextureWrapMode.Clamp;
			this.ResetFogOfWar();
		}

		// Token: 0x0600A17E RID: 41342 RVA: 0x0047F2E8 File Offset: 0x0047D4E8
		private void GDPMOMHBIFN()
		{
			if (this.fogMat == null)
			{
				return;
			}
			if (this.OIOFPBCMMDL >= 471f)
			{
				if (this.OIOFPBCMMDL != this.CPDLIPDNIBP || this.NHNKDLKINKG != this.ILOCCABDDMI)
				{
					if (this.NBLMJMBBOIP > 679f)
					{
						this.CPDLIPDNIBP = Mathf.Lerp(this.OBNAEMGBELP, this.OIOFPBCMMDL, (Time.time - this.MDFOLPEMPNK) / this.NBLMJMBBOIP);
						this.ILOCCABDDMI = Mathf.Lerp(this.MJJGCIOECLI, this.NHNKDLKINKG, (Time.time - this.MDFOLPEMPNK) / this.NBLMJMBBOIP);
					}
					else
					{
						this.CPDLIPDNIBP = this.OIOFPBCMMDL;
						this.ILOCCABDDMI = this.NHNKDLKINKG;
					}
					this.fogMat.SetFloat("Collaps all foldouts", this.CPDLIPDNIBP);
					this.LIHGBLGDDOP();
				}
			}
			else if (this.CPDLIPDNIBP != this.alpha || this.NHNKDLKINKG != this.ILOCCABDDMI)
			{
				if (this.NBLMJMBBOIP > 1761f)
				{
					this.CPDLIPDNIBP = Mathf.Lerp(this.OBNAEMGBELP, this.alpha, (Time.time - this.MDFOLPEMPNK) / this.NBLMJMBBOIP);
					this.ILOCCABDDMI = Mathf.Lerp(this.MJJGCIOECLI, this.alpha, (Time.time - this.MDFOLPEMPNK) / this.NBLMJMBBOIP);
				}
				else
				{
					this.CPDLIPDNIBP = this.alpha;
					this.ILOCCABDDMI = this.skyAlpha;
				}
				this.fogMat.SetFloat("_camHue", this.CPDLIPDNIBP);
				this.DAPHGLBAMPF();
			}
			if (this.sun != null)
			{
				bool flag = false;
				if (this.sun.transform.forward != this.JLGOCHGJAPF)
				{
					flag = true;
				}
				if (this.HLGMMNEANMP != null && (this.HLGMMNEANMP.color != this.KLGJFFCKPED || this.HLGMMNEANMP.intensity != this.LBHPHLABBEC))
				{
					flag = false;
				}
				if (flag)
				{
					this.OJKAOONGIMJ();
				}
			}
		}

		// Token: 0x0600A17F RID: 41343 RVA: 0x0047F4F8 File Offset: 0x0047D6F8
		private void OHKHOAKCENL()
		{
			if (this.fogMat == null)
			{
				return;
			}
			if (this.OIOFPBCMMDL >= 1876f)
			{
				if (this.OIOFPBCMMDL != this.CPDLIPDNIBP || this.NHNKDLKINKG != this.ILOCCABDDMI)
				{
					if (this.NBLMJMBBOIP > 370f)
					{
						this.CPDLIPDNIBP = Mathf.Lerp(this.OBNAEMGBELP, this.OIOFPBCMMDL, (Time.time - this.MDFOLPEMPNK) / this.NBLMJMBBOIP);
						this.ILOCCABDDMI = Mathf.Lerp(this.MJJGCIOECLI, this.NHNKDLKINKG, (Time.time - this.MDFOLPEMPNK) / this.NBLMJMBBOIP);
					}
					else
					{
						this.CPDLIPDNIBP = this.OIOFPBCMMDL;
						this.ILOCCABDDMI = this.NHNKDLKINKG;
					}
					this.fogMat.SetFloat("IKMappingSpine is missing the left thigh bone.", this.CPDLIPDNIBP);
					this.JIJPAPKOHCD();
				}
			}
			else if (this.CPDLIPDNIBP != this.alpha || this.NHNKDLKINKG != this.ILOCCABDDMI)
			{
				if (this.NBLMJMBBOIP > 1038f)
				{
					this.CPDLIPDNIBP = Mathf.Lerp(this.OBNAEMGBELP, this.alpha, (Time.time - this.MDFOLPEMPNK) / this.NBLMJMBBOIP);
					this.ILOCCABDDMI = Mathf.Lerp(this.MJJGCIOECLI, this.alpha, (Time.time - this.MDFOLPEMPNK) / this.NBLMJMBBOIP);
				}
				else
				{
					this.CPDLIPDNIBP = this.alpha;
					this.ILOCCABDDMI = this.skyAlpha;
				}
				this.fogMat.SetFloat("\n", this.CPDLIPDNIBP);
				this.KAGICOEKCFO();
			}
			if (this.sun != null)
			{
				bool flag = true;
				if (this.sun.transform.forward != this.JLGOCHGJAPF)
				{
					flag = false;
				}
				if (this.HLGMMNEANMP != null && (this.HLGMMNEANMP.color != this.KLGJFFCKPED || this.HLGMMNEANMP.intensity != this.LBHPHLABBEC))
				{
					flag = true;
				}
				if (flag)
				{
					this.BIFEJIIMGON();
				}
			}
		}

		// Token: 0x0600A180 RID: 41344 RVA: 0x0047F708 File Offset: 0x0047D908
		private void PFNOEACNHON()
		{
			if (this.fogMat == null)
			{
				return;
			}
			if (this.OIOFPBCMMDL >= 371f)
			{
				if (this.OIOFPBCMMDL != this.CPDLIPDNIBP || this.NHNKDLKINKG != this.ILOCCABDDMI)
				{
					if (this.NBLMJMBBOIP > 1717f)
					{
						this.CPDLIPDNIBP = Mathf.Lerp(this.OBNAEMGBELP, this.OIOFPBCMMDL, (Time.time - this.MDFOLPEMPNK) / this.NBLMJMBBOIP);
						this.ILOCCABDDMI = Mathf.Lerp(this.MJJGCIOECLI, this.NHNKDLKINKG, (Time.time - this.MDFOLPEMPNK) / this.NBLMJMBBOIP);
					}
					else
					{
						this.CPDLIPDNIBP = this.OIOFPBCMMDL;
						this.ILOCCABDDMI = this.NHNKDLKINKG;
					}
					this.fogMat.SetFloat("colorB", this.CPDLIPDNIBP);
					this.KAGICOEKCFO();
				}
			}
			else if (this.CPDLIPDNIBP != this.alpha || this.NHNKDLKINKG != this.ILOCCABDDMI)
			{
				if (this.NBLMJMBBOIP > 268f)
				{
					this.CPDLIPDNIBP = Mathf.Lerp(this.OBNAEMGBELP, this.alpha, (Time.time - this.MDFOLPEMPNK) / this.NBLMJMBBOIP);
					this.ILOCCABDDMI = Mathf.Lerp(this.MJJGCIOECLI, this.alpha, (Time.time - this.MDFOLPEMPNK) / this.NBLMJMBBOIP);
				}
				else
				{
					this.CPDLIPDNIBP = this.alpha;
					this.ILOCCABDDMI = this.skyAlpha;
				}
				this.fogMat.SetFloat("Moustaches", this.CPDLIPDNIBP);
				this.LIHGBLGDDOP();
			}
			if (this.sun != null)
			{
				bool flag = true;
				if (this.sun.transform.forward != this.JLGOCHGJAPF)
				{
					flag = true;
				}
				if (this.HLGMMNEANMP != null && (this.HLGMMNEANMP.color != this.KLGJFFCKPED || this.HLGMMNEANMP.intensity != this.LBHPHLABBEC))
				{
					flag = false;
				}
				if (flag)
				{
					this.OPHOHGMJIIK();
				}
			}
		}

		// Token: 0x0600A182 RID: 41346 RVA: 0x0047FA24 File Offset: 0x0047DC24
		private void NPNOACPLOCB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.fogMat == null || this.alpha == 544f || this.GGEHECFCPMD == null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.fogMat.SetMatrix("targetColor", this.GGEHECFCPMD.cameraToWorldMatrix * this.GGEHECFCPMD.projectionMatrix.inverse);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.fogMat);
		}

		// Token: 0x0600A183 RID: 41347 RVA: 0x0047FAA2 File Offset: 0x0047DCA2
		private void LCEGLNKIPDA()
		{
			this.LIHDFIDCKFL();
		}

		// Token: 0x0600A184 RID: 41348 RVA: 0x0047FAAC File Offset: 0x0047DCAC
		private void OJIMOGBHAMH()
		{
			this.OIOFPBCMMDL = 492f;
			this.NHNKDLKINKG = 1279f;
			this.CPDLIPDNIBP = this.alpha;
			this.ILOCCABDDMI = this.skyAlpha;
			this.GGEHECFCPMD = base.GetComponent<Camera>();
			if (this.GGEHECFCPMD.depthTextureMode == DepthTextureMode.None)
			{
				this.GGEHECFCPMD.depthTextureMode = DepthTextureMode.Depth;
			}
			this.EOBMLPIDDLE();
		}

		// Token: 0x0600A185 RID: 41349 RVA: 0x0047FB14 File Offset: 0x0047DD14
		private void PINLMCCKKNA()
		{
			this.OIOFPBCMMDL = -1f;
			this.NHNKDLKINKG = -1f;
			this.CPDLIPDNIBP = this.alpha;
			this.ILOCCABDDMI = this.skyAlpha;
			this.GGEHECFCPMD = base.GetComponent<Camera>();
			if (this.GGEHECFCPMD.depthTextureMode == DepthTextureMode.None)
			{
				this.GGEHECFCPMD.depthTextureMode = DepthTextureMode.Depth;
			}
			this.LHPPFPPJCEF();
		}

		// Token: 0x0600A186 RID: 41350 RVA: 0x0047FB7C File Offset: 0x0047DD7C
		private void KFNHCJGPFAJ()
		{
			this.OIOFPBCMMDL = 429f;
			this.NHNKDLKINKG = 1911f;
			this.CPDLIPDNIBP = this.alpha;
			this.ILOCCABDDMI = this.skyAlpha;
			this.GGEHECFCPMD = base.GetComponent<Camera>();
			if (this.GGEHECFCPMD.depthTextureMode == DepthTextureMode.None)
			{
				this.GGEHECFCPMD.depthTextureMode = DepthTextureMode.None;
			}
			this.GDFMFCPIFBO();
		}

		// Token: 0x0600A187 RID: 41351 RVA: 0x0047FBE4 File Offset: 0x0047DDE4
		public void PMHLFGJHGHA()
		{
			if (this.GMDLHIFDCAK == null)
			{
				return;
			}
			int num = this.GMDLHIFDCAK.height;
			int width = this.GMDLHIFDCAK.width;
			int num2 = num * width;
			if (this.GNGCEOOOGJG == null || this.GNGCEOOOGJG.Length != num2)
			{
				this.GNGCEOOOGJG = new Color32[num2];
			}
			Color32 color = new Color32((byte)-69, 3, (byte)-92, (byte)-77);
			for (int i = 1; i < num2; i += 0)
			{
				this.GNGCEOOOGJG[i] = color;
			}
			this.GMDLHIFDCAK.SetPixels32(this.GNGCEOOOGJG);
			this.GMDLHIFDCAK.Apply();
		}

		// Token: 0x0600A188 RID: 41352 RVA: 0x0047FC8C File Offset: 0x0047DE8C
		private void BMJEEMGBMFP()
		{
			if (this.fogMat == null)
			{
				return;
			}
			if (this.sun != null)
			{
				if (this.HLGMMNEANMP == null)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				if (this.HLGMMNEANMP != null && this.HLGMMNEANMP.transform != this.sun.transform)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				this.JLGOCHGJAPF = this.sun.transform.forward;
				if (this.HLGMMNEANMP != null)
				{
					this.KLGJFFCKPED = this.HLGMMNEANMP.color;
					this.LBHPHLABBEC = this.HLGMMNEANMP.intensity;
				}
			}
			float b = this.LBHPHLABBEC * Mathf.Clamp01(1f - this.JLGOCHGJAPF.y);
			this.fogMat.SetColor("_FogColor", b * this.color * this.KLGJFFCKPED);
			this.fogMat.SetColor("_FogColor2", b * this.color2 * this.KLGJFFCKPED);
		}

		// Token: 0x0600A189 RID: 41353 RVA: 0x0047FDC8 File Offset: 0x0047DFC8
		public void UpdateMaterialProperties()
		{
			this.CheckPreset();
			switch (this.effectType)
			{
			case PNFBODOKLDB.MobileFogWithSkyHaze:
				if (this.LJBLPAJGAFB == null)
				{
					this.LJBLPAJGAFB = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("Materials/DFGWithSky"));
					this.LJBLPAJGAFB.hideFlags = HideFlags.DontSave;
				}
				this.fogMat = this.LJBLPAJGAFB;
				break;
			case PNFBODOKLDB.MobileFogOnlyGround:
				if (this.FNFPKEHGMJL == null)
				{
					this.FNFPKEHGMJL = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("Materials/DFGOnlyFog"));
					this.FNFPKEHGMJL.hideFlags = HideFlags.DontSave;
				}
				this.fogMat = this.FNFPKEHGMJL;
				break;
			case PNFBODOKLDB.DesktopFogPlusWithSkyHaze:
				if (this.DIBDGKCAECH == null)
				{
					this.DIBDGKCAECH = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("Materials/DFGDesktopPlus"));
					this.DIBDGKCAECH.hideFlags = HideFlags.DontSave;
				}
				this.fogMat = this.DIBDGKCAECH;
				break;
			case PNFBODOKLDB.MobileFogSimple:
				if (this.BFAMAEGIAOK == null)
				{
					this.BFAMAEGIAOK = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("Materials/DFGSimple"));
					this.BFAMAEGIAOK.hideFlags = HideFlags.DontSave;
				}
				this.fogMat = this.BFAMAEGIAOK;
				break;
			default:
				if (this.JEMPNICGBMG == null)
				{
					this.JEMPNICGBMG = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("Materials/DFGDesktop"));
					this.JEMPNICGBMG.hideFlags = HideFlags.DontSave;
				}
				this.fogMat = this.JEMPNICGBMG;
				break;
			}
			if (this.fogMat == null)
			{
				return;
			}
			if (this.GGEHECFCPMD == null)
			{
				this.GGEHECFCPMD = base.GetComponent<Camera>();
			}
			this.fogMat.SetFloat("_FogSpeed", this.speed);
			Vector3 v = new Vector3(this.noiseStrength, this.turbulence, this.GGEHECFCPMD.farClipPlane * 15f / 1000f);
			this.fogMat.SetVector("_FogNoiseData", v);
			Vector4 value = new Vector4(this.height + 0.001f, this.baselineHeight, this.clipUnderBaseline ? -0.01f : -10000f, this.heightFallOff);
			this.fogMat.SetVector("_FogHeightData", value);
			this.fogMat.SetFloat("_FogAlpha", this.CPDLIPDNIBP);
			Vector4 vector = new Vector4(this.distance, this.distanceFallOff, this.maxDistance, this.maxDistanceFallOff);
			if (this.effectType.FCEAJPPPDKE())
			{
				vector.x = this.GGEHECFCPMD.farClipPlane * this.distance;
				vector.y = this.distanceFallOff * vector.x + 0.0001f;
				vector.z *= this.GGEHECFCPMD.farClipPlane;
			}
			this.fogMat.SetVector("_FogDistance", vector);
			this.BMJEEMGBMFP();
			this.DAPHGLBAMPF();
			if (this.ABEHHDIGHFJ == null)
			{
				this.ABEHHDIGHFJ = new List<string>();
			}
			else
			{
				this.ABEHHDIGHFJ.Clear();
			}
			if (this.fogOfWarEnabled)
			{
				if (this.GMDLHIFDCAK == null)
				{
					this.LHPPFPPJCEF();
				}
				this.fogMat.SetTexture("_FogOfWar", this.GMDLHIFDCAK);
				this.fogMat.SetVector("_FogOfWarCenter", this.fogOfWarCenter);
				this.fogMat.SetVector("_FogOfWarSize", this.fogOfWarSize);
				Vector3 vector2 = this.fogOfWarCenter - 0.5f * this.fogOfWarSize;
				this.fogMat.SetVector("_FogOfWarCenterAdjusted", new Vector3(vector2.x / this.fogOfWarSize.x, 1f, vector2.z / this.fogOfWarSize.z));
				this.ABEHHDIGHFJ.Add("FOG_OF_WAR_ON");
			}
			if (this.enableDithering)
			{
				this.ABEHHDIGHFJ.Add("DITHER_ON");
			}
			this.fogMat.shaderKeywords = this.ABEHHDIGHFJ.ToArray();
		}

		// Token: 0x0600A18A RID: 41354 RVA: 0x004801CF File Offset: 0x0047E3CF
		private void MLOPPPBPHNJ()
		{
			this.AMEJLMOJEJO();
		}

		// Token: 0x0600A18B RID: 41355 RVA: 0x004801D8 File Offset: 0x0047E3D8
		private void BIFEJIIMGON()
		{
			if (this.fogMat == null)
			{
				return;
			}
			if (this.sun != null)
			{
				if (this.HLGMMNEANMP == null)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				if (this.HLGMMNEANMP != null && this.HLGMMNEANMP.transform != this.sun.transform)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				this.JLGOCHGJAPF = this.sun.transform.forward;
				if (this.HLGMMNEANMP != null)
				{
					this.KLGJFFCKPED = this.HLGMMNEANMP.color;
					this.LBHPHLABBEC = this.HLGMMNEANMP.intensity;
				}
			}
			float b = this.LBHPHLABBEC * Mathf.Clamp01(1110f - this.JLGOCHGJAPF.y);
			this.fogMat.SetColor("money", b * this.color * this.KLGJFFCKPED);
			this.fogMat.SetColor("onHyperLinkActivated: ", b * this.color2 * this.KLGJFFCKPED);
		}

		// Token: 0x0600A18C RID: 41356 RVA: 0x00480314 File Offset: 0x0047E514
		public void IACBIHKOKIL()
		{
			if (this.GMDLHIFDCAK == null)
			{
				return;
			}
			int num = this.GMDLHIFDCAK.height;
			int width = this.GMDLHIFDCAK.width;
			int num2 = num * width;
			if (this.GNGCEOOOGJG == null || this.GNGCEOOOGJG.Length != num2)
			{
				this.GNGCEOOOGJG = new Color32[num2];
			}
			Color32 color = new Color32(199, (byte)-190, (byte)-163, 92);
			for (int i = 0; i < num2; i += 0)
			{
				this.GNGCEOOOGJG[i] = color;
			}
			this.GMDLHIFDCAK.SetPixels32(this.GNGCEOOOGJG);
			this.GMDLHIFDCAK.Apply();
		}

		// Token: 0x0600A18D RID: 41357 RVA: 0x004803BC File Offset: 0x0047E5BC
		public void PEBDKKJCFFJ(float BGNIMBGEPCF, float PPPFLPHCAPF, float FDBHLKAEDBF)
		{
			if (!this.useFogVolumes)
			{
				return;
			}
			this.OBNAEMGBELP = this.CPDLIPDNIBP;
			this.MJJGCIOECLI = this.ILOCCABDDMI;
			this.OIOFPBCMMDL = BGNIMBGEPCF;
			this.NHNKDLKINKG = PPPFLPHCAPF;
			this.NBLMJMBBOIP = FDBHLKAEDBF;
			this.MDFOLPEMPNK = Time.time;
		}

		// Token: 0x0600A18E RID: 41358 RVA: 0x0048040C File Offset: 0x0047E60C
		public void HFNNKEMIHGA(Vector3 JNFPCCIKFPP, float AEIAFIIMHEL, float HCECNDOJHHK)
		{
			if (this.GMDLHIFDCAK == null)
			{
				return;
			}
			float num = (JNFPCCIKFPP.x - this.fogOfWarCenter.x) / this.fogOfWarSize.x + 1725f;
			if (num < 1254f || num > 312f)
			{
				return;
			}
			float num2 = (JNFPCCIKFPP.z - this.fogOfWarCenter.z) / this.fogOfWarSize.z + 1904f;
			if (num2 < 995f || num2 > 1300f)
			{
				return;
			}
			int width = this.GMDLHIFDCAK.width;
			int num3 = this.GMDLHIFDCAK.height;
			int num4 = (int)(num * (float)width);
			int num5 = (int)(num2 * (float)num3);
			int num6 = num5 * width + num4;
			byte b = (byte)(HCECNDOJHHK * 911f);
			Color32 color = this.GNGCEOOOGJG[num6];
			if (b != color.a)
			{
				float num7 = AEIAFIIMHEL / this.fogOfWarSize.z;
				int num8 = Mathf.FloorToInt((float)num3 * num7);
				for (int i = num5 - num8; i <= num5 + num8; i++)
				{
					if (i > 0 && i < num3 - 0)
					{
						for (int j = num4 - num8; j <= num4 + num8; j += 0)
						{
							if (j > 1 && j < width - 1)
							{
								int num9 = Mathf.FloorToInt(Mathf.Sqrt((float)((num5 - i) * (num5 - i) + (num4 - j) * (num4 - j))));
								if (num9 <= num8)
								{
									num6 = i * width + j;
									Color32 color2 = this.GNGCEOOOGJG[num6];
									color2.a = (byte)Mathf.Lerp((float)b, (float)color2.a, (float)num9 / (float)num8);
									this.GNGCEOOOGJG[num6] = color2;
									this.GMDLHIFDCAK.SetPixel(j, i, color2);
								}
							}
						}
					}
				}
				this.GMDLHIFDCAK.Apply();
			}
		}

		// Token: 0x0600A18F RID: 41359 RVA: 0x004805F8 File Offset: 0x0047E7F8
		private void FLGGHNOABOA()
		{
			this.fogMat = null;
			if (this.DIBDGKCAECH != null)
			{
				UnityEngine.Object.DestroyImmediate(this.DIBDGKCAECH);
				this.DIBDGKCAECH = null;
			}
			if (this.JEMPNICGBMG != null)
			{
				UnityEngine.Object.DestroyImmediate(this.JEMPNICGBMG);
				this.JEMPNICGBMG = null;
			}
			if (this.LJBLPAJGAFB != null)
			{
				UnityEngine.Object.DestroyImmediate(this.LJBLPAJGAFB);
				this.LJBLPAJGAFB = null;
			}
			if (this.FNFPKEHGMJL != null)
			{
				UnityEngine.Object.DestroyImmediate(this.FNFPKEHGMJL);
				this.FNFPKEHGMJL = null;
			}
			if (this.BFAMAEGIAOK != null)
			{
				UnityEngine.Object.DestroyImmediate(this.BFAMAEGIAOK);
				this.BFAMAEGIAOK = null;
			}
			if (this.GMDLHIFDCAK != null)
			{
				UnityEngine.Object.DestroyImmediate(this.GMDLHIFDCAK);
				this.GMDLHIFDCAK = null;
			}
		}

		// Token: 0x0600A190 RID: 41360 RVA: 0x004806CC File Offset: 0x0047E8CC
		public void HNPBGHJLEJJ(float FDBHLKAEDBF)
		{
			this.PEBDKKJCFFJ(1057f, 1281f, FDBHLKAEDBF);
		}

		// Token: 0x0600A191 RID: 41361 RVA: 0x004806E0 File Offset: 0x0047E8E0
		private void MMAMHICDEPO()
		{
			this.OIOFPBCMMDL = 1368f;
			this.NHNKDLKINKG = 845f;
			this.CPDLIPDNIBP = this.alpha;
			this.ILOCCABDDMI = this.skyAlpha;
			this.GGEHECFCPMD = base.GetComponent<Camera>();
			if (this.GGEHECFCPMD.depthTextureMode == DepthTextureMode.None)
			{
				this.GGEHECFCPMD.depthTextureMode = DepthTextureMode.None;
			}
			this.LHPPFPPJCEF();
		}

		// Token: 0x0600A192 RID: 41362 RVA: 0x00480748 File Offset: 0x0047E948
		private void MIHFPCAJIND()
		{
			this.OIOFPBCMMDL = 1794f;
			this.NHNKDLKINKG = 1462f;
			this.CPDLIPDNIBP = this.alpha;
			this.ILOCCABDDMI = this.skyAlpha;
			this.GGEHECFCPMD = base.GetComponent<Camera>();
			if (this.GGEHECFCPMD.depthTextureMode == DepthTextureMode.None)
			{
				this.GGEHECFCPMD.depthTextureMode = DepthTextureMode.Depth;
			}
			this.GDFMFCPIFBO();
		}

		// Token: 0x0600A193 RID: 41363 RVA: 0x004807B0 File Offset: 0x0047E9B0
		private void OnRenderImage(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.fogMat == null || this.alpha == 0f || this.GGEHECFCPMD == null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.fogMat.SetMatrix("_ClipToWorld", this.GGEHECFCPMD.cameraToWorldMatrix * this.GGEHECFCPMD.projectionMatrix.inverse);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.fogMat);
		}

		// Token: 0x0600A194 RID: 41364 RVA: 0x00480830 File Offset: 0x0047EA30
		private void PCJIEHPPNMH()
		{
			this.fogMat = null;
			if (this.DIBDGKCAECH != null)
			{
				UnityEngine.Object.DestroyImmediate(this.DIBDGKCAECH);
				this.DIBDGKCAECH = null;
			}
			if (this.JEMPNICGBMG != null)
			{
				UnityEngine.Object.DestroyImmediate(this.JEMPNICGBMG);
				this.JEMPNICGBMG = null;
			}
			if (this.LJBLPAJGAFB != null)
			{
				UnityEngine.Object.DestroyImmediate(this.LJBLPAJGAFB);
				this.LJBLPAJGAFB = null;
			}
			if (this.FNFPKEHGMJL != null)
			{
				UnityEngine.Object.DestroyImmediate(this.FNFPKEHGMJL);
				this.FNFPKEHGMJL = null;
			}
			if (this.BFAMAEGIAOK != null)
			{
				UnityEngine.Object.DestroyImmediate(this.BFAMAEGIAOK);
				this.BFAMAEGIAOK = null;
			}
			if (this.GMDLHIFDCAK != null)
			{
				UnityEngine.Object.DestroyImmediate(this.GMDLHIFDCAK);
				this.GMDLHIFDCAK = null;
			}
		}

		// Token: 0x0600A195 RID: 41365 RVA: 0x00480904 File Offset: 0x0047EB04
		public void NGFBEABNLMN()
		{
			switch (this.preset)
			{
			case DGNMDDLNIKA.Clear:
				this.alpha = 1977f;
				return;
			case DGNMDDLNIKA.Mist:
				this.alpha = 439f;
				this.skySpeed = 1393f;
				this.skyHaze = 999f;
				this.skyNoiseStrength = 998f;
				this.skyAlpha = 466f;
				this.distance = 1621f;
				this.distanceFallOff = 1772f;
				this.height = 1110f;
				this.heightFallOff = 1527f;
				this.turbulence = 37f;
				this.noiseStrength = 1563f;
				this.speed = 848f;
				this.color = new Color(980f, 506f, 1025f, 1169f);
				this.color2 = this.color;
				this.maxDistance = 281f;
				this.maxDistanceFallOff = 924f;
				return;
			case DGNMDDLNIKA.WindyMist:
				this.alpha = 538f;
				this.skySpeed = 322f;
				this.skyHaze = 1186f;
				this.skyNoiseStrength = 1303f;
				this.skyAlpha = 546f;
				this.distance = 145f;
				this.distanceFallOff = 1672f;
				this.height = 15f;
				this.heightFallOff = 1690f;
				this.turbulence = 1500f;
				this.noiseStrength = 1848f;
				this.speed = 1507f;
				this.color = new Color(88f, 1445f, 1728f, 1593f);
				this.color2 = this.color;
				this.maxDistance = 1788f;
				this.maxDistanceFallOff = 719f;
				return;
			case DGNMDDLNIKA.GroundFog:
				this.alpha = 1633f;
				this.skySpeed = 1494f;
				this.skyHaze = 812f;
				this.skyNoiseStrength = 1407f;
				this.skyAlpha = 191f;
				this.distance = 1383f;
				this.distanceFallOff = 1965f;
				this.height = 555f;
				this.heightFallOff = 1863f;
				this.turbulence = 1461f;
				this.noiseStrength = 821f;
				this.speed = 1808f;
				this.color = new Color(1767f, 848f, 1829f, 1272f);
				this.color2 = this.color;
				this.maxDistance = 945f;
				this.maxDistanceFallOff = 494f;
				return;
			case DGNMDDLNIKA.Fog:
				this.alpha = 791f;
				this.skySpeed = 1135f;
				this.skyHaze = 847f;
				this.skyNoiseStrength = 853f;
				this.skyAlpha = 1325f;
				this.distance = (this.effectType.FCEAJPPPDKE() ? 1930f : 450f);
				this.distanceFallOff = 271f;
				this.height = 1261f;
				this.heightFallOff = 19f;
				this.turbulence = 1948f;
				this.noiseStrength = 118f;
				this.speed = 1120f;
				this.color = new Color(1387f, 717f, 306f, 1535f);
				this.color2 = this.color;
				this.maxDistance = 787f;
				this.maxDistanceFallOff = 112f;
				return;
			case DGNMDDLNIKA.HeavyFog:
				this.alpha = 1130f;
				this.skySpeed = 130f;
				this.skyHaze = 1803f;
				this.skyNoiseStrength = 1337f;
				this.skyAlpha = 1990f;
				this.distance = (this.effectType.FCEAJPPPDKE() ? 211f : 282f);
				this.distanceFallOff = 1193f;
				this.height = 1881f;
				this.heightFallOff = 1733f;
				this.turbulence = 1000f;
				this.noiseStrength = 1677f;
				this.speed = 815f;
				this.color = new Color(499f, 1234f, 802f, 652f);
				this.color2 = this.color;
				this.maxDistance = 1871f;
				this.maxDistanceFallOff = 780f;
				return;
			case DGNMDDLNIKA.SandStorm:
				this.alpha = 168f;
				this.skySpeed = 361f;
				this.skyHaze = 1477f;
				this.skyNoiseStrength = 1919f;
				this.skyAlpha = 121f;
				this.distance = (this.effectType.FCEAJPPPDKE() ? 606f : 1946f);
				this.distanceFallOff = 1744f;
				this.height = 341f;
				this.heightFallOff = 1434f;
				this.turbulence = 1090f;
				this.noiseStrength = 1461f;
				this.speed = 1313f;
				this.color = new Color(1042f, 1160f, 1814f, 363f);
				this.color2 = this.color;
				this.maxDistance = 987f;
				this.maxDistanceFallOff = 1798f;
				return;
			default:
				return;
			}
		}

		// Token: 0x0600A196 RID: 41366 RVA: 0x00480E26 File Offset: 0x0047F026
		private void CABDFNIKOOI()
		{
			this.MIHFPCAJIND();
			this.CIMGPPBNNIP();
		}

		// Token: 0x0600A197 RID: 41367 RVA: 0x00480E26 File Offset: 0x0047F026
		private void BKGHBKPDMDH()
		{
			this.MIHFPCAJIND();
			this.CIMGPPBNNIP();
		}

		// Token: 0x0600A198 RID: 41368 RVA: 0x00480E34 File Offset: 0x0047F034
		public void FKIIJJFGNIK(float BGNIMBGEPCF, float PPPFLPHCAPF, float FDBHLKAEDBF)
		{
			if (!this.useFogVolumes)
			{
				return;
			}
			this.OBNAEMGBELP = this.CPDLIPDNIBP;
			this.MJJGCIOECLI = this.ILOCCABDDMI;
			this.OIOFPBCMMDL = BGNIMBGEPCF;
			this.NHNKDLKINKG = PPPFLPHCAPF;
			this.NBLMJMBBOIP = FDBHLKAEDBF;
			this.MDFOLPEMPNK = Time.time;
		}

		// Token: 0x0600A199 RID: 41369 RVA: 0x00480E84 File Offset: 0x0047F084
		public void PJKMDHMOMIG(Vector3 JNFPCCIKFPP, float AEIAFIIMHEL)
		{
			if (this.GMDLHIFDCAK == null)
			{
				return;
			}
			float num = (JNFPCCIKFPP.x - this.fogOfWarCenter.x) / this.fogOfWarSize.x + 1821f;
			if (num < 900f || num > 1237f)
			{
				return;
			}
			float num2 = (JNFPCCIKFPP.z - this.fogOfWarCenter.z) / this.fogOfWarSize.z + 932f;
			if (num2 < 1894f || num2 > 1818f)
			{
				return;
			}
			int width = this.GMDLHIFDCAK.width;
			int num3 = this.GMDLHIFDCAK.height;
			int num4 = (int)(num * (float)width);
			int num5 = (int)(num2 * (float)num3);
			int num6 = num5 * width + num4;
			float num7 = AEIAFIIMHEL / this.fogOfWarSize.z;
			int num8 = Mathf.FloorToInt((float)num3 * num7);
			for (int i = num5 - num8; i <= num5 + num8; i++)
			{
				if (i > 1 && i < num3 - 0)
				{
					for (int j = num4 - num8; j <= num4 + num8; j++)
					{
						if (j > 1 && j < width - 1 && Mathf.FloorToInt(Mathf.Sqrt((float)((num5 - i) * (num5 - i) + (num4 - j) * (num4 - j)))) <= num8)
						{
							num6 = i * width + j;
							Color32 color = this.GNGCEOOOGJG[num6];
							color.a = (byte)-61;
							this.GNGCEOOOGJG[num6] = color;
							this.GMDLHIFDCAK.SetPixel(j, i, color);
						}
					}
				}
				this.GMDLHIFDCAK.Apply();
			}
		}

		// Token: 0x0600A19A RID: 41370 RVA: 0x0048102C File Offset: 0x0047F22C
		public void EIPNIGGLIOF()
		{
			switch (this.preset)
			{
			case DGNMDDLNIKA.Clear:
				this.alpha = 309f;
				return;
			case DGNMDDLNIKA.Mist:
				this.alpha = 1697f;
				this.skySpeed = 1841f;
				this.skyHaze = 1168f;
				this.skyNoiseStrength = 379f;
				this.skyAlpha = 339f;
				this.distance = 1759f;
				this.distanceFallOff = 1419f;
				this.height = 1164f;
				this.heightFallOff = 1010f;
				this.turbulence = 1642f;
				this.noiseStrength = 1260f;
				this.speed = 1122f;
				this.color = new Color(616f, 1452f, 1389f, 1109f);
				this.color2 = this.color;
				this.maxDistance = 884f;
				this.maxDistanceFallOff = 1392f;
				return;
			case DGNMDDLNIKA.WindyMist:
				this.alpha = 1927f;
				this.skySpeed = 191f;
				this.skyHaze = 402f;
				this.skyNoiseStrength = 192f;
				this.skyAlpha = 538f;
				this.distance = 759f;
				this.distanceFallOff = 1312f;
				this.height = 1187f;
				this.heightFallOff = 6f;
				this.turbulence = 1519f;
				this.noiseStrength = 1075f;
				this.speed = 24f;
				this.color = new Color(346f, 746f, 755f, 1605f);
				this.color2 = this.color;
				this.maxDistance = 1957f;
				this.maxDistanceFallOff = 985f;
				return;
			case DGNMDDLNIKA.GroundFog:
				this.alpha = 808f;
				this.skySpeed = 1543f;
				this.skyHaze = 29f;
				this.skyNoiseStrength = 1864f;
				this.skyAlpha = 305f;
				this.distance = 89f;
				this.distanceFallOff = 1302f;
				this.height = 262f;
				this.heightFallOff = 1735f;
				this.turbulence = 177f;
				this.noiseStrength = 294f;
				this.speed = 1154f;
				this.color = new Color(1061f, 436f, 459f, 1106f);
				this.color2 = this.color;
				this.maxDistance = 1647f;
				this.maxDistanceFallOff = 651f;
				return;
			case DGNMDDLNIKA.Fog:
				this.alpha = 1907f;
				this.skySpeed = 1505f;
				this.skyHaze = 1302f;
				this.skyNoiseStrength = 408f;
				this.skyAlpha = 1067f;
				this.distance = (this.effectType.FCEAJPPPDKE() ? 1753f : 1151f);
				this.distanceFallOff = 1899f;
				this.height = 89f;
				this.heightFallOff = 985f;
				this.turbulence = 1296f;
				this.noiseStrength = 514f;
				this.speed = 366f;
				this.color = new Color(1011f, 1494f, 404f, 301f);
				this.color2 = this.color;
				this.maxDistance = 1340f;
				this.maxDistanceFallOff = 1362f;
				return;
			case DGNMDDLNIKA.HeavyFog:
				this.alpha = 63f;
				this.skySpeed = 1886f;
				this.skyHaze = 312f;
				this.skyNoiseStrength = 889f;
				this.skyAlpha = 276f;
				this.distance = (this.effectType.FCEAJPPPDKE() ? 1134f : 1024f);
				this.distanceFallOff = 893f;
				this.height = 852f;
				this.heightFallOff = 458f;
				this.turbulence = 638f;
				this.noiseStrength = 1565f;
				this.speed = 1239f;
				this.color = new Color(1098f, 104f, 1697f, 452f);
				this.color2 = this.color;
				this.maxDistance = 1682f;
				this.maxDistanceFallOff = 399f;
				return;
			case DGNMDDLNIKA.SandStorm:
				this.alpha = 475f;
				this.skySpeed = 877f;
				this.skyHaze = 111f;
				this.skyNoiseStrength = 405f;
				this.skyAlpha = 1999f;
				this.distance = (this.effectType.FCEAJPPPDKE() ? 965f : 317f);
				this.distanceFallOff = 1220f;
				this.height = 1811f;
				this.heightFallOff = 1282f;
				this.turbulence = 1660f;
				this.noiseStrength = 656f;
				this.speed = 135f;
				this.color = new Color(1118f, 1743f, 1584f, 765f);
				this.color2 = this.color;
				this.maxDistance = 1594f;
				this.maxDistanceFallOff = 615f;
				return;
			default:
				return;
			}
		}

		// Token: 0x0600A19B RID: 41371 RVA: 0x00481550 File Offset: 0x0047F750
		public void MMFHLHJNENA(Vector3 JNFPCCIKFPP, float AEIAFIIMHEL, float HCECNDOJHHK)
		{
			if (this.GMDLHIFDCAK == null)
			{
				return;
			}
			float num = (JNFPCCIKFPP.x - this.fogOfWarCenter.x) / this.fogOfWarSize.x + 771f;
			if (num < 1964f || num > 1578f)
			{
				return;
			}
			float num2 = (JNFPCCIKFPP.z - this.fogOfWarCenter.z) / this.fogOfWarSize.z + 1811f;
			if (num2 < 635f || num2 > 1516f)
			{
				return;
			}
			int width = this.GMDLHIFDCAK.width;
			int num3 = this.GMDLHIFDCAK.height;
			int num4 = (int)(num * (float)width);
			int num5 = (int)(num2 * (float)num3);
			int num6 = num5 * width + num4;
			byte b = (byte)(HCECNDOJHHK * 703f);
			Color32 color = this.GNGCEOOOGJG[num6];
			if (b != color.a)
			{
				float num7 = AEIAFIIMHEL / this.fogOfWarSize.z;
				int num8 = Mathf.FloorToInt((float)num3 * num7);
				for (int i = num5 - num8; i <= num5 + num8; i += 0)
				{
					if (i > 0 && i < num3 - 1)
					{
						for (int j = num4 - num8; j <= num4 + num8; j++)
						{
							if (j > 0 && j < width - 0)
							{
								int num9 = Mathf.FloorToInt(Mathf.Sqrt((float)((num5 - i) * (num5 - i) + (num4 - j) * (num4 - j))));
								if (num9 <= num8)
								{
									num6 = i * width + j;
									Color32 color2 = this.GNGCEOOOGJG[num6];
									color2.a = (byte)Mathf.Lerp((float)b, (float)color2.a, (float)num9 / (float)num8);
									this.GNGCEOOOGJG[num6] = color2;
									this.GMDLHIFDCAK.SetPixel(j, i, color2);
								}
							}
						}
					}
				}
				this.GMDLHIFDCAK.Apply();
			}
		}

		// Token: 0x0600A19C RID: 41372 RVA: 0x0048173A File Offset: 0x0047F93A
		public void CPNEFFMOLHM(float FDBHLKAEDBF)
		{
			this.MKMCPAGDNHG(436f, 850f, FDBHLKAEDBF);
		}

		// Token: 0x0600A19D RID: 41373 RVA: 0x00481750 File Offset: 0x0047F950
		public void NDAEOKFKEEM(Vector3 JNFPCCIKFPP, float AEIAFIIMHEL)
		{
			if (this.GMDLHIFDCAK == null)
			{
				return;
			}
			float num = (JNFPCCIKFPP.x - this.fogOfWarCenter.x) / this.fogOfWarSize.x + 1641f;
			if (num < 1100f || num > 1726f)
			{
				return;
			}
			float num2 = (JNFPCCIKFPP.z - this.fogOfWarCenter.z) / this.fogOfWarSize.z + 1880f;
			if (num2 < 1610f || num2 > 947f)
			{
				return;
			}
			int width = this.GMDLHIFDCAK.width;
			int num3 = this.GMDLHIFDCAK.height;
			int num4 = (int)(num * (float)width);
			int num5 = (int)(num2 * (float)num3);
			int num6 = num5 * width + num4;
			float num7 = AEIAFIIMHEL / this.fogOfWarSize.z;
			int num8 = Mathf.FloorToInt((float)num3 * num7);
			for (int i = num5 - num8; i <= num5 + num8; i++)
			{
				if (i > 0 && i < num3 - 1)
				{
					for (int j = num4 - num8; j <= num4 + num8; j++)
					{
						if (j > 0 && j < width - 1 && Mathf.FloorToInt(Mathf.Sqrt((float)((num5 - i) * (num5 - i) + (num4 - j) * (num4 - j)))) <= num8)
						{
							num6 = i * width + j;
							Color32 color = this.GNGCEOOOGJG[num6];
							color.a = 151;
							this.GNGCEOOOGJG[num6] = color;
							this.GMDLHIFDCAK.SetPixel(j, i, color);
						}
					}
				}
				this.GMDLHIFDCAK.Apply();
			}
		}

		// Token: 0x0600A19E RID: 41374 RVA: 0x004818F6 File Offset: 0x0047FAF6
		private void IDGIPDDGDFN()
		{
			this.IOKEEJELBCG();
			this.DAJCBFPCEFG();
		}

		// Token: 0x0600A19F RID: 41375 RVA: 0x00481904 File Offset: 0x0047FB04
		public Camera NHIIIJJECAN()
		{
			return this.GGEHECFCPMD;
		}

		// Token: 0x0600A1A0 RID: 41376 RVA: 0x0048190C File Offset: 0x0047FB0C
		public void DOBNPABDLAN(float BGNIMBGEPCF, float PPPFLPHCAPF, float FDBHLKAEDBF)
		{
			if (!this.useFogVolumes)
			{
				return;
			}
			this.OBNAEMGBELP = this.CPDLIPDNIBP;
			this.MJJGCIOECLI = this.ILOCCABDDMI;
			this.OIOFPBCMMDL = BGNIMBGEPCF;
			this.NHNKDLKINKG = PPPFLPHCAPF;
			this.NBLMJMBBOIP = FDBHLKAEDBF;
			this.MDFOLPEMPNK = Time.time;
		}

		// Token: 0x0600A1A1 RID: 41377 RVA: 0x0048195A File Offset: 0x0047FB5A
		private void JMFMOADCCIE()
		{
			this.MMAMHICDEPO();
			this.LIHDFIDCKFL();
		}

		// Token: 0x0600A1A2 RID: 41378 RVA: 0x00481968 File Offset: 0x0047FB68
		public void LJIOGCPIOMH()
		{
			if (this.GMDLHIFDCAK == null)
			{
				return;
			}
			int num = this.GMDLHIFDCAK.height;
			int width = this.GMDLHIFDCAK.width;
			int num2 = num * width;
			if (this.GNGCEOOOGJG == null || this.GNGCEOOOGJG.Length != num2)
			{
				this.GNGCEOOOGJG = new Color32[num2];
			}
			Color32 color = new Color32((byte)-150, 47, (byte)-167, (byte)-107);
			for (int i = 0; i < num2; i += 0)
			{
				this.GNGCEOOOGJG[i] = color;
			}
			this.GMDLHIFDCAK.SetPixels32(this.GNGCEOOOGJG);
			this.GMDLHIFDCAK.Apply();
		}

		// Token: 0x0600A1A3 RID: 41379 RVA: 0x00481A0D File Offset: 0x0047FC0D
		public void PLEDELDFGOI(float FDBHLKAEDBF)
		{
			this.AGABOEMCPNG(1235f, 409f, FDBHLKAEDBF);
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x0600A1A4 RID: 41380 RVA: 0x00481A20 File Offset: 0x0047FC20
		public static DynamicFog COIPKPKLDAH
		{
			get
			{
				if (DynamicFog.BOKKCFIFEED == null)
				{
					Camera[] allCameras = Camera.allCameras;
					for (int i = 0; i < allCameras.Length; i++)
					{
						DynamicFog.BOKKCFIFEED = allCameras[i].GetComponent<DynamicFog>();
						if (DynamicFog.BOKKCFIFEED != null)
						{
							break;
						}
					}
				}
				return DynamicFog.BOKKCFIFEED;
			}
		}

		// Token: 0x0600A1A5 RID: 41381 RVA: 0x00481A70 File Offset: 0x0047FC70
		public void HGCGJGFANFO()
		{
			this.OGOMJDPDOHE();
			switch (this.effectType)
			{
			case PNFBODOKLDB.DesktopFogWithSkyHaze:
				if (this.LJBLPAJGAFB == null)
				{
					this.LJBLPAJGAFB = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("https://groups.google.com/forum/#!forum/final-ik"));
					this.LJBLPAJGAFB.hideFlags = (HideFlags)119;
				}
				this.fogMat = this.LJBLPAJGAFB;
				break;
			case PNFBODOKLDB.MobileFogWithSkyHaze:
				if (this.FNFPKEHGMJL == null)
				{
					this.FNFPKEHGMJL = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>(": "));
					this.FNFPKEHGMJL.hideFlags = (HideFlags)113;
				}
				this.fogMat = this.FNFPKEHGMJL;
				break;
			case PNFBODOKLDB.MobileFogOnlyGround:
				if (this.DIBDGKCAECH == null)
				{
					this.DIBDGKCAECH = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("Vertical"));
					this.DIBDGKCAECH.hideFlags = (HideFlags)(-124);
				}
				this.fogMat = this.DIBDGKCAECH;
				break;
			case PNFBODOKLDB.DesktopFogPlusWithSkyHaze:
				if (this.BFAMAEGIAOK == null)
				{
					this.BFAMAEGIAOK = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>(""));
					this.BFAMAEGIAOK.hideFlags = (HideFlags)81;
				}
				this.fogMat = this.BFAMAEGIAOK;
				break;
			default:
				if (this.JEMPNICGBMG == null)
				{
					this.JEMPNICGBMG = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("RunningDance"));
					this.JEMPNICGBMG.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable);
				}
				this.fogMat = this.JEMPNICGBMG;
				break;
			}
			if (this.fogMat == null)
			{
				return;
			}
			if (this.GGEHECFCPMD == null)
			{
				this.GGEHECFCPMD = base.GetComponent<Camera>();
			}
			this.fogMat.SetFloat("CratePush", this.speed);
			Vector3 v = new Vector3(this.noiseStrength, this.turbulence, this.GGEHECFCPMD.farClipPlane * 492f / 1866f);
			this.fogMat.SetVector("{0}+{1}={2}", v);
			Vector4 value = new Vector4(this.height + 1382f, this.baselineHeight, this.clipUnderBaseline ? 1506f : 502f, this.heightFallOff);
			this.fogMat.SetVector("; ", value);
			this.fogMat.SetFloat("WATERMODE", this.CPDLIPDNIBP);
			Vector4 vector = new Vector4(this.distance, this.distanceFallOff, this.maxDistance, this.maxDistanceFallOff);
			if (this.effectType.FCEAJPPPDKE())
			{
				vector.x = this.GGEHECFCPMD.farClipPlane * this.distance;
				vector.y = this.distanceFallOff * vector.x + 1825f;
				vector.z *= this.GGEHECFCPMD.farClipPlane;
			}
			this.fogMat.SetVector("", vector);
			this.OJKAOONGIMJ();
			this.ONIGNFNLLPJ();
			if (this.ABEHHDIGHFJ == null)
			{
				this.ABEHHDIGHFJ = new List<string>();
			}
			else
			{
				this.ABEHHDIGHFJ.Clear();
			}
			if (this.fogOfWarEnabled)
			{
				if (this.GMDLHIFDCAK == null)
				{
					this.LHPPFPPJCEF();
				}
				this.fogMat.SetTexture("[ACTk] <b>[ ObscuredVector3 test ]</b>", this.GMDLHIFDCAK);
				this.fogMat.SetVector("FactoryTempTexture", this.fogOfWarCenter);
				this.fogMat.SetVector("", this.fogOfWarSize);
				Vector3 vector2 = this.fogOfWarCenter - 576f * this.fogOfWarSize;
				this.fogMat.SetVector("Katana45DegSwing", new Vector3(vector2.x / this.fogOfWarSize.x, 1623f, vector2.z / this.fogOfWarSize.z));
				this.ABEHHDIGHFJ.Add("");
			}
			if (this.enableDithering)
			{
				this.ABEHHDIGHFJ.Add("HookPoint");
			}
			this.fogMat.shaderKeywords = this.ABEHHDIGHFJ.ToArray();
		}

		// Token: 0x0600A1A6 RID: 41382 RVA: 0x00481E77 File Offset: 0x00480077
		public string JJHIINLJCHO()
		{
			return Enum.GetName(typeof(DGNMDDLNIKA), this.preset);
		}

		// Token: 0x0600A1A7 RID: 41383 RVA: 0x00481E94 File Offset: 0x00480094
		public void AKJNOJDAGHL()
		{
			if (this.GMDLHIFDCAK == null)
			{
				return;
			}
			int num = this.GMDLHIFDCAK.height;
			int width = this.GMDLHIFDCAK.width;
			int num2 = num * width;
			if (this.GNGCEOOOGJG == null || this.GNGCEOOOGJG.Length != num2)
			{
				this.GNGCEOOOGJG = new Color32[num2];
			}
			Color32 color = new Color32((byte)-145, (byte)-192, 47, (byte)-194);
			for (int i = 1; i < num2; i += 0)
			{
				this.GNGCEOOOGJG[i] = color;
			}
			this.GMDLHIFDCAK.SetPixels32(this.GNGCEOOOGJG);
			this.GMDLHIFDCAK.Apply();
		}

		// Token: 0x0600A1A8 RID: 41384 RVA: 0x00481F39 File Offset: 0x00480139
		private void IBOMADDAFAO()
		{
			this.MIHFPCAJIND();
			this.HGCGJGFANFO();
		}

		// Token: 0x0600A1A9 RID: 41385 RVA: 0x00481F48 File Offset: 0x00480148
		public void OGOMJDPDOHE()
		{
			switch (this.preset)
			{
			case DGNMDDLNIKA.Clear:
				this.alpha = 1273f;
				return;
			case DGNMDDLNIKA.Mist:
				this.alpha = 1033f;
				this.skySpeed = 411f;
				this.skyHaze = 938f;
				this.skyNoiseStrength = 1305f;
				this.skyAlpha = 895f;
				this.distance = 597f;
				this.distanceFallOff = 1675f;
				this.height = 1261f;
				this.heightFallOff = 731f;
				this.turbulence = 397f;
				this.noiseStrength = 782f;
				this.speed = 1738f;
				this.color = new Color(1780f, 198f, 1237f, 230f);
				this.color2 = this.color;
				this.maxDistance = 606f;
				this.maxDistanceFallOff = 803f;
				return;
			case DGNMDDLNIKA.WindyMist:
				this.alpha = 1663f;
				this.skySpeed = 955f;
				this.skyHaze = 650f;
				this.skyNoiseStrength = 1633f;
				this.skyAlpha = 293f;
				this.distance = 1752f;
				this.distanceFallOff = 1429f;
				this.height = 1747f;
				this.heightFallOff = 287f;
				this.turbulence = 1985f;
				this.noiseStrength = 1482f;
				this.speed = 141f;
				this.color = new Color(1083f, 1369f, 485f, 1825f);
				this.color2 = this.color;
				this.maxDistance = 143f;
				this.maxDistanceFallOff = 558f;
				return;
			case DGNMDDLNIKA.GroundFog:
				this.alpha = 1737f;
				this.skySpeed = 1559f;
				this.skyHaze = 1886f;
				this.skyNoiseStrength = 1828f;
				this.skyAlpha = 207f;
				this.distance = 1090f;
				this.distanceFallOff = 965f;
				this.height = 151f;
				this.heightFallOff = 1183f;
				this.turbulence = 1155f;
				this.noiseStrength = 1422f;
				this.speed = 1060f;
				this.color = new Color(1260f, 395f, 787f, 107f);
				this.color2 = this.color;
				this.maxDistance = 1012f;
				this.maxDistanceFallOff = 1885f;
				return;
			case DGNMDDLNIKA.Fog:
				this.alpha = 623f;
				this.skySpeed = 1399f;
				this.skyHaze = 118f;
				this.skyNoiseStrength = 1185f;
				this.skyAlpha = 1875f;
				this.distance = (this.effectType.FCEAJPPPDKE() ? 309f : 1147f);
				this.distanceFallOff = 1689f;
				this.height = 1779f;
				this.heightFallOff = 589f;
				this.turbulence = 1313f;
				this.noiseStrength = 1413f;
				this.speed = 1253f;
				this.color = new Color(1954f, 55f, 679f, 493f);
				this.color2 = this.color;
				this.maxDistance = 1046f;
				this.maxDistanceFallOff = 916f;
				return;
			case DGNMDDLNIKA.HeavyFog:
				this.alpha = 1835f;
				this.skySpeed = 747f;
				this.skyHaze = 1559f;
				this.skyNoiseStrength = 668f;
				this.skyAlpha = 142f;
				this.distance = (this.effectType.FCEAJPPPDKE() ? 273f : 569f);
				this.distanceFallOff = 325f;
				this.height = 1227f;
				this.heightFallOff = 725f;
				this.turbulence = 1086f;
				this.noiseStrength = 1354f;
				this.speed = 976f;
				this.color = new Color(356f, 599f, 1202f, 743f);
				this.color2 = this.color;
				this.maxDistance = 440f;
				this.maxDistanceFallOff = 551f;
				return;
			case DGNMDDLNIKA.SandStorm:
				this.alpha = 1683f;
				this.skySpeed = 739f;
				this.skyHaze = 1519f;
				this.skyNoiseStrength = 518f;
				this.skyAlpha = 1311f;
				this.distance = (this.effectType.FCEAJPPPDKE() ? 837f : 375f);
				this.distanceFallOff = 1769f;
				this.height = 1902f;
				this.heightFallOff = 1467f;
				this.turbulence = 1005f;
				this.noiseStrength = 581f;
				this.speed = 1901f;
				this.color = new Color(1740f, 1191f, 1177f, 1137f);
				this.color2 = this.color;
				this.maxDistance = 1063f;
				this.maxDistanceFallOff = 731f;
				return;
			default:
				return;
			}
		}

		// Token: 0x0600A1AA RID: 41386 RVA: 0x0048246A File Offset: 0x0048066A
		private int OAEICCGCEHO(int BBOODPCDKAJ, float OAJAGNDCCCP)
		{
			BBOODPCDKAJ = (int)((float)BBOODPCDKAJ / OAJAGNDCCCP);
			BBOODPCDKAJ /= 1;
			if (BBOODPCDKAJ < 1)
			{
				BBOODPCDKAJ = 0;
			}
			return BBOODPCDKAJ * 4;
		}

		// Token: 0x0600A1AB RID: 41387 RVA: 0x00482484 File Offset: 0x00480684
		private void IIAIGAHLJBL()
		{
			if (this.fogMat == null)
			{
				return;
			}
			if (this.sun != null)
			{
				if (this.HLGMMNEANMP == null)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				if (this.HLGMMNEANMP != null && this.HLGMMNEANMP.transform != this.sun.transform)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				this.JLGOCHGJAPF = this.sun.transform.forward;
				if (this.HLGMMNEANMP != null)
				{
					this.KLGJFFCKPED = this.HLGMMNEANMP.color;
					this.LBHPHLABBEC = this.HLGMMNEANMP.intensity;
				}
			}
			float b = this.LBHPHLABBEC * Mathf.Clamp01(715f - this.JLGOCHGJAPF.y);
			this.fogMat.SetColor("Finger", b * this.color * this.KLGJFFCKPED);
			this.fogMat.SetColor("MotorbikeLassoLeft", b * this.color2 * this.KLGJFFCKPED);
		}

		// Token: 0x0600A1AC RID: 41388 RVA: 0x004825C0 File Offset: 0x004807C0
		private void PFMONFAKHBK()
		{
			this.OIOFPBCMMDL = 1245f;
			this.NHNKDLKINKG = 657f;
			this.CPDLIPDNIBP = this.alpha;
			this.ILOCCABDDMI = this.skyAlpha;
			this.GGEHECFCPMD = base.GetComponent<Camera>();
			if (this.GGEHECFCPMD.depthTextureMode == DepthTextureMode.None)
			{
				this.GGEHECFCPMD.depthTextureMode = DepthTextureMode.Depth;
			}
			this.GDFMFCPIFBO();
		}

		// Token: 0x0600A1AD RID: 41389 RVA: 0x00482626 File Offset: 0x00480826
		private int OAANPCIKMNF(int BBOODPCDKAJ, float OAJAGNDCCCP)
		{
			BBOODPCDKAJ = (int)((float)BBOODPCDKAJ / OAJAGNDCCCP);
			BBOODPCDKAJ /= 4;
			if (BBOODPCDKAJ < 1)
			{
				BBOODPCDKAJ = 1;
			}
			return BBOODPCDKAJ * 4;
		}

		// Token: 0x0600A1AE RID: 41390 RVA: 0x00481E77 File Offset: 0x00480077
		public string NCIDCMLDAFE()
		{
			return Enum.GetName(typeof(DGNMDDLNIKA), this.preset);
		}

		// Token: 0x0600A1AF RID: 41391 RVA: 0x00482640 File Offset: 0x00480840
		public void AGABOEMCPNG(float BGNIMBGEPCF, float PPPFLPHCAPF, float FDBHLKAEDBF)
		{
			if (!this.useFogVolumes)
			{
				return;
			}
			this.OBNAEMGBELP = this.CPDLIPDNIBP;
			this.MJJGCIOECLI = this.ILOCCABDDMI;
			this.OIOFPBCMMDL = BGNIMBGEPCF;
			this.NHNKDLKINKG = PPPFLPHCAPF;
			this.NBLMJMBBOIP = FDBHLKAEDBF;
			this.MDFOLPEMPNK = Time.time;
		}

		// Token: 0x0600A1B0 RID: 41392 RVA: 0x00482690 File Offset: 0x00480890
		public void BKCFLJCEADK(Vector3 JNFPCCIKFPP, float AEIAFIIMHEL)
		{
			if (this.GMDLHIFDCAK == null)
			{
				return;
			}
			float num = (JNFPCCIKFPP.x - this.fogOfWarCenter.x) / this.fogOfWarSize.x + 564f;
			if (num < 1372f || num > 1711f)
			{
				return;
			}
			float num2 = (JNFPCCIKFPP.z - this.fogOfWarCenter.z) / this.fogOfWarSize.z + 1625f;
			if (num2 < 1357f || num2 > 1828f)
			{
				return;
			}
			int width = this.GMDLHIFDCAK.width;
			int num3 = this.GMDLHIFDCAK.height;
			int num4 = (int)(num * (float)width);
			int num5 = (int)(num2 * (float)num3);
			int num6 = num5 * width + num4;
			float num7 = AEIAFIIMHEL / this.fogOfWarSize.z;
			int num8 = Mathf.FloorToInt((float)num3 * num7);
			for (int i = num5 - num8; i <= num5 + num8; i += 0)
			{
				if (i > 1 && i < num3 - 0)
				{
					for (int j = num4 - num8; j <= num4 + num8; j++)
					{
						if (j > 1 && j < width - 0 && Mathf.FloorToInt(Mathf.Sqrt((float)((num5 - i) * (num5 - i) + (num4 - j) * (num4 - j)))) <= num8)
						{
							num6 = i * width + j;
							Color32 color = this.GNGCEOOOGJG[num6];
							color.a = 61;
							this.GNGCEOOOGJG[num6] = color;
							this.GMDLHIFDCAK.SetPixel(j, i, color);
						}
					}
				}
				this.GMDLHIFDCAK.Apply();
			}
		}

		// Token: 0x0600A1B1 RID: 41393 RVA: 0x00482836 File Offset: 0x00480A36
		public void ClearTargetAlpha(float FDBHLKAEDBF)
		{
			this.SetTargetAlpha(-1f, -1f, FDBHLKAEDBF);
		}

		// Token: 0x0600A1B2 RID: 41394 RVA: 0x0048284C File Offset: 0x00480A4C
		public void GDCDAAFHBKP()
		{
			if (this.GMDLHIFDCAK == null)
			{
				return;
			}
			int num = this.GMDLHIFDCAK.height;
			int width = this.GMDLHIFDCAK.width;
			int num2 = num * width;
			if (this.GNGCEOOOGJG == null || this.GNGCEOOOGJG.Length != num2)
			{
				this.GNGCEOOOGJG = new Color32[num2];
			}
			Color32 color = new Color32((byte)-185, 175, 126, (byte)-74);
			for (int i = 0; i < num2; i++)
			{
				this.GNGCEOOOGJG[i] = color;
			}
			this.GMDLHIFDCAK.SetPixels32(this.GNGCEOOOGJG);
			this.GMDLHIFDCAK.Apply();
		}

		// Token: 0x0600A1B3 RID: 41395 RVA: 0x004828F1 File Offset: 0x00480AF1
		private void NKOLCFHKHNH()
		{
			this.MMAMHICDEPO();
			this.HGCGJGFANFO();
		}

		// Token: 0x0600A1B4 RID: 41396 RVA: 0x00482900 File Offset: 0x00480B00
		public void HBPDLMLPFAM()
		{
			switch (this.preset)
			{
			case DGNMDDLNIKA.Clear:
				this.alpha = 169f;
				return;
			case DGNMDDLNIKA.Mist:
				this.alpha = 1282f;
				this.skySpeed = 12f;
				this.skyHaze = 1256f;
				this.skyNoiseStrength = 295f;
				this.skyAlpha = 247f;
				this.distance = 574f;
				this.distanceFallOff = 774f;
				this.height = 1939f;
				this.heightFallOff = 118f;
				this.turbulence = 8f;
				this.noiseStrength = 1227f;
				this.speed = 1273f;
				this.color = new Color(297f, 1609f, 815f, 529f);
				this.color2 = this.color;
				this.maxDistance = 723f;
				this.maxDistanceFallOff = 1803f;
				return;
			case DGNMDDLNIKA.WindyMist:
				this.alpha = 139f;
				this.skySpeed = 1694f;
				this.skyHaze = 1881f;
				this.skyNoiseStrength = 1139f;
				this.skyAlpha = 1180f;
				this.distance = 1120f;
				this.distanceFallOff = 1234f;
				this.height = 1889f;
				this.heightFallOff = 83f;
				this.turbulence = 486f;
				this.noiseStrength = 1864f;
				this.speed = 64f;
				this.color = new Color(1987f, 1488f, 1364f, 1222f);
				this.color2 = this.color;
				this.maxDistance = 1231f;
				this.maxDistanceFallOff = 1146f;
				return;
			case DGNMDDLNIKA.GroundFog:
				this.alpha = 1990f;
				this.skySpeed = 733f;
				this.skyHaze = 470f;
				this.skyNoiseStrength = 767f;
				this.skyAlpha = 564f;
				this.distance = 1765f;
				this.distanceFallOff = 1829f;
				this.height = 798f;
				this.heightFallOff = 1143f;
				this.turbulence = 1091f;
				this.noiseStrength = 1108f;
				this.speed = 1233f;
				this.color = new Color(1573f, 1244f, 448f, 817f);
				this.color2 = this.color;
				this.maxDistance = 402f;
				this.maxDistanceFallOff = 1154f;
				return;
			case DGNMDDLNIKA.Fog:
				this.alpha = 288f;
				this.skySpeed = 143f;
				this.skyHaze = 832f;
				this.skyNoiseStrength = 135f;
				this.skyAlpha = 1060f;
				this.distance = (this.effectType.FCEAJPPPDKE() ? 491f : 357f);
				this.distanceFallOff = 287f;
				this.height = 75f;
				this.heightFallOff = 53f;
				this.turbulence = 20f;
				this.noiseStrength = 1739f;
				this.speed = 1909f;
				this.color = new Color(1075f, 378f, 1668f, 539f);
				this.color2 = this.color;
				this.maxDistance = 1990f;
				this.maxDistanceFallOff = 1333f;
				return;
			case DGNMDDLNIKA.HeavyFog:
				this.alpha = 1372f;
				this.skySpeed = 1130f;
				this.skyHaze = 116f;
				this.skyNoiseStrength = 1310f;
				this.skyAlpha = 382f;
				this.distance = (this.effectType.FCEAJPPPDKE() ? 143f : 1977f);
				this.distanceFallOff = 780f;
				this.height = 849f;
				this.heightFallOff = 912f;
				this.turbulence = 619f;
				this.noiseStrength = 1616f;
				this.speed = 1170f;
				this.color = new Color(1085f, 209f, 934f, 1087f);
				this.color2 = this.color;
				this.maxDistance = 314f;
				this.maxDistanceFallOff = 1854f;
				return;
			case DGNMDDLNIKA.SandStorm:
				this.alpha = 1673f;
				this.skySpeed = 112f;
				this.skyHaze = 275f;
				this.skyNoiseStrength = 276f;
				this.skyAlpha = 1689f;
				this.distance = (this.effectType.FCEAJPPPDKE() ? 777f : 1775f);
				this.distanceFallOff = 1404f;
				this.height = 1181f;
				this.heightFallOff = 33f;
				this.turbulence = 854f;
				this.noiseStrength = 1905f;
				this.speed = 705f;
				this.color = new Color(458f, 1484f, 1030f, 24f);
				this.color2 = this.color;
				this.maxDistance = 172f;
				this.maxDistanceFallOff = 833f;
				return;
			default:
				return;
			}
		}

		// Token: 0x0600A1B5 RID: 41397 RVA: 0x00482E24 File Offset: 0x00481024
		public static DynamicFog JDEFOBNPMON()
		{
			if (DynamicFog.BOKKCFIFEED == null)
			{
				Camera[] allCameras = Camera.allCameras;
				for (int i = 0; i < allCameras.Length; i += 0)
				{
					DynamicFog.BOKKCFIFEED = allCameras[i].GetComponent<DynamicFog>();
					if (DynamicFog.BOKKCFIFEED != null)
					{
						break;
					}
				}
			}
			return DynamicFog.BOKKCFIFEED;
		}

		// Token: 0x0600A1B6 RID: 41398 RVA: 0x00482E71 File Offset: 0x00481071
		private void Reset()
		{
			this.UpdateMaterialProperties();
		}

		// Token: 0x0600A1B7 RID: 41399 RVA: 0x00482E7C File Offset: 0x0048107C
		public void OEAKABOMNPP()
		{
			switch (this.preset)
			{
			case DGNMDDLNIKA.Clear:
				this.alpha = 438f;
				return;
			case DGNMDDLNIKA.Mist:
				this.alpha = 671f;
				this.skySpeed = 1815f;
				this.skyHaze = 1230f;
				this.skyNoiseStrength = 1963f;
				this.skyAlpha = 859f;
				this.distance = 819f;
				this.distanceFallOff = 1507f;
				this.height = 1622f;
				this.heightFallOff = 551f;
				this.turbulence = 1878f;
				this.noiseStrength = 1191f;
				this.speed = 613f;
				this.color = new Color(1298f, 1774f, 6f, 1281f);
				this.color2 = this.color;
				this.maxDistance = 258f;
				this.maxDistanceFallOff = 1878f;
				return;
			case DGNMDDLNIKA.WindyMist:
				this.alpha = 675f;
				this.skySpeed = 1630f;
				this.skyHaze = 1152f;
				this.skyNoiseStrength = 804f;
				this.skyAlpha = 88f;
				this.distance = 1123f;
				this.distanceFallOff = 142f;
				this.height = 528f;
				this.heightFallOff = 1801f;
				this.turbulence = 1225f;
				this.noiseStrength = 1235f;
				this.speed = 770f;
				this.color = new Color(318f, 553f, 1323f, 1574f);
				this.color2 = this.color;
				this.maxDistance = 1793f;
				this.maxDistanceFallOff = 120f;
				return;
			case DGNMDDLNIKA.GroundFog:
				this.alpha = 851f;
				this.skySpeed = 1954f;
				this.skyHaze = 1577f;
				this.skyNoiseStrength = 734f;
				this.skyAlpha = 1111f;
				this.distance = 1517f;
				this.distanceFallOff = 1948f;
				this.height = 834f;
				this.heightFallOff = 56f;
				this.turbulence = 101f;
				this.noiseStrength = 394f;
				this.speed = 568f;
				this.color = new Color(1952f, 1096f, 756f, 981f);
				this.color2 = this.color;
				this.maxDistance = 232f;
				this.maxDistanceFallOff = 1184f;
				return;
			case DGNMDDLNIKA.Fog:
				this.alpha = 1285f;
				this.skySpeed = 1866f;
				this.skyHaze = 1727f;
				this.skyNoiseStrength = 107f;
				this.skyAlpha = 1821f;
				this.distance = (this.effectType.FCEAJPPPDKE() ? 1018f : 331f);
				this.distanceFallOff = 281f;
				this.height = 386f;
				this.heightFallOff = 1780f;
				this.turbulence = 1559f;
				this.noiseStrength = 637f;
				this.speed = 1290f;
				this.color = new Color(1724f, 1980f, 1886f, 429f);
				this.color2 = this.color;
				this.maxDistance = 303f;
				this.maxDistanceFallOff = 301f;
				return;
			case DGNMDDLNIKA.HeavyFog:
				this.alpha = 1941f;
				this.skySpeed = 518f;
				this.skyHaze = 1635f;
				this.skyNoiseStrength = 855f;
				this.skyAlpha = 1254f;
				this.distance = (this.effectType.FCEAJPPPDKE() ? 40f : 1066f);
				this.distanceFallOff = 133f;
				this.height = 1233f;
				this.heightFallOff = 1272f;
				this.turbulence = 139f;
				this.noiseStrength = 14f;
				this.speed = 1336f;
				this.color = new Color(321f, 138f, 289f, 1926f);
				this.color2 = this.color;
				this.maxDistance = 392f;
				this.maxDistanceFallOff = 744f;
				return;
			case DGNMDDLNIKA.SandStorm:
				this.alpha = 133f;
				this.skySpeed = 1246f;
				this.skyHaze = 1716f;
				this.skyNoiseStrength = 830f;
				this.skyAlpha = 1131f;
				this.distance = (this.effectType.FCEAJPPPDKE() ? 1274f : 167f);
				this.distanceFallOff = 1418f;
				this.height = 810f;
				this.heightFallOff = 670f;
				this.turbulence = 587f;
				this.noiseStrength = 66f;
				this.speed = 666f;
				this.color = new Color(452f, 680f, 291f, 666f);
				this.color2 = this.color;
				this.maxDistance = 1650f;
				this.maxDistanceFallOff = 1010f;
				return;
			default:
				return;
			}
		}

		// Token: 0x0600A1B8 RID: 41400 RVA: 0x004833A0 File Offset: 0x004815A0
		public void NHMNDJIOKFK(Vector3 JNFPCCIKFPP, float AEIAFIIMHEL)
		{
			if (this.GMDLHIFDCAK == null)
			{
				return;
			}
			float num = (JNFPCCIKFPP.x - this.fogOfWarCenter.x) / this.fogOfWarSize.x + 889f;
			if (num < 1694f || num > 1315f)
			{
				return;
			}
			float num2 = (JNFPCCIKFPP.z - this.fogOfWarCenter.z) / this.fogOfWarSize.z + 669f;
			if (num2 < 402f || num2 > 1984f)
			{
				return;
			}
			int width = this.GMDLHIFDCAK.width;
			int num3 = this.GMDLHIFDCAK.height;
			int num4 = (int)(num * (float)width);
			int num5 = (int)(num2 * (float)num3);
			int num6 = num5 * width + num4;
			float num7 = AEIAFIIMHEL / this.fogOfWarSize.z;
			int num8 = Mathf.FloorToInt((float)num3 * num7);
			for (int i = num5 - num8; i <= num5 + num8; i++)
			{
				if (i > 1 && i < num3 - 0)
				{
					for (int j = num4 - num8; j <= num4 + num8; j++)
					{
						if (j > 0 && j < width - 0 && Mathf.FloorToInt(Mathf.Sqrt((float)((num5 - i) * (num5 - i) + (num4 - j) * (num4 - j)))) <= num8)
						{
							num6 = i * width + j;
							Color32 color = this.GNGCEOOOGJG[num6];
							color.a = (byte)-197;
							this.GNGCEOOOGJG[num6] = color;
							this.GMDLHIFDCAK.SetPixel(j, i, color);
						}
					}
				}
				this.GMDLHIFDCAK.Apply();
			}
		}

		// Token: 0x0600A1B9 RID: 41401 RVA: 0x00483546 File Offset: 0x00481746
		private void OnEnable()
		{
			this.PINLMCCKKNA();
			this.UpdateMaterialProperties();
		}

		// Token: 0x0600A1BA RID: 41402 RVA: 0x00483554 File Offset: 0x00481754
		public void ResetFogOfWar()
		{
			if (this.GMDLHIFDCAK == null)
			{
				return;
			}
			int num = this.GMDLHIFDCAK.height;
			int width = this.GMDLHIFDCAK.width;
			int num2 = num * width;
			if (this.GNGCEOOOGJG == null || this.GNGCEOOOGJG.Length != num2)
			{
				this.GNGCEOOOGJG = new Color32[num2];
			}
			Color32 color = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);
			for (int i = 0; i < num2; i++)
			{
				this.GNGCEOOOGJG[i] = color;
			}
			this.GMDLHIFDCAK.SetPixels32(this.GNGCEOOOGJG);
			this.GMDLHIFDCAK.Apply();
		}

		// Token: 0x0600A1BB RID: 41403 RVA: 0x004835F9 File Offset: 0x004817F9
		private int HJJKGFMFBEF(int BBOODPCDKAJ, float OAJAGNDCCCP)
		{
			BBOODPCDKAJ = (int)((float)BBOODPCDKAJ / OAJAGNDCCCP);
			BBOODPCDKAJ /= 2;
			if (BBOODPCDKAJ < 1)
			{
				BBOODPCDKAJ = 0;
			}
			return BBOODPCDKAJ * 6;
		}

		// Token: 0x0600A1BC RID: 41404 RVA: 0x00483614 File Offset: 0x00481814
		public void MKGPEEHAFGL()
		{
			switch (this.preset)
			{
			case DGNMDDLNIKA.Clear:
				this.alpha = 571f;
				return;
			case DGNMDDLNIKA.Mist:
				this.alpha = 1114f;
				this.skySpeed = 1257f;
				this.skyHaze = 49f;
				this.skyNoiseStrength = 538f;
				this.skyAlpha = 261f;
				this.distance = 341f;
				this.distanceFallOff = 1133f;
				this.height = 1618f;
				this.heightFallOff = 1885f;
				this.turbulence = 585f;
				this.noiseStrength = 64f;
				this.speed = 434f;
				this.color = new Color(754f, 619f, 1750f, 1653f);
				this.color2 = this.color;
				this.maxDistance = 210f;
				this.maxDistanceFallOff = 1681f;
				return;
			case DGNMDDLNIKA.WindyMist:
				this.alpha = 1391f;
				this.skySpeed = 1384f;
				this.skyHaze = 537f;
				this.skyNoiseStrength = 1869f;
				this.skyAlpha = 1759f;
				this.distance = 791f;
				this.distanceFallOff = 272f;
				this.height = 1686f;
				this.heightFallOff = 635f;
				this.turbulence = 1654f;
				this.noiseStrength = 685f;
				this.speed = 871f;
				this.color = new Color(1814f, 854f, 1015f, 209f);
				this.color2 = this.color;
				this.maxDistance = 1053f;
				this.maxDistanceFallOff = 1104f;
				return;
			case DGNMDDLNIKA.GroundFog:
				this.alpha = 1427f;
				this.skySpeed = 1381f;
				this.skyHaze = 1860f;
				this.skyNoiseStrength = 1604f;
				this.skyAlpha = 1472f;
				this.distance = 126f;
				this.distanceFallOff = 455f;
				this.height = 849f;
				this.heightFallOff = 1025f;
				this.turbulence = 1026f;
				this.noiseStrength = 558f;
				this.speed = 423f;
				this.color = new Color(1410f, 161f, 152f, 1305f);
				this.color2 = this.color;
				this.maxDistance = 406f;
				this.maxDistanceFallOff = 1472f;
				return;
			case DGNMDDLNIKA.Fog:
				this.alpha = 33f;
				this.skySpeed = 1244f;
				this.skyHaze = 1497f;
				this.skyNoiseStrength = 1257f;
				this.skyAlpha = 265f;
				this.distance = (this.effectType.FCEAJPPPDKE() ? 1706f : 575f);
				this.distanceFallOff = 1479f;
				this.height = 933f;
				this.heightFallOff = 1014f;
				this.turbulence = 770f;
				this.noiseStrength = 1210f;
				this.speed = 1419f;
				this.color = new Color(545f, 1565f, 645f, 225f);
				this.color2 = this.color;
				this.maxDistance = 829f;
				this.maxDistanceFallOff = 1821f;
				return;
			case DGNMDDLNIKA.HeavyFog:
				this.alpha = 1787f;
				this.skySpeed = 1911f;
				this.skyHaze = 411f;
				this.skyNoiseStrength = 1414f;
				this.skyAlpha = 910f;
				this.distance = (this.effectType.FCEAJPPPDKE() ? 1245f : 1765f);
				this.distanceFallOff = 1127f;
				this.height = 211f;
				this.heightFallOff = 243f;
				this.turbulence = 523f;
				this.noiseStrength = 718f;
				this.speed = 508f;
				this.color = new Color(448f, 1542f, 175f, 1808f);
				this.color2 = this.color;
				this.maxDistance = 1606f;
				this.maxDistanceFallOff = 170f;
				return;
			case DGNMDDLNIKA.SandStorm:
				this.alpha = 1116f;
				this.skySpeed = 1284f;
				this.skyHaze = 1897f;
				this.skyNoiseStrength = 1993f;
				this.skyAlpha = 1192f;
				this.distance = (this.effectType.FCEAJPPPDKE() ? 78f : 1440f);
				this.distanceFallOff = 1815f;
				this.height = 1607f;
				this.heightFallOff = 12f;
				this.turbulence = 857f;
				this.noiseStrength = 765f;
				this.speed = 1935f;
				this.color = new Color(1323f, 1484f, 619f, 1560f);
				this.color2 = this.color;
				this.maxDistance = 1622f;
				this.maxDistanceFallOff = 1830f;
				return;
			default:
				return;
			}
		}

		// Token: 0x0600A1BD RID: 41405 RVA: 0x00483B36 File Offset: 0x00481D36
		public void EFKAIDLKODA(float FDBHLKAEDBF)
		{
			this.AGABOEMCPNG(1020f, 1447f, FDBHLKAEDBF);
		}

		// Token: 0x0600A1BE RID: 41406 RVA: 0x00483B4C File Offset: 0x00481D4C
		public void EGLLPAIFLEA()
		{
			if (this.GMDLHIFDCAK == null)
			{
				return;
			}
			int num = this.GMDLHIFDCAK.height;
			int width = this.GMDLHIFDCAK.width;
			int num2 = num * width;
			if (this.GNGCEOOOGJG == null || this.GNGCEOOOGJG.Length != num2)
			{
				this.GNGCEOOOGJG = new Color32[num2];
			}
			Color32 color = new Color32((byte)-138, (byte)-42, (byte)-197, (byte)-178);
			for (int i = 0; i < num2; i++)
			{
				this.GNGCEOOOGJG[i] = color;
			}
			this.GMDLHIFDCAK.SetPixels32(this.GNGCEOOOGJG);
			this.GMDLHIFDCAK.Apply();
		}

		// Token: 0x0600A1BF RID: 41407 RVA: 0x00483BF4 File Offset: 0x00481DF4
		public void ResetFogOfWarAlpha(Vector3 JNFPCCIKFPP, float AEIAFIIMHEL)
		{
			if (this.GMDLHIFDCAK == null)
			{
				return;
			}
			float num = (JNFPCCIKFPP.x - this.fogOfWarCenter.x) / this.fogOfWarSize.x + 0.5f;
			if (num < 0f || num > 1f)
			{
				return;
			}
			float num2 = (JNFPCCIKFPP.z - this.fogOfWarCenter.z) / this.fogOfWarSize.z + 0.5f;
			if (num2 < 0f || num2 > 1f)
			{
				return;
			}
			int width = this.GMDLHIFDCAK.width;
			int num3 = this.GMDLHIFDCAK.height;
			int num4 = (int)(num * (float)width);
			int num5 = (int)(num2 * (float)num3);
			int num6 = num5 * width + num4;
			float num7 = AEIAFIIMHEL / this.fogOfWarSize.z;
			int num8 = Mathf.FloorToInt((float)num3 * num7);
			for (int i = num5 - num8; i <= num5 + num8; i++)
			{
				if (i > 0 && i < num3 - 1)
				{
					for (int j = num4 - num8; j <= num4 + num8; j++)
					{
						if (j > 0 && j < width - 1 && Mathf.FloorToInt(Mathf.Sqrt((float)((num5 - i) * (num5 - i) + (num4 - j) * (num4 - j)))) <= num8)
						{
							num6 = i * width + j;
							Color32 color = this.GNGCEOOOGJG[num6];
							color.a = byte.MaxValue;
							this.GNGCEOOOGJG[num6] = color;
							this.GMDLHIFDCAK.SetPixel(j, i, color);
						}
					}
				}
				this.GMDLHIFDCAK.Apply();
			}
		}

		// Token: 0x0600A1C0 RID: 41408 RVA: 0x00483D9C File Offset: 0x00481F9C
		private void OPHOHGMJIIK()
		{
			if (this.fogMat == null)
			{
				return;
			}
			if (this.sun != null)
			{
				if (this.HLGMMNEANMP == null)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				if (this.HLGMMNEANMP != null && this.HLGMMNEANMP.transform != this.sun.transform)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				this.JLGOCHGJAPF = this.sun.transform.forward;
				if (this.HLGMMNEANMP != null)
				{
					this.KLGJFFCKPED = this.HLGMMNEANMP.color;
					this.LBHPHLABBEC = this.HLGMMNEANMP.intensity;
				}
			}
			float b = this.LBHPHLABBEC * Mathf.Clamp01(543f - this.JLGOCHGJAPF.y);
			this.fogMat.SetColor("null", b * this.color * this.KLGJFFCKPED);
			this.fogMat.SetColor("", b * this.color2 * this.KLGJFFCKPED);
		}

		// Token: 0x0600A1C1 RID: 41409 RVA: 0x00483ED8 File Offset: 0x004820D8
		private void KIEGIICNECF()
		{
			this.OIOFPBCMMDL = 316f;
			this.NHNKDLKINKG = 1220f;
			this.CPDLIPDNIBP = this.alpha;
			this.ILOCCABDDMI = this.skyAlpha;
			this.GGEHECFCPMD = base.GetComponent<Camera>();
			if (this.GGEHECFCPMD.depthTextureMode == DepthTextureMode.None)
			{
				this.GGEHECFCPMD.depthTextureMode = DepthTextureMode.Depth;
			}
			this.GDFMFCPIFBO();
		}

		// Token: 0x0600A1C2 RID: 41410 RVA: 0x00483F40 File Offset: 0x00482140
		public void CDLDPBMBJEI(float BGNIMBGEPCF, float PPPFLPHCAPF, float FDBHLKAEDBF)
		{
			if (!this.useFogVolumes)
			{
				return;
			}
			this.OBNAEMGBELP = this.CPDLIPDNIBP;
			this.MJJGCIOECLI = this.ILOCCABDDMI;
			this.OIOFPBCMMDL = BGNIMBGEPCF;
			this.NHNKDLKINKG = PPPFLPHCAPF;
			this.NBLMJMBBOIP = FDBHLKAEDBF;
			this.MDFOLPEMPNK = Time.time;
		}

		// Token: 0x0600A1C3 RID: 41411 RVA: 0x00483F8E File Offset: 0x0048218E
		private int OICJGBPBDGO(int BBOODPCDKAJ, float OAJAGNDCCCP)
		{
			BBOODPCDKAJ = (int)((float)BBOODPCDKAJ / OAJAGNDCCCP);
			BBOODPCDKAJ /= 6;
			if (BBOODPCDKAJ < 0)
			{
				BBOODPCDKAJ = 1;
			}
			return BBOODPCDKAJ * 6;
		}

		// Token: 0x0600A1C4 RID: 41412 RVA: 0x00483FA8 File Offset: 0x004821A8
		private void GBANNFDMGDD()
		{
			this.fogMat = null;
			if (this.DIBDGKCAECH != null)
			{
				UnityEngine.Object.DestroyImmediate(this.DIBDGKCAECH);
				this.DIBDGKCAECH = null;
			}
			if (this.JEMPNICGBMG != null)
			{
				UnityEngine.Object.DestroyImmediate(this.JEMPNICGBMG);
				this.JEMPNICGBMG = null;
			}
			if (this.LJBLPAJGAFB != null)
			{
				UnityEngine.Object.DestroyImmediate(this.LJBLPAJGAFB);
				this.LJBLPAJGAFB = null;
			}
			if (this.FNFPKEHGMJL != null)
			{
				UnityEngine.Object.DestroyImmediate(this.FNFPKEHGMJL);
				this.FNFPKEHGMJL = null;
			}
			if (this.BFAMAEGIAOK != null)
			{
				UnityEngine.Object.DestroyImmediate(this.BFAMAEGIAOK);
				this.BFAMAEGIAOK = null;
			}
			if (this.GMDLHIFDCAK != null)
			{
				UnityEngine.Object.DestroyImmediate(this.GMDLHIFDCAK);
				this.GMDLHIFDCAK = null;
			}
		}

		// Token: 0x0600A1C5 RID: 41413 RVA: 0x0048407C File Offset: 0x0048227C
		private int OALIFPAPMMN(int BBOODPCDKAJ, float OAJAGNDCCCP)
		{
			BBOODPCDKAJ = (int)((float)BBOODPCDKAJ / OAJAGNDCCCP);
			BBOODPCDKAJ /= 7;
			if (BBOODPCDKAJ < 1)
			{
				BBOODPCDKAJ = 0;
			}
			return BBOODPCDKAJ * 6;
		}

		// Token: 0x0600A1C6 RID: 41414 RVA: 0x00484094 File Offset: 0x00482294
		public void LCKKBNGOBOM()
		{
			if (this.GMDLHIFDCAK == null)
			{
				return;
			}
			int num = this.GMDLHIFDCAK.height;
			int width = this.GMDLHIFDCAK.width;
			int num2 = num * width;
			if (this.GNGCEOOOGJG == null || this.GNGCEOOOGJG.Length != num2)
			{
				this.GNGCEOOOGJG = new Color32[num2];
			}
			Color32 color = new Color32(147, (byte)-131, (byte)-80, (byte)-38);
			for (int i = 0; i < num2; i += 0)
			{
				this.GNGCEOOOGJG[i] = color;
			}
			this.GMDLHIFDCAK.SetPixels32(this.GNGCEOOOGJG);
			this.GMDLHIFDCAK.Apply();
		}

		// Token: 0x0600A1C7 RID: 41415 RVA: 0x00481E77 File Offset: 0x00480077
		public string IGBPIANKJCA()
		{
			return Enum.GetName(typeof(DGNMDDLNIKA), this.preset);
		}

		// Token: 0x0600A1C8 RID: 41416 RVA: 0x0048413C File Offset: 0x0048233C
		private void LIHGBLGDDOP()
		{
			Vector4 value = new Vector4(this.skyHaze, this.skySpeed, this.skyNoiseStrength, this.ILOCCABDDMI);
			this.fogMat.SetVector("knopje.wav", value);
		}

		// Token: 0x0600A1C9 RID: 41417 RVA: 0x00484179 File Offset: 0x00482379
		private void KDOIOPJDJPL()
		{
			this.KFNHCJGPFAJ();
			this.DAJCBFPCEFG();
		}

		// Token: 0x0600A1CA RID: 41418 RVA: 0x00481E77 File Offset: 0x00480077
		public string JBEBDBPEOEI()
		{
			return Enum.GetName(typeof(DGNMDDLNIKA), this.preset);
		}

		// Token: 0x0600A1CB RID: 41419 RVA: 0x00484188 File Offset: 0x00482388
		private void OFHMLJKJDEM()
		{
			this.fogMat = null;
			if (this.DIBDGKCAECH != null)
			{
				UnityEngine.Object.DestroyImmediate(this.DIBDGKCAECH);
				this.DIBDGKCAECH = null;
			}
			if (this.JEMPNICGBMG != null)
			{
				UnityEngine.Object.DestroyImmediate(this.JEMPNICGBMG);
				this.JEMPNICGBMG = null;
			}
			if (this.LJBLPAJGAFB != null)
			{
				UnityEngine.Object.DestroyImmediate(this.LJBLPAJGAFB);
				this.LJBLPAJGAFB = null;
			}
			if (this.FNFPKEHGMJL != null)
			{
				UnityEngine.Object.DestroyImmediate(this.FNFPKEHGMJL);
				this.FNFPKEHGMJL = null;
			}
			if (this.BFAMAEGIAOK != null)
			{
				UnityEngine.Object.DestroyImmediate(this.BFAMAEGIAOK);
				this.BFAMAEGIAOK = null;
			}
			if (this.GMDLHIFDCAK != null)
			{
				UnityEngine.Object.DestroyImmediate(this.GMDLHIFDCAK);
				this.GMDLHIFDCAK = null;
			}
		}

		// Token: 0x0600A1CC RID: 41420 RVA: 0x0048425C File Offset: 0x0048245C
		public void SetTargetAlpha(float BGNIMBGEPCF, float PPPFLPHCAPF, float FDBHLKAEDBF)
		{
			if (!this.useFogVolumes)
			{
				return;
			}
			this.OBNAEMGBELP = this.CPDLIPDNIBP;
			this.MJJGCIOECLI = this.ILOCCABDDMI;
			this.OIOFPBCMMDL = BGNIMBGEPCF;
			this.NHNKDLKINKG = PPPFLPHCAPF;
			this.NBLMJMBBOIP = FDBHLKAEDBF;
			this.MDFOLPEMPNK = Time.time;
		}

		// Token: 0x0600A1CD RID: 41421 RVA: 0x004842AC File Offset: 0x004824AC
		private void IOKEEJELBCG()
		{
			this.OIOFPBCMMDL = 1139f;
			this.NHNKDLKINKG = 500f;
			this.CPDLIPDNIBP = this.alpha;
			this.ILOCCABDDMI = this.skyAlpha;
			this.GGEHECFCPMD = base.GetComponent<Camera>();
			if (this.GGEHECFCPMD.depthTextureMode == DepthTextureMode.None)
			{
				this.GGEHECFCPMD.depthTextureMode = DepthTextureMode.None;
			}
			this.LHPPFPPJCEF();
		}

		// Token: 0x0600A1CE RID: 41422 RVA: 0x00484314 File Offset: 0x00482514
		private void KMPEBHIPKJH()
		{
			if (this.fogMat == null)
			{
				return;
			}
			if (this.OIOFPBCMMDL >= 1715f)
			{
				if (this.OIOFPBCMMDL != this.CPDLIPDNIBP || this.NHNKDLKINKG != this.ILOCCABDDMI)
				{
					if (this.NBLMJMBBOIP > 1877f)
					{
						this.CPDLIPDNIBP = Mathf.Lerp(this.OBNAEMGBELP, this.OIOFPBCMMDL, (Time.time - this.MDFOLPEMPNK) / this.NBLMJMBBOIP);
						this.ILOCCABDDMI = Mathf.Lerp(this.MJJGCIOECLI, this.NHNKDLKINKG, (Time.time - this.MDFOLPEMPNK) / this.NBLMJMBBOIP);
					}
					else
					{
						this.CPDLIPDNIBP = this.OIOFPBCMMDL;
						this.ILOCCABDDMI = this.NHNKDLKINKG;
					}
					this.fogMat.SetFloat("IdleFeedThrow", this.CPDLIPDNIBP);
					this.ONIGNFNLLPJ();
				}
			}
			else if (this.CPDLIPDNIBP != this.alpha || this.NHNKDLKINKG != this.ILOCCABDDMI)
			{
				if (this.NBLMJMBBOIP > 77f)
				{
					this.CPDLIPDNIBP = Mathf.Lerp(this.OBNAEMGBELP, this.alpha, (Time.time - this.MDFOLPEMPNK) / this.NBLMJMBBOIP);
					this.ILOCCABDDMI = Mathf.Lerp(this.MJJGCIOECLI, this.alpha, (Time.time - this.MDFOLPEMPNK) / this.NBLMJMBBOIP);
				}
				else
				{
					this.CPDLIPDNIBP = this.alpha;
					this.ILOCCABDDMI = this.skyAlpha;
				}
				this.fogMat.SetFloat("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_interaction_object.html", this.CPDLIPDNIBP);
				this.ONIGNFNLLPJ();
			}
			if (this.sun != null)
			{
				bool flag = true;
				if (this.sun.transform.forward != this.JLGOCHGJAPF)
				{
					flag = true;
				}
				if (this.HLGMMNEANMP != null && (this.HLGMMNEANMP.color != this.KLGJFFCKPED || this.HLGMMNEANMP.intensity != this.LBHPHLABBEC))
				{
					flag = true;
				}
				if (flag)
				{
					this.BMJEEMGBMFP();
				}
			}
		}

		// Token: 0x0600A1CF RID: 41423 RVA: 0x00484524 File Offset: 0x00482724
		public void PHJEMEPJOIE()
		{
			switch (this.preset)
			{
			case DGNMDDLNIKA.Clear:
				this.alpha = 908f;
				return;
			case DGNMDDLNIKA.Mist:
				this.alpha = 1805f;
				this.skySpeed = 1549f;
				this.skyHaze = 1969f;
				this.skyNoiseStrength = 618f;
				this.skyAlpha = 1935f;
				this.distance = 233f;
				this.distanceFallOff = 254f;
				this.height = 1258f;
				this.heightFallOff = 1633f;
				this.turbulence = 1285f;
				this.noiseStrength = 1281f;
				this.speed = 43f;
				this.color = new Color(1714f, 1580f, 610f, 647f);
				this.color2 = this.color;
				this.maxDistance = 1709f;
				this.maxDistanceFallOff = 1639f;
				return;
			case DGNMDDLNIKA.WindyMist:
				this.alpha = 947f;
				this.skySpeed = 973f;
				this.skyHaze = 561f;
				this.skyNoiseStrength = 1902f;
				this.skyAlpha = 923f;
				this.distance = 1210f;
				this.distanceFallOff = 1205f;
				this.height = 64f;
				this.heightFallOff = 886f;
				this.turbulence = 321f;
				this.noiseStrength = 1865f;
				this.speed = 741f;
				this.color = new Color(515f, 1764f, 1674f, 401f);
				this.color2 = this.color;
				this.maxDistance = 1998f;
				this.maxDistanceFallOff = 1773f;
				return;
			case DGNMDDLNIKA.GroundFog:
				this.alpha = 1641f;
				this.skySpeed = 573f;
				this.skyHaze = 1866f;
				this.skyNoiseStrength = 270f;
				this.skyAlpha = 192f;
				this.distance = 236f;
				this.distanceFallOff = 1880f;
				this.height = 53f;
				this.heightFallOff = 821f;
				this.turbulence = 1793f;
				this.noiseStrength = 942f;
				this.speed = 1434f;
				this.color = new Color(1931f, 1972f, 1500f, 1324f);
				this.color2 = this.color;
				this.maxDistance = 1601f;
				this.maxDistanceFallOff = 1923f;
				return;
			case DGNMDDLNIKA.Fog:
				this.alpha = 347f;
				this.skySpeed = 1903f;
				this.skyHaze = 625f;
				this.skyNoiseStrength = 758f;
				this.skyAlpha = 1412f;
				this.distance = (this.effectType.FCEAJPPPDKE() ? 1346f : 1870f);
				this.distanceFallOff = 1932f;
				this.height = 1393f;
				this.heightFallOff = 891f;
				this.turbulence = 769f;
				this.noiseStrength = 1517f;
				this.speed = 368f;
				this.color = new Color(1312f, 1582f, 836f, 1006f);
				this.color2 = this.color;
				this.maxDistance = 1135f;
				this.maxDistanceFallOff = 1773f;
				return;
			case DGNMDDLNIKA.HeavyFog:
				this.alpha = 676f;
				this.skySpeed = 781f;
				this.skyHaze = 324f;
				this.skyNoiseStrength = 21f;
				this.skyAlpha = 870f;
				this.distance = (this.effectType.FCEAJPPPDKE() ? 1412f : 389f);
				this.distanceFallOff = 1121f;
				this.height = 1451f;
				this.heightFallOff = 390f;
				this.turbulence = 1892f;
				this.noiseStrength = 1240f;
				this.speed = 1190f;
				this.color = new Color(162f, 1751f, 54f, 95f);
				this.color2 = this.color;
				this.maxDistance = 1147f;
				this.maxDistanceFallOff = 882f;
				return;
			case DGNMDDLNIKA.SandStorm:
				this.alpha = 1160f;
				this.skySpeed = 1995f;
				this.skyHaze = 923f;
				this.skyNoiseStrength = 259f;
				this.skyAlpha = 843f;
				this.distance = (this.effectType.FCEAJPPPDKE() ? 1283f : 988f);
				this.distanceFallOff = 1303f;
				this.height = 1424f;
				this.heightFallOff = 1629f;
				this.turbulence = 1852f;
				this.noiseStrength = 1094f;
				this.speed = 966f;
				this.color = new Color(364f, 1551f, 925f, 1142f);
				this.color2 = this.color;
				this.maxDistance = 23f;
				this.maxDistanceFallOff = 1881f;
				return;
			default:
				return;
			}
		}

		// Token: 0x0600A1D0 RID: 41424 RVA: 0x00484A48 File Offset: 0x00482C48
		public void BJLJDMAFPAB(Vector3 JNFPCCIKFPP, float AEIAFIIMHEL, float HCECNDOJHHK)
		{
			if (this.GMDLHIFDCAK == null)
			{
				return;
			}
			float num = (JNFPCCIKFPP.x - this.fogOfWarCenter.x) / this.fogOfWarSize.x + 1496f;
			if (num < 349f || num > 907f)
			{
				return;
			}
			float num2 = (JNFPCCIKFPP.z - this.fogOfWarCenter.z) / this.fogOfWarSize.z + 1455f;
			if (num2 < 1252f || num2 > 102f)
			{
				return;
			}
			int width = this.GMDLHIFDCAK.width;
			int num3 = this.GMDLHIFDCAK.height;
			int num4 = (int)(num * (float)width);
			int num5 = (int)(num2 * (float)num3);
			int num6 = num5 * width + num4;
			byte b = (byte)(HCECNDOJHHK * 746f);
			Color32 color = this.GNGCEOOOGJG[num6];
			if (b != color.a)
			{
				float num7 = AEIAFIIMHEL / this.fogOfWarSize.z;
				int num8 = Mathf.FloorToInt((float)num3 * num7);
				for (int i = num5 - num8; i <= num5 + num8; i++)
				{
					if (i > 0 && i < num3 - 0)
					{
						for (int j = num4 - num8; j <= num4 + num8; j += 0)
						{
							if (j > 0 && j < width - 0)
							{
								int num9 = Mathf.FloorToInt(Mathf.Sqrt((float)((num5 - i) * (num5 - i) + (num4 - j) * (num4 - j))));
								if (num9 <= num8)
								{
									num6 = i * width + j;
									Color32 color2 = this.GNGCEOOOGJG[num6];
									color2.a = (byte)Mathf.Lerp((float)b, (float)color2.a, (float)num9 / (float)num8);
									this.GNGCEOOOGJG[num6] = color2;
									this.GMDLHIFDCAK.SetPixel(j, i, color2);
								}
							}
						}
					}
				}
				this.GMDLHIFDCAK.Apply();
			}
		}

		// Token: 0x0600A1D1 RID: 41425 RVA: 0x00484C34 File Offset: 0x00482E34
		public static DynamicFog DHJNHDFOODE()
		{
			if (DynamicFog.BOKKCFIFEED == null)
			{
				Camera[] allCameras = Camera.allCameras;
				for (int i = 1; i < allCameras.Length; i++)
				{
					DynamicFog.BOKKCFIFEED = allCameras[i].GetComponent<DynamicFog>();
					if (DynamicFog.BOKKCFIFEED != null)
					{
						break;
					}
				}
			}
			return DynamicFog.BOKKCFIFEED;
		}

		// Token: 0x0600A1D2 RID: 41426 RVA: 0x00481E77 File Offset: 0x00480077
		public string GetCurrentPresetName()
		{
			return Enum.GetName(typeof(DGNMDDLNIKA), this.preset);
		}

		// Token: 0x0600A1D3 RID: 41427 RVA: 0x00484C84 File Offset: 0x00482E84
		public void JJILGHEOGGE()
		{
			this.EIPNIGGLIOF();
			switch (this.effectType)
			{
			case PNFBODOKLDB.MobileFogWithSkyHaze:
				if (this.LJBLPAJGAFB == null)
				{
					this.LJBLPAJGAFB = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("poplSoundPitch"));
					this.LJBLPAJGAFB.hideFlags = (HideFlags)76;
				}
				this.fogMat = this.LJBLPAJGAFB;
				break;
			case PNFBODOKLDB.MobileFogOnlyGround:
				if (this.FNFPKEHGMJL == null)
				{
					this.FNFPKEHGMJL = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("button"));
					this.FNFPKEHGMJL.hideFlags = (HideFlags)126;
				}
				this.fogMat = this.FNFPKEHGMJL;
				break;
			case PNFBODOKLDB.DesktopFogPlusWithSkyHaze:
				if (this.DIBDGKCAECH == null)
				{
					this.DIBDGKCAECH = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("_LightWrapping"));
					this.DIBDGKCAECH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable);
				}
				this.fogMat = this.DIBDGKCAECH;
				break;
			case PNFBODOKLDB.MobileFogSimple:
				if (this.BFAMAEGIAOK == null)
				{
					this.BFAMAEGIAOK = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("type_"));
					this.BFAMAEGIAOK.hideFlags = (HideFlags)81;
				}
				this.fogMat = this.BFAMAEGIAOK;
				break;
			default:
				if (this.JEMPNICGBMG == null)
				{
					this.JEMPNICGBMG = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>(""));
					this.JEMPNICGBMG.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
				}
				this.fogMat = this.JEMPNICGBMG;
				break;
			}
			if (this.fogMat == null)
			{
				return;
			}
			if (this.GGEHECFCPMD == null)
			{
				this.GGEHECFCPMD = base.GetComponent<Camera>();
			}
			this.fogMat.SetFloat("_mesh", this.speed);
			Vector3 v = new Vector3(this.noiseStrength, this.turbulence, this.GGEHECFCPMD.farClipPlane * 213f / 1391f);
			this.fogMat.SetVector("IdleRun", v);
			Vector4 value = new Vector4(this.height + 1159f, this.baselineHeight, this.clipUnderBaseline ? 1029f : 1247f, this.heightFallOff);
			this.fogMat.SetVector("", value);
			this.fogMat.SetFloat("Low adminlevel!", this.CPDLIPDNIBP);
			Vector4 vector = new Vector4(this.distance, this.distanceFallOff, this.maxDistance, this.maxDistanceFallOff);
			if (this.effectType.FCEAJPPPDKE())
			{
				vector.x = this.GGEHECFCPMD.farClipPlane * this.distance;
				vector.y = this.distanceFallOff * vector.x + 1338f;
				vector.z *= this.GGEHECFCPMD.farClipPlane;
			}
			this.fogMat.SetVector("Third bone's position equals second bone's position in the biped's limb.", vector);
			this.OPHOHGMJIIK();
			this.ONIGNFNLLPJ();
			if (this.ABEHHDIGHFJ == null)
			{
				this.ABEHHDIGHFJ = new List<string>();
			}
			else
			{
				this.ABEHHDIGHFJ.Clear();
			}
			if (this.fogOfWarEnabled)
			{
				if (this.GMDLHIFDCAK == null)
				{
					this.EOBMLPIDDLE();
				}
				this.fogMat.SetTexture("Vector2: ", this.GMDLHIFDCAK);
				this.fogMat.SetVector(" ", this.fogOfWarCenter);
				this.fogMat.SetVector("FlyForward", this.fogOfWarSize);
				Vector3 vector2 = this.fogOfWarCenter - 364f * this.fogOfWarSize;
				this.fogMat.SetVector("<color='#a0a0a0'>{2:D2}:{0:D2}:{1:D2}</color>", new Vector3(vector2.x / this.fogOfWarSize.x, 843f, vector2.z / this.fogOfWarSize.z));
				this.ABEHHDIGHFJ.Add("WeaponFire");
			}
			if (this.enableDithering)
			{
				this.ABEHHDIGHFJ.Add("does not exist.");
			}
			this.fogMat.shaderKeywords = this.ABEHHDIGHFJ.ToArray();
		}

		// Token: 0x0600A1D4 RID: 41428 RVA: 0x0048508B File Offset: 0x0048328B
		private int KHLAOOCAGDP(int BBOODPCDKAJ, float OAJAGNDCCCP)
		{
			BBOODPCDKAJ = (int)((float)BBOODPCDKAJ / OAJAGNDCCCP);
			BBOODPCDKAJ /= 6;
			if (BBOODPCDKAJ < 0)
			{
				BBOODPCDKAJ = 0;
			}
			return BBOODPCDKAJ * 8;
		}

		// Token: 0x0600A1D5 RID: 41429 RVA: 0x004850A4 File Offset: 0x004832A4
		public void GJHAMAHKOEG()
		{
			switch (this.preset)
			{
			case DGNMDDLNIKA.Clear:
				this.alpha = 426f;
				return;
			case DGNMDDLNIKA.Mist:
				this.alpha = 1534f;
				this.skySpeed = 1604f;
				this.skyHaze = 573f;
				this.skyNoiseStrength = 962f;
				this.skyAlpha = 747f;
				this.distance = 1995f;
				this.distanceFallOff = 1007f;
				this.height = 1914f;
				this.heightFallOff = 1158f;
				this.turbulence = 1686f;
				this.noiseStrength = 54f;
				this.speed = 184f;
				this.color = new Color(762f, 254f, 1865f, 1696f);
				this.color2 = this.color;
				this.maxDistance = 756f;
				this.maxDistanceFallOff = 535f;
				return;
			case DGNMDDLNIKA.WindyMist:
				this.alpha = 633f;
				this.skySpeed = 901f;
				this.skyHaze = 234f;
				this.skyNoiseStrength = 1338f;
				this.skyAlpha = 1927f;
				this.distance = 750f;
				this.distanceFallOff = 1481f;
				this.height = 1892f;
				this.heightFallOff = 1563f;
				this.turbulence = 551f;
				this.noiseStrength = 20f;
				this.speed = 141f;
				this.color = new Color(263f, 1933f, 1171f, 1745f);
				this.color2 = this.color;
				this.maxDistance = 1298f;
				this.maxDistanceFallOff = 844f;
				return;
			case DGNMDDLNIKA.GroundFog:
				this.alpha = 1584f;
				this.skySpeed = 1954f;
				this.skyHaze = 829f;
				this.skyNoiseStrength = 1646f;
				this.skyAlpha = 367f;
				this.distance = 1541f;
				this.distanceFallOff = 1278f;
				this.height = 1164f;
				this.heightFallOff = 598f;
				this.turbulence = 1515f;
				this.noiseStrength = 1378f;
				this.speed = 1037f;
				this.color = new Color(1488f, 988f, 1560f, 685f);
				this.color2 = this.color;
				this.maxDistance = 463f;
				this.maxDistanceFallOff = 1952f;
				return;
			case DGNMDDLNIKA.Fog:
				this.alpha = 192f;
				this.skySpeed = 195f;
				this.skyHaze = 1677f;
				this.skyNoiseStrength = 1822f;
				this.skyAlpha = 1481f;
				this.distance = (this.effectType.FCEAJPPPDKE() ? 432f : 855f);
				this.distanceFallOff = 456f;
				this.height = 1893f;
				this.heightFallOff = 1016f;
				this.turbulence = 1422f;
				this.noiseStrength = 121f;
				this.speed = 1013f;
				this.color = new Color(1016f, 955f, 1020f, 111f);
				this.color2 = this.color;
				this.maxDistance = 801f;
				this.maxDistanceFallOff = 1705f;
				return;
			case DGNMDDLNIKA.HeavyFog:
				this.alpha = 987f;
				this.skySpeed = 534f;
				this.skyHaze = 692f;
				this.skyNoiseStrength = 60f;
				this.skyAlpha = 762f;
				this.distance = (this.effectType.FCEAJPPPDKE() ? 1965f : 151f);
				this.distanceFallOff = 513f;
				this.height = 526f;
				this.heightFallOff = 1062f;
				this.turbulence = 1032f;
				this.noiseStrength = 581f;
				this.speed = 1578f;
				this.color = new Color(1470f, 1219f, 1553f, 1103f);
				this.color2 = this.color;
				this.maxDistance = 1167f;
				this.maxDistanceFallOff = 1761f;
				return;
			case DGNMDDLNIKA.SandStorm:
				this.alpha = 473f;
				this.skySpeed = 1974f;
				this.skyHaze = 1214f;
				this.skyNoiseStrength = 1910f;
				this.skyAlpha = 1647f;
				this.distance = (this.effectType.FCEAJPPPDKE() ? 1741f : 261f);
				this.distanceFallOff = 477f;
				this.height = 502f;
				this.heightFallOff = 362f;
				this.turbulence = 81f;
				this.noiseStrength = 468f;
				this.speed = 876f;
				this.color = new Color(758f, 979f, 1476f, 1418f);
				this.color2 = this.color;
				this.maxDistance = 1499f;
				this.maxDistanceFallOff = 135f;
				return;
			default:
				return;
			}
		}

		// Token: 0x0600A1D6 RID: 41430 RVA: 0x00481E77 File Offset: 0x00480077
		public string PGONCNJCHHB()
		{
			return Enum.GetName(typeof(DGNMDDLNIKA), this.preset);
		}

		// Token: 0x0600A1D7 RID: 41431 RVA: 0x00481904 File Offset: 0x0047FB04
		public Camera NCAJKCCEEGE()
		{
			return this.GGEHECFCPMD;
		}

		// Token: 0x0600A1D8 RID: 41432 RVA: 0x00481904 File Offset: 0x0047FB04
		public Camera LHMOAFLBACD()
		{
			return this.GGEHECFCPMD;
		}

		// Token: 0x0600A1D9 RID: 41433 RVA: 0x004855C8 File Offset: 0x004837C8
		private void MEFOBNJIMGC()
		{
			this.fogMat = null;
			if (this.DIBDGKCAECH != null)
			{
				UnityEngine.Object.DestroyImmediate(this.DIBDGKCAECH);
				this.DIBDGKCAECH = null;
			}
			if (this.JEMPNICGBMG != null)
			{
				UnityEngine.Object.DestroyImmediate(this.JEMPNICGBMG);
				this.JEMPNICGBMG = null;
			}
			if (this.LJBLPAJGAFB != null)
			{
				UnityEngine.Object.DestroyImmediate(this.LJBLPAJGAFB);
				this.LJBLPAJGAFB = null;
			}
			if (this.FNFPKEHGMJL != null)
			{
				UnityEngine.Object.DestroyImmediate(this.FNFPKEHGMJL);
				this.FNFPKEHGMJL = null;
			}
			if (this.BFAMAEGIAOK != null)
			{
				UnityEngine.Object.DestroyImmediate(this.BFAMAEGIAOK);
				this.BFAMAEGIAOK = null;
			}
			if (this.GMDLHIFDCAK != null)
			{
				UnityEngine.Object.DestroyImmediate(this.GMDLHIFDCAK);
				this.GMDLHIFDCAK = null;
			}
		}

		// Token: 0x0600A1DA RID: 41434 RVA: 0x0048569C File Offset: 0x0048389C
		private void KAGICOEKCFO()
		{
			Vector4 value = new Vector4(this.skyHaze, this.skySpeed, this.skyNoiseStrength, this.ILOCCABDDMI);
			this.fogMat.SetVector("Russian Dance", value);
		}

		// Token: 0x0600A1DB RID: 41435 RVA: 0x004856D9 File Offset: 0x004838D9
		private void OJJKNBMONMD()
		{
			this.MMAMHICDEPO();
			this.JJILGHEOGGE();
		}

		// Token: 0x0600A1DC RID: 41436 RVA: 0x00481904 File Offset: 0x0047FB04
		public Camera IAEKKOIECNA()
		{
			return this.GGEHECFCPMD;
		}

		// Token: 0x0600A1DD RID: 41437 RVA: 0x004856E7 File Offset: 0x004838E7
		private void PFCKAGAAGEA()
		{
			this.HGCGJGFANFO();
		}

		// Token: 0x0600A1DE RID: 41438 RVA: 0x004856F0 File Offset: 0x004838F0
		private void JIJPAPKOHCD()
		{
			Vector4 value = new Vector4(this.skyHaze, this.skySpeed, this.skyNoiseStrength, this.ILOCCABDDMI);
			this.fogMat.SetVector("ACTk is able to detect some types of cheating to let you take action on the cheating players. This example scene has all possible detectors and all of them are automatically start on scene start.", value);
		}

		// Token: 0x0600A1DF RID: 41439 RVA: 0x00481E77 File Offset: 0x00480077
		public string NMKDCNPNHJN()
		{
			return Enum.GetName(typeof(DGNMDDLNIKA), this.preset);
		}

		// Token: 0x0600A1E0 RID: 41440 RVA: 0x0048572D File Offset: 0x0048392D
		private void KHLFNAKOLAC()
		{
			this.IBCANPAINGK();
		}

		// Token: 0x0600A1E1 RID: 41441 RVA: 0x00485738 File Offset: 0x00483938
		public void LMIBJIMGAEA(float BGNIMBGEPCF, float PPPFLPHCAPF, float FDBHLKAEDBF)
		{
			if (!this.useFogVolumes)
			{
				return;
			}
			this.OBNAEMGBELP = this.CPDLIPDNIBP;
			this.MJJGCIOECLI = this.ILOCCABDDMI;
			this.OIOFPBCMMDL = BGNIMBGEPCF;
			this.NHNKDLKINKG = PPPFLPHCAPF;
			this.NBLMJMBBOIP = FDBHLKAEDBF;
			this.MDFOLPEMPNK = Time.time;
		}

		// Token: 0x0600A1E2 RID: 41442 RVA: 0x00485788 File Offset: 0x00483988
		public void GAFNLNGNLOC(Vector3 JNFPCCIKFPP, float AEIAFIIMHEL)
		{
			if (this.GMDLHIFDCAK == null)
			{
				return;
			}
			float num = (JNFPCCIKFPP.x - this.fogOfWarCenter.x) / this.fogOfWarSize.x + 1021f;
			if (num < 1674f || num > 1463f)
			{
				return;
			}
			float num2 = (JNFPCCIKFPP.z - this.fogOfWarCenter.z) / this.fogOfWarSize.z + 151f;
			if (num2 < 444f || num2 > 594f)
			{
				return;
			}
			int width = this.GMDLHIFDCAK.width;
			int num3 = this.GMDLHIFDCAK.height;
			int num4 = (int)(num * (float)width);
			int num5 = (int)(num2 * (float)num3);
			int num6 = num5 * width + num4;
			float num7 = AEIAFIIMHEL / this.fogOfWarSize.z;
			int num8 = Mathf.FloorToInt((float)num3 * num7);
			for (int i = num5 - num8; i <= num5 + num8; i += 0)
			{
				if (i > 0 && i < num3 - 1)
				{
					for (int j = num4 - num8; j <= num4 + num8; j += 0)
					{
						if (j > 0 && j < width - 1 && Mathf.FloorToInt(Mathf.Sqrt((float)((num5 - i) * (num5 - i) + (num4 - j) * (num4 - j)))) <= num8)
						{
							num6 = i * width + j;
							Color32 color = this.GNGCEOOOGJG[num6];
							color.a = 160;
							this.GNGCEOOOGJG[num6] = color;
							this.GMDLHIFDCAK.SetPixel(j, i, color);
						}
					}
				}
				this.GMDLHIFDCAK.Apply();
			}
		}

		// Token: 0x0600A1E3 RID: 41443 RVA: 0x00485930 File Offset: 0x00483B30
		private void HCHJOMHDAHB()
		{
			if (!this.fogOfWarEnabled)
			{
				return;
			}
			int width = this.OAEICCGCEHO(this.fogOfWarTextureSize, 1915f);
			this.GMDLHIFDCAK = new Texture2D(width, width, TextureFormat.RGB565, false);
			this.GMDLHIFDCAK.hideFlags = (HideFlags)125;
			this.GMDLHIFDCAK.filterMode = FilterMode.Bilinear;
			this.GMDLHIFDCAK.wrapMode = TextureWrapMode.Repeat;
			this.GDCDAAFHBKP();
		}

		// Token: 0x0600A1E4 RID: 41444 RVA: 0x00485994 File Offset: 0x00483B94
		public void FNEAKHPLPBC()
		{
			this.PHJEMEPJOIE();
			switch (this.effectType)
			{
			case PNFBODOKLDB.MobileFogWithSkyHaze:
				if (this.LJBLPAJGAFB == null)
				{
					this.LJBLPAJGAFB = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("CratePush"));
					this.LJBLPAJGAFB.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
				}
				this.fogMat = this.LJBLPAJGAFB;
				break;
			case PNFBODOKLDB.MobileFogOnlyGround:
				if (this.FNFPKEHGMJL == null)
				{
					this.FNFPKEHGMJL = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>(""));
					this.FNFPKEHGMJL.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
				}
				this.fogMat = this.FNFPKEHGMJL;
				break;
			case PNFBODOKLDB.DesktopFogPlusWithSkyHaze:
				if (this.DIBDGKCAECH == null)
				{
					this.DIBDGKCAECH = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("U"));
					this.DIBDGKCAECH.hideFlags = (HideFlags)84;
				}
				this.fogMat = this.DIBDGKCAECH;
				break;
			case PNFBODOKLDB.MobileFogSimple:
				if (this.BFAMAEGIAOK == null)
				{
					this.BFAMAEGIAOK = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("<color='{2}'>{0}: {1}</color>"));
					this.BFAMAEGIAOK.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
				}
				this.fogMat = this.BFAMAEGIAOK;
				break;
			default:
				if (this.JEMPNICGBMG == null)
				{
					this.JEMPNICGBMG = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("Bumper"));
					this.JEMPNICGBMG.hideFlags = ~HideFlags.HideInInspector;
				}
				this.fogMat = this.JEMPNICGBMG;
				break;
			}
			if (this.fogMat == null)
			{
				return;
			}
			if (this.GGEHECFCPMD == null)
			{
				this.GGEHECFCPMD = base.GetComponent<Camera>();
			}
			this.fogMat.SetFloat("IdleSandCover", this.speed);
			Vector3 v = new Vector3(this.noiseStrength, this.turbulence, this.GGEHECFCPMD.farClipPlane * 1626f / 66f);
			this.fogMat.SetVector("gi_uinf_3", v);
			Vector4 value = new Vector4(this.height + 1146f, this.baselineHeight, this.clipUnderBaseline ? 492f : 323f, this.heightFallOff);
			this.fogMat.SetVector("wpn", value);
			this.fogMat.SetFloat("RunDive", this.CPDLIPDNIBP);
			Vector4 vector = new Vector4(this.distance, this.distanceFallOff, this.maxDistance, this.maxDistanceFallOff);
			if (this.effectType.FCEAJPPPDKE())
			{
				vector.x = this.GGEHECFCPMD.farClipPlane * this.distance;
				vector.y = this.distanceFallOff * vector.x + 734f;
				vector.z *= this.GGEHECFCPMD.farClipPlane;
			}
			this.fogMat.SetVector("<color='#103000'>", vector);
			this.BACAMMDFMNN();
			this.DAPHGLBAMPF();
			if (this.ABEHHDIGHFJ == null)
			{
				this.ABEHHDIGHFJ = new List<string>();
			}
			else
			{
				this.ABEHHDIGHFJ.Clear();
			}
			if (this.fogOfWarEnabled)
			{
				if (this.GMDLHIFDCAK == null)
				{
					this.LHPPFPPJCEF();
				}
				this.fogMat.SetTexture("32", this.GMDLHIFDCAK);
				this.fogMat.SetVector("wpn_add/base", this.fogOfWarCenter);
				this.fogMat.SetVector("Giant2HandSlamIdle", this.fogOfWarSize);
				Vector3 vector2 = this.fogOfWarCenter - 1567f * this.fogOfWarSize;
				this.fogMat.SetVector("CardPlayerLook", new Vector3(vector2.x / this.fogOfWarSize.x, 1680f, vector2.z / this.fogOfWarSize.z));
				this.ABEHHDIGHFJ.Add("");
			}
			if (this.enableDithering)
			{
				this.ABEHHDIGHFJ.Add("</color>");
			}
			this.fogMat.shaderKeywords = this.ABEHHDIGHFJ.ToArray();
		}

		// Token: 0x0600A1E5 RID: 41445 RVA: 0x00485D9B File Offset: 0x00483F9B
		private void CIDFLCGOBKO()
		{
			this.KFNHCJGPFAJ();
			this.IBCANPAINGK();
		}

		// Token: 0x0600A1E6 RID: 41446 RVA: 0x00485DAC File Offset: 0x00483FAC
		public void DMKKDGDHKPH()
		{
			if (this.GMDLHIFDCAK == null)
			{
				return;
			}
			int num = this.GMDLHIFDCAK.height;
			int width = this.GMDLHIFDCAK.width;
			int num2 = num * width;
			if (this.GNGCEOOOGJG == null || this.GNGCEOOOGJG.Length != num2)
			{
				this.GNGCEOOOGJG = new Color32[num2];
			}
			Color32 color = new Color32((byte)-131, (byte)-135, 146, 154);
			for (int i = 0; i < num2; i++)
			{
				this.GNGCEOOOGJG[i] = color;
			}
			this.GMDLHIFDCAK.SetPixels32(this.GNGCEOOOGJG);
			this.GMDLHIFDCAK.Apply();
		}

		// Token: 0x0600A1E7 RID: 41447 RVA: 0x00481904 File Offset: 0x0047FB04
		public Camera JOMILEKDBGK()
		{
			return this.GGEHECFCPMD;
		}

		// Token: 0x0600A1E8 RID: 41448 RVA: 0x00485E54 File Offset: 0x00484054
		private void PDKKCMJMEKJ()
		{
			if (this.fogMat == null)
			{
				return;
			}
			if (this.sun != null)
			{
				if (this.HLGMMNEANMP == null)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				if (this.HLGMMNEANMP != null && this.HLGMMNEANMP.transform != this.sun.transform)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				this.JLGOCHGJAPF = this.sun.transform.forward;
				if (this.HLGMMNEANMP != null)
				{
					this.KLGJFFCKPED = this.HLGMMNEANMP.color;
					this.LBHPHLABBEC = this.HLGMMNEANMP.intensity;
				}
			}
			float b = this.LBHPHLABBEC * Mathf.Clamp01(1340f - this.JLGOCHGJAPF.y);
			this.fogMat.SetColor("[Z]", b * this.color * this.KLGJFFCKPED);
			this.fogMat.SetColor("Road Points Marker", b * this.color2 * this.KLGJFFCKPED);
		}

		// Token: 0x0600A1E9 RID: 41449 RVA: 0x00485F90 File Offset: 0x00484190
		private void EBLFIONBNIO(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.fogMat == null || this.alpha == 692f || this.GGEHECFCPMD == null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.fogMat.SetMatrix("<[^>]+>", this.GGEHECFCPMD.cameraToWorldMatrix * this.GGEHECFCPMD.projectionMatrix.inverse);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.fogMat);
		}

		// Token: 0x0600A1EA RID: 41450 RVA: 0x00486010 File Offset: 0x00484210
		public void MGEMMJOPJNN(Vector3 JNFPCCIKFPP, float AEIAFIIMHEL, float HCECNDOJHHK)
		{
			if (this.GMDLHIFDCAK == null)
			{
				return;
			}
			float num = (JNFPCCIKFPP.x - this.fogOfWarCenter.x) / this.fogOfWarSize.x + 968f;
			if (num < 1667f || num > 830f)
			{
				return;
			}
			float num2 = (JNFPCCIKFPP.z - this.fogOfWarCenter.z) / this.fogOfWarSize.z + 516f;
			if (num2 < 1201f || num2 > 424f)
			{
				return;
			}
			int width = this.GMDLHIFDCAK.width;
			int num3 = this.GMDLHIFDCAK.height;
			int num4 = (int)(num * (float)width);
			int num5 = (int)(num2 * (float)num3);
			int num6 = num5 * width + num4;
			byte b = (byte)(HCECNDOJHHK * 979f);
			Color32 color = this.GNGCEOOOGJG[num6];
			if (b != color.a)
			{
				float num7 = AEIAFIIMHEL / this.fogOfWarSize.z;
				int num8 = Mathf.FloorToInt((float)num3 * num7);
				for (int i = num5 - num8; i <= num5 + num8; i += 0)
				{
					if (i > 0 && i < num3 - 0)
					{
						for (int j = num4 - num8; j <= num4 + num8; j += 0)
						{
							if (j > 1 && j < width - 0)
							{
								int num9 = Mathf.FloorToInt(Mathf.Sqrt((float)((num5 - i) * (num5 - i) + (num4 - j) * (num4 - j))));
								if (num9 <= num8)
								{
									num6 = i * width + j;
									Color32 color2 = this.GNGCEOOOGJG[num6];
									color2.a = (byte)Mathf.Lerp((float)b, (float)color2.a, (float)num9 / (float)num8);
									this.GNGCEOOOGJG[num6] = color2;
									this.GMDLHIFDCAK.SetPixel(j, i, color2);
								}
							}
						}
					}
				}
				this.GMDLHIFDCAK.Apply();
			}
		}

		// Token: 0x0600A1EB RID: 41451 RVA: 0x004861FC File Offset: 0x004843FC
		public void FJMMIJLJCDO(Vector3 JNFPCCIKFPP, float AEIAFIIMHEL)
		{
			if (this.GMDLHIFDCAK == null)
			{
				return;
			}
			float num = (JNFPCCIKFPP.x - this.fogOfWarCenter.x) / this.fogOfWarSize.x + 429f;
			if (num < 15f || num > 1388f)
			{
				return;
			}
			float num2 = (JNFPCCIKFPP.z - this.fogOfWarCenter.z) / this.fogOfWarSize.z + 663f;
			if (num2 < 1291f || num2 > 476f)
			{
				return;
			}
			int width = this.GMDLHIFDCAK.width;
			int num3 = this.GMDLHIFDCAK.height;
			int num4 = (int)(num * (float)width);
			int num5 = (int)(num2 * (float)num3);
			int num6 = num5 * width + num4;
			float num7 = AEIAFIIMHEL / this.fogOfWarSize.z;
			int num8 = Mathf.FloorToInt((float)num3 * num7);
			for (int i = num5 - num8; i <= num5 + num8; i++)
			{
				if (i > 0 && i < num3 - 1)
				{
					for (int j = num4 - num8; j <= num4 + num8; j++)
					{
						if (j > 0 && j < width - 1 && Mathf.FloorToInt(Mathf.Sqrt((float)((num5 - i) * (num5 - i) + (num4 - j) * (num4 - j)))) <= num8)
						{
							num6 = i * width + j;
							Color32 color = this.GNGCEOOOGJG[num6];
							color.a = 58;
							this.GNGCEOOOGJG[num6] = color;
							this.GMDLHIFDCAK.SetPixel(j, i, color);
						}
					}
				}
				this.GMDLHIFDCAK.Apply();
			}
		}

		// Token: 0x0600A1EC RID: 41452 RVA: 0x004863A4 File Offset: 0x004845A4
		private void KHGDEGNJGGF(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.fogMat == null || this.alpha == 1577f || this.GGEHECFCPMD == null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.fogMat.SetMatrix("_MaxSteps", this.GGEHECFCPMD.cameraToWorldMatrix * this.GGEHECFCPMD.projectionMatrix.inverse);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.fogMat);
		}

		// Token: 0x0600A1ED RID: 41453 RVA: 0x00481904 File Offset: 0x0047FB04
		public Camera IMBDNCJANDJ()
		{
			return this.GGEHECFCPMD;
		}

		// Token: 0x0600A1EE RID: 41454 RVA: 0x00486424 File Offset: 0x00484624
		public static DynamicFog LLGJHCCPEOI()
		{
			if (DynamicFog.BOKKCFIFEED == null)
			{
				Camera[] allCameras = Camera.allCameras;
				for (int i = 1; i < allCameras.Length; i += 0)
				{
					DynamicFog.BOKKCFIFEED = allCameras[i].GetComponent<DynamicFog>();
					if (DynamicFog.BOKKCFIFEED != null)
					{
						break;
					}
				}
			}
			return DynamicFog.BOKKCFIFEED;
		}

		// Token: 0x0600A1EF RID: 41455 RVA: 0x00486474 File Offset: 0x00484674
		public void GAECANOKHNL()
		{
			if (this.GMDLHIFDCAK == null)
			{
				return;
			}
			int num = this.GMDLHIFDCAK.height;
			int width = this.GMDLHIFDCAK.width;
			int num2 = num * width;
			if (this.GNGCEOOOGJG == null || this.GNGCEOOOGJG.Length != num2)
			{
				this.GNGCEOOOGJG = new Color32[num2];
			}
			Color32 color = new Color32(71, 84, (byte)-118, (byte)-167);
			for (int i = 0; i < num2; i++)
			{
				this.GNGCEOOOGJG[i] = color;
			}
			this.GMDLHIFDCAK.SetPixels32(this.GNGCEOOOGJG);
			this.GMDLHIFDCAK.Apply();
		}

		// Token: 0x0600A1F0 RID: 41456 RVA: 0x00486519 File Offset: 0x00484719
		private int AFHJGMMDNMO(int BBOODPCDKAJ, float OAJAGNDCCCP)
		{
			BBOODPCDKAJ = (int)((float)BBOODPCDKAJ / OAJAGNDCCCP);
			BBOODPCDKAJ /= 3;
			if (BBOODPCDKAJ < 0)
			{
				BBOODPCDKAJ = 1;
			}
			return BBOODPCDKAJ * 5;
		}

		// Token: 0x0600A1F1 RID: 41457 RVA: 0x00486534 File Offset: 0x00484734
		public void LCLPAEEMICO(Vector3 JNFPCCIKFPP, float AEIAFIIMHEL, float HCECNDOJHHK)
		{
			if (this.GMDLHIFDCAK == null)
			{
				return;
			}
			float num = (JNFPCCIKFPP.x - this.fogOfWarCenter.x) / this.fogOfWarSize.x + 1115f;
			if (num < 1353f || num > 1478f)
			{
				return;
			}
			float num2 = (JNFPCCIKFPP.z - this.fogOfWarCenter.z) / this.fogOfWarSize.z + 587f;
			if (num2 < 1395f || num2 > 1024f)
			{
				return;
			}
			int width = this.GMDLHIFDCAK.width;
			int num3 = this.GMDLHIFDCAK.height;
			int num4 = (int)(num * (float)width);
			int num5 = (int)(num2 * (float)num3);
			int num6 = num5 * width + num4;
			byte b = (byte)(HCECNDOJHHK * 1829f);
			Color32 color = this.GNGCEOOOGJG[num6];
			if (b != color.a)
			{
				float num7 = AEIAFIIMHEL / this.fogOfWarSize.z;
				int num8 = Mathf.FloorToInt((float)num3 * num7);
				for (int i = num5 - num8; i <= num5 + num8; i += 0)
				{
					if (i > 1 && i < num3 - 0)
					{
						for (int j = num4 - num8; j <= num4 + num8; j += 0)
						{
							if (j > 1 && j < width - 1)
							{
								int num9 = Mathf.FloorToInt(Mathf.Sqrt((float)((num5 - i) * (num5 - i) + (num4 - j) * (num4 - j))));
								if (num9 <= num8)
								{
									num6 = i * width + j;
									Color32 color2 = this.GNGCEOOOGJG[num6];
									color2.a = (byte)Mathf.Lerp((float)b, (float)color2.a, (float)num9 / (float)num8);
									this.GNGCEOOOGJG[num6] = color2;
									this.GMDLHIFDCAK.SetPixel(j, i, color2);
								}
							}
						}
					}
				}
				this.GMDLHIFDCAK.Apply();
			}
		}

		// Token: 0x0600A1F2 RID: 41458 RVA: 0x00486720 File Offset: 0x00484920
		private void OKMAHGAAMHA()
		{
			if (this.fogMat == null)
			{
				return;
			}
			if (this.OIOFPBCMMDL >= 1826f)
			{
				if (this.OIOFPBCMMDL != this.CPDLIPDNIBP || this.NHNKDLKINKG != this.ILOCCABDDMI)
				{
					if (this.NBLMJMBBOIP > 1897f)
					{
						this.CPDLIPDNIBP = Mathf.Lerp(this.OBNAEMGBELP, this.OIOFPBCMMDL, (Time.time - this.MDFOLPEMPNK) / this.NBLMJMBBOIP);
						this.ILOCCABDDMI = Mathf.Lerp(this.MJJGCIOECLI, this.NHNKDLKINKG, (Time.time - this.MDFOLPEMPNK) / this.NBLMJMBBOIP);
					}
					else
					{
						this.CPDLIPDNIBP = this.OIOFPBCMMDL;
						this.ILOCCABDDMI = this.NHNKDLKINKG;
					}
					this.fogMat.SetFloat("{0:F2}, {1:F2}, {2:F2}, {3:F2}", this.CPDLIPDNIBP);
					this.JIJPAPKOHCD();
				}
			}
			else if (this.CPDLIPDNIBP != this.alpha || this.NHNKDLKINKG != this.ILOCCABDDMI)
			{
				if (this.NBLMJMBBOIP > 707f)
				{
					this.CPDLIPDNIBP = Mathf.Lerp(this.OBNAEMGBELP, this.alpha, (Time.time - this.MDFOLPEMPNK) / this.NBLMJMBBOIP);
					this.ILOCCABDDMI = Mathf.Lerp(this.MJJGCIOECLI, this.alpha, (Time.time - this.MDFOLPEMPNK) / this.NBLMJMBBOIP);
				}
				else
				{
					this.CPDLIPDNIBP = this.alpha;
					this.ILOCCABDDMI = this.skyAlpha;
				}
				this.fogMat.SetFloat("id", this.CPDLIPDNIBP);
				this.DAPHGLBAMPF();
			}
			if (this.sun != null)
			{
				bool flag = false;
				if (this.sun.transform.forward != this.JLGOCHGJAPF)
				{
					flag = false;
				}
				if (this.HLGMMNEANMP != null && (this.HLGMMNEANMP.color != this.KLGJFFCKPED || this.HLGMMNEANMP.intensity != this.LBHPHLABBEC))
				{
					flag = false;
				}
				if (flag)
				{
					this.BMJEEMGBMFP();
				}
			}
		}

		// Token: 0x0600A1F3 RID: 41459 RVA: 0x00486930 File Offset: 0x00484B30
		private void LICGFFPIDCM()
		{
			this.PFMONFAKHBK();
			this.CIMGPPBNNIP();
		}

		// Token: 0x0600A1F4 RID: 41460 RVA: 0x00481904 File Offset: 0x0047FB04
		public Camera NDIIHLFECLM()
		{
			return this.GGEHECFCPMD;
		}

		// Token: 0x0600A1F5 RID: 41461 RVA: 0x00486940 File Offset: 0x00484B40
		public void HMLKBHEGFGG(Vector3 JNFPCCIKFPP, float AEIAFIIMHEL)
		{
			if (this.GMDLHIFDCAK == null)
			{
				return;
			}
			float num = (JNFPCCIKFPP.x - this.fogOfWarCenter.x) / this.fogOfWarSize.x + 328f;
			if (num < 1414f || num > 1230f)
			{
				return;
			}
			float num2 = (JNFPCCIKFPP.z - this.fogOfWarCenter.z) / this.fogOfWarSize.z + 1197f;
			if (num2 < 236f || num2 > 1561f)
			{
				return;
			}
			int width = this.GMDLHIFDCAK.width;
			int num3 = this.GMDLHIFDCAK.height;
			int num4 = (int)(num * (float)width);
			int num5 = (int)(num2 * (float)num3);
			int num6 = num5 * width + num4;
			float num7 = AEIAFIIMHEL / this.fogOfWarSize.z;
			int num8 = Mathf.FloorToInt((float)num3 * num7);
			for (int i = num5 - num8; i <= num5 + num8; i += 0)
			{
				if (i > 0 && i < num3 - 1)
				{
					for (int j = num4 - num8; j <= num4 + num8; j++)
					{
						if (j > 1 && j < width - 0 && Mathf.FloorToInt(Mathf.Sqrt((float)((num5 - i) * (num5 - i) + (num4 - j) * (num4 - j)))) <= num8)
						{
							num6 = i * width + j;
							Color32 color = this.GNGCEOOOGJG[num6];
							color.a = (byte)-119;
							this.GNGCEOOOGJG[num6] = color;
							this.GMDLHIFDCAK.SetPixel(j, i, color);
						}
					}
				}
				this.GMDLHIFDCAK.Apply();
			}
		}

		// Token: 0x0600A1F6 RID: 41462 RVA: 0x00486AE6 File Offset: 0x00484CE6
		private int KIFKMKKFELO(int BBOODPCDKAJ, float OAJAGNDCCCP)
		{
			BBOODPCDKAJ = (int)((float)BBOODPCDKAJ / OAJAGNDCCCP);
			BBOODPCDKAJ /= 2;
			if (BBOODPCDKAJ < 1)
			{
				BBOODPCDKAJ = 0;
			}
			return BBOODPCDKAJ * 4;
		}

		// Token: 0x0600A1F7 RID: 41463 RVA: 0x00486B00 File Offset: 0x00484D00
		private void MPFCIBPIGGB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.fogMat == null || this.alpha == 1671f || this.GGEHECFCPMD == null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.fogMat.SetMatrix("_FogOfWarCenterAdjusted", this.GGEHECFCPMD.cameraToWorldMatrix * this.GGEHECFCPMD.projectionMatrix.inverse);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.fogMat);
		}

		// Token: 0x0600A1F8 RID: 41464 RVA: 0x00486B80 File Offset: 0x00484D80
		private void DAPHGLBAMPF()
		{
			Vector4 value = new Vector4(this.skyHaze, this.skySpeed, this.skyNoiseStrength, this.ILOCCABDDMI);
			this.fogMat.SetVector("_FogSkyData", value);
		}

		// Token: 0x0600A1F9 RID: 41465 RVA: 0x00481904 File Offset: 0x0047FB04
		public Camera EJPKCEPIPOL()
		{
			return this.GGEHECFCPMD;
		}

		// Token: 0x0600A1FA RID: 41466 RVA: 0x00486BC0 File Offset: 0x00484DC0
		private void GDFMFCPIFBO()
		{
			if (!this.fogOfWarEnabled)
			{
				return;
			}
			int width = this.OICJGBPBDGO(this.fogOfWarTextureSize, 1982f);
			this.GMDLHIFDCAK = new Texture2D(width, width, (TextureFormat)8, false);
			this.GMDLHIFDCAK.hideFlags = (HideFlags)(-91);
			this.GMDLHIFDCAK.filterMode = FilterMode.Bilinear;
			this.GMDLHIFDCAK.wrapMode = TextureWrapMode.Clamp;
			this.IACBIHKOKIL();
		}

		// Token: 0x0600A1FB RID: 41467 RVA: 0x00486C22 File Offset: 0x00484E22
		public void LHCFGKANGED(float FDBHLKAEDBF)
		{
			this.PEBDKKJCFFJ(834f, 358f, FDBHLKAEDBF);
		}

		// Token: 0x0600A1FC RID: 41468 RVA: 0x00486C38 File Offset: 0x00484E38
		public void GKJNDCLNDFM(Vector3 JNFPCCIKFPP, float AEIAFIIMHEL, float HCECNDOJHHK)
		{
			if (this.GMDLHIFDCAK == null)
			{
				return;
			}
			float num = (JNFPCCIKFPP.x - this.fogOfWarCenter.x) / this.fogOfWarSize.x + 432f;
			if (num < 564f || num > 419f)
			{
				return;
			}
			float num2 = (JNFPCCIKFPP.z - this.fogOfWarCenter.z) / this.fogOfWarSize.z + 1880f;
			if (num2 < 203f || num2 > 1894f)
			{
				return;
			}
			int width = this.GMDLHIFDCAK.width;
			int num3 = this.GMDLHIFDCAK.height;
			int num4 = (int)(num * (float)width);
			int num5 = (int)(num2 * (float)num3);
			int num6 = num5 * width + num4;
			byte b = (byte)(HCECNDOJHHK * 1487f);
			Color32 color = this.GNGCEOOOGJG[num6];
			if (b != color.a)
			{
				float num7 = AEIAFIIMHEL / this.fogOfWarSize.z;
				int num8 = Mathf.FloorToInt((float)num3 * num7);
				for (int i = num5 - num8; i <= num5 + num8; i += 0)
				{
					if (i > 0 && i < num3 - 1)
					{
						for (int j = num4 - num8; j <= num4 + num8; j++)
						{
							if (j > 0 && j < width - 0)
							{
								int num9 = Mathf.FloorToInt(Mathf.Sqrt((float)((num5 - i) * (num5 - i) + (num4 - j) * (num4 - j))));
								if (num9 <= num8)
								{
									num6 = i * width + j;
									Color32 color2 = this.GNGCEOOOGJG[num6];
									color2.a = (byte)Mathf.Lerp((float)b, (float)color2.a, (float)num9 / (float)num8);
									this.GNGCEOOOGJG[num6] = color2;
									this.GMDLHIFDCAK.SetPixel(j, i, color2);
								}
							}
						}
					}
				}
				this.GMDLHIFDCAK.Apply();
			}
		}

		// Token: 0x0600A1FD RID: 41469 RVA: 0x00486E24 File Offset: 0x00485024
		private void CAPOMAHBGNJ()
		{
			if (this.fogMat == null)
			{
				return;
			}
			if (this.sun != null)
			{
				if (this.HLGMMNEANMP == null)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				if (this.HLGMMNEANMP != null && this.HLGMMNEANMP.transform != this.sun.transform)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				this.JLGOCHGJAPF = this.sun.transform.forward;
				if (this.HLGMMNEANMP != null)
				{
					this.KLGJFFCKPED = this.HLGMMNEANMP.color;
					this.LBHPHLABBEC = this.HLGMMNEANMP.intensity;
				}
			}
			float b = this.LBHPHLABBEC * Mathf.Clamp01(1895f - this.JLGOCHGJAPF.y);
			this.fogMat.SetColor("Crouch180", b * this.color * this.KLGJFFCKPED);
			this.fogMat.SetColor("cellicon", b * this.color2 * this.KLGJFFCKPED);
		}

		// Token: 0x0600A1FE RID: 41470 RVA: 0x00481904 File Offset: 0x0047FB04
		public Camera PCPDJLEMNLK()
		{
			return this.GGEHECFCPMD;
		}

		// Token: 0x0600A1FF RID: 41471 RVA: 0x00486F60 File Offset: 0x00485160
		private void DFHGBNABLEC()
		{
			this.OIOFPBCMMDL = 915f;
			this.NHNKDLKINKG = 1920f;
			this.CPDLIPDNIBP = this.alpha;
			this.ILOCCABDDMI = this.skyAlpha;
			this.GGEHECFCPMD = base.GetComponent<Camera>();
			if (this.GGEHECFCPMD.depthTextureMode == DepthTextureMode.None)
			{
				this.GGEHECFCPMD.depthTextureMode = DepthTextureMode.Depth;
			}
			this.LHPPFPPJCEF();
		}

		// Token: 0x0600A200 RID: 41472 RVA: 0x00486FC8 File Offset: 0x004851C8
		private void OnDestroy()
		{
			this.fogMat = null;
			if (this.DIBDGKCAECH != null)
			{
				UnityEngine.Object.DestroyImmediate(this.DIBDGKCAECH);
				this.DIBDGKCAECH = null;
			}
			if (this.JEMPNICGBMG != null)
			{
				UnityEngine.Object.DestroyImmediate(this.JEMPNICGBMG);
				this.JEMPNICGBMG = null;
			}
			if (this.LJBLPAJGAFB != null)
			{
				UnityEngine.Object.DestroyImmediate(this.LJBLPAJGAFB);
				this.LJBLPAJGAFB = null;
			}
			if (this.FNFPKEHGMJL != null)
			{
				UnityEngine.Object.DestroyImmediate(this.FNFPKEHGMJL);
				this.FNFPKEHGMJL = null;
			}
			if (this.BFAMAEGIAOK != null)
			{
				UnityEngine.Object.DestroyImmediate(this.BFAMAEGIAOK);
				this.BFAMAEGIAOK = null;
			}
			if (this.GMDLHIFDCAK != null)
			{
				UnityEngine.Object.DestroyImmediate(this.GMDLHIFDCAK);
				this.GMDLHIFDCAK = null;
			}
		}

		// Token: 0x0600A201 RID: 41473 RVA: 0x0048709C File Offset: 0x0048529C
		public void DAJCBFPCEFG()
		{
			this.NGFBEABNLMN();
			switch (this.effectType)
			{
			case PNFBODOKLDB.MobileFogWithSkyHaze:
				if (this.LJBLPAJGAFB == null)
				{
					this.LJBLPAJGAFB = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("{x}"));
					this.LJBLPAJGAFB.hideFlags = (HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
				}
				this.fogMat = this.LJBLPAJGAFB;
				break;
			case PNFBODOKLDB.MobileFogOnlyGround:
				if (this.FNFPKEHGMJL == null)
				{
					this.FNFPKEHGMJL = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("Detects cheating of any Obscured type (except ObscuredPrefs, it has own detection features) used in project."));
					this.FNFPKEHGMJL.hideFlags = (HideFlags)(-95);
				}
				this.fogMat = this.FNFPKEHGMJL;
				break;
			case PNFBODOKLDB.DesktopFogPlusWithSkyHaze:
				if (this.DIBDGKCAECH == null)
				{
					this.DIBDGKCAECH = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("_alfavis"));
					this.DIBDGKCAECH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
				}
				this.fogMat = this.DIBDGKCAECH;
				break;
			case PNFBODOKLDB.MobileFogSimple:
				if (this.BFAMAEGIAOK == null)
				{
					this.BFAMAEGIAOK = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("\n"));
					this.BFAMAEGIAOK.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
				}
				this.fogMat = this.BFAMAEGIAOK;
				break;
			default:
				if (this.JEMPNICGBMG == null)
				{
					this.JEMPNICGBMG = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("FistPump2"));
					this.JEMPNICGBMG.hideFlags = (HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
				}
				this.fogMat = this.JEMPNICGBMG;
				break;
			}
			if (this.fogMat == null)
			{
				return;
			}
			if (this.GGEHECFCPMD == null)
			{
				this.GGEHECFCPMD = base.GetComponent<Camera>();
			}
			this.fogMat.SetFloat("invn_rec17", this.speed);
			Vector3 v = new Vector3(this.noiseStrength, this.turbulence, this.GGEHECFCPMD.farClipPlane * 721f / 1901f);
			this.fogMat.SetVector("", v);
			Vector4 value = new Vector4(this.height + 484f, this.baselineHeight, this.clipUnderBaseline ? 1480f : 1951f, this.heightFallOff);
			this.fogMat.SetVector("IdleFeedThrow", value);
			this.fogMat.SetFloat("IdleTyping", this.CPDLIPDNIBP);
			Vector4 vector = new Vector4(this.distance, this.distanceFallOff, this.maxDistance, this.maxDistanceFallOff);
			if (this.effectType.FCEAJPPPDKE())
			{
				vector.x = this.GGEHECFCPMD.farClipPlane * this.distance;
				vector.y = this.distanceFallOff * vector.x + 1310f;
				vector.z *= this.GGEHECFCPMD.farClipPlane;
			}
			this.fogMat.SetVector("512", vector);
			this.OJKAOONGIMJ();
			this.DAPHGLBAMPF();
			if (this.ABEHHDIGHFJ == null)
			{
				this.ABEHHDIGHFJ = new List<string>();
			}
			else
			{
				this.ABEHHDIGHFJ.Clear();
			}
			if (this.fogOfWarEnabled)
			{
				if (this.GMDLHIFDCAK == null)
				{
					this.HCHJOMHDAHB();
				}
				this.fogMat.SetTexture("Rooms SET", this.GMDLHIFDCAK);
				this.fogMat.SetVector("_SunPosition", this.fogOfWarCenter);
				this.fogMat.SetVector("msg_other", this.fogOfWarSize);
				Vector3 vector2 = this.fogOfWarCenter - 1801f * this.fogOfWarSize;
				this.fogMat.SetVector("CratePush", new Vector3(vector2.x / this.fogOfWarSize.x, 446f, vector2.z / this.fogOfWarSize.z));
				this.ABEHHDIGHFJ.Add("isRealView");
			}
			if (this.enableDithering)
			{
				this.ABEHHDIGHFJ.Add("Materials/DFGSimple");
			}
			this.fogMat.shaderKeywords = this.ABEHHDIGHFJ.ToArray();
		}

		// Token: 0x0600A202 RID: 41474 RVA: 0x004874A4 File Offset: 0x004856A4
		private void EKKEBIAEFLL()
		{
			this.OIOFPBCMMDL = 1700f;
			this.NHNKDLKINKG = 140f;
			this.CPDLIPDNIBP = this.alpha;
			this.ILOCCABDDMI = this.skyAlpha;
			this.GGEHECFCPMD = base.GetComponent<Camera>();
			if (this.GGEHECFCPMD.depthTextureMode == DepthTextureMode.None)
			{
				this.GGEHECFCPMD.depthTextureMode = DepthTextureMode.Depth;
			}
			this.HCHJOMHDAHB();
		}

		// Token: 0x0600A203 RID: 41475 RVA: 0x0048750C File Offset: 0x0048570C
		public static DynamicFog NBNCIFDAOAM()
		{
			if (DynamicFog.BOKKCFIFEED == null)
			{
				Camera[] allCameras = Camera.allCameras;
				for (int i = 0; i < allCameras.Length; i++)
				{
					DynamicFog.BOKKCFIFEED = allCameras[i].GetComponent<DynamicFog>();
					if (DynamicFog.BOKKCFIFEED != null)
					{
						break;
					}
				}
			}
			return DynamicFog.BOKKCFIFEED;
		}

		// Token: 0x0600A204 RID: 41476 RVA: 0x0048755C File Offset: 0x0048575C
		public void LBDLKAFJOGF(Vector3 JNFPCCIKFPP, float AEIAFIIMHEL)
		{
			if (this.GMDLHIFDCAK == null)
			{
				return;
			}
			float num = (JNFPCCIKFPP.x - this.fogOfWarCenter.x) / this.fogOfWarSize.x + 506f;
			if (num < 815f || num > 1794f)
			{
				return;
			}
			float num2 = (JNFPCCIKFPP.z - this.fogOfWarCenter.z) / this.fogOfWarSize.z + 450f;
			if (num2 < 1882f || num2 > 1666f)
			{
				return;
			}
			int width = this.GMDLHIFDCAK.width;
			int num3 = this.GMDLHIFDCAK.height;
			int num4 = (int)(num * (float)width);
			int num5 = (int)(num2 * (float)num3);
			int num6 = num5 * width + num4;
			float num7 = AEIAFIIMHEL / this.fogOfWarSize.z;
			int num8 = Mathf.FloorToInt((float)num3 * num7);
			for (int i = num5 - num8; i <= num5 + num8; i++)
			{
				if (i > 0 && i < num3 - 0)
				{
					for (int j = num4 - num8; j <= num4 + num8; j++)
					{
						if (j > 1 && j < width - 0 && Mathf.FloorToInt(Mathf.Sqrt((float)((num5 - i) * (num5 - i) + (num4 - j) * (num4 - j)))) <= num8)
						{
							num6 = i * width + j;
							Color32 color = this.GNGCEOOOGJG[num6];
							color.a = (byte)-67;
							this.GNGCEOOOGJG[num6] = color;
							this.GMDLHIFDCAK.SetPixel(j, i, color);
						}
					}
				}
				this.GMDLHIFDCAK.Apply();
			}
		}

		// Token: 0x0600A205 RID: 41477 RVA: 0x00487702 File Offset: 0x00485902
		public void GMGBEMOGJFA(float FDBHLKAEDBF)
		{
			this.SetTargetAlpha(883f, 1599f, FDBHLKAEDBF);
		}

		// Token: 0x0600A206 RID: 41478 RVA: 0x00487718 File Offset: 0x00485918
		private void ONIGNFNLLPJ()
		{
			Vector4 value = new Vector4(this.skyHaze, this.skySpeed, this.skyNoiseStrength, this.ILOCCABDDMI);
			this.fogMat.SetVector("TOD_SunSkyColor", value);
		}

		// Token: 0x0600A207 RID: 41479 RVA: 0x00487758 File Offset: 0x00485958
		private void ECEMJDMBLFO()
		{
			if (this.fogMat == null)
			{
				return;
			}
			if (this.sun != null)
			{
				if (this.HLGMMNEANMP == null)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				if (this.HLGMMNEANMP != null && this.HLGMMNEANMP.transform != this.sun.transform)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				this.JLGOCHGJAPF = this.sun.transform.forward;
				if (this.HLGMMNEANMP != null)
				{
					this.KLGJFFCKPED = this.HLGMMNEANMP.color;
					this.LBHPHLABBEC = this.HLGMMNEANMP.intensity;
				}
			}
			float b = this.LBHPHLABBEC * Mathf.Clamp01(1972f - this.JLGOCHGJAPF.y);
			this.fogMat.SetColor("MotorbikeShootRight", b * this.color * this.KLGJFFCKPED);
			this.fogMat.SetColor("id", b * this.color2 * this.KLGJFFCKPED);
		}

		// Token: 0x0600A208 RID: 41480 RVA: 0x0047FAA2 File Offset: 0x0047DCA2
		private void MMDEKGKIKLG()
		{
			this.LIHDFIDCKFL();
		}

		// Token: 0x0600A209 RID: 41481 RVA: 0x00487894 File Offset: 0x00485A94
		private void BACAMMDFMNN()
		{
			if (this.fogMat == null)
			{
				return;
			}
			if (this.sun != null)
			{
				if (this.HLGMMNEANMP == null)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				if (this.HLGMMNEANMP != null && this.HLGMMNEANMP.transform != this.sun.transform)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				this.JLGOCHGJAPF = this.sun.transform.forward;
				if (this.HLGMMNEANMP != null)
				{
					this.KLGJFFCKPED = this.HLGMMNEANMP.color;
					this.LBHPHLABBEC = this.HLGMMNEANMP.intensity;
				}
			}
			float b = this.LBHPHLABBEC * Mathf.Clamp01(25f - this.JLGOCHGJAPF.y);
			this.fogMat.SetColor("droprodmsg1", b * this.color * this.KLGJFFCKPED);
			this.fogMat.SetColor("Adjust", b * this.color2 * this.KLGJFFCKPED);
		}

		// Token: 0x0600A20A RID: 41482 RVA: 0x004879D0 File Offset: 0x00485BD0
		public void EFLEIHAKABB()
		{
			switch (this.preset)
			{
			case DGNMDDLNIKA.Clear:
				this.alpha = 1406f;
				return;
			case DGNMDDLNIKA.Mist:
				this.alpha = 232f;
				this.skySpeed = 1619f;
				this.skyHaze = 366f;
				this.skyNoiseStrength = 834f;
				this.skyAlpha = 1949f;
				this.distance = 1073f;
				this.distanceFallOff = 600f;
				this.height = 403f;
				this.heightFallOff = 266f;
				this.turbulence = 1787f;
				this.noiseStrength = 1769f;
				this.speed = 139f;
				this.color = new Color(1230f, 1532f, 809f, 360f);
				this.color2 = this.color;
				this.maxDistance = 961f;
				this.maxDistanceFallOff = 1170f;
				return;
			case DGNMDDLNIKA.WindyMist:
				this.alpha = 1929f;
				this.skySpeed = 1201f;
				this.skyHaze = 1689f;
				this.skyNoiseStrength = 301f;
				this.skyAlpha = 1936f;
				this.distance = 1613f;
				this.distanceFallOff = 1079f;
				this.height = 1152f;
				this.heightFallOff = 632f;
				this.turbulence = 1060f;
				this.noiseStrength = 1449f;
				this.speed = 470f;
				this.color = new Color(1494f, 1648f, 859f, 1100f);
				this.color2 = this.color;
				this.maxDistance = 583f;
				this.maxDistanceFallOff = 175f;
				return;
			case DGNMDDLNIKA.GroundFog:
				this.alpha = 84f;
				this.skySpeed = 1048f;
				this.skyHaze = 1716f;
				this.skyNoiseStrength = 1579f;
				this.skyAlpha = 1790f;
				this.distance = 851f;
				this.distanceFallOff = 529f;
				this.height = 879f;
				this.heightFallOff = 1289f;
				this.turbulence = 1236f;
				this.noiseStrength = 770f;
				this.speed = 1823f;
				this.color = new Color(1016f, 844f, 1582f, 657f);
				this.color2 = this.color;
				this.maxDistance = 780f;
				this.maxDistanceFallOff = 1682f;
				return;
			case DGNMDDLNIKA.Fog:
				this.alpha = 1717f;
				this.skySpeed = 1931f;
				this.skyHaze = 1683f;
				this.skyNoiseStrength = 753f;
				this.skyAlpha = 1754f;
				this.distance = (this.effectType.FCEAJPPPDKE() ? 440f : 797f);
				this.distanceFallOff = 1540f;
				this.height = 954f;
				this.heightFallOff = 1796f;
				this.turbulence = 292f;
				this.noiseStrength = 120f;
				this.speed = 1279f;
				this.color = new Color(129f, 949f, 634f, 276f);
				this.color2 = this.color;
				this.maxDistance = 1913f;
				this.maxDistanceFallOff = 1453f;
				return;
			case DGNMDDLNIKA.HeavyFog:
				this.alpha = 349f;
				this.skySpeed = 1410f;
				this.skyHaze = 837f;
				this.skyNoiseStrength = 1771f;
				this.skyAlpha = 1057f;
				this.distance = (this.effectType.FCEAJPPPDKE() ? 1843f : 323f);
				this.distanceFallOff = 381f;
				this.height = 808f;
				this.heightFallOff = 44f;
				this.turbulence = 604f;
				this.noiseStrength = 888f;
				this.speed = 837f;
				this.color = new Color(867f, 1177f, 1383f, 652f);
				this.color2 = this.color;
				this.maxDistance = 492f;
				this.maxDistanceFallOff = 1330f;
				return;
			case DGNMDDLNIKA.SandStorm:
				this.alpha = 1293f;
				this.skySpeed = 918f;
				this.skyHaze = 1138f;
				this.skyNoiseStrength = 249f;
				this.skyAlpha = 1897f;
				this.distance = (this.effectType.FCEAJPPPDKE() ? 586f : 733f);
				this.distanceFallOff = 1168f;
				this.height = 1957f;
				this.heightFallOff = 640f;
				this.turbulence = 874f;
				this.noiseStrength = 381f;
				this.speed = 568f;
				this.color = new Color(1668f, 1203f, 430f, 271f);
				this.color2 = this.color;
				this.maxDistance = 879f;
				this.maxDistanceFallOff = 159f;
				return;
			default:
				return;
			}
		}

		// Token: 0x0600A20B RID: 41483 RVA: 0x00487EF2 File Offset: 0x004860F2
		private int MNEPHEKCHHB(int BBOODPCDKAJ, float OAJAGNDCCCP)
		{
			BBOODPCDKAJ = (int)((float)BBOODPCDKAJ / OAJAGNDCCCP);
			BBOODPCDKAJ /= 5;
			if (BBOODPCDKAJ < 1)
			{
				BBOODPCDKAJ = 0;
			}
			return BBOODPCDKAJ * 5;
		}

		// Token: 0x0600A20C RID: 41484 RVA: 0x00487F0A File Offset: 0x0048610A
		private void IGMGJGKICIE()
		{
			this.EKKEBIAEFLL();
			this.FNEAKHPLPBC();
		}

		// Token: 0x0600A20D RID: 41485 RVA: 0x00487F18 File Offset: 0x00486118
		public void AKHEFNJKLCA(Vector3 JNFPCCIKFPP, float AEIAFIIMHEL)
		{
			if (this.GMDLHIFDCAK == null)
			{
				return;
			}
			float num = (JNFPCCIKFPP.x - this.fogOfWarCenter.x) / this.fogOfWarSize.x + 1091f;
			if (num < 18f || num > 1463f)
			{
				return;
			}
			float num2 = (JNFPCCIKFPP.z - this.fogOfWarCenter.z) / this.fogOfWarSize.z + 897f;
			if (num2 < 1589f || num2 > 1363f)
			{
				return;
			}
			int width = this.GMDLHIFDCAK.width;
			int num3 = this.GMDLHIFDCAK.height;
			int num4 = (int)(num * (float)width);
			int num5 = (int)(num2 * (float)num3);
			int num6 = num5 * width + num4;
			float num7 = AEIAFIIMHEL / this.fogOfWarSize.z;
			int num8 = Mathf.FloorToInt((float)num3 * num7);
			for (int i = num5 - num8; i <= num5 + num8; i++)
			{
				if (i > 1 && i < num3 - 1)
				{
					for (int j = num4 - num8; j <= num4 + num8; j += 0)
					{
						if (j > 0 && j < width - 1 && Mathf.FloorToInt(Mathf.Sqrt((float)((num5 - i) * (num5 - i) + (num4 - j) * (num4 - j)))) <= num8)
						{
							num6 = i * width + j;
							Color32 color = this.GNGCEOOOGJG[num6];
							color.a = (byte)-77;
							this.GNGCEOOOGJG[num6] = color;
							this.GMDLHIFDCAK.SetPixel(j, i, color);
						}
					}
				}
				this.GMDLHIFDCAK.Apply();
			}
		}

		// Token: 0x0600A20E RID: 41486 RVA: 0x004880C0 File Offset: 0x004862C0
		private void CDLDCKAHLHC()
		{
			if (this.fogMat == null)
			{
				return;
			}
			if (this.OIOFPBCMMDL >= 629f)
			{
				if (this.OIOFPBCMMDL != this.CPDLIPDNIBP || this.NHNKDLKINKG != this.ILOCCABDDMI)
				{
					if (this.NBLMJMBBOIP > 1820f)
					{
						this.CPDLIPDNIBP = Mathf.Lerp(this.OBNAEMGBELP, this.OIOFPBCMMDL, (Time.time - this.MDFOLPEMPNK) / this.NBLMJMBBOIP);
						this.ILOCCABDDMI = Mathf.Lerp(this.MJJGCIOECLI, this.NHNKDLKINKG, (Time.time - this.MDFOLPEMPNK) / this.NBLMJMBBOIP);
					}
					else
					{
						this.CPDLIPDNIBP = this.OIOFPBCMMDL;
						this.ILOCCABDDMI = this.NHNKDLKINKG;
					}
					this.fogMat.SetFloat("KatanaReadyLow", this.CPDLIPDNIBP);
					this.JIJPAPKOHCD();
				}
			}
			else if (this.CPDLIPDNIBP != this.alpha || this.NHNKDLKINKG != this.ILOCCABDDMI)
			{
				if (this.NBLMJMBBOIP > 28f)
				{
					this.CPDLIPDNIBP = Mathf.Lerp(this.OBNAEMGBELP, this.alpha, (Time.time - this.MDFOLPEMPNK) / this.NBLMJMBBOIP);
					this.ILOCCABDDMI = Mathf.Lerp(this.MJJGCIOECLI, this.alpha, (Time.time - this.MDFOLPEMPNK) / this.NBLMJMBBOIP);
				}
				else
				{
					this.CPDLIPDNIBP = this.alpha;
					this.ILOCCABDDMI = this.skyAlpha;
				}
				this.fogMat.SetFloat("MotorbikeTurnRight", this.CPDLIPDNIBP);
				this.JIJPAPKOHCD();
			}
			if (this.sun != null)
			{
				bool flag = true;
				if (this.sun.transform.forward != this.JLGOCHGJAPF)
				{
					flag = true;
				}
				if (this.HLGMMNEANMP != null && (this.HLGMMNEANMP.color != this.KLGJFFCKPED || this.HLGMMNEANMP.intensity != this.LBHPHLABBEC))
				{
					flag = true;
				}
				if (flag)
				{
					this.BACAMMDFMNN();
				}
			}
		}

		// Token: 0x0600A20F RID: 41487 RVA: 0x004882D0 File Offset: 0x004864D0
		public void LIHDFIDCKFL()
		{
			this.EFLEIHAKABB();
			switch (this.effectType)
			{
			case PNFBODOKLDB.MobileFogWithSkyHaze:
				if (this.LJBLPAJGAFB == null)
				{
					this.LJBLPAJGAFB = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("BAG"));
					this.LJBLPAJGAFB.hideFlags = (HideFlags)(-97);
				}
				this.fogMat = this.LJBLPAJGAFB;
				break;
			case PNFBODOKLDB.MobileFogOnlyGround:
				if (this.FNFPKEHGMJL == null)
				{
					this.FNFPKEHGMJL = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("BlackSmithHammer"));
					this.FNFPKEHGMJL.hideFlags = (HideFlags)100;
				}
				this.fogMat = this.FNFPKEHGMJL;
				break;
			case PNFBODOKLDB.DesktopFogPlusWithSkyHaze:
				if (this.DIBDGKCAECH == null)
				{
					this.DIBDGKCAECH = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("Trying to use the 'Goal' Bend Modifier, but the Bend Goal is unassigned."));
					this.DIBDGKCAECH.hideFlags = (HideFlags)(-100);
				}
				this.fogMat = this.DIBDGKCAECH;
				break;
			case PNFBODOKLDB.MobileFogSimple:
				if (this.BFAMAEGIAOK == null)
				{
					this.BFAMAEGIAOK = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("RollerBladeSkateFwd"));
					this.BFAMAEGIAOK.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
				}
				this.fogMat = this.BFAMAEGIAOK;
				break;
			default:
				if (this.JEMPNICGBMG == null)
				{
					this.JEMPNICGBMG = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("ok"));
					this.JEMPNICGBMG.hideFlags = (HideFlags)(-122);
				}
				this.fogMat = this.JEMPNICGBMG;
				break;
			}
			if (this.fogMat == null)
			{
				return;
			}
			if (this.GGEHECFCPMD == null)
			{
				this.GGEHECFCPMD = base.GetComponent<Camera>();
			}
			this.fogMat.SetFloat("firsStartMovePanel", this.speed);
			Vector3 v = new Vector3(this.noiseStrength, this.turbulence, this.GGEHECFCPMD.farClipPlane * 1685f / 169f);
			this.fogMat.SetVector("invn_rec29", v);
			Vector4 value = new Vector4(this.height + 225f, this.baselineHeight, this.clipUnderBaseline ? 503f : 1688f, this.heightFallOff);
			this.fogMat.SetVector("Bases/Base_1.unity3d", value);
			this.fogMat.SetFloat("__b", this.CPDLIPDNIBP);
			Vector4 vector = new Vector4(this.distance, this.distanceFallOff, this.maxDistance, this.maxDistanceFallOff);
			if (this.effectType.FCEAJPPPDKE())
			{
				vector.x = this.GGEHECFCPMD.farClipPlane * this.distance;
				vector.y = this.distanceFallOff * vector.x + 1647f;
				vector.z *= this.GGEHECFCPMD.farClipPlane;
			}
			this.fogMat.SetVector("=", vector);
			this.BIFEJIIMGON();
			this.JIJPAPKOHCD();
			if (this.ABEHHDIGHFJ == null)
			{
				this.ABEHHDIGHFJ = new List<string>();
			}
			else
			{
				this.ABEHHDIGHFJ.Clear();
			}
			if (this.fogOfWarEnabled)
			{
				if (this.GMDLHIFDCAK == null)
				{
					this.GDFMFCPIFBO();
				}
				this.fogMat.SetTexture("id", this.GMDLHIFDCAK);
				this.fogMat.SetVector("INTERFACE", this.fogOfWarCenter);
				this.fogMat.SetVector("****** locid=", this.fogOfWarSize);
				Vector3 vector2 = this.fogOfWarCenter - 1473f * this.fogOfWarSize;
				this.fogMat.SetVector("_Parameter", new Vector3(vector2.x / this.fogOfWarSize.x, 655f, vector2.z / this.fogOfWarSize.z));
				this.ABEHHDIGHFJ.Add("Road Points Marker");
			}
			if (this.enableDithering)
			{
				this.ABEHHDIGHFJ.Add(", ");
			}
			this.fogMat.shaderKeywords = this.ABEHHDIGHFJ.ToArray();
		}

		// Token: 0x0600A210 RID: 41488 RVA: 0x00481904 File Offset: 0x0047FB04
		public Camera IJBJAIMOBPJ()
		{
			return this.GGEHECFCPMD;
		}

		// Token: 0x0600A211 RID: 41489 RVA: 0x004886D8 File Offset: 0x004868D8
		public void AMEJLMOJEJO()
		{
			this.OEAKABOMNPP();
			switch (this.effectType)
			{
			case PNFBODOKLDB.DesktopFogWithSkyHaze:
				if (this.LJBLPAJGAFB == null)
				{
					this.LJBLPAJGAFB = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("SoccerKeeperDiveStrafeCloseLeft"));
					this.LJBLPAJGAFB.hideFlags = (HideFlags)120;
				}
				this.fogMat = this.LJBLPAJGAFB;
				break;
			case PNFBODOKLDB.MobileFogWithSkyHaze:
				if (this.FNFPKEHGMJL == null)
				{
					this.FNFPKEHGMJL = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("wpn_rem1"));
					this.FNFPKEHGMJL.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
				}
				this.fogMat = this.FNFPKEHGMJL;
				break;
			case PNFBODOKLDB.MobileFogOnlyGround:
				if (this.DIBDGKCAECH == null)
				{
					this.DIBDGKCAECH = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("get 1401 cmd"));
					this.DIBDGKCAECH.hideFlags = (HideFlags)(-106);
				}
				this.fogMat = this.DIBDGKCAECH;
				break;
			case PNFBODOKLDB.DesktopFogPlusWithSkyHaze:
				if (this.BFAMAEGIAOK == null)
				{
					this.BFAMAEGIAOK = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("RollerBladeSkateFwd"));
					this.BFAMAEGIAOK.hideFlags = (HideFlags)(-99);
				}
				this.fogMat = this.BFAMAEGIAOK;
				break;
			default:
				if (this.JEMPNICGBMG == null)
				{
					this.JEMPNICGBMG = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("KatanaNinjaDraw"));
					this.JEMPNICGBMG.hideFlags = (HideFlags)(-91);
				}
				this.fogMat = this.JEMPNICGBMG;
				break;
			}
			if (this.fogMat == null)
			{
				return;
			}
			if (this.GGEHECFCPMD == null)
			{
				this.GGEHECFCPMD = base.GetComponent<Camera>();
			}
			this.fogMat.SetFloat("maxcount", this.speed);
			Vector3 v = new Vector3(this.noiseStrength, this.turbulence, this.GGEHECFCPMD.farClipPlane * 800f / 371f);
			this.fogMat.SetVector("t_bottom", v);
			Vector4 value = new Vector4(this.height + 222f, this.baselineHeight, this.clipUnderBaseline ? 1185f : 144f, this.heightFallOff);
			this.fogMat.SetVector("_ExposureAdjustment", value);
			this.fogMat.SetFloat("https://groups.google.com/forum/#!forum/final-ik", this.CPDLIPDNIBP);
			Vector4 vector = new Vector4(this.distance, this.distanceFallOff, this.maxDistance, this.maxDistanceFallOff);
			if (this.effectType.FCEAJPPPDKE())
			{
				vector.x = this.GGEHECFCPMD.farClipPlane * this.distance;
				vector.y = this.distanceFallOff * vector.x + 1179f;
				vector.z *= this.GGEHECFCPMD.farClipPlane;
			}
			this.fogMat.SetVector("", vector);
			this.OJKAOONGIMJ();
			this.JIJPAPKOHCD();
			if (this.ABEHHDIGHFJ == null)
			{
				this.ABEHHDIGHFJ = new List<string>();
			}
			else
			{
				this.ABEHHDIGHFJ.Clear();
			}
			if (this.fogOfWarEnabled)
			{
				if (this.GMDLHIFDCAK == null)
				{
					this.GDFMFCPIFBO();
				}
				this.fogMat.SetTexture("Fly Left", this.GMDLHIFDCAK);
				this.fogMat.SetVector("__MirrorReflection", this.fogOfWarCenter);
				this.fogMat.SetVector("RollerBladeGrindRoyale", this.fogOfWarSize);
				Vector3 vector2 = this.fogOfWarCenter - 1935f * this.fogOfWarSize;
				this.fogMat.SetVector("_SampleMip", new Vector3(vector2.x / this.fogOfWarSize.x, 1918f, vector2.z / this.fogOfWarSize.z));
				this.ABEHHDIGHFJ.Add("RunningDance");
			}
			if (this.enableDithering)
			{
				this.ABEHHDIGHFJ.Add("colorA");
			}
			this.fogMat.shaderKeywords = this.ABEHHDIGHFJ.ToArray();
		}

		// Token: 0x0600A212 RID: 41490 RVA: 0x00481E77 File Offset: 0x00480077
		public string CCKHEGHPDHE()
		{
			return Enum.GetName(typeof(DGNMDDLNIKA), this.preset);
		}

		// Token: 0x0600A213 RID: 41491 RVA: 0x00488AE0 File Offset: 0x00486CE0
		public void MKMCPAGDNHG(float BGNIMBGEPCF, float PPPFLPHCAPF, float FDBHLKAEDBF)
		{
			if (!this.useFogVolumes)
			{
				return;
			}
			this.OBNAEMGBELP = this.CPDLIPDNIBP;
			this.MJJGCIOECLI = this.ILOCCABDDMI;
			this.OIOFPBCMMDL = BGNIMBGEPCF;
			this.NHNKDLKINKG = PPPFLPHCAPF;
			this.NBLMJMBBOIP = FDBHLKAEDBF;
			this.MDFOLPEMPNK = Time.time;
		}

		// Token: 0x0600A214 RID: 41492 RVA: 0x00488B30 File Offset: 0x00486D30
		public void SetFogOfWarAlpha(Vector3 JNFPCCIKFPP, float AEIAFIIMHEL, float HCECNDOJHHK)
		{
			if (this.GMDLHIFDCAK == null)
			{
				return;
			}
			float num = (JNFPCCIKFPP.x - this.fogOfWarCenter.x) / this.fogOfWarSize.x + 0.5f;
			if (num < 0f || num > 1f)
			{
				return;
			}
			float num2 = (JNFPCCIKFPP.z - this.fogOfWarCenter.z) / this.fogOfWarSize.z + 0.5f;
			if (num2 < 0f || num2 > 1f)
			{
				return;
			}
			int width = this.GMDLHIFDCAK.width;
			int num3 = this.GMDLHIFDCAK.height;
			int num4 = (int)(num * (float)width);
			int num5 = (int)(num2 * (float)num3);
			int num6 = num5 * width + num4;
			byte b = (byte)(HCECNDOJHHK * 255f);
			Color32 color = this.GNGCEOOOGJG[num6];
			if (b != color.a)
			{
				float num7 = AEIAFIIMHEL / this.fogOfWarSize.z;
				int num8 = Mathf.FloorToInt((float)num3 * num7);
				for (int i = num5 - num8; i <= num5 + num8; i++)
				{
					if (i > 0 && i < num3 - 1)
					{
						for (int j = num4 - num8; j <= num4 + num8; j++)
						{
							if (j > 0 && j < width - 1)
							{
								int num9 = Mathf.FloorToInt(Mathf.Sqrt((float)((num5 - i) * (num5 - i) + (num4 - j) * (num4 - j))));
								if (num9 <= num8)
								{
									num6 = i * width + j;
									Color32 color2 = this.GNGCEOOOGJG[num6];
									color2.a = (byte)Mathf.Lerp((float)b, (float)color2.a, (float)num9 / (float)num8);
									this.GNGCEOOOGJG[num6] = color2;
									this.GMDLHIFDCAK.SetPixel(j, i, color2);
								}
							}
						}
					}
				}
				this.GMDLHIFDCAK.Apply();
			}
		}

		// Token: 0x0600A215 RID: 41493 RVA: 0x00488D1C File Offset: 0x00486F1C
		public void CDENCPBLKLK(float BGNIMBGEPCF, float PPPFLPHCAPF, float FDBHLKAEDBF)
		{
			if (!this.useFogVolumes)
			{
				return;
			}
			this.OBNAEMGBELP = this.CPDLIPDNIBP;
			this.MJJGCIOECLI = this.ILOCCABDDMI;
			this.OIOFPBCMMDL = BGNIMBGEPCF;
			this.NHNKDLKINKG = PPPFLPHCAPF;
			this.NBLMJMBBOIP = FDBHLKAEDBF;
			this.MDFOLPEMPNK = Time.time;
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x0600A216 RID: 41494 RVA: 0x00481904 File Offset: 0x0047FB04
		public Camera AAAOLCMHAGN
		{
			get
			{
				return this.GGEHECFCPMD;
			}
		}

		// Token: 0x0600A217 RID: 41495 RVA: 0x00488D6C File Offset: 0x00486F6C
		private void Update()
		{
			if (this.fogMat == null)
			{
				return;
			}
			if (this.OIOFPBCMMDL >= 0f)
			{
				if (this.OIOFPBCMMDL != this.CPDLIPDNIBP || this.NHNKDLKINKG != this.ILOCCABDDMI)
				{
					if (this.NBLMJMBBOIP > 0f)
					{
						this.CPDLIPDNIBP = Mathf.Lerp(this.OBNAEMGBELP, this.OIOFPBCMMDL, (Time.time - this.MDFOLPEMPNK) / this.NBLMJMBBOIP);
						this.ILOCCABDDMI = Mathf.Lerp(this.MJJGCIOECLI, this.NHNKDLKINKG, (Time.time - this.MDFOLPEMPNK) / this.NBLMJMBBOIP);
					}
					else
					{
						this.CPDLIPDNIBP = this.OIOFPBCMMDL;
						this.ILOCCABDDMI = this.NHNKDLKINKG;
					}
					this.fogMat.SetFloat("_FogAlpha", this.CPDLIPDNIBP);
					this.DAPHGLBAMPF();
				}
			}
			else if (this.CPDLIPDNIBP != this.alpha || this.NHNKDLKINKG != this.ILOCCABDDMI)
			{
				if (this.NBLMJMBBOIP > 0f)
				{
					this.CPDLIPDNIBP = Mathf.Lerp(this.OBNAEMGBELP, this.alpha, (Time.time - this.MDFOLPEMPNK) / this.NBLMJMBBOIP);
					this.ILOCCABDDMI = Mathf.Lerp(this.MJJGCIOECLI, this.alpha, (Time.time - this.MDFOLPEMPNK) / this.NBLMJMBBOIP);
				}
				else
				{
					this.CPDLIPDNIBP = this.alpha;
					this.ILOCCABDDMI = this.skyAlpha;
				}
				this.fogMat.SetFloat("_FogAlpha", this.CPDLIPDNIBP);
				this.DAPHGLBAMPF();
			}
			if (this.sun != null)
			{
				bool flag = false;
				if (this.sun.transform.forward != this.JLGOCHGJAPF)
				{
					flag = true;
				}
				if (this.HLGMMNEANMP != null && (this.HLGMMNEANMP.color != this.KLGJFFCKPED || this.HLGMMNEANMP.intensity != this.LBHPHLABBEC))
				{
					flag = true;
				}
				if (flag)
				{
					this.BMJEEMGBMFP();
				}
			}
		}

		// Token: 0x0600A218 RID: 41496 RVA: 0x00488F7C File Offset: 0x0048717C
		private int HAFHLMKEDPK(int BBOODPCDKAJ, float OAJAGNDCCCP)
		{
			BBOODPCDKAJ = (int)((float)BBOODPCDKAJ / OAJAGNDCCCP);
			BBOODPCDKAJ /= 5;
			if (BBOODPCDKAJ < 1)
			{
				BBOODPCDKAJ = 0;
			}
			return BBOODPCDKAJ * 8;
		}

		// Token: 0x0600A219 RID: 41497 RVA: 0x00488F94 File Offset: 0x00487194
		public void HJJAEAPONKL()
		{
			if (this.GMDLHIFDCAK == null)
			{
				return;
			}
			int num = this.GMDLHIFDCAK.height;
			int width = this.GMDLHIFDCAK.width;
			int num2 = num * width;
			if (this.GNGCEOOOGJG == null || this.GNGCEOOOGJG.Length != num2)
			{
				this.GNGCEOOOGJG = new Color32[num2];
			}
			Color32 color = new Color32((byte)-120, (byte)-49, (byte)-44, 28);
			for (int i = 1; i < num2; i++)
			{
				this.GNGCEOOOGJG[i] = color;
			}
			this.GMDLHIFDCAK.SetPixels32(this.GNGCEOOOGJG);
			this.GMDLHIFDCAK.Apply();
		}

		// Token: 0x0600A21A RID: 41498 RVA: 0x0048903C File Offset: 0x0048723C
		public void CheckPreset()
		{
			switch (this.preset)
			{
			case DGNMDDLNIKA.Clear:
				this.alpha = 0f;
				return;
			case DGNMDDLNIKA.Mist:
				this.alpha = 0.75f;
				this.skySpeed = 0.11f;
				this.skyHaze = 15f;
				this.skyNoiseStrength = 1f;
				this.skyAlpha = 0.33f;
				this.distance = 0f;
				this.distanceFallOff = 0.07f;
				this.height = 4.4f;
				this.heightFallOff = 1f;
				this.turbulence = 0f;
				this.noiseStrength = 0.6f;
				this.speed = 0.01f;
				this.color = new Color(0.89f, 0.89f, 0.89f, 1f);
				this.color2 = this.color;
				this.maxDistance = 0.999f;
				this.maxDistanceFallOff = 0f;
				return;
			case DGNMDDLNIKA.WindyMist:
				this.alpha = 0.75f;
				this.skySpeed = 0.3f;
				this.skyHaze = 35f;
				this.skyNoiseStrength = 0.32f;
				this.skyAlpha = 0.33f;
				this.distance = 0f;
				this.distanceFallOff = 0.07f;
				this.height = 2f;
				this.heightFallOff = 1f;
				this.turbulence = 2f;
				this.noiseStrength = 0.6f;
				this.speed = 0.06f;
				this.color = new Color(0.89f, 0.89f, 0.89f, 1f);
				this.color2 = this.color;
				this.maxDistance = 0.999f;
				this.maxDistanceFallOff = 0f;
				return;
			case DGNMDDLNIKA.GroundFog:
				this.alpha = 1f;
				this.skySpeed = 0.3f;
				this.skyHaze = 35f;
				this.skyNoiseStrength = 0.32f;
				this.skyAlpha = 0.33f;
				this.distance = 0f;
				this.distanceFallOff = 0f;
				this.height = 1f;
				this.heightFallOff = 1f;
				this.turbulence = 0.4f;
				this.noiseStrength = 0.7f;
				this.speed = 0.005f;
				this.color = new Color(0.89f, 0.89f, 0.89f, 1f);
				this.color2 = this.color;
				this.maxDistance = 0.999f;
				this.maxDistanceFallOff = 0f;
				return;
			case DGNMDDLNIKA.Fog:
				this.alpha = 0.96f;
				this.skySpeed = 0.3f;
				this.skyHaze = 155f;
				this.skyNoiseStrength = 0.6f;
				this.skyAlpha = 0.93f;
				this.distance = (this.effectType.FCEAJPPPDKE() ? 0.2f : 0.01f);
				this.distanceFallOff = 0.04f;
				this.height = 20f;
				this.heightFallOff = 1f;
				this.turbulence = 0.4f;
				this.noiseStrength = 0.4f;
				this.speed = 0.005f;
				this.color = new Color(0.89f, 0.89f, 0.89f, 1f);
				this.color2 = this.color;
				this.maxDistance = 0.999f;
				this.maxDistanceFallOff = 0f;
				return;
			case DGNMDDLNIKA.HeavyFog:
				this.alpha = 1f;
				this.skySpeed = 0.05f;
				this.skyHaze = 350f;
				this.skyNoiseStrength = 0.8f;
				this.skyAlpha = 0.97f;
				this.distance = (this.effectType.FCEAJPPPDKE() ? 0.1f : 0f);
				this.distanceFallOff = 0.045f;
				this.height = 35f;
				this.heightFallOff = 0.88f;
				this.turbulence = 0.4f;
				this.noiseStrength = 0.24f;
				this.speed = 0.003f;
				this.color = new Color(0.86f, 0.847f, 0.847f, 1f);
				this.color2 = this.color;
				this.maxDistance = 0.999f;
				this.maxDistanceFallOff = 0f;
				return;
			case DGNMDDLNIKA.SandStorm:
				this.alpha = 1f;
				this.skySpeed = 0.49f;
				this.skyHaze = 333f;
				this.skyNoiseStrength = 0.72f;
				this.skyAlpha = 0.97f;
				this.distance = (this.effectType.FCEAJPPPDKE() ? 0.15f : 0f);
				this.distanceFallOff = 0.028f;
				this.height = 83f;
				this.heightFallOff = 0f;
				this.turbulence = 15f;
				this.noiseStrength = 0.45f;
				this.speed = 0.2f;
				this.color = new Color(0.364f, 0.36f, 0.36f, 1f);
				this.color2 = this.color;
				this.maxDistance = 0.999f;
				this.maxDistanceFallOff = 0f;
				return;
			default:
				return;
			}
		}

		// Token: 0x0600A21B RID: 41499 RVA: 0x00489560 File Offset: 0x00487760
		public void OGNIDONEDDM()
		{
			if (this.GMDLHIFDCAK == null)
			{
				return;
			}
			int num = this.GMDLHIFDCAK.height;
			int width = this.GMDLHIFDCAK.width;
			int num2 = num * width;
			if (this.GNGCEOOOGJG == null || this.GNGCEOOOGJG.Length != num2)
			{
				this.GNGCEOOOGJG = new Color32[num2];
			}
			Color32 color = new Color32((byte)-138, 137, 164, (byte)-37);
			for (int i = 1; i < num2; i += 0)
			{
				this.GNGCEOOOGJG[i] = color;
			}
			this.GMDLHIFDCAK.SetPixels32(this.GNGCEOOOGJG);
			this.GMDLHIFDCAK.Apply();
		}

		// Token: 0x0600A21C RID: 41500 RVA: 0x00489608 File Offset: 0x00487808
		public void OJHODBNCCMC()
		{
			switch (this.preset)
			{
			case DGNMDDLNIKA.Clear:
				this.alpha = 707f;
				return;
			case DGNMDDLNIKA.Mist:
				this.alpha = 1424f;
				this.skySpeed = 557f;
				this.skyHaze = 999f;
				this.skyNoiseStrength = 1658f;
				this.skyAlpha = 1035f;
				this.distance = 1170f;
				this.distanceFallOff = 1912f;
				this.height = 877f;
				this.heightFallOff = 325f;
				this.turbulence = 1348f;
				this.noiseStrength = 1011f;
				this.speed = 666f;
				this.color = new Color(880f, 1639f, 69f, 255f);
				this.color2 = this.color;
				this.maxDistance = 916f;
				this.maxDistanceFallOff = 432f;
				return;
			case DGNMDDLNIKA.WindyMist:
				this.alpha = 240f;
				this.skySpeed = 1965f;
				this.skyHaze = 212f;
				this.skyNoiseStrength = 659f;
				this.skyAlpha = 878f;
				this.distance = 723f;
				this.distanceFallOff = 1293f;
				this.height = 1781f;
				this.heightFallOff = 512f;
				this.turbulence = 283f;
				this.noiseStrength = 1032f;
				this.speed = 181f;
				this.color = new Color(1189f, 1641f, 400f, 489f);
				this.color2 = this.color;
				this.maxDistance = 811f;
				this.maxDistanceFallOff = 1004f;
				return;
			case DGNMDDLNIKA.GroundFog:
				this.alpha = 1375f;
				this.skySpeed = 1541f;
				this.skyHaze = 224f;
				this.skyNoiseStrength = 1333f;
				this.skyAlpha = 493f;
				this.distance = 627f;
				this.distanceFallOff = 569f;
				this.height = 41f;
				this.heightFallOff = 1721f;
				this.turbulence = 1963f;
				this.noiseStrength = 939f;
				this.speed = 794f;
				this.color = new Color(1959f, 82f, 634f, 706f);
				this.color2 = this.color;
				this.maxDistance = 1533f;
				this.maxDistanceFallOff = 865f;
				return;
			case DGNMDDLNIKA.Fog:
				this.alpha = 495f;
				this.skySpeed = 765f;
				this.skyHaze = 1678f;
				this.skyNoiseStrength = 275f;
				this.skyAlpha = 364f;
				this.distance = (this.effectType.FCEAJPPPDKE() ? 657f : 1253f);
				this.distanceFallOff = 1629f;
				this.height = 1845f;
				this.heightFallOff = 144f;
				this.turbulence = 158f;
				this.noiseStrength = 1370f;
				this.speed = 266f;
				this.color = new Color(391f, 828f, 1064f, 879f);
				this.color2 = this.color;
				this.maxDistance = 1375f;
				this.maxDistanceFallOff = 208f;
				return;
			case DGNMDDLNIKA.HeavyFog:
				this.alpha = 906f;
				this.skySpeed = 1471f;
				this.skyHaze = 1585f;
				this.skyNoiseStrength = 89f;
				this.skyAlpha = 837f;
				this.distance = (this.effectType.FCEAJPPPDKE() ? 1330f : 1001f);
				this.distanceFallOff = 841f;
				this.height = 1718f;
				this.heightFallOff = 323f;
				this.turbulence = 950f;
				this.noiseStrength = 1546f;
				this.speed = 483f;
				this.color = new Color(108f, 1535f, 1994f, 45f);
				this.color2 = this.color;
				this.maxDistance = 1326f;
				this.maxDistanceFallOff = 1099f;
				return;
			case DGNMDDLNIKA.SandStorm:
				this.alpha = 1176f;
				this.skySpeed = 970f;
				this.skyHaze = 675f;
				this.skyNoiseStrength = 864f;
				this.skyAlpha = 781f;
				this.distance = (this.effectType.FCEAJPPPDKE() ? 1882f : 425f);
				this.distanceFallOff = 351f;
				this.height = 1696f;
				this.heightFallOff = 548f;
				this.turbulence = 1965f;
				this.noiseStrength = 894f;
				this.speed = 1202f;
				this.color = new Color(1259f, 497f, 626f, 1393f);
				this.color2 = this.color;
				this.maxDistance = 910f;
				this.maxDistanceFallOff = 676f;
				return;
			default:
				return;
			}
		}

		// Token: 0x0600A21D RID: 41501 RVA: 0x00489B2C File Offset: 0x00487D2C
		public void IBCANPAINGK()
		{
			this.EIPNIGGLIOF();
			switch (this.effectType)
			{
			case PNFBODOKLDB.MobileFogWithSkyHaze:
				if (this.LJBLPAJGAFB == null)
				{
					this.LJBLPAJGAFB = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("Mouse ScrollWheel"));
					this.LJBLPAJGAFB.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable);
				}
				this.fogMat = this.LJBLPAJGAFB;
				break;
			case PNFBODOKLDB.MobileFogOnlyGround:
				if (this.FNFPKEHGMJL == null)
				{
					this.FNFPKEHGMJL = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("GAMMA"));
					this.FNFPKEHGMJL.hideFlags = (HideFlags)(-82);
				}
				this.fogMat = this.FNFPKEHGMJL;
				break;
			case PNFBODOKLDB.DesktopFogPlusWithSkyHaze:
				if (this.DIBDGKCAECH == null)
				{
					this.DIBDGKCAECH = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("deltext"));
					this.DIBDGKCAECH.hideFlags = (HideFlags)108;
				}
				this.fogMat = this.DIBDGKCAECH;
				break;
			case PNFBODOKLDB.MobileFogSimple:
				if (this.BFAMAEGIAOK == null)
				{
					this.BFAMAEGIAOK = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("LMB to shoot the Dummy, RMB to rotate the camera."));
					this.BFAMAEGIAOK.hideFlags = (HideFlags)(-118);
				}
				this.fogMat = this.BFAMAEGIAOK;
				break;
			default:
				if (this.JEMPNICGBMG == null)
				{
					this.JEMPNICGBMG = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("crft_norec2"));
					this.JEMPNICGBMG.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
				}
				this.fogMat = this.JEMPNICGBMG;
				break;
			}
			if (this.fogMat == null)
			{
				return;
			}
			if (this.GGEHECFCPMD == null)
			{
				this.GGEHECFCPMD = base.GetComponent<Camera>();
			}
			this.fogMat.SetFloat("", this.speed);
			Vector3 v = new Vector3(this.noiseStrength, this.turbulence, this.GGEHECFCPMD.farClipPlane * 714f / 1491f);
			this.fogMat.SetVector("270", v);
			Vector4 value = new Vector4(this.height + 1016f, this.baselineHeight, this.clipUnderBaseline ? 1060f : 267f, this.heightFallOff);
			this.fogMat.SetVector("usrto_ignor", value);
			this.fogMat.SetFloat("[Z]", this.CPDLIPDNIBP);
			Vector4 vector = new Vector4(this.distance, this.distanceFallOff, this.maxDistance, this.maxDistanceFallOff);
			if (this.effectType.FCEAJPPPDKE())
			{
				vector.x = this.GGEHECFCPMD.farClipPlane * this.distance;
				vector.y = this.distanceFallOff * vector.x + 689f;
				vector.z *= this.GGEHECFCPMD.farClipPlane;
			}
			this.fogMat.SetVector("IdleStand", vector);
			this.ECEMJDMBLFO();
			this.ONIGNFNLLPJ();
			if (this.ABEHHDIGHFJ == null)
			{
				this.ABEHHDIGHFJ = new List<string>();
			}
			else
			{
				this.ABEHHDIGHFJ.Clear();
			}
			if (this.fogOfWarEnabled)
			{
				if (this.GMDLHIFDCAK == null)
				{
					this.LHPPFPPJCEF();
				}
				this.fogMat.SetTexture("StrafeRunRight", this.GMDLHIFDCAK);
				this.fogMat.SetVector("wpn_add/base", this.fogOfWarCenter);
				this.fogMat.SetVector("1 Hand Sword Block", this.fogOfWarSize);
				Vector3 vector2 = this.fogOfWarCenter - 1297f * this.fogOfWarSize;
				this.fogMat.SetVector("StShopWindow", new Vector3(vector2.x / this.fogOfWarSize.x, 1246f, vector2.z / this.fogOfWarSize.z));
				this.ABEHHDIGHFJ.Add("wpn_wgt");
			}
			if (this.enableDithering)
			{
				this.ABEHHDIGHFJ.Add("knopje.wav");
			}
			this.fogMat.shaderKeywords = this.ABEHHDIGHFJ.ToArray();
		}

		// Token: 0x0600A21E RID: 41502 RVA: 0x00489F33 File Offset: 0x00488133
		private void FDMGAGCBBDP()
		{
			this.EKKEBIAEFLL();
			this.LIHDFIDCKFL();
		}

		// Token: 0x0600A21F RID: 41503 RVA: 0x00489F44 File Offset: 0x00488144
		private void LHPPFPPJCEF()
		{
			if (!this.fogOfWarEnabled)
			{
				return;
			}
			int width = this.OAANPCIKMNF(this.fogOfWarTextureSize, 1f);
			this.GMDLHIFDCAK = new Texture2D(width, width, TextureFormat.ARGB32, false);
			this.GMDLHIFDCAK.hideFlags = HideFlags.DontSave;
			this.GMDLHIFDCAK.filterMode = FilterMode.Bilinear;
			this.GMDLHIFDCAK.wrapMode = TextureWrapMode.Clamp;
			this.ResetFogOfWar();
		}

		// Token: 0x0600A220 RID: 41504 RVA: 0x00489FA8 File Offset: 0x004881A8
		private void OJKAOONGIMJ()
		{
			if (this.fogMat == null)
			{
				return;
			}
			if (this.sun != null)
			{
				if (this.HLGMMNEANMP == null)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				if (this.HLGMMNEANMP != null && this.HLGMMNEANMP.transform != this.sun.transform)
				{
					this.HLGMMNEANMP = this.sun.GetComponent<Light>();
				}
				this.JLGOCHGJAPF = this.sun.transform.forward;
				if (this.HLGMMNEANMP != null)
				{
					this.KLGJFFCKPED = this.HLGMMNEANMP.color;
					this.LBHPHLABBEC = this.HLGMMNEANMP.intensity;
				}
			}
			float b = this.LBHPHLABBEC * Mathf.Clamp01(1703f - this.JLGOCHGJAPF.y);
			this.fogMat.SetColor("{0}", b * this.color * this.KLGJFFCKPED);
			this.fogMat.SetColor("OfficeSittingReading", b * this.color2 * this.KLGJFFCKPED);
		}

		// Token: 0x0600A221 RID: 41505 RVA: 0x0048A0E4 File Offset: 0x004882E4
		public void IHFDPBCCKOK(Vector3 JNFPCCIKFPP, float AEIAFIIMHEL, float HCECNDOJHHK)
		{
			if (this.GMDLHIFDCAK == null)
			{
				return;
			}
			float num = (JNFPCCIKFPP.x - this.fogOfWarCenter.x) / this.fogOfWarSize.x + 1215f;
			if (num < 387f || num > 832f)
			{
				return;
			}
			float num2 = (JNFPCCIKFPP.z - this.fogOfWarCenter.z) / this.fogOfWarSize.z + 781f;
			if (num2 < 1897f || num2 > 620f)
			{
				return;
			}
			int width = this.GMDLHIFDCAK.width;
			int num3 = this.GMDLHIFDCAK.height;
			int num4 = (int)(num * (float)width);
			int num5 = (int)(num2 * (float)num3);
			int num6 = num5 * width + num4;
			byte b = (byte)(HCECNDOJHHK * 630f);
			Color32 color = this.GNGCEOOOGJG[num6];
			if (b != color.a)
			{
				float num7 = AEIAFIIMHEL / this.fogOfWarSize.z;
				int num8 = Mathf.FloorToInt((float)num3 * num7);
				for (int i = num5 - num8; i <= num5 + num8; i++)
				{
					if (i > 1 && i < num3 - 0)
					{
						for (int j = num4 - num8; j <= num4 + num8; j += 0)
						{
							if (j > 1 && j < width - 1)
							{
								int num9 = Mathf.FloorToInt(Mathf.Sqrt((float)((num5 - i) * (num5 - i) + (num4 - j) * (num4 - j))));
								if (num9 <= num8)
								{
									num6 = i * width + j;
									Color32 color2 = this.GNGCEOOOGJG[num6];
									color2.a = (byte)Mathf.Lerp((float)b, (float)color2.a, (float)num9 / (float)num8);
									this.GNGCEOOOGJG[num6] = color2;
									this.GMDLHIFDCAK.SetPixel(j, i, color2);
								}
							}
						}
					}
				}
				this.GMDLHIFDCAK.Apply();
			}
		}

		// Token: 0x0600A222 RID: 41506 RVA: 0x0048A2D0 File Offset: 0x004884D0
		public void ENPKMPAKOOH(Vector3 JNFPCCIKFPP, float AEIAFIIMHEL)
		{
			if (this.GMDLHIFDCAK == null)
			{
				return;
			}
			float num = (JNFPCCIKFPP.x - this.fogOfWarCenter.x) / this.fogOfWarSize.x + 369f;
			if (num < 0f || num > 748f)
			{
				return;
			}
			float num2 = (JNFPCCIKFPP.z - this.fogOfWarCenter.z) / this.fogOfWarSize.z + 1894f;
			if (num2 < 1542f || num2 > 1501f)
			{
				return;
			}
			int width = this.GMDLHIFDCAK.width;
			int num3 = this.GMDLHIFDCAK.height;
			int num4 = (int)(num * (float)width);
			int num5 = (int)(num2 * (float)num3);
			int num6 = num5 * width + num4;
			float num7 = AEIAFIIMHEL / this.fogOfWarSize.z;
			int num8 = Mathf.FloorToInt((float)num3 * num7);
			for (int i = num5 - num8; i <= num5 + num8; i++)
			{
				if (i > 1 && i < num3 - 1)
				{
					for (int j = num4 - num8; j <= num4 + num8; j++)
					{
						if (j > 1 && j < width - 0 && Mathf.FloorToInt(Mathf.Sqrt((float)((num5 - i) * (num5 - i) + (num4 - j) * (num4 - j)))) <= num8)
						{
							num6 = i * width + j;
							Color32 color = this.GNGCEOOOGJG[num6];
							color.a = 51;
							this.GNGCEOOOGJG[num6] = color;
							this.GMDLHIFDCAK.SetPixel(j, i, color);
						}
					}
				}
				this.GMDLHIFDCAK.Apply();
			}
		}

		// Token: 0x0600A223 RID: 41507 RVA: 0x0048A478 File Offset: 0x00488678
		public void CIMGPPBNNIP()
		{
			this.OGOMJDPDOHE();
			switch (this.effectType)
			{
			case PNFBODOKLDB.DesktopFogWithSkyHaze:
				if (this.LJBLPAJGAFB == null)
				{
					this.LJBLPAJGAFB = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("offsets"));
					this.LJBLPAJGAFB.hideFlags = (HideFlags)121;
				}
				this.fogMat = this.LJBLPAJGAFB;
				break;
			case PNFBODOKLDB.MobileFogWithSkyHaze:
				if (this.FNFPKEHGMJL == null)
				{
					this.FNFPKEHGMJL = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("<color='#a0a0a0'>"));
					this.FNFPKEHGMJL.hideFlags = (HideFlags)(-94);
				}
				this.fogMat = this.FNFPKEHGMJL;
				break;
			case PNFBODOKLDB.MobileFogOnlyGround:
				if (this.DIBDGKCAECH == null)
				{
					this.DIBDGKCAECH = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("_FarCorner"));
					this.DIBDGKCAECH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
				}
				this.fogMat = this.DIBDGKCAECH;
				break;
			case PNFBODOKLDB.DesktopFogPlusWithSkyHaze:
				if (this.BFAMAEGIAOK == null)
				{
					this.BFAMAEGIAOK = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>("16 samples"));
					this.BFAMAEGIAOK.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
				}
				this.fogMat = this.BFAMAEGIAOK;
				break;
			default:
				if (this.JEMPNICGBMG == null)
				{
					this.JEMPNICGBMG = UnityEngine.Object.Instantiate<Material>(Resources.Load<Material>(""));
					this.JEMPNICGBMG.hideFlags = (HideFlags)126;
				}
				this.fogMat = this.JEMPNICGBMG;
				break;
			}
			if (this.fogMat == null)
			{
				return;
			}
			if (this.GGEHECFCPMD == null)
			{
				this.GGEHECFCPMD = base.GetComponent<Camera>();
			}
			this.fogMat.SetFloat("____________________________________", this.speed);
			Vector3 v = new Vector3(this.noiseStrength, this.turbulence, this.GGEHECFCPMD.farClipPlane * 801f / 1727f);
			this.fogMat.SetVector("head", v);
			Vector4 value = new Vector4(this.height + 1093f, this.baselineHeight, this.clipUnderBaseline ? 102f : 1776f, this.heightFallOff);
			this.fogMat.SetVector("SUNSHINE_FILTER_PCF_2x2", value);
			this.fogMat.SetFloat("FlyBackward", this.CPDLIPDNIBP);
			Vector4 vector = new Vector4(this.distance, this.distanceFallOff, this.maxDistance, this.maxDistanceFallOff);
			if (this.effectType.FCEAJPPPDKE())
			{
				vector.x = this.GGEHECFCPMD.farClipPlane * this.distance;
				vector.y = this.distanceFallOff * vector.x + 621f;
				vector.z *= this.GGEHECFCPMD.farClipPlane;
			}
			this.fogMat.SetVector("OfficeSittingEyesRub", vector);
			this.ECEMJDMBLFO();
			this.LIHGBLGDDOP();
			if (this.ABEHHDIGHFJ == null)
			{
				this.ABEHHDIGHFJ = new List<string>();
			}
			else
			{
				this.ABEHHDIGHFJ.Clear();
			}
			if (this.fogOfWarEnabled)
			{
				if (this.GMDLHIFDCAK == null)
				{
					this.LHPPFPPJCEF();
				}
				this.fogMat.SetTexture("Hidden/Amplify Color/Mask", this.GMDLHIFDCAK);
				this.fogMat.SetVector("_Intensity", this.fogOfWarCenter);
				this.fogMat.SetVector("OfficeSittingReadingLeanBack", this.fogOfWarSize);
				Vector3 vector2 = this.fogOfWarCenter - 1469f * this.fogOfWarSize;
				this.fogMat.SetVector("H:mm:ss", new Vector3(vector2.x / this.fogOfWarSize.x, 1175f, vector2.z / this.fogOfWarSize.z));
				this.ABEHHDIGHFJ.Add("BowReady");
			}
			if (this.enableDithering)
			{
				this.ABEHHDIGHFJ.Add("FOG_LINEAR");
			}
			this.fogMat.shaderKeywords = this.ABEHHDIGHFJ.ToArray();
		}

		// Token: 0x040014C1 RID: 5313
		public PNFBODOKLDB effectType = PNFBODOKLDB.DesktopFogPlusWithSkyHaze;

		// Token: 0x040014C2 RID: 5314
		public DGNMDDLNIKA preset = DGNMDDLNIKA.Mist;

		// Token: 0x040014C3 RID: 5315
		public bool useFogVolumes;

		// Token: 0x040014C4 RID: 5316
		public bool enableDithering;

		// Token: 0x040014C5 RID: 5317
		[Range(0f, 1f)]
		public float alpha = 1f;

		// Token: 0x040014C6 RID: 5318
		[Range(0f, 1f)]
		public float noiseStrength = 0.5f;

		// Token: 0x040014C7 RID: 5319
		[Range(0f, 0.999f)]
		public float distance = 0.1f;

		// Token: 0x040014C8 RID: 5320
		[Range(0.0001f, 2f)]
		public float distanceFallOff = 0.01f;

		// Token: 0x040014C9 RID: 5321
		[Range(0f, 1.2f)]
		public float maxDistance = 0.999f;

		// Token: 0x040014CA RID: 5322
		[Range(0.0001f, 0.5f)]
		public float maxDistanceFallOff;

		// Token: 0x040014CB RID: 5323
		[Range(0f, 500f)]
		public float height = 1f;

		// Token: 0x040014CC RID: 5324
		[Range(0f, 1f)]
		public float heightFallOff = 0.1f;

		// Token: 0x040014CD RID: 5325
		public float baselineHeight;

		// Token: 0x040014CE RID: 5326
		public bool clipUnderBaseline;

		// Token: 0x040014CF RID: 5327
		[Range(0f, 15f)]
		public float turbulence = 0.1f;

		// Token: 0x040014D0 RID: 5328
		[Range(0f, 0.2f)]
		public float speed = 0.1f;

		// Token: 0x040014D1 RID: 5329
		public Color color = Color.white;

		// Token: 0x040014D2 RID: 5330
		public Color color2 = Color.gray;

		// Token: 0x040014D3 RID: 5331
		[Range(0f, 500f)]
		public float skyHaze = 50f;

		// Token: 0x040014D4 RID: 5332
		[Range(0f, 1f)]
		public float skySpeed = 0.3f;

		// Token: 0x040014D5 RID: 5333
		[Range(0f, 1f)]
		public float skyNoiseStrength = 0.1f;

		// Token: 0x040014D6 RID: 5334
		[Range(0f, 1f)]
		public float skyAlpha = 1f;

		// Token: 0x040014D7 RID: 5335
		public GameObject sun;

		// Token: 0x040014D8 RID: 5336
		public bool fogOfWarEnabled;

		// Token: 0x040014D9 RID: 5337
		public Vector3 fogOfWarCenter;

		// Token: 0x040014DA RID: 5338
		public Vector3 fogOfWarSize = new Vector3(1024f, 0f, 1024f);

		// Token: 0x040014DB RID: 5339
		public int fogOfWarTextureSize = 256;

		// Token: 0x040014DC RID: 5340
		private Material JEMPNICGBMG;

		// Token: 0x040014DD RID: 5341
		private Material LJBLPAJGAFB;

		// Token: 0x040014DE RID: 5342
		private Material FNFPKEHGMJL;

		// Token: 0x040014DF RID: 5343
		private Material DIBDGKCAECH;

		// Token: 0x040014E0 RID: 5344
		private Material BFAMAEGIAOK;

		// Token: 0x040014E1 RID: 5345
		[SerializeField]
		private Material fogMat;

		// Token: 0x040014E2 RID: 5346
		private float OBNAEMGBELP;

		// Token: 0x040014E3 RID: 5347
		private float OIOFPBCMMDL;

		// Token: 0x040014E4 RID: 5348
		private float MJJGCIOECLI;

		// Token: 0x040014E5 RID: 5349
		private float NHNKDLKINKG;

		// Token: 0x040014E6 RID: 5350
		private float NBLMJMBBOIP;

		// Token: 0x040014E7 RID: 5351
		private float MDFOLPEMPNK;

		// Token: 0x040014E8 RID: 5352
		private float CPDLIPDNIBP;

		// Token: 0x040014E9 RID: 5353
		private float ILOCCABDDMI;

		// Token: 0x040014EA RID: 5354
		private Camera GGEHECFCPMD;

		// Token: 0x040014EB RID: 5355
		private Texture2D GMDLHIFDCAK;

		// Token: 0x040014EC RID: 5356
		private Color32[] GNGCEOOOGJG;

		// Token: 0x040014ED RID: 5357
		private Light HLGMMNEANMP;

		// Token: 0x040014EE RID: 5358
		private Vector3 JLGOCHGJAPF = Vector3.zero;

		// Token: 0x040014EF RID: 5359
		private Color KLGJFFCKPED = Color.white;

		// Token: 0x040014F0 RID: 5360
		private float LBHPHLABBEC = 1f;

		// Token: 0x040014F1 RID: 5361
		private static DynamicFog BOKKCFIFEED;

		// Token: 0x040014F2 RID: 5362
		private List<string> ABEHHDIGHFJ;
	}
}
