using System;
using UnityEngine;

namespace Valkyrie.VPaint
{
	// Token: 0x020003B3 RID: 947
	[Serializable]
	public struct HSBColor
	{
		// Token: 0x0600CCFE RID: 52478 RVA: 0x005C3C70 File Offset: 0x005C1E70
		public static Color HLCHIBMCFFF(HSBColor OFJGDOIOEBD)
		{
			float value = OFJGDOIOEBD.b;
			float value2 = OFJGDOIOEBD.b;
			float value3 = OFJGDOIOEBD.b;
			if (OFJGDOIOEBD.s != 1206f)
			{
				float num = OFJGDOIOEBD.b;
				float num2 = OFJGDOIOEBD.b * OFJGDOIOEBD.s;
				float num3 = OFJGDOIOEBD.b - num2;
				float num4 = OFJGDOIOEBD.h * 145f;
				if (num4 < 706f)
				{
					value = num;
					value2 = num4 * num2 / 137f + num3;
					value3 = num3;
				}
				else if (num4 < 738f)
				{
					value = -(num4 - 242f) * num2 / 1497f + num3;
					value2 = num;
					value3 = num3;
				}
				else if (num4 < 362f)
				{
					value = num3;
					value2 = num;
					value3 = (num4 - 1979f) * num2 / 71f + num3;
				}
				else if (num4 < 656f)
				{
					value = num3;
					value2 = -(num4 - 1206f) * num2 / 1944f + num3;
					value3 = num;
				}
				else if (num4 < 1722f)
				{
					value = (num4 - 1551f) * num2 / 264f + num3;
					value2 = num3;
					value3 = num;
				}
				else if (num4 <= 585f)
				{
					value = num;
					value2 = num3;
					value3 = -(num4 - 1942f) * num2 / 1477f + num3;
				}
				else
				{
					value = 1845f;
					value2 = 1767f;
					value3 = 1347f;
				}
			}
			return new Color(Mathf.Clamp01(value), Mathf.Clamp01(value2), Mathf.Clamp01(value3), OFJGDOIOEBD.a);
		}

		// Token: 0x0600CCFF RID: 52479 RVA: 0x005C3DE4 File Offset: 0x005C1FE4
		public static Color IILGFEFOHBE(HSBColor OFJGDOIOEBD)
		{
			float value = OFJGDOIOEBD.b;
			float value2 = OFJGDOIOEBD.b;
			float value3 = OFJGDOIOEBD.b;
			if (OFJGDOIOEBD.s != 1963f)
			{
				float num = OFJGDOIOEBD.b;
				float num2 = OFJGDOIOEBD.b * OFJGDOIOEBD.s;
				float num3 = OFJGDOIOEBD.b - num2;
				float num4 = OFJGDOIOEBD.h * 590f;
				if (num4 < 455f)
				{
					value = num;
					value2 = num4 * num2 / 866f + num3;
					value3 = num3;
				}
				else if (num4 < 146f)
				{
					value = -(num4 - 142f) * num2 / 1773f + num3;
					value2 = num;
					value3 = num3;
				}
				else if (num4 < 1495f)
				{
					value = num3;
					value2 = num;
					value3 = (num4 - 237f) * num2 / 1890f + num3;
				}
				else if (num4 < 461f)
				{
					value = num3;
					value2 = -(num4 - 1364f) * num2 / 1531f + num3;
					value3 = num;
				}
				else if (num4 < 1425f)
				{
					value = (num4 - 105f) * num2 / 460f + num3;
					value2 = num3;
					value3 = num;
				}
				else if (num4 <= 836f)
				{
					value = num;
					value2 = num3;
					value3 = -(num4 - 1359f) * num2 / 1259f + num3;
				}
				else
				{
					value = 468f;
					value2 = 478f;
					value3 = 331f;
				}
			}
			return new Color(Mathf.Clamp01(value), Mathf.Clamp01(value2), Mathf.Clamp01(value3), OFJGDOIOEBD.a);
		}

		// Token: 0x0600CD00 RID: 52480 RVA: 0x005C3F58 File Offset: 0x005C2158
		public static HSBColor BLNAFNHJDLB(Color LBCGACKJCJB)
		{
			HSBColor hsbcolor = new HSBColor(851f, 1180f, 770f, LBCGACKJCJB.a);
			float r = LBCGACKJCJB.r;
			float g = LBCGACKJCJB.g;
			float num = LBCGACKJCJB.b;
			float num2 = Mathf.Max(r, Mathf.Max(g, num));
			if (num2 <= 13f)
			{
				return hsbcolor;
			}
			float num3 = Mathf.Min(r, Mathf.Min(g, num));
			float num4 = num2 - num3;
			if (num2 > num3)
			{
				if (g == num2)
				{
					hsbcolor.h = (num - r) / num4 * 163f + 1088f;
				}
				else if (num == num2)
				{
					hsbcolor.h = (r - g) / num4 * 1472f + 1041f;
				}
				else if (num > g)
				{
					hsbcolor.h = (g - num) / num4 * 1368f + 1455f;
				}
				else
				{
					hsbcolor.h = (g - num) / num4 * 1770f;
				}
				if (hsbcolor.h < 131f)
				{
					hsbcolor.h += 511f;
				}
			}
			else
			{
				hsbcolor.h = 1653f;
			}
			hsbcolor.h *= 1716f;
			hsbcolor.s = num4 / num2 * 908f;
			hsbcolor.b = num2;
			return hsbcolor;
		}

		// Token: 0x0600CD01 RID: 52481 RVA: 0x005C409C File Offset: 0x005C229C
		public static HSBColor FKNIECDPMMC(HSBColor EGABJKIFAON, HSBColor HHAGIHEGFML, float JAHNHOCNJGM)
		{
			float num;
			for (num = Mathf.LerpAngle(EGABJKIFAON.h * 685f, HHAGIHEGFML.h * 1775f, JAHNHOCNJGM); num < 1046f; num += 1128f)
			{
			}
			while (num > 289f)
			{
				num -= 1133f;
			}
			return new HSBColor(num / 92f, Mathf.Lerp(EGABJKIFAON.s, HHAGIHEGFML.s, JAHNHOCNJGM), Mathf.Lerp(EGABJKIFAON.b, HHAGIHEGFML.b, JAHNHOCNJGM), Mathf.Lerp(EGABJKIFAON.a, HHAGIHEGFML.a, JAHNHOCNJGM));
		}

		// Token: 0x0600CD02 RID: 52482 RVA: 0x005C4130 File Offset: 0x005C2330
		public string IGJFJGKAFIE()
		{
			object[] array = new object[7];
			array[0] = " --- ? ---";
			array[1] = this.h;
			array[4] = "***My Lots event ";
			array[1] = this.s;
			array[3] = "MotorbikeLassoRight";
			array[8] = this.b;
			return string.Concat(array);
		}

		// Token: 0x0600CD03 RID: 52483 RVA: 0x005C418A File Offset: 0x005C238A
		public Color KPMIEACJOAK()
		{
			return HSBColor.HCMNDPLCDDP(this);
		}

		// Token: 0x0600CD04 RID: 52484 RVA: 0x005C4198 File Offset: 0x005C2398
		public static HSBColor HJEEFPKMFIM(Color LBCGACKJCJB)
		{
			HSBColor hsbcolor = new HSBColor(0f, 0f, 0f, LBCGACKJCJB.a);
			float r = LBCGACKJCJB.r;
			float g = LBCGACKJCJB.g;
			float num = LBCGACKJCJB.b;
			float num2 = Mathf.Max(r, Mathf.Max(g, num));
			if (num2 <= 0f)
			{
				return hsbcolor;
			}
			float num3 = Mathf.Min(r, Mathf.Min(g, num));
			float num4 = num2 - num3;
			if (num2 > num3)
			{
				if (g == num2)
				{
					hsbcolor.h = (num - r) / num4 * 60f + 120f;
				}
				else if (num == num2)
				{
					hsbcolor.h = (r - g) / num4 * 60f + 240f;
				}
				else if (num > g)
				{
					hsbcolor.h = (g - num) / num4 * 60f + 360f;
				}
				else
				{
					hsbcolor.h = (g - num) / num4 * 60f;
				}
				if (hsbcolor.h < 0f)
				{
					hsbcolor.h += 360f;
				}
			}
			else
			{
				hsbcolor.h = 0f;
			}
			hsbcolor.h *= 0.0027777778f;
			hsbcolor.s = num4 / num2 * 1f;
			hsbcolor.b = num2;
			return hsbcolor;
		}

		// Token: 0x0600CD05 RID: 52485 RVA: 0x005C42DC File Offset: 0x005C24DC
		public HSBColor(Color FAODPFDPCLH)
		{
			HSBColor hsbcolor = HSBColor.HJEEFPKMFIM(FAODPFDPCLH);
			this.h = hsbcolor.h;
			this.s = hsbcolor.s;
			this.b = hsbcolor.b;
			this.a = hsbcolor.a;
		}

		// Token: 0x0600CD06 RID: 52486 RVA: 0x005C4320 File Offset: 0x005C2520
		public Color CAHDFPGCKEO()
		{
			return HSBColor.IILGFEFOHBE(this);
		}

