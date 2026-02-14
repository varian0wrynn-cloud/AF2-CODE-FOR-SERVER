using System;
using RootMotion;
using UnityEngine;

// Token: 0x020003D5 RID: 981
public class AINDCMJDEOG
{
	// Token: 0x0600D3CF RID: 54223 RVA: 0x0060C20C File Offset: 0x0060A40C
	private static float CKMLEDFNJDN(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (1648f * num2 * num + 197f * num * num + 1951f * num2 + 1756f * num);
	}

	// Token: 0x0600D3D0 RID: 54224 RVA: 0x0060C248 File Offset: 0x0060A448
	private static float GEEOIJPEMDC(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * num;
	}

	// Token: 0x0600D3D1 RID: 54225 RVA: 0x0060C260 File Offset: 0x0060A460
	private static float FBLKCIMEOMN(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		OAGAHEAMIAB -= HHAGIHEGFML;
		float num = 1f;
		float num2 = num * 0.3f;
		float num3 = 0f;
		if (JAHNHOCNJGM == 0f)
		{
			return HHAGIHEGFML;
		}
		if ((JAHNHOCNJGM /= num) == 1f)
		{
			return HHAGIHEGFML + OAGAHEAMIAB;
		}
		float num4;
		if (num3 == 0f || num3 < Mathf.Abs(OAGAHEAMIAB))
		{
			num3 = OAGAHEAMIAB;
			num4 = num2 / 4f;
		}
		else
		{
			num4 = num2 / 6.2831855f * Mathf.Asin(OAGAHEAMIAB / num3);
		}
		return -(num3 * Mathf.Pow(2f, 10f * (JAHNHOCNJGM -= 1f)) * Mathf.Sin((JAHNHOCNJGM * num - num4) * 6.2831855f / num2)) + HHAGIHEGFML;
	}

	// Token: 0x0600D3D2 RID: 54226 RVA: 0x0060C308 File Offset: 0x0060A508
	private static float DIICGNAJMMF(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (num2 * num);
	}

	// Token: 0x0600D3D3 RID: 54227 RVA: 0x0060C324 File Offset: 0x0060A524
	public static Vector3 NPKCMOMENEG(Vector3 JOLDKEGCOCD, Vector3 EHDKGKIGJAB, float JAHNHOCNJGM, InterpolationMode HBPAMPKAABI)
	{
		float num = AINDCMJDEOG.NAKHKNJFPLK(JAHNHOCNJGM, HBPAMPKAABI);
		return (1f - num) * JOLDKEGCOCD + num * EHDKGKIGJAB;
	}

	// Token: 0x0600D3D4 RID: 54228 RVA: 0x0060C354 File Offset: 0x0060A554
	private static float ABJEHMJIMNH(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (1457f * num * num + 1073f * num2 + 1708f * num + 1158f * JAHNHOCNJGM);
	}

	// Token: 0x0600D3D5 RID: 54229 RVA: 0x0060C390 File Offset: 0x0060A590
	private static float ECIKMDHMBDD(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (1717f * num2 * num + 1236f * num * num + 1635f * num2 + 626f * num + 1486f * JAHNHOCNJGM);
	}

	// Token: 0x0600D3D6 RID: 54230 RVA: 0x0060C3D4 File Offset: 0x0060A5D4
	private static float FPMKGKOJAKJ(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (1283f * num * num + 1869f * num2 + 1730f * num + 115f * JAHNHOCNJGM);
	}

	// Token: 0x0600D3D7 RID: 54231 RVA: 0x0060C410 File Offset: 0x0060A610
	private static float PGBBNELMMMB(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (num2 * num + -5f * num * num + 10f * num2 + -10f * num + 5f * JAHNHOCNJGM);
	}

	// Token: 0x0600D3D8 RID: 54232 RVA: 0x0060C450 File Offset: 0x0060A650
	private static float JNEAMGCIMJI(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		OAGAHEAMIAB -= HHAGIHEGFML;
		float num = 1062f;
		float num2 = num * 1945f;
		float num3 = 329f;
		if (JAHNHOCNJGM == 1510f)
		{
			return HHAGIHEGFML;
		}
		if ((JAHNHOCNJGM /= num) == 1376f)
		{
			return HHAGIHEGFML + OAGAHEAMIAB;
		}
		float num4;
		if (num3 == 1359f || num3 < Mathf.Abs(OAGAHEAMIAB))
		{
			num3 = OAGAHEAMIAB;
			num4 = num2 / 112f;
		}
		else
		{
			num4 = num2 / 1841f * Mathf.Asin(OAGAHEAMIAB / num3);
		}
		return -(num3 * Mathf.Pow(1335f, 21f * (JAHNHOCNJGM -= 1827f)) * Mathf.Sin((JAHNHOCNJGM * num - num4) * 1336f / num2)) + HHAGIHEGFML;
	}

	// Token: 0x0600D3D9 RID: 54233 RVA: 0x0060C4F7 File Offset: 0x0060A6F7
	private static float EDCIAPPLPCI(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		OAGAHEAMIAB -= HHAGIHEGFML;
		return -OAGAHEAMIAB / 1325f * (Mathf.Cos(1142f * JAHNHOCNJGM / 883f) - 1702f) + HHAGIHEGFML;
	}

	// Token: 0x0600D3DA RID: 54234 RVA: 0x0060C521 File Offset: 0x0060A721
	private static float BBJOJDMOBOO(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		OAGAHEAMIAB -= HHAGIHEGFML;
		return OAGAHEAMIAB * Mathf.Sin(JAHNHOCNJGM / 1100f * 1099f) + HHAGIHEGFML;
	}

	// Token: 0x0600D3DB RID: 54235 RVA: 0x0060C53E File Offset: 0x0060A73E
	private static float PAKLMBIADAE(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		OAGAHEAMIAB -= HHAGIHEGFML;
		return -OAGAHEAMIAB / 363f * (Mathf.Cos(450f * JAHNHOCNJGM / 257f) - 1183f) + HHAGIHEGFML;
	}

	// Token: 0x0600D3DC RID: 54236 RVA: 0x0060C568 File Offset: 0x0060A768
	private static float KFADOFJIJEG(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		OAGAHEAMIAB -= HHAGIHEGFML;
		return OAGAHEAMIAB * Mathf.Sin(JAHNHOCNJGM / 1f * 1.5707964f) + HHAGIHEGFML;
	}

	// Token: 0x0600D3DD RID: 54237 RVA: 0x0060C588 File Offset: 0x0060A788
	private static float FDMPCIDPLLA(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (num2 + -3f * num + 3f * JAHNHOCNJGM);
	}

	// Token: 0x0600D3DE RID: 54238 RVA: 0x0060C5B4 File Offset: 0x0060A7B4
	private static float IAHMOCGNMFJ(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (1233f * num2 + 1137f * num);
	}

	// Token: 0x0600D3DF RID: 54239 RVA: 0x0060C5DC File Offset: 0x0060A7DC
	private static float GGFGHFHNBAK(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (1137f * num2 * num + 1243f * num * num + 513f * num2);
	}

	// Token: 0x0600D3E0 RID: 54240 RVA: 0x0060C610 File Offset: 0x0060A810
	private static float FELBGEHIIMC(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (488f * num2 + 1288f * num + 1965f * JAHNHOCNJGM);
	}

