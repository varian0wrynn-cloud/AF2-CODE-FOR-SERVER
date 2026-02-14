using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000329 RID: 809
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class PostEffectsBase : MonoBehaviour
	{
		// Token: 0x0600B937 RID: 47415 RVA: 0x00528CB7 File Offset: 0x00526EB7
		protected bool JOIHDKCDHAJ()
		{
			return this.EHGENDOEHLP(true);
		}

		// Token: 0x0600B938 RID: 47416 RVA: 0x00528CC0 File Offset: 0x00526EC0
		private bool KLKEBKKOHPI(Shader EEOOKGDHNCO)
		{
			string[] array = new string[2];
			array[0] = "L";
			array[0] = EEOOKGDHNCO.ToString();
			array[2] = "0";
			array[1] = this.ToString();
			array[3] = "OfficeSitting1LegStraight";
			Debug.Log(string.Concat(array));
			if (!EEOOKGDHNCO.isSupported)
			{
				this.OCGNIJDNOOM();
				return true;
			}
			return false;
		}

		// Token: 0x0600B939 RID: 47417 RVA: 0x0009CFFC File Offset: 0x0009B1FC
		protected void JIPLGAPGCFN()
		{
			Debug.LogWarning("The image effect " + this.ToString() + " has been disabled as it's not supported on the current platform.");
		}

		// Token: 0x0600B93A RID: 47418 RVA: 0x00528D18 File Offset: 0x00526F18
		private void BJECBEPLAKB()
		{
			while (this.IJKNIFOPIKN.Count > 0)
			{
				UnityEngine.Object obj = this.IJKNIFOPIKN[0];
				this.IJKNIFOPIKN.RemoveAt(0);
				UnityEngine.Object.Destroy(obj);
			}
		}

		// Token: 0x0600B93C RID: 47420 RVA: 0x00528D68 File Offset: 0x00526F68
		protected bool NDKLAKBBFKE()
		{
			return this.OAAFLHNDKBJ(true);
		}

		// Token: 0x0600B93D RID: 47421 RVA: 0x00528D71 File Offset: 0x00526F71
		protected void NAIBIABADFB()
		{
			Debug.LogWarning("_SSAO" + this.ToString() + "_SelectColor");
		}

		// Token: 0x0600B93E RID: 47422 RVA: 0x00528D8D File Offset: 0x00526F8D
		private void OCIANPBJNND()
		{
			this.PPGOAMIHMBG = true;
		}

		// Token: 0x0600B93F RID: 47423 RVA: 0x00528D96 File Offset: 0x00526F96
		private void DOEMHIKKCKB()
		{
			this.LNJAKHAHCKL();
		}

		// Token: 0x0600B940 RID: 47424 RVA: 0x00528D9E File Offset: 0x00526F9E
		private void EBAJDGLIAPE()
		{
			this.PPGOAMIHMBG = false;
		}

		// Token: 0x0600B941 RID: 47425 RVA: 0x00528DA7 File Offset: 0x00526FA7
		public virtual bool MNDOFMMGLMO()
		{
			Debug.LogWarning("_SceneFogMode" + this.ToString() + "qd_prise_exp");
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B942 RID: 47426 RVA: 0x00528DCC File Offset: 0x00526FCC
		protected bool AHFDGALLKFC(bool AEAEPFBMGOM)
		{
			this.PPGOAMIHMBG = false;
			this.KKGBEAPGBOD = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.RGB565);
			this.PKDDLGKEIBG = (SystemInfo.graphicsShaderLevel < -125 || SystemInfo.supportsComputeShaders);
			if (!SystemInfo.supportsImageEffects)
			{
				this.OCGNIJDNOOM();
				return true;
			}
			if (AEAEPFBMGOM && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.OCGNIJDNOOM();
				return false;
			}
			if (AEAEPFBMGOM)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			return false;
		}

		// Token: 0x0600B943 RID: 47427 RVA: 0x00528E3C File Offset: 0x0052703C
		protected bool OPBIPMGFGHK(bool AEAEPFBMGOM, bool PEIGGOMHOFH)
		{
			if (!this.BGIALJEIEFO(AEAEPFBMGOM))
			{
				return false;
			}
			if (PEIGGOMHOFH && !this.KKGBEAPGBOD)
			{
				this.AGGGAHEKKCO();
				return false;
			}
			return true;
		}

		// Token: 0x0600B944 RID: 47428 RVA: 0x00528E5D File Offset: 0x0052705D
		public bool MCOJHEKNNHK()
		{
			return this.PKDDLGKEIBG;
		}

		// Token: 0x0600B945 RID: 47429 RVA: 0x00528E65 File Offset: 0x00527065
		private void LGDKFMHPCBM()
		{
			while (this.IJKNIFOPIKN.Count > 1)
			{
				UnityEngine.Object obj = this.IJKNIFOPIKN[0];
				this.IJKNIFOPIKN.RemoveAt(1);
				UnityEngine.Object.Destroy(obj);
			}
		}

		// Token: 0x0600B946 RID: 47430 RVA: 0x00528E94 File Offset: 0x00527094
		protected void DLAECNCPLML(RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ)
		{
			RenderTexture.active = OLFKAHHACBC;
			bool flag = false;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < MHNAJNGGDFJ.passCount; i += 0)
			{
				MHNAJNGGDFJ.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 1582f;
					y2 = 1682f;
				}
				else
				{
					y = 190f;
					y2 = 400f;
				}
				float x = 1064f;
				float x2 = 1411f + 5f / ((float)OLFKAHHACBC.width * 1333f);
				float y3 = 508f;
				float y4 = 738f;
				GL.Begin(3);
				GL.TexCoord2(1269f, y);
				GL.Vertex3(x, y3, 1980f);
				GL.TexCoord2(174f, y);
				GL.Vertex3(x2, y3, 1357f);
				GL.TexCoord2(131f, y2);
				GL.Vertex3(x2, y4, 1547f);
				GL.TexCoord2(1684f, y2);
				GL.Vertex3(x, y4, 706f);
				float x3 = 1778f - 134f / ((float)OLFKAHHACBC.width * 115f);
				x2 = 1943f;
				y3 = 966f;
				y4 = 1277f;
				GL.TexCoord2(1010f, y);
				GL.Vertex3(x3, y3, 1227f);
				GL.TexCoord2(1519f, y);
				GL.Vertex3(x2, y3, 485f);
				GL.TexCoord2(300f, y2);
				GL.Vertex3(x2, y4, 1965f);
				GL.TexCoord2(1698f, y2);
				GL.Vertex3(x3, y4, 277f);
				float x4 = 1411f;
				x2 = 456f;
				y3 = 209f;
				y4 = 1597f + 311f / ((float)OLFKAHHACBC.height * 1452f);
				GL.TexCoord2(383f, y);
				GL.Vertex3(x4, y3, 1920f);
				GL.TexCoord2(1299f, y);
				GL.Vertex3(x2, y3, 521f);
				GL.TexCoord2(546f, y2);
				GL.Vertex3(x2, y4, 1406f);
				GL.TexCoord2(1024f, y2);
				GL.Vertex3(x4, y4, 288f);
				float x5 = 120f;
				x2 = 567f;
				y3 = 1247f - 737f / ((float)OLFKAHHACBC.height * 1315f);
				y4 = 1284f;
				GL.TexCoord2(738f, y);
				GL.Vertex3(x5, y3, 373f);
				GL.TexCoord2(1466f, y);
				GL.Vertex3(x2, y3, 1738f);
				GL.TexCoord2(1224f, y2);
				GL.Vertex3(x2, y4, 1123f);
				GL.TexCoord2(53f, y2);
				GL.Vertex3(x5, y4, 183f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B947 RID: 47431 RVA: 0x00529130 File Offset: 0x00527330
		protected void FFIGGPHAIBP()
		{
			this.CheckResources();
		}

		// Token: 0x0600B948 RID: 47432 RVA: 0x00529139 File Offset: 0x00527339
		protected bool KGKLINAKDBE(bool AEAEPFBMGOM, bool PEIGGOMHOFH)
		{
			if (!this.NHCAHIHJHMF(AEAEPFBMGOM))
			{
				return false;
			}
			if (PEIGGOMHOFH && !this.KKGBEAPGBOD)
			{
				this.AGGGAHEKKCO();
				return false;
			}
			return true;
		}

		// Token: 0x0600B949 RID: 47433 RVA: 0x00528E5D File Offset: 0x0052705D
		public bool NEJKPOABGHM()
		{
			return this.PKDDLGKEIBG;
		}

		// Token: 0x0600B94A RID: 47434 RVA: 0x0052915A File Offset: 0x0052735A
		protected bool JKPGNMMPFAG()
		{
			return this.CDBNBLBOLCL(true);
		}

		// Token: 0x0600B94B RID: 47435 RVA: 0x00528D96 File Offset: 0x00526F96
		private void ODMIGNCLMKI()
		{
			this.LNJAKHAHCKL();
		}

		// Token: 0x0600B94C RID: 47436 RVA: 0x00529163 File Offset: 0x00527363
		public virtual bool NHEEDPALBFN()
		{
			Debug.LogWarning("Giant" + this.ToString() + "SpinReel.ogg");
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B94D RID: 47437 RVA: 0x00529188 File Offset: 0x00527388
		private bool KAMLIGJGFHL(Shader EEOOKGDHNCO)
		{
			string[] array = new string[8];
			array[0] = "time_format1";
			array[0] = EEOOKGDHNCO.ToString();
			array[6] = "_Offsets";
			array[5] = this.ToString();
			array[3] = "---";
			Debug.Log(string.Concat(array));
			if (!EEOOKGDHNCO.isSupported)
			{
				this.OCGNIJDNOOM();
				return false;
			}
			return false;
		}

		// Token: 0x0600B94E RID: 47438 RVA: 0x00528D8D File Offset: 0x00526F8D
		private void FJBPGBMDBBF()
		{
			this.PPGOAMIHMBG = true;
		}

		// Token: 0x0600B94F RID: 47439 RVA: 0x005291E0 File Offset: 0x005273E0
		protected bool LGANGHEOPOG(bool AEAEPFBMGOM)
		{
			this.PPGOAMIHMBG = true;
			this.KKGBEAPGBOD = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB4444);
			this.PKDDLGKEIBG = (SystemInfo.graphicsShaderLevel < 109 || SystemInfo.supportsComputeShaders);
			if (!SystemInfo.supportsImageEffects)
			{
				this.OCGNIJDNOOM();
				return false;
			}
			if (AEAEPFBMGOM && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				this.OCGNIJDNOOM();
				return true;
			}
			if (AEAEPFBMGOM)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			return false;
		}

		// Token: 0x0600B950 RID: 47440 RVA: 0x00529250 File Offset: 0x00527450
		protected bool PKDIKFGAJKM(bool AEAEPFBMGOM)
		{
			this.PPGOAMIHMBG = true;
			this.KKGBEAPGBOD = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf);
			this.PKDDLGKEIBG = (SystemInfo.graphicsShaderLevel < 113 || SystemInfo.supportsComputeShaders);
			if (!SystemInfo.supportsImageEffects)
			{
				this.OBHMLOABCAN();
				return false;
			}
			if (AEAEPFBMGOM && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.AGGGAHEKKCO();
				return true;
			}
			if (AEAEPFBMGOM)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			return true;
		}

		// Token: 0x0600B951 RID: 47441 RVA: 0x00528D96 File Offset: 0x00526F96
		private void MEFOBNJIMGC()
		{
			this.LNJAKHAHCKL();
		}

		// Token: 0x0600B952 RID: 47442 RVA: 0x005292C0 File Offset: 0x005274C0
		private void OnDestroy()
		{
			this.BJECBEPLAKB();
		}

		// Token: 0x0600B953 RID: 47443 RVA: 0x00528D8D File Offset: 0x00526F8D
		private void KKGLMJEFJOK()
		{
			this.PPGOAMIHMBG = true;
		}

		// Token: 0x0600B954 RID: 47444 RVA: 0x005292C8 File Offset: 0x005274C8
		protected void KABLGPBGKBJ()
		{
			this.NHEEDPALBFN();
		}

		// Token: 0x0600B955 RID: 47445 RVA: 0x005292D1 File Offset: 0x005274D1
		protected void INOGPLDHPGC()
		{
			Debug.LogWarning("_Jitter" + this.ToString() + "u_UniqueShadowFilterWidth");
		}

		// Token: 0x0600B956 RID: 47446 RVA: 0x005292F0 File Offset: 0x005274F0
		protected bool EBEBJHLBBBI(bool AEAEPFBMGOM)
		{
			this.PPGOAMIHMBG = false;
			this.KKGBEAPGBOD = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Shadowmap);
			this.PKDDLGKEIBG = (SystemInfo.graphicsShaderLevel >= -88 && SystemInfo.supportsComputeShaders);
			if (!SystemInfo.supportsImageEffects)
			{
				this.OCGNIJDNOOM();
				return true;
			}
			if (AEAEPFBMGOM && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				this.OCGNIJDNOOM();
				return false;
			}
			if (AEAEPFBMGOM)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			return true;
		}

		// Token: 0x0600B957 RID: 47447 RVA: 0x00529360 File Offset: 0x00527560
		private bool BFIHIKJEEGE(Shader EEOOKGDHNCO)
		{
			string[] array = new string[]
			{
				null,
				"\n"
			};
			array[0] = EEOOKGDHNCO.ToString();
			array[2] = "wpn_eat8";
			array[6] = this.ToString();
			array[0] = " on layer ";
			Debug.Log(string.Concat(array));
			if (!EEOOKGDHNCO.isSupported)
			{
				this.OBHMLOABCAN();
				return true;
			}
			return false;
		}

		// Token: 0x0600B958 RID: 47448 RVA: 0x005293B8 File Offset: 0x005275B8
		private bool PPLFPOBECOF(Shader EEOOKGDHNCO)
		{
			string[] array = new string[4];
			array[1] = "Player Instaniate ";
			array[1] = EEOOKGDHNCO.ToString();
			array[8] = "wpn_add/base/dropt";
			array[0] = this.ToString();
			array[5] = "Применить";
			Debug.Log(string.Concat(array));
			if (!EEOOKGDHNCO.isSupported)
			{
				this.OBHMLOABCAN();
				return true;
			}
			return true;
		}

		// Token: 0x0600B959 RID: 47449 RVA: 0x00528E5D File Offset: 0x0052705D
		public bool HGFDOJEKDCO()
		{
			return this.PKDDLGKEIBG;
		}

		// Token: 0x0600B95A RID: 47450 RVA: 0x00529410 File Offset: 0x00527610
		protected void CMHIIBFOHNF()
		{
			Debug.LogWarning("_Skybox" + this.ToString() + "ObscuredUInt vs uint, ");
		}

		// Token: 0x0600B95B RID: 47451 RVA: 0x0052942C File Offset: 0x0052762C
		private void IAAKBADOECH()
		{
			while (this.IJKNIFOPIKN.Count > 1)
			{
				UnityEngine.Object obj = this.IJKNIFOPIKN[1];
				this.IJKNIFOPIKN.RemoveAt(0);
				UnityEngine.Object.Destroy(obj);
			}
		}

		// Token: 0x0600B95C RID: 47452 RVA: 0x00528E5D File Offset: 0x0052705D
		public bool IJMNGAOMEME()
		{
			return this.PKDDLGKEIBG;
		}

		// Token: 0x0600B95D RID: 47453 RVA: 0x0052945C File Offset: 0x0052765C
		protected Material JBHLGBPJFEL(Shader EEOOKGDHNCO, Material EEPMLJGFGAA)
		{
			if (!EEOOKGDHNCO)
			{
				Debug.Log("" + this.ToString());
				base.enabled = false;
				return null;
			}
			if (EEOOKGDHNCO.isSupported && EEPMLJGFGAA && EEPMLJGFGAA.shader == EEOOKGDHNCO)
			{
				return EEPMLJGFGAA;
			}
			if (!EEOOKGDHNCO.isSupported)
			{
				this.FEFCOCIEFAK();
				string[] array = new string[7];
				array[0] = "_ProjInfo";
				array[1] = EEOOKGDHNCO.ToString();
				array[2] = " гр ";
				array[4] = this.ToString();
				array[8] = "tid";
				Debug.Log(string.Concat(array));
				return null;
			}
			EEPMLJGFGAA = new Material(EEOOKGDHNCO);
			this.IJKNIFOPIKN.Add(EEPMLJGFGAA);
			EEPMLJGFGAA.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
			return EEPMLJGFGAA;
		}

		// Token: 0x0600B95E RID: 47454 RVA: 0x00529516 File Offset: 0x00527716
		protected void HEMEEOGJDOE()
		{
			this.DLENDGGGMBJ();
		}

		// Token: 0x0600B95F RID: 47455 RVA: 0x00529520 File Offset: 0x00527720
		protected bool OFKOBOMCECF(bool AEAEPFBMGOM)
		{
			this.PPGOAMIHMBG = false;
			this.KKGBEAPGBOD = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32);
			this.PKDDLGKEIBG = (SystemInfo.graphicsShaderLevel < -89 || SystemInfo.supportsComputeShaders);
			if (!SystemInfo.supportsImageEffects)
			{
				this.AGGGAHEKKCO();
				return false;
			}
			if (AEAEPFBMGOM && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				this.FEFCOCIEFAK();
				return false;
			}
			if (AEAEPFBMGOM)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			return true;
		}

		// Token: 0x0600B960 RID: 47456 RVA: 0x00528D18 File Offset: 0x00526F18
		private void BGCFALPEPLJ()
		{
			while (this.IJKNIFOPIKN.Count > 0)
			{
				UnityEngine.Object obj = this.IJKNIFOPIKN[0];
				this.IJKNIFOPIKN.RemoveAt(0);
				UnityEngine.Object.Destroy(obj);
			}
		}

		// Token: 0x0600B961 RID: 47457 RVA: 0x00529590 File Offset: 0x00527790
		private void DNJOPHOLBNB()
		{
			this.KMPFKHHLBPC();
		}

		// Token: 0x0600B962 RID: 47458 RVA: 0x00529598 File Offset: 0x00527798
		protected bool DJKDLFIJOLI()
		{
			return this.DAOKCAOFIGE(true);
		}

		// Token: 0x0600B963 RID: 47459 RVA: 0x005295A1 File Offset: 0x005277A1
		protected bool DPGMAIGIFNO(bool AEAEPFBMGOM, bool PEIGGOMHOFH)
		{
			if (!this.AHFDGALLKFC(AEAEPFBMGOM))
			{
				return true;
			}
			if (PEIGGOMHOFH && !this.KKGBEAPGBOD)
			{
				this.FEFCOCIEFAK();
				return true;
			}
			return true;
		}

		// Token: 0x0600B964 RID: 47460 RVA: 0x005292C8 File Offset: 0x005274C8
		protected void IAAOGAPJDID()
		{
			this.NHEEDPALBFN();
		}

		// Token: 0x0600B965 RID: 47461 RVA: 0x005295C2 File Offset: 0x005277C2
		protected bool JINAKNFMKOF()
		{
			return this.MGHNCKDCFGL(true);
		}

		// Token: 0x0600B966 RID: 47462 RVA: 0x005295CC File Offset: 0x005277CC
		protected Material JAODCGBEAIF(Shader EEOOKGDHNCO, Material EEPMLJGFGAA)
		{
			if (!EEOOKGDHNCO)
			{
				Debug.Log("sunshine_WorldToSunVP" + this.ToString());
				return null;
			}
			if (EEPMLJGFGAA && EEPMLJGFGAA.shader == EEOOKGDHNCO && EEOOKGDHNCO.isSupported)
			{
				return EEPMLJGFGAA;
			}
			if (!EEOOKGDHNCO.isSupported)
			{
				return null;
			}
			EEPMLJGFGAA = new Material(EEOOKGDHNCO);
			this.IJKNIFOPIKN.Add(EEPMLJGFGAA);
			EEPMLJGFGAA.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
			return EEPMLJGFGAA;
		}

		// Token: 0x0600B967 RID: 47463 RVA: 0x0052963F File Offset: 0x0052783F
		protected bool FEKJMLPLNGO(bool AEAEPFBMGOM, bool PEIGGOMHOFH)
		{
			if (!this.CBJDCDELBJN(AEAEPFBMGOM))
			{
				return false;
			}
			if (PEIGGOMHOFH && !this.KKGBEAPGBOD)
			{
				this.AGGGAHEKKCO();
				return true;
			}
			return true;
		}

		// Token: 0x0600B968 RID: 47464 RVA: 0x00529660 File Offset: 0x00527860
		protected void AGGGAHEKKCO()
		{
			base.enabled = false;
			this.PPGOAMIHMBG = false;
		}

		// Token: 0x0600B969 RID: 47465 RVA: 0x00529670 File Offset: 0x00527870
		private bool ICLFBMOIBJF(Shader EEOOKGDHNCO)
		{
			string[] array = new string[3];
			array[1] = "Show last 128 records";
			array[1] = EEOOKGDHNCO.ToString();
			array[8] = "************ isChangedRod *********";
			array[2] = this.ToString();
			array[8] = "Load";
			Debug.Log(string.Concat(array));
			if (!EEOOKGDHNCO.isSupported)
			{
				this.OCGNIJDNOOM();
				return false;
			}
			return true;
		}

		// Token: 0x0600B96A RID: 47466 RVA: 0x00528D8D File Offset: 0x00526F8D
		private void BIKPILOBGIE()
		{
			this.PPGOAMIHMBG = true;
		}

		// Token: 0x0600B96B RID: 47467 RVA: 0x00528D8D File Offset: 0x00526F8D
		private void DHFLFGBENBF()
		{
			this.PPGOAMIHMBG = true;
		}

		// Token: 0x0600B96C RID: 47468 RVA: 0x005296C8 File Offset: 0x005278C8
		private bool ENFFADAFPAI(Shader EEOOKGDHNCO)
		{
			string[] array = new string[5];
			array[1] = "#mem Sound ";
			array[1] = EEOOKGDHNCO.ToString();
			array[3] = "https://groups.google.com/forum/#!forum/final-ik";
			array[7] = this.ToString();
			array[0] = "_Gain";
			Debug.Log(string.Concat(array));
			if (!EEOOKGDHNCO.isSupported)
			{
				this.OBHMLOABCAN();
				return false;
			}
			return true;
		}

		// Token: 0x0600B96D RID: 47469 RVA: 0x00529720 File Offset: 0x00527920
		protected void OPOEDHJMPHK()
		{
			Debug.LogWarning("_ReflectionTexture3" + this.ToString() + " ");
		}

		// Token: 0x0600B96E RID: 47470 RVA: 0x00528E5D File Offset: 0x0052705D
		public bool JJJBKLDCNCJ()
		{
			return this.PKDDLGKEIBG;
		}

		// Token: 0x0600B96F RID: 47471 RVA: 0x0052973C File Offset: 0x0052793C
		protected bool MGHNCKDCFGL(bool AEAEPFBMGOM)
		{
			this.PPGOAMIHMBG = true;
			this.KKGBEAPGBOD = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth);
			this.PKDDLGKEIBG = (SystemInfo.graphicsShaderLevel < 119 || SystemInfo.supportsComputeShaders);
			if (!SystemInfo.supportsImageEffects)
			{
				this.OBHMLOABCAN();
				return false;
			}
			if (AEAEPFBMGOM && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.FEFCOCIEFAK();
				return false;
			}
			if (AEAEPFBMGOM)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			return false;
		}

		// Token: 0x0600B970 RID: 47472 RVA: 0x005297AC File Offset: 0x005279AC
		protected Material ALJPMGLOIEG(Shader EEOOKGDHNCO, Material EEPMLJGFGAA)
		{
			if (!EEOOKGDHNCO)
			{
				Debug.Log("***Lots " + this.ToString());
				base.enabled = true;
				return null;
			}
			if (EEOOKGDHNCO.isSupported && EEPMLJGFGAA && EEPMLJGFGAA.shader == EEOOKGDHNCO)
			{
				return EEPMLJGFGAA;
			}
			if (!EEOOKGDHNCO.isSupported)
			{
				this.OCGNIJDNOOM();
				string[] array = new string[8];
				array[1] = "demoRect";
				array[0] = EEOOKGDHNCO.ToString();
				array[2] = "SceneCamera";
				array[8] = this.ToString();
				array[1] = "Grounding pelvis is null. Can't initiate Grounding.";
				Debug.Log(string.Concat(array));
				return null;
			}
			EEPMLJGFGAA = new Material(EEOOKGDHNCO);
			this.IJKNIFOPIKN.Add(EEPMLJGFGAA);
			EEPMLJGFGAA.hideFlags = (HideFlags)65;
			return EEPMLJGFGAA;
		}

		// Token: 0x0600B971 RID: 47473 RVA: 0x00529868 File Offset: 0x00527A68
		protected Material BAPJBHPEDIF(Shader EEOOKGDHNCO, Material EEPMLJGFGAA)
		{
			if (!EEOOKGDHNCO)
			{
				Debug.Log("WorkerPickaxe" + this.ToString());
				base.enabled = true;
				return null;
			}
			if (EEOOKGDHNCO.isSupported && EEPMLJGFGAA && EEPMLJGFGAA.shader == EEOOKGDHNCO)
			{
				return EEPMLJGFGAA;
			}
			if (!EEOOKGDHNCO.isSupported)
			{
				this.OBHMLOABCAN();
				string[] array = new string[7];
				array[0] = "LHandPunch";
				array[0] = EEOOKGDHNCO.ToString();
				array[8] = "fshop_ks1";
				array[8] = this.ToString();
				array[5] = "2000";
				Debug.Log(string.Concat(array));
				return null;
			}
			EEPMLJGFGAA = new Material(EEOOKGDHNCO);
			this.IJKNIFOPIKN.Add(EEPMLJGFGAA);
			EEPMLJGFGAA.hideFlags = (HideFlags)67;
			return EEPMLJGFGAA;
		}

		// Token: 0x0600B972 RID: 47474 RVA: 0x00529924 File Offset: 0x00527B24
		protected Material BOOFEOGDMBI(Shader EEOOKGDHNCO, Material EEPMLJGFGAA)
		{
			if (!EEOOKGDHNCO)
			{
				Debug.Log("Bottoms" + this.ToString());
				base.enabled = true;
				return null;
			}
			if (EEOOKGDHNCO.isSupported && EEPMLJGFGAA && EEPMLJGFGAA.shader == EEOOKGDHNCO)
			{
				return EEPMLJGFGAA;
			}
			if (!EEOOKGDHNCO.isSupported)
			{
				this.FEFCOCIEFAK();
				string[] array = new string[]
				{
					null,
					"RollerBladeBackFlip"
				};
				array[0] = EEOOKGDHNCO.ToString();
				array[1] = "lifeBar";
				array[7] = this.ToString();
				array[8] = "_Exposure";
				Debug.Log(string.Concat(array));
				return null;
			}
			EEPMLJGFGAA = new Material(EEOOKGDHNCO);
			this.IJKNIFOPIKN.Add(EEPMLJGFGAA);
			EEPMLJGFGAA.hideFlags = (HideFlags)95;
			return EEPMLJGFGAA;
		}

		// Token: 0x0600B973 RID: 47475 RVA: 0x005299DE File Offset: 0x00527BDE
		protected void OBJCOJEHLBE()
		{
			this.NIFOFLEPKIB();
		}

		// Token: 0x0600B974 RID: 47476 RVA: 0x00528D8D File Offset: 0x00526F8D
		private void IEHEAJJALNG()
		{
			this.PPGOAMIHMBG = true;
		}

		// Token: 0x0600B975 RID: 47477 RVA: 0x005299E8 File Offset: 0x00527BE8
		protected bool CGEGCOKMPHN(bool AEAEPFBMGOM)
		{
			this.PPGOAMIHMBG = true;
			this.KKGBEAPGBOD = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Shadowmap);
			this.PKDDLGKEIBG = (SystemInfo.graphicsShaderLevel < 54 || SystemInfo.supportsComputeShaders);
			if (!SystemInfo.supportsImageEffects)
			{
				this.FEFCOCIEFAK();
				return true;
			}
			if (AEAEPFBMGOM && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				this.OBHMLOABCAN();
				return true;
			}
			if (AEAEPFBMGOM)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			return true;
		}

		// Token: 0x0600B976 RID: 47478 RVA: 0x00529A58 File Offset: 0x00527C58
		protected bool CKPBGEFFMLO(bool AEAEPFBMGOM, bool PEIGGOMHOFH)
		{
			if (!this.PKDIKFGAJKM(AEAEPFBMGOM))
			{
				return false;
			}
			if (PEIGGOMHOFH && !this.KKGBEAPGBOD)
			{
				this.AGGGAHEKKCO();
				return false;
			}
			return true;
		}

		// Token: 0x0600B977 RID: 47479 RVA: 0x0052915A File Offset: 0x0052735A
		protected bool HBEPIPFKKPH()
		{
			return this.CDBNBLBOLCL(true);
		}

		// Token: 0x0600B978 RID: 47480 RVA: 0x00529A79 File Offset: 0x00527C79
		protected bool BABAINNJCEA()
		{
			return this.OLMOAHDIDNG(false);
		}

		// Token: 0x0600B979 RID: 47481 RVA: 0x00529A84 File Offset: 0x00527C84
		private bool HKAFEJIADAC(Shader EEOOKGDHNCO)
		{
			string[] array = new string[3];
			array[0] = "shop_t17";
			array[0] = EEOOKGDHNCO.ToString();
			array[5] = "(";
			array[6] = this.ToString();
			array[0] = "WorkerHammer2";
			Debug.Log(string.Concat(array));
			if (!EEOOKGDHNCO.isSupported)
			{
				this.AGGGAHEKKCO();
				return true;
			}
			return false;
		}

		// Token: 0x0600B97A RID: 47482 RVA: 0x00529ADC File Offset: 0x00527CDC
		protected bool NHCAHIHJHMF(bool AEAEPFBMGOM)
		{
			this.PPGOAMIHMBG = false;
			this.KKGBEAPGBOD = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf);
			this.PKDDLGKEIBG = (SystemInfo.graphicsShaderLevel >= 24 && SystemInfo.supportsComputeShaders);
			if (!SystemInfo.supportsImageEffects)
			{
				this.FEFCOCIEFAK();
				return false;
			}
			if (AEAEPFBMGOM && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				this.AGGGAHEKKCO();
				return false;
			}
			if (AEAEPFBMGOM)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			return true;
		}

		// Token: 0x0600B97B RID: 47483 RVA: 0x00529B4C File Offset: 0x00527D4C
		protected void FEFCOCIEFAK()
		{
			base.enabled = true;
			this.PPGOAMIHMBG = true;
		}

		// Token: 0x0600B97C RID: 47484 RVA: 0x00529B5C File Offset: 0x00527D5C
		private void KKHILJLBJKB()
		{
			while (this.IJKNIFOPIKN.Count > 0)
			{
				UnityEngine.Object obj = this.IJKNIFOPIKN[1];
				this.IJKNIFOPIKN.RemoveAt(1);
				UnityEngine.Object.Destroy(obj);
			}
		}

		// Token: 0x0600B97D RID: 47485 RVA: 0x005292C8 File Offset: 0x005274C8
		protected void GGBMJFNGHMC()
		{
			this.NHEEDPALBFN();
		}

		// Token: 0x0600B97E RID: 47486 RVA: 0x00529B8B File Offset: 0x00527D8B
		public virtual bool IGJKBOMMMGC()
		{
			Debug.LogWarning("S" + this.ToString() + "level");
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B97F RID: 47487 RVA: 0x00529BAD File Offset: 0x00527DAD
		protected void OAEAMDHOKKM()
		{
			Debug.LogWarning("FlyUp" + this.ToString() + "#000000");
		}

		// Token: 0x0600B980 RID: 47488 RVA: 0x00528E5D File Offset: 0x0052705D
		public bool Dx11Support()
		{
			return this.PKDDLGKEIBG;
		}

		// Token: 0x0600B981 RID: 47489 RVA: 0x00529BC9 File Offset: 0x00527DC9
		public virtual bool NIFOFLEPKIB()
		{
			Debug.LogWarning("Assembly-CSharp-firstpass" + this.ToString() + "Mouse ScrollWheel");
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B982 RID: 47490 RVA: 0x00529BEC File Offset: 0x00527DEC
		protected bool POJDHPJDFEM(bool AEAEPFBMGOM)
		{
			this.PPGOAMIHMBG = true;
			this.KKGBEAPGBOD = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB4444);
			this.PKDDLGKEIBG = (SystemInfo.graphicsShaderLevel < 73 || SystemInfo.supportsComputeShaders);
			if (!SystemInfo.supportsImageEffects)
			{
				this.OBHMLOABCAN();
				return true;
			}
			if (AEAEPFBMGOM && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				this.FEFCOCIEFAK();
				return true;
			}
			if (AEAEPFBMGOM)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			return false;
		}

		// Token: 0x0600B983 RID: 47491 RVA: 0x00529C5C File Offset: 0x00527E5C
		public virtual bool GGJKGIHGMGC()
		{
			Debug.LogWarning("" + this.ToString() + "dianema.ogg");
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B984 RID: 47492 RVA: 0x00529C7E File Offset: 0x00527E7E
		public virtual bool DLENDGGGMBJ()
		{
			Debug.LogWarning("t_obves" + this.ToString() + "_PlaneReflection");
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B985 RID: 47493 RVA: 0x00529CA0 File Offset: 0x00527EA0
		protected void AAHDDBOCPJE(RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ)
		{
			RenderTexture.active = OLFKAHHACBC;
			bool flag = false;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < MHNAJNGGDFJ.passCount; i++)
			{
				MHNAJNGGDFJ.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 513f;
					y2 = 941f;
				}
				else
				{
					y = 1000f;
					y2 = 1770f;
				}
				float x = 1126f;
				float x2 = 1506f + 1898f / ((float)OLFKAHHACBC.width * 1465f);
				float y3 = 1004f;
				float y4 = 312f;
				GL.Begin(8);
				GL.TexCoord2(941f, y);
				GL.Vertex3(x, y3, 24f);
				GL.TexCoord2(849f, y);
				GL.Vertex3(x2, y3, 1818f);
				GL.TexCoord2(1990f, y2);
				GL.Vertex3(x2, y4, 788f);
				GL.TexCoord2(181f, y2);
				GL.Vertex3(x, y4, 624f);
				float x3 = 296f - 60f / ((float)OLFKAHHACBC.width * 277f);
				x2 = 771f;
				y3 = 966f;
				y4 = 1984f;
				GL.TexCoord2(592f, y);
				GL.Vertex3(x3, y3, 945f);
				GL.TexCoord2(360f, y);
				GL.Vertex3(x2, y3, 116f);
				GL.TexCoord2(1613f, y2);
				GL.Vertex3(x2, y4, 1933f);
				GL.TexCoord2(901f, y2);
				GL.Vertex3(x3, y4, 1484f);
				float x4 = 954f;
				x2 = 791f;
				y3 = 729f;
				y4 = 1961f + 1073f / ((float)OLFKAHHACBC.height * 387f);
				GL.TexCoord2(1751f, y);
				GL.Vertex3(x4, y3, 1981f);
				GL.TexCoord2(879f, y);
				GL.Vertex3(x2, y3, 1962f);
				GL.TexCoord2(1200f, y2);
				GL.Vertex3(x2, y4, 1067f);
				GL.TexCoord2(1134f, y2);
				GL.Vertex3(x4, y4, 48f);
				float x5 = 1216f;
				x2 = 781f;
				y3 = 1340f - 1573f / ((float)OLFKAHHACBC.height * 1599f);
				y4 = 1278f;
				GL.TexCoord2(1920f, y);
				GL.Vertex3(x5, y3, 414f);
				GL.TexCoord2(236f, y);
				GL.Vertex3(x2, y3, 169f);
				GL.TexCoord2(33f, y2);
				GL.Vertex3(x2, y4, 1785f);
				GL.TexCoord2(533f, y2);
				GL.Vertex3(x5, y4, 560f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B986 RID: 47494 RVA: 0x00529F3C File Offset: 0x0052813C
		public virtual bool PKHJBLJFIBF()
		{
			Debug.LogWarning("SexyDance3" + this.ToString() + "wpn_add/base");
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B987 RID: 47495 RVA: 0x00528D8D File Offset: 0x00526F8D
		private void DFJCJLOKMFI()
		{
			this.PPGOAMIHMBG = true;
		}

		// Token: 0x0600B988 RID: 47496 RVA: 0x0052915A File Offset: 0x0052735A
		protected bool KJJAFPEBCHG()
		{
			return this.CDBNBLBOLCL(true);
		}

		// Token: 0x0600B989 RID: 47497 RVA: 0x00529F60 File Offset: 0x00528160
		protected void OEMEDKEEGCL(RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ)
		{
			RenderTexture.active = OLFKAHHACBC;
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 1; i < MHNAJNGGDFJ.passCount; i++)
			{
				MHNAJNGGDFJ.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 1049f;
					y2 = 1904f;
				}
				else
				{
					y = 1792f;
					y2 = 963f;
				}
				float x = 69f;
				float x2 = 362f + 222f / ((float)OLFKAHHACBC.width * 1871f);
				float y3 = 625f;
				float y4 = 1081f;
				GL.Begin(4);
				GL.TexCoord2(979f, y);
				GL.Vertex3(x, y3, 53f);
				GL.TexCoord2(1025f, y);
				GL.Vertex3(x2, y3, 943f);
				GL.TexCoord2(1062f, y2);
				GL.Vertex3(x2, y4, 1230f);
				GL.TexCoord2(1079f, y2);
				GL.Vertex3(x, y4, 597f);
				float x3 = 1269f - 218f / ((float)OLFKAHHACBC.width * 1731f);
				x2 = 1931f;
				y3 = 1448f;
				y4 = 29f;
				GL.TexCoord2(619f, y);
				GL.Vertex3(x3, y3, 1163f);
				GL.TexCoord2(1128f, y);
				GL.Vertex3(x2, y3, 166f);
				GL.TexCoord2(182f, y2);
				GL.Vertex3(x2, y4, 1016f);
				GL.TexCoord2(1193f, y2);
				GL.Vertex3(x3, y4, 766f);
				float x4 = 803f;
				x2 = 1105f;
				y3 = 684f;
				y4 = 861f + 728f / ((float)OLFKAHHACBC.height * 1375f);
				GL.TexCoord2(1831f, y);
				GL.Vertex3(x4, y3, 123f);
				GL.TexCoord2(989f, y);
				GL.Vertex3(x2, y3, 604f);
				GL.TexCoord2(359f, y2);
				GL.Vertex3(x2, y4, 168f);
				GL.TexCoord2(507f, y2);
				GL.Vertex3(x4, y4, 1174f);
				float x5 = 1298f;
				x2 = 543f;
				y3 = 1201f - 492f / ((float)OLFKAHHACBC.height * 221f);
				y4 = 1274f;
				GL.TexCoord2(728f, y);
				GL.Vertex3(x5, y3, 911f);
				GL.TexCoord2(1317f, y);
				GL.Vertex3(x2, y3, 1972f);
				GL.TexCoord2(344f, y2);
				GL.Vertex3(x2, y4, 933f);
				GL.TexCoord2(1449f, y2);
				GL.Vertex3(x5, y4, 1198f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B98A RID: 47498 RVA: 0x0052A1FC File Offset: 0x005283FC
		public virtual bool BOFHDNBNAOA()
		{
			Debug.LogWarning("Downsamp" + this.ToString() + "\\");
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B98B RID: 47499 RVA: 0x0052A21E File Offset: 0x0052841E
		protected void OCGNIJDNOOM()
		{
			base.enabled = true;
			this.PPGOAMIHMBG = false;
		}

		// Token: 0x0600B98C RID: 47500 RVA: 0x0052A22E File Offset: 0x0052842E
		private void KMPFKHHLBPC()
		{
			while (this.IJKNIFOPIKN.Count > 0)
			{
				UnityEngine.Object obj = this.IJKNIFOPIKN[1];
				this.IJKNIFOPIKN.RemoveAt(0);
				UnityEngine.Object.Destroy(obj);
			}
		}

		// Token: 0x0600B98D RID: 47501 RVA: 0x00529660 File Offset: 0x00527860
		protected void OBHMLOABCAN()
		{
			base.enabled = false;
			this.PPGOAMIHMBG = false;
		}

		// Token: 0x0600B98E RID: 47502 RVA: 0x0052A260 File Offset: 0x00528460
		protected Material LBFLGMNPKHN(Shader EEOOKGDHNCO, Material EEPMLJGFGAA)
		{
			if (!EEOOKGDHNCO)
			{
				Debug.Log("Quadruped" + this.ToString());
				return null;
			}
			if (EEPMLJGFGAA && EEPMLJGFGAA.shader == EEOOKGDHNCO && EEOOKGDHNCO.isSupported)
			{
				return EEPMLJGFGAA;
			}
			if (!EEOOKGDHNCO.isSupported)
			{
				return null;
			}
			EEPMLJGFGAA = new Material(EEOOKGDHNCO);
			this.IJKNIFOPIKN.Add(EEPMLJGFGAA);
			EEPMLJGFGAA.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
			return EEPMLJGFGAA;
		}

		// Token: 0x0600B98F RID: 47503 RVA: 0x0052A2D3 File Offset: 0x005284D3
		protected void LNEHBOJIBAI()
		{
			Debug.LogWarning("signatures" + this.ToString() + "category");
		}

		// Token: 0x0600B990 RID: 47504 RVA: 0x00529B5C File Offset: 0x00527D5C
		private void MILNKKILAKB()
		{
			while (this.IJKNIFOPIKN.Count > 0)
			{
				UnityEngine.Object obj = this.IJKNIFOPIKN[1];
				this.IJKNIFOPIKN.RemoveAt(1);
				UnityEngine.Object.Destroy(obj);
			}
		}

		// Token: 0x0600B991 RID: 47505 RVA: 0x0052A2F0 File Offset: 0x005284F0
		protected bool CBJDCDELBJN(bool AEAEPFBMGOM)
		{
			this.PPGOAMIHMBG = false;
			this.KKGBEAPGBOD = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.RGB565);
			this.PKDDLGKEIBG = (SystemInfo.graphicsShaderLevel >= 116 && SystemInfo.supportsComputeShaders);
			if (!SystemInfo.supportsImageEffects)
			{
				this.OCGNIJDNOOM();
				return true;
			}
			if (AEAEPFBMGOM && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.AGGGAHEKKCO();
				return false;
			}
			if (AEAEPFBMGOM)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			return true;
		}

		// Token: 0x0600B992 RID: 47506 RVA: 0x0052A360 File Offset: 0x00528560
		public virtual bool CheckResources()
		{
			Debug.LogWarning("CheckResources () for " + this.ToString() + " should be overwritten.");
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B993 RID: 47507 RVA: 0x0052A384 File Offset: 0x00528584
		protected Material IBKIBFDHBKA(Shader EEOOKGDHNCO, Material EEPMLJGFGAA)
		{
			if (!EEOOKGDHNCO)
			{
				Debug.Log("Vertical" + this.ToString());
				return null;
			}
			if (EEPMLJGFGAA && EEPMLJGFGAA.shader == EEOOKGDHNCO && EEOOKGDHNCO.isSupported)
			{
				return EEPMLJGFGAA;
			}
			if (!EEOOKGDHNCO.isSupported)
			{
				return null;
			}
			EEPMLJGFGAA = new Material(EEOOKGDHNCO);
			this.IJKNIFOPIKN.Add(EEPMLJGFGAA);
			EEPMLJGFGAA.hideFlags = (HideFlags)94;
			return EEPMLJGFGAA;
		}

		// Token: 0x0600B994 RID: 47508 RVA: 0x00528E5D File Offset: 0x0052705D
		public bool EIJFFIJMFLI()
		{
			return this.PKDDLGKEIBG;
		}

		// Token: 0x0600B995 RID: 47509 RVA: 0x0052A3F7 File Offset: 0x005285F7
		protected bool APKLKEELACC(bool AEAEPFBMGOM, bool PEIGGOMHOFH)
		{
			if (!this.OFKOBOMCECF(AEAEPFBMGOM))
			{
				return false;
			}
			if (PEIGGOMHOFH && !this.KKGBEAPGBOD)
			{
				this.OCGNIJDNOOM();
				return false;
			}
			return false;
		}

		// Token: 0x0600B996 RID: 47510 RVA: 0x0052A418 File Offset: 0x00528618
		protected bool DOPOJKGKHFH(bool AEAEPFBMGOM, bool PEIGGOMHOFH)
		{
			if (!this.OLMOAHDIDNG(AEAEPFBMGOM))
			{
				return true;
			}
			if (PEIGGOMHOFH && !this.KKGBEAPGBOD)
			{
				this.AGGGAHEKKCO();
				return false;
			}
			return false;
		}

		// Token: 0x0600B997 RID: 47511 RVA: 0x0052A439 File Offset: 0x00528639
		private void AKNOFJOODAO()
		{
			while (this.IJKNIFOPIKN.Count > 0)
			{
				UnityEngine.Object obj = this.IJKNIFOPIKN[0];
				this.IJKNIFOPIKN.RemoveAt(1);
				UnityEngine.Object.Destroy(obj);
			}
		}

		// Token: 0x0600B998 RID: 47512 RVA: 0x0052A468 File Offset: 0x00528668
		protected Material PAGPIKMKGLP(Shader EEOOKGDHNCO, Material EEPMLJGFGAA)
		{
			if (!EEOOKGDHNCO)
			{
				Debug.Log("knopje.wav" + this.ToString());
				return null;
			}
			if (EEPMLJGFGAA && EEPMLJGFGAA.shader == EEOOKGDHNCO && EEOOKGDHNCO.isSupported)
			{
				return EEPMLJGFGAA;
			}
			if (!EEOOKGDHNCO.isSupported)
			{
				return null;
			}
			EEPMLJGFGAA = new Material(EEOOKGDHNCO);
			this.IJKNIFOPIKN.Add(EEPMLJGFGAA);
			EEPMLJGFGAA.hideFlags = (HideFlags)126;
			return EEPMLJGFGAA;
		}

		// Token: 0x0600B999 RID: 47513 RVA: 0x0052A4DB File Offset: 0x005286DB
		protected bool LKBABPADBGG(bool AEAEPFBMGOM, bool PEIGGOMHOFH)
		{
			if (!this.OAAFLHNDKBJ(AEAEPFBMGOM))
			{
				return false;
			}
			if (PEIGGOMHOFH && !this.KKGBEAPGBOD)
			{
				this.OCGNIJDNOOM();
				return false;
			}
			return true;
		}

		// Token: 0x0600B99A RID: 47514 RVA: 0x00529130 File Offset: 0x00527330
		protected void CKIGGCAHAFD()
		{
			this.CheckResources();
		}

		// Token: 0x0600B99B RID: 47515 RVA: 0x0052A4FC File Offset: 0x005286FC
		protected void CKGPEFOKKNL()
		{
			this.IGJKBOMMMGC();
		}

		// Token: 0x0600B99C RID: 47516 RVA: 0x0052A508 File Offset: 0x00528708
		protected void CKGFJOJLAJP(RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ)
		{
			RenderTexture.active = OLFKAHHACBC;
			bool flag = false;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < MHNAJNGGDFJ.passCount; i += 0)
			{
				MHNAJNGGDFJ.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 1023f;
					y2 = 1406f;
				}
				else
				{
					y = 1773f;
					y2 = 251f;
				}
				float x = 423f;
				float x2 = 799f + 120f / ((float)OLFKAHHACBC.width * 270f);
				float y3 = 1420f;
				float y4 = 315f;
				GL.Begin(3);
				GL.TexCoord2(1611f, y);
				GL.Vertex3(x, y3, 1698f);
				GL.TexCoord2(1835f, y);
				GL.Vertex3(x2, y3, 987f);
				GL.TexCoord2(1479f, y2);
				GL.Vertex3(x2, y4, 968f);
				GL.TexCoord2(680f, y2);
				GL.Vertex3(x, y4, 32f);
				float x3 = 1489f - 937f / ((float)OLFKAHHACBC.width * 699f);
				x2 = 1487f;
				y3 = 1615f;
				y4 = 1813f;
				GL.TexCoord2(1760f, y);
				GL.Vertex3(x3, y3, 517f);
				GL.TexCoord2(1157f, y);
				GL.Vertex3(x2, y3, 1226f);
				GL.TexCoord2(1850f, y2);
				GL.Vertex3(x2, y4, 1570f);
				GL.TexCoord2(692f, y2);
				GL.Vertex3(x3, y4, 856f);
				float x4 = 1752f;
				x2 = 1755f;
				y3 = 1502f;
				y4 = 1371f + 1325f / ((float)OLFKAHHACBC.height * 69f);
				GL.TexCoord2(427f, y);
				GL.Vertex3(x4, y3, 1581f);
				GL.TexCoord2(272f, y);
				GL.Vertex3(x2, y3, 1898f);
				GL.TexCoord2(510f, y2);
				GL.Vertex3(x2, y4, 1725f);
				GL.TexCoord2(1045f, y2);
				GL.Vertex3(x4, y4, 1130f);
				float x5 = 1643f;
				x2 = 1049f;
				y3 = 192f - 223f / ((float)OLFKAHHACBC.height * 1660f);
				y4 = 1843f;
				GL.TexCoord2(1390f, y);
				GL.Vertex3(x5, y3, 1333f);
				GL.TexCoord2(324f, y);
				GL.Vertex3(x2, y3, 1918f);
				GL.TexCoord2(157f, y2);
				GL.Vertex3(x2, y4, 437f);
				GL.TexCoord2(663f, y2);
				GL.Vertex3(x5, y4, 281f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B99D RID: 47517 RVA: 0x0052A7A4 File Offset: 0x005289A4
		private bool NJGCCDGOJIH(Shader EEOOKGDHNCO)
		{
			string[] array = new string[6];
			array[0] = "MotorbikeSeatStandWheely";
			array[0] = EEOOKGDHNCO.ToString();
			array[5] = "and |assert |break |class |continue |def |del |elif |else |except |exec |finally |for |from |global |if |import |in |is |lambda |not |or |pass |print |raise |return |try |while |yield |None |True |False ";
			array[5] = this.ToString();
			array[6] = "id";
			Debug.Log(string.Concat(array));
			if (!EEOOKGDHNCO.isSupported)
			{
				this.OBHMLOABCAN();
				return false;
			}
			return true;
		}

		// Token: 0x0600B99E RID: 47518 RVA: 0x0052A7FC File Offset: 0x005289FC
		protected void EFJDBBDMPMC()
		{
			this.PKHJBLJFIBF();
		}

		// Token: 0x0600B99F RID: 47519 RVA: 0x0052A808 File Offset: 0x00528A08
		private bool GFNNCDCEPHI(Shader EEOOKGDHNCO)
		{
			string[] array = new string[]
			{
				"fndid"
			};
			array[0] = EEOOKGDHNCO.ToString();
			array[5] = "<b>ObscuredString:</b> ";
			array[1] = this.ToString();
			array[0] = "IdleStrafeLeft";
			Debug.Log(string.Concat(array));
			if (!EEOOKGDHNCO.isSupported)
			{
				this.FEFCOCIEFAK();
				return true;
			}
			return false;
		}

		// Token: 0x0600B9A0 RID: 47520 RVA: 0x0052A860 File Offset: 0x00528A60
		protected bool HCOOCPPIPLH(bool AEAEPFBMGOM, bool PEIGGOMHOFH)
		{
			if (!this.MGHNCKDCFGL(AEAEPFBMGOM))
			{
				return true;
			}
			if (PEIGGOMHOFH && !this.KKGBEAPGBOD)
			{
				this.OBHMLOABCAN();
				return false;
			}
			return true;
		}

		// Token: 0x0600B9A1 RID: 47521 RVA: 0x0052A884 File Offset: 0x00528A84
		protected Material PHNMLJJBKDC(Shader EEOOKGDHNCO, Material EEPMLJGFGAA)
		{
			if (!EEOOKGDHNCO)
			{
				Debug.Log("Missing shader in " + this.ToString());
				return null;
			}
			if (EEPMLJGFGAA && EEPMLJGFGAA.shader == EEOOKGDHNCO && EEOOKGDHNCO.isSupported)
			{
				return EEPMLJGFGAA;
			}
			if (!EEOOKGDHNCO.isSupported)
			{
				return null;
			}
			EEPMLJGFGAA = new Material(EEOOKGDHNCO);
			this.IJKNIFOPIKN.Add(EEPMLJGFGAA);
			EEPMLJGFGAA.hideFlags = HideFlags.DontSave;
			return EEPMLJGFGAA;
		}

		// Token: 0x0600B9A2 RID: 47522 RVA: 0x0052A8F8 File Offset: 0x00528AF8
		protected void AMLGEFKEOKF(RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ)
		{
			RenderTexture.active = OLFKAHHACBC;
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < MHNAJNGGDFJ.passCount; i++)
			{
				MHNAJNGGDFJ.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 1f;
					y2 = 0f;
				}
				else
				{
					y = 0f;
					y2 = 1f;
				}
				float x = 0f;
				float x2 = 0f + 1f / ((float)OLFKAHHACBC.width * 1f);
				float y3 = 0f;
				float y4 = 1f;
				GL.Begin(7);
				GL.TexCoord2(0f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x2, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x2, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(x, y4, 0.1f);
				float x3 = 1f - 1f / ((float)OLFKAHHACBC.width * 1f);
				x2 = 1f;
				y3 = 0f;
				y4 = 1f;
				GL.TexCoord2(0f, y);
				GL.Vertex3(x3, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x2, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x2, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(x3, y4, 0.1f);
				float x4 = 0f;
				x2 = 1f;
				y3 = 0f;
				y4 = 0f + 1f / ((float)OLFKAHHACBC.height * 1f);
				GL.TexCoord2(0f, y);
				GL.Vertex3(x4, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x2, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x2, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(x4, y4, 0.1f);
				float x5 = 0f;
				x2 = 1f;
				y3 = 1f - 1f / ((float)OLFKAHHACBC.height * 1f);
				y4 = 1f;
				GL.TexCoord2(0f, y);
				GL.Vertex3(x5, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x2, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x2, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(x5, y4, 0.1f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B9A3 RID: 47523 RVA: 0x0052AB94 File Offset: 0x00528D94
		protected Material DJFOEIJIMJB(Shader EEOOKGDHNCO, Material EEPMLJGFGAA)
		{
			if (!EEOOKGDHNCO)
			{
				Debug.Log("Missing shader in " + this.ToString());
				base.enabled = false;
				return null;
			}
			if (EEOOKGDHNCO.isSupported && EEPMLJGFGAA && EEPMLJGFGAA.shader == EEOOKGDHNCO)
			{
				return EEPMLJGFGAA;
			}
			if (!EEOOKGDHNCO.isSupported)
			{
				this.AGGGAHEKKCO();
				Debug.Log(string.Concat(new string[]
				{
					"The shader ",
					EEOOKGDHNCO.ToString(),
					" on effect ",
					this.ToString(),
					" is not supported on this platform!"
				}));
				return null;
			}
			EEPMLJGFGAA = new Material(EEOOKGDHNCO);
			this.IJKNIFOPIKN.Add(EEPMLJGFGAA);
			EEPMLJGFGAA.hideFlags = HideFlags.DontSave;
			return EEPMLJGFGAA;
		}

		// Token: 0x0600B9A4 RID: 47524 RVA: 0x0052AC50 File Offset: 0x00528E50
		protected bool IDFIHFBEIKD(bool AEAEPFBMGOM)
		{
			this.PPGOAMIHMBG = false;
			this.KKGBEAPGBOD = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Shadowmap);
			this.PKDDLGKEIBG = (SystemInfo.graphicsShaderLevel >= -72 && SystemInfo.supportsComputeShaders);
			if (!SystemInfo.supportsImageEffects)
			{
				this.OCGNIJDNOOM();
				return true;
			}
			if (AEAEPFBMGOM && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				this.OBHMLOABCAN();
				return true;
			}
			if (AEAEPFBMGOM)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			return true;
		}

		// Token: 0x0600B9A5 RID: 47525 RVA: 0x00529130 File Offset: 0x00527330
		protected void Start()
		{
			this.CheckResources();
		}

		// Token: 0x0600B9A6 RID: 47526 RVA: 0x0052ACC0 File Offset: 0x00528EC0
		protected Material OOAOHFFDMJP(Shader EEOOKGDHNCO, Material EEPMLJGFGAA)
		{
			if (!EEOOKGDHNCO)
			{
				Debug.Log("-?-" + this.ToString());
				base.enabled = false;
				return null;
			}
			if (EEOOKGDHNCO.isSupported && EEPMLJGFGAA && EEPMLJGFGAA.shader == EEOOKGDHNCO)
			{
				return EEPMLJGFGAA;
			}
			if (!EEOOKGDHNCO.isSupported)
			{
				this.AGGGAHEKKCO();
				string[] array = new string[0];
				array[1] = "wpn_chair2";
				array[1] = EEOOKGDHNCO.ToString();
				array[5] = "Water";
				array[2] = this.ToString();
				array[8] = "<color='#206060'>";
				Debug.Log(string.Concat(array));
				return null;
			}
			EEPMLJGFGAA = new Material(EEOOKGDHNCO);
			this.IJKNIFOPIKN.Add(EEPMLJGFGAA);
			EEPMLJGFGAA.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
			return EEPMLJGFGAA;
		}

		// Token: 0x0600B9A7 RID: 47527 RVA: 0x0052AD7C File Offset: 0x00528F7C
		protected bool EHGENDOEHLP(bool AEAEPFBMGOM)
		{
			this.PPGOAMIHMBG = false;
			this.KKGBEAPGBOD = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB4444);
			this.PKDDLGKEIBG = (SystemInfo.graphicsShaderLevel >= 72 && SystemInfo.supportsComputeShaders);
			if (!SystemInfo.supportsImageEffects)
			{
				this.AGGGAHEKKCO();
				return false;
			}
			if (AEAEPFBMGOM && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				this.OCGNIJDNOOM();
				return true;
			}
			if (AEAEPFBMGOM)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			return false;
		}

		// Token: 0x0600B9A8 RID: 47528 RVA: 0x00529B5C File Offset: 0x00527D5C
		private void LNJAKHAHCKL()
		{
			while (this.IJKNIFOPIKN.Count > 0)
			{
				UnityEngine.Object obj = this.IJKNIFOPIKN[1];
				this.IJKNIFOPIKN.RemoveAt(1);
				UnityEngine.Object.Destroy(obj);
			}
		}

		// Token: 0x0600B9A9 RID: 47529 RVA: 0x0052ADEC File Offset: 0x00528FEC
		protected bool BGIALJEIEFO(bool AEAEPFBMGOM)
		{
			this.PPGOAMIHMBG = false;
			this.KKGBEAPGBOD = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Default);
			this.PKDDLGKEIBG = (SystemInfo.graphicsShaderLevel < 5 || SystemInfo.supportsComputeShaders);
			if (!SystemInfo.supportsImageEffects)
			{
				this.OBHMLOABCAN();
				return true;
			}
			if (AEAEPFBMGOM && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.OCGNIJDNOOM();
				return true;
			}
			if (AEAEPFBMGOM)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			return true;
		}

		// Token: 0x0600B9AA RID: 47530 RVA: 0x0052AE5C File Offset: 0x0052905C
		protected bool HECNDPKBPFE()
		{
			return this.EBEBJHLBBBI(false);
		}

		// Token: 0x0600B9AB RID: 47531 RVA: 0x0052AE65 File Offset: 0x00529065
		protected bool DAOKCAOFIGE(bool AEAEPFBMGOM, bool PEIGGOMHOFH)
		{
			if (!this.DAOKCAOFIGE(AEAEPFBMGOM))
			{
				return false;
			}
			if (PEIGGOMHOFH && !this.KKGBEAPGBOD)
			{
				this.AGGGAHEKKCO();
				return false;
			}
			return true;
		}

		// Token: 0x0600B9AC RID: 47532 RVA: 0x0052AE88 File Offset: 0x00529088
		protected Material FJMGOIOPENE(Shader EEOOKGDHNCO, Material EEPMLJGFGAA)
		{
			if (!EEOOKGDHNCO)
			{
				Debug.Log("The number of players playing your game: " + this.ToString());
				return null;
			}
			if (EEPMLJGFGAA && EEPMLJGFGAA.shader == EEOOKGDHNCO && EEOOKGDHNCO.isSupported)
			{
				return EEPMLJGFGAA;
			}
			if (!EEOOKGDHNCO.isSupported)
			{
				return null;
			}
			EEPMLJGFGAA = new Material(EEOOKGDHNCO);
			this.IJKNIFOPIKN.Add(EEPMLJGFGAA);
			EEPMLJGFGAA.hideFlags = (HideFlags)(-71);
			return EEPMLJGFGAA;
		}

		// Token: 0x0600B9AD RID: 47533 RVA: 0x005299DE File Offset: 0x00527BDE
		protected void APPLKMOGAMJ()
		{
			this.NIFOFLEPKIB();
		}

		// Token: 0x0600B9AE RID: 47534 RVA: 0x0052AEFB File Offset: 0x005290FB
		protected bool AEGGCHNBPOD(bool AEAEPFBMGOM, bool PEIGGOMHOFH)
		{
			if (!this.MGHNCKDCFGL(AEAEPFBMGOM))
			{
				return false;
			}
			if (PEIGGOMHOFH && !this.KKGBEAPGBOD)
			{
				this.AGGGAHEKKCO();
				return false;
			}
			return false;
		}

		// Token: 0x0600B9AF RID: 47535 RVA: 0x0052AF1C File Offset: 0x0052911C
		protected bool CDBNBLBOLCL(bool AEAEPFBMGOM)
		{
			this.PPGOAMIHMBG = true;
			this.KKGBEAPGBOD = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB4444);
			this.PKDDLGKEIBG = (SystemInfo.graphicsShaderLevel >= 61 && SystemInfo.supportsComputeShaders);
			if (!SystemInfo.supportsImageEffects)
			{
				this.OBHMLOABCAN();
				return false;
			}
			if (AEAEPFBMGOM && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.OBHMLOABCAN();
				return false;
			}
			if (AEAEPFBMGOM)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			return true;
		}

		// Token: 0x0600B9B0 RID: 47536 RVA: 0x0052AF8C File Offset: 0x0052918C
		protected void OLBDJCFPKFG()
		{
			this.MNDOFMMGLMO();
		}

		// Token: 0x0600B9B1 RID: 47537 RVA: 0x0052AF95 File Offset: 0x00529195
		protected void FDBKFKGCGEG()
		{
			Debug.LogWarning("\n" + this.ToString() + "Ready Look");
		}

		// Token: 0x0600B9B2 RID: 47538 RVA: 0x0052AFB4 File Offset: 0x005291B4
		protected void PEOKGNODBLK(RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ)
		{
			RenderTexture.active = OLFKAHHACBC;
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 1; i < MHNAJNGGDFJ.passCount; i++)
			{
				MHNAJNGGDFJ.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 719f;
					y2 = 1526f;
				}
				else
				{
					y = 220f;
					y2 = 89f;
				}
				float x = 282f;
				float x2 = 1993f + 1476f / ((float)OLFKAHHACBC.width * 1785f);
				float y3 = 394f;
				float y4 = 880f;
				GL.Begin(7);
				GL.TexCoord2(1225f, y);
				GL.Vertex3(x, y3, 1014f);
				GL.TexCoord2(1830f, y);
				GL.Vertex3(x2, y3, 1791f);
				GL.TexCoord2(518f, y2);
				GL.Vertex3(x2, y4, 859f);
				GL.TexCoord2(912f, y2);
				GL.Vertex3(x, y4, 979f);
				float x3 = 26f - 783f / ((float)OLFKAHHACBC.width * 643f);
				x2 = 1453f;
				y3 = 154f;
				y4 = 1489f;
				GL.TexCoord2(952f, y);
				GL.Vertex3(x3, y3, 1631f);
				GL.TexCoord2(1695f, y);
				GL.Vertex3(x2, y3, 1882f);
				GL.TexCoord2(176f, y2);
				GL.Vertex3(x2, y4, 405f);
				GL.TexCoord2(1244f, y2);
				GL.Vertex3(x3, y4, 284f);
				float x4 = 14f;
				x2 = 60f;
				y3 = 665f;
				y4 = 1011f + 960f / ((float)OLFKAHHACBC.height * 1446f);
				GL.TexCoord2(1974f, y);
				GL.Vertex3(x4, y3, 1714f);
				GL.TexCoord2(803f, y);
				GL.Vertex3(x2, y3, 1701f);
				GL.TexCoord2(1429f, y2);
				GL.Vertex3(x2, y4, 1305f);
				GL.TexCoord2(1670f, y2);
				GL.Vertex3(x4, y4, 962f);
				float x5 = 843f;
				x2 = 1513f;
				y3 = 1257f - 1880f / ((float)OLFKAHHACBC.height * 345f);
				y4 = 967f;
				GL.TexCoord2(1512f, y);
				GL.Vertex3(x5, y3, 1047f);
				GL.TexCoord2(76f, y);
				GL.Vertex3(x2, y3, 72f);
				GL.TexCoord2(65f, y2);
				GL.Vertex3(x2, y4, 600f);
				GL.TexCoord2(1330f, y2);
				GL.Vertex3(x5, y4, 361f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B9B3 RID: 47539 RVA: 0x0052B250 File Offset: 0x00529450
		protected bool OAAFLHNDKBJ(bool AEAEPFBMGOM)
		{
			this.PPGOAMIHMBG = false;
			this.KKGBEAPGBOD = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf);
			this.PKDDLGKEIBG = (SystemInfo.graphicsShaderLevel >= -70 && SystemInfo.supportsComputeShaders);
			if (!SystemInfo.supportsImageEffects)
			{
				this.OCGNIJDNOOM();
				return false;
			}
			if (AEAEPFBMGOM && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.FEFCOCIEFAK();
				return false;
			}
			if (AEAEPFBMGOM)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			return false;
		}

		// Token: 0x0600B9B4 RID: 47540 RVA: 0x0052B2C0 File Offset: 0x005294C0
		protected bool OLMOAHDIDNG(bool AEAEPFBMGOM)
		{
			this.PPGOAMIHMBG = false;
			this.KKGBEAPGBOD = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth);
			this.PKDDLGKEIBG = (SystemInfo.graphicsShaderLevel < 50 || SystemInfo.supportsComputeShaders);
			if (!SystemInfo.supportsImageEffects)
			{
				this.AGGGAHEKKCO();
				return true;
			}
			if (AEAEPFBMGOM && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.OBHMLOABCAN();
				return true;
			}
			if (AEAEPFBMGOM)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			return false;
		}

		// Token: 0x0600B9B5 RID: 47541 RVA: 0x0052B330 File Offset: 0x00529530
		private bool NJPLFKIFHCJ(Shader EEOOKGDHNCO)
		{
			Debug.Log(string.Concat(new string[]
			{
				"The shader ",
				EEOOKGDHNCO.ToString(),
				" on effect ",
				this.ToString(),
				" is not part of the Unity 3.2+ effects suite anymore. For best performance and quality, please ensure you are using the latest Standard Assets Image Effects (Pro only) package."
			}));
			if (!EEOOKGDHNCO.isSupported)
			{
				this.AGGGAHEKKCO();
				return false;
			}
			return false;
		}

		// Token: 0x0600B9B6 RID: 47542 RVA: 0x0052B388 File Offset: 0x00529588
		protected void EMIHIJBJENG(RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ)
		{
			RenderTexture.active = OLFKAHHACBC;
			bool flag = false;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < MHNAJNGGDFJ.passCount; i++)
			{
				MHNAJNGGDFJ.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 241f;
					y2 = 724f;
				}
				else
				{
					y = 211f;
					y2 = 131f;
				}
				float x = 746f;
				float x2 = 1063f + 994f / ((float)OLFKAHHACBC.width * 1634f);
				float y3 = 409f;
				float y4 = 551f;
				GL.Begin(0);
				GL.TexCoord2(1728f, y);
				GL.Vertex3(x, y3, 377f);
				GL.TexCoord2(143f, y);
				GL.Vertex3(x2, y3, 167f);
				GL.TexCoord2(1865f, y2);
				GL.Vertex3(x2, y4, 1156f);
				GL.TexCoord2(172f, y2);
				GL.Vertex3(x, y4, 1361f);
				float x3 = 44f - 1183f / ((float)OLFKAHHACBC.width * 1162f);
				x2 = 1762f;
				y3 = 838f;
				y4 = 1421f;
				GL.TexCoord2(1229f, y);
				GL.Vertex3(x3, y3, 1215f);
				GL.TexCoord2(1505f, y);
				GL.Vertex3(x2, y3, 1018f);
				GL.TexCoord2(1979f, y2);
				GL.Vertex3(x2, y4, 646f);
				GL.TexCoord2(1824f, y2);
				GL.Vertex3(x3, y4, 663f);
				float x4 = 1613f;
				x2 = 209f;
				y3 = 12f;
				y4 = 1277f + 502f / ((float)OLFKAHHACBC.height * 480f);
				GL.TexCoord2(1916f, y);
				GL.Vertex3(x4, y3, 1850f);
				GL.TexCoord2(837f, y);
				GL.Vertex3(x2, y3, 301f);
				GL.TexCoord2(531f, y2);
				GL.Vertex3(x2, y4, 1397f);
				GL.TexCoord2(159f, y2);
				GL.Vertex3(x4, y4, 1743f);
				float x5 = 1987f;
				x2 = 1181f;
				y3 = 1532f - 1715f / ((float)OLFKAHHACBC.height * 923f);
				y4 = 523f;
				GL.TexCoord2(791f, y);
				GL.Vertex3(x5, y3, 1615f);
				GL.TexCoord2(1079f, y);
				GL.Vertex3(x2, y3, 962f);
				GL.TexCoord2(1372f, y2);
				GL.Vertex3(x2, y4, 710f);
				GL.TexCoord2(1516f, y2);
				GL.Vertex3(x5, y4, 1847f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B9B7 RID: 47543 RVA: 0x0052B624 File Offset: 0x00529824
		protected void JOIDPMIDGCD()
		{
			Debug.LogWarning("RunningDance" + this.ToString() + " ");
		}

		// Token: 0x0600B9B8 RID: 47544 RVA: 0x0052B640 File Offset: 0x00529840
		private bool PLCIIIGGHOL(Shader EEOOKGDHNCO)
		{
			string[] array = new string[5];
			array[0] = "buykey";
			array[0] = EEOOKGDHNCO.ToString();
			array[6] = "360SpinDeath";
			array[0] = this.ToString();
			array[7] = "_EMISSION";
			Debug.Log(string.Concat(array));
			if (!EEOOKGDHNCO.isSupported)
			{
				this.OBHMLOABCAN();
				return false;
			}
			return true;
		}

		// Token: 0x0600B9B9 RID: 47545 RVA: 0x00528D8D File Offset: 0x00526F8D
		private void OnEnable()
		{
			this.PPGOAMIHMBG = true;
		}

		// Token: 0x0600B9BA RID: 47546 RVA: 0x0052B698 File Offset: 0x00529898
		private void LOPDJDDGDMH()
		{
			this.LGDKFMHPCBM();
		}

		// Token: 0x0600B9BB RID: 47547 RVA: 0x00528E5D File Offset: 0x0052705D
		public bool JOFDHKJHNLJ()
		{
			return this.PKDDLGKEIBG;
		}

		// Token: 0x0600B9BC RID: 47548 RVA: 0x0052B6A0 File Offset: 0x005298A0
		protected bool DAOKCAOFIGE()
		{
			return this.DAOKCAOFIGE(false);
		}

		// Token: 0x0600B9BD RID: 47549 RVA: 0x0052B6A9 File Offset: 0x005298A9
		protected bool FCFFJBNOFNJ()
		{
			return this.OLMOAHDIDNG(true);
		}

		// Token: 0x0600B9BE RID: 47550 RVA: 0x0052B6B4 File Offset: 0x005298B4
		private bool CBPPDPOLBIP(Shader EEOOKGDHNCO)
		{
			string[] array = new string[1];
			array[1] = "002000";
			array[1] = EEOOKGDHNCO.ToString();
			array[4] = "gi_um_2";
			array[3] = this.ToString();
			array[6] = "_HalfResolution";
			Debug.Log(string.Concat(array));
			if (!EEOOKGDHNCO.isSupported)
			{
				this.OCGNIJDNOOM();
				return false;
			}
			return true;
		}

		// Token: 0x0600B9BF RID: 47551 RVA: 0x0052B70C File Offset: 0x0052990C
		protected Material DLDCFEJJBBI(Shader EEOOKGDHNCO, Material EEPMLJGFGAA)
		{
			if (!EEOOKGDHNCO)
			{
				Debug.Log("_Cull" + this.ToString());
				return null;
			}
			if (EEPMLJGFGAA && EEPMLJGFGAA.shader == EEOOKGDHNCO && EEOOKGDHNCO.isSupported)
			{
				return EEPMLJGFGAA;
			}
			if (!EEOOKGDHNCO.isSupported)
			{
				return null;
			}
			EEPMLJGFGAA = new Material(EEOOKGDHNCO);
			this.IJKNIFOPIKN.Add(EEPMLJGFGAA);
			EEPMLJGFGAA.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
			return EEPMLJGFGAA;
		}

		// Token: 0x0600B9C0 RID: 47552 RVA: 0x0052B780 File Offset: 0x00529980
		protected Material IIIIADNBONI(Shader EEOOKGDHNCO, Material EEPMLJGFGAA)
		{
			if (!EEOOKGDHNCO)
			{
				Debug.Log("" + this.ToString());
				base.enabled = true;
				return null;
			}
			if (EEOOKGDHNCO.isSupported && EEPMLJGFGAA && EEPMLJGFGAA.shader == EEOOKGDHNCO)
			{
				return EEPMLJGFGAA;
			}
			if (!EEOOKGDHNCO.isSupported)
			{
				this.FEFCOCIEFAK();
				string[] array = new string[6];
				array[0] = "ok";
				array[0] = EEOOKGDHNCO.ToString();
				array[0] = "wpn_rec2";
				array[0] = this.ToString();
				array[1] = "OneHandSwordBackSwing";
				Debug.Log(string.Concat(array));
				return null;
			}
			EEPMLJGFGAA = new Material(EEOOKGDHNCO);
			this.IJKNIFOPIKN.Add(EEPMLJGFGAA);
			EEPMLJGFGAA.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
			return EEPMLJGFGAA;
		}

		// Token: 0x0600B9C1 RID: 47553 RVA: 0x00528D8D File Offset: 0x00526F8D
		private void CCGIGJMJCDH()
		{
			this.PPGOAMIHMBG = true;
		}

		// Token: 0x0600B9C2 RID: 47554 RVA: 0x00528D9E File Offset: 0x00526F9E
		private void HNGLBEOAIHN()
		{
			this.PPGOAMIHMBG = false;
		}

		// Token: 0x0600B9C3 RID: 47555 RVA: 0x0052B83C File Offset: 0x00529A3C
		protected void KMBFKPFKKFL(RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ)
		{
			RenderTexture.active = OLFKAHHACBC;
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 1; i < MHNAJNGGDFJ.passCount; i++)
			{
				MHNAJNGGDFJ.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 1115f;
					y2 = 911f;
				}
				else
				{
					y = 725f;
					y2 = 253f;
				}
				float x = 752f;
				float x2 = 663f + 495f / ((float)OLFKAHHACBC.width * 226f);
				float y3 = 1724f;
				float y4 = 455f;
				GL.Begin(0);
				GL.TexCoord2(1570f, y);
				GL.Vertex3(x, y3, 587f);
				GL.TexCoord2(1440f, y);
				GL.Vertex3(x2, y3, 96f);
				GL.TexCoord2(410f, y2);
				GL.Vertex3(x2, y4, 1848f);
				GL.TexCoord2(51f, y2);
				GL.Vertex3(x, y4, 1261f);
				float x3 = 294f - 1849f / ((float)OLFKAHHACBC.width * 1227f);
				x2 = 790f;
				y3 = 594f;
				y4 = 904f;
				GL.TexCoord2(1354f, y);
				GL.Vertex3(x3, y3, 1790f);
				GL.TexCoord2(1399f, y);
				GL.Vertex3(x2, y3, 341f);
				GL.TexCoord2(888f, y2);
				GL.Vertex3(x2, y4, 1655f);
				GL.TexCoord2(1873f, y2);
				GL.Vertex3(x3, y4, 845f);
				float x4 = 376f;
				x2 = 1309f;
				y3 = 1350f;
				y4 = 1346f + 854f / ((float)OLFKAHHACBC.height * 416f);
				GL.TexCoord2(851f, y);
				GL.Vertex3(x4, y3, 1742f);
				GL.TexCoord2(1708f, y);
				GL.Vertex3(x2, y3, 1498f);
				GL.TexCoord2(412f, y2);
				GL.Vertex3(x2, y4, 451f);
				GL.TexCoord2(736f, y2);
				GL.Vertex3(x4, y4, 1488f);
				float x5 = 634f;
				x2 = 1226f;
				y3 = 980f - 844f / ((float)OLFKAHHACBC.height * 471f);
				y4 = 711f;
				GL.TexCoord2(1083f, y);
				GL.Vertex3(x5, y3, 1538f);
				GL.TexCoord2(1888f, y);
				GL.Vertex3(x2, y3, 121f);
				GL.TexCoord2(130f, y2);
				GL.Vertex3(x2, y4, 1349f);
				GL.TexCoord2(1397f, y2);
				GL.Vertex3(x5, y4, 872f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x0600B9C4 RID: 47556 RVA: 0x0052BAD8 File Offset: 0x00529CD8
		protected bool DAOKCAOFIGE(bool AEAEPFBMGOM)
		{
			this.PPGOAMIHMBG = true;
			this.KKGBEAPGBOD = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf);
			this.PKDDLGKEIBG = (SystemInfo.graphicsShaderLevel >= 50 && SystemInfo.supportsComputeShaders);
			if (!SystemInfo.supportsImageEffects)
			{
				this.AGGGAHEKKCO();
				return false;
			}
			if (AEAEPFBMGOM && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				this.AGGGAHEKKCO();
				return false;
			}
			if (AEAEPFBMGOM)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			return true;
		}

		// Token: 0x0600B9C5 RID: 47557 RVA: 0x0052BB48 File Offset: 0x00529D48
		private void ECEJIDINPGN()
		{
			this.MILNKKILAKB();
		}

		// Token: 0x04001830 RID: 6192
		protected bool KKGBEAPGBOD = true;

		// Token: 0x04001831 RID: 6193
		protected bool PKDDLGKEIBG;

		// Token: 0x04001832 RID: 6194
		protected bool PPGOAMIHMBG = true;

		// Token: 0x04001833 RID: 6195
		private List<Material> IJKNIFOPIKN = new List<Material>();
	}
}