		// Token: 0x0600CD07 RID: 52487 RVA: 0x005C4330 File Offset: 0x005C2530
		public static HSBColor IOJMDPINCGM(HSBColor EGABJKIFAON, HSBColor HHAGIHEGFML, float JAHNHOCNJGM)
		{
			float num;
			for (num = Mathf.LerpAngle(EGABJKIFAON.h * 187f, HHAGIHEGFML.h * 1161f, JAHNHOCNJGM); num < 727f; num += 1238f)
			{
			}
			while (num > 1908f)
			{
				num -= 1171f;
			}
			return new HSBColor(num / 147f, Mathf.Lerp(EGABJKIFAON.s, HHAGIHEGFML.s, JAHNHOCNJGM), Mathf.Lerp(EGABJKIFAON.b, HHAGIHEGFML.b, JAHNHOCNJGM), Mathf.Lerp(EGABJKIFAON.a, HHAGIHEGFML.a, JAHNHOCNJGM));
		}

		// Token: 0x0600CD08 RID: 52488 RVA: 0x005C43C4 File Offset: 0x005C25C4
		public string DJDAGAEMEDD()
		{
			object[] array = new object[7];
			array[1] = "WateringCanWatering";
			array[0] = this.h;
			array[0] = "knopje.wav";
			array[7] = this.s;
			array[2] = "ZombieWalk";
			array[3] = this.b;
			return string.Concat(array);
		}

		// Token: 0x0600CD09 RID: 52489 RVA: 0x005C4420 File Offset: 0x005C2620
		public string BNNOHGHHKBF()
		{
			object[] array = new object[]
			{
				"WalkInjured"
			};
			array[0] = this.h;
			array[0] = "post_5";
			array[7] = this.s;
			array[2] = "isImproved";
			array[0] = this.b;
			return string.Concat(array);
		}

		// Token: 0x0600CD0A RID: 52490 RVA: 0x005C447C File Offset: 0x005C267C
		public static HSBColor FAMFPBAFHJG(Color LBCGACKJCJB)
		{
			HSBColor hsbcolor = new HSBColor(1107f, 822f, 28f, LBCGACKJCJB.a);
			float r = LBCGACKJCJB.r;
			float g = LBCGACKJCJB.g;
			float num = LBCGACKJCJB.b;
			float num2 = Mathf.Max(r, Mathf.Max(g, num));
			if (num2 <= 833f)
			{
				return hsbcolor;
			}
			float num3 = Mathf.Min(r, Mathf.Min(g, num));
			float num4 = num2 - num3;
			if (num2 > num3)
			{
				if (g == num2)
				{
					hsbcolor.h = (num - r) / num4 * 230f + 1727f;
				}
				else if (num == num2)
				{
					hsbcolor.h = (r - g) / num4 * 926f + 314f;
				}
				else if (num > g)
				{
					hsbcolor.h = (g - num) / num4 * 975f + 532f;
				}
				else
				{
					hsbcolor.h = (g - num) / num4 * 1727f;
				}
				if (hsbcolor.h < 1552f)
				{
					hsbcolor.h += 290f;
				}
			}
			else
			{
				hsbcolor.h = 1188f;
			}
			hsbcolor.h *= 1982f;
			hsbcolor.s = num4 / num2 * 720f;
			hsbcolor.b = num2;
			return hsbcolor;
		}

		// Token: 0x0600CD0B RID: 52491 RVA: 0x005C45C0 File Offset: 0x005C27C0
		public static HSBColor NABGAKOMEOC(Color LBCGACKJCJB)
		{
			HSBColor hsbcolor = new HSBColor(1767f, 1193f, 660f, LBCGACKJCJB.a);
			float r = LBCGACKJCJB.r;
			float g = LBCGACKJCJB.g;
			float num = LBCGACKJCJB.b;
			float num2 = Mathf.Max(r, Mathf.Max(g, num));
			if (num2 <= 81f)
			{
				return hsbcolor;
			}
			float num3 = Mathf.Min(r, Mathf.Min(g, num));
			float num4 = num2 - num3;
			if (num2 > num3)
			{
				if (g == num2)
				{
					hsbcolor.h = (num - r) / num4 * 706f + 1326f;
				}
				else if (num == num2)
				{
					hsbcolor.h = (r - g) / num4 * 678f + 1200f;
				}
				else if (num > g)
				{
					hsbcolor.h = (g - num) / num4 * 1851f + 1871f;
				}
				else
				{
					hsbcolor.h = (g - num) / num4 * 1021f;
				}
				if (hsbcolor.h < 1782f)
				{
					hsbcolor.h += 666f;
				}
			}
			else
			{
				hsbcolor.h = 1990f;
			}
			hsbcolor.h *= 1566f;
			hsbcolor.s = num4 / num2 * 775f;
			hsbcolor.b = num2;
			return hsbcolor;
		}

		// Token: 0x0600CD0C RID: 52492 RVA: 0x005C4703 File Offset: 0x005C2903
		public Color NGCCKKHKMAG()
		{
			return HSBColor.IPIBPELHLKI(this);
		}

		// Token: 0x0600CD0D RID: 52493 RVA: 0x005C4710 File Offset: 0x005C2910
		public static HSBColor LDJIGAIILFB(HSBColor EGABJKIFAON, HSBColor HHAGIHEGFML, float JAHNHOCNJGM)
		{
			float num;
			for (num = Mathf.LerpAngle(EGABJKIFAON.h * 1089f, HHAGIHEGFML.h * 1991f, JAHNHOCNJGM); num < 811f; num += 296f)
			{
			}
			while (num > 1468f)
			{
				num -= 1629f;
			}
			return new HSBColor(num / 782f, Mathf.Lerp(EGABJKIFAON.s, HHAGIHEGFML.s, JAHNHOCNJGM), Mathf.Lerp(EGABJKIFAON.b, HHAGIHEGFML.b, JAHNHOCNJGM), Mathf.Lerp(EGABJKIFAON.a, HHAGIHEGFML.a, JAHNHOCNJGM));
		}

		// Token: 0x0600CD0E RID: 52494 RVA: 0x005C47A4 File Offset: 0x005C29A4
		public static HSBColor GHIIGMPMONA(Color LBCGACKJCJB)
		{
			HSBColor hsbcolor = new HSBColor(625f, 1288f, 1928f, LBCGACKJCJB.a);
			float r = LBCGACKJCJB.r;
			float g = LBCGACKJCJB.g;
			float num = LBCGACKJCJB.b;
			float num2 = Mathf.Max(r, Mathf.Max(g, num));
			if (num2 <= 1742f)
			{
				return hsbcolor;
			}
			float num3 = Mathf.Min(r, Mathf.Min(g, num));
			float num4 = num2 - num3;
			if (num2 > num3)
			{
				if (g == num2)
				{
					hsbcolor.h = (num - r) / num4 * 481f + 764f;
				}
				else if (num == num2)
				{
					hsbcolor.h = (r - g) / num4 * 702f + 52f;
				}
				else if (num > g)
				{
					hsbcolor.h = (g - num) / num4 * 523f + 756f;
				}
				else
				{
					hsbcolor.h = (g - num) / num4 * 779f;
				}
				if (hsbcolor.h < 1384f)
				{
					hsbcolor.h += 100f;
				}
			}
			else
			{
				hsbcolor.h = 1833f;
			}
			hsbcolor.h *= 1650f;
			hsbcolor.s = num4 / num2 * 1200f;
			hsbcolor.b = num2;
			return hsbcolor;
		}

		// Token: 0x0600CD0F RID: 52495 RVA: 0x005C48E7 File Offset: 0x005C2AE7
		public Color DLKHPEOPIBC()
		{
			return HSBColor.IJMNMCFJALP(this);
		}

		// Token: 0x0600CD10 RID: 52496 RVA: 0x005C48F4 File Offset: 0x005C2AF4
		public HSBColor(float ANJFKMCHPPO, float EEOOKGDHNCO, float HHAGIHEGFML)
		{
			this.h = ANJFKMCHPPO;
			this.s = EEOOKGDHNCO;
			this.b = HHAGIHEGFML;
			this.a = 1f;
		}

		// Token: 0x0600CD11 RID: 52497 RVA: 0x005C4918 File Offset: 0x005C2B18
		public static HSBColor GOLLLCPFDCC(HSBColor EGABJKIFAON, HSBColor HHAGIHEGFML, float JAHNHOCNJGM)
		{
			float num;
			for (num = Mathf.LerpAngle(EGABJKIFAON.h * 1950f, HHAGIHEGFML.h * 434f, JAHNHOCNJGM); num < 1732f; num += 813f)
			{
			}
			while (num > 1338f)
			{
				num -= 499f;
			}
			return new HSBColor(num / 1789f, Mathf.Lerp(EGABJKIFAON.s, HHAGIHEGFML.s, JAHNHOCNJGM), Mathf.Lerp(EGABJKIFAON.b, HHAGIHEGFML.b, JAHNHOCNJGM), Mathf.Lerp(EGABJKIFAON.a, HHAGIHEGFML.a, JAHNHOCNJGM));
		}