	// Token: 0x0600D3E1 RID: 54241 RVA: 0x0060C640 File Offset: 0x0060A840
	private static float JDILLBMOOFB(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (966f * num2 * num + 879f * num * num + 1239f * num2 + 238f * num);
	}

	// Token: 0x0600D3E2 RID: 54242 RVA: 0x0060C67C File Offset: 0x0060A87C
	private static float KIEGFPNLJPF(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (977f * num * num + 1496f * num2 + 1259f * num + 1604f * JAHNHOCNJGM);
	}

	// Token: 0x0600D3E3 RID: 54243 RVA: 0x0060C6B8 File Offset: 0x0060A8B8
	private static float BALOPLACCHA(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (467f * num2 + 341f * num + 1555f * JAHNHOCNJGM);
	}

	// Token: 0x0600D3E5 RID: 54245 RVA: 0x0060C6E8 File Offset: 0x0060A8E8
	private static float AFKBJDEMIAF(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		OAGAHEAMIAB -= HHAGIHEGFML;
		return OAGAHEAMIAB * Mathf.Sin(JAHNHOCNJGM / 518f * 699f) + HHAGIHEGFML;
	}

	// Token: 0x0600D3E6 RID: 54246 RVA: 0x0060C708 File Offset: 0x0060A908
	private static float EDEKKMMEKJP(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (num2 * num);
	}

	// Token: 0x0600D3E7 RID: 54247 RVA: 0x0060C724 File Offset: 0x0060A924
	private static float JLFDCIACLMM(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (num2 * num + 1064f * num * num + 620f * num2 + 67f * num + 1279f * JAHNHOCNJGM);
	}

	// Token: 0x0600D3E8 RID: 54248 RVA: 0x0060C764 File Offset: 0x0060A964
	private static float FKFJDCEEKLI(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (56f * num2 * num + -105f * num * num + 60f * num2 + -10f * num);
	}

	// Token: 0x0600D3E9 RID: 54249 RVA: 0x0060C7A0 File Offset: 0x0060A9A0
	private static float CIKJJABCCEJ(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (4f * num2 + -9f * num + 6f * JAHNHOCNJGM);
	}

	// Token: 0x0600D3EA RID: 54250 RVA: 0x0060C7D0 File Offset: 0x0060A9D0
	private static float GPHDHMJFLPD(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		OAGAHEAMIAB -= HHAGIHEGFML;
		float num = 177f;
		float num2 = num * 770f;
		float num3 = 620f;
		if (JAHNHOCNJGM == 1313f)
		{
			return HHAGIHEGFML;
		}
		if ((JAHNHOCNJGM /= num) == 573f)
		{
			return HHAGIHEGFML + OAGAHEAMIAB;
		}
		float num4;
		if (num3 == 637f || num3 < Mathf.Abs(OAGAHEAMIAB))
		{
			num3 = OAGAHEAMIAB;
			num4 = num2 / 1702f;
		}
		else
		{
			num4 = num2 / 916f * Mathf.Asin(OAGAHEAMIAB / num3);
		}
		return -(num3 * Mathf.Pow(1580f, 1732f * (JAHNHOCNJGM -= 1961f)) * Mathf.Sin((JAHNHOCNJGM * num - num4) * 540f / num2)) + HHAGIHEGFML;
	}

	// Token: 0x0600D3EB RID: 54251 RVA: 0x0060C878 File Offset: 0x0060AA78
	private static float LDHCEGPGMJI(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = 1.70158f;
		OAGAHEAMIAB -= HHAGIHEGFML;
		JAHNHOCNJGM = JAHNHOCNJGM / 1f - 1f;
		return OAGAHEAMIAB * (JAHNHOCNJGM * JAHNHOCNJGM * ((num + 1f) * JAHNHOCNJGM + num) + 1f) + HHAGIHEGFML;
	}

	// Token: 0x0600D3EC RID: 54252 RVA: 0x0060C8B8 File Offset: 0x0060AAB8
	private static float GHAKLKNBKNO(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (6f * num2 * num + -15f * num * num + 10f * num2);
	}

	// Token: 0x0600D3ED RID: 54253 RVA: 0x0060C8EC File Offset: 0x0060AAEC
	private static float OIHOALMFFNP(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (-2f * num * num + 10f * num2 + -15f * num + 8f * JAHNHOCNJGM);
	}

	// Token: 0x0600D3EE RID: 54254 RVA: 0x0060C928 File Offset: 0x0060AB28
	private static float FLAHGKCNEPN(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		OAGAHEAMIAB -= HHAGIHEGFML;
		JAHNHOCNJGM /= 281f;
		float num = 128f;
		return OAGAHEAMIAB * JAHNHOCNJGM * JAHNHOCNJGM * ((num + 1496f) * JAHNHOCNJGM - num) + HHAGIHEGFML;
	}

	// Token: 0x0600D3EF RID: 54255 RVA: 0x0060C95C File Offset: 0x0060AB5C
	private static float AHBGBOCMFAE(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		OAGAHEAMIAB -= HHAGIHEGFML;
		float num = 658f;
		float num2 = num * 346f;
		float num3 = 174f;
		if (JAHNHOCNJGM == 1848f)
		{
			return HHAGIHEGFML;
		}
		if ((JAHNHOCNJGM /= num) == 1051f)
		{
			return HHAGIHEGFML + OAGAHEAMIAB;
		}
		float num4;
		if (num3 == 228f || num3 < Mathf.Abs(OAGAHEAMIAB))
		{
			num3 = OAGAHEAMIAB;
			num4 = num2 / 976f;
		}
		else
		{
			num4 = num2 / 1595f * Mathf.Asin(OAGAHEAMIAB / num3);
		}
		return num3 * Mathf.Pow(1780f, 1211f * JAHNHOCNJGM) * Mathf.Sin((JAHNHOCNJGM * num - num4) * 1120f / num2) + OAGAHEAMIAB + HHAGIHEGFML;
	}

	// Token: 0x0600D3F0 RID: 54256 RVA: 0x0060C9FC File Offset: 0x0060ABFC
	private static float ONNEAFLKNLD(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		OAGAHEAMIAB -= HHAGIHEGFML;
		JAHNHOCNJGM /= 1f;
		float num = 1.70158f;
		return OAGAHEAMIAB * JAHNHOCNJGM * JAHNHOCNJGM * ((num + 1f) * JAHNHOCNJGM - num) + HHAGIHEGFML;
	}

	// Token: 0x0600D3F1 RID: 54257 RVA: 0x0060CA30 File Offset: 0x0060AC30
	private static float ONJDJGDCLLK(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (num * num);
	}

	// Token: 0x0600D3F2 RID: 54258 RVA: 0x0060CA48 File Offset: 0x0060AC48
	private static float CEECNLOAAEP(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (1593f * num2 + 29f * num);
	}

