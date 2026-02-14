using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;

// Token: 0x020004FF RID: 1279
public static class PJPPHDDFAHP
{
	// Token: 0x060111F0 RID: 70128 RVA: 0x007A0E82 File Offset: 0x0079F082
	public static Mesh FDKBNGEKNCC(Mesh BNDNKLBIJJF)
	{
		Mesh mesh = new Mesh();
		PJPPHDDFAHP.MMPGGCGDBNI(mesh, BNDNKLBIJJF);
		return mesh;
	}

	// Token: 0x060111F1 RID: 70129 RVA: 0x007A0E90 File Offset: 0x0079F090
	public static void MMPGGCGDBNI(Mesh OLFKAHHACBC, Mesh BNDNKLBIJJF)
	{
		OLFKAHHACBC.Clear();
		OLFKAHHACBC.vertices = BNDNKLBIJJF.vertices;
		List<Vector4> uvs = new List<Vector4>();
		BNDNKLBIJJF.GetUVs(0, uvs);
		OLFKAHHACBC.SetUVs(0, uvs);
		BNDNKLBIJJF.GetUVs(1, uvs);
		OLFKAHHACBC.SetUVs(1, uvs);
		BNDNKLBIJJF.GetUVs(2, uvs);
		OLFKAHHACBC.SetUVs(2, uvs);
		BNDNKLBIJJF.GetUVs(3, uvs);
		OLFKAHHACBC.SetUVs(3, uvs);
		OLFKAHHACBC.normals = BNDNKLBIJJF.normals;
		OLFKAHHACBC.tangents = BNDNKLBIJJF.tangents;
		OLFKAHHACBC.boneWeights = BNDNKLBIJJF.boneWeights;
		OLFKAHHACBC.colors = BNDNKLBIJJF.colors;
		OLFKAHHACBC.colors32 = BNDNKLBIJJF.colors32;
		OLFKAHHACBC.bindposes = BNDNKLBIJJF.bindposes;
		OLFKAHHACBC.subMeshCount = BNDNKLBIJJF.subMeshCount;
		for (int i = 0; i < BNDNKLBIJJF.subMeshCount; i++)
		{
			OLFKAHHACBC.SetIndices(BNDNKLBIJJF.GetIndices(i), BNDNKLBIJJF.GetTopology(i), i);
		}
		OLFKAHHACBC.name = KMAJFAMPPMG.HEBLJJLBDJM("z", BNDNKLBIJJF.name);
	}

	// Token: 0x060111F2 RID: 70130 RVA: 0x007A0F88 File Offset: 0x0079F188
	public static Mesh LNDNHOBOFEE(LFMCCNHNKCJ BNDNKLBIJJF)
	{
		Mesh mesh = new Mesh();
		mesh.name = "Overlay Mesh: " + BNDNKLBIJJF.BNIHFBMEPAB;
		mesh.vertices = BNDNKLBIJJF.OKLLKJPCJLK;
		mesh.normals = BNDNKLBIJJF.DKGOOCCIOAH;
		mesh.colors = KMAJFAMPPMG.DBBLNCMBENK<Color>(new Color(0f, 0f, 0f, 0f), mesh.vertexCount);
		mesh.subMeshCount = BNDNKLBIJJF.FFDLDPAIKEE;
		for (int i = 0; i < BNDNKLBIJJF.FFDLDPAIKEE; i++)
		{
			if (BNDNKLBIJJF.KFAJDEPOFKM(i) == MeshTopology.Triangles)
			{
				int[] array = BNDNKLBIJJF.CIIMNMCIBNC(i);
				int[] array2 = new int[array.Length * 2];
				int num = 0;
				for (int j = 0; j < array.Length; j += 3)
				{
					array2[num++] = array[j];
					array2[num++] = array[j + 1];
					array2[num++] = array[j + 1];
					array2[num++] = array[j + 2];
					array2[num++] = array[j + 2];
					array2[num++] = array[j];
				}
				mesh.SetIndices(array2, MeshTopology.Lines, i);
			}
			else
			{
				mesh.SetIndices(BNDNKLBIJJF.CIIMNMCIBNC(i), BNDNKLBIJJF.KFAJDEPOFKM(i), i);
			}
		}
		return mesh;
	}

	// Token: 0x060111F3 RID: 70131 RVA: 0x007A10C4 File Offset: 0x0079F2C4
	public static Mesh JCLNNOGHIAC(LFMCCNHNKCJ BNDNKLBIJJF, List<List<int>> NJEHCCKLOLC)
	{
		int num = Math.Min(16383, NJEHCCKLOLC.Count<List<int>>());
		Vector3[] array = new Vector3[num * 4];
		Vector2[] array2 = new Vector2[num * 4];
		Vector2[] array3 = new Vector2[num * 4];
		Color[] array4 = new Color[num * 4];
		int[] array5 = new int[num * 6];
		int num2 = 0;
		int num3 = 0;
		Vector3 up = Vector3.up;
		Vector3 right = Vector3.right;
		Vector3[] okllkjpcjlk = BNDNKLBIJJF.OKLLKJPCJLK;
		for (int i = 0; i < num; i++)
		{
			int num4 = NJEHCCKLOLC[i][0];
			array[num3] = okllkjpcjlk[num4];
			array[num3 + 1] = okllkjpcjlk[num4];
			array[num3 + 2] = okllkjpcjlk[num4];
			array[num3 + 3] = okllkjpcjlk[num4];
			array2[num3] = Vector3.zero;
			array2[num3 + 1] = Vector3.right;
			array2[num3 + 2] = Vector3.up;
			array2[num3 + 3] = Vector3.one;
			array3[num3] = -up - right;
			array3[num3 + 1] = -up + right;
			array3[num3 + 2] = up - right;
			array3[num3 + 3] = up + right;
			array5[num2] = num3;
			array5[num2 + 1] = num3 + 1;
			array5[num2 + 2] = num3 + 2;
			array5[num2 + 3] = num3 + 1;
			array5[num2 + 4] = num3 + 3;
			array5[num2 + 5] = num3 + 2;
			array4[num3] = PJPPHDDFAHP.MPKCOJHJIIB;
			array4[num3 + 1] = PJPPHDDFAHP.MPKCOJHJIIB;
			array4[num3 + 2] = PJPPHDDFAHP.MPKCOJHJIIB;
			array4[num3 + 3] = PJPPHDDFAHP.MPKCOJHJIIB;
			num3 += 4;
			num2 += 6;
		}
		return new Mesh
		{
			vertices = array,
			uv = array2,
			uv2 = array3,
			colors = array4,
			triangles = array5
		};
	}