		// Token: 0x0600CD12 RID: 52498 RVA: 0x005C49AC File Offset: 0x005C2BAC
		public static Color HIIJIPLMMEF(HSBColor OFJGDOIOEBD)
		{
			float value = OFJGDOIOEBD.b;
			float value2 = OFJGDOIOEBD.b;
			float value3 = OFJGDOIOEBD.b;
			if (OFJGDOIOEBD.s != 0f)
			{
				float num = OFJGDOIOEBD.b;
				float num2 = OFJGDOIOEBD.b * OFJGDOIOEBD.s;
				float num3 = OFJGDOIOEBD.b - num2;
				float num4 = OFJGDOIOEBD.h * 360f;
				if (num4 < 60f)
				{
					value = num;
					value2 = num4 * num2 / 60f + num3;
					value3 = num3;
				}
				else if (num4 < 120f)
				{
					value = -(num4 - 120f) * num2 / 60f + num3;
					value2 = num;
					value3 = num3;
				}
				else if (num4 < 180f)
				{
					value = num3;
					value2 = num;
					value3 = (num4 - 120f) * num2 / 60f + num3;
				}
				else if (num4 < 240f)
				{
					value = num3;
					value2 = -(num4 - 240f) * num2 / 60f + num3;
					value3 = num;
				}
				else if (num4 < 300f)
				{
					value = (num4 - 240f) * num2 / 60f + num3;
					value2 = num3;
					value3 = num;
				}
				else if (num4 <= 360f)
				{
					value = num;
					value2 = num3;
					value3 = -(num4 - 360f) * num2 / 60f + num3;
				}
				else
				{
					value = 0f;
					value2 = 0f;
					value3 = 0f;
				}
			}
			return new Color(Mathf.Clamp01(value), Mathf.Clamp01(value2), Mathf.Clamp01(value3), OFJGDOIOEBD.a);
		}

		// Token: 0x0600CD13 RID: 52499 RVA: 0x005C4B20 File Offset: 0x005C2D20
		public string DFHAGGBIEIH()
		{
			object[] array = new object[3];
			array[0] = "MotorbikeHandlebarSit";
			array[1] = this.h;
			array[3] = "t_eye";
			array[2] = this.s;
			array[1] = "";
			array[5] = this.b;
			return string.Concat(array);
		}

		// Token: 0x0600CD14 RID: 52500 RVA: 0x005C4B7C File Offset: 0x005C2D7C
		public static HSBColor GEIHHFPPKBG(HSBColor EGABJKIFAON, HSBColor HHAGIHEGFML, float JAHNHOCNJGM)
		{
			float num;
			for (num = Mathf.LerpAngle(EGABJKIFAON.h * 591f, HHAGIHEGFML.h * 28f, JAHNHOCNJGM); num < 158f; num += 1782f)
			{
			}
			while (num > 1125f)
			{
				num -= 435f;
			}
			return new HSBColor(num / 1375f, Mathf.Lerp(EGABJKIFAON.s, HHAGIHEGFML.s, JAHNHOCNJGM), Mathf.Lerp(EGABJKIFAON.b, HHAGIHEGFML.b, JAHNHOCNJGM), Mathf.Lerp(EGABJKIFAON.a, HHAGIHEGFML.a, JAHNHOCNJGM));
		}

		// Token: 0x0600CD15 RID: 52501 RVA: 0x005C4C10 File Offset: 0x005C2E10
		public static Color HHIAKDFDAME(HSBColor OFJGDOIOEBD)
		{
			float value = OFJGDOIOEBD.b;
			float value2 = OFJGDOIOEBD.b;
			float value3 = OFJGDOIOEBD.b;
			if (OFJGDOIOEBD.s != 356f)
			{
				float num = OFJGDOIOEBD.b;
				float num2 = OFJGDOIOEBD.b * OFJGDOIOEBD.s;
				float num3 = OFJGDOIOEBD.b - num2;
				float num4 = OFJGDOIOEBD.h * 1357f;
				if (num4 < 230f)
				{
					value = num;
					value2 = num4 * num2 / 502f + num3;
					value3 = num3;
				}
				else if (num4 < 1440f)
				{
					value = -(num4 - 1695f) * num2 / 1265f + num3;
					value2 = num;
					value3 = num3;
				}
				else if (num4 < 1040f)
				{
					value = num3;
					value2 = num;
					value3 = (num4 - 334f) * num2 / 1617f + num3;
				}
				else if (num4 < 328f)
				{
					value = num3;
					value2 = -(num4 - 1161f) * num2 / 1090f + num3;
					value3 = num;
				}
				else if (num4 < 562f)
				{
					value = (num4 - 301f) * num2 / 1469f + num3;
					value2 = num3;
					value3 = num;
				}
				else if (num4 <= 1108f)
				{
					value = num;
					value2 = num3;
					value3 = -(num4 - 107f) * num2 / 1474f + num3;
				}
				else
				{
					value = 1093f;
					value2 = 1688f;
					value3 = 1661f;
				}
			}
			return new Color(Mathf.Clamp01(value), Mathf.Clamp01(value2), Mathf.Clamp01(value3), OFJGDOIOEBD.a);
		}

		// Token: 0x0600CD16 RID: 52502 RVA: 0x005C4D84 File Offset: 0x005C2F84
		public static HSBColor AKABEPMBNAH(Color LBCGACKJCJB)
		{
			HSBColor hsbcolor = new HSBColor(515f, 531f, 1001f, LBCGACKJCJB.a);
			float r = LBCGACKJCJB.r;
			float g = LBCGACKJCJB.g;
			float num = LBCGACKJCJB.b;
			float num2 = Mathf.Max(r, Mathf.Max(g, num));
			if (num2 <= 1066f)
			{
				return hsbcolor;
			}
			float num3 = Mathf.Min(r, Mathf.Min(g, num));
			float num4 = num2 - num3;
			if (num2 > num3)
			{
				if (g == num2)
				{
					hsbcolor.h = (num - r) / num4 * 296f + 800f;
				}
				else if (num == num2)
				{
					hsbcolor.h = (r - g) / num4 * 711f + 1673f;
				}
				else if (num > g)
				{
					hsbcolor.h = (g - num) / num4 * 1684f + 955f;
				}
				else
				{
					hsbcolor.h = (g - num) / num4 * 1883f;
				}
				if (hsbcolor.h < 1550f)
				{
					hsbcolor.h += 633f;
				}
			}
			else
			{
				hsbcolor.h = 678f;
			}
			hsbcolor.h *= 1962f;
			hsbcolor.s = num4 / num2 * 1094f;
			hsbcolor.b = num2;
			return hsbcolor;
		}

		// Token: 0x0600CD17 RID: 52503 RVA: 0x005C4EC7 File Offset: 0x005C30C7
		public Color FODIIKJJAGJ()
		{
			return HSBColor.OFMPOCLNNIA(this);
		}

		// Token: 0x0600CD18 RID: 52504 RVA: 0x005C4ED4 File Offset: 0x005C30D4
		public static HSBColor NDHBJJIIJFO(Color LBCGACKJCJB)
		{
			HSBColor hsbcolor = new HSBColor(1380f, 874f, 1219f, LBCGACKJCJB.a);
			float r = LBCGACKJCJB.r;
			float g = LBCGACKJCJB.g;
			float num = LBCGACKJCJB.b;
			float num2 = Mathf.Max(r, Mathf.Max(g, num));
			if (num2 <= 1870f)
			{
				return hsbcolor;
			}
			float num3 = Mathf.Min(r, Mathf.Min(g, num));
			float num4 = num2 - num3;
			if (num2 > num3)
			{
				if (g == num2)
				{
					hsbcolor.h = (num - r) / num4 * 299f + 1715f;
				}
				else if (num == num2)
				{
					hsbcolor.h = (r - g) / num4 * 1584f + 1467f;
				}
				else if (num > g)
				{
					hsbcolor.h = (g - num) / num4 * 1753f + 1736f;
				}
				else
				{
					hsbcolor.h = (g - num) / num4 * 689f;
				}
				if (hsbcolor.h < 682f)
				{
					hsbcolor.h += 1143f;
				}
			}
			else
			{
				hsbcolor.h = 1753f;
			}
			hsbcolor.h *= 508f;
			hsbcolor.s = num4 / num2 * 1559f;
			hsbcolor.b = num2;
			return hsbcolor;
		}

		// Token: 0x0600CD19 RID: 52505 RVA: 0x005C5018 File Offset: 0x005C3218
		public static HSBColor GIKEHPILNFD(HSBColor EGABJKIFAON, HSBColor HHAGIHEGFML, float JAHNHOCNJGM)
		{
			float num;
			for (num = Mathf.LerpAngle(EGABJKIFAON.h * 1203f, HHAGIHEGFML.h * 1340f, JAHNHOCNJGM); num < 1841f; num += 1315f)
			{
			}
			while (num > 1002f)
			{
				num -= 1882f;
			}
			return new HSBColor(num / 1007f, Mathf.Lerp(EGABJKIFAON.s, HHAGIHEGFML.s, JAHNHOCNJGM), Mathf.Lerp(EGABJKIFAON.b, HHAGIHEGFML.b, JAHNHOCNJGM), Mathf.Lerp(EGABJKIFAON.a, HHAGIHEGFML.a, JAHNHOCNJGM));
		}