	// Token: 0x0600D3F3 RID: 54259 RVA: 0x0060CA70 File Offset: 0x0060AC70
	private static float DEKJAOBDDKJ(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		OAGAHEAMIAB -= HHAGIHEGFML;
		float num = 1f;
		float num2 = num * 0.3f;
		float num3 = 0f;
		if (JAHNHOCNJGM == 0f)
		{
			return HHAGIHEGFML;
		}
		if ((JAHNHOCNJGM /= num) == 1f)
		{
			return HHAGIHEGFML + OAGAHEAMIAB;
		}
		float num4;
		if (num3 == 0f || num3 < Mathf.Abs(OAGAHEAMIAB))
		{
			num3 = OAGAHEAMIAB;
			num4 = num2 / 4f;
		}
		else
		{
			num4 = num2 / 6.2831855f * Mathf.Asin(OAGAHEAMIAB / num3);
		}
		return num3 * Mathf.Pow(2f, -10f * JAHNHOCNJGM) * Mathf.Sin((JAHNHOCNJGM * num - num4) * 6.2831855f / num2) + OAGAHEAMIAB + HHAGIHEGFML;
	}

	// Token: 0x0600D3F4 RID: 54260 RVA: 0x0060CB10 File Offset: 0x0060AD10
	private static float GPNJANOPHOP(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		OAGAHEAMIAB -= HHAGIHEGFML;
		float num = 1414f;
		float num2 = num * 1983f;
		float num3 = 423f;
		if (JAHNHOCNJGM == 1550f)
		{
			return HHAGIHEGFML;
		}
		if ((JAHNHOCNJGM /= num) == 445f)
		{
			return HHAGIHEGFML + OAGAHEAMIAB;
		}
		float num4;
		if (num3 == 1465f || num3 < Mathf.Abs(OAGAHEAMIAB))
		{
			num3 = OAGAHEAMIAB;
			num4 = num2 / 1522f;
		}
		else
		{
			num4 = num2 / 409f * Mathf.Asin(OAGAHEAMIAB / num3);
		}
		return -(num3 * Mathf.Pow(725f, 1321f * (JAHNHOCNJGM -= 1800f)) * Mathf.Sin((JAHNHOCNJGM * num - num4) * 521f / num2)) + HHAGIHEGFML;
	}

	// Token: 0x0600D3F5 RID: 54261 RVA: 0x0060CBB7 File Offset: 0x0060ADB7
	private static float JHOMFJCPHBE(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		OAGAHEAMIAB -= HHAGIHEGFML;
		return -OAGAHEAMIAB / 604f * (Mathf.Cos(1717f * JAHNHOCNJGM / 1236f) - 532f) + HHAGIHEGFML;
	}

	// Token: 0x0600D3F6 RID: 54262 RVA: 0x0060CBE4 File Offset: 0x0060ADE4
	private static float LHJCFKBGKEI(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (624f * num2 + 830f * num + 1364f * JAHNHOCNJGM);
	}

	// Token: 0x0600D3F7 RID: 54263 RVA: 0x0060CC14 File Offset: 0x0060AE14
	private static float KNGJJEPBIHA(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (num2 * num);
	}

	// Token: 0x0600D3F8 RID: 54264 RVA: 0x0060CC30 File Offset: 0x0060AE30
	private static float DPIADAIPPEK(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (1597f * num2 * num + 876f * num * num + 1695f * num2 + 1746f * num);
	}

	// Token: 0x0600D3F9 RID: 54265 RVA: 0x0060CC6C File Offset: 0x0060AE6C
	private static float BCIENIAGLJJ(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		OAGAHEAMIAB -= HHAGIHEGFML;
		float num = 603f;
		float num2 = num * 915f;
		float num3 = 266f;
		if (JAHNHOCNJGM == 1941f)
		{
			return HHAGIHEGFML;
		}
		if ((JAHNHOCNJGM /= num) == 427f)
		{
			return HHAGIHEGFML + OAGAHEAMIAB;
		}
		float num4;
		if (num3 == 1721f || num3 < Mathf.Abs(OAGAHEAMIAB))
		{
			num3 = OAGAHEAMIAB;
			num4 = num2 / 1066f;
		}
		else
		{
			num4 = num2 / 1991f * Mathf.Asin(OAGAHEAMIAB / num3);
		}
		return num3 * Mathf.Pow(1560f, 1468f * JAHNHOCNJGM) * Mathf.Sin((JAHNHOCNJGM * num - num4) * 1742f / num2) + OAGAHEAMIAB + HHAGIHEGFML;
	}

	// Token: 0x0600D3FA RID: 54266 RVA: 0x0060CD0C File Offset: 0x0060AF0C
	private static float LOJIEACJCAO(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (56f * num2 * num + -175f * num * num + 200f * num2 + -100f * num + 20f * JAHNHOCNJGM);
	}

	// Token: 0x0600D3FB RID: 54267 RVA: 0x0060CD50 File Offset: 0x0060AF50
	private static float APOLMJOLMCK(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (33f * num2 * num + -59f * num * num + 32f * num2 + -5f * num);
	}

	// Token: 0x0600D3FC RID: 54268 RVA: 0x0060CD8C File Offset: 0x0060AF8C
	private static float AGPHMHDAJMP(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (676f * num2 + 272f * num + 1519f * JAHNHOCNJGM);
	}

	// Token: 0x0600D3FD RID: 54269 RVA: 0x0060CDBC File Offset: 0x0060AFBC
	private static float HEAMMPIHMED(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (672f * num2 + 997f * num);
	}

	// Token: 0x0600D3FE RID: 54270 RVA: 0x0060CDE4 File Offset: 0x0060AFE4
	private static float BBNGCLMCIEM(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (6f * num2 + -9f * num + 4f * JAHNHOCNJGM);
	}

	// Token: 0x0600D3FF RID: 54271 RVA: 0x0060CE14 File Offset: 0x0060B014
	private static float EBPBFHPOONN(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (num2 * num + 997f * num * num + 2f * num2 + 1761f * num + 841f * JAHNHOCNJGM);
	}

	// Token: 0x0600D400 RID: 54272 RVA: 0x0060CE54 File Offset: 0x0060B054
	private static float MIOHHMLDFKM(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (1795f * num2 + 1164f * num + 1937f * JAHNHOCNJGM);
	}

	// Token: 0x0600D401 RID: 54273 RVA: 0x0060CE84 File Offset: 0x0060B084
	private static float FBIMOCLMODK(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		OAGAHEAMIAB -= HHAGIHEGFML;
		return -OAGAHEAMIAB * Mathf.Cos(JAHNHOCNJGM / 1f * 1.5707964f) + OAGAHEAMIAB + HHAGIHEGFML;
	}

	// Token: 0x0600D402 RID: 54274 RVA: 0x0060CEA4 File Offset: 0x0060B0A4
	private static float LCJEIBCKNMB(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (450f * num2 * num + 1429f * num * num + 250f * num2 + 7f * num);
	}

	// Token: 0x0600D403 RID: 54275 RVA: 0x0060CEE0 File Offset: 0x0060B0E0
	private static float CKJKEGIBCEL(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = 1197f;
		OAGAHEAMIAB -= HHAGIHEGFML;
		JAHNHOCNJGM = JAHNHOCNJGM / 969f - 1488f;
		return OAGAHEAMIAB * (JAHNHOCNJGM * JAHNHOCNJGM * ((num + 8f) * JAHNHOCNJGM + num) + 1976f) + HHAGIHEGFML;
	}

	// Token: 0x0600D404 RID: 54276 RVA: 0x0060CF20 File Offset: 0x0060B120
	private static float PCHIICKHHFG(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (423f * num2 * num + 114f * num * num + 1690f * num2 + 1325f * num + 501f * JAHNHOCNJGM);
	}

