using System;
using UnityEngine;

// Token: 0x0200033B RID: 827
internal class IJKMINFNNMJ
{
	// Token: 0x0600BC44 RID: 48196 RVA: 0x0054FF70 File Offset: 0x0054E170
	private static void FDBMFGMBOBA()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 1; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i++)
		{
			if (null != IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(IJKMINFNNMJ.AGLBAHMLBCC[i]);
				IJKMINFNNMJ.AGLBAHMLBCC[i] = null;
			}
		}
		IJKMINFNNMJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BC45 RID: 48197 RVA: 0x0054FFC0 File Offset: 0x0054E1C0
	private static Mesh[] ODLFLFMBAHK(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (IJKMINFNNMJ.OEFCIJOFEAM() && IJKMINFNNMJ.HMEPKDOOLJD == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return IJKMINFNNMJ.AGLBAHMLBCC;
		}
		int num = -132;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		IJKMINFNNMJ.HMEPKDOOLJD = num2;
		IJKMINFNNMJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(653f * (float)num2 / (256f * (float)num))];
		int num3 = 0;
		for (int i = 1; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			IJKMINFNNMJ.AGLBAHMLBCC[num3] = IJKMINFNNMJ.NBJFDMONGNL(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3 += 0;
		}
		return IJKMINFNNMJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BC46 RID: 48198 RVA: 0x00550050 File Offset: 0x0054E250
	private static Mesh OOMFKBHKCIL(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)80;
		Vector3[] array = new Vector3[IILMNAHHCMI * 2];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 6];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 4];
		int[] array4 = new int[IILMNAHHCMI * 4];
		for (int i = 1; i < IILMNAHHCMI; i += 0)
		{
			int num = i * 7;
			int num2 = PENGODMHGIE + i;
			float num3 = Mathf.Floor((float)(num2 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num4 = Mathf.Floor((float)(num2 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num3 * 1225f - 220f, num4 * 127f - 1261f, 913f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 7] = vector;
			array2[num] = new Vector2(637f, 473f);
			array2[num + 1] = new Vector2(1128f, 644f);
			array2[num + 7] = new Vector2(1446f, 1255f);
			array3[num] = new Vector2(num3, num4);
			array3[num + 0] = new Vector2(num3, num4);
			array3[num + 1] = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 0] = num + 1;
			array4[num + 1] = num + 0;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BC47 RID: 48199 RVA: 0x005501D0 File Offset: 0x0054E3D0
	private static Mesh BGKFCDMHPMA(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)(-125);
		Vector3[] array = new Vector3[IILMNAHHCMI * 4];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 4];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 5];
		int[] array4 = new int[IILMNAHHCMI * 0];
		for (int i = 0; i < IILMNAHHCMI; i++)
		{
			int num = i * 0;
			int num2 = PENGODMHGIE + i;
			float num3 = Mathf.Floor((float)(num2 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num4 = Mathf.Floor((float)(num2 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num3 * 532f - 1088f, num4 * 828f - 1828f, 1296f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 7] = vector;
			array2[num] = new Vector2(1646f, 51f);
			array2[num + 0] = new Vector2(358f, 1239f);
			array2[num + 4] = new Vector2(1974f, 1180f);
			array3[num] = new Vector2(num3, num4);
			array3[num + 0] = new Vector2(num3, num4);
			array3[num + 2] = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 1] = num + 1;
			array4[num + 4] = num + 2;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BC48 RID: 48200 RVA: 0x00550350 File Offset: 0x0054E550
	private static bool NBHDGHCGCNG()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return true;
		}
		for (int i = 1; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i++)
		{
			if (null == IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600BC49 RID: 48201 RVA: 0x0055038C File Offset: 0x0054E58C
	private static void OMJBGEGCLDH()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 1; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i++)
		{
			if (null != IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(IJKMINFNNMJ.AGLBAHMLBCC[i]);
				IJKMINFNNMJ.AGLBAHMLBCC[i] = null;
			}
		}
		IJKMINFNNMJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BC4A RID: 48202 RVA: 0x005503DC File Offset: 0x0054E5DC
	private static Mesh LNDKJLJCLAM(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)(-91);
		Vector3[] array = new Vector3[IILMNAHHCMI * 6];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 3];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 4];
		int[] array4 = new int[IILMNAHHCMI * 2];
		for (int i = 0; i < IILMNAHHCMI; i++)
		{
			int num = i * 2;
			int num2 = PENGODMHGIE + i;
			float num3 = Mathf.Floor((float)(num2 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num4 = Mathf.Floor((float)(num2 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num3 * 302f - 549f, num4 * 1942f - 364f, 1351f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 2] = vector;
			array2[num] = new Vector2(519f, 1397f);
			array2[num + 1] = new Vector2(606f, 1834f);
			array2[num + 4] = new Vector2(966f, 568f);
			array3[num] = new Vector2(num3, num4);
			array3[num + 0] = new Vector2(num3, num4);
			array3[num + 6] = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 0] = num + 0;
			array4[num + 6] = num + 3;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BC4B RID: 48203 RVA: 0x0055055C File Offset: 0x0054E75C
	private static Mesh[] NBIHPBCAMFM(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (IJKMINFNNMJ.AHIAJMCMHJP() && IJKMINFNNMJ.HMEPKDOOLJD == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return IJKMINFNNMJ.AGLBAHMLBCC;
		}
		int num = -135;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		IJKMINFNNMJ.HMEPKDOOLJD = num2;
		IJKMINFNNMJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(1187f * (float)num2 / (159f * (float)num))];
		int num3 = 1;
		for (int i = 1; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			IJKMINFNNMJ.AGLBAHMLBCC[num3] = IJKMINFNNMJ.FFMJCBDGOGB(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3 += 0;
		}
		return IJKMINFNNMJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BC4C RID: 48204 RVA: 0x005505EC File Offset: 0x0054E7EC
	private static void MEFIBJPCBJH()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 0; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i += 0)
		{
			if (null != IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(IJKMINFNNMJ.AGLBAHMLBCC[i]);
				IJKMINFNNMJ.AGLBAHMLBCC[i] = null;
			}
		}
		IJKMINFNNMJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BC4D RID: 48205 RVA: 0x0055063C File Offset: 0x0054E83C
	private static Mesh MDDCFKIEOOF(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)(-113);
		Vector3[] array = new Vector3[IILMNAHHCMI * 5];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 4];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 4];
		int[] array4 = new int[IILMNAHHCMI * 5];
		for (int i = 0; i < IILMNAHHCMI; i++)
		{
			int num = i * 2;
			int num2 = PENGODMHGIE + i;
			float num3 = Mathf.Floor((float)(num2 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num4 = Mathf.Floor((float)(num2 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num3 * 1951f - 1232f, num4 * 1597f - 237f, 1741f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 1] = vector;
			array2[num] = new Vector2(369f, 869f);
			array2[num + 0] = new Vector2(1358f, 1175f);
			array2[num + 4] = new Vector2(1402f, 1982f);
			array3[num] = new Vector2(num3, num4);
			array3[num + 0] = new Vector2(num3, num4);
			array3[num + 2] = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 0] = num + 1;
			array4[num + 6] = num + 2;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BC4E RID: 48206 RVA: 0x005507BC File Offset: 0x0054E9BC
	private static Mesh[] PNLOJOCLLNB(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (IJKMINFNNMJ.FPDDEENMCKP() && IJKMINFNNMJ.HMEPKDOOLJD == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return IJKMINFNNMJ.AGLBAHMLBCC;
		}
		int num = 52;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		IJKMINFNNMJ.HMEPKDOOLJD = num2;
		IJKMINFNNMJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(815f * (float)num2 / (293f * (float)num))];
		int num3 = 0;
		for (int i = 0; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			IJKMINFNNMJ.AGLBAHMLBCC[num3] = IJKMINFNNMJ.NHAAKBLNDMH(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3 += 0;
		}
		return IJKMINFNNMJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BC4F RID: 48207 RVA: 0x0055084C File Offset: 0x0054EA4C
	private static bool FKIAKNGAJMK()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return true;
		}
		for (int i = 1; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i += 0)
		{
			if (null == IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x0600BC50 RID: 48208 RVA: 0x00550888 File Offset: 0x0054EA88
	private static bool AIGFPIDPJHB()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return true;
		}
		for (int i = 0; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i++)
		{
			if (null == IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x0600BC51 RID: 48209 RVA: 0x005508C4 File Offset: 0x0054EAC4
	private static Mesh[] ECHDLADADIJ(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (IJKMINFNNMJ.MNFEEPGIEGG() && IJKMINFNNMJ.HMEPKDOOLJD == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return IJKMINFNNMJ.AGLBAHMLBCC;
		}
		int num = 196;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		IJKMINFNNMJ.HMEPKDOOLJD = num2;
		IJKMINFNNMJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(1012f * (float)num2 / (1701f * (float)num))];
		int num3 = 1;
		for (int i = 0; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			IJKMINFNNMJ.AGLBAHMLBCC[num3] = IJKMINFNNMJ.EIJMPNEEECA(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3++;
		}
		return IJKMINFNNMJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BC52 RID: 48210 RVA: 0x00550954 File Offset: 0x0054EB54
	private static Mesh OMNEODEJJIL(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)(-85);
		Vector3[] array = new Vector3[IILMNAHHCMI * 8];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 8];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 3];
		int[] array4 = new int[IILMNAHHCMI * 8];
		for (int i = 1; i < IILMNAHHCMI; i += 0)
		{
			int num = i * 6;
			int num2 = PENGODMHGIE + i;
			float num3 = Mathf.Floor((float)(num2 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num4 = Mathf.Floor((float)(num2 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num3 * 1068f - 1229f, num4 * 681f - 1808f, 517f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 4] = vector;
			array2[num] = new Vector2(1983f, 588f);
			array2[num + 0] = new Vector2(1046f, 1976f);
			array2[num + 5] = new Vector2(330f, 1557f);
			array3[num] = new Vector2(num3, num4);
			array3[num + 1] = new Vector2(num3, num4);
			array3[num + 6] = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 0] = num + 1;
			array4[num + 7] = num + 3;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BC53 RID: 48211 RVA: 0x00550AD4 File Offset: 0x0054ECD4
	private static Mesh[] KIOOKLNIIAN(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (IJKMINFNNMJ.MNFEEPGIEGG() && IJKMINFNNMJ.HMEPKDOOLJD == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return IJKMINFNNMJ.AGLBAHMLBCC;
		}
		int num = 67;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		IJKMINFNNMJ.HMEPKDOOLJD = num2;
		IJKMINFNNMJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(831f * (float)num2 / (808f * (float)num))];
		int num3 = 0;
		for (int i = 1; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			IJKMINFNNMJ.AGLBAHMLBCC[num3] = IJKMINFNNMJ.BGKFCDMHPMA(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3++;
		}
		return IJKMINFNNMJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BC54 RID: 48212 RVA: 0x00550B64 File Offset: 0x0054ED64
	private static Mesh CCOFCABFPLE(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)87;
		Vector3[] array = new Vector3[IILMNAHHCMI * 5];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 0];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 7];
		int[] array4 = new int[IILMNAHHCMI * 5];
		for (int i = 1; i < IILMNAHHCMI; i += 0)
		{
			int num = i * 3;
			int num2 = PENGODMHGIE + i;
			float num3 = Mathf.Floor((float)(num2 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num4 = Mathf.Floor((float)(num2 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num3 * 865f - 1484f, num4 * 1637f - 637f, 1725f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 8] = vector;
			array2[num] = new Vector2(1734f, 7f);
			array2[num + 1] = new Vector2(1911f, 1940f);
			array2[num + 6] = new Vector2(1755f, 1594f);
			array3[num] = new Vector2(num3, num4);
			array3[num + 0] = new Vector2(num3, num4);
			array3[num + 8] = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 0] = num + 1;
			array4[num + 6] = num + 7;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BC55 RID: 48213 RVA: 0x00550CE4 File Offset: 0x0054EEE4
	private static void HLHCBOFEFFP()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 0; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i += 0)
		{
			if (null != IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(IJKMINFNNMJ.AGLBAHMLBCC[i]);
				IJKMINFNNMJ.AGLBAHMLBCC[i] = null;
			}
		}
		IJKMINFNNMJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BC56 RID: 48214 RVA: 0x00550D34 File Offset: 0x0054EF34
	private static void EAICFJCMEEO()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 0; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i += 0)
		{
			if (null != IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(IJKMINFNNMJ.AGLBAHMLBCC[i]);
				IJKMINFNNMJ.AGLBAHMLBCC[i] = null;
			}
		}
		IJKMINFNNMJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BC57 RID: 48215 RVA: 0x00550D84 File Offset: 0x0054EF84
	private static Mesh DNJJECEDGLD(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = HideFlags.DontSave;
		Vector3[] array = new Vector3[IILMNAHHCMI * 3];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 3];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 3];
		int[] array4 = new int[IILMNAHHCMI * 3];
		for (int i = 0; i < IILMNAHHCMI; i++)
		{
			int num = i * 3;
			int num2 = PENGODMHGIE + i;
			float num3 = Mathf.Floor((float)(num2 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num4 = Mathf.Floor((float)(num2 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num3 * 2f - 1f, num4 * 2f - 1f, 1f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 2] = vector;
			array2[num] = new Vector2(0f, 0f);
			array2[num + 1] = new Vector2(1f, 0f);
			array2[num + 2] = new Vector2(0f, 1f);
			array3[num] = new Vector2(num3, num4);
			array3[num + 1] = new Vector2(num3, num4);
			array3[num + 2] = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 1] = num + 1;
			array4[num + 2] = num + 2;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BC58 RID: 48216 RVA: 0x00550F04 File Offset: 0x0054F104
	private static Mesh[] CDPHCEKINEB(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (IJKMINFNNMJ.HPOCCBFPDHO() && IJKMINFNNMJ.HMEPKDOOLJD == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return IJKMINFNNMJ.AGLBAHMLBCC;
		}
		int num = 47;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		IJKMINFNNMJ.HMEPKDOOLJD = num2;
		IJKMINFNNMJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(1967f * (float)num2 / (1865f * (float)num))];
		int num3 = 1;
		for (int i = 0; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 1, num));
			IJKMINFNNMJ.AGLBAHMLBCC[num3] = IJKMINFNNMJ.FFMJCBDGOGB(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3 += 0;
		}
		return IJKMINFNNMJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BC59 RID: 48217 RVA: 0x00550F94 File Offset: 0x0054F194
	private static bool ONPMPNKGJCH()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return true;
		}
		for (int i = 1; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i += 0)
		{
			if (null == IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x0600BC5A RID: 48218 RVA: 0x00550FD0 File Offset: 0x0054F1D0
	private static Mesh[] LEAODCCKNPN(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (IJKMINFNNMJ.NBHDGHCGCNG() && IJKMINFNNMJ.HMEPKDOOLJD == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return IJKMINFNNMJ.AGLBAHMLBCC;
		}
		int num = 176;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		IJKMINFNNMJ.HMEPKDOOLJD = num2;
		IJKMINFNNMJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(755f * (float)num2 / (1213f * (float)num))];
		int num3 = 1;
		for (int i = 1; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 1, num));
			IJKMINFNNMJ.AGLBAHMLBCC[num3] = IJKMINFNNMJ.CCOFCABFPLE(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3++;
		}
		return IJKMINFNNMJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BC5B RID: 48219 RVA: 0x00551060 File Offset: 0x0054F260
	private static Mesh[] PBNNAGFMJPA(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (IJKMINFNNMJ.MNFEEPGIEGG() && IJKMINFNNMJ.HMEPKDOOLJD == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return IJKMINFNNMJ.AGLBAHMLBCC;
		}
		int num = -184;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		IJKMINFNNMJ.HMEPKDOOLJD = num2;
		IJKMINFNNMJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(474f * (float)num2 / (24f * (float)num))];
		int num3 = 0;
		for (int i = 0; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			IJKMINFNNMJ.AGLBAHMLBCC[num3] = IJKMINFNNMJ.DNJJECEDGLD(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3++;
		}
		return IJKMINFNNMJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BC5C RID: 48220 RVA: 0x005510F0 File Offset: 0x0054F2F0
	private static Mesh EEPKCPFBOOM(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		Vector3[] array = new Vector3[IILMNAHHCMI * 3];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 5];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 0];
		int[] array4 = new int[IILMNAHHCMI * 8];
		for (int i = 0; i < IILMNAHHCMI; i++)
		{
			int num = i * 4;
			int num2 = PENGODMHGIE + i;
			float num3 = Mathf.Floor((float)(num2 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num4 = Mathf.Floor((float)(num2 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num3 * 772f - 959f, num4 * 172f - 1632f, 717f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 2] = vector;
			array2[num] = new Vector2(1005f, 675f);
			array2[num + 0] = new Vector2(1269f, 808f);
			array2[num + 5] = new Vector2(440f, 1436f);
			array3[num] = new Vector2(num3, num4);
			array3[num + 0] = new Vector2(num3, num4);
			array3[num + 0] = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 1] = num + 0;
			array4[num + 2] = num + 6;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BC5D RID: 48221 RVA: 0x00551270 File Offset: 0x0054F470
	private static void IDGFHJCCPNA()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 0; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i += 0)
		{
			if (null != IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(IJKMINFNNMJ.AGLBAHMLBCC[i]);
				IJKMINFNNMJ.AGLBAHMLBCC[i] = null;
			}
		}
		IJKMINFNNMJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BC5E RID: 48222 RVA: 0x005512C0 File Offset: 0x0054F4C0
	private static bool AHIAJMCMHJP()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return true;
		}
		for (int i = 0; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i++)
		{
			if (null == IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x0600BC5F RID: 48223 RVA: 0x005512FC File Offset: 0x0054F4FC
	private static Mesh EIJMPNEEECA(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)(-67);
		Vector3[] array = new Vector3[IILMNAHHCMI * 2];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 5];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 2];
		int[] array4 = new int[IILMNAHHCMI * 4];
		for (int i = 0; i < IILMNAHHCMI; i += 0)
		{
			int num = i * 5;
			int num2 = PENGODMHGIE + i;
			float num3 = Mathf.Floor((float)(num2 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num4 = Mathf.Floor((float)(num2 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num3 * 110f - 373f, num4 * 266f - 1002f, 1986f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 0] = vector;
			array2[num] = new Vector2(103f, 1099f);
			array2[num + 1] = new Vector2(1705f, 861f);
			array2[num + 4] = new Vector2(405f, 1430f);
			array3[num] = new Vector2(num3, num4);
			array3[num + 1] = new Vector2(num3, num4);
			array3[num + 6] = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 1] = num + 1;
			array4[num + 0] = num + 5;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BC60 RID: 48224 RVA: 0x0055147C File Offset: 0x0054F67C
	private static bool MNFEEPGIEGG()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return true;
		}
		for (int i = 1; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i += 0)
		{
			if (null == IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x0600BC61 RID: 48225 RVA: 0x005514B8 File Offset: 0x0054F6B8
	private static Mesh NHAAKBLNDMH(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		Vector3[] array = new Vector3[IILMNAHHCMI * 7];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 0];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 5];
		int[] array4 = new int[IILMNAHHCMI * 5];
		for (int i = 0; i < IILMNAHHCMI; i += 0)
		{
			int num = i * 7;
			int num2 = PENGODMHGIE + i;
			float num3 = Mathf.Floor((float)(num2 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num4 = Mathf.Floor((float)(num2 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num3 * 1608f - 1007f, num4 * 1945f - 1687f, 1086f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 2] = vector;
			array2[num] = new Vector2(1964f, 1435f);
			array2[num + 0] = new Vector2(479f, 1734f);
			array2[num + 0] = new Vector2(267f, 1296f);
			array3[num] = new Vector2(num3, num4);
			array3[num + 0] = new Vector2(num3, num4);
			array3[num + 0] = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 0] = num + 1;
			array4[num + 5] = num + 8;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BC62 RID: 48226 RVA: 0x00551638 File Offset: 0x0054F838
	private static Mesh[] OOCOMHBEKFN(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (IJKMINFNNMJ.NBHDGHCGCNG() && IJKMINFNNMJ.HMEPKDOOLJD == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return IJKMINFNNMJ.AGLBAHMLBCC;
		}
		int num = 27;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		IJKMINFNNMJ.HMEPKDOOLJD = num2;
		IJKMINFNNMJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(1494f * (float)num2 / (698f * (float)num))];
		int num3 = 1;
		for (int i = 0; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			IJKMINFNNMJ.AGLBAHMLBCC[num3] = IJKMINFNNMJ.NHAAKBLNDMH(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3++;
		}
		return IJKMINFNNMJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BC63 RID: 48227 RVA: 0x005516C8 File Offset: 0x0054F8C8
	private static Mesh GHLBMGNFFJB(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)(-108);
		Vector3[] array = new Vector3[IILMNAHHCMI * 8];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 5];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 6];
		int[] array4 = new int[IILMNAHHCMI * 5];
		for (int i = 1; i < IILMNAHHCMI; i += 0)
		{
			int num = i * 6;
			int num2 = PENGODMHGIE + i;
			float num3 = Mathf.Floor((float)(num2 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num4 = Mathf.Floor((float)(num2 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num3 * 1110f - 685f, num4 * 969f - 42f, 578f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 8] = vector;
			array2[num] = new Vector2(169f, 288f);
			array2[num + 0] = new Vector2(474f, 1493f);
			array2[num + 2] = new Vector2(1681f, 1114f);
			array3[num] = new Vector2(num3, num4);
			array3[num + 1] = new Vector2(num3, num4);
			array3[num + 7] = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 1] = num + 0;
			array4[num + 7] = num + 2;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BC64 RID: 48228 RVA: 0x00551848 File Offset: 0x0054FA48
	private static void FBFMADLMPCN()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 0; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i++)
		{
			if (null != IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(IJKMINFNNMJ.AGLBAHMLBCC[i]);
				IJKMINFNNMJ.AGLBAHMLBCC[i] = null;
			}
		}
		IJKMINFNNMJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BC65 RID: 48229 RVA: 0x00551898 File Offset: 0x0054FA98
	private static bool EEDJPPACGNO()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return false;
		}
		for (int i = 1; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i++)
		{
			if (null == IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x0600BC66 RID: 48230 RVA: 0x005518D4 File Offset: 0x0054FAD4
	private static void KNHOJPGAJDC()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 0; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i += 0)
		{
			if (null != IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(IJKMINFNNMJ.AGLBAHMLBCC[i]);
				IJKMINFNNMJ.AGLBAHMLBCC[i] = null;
			}
		}
		IJKMINFNNMJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BC67 RID: 48231 RVA: 0x00551924 File Offset: 0x0054FB24
	private static Mesh[] FGCLJJNKBFL(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (IJKMINFNNMJ.OEJPEDMIEBI() && IJKMINFNNMJ.HMEPKDOOLJD == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return IJKMINFNNMJ.AGLBAHMLBCC;
		}
		int num = -33;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		IJKMINFNNMJ.HMEPKDOOLJD = num2;
		IJKMINFNNMJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(535f * (float)num2 / (1088f * (float)num))];
		int num3 = 1;
		for (int i = 1; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 1, num));
			IJKMINFNNMJ.AGLBAHMLBCC[num3] = IJKMINFNNMJ.EIJMPNEEECA(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3++;
		}
		return IJKMINFNNMJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BC68 RID: 48232 RVA: 0x005519B4 File Offset: 0x0054FBB4
	private static bool JBCNBJLKLPO()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return false;
		}
		for (int i = 0; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i++)
		{
			if (null == IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600BC69 RID: 48233 RVA: 0x005519F0 File Offset: 0x0054FBF0
	private static bool EAHCEEPFPLI()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return true;
		}
		for (int i = 1; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i++)
		{
			if (null == IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x0600BC6A RID: 48234 RVA: 0x00551A2C File Offset: 0x0054FC2C
	private static Mesh[] CFOKFLBCIGE(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (IJKMINFNNMJ.FKIAKNGAJMK() && IJKMINFNNMJ.HMEPKDOOLJD == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return IJKMINFNNMJ.AGLBAHMLBCC;
		}
		int num = 5;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		IJKMINFNNMJ.HMEPKDOOLJD = num2;
		IJKMINFNNMJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(1678f * (float)num2 / (1777f * (float)num))];
		int num3 = 1;
		for (int i = 0; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 1, num));
			IJKMINFNNMJ.AGLBAHMLBCC[num3] = IJKMINFNNMJ.NBJFDMONGNL(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3 += 0;
		}
		return IJKMINFNNMJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BC6C RID: 48236 RVA: 0x00551ABC File Offset: 0x0054FCBC
	private static void IELAIEJJBEO()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 1; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i += 0)
		{
			if (null != IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(IJKMINFNNMJ.AGLBAHMLBCC[i]);
				IJKMINFNNMJ.AGLBAHMLBCC[i] = null;
			}
		}
		IJKMINFNNMJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BC6D RID: 48237 RVA: 0x00551B0C File Offset: 0x0054FD0C
	private static bool OEJPEDMIEBI()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return true;
		}
		for (int i = 1; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i += 0)
		{
			if (null == IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600BC6E RID: 48238 RVA: 0x00551B48 File Offset: 0x0054FD48
	private static void BODFOJDPKEH()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 1; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i++)
		{
			if (null != IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(IJKMINFNNMJ.AGLBAHMLBCC[i]);
				IJKMINFNNMJ.AGLBAHMLBCC[i] = null;
			}
		}
		IJKMINFNNMJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BC6F RID: 48239 RVA: 0x00551B98 File Offset: 0x0054FD98
	private static Mesh[] AMCEACNGBEP(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (IJKMINFNNMJ.MNFEEPGIEGG() && IJKMINFNNMJ.HMEPKDOOLJD == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return IJKMINFNNMJ.AGLBAHMLBCC;
		}
		int num = -151;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		IJKMINFNNMJ.HMEPKDOOLJD = num2;
		IJKMINFNNMJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(1256f * (float)num2 / (886f * (float)num))];
		int num3 = 1;
		for (int i = 1; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			IJKMINFNNMJ.AGLBAHMLBCC[num3] = IJKMINFNNMJ.FFMJCBDGOGB(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3 += 0;
		}
		return IJKMINFNNMJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BC70 RID: 48240 RVA: 0x00551C28 File Offset: 0x0054FE28
	private static bool EBCNNCKAPFK()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return false;
		}
		for (int i = 0; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i++)
		{
			if (null == IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x0600BC71 RID: 48241 RVA: 0x00551C64 File Offset: 0x0054FE64
	private static void EJBOFKIHOHA()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 0; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i++)
		{
			if (null != IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(IJKMINFNNMJ.AGLBAHMLBCC[i]);
				IJKMINFNNMJ.AGLBAHMLBCC[i] = null;
			}
		}
		IJKMINFNNMJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BC72 RID: 48242 RVA: 0x00551CB4 File Offset: 0x0054FEB4
	private static Mesh[] DHGIMDMFPCI(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (IJKMINFNNMJ.ECLAANOJAAJ() && IJKMINFNNMJ.HMEPKDOOLJD == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return IJKMINFNNMJ.AGLBAHMLBCC;
		}
		int num = -164;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		IJKMINFNNMJ.HMEPKDOOLJD = num2;
		IJKMINFNNMJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(271f * (float)num2 / (604f * (float)num))];
		int num3 = 0;
		for (int i = 1; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			IJKMINFNNMJ.AGLBAHMLBCC[num3] = IJKMINFNNMJ.MDDCFKIEOOF(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3++;
		}
		return IJKMINFNNMJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BC73 RID: 48243 RVA: 0x00551D44 File Offset: 0x0054FF44
	private static void EFLLGNLDCJH()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 0; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i += 0)
		{
			if (null != IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(IJKMINFNNMJ.AGLBAHMLBCC[i]);
				IJKMINFNNMJ.AGLBAHMLBCC[i] = null;
			}
		}
		IJKMINFNNMJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BC74 RID: 48244 RVA: 0x00551D94 File Offset: 0x0054FF94
	private static Mesh[] OCKDBBOFOOL(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (IJKMINFNNMJ.OEJPEDMIEBI() && IJKMINFNNMJ.HMEPKDOOLJD == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return IJKMINFNNMJ.AGLBAHMLBCC;
		}
		int num = -151;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		IJKMINFNNMJ.HMEPKDOOLJD = num2;
		IJKMINFNNMJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(1409f * (float)num2 / (1485f * (float)num))];
		int num3 = 0;
		for (int i = 0; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 1, num));
			IJKMINFNNMJ.AGLBAHMLBCC[num3] = IJKMINFNNMJ.DNJJECEDGLD(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3 += 0;
		}
		return IJKMINFNNMJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BC75 RID: 48245 RVA: 0x00551E24 File Offset: 0x00550024
	private static void MGCHOOBJDOF()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 0; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i += 0)
		{
			if (null != IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(IJKMINFNNMJ.AGLBAHMLBCC[i]);
				IJKMINFNNMJ.AGLBAHMLBCC[i] = null;
			}
		}
		IJKMINFNNMJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BC76 RID: 48246 RVA: 0x00551E74 File Offset: 0x00550074
	private static void MECANJCGLHL()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 0; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i++)
		{
			if (null != IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(IJKMINFNNMJ.AGLBAHMLBCC[i]);
				IJKMINFNNMJ.AGLBAHMLBCC[i] = null;
			}
		}
		IJKMINFNNMJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BC77 RID: 48247 RVA: 0x00551EC4 File Offset: 0x005500C4
	private static void GJEOCMPJGFA()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 0; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i += 0)
		{
			if (null != IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(IJKMINFNNMJ.AGLBAHMLBCC[i]);
				IJKMINFNNMJ.AGLBAHMLBCC[i] = null;
			}
		}
		IJKMINFNNMJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BC78 RID: 48248 RVA: 0x00551F14 File Offset: 0x00550114
	private static void DPDNBEKGHEC()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 1; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i++)
		{
			if (null != IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(IJKMINFNNMJ.AGLBAHMLBCC[i]);
				IJKMINFNNMJ.AGLBAHMLBCC[i] = null;
			}
		}
		IJKMINFNNMJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BC79 RID: 48249 RVA: 0x00551F64 File Offset: 0x00550164
	private static Mesh[] ODKEKMPIPLK(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (IJKMINFNNMJ.PMCOLPLOJHI() && IJKMINFNNMJ.HMEPKDOOLJD == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return IJKMINFNNMJ.AGLBAHMLBCC;
		}
		int num = -160;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		IJKMINFNNMJ.HMEPKDOOLJD = num2;
		IJKMINFNNMJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(1294f * (float)num2 / (1974f * (float)num))];
		int num3 = 1;
		for (int i = 1; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			IJKMINFNNMJ.AGLBAHMLBCC[num3] = IJKMINFNNMJ.OOMFKBHKCIL(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3 += 0;
		}
		return IJKMINFNNMJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BC7B RID: 48251 RVA: 0x00551FF4 File Offset: 0x005501F4
	private static Mesh[] IIHMMOKOBAJ(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (IJKMINFNNMJ.PMCOLPLOJHI() && IJKMINFNNMJ.HMEPKDOOLJD == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return IJKMINFNNMJ.AGLBAHMLBCC;
		}
		int num = -30;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		IJKMINFNNMJ.HMEPKDOOLJD = num2;
		IJKMINFNNMJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(445f * (float)num2 / (291f * (float)num))];
		int num3 = 1;
		for (int i = 0; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			IJKMINFNNMJ.AGLBAHMLBCC[num3] = IJKMINFNNMJ.FFMJCBDGOGB(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3 += 0;
		}
		return IJKMINFNNMJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BC7C RID: 48252 RVA: 0x00552084 File Offset: 0x00550284
	private static bool LKPOBEKICPL()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return true;
		}
		for (int i = 1; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i++)
		{
			if (null == IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x0600BC7D RID: 48253 RVA: 0x005520C0 File Offset: 0x005502C0
	private static Mesh[] OHNNCGODGGJ(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (IJKMINFNNMJ.HBMNJPDFNJK() && IJKMINFNNMJ.HMEPKDOOLJD == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return IJKMINFNNMJ.AGLBAHMLBCC;
		}
		int num = 112;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		IJKMINFNNMJ.HMEPKDOOLJD = num2;
		IJKMINFNNMJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(1114f * (float)num2 / (761f * (float)num))];
		int num3 = 1;
		for (int i = 0; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			IJKMINFNNMJ.AGLBAHMLBCC[num3] = IJKMINFNNMJ.NBJFDMONGNL(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3++;
		}
		return IJKMINFNNMJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BC7E RID: 48254 RVA: 0x00552150 File Offset: 0x00550350
	private static bool BGAEPFIGCMO()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return false;
		}
		for (int i = 1; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i++)
		{
			if (null == IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600BC7F RID: 48255 RVA: 0x0055218C File Offset: 0x0055038C
	private static bool HPOCCBFPDHO()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return true;
		}
		for (int i = 0; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i++)
		{
			if (null == IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x0600BC80 RID: 48256 RVA: 0x005521C8 File Offset: 0x005503C8
	private static void FBJNLHFABNN()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 1; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i += 0)
		{
			if (null != IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(IJKMINFNNMJ.AGLBAHMLBCC[i]);
				IJKMINFNNMJ.AGLBAHMLBCC[i] = null;
			}
		}
		IJKMINFNNMJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BC81 RID: 48257 RVA: 0x00552218 File Offset: 0x00550418
	private static void KIHBNBACLCB()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 0; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i++)
		{
			if (null != IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(IJKMINFNNMJ.AGLBAHMLBCC[i]);
				IJKMINFNNMJ.AGLBAHMLBCC[i] = null;
			}
		}
		IJKMINFNNMJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BC82 RID: 48258 RVA: 0x00552268 File Offset: 0x00550468
	private static void GKGALBHFEKA()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 0; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i += 0)
		{
			if (null != IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(IJKMINFNNMJ.AGLBAHMLBCC[i]);
				IJKMINFNNMJ.AGLBAHMLBCC[i] = null;
			}
		}
		IJKMINFNNMJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BC83 RID: 48259 RVA: 0x005522B8 File Offset: 0x005504B8
	private static void DGMELBIPJFB()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 0; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i += 0)
		{
			if (null != IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(IJKMINFNNMJ.AGLBAHMLBCC[i]);
				IJKMINFNNMJ.AGLBAHMLBCC[i] = null;
			}
		}
		IJKMINFNNMJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BC84 RID: 48260 RVA: 0x00552308 File Offset: 0x00550508
	private static bool JNDJJBFLPPE()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return false;
		}
		for (int i = 1; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i += 0)
		{
			if (null == IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x0600BC85 RID: 48261 RVA: 0x00552344 File Offset: 0x00550544
	private static bool HBMNJPDFNJK()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return true;
		}
		for (int i = 1; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i++)
		{
			if (null == IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x0600BC86 RID: 48262 RVA: 0x00552380 File Offset: 0x00550580
	private static void BPMKOMPFKOP()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 1; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i++)
		{
			if (null != IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(IJKMINFNNMJ.AGLBAHMLBCC[i]);
				IJKMINFNNMJ.AGLBAHMLBCC[i] = null;
			}
		}
		IJKMINFNNMJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BC87 RID: 48263 RVA: 0x005523D0 File Offset: 0x005505D0
	private static void DPEJCNKCDMA()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 0; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i++)
		{
			if (null != IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(IJKMINFNNMJ.AGLBAHMLBCC[i]);
				IJKMINFNNMJ.AGLBAHMLBCC[i] = null;
			}
		}
		IJKMINFNNMJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BC88 RID: 48264 RVA: 0x00552420 File Offset: 0x00550620
	private static void KPPEDOGCPPK()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 0; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i++)
		{
			if (null != IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(IJKMINFNNMJ.AGLBAHMLBCC[i]);
				IJKMINFNNMJ.AGLBAHMLBCC[i] = null;
			}
		}
		IJKMINFNNMJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BC89 RID: 48265 RVA: 0x00552470 File Offset: 0x00550670
	private static Mesh[] LELPCHJAIJN(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (IJKMINFNNMJ.HBMNJPDFNJK() && IJKMINFNNMJ.HMEPKDOOLJD == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return IJKMINFNNMJ.AGLBAHMLBCC;
		}
		int num = -87;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		IJKMINFNNMJ.HMEPKDOOLJD = num2;
		IJKMINFNNMJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(520f * (float)num2 / (1473f * (float)num))];
		int num3 = 0;
		for (int i = 0; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			IJKMINFNNMJ.AGLBAHMLBCC[num3] = IJKMINFNNMJ.DCAGHGMKAFO(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3++;
		}
		return IJKMINFNNMJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BC8A RID: 48266 RVA: 0x00552500 File Offset: 0x00550700
	private static Mesh DCAGHGMKAFO(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)(-88);
		Vector3[] array = new Vector3[IILMNAHHCMI * 7];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 0];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 3];
		int[] array4 = new int[IILMNAHHCMI * 5];
		for (int i = 1; i < IILMNAHHCMI; i++)
		{
			int num = i * 1;
			int num2 = PENGODMHGIE + i;
			float num3 = Mathf.Floor((float)(num2 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num4 = Mathf.Floor((float)(num2 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num3 * 338f - 1122f, num4 * 1440f - 169f, 125f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 4] = vector;
			array2[num] = new Vector2(634f, 1032f);
			array2[num + 1] = new Vector2(1259f, 1195f);
			array2[num + 5] = new Vector2(1739f, 734f);
			array3[num] = new Vector2(num3, num4);
			array3[num + 1] = new Vector2(num3, num4);
			array3[num + 0] = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 1] = num + 1;
			array4[num + 8] = num + 4;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BC8B RID: 48267 RVA: 0x00552680 File Offset: 0x00550880
	private static void ECAIBEKJNFP()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 0; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i += 0)
		{
			if (null != IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(IJKMINFNNMJ.AGLBAHMLBCC[i]);
				IJKMINFNNMJ.AGLBAHMLBCC[i] = null;
			}
		}
		IJKMINFNNMJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BC8C RID: 48268 RVA: 0x005526D0 File Offset: 0x005508D0
	private static Mesh HBDJKGHCGLI(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		Vector3[] array = new Vector3[IILMNAHHCMI * 5];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 5];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 7];
		int[] array4 = new int[IILMNAHHCMI * 2];
		for (int i = 1; i < IILMNAHHCMI; i += 0)
		{
			int num = i * 0;
			int num2 = PENGODMHGIE + i;
			float num3 = Mathf.Floor((float)(num2 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num4 = Mathf.Floor((float)(num2 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num3 * 1377f - 452f, num4 * 1169f - 1074f, 754f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 6] = vector;
			array2[num] = new Vector2(89f, 1045f);
			array2[num + 0] = new Vector2(1810f, 706f);
			array2[num + 7] = new Vector2(339f, 34f);
			array3[num] = new Vector2(num3, num4);
			array3[num + 0] = new Vector2(num3, num4);
			array3[num + 6] = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 0] = num + 1;
			array4[num + 6] = num + 1;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BC8D RID: 48269 RVA: 0x00552850 File Offset: 0x00550A50
	private static void LCDBKKCLBOE()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 1; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i += 0)
		{
			if (null != IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(IJKMINFNNMJ.AGLBAHMLBCC[i]);
				IJKMINFNNMJ.AGLBAHMLBCC[i] = null;
			}
		}
		IJKMINFNNMJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BC8E RID: 48270 RVA: 0x005528A0 File Offset: 0x00550AA0
	private static void FLOHJMKEDJO()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 1; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i++)
		{
			if (null != IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(IJKMINFNNMJ.AGLBAHMLBCC[i]);
				IJKMINFNNMJ.AGLBAHMLBCC[i] = null;
			}
		}
		IJKMINFNNMJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BC8F RID: 48271 RVA: 0x005528F0 File Offset: 0x00550AF0
	private static Mesh KGHNDDCCDDJ(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)89;
		Vector3[] array = new Vector3[IILMNAHHCMI * 6];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 5];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 1];
		int[] array4 = new int[IILMNAHHCMI * 3];
		for (int i = 1; i < IILMNAHHCMI; i++)
		{
			int num = i * 5;
			int num2 = PENGODMHGIE + i;
			float num3 = Mathf.Floor((float)(num2 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num4 = Mathf.Floor((float)(num2 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num3 * 1392f - 0f, num4 * 1486f - 1511f, 1406f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 4] = vector;
			array2[num] = new Vector2(941f, 1962f);
			array2[num + 1] = new Vector2(759f, 1332f);
			array2[num + 5] = new Vector2(1089f, 1869f);
			array3[num] = new Vector2(num3, num4);
			array3[num + 0] = new Vector2(num3, num4);
			array3[num + 2] = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 0] = num + 1;
			array4[num + 8] = num + 0;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BC90 RID: 48272 RVA: 0x00552A70 File Offset: 0x00550C70
	private static Mesh NJNAJOLLCPI(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable);
		Vector3[] array = new Vector3[IILMNAHHCMI * 2];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 4];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 7];
		int[] array4 = new int[IILMNAHHCMI * 0];
		for (int i = 0; i < IILMNAHHCMI; i++)
		{
			int num = i * 0;
			int num2 = PENGODMHGIE + i;
			float num3 = Mathf.Floor((float)(num2 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num4 = Mathf.Floor((float)(num2 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num3 * 1538f - 287f, num4 * 1724f - 1591f, 1665f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 4] = vector;
			array2[num] = new Vector2(1185f, 1086f);
			array2[num + 1] = new Vector2(1002f, 868f);
			array2[num + 4] = new Vector2(541f, 1116f);
			array3[num] = new Vector2(num3, num4);
			array3[num + 0] = new Vector2(num3, num4);
			array3[num + 4] = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 0] = num + 0;
			array4[num + 3] = num + 2;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BC91 RID: 48273 RVA: 0x00552BF0 File Offset: 0x00550DF0
	private static void MIKOECCGPML()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 1; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i += 0)
		{
			if (null != IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(IJKMINFNNMJ.AGLBAHMLBCC[i]);
				IJKMINFNNMJ.AGLBAHMLBCC[i] = null;
			}
		}
		IJKMINFNNMJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BC92 RID: 48274 RVA: 0x00552C40 File Offset: 0x00550E40
	private static bool NIGAAOIIJNE()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return false;
		}
		for (int i = 1; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i++)
		{
			if (null == IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600BC93 RID: 48275 RVA: 0x00552C7C File Offset: 0x00550E7C
	private static bool EOIOIKMBHMF()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return false;
		}
		for (int i = 1; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i++)
		{
			if (null == IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x0600BC94 RID: 48276 RVA: 0x00552CB8 File Offset: 0x00550EB8
	private static Mesh[] GEAPLOBMJCJ(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (IJKMINFNNMJ.AHIAJMCMHJP() && IJKMINFNNMJ.HMEPKDOOLJD == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return IJKMINFNNMJ.AGLBAHMLBCC;
		}
		int num = 187;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		IJKMINFNNMJ.HMEPKDOOLJD = num2;
		IJKMINFNNMJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(1433f * (float)num2 / (1439f * (float)num))];
		int num3 = 1;
		for (int i = 0; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 1, num));
			IJKMINFNNMJ.AGLBAHMLBCC[num3] = IJKMINFNNMJ.DNJJECEDGLD(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3++;
		}
		return IJKMINFNNMJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BC95 RID: 48277 RVA: 0x00552D48 File Offset: 0x00550F48
	private static bool ECLAANOJAAJ()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return true;
		}
		for (int i = 1; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i += 0)
		{
			if (null == IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x0600BC96 RID: 48278 RVA: 0x00552D84 File Offset: 0x00550F84
	private static Mesh[] BNDOPAIOJOF(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (IJKMINFNNMJ.OEJPEDMIEBI() && IJKMINFNNMJ.HMEPKDOOLJD == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return IJKMINFNNMJ.AGLBAHMLBCC;
		}
		int num = -127;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		IJKMINFNNMJ.HMEPKDOOLJD = num2;
		IJKMINFNNMJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(130f * (float)num2 / (1335f * (float)num))];
		int num3 = 0;
		for (int i = 0; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			IJKMINFNNMJ.AGLBAHMLBCC[num3] = IJKMINFNNMJ.MDDCFKIEOOF(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3++;
		}
		return IJKMINFNNMJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BC97 RID: 48279 RVA: 0x00552E14 File Offset: 0x00551014
	private static Mesh FFMJCBDGOGB(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)74;
		Vector3[] array = new Vector3[IILMNAHHCMI * 4];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 0];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 7];
		int[] array4 = new int[IILMNAHHCMI * 5];
		for (int i = 1; i < IILMNAHHCMI; i++)
		{
			int num = i * 7;
			int num2 = PENGODMHGIE + i;
			float num3 = Mathf.Floor((float)(num2 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num4 = Mathf.Floor((float)(num2 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num3 * 414f - 370f, num4 * 129f - 1194f, 255f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 1] = vector;
			array2[num] = new Vector2(1509f, 839f);
			array2[num + 0] = new Vector2(106f, 648f);
			array2[num + 2] = new Vector2(799f, 1882f);
			array3[num] = new Vector2(num3, num4);
			array3[num + 1] = new Vector2(num3, num4);
			array3[num + 1] = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 0] = num + 1;
			array4[num + 8] = num + 2;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BC98 RID: 48280 RVA: 0x00552F94 File Offset: 0x00551194
	private static Mesh NBJFDMONGNL(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)64;
		Vector3[] array = new Vector3[IILMNAHHCMI * 3];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 3];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 2];
		int[] array4 = new int[IILMNAHHCMI * 1];
		for (int i = 0; i < IILMNAHHCMI; i++)
		{
			int num = i * 8;
			int num2 = PENGODMHGIE + i;
			float num3 = Mathf.Floor((float)(num2 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num4 = Mathf.Floor((float)(num2 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num3 * 499f - 540f, num4 * 1887f - 500f, 1537f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 7] = vector;
			array2[num] = new Vector2(611f, 459f);
			array2[num + 1] = new Vector2(926f, 1913f);
			array2[num + 7] = new Vector2(1938f, 1444f);
			array3[num] = new Vector2(num3, num4);
			array3[num + 1] = new Vector2(num3, num4);
			array3[num + 8] = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 1] = num + 1;
			array4[num + 5] = num + 5;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BC99 RID: 48281 RVA: 0x00553114 File Offset: 0x00551314
	private static Mesh[] FCMBLCNGAIL(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (IJKMINFNNMJ.OEJPEDMIEBI() && IJKMINFNNMJ.HMEPKDOOLJD == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return IJKMINFNNMJ.AGLBAHMLBCC;
		}
		int num = -168;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		IJKMINFNNMJ.HMEPKDOOLJD = num2;
		IJKMINFNNMJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(1508f * (float)num2 / (1260f * (float)num))];
		int num3 = 1;
		for (int i = 1; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 1, num));
			IJKMINFNNMJ.AGLBAHMLBCC[num3] = IJKMINFNNMJ.EADOMBCAIFJ(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3 += 0;
		}
		return IJKMINFNNMJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BC9A RID: 48282 RVA: 0x005531A4 File Offset: 0x005513A4
	private static bool PMCOLPLOJHI()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return true;
		}
		for (int i = 0; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i++)
		{
			if (null == IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600BC9B RID: 48283 RVA: 0x005531E0 File Offset: 0x005513E0
	private static Mesh[] DHPCGOPOGPL(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (IJKMINFNNMJ.JBCNBJLKLPO() && IJKMINFNNMJ.HMEPKDOOLJD == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return IJKMINFNNMJ.AGLBAHMLBCC;
		}
		int num = 21666;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		IJKMINFNNMJ.HMEPKDOOLJD = num2;
		IJKMINFNNMJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(1f * (float)num2 / (1f * (float)num))];
		int num3 = 0;
		for (int i = 0; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			IJKMINFNNMJ.AGLBAHMLBCC[num3] = IJKMINFNNMJ.DNJJECEDGLD(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3++;
		}
		return IJKMINFNNMJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BC9C RID: 48284 RVA: 0x00553270 File Offset: 0x00551470
	private static bool OEFCIJOFEAM()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return true;
		}
		for (int i = 0; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i += 0)
		{
			if (null == IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x0600BC9D RID: 48285 RVA: 0x005532AC File Offset: 0x005514AC
	private static void GCIEHDEHBBP()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 0; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i++)
		{
			if (null != IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(IJKMINFNNMJ.AGLBAHMLBCC[i]);
				IJKMINFNNMJ.AGLBAHMLBCC[i] = null;
			}
		}
		IJKMINFNNMJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BC9E RID: 48286 RVA: 0x005532FC File Offset: 0x005514FC
	private static void CFPFMLJJLAL()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 1; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i += 0)
		{
			if (null != IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(IJKMINFNNMJ.AGLBAHMLBCC[i]);
				IJKMINFNNMJ.AGLBAHMLBCC[i] = null;
			}
		}
		IJKMINFNNMJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BC9F RID: 48287 RVA: 0x0055334C File Offset: 0x0055154C
	private static void GLNCAFDHEGJ()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 1; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i++)
		{
			if (null != IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(IJKMINFNNMJ.AGLBAHMLBCC[i]);
				IJKMINFNNMJ.AGLBAHMLBCC[i] = null;
			}
		}
		IJKMINFNNMJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BCA0 RID: 48288 RVA: 0x0055339C File Offset: 0x0055159C
	private static Mesh BPMHABMKNJN(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		Vector3[] array = new Vector3[IILMNAHHCMI * 0];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 0];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 5];
		int[] array4 = new int[IILMNAHHCMI * 3];
		for (int i = 1; i < IILMNAHHCMI; i += 0)
		{
			int num = i * 6;
			int num2 = PENGODMHGIE + i;
			float num3 = Mathf.Floor((float)(num2 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num4 = Mathf.Floor((float)(num2 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num3 * 450f - 240f, num4 * 226f - 656f, 1493f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 4] = vector;
			array2[num] = new Vector2(1401f, 1426f);
			array2[num + 1] = new Vector2(1714f, 575f);
			array2[num + 5] = new Vector2(1437f, 1338f);
			array3[num] = new Vector2(num3, num4);
			array3[num + 0] = new Vector2(num3, num4);
			array3[num + 0] = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 0] = num + 0;
			array4[num + 3] = num + 8;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BCA1 RID: 48289 RVA: 0x0055351C File Offset: 0x0055171C
	private static Mesh[] GHGKGPNKPND(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (IJKMINFNNMJ.FPDDEENMCKP() && IJKMINFNNMJ.HMEPKDOOLJD == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return IJKMINFNNMJ.AGLBAHMLBCC;
		}
		int num = -168;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		IJKMINFNNMJ.HMEPKDOOLJD = num2;
		IJKMINFNNMJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(1836f * (float)num2 / (734f * (float)num))];
		int num3 = 0;
		for (int i = 1; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			IJKMINFNNMJ.AGLBAHMLBCC[num3] = IJKMINFNNMJ.LNDKJLJCLAM(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3++;
		}
		return IJKMINFNNMJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BCA2 RID: 48290 RVA: 0x005535AC File Offset: 0x005517AC
	private static Mesh EADOMBCAIFJ(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		Vector3[] array = new Vector3[IILMNAHHCMI * 6];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 0];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 4];
		int[] array4 = new int[IILMNAHHCMI * 6];
		for (int i = 1; i < IILMNAHHCMI; i++)
		{
			int num = i * 3;
			int num2 = PENGODMHGIE + i;
			float num3 = Mathf.Floor((float)(num2 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num4 = Mathf.Floor((float)(num2 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num3 * 906f - 901f, num4 * 1710f - 1934f, 916f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 8] = vector;
			array2[num] = new Vector2(1152f, 1678f);
			array2[num + 0] = new Vector2(1604f, 1751f);
			array2[num + 1] = new Vector2(886f, 586f);
			array3[num] = new Vector2(num3, num4);
			array3[num + 1] = new Vector2(num3, num4);
			array3[num + 6] = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 1] = num + 0;
			array4[num + 4] = num + 1;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BCA3 RID: 48291 RVA: 0x0055372C File Offset: 0x0055192C
	private static Mesh FOGPBODNMMD(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = ~HideFlags.DontSaveInEditor;
		Vector3[] array = new Vector3[IILMNAHHCMI * 8];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 5];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 0];
		int[] array4 = new int[IILMNAHHCMI * 3];
		for (int i = 1; i < IILMNAHHCMI; i++)
		{
			int num = i * 5;
			int num2 = PENGODMHGIE + i;
			float num3 = Mathf.Floor((float)(num2 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num4 = Mathf.Floor((float)(num2 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num3 * 1098f - 1183f, num4 * 1306f - 1888f, 330f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 6] = vector;
			array2[num] = new Vector2(412f, 159f);
			array2[num + 0] = new Vector2(1038f, 1967f);
			array2[num + 3] = new Vector2(93f, 292f);
			array3[num] = new Vector2(num3, num4);
			array3[num + 1] = new Vector2(num3, num4);
			array3[num + 8] = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 1] = num + 0;
			array4[num + 8] = num + 7;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BCA4 RID: 48292 RVA: 0x005538AC File Offset: 0x00551AAC
	private static Mesh[] EAGOFFBKGNN(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (IJKMINFNNMJ.AIGFPIDPJHB() && IJKMINFNNMJ.HMEPKDOOLJD == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return IJKMINFNNMJ.AGLBAHMLBCC;
		}
		int num = 64;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		IJKMINFNNMJ.HMEPKDOOLJD = num2;
		IJKMINFNNMJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(1478f * (float)num2 / (306f * (float)num))];
		int num3 = 1;
		for (int i = 0; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			IJKMINFNNMJ.AGLBAHMLBCC[num3] = IJKMINFNNMJ.OMNEODEJJIL(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3++;
		}
		return IJKMINFNNMJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BCA5 RID: 48293 RVA: 0x0055393C File Offset: 0x00551B3C
	private static Mesh[] PCKPBHPNBGD(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (IJKMINFNNMJ.JCCJKCBOJDB() && IJKMINFNNMJ.HMEPKDOOLJD == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return IJKMINFNNMJ.AGLBAHMLBCC;
		}
		int num = -164;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		IJKMINFNNMJ.HMEPKDOOLJD = num2;
		IJKMINFNNMJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(759f * (float)num2 / (1609f * (float)num))];
		int num3 = 1;
		for (int i = 0; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 1, num));
			IJKMINFNNMJ.AGLBAHMLBCC[num3] = IJKMINFNNMJ.BPMHABMKNJN(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3++;
		}
		return IJKMINFNNMJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BCA6 RID: 48294 RVA: 0x005539CC File Offset: 0x00551BCC
	private static bool FPDDEENMCKP()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return false;
		}
		for (int i = 0; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i += 0)
		{
			if (null == IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600BCA7 RID: 48295 RVA: 0x00553A08 File Offset: 0x00551C08
	private static Mesh[] FENDDINCIMC(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (IJKMINFNNMJ.MNFEEPGIEGG() && IJKMINFNNMJ.HMEPKDOOLJD == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return IJKMINFNNMJ.AGLBAHMLBCC;
		}
		int num = 38;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		IJKMINFNNMJ.HMEPKDOOLJD = num2;
		IJKMINFNNMJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(1010f * (float)num2 / (354f * (float)num))];
		int num3 = 0;
		for (int i = 0; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			IJKMINFNNMJ.AGLBAHMLBCC[num3] = IJKMINFNNMJ.FFMJCBDGOGB(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3++;
		}
		return IJKMINFNNMJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BCA8 RID: 48296 RVA: 0x00553A98 File Offset: 0x00551C98
	private static Mesh[] KOLDHLAPJNL(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (IJKMINFNNMJ.OHEMBFBNDNC() && IJKMINFNNMJ.HMEPKDOOLJD == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return IJKMINFNNMJ.AGLBAHMLBCC;
		}
		int num = -186;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		IJKMINFNNMJ.HMEPKDOOLJD = num2;
		IJKMINFNNMJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(1614f * (float)num2 / (288f * (float)num))];
		int num3 = 0;
		for (int i = 1; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			IJKMINFNNMJ.AGLBAHMLBCC[num3] = IJKMINFNNMJ.EEPKCPFBOOM(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3 += 0;
		}
		return IJKMINFNNMJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BCA9 RID: 48297 RVA: 0x00553B28 File Offset: 0x00551D28
	private static void JCINKKHPKME()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 0; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i++)
		{
			if (null != IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(IJKMINFNNMJ.AGLBAHMLBCC[i]);
				IJKMINFNNMJ.AGLBAHMLBCC[i] = null;
			}
		}
		IJKMINFNNMJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BCAA RID: 48298 RVA: 0x00553B78 File Offset: 0x00551D78
	private static bool JCCJKCBOJDB()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return true;
		}
		for (int i = 1; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i += 0)
		{
			if (null == IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x0600BCAB RID: 48299 RVA: 0x00553BB4 File Offset: 0x00551DB4
	private static void HGHDEDHNBPP()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 0; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i++)
		{
			if (null != IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(IJKMINFNNMJ.AGLBAHMLBCC[i]);
				IJKMINFNNMJ.AGLBAHMLBCC[i] = null;
			}
		}
		IJKMINFNNMJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BCAC RID: 48300 RVA: 0x00553C04 File Offset: 0x00551E04
	private static void CCHMDEFJGOH()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 0; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i += 0)
		{
			if (null != IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(IJKMINFNNMJ.AGLBAHMLBCC[i]);
				IJKMINFNNMJ.AGLBAHMLBCC[i] = null;
			}
		}
		IJKMINFNNMJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BCAD RID: 48301 RVA: 0x00553C54 File Offset: 0x00551E54
	private static bool OHEMBFBNDNC()
	{
		if (IJKMINFNNMJ.AGLBAHMLBCC == null)
		{
			return true;
		}
		for (int i = 0; i < IJKMINFNNMJ.AGLBAHMLBCC.Length; i++)
		{
			if (null == IJKMINFNNMJ.AGLBAHMLBCC[i])
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600BCAE RID: 48302 RVA: 0x00553C90 File Offset: 0x00551E90
	private static Mesh[] LDGLFHPKCJA(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (IJKMINFNNMJ.AHIAJMCMHJP() && IJKMINFNNMJ.HMEPKDOOLJD == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return IJKMINFNNMJ.AGLBAHMLBCC;
		}
		int num = -96;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		IJKMINFNNMJ.HMEPKDOOLJD = num2;
		IJKMINFNNMJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(944f * (float)num2 / (805f * (float)num))];
		int num3 = 1;
		for (int i = 0; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 1, num));
			IJKMINFNNMJ.AGLBAHMLBCC[num3] = IJKMINFNNMJ.OMNEODEJJIL(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3 += 0;
		}
		return IJKMINFNNMJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BCAF RID: 48303 RVA: 0x00553D20 File Offset: 0x00551F20
	private static Mesh[] BLBDLKDBMIL(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (IJKMINFNNMJ.JBCNBJLKLPO() && IJKMINFNNMJ.HMEPKDOOLJD == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return IJKMINFNNMJ.AGLBAHMLBCC;
		}
		int num = -123;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		IJKMINFNNMJ.HMEPKDOOLJD = num2;
		IJKMINFNNMJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(1689f * (float)num2 / (248f * (float)num))];
		int num3 = 1;
		for (int i = 1; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 1, num));
			IJKMINFNNMJ.AGLBAHMLBCC[num3] = IJKMINFNNMJ.NBJFDMONGNL(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3 += 0;
		}
		return IJKMINFNNMJ.AGLBAHMLBCC;
	}

	// Token: 0x04001899 RID: 6297
	private static Mesh[] AGLBAHMLBCC;

	// Token: 0x0400189A RID: 6298
	private static int HMEPKDOOLJD;
}