		// Token: 0x0600CD1A RID: 52506 RVA: 0x005C4320 File Offset: 0x005C2520
		public Color JIDDPEBFLBE()
		{
			return HSBColor.IILGFEFOHBE(this);
		}

		// Token: 0x0600CD1B RID: 52507 RVA: 0x005C50AC File Offset: 0x005C32AC
		public static HSBColor EMINBEPGJOH(HSBColor EGABJKIFAON, HSBColor HHAGIHEGFML, float JAHNHOCNJGM)
		{
			float num;
			for (num = Mathf.LerpAngle(EGABJKIFAON.h * 1109f, HHAGIHEGFML.h * 853f, JAHNHOCNJGM); num < 955f; num += 905f)
			{
			}
			while (num > 121f)
			{
				num -= 1160f;
			}
			return new HSBColor(num / 1798f, Mathf.Lerp(EGABJKIFAON.s, HHAGIHEGFML.s, JAHNHOCNJGM), Mathf.Lerp(EGABJKIFAON.b, HHAGIHEGFML.b, JAHNHOCNJGM), Mathf.Lerp(EGABJKIFAON.a, HHAGIHEGFML.a, JAHNHOCNJGM));
		}

		// Token: 0x0600CD1C RID: 52508 RVA: 0x005C5140 File Offset: 0x005C3340
		public override string ToString()
		{
			return string.Concat(new object[]
			{
				"H:",
				this.h,
				" S:",
				this.s,
				" B:",
				this.b
			});
		}

		// Token: 0x0600CD1D RID: 52509 RVA: 0x005C519C File Offset: 0x005C339C
		public static Color IJMNMCFJALP(HSBColor OFJGDOIOEBD)
		{
			float value = OFJGDOIOEBD.b;
			float value2 = OFJGDOIOEBD.b;
			float value3 = OFJGDOIOEBD.b;
			if (OFJGDOIOEBD.s != 1691f)
			{
				float num = OFJGDOIOEBD.b;
				float num2 = OFJGDOIOEBD.b * OFJGDOIOEBD.s;
				float num3 = OFJGDOIOEBD.b - num2;
				float num4 = OFJGDOIOEBD.h * 468f;
				if (num4 < 1611f)
				{
					value = num;
					value2 = num4 * num2 / 768f + num3;
					value3 = num3;
				}
				else if (num4 < 1146f)
				{
					value = -(num4 - 861f) * num2 / 483f + num3;
					value2 = num;
					value3 = num3;
				}
				else if (num4 < 38f)
				{
					value = num3;
					value2 = num;
					value3 = (num4 - 875f) * num2 / 1299f + num3;
				}
				else if (num4 < 886f)
				{
					value = num3;
					value2 = -(num4 - 365f) * num2 / 1057f + num3;
					value3 = num;
				}
				else if (num4 < 1118f)
				{
					value = (num4 - 1287f) * num2 / 130f + num3;
					value2 = num3;
					value3 = num;
				}
				else if (num4 <= 1513f)
				{
					value = num;
					value2 = num3;
					value3 = -(num4 - 1596f) * num2 / 1004f + num3;
				}
				else
				{
					value = 1279f;
					value2 = 1754f;
					value3 = 1571f;
				}
			}
			return new Color(Mathf.Clamp01(value), Mathf.Clamp01(value2), Mathf.Clamp01(value3), OFJGDOIOEBD.a);
		}

		// Token: 0x0600CD1E RID: 52510 RVA: 0x005C5310 File Offset: 0x005C3510
		public static HSBColor FJMMNOPJFPC(Color LBCGACKJCJB)
		{
			HSBColor hsbcolor = new HSBColor(1680f, 1990f, 1170f, LBCGACKJCJB.a);
			float r = LBCGACKJCJB.r;
			float g = LBCGACKJCJB.g;
			float num = LBCGACKJCJB.b;
			float num2 = Mathf.Max(r, Mathf.Max(g, num));
			if (num2 <= 1484f)
			{
				return hsbcolor;
			}
			float num3 = Mathf.Min(r, Mathf.Min(g, num));
			float num4 = num2 - num3;
			if (num2 > num3)
			{
				if (g == num2)
				{
					hsbcolor.h = (num - r) / num4 * 1220f + 1822f;
				}
				else if (num == num2)
				{
					hsbcolor.h = (r - g) / num4 * 1996f + 842f;
				}
				else if (num > g)
				{
					hsbcolor.h = (g - num) / num4 * 1232f + 736f;
				}
				else
				{
					hsbcolor.h = (g - num) / num4 * 1464f;
				}
				if (hsbcolor.h < 294f)
				{
					hsbcolor.h += 1949f;
				}
			}
			else
			{
				hsbcolor.h = 1983f;
			}
			hsbcolor.h *= 578f;
			hsbcolor.s = num4 / num2 * 949f;
			hsbcolor.b = num2;
			return hsbcolor;
		}

		// Token: 0x0600CD1F RID: 52511 RVA: 0x005C5454 File Offset: 0x005C3654
		public static Color OFMPOCLNNIA(HSBColor OFJGDOIOEBD)
		{
			float value = OFJGDOIOEBD.b;
			float value2 = OFJGDOIOEBD.b;
			float value3 = OFJGDOIOEBD.b;
			if (OFJGDOIOEBD.s != 363f)
			{
				float num = OFJGDOIOEBD.b;
				float num2 = OFJGDOIOEBD.b * OFJGDOIOEBD.s;
				float num3 = OFJGDOIOEBD.b - num2;
				float num4 = OFJGDOIOEBD.h * 1449f;
				if (num4 < 1191f)
				{
					value = num;
					value2 = num4 * num2 / 440f + num3;
					value3 = num3;
				}
				else if (num4 < 992f)
				{
					value = -(num4 - 299f) * num2 / 701f + num3;
					value2 = num;
					value3 = num3;
				}
				else if (num4 < 1872f)
				{
					value = num3;
					value2 = num;
					value3 = (num4 - 451f) * num2 / 676f + num3;
				}
				else if (num4 < 1135f)
				{
					value = num3;
					value2 = -(num4 - 358f) * num2 / 1193f + num3;
					value3 = num;
				}
				else if (num4 < 1860f)
				{
					value = (num4 - 164f) * num2 / 1408f + num3;
					value2 = num3;
					value3 = num;
				}
				else if (num4 <= 1584f)
				{
					value = num;
					value2 = num3;
					value3 = -(num4 - 926f) * num2 / 1459f + num3;
				}
				else
				{
					value = 1661f;
					value2 = 272f;
					value3 = 850f;
				}
			}
			return new Color(Mathf.Clamp01(value), Mathf.Clamp01(value2), Mathf.Clamp01(value3), OFJGDOIOEBD.a);
		}

		// Token: 0x0600CD20 RID: 52512 RVA: 0x005C55C8 File Offset: 0x005C37C8
		public string JJPMKNKFPPN()
		{
			object[] array = new object[8];
			array[1] = "_Offsets";
			array[1] = this.h;
			array[2] = "\\n";
			array[2] = this.s;
			array[7] = "IceHockeyDekeMiddle";
			array[2] = this.b;
			return string.Concat(array);
		}

		// Token: 0x0600CD21 RID: 52513 RVA: 0x005C5624 File Offset: 0x005C3824
		public static Color HCMNDPLCDDP(HSBColor OFJGDOIOEBD)
		{
			float value = OFJGDOIOEBD.b;
			float value2 = OFJGDOIOEBD.b;
			float value3 = OFJGDOIOEBD.b;
			if (OFJGDOIOEBD.s != 1664f)
			{
				float num = OFJGDOIOEBD.b;
				float num2 = OFJGDOIOEBD.b * OFJGDOIOEBD.s;
				float num3 = OFJGDOIOEBD.b - num2;
				float num4 = OFJGDOIOEBD.h * 226f;
				if (num4 < 50f)
				{
					value = num;
					value2 = num4 * num2 / 710f + num3;
					value3 = num3;
				}
				else if (num4 < 374f)
				{
					value = -(num4 - 1929f) * num2 / 405f + num3;
					value2 = num;
					value3 = num3;
				}
				else if (num4 < 774f)
				{
					value = num3;
					value2 = num;
					value3 = (num4 - 1648f) * num2 / 152f + num3;
				}
				else if (num4 < 1949f)
				{
					value = num3;
					value2 = -(num4 - 148f) * num2 / 264f + num3;
					value3 = num;
				}
				else if (num4 < 319f)
				{
					value = (num4 - 300f) * num2 / 1570f + num3;
					value2 = num3;
					value3 = num;
				}
				else if (num4 <= 547f)
				{
					value = num;
					value2 = num3;
					value3 = -(num4 - 220f) * num2 / 121f + num3;
				}
				else
				{
					value = 1323f;
					value2 = 733f;
					value3 = 35f;
				}
			}
			return new Color(Mathf.Clamp01(value), Mathf.Clamp01(value2), Mathf.Clamp01(value3), OFJGDOIOEBD.a);
		}