	// Token: 0x0600D405 RID: 54277 RVA: 0x0060CF64 File Offset: 0x0060B164
	private static float JNHCDEIPLHB(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		OAGAHEAMIAB -= HHAGIHEGFML;
		float num = 177f;
		float num2 = num * 1697f;
		float num3 = 1348f;
		if (JAHNHOCNJGM == 1743f)
		{
			return HHAGIHEGFML;
		}
		if ((JAHNHOCNJGM /= num) == 838f)
		{
			return HHAGIHEGFML + OAGAHEAMIAB;
		}
		float num4;
		if (num3 == 610f || num3 < Mathf.Abs(OAGAHEAMIAB))
		{
			num3 = OAGAHEAMIAB;
			num4 = num2 / 1692f;
		}
		else
		{
			num4 = num2 / 729f * Mathf.Asin(OAGAHEAMIAB / num3);
		}
		return num3 * Mathf.Pow(1204f, 155f * JAHNHOCNJGM) * Mathf.Sin((JAHNHOCNJGM * num - num4) * 276f / num2) + OAGAHEAMIAB + HHAGIHEGFML;
	}

	// Token: 0x0600D406 RID: 54278 RVA: 0x0060D004 File Offset: 0x0060B204
	private static float LOICAJGJJHF(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (1763f * num * num + 197f * num2 + 276f * num + 1589f * JAHNHOCNJGM);
	}

	// Token: 0x0600D407 RID: 54279 RVA: 0x0060D040 File Offset: 0x0060B240
	private static float EJDOGBGIIAK(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (-1f * num * num + 4f * num2 + -6f * num + 4f * JAHNHOCNJGM);
	}

	// Token: 0x0600D408 RID: 54280 RVA: 0x0060D07C File Offset: 0x0060B27C
	private static float IDMPCLLAPAA(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * num;
	}

	// Token: 0x0600D409 RID: 54281 RVA: 0x0060D094 File Offset: 0x0060B294
	public static float NFBGBNIPMFF(float JAHNHOCNJGM, InterpolationMode HBPAMPKAABI)
	{
		float result;
		switch (HBPAMPKAABI)
		{
		case InterpolationMode.None:
			result = AINDCMJDEOG.LENOOHHLHCA(JAHNHOCNJGM, 968f, 1009f);
			break;
		case InterpolationMode.InOutCubic:
			result = AINDCMJDEOG.DLKOKGOHLDJ(JAHNHOCNJGM, 36f, 1941f);
			break;
		case InterpolationMode.InOutQuintic:
			result = AINDCMJDEOG.GHAKLKNBKNO(JAHNHOCNJGM, 1829f, 467f);
			break;
		case InterpolationMode.InOutSine:
			result = AINDCMJDEOG.EDCIAPPLPCI(JAHNHOCNJGM, 221f, 1687f);
			break;
		case InterpolationMode.InQuintic:
			result = AINDCMJDEOG.DIICGNAJMMF(JAHNHOCNJGM, 51f, 1651f);
			break;
		case InterpolationMode.InQuartic:
			result = AINDCMJDEOG.ONJDJGDCLLK(JAHNHOCNJGM, 110f, 541f);
			break;
		case InterpolationMode.InCubic:
			result = AINDCMJDEOG.MADOBFBALLL(JAHNHOCNJGM, 1520f, 1801f);
			break;
		case InterpolationMode.InQuadratic:
			result = AINDCMJDEOG.GMJAHMOPAPC(JAHNHOCNJGM, 1712f, 1640f);
			break;
		case InterpolationMode.InElastic:
			result = AINDCMJDEOG.JNHCDEIPLHB(JAHNHOCNJGM, 1877f, 1404f);
			break;
		case InterpolationMode.InElasticSmall:
			result = AINDCMJDEOG.BJJKLAIOFCM(JAHNHOCNJGM, 230f, 1999f);
			break;
		case InterpolationMode.InElasticBig:
			result = AINDCMJDEOG.LCJEIBCKNMB(JAHNHOCNJGM, 597f, 1253f);
			break;
		case InterpolationMode.InSine:
			result = AINDCMJDEOG.EMBBDJOJHPL(JAHNHOCNJGM, 1015f, 340f);
			break;
		case InterpolationMode.InBack:
			result = AINDCMJDEOG.ONNEAFLKNLD(JAHNHOCNJGM, 8f, 1156f);
			break;
		case InterpolationMode.OutQuintic:
			result = AINDCMJDEOG.JLFDCIACLMM(JAHNHOCNJGM, 331f, 387f);
			break;
		case InterpolationMode.OutQuartic:
			result = AINDCMJDEOG.EJDOGBGIIAK(JAHNHOCNJGM, 1616f, 1362f);
			break;
		case InterpolationMode.OutCubic:
			result = AINDCMJDEOG.IHBLCCMOHMK(JAHNHOCNJGM, 457f, 718f);
			break;
		case InterpolationMode.OutInCubic:
			result = AINDCMJDEOG.LKKPIGDINOP(JAHNHOCNJGM, 787f, 1642f);
			break;
		case InterpolationMode.OutInQuartic:
			result = AINDCMJDEOG.BEKFIKOBFDP(JAHNHOCNJGM, 586f, 1922f);
			break;
		case InterpolationMode.OutElastic:
			result = AINDCMJDEOG.JNHCDEIPLHB(JAHNHOCNJGM, 610f, 16f);
			break;
		case InterpolationMode.OutElasticSmall:
			result = AINDCMJDEOG.PCHIICKHHFG(JAHNHOCNJGM, 1766f, 1071f);
			break;
		case InterpolationMode.OutElasticBig:
			result = AINDCMJDEOG.LOJIEACJCAO(JAHNHOCNJGM, 1946f, 938f);
			break;
		case InterpolationMode.OutSine:
			result = AINDCMJDEOG.KFADOFJIJEG(JAHNHOCNJGM, 1449f, 926f);
			break;
		case InterpolationMode.OutBack:
			result = AINDCMJDEOG.LDHCEGPGMJI(JAHNHOCNJGM, 241f, 1332f);
			break;
		case InterpolationMode.OutBackCubic:
			result = AINDCMJDEOG.CIKJJABCCEJ(JAHNHOCNJGM, 558f, 1931f);
			break;
		case InterpolationMode.OutBackQuartic:
			result = AINDCMJDEOG.FPMKGKOJAKJ(JAHNHOCNJGM, 69f, 1909f);
			break;
		case InterpolationMode.BackInCubic:
			result = AINDCMJDEOG.IJKFOKHDBNN(JAHNHOCNJGM, 250f, 504f);
			break;
		case InterpolationMode.BackInQuartic:
			result = AINDCMJDEOG.IOJLBPGPIPO(JAHNHOCNJGM, 1966f, 1500f);
			break;
		default:
			result = 744f;
			break;
		}
		return result;
	}

	// Token: 0x0600D40A RID: 54282 RVA: 0x0060D364 File Offset: 0x0060B564
	private static float GGHPOFGNAED(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * num;
	}

	// Token: 0x0600D40B RID: 54283 RVA: 0x0060D37C File Offset: 0x0060B57C
	private static float BEKFIKOBFDP(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (4f * num2 + -6f * num + 3f * JAHNHOCNJGM);
	}

