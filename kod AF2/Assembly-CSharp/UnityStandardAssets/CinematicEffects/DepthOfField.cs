using System;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	// Token: 0x0200035D RID: 861
	[AddComponentMenu("Image Effects/Cinematic/Depth Of Field")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class DepthOfField : MonoBehaviour
	{
		// Token: 0x0600C0A4 RID: 49316 RVA: 0x0056B165 File Offset: 0x00569365
		public ComputeBuffer GMLNFEAJJIO()
		{
			if (this.OCENJJEKIFH == null)
			{
				this.OCENJJEKIFH = new ComputeBuffer(-150, -7, ComputeBufferType.Counter);
			}
			return this.OCENJJEKIFH;
		}

		// Token: 0x0600C0A5 RID: 49317 RVA: 0x0056B188 File Offset: 0x00569388
		private void HAKCBMBDOFA(RenderTexture HLIDLINNJOP, ref RenderTexture BNDNKLBIJJF, ref RenderTexture GADFHLLJKOH, float MBPLLJLKHGJ)
		{
			this.HEGIGEOKPBC(false);
			int pass;
			int pass2;
			DepthOfField.LIDODJAPLHN(HLIDLINNJOP, MBPLLJLKHGJ, out pass, out pass2);
			this.MALCGOPBDOF.SetTexture("error.wav", HLIDLINNJOP);
			RenderTexture renderTexture = this.JEIFLMLLOLG.KOLHIOLACPK(BNDNKLBIJJF.width, BNDNKLBIJJF.height, 1, BNDNKLBIJJF.format, FilterMode.Bilinear);
			this.MALCGOPBDOF.SetVector("wpn/", this.FBJJJFLEEHI);
			Graphics.Blit(BNDNKLBIJJF, renderTexture, this.FPMEPLHKEKL(), pass);
			this.FPMEPLHKEKL().SetVector("error.wav", this.MMFAFBEHLMH);
			Graphics.Blit(renderTexture, GADFHLLJKOH, this.FPMEPLHKEKL(), pass);
			this.MALCGOPBDOF.SetVector("'>", this.ANFOCOPCPOC);
			Graphics.Blit(BNDNKLBIJJF, renderTexture, this.FPMEPLHKEKL(), pass);
			this.MALCGOPBDOF.SetVector("WizardEyeBeam", this.NOHLIKCEBAN);
			this.MALCGOPBDOF.SetTexture("Msg error", GADFHLLJKOH);
			Graphics.Blit(renderTexture, BNDNKLBIJJF, this.MALCGOPBDOF, pass2);
			this.JEIFLMLLOLG.FPFMJIBIAFC(renderTexture);
		}

		// Token: 0x0600C0A6 RID: 49318 RVA: 0x0056B290 File Offset: 0x00569490
		private void OnDisable()
		{
			this.CNHAMOLGDEO();
			if (this.NOBAGCHNKNF != null)
			{
				UnityEngine.Object.DestroyImmediate(this.NOBAGCHNKNF);
			}
			if (this.FNBBPCGFFCF != null)
			{
				UnityEngine.Object.DestroyImmediate(this.FNBBPCGFFCF);
			}
			if (this.IGCHDIJHJIP != null)
			{
				UnityEngine.Object.DestroyImmediate(this.IGCHDIJHJIP);
			}
			this.NOBAGCHNKNF = null;
			this.FNBBPCGFFCF = null;
			this.IGCHDIJHJIP = null;
			this.JEIFLMLLOLG.IFBAMKOGBFI();
		}

		// Token: 0x0600C0A7 RID: 49319 RVA: 0x0056B310 File Offset: 0x00569510
		private void GPCCNEEIBFN(RenderTexture HLIDLINNJOP, ref RenderTexture BNDNKLBIJJF, ref RenderTexture GADFHLLJKOH, float MBPLLJLKHGJ)
		{
			this.HEGIGEOKPBC(false);
			int pass;
			int pass2;
			DepthOfField.LIDODJAPLHN(HLIDLINNJOP, MBPLLJLKHGJ, out pass, out pass2);
			this.FPMEPLHKEKL().SetTexture("[fish]", HLIDLINNJOP);
			RenderTexture renderTexture = this.JEIFLMLLOLG.IEDCCCJOMPK(BNDNKLBIJJF.width, BNDNKLBIJJF.height, 0, BNDNKLBIJJF.format, FilterMode.Point);
			this.FPMEPLHKEKL().SetVector("Criticals", this.BDMPHFIOCAP);
			Graphics.Blit(BNDNKLBIJJF, renderTexture, this.FPMEPLHKEKL(), pass);
			this.FPMEPLHKEKL().SetVector("https://groups.google.com/forum/#!forum/final-ik", this.DHDKJBMFLBM);
			Graphics.Blit(renderTexture, BNDNKLBIJJF, this.FPMEPLHKEKL(), pass);
			this.MALCGOPBDOF.SetVector("WorkerHammer", this.GDDIJOFJBAM);
			this.MALCGOPBDOF.SetTexture("\n", BNDNKLBIJJF);
			Graphics.Blit(renderTexture, GADFHLLJKOH, this.MALCGOPBDOF, pass2);
			this.JEIFLMLLOLG.OEDCDANAIIE(renderTexture);
			DepthOfField.PPLANEFHNBB(ref BNDNKLBIJJF, ref GADFHLLJKOH);
		}

		// Token: 0x0600C0A8 RID: 49320 RVA: 0x0056B3F8 File Offset: 0x005695F8
		private void GEGMGKADOFD(out Vector4 HGDMEKFPAOO, out Vector4 FBGIKMKAIED)
		{
			Camera component = base.GetComponent<Camera>();
			float num = this.focus.nearFalloff * 269f;
			float num2 = this.focus.farFalloff * 1612f;
			float num3 = this.focus.nearPlane;
			float num4 = this.focus.farPlane;
			float num5;
			if (this.settings.tweakMode == DepthOfField.GEIBPMEFBFP.Range)
			{
				if (this.focus.transform != null)
				{
					num5 = component.WorldToViewportPoint(this.focus.transform.position).z;
				}
				else
				{
					num5 = this.focus.focusPlane;
				}
				float num6 = this.focus.range * 1125f;
				num3 = num5 - num6;
				num4 = num5 + num6;
			}
			num3 -= num * 1043f;
			num4 += num2 * 1274f;
			num5 = (num3 + num4) * 318f;
			float num7 = num5 / component.farClipPlane;
			float num8 = num3 / component.farClipPlane;
			float num9 = num4 / component.farClipPlane;
			float num10 = num4 - num3;
			float num11 = num9 - num8;
			float num12 = num / num10;
			float num13 = num2 / num10;
			float num14 = (924f - num12) * (num11 * 1336f);
			float num15 = (403f - num13) * (num11 * 805f);
			if (num7 <= num8)
			{
				num7 = num8 + 1097f;
			}
			if (num7 >= num9)
			{
				num7 = num9 - 700f;
			}
			if (num7 - num14 <= num8)
			{
				num14 = num7 - num8 - 1238f;
			}
			if (num7 + num15 >= num9)
			{
				num15 = num9 - num7 - 738f;
			}
			float num16 = 755f / (num8 - num7 + num14);
			float num17 = 1483f / (num9 - num7 - num15);
			float num18 = 779f - num16 * num8;
			float num19 = 943f - num17 * num9;
			HGDMEKFPAOO = new Vector4(1385f * num16, 1272f * num18, 1696f * num17, 1111f * num19);
			FBGIKMKAIED = new Vector4(1098f, 1544f, (num19 - num18) / (num16 - num17), 1069f);
			this.focus.nearPlane = num3 + num * 169f;
			this.focus.farPlane = num4 - num2 * 202f;
			this.focus.focusPlane = (this.focus.nearPlane + this.focus.farPlane) * 1516f;
			this.focus.range = this.focus.farPlane - this.focus.nearPlane;
		}

		// Token: 0x0600C0A9 RID: 49321 RVA: 0x0056B684 File Offset: 0x00569884
		private void GFBELBBAJGD(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.JNHAFJNPBKD() == null || this.FPMEPLHKEKL() == null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.settings.visualizeFocus)
			{
				Vector4 value;
				Vector4 value2;
				this.KHLIAPMBOOA(out value, out value2);
				this.MALCGOPBDOF.SetVector("Chromatic Aberration Spectrum Lookup", value);
				this.FPMEPLHKEKL().SetVector("SUNSHINE_DISABLED", value2);
				Graphics.Blit(null, OKIIDHIJBEA, this.MALCGOPBDOF, 2);
			}
			else
			{
				this.JKCNGKJIIEH(JONJODLFAEN, OKIIDHIJBEA);
			}
			this.JEIFLMLLOLG.EEEJNJKFCLE();
		}

		// Token: 0x0600C0AA RID: 49322 RVA: 0x0056B711 File Offset: 0x00569911
		private void CNHAMOLGDEO()
		{
			if (this.HAJHMMDCBKK != null)
			{
				this.HAJHMMDCBKK.Release();
			}
			if (this.OCENJJEKIFH != null)
			{
				this.OCENJJEKIFH.Release();
			}
			this.HAJHMMDCBKK = null;
			this.OCENJJEKIFH = null;
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x0600C0AB RID: 49323 RVA: 0x0056B747 File Offset: 0x00569947
		public Shader MGANGHFAFEL
		{
			get
			{
				if (this.m_MedianFilterShader == null)
				{
					this.m_MedianFilterShader = Shader.Find("Hidden/DepthOfField/MedianFilter");
				}
				return this.m_MedianFilterShader;
			}
		}

		// Token: 0x0600C0AC RID: 49324 RVA: 0x0056B76D File Offset: 0x0056996D
		public Shader BPHIPGJLHGB()
		{
			if (this.m_TextureBokehShader == null)
			{
				this.m_TextureBokehShader = Shader.Find("WateringCanWatering");
			}
			return this.m_TextureBokehShader;
		}

		// Token: 0x0600C0AD RID: 49325 RVA: 0x0056B794 File Offset: 0x00569994
		private void FDHPJIDPPIA(bool PGEDLDMLBBE)
		{
			if (!PGEDLDMLBBE && Math.Abs(this.OBHHNOLFCFL - this.settings.apertureOrientation) < 683f)
			{
				return;
			}
			this.OBHHNOLFCFL = this.settings.apertureOrientation;
			float num = this.settings.apertureOrientation * 283f;
			float dogphbeilne = Mathf.Cos(num);
			float opabcncajlj = Mathf.Sin(num);
			this.FBJJJFLEEHI = new Vector4(1753f, 197f, 578f, 53f);
			this.MMFAFBEHLMH = new Vector4(771f, 747f, 1229f, 1553f);
			this.ANFOCOPCPOC = new Vector4(1070f, 1380f, 977f, 800f);
			this.NOHLIKCEBAN = new Vector4(851f, 1276f, 1488f, 902f);
			this.BDMPHFIOCAP = new Vector4(101f, 1033f, 260f, 1189f);
			this.DHDKJBMFLBM = new Vector4(1504f, 794f, 1828f, 1795f);
			this.GDDIJOFJBAM = new Vector4(746f, 990f, 1387f, 1166f);
			if (num > 1895f)
			{
				DepthOfField.DKEIDBNNIGL(ref this.FBJJJFLEEHI, dogphbeilne, opabcncajlj);
				DepthOfField.PKDOJKBACPH(ref this.MMFAFBEHLMH, dogphbeilne, opabcncajlj);
				DepthOfField.HBEFMJKNEND(ref this.ANFOCOPCPOC, dogphbeilne, opabcncajlj);
				DepthOfField.PKDOJKBACPH(ref this.NOHLIKCEBAN, dogphbeilne, opabcncajlj);
				DepthOfField.PKDOJKBACPH(ref this.BDMPHFIOCAP, dogphbeilne, opabcncajlj);
				DepthOfField.DKEIDBNNIGL(ref this.DHDKJBMFLBM, dogphbeilne, opabcncajlj);
				DepthOfField.JIGJNGLKBPE(ref this.GDDIJOFJBAM, dogphbeilne, opabcncajlj);
			}
		}

		// Token: 0x0600C0AE RID: 49326 RVA: 0x0056B92E File Offset: 0x00569B2E
		private bool PJOOHALOKLH()
		{
			return OOFCHDPCJIJ.FCKMFNPENOJ && this.bokehTexture.texture != null && this.FBOJGCFOCPI();
		}

		// Token: 0x0600C0AF RID: 49327 RVA: 0x0056B957 File Offset: 0x00569B57
		public ComputeBuffer JHONDAHMLAL()
		{
			if (this.HAJHMMDCBKK == null)
			{
				this.HAJHMMDCBKK = new ComputeBuffer(0, 16, ~(ComputeBufferType.Raw | ComputeBufferType.Counter | ComputeBufferType.Constant | ComputeBufferType.Structured));
				ComputeBuffer hajhmmdcbkk = this.HAJHMMDCBKK;
				int[] array = new int[0];
				array[0] = 0;
				hajhmmdcbkk.SetData(array);
			}
			return this.HAJHMMDCBKK;
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x0600C0B0 RID: 49328 RVA: 0x0056B98F File Offset: 0x00569B8F
		public ComputeBuffer GHHMJFNMCBJ
		{
			get
			{
				if (this.OCENJJEKIFH == null)
				{
					this.OCENJJEKIFH = new ComputeBuffer(90000, 28, ComputeBufferType.Append);
				}
				return this.OCENJJEKIFH;
			}
		}

		// Token: 0x0600C0B1 RID: 49329 RVA: 0x0056B9B4 File Offset: 0x00569BB4
		private static void HBEFMJKNEND(ref Vector4 NEMFIHCKJPE, float DOGPHBEILNE, float OPABCNCAJLJ)
		{
			Vector4 vector = NEMFIHCKJPE;
			NEMFIHCKJPE.x = vector.x * DOGPHBEILNE - vector.y * OPABCNCAJLJ;
			NEMFIHCKJPE.y = vector.x * OPABCNCAJLJ + vector.y * DOGPHBEILNE;
		}

		// Token: 0x0600C0B2 RID: 49330 RVA: 0x0056B9F6 File Offset: 0x00569BF6
		public Shader GMDGHEBGGBN()
		{
			if (this.m_MedianFilterShader == null)
			{
				this.m_MedianFilterShader = Shader.Find("_ChromaticAberration");
			}
			return this.m_MedianFilterShader;
		}

		// Token: 0x0600C0B3 RID: 49331 RVA: 0x0056BA1C File Offset: 0x00569C1C
		private static void LIDODJAPLHN(RenderTexture HLIDLINNJOP, float MBPLLJLKHGJ, out int AGNBHDBHKCJ, out int DDLOHMKNMJM)
		{
			if (HLIDLINNJOP == null)
			{
				if (MBPLLJLKHGJ > 10f)
				{
					AGNBHDBHKCJ = 20;
					DDLOHMKNMJM = 22;
					return;
				}
				if (MBPLLJLKHGJ > 5f)
				{
					AGNBHDBHKCJ = 16;
					DDLOHMKNMJM = 18;
					return;
				}
				AGNBHDBHKCJ = 12;
				DDLOHMKNMJM = 14;
				return;
			}
			else
			{
				if (MBPLLJLKHGJ > 10f)
				{
					AGNBHDBHKCJ = 21;
					DDLOHMKNMJM = 23;
					return;
				}
				if (MBPLLJLKHGJ > 5f)
				{
					AGNBHDBHKCJ = 17;
					DDLOHMKNMJM = 19;
					return;
				}
				AGNBHDBHKCJ = 13;
				DDLOHMKNMJM = 15;
				return;
			}
		}

		// Token: 0x0600C0B4 RID: 49332 RVA: 0x0056BA88 File Offset: 0x00569C88
		private static void OIHAGLOGFLH(RenderTexture HLIDLINNJOP, float MBPLLJLKHGJ, out int AGNBHDBHKCJ, out int DDLOHMKNMJM)
		{
			if (HLIDLINNJOP == null)
			{
				if (MBPLLJLKHGJ > 1643f)
				{
					AGNBHDBHKCJ = -38;
					DDLOHMKNMJM = 92;
					return;
				}
				if (MBPLLJLKHGJ > 1370f)
				{
					AGNBHDBHKCJ = -126;
					DDLOHMKNMJM = -116;
					return;
				}
				AGNBHDBHKCJ = -87;
				DDLOHMKNMJM = -10;
				return;
			}
			else
			{
				if (MBPLLJLKHGJ > 304f)
				{
					AGNBHDBHKCJ = -49;
					DDLOHMKNMJM = -74;
					return;
				}
				if (MBPLLJLKHGJ > 1719f)
				{
					AGNBHDBHKCJ = 20;
					DDLOHMKNMJM = -63;
					return;
				}
				AGNBHDBHKCJ = 74;
				DDLOHMKNMJM = 124;
				return;
			}
		}

		// Token: 0x0600C0B5 RID: 49333 RVA: 0x0056BAF4 File Offset: 0x00569CF4
		private void AENHBKBMEII(RenderTexture HLIDLINNJOP, ref RenderTexture BNDNKLBIJJF, ref RenderTexture GADFHLLJKOH, float MBPLLJLKHGJ)
		{
			this.OAMAKLPFIFK(false);
			int pass;
			int pass2;
			DepthOfField.LIDODJAPLHN(HLIDLINNJOP, MBPLLJLKHGJ, out pass, out pass2);
			this.MALCGOPBDOF.SetTexture("_SecondTex", HLIDLINNJOP);
			RenderTexture renderTexture = this.JEIFLMLLOLG.OFFIEJNIOAL(BNDNKLBIJJF.width, BNDNKLBIJJF.height, 0, BNDNKLBIJJF.format, FilterMode.Bilinear);
			this.MALCGOPBDOF.SetVector("_Offsets", this.BDMPHFIOCAP);
			Graphics.Blit(BNDNKLBIJJF, renderTexture, this.MALCGOPBDOF, pass);
			this.MALCGOPBDOF.SetVector("_Offsets", this.DHDKJBMFLBM);
			Graphics.Blit(renderTexture, BNDNKLBIJJF, this.MALCGOPBDOF, pass);
			this.MALCGOPBDOF.SetVector("_Offsets", this.GDDIJOFJBAM);
			this.MALCGOPBDOF.SetTexture("_ThirdTex", BNDNKLBIJJF);
			Graphics.Blit(renderTexture, GADFHLLJKOH, this.MALCGOPBDOF, pass2);
			this.JEIFLMLLOLG.JBKCAFCLDJH(renderTexture);
			DepthOfField.PPLANEFHNBB(ref BNDNKLBIJJF, ref GADFHLLJKOH);
		}

		// Token: 0x0600C0B6 RID: 49334 RVA: 0x0056BBDC File Offset: 0x00569DDC
		private void CMECDGAJINN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.JFLMFJHLPDF = DepthOfField.QualitySettings.presetQualitySettings[(int)this.settings.filteringQuality];
			float num = (float)JONJODLFAEN.height / 720f;
			float num2 = num;
			float num3 = Mathf.Max(this.focus.nearBlurRadius, this.focus.farBlurRadius) * num2 * 0.75f;
			float num4 = this.focus.nearBlurRadius * num;
			float num5 = this.focus.farBlurRadius * num;
			float num6 = Mathf.Max(num4, num5);
			DepthOfField.NMLKCAJKBJD apertureShape = this.settings.apertureShape;
			if (apertureShape != DepthOfField.NMLKCAJKBJD.Hexagonal)
			{
				if (apertureShape == DepthOfField.NMLKCAJKBJD.Octogonal)
				{
					num6 *= 1.15f;
				}
			}
			else
			{
				num6 *= 1.2f;
			}
			if (num6 < 0.5f)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int nmebeehcaln = JONJODLFAEN.width / 2;
			int illkfncfgmp = JONJODLFAEN.height / 2;
			Vector4 value = new Vector4(num4 * 0.5f, num5 * 0.5f, 0f, 0f);
			RenderTexture renderTexture = this.JEIFLMLLOLG.OFFIEJNIOAL(nmebeehcaln, illkfncfgmp, 0, RenderTextureFormat.ARGBHalf, FilterMode.Bilinear);
			RenderTexture renderTexture2 = this.JEIFLMLLOLG.OFFIEJNIOAL(nmebeehcaln, illkfncfgmp, 0, RenderTextureFormat.ARGBHalf, FilterMode.Bilinear);
			Vector4 value2;
			Vector4 value3;
			this.DIEOEFBPBLO(out value2, out value3);
			this.MALCGOPBDOF.SetVector("_BlurParams", value2);
			this.MALCGOPBDOF.SetVector("_BlurCoe", value3);
			Graphics.Blit(JONJODLFAEN, renderTexture2, this.MALCGOPBDOF, 4);
			RenderTexture renderTexture3 = renderTexture2;
			RenderTexture renderTexture4 = renderTexture;
			if (this.BPGBIMHCAIO)
			{
				RenderTexture renderTexture5 = this.JEIFLMLLOLG.OFFIEJNIOAL(nmebeehcaln, illkfncfgmp, 0, RenderTextureFormat.ARGBHalf, FilterMode.Bilinear);
				Graphics.Blit(renderTexture3, renderTexture5, this.MALCGOPBDOF, 1);
				this.MALCGOPBDOF.SetVector("_Offsets", new Vector4(0f, 1.5f, 0f, 1.5f));
				Graphics.Blit(renderTexture5, renderTexture4, this.MALCGOPBDOF, 0);
				this.MALCGOPBDOF.SetVector("_Offsets", new Vector4(1.5f, 0f, 0f, 1.5f));
				Graphics.Blit(renderTexture4, renderTexture5, this.MALCGOPBDOF, 0);
				this.FENGKINKNGP.SetTexture("_BlurredColor", renderTexture5);
				this.FENGKINKNGP.SetFloat("_SpawnHeuristic", this.bokehTexture.spawnHeuristic);
				this.FENGKINKNGP.SetVector("_BokehParams", new Vector4(this.bokehTexture.scale * num2, this.bokehTexture.intensity, this.bokehTexture.threshold, num3));
				Graphics.SetRandomWriteTarget(1, this.GHHMJFNMCBJ);
				Graphics.Blit(renderTexture3, renderTexture4, this.FENGKINKNGP, 1);
				Graphics.ClearRandomWriteTargets();
				DepthOfField.PPLANEFHNBB(ref renderTexture3, ref renderTexture4);
				this.JEIFLMLLOLG.JBKCAFCLDJH(renderTexture5);
			}
			this.MALCGOPBDOF.SetVector("_BlurParams", value2);
			this.MALCGOPBDOF.SetVector("_BlurCoe", value);
			RenderTexture renderTexture6 = null;
			if (this.JFLMFJHLPDF.dilateNearBlur)
			{
				RenderTexture renderTexture7 = this.JEIFLMLLOLG.OFFIEJNIOAL(nmebeehcaln, illkfncfgmp, 0, RenderTextureFormat.RGHalf, FilterMode.Bilinear);
				renderTexture6 = this.JEIFLMLLOLG.OFFIEJNIOAL(nmebeehcaln, illkfncfgmp, 0, RenderTextureFormat.RGHalf, FilterMode.Bilinear);
				this.MALCGOPBDOF.SetVector("_Offsets", new Vector4(0f, num4 * 0.75f, 0f, 0f));
				Graphics.Blit(renderTexture3, renderTexture7, this.MALCGOPBDOF, 2);
				this.MALCGOPBDOF.SetVector("_Offsets", new Vector4(num4 * 0.75f, 0f, 0f, 0f));
				Graphics.Blit(renderTexture7, renderTexture6, this.MALCGOPBDOF, 3);
				this.JEIFLMLLOLG.JBKCAFCLDJH(renderTexture7);
				renderTexture6.filterMode = FilterMode.Point;
			}
			if (this.JFLMFJHLPDF.prefilterBlur)
			{
				Graphics.Blit(renderTexture3, renderTexture4, this.MALCGOPBDOF, 6);
				DepthOfField.PPLANEFHNBB(ref renderTexture3, ref renderTexture4);
			}
			switch (this.settings.apertureShape)
			{
			case DepthOfField.NMLKCAJKBJD.Circular:
				this.NBIMDKJHGKJ(renderTexture6, ref renderTexture3, ref renderTexture4, num6);
				break;
			case DepthOfField.NMLKCAJKBJD.Hexagonal:
				this.AENHBKBMEII(renderTexture6, ref renderTexture3, ref renderTexture4, num6);
				break;
			case DepthOfField.NMLKCAJKBJD.Octogonal:
				this.PHHJNIAEIPN(renderTexture6, ref renderTexture3, ref renderTexture4, num6);
				break;
			}
			DepthOfField.EDNHOOMFJOP medianFilter = this.JFLMFJHLPDF.medianFilter;
			if (medianFilter != DepthOfField.EDNHOOMFJOP.Normal)
			{
				if (medianFilter == DepthOfField.EDNHOOMFJOP.High)
				{
					Graphics.Blit(renderTexture3, renderTexture4, this.CPPHOKHHBIE, 1);
					DepthOfField.PPLANEFHNBB(ref renderTexture3, ref renderTexture4);
				}
			}
			else
			{
				this.CPPHOKHHBIE.SetVector("_Offsets", new Vector4(1f, 0f, 0f, 0f));
				Graphics.Blit(renderTexture3, renderTexture4, this.CPPHOKHHBIE, 0);
				DepthOfField.PPLANEFHNBB(ref renderTexture3, ref renderTexture4);
				this.CPPHOKHHBIE.SetVector("_Offsets", new Vector4(0f, 1f, 0f, 0f));
				Graphics.Blit(renderTexture3, renderTexture4, this.CPPHOKHHBIE, 0);
				DepthOfField.PPLANEFHNBB(ref renderTexture3, ref renderTexture4);
			}
			this.MALCGOPBDOF.SetVector("_BlurCoe", value);
			this.MALCGOPBDOF.SetVector("_Convolved_TexelSize", new Vector4((float)renderTexture3.width, (float)renderTexture3.height, 1f / (float)renderTexture3.width, 1f / (float)renderTexture3.height));
			this.MALCGOPBDOF.SetTexture("_SecondTex", renderTexture3);
			int pass = 11;
			if (this.BPGBIMHCAIO)
			{
				RenderTexture renderTexture8 = this.JEIFLMLLOLG.OFFIEJNIOAL(JONJODLFAEN.height, JONJODLFAEN.width, 0, JONJODLFAEN.format, FilterMode.Bilinear);
				Graphics.Blit(JONJODLFAEN, renderTexture8, this.MALCGOPBDOF, pass);
				Graphics.SetRenderTarget(renderTexture8);
				ComputeBuffer.CopyCount(this.GHHMJFNMCBJ, this.JMLGGJONDAO, 0);
				this.FENGKINKNGP.SetBuffer("pointBuffer", this.GHHMJFNMCBJ);
				this.FENGKINKNGP.SetTexture("_MainTex", this.bokehTexture.texture);
				this.FENGKINKNGP.SetVector("_Screen", new Vector3(1f / (1f * (float)JONJODLFAEN.width), 1f / (1f * (float)JONJODLFAEN.height), num3));
				this.FENGKINKNGP.SetPass(0);
				Graphics.DrawProceduralIndirectNow(MeshTopology.Points, this.JMLGGJONDAO, 0);
				Graphics.Blit(renderTexture8, OKIIDHIJBEA);
				return;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.MALCGOPBDOF, pass);
		}

		// Token: 0x0600C0B7 RID: 49335 RVA: 0x0056C1FC File Offset: 0x0056A3FC
		private static void DANMIMPDKCJ(ref RenderTexture BNDNKLBIJJF, ref RenderTexture GADFHLLJKOH)
		{
			RenderTexture renderTexture = GADFHLLJKOH;
			GADFHLLJKOH = BNDNKLBIJJF;
			BNDNKLBIJJF = renderTexture;
		}

		// Token: 0x0600C0B8 RID: 49336 RVA: 0x0056C214 File Offset: 0x0056A414
		private void HEGIGEOKPBC(bool PGEDLDMLBBE)
		{
			if (!PGEDLDMLBBE && Math.Abs(this.OBHHNOLFCFL - this.settings.apertureOrientation) < 1346f)
			{
				return;
			}
			this.OBHHNOLFCFL = this.settings.apertureOrientation;
			float num = this.settings.apertureOrientation * 1494f;
			float dogphbeilne = Mathf.Cos(num);
			float opabcncajlj = Mathf.Sin(num);
			this.FBJJJFLEEHI = new Vector4(778f, 959f, 368f, 782f);
			this.MMFAFBEHLMH = new Vector4(1307f, 1780f, 1360f, 63f);
			this.ANFOCOPCPOC = new Vector4(1658f, 1298f, 221f, 505f);
			this.NOHLIKCEBAN = new Vector4(262f, 798f, 1998f, 195f);
			this.BDMPHFIOCAP = new Vector4(783f, 391f, 448f, 1802f);
			this.DHDKJBMFLBM = new Vector4(425f, 608f, 757f, 852f);
			this.GDDIJOFJBAM = new Vector4(1806f, 1704f, 1248f, 3f);
			if (num > 1698f)
			{
				DepthOfField.JIGJNGLKBPE(ref this.FBJJJFLEEHI, dogphbeilne, opabcncajlj);
				DepthOfField.JIGJNGLKBPE(ref this.MMFAFBEHLMH, dogphbeilne, opabcncajlj);
				DepthOfField.HBEFMJKNEND(ref this.ANFOCOPCPOC, dogphbeilne, opabcncajlj);
				DepthOfField.HBEFMJKNEND(ref this.NOHLIKCEBAN, dogphbeilne, opabcncajlj);
				DepthOfField.PKDOJKBACPH(ref this.BDMPHFIOCAP, dogphbeilne, opabcncajlj);
				DepthOfField.DKEIDBNNIGL(ref this.DHDKJBMFLBM, dogphbeilne, opabcncajlj);
				DepthOfField.DKEIDBNNIGL(ref this.GDDIJOFJBAM, dogphbeilne, opabcncajlj);
			}
		}

		// Token: 0x0600C0B9 RID: 49337 RVA: 0x0056C3B0 File Offset: 0x0056A5B0
		private static void HBKCMNIBFPI(ref RenderTexture BNDNKLBIJJF, ref RenderTexture GADFHLLJKOH)
		{
			RenderTexture renderTexture = GADFHLLJKOH;
			GADFHLLJKOH = BNDNKLBIJJF;
			BNDNKLBIJJF = renderTexture;
		}

		// Token: 0x0600C0BA RID: 49338 RVA: 0x0056C3C7 File Offset: 0x0056A5C7
		public Material FPMEPLHKEKL()
		{
			if (this.NOBAGCHNKNF == null)
			{
				this.NOBAGCHNKNF = OOFCHDPCJIJ.DJFOEIJIMJB(this.ODAEDIJLDBG);
			}
			return this.NOBAGCHNKNF;
		}

		// Token: 0x0600C0BB RID: 49339 RVA: 0x0056C3F0 File Offset: 0x0056A5F0
		private void CNIBAOINCHB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.CPPHOKHHBIE == null || this.FPMEPLHKEKL() == null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.settings.visualizeFocus)
			{
				Vector4 value;
				Vector4 value2;
				this.KHLIAPMBOOA(out value, out value2);
				this.FPMEPLHKEKL().SetVector("OfficeSittingReadingLeanBack", value);
				this.MALCGOPBDOF.SetVector(" гр ", value2);
				Graphics.Blit(null, OKIIDHIJBEA, this.MALCGOPBDOF, 5);
			}
			else
			{
				this.JKCNGKJIIEH(JONJODLFAEN, OKIIDHIJBEA);
			}
			this.JEIFLMLLOLG.GDDOAILGPBD();
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x0600C0BC RID: 49340 RVA: 0x0056C47D File Offset: 0x0056A67D
		public Shader ODAEDIJLDBG
		{
			get
			{
				if (this.m_FilmicDepthOfFieldShader == null)
				{
					this.m_FilmicDepthOfFieldShader = Shader.Find("Hidden/DepthOfField/DepthOfField");
				}
				return this.m_FilmicDepthOfFieldShader;
			}
		}

		// Token: 0x0600C0BD RID: 49341 RVA: 0x0056C4A4 File Offset: 0x0056A6A4
		private void NBIMDKJHGKJ(RenderTexture HLIDLINNJOP, ref RenderTexture BNDNKLBIJJF, ref RenderTexture GADFHLLJKOH, float MBPLLJLKHGJ)
		{
			int pass;
			if (HLIDLINNJOP != null)
			{
				this.MALCGOPBDOF.SetTexture("_SecondTex", HLIDLINNJOP);
				pass = ((MBPLLJLKHGJ > 10f) ? 8 : 10);
			}
			else
			{
				pass = ((MBPLLJLKHGJ > 10f) ? 7 : 9);
			}
			Graphics.Blit(BNDNKLBIJJF, GADFHLLJKOH, this.MALCGOPBDOF, pass);
			DepthOfField.PPLANEFHNBB(ref BNDNKLBIJJF, ref GADFHLLJKOH);
		}

		// Token: 0x0600C0BE RID: 49342 RVA: 0x0056C504 File Offset: 0x0056A704
		private void OnEnable()
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.ODAEDIJLDBG, true, true, this) || !OOFCHDPCJIJ.MLBELGPBEFK(this.MGANGHFAFEL, true, true, this))
			{
				base.enabled = false;
				return;
			}
			if (OOFCHDPCJIJ.FCKMFNPENOJ && !OOFCHDPCJIJ.MLBELGPBEFK(this.KJLFEDMLDCA, true, true, this))
			{
				base.enabled = false;
				return;
			}
			this.OAMAKLPFIFK(true);
			base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
		}

		// Token: 0x0600C0BF RID: 49343 RVA: 0x0056C574 File Offset: 0x0056A774
		private void DHBGJCMAEAE(RenderTexture HLIDLINNJOP, ref RenderTexture BNDNKLBIJJF, ref RenderTexture GADFHLLJKOH, float MBPLLJLKHGJ)
		{
			this.HEGIGEOKPBC(false);
			int pass;
			int pass2;
			DepthOfField.OIHAGLOGFLH(HLIDLINNJOP, MBPLLJLKHGJ, out pass, out pass2);
			this.FPMEPLHKEKL().SetTexture("MotorbikeShootFwd", HLIDLINNJOP);
			RenderTexture renderTexture = this.JEIFLMLLOLG.AIDDGPOEGHB(BNDNKLBIJJF.width, BNDNKLBIJJF.height, 0, BNDNKLBIJJF.format, FilterMode.Bilinear);
			this.FPMEPLHKEKL().SetVector("fshop_fcost", this.BDMPHFIOCAP);
			Graphics.Blit(BNDNKLBIJJF, renderTexture, this.FPMEPLHKEKL(), pass);
			this.MALCGOPBDOF.SetVector("Idle Sand Cover", this.DHDKJBMFLBM);
			Graphics.Blit(renderTexture, BNDNKLBIJJF, this.FPMEPLHKEKL(), pass);
			this.MALCGOPBDOF.SetVector("Transforms[", this.GDDIJOFJBAM);
			this.MALCGOPBDOF.SetTexture("Post Process Debug Shader Missing...", BNDNKLBIJJF);
			Graphics.Blit(renderTexture, GADFHLLJKOH, this.FPMEPLHKEKL(), pass2);
			this.JEIFLMLLOLG.AHAJPEDCFAE(renderTexture);
			DepthOfField.HBKCMNIBFPI(ref BNDNKLBIJJF, ref GADFHLLJKOH);
		}

		// Token: 0x0600C0C0 RID: 49344 RVA: 0x0056C65C File Offset: 0x0056A85C
		private static void PPLANEFHNBB(ref RenderTexture BNDNKLBIJJF, ref RenderTexture GADFHLLJKOH)
		{
			RenderTexture renderTexture = GADFHLLJKOH;
			GADFHLLJKOH = BNDNKLBIJJF;
			BNDNKLBIJJF = renderTexture;
		}

		// Token: 0x0600C0C1 RID: 49345 RVA: 0x0056C674 File Offset: 0x0056A874
		private void PHHJNIAEIPN(RenderTexture HLIDLINNJOP, ref RenderTexture BNDNKLBIJJF, ref RenderTexture GADFHLLJKOH, float MBPLLJLKHGJ)
		{
			this.OAMAKLPFIFK(false);
			int pass;
			int pass2;
			DepthOfField.LIDODJAPLHN(HLIDLINNJOP, MBPLLJLKHGJ, out pass, out pass2);
			this.MALCGOPBDOF.SetTexture("_SecondTex", HLIDLINNJOP);
			RenderTexture renderTexture = this.JEIFLMLLOLG.OFFIEJNIOAL(BNDNKLBIJJF.width, BNDNKLBIJJF.height, 0, BNDNKLBIJJF.format, FilterMode.Bilinear);
			this.MALCGOPBDOF.SetVector("_Offsets", this.FBJJJFLEEHI);
			Graphics.Blit(BNDNKLBIJJF, renderTexture, this.MALCGOPBDOF, pass);
			this.MALCGOPBDOF.SetVector("_Offsets", this.MMFAFBEHLMH);
			Graphics.Blit(renderTexture, GADFHLLJKOH, this.MALCGOPBDOF, pass);
			this.MALCGOPBDOF.SetVector("_Offsets", this.ANFOCOPCPOC);
			Graphics.Blit(BNDNKLBIJJF, renderTexture, this.MALCGOPBDOF, pass);
			this.MALCGOPBDOF.SetVector("_Offsets", this.NOHLIKCEBAN);
			this.MALCGOPBDOF.SetTexture("_ThirdTex", GADFHLLJKOH);
			Graphics.Blit(renderTexture, BNDNKLBIJJF, this.MALCGOPBDOF, pass2);
			this.JEIFLMLLOLG.JBKCAFCLDJH(renderTexture);
		}

		// Token: 0x0600C0C2 RID: 49346 RVA: 0x0056C77C File Offset: 0x0056A97C
		private void OnRenderImage(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.CPPHOKHHBIE == null || this.MALCGOPBDOF == null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.settings.visualizeFocus)
			{
				Vector4 value;
				Vector4 value2;
				this.DIEOEFBPBLO(out value, out value2);
				this.MALCGOPBDOF.SetVector("_BlurParams", value);
				this.MALCGOPBDOF.SetVector("_BlurCoe", value2);
				Graphics.Blit(null, OKIIDHIJBEA, this.MALCGOPBDOF, 5);
			}
			else
			{
				this.CMECDGAJINN(JONJODLFAEN, OKIIDHIJBEA);
			}
			this.JEIFLMLLOLG.IFBAMKOGBFI();
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x0600C0C3 RID: 49347 RVA: 0x0056C809 File Offset: 0x0056AA09
		public Material FENGKINKNGP
		{
			get
			{
				if (this.FNBBPCGFFCF == null)
				{
					this.FNBBPCGFFCF = OOFCHDPCJIJ.DJFOEIJIMJB(this.KJLFEDMLDCA);
				}
				return this.FNBBPCGFFCF;
			}
		}

		// Token: 0x0600C0C4 RID: 49348 RVA: 0x0056C830 File Offset: 0x0056AA30
		private void LENELHOAKID(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.BHHMGOOALBF() == null || this.FPMEPLHKEKL() == null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.settings.visualizeFocus)
			{
				Vector4 value;
				Vector4 value2;
				this.DIEOEFBPBLO(out value, out value2);
				this.MALCGOPBDOF.SetVector("минута", value);
				this.MALCGOPBDOF.SetVector("_Overlay", value2);
				Graphics.Blit(null, OKIIDHIJBEA, this.FPMEPLHKEKL(), 2);
			}
			else
			{
				this.JKCNGKJIIEH(JONJODLFAEN, OKIIDHIJBEA);
			}
			this.JEIFLMLLOLG.OHLNIGLKOEN();
		}

		// Token: 0x0600C0C5 RID: 49349 RVA: 0x0056C8BD File Offset: 0x0056AABD
		public Material FBOJGCFOCPI()
		{
			if (this.FNBBPCGFFCF == null)
			{
				this.FNBBPCGFFCF = OOFCHDPCJIJ.DJFOEIJIMJB(this.NPCENKNBNBB());
			}
			return this.FNBBPCGFFCF;
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x0600C0C6 RID: 49350 RVA: 0x0056C8E4 File Offset: 0x0056AAE4
		public Material CPPHOKHHBIE
		{
			get
			{
				if (this.IGCHDIJHJIP == null)
				{
					this.IGCHDIJHJIP = OOFCHDPCJIJ.DJFOEIJIMJB(this.MGANGHFAFEL);
				}
				return this.IGCHDIJHJIP;
			}
		}

		// Token: 0x0600C0C7 RID: 49351 RVA: 0x0056C8E4 File Offset: 0x0056AAE4
		public Material BHHMGOOALBF()
		{
			if (this.IGCHDIJHJIP == null)
			{
				this.IGCHDIJHJIP = OOFCHDPCJIJ.DJFOEIJIMJB(this.MGANGHFAFEL);
			}
			return this.IGCHDIJHJIP;
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x0600C0C8 RID: 49352 RVA: 0x0056C3C7 File Offset: 0x0056A5C7
		public Material MALCGOPBDOF
		{
			get
			{
				if (this.NOBAGCHNKNF == null)
				{
					this.NOBAGCHNKNF = OOFCHDPCJIJ.DJFOEIJIMJB(this.ODAEDIJLDBG);
				}
				return this.NOBAGCHNKNF;
			}
		}

		// Token: 0x0600C0C9 RID: 49353 RVA: 0x0056C90C File Offset: 0x0056AB0C
		private void JKCNGKJIIEH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.JFLMFJHLPDF = DepthOfField.QualitySettings.presetQualitySettings[(int)this.settings.filteringQuality];
			float num = (float)JONJODLFAEN.height / 396f;
			float num2 = num;
			float num3 = Mathf.Max(this.focus.nearBlurRadius, this.focus.farBlurRadius) * num2 * 472f;
			float num4 = this.focus.nearBlurRadius * num;
			float num5 = this.focus.farBlurRadius * num;
			float num6 = Mathf.Max(num4, num5);
			DepthOfField.NMLKCAJKBJD apertureShape = this.settings.apertureShape;
			if (apertureShape != DepthOfField.NMLKCAJKBJD.Hexagonal)
			{
				if (apertureShape == DepthOfField.NMLKCAJKBJD.Circular)
				{
					num6 *= 316f;
				}
			}
			else
			{
				num6 *= 302f;
			}
			if (num6 < 999f)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			int nmebeehcaln = JONJODLFAEN.width / 0;
			int illkfncfgmp = JONJODLFAEN.height / 0;
			Vector4 value = new Vector4(num4 * 1163f, num5 * 1936f, 85f, 1877f);
			RenderTexture renderTexture = this.JEIFLMLLOLG.CLEEDKHNPED(nmebeehcaln, illkfncfgmp, 1, RenderTextureFormat.Depth, FilterMode.Bilinear);
			RenderTexture renderTexture2 = this.JEIFLMLLOLG.HAIACDDDOCD(nmebeehcaln, illkfncfgmp, 1, RenderTextureFormat.Depth, FilterMode.Bilinear);
			Vector4 value2;
			Vector4 value3;
			this.GEGMGKADOFD(out value2, out value3);
			this.FPMEPLHKEKL().SetVector("cht_msg4", value2);
			this.MALCGOPBDOF.SetVector("null", value3);
			Graphics.Blit(JONJODLFAEN, renderTexture2, this.MALCGOPBDOF, 6);
			RenderTexture renderTexture3 = renderTexture2;
			RenderTexture renderTexture4 = renderTexture;
			if (this.PJOOHALOKLH())
			{
				RenderTexture renderTexture5 = this.JEIFLMLLOLG.ACIOKBMAHMH(nmebeehcaln, illkfncfgmp, 1, RenderTextureFormat.ARGB2101010, FilterMode.Bilinear);
				Graphics.Blit(renderTexture3, renderTexture5, this.MALCGOPBDOF, 1);
				this.MALCGOPBDOF.SetVector("Mouse X", new Vector4(114f, 1629f, 1875f, 1378f));
				Graphics.Blit(renderTexture5, renderTexture4, this.MALCGOPBDOF, 1);
				this.FPMEPLHKEKL().SetVector(" ", new Vector4(1961f, 992f, 1902f, 474f));
				Graphics.Blit(renderTexture4, renderTexture5, this.FPMEPLHKEKL(), 1);
				this.FBOJGCFOCPI().SetTexture("Below you can try to cheat few variables of the regular types and their obscured (secure) analogues (you may change initial values from Tester object inspector):", renderTexture5);
				this.FENGKINKNGP.SetFloat(" {0}", this.bokehTexture.spawnHeuristic);
				this.FENGKINKNGP.SetVector("", new Vector4(this.bokehTexture.scale * num2, this.bokehTexture.intensity, this.bokehTexture.threshold, num3));
				Graphics.SetRandomWriteTarget(0, this.GHHMJFNMCBJ);
				Graphics.Blit(renderTexture3, renderTexture4, this.FENGKINKNGP, 0);
				Graphics.ClearRandomWriteTargets();
				DepthOfField.DANMIMPDKCJ(ref renderTexture3, ref renderTexture4);
				this.JEIFLMLLOLG.IJINNEALDCD(renderTexture5);
			}
			this.FPMEPLHKEKL().SetVector("Yawn", value2);
			this.FPMEPLHKEKL().SetVector("Fire1", value);
			RenderTexture renderTexture6 = null;
			if (this.JFLMFJHLPDF.dilateNearBlur)
			{
				RenderTexture renderTexture7 = this.JEIFLMLLOLG.BKEEIBKHILH(nmebeehcaln, illkfncfgmp, 0, (RenderTextureFormat)(-18), FilterMode.Point);
				renderTexture6 = this.JEIFLMLLOLG.EBDILCDNIEJ(nmebeehcaln, illkfncfgmp, 1, (RenderTextureFormat)(-121), FilterMode.Point);
				this.FPMEPLHKEKL().SetVector("0", new Vector4(811f, num4 * 706f, 1174f, 882f));
				Graphics.Blit(renderTexture3, renderTexture7, this.FPMEPLHKEKL(), 6);
				this.FPMEPLHKEKL().SetVector("UnityEngine.Color", new Vector4(num4 * 1013f, 1242f, 1702f, 885f));
				Graphics.Blit(renderTexture7, renderTexture6, this.MALCGOPBDOF, 2);
				this.JEIFLMLLOLG.HEMCJHCMDKP(renderTexture7);
				renderTexture6.filterMode = FilterMode.Point;
			}
			if (this.JFLMFJHLPDF.prefilterBlur)
			{
				Graphics.Blit(renderTexture3, renderTexture4, this.FPMEPLHKEKL(), 8);
				DepthOfField.HBKCMNIBFPI(ref renderTexture3, ref renderTexture4);
			}
			switch (this.settings.apertureShape)
			{
			case DepthOfField.NMLKCAJKBJD.Circular:
				this.NBIMDKJHGKJ(renderTexture6, ref renderTexture3, ref renderTexture4, num6);
				break;
			case DepthOfField.NMLKCAJKBJD.Hexagonal:
				this.GPCCNEEIBFN(renderTexture6, ref renderTexture3, ref renderTexture4, num6);
				break;
			case DepthOfField.NMLKCAJKBJD.Octogonal:
				this.EIJBDKKHBFM(renderTexture6, ref renderTexture3, ref renderTexture4, num6);
				break;
			}
			DepthOfField.EDNHOOMFJOP medianFilter = this.JFLMFJHLPDF.medianFilter;
			if (medianFilter != DepthOfField.EDNHOOMFJOP.None)
			{
				if (medianFilter == (DepthOfField.EDNHOOMFJOP)3)
				{
					Graphics.Blit(renderTexture3, renderTexture4, this.JNHAFJNPBKD(), 0);
					DepthOfField.PPLANEFHNBB(ref renderTexture3, ref renderTexture4);
				}
			}
			else
			{
				this.JNHAFJNPBKD().SetVector("[ACTk] <b>[ ObscuredVector3 test ]</b>", new Vector4(962f, 521f, 1398f, 1569f));
				Graphics.Blit(renderTexture3, renderTexture4, this.CPPHOKHHBIE, 0);
				DepthOfField.DANMIMPDKCJ(ref renderTexture3, ref renderTexture4);
				this.BHHMGOOALBF().SetVector("Fishing", new Vector4(1454f, 1059f, 1225f, 748f));
				Graphics.Blit(renderTexture3, renderTexture4, this.CPPHOKHHBIE, 1);
				DepthOfField.PPLANEFHNBB(ref renderTexture3, ref renderTexture4);
			}
			this.FPMEPLHKEKL().SetVector("BlackSmithHammer", value);
			this.FPMEPLHKEKL().SetVector("\n", new Vector4((float)renderTexture3.width, (float)renderTexture3.height, 232f / (float)renderTexture3.width, 1568f / (float)renderTexture3.height));
			this.FPMEPLHKEKL().SetTexture("cht_msg29", renderTexture3);
			int pass = -115;
			if (this.PJOOHALOKLH())
			{
				RenderTexture renderTexture8 = this.JEIFLMLLOLG.HAIACDDDOCD(JONJODLFAEN.height, JONJODLFAEN.width, 0, JONJODLFAEN.format, FilterMode.Point);
				Graphics.Blit(JONJODLFAEN, renderTexture8, this.FPMEPLHKEKL(), pass);
				Graphics.SetRenderTarget(renderTexture8);
				ComputeBuffer.CopyCount(this.GHHMJFNMCBJ, this.KABMEGODJMH(), 0);
				this.FBOJGCFOCPI().SetBuffer("Idle Walk", this.KDKMHCIOGPP());
				this.FBOJGCFOCPI().SetTexture("MotorbikeBackwardSitting", this.bokehTexture.texture);
				this.FBOJGCFOCPI().SetVector("MotorbikeLasso", new Vector3(886f / (675f * (float)JONJODLFAEN.width), 1346f / (1001f * (float)JONJODLFAEN.height), num3));
				this.FENGKINKNGP.SetPass(0);
				Graphics.DrawProceduralIndirectNow(MeshTopology.Triangles, this.JMLGGJONDAO, 0);
				Graphics.Blit(renderTexture8, OKIIDHIJBEA);
				return;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FPMEPLHKEKL(), pass);
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x0600C0CA RID: 49354 RVA: 0x0056CF2C File Offset: 0x0056B12C
		public Shader KJLFEDMLDCA
		{
			get
			{
				if (this.m_TextureBokehShader == null)
				{
					this.m_TextureBokehShader = Shader.Find("Hidden/DepthOfField/BokehSplatting");
				}
				return this.m_TextureBokehShader;
			}
		}

		// Token: 0x0600C0CB RID: 49355 RVA: 0x0056CF54 File Offset: 0x0056B154
		private static void EDCNOEPDFFM(RenderTexture HLIDLINNJOP, float MBPLLJLKHGJ, out int AGNBHDBHKCJ, out int DDLOHMKNMJM)
		{
			if (HLIDLINNJOP == null)
			{
				if (MBPLLJLKHGJ > 220f)
				{
					AGNBHDBHKCJ = 46;
					DDLOHMKNMJM = -15;
					return;
				}
				if (MBPLLJLKHGJ > 911f)
				{
					AGNBHDBHKCJ = -74;
					DDLOHMKNMJM = 60;
					return;
				}
				AGNBHDBHKCJ = -124;
				DDLOHMKNMJM = 7;
				return;
			}
			else
			{
				if (MBPLLJLKHGJ > 740f)
				{
					AGNBHDBHKCJ = -48;
					DDLOHMKNMJM = -89;
					return;
				}
				if (MBPLLJLKHGJ > 1933f)
				{
					AGNBHDBHKCJ = 126;
					DDLOHMKNMJM = 90;
					return;
				}
				AGNBHDBHKCJ = -113;
				DDLOHMKNMJM = -122;
				return;
			}
		}

		// Token: 0x0600C0CC RID: 49356 RVA: 0x0056CFBF File Offset: 0x0056B1BF
		public Shader NPCENKNBNBB()
		{
			if (this.m_TextureBokehShader == null)
			{
				this.m_TextureBokehShader = Shader.Find("int\nfloat\nstring\n<color=\"#75C4EB\">uint\ndouble\ndecimal\nlong\nulong\nbool\nbyte[]\nVector2\nVector3\nQuaternion\nColor\nRect</color>");
			}
			return this.m_TextureBokehShader;
		}

		// Token: 0x0600C0CD RID: 49357 RVA: 0x0056CFE8 File Offset: 0x0056B1E8
		private void EIJBDKKHBFM(RenderTexture HLIDLINNJOP, ref RenderTexture BNDNKLBIJJF, ref RenderTexture GADFHLLJKOH, float MBPLLJLKHGJ)
		{
			this.OAMAKLPFIFK(false);
			int pass;
			int pass2;
			DepthOfField.EDCNOEPDFFM(HLIDLINNJOP, MBPLLJLKHGJ, out pass, out pass2);
			this.FPMEPLHKEKL().SetTexture("<color='#ff0000'>Вы сломали удочку</color>", HLIDLINNJOP);
			RenderTexture renderTexture = this.JEIFLMLLOLG.LJFNLLAHDIM(BNDNKLBIJJF.width, BNDNKLBIJJF.height, 0, BNDNKLBIJJF.format, FilterMode.Point);
			this.FPMEPLHKEKL().SetVector("cht_msg11", this.FBJJJFLEEHI);
			Graphics.Blit(BNDNKLBIJJF, renderTexture, this.MALCGOPBDOF, pass);
			this.MALCGOPBDOF.SetVector("BipedReferences contains one or more missing Transforms.", this.MMFAFBEHLMH);
			Graphics.Blit(renderTexture, GADFHLLJKOH, this.FPMEPLHKEKL(), pass);
			this.MALCGOPBDOF.SetVector("error", this.ANFOCOPCPOC);
			Graphics.Blit(BNDNKLBIJJF, renderTexture, this.MALCGOPBDOF, pass);
			this.MALCGOPBDOF.SetVector("man_death.ogg", this.NOHLIKCEBAN);
			this.MALCGOPBDOF.SetTexture("OfficeSittingReading", GADFHLLJKOH);
			Graphics.Blit(renderTexture, BNDNKLBIJJF, this.FPMEPLHKEKL(), pass2);
			this.JEIFLMLLOLG.IJINNEALDCD(renderTexture);
		}

		// Token: 0x0600C0CE RID: 49358 RVA: 0x0056D0EE File Offset: 0x0056B2EE
		public Shader NDNJPNKDLGL()
		{
			if (this.m_MedianFilterShader == null)
			{
				this.m_MedianFilterShader = Shader.Find("useSrcAlphaAsMask");
			}
			return this.m_MedianFilterShader;
		}

		// Token: 0x0600C0CF RID: 49359 RVA: 0x0056D114 File Offset: 0x0056B314
		public ComputeBuffer KABMEGODJMH()
		{
			if (this.HAJHMMDCBKK == null)
			{
				this.HAJHMMDCBKK = new ComputeBuffer(1, 27, (ComputeBufferType)104);
				ComputeBuffer hajhmmdcbkk = this.HAJHMMDCBKK;
				int[] array = new int[7];
				array[1] = 1;
				hajhmmdcbkk.SetData(array);
			}
			return this.HAJHMMDCBKK;
		}

		// Token: 0x0600C0D0 RID: 49360 RVA: 0x0056D14C File Offset: 0x0056B34C
		private void KHLIAPMBOOA(out Vector4 HGDMEKFPAOO, out Vector4 FBGIKMKAIED)
		{
			Camera component = base.GetComponent<Camera>();
			float num = this.focus.nearFalloff * 1706f;
			float num2 = this.focus.farFalloff * 0f;
			float num3 = this.focus.nearPlane;
			float num4 = this.focus.farPlane;
			float num5;
			if (this.settings.tweakMode == DepthOfField.GEIBPMEFBFP.Range)
			{
				if (this.focus.transform != null)
				{
					num5 = component.WorldToViewportPoint(this.focus.transform.position).z;
				}
				else
				{
					num5 = this.focus.focusPlane;
				}
				float num6 = this.focus.range * 249f;
				num3 = num5 - num6;
				num4 = num5 + num6;
			}
			num3 -= num * 1123f;
			num4 += num2 * 1455f;
			num5 = (num3 + num4) * 840f;
			float num7 = num5 / component.farClipPlane;
			float num8 = num3 / component.farClipPlane;
			float num9 = num4 / component.farClipPlane;
			float num10 = num4 - num3;
			float num11 = num9 - num8;
			float num12 = num / num10;
			float num13 = num2 / num10;
			float num14 = (1344f - num12) * (num11 * 798f);
			float num15 = (183f - num13) * (num11 * 1420f);
			if (num7 <= num8)
			{
				num7 = num8 + 652f;
			}
			if (num7 >= num9)
			{
				num7 = num9 - 676f;
			}
			if (num7 - num14 <= num8)
			{
				num14 = num7 - num8 - 226f;
			}
			if (num7 + num15 >= num9)
			{
				num15 = num9 - num7 - 739f;
			}
			float num16 = 1939f / (num8 - num7 + num14);
			float num17 = 523f / (num9 - num7 - num15);
			float num18 = 1872f - num16 * num8;
			float num19 = 95f - num17 * num9;
			HGDMEKFPAOO = new Vector4(1800f * num16, 1244f * num18, 419f * num17, 1563f * num19);
			FBGIKMKAIED = new Vector4(1863f, 1086f, (num19 - num18) / (num16 - num17), 1187f);
			this.focus.nearPlane = num3 + num * 1369f;
			this.focus.farPlane = num4 - num2 * 963f;
			this.focus.focusPlane = (this.focus.nearPlane + this.focus.farPlane) * 1389f;
			this.focus.range = this.focus.farPlane - this.focus.nearPlane;
		}

		// Token: 0x0600C0D1 RID: 49361 RVA: 0x0056D3D8 File Offset: 0x0056B5D8
		private void EEDJEMLFJKP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.BHHMGOOALBF() == null || this.FPMEPLHKEKL() == null)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.settings.visualizeFocus)
			{
				Vector4 value;
				Vector4 value2;
				this.DIEOEFBPBLO(out value, out value2);
				this.MALCGOPBDOF.SetVector(" has been disabled as it's not supported on the current platform.", value);
				this.FPMEPLHKEKL().SetVector("MotorbikeSuperman", value2);
				Graphics.Blit(null, OKIIDHIJBEA, this.MALCGOPBDOF, 6);
			}
			else
			{
				this.JKCNGKJIIEH(JONJODLFAEN, OKIIDHIJBEA);
			}
			this.JEIFLMLLOLG.FMIMDCPJHMF();
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x0600C0D2 RID: 49362 RVA: 0x0056D465 File Offset: 0x0056B665
		public ComputeBuffer JMLGGJONDAO
		{
			get
			{
				if (this.HAJHMMDCBKK == null)
				{
					this.HAJHMMDCBKK = new ComputeBuffer(1, 16, ComputeBufferType.DrawIndirect);
					ComputeBuffer hajhmmdcbkk = this.HAJHMMDCBKK;
					int[] array = new int[4];
					array[1] = 1;
					hajhmmdcbkk.SetData(array);
				}
				return this.HAJHMMDCBKK;
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x0600C0D3 RID: 49363 RVA: 0x0056D49D File Offset: 0x0056B69D
		private bool BPGBIMHCAIO
		{
			get
			{
				return OOFCHDPCJIJ.FCKMFNPENOJ && this.bokehTexture.texture != null && this.FENGKINKNGP;
			}
		}

		// Token: 0x0600C0D4 RID: 49364 RVA: 0x0056D4C8 File Offset: 0x0056B6C8
		private void DIEOEFBPBLO(out Vector4 HGDMEKFPAOO, out Vector4 FBGIKMKAIED)
		{
			Camera component = base.GetComponent<Camera>();
			float num = this.focus.nearFalloff * 2f;
			float num2 = this.focus.farFalloff * 2f;
			float num3 = this.focus.nearPlane;
			float num4 = this.focus.farPlane;
			float num5;
			if (this.settings.tweakMode == DepthOfField.GEIBPMEFBFP.Range)
			{
				if (this.focus.transform != null)
				{
					num5 = component.WorldToViewportPoint(this.focus.transform.position).z;
				}
				else
				{
					num5 = this.focus.focusPlane;
				}
				float num6 = this.focus.range * 0.5f;
				num3 = num5 - num6;
				num4 = num5 + num6;
			}
			num3 -= num * 0.5f;
			num4 += num2 * 0.5f;
			num5 = (num3 + num4) * 0.5f;
			float num7 = num5 / component.farClipPlane;
			float num8 = num3 / component.farClipPlane;
			float num9 = num4 / component.farClipPlane;
			float num10 = num4 - num3;
			float num11 = num9 - num8;
			float num12 = num / num10;
			float num13 = num2 / num10;
			float num14 = (1f - num12) * (num11 * 0.5f);
			float num15 = (1f - num13) * (num11 * 0.5f);
			if (num7 <= num8)
			{
				num7 = num8 + 1E-06f;
			}
			if (num7 >= num9)
			{
				num7 = num9 - 1E-06f;
			}
			if (num7 - num14 <= num8)
			{
				num14 = num7 - num8 - 1E-06f;
			}
			if (num7 + num15 >= num9)
			{
				num15 = num9 - num7 - 1E-06f;
			}
			float num16 = 1f / (num8 - num7 + num14);
			float num17 = 1f / (num9 - num7 - num15);
			float num18 = 1f - num16 * num8;
			float num19 = 1f - num17 * num9;
			HGDMEKFPAOO = new Vector4(-1f * num16, -1f * num18, 1f * num17, 1f * num19);
			FBGIKMKAIED = new Vector4(0f, 0f, (num19 - num18) / (num16 - num17), 0f);
			this.focus.nearPlane = num3 + num * 0.5f;
			this.focus.farPlane = num4 - num2 * 0.5f;
			this.focus.focusPlane = (this.focus.nearPlane + this.focus.farPlane) * 0.5f;
			this.focus.range = this.focus.farPlane - this.focus.nearPlane;
		}

		// Token: 0x0600C0D6 RID: 49366 RVA: 0x0056D788 File Offset: 0x0056B988
		private static void DKEIDBNNIGL(ref Vector4 NEMFIHCKJPE, float DOGPHBEILNE, float OPABCNCAJLJ)
		{
			Vector4 vector = NEMFIHCKJPE;
			NEMFIHCKJPE.x = vector.x * DOGPHBEILNE - vector.y * OPABCNCAJLJ;
			NEMFIHCKJPE.y = vector.x * OPABCNCAJLJ + vector.y * DOGPHBEILNE;
		}

		// Token: 0x0600C0D7 RID: 49367 RVA: 0x0056D7CC File Offset: 0x0056B9CC
		private static void PKDOJKBACPH(ref Vector4 NEMFIHCKJPE, float DOGPHBEILNE, float OPABCNCAJLJ)
		{
			Vector4 vector = NEMFIHCKJPE;
			NEMFIHCKJPE.x = vector.x * DOGPHBEILNE - vector.y * OPABCNCAJLJ;
			NEMFIHCKJPE.y = vector.x * OPABCNCAJLJ + vector.y * DOGPHBEILNE;
		}

		// Token: 0x0600C0D8 RID: 49368 RVA: 0x0056D80E File Offset: 0x0056BA0E
		public Shader LMAHDHNJIKL()
		{
			if (this.m_TextureBokehShader == null)
			{
				this.m_TextureBokehShader = Shader.Find(" ");
			}
			return this.m_TextureBokehShader;
		}

		// Token: 0x0600C0D9 RID: 49369 RVA: 0x0056D834 File Offset: 0x0056BA34
		private static void JIGJNGLKBPE(ref Vector4 NEMFIHCKJPE, float DOGPHBEILNE, float OPABCNCAJLJ)
		{
			Vector4 vector = NEMFIHCKJPE;
			NEMFIHCKJPE.x = vector.x * DOGPHBEILNE - vector.y * OPABCNCAJLJ;
			NEMFIHCKJPE.y = vector.x * OPABCNCAJLJ + vector.y * DOGPHBEILNE;
		}

		// Token: 0x0600C0DA RID: 49370 RVA: 0x0056D878 File Offset: 0x0056BA78
		private void IIONABJOCBN()
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.ODAEDIJLDBG, false, false, this) || !OOFCHDPCJIJ.MLBELGPBEFK(this.GMDGHEBGGBN(), false, true, this))
			{
				base.enabled = true;
				return;
			}
			if (OOFCHDPCJIJ.FCKMFNPENOJ && !OOFCHDPCJIJ.MLBELGPBEFK(this.KJLFEDMLDCA, true, true, this))
			{
				base.enabled = true;
				return;
			}
			this.FDHPJIDPPIA(false);
			base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
		}

		// Token: 0x0600C0DB RID: 49371 RVA: 0x0056D8E6 File Offset: 0x0056BAE6
		public ComputeBuffer KDKMHCIOGPP()
		{
			if (this.OCENJJEKIFH == null)
			{
				this.OCENJJEKIFH = new ComputeBuffer(-12, -13, ComputeBufferType.Raw | ComputeBufferType.Append | ComputeBufferType.Counter);
			}
			return this.OCENJJEKIFH;
		}

		// Token: 0x0600C0DC RID: 49372 RVA: 0x0056D90C File Offset: 0x0056BB0C
		private void OAMAKLPFIFK(bool PGEDLDMLBBE)
		{
			if (!PGEDLDMLBBE && Math.Abs(this.OBHHNOLFCFL - this.settings.apertureOrientation) < 1E-45f)
			{
				return;
			}
			this.OBHHNOLFCFL = this.settings.apertureOrientation;
			float num = this.settings.apertureOrientation * 0.017453292f;
			float dogphbeilne = Mathf.Cos(num);
			float opabcncajlj = Mathf.Sin(num);
			this.FBJJJFLEEHI = new Vector4(0.5f, 0f, 0f, 0f);
			this.MMFAFBEHLMH = new Vector4(0f, 0.5f, 1f, 0f);
			this.ANFOCOPCPOC = new Vector4(-0.353553f, 0.353553f, 1f, 0f);
			this.NOHLIKCEBAN = new Vector4(0.353553f, 0.353553f, 1f, 0f);
			this.BDMPHFIOCAP = new Vector4(0.5f, 0f, 0f, 0f);
			this.DHDKJBMFLBM = new Vector4(0.25f, 0.433013f, 1f, 0f);
			this.GDDIJOFJBAM = new Vector4(0.25f, -0.433013f, 1f, 0f);
			if (num > 1E-45f)
			{
				DepthOfField.JIGJNGLKBPE(ref this.FBJJJFLEEHI, dogphbeilne, opabcncajlj);
				DepthOfField.JIGJNGLKBPE(ref this.MMFAFBEHLMH, dogphbeilne, opabcncajlj);
				DepthOfField.JIGJNGLKBPE(ref this.ANFOCOPCPOC, dogphbeilne, opabcncajlj);
				DepthOfField.JIGJNGLKBPE(ref this.NOHLIKCEBAN, dogphbeilne, opabcncajlj);
				DepthOfField.JIGJNGLKBPE(ref this.BDMPHFIOCAP, dogphbeilne, opabcncajlj);
				DepthOfField.JIGJNGLKBPE(ref this.DHDKJBMFLBM, dogphbeilne, opabcncajlj);
				DepthOfField.JIGJNGLKBPE(ref this.GDDIJOFJBAM, dogphbeilne, opabcncajlj);
			}
		}

		// Token: 0x0600C0DD RID: 49373 RVA: 0x0056C8E4 File Offset: 0x0056AAE4
		public Material JNHAFJNPBKD()
		{
			if (this.IGCHDIJHJIP == null)
			{
				this.IGCHDIJHJIP = OOFCHDPCJIJ.DJFOEIJIMJB(this.MGANGHFAFEL);
			}
			return this.IGCHDIJHJIP;
		}

		// Token: 0x04001925 RID: 6437
		private const float ADNFHKBAKOJ = 40f;

		// Token: 0x04001926 RID: 6438
		public DepthOfField.GlobalSettings settings = DepthOfField.GlobalSettings.defaultSettings;

		// Token: 0x04001927 RID: 6439
		public DepthOfField.FocusSettings focus = DepthOfField.FocusSettings.defaultSettings;

		// Token: 0x04001928 RID: 6440
		public DepthOfField.BokehTextureSettings bokehTexture = DepthOfField.BokehTextureSettings.defaultSettings;

		// Token: 0x04001929 RID: 6441
		[SerializeField]
		private Shader m_FilmicDepthOfFieldShader;

		// Token: 0x0400192A RID: 6442
		[SerializeField]
		private Shader m_MedianFilterShader;

		// Token: 0x0400192B RID: 6443
		[SerializeField]
		private Shader m_TextureBokehShader;

		// Token: 0x0400192C RID: 6444
		private ICADPIDCHAM JEIFLMLLOLG = new ICADPIDCHAM();

		// Token: 0x0400192D RID: 6445
		private Material NOBAGCHNKNF;

		// Token: 0x0400192E RID: 6446
		private Material IGCHDIJHJIP;

		// Token: 0x0400192F RID: 6447
		private Material FNBBPCGFFCF;

		// Token: 0x04001930 RID: 6448
		private ComputeBuffer HAJHMMDCBKK;

		// Token: 0x04001931 RID: 6449
		private ComputeBuffer OCENJJEKIFH;

		// Token: 0x04001932 RID: 6450
		private DepthOfField.QualitySettings JFLMFJHLPDF;

		// Token: 0x04001933 RID: 6451
		private float OBHHNOLFCFL;

		// Token: 0x04001934 RID: 6452
		private Vector4 FBJJJFLEEHI;

		// Token: 0x04001935 RID: 6453
		private Vector4 MMFAFBEHLMH;

		// Token: 0x04001936 RID: 6454
		private Vector4 ANFOCOPCPOC;

		// Token: 0x04001937 RID: 6455
		private Vector4 NOHLIKCEBAN;

		// Token: 0x04001938 RID: 6456
		private Vector4 BDMPHFIOCAP;

		// Token: 0x04001939 RID: 6457
		private Vector4 DHDKJBMFLBM;

		// Token: 0x0400193A RID: 6458
		private Vector4 GDDIJOFJBAM;

		// Token: 0x0200035E RID: 862
		private enum BHHMIOOIDDL
		{
			// Token: 0x0400193C RID: 6460
			BlurAlphaWeighted,
			// Token: 0x0400193D RID: 6461
			BoxBlur,
			// Token: 0x0400193E RID: 6462
			DilateFgCocFromColor,
			// Token: 0x0400193F RID: 6463
			DilateFgCoc,
			// Token: 0x04001940 RID: 6464
			CaptureCocExplicit,
			// Token: 0x04001941 RID: 6465
			VisualizeCocExplicit,
			// Token: 0x04001942 RID: 6466
			CocPrefilter,
			// Token: 0x04001943 RID: 6467
			CircleBlur,
			// Token: 0x04001944 RID: 6468
			CircleBlurWithDilatedFg,
			// Token: 0x04001945 RID: 6469
			CircleBlurLowQuality,
			// Token: 0x04001946 RID: 6470
			CircleBlowLowQualityWithDilatedFg,
			// Token: 0x04001947 RID: 6471
			MergeExplicit,
			// Token: 0x04001948 RID: 6472
			ShapeLowQuality,
			// Token: 0x04001949 RID: 6473
			ShapeLowQualityDilateFg,
			// Token: 0x0400194A RID: 6474
			ShapeLowQualityMerge,
			// Token: 0x0400194B RID: 6475
			ShapeLowQualityMergeDilateFg,
			// Token: 0x0400194C RID: 6476
			ShapeMediumQuality,
			// Token: 0x0400194D RID: 6477
			ShapeMediumQualityDilateFg,
			// Token: 0x0400194E RID: 6478
			ShapeMediumQualityMerge,
			// Token: 0x0400194F RID: 6479
			ShapeMediumQualityMergeDilateFg,
			// Token: 0x04001950 RID: 6480
			ShapeHighQuality,
			// Token: 0x04001951 RID: 6481
			ShapeHighQualityDilateFg,
			// Token: 0x04001952 RID: 6482
			ShapeHighQualityMerge,
			// Token: 0x04001953 RID: 6483
			ShapeHighQualityMergeDilateFg
		}

		// Token: 0x0200035F RID: 863
		private enum DCALIMFNCIM
		{
			// Token: 0x04001955 RID: 6485
			Median3,
			// Token: 0x04001956 RID: 6486
			Median3X3
		}

		// Token: 0x02000360 RID: 864
		private enum CCJEGGJNEDC
		{
			// Token: 0x04001958 RID: 6488
			Apply,
			// Token: 0x04001959 RID: 6489
			Collect
		}

		// Token: 0x02000361 RID: 865
		public enum GEIBPMEFBFP
		{
			// Token: 0x0400195B RID: 6491
			Range,
			// Token: 0x0400195C RID: 6492
			Explicit
		}

		// Token: 0x02000362 RID: 866
		public enum NMLKCAJKBJD
		{
			// Token: 0x0400195E RID: 6494
			Circular,
			// Token: 0x0400195F RID: 6495
			Hexagonal,
			// Token: 0x04001960 RID: 6496
			Octogonal
		}

		// Token: 0x02000363 RID: 867
		public enum NGPIGOBFNPP
		{
			// Token: 0x04001962 RID: 6498
			Low,
			// Token: 0x04001963 RID: 6499
			Medium,
			// Token: 0x04001964 RID: 6500
			High
		}

		// Token: 0x02000364 RID: 868
		public enum EDNHOOMFJOP
		{
			// Token: 0x04001966 RID: 6502
			None,
			// Token: 0x04001967 RID: 6503
			Normal,
			// Token: 0x04001968 RID: 6504
			High
		}

		// Token: 0x02000365 RID: 869
		[Serializable]
		public struct GlobalSettings
		{
			// Token: 0x0600C0DE RID: 49374 RVA: 0x0056DAA8 File Offset: 0x0056BCA8
			public static DepthOfField.GlobalSettings MDDFLLOCDEA()
			{
				return new DepthOfField.GlobalSettings
				{
					visualizeFocus = false,
					tweakMode = DepthOfField.GEIBPMEFBFP.Range,
					filteringQuality = DepthOfField.NGPIGOBFNPP.High,
					apertureShape = DepthOfField.NMLKCAJKBJD.Hexagonal,
					apertureOrientation = 1453f
				};
			}

			// Token: 0x0600C0DF RID: 49375 RVA: 0x0056DAEC File Offset: 0x0056BCEC
			public static DepthOfField.GlobalSettings GDKPNHJPBKJ()
			{
				return new DepthOfField.GlobalSettings
				{
					visualizeFocus = false,
					tweakMode = DepthOfField.GEIBPMEFBFP.Range,
					filteringQuality = (DepthOfField.NGPIGOBFNPP)7,
					apertureShape = DepthOfField.NMLKCAJKBJD.Circular,
					apertureOrientation = 398f
				};
			}

			// Token: 0x0600C0E0 RID: 49376 RVA: 0x0056DB30 File Offset: 0x0056BD30
			public static DepthOfField.GlobalSettings COINKHKLJAP()
			{
				return new DepthOfField.GlobalSettings
				{
					visualizeFocus = false,
					tweakMode = DepthOfField.GEIBPMEFBFP.Range,
					filteringQuality = DepthOfField.NGPIGOBFNPP.Medium,
					apertureShape = DepthOfField.NMLKCAJKBJD.Circular,
					apertureOrientation = 1259f
				};
			}

			// Token: 0x170002A4 RID: 676
			// (get) Token: 0x0600C0E1 RID: 49377 RVA: 0x0056DB74 File Offset: 0x0056BD74
			public static DepthOfField.GlobalSettings defaultSettings
			{
				get
				{
					return new DepthOfField.GlobalSettings
					{
						visualizeFocus = false,
						tweakMode = DepthOfField.GEIBPMEFBFP.Range,
						filteringQuality = DepthOfField.NGPIGOBFNPP.High,
						apertureShape = DepthOfField.NMLKCAJKBJD.Circular,
						apertureOrientation = 0f
					};
				}
			}

			// Token: 0x0600C0E2 RID: 49378 RVA: 0x0056DBB8 File Offset: 0x0056BDB8
			public static DepthOfField.GlobalSettings PIAJOHPDMNA()
			{
				return new DepthOfField.GlobalSettings
				{
					visualizeFocus = false,
					tweakMode = DepthOfField.GEIBPMEFBFP.Explicit,
					filteringQuality = (DepthOfField.NGPIGOBFNPP)7,
					apertureShape = DepthOfField.NMLKCAJKBJD.Hexagonal,
					apertureOrientation = 1056f
				};
			}

			// Token: 0x0600C0E3 RID: 49379 RVA: 0x0056DBFC File Offset: 0x0056BDFC
			public static DepthOfField.GlobalSettings MDDBLMDKDAO()
			{
				return new DepthOfField.GlobalSettings
				{
					visualizeFocus = false,
					tweakMode = DepthOfField.GEIBPMEFBFP.Range,
					filteringQuality = DepthOfField.NGPIGOBFNPP.Low,
					apertureShape = DepthOfField.NMLKCAJKBJD.Circular,
					apertureOrientation = 1444f
				};
			}

			// Token: 0x0600C0E4 RID: 49380 RVA: 0x0056DC40 File Offset: 0x0056BE40
			public static DepthOfField.GlobalSettings CGGMKBADCBM()
			{
				return new DepthOfField.GlobalSettings
				{
					visualizeFocus = false,
					tweakMode = DepthOfField.GEIBPMEFBFP.Range,
					filteringQuality = (DepthOfField.NGPIGOBFNPP)8,
					apertureShape = DepthOfField.NMLKCAJKBJD.Circular,
					apertureOrientation = 1533f
				};
			}

			// Token: 0x0600C0E5 RID: 49381 RVA: 0x0056DC84 File Offset: 0x0056BE84
			public static DepthOfField.GlobalSettings HMDLEIJHKEP()
			{
				return new DepthOfField.GlobalSettings
				{
					visualizeFocus = false,
					tweakMode = DepthOfField.GEIBPMEFBFP.Explicit,
					filteringQuality = (DepthOfField.NGPIGOBFNPP)7,
					apertureShape = DepthOfField.NMLKCAJKBJD.Hexagonal,
					apertureOrientation = 1381f
				};
			}

			// Token: 0x0600C0E6 RID: 49382 RVA: 0x0056DCC8 File Offset: 0x0056BEC8
			public static DepthOfField.GlobalSettings NNNMNENCOBC()
			{
				return new DepthOfField.GlobalSettings
				{
					visualizeFocus = false,
					tweakMode = DepthOfField.GEIBPMEFBFP.Explicit,
					filteringQuality = DepthOfField.NGPIGOBFNPP.Low,
					apertureShape = DepthOfField.NMLKCAJKBJD.Hexagonal,
					apertureOrientation = 575f
				};
			}

			// Token: 0x0600C0E7 RID: 49383 RVA: 0x0056DD0C File Offset: 0x0056BF0C
			public static DepthOfField.GlobalSettings OOFOKHIDMDG()
			{
				return new DepthOfField.GlobalSettings
				{
					visualizeFocus = true,
					tweakMode = DepthOfField.GEIBPMEFBFP.Explicit,
					filteringQuality = (DepthOfField.NGPIGOBFNPP)3,
					apertureShape = DepthOfField.NMLKCAJKBJD.Hexagonal,
					apertureOrientation = 654f
				};
			}

			// Token: 0x0600C0E8 RID: 49384 RVA: 0x0056DD50 File Offset: 0x0056BF50
			public static DepthOfField.GlobalSettings IGIKNGLDPJB()
			{
				return new DepthOfField.GlobalSettings
				{
					visualizeFocus = true,
					tweakMode = DepthOfField.GEIBPMEFBFP.Explicit,
					filteringQuality = (DepthOfField.NGPIGOBFNPP)3,
					apertureShape = DepthOfField.NMLKCAJKBJD.Hexagonal,
					apertureOrientation = 389f
				};
			}

			// Token: 0x0600C0E9 RID: 49385 RVA: 0x0056DD94 File Offset: 0x0056BF94
			public static DepthOfField.GlobalSettings FBBLPICJODA()
			{
				return new DepthOfField.GlobalSettings
				{
					visualizeFocus = false,
					tweakMode = DepthOfField.GEIBPMEFBFP.Range,
					filteringQuality = (DepthOfField.NGPIGOBFNPP)8,
					apertureShape = DepthOfField.NMLKCAJKBJD.Circular,
					apertureOrientation = 462f
				};
			}

			// Token: 0x0600C0EA RID: 49386 RVA: 0x0056DDD8 File Offset: 0x0056BFD8
			public static DepthOfField.GlobalSettings MDGIIBPIGJC()
			{
				return new DepthOfField.GlobalSettings
				{
					visualizeFocus = false,
					tweakMode = DepthOfField.GEIBPMEFBFP.Explicit,
					filteringQuality = (DepthOfField.NGPIGOBFNPP)4,
					apertureShape = DepthOfField.NMLKCAJKBJD.Circular,
					apertureOrientation = 1766f
				};
			}

			// Token: 0x0600C0EB RID: 49387 RVA: 0x0056DE1C File Offset: 0x0056C01C
			public static DepthOfField.GlobalSettings HLLBKJENCLA()
			{
				return new DepthOfField.GlobalSettings
				{
					visualizeFocus = true,
					tweakMode = DepthOfField.GEIBPMEFBFP.Range,
					filteringQuality = DepthOfField.NGPIGOBFNPP.Low,
					apertureShape = DepthOfField.NMLKCAJKBJD.Circular,
					apertureOrientation = 1204f
				};
			}

			// Token: 0x0600C0EC RID: 49388 RVA: 0x0056DE60 File Offset: 0x0056C060
			public static DepthOfField.GlobalSettings JPGMEJNEOCC()
			{
				return new DepthOfField.GlobalSettings
				{
					visualizeFocus = true,
					tweakMode = DepthOfField.GEIBPMEFBFP.Explicit,
					filteringQuality = (DepthOfField.NGPIGOBFNPP)5,
					apertureShape = DepthOfField.NMLKCAJKBJD.Circular,
					apertureOrientation = 128f
				};
			}

			// Token: 0x0600C0ED RID: 49389 RVA: 0x0056DEA4 File Offset: 0x0056C0A4
			public static DepthOfField.GlobalSettings OCIMBHLOOGC()
			{
				return new DepthOfField.GlobalSettings
				{
					visualizeFocus = true,
					tweakMode = DepthOfField.GEIBPMEFBFP.Explicit,
					filteringQuality = DepthOfField.NGPIGOBFNPP.Low,
					apertureShape = DepthOfField.NMLKCAJKBJD.Circular,
					apertureOrientation = 1467f
				};
			}

			// Token: 0x0600C0EE RID: 49390 RVA: 0x0056DEE8 File Offset: 0x0056C0E8
			public static DepthOfField.GlobalSettings NLCHLENDMLI()
			{
				return new DepthOfField.GlobalSettings
				{
					visualizeFocus = true,
					tweakMode = DepthOfField.GEIBPMEFBFP.Range,
					filteringQuality = (DepthOfField.NGPIGOBFNPP)8,
					apertureShape = DepthOfField.NMLKCAJKBJD.Hexagonal,
					apertureOrientation = 1714f
				};
			}

			// Token: 0x0600C0EF RID: 49391 RVA: 0x0056DF2C File Offset: 0x0056C12C
			public static DepthOfField.GlobalSettings OOKKEMFPNBJ()
			{
				return new DepthOfField.GlobalSettings
				{
					visualizeFocus = true,
					tweakMode = DepthOfField.GEIBPMEFBFP.Explicit,
					filteringQuality = (DepthOfField.NGPIGOBFNPP)5,
					apertureShape = DepthOfField.NMLKCAJKBJD.Hexagonal,
					apertureOrientation = 1185f
				};
			}

			// Token: 0x0600C0F0 RID: 49392 RVA: 0x0056DF70 File Offset: 0x0056C170
			public static DepthOfField.GlobalSettings MKEJGGFNILJ()
			{
				return new DepthOfField.GlobalSettings
				{
					visualizeFocus = true,
					tweakMode = DepthOfField.GEIBPMEFBFP.Range,
					filteringQuality = (DepthOfField.NGPIGOBFNPP)5,
					apertureShape = DepthOfField.NMLKCAJKBJD.Hexagonal,
					apertureOrientation = 1038f
				};
			}

			// Token: 0x0600C0F1 RID: 49393 RVA: 0x0056DFB4 File Offset: 0x0056C1B4
			public static DepthOfField.GlobalSettings MEFEDCEEAMK()
			{
				return new DepthOfField.GlobalSettings
				{
					visualizeFocus = false,
					tweakMode = DepthOfField.GEIBPMEFBFP.Range,
					filteringQuality = (DepthOfField.NGPIGOBFNPP)8,
					apertureShape = DepthOfField.NMLKCAJKBJD.Hexagonal,
					apertureOrientation = 1976f
				};
			}

			// Token: 0x0600C0F2 RID: 49394 RVA: 0x0056DFF8 File Offset: 0x0056C1F8
			public static DepthOfField.GlobalSettings NJJBBDIFPKH()
			{
				return new DepthOfField.GlobalSettings
				{
					visualizeFocus = false,
					tweakMode = DepthOfField.GEIBPMEFBFP.Explicit,
					filteringQuality = (DepthOfField.NGPIGOBFNPP)4,
					apertureShape = DepthOfField.NMLKCAJKBJD.Hexagonal,
					apertureOrientation = 1007f
				};
			}

			// Token: 0x0600C0F3 RID: 49395 RVA: 0x0056E03C File Offset: 0x0056C23C
			public static DepthOfField.GlobalSettings MJLLLKFIDOE()
			{
				return new DepthOfField.GlobalSettings
				{
					visualizeFocus = false,
					tweakMode = DepthOfField.GEIBPMEFBFP.Explicit,
					filteringQuality = (DepthOfField.NGPIGOBFNPP)3,
					apertureShape = DepthOfField.NMLKCAJKBJD.Hexagonal,
					apertureOrientation = 1256f
				};
			}

			// Token: 0x04001969 RID: 6505
			[Tooltip("Allows to view where the blur will be applied. Yellow for near blur, blue for far blur.")]
			public bool visualizeFocus;

			// Token: 0x0400196A RID: 6506
			[Tooltip("Setup mode. Use \"Advanced\" if you need more control on blur settings and/or want to use a bokeh texture. \"Explicit\" is the same as \"Advanced\" but makes use of \"Near Plane\" and \"Far Plane\" values instead of \"F-Stop\".")]
			public DepthOfField.GEIBPMEFBFP tweakMode;

			// Token: 0x0400196B RID: 6507
			[Tooltip("Quality presets. Use \"Custom\" for more advanced settings.")]
			public DepthOfField.NGPIGOBFNPP filteringQuality;

			// Token: 0x0400196C RID: 6508
			[Tooltip("\"Circular\" is the fastest, followed by \"Hexagonal\" and \"Octogonal\".")]
			public DepthOfField.NMLKCAJKBJD apertureShape;

			// Token: 0x0400196D RID: 6509
			[Tooltip("Rotates the aperture when working with \"Hexagonal\" and \"Ortogonal\".")]
			[Range(0f, 179f)]
			public float apertureOrientation;
		}

		// Token: 0x02000366 RID: 870
		[Serializable]
		public struct QualitySettings
		{
			// Token: 0x0400196E RID: 6510
			[Tooltip("Enable this to get smooth bokeh.")]
			public bool prefilterBlur;

			// Token: 0x0400196F RID: 6511
			[Tooltip("Applies a median filter for even smoother bokeh.")]
			public DepthOfField.EDNHOOMFJOP medianFilter;

			// Token: 0x04001970 RID: 6512
			[Tooltip("Dilates near blur over in focus area.")]
			public bool dilateNearBlur;

			// Token: 0x04001971 RID: 6513
			public static DepthOfField.QualitySettings[] presetQualitySettings = new DepthOfField.QualitySettings[]
			{
				new DepthOfField.QualitySettings
				{
					prefilterBlur = false,
					medianFilter = DepthOfField.EDNHOOMFJOP.None,
					dilateNearBlur = false
				},
				new DepthOfField.QualitySettings
				{
					prefilterBlur = true,
					medianFilter = DepthOfField.EDNHOOMFJOP.Normal,
					dilateNearBlur = false
				},
				new DepthOfField.QualitySettings
				{
					prefilterBlur = true,
					medianFilter = DepthOfField.EDNHOOMFJOP.High,
					dilateNearBlur = true
				}
			};
		}

		// Token: 0x02000367 RID: 871
		[Serializable]
		public struct FocusSettings
		{
			// Token: 0x0600C0F5 RID: 49397 RVA: 0x0056E110 File Offset: 0x0056C310
			public static DepthOfField.FocusSettings MDDBLMDKDAO()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 1146f,
					range = 1773f,
					nearPlane = 506f,
					nearFalloff = 407f,
					farPlane = 1333f,
					farFalloff = 465f,
					nearBlurRadius = 1611f,
					farBlurRadius = 1148f
				};
			}

			// Token: 0x0600C0F6 RID: 49398 RVA: 0x0056E190 File Offset: 0x0056C390
			public static DepthOfField.FocusSettings DHCNIDFOOPO()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 241f,
					range = 921f,
					nearPlane = 779f,
					nearFalloff = 870f,
					farPlane = 1409f,
					farFalloff = 843f,
					nearBlurRadius = 1423f,
					farBlurRadius = 1596f
				};
			}

			// Token: 0x0600C0F7 RID: 49399 RVA: 0x0056E210 File Offset: 0x0056C410
			public static DepthOfField.FocusSettings FMLMIDJIEOP()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 1614f,
					range = 1667f,
					nearPlane = 360f,
					nearFalloff = 1346f,
					farPlane = 369f,
					farFalloff = 1002f,
					nearBlurRadius = 1416f,
					farBlurRadius = 414f
				};
			}

			// Token: 0x0600C0F8 RID: 49400 RVA: 0x0056E290 File Offset: 0x0056C490
			public static DepthOfField.FocusSettings MKEJGGFNILJ()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 1146f,
					range = 977f,
					nearPlane = 1796f,
					nearFalloff = 1887f,
					farPlane = 367f,
					farFalloff = 1040f,
					nearBlurRadius = 1969f,
					farBlurRadius = 1043f
				};
			}

			// Token: 0x0600C0F9 RID: 49401 RVA: 0x0056E310 File Offset: 0x0056C510
			public static DepthOfField.FocusSettings CGGMKBADCBM()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 568f,
					range = 1404f,
					nearPlane = 1877f,
					nearFalloff = 140f,
					farPlane = 1887f,
					farFalloff = 539f,
					nearBlurRadius = 515f,
					farBlurRadius = 857f
				};
			}

			// Token: 0x0600C0FA RID: 49402 RVA: 0x0056E390 File Offset: 0x0056C590
			public static DepthOfField.FocusSettings JPGMEJNEOCC()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 1801f,
					range = 1808f,
					nearPlane = 1662f,
					nearFalloff = 531f,
					farPlane = 1753f,
					farFalloff = 1375f,
					nearBlurRadius = 1515f,
					farBlurRadius = 504f
				};
			}

			// Token: 0x0600C0FB RID: 49403 RVA: 0x0056E410 File Offset: 0x0056C610
			public static DepthOfField.FocusSettings PIAJOHPDMNA()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 148f,
					range = 314f,
					nearPlane = 322f,
					nearFalloff = 1287f,
					farPlane = 867f,
					farFalloff = 1568f,
					nearBlurRadius = 1941f,
					farBlurRadius = 18f
				};
			}

			// Token: 0x170002A5 RID: 677
			// (get) Token: 0x0600C0FC RID: 49404 RVA: 0x0056E490 File Offset: 0x0056C690
			public static DepthOfField.FocusSettings defaultSettings
			{
				get
				{
					return new DepthOfField.FocusSettings
					{
						transform = null,
						focusPlane = 20f,
						range = 35f,
						nearPlane = 2.5f,
						nearFalloff = 15f,
						farPlane = 37.5f,
						farFalloff = 50f,
						nearBlurRadius = 15f,
						farBlurRadius = 20f
					};
				}
			}

			// Token: 0x0600C0FD RID: 49405 RVA: 0x0056E510 File Offset: 0x0056C710
			public static DepthOfField.FocusSettings DELLGIGMFLC()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 1411f,
					range = 1719f,
					nearPlane = 1150f,
					nearFalloff = 1841f,
					farPlane = 1161f,
					farFalloff = 1953f,
					nearBlurRadius = 13f,
					farBlurRadius = 1904f
				};
			}

			// Token: 0x0600C0FE RID: 49406 RVA: 0x0056E590 File Offset: 0x0056C790
			public static DepthOfField.FocusSettings NLCHLENDMLI()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 396f,
					range = 997f,
					nearPlane = 1778f,
					nearFalloff = 1507f,
					farPlane = 167f,
					farFalloff = 741f,
					nearBlurRadius = 1000f,
					farBlurRadius = 1715f
				};
			}

			// Token: 0x0600C0FF RID: 49407 RVA: 0x0056E610 File Offset: 0x0056C810
			public static DepthOfField.FocusSettings AAPKKAPOLKH()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 267f,
					range = 433f,
					nearPlane = 1836f,
					nearFalloff = 1927f,
					farPlane = 598f,
					farFalloff = 1491f,
					nearBlurRadius = 3f,
					farBlurRadius = 1841f
				};
			}

			// Token: 0x0600C100 RID: 49408 RVA: 0x0056E690 File Offset: 0x0056C890
			public static DepthOfField.FocusSettings MDDFLLOCDEA()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 68f,
					range = 736f,
					nearPlane = 1011f,
					nearFalloff = 710f,
					farPlane = 1557f,
					farFalloff = 1521f,
					nearBlurRadius = 1396f,
					farBlurRadius = 1736f
				};
			}

			// Token: 0x0600C101 RID: 49409 RVA: 0x0056E710 File Offset: 0x0056C910
			public static DepthOfField.FocusSettings HMDLEIJHKEP()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 1248f,
					range = 1632f,
					nearPlane = 1829f,
					nearFalloff = 168f,
					farPlane = 1977f,
					farFalloff = 618f,
					nearBlurRadius = 39f,
					farBlurRadius = 293f
				};
			}

			// Token: 0x0600C102 RID: 49410 RVA: 0x0056E790 File Offset: 0x0056C990
			public static DepthOfField.FocusSettings HLLBKJENCLA()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 706f,
					range = 1741f,
					nearPlane = 1464f,
					nearFalloff = 1088f,
					farPlane = 1167f,
					farFalloff = 261f,
					nearBlurRadius = 390f,
					farBlurRadius = 448f
				};
			}

			// Token: 0x0600C103 RID: 49411 RVA: 0x0056E810 File Offset: 0x0056CA10
			public static DepthOfField.FocusSettings FBBLPICJODA()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 271f,
					range = 508f,
					nearPlane = 629f,
					nearFalloff = 738f,
					farPlane = 1537f,
					farFalloff = 1124f,
					nearBlurRadius = 996f,
					farBlurRadius = 897f
				};
			}

			// Token: 0x0600C104 RID: 49412 RVA: 0x0056E890 File Offset: 0x0056CA90
			public static DepthOfField.FocusSettings OOKKEMFPNBJ()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 1720f,
					range = 1409f,
					nearPlane = 822f,
					nearFalloff = 862f,
					farPlane = 555f,
					farFalloff = 1696f,
					nearBlurRadius = 40f,
					farBlurRadius = 59f
				};
			}

			// Token: 0x0600C105 RID: 49413 RVA: 0x0056E910 File Offset: 0x0056CB10
			public static DepthOfField.FocusSettings NNNMNENCOBC()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 1404f,
					range = 1111f,
					nearPlane = 1972f,
					nearFalloff = 1779f,
					farPlane = 1889f,
					farFalloff = 982f,
					nearBlurRadius = 1863f,
					farBlurRadius = 542f
				};
			}

			// Token: 0x0600C106 RID: 49414 RVA: 0x0056E990 File Offset: 0x0056CB90
			public static DepthOfField.FocusSettings COINKHKLJAP()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 845f,
					range = 622f,
					nearPlane = 1965f,
					nearFalloff = 1539f,
					farPlane = 981f,
					farFalloff = 908f,
					nearBlurRadius = 1279f,
					farBlurRadius = 982f
				};
			}

			// Token: 0x0600C107 RID: 49415 RVA: 0x0056EA10 File Offset: 0x0056CC10
			public static DepthOfField.FocusSettings MDGIIBPIGJC()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 1591f,
					range = 433f,
					nearPlane = 541f,
					nearFalloff = 1254f,
					farPlane = 920f,
					farFalloff = 536f,
					nearBlurRadius = 1211f,
					farBlurRadius = 791f
				};
			}

			// Token: 0x0600C108 RID: 49416 RVA: 0x0056EA90 File Offset: 0x0056CC90
			public static DepthOfField.FocusSettings IGIKNGLDPJB()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 1953f,
					range = 1314f,
					nearPlane = 483f,
					nearFalloff = 1340f,
					farPlane = 928f,
					farFalloff = 1095f,
					nearBlurRadius = 112f,
					farBlurRadius = 1369f
				};
			}

			// Token: 0x0600C109 RID: 49417 RVA: 0x0056EB10 File Offset: 0x0056CD10
			public static DepthOfField.FocusSettings MEFEDCEEAMK()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 628f,
					range = 470f,
					nearPlane = 138f,
					nearFalloff = 260f,
					farPlane = 400f,
					farFalloff = 524f,
					nearBlurRadius = 338f,
					farBlurRadius = 1124f
				};
			}

			// Token: 0x0600C10A RID: 49418 RVA: 0x0056EB90 File Offset: 0x0056CD90
			public static DepthOfField.FocusSettings GDKPNHJPBKJ()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 1260f,
					range = 763f,
					nearPlane = 1079f,
					nearFalloff = 1330f,
					farPlane = 1670f,
					farFalloff = 1401f,
					nearBlurRadius = 130f,
					farBlurRadius = 1228f
				};
			}

			// Token: 0x0600C10B RID: 49419 RVA: 0x0056EC10 File Offset: 0x0056CE10
			public static DepthOfField.FocusSettings MJLLLKFIDOE()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 391f,
					range = 1967f,
					nearPlane = 204f,
					nearFalloff = 339f,
					farPlane = 91f,
					farFalloff = 270f,
					nearBlurRadius = 553f,
					farBlurRadius = 588f
				};
			}

			// Token: 0x0600C10C RID: 49420 RVA: 0x0056EC90 File Offset: 0x0056CE90
			public static DepthOfField.FocusSettings NJJBBDIFPKH()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 962f,
					range = 57f,
					nearPlane = 1810f,
					nearFalloff = 1534f,
					farPlane = 1497f,
					farFalloff = 1919f,
					nearBlurRadius = 1180f,
					farBlurRadius = 15f
				};
			}

			// Token: 0x0600C10D RID: 49421 RVA: 0x0056ED10 File Offset: 0x0056CF10
			public static DepthOfField.FocusSettings OOFOKHIDMDG()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 103f,
					range = 7f,
					nearPlane = 426f,
					nearFalloff = 1783f,
					farPlane = 771f,
					farFalloff = 10f,
					nearBlurRadius = 1500f,
					farBlurRadius = 1545f
				};
			}

			// Token: 0x0600C10E RID: 49422 RVA: 0x0056ED90 File Offset: 0x0056CF90
			public static DepthOfField.FocusSettings OCIMBHLOOGC()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 197f,
					range = 1422f,
					nearPlane = 1560f,
					nearFalloff = 1108f,
					farPlane = 1824f,
					farFalloff = 423f,
					nearBlurRadius = 46f,
					farBlurRadius = 1150f
				};
			}

			// Token: 0x04001972 RID: 6514
			[Tooltip("Auto-focus on a selected transform.")]
			public Transform transform;

			// Token: 0x04001973 RID: 6515
			[BKALGGGLDHJ(0f)]
			[Tooltip("Focus distance (in world units).")]
			public float focusPlane;

			// Token: 0x04001974 RID: 6516
			[Tooltip("Focus range (in world units). The focus plane is located in the center of the range.")]
			[BKALGGGLDHJ(0.1f)]
			public float range;

			// Token: 0x04001975 RID: 6517
			[BKALGGGLDHJ(0f)]
			[Tooltip("Near focus distance (in world units).")]
			public float nearPlane;

			// Token: 0x04001976 RID: 6518
			[BKALGGGLDHJ(0f)]
			[Tooltip("Near blur falloff (in world units).")]
			public float nearFalloff;

			// Token: 0x04001977 RID: 6519
			[BKALGGGLDHJ(0f)]
			[Tooltip("Far focus distance (in world units).")]
			public float farPlane;

			// Token: 0x04001978 RID: 6520
			[BKALGGGLDHJ(0f)]
			[Tooltip("Far blur falloff (in world units).")]
			public float farFalloff;

			// Token: 0x04001979 RID: 6521
			[Range(0f, 40f)]
			[Tooltip("Maximum blur radius for the near plane.")]
			public float nearBlurRadius;

			// Token: 0x0400197A RID: 6522
			[Range(0f, 40f)]
			[Tooltip("Maximum blur radius for the far plane.")]
			public float farBlurRadius;
		}

		// Token: 0x02000368 RID: 872
		[Serializable]
		public struct BokehTextureSettings
		{
			// Token: 0x0600C10F RID: 49423 RVA: 0x0056EE10 File Offset: 0x0056D010
			public static DepthOfField.BokehTextureSettings OOFOKHIDMDG()
			{
				return new DepthOfField.BokehTextureSettings
				{
					texture = null,
					scale = 725f,
					intensity = 875f,
					threshold = 314f,
					spawnHeuristic = 1626f
				};
			}

			// Token: 0x0600C110 RID: 49424 RVA: 0x0056EE60 File Offset: 0x0056D060
			public static DepthOfField.BokehTextureSettings HMDLEIJHKEP()
			{
				return new DepthOfField.BokehTextureSettings
				{
					texture = null,
					scale = 1179f,
					intensity = 628f,
					threshold = 550f,
					spawnHeuristic = 1659f
				};
			}

			// Token: 0x0600C111 RID: 49425 RVA: 0x0056EEB0 File Offset: 0x0056D0B0
			public static DepthOfField.BokehTextureSettings MEBNDNNHNMB()
			{
				return new DepthOfField.BokehTextureSettings
				{
					texture = null,
					scale = 496f,
					intensity = 1683f,
					threshold = 1281f,
					spawnHeuristic = 1360f
				};
			}

			// Token: 0x0600C112 RID: 49426 RVA: 0x0056EF00 File Offset: 0x0056D100
			public static DepthOfField.BokehTextureSettings JPGMEJNEOCC()
			{
				return new DepthOfField.BokehTextureSettings
				{
					texture = null,
					scale = 13f,
					intensity = 1734f,
					threshold = 1909f,
					spawnHeuristic = 1144f
				};
			}

			// Token: 0x0600C113 RID: 49427 RVA: 0x0056EF50 File Offset: 0x0056D150
			public static DepthOfField.BokehTextureSettings BJNIBDPAHBP()
			{
				return new DepthOfField.BokehTextureSettings
				{
					texture = null,
					scale = 1301f,
					intensity = 363f,
					threshold = 164f,
					spawnHeuristic = 232f
				};
			}

			// Token: 0x0600C114 RID: 49428 RVA: 0x0056EFA0 File Offset: 0x0056D1A0
			public static DepthOfField.BokehTextureSettings OOKKEMFPNBJ()
			{
				return new DepthOfField.BokehTextureSettings
				{
					texture = null,
					scale = 1397f,
					intensity = 1444f,
					threshold = 1808f,
					spawnHeuristic = 850f
				};
			}

			// Token: 0x0600C115 RID: 49429 RVA: 0x0056EFF0 File Offset: 0x0056D1F0
			public static DepthOfField.BokehTextureSettings LNGBMOGJKGD()
			{
				return new DepthOfField.BokehTextureSettings
				{
					texture = null,
					scale = 1471f,
					intensity = 1884f,
					threshold = 335f,
					spawnHeuristic = 402f
				};
			}

			// Token: 0x0600C116 RID: 49430 RVA: 0x0056F040 File Offset: 0x0056D240
			public static DepthOfField.BokehTextureSettings MJLLLKFIDOE()
			{
				return new DepthOfField.BokehTextureSettings
				{
					texture = null,
					scale = 1466f,
					intensity = 1449f,
					threshold = 1097f,
					spawnHeuristic = 1119f
				};
			}

			// Token: 0x0600C117 RID: 49431 RVA: 0x0056F090 File Offset: 0x0056D290
			public static DepthOfField.BokehTextureSettings COINKHKLJAP()
			{
				return new DepthOfField.BokehTextureSettings
				{
					texture = null,
					scale = 991f,
					intensity = 966f,
					threshold = 1170f,
					spawnHeuristic = 865f
				};
			}

			// Token: 0x0600C118 RID: 49432 RVA: 0x0056F0E0 File Offset: 0x0056D2E0
			public static DepthOfField.BokehTextureSettings FMLMIDJIEOP()
			{
				return new DepthOfField.BokehTextureSettings
				{
					texture = null,
					scale = 1156f,
					intensity = 1592f,
					threshold = 933f,
					spawnHeuristic = 161f
				};
			}

			// Token: 0x0600C119 RID: 49433 RVA: 0x0056F130 File Offset: 0x0056D330
			public static DepthOfField.BokehTextureSettings BNGFNAFFAME()
			{
				return new DepthOfField.BokehTextureSettings
				{
					texture = null,
					scale = 126f,
					intensity = 623f,
					threshold = 1697f,
					spawnHeuristic = 1773f
				};
			}

			// Token: 0x0600C11A RID: 49434 RVA: 0x0056F180 File Offset: 0x0056D380
			public static DepthOfField.BokehTextureSettings HIPJDBACJDH()
			{
				return new DepthOfField.BokehTextureSettings
				{
					texture = null,
					scale = 693f,
					intensity = 1814f,
					threshold = 380f,
					spawnHeuristic = 1053f
				};
			}

			// Token: 0x0600C11B RID: 49435 RVA: 0x0056F1D0 File Offset: 0x0056D3D0
			public static DepthOfField.BokehTextureSettings FBBLPICJODA()
			{
				return new DepthOfField.BokehTextureSettings
				{
					texture = null,
					scale = 1633f,
					intensity = 720f,
					threshold = 1093f,
					spawnHeuristic = 1578f
				};
			}

			// Token: 0x0600C11C RID: 49436 RVA: 0x0056F220 File Offset: 0x0056D420
			public static DepthOfField.BokehTextureSettings MEFEDCEEAMK()
			{
				return new DepthOfField.BokehTextureSettings
				{
					texture = null,
					scale = 625f,
					intensity = 1389f,
					threshold = 826f,
					spawnHeuristic = 1113f
				};
			}

			// Token: 0x0600C11D RID: 49437 RVA: 0x0056F270 File Offset: 0x0056D470
			public static DepthOfField.BokehTextureSettings ILFHFFCIBPJ()
			{
				return new DepthOfField.BokehTextureSettings
				{
					texture = null,
					scale = 233f,
					intensity = 510f,
					threshold = 72f,
					spawnHeuristic = 908f
				};
			}

			// Token: 0x0600C11E RID: 49438 RVA: 0x0056F2C0 File Offset: 0x0056D4C0
			public static DepthOfField.BokehTextureSettings PIAJOHPDMNA()
			{
				return new DepthOfField.BokehTextureSettings
				{
					texture = null,
					scale = 1954f,
					intensity = 681f,
					threshold = 157f,
					spawnHeuristic = 1083f
				};
			}

			// Token: 0x0600C11F RID: 49439 RVA: 0x0056F310 File Offset: 0x0056D510
			public static DepthOfField.BokehTextureSettings CGGMKBADCBM()
			{
				return new DepthOfField.BokehTextureSettings
				{
					texture = null,
					scale = 342f,
					intensity = 1763f,
					threshold = 723f,
					spawnHeuristic = 714f
				};
			}

			// Token: 0x170002A6 RID: 678
			// (get) Token: 0x0600C120 RID: 49440 RVA: 0x0056F360 File Offset: 0x0056D560
			public static DepthOfField.BokehTextureSettings defaultSettings
			{
				get
				{
					return new DepthOfField.BokehTextureSettings
					{
						texture = null,
						scale = 1f,
						intensity = 50f,
						threshold = 2f,
						spawnHeuristic = 0.15f
					};
				}
			}

			// Token: 0x0600C121 RID: 49441 RVA: 0x0056F3B0 File Offset: 0x0056D5B0
			public static DepthOfField.BokehTextureSettings BFFANDBCLFI()
			{
				return new DepthOfField.BokehTextureSettings
				{
					texture = null,
					scale = 349f,
					intensity = 1926f,
					threshold = 846f,
					spawnHeuristic = 215f
				};
			}

			// Token: 0x0600C122 RID: 49442 RVA: 0x0056F400 File Offset: 0x0056D600
			public static DepthOfField.BokehTextureSettings COJPKDJKJAM()
			{
				return new DepthOfField.BokehTextureSettings
				{
					texture = null,
					scale = 1283f,
					intensity = 1536f,
					threshold = 222f,
					spawnHeuristic = 1447f
				};
			}

			// Token: 0x0600C123 RID: 49443 RVA: 0x0056F450 File Offset: 0x0056D650
			public static DepthOfField.BokehTextureSettings HLLBKJENCLA()
			{
				return new DepthOfField.BokehTextureSettings
				{
					texture = null,
					scale = 104f,
					intensity = 373f,
					threshold = 459f,
					spawnHeuristic = 1601f
				};
			}

			// Token: 0x0600C124 RID: 49444 RVA: 0x0056F4A0 File Offset: 0x0056D6A0
			public static DepthOfField.BokehTextureSettings DHCNIDFOOPO()
			{
				return new DepthOfField.BokehTextureSettings
				{
					texture = null,
					scale = 790f,
					intensity = 291f,
					threshold = 1256f,
					spawnHeuristic = 1785f
				};
			}

			// Token: 0x0600C125 RID: 49445 RVA: 0x0056F4F0 File Offset: 0x0056D6F0
			public static DepthOfField.BokehTextureSettings OCIMBHLOOGC()
			{
				return new DepthOfField.BokehTextureSettings
				{
					texture = null,
					scale = 1347f,
					intensity = 824f,
					threshold = 1664f,
					spawnHeuristic = 1721f
				};
			}

			// Token: 0x0600C126 RID: 49446 RVA: 0x0056F540 File Offset: 0x0056D740
			public static DepthOfField.BokehTextureSettings ADJNPGFJGJI()
			{
				return new DepthOfField.BokehTextureSettings
				{
					texture = null,
					scale = 570f,
					intensity = 836f,
					threshold = 1066f,
					spawnHeuristic = 263f
				};
			}

			// Token: 0x0600C127 RID: 49447 RVA: 0x0056F590 File Offset: 0x0056D790
			public static DepthOfField.BokehTextureSettings NPEIGPHIHFP()
			{
				return new DepthOfField.BokehTextureSettings
				{
					texture = null,
					scale = 1546f,
					intensity = 1615f,
					threshold = 319f,
					spawnHeuristic = 668f
				};
			}

			// Token: 0x0600C128 RID: 49448 RVA: 0x0056F5E0 File Offset: 0x0056D7E0
			public static DepthOfField.BokehTextureSettings NNNMNENCOBC()
			{
				return new DepthOfField.BokehTextureSettings
				{
					texture = null,
					scale = 1399f,
					intensity = 1201f,
					threshold = 1819f,
					spawnHeuristic = 1167f
				};
			}

			// Token: 0x0600C129 RID: 49449 RVA: 0x0056F630 File Offset: 0x0056D830
			public static DepthOfField.BokehTextureSettings MKEJGGFNILJ()
			{
				return new DepthOfField.BokehTextureSettings
				{
					texture = null,
					scale = 1346f,
					intensity = 483f,
					threshold = 405f,
					spawnHeuristic = 1589f
				};
			}

			// Token: 0x0600C12A RID: 49450 RVA: 0x0056F680 File Offset: 0x0056D880
			public static DepthOfField.BokehTextureSettings IGIKNGLDPJB()
			{
				return new DepthOfField.BokehTextureSettings
				{
					texture = null,
					scale = 770f,
					intensity = 650f,
					threshold = 160f,
					spawnHeuristic = 615f
				};
			}

			// Token: 0x0600C12B RID: 49451 RVA: 0x0056F6D0 File Offset: 0x0056D8D0
			public static DepthOfField.BokehTextureSettings MDDFLLOCDEA()
			{
				return new DepthOfField.BokehTextureSettings
				{
					texture = null,
					scale = 1304f,
					intensity = 1612f,
					threshold = 1150f,
					spawnHeuristic = 1860f
				};
			}

			// Token: 0x0600C12C RID: 49452 RVA: 0x0056F720 File Offset: 0x0056D920
			public static DepthOfField.BokehTextureSettings DELLGIGMFLC()
			{
				return new DepthOfField.BokehTextureSettings
				{
					texture = null,
					scale = 1726f,
					intensity = 228f,
					threshold = 1073f,
					spawnHeuristic = 342f
				};
			}

			// Token: 0x0600C12D RID: 49453 RVA: 0x0056F770 File Offset: 0x0056D970
			public static DepthOfField.BokehTextureSettings AAPKKAPOLKH()
			{
				return new DepthOfField.BokehTextureSettings
				{
					texture = null,
					scale = 786f,
					intensity = 530f,
					threshold = 1543f,
					spawnHeuristic = 355f
				};
			}

			// Token: 0x0600C12E RID: 49454 RVA: 0x0056F7C0 File Offset: 0x0056D9C0
			public static DepthOfField.BokehTextureSettings JACPKLDIIKG()
			{
				return new DepthOfField.BokehTextureSettings
				{
					texture = null,
					scale = 402f,
					intensity = 850f,
					threshold = 212f,
					spawnHeuristic = 1899f
				};
			}

			// Token: 0x0600C12F RID: 49455 RVA: 0x0056F810 File Offset: 0x0056DA10
			public static DepthOfField.BokehTextureSettings MCLJECOKBEJ()
			{
				return new DepthOfField.BokehTextureSettings
				{
					texture = null,
					scale = 1101f,
					intensity = 1040f,
					threshold = 1521f,
					spawnHeuristic = 717f
				};
			}

			// Token: 0x0600C130 RID: 49456 RVA: 0x0056F860 File Offset: 0x0056DA60
			public static DepthOfField.BokehTextureSettings MGIIIBAJNIE()
			{
				return new DepthOfField.BokehTextureSettings
				{
					texture = null,
					scale = 251f,
					intensity = 828f,
					threshold = 1621f,
					spawnHeuristic = 345f
				};
			}

			// Token: 0x0600C131 RID: 49457 RVA: 0x0056F8B0 File Offset: 0x0056DAB0
			public static DepthOfField.BokehTextureSettings GDKPNHJPBKJ()
			{
				return new DepthOfField.BokehTextureSettings
				{
					texture = null,
					scale = 696f,
					intensity = 223f,
					threshold = 961f,
					spawnHeuristic = 214f
				};
			}

			// Token: 0x0600C132 RID: 49458 RVA: 0x0056F900 File Offset: 0x0056DB00
			public static DepthOfField.BokehTextureSettings NJJBBDIFPKH()
			{
				return new DepthOfField.BokehTextureSettings
				{
					texture = null,
					scale = 181f,
					intensity = 915f,
					threshold = 318f,
					spawnHeuristic = 896f
				};
			}

			// Token: 0x0600C133 RID: 49459 RVA: 0x0056F950 File Offset: 0x0056DB50
			public static DepthOfField.BokehTextureSettings NLCHLENDMLI()
			{
				return new DepthOfField.BokehTextureSettings
				{
					texture = null,
					scale = 1720f,
					intensity = 1284f,
					threshold = 1266f,
					spawnHeuristic = 1443f
				};
			}

			// Token: 0x0600C134 RID: 49460 RVA: 0x0056F9A0 File Offset: 0x0056DBA0
			public static DepthOfField.BokehTextureSettings MDGIIBPIGJC()
			{
				return new DepthOfField.BokehTextureSettings
				{
					texture = null,
					scale = 1955f,
					intensity = 1772f,
					threshold = 1765f,
					spawnHeuristic = 1839f
				};
			}

			// Token: 0x0600C135 RID: 49461 RVA: 0x0056F9F0 File Offset: 0x0056DBF0
			public static DepthOfField.BokehTextureSettings MDDBLMDKDAO()
			{
				return new DepthOfField.BokehTextureSettings
				{
					texture = null,
					scale = 1298f,
					intensity = 1001f,
					threshold = 1352f,
					spawnHeuristic = 759f
				};
			}

			// Token: 0x0400197B RID: 6523
			[Tooltip("Adding a texture to this field will enable the use of \"Bokeh Textures\". Use with care. This feature is only available on Shader Model 5 compatible-hardware and performance scale with the amount of bokeh.")]
			public Texture2D texture;

			// Token: 0x0400197C RID: 6524
			[Range(0.01f, 10f)]
			[Tooltip("Maximum size of bokeh textures on screen.")]
			public float scale;

			// Token: 0x0400197D RID: 6525
			[Range(0.01f, 100f)]
			[Tooltip("Bokeh brightness.")]
			public float intensity;

			// Token: 0x0400197E RID: 6526
			[Range(0.01f, 5f)]
			[Tooltip("Controls the amount of bokeh textures. Lower values mean more bokeh splats.")]
			public float threshold;

			// Token: 0x0400197F RID: 6527
			[Range(0.01f, 1f)]
			[Tooltip("Controls the spawn conditions. Lower values mean more visible bokeh.")]
			public float spawnHeuristic;
		}
	}
}