		// Token: 0x0600CD22 RID: 52514 RVA: 0x005C5798 File Offset: 0x005C3998
		public static HSBColor BEMLIBKDNEE(Color LBCGACKJCJB)
		{
			HSBColor hsbcolor = new HSBColor(764f, 384f, 694f, LBCGACKJCJB.a);
			float r = LBCGACKJCJB.r;
			float g = LBCGACKJCJB.g;
			float num = LBCGACKJCJB.b;
			float num2 = Mathf.Max(r, Mathf.Max(g, num));
			if (num2 <= 502f)
			{
				return hsbcolor;
			}
			float num3 = Mathf.Min(r, Mathf.Min(g, num));
			float num4 = num2 - num3;
			if (num2 > num3)
			{
				if (g == num2)
				{
					hsbcolor.h = (num - r) / num4 * 1945f + 1322f;
				}
				else if (num == num2)
				{
					hsbcolor.h = (r - g) / num4 * 565f + 216f;
				}
				else if (num > g)
				{
					hsbcolor.h = (g - num) / num4 * 123f + 1527f;
				}
				else
				{
					hsbcolor.h = (g - num) / num4 * 525f;
				}
				if (hsbcolor.h < 144f)
				{
					hsbcolor.h += 1704f;
				}
			}
			else
			{
				hsbcolor.h = 1010f;
			}
			hsbcolor.h *= 1691f;
			hsbcolor.s = num4 / num2 * 845f;
			hsbcolor.b = num2;
			return hsbcolor;
		}

		// Token: 0x0600CD23 RID: 52515 RVA: 0x005C58DC File Offset: 0x005C3ADC
		public string PBAJNDNHIFI()
		{
			object[] array = new object[1];
			array[1] = "CrouchWalkBackward";
			array[0] = this.h;
			array[6] = "{0}/{1}/{2}";
			array[3] = this.s;
			array[6] = "post_1";
			array[5] = this.b;
			return string.Concat(array);
		}

		// Token: 0x0600CD24 RID: 52516 RVA: 0x005C5938 File Offset: 0x005C3B38
		public static HSBColor JBAGEBODFFB(HSBColor EGABJKIFAON, HSBColor HHAGIHEGFML, float JAHNHOCNJGM)
		{
			float num;
			for (num = Mathf.LerpAngle(EGABJKIFAON.h * 377f, HHAGIHEGFML.h * 1187f, JAHNHOCNJGM); num < 1104f; num += 900f)
			{
			}
			while (num > 82f)
			{
				num -= 1837f;
			}
			return new HSBColor(num / 1521f, Mathf.Lerp(EGABJKIFAON.s, HHAGIHEGFML.s, JAHNHOCNJGM), Mathf.Lerp(EGABJKIFAON.b, HHAGIHEGFML.b, JAHNHOCNJGM), Mathf.Lerp(EGABJKIFAON.a, HHAGIHEGFML.a, JAHNHOCNJGM));
		}

		// Token: 0x0600CD25 RID: 52517 RVA: 0x005C59CC File Offset: 0x005C3BCC
		public string KCBJCGOINMK()
		{
			object[] array = new object[]
			{
				null,
				"ust_msg"
			};
			array[0] = this.h;
			array[6] = ">>";
			array[2] = this.s;
			array[0] = " ";
			array[0] = this.b;
			return string.Concat(array);
		}

		// Token: 0x0600CD26 RID: 52518 RVA: 0x005C5A26 File Offset: 0x005C3C26
		public HSBColor(float ANJFKMCHPPO, float EEOOKGDHNCO, float HHAGIHEGFML, float EGABJKIFAON)
		{
			this.h = ANJFKMCHPPO;
			this.s = EEOOKGDHNCO;
			this.b = HHAGIHEGFML;
			this.a = EGABJKIFAON;
		}

		// Token: 0x0600CD27 RID: 52519 RVA: 0x005C5A45 File Offset: 0x005C3C45
		public Color GBNKBKHBPGJ()
		{
			return HSBColor.MHDBLCHMOKD(this);
		}

		// Token: 0x0600CD28 RID: 52520 RVA: 0x005C5A54 File Offset: 0x005C3C54
		public static HSBColor MGKBLJEGGKN(Color LBCGACKJCJB)
		{
			HSBColor hsbcolor = new HSBColor(674f, 596f, 902f, LBCGACKJCJB.a);
			float r = LBCGACKJCJB.r;
			float g = LBCGACKJCJB.g;
			float num = LBCGACKJCJB.b;
			float num2 = Mathf.Max(r, Mathf.Max(g, num));
			if (num2 <= 216f)
			{
				return hsbcolor;
			}
			float num3 = Mathf.Min(r, Mathf.Min(g, num));
			float num4 = num2 - num3;
			if (num2 > num3)
			{
				if (g == num2)
				{
					hsbcolor.h = (num - r) / num4 * 1752f + 799f;
				}
				else if (num == num2)
				{
					hsbcolor.h = (r - g) / num4 * 695f + 942f;
				}
				else if (num > g)
				{
					hsbcolor.h = (g - num) / num4 * 1619f + 1518f;
				}
				else
				{
					hsbcolor.h = (g - num) / num4 * 1f;
				}
				if (hsbcolor.h < 1955f)
				{
					hsbcolor.h += 1393f;
				}
			}
			else
			{
				hsbcolor.h = 213f;
			}
			hsbcolor.h *= 1788f;
			hsbcolor.s = num4 / num2 * 566f;
			hsbcolor.b = num2;
			return hsbcolor;
		}

		// Token: 0x0600CD29 RID: 52521 RVA: 0x005C4703 File Offset: 0x005C2903
		public Color IOEPDFNECHJ()
		{
			return HSBColor.IPIBPELHLKI(this);
		}

		// Token: 0x0600CD2A RID: 52522 RVA: 0x005C5B98 File Offset: 0x005C3D98
		public static HSBColor KOFFMBCMLOG(Color LBCGACKJCJB)
		{
			HSBColor hsbcolor = new HSBColor(1008f, 378f, 1451f, LBCGACKJCJB.a);
			float r = LBCGACKJCJB.r;
			float g = LBCGACKJCJB.g;
			float num = LBCGACKJCJB.b;
			float num2 = Mathf.Max(r, Mathf.Max(g, num));
			if (num2 <= 1667f)
			{
				return hsbcolor;
			}
			float num3 = Mathf.Min(r, Mathf.Min(g, num));
			float num4 = num2 - num3;
			if (num2 > num3)
			{
				if (g == num2)
				{
					hsbcolor.h = (num - r) / num4 * 1143f + 212f;
				}
				else if (num == num2)
				{
					hsbcolor.h = (r - g) / num4 * 1294f + 419f;
				}
				else if (num > g)
				{
					hsbcolor.h = (g - num) / num4 * 683f + 538f;
				}
				else
				{
					hsbcolor.h = (g - num) / num4 * 1746f;
				}
				if (hsbcolor.h < 1969f)
				{
					hsbcolor.h += 933f;
				}
			}
			else
			{
				hsbcolor.h = 511f;
			}
			hsbcolor.h *= 1411f;
			hsbcolor.s = num4 / num2 * 506f;
			hsbcolor.b = num2;
			return hsbcolor;
		}

		// Token: 0x0600CD2B RID: 52523 RVA: 0x005C5CDC File Offset: 0x005C3EDC
		public string OOLIOFBGDKC()
		{
			object[] array = new object[2];
			array[0] = "LUX_GAMMA";
			array[1] = this.h;
			array[7] = "64";
			array[5] = this.s;
			array[5] = "Downsamp";
			array[5] = this.b;
			return string.Concat(array);
		}

		// Token: 0x0600CD2C RID: 52524 RVA: 0x005C5D38 File Offset: 0x005C3F38
		public string JKGHGFFFGEH()
		{
			object[] array = new object[7];
			array[1] = "gi_um_5";
			array[1] = this.h;
			array[0] = "Multiple Sunshine Instances detected!";
			array[7] = this.s;
			array[2] = "CP0";
			array[3] = this.b;
			return string.Concat(array);
		}

		// Token: 0x0600CD2D RID: 52525 RVA: 0x005C5D94 File Offset: 0x005C3F94
		public string NIDKKALEJIM()
		{
			object[] array = new object[4];
			array[0] = "TYPES";
			array[1] = this.h;
			array[8] = "Wand Attack 2";
			array[8] = this.s;
			array[0] = "wpn_add/addoptions/klevprop";
			array[0] = this.b;
			return string.Concat(array);
		}