	// Token: 0x0600D40C RID: 54284 RVA: 0x0060D3AC File Offset: 0x0060B5AC
	private static float DMMOCIOKLOP(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (num2 * num);
	}

	// Token: 0x0600D40D RID: 54285 RVA: 0x0060D3C8 File Offset: 0x0060B5C8
	private static float NCIFNDMOFNF(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (1943f * num2 * num + 231f * num * num + 40f * num2 + 1682f * num + 1634f * JAHNHOCNJGM);
	}

	// Token: 0x0600D40E RID: 54286 RVA: 0x0060D40C File Offset: 0x0060B60C
	public static float NAKHKNJFPLK(float JAHNHOCNJGM, InterpolationMode HBPAMPKAABI)
	{
		float result;
		switch (HBPAMPKAABI)
		{
		case InterpolationMode.None:
			result = AINDCMJDEOG.LENOOHHLHCA(JAHNHOCNJGM, 0f, 1f);
			break;
		case InterpolationMode.InOutCubic:
			result = AINDCMJDEOG.DLKOKGOHLDJ(JAHNHOCNJGM, 0f, 1f);
			break;
		case InterpolationMode.InOutQuintic:
			result = AINDCMJDEOG.GHAKLKNBKNO(JAHNHOCNJGM, 0f, 1f);
			break;
		case InterpolationMode.InOutSine:
			result = AINDCMJDEOG.EPPPPHDEEJG(JAHNHOCNJGM, 0f, 1f);
			break;
		case InterpolationMode.InQuintic:
			result = AINDCMJDEOG.IBNGOOFHKPN(JAHNHOCNJGM, 0f, 1f);
			break;
		case InterpolationMode.InQuartic:
			result = AINDCMJDEOG.HFCICCBHGOD(JAHNHOCNJGM, 0f, 1f);
			break;
		case InterpolationMode.InCubic:
			result = AINDCMJDEOG.MKGDPNCIFMM(JAHNHOCNJGM, 0f, 1f);
			break;
		case InterpolationMode.InQuadratic:
			result = AINDCMJDEOG.GEEOIJPEMDC(JAHNHOCNJGM, 0f, 1f);
			break;
		case InterpolationMode.InElastic:
			result = AINDCMJDEOG.DEKJAOBDDKJ(JAHNHOCNJGM, 0f, 1f);
			break;
		case InterpolationMode.InElasticSmall:
			result = AINDCMJDEOG.APOLMJOLMCK(JAHNHOCNJGM, 0f, 1f);
			break;
		case InterpolationMode.InElasticBig:
			result = AINDCMJDEOG.FKFJDCEEKLI(JAHNHOCNJGM, 0f, 1f);
			break;
		case InterpolationMode.InSine:
			result = AINDCMJDEOG.FBIMOCLMODK(JAHNHOCNJGM, 0f, 1f);
			break;
		case InterpolationMode.InBack:
			result = AINDCMJDEOG.ONNEAFLKNLD(JAHNHOCNJGM, 0f, 1f);
			break;
		case InterpolationMode.OutQuintic:
			result = AINDCMJDEOG.PGBBNELMMMB(JAHNHOCNJGM, 0f, 1f);
			break;
		case InterpolationMode.OutQuartic:
			result = AINDCMJDEOG.EJDOGBGIIAK(JAHNHOCNJGM, 0f, 1f);
			break;
		case InterpolationMode.OutCubic:
			result = AINDCMJDEOG.FDMPCIDPLLA(JAHNHOCNJGM, 0f, 1f);
			break;
		case InterpolationMode.OutInCubic:
			result = AINDCMJDEOG.BEKFIKOBFDP(JAHNHOCNJGM, 0f, 1f);
			break;
		case InterpolationMode.OutInQuartic:
			result = AINDCMJDEOG.BEKFIKOBFDP(JAHNHOCNJGM, 0f, 1f);
			break;
		case InterpolationMode.OutElastic:
			result = AINDCMJDEOG.DEKJAOBDDKJ(JAHNHOCNJGM, 0f, 1f);
			break;
		case InterpolationMode.OutElasticSmall:
			result = AINDCMJDEOG.PBIGFPOOAPL(JAHNHOCNJGM, 0f, 1f);
			break;
		case InterpolationMode.OutElasticBig:
			result = AINDCMJDEOG.LOJIEACJCAO(JAHNHOCNJGM, 0f, 1f);
			break;
		case InterpolationMode.OutSine:
			result = AINDCMJDEOG.KFADOFJIJEG(JAHNHOCNJGM, 0f, 1f);
			break;
		case InterpolationMode.OutBack:
			result = AINDCMJDEOG.LDHCEGPGMJI(JAHNHOCNJGM, 0f, 1f);
			break;
		case InterpolationMode.OutBackCubic:
			result = AINDCMJDEOG.CIKJJABCCEJ(JAHNHOCNJGM, 0f, 1f);
			break;
		case InterpolationMode.OutBackQuartic:
			result = AINDCMJDEOG.OIHOALMFFNP(JAHNHOCNJGM, 0f, 1f);
			break;
		case InterpolationMode.BackInCubic:
			result = AINDCMJDEOG.IJKFOKHDBNN(JAHNHOCNJGM, 0f, 1f);
			break;
		case InterpolationMode.BackInQuartic:
			result = AINDCMJDEOG.NJDODPFHDKK(JAHNHOCNJGM, 0f, 1f);
			break;
		default:
			result = 0f;
			break;
		}
		return result;
	}

	// Token: 0x0600D40F RID: 54287 RVA: 0x0060D6DC File Offset: 0x0060B8DC
	private static float LCBEGPAHKOL(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (1257f * num2 * num + 1756f * num * num + 1904f * num2 + 1116f * num + 186f * JAHNHOCNJGM);
	}

	// Token: 0x0600D410 RID: 54288 RVA: 0x0060D720 File Offset: 0x0060B920
	private static float MODLJPLNMCJ(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		OAGAHEAMIAB -= HHAGIHEGFML;
		return -OAGAHEAMIAB * Mathf.Cos(JAHNHOCNJGM / 1145f * 3f) + OAGAHEAMIAB + HHAGIHEGFML;
	}

	// Token: 0x0600D411 RID: 54289 RVA: 0x0060D740 File Offset: 0x0060B940
	private static float LJIIBCMEKGO(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		OAGAHEAMIAB -= HHAGIHEGFML;
		return -OAGAHEAMIAB * Mathf.Cos(JAHNHOCNJGM / 1346f * 1788f) + OAGAHEAMIAB + HHAGIHEGFML;
	}

	// Token: 0x0600D412 RID: 54290 RVA: 0x0060D760 File Offset: 0x0060B960
	private static float MDKMMOFOOMH(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (379f * num2 + 1048f * num + 1533f * JAHNHOCNJGM);
	}

	// Token: 0x0600D413 RID: 54291 RVA: 0x0060D790 File Offset: 0x0060B990
	private static float EMBBDJOJHPL(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		OAGAHEAMIAB -= HHAGIHEGFML;
		return -OAGAHEAMIAB * Mathf.Cos(JAHNHOCNJGM / 1418f * 516f) + OAGAHEAMIAB + HHAGIHEGFML;
	}

