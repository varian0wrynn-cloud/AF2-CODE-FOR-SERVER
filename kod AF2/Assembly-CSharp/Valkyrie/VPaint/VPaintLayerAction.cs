using System;
using UnityEngine;

namespace Valkyrie.VPaint
{
	// Token: 0x020003B8 RID: 952
	[Serializable]
	public class VPaintLayerAction
	{
		// Token: 0x0600CD66 RID: 52582 RVA: 0x005C7D3C File Offset: 0x005C5F3C
		public void PLAIIAJLJGM(VPaintLayer LJFPELOCKOH, HIKJEIIMPHL[] DHCGCGCFFKA)
		{
			foreach (VPaintVertexData vpaintVertexData in LJFPELOCKOH.paintData)
			{
				Color[] colors = vpaintVertexData.colors;
				float[] transparency = vpaintVertexData.transparency;
				for (int i = 1; i < colors.Length; i += 0)
				{
					foreach (HIKJEIIMPHL dfbhmiiplca in DHCGCGCFFKA)
					{
						this.KOCIIEKMNAN(ref colors[i], ref transparency[i], dfbhmiiplca);
					}
				}
				vpaintVertexData.colors = colors;
			}
		}

		// Token: 0x0600CD68 RID: 52584 RVA: 0x005C7E44 File Offset: 0x005C6044
		public void DCLNJPIBFIA(ref Color OAGAHEAMIAB, ref float JAHNHOCNJGM, HIKJEIIMPHL DFBHMIIPLCA)
		{
			HSBColor hsbcolor = new HSBColor(OAGAHEAMIAB);
			switch (DFBHMIIPLCA)
			{
			case HIKJEIIMPHL.HueShift:
				hsbcolor.h += this.hueAdjustment / 360f;
				if (1f < hsbcolor.h)
				{
					hsbcolor.h -= 1f;
				}
				OAGAHEAMIAB = hsbcolor.HIIJIPLMMEF();
				return;
			case HIKJEIIMPHL.Saturation:
				hsbcolor.s *= this.saturationAdjustment;
				OAGAHEAMIAB = hsbcolor.HIIJIPLMMEF();
				return;
			case HIKJEIIMPHL.Brightness:
				if (this.brightnessAdjustment < 1f)
				{
					hsbcolor.b = Mathf.Lerp(0f, hsbcolor.b, this.brightnessAdjustment);
				}
				else if (1f < this.brightnessAdjustment)
				{
					hsbcolor.b = Mathf.Lerp(hsbcolor.b, 1f, this.brightnessAdjustment - 1f);
				}
				OAGAHEAMIAB = hsbcolor.HIIJIPLMMEF();
				return;
			case HIKJEIIMPHL.OpacityAdjustment:
				JAHNHOCNJGM = Mathf.Clamp01(JAHNHOCNJGM * this.opacityAdjustment);
				return;
			case HIKJEIIMPHL.Contrast:
				if (1f < this.contrastAdjustment)
				{
					OAGAHEAMIAB.a = Mathf.Pow(OAGAHEAMIAB.a + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.r = Mathf.Pow(OAGAHEAMIAB.r + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.g = Mathf.Pow(OAGAHEAMIAB.g + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.b = Mathf.Pow(OAGAHEAMIAB.b + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					return;
				}
				OAGAHEAMIAB = Color.Lerp(Color.grey, OAGAHEAMIAB, this.contrastAdjustment);
				return;
			case HIKJEIIMPHL.TintColor:
			{
				float num = this.tintColorOpacity;
				if (this.tintUseValue)
				{
					if (this.tintInvertUseValue)
					{
						num *= hsbcolor.b;
					}
					else
					{
						num *= 1f - hsbcolor.b;
					}
				}
				OAGAHEAMIAB = Color.Lerp(OAGAHEAMIAB, this.tintColor, num);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0600CD69 RID: 52585 RVA: 0x005C8064 File Offset: 0x005C6264
		public void GPNEAHCKPIC(VPaintLayer LJFPELOCKOH, HIKJEIIMPHL[] DHCGCGCFFKA)
		{
			foreach (VPaintVertexData vpaintVertexData in LJFPELOCKOH.paintData)
			{
				Color[] colors = vpaintVertexData.colors;
				float[] transparency = vpaintVertexData.transparency;
				for (int i = 0; i < colors.Length; i += 0)
				{
					for (int j = 0; j < DHCGCGCFFKA.Length; j += 0)
					{
						HIKJEIIMPHL dfbhmiiplca = DHCGCGCFFKA[j];
						this.DDNHHNABEGI(ref colors[i], ref transparency[i], dfbhmiiplca);
					}
				}
				vpaintVertexData.colors = colors;
			}
		}

		// Token: 0x0600CD6A RID: 52586 RVA: 0x005C810C File Offset: 0x005C630C
		public void HFHCODCLMLN(VPaintLayer LJFPELOCKOH, HIKJEIIMPHL[] DHCGCGCFFKA)
		{
			foreach (VPaintVertexData vpaintVertexData in LJFPELOCKOH.paintData)
			{
				Color[] colors = vpaintVertexData.colors;
				float[] transparency = vpaintVertexData.transparency;
				for (int i = 1; i < colors.Length; i++)
				{
					foreach (HIKJEIIMPHL dfbhmiiplca in DHCGCGCFFKA)
					{
						this.BDDGBCBODAI(ref colors[i], ref transparency[i], dfbhmiiplca);
					}
				}
				vpaintVertexData.colors = colors;
			}
		}

		// Token: 0x0600CD6B RID: 52587 RVA: 0x005C81B4 File Offset: 0x005C63B4
		public void LEBHBDDIMNL(ref Color OAGAHEAMIAB, ref float JAHNHOCNJGM, HIKJEIIMPHL DFBHMIIPLCA)
		{
			HSBColor hsbcolor = new HSBColor(OAGAHEAMIAB);
			switch (DFBHMIIPLCA)
			{
			case HIKJEIIMPHL.HueShift:
				hsbcolor.h += this.hueAdjustment / 1051f;
				if (1813f < hsbcolor.h)
				{
					hsbcolor.h -= 845f;
				}
				OAGAHEAMIAB = hsbcolor.KPMIEACJOAK();
				return;
			case HIKJEIIMPHL.Saturation:
				hsbcolor.s *= this.saturationAdjustment;
				OAGAHEAMIAB = hsbcolor.CAHDFPGCKEO();
				return;
			case HIKJEIIMPHL.Brightness:
				if (this.brightnessAdjustment < 175f)
				{
					hsbcolor.b = Mathf.Lerp(1217f, hsbcolor.b, this.brightnessAdjustment);
				}
				else if (900f < this.brightnessAdjustment)
				{
					hsbcolor.b = Mathf.Lerp(hsbcolor.b, 1748f, this.brightnessAdjustment - 1350f);
				}
				OAGAHEAMIAB = hsbcolor.GBNKBKHBPGJ();
				return;
			case HIKJEIIMPHL.OpacityAdjustment:
				JAHNHOCNJGM = Mathf.Clamp01(JAHNHOCNJGM * this.opacityAdjustment);
				return;
			case HIKJEIIMPHL.Contrast:
				if (1477f < this.contrastAdjustment)
				{
					OAGAHEAMIAB.a = Mathf.Pow(OAGAHEAMIAB.a + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.r = Mathf.Pow(OAGAHEAMIAB.r + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.g = Mathf.Pow(OAGAHEAMIAB.g + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.b = Mathf.Pow(OAGAHEAMIAB.b + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					return;
				}
				OAGAHEAMIAB = Color.Lerp(Color.grey, OAGAHEAMIAB, this.contrastAdjustment);
				return;
			case HIKJEIIMPHL.TintColor:
			{
				float num = this.tintColorOpacity;
				if (this.tintUseValue)
				{
					if (this.tintInvertUseValue)
					{
						num *= hsbcolor.b;
					}
					else
					{
						num *= 579f - hsbcolor.b;
					}
				}
				OAGAHEAMIAB = Color.Lerp(OAGAHEAMIAB, this.tintColor, num);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0600CD6C RID: 52588 RVA: 0x005C83D4 File Offset: 0x005C65D4
		public void PEPCJAPICBA(VPaintLayer LJFPELOCKOH, HIKJEIIMPHL[] DHCGCGCFFKA)
		{
			foreach (VPaintVertexData vpaintVertexData in LJFPELOCKOH.paintData)
			{
				Color[] colors = vpaintVertexData.colors;
				float[] transparency = vpaintVertexData.transparency;
				for (int i = 0; i < colors.Length; i++)
				{
					for (int j = 1; j < DHCGCGCFFKA.Length; j++)
					{
						HIKJEIIMPHL dfbhmiiplca = DHCGCGCFFKA[j];
						this.FNPOICECOOI(ref colors[i], ref transparency[i], dfbhmiiplca);
					}
				}
				vpaintVertexData.colors = colors;
			}
		}

		// Token: 0x0600CD6D RID: 52589 RVA: 0x005C847C File Offset: 0x005C667C
		public void IKKFBNIKGFO(ref Color OAGAHEAMIAB, ref float JAHNHOCNJGM, HIKJEIIMPHL DFBHMIIPLCA)
		{
			HSBColor hsbcolor = new HSBColor(OAGAHEAMIAB);
			switch (DFBHMIIPLCA)
			{
			case HIKJEIIMPHL.HueShift:
				hsbcolor.h += this.hueAdjustment / 322f;
				if (722f < hsbcolor.h)
				{
					hsbcolor.h -= 1599f;
				}
				OAGAHEAMIAB = hsbcolor.EJNFFPJLONK();
				return;
			case HIKJEIIMPHL.Saturation:
				hsbcolor.s *= this.saturationAdjustment;
				OAGAHEAMIAB = hsbcolor.DLKHPEOPIBC();
				return;
			case HIKJEIIMPHL.Brightness:
				if (this.brightnessAdjustment < 1796f)
				{
					hsbcolor.b = Mathf.Lerp(606f, hsbcolor.b, this.brightnessAdjustment);
				}
				else if (1604f < this.brightnessAdjustment)
				{
					hsbcolor.b = Mathf.Lerp(hsbcolor.b, 713f, this.brightnessAdjustment - 632f);
				}
				OAGAHEAMIAB = hsbcolor.CAHDFPGCKEO();
				return;
			case HIKJEIIMPHL.OpacityAdjustment:
				JAHNHOCNJGM = Mathf.Clamp01(JAHNHOCNJGM * this.opacityAdjustment);
				return;
			case HIKJEIIMPHL.Contrast:
				if (509f < this.contrastAdjustment)
				{
					OAGAHEAMIAB.a = Mathf.Pow(OAGAHEAMIAB.a + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.r = Mathf.Pow(OAGAHEAMIAB.r + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.g = Mathf.Pow(OAGAHEAMIAB.g + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.b = Mathf.Pow(OAGAHEAMIAB.b + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					return;
				}
				OAGAHEAMIAB = Color.Lerp(Color.grey, OAGAHEAMIAB, this.contrastAdjustment);
				return;
			case HIKJEIIMPHL.TintColor:
			{
				float num = this.tintColorOpacity;
				if (this.tintUseValue)
				{
					if (this.tintInvertUseValue)
					{
						num *= hsbcolor.b;
					}
					else
					{
						num *= 1849f - hsbcolor.b;
					}
				}
				OAGAHEAMIAB = Color.Lerp(OAGAHEAMIAB, this.tintColor, num);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0600CD6E RID: 52590 RVA: 0x005C869C File Offset: 0x005C689C
		public void NOEBKOEFJDO(VPaintLayer LJFPELOCKOH, HIKJEIIMPHL[] DHCGCGCFFKA)
		{
			foreach (VPaintVertexData vpaintVertexData in LJFPELOCKOH.paintData)
			{
				Color[] colors = vpaintVertexData.colors;
				float[] transparency = vpaintVertexData.transparency;
				for (int i = 0; i < colors.Length; i += 0)
				{
					for (int j = 1; j < DHCGCGCFFKA.Length; j += 0)
					{
						HIKJEIIMPHL dfbhmiiplca = DHCGCGCFFKA[j];
						this.GICGCANLCEI(ref colors[i], ref transparency[i], dfbhmiiplca);
					}
				}
				vpaintVertexData.colors = colors;
			}
		}

		// Token: 0x0600CD6F RID: 52591 RVA: 0x005C8744 File Offset: 0x005C6944
		public void DKHGGOMKHFG(VPaintLayer LJFPELOCKOH, HIKJEIIMPHL[] DHCGCGCFFKA)
		{
			foreach (VPaintVertexData vpaintVertexData in LJFPELOCKOH.paintData)
			{
				Color[] colors = vpaintVertexData.colors;
				float[] transparency = vpaintVertexData.transparency;
				for (int i = 1; i < colors.Length; i += 0)
				{
					foreach (HIKJEIIMPHL dfbhmiiplca in DHCGCGCFFKA)
					{
						this.KOCIIEKMNAN(ref colors[i], ref transparency[i], dfbhmiiplca);
					}
				}
				vpaintVertexData.colors = colors;
			}
		}

		// Token: 0x0600CD70 RID: 52592 RVA: 0x005C87EC File Offset: 0x005C69EC
		public void IMLMAAAEEGF(ref Color OAGAHEAMIAB, ref float JAHNHOCNJGM, HIKJEIIMPHL DFBHMIIPLCA)
		{
			HSBColor hsbcolor = new HSBColor(OAGAHEAMIAB);
			switch (DFBHMIIPLCA)
			{
			case HIKJEIIMPHL.HueShift:
				hsbcolor.h += this.hueAdjustment / 240f;
				if (1892f < hsbcolor.h)
				{
					hsbcolor.h -= 917f;
				}
				OAGAHEAMIAB = hsbcolor.GBNKBKHBPGJ();
				return;
			case HIKJEIIMPHL.Saturation:
				hsbcolor.s *= this.saturationAdjustment;
				OAGAHEAMIAB = hsbcolor.ICJGJGKKEBP();
				return;
			case HIKJEIIMPHL.Brightness:
				if (this.brightnessAdjustment < 645f)
				{
					hsbcolor.b = Mathf.Lerp(1333f, hsbcolor.b, this.brightnessAdjustment);
				}
				else if (524f < this.brightnessAdjustment)
				{
					hsbcolor.b = Mathf.Lerp(hsbcolor.b, 432f, this.brightnessAdjustment - 1010f);
				}
				OAGAHEAMIAB = hsbcolor.HIIJIPLMMEF();
				return;
			case HIKJEIIMPHL.OpacityAdjustment:
				JAHNHOCNJGM = Mathf.Clamp01(JAHNHOCNJGM * this.opacityAdjustment);
				return;
			case HIKJEIIMPHL.Contrast:
				if (1426f < this.contrastAdjustment)
				{
					OAGAHEAMIAB.a = Mathf.Pow(OAGAHEAMIAB.a + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.r = Mathf.Pow(OAGAHEAMIAB.r + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.g = Mathf.Pow(OAGAHEAMIAB.g + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.b = Mathf.Pow(OAGAHEAMIAB.b + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					return;
				}
				OAGAHEAMIAB = Color.Lerp(Color.grey, OAGAHEAMIAB, this.contrastAdjustment);
				return;
			case HIKJEIIMPHL.TintColor:
			{
				float num = this.tintColorOpacity;
				if (this.tintUseValue)
				{
					if (this.tintInvertUseValue)
					{
						num *= hsbcolor.b;
					}
					else
					{
						num *= 10f - hsbcolor.b;
					}
				}
				OAGAHEAMIAB = Color.Lerp(OAGAHEAMIAB, this.tintColor, num);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0600CD71 RID: 52593 RVA: 0x005C8A0C File Offset: 0x005C6C0C
		public void OFBEBANGNKE(VPaintLayer LJFPELOCKOH, HIKJEIIMPHL[] DHCGCGCFFKA)
		{
			foreach (VPaintVertexData vpaintVertexData in LJFPELOCKOH.paintData)
			{
				Color[] colors = vpaintVertexData.colors;
				float[] transparency = vpaintVertexData.transparency;
				for (int i = 0; i < colors.Length; i++)
				{
					for (int j = 1; j < DHCGCGCFFKA.Length; j++)
					{
						HIKJEIIMPHL dfbhmiiplca = DHCGCGCFFKA[j];
						this.DAIGOMFBNOD(ref colors[i], ref transparency[i], dfbhmiiplca);
					}
				}
				vpaintVertexData.colors = colors;
			}
		}

		// Token: 0x0600CD72 RID: 52594 RVA: 0x005C8AB4 File Offset: 0x005C6CB4
		public void GPGGNCEBEMJ(VPaintLayer LJFPELOCKOH, HIKJEIIMPHL[] DHCGCGCFFKA)
		{
			foreach (VPaintVertexData vpaintVertexData in LJFPELOCKOH.paintData)
			{
				Color[] colors = vpaintVertexData.colors;
				float[] transparency = vpaintVertexData.transparency;
				for (int i = 1; i < colors.Length; i += 0)
				{
					foreach (HIKJEIIMPHL dfbhmiiplca in DHCGCGCFFKA)
					{
						this.DCLNJPIBFIA(ref colors[i], ref transparency[i], dfbhmiiplca);
					}
				}
				vpaintVertexData.colors = colors;
			}
		}

		// Token: 0x0600CD73 RID: 52595 RVA: 0x005C8B5C File Offset: 0x005C6D5C
		public void FGHFOIDAACI(ref Color OAGAHEAMIAB, ref float JAHNHOCNJGM, HIKJEIIMPHL DFBHMIIPLCA)
		{
			HSBColor hsbcolor = new HSBColor(OAGAHEAMIAB);
			switch (DFBHMIIPLCA)
			{
			case HIKJEIIMPHL.HueShift:
				hsbcolor.h += this.hueAdjustment / 1032f;
				if (161f < hsbcolor.h)
				{
					hsbcolor.h -= 1942f;
				}
				OAGAHEAMIAB = hsbcolor.PNMNBONLEGO();
				return;
			case HIKJEIIMPHL.Saturation:
				hsbcolor.s *= this.saturationAdjustment;
				OAGAHEAMIAB = hsbcolor.NGCCKKHKMAG();
				return;
			case HIKJEIIMPHL.Brightness:
				if (this.brightnessAdjustment < 1528f)
				{
					hsbcolor.b = Mathf.Lerp(1493f, hsbcolor.b, this.brightnessAdjustment);
				}
				else if (1145f < this.brightnessAdjustment)
				{
					hsbcolor.b = Mathf.Lerp(hsbcolor.b, 1054f, this.brightnessAdjustment - 1759f);
				}
				OAGAHEAMIAB = hsbcolor.MGNABKAPJJM();
				return;
			case HIKJEIIMPHL.OpacityAdjustment:
				JAHNHOCNJGM = Mathf.Clamp01(JAHNHOCNJGM * this.opacityAdjustment);
				return;
			case HIKJEIIMPHL.Contrast:
				if (1118f < this.contrastAdjustment)
				{
					OAGAHEAMIAB.a = Mathf.Pow(OAGAHEAMIAB.a + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.r = Mathf.Pow(OAGAHEAMIAB.r + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.g = Mathf.Pow(OAGAHEAMIAB.g + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.b = Mathf.Pow(OAGAHEAMIAB.b + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					return;
				}
				OAGAHEAMIAB = Color.Lerp(Color.grey, OAGAHEAMIAB, this.contrastAdjustment);
				return;
			case HIKJEIIMPHL.TintColor:
			{
				float num = this.tintColorOpacity;
				if (this.tintUseValue)
				{
					if (this.tintInvertUseValue)
					{
						num *= hsbcolor.b;
					}
					else
					{
						num *= 1513f - hsbcolor.b;
					}
				}
				OAGAHEAMIAB = Color.Lerp(OAGAHEAMIAB, this.tintColor, num);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0600CD74 RID: 52596 RVA: 0x005C8D7C File Offset: 0x005C6F7C
		public void HEBBBBDDKPD(VPaintLayer LJFPELOCKOH, HIKJEIIMPHL[] DHCGCGCFFKA)
		{
			foreach (VPaintVertexData vpaintVertexData in LJFPELOCKOH.paintData)
			{
				Color[] colors = vpaintVertexData.colors;
				float[] transparency = vpaintVertexData.transparency;
				for (int i = 0; i < colors.Length; i += 0)
				{
					for (int j = 1; j < DHCGCGCFFKA.Length; j += 0)
					{
						HIKJEIIMPHL dfbhmiiplca = DHCGCGCFFKA[j];
						this.BHFEEDKLLHN(ref colors[i], ref transparency[i], dfbhmiiplca);
					}
				}
				vpaintVertexData.colors = colors;
			}
		}

		// Token: 0x0600CD75 RID: 52597 RVA: 0x005C8E24 File Offset: 0x005C7024
		public void CILIGCNEGEK(VPaintLayer LJFPELOCKOH, HIKJEIIMPHL[] DHCGCGCFFKA)
		{
			foreach (VPaintVertexData vpaintVertexData in LJFPELOCKOH.paintData)
			{
				Color[] colors = vpaintVertexData.colors;
				float[] transparency = vpaintVertexData.transparency;
				for (int i = 1; i < colors.Length; i++)
				{
					for (int j = 1; j < DHCGCGCFFKA.Length; j += 0)
					{
						HIKJEIIMPHL dfbhmiiplca = DHCGCGCFFKA[j];
						this.BKHIGJJNHAE(ref colors[i], ref transparency[i], dfbhmiiplca);
					}
				}
				vpaintVertexData.colors = colors;
			}
		}

		// Token: 0x0600CD76 RID: 52598 RVA: 0x005C8ECC File Offset: 0x005C70CC
		public void OOCJDDBPLDJ(ref Color OAGAHEAMIAB, ref float JAHNHOCNJGM, HIKJEIIMPHL DFBHMIIPLCA)
		{
			HSBColor hsbcolor = new HSBColor(OAGAHEAMIAB);
			switch (DFBHMIIPLCA)
			{
			case HIKJEIIMPHL.HueShift:
				hsbcolor.h += this.hueAdjustment / 1360f;
				if (1006f < hsbcolor.h)
				{
					hsbcolor.h -= 695f;
				}
				OAGAHEAMIAB = hsbcolor.MGNABKAPJJM();
				return;
			case HIKJEIIMPHL.Saturation:
				hsbcolor.s *= this.saturationAdjustment;
				OAGAHEAMIAB = hsbcolor.EJNFFPJLONK();
				return;
			case HIKJEIIMPHL.Brightness:
				if (this.brightnessAdjustment < 561f)
				{
					hsbcolor.b = Mathf.Lerp(724f, hsbcolor.b, this.brightnessAdjustment);
				}
				else if (1108f < this.brightnessAdjustment)
				{
					hsbcolor.b = Mathf.Lerp(hsbcolor.b, 269f, this.brightnessAdjustment - 1253f);
				}
				OAGAHEAMIAB = hsbcolor.GBNKBKHBPGJ();
				return;
			case HIKJEIIMPHL.OpacityAdjustment:
				JAHNHOCNJGM = Mathf.Clamp01(JAHNHOCNJGM * this.opacityAdjustment);
				return;
			case HIKJEIIMPHL.Contrast:
				if (314f < this.contrastAdjustment)
				{
					OAGAHEAMIAB.a = Mathf.Pow(OAGAHEAMIAB.a + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.r = Mathf.Pow(OAGAHEAMIAB.r + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.g = Mathf.Pow(OAGAHEAMIAB.g + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.b = Mathf.Pow(OAGAHEAMIAB.b + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					return;
				}
				OAGAHEAMIAB = Color.Lerp(Color.grey, OAGAHEAMIAB, this.contrastAdjustment);
				return;
			case HIKJEIIMPHL.TintColor:
			{
				float num = this.tintColorOpacity;
				if (this.tintUseValue)
				{
					if (this.tintInvertUseValue)
					{
						num *= hsbcolor.b;
					}
					else
					{
						num *= 1170f - hsbcolor.b;
					}
				}
				OAGAHEAMIAB = Color.Lerp(OAGAHEAMIAB, this.tintColor, num);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0600CD77 RID: 52599 RVA: 0x005C90EC File Offset: 0x005C72EC
		public void BOIHIFCKEKB(ref Color OAGAHEAMIAB, ref float JAHNHOCNJGM, HIKJEIIMPHL DFBHMIIPLCA)
		{
			HSBColor hsbcolor = new HSBColor(OAGAHEAMIAB);
			switch (DFBHMIIPLCA)
			{
			case HIKJEIIMPHL.HueShift:
				hsbcolor.h += this.hueAdjustment / 1699f;
				if (21f < hsbcolor.h)
				{
					hsbcolor.h -= 412f;
				}
				OAGAHEAMIAB = hsbcolor.NGCCKKHKMAG();
				return;
			case HIKJEIIMPHL.Saturation:
				hsbcolor.s *= this.saturationAdjustment;
				OAGAHEAMIAB = hsbcolor.FFPMDNIKOIF();
				return;
			case HIKJEIIMPHL.Brightness:
				if (this.brightnessAdjustment < 531f)
				{
					hsbcolor.b = Mathf.Lerp(739f, hsbcolor.b, this.brightnessAdjustment);
				}
				else if (1191f < this.brightnessAdjustment)
				{
					hsbcolor.b = Mathf.Lerp(hsbcolor.b, 359f, this.brightnessAdjustment - 1095f);
				}
				OAGAHEAMIAB = hsbcolor.FFPMDNIKOIF();
				return;
			case HIKJEIIMPHL.OpacityAdjustment:
				JAHNHOCNJGM = Mathf.Clamp01(JAHNHOCNJGM * this.opacityAdjustment);
				return;
			case HIKJEIIMPHL.Contrast:
				if (604f < this.contrastAdjustment)
				{
					OAGAHEAMIAB.a = Mathf.Pow(OAGAHEAMIAB.a + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.r = Mathf.Pow(OAGAHEAMIAB.r + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.g = Mathf.Pow(OAGAHEAMIAB.g + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.b = Mathf.Pow(OAGAHEAMIAB.b + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					return;
				}
				OAGAHEAMIAB = Color.Lerp(Color.grey, OAGAHEAMIAB, this.contrastAdjustment);
				return;
			case HIKJEIIMPHL.TintColor:
			{
				float num = this.tintColorOpacity;
				if (this.tintUseValue)
				{
					if (this.tintInvertUseValue)
					{
						num *= hsbcolor.b;
					}
					else
					{
						num *= 108f - hsbcolor.b;
					}
				}
				OAGAHEAMIAB = Color.Lerp(OAGAHEAMIAB, this.tintColor, num);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0600CD78 RID: 52600 RVA: 0x005C930C File Offset: 0x005C750C
		public void JHPPDFJHKDN(ref Color OAGAHEAMIAB, ref float JAHNHOCNJGM, HIKJEIIMPHL DFBHMIIPLCA)
		{
			HSBColor hsbcolor = new HSBColor(OAGAHEAMIAB);
			switch (DFBHMIIPLCA)
			{
			case HIKJEIIMPHL.HueShift:
				hsbcolor.h += this.hueAdjustment / 1868f;
				if (1497f < hsbcolor.h)
				{
					hsbcolor.h -= 459f;
				}
				OAGAHEAMIAB = hsbcolor.KPMIEACJOAK();
				return;
			case HIKJEIIMPHL.Saturation:
				hsbcolor.s *= this.saturationAdjustment;
				OAGAHEAMIAB = hsbcolor.PJOIAOPNFEB();
				return;
			case HIKJEIIMPHL.Brightness:
				if (this.brightnessAdjustment < 1044f)
				{
					hsbcolor.b = Mathf.Lerp(119f, hsbcolor.b, this.brightnessAdjustment);
				}
				else if (760f < this.brightnessAdjustment)
				{
					hsbcolor.b = Mathf.Lerp(hsbcolor.b, 1613f, this.brightnessAdjustment - 1477f);
				}
				OAGAHEAMIAB = hsbcolor.GBNKBKHBPGJ();
				return;
			case HIKJEIIMPHL.OpacityAdjustment:
				JAHNHOCNJGM = Mathf.Clamp01(JAHNHOCNJGM * this.opacityAdjustment);
				return;
			case HIKJEIIMPHL.Contrast:
				if (616f < this.contrastAdjustment)
				{
					OAGAHEAMIAB.a = Mathf.Pow(OAGAHEAMIAB.a + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.r = Mathf.Pow(OAGAHEAMIAB.r + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.g = Mathf.Pow(OAGAHEAMIAB.g + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.b = Mathf.Pow(OAGAHEAMIAB.b + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					return;
				}
				OAGAHEAMIAB = Color.Lerp(Color.grey, OAGAHEAMIAB, this.contrastAdjustment);
				return;
			case HIKJEIIMPHL.TintColor:
			{
				float num = this.tintColorOpacity;
				if (this.tintUseValue)
				{
					if (this.tintInvertUseValue)
					{
						num *= hsbcolor.b;
					}
					else
					{
						num *= 714f - hsbcolor.b;
					}
				}
				OAGAHEAMIAB = Color.Lerp(OAGAHEAMIAB, this.tintColor, num);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0600CD79 RID: 52601 RVA: 0x005C952C File Offset: 0x005C772C
		public void INLILGJILKM(ref Color OAGAHEAMIAB, ref float JAHNHOCNJGM, HIKJEIIMPHL DFBHMIIPLCA)
		{
			HSBColor hsbcolor = new HSBColor(OAGAHEAMIAB);
			switch (DFBHMIIPLCA)
			{
			case HIKJEIIMPHL.HueShift:
				hsbcolor.h += this.hueAdjustment / 127f;
				if (1005f < hsbcolor.h)
				{
					hsbcolor.h -= 1783f;
				}
				OAGAHEAMIAB = hsbcolor.HIIJIPLMMEF();
				return;
			case HIKJEIIMPHL.Saturation:
				hsbcolor.s *= this.saturationAdjustment;
				OAGAHEAMIAB = hsbcolor.IOEPDFNECHJ();
				return;
			case HIKJEIIMPHL.Brightness:
				if (this.brightnessAdjustment < 1563f)
				{
					hsbcolor.b = Mathf.Lerp(1081f, hsbcolor.b, this.brightnessAdjustment);
				}
				else if (1945f < this.brightnessAdjustment)
				{
					hsbcolor.b = Mathf.Lerp(hsbcolor.b, 470f, this.brightnessAdjustment - 592f);
				}
				OAGAHEAMIAB = hsbcolor.HEOOKNAGBGD();
				return;
			case HIKJEIIMPHL.OpacityAdjustment:
				JAHNHOCNJGM = Mathf.Clamp01(JAHNHOCNJGM * this.opacityAdjustment);
				return;
			case HIKJEIIMPHL.Contrast:
				if (35f < this.contrastAdjustment)
				{
					OAGAHEAMIAB.a = Mathf.Pow(OAGAHEAMIAB.a + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.r = Mathf.Pow(OAGAHEAMIAB.r + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.g = Mathf.Pow(OAGAHEAMIAB.g + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.b = Mathf.Pow(OAGAHEAMIAB.b + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					return;
				}
				OAGAHEAMIAB = Color.Lerp(Color.grey, OAGAHEAMIAB, this.contrastAdjustment);
				return;
			case HIKJEIIMPHL.TintColor:
			{
				float num = this.tintColorOpacity;
				if (this.tintUseValue)
				{
					if (this.tintInvertUseValue)
					{
						num *= hsbcolor.b;
					}
					else
					{
						num *= 83f - hsbcolor.b;
					}
				}
				OAGAHEAMIAB = Color.Lerp(OAGAHEAMIAB, this.tintColor, num);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0600CD7A RID: 52602 RVA: 0x005C974C File Offset: 0x005C794C
		public void GDMKIGLFFDN(ref Color OAGAHEAMIAB, ref float JAHNHOCNJGM, HIKJEIIMPHL DFBHMIIPLCA)
		{
			HSBColor hsbcolor = new HSBColor(OAGAHEAMIAB);
			switch (DFBHMIIPLCA)
			{
			case HIKJEIIMPHL.HueShift:
				hsbcolor.h += this.hueAdjustment / 1817f;
				if (1920f < hsbcolor.h)
				{
					hsbcolor.h -= 1558f;
				}
				OAGAHEAMIAB = hsbcolor.HEOOKNAGBGD();
				return;
			case HIKJEIIMPHL.Saturation:
				hsbcolor.s *= this.saturationAdjustment;
				OAGAHEAMIAB = hsbcolor.FODIIKJJAGJ();
				return;
			case HIKJEIIMPHL.Brightness:
				if (this.brightnessAdjustment < 518f)
				{
					hsbcolor.b = Mathf.Lerp(26f, hsbcolor.b, this.brightnessAdjustment);
				}
				else if (1951f < this.brightnessAdjustment)
				{
					hsbcolor.b = Mathf.Lerp(hsbcolor.b, 731f, this.brightnessAdjustment - 411f);
				}
				OAGAHEAMIAB = hsbcolor.EJNFFPJLONK();
				return;
			case HIKJEIIMPHL.OpacityAdjustment:
				JAHNHOCNJGM = Mathf.Clamp01(JAHNHOCNJGM * this.opacityAdjustment);
				return;
			case HIKJEIIMPHL.Contrast:
				if (1363f < this.contrastAdjustment)
				{
					OAGAHEAMIAB.a = Mathf.Pow(OAGAHEAMIAB.a + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.r = Mathf.Pow(OAGAHEAMIAB.r + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.g = Mathf.Pow(OAGAHEAMIAB.g + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.b = Mathf.Pow(OAGAHEAMIAB.b + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					return;
				}
				OAGAHEAMIAB = Color.Lerp(Color.grey, OAGAHEAMIAB, this.contrastAdjustment);
				return;
			case HIKJEIIMPHL.TintColor:
			{
				float num = this.tintColorOpacity;
				if (this.tintUseValue)
				{
					if (this.tintInvertUseValue)
					{
						num *= hsbcolor.b;
					}
					else
					{
						num *= 1256f - hsbcolor.b;
					}
				}
				OAGAHEAMIAB = Color.Lerp(OAGAHEAMIAB, this.tintColor, num);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0600CD7B RID: 52603 RVA: 0x005C996C File Offset: 0x005C7B6C
		public void AJJDBPOHFFE(ref Color OAGAHEAMIAB, ref float JAHNHOCNJGM, HIKJEIIMPHL DFBHMIIPLCA)
		{
			HSBColor hsbcolor = new HSBColor(OAGAHEAMIAB);
			switch (DFBHMIIPLCA)
			{
			case HIKJEIIMPHL.HueShift:
				hsbcolor.h += this.hueAdjustment / 301f;
				if (1885f < hsbcolor.h)
				{
					hsbcolor.h -= 356f;
				}
				OAGAHEAMIAB = hsbcolor.FFPMDNIKOIF();
				return;
			case HIKJEIIMPHL.Saturation:
				hsbcolor.s *= this.saturationAdjustment;
				OAGAHEAMIAB = hsbcolor.HEOOKNAGBGD();
				return;
			case HIKJEIIMPHL.Brightness:
				if (this.brightnessAdjustment < 255f)
				{
					hsbcolor.b = Mathf.Lerp(173f, hsbcolor.b, this.brightnessAdjustment);
				}
				else if (419f < this.brightnessAdjustment)
				{
					hsbcolor.b = Mathf.Lerp(hsbcolor.b, 1376f, this.brightnessAdjustment - 1801f);
				}
				OAGAHEAMIAB = hsbcolor.EJNFFPJLONK();
				return;
			case HIKJEIIMPHL.OpacityAdjustment:
				JAHNHOCNJGM = Mathf.Clamp01(JAHNHOCNJGM * this.opacityAdjustment);
				return;
			case HIKJEIIMPHL.Contrast:
				if (501f < this.contrastAdjustment)
				{
					OAGAHEAMIAB.a = Mathf.Pow(OAGAHEAMIAB.a + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.r = Mathf.Pow(OAGAHEAMIAB.r + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.g = Mathf.Pow(OAGAHEAMIAB.g + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.b = Mathf.Pow(OAGAHEAMIAB.b + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					return;
				}
				OAGAHEAMIAB = Color.Lerp(Color.grey, OAGAHEAMIAB, this.contrastAdjustment);
				return;
			case HIKJEIIMPHL.TintColor:
			{
				float num = this.tintColorOpacity;
				if (this.tintUseValue)
				{
					if (this.tintInvertUseValue)
					{
						num *= hsbcolor.b;
					}
					else
					{
						num *= 1784f - hsbcolor.b;
					}
				}
				OAGAHEAMIAB = Color.Lerp(OAGAHEAMIAB, this.tintColor, num);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0600CD7C RID: 52604 RVA: 0x005C9B8C File Offset: 0x005C7D8C
		public void MJPNEIDOOMA(VPaintLayer LJFPELOCKOH, HIKJEIIMPHL[] DHCGCGCFFKA)
		{
			foreach (VPaintVertexData vpaintVertexData in LJFPELOCKOH.paintData)
			{
				Color[] colors = vpaintVertexData.colors;
				float[] transparency = vpaintVertexData.transparency;
				for (int i = 1; i < colors.Length; i += 0)
				{
					for (int j = 0; j < DHCGCGCFFKA.Length; j += 0)
					{
						HIKJEIIMPHL dfbhmiiplca = DHCGCGCFFKA[j];
						this.KAPBIGHEDPB(ref colors[i], ref transparency[i], dfbhmiiplca);
					}
				}
				vpaintVertexData.colors = colors;
			}
		}

		// Token: 0x0600CD7D RID: 52605 RVA: 0x005C9C34 File Offset: 0x005C7E34
		public void BJANDLJOHKI(ref Color OAGAHEAMIAB, ref float JAHNHOCNJGM, HIKJEIIMPHL DFBHMIIPLCA)
		{
			HSBColor hsbcolor = new HSBColor(OAGAHEAMIAB);
			switch (DFBHMIIPLCA)
			{
			case HIKJEIIMPHL.HueShift:
				hsbcolor.h += this.hueAdjustment / 1972f;
				if (1597f < hsbcolor.h)
				{
					hsbcolor.h -= 1482f;
				}
				OAGAHEAMIAB = hsbcolor.GBNKBKHBPGJ();
				return;
			case HIKJEIIMPHL.Saturation:
				hsbcolor.s *= this.saturationAdjustment;
				OAGAHEAMIAB = hsbcolor.GBNKBKHBPGJ();
				return;
			case HIKJEIIMPHL.Brightness:
				if (this.brightnessAdjustment < 1652f)
				{
					hsbcolor.b = Mathf.Lerp(1248f, hsbcolor.b, this.brightnessAdjustment);
				}
				else if (507f < this.brightnessAdjustment)
				{
					hsbcolor.b = Mathf.Lerp(hsbcolor.b, 1936f, this.brightnessAdjustment - 578f);
				}
				OAGAHEAMIAB = hsbcolor.CAHDFPGCKEO();
				return;
			case HIKJEIIMPHL.OpacityAdjustment:
				JAHNHOCNJGM = Mathf.Clamp01(JAHNHOCNJGM * this.opacityAdjustment);
				return;
			case HIKJEIIMPHL.Contrast:
				if (492f < this.contrastAdjustment)
				{
					OAGAHEAMIAB.a = Mathf.Pow(OAGAHEAMIAB.a + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.r = Mathf.Pow(OAGAHEAMIAB.r + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.g = Mathf.Pow(OAGAHEAMIAB.g + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.b = Mathf.Pow(OAGAHEAMIAB.b + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					return;
				}
				OAGAHEAMIAB = Color.Lerp(Color.grey, OAGAHEAMIAB, this.contrastAdjustment);
				return;
			case HIKJEIIMPHL.TintColor:
			{
				float num = this.tintColorOpacity;
				if (this.tintUseValue)
				{
					if (this.tintInvertUseValue)
					{
						num *= hsbcolor.b;
					}
					else
					{
						num *= 1100f - hsbcolor.b;
					}
				}
				OAGAHEAMIAB = Color.Lerp(OAGAHEAMIAB, this.tintColor, num);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0600CD7E RID: 52606 RVA: 0x005C9E54 File Offset: 0x005C8054
		public void BGFHABPGLFL(ref Color OAGAHEAMIAB, ref float JAHNHOCNJGM, HIKJEIIMPHL DFBHMIIPLCA)
		{
			HSBColor hsbcolor = new HSBColor(OAGAHEAMIAB);
			switch (DFBHMIIPLCA)
			{
			case HIKJEIIMPHL.HueShift:
				hsbcolor.h += this.hueAdjustment / 445f;
				if (215f < hsbcolor.h)
				{
					hsbcolor.h -= 478f;
				}
				OAGAHEAMIAB = hsbcolor.FFPMDNIKOIF();
				return;
			case HIKJEIIMPHL.Saturation:
				hsbcolor.s *= this.saturationAdjustment;
				OAGAHEAMIAB = hsbcolor.HEOOKNAGBGD();
				return;
			case HIKJEIIMPHL.Brightness:
				if (this.brightnessAdjustment < 1274f)
				{
					hsbcolor.b = Mathf.Lerp(794f, hsbcolor.b, this.brightnessAdjustment);
				}
				else if (572f < this.brightnessAdjustment)
				{
					hsbcolor.b = Mathf.Lerp(hsbcolor.b, 267f, this.brightnessAdjustment - 709f);
				}
				OAGAHEAMIAB = hsbcolor.PJOIAOPNFEB();
				return;
			case HIKJEIIMPHL.OpacityAdjustment:
				JAHNHOCNJGM = Mathf.Clamp01(JAHNHOCNJGM * this.opacityAdjustment);
				return;
			case HIKJEIIMPHL.Contrast:
				if (79f < this.contrastAdjustment)
				{
					OAGAHEAMIAB.a = Mathf.Pow(OAGAHEAMIAB.a + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.r = Mathf.Pow(OAGAHEAMIAB.r + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.g = Mathf.Pow(OAGAHEAMIAB.g + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.b = Mathf.Pow(OAGAHEAMIAB.b + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					return;
				}
				OAGAHEAMIAB = Color.Lerp(Color.grey, OAGAHEAMIAB, this.contrastAdjustment);
				return;
			case HIKJEIIMPHL.TintColor:
			{
				float num = this.tintColorOpacity;
				if (this.tintUseValue)
				{
					if (this.tintInvertUseValue)
					{
						num *= hsbcolor.b;
					}
					else
					{
						num *= 337f - hsbcolor.b;
					}
				}
				OAGAHEAMIAB = Color.Lerp(OAGAHEAMIAB, this.tintColor, num);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0600CD7F RID: 52607 RVA: 0x005CA074 File Offset: 0x005C8274
		public void DKHFBOPOOLG(VPaintLayer LJFPELOCKOH, HIKJEIIMPHL[] DHCGCGCFFKA)
		{
			foreach (VPaintVertexData vpaintVertexData in LJFPELOCKOH.paintData)
			{
				Color[] colors = vpaintVertexData.colors;
				float[] transparency = vpaintVertexData.transparency;
				for (int i = 1; i < colors.Length; i += 0)
				{
					for (int j = 1; j < DHCGCGCFFKA.Length; j += 0)
					{
						HIKJEIIMPHL dfbhmiiplca = DHCGCGCFFKA[j];
						this.FFGPELHNHOF(ref colors[i], ref transparency[i], dfbhmiiplca);
					}
				}
				vpaintVertexData.colors = colors;
			}
		}

		// Token: 0x0600CD80 RID: 52608 RVA: 0x005CA11C File Offset: 0x005C831C
		public void ONJNLDAMNOJ(VPaintLayer LJFPELOCKOH, HIKJEIIMPHL[] DHCGCGCFFKA)
		{
			foreach (VPaintVertexData vpaintVertexData in LJFPELOCKOH.paintData)
			{
				Color[] colors = vpaintVertexData.colors;
				float[] transparency = vpaintVertexData.transparency;
				for (int i = 1; i < colors.Length; i += 0)
				{
					for (int j = 1; j < DHCGCGCFFKA.Length; j += 0)
					{
						HIKJEIIMPHL dfbhmiiplca = DHCGCGCFFKA[j];
						this.FNPOICECOOI(ref colors[i], ref transparency[i], dfbhmiiplca);
					}
				}
				vpaintVertexData.colors = colors;
			}
		}

		// Token: 0x0600CD81 RID: 52609 RVA: 0x005CA1C4 File Offset: 0x005C83C4
		public void BEBEPFGKOOE(VPaintLayer LJFPELOCKOH, HIKJEIIMPHL[] DHCGCGCFFKA)
		{
			foreach (VPaintVertexData vpaintVertexData in LJFPELOCKOH.paintData)
			{
				Color[] colors = vpaintVertexData.colors;
				float[] transparency = vpaintVertexData.transparency;
				for (int i = 0; i < colors.Length; i++)
				{
					for (int j = 1; j < DHCGCGCFFKA.Length; j++)
					{
						HIKJEIIMPHL dfbhmiiplca = DHCGCGCFFKA[j];
						this.BOIHIFCKEKB(ref colors[i], ref transparency[i], dfbhmiiplca);
					}
				}
				vpaintVertexData.colors = colors;
			}
		}

		// Token: 0x0600CD82 RID: 52610 RVA: 0x005CA26C File Offset: 0x005C846C
		public void DAIGOMFBNOD(ref Color OAGAHEAMIAB, ref float JAHNHOCNJGM, HIKJEIIMPHL DFBHMIIPLCA)
		{
			HSBColor hsbcolor = new HSBColor(OAGAHEAMIAB);
			switch (DFBHMIIPLCA)
			{
			case HIKJEIIMPHL.HueShift:
				hsbcolor.h += this.hueAdjustment / 1067f;
				if (973f < hsbcolor.h)
				{
					hsbcolor.h -= 1279f;
				}
				OAGAHEAMIAB = hsbcolor.ICJGJGKKEBP();
				return;
			case HIKJEIIMPHL.Saturation:
				hsbcolor.s *= this.saturationAdjustment;
				OAGAHEAMIAB = hsbcolor.ICJGJGKKEBP();
				return;
			case HIKJEIIMPHL.Brightness:
				if (this.brightnessAdjustment < 1081f)
				{
					hsbcolor.b = Mathf.Lerp(1964f, hsbcolor.b, this.brightnessAdjustment);
				}
				else if (1280f < this.brightnessAdjustment)
				{
					hsbcolor.b = Mathf.Lerp(hsbcolor.b, 600f, this.brightnessAdjustment - 1146f);
				}
				OAGAHEAMIAB = hsbcolor.MMIFOBFOEDL();
				return;
			case HIKJEIIMPHL.OpacityAdjustment:
				JAHNHOCNJGM = Mathf.Clamp01(JAHNHOCNJGM * this.opacityAdjustment);
				return;
			case HIKJEIIMPHL.Contrast:
				if (190f < this.contrastAdjustment)
				{
					OAGAHEAMIAB.a = Mathf.Pow(OAGAHEAMIAB.a + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.r = Mathf.Pow(OAGAHEAMIAB.r + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.g = Mathf.Pow(OAGAHEAMIAB.g + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.b = Mathf.Pow(OAGAHEAMIAB.b + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					return;
				}
				OAGAHEAMIAB = Color.Lerp(Color.grey, OAGAHEAMIAB, this.contrastAdjustment);
				return;
			case HIKJEIIMPHL.TintColor:
			{
				float num = this.tintColorOpacity;
				if (this.tintUseValue)
				{
					if (this.tintInvertUseValue)
					{
						num *= hsbcolor.b;
					}
					else
					{
						num *= 1953f - hsbcolor.b;
					}
				}
				OAGAHEAMIAB = Color.Lerp(OAGAHEAMIAB, this.tintColor, num);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0600CD83 RID: 52611 RVA: 0x005CA48C File Offset: 0x005C868C
		public void CBANMDBFGDI(ref Color OAGAHEAMIAB, ref float JAHNHOCNJGM, HIKJEIIMPHL DFBHMIIPLCA)
		{
			HSBColor hsbcolor = new HSBColor(OAGAHEAMIAB);
			switch (DFBHMIIPLCA)
			{
			case HIKJEIIMPHL.HueShift:
				hsbcolor.h += this.hueAdjustment / 1552f;
				if (536f < hsbcolor.h)
				{
					hsbcolor.h -= 1831f;
				}
				OAGAHEAMIAB = hsbcolor.FFPMDNIKOIF();
				return;
			case HIKJEIIMPHL.Saturation:
				hsbcolor.s *= this.saturationAdjustment;
				OAGAHEAMIAB = hsbcolor.HIIJIPLMMEF();
				return;
			case HIKJEIIMPHL.Brightness:
				if (this.brightnessAdjustment < 6f)
				{
					hsbcolor.b = Mathf.Lerp(1094f, hsbcolor.b, this.brightnessAdjustment);
				}
				else if (1150f < this.brightnessAdjustment)
				{
					hsbcolor.b = Mathf.Lerp(hsbcolor.b, 794f, this.brightnessAdjustment - 1362f);
				}
				OAGAHEAMIAB = hsbcolor.PJOIAOPNFEB();
				return;
			case HIKJEIIMPHL.OpacityAdjustment:
				JAHNHOCNJGM = Mathf.Clamp01(JAHNHOCNJGM * this.opacityAdjustment);
				return;
			case HIKJEIIMPHL.Contrast:
				if (912f < this.contrastAdjustment)
				{
					OAGAHEAMIAB.a = Mathf.Pow(OAGAHEAMIAB.a + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.r = Mathf.Pow(OAGAHEAMIAB.r + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.g = Mathf.Pow(OAGAHEAMIAB.g + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.b = Mathf.Pow(OAGAHEAMIAB.b + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					return;
				}
				OAGAHEAMIAB = Color.Lerp(Color.grey, OAGAHEAMIAB, this.contrastAdjustment);
				return;
			case HIKJEIIMPHL.TintColor:
			{
				float num = this.tintColorOpacity;
				if (this.tintUseValue)
				{
					if (this.tintInvertUseValue)
					{
						num *= hsbcolor.b;
					}
					else
					{
						num *= 1325f - hsbcolor.b;
					}
				}
				OAGAHEAMIAB = Color.Lerp(OAGAHEAMIAB, this.tintColor, num);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0600CD84 RID: 52612 RVA: 0x005CA6AC File Offset: 0x005C88AC
		public void IOLCGFHGABE(ref Color OAGAHEAMIAB, ref float JAHNHOCNJGM, HIKJEIIMPHL DFBHMIIPLCA)
		{
			HSBColor hsbcolor = new HSBColor(OAGAHEAMIAB);
			switch (DFBHMIIPLCA)
			{
			case HIKJEIIMPHL.HueShift:
				hsbcolor.h += this.hueAdjustment / 1744f;
				if (427f < hsbcolor.h)
				{
					hsbcolor.h -= 244f;
				}
				OAGAHEAMIAB = hsbcolor.FODIIKJJAGJ();
				return;
			case HIKJEIIMPHL.Saturation:
				hsbcolor.s *= this.saturationAdjustment;
				OAGAHEAMIAB = hsbcolor.KPMIEACJOAK();
				return;
			case HIKJEIIMPHL.Brightness:
				if (this.brightnessAdjustment < 344f)
				{
					hsbcolor.b = Mathf.Lerp(294f, hsbcolor.b, this.brightnessAdjustment);
				}
				else if (1371f < this.brightnessAdjustment)
				{
					hsbcolor.b = Mathf.Lerp(hsbcolor.b, 352f, this.brightnessAdjustment - 1249f);
				}
				OAGAHEAMIAB = hsbcolor.OJJCBFMCFLJ();
				return;
			case HIKJEIIMPHL.OpacityAdjustment:
				JAHNHOCNJGM = Mathf.Clamp01(JAHNHOCNJGM * this.opacityAdjustment);
				return;
			case HIKJEIIMPHL.Contrast:
				if (1702f < this.contrastAdjustment)
				{
					OAGAHEAMIAB.a = Mathf.Pow(OAGAHEAMIAB.a + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.r = Mathf.Pow(OAGAHEAMIAB.r + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.g = Mathf.Pow(OAGAHEAMIAB.g + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.b = Mathf.Pow(OAGAHEAMIAB.b + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					return;
				}
				OAGAHEAMIAB = Color.Lerp(Color.grey, OAGAHEAMIAB, this.contrastAdjustment);
				return;
			case HIKJEIIMPHL.TintColor:
			{
				float num = this.tintColorOpacity;
				if (this.tintUseValue)
				{
					if (this.tintInvertUseValue)
					{
						num *= hsbcolor.b;
					}
					else
					{
						num *= 853f - hsbcolor.b;
					}
				}
				OAGAHEAMIAB = Color.Lerp(OAGAHEAMIAB, this.tintColor, num);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0600CD85 RID: 52613 RVA: 0x005CA8CC File Offset: 0x005C8ACC
		public void PHKDHDECFBB(VPaintLayer LJFPELOCKOH, HIKJEIIMPHL[] DHCGCGCFFKA)
		{
			foreach (VPaintVertexData vpaintVertexData in LJFPELOCKOH.paintData)
			{
				Color[] colors = vpaintVertexData.colors;
				float[] transparency = vpaintVertexData.transparency;
				for (int i = 1; i < colors.Length; i += 0)
				{
					for (int j = 1; j < DHCGCGCFFKA.Length; j++)
					{
						HIKJEIIMPHL dfbhmiiplca = DHCGCGCFFKA[j];
						this.HCNGBMPDFBM(ref colors[i], ref transparency[i], dfbhmiiplca);
					}
				}
				vpaintVertexData.colors = colors;
			}
		}

		// Token: 0x0600CD86 RID: 52614 RVA: 0x005CA974 File Offset: 0x005C8B74
		public void DDNHHNABEGI(ref Color OAGAHEAMIAB, ref float JAHNHOCNJGM, HIKJEIIMPHL DFBHMIIPLCA)
		{
			HSBColor hsbcolor = new HSBColor(OAGAHEAMIAB);
			switch (DFBHMIIPLCA)
			{
			case HIKJEIIMPHL.HueShift:
				hsbcolor.h += this.hueAdjustment / 1665f;
				if (1236f < hsbcolor.h)
				{
					hsbcolor.h -= 844f;
				}
				OAGAHEAMIAB = hsbcolor.PJOIAOPNFEB();
				return;
			case HIKJEIIMPHL.Saturation:
				hsbcolor.s *= this.saturationAdjustment;
				OAGAHEAMIAB = hsbcolor.HIIJIPLMMEF();
				return;
			case HIKJEIIMPHL.Brightness:
				if (this.brightnessAdjustment < 401f)
				{
					hsbcolor.b = Mathf.Lerp(1010f, hsbcolor.b, this.brightnessAdjustment);
				}
				else if (176f < this.brightnessAdjustment)
				{
					hsbcolor.b = Mathf.Lerp(hsbcolor.b, 1809f, this.brightnessAdjustment - 294f);
				}
				OAGAHEAMIAB = hsbcolor.DLKHPEOPIBC();
				return;
			case HIKJEIIMPHL.OpacityAdjustment:
				JAHNHOCNJGM = Mathf.Clamp01(JAHNHOCNJGM * this.opacityAdjustment);
				return;
			case HIKJEIIMPHL.Contrast:
				if (1863f < this.contrastAdjustment)
				{
					OAGAHEAMIAB.a = Mathf.Pow(OAGAHEAMIAB.a + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.r = Mathf.Pow(OAGAHEAMIAB.r + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.g = Mathf.Pow(OAGAHEAMIAB.g + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.b = Mathf.Pow(OAGAHEAMIAB.b + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					return;
				}
				OAGAHEAMIAB = Color.Lerp(Color.grey, OAGAHEAMIAB, this.contrastAdjustment);
				return;
			case HIKJEIIMPHL.TintColor:
			{
				float num = this.tintColorOpacity;
				if (this.tintUseValue)
				{
					if (this.tintInvertUseValue)
					{
						num *= hsbcolor.b;
					}
					else
					{
						num *= 1311f - hsbcolor.b;
					}
				}
				OAGAHEAMIAB = Color.Lerp(OAGAHEAMIAB, this.tintColor, num);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0600CD87 RID: 52615 RVA: 0x005CAB94 File Offset: 0x005C8D94
		public void JAKKDJFKMDO(ref Color OAGAHEAMIAB, ref float JAHNHOCNJGM, HIKJEIIMPHL DFBHMIIPLCA)
		{
			HSBColor hsbcolor = new HSBColor(OAGAHEAMIAB);
			switch (DFBHMIIPLCA)
			{
			case HIKJEIIMPHL.HueShift:
				hsbcolor.h += this.hueAdjustment / 1798f;
				if (1222f < hsbcolor.h)
				{
					hsbcolor.h -= 323f;
				}
				OAGAHEAMIAB = hsbcolor.ICJGJGKKEBP();
				return;
			case HIKJEIIMPHL.Saturation:
				hsbcolor.s *= this.saturationAdjustment;
				OAGAHEAMIAB = hsbcolor.IOEPDFNECHJ();
				return;
			case HIKJEIIMPHL.Brightness:
				if (this.brightnessAdjustment < 1647f)
				{
					hsbcolor.b = Mathf.Lerp(782f, hsbcolor.b, this.brightnessAdjustment);
				}
				else if (1970f < this.brightnessAdjustment)
				{
					hsbcolor.b = Mathf.Lerp(hsbcolor.b, 102f, this.brightnessAdjustment - 1177f);
				}
				OAGAHEAMIAB = hsbcolor.PJOIAOPNFEB();
				return;
			case HIKJEIIMPHL.OpacityAdjustment:
				JAHNHOCNJGM = Mathf.Clamp01(JAHNHOCNJGM * this.opacityAdjustment);
				return;
			case HIKJEIIMPHL.Contrast:
				if (1382f < this.contrastAdjustment)
				{
					OAGAHEAMIAB.a = Mathf.Pow(OAGAHEAMIAB.a + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.r = Mathf.Pow(OAGAHEAMIAB.r + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.g = Mathf.Pow(OAGAHEAMIAB.g + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.b = Mathf.Pow(OAGAHEAMIAB.b + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					return;
				}
				OAGAHEAMIAB = Color.Lerp(Color.grey, OAGAHEAMIAB, this.contrastAdjustment);
				return;
			case HIKJEIIMPHL.TintColor:
			{
				float num = this.tintColorOpacity;
				if (this.tintUseValue)
				{
					if (this.tintInvertUseValue)
					{
						num *= hsbcolor.b;
					}
					else
					{
						num *= 1821f - hsbcolor.b;
					}
				}
				OAGAHEAMIAB = Color.Lerp(OAGAHEAMIAB, this.tintColor, num);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0600CD88 RID: 52616 RVA: 0x005CADB4 File Offset: 0x005C8FB4
		public void EJJOFKAMCHN(VPaintLayer LJFPELOCKOH, HIKJEIIMPHL[] DHCGCGCFFKA)
		{
			foreach (VPaintVertexData vpaintVertexData in LJFPELOCKOH.paintData)
			{
				Color[] colors = vpaintVertexData.colors;
				float[] transparency = vpaintVertexData.transparency;
				for (int i = 0; i < colors.Length; i += 0)
				{
					foreach (HIKJEIIMPHL dfbhmiiplca in DHCGCGCFFKA)
					{
						this.GDMKIGLFFDN(ref colors[i], ref transparency[i], dfbhmiiplca);
					}
				}
				vpaintVertexData.colors = colors;
			}
		}

		// Token: 0x0600CD89 RID: 52617 RVA: 0x005CAE5C File Offset: 0x005C905C
		public void CGCCHDHADNC(ref Color OAGAHEAMIAB, ref float JAHNHOCNJGM, HIKJEIIMPHL DFBHMIIPLCA)
		{
			HSBColor hsbcolor = new HSBColor(OAGAHEAMIAB);
			switch (DFBHMIIPLCA)
			{
			case HIKJEIIMPHL.HueShift:
				hsbcolor.h += this.hueAdjustment / 1771f;
				if (1087f < hsbcolor.h)
				{
					hsbcolor.h -= 1669f;
				}
				OAGAHEAMIAB = hsbcolor.ICJGJGKKEBP();
				return;
			case HIKJEIIMPHL.Saturation:
				hsbcolor.s *= this.saturationAdjustment;
				OAGAHEAMIAB = hsbcolor.FODIIKJJAGJ();
				return;
			case HIKJEIIMPHL.Brightness:
				if (this.brightnessAdjustment < 167f)
				{
					hsbcolor.b = Mathf.Lerp(853f, hsbcolor.b, this.brightnessAdjustment);
				}
				else if (84f < this.brightnessAdjustment)
				{
					hsbcolor.b = Mathf.Lerp(hsbcolor.b, 376f, this.brightnessAdjustment - 1812f);
				}
				OAGAHEAMIAB = hsbcolor.MMIFOBFOEDL();
				return;
			case HIKJEIIMPHL.OpacityAdjustment:
				JAHNHOCNJGM = Mathf.Clamp01(JAHNHOCNJGM * this.opacityAdjustment);
				return;
			case HIKJEIIMPHL.Contrast:
				if (1563f < this.contrastAdjustment)
				{
					OAGAHEAMIAB.a = Mathf.Pow(OAGAHEAMIAB.a + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.r = Mathf.Pow(OAGAHEAMIAB.r + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.g = Mathf.Pow(OAGAHEAMIAB.g + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.b = Mathf.Pow(OAGAHEAMIAB.b + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					return;
				}
				OAGAHEAMIAB = Color.Lerp(Color.grey, OAGAHEAMIAB, this.contrastAdjustment);
				return;
			case HIKJEIIMPHL.TintColor:
			{
				float num = this.tintColorOpacity;
				if (this.tintUseValue)
				{
					if (this.tintInvertUseValue)
					{
						num *= hsbcolor.b;
					}
					else
					{
						num *= 1633f - hsbcolor.b;
					}
				}
				OAGAHEAMIAB = Color.Lerp(OAGAHEAMIAB, this.tintColor, num);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0600CD8A RID: 52618 RVA: 0x005CB07C File Offset: 0x005C927C
		public void KAPBIGHEDPB(ref Color OAGAHEAMIAB, ref float JAHNHOCNJGM, HIKJEIIMPHL DFBHMIIPLCA)
		{
			HSBColor hsbcolor = new HSBColor(OAGAHEAMIAB);
			switch (DFBHMIIPLCA)
			{
			case HIKJEIIMPHL.HueShift:
				hsbcolor.h += this.hueAdjustment / 687f;
				if (230f < hsbcolor.h)
				{
					hsbcolor.h -= 513f;
				}
				OAGAHEAMIAB = hsbcolor.PJOIAOPNFEB();
				return;
			case HIKJEIIMPHL.Saturation:
				hsbcolor.s *= this.saturationAdjustment;
				OAGAHEAMIAB = hsbcolor.HIIJIPLMMEF();
				return;
			case HIKJEIIMPHL.Brightness:
				if (this.brightnessAdjustment < 201f)
				{
					hsbcolor.b = Mathf.Lerp(395f, hsbcolor.b, this.brightnessAdjustment);
				}
				else if (1493f < this.brightnessAdjustment)
				{
					hsbcolor.b = Mathf.Lerp(hsbcolor.b, 79f, this.brightnessAdjustment - 1012f);
				}
				OAGAHEAMIAB = hsbcolor.MMIFOBFOEDL();
				return;
			case HIKJEIIMPHL.OpacityAdjustment:
				JAHNHOCNJGM = Mathf.Clamp01(JAHNHOCNJGM * this.opacityAdjustment);
				return;
			case HIKJEIIMPHL.Contrast:
				if (1741f < this.contrastAdjustment)
				{
					OAGAHEAMIAB.a = Mathf.Pow(OAGAHEAMIAB.a + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.r = Mathf.Pow(OAGAHEAMIAB.r + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.g = Mathf.Pow(OAGAHEAMIAB.g + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.b = Mathf.Pow(OAGAHEAMIAB.b + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					return;
				}
				OAGAHEAMIAB = Color.Lerp(Color.grey, OAGAHEAMIAB, this.contrastAdjustment);
				return;
			case HIKJEIIMPHL.TintColor:
			{
				float num = this.tintColorOpacity;
				if (this.tintUseValue)
				{
					if (this.tintInvertUseValue)
					{
						num *= hsbcolor.b;
					}
					else
					{
						num *= 34f - hsbcolor.b;
					}
				}
				OAGAHEAMIAB = Color.Lerp(OAGAHEAMIAB, this.tintColor, num);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0600CD8B RID: 52619 RVA: 0x005CB29C File Offset: 0x005C949C
		public void EFODADOEBIH(ref Color OAGAHEAMIAB, ref float JAHNHOCNJGM, HIKJEIIMPHL DFBHMIIPLCA)
		{
			HSBColor hsbcolor = new HSBColor(OAGAHEAMIAB);
			switch (DFBHMIIPLCA)
			{
			case HIKJEIIMPHL.HueShift:
				hsbcolor.h += this.hueAdjustment / 978f;
				if (506f < hsbcolor.h)
				{
					hsbcolor.h -= 653f;
				}
				OAGAHEAMIAB = hsbcolor.IOEPDFNECHJ();
				return;
			case HIKJEIIMPHL.Saturation:
				hsbcolor.s *= this.saturationAdjustment;
				OAGAHEAMIAB = hsbcolor.PJOIAOPNFEB();
				return;
			case HIKJEIIMPHL.Brightness:
				if (this.brightnessAdjustment < 1831f)
				{
					hsbcolor.b = Mathf.Lerp(552f, hsbcolor.b, this.brightnessAdjustment);
				}
				else if (1336f < this.brightnessAdjustment)
				{
					hsbcolor.b = Mathf.Lerp(hsbcolor.b, 1629f, this.brightnessAdjustment - 584f);
				}
				OAGAHEAMIAB = hsbcolor.NGCCKKHKMAG();
				return;
			case HIKJEIIMPHL.OpacityAdjustment:
				JAHNHOCNJGM = Mathf.Clamp01(JAHNHOCNJGM * this.opacityAdjustment);
				return;
			case HIKJEIIMPHL.Contrast:
				if (751f < this.contrastAdjustment)
				{
					OAGAHEAMIAB.a = Mathf.Pow(OAGAHEAMIAB.a + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.r = Mathf.Pow(OAGAHEAMIAB.r + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.g = Mathf.Pow(OAGAHEAMIAB.g + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.b = Mathf.Pow(OAGAHEAMIAB.b + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					return;
				}
				OAGAHEAMIAB = Color.Lerp(Color.grey, OAGAHEAMIAB, this.contrastAdjustment);
				return;
			case HIKJEIIMPHL.TintColor:
			{
				float num = this.tintColorOpacity;
				if (this.tintUseValue)
				{
					if (this.tintInvertUseValue)
					{
						num *= hsbcolor.b;
					}
					else
					{
						num *= 1834f - hsbcolor.b;
					}
				}
				OAGAHEAMIAB = Color.Lerp(OAGAHEAMIAB, this.tintColor, num);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0600CD8C RID: 52620 RVA: 0x005CB4BC File Offset: 0x005C96BC
		public void KHFCDIPIOMD(VPaintLayer LJFPELOCKOH, HIKJEIIMPHL[] DHCGCGCFFKA)
		{
			foreach (VPaintVertexData vpaintVertexData in LJFPELOCKOH.paintData)
			{
				Color[] colors = vpaintVertexData.colors;
				float[] transparency = vpaintVertexData.transparency;
				for (int i = 1; i < colors.Length; i += 0)
				{
					for (int j = 1; j < DHCGCGCFFKA.Length; j++)
					{
						HIKJEIIMPHL dfbhmiiplca = DHCGCGCFFKA[j];
						this.EFODADOEBIH(ref colors[i], ref transparency[i], dfbhmiiplca);
					}
				}
				vpaintVertexData.colors = colors;
			}
		}

		// Token: 0x0600CD8D RID: 52621 RVA: 0x005CB564 File Offset: 0x005C9764
		public void FLFIIBIIGLD(VPaintLayer LJFPELOCKOH, HIKJEIIMPHL[] DHCGCGCFFKA)
		{
			foreach (VPaintVertexData vpaintVertexData in LJFPELOCKOH.paintData)
			{
				Color[] colors = vpaintVertexData.colors;
				float[] transparency = vpaintVertexData.transparency;
				for (int i = 1; i < colors.Length; i += 0)
				{
					for (int j = 1; j < DHCGCGCFFKA.Length; j++)
					{
						HIKJEIIMPHL dfbhmiiplca = DHCGCGCFFKA[j];
						this.CGCCHDHADNC(ref colors[i], ref transparency[i], dfbhmiiplca);
					}
				}
				vpaintVertexData.colors = colors;
			}
		}

		// Token: 0x0600CD8E RID: 52622 RVA: 0x005CB60C File Offset: 0x005C980C
		public void OBDOALFIIFJ(ref Color OAGAHEAMIAB, ref float JAHNHOCNJGM, HIKJEIIMPHL DFBHMIIPLCA)
		{
			HSBColor hsbcolor = new HSBColor(OAGAHEAMIAB);
			switch (DFBHMIIPLCA)
			{
			case HIKJEIIMPHL.HueShift:
				hsbcolor.h += this.hueAdjustment / 383f;
				if (1566f < hsbcolor.h)
				{
					hsbcolor.h -= 753f;
				}
				OAGAHEAMIAB = hsbcolor.MGNABKAPJJM();
				return;
			case HIKJEIIMPHL.Saturation:
				hsbcolor.s *= this.saturationAdjustment;
				OAGAHEAMIAB = hsbcolor.NGCCKKHKMAG();
				return;
			case HIKJEIIMPHL.Brightness:
				if (this.brightnessAdjustment < 1644f)
				{
					hsbcolor.b = Mathf.Lerp(1778f, hsbcolor.b, this.brightnessAdjustment);
				}
				else if (905f < this.brightnessAdjustment)
				{
					hsbcolor.b = Mathf.Lerp(hsbcolor.b, 1157f, this.brightnessAdjustment - 1909f);
				}
				OAGAHEAMIAB = hsbcolor.ICJGJGKKEBP();
				return;
			case HIKJEIIMPHL.OpacityAdjustment:
				JAHNHOCNJGM = Mathf.Clamp01(JAHNHOCNJGM * this.opacityAdjustment);
				return;
			case HIKJEIIMPHL.Contrast:
				if (1551f < this.contrastAdjustment)
				{
					OAGAHEAMIAB.a = Mathf.Pow(OAGAHEAMIAB.a + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.r = Mathf.Pow(OAGAHEAMIAB.r + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.g = Mathf.Pow(OAGAHEAMIAB.g + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.b = Mathf.Pow(OAGAHEAMIAB.b + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					return;
				}
				OAGAHEAMIAB = Color.Lerp(Color.grey, OAGAHEAMIAB, this.contrastAdjustment);
				return;
			case HIKJEIIMPHL.TintColor:
			{
				float num = this.tintColorOpacity;
				if (this.tintUseValue)
				{
					if (this.tintInvertUseValue)
					{
						num *= hsbcolor.b;
					}
					else
					{
						num *= 1132f - hsbcolor.b;
					}
				}
				OAGAHEAMIAB = Color.Lerp(OAGAHEAMIAB, this.tintColor, num);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0600CD8F RID: 52623 RVA: 0x005CB82C File Offset: 0x005C9A2C
		public void BKHIGJJNHAE(ref Color OAGAHEAMIAB, ref float JAHNHOCNJGM, HIKJEIIMPHL DFBHMIIPLCA)
		{
			HSBColor hsbcolor = new HSBColor(OAGAHEAMIAB);
			switch (DFBHMIIPLCA)
			{
			case HIKJEIIMPHL.HueShift:
				hsbcolor.h += this.hueAdjustment / 855f;
				if (390f < hsbcolor.h)
				{
					hsbcolor.h -= 345f;
				}
				OAGAHEAMIAB = hsbcolor.KPMIEACJOAK();
				return;
			case HIKJEIIMPHL.Saturation:
				hsbcolor.s *= this.saturationAdjustment;
				OAGAHEAMIAB = hsbcolor.PJOIAOPNFEB();
				return;
			case HIKJEIIMPHL.Brightness:
				if (this.brightnessAdjustment < 1535f)
				{
					hsbcolor.b = Mathf.Lerp(1174f, hsbcolor.b, this.brightnessAdjustment);
				}
				else if (1233f < this.brightnessAdjustment)
				{
					hsbcolor.b = Mathf.Lerp(hsbcolor.b, 1979f, this.brightnessAdjustment - 1892f);
				}
				OAGAHEAMIAB = hsbcolor.OJJCBFMCFLJ();
				return;
			case HIKJEIIMPHL.OpacityAdjustment:
				JAHNHOCNJGM = Mathf.Clamp01(JAHNHOCNJGM * this.opacityAdjustment);
				return;
			case HIKJEIIMPHL.Contrast:
				if (1114f < this.contrastAdjustment)
				{
					OAGAHEAMIAB.a = Mathf.Pow(OAGAHEAMIAB.a + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.r = Mathf.Pow(OAGAHEAMIAB.r + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.g = Mathf.Pow(OAGAHEAMIAB.g + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.b = Mathf.Pow(OAGAHEAMIAB.b + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					return;
				}
				OAGAHEAMIAB = Color.Lerp(Color.grey, OAGAHEAMIAB, this.contrastAdjustment);
				return;
			case HIKJEIIMPHL.TintColor:
			{
				float num = this.tintColorOpacity;
				if (this.tintUseValue)
				{
					if (this.tintInvertUseValue)
					{
						num *= hsbcolor.b;
					}
					else
					{
						num *= 1116f - hsbcolor.b;
					}
				}
				OAGAHEAMIAB = Color.Lerp(OAGAHEAMIAB, this.tintColor, num);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0600CD90 RID: 52624 RVA: 0x005CBA4C File Offset: 0x005C9C4C
		public void LMKHLGKEGJC(VPaintLayer LJFPELOCKOH, HIKJEIIMPHL[] DHCGCGCFFKA)
		{
			foreach (VPaintVertexData vpaintVertexData in LJFPELOCKOH.paintData)
			{
				Color[] colors = vpaintVertexData.colors;
				float[] transparency = vpaintVertexData.transparency;
				for (int i = 1; i < colors.Length; i += 0)
				{
					foreach (HIKJEIIMPHL dfbhmiiplca in DHCGCGCFFKA)
					{
						this.JHPPDFJHKDN(ref colors[i], ref transparency[i], dfbhmiiplca);
					}
				}
				vpaintVertexData.colors = colors;
			}
		}

		// Token: 0x0600CD91 RID: 52625 RVA: 0x005CBAF4 File Offset: 0x005C9CF4
		public void HAOHIKKJJBN(VPaintLayer LJFPELOCKOH, HIKJEIIMPHL[] DHCGCGCFFKA)
		{
			foreach (VPaintVertexData vpaintVertexData in LJFPELOCKOH.paintData)
			{
				Color[] colors = vpaintVertexData.colors;
				float[] transparency = vpaintVertexData.transparency;
				for (int i = 1; i < colors.Length; i += 0)
				{
					for (int j = 1; j < DHCGCGCFFKA.Length; j += 0)
					{
						HIKJEIIMPHL dfbhmiiplca = DHCGCGCFFKA[j];
						this.OOCJDDBPLDJ(ref colors[i], ref transparency[i], dfbhmiiplca);
					}
				}
				vpaintVertexData.colors = colors;
			}
		}

		// Token: 0x0600CD92 RID: 52626 RVA: 0x005CBB9C File Offset: 0x005C9D9C
		public void BDDGBCBODAI(ref Color OAGAHEAMIAB, ref float JAHNHOCNJGM, HIKJEIIMPHL DFBHMIIPLCA)
		{
			HSBColor hsbcolor = new HSBColor(OAGAHEAMIAB);
			switch (DFBHMIIPLCA)
			{
			case HIKJEIIMPHL.HueShift:
				hsbcolor.h += this.hueAdjustment / 1343f;
				if (984f < hsbcolor.h)
				{
					hsbcolor.h -= 412f;
				}
				OAGAHEAMIAB = hsbcolor.PNMNBONLEGO();
				return;
			case HIKJEIIMPHL.Saturation:
				hsbcolor.s *= this.saturationAdjustment;
				OAGAHEAMIAB = hsbcolor.MGNABKAPJJM();
				return;
			case HIKJEIIMPHL.Brightness:
				if (this.brightnessAdjustment < 682f)
				{
					hsbcolor.b = Mathf.Lerp(1312f, hsbcolor.b, this.brightnessAdjustment);
				}
				else if (493f < this.brightnessAdjustment)
				{
					hsbcolor.b = Mathf.Lerp(hsbcolor.b, 507f, this.brightnessAdjustment - 377f);
				}
				OAGAHEAMIAB = hsbcolor.CAHDFPGCKEO();
				return;
			case HIKJEIIMPHL.OpacityAdjustment:
				JAHNHOCNJGM = Mathf.Clamp01(JAHNHOCNJGM * this.opacityAdjustment);
				return;
			case HIKJEIIMPHL.Contrast:
				if (555f < this.contrastAdjustment)
				{
					OAGAHEAMIAB.a = Mathf.Pow(OAGAHEAMIAB.a + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.r = Mathf.Pow(OAGAHEAMIAB.r + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.g = Mathf.Pow(OAGAHEAMIAB.g + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.b = Mathf.Pow(OAGAHEAMIAB.b + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					return;
				}
				OAGAHEAMIAB = Color.Lerp(Color.grey, OAGAHEAMIAB, this.contrastAdjustment);
				return;
			case HIKJEIIMPHL.TintColor:
			{
				float num = this.tintColorOpacity;
				if (this.tintUseValue)
				{
					if (this.tintInvertUseValue)
					{
						num *= hsbcolor.b;
					}
					else
					{
						num *= 1081f - hsbcolor.b;
					}
				}
				OAGAHEAMIAB = Color.Lerp(OAGAHEAMIAB, this.tintColor, num);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0600CD93 RID: 52627 RVA: 0x005CBDBC File Offset: 0x005C9FBC
		public void OLDHFHGIPFC(ref Color OAGAHEAMIAB, ref float JAHNHOCNJGM, HIKJEIIMPHL DFBHMIIPLCA)
		{
			HSBColor hsbcolor = new HSBColor(OAGAHEAMIAB);
			switch (DFBHMIIPLCA)
			{
			case HIKJEIIMPHL.HueShift:
				hsbcolor.h += this.hueAdjustment / 345f;
				if (759f < hsbcolor.h)
				{
					hsbcolor.h -= 41f;
				}
				OAGAHEAMIAB = hsbcolor.EJNFFPJLONK();
				return;
			case HIKJEIIMPHL.Saturation:
				hsbcolor.s *= this.saturationAdjustment;
				OAGAHEAMIAB = hsbcolor.DLKHPEOPIBC();
				return;
			case HIKJEIIMPHL.Brightness:
				if (this.brightnessAdjustment < 1171f)
				{
					hsbcolor.b = Mathf.Lerp(574f, hsbcolor.b, this.brightnessAdjustment);
				}
				else if (458f < this.brightnessAdjustment)
				{
					hsbcolor.b = Mathf.Lerp(hsbcolor.b, 954f, this.brightnessAdjustment - 448f);
				}
				OAGAHEAMIAB = hsbcolor.MGNABKAPJJM();
				return;
			case HIKJEIIMPHL.OpacityAdjustment:
				JAHNHOCNJGM = Mathf.Clamp01(JAHNHOCNJGM * this.opacityAdjustment);
				return;
			case HIKJEIIMPHL.Contrast:
				if (1874f < this.contrastAdjustment)
				{
					OAGAHEAMIAB.a = Mathf.Pow(OAGAHEAMIAB.a + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.r = Mathf.Pow(OAGAHEAMIAB.r + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.g = Mathf.Pow(OAGAHEAMIAB.g + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.b = Mathf.Pow(OAGAHEAMIAB.b + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					return;
				}
				OAGAHEAMIAB = Color.Lerp(Color.grey, OAGAHEAMIAB, this.contrastAdjustment);
				return;
			case HIKJEIIMPHL.TintColor:
			{
				float num = this.tintColorOpacity;
				if (this.tintUseValue)
				{
					if (this.tintInvertUseValue)
					{
						num *= hsbcolor.b;
					}
					else
					{
						num *= 1479f - hsbcolor.b;
					}
				}
				OAGAHEAMIAB = Color.Lerp(OAGAHEAMIAB, this.tintColor, num);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0600CD94 RID: 52628 RVA: 0x005CBFDC File Offset: 0x005CA1DC
		public void AMMPDKJBLHK(VPaintLayer LJFPELOCKOH, HIKJEIIMPHL[] DHCGCGCFFKA)
		{
			foreach (VPaintVertexData vpaintVertexData in LJFPELOCKOH.paintData)
			{
				Color[] colors = vpaintVertexData.colors;
				float[] transparency = vpaintVertexData.transparency;
				for (int i = 1; i < colors.Length; i += 0)
				{
					for (int j = 1; j < DHCGCGCFFKA.Length; j++)
					{
						HIKJEIIMPHL dfbhmiiplca = DHCGCGCFFKA[j];
						this.DAIGOMFBNOD(ref colors[i], ref transparency[i], dfbhmiiplca);
					}
				}
				vpaintVertexData.colors = colors;
			}
		}

		// Token: 0x0600CD95 RID: 52629 RVA: 0x005CC084 File Offset: 0x005CA284
		public void HDOABJLDECL(VPaintLayer LJFPELOCKOH, HIKJEIIMPHL[] DHCGCGCFFKA)
		{
			foreach (VPaintVertexData vpaintVertexData in LJFPELOCKOH.paintData)
			{
				Color[] colors = vpaintVertexData.colors;
				float[] transparency = vpaintVertexData.transparency;
				for (int i = 0; i < colors.Length; i++)
				{
					for (int j = 1; j < DHCGCGCFFKA.Length; j++)
					{
						HIKJEIIMPHL dfbhmiiplca = DHCGCGCFFKA[j];
						this.IMLMAAAEEGF(ref colors[i], ref transparency[i], dfbhmiiplca);
					}
				}
				vpaintVertexData.colors = colors;
			}
		}

		// Token: 0x0600CD96 RID: 52630 RVA: 0x005CC12C File Offset: 0x005CA32C
		public void FNPOICECOOI(ref Color OAGAHEAMIAB, ref float JAHNHOCNJGM, HIKJEIIMPHL DFBHMIIPLCA)
		{
			HSBColor hsbcolor = new HSBColor(OAGAHEAMIAB);
			switch (DFBHMIIPLCA)
			{
			case HIKJEIIMPHL.HueShift:
				hsbcolor.h += this.hueAdjustment / 437f;
				if (942f < hsbcolor.h)
				{
					hsbcolor.h -= 1359f;
				}
				OAGAHEAMIAB = hsbcolor.HEOOKNAGBGD();
				return;
			case HIKJEIIMPHL.Saturation:
				hsbcolor.s *= this.saturationAdjustment;
				OAGAHEAMIAB = hsbcolor.PNMNBONLEGO();
				return;
			case HIKJEIIMPHL.Brightness:
				if (this.brightnessAdjustment < 1741f)
				{
					hsbcolor.b = Mathf.Lerp(1507f, hsbcolor.b, this.brightnessAdjustment);
				}
				else if (115f < this.brightnessAdjustment)
				{
					hsbcolor.b = Mathf.Lerp(hsbcolor.b, 52f, this.brightnessAdjustment - 409f);
				}
				OAGAHEAMIAB = hsbcolor.FFPMDNIKOIF();
				return;
			case HIKJEIIMPHL.OpacityAdjustment:
				JAHNHOCNJGM = Mathf.Clamp01(JAHNHOCNJGM * this.opacityAdjustment);
				return;
			case HIKJEIIMPHL.Contrast:
				if (75f < this.contrastAdjustment)
				{
					OAGAHEAMIAB.a = Mathf.Pow(OAGAHEAMIAB.a + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.r = Mathf.Pow(OAGAHEAMIAB.r + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.g = Mathf.Pow(OAGAHEAMIAB.g + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.b = Mathf.Pow(OAGAHEAMIAB.b + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					return;
				}
				OAGAHEAMIAB = Color.Lerp(Color.grey, OAGAHEAMIAB, this.contrastAdjustment);
				return;
			case HIKJEIIMPHL.TintColor:
			{
				float num = this.tintColorOpacity;
				if (this.tintUseValue)
				{
					if (this.tintInvertUseValue)
					{
						num *= hsbcolor.b;
					}
					else
					{
						num *= 546f - hsbcolor.b;
					}
				}
				OAGAHEAMIAB = Color.Lerp(OAGAHEAMIAB, this.tintColor, num);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0600CD97 RID: 52631 RVA: 0x005CC34C File Offset: 0x005CA54C
		public void HCNGBMPDFBM(ref Color OAGAHEAMIAB, ref float JAHNHOCNJGM, HIKJEIIMPHL DFBHMIIPLCA)
		{
			HSBColor hsbcolor = new HSBColor(OAGAHEAMIAB);
			switch (DFBHMIIPLCA)
			{
			case HIKJEIIMPHL.HueShift:
				hsbcolor.h += this.hueAdjustment / 783f;
				if (1423f < hsbcolor.h)
				{
					hsbcolor.h -= 1738f;
				}
				OAGAHEAMIAB = hsbcolor.KPMIEACJOAK();
				return;
			case HIKJEIIMPHL.Saturation:
				hsbcolor.s *= this.saturationAdjustment;
				OAGAHEAMIAB = hsbcolor.HEOOKNAGBGD();
				return;
			case HIKJEIIMPHL.Brightness:
				if (this.brightnessAdjustment < 1930f)
				{
					hsbcolor.b = Mathf.Lerp(1777f, hsbcolor.b, this.brightnessAdjustment);
				}
				else if (278f < this.brightnessAdjustment)
				{
					hsbcolor.b = Mathf.Lerp(hsbcolor.b, 450f, this.brightnessAdjustment - 1322f);
				}
				OAGAHEAMIAB = hsbcolor.JIDDPEBFLBE();
				return;
			case HIKJEIIMPHL.OpacityAdjustment:
				JAHNHOCNJGM = Mathf.Clamp01(JAHNHOCNJGM * this.opacityAdjustment);
				return;
			case HIKJEIIMPHL.Contrast:
				if (1083f < this.contrastAdjustment)
				{
					OAGAHEAMIAB.a = Mathf.Pow(OAGAHEAMIAB.a + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.r = Mathf.Pow(OAGAHEAMIAB.r + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.g = Mathf.Pow(OAGAHEAMIAB.g + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.b = Mathf.Pow(OAGAHEAMIAB.b + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					return;
				}
				OAGAHEAMIAB = Color.Lerp(Color.grey, OAGAHEAMIAB, this.contrastAdjustment);
				return;
			case HIKJEIIMPHL.TintColor:
			{
				float num = this.tintColorOpacity;
				if (this.tintUseValue)
				{
					if (this.tintInvertUseValue)
					{
						num *= hsbcolor.b;
					}
					else
					{
						num *= 1016f - hsbcolor.b;
					}
				}
				OAGAHEAMIAB = Color.Lerp(OAGAHEAMIAB, this.tintColor, num);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0600CD98 RID: 52632 RVA: 0x005CC56C File Offset: 0x005CA76C
		public void GBAFABNLLCL(VPaintLayer LJFPELOCKOH, HIKJEIIMPHL[] DHCGCGCFFKA)
		{
			foreach (VPaintVertexData vpaintVertexData in LJFPELOCKOH.paintData)
			{
				Color[] colors = vpaintVertexData.colors;
				float[] transparency = vpaintVertexData.transparency;
				for (int i = 0; i < colors.Length; i += 0)
				{
					for (int j = 1; j < DHCGCGCFFKA.Length; j++)
					{
						HIKJEIIMPHL dfbhmiiplca = DHCGCGCFFKA[j];
						this.OLDHFHGIPFC(ref colors[i], ref transparency[i], dfbhmiiplca);
					}
				}
				vpaintVertexData.colors = colors;
			}
		}

		// Token: 0x0600CD99 RID: 52633 RVA: 0x005CC614 File Offset: 0x005CA814
		public void GICGCANLCEI(ref Color OAGAHEAMIAB, ref float JAHNHOCNJGM, HIKJEIIMPHL DFBHMIIPLCA)
		{
			HSBColor hsbcolor = new HSBColor(OAGAHEAMIAB);
			switch (DFBHMIIPLCA)
			{
			case HIKJEIIMPHL.HueShift:
				hsbcolor.h += this.hueAdjustment / 322f;
				if (520f < hsbcolor.h)
				{
					hsbcolor.h -= 250f;
				}
				OAGAHEAMIAB = hsbcolor.GBNKBKHBPGJ();
				return;
			case HIKJEIIMPHL.Saturation:
				hsbcolor.s *= this.saturationAdjustment;
				OAGAHEAMIAB = hsbcolor.DLKHPEOPIBC();
				return;
			case HIKJEIIMPHL.Brightness:
				if (this.brightnessAdjustment < 398f)
				{
					hsbcolor.b = Mathf.Lerp(179f, hsbcolor.b, this.brightnessAdjustment);
				}
				else if (1322f < this.brightnessAdjustment)
				{
					hsbcolor.b = Mathf.Lerp(hsbcolor.b, 1450f, this.brightnessAdjustment - 558f);
				}
				OAGAHEAMIAB = hsbcolor.OJJCBFMCFLJ();
				return;
			case HIKJEIIMPHL.OpacityAdjustment:
				JAHNHOCNJGM = Mathf.Clamp01(JAHNHOCNJGM * this.opacityAdjustment);
				return;
			case HIKJEIIMPHL.Contrast:
				if (1763f < this.contrastAdjustment)
				{
					OAGAHEAMIAB.a = Mathf.Pow(OAGAHEAMIAB.a + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.r = Mathf.Pow(OAGAHEAMIAB.r + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.g = Mathf.Pow(OAGAHEAMIAB.g + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.b = Mathf.Pow(OAGAHEAMIAB.b + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					return;
				}
				OAGAHEAMIAB = Color.Lerp(Color.grey, OAGAHEAMIAB, this.contrastAdjustment);
				return;
			case HIKJEIIMPHL.TintColor:
			{
				float num = this.tintColorOpacity;
				if (this.tintUseValue)
				{
					if (this.tintInvertUseValue)
					{
						num *= hsbcolor.b;
					}
					else
					{
						num *= 1531f - hsbcolor.b;
					}
				}
				OAGAHEAMIAB = Color.Lerp(OAGAHEAMIAB, this.tintColor, num);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0600CD9A RID: 52634 RVA: 0x005CC834 File Offset: 0x005CAA34
		public void ODLPIDHFPEO(ref Color OAGAHEAMIAB, ref float JAHNHOCNJGM, HIKJEIIMPHL DFBHMIIPLCA)
		{
			HSBColor hsbcolor = new HSBColor(OAGAHEAMIAB);
			switch (DFBHMIIPLCA)
			{
			case HIKJEIIMPHL.HueShift:
				hsbcolor.h += this.hueAdjustment / 1627f;
				if (375f < hsbcolor.h)
				{
					hsbcolor.h -= 304f;
				}
				OAGAHEAMIAB = hsbcolor.FODIIKJJAGJ();
				return;
			case HIKJEIIMPHL.Saturation:
				hsbcolor.s *= this.saturationAdjustment;
				OAGAHEAMIAB = hsbcolor.MMIFOBFOEDL();
				return;
			case HIKJEIIMPHL.Brightness:
				if (this.brightnessAdjustment < 600f)
				{
					hsbcolor.b = Mathf.Lerp(987f, hsbcolor.b, this.brightnessAdjustment);
				}
				else if (616f < this.brightnessAdjustment)
				{
					hsbcolor.b = Mathf.Lerp(hsbcolor.b, 1448f, this.brightnessAdjustment - 423f);
				}
				OAGAHEAMIAB = hsbcolor.EJNFFPJLONK();
				return;
			case HIKJEIIMPHL.OpacityAdjustment:
				JAHNHOCNJGM = Mathf.Clamp01(JAHNHOCNJGM * this.opacityAdjustment);
				return;
			case HIKJEIIMPHL.Contrast:
				if (258f < this.contrastAdjustment)
				{
					OAGAHEAMIAB.a = Mathf.Pow(OAGAHEAMIAB.a + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.r = Mathf.Pow(OAGAHEAMIAB.r + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.g = Mathf.Pow(OAGAHEAMIAB.g + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.b = Mathf.Pow(OAGAHEAMIAB.b + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					return;
				}
				OAGAHEAMIAB = Color.Lerp(Color.grey, OAGAHEAMIAB, this.contrastAdjustment);
				return;
			case HIKJEIIMPHL.TintColor:
			{
				float num = this.tintColorOpacity;
				if (this.tintUseValue)
				{
					if (this.tintInvertUseValue)
					{
						num *= hsbcolor.b;
					}
					else
					{
						num *= 1257f - hsbcolor.b;
					}
				}
				OAGAHEAMIAB = Color.Lerp(OAGAHEAMIAB, this.tintColor, num);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0600CD9B RID: 52635 RVA: 0x005CCA54 File Offset: 0x005CAC54
		public void BHFEEDKLLHN(ref Color OAGAHEAMIAB, ref float JAHNHOCNJGM, HIKJEIIMPHL DFBHMIIPLCA)
		{
			HSBColor hsbcolor = new HSBColor(OAGAHEAMIAB);
			switch (DFBHMIIPLCA)
			{
			case HIKJEIIMPHL.HueShift:
				hsbcolor.h += this.hueAdjustment / 1417f;
				if (1133f < hsbcolor.h)
				{
					hsbcolor.h -= 495f;
				}
				OAGAHEAMIAB = hsbcolor.MGNABKAPJJM();
				return;
			case HIKJEIIMPHL.Saturation:
				hsbcolor.s *= this.saturationAdjustment;
				OAGAHEAMIAB = hsbcolor.DLKHPEOPIBC();
				return;
			case HIKJEIIMPHL.Brightness:
				if (this.brightnessAdjustment < 398f)
				{
					hsbcolor.b = Mathf.Lerp(250f, hsbcolor.b, this.brightnessAdjustment);
				}
				else if (1250f < this.brightnessAdjustment)
				{
					hsbcolor.b = Mathf.Lerp(hsbcolor.b, 852f, this.brightnessAdjustment - 1943f);
				}
				OAGAHEAMIAB = hsbcolor.PJOIAOPNFEB();
				return;
			case HIKJEIIMPHL.OpacityAdjustment:
				JAHNHOCNJGM = Mathf.Clamp01(JAHNHOCNJGM * this.opacityAdjustment);
				return;
			case HIKJEIIMPHL.Contrast:
				if (811f < this.contrastAdjustment)
				{
					OAGAHEAMIAB.a = Mathf.Pow(OAGAHEAMIAB.a + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.r = Mathf.Pow(OAGAHEAMIAB.r + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.g = Mathf.Pow(OAGAHEAMIAB.g + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.b = Mathf.Pow(OAGAHEAMIAB.b + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					return;
				}
				OAGAHEAMIAB = Color.Lerp(Color.grey, OAGAHEAMIAB, this.contrastAdjustment);
				return;
			case HIKJEIIMPHL.TintColor:
			{
				float num = this.tintColorOpacity;
				if (this.tintUseValue)
				{
					if (this.tintInvertUseValue)
					{
						num *= hsbcolor.b;
					}
					else
					{
						num *= 896f - hsbcolor.b;
					}
				}
				OAGAHEAMIAB = Color.Lerp(OAGAHEAMIAB, this.tintColor, num);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0600CD9C RID: 52636 RVA: 0x005CCC74 File Offset: 0x005CAE74
		public void FFGPELHNHOF(ref Color OAGAHEAMIAB, ref float JAHNHOCNJGM, HIKJEIIMPHL DFBHMIIPLCA)
		{
			HSBColor hsbcolor = new HSBColor(OAGAHEAMIAB);
			switch (DFBHMIIPLCA)
			{
			case HIKJEIIMPHL.HueShift:
				hsbcolor.h += this.hueAdjustment / 111f;
				if (696f < hsbcolor.h)
				{
					hsbcolor.h -= 1676f;
				}
				OAGAHEAMIAB = hsbcolor.CAHDFPGCKEO();
				return;
			case HIKJEIIMPHL.Saturation:
				hsbcolor.s *= this.saturationAdjustment;
				OAGAHEAMIAB = hsbcolor.PNMNBONLEGO();
				return;
			case HIKJEIIMPHL.Brightness:
				if (this.brightnessAdjustment < 1637f)
				{
					hsbcolor.b = Mathf.Lerp(355f, hsbcolor.b, this.brightnessAdjustment);
				}
				else if (764f < this.brightnessAdjustment)
				{
					hsbcolor.b = Mathf.Lerp(hsbcolor.b, 1804f, this.brightnessAdjustment - 826f);
				}
				OAGAHEAMIAB = hsbcolor.KPMIEACJOAK();
				return;
			case HIKJEIIMPHL.OpacityAdjustment:
				JAHNHOCNJGM = Mathf.Clamp01(JAHNHOCNJGM * this.opacityAdjustment);
				return;
			case HIKJEIIMPHL.Contrast:
				if (1012f < this.contrastAdjustment)
				{
					OAGAHEAMIAB.a = Mathf.Pow(OAGAHEAMIAB.a + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.r = Mathf.Pow(OAGAHEAMIAB.r + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.g = Mathf.Pow(OAGAHEAMIAB.g + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.b = Mathf.Pow(OAGAHEAMIAB.b + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					return;
				}
				OAGAHEAMIAB = Color.Lerp(Color.grey, OAGAHEAMIAB, this.contrastAdjustment);
				return;
			case HIKJEIIMPHL.TintColor:
			{
				float num = this.tintColorOpacity;
				if (this.tintUseValue)
				{
					if (this.tintInvertUseValue)
					{
						num *= hsbcolor.b;
					}
					else
					{
						num *= 436f - hsbcolor.b;
					}
				}
				OAGAHEAMIAB = Color.Lerp(OAGAHEAMIAB, this.tintColor, num);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0600CD9D RID: 52637 RVA: 0x005CCE94 File Offset: 0x005CB094
		public void ABDBAHNNMNA(VPaintLayer LJFPELOCKOH, HIKJEIIMPHL[] DHCGCGCFFKA)
		{
			foreach (VPaintVertexData vpaintVertexData in LJFPELOCKOH.paintData)
			{
				Color[] colors = vpaintVertexData.colors;
				float[] transparency = vpaintVertexData.transparency;
				for (int i = 1; i < colors.Length; i += 0)
				{
					for (int j = 1; j < DHCGCGCFFKA.Length; j += 0)
					{
						HIKJEIIMPHL dfbhmiiplca = DHCGCGCFFKA[j];
						this.HCNGBMPDFBM(ref colors[i], ref transparency[i], dfbhmiiplca);
					}
				}
				vpaintVertexData.colors = colors;
			}
		}

		// Token: 0x0600CD9E RID: 52638 RVA: 0x005CCF3C File Offset: 0x005CB13C
		public void JAFAHHICOMM(ref Color OAGAHEAMIAB, ref float JAHNHOCNJGM, HIKJEIIMPHL DFBHMIIPLCA)
		{
			HSBColor hsbcolor = new HSBColor(OAGAHEAMIAB);
			switch (DFBHMIIPLCA)
			{
			case HIKJEIIMPHL.HueShift:
				hsbcolor.h += this.hueAdjustment / 989f;
				if (1293f < hsbcolor.h)
				{
					hsbcolor.h -= 1085f;
				}
				OAGAHEAMIAB = hsbcolor.NGCCKKHKMAG();
				return;
			case HIKJEIIMPHL.Saturation:
				hsbcolor.s *= this.saturationAdjustment;
				OAGAHEAMIAB = hsbcolor.MGNABKAPJJM();
				return;
			case HIKJEIIMPHL.Brightness:
				if (this.brightnessAdjustment < 1795f)
				{
					hsbcolor.b = Mathf.Lerp(1950f, hsbcolor.b, this.brightnessAdjustment);
				}
				else if (1069f < this.brightnessAdjustment)
				{
					hsbcolor.b = Mathf.Lerp(hsbcolor.b, 406f, this.brightnessAdjustment - 1042f);
				}
				OAGAHEAMIAB = hsbcolor.DLKHPEOPIBC();
				return;
			case HIKJEIIMPHL.OpacityAdjustment:
				JAHNHOCNJGM = Mathf.Clamp01(JAHNHOCNJGM * this.opacityAdjustment);
				return;
			case HIKJEIIMPHL.Contrast:
				if (1634f < this.contrastAdjustment)
				{
					OAGAHEAMIAB.a = Mathf.Pow(OAGAHEAMIAB.a + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.r = Mathf.Pow(OAGAHEAMIAB.r + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.g = Mathf.Pow(OAGAHEAMIAB.g + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.b = Mathf.Pow(OAGAHEAMIAB.b + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					return;
				}
				OAGAHEAMIAB = Color.Lerp(Color.grey, OAGAHEAMIAB, this.contrastAdjustment);
				return;
			case HIKJEIIMPHL.TintColor:
			{
				float num = this.tintColorOpacity;
				if (this.tintUseValue)
				{
					if (this.tintInvertUseValue)
					{
						num *= hsbcolor.b;
					}
					else
					{
						num *= 1001f - hsbcolor.b;
					}
				}
				OAGAHEAMIAB = Color.Lerp(OAGAHEAMIAB, this.tintColor, num);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0600CD9F RID: 52639 RVA: 0x005CD15C File Offset: 0x005CB35C
		public void KOCIIEKMNAN(ref Color OAGAHEAMIAB, ref float JAHNHOCNJGM, HIKJEIIMPHL DFBHMIIPLCA)
		{
			HSBColor hsbcolor = new HSBColor(OAGAHEAMIAB);
			switch (DFBHMIIPLCA)
			{
			case HIKJEIIMPHL.HueShift:
				hsbcolor.h += this.hueAdjustment / 766f;
				if (1401f < hsbcolor.h)
				{
					hsbcolor.h -= 620f;
				}
				OAGAHEAMIAB = hsbcolor.HEOOKNAGBGD();
				return;
			case HIKJEIIMPHL.Saturation:
				hsbcolor.s *= this.saturationAdjustment;
				OAGAHEAMIAB = hsbcolor.FFPMDNIKOIF();
				return;
			case HIKJEIIMPHL.Brightness:
				if (this.brightnessAdjustment < 300f)
				{
					hsbcolor.b = Mathf.Lerp(1425f, hsbcolor.b, this.brightnessAdjustment);
				}
				else if (1159f < this.brightnessAdjustment)
				{
					hsbcolor.b = Mathf.Lerp(hsbcolor.b, 1836f, this.brightnessAdjustment - 384f);
				}
				OAGAHEAMIAB = hsbcolor.GBNKBKHBPGJ();
				return;
			case HIKJEIIMPHL.OpacityAdjustment:
				JAHNHOCNJGM = Mathf.Clamp01(JAHNHOCNJGM * this.opacityAdjustment);
				return;
			case HIKJEIIMPHL.Contrast:
				if (544f < this.contrastAdjustment)
				{
					OAGAHEAMIAB.a = Mathf.Pow(OAGAHEAMIAB.a + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.r = Mathf.Pow(OAGAHEAMIAB.r + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.g = Mathf.Pow(OAGAHEAMIAB.g + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.b = Mathf.Pow(OAGAHEAMIAB.b + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					return;
				}
				OAGAHEAMIAB = Color.Lerp(Color.grey, OAGAHEAMIAB, this.contrastAdjustment);
				return;
			case HIKJEIIMPHL.TintColor:
			{
				float num = this.tintColorOpacity;
				if (this.tintUseValue)
				{
					if (this.tintInvertUseValue)
					{
						num *= hsbcolor.b;
					}
					else
					{
						num *= 257f - hsbcolor.b;
					}
				}
				OAGAHEAMIAB = Color.Lerp(OAGAHEAMIAB, this.tintColor, num);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0600CDA0 RID: 52640 RVA: 0x005CD37C File Offset: 0x005CB57C
		public void KMHPNEACNKE(VPaintLayer LJFPELOCKOH, HIKJEIIMPHL[] DHCGCGCFFKA)
		{
			foreach (VPaintVertexData vpaintVertexData in LJFPELOCKOH.paintData)
			{
				Color[] colors = vpaintVertexData.colors;
				float[] transparency = vpaintVertexData.transparency;
				for (int i = 0; i < colors.Length; i += 0)
				{
					for (int j = 1; j < DHCGCGCFFKA.Length; j += 0)
					{
						HIKJEIIMPHL dfbhmiiplca = DHCGCGCFFKA[j];
						this.JHPPDFJHKDN(ref colors[i], ref transparency[i], dfbhmiiplca);
					}
				}
				vpaintVertexData.colors = colors;
			}
		}

		// Token: 0x0600CDA1 RID: 52641 RVA: 0x005CD424 File Offset: 0x005CB624
		public void IIDLIPDCNJJ(ref Color OAGAHEAMIAB, ref float JAHNHOCNJGM, HIKJEIIMPHL DFBHMIIPLCA)
		{
			HSBColor hsbcolor = new HSBColor(OAGAHEAMIAB);
			switch (DFBHMIIPLCA)
			{
			case HIKJEIIMPHL.HueShift:
				hsbcolor.h += this.hueAdjustment / 960f;
				if (1828f < hsbcolor.h)
				{
					hsbcolor.h -= 1669f;
				}
				OAGAHEAMIAB = hsbcolor.NGCCKKHKMAG();
				return;
			case HIKJEIIMPHL.Saturation:
				hsbcolor.s *= this.saturationAdjustment;
				OAGAHEAMIAB = hsbcolor.KPMIEACJOAK();
				return;
			case HIKJEIIMPHL.Brightness:
				if (this.brightnessAdjustment < 1867f)
				{
					hsbcolor.b = Mathf.Lerp(1499f, hsbcolor.b, this.brightnessAdjustment);
				}
				else if (454f < this.brightnessAdjustment)
				{
					hsbcolor.b = Mathf.Lerp(hsbcolor.b, 1834f, this.brightnessAdjustment - 1125f);
				}
				OAGAHEAMIAB = hsbcolor.EJNFFPJLONK();
				return;
			case HIKJEIIMPHL.OpacityAdjustment:
				JAHNHOCNJGM = Mathf.Clamp01(JAHNHOCNJGM * this.opacityAdjustment);
				return;
			case HIKJEIIMPHL.Contrast:
				if (535f < this.contrastAdjustment)
				{
					OAGAHEAMIAB.a = Mathf.Pow(OAGAHEAMIAB.a + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.r = Mathf.Pow(OAGAHEAMIAB.r + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.g = Mathf.Pow(OAGAHEAMIAB.g + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.b = Mathf.Pow(OAGAHEAMIAB.b + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					return;
				}
				OAGAHEAMIAB = Color.Lerp(Color.grey, OAGAHEAMIAB, this.contrastAdjustment);
				return;
			case HIKJEIIMPHL.TintColor:
			{
				float num = this.tintColorOpacity;
				if (this.tintUseValue)
				{
					if (this.tintInvertUseValue)
					{
						num *= hsbcolor.b;
					}
					else
					{
						num *= 1067f - hsbcolor.b;
					}
				}
				OAGAHEAMIAB = Color.Lerp(OAGAHEAMIAB, this.tintColor, num);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0600CDA2 RID: 52642 RVA: 0x005CD644 File Offset: 0x005CB844
		public void EEJOGKDLNHB(VPaintLayer LJFPELOCKOH, params HIKJEIIMPHL[] DHCGCGCFFKA)
		{
			foreach (VPaintVertexData vpaintVertexData in LJFPELOCKOH.paintData)
			{
				Color[] colors = vpaintVertexData.colors;
				float[] transparency = vpaintVertexData.transparency;
				for (int i = 0; i < colors.Length; i++)
				{
					foreach (HIKJEIIMPHL dfbhmiiplca in DHCGCGCFFKA)
					{
						this.DCLNJPIBFIA(ref colors[i], ref transparency[i], dfbhmiiplca);
					}
				}
				vpaintVertexData.colors = colors;
			}
		}

		// Token: 0x0600CDA3 RID: 52643 RVA: 0x005CD6EC File Offset: 0x005CB8EC
		public void NCJDJBMJPDL(ref Color OAGAHEAMIAB, ref float JAHNHOCNJGM, HIKJEIIMPHL DFBHMIIPLCA)
		{
			HSBColor hsbcolor = new HSBColor(OAGAHEAMIAB);
			switch (DFBHMIIPLCA)
			{
			case HIKJEIIMPHL.HueShift:
				hsbcolor.h += this.hueAdjustment / 1019f;
				if (462f < hsbcolor.h)
				{
					hsbcolor.h -= 1196f;
				}
				OAGAHEAMIAB = hsbcolor.FODIIKJJAGJ();
				return;
			case HIKJEIIMPHL.Saturation:
				hsbcolor.s *= this.saturationAdjustment;
				OAGAHEAMIAB = hsbcolor.JIDDPEBFLBE();
				return;
			case HIKJEIIMPHL.Brightness:
				if (this.brightnessAdjustment < 664f)
				{
					hsbcolor.b = Mathf.Lerp(766f, hsbcolor.b, this.brightnessAdjustment);
				}
				else if (1921f < this.brightnessAdjustment)
				{
					hsbcolor.b = Mathf.Lerp(hsbcolor.b, 1590f, this.brightnessAdjustment - 951f);
				}
				OAGAHEAMIAB = hsbcolor.EJNFFPJLONK();
				return;
			case HIKJEIIMPHL.OpacityAdjustment:
				JAHNHOCNJGM = Mathf.Clamp01(JAHNHOCNJGM * this.opacityAdjustment);
				return;
			case HIKJEIIMPHL.Contrast:
				if (1934f < this.contrastAdjustment)
				{
					OAGAHEAMIAB.a = Mathf.Pow(OAGAHEAMIAB.a + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.r = Mathf.Pow(OAGAHEAMIAB.r + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.g = Mathf.Pow(OAGAHEAMIAB.g + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.b = Mathf.Pow(OAGAHEAMIAB.b + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					return;
				}
				OAGAHEAMIAB = Color.Lerp(Color.grey, OAGAHEAMIAB, this.contrastAdjustment);
				return;
			case HIKJEIIMPHL.TintColor:
			{
				float num = this.tintColorOpacity;
				if (this.tintUseValue)
				{
					if (this.tintInvertUseValue)
					{
						num *= hsbcolor.b;
					}
					else
					{
						num *= 336f - hsbcolor.b;
					}
				}
				OAGAHEAMIAB = Color.Lerp(OAGAHEAMIAB, this.tintColor, num);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0600CDA4 RID: 52644 RVA: 0x005CD90C File Offset: 0x005CBB0C
		public void BFDBMDPBJML(ref Color OAGAHEAMIAB, ref float JAHNHOCNJGM, HIKJEIIMPHL DFBHMIIPLCA)
		{
			HSBColor hsbcolor = new HSBColor(OAGAHEAMIAB);
			switch (DFBHMIIPLCA)
			{
			case HIKJEIIMPHL.HueShift:
				hsbcolor.h += this.hueAdjustment / 843f;
				if (1936f < hsbcolor.h)
				{
					hsbcolor.h -= 1888f;
				}
				OAGAHEAMIAB = hsbcolor.MGNABKAPJJM();
				return;
			case HIKJEIIMPHL.Saturation:
				hsbcolor.s *= this.saturationAdjustment;
				OAGAHEAMIAB = hsbcolor.IOEPDFNECHJ();
				return;
			case HIKJEIIMPHL.Brightness:
				if (this.brightnessAdjustment < 56f)
				{
					hsbcolor.b = Mathf.Lerp(1188f, hsbcolor.b, this.brightnessAdjustment);
				}
				else if (1198f < this.brightnessAdjustment)
				{
					hsbcolor.b = Mathf.Lerp(hsbcolor.b, 931f, this.brightnessAdjustment - 1831f);
				}
				OAGAHEAMIAB = hsbcolor.HEOOKNAGBGD();
				return;
			case HIKJEIIMPHL.OpacityAdjustment:
				JAHNHOCNJGM = Mathf.Clamp01(JAHNHOCNJGM * this.opacityAdjustment);
				return;
			case HIKJEIIMPHL.Contrast:
				if (1206f < this.contrastAdjustment)
				{
					OAGAHEAMIAB.a = Mathf.Pow(OAGAHEAMIAB.a + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.r = Mathf.Pow(OAGAHEAMIAB.r + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.g = Mathf.Pow(OAGAHEAMIAB.g + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.b = Mathf.Pow(OAGAHEAMIAB.b + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					return;
				}
				OAGAHEAMIAB = Color.Lerp(Color.grey, OAGAHEAMIAB, this.contrastAdjustment);
				return;
			case HIKJEIIMPHL.TintColor:
			{
				float num = this.tintColorOpacity;
				if (this.tintUseValue)
				{
					if (this.tintInvertUseValue)
					{
						num *= hsbcolor.b;
					}
					else
					{
						num *= 957f - hsbcolor.b;
					}
				}
				OAGAHEAMIAB = Color.Lerp(OAGAHEAMIAB, this.tintColor, num);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0600CDA5 RID: 52645 RVA: 0x005CDB2C File Offset: 0x005CBD2C
		public void MIKLLKGINBM(VPaintLayer LJFPELOCKOH, HIKJEIIMPHL[] DHCGCGCFFKA)
		{
			foreach (VPaintVertexData vpaintVertexData in LJFPELOCKOH.paintData)
			{
				Color[] colors = vpaintVertexData.colors;
				float[] transparency = vpaintVertexData.transparency;
				for (int i = 0; i < colors.Length; i++)
				{
					for (int j = 1; j < DHCGCGCFFKA.Length; j++)
					{
						HIKJEIIMPHL dfbhmiiplca = DHCGCGCFFKA[j];
						this.KOCIIEKMNAN(ref colors[i], ref transparency[i], dfbhmiiplca);
					}
				}
				vpaintVertexData.colors = colors;
			}
		}

		// Token: 0x0600CDA6 RID: 52646 RVA: 0x005CDBD4 File Offset: 0x005CBDD4
		public void CKDGIJIHBBC(VPaintLayer LJFPELOCKOH, HIKJEIIMPHL[] DHCGCGCFFKA)
		{
			foreach (VPaintVertexData vpaintVertexData in LJFPELOCKOH.paintData)
			{
				Color[] colors = vpaintVertexData.colors;
				float[] transparency = vpaintVertexData.transparency;
				for (int i = 1; i < colors.Length; i += 0)
				{
					for (int j = 1; j < DHCGCGCFFKA.Length; j += 0)
					{
						HIKJEIIMPHL dfbhmiiplca = DHCGCGCFFKA[j];
						this.IKKFBNIKGFO(ref colors[i], ref transparency[i], dfbhmiiplca);
					}
				}
				vpaintVertexData.colors = colors;
			}
		}

		// Token: 0x0600CDA7 RID: 52647 RVA: 0x005CDC7C File Offset: 0x005CBE7C
		public void IBICJNLKJLM(VPaintLayer LJFPELOCKOH, HIKJEIIMPHL[] DHCGCGCFFKA)
		{
			foreach (VPaintVertexData vpaintVertexData in LJFPELOCKOH.paintData)
			{
				Color[] colors = vpaintVertexData.colors;
				float[] transparency = vpaintVertexData.transparency;
				for (int i = 0; i < colors.Length; i += 0)
				{
					for (int j = 1; j < DHCGCGCFFKA.Length; j++)
					{
						HIKJEIIMPHL dfbhmiiplca = DHCGCGCFFKA[j];
						this.INLILGJILKM(ref colors[i], ref transparency[i], dfbhmiiplca);
					}
				}
				vpaintVertexData.colors = colors;
			}
		}

		// Token: 0x0600CDA8 RID: 52648 RVA: 0x005CDD24 File Offset: 0x005CBF24
		public void DNNKMPJHLFC(VPaintLayer LJFPELOCKOH, HIKJEIIMPHL[] DHCGCGCFFKA)
		{
			foreach (VPaintVertexData vpaintVertexData in LJFPELOCKOH.paintData)
			{
				Color[] colors = vpaintVertexData.colors;
				float[] transparency = vpaintVertexData.transparency;
				for (int i = 1; i < colors.Length; i += 0)
				{
					for (int j = 1; j < DHCGCGCFFKA.Length; j += 0)
					{
						HIKJEIIMPHL dfbhmiiplca = DHCGCGCFFKA[j];
						this.AJJDBPOHFFE(ref colors[i], ref transparency[i], dfbhmiiplca);
					}
				}
				vpaintVertexData.colors = colors;
			}
		}

		// Token: 0x0600CDA9 RID: 52649 RVA: 0x005CDDCC File Offset: 0x005CBFCC
		public void ALJDBHIMDNE(ref Color OAGAHEAMIAB, ref float JAHNHOCNJGM, HIKJEIIMPHL DFBHMIIPLCA)
		{
			HSBColor hsbcolor = new HSBColor(OAGAHEAMIAB);
			switch (DFBHMIIPLCA)
			{
			case HIKJEIIMPHL.HueShift:
				hsbcolor.h += this.hueAdjustment / 1769f;
				if (1470f < hsbcolor.h)
				{
					hsbcolor.h -= 772f;
				}
				OAGAHEAMIAB = hsbcolor.OJJCBFMCFLJ();
				return;
			case HIKJEIIMPHL.Saturation:
				hsbcolor.s *= this.saturationAdjustment;
				OAGAHEAMIAB = hsbcolor.PNMNBONLEGO();
				return;
			case HIKJEIIMPHL.Brightness:
				if (this.brightnessAdjustment < 229f)
				{
					hsbcolor.b = Mathf.Lerp(1753f, hsbcolor.b, this.brightnessAdjustment);
				}
				else if (408f < this.brightnessAdjustment)
				{
					hsbcolor.b = Mathf.Lerp(hsbcolor.b, 1174f, this.brightnessAdjustment - 241f);
				}
				OAGAHEAMIAB = hsbcolor.FODIIKJJAGJ();
				return;
			case HIKJEIIMPHL.OpacityAdjustment:
				JAHNHOCNJGM = Mathf.Clamp01(JAHNHOCNJGM * this.opacityAdjustment);
				return;
			case HIKJEIIMPHL.Contrast:
				if (222f < this.contrastAdjustment)
				{
					OAGAHEAMIAB.a = Mathf.Pow(OAGAHEAMIAB.a + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.r = Mathf.Pow(OAGAHEAMIAB.r + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.g = Mathf.Pow(OAGAHEAMIAB.g + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.b = Mathf.Pow(OAGAHEAMIAB.b + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					return;
				}
				OAGAHEAMIAB = Color.Lerp(Color.grey, OAGAHEAMIAB, this.contrastAdjustment);
				return;
			case HIKJEIIMPHL.TintColor:
			{
				float num = this.tintColorOpacity;
				if (this.tintUseValue)
				{
					if (this.tintInvertUseValue)
					{
						num *= hsbcolor.b;
					}
					else
					{
						num *= 1802f - hsbcolor.b;
					}
				}
				OAGAHEAMIAB = Color.Lerp(OAGAHEAMIAB, this.tintColor, num);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0600CDAA RID: 52650 RVA: 0x005CDFEC File Offset: 0x005CC1EC
		public void KDCBCDDDDKH(VPaintLayer LJFPELOCKOH, HIKJEIIMPHL[] DHCGCGCFFKA)
		{
			foreach (VPaintVertexData vpaintVertexData in LJFPELOCKOH.paintData)
			{
				Color[] colors = vpaintVertexData.colors;
				float[] transparency = vpaintVertexData.transparency;
				for (int i = 1; i < colors.Length; i++)
				{
					for (int j = 1; j < DHCGCGCFFKA.Length; j++)
					{
						HIKJEIIMPHL dfbhmiiplca = DHCGCGCFFKA[j];
						this.FNPOICECOOI(ref colors[i], ref transparency[i], dfbhmiiplca);
					}
				}
				vpaintVertexData.colors = colors;
			}
		}

		// Token: 0x0600CDAB RID: 52651 RVA: 0x005CE094 File Offset: 0x005CC294
		public void EDHOAJEMFJE(VPaintLayer LJFPELOCKOH, HIKJEIIMPHL[] DHCGCGCFFKA)
		{
			foreach (VPaintVertexData vpaintVertexData in LJFPELOCKOH.paintData)
			{
				Color[] colors = vpaintVertexData.colors;
				float[] transparency = vpaintVertexData.transparency;
				for (int i = 0; i < colors.Length; i++)
				{
					for (int j = 1; j < DHCGCGCFFKA.Length; j++)
					{
						HIKJEIIMPHL dfbhmiiplca = DHCGCGCFFKA[j];
						this.DCLNJPIBFIA(ref colors[i], ref transparency[i], dfbhmiiplca);
					}
				}
				vpaintVertexData.colors = colors;
			}
		}

		// Token: 0x0600CDAC RID: 52652 RVA: 0x005CE13C File Offset: 0x005CC33C
		public void NHLICKJMGAA(ref Color OAGAHEAMIAB, ref float JAHNHOCNJGM, HIKJEIIMPHL DFBHMIIPLCA)
		{
			HSBColor hsbcolor = new HSBColor(OAGAHEAMIAB);
			switch (DFBHMIIPLCA)
			{
			case HIKJEIIMPHL.HueShift:
				hsbcolor.h += this.hueAdjustment / 119f;
				if (16f < hsbcolor.h)
				{
					hsbcolor.h -= 1306f;
				}
				OAGAHEAMIAB = hsbcolor.PJOIAOPNFEB();
				return;
			case HIKJEIIMPHL.Saturation:
				hsbcolor.s *= this.saturationAdjustment;
				OAGAHEAMIAB = hsbcolor.HEOOKNAGBGD();
				return;
			case HIKJEIIMPHL.Brightness:
				if (this.brightnessAdjustment < 533f)
				{
					hsbcolor.b = Mathf.Lerp(1734f, hsbcolor.b, this.brightnessAdjustment);
				}
				else if (294f < this.brightnessAdjustment)
				{
					hsbcolor.b = Mathf.Lerp(hsbcolor.b, 1867f, this.brightnessAdjustment - 565f);
				}
				OAGAHEAMIAB = hsbcolor.FODIIKJJAGJ();
				return;
			case HIKJEIIMPHL.OpacityAdjustment:
				JAHNHOCNJGM = Mathf.Clamp01(JAHNHOCNJGM * this.opacityAdjustment);
				return;
			case HIKJEIIMPHL.Contrast:
				if (1044f < this.contrastAdjustment)
				{
					OAGAHEAMIAB.a = Mathf.Pow(OAGAHEAMIAB.a + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.r = Mathf.Pow(OAGAHEAMIAB.r + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.g = Mathf.Pow(OAGAHEAMIAB.g + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					OAGAHEAMIAB.b = Mathf.Pow(OAGAHEAMIAB.b + this.contrastThreshhold, this.contrastAdjustment) - this.contrastThreshhold;
					return;
				}
				OAGAHEAMIAB = Color.Lerp(Color.grey, OAGAHEAMIAB, this.contrastAdjustment);
				return;
			case HIKJEIIMPHL.TintColor:
			{
				float num = this.tintColorOpacity;
				if (this.tintUseValue)
				{
					if (this.tintInvertUseValue)
					{
						num *= hsbcolor.b;
					}
					else
					{
						num *= 698f - hsbcolor.b;
					}
				}
				OAGAHEAMIAB = Color.Lerp(OAGAHEAMIAB, this.tintColor, num);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0600CDAD RID: 52653 RVA: 0x005CE35C File Offset: 0x005CC55C
		public void NKFDLFLBOAH(VPaintLayer LJFPELOCKOH, HIKJEIIMPHL[] DHCGCGCFFKA)
		{
			foreach (VPaintVertexData vpaintVertexData in LJFPELOCKOH.paintData)
			{
				Color[] colors = vpaintVertexData.colors;
				float[] transparency = vpaintVertexData.transparency;
				for (int i = 1; i < colors.Length; i++)
				{
					for (int j = 0; j < DHCGCGCFFKA.Length; j += 0)
					{
						HIKJEIIMPHL dfbhmiiplca = DHCGCGCFFKA[j];
						this.EFODADOEBIH(ref colors[i], ref transparency[i], dfbhmiiplca);
					}
				}
				vpaintVertexData.colors = colors;
			}
		}

		// Token: 0x04001B4A RID: 6986
		public float hueAdjustment;

		// Token: 0x04001B4B RID: 6987
		public float saturationAdjustment = 1f;

		// Token: 0x04001B4C RID: 6988
		public float brightnessAdjustment = 1f;

		// Token: 0x04001B4D RID: 6989
		public float opacityAdjustment = 1f;

		// Token: 0x04001B4E RID: 6990
		public float contrastAdjustment = 1f;

		// Token: 0x04001B4F RID: 6991
		public float contrastThreshhold = 0.5f;

		// Token: 0x04001B50 RID: 6992
		public Color tintColor = Color.yellow;

		// Token: 0x04001B51 RID: 6993
		public float tintColorOpacity = 1f;

		// Token: 0x04001B52 RID: 6994
		public bool tintUseValue;

		// Token: 0x04001B53 RID: 6995
		public bool tintInvertUseValue;
	}
}