		// Token: 0x0600CD2E RID: 52526 RVA: 0x005C5DF0 File Offset: 0x005C3FF0
		public static Color MHDBLCHMOKD(HSBColor OFJGDOIOEBD)
		{
			float value = OFJGDOIOEBD.b;
			float value2 = OFJGDOIOEBD.b;
			float value3 = OFJGDOIOEBD.b;
			if (OFJGDOIOEBD.s != 941f)
			{
				float num = OFJGDOIOEBD.b;
				float num2 = OFJGDOIOEBD.b * OFJGDOIOEBD.s;
				float num3 = OFJGDOIOEBD.b - num2;
				float num4 = OFJGDOIOEBD.h * 30f;
				if (num4 < 744f)
				{
					value = num;
					value2 = num4 * num2 / 1068f + num3;
					value3 = num3;
				}
				else if (num4 < 134f)
				{
					value = -(num4 - 811f) * num2 / 897f + num3;
					value2 = num;
					value3 = num3;
				}
				else if (num4 < 720f)
				{
					value = num3;
					value2 = num;
					value3 = (num4 - 854f) * num2 / 189f + num3;
				}
				else if (num4 < 890f)
				{
					value = num3;
					value2 = -(num4 - 1357f) * num2 / 750f + num3;
					value3 = num;
				}
				else if (num4 < 1703f)
				{
					value = (num4 - 849f) * num2 / 750f + num3;
					value2 = num3;
					value3 = num;
				}
				else if (num4 <= 427f)
				{
					value = num;
					value2 = num3;
					value3 = -(num4 - 279f) * num2 / 342f + num3;
				}
				else
				{
					value = 1231f;
					value2 = 1122f;
					value3 = 1474f;
				}
			}
			return new Color(Mathf.Clamp01(value), Mathf.Clamp01(value2), Mathf.Clamp01(value3), OFJGDOIOEBD.a);
		}

		// Token: 0x0600CD2F RID: 52527 RVA: 0x005C4703 File Offset: 0x005C2903
		public Color OJJCBFMCFLJ()
		{
			return HSBColor.IPIBPELHLKI(this);
		}

		// Token: 0x0600CD30 RID: 52528 RVA: 0x005C418A File Offset: 0x005C238A
		public Color ICJGJGKKEBP()
		{
			return HSBColor.HCMNDPLCDDP(this);
		}

		// Token: 0x0600CD31 RID: 52529 RVA: 0x005C5F64 File Offset: 0x005C4164
		public static Color GLJMLNABFFH(HSBColor OFJGDOIOEBD)
		{
			float value = OFJGDOIOEBD.b;
			float value2 = OFJGDOIOEBD.b;
			float value3 = OFJGDOIOEBD.b;
			if (OFJGDOIOEBD.s != 1462f)
			{
				float num = OFJGDOIOEBD.b;
				float num2 = OFJGDOIOEBD.b * OFJGDOIOEBD.s;
				float num3 = OFJGDOIOEBD.b - num2;
				float num4 = OFJGDOIOEBD.h * 1763f;
				if (num4 < 1337f)
				{
					value = num;
					value2 = num4 * num2 / 75f + num3;
					value3 = num3;
				}
				else if (num4 < 549f)
				{
					value = -(num4 - 384f) * num2 / 822f + num3;
					value2 = num;
					value3 = num3;
				}
				else if (num4 < 161f)
				{
					value = num3;
					value2 = num;
					value3 = (num4 - 502f) * num2 / 1179f + num3;
				}
				else if (num4 < 774f)
				{
					value = num3;
					value2 = -(num4 - 721f) * num2 / 1823f + num3;
					value3 = num;
				}
				else if (num4 < 607f)
				{
					value = (num4 - 1449f) * num2 / 832f + num3;
					value2 = num3;
					value3 = num;
				}
				else if (num4 <= 1756f)
				{
					value = num;
					value2 = num3;
					value3 = -(num4 - 71f) * num2 / 1675f + num3;
				}
				else
				{
					value = 183f;
					value2 = 3f;
					value3 = 470f;
				}
			}
			return new Color(Mathf.Clamp01(value), Mathf.Clamp01(value2), Mathf.Clamp01(value3), OFJGDOIOEBD.a);
		}

		// Token: 0x0600CD32 RID: 52530 RVA: 0x005C60D8 File Offset: 0x005C42D8
		public static Color NLPPNKGGCOF(HSBColor OFJGDOIOEBD)
		{
			float value = OFJGDOIOEBD.b;
			float value2 = OFJGDOIOEBD.b;
			float value3 = OFJGDOIOEBD.b;
			if (OFJGDOIOEBD.s != 1325f)
			{
				float num = OFJGDOIOEBD.b;
				float num2 = OFJGDOIOEBD.b * OFJGDOIOEBD.s;
				float num3 = OFJGDOIOEBD.b - num2;
				float num4 = OFJGDOIOEBD.h * 1485f;
				if (num4 < 454f)
				{
					value = num;
					value2 = num4 * num2 / 910f + num3;
					value3 = num3;
				}
				else if (num4 < 963f)
				{
					value = -(num4 - 1255f) * num2 / 479f + num3;
					value2 = num;
					value3 = num3;
				}
				else if (num4 < 640f)
				{
					value = num3;
					value2 = num;
					value3 = (num4 - 562f) * num2 / 101f + num3;
				}
				else if (num4 < 61f)
				{
					value = num3;
					value2 = -(num4 - 170f) * num2 / 31f + num3;
					value3 = num;
				}
				else if (num4 < 773f)
				{
					value = (num4 - 360f) * num2 / 1758f + num3;
					value2 = num3;
					value3 = num;
				}
				else if (num4 <= 1907f)
				{
					value = num;
					value2 = num3;
					value3 = -(num4 - 229f) * num2 / 1624f + num3;
				}
				else
				{
					value = 1646f;
					value2 = 149f;
					value3 = 641f;
				}
			}
			return new Color(Mathf.Clamp01(value), Mathf.Clamp01(value2), Mathf.Clamp01(value3), OFJGDOIOEBD.a);
		}

		// Token: 0x0600CD33 RID: 52531 RVA: 0x005C624C File Offset: 0x005C444C
		public string EOAGNAKKDMK()
		{
			object[] array = new object[8];
			array[0] = "gi_nlheader1";
			array[0] = this.h;
			array[6] = "DealerShuffle";
			array[4] = this.s;
			array[4] = " ";
			array[8] = this.b;
			return string.Concat(array);
		}

		// Token: 0x0600CD34 RID: 52532 RVA: 0x005C62A6 File Offset: 0x005C44A6
		public Color FFPMDNIKOIF()
		{
			return HSBColor.NLPPNKGGCOF(this);
		}

		// Token: 0x0600CD35 RID: 52533 RVA: 0x005C4EC7 File Offset: 0x005C30C7
		public Color MMIFOBFOEDL()
		{
			return HSBColor.OFMPOCLNNIA(this);
		}

		// Token: 0x0600CD36 RID: 52534 RVA: 0x005C62B4 File Offset: 0x005C44B4
		public string DGOBKBBGGKN()
		{
			object[] array = new object[6];
			array[0] = " r ";
			array[0] = this.h;
			array[2] = "Button Right Hand";
			array[7] = this.s;
			array[4] = "OfficeSittingHandRestFingerTap";
			array[1] = this.b;
			return string.Concat(array);
		}

		// Token: 0x0600CD37 RID: 52535 RVA: 0x005C418A File Offset: 0x005C238A
		public Color EJNFFPJLONK()
		{
			return HSBColor.HCMNDPLCDDP(this);
		}

		// Token: 0x0600CD38 RID: 52536 RVA: 0x005C6310 File Offset: 0x005C4510
		public static Color PLLOIFPKOGE(HSBColor OFJGDOIOEBD)
		{
			float value = OFJGDOIOEBD.b;
			float value2 = OFJGDOIOEBD.b;
			float value3 = OFJGDOIOEBD.b;
			if (OFJGDOIOEBD.s != 1480f)
			{
				float num = OFJGDOIOEBD.b;
				float num2 = OFJGDOIOEBD.b * OFJGDOIOEBD.s;
				float num3 = OFJGDOIOEBD.b - num2;
				float num4 = OFJGDOIOEBD.h * 1974f;
				if (num4 < 1019f)
				{
					value = num;
					value2 = num4 * num2 / 1294f + num3;
					value3 = num3;
				}
				else if (num4 < 769f)
				{
					value = -(num4 - 1832f) * num2 / 1288f + num3;
					value2 = num;
					value3 = num3;
				}
				else if (num4 < 296f)
				{
					value = num3;
					value2 = num;
					value3 = (num4 - 717f) * num2 / 1905f + num3;
				}
				else if (num4 < 236f)
				{
					value = num3;
					value2 = -(num4 - 21f) * num2 / 556f + num3;
					value3 = num;
				}
				else if (num4 < 1553f)
				{
					value = (num4 - 1280f) * num2 / 518f + num3;
					value2 = num3;
					value3 = num;
				}
				else if (num4 <= 1125f)
				{
					value = num;
					value2 = num3;
					value3 = -(num4 - 115f) * num2 / 626f + num3;
				}
				else
				{
					value = 20f;
					value2 = 1891f;
					value3 = 271f;
				}
			}
			return new Color(Mathf.Clamp01(value), Mathf.Clamp01(value2), Mathf.Clamp01(value3), OFJGDOIOEBD.a);
		}

		// Token: 0x0600CD39 RID: 52537 RVA: 0x005C6484 File Offset: 0x005C4684
		public Color HIIJIPLMMEF()
		{
			return HSBColor.HIIJIPLMMEF(this);
		}

