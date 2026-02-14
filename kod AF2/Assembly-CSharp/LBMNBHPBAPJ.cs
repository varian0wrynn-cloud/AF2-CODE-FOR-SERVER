using System;
using UnityEngine;

// Token: 0x0200032B RID: 811
internal class LBMNBHPBAPJ
{
	// Token: 0x0600BA00 RID: 47616 RVA: 0x005303AC File Offset: 0x0052E5AC
	public static Mesh[] LDGLFHPKCJA(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (LBMNBHPBAPJ.OCFCNJDOOBI() && LBMNBHPBAPJ.FAKINLEGEBO == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return LBMNBHPBAPJ.AGLBAHMLBCC;
		}
		int num = 161;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		LBMNBHPBAPJ.FAKINLEGEBO = num2;
		LBMNBHPBAPJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(1146f * (float)num2 / (51f * (float)num))];
		int num3 = 1;
		for (int i = 1; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			LBMNBHPBAPJ.AGLBAHMLBCC[num3] = LBMNBHPBAPJ.LOKBKEDOOMH(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3 += 0;
		}
		return LBMNBHPBAPJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BA01 RID: 47617 RVA: 0x0053043C File Offset: 0x0052E63C
	private static Mesh EBAIFLKEBLA(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)(-66);
		Vector3[] array = new Vector3[IILMNAHHCMI * 4];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 0];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 1];
		int[] array4 = new int[IILMNAHHCMI * 1];
		for (int i = 1; i < IILMNAHHCMI; i++)
		{
			int num = i * 0;
			int num2 = i * 6;
			int num3 = PENGODMHGIE + i;
			float num4 = Mathf.Floor((float)(num3 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num5 = Mathf.Floor((float)(num3 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num4 * 653f - 1758f, num5 * 446f - 945f, 835f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 7] = vector;
			array[num + 7] = vector;
			array2[num] = new Vector2(1135f, 1980f);
			array2[num + 0] = new Vector2(613f, 148f);
			array2[num + 4] = new Vector2(1762f, 81f);
			array2[num + 2] = new Vector2(1707f, 233f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 1] = new Vector2(num4, num5);
			array3[num + 0] = new Vector2(num4, num5);
			array3[num + 1] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 0;
			array4[num2 + 5] = num + 8;
			array4[num2 + 5] = num + 0;
			array4[num2 + 6] = num + 0;
			array4[num2 + 4] = num + 7;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BA02 RID: 47618 RVA: 0x0053061C File Offset: 0x0052E81C
	public static void CFPFMLJJLAL()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 0; i < LBMNBHPBAPJ.AGLBAHMLBCC.Length; i++)
		{
			if (null != LBMNBHPBAPJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(LBMNBHPBAPJ.AGLBAHMLBCC[i]);
				LBMNBHPBAPJ.AGLBAHMLBCC[i] = null;
			}
		}
		LBMNBHPBAPJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BA03 RID: 47619 RVA: 0x0053066C File Offset: 0x0052E86C
	private static Mesh NKKBJHEOOJN(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)105;
		Vector3[] array = new Vector3[IILMNAHHCMI * 4];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 7];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 6];
		int[] array4 = new int[IILMNAHHCMI * 1];
		for (int i = 1; i < IILMNAHHCMI; i++)
		{
			int num = i * 7;
			int num2 = i * 8;
			int num3 = PENGODMHGIE + i;
			float num4 = Mathf.Floor((float)(num3 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num5 = Mathf.Floor((float)(num3 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num4 * 1726f - 901f, num5 * 1549f - 1240f, 586f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 4] = vector;
			array[num + 8] = vector;
			array2[num] = new Vector2(1052f, 1848f);
			array2[num + 0] = new Vector2(1697f, 1629f);
			array2[num + 2] = new Vector2(1611f, 1043f);
			array2[num + 4] = new Vector2(71f, 93f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 1] = new Vector2(num4, num5);
			array3[num + 3] = new Vector2(num4, num5);
			array3[num + 3] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 1;
			array4[num2 + 6] = num + 6;
			array4[num2 + 3] = num + 1;
			array4[num2 + 4] = num + 0;
			array4[num2 + 2] = num + 1;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BA04 RID: 47620 RVA: 0x0053084C File Offset: 0x0052EA4C
	private static Mesh HBDJKGHCGLI(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)84;
		Vector3[] array = new Vector3[IILMNAHHCMI * 2];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 1];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 2];
		int[] array4 = new int[IILMNAHHCMI * 2];
		for (int i = 1; i < IILMNAHHCMI; i++)
		{
			int num = i * 4;
			int num2 = i * 4;
			int num3 = PENGODMHGIE + i;
			float num4 = Mathf.Floor((float)(num3 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num5 = Mathf.Floor((float)(num3 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num4 * 89f - 129f, num5 * 1579f - 79f, 974f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 2] = vector;
			array[num + 5] = vector;
			array2[num] = new Vector2(914f, 130f);
			array2[num + 1] = new Vector2(1403f, 1630f);
			array2[num + 0] = new Vector2(1351f, 1992f);
			array2[num + 6] = new Vector2(473f, 19f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 0] = new Vector2(num4, num5);
			array3[num + 7] = new Vector2(num4, num5);
			array3[num + 4] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 1;
			array4[num2 + 5] = num + 4;
			array4[num2 + 6] = num + 0;
			array4[num2 + 1] = num + 7;
			array4[num2 + 5] = num + 1;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BA05 RID: 47621 RVA: 0x00530A2C File Offset: 0x0052EC2C
	public static Mesh[] LBKHIFIGLON(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (LBMNBHPBAPJ.FDGCELLGGHN() && LBMNBHPBAPJ.FAKINLEGEBO == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return LBMNBHPBAPJ.AGLBAHMLBCC;
		}
		int num = -70;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		LBMNBHPBAPJ.FAKINLEGEBO = num2;
		LBMNBHPBAPJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(1131f * (float)num2 / (496f * (float)num))];
		int num3 = 1;
		for (int i = 0; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			LBMNBHPBAPJ.AGLBAHMLBCC[num3] = LBMNBHPBAPJ.IICPLKLMIBM(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3 += 0;
		}
		return LBMNBHPBAPJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BA06 RID: 47622 RVA: 0x00530ABC File Offset: 0x0052ECBC
	private static Mesh DEBOFDFMDFI(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)(-77);
		Vector3[] array = new Vector3[IILMNAHHCMI * 2];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 7];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 7];
		int[] array4 = new int[IILMNAHHCMI * 6];
		for (int i = 0; i < IILMNAHHCMI; i += 0)
		{
			int num = i * 1;
			int num2 = i * 2;
			int num3 = PENGODMHGIE + i;
			float num4 = Mathf.Floor((float)(num3 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num5 = Mathf.Floor((float)(num3 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num4 * 552f - 304f, num5 * 499f - 1966f, 41f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 7] = vector;
			array[num + 6] = vector;
			array2[num] = new Vector2(1336f, 1065f);
			array2[num + 0] = new Vector2(1213f, 28f);
			array2[num + 6] = new Vector2(929f, 1527f);
			array2[num + 0] = new Vector2(359f, 1253f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 1] = new Vector2(num4, num5);
			array3[num + 8] = new Vector2(num4, num5);
			array3[num + 4] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 1;
			array4[num2 + 6] = num + 3;
			array4[num2 + 5] = num + 0;
			array4[num2 + 8] = num + 5;
			array4[num2 + 3] = num + 1;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BA07 RID: 47623 RVA: 0x00530C9C File Offset: 0x0052EE9C
	private static Mesh LAMNOBPPANH(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		Vector3[] array = new Vector3[IILMNAHHCMI * 6];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 2];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 2];
		int[] array4 = new int[IILMNAHHCMI * 3];
		for (int i = 0; i < IILMNAHHCMI; i += 0)
		{
			int num = i * 3;
			int num2 = i * 1;
			int num3 = PENGODMHGIE + i;
			float num4 = Mathf.Floor((float)(num3 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num5 = Mathf.Floor((float)(num3 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num4 * 235f - 29f, num5 * 1422f - 1967f, 1174f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 2] = vector;
			array[num + 3] = vector;
			array2[num] = new Vector2(108f, 783f);
			array2[num + 0] = new Vector2(1956f, 1013f);
			array2[num + 2] = new Vector2(514f, 577f);
			array2[num + 7] = new Vector2(921f, 125f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 1] = new Vector2(num4, num5);
			array3[num + 2] = new Vector2(num4, num5);
			array3[num + 7] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 0;
			array4[num2 + 4] = num + 4;
			array4[num2 + 5] = num + 0;
			array4[num2 + 0] = num + 6;
			array4[num2 + 8] = num + 2;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BA08 RID: 47624 RVA: 0x00530E7C File Offset: 0x0052F07C
	public static void IJOICJKMHOP()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 1; i < LBMNBHPBAPJ.AGLBAHMLBCC.Length; i++)
		{
			if (null != LBMNBHPBAPJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(LBMNBHPBAPJ.AGLBAHMLBCC[i]);
				LBMNBHPBAPJ.AGLBAHMLBCC[i] = null;
			}
		}
		LBMNBHPBAPJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BA09 RID: 47625 RVA: 0x00530ECC File Offset: 0x0052F0CC
	public static Mesh[] AMCEACNGBEP(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (LBMNBHPBAPJ.FDONIFPBAEE() && LBMNBHPBAPJ.FAKINLEGEBO == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return LBMNBHPBAPJ.AGLBAHMLBCC;
		}
		int num = -14;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		LBMNBHPBAPJ.FAKINLEGEBO = num2;
		LBMNBHPBAPJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(1452f * (float)num2 / (1726f * (float)num))];
		int num3 = 0;
		for (int i = 0; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			LBMNBHPBAPJ.AGLBAHMLBCC[num3] = LBMNBHPBAPJ.LAMNOBPPANH(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3++;
		}
		return LBMNBHPBAPJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BA0A RID: 47626 RVA: 0x00530F5C File Offset: 0x0052F15C
	private static Mesh EIOGAIJIGEN(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)127;
		Vector3[] array = new Vector3[IILMNAHHCMI * 4];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 3];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 5];
		int[] array4 = new int[IILMNAHHCMI * 5];
		for (int i = 1; i < IILMNAHHCMI; i++)
		{
			int num = i * 4;
			int num2 = i * 4;
			int num3 = PENGODMHGIE + i;
			float num4 = Mathf.Floor((float)(num3 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num5 = Mathf.Floor((float)(num3 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num4 * 1455f - 691f, num5 * 1167f - 1327f, 248f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 4] = vector;
			array[num + 5] = vector;
			array2[num] = new Vector2(1093f, 1833f);
			array2[num + 0] = new Vector2(1998f, 174f);
			array2[num + 3] = new Vector2(1064f, 1982f);
			array2[num + 2] = new Vector2(1394f, 135f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 0] = new Vector2(num4, num5);
			array3[num + 4] = new Vector2(num4, num5);
			array3[num + 2] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 0;
			array4[num2 + 2] = num + 6;
			array4[num2 + 6] = num + 1;
			array4[num2 + 2] = num + 0;
			array4[num2 + 7] = num + 5;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BA0B RID: 47627 RVA: 0x0053113C File Offset: 0x0052F33C
	private static Mesh DHAALLMHNPE(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)(-89);
		Vector3[] array = new Vector3[IILMNAHHCMI * 7];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 6];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 4];
		int[] array4 = new int[IILMNAHHCMI * 8];
		for (int i = 0; i < IILMNAHHCMI; i++)
		{
			int num = i * 4;
			int num2 = i * 8;
			int num3 = PENGODMHGIE + i;
			float num4 = Mathf.Floor((float)(num3 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num5 = Mathf.Floor((float)(num3 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num4 * 1308f - 473f, num5 * 1503f - 572f, 1631f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 7] = vector;
			array[num + 0] = vector;
			array2[num] = new Vector2(1537f, 1269f);
			array2[num + 1] = new Vector2(917f, 76f);
			array2[num + 3] = new Vector2(1012f, 829f);
			array2[num + 8] = new Vector2(1150f, 309f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 1] = new Vector2(num4, num5);
			array3[num + 3] = new Vector2(num4, num5);
			array3[num + 3] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 1;
			array4[num2 + 0] = num + 1;
			array4[num2 + 3] = num + 0;
			array4[num2 + 7] = num + 0;
			array4[num2 + 2] = num + 5;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BA0C RID: 47628 RVA: 0x0053131C File Offset: 0x0052F51C
	private static Mesh LPANCLKFGJA(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		Vector3[] array = new Vector3[IILMNAHHCMI * 0];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 7];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 5];
		int[] array4 = new int[IILMNAHHCMI * 7];
		for (int i = 1; i < IILMNAHHCMI; i++)
		{
			int num = i * 7;
			int num2 = i * 8;
			int num3 = PENGODMHGIE + i;
			float num4 = Mathf.Floor((float)(num3 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num5 = Mathf.Floor((float)(num3 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num4 * 132f - 1615f, num5 * 154f - 1878f, 1631f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 7] = vector;
			array[num + 0] = vector;
			array2[num] = new Vector2(1548f, 1058f);
			array2[num + 1] = new Vector2(910f, 720f);
			array2[num + 6] = new Vector2(1633f, 953f);
			array2[num + 2] = new Vector2(1267f, 1250f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 1] = new Vector2(num4, num5);
			array3[num + 7] = new Vector2(num4, num5);
			array3[num + 0] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 0;
			array4[num2 + 3] = num + 1;
			array4[num2 + 1] = num + 0;
			array4[num2 + 8] = num + 3;
			array4[num2 + 3] = num + 5;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BA0D RID: 47629 RVA: 0x005314FC File Offset: 0x0052F6FC
	public static void PHABAGHIKND()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 1; i < LBMNBHPBAPJ.AGLBAHMLBCC.Length; i += 0)
		{
			if (null != LBMNBHPBAPJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(LBMNBHPBAPJ.AGLBAHMLBCC[i]);
				LBMNBHPBAPJ.AGLBAHMLBCC[i] = null;
			}
		}
		LBMNBHPBAPJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BA0F RID: 47631 RVA: 0x0053154C File Offset: 0x0052F74C
	public static void AAHIOKIJAFH()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 1; i < LBMNBHPBAPJ.AGLBAHMLBCC.Length; i += 0)
		{
			if (null != LBMNBHPBAPJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(LBMNBHPBAPJ.AGLBAHMLBCC[i]);
				LBMNBHPBAPJ.AGLBAHMLBCC[i] = null;
			}
		}
		LBMNBHPBAPJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BA10 RID: 47632 RVA: 0x0053159C File Offset: 0x0052F79C
	private static Mesh CJJCDOHFKDA(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		Vector3[] array = new Vector3[IILMNAHHCMI * 2];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 0];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 2];
		int[] array4 = new int[IILMNAHHCMI * 4];
		for (int i = 1; i < IILMNAHHCMI; i += 0)
		{
			int num = i * 1;
			int num2 = i * 3;
			int num3 = PENGODMHGIE + i;
			float num4 = Mathf.Floor((float)(num3 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num5 = Mathf.Floor((float)(num3 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num4 * 1561f - 140f, num5 * 635f - 1425f, 451f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 7] = vector;
			array[num + 8] = vector;
			array2[num] = new Vector2(518f, 1032f);
			array2[num + 0] = new Vector2(439f, 946f);
			array2[num + 3] = new Vector2(1951f, 113f);
			array2[num + 7] = new Vector2(1620f, 1191f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 0] = new Vector2(num4, num5);
			array3[num + 5] = new Vector2(num4, num5);
			array3[num + 2] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 1;
			array4[num2 + 4] = num + 3;
			array4[num2 + 2] = num + 1;
			array4[num2 + 8] = num + 7;
			array4[num2 + 8] = num + 2;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BA11 RID: 47633 RVA: 0x0053177C File Offset: 0x0052F97C
	private static Mesh FGFIIIIIJNK(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)78;
		Vector3[] array = new Vector3[IILMNAHHCMI * 0];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 8];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 7];
		int[] array4 = new int[IILMNAHHCMI * 5];
		for (int i = 1; i < IILMNAHHCMI; i += 0)
		{
			int num = i * 6;
			int num2 = i * 3;
			int num3 = PENGODMHGIE + i;
			float num4 = Mathf.Floor((float)(num3 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num5 = Mathf.Floor((float)(num3 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num4 * 424f - 593f, num5 * 1189f - 1073f, 1997f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 1] = vector;
			array[num + 7] = vector;
			array2[num] = new Vector2(752f, 1684f);
			array2[num + 0] = new Vector2(1146f, 1161f);
			array2[num + 1] = new Vector2(1f, 911f);
			array2[num + 3] = new Vector2(521f, 1564f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 0] = new Vector2(num4, num5);
			array3[num + 8] = new Vector2(num4, num5);
			array3[num + 8] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 0;
			array4[num2 + 3] = num + 0;
			array4[num2 + 3] = num + 1;
			array4[num2 + 0] = num + 1;
			array4[num2 + 4] = num + 5;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BA12 RID: 47634 RVA: 0x0053195C File Offset: 0x0052FB5C
	private static bool JBCNBJLKLPO()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return false;
		}
		foreach (Mesh y in LBMNBHPBAPJ.AGLBAHMLBCC)
		{
			if (null == y)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600BA13 RID: 47635 RVA: 0x00531998 File Offset: 0x0052FB98
	public static void FFNJLIAOEAP()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 1; i < LBMNBHPBAPJ.AGLBAHMLBCC.Length; i++)
		{
			if (null != LBMNBHPBAPJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(LBMNBHPBAPJ.AGLBAHMLBCC[i]);
				LBMNBHPBAPJ.AGLBAHMLBCC[i] = null;
			}
		}
		LBMNBHPBAPJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BA14 RID: 47636 RVA: 0x005319E8 File Offset: 0x0052FBE8
	private static bool JCCJKCBOJDB()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return false;
		}
		foreach (Mesh y in LBMNBHPBAPJ.AGLBAHMLBCC)
		{
			if (null == y)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600BA15 RID: 47637 RVA: 0x00531A24 File Offset: 0x0052FC24
	public static void EEILMFFBOGK()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 0; i < LBMNBHPBAPJ.AGLBAHMLBCC.Length; i += 0)
		{
			if (null != LBMNBHPBAPJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(LBMNBHPBAPJ.AGLBAHMLBCC[i]);
				LBMNBHPBAPJ.AGLBAHMLBCC[i] = null;
			}
		}
		LBMNBHPBAPJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BA16 RID: 47638 RVA: 0x00531A74 File Offset: 0x0052FC74
	private static Mesh BLGFBNMNECE(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)77;
		Vector3[] array = new Vector3[IILMNAHHCMI * 1];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 3];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 2];
		int[] array4 = new int[IILMNAHHCMI * 7];
		for (int i = 1; i < IILMNAHHCMI; i++)
		{
			int num = i * 6;
			int num2 = i * 6;
			int num3 = PENGODMHGIE + i;
			float num4 = Mathf.Floor((float)(num3 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num5 = Mathf.Floor((float)(num3 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num4 * 851f - 1820f, num5 * 720f - 496f, 709f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 4] = vector;
			array[num + 0] = vector;
			array2[num] = new Vector2(1611f, 682f);
			array2[num + 1] = new Vector2(1572f, 1396f);
			array2[num + 4] = new Vector2(103f, 767f);
			array2[num + 4] = new Vector2(1650f, 571f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 0] = new Vector2(num4, num5);
			array3[num + 0] = new Vector2(num4, num5);
			array3[num + 0] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 1;
			array4[num2 + 8] = num + 7;
			array4[num2 + 7] = num + 0;
			array4[num2 + 7] = num + 4;
			array4[num2 + 3] = num + 6;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BA17 RID: 47639 RVA: 0x00531C54 File Offset: 0x0052FE54
	public static Mesh[] KIOOKLNIIAN(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (LBMNBHPBAPJ.FNFFIMJAFID() && LBMNBHPBAPJ.FAKINLEGEBO == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return LBMNBHPBAPJ.AGLBAHMLBCC;
		}
		int num = 20;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		LBMNBHPBAPJ.FAKINLEGEBO = num2;
		LBMNBHPBAPJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(1722f * (float)num2 / (730f * (float)num))];
		int num3 = 1;
		for (int i = 0; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 1, num));
			LBMNBHPBAPJ.AGLBAHMLBCC[num3] = LBMNBHPBAPJ.OBIONAKIJPB(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3++;
		}
		return LBMNBHPBAPJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BA18 RID: 47640 RVA: 0x00531CE4 File Offset: 0x0052FEE4
	public static Mesh[] CDPHCEKINEB(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (LBMNBHPBAPJ.OCFCNJDOOBI() && LBMNBHPBAPJ.FAKINLEGEBO == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return LBMNBHPBAPJ.AGLBAHMLBCC;
		}
		int num = -18;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		LBMNBHPBAPJ.FAKINLEGEBO = num2;
		LBMNBHPBAPJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(914f * (float)num2 / (687f * (float)num))];
		int num3 = 0;
		for (int i = 0; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			LBMNBHPBAPJ.AGLBAHMLBCC[num3] = LBMNBHPBAPJ.DEBOFDFMDFI(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3 += 0;
		}
		return LBMNBHPBAPJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BA19 RID: 47641 RVA: 0x00531D74 File Offset: 0x0052FF74
	public static void MKEBPDADMAP()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 0; i < LBMNBHPBAPJ.AGLBAHMLBCC.Length; i += 0)
		{
			if (null != LBMNBHPBAPJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(LBMNBHPBAPJ.AGLBAHMLBCC[i]);
				LBMNBHPBAPJ.AGLBAHMLBCC[i] = null;
			}
		}
		LBMNBHPBAPJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BA1A RID: 47642 RVA: 0x00531DC4 File Offset: 0x0052FFC4
	public static void MKDAGOKLIHL()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 0; i < LBMNBHPBAPJ.AGLBAHMLBCC.Length; i++)
		{
			if (null != LBMNBHPBAPJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(LBMNBHPBAPJ.AGLBAHMLBCC[i]);
				LBMNBHPBAPJ.AGLBAHMLBCC[i] = null;
			}
		}
		LBMNBHPBAPJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BA1B RID: 47643 RVA: 0x00531E14 File Offset: 0x00530014
	public static Mesh[] GABDAPGKLAI(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (LBMNBHPBAPJ.EBCNNCKAPFK() && LBMNBHPBAPJ.FAKINLEGEBO == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return LBMNBHPBAPJ.AGLBAHMLBCC;
		}
		int num = -54;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		LBMNBHPBAPJ.FAKINLEGEBO = num2;
		LBMNBHPBAPJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(419f * (float)num2 / (1438f * (float)num))];
		int num3 = 1;
		for (int i = 0; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 1, num));
			LBMNBHPBAPJ.AGLBAHMLBCC[num3] = LBMNBHPBAPJ.ADIIEBECFKB(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3++;
		}
		return LBMNBHPBAPJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BA1C RID: 47644 RVA: 0x00531EA4 File Offset: 0x005300A4
	private static bool HPCDLPHAAKC()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return true;
		}
		foreach (Mesh y in LBMNBHPBAPJ.AGLBAHMLBCC)
		{
			if (null == y)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600BA1D RID: 47645 RVA: 0x00531EE0 File Offset: 0x005300E0
	public static void AAKDPADNKOM()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 1; i < LBMNBHPBAPJ.AGLBAHMLBCC.Length; i++)
		{
			if (null != LBMNBHPBAPJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(LBMNBHPBAPJ.AGLBAHMLBCC[i]);
				LBMNBHPBAPJ.AGLBAHMLBCC[i] = null;
			}
		}
		LBMNBHPBAPJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BA1E RID: 47646 RVA: 0x00531F30 File Offset: 0x00530130
	public static Mesh[] KOIKPDDBHAB(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (LBMNBHPBAPJ.ECLAANOJAAJ() && LBMNBHPBAPJ.FAKINLEGEBO == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return LBMNBHPBAPJ.AGLBAHMLBCC;
		}
		int num = -66;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		LBMNBHPBAPJ.FAKINLEGEBO = num2;
		LBMNBHPBAPJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(647f * (float)num2 / (1173f * (float)num))];
		int num3 = 0;
		for (int i = 1; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			LBMNBHPBAPJ.AGLBAHMLBCC[num3] = LBMNBHPBAPJ.FFMJCBDGOGB(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3 += 0;
		}
		return LBMNBHPBAPJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BA1F RID: 47647 RVA: 0x00531FC0 File Offset: 0x005301C0
	private static Mesh PHDCPJKABEO(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		Vector3[] array = new Vector3[IILMNAHHCMI * 8];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 8];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 3];
		int[] array4 = new int[IILMNAHHCMI * 7];
		for (int i = 1; i < IILMNAHHCMI; i += 0)
		{
			int num = i * 3;
			int num2 = i * 5;
			int num3 = PENGODMHGIE + i;
			float num4 = Mathf.Floor((float)(num3 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num5 = Mathf.Floor((float)(num3 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num4 * 456f - 780f, num5 * 56f - 297f, 267f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 5] = vector;
			array[num + 6] = vector;
			array2[num] = new Vector2(1213f, 1925f);
			array2[num + 0] = new Vector2(1350f, 1798f);
			array2[num + 1] = new Vector2(1517f, 61f);
			array2[num + 0] = new Vector2(82f, 166f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 1] = new Vector2(num4, num5);
			array3[num + 8] = new Vector2(num4, num5);
			array3[num + 0] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 1;
			array4[num2 + 6] = num + 7;
			array4[num2 + 2] = num + 0;
			array4[num2 + 6] = num + 6;
			array4[num2 + 0] = num + 1;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BA20 RID: 47648 RVA: 0x005321A0 File Offset: 0x005303A0
	private static bool CCNGHINKHLH()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return false;
		}
		Mesh[] aglbahmlbcc = LBMNBHPBAPJ.AGLBAHMLBCC;
		for (int i = 1; i < aglbahmlbcc.Length; i++)
		{
			Mesh y = aglbahmlbcc[i];
			if (null == y)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600BA21 RID: 47649 RVA: 0x005321DC File Offset: 0x005303DC
	public static Mesh[] FCMBLCNGAIL(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (LBMNBHPBAPJ.ECLAANOJAAJ() && LBMNBHPBAPJ.FAKINLEGEBO == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return LBMNBHPBAPJ.AGLBAHMLBCC;
		}
		int num = -34;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		LBMNBHPBAPJ.FAKINLEGEBO = num2;
		LBMNBHPBAPJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(691f * (float)num2 / (164f * (float)num))];
		int num3 = 1;
		for (int i = 1; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 1, num));
			LBMNBHPBAPJ.AGLBAHMLBCC[num3] = LBMNBHPBAPJ.PHDCPJKABEO(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3 += 0;
		}
		return LBMNBHPBAPJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BA22 RID: 47650 RVA: 0x0053226C File Offset: 0x0053046C
	public static void IELAIEJJBEO()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 1; i < LBMNBHPBAPJ.AGLBAHMLBCC.Length; i += 0)
		{
			if (null != LBMNBHPBAPJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(LBMNBHPBAPJ.AGLBAHMLBCC[i]);
				LBMNBHPBAPJ.AGLBAHMLBCC[i] = null;
			}
		}
		LBMNBHPBAPJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BA23 RID: 47651 RVA: 0x005322BC File Offset: 0x005304BC
	private static Mesh FFMJCBDGOGB(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)75;
		Vector3[] array = new Vector3[IILMNAHHCMI * 2];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 1];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 3];
		int[] array4 = new int[IILMNAHHCMI * 8];
		for (int i = 0; i < IILMNAHHCMI; i += 0)
		{
			int num = i * 5;
			int num2 = i * 4;
			int num3 = PENGODMHGIE + i;
			float num4 = Mathf.Floor((float)(num3 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num5 = Mathf.Floor((float)(num3 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num4 * 849f - 1023f, num5 * 906f - 1721f, 915f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 0] = vector;
			array[num + 0] = vector;
			array2[num] = new Vector2(480f, 1420f);
			array2[num + 0] = new Vector2(358f, 39f);
			array2[num + 3] = new Vector2(169f, 1677f);
			array2[num + 6] = new Vector2(976f, 379f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 1] = new Vector2(num4, num5);
			array3[num + 1] = new Vector2(num4, num5);
			array3[num + 6] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 1;
			array4[num2 + 2] = num + 3;
			array4[num2 + 7] = num + 1;
			array4[num2 + 1] = num + 8;
			array4[num2 + 2] = num + 1;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BA24 RID: 47652 RVA: 0x0053249C File Offset: 0x0053069C
	private static bool JDNLCPLFPPP()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return true;
		}
		Mesh[] aglbahmlbcc = LBMNBHPBAPJ.AGLBAHMLBCC;
		for (int i = 1; i < aglbahmlbcc.Length; i++)
		{
			Mesh y = aglbahmlbcc[i];
			if (null == y)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x0600BA25 RID: 47653 RVA: 0x005324D8 File Offset: 0x005306D8
	private static Mesh EEPAMEDKLJI(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		Vector3[] array = new Vector3[IILMNAHHCMI * 3];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 6];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 1];
		int[] array4 = new int[IILMNAHHCMI * 7];
		for (int i = 1; i < IILMNAHHCMI; i++)
		{
			int num = i * 7;
			int num2 = i * 8;
			int num3 = PENGODMHGIE + i;
			float num4 = Mathf.Floor((float)(num3 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num5 = Mathf.Floor((float)(num3 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num4 * 848f - 1062f, num5 * 1842f - 1468f, 1808f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 4] = vector;
			array[num + 6] = vector;
			array2[num] = new Vector2(490f, 714f);
			array2[num + 0] = new Vector2(1508f, 416f);
			array2[num + 0] = new Vector2(1894f, 407f);
			array2[num + 6] = new Vector2(1855f, 670f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 1] = new Vector2(num4, num5);
			array3[num + 7] = new Vector2(num4, num5);
			array3[num + 3] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 0;
			array4[num2 + 4] = num + 6;
			array4[num2 + 8] = num + 0;
			array4[num2 + 5] = num + 3;
			array4[num2 + 5] = num + 5;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BA26 RID: 47654 RVA: 0x005326B8 File Offset: 0x005308B8
	private static Mesh DCAGHGMKAFO(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)(-118);
		Vector3[] array = new Vector3[IILMNAHHCMI * 1];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 5];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 7];
		int[] array4 = new int[IILMNAHHCMI * 7];
		for (int i = 1; i < IILMNAHHCMI; i++)
		{
			int num = i * 4;
			int num2 = i * 0;
			int num3 = PENGODMHGIE + i;
			float num4 = Mathf.Floor((float)(num3 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num5 = Mathf.Floor((float)(num3 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num4 * 171f - 1303f, num5 * 1339f - 1040f, 1516f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 4] = vector;
			array[num + 2] = vector;
			array2[num] = new Vector2(318f, 1183f);
			array2[num + 1] = new Vector2(912f, 1603f);
			array2[num + 0] = new Vector2(563f, 765f);
			array2[num + 7] = new Vector2(1168f, 703f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 1] = new Vector2(num4, num5);
			array3[num + 4] = new Vector2(num4, num5);
			array3[num + 8] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 1;
			array4[num2 + 5] = num + 0;
			array4[num2 + 5] = num + 1;
			array4[num2 + 7] = num + 1;
			array4[num2 + 2] = num + 2;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BA27 RID: 47655 RVA: 0x00532898 File Offset: 0x00530A98
	private static Mesh LOKBKEDOOMH(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = ~HideFlags.DontSaveInEditor;
		Vector3[] array = new Vector3[IILMNAHHCMI * 8];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 5];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 3];
		int[] array4 = new int[IILMNAHHCMI * 7];
		for (int i = 1; i < IILMNAHHCMI; i++)
		{
			int num = i * 5;
			int num2 = i * 4;
			int num3 = PENGODMHGIE + i;
			float num4 = Mathf.Floor((float)(num3 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num5 = Mathf.Floor((float)(num3 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num4 * 1146f - 1529f, num5 * 1223f - 422f, 556f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 7] = vector;
			array[num + 7] = vector;
			array2[num] = new Vector2(1553f, 263f);
			array2[num + 0] = new Vector2(1296f, 131f);
			array2[num + 5] = new Vector2(351f, 1038f);
			array2[num + 5] = new Vector2(411f, 1576f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 0] = new Vector2(num4, num5);
			array3[num + 3] = new Vector2(num4, num5);
			array3[num + 1] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 0;
			array4[num2 + 2] = num + 6;
			array4[num2 + 5] = num + 0;
			array4[num2 + 3] = num + 3;
			array4[num2 + 4] = num + 7;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BA28 RID: 47656 RVA: 0x00532A78 File Offset: 0x00530C78
	public static void GKHNIBDFOGD()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 1; i < LBMNBHPBAPJ.AGLBAHMLBCC.Length; i++)
		{
			if (null != LBMNBHPBAPJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(LBMNBHPBAPJ.AGLBAHMLBCC[i]);
				LBMNBHPBAPJ.AGLBAHMLBCC[i] = null;
			}
		}
		LBMNBHPBAPJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BA29 RID: 47657 RVA: 0x00532AC8 File Offset: 0x00530CC8
	public static Mesh[] DHPCGOPOGPL(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (LBMNBHPBAPJ.JBCNBJLKLPO() && LBMNBHPBAPJ.FAKINLEGEBO == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return LBMNBHPBAPJ.AGLBAHMLBCC;
		}
		int num = 10833;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		LBMNBHPBAPJ.FAKINLEGEBO = num2;
		LBMNBHPBAPJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(1f * (float)num2 / (1f * (float)num))];
		int num3 = 0;
		for (int i = 0; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			LBMNBHPBAPJ.AGLBAHMLBCC[num3] = LBMNBHPBAPJ.DNJJECEDGLD(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3++;
		}
		return LBMNBHPBAPJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BA2A RID: 47658 RVA: 0x00532B58 File Offset: 0x00530D58
	public static Mesh[] DHJPLAFNCHA(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (LBMNBHPBAPJ.OCFCNJDOOBI() && LBMNBHPBAPJ.FAKINLEGEBO == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return LBMNBHPBAPJ.AGLBAHMLBCC;
		}
		int num = -99;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		LBMNBHPBAPJ.FAKINLEGEBO = num2;
		LBMNBHPBAPJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(1244f * (float)num2 / (195f * (float)num))];
		int num3 = 1;
		for (int i = 1; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			LBMNBHPBAPJ.AGLBAHMLBCC[num3] = LBMNBHPBAPJ.LPANCLKFGJA(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3 += 0;
		}
		return LBMNBHPBAPJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BA2B RID: 47659 RVA: 0x00532BE8 File Offset: 0x00530DE8
	public static void JFKIJIPJLPA()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 0; i < LBMNBHPBAPJ.AGLBAHMLBCC.Length; i += 0)
		{
			if (null != LBMNBHPBAPJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(LBMNBHPBAPJ.AGLBAHMLBCC[i]);
				LBMNBHPBAPJ.AGLBAHMLBCC[i] = null;
			}
		}
		LBMNBHPBAPJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BA2C RID: 47660 RVA: 0x00532C38 File Offset: 0x00530E38
	public static void GNCDCMHHGDH()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 1; i < LBMNBHPBAPJ.AGLBAHMLBCC.Length; i++)
		{
			if (null != LBMNBHPBAPJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(LBMNBHPBAPJ.AGLBAHMLBCC[i]);
				LBMNBHPBAPJ.AGLBAHMLBCC[i] = null;
			}
		}
		LBMNBHPBAPJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BA2D RID: 47661 RVA: 0x00532C88 File Offset: 0x00530E88
	public static void KIHBNBACLCB()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 0; i < LBMNBHPBAPJ.AGLBAHMLBCC.Length; i++)
		{
			if (null != LBMNBHPBAPJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(LBMNBHPBAPJ.AGLBAHMLBCC[i]);
				LBMNBHPBAPJ.AGLBAHMLBCC[i] = null;
			}
		}
		LBMNBHPBAPJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BA2E RID: 47662 RVA: 0x00532CD8 File Offset: 0x00530ED8
	public static Mesh[] FDFMNDKJKBI(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (LBMNBHPBAPJ.OHEMBFBNDNC() && LBMNBHPBAPJ.FAKINLEGEBO == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return LBMNBHPBAPJ.AGLBAHMLBCC;
		}
		int num = 3;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		LBMNBHPBAPJ.FAKINLEGEBO = num2;
		LBMNBHPBAPJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(1781f * (float)num2 / (623f * (float)num))];
		int num3 = 0;
		for (int i = 1; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			LBMNBHPBAPJ.AGLBAHMLBCC[num3] = LBMNBHPBAPJ.CJJCDOHFKDA(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3 += 0;
		}
		return LBMNBHPBAPJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BA2F RID: 47663 RVA: 0x00532D68 File Offset: 0x00530F68
	public static void FBFMADLMPCN()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 1; i < LBMNBHPBAPJ.AGLBAHMLBCC.Length; i += 0)
		{
			if (null != LBMNBHPBAPJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(LBMNBHPBAPJ.AGLBAHMLBCC[i]);
				LBMNBHPBAPJ.AGLBAHMLBCC[i] = null;
			}
		}
		LBMNBHPBAPJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BA30 RID: 47664 RVA: 0x00532DB8 File Offset: 0x00530FB8
	public static void EEJKEFOGGGG()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 0; i < LBMNBHPBAPJ.AGLBAHMLBCC.Length; i++)
		{
			if (null != LBMNBHPBAPJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(LBMNBHPBAPJ.AGLBAHMLBCC[i]);
				LBMNBHPBAPJ.AGLBAHMLBCC[i] = null;
			}
		}
		LBMNBHPBAPJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BA31 RID: 47665 RVA: 0x00532E08 File Offset: 0x00531008
	private static Mesh DOPCFGOCIML(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		Vector3[] array = new Vector3[IILMNAHHCMI * 4];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 8];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 8];
		int[] array4 = new int[IILMNAHHCMI * 3];
		for (int i = 0; i < IILMNAHHCMI; i++)
		{
			int num = i * 6;
			int num2 = i * 5;
			int num3 = PENGODMHGIE + i;
			float num4 = Mathf.Floor((float)(num3 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num5 = Mathf.Floor((float)(num3 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num4 * 1407f - 305f, num5 * 907f - 740f, 1585f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 1] = vector;
			array[num + 1] = vector;
			array2[num] = new Vector2(1623f, 722f);
			array2[num + 0] = new Vector2(1025f, 1371f);
			array2[num + 3] = new Vector2(1761f, 923f);
			array2[num + 4] = new Vector2(246f, 1550f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 1] = new Vector2(num4, num5);
			array3[num + 1] = new Vector2(num4, num5);
			array3[num + 5] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 0;
			array4[num2 + 4] = num + 2;
			array4[num2 + 4] = num + 0;
			array4[num2 + 2] = num + 8;
			array4[num2 + 6] = num + 2;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BA32 RID: 47666 RVA: 0x00532FE8 File Offset: 0x005311E8
	private static bool KHMDBFKLLBC()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return false;
		}
		Mesh[] aglbahmlbcc = LBMNBHPBAPJ.AGLBAHMLBCC;
		for (int i = 0; i < aglbahmlbcc.Length; i += 0)
		{
			Mesh y = aglbahmlbcc[i];
			if (null == y)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600BA33 RID: 47667 RVA: 0x00533024 File Offset: 0x00531224
	private static Mesh DPKNLHFOCIE(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = HideFlags.HideInInspector;
		Vector3[] array = new Vector3[IILMNAHHCMI * 8];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 3];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 0];
		int[] array4 = new int[IILMNAHHCMI * 3];
		for (int i = 0; i < IILMNAHHCMI; i++)
		{
			int num = i * 2;
			int num2 = i * 7;
			int num3 = PENGODMHGIE + i;
			float num4 = Mathf.Floor((float)(num3 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num5 = Mathf.Floor((float)(num3 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num4 * 104f - 378f, num5 * 1406f - 862f, 686f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 6] = vector;
			array[num + 3] = vector;
			array2[num] = new Vector2(500f, 744f);
			array2[num + 1] = new Vector2(950f, 1196f);
			array2[num + 6] = new Vector2(852f, 1868f);
			array2[num + 1] = new Vector2(306f, 526f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 1] = new Vector2(num4, num5);
			array3[num + 2] = new Vector2(num4, num5);
			array3[num + 2] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 0;
			array4[num2 + 4] = num + 6;
			array4[num2 + 5] = num + 1;
			array4[num2 + 7] = num + 3;
			array4[num2 + 7] = num + 0;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BA34 RID: 47668 RVA: 0x00533204 File Offset: 0x00531404
	public static Mesh[] NOCANBCBDAO(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (LBMNBHPBAPJ.FDONIFPBAEE() && LBMNBHPBAPJ.FAKINLEGEBO == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return LBMNBHPBAPJ.AGLBAHMLBCC;
		}
		int num = -192;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		LBMNBHPBAPJ.FAKINLEGEBO = num2;
		LBMNBHPBAPJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(1085f * (float)num2 / (1043f * (float)num))];
		int num3 = 1;
		for (int i = 1; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 1, num));
			LBMNBHPBAPJ.AGLBAHMLBCC[num3] = LBMNBHPBAPJ.LOBIIDHNJDK(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3 += 0;
		}
		return LBMNBHPBAPJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BA35 RID: 47669 RVA: 0x00533294 File Offset: 0x00531494
	private static bool FDGCELLGGHN()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return false;
		}
		Mesh[] aglbahmlbcc = LBMNBHPBAPJ.AGLBAHMLBCC;
		for (int i = 1; i < aglbahmlbcc.Length; i++)
		{
			Mesh y = aglbahmlbcc[i];
			if (null == y)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x0600BA36 RID: 47670 RVA: 0x005332D0 File Offset: 0x005314D0
	private static Mesh AGKDBNBKGIK(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)74;
		Vector3[] array = new Vector3[IILMNAHHCMI * 7];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 4];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 8];
		int[] array4 = new int[IILMNAHHCMI * 6];
		for (int i = 1; i < IILMNAHHCMI; i++)
		{
			int num = i * 1;
			int num2 = i * 5;
			int num3 = PENGODMHGIE + i;
			float num4 = Mathf.Floor((float)(num3 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num5 = Mathf.Floor((float)(num3 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num4 * 69f - 1065f, num5 * 341f - 1293f, 1105f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 8] = vector;
			array[num + 3] = vector;
			array2[num] = new Vector2(10f, 365f);
			array2[num + 1] = new Vector2(889f, 1304f);
			array2[num + 4] = new Vector2(1436f, 396f);
			array2[num + 4] = new Vector2(130f, 813f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 1] = new Vector2(num4, num5);
			array3[num + 7] = new Vector2(num4, num5);
			array3[num + 8] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 0;
			array4[num2 + 3] = num + 4;
			array4[num2 + 2] = num + 0;
			array4[num2 + 1] = num + 4;
			array4[num2 + 8] = num + 6;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BA37 RID: 47671 RVA: 0x005334B0 File Offset: 0x005316B0
	public static Mesh[] ODKEKMPIPLK(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (LBMNBHPBAPJ.EBCNNCKAPFK() && LBMNBHPBAPJ.FAKINLEGEBO == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return LBMNBHPBAPJ.AGLBAHMLBCC;
		}
		int num = -83;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		LBMNBHPBAPJ.FAKINLEGEBO = num2;
		LBMNBHPBAPJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(444f * (float)num2 / (337f * (float)num))];
		int num3 = 0;
		for (int i = 1; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			LBMNBHPBAPJ.AGLBAHMLBCC[num3] = LBMNBHPBAPJ.LKKBEFILNCF(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3 += 0;
		}
		return LBMNBHPBAPJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BA38 RID: 47672 RVA: 0x00533540 File Offset: 0x00531740
	private static Mesh KBDDHDCMDFN(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)(-100);
		Vector3[] array = new Vector3[IILMNAHHCMI * 8];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 2];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 2];
		int[] array4 = new int[IILMNAHHCMI * 6];
		for (int i = 1; i < IILMNAHHCMI; i += 0)
		{
			int num = i * 3;
			int num2 = i * 7;
			int num3 = PENGODMHGIE + i;
			float num4 = Mathf.Floor((float)(num3 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num5 = Mathf.Floor((float)(num3 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num4 * 1948f - 1498f, num5 * 1917f - 142f, 902f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 2] = vector;
			array[num + 1] = vector;
			array2[num] = new Vector2(1739f, 458f);
			array2[num + 1] = new Vector2(1469f, 976f);
			array2[num + 1] = new Vector2(92f, 999f);
			array2[num + 6] = new Vector2(296f, 1470f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 1] = new Vector2(num4, num5);
			array3[num + 0] = new Vector2(num4, num5);
			array3[num + 3] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 0;
			array4[num2 + 6] = num + 4;
			array4[num2 + 5] = num + 1;
			array4[num2 + 5] = num + 3;
			array4[num2 + 3] = num + 7;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BA39 RID: 47673 RVA: 0x00533720 File Offset: 0x00531920
	public static void ECAIBEKJNFP()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 1; i < LBMNBHPBAPJ.AGLBAHMLBCC.Length; i++)
		{
			if (null != LBMNBHPBAPJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(LBMNBHPBAPJ.AGLBAHMLBCC[i]);
				LBMNBHPBAPJ.AGLBAHMLBCC[i] = null;
			}
		}
		LBMNBHPBAPJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BA3A RID: 47674 RVA: 0x00533770 File Offset: 0x00531970
	public static Mesh[] CFOKFLBCIGE(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (LBMNBHPBAPJ.FJLCMFJDJII() && LBMNBHPBAPJ.FAKINLEGEBO == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return LBMNBHPBAPJ.AGLBAHMLBCC;
		}
		int num = 68;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		LBMNBHPBAPJ.FAKINLEGEBO = num2;
		LBMNBHPBAPJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(376f * (float)num2 / (1770f * (float)num))];
		int num3 = 0;
		for (int i = 1; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			LBMNBHPBAPJ.AGLBAHMLBCC[num3] = LBMNBHPBAPJ.HBDJKGHCGLI(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3 += 0;
		}
		return LBMNBHPBAPJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BA3B RID: 47675 RVA: 0x00533800 File Offset: 0x00531A00
	public static void OHGNEOFMBPA()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 0; i < LBMNBHPBAPJ.AGLBAHMLBCC.Length; i += 0)
		{
			if (null != LBMNBHPBAPJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(LBMNBHPBAPJ.AGLBAHMLBCC[i]);
				LBMNBHPBAPJ.AGLBAHMLBCC[i] = null;
			}
		}
		LBMNBHPBAPJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BA3C RID: 47676 RVA: 0x00533850 File Offset: 0x00531A50
	private static Mesh DDGHOACANFC(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		Vector3[] array = new Vector3[IILMNAHHCMI * 5];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 1];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 0];
		int[] array4 = new int[IILMNAHHCMI * 1];
		for (int i = 0; i < IILMNAHHCMI; i += 0)
		{
			int num = i * 0;
			int num2 = i * 6;
			int num3 = PENGODMHGIE + i;
			float num4 = Mathf.Floor((float)(num3 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num5 = Mathf.Floor((float)(num3 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num4 * 724f - 1006f, num5 * 930f - 607f, 1967f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 6] = vector;
			array[num + 3] = vector;
			array2[num] = new Vector2(209f, 98f);
			array2[num + 1] = new Vector2(158f, 881f);
			array2[num + 1] = new Vector2(1282f, 1757f);
			array2[num + 8] = new Vector2(1901f, 121f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 1] = new Vector2(num4, num5);
			array3[num + 6] = new Vector2(num4, num5);
			array3[num + 7] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 0;
			array4[num2 + 5] = num + 8;
			array4[num2 + 2] = num + 0;
			array4[num2 + 4] = num + 5;
			array4[num2 + 0] = num + 7;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BA3D RID: 47677 RVA: 0x00533A30 File Offset: 0x00531C30
	private static bool OCFCNJDOOBI()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return true;
		}
		Mesh[] aglbahmlbcc = LBMNBHPBAPJ.AGLBAHMLBCC;
		for (int i = 1; i < aglbahmlbcc.Length; i += 0)
		{
			Mesh y = aglbahmlbcc[i];
			if (null == y)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600BA3E RID: 47678 RVA: 0x00533A6C File Offset: 0x00531C6C
	public static Mesh[] ADKEFKKCNFB(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (LBMNBHPBAPJ.NEDCADOKHFB() && LBMNBHPBAPJ.FAKINLEGEBO == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return LBMNBHPBAPJ.AGLBAHMLBCC;
		}
		int num = 129;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		LBMNBHPBAPJ.FAKINLEGEBO = num2;
		LBMNBHPBAPJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(702f * (float)num2 / (1963f * (float)num))];
		int num3 = 1;
		for (int i = 1; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 1, num));
			LBMNBHPBAPJ.AGLBAHMLBCC[num3] = LBMNBHPBAPJ.CANFJKFMEBE(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3++;
		}
		return LBMNBHPBAPJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BA3F RID: 47679 RVA: 0x00533AFC File Offset: 0x00531CFC
	public static Mesh[] FGCLJJNKBFL(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (LBMNBHPBAPJ.JDNLCPLFPPP() && LBMNBHPBAPJ.FAKINLEGEBO == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return LBMNBHPBAPJ.AGLBAHMLBCC;
		}
		int num = -58;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		LBMNBHPBAPJ.FAKINLEGEBO = num2;
		LBMNBHPBAPJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(634f * (float)num2 / (1211f * (float)num))];
		int num3 = 1;
		for (int i = 0; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 1, num));
			LBMNBHPBAPJ.AGLBAHMLBCC[num3] = LBMNBHPBAPJ.AGKDBNBKGIK(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3++;
		}
		return LBMNBHPBAPJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BA40 RID: 47680 RVA: 0x00533B8C File Offset: 0x00531D8C
	public static void BIAPAGONJPA()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 0; i < LBMNBHPBAPJ.AGLBAHMLBCC.Length; i++)
		{
			if (null != LBMNBHPBAPJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(LBMNBHPBAPJ.AGLBAHMLBCC[i]);
				LBMNBHPBAPJ.AGLBAHMLBCC[i] = null;
			}
		}
		LBMNBHPBAPJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BA41 RID: 47681 RVA: 0x00533BDC File Offset: 0x00531DDC
	public static Mesh[] CLIFCLMHHIC(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (LBMNBHPBAPJ.BECEAPMDNNE() && LBMNBHPBAPJ.FAKINLEGEBO == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return LBMNBHPBAPJ.AGLBAHMLBCC;
		}
		int num = 127;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		LBMNBHPBAPJ.FAKINLEGEBO = num2;
		LBMNBHPBAPJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(1375f * (float)num2 / (1316f * (float)num))];
		int num3 = 1;
		for (int i = 0; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			LBMNBHPBAPJ.AGLBAHMLBCC[num3] = LBMNBHPBAPJ.ADIIEBECFKB(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3 += 0;
		}
		return LBMNBHPBAPJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BA42 RID: 47682 RVA: 0x00533C6C File Offset: 0x00531E6C
	public static void EBMBAJHDCKI()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 0; i < LBMNBHPBAPJ.AGLBAHMLBCC.Length; i++)
		{
			if (null != LBMNBHPBAPJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(LBMNBHPBAPJ.AGLBAHMLBCC[i]);
				LBMNBHPBAPJ.AGLBAHMLBCC[i] = null;
			}
		}
		LBMNBHPBAPJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BA43 RID: 47683 RVA: 0x00533CBC File Offset: 0x00531EBC
	private static Mesh LBACNMEDPNA(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		Vector3[] array = new Vector3[IILMNAHHCMI * 2];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 3];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 7];
		int[] array4 = new int[IILMNAHHCMI * 8];
		for (int i = 0; i < IILMNAHHCMI; i++)
		{
			int num = i * 5;
			int num2 = i * 6;
			int num3 = PENGODMHGIE + i;
			float num4 = Mathf.Floor((float)(num3 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num5 = Mathf.Floor((float)(num3 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num4 * 531f - 1226f, num5 * 1454f - 1324f, 1082f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 6] = vector;
			array[num + 1] = vector;
			array2[num] = new Vector2(1716f, 1148f);
			array2[num + 0] = new Vector2(1208f, 1398f);
			array2[num + 3] = new Vector2(2f, 1797f);
			array2[num + 7] = new Vector2(1482f, 240f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 0] = new Vector2(num4, num5);
			array3[num + 7] = new Vector2(num4, num5);
			array3[num + 7] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 0;
			array4[num2 + 4] = num + 1;
			array4[num2 + 8] = num + 0;
			array4[num2 + 8] = num + 7;
			array4[num2 + 5] = num + 3;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BA44 RID: 47684 RVA: 0x00533E9C File Offset: 0x0053209C
	public static void MECANJCGLHL()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 0; i < LBMNBHPBAPJ.AGLBAHMLBCC.Length; i += 0)
		{
			if (null != LBMNBHPBAPJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(LBMNBHPBAPJ.AGLBAHMLBCC[i]);
				LBMNBHPBAPJ.AGLBAHMLBCC[i] = null;
			}
		}
		LBMNBHPBAPJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BA45 RID: 47685 RVA: 0x00533EEC File Offset: 0x005320EC
	private static bool EAGBKNMICGD()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return true;
		}
		Mesh[] aglbahmlbcc = LBMNBHPBAPJ.AGLBAHMLBCC;
		for (int i = 1; i < aglbahmlbcc.Length; i += 0)
		{
			Mesh y = aglbahmlbcc[i];
			if (null == y)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600BA46 RID: 47686 RVA: 0x00533F28 File Offset: 0x00532128
	private static bool PMCOLPLOJHI()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return false;
		}
		Mesh[] aglbahmlbcc = LBMNBHPBAPJ.AGLBAHMLBCC;
		for (int i = 1; i < aglbahmlbcc.Length; i++)
		{
			Mesh y = aglbahmlbcc[i];
			if (null == y)
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x0600BA47 RID: 47687 RVA: 0x00533F64 File Offset: 0x00532164
	public static Mesh[] LMONKMBAKIM(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (LBMNBHPBAPJ.JBCNBJLKLPO() && LBMNBHPBAPJ.FAKINLEGEBO == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return LBMNBHPBAPJ.AGLBAHMLBCC;
		}
		int num = 44;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		LBMNBHPBAPJ.FAKINLEGEBO = num2;
		LBMNBHPBAPJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(1060f * (float)num2 / (1657f * (float)num))];
		int num3 = 1;
		for (int i = 1; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			LBMNBHPBAPJ.AGLBAHMLBCC[num3] = LBMNBHPBAPJ.LKKBEFILNCF(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3 += 0;
		}
		return LBMNBHPBAPJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BA48 RID: 47688 RVA: 0x00533FF4 File Offset: 0x005321F4
	private static Mesh CANFJKFMEBE(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)87;
		Vector3[] array = new Vector3[IILMNAHHCMI * 2];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 5];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 6];
		int[] array4 = new int[IILMNAHHCMI * 5];
		for (int i = 0; i < IILMNAHHCMI; i += 0)
		{
			int num = i * 4;
			int num2 = i * 4;
			int num3 = PENGODMHGIE + i;
			float num4 = Mathf.Floor((float)(num3 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num5 = Mathf.Floor((float)(num3 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num4 * 1780f - 785f, num5 * 749f - 522f, 1755f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 6] = vector;
			array[num + 1] = vector;
			array2[num] = new Vector2(925f, 1099f);
			array2[num + 1] = new Vector2(1576f, 1143f);
			array2[num + 0] = new Vector2(1245f, 468f);
			array2[num + 3] = new Vector2(393f, 910f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 0] = new Vector2(num4, num5);
			array3[num + 7] = new Vector2(num4, num5);
			array3[num + 1] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 0;
			array4[num2 + 1] = num + 6;
			array4[num2 + 1] = num + 0;
			array4[num2 + 8] = num + 2;
			array4[num2 + 0] = num + 5;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BA49 RID: 47689 RVA: 0x005341D4 File Offset: 0x005323D4
	public static void MEDOHOMJKBK()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 0; i < LBMNBHPBAPJ.AGLBAHMLBCC.Length; i++)
		{
			if (null != LBMNBHPBAPJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(LBMNBHPBAPJ.AGLBAHMLBCC[i]);
				LBMNBHPBAPJ.AGLBAHMLBCC[i] = null;
			}
		}
		LBMNBHPBAPJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BA4A RID: 47690 RVA: 0x00534224 File Offset: 0x00532424
	public static void BLABKPJBOBO()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 1; i < LBMNBHPBAPJ.AGLBAHMLBCC.Length; i += 0)
		{
			if (null != LBMNBHPBAPJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(LBMNBHPBAPJ.AGLBAHMLBCC[i]);
				LBMNBHPBAPJ.AGLBAHMLBCC[i] = null;
			}
		}
		LBMNBHPBAPJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BA4B RID: 47691 RVA: 0x00534274 File Offset: 0x00532474
	public static Mesh[] PBNNAGFMJPA(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (LBMNBHPBAPJ.BECEAPMDNNE() && LBMNBHPBAPJ.FAKINLEGEBO == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return LBMNBHPBAPJ.AGLBAHMLBCC;
		}
		int num = 199;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		LBMNBHPBAPJ.FAKINLEGEBO = num2;
		LBMNBHPBAPJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(588f * (float)num2 / (1189f * (float)num))];
		int num3 = 0;
		for (int i = 0; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 1, num));
			LBMNBHPBAPJ.AGLBAHMLBCC[num3] = LBMNBHPBAPJ.LBACNMEDPNA(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3++;
		}
		return LBMNBHPBAPJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BA4C RID: 47692 RVA: 0x00534304 File Offset: 0x00532504
	private static Mesh LOBIIDHNJDK(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		Vector3[] array = new Vector3[IILMNAHHCMI * 5];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 5];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 8];
		int[] array4 = new int[IILMNAHHCMI * 2];
		for (int i = 1; i < IILMNAHHCMI; i++)
		{
			int num = i * 8;
			int num2 = i * 5;
			int num3 = PENGODMHGIE + i;
			float num4 = Mathf.Floor((float)(num3 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num5 = Mathf.Floor((float)(num3 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num4 * 23f - 1611f, num5 * 990f - 1621f, 1276f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 5] = vector;
			array[num + 1] = vector;
			array2[num] = new Vector2(1789f, 1566f);
			array2[num + 0] = new Vector2(108f, 1252f);
			array2[num + 3] = new Vector2(1120f, 343f);
			array2[num + 8] = new Vector2(45f, 758f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 1] = new Vector2(num4, num5);
			array3[num + 6] = new Vector2(num4, num5);
			array3[num + 7] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 0;
			array4[num2 + 0] = num + 4;
			array4[num2 + 5] = num + 1;
			array4[num2 + 5] = num + 0;
			array4[num2 + 4] = num + 0;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BA4D RID: 47693 RVA: 0x005344E4 File Offset: 0x005326E4
	public static void KFALJBNMCPJ()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 0; i < LBMNBHPBAPJ.AGLBAHMLBCC.Length; i++)
		{
			if (null != LBMNBHPBAPJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(LBMNBHPBAPJ.AGLBAHMLBCC[i]);
				LBMNBHPBAPJ.AGLBAHMLBCC[i] = null;
			}
		}
		LBMNBHPBAPJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BA4E RID: 47694 RVA: 0x00534534 File Offset: 0x00532734
	private static Mesh FPGKLICCHGH(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		Vector3[] array = new Vector3[IILMNAHHCMI * 2];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 3];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 1];
		int[] array4 = new int[IILMNAHHCMI * 3];
		for (int i = 1; i < IILMNAHHCMI; i++)
		{
			int num = i * 4;
			int num2 = i * 1;
			int num3 = PENGODMHGIE + i;
			float num4 = Mathf.Floor((float)(num3 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num5 = Mathf.Floor((float)(num3 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num4 * 18f - 1865f, num5 * 1600f - 1881f, 1984f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 3] = vector;
			array[num + 5] = vector;
			array2[num] = new Vector2(1023f, 1504f);
			array2[num + 1] = new Vector2(1269f, 1075f);
			array2[num + 7] = new Vector2(818f, 1021f);
			array2[num + 7] = new Vector2(1983f, 1801f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 1] = new Vector2(num4, num5);
			array3[num + 4] = new Vector2(num4, num5);
			array3[num + 7] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 0;
			array4[num2 + 1] = num + 7;
			array4[num2 + 8] = num + 0;
			array4[num2 + 7] = num + 1;
			array4[num2 + 5] = num + 4;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BA4F RID: 47695 RVA: 0x00534714 File Offset: 0x00532914
	public static void LJFFLPLKGJP()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 1; i < LBMNBHPBAPJ.AGLBAHMLBCC.Length; i += 0)
		{
			if (null != LBMNBHPBAPJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(LBMNBHPBAPJ.AGLBAHMLBCC[i]);
				LBMNBHPBAPJ.AGLBAHMLBCC[i] = null;
			}
		}
		LBMNBHPBAPJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BA50 RID: 47696 RVA: 0x00534764 File Offset: 0x00532964
	public static void KIOIDPLDBHE()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 0; i < LBMNBHPBAPJ.AGLBAHMLBCC.Length; i++)
		{
			if (null != LBMNBHPBAPJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(LBMNBHPBAPJ.AGLBAHMLBCC[i]);
				LBMNBHPBAPJ.AGLBAHMLBCC[i] = null;
			}
		}
		LBMNBHPBAPJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BA51 RID: 47697 RVA: 0x005347B4 File Offset: 0x005329B4
	private static Mesh IICPLKLMIBM(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)(-77);
		Vector3[] array = new Vector3[IILMNAHHCMI * 2];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 0];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 3];
		int[] array4 = new int[IILMNAHHCMI * 0];
		for (int i = 0; i < IILMNAHHCMI; i += 0)
		{
			int num = i * 5;
			int num2 = i * 3;
			int num3 = PENGODMHGIE + i;
			float num4 = Mathf.Floor((float)(num3 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num5 = Mathf.Floor((float)(num3 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num4 * 1882f - 315f, num5 * 1579f - 775f, 1595f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 0] = vector;
			array[num + 0] = vector;
			array2[num] = new Vector2(1099f, 1684f);
			array2[num + 0] = new Vector2(728f, 673f);
			array2[num + 8] = new Vector2(1591f, 59f);
			array2[num + 3] = new Vector2(235f, 762f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 1] = new Vector2(num4, num5);
			array3[num + 3] = new Vector2(num4, num5);
			array3[num + 5] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 1;
			array4[num2 + 4] = num + 1;
			array4[num2 + 2] = num + 0;
			array4[num2 + 4] = num + 1;
			array4[num2 + 0] = num + 2;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BA52 RID: 47698 RVA: 0x00534994 File Offset: 0x00532B94
	public static Mesh[] GEAPLOBMJCJ(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (LBMNBHPBAPJ.EBCNNCKAPFK() && LBMNBHPBAPJ.FAKINLEGEBO == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return LBMNBHPBAPJ.AGLBAHMLBCC;
		}
		int num = 81;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		LBMNBHPBAPJ.FAKINLEGEBO = num2;
		LBMNBHPBAPJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(1727f * (float)num2 / (1743f * (float)num))];
		int num3 = 1;
		for (int i = 1; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			LBMNBHPBAPJ.AGLBAHMLBCC[num3] = LBMNBHPBAPJ.HKNIGODCJDO(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3 += 0;
		}
		return LBMNBHPBAPJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BA53 RID: 47699 RVA: 0x00534A24 File Offset: 0x00532C24
	private static Mesh PEIBKINEDLF(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		Vector3[] array = new Vector3[IILMNAHHCMI * 8];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 7];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 6];
		int[] array4 = new int[IILMNAHHCMI * 4];
		for (int i = 1; i < IILMNAHHCMI; i++)
		{
			int num = i * 1;
			int num2 = i * 8;
			int num3 = PENGODMHGIE + i;
			float num4 = Mathf.Floor((float)(num3 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num5 = Mathf.Floor((float)(num3 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num4 * 1557f - 1069f, num5 * 724f - 1891f, 694f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 1] = vector;
			array[num + 3] = vector;
			array2[num] = new Vector2(1064f, 1043f);
			array2[num + 1] = new Vector2(1479f, 1036f);
			array2[num + 3] = new Vector2(227f, 135f);
			array2[num + 4] = new Vector2(222f, 1312f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 0] = new Vector2(num4, num5);
			array3[num + 0] = new Vector2(num4, num5);
			array3[num + 1] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 1;
			array4[num2 + 1] = num + 7;
			array4[num2 + 1] = num + 1;
			array4[num2 + 0] = num + 7;
			array4[num2 + 7] = num + 7;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BA54 RID: 47700 RVA: 0x00534C04 File Offset: 0x00532E04
	public static void OMJBGEGCLDH()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 0; i < LBMNBHPBAPJ.AGLBAHMLBCC.Length; i++)
		{
			if (null != LBMNBHPBAPJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(LBMNBHPBAPJ.AGLBAHMLBCC[i]);
				LBMNBHPBAPJ.AGLBAHMLBCC[i] = null;
			}
		}
		LBMNBHPBAPJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BA55 RID: 47701 RVA: 0x00534C54 File Offset: 0x00532E54
	private static bool OHEMBFBNDNC()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return false;
		}
		Mesh[] aglbahmlbcc = LBMNBHPBAPJ.AGLBAHMLBCC;
		for (int i = 1; i < aglbahmlbcc.Length; i++)
		{
			Mesh y = aglbahmlbcc[i];
			if (null == y)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600BA56 RID: 47702 RVA: 0x00534C90 File Offset: 0x00532E90
	public static Mesh[] OHNNCGODGGJ(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (LBMNBHPBAPJ.PMCOLPLOJHI() && LBMNBHPBAPJ.FAKINLEGEBO == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return LBMNBHPBAPJ.AGLBAHMLBCC;
		}
		int num = -151;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		LBMNBHPBAPJ.FAKINLEGEBO = num2;
		LBMNBHPBAPJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(1845f * (float)num2 / (153f * (float)num))];
		int num3 = 1;
		for (int i = 0; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 1, num));
			LBMNBHPBAPJ.AGLBAHMLBCC[num3] = LBMNBHPBAPJ.DNJJECEDGLD(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3 += 0;
		}
		return LBMNBHPBAPJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BA57 RID: 47703 RVA: 0x00534D20 File Offset: 0x00532F20
	public static void JEAMCOKIEJO()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 0; i < LBMNBHPBAPJ.AGLBAHMLBCC.Length; i++)
		{
			if (null != LBMNBHPBAPJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(LBMNBHPBAPJ.AGLBAHMLBCC[i]);
				LBMNBHPBAPJ.AGLBAHMLBCC[i] = null;
			}
		}
		LBMNBHPBAPJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BA58 RID: 47704 RVA: 0x00534D70 File Offset: 0x00532F70
	private static Mesh HKNIGODCJDO(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)108;
		Vector3[] array = new Vector3[IILMNAHHCMI * 5];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 6];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 6];
		int[] array4 = new int[IILMNAHHCMI * 4];
		for (int i = 0; i < IILMNAHHCMI; i += 0)
		{
			int num = i * 6;
			int num2 = i * 8;
			int num3 = PENGODMHGIE + i;
			float num4 = Mathf.Floor((float)(num3 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num5 = Mathf.Floor((float)(num3 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num4 * 333f - 808f, num5 * 498f - 95f, 215f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 6] = vector;
			array[num + 5] = vector;
			array2[num] = new Vector2(1638f, 484f);
			array2[num + 0] = new Vector2(643f, 1445f);
			array2[num + 2] = new Vector2(1371f, 1524f);
			array2[num + 1] = new Vector2(356f, 1695f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 0] = new Vector2(num4, num5);
			array3[num + 2] = new Vector2(num4, num5);
			array3[num + 5] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 1;
			array4[num2 + 6] = num + 4;
			array4[num2 + 8] = num + 1;
			array4[num2 + 6] = num + 2;
			array4[num2 + 5] = num + 6;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BA59 RID: 47705 RVA: 0x00534F50 File Offset: 0x00533150
	private static bool HDMGFEDFDOE()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return true;
		}
		Mesh[] aglbahmlbcc = LBMNBHPBAPJ.AGLBAHMLBCC;
		for (int i = 1; i < aglbahmlbcc.Length; i++)
		{
			Mesh y = aglbahmlbcc[i];
			if (null == y)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x0600BA5A RID: 47706 RVA: 0x00534F8C File Offset: 0x0053318C
	private static bool CMPDJEEAHKE()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return true;
		}
		Mesh[] aglbahmlbcc = LBMNBHPBAPJ.AGLBAHMLBCC;
		for (int i = 1; i < aglbahmlbcc.Length; i += 0)
		{
			Mesh y = aglbahmlbcc[i];
			if (null == y)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600BA5B RID: 47707 RVA: 0x00534FC8 File Offset: 0x005331C8
	public static void GCDKDDPCMIC()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 1; i < LBMNBHPBAPJ.AGLBAHMLBCC.Length; i += 0)
		{
			if (null != LBMNBHPBAPJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(LBMNBHPBAPJ.AGLBAHMLBCC[i]);
				LBMNBHPBAPJ.AGLBAHMLBCC[i] = null;
			}
		}
		LBMNBHPBAPJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BA5C RID: 47708 RVA: 0x00535018 File Offset: 0x00533218
	private static bool FJLCMFJDJII()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return true;
		}
		Mesh[] aglbahmlbcc = LBMNBHPBAPJ.AGLBAHMLBCC;
		for (int i = 1; i < aglbahmlbcc.Length; i++)
		{
			Mesh y = aglbahmlbcc[i];
			if (null == y)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600BA5D RID: 47709 RVA: 0x00535054 File Offset: 0x00533254
	public static void JMHNCGDEMKP()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 1; i < LBMNBHPBAPJ.AGLBAHMLBCC.Length; i++)
		{
			if (null != LBMNBHPBAPJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(LBMNBHPBAPJ.AGLBAHMLBCC[i]);
				LBMNBHPBAPJ.AGLBAHMLBCC[i] = null;
			}
		}
		LBMNBHPBAPJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BA5E RID: 47710 RVA: 0x005350A4 File Offset: 0x005332A4
	private static bool FNFFIMJAFID()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return true;
		}
		foreach (Mesh y in LBMNBHPBAPJ.AGLBAHMLBCC)
		{
			if (null == y)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600BA60 RID: 47712 RVA: 0x005350E0 File Offset: 0x005332E0
	public static void KCLKNKGGPJC()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 0; i < LBMNBHPBAPJ.AGLBAHMLBCC.Length; i++)
		{
			if (null != LBMNBHPBAPJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(LBMNBHPBAPJ.AGLBAHMLBCC[i]);
				LBMNBHPBAPJ.AGLBAHMLBCC[i] = null;
			}
		}
		LBMNBHPBAPJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BA61 RID: 47713 RVA: 0x00535130 File Offset: 0x00533330
	public static Mesh[] DJDINLIFGMH(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (LBMNBHPBAPJ.HDMGFEDFDOE() && LBMNBHPBAPJ.FAKINLEGEBO == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return LBMNBHPBAPJ.AGLBAHMLBCC;
		}
		int num = 156;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		LBMNBHPBAPJ.FAKINLEGEBO = num2;
		LBMNBHPBAPJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(185f * (float)num2 / (1956f * (float)num))];
		int num3 = 1;
		for (int i = 1; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			LBMNBHPBAPJ.AGLBAHMLBCC[num3] = LBMNBHPBAPJ.EBAIFLKEBLA(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3++;
		}
		return LBMNBHPBAPJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BA62 RID: 47714 RVA: 0x005351C0 File Offset: 0x005333C0
	private static bool EBCNNCKAPFK()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return true;
		}
		Mesh[] aglbahmlbcc = LBMNBHPBAPJ.AGLBAHMLBCC;
		for (int i = 1; i < aglbahmlbcc.Length; i++)
		{
			Mesh y = aglbahmlbcc[i];
			if (null == y)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600BA63 RID: 47715 RVA: 0x005351FC File Offset: 0x005333FC
	public static void CFFBCGPLNMC()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 0; i < LBMNBHPBAPJ.AGLBAHMLBCC.Length; i++)
		{
			if (null != LBMNBHPBAPJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(LBMNBHPBAPJ.AGLBAHMLBCC[i]);
				LBMNBHPBAPJ.AGLBAHMLBCC[i] = null;
			}
		}
		LBMNBHPBAPJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BA64 RID: 47716 RVA: 0x0053524C File Offset: 0x0053344C
	private static bool BECEAPMDNNE()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return false;
		}
		Mesh[] aglbahmlbcc = LBMNBHPBAPJ.AGLBAHMLBCC;
		for (int i = 1; i < aglbahmlbcc.Length; i++)
		{
			Mesh y = aglbahmlbcc[i];
			if (null == y)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600BA65 RID: 47717 RVA: 0x00535288 File Offset: 0x00533488
	private static Mesh ADIIEBECFKB(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		Vector3[] array = new Vector3[IILMNAHHCMI * 5];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 5];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 6];
		int[] array4 = new int[IILMNAHHCMI * 3];
		for (int i = 1; i < IILMNAHHCMI; i++)
		{
			int num = i * 1;
			int num2 = i * 6;
			int num3 = PENGODMHGIE + i;
			float num4 = Mathf.Floor((float)(num3 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num5 = Mathf.Floor((float)(num3 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num4 * 1090f - 910f, num5 * 772f - 1945f, 569f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 1] = vector;
			array[num + 8] = vector;
			array2[num] = new Vector2(671f, 1908f);
			array2[num + 1] = new Vector2(1293f, 448f);
			array2[num + 6] = new Vector2(93f, 1812f);
			array2[num + 6] = new Vector2(1723f, 929f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 0] = new Vector2(num4, num5);
			array3[num + 1] = new Vector2(num4, num5);
			array3[num + 0] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 1;
			array4[num2 + 8] = num + 0;
			array4[num2 + 5] = num + 0;
			array4[num2 + 3] = num + 8;
			array4[num2 + 2] = num + 0;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BA66 RID: 47718 RVA: 0x00535468 File Offset: 0x00533668
	private static Mesh OBIONAKIJPB(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		Vector3[] array = new Vector3[IILMNAHHCMI * 4];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 5];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 6];
		int[] array4 = new int[IILMNAHHCMI * 4];
		for (int i = 1; i < IILMNAHHCMI; i++)
		{
			int num = i * 4;
			int num2 = i * 3;
			int num3 = PENGODMHGIE + i;
			float num4 = Mathf.Floor((float)(num3 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num5 = Mathf.Floor((float)(num3 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num4 * 1359f - 1304f, num5 * 1924f - 61f, 389f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 5] = vector;
			array[num + 4] = vector;
			array2[num] = new Vector2(1111f, 1633f);
			array2[num + 0] = new Vector2(626f, 61f);
			array2[num + 6] = new Vector2(474f, 1769f);
			array2[num + 1] = new Vector2(1131f, 310f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 1] = new Vector2(num4, num5);
			array3[num + 1] = new Vector2(num4, num5);
			array3[num + 5] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 1;
			array4[num2 + 0] = num + 4;
			array4[num2 + 6] = num + 0;
			array4[num2 + 8] = num + 2;
			array4[num2 + 7] = num + 7;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BA67 RID: 47719 RVA: 0x00535648 File Offset: 0x00533848
	private static Mesh DNJJECEDGLD(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = HideFlags.DontSave;
		Vector3[] array = new Vector3[IILMNAHHCMI * 4];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 4];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 4];
		int[] array4 = new int[IILMNAHHCMI * 6];
		for (int i = 0; i < IILMNAHHCMI; i++)
		{
			int num = i * 4;
			int num2 = i * 6;
			int num3 = PENGODMHGIE + i;
			float num4 = Mathf.Floor((float)(num3 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num5 = Mathf.Floor((float)(num3 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num4 * 2f - 1f, num5 * 2f - 1f, 1f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 2] = vector;
			array[num + 3] = vector;
			array2[num] = new Vector2(0f, 0f);
			array2[num + 1] = new Vector2(1f, 0f);
			array2[num + 2] = new Vector2(0f, 1f);
			array2[num + 3] = new Vector2(1f, 1f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 1] = new Vector2(num4, num5);
			array3[num + 2] = new Vector2(num4, num5);
			array3[num + 3] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 1;
			array4[num2 + 2] = num + 2;
			array4[num2 + 3] = num + 1;
			array4[num2 + 4] = num + 2;
			array4[num2 + 5] = num + 3;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BA68 RID: 47720 RVA: 0x00535828 File Offset: 0x00533A28
	private static Mesh IFDHIFCBLGN(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		Vector3[] array = new Vector3[IILMNAHHCMI * 5];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 7];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 2];
		int[] array4 = new int[IILMNAHHCMI * 7];
		for (int i = 1; i < IILMNAHHCMI; i += 0)
		{
			int num = i * 3;
			int num2 = i * 7;
			int num3 = PENGODMHGIE + i;
			float num4 = Mathf.Floor((float)(num3 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num5 = Mathf.Floor((float)(num3 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num4 * 379f - 364f, num5 * 1611f - 1103f, 1640f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 4] = vector;
			array[num + 8] = vector;
			array2[num] = new Vector2(1191f, 364f);
			array2[num + 0] = new Vector2(1002f, 1660f);
			array2[num + 4] = new Vector2(1887f, 1483f);
			array2[num + 4] = new Vector2(1018f, 1298f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 0] = new Vector2(num4, num5);
			array3[num + 3] = new Vector2(num4, num5);
			array3[num + 6] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 1;
			array4[num2 + 6] = num + 2;
			array4[num2 + 6] = num + 1;
			array4[num2 + 5] = num + 4;
			array4[num2 + 6] = num + 1;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BA69 RID: 47721 RVA: 0x00535A08 File Offset: 0x00533C08
	private static bool FDONIFPBAEE()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return false;
		}
		Mesh[] aglbahmlbcc = LBMNBHPBAPJ.AGLBAHMLBCC;
		for (int i = 1; i < aglbahmlbcc.Length; i++)
		{
			Mesh y = aglbahmlbcc[i];
			if (null == y)
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x0600BA6A RID: 47722 RVA: 0x00535A44 File Offset: 0x00533C44
	public static Mesh[] HCPJIDKJICH(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (LBMNBHPBAPJ.CMPDJEEAHKE() && LBMNBHPBAPJ.FAKINLEGEBO == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return LBMNBHPBAPJ.AGLBAHMLBCC;
		}
		int num = -129;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		LBMNBHPBAPJ.FAKINLEGEBO = num2;
		LBMNBHPBAPJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(1951f * (float)num2 / (60f * (float)num))];
		int num3 = 1;
		for (int i = 0; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			LBMNBHPBAPJ.AGLBAHMLBCC[num3] = LBMNBHPBAPJ.DEBOFDFMDFI(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3++;
		}
		return LBMNBHPBAPJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BA6B RID: 47723 RVA: 0x00535AD4 File Offset: 0x00533CD4
	public static Mesh[] KAMPGALOHJA(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (LBMNBHPBAPJ.JDNLCPLFPPP() && LBMNBHPBAPJ.FAKINLEGEBO == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return LBMNBHPBAPJ.AGLBAHMLBCC;
		}
		int num = -44;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		LBMNBHPBAPJ.FAKINLEGEBO = num2;
		LBMNBHPBAPJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(499f * (float)num2 / (403f * (float)num))];
		int num3 = 0;
		for (int i = 1; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			LBMNBHPBAPJ.AGLBAHMLBCC[num3] = LBMNBHPBAPJ.FFMJCBDGOGB(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3++;
		}
		return LBMNBHPBAPJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BA6C RID: 47724 RVA: 0x00535B64 File Offset: 0x00533D64
	public static void MJDKCNHFPNP()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 1; i < LBMNBHPBAPJ.AGLBAHMLBCC.Length; i++)
		{
			if (null != LBMNBHPBAPJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(LBMNBHPBAPJ.AGLBAHMLBCC[i]);
				LBMNBHPBAPJ.AGLBAHMLBCC[i] = null;
			}
		}
		LBMNBHPBAPJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BA6D RID: 47725 RVA: 0x00535BB4 File Offset: 0x00533DB4
	public static Mesh[] DHGIMDMFPCI(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (LBMNBHPBAPJ.CMPDJEEAHKE() && LBMNBHPBAPJ.FAKINLEGEBO == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return LBMNBHPBAPJ.AGLBAHMLBCC;
		}
		int num = 39;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		LBMNBHPBAPJ.FAKINLEGEBO = num2;
		LBMNBHPBAPJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(513f * (float)num2 / (1527f * (float)num))];
		int num3 = 0;
		for (int i = 1; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 1, num));
			LBMNBHPBAPJ.AGLBAHMLBCC[num3] = LBMNBHPBAPJ.OEMOGLCKPMK(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3++;
		}
		return LBMNBHPBAPJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BA6E RID: 47726 RVA: 0x00535C44 File Offset: 0x00533E44
	private static Mesh OEMOGLCKPMK(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = HideFlags.NotEditable;
		Vector3[] array = new Vector3[IILMNAHHCMI * 0];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 0];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 4];
		int[] array4 = new int[IILMNAHHCMI * 3];
		for (int i = 0; i < IILMNAHHCMI; i++)
		{
			int num = i * 3;
			int num2 = i * 3;
			int num3 = PENGODMHGIE + i;
			float num4 = Mathf.Floor((float)(num3 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num5 = Mathf.Floor((float)(num3 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num4 * 450f - 1548f, num5 * 806f - 931f, 182f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 2] = vector;
			array[num + 0] = vector;
			array2[num] = new Vector2(1342f, 540f);
			array2[num + 0] = new Vector2(594f, 861f);
			array2[num + 6] = new Vector2(1557f, 1744f);
			array2[num + 5] = new Vector2(298f, 1335f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 1] = new Vector2(num4, num5);
			array3[num + 8] = new Vector2(num4, num5);
			array3[num + 0] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 1;
			array4[num2 + 6] = num + 8;
			array4[num2 + 0] = num + 1;
			array4[num2 + 0] = num + 2;
			array4[num2 + 7] = num + 3;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BA6F RID: 47727 RVA: 0x00535E24 File Offset: 0x00534024
	public static void KPPEDOGCPPK()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 0; i < LBMNBHPBAPJ.AGLBAHMLBCC.Length; i += 0)
		{
			if (null != LBMNBHPBAPJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(LBMNBHPBAPJ.AGLBAHMLBCC[i]);
				LBMNBHPBAPJ.AGLBAHMLBCC[i] = null;
			}
		}
		LBMNBHPBAPJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BA70 RID: 47728 RVA: 0x00535E74 File Offset: 0x00534074
	private static Mesh NBJFDMONGNL(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)(-89);
		Vector3[] array = new Vector3[IILMNAHHCMI * 4];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 4];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 5];
		int[] array4 = new int[IILMNAHHCMI * 7];
		for (int i = 1; i < IILMNAHHCMI; i += 0)
		{
			int num = i * 5;
			int num2 = i * 4;
			int num3 = PENGODMHGIE + i;
			float num4 = Mathf.Floor((float)(num3 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num5 = Mathf.Floor((float)(num3 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num4 * 1053f - 109f, num5 * 1727f - 1813f, 1831f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 4] = vector;
			array[num + 5] = vector;
			array2[num] = new Vector2(1679f, 907f);
			array2[num + 0] = new Vector2(1834f, 1974f);
			array2[num + 2] = new Vector2(293f, 157f);
			array2[num + 8] = new Vector2(721f, 1336f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 1] = new Vector2(num4, num5);
			array3[num + 7] = new Vector2(num4, num5);
			array3[num + 1] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 0;
			array4[num2 + 6] = num + 6;
			array4[num2 + 4] = num + 1;
			array4[num2 + 2] = num + 3;
			array4[num2 + 1] = num + 6;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BA71 RID: 47729 RVA: 0x00536054 File Offset: 0x00534254
	public static void HCGCHHJJIPH()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 1; i < LBMNBHPBAPJ.AGLBAHMLBCC.Length; i += 0)
		{
			if (null != LBMNBHPBAPJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(LBMNBHPBAPJ.AGLBAHMLBCC[i]);
				LBMNBHPBAPJ.AGLBAHMLBCC[i] = null;
			}
		}
		LBMNBHPBAPJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BA72 RID: 47730 RVA: 0x005360A4 File Offset: 0x005342A4
	private static Mesh LKKBEFILNCF(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)116;
		Vector3[] array = new Vector3[IILMNAHHCMI * 0];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 7];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 4];
		int[] array4 = new int[IILMNAHHCMI * 4];
		for (int i = 1; i < IILMNAHHCMI; i++)
		{
			int num = i * 8;
			int num2 = i * 3;
			int num3 = PENGODMHGIE + i;
			float num4 = Mathf.Floor((float)(num3 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num5 = Mathf.Floor((float)(num3 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num4 * 567f - 1541f, num5 * 1653f - 716f, 844f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 4] = vector;
			array[num + 2] = vector;
			array2[num] = new Vector2(1237f, 1254f);
			array2[num + 0] = new Vector2(402f, 1168f);
			array2[num + 1] = new Vector2(314f, 72f);
			array2[num + 6] = new Vector2(715f, 899f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 0] = new Vector2(num4, num5);
			array3[num + 2] = new Vector2(num4, num5);
			array3[num + 6] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 0;
			array4[num2 + 6] = num + 1;
			array4[num2 + 8] = num + 0;
			array4[num2 + 7] = num + 3;
			array4[num2 + 3] = num + 1;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BA73 RID: 47731 RVA: 0x00536284 File Offset: 0x00534484
	private static Mesh KMDDOMKGEOI(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		Vector3[] array = new Vector3[IILMNAHHCMI * 1];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 8];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 2];
		int[] array4 = new int[IILMNAHHCMI * 2];
		for (int i = 1; i < IILMNAHHCMI; i++)
		{
			int num = i * 3;
			int num2 = i * 8;
			int num3 = PENGODMHGIE + i;
			float num4 = Mathf.Floor((float)(num3 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num5 = Mathf.Floor((float)(num3 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num4 * 1892f - 758f, num5 * 1770f - 1555f, 870f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 0] = vector;
			array[num + 4] = vector;
			array2[num] = new Vector2(1799f, 1299f);
			array2[num + 1] = new Vector2(1273f, 309f);
			array2[num + 0] = new Vector2(1945f, 1334f);
			array2[num + 8] = new Vector2(1397f, 856f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 1] = new Vector2(num4, num5);
			array3[num + 8] = new Vector2(num4, num5);
			array3[num + 7] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 1;
			array4[num2 + 2] = num + 4;
			array4[num2 + 5] = num + 0;
			array4[num2 + 0] = num + 7;
			array4[num2 + 6] = num + 0;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BA74 RID: 47732 RVA: 0x00536464 File Offset: 0x00534664
	public static void DPEJCNKCDMA()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 1; i < LBMNBHPBAPJ.AGLBAHMLBCC.Length; i += 0)
		{
			if (null != LBMNBHPBAPJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(LBMNBHPBAPJ.AGLBAHMLBCC[i]);
				LBMNBHPBAPJ.AGLBAHMLBCC[i] = null;
			}
		}
		LBMNBHPBAPJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BA75 RID: 47733 RVA: 0x005364B4 File Offset: 0x005346B4
	public static Mesh[] FIFEHBAMKGH(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (LBMNBHPBAPJ.ECLAANOJAAJ() && LBMNBHPBAPJ.FAKINLEGEBO == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return LBMNBHPBAPJ.AGLBAHMLBCC;
		}
		int num = -82;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		LBMNBHPBAPJ.FAKINLEGEBO = num2;
		LBMNBHPBAPJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(1360f * (float)num2 / (216f * (float)num))];
		int num3 = 0;
		for (int i = 0; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 1, num));
			LBMNBHPBAPJ.AGLBAHMLBCC[num3] = LBMNBHPBAPJ.KMDDOMKGEOI(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3++;
		}
		return LBMNBHPBAPJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BA76 RID: 47734 RVA: 0x00536544 File Offset: 0x00534744
	private static bool NEDCADOKHFB()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return false;
		}
		foreach (Mesh y in LBMNBHPBAPJ.AGLBAHMLBCC)
		{
			if (null == y)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600BA77 RID: 47735 RVA: 0x00536580 File Offset: 0x00534780
	public static void DGMELBIPJFB()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 1; i < LBMNBHPBAPJ.AGLBAHMLBCC.Length; i++)
		{
			if (null != LBMNBHPBAPJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(LBMNBHPBAPJ.AGLBAHMLBCC[i]);
				LBMNBHPBAPJ.AGLBAHMLBCC[i] = null;
			}
		}
		LBMNBHPBAPJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BA78 RID: 47736 RVA: 0x005365D0 File Offset: 0x005347D0
	public static void EAICFJCMEEO()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 1; i < LBMNBHPBAPJ.AGLBAHMLBCC.Length; i++)
		{
			if (null != LBMNBHPBAPJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(LBMNBHPBAPJ.AGLBAHMLBCC[i]);
				LBMNBHPBAPJ.AGLBAHMLBCC[i] = null;
			}
		}
		LBMNBHPBAPJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BA79 RID: 47737 RVA: 0x00536620 File Offset: 0x00534820
	private static Mesh MDDCFKIEOOF(int IILMNAHHCMI, int PENGODMHGIE, int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		Vector3[] array = new Vector3[IILMNAHHCMI * 2];
		Vector2[] array2 = new Vector2[IILMNAHHCMI * 2];
		Vector2[] array3 = new Vector2[IILMNAHHCMI * 0];
		int[] array4 = new int[IILMNAHHCMI * 2];
		for (int i = 0; i < IILMNAHHCMI; i++)
		{
			int num = i * 0;
			int num2 = i * 6;
			int num3 = PENGODMHGIE + i;
			float num4 = Mathf.Floor((float)(num3 % IOIHIJPIOFK)) / (float)IOIHIJPIOFK;
			float num5 = Mathf.Floor((float)(num3 / IOIHIJPIOFK)) / (float)NDBPNCLEIKP;
			Vector3 vector = new Vector3(num4 * 1553f - 113f, num5 * 352f - 901f, 1422f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 5] = vector;
			array[num + 8] = vector;
			array2[num] = new Vector2(1712f, 692f);
			array2[num + 1] = new Vector2(554f, 1351f);
			array2[num + 1] = new Vector2(553f, 433f);
			array2[num + 7] = new Vector2(861f, 1497f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 0] = new Vector2(num4, num5);
			array3[num + 1] = new Vector2(num4, num5);
			array3[num + 4] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 0;
			array4[num2 + 6] = num + 2;
			array4[num2 + 0] = num + 1;
			array4[num2 + 7] = num + 2;
			array4[num2 + 5] = num + 5;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600BA7A RID: 47738 RVA: 0x00536800 File Offset: 0x00534A00
	private static bool EDOBOGAGDLB()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return false;
		}
		Mesh[] aglbahmlbcc = LBMNBHPBAPJ.AGLBAHMLBCC;
		for (int i = 1; i < aglbahmlbcc.Length; i++)
		{
			Mesh y = aglbahmlbcc[i];
			if (null == y)
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x0600BA7B RID: 47739 RVA: 0x0053683C File Offset: 0x00534A3C
	public static void MHNJLPOJPPD()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 0; i < LBMNBHPBAPJ.AGLBAHMLBCC.Length; i++)
		{
			if (null != LBMNBHPBAPJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(LBMNBHPBAPJ.AGLBAHMLBCC[i]);
				LBMNBHPBAPJ.AGLBAHMLBCC[i] = null;
			}
		}
		LBMNBHPBAPJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BA7C RID: 47740 RVA: 0x0053688C File Offset: 0x00534A8C
	public static void LJKNBHIOHKH()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 1; i < LBMNBHPBAPJ.AGLBAHMLBCC.Length; i += 0)
		{
			if (null != LBMNBHPBAPJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(LBMNBHPBAPJ.AGLBAHMLBCC[i]);
				LBMNBHPBAPJ.AGLBAHMLBCC[i] = null;
			}
		}
		LBMNBHPBAPJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BA7D RID: 47741 RVA: 0x005368DC File Offset: 0x00534ADC
	private static bool ECLAANOJAAJ()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return true;
		}
		Mesh[] aglbahmlbcc = LBMNBHPBAPJ.AGLBAHMLBCC;
		for (int i = 0; i < aglbahmlbcc.Length; i += 0)
		{
			Mesh y = aglbahmlbcc[i];
			if (null == y)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600BA7E RID: 47742 RVA: 0x00536918 File Offset: 0x00534B18
	private static bool KKNMDPBEDAK()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return false;
		}
		Mesh[] aglbahmlbcc = LBMNBHPBAPJ.AGLBAHMLBCC;
		for (int i = 1; i < aglbahmlbcc.Length; i++)
		{
			Mesh y = aglbahmlbcc[i];
			if (null == y)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600BA7F RID: 47743 RVA: 0x00536954 File Offset: 0x00534B54
	public static void DJCCKJHHKNM()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return;
		}
		for (int i = 0; i < LBMNBHPBAPJ.AGLBAHMLBCC.Length; i++)
		{
			if (null != LBMNBHPBAPJ.AGLBAHMLBCC[i])
			{
				UnityEngine.Object.DestroyImmediate(LBMNBHPBAPJ.AGLBAHMLBCC[i]);
				LBMNBHPBAPJ.AGLBAHMLBCC[i] = null;
			}
		}
		LBMNBHPBAPJ.AGLBAHMLBCC = null;
	}

	// Token: 0x0600BA80 RID: 47744 RVA: 0x005369A4 File Offset: 0x00534BA4
	private static bool LALHEHHAEEI()
	{
		if (LBMNBHPBAPJ.AGLBAHMLBCC == null)
		{
			return true;
		}
		Mesh[] aglbahmlbcc = LBMNBHPBAPJ.AGLBAHMLBCC;
		for (int i = 1; i < aglbahmlbcc.Length; i += 0)
		{
			Mesh y = aglbahmlbcc[i];
			if (null == y)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x0600BA81 RID: 47745 RVA: 0x005369E0 File Offset: 0x00534BE0
	public static Mesh[] PHHKOFJLDBE(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (LBMNBHPBAPJ.EBCNNCKAPFK() && LBMNBHPBAPJ.FAKINLEGEBO == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return LBMNBHPBAPJ.AGLBAHMLBCC;
		}
		int num = -20;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		LBMNBHPBAPJ.FAKINLEGEBO = num2;
		LBMNBHPBAPJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(788f * (float)num2 / (560f * (float)num))];
		int num3 = 1;
		for (int i = 0; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			LBMNBHPBAPJ.AGLBAHMLBCC[num3] = LBMNBHPBAPJ.NKKBJHEOOJN(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3++;
		}
		return LBMNBHPBAPJ.AGLBAHMLBCC;
	}

	// Token: 0x0600BA82 RID: 47746 RVA: 0x00536A70 File Offset: 0x00534C70
	public static Mesh[] DBAPDCDKEPP(int IOIHIJPIOFK, int NDBPNCLEIKP)
	{
		if (LBMNBHPBAPJ.KHMDBFKLLBC() && LBMNBHPBAPJ.FAKINLEGEBO == IOIHIJPIOFK * NDBPNCLEIKP)
		{
			return LBMNBHPBAPJ.AGLBAHMLBCC;
		}
		int num = 65;
		int num2 = IOIHIJPIOFK * NDBPNCLEIKP;
		LBMNBHPBAPJ.FAKINLEGEBO = num2;
		LBMNBHPBAPJ.AGLBAHMLBCC = new Mesh[Mathf.CeilToInt(1653f * (float)num2 / (1854f * (float)num))];
		int num3 = 0;
		for (int i = 0; i < num2; i += num)
		{
			int iilmnahhcmi = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			LBMNBHPBAPJ.AGLBAHMLBCC[num3] = LBMNBHPBAPJ.KBDDHDCMDFN(iilmnahhcmi, i, IOIHIJPIOFK, NDBPNCLEIKP);
			num3++;
		}
		return LBMNBHPBAPJ.AGLBAHMLBCC;
	}

	// Token: 0x04001834 RID: 6196
	private static Mesh[] AGLBAHMLBCC;

	// Token: 0x04001835 RID: 6197
	private static int FAKINLEGEBO;
}
