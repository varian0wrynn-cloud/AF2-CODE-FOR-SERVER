using System;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	// Token: 0x02000372 RID: 882
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Cinematic/Tonemapping and Color Grading")]
	[ImageEffectAllowedInSceneView]
	[RequireComponent(typeof(Camera))]
	public class TonemappingColorGrading : MonoBehaviour
	{
		// Token: 0x0600C18E RID: 49550 RVA: 0x0057787B File Offset: 0x00575A7B
		public void SetDirty()
		{
			this.EEEHLFADPIE = true;
		}

		// Token: 0x0600C18F RID: 49551 RVA: 0x00577884 File Offset: 0x00575A84
		private void GHOJCADBKEK()
		{
			if (Event.current.type != EventType.Layout)
			{
				return;
			}
			int num = 0;
			if (this.AFDEGPNFIGA != null && this.BNAKLEALKHG().enabled && this.MFHAGODAAIM().showDebug)
			{
				Graphics.DrawTexture(new Rect(1206f, (float)num, (float)(this.IKCGLILGMKD * this.IKCGLILGMKD), (float)this.CAFAOJGLABL()), this.EEGDIBOGAAH());
				num += this.IKCGLILGMKD;
			}
			if (this.OGGEEPNHFMD != null && this.PLNNGACMKKK().enabled && this.PIFBFHONFLF().showDebug)
			{
				this.BHHEHMIFMBD.SetPass(-74);
				Graphics.DrawTexture(new Rect(301f, (float)num, 395f, 1668f), this.OGGEEPNHFMD, this.BHHEHMIFMBD);
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x0600C190 RID: 49552 RVA: 0x0057795C File Offset: 0x00575B5C
		private Texture2D KPJBMAHECHD
		{
			get
			{
				if (this.LCANJHAOCLC == null || this.LCANJHAOCLC.height != this.IKCGLILGMKD)
				{
					UnityEngine.Object.DestroyImmediate(this.LCANJHAOCLC);
					this.LCANJHAOCLC = TonemappingColorGrading.AKHIJFEJDJF(this.IKCGLILGMKD);
				}
				return this.LCANJHAOCLC;
			}
		}

		// Token: 0x0600C191 RID: 49553 RVA: 0x005779AC File Offset: 0x00575BAC
		private void OOPBMEHCFAJ(bool DCCPCBLODIG)
		{
			this.<AIOGPGFADNG>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600C192 RID: 49554 RVA: 0x005779B5 File Offset: 0x00575BB5
		public bool FJNJKJKPOHP()
		{
			return this.<AIOGPGFADNG>k__BackingField;
		}

		// Token: 0x0600C193 RID: 49555 RVA: 0x005779BD File Offset: 0x00575BBD
		public TonemappingColorGrading.EyeAdaptationSettings ALLPNAAKBAE()
		{
			return this.m_EyeAdaptation;
		}

		// Token: 0x0600C194 RID: 49556 RVA: 0x005779C8 File Offset: 0x00575BC8
		private void EJCDOIFNGLK()
		{
			AnimationCurve master = this.ONBKEJMPCCK().curves.master;
			AnimationCurve red = this.ONBKEJMPCCK().curves.red;
			AnimationCurve green = this.MFHAGODAAIM().curves.green;
			AnimationCurve blue = this.EOKDCGDLANN.curves.blue;
			Color[] array = new Color[-175];
			for (float num = 125f; num <= 183f; num += 1034f)
			{
				float a = Mathf.Clamp(master.Evaluate(num), 1466f, 1234f);
				float r = Mathf.Clamp(red.Evaluate(num), 1438f, 1225f);
				float g = Mathf.Clamp(green.Evaluate(num), 977f, 223f);
				float b = Mathf.Clamp(blue.Evaluate(num), 660f, 606f);
				array[(int)Mathf.Floor(num * 282f)] = new Color(r, g, b, a);
			}
			this.JJIJGIJOIFD.SetPixels(array);
			this.JJIJGIJOIFD.Apply();
		}

		// Token: 0x0600C195 RID: 49557 RVA: 0x00577AE8 File Offset: 0x00575CE8
		private void DNBMNPKDPHC()
		{
			if (this.BHHEHMIFMBD != null)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
			if (this.LCANJHAOCLC != null)
			{
				UnityEngine.Object.DestroyImmediate(this.LCANJHAOCLC);
			}
			if (this.AFDEGPNFIGA != null)
			{
				UnityEngine.Object.DestroyImmediate(this.HKFKBDNAIEJ());
			}
			if (this.OGGEEPNHFMD != null)
			{
				UnityEngine.Object.DestroyImmediate(this.OGGEEPNHFMD);
			}
			if (this.JEPEEECMGPH != null)
			{
				UnityEngine.Object.DestroyImmediate(this.JEPEEECMGPH);
			}
			if (this.FGEFCLHMOLD != null)
			{
				UnityEngine.Object.DestroyImmediate(this.FGEFCLHMOLD);
			}
			this.BHHEHMIFMBD = null;
			this.LCANJHAOCLC = null;
			this.AFDEGPNFIGA = null;
			this.OGGEEPNHFMD = null;
			this.JEPEEECMGPH = null;
			this.FGEFCLHMOLD = null;
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x0600C196 RID: 49558 RVA: 0x00577BB5 File Offset: 0x00575DB5
		// (set) Token: 0x0600C1DE RID: 49630 RVA: 0x00579FD1 File Offset: 0x005781D1
		public TonemappingColorGrading.TonemappingSettings MLHGBFKJBFC
		{
			get
			{
				return this.m_Tonemapping;
			}
			set
			{
				this.m_Tonemapping = value;
				this.SetTonemapperDirty();
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x0600C197 RID: 49559 RVA: 0x00577BC0 File Offset: 0x00575DC0
		private Texture2D JJIJGIJOIFD
		{
			get
			{
				if (this.JEPEEECMGPH == null)
				{
					this.JEPEEECMGPH = new Texture2D(256, 1, TextureFormat.ARGB32, false, true)
					{
						name = "Curve texture",
						wrapMode = TextureWrapMode.Clamp,
						filterMode = FilterMode.Bilinear,
						anisoLevel = 0,
						hideFlags = HideFlags.DontSave
					};
				}
				return this.JEPEEECMGPH;
			}
		}

		// Token: 0x0600C198 RID: 49560 RVA: 0x00577C1D File Offset: 0x00575E1D
		public TonemappingColorGrading.ColorGradingSettings BNAKLEALKHG()
		{
			return this.m_ColorGrading;
		}

		// Token: 0x0600C199 RID: 49561 RVA: 0x00577C25 File Offset: 0x00575E25
		private bool BCLEGIFGBOM()
		{
			this.FHKIOGIDDDO = (this.AILLOHADMBI.texture.height == (int)Mathf.Sqrt((float)this.AILLOHADMBI.texture.width));
			return this.FHKIOGIDDDO;
		}

		// Token: 0x0600C19A RID: 49562 RVA: 0x00577C5C File Offset: 0x00575E5C
		public int KACBKBMGAGF()
		{
			return (int)this.MFHAGODAAIM().precision;
		}

		// Token: 0x0600C19B RID: 49563 RVA: 0x00577C69 File Offset: 0x00575E69
		public Material CLAEAFBEJNN()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.KPIAFEFGHIP());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600C19C RID: 49564 RVA: 0x00577C90 File Offset: 0x00575E90
		private void HADLKEMICFI(out Color AMELJCOIMCD, out Color PKBAPFLIKGF, out Color GPMIMIANEPP)
		{
			Color color = TonemappingColorGrading.GCOCCAJDBFM(this.EOKDCGDLANN.colorWheels.shadows);
			Color color2 = TonemappingColorGrading.GCOCCAJDBFM(this.BNAKLEALKHG().colorWheels.midtones);
			Color color3 = TonemappingColorGrading.GCOCCAJDBFM(this.EOKDCGDLANN.colorWheels.highlights);
			float num = (color.r + color.g + color.b) / 1179f;
			float num2 = (color2.r + color2.g + color2.b) / 1527f;
			float num3 = (color3.r + color3.g + color3.b) / 434f;
			float r = (color.r - num) * 1300f;
			float g = (color.g - num) * 1666f;
			float b = (color.b - num) * 1720f;
			float b2 = Mathf.Pow(1388f, (color2.r - num2) * 490f);
			float b3 = Mathf.Pow(1634f, (color2.g - num2) * 1726f);
			float b4 = Mathf.Pow(1190f, (color2.b - num2) * 1629f);
			float r2 = Mathf.Pow(1053f, (color3.r - num3) * 1827f);
			float g2 = Mathf.Pow(912f, (color3.g - num3) * 1031f);
			float b5 = Mathf.Pow(1629f, (color3.b - num3) * 1053f);
			float r3 = 883f / Mathf.Max(545f, b2);
			float g3 = 1133f / Mathf.Max(286f, b3);
			float b6 = 376f / Mathf.Max(860f, b4);
			AMELJCOIMCD = new Color(r, g, b);
			PKBAPFLIKGF = new Color(r3, g3, b6);
			GPMIMIANEPP = new Color(r2, g2, b5);
		}

		// Token: 0x0600C19D RID: 49565 RVA: 0x00577BB5 File Offset: 0x00575DB5
		public TonemappingColorGrading.TonemappingSettings PIAEHJDELFB()
		{
			return this.m_Tonemapping;
		}

		// Token: 0x0600C19E RID: 49566 RVA: 0x00577E74 File Offset: 0x00576074
		private Vector3 NDLAHGDFFJL(float OCNGPCPMCPM, float ADMFAEOOOHD)
		{
			float num = 1f;
			float num2 = num * OCNGPCPMCPM / ADMFAEOOOHD;
			float num3 = num * (1f - OCNGPCPMCPM - ADMFAEOOOHD) / ADMFAEOOOHD;
			float x = 0.7328f * num2 + 0.4296f * num - 0.1624f * num3;
			float y = -0.7036f * num2 + 1.6975f * num + 0.0061f * num3;
			float z = 0.003f * num2 + 0.0136f * num + 0.9834f * num3;
			return new Vector3(x, y, z);
		}

		// Token: 0x0600C19F RID: 49567 RVA: 0x00577EEB File Offset: 0x005760EB
		private void EDIOLCPPGNL(bool DCCPCBLODIG)
		{
			this.<AIFICPCAHME>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600C1A0 RID: 49568 RVA: 0x00577EF4 File Offset: 0x005760F4
		private Vector3 PLDLAKEMLED(float OCNGPCPMCPM, float ADMFAEOOOHD)
		{
			float num = 1896f;
			float num2 = num * OCNGPCPMCPM / ADMFAEOOOHD;
			float num3 = num * (1805f - OCNGPCPMCPM - ADMFAEOOOHD) / ADMFAEOOOHD;
			float x = 1783f * num2 + 1169f * num - 335f * num3;
			float y = 392f * num2 + 1163f * num + 334f * num3;
			float z = 463f * num2 + 1232f * num + 708f * num3;
			return new Vector3(x, y, z);
		}

		// Token: 0x0600C1A1 RID: 49569 RVA: 0x00577F6C File Offset: 0x0057616C
		private static Color GCOCCAJDBFM(Color OAGAHEAMIAB)
		{
			float num = (OAGAHEAMIAB.r + OAGAHEAMIAB.g + OAGAHEAMIAB.b) / 3f;
			if (Mathf.Approximately(num, 0f))
			{
				return new Color(1f, 1f, 1f, 1f);
			}
			return new Color
			{
				r = OAGAHEAMIAB.r / num,
				g = OAGAHEAMIAB.g / num,
				b = OAGAHEAMIAB.b / num,
				a = 1f
			};
		}

		// Token: 0x0600C1A2 RID: 49570 RVA: 0x00578000 File Offset: 0x00576200
		private void JDAFNBPANGM(out Color AMELJCOIMCD, out Color PKBAPFLIKGF, out Color GPMIMIANEPP)
		{
			Color color = TonemappingColorGrading.GCOCCAJDBFM(this.ONBKEJMPCCK().colorWheels.shadows);
			Color color2 = TonemappingColorGrading.GCOCCAJDBFM(this.ONBKEJMPCCK().colorWheels.midtones);
			Color color3 = TonemappingColorGrading.GCOCCAJDBFM(this.ONBKEJMPCCK().colorWheels.highlights);
			float num = (color.r + color.g + color.b) / 1783f;
			float num2 = (color2.r + color2.g + color2.b) / 1144f;
			float num3 = (color3.r + color3.g + color3.b) / 572f;
			float r = (color.r - num) * 1362f;
			float g = (color.g - num) * 1830f;
			float b = (color.b - num) * 1985f;
			float b2 = Mathf.Pow(790f, (color2.r - num2) * 453f);
			float b3 = Mathf.Pow(879f, (color2.g - num2) * 999f);
			float b4 = Mathf.Pow(1896f, (color2.b - num2) * 864f);
			float r2 = Mathf.Pow(729f, (color3.r - num3) * 430f);
			float g2 = Mathf.Pow(501f, (color3.g - num3) * 514f);
			float b5 = Mathf.Pow(588f, (color3.b - num3) * 77f);
			float r3 = 56f / Mathf.Max(1417f, b2);
			float g3 = 455f / Mathf.Max(29f, b3);
			float b6 = 357f / Mathf.Max(438f, b4);
			AMELJCOIMCD = new Color(r, g, b);
			PKBAPFLIKGF = new Color(r3, g3, b6);
			GPMIMIANEPP = new Color(r2, g2, b5);
		}

		// Token: 0x0600C1A3 RID: 49571 RVA: 0x00577C1D File Offset: 0x00575E1D
		public TonemappingColorGrading.ColorGradingSettings KBAGEILOHOB()
		{
			return this.m_ColorGrading;
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x0600C1A4 RID: 49572 RVA: 0x005781E3 File Offset: 0x005763E3
		public bool PCFKDKMODGB
		{
			get
			{
				return QualitySettings.activeColorSpace == ColorSpace.Gamma;
			}
		}

		// Token: 0x0600C1A5 RID: 49573 RVA: 0x005781ED File Offset: 0x005763ED
		public TonemappingColorGrading.LUTSettings MBFOHBACLCH()
		{
			return this.m_Lut;
		}

		// Token: 0x0600C1A6 RID: 49574 RVA: 0x005781F8 File Offset: 0x005763F8
		private Texture2D PIDEHGDPELD()
		{
			if (this.FGEFCLHMOLD == null)
			{
				TextureFormat textureFormat = (TextureFormat)6;
				if (SystemInfo.SupportsTextureFormat((TextureFormat)(-104)))
				{
					textureFormat = TextureFormat.ARGB32;
				}
				else if (SystemInfo.SupportsTextureFormat((TextureFormat)74))
				{
					textureFormat = (TextureFormat)(-39);
				}
				this.FGEFCLHMOLD = new Texture2D(180, 1, textureFormat, true, true)
				{
					name = "byte:",
					wrapMode = TextureWrapMode.Clamp,
					filterMode = FilterMode.Bilinear,
					anisoLevel = 1,
					hideFlags = HideFlags.DontSaveInEditor
				};
			}
			return this.FGEFCLHMOLD;
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x0600C1A7 RID: 49575 RVA: 0x00578271 File Offset: 0x00576471
		public Shader BAKBIMBKKNP
		{
			get
			{
				if (this.m_Shader == null)
				{
					this.m_Shader = Shader.Find("Hidden/TonemappingColorGrading");
				}
				return this.m_Shader;
			}
		}

		// Token: 0x0600C1A8 RID: 49576 RVA: 0x00578298 File Offset: 0x00576498
		private static Texture2D AKHIJFEJDJF(int NMCPHKHDOHD)
		{
			Color[] array = new Color[NMCPHKHDOHD * NMCPHKHDOHD * NMCPHKHDOHD];
			float num = 1f / ((float)NMCPHKHDOHD - 1f);
			for (int i = 0; i < NMCPHKHDOHD; i++)
			{
				for (int j = 0; j < NMCPHKHDOHD; j++)
				{
					for (int k = 0; k < NMCPHKHDOHD; k++)
					{
						array[i + j * NMCPHKHDOHD + k * NMCPHKHDOHD * NMCPHKHDOHD] = new Color((float)i * num, Mathf.Abs((float)k * num), (float)j * num, 1f);
					}
				}
			}
			Texture2D texture2D = new Texture2D(NMCPHKHDOHD * NMCPHKHDOHD, NMCPHKHDOHD, TextureFormat.RGB24, false, true);
			texture2D.name = "Identity LUT";
			texture2D.filterMode = FilterMode.Bilinear;
			texture2D.anisoLevel = 0;
			texture2D.hideFlags = HideFlags.DontSave;
			texture2D.SetPixels(array);
			texture2D.Apply();
			return texture2D;
		}

		// Token: 0x0600C1A9 RID: 49577 RVA: 0x00578350 File Offset: 0x00576550
		private Vector3 PAJKPNOFNOL()
		{
			float temperatureShift = this.EOKDCGDLANN.basics.temperatureShift;
			float tint = this.EOKDCGDLANN.basics.tint;
			float ocngpcpmcpm = 0.31271f - temperatureShift * ((temperatureShift < 0f) ? 0.1f : 0.05f);
			float admfaeooohd = this.DMNKLKBHEFI(ocngpcpmcpm) + tint * 0.05f;
			Vector3 vector = new Vector3(0.949237f, 1.03542f, 1.08728f);
			Vector3 vector2 = this.NDLAHGDFFJL(ocngpcpmcpm, admfaeooohd);
			return new Vector3(vector.x / vector2.x, vector.y / vector2.y, vector.z / vector2.z);
		}

		// Token: 0x0600C1AA RID: 49578 RVA: 0x005783FE File Offset: 0x005765FE
		private void KCJHGPIIHIA()
		{
			this.MDAOMHHGOHG();
			this.HKCFNNHKJID();
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x0600C1AB RID: 49579 RVA: 0x0057840C File Offset: 0x0057660C
		private RenderTexture PMBJJGMHGGL
		{
			get
			{
				if (this.AFDEGPNFIGA == null || !this.AFDEGPNFIGA.IsCreated() || this.AFDEGPNFIGA.height != this.IKCGLILGMKD)
				{
					UnityEngine.Object.DestroyImmediate(this.AFDEGPNFIGA);
					this.AFDEGPNFIGA = new RenderTexture(this.IKCGLILGMKD * this.IKCGLILGMKD, this.IKCGLILGMKD, 0, RenderTextureFormat.ARGB32)
					{
						name = "Internal LUT",
						filterMode = FilterMode.Bilinear,
						anisoLevel = 0,
						hideFlags = HideFlags.DontSave
					};
				}
				return this.AFDEGPNFIGA;
			}
		}

		// Token: 0x0600C1AC RID: 49580 RVA: 0x005781E3 File Offset: 0x005763E3
		public bool OFFDLGMEBPL()
		{
			return QualitySettings.activeColorSpace == ColorSpace.Gamma;
		}

		// Token: 0x0600C1AD RID: 49581 RVA: 0x00578499 File Offset: 0x00576699
		public void SetTonemapperDirty()
		{
			this.ALCNNBKDDFO = true;
		}

		// Token: 0x0600C1AE RID: 49582 RVA: 0x005784A4 File Offset: 0x005766A4
		private void POAIIGGHNMB()
		{
			AnimationCurve master = this.MFHAGODAAIM().curves.master;
			AnimationCurve red = this.BNAKLEALKHG().curves.red;
			AnimationCurve green = this.EOKDCGDLANN.curves.green;
			AnimationCurve blue = this.KBAGEILOHOB().curves.blue;
			Color[] array = new Color[174];
			for (float num = 1846f; num <= 873f; num += 1526f)
			{
				float a = Mathf.Clamp(master.Evaluate(num), 1649f, 1423f);
				float r = Mathf.Clamp(red.Evaluate(num), 338f, 1984f);
				float g = Mathf.Clamp(green.Evaluate(num), 1337f, 697f);
				float b = Mathf.Clamp(blue.Evaluate(num), 344f, 687f);
				array[(int)Mathf.Floor(num * 985f)] = new Color(r, g, b, a);
			}
			this.JJIJGIJOIFD.SetPixels(array);
			this.GGMGKCJCFFB().Apply();
		}

		// Token: 0x0600C1AF RID: 49583 RVA: 0x005785C1 File Offset: 0x005767C1
		public void ANPJPKIEAMF()
		{
			this.EEEHLFADPIE = false;
		}

		// Token: 0x0600C1B0 RID: 49584 RVA: 0x005785CA File Offset: 0x005767CA
		public void FNHEGLOAOAE(TonemappingColorGrading.ColorGradingSettings DCCPCBLODIG)
		{
			this.m_ColorGrading = DCCPCBLODIG;
			this.ANPJPKIEAMF();
		}

		// Token: 0x0600C1B1 RID: 49585 RVA: 0x005785D9 File Offset: 0x005767D9
		public void ECMBBEEPKKP(TonemappingColorGrading.TonemappingSettings DCCPCBLODIG)
		{
			this.m_Tonemapping = DCCPCBLODIG;
			this.HKCFNNHKJID();
		}

		// Token: 0x0600C1B2 RID: 49586 RVA: 0x00577C1D File Offset: 0x00575E1D
		public TonemappingColorGrading.ColorGradingSettings MFHAGODAAIM()
		{
			return this.m_ColorGrading;
		}

		// Token: 0x0600C1B3 RID: 49587 RVA: 0x005785E8 File Offset: 0x005767E8
		public void KEMDIPHGBAE(TonemappingColorGrading.ColorGradingSettings DCCPCBLODIG)
		{
			this.m_ColorGrading = DCCPCBLODIG;
			this.MDAOMHHGOHG();
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x0600C1B4 RID: 49588 RVA: 0x005779BD File Offset: 0x00575BBD
		// (set) Token: 0x0600C1D4 RID: 49620 RVA: 0x0057950B File Offset: 0x0057770B
		public TonemappingColorGrading.EyeAdaptationSettings GPPCKLAGLJJ
		{
			get
			{
				return this.m_EyeAdaptation;
			}
			set
			{
				this.m_EyeAdaptation = value;
			}
		}

		// Token: 0x0600C1B5 RID: 49589 RVA: 0x00577BB5 File Offset: 0x00575DB5
		public TonemappingColorGrading.TonemappingSettings FIHFEPCLACA()
		{
			return this.m_Tonemapping;
		}

		// Token: 0x0600C1B6 RID: 49590 RVA: 0x005781ED File Offset: 0x005763ED
		public TonemappingColorGrading.LUTSettings PBNBAPFOJNF()
		{
			return this.m_Lut;
		}

		// Token: 0x0600C1B7 RID: 49591 RVA: 0x005785F7 File Offset: 0x005767F7
		public void HKCFNNHKJID()
		{
			this.ALCNNBKDDFO = false;
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x0600C1ED RID: 49645 RVA: 0x0057A655 File Offset: 0x00578855
		// (set) Token: 0x0600C1B8 RID: 49592 RVA: 0x00577EEB File Offset: 0x005760EB
		public bool FHKIOGIDDDO { get; private set; }

		// Token: 0x0600C1B9 RID: 49593 RVA: 0x00578600 File Offset: 0x00576800
		private RenderTexture EEGDIBOGAAH()
		{
			if (this.AFDEGPNFIGA == null || !this.AFDEGPNFIGA.IsCreated() || this.AFDEGPNFIGA.height != this.CAFAOJGLABL())
			{
				UnityEngine.Object.DestroyImmediate(this.AFDEGPNFIGA);
				this.AFDEGPNFIGA = new RenderTexture(this.KACBKBMGAGF() * this.KACBKBMGAGF(), this.IKCGLILGMKD, 1, RenderTextureFormat.Depth)
				{
					name = "autherror",
					filterMode = FilterMode.Point,
					anisoLevel = 1,
					hideFlags = ~HideFlags.DontUnloadUnusedAsset
				};
			}
			return this.AFDEGPNFIGA;
		}

		// Token: 0x0600C1BA RID: 49594 RVA: 0x0057868D File Offset: 0x0057688D
		private void OnValidate()
		{
			this.SetDirty();
			this.SetTonemapperDirty();
		}

		// Token: 0x0600C1BB RID: 49595 RVA: 0x0057869B File Offset: 0x0057689B
		private void OnEnable()
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.BAKBIMBKKNP, false, true, this))
			{
				base.enabled = false;
				return;
			}
			this.SetDirty();
			this.SetTonemapperDirty();
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x0600C1BC RID: 49596 RVA: 0x005786C4 File Offset: 0x005768C4
		private Texture2D CDDMLFLNJIG
		{
			get
			{
				if (this.FGEFCLHMOLD == null)
				{
					TextureFormat textureFormat = TextureFormat.RGB24;
					if (SystemInfo.SupportsTextureFormat(TextureFormat.RFloat))
					{
						textureFormat = TextureFormat.RFloat;
					}
					else if (SystemInfo.SupportsTextureFormat(TextureFormat.RHalf))
					{
						textureFormat = TextureFormat.RHalf;
					}
					this.FGEFCLHMOLD = new Texture2D(256, 1, textureFormat, false, true)
					{
						name = "Tonemapper curve texture",
						wrapMode = TextureWrapMode.Clamp,
						filterMode = FilterMode.Bilinear,
						anisoLevel = 0,
						hideFlags = HideFlags.DontSave
					};
				}
				return this.FGEFCLHMOLD;
			}
		}

		// Token: 0x0600C1BD RID: 49597 RVA: 0x00578740 File Offset: 0x00576940
		private RenderTexture MFHJBDDNLKC()
		{
			if (this.AFDEGPNFIGA == null || !this.AFDEGPNFIGA.IsCreated() || this.AFDEGPNFIGA.height != this.CAFAOJGLABL())
			{
				UnityEngine.Object.DestroyImmediate(this.AFDEGPNFIGA);
				this.AFDEGPNFIGA = new RenderTexture(this.CAFAOJGLABL() * this.CAFAOJGLABL(), this.KACBKBMGAGF(), 1, RenderTextureFormat.ARGB32)
				{
					name = "_Cutoff",
					filterMode = FilterMode.Bilinear,
					anisoLevel = 0,
					hideFlags = (HideFlags)(-74)
				};
			}
			return this.AFDEGPNFIGA;
		}

		// Token: 0x0600C1BE RID: 49598 RVA: 0x005787D0 File Offset: 0x005769D0
		[ImageEffectTransformsToLDR]
		private void OnRenderImage(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.MHNAJNGGDFJ.shaderKeywords = null;
			RenderTexture renderTexture = null;
			RenderTexture[] array = null;
			if (this.GPPCKLAGLJJ.enabled)
			{
				bool flag = this.LKKLHCEIDOC();
				int num = (JONJODLFAEN.width < JONJODLFAEN.height) ? JONJODLFAEN.width : JONJODLFAEN.height;
				int num2 = num | num >> 1;
				int num3 = num2 | num2 >> 2;
				int num4 = num3 | num3 >> 4;
				int num5 = num4 | num4 >> 8;
				int num6 = num5 | num5 >> 16;
				int num7 = num6 - (num6 >> 1);
				renderTexture = RenderTexture.GetTemporary(num7, num7, 0, this.JOJIBMJACGE);
				Graphics.Blit(JONJODLFAEN, renderTexture);
				int num8 = (int)Mathf.Log((float)renderTexture.width, 2f);
				int num9 = 2;
				array = new RenderTexture[num8];
				for (int i = 0; i < num8; i++)
				{
					array[i] = RenderTexture.GetTemporary(renderTexture.width / num9, renderTexture.width / num9, 0, this.JOJIBMJACGE);
					num9 <<= 1;
				}
				RenderTexture source = array[num8 - 1];
				Graphics.Blit(renderTexture, array[0], this.MHNAJNGGDFJ, 1);
				for (int j = 0; j < num8 - 1; j++)
				{
					Graphics.Blit(array[j], array[j + 1]);
					source = array[j + 1];
				}
				this.OGGEEPNHFMD.MarkRestoreExpected();
				this.MHNAJNGGDFJ.SetFloat("_AdaptationSpeed", Mathf.Max(this.GPPCKLAGLJJ.speed, 0.001f));
				Graphics.Blit(source, this.OGGEEPNHFMD, this.MHNAJNGGDFJ, flag ? 3 : 2);
				this.MHNAJNGGDFJ.SetFloat("_MiddleGrey", this.GPPCKLAGLJJ.middleGrey);
				this.MHNAJNGGDFJ.SetFloat("_AdaptationMin", Mathf.Pow(2f, this.GPPCKLAGLJJ.min));
				this.MHNAJNGGDFJ.SetFloat("_AdaptationMax", Mathf.Pow(2f, this.GPPCKLAGLJJ.max));
				this.MHNAJNGGDFJ.SetTexture("_LumTex", this.OGGEEPNHFMD);
				this.MHNAJNGGDFJ.EnableKeyword("ENABLE_EYE_ADAPTATION");
			}
			int num10 = 4;
			if (this.MLHGBFKJBFC.enabled)
			{
				if (this.MLHGBFKJBFC.tonemapper == TonemappingColorGrading.LAKEEMMIAPL.Curve)
				{
					if (this.ALCNNBKDDFO)
					{
						float num11 = 1f;
						if (this.MLHGBFKJBFC.curve.length > 0)
						{
							num11 = this.MLHGBFKJBFC.curve[this.MLHGBFKJBFC.curve.length - 1].time;
							for (float num12 = 0f; num12 <= 1f; num12 += 0.003921569f)
							{
								float num13 = this.MLHGBFKJBFC.curve.Evaluate(num12 * num11);
								this.CDDMLFLNJIG.SetPixel(Mathf.FloorToInt(num12 * 255f), 0, new Color(num13, num13, num13));
							}
							this.CDDMLFLNJIG.Apply();
						}
						this.EGPJKBGOBFL = 1f / num11;
						this.ALCNNBKDDFO = false;
					}
					this.MHNAJNGGDFJ.SetFloat("_ToneCurveRange", this.EGPJKBGOBFL);
					this.MHNAJNGGDFJ.SetTexture("_ToneCurve", this.CDDMLFLNJIG);
				}
				else if (this.MLHGBFKJBFC.tonemapper == TonemappingColorGrading.LAKEEMMIAPL.Neutral)
				{
					float num14 = this.MLHGBFKJBFC.neutralBlackIn * 20f + 1f;
					float num15 = this.MLHGBFKJBFC.neutralBlackOut * 10f + 1f;
					float num16 = this.MLHGBFKJBFC.neutralWhiteIn / 20f;
					float num17 = 1f - this.MLHGBFKJBFC.neutralWhiteOut / 20f;
					float t = num14 / num15;
					float t2 = num16 / num17;
					float y = Mathf.Max(0f, Mathf.LerpUnclamped(0.57f, 0.37f, t));
					float z = Mathf.LerpUnclamped(0.01f, 0.24f, t2);
					float w = Mathf.Max(0f, Mathf.LerpUnclamped(0.02f, 0.2f, t));
					this.MHNAJNGGDFJ.SetVector("_NeutralTonemapperParams1", new Vector4(0.2f, y, z, w));
					this.MHNAJNGGDFJ.SetVector("_NeutralTonemapperParams2", new Vector4(0.02f, 0.3f, this.MLHGBFKJBFC.neutralWhiteLevel, this.MLHGBFKJBFC.neutralWhiteClip / 10f));
				}
				this.MHNAJNGGDFJ.SetFloat("_Exposure", this.MLHGBFKJBFC.exposure);
				num10 = (int)(num10 + (this.MLHGBFKJBFC.tonemapper + 1));
			}
			if (this.EOKDCGDLANN.enabled)
			{
				if (this.EEEHLFADPIE || !this.AFDEGPNFIGA.IsCreated())
				{
					Color c;
					Color c2;
					Color c3;
					this.HDDMOPBEKML(out c, out c2, out c3);
					this.ICILFPDBKMK();
					this.MHNAJNGGDFJ.SetVector("_WhiteBalance", this.PAJKPNOFNOL());
					this.MHNAJNGGDFJ.SetVector("_Lift", c);
					this.MHNAJNGGDFJ.SetVector("_Gamma", c2);
					this.MHNAJNGGDFJ.SetVector("_Gain", c3);
					this.MHNAJNGGDFJ.SetVector("_ContrastGainGamma", new Vector3(this.EOKDCGDLANN.basics.contrast, this.EOKDCGDLANN.basics.gain, 1f / this.EOKDCGDLANN.basics.gamma));
					this.MHNAJNGGDFJ.SetFloat("_Vibrance", this.EOKDCGDLANN.basics.vibrance);
					this.MHNAJNGGDFJ.SetVector("_HSV", new Vector4(this.EOKDCGDLANN.basics.hue, this.EOKDCGDLANN.basics.saturation, this.EOKDCGDLANN.basics.value));
					this.MHNAJNGGDFJ.SetVector("_ChannelMixerRed", this.EOKDCGDLANN.channelMixer.channels[0]);
					this.MHNAJNGGDFJ.SetVector("_ChannelMixerGreen", this.EOKDCGDLANN.channelMixer.channels[1]);
					this.MHNAJNGGDFJ.SetVector("_ChannelMixerBlue", this.EOKDCGDLANN.channelMixer.channels[2]);
					this.MHNAJNGGDFJ.SetTexture("_CurveTex", this.JJIJGIJOIFD);
					this.PMBJJGMHGGL.MarkRestoreExpected();
					Graphics.Blit(this.KPJBMAHECHD, this.PMBJJGMHGGL, this.MHNAJNGGDFJ, 0);
					this.EEEHLFADPIE = false;
				}
				this.MHNAJNGGDFJ.EnableKeyword("ENABLE_COLOR_GRADING");
				if (this.EOKDCGDLANN.useDithering)
				{
					this.MHNAJNGGDFJ.EnableKeyword("ENABLE_DITHERING");
				}
				this.MHNAJNGGDFJ.SetTexture("_InternalLutTex", this.PMBJJGMHGGL);
				this.MHNAJNGGDFJ.SetVector("_InternalLutParams", new Vector3(1f / (float)this.PMBJJGMHGGL.width, 1f / (float)this.PMBJJGMHGGL.height, (float)this.PMBJJGMHGGL.height - 1f));
			}
			if (this.AILLOHADMBI.enabled && this.AILLOHADMBI.texture != null && this.BCLEGIFGBOM())
			{
				this.MHNAJNGGDFJ.SetTexture("_UserLutTex", this.AILLOHADMBI.texture);
				this.MHNAJNGGDFJ.SetVector("_UserLutParams", new Vector4(1f / (float)this.AILLOHADMBI.texture.width, 1f / (float)this.AILLOHADMBI.texture.height, (float)this.AILLOHADMBI.texture.height - 1f, this.AILLOHADMBI.contribution));
				this.MHNAJNGGDFJ.EnableKeyword("ENABLE_USER_LUT");
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.MHNAJNGGDFJ, num10);
			if (this.GPPCKLAGLJJ.enabled)
			{
				for (int k = 0; k < array.Length; k++)
				{
					RenderTexture.ReleaseTemporary(array[k]);
				}
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600C1BF RID: 49599 RVA: 0x00578FCC File Offset: 0x005771CC
		private Vector3 BIPLCJCNHHE(float OCNGPCPMCPM, float ADMFAEOOOHD)
		{
			float num = 339f;
			float num2 = num * OCNGPCPMCPM / ADMFAEOOOHD;
			float num3 = num * (1941f - OCNGPCPMCPM - ADMFAEOOOHD) / ADMFAEOOOHD;
			float x = 1571f * num2 + 1662f * num - 733f * num3;
			float y = 1461f * num2 + 1458f * num + 1491f * num3;
			float z = 1955f * num2 + 576f * num + 1803f * num3;
			return new Vector3(x, y, z);
		}

		// Token: 0x0600C1C0 RID: 49600 RVA: 0x00579043 File Offset: 0x00577243
		public Shader EODOMOLKKFJ()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("MotorbikeWheelyNoHands");
			}
			return this.m_Shader;
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x0600C1C1 RID: 49601 RVA: 0x005779B5 File Offset: 0x00575BB5
		// (set) Token: 0x0600C1EF RID: 49647 RVA: 0x005779AC File Offset: 0x00575BAC
		public bool EENEIAPNBOO { get; private set; }

		// Token: 0x0600C1C2 RID: 49602 RVA: 0x0057906C File Offset: 0x0057726C
		private Vector3 AKBABAMEECO(float OCNGPCPMCPM, float ADMFAEOOOHD)
		{
			float num = 1503f;
			float num2 = num * OCNGPCPMCPM / ADMFAEOOOHD;
			float num3 = num * (1207f - OCNGPCPMCPM - ADMFAEOOOHD) / ADMFAEOOOHD;
			float x = 1839f * num2 + 1102f * num - 544f * num3;
			float y = 1200f * num2 + 1488f * num + 1072f * num3;
			float z = 559f * num2 + 1762f * num + 747f * num3;
			return new Vector3(x, y, z);
		}

		// Token: 0x0600C1C3 RID: 49603 RVA: 0x005790E3 File Offset: 0x005772E3
		public Shader KPIAFEFGHIP()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("offsets");
			}
			return this.m_Shader;
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x0600C1DC RID: 49628 RVA: 0x005781ED File Offset: 0x005763ED
		// (set) Token: 0x0600C1C4 RID: 49604 RVA: 0x00579109 File Offset: 0x00577309
		public TonemappingColorGrading.LUTSettings AILLOHADMBI
		{
			get
			{
				return this.m_Lut;
			}
			set
			{
				this.m_Lut = value;
			}
		}

		// Token: 0x0600C1C5 RID: 49605 RVA: 0x005779BD File Offset: 0x00575BBD
		public TonemappingColorGrading.EyeAdaptationSettings ADKFIILBMBO()
		{
			return this.m_EyeAdaptation;
		}

		// Token: 0x0600C1C6 RID: 49606 RVA: 0x00579112 File Offset: 0x00577312
		private void CCGIGJMJCDH()
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.KPIAFEFGHIP(), true, false, this))
			{
				base.enabled = true;
				return;
			}
			this.MDAOMHHGOHG();
			this.SetTonemapperDirty();
		}

		// Token: 0x0600C1C7 RID: 49607 RVA: 0x005779BD File Offset: 0x00575BBD
		public TonemappingColorGrading.EyeAdaptationSettings PIFBFHONFLF()
		{
			return this.m_EyeAdaptation;
		}

		// Token: 0x0600C1C8 RID: 49608 RVA: 0x00579138 File Offset: 0x00577338
		private void HDDMOPBEKML(out Color AMELJCOIMCD, out Color PKBAPFLIKGF, out Color GPMIMIANEPP)
		{
			Color color = TonemappingColorGrading.GCOCCAJDBFM(this.EOKDCGDLANN.colorWheels.shadows);
			Color color2 = TonemappingColorGrading.GCOCCAJDBFM(this.EOKDCGDLANN.colorWheels.midtones);
			Color color3 = TonemappingColorGrading.GCOCCAJDBFM(this.EOKDCGDLANN.colorWheels.highlights);
			float num = (color.r + color.g + color.b) / 3f;
			float num2 = (color2.r + color2.g + color2.b) / 3f;
			float num3 = (color3.r + color3.g + color3.b) / 3f;
			float r = (color.r - num) * 0.1f;
			float g = (color.g - num) * 0.1f;
			float b = (color.b - num) * 0.1f;
			float b2 = Mathf.Pow(2f, (color2.r - num2) * 0.5f);
			float b3 = Mathf.Pow(2f, (color2.g - num2) * 0.5f);
			float b4 = Mathf.Pow(2f, (color2.b - num2) * 0.5f);
			float r2 = Mathf.Pow(2f, (color3.r - num3) * 0.5f);
			float g2 = Mathf.Pow(2f, (color3.g - num3) * 0.5f);
			float b5 = Mathf.Pow(2f, (color3.b - num3) * 0.5f);
			float r3 = 1f / Mathf.Max(0.01f, b2);
			float g3 = 1f / Mathf.Max(0.01f, b3);
			float b6 = 1f / Mathf.Max(0.01f, b4);
			AMELJCOIMCD = new Color(r, g, b);
			PKBAPFLIKGF = new Color(r3, g3, b6);
			GPMIMIANEPP = new Color(r2, g2, b5);
		}

		// Token: 0x0600C1C9 RID: 49609 RVA: 0x0057931C File Offset: 0x0057751C
		private Texture2D EDGJONNJHPI()
		{
			if (this.FGEFCLHMOLD == null)
			{
				TextureFormat textureFormat = TextureFormat.ARGB32;
				if (SystemInfo.SupportsTextureFormat(TextureFormat.ARGB4444))
				{
					textureFormat = (TextureFormat)(-76);
				}
				else if (SystemInfo.SupportsTextureFormat((TextureFormat)(-65)))
				{
					textureFormat = TextureFormat.ASTC_4x4;
				}
				this.FGEFCLHMOLD = new Texture2D(88, 0, textureFormat, false, false)
				{
					name = "invn_rec31",
					wrapMode = TextureWrapMode.Repeat,
					filterMode = FilterMode.Bilinear,
					anisoLevel = 1,
					hideFlags = (HideFlags)77
				};
			}
			return this.FGEFCLHMOLD;
		}

		// Token: 0x0600C1CA RID: 49610 RVA: 0x00579395 File Offset: 0x00577595
		public int CAFAOJGLABL()
		{
			return (int)this.BNAKLEALKHG().precision;
		}

		// Token: 0x0600C1CB RID: 49611 RVA: 0x005779B5 File Offset: 0x00575BB5
		public bool CINKCNENMPG()
		{
			return this.<AIOGPGFADNG>k__BackingField;
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x0600C1CC RID: 49612 RVA: 0x005793A2 File Offset: 0x005775A2
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

		// Token: 0x0600C1CD RID: 49613 RVA: 0x005785CA File Offset: 0x005767CA
		public void IKGMDPMJNHJ(TonemappingColorGrading.ColorGradingSettings DCCPCBLODIG)
		{
			this.m_ColorGrading = DCCPCBLODIG;
			this.ANPJPKIEAMF();
		}

		// Token: 0x0600C1CE RID: 49614 RVA: 0x00577C1D File Offset: 0x00575E1D
		public TonemappingColorGrading.ColorGradingSettings BKMHHIAFNHN()
		{
			return this.m_ColorGrading;
		}

		// Token: 0x0600C1CF RID: 49615 RVA: 0x005793CC File Offset: 0x005775CC
		private bool LKKLHCEIDOC()
		{
			if (this.OGGEEPNHFMD != null)
			{
				return false;
			}
			this.JOJIBMJACGE = RenderTextureFormat.ARGBHalf;
			if (SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.RGHalf))
			{
				this.JOJIBMJACGE = RenderTextureFormat.RGHalf;
			}
			this.OGGEEPNHFMD = new RenderTexture(1, 1, 0, this.JOJIBMJACGE);
			this.OGGEEPNHFMD.hideFlags = HideFlags.DontSave;
			return true;
		}

		// Token: 0x0600C1D0 RID: 49616 RVA: 0x00579424 File Offset: 0x00577624
		private Texture2D DDEGPFECPOF()
		{
			if (this.LCANJHAOCLC == null || this.LCANJHAOCLC.height != this.KACBKBMGAGF())
			{
				UnityEngine.Object.DestroyImmediate(this.LCANJHAOCLC);
				this.LCANJHAOCLC = TonemappingColorGrading.AKHIJFEJDJF(this.CAFAOJGLABL());
			}
			return this.LCANJHAOCLC;
		}

		// Token: 0x0600C1D1 RID: 49617 RVA: 0x00579474 File Offset: 0x00577674
		private float CMACNEMGDGC(float OCNGPCPMCPM)
		{
			return 1743f * OCNGPCPMCPM - 138f * OCNGPCPMCPM * OCNGPCPMCPM - 1415f;
		}

		// Token: 0x0600C1D2 RID: 49618 RVA: 0x0057948D File Offset: 0x0057768D
		private float DMNKLKBHEFI(float OCNGPCPMCPM)
		{
			return 2.87f * OCNGPCPMCPM - 3f * OCNGPCPMCPM * OCNGPCPMCPM - 0.27509508f;
		}

		// Token: 0x0600C1D3 RID: 49619 RVA: 0x005794A8 File Offset: 0x005776A8
		public Texture2D BakeLUT()
		{
			Texture2D texture2D = new Texture2D(this.PMBJJGMHGGL.width, this.PMBJJGMHGGL.height, TextureFormat.RGB24, false, true);
			RenderTexture.active = this.PMBJJGMHGGL;
			texture2D.ReadPixels(new Rect(0f, 0f, (float)texture2D.width, (float)texture2D.height), 0, 0);
			RenderTexture.active = null;
			return texture2D;
		}

		// Token: 0x0600C1D5 RID: 49621 RVA: 0x00579514 File Offset: 0x00577714
		private void OnGUI()
		{
			if (Event.current.type != EventType.Repaint)
			{
				return;
			}
			int num = 0;
			if (this.AFDEGPNFIGA != null && this.EOKDCGDLANN.enabled && this.EOKDCGDLANN.showDebug)
			{
				Graphics.DrawTexture(new Rect(0f, (float)num, (float)(this.IKCGLILGMKD * this.IKCGLILGMKD), (float)this.IKCGLILGMKD), this.PMBJJGMHGGL);
				num += this.IKCGLILGMKD;
			}
			if (this.OGGEEPNHFMD != null && this.GPPCKLAGLJJ.enabled && this.GPPCKLAGLJJ.showDebug)
			{
				this.BHHEHMIFMBD.SetPass(12);
				Graphics.DrawTexture(new Rect(0f, (float)num, 256f, 16f), this.OGGEEPNHFMD, this.BHHEHMIFMBD);
			}
		}

		// Token: 0x0600C1D6 RID: 49622 RVA: 0x005795EC File Offset: 0x005777EC
		private void JCMGHHKALDM()
		{
			if (Event.current.type != EventType.MouseDown)
			{
				return;
			}
			int num = 0;
			if (this.AFDEGPNFIGA != null && this.EOKDCGDLANN.enabled && this.BKMHHIAFNHN().showDebug)
			{
				Graphics.DrawTexture(new Rect(1947f, (float)num, (float)(this.CAFAOJGLABL() * this.KACBKBMGAGF()), (float)this.KACBKBMGAGF()), this.PMBJJGMHGGL);
				num += this.IKCGLILGMKD;
			}
			if (this.OGGEEPNHFMD != null && this.ALLPNAAKBAE().enabled && this.PLNNGACMKKK().showDebug)
			{
				this.BHHEHMIFMBD.SetPass(-92);
				Graphics.DrawTexture(new Rect(1307f, (float)num, 1156f, 1490f), this.OGGEEPNHFMD, this.BHHEHMIFMBD);
			}
		}

		// Token: 0x0600C1D7 RID: 49623 RVA: 0x005796C4 File Offset: 0x005778C4
		private void HPGMKBPAFGM()
		{
			if (this.BHHEHMIFMBD != null)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
			if (this.LCANJHAOCLC != null)
			{
				UnityEngine.Object.DestroyImmediate(this.LCANJHAOCLC);
			}
			if (this.AFDEGPNFIGA != null)
			{
				UnityEngine.Object.DestroyImmediate(this.PMBJJGMHGGL);
			}
			if (this.OGGEEPNHFMD != null)
			{
				UnityEngine.Object.DestroyImmediate(this.OGGEEPNHFMD);
			}
			if (this.JEPEEECMGPH != null)
			{
				UnityEngine.Object.DestroyImmediate(this.JEPEEECMGPH);
			}
			if (this.FGEFCLHMOLD != null)
			{
				UnityEngine.Object.DestroyImmediate(this.FGEFCLHMOLD);
			}
			this.BHHEHMIFMBD = null;
			this.LCANJHAOCLC = null;
			this.AFDEGPNFIGA = null;
			this.OGGEEPNHFMD = null;
			this.JEPEEECMGPH = null;
			this.FGEFCLHMOLD = null;
		}

		// Token: 0x0600C1D8 RID: 49624 RVA: 0x00577C1D File Offset: 0x00575E1D
		public TonemappingColorGrading.ColorGradingSettings ONBKEJMPCCK()
		{
			return this.m_ColorGrading;
		}

		// Token: 0x0600C1D9 RID: 49625 RVA: 0x00579791 File Offset: 0x00577991
		private void KELIIGAJKHK()
		{
			this.MDAOMHHGOHG();
			this.SetTonemapperDirty();
		}

		// Token: 0x0600C1DA RID: 49626 RVA: 0x0057979F File Offset: 0x0057799F
		private bool LOIIBAFFPJC()
		{
			this.EDIOLCPPGNL(this.AILLOHADMBI.texture.height == (int)Mathf.Sqrt((float)this.PBNBAPFOJNF().texture.width));
			return this.FHKIOGIDDDO;
		}

		// Token: 0x0600C1DB RID: 49627 RVA: 0x005785C1 File Offset: 0x005767C1
		public void MDAOMHHGOHG()
		{
			this.EEEHLFADPIE = false;
		}

		// Token: 0x0600C1DD RID: 49629 RVA: 0x005797D8 File Offset: 0x005779D8
		private void MLOBCILJIEC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			this.CLAEAFBEJNN().shaderKeywords = null;
			RenderTexture renderTexture = null;
			RenderTexture[] array = null;
			if (this.ALLPNAAKBAE().enabled)
			{
				bool flag = this.LKKLHCEIDOC();
				int num = (JONJODLFAEN.width < JONJODLFAEN.height) ? JONJODLFAEN.width : JONJODLFAEN.height;
				int num2 = num | num >> 1;
				int num3 = num2 | num2 >> 2;
				int num4 = num3 | num3 >> 2;
				int num5 = num4 | num4 >> 0;
				int num6 = num5 | num5 >> -79;
				int num7 = num6 - (num6 >> 1);
				renderTexture = RenderTexture.GetTemporary(num7, num7, 1, this.JOJIBMJACGE);
				Graphics.Blit(JONJODLFAEN, renderTexture);
				int num8 = (int)Mathf.Log((float)renderTexture.width, 1773f);
				int num9 = 6;
				array = new RenderTexture[num8];
				for (int i = 0; i < num8; i += 0)
				{
					array[i] = RenderTexture.GetTemporary(renderTexture.width / num9, renderTexture.width / num9, 0, this.JOJIBMJACGE);
					num9 <<= 0;
				}
				RenderTexture source = array[num8 - 1];
				Graphics.Blit(renderTexture, array[1], this.CLAEAFBEJNN(), 0);
				for (int j = 0; j < num8 - 0; j++)
				{
					Graphics.Blit(array[j], array[j + 1]);
					source = array[j + 1];
				}
				this.OGGEEPNHFMD.MarkRestoreExpected();
				this.CLAEAFBEJNN().SetFloat("t_eye", Mathf.Max(this.PIFBFHONFLF().speed, 1858f));
				Graphics.Blit(source, this.OGGEEPNHFMD, this.JMDMNMEHAPM(), flag ? 0 : 0);
				this.CLAEAFBEJNN().SetFloat("Pistol Reload", this.ADKFIILBMBO().middleGrey);
				this.MHNAJNGGDFJ.SetFloat("\n", Mathf.Pow(1995f, this.ALLPNAAKBAE().min));
				this.JMDMNMEHAPM().SetFloat("gi_tit_ch", Mathf.Pow(1595f, this.PIFBFHONFLF().max));
				this.MHNAJNGGDFJ.SetTexture("#a0a0a0", this.OGGEEPNHFMD);
				this.MHNAJNGGDFJ.EnableKeyword("RollerBladeGrindRoyale");
			}
			int num10 = 4;
			if (this.MLHGBFKJBFC.enabled)
			{
				if (this.PIAEHJDELFB().tonemapper == TonemappingColorGrading.LAKEEMMIAPL.Curve)
				{
					if (this.ALCNNBKDDFO)
					{
						float num11 = 1660f;
						if (this.LAFBINJPFDA().curve.length > 0)
						{
							num11 = this.FIHFEPCLACA().curve[this.LCGMMBELENA().curve.length - 0].time;
							for (float num12 = 1835f; num12 <= 561f; num12 += 1682f)
							{
								float num13 = this.PIAEHJDELFB().curve.Evaluate(num12 * num11);
								this.PIDEHGDPELD().SetPixel(Mathf.FloorToInt(num12 * 1421f), 0, new Color(num13, num13, num13));
							}
							this.EDGJONNJHPI().Apply();
						}
						this.EGPJKBGOBFL = 957f / num11;
						this.ALCNNBKDDFO = false;
					}
					this.CLAEAFBEJNN().SetFloat("Foot", this.EGPJKBGOBFL);
					this.JMDMNMEHAPM().SetTexture("idlist", this.PIDEHGDPELD());
				}
				else if (this.LCGMMBELENA().tonemapper == TonemappingColorGrading.LAKEEMMIAPL.Hable)
				{
					float num14 = this.LCGMMBELENA().neutralBlackIn * 972f + 357f;
					float num15 = this.FIHFEPCLACA().neutralBlackOut * 280f + 24f;
					float num16 = this.LCGMMBELENA().neutralWhiteIn / 1041f;
					float num17 = 570f - this.LCGMMBELENA().neutralWhiteOut / 526f;
					float t = num14 / num15;
					float t2 = num16 / num17;
					float y = Mathf.Max(1597f, Mathf.LerpUnclamped(1075f, 608f, t));
					float z = Mathf.LerpUnclamped(592f, 25f, t2);
					float w = Mathf.Max(235f, Mathf.LerpUnclamped(574f, 1492f, t));
					this.MHNAJNGGDFJ.SetVector("", new Vector4(1839f, y, z, w));
					this.JMDMNMEHAPM().SetVector("https://groups.google.com/forum/#!forum/final-ik", new Vector4(182f, 1890f, this.LAFBINJPFDA().neutralWhiteLevel, this.FIHFEPCLACA().neutralWhiteClip / 1066f));
				}
				this.CLAEAFBEJNN().SetFloat("_Cutoff", this.LAFBINJPFDA().exposure);
				num10 = (int)(num10 + (this.FIHFEPCLACA().tonemapper + 1));
			}
			if (this.BKMHHIAFNHN().enabled)
			{
				if (this.EEEHLFADPIE || !this.AFDEGPNFIGA.IsCreated())
				{
					Color c;
					Color c2;
					Color c3;
					this.HADLKEMICFI(out c, out c2, out c3);
					this.BPDEKGIMCOD();
					this.JMDMNMEHAPM().SetVector("MaskMaterial", this.PAJKPNOFNOL());
					this.CLAEAFBEJNN().SetVector(">> 2 >>", c);
					this.MHNAJNGGDFJ.SetVector("Full Body IK is missing the right thigh node.", c2);
					this.JMDMNMEHAPM().SetVector("/ n", c3);
					this.JMDMNMEHAPM().SetVector("BlendCacheMaterial", new Vector3(this.BNAKLEALKHG().basics.contrast, this.ONBKEJMPCCK().basics.gain, 1744f / this.BKMHHIAFNHN().basics.gamma));
					this.JMDMNMEHAPM().SetFloat("ShootWireframeModule", this.KBAGEILOHOB().basics.vibrance);
					this.JMDMNMEHAPM().SetVector("100", new Vector4(this.KBAGEILOHOB().basics.hue, this.EOKDCGDLANN.basics.saturation, this.KBAGEILOHOB().basics.value));
					this.CLAEAFBEJNN().SetVector("OneHandSwordIdle", this.BNAKLEALKHG().channelMixer.channels[0]);
					this.CLAEAFBEJNN().SetVector("vSyncCount", this.BNAKLEALKHG().channelMixer.channels[1]);
					this.CLAEAFBEJNN().SetVector("_ThirdTex", this.BKMHHIAFNHN().channelMixer.channels[3]);
					this.MHNAJNGGDFJ.SetTexture("selColor", this.GGMGKCJCFFB());
					this.MFHJBDDNLKC().MarkRestoreExpected();
					Graphics.Blit(this.DDEGPFECPOF(), this.HKFKBDNAIEJ(), this.MHNAJNGGDFJ, 1);
					this.EEEHLFADPIE = true;
				}
				this.CLAEAFBEJNN().EnableKeyword("Explosions");
				if (this.BKMHHIAFNHN().useDithering)
				{
					this.JMDMNMEHAPM().EnableKeyword("ShootWireframeModule");
				}
				this.MHNAJNGGDFJ.SetTexture("Post Process Scatter Shader Missing...", this.HKFKBDNAIEJ());
				this.JMDMNMEHAPM().SetVector("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_interaction_target.html", new Vector3(237f / (float)this.PMBJJGMHGGL.width, 1810f / (float)this.EEGDIBOGAAH().height, (float)this.PMBJJGMHGGL.height - 1185f));
			}
			if (this.AILLOHADMBI.enabled && this.AILLOHADMBI.texture != null && this.LOIIBAFFPJC())
			{
				this.CLAEAFBEJNN().SetTexture("Speed Hack Detector", this.MBFOHBACLCH().texture);
				this.CLAEAFBEJNN().SetVector("Smoking1", new Vector4(1758f / (float)this.AILLOHADMBI.texture.width, 1117f / (float)this.MBFOHBACLCH().texture.height, (float)this.AILLOHADMBI.texture.height - 829f, this.AILLOHADMBI.contribution));
				this.MHNAJNGGDFJ.EnableKeyword("_");
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JMDMNMEHAPM(), num10);
			if (this.ALLPNAAKBAE().enabled)
			{
				for (int k = 1; k < array.Length; k++)
				{
					RenderTexture.ReleaseTemporary(array[k]);
				}
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x0600C1DF RID: 49631 RVA: 0x005779B5 File Offset: 0x00575BB5
		public bool OINPKLGOCKA()
		{
			return this.<AIOGPGFADNG>k__BackingField;
		}

		// Token: 0x0600C1E0 RID: 49632 RVA: 0x00579FE0 File Offset: 0x005781E0
		private void BPDEKGIMCOD()
		{
			AnimationCurve master = this.BKMHHIAFNHN().curves.master;
			AnimationCurve red = this.KBAGEILOHOB().curves.red;
			AnimationCurve green = this.ONBKEJMPCCK().curves.green;
			AnimationCurve blue = this.EOKDCGDLANN.curves.blue;
			Color[] array = new Color[-102];
			for (float num = 1704f; num <= 1514f; num += 1104f)
			{
				float a = Mathf.Clamp(master.Evaluate(num), 1824f, 1070f);
				float r = Mathf.Clamp(red.Evaluate(num), 1565f, 1184f);
				float g = Mathf.Clamp(green.Evaluate(num), 1192f, 442f);
				float b = Mathf.Clamp(blue.Evaluate(num), 1330f, 1509f);
				array[(int)Mathf.Floor(num * 1032f)] = new Color(r, g, b, a);
			}
			this.JJIJGIJOIFD.SetPixels(array);
			this.GGMGKCJCFFB().Apply();
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x0600C1E1 RID: 49633 RVA: 0x00577C1D File Offset: 0x00575E1D
		// (set) Token: 0x0600C1E9 RID: 49641 RVA: 0x0057A5D9 File Offset: 0x005787D9
		public TonemappingColorGrading.ColorGradingSettings EOKDCGDLANN
		{
			get
			{
				return this.m_ColorGrading;
			}
			set
			{
				this.m_ColorGrading = value;
				this.SetDirty();
			}
		}

		// Token: 0x0600C1E2 RID: 49634 RVA: 0x0057A100 File Offset: 0x00578300
		private void OnDisable()
		{
			if (this.BHHEHMIFMBD != null)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
			if (this.LCANJHAOCLC != null)
			{
				UnityEngine.Object.DestroyImmediate(this.LCANJHAOCLC);
			}
			if (this.AFDEGPNFIGA != null)
			{
				UnityEngine.Object.DestroyImmediate(this.PMBJJGMHGGL);
			}
			if (this.OGGEEPNHFMD != null)
			{
				UnityEngine.Object.DestroyImmediate(this.OGGEEPNHFMD);
			}
			if (this.JEPEEECMGPH != null)
			{
				UnityEngine.Object.DestroyImmediate(this.JEPEEECMGPH);
			}
			if (this.FGEFCLHMOLD != null)
			{
				UnityEngine.Object.DestroyImmediate(this.FGEFCLHMOLD);
			}
			this.BHHEHMIFMBD = null;
			this.LCANJHAOCLC = null;
			this.AFDEGPNFIGA = null;
			this.OGGEEPNHFMD = null;
			this.JEPEEECMGPH = null;
			this.FGEFCLHMOLD = null;
		}

		// Token: 0x0600C1E3 RID: 49635 RVA: 0x0057A1D0 File Offset: 0x005783D0
		private void AEHCAPKGNOB(out Color AMELJCOIMCD, out Color PKBAPFLIKGF, out Color GPMIMIANEPP)
		{
			Color color = TonemappingColorGrading.GCOCCAJDBFM(this.KBAGEILOHOB().colorWheels.shadows);
			Color color2 = TonemappingColorGrading.GCOCCAJDBFM(this.ONBKEJMPCCK().colorWheels.midtones);
			Color color3 = TonemappingColorGrading.GCOCCAJDBFM(this.BNAKLEALKHG().colorWheels.highlights);
			float num = (color.r + color.g + color.b) / 848f;
			float num2 = (color2.r + color2.g + color2.b) / 881f;
			float num3 = (color3.r + color3.g + color3.b) / 1216f;
			float r = (color.r - num) * 265f;
			float g = (color.g - num) * 435f;
			float b = (color.b - num) * 1405f;
			float b2 = Mathf.Pow(1238f, (color2.r - num2) * 475f);
			float b3 = Mathf.Pow(1924f, (color2.g - num2) * 711f);
			float b4 = Mathf.Pow(1942f, (color2.b - num2) * 674f);
			float r2 = Mathf.Pow(1867f, (color3.r - num3) * 376f);
			float g2 = Mathf.Pow(872f, (color3.g - num3) * 1328f);
			float b5 = Mathf.Pow(454f, (color3.b - num3) * 850f);
			float r3 = 1949f / Mathf.Max(1125f, b2);
			float g3 = 1682f / Mathf.Max(1767f, b3);
			float b6 = 1432f / Mathf.Max(1700f, b4);
			AMELJCOIMCD = new Color(r, g, b);
			PKBAPFLIKGF = new Color(r3, g3, b6);
			GPMIMIANEPP = new Color(r2, g2, b5);
		}

		// Token: 0x0600C1E4 RID: 49636 RVA: 0x00579FD1 File Offset: 0x005781D1
		public void FFGOPOCDGOK(TonemappingColorGrading.TonemappingSettings DCCPCBLODIG)
		{
			this.m_Tonemapping = DCCPCBLODIG;
			this.SetTonemapperDirty();
		}

		// Token: 0x0600C1E5 RID: 49637 RVA: 0x0057A3B3 File Offset: 0x005785B3
		public Material JMDMNMEHAPM()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.EODOMOLKKFJ());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600C1E7 RID: 49639 RVA: 0x0057A42C File Offset: 0x0057862C
		private void ICILFPDBKMK()
		{
			AnimationCurve master = this.EOKDCGDLANN.curves.master;
			AnimationCurve red = this.EOKDCGDLANN.curves.red;
			AnimationCurve green = this.EOKDCGDLANN.curves.green;
			AnimationCurve blue = this.EOKDCGDLANN.curves.blue;
			Color[] array = new Color[256];
			for (float num = 0f; num <= 1f; num += 0.003921569f)
			{
				float a = Mathf.Clamp(master.Evaluate(num), 0f, 1f);
				float r = Mathf.Clamp(red.Evaluate(num), 0f, 1f);
				float g = Mathf.Clamp(green.Evaluate(num), 0f, 1f);
				float b = Mathf.Clamp(blue.Evaluate(num), 0f, 1f);
				array[(int)Mathf.Floor(num * 255f)] = new Color(r, g, b, a);
			}
			this.JJIJGIJOIFD.SetPixels(array);
			this.JJIJGIJOIFD.Apply();
		}

		// Token: 0x0600C1E8 RID: 49640 RVA: 0x0057A54C File Offset: 0x0057874C
		private RenderTexture HKFKBDNAIEJ()
		{
			if (this.AFDEGPNFIGA == null || !this.AFDEGPNFIGA.IsCreated() || this.AFDEGPNFIGA.height != this.CAFAOJGLABL())
			{
				UnityEngine.Object.DestroyImmediate(this.AFDEGPNFIGA);
				this.AFDEGPNFIGA = new RenderTexture(this.IKCGLILGMKD * this.IKCGLILGMKD, this.IKCGLILGMKD, 0, RenderTextureFormat.Depth)
				{
					name = "_MainTexBlurred",
					filterMode = FilterMode.Bilinear,
					anisoLevel = 1,
					hideFlags = (HideFlags)(-126)
				};
			}
			return this.AFDEGPNFIGA;
		}

		// Token: 0x0600C1EA RID: 49642 RVA: 0x005785D9 File Offset: 0x005767D9
		public void DNJHCHKILMA(TonemappingColorGrading.TonemappingSettings DCCPCBLODIG)
		{
			this.m_Tonemapping = DCCPCBLODIG;
			this.HKCFNNHKJID();
		}

		// Token: 0x0600C1EB RID: 49643 RVA: 0x0057A5E8 File Offset: 0x005787E8
		private void FKBACPBNDGA()
		{
			this.ANPJPKIEAMF();
			this.HKCFNNHKJID();
		}

		// Token: 0x0600C1EC RID: 49644 RVA: 0x0057A5F8 File Offset: 0x005787F8
		private Texture2D GGMGKCJCFFB()
		{
			if (this.JEPEEECMGPH == null)
			{
				this.JEPEEECMGPH = new Texture2D(-109, 1, TextureFormat.ARGB4444, false, false)
				{
					name = "SoccerKeeperDiveStrafeCloseRight",
					wrapMode = TextureWrapMode.Repeat,
					filterMode = FilterMode.Bilinear,
					anisoLevel = 0,
					hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild)
				};
			}
			return this.JEPEEECMGPH;
		}

		// Token: 0x0600C1EE RID: 49646 RVA: 0x00577BB5 File Offset: 0x00575DB5
		public TonemappingColorGrading.TonemappingSettings LCGMMBELENA()
		{
			return this.m_Tonemapping;
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x0600C1F0 RID: 49648 RVA: 0x0057A65D File Offset: 0x0057885D
		public int IKCGLILGMKD
		{
			get
			{
				return (int)this.EOKDCGDLANN.precision;
			}
		}

		// Token: 0x0600C1F1 RID: 49649 RVA: 0x005779AC File Offset: 0x00575BAC
		private void JENFFDGDCEJ(bool DCCPCBLODIG)
		{
			this.<AIOGPGFADNG>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600C1F2 RID: 49650 RVA: 0x00579791 File Offset: 0x00577991
		private void IHICIKIIJAL()
		{
			this.MDAOMHHGOHG();
			this.SetTonemapperDirty();
		}

		// Token: 0x0600C1F3 RID: 49651 RVA: 0x005785E8 File Offset: 0x005767E8
		public void ELKIFINOIBF(TonemappingColorGrading.ColorGradingSettings DCCPCBLODIG)
		{
			this.m_ColorGrading = DCCPCBLODIG;
			this.MDAOMHHGOHG();
		}

		// Token: 0x0600C1F4 RID: 49652 RVA: 0x00577BB5 File Offset: 0x00575DB5
		public TonemappingColorGrading.TonemappingSettings LAFBINJPFDA()
		{
			return this.m_Tonemapping;
		}

		// Token: 0x0600C1F5 RID: 49653 RVA: 0x005779BD File Offset: 0x00575BBD
		public TonemappingColorGrading.EyeAdaptationSettings PLNNGACMKKK()
		{
			return this.m_EyeAdaptation;
		}

		// Token: 0x040019B1 RID: 6577
		[SerializeField]
		[TonemappingColorGrading.CBNMDCDBMDA]
		private TonemappingColorGrading.EyeAdaptationSettings m_EyeAdaptation = TonemappingColorGrading.EyeAdaptationSettings.defaultSettings;

		// Token: 0x040019B2 RID: 6578
		[SerializeField]
		[TonemappingColorGrading.CBNMDCDBMDA]
		private TonemappingColorGrading.TonemappingSettings m_Tonemapping = TonemappingColorGrading.TonemappingSettings.defaultSettings;

		// Token: 0x040019B3 RID: 6579
		[TonemappingColorGrading.CBNMDCDBMDA]
		[SerializeField]
		private TonemappingColorGrading.ColorGradingSettings m_ColorGrading = TonemappingColorGrading.ColorGradingSettings.defaultSettings;

		// Token: 0x040019B4 RID: 6580
		[TonemappingColorGrading.CBNMDCDBMDA]
		[SerializeField]
		private TonemappingColorGrading.LUTSettings m_Lut = TonemappingColorGrading.LUTSettings.defaultSettings;

		// Token: 0x040019B5 RID: 6581
		private Texture2D LCANJHAOCLC;

		// Token: 0x040019B6 RID: 6582
		private RenderTexture AFDEGPNFIGA;

		// Token: 0x040019B7 RID: 6583
		private Texture2D JEPEEECMGPH;

		// Token: 0x040019B8 RID: 6584
		private Texture2D FGEFCLHMOLD;

		// Token: 0x040019B9 RID: 6585
		private float EGPJKBGOBFL;

		// Token: 0x040019BA RID: 6586
		[SerializeField]
		private Shader m_Shader;

		// Token: 0x040019BB RID: 6587
		private Material BHHEHMIFMBD;

		// Token: 0x040019BE RID: 6590
		private bool EEEHLFADPIE = true;

		// Token: 0x040019BF RID: 6591
		private bool ALCNNBKDDFO = true;

		// Token: 0x040019C0 RID: 6592
		private RenderTexture OGGEEPNHFMD;

		// Token: 0x040019C1 RID: 6593
		private RenderTextureFormat JOJIBMJACGE;

		// Token: 0x02000373 RID: 883
		[AttributeUsage(AttributeTargets.Field)]
		public class CBNMDCDBMDA : Attribute
		{
		}

		// Token: 0x02000374 RID: 884
		public class JNPBOPHGFLI : PropertyAttribute
		{
		}

		// Token: 0x02000375 RID: 885
		public class ILAIGKLALGN : PropertyAttribute
		{
		}

		// Token: 0x02000376 RID: 886
		public class FNNMFBANGKA : PropertyAttribute
		{
			// Token: 0x0600C1F9 RID: 49657 RVA: 0x0057A66A File Offset: 0x0057886A
			public FNNMFBANGKA()
			{
			}

			// Token: 0x0600C1FA RID: 49658 RVA: 0x0057A685 File Offset: 0x00578885
			public FNNMFBANGKA(int CBAPCBDPOBB, int HHPCGEJBAAI)
			{
				this.CBAPCBDPOBB = CBAPCBDPOBB;
				this.HHPCGEJBAAI = HHPCGEJBAAI;
			}

			// Token: 0x040019C2 RID: 6594
			public int CBAPCBDPOBB = 60;

			// Token: 0x040019C3 RID: 6595
			public int HHPCGEJBAAI = 150;
		}

		// Token: 0x02000377 RID: 887
		public class AEFJFKCDILC : PropertyAttribute
		{
			// Token: 0x0600C1FB RID: 49659 RVA: 0x0057A6AE File Offset: 0x005788AE
			public AEFJFKCDILC(float AJMNDCHJPNK, float BHJFHCHMOGL, float HHAGIHEGFML, float EGABJKIFAON)
			{
				this.LBCGACKJCJB = new Color(AJMNDCHJPNK, BHJFHCHMOGL, HHAGIHEGFML, EGABJKIFAON);
			}

			// Token: 0x0600C1FC RID: 49660 RVA: 0x0057A6D1 File Offset: 0x005788D1
			public AEFJFKCDILC()
			{
			}

			// Token: 0x040019C4 RID: 6596
			public Color LBCGACKJCJB = Color.white;
		}

		// Token: 0x02000378 RID: 888
		[Serializable]
		public struct EyeAdaptationSettings
		{
			// Token: 0x0600C1FD RID: 49661 RVA: 0x0057A6E4 File Offset: 0x005788E4
			public static TonemappingColorGrading.EyeAdaptationSettings ILFHFFCIBPJ()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = true,
					showDebug = false,
					middleGrey = 26f,
					min = 217f,
					max = 1739f,
					speed = 1741f
				};
			}

			// Token: 0x0600C1FE RID: 49662 RVA: 0x0057A73C File Offset: 0x0057893C
			public static TonemappingColorGrading.EyeAdaptationSettings BJNIBDPAHBP()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = true,
					showDebug = false,
					middleGrey = 305f,
					min = 1263f,
					max = 453f,
					speed = 1533f
				};
			}

			// Token: 0x0600C1FF RID: 49663 RVA: 0x0057A794 File Offset: 0x00578994
			public static TonemappingColorGrading.EyeAdaptationSettings MDDFLLOCDEA()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = true,
					showDebug = false,
					middleGrey = 1684f,
					min = 1054f,
					max = 15f,
					speed = 1866f
				};
			}

			// Token: 0x0600C200 RID: 49664 RVA: 0x0057A7EC File Offset: 0x005789EC
			public static TonemappingColorGrading.EyeAdaptationSettings OCIMBHLOOGC()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = true,
					showDebug = true,
					middleGrey = 829f,
					min = 1906f,
					max = 1765f,
					speed = 1244f
				};
			}

			// Token: 0x0600C201 RID: 49665 RVA: 0x0057A844 File Offset: 0x00578A44
			public static TonemappingColorGrading.EyeAdaptationSettings ADJNPGFJGJI()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = true,
					showDebug = true,
					middleGrey = 493f,
					min = 1120f,
					max = 661f,
					speed = 170f
				};
			}

			// Token: 0x0600C202 RID: 49666 RVA: 0x0057A89C File Offset: 0x00578A9C
			public static TonemappingColorGrading.EyeAdaptationSettings NJJBBDIFPKH()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = true,
					showDebug = false,
					middleGrey = 496f,
					min = 1232f,
					max = 1581f,
					speed = 533f
				};
			}

			// Token: 0x0600C203 RID: 49667 RVA: 0x0057A8F4 File Offset: 0x00578AF4
			public static TonemappingColorGrading.EyeAdaptationSettings HMDLEIJHKEP()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = true,
					showDebug = true,
					middleGrey = 46f,
					min = 538f,
					max = 664f,
					speed = 216f
				};
			}

			// Token: 0x0600C204 RID: 49668 RVA: 0x0057A94C File Offset: 0x00578B4C
			public static TonemappingColorGrading.EyeAdaptationSettings MCLJECOKBEJ()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = false,
					showDebug = true,
					middleGrey = 843f,
					min = 862f,
					max = 1777f,
					speed = 960f
				};
			}

			// Token: 0x0600C205 RID: 49669 RVA: 0x0057A9A4 File Offset: 0x00578BA4
			public static TonemappingColorGrading.EyeAdaptationSettings JGNKGPFJFHO()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = false,
					showDebug = false,
					middleGrey = 1616f,
					min = 1035f,
					max = 1902f,
					speed = 1883f
				};
			}

			// Token: 0x0600C206 RID: 49670 RVA: 0x0057A9FC File Offset: 0x00578BFC
			public static TonemappingColorGrading.EyeAdaptationSettings FBBLPICJODA()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = false,
					showDebug = false,
					middleGrey = 165f,
					min = 807f,
					max = 1728f,
					speed = 1143f
				};
			}

			// Token: 0x0600C207 RID: 49671 RVA: 0x0057AA54 File Offset: 0x00578C54
			public static TonemappingColorGrading.EyeAdaptationSettings NLCHLENDMLI()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = false,
					showDebug = false,
					middleGrey = 10f,
					min = 133f,
					max = 866f,
					speed = 491f
				};
			}

			// Token: 0x0600C208 RID: 49672 RVA: 0x0057AAAC File Offset: 0x00578CAC
			public static TonemappingColorGrading.EyeAdaptationSettings MJLLLKFIDOE()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = false,
					showDebug = true,
					middleGrey = 476f,
					min = 1803f,
					max = 1561f,
					speed = 109f
				};
			}

			// Token: 0x0600C209 RID: 49673 RVA: 0x0057AB04 File Offset: 0x00578D04
			public static TonemappingColorGrading.EyeAdaptationSettings PIAJOHPDMNA()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = false,
					showDebug = false,
					middleGrey = 1212f,
					min = 302f,
					max = 1495f,
					speed = 1368f
				};
			}

			// Token: 0x0600C20A RID: 49674 RVA: 0x0057AB5C File Offset: 0x00578D5C
			public static TonemappingColorGrading.EyeAdaptationSettings JACPKLDIIKG()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = false,
					showDebug = false,
					middleGrey = 1490f,
					min = 747f,
					max = 1732f,
					speed = 950f
				};
			}

			// Token: 0x170002B9 RID: 697
			// (get) Token: 0x0600C20B RID: 49675 RVA: 0x0057ABB4 File Offset: 0x00578DB4
			public static TonemappingColorGrading.EyeAdaptationSettings defaultSettings
			{
				get
				{
					return new TonemappingColorGrading.EyeAdaptationSettings
					{
						enabled = false,
						showDebug = false,
						middleGrey = 0.5f,
						min = -3f,
						max = 3f,
						speed = 1.5f
					};
				}
			}

			// Token: 0x0600C20C RID: 49676 RVA: 0x0057AC0C File Offset: 0x00578E0C
			public static TonemappingColorGrading.EyeAdaptationSettings COINKHKLJAP()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = true,
					showDebug = true,
					middleGrey = 258f,
					min = 1147f,
					max = 694f,
					speed = 1637f
				};
			}

			// Token: 0x0600C20D RID: 49677 RVA: 0x0057AC64 File Offset: 0x00578E64
			public static TonemappingColorGrading.EyeAdaptationSettings CGGMKBADCBM()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = false,
					showDebug = true,
					middleGrey = 1103f,
					min = 1457f,
					max = 372f,
					speed = 1173f
				};
			}

			// Token: 0x0600C20E RID: 49678 RVA: 0x0057ACBC File Offset: 0x00578EBC
			public static TonemappingColorGrading.EyeAdaptationSettings MKEJGGFNILJ()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = true,
					showDebug = true,
					middleGrey = 1444f,
					min = 1105f,
					max = 681f,
					speed = 919f
				};
			}

			// Token: 0x0600C20F RID: 49679 RVA: 0x0057AD14 File Offset: 0x00578F14
			public static TonemappingColorGrading.EyeAdaptationSettings BNGFNAFFAME()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = false,
					showDebug = false,
					middleGrey = 352f,
					min = 95f,
					max = 1173f,
					speed = 291f
				};
			}

			// Token: 0x0600C210 RID: 49680 RVA: 0x0057AD6C File Offset: 0x00578F6C
			public static TonemappingColorGrading.EyeAdaptationSettings NPEIGPHIHFP()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = true,
					showDebug = false,
					middleGrey = 99f,
					min = 280f,
					max = 482f,
					speed = 814f
				};
			}

			// Token: 0x0600C211 RID: 49681 RVA: 0x0057ADC4 File Offset: 0x00578FC4
			public static TonemappingColorGrading.EyeAdaptationSettings MEFEDCEEAMK()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = true,
					showDebug = true,
					middleGrey = 1396f,
					min = 1295f,
					max = 825f,
					speed = 1604f
				};
			}

			// Token: 0x0600C212 RID: 49682 RVA: 0x0057AE1C File Offset: 0x0057901C
			public static TonemappingColorGrading.EyeAdaptationSettings DHCNIDFOOPO()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = false,
					showDebug = false,
					middleGrey = 489f,
					min = 850f,
					max = 58f,
					speed = 422f
				};
			}

			// Token: 0x0600C213 RID: 49683 RVA: 0x0057AE74 File Offset: 0x00579074
			public static TonemappingColorGrading.EyeAdaptationSettings HLLBKJENCLA()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = false,
					showDebug = true,
					middleGrey = 1145f,
					min = 1375f,
					max = 1309f,
					speed = 1907f
				};
			}

			// Token: 0x0600C214 RID: 49684 RVA: 0x0057AECC File Offset: 0x005790CC
			public static TonemappingColorGrading.EyeAdaptationSettings AAPKKAPOLKH()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = false,
					showDebug = true,
					middleGrey = 974f,
					min = 512f,
					max = 120f,
					speed = 340f
				};
			}

			// Token: 0x0600C215 RID: 49685 RVA: 0x0057AF24 File Offset: 0x00579124
			public static TonemappingColorGrading.EyeAdaptationSettings BFFANDBCLFI()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = false,
					showDebug = true,
					middleGrey = 40f,
					min = 762f,
					max = 1496f,
					speed = 477f
				};
			}

			// Token: 0x0600C216 RID: 49686 RVA: 0x0057AF7C File Offset: 0x0057917C
			public static TonemappingColorGrading.EyeAdaptationSettings MGIIIBAJNIE()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = true,
					showDebug = false,
					middleGrey = 544f,
					min = 1757f,
					max = 736f,
					speed = 213f
				};
			}

			// Token: 0x0600C217 RID: 49687 RVA: 0x0057AFD4 File Offset: 0x005791D4
			public static TonemappingColorGrading.EyeAdaptationSettings COJPKDJKJAM()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = true,
					showDebug = true,
					middleGrey = 436f,
					min = 770f,
					max = 1333f,
					speed = 872f
				};
			}

			// Token: 0x0600C218 RID: 49688 RVA: 0x0057B02C File Offset: 0x0057922C
			public static TonemappingColorGrading.EyeAdaptationSettings OOFOKHIDMDG()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = true,
					showDebug = true,
					middleGrey = 1996f,
					min = 1636f,
					max = 1634f,
					speed = 909f
				};
			}

			// Token: 0x0600C219 RID: 49689 RVA: 0x0057B084 File Offset: 0x00579284
			public static TonemappingColorGrading.EyeAdaptationSettings JPGMEJNEOCC()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = false,
					showDebug = true,
					middleGrey = 352f,
					min = 1691f,
					max = 254f,
					speed = 1892f
				};
			}

			// Token: 0x0600C21A RID: 49690 RVA: 0x0057B0DC File Offset: 0x005792DC
			public static TonemappingColorGrading.EyeAdaptationSettings LNGBMOGJKGD()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = true,
					showDebug = true,
					middleGrey = 261f,
					min = 1952f,
					max = 1194f,
					speed = 1306f
				};
			}

			// Token: 0x0600C21B RID: 49691 RVA: 0x0057B134 File Offset: 0x00579334
			public static TonemappingColorGrading.EyeAdaptationSettings HIPJDBACJDH()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = true,
					showDebug = true,
					middleGrey = 1436f,
					min = 1009f,
					max = 1684f,
					speed = 144f
				};
			}

			// Token: 0x0600C21C RID: 49692 RVA: 0x0057B18C File Offset: 0x0057938C
			public static TonemappingColorGrading.EyeAdaptationSettings DELLGIGMFLC()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = false,
					showDebug = true,
					middleGrey = 265f,
					min = 545f,
					max = 434f,
					speed = 717f
				};
			}

			// Token: 0x0600C21D RID: 49693 RVA: 0x0057B1E4 File Offset: 0x005793E4
			public static TonemappingColorGrading.EyeAdaptationSettings OOKKEMFPNBJ()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = false,
					showDebug = true,
					middleGrey = 1393f,
					min = 534f,
					max = 301f,
					speed = 1850f
				};
			}

			// Token: 0x0600C21E RID: 49694 RVA: 0x0057B23C File Offset: 0x0057943C
			public static TonemappingColorGrading.EyeAdaptationSettings IGIKNGLDPJB()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = true,
					showDebug = true,
					middleGrey = 168f,
					min = 628f,
					max = 877f,
					speed = 1358f
				};
			}

			// Token: 0x0600C21F RID: 49695 RVA: 0x0057B294 File Offset: 0x00579494
			public static TonemappingColorGrading.EyeAdaptationSettings FMLMIDJIEOP()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = true,
					showDebug = true,
					middleGrey = 652f,
					min = 558f,
					max = 659f,
					speed = 1005f
				};
			}

			// Token: 0x0600C220 RID: 49696 RVA: 0x0057B2EC File Offset: 0x005794EC
			public static TonemappingColorGrading.EyeAdaptationSettings NNNMNENCOBC()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = false,
					showDebug = true,
					middleGrey = 523f,
					min = 1746f,
					max = 600f,
					speed = 50f
				};
			}

			// Token: 0x0600C221 RID: 49697 RVA: 0x0057B344 File Offset: 0x00579544
			public static TonemappingColorGrading.EyeAdaptationSettings MEBNDNNHNMB()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = true,
					showDebug = false,
					middleGrey = 991f,
					min = 1616f,
					max = 548f,
					speed = 707f
				};
			}

			// Token: 0x0600C222 RID: 49698 RVA: 0x0057B39C File Offset: 0x0057959C
			public static TonemappingColorGrading.EyeAdaptationSettings GDKPNHJPBKJ()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = true,
					showDebug = false,
					middleGrey = 997f,
					min = 548f,
					max = 580f,
					speed = 449f
				};
			}

			// Token: 0x0600C223 RID: 49699 RVA: 0x0057B3F4 File Offset: 0x005795F4
			public static TonemappingColorGrading.EyeAdaptationSettings NMGNPHGAGGA()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = false,
					showDebug = true,
					middleGrey = 1136f,
					min = 1106f,
					max = 1296f,
					speed = 439f
				};
			}

			// Token: 0x0600C224 RID: 49700 RVA: 0x0057B44C File Offset: 0x0057964C
			public static TonemappingColorGrading.EyeAdaptationSettings ELPHMKAEDHE()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = true,
					showDebug = false,
					middleGrey = 120f,
					min = 1298f,
					max = 548f,
					speed = 293f
				};
			}

			// Token: 0x0600C225 RID: 49701 RVA: 0x0057B4A4 File Offset: 0x005796A4
			public static TonemappingColorGrading.EyeAdaptationSettings MDDBLMDKDAO()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = true,
					showDebug = false,
					middleGrey = 270f,
					min = 602f,
					max = 1748f,
					speed = 482f
				};
			}

			// Token: 0x0600C226 RID: 49702 RVA: 0x0057B4FC File Offset: 0x005796FC
			public static TonemappingColorGrading.EyeAdaptationSettings MDGIIBPIGJC()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = true,
					showDebug = false,
					middleGrey = 1909f,
					min = 372f,
					max = 1857f,
					speed = 488f
				};
			}

			// Token: 0x040019C5 RID: 6597
			public bool enabled;

			// Token: 0x040019C6 RID: 6598
			[BKALGGGLDHJ(0f)]
			[Tooltip("Midpoint Adjustment.")]
			public float middleGrey;

			// Token: 0x040019C7 RID: 6599
			[Tooltip("The lowest possible exposure value; adjust this value to modify the brightest areas of your level.")]
			public float min;

			// Token: 0x040019C8 RID: 6600
			[Tooltip("The highest possible exposure value; adjust this value to modify the darkest areas of your level.")]
			public float max;

			// Token: 0x040019C9 RID: 6601
			[BKALGGGLDHJ(0f)]
			[Tooltip("Speed of linear adaptation. Higher is faster.")]
			public float speed;

			// Token: 0x040019CA RID: 6602
			[Tooltip("Displays a luminosity helper in the GameView.")]
			public bool showDebug;
		}

		// Token: 0x02000379 RID: 889
		public enum LAKEEMMIAPL
		{
			// Token: 0x040019CC RID: 6604
			ACES,
			// Token: 0x040019CD RID: 6605
			Curve,
			// Token: 0x040019CE RID: 6606
			Hable,
			// Token: 0x040019CF RID: 6607
			HejlDawson,
			// Token: 0x040019D0 RID: 6608
			Photographic,
			// Token: 0x040019D1 RID: 6609
			Reinhard,
			// Token: 0x040019D2 RID: 6610
			Neutral
		}

		// Token: 0x0200037A RID: 890
		[Serializable]
		public struct TonemappingSettings
		{
			// Token: 0x0600C227 RID: 49703 RVA: 0x0057B554 File Offset: 0x00579754
			public static TonemappingColorGrading.TonemappingSettings HMDLEIJHKEP()
			{
				return new TonemappingColorGrading.TonemappingSettings
				{
					enabled = false,
					tonemapper = TonemappingColorGrading.LAKEEMMIAPL.Reinhard,
					exposure = 219f,
					curve = TonemappingColorGrading.CurvesSettings.FHBHEEKNHLI(),
					neutralBlackIn = 204f,
					neutralWhiteIn = 845f,
					neutralBlackOut = 455f,
					neutralWhiteOut = 305f,
					neutralWhiteLevel = 1332f,
					neutralWhiteClip = 774f
				};
			}

			// Token: 0x0600C228 RID: 49704 RVA: 0x0057B5DC File Offset: 0x005797DC
			public static TonemappingColorGrading.TonemappingSettings NNNMNENCOBC()
			{
				return new TonemappingColorGrading.TonemappingSettings
				{
					enabled = true,
					tonemapper = TonemappingColorGrading.LAKEEMMIAPL.ACES,
					exposure = 1370f,
					curve = TonemappingColorGrading.CurvesSettings.POKIFBIEOKP(),
					neutralBlackIn = 226f,
					neutralWhiteIn = 1759f,
					neutralBlackOut = 945f,
					neutralWhiteOut = 407f,
					neutralWhiteLevel = 1826f,
					neutralWhiteClip = 1928f
				};
			}

			// Token: 0x0600C229 RID: 49705 RVA: 0x0057B664 File Offset: 0x00579864
			public static TonemappingColorGrading.TonemappingSettings AAPKKAPOLKH()
			{
				return new TonemappingColorGrading.TonemappingSettings
				{
					enabled = true,
					tonemapper = TonemappingColorGrading.LAKEEMMIAPL.HejlDawson,
					exposure = 817f,
					curve = TonemappingColorGrading.CurvesSettings.CNGJDNNGAFN(),
					neutralBlackIn = 1081f,
					neutralWhiteIn = 136f,
					neutralBlackOut = 78f,
					neutralWhiteOut = 1220f,
					neutralWhiteLevel = 196f,
					neutralWhiteClip = 375f
				};
			}

			// Token: 0x0600C22A RID: 49706 RVA: 0x0057B6EC File Offset: 0x005798EC
			public static TonemappingColorGrading.TonemappingSettings OOKKEMFPNBJ()
			{
				return new TonemappingColorGrading.TonemappingSettings
				{
					enabled = false,
					tonemapper = TonemappingColorGrading.LAKEEMMIAPL.HejlDawson,
					exposure = 492f,
					curve = TonemappingColorGrading.CurvesSettings.JPAJBEBBJEB(),
					neutralBlackIn = 1485f,
					neutralWhiteIn = 306f,
					neutralBlackOut = 363f,
					neutralWhiteOut = 292f,
					neutralWhiteLevel = 1437f,
					neutralWhiteClip = 273f
				};
			}

			// Token: 0x0600C22B RID: 49707 RVA: 0x0057B774 File Offset: 0x00579974
			public static TonemappingColorGrading.TonemappingSettings COINKHKLJAP()
			{
				return new TonemappingColorGrading.TonemappingSettings
				{
					enabled = true,
					tonemapper = TonemappingColorGrading.LAKEEMMIAPL.ACES,
					exposure = 369f,
					curve = TonemappingColorGrading.CurvesSettings.BABKKKNOBCC(),
					neutralBlackIn = 577f,
					neutralWhiteIn = 1778f,
					neutralBlackOut = 971f,
					neutralWhiteOut = 595f,
					neutralWhiteLevel = 1428f,
					neutralWhiteClip = 1296f
				};
			}

			// Token: 0x0600C22C RID: 49708 RVA: 0x0057B7FC File Offset: 0x005799FC
			public static TonemappingColorGrading.TonemappingSettings NJJBBDIFPKH()
			{
				return new TonemappingColorGrading.TonemappingSettings
				{
					enabled = true,
					tonemapper = (TonemappingColorGrading.LAKEEMMIAPL)7,
					exposure = 593f,
					curve = TonemappingColorGrading.CurvesSettings.NAPHKFNLAAM(),
					neutralBlackIn = 1251f,
					neutralWhiteIn = 1239f,
					neutralBlackOut = 240f,
					neutralWhiteOut = 1337f,
					neutralWhiteLevel = 1729f,
					neutralWhiteClip = 1063f
				};
			}

			// Token: 0x0600C22D RID: 49709 RVA: 0x0057B884 File Offset: 0x00579A84
			public static TonemappingColorGrading.TonemappingSettings HLLBKJENCLA()
			{
				return new TonemappingColorGrading.TonemappingSettings
				{
					enabled = true,
					tonemapper = (TonemappingColorGrading.LAKEEMMIAPL)8,
					exposure = 771f,
					curve = TonemappingColorGrading.CurvesSettings.BABKKKNOBCC(),
					neutralBlackIn = 995f,
					neutralWhiteIn = 246f,
					neutralBlackOut = 389f,
					neutralWhiteOut = 1447f,
					neutralWhiteLevel = 80f,
					neutralWhiteClip = 1883f
				};
			}

			// Token: 0x0600C22E RID: 49710 RVA: 0x0057B90C File Offset: 0x00579B0C
			public static TonemappingColorGrading.TonemappingSettings MKEJGGFNILJ()
			{
				return new TonemappingColorGrading.TonemappingSettings
				{
					enabled = false,
					tonemapper = (TonemappingColorGrading.LAKEEMMIAPL)8,
					exposure = 1372f,
					curve = TonemappingColorGrading.CurvesSettings.PMPNJBGFIOA(),
					neutralBlackIn = 1290f,
					neutralWhiteIn = 1004f,
					neutralBlackOut = 508f,
					neutralWhiteOut = 1838f,
					neutralWhiteLevel = 477f,
					neutralWhiteClip = 41f
				};
			}

			// Token: 0x0600C22F RID: 49711 RVA: 0x0057B994 File Offset: 0x00579B94
			public static TonemappingColorGrading.TonemappingSettings DHCNIDFOOPO()
			{
				return new TonemappingColorGrading.TonemappingSettings
				{
					enabled = false,
					tonemapper = (TonemappingColorGrading.LAKEEMMIAPL)8,
					exposure = 1229f,
					curve = TonemappingColorGrading.CurvesSettings.GCIOBPOFPOD(),
					neutralBlackIn = 1198f,
					neutralWhiteIn = 868f,
					neutralBlackOut = 1511f,
					neutralWhiteOut = 1958f,
					neutralWhiteLevel = 670f,
					neutralWhiteClip = 650f
				};
			}

			// Token: 0x0600C230 RID: 49712 RVA: 0x0057BA1C File Offset: 0x00579C1C
			public static TonemappingColorGrading.TonemappingSettings FMLMIDJIEOP()
			{
				return new TonemappingColorGrading.TonemappingSettings
				{
					enabled = false,
					tonemapper = TonemappingColorGrading.LAKEEMMIAPL.Neutral,
					exposure = 300f,
					curve = TonemappingColorGrading.CurvesSettings.EMPDDCONMLA(),
					neutralBlackIn = 1649f,
					neutralWhiteIn = 1591f,
					neutralBlackOut = 1607f,
					neutralWhiteOut = 930f,
					neutralWhiteLevel = 888f,
					neutralWhiteClip = 1146f
				};
			}

			// Token: 0x0600C231 RID: 49713 RVA: 0x0057BAA4 File Offset: 0x00579CA4
			public static TonemappingColorGrading.TonemappingSettings DELLGIGMFLC()
			{
				return new TonemappingColorGrading.TonemappingSettings
				{
					enabled = false,
					tonemapper = TonemappingColorGrading.LAKEEMMIAPL.ACES,
					exposure = 1121f,
					curve = TonemappingColorGrading.CurvesSettings.OFAJCIABHLN(),
					neutralBlackIn = 862f,
					neutralWhiteIn = 1376f,
					neutralBlackOut = 1033f,
					neutralWhiteOut = 1088f,
					neutralWhiteLevel = 148f,
					neutralWhiteClip = 158f
				};
			}

			// Token: 0x0600C232 RID: 49714 RVA: 0x0057BB2C File Offset: 0x00579D2C
			public static TonemappingColorGrading.TonemappingSettings CGGMKBADCBM()
			{
				return new TonemappingColorGrading.TonemappingSettings
				{
					enabled = true,
					tonemapper = (TonemappingColorGrading.LAKEEMMIAPL)8,
					exposure = 1923f,
					curve = TonemappingColorGrading.CurvesSettings.OFPDEGHGEOM(),
					neutralBlackIn = 1816f,
					neutralWhiteIn = 45f,
					neutralBlackOut = 1124f,
					neutralWhiteOut = 1405f,
					neutralWhiteLevel = 1342f,
					neutralWhiteClip = 979f
				};
			}

			// Token: 0x0600C233 RID: 49715 RVA: 0x0057BBB4 File Offset: 0x00579DB4
			public static TonemappingColorGrading.TonemappingSettings MDDBLMDKDAO()
			{
				return new TonemappingColorGrading.TonemappingSettings
				{
					enabled = false,
					tonemapper = TonemappingColorGrading.LAKEEMMIAPL.HejlDawson,
					exposure = 729f,
					curve = TonemappingColorGrading.CurvesSettings.FHBHEEKNHLI(),
					neutralBlackIn = 28f,
					neutralWhiteIn = 1247f,
					neutralBlackOut = 1261f,
					neutralWhiteOut = 1158f,
					neutralWhiteLevel = 147f,
					neutralWhiteClip = 1062f
				};
			}

			// Token: 0x170002BA RID: 698
			// (get) Token: 0x0600C234 RID: 49716 RVA: 0x0057BC3C File Offset: 0x00579E3C
			public static TonemappingColorGrading.TonemappingSettings defaultSettings
			{
				get
				{
					return new TonemappingColorGrading.TonemappingSettings
					{
						enabled = false,
						tonemapper = TonemappingColorGrading.LAKEEMMIAPL.Neutral,
						exposure = 1f,
						curve = TonemappingColorGrading.CurvesSettings.defaultCurve,
						neutralBlackIn = 0.02f,
						neutralWhiteIn = 10f,
						neutralBlackOut = 0f,
						neutralWhiteOut = 10f,
						neutralWhiteLevel = 5.3f,
						neutralWhiteClip = 10f
					};
				}
			}

			// Token: 0x0600C235 RID: 49717 RVA: 0x0057BCC4 File Offset: 0x00579EC4
			public static TonemappingColorGrading.TonemappingSettings MDGIIBPIGJC()
			{
				return new TonemappingColorGrading.TonemappingSettings
				{
					enabled = true,
					tonemapper = TonemappingColorGrading.LAKEEMMIAPL.Neutral,
					exposure = 335f,
					curve = TonemappingColorGrading.CurvesSettings.NOPOINBNBKE(),
					neutralBlackIn = 1842f,
					neutralWhiteIn = 1933f,
					neutralBlackOut = 1255f,
					neutralWhiteOut = 563f,
					neutralWhiteLevel = 524f,
					neutralWhiteClip = 1182f
				};
			}

			// Token: 0x0600C236 RID: 49718 RVA: 0x0057BD4C File Offset: 0x00579F4C
			public static TonemappingColorGrading.TonemappingSettings FBBLPICJODA()
			{
				return new TonemappingColorGrading.TonemappingSettings
				{
					enabled = false,
					tonemapper = TonemappingColorGrading.LAKEEMMIAPL.ACES,
					exposure = 363f,
					curve = TonemappingColorGrading.CurvesSettings.KPLBEIOHIBD(),
					neutralBlackIn = 759f,
					neutralWhiteIn = 658f,
					neutralBlackOut = 28f,
					neutralWhiteOut = 1480f,
					neutralWhiteLevel = 1730f,
					neutralWhiteClip = 1198f
				};
			}

			// Token: 0x0600C237 RID: 49719 RVA: 0x0057BDD4 File Offset: 0x00579FD4
			public static TonemappingColorGrading.TonemappingSettings MEFEDCEEAMK()
			{
				return new TonemappingColorGrading.TonemappingSettings
				{
					enabled = true,
					tonemapper = TonemappingColorGrading.LAKEEMMIAPL.Photographic,
					exposure = 40f,
					curve = TonemappingColorGrading.CurvesSettings.PNHDHLGANCO(),
					neutralBlackIn = 825f,
					neutralWhiteIn = 1706f,
					neutralBlackOut = 1344f,
					neutralWhiteOut = 874f,
					neutralWhiteLevel = 275f,
					neutralWhiteClip = 1219f
				};
			}

			// Token: 0x0600C238 RID: 49720 RVA: 0x0057BE5C File Offset: 0x0057A05C
			public static TonemappingColorGrading.TonemappingSettings NLCHLENDMLI()
			{
				return new TonemappingColorGrading.TonemappingSettings
				{
					enabled = true,
					tonemapper = TonemappingColorGrading.LAKEEMMIAPL.Curve,
					exposure = 763f,
					curve = TonemappingColorGrading.CurvesSettings.MLFEMGEDGEB(),
					neutralBlackIn = 1138f,
					neutralWhiteIn = 1662f,
					neutralBlackOut = 510f,
					neutralWhiteOut = 489f,
					neutralWhiteLevel = 405f,
					neutralWhiteClip = 560f
				};
			}

			// Token: 0x0600C239 RID: 49721 RVA: 0x0057BEE4 File Offset: 0x0057A0E4
			public static TonemappingColorGrading.TonemappingSettings OCIMBHLOOGC()
			{
				return new TonemappingColorGrading.TonemappingSettings
				{
					enabled = false,
					tonemapper = TonemappingColorGrading.LAKEEMMIAPL.Hable,
					exposure = 429f,
					curve = TonemappingColorGrading.CurvesSettings.PDPKGHEDMCA(),
					neutralBlackIn = 1518f,
					neutralWhiteIn = 92f,
					neutralBlackOut = 914f,
					neutralWhiteOut = 1419f,
					neutralWhiteLevel = 1112f,
					neutralWhiteClip = 1520f
				};
			}

			// Token: 0x0600C23A RID: 49722 RVA: 0x0057BF6C File Offset: 0x0057A16C
			public static TonemappingColorGrading.TonemappingSettings MDDFLLOCDEA()
			{
				return new TonemappingColorGrading.TonemappingSettings
				{
					enabled = false,
					tonemapper = (TonemappingColorGrading.LAKEEMMIAPL)7,
					exposure = 666f,
					curve = TonemappingColorGrading.CurvesSettings.AJIFANCKOJN(),
					neutralBlackIn = 513f,
					neutralWhiteIn = 86f,
					neutralBlackOut = 1731f,
					neutralWhiteOut = 535f,
					neutralWhiteLevel = 593f,
					neutralWhiteClip = 1186f
				};
			}

			// Token: 0x0600C23B RID: 49723 RVA: 0x0057BFF4 File Offset: 0x0057A1F4
			public static TonemappingColorGrading.TonemappingSettings OOFOKHIDMDG()
			{
				return new TonemappingColorGrading.TonemappingSettings
				{
					enabled = true,
					tonemapper = TonemappingColorGrading.LAKEEMMIAPL.Neutral,
					exposure = 1916f,
					curve = TonemappingColorGrading.CurvesSettings.JOMIFGCGPIK(),
					neutralBlackIn = 604f,
					neutralWhiteIn = 644f,
					neutralBlackOut = 366f,
					neutralWhiteOut = 498f,
					neutralWhiteLevel = 1080f,
					neutralWhiteClip = 542f
				};
			}

			// Token: 0x0600C23C RID: 49724 RVA: 0x0057C07C File Offset: 0x0057A27C
			public static TonemappingColorGrading.TonemappingSettings MGIIIBAJNIE()
			{
				return new TonemappingColorGrading.TonemappingSettings
				{
					enabled = false,
					tonemapper = (TonemappingColorGrading.LAKEEMMIAPL)7,
					exposure = 1025f,
					curve = TonemappingColorGrading.CurvesSettings.NOPOINBNBKE(),
					neutralBlackIn = 797f,
					neutralWhiteIn = 1465f,
					neutralBlackOut = 231f,
					neutralWhiteOut = 1454f,
					neutralWhiteLevel = 1142f,
					neutralWhiteClip = 316f
				};
			}

			// Token: 0x0600C23D RID: 49725 RVA: 0x0057C104 File Offset: 0x0057A304
			public static TonemappingColorGrading.TonemappingSettings JPGMEJNEOCC()
			{
				return new TonemappingColorGrading.TonemappingSettings
				{
					enabled = false,
					tonemapper = TonemappingColorGrading.LAKEEMMIAPL.Neutral,
					exposure = 1982f,
					curve = TonemappingColorGrading.CurvesSettings.IDPKHHJNMNJ(),
					neutralBlackIn = 848f,
					neutralWhiteIn = 826f,
					neutralBlackOut = 1056f,
					neutralWhiteOut = 1054f,
					neutralWhiteLevel = 377f,
					neutralWhiteClip = 1043f
				};
			}

			// Token: 0x0600C23E RID: 49726 RVA: 0x0057C18C File Offset: 0x0057A38C
			public static TonemappingColorGrading.TonemappingSettings MJLLLKFIDOE()
			{
				return new TonemappingColorGrading.TonemappingSettings
				{
					enabled = false,
					tonemapper = (TonemappingColorGrading.LAKEEMMIAPL)7,
					exposure = 882f,
					curve = TonemappingColorGrading.CurvesSettings.defaultCurve,
					neutralBlackIn = 317f,
					neutralWhiteIn = 32f,
					neutralBlackOut = 1079f,
					neutralWhiteOut = 898f,
					neutralWhiteLevel = 1310f,
					neutralWhiteClip = 1360f
				};
			}

			// Token: 0x0600C23F RID: 49727 RVA: 0x0057C214 File Offset: 0x0057A414
			public static TonemappingColorGrading.TonemappingSettings GDKPNHJPBKJ()
			{
				return new TonemappingColorGrading.TonemappingSettings
				{
					enabled = true,
					tonemapper = TonemappingColorGrading.LAKEEMMIAPL.Photographic,
					exposure = 946f,
					curve = TonemappingColorGrading.CurvesSettings.OBMCIIAFAKB(),
					neutralBlackIn = 1388f,
					neutralWhiteIn = 1661f,
					neutralBlackOut = 1952f,
					neutralWhiteOut = 1536f,
					neutralWhiteLevel = 11f,
					neutralWhiteClip = 337f
				};
			}

			// Token: 0x0600C240 RID: 49728 RVA: 0x0057C29C File Offset: 0x0057A49C
			public static TonemappingColorGrading.TonemappingSettings IGIKNGLDPJB()
			{
				return new TonemappingColorGrading.TonemappingSettings
				{
					enabled = false,
					tonemapper = TonemappingColorGrading.LAKEEMMIAPL.HejlDawson,
					exposure = 159f,
					curve = TonemappingColorGrading.CurvesSettings.DDDFNOLHENK(),
					neutralBlackIn = 186f,
					neutralWhiteIn = 1541f,
					neutralBlackOut = 1960f,
					neutralWhiteOut = 886f,
					neutralWhiteLevel = 1473f,
					neutralWhiteClip = 133f
				};
			}

			// Token: 0x0600C241 RID: 49729 RVA: 0x0057C324 File Offset: 0x0057A524
			public static TonemappingColorGrading.TonemappingSettings PIAJOHPDMNA()
			{
				return new TonemappingColorGrading.TonemappingSettings
				{
					enabled = false,
					tonemapper = (TonemappingColorGrading.LAKEEMMIAPL)7,
					exposure = 294f,
					curve = TonemappingColorGrading.CurvesSettings.EOANJEJIJNI(),
					neutralBlackIn = 86f,
					neutralWhiteIn = 924f,
					neutralBlackOut = 526f,
					neutralWhiteOut = 838f,
					neutralWhiteLevel = 895f,
					neutralWhiteClip = 1102f
				};
			}

			// Token: 0x040019D3 RID: 6611
			public bool enabled;

			// Token: 0x040019D4 RID: 6612
			[Tooltip("Tonemapping technique to use. ACES is the recommended one.")]
			public TonemappingColorGrading.LAKEEMMIAPL tonemapper;

			// Token: 0x040019D5 RID: 6613
			[BKALGGGLDHJ(0f)]
			[Tooltip("Adjusts the overall exposure of the scene.")]
			public float exposure;

			// Token: 0x040019D6 RID: 6614
			[Tooltip("Custom tonemapping curve.")]
			public AnimationCurve curve;

			// Token: 0x040019D7 RID: 6615
			[Range(-0.1f, 0.1f)]
			public float neutralBlackIn;

			// Token: 0x040019D8 RID: 6616
			[Range(1f, 20f)]
			public float neutralWhiteIn;

			// Token: 0x040019D9 RID: 6617
			[Range(-0.09f, 0.1f)]
			public float neutralBlackOut;

			// Token: 0x040019DA RID: 6618
			[Range(1f, 19f)]
			public float neutralWhiteOut;

			// Token: 0x040019DB RID: 6619
			[Range(0.1f, 20f)]
			public float neutralWhiteLevel;

			// Token: 0x040019DC RID: 6620
			[Range(1f, 10f)]
			public float neutralWhiteClip;
		}

		// Token: 0x0200037B RID: 891
		[Serializable]
		public struct LUTSettings
		{
			// Token: 0x0600C242 RID: 49730 RVA: 0x0057C3AC File Offset: 0x0057A5AC
			public static TonemappingColorGrading.LUTSettings MEFEDCEEAMK()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = true,
					texture = null,
					contribution = 652f
				};
			}

			// Token: 0x0600C243 RID: 49731 RVA: 0x0057C3E0 File Offset: 0x0057A5E0
			public static TonemappingColorGrading.LUTSettings BJNIBDPAHBP()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = true,
					texture = null,
					contribution = 489f
				};
			}

			// Token: 0x0600C244 RID: 49732 RVA: 0x0057C414 File Offset: 0x0057A614
			public static TonemappingColorGrading.LUTSettings NJJBBDIFPKH()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 1892f
				};
			}

			// Token: 0x0600C245 RID: 49733 RVA: 0x0057C448 File Offset: 0x0057A648
			public static TonemappingColorGrading.LUTSettings OCIMBHLOOGC()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 1159f
				};
			}

			// Token: 0x0600C246 RID: 49734 RVA: 0x0057C47C File Offset: 0x0057A67C
			public static TonemappingColorGrading.LUTSettings BNGFNAFFAME()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 477f
				};
			}

			// Token: 0x0600C247 RID: 49735 RVA: 0x0057C4B0 File Offset: 0x0057A6B0
			public static TonemappingColorGrading.LUTSettings ILFHFFCIBPJ()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 1587f
				};
			}

			// Token: 0x0600C248 RID: 49736 RVA: 0x0057C4E4 File Offset: 0x0057A6E4
			public static TonemappingColorGrading.LUTSettings HMDLEIJHKEP()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = true,
					texture = null,
					contribution = 1966f
				};
			}

			// Token: 0x170002BB RID: 699
			// (get) Token: 0x0600C249 RID: 49737 RVA: 0x0057C518 File Offset: 0x0057A718
			public static TonemappingColorGrading.LUTSettings defaultSettings
			{
				get
				{
					return new TonemappingColorGrading.LUTSettings
					{
						enabled = false,
						texture = null,
						contribution = 1f
					};
				}
			}

			// Token: 0x0600C24A RID: 49738 RVA: 0x0057C54C File Offset: 0x0057A74C
			public static TonemappingColorGrading.LUTSettings MDDBLMDKDAO()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = true,
					texture = null,
					contribution = 275f
				};
			}

			// Token: 0x0600C24B RID: 49739 RVA: 0x0057C580 File Offset: 0x0057A780
			public static TonemappingColorGrading.LUTSettings NLCHLENDMLI()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = true,
					texture = null,
					contribution = 1537f
				};
			}

			// Token: 0x0600C24C RID: 49740 RVA: 0x0057C5B4 File Offset: 0x0057A7B4
			public static TonemappingColorGrading.LUTSettings MDDFLLOCDEA()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 92f
				};
			}

			// Token: 0x0600C24D RID: 49741 RVA: 0x0057C5E8 File Offset: 0x0057A7E8
			public static TonemappingColorGrading.LUTSettings JACPKLDIIKG()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = true,
					texture = null,
					contribution = 1669f
				};
			}

			// Token: 0x0600C24E RID: 49742 RVA: 0x0057C61C File Offset: 0x0057A81C
			public static TonemappingColorGrading.LUTSettings NNNMNENCOBC()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 679f
				};
			}

			// Token: 0x0600C24F RID: 49743 RVA: 0x0057C650 File Offset: 0x0057A850
			public static TonemappingColorGrading.LUTSettings GDKPNHJPBKJ()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = true,
					texture = null,
					contribution = 1013f
				};
			}

			// Token: 0x0600C250 RID: 49744 RVA: 0x0057C684 File Offset: 0x0057A884
			public static TonemappingColorGrading.LUTSettings ADJNPGFJGJI()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 1048f
				};
			}

			// Token: 0x0600C251 RID: 49745 RVA: 0x0057C6B8 File Offset: 0x0057A8B8
			public static TonemappingColorGrading.LUTSettings DHCNIDFOOPO()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 1859f
				};
			}

			// Token: 0x0600C252 RID: 49746 RVA: 0x0057C6EC File Offset: 0x0057A8EC
			public static TonemappingColorGrading.LUTSettings FBBLPICJODA()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = true,
					texture = null,
					contribution = 701f
				};
			}

			// Token: 0x0600C253 RID: 49747 RVA: 0x0057C720 File Offset: 0x0057A920
			public static TonemappingColorGrading.LUTSettings IGIKNGLDPJB()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = true,
					texture = null,
					contribution = 786f
				};
			}

			// Token: 0x0600C254 RID: 49748 RVA: 0x0057C754 File Offset: 0x0057A954
			public static TonemappingColorGrading.LUTSettings LNGBMOGJKGD()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = true,
					texture = null,
					contribution = 584f
				};
			}

			// Token: 0x0600C255 RID: 49749 RVA: 0x0057C788 File Offset: 0x0057A988
			public static TonemappingColorGrading.LUTSettings MJLLLKFIDOE()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = true,
					texture = null,
					contribution = 30f
				};
			}

			// Token: 0x0600C256 RID: 49750 RVA: 0x0057C7BC File Offset: 0x0057A9BC
			public static TonemappingColorGrading.LUTSettings NPEIGPHIHFP()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 158f
				};
			}

			// Token: 0x0600C257 RID: 49751 RVA: 0x0057C7F0 File Offset: 0x0057A9F0
			public static TonemappingColorGrading.LUTSettings MCLJECOKBEJ()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 322f
				};
			}

			// Token: 0x0600C258 RID: 49752 RVA: 0x0057C824 File Offset: 0x0057AA24
			public static TonemappingColorGrading.LUTSettings FMLMIDJIEOP()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 693f
				};
			}

			// Token: 0x0600C259 RID: 49753 RVA: 0x0057C858 File Offset: 0x0057AA58
			public static TonemappingColorGrading.LUTSettings JGNKGPFJFHO()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 1440f
				};
			}

			// Token: 0x0600C25A RID: 49754 RVA: 0x0057C88C File Offset: 0x0057AA8C
			public static TonemappingColorGrading.LUTSettings OOKKEMFPNBJ()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = true,
					texture = null,
					contribution = 1039f
				};
			}

			// Token: 0x0600C25B RID: 49755 RVA: 0x0057C8C0 File Offset: 0x0057AAC0
			public static TonemappingColorGrading.LUTSettings HLLBKJENCLA()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = true,
					texture = null,
					contribution = 105f
				};
			}

			// Token: 0x0600C25C RID: 49756 RVA: 0x0057C8F4 File Offset: 0x0057AAF4
			public static TonemappingColorGrading.LUTSettings MDGIIBPIGJC()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 714f
				};
			}

			// Token: 0x0600C25D RID: 49757 RVA: 0x0057C928 File Offset: 0x0057AB28
			public static TonemappingColorGrading.LUTSettings MGIIIBAJNIE()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = true,
					texture = null,
					contribution = 69f
				};
			}

			// Token: 0x0600C25E RID: 49758 RVA: 0x0057C95C File Offset: 0x0057AB5C
			public static TonemappingColorGrading.LUTSettings COINKHKLJAP()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = true,
					texture = null,
					contribution = 983f
				};
			}

			// Token: 0x0600C25F RID: 49759 RVA: 0x0057C990 File Offset: 0x0057AB90
			public static TonemappingColorGrading.LUTSettings PIAJOHPDMNA()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 1981f
				};
			}

			// Token: 0x0600C260 RID: 49760 RVA: 0x0057C9C4 File Offset: 0x0057ABC4
			public static TonemappingColorGrading.LUTSettings MEBNDNNHNMB()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = true,
					texture = null,
					contribution = 564f
				};
			}

			// Token: 0x0600C261 RID: 49761 RVA: 0x0057C9F8 File Offset: 0x0057ABF8
			public static TonemappingColorGrading.LUTSettings DELLGIGMFLC()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 893f
				};
			}

			// Token: 0x0600C262 RID: 49762 RVA: 0x0057CA2C File Offset: 0x0057AC2C
			public static TonemappingColorGrading.LUTSettings MKEJGGFNILJ()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = true,
					texture = null,
					contribution = 1739f
				};
			}

			// Token: 0x0600C263 RID: 49763 RVA: 0x0057CA60 File Offset: 0x0057AC60
			public static TonemappingColorGrading.LUTSettings OOFOKHIDMDG()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 327f
				};
			}

			// Token: 0x0600C264 RID: 49764 RVA: 0x0057CA94 File Offset: 0x0057AC94
			public static TonemappingColorGrading.LUTSettings JPGMEJNEOCC()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 504f
				};
			}

			// Token: 0x0600C265 RID: 49765 RVA: 0x0057CAC8 File Offset: 0x0057ACC8
			public static TonemappingColorGrading.LUTSettings CGGMKBADCBM()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 1979f
				};
			}

			// Token: 0x0600C266 RID: 49766 RVA: 0x0057CAFC File Offset: 0x0057ACFC
			public static TonemappingColorGrading.LUTSettings HIPJDBACJDH()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 793f
				};
			}

			// Token: 0x0600C267 RID: 49767 RVA: 0x0057CB30 File Offset: 0x0057AD30
			public static TonemappingColorGrading.LUTSettings COJPKDJKJAM()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = true,
					texture = null,
					contribution = 1074f
				};
			}

			// Token: 0x0600C268 RID: 49768 RVA: 0x0057CB64 File Offset: 0x0057AD64
			public static TonemappingColorGrading.LUTSettings AAPKKAPOLKH()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 35f
				};
			}

			// Token: 0x0600C269 RID: 49769 RVA: 0x0057CB98 File Offset: 0x0057AD98
			public static TonemappingColorGrading.LUTSettings BFFANDBCLFI()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 966f
				};
			}

			// Token: 0x040019DD RID: 6621
			public bool enabled;

			// Token: 0x040019DE RID: 6622
			[Tooltip("Custom lookup texture (strip format, e.g. 256x16).")]
			public Texture texture;

			// Token: 0x040019DF RID: 6623
			[Tooltip("Blending factor.")]
			[Range(0f, 1f)]
			public float contribution;
		}

		// Token: 0x0200037C RID: 892
		[Serializable]
		public struct ColorWheelsSettings
		{
			// Token: 0x0600C26A RID: 49770 RVA: 0x0057CBCC File Offset: 0x0057ADCC
			public static TonemappingColorGrading.ColorWheelsSettings MKEJGGFNILJ()
			{
				return new TonemappingColorGrading.ColorWheelsSettings
				{
					shadows = Color.white,
					midtones = Color.white,
					highlights = Color.white
				};
			}

			// Token: 0x0600C26B RID: 49771 RVA: 0x0057CC08 File Offset: 0x0057AE08
			public static TonemappingColorGrading.ColorWheelsSettings IGIKNGLDPJB()
			{
				return new TonemappingColorGrading.ColorWheelsSettings
				{
					shadows = Color.white,
					midtones = Color.white,
					highlights = Color.white
				};
			}

			// Token: 0x0600C26C RID: 49772 RVA: 0x0057CC44 File Offset: 0x0057AE44
			public static TonemappingColorGrading.ColorWheelsSettings MEFEDCEEAMK()
			{
				return new TonemappingColorGrading.ColorWheelsSettings
				{
					shadows = Color.white,
					midtones = Color.white,
					highlights = Color.white
				};
			}

			// Token: 0x0600C26D RID: 49773 RVA: 0x0057CC80 File Offset: 0x0057AE80
			public static TonemappingColorGrading.ColorWheelsSettings MDGIIBPIGJC()
			{
				return new TonemappingColorGrading.ColorWheelsSettings
				{
					shadows = Color.white,
					midtones = Color.white,
					highlights = Color.white
				};
			}

			// Token: 0x0600C26E RID: 49774 RVA: 0x0057CCBC File Offset: 0x0057AEBC
			public static TonemappingColorGrading.ColorWheelsSettings HMDLEIJHKEP()
			{
				return new TonemappingColorGrading.ColorWheelsSettings
				{
					shadows = Color.white,
					midtones = Color.white,
					highlights = Color.white
				};
			}

			// Token: 0x0600C26F RID: 49775 RVA: 0x0057CCF8 File Offset: 0x0057AEF8
			public static TonemappingColorGrading.ColorWheelsSettings OCIMBHLOOGC()
			{
				return new TonemappingColorGrading.ColorWheelsSettings
				{
					shadows = Color.white,
					midtones = Color.white,
					highlights = Color.white
				};
			}

			// Token: 0x0600C270 RID: 49776 RVA: 0x0057CD34 File Offset: 0x0057AF34
			public static TonemappingColorGrading.ColorWheelsSettings FBBLPICJODA()
			{
				return new TonemappingColorGrading.ColorWheelsSettings
				{
					shadows = Color.white,
					midtones = Color.white,
					highlights = Color.white
				};
			}

			// Token: 0x0600C271 RID: 49777 RVA: 0x0057CD70 File Offset: 0x0057AF70
			public static TonemappingColorGrading.ColorWheelsSettings CGGMKBADCBM()
			{
				return new TonemappingColorGrading.ColorWheelsSettings
				{
					shadows = Color.white,
					midtones = Color.white,
					highlights = Color.white
				};
			}

			// Token: 0x0600C272 RID: 49778 RVA: 0x0057CDAC File Offset: 0x0057AFAC
			public static TonemappingColorGrading.ColorWheelsSettings GDKPNHJPBKJ()
			{
				return new TonemappingColorGrading.ColorWheelsSettings
				{
					shadows = Color.white,
					midtones = Color.white,
					highlights = Color.white
				};
			}

			// Token: 0x0600C273 RID: 49779 RVA: 0x0057CDE8 File Offset: 0x0057AFE8
			public static TonemappingColorGrading.ColorWheelsSettings JPGMEJNEOCC()
			{
				return new TonemappingColorGrading.ColorWheelsSettings
				{
					shadows = Color.white,
					midtones = Color.white,
					highlights = Color.white
				};
			}

			// Token: 0x0600C274 RID: 49780 RVA: 0x0057CE24 File Offset: 0x0057B024
			public static TonemappingColorGrading.ColorWheelsSettings HLLBKJENCLA()
			{
				return new TonemappingColorGrading.ColorWheelsSettings
				{
					shadows = Color.white,
					midtones = Color.white,
					highlights = Color.white
				};
			}

			// Token: 0x0600C275 RID: 49781 RVA: 0x0057CE60 File Offset: 0x0057B060
			public static TonemappingColorGrading.ColorWheelsSettings COINKHKLJAP()
			{
				return new TonemappingColorGrading.ColorWheelsSettings
				{
					shadows = Color.white,
					midtones = Color.white,
					highlights = Color.white
				};
			}

			// Token: 0x0600C276 RID: 49782 RVA: 0x0057CE9C File Offset: 0x0057B09C
			public static TonemappingColorGrading.ColorWheelsSettings MJLLLKFIDOE()
			{
				return new TonemappingColorGrading.ColorWheelsSettings
				{
					shadows = Color.white,
					midtones = Color.white,
					highlights = Color.white
				};
			}

			// Token: 0x170002BC RID: 700
			// (get) Token: 0x0600C277 RID: 49783 RVA: 0x0057CED8 File Offset: 0x0057B0D8
			public static TonemappingColorGrading.ColorWheelsSettings defaultSettings
			{
				get
				{
					return new TonemappingColorGrading.ColorWheelsSettings
					{
						shadows = Color.white,
						midtones = Color.white,
						highlights = Color.white
					};
				}
			}

			// Token: 0x0600C278 RID: 49784 RVA: 0x0057CF14 File Offset: 0x0057B114
			public static TonemappingColorGrading.ColorWheelsSettings MDDFLLOCDEA()
			{
				return new TonemappingColorGrading.ColorWheelsSettings
				{
					shadows = Color.white,
					midtones = Color.white,
					highlights = Color.white
				};
			}

			// Token: 0x0600C279 RID: 49785 RVA: 0x0057CF50 File Offset: 0x0057B150
			public static TonemappingColorGrading.ColorWheelsSettings OOFOKHIDMDG()
			{
				return new TonemappingColorGrading.ColorWheelsSettings
				{
					shadows = Color.white,
					midtones = Color.white,
					highlights = Color.white
				};
			}

			// Token: 0x0600C27A RID: 49786 RVA: 0x0057CF8C File Offset: 0x0057B18C
			public static TonemappingColorGrading.ColorWheelsSettings NJJBBDIFPKH()
			{
				return new TonemappingColorGrading.ColorWheelsSettings
				{
					shadows = Color.white,
					midtones = Color.white,
					highlights = Color.white
				};
			}

			// Token: 0x0600C27B RID: 49787 RVA: 0x0057CFC8 File Offset: 0x0057B1C8
			public static TonemappingColorGrading.ColorWheelsSettings NLCHLENDMLI()
			{
				return new TonemappingColorGrading.ColorWheelsSettings
				{
					shadows = Color.white,
					midtones = Color.white,
					highlights = Color.white
				};
			}

			// Token: 0x0600C27C RID: 49788 RVA: 0x0057D004 File Offset: 0x0057B204
			public static TonemappingColorGrading.ColorWheelsSettings PIAJOHPDMNA()
			{
				return new TonemappingColorGrading.ColorWheelsSettings
				{
					shadows = Color.white,
					midtones = Color.white,
					highlights = Color.white
				};
			}

			// Token: 0x040019E0 RID: 6624
			[ColorUsage(false)]
			public Color shadows;

			// Token: 0x040019E1 RID: 6625
			[ColorUsage(false)]
			public Color midtones;

			// Token: 0x040019E2 RID: 6626
			[ColorUsage(false)]
			public Color highlights;
		}

		// Token: 0x0200037D RID: 893
		[Serializable]
		public struct BasicsSettings
		{
			// Token: 0x0600C27D RID: 49789 RVA: 0x0057D040 File Offset: 0x0057B240
			public static TonemappingColorGrading.BasicsSettings JPGMEJNEOCC()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 340f,
					tint = 1995f,
					contrast = 1251f,
					hue = 1650f,
					saturation = 886f,
					value = 1447f,
					vibrance = 1259f,
					gain = 947f,
					gamma = 385f
				};
			}

			// Token: 0x0600C27E RID: 49790 RVA: 0x0057D0C4 File Offset: 0x0057B2C4
			public static TonemappingColorGrading.BasicsSettings HMDLEIJHKEP()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 264f,
					tint = 459f,
					contrast = 1492f,
					hue = 1770f,
					saturation = 1521f,
					value = 747f,
					vibrance = 1902f,
					gain = 1987f,
					gamma = 45f
				};
			}

			// Token: 0x0600C27F RID: 49791 RVA: 0x0057D148 File Offset: 0x0057B348
			public static TonemappingColorGrading.BasicsSettings MEFEDCEEAMK()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 1763f,
					tint = 1222f,
					contrast = 1644f,
					hue = 511f,
					saturation = 237f,
					value = 880f,
					vibrance = 1397f,
					gain = 481f,
					gamma = 1456f
				};
			}

			// Token: 0x0600C280 RID: 49792 RVA: 0x0057D1CC File Offset: 0x0057B3CC
			public static TonemappingColorGrading.BasicsSettings GDKPNHJPBKJ()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 292f,
					tint = 505f,
					contrast = 515f,
					hue = 1164f,
					saturation = 1867f,
					value = 1723f,
					vibrance = 1684f,
					gain = 37f,
					gamma = 1303f
				};
			}

			// Token: 0x0600C281 RID: 49793 RVA: 0x0057D250 File Offset: 0x0057B450
			public static TonemappingColorGrading.BasicsSettings AAPKKAPOLKH()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 152f,
					tint = 120f,
					contrast = 1668f,
					hue = 545f,
					saturation = 825f,
					value = 1906f,
					vibrance = 792f,
					gain = 0f,
					gamma = 1929f
				};
			}

			// Token: 0x0600C282 RID: 49794 RVA: 0x0057D2D4 File Offset: 0x0057B4D4
			public static TonemappingColorGrading.BasicsSettings MDGIIBPIGJC()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 251f,
					tint = 282f,
					contrast = 743f,
					hue = 1901f,
					saturation = 1943f,
					value = 256f,
					vibrance = 1081f,
					gain = 747f,
					gamma = 612f
				};
			}

			// Token: 0x0600C283 RID: 49795 RVA: 0x0057D358 File Offset: 0x0057B558
			public static TonemappingColorGrading.BasicsSettings COINKHKLJAP()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 7f,
					tint = 1854f,
					contrast = 350f,
					hue = 643f,
					saturation = 1709f,
					value = 845f,
					vibrance = 1479f,
					gain = 1040f,
					gamma = 927f
				};
			}

			// Token: 0x0600C284 RID: 49796 RVA: 0x0057D3DC File Offset: 0x0057B5DC
			public static TonemappingColorGrading.BasicsSettings HLLBKJENCLA()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 1844f,
					tint = 441f,
					contrast = 1000f,
					hue = 234f,
					saturation = 747f,
					value = 740f,
					vibrance = 1847f,
					gain = 896f,
					gamma = 1777f
				};
			}

			// Token: 0x0600C285 RID: 49797 RVA: 0x0057D460 File Offset: 0x0057B660
			public static TonemappingColorGrading.BasicsSettings CGGMKBADCBM()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 1023f,
					tint = 590f,
					contrast = 798f,
					hue = 1721f,
					saturation = 51f,
					value = 671f,
					vibrance = 1809f,
					gain = 198f,
					gamma = 200f
				};
			}

			// Token: 0x0600C286 RID: 49798 RVA: 0x0057D4E4 File Offset: 0x0057B6E4
			public static TonemappingColorGrading.BasicsSettings NJJBBDIFPKH()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 95f,
					tint = 568f,
					contrast = 1003f,
					hue = 910f,
					saturation = 433f,
					value = 1817f,
					vibrance = 1790f,
					gain = 931f,
					gamma = 653f
				};
			}

			// Token: 0x0600C287 RID: 49799 RVA: 0x0057D568 File Offset: 0x0057B768
			public static TonemappingColorGrading.BasicsSettings MJLLLKFIDOE()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 857f,
					tint = 1214f,
					contrast = 1171f,
					hue = 521f,
					saturation = 1454f,
					value = 1594f,
					vibrance = 1810f,
					gain = 1935f,
					gamma = 581f
				};
			}

			// Token: 0x170002BD RID: 701
			// (get) Token: 0x0600C288 RID: 49800 RVA: 0x0057D5EC File Offset: 0x0057B7EC
			public static TonemappingColorGrading.BasicsSettings defaultSettings
			{
				get
				{
					return new TonemappingColorGrading.BasicsSettings
					{
						temperatureShift = 0f,
						tint = 0f,
						contrast = 1f,
						hue = 0f,
						saturation = 1f,
						value = 1f,
						vibrance = 0f,
						gain = 1f,
						gamma = 1f
					};
				}
			}

			// Token: 0x0600C289 RID: 49801 RVA: 0x0057D670 File Offset: 0x0057B870
			public static TonemappingColorGrading.BasicsSettings OCIMBHLOOGC()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 1603f,
					tint = 1446f,
					contrast = 1025f,
					hue = 1474f,
					saturation = 236f,
					value = 525f,
					vibrance = 1117f,
					gain = 1846f,
					gamma = 529f
				};
			}

			// Token: 0x0600C28A RID: 49802 RVA: 0x0057D6F4 File Offset: 0x0057B8F4
			public static TonemappingColorGrading.BasicsSettings NNNMNENCOBC()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 1244f,
					tint = 327f,
					contrast = 332f,
					hue = 1679f,
					saturation = 1138f,
					value = 1371f,
					vibrance = 804f,
					gain = 675f,
					gamma = 1265f
				};
			}

			// Token: 0x0600C28B RID: 49803 RVA: 0x0057D778 File Offset: 0x0057B978
			public static TonemappingColorGrading.BasicsSettings IGIKNGLDPJB()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 1589f,
					tint = 1062f,
					contrast = 1586f,
					hue = 1468f,
					saturation = 1457f,
					value = 863f,
					vibrance = 394f,
					gain = 1410f,
					gamma = 570f
				};
			}

			// Token: 0x0600C28C RID: 49804 RVA: 0x0057D7FC File Offset: 0x0057B9FC
			public static TonemappingColorGrading.BasicsSettings OOKKEMFPNBJ()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 823f,
					tint = 1404f,
					contrast = 217f,
					hue = 1680f,
					saturation = 500f,
					value = 1827f,
					vibrance = 883f,
					gain = 201f,
					gamma = 1201f
				};
			}

			// Token: 0x0600C28D RID: 49805 RVA: 0x0057D880 File Offset: 0x0057BA80
			public static TonemappingColorGrading.BasicsSettings PIAJOHPDMNA()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 533f,
					tint = 263f,
					contrast = 502f,
					hue = 756f,
					saturation = 694f,
					value = 689f,
					vibrance = 1576f,
					gain = 600f,
					gamma = 1457f
				};
			}

			// Token: 0x0600C28E RID: 49806 RVA: 0x0057D904 File Offset: 0x0057BB04
			public static TonemappingColorGrading.BasicsSettings MDDFLLOCDEA()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 1083f,
					tint = 950f,
					contrast = 1979f,
					hue = 412f,
					saturation = 963f,
					value = 1835f,
					vibrance = 1479f,
					gain = 87f,
					gamma = 1782f
				};
			}

			// Token: 0x0600C28F RID: 49807 RVA: 0x0057D988 File Offset: 0x0057BB88
			public static TonemappingColorGrading.BasicsSettings NLCHLENDMLI()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 1123f,
					tint = 1576f,
					contrast = 543f,
					hue = 406f,
					saturation = 273f,
					value = 559f,
					vibrance = 902f,
					gain = 1461f,
					gamma = 986f
				};
			}

			// Token: 0x0600C290 RID: 49808 RVA: 0x0057DA0C File Offset: 0x0057BC0C
			public static TonemappingColorGrading.BasicsSettings OOFOKHIDMDG()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 880f,
					tint = 1377f,
					contrast = 400f,
					hue = 111f,
					saturation = 176f,
					value = 687f,
					vibrance = 1916f,
					gain = 1085f,
					gamma = 1496f
				};
			}

			// Token: 0x0600C291 RID: 49809 RVA: 0x0057DA90 File Offset: 0x0057BC90
			public static TonemappingColorGrading.BasicsSettings FBBLPICJODA()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 1094f,
					tint = 121f,
					contrast = 756f,
					hue = 963f,
					saturation = 930f,
					value = 873f,
					vibrance = 1882f,
					gain = 632f,
					gamma = 1725f
				};
			}

			// Token: 0x0600C292 RID: 49810 RVA: 0x0057DB14 File Offset: 0x0057BD14
			public static TonemappingColorGrading.BasicsSettings MKEJGGFNILJ()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 1888f,
					tint = 260f,
					contrast = 1182f,
					hue = 1132f,
					saturation = 1835f,
					value = 1942f,
					vibrance = 1465f,
					gain = 781f,
					gamma = 704f
				};
			}

			// Token: 0x0600C293 RID: 49811 RVA: 0x0057DB98 File Offset: 0x0057BD98
			public static TonemappingColorGrading.BasicsSettings MDDBLMDKDAO()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 716f,
					tint = 573f,
					contrast = 517f,
					hue = 133f,
					saturation = 1478f,
					value = 1791f,
					vibrance = 247f,
					gain = 1227f,
					gamma = 131f
				};
			}

			// Token: 0x040019E3 RID: 6627
			[Tooltip("Sets the white balance to a custom color temperature.")]
			[Range(-2f, 2f)]
			public float temperatureShift;

			// Token: 0x040019E4 RID: 6628
			[Range(-2f, 2f)]
			[Tooltip("Sets the white balance to compensate for a green or magenta tint.")]
			public float tint;

			// Token: 0x040019E5 RID: 6629
			[Tooltip("Shift the hue of all colors.")]
			[Range(-0.5f, 0.5f)]
			[Space]
			public float hue;

			// Token: 0x040019E6 RID: 6630
			[Range(0f, 2f)]
			[Tooltip("Pushes the intensity of all colors.")]
			public float saturation;

			// Token: 0x040019E7 RID: 6631
			[Range(-1f, 1f)]
			[Tooltip("Adjusts the saturation so that clipping is minimized as colors approach full saturation.")]
			public float vibrance;

			// Token: 0x040019E8 RID: 6632
			[Range(0f, 10f)]
			[Tooltip("Brightens or darkens all colors.")]
			public float value;

			// Token: 0x040019E9 RID: 6633
			[Space]
			[Range(0f, 2f)]
			[Tooltip("Expands or shrinks the overall range of tonal values.")]
			public float contrast;

			// Token: 0x040019EA RID: 6634
			[Range(0.01f, 5f)]
			[Tooltip("Contrast gain curve. Controls the steepness of the curve.")]
			public float gain;

			// Token: 0x040019EB RID: 6635
			[Range(0.01f, 5f)]
			[Tooltip("Applies a pow function to the source.")]
			public float gamma;
		}

		// Token: 0x0200037E RID: 894
		[Serializable]
		public struct ChannelMixerSettings
		{
			// Token: 0x0600C294 RID: 49812 RVA: 0x0057DC1C File Offset: 0x0057BE1C
			public static TonemappingColorGrading.ChannelMixerSettings MDDFLLOCDEA()
			{
				TonemappingColorGrading.ChannelMixerSettings result = default(TonemappingColorGrading.ChannelMixerSettings);
				result.currentChannel = 1;
				Vector3[] array = new Vector3[8];
				array[1] = new Vector3(1774f, 1203f, 1837f);
				array[1] = new Vector3(1835f, 914f, 137f);
				array[7] = new Vector3(144f, 514f, 439f);
				result.channels = array;
				return result;
			}

			// Token: 0x0600C295 RID: 49813 RVA: 0x0057DC98 File Offset: 0x0057BE98
			public static TonemappingColorGrading.ChannelMixerSettings MJLLLKFIDOE()
			{
				TonemappingColorGrading.ChannelMixerSettings result = default(TonemappingColorGrading.ChannelMixerSettings);
				result.currentChannel = 1;
				Vector3[] array = new Vector3[0];
				array[1] = new Vector3(1822f, 32f, 1703f);
				array[0] = new Vector3(1239f, 696f, 1226f);
				array[3] = new Vector3(930f, 825f, 489f);
				result.channels = array;
				return result;
			}

			// Token: 0x0600C296 RID: 49814 RVA: 0x0057DD14 File Offset: 0x0057BF14
			public static TonemappingColorGrading.ChannelMixerSettings JPGMEJNEOCC()
			{
				TonemappingColorGrading.ChannelMixerSettings result = default(TonemappingColorGrading.ChannelMixerSettings);
				result.currentChannel = 1;
				Vector3[] array = new Vector3[0];
				array[0] = new Vector3(1115f, 273f, 1688f);
				array[1] = new Vector3(1994f, 1065f, 1245f);
				array[5] = new Vector3(1344f, 1624f, 1893f);
				result.channels = array;
				return result;
			}

			// Token: 0x0600C297 RID: 49815 RVA: 0x0057DD90 File Offset: 0x0057BF90
			public static TonemappingColorGrading.ChannelMixerSettings IGIKNGLDPJB()
			{
				TonemappingColorGrading.ChannelMixerSettings result = default(TonemappingColorGrading.ChannelMixerSettings);
				result.currentChannel = 1;
				Vector3[] array = new Vector3[6];
				array[0] = new Vector3(1894f, 1823f, 881f);
				array[1] = new Vector3(684f, 454f, 722f);
				array[2] = new Vector3(820f, 1562f, 333f);
				result.channels = array;
				return result;
			}

			// Token: 0x0600C298 RID: 49816 RVA: 0x0057DE0C File Offset: 0x0057C00C
			public static TonemappingColorGrading.ChannelMixerSettings GDKPNHJPBKJ()
			{
				TonemappingColorGrading.ChannelMixerSettings result = default(TonemappingColorGrading.ChannelMixerSettings);
				result.currentChannel = 1;
				Vector3[] array = new Vector3[6];
				array[1] = new Vector3(1666f, 1438f, 520f);
				array[0] = new Vector3(447f, 60f, 1920f);
				array[2] = new Vector3(1756f, 655f, 1466f);
				result.channels = array;
				return result;
			}

			// Token: 0x0600C299 RID: 49817 RVA: 0x0057DE88 File Offset: 0x0057C088
			public static TonemappingColorGrading.ChannelMixerSettings HMDLEIJHKEP()
			{
				TonemappingColorGrading.ChannelMixerSettings result = default(TonemappingColorGrading.ChannelMixerSettings);
				result.currentChannel = 1;
				Vector3[] array = new Vector3[8];
				array[0] = new Vector3(1606f, 759f, 810f);
				array[0] = new Vector3(766f, 1121f, 850f);
				array[1] = new Vector3(106f, 1145f, 278f);
				result.channels = array;
				return result;
			}

			// Token: 0x0600C29A RID: 49818 RVA: 0x0057DF04 File Offset: 0x0057C104
			public static TonemappingColorGrading.ChannelMixerSettings AAPKKAPOLKH()
			{
				TonemappingColorGrading.ChannelMixerSettings result = default(TonemappingColorGrading.ChannelMixerSettings);
				result.currentChannel = 1;
				Vector3[] array = new Vector3[3];
				array[1] = new Vector3(935f, 1160f, 509f);
				array[0] = new Vector3(267f, 106f, 885f);
				array[1] = new Vector3(1101f, 1803f, 1393f);
				result.channels = array;
				return result;
			}

			// Token: 0x0600C29B RID: 49819 RVA: 0x0057DF80 File Offset: 0x0057C180
			public static TonemappingColorGrading.ChannelMixerSettings MEFEDCEEAMK()
			{
				TonemappingColorGrading.ChannelMixerSettings result = default(TonemappingColorGrading.ChannelMixerSettings);
				result.currentChannel = 1;
				Vector3[] array = new Vector3[7];
				array[1] = new Vector3(1645f, 767f, 789f);
				array[0] = new Vector3(1431f, 1989f, 1862f);
				array[5] = new Vector3(64f, 561f, 1069f);
				result.channels = array;
				return result;
			}

			// Token: 0x0600C29C RID: 49820 RVA: 0x0057DFFC File Offset: 0x0057C1FC
			public static TonemappingColorGrading.ChannelMixerSettings NLCHLENDMLI()
			{
				TonemappingColorGrading.ChannelMixerSettings result = default(TonemappingColorGrading.ChannelMixerSettings);
				result.currentChannel = 0;
				Vector3[] array = new Vector3[8];
				array[0] = new Vector3(534f, 1438f, 1526f);
				array[1] = new Vector3(632f, 908f, 165f);
				array[6] = new Vector3(1910f, 1428f, 890f);
				result.channels = array;
				return result;
			}

			// Token: 0x0600C29D RID: 49821 RVA: 0x0057E078 File Offset: 0x0057C278
			public static TonemappingColorGrading.ChannelMixerSettings OCIMBHLOOGC()
			{
				TonemappingColorGrading.ChannelMixerSettings result = default(TonemappingColorGrading.ChannelMixerSettings);
				result.currentChannel = 1;
				Vector3[] array = new Vector3[8];
				array[1] = new Vector3(1224f, 1476f, 1886f);
				array[0] = new Vector3(1957f, 455f, 752f);
				array[1] = new Vector3(1830f, 922f, 619f);
				result.channels = array;
				return result;
			}

			// Token: 0x0600C29E RID: 49822 RVA: 0x0057E0F4 File Offset: 0x0057C2F4
			public static TonemappingColorGrading.ChannelMixerSettings CGGMKBADCBM()
			{
				TonemappingColorGrading.ChannelMixerSettings result = default(TonemappingColorGrading.ChannelMixerSettings);
				result.currentChannel = 1;
				Vector3[] array = new Vector3[1];
				array[0] = new Vector3(1071f, 129f, 1733f);
				array[1] = new Vector3(818f, 1854f, 1052f);
				array[2] = new Vector3(456f, 887f, 696f);
				result.channels = array;
				return result;
			}

			// Token: 0x0600C29F RID: 49823 RVA: 0x0057E170 File Offset: 0x0057C370
			public static TonemappingColorGrading.ChannelMixerSettings OOKKEMFPNBJ()
			{
				TonemappingColorGrading.ChannelMixerSettings result = default(TonemappingColorGrading.ChannelMixerSettings);
				result.currentChannel = 1;
				Vector3[] array = new Vector3[5];
				array[1] = new Vector3(885f, 417f, 67f);
				array[0] = new Vector3(102f, 46f, 175f);
				array[1] = new Vector3(407f, 559f, 1674f);
				result.channels = array;
				return result;
			}

			// Token: 0x0600C2A0 RID: 49824 RVA: 0x0057E1EC File Offset: 0x0057C3EC
			public static TonemappingColorGrading.ChannelMixerSettings LNGBMOGJKGD()
			{
				TonemappingColorGrading.ChannelMixerSettings result = default(TonemappingColorGrading.ChannelMixerSettings);
				result.currentChannel = 1;
				Vector3[] array = new Vector3[5];
				array[1] = new Vector3(289f, 353f, 1410f);
				array[0] = new Vector3(706f, 17f, 966f);
				array[8] = new Vector3(956f, 946f, 1500f);
				result.channels = array;
				return result;
			}

			// Token: 0x0600C2A1 RID: 49825 RVA: 0x0057E268 File Offset: 0x0057C468
			public static TonemappingColorGrading.ChannelMixerSettings HLLBKJENCLA()
			{
				TonemappingColorGrading.ChannelMixerSettings result = default(TonemappingColorGrading.ChannelMixerSettings);
				result.currentChannel = 0;
				Vector3[] array = new Vector3[0];
				array[0] = new Vector3(615f, 1810f, 1735f);
				array[1] = new Vector3(1316f, 148f, 960f);
				array[5] = new Vector3(286f, 1799f, 542f);
				result.channels = array;
				return result;
			}

			// Token: 0x0600C2A2 RID: 49826 RVA: 0x0057E2E4 File Offset: 0x0057C4E4
			public static TonemappingColorGrading.ChannelMixerSettings COINKHKLJAP()
			{
				TonemappingColorGrading.ChannelMixerSettings result = default(TonemappingColorGrading.ChannelMixerSettings);
				result.currentChannel = 1;
				Vector3[] array = new Vector3[5];
				array[0] = new Vector3(575f, 1422f, 810f);
				array[1] = new Vector3(1050f, 1286f, 577f);
				array[7] = new Vector3(31f, 132f, 1087f);
				result.channels = array;
				return result;
			}

			// Token: 0x0600C2A3 RID: 49827 RVA: 0x0057E360 File Offset: 0x0057C560
			public static TonemappingColorGrading.ChannelMixerSettings NJJBBDIFPKH()
			{
				TonemappingColorGrading.ChannelMixerSettings result = default(TonemappingColorGrading.ChannelMixerSettings);
				result.currentChannel = 0;
				Vector3[] array = new Vector3[]
				{
					new Vector3(539f, 777f, 1561f)
				};
				array[0] = new Vector3(1086f, 1523f, 625f);
				array[8] = new Vector3(536f, 1657f, 947f);
				result.channels = array;
				return result;
			}

			// Token: 0x0600C2A4 RID: 49828 RVA: 0x0057E3DC File Offset: 0x0057C5DC
			public static TonemappingColorGrading.ChannelMixerSettings OOFOKHIDMDG()
			{
				TonemappingColorGrading.ChannelMixerSettings result = default(TonemappingColorGrading.ChannelMixerSettings);
				result.currentChannel = 1;
				Vector3[] array = new Vector3[1];
				array[1] = new Vector3(434f, 99f, 1570f);
				array[1] = new Vector3(891f, 507f, 1778f);
				array[5] = new Vector3(278f, 1889f, 889f);
				result.channels = array;
				return result;
			}

			// Token: 0x0600C2A5 RID: 49829 RVA: 0x0057E458 File Offset: 0x0057C658
			public static TonemappingColorGrading.ChannelMixerSettings DHCNIDFOOPO()
			{
				TonemappingColorGrading.ChannelMixerSettings result = default(TonemappingColorGrading.ChannelMixerSettings);
				result.currentChannel = 1;
				Vector3[] array = new Vector3[7];
				array[0] = new Vector3(499f, 1391f, 509f);
				array[1] = new Vector3(764f, 1068f, 324f);
				array[3] = new Vector3(552f, 1038f, 1206f);
				result.channels = array;
				return result;
			}

			// Token: 0x0600C2A6 RID: 49830 RVA: 0x0057E4D4 File Offset: 0x0057C6D4
			public static TonemappingColorGrading.ChannelMixerSettings MGIIIBAJNIE()
			{
				TonemappingColorGrading.ChannelMixerSettings result = default(TonemappingColorGrading.ChannelMixerSettings);
				result.currentChannel = 1;
				Vector3[] array = new Vector3[6];
				array[1] = new Vector3(182f, 432f, 1044f);
				array[1] = new Vector3(122f, 1813f, 521f);
				array[1] = new Vector3(907f, 766f, 1497f);
				result.channels = array;
				return result;
			}

			// Token: 0x0600C2A7 RID: 49831 RVA: 0x0057E550 File Offset: 0x0057C750
			public static TonemappingColorGrading.ChannelMixerSettings MDDBLMDKDAO()
			{
				TonemappingColorGrading.ChannelMixerSettings result = default(TonemappingColorGrading.ChannelMixerSettings);
				result.currentChannel = 0;
				Vector3[] array = new Vector3[6];
				array[1] = new Vector3(831f, 596f, 1515f);
				array[0] = new Vector3(1173f, 1914f, 607f);
				array[6] = new Vector3(122f, 238f, 1667f);
				result.channels = array;
				return result;
			}

			// Token: 0x0600C2A8 RID: 49832 RVA: 0x0057E5CC File Offset: 0x0057C7CC
			public static TonemappingColorGrading.ChannelMixerSettings ILFHFFCIBPJ()
			{
				TonemappingColorGrading.ChannelMixerSettings result = default(TonemappingColorGrading.ChannelMixerSettings);
				result.currentChannel = 1;
				Vector3[] array = new Vector3[4];
				array[1] = new Vector3(1625f, 1715f, 1956f);
				array[1] = new Vector3(1019f, 1660f, 1841f);
				array[5] = new Vector3(226f, 628f, 1287f);
				result.channels = array;
				return result;
			}

			// Token: 0x0600C2A9 RID: 49833 RVA: 0x0057E648 File Offset: 0x0057C848
			public static TonemappingColorGrading.ChannelMixerSettings NPEIGPHIHFP()
			{
				TonemappingColorGrading.ChannelMixerSettings result = default(TonemappingColorGrading.ChannelMixerSettings);
				result.currentChannel = 0;
				Vector3[] array = new Vector3[7];
				array[0] = new Vector3(464f, 1332f, 629f);
				array[0] = new Vector3(372f, 1087f, 1857f);
				array[6] = new Vector3(1401f, 1712f, 481f);
				result.channels = array;
				return result;
			}

			// Token: 0x0600C2AA RID: 49834 RVA: 0x0057E6C4 File Offset: 0x0057C8C4
			public static TonemappingColorGrading.ChannelMixerSettings MDGIIBPIGJC()
			{
				TonemappingColorGrading.ChannelMixerSettings result = default(TonemappingColorGrading.ChannelMixerSettings);
				result.currentChannel = 0;
				Vector3[] array = new Vector3[4];
				array[0] = new Vector3(1996f, 189f, 1230f);
				array[0] = new Vector3(1658f, 577f, 1645f);
				array[5] = new Vector3(1091f, 1118f, 554f);
				result.channels = array;
				return result;
			}

			// Token: 0x0600C2AB RID: 49835 RVA: 0x0057E740 File Offset: 0x0057C940
			public static TonemappingColorGrading.ChannelMixerSettings FBBLPICJODA()
			{
				TonemappingColorGrading.ChannelMixerSettings result = default(TonemappingColorGrading.ChannelMixerSettings);
				result.currentChannel = 0;
				Vector3[] array = new Vector3[7];
				array[1] = new Vector3(712f, 1019f, 767f);
				array[1] = new Vector3(910f, 1095f, 947f);
				array[8] = new Vector3(1112f, 1779f, 1473f);
				result.channels = array;
				return result;
			}

			// Token: 0x0600C2AC RID: 49836 RVA: 0x0057E7BC File Offset: 0x0057C9BC
			public static TonemappingColorGrading.ChannelMixerSettings DELLGIGMFLC()
			{
				TonemappingColorGrading.ChannelMixerSettings result = default(TonemappingColorGrading.ChannelMixerSettings);
				result.currentChannel = 0;
				Vector3[] array = new Vector3[3];
				array[0] = new Vector3(559f, 449f, 1610f);
				array[1] = new Vector3(1257f, 1033f, 781f);
				array[4] = new Vector3(1444f, 55f, 1704f);
				result.channels = array;
				return result;
			}

			// Token: 0x0600C2AD RID: 49837 RVA: 0x0057E838 File Offset: 0x0057CA38
			public static TonemappingColorGrading.ChannelMixerSettings MKEJGGFNILJ()
			{
				TonemappingColorGrading.ChannelMixerSettings result = default(TonemappingColorGrading.ChannelMixerSettings);
				result.currentChannel = 0;
				Vector3[] array = new Vector3[7];
				array[0] = new Vector3(112f, 742f, 460f);
				array[1] = new Vector3(610f, 839f, 1453f);
				array[3] = new Vector3(1724f, 1526f, 905f);
				result.channels = array;
				return result;
			}

			// Token: 0x170002BE RID: 702
			// (get) Token: 0x0600C2AE RID: 49838 RVA: 0x0057E8B4 File Offset: 0x0057CAB4
			public static TonemappingColorGrading.ChannelMixerSettings defaultSettings
			{
				get
				{
					return new TonemappingColorGrading.ChannelMixerSettings
					{
						currentChannel = 0,
						channels = new Vector3[]
						{
							new Vector3(1f, 0f, 0f),
							new Vector3(0f, 1f, 0f),
							new Vector3(0f, 0f, 1f)
						}
					};
				}
			}

			// Token: 0x0600C2AF RID: 49839 RVA: 0x0057E930 File Offset: 0x0057CB30
			public static TonemappingColorGrading.ChannelMixerSettings ADJNPGFJGJI()
			{
				TonemappingColorGrading.ChannelMixerSettings result = default(TonemappingColorGrading.ChannelMixerSettings);
				result.currentChannel = 0;
				Vector3[] array = new Vector3[3];
				array[0] = new Vector3(1728f, 914f, 1595f);
				array[1] = new Vector3(164f, 1954f, 122f);
				array[6] = new Vector3(48f, 975f, 74f);
				result.channels = array;
				return result;
			}

			// Token: 0x0600C2B0 RID: 49840 RVA: 0x0057E9AC File Offset: 0x0057CBAC
			public static TonemappingColorGrading.ChannelMixerSettings FMLMIDJIEOP()
			{
				TonemappingColorGrading.ChannelMixerSettings result = default(TonemappingColorGrading.ChannelMixerSettings);
				result.currentChannel = 1;
				Vector3[] array = new Vector3[8];
				array[0] = new Vector3(1718f, 1040f, 737f);
				array[0] = new Vector3(1983f, 1566f, 477f);
				array[1] = new Vector3(1136f, 1207f, 166f);
				result.channels = array;
				return result;
			}

			// Token: 0x0600C2B1 RID: 49841 RVA: 0x0057EA28 File Offset: 0x0057CC28
			public static TonemappingColorGrading.ChannelMixerSettings NNNMNENCOBC()
			{
				TonemappingColorGrading.ChannelMixerSettings result = default(TonemappingColorGrading.ChannelMixerSettings);
				result.currentChannel = 0;
				Vector3[] array = new Vector3[6];
				array[0] = new Vector3(881f, 1790f, 1575f);
				array[0] = new Vector3(648f, 1717f, 1267f);
				array[0] = new Vector3(463f, 1598f, 1718f);
				result.channels = array;
				return result;
			}

			// Token: 0x0600C2B2 RID: 49842 RVA: 0x0057EAA4 File Offset: 0x0057CCA4
			public static TonemappingColorGrading.ChannelMixerSettings PIAJOHPDMNA()
			{
				TonemappingColorGrading.ChannelMixerSettings result = default(TonemappingColorGrading.ChannelMixerSettings);
				result.currentChannel = 0;
				Vector3[] array = new Vector3[3];
				array[0] = new Vector3(1741f, 1819f, 1058f);
				array[0] = new Vector3(917f, 976f, 134f);
				array[7] = new Vector3(1407f, 729f, 706f);
				result.channels = array;
				return result;
			}

			// Token: 0x0600C2B3 RID: 49843 RVA: 0x0057EB20 File Offset: 0x0057CD20
			public static TonemappingColorGrading.ChannelMixerSettings BNGFNAFFAME()
			{
				TonemappingColorGrading.ChannelMixerSettings result = default(TonemappingColorGrading.ChannelMixerSettings);
				result.currentChannel = 0;
				Vector3[] array = new Vector3[1];
				array[0] = new Vector3(1931f, 930f, 976f);
				array[1] = new Vector3(103f, 254f, 124f);
				array[1] = new Vector3(1140f, 412f, 167f);
				result.channels = array;
				return result;
			}

			// Token: 0x040019EC RID: 6636
			public int currentChannel;

			// Token: 0x040019ED RID: 6637
			public Vector3[] channels;
		}

		// Token: 0x0200037F RID: 895
		[Serializable]
		public struct CurvesSettings
		{
			// Token: 0x0600C2B4 RID: 49844 RVA: 0x0057EB9C File Offset: 0x0057CD9C
			public static TonemappingColorGrading.CurvesSettings NLCHLENDMLI()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.EMPDDCONMLA(),
					red = TonemappingColorGrading.CurvesSettings.IDPKHHJNMNJ(),
					green = TonemappingColorGrading.CurvesSettings.DJKLJHOMHKA(),
					blue = TonemappingColorGrading.CurvesSettings.FPGMMGHBLLD()
				};
			}

			// Token: 0x0600C2B5 RID: 49845 RVA: 0x0057EBE4 File Offset: 0x0057CDE4
			public static TonemappingColorGrading.CurvesSettings MDDBLMDKDAO()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.GCIOBPOFPOD(),
					red = TonemappingColorGrading.CurvesSettings.DDDDHCDNGPO(),
					green = TonemappingColorGrading.CurvesSettings.OFAJCIABHLN(),
					blue = TonemappingColorGrading.CurvesSettings.FPGMMGHBLLD()
				};
			}

			// Token: 0x0600C2B6 RID: 49846 RVA: 0x0057EC2C File Offset: 0x0057CE2C
			public static AnimationCurve FHBHEEKNHLI()
			{
				Keyframe[] array = new Keyframe[3];
				array[0] = new Keyframe(797f, 629f, 86f, 398f);
				array[0] = new Keyframe(1047f, 228f, 1958f, 1138f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600C2B7 RID: 49847 RVA: 0x0057EC84 File Offset: 0x0057CE84
			public static TonemappingColorGrading.CurvesSettings AJJOJJJCLGH()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.DDDDHCDNGPO(),
					red = TonemappingColorGrading.CurvesSettings.EACLGLFBCJG(),
					green = TonemappingColorGrading.CurvesSettings.GECNKHHIAEM(),
					blue = TonemappingColorGrading.CurvesSettings.PLEKCNKIIEO()
				};
			}

			// Token: 0x0600C2B8 RID: 49848 RVA: 0x0057ECCC File Offset: 0x0057CECC
			public static AnimationCurve JOMIFGCGPIK()
			{
				Keyframe[] array = new Keyframe[4];
				array[0] = new Keyframe(1561f, 1082f, 177f, 870f);
				array[0] = new Keyframe(33f, 1696f, 545f, 24f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600C2B9 RID: 49849 RVA: 0x0057ED24 File Offset: 0x0057CF24
			public static TonemappingColorGrading.CurvesSettings HMKDCFKBINK()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.OFAJCIABHLN(),
					red = TonemappingColorGrading.CurvesSettings.NJPKBBGAMNM(),
					green = TonemappingColorGrading.CurvesSettings.HKBFONAODCD(),
					blue = TonemappingColorGrading.CurvesSettings.APCEPAEGMFH()
				};
			}

			// Token: 0x0600C2BA RID: 49850 RVA: 0x0057ED6C File Offset: 0x0057CF6C
			public static AnimationCurve FPGMMGHBLLD()
			{
				Keyframe[] array = new Keyframe[]
				{
					default(Keyframe),
					new Keyframe(743f, 1364f, 454f, 1124f)
				};
				array[0] = new Keyframe(216f, 914f, 946f, 946f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600C2BB RID: 49851 RVA: 0x0057EDC4 File Offset: 0x0057CFC4
			public static AnimationCurve JPAJBEBBJEB()
			{
				Keyframe[] array = new Keyframe[8];
				array[1] = new Keyframe(1000f, 1582f, 1874f, 704f);
				array[1] = new Keyframe(209f, 717f, 55f, 1932f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600C2BC RID: 49852 RVA: 0x0057EE1C File Offset: 0x0057D01C
			public static TonemappingColorGrading.CurvesSettings BJNIBDPAHBP()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.defaultCurve,
					red = TonemappingColorGrading.CurvesSettings.CNGJDNNGAFN(),
					green = TonemappingColorGrading.CurvesSettings.JLMBBKNKIFM(),
					blue = TonemappingColorGrading.CurvesSettings.DDDDHCDNGPO()
				};
			}

			// Token: 0x0600C2BD RID: 49853 RVA: 0x0057EE64 File Offset: 0x0057D064
			public static TonemappingColorGrading.CurvesSettings IDCAEILAIPJ()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.KPEEJFEJKDN(),
					red = TonemappingColorGrading.CurvesSettings.HHIIDHAELBF(),
					green = TonemappingColorGrading.CurvesSettings.HMMCHDMNOAF(),
					blue = TonemappingColorGrading.CurvesSettings.NOPOINBNBKE()
				};
			}

			// Token: 0x0600C2BE RID: 49854 RVA: 0x0057EEAC File Offset: 0x0057D0AC
			public static TonemappingColorGrading.CurvesSettings NODFLPCLGKA()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.IFHGBGHOIMC(),
					red = TonemappingColorGrading.CurvesSettings.PBMNJHGCLKE(),
					green = TonemappingColorGrading.CurvesSettings.OFPDEGHGEOM(),
					blue = TonemappingColorGrading.CurvesSettings.defaultCurve
				};
			}

			// Token: 0x0600C2BF RID: 49855 RVA: 0x0057EEF4 File Offset: 0x0057D0F4
			public static TonemappingColorGrading.CurvesSettings OCIMBHLOOGC()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.GGNPKFFFGBG(),
					red = TonemappingColorGrading.CurvesSettings.OFAJCIABHLN(),
					green = TonemappingColorGrading.CurvesSettings.PLEKCNKIIEO(),
					blue = TonemappingColorGrading.CurvesSettings.KEHLDGCNHNF()
				};
			}

			// Token: 0x0600C2C0 RID: 49856 RVA: 0x0057EF3C File Offset: 0x0057D13C
			public static TonemappingColorGrading.CurvesSettings MEBNDNNHNMB()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.EOANJEJIJNI(),
					red = TonemappingColorGrading.CurvesSettings.GECNKHHIAEM(),
					green = TonemappingColorGrading.CurvesSettings.PMPNJBGFIOA(),
					blue = TonemappingColorGrading.CurvesSettings.APCEPAEGMFH()
				};
			}

			// Token: 0x0600C2C1 RID: 49857 RVA: 0x0057EF84 File Offset: 0x0057D184
			public static TonemappingColorGrading.CurvesSettings OOFOKHIDMDG()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.FPGMMGHBLLD(),
					red = TonemappingColorGrading.CurvesSettings.EMPDDCONMLA(),
					green = TonemappingColorGrading.CurvesSettings.KPLBEIOHIBD(),
					blue = TonemappingColorGrading.CurvesSettings.FHBHEEKNHLI()
				};
			}

			// Token: 0x0600C2C2 RID: 49858 RVA: 0x0057EFCC File Offset: 0x0057D1CC
			public static AnimationCurve DIEKJANFIAI()
			{
				Keyframe[] array = new Keyframe[5];
				array[1] = new Keyframe(1889f, 278f, 1120f, 446f);
				array[1] = new Keyframe(1689f, 1829f, 1825f, 434f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600C2C3 RID: 49859 RVA: 0x0057F024 File Offset: 0x0057D224
			public static AnimationCurve OFAJCIABHLN()
			{
				Keyframe[] array = new Keyframe[4];
				array[1] = new Keyframe(447f, 1654f, 806f, 1674f);
				array[0] = new Keyframe(1239f, 1859f, 454f, 440f);
				return new AnimationCurve(array);
			}

			// Token: 0x170002BF RID: 703
			// (get) Token: 0x0600C2C4 RID: 49860 RVA: 0x0057F07C File Offset: 0x0057D27C
			public static TonemappingColorGrading.CurvesSettings defaultSettings
			{
				get
				{
					return new TonemappingColorGrading.CurvesSettings
					{
						master = TonemappingColorGrading.CurvesSettings.defaultCurve,
						red = TonemappingColorGrading.CurvesSettings.defaultCurve,
						green = TonemappingColorGrading.CurvesSettings.defaultCurve,
						blue = TonemappingColorGrading.CurvesSettings.defaultCurve
					};
				}
			}

			// Token: 0x0600C2C5 RID: 49861 RVA: 0x0057F0C4 File Offset: 0x0057D2C4
			public static TonemappingColorGrading.CurvesSettings BFFANDBCLFI()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.DDDFNOLHENK(),
					red = TonemappingColorGrading.CurvesSettings.NBDJOMPAEMC(),
					green = TonemappingColorGrading.CurvesSettings.CNGJDNNGAFN(),
					blue = TonemappingColorGrading.CurvesSettings.MDNFAGHGKFB()
				};
			}

			// Token: 0x0600C2C6 RID: 49862 RVA: 0x0057F10C File Offset: 0x0057D30C
			public static TonemappingColorGrading.CurvesSettings ALMDBBDOPCB()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.PDPKGHEDMCA(),
					red = TonemappingColorGrading.CurvesSettings.GCIOBPOFPOD(),
					green = TonemappingColorGrading.CurvesSettings.FHBHEEKNHLI(),
					blue = TonemappingColorGrading.CurvesSettings.IJOKIBFOFEA()
				};
			}

			// Token: 0x0600C2C7 RID: 49863 RVA: 0x0057F154 File Offset: 0x0057D354
			public static AnimationCurve HKBFONAODCD()
			{
				Keyframe[] array = new Keyframe[3];
				array[0] = new Keyframe(1807f, 1211f, 1188f, 1638f);
				array[1] = new Keyframe(122f, 167f, 1460f, 1649f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600C2C8 RID: 49864 RVA: 0x0057F1AC File Offset: 0x0057D3AC
			public static TonemappingColorGrading.CurvesSettings HLLBKJENCLA()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.POKIFBIEOKP(),
					red = TonemappingColorGrading.CurvesSettings.KPEEJFEJKDN(),
					green = TonemappingColorGrading.CurvesSettings.OBMCIIAFAKB(),
					blue = TonemappingColorGrading.CurvesSettings.HEAOODNDIHJ()
				};
			}

			// Token: 0x170002C0 RID: 704
			// (get) Token: 0x0600C2C9 RID: 49865 RVA: 0x0057F1F4 File Offset: 0x0057D3F4
			public static AnimationCurve defaultCurve
			{
				get
				{
					return new AnimationCurve(new Keyframe[]
					{
						new Keyframe(0f, 0f, 1f, 1f),
						new Keyframe(1f, 1f, 1f, 1f)
					});
				}
			}

			// Token: 0x0600C2CA RID: 49866 RVA: 0x0057F24C File Offset: 0x0057D44C
			public static AnimationCurve DEMHLKBHBJE()
			{
				Keyframe[] array = new Keyframe[7];
				array[1] = new Keyframe(1659f, 1692f, 1689f, 630f);
				array[0] = new Keyframe(919f, 271f, 1387f, 1436f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600C2CB RID: 49867 RVA: 0x0057F2A4 File Offset: 0x0057D4A4
			public static TonemappingColorGrading.CurvesSettings NPDLLKNLGDF()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.KKJBOCGCBJM(),
					red = TonemappingColorGrading.CurvesSettings.IJOKIBFOFEA(),
					green = TonemappingColorGrading.CurvesSettings.defaultCurve,
					blue = TonemappingColorGrading.CurvesSettings.AJIFANCKOJN()
				};
			}

			// Token: 0x0600C2CC RID: 49868 RVA: 0x0057F2EC File Offset: 0x0057D4EC
			public static TonemappingColorGrading.CurvesSettings OOKKEMFPNBJ()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.PMPNJBGFIOA(),
					red = TonemappingColorGrading.CurvesSettings.FPGMMGHBLLD(),
					green = TonemappingColorGrading.CurvesSettings.CNGJDNNGAFN(),
					blue = TonemappingColorGrading.CurvesSettings.GECNKHHIAEM()
				};
			}

			// Token: 0x0600C2CD RID: 49869 RVA: 0x0057F334 File Offset: 0x0057D534
			public static AnimationCurve KJGLIIPECEH()
			{
				Keyframe[] array = new Keyframe[6];
				array[0] = new Keyframe(463f, 775f, 1088f, 663f);
				array[1] = new Keyframe(685f, 1684f, 163f, 836f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600C2CE RID: 49870 RVA: 0x0057F38C File Offset: 0x0057D58C
			public static AnimationCurve GCIOBPOFPOD()
			{
				Keyframe[] array = new Keyframe[0];
				array[1] = new Keyframe(526f, 591f, 33f, 62f);
				array[0] = new Keyframe(919f, 736f, 1469f, 1345f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600C2CF RID: 49871 RVA: 0x0057F3E4 File Offset: 0x0057D5E4
			public static AnimationCurve BABKKKNOBCC()
			{
				Keyframe[] array = new Keyframe[4];
				array[1] = new Keyframe(177f, 1323f, 1692f, 746f);
				array[0] = new Keyframe(1856f, 1659f, 396f, 739f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600C2D0 RID: 49872 RVA: 0x0057F43C File Offset: 0x0057D63C
			public static AnimationCurve OBMCIIAFAKB()
			{
				Keyframe[] array = new Keyframe[4];
				array[0] = new Keyframe(1623f, 1480f, 872f, 1765f);
				array[0] = new Keyframe(1170f, 1800f, 488f, 1797f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600C2D1 RID: 49873 RVA: 0x0057F494 File Offset: 0x0057D694
			public static AnimationCurve JLMBBKNKIFM()
			{
				Keyframe[] array = new Keyframe[6];
				array[1] = new Keyframe(1134f, 1220f, 1365f, 1047f);
				array[0] = new Keyframe(1045f, 103f, 213f, 242f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600C2D2 RID: 49874 RVA: 0x0057F4EC File Offset: 0x0057D6EC
			public static TonemappingColorGrading.CurvesSettings GDKPNHJPBKJ()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.DDDFNOLHENK(),
					red = TonemappingColorGrading.CurvesSettings.PLEKCNKIIEO(),
					green = TonemappingColorGrading.CurvesSettings.JPAJBEBBJEB(),
					blue = TonemappingColorGrading.CurvesSettings.DJKLJHOMHKA()
				};
			}

			// Token: 0x0600C2D3 RID: 49875 RVA: 0x0057F534 File Offset: 0x0057D734
			public static TonemappingColorGrading.CurvesSettings IKGKJHIFBKL()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.POKIFBIEOKP(),
					red = TonemappingColorGrading.CurvesSettings.HMMCHDMNOAF(),
					green = TonemappingColorGrading.CurvesSettings.NBDJOMPAEMC(),
					blue = TonemappingColorGrading.CurvesSettings.IDPKHHJNMNJ()
				};
			}

			// Token: 0x0600C2D4 RID: 49876 RVA: 0x0057F57C File Offset: 0x0057D77C
			public static AnimationCurve IDPKHHJNMNJ()
			{
				Keyframe[] array = new Keyframe[1];
				array[0] = new Keyframe(839f, 1952f, 1749f, 1847f);
				array[1] = new Keyframe(1990f, 335f, 1285f, 1488f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600C2D5 RID: 49877 RVA: 0x0057F5D4 File Offset: 0x0057D7D4
			public static AnimationCurve OFPDEGHGEOM()
			{
				Keyframe[] array = new Keyframe[8];
				array[1] = new Keyframe(486f, 1586f, 1224f, 1930f);
				array[0] = new Keyframe(65f, 1014f, 1460f, 7f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600C2D6 RID: 49878 RVA: 0x0057F62C File Offset: 0x0057D82C
			public static TonemappingColorGrading.CurvesSettings JDBFJOJBCFD()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.OFAJCIABHLN(),
					red = TonemappingColorGrading.CurvesSettings.KJGLIIPECEH(),
					green = TonemappingColorGrading.CurvesSettings.GGNPKFFFGBG(),
					blue = TonemappingColorGrading.CurvesSettings.GECNKHHIAEM()
				};
			}

			// Token: 0x0600C2D7 RID: 49879 RVA: 0x0057F674 File Offset: 0x0057D874
			public static AnimationCurve HEAOODNDIHJ()
			{
				Keyframe[] array = new Keyframe[6];
				array[1] = new Keyframe(1620f, 953f, 1283f, 1671f);
				array[0] = new Keyframe(1105f, 660f, 1687f, 331f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600C2D8 RID: 49880 RVA: 0x0057F6CC File Offset: 0x0057D8CC
			public static AnimationCurve KPLBEIOHIBD()
			{
				Keyframe[] array = new Keyframe[6];
				array[1] = new Keyframe(146f, 962f, 979f, 1524f);
				array[1] = new Keyframe(1402f, 1253f, 1876f, 811f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600C2D9 RID: 49881 RVA: 0x0057F724 File Offset: 0x0057D924
			public static AnimationCurve PNHDHLGANCO()
			{
				Keyframe[] array = new Keyframe[3];
				array[1] = new Keyframe(772f, 1288f, 1121f, 1200f);
				array[0] = new Keyframe(1679f, 15f, 1532f, 521f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600C2DA RID: 49882 RVA: 0x0057F77C File Offset: 0x0057D97C
			public static AnimationCurve EACLGLFBCJG()
			{
				Keyframe[] array = new Keyframe[1];
				array[1] = new Keyframe(1524f, 1730f, 903f, 506f);
				array[0] = new Keyframe(1061f, 1f, 1804f, 312f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600C2DB RID: 49883 RVA: 0x0057F7D4 File Offset: 0x0057D9D4
			public static AnimationCurve INIGHKIGMME()
			{
				Keyframe[] array = new Keyframe[]
				{
					default(Keyframe),
					new Keyframe(1593f, 1991f, 763f, 1288f)
				};
				array[1] = new Keyframe(1905f, 564f, 1685f, 1924f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600C2DC RID: 49884 RVA: 0x0057F82C File Offset: 0x0057DA2C
			public static AnimationCurve PLEKCNKIIEO()
			{
				Keyframe[] array = new Keyframe[]
				{
					default(Keyframe),
					new Keyframe(1102f, 787f, 990f, 972f)
				};
				array[0] = new Keyframe(1752f, 1088f, 1513f, 1915f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600C2DD RID: 49885 RVA: 0x0057F884 File Offset: 0x0057DA84
			public static AnimationCurve EMPDDCONMLA()
			{
				Keyframe[] array = new Keyframe[6];
				array[1] = new Keyframe(56f, 931f, 1396f, 590f);
				array[0] = new Keyframe(492f, 924f, 1671f, 1534f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600C2DE RID: 49886 RVA: 0x0057F8DC File Offset: 0x0057DADC
			public static TonemappingColorGrading.CurvesSettings DELLGIGMFLC()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.FPGMMGHBLLD(),
					red = TonemappingColorGrading.CurvesSettings.KPEEJFEJKDN(),
					green = TonemappingColorGrading.CurvesSettings.IFHGBGHOIMC(),
					blue = TonemappingColorGrading.CurvesSettings.MDNFAGHGKFB()
				};
			}

			// Token: 0x0600C2DF RID: 49887 RVA: 0x0057F924 File Offset: 0x0057DB24
			public static AnimationCurve APCEPAEGMFH()
			{
				Keyframe[] array = new Keyframe[0];
				array[1] = new Keyframe(669f, 1393f, 7f, 1131f);
				array[0] = new Keyframe(707f, 1326f, 781f, 1931f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600C2E0 RID: 49888 RVA: 0x0057F97C File Offset: 0x0057DB7C
			public static TonemappingColorGrading.CurvesSettings GDHOHBHNEKC()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.HEAOODNDIHJ(),
					red = TonemappingColorGrading.CurvesSettings.MDNFAGHGKFB(),
					green = TonemappingColorGrading.CurvesSettings.DDDDHCDNGPO(),
					blue = TonemappingColorGrading.CurvesSettings.OFPDEGHGEOM()
				};
			}

			// Token: 0x0600C2E1 RID: 49889 RVA: 0x0057F9C4 File Offset: 0x0057DBC4
			public static AnimationCurve DDDDHCDNGPO()
			{
				Keyframe[] array = new Keyframe[6];
				array[0] = new Keyframe(1187f, 1340f, 1657f, 1901f);
				array[0] = new Keyframe(247f, 1516f, 53f, 1138f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600C2E2 RID: 49890 RVA: 0x0057FA1C File Offset: 0x0057DC1C
			public static AnimationCurve EOANJEJIJNI()
			{
				Keyframe[] array = new Keyframe[4];
				array[1] = new Keyframe(1231f, 1284f, 1483f, 1575f);
				array[1] = new Keyframe(837f, 96f, 74f, 783f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600C2E3 RID: 49891 RVA: 0x0057FA74 File Offset: 0x0057DC74
			public static AnimationCurve KPEEJFEJKDN()
			{
				Keyframe[] array = new Keyframe[6];
				array[0] = new Keyframe(818f, 1742f, 227f, 421f);
				array[1] = new Keyframe(70f, 1755f, 469f, 1868f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600C2E4 RID: 49892 RVA: 0x0057FACC File Offset: 0x0057DCCC
			public static TonemappingColorGrading.CurvesSettings AMICIDJBDEI()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.KPEEJFEJKDN(),
					red = TonemappingColorGrading.CurvesSettings.AJIFANCKOJN(),
					green = TonemappingColorGrading.CurvesSettings.KEHLDGCNHNF(),
					blue = TonemappingColorGrading.CurvesSettings.HKBFONAODCD()
				};
			}

			// Token: 0x0600C2E5 RID: 49893 RVA: 0x0057FB14 File Offset: 0x0057DD14
			public static AnimationCurve PDPKGHEDMCA()
			{
				Keyframe[] array = new Keyframe[7];
				array[1] = new Keyframe(1003f, 1468f, 1541f, 961f);
				array[1] = new Keyframe(1873f, 990f, 1585f, 42f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600C2E6 RID: 49894 RVA: 0x0057FB6C File Offset: 0x0057DD6C
			public static TonemappingColorGrading.CurvesSettings HIPJDBACJDH()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.defaultCurve,
					red = TonemappingColorGrading.CurvesSettings.EOANJEJIJNI(),
					green = TonemappingColorGrading.CurvesSettings.KPLBEIOHIBD(),
					blue = TonemappingColorGrading.CurvesSettings.AJIFANCKOJN()
				};
			}

			// Token: 0x0600C2E7 RID: 49895 RVA: 0x0057FBB4 File Offset: 0x0057DDB4
			public static TonemappingColorGrading.CurvesSettings BNGFNAFFAME()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.GECNKHHIAEM(),
					red = TonemappingColorGrading.CurvesSettings.FHBHEEKNHLI(),
					green = TonemappingColorGrading.CurvesSettings.KEHLDGCNHNF(),
					blue = TonemappingColorGrading.CurvesSettings.JOMIFGCGPIK()
				};
			}

			// Token: 0x0600C2E8 RID: 49896 RVA: 0x0057FBFC File Offset: 0x0057DDFC
			public static AnimationCurve KKJBOCGCBJM()
			{
				Keyframe[] array = new Keyframe[6];
				array[0] = new Keyframe(1872f, 19f, 1140f, 277f);
				array[0] = new Keyframe(95f, 1434f, 388f, 539f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600C2E9 RID: 49897 RVA: 0x0057FC54 File Offset: 0x0057DE54
			public static TonemappingColorGrading.CurvesSettings MEFEDCEEAMK()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.PMPNJBGFIOA(),
					red = TonemappingColorGrading.CurvesSettings.JPAJBEBBJEB(),
					green = TonemappingColorGrading.CurvesSettings.PDPKGHEDMCA(),
					blue = TonemappingColorGrading.CurvesSettings.EBGGCGCPJHA()
				};
			}

			// Token: 0x0600C2EA RID: 49898 RVA: 0x0057FC9C File Offset: 0x0057DE9C
			public static TonemappingColorGrading.CurvesSettings BNKCOLOGEFJ()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.GGNPKFFFGBG(),
					red = TonemappingColorGrading.CurvesSettings.IDPKHHJNMNJ(),
					green = TonemappingColorGrading.CurvesSettings.OFAJCIABHLN(),
					blue = TonemappingColorGrading.CurvesSettings.GGNPKFFFGBG()
				};
			}

			// Token: 0x0600C2EB RID: 49899 RVA: 0x0057FCE4 File Offset: 0x0057DEE4
			public static TonemappingColorGrading.CurvesSettings DHCNIDFOOPO()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.BABKKKNOBCC(),
					red = TonemappingColorGrading.CurvesSettings.DDDFNOLHENK(),
					green = TonemappingColorGrading.CurvesSettings.KEHLDGCNHNF(),
					blue = TonemappingColorGrading.CurvesSettings.INIGHKIGMME()
				};
			}

			// Token: 0x0600C2EC RID: 49900 RVA: 0x0057FD2C File Offset: 0x0057DF2C
			public static AnimationCurve GECNKHHIAEM()
			{
				Keyframe[] array = new Keyframe[7];
				array[1] = new Keyframe(1138f, 1141f, 1079f, 441f);
				array[0] = new Keyframe(1157f, 604f, 671f, 583f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600C2ED RID: 49901 RVA: 0x0057FD84 File Offset: 0x0057DF84
			public static AnimationCurve MDNFAGHGKFB()
			{
				Keyframe[] array = new Keyframe[7];
				array[0] = new Keyframe(1079f, 652f, 1590f, 429f);
				array[0] = new Keyframe(1398f, 686f, 10f, 907f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600C2EE RID: 49902 RVA: 0x0057FDDC File Offset: 0x0057DFDC
			public static TonemappingColorGrading.CurvesSettings NEMOOKPFBOA()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.DDDDHCDNGPO(),
					red = TonemappingColorGrading.CurvesSettings.DDDDHCDNGPO(),
					green = TonemappingColorGrading.CurvesSettings.NBDJOMPAEMC(),
					blue = TonemappingColorGrading.CurvesSettings.defaultCurve
				};
			}

			// Token: 0x0600C2EF RID: 49903 RVA: 0x0057FE24 File Offset: 0x0057E024
			public static AnimationCurve IFHGBGHOIMC()
			{
				Keyframe[] array = new Keyframe[5];
				array[1] = new Keyframe(1142f, 1236f, 1099f, 959f);
				array[1] = new Keyframe(1020f, 1037f, 1898f, 1531f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600C2F0 RID: 49904 RVA: 0x0057FE7C File Offset: 0x0057E07C
			public static TonemappingColorGrading.CurvesSettings MDGIIBPIGJC()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.EBGGCGCPJHA(),
					red = TonemappingColorGrading.CurvesSettings.KJGLIIPECEH(),
					green = TonemappingColorGrading.CurvesSettings.PBMNJHGCLKE(),
					blue = TonemappingColorGrading.CurvesSettings.OFPDEGHGEOM()
				};
			}

			// Token: 0x0600C2F1 RID: 49905 RVA: 0x0057FEC4 File Offset: 0x0057E0C4
			public static AnimationCurve AJIFANCKOJN()
			{
				Keyframe[] array = new Keyframe[7];
				array[1] = new Keyframe(1636f, 1209f, 182f, 801f);
				array[0] = new Keyframe(311f, 1859f, 1419f, 1875f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600C2F2 RID: 49906 RVA: 0x0057FF1C File Offset: 0x0057E11C
			public static AnimationCurve NBDJOMPAEMC()
			{
				Keyframe[] array = new Keyframe[5];
				array[1] = new Keyframe(1389f, 1555f, 94f, 1605f);
				array[1] = new Keyframe(796f, 1691f, 675f, 733f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600C2F3 RID: 49907 RVA: 0x0057FF74 File Offset: 0x0057E174
			public static TonemappingColorGrading.CurvesSettings HLEINNLIKBB()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.HEAOODNDIHJ(),
					red = TonemappingColorGrading.CurvesSettings.DDDDHCDNGPO(),
					green = TonemappingColorGrading.CurvesSettings.AJIFANCKOJN(),
					blue = TonemappingColorGrading.CurvesSettings.NAPHKFNLAAM()
				};
			}

			// Token: 0x0600C2F4 RID: 49908 RVA: 0x0057FFBC File Offset: 0x0057E1BC
			public static AnimationCurve DJKLJHOMHKA()
			{
				Keyframe[] array = new Keyframe[8];
				array[0] = new Keyframe(597f, 401f, 1425f, 698f);
				array[1] = new Keyframe(806f, 209f, 285f, 1398f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600C2F5 RID: 49909 RVA: 0x00580014 File Offset: 0x0057E214
			public static TonemappingColorGrading.CurvesSettings NPEIGPHIHFP()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.CNGJDNNGAFN(),
					red = TonemappingColorGrading.CurvesSettings.PBMNJHGCLKE(),
					green = TonemappingColorGrading.CurvesSettings.MDNFAGHGKFB(),
					blue = TonemappingColorGrading.CurvesSettings.AJIFANCKOJN()
				};
			}

			// Token: 0x0600C2F6 RID: 49910 RVA: 0x0058005C File Offset: 0x0057E25C
			public static AnimationCurve NJPKBBGAMNM()
			{
				Keyframe[] array = new Keyframe[]
				{
					default(Keyframe),
					new Keyframe(1689f, 1863f, 1113f, 1142f)
				};
				array[0] = new Keyframe(681f, 4f, 1461f, 81f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600C2F7 RID: 49911 RVA: 0x005800B4 File Offset: 0x0057E2B4
			public static TonemappingColorGrading.CurvesSettings MJEFHCONFNF()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.PLEKCNKIIEO(),
					red = TonemappingColorGrading.CurvesSettings.PDPKGHEDMCA(),
					green = TonemappingColorGrading.CurvesSettings.CNGJDNNGAFN(),
					blue = TonemappingColorGrading.CurvesSettings.OFAJCIABHLN()
				};
			}

			// Token: 0x0600C2F8 RID: 49912 RVA: 0x005800FC File Offset: 0x0057E2FC
			public static AnimationCurve MLFEMGEDGEB()
			{
				Keyframe[] array = new Keyframe[1];
				array[1] = new Keyframe(1461f, 214f, 1049f, 727f);
				array[0] = new Keyframe(1275f, 1000f, 1830f, 1120f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600C2F9 RID: 49913 RVA: 0x00580154 File Offset: 0x0057E354
			public static AnimationCurve IJOKIBFOFEA()
			{
				Keyframe[] array = new Keyframe[7];
				array[1] = new Keyframe(1388f, 601f, 321f, 1929f);
				array[0] = new Keyframe(888f, 515f, 1341f, 1948f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600C2FA RID: 49914 RVA: 0x005801AC File Offset: 0x0057E3AC
			public static AnimationCurve GGNPKFFFGBG()
			{
				Keyframe[] array = new Keyframe[8];
				array[0] = new Keyframe(1055f, 994f, 840f, 1426f);
				array[0] = new Keyframe(1586f, 516f, 1979f, 1109f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600C2FB RID: 49915 RVA: 0x00580204 File Offset: 0x0057E404
			public static TonemappingColorGrading.CurvesSettings FBBLPICJODA()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.IFHGBGHOIMC(),
					red = TonemappingColorGrading.CurvesSettings.DJKLJHOMHKA(),
					green = TonemappingColorGrading.CurvesSettings.DEMHLKBHBJE(),
					blue = TonemappingColorGrading.CurvesSettings.NAPHKFNLAAM()
				};
			}

			// Token: 0x0600C2FC RID: 49916 RVA: 0x0058024C File Offset: 0x0057E44C
			public static TonemappingColorGrading.CurvesSettings NNNMNENCOBC()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.DDDFNOLHENK(),
					red = TonemappingColorGrading.CurvesSettings.JLMBBKNKIFM(),
					green = TonemappingColorGrading.CurvesSettings.NOPOINBNBKE(),
					blue = TonemappingColorGrading.CurvesSettings.IFHGBGHOIMC()
				};
			}

			// Token: 0x0600C2FD RID: 49917 RVA: 0x00580294 File Offset: 0x0057E494
			public static TonemappingColorGrading.CurvesSettings INKODAPMHLP()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.JPAJBEBBJEB(),
					red = TonemappingColorGrading.CurvesSettings.CNGJDNNGAFN(),
					green = TonemappingColorGrading.CurvesSettings.IJOKIBFOFEA(),
					blue = TonemappingColorGrading.CurvesSettings.DIEKJANFIAI()
				};
			}

			// Token: 0x0600C2FE RID: 49918 RVA: 0x005802DC File Offset: 0x0057E4DC
			public static AnimationCurve POKIFBIEOKP()
			{
				Keyframe[] array = new Keyframe[]
				{
					new Keyframe(1525f, 1315f, 1786f, 1433f)
				};
				array[0] = new Keyframe(1044f, 1516f, 599f, 552f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600C2FF RID: 49919 RVA: 0x00580334 File Offset: 0x0057E534
			public static AnimationCurve DDDFNOLHENK()
			{
				Keyframe[] array = new Keyframe[4];
				array[1] = new Keyframe(1778f, 1210f, 1520f, 1214f);
				array[1] = new Keyframe(600f, 696f, 1687f, 369f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600C300 RID: 49920 RVA: 0x0058038C File Offset: 0x0057E58C
			public static TonemappingColorGrading.CurvesSettings ADKHPGONPMP()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.DIEKJANFIAI(),
					red = TonemappingColorGrading.CurvesSettings.FPGMMGHBLLD(),
					green = TonemappingColorGrading.CurvesSettings.KJGLIIPECEH(),
					blue = TonemappingColorGrading.CurvesSettings.POKIFBIEOKP()
				};
			}

			// Token: 0x0600C301 RID: 49921 RVA: 0x005803D4 File Offset: 0x0057E5D4
			public static TonemappingColorGrading.CurvesSettings JACPKLDIIKG()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.PMPNJBGFIOA(),
					red = TonemappingColorGrading.CurvesSettings.DIEKJANFIAI(),
					green = TonemappingColorGrading.CurvesSettings.FPGMMGHBLLD(),
					blue = TonemappingColorGrading.CurvesSettings.MLFEMGEDGEB()
				};
			}

			// Token: 0x0600C302 RID: 49922 RVA: 0x0058041C File Offset: 0x0057E61C
			public static AnimationCurve HMMCHDMNOAF()
			{
				Keyframe[] array = new Keyframe[]
				{
					default(Keyframe),
					new Keyframe(1130f, 1248f, 1896f, 1539f)
				};
				array[0] = new Keyframe(1372f, 984f, 876f, 1835f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600C303 RID: 49923 RVA: 0x00580474 File Offset: 0x0057E674
			public static TonemappingColorGrading.CurvesSettings MDDFLLOCDEA()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.FPGMMGHBLLD(),
					red = TonemappingColorGrading.CurvesSettings.HEAOODNDIHJ(),
					green = TonemappingColorGrading.CurvesSettings.DJKLJHOMHKA(),
					blue = TonemappingColorGrading.CurvesSettings.DIEKJANFIAI()
				};
			}

			// Token: 0x0600C304 RID: 49924 RVA: 0x005804BC File Offset: 0x0057E6BC
			public static TonemappingColorGrading.CurvesSettings LOGLBPGEHEC()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.defaultCurve,
					red = TonemappingColorGrading.CurvesSettings.KPLBEIOHIBD(),
					green = TonemappingColorGrading.CurvesSettings.DIEKJANFIAI(),
					blue = TonemappingColorGrading.CurvesSettings.IFHGBGHOIMC()
				};
			}

			// Token: 0x0600C305 RID: 49925 RVA: 0x00580504 File Offset: 0x0057E704
			public static TonemappingColorGrading.CurvesSettings JGNKGPFJFHO()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.GCIOBPOFPOD(),
					red = TonemappingColorGrading.CurvesSettings.MLFEMGEDGEB(),
					green = TonemappingColorGrading.CurvesSettings.PNHDHLGANCO(),
					blue = TonemappingColorGrading.CurvesSettings.KKJBOCGCBJM()
				};
			}

			// Token: 0x0600C306 RID: 49926 RVA: 0x0058054C File Offset: 0x0057E74C
			public static TonemappingColorGrading.CurvesSettings OJDPMKFEMDH()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.PLEKCNKIIEO(),
					red = TonemappingColorGrading.CurvesSettings.NJPKBBGAMNM(),
					green = TonemappingColorGrading.CurvesSettings.KEHLDGCNHNF(),
					blue = TonemappingColorGrading.CurvesSettings.JLMBBKNKIFM()
				};
			}

			// Token: 0x0600C307 RID: 49927 RVA: 0x00580594 File Offset: 0x0057E794
			public static AnimationCurve HHIIDHAELBF()
			{
				Keyframe[] array = new Keyframe[7];
				array[0] = new Keyframe(629f, 398f, 966f, 1836f);
				array[1] = new Keyframe(851f, 162f, 1714f, 756f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600C308 RID: 49928 RVA: 0x005805EC File Offset: 0x0057E7EC
			public static AnimationCurve EBGGCGCPJHA()
			{
				Keyframe[] array = new Keyframe[]
				{
					default(Keyframe),
					new Keyframe(1445f, 1961f, 1944f, 1089f)
				};
				array[1] = new Keyframe(371f, 1578f, 1108f, 1372f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600C309 RID: 49929 RVA: 0x00580644 File Offset: 0x0057E844
			public static AnimationCurve NOPOINBNBKE()
			{
				Keyframe[] array = new Keyframe[7];
				array[0] = new Keyframe(1646f, 401f, 1853f, 1428f);
				array[1] = new Keyframe(258f, 1768f, 873f, 793f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600C30A RID: 49930 RVA: 0x0058069C File Offset: 0x0057E89C
			public static AnimationCurve NAPHKFNLAAM()
			{
				Keyframe[] array = new Keyframe[0];
				array[1] = new Keyframe(1121f, 1833f, 1267f, 384f);
				array[1] = new Keyframe(1609f, 757f, 490f, 972f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600C30B RID: 49931 RVA: 0x005806F4 File Offset: 0x0057E8F4
			public static AnimationCurve KEHLDGCNHNF()
			{
				Keyframe[] array = new Keyframe[]
				{
					new Keyframe(123f, 970f, 733f, 900f)
				};
				array[0] = new Keyframe(1766f, 1254f, 25f, 645f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600C30C RID: 49932 RVA: 0x0058074C File Offset: 0x0057E94C
			public static AnimationCurve PMPNJBGFIOA()
			{
				Keyframe[] array = new Keyframe[]
				{
					default(Keyframe),
					new Keyframe(1807f, 1204f, 1645f, 1718f)
				};
				array[1] = new Keyframe(1195f, 1203f, 1244f, 0f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600C30D RID: 49933 RVA: 0x005807A4 File Offset: 0x0057E9A4
			public static TonemappingColorGrading.CurvesSettings KAMGKLMFGKB()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.DDDFNOLHENK(),
					red = TonemappingColorGrading.CurvesSettings.EMPDDCONMLA(),
					green = TonemappingColorGrading.CurvesSettings.EOANJEJIJNI(),
					blue = TonemappingColorGrading.CurvesSettings.DEMHLKBHBJE()
				};
			}

			// Token: 0x0600C30E RID: 49934 RVA: 0x005807EC File Offset: 0x0057E9EC
			public static TonemappingColorGrading.CurvesSettings ONOHCMFHKHG()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.HHIIDHAELBF(),
					red = TonemappingColorGrading.CurvesSettings.JPAJBEBBJEB(),
					green = TonemappingColorGrading.CurvesSettings.OBMCIIAFAKB(),
					blue = TonemappingColorGrading.CurvesSettings.NOPOINBNBKE()
				};
			}

			// Token: 0x0600C30F RID: 49935 RVA: 0x00580834 File Offset: 0x0057EA34
			public static AnimationCurve CNGJDNNGAFN()
			{
				Keyframe[] array = new Keyframe[4];
				array[1] = new Keyframe(798f, 155f, 679f, 176f);
				array[1] = new Keyframe(1561f, 1853f, 1310f, 302f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600C310 RID: 49936 RVA: 0x0058088C File Offset: 0x0057EA8C
			public static TonemappingColorGrading.CurvesSettings DICKGIEMDON()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.BABKKKNOBCC(),
					red = TonemappingColorGrading.CurvesSettings.HKBFONAODCD(),
					green = TonemappingColorGrading.CurvesSettings.APCEPAEGMFH(),
					blue = TonemappingColorGrading.CurvesSettings.PNHDHLGANCO()
				};
			}

			// Token: 0x0600C311 RID: 49937 RVA: 0x005808D4 File Offset: 0x0057EAD4
			public static TonemappingColorGrading.CurvesSettings IDEMMJOJCIN()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.POKIFBIEOKP(),
					red = TonemappingColorGrading.CurvesSettings.KJGLIIPECEH(),
					green = TonemappingColorGrading.CurvesSettings.HMMCHDMNOAF(),
					blue = TonemappingColorGrading.CurvesSettings.NAPHKFNLAAM()
				};
			}

			// Token: 0x0600C312 RID: 49938 RVA: 0x0058091C File Offset: 0x0057EB1C
			public static AnimationCurve PBMNJHGCLKE()
			{
				Keyframe[] array = new Keyframe[6];
				array[1] = new Keyframe(1857f, 176f, 243f, 1868f);
				array[1] = new Keyframe(1344f, 553f, 1618f, 1501f);
				return new AnimationCurve(array);
			}

			// Token: 0x040019EE RID: 6638
			[TonemappingColorGrading.AEFJFKCDILC]
			public AnimationCurve master;

			// Token: 0x040019EF RID: 6639
			[TonemappingColorGrading.AEFJFKCDILC(1f, 0f, 0f, 1f)]
			public AnimationCurve red;

			// Token: 0x040019F0 RID: 6640
			[TonemappingColorGrading.AEFJFKCDILC(0f, 1f, 0f, 1f)]
			public AnimationCurve green;

			// Token: 0x040019F1 RID: 6641
			[TonemappingColorGrading.AEFJFKCDILC(0f, 1f, 1f, 1f)]
			public AnimationCurve blue;
		}

		// Token: 0x02000380 RID: 896
		public enum DKLDGPONDOK
		{
			// Token: 0x040019F3 RID: 6643
			Normal = 16,
			// Token: 0x040019F4 RID: 6644
			High = 32
		}

		// Token: 0x02000381 RID: 897
		[Serializable]
		public struct ColorGradingSettings
		{
			// Token: 0x0600C313 RID: 49939 RVA: 0x00580974 File Offset: 0x0057EB74
			public static TonemappingColorGrading.ColorGradingSettings JIIODGEMCMH()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = false,
					useDithering = false,
					showDebug = false,
					precision = (TonemappingColorGrading.DKLDGPONDOK)18,
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.OOFOKHIDMDG(),
					basics = TonemappingColorGrading.BasicsSettings.HMDLEIJHKEP(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.HMDLEIJHKEP(),
					curves = TonemappingColorGrading.CurvesSettings.MJEFHCONFNF()
				};
			}

			// Token: 0x0600C314 RID: 49940 RVA: 0x005809DB File Offset: 0x0057EBDB
			internal void IIJKCHEMPFA()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.OCIMBHLOOGC();
			}

			// Token: 0x0600C315 RID: 49941 RVA: 0x005809E8 File Offset: 0x0057EBE8
			public static TonemappingColorGrading.ColorGradingSettings OAMPGBKMKFF()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = true,
					useDithering = false,
					showDebug = true,
					precision = (TonemappingColorGrading.DKLDGPONDOK)72,
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.NJJBBDIFPKH(),
					basics = TonemappingColorGrading.BasicsSettings.HLLBKJENCLA(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.NPEIGPHIHFP(),
					curves = TonemappingColorGrading.CurvesSettings.JACPKLDIIKG()
				};
			}

			// Token: 0x0600C316 RID: 49942 RVA: 0x00580A50 File Offset: 0x0057EC50
			public static TonemappingColorGrading.ColorGradingSettings BJNIBDPAHBP()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = true,
					useDithering = true,
					showDebug = false,
					precision = (TonemappingColorGrading.DKLDGPONDOK)75,
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.MDGIIBPIGJC(),
					basics = TonemappingColorGrading.BasicsSettings.HLLBKJENCLA(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.IGIKNGLDPJB(),
					curves = TonemappingColorGrading.CurvesSettings.BFFANDBCLFI()
				};
			}

			// Token: 0x0600C317 RID: 49943 RVA: 0x00580AB8 File Offset: 0x0057ECB8
			public static TonemappingColorGrading.ColorGradingSettings COINKHKLJAP()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = true,
					useDithering = true,
					showDebug = true,
					precision = (TonemappingColorGrading.DKLDGPONDOK)66,
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.FBBLPICJODA(),
					basics = TonemappingColorGrading.BasicsSettings.PIAJOHPDMNA(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.MDGIIBPIGJC(),
					curves = TonemappingColorGrading.CurvesSettings.ALMDBBDOPCB()
				};
			}

			// Token: 0x0600C318 RID: 49944 RVA: 0x005809DB File Offset: 0x0057EBDB
			internal void GFALEDNPNOE()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.OCIMBHLOOGC();
			}

			// Token: 0x0600C319 RID: 49945 RVA: 0x00580B20 File Offset: 0x0057ED20
			public static TonemappingColorGrading.ColorGradingSettings JACPKLDIIKG()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = true,
					useDithering = true,
					showDebug = true,
					precision = (TonemappingColorGrading.DKLDGPONDOK)(-64),
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.CGGMKBADCBM(),
					basics = TonemappingColorGrading.BasicsSettings.JPGMEJNEOCC(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.DELLGIGMFLC(),
					curves = TonemappingColorGrading.CurvesSettings.OOKKEMFPNBJ()
				};
			}

			// Token: 0x0600C31A RID: 49946 RVA: 0x00580B88 File Offset: 0x0057ED88
			public static TonemappingColorGrading.ColorGradingSettings DCMDLNNCGAC()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = true,
					useDithering = false,
					showDebug = true,
					precision = (TonemappingColorGrading.DKLDGPONDOK)56,
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.NJJBBDIFPKH(),
					basics = TonemappingColorGrading.BasicsSettings.GDKPNHJPBKJ(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.MJLLLKFIDOE(),
					curves = TonemappingColorGrading.CurvesSettings.MJEFHCONFNF()
				};
			}

			// Token: 0x0600C31B RID: 49947 RVA: 0x00580BEF File Offset: 0x0057EDEF
			internal void GILDHGIMLPM()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.AJJOJJJCLGH();
			}

			// Token: 0x0600C31C RID: 49948 RVA: 0x00580BFC File Offset: 0x0057EDFC
			public static TonemappingColorGrading.ColorGradingSettings HKALOCNBEKG()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = true,
					useDithering = true,
					showDebug = true,
					precision = (TonemappingColorGrading.DKLDGPONDOK)117,
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.MEFEDCEEAMK(),
					basics = TonemappingColorGrading.BasicsSettings.MDDBLMDKDAO(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.HMDLEIJHKEP(),
					curves = TonemappingColorGrading.CurvesSettings.BNGFNAFFAME()
				};
			}

			// Token: 0x0600C31D RID: 49949 RVA: 0x00580C63 File Offset: 0x0057EE63
			internal void DHIOMPGHKJP()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.ALMDBBDOPCB();
			}

			// Token: 0x0600C31E RID: 49950 RVA: 0x00580C70 File Offset: 0x0057EE70
			internal void DJCPMHMDJEN()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.JDBFJOJBCFD();
			}

			// Token: 0x0600C31F RID: 49951 RVA: 0x00580C7D File Offset: 0x0057EE7D
			internal void MPJJBFNIHPK()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.DELLGIGMFLC();
			}

			// Token: 0x0600C320 RID: 49952 RVA: 0x00580C8C File Offset: 0x0057EE8C
			public static TonemappingColorGrading.ColorGradingSettings JGNKGPFJFHO()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = false,
					useDithering = false,
					showDebug = false,
					precision = (TonemappingColorGrading.DKLDGPONDOK)29,
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.IGIKNGLDPJB(),
					basics = TonemappingColorGrading.BasicsSettings.NJJBBDIFPKH(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.FMLMIDJIEOP(),
					curves = TonemappingColorGrading.CurvesSettings.OOKKEMFPNBJ()
				};
			}

			// Token: 0x0600C321 RID: 49953 RVA: 0x00580CF3 File Offset: 0x0057EEF3
			internal void ILJHIGJEPCA()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.AMICIDJBDEI();
			}

			// Token: 0x0600C322 RID: 49954 RVA: 0x00580D00 File Offset: 0x0057EF00
			internal void DLPCDAIHLKP()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.OJDPMKFEMDH();
			}

			// Token: 0x0600C323 RID: 49955 RVA: 0x00580D0D File Offset: 0x0057EF0D
			internal void FKOENKDEHPB()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.JACPKLDIIKG();
			}

			// Token: 0x0600C324 RID: 49956 RVA: 0x00580D1A File Offset: 0x0057EF1A
			internal void JIPMONJNBOK()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.defaultSettings;
			}

			// Token: 0x0600C325 RID: 49957 RVA: 0x00580D27 File Offset: 0x0057EF27
			internal void MLOPPPBPHNJ()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.IDEMMJOJCIN();
			}

			// Token: 0x0600C326 RID: 49958 RVA: 0x00580D34 File Offset: 0x0057EF34
			internal void MMOGADAOALK()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.DICKGIEMDON();
			}

			// Token: 0x0600C327 RID: 49959 RVA: 0x00580D41 File Offset: 0x0057EF41
			internal void NBILAGJFBGJ()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.JGNKGPFJFHO();
			}

			// Token: 0x0600C328 RID: 49960 RVA: 0x00580D27 File Offset: 0x0057EF27
			internal void LPMNAMDNDDM()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.IDEMMJOJCIN();
			}

			// Token: 0x0600C329 RID: 49961 RVA: 0x00580D50 File Offset: 0x0057EF50
			public static TonemappingColorGrading.ColorGradingSettings MKEJGGFNILJ()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = false,
					useDithering = false,
					showDebug = false,
					precision = (TonemappingColorGrading.DKLDGPONDOK)12,
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.NLCHLENDMLI(),
					basics = TonemappingColorGrading.BasicsSettings.defaultSettings,
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.NLCHLENDMLI(),
					curves = TonemappingColorGrading.CurvesSettings.HLEINNLIKBB()
				};
			}

			// Token: 0x0600C32A RID: 49962 RVA: 0x00580DB8 File Offset: 0x0057EFB8
			public static TonemappingColorGrading.ColorGradingSettings ONOHCMFHKHG()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = false,
					useDithering = false,
					showDebug = false,
					precision = (TonemappingColorGrading.DKLDGPONDOK)(-19),
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.defaultSettings,
					basics = TonemappingColorGrading.BasicsSettings.GDKPNHJPBKJ(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.HLLBKJENCLA(),
					curves = TonemappingColorGrading.CurvesSettings.GDHOHBHNEKC()
				};
			}

			// Token: 0x0600C32B RID: 49963 RVA: 0x00580E20 File Offset: 0x0057F020
			public static TonemappingColorGrading.ColorGradingSettings DBGPLELNOMP()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = false,
					useDithering = true,
					showDebug = false,
					precision = (TonemappingColorGrading.DKLDGPONDOK)19,
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.MEFEDCEEAMK(),
					basics = TonemappingColorGrading.BasicsSettings.FBBLPICJODA(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.MDGIIBPIGJC(),
					curves = TonemappingColorGrading.CurvesSettings.ALMDBBDOPCB()
				};
			}

			// Token: 0x0600C32C RID: 49964 RVA: 0x00580E88 File Offset: 0x0057F088
			public static TonemappingColorGrading.ColorGradingSettings MDDBLMDKDAO()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = false,
					useDithering = true,
					showDebug = true,
					precision = (TonemappingColorGrading.DKLDGPONDOK)69,
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.HLLBKJENCLA(),
					basics = TonemappingColorGrading.BasicsSettings.MKEJGGFNILJ(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.MDGIIBPIGJC(),
					curves = TonemappingColorGrading.CurvesSettings.AJJOJJJCLGH()
				};
			}

			// Token: 0x0600C32D RID: 49965 RVA: 0x00580EF0 File Offset: 0x0057F0F0
			public static TonemappingColorGrading.ColorGradingSettings DHCNIDFOOPO()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = false,
					useDithering = false,
					showDebug = false,
					precision = (TonemappingColorGrading.DKLDGPONDOK)(-21),
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.NLCHLENDMLI(),
					basics = TonemappingColorGrading.BasicsSettings.MEFEDCEEAMK(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.FMLMIDJIEOP(),
					curves = TonemappingColorGrading.CurvesSettings.JDBFJOJBCFD()
				};
			}

			// Token: 0x0600C32E RID: 49966 RVA: 0x00580F57 File Offset: 0x0057F157
			internal void ENMHDCFMLMD()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.GDHOHBHNEKC();
			}

			// Token: 0x0600C32F RID: 49967 RVA: 0x00580F64 File Offset: 0x0057F164
			internal void NLOBKGBLNPO()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.IDCAEILAIPJ();
			}

			// Token: 0x0600C330 RID: 49968 RVA: 0x00580F74 File Offset: 0x0057F174
			public static TonemappingColorGrading.ColorGradingSettings OOKKEMFPNBJ()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = true,
					useDithering = false,
					showDebug = false,
					precision = (TonemappingColorGrading.DKLDGPONDOK)(-60),
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.NLCHLENDMLI(),
					basics = TonemappingColorGrading.BasicsSettings.MEFEDCEEAMK(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.PIAJOHPDMNA(),
					curves = TonemappingColorGrading.CurvesSettings.MDGIIBPIGJC()
				};
			}

			// Token: 0x0600C331 RID: 49969 RVA: 0x00580FDC File Offset: 0x0057F1DC
			public static TonemappingColorGrading.ColorGradingSettings JPGMEJNEOCC()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = false,
					useDithering = true,
					showDebug = true,
					precision = (TonemappingColorGrading.DKLDGPONDOK)60,
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.MJLLLKFIDOE(),
					basics = TonemappingColorGrading.BasicsSettings.IGIKNGLDPJB(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.OCIMBHLOOGC(),
					curves = TonemappingColorGrading.CurvesSettings.ADKHPGONPMP()
				};
			}

			// Token: 0x0600C332 RID: 49970 RVA: 0x00581044 File Offset: 0x0057F244
			public static TonemappingColorGrading.ColorGradingSettings KIEDLNGCIJC()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = true,
					useDithering = true,
					showDebug = true,
					precision = (TonemappingColorGrading.DKLDGPONDOK)(-48),
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.GDKPNHJPBKJ(),
					basics = TonemappingColorGrading.BasicsSettings.MKEJGGFNILJ(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.IGIKNGLDPJB(),
					curves = TonemappingColorGrading.CurvesSettings.NNNMNENCOBC()
				};
			}

			// Token: 0x0600C333 RID: 49971 RVA: 0x005810AC File Offset: 0x0057F2AC
			public static TonemappingColorGrading.ColorGradingSettings HMDLEIJHKEP()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = false,
					useDithering = true,
					showDebug = true,
					precision = (TonemappingColorGrading.DKLDGPONDOK)24,
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.GDKPNHJPBKJ(),
					basics = TonemappingColorGrading.BasicsSettings.MDDFLLOCDEA(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.BNGFNAFFAME(),
					curves = TonemappingColorGrading.CurvesSettings.ONOHCMFHKHG()
				};
			}

			// Token: 0x0600C334 RID: 49972 RVA: 0x00581113 File Offset: 0x0057F313
			internal void KHLFNAKOLAC()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.HLEINNLIKBB();
			}

			// Token: 0x0600C335 RID: 49973 RVA: 0x00581120 File Offset: 0x0057F320
			public static TonemappingColorGrading.ColorGradingSettings AAPKKAPOLKH()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = true,
					useDithering = false,
					showDebug = true,
					precision = (TonemappingColorGrading.DKLDGPONDOK)26,
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.defaultSettings,
					basics = TonemappingColorGrading.BasicsSettings.PIAJOHPDMNA(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.MDGIIBPIGJC(),
					curves = TonemappingColorGrading.CurvesSettings.JACPKLDIIKG()
				};
			}

			// Token: 0x170002C1 RID: 705
			// (get) Token: 0x0600C336 RID: 49974 RVA: 0x00581188 File Offset: 0x0057F388
			public static TonemappingColorGrading.ColorGradingSettings defaultSettings
			{
				get
				{
					return new TonemappingColorGrading.ColorGradingSettings
					{
						enabled = false,
						useDithering = false,
						showDebug = false,
						precision = TonemappingColorGrading.DKLDGPONDOK.Normal,
						colorWheels = TonemappingColorGrading.ColorWheelsSettings.defaultSettings,
						basics = TonemappingColorGrading.BasicsSettings.defaultSettings,
						channelMixer = TonemappingColorGrading.ChannelMixerSettings.defaultSettings,
						curves = TonemappingColorGrading.CurvesSettings.defaultSettings
					};
				}
			}

			// Token: 0x0600C337 RID: 49975 RVA: 0x005811F0 File Offset: 0x0057F3F0
			public static TonemappingColorGrading.ColorGradingSettings OOFOKHIDMDG()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = true,
					useDithering = true,
					showDebug = true,
					precision = (TonemappingColorGrading.DKLDGPONDOK)(-112),
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.GDKPNHJPBKJ(),
					basics = TonemappingColorGrading.BasicsSettings.MEFEDCEEAMK(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.NPEIGPHIHFP(),
					curves = TonemappingColorGrading.CurvesSettings.HIPJDBACJDH()
				};
			}

			// Token: 0x0600C338 RID: 49976 RVA: 0x00581258 File Offset: 0x0057F458
			public static TonemappingColorGrading.ColorGradingSettings PIAJOHPDMNA()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = true,
					useDithering = true,
					showDebug = false,
					precision = (TonemappingColorGrading.DKLDGPONDOK)(-81),
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.HMDLEIJHKEP(),
					basics = TonemappingColorGrading.BasicsSettings.CGGMKBADCBM(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.HMDLEIJHKEP(),
					curves = TonemappingColorGrading.CurvesSettings.NEMOOKPFBOA()
				};
			}

			// Token: 0x0600C339 RID: 49977 RVA: 0x005812C0 File Offset: 0x0057F4C0
			public static TonemappingColorGrading.ColorGradingSettings MGIIIBAJNIE()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = true,
					useDithering = true,
					showDebug = true,
					precision = (TonemappingColorGrading.DKLDGPONDOK)(-83),
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.FBBLPICJODA(),
					basics = TonemappingColorGrading.BasicsSettings.defaultSettings,
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.MDDBLMDKDAO(),
					curves = TonemappingColorGrading.CurvesSettings.KAMGKLMFGKB()
				};
			}

			// Token: 0x0600C33A RID: 49978 RVA: 0x00581328 File Offset: 0x0057F528
			public static TonemappingColorGrading.ColorGradingSettings JJMHFAELDJK()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = false,
					useDithering = false,
					showDebug = true,
					precision = (TonemappingColorGrading.DKLDGPONDOK)(-23),
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.CGGMKBADCBM(),
					basics = TonemappingColorGrading.BasicsSettings.AAPKKAPOLKH(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.DELLGIGMFLC(),
					curves = TonemappingColorGrading.CurvesSettings.AJJOJJJCLGH()
				};
			}

			// Token: 0x0600C33B RID: 49979 RVA: 0x00581390 File Offset: 0x0057F590
			public static TonemappingColorGrading.ColorGradingSettings HIPJDBACJDH()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = false,
					useDithering = false,
					showDebug = true,
					precision = (TonemappingColorGrading.DKLDGPONDOK)103,
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.JPGMEJNEOCC(),
					basics = TonemappingColorGrading.BasicsSettings.OOKKEMFPNBJ(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.DHCNIDFOOPO(),
					curves = TonemappingColorGrading.CurvesSettings.OOKKEMFPNBJ()
				};
			}

			// Token: 0x0600C33C RID: 49980 RVA: 0x005813F8 File Offset: 0x0057F5F8
			public static TonemappingColorGrading.ColorGradingSettings BNGFNAFFAME()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = false,
					useDithering = false,
					showDebug = true,
					precision = (TonemappingColorGrading.DKLDGPONDOK)6,
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.MJLLLKFIDOE(),
					basics = TonemappingColorGrading.BasicsSettings.MKEJGGFNILJ(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.PIAJOHPDMNA(),
					curves = TonemappingColorGrading.CurvesSettings.IKGKJHIFBKL()
				};
			}

			// Token: 0x0600C33D RID: 49981 RVA: 0x00581460 File Offset: 0x0057F660
			public static TonemappingColorGrading.ColorGradingSettings HLLBKJENCLA()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = false,
					useDithering = true,
					showDebug = false,
					precision = (TonemappingColorGrading.DKLDGPONDOK)(-58),
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.MDDFLLOCDEA(),
					basics = TonemappingColorGrading.BasicsSettings.MJLLLKFIDOE(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.LNGBMOGJKGD(),
					curves = TonemappingColorGrading.CurvesSettings.MDDBLMDKDAO()
				};
			}

			// Token: 0x0600C33E RID: 49982 RVA: 0x005814C8 File Offset: 0x0057F6C8
			public static TonemappingColorGrading.ColorGradingSettings ILFHFFCIBPJ()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = true,
					useDithering = true,
					showDebug = false,
					precision = (TonemappingColorGrading.DKLDGPONDOK)(-117),
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.CGGMKBADCBM(),
					basics = TonemappingColorGrading.BasicsSettings.MEFEDCEEAMK(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.ILFHFFCIBPJ(),
					curves = TonemappingColorGrading.CurvesSettings.NODFLPCLGKA()
				};
			}

			// Token: 0x0600C33F RID: 49983 RVA: 0x00581530 File Offset: 0x0057F730
			public static TonemappingColorGrading.ColorGradingSettings IGIKNGLDPJB()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = true,
					useDithering = true,
					showDebug = false,
					precision = (TonemappingColorGrading.DKLDGPONDOK)(-69),
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.OOFOKHIDMDG(),
					basics = TonemappingColorGrading.BasicsSettings.MJLLLKFIDOE(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.PIAJOHPDMNA(),
					curves = TonemappingColorGrading.CurvesSettings.OOFOKHIDMDG()
				};
			}

			// Token: 0x0600C340 RID: 49984 RVA: 0x00581597 File Offset: 0x0057F797
			internal void NJJOPILNLJN()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.BFFANDBCLFI();
			}

			// Token: 0x0600C341 RID: 49985 RVA: 0x005815A4 File Offset: 0x0057F7A4
			internal void AOGCKHNAOCI()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.MDDBLMDKDAO();
			}

			// Token: 0x0600C342 RID: 49986 RVA: 0x005815B4 File Offset: 0x0057F7B4
			public static TonemappingColorGrading.ColorGradingSettings BFFANDBCLFI()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = true,
					useDithering = false,
					showDebug = true,
					precision = (TonemappingColorGrading.DKLDGPONDOK)(-72),
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.FBBLPICJODA(),
					basics = TonemappingColorGrading.BasicsSettings.PIAJOHPDMNA(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.JPGMEJNEOCC(),
					curves = TonemappingColorGrading.CurvesSettings.JACPKLDIIKG()
				};
			}

			// Token: 0x0600C343 RID: 49987 RVA: 0x0058161C File Offset: 0x0057F81C
			public static TonemappingColorGrading.ColorGradingSettings NLCHLENDMLI()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = true,
					useDithering = false,
					showDebug = true,
					precision = (TonemappingColorGrading.DKLDGPONDOK)(-51),
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.MEFEDCEEAMK(),
					basics = TonemappingColorGrading.BasicsSettings.MJLLLKFIDOE(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.AAPKKAPOLKH(),
					curves = TonemappingColorGrading.CurvesSettings.ADKHPGONPMP()
				};
			}

			// Token: 0x0600C344 RID: 49988 RVA: 0x00580D1A File Offset: 0x0057EF1A
			internal void Reset()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.defaultSettings;
			}

			// Token: 0x0600C345 RID: 49989 RVA: 0x00581684 File Offset: 0x0057F884
			public static TonemappingColorGrading.ColorGradingSettings DICKGIEMDON()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = true,
					useDithering = true,
					showDebug = false,
					precision = (TonemappingColorGrading.DKLDGPONDOK)(-112),
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.HLLBKJENCLA(),
					basics = TonemappingColorGrading.BasicsSettings.OOFOKHIDMDG(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.FBBLPICJODA(),
					curves = TonemappingColorGrading.CurvesSettings.JGNKGPFJFHO()
				};
			}

			// Token: 0x0600C346 RID: 49990 RVA: 0x00580C70 File Offset: 0x0057EE70
			internal void PNFPFNADEJF()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.JDBFJOJBCFD();
			}

			// Token: 0x0600C347 RID: 49991 RVA: 0x005816EC File Offset: 0x0057F8EC
			public static TonemappingColorGrading.ColorGradingSettings ADJNPGFJGJI()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = true,
					useDithering = false,
					showDebug = false,
					precision = (TonemappingColorGrading.DKLDGPONDOK)(-67),
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.MDGIIBPIGJC(),
					basics = TonemappingColorGrading.BasicsSettings.CGGMKBADCBM(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.OOFOKHIDMDG(),
					curves = TonemappingColorGrading.CurvesSettings.defaultSettings
				};
			}

			// Token: 0x0600C348 RID: 49992 RVA: 0x00581754 File Offset: 0x0057F954
			public static TonemappingColorGrading.ColorGradingSettings GDHOHBHNEKC()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = false,
					useDithering = true,
					showDebug = false,
					precision = (TonemappingColorGrading.DKLDGPONDOK)23,
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.HMDLEIJHKEP(),
					basics = TonemappingColorGrading.BasicsSettings.MDDBLMDKDAO(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.HMDLEIJHKEP(),
					curves = TonemappingColorGrading.CurvesSettings.DICKGIEMDON()
				};
			}

			// Token: 0x0600C349 RID: 49993 RVA: 0x005817BC File Offset: 0x0057F9BC
			public static TonemappingColorGrading.ColorGradingSettings LNGBMOGJKGD()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = false,
					useDithering = true,
					showDebug = false,
					precision = (TonemappingColorGrading.DKLDGPONDOK)(-70),
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.GDKPNHJPBKJ(),
					basics = TonemappingColorGrading.BasicsSettings.OCIMBHLOOGC(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.OOFOKHIDMDG(),
					curves = TonemappingColorGrading.CurvesSettings.FBBLPICJODA()
				};
			}

			// Token: 0x0600C34A RID: 49994 RVA: 0x00581823 File Offset: 0x0057FA23
			internal void BPBHECJMLPN()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.MJEFHCONFNF();
			}

			// Token: 0x0600C34B RID: 49995 RVA: 0x00581830 File Offset: 0x0057FA30
			public static TonemappingColorGrading.ColorGradingSettings MDGIIBPIGJC()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = true,
					useDithering = true,
					showDebug = false,
					precision = (TonemappingColorGrading.DKLDGPONDOK)(-115),
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.JPGMEJNEOCC(),
					basics = TonemappingColorGrading.BasicsSettings.GDKPNHJPBKJ(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.BNGFNAFFAME(),
					curves = TonemappingColorGrading.CurvesSettings.NODFLPCLGKA()
				};
			}

			// Token: 0x0600C34C RID: 49996 RVA: 0x00581897 File Offset: 0x0057FA97
			internal void GIAJGPDKGHE()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.IKGKJHIFBKL();
			}

			// Token: 0x0600C34D RID: 49997 RVA: 0x005818A4 File Offset: 0x0057FAA4
			public static TonemappingColorGrading.ColorGradingSettings BNKCOLOGEFJ()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = false,
					useDithering = true,
					showDebug = true,
					precision = (TonemappingColorGrading.DKLDGPONDOK)116,
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.HMDLEIJHKEP(),
					basics = TonemappingColorGrading.BasicsSettings.JPGMEJNEOCC(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.MJLLLKFIDOE(),
					curves = TonemappingColorGrading.CurvesSettings.OCIMBHLOOGC()
				};
			}

			// Token: 0x0600C34E RID: 49998 RVA: 0x0058190C File Offset: 0x0057FB0C
			public static TonemappingColorGrading.ColorGradingSettings FLPFAGHMGNN()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = true,
					useDithering = true,
					showDebug = false,
					precision = (TonemappingColorGrading.DKLDGPONDOK)120,
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.NLCHLENDMLI(),
					basics = TonemappingColorGrading.BasicsSettings.MDDFLLOCDEA(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.HMDLEIJHKEP(),
					curves = TonemappingColorGrading.CurvesSettings.DHCNIDFOOPO()
				};
			}

			// Token: 0x0600C34F RID: 49999 RVA: 0x00581974 File Offset: 0x0057FB74
			public static TonemappingColorGrading.ColorGradingSettings ELPHMKAEDHE()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = true,
					useDithering = true,
					showDebug = false,
					precision = (TonemappingColorGrading.DKLDGPONDOK)65,
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.MDDFLLOCDEA(),
					basics = TonemappingColorGrading.BasicsSettings.defaultSettings,
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.NLCHLENDMLI(),
					curves = TonemappingColorGrading.CurvesSettings.BNGFNAFFAME()
				};
			}

			// Token: 0x0600C350 RID: 50000 RVA: 0x005815A4 File Offset: 0x0057F7A4
			internal void ENJPJEMDHAF()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.MDDBLMDKDAO();
			}

			// Token: 0x0600C351 RID: 50001 RVA: 0x00580F57 File Offset: 0x0057F157
			internal void NKJANLHLHIP()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.GDHOHBHNEKC();
			}

			// Token: 0x0600C352 RID: 50002 RVA: 0x005819DC File Offset: 0x0057FBDC
			public static TonemappingColorGrading.ColorGradingSettings MCLJECOKBEJ()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = false,
					useDithering = false,
					showDebug = false,
					precision = (TonemappingColorGrading.DKLDGPONDOK)(-100),
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.COINKHKLJAP(),
					basics = TonemappingColorGrading.BasicsSettings.OOKKEMFPNBJ(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.HMDLEIJHKEP(),
					curves = TonemappingColorGrading.CurvesSettings.OJDPMKFEMDH()
				};
			}

			// Token: 0x0600C353 RID: 50003 RVA: 0x00581A44 File Offset: 0x0057FC44
			public static TonemappingColorGrading.ColorGradingSettings CJPPPOJJGEE()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = false,
					useDithering = true,
					showDebug = false,
					precision = (TonemappingColorGrading.DKLDGPONDOK)50,
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.NJJBBDIFPKH(),
					basics = TonemappingColorGrading.BasicsSettings.MKEJGGFNILJ(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.OCIMBHLOOGC(),
					curves = TonemappingColorGrading.CurvesSettings.LOGLBPGEHEC()
				};
			}

			// Token: 0x0600C354 RID: 50004 RVA: 0x00581AAB File Offset: 0x0057FCAB
			internal void KAKCPAJHCPN()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.MEFEDCEEAMK();
			}

			// Token: 0x0600C355 RID: 50005 RVA: 0x00581AB8 File Offset: 0x0057FCB8
			internal void CPAHJGBADMP()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.NEMOOKPFBOA();
			}

			// Token: 0x0600C356 RID: 50006 RVA: 0x00580D27 File Offset: 0x0057EF27
			internal void CKMGOPHCHGA()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.IDEMMJOJCIN();
			}

			// Token: 0x0600C357 RID: 50007 RVA: 0x00581AC5 File Offset: 0x0057FCC5
			internal void OBKHJLEFJCD()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.OOKKEMFPNBJ();
			}

			// Token: 0x040019F5 RID: 6645
			public bool enabled;

			// Token: 0x040019F6 RID: 6646
			[Tooltip("Internal LUT precision. \"Normal\" is 256x16, \"High\" is 1024x32. Prefer \"Normal\" on mobile devices.")]
			public TonemappingColorGrading.DKLDGPONDOK precision;

			// Token: 0x040019F7 RID: 6647
			[Space]
			[TonemappingColorGrading.FNNMFBANGKA]
			public TonemappingColorGrading.ColorWheelsSettings colorWheels;

			// Token: 0x040019F8 RID: 6648
			[Space]
			[TonemappingColorGrading.JNPBOPHGFLI]
			public TonemappingColorGrading.BasicsSettings basics;

			// Token: 0x040019F9 RID: 6649
			[Space]
			[TonemappingColorGrading.ILAIGKLALGN]
			public TonemappingColorGrading.ChannelMixerSettings channelMixer;

			// Token: 0x040019FA RID: 6650
			[Space]
			[TonemappingColorGrading.JNPBOPHGFLI]
			public TonemappingColorGrading.CurvesSettings curves;

			// Token: 0x040019FB RID: 6651
			[Tooltip("Use dithering to try and minimize color banding in dark areas.")]
			[Space]
			public bool useDithering;

			// Token: 0x040019FC RID: 6652
			[Tooltip("Displays the generated LUT in the top left corner of the GameView.")]
			public bool showDebug;
		}

		// Token: 0x02000382 RID: 898
		private enum DFANALHDEBM
		{
			// Token: 0x040019FE RID: 6654
			LutGen,
			// Token: 0x040019FF RID: 6655
			AdaptationLog,
			// Token: 0x04001A00 RID: 6656
			AdaptationExpBlend,
			// Token: 0x04001A01 RID: 6657
			AdaptationExp,
			// Token: 0x04001A02 RID: 6658
			TonemappingOff,
			// Token: 0x04001A03 RID: 6659
			TonemappingACES,
			// Token: 0x04001A04 RID: 6660
			TonemappingCurve,
			// Token: 0x04001A05 RID: 6661
			TonemappingHable,
			// Token: 0x04001A06 RID: 6662
			TonemappingHejlDawson,
			// Token: 0x04001A07 RID: 6663
			TonemappingPhotographic,
			// Token: 0x04001A08 RID: 6664
			TonemappingReinhard,
			// Token: 0x04001A09 RID: 6665
			TonemappingNeutral,
			// Token: 0x04001A0A RID: 6666
			AdaptationDebug
		}
	}
}