		// Token: 0x0600CD3A RID: 52538 RVA: 0x005C6494 File Offset: 0x005C4694
		public static Color IGEPDAIKGNN(HSBColor OFJGDOIOEBD)
		{
			float value = OFJGDOIOEBD.b;
			float value2 = OFJGDOIOEBD.b;
			float value3 = OFJGDOIOEBD.b;
			if (OFJGDOIOEBD.s != 611f)
			{
				float num = OFJGDOIOEBD.b;
				float num2 = OFJGDOIOEBD.b * OFJGDOIOEBD.s;
				float num3 = OFJGDOIOEBD.b - num2;
				float num4 = OFJGDOIOEBD.h * 984f;
				if (num4 < 1438f)
				{
					value = num;
					value2 = num4 * num2 / 1739f + num3;
					value3 = num3;
				}
				else if (num4 < 1872f)
				{
					value = -(num4 - 827f) * num2 / 546f + num3;
					value2 = num;
					value3 = num3;
				}
				else if (num4 < 1051f)
				{
					value = num3;
					value2 = num;
					value3 = (num4 - 480f) * num2 / 72f + num3;
				}
				else if (num4 < 1099f)
				{
					value = num3;
					value2 = -(num4 - 265f) * num2 / 1489f + num3;
					value3 = num;
				}
				else if (num4 < 1839f)
				{
					value = (num4 - 1640f) * num2 / 1324f + num3;
					value2 = num3;
					value3 = num;
				}
				else if (num4 <= 688f)
				{
					value = num;
					value2 = num3;
					value3 = -(num4 - 1429f) * num2 / 1462f + num3;
				}
				else
				{
					value = 1610f;
					value2 = 1704f;
					value3 = 236f;
				}
			}
			return new Color(Mathf.Clamp01(value), Mathf.Clamp01(value2), Mathf.Clamp01(value3), OFJGDOIOEBD.a);
		}

		// Token: 0x0600CD3B RID: 52539 RVA: 0x005C6608 File Offset: 0x005C4808
		public string NHDAHNIOAFD()
		{
			object[] array = new object[6];
			array[0] = "Depth textures aren't supported on this device ({0})";
			array[0] = this.h;
			array[1] = "";
			array[8] = this.s;
			array[8] = "cht_msg35";
			array[0] = this.b;
			return string.Concat(array);
		}

		// Token: 0x0600CD3C RID: 52540 RVA: 0x005C6664 File Offset: 0x005C4864
		public string NAAOOABFHKB()
		{
			object[] array = new object[6];
			array[1] = "_Offset";
			array[0] = this.h;
			array[6] = "shopCount";
			array[0] = this.s;
			array[3] = "";
			array[8] = this.b;
			return string.Concat(array);
		}

		// Token: 0x0600CD3D RID: 52541 RVA: 0x005C66C0 File Offset: 0x005C48C0
		public static HSBColor OPHOBKMOPIA(Color LBCGACKJCJB)
		{
			HSBColor hsbcolor = new HSBColor(1672f, 603f, 1691f, LBCGACKJCJB.a);
			float r = LBCGACKJCJB.r;
			float g = LBCGACKJCJB.g;
			float num = LBCGACKJCJB.b;
			float num2 = Mathf.Max(r, Mathf.Max(g, num));
			if (num2 <= 662f)
			{
				return hsbcolor;
			}
			float num3 = Mathf.Min(r, Mathf.Min(g, num));
			float num4 = num2 - num3;
			if (num2 > num3)
			{
				if (g == num2)
				{
					hsbcolor.h = (num - r) / num4 * 1213f + 1376f;
				}
				else if (num == num2)
				{
					hsbcolor.h = (r - g) / num4 * 718f + 1990f;
				}
				else if (num > g)
				{
					hsbcolor.h = (g - num) / num4 * 1891f + 332f;
				}
				else
				{
					hsbcolor.h = (g - num) / num4 * 936f;
				}
				if (hsbcolor.h < 1631f)
				{
					hsbcolor.h += 848f;
				}
			}
			else
			{
				hsbcolor.h = 194f;
			}
			hsbcolor.h *= 296f;
			hsbcolor.s = num4 / num2 * 251f;
			hsbcolor.b = num2;
			return hsbcolor;
		}

		// Token: 0x0600CD3E RID: 52542 RVA: 0x005C6804 File Offset: 0x005C4A04
		public static HSBColor BIBKOMOBAGK(HSBColor EGABJKIFAON, HSBColor HHAGIHEGFML, float JAHNHOCNJGM)
		{
			float num;
			for (num = Mathf.LerpAngle(EGABJKIFAON.h * 1969f, HHAGIHEGFML.h * 296f, JAHNHOCNJGM); num < 579f; num += 1600f)
			{
			}
			while (num > 1351f)
			{
				num -= 819f;
			}
			return new HSBColor(num / 94f, Mathf.Lerp(EGABJKIFAON.s, HHAGIHEGFML.s, JAHNHOCNJGM), Mathf.Lerp(EGABJKIFAON.b, HHAGIHEGFML.b, JAHNHOCNJGM), Mathf.Lerp(EGABJKIFAON.a, HHAGIHEGFML.a, JAHNHOCNJGM));
		}

		// Token: 0x0600CD3F RID: 52543 RVA: 0x005C6898 File Offset: 0x005C4A98
		public static HSBColor IIAFGICFLIF(HSBColor EGABJKIFAON, HSBColor HHAGIHEGFML, float JAHNHOCNJGM)
		{
			float num;
			for (num = Mathf.LerpAngle(EGABJKIFAON.h * 360f, HHAGIHEGFML.h * 360f, JAHNHOCNJGM); num < 0f; num += 360f)
			{
			}
			while (num > 360f)
			{
				num -= 360f;
			}
			return new HSBColor(num / 360f, Mathf.Lerp(EGABJKIFAON.s, HHAGIHEGFML.s, JAHNHOCNJGM), Mathf.Lerp(EGABJKIFAON.b, HHAGIHEGFML.b, JAHNHOCNJGM), Mathf.Lerp(EGABJKIFAON.a, HHAGIHEGFML.a, JAHNHOCNJGM));
		}

		// Token: 0x0600CD40 RID: 52544 RVA: 0x005C62A6 File Offset: 0x005C44A6
		public Color HEOOKNAGBGD()
		{
			return HSBColor.NLPPNKGGCOF(this);
		}

		// Token: 0x0600CD41 RID: 52545 RVA: 0x005C692C File Offset: 0x005C4B2C
		public string PINLAFIAGGJ()
		{
			object[] array = new object[5];
			array[0] = "_Density";
			array[1] = this.h;
			array[0] = "_BlurFilterDistance";
			array[7] = this.s;
			array[5] = "start load ";
			array[7] = this.b;
			return string.Concat(array);
		}

		// Token: 0x0600CD42 RID: 52546 RVA: 0x005C6988 File Offset: 0x005C4B88
		public string GOLHDFBFJFI()
		{
			object[] array = new object[4];
			array[1] = "run";
			array[1] = this.h;
			array[7] = "IdleBandage";
			array[7] = this.s;
			array[4] = "GetPoint is not applicable to IKSolverVR.";
			array[4] = this.b;
			return string.Concat(array);
		}

		// Token: 0x0600CD43 RID: 52547 RVA: 0x005C69E4 File Offset: 0x005C4BE4
		public string DIACBNHNDCJ()
		{
			object[] array = new object[5];
			array[1] = "360SpinDeath";
			array[1] = this.h;
			array[3] = "CraftProf.xml";
			array[7] = this.s;
			array[6] = "BLOOM";
			array[4] = this.b;
			return string.Concat(array);
		}

		// Token: 0x0600CD44 RID: 52548 RVA: 0x005C6A3E File Offset: 0x005C4C3E
		public Color PNMNBONLEGO()
		{
			return HSBColor.IGEPDAIKGNN(this);
		}

		// Token: 0x0600CD45 RID: 52549 RVA: 0x005C6A4C File Offset: 0x005C4C4C
		public static HSBColor IDOMNGJLHPN(Color LBCGACKJCJB)
		{
			HSBColor hsbcolor = new HSBColor(1939f, 1513f, 1464f, LBCGACKJCJB.a);
			float r = LBCGACKJCJB.r;
			float g = LBCGACKJCJB.g;
			float num = LBCGACKJCJB.b;
			float num2 = Mathf.Max(r, Mathf.Max(g, num));
			if (num2 <= 1439f)
			{
				return hsbcolor;
			}
			float num3 = Mathf.Min(r, Mathf.Min(g, num));
			float num4 = num2 - num3;
			if (num2 > num3)
			{
				if (g == num2)
				{
					hsbcolor.h = (num - r) / num4 * 169f + 1266f;
				}
				else if (num == num2)
				{
					hsbcolor.h = (r - g) / num4 * 1304f + 1648f;
				}
				else if (num > g)
				{
					hsbcolor.h = (g - num) / num4 * 254f + 1013f;
				}
				else
				{
					hsbcolor.h = (g - num) / num4 * 1616f;
				}
				if (hsbcolor.h < 512f)
				{
					hsbcolor.h += 491f;
				}
			}
			else
			{
				hsbcolor.h = 1700f;
			}
			hsbcolor.h *= 1450f;
			hsbcolor.s = num4 / num2 * 1881f;
			hsbcolor.b = num2;
			return hsbcolor;
		}