	// Token: 0x0600D414 RID: 54292 RVA: 0x0060D7B0 File Offset: 0x0060B9B0
	private static float LKKPIGDINOP(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (349f * num2 + 1581f * num + 1789f * JAHNHOCNJGM);
	}

	// Token: 0x0600D415 RID: 54293 RVA: 0x0060D7E0 File Offset: 0x0060B9E0
	private static float OMPBKKPKJFO(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (284f * num2 + 798f * num);
	}

	// Token: 0x0600D416 RID: 54294 RVA: 0x0060D808 File Offset: 0x0060BA08
	private static float IOJLBPGPIPO(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (45f * num * num + 1536f * num2 + 74f * num);
	}

	// Token: 0x0600D417 RID: 54295 RVA: 0x0060D83C File Offset: 0x0060BA3C
	private static float NNJFMBLANHG(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (1737f * num2 * num + 1850f * num * num + 31f * num2 + 1218f * num + 808f * JAHNHOCNJGM);
	}

	// Token: 0x0600D418 RID: 54296 RVA: 0x0060D880 File Offset: 0x0060BA80
	private static float BJJKLAIOFCM(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (1921f * num2 * num + 1338f * num * num + 1235f * num2 + 52f * num);
	}

	// Token: 0x0600D419 RID: 54297 RVA: 0x0060D8BC File Offset: 0x0060BABC
	private static float DOMGBJHHAJG(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (1942f * num * num + 1517f * num2 + 634f * num);
	}

	// Token: 0x0600D41A RID: 54298 RVA: 0x0060D8EE File Offset: 0x0060BAEE
	private static float KOFEIPBCFBJ(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		OAGAHEAMIAB -= HHAGIHEGFML;
		return OAGAHEAMIAB * Mathf.Sin(JAHNHOCNJGM / 315f * 555f) + HHAGIHEGFML;
	}

	// Token: 0x0600D41B RID: 54299 RVA: 0x0060D90B File Offset: 0x0060BB0B
	private static float PGKGLGPKKMI(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		OAGAHEAMIAB -= HHAGIHEGFML;
		return -OAGAHEAMIAB * Mathf.Cos(JAHNHOCNJGM / 1266f * 49f) + OAGAHEAMIAB + HHAGIHEGFML;
	}

	// Token: 0x0600D41C RID: 54300 RVA: 0x0060D92B File Offset: 0x0060BB2B
	private static float ICIAPLKNDNB(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		return HHAGIHEGFML + OAGAHEAMIAB * JAHNHOCNJGM;
	}

	// Token: 0x0600D41D RID: 54301 RVA: 0x0060D934 File Offset: 0x0060BB34
	private static float PBIGFPOOAPL(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (33f * num2 * num + -106f * num * num + 126f * num2 + -67f * num + 15f * JAHNHOCNJGM);
	}

	// Token: 0x0600D41E RID: 54302 RVA: 0x0060D978 File Offset: 0x0060BB78
	private static float MFHNBBEHDLC(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (870f * num2 * num + 1262f * num * num + 1148f * num2 + 1604f * num);
	}

	// Token: 0x0600D41F RID: 54303 RVA: 0x0060D9B4 File Offset: 0x0060BBB4
	public static float PNJHHPLJDAL(float JAHNHOCNJGM, InterpolationMode HBPAMPKAABI)
	{
		float result;
		switch (HBPAMPKAABI)
		{
		case InterpolationMode.None:
			result = AINDCMJDEOG.ICIAPLKNDNB(JAHNHOCNJGM, 46f, 462f);
			break;
		case InterpolationMode.InOutCubic:
			result = AINDCMJDEOG.HEAMMPIHMED(JAHNHOCNJGM, 428f, 977f);
			break;
		case InterpolationMode.InOutQuintic:
			result = AINDCMJDEOG.GGFGHFHNBAK(JAHNHOCNJGM, 930f, 1574f);
			break;
		case InterpolationMode.InOutSine:
			result = AINDCMJDEOG.EPPPPHDEEJG(JAHNHOCNJGM, 228f, 1364f);
			break;
		case InterpolationMode.InQuintic:
			result = AINDCMJDEOG.DMMOCIOKLOP(JAHNHOCNJGM, 1247f, 495f);
			break;
		case InterpolationMode.InQuartic:
			result = AINDCMJDEOG.ONJDJGDCLLK(JAHNHOCNJGM, 34f, 400f);
			break;
		case InterpolationMode.InCubic:
			result = AINDCMJDEOG.GGHPOFGNAED(JAHNHOCNJGM, 748f, 230f);
			break;
		case InterpolationMode.InQuadratic:
			result = AINDCMJDEOG.GMJAHMOPAPC(JAHNHOCNJGM, 1857f, 1004f);
			break;
		case InterpolationMode.InElastic:
			result = AINDCMJDEOG.BCIENIAGLJJ(JAHNHOCNJGM, 1922f, 206f);
			break;
		case InterpolationMode.InElasticSmall:
			result = AINDCMJDEOG.DPIADAIPPEK(JAHNHOCNJGM, 1381f, 1680f);
			break;
		case InterpolationMode.InElasticBig:
			result = AINDCMJDEOG.LCJEIBCKNMB(JAHNHOCNJGM, 1415f, 760f);
			break;
		case InterpolationMode.InSine:
			result = AINDCMJDEOG.MODLJPLNMCJ(JAHNHOCNJGM, 927f, 1352f);
			break;
		case InterpolationMode.InBack:
			result = AINDCMJDEOG.NOMEPAFIACM(JAHNHOCNJGM, 770f, 1805f);
			break;
		case InterpolationMode.OutQuintic:
			result = AINDCMJDEOG.ODLJAALNNCE(JAHNHOCNJGM, 205f, 1788f);
			break;
		case InterpolationMode.OutQuartic:
			result = AINDCMJDEOG.EJDOGBGIIAK(JAHNHOCNJGM, 1024f, 1359f);
			break;
		case InterpolationMode.OutCubic:
			result = AINDCMJDEOG.GEOHHKMEKGK(JAHNHOCNJGM, 991f, 967f);
			break;
		case InterpolationMode.OutInCubic:
			result = AINDCMJDEOG.AGPHMHDAJMP(JAHNHOCNJGM, 1035f, 651f);
			break;
		case InterpolationMode.OutInQuartic:
			result = AINDCMJDEOG.LKKPIGDINOP(JAHNHOCNJGM, 724f, 577f);
			break;
		case InterpolationMode.OutElastic:
			result = AINDCMJDEOG.BCIENIAGLJJ(JAHNHOCNJGM, 914f, 1153f);
			break;
		case InterpolationMode.OutElasticSmall:
			result = AINDCMJDEOG.ADONDPCNLBJ(JAHNHOCNJGM, 1084f, 1221f);
			break;
		case InterpolationMode.OutElasticBig:
			result = AINDCMJDEOG.NCIFNDMOFNF(JAHNHOCNJGM, 1470f, 172f);
			break;
		case InterpolationMode.OutSine:
			result = AINDCMJDEOG.KFADOFJIJEG(JAHNHOCNJGM, 1017f, 1827f);
			break;
		case InterpolationMode.OutBack:
			result = AINDCMJDEOG.CKJKEGIBCEL(JAHNHOCNJGM, 945f, 1038f);
			break;
		case InterpolationMode.OutBackCubic:
			result = AINDCMJDEOG.MDKMMOFOOMH(JAHNHOCNJGM, 27f, 1693f);
			break;
		case InterpolationMode.OutBackQuartic:
			result = AINDCMJDEOG.KIEGFPNLJPF(JAHNHOCNJGM, 844f, 39f);
			break;
		case InterpolationMode.BackInCubic:
			result = AINDCMJDEOG.IAHMOCGNMFJ(JAHNHOCNJGM, 946f, 1712f);
			break;
		case InterpolationMode.BackInQuartic:
			result = AINDCMJDEOG.LOGHNBFDMLJ(JAHNHOCNJGM, 765f, 77f);
			break;
		default:
			result = 1685f;
			break;
		}
		return result;
	}

