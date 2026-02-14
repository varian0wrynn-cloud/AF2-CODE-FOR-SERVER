using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x0200032F RID: 815
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Rendering/Screen Space Ambient Occlusion")]
	public class ScreenSpaceAmbientOcclusion : MonoBehaviour
	{
		// Token: 0x0600BAF1 RID: 47857 RVA: 0x0053A425 File Offset: 0x00538625
		private static void EJNEEKIMPKN(Material LCBKJGFGGGF)
		{
			if (LCBKJGFGGGF)
			{
				UnityEngine.Object.DestroyImmediate(LCBKJGFGGGF);
				LCBKJGFGGGF = null;
			}
		}

		// Token: 0x0600BAF2 RID: 47858 RVA: 0x0053A438 File Offset: 0x00538638
		private void CBLGFOFHNPJ()
		{
			if (!SystemInfo.supportsImageEffects || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				this.JEAOMBOAPEC = true;
				base.enabled = true;
				return;
			}
			this.BKIDKCDBFJC();
			if (!this.LNGELFODMDB || this.LNGELFODMDB.passCount != 0)
			{
				this.JEAOMBOAPEC = true;
				base.enabled = false;
				return;
			}
			this.JEAOMBOAPEC = false;
		}

		// Token: 0x0600BAF3 RID: 47859 RVA: 0x0053A425 File Offset: 0x00538625
		private static void IOJCOGBBBBD(Material LCBKJGFGGGF)
		{
			if (LCBKJGFGGGF)
			{
				UnityEngine.Object.DestroyImmediate(LCBKJGFGGGF);
				LCBKJGFGGGF = null;
			}
		}

		// Token: 0x0600BAF4 RID: 47860 RVA: 0x0053A49C File Offset: 0x0053869C
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.JEAOMBOAPEC || !this.m_SSAOShader.isSupported)
			{
				base.enabled = false;
				return;
			}
			this.FNMFECJCGBP();
			this.m_Downsampling = Mathf.Clamp(this.m_Downsampling, 1, 6);
			this.m_Radius = Mathf.Clamp(this.m_Radius, 0.05f, 1f);
			this.m_MinZ = Mathf.Clamp(this.m_MinZ, 1E-05f, 0.5f);
			this.m_OcclusionIntensity = Mathf.Clamp(this.m_OcclusionIntensity, 0.5f, 4f);
			this.m_OcclusionAttenuation = Mathf.Clamp(this.m_OcclusionAttenuation, 0.2f, 2f);
			this.m_Blur = Mathf.Clamp(this.m_Blur, 0, 4);
			RenderTexture renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width / this.m_Downsampling, JONJODLFAEN.height / this.m_Downsampling, 0);
			float fieldOfView = base.GetComponent<Camera>().fieldOfView;
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			float num = Mathf.Tan(fieldOfView * 0.017453292f * 0.5f) * farClipPlane;
			float x = num * base.GetComponent<Camera>().aspect;
			this.LNGELFODMDB.SetVector("_FarCorner", new Vector3(x, num, farClipPlane));
			int num2;
			int num3;
			if (this.m_RandomTexture)
			{
				num2 = this.m_RandomTexture.width;
				num3 = this.m_RandomTexture.height;
			}
			else
			{
				num2 = 1;
				num3 = 1;
			}
			this.LNGELFODMDB.SetVector("_NoiseScale", new Vector3((float)renderTexture.width / (float)num2, (float)renderTexture.height / (float)num3, 0f));
			this.LNGELFODMDB.SetVector("_Params", new Vector4(this.m_Radius, this.m_MinZ, 1f / this.m_OcclusionAttenuation, this.m_OcclusionIntensity));
			bool flag = this.m_Blur > 0;
			Graphics.Blit(flag ? null : JONJODLFAEN, renderTexture, this.LNGELFODMDB, (int)this.m_SampleCount);
			if (flag)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0);
				this.LNGELFODMDB.SetVector("_TexelOffsetScale", new Vector4((float)this.m_Blur / (float)JONJODLFAEN.width, 0f, 0f, 0f));
				this.LNGELFODMDB.SetTexture("_SSAO", renderTexture);
				Graphics.Blit(null, temporary, this.LNGELFODMDB, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0);
				this.LNGELFODMDB.SetVector("_TexelOffsetScale", new Vector4(0f, (float)this.m_Blur / (float)JONJODLFAEN.height, 0f, 0f));
				this.LNGELFODMDB.SetTexture("_SSAO", temporary);
				Graphics.Blit(JONJODLFAEN, temporary2, this.LNGELFODMDB, 3);
				RenderTexture.ReleaseTemporary(temporary);
				renderTexture = temporary2;
			}
			this.LNGELFODMDB.SetTexture("_SSAO", renderTexture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LNGELFODMDB, 4);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600BAF5 RID: 47861 RVA: 0x0053A798 File Offset: 0x00538998
		private void EHFPLKEINFO()
		{
			if (!SystemInfo.supportsImageEffects || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				this.JEAOMBOAPEC = false;
				base.enabled = true;
				return;
			}
			this.PFJBHOPNOPP();
			if (!this.LNGELFODMDB || this.LNGELFODMDB.passCount != 1)
			{
				this.JEAOMBOAPEC = true;
				base.enabled = true;
				return;
			}
			this.JEAOMBOAPEC = true;
		}

		// Token: 0x0600BAF6 RID: 47862 RVA: 0x0053A7FA File Offset: 0x005389FA
		private void OnEnable()
		{
			base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.DepthNormals;
		}

		// Token: 0x0600BAF7 RID: 47863 RVA: 0x0053A425 File Offset: 0x00538625
		private static void HGHLHNFLKFM(Material LCBKJGFGGGF)
		{
			if (LCBKJGFGGGF)
			{
				UnityEngine.Object.DestroyImmediate(LCBKJGFGGGF);
				LCBKJGFGGGF = null;
			}
		}

		// Token: 0x0600BAF8 RID: 47864 RVA: 0x0053A425 File Offset: 0x00538625
		private static void FMNPNCNOEJM(Material LCBKJGFGGGF)
		{
			if (LCBKJGFGGGF)
			{
				UnityEngine.Object.DestroyImmediate(LCBKJGFGGGF);
				LCBKJGFGGGF = null;
			}
		}

		// Token: 0x0600BAF9 RID: 47865 RVA: 0x0053A80F File Offset: 0x00538A0F
		private void CCCAOGJKJOD()
		{
			ScreenSpaceAmbientOcclusion.HGHLHNFLKFM(this.LNGELFODMDB);
		}

		// Token: 0x0600BAFA RID: 47866 RVA: 0x0053A81C File Offset: 0x00538A1C
		private static Material OJCCNCIGKCG(Shader BAKBIMBKKNP)
		{
			if (!BAKBIMBKKNP)
			{
				return null;
			}
			return new Material(BAKBIMBKKNP)
			{
				hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset)
			};
		}

		// Token: 0x0600BAFB RID: 47867 RVA: 0x0053A836 File Offset: 0x00538A36
		private void KFLFNGGBAEB()
		{
			base.GetComponent<Camera>().depthTextureMode |= (DepthTextureMode)8;
		}

		// Token: 0x0600BAFC RID: 47868 RVA: 0x0053A84B File Offset: 0x00538A4B
		private static Material FBCIOGMBCKA(Shader BAKBIMBKKNP)
		{
			if (!BAKBIMBKKNP)
			{
				return null;
			}
			return new Material(BAKBIMBKKNP)
			{
				hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset)
			};
		}

		// Token: 0x0600BAFD RID: 47869 RVA: 0x0053A865 File Offset: 0x00538A65
		private static Material PHNMLJJBKDC(Shader BAKBIMBKKNP)
		{
			if (!BAKBIMBKKNP)
			{
				return null;
			}
			return new Material(BAKBIMBKKNP)
			{
				hideFlags = HideFlags.HideAndDontSave
			};
		}

		// Token: 0x0600BAFE RID: 47870 RVA: 0x0053A87F File Offset: 0x00538A7F
		private void OnDisable()
		{
			ScreenSpaceAmbientOcclusion.EJNEEKIMPKN(this.LNGELFODMDB);
		}

		// Token: 0x0600BAFF RID: 47871 RVA: 0x0053A88C File Offset: 0x00538A8C
		private void FIJKDFIMELM()
		{
			if (!SystemInfo.supportsImageEffects || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.JEAOMBOAPEC = false;
				base.enabled = false;
				return;
			}
			this.GHKDLFMFKOG();
			if (!this.LNGELFODMDB || this.LNGELFODMDB.passCount != 0)
			{
				this.JEAOMBOAPEC = true;
				base.enabled = false;
				return;
			}
			this.JEAOMBOAPEC = true;
		}

		// Token: 0x0600BB00 RID: 47872 RVA: 0x0053A8F0 File Offset: 0x00538AF0
		private void Start()
		{
			if (!SystemInfo.supportsImageEffects || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				this.JEAOMBOAPEC = false;
				base.enabled = false;
				return;
			}
			this.FNMFECJCGBP();
			if (!this.LNGELFODMDB || this.LNGELFODMDB.passCount != 5)
			{
				this.JEAOMBOAPEC = false;
				base.enabled = false;
				return;
			}
			this.JEAOMBOAPEC = true;
		}

		// Token: 0x0600BB01 RID: 47873 RVA: 0x0053A954 File Offset: 0x00538B54
		private void ANHOOJFEJJE()
		{
			if (!SystemInfo.supportsImageEffects || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.JEAOMBOAPEC = true;
				base.enabled = true;
				return;
			}
			this.NELHMAMLGGN();
			if (!this.LNGELFODMDB || this.LNGELFODMDB.passCount != 1)
			{
				this.JEAOMBOAPEC = true;
				base.enabled = true;
				return;
			}
			this.JEAOMBOAPEC = false;
		}

		// Token: 0x0600BB02 RID: 47874 RVA: 0x0053A9B6 File Offset: 0x00538BB6
		private static Material DHPLKOCDGJE(Shader BAKBIMBKKNP)
		{
			if (!BAKBIMBKKNP)
			{
				return null;
			}
			return new Material(BAKBIMBKKNP)
			{
				hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild)
			};
		}

		// Token: 0x0600BB03 RID: 47875 RVA: 0x0053A9D0 File Offset: 0x00538BD0
		private static Material NKCOFMAGCMP(Shader BAKBIMBKKNP)
		{
			if (!BAKBIMBKKNP)
			{
				return null;
			}
			return new Material(BAKBIMBKKNP)
			{
				hideFlags = (HideFlags)85
			};
		}

		// Token: 0x0600BB04 RID: 47876 RVA: 0x0053A425 File Offset: 0x00538625
		private static void FJIJOGIDNJJ(Material LCBKJGFGGGF)
		{
			if (LCBKJGFGGGF)
			{
				UnityEngine.Object.DestroyImmediate(LCBKJGFGGGF);
				LCBKJGFGGGF = null;
			}
		}

		// Token: 0x0600BB05 RID: 47877 RVA: 0x0053A9EA File Offset: 0x00538BEA
		private void BGKOJIDABKB()
		{
			base.GetComponent<Camera>().depthTextureMode |= (DepthTextureMode.Depth | DepthTextureMode.MotionVectors);
		}

		// Token: 0x0600BB06 RID: 47878 RVA: 0x0053AA00 File Offset: 0x00538C00
		private void BKIDKCDBFJC()
		{
			if (!this.LNGELFODMDB && this.m_SSAOShader.isSupported)
			{
				this.LNGELFODMDB = ScreenSpaceAmbientOcclusion.LLBDDEAODMJ(this.m_SSAOShader);
				this.LNGELFODMDB.SetTexture("SoccerKeeperReady", this.m_RandomTexture);
			}
		}

		// Token: 0x0600BB07 RID: 47879 RVA: 0x0053AA50 File Offset: 0x00538C50
		private void ONIHHFLOJMN()
		{
			if (!SystemInfo.supportsImageEffects || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.JEAOMBOAPEC = false;
				base.enabled = true;
				return;
			}
			this.PFJBHOPNOPP();
			if (!this.LNGELFODMDB || this.LNGELFODMDB.passCount != 1)
			{
				this.JEAOMBOAPEC = true;
				base.enabled = true;
				return;
			}
			this.JEAOMBOAPEC = true;
		}

		// Token: 0x0600BB08 RID: 47880 RVA: 0x0053AAB4 File Offset: 0x00538CB4
		private void ELADFDNPOOI()
		{
			if (!SystemInfo.supportsImageEffects || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.JEAOMBOAPEC = false;
				base.enabled = true;
				return;
			}
			this.BKIDKCDBFJC();
			if (!this.LNGELFODMDB || this.LNGELFODMDB.passCount != 6)
			{
				this.JEAOMBOAPEC = false;
				base.enabled = false;
				return;
			}
			this.JEAOMBOAPEC = false;
		}

		// Token: 0x0600BB09 RID: 47881 RVA: 0x0053AB18 File Offset: 0x00538D18
		private void NCEFKCHPKFF()
		{
			if (!this.LNGELFODMDB && this.m_SSAOShader.isSupported)
			{
				this.LNGELFODMDB = ScreenSpaceAmbientOcclusion.DHPLKOCDGJE(this.m_SSAOShader);
				this.LNGELFODMDB.SetTexture("qd_prise_rep", this.m_RandomTexture);
			}
		}

		// Token: 0x0600BB0A RID: 47882 RVA: 0x0053AB68 File Offset: 0x00538D68
		private void INKNBKJLICN()
		{
			if (!this.LNGELFODMDB && this.m_SSAOShader.isSupported)
			{
				this.LNGELFODMDB = ScreenSpaceAmbientOcclusion.FBCIOGMBCKA(this.m_SSAOShader);
				this.LNGELFODMDB.SetTexture("Middle click", this.m_RandomTexture);
			}
		}

		// Token: 0x0600BB0B RID: 47883 RVA: 0x0053ABB6 File Offset: 0x00538DB6
		private static Material BCMHFDEDBBA(Shader BAKBIMBKKNP)
		{
			if (!BAKBIMBKKNP)
			{
				return null;
			}
			return new Material(BAKBIMBKKNP)
			{
				hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset)
			};
		}

		// Token: 0x0600BB0C RID: 47884 RVA: 0x0053A425 File Offset: 0x00538625
		private static void IJIGNPDNAMD(Material LCBKJGFGGGF)
		{
			if (LCBKJGFGGGF)
			{
				UnityEngine.Object.DestroyImmediate(LCBKJGFGGGF);
				LCBKJGFGGGF = null;
			}
		}

		// Token: 0x0600BB0E RID: 47886 RVA: 0x0053AC24 File Offset: 0x00538E24
		private void KDOIOPJDJPL()
		{
			base.GetComponent<Camera>().depthTextureMode |= (DepthTextureMode.Depth | DepthTextureMode.DepthNormals | DepthTextureMode.MotionVectors);
		}

		// Token: 0x0600BB0F RID: 47887 RVA: 0x0053AC39 File Offset: 0x00538E39
		private void PIMGCFGNCJH()
		{
			base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.MotionVectors;
		}

		// Token: 0x0600BB10 RID: 47888 RVA: 0x0053AC50 File Offset: 0x00538E50
		private void FNMFECJCGBP()
		{
			if (!this.LNGELFODMDB && this.m_SSAOShader.isSupported)
			{
				this.LNGELFODMDB = ScreenSpaceAmbientOcclusion.PHNMLJJBKDC(this.m_SSAOShader);
				this.LNGELFODMDB.SetTexture("_RandomTexture", this.m_RandomTexture);
			}
		}

		// Token: 0x0600BB11 RID: 47889 RVA: 0x0053AC9E File Offset: 0x00538E9E
		private void ONPDNGNNBIG()
		{
			ScreenSpaceAmbientOcclusion.ILHLBHLEBAP(this.LNGELFODMDB);
		}

		// Token: 0x0600BB12 RID: 47890 RVA: 0x0053ACAB File Offset: 0x00538EAB
		private static Material CEDEGDCCPOJ(Shader BAKBIMBKKNP)
		{
			if (!BAKBIMBKKNP)
			{
				return null;
			}
			return new Material(BAKBIMBKKNP)
			{
				hideFlags = (HideFlags)111
			};
		}

		// Token: 0x0600BB13 RID: 47891 RVA: 0x0053A425 File Offset: 0x00538625
		private static void HPDJHJGDCBF(Material LCBKJGFGGGF)
		{
			if (LCBKJGFGGGF)
			{
				UnityEngine.Object.DestroyImmediate(LCBKJGFGGGF);
				LCBKJGFGGGF = null;
			}
		}

		// Token: 0x0600BB14 RID: 47892 RVA: 0x0053ACC8 File Offset: 0x00538EC8
		private void JPCPEPMDLAN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.JEAOMBOAPEC || !this.m_SSAOShader.isSupported)
			{
				base.enabled = false;
				return;
			}
			this.NELHMAMLGGN();
			this.m_Downsampling = Mathf.Clamp(this.m_Downsampling, 0, 4);
			this.m_Radius = Mathf.Clamp(this.m_Radius, 1931f, 563f);
			this.m_MinZ = Mathf.Clamp(this.m_MinZ, 322f, 839f);
			this.m_OcclusionIntensity = Mathf.Clamp(this.m_OcclusionIntensity, 661f, 336f);
			this.m_OcclusionAttenuation = Mathf.Clamp(this.m_OcclusionAttenuation, 729f, 225f);
			this.m_Blur = Mathf.Clamp(this.m_Blur, 0, 5);
			RenderTexture renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width / this.m_Downsampling, JONJODLFAEN.height / this.m_Downsampling, 1);
			float fieldOfView = base.GetComponent<Camera>().fieldOfView;
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			float num = Mathf.Tan(fieldOfView * 493f * 1723f) * farClipPlane;
			float x = num * base.GetComponent<Camera>().aspect;
			this.LNGELFODMDB.SetVector("IdleMouthWipe", new Vector3(x, num, farClipPlane));
			int num2;
			int num3;
			if (this.m_RandomTexture)
			{
				num2 = this.m_RandomTexture.width;
				num3 = this.m_RandomTexture.height;
			}
			else
			{
				num2 = 1;
				num3 = 0;
			}
			this.LNGELFODMDB.SetVector("crft_from", new Vector3((float)renderTexture.width / (float)num2, (float)renderTexture.height / (float)num3, 1898f));
			this.LNGELFODMDB.SetVector("_SSAOTex", new Vector4(this.m_Radius, this.m_MinZ, 1344f / this.m_OcclusionAttenuation, this.m_OcclusionIntensity));
			bool flag = this.m_Blur > 0;
			Graphics.Blit(flag ? null : JONJODLFAEN, renderTexture, this.LNGELFODMDB, (int)this.m_SampleCount);
			if (flag)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0);
				this.LNGELFODMDB.SetVector("crft_sbor", new Vector4((float)this.m_Blur / (float)JONJODLFAEN.width, 90f, 541f, 1370f));
				this.LNGELFODMDB.SetTexture("SneakRight", renderTexture);
				Graphics.Blit(null, temporary, this.LNGELFODMDB, 0);
				RenderTexture.ReleaseTemporary(renderTexture);
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 1);
				this.LNGELFODMDB.SetVector("ShootRaycastModule", new Vector4(1353f, (float)this.m_Blur / (float)JONJODLFAEN.height, 537f, 1221f));
				this.LNGELFODMDB.SetTexture("[ACTk] Injection Detector: already running!", temporary);
				Graphics.Blit(JONJODLFAEN, temporary2, this.LNGELFODMDB, 2);
				RenderTexture.ReleaseTemporary(temporary);
				renderTexture = temporary2;
			}
			this.LNGELFODMDB.SetTexture("RollerBladeSkateFwd", renderTexture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LNGELFODMDB, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600BB15 RID: 47893 RVA: 0x0053AFC3 File Offset: 0x005391C3
		private void INEHANLJIEM()
		{
			base.GetComponent<Camera>().depthTextureMode |= (DepthTextureMode.Depth | DepthTextureMode.DepthNormals);
		}

		// Token: 0x0600BB16 RID: 47894 RVA: 0x0053A425 File Offset: 0x00538625
		private static void NGKCAEBNHKP(Material LCBKJGFGGGF)
		{
			if (LCBKJGFGGGF)
			{
				UnityEngine.Object.DestroyImmediate(LCBKJGFGGGF);
				LCBKJGFGGGF = null;
			}
		}

		// Token: 0x0600BB17 RID: 47895 RVA: 0x0053AFD8 File Offset: 0x005391D8
		private void HNGLBEOAIHN()
		{
			base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
		}

		// Token: 0x0600BB18 RID: 47896 RVA: 0x0053AC24 File Offset: 0x00538E24
		private void HHOJJINMMMA()
		{
			base.GetComponent<Camera>().depthTextureMode |= (DepthTextureMode.Depth | DepthTextureMode.DepthNormals | DepthTextureMode.MotionVectors);
		}

		// Token: 0x0600BB19 RID: 47897 RVA: 0x0053A425 File Offset: 0x00538625
		private static void OEOEHGBDIGE(Material LCBKJGFGGGF)
		{
			if (LCBKJGFGGGF)
			{
				UnityEngine.Object.DestroyImmediate(LCBKJGFGGGF);
				LCBKJGFGGGF = null;
			}
		}

		// Token: 0x0600BB1A RID: 47898 RVA: 0x0053AFF0 File Offset: 0x005391F0
		private void GDGPNFLCNEG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.JEAOMBOAPEC || !this.m_SSAOShader.isSupported)
			{
				base.enabled = true;
				return;
			}
			this.GHKDLFMFKOG();
			this.m_Downsampling = Mathf.Clamp(this.m_Downsampling, 1, 1);
			this.m_Radius = Mathf.Clamp(this.m_Radius, 1077f, 36f);
			this.m_MinZ = Mathf.Clamp(this.m_MinZ, 986f, 721f);
			this.m_OcclusionIntensity = Mathf.Clamp(this.m_OcclusionIntensity, 1732f, 70f);
			this.m_OcclusionAttenuation = Mathf.Clamp(this.m_OcclusionAttenuation, 429f, 280f);
			this.m_Blur = Mathf.Clamp(this.m_Blur, 1, 6);
			RenderTexture renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width / this.m_Downsampling, JONJODLFAEN.height / this.m_Downsampling, 0);
			float fieldOfView = base.GetComponent<Camera>().fieldOfView;
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			float num = Mathf.Tan(fieldOfView * 578f * 456f) * farClipPlane;
			float x = num * base.GetComponent<Camera>().aspect;
			this.LNGELFODMDB.SetVector("Mouse X", new Vector3(x, num, farClipPlane));
			int num2;
			int num3;
			if (this.m_RandomTexture)
			{
				num2 = this.m_RandomTexture.width;
				num3 = this.m_RandomTexture.height;
			}
			else
			{
				num2 = 0;
				num3 = 0;
			}
			this.LNGELFODMDB.SetVector("leskaProc", new Vector3((float)renderTexture.width / (float)num2, (float)renderTexture.height / (float)num3, 1124f));
			this.LNGELFODMDB.SetVector("UnityEngine.Vector4", new Vector4(this.m_Radius, this.m_MinZ, 1298f / this.m_OcclusionAttenuation, this.m_OcclusionIntensity));
			bool flag = this.m_Blur > 1;
			Graphics.Blit(flag ? null : JONJODLFAEN, renderTexture, this.LNGELFODMDB, (int)this.m_SampleCount);
			if (flag)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0);
				this.LNGELFODMDB.SetVector("Idle Monster", new Vector4((float)this.m_Blur / (float)JONJODLFAEN.width, 423f, 398f, 893f));
				this.LNGELFODMDB.SetTexture("[curcnt]", renderTexture);
				Graphics.Blit(null, temporary, this.LNGELFODMDB, 0);
				RenderTexture.ReleaseTemporary(renderTexture);
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 1);
				this.LNGELFODMDB.SetVector("", new Vector4(679f, (float)this.m_Blur / (float)JONJODLFAEN.height, 1124f, 795f));
				this.LNGELFODMDB.SetTexture(" ms", temporary);
				Graphics.Blit(JONJODLFAEN, temporary2, this.LNGELFODMDB, 4);
				RenderTexture.ReleaseTemporary(temporary);
				renderTexture = temporary2;
			}
			this.LNGELFODMDB.SetTexture("Cowboy1HandDraw", renderTexture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LNGELFODMDB, 4);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600BB1B RID: 47899 RVA: 0x0053B2EB File Offset: 0x005394EB
		private static Material HJHHIFAEEGL(Shader BAKBIMBKKNP)
		{
			if (!BAKBIMBKKNP)
			{
				return null;
			}
			return new Material(BAKBIMBKKNP)
			{
				hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset)
			};
		}

		// Token: 0x0600BB1C RID: 47900 RVA: 0x0053A425 File Offset: 0x00538625
		private static void ILHLBHLEBAP(Material LCBKJGFGGGF)
		{
			if (LCBKJGFGGGF)
			{
				UnityEngine.Object.DestroyImmediate(LCBKJGFGGGF);
				LCBKJGFGGGF = null;
			}
		}

		// Token: 0x0600BB1D RID: 47901 RVA: 0x0053B308 File Offset: 0x00539508
		private void GHKDLFMFKOG()
		{
			if (!this.LNGELFODMDB && this.m_SSAOShader.isSupported)
			{
				this.LNGELFODMDB = ScreenSpaceAmbientOcclusion.OJCCNCIGKCG(this.m_SSAOShader);
				this.LNGELFODMDB.SetTexture("int\nfloat\nstring\n<color=\"#75C4EB\">uint\ndouble\ndecimal\nlong\nulong\nbool\nbyte[]\nVector2\nVector3\nQuaternion\nColor\nRect</color>", this.m_RandomTexture);
			}
		}

		// Token: 0x0600BB1E RID: 47902 RVA: 0x0053B356 File Offset: 0x00539556
		private void PEPOOEGHCMC()
		{
			ScreenSpaceAmbientOcclusion.IJIGNPDNAMD(this.LNGELFODMDB);
		}

		// Token: 0x0600BB1F RID: 47903 RVA: 0x0053A425 File Offset: 0x00538625
		private static void GLDAEGOANDB(Material LCBKJGFGGGF)
		{
			if (LCBKJGFGGGF)
			{
				UnityEngine.Object.DestroyImmediate(LCBKJGFGGGF);
				LCBKJGFGGGF = null;
			}
		}

		// Token: 0x0600BB20 RID: 47904 RVA: 0x0053B363 File Offset: 0x00539563
		private void FLFFEJFEPHF()
		{
			ScreenSpaceAmbientOcclusion.FJIJOGIDNJJ(this.LNGELFODMDB);
		}

		// Token: 0x0600BB21 RID: 47905 RVA: 0x0053B370 File Offset: 0x00539570
		private static Material NNMKIOCFCAF(Shader BAKBIMBKKNP)
		{
			if (!BAKBIMBKKNP)
			{
				return null;
			}
			return new Material(BAKBIMBKKNP)
			{
				hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset)
			};
		}

		// Token: 0x0600BB22 RID: 47906 RVA: 0x0053B38C File Offset: 0x0053958C
		private void IBILMNLCCJJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.JEAOMBOAPEC || !this.m_SSAOShader.isSupported)
			{
				base.enabled = false;
				return;
			}
			this.PFJBHOPNOPP();
			this.m_Downsampling = Mathf.Clamp(this.m_Downsampling, 1, 5);
			this.m_Radius = Mathf.Clamp(this.m_Radius, 930f, 652f);
			this.m_MinZ = Mathf.Clamp(this.m_MinZ, 581f, 1324f);
			this.m_OcclusionIntensity = Mathf.Clamp(this.m_OcclusionIntensity, 656f, 63f);
			this.m_OcclusionAttenuation = Mathf.Clamp(this.m_OcclusionAttenuation, 1263f, 168f);
			this.m_Blur = Mathf.Clamp(this.m_Blur, 0, 8);
			RenderTexture renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width / this.m_Downsampling, JONJODLFAEN.height / this.m_Downsampling, 0);
			float fieldOfView = base.GetComponent<Camera>().fieldOfView;
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			float num = Mathf.Tan(fieldOfView * 1066f * 38f) * farClipPlane;
			float x = num * base.GetComponent<Camera>().aspect;
			this.LNGELFODMDB.SetVector("shop_ycnt", new Vector3(x, num, farClipPlane));
			int num2;
			int num3;
			if (this.m_RandomTexture)
			{
				num2 = this.m_RandomTexture.width;
				num3 = this.m_RandomTexture.height;
			}
			else
			{
				num2 = 1;
				num3 = 0;
			}
			this.LNGELFODMDB.SetVector("run", new Vector3((float)renderTexture.width / (float)num2, (float)renderTexture.height / (float)num3, 1679f));
			this.LNGELFODMDB.SetVector("_Radius", new Vector4(this.m_Radius, this.m_MinZ, 573f / this.m_OcclusionAttenuation, this.m_OcclusionIntensity));
			bool flag = this.m_Blur > 0;
			Graphics.Blit(flag ? null : JONJODLFAEN, renderTexture, this.LNGELFODMDB, (int)this.m_SampleCount);
			if (flag)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0);
				this.LNGELFODMDB.SetVector("ZombieIdle", new Vector4((float)this.m_Blur / (float)JONJODLFAEN.width, 1967f, 413f, 13f));
				this.LNGELFODMDB.SetTexture("[maxweight]", renderTexture);
				Graphics.Blit(null, temporary, this.LNGELFODMDB, 0);
				RenderTexture.ReleaseTemporary(renderTexture);
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0);
				this.LNGELFODMDB.SetVector("", new Vector4(427f, (float)this.m_Blur / (float)JONJODLFAEN.height, 436f, 961f));
				this.LNGELFODMDB.SetTexture("_SmallTex", temporary);
				Graphics.Blit(JONJODLFAEN, temporary2, this.LNGELFODMDB, 3);
				RenderTexture.ReleaseTemporary(temporary);
				renderTexture = temporary2;
			}
			this.LNGELFODMDB.SetTexture("", renderTexture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LNGELFODMDB, 2);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600BB23 RID: 47907 RVA: 0x0053B687 File Offset: 0x00539887
		private static Material AMANNCHOCJK(Shader BAKBIMBKKNP)
		{
			if (!BAKBIMBKKNP)
			{
				return null;
			}
			return new Material(BAKBIMBKKNP)
			{
				hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable)
			};
		}

		// Token: 0x0600BB24 RID: 47908 RVA: 0x0053B6A1 File Offset: 0x005398A1
		private static Material LLBDDEAODMJ(Shader BAKBIMBKKNP)
		{
			if (!BAKBIMBKKNP)
			{
				return null;
			}
			return new Material(BAKBIMBKKNP)
			{
				hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset)
			};
		}

		// Token: 0x0600BB25 RID: 47909 RVA: 0x0053B6BC File Offset: 0x005398BC
		private void HGBMMLPBFAL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.JEAOMBOAPEC || !this.m_SSAOShader.isSupported)
			{
				base.enabled = true;
				return;
			}
			this.NELHMAMLGGN();
			this.m_Downsampling = Mathf.Clamp(this.m_Downsampling, 1, 8);
			this.m_Radius = Mathf.Clamp(this.m_Radius, 87f, 1153f);
			this.m_MinZ = Mathf.Clamp(this.m_MinZ, 1661f, 1150f);
			this.m_OcclusionIntensity = Mathf.Clamp(this.m_OcclusionIntensity, 460f, 242f);
			this.m_OcclusionAttenuation = Mathf.Clamp(this.m_OcclusionAttenuation, 1926f, 1902f);
			this.m_Blur = Mathf.Clamp(this.m_Blur, 1, 5);
			RenderTexture renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width / this.m_Downsampling, JONJODLFAEN.height / this.m_Downsampling, 1);
			float fieldOfView = base.GetComponent<Camera>().fieldOfView;
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			float num = Mathf.Tan(fieldOfView * 682f * 1056f) * farClipPlane;
			float x = num * base.GetComponent<Camera>().aspect;
			this.LNGELFODMDB.SetVector("**** Weather cloudly={0} fog={1} rain={2} snaige={3} grom={4}", new Vector3(x, num, farClipPlane));
			int num2;
			int num3;
			if (this.m_RandomTexture)
			{
				num2 = this.m_RandomTexture.width;
				num3 = this.m_RandomTexture.height;
			}
			else
			{
				num2 = 0;
				num3 = 1;
			}
			this.LNGELFODMDB.SetVector("_DebugWidth", new Vector3((float)renderTexture.width / (float)num2, (float)renderTexture.height / (float)num3, 1479f));
			this.LNGELFODMDB.SetVector("No fish in fishModelData modelid=", new Vector4(this.m_Radius, this.m_MinZ, 1823f / this.m_OcclusionAttenuation, this.m_OcclusionIntensity));
			bool flag = this.m_Blur > 1;
			Graphics.Blit(flag ? null : JONJODLFAEN, renderTexture, this.LNGELFODMDB, (int)this.m_SampleCount);
			if (flag)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 1);
				this.LNGELFODMDB.SetVector("The 'hyperlink' command requires an hyperlink id parameter.", new Vector4((float)this.m_Blur / (float)JONJODLFAEN.width, 113f, 1269f, 146f));
				this.LNGELFODMDB.SetTexture("WandStand", renderTexture);
				Graphics.Blit(null, temporary, this.LNGELFODMDB, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 1);
				this.LNGELFODMDB.SetVector("Sitting Reading", new Vector4(20f, (float)this.m_Blur / (float)JONJODLFAEN.height, 1277f, 586f));
				this.LNGELFODMDB.SetTexture("RunBackward", temporary);
				Graphics.Blit(JONJODLFAEN, temporary2, this.LNGELFODMDB, 4);
				RenderTexture.ReleaseTemporary(temporary);
				renderTexture = temporary2;
			}
			this.LNGELFODMDB.SetTexture("800000", renderTexture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LNGELFODMDB, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600BB26 RID: 47910 RVA: 0x0053B9B8 File Offset: 0x00539BB8
		private void EGOKABFLKGC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.JEAOMBOAPEC || !this.m_SSAOShader.isSupported)
			{
				base.enabled = true;
				return;
			}
			this.INKNBKJLICN();
			this.m_Downsampling = Mathf.Clamp(this.m_Downsampling, 0, 4);
			this.m_Radius = Mathf.Clamp(this.m_Radius, 1164f, 1294f);
			this.m_MinZ = Mathf.Clamp(this.m_MinZ, 570f, 462f);
			this.m_OcclusionIntensity = Mathf.Clamp(this.m_OcclusionIntensity, 296f, 1732f);
			this.m_OcclusionAttenuation = Mathf.Clamp(this.m_OcclusionAttenuation, 832f, 333f);
			this.m_Blur = Mathf.Clamp(this.m_Blur, 0, 7);
			RenderTexture renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width / this.m_Downsampling, JONJODLFAEN.height / this.m_Downsampling, 1);
			float fieldOfView = base.GetComponent<Camera>().fieldOfView;
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			float num = Mathf.Tan(fieldOfView * 1038f * 1395f) * farClipPlane;
			float x = num * base.GetComponent<Camera>().aspect;
			this.LNGELFODMDB.SetVector("intensity", new Vector3(x, num, farClipPlane));
			int num2;
			int num3;
			if (this.m_RandomTexture)
			{
				num2 = this.m_RandomTexture.width;
				num3 = this.m_RandomTexture.height;
			}
			else
			{
				num2 = 0;
				num3 = 0;
			}
			this.LNGELFODMDB.SetVector("PistolInstant", new Vector3((float)renderTexture.width / (float)num2, (float)renderTexture.height / (float)num3, 1289f));
			this.LNGELFODMDB.SetVector("<color='#ff80ff'>", new Vector4(this.m_Radius, this.m_MinZ, 907f / this.m_OcclusionAttenuation, this.m_OcclusionIntensity));
			bool flag = this.m_Blur > 1;
			Graphics.Blit(flag ? null : JONJODLFAEN, renderTexture, this.LNGELFODMDB, (int)this.m_SampleCount);
			if (flag)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 1);
				this.LNGELFODMDB.SetVector(" x", new Vector4((float)this.m_Blur / (float)JONJODLFAEN.width, 1901f, 783f, 676f));
				this.LNGELFODMDB.SetTexture("", renderTexture);
				Graphics.Blit(null, temporary, this.LNGELFODMDB, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 1);
				this.LNGELFODMDB.SetVector("1 Hand Sword Jab ready strafe left", new Vector4(1598f, (float)this.m_Blur / (float)JONJODLFAEN.height, 1102f, 1025f));
				this.LNGELFODMDB.SetTexture("_Refraction", temporary);
				Graphics.Blit(JONJODLFAEN, temporary2, this.LNGELFODMDB, 6);
				RenderTexture.ReleaseTemporary(temporary);
				renderTexture = temporary2;
			}
			this.LNGELFODMDB.SetTexture("BlackSmithHammer", renderTexture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LNGELFODMDB, 4);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600BB27 RID: 47911 RVA: 0x0053BCB3 File Offset: 0x00539EB3
		private void GBAEKFJBEFM()
		{
			ScreenSpaceAmbientOcclusion.FMNPNCNOEJM(this.LNGELFODMDB);
		}

		// Token: 0x0600BB28 RID: 47912 RVA: 0x0053A425 File Offset: 0x00538625
		private static void EHAABCDAJFG(Material LCBKJGFGGGF)
		{
			if (LCBKJGFGGGF)
			{
				UnityEngine.Object.DestroyImmediate(LCBKJGFGGGF);
				LCBKJGFGGGF = null;
			}
		}

		// Token: 0x0600BB29 RID: 47913 RVA: 0x0053BCC0 File Offset: 0x00539EC0
		private void EDCBFNNHICN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.JEAOMBOAPEC || !this.m_SSAOShader.isSupported)
			{
				base.enabled = true;
				return;
			}
			this.BKIDKCDBFJC();
			this.m_Downsampling = Mathf.Clamp(this.m_Downsampling, 0, 8);
			this.m_Radius = Mathf.Clamp(this.m_Radius, 1256f, 1579f);
			this.m_MinZ = Mathf.Clamp(this.m_MinZ, 912f, 1137f);
			this.m_OcclusionIntensity = Mathf.Clamp(this.m_OcclusionIntensity, 450f, 1970f);
			this.m_OcclusionAttenuation = Mathf.Clamp(this.m_OcclusionAttenuation, 668f, 721f);
			this.m_Blur = Mathf.Clamp(this.m_Blur, 1, 4);
			RenderTexture renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width / this.m_Downsampling, JONJODLFAEN.height / this.m_Downsampling, 1);
			float fieldOfView = base.GetComponent<Camera>().fieldOfView;
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			float num = Mathf.Tan(fieldOfView * 301f * 128f) * farClipPlane;
			float x = num * base.GetComponent<Camera>().aspect;
			this.LNGELFODMDB.SetVector("RollerBladeRoll", new Vector3(x, num, farClipPlane));
			int num2;
			int num3;
			if (this.m_RandomTexture)
			{
				num2 = this.m_RandomTexture.width;
				num3 = this.m_RandomTexture.height;
			}
			else
			{
				num2 = 0;
				num3 = 0;
			}
			this.LNGELFODMDB.SetVector("Current fog preset: ", new Vector3((float)renderTexture.width / (float)num2, (float)renderTexture.height / (float)num3, 1666f));
			this.LNGELFODMDB.SetVector("StrafeRunLeft", new Vector4(this.m_Radius, this.m_MinZ, 977f / this.m_OcclusionAttenuation, this.m_OcclusionIntensity));
			bool flag = this.m_Blur > 1;
			Graphics.Blit(flag ? null : JONJODLFAEN, renderTexture, this.LNGELFODMDB, (int)this.m_SampleCount);
			if (flag)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 1);
				this.LNGELFODMDB.SetVector("IdleMeditate", new Vector4((float)this.m_Blur / (float)JONJODLFAEN.width, 896f, 1096f, 458f));
				this.LNGELFODMDB.SetTexture("http://j.mp/1iBK5pz", renderTexture);
				Graphics.Blit(null, temporary, this.LNGELFODMDB, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0);
				this.LNGELFODMDB.SetVector("SneakBackward", new Vector4(401f, (float)this.m_Blur / (float)JONJODLFAEN.height, 1957f, 876f));
				this.LNGELFODMDB.SetTexture("SixStep", temporary);
				Graphics.Blit(JONJODLFAEN, temporary2, this.LNGELFODMDB, 0);
				RenderTexture.ReleaseTemporary(temporary);
				renderTexture = temporary2;
			}
			this.LNGELFODMDB.SetTexture("Jump", renderTexture);
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LNGELFODMDB, 6);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600BB2A RID: 47914 RVA: 0x0053BFBC File Offset: 0x0053A1BC
		private void NELHMAMLGGN()
		{
			if (!this.LNGELFODMDB && this.m_SSAOShader.isSupported)
			{
				this.LNGELFODMDB = ScreenSpaceAmbientOcclusion.NNMKIOCFCAF(this.m_SSAOShader);
				this.LNGELFODMDB.SetTexture("INTERFACE", this.m_RandomTexture);
			}
		}

		// Token: 0x0600BB2B RID: 47915 RVA: 0x0053C00C File Offset: 0x0053A20C
		private void PFJBHOPNOPP()
		{
			if (!this.LNGELFODMDB && this.m_SSAOShader.isSupported)
			{
				this.LNGELFODMDB = ScreenSpaceAmbientOcclusion.HJHHIFAEEGL(this.m_SSAOShader);
				this.LNGELFODMDB.SetTexture("_UserLutParams", this.m_RandomTexture);
			}
		}

		// Token: 0x0600BB2C RID: 47916 RVA: 0x0053C05C File Offset: 0x0053A25C
		private void NFOFBAPIJPI()
		{
			if (!this.LNGELFODMDB && this.m_SSAOShader.isSupported)
			{
				this.LNGELFODMDB = ScreenSpaceAmbientOcclusion.OJCCNCIGKCG(this.m_SSAOShader);
				this.LNGELFODMDB.SetTexture("Show History (messages : {0})", this.m_RandomTexture);
			}
		}

		// Token: 0x04001849 RID: 6217
		[Range(0.05f, 1f)]
		public float m_Radius = 0.4f;

		// Token: 0x0400184A RID: 6218
		public ScreenSpaceAmbientOcclusion.GIJMMPKNHIM m_SampleCount = ScreenSpaceAmbientOcclusion.GIJMMPKNHIM.Medium;

		// Token: 0x0400184B RID: 6219
		[Range(0.5f, 4f)]
		public float m_OcclusionIntensity = 1.5f;

		// Token: 0x0400184C RID: 6220
		[Range(0f, 4f)]
		public int m_Blur = 2;

		// Token: 0x0400184D RID: 6221
		[Range(1f, 6f)]
		public int m_Downsampling = 2;

		// Token: 0x0400184E RID: 6222
		[Range(0.2f, 2f)]
		public float m_OcclusionAttenuation = 1f;

		// Token: 0x0400184F RID: 6223
		[Range(1E-05f, 0.5f)]
		public float m_MinZ = 0.01f;

		// Token: 0x04001850 RID: 6224
		public Shader m_SSAOShader;

		// Token: 0x04001851 RID: 6225
		private Material LNGELFODMDB;

		// Token: 0x04001852 RID: 6226
		public Texture2D m_RandomTexture;

		// Token: 0x04001853 RID: 6227
		private bool JEAOMBOAPEC;

		// Token: 0x02000330 RID: 816
		public enum GIJMMPKNHIM
		{
			// Token: 0x04001855 RID: 6229
			Low,
			// Token: 0x04001856 RID: 6230
			Medium,
			// Token: 0x04001857 RID: 6231
			High
		}
	}
}