	// Token: 0x060111F4 RID: 70132 RVA: 0x007A1308 File Offset: 0x0079F508
	public static Dictionary<int, Vector3> KHOLNBBPFCG(LFMCCNHNKCJ PDBOLEGLMEL)
	{
		Vector3[] dkgooccioah = PDBOLEGLMEL.DKGOOCCIOAH;
		Dictionary<int, Vector3> dictionary = new Dictionary<int, Vector3>();
		if (dkgooccioah == null || dkgooccioah.Length != PDBOLEGLMEL.PAOKLFNDPAE)
		{
			return dictionary;
		}
		List<List<int>> list = PJPPHDDFAHP.JPBAMJGOLDH(PDBOLEGLMEL);
		Vector3 vector = Vector3.zero;
		Vector3 vector2 = Vector3.zero;
		foreach (List<int> list2 in list)
		{
			vector.x = 0f;
			vector.y = 0f;
			vector.z = 0f;
			foreach (int num in list2)
			{
				vector2 = dkgooccioah[num];
				vector.x += vector2.x;
				vector.y += vector2.y;
				vector.z += vector2.z;
			}
			vector /= (float)list2.Count<int>();
			foreach (int key in list2)
			{
				dictionary.Add(key, vector);
			}
		}
		return dictionary;
	}

	// Token: 0x060111F5 RID: 70133 RVA: 0x007A1470 File Offset: 0x0079F670
	public static List<List<int>> JPBAMJGOLDH(LFMCCNHNKCJ PDBOLEGLMEL)
	{
		PJPPHDDFAHP.ANAOJHGPMGH anaojhgpmgh = new PJPPHDDFAHP.ANAOJHGPMGH();
		List<List<int>> list;
		if (PJPPHDDFAHP.OFFBDDDOPHC.TryGetValue(PDBOLEGLMEL, out list))
		{
			return list;
		}
		anaojhgpmgh.LIBEPMOMPID = PDBOLEGLMEL.OKLLKJPCJLK;
		list = KMAJFAMPPMG.DBBLNCMBENK<int>(new Func<int, int>(PJPPHDDFAHP.<>c.<>9.BGNIJJBOMFG), anaojhgpmgh.LIBEPMOMPID.Length).ToLookup(new Func<int, AGOHHPKFBEK>(anaojhgpmgh.NOPHHIANCBD)).Select(new Func<IGrouping<AGOHHPKFBEK, int>, List<int>>(PJPPHDDFAHP.<>c.<>9.BFEGGHAALNP)).ToList<List<int>>();
		if (!PJPPHDDFAHP.OFFBDDDOPHC.ContainsKey(PDBOLEGLMEL))
		{
			PJPPHDDFAHP.OFFBDDDOPHC.Add(PDBOLEGLMEL, list);
		}
		else
		{
			PJPPHDDFAHP.OFFBDDDOPHC[PDBOLEGLMEL] = list;
		}
		return list;
	}

	// Token: 0x060111F6 RID: 70134 RVA: 0x007A1530 File Offset: 0x0079F730
	public static List<MNIANAAANGD> IJDHGCJFDGE(LFMCCNHNKCJ BMHDIKHFLBP)
	{
		Dictionary<int, int> ojebaefdkbn = PJPPHDDFAHP.JPBAMJGOLDH(BMHDIKHFLBP).DKHCBIDDGJE<int>();
		return PJPPHDDFAHP.IJDHGCJFDGE(BMHDIKHFLBP, ojebaefdkbn);
	}

	// Token: 0x060111F7 RID: 70135 RVA: 0x007A1550 File Offset: 0x0079F750
	public static List<MNIANAAANGD> IJDHGCJFDGE(LFMCCNHNKCJ BMHDIKHFLBP, Dictionary<int, int> OJEBAEFDKBN)
	{
		int[] array = BMHDIKHFLBP.LJMCJKHPHOI();
		int num = array.Length;
		List<MNIANAAANGD> list = new List<MNIANAAANGD>(num);
		for (int i = 0; i < num; i += 3)
		{
			list.Add(new MNIANAAANGD(array[i], array[i + 1], OJEBAEFDKBN[array[i]], OJEBAEFDKBN[array[i + 1]]));
			list.Add(new MNIANAAANGD(array[i + 1], array[i + 2], OJEBAEFDKBN[array[i + 1]], OJEBAEFDKBN[array[i + 2]]));
			list.Add(new MNIANAAANGD(array[i + 2], array[i], OJEBAEFDKBN[array[i + 2]], OJEBAEFDKBN[array[i]]));
		}
		return list;
	}

	// Token: 0x060111F8 RID: 70136 RVA: 0x007A15F8 File Offset: 0x0079F7F8
	public static HashSet<MNIANAAANGD> GGEFJBKAKAO(LFMCCNHNKCJ PDBOLEGLMEL, out List<MNIANAAANGD> CKALKMLGDOA)
	{
		Dictionary<int, int> ojebaefdkbn = PJPPHDDFAHP.JPBAMJGOLDH(PDBOLEGLMEL).DKHCBIDDGJE<int>();
		return PJPPHDDFAHP.GGEFJBKAKAO(PDBOLEGLMEL, ojebaefdkbn, out CKALKMLGDOA);
	}

	// Token: 0x060111F9 RID: 70137 RVA: 0x007A161C File Offset: 0x0079F81C
	private static HashSet<MNIANAAANGD> GGEFJBKAKAO(LFMCCNHNKCJ BMHDIKHFLBP, Dictionary<int, int> OJEBAEFDKBN, out List<MNIANAAANGD> CKALKMLGDOA)
	{
		int[] array = BMHDIKHFLBP.LJMCJKHPHOI();
		int num = array.Length;
		HashSet<MNIANAAANGD> hashSet = new HashSet<MNIANAAANGD>();
		CKALKMLGDOA = new List<MNIANAAANGD>();
		for (int i = 0; i < num; i += 3)
		{
			MNIANAAANGD item = new MNIANAAANGD(array[i], array[i + 1], OJEBAEFDKBN[array[i]], OJEBAEFDKBN[array[i + 1]]);
			MNIANAAANGD item2 = new MNIANAAANGD(array[i + 1], array[i + 2], OJEBAEFDKBN[array[i + 1]], OJEBAEFDKBN[array[i + 2]]);
			MNIANAAANGD item3 = new MNIANAAANGD(array[i + 2], array[i], OJEBAEFDKBN[array[i + 2]], OJEBAEFDKBN[array[i]]);
			if (!hashSet.Add(item))
			{
				CKALKMLGDOA.Add(item);
			}
			if (!hashSet.Add(item2))
			{
				CKALKMLGDOA.Add(item2);
			}
			if (!hashSet.Add(item3))
			{
				CKALKMLGDOA.Add(item3);
			}
		}
		return hashSet;
	}