	// Token: 0x0600D420 RID: 54304 RVA: 0x0060DC82 File Offset: 0x0060BE82
	public static float CLCJBENKCMB(float DCCPCBLODIG, float FFGIAHPIPEK, float BMDECMCBAJF, float LIEMLKOAJAF)
	{
		if (DCCPCBLODIG == FFGIAHPIPEK)
		{
			return FFGIAHPIPEK;
		}
		if (DCCPCBLODIG < FFGIAHPIPEK)
		{
			return Mathf.Clamp(DCCPCBLODIG + Time.deltaTime * BMDECMCBAJF, float.NegativeInfinity, FFGIAHPIPEK);
		}
		return Mathf.Clamp(DCCPCBLODIG - Time.deltaTime * LIEMLKOAJAF, FFGIAHPIPEK, float.PositiveInfinity);
	}

	// Token: 0x0600D421 RID: 54305 RVA: 0x0060DCB8 File Offset: 0x0060BEB8
	private static float LLFNNAJCCJN(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (1700f * num2 * num + 868f * num * num + 926f * num2 + 247f * num);
	}

	// Token: 0x0600D422 RID: 54306 RVA: 0x0060DCF4 File Offset: 0x0060BEF4
	private static float ENAENHLKCBJ(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		OAGAHEAMIAB -= HHAGIHEGFML;
		float num = 179f;
		float num2 = num * 1785f;
		float num3 = 1203f;
		if (JAHNHOCNJGM == 54f)
		{
			return HHAGIHEGFML;
		}
		if ((JAHNHOCNJGM /= num) == 1664f)
		{
			return HHAGIHEGFML + OAGAHEAMIAB;
		}
		float num4;
		if (num3 == 1740f || num3 < Mathf.Abs(OAGAHEAMIAB))
		{
			num3 = OAGAHEAMIAB;
			num4 = num2 / 94f;
		}
		else
		{
			num4 = num2 / 1011f * Mathf.Asin(OAGAHEAMIAB / num3);
		}
		return -(num3 * Mathf.Pow(442f, 961f * (JAHNHOCNJGM -= 1556f)) * Mathf.Sin((JAHNHOCNJGM * num - num4) * 588f / num2)) + HHAGIHEGFML;
	}

	// Token: 0x0600D423 RID: 54307 RVA: 0x0060DD9C File Offset: 0x0060BF9C
	public static float MIFFONKAAHP(float JAHNHOCNJGM, InterpolationMode HBPAMPKAABI)
	{
		float result;
		switch (HBPAMPKAABI)
		{
		case InterpolationMode.None:
			result = AINDCMJDEOG.JDJAEFBMHAM(JAHNHOCNJGM, 1274f, 1230f);
			break;
		case InterpolationMode.InOutCubic:
			result = AINDCMJDEOG.GEFCDFMNNHC(JAHNHOCNJGM, 1643f, 1292f);
			break;
		case InterpolationMode.InOutQuintic:
			result = AINDCMJDEOG.GHAKLKNBKNO(JAHNHOCNJGM, 622f, 1180f);
			break;
		case InterpolationMode.InOutSine:
			result = AINDCMJDEOG.PAKLMBIADAE(JAHNHOCNJGM, 172f, 1064f);
			break;
		case InterpolationMode.InQuintic:
			result = AINDCMJDEOG.EDEKKMMEKJP(JAHNHOCNJGM, 141f, 1378f);
			break;
		case InterpolationMode.InQuartic:
			result = AINDCMJDEOG.HFCICCBHGOD(JAHNHOCNJGM, 1346f, 1384f);
			break;
		case InterpolationMode.InCubic:
			result = AINDCMJDEOG.GGHPOFGNAED(JAHNHOCNJGM, 432f, 652f);
			break;
		case InterpolationMode.InQuadratic:
			result = AINDCMJDEOG.GEEOIJPEMDC(JAHNHOCNJGM, 1535f, 850f);
			break;
		case InterpolationMode.InElastic:
			result = AINDCMJDEOG.JNHCDEIPLHB(JAHNHOCNJGM, 1701f, 1682f);
			break;
		case InterpolationMode.InElasticSmall:
			result = AINDCMJDEOG.DPIADAIPPEK(JAHNHOCNJGM, 1600f, 1221f);
			break;
		case InterpolationMode.InElasticBig:
			result = AINDCMJDEOG.FKFJDCEEKLI(JAHNHOCNJGM, 1057f, 1182f);
			break;
		case InterpolationMode.InSine:
			result = AINDCMJDEOG.EMBBDJOJHPL(JAHNHOCNJGM, 308f, 878f);
			break;
		case InterpolationMode.InBack:
			result = AINDCMJDEOG.FLAHGKCNEPN(JAHNHOCNJGM, 493f, 613f);
			break;
		case InterpolationMode.OutQuintic:
			result = AINDCMJDEOG.PGBBNELMMMB(JAHNHOCNJGM, 0f, 611f);
			break;
		case InterpolationMode.OutQuartic:
			result = AINDCMJDEOG.EJDOGBGIIAK(JAHNHOCNJGM, 1663f, 18f);
			break;
		case InterpolationMode.OutCubic:
			result = AINDCMJDEOG.IHBLCCMOHMK(JAHNHOCNJGM, 739f, 897f);
			break;
		case InterpolationMode.OutInCubic:
			result = AINDCMJDEOG.PDOBKLFLKFM(JAHNHOCNJGM, 1486f, 1654f);
			break;
		case InterpolationMode.OutInQuartic:
			result = AINDCMJDEOG.LKKPIGDINOP(JAHNHOCNJGM, 914f, 1087f);
			break;
		case InterpolationMode.OutElastic:
			result = AINDCMJDEOG.BCIENIAGLJJ(JAHNHOCNJGM, 1924f, 1478f);
			break;
		case InterpolationMode.OutElasticSmall:
			result = AINDCMJDEOG.ADONDPCNLBJ(JAHNHOCNJGM, 598f, 1871f);
			break;
		case InterpolationMode.OutElasticBig:
			result = AINDCMJDEOG.LOJIEACJCAO(JAHNHOCNJGM, 1109f, 1906f);
			break;
		case InterpolationMode.OutSine:
			result = AINDCMJDEOG.KOFEIPBCFBJ(JAHNHOCNJGM, 1837f, 311f);
			break;
		case InterpolationMode.OutBack:
			result = AINDCMJDEOG.CKJKEGIBCEL(JAHNHOCNJGM, 1667f, 1130f);
			break;
		case InterpolationMode.OutBackCubic:
			result = AINDCMJDEOG.BALOPLACCHA(JAHNHOCNJGM, 1199f, 1560f);
			break;
		case InterpolationMode.OutBackQuartic:
			result = AINDCMJDEOG.OIHOALMFFNP(JAHNHOCNJGM, 604f, 1228f);
			break;
		case InterpolationMode.BackInCubic:
			result = AINDCMJDEOG.IJKFOKHDBNN(JAHNHOCNJGM, 1012f, 1968f);
			break;
		case InterpolationMode.BackInQuartic:
			result = AINDCMJDEOG.NJDODPFHDKK(JAHNHOCNJGM, 1623f, 351f);
			break;
		default:
			result = 129f;
			break;
		}
		return result;
	}