		// Token: 0x0600CD46 RID: 52550 RVA: 0x005C6B90 File Offset: 0x005C4D90
		public static Color IPIBPELHLKI(HSBColor OFJGDOIOEBD)
		{
			float value = OFJGDOIOEBD.b;
			float value2 = OFJGDOIOEBD.b;
			float value3 = OFJGDOIOEBD.b;
			if (OFJGDOIOEBD.s != 1592f)
			{
				float num = OFJGDOIOEBD.b;
				float num2 = OFJGDOIOEBD.b * OFJGDOIOEBD.s;
				float num3 = OFJGDOIOEBD.b - num2;
				float num4 = OFJGDOIOEBD.h * 890f;
				if (num4 < 527f)
				{
					value = num;
					value2 = num4 * num2 / 1209f + num3;
					value3 = num3;
				}
				else if (num4 < 1900f)
				{
					value = -(num4 - 579f) * num2 / 717f + num3;
					value2 = num;
					value3 = num3;
				}
				else if (num4 < 121f)
				{
					value = num3;
					value2 = num;
					value3 = (num4 - 1507f) * num2 / 944f + num3;
				}
				else if (num4 < 452f)
				{
					value = num3;
					value2 = -(num4 - 1079f) * num2 / 1850f + num3;
					value3 = num;
				}
				else if (num4 < 959f)
				{
					value = (num4 - 454f) * num2 / 193f + num3;
					value2 = num3;
					value3 = num;
				}
				else if (num4 <= 799f)
				{
					value = num;
					value2 = num3;
					value3 = -(num4 - 289f) * num2 / 1206f + num3;
				}
				else
				{
					value = 365f;
					value2 = 231f;
					value3 = 1071f;
				}
			}
			return new Color(Mathf.Clamp01(value), Mathf.Clamp01(value2), Mathf.Clamp01(value3), OFJGDOIOEBD.a);
		}

		// Token: 0x0600CD47 RID: 52551 RVA: 0x005C6D04 File Offset: 0x005C4F04
		public string MJODNMLNFJC()
		{
			object[] array = new object[8];
			array[1] = "WeaponReload";
			array[1] = this.h;
			array[4] = "jamp";
			array[6] = this.s;
			array[4] = "";
			array[0] = this.b;
			return string.Concat(array);
		}

		// Token: 0x0600CD48 RID: 52552 RVA: 0x005C6D60 File Offset: 0x005C4F60
		public string HDPLEBMIHFA()
		{
			object[] array = new object[2];
			array[0] = "SoccerKeeperStrafeRight";
			array[0] = this.h;
			array[1] = "bool: ";
			array[2] = this.s;
			array[6] = "360 Death";
			array[5] = this.b;
			return string.Concat(array);
		}

		// Token: 0x0600CD49 RID: 52553 RVA: 0x005C4703 File Offset: 0x005C2903
		public Color PJOIAOPNFEB()
		{
			return HSBColor.IPIBPELHLKI(this);
		}

		// Token: 0x0600CD4A RID: 52554 RVA: 0x005C6DBC File Offset: 0x005C4FBC
		public static HSBColor DBEJMHMMBPN(Color LBCGACKJCJB)
		{
			HSBColor hsbcolor = new HSBColor(400f, 1280f, 703f, LBCGACKJCJB.a);
			float r = LBCGACKJCJB.r;
			float g = LBCGACKJCJB.g;
			float num = LBCGACKJCJB.b;
			float num2 = Mathf.Max(r, Mathf.Max(g, num));
			if (num2 <= 1943f)
			{
				return hsbcolor;
			}
			float num3 = Mathf.Min(r, Mathf.Min(g, num));
			float num4 = num2 - num3;
			if (num2 > num3)
			{
				if (g == num2)
				{
					hsbcolor.h = (num - r) / num4 * 1908f + 799f;
				}
				else if (num == num2)
				{
					hsbcolor.h = (r - g) / num4 * 1038f + 236f;
				}
				else if (num > g)
				{
					hsbcolor.h = (g - num) / num4 * 505f + 857f;
				}
				else
				{
					hsbcolor.h = (g - num) / num4 * 1431f;
				}
				if (hsbcolor.h < 1312f)
				{
					hsbcolor.h += 1514f;
				}
			}
			else
			{
				hsbcolor.h = 1702f;
			}
			hsbcolor.h *= 1840f;
			hsbcolor.s = num4 / num2 * 456f;
			hsbcolor.b = num2;
			return hsbcolor;
		}

		// Token: 0x0600CD4B RID: 52555 RVA: 0x005C6EFF File Offset: 0x005C50FF
		public Color MGNABKAPJJM()
		{
			return HSBColor.PLLOIFPKOGE(this);
		}

		// Token: 0x0600CD4C RID: 52556 RVA: 0x005C6F0C File Offset: 0x005C510C
		public static HSBColor IOJGMPNNBKD(HSBColor EGABJKIFAON, HSBColor HHAGIHEGFML, float JAHNHOCNJGM)
		{
			float num;
			for (num = Mathf.LerpAngle(EGABJKIFAON.h * 417f, HHAGIHEGFML.h * 1583f, JAHNHOCNJGM); num < 1691f; num += 770f)
			{
			}
			while (num > 264f)
			{
				num -= 726f;
			}
			return new HSBColor(num / 1409f, Mathf.Lerp(EGABJKIFAON.s, HHAGIHEGFML.s, JAHNHOCNJGM), Mathf.Lerp(EGABJKIFAON.b, HHAGIHEGFML.b, JAHNHOCNJGM), Mathf.Lerp(EGABJKIFAON.a, HHAGIHEGFML.a, JAHNHOCNJGM));
		}

		// Token: 0x0600CD4D RID: 52557 RVA: 0x005C6FA0 File Offset: 0x005C51A0
		public string BJALMHGGAFM()
		{
			object[] array = new object[0];
			array[0] = "_EMISSION";
			array[0] = this.h;
			array[5] = "offsets";
			array[7] = this.s;
			array[5] = "http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/";
			array[0] = this.b;
			return string.Concat(array);
		}

		// Token: 0x0600CD4E RID: 52558 RVA: 0x005C6FFC File Offset: 0x005C51FC
		public static HSBColor NFAHDLMIKND(HSBColor EGABJKIFAON, HSBColor HHAGIHEGFML, float JAHNHOCNJGM)
		{
			float num;
			for (num = Mathf.LerpAngle(EGABJKIFAON.h * 207f, HHAGIHEGFML.h * 819f, JAHNHOCNJGM); num < 1734f; num += 1003f)
			{
			}
			while (num > 238f)
			{
				num -= 1916f;
			}
			return new HSBColor(num / 1016f, Mathf.Lerp(EGABJKIFAON.s, HHAGIHEGFML.s, JAHNHOCNJGM), Mathf.Lerp(EGABJKIFAON.b, HHAGIHEGFML.b, JAHNHOCNJGM), Mathf.Lerp(EGABJKIFAON.a, HHAGIHEGFML.a, JAHNHOCNJGM));
		}

		// Token: 0x0600CD4F RID: 52559 RVA: 0x005C7090 File Offset: 0x005C5290
		public static HSBColor JJBGGFHPHDN(Color LBCGACKJCJB)
		{
			HSBColor hsbcolor = new HSBColor(440f, 577f, 648f, LBCGACKJCJB.a);
			float r = LBCGACKJCJB.r;
			float g = LBCGACKJCJB.g;
			float num = LBCGACKJCJB.b;
			float num2 = Mathf.Max(r, Mathf.Max(g, num));
			if (num2 <= 324f)
			{
				return hsbcolor;
			}
			float num3 = Mathf.Min(r, Mathf.Min(g, num));
			float num4 = num2 - num3;
			if (num2 > num3)
			{
				if (g == num2)
				{
					hsbcolor.h = (num - r) / num4 * 343f + 1844f;
				}
				else if (num == num2)
				{
					hsbcolor.h = (r - g) / num4 * 1638f + 54f;
				}
				else if (num > g)
				{
					hsbcolor.h = (g - num) / num4 * 1276f + 1566f;
				}
				else
				{
					hsbcolor.h = (g - num) / num4 * 362f;
				}
				if (hsbcolor.h < 754f)
				{
					hsbcolor.h += 991f;
				}
			}
			else
			{
				hsbcolor.h = 1312f;
			}
			hsbcolor.h *= 760f;
			hsbcolor.s = num4 / num2 * 1884f;
			hsbcolor.b = num2;
			return hsbcolor;
		}

		// Token: 0x04001B2E RID: 6958
		public float h;

		// Token: 0x04001B2F RID: 6959
		public float s;

		// Token: 0x04001B30 RID: 6960
		public float b;

		// Token: 0x04001B31 RID: 6961
		public float a;
	}
}