	// Token: 0x060111FA RID: 70138 RVA: 0x007A16FC File Offset: 0x0079F8FC
	public static HashSet<int> EDLIDPMHAEG(LFMCCNHNKCJ PDBOLEGLMEL)
	{
		List<MNIANAAANGD> other;
		HashSet<MNIANAAANGD> hashSet = PJPPHDDFAHP.GGEFJBKAKAO(PDBOLEGLMEL, out other);
		hashSet.ExceptWith(other);
		return MNIANAAANGD.BBMDOODPHKD(hashSet);
	}

	// Token: 0x060111FB RID: 70139 RVA: 0x007A1720 File Offset: 0x0079F920
	public static Dictionary<int, List<int>> INHEFPAEGAC(LFMCCNHNKCJ PDBOLEGLMEL)
	{
		List<List<int>> list = PJPPHDDFAHP.JPBAMJGOLDH(PDBOLEGLMEL);
		Dictionary<int, int> dictionary = list.DKHCBIDDGJE<int>();
		List<MNIANAAANGD> list2 = PJPPHDDFAHP.IJDHGCJFDGE(PDBOLEGLMEL, dictionary).ToList<MNIANAAANGD>();
		List<List<int>> list3 = new List<List<int>>();
		for (int i = 0; i < list.Count<List<int>>(); i++)
		{
			list3.Add(new List<int>());
		}
		for (int j = 0; j < list2.Count; j++)
		{
			list3[list2[j].DEOHCNBLNPF].Add(list2[j].ADMFAEOOOHD);
			list3[list2[j].LJDBKOIGCAK].Add(list2[j].OCNGPCPMCPM);
		}
		Dictionary<int, List<int>> dictionary2 = new Dictionary<int, List<int>>();
		foreach (int key in PDBOLEGLMEL.LJMCJKHPHOI().Distinct<int>())
		{
			dictionary2.Add(key, list3[dictionary[key]]);
		}
		return dictionary2;
	}

	// Token: 0x060111FC RID: 70140 RVA: 0x007A1844 File Offset: 0x0079FA44
	public static Dictionary<JAFKHEFNPML, List<int>> MOAELFLKBNJ(LFMCCNHNKCJ BMHDIKHFLBP)
	{
		int num = BMHDIKHFLBP.LJMCJKHPHOI().Length;
		if (num % 3 != 0 || num / 3 == BMHDIKHFLBP.PAOKLFNDPAE)
		{
			return new Dictionary<JAFKHEFNPML, List<int>>();
		}
		Dictionary<JAFKHEFNPML, List<int>> dictionary = null;
		if (PJPPHDDFAHP.BOGBPGJFAJN.TryGetValue(BMHDIKHFLBP, out dictionary))
		{
			return dictionary;
		}
		int num2 = BMHDIKHFLBP.FFDLDPAIKEE;
		dictionary = new Dictionary<JAFKHEFNPML, List<int>>();
		for (int i = 0; i < num2; i++)
		{
			int[] array = BMHDIKHFLBP.CIIMNMCIBNC(i);
			for (int j = 0; j < array.Length; j += 3)
			{
				int item = j / 3;
				JAFKHEFNPML key = new JAFKHEFNPML(array[j], array[j + 1]);
				JAFKHEFNPML key2 = new JAFKHEFNPML(array[j + 1], array[j + 2]);
				JAFKHEFNPML key3 = new JAFKHEFNPML(array[j + 2], array[j]);
				List<int> list;
				if (dictionary.TryGetValue(key, out list))
				{
					list.Add(item);
				}
				else
				{
					dictionary.Add(key, new List<int>
					{
						item
					});
				}
				if (dictionary.TryGetValue(key2, out list))
				{
					list.Add(item);
				}
				else
				{
					dictionary.Add(key2, new List<int>
					{
						item
					});
				}
				if (dictionary.TryGetValue(key3, out list))
				{
					list.Add(item);
				}
				else
				{
					dictionary.Add(key3, new List<int>
					{
						item
					});
				}
			}
		}
		PJPPHDDFAHP.BOGBPGJFAJN.Add(BMHDIKHFLBP, dictionary);
		return dictionary;
	}

	// Token: 0x060111FD RID: 70141 RVA: 0x007A1998 File Offset: 0x0079FB98
	public static List<List<int>> PALANKPALGC(LFMCCNHNKCJ BMHDIKHFLBP)
	{
		PJPPHDDFAHP.OGBALHCCADE ogbalhccade = new PJPPHDDFAHP.OGBALHCCADE();
		ogbalhccade.DKGOOCCIOAH = BMHDIKHFLBP.DKGOOCCIOAH;
		if (ogbalhccade.DKGOOCCIOAH == null)
		{
			return null;
		}
		List<List<int>> result = null;
		if (PJPPHDDFAHP.CNPGCELMFKD.TryGetValue(BMHDIKHFLBP, out result))
		{
			return result;
		}
		List<List<int>> list = PJPPHDDFAHP.JPBAMJGOLDH(BMHDIKHFLBP).SelectMany(new Func<List<int>, IEnumerable<IGrouping<AGOHHPKFBEK, int>>>(ogbalhccade.KCHCCCJEOCG)).Where(new Func<IGrouping<AGOHHPKFBEK, int>, bool>(PJPPHDDFAHP.<>c.<>9.BNPEOBBCDNF)).Select(new Func<IGrouping<AGOHHPKFBEK, int>, List<int>>(PJPPHDDFAHP.<>c.<>9.LGHLKFCGFBB)).ToList<List<int>>();
		PJPPHDDFAHP.CNPGCELMFKD.Add(BMHDIKHFLBP, list);
		return list;
	}

	// Token: 0x060111FE RID: 70142 RVA: 0x007A1A48 File Offset: 0x0079FC48
	public static void GHPMNJJFLDG(LFMCCNHNKCJ BMHDIKHFLBP)
	{
		List<List<int>> list = PJPPHDDFAHP.PALANKPALGC(BMHDIKHFLBP);
		BMHDIKHFLBP.GHPMNJJFLDG();
		if (list != null)
		{
			Vector3[] dkgooccioah = BMHDIKHFLBP.DKGOOCCIOAH;
			foreach (List<int> list2 in list)
			{
				Vector3 vector = NCFJIBJEMCF.INHBIAADCCM(dkgooccioah, list2);
				foreach (int num in list2)
				{
					dkgooccioah[num] = vector;
				}
			}
			BMHDIKHFLBP.DKGOOCCIOAH = dkgooccioah;
		}
	}