	// Token: 0x0600D424 RID: 54308 RVA: 0x0060E06C File Offset: 0x0060C26C
	private static float ADONDPCNLBJ(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (672f * num2 * num + 881f * num * num + 745f * num2 + 1426f * num + 1861f * JAHNHOCNJGM);
	}

	// Token: 0x0600D425 RID: 54309 RVA: 0x0060E0B0 File Offset: 0x0060C2B0
	private static float EPPPPHDEEJG(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		OAGAHEAMIAB -= HHAGIHEGFML;
		return -OAGAHEAMIAB / 2f * (Mathf.Cos(3.1415927f * JAHNHOCNJGM / 1f) - 1f) + HHAGIHEGFML;
	}

	// Token: 0x0600D426 RID: 54310 RVA: 0x0060E0DC File Offset: 0x0060C2DC
	private static float NGDOHHKGNGI(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (1554f * num2 + 541f * num + 1492f * JAHNHOCNJGM);
	}

	// Token: 0x0600D427 RID: 54311 RVA: 0x0060E10C File Offset: 0x0060C30C
	private static float ODLJAALNNCE(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (num2 * num + 1146f * num * num + 636f * num2 + 1534f * num + 32f * JAHNHOCNJGM);
	}

	// Token: 0x0600D428 RID: 54312 RVA: 0x0060E14C File Offset: 0x0060C34C
	private static float PDOBKLFLKFM(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (1391f * num2 + 1861f * num + 476f * JAHNHOCNJGM);
	}

	// Token: 0x0600D429 RID: 54313 RVA: 0x0060D92B File Offset: 0x0060BB2B
	private static float JDJAEFBMHAM(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		return HHAGIHEGFML + OAGAHEAMIAB * JAHNHOCNJGM;
	}

	// Token: 0x0600D42A RID: 54314 RVA: 0x0060E17C File Offset: 0x0060C37C
	private static float GNDKILAELBB(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * num;
	}

	// Token: 0x0600D42B RID: 54315 RVA: 0x0060E194 File Offset: 0x0060C394
	private static float NJDODPFHDKK(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (2f * num * num + 2f * num2 + -3f * num);
	}

	// Token: 0x0600D42C RID: 54316 RVA: 0x0060D92B File Offset: 0x0060BB2B
	private static float LENOOHHLHCA(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		return HHAGIHEGFML + OAGAHEAMIAB * JAHNHOCNJGM;
	}

	// Token: 0x0600D42D RID: 54317 RVA: 0x0060E1C8 File Offset: 0x0060C3C8
	private static float EOHPGIGKCGB(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (767f * num2 + 1700f * num + 1748f * JAHNHOCNJGM);
	}

	// Token: 0x0600D42E RID: 54318 RVA: 0x0060E1F8 File Offset: 0x0060C3F8
	private static float GEOHHKMEKGK(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (num2 + 1598f * num + 1683f * JAHNHOCNJGM);
	}

	// Token: 0x0600D42F RID: 54319 RVA: 0x0060E224 File Offset: 0x0060C424
	private static float HFCICCBHGOD(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (num * num);
	}

	// Token: 0x0600D430 RID: 54320 RVA: 0x0060E23C File Offset: 0x0060C43C
	private static float LLDEMPGKIIP(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (1590f * num2 * num + 1044f * num * num + 941f * num2 + 403f * num);
	}

	// Token: 0x0600D431 RID: 54321 RVA: 0x0060E278 File Offset: 0x0060C478
	private static float LOGHNBFDMLJ(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (926f * num * num + 364f * num2 + 1726f * num);
	}

	// Token: 0x0600D432 RID: 54322 RVA: 0x0060E2AC File Offset: 0x0060C4AC
	private static float INFEFLKCMHE(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (num2 * num);
	}

	// Token: 0x0600D433 RID: 54323 RVA: 0x0060E2C8 File Offset: 0x0060C4C8
	private static float IJKFOKHDBNN(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (4f * num2 + -3f * num);
	}

	// Token: 0x0600D434 RID: 54324 RVA: 0x0060E2F0 File Offset: 0x0060C4F0
	private static float IBNGOOFHKPN(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (num2 * num);
	}

	// Token: 0x0600D435 RID: 54325 RVA: 0x0060E30C File Offset: 0x0060C50C
	private static float IHBLCCMOHMK(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (num2 + 496f * num + 978f * JAHNHOCNJGM);
	}

	// Token: 0x0600D436 RID: 54326 RVA: 0x0060E338 File Offset: 0x0060C538
	private static float DLKOKGOHLDJ(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (-2f * num2 + 3f * num);
	}

	// Token: 0x0600D437 RID: 54327 RVA: 0x0060E360 File Offset: 0x0060C560
	private static float GMJAHMOPAPC(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * num;
	}

	// Token: 0x0600D438 RID: 54328 RVA: 0x0060E378 File Offset: 0x0060C578
	private static float NOMEPAFIACM(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		OAGAHEAMIAB -= HHAGIHEGFML;
		JAHNHOCNJGM /= 90f;
		float num = 157f;
		return OAGAHEAMIAB * JAHNHOCNJGM * JAHNHOCNJGM * ((num + 631f) * JAHNHOCNJGM - num) + HHAGIHEGFML;
	}

	// Token: 0x0600D439 RID: 54329 RVA: 0x0060E3AC File Offset: 0x0060C5AC
	private static float MKGDPNCIFMM(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * num;
	}

	// Token: 0x0600D43A RID: 54330 RVA: 0x0060E3C4 File Offset: 0x0060C5C4
	private static float GEFCDFMNNHC(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (653f * num2 + 1557f * num);
	}

	// Token: 0x0600D43B RID: 54331 RVA: 0x0060E3EC File Offset: 0x0060C5EC
	private static float NODJIJHFAEA(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (num2 * num + 1204f * num * num + 803f * num2 + 216f * num + 670f * JAHNHOCNJGM);
	}

	// Token: 0x0600D43C RID: 54332 RVA: 0x0060E42C File Offset: 0x0060C62C
	private static float MADOBFBALLL(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * num;
	}

	// Token: 0x0600D43D RID: 54333 RVA: 0x0060E444 File Offset: 0x0060C644
	private static float FCCMONMEGGM(float JAHNHOCNJGM, float HHAGIHEGFML, float OAGAHEAMIAB)
	{
		float num = JAHNHOCNJGM * JAHNHOCNJGM;
		float num2 = num * JAHNHOCNJGM;
		return HHAGIHEGFML + OAGAHEAMIAB * (874f * num2 + 922f * num + 1039f * JAHNHOCNJGM);
	}
}