	// Token: 0x060111FF RID: 70143 RVA: 0x007A1AF8 File Offset: 0x0079FCF8
	public static string IOMAHJCCGIP(Mesh BMHDIKHFLBP, int CABHALLNLMD = 8)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine(string.Format("{0,-28}{1,-28}{2,-28}{3,-28}{4,-28}{5,-28}{6,-28}", new object[]
		{
			"Positions",
			"Colors",
			"Tangents",
			"UV0",
			"UV2",
			"UV3",
			"UV4"
		}));
		stringBuilder.AppendLine(string.Format("vertices: {0}   triangles: {1}", BMHDIKHFLBP.vertexCount, BMHDIKHFLBP.triangles.Length));
		Vector3[] array = BMHDIKHFLBP.vertices;
		Color[] array2 = BMHDIKHFLBP.colors;
		Vector4[] array3 = BMHDIKHFLBP.tangents;
		List<Vector4> list = new List<Vector4>();
		Vector2[] array4 = BMHDIKHFLBP.uv2;
		List<Vector4> list2 = new List<Vector4>();
		List<Vector4> list3 = new List<Vector4>();
		BMHDIKHFLBP.GetUVs(0, list);
		BMHDIKHFLBP.GetUVs(2, list2);
		BMHDIKHFLBP.GetUVs(3, list3);
		if (array != null && array.Count<Vector3>() != BMHDIKHFLBP.vertexCount)
		{
			array = null;
		}
		if (array2 != null && array2.Count<Color>() != BMHDIKHFLBP.vertexCount)
		{
			array2 = null;
		}
		if (array3 != null && array3.Count<Vector4>() != BMHDIKHFLBP.vertexCount)
		{
			array3 = null;
		}
		if (list != null && list.Count<Vector4>() != BMHDIKHFLBP.vertexCount)
		{
			list = null;
		}
		if (array4 != null && array4.Count<Vector2>() != BMHDIKHFLBP.vertexCount)
		{
			array4 = null;
		}
		if (list2 != null && list2.Count<Vector4>() != BMHDIKHFLBP.vertexCount)
		{
			list2 = null;
		}
		if (list3 != null && list3.Count<Vector4>() != BMHDIKHFLBP.vertexCount)
		{
			list3 = null;
		}
		int num = BMHDIKHFLBP.vertexCount;
		if (CABHALLNLMD > -1 && CABHALLNLMD < num)
		{
			num = CABHALLNLMD;
		}
		for (int i = 0; i < num; i++)
		{
			stringBuilder.AppendLine(string.Format("{0,-28}{1,-28}{2,-28}{3,-28}{4,-28}{5,-28}{6,-28}", new object[]
			{
				(array == null) ? "null" : string.Format("{0:F2}, {1:F2}, {2:F2}", array[i].x, array[i].y, array[i].z),
				(array2 == null) ? "null" : string.Format("{0:F2}, {1:F2}, {2:F2}, {3:F2}", new object[]
				{
					array2[i].r,
					array2[i].g,
					array2[i].b,
					array2[i].a
				}),
				(array3 == null) ? "null" : string.Format("{0:F2}, {1:F2}, {2:F2}, {3:F2}", new object[]
				{
					array3[i].x,
					array3[i].y,
					array3[i].z,
					array3[i].w
				}),
				(list == null) ? "null" : string.Format("{0:F2}, {1:F2}, {2:F2}, {3:F2}", new object[]
				{
					list[i].x,
					list[i].y,
					list[i].z,
					list[i].w
				}),
				(array4 == null) ? "null" : string.Format("{0:F2}, {1:F2}", array4[i].x, array4[i].y),
				(list2 == null) ? "null" : string.Format("{0:F2}, {1:F2}, {2:F2}, {3:F2}", new object[]
				{
					list2[i].x,
					list2[i].y,
					list2[i].z,
					list2[i].w
				}),
				(list3 == null) ? "null" : string.Format("{0:F2}, {1:F2}, {2:F2}, {3:F2}", new object[]
				{
					list3[i].x,
					list3[i].y,
					list3[i].z,
					list3[i].w
				})
			}));
		}
		int num2 = BMHDIKHFLBP.triangles.Length;
		if (CABHALLNLMD > -1 && CABHALLNLMD * 3 < num2)
		{
			num2 = CABHALLNLMD * 3;
		}
		for (int j = 0; j < num2; j += 3)
		{
			stringBuilder.AppendLine(string.Format("{0}, {1}, {2}", BMHDIKHFLBP.triangles[j], BMHDIKHFLBP.triangles[j + 1], BMHDIKHFLBP.triangles[j + 2]));
		}
		return stringBuilder.ToString();
	}

	// Token: 0x040023D0 RID: 9168
	private static readonly Color MPKCOJHJIIB = new Color(0f, 0f, 0f, 0f);

	// Token: 0x040023D1 RID: 9169
	public static Dictionary<LFMCCNHNKCJ, List<List<int>>> OFFBDDDOPHC = new Dictionary<LFMCCNHNKCJ, List<List<int>>>();

	// Token: 0x040023D2 RID: 9170
	private static Dictionary<LFMCCNHNKCJ, Dictionary<JAFKHEFNPML, List<int>>> BOGBPGJFAJN = new Dictionary<LFMCCNHNKCJ, Dictionary<JAFKHEFNPML, List<int>>>();

	// Token: 0x040023D3 RID: 9171
	private static Dictionary<LFMCCNHNKCJ, List<List<int>>> CNPGCELMFKD = new Dictionary<LFMCCNHNKCJ, List<List<int>>>();

	// Token: 0x02000500 RID: 1280
	[CompilerGenerated]
	private sealed class ANAOJHGPMGH
	{
		// Token: 0x06011201 RID: 70145 RVA: 0x007A2020 File Offset: 0x007A0220
		internal AGOHHPKFBEK BJCGKJAOEJM(int OCNGPCPMCPM)
		{
			return AGOHHPKFBEK.CFGBAJCJKPG(this.LIBEPMOMPID[OCNGPCPMCPM]);
		}

		// Token: 0x06011203 RID: 70147 RVA: 0x007A2033 File Offset: 0x007A0233
		internal AGOHHPKFBEK FOADEADOKFH(int OCNGPCPMCPM)
		{
			return AGOHHPKFBEK.NHCGLOMINFK(this.LIBEPMOMPID[OCNGPCPMCPM]);
		}

		// Token: 0x06011204 RID: 70148 RVA: 0x007A2046 File Offset: 0x007A0246
		internal AGOHHPKFBEK NOPHHIANCBD(int OCNGPCPMCPM)
		{
			return AGOHHPKFBEK.GOOIABGKMHK(this.LIBEPMOMPID[OCNGPCPMCPM]);
		}

		// Token: 0x06011205 RID: 70149 RVA: 0x007A2059 File Offset: 0x007A0259
		internal AGOHHPKFBEK LLPGNAPEIPN(int OCNGPCPMCPM)
		{
			return AGOHHPKFBEK.KHJPCCFDJPA(this.LIBEPMOMPID[OCNGPCPMCPM]);
		}

		// Token: 0x06011206 RID: 70150 RVA: 0x007A206C File Offset: 0x007A026C
		internal AGOHHPKFBEK FDHPEOHMILF(int OCNGPCPMCPM)
		{
			return AGOHHPKFBEK.KNFNKGJGDAB(this.LIBEPMOMPID[OCNGPCPMCPM]);
		}

		// Token: 0x06011207 RID: 70151 RVA: 0x007A2046 File Offset: 0x007A0246
		internal AGOHHPKFBEK LGOGJLFKHBC(int OCNGPCPMCPM)
		{
			return AGOHHPKFBEK.GOOIABGKMHK(this.LIBEPMOMPID[OCNGPCPMCPM]);
		}

		// Token: 0x06011208 RID: 70152 RVA: 0x007A207F File Offset: 0x007A027F
		internal AGOHHPKFBEK BCGDDEMADEN(int OCNGPCPMCPM)
		{
			return AGOHHPKFBEK.EDIGIBJKONA(this.LIBEPMOMPID[OCNGPCPMCPM]);
		}

		// Token: 0x06011209 RID: 70153 RVA: 0x007A2092 File Offset: 0x007A0292
		internal AGOHHPKFBEK IPOJDHJEEAO(int OCNGPCPMCPM)
		{
			return AGOHHPKFBEK.JFOEIEAOMNM(this.LIBEPMOMPID[OCNGPCPMCPM]);
		}

		// Token: 0x0601120A RID: 70154 RVA: 0x007A2033 File Offset: 0x007A0233
		internal AGOHHPKFBEK DNKPBFIAALI(int OCNGPCPMCPM)
		{
			return AGOHHPKFBEK.NHCGLOMINFK(this.LIBEPMOMPID[OCNGPCPMCPM]);
		}

		// Token: 0x0601120B RID: 70155 RVA: 0x007A2033 File Offset: 0x007A0233
		internal AGOHHPKFBEK LHIKAOEBKHD(int OCNGPCPMCPM)
		{
			return AGOHHPKFBEK.NHCGLOMINFK(this.LIBEPMOMPID[OCNGPCPMCPM]);
		}

		// Token: 0x0601120C RID: 70156 RVA: 0x007A2020 File Offset: 0x007A0220
		internal AGOHHPKFBEK KOAKDBADJBL(int OCNGPCPMCPM)
		{
			return AGOHHPKFBEK.CFGBAJCJKPG(this.LIBEPMOMPID[OCNGPCPMCPM]);
		}

		// Token: 0x0601120D RID: 70157 RVA: 0x007A2046 File Offset: 0x007A0246
		internal AGOHHPKFBEK CADCHKJOBKN(int OCNGPCPMCPM)
		{
			return AGOHHPKFBEK.GOOIABGKMHK(this.LIBEPMOMPID[OCNGPCPMCPM]);
		}

		// Token: 0x0601120E RID: 70158 RVA: 0x007A2020 File Offset: 0x007A0220
		internal AGOHHPKFBEK CCBIBBLECDN(int OCNGPCPMCPM)
		{
			return AGOHHPKFBEK.CFGBAJCJKPG(this.LIBEPMOMPID[OCNGPCPMCPM]);
		}

		// Token: 0x0601120F RID: 70159 RVA: 0x007A2046 File Offset: 0x007A0246
		internal AGOHHPKFBEK FECAOPFLFGA(int OCNGPCPMCPM)
		{
			return AGOHHPKFBEK.GOOIABGKMHK(this.LIBEPMOMPID[OCNGPCPMCPM]);
		}

		// Token: 0x06011210 RID: 70160 RVA: 0x007A2092 File Offset: 0x007A0292
		internal AGOHHPKFBEK LHFIBKANJNH(int OCNGPCPMCPM)
		{
			return AGOHHPKFBEK.JFOEIEAOMNM(this.LIBEPMOMPID[OCNGPCPMCPM]);
		}

		// Token: 0x06011211 RID: 70161 RVA: 0x007A20A5 File Offset: 0x007A02A5
		internal AGOHHPKFBEK HMOFKCFHCFH(int OCNGPCPMCPM)
		{
			return AGOHHPKFBEK.CEPIGFKNAFC(this.LIBEPMOMPID[OCNGPCPMCPM]);
		}

		// Token: 0x06011212 RID: 70162 RVA: 0x007A2046 File Offset: 0x007A0246
		internal AGOHHPKFBEK NIIKNINFAMP(int OCNGPCPMCPM)
		{
			return AGOHHPKFBEK.GOOIABGKMHK(this.LIBEPMOMPID[OCNGPCPMCPM]);
		}

		// Token: 0x06011213 RID: 70163 RVA: 0x007A2092 File Offset: 0x007A0292
		internal AGOHHPKFBEK NALKCDGEIBP(int OCNGPCPMCPM)
		{
			return AGOHHPKFBEK.JFOEIEAOMNM(this.LIBEPMOMPID[OCNGPCPMCPM]);
		}

		// Token: 0x06011214 RID: 70164 RVA: 0x007A20A5 File Offset: 0x007A02A5
		internal AGOHHPKFBEK PFNMMBJKIDH(int OCNGPCPMCPM)
		{
			return AGOHHPKFBEK.CEPIGFKNAFC(this.LIBEPMOMPID[OCNGPCPMCPM]);
		}

		// Token: 0x06011215 RID: 70165 RVA: 0x007A206C File Offset: 0x007A026C
		internal AGOHHPKFBEK IBNBACMFNBE(int OCNGPCPMCPM)
		{
			return AGOHHPKFBEK.KNFNKGJGDAB(this.LIBEPMOMPID[OCNGPCPMCPM]);
		}

		// Token: 0x06011216 RID: 70166 RVA: 0x007A20A5 File Offset: 0x007A02A5
		internal AGOHHPKFBEK MMAOINADONB(int OCNGPCPMCPM)
		{
			return AGOHHPKFBEK.CEPIGFKNAFC(this.LIBEPMOMPID[OCNGPCPMCPM]);
		}

		// Token: 0x06011217 RID: 70167 RVA: 0x007A207F File Offset: 0x007A027F
		internal AGOHHPKFBEK LEJMPHGGPIL(int OCNGPCPMCPM)
		{
			return AGOHHPKFBEK.EDIGIBJKONA(this.LIBEPMOMPID[OCNGPCPMCPM]);
		}

		// Token: 0x06011218 RID: 70168 RVA: 0x007A20A5 File Offset: 0x007A02A5
		internal AGOHHPKFBEK DAODIPFMEKF(int OCNGPCPMCPM)
		{
			return AGOHHPKFBEK.CEPIGFKNAFC(this.LIBEPMOMPID[OCNGPCPMCPM]);
		}

		// Token: 0x06011219 RID: 70169 RVA: 0x007A206C File Offset: 0x007A026C
		internal AGOHHPKFBEK CPNONHNCLBN(int OCNGPCPMCPM)
		{
			return AGOHHPKFBEK.KNFNKGJGDAB(this.LIBEPMOMPID[OCNGPCPMCPM]);
		}

		// Token: 0x0601121A RID: 70170 RVA: 0x007A20B8 File Offset: 0x007A02B8
		internal AGOHHPKFBEK GFMKFNHJAOL(int OCNGPCPMCPM)
		{
			return AGOHHPKFBEK.GJKHONBFJEI(this.LIBEPMOMPID[OCNGPCPMCPM]);
		}

		// Token: 0x040023D4 RID: 9172
		public Vector3[] LIBEPMOMPID;
	}

	// Token: 0x02000502 RID: 1282
	[CompilerGenerated]
	private sealed class OGBALHCCADE
	{
		// Token: 0x06011273 RID: 70259 RVA: 0x007A20F8 File Offset: 0x007A02F8
		internal IEnumerable<IGrouping<AGOHHPKFBEK, int>> KFCMHEAPCAP(List<int> OCNGPCPMCPM)
		{
			Func<int, AGOHHPKFBEK> keySelector;
			if ((keySelector = this.GPONEIMMFIP) == null)
			{
				keySelector = (this.GPONEIMMFIP = new Func<int, AGOHHPKFBEK>(this.NJOCALDKFEH));
			}
			return OCNGPCPMCPM.GroupBy(keySelector);
		}

		// Token: 0x06011274 RID: 70260 RVA: 0x007A212A File Offset: 0x007A032A
		internal AGOHHPKFBEK JHBFANLABDL(int LMGJKOMFCFC)
		{
			return AGOHHPKFBEK.CFGBAJCJKPG(this.DKGOOCCIOAH[LMGJKOMFCFC]);
		}

		// Token: 0x06011275 RID: 70261 RVA: 0x007A213D File Offset: 0x007A033D
		internal AGOHHPKFBEK NJLELFKAAGO(int LMGJKOMFCFC)
		{
			return AGOHHPKFBEK.JFOEIEAOMNM(this.DKGOOCCIOAH[LMGJKOMFCFC]);
		}

		// Token: 0x06011276 RID: 70262 RVA: 0x007A2150 File Offset: 0x007A0350
		internal IEnumerable<IGrouping<AGOHHPKFBEK, int>> OHLCIDICMDE(List<int> OCNGPCPMCPM)
		{
			Func<int, AGOHHPKFBEK> keySelector;
			if ((keySelector = this.GPONEIMMFIP) == null)
			{
				keySelector = (this.GPONEIMMFIP = new Func<int, AGOHHPKFBEK>(this.NJLELFKAAGO));
			}
			return OCNGPCPMCPM.GroupBy(keySelector);
		}

		// Token: 0x06011277 RID: 70263 RVA: 0x007A213D File Offset: 0x007A033D
		internal AGOHHPKFBEK LPEPBNDNCMB(int LMGJKOMFCFC)
		{
			return AGOHHPKFBEK.JFOEIEAOMNM(this.DKGOOCCIOAH[LMGJKOMFCFC]);
		}

		// Token: 0x06011278 RID: 70264 RVA: 0x007A2184 File Offset: 0x007A0384
		internal IEnumerable<IGrouping<AGOHHPKFBEK, int>> JKJGFIOEFOL(List<int> OCNGPCPMCPM)
		{
			Func<int, AGOHHPKFBEK> keySelector;
			if ((keySelector = this.GPONEIMMFIP) == null)
			{
				keySelector = (this.GPONEIMMFIP = new Func<int, AGOHHPKFBEK>(this.NJLELFKAAGO));
			}
			return OCNGPCPMCPM.GroupBy(keySelector);
		}

		// Token: 0x06011279 RID: 70265 RVA: 0x007A21B8 File Offset: 0x007A03B8
		internal IEnumerable<IGrouping<AGOHHPKFBEK, int>> EDKPFKDLIMD(List<int> OCNGPCPMCPM)
		{
			Func<int, AGOHHPKFBEK> keySelector;
			if ((keySelector = this.GPONEIMMFIP) == null)
			{
				keySelector = (this.GPONEIMMFIP = new Func<int, AGOHHPKFBEK>(this.OMPAOMDKAHE));
			}
			return OCNGPCPMCPM.GroupBy(keySelector);
		}

		// Token: 0x0601127A RID: 70266 RVA: 0x007A21EC File Offset: 0x007A03EC
		internal IEnumerable<IGrouping<AGOHHPKFBEK, int>> DAELPKNCDAG(List<int> OCNGPCPMCPM)
		{
			Func<int, AGOHHPKFBEK> keySelector;
			if ((keySelector = this.GPONEIMMFIP) == null)
			{
				keySelector = (this.GPONEIMMFIP = new Func<int, AGOHHPKFBEK>(this.GELOELCOONN));
			}
			return OCNGPCPMCPM.GroupBy(keySelector);
		}

		// Token: 0x0601127B RID: 70267 RVA: 0x007A2220 File Offset: 0x007A0420
		internal IEnumerable<IGrouping<AGOHHPKFBEK, int>> MIMNABNPOGD(List<int> OCNGPCPMCPM)
		{
			Func<int, AGOHHPKFBEK> keySelector;
			if ((keySelector = this.GPONEIMMFIP) == null)
			{
				keySelector = (this.GPONEIMMFIP = new Func<int, AGOHHPKFBEK>(this.GELOELCOONN));
			}
			return OCNGPCPMCPM.GroupBy(keySelector);
		}

		// Token: 0x0601127C RID: 70268 RVA: 0x007A2254 File Offset: 0x007A0454
		internal IEnumerable<IGrouping<AGOHHPKFBEK, int>> NBNNMLOIBII(List<int> OCNGPCPMCPM)
		{
			Func<int, AGOHHPKFBEK> keySelector;
			if ((keySelector = this.GPONEIMMFIP) == null)
			{
				keySelector = (this.GPONEIMMFIP = new Func<int, AGOHHPKFBEK>(this.OMPAOMDKAHE));
			}
			return OCNGPCPMCPM.GroupBy(keySelector);
		}

		// Token: 0x0601127D RID: 70269 RVA: 0x007A2288 File Offset: 0x007A0488
		internal IEnumerable<IGrouping<AGOHHPKFBEK, int>> KCHCCCJEOCG(List<int> OCNGPCPMCPM)
		{
			Func<int, AGOHHPKFBEK> keySelector;
			if ((keySelector = this.GPONEIMMFIP) == null)
			{
				keySelector = (this.GPONEIMMFIP = new Func<int, AGOHHPKFBEK>(this.OKHJCPDJECI));
			}
			return OCNGPCPMCPM.GroupBy(keySelector);
		}

		// Token: 0x0601127E RID: 70270 RVA: 0x007A22BC File Offset: 0x007A04BC
		internal IEnumerable<IGrouping<AGOHHPKFBEK, int>> OGDEENNCENI(List<int> OCNGPCPMCPM)
		{
			Func<int, AGOHHPKFBEK> keySelector;
			if ((keySelector = this.GPONEIMMFIP) == null)
			{
				keySelector = (this.GPONEIMMFIP = new Func<int, AGOHHPKFBEK>(this.MJMDPODGIAH));
			}
			return OCNGPCPMCPM.GroupBy(keySelector);
		}

		// Token: 0x0601127F RID: 70271 RVA: 0x007A22F0 File Offset: 0x007A04F0
		internal IEnumerable<IGrouping<AGOHHPKFBEK, int>> LCJPNJMKFOK(List<int> OCNGPCPMCPM)
		{
			Func<int, AGOHHPKFBEK> keySelector;
			if ((keySelector = this.GPONEIMMFIP) == null)
			{
				keySelector = (this.GPONEIMMFIP = new Func<int, AGOHHPKFBEK>(this.JHBFANLABDL));
			}
			return OCNGPCPMCPM.GroupBy(keySelector);
		}

		// Token: 0x06011280 RID: 70272 RVA: 0x007A2324 File Offset: 0x007A0524
		internal IEnumerable<IGrouping<AGOHHPKFBEK, int>> KDLJDHLJOFB(List<int> OCNGPCPMCPM)
		{
			Func<int, AGOHHPKFBEK> keySelector;
			if ((keySelector = this.GPONEIMMFIP) == null)
			{
				keySelector = (this.GPONEIMMFIP = new Func<int, AGOHHPKFBEK>(this.JHBFANLABDL));
			}
			return OCNGPCPMCPM.GroupBy(keySelector);
		}

		// Token: 0x06011281 RID: 70273 RVA: 0x007A2358 File Offset: 0x007A0558
		internal IEnumerable<IGrouping<AGOHHPKFBEK, int>> ALMIDLGPOJC(List<int> OCNGPCPMCPM)
		{
			Func<int, AGOHHPKFBEK> keySelector;
			if ((keySelector = this.GPONEIMMFIP) == null)
			{
				keySelector = (this.GPONEIMMFIP = new Func<int, AGOHHPKFBEK>(this.GELOELCOONN));
			}
			return OCNGPCPMCPM.GroupBy(keySelector);
		}

		// Token: 0x06011282 RID: 70274 RVA: 0x007A238C File Offset: 0x007A058C
		internal IEnumerable<IGrouping<AGOHHPKFBEK, int>> KECODMCBGDE(List<int> OCNGPCPMCPM)
		{
			Func<int, AGOHHPKFBEK> keySelector;
			if ((keySelector = this.GPONEIMMFIP) == null)
			{
				keySelector = (this.GPONEIMMFIP = new Func<int, AGOHHPKFBEK>(this.MJMDPODGIAH));
			}
			return OCNGPCPMCPM.GroupBy(keySelector);
		}

		// Token: 0x06011283 RID: 70275 RVA: 0x007A23C0 File Offset: 0x007A05C0
		internal IEnumerable<IGrouping<AGOHHPKFBEK, int>> KAIPBMMKMIH(List<int> OCNGPCPMCPM)
		{
			Func<int, AGOHHPKFBEK> keySelector;
			if ((keySelector = this.GPONEIMMFIP) == null)
			{
				keySelector = (this.GPONEIMMFIP = new Func<int, AGOHHPKFBEK>(this.EDJCPFDFADE));
			}
			return OCNGPCPMCPM.GroupBy(keySelector);
		}

		// Token: 0x06011284 RID: 70276 RVA: 0x007A23F2 File Offset: 0x007A05F2
		internal AGOHHPKFBEK IAAJFKFDHGL(int LMGJKOMFCFC)
		{
			return AGOHHPKFBEK.NHCGLOMINFK(this.DKGOOCCIOAH[LMGJKOMFCFC]);
		}

		// Token: 0x06011285 RID: 70277 RVA: 0x007A2408 File Offset: 0x007A0608
		internal IEnumerable<IGrouping<AGOHHPKFBEK, int>> FAKDHFJJJKA(List<int> OCNGPCPMCPM)
		{
			Func<int, AGOHHPKFBEK> keySelector;
			if ((keySelector = this.GPONEIMMFIP) == null)
			{
				keySelector = (this.GPONEIMMFIP = new Func<int, AGOHHPKFBEK>(this.EDJCPFDFADE));
			}
			return OCNGPCPMCPM.GroupBy(keySelector);
		}

		// Token: 0x06011286 RID: 70278 RVA: 0x007A243A File Offset: 0x007A063A
		internal AGOHHPKFBEK OMPAOMDKAHE(int LMGJKOMFCFC)
		{
			return AGOHHPKFBEK.GOOIABGKMHK(this.DKGOOCCIOAH[LMGJKOMFCFC]);
		}

		// Token: 0x06011287 RID: 70279 RVA: 0x007A2450 File Offset: 0x007A0650
		internal IEnumerable<IGrouping<AGOHHPKFBEK, int>> OBJGAOPEFDA(List<int> OCNGPCPMCPM)
		{
			Func<int, AGOHHPKFBEK> keySelector;
			if ((keySelector = this.GPONEIMMFIP) == null)
			{
				keySelector = (this.GPONEIMMFIP = new Func<int, AGOHHPKFBEK>(this.LPEPBNDNCMB));
			}
			return OCNGPCPMCPM.GroupBy(keySelector);
		}

		// Token: 0x06011289 RID: 70281 RVA: 0x007A2484 File Offset: 0x007A0684
		internal IEnumerable<IGrouping<AGOHHPKFBEK, int>> JCKEKAKKOHE(List<int> OCNGPCPMCPM)
		{
			Func<int, AGOHHPKFBEK> keySelector;
			if ((keySelector = this.GPONEIMMFIP) == null)
			{
				keySelector = (this.GPONEIMMFIP = new Func<int, AGOHHPKFBEK>(this.OKHJCPDJECI));
			}
			return OCNGPCPMCPM.GroupBy(keySelector);
		}

		// Token: 0x0601128A RID: 70282 RVA: 0x007A24B8 File Offset: 0x007A06B8
		internal IEnumerable<IGrouping<AGOHHPKFBEK, int>> OLBELJFHNEE(List<int> OCNGPCPMCPM)
		{
			Func<int, AGOHHPKFBEK> keySelector;
			if ((keySelector = this.GPONEIMMFIP) == null)
			{
				keySelector = (this.GPONEIMMFIP = new Func<int, AGOHHPKFBEK>(this.NJLELFKAAGO));
			}
			return OCNGPCPMCPM.GroupBy(keySelector);
		}

		// Token: 0x0601128B RID: 70283 RVA: 0x007A212A File Offset: 0x007A032A
		internal AGOHHPKFBEK NJOCALDKFEH(int LMGJKOMFCFC)
		{
			return AGOHHPKFBEK.CFGBAJCJKPG(this.DKGOOCCIOAH[LMGJKOMFCFC]);
		}

		// Token: 0x0601128C RID: 70284 RVA: 0x007A24EC File Offset: 0x007A06EC
		internal IEnumerable<IGrouping<AGOHHPKFBEK, int>> FCDMFLCIGJF(List<int> OCNGPCPMCPM)
		{
			Func<int, AGOHHPKFBEK> keySelector;
			if ((keySelector = this.GPONEIMMFIP) == null)
			{
				keySelector = (this.GPONEIMMFIP = new Func<int, AGOHHPKFBEK>(this.NJLELFKAAGO));
			}
			return OCNGPCPMCPM.GroupBy(keySelector);
		}

		// Token: 0x0601128D RID: 70285 RVA: 0x007A251E File Offset: 0x007A071E
		internal AGOHHPKFBEK EDJCPFDFADE(int LMGJKOMFCFC)
		{
			return AGOHHPKFBEK.CEPIGFKNAFC(this.DKGOOCCIOAH[LMGJKOMFCFC]);
		}

		// Token: 0x0601128E RID: 70286 RVA: 0x007A2531 File Offset: 0x007A0731
		internal AGOHHPKFBEK FBBKOABGEOK(int LMGJKOMFCFC)
		{
			return AGOHHPKFBEK.KNFNKGJGDAB(this.DKGOOCCIOAH[LMGJKOMFCFC]);
		}

		// Token: 0x0601128F RID: 70287 RVA: 0x007A2544 File Offset: 0x007A0744
		internal AGOHHPKFBEK GELOELCOONN(int LMGJKOMFCFC)
		{
			return AGOHHPKFBEK.GJKHONBFJEI(this.DKGOOCCIOAH[LMGJKOMFCFC]);
		}

		// Token: 0x06011290 RID: 70288 RVA: 0x007A2558 File Offset: 0x007A0758
		internal IEnumerable<IGrouping<AGOHHPKFBEK, int>> LIJBPABPFFE(List<int> OCNGPCPMCPM)
		{
			Func<int, AGOHHPKFBEK> keySelector;
			if ((keySelector = this.GPONEIMMFIP) == null)
			{
				keySelector = (this.GPONEIMMFIP = new Func<int, AGOHHPKFBEK>(this.FBBKOABGEOK));
			}
			return OCNGPCPMCPM.GroupBy(keySelector);
		}

		// Token: 0x06011291 RID: 70289 RVA: 0x007A258C File Offset: 0x007A078C
		internal IEnumerable<IGrouping<AGOHHPKFBEK, int>> HBBCNANOBCM(List<int> OCNGPCPMCPM)
		{
			Func<int, AGOHHPKFBEK> keySelector;
			if ((keySelector = this.GPONEIMMFIP) == null)
			{
				keySelector = (this.GPONEIMMFIP = new Func<int, AGOHHPKFBEK>(this.NJOCALDKFEH));
			}
			return OCNGPCPMCPM.GroupBy(keySelector);
		}

		// Token: 0x06011292 RID: 70290 RVA: 0x007A25BE File Offset: 0x007A07BE
		internal AGOHHPKFBEK MJMDPODGIAH(int LMGJKOMFCFC)
		{
			return AGOHHPKFBEK.KHJPCCFDJPA(this.DKGOOCCIOAH[LMGJKOMFCFC]);
		}

		// Token: 0x06011293 RID: 70291 RVA: 0x007A25D4 File Offset: 0x007A07D4
		internal IEnumerable<IGrouping<AGOHHPKFBEK, int>> NEELMJEIICL(List<int> OCNGPCPMCPM)
		{
			Func<int, AGOHHPKFBEK> keySelector;
			if ((keySelector = this.GPONEIMMFIP) == null)
			{
				keySelector = (this.GPONEIMMFIP = new Func<int, AGOHHPKFBEK>(this.NJLELFKAAGO));
			}
			return OCNGPCPMCPM.GroupBy(keySelector);
		}

		// Token: 0x06011294 RID: 70292 RVA: 0x007A243A File Offset: 0x007A063A
		internal AGOHHPKFBEK OKHJCPDJECI(int LMGJKOMFCFC)
		{
			return AGOHHPKFBEK.GOOIABGKMHK(this.DKGOOCCIOAH[LMGJKOMFCFC]);
		}

		// Token: 0x06011295 RID: 70293 RVA: 0x007A2608 File Offset: 0x007A0808
		internal IEnumerable<IGrouping<AGOHHPKFBEK, int>> FBPJDLIAOAJ(List<int> OCNGPCPMCPM)
		{
			Func<int, AGOHHPKFBEK> keySelector;
			if ((keySelector = this.GPONEIMMFIP) == null)
			{
				keySelector = (this.GPONEIMMFIP = new Func<int, AGOHHPKFBEK>(this.LPEPBNDNCMB));
			}
			return OCNGPCPMCPM.GroupBy(keySelector);
		}

		// Token: 0x040023DA RID: 9178
		public Vector3[] DKGOOCCIOAH;

		// Token: 0x040023DB RID: 9179
		public Func<int, AGOHHPKFBEK> GPONEIMMFIP;
	}
}
