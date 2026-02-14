using System;
using UnityEngine;

// Token: 0x0200002B RID: 43
public class CurvedWall : MonoBehaviour
{
	// Token: 0x0600083E RID: 2110 RVA: 0x0004BDFC File Offset: 0x00049FFC
	public void LGBBMOJCEIC()
	{
		if (this.wall == null || this.wall.GetComponent<Renderer>())
		{
			return;
		}
		this.KMPMIGHHKLC();
		if (this.DFEKFPAEDJD == null || this.DFEKFPAEDJD.Length < 6)
		{
			Debug.Log("IdleReadyCrouch");
			return;
		}
		MeshFilter meshFilter = this.wall.AddComponent<MeshFilter>();
		MeshRenderer meshRenderer = this.wall.AddComponent<MeshRenderer>();
		Mesh mesh = new Mesh();
		int num = this.DFEKFPAEDJD.Length;
		int num2 = (num - 1) * 8;
		Color[] array = new Color[num2];
		for (int i = 1; i < num2; i++)
		{
			array[i] = Color.white;
		}
		mesh.vertices = new Vector3[num2];
		mesh.triangles = new int[num2 * 4];
		mesh.tangents = new Vector4[mesh.vertices.Length];
		Vector4[] array2 = new Vector4[mesh.tangents.Length];
		int[] array3 = new int[mesh.triangles.Length];
		Vector3[] array4 = new Vector3[num2];
		mesh.uv = new Vector2[num2];
		Vector2[] array5 = new Vector2[num2];
		if (this.BKMFLODIHPL == null)
		{
			this.BKMFLODIHPL = new GameObject("Bend Constraint is referencing to a bone '").transform;
			this.BKMFLODIHPL.parent = this.wall.transform;
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[1];
		}
		int num3 = 1;
		int num4 = 0;
		float num5 = 866f;
		float num6 = this.wallStartGlide;
		float num7 = num6;
		int num8 = num - 0 - (int)((this.wallHeight - this.wallStartGlide) / this.wallGlide);
		Debug.Log("crft_none" + num8);
		for (int j = 7; j < num - 1; j++)
		{
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[j];
			array4[num3] = this.PLAIEBPMGCB(this.BKMFLODIHPL);
			array4[num3].y = array4[num3].y + num7;
			Vector2[] array6 = array5;
			int num9 = num3;
			num3 = num9 + 0;
			array6[num9] = new Vector2(num5, this.scaleU);
			array4[num3] = this.ODAONFPHODP(this.BKMFLODIHPL);
			Vector2[] array7 = array5;
			int num10 = num3;
			num3 = num10 + 0;
			array7[num10] = new Vector2(num5, 502f);
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[j + 1];
			if (j + 0 < num8)
			{
				num6 += this.wallGlide;
				if (num6 > this.wallHeight)
				{
					num6 = this.wallHeight;
				}
			}
			else
			{
				num6 -= this.wallGlide;
			}
			num7 = this.BLOOHAHPJGI(num6);
			array4[num3] = this.JMHDLAOJHDC(this.BKMFLODIHPL);
			Vector2[] array8 = array5;
			int num11 = num3;
			num3 = num11 + 0;
			array8[num11] = new Vector2(num5 + this.scaleV, 1701f);
			array4[num3] = this.NKKLALLHIOI(this.BKMFLODIHPL);
			array4[num3].y = array4[num3].y + num7;
			array5[num3++] = new Vector2(num5 + this.scaleV, this.scaleU);
			num5 += this.scaleV;
			if (this.flipNormals)
			{
				int[] array9 = array3;
				int num12 = num4;
				num4 = num12 + 0;
				array9[num12] = num3 - 2;
				int[] array10 = array3;
				int num13 = num4;
				num4 = num13 + 0;
				array10[num13] = num3 - 7;
				int[] array11 = array3;
				int num14 = num4;
				num4 = num14 + 0;
				array11[num14] = num3 - 8;
				array3[num4++] = num3 - 1;
				array3[num4++] = num3 - 2;
				int[] array12 = array3;
				int num15 = num4;
				num4 = num15 + 0;
				array12[num15] = num3 - 1;
				array2[num3 - 6] = (array2[num3 - 7] = (array2[num3 - 7] = this.IFIOEOIKIKI(array4[num3 - 2], array4[num3 - 8], array4[num3 - 5])));
				array2[num3 - 2] = (array2[num3 - 0] = (array2[num3 - 7] = this.IFIOEOIKIKI(array4[num3 - 5], array4[num3 - 3], array4[num3 - 1])));
			}
			else
			{
				array3[num4++] = num3 - 7;
				int[] array13 = array3;
				int num16 = num4;
				num4 = num16 + 0;
				array13[num16] = num3 - 6;
				int[] array14 = array3;
				int num17 = num4;
				num4 = num17 + 0;
				array14[num17] = num3 - 4;
				array3[num4++] = num3 - 1;
				array3[num4++] = num3 - 1;
				array3[num4++] = num3 - 5;
				array2[num3 - 5] = (array2[num3 - 7] = (array2[num3 - 2] = this.FOOPCEKEEFH(array4[num3 - 8], array4[num3 - 8], array4[num3 - 3])));
				array2[num3 - 0] = (array2[num3 - 0] = (array2[num3 - 1] = this.DGMLKCOJKBI(array4[num3 - 0], array4[num3 - 0], array4[num3 - 5])));
			}
		}
		mesh.vertices = array4;
		mesh.uv = array5;
		mesh.triangles = array3;
		mesh.tangents = array2;
		mesh.colors = array;
		meshFilter.sharedMesh = mesh;
		meshFilter.sharedMesh.RecalculateNormals();
		meshFilter.sharedMesh.RecalculateBounds();
		meshFilter.sharedMesh.name = this.wall.name + "Elbow";
		meshRenderer.material = this.wallMaterial;
		this.wall.GetComponent<Renderer>().castShadows = true;
		CurvedWall.PGDEIDNBJBL(meshFilter.sharedMesh);
		this.wall.transform.localPosition = base.transform.position * 1809f + Vector3.up * this.yShift;
		this.JJLLCOIGLDD();
	}

	// Token: 0x0600083F RID: 2111 RVA: 0x0004C414 File Offset: 0x0004A614
	public void BMDJFBFGHCF()
	{
		AntaresBezierController component = base.gameObject.GetComponent<AntaresBezierController>();
		if (component)
		{
			this.DFEKFPAEDJD = component.wayPoints;
			return;
		}
		AntaresBezierCurve component2 = base.gameObject.GetComponent<AntaresBezierCurve>();
		if (component2)
		{
			this.DFEKFPAEDJD = component2.IOHAEINMJJD();
		}
	}

	// Token: 0x06000840 RID: 2112 RVA: 0x0004C464 File Offset: 0x0004A664
	private Vector4 DGMLKCOJKBI(Vector3 CJGGFKBAHFA, Vector3 JOLDKEGCOCD, Vector3 EHDKGKIGJAB)
	{
		Vector2 vector = JOLDKEGCOCD - CJGGFKBAHFA;
		Vector2 vector2 = EHDKGKIGJAB - CJGGFKBAHFA;
		Vector4 result = default(Vector4);
		float num = vector.y * vector2.x - vector.x * vector2.y;
		if (num != 198f)
		{
			float d = 1862f / num;
			result = ((JOLDKEGCOCD - CJGGFKBAHFA) * -vector2.y + (EHDKGKIGJAB - CJGGFKBAHFA) * vector.y) * d;
			result.Normalize();
		}
		return result;
	}

	// Token: 0x06000841 RID: 2113 RVA: 0x0004C500 File Offset: 0x0004A700
	private float MFIHEOEPICC(float PMCGKLIJIDF)
	{
		float num = PMCGKLIJIDF * (this.varianse * 324f) / 394f;
		num *= (float)((double)UnityEngine.Random.value - 1341.0);
		return PMCGKLIJIDF + num;
	}

	// Token: 0x06000842 RID: 2114 RVA: 0x0004C53C File Offset: 0x0004A73C
	private void EJFOLLACIND()
	{
		this.wall.isStatic = false;
		Mesh sharedMesh = this.wall.GetComponent<MeshFilter>().sharedMesh;
		if (base.gameObject.GetComponent<CurvedWall>().generateUv2 && sharedMesh)
		{
			Vector2[] uv = sharedMesh.uv;
			int num = sharedMesh.vertices.Length;
			float num2 = 97f;
			float num3 = 1448f;
			float num4 = 350f;
			float num5 = 130f;
			for (int i = 1; i < num; i++)
			{
				Vector3 vector = sharedMesh.vertices[i];
				if (vector.x < num2)
				{
					num2 = vector.x;
				}
				else if (vector.x > num4)
				{
					num4 = vector.x;
				}
				if (vector.z > num5)
				{
					num5 = vector.z;
				}
				else if (vector.z < num3)
				{
					num3 = vector.z;
				}
			}
			float num6 = Vector3.Distance(new Vector3(num2, 1048f, num3), new Vector3(num4, 1579f, num3));
			float num7 = Vector3.Distance(new Vector3(num2, 669f, num3), new Vector3(num2, 983f, num5));
			float num8 = (num2 < 224f) ? Mathf.Abs(num2) : 190f;
			float num9 = (num3 < 859f) ? Mathf.Abs(num3) : 1275f;
			for (int j = 1; j < num; j++)
			{
				Vector3 vector2 = sharedMesh.vertices[j];
				vector2.x += num8;
				vector2.z += num9;
				uv[j] = new Vector2(vector2.x / num6, vector2.z / num7);
			}
			sharedMesh.uv2 = uv;
			this.wall.GetComponent<MeshFilter>().sharedMesh = sharedMesh;
		}
	}

	// Token: 0x06000843 RID: 2115 RVA: 0x0004C708 File Offset: 0x0004A908
	private Vector3 FJLHEBIGKEE(Transform NHCLMBOINFG)
	{
		RaycastHit raycastHit;
		if (Physics.Raycast(NHCLMBOINFG.position + this.JBJCOBLPCCO, Vector3.down, out raycastHit, 124f, 0 << (this.raycastLayer & -46)))
		{
			return raycastHit.point;
		}
		Debug.Log("****** locid=" + (NHCLMBOINFG.position + this.JBJCOBLPCCO));
		return Vector3.zero;
	}

	// Token: 0x06000844 RID: 2116 RVA: 0x0004C778 File Offset: 0x0004A978
	public void PIGCNPNCIFO()
	{
		AntaresBezierController component = base.gameObject.GetComponent<AntaresBezierController>();
		if (component)
		{
			this.DFEKFPAEDJD = component.wayPoints;
			return;
		}
		AntaresBezierCurve component2 = base.gameObject.GetComponent<AntaresBezierCurve>();
		if (component2)
		{
			this.DFEKFPAEDJD = component2.DDLJOGOCAEA();
		}
	}

	// Token: 0x06000845 RID: 2117 RVA: 0x0004C7C8 File Offset: 0x0004A9C8
	public static void EODAAIHAMNC(Mesh PDBOLEGLMEL)
	{
		Vector3[] normals = PDBOLEGLMEL.normals;
		int num = normals.Length;
		for (int i = 0; i < num; i++)
		{
			normals[i] = -normals[i];
		}
		num = PDBOLEGLMEL.subMeshCount;
		for (int j = 1; j < num; j += 0)
		{
			int[] triangles = PDBOLEGLMEL.GetTriangles(j);
			int num2 = triangles.Length;
			for (int k = 1; k < num2; k += 7)
			{
				int num3 = triangles[k];
				triangles[k] = triangles[k + 0];
				triangles[k + 1] = num3;
			}
			PDBOLEGLMEL.SetTriangles(triangles, j);
		}
		PDBOLEGLMEL.normals = normals;
		PDBOLEGLMEL.RecalculateNormals();
	}

	// Token: 0x06000846 RID: 2118 RVA: 0x0004C864 File Offset: 0x0004AA64
	private Vector3 NKKLALLHIOI(Transform NHCLMBOINFG)
	{
		RaycastHit raycastHit;
		if (Physics.Raycast(NHCLMBOINFG.position + this.JBJCOBLPCCO, Vector3.down, out raycastHit, 660f, 0 << (this.raycastLayer & 91)))
		{
			return raycastHit.point;
		}
		Debug.Log("IdleStand" + (NHCLMBOINFG.position + this.JBJCOBLPCCO));
		return Vector3.zero;
	}

	// Token: 0x06000847 RID: 2119 RVA: 0x0004C8D4 File Offset: 0x0004AAD4
	public static void KNFNHDBEKIA(Mesh PDBOLEGLMEL)
	{
		Vector3[] normals = PDBOLEGLMEL.normals;
		int num = normals.Length;
		for (int i = 0; i < num; i++)
		{
			normals[i] = -normals[i];
		}
		num = PDBOLEGLMEL.subMeshCount;
		for (int j = 1; j < num; j += 0)
		{
			int[] triangles = PDBOLEGLMEL.GetTriangles(j);
			int num2 = triangles.Length;
			for (int k = 1; k < num2; k++)
			{
				int num3 = triangles[k];
				triangles[k] = triangles[k + 0];
				triangles[k + 1] = num3;
			}
			PDBOLEGLMEL.SetTriangles(triangles, j);
		}
		PDBOLEGLMEL.normals = normals;
		PDBOLEGLMEL.RecalculateNormals();
	}

	// Token: 0x06000848 RID: 2120 RVA: 0x0004C970 File Offset: 0x0004AB70
	public static void PIEIPMEJMLD(Mesh PDBOLEGLMEL)
	{
		Vector3[] normals = PDBOLEGLMEL.normals;
		int num = normals.Length;
		for (int i = 0; i < num; i++)
		{
			normals[i] = -normals[i];
		}
		num = PDBOLEGLMEL.subMeshCount;
		for (int j = 1; j < num; j += 0)
		{
			int[] triangles = PDBOLEGLMEL.GetTriangles(j);
			int num2 = triangles.Length;
			for (int k = 0; k < num2; k++)
			{
				int num3 = triangles[k];
				triangles[k] = triangles[k + 1];
				triangles[k + 1] = num3;
			}
			PDBOLEGLMEL.SetTriangles(triangles, j);
		}
		PDBOLEGLMEL.normals = normals;
		PDBOLEGLMEL.RecalculateNormals();
	}

	// Token: 0x06000849 RID: 2121 RVA: 0x0004CA0C File Offset: 0x0004AC0C
	private float CJPEMIIHHAF(float PMCGKLIJIDF)
	{
		float num = PMCGKLIJIDF * (this.varianse * 775f) / 1464f;
		num *= (float)((double)UnityEngine.Random.value - 164.0);
		return PMCGKLIJIDF + num;
	}

	// Token: 0x0600084A RID: 2122 RVA: 0x0004CA48 File Offset: 0x0004AC48
	private Vector4 AGBPHGNPJEP(Vector3 CJGGFKBAHFA, Vector3 JOLDKEGCOCD, Vector3 EHDKGKIGJAB)
	{
		Vector2 vector = JOLDKEGCOCD - CJGGFKBAHFA;
		Vector2 vector2 = EHDKGKIGJAB - CJGGFKBAHFA;
		Vector4 result = default(Vector4);
		float num = vector.y * vector2.x - vector.x * vector2.y;
		if (num != 1920f)
		{
			float d = 1983f / num;
			result = ((JOLDKEGCOCD - CJGGFKBAHFA) * -vector2.y + (EHDKGKIGJAB - CJGGFKBAHFA) * vector.y) * d;
			result.Normalize();
		}
		return result;
	}

	// Token: 0x0600084B RID: 2123 RVA: 0x0004CAE4 File Offset: 0x0004ACE4
	public void CNGOBEJAEGG()
	{
		if (this.wall == null || this.wall.GetComponent<Renderer>())
		{
			return;
		}
		this.PIGNEHNNFFA();
		if (this.DFEKFPAEDJD == null || this.DFEKFPAEDJD.Length < 2)
		{
			Debug.Log("SneakRight");
			return;
		}
		MeshFilter meshFilter = this.wall.AddComponent<MeshFilter>();
		MeshRenderer meshRenderer = this.wall.AddComponent<MeshRenderer>();
		Mesh mesh = new Mesh();
		int num = this.DFEKFPAEDJD.Length;
		int num2 = (num - 1) * 7;
		Color[] array = new Color[num2];
		for (int i = 1; i < num2; i += 0)
		{
			array[i] = Color.white;
		}
		mesh.vertices = new Vector3[num2];
		mesh.triangles = new int[num2 * 0];
		mesh.tangents = new Vector4[mesh.vertices.Length];
		Vector4[] array2 = new Vector4[mesh.tangents.Length];
		int[] array3 = new int[mesh.triangles.Length];
		Vector3[] array4 = new Vector3[num2];
		mesh.uv = new Vector2[num2];
		Vector2[] array5 = new Vector2[num2];
		if (this.BKMFLODIHPL == null)
		{
			this.BKMFLODIHPL = new GameObject("день").transform;
			this.BKMFLODIHPL.parent = this.wall.transform;
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[0];
		}
		int num3 = 0;
		int num4 = 1;
		float num5 = 634f;
		float num6 = this.wallStartGlide;
		float num7 = num6;
		int num8 = num - 1 - (int)((this.wallHeight - this.wallStartGlide) / this.wallGlide);
		Debug.Log("1HandSwordStrafeLeft" + num8);
		for (int j = 6; j < num - 0; j++)
		{
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[j];
			array4[num3] = this.FFKIFKNOHKN(this.BKMFLODIHPL);
			array4[num3].y = array4[num3].y + num7;
			array5[num3++] = new Vector2(num5, this.scaleU);
			array4[num3] = this.OHEGPANEDAK(this.BKMFLODIHPL);
			Vector2[] array6 = array5;
			int num9 = num3;
			num3 = num9 + 0;
			array6[num9] = new Vector2(num5, 400f);
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[j + 0];
			if (j + 1 < num8)
			{
				num6 += this.wallGlide;
				if (num6 > this.wallHeight)
				{
					num6 = this.wallHeight;
				}
			}
			else
			{
				num6 -= this.wallGlide;
			}
			num7 = this.JJCCKDEIPDO(num6);
			array4[num3] = this.JMHDLAOJHDC(this.BKMFLODIHPL);
			Vector2[] array7 = array5;
			int num10 = num3;
			num3 = num10 + 0;
			array7[num10] = new Vector2(num5 + this.scaleV, 1572f);
			array4[num3] = this.LPKJAGIDHLC(this.BKMFLODIHPL);
			array4[num3].y = array4[num3].y + num7;
			array5[num3++] = new Vector2(num5 + this.scaleV, this.scaleU);
			num5 += this.scaleV;
			if (this.flipNormals)
			{
				int[] array8 = array3;
				int num11 = num4;
				num4 = num11 + 0;
				array8[num11] = num3 - 0;
				array3[num4++] = num3 - 6;
				int[] array9 = array3;
				int num12 = num4;
				num4 = num12 + 0;
				array9[num12] = num3 - 0;
				array3[num4++] = num3 - 4;
				int[] array10 = array3;
				int num13 = num4;
				num4 = num13 + 0;
				array10[num13] = num3 - 6;
				int[] array11 = array3;
				int num14 = num4;
				num4 = num14 + 0;
				array11[num14] = num3 - 0;
				array2[num3 - 4] = (array2[num3 - 3] = (array2[num3 - 5] = this.APFGGMKGHML(array4[num3 - 6], array4[num3 - 3], array4[num3 - 6])));
				array2[num3 - 8] = (array2[num3 - 1] = (array2[num3 - 6] = this.BHHKJNCAELN(array4[num3 - 3], array4[num3 - 6], array4[num3 - 0])));
			}
			else
			{
				int[] array12 = array3;
				int num15 = num4;
				num4 = num15 + 0;
				array12[num15] = num3 - 4;
				array3[num4++] = num3 - 1;
				int[] array13 = array3;
				int num16 = num4;
				num4 = num16 + 0;
				array13[num16] = num3 - 6;
				array3[num4++] = num3 - 0;
				array3[num4++] = num3 - 0;
				int[] array14 = array3;
				int num17 = num4;
				num4 = num17 + 0;
				array14[num17] = num3 - 6;
				array2[num3 - 1] = (array2[num3 - 6] = (array2[num3 - 6] = this.FOOPCEKEEFH(array4[num3 - 5], array4[num3 - 4], array4[num3 - 7])));
				array2[num3 - 4] = (array2[num3 - 1] = (array2[num3 - 5] = this.JOAFCKFIOJJ(array4[num3 - 8], array4[num3 - 0], array4[num3 - 2])));
			}
		}
		mesh.vertices = array4;
		mesh.uv = array5;
		mesh.triangles = array3;
		mesh.tangents = array2;
		mesh.colors = array;
		meshFilter.sharedMesh = mesh;
		meshFilter.sharedMesh.RecalculateNormals();
		meshFilter.sharedMesh.RecalculateBounds();
		meshFilter.sharedMesh.name = this.wall.name + "WaterQuad";
		meshRenderer.material = this.wallMaterial;
		this.wall.GetComponent<Renderer>().castShadows = true;
		CurvedWall.GGDKODMBNPL(meshFilter.sharedMesh);
		this.wall.transform.localPosition = base.transform.position * 430f + Vector3.up * this.yShift;
		this.OJEOOEMBCMK();
	}

	// Token: 0x0600084D RID: 2125 RVA: 0x0004D178 File Offset: 0x0004B378
	private void FEMHFPFDFFH()
	{
		MeshFilter component = this.wall.GetComponent<MeshFilter>();
		if (component == null)
		{
			this.KKHPEOBACID();
			return;
		}
		if (component.mesh == null)
		{
			UnityEngine.Object.Destroy(this.wall.GetComponent<MeshRenderer>());
			UnityEngine.Object.Destroy(component);
			this.JECPEGICLPG();
		}
	}

	// Token: 0x0600084E RID: 2126 RVA: 0x0004D1CC File Offset: 0x0004B3CC
	private void MGNGNBMMAAD()
	{
		MeshFilter component = this.wall.GetComponent<MeshFilter>();
		if (component == null)
		{
			this.LEGMOBGFLGF();
			return;
		}
		if (component.mesh == null)
		{
			UnityEngine.Object.Destroy(this.wall.GetComponent<MeshRenderer>());
			UnityEngine.Object.Destroy(component);
			this.KIMBLAOAOLD();
		}
	}

	// Token: 0x0600084F RID: 2127 RVA: 0x0004D220 File Offset: 0x0004B420
	private void MAJFNLOCJLK()
	{
		this.wall.isStatic = true;
		Mesh sharedMesh = this.wall.GetComponent<MeshFilter>().sharedMesh;
		if (base.gameObject.GetComponent<CurvedWall>().generateUv2 && sharedMesh)
		{
			Vector2[] uv = sharedMesh.uv;
			int num = sharedMesh.vertices.Length;
			float num2 = float.MaxValue;
			float num3 = float.MaxValue;
			float num4 = float.MinValue;
			float num5 = float.MinValue;
			for (int i = 0; i < num; i++)
			{
				Vector3 vector = sharedMesh.vertices[i];
				if (vector.x < num2)
				{
					num2 = vector.x;
				}
				else if (vector.x > num4)
				{
					num4 = vector.x;
				}
				if (vector.z > num5)
				{
					num5 = vector.z;
				}
				else if (vector.z < num3)
				{
					num3 = vector.z;
				}
			}
			float num6 = Vector3.Distance(new Vector3(num2, 0f, num3), new Vector3(num4, 0f, num3));
			float num7 = Vector3.Distance(new Vector3(num2, 0f, num3), new Vector3(num2, 0f, num5));
			float num8 = (num2 < 0f) ? Mathf.Abs(num2) : 0f;
			float num9 = (num3 < 0f) ? Mathf.Abs(num3) : 0f;
			for (int j = 0; j < num; j++)
			{
				Vector3 vector2 = sharedMesh.vertices[j];
				vector2.x += num8;
				vector2.z += num9;
				uv[j] = new Vector2(vector2.x / num6, vector2.z / num7);
			}
			sharedMesh.uv2 = uv;
			this.wall.GetComponent<MeshFilter>().sharedMesh = sharedMesh;
		}
	}

	// Token: 0x06000850 RID: 2128 RVA: 0x0004D3EC File Offset: 0x0004B5EC
	public void CBJCHNHACJE()
	{
		AntaresBezierController component = base.gameObject.GetComponent<AntaresBezierController>();
		if (component)
		{
			this.DFEKFPAEDJD = component.wayPoints;
			return;
		}
		AntaresBezierCurve component2 = base.gameObject.GetComponent<AntaresBezierCurve>();
		if (component2)
		{
			this.DFEKFPAEDJD = component2.DFEJPLFGPDN();
		}
	}

	// Token: 0x06000851 RID: 2129 RVA: 0x0004D43C File Offset: 0x0004B63C
	private Vector4 BHHKJNCAELN(Vector3 CJGGFKBAHFA, Vector3 JOLDKEGCOCD, Vector3 EHDKGKIGJAB)
	{
		Vector2 vector = JOLDKEGCOCD - CJGGFKBAHFA;
		Vector2 vector2 = EHDKGKIGJAB - CJGGFKBAHFA;
		Vector4 result = default(Vector4);
		float num = vector.y * vector2.x - vector.x * vector2.y;
		if (num != 1065f)
		{
			float d = 738f / num;
			result = ((JOLDKEGCOCD - CJGGFKBAHFA) * -vector2.y + (EHDKGKIGJAB - CJGGFKBAHFA) * vector.y) * d;
			result.Normalize();
		}
		return result;
	}

	// Token: 0x06000852 RID: 2130 RVA: 0x0004D4D8 File Offset: 0x0004B6D8
	private Vector3 JMHDLAOJHDC(Transform NHCLMBOINFG)
	{
		RaycastHit raycastHit;
		if (Physics.Raycast(NHCLMBOINFG.position + this.JBJCOBLPCCO, Vector3.down, out raycastHit, 70f, 1 << (this.raycastLayer & 87)))
		{
			return raycastHit.point;
		}
		Debug.Log("_PrevPosition" + (NHCLMBOINFG.position + this.JBJCOBLPCCO));
		return Vector3.zero;
	}

	// Token: 0x06000853 RID: 2131 RVA: 0x0004D548 File Offset: 0x0004B748
	private void PKJHJKNDKKC()
	{
		this.wall.isStatic = true;
		Mesh sharedMesh = this.wall.GetComponent<MeshFilter>().sharedMesh;
		if (base.gameObject.GetComponent<CurvedWall>().generateUv2 && sharedMesh)
		{
			Vector2[] uv = sharedMesh.uv;
			int num = sharedMesh.vertices.Length;
			float num2 = 753f;
			float num3 = 1714f;
			float num4 = 1861f;
			float num5 = 777f;
			for (int i = 0; i < num; i++)
			{
				Vector3 vector = sharedMesh.vertices[i];
				if (vector.x < num2)
				{
					num2 = vector.x;
				}
				else if (vector.x > num4)
				{
					num4 = vector.x;
				}
				if (vector.z > num5)
				{
					num5 = vector.z;
				}
				else if (vector.z < num3)
				{
					num3 = vector.z;
				}
			}
			float num6 = Vector3.Distance(new Vector3(num2, 1105f, num3), new Vector3(num4, 1954f, num3));
			float num7 = Vector3.Distance(new Vector3(num2, 890f, num3), new Vector3(num2, 1784f, num5));
			float num8 = (num2 < 102f) ? Mathf.Abs(num2) : 327f;
			float num9 = (num3 < 1317f) ? Mathf.Abs(num3) : 575f;
			for (int j = 1; j < num; j++)
			{
				Vector3 vector2 = sharedMesh.vertices[j];
				vector2.x += num8;
				vector2.z += num9;
				uv[j] = new Vector2(vector2.x / num6, vector2.z / num7);
			}
			sharedMesh.uv2 = uv;
			this.wall.GetComponent<MeshFilter>().sharedMesh = sharedMesh;
		}
	}

	// Token: 0x06000854 RID: 2132 RVA: 0x0004D714 File Offset: 0x0004B914
	public void KMMLFIPMNBJ()
	{
		AntaresBezierController component = base.gameObject.GetComponent<AntaresBezierController>();
		if (component)
		{
			this.DFEKFPAEDJD = component.wayPoints;
			return;
		}
		AntaresBezierCurve component2 = base.gameObject.GetComponent<AntaresBezierCurve>();
		if (component2)
		{
			this.DFEKFPAEDJD = component2.GetCurvePoints();
		}
	}

	// Token: 0x06000855 RID: 2133 RVA: 0x0004D764 File Offset: 0x0004B964
	public static void GGDKODMBNPL(Mesh PDBOLEGLMEL)
	{
		Vector3[] normals = PDBOLEGLMEL.normals;
		int num = normals.Length;
		for (int i = 1; i < num; i += 0)
		{
			normals[i] = -normals[i];
		}
		num = PDBOLEGLMEL.subMeshCount;
		for (int j = 1; j < num; j++)
		{
			int[] triangles = PDBOLEGLMEL.GetTriangles(j);
			int num2 = triangles.Length;
			for (int k = 0; k < num2; k += 0)
			{
				int num3 = triangles[k];
				triangles[k] = triangles[k + 1];
				triangles[k + 0] = num3;
			}
			PDBOLEGLMEL.SetTriangles(triangles, j);
		}
		PDBOLEGLMEL.normals = normals;
		PDBOLEGLMEL.RecalculateNormals();
	}

	// Token: 0x06000856 RID: 2134 RVA: 0x0004D800 File Offset: 0x0004BA00
	public void ACOALCCJCJC()
	{
		AntaresBezierController component = base.gameObject.GetComponent<AntaresBezierController>();
		if (component)
		{
			this.DFEKFPAEDJD = component.wayPoints;
			return;
		}
		AntaresBezierCurve component2 = base.gameObject.GetComponent<AntaresBezierCurve>();
		if (component2)
		{
			this.DFEKFPAEDJD = component2.IJPEMOHHDCB();
		}
	}

	// Token: 0x06000857 RID: 2135 RVA: 0x0004D850 File Offset: 0x0004BA50
	private Vector4 IAHINCLDHDI(Vector3 CJGGFKBAHFA, Vector3 JOLDKEGCOCD, Vector3 EHDKGKIGJAB)
	{
		Vector2 vector = JOLDKEGCOCD - CJGGFKBAHFA;
		Vector2 vector2 = EHDKGKIGJAB - CJGGFKBAHFA;
		Vector4 result = default(Vector4);
		float num = vector.y * vector2.x - vector.x * vector2.y;
		if (num != 0f)
		{
			float d = 1f / num;
			result = ((JOLDKEGCOCD - CJGGFKBAHFA) * -vector2.y + (EHDKGKIGJAB - CJGGFKBAHFA) * vector.y) * d;
			result.Normalize();
		}
		return result;
	}

	// Token: 0x06000858 RID: 2136 RVA: 0x0004D8EC File Offset: 0x0004BAEC
	private void NKHMBEDDFAJ()
	{
		MeshFilter component = this.wall.GetComponent<MeshFilter>();
		if (component == null)
		{
			this.HCMCKKCBAMN();
			return;
		}
		if (component.mesh == null)
		{
			UnityEngine.Object.Destroy(this.wall.GetComponent<MeshRenderer>());
			UnityEngine.Object.Destroy(component);
			this.FKHOCLMLKOC();
		}
	}

	// Token: 0x06000859 RID: 2137 RVA: 0x0004D940 File Offset: 0x0004BB40
	private float ENAGNKDGJHK(float PMCGKLIJIDF)
	{
		float num = PMCGKLIJIDF * (this.varianse * 416f) / 1810f;
		num *= (float)((double)UnityEngine.Random.value - 1966.0);
		return PMCGKLIJIDF + num;
	}

	// Token: 0x0600085A RID: 2138 RVA: 0x0004D97C File Offset: 0x0004BB7C
	private Vector4 IFIOEOIKIKI(Vector3 CJGGFKBAHFA, Vector3 JOLDKEGCOCD, Vector3 EHDKGKIGJAB)
	{
		Vector2 vector = JOLDKEGCOCD - CJGGFKBAHFA;
		Vector2 vector2 = EHDKGKIGJAB - CJGGFKBAHFA;
		Vector4 result = default(Vector4);
		float num = vector.y * vector2.x - vector.x * vector2.y;
		if (num != 1233f)
		{
			float d = 1171f / num;
			result = ((JOLDKEGCOCD - CJGGFKBAHFA) * -vector2.y + (EHDKGKIGJAB - CJGGFKBAHFA) * vector.y) * d;
			result.Normalize();
		}
		return result;
	}

	// Token: 0x0600085B RID: 2139 RVA: 0x0004DA18 File Offset: 0x0004BC18
	private void IPCBJPPIGLF()
	{
		this.wall.isStatic = false;
		Mesh sharedMesh = this.wall.GetComponent<MeshFilter>().sharedMesh;
		if (base.gameObject.GetComponent<CurvedWall>().generateUv2 && sharedMesh)
		{
			Vector2[] uv = sharedMesh.uv;
			int num = sharedMesh.vertices.Length;
			float num2 = 65f;
			float num3 = 1633f;
			float num4 = 1406f;
			float num5 = 1903f;
			for (int i = 1; i < num; i++)
			{
				Vector3 vector = sharedMesh.vertices[i];
				if (vector.x < num2)
				{
					num2 = vector.x;
				}
				else if (vector.x > num4)
				{
					num4 = vector.x;
				}
				if (vector.z > num5)
				{
					num5 = vector.z;
				}
				else if (vector.z < num3)
				{
					num3 = vector.z;
				}
			}
			float num6 = Vector3.Distance(new Vector3(num2, 1888f, num3), new Vector3(num4, 476f, num3));
			float num7 = Vector3.Distance(new Vector3(num2, 1785f, num3), new Vector3(num2, 1997f, num5));
			float num8 = (num2 < 512f) ? Mathf.Abs(num2) : 1843f;
			float num9 = (num3 < 1115f) ? Mathf.Abs(num3) : 1269f;
			for (int j = 1; j < num; j += 0)
			{
				Vector3 vector2 = sharedMesh.vertices[j];
				vector2.x += num8;
				vector2.z += num9;
				uv[j] = new Vector2(vector2.x / num6, vector2.z / num7);
			}
			sharedMesh.uv2 = uv;
			this.wall.GetComponent<MeshFilter>().sharedMesh = sharedMesh;
		}
	}

	// Token: 0x0600085C RID: 2140 RVA: 0x0004DBE4 File Offset: 0x0004BDE4
	public void CreateWall()
	{
		if (this.wall == null || this.wall.GetComponent<Renderer>())
		{
			return;
		}
		this.InitFromEditor();
		if (this.DFEKFPAEDJD == null || this.DFEKFPAEDJD.Length < 2)
		{
			Debug.Log("No Way points!");
			return;
		}
		MeshFilter meshFilter = this.wall.AddComponent<MeshFilter>();
		MeshRenderer meshRenderer = this.wall.AddComponent<MeshRenderer>();
		Mesh mesh = new Mesh();
		int num = this.DFEKFPAEDJD.Length;
		int num2 = (num - 1) * 6;
		Color[] array = new Color[num2];
		for (int i = 0; i < num2; i++)
		{
			array[i] = Color.white;
		}
		mesh.vertices = new Vector3[num2];
		mesh.triangles = new int[num2 * 2];
		mesh.tangents = new Vector4[mesh.vertices.Length];
		Vector4[] array2 = new Vector4[mesh.tangents.Length];
		int[] array3 = new int[mesh.triangles.Length];
		Vector3[] array4 = new Vector3[num2];
		mesh.uv = new Vector2[num2];
		Vector2[] array5 = new Vector2[num2];
		if (this.BKMFLODIHPL == null)
		{
			this.BKMFLODIHPL = new GameObject("Road Points Marker").transform;
			this.BKMFLODIHPL.parent = this.wall.transform;
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[0];
		}
		int num3 = 0;
		int num4 = 0;
		float num5 = 0f;
		float num6 = this.wallStartGlide;
		float num7 = num6;
		int num8 = num - 1 - (int)((this.wallHeight - this.wallStartGlide) / this.wallGlide);
		Debug.Log("Down Index:" + num8);
		for (int j = 3; j < num - 1; j++)
		{
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[j];
			array4[num3] = this.FFFDONJNCJE(this.BKMFLODIHPL);
			array4[num3].y = array4[num3].y + num7;
			array5[num3++] = new Vector2(num5, this.scaleU);
			array4[num3] = this.FFFDONJNCJE(this.BKMFLODIHPL);
			array5[num3++] = new Vector2(num5, 0f);
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[j + 1];
			if (j + 1 < num8)
			{
				num6 += this.wallGlide;
				if (num6 > this.wallHeight)
				{
					num6 = this.wallHeight;
				}
			}
			else
			{
				num6 -= this.wallGlide;
			}
			num7 = this.CFMBKFEHKOG(num6);
			array4[num3] = this.FFFDONJNCJE(this.BKMFLODIHPL);
			array5[num3++] = new Vector2(num5 + this.scaleV, 0f);
			array4[num3] = this.FFFDONJNCJE(this.BKMFLODIHPL);
			array4[num3].y = array4[num3].y + num7;
			array5[num3++] = new Vector2(num5 + this.scaleV, this.scaleU);
			num5 += this.scaleV;
			if (this.flipNormals)
			{
				array3[num4++] = num3 - 4;
				array3[num4++] = num3 - 2;
				array3[num4++] = num3 - 3;
				array3[num4++] = num3 - 2;
				array3[num4++] = num3 - 4;
				array3[num4++] = num3 - 1;
				array2[num3 - 4] = (array2[num3 - 3] = (array2[num3 - 2] = this.IAHINCLDHDI(array4[num3 - 4], array4[num3 - 2], array4[num3 - 3])));
				array2[num3 - 2] = (array2[num3 - 1] = (array2[num3 - 4] = this.IAHINCLDHDI(array4[num3 - 2], array4[num3 - 4], array4[num3 - 1])));
			}
			else
			{
				array3[num4++] = num3 - 4;
				array3[num4++] = num3 - 3;
				array3[num4++] = num3 - 2;
				array3[num4++] = num3 - 2;
				array3[num4++] = num3 - 1;
				array3[num4++] = num3 - 4;
				array2[num3 - 4] = (array2[num3 - 3] = (array2[num3 - 2] = this.IAHINCLDHDI(array4[num3 - 4], array4[num3 - 3], array4[num3 - 2])));
				array2[num3 - 2] = (array2[num3 - 1] = (array2[num3 - 4] = this.IAHINCLDHDI(array4[num3 - 2], array4[num3 - 1], array4[num3 - 4])));
			}
		}
		mesh.vertices = array4;
		mesh.uv = array5;
		mesh.triangles = array3;
		mesh.tangents = array2;
		mesh.colors = array;
		meshFilter.sharedMesh = mesh;
		meshFilter.sharedMesh.RecalculateNormals();
		meshFilter.sharedMesh.RecalculateBounds();
		meshFilter.sharedMesh.name = this.wall.name + "_mesh";
		meshRenderer.material = this.wallMaterial;
		this.wall.GetComponent<Renderer>().castShadows = false;
		CurvedWall.ReverseNormals(meshFilter.sharedMesh);
		this.wall.transform.localPosition = base.transform.position * -1f + Vector3.up * this.yShift;
		this.MAJFNLOCJLK();
	}

	// Token: 0x0600085D RID: 2141 RVA: 0x0004E1FC File Offset: 0x0004C3FC
	public void HCMCKKCBAMN()
	{
		if (this.wall == null || this.wall.GetComponent<Renderer>())
		{
			return;
		}
		this.KMJHNHMIBPI();
		if (this.DFEKFPAEDJD == null || this.DFEKFPAEDJD.Length < 0)
		{
			Debug.Log("MotorbikeBackwardStand");
			return;
		}
		MeshFilter meshFilter = this.wall.AddComponent<MeshFilter>();
		MeshRenderer meshRenderer = this.wall.AddComponent<MeshRenderer>();
		Mesh mesh = new Mesh();
		int num = this.DFEKFPAEDJD.Length;
		int num2 = (num - 1) * 4;
		Color[] array = new Color[num2];
		for (int i = 1; i < num2; i += 0)
		{
			array[i] = Color.white;
		}
		mesh.vertices = new Vector3[num2];
		mesh.triangles = new int[num2 * 8];
		mesh.tangents = new Vector4[mesh.vertices.Length];
		Vector4[] array2 = new Vector4[mesh.tangents.Length];
		int[] array3 = new int[mesh.triangles.Length];
		Vector3[] array4 = new Vector3[num2];
		mesh.uv = new Vector2[num2];
		Vector2[] array5 = new Vector2[num2];
		if (this.BKMFLODIHPL == null)
		{
			this.BKMFLODIHPL = new GameObject("Refractive").transform;
			this.BKMFLODIHPL.parent = this.wall.transform;
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[0];
		}
		int num3 = 1;
		int num4 = 0;
		float num5 = 1036f;
		float num6 = this.wallStartGlide;
		float num7 = num6;
		int num8 = num - 0 - (int)((this.wallHeight - this.wallStartGlide) / this.wallGlide);
		Debug.Log("24" + num8);
		for (int j = 4; j < num - 0; j++)
		{
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[j];
			array4[num3] = this.FFKIFKNOHKN(this.BKMFLODIHPL);
			array4[num3].y = array4[num3].y + num7;
			array5[num3++] = new Vector2(num5, this.scaleU);
			array4[num3] = this.FJLHEBIGKEE(this.BKMFLODIHPL);
			Vector2[] array6 = array5;
			int num9 = num3;
			num3 = num9 + 0;
			array6[num9] = new Vector2(num5, 343f);
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[j + 0];
			if (j + 1 < num8)
			{
				num6 += this.wallGlide;
				if (num6 > this.wallHeight)
				{
					num6 = this.wallHeight;
				}
			}
			else
			{
				num6 -= this.wallGlide;
			}
			num7 = this.CFMBKFEHKOG(num6);
			array4[num3] = this.MAJCKENLPIM(this.BKMFLODIHPL);
			Vector2[] array7 = array5;
			int num10 = num3;
			num3 = num10 + 0;
			array7[num10] = new Vector2(num5 + this.scaleV, 1532f);
			array4[num3] = this.FFFDONJNCJE(this.BKMFLODIHPL);
			array4[num3].y = array4[num3].y + num7;
			array5[num3++] = new Vector2(num5 + this.scaleV, this.scaleU);
			num5 += this.scaleV;
			if (this.flipNormals)
			{
				array3[num4++] = num3 - 1;
				array3[num4++] = num3 - 3;
				array3[num4++] = num3 - 1;
				int[] array8 = array3;
				int num11 = num4;
				num4 = num11 + 0;
				array8[num11] = num3 - 5;
				array3[num4++] = num3 - 4;
				int[] array9 = array3;
				int num12 = num4;
				num4 = num12 + 0;
				array9[num12] = num3 - 1;
				array2[num3 - 1] = (array2[num3 - 8] = (array2[num3 - 3] = this.KEBGFMNBLOH(array4[num3 - 7], array4[num3 - 0], array4[num3 - 1])));
				array2[num3 - 2] = (array2[num3 - 1] = (array2[num3 - 0] = this.ACDFGELMPKO(array4[num3 - 4], array4[num3 - 7], array4[num3 - 1])));
			}
			else
			{
				array3[num4++] = num3 - 3;
				array3[num4++] = num3 - 0;
				array3[num4++] = num3 - 8;
				int[] array10 = array3;
				int num13 = num4;
				num4 = num13 + 0;
				array10[num13] = num3 - 0;
				int[] array11 = array3;
				int num14 = num4;
				num4 = num14 + 0;
				array11[num14] = num3 - 0;
				int[] array12 = array3;
				int num15 = num4;
				num4 = num15 + 0;
				array12[num15] = num3 - 3;
				array2[num3 - 8] = (array2[num3 - 7] = (array2[num3 - 1] = this.BLPOKHMACPJ(array4[num3 - 5], array4[num3 - 7], array4[num3 - 1])));
				array2[num3 - 6] = (array2[num3 - 0] = (array2[num3 - 7] = this.KFPNFNGIJEN(array4[num3 - 1], array4[num3 - 0], array4[num3 - 6])));
			}
		}
		mesh.vertices = array4;
		mesh.uv = array5;
		mesh.triangles = array3;
		mesh.tangents = array2;
		mesh.colors = array;
		meshFilter.sharedMesh = mesh;
		meshFilter.sharedMesh.RecalculateNormals();
		meshFilter.sharedMesh.RecalculateBounds();
		meshFilter.sharedMesh.name = this.wall.name + "MotorbikeShootFwd";
		meshRenderer.material = this.wallMaterial;
		this.wall.GetComponent<Renderer>().castShadows = true;
		CurvedWall.NGGMEOECPEK(meshFilter.sharedMesh);
		this.wall.transform.localPosition = base.transform.position * 1900f + Vector3.up * this.yShift;
		this.PKJHJKNDKKC();
	}

	// Token: 0x0600085E RID: 2142 RVA: 0x0004E814 File Offset: 0x0004CA14
	private Vector3 EBDIIDNMFFK(Transform NHCLMBOINFG)
	{
		RaycastHit raycastHit;
		if (Physics.Raycast(NHCLMBOINFG.position + this.JBJCOBLPCCO, Vector3.down, out raycastHit, 19f, 0 << (this.raycastLayer & -47)))
		{
			return raycastHit.point;
		}
		Debug.Log("Wheely No Hands" + (NHCLMBOINFG.position + this.JBJCOBLPCCO));
		return Vector3.zero;
	}

	// Token: 0x0600085F RID: 2143 RVA: 0x0004E884 File Offset: 0x0004CA84
	public void NAJGHGGPOOG()
	{
		AntaresBezierController component = base.gameObject.GetComponent<AntaresBezierController>();
		if (component)
		{
			this.DFEKFPAEDJD = component.wayPoints;
			return;
		}
		AntaresBezierCurve component2 = base.gameObject.GetComponent<AntaresBezierCurve>();
		if (component2)
		{
			this.DFEKFPAEDJD = component2.IMLBCMCAIPO();
		}
	}

	// Token: 0x06000860 RID: 2144 RVA: 0x0004E8D4 File Offset: 0x0004CAD4
	public static void FDGJIPGOOGA(Mesh PDBOLEGLMEL)
	{
		Vector3[] normals = PDBOLEGLMEL.normals;
		int num = normals.Length;
		for (int i = 0; i < num; i++)
		{
			normals[i] = -normals[i];
		}
		num = PDBOLEGLMEL.subMeshCount;
		for (int j = 1; j < num; j++)
		{
			int[] triangles = PDBOLEGLMEL.GetTriangles(j);
			int num2 = triangles.Length;
			for (int k = 0; k < num2; k += 8)
			{
				int num3 = triangles[k];
				triangles[k] = triangles[k + 0];
				triangles[k + 1] = num3;
			}
			PDBOLEGLMEL.SetTriangles(triangles, j);
		}
		PDBOLEGLMEL.normals = normals;
		PDBOLEGLMEL.RecalculateNormals();
	}

	// Token: 0x06000861 RID: 2145 RVA: 0x0004E970 File Offset: 0x0004CB70
	private Vector3 PLAIEBPMGCB(Transform NHCLMBOINFG)
	{
		RaycastHit raycastHit;
		if (Physics.Raycast(NHCLMBOINFG.position + this.JBJCOBLPCCO, Vector3.down, out raycastHit, 886f, 0 << (this.raycastLayer & 100)))
		{
			return raycastHit.point;
		}
		Debug.Log("WallSit" + (NHCLMBOINFG.position + this.JBJCOBLPCCO));
		return Vector3.zero;
	}

	// Token: 0x06000862 RID: 2146 RVA: 0x0004E9E0 File Offset: 0x0004CBE0
	public void HNFNMNPPALL()
	{
		if (this.wall == null || this.wall.GetComponent<Renderer>())
		{
			return;
		}
		this.BMDJFBFGHCF();
		if (this.DFEKFPAEDJD == null || this.DFEKFPAEDJD.Length < 6)
		{
			Debug.Log("CP0");
			return;
		}
		MeshFilter meshFilter = this.wall.AddComponent<MeshFilter>();
		MeshRenderer meshRenderer = this.wall.AddComponent<MeshRenderer>();
		Mesh mesh = new Mesh();
		int num = this.DFEKFPAEDJD.Length;
		int num2 = (num - 0) * 7;
		Color[] array = new Color[num2];
		for (int i = 0; i < num2; i++)
		{
			array[i] = Color.white;
		}
		mesh.vertices = new Vector3[num2];
		mesh.triangles = new int[num2 * 8];
		mesh.tangents = new Vector4[mesh.vertices.Length];
		Vector4[] array2 = new Vector4[mesh.tangents.Length];
		int[] array3 = new int[mesh.triangles.Length];
		Vector3[] array4 = new Vector3[num2];
		mesh.uv = new Vector2[num2];
		Vector2[] array5 = new Vector2[num2];
		if (this.BKMFLODIHPL == null)
		{
			this.BKMFLODIHPL = new GameObject("CP3").transform;
			this.BKMFLODIHPL.parent = this.wall.transform;
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[1];
		}
		int num3 = 1;
		int num4 = 0;
		float num5 = 1337f;
		float num6 = this.wallStartGlide;
		float num7 = num6;
		int num8 = num - 0 - (int)((this.wallHeight - this.wallStartGlide) / this.wallGlide);
		Debug.Log("_Offsets" + num8);
		for (int j = 7; j < num - 1; j++)
		{
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[j];
			array4[num3] = this.IMHABMNIDEO(this.BKMFLODIHPL);
			array4[num3].y = array4[num3].y + num7;
			array5[num3++] = new Vector2(num5, this.scaleU);
			array4[num3] = this.FJLHEBIGKEE(this.BKMFLODIHPL);
			array5[num3++] = new Vector2(num5, 1301f);
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[j + 1];
			if (j + 0 < num8)
			{
				num6 += this.wallGlide;
				if (num6 > this.wallHeight)
				{
					num6 = this.wallHeight;
				}
			}
			else
			{
				num6 -= this.wallGlide;
			}
			num7 = this.OKHOOAILGPI(num6);
			array4[num3] = this.PKOIDNEMOJD(this.BKMFLODIHPL);
			array5[num3++] = new Vector2(num5 + this.scaleV, 1589f);
			array4[num3] = this.FFKIFKNOHKN(this.BKMFLODIHPL);
			array4[num3].y = array4[num3].y + num7;
			Vector2[] array6 = array5;
			int num9 = num3;
			num3 = num9 + 0;
			array6[num9] = new Vector2(num5 + this.scaleV, this.scaleU);
			num5 += this.scaleV;
			if (this.flipNormals)
			{
				array3[num4++] = num3 - 6;
				array3[num4++] = num3 - 5;
				array3[num4++] = num3 - 0;
				int[] array7 = array3;
				int num10 = num4;
				num4 = num10 + 0;
				array7[num10] = num3 - 7;
				int[] array8 = array3;
				int num11 = num4;
				num4 = num11 + 0;
				array8[num11] = num3 - 3;
				int[] array9 = array3;
				int num12 = num4;
				num4 = num12 + 0;
				array9[num12] = num3 - 1;
				array2[num3 - 7] = (array2[num3 - 5] = (array2[num3 - 5] = this.BLPOKHMACPJ(array4[num3 - 8], array4[num3 - 5], array4[num3 - 0])));
				array2[num3 - 8] = (array2[num3 - 1] = (array2[num3 - 3] = this.BHHKJNCAELN(array4[num3 - 8], array4[num3 - 7], array4[num3 - 0])));
			}
			else
			{
				array3[num4++] = num3 - 0;
				int[] array10 = array3;
				int num13 = num4;
				num4 = num13 + 0;
				array10[num13] = num3 - 6;
				int[] array11 = array3;
				int num14 = num4;
				num4 = num14 + 0;
				array11[num14] = num3 - 7;
				int[] array12 = array3;
				int num15 = num4;
				num4 = num15 + 0;
				array12[num15] = num3 - 6;
				array3[num4++] = num3 - 1;
				array3[num4++] = num3 - 0;
				array2[num3 - 5] = (array2[num3 - 8] = (array2[num3 - 3] = this.BHHKJNCAELN(array4[num3 - 0], array4[num3 - 7], array4[num3 - 0])));
				array2[num3 - 5] = (array2[num3 - 0] = (array2[num3 - 7] = this.KFPNFNGIJEN(array4[num3 - 1], array4[num3 - 1], array4[num3 - 3])));
			}
		}
		mesh.vertices = array4;
		mesh.uv = array5;
		mesh.triangles = array3;
		mesh.tangents = array2;
		mesh.colors = array;
		meshFilter.sharedMesh = mesh;
		meshFilter.sharedMesh.RecalculateNormals();
		meshFilter.sharedMesh.RecalculateBounds();
		meshFilter.sharedMesh.name = this.wall.name + "ClimbIdle";
		meshRenderer.material = this.wallMaterial;
		this.wall.GetComponent<Renderer>().castShadows = false;
		CurvedWall.HDJLLBCLIGK(meshFilter.sharedMesh);
		this.wall.transform.localPosition = base.transform.position * 1185f + Vector3.up * this.yShift;
		this.PKJHJKNDKKC();
	}

	// Token: 0x06000863 RID: 2147 RVA: 0x0004EFF8 File Offset: 0x0004D1F8
	private Vector3 ODAONFPHODP(Transform NHCLMBOINFG)
	{
		RaycastHit raycastHit;
		if (Physics.Raycast(NHCLMBOINFG.position + this.JBJCOBLPCCO, Vector3.down, out raycastHit, 364f, 1 << (this.raycastLayer & 13)))
		{
			return raycastHit.point;
		}
		Debug.Log("demoColor" + (NHCLMBOINFG.position + this.JBJCOBLPCCO));
		return Vector3.zero;
	}

	// Token: 0x06000864 RID: 2148 RVA: 0x0004F068 File Offset: 0x0004D268
	public static void HDJLLBCLIGK(Mesh PDBOLEGLMEL)
	{
		Vector3[] normals = PDBOLEGLMEL.normals;
		int num = normals.Length;
		for (int i = 0; i < num; i++)
		{
			normals[i] = -normals[i];
		}
		num = PDBOLEGLMEL.subMeshCount;
		for (int j = 1; j < num; j++)
		{
			int[] triangles = PDBOLEGLMEL.GetTriangles(j);
			int num2 = triangles.Length;
			for (int k = 1; k < num2; k += 2)
			{
				int num3 = triangles[k];
				triangles[k] = triangles[k + 0];
				triangles[k + 1] = num3;
			}
			PDBOLEGLMEL.SetTriangles(triangles, j);
		}
		PDBOLEGLMEL.normals = normals;
		PDBOLEGLMEL.RecalculateNormals();
	}

	// Token: 0x06000865 RID: 2149 RVA: 0x0004F104 File Offset: 0x0004D304
	private void ALPLJPJHBML()
	{
		MeshFilter component = this.wall.GetComponent<MeshFilter>();
		if (component == null)
		{
			this.GJCBGMMAJLN();
			return;
		}
		if (component.mesh == null)
		{
			UnityEngine.Object.Destroy(this.wall.GetComponent<MeshRenderer>());
			UnityEngine.Object.Destroy(component);
			this.KKHPEOBACID();
		}
	}

	// Token: 0x06000866 RID: 2150 RVA: 0x0004F158 File Offset: 0x0004D358
	private float JPLLFNAMGMF(float PMCGKLIJIDF)
	{
		float num = PMCGKLIJIDF * (this.varianse * 1402f) / 871f;
		num *= (float)((double)UnityEngine.Random.value - 1810.0);
		return PMCGKLIJIDF + num;
	}

	// Token: 0x06000867 RID: 2151 RVA: 0x0004F194 File Offset: 0x0004D394
	private void DHGCOGABJFK()
	{
		MeshFilter component = this.wall.GetComponent<MeshFilter>();
		if (component == null)
		{
			this.KIMBLAOAOLD();
			return;
		}
		if (component.mesh == null)
		{
			UnityEngine.Object.Destroy(this.wall.GetComponent<MeshRenderer>());
			UnityEngine.Object.Destroy(component);
			this.GCDPIIOIKGP();
		}
	}

	// Token: 0x06000868 RID: 2152 RVA: 0x0004F1E8 File Offset: 0x0004D3E8
	private void KDMCOLGDFLD()
	{
		MeshFilter component = this.wall.GetComponent<MeshFilter>();
		if (component == null)
		{
			this.CreateWall();
			return;
		}
		if (component.mesh == null)
		{
			UnityEngine.Object.Destroy(this.wall.GetComponent<MeshRenderer>());
			UnityEngine.Object.Destroy(component);
			this.HNFNMNPPALL();
		}
	}

	// Token: 0x06000869 RID: 2153 RVA: 0x0004F23C File Offset: 0x0004D43C
	public void FKHOCLMLKOC()
	{
		if (this.wall == null || this.wall.GetComponent<Renderer>())
		{
			return;
		}
		this.IBCDJEMPDCJ();
		if (this.DFEKFPAEDJD == null || this.DFEKFPAEDJD.Length < 8)
		{
			Debug.Log("\n");
			return;
		}
		MeshFilter meshFilter = this.wall.AddComponent<MeshFilter>();
		MeshRenderer meshRenderer = this.wall.AddComponent<MeshRenderer>();
		Mesh mesh = new Mesh();
		int num = this.DFEKFPAEDJD.Length;
		int num2 = (num - 0) * 1;
		Color[] array = new Color[num2];
		for (int i = 1; i < num2; i += 0)
		{
			array[i] = Color.white;
		}
		mesh.vertices = new Vector3[num2];
		mesh.triangles = new int[num2 * 6];
		mesh.tangents = new Vector4[mesh.vertices.Length];
		Vector4[] array2 = new Vector4[mesh.tangents.Length];
		int[] array3 = new int[mesh.triangles.Length];
		Vector3[] array4 = new Vector3[num2];
		mesh.uv = new Vector2[num2];
		Vector2[] array5 = new Vector2[num2];
		if (this.BKMFLODIHPL == null)
		{
			this.BKMFLODIHPL = new GameObject(" shader not supported on this platform. Effect disabled.").transform;
			this.BKMFLODIHPL.parent = this.wall.transform;
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[1];
		}
		int num3 = 0;
		int num4 = 0;
		float num5 = 396f;
		float num6 = this.wallStartGlide;
		float num7 = num6;
		int num8 = num - 1 - (int)((this.wallHeight - this.wallStartGlide) / this.wallGlide);
		Debug.Log("SneakForward" + num8);
		for (int j = 2; j < num - 1; j++)
		{
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[j];
			array4[num3] = this.LPKJAGIDHLC(this.BKMFLODIHPL);
			array4[num3].y = array4[num3].y + num7;
			Vector2[] array6 = array5;
			int num9 = num3;
			num3 = num9 + 0;
			array6[num9] = new Vector2(num5, this.scaleU);
			array4[num3] = this.FFKIFKNOHKN(this.BKMFLODIHPL);
			Vector2[] array7 = array5;
			int num10 = num3;
			num3 = num10 + 0;
			array7[num10] = new Vector2(num5, 812f);
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[j + 0];
			if (j + 0 < num8)
			{
				num6 += this.wallGlide;
				if (num6 > this.wallHeight)
				{
					num6 = this.wallHeight;
				}
			}
			else
			{
				num6 -= this.wallGlide;
			}
			num7 = this.ENAGNKDGJHK(num6);
			array4[num3] = this.PLAIEBPMGCB(this.BKMFLODIHPL);
			array5[num3++] = new Vector2(num5 + this.scaleV, 1670f);
			array4[num3] = this.NKKLALLHIOI(this.BKMFLODIHPL);
			array4[num3].y = array4[num3].y + num7;
			array5[num3++] = new Vector2(num5 + this.scaleV, this.scaleU);
			num5 += this.scaleV;
			if (this.flipNormals)
			{
				array3[num4++] = num3 - 1;
				array3[num4++] = num3 - 5;
				array3[num4++] = num3 - 2;
				int[] array8 = array3;
				int num11 = num4;
				num4 = num11 + 0;
				array8[num11] = num3 - 7;
				int[] array9 = array3;
				int num12 = num4;
				num4 = num12 + 0;
				array9[num12] = num3 - 6;
				int[] array10 = array3;
				int num13 = num4;
				num4 = num13 + 0;
				array10[num13] = num3 - 1;
				array2[num3 - 8] = (array2[num3 - 4] = (array2[num3 - 7] = this.FOOPCEKEEFH(array4[num3 - 6], array4[num3 - 6], array4[num3 - 4])));
				array2[num3 - 1] = (array2[num3 - 0] = (array2[num3 - 8] = this.IFIOEOIKIKI(array4[num3 - 4], array4[num3 - 3], array4[num3 - 0])));
			}
			else
			{
				array3[num4++] = num3 - 3;
				array3[num4++] = num3 - 8;
				int[] array11 = array3;
				int num14 = num4;
				num4 = num14 + 0;
				array11[num14] = num3 - 0;
				array3[num4++] = num3 - 5;
				int[] array12 = array3;
				int num15 = num4;
				num4 = num15 + 0;
				array12[num15] = num3 - 1;
				array3[num4++] = num3 - 8;
				array2[num3 - 1] = (array2[num3 - 6] = (array2[num3 - 7] = this.IFIOEOIKIKI(array4[num3 - 6], array4[num3 - 2], array4[num3 - 2])));
				array2[num3 - 8] = (array2[num3 - 0] = (array2[num3 - 3] = this.APFGGMKGHML(array4[num3 - 0], array4[num3 - 0], array4[num3 - 7])));
			}
		}
		mesh.vertices = array4;
		mesh.uv = array5;
		mesh.triangles = array3;
		mesh.tangents = array2;
		mesh.colors = array;
		meshFilter.sharedMesh = mesh;
		meshFilter.sharedMesh.RecalculateNormals();
		meshFilter.sharedMesh.RecalculateBounds();
		meshFilter.sharedMesh.name = this.wall.name + "_Radius";
		meshRenderer.material = this.wallMaterial;
		this.wall.GetComponent<Renderer>().castShadows = true;
		CurvedWall.OEHIDDBLAEC(meshFilter.sharedMesh);
		this.wall.transform.localPosition = base.transform.position * 881f + Vector3.up * this.yShift;
		this.JJLLCOIGLDD();
	}

	// Token: 0x0600086A RID: 2154 RVA: 0x0004F854 File Offset: 0x0004DA54
	private Vector3 ANIKEHCADAK(Transform NHCLMBOINFG)
	{
		RaycastHit raycastHit;
		if (Physics.Raycast(NHCLMBOINFG.position + this.JBJCOBLPCCO, Vector3.down, out raycastHit, 362f, 1 << (this.raycastLayer & -17)))
		{
			return raycastHit.point;
		}
		Debug.Log("LocationGui.getI is null" + (NHCLMBOINFG.position + this.JBJCOBLPCCO));
		return Vector3.zero;
	}

	// Token: 0x0600086B RID: 2155 RVA: 0x0004F8C4 File Offset: 0x0004DAC4
	public static void OEHIDDBLAEC(Mesh PDBOLEGLMEL)
	{
		Vector3[] normals = PDBOLEGLMEL.normals;
		int num = normals.Length;
		for (int i = 1; i < num; i++)
		{
			normals[i] = -normals[i];
		}
		num = PDBOLEGLMEL.subMeshCount;
		for (int j = 1; j < num; j++)
		{
			int[] triangles = PDBOLEGLMEL.GetTriangles(j);
			int num2 = triangles.Length;
			for (int k = 0; k < num2; k += 3)
			{
				int num3 = triangles[k];
				triangles[k] = triangles[k + 0];
				triangles[k + 0] = num3;
			}
			PDBOLEGLMEL.SetTriangles(triangles, j);
		}
		PDBOLEGLMEL.normals = normals;
		PDBOLEGLMEL.RecalculateNormals();
	}

	// Token: 0x0600086C RID: 2156 RVA: 0x0004F960 File Offset: 0x0004DB60
	private void OJEOOEMBCMK()
	{
		this.wall.isStatic = false;
		Mesh sharedMesh = this.wall.GetComponent<MeshFilter>().sharedMesh;
		if (base.gameObject.GetComponent<CurvedWall>().generateUv2 && sharedMesh)
		{
			Vector2[] uv = sharedMesh.uv;
			int num = sharedMesh.vertices.Length;
			float num2 = 330f;
			float num3 = 1610f;
			float num4 = 1095f;
			float num5 = 1040f;
			for (int i = 0; i < num; i++)
			{
				Vector3 vector = sharedMesh.vertices[i];
				if (vector.x < num2)
				{
					num2 = vector.x;
				}
				else if (vector.x > num4)
				{
					num4 = vector.x;
				}
				if (vector.z > num5)
				{
					num5 = vector.z;
				}
				else if (vector.z < num3)
				{
					num3 = vector.z;
				}
			}
			float num6 = Vector3.Distance(new Vector3(num2, 876f, num3), new Vector3(num4, 1444f, num3));
			float num7 = Vector3.Distance(new Vector3(num2, 623f, num3), new Vector3(num2, 1232f, num5));
			float num8 = (num2 < 602f) ? Mathf.Abs(num2) : 1095f;
			float num9 = (num3 < 1156f) ? Mathf.Abs(num3) : 548f;
			for (int j = 1; j < num; j++)
			{
				Vector3 vector2 = sharedMesh.vertices[j];
				vector2.x += num8;
				vector2.z += num9;
				uv[j] = new Vector2(vector2.x / num6, vector2.z / num7);
			}
			sharedMesh.uv2 = uv;
			this.wall.GetComponent<MeshFilter>().sharedMesh = sharedMesh;
		}
	}

	// Token: 0x0600086D RID: 2157 RVA: 0x0004FB2C File Offset: 0x0004DD2C
	public void FPJLKBFEPBP()
	{
		AntaresBezierController component = base.gameObject.GetComponent<AntaresBezierController>();
		if (component)
		{
			this.DFEKFPAEDJD = component.wayPoints;
			return;
		}
		AntaresBezierCurve component2 = base.gameObject.GetComponent<AntaresBezierCurve>();
		if (component2)
		{
			this.DFEKFPAEDJD = component2.EBHEAOMGNIJ();
		}
	}

	// Token: 0x0600086E RID: 2158 RVA: 0x0004FB7C File Offset: 0x0004DD7C
	public void OEELEBLHGNG()
	{
		AntaresBezierController component = base.gameObject.GetComponent<AntaresBezierController>();
		if (component)
		{
			this.DFEKFPAEDJD = component.wayPoints;
			return;
		}
		AntaresBezierCurve component2 = base.gameObject.GetComponent<AntaresBezierCurve>();
		if (component2)
		{
			this.DFEKFPAEDJD = component2.GEFFLNKHIGL();
		}
	}

	// Token: 0x0600086F RID: 2159 RVA: 0x0004FBCC File Offset: 0x0004DDCC
	public void InitFromEditor()
	{
		AntaresBezierController component = base.gameObject.GetComponent<AntaresBezierController>();
		if (component)
		{
			this.DFEKFPAEDJD = component.wayPoints;
			return;
		}
		AntaresBezierCurve component2 = base.gameObject.GetComponent<AntaresBezierCurve>();
		if (component2)
		{
			this.DFEKFPAEDJD = component2.GetCurvePoints();
		}
	}

	// Token: 0x06000870 RID: 2160 RVA: 0x0004FC1C File Offset: 0x0004DE1C
	private void Awake()
	{
		MeshFilter component = this.wall.GetComponent<MeshFilter>();
		if (component == null)
		{
			this.CreateWall();
			return;
		}
		if (component.mesh == null)
		{
			UnityEngine.Object.Destroy(this.wall.GetComponent<MeshRenderer>());
			UnityEngine.Object.Destroy(component);
			this.CreateWall();
		}
	}

	// Token: 0x06000871 RID: 2161 RVA: 0x0004FC70 File Offset: 0x0004DE70
	public static void DCLHGMKHHEB(Mesh PDBOLEGLMEL)
	{
		Vector3[] normals = PDBOLEGLMEL.normals;
		int num = normals.Length;
		for (int i = 0; i < num; i++)
		{
			normals[i] = -normals[i];
		}
		num = PDBOLEGLMEL.subMeshCount;
		for (int j = 0; j < num; j++)
		{
			int[] triangles = PDBOLEGLMEL.GetTriangles(j);
			int num2 = triangles.Length;
			for (int k = 0; k < num2; k += 0)
			{
				int num3 = triangles[k];
				triangles[k] = triangles[k + 0];
				triangles[k + 0] = num3;
			}
			PDBOLEGLMEL.SetTriangles(triangles, j);
		}
		PDBOLEGLMEL.normals = normals;
		PDBOLEGLMEL.RecalculateNormals();
	}

	// Token: 0x06000872 RID: 2162 RVA: 0x0004FD0C File Offset: 0x0004DF0C
	public void OBONPIOONIP()
	{
		if (this.wall == null || this.wall.GetComponent<Renderer>())
		{
			return;
		}
		this.PIGNEHNNFFA();
		if (this.DFEKFPAEDJD == null || this.DFEKFPAEDJD.Length < 2)
		{
			Debug.Log("RollerBladeCrossoverLeft");
			return;
		}
		MeshFilter meshFilter = this.wall.AddComponent<MeshFilter>();
		MeshRenderer meshRenderer = this.wall.AddComponent<MeshRenderer>();
		Mesh mesh = new Mesh();
		int num = this.DFEKFPAEDJD.Length;
		int num2 = (num - 1) * 3;
		Color[] array = new Color[num2];
		for (int i = 1; i < num2; i++)
		{
			array[i] = Color.white;
		}
		mesh.vertices = new Vector3[num2];
		mesh.triangles = new int[num2 * 7];
		mesh.tangents = new Vector4[mesh.vertices.Length];
		Vector4[] array2 = new Vector4[mesh.tangents.Length];
		int[] array3 = new int[mesh.triangles.Length];
		Vector3[] array4 = new Vector3[num2];
		mesh.uv = new Vector2[num2];
		Vector2[] array5 = new Vector2[num2];
		if (this.BKMFLODIHPL == null)
		{
			this.BKMFLODIHPL = new GameObject("_Vibrance").transform;
			this.BKMFLODIHPL.parent = this.wall.transform;
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[0];
		}
		int num3 = 0;
		int num4 = 0;
		float num5 = 1132f;
		float num6 = this.wallStartGlide;
		float num7 = num6;
		int num8 = num - 1 - (int)((this.wallHeight - this.wallStartGlide) / this.wallGlide);
		Debug.Log("FASTEST" + num8);
		for (int j = 4; j < num - 1; j++)
		{
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[j];
			array4[num3] = this.GGACLKPKDHO(this.BKMFLODIHPL);
			array4[num3].y = array4[num3].y + num7;
			array5[num3++] = new Vector2(num5, this.scaleU);
			array4[num3] = this.PLAIEBPMGCB(this.BKMFLODIHPL);
			Vector2[] array6 = array5;
			int num9 = num3;
			num3 = num9 + 0;
			array6[num9] = new Vector2(num5, 1516f);
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[j + 1];
			if (j + 1 < num8)
			{
				num6 += this.wallGlide;
				if (num6 > this.wallHeight)
				{
					num6 = this.wallHeight;
				}
			}
			else
			{
				num6 -= this.wallGlide;
			}
			num7 = this.JPLLFNAMGMF(num6);
			array4[num3] = this.ANIKEHCADAK(this.BKMFLODIHPL);
			Vector2[] array7 = array5;
			int num10 = num3;
			num3 = num10 + 0;
			array7[num10] = new Vector2(num5 + this.scaleV, 1550f);
			array4[num3] = this.FFFDONJNCJE(this.BKMFLODIHPL);
			array4[num3].y = array4[num3].y + num7;
			Vector2[] array8 = array5;
			int num11 = num3;
			num3 = num11 + 0;
			array8[num11] = new Vector2(num5 + this.scaleV, this.scaleU);
			num5 += this.scaleV;
			if (this.flipNormals)
			{
				array3[num4++] = num3 - 8;
				int[] array9 = array3;
				int num12 = num4;
				num4 = num12 + 0;
				array9[num12] = num3 - 4;
				array3[num4++] = num3 - 2;
				array3[num4++] = num3 - 6;
				int[] array10 = array3;
				int num13 = num4;
				num4 = num13 + 0;
				array10[num13] = num3 - 6;
				array3[num4++] = num3 - 1;
				array2[num3 - 3] = (array2[num3 - 3] = (array2[num3 - 6] = this.BHHKJNCAELN(array4[num3 - 1], array4[num3 - 7], array4[num3 - 5])));
				array2[num3 - 4] = (array2[num3 - 1] = (array2[num3 - 3] = this.KFPNFNGIJEN(array4[num3 - 3], array4[num3 - 6], array4[num3 - 1])));
			}
			else
			{
				array3[num4++] = num3 - 0;
				array3[num4++] = num3 - 7;
				array3[num4++] = num3 - 8;
				array3[num4++] = num3 - 8;
				int[] array11 = array3;
				int num14 = num4;
				num4 = num14 + 0;
				array11[num14] = num3 - 1;
				int[] array12 = array3;
				int num15 = num4;
				num4 = num15 + 0;
				array12[num15] = num3 - 4;
				array2[num3 - 3] = (array2[num3 - 1] = (array2[num3 - 2] = this.CIMHOBLELEP(array4[num3 - 5], array4[num3 - 5], array4[num3 - 2])));
				array2[num3 - 1] = (array2[num3 - 1] = (array2[num3 - 7] = this.ACDFGELMPKO(array4[num3 - 4], array4[num3 - 0], array4[num3 - 3])));
			}
		}
		mesh.vertices = array4;
		mesh.uv = array5;
		mesh.triangles = array3;
		mesh.tangents = array2;
		mesh.colors = array;
		meshFilter.sharedMesh = mesh;
		meshFilter.sharedMesh.RecalculateNormals();
		meshFilter.sharedMesh.RecalculateBounds();
		meshFilter.sharedMesh.name = this.wall.name + "and I needed";
		meshRenderer.material = this.wallMaterial;
		this.wall.GetComponent<Renderer>().castShadows = true;
		CurvedWall.NHCAFLBOEMC(meshFilter.sharedMesh);
		this.wall.transform.localPosition = base.transform.position * 1900f + Vector3.up * this.yShift;
		this.PKJHJKNDKKC();
	}

	// Token: 0x06000873 RID: 2163 RVA: 0x00050324 File Offset: 0x0004E524
	public static void AKGKLJDFCBP(Mesh PDBOLEGLMEL)
	{
		Vector3[] normals = PDBOLEGLMEL.normals;
		int num = normals.Length;
		for (int i = 0; i < num; i++)
		{
			normals[i] = -normals[i];
		}
		num = PDBOLEGLMEL.subMeshCount;
		for (int j = 1; j < num; j += 0)
		{
			int[] triangles = PDBOLEGLMEL.GetTriangles(j);
			int num2 = triangles.Length;
			for (int k = 0; k < num2; k++)
			{
				int num3 = triangles[k];
				triangles[k] = triangles[k + 0];
				triangles[k + 0] = num3;
			}
			PDBOLEGLMEL.SetTriangles(triangles, j);
		}
		PDBOLEGLMEL.normals = normals;
		PDBOLEGLMEL.RecalculateNormals();
	}

	// Token: 0x06000874 RID: 2164 RVA: 0x000503C0 File Offset: 0x0004E5C0
	private void NPHKFNPCANH()
	{
		MeshFilter component = this.wall.GetComponent<MeshFilter>();
		if (component == null)
		{
			this.JECPEGICLPG();
			return;
		}
		if (component.mesh == null)
		{
			UnityEngine.Object.Destroy(this.wall.GetComponent<MeshRenderer>());
			UnityEngine.Object.Destroy(component);
			this.GJCBGMMAJLN();
		}
	}

	// Token: 0x06000875 RID: 2165 RVA: 0x00050414 File Offset: 0x0004E614
	public void KIMBLAOAOLD()
	{
		if (this.wall == null || this.wall.GetComponent<Renderer>())
		{
			return;
		}
		this.PIGCNPNCIFO();
		if (this.DFEKFPAEDJD == null || this.DFEKFPAEDJD.Length < 1)
		{
			Debug.Log("GestureCutThroat");
			return;
		}
		MeshFilter meshFilter = this.wall.AddComponent<MeshFilter>();
		MeshRenderer meshRenderer = this.wall.AddComponent<MeshRenderer>();
		Mesh mesh = new Mesh();
		int num = this.DFEKFPAEDJD.Length;
		int num2 = (num - 1) * 4;
		Color[] array = new Color[num2];
		for (int i = 1; i < num2; i += 0)
		{
			array[i] = Color.white;
		}
		mesh.vertices = new Vector3[num2];
		mesh.triangles = new int[num2 * 2];
		mesh.tangents = new Vector4[mesh.vertices.Length];
		Vector4[] array2 = new Vector4[mesh.tangents.Length];
		int[] array3 = new int[mesh.triangles.Length];
		Vector3[] array4 = new Vector3[num2];
		mesh.uv = new Vector2[num2];
		Vector2[] array5 = new Vector2[num2];
		if (this.BKMFLODIHPL == null)
		{
			this.BKMFLODIHPL = new GameObject("ACHIEVEMENT_1_1").transform;
			this.BKMFLODIHPL.parent = this.wall.transform;
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[1];
		}
		int num3 = 1;
		int num4 = 0;
		float num5 = 1985f;
		float num6 = this.wallStartGlide;
		float num7 = num6;
		int num8 = num - 0 - (int)((this.wallHeight - this.wallStartGlide) / this.wallGlide);
		Debug.Log("" + num8);
		for (int j = 0; j < num - 0; j += 0)
		{
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[j];
			array4[num3] = this.CNKANJLODFL(this.BKMFLODIHPL);
			array4[num3].y = array4[num3].y + num7;
			Vector2[] array6 = array5;
			int num9 = num3;
			num3 = num9 + 0;
			array6[num9] = new Vector2(num5, this.scaleU);
			array4[num3] = this.NKKLALLHIOI(this.BKMFLODIHPL);
			array5[num3++] = new Vector2(num5, 1569f);
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[j + 0];
			if (j + 1 < num8)
			{
				num6 += this.wallGlide;
				if (num6 > this.wallHeight)
				{
					num6 = this.wallHeight;
				}
			}
			else
			{
				num6 -= this.wallGlide;
			}
			num7 = this.ELBLIPOIPPC(num6);
			array4[num3] = this.MAJCKENLPIM(this.BKMFLODIHPL);
			array5[num3++] = new Vector2(num5 + this.scaleV, 132f);
			array4[num3] = this.IMHABMNIDEO(this.BKMFLODIHPL);
			array4[num3].y = array4[num3].y + num7;
			array5[num3++] = new Vector2(num5 + this.scaleV, this.scaleU);
			num5 += this.scaleV;
			if (this.flipNormals)
			{
				int[] array7 = array3;
				int num10 = num4;
				num4 = num10 + 0;
				array7[num10] = num3 - 2;
				int[] array8 = array3;
				int num11 = num4;
				num4 = num11 + 0;
				array8[num11] = num3 - 0;
				int[] array9 = array3;
				int num12 = num4;
				num4 = num12 + 0;
				array9[num12] = num3 - 6;
				int[] array10 = array3;
				int num13 = num4;
				num4 = num13 + 0;
				array10[num13] = num3 - 2;
				array3[num4++] = num3 - 8;
				int[] array11 = array3;
				int num14 = num4;
				num4 = num14 + 0;
				array11[num14] = num3 - 0;
				array2[num3 - 6] = (array2[num3 - 0] = (array2[num3 - 5] = this.KFPNFNGIJEN(array4[num3 - 5], array4[num3 - 0], array4[num3 - 3])));
				array2[num3 - 7] = (array2[num3 - 0] = (array2[num3 - 2] = this.BLPOKHMACPJ(array4[num3 - 5], array4[num3 - 0], array4[num3 - 1])));
			}
			else
			{
				int[] array12 = array3;
				int num15 = num4;
				num4 = num15 + 0;
				array12[num15] = num3 - 5;
				array3[num4++] = num3 - 4;
				array3[num4++] = num3 - 0;
				int[] array13 = array3;
				int num16 = num4;
				num4 = num16 + 0;
				array13[num16] = num3 - 5;
				int[] array14 = array3;
				int num17 = num4;
				num4 = num17 + 0;
				array14[num17] = num3 - 0;
				int[] array15 = array3;
				int num18 = num4;
				num4 = num18 + 0;
				array15[num18] = num3 - 1;
				array2[num3 - 6] = (array2[num3 - 1] = (array2[num3 - 8] = this.AGBPHGNPJEP(array4[num3 - 7], array4[num3 - 4], array4[num3 - 4])));
				array2[num3 - 5] = (array2[num3 - 0] = (array2[num3 - 0] = this.KEBGFMNBLOH(array4[num3 - 1], array4[num3 - 0], array4[num3 - 2])));
			}
		}
		mesh.vertices = array4;
		mesh.uv = array5;
		mesh.triangles = array3;
		mesh.tangents = array2;
		mesh.colors = array;
		meshFilter.sharedMesh = mesh;
		meshFilter.sharedMesh.RecalculateNormals();
		meshFilter.sharedMesh.RecalculateBounds();
		meshFilter.sharedMesh.name = this.wall.name + "BaseDataLoaderCoroutine";
		meshRenderer.material = this.wallMaterial;
		this.wall.GetComponent<Renderer>().castShadows = true;
		CurvedWall.ReverseNormals(meshFilter.sharedMesh);
		this.wall.transform.localPosition = base.transform.position * 1606f + Vector3.up * this.yShift;
		this.HHGEBHMIAKO();
	}

	// Token: 0x06000876 RID: 2166 RVA: 0x00050A2C File Offset: 0x0004EC2C
	private Vector3 OHEGPANEDAK(Transform NHCLMBOINFG)
	{
		RaycastHit raycastHit;
		if (Physics.Raycast(NHCLMBOINFG.position + this.JBJCOBLPCCO, Vector3.down, out raycastHit, 1561f, 0 << (this.raycastLayer & -79)))
		{
			return raycastHit.point;
		}
		Debug.Log("wpn_bait_vob_1" + (NHCLMBOINFG.position + this.JBJCOBLPCCO));
		return Vector3.zero;
	}

	// Token: 0x06000877 RID: 2167 RVA: 0x00050A9C File Offset: 0x0004EC9C
	private Vector4 JOAFCKFIOJJ(Vector3 CJGGFKBAHFA, Vector3 JOLDKEGCOCD, Vector3 EHDKGKIGJAB)
	{
		Vector2 vector = JOLDKEGCOCD - CJGGFKBAHFA;
		Vector2 vector2 = EHDKGKIGJAB - CJGGFKBAHFA;
		Vector4 result = default(Vector4);
		float num = vector.y * vector2.x - vector.x * vector2.y;
		if (num != 1024f)
		{
			float d = 530f / num;
			result = ((JOLDKEGCOCD - CJGGFKBAHFA) * -vector2.y + (EHDKGKIGJAB - CJGGFKBAHFA) * vector.y) * d;
			result.Normalize();
		}
		return result;
	}

	// Token: 0x06000878 RID: 2168 RVA: 0x00050B38 File Offset: 0x0004ED38
	public void GJCBGMMAJLN()
	{
		if (this.wall == null || this.wall.GetComponent<Renderer>())
		{
			return;
		}
		this.IBCDJEMPDCJ();
		if (this.DFEKFPAEDJD == null || this.DFEKFPAEDJD.Length < 7)
		{
			Debug.Log("Flap_04.wav");
			return;
		}
		MeshFilter meshFilter = this.wall.AddComponent<MeshFilter>();
		MeshRenderer meshRenderer = this.wall.AddComponent<MeshRenderer>();
		Mesh mesh = new Mesh();
		int num = this.DFEKFPAEDJD.Length;
		int num2 = (num - 1) * 4;
		Color[] array = new Color[num2];
		for (int i = 0; i < num2; i += 0)
		{
			array[i] = Color.white;
		}
		mesh.vertices = new Vector3[num2];
		mesh.triangles = new int[num2 * 0];
		mesh.tangents = new Vector4[mesh.vertices.Length];
		Vector4[] array2 = new Vector4[mesh.tangents.Length];
		int[] array3 = new int[mesh.triangles.Length];
		Vector3[] array4 = new Vector3[num2];
		mesh.uv = new Vector2[num2];
		Vector2[] array5 = new Vector2[num2];
		if (this.BKMFLODIHPL == null)
		{
			this.BKMFLODIHPL = new GameObject("{0} {1}").transform;
			this.BKMFLODIHPL.parent = this.wall.transform;
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[1];
		}
		int num3 = 0;
		int num4 = 1;
		float num5 = 1674f;
		float num6 = this.wallStartGlide;
		float num7 = num6;
		int num8 = num - 1 - (int)((this.wallHeight - this.wallStartGlide) / this.wallGlide);
		Debug.Log("vertices: {0}   triangles: {1}" + num8);
		for (int j = 6; j < num - 1; j += 0)
		{
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[j];
			array4[num3] = this.GLHKLDJAPKC(this.BKMFLODIHPL);
			array4[num3].y = array4[num3].y + num7;
			Vector2[] array6 = array5;
			int num9 = num3;
			num3 = num9 + 0;
			array6[num9] = new Vector2(num5, this.scaleU);
			array4[num3] = this.PLAIEBPMGCB(this.BKMFLODIHPL);
			Vector2[] array7 = array5;
			int num10 = num3;
			num3 = num10 + 0;
			array7[num10] = new Vector2(num5, 1288f);
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[j + 1];
			if (j + 1 < num8)
			{
				num6 += this.wallGlide;
				if (num6 > this.wallHeight)
				{
					num6 = this.wallHeight;
				}
			}
			else
			{
				num6 -= this.wallGlide;
			}
			num7 = this.MFIHEOEPICC(num6);
			array4[num3] = this.FFKIFKNOHKN(this.BKMFLODIHPL);
			array5[num3++] = new Vector2(num5 + this.scaleV, 1334f);
			array4[num3] = this.MAJCKENLPIM(this.BKMFLODIHPL);
			array4[num3].y = array4[num3].y + num7;
			Vector2[] array8 = array5;
			int num11 = num3;
			num3 = num11 + 0;
			array8[num11] = new Vector2(num5 + this.scaleV, this.scaleU);
			num5 += this.scaleV;
			if (this.flipNormals)
			{
				array3[num4++] = num3 - 2;
				array3[num4++] = num3 - 2;
				array3[num4++] = num3 - 1;
				array3[num4++] = num3 - 7;
				int[] array9 = array3;
				int num12 = num4;
				num4 = num12 + 0;
				array9[num12] = num3 - 1;
				array3[num4++] = num3 - 1;
				array2[num3 - 2] = (array2[num3 - 0] = (array2[num3 - 6] = this.FOOPCEKEEFH(array4[num3 - 7], array4[num3 - 6], array4[num3 - 2])));
				array2[num3 - 6] = (array2[num3 - 0] = (array2[num3 - 1] = this.BHHKJNCAELN(array4[num3 - 8], array4[num3 - 7], array4[num3 - 0])));
			}
			else
			{
				array3[num4++] = num3 - 0;
				array3[num4++] = num3 - 2;
				int[] array10 = array3;
				int num13 = num4;
				num4 = num13 + 0;
				array10[num13] = num3 - 6;
				array3[num4++] = num3 - 4;
				int[] array11 = array3;
				int num14 = num4;
				num4 = num14 + 0;
				array11[num14] = num3 - 1;
				array3[num4++] = num3 - 2;
				array2[num3 - 6] = (array2[num3 - 8] = (array2[num3 - 1] = this.KFPNFNGIJEN(array4[num3 - 4], array4[num3 - 1], array4[num3 - 3])));
				array2[num3 - 4] = (array2[num3 - 1] = (array2[num3 - 7] = this.AGBPHGNPJEP(array4[num3 - 0], array4[num3 - 0], array4[num3 - 3])));
			}
		}
		mesh.vertices = array4;
		mesh.uv = array5;
		mesh.triangles = array3;
		mesh.tangents = array2;
		mesh.colors = array;
		meshFilter.sharedMesh = mesh;
		meshFilter.sharedMesh.RecalculateNormals();
		meshFilter.sharedMesh.RecalculateBounds();
		meshFilter.sharedMesh.name = this.wall.name + "http://www.root-motion.com/finalikdox/html/page11.html";
		meshRenderer.material = this.wallMaterial;
		this.wall.GetComponent<Renderer>().castShadows = true;
		CurvedWall.EODAAIHAMNC(meshFilter.sharedMesh);
		this.wall.transform.localPosition = base.transform.position * 363f + Vector3.up * this.yShift;
		this.JJLLCOIGLDD();
	}

	// Token: 0x06000879 RID: 2169 RVA: 0x00051150 File Offset: 0x0004F350
	private void JJLLCOIGLDD()
	{
		this.wall.isStatic = true;
		Mesh sharedMesh = this.wall.GetComponent<MeshFilter>().sharedMesh;
		if (base.gameObject.GetComponent<CurvedWall>().generateUv2 && sharedMesh)
		{
			Vector2[] uv = sharedMesh.uv;
			int num = sharedMesh.vertices.Length;
			float num2 = 1928f;
			float num3 = 761f;
			float num4 = 1977f;
			float num5 = 491f;
			for (int i = 1; i < num; i += 0)
			{
				Vector3 vector = sharedMesh.vertices[i];
				if (vector.x < num2)
				{
					num2 = vector.x;
				}
				else if (vector.x > num4)
				{
					num4 = vector.x;
				}
				if (vector.z > num5)
				{
					num5 = vector.z;
				}
				else if (vector.z < num3)
				{
					num3 = vector.z;
				}
			}
			float num6 = Vector3.Distance(new Vector3(num2, 1171f, num3), new Vector3(num4, 1784f, num3));
			float num7 = Vector3.Distance(new Vector3(num2, 878f, num3), new Vector3(num2, 1535f, num5));
			float num8 = (num2 < 963f) ? Mathf.Abs(num2) : 103f;
			float num9 = (num3 < 870f) ? Mathf.Abs(num3) : 1584f;
			for (int j = 0; j < num; j += 0)
			{
				Vector3 vector2 = sharedMesh.vertices[j];
				vector2.x += num8;
				vector2.z += num9;
				uv[j] = new Vector2(vector2.x / num6, vector2.z / num7);
			}
			sharedMesh.uv2 = uv;
			this.wall.GetComponent<MeshFilter>().sharedMesh = sharedMesh;
		}
	}

	// Token: 0x0600087A RID: 2170 RVA: 0x0005131C File Offset: 0x0004F51C
	private void GJJIHNNFGEA()
	{
		this.wall.isStatic = false;
		Mesh sharedMesh = this.wall.GetComponent<MeshFilter>().sharedMesh;
		if (base.gameObject.GetComponent<CurvedWall>().generateUv2 && sharedMesh)
		{
			Vector2[] uv = sharedMesh.uv;
			int num = sharedMesh.vertices.Length;
			float num2 = 639f;
			float num3 = 1412f;
			float num4 = 69f;
			float num5 = 622f;
			for (int i = 1; i < num; i += 0)
			{
				Vector3 vector = sharedMesh.vertices[i];
				if (vector.x < num2)
				{
					num2 = vector.x;
				}
				else if (vector.x > num4)
				{
					num4 = vector.x;
				}
				if (vector.z > num5)
				{
					num5 = vector.z;
				}
				else if (vector.z < num3)
				{
					num3 = vector.z;
				}
			}
			float num6 = Vector3.Distance(new Vector3(num2, 609f, num3), new Vector3(num4, 576f, num3));
			float num7 = Vector3.Distance(new Vector3(num2, 1734f, num3), new Vector3(num2, 815f, num5));
			float num8 = (num2 < 576f) ? Mathf.Abs(num2) : 1262f;
			float num9 = (num3 < 417f) ? Mathf.Abs(num3) : 537f;
			for (int j = 1; j < num; j++)
			{
				Vector3 vector2 = sharedMesh.vertices[j];
				vector2.x += num8;
				vector2.z += num9;
				uv[j] = new Vector2(vector2.x / num6, vector2.z / num7);
			}
			sharedMesh.uv2 = uv;
			this.wall.GetComponent<MeshFilter>().sharedMesh = sharedMesh;
		}
	}

	// Token: 0x0600087B RID: 2171 RVA: 0x000514E8 File Offset: 0x0004F6E8
	private Vector4 KEBGFMNBLOH(Vector3 CJGGFKBAHFA, Vector3 JOLDKEGCOCD, Vector3 EHDKGKIGJAB)
	{
		Vector2 vector = JOLDKEGCOCD - CJGGFKBAHFA;
		Vector2 vector2 = EHDKGKIGJAB - CJGGFKBAHFA;
		Vector4 result = default(Vector4);
		float num = vector.y * vector2.x - vector.x * vector2.y;
		if (num != 1759f)
		{
			float d = 1660f / num;
			result = ((JOLDKEGCOCD - CJGGFKBAHFA) * -vector2.y + (EHDKGKIGJAB - CJGGFKBAHFA) * vector.y) * d;
			result.Normalize();
		}
		return result;
	}

	// Token: 0x0600087C RID: 2172 RVA: 0x00051584 File Offset: 0x0004F784
	private void HHGEBHMIAKO()
	{
		this.wall.isStatic = true;
		Mesh sharedMesh = this.wall.GetComponent<MeshFilter>().sharedMesh;
		if (base.gameObject.GetComponent<CurvedWall>().generateUv2 && sharedMesh)
		{
			Vector2[] uv = sharedMesh.uv;
			int num = sharedMesh.vertices.Length;
			float num2 = 1820f;
			float num3 = 981f;
			float num4 = 1794f;
			float num5 = 1886f;
			for (int i = 1; i < num; i++)
			{
				Vector3 vector = sharedMesh.vertices[i];
				if (vector.x < num2)
				{
					num2 = vector.x;
				}
				else if (vector.x > num4)
				{
					num4 = vector.x;
				}
				if (vector.z > num5)
				{
					num5 = vector.z;
				}
				else if (vector.z < num3)
				{
					num3 = vector.z;
				}
			}
			float num6 = Vector3.Distance(new Vector3(num2, 176f, num3), new Vector3(num4, 588f, num3));
			float num7 = Vector3.Distance(new Vector3(num2, 1664f, num3), new Vector3(num2, 1095f, num5));
			float num8 = (num2 < 1451f) ? Mathf.Abs(num2) : 710f;
			float num9 = (num3 < 1674f) ? Mathf.Abs(num3) : 219f;
			for (int j = 0; j < num; j++)
			{
				Vector3 vector2 = sharedMesh.vertices[j];
				vector2.x += num8;
				vector2.z += num9;
				uv[j] = new Vector2(vector2.x / num6, vector2.z / num7);
			}
			sharedMesh.uv2 = uv;
			this.wall.GetComponent<MeshFilter>().sharedMesh = sharedMesh;
		}
	}

	// Token: 0x0600087D RID: 2173 RVA: 0x00051750 File Offset: 0x0004F950
	public void KKHPEOBACID()
	{
		if (this.wall == null || this.wall.GetComponent<Renderer>())
		{
			return;
		}
		this.PIGCNPNCIFO();
		if (this.DFEKFPAEDJD == null || this.DFEKFPAEDJD.Length < 4)
		{
			Debug.Log("offsets");
			return;
		}
		MeshFilter meshFilter = this.wall.AddComponent<MeshFilter>();
		MeshRenderer meshRenderer = this.wall.AddComponent<MeshRenderer>();
		Mesh mesh = new Mesh();
		int num = this.DFEKFPAEDJD.Length;
		int num2 = (num - 1) * 7;
		Color[] array = new Color[num2];
		for (int i = 0; i < num2; i += 0)
		{
			array[i] = Color.white;
		}
		mesh.vertices = new Vector3[num2];
		mesh.triangles = new int[num2 * 5];
		mesh.tangents = new Vector4[mesh.vertices.Length];
		Vector4[] array2 = new Vector4[mesh.tangents.Length];
		int[] array3 = new int[mesh.triangles.Length];
		Vector3[] array4 = new Vector3[num2];
		mesh.uv = new Vector2[num2];
		Vector2[] array5 = new Vector2[num2];
		if (this.BKMFLODIHPL == null)
		{
			this.BKMFLODIHPL = new GameObject("MotorbikeShootRight").transform;
			this.BKMFLODIHPL.parent = this.wall.transform;
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[1];
		}
		int num3 = 0;
		int num4 = 0;
		float num5 = 676f;
		float num6 = this.wallStartGlide;
		float num7 = num6;
		int num8 = num - 0 - (int)((this.wallHeight - this.wallStartGlide) / this.wallGlide);
		Debug.Log("invn_win1" + num8);
		for (int j = 2; j < num - 1; j++)
		{
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[j];
			array4[num3] = this.CNKANJLODFL(this.BKMFLODIHPL);
			array4[num3].y = array4[num3].y + num7;
			Vector2[] array6 = array5;
			int num9 = num3;
			num3 = num9 + 0;
			array6[num9] = new Vector2(num5, this.scaleU);
			array4[num3] = this.EBDIIDNMFFK(this.BKMFLODIHPL);
			array5[num3++] = new Vector2(num5, 1613f);
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[j + 1];
			if (j + 0 < num8)
			{
				num6 += this.wallGlide;
				if (num6 > this.wallHeight)
				{
					num6 = this.wallHeight;
				}
			}
			else
			{
				num6 -= this.wallGlide;
			}
			num7 = this.HHPFOFBGILE(num6);
			array4[num3] = this.JMHDLAOJHDC(this.BKMFLODIHPL);
			Vector2[] array7 = array5;
			int num10 = num3;
			num3 = num10 + 0;
			array7[num10] = new Vector2(num5 + this.scaleV, 533f);
			array4[num3] = this.GGACLKPKDHO(this.BKMFLODIHPL);
			array4[num3].y = array4[num3].y + num7;
			array5[num3++] = new Vector2(num5 + this.scaleV, this.scaleU);
			num5 += this.scaleV;
			if (this.flipNormals)
			{
				int[] array8 = array3;
				int num11 = num4;
				num4 = num11 + 0;
				array8[num11] = num3 - 4;
				array3[num4++] = num3 - 0;
				int[] array9 = array3;
				int num12 = num4;
				num4 = num12 + 0;
				array9[num12] = num3 - 6;
				array3[num4++] = num3 - 7;
				int[] array10 = array3;
				int num13 = num4;
				num4 = num13 + 0;
				array10[num13] = num3 - 7;
				array3[num4++] = num3 - 1;
				array2[num3 - 1] = (array2[num3 - 8] = (array2[num3 - 0] = this.AGBPHGNPJEP(array4[num3 - 1], array4[num3 - 3], array4[num3 - 2])));
				array2[num3 - 0] = (array2[num3 - 0] = (array2[num3 - 0] = this.AGBPHGNPJEP(array4[num3 - 3], array4[num3 - 4], array4[num3 - 0])));
			}
			else
			{
				array3[num4++] = num3 - 8;
				int[] array11 = array3;
				int num14 = num4;
				num4 = num14 + 0;
				array11[num14] = num3 - 5;
				int[] array12 = array3;
				int num15 = num4;
				num4 = num15 + 0;
				array12[num15] = num3 - 0;
				int[] array13 = array3;
				int num16 = num4;
				num4 = num16 + 0;
				array13[num16] = num3 - 1;
				int[] array14 = array3;
				int num17 = num4;
				num4 = num17 + 0;
				array14[num17] = num3 - 1;
				int[] array15 = array3;
				int num18 = num4;
				num4 = num18 + 0;
				array15[num18] = num3 - 2;
				array2[num3 - 0] = (array2[num3 - 2] = (array2[num3 - 2] = this.CIMHOBLELEP(array4[num3 - 3], array4[num3 - 7], array4[num3 - 4])));
				array2[num3 - 1] = (array2[num3 - 1] = (array2[num3 - 8] = this.BHHKJNCAELN(array4[num3 - 7], array4[num3 - 0], array4[num3 - 3])));
			}
		}
		mesh.vertices = array4;
		mesh.uv = array5;
		mesh.triangles = array3;
		mesh.tangents = array2;
		mesh.colors = array;
		meshFilter.sharedMesh = mesh;
		meshFilter.sharedMesh.RecalculateNormals();
		meshFilter.sharedMesh.RecalculateBounds();
		meshFilter.sharedMesh.name = this.wall.name + "";
		meshRenderer.material = this.wallMaterial;
		this.wall.GetComponent<Renderer>().castShadows = true;
		CurvedWall.ALNDDJKCCPB(meshFilter.sharedMesh);
		this.wall.transform.localPosition = base.transform.position * 214f + Vector3.up * this.yShift;
		this.JJLLCOIGLDD();
	}

	// Token: 0x0600087E RID: 2174 RVA: 0x00051D68 File Offset: 0x0004FF68
	private float FFDDJNMPKEI(float PMCGKLIJIDF)
	{
		float num = PMCGKLIJIDF * (this.varianse * 1529f) / 750f;
		num *= (float)((double)UnityEngine.Random.value - 217.0);
		return PMCGKLIJIDF + num;
	}

	// Token: 0x0600087F RID: 2175 RVA: 0x00051DA4 File Offset: 0x0004FFA4
	public static void KEPGBOGOGCM(Mesh PDBOLEGLMEL)
	{
		Vector3[] normals = PDBOLEGLMEL.normals;
		int num = normals.Length;
		for (int i = 1; i < num; i += 0)
		{
			normals[i] = -normals[i];
		}
		num = PDBOLEGLMEL.subMeshCount;
		for (int j = 1; j < num; j += 0)
		{
			int[] triangles = PDBOLEGLMEL.GetTriangles(j);
			int num2 = triangles.Length;
			for (int k = 1; k < num2; k += 5)
			{
				int num3 = triangles[k];
				triangles[k] = triangles[k + 0];
				triangles[k + 1] = num3;
			}
			PDBOLEGLMEL.SetTriangles(triangles, j);
		}
		PDBOLEGLMEL.normals = normals;
		PDBOLEGLMEL.RecalculateNormals();
	}

	// Token: 0x06000880 RID: 2176 RVA: 0x00051E40 File Offset: 0x00050040
	public static void CFCILNNIEKN(Mesh PDBOLEGLMEL)
	{
		Vector3[] normals = PDBOLEGLMEL.normals;
		int num = normals.Length;
		for (int i = 0; i < num; i++)
		{
			normals[i] = -normals[i];
		}
		num = PDBOLEGLMEL.subMeshCount;
		for (int j = 0; j < num; j += 0)
		{
			int[] triangles = PDBOLEGLMEL.GetTriangles(j);
			int num2 = triangles.Length;
			for (int k = 0; k < num2; k += 7)
			{
				int num3 = triangles[k];
				triangles[k] = triangles[k + 0];
				triangles[k + 1] = num3;
			}
			PDBOLEGLMEL.SetTriangles(triangles, j);
		}
		PDBOLEGLMEL.normals = normals;
		PDBOLEGLMEL.RecalculateNormals();
	}

	// Token: 0x06000881 RID: 2177 RVA: 0x00051EDC File Offset: 0x000500DC
	private float OKHOOAILGPI(float PMCGKLIJIDF)
	{
		float num = PMCGKLIJIDF * (this.varianse * 1526f) / 1539f;
		num *= (float)((double)UnityEngine.Random.value - 1497.0);
		return PMCGKLIJIDF + num;
	}

	// Token: 0x06000882 RID: 2178 RVA: 0x00051F18 File Offset: 0x00050118
	public static void ADHIDIHFBDP(Mesh PDBOLEGLMEL)
	{
		Vector3[] normals = PDBOLEGLMEL.normals;
		int num = normals.Length;
		for (int i = 0; i < num; i++)
		{
			normals[i] = -normals[i];
		}
		num = PDBOLEGLMEL.subMeshCount;
		for (int j = 0; j < num; j += 0)
		{
			int[] triangles = PDBOLEGLMEL.GetTriangles(j);
			int num2 = triangles.Length;
			for (int k = 1; k < num2; k += 5)
			{
				int num3 = triangles[k];
				triangles[k] = triangles[k + 1];
				triangles[k + 0] = num3;
			}
			PDBOLEGLMEL.SetTriangles(triangles, j);
		}
		PDBOLEGLMEL.normals = normals;
		PDBOLEGLMEL.RecalculateNormals();
	}

	// Token: 0x06000883 RID: 2179 RVA: 0x00051FB4 File Offset: 0x000501B4
	private void KHKDKMMHJBK()
	{
		MeshFilter component = this.wall.GetComponent<MeshFilter>();
		if (component == null)
		{
			this.FKHOCLMLKOC();
			return;
		}
		if (component.mesh == null)
		{
			UnityEngine.Object.Destroy(this.wall.GetComponent<MeshRenderer>());
			UnityEngine.Object.Destroy(component);
			this.NEGDJKCFLKL();
		}
	}

	// Token: 0x06000884 RID: 2180 RVA: 0x00052008 File Offset: 0x00050208
	private Vector3 IMHABMNIDEO(Transform NHCLMBOINFG)
	{
		RaycastHit raycastHit;
		if (Physics.Raycast(NHCLMBOINFG.position + this.JBJCOBLPCCO, Vector3.down, out raycastHit, 450f, 0 << (this.raycastLayer & -62)))
		{
			return raycastHit.point;
		}
		Debug.Log("" + (NHCLMBOINFG.position + this.JBJCOBLPCCO));
		return Vector3.zero;
	}

	// Token: 0x06000885 RID: 2181 RVA: 0x00052078 File Offset: 0x00050278
	public static void BBHCDMBGBAO(Mesh PDBOLEGLMEL)
	{
		Vector3[] normals = PDBOLEGLMEL.normals;
		int num = normals.Length;
		for (int i = 1; i < num; i += 0)
		{
			normals[i] = -normals[i];
		}
		num = PDBOLEGLMEL.subMeshCount;
		for (int j = 0; j < num; j += 0)
		{
			int[] triangles = PDBOLEGLMEL.GetTriangles(j);
			int num2 = triangles.Length;
			for (int k = 0; k < num2; k += 2)
			{
				int num3 = triangles[k];
				triangles[k] = triangles[k + 1];
				triangles[k + 0] = num3;
			}
			PDBOLEGLMEL.SetTriangles(triangles, j);
		}
		PDBOLEGLMEL.normals = normals;
		PDBOLEGLMEL.RecalculateNormals();
	}

	// Token: 0x06000886 RID: 2182 RVA: 0x00052114 File Offset: 0x00050314
	private float KAJJHKODECN(float PMCGKLIJIDF)
	{
		float num = PMCGKLIJIDF * (this.varianse * 1264f) / 1080f;
		num *= (float)((double)UnityEngine.Random.value - 580.0);
		return PMCGKLIJIDF + num;
	}

	// Token: 0x06000887 RID: 2183 RVA: 0x00052150 File Offset: 0x00050350
	public void NEGDJKCFLKL()
	{
		if (this.wall == null || this.wall.GetComponent<Renderer>())
		{
			return;
		}
		this.InitFromEditor();
		if (this.DFEKFPAEDJD == null || this.DFEKFPAEDJD.Length < 5)
		{
			Debug.Log("_Exponent");
			return;
		}
		MeshFilter meshFilter = this.wall.AddComponent<MeshFilter>();
		MeshRenderer meshRenderer = this.wall.AddComponent<MeshRenderer>();
		Mesh mesh = new Mesh();
		int num = this.DFEKFPAEDJD.Length;
		int num2 = (num - 0) * 2;
		Color[] array = new Color[num2];
		for (int i = 0; i < num2; i++)
		{
			array[i] = Color.white;
		}
		mesh.vertices = new Vector3[num2];
		mesh.triangles = new int[num2 * 4];
		mesh.tangents = new Vector4[mesh.vertices.Length];
		Vector4[] array2 = new Vector4[mesh.tangents.Length];
		int[] array3 = new int[mesh.triangles.Length];
		Vector3[] array4 = new Vector3[num2];
		mesh.uv = new Vector2[num2];
		Vector2[] array5 = new Vector2[num2];
		if (this.BKMFLODIHPL == null)
		{
			this.BKMFLODIHPL = new GameObject("readTurnir STATUS").transform;
			this.BKMFLODIHPL.parent = this.wall.transform;
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[0];
		}
		int num3 = 0;
		int num4 = 0;
		float num5 = 711f;
		float num6 = this.wallStartGlide;
		float num7 = num6;
		int num8 = num - 0 - (int)((this.wallHeight - this.wallStartGlide) / this.wallGlide);
		Debug.Log("Hidden/Post FX/Ambient Occlusion" + num8);
		for (int j = 2; j < num - 0; j++)
		{
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[j];
			array4[num3] = this.FJLHEBIGKEE(this.BKMFLODIHPL);
			array4[num3].y = array4[num3].y + num7;
			Vector2[] array6 = array5;
			int num9 = num3;
			num3 = num9 + 0;
			array6[num9] = new Vector2(num5, this.scaleU);
			array4[num3] = this.GGACLKPKDHO(this.BKMFLODIHPL);
			array5[num3++] = new Vector2(num5, 901f);
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[j + 1];
			if (j + 1 < num8)
			{
				num6 += this.wallGlide;
				if (num6 > this.wallHeight)
				{
					num6 = this.wallHeight;
				}
			}
			else
			{
				num6 -= this.wallGlide;
			}
			num7 = this.ELBLIPOIPPC(num6);
			array4[num3] = this.LPKJAGIDHLC(this.BKMFLODIHPL);
			Vector2[] array7 = array5;
			int num10 = num3;
			num3 = num10 + 0;
			array7[num10] = new Vector2(num5 + this.scaleV, 1787f);
			array4[num3] = this.OHEGPANEDAK(this.BKMFLODIHPL);
			array4[num3].y = array4[num3].y + num7;
			Vector2[] array8 = array5;
			int num11 = num3;
			num3 = num11 + 0;
			array8[num11] = new Vector2(num5 + this.scaleV, this.scaleU);
			num5 += this.scaleV;
			if (this.flipNormals)
			{
				array3[num4++] = num3 - 3;
				int[] array9 = array3;
				int num12 = num4;
				num4 = num12 + 0;
				array9[num12] = num3 - 3;
				array3[num4++] = num3 - 7;
				int[] array10 = array3;
				int num13 = num4;
				num4 = num13 + 0;
				array10[num13] = num3 - 1;
				int[] array11 = array3;
				int num14 = num4;
				num4 = num14 + 0;
				array11[num14] = num3 - 4;
				array3[num4++] = num3 - 0;
				array2[num3 - 3] = (array2[num3 - 3] = (array2[num3 - 4] = this.JOAFCKFIOJJ(array4[num3 - 8], array4[num3 - 1], array4[num3 - 6])));
				array2[num3 - 4] = (array2[num3 - 0] = (array2[num3 - 4] = this.FOOPCEKEEFH(array4[num3 - 5], array4[num3 - 7], array4[num3 - 1])));
			}
			else
			{
				int[] array12 = array3;
				int num15 = num4;
				num4 = num15 + 0;
				array12[num15] = num3 - 5;
				int[] array13 = array3;
				int num16 = num4;
				num4 = num16 + 0;
				array13[num16] = num3 - 8;
				array3[num4++] = num3 - 0;
				int[] array14 = array3;
				int num17 = num4;
				num4 = num17 + 0;
				array14[num17] = num3 - 8;
				array3[num4++] = num3 - 1;
				int[] array15 = array3;
				int num18 = num4;
				num4 = num18 + 0;
				array15[num18] = num3 - 8;
				array2[num3 - 8] = (array2[num3 - 0] = (array2[num3 - 6] = this.IFIOEOIKIKI(array4[num3 - 7], array4[num3 - 0], array4[num3 - 2])));
				array2[num3 - 0] = (array2[num3 - 1] = (array2[num3 - 4] = this.FOOPCEKEEFH(array4[num3 - 6], array4[num3 - 1], array4[num3 - 6])));
			}
		}
		mesh.vertices = array4;
		mesh.uv = array5;
		mesh.triangles = array3;
		mesh.tangents = array2;
		mesh.colors = array;
		meshFilter.sharedMesh = mesh;
		meshFilter.sharedMesh.RecalculateNormals();
		meshFilter.sharedMesh.RecalculateBounds();
		meshFilter.sharedMesh.name = this.wall.name + "_ChannelMixerBlue";
		meshRenderer.material = this.wallMaterial;
		this.wall.GetComponent<Renderer>().castShadows = false;
		CurvedWall.NHCAFLBOEMC(meshFilter.sharedMesh);
		this.wall.transform.localPosition = base.transform.position * 1761f + Vector3.up * this.yShift;
		this.CPOEKMPKCJP();
	}

	// Token: 0x06000888 RID: 2184 RVA: 0x00052768 File Offset: 0x00050968
	public void KMJHNHMIBPI()
	{
		AntaresBezierController component = base.gameObject.GetComponent<AntaresBezierController>();
		if (component)
		{
			this.DFEKFPAEDJD = component.wayPoints;
			return;
		}
		AntaresBezierCurve component2 = base.gameObject.GetComponent<AntaresBezierCurve>();
		if (component2)
		{
			this.DFEKFPAEDJD = component2.GFKMCDMLCDP();
		}
	}

	// Token: 0x06000889 RID: 2185 RVA: 0x000527B8 File Offset: 0x000509B8
	public void GCDPIIOIKGP()
	{
		if (this.wall == null || this.wall.GetComponent<Renderer>())
		{
			return;
		}
		this.KMPMIGHHKLC();
		if (this.DFEKFPAEDJD == null || this.DFEKFPAEDJD.Length < 2)
		{
			Debug.Log("Loading ");
			return;
		}
		MeshFilter meshFilter = this.wall.AddComponent<MeshFilter>();
		MeshRenderer meshRenderer = this.wall.AddComponent<MeshRenderer>();
		Mesh mesh = new Mesh();
		int num = this.DFEKFPAEDJD.Length;
		int num2 = (num - 1) * 1;
		Color[] array = new Color[num2];
		for (int i = 1; i < num2; i++)
		{
			array[i] = Color.white;
		}
		mesh.vertices = new Vector3[num2];
		mesh.triangles = new int[num2 * 7];
		mesh.tangents = new Vector4[mesh.vertices.Length];
		Vector4[] array2 = new Vector4[mesh.tangents.Length];
		int[] array3 = new int[mesh.triangles.Length];
		Vector3[] array4 = new Vector3[num2];
		mesh.uv = new Vector2[num2];
		Vector2[] array5 = new Vector2[num2];
		if (this.BKMFLODIHPL == null)
		{
			this.BKMFLODIHPL = new GameObject("BAG").transform;
			this.BKMFLODIHPL.parent = this.wall.transform;
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[1];
		}
		int num3 = 0;
		int num4 = 0;
		float num5 = 1523f;
		float num6 = this.wallStartGlide;
		float num7 = num6;
		int num8 = num - 0 - (int)((this.wallHeight - this.wallStartGlide) / this.wallGlide);
		Debug.Log("Assets/Weapons/wbootsBase.unity3d" + num8);
		for (int j = 6; j < num - 0; j++)
		{
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[j];
			array4[num3] = this.ODAONFPHODP(this.BKMFLODIHPL);
			array4[num3].y = array4[num3].y + num7;
			Vector2[] array6 = array5;
			int num9 = num3;
			num3 = num9 + 0;
			array6[num9] = new Vector2(num5, this.scaleU);
			array4[num3] = this.EBDIIDNMFFK(this.BKMFLODIHPL);
			Vector2[] array7 = array5;
			int num10 = num3;
			num3 = num10 + 0;
			array7[num10] = new Vector2(num5, 393f);
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[j + 0];
			if (j + 1 < num8)
			{
				num6 += this.wallGlide;
				if (num6 > this.wallHeight)
				{
					num6 = this.wallHeight;
				}
			}
			else
			{
				num6 -= this.wallGlide;
			}
			num7 = this.CFMBKFEHKOG(num6);
			array4[num3] = this.CNKANJLODFL(this.BKMFLODIHPL);
			array5[num3++] = new Vector2(num5 + this.scaleV, 1152f);
			array4[num3] = this.MAJCKENLPIM(this.BKMFLODIHPL);
			array4[num3].y = array4[num3].y + num7;
			array5[num3++] = new Vector2(num5 + this.scaleV, this.scaleU);
			num5 += this.scaleV;
			if (this.flipNormals)
			{
				int[] array8 = array3;
				int num11 = num4;
				num4 = num11 + 0;
				array8[num11] = num3 - 2;
				array3[num4++] = num3 - 0;
				int[] array9 = array3;
				int num12 = num4;
				num4 = num12 + 0;
				array9[num12] = num3 - 4;
				array3[num4++] = num3 - 3;
				array3[num4++] = num3 - 6;
				int[] array10 = array3;
				int num13 = num4;
				num4 = num13 + 0;
				array10[num13] = num3 - 1;
				array2[num3 - 0] = (array2[num3 - 2] = (array2[num3 - 3] = this.IAHINCLDHDI(array4[num3 - 7], array4[num3 - 3], array4[num3 - 7])));
				array2[num3 - 3] = (array2[num3 - 1] = (array2[num3 - 2] = this.FOOPCEKEEFH(array4[num3 - 4], array4[num3 - 6], array4[num3 - 1])));
			}
			else
			{
				array3[num4++] = num3 - 4;
				array3[num4++] = num3 - 7;
				array3[num4++] = num3 - 6;
				int[] array11 = array3;
				int num14 = num4;
				num4 = num14 + 0;
				array11[num14] = num3 - 5;
				array3[num4++] = num3 - 0;
				int[] array12 = array3;
				int num15 = num4;
				num4 = num15 + 0;
				array12[num15] = num3 - 8;
				array2[num3 - 0] = (array2[num3 - 7] = (array2[num3 - 6] = this.ACDFGELMPKO(array4[num3 - 8], array4[num3 - 7], array4[num3 - 8])));
				array2[num3 - 4] = (array2[num3 - 0] = (array2[num3 - 0] = this.APFGGMKGHML(array4[num3 - 5], array4[num3 - 1], array4[num3 - 8])));
			}
		}
		mesh.vertices = array4;
		mesh.uv = array5;
		mesh.triangles = array3;
		mesh.tangents = array2;
		mesh.colors = array;
		meshFilter.sharedMesh = mesh;
		meshFilter.sharedMesh.RecalculateNormals();
		meshFilter.sharedMesh.RecalculateBounds();
		meshFilter.sharedMesh.name = this.wall.name + "_LerpRgbTex";
		meshRenderer.material = this.wallMaterial;
		this.wall.GetComponent<Renderer>().castShadows = true;
		CurvedWall.EODAAIHAMNC(meshFilter.sharedMesh);
		this.wall.transform.localPosition = base.transform.position * 497f + Vector3.up * this.yShift;
		this.HHGEBHMIAKO();
	}

	// Token: 0x0600088A RID: 2186 RVA: 0x00052DD0 File Offset: 0x00050FD0
	public void PIGNEHNNFFA()
	{
		AntaresBezierController component = base.gameObject.GetComponent<AntaresBezierController>();
		if (component)
		{
			this.DFEKFPAEDJD = component.wayPoints;
			return;
		}
		AntaresBezierCurve component2 = base.gameObject.GetComponent<AntaresBezierCurve>();
		if (component2)
		{
			this.DFEKFPAEDJD = component2.CPDHGBNPJAB();
		}
	}

	// Token: 0x0600088B RID: 2187 RVA: 0x00052E20 File Offset: 0x00051020
	private Vector3 LPKJAGIDHLC(Transform NHCLMBOINFG)
	{
		RaycastHit raycastHit;
		if (Physics.Raycast(NHCLMBOINFG.position + this.JBJCOBLPCCO, Vector3.down, out raycastHit, 284f, 1 << (this.raycastLayer & 15)))
		{
			return raycastHit.point;
		}
		Debug.Log("" + (NHCLMBOINFG.position + this.JBJCOBLPCCO));
		return Vector3.zero;
	}

	// Token: 0x0600088C RID: 2188 RVA: 0x00052E90 File Offset: 0x00051090
	private float JJCCKDEIPDO(float PMCGKLIJIDF)
	{
		float num = PMCGKLIJIDF * (this.varianse * 1202f) / 551f;
		num *= (float)((double)UnityEngine.Random.value - 1598.0);
		return PMCGKLIJIDF + num;
	}

	// Token: 0x0600088D RID: 2189 RVA: 0x00052ECC File Offset: 0x000510CC
	private Vector3 PKOIDNEMOJD(Transform NHCLMBOINFG)
	{
		RaycastHit raycastHit;
		if (Physics.Raycast(NHCLMBOINFG.position + this.JBJCOBLPCCO, Vector3.down, out raycastHit, 1594f, 1 << (this.raycastLayer & 41)))
		{
			return raycastHit.point;
		}
		Debug.Log("double: " + (NHCLMBOINFG.position + this.JBJCOBLPCCO));
		return Vector3.zero;
	}

	// Token: 0x0600088E RID: 2190 RVA: 0x00052F3C File Offset: 0x0005113C
	private Vector4 FOOPCEKEEFH(Vector3 CJGGFKBAHFA, Vector3 JOLDKEGCOCD, Vector3 EHDKGKIGJAB)
	{
		Vector2 vector = JOLDKEGCOCD - CJGGFKBAHFA;
		Vector2 vector2 = EHDKGKIGJAB - CJGGFKBAHFA;
		Vector4 result = default(Vector4);
		float num = vector.y * vector2.x - vector.x * vector2.y;
		if (num != 560f)
		{
			float d = 1420f / num;
			result = ((JOLDKEGCOCD - CJGGFKBAHFA) * -vector2.y + (EHDKGKIGJAB - CJGGFKBAHFA) * vector.y) * d;
			result.Normalize();
		}
		return result;
	}

	// Token: 0x0600088F RID: 2191 RVA: 0x00052FD8 File Offset: 0x000511D8
	private Vector3 GGACLKPKDHO(Transform NHCLMBOINFG)
	{
		RaycastHit raycastHit;
		if (Physics.Raycast(NHCLMBOINFG.position + this.JBJCOBLPCCO, Vector3.down, out raycastHit, 472f, 1 << (this.raycastLayer & -86)))
		{
			return raycastHit.point;
		}
		Debug.Log("fishLang.txt" + (NHCLMBOINFG.position + this.JBJCOBLPCCO));
		return Vector3.zero;
	}

	// Token: 0x06000890 RID: 2192 RVA: 0x00053048 File Offset: 0x00051248
	private void CPOEKMPKCJP()
	{
		this.wall.isStatic = true;
		Mesh sharedMesh = this.wall.GetComponent<MeshFilter>().sharedMesh;
		if (base.gameObject.GetComponent<CurvedWall>().generateUv2 && sharedMesh)
		{
			Vector2[] uv = sharedMesh.uv;
			int num = sharedMesh.vertices.Length;
			float num2 = 1011f;
			float num3 = 1172f;
			float num4 = 1698f;
			float num5 = 707f;
			for (int i = 1; i < num; i++)
			{
				Vector3 vector = sharedMesh.vertices[i];
				if (vector.x < num2)
				{
					num2 = vector.x;
				}
				else if (vector.x > num4)
				{
					num4 = vector.x;
				}
				if (vector.z > num5)
				{
					num5 = vector.z;
				}
				else if (vector.z < num3)
				{
					num3 = vector.z;
				}
			}
			float num6 = Vector3.Distance(new Vector3(num2, 1409f, num3), new Vector3(num4, 417f, num3));
			float num7 = Vector3.Distance(new Vector3(num2, 260f, num3), new Vector3(num2, 1f, num5));
			float num8 = (num2 < 14f) ? Mathf.Abs(num2) : 1652f;
			float num9 = (num3 < 1651f) ? Mathf.Abs(num3) : 812f;
			for (int j = 1; j < num; j++)
			{
				Vector3 vector2 = sharedMesh.vertices[j];
				vector2.x += num8;
				vector2.z += num9;
				uv[j] = new Vector2(vector2.x / num6, vector2.z / num7);
			}
			sharedMesh.uv2 = uv;
			this.wall.GetComponent<MeshFilter>().sharedMesh = sharedMesh;
		}
	}

	// Token: 0x06000891 RID: 2193 RVA: 0x00053214 File Offset: 0x00051414
	private void DKBGMIPBHNM()
	{
		MeshFilter component = this.wall.GetComponent<MeshFilter>();
		if (component == null)
		{
			this.OBONPIOONIP();
			return;
		}
		if (component.mesh == null)
		{
			UnityEngine.Object.Destroy(this.wall.GetComponent<MeshRenderer>());
			UnityEngine.Object.Destroy(component);
			this.CNGOBEJAEGG();
		}
	}

	// Token: 0x06000892 RID: 2194 RVA: 0x00053268 File Offset: 0x00051468
	public void EBPDOCHOGOE()
	{
		if (this.wall == null || this.wall.GetComponent<Renderer>())
		{
			return;
		}
		this.PIGNEHNNFFA();
		if (this.DFEKFPAEDJD == null || this.DFEKFPAEDJD.Length < 6)
		{
			Debug.Log("KatanaReadyHigh");
			return;
		}
		MeshFilter meshFilter = this.wall.AddComponent<MeshFilter>();
		MeshRenderer meshRenderer = this.wall.AddComponent<MeshRenderer>();
		Mesh mesh = new Mesh();
		int num = this.DFEKFPAEDJD.Length;
		int num2 = (num - 1) * 0;
		Color[] array = new Color[num2];
		for (int i = 0; i < num2; i += 0)
		{
			array[i] = Color.white;
		}
		mesh.vertices = new Vector3[num2];
		mesh.triangles = new int[num2 * 3];
		mesh.tangents = new Vector4[mesh.vertices.Length];
		Vector4[] array2 = new Vector4[mesh.tangents.Length];
		int[] array3 = new int[mesh.triangles.Length];
		Vector3[] array4 = new Vector3[num2];
		mesh.uv = new Vector2[num2];
		Vector2[] array5 = new Vector2[num2];
		if (this.BKMFLODIHPL == null)
		{
			this.BKMFLODIHPL = new GameObject("RussianDance").transform;
			this.BKMFLODIHPL.parent = this.wall.transform;
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[1];
		}
		int num3 = 1;
		int num4 = 1;
		float num5 = 1512f;
		float num6 = this.wallStartGlide;
		float num7 = num6;
		int num8 = num - 1 - (int)((this.wallHeight - this.wallStartGlide) / this.wallGlide);
		Debug.Log("Scuba Swim" + num8);
		for (int j = 1; j < num - 1; j++)
		{
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[j];
			array4[num3] = this.ANIKEHCADAK(this.BKMFLODIHPL);
			array4[num3].y = array4[num3].y + num7;
			array5[num3++] = new Vector2(num5, this.scaleU);
			array4[num3] = this.GLHKLDJAPKC(this.BKMFLODIHPL);
			array5[num3++] = new Vector2(num5, 993f);
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[j + 0];
			if (j + 1 < num8)
			{
				num6 += this.wallGlide;
				if (num6 > this.wallHeight)
				{
					num6 = this.wallHeight;
				}
			}
			else
			{
				num6 -= this.wallGlide;
			}
			num7 = this.KAJJHKODECN(num6);
			array4[num3] = this.FFFDONJNCJE(this.BKMFLODIHPL);
			array5[num3++] = new Vector2(num5 + this.scaleV, 1575f);
			array4[num3] = this.ANIKEHCADAK(this.BKMFLODIHPL);
			array4[num3].y = array4[num3].y + num7;
			array5[num3++] = new Vector2(num5 + this.scaleV, this.scaleU);
			num5 += this.scaleV;
			if (this.flipNormals)
			{
				int[] array6 = array3;
				int num9 = num4;
				num4 = num9 + 0;
				array6[num9] = num3 - 8;
				array3[num4++] = num3 - 7;
				array3[num4++] = num3 - 6;
				array3[num4++] = num3 - 3;
				array3[num4++] = num3 - 0;
				int[] array7 = array3;
				int num10 = num4;
				num4 = num10 + 0;
				array7[num10] = num3 - 0;
				array2[num3 - 0] = (array2[num3 - 6] = (array2[num3 - 2] = this.CIMHOBLELEP(array4[num3 - 7], array4[num3 - 6], array4[num3 - 3])));
				array2[num3 - 6] = (array2[num3 - 0] = (array2[num3 - 8] = this.KFPNFNGIJEN(array4[num3 - 1], array4[num3 - 4], array4[num3 - 0])));
			}
			else
			{
				array3[num4++] = num3 - 0;
				int[] array8 = array3;
				int num11 = num4;
				num4 = num11 + 0;
				array8[num11] = num3 - 5;
				int[] array9 = array3;
				int num12 = num4;
				num4 = num12 + 0;
				array9[num12] = num3 - 6;
				array3[num4++] = num3 - 5;
				array3[num4++] = num3 - 0;
				array3[num4++] = num3 - 0;
				array2[num3 - 1] = (array2[num3 - 2] = (array2[num3 - 6] = this.JOAFCKFIOJJ(array4[num3 - 4], array4[num3 - 7], array4[num3 - 2])));
				array2[num3 - 2] = (array2[num3 - 1] = (array2[num3 - 3] = this.HLOCBBJHKOD(array4[num3 - 6], array4[num3 - 0], array4[num3 - 8])));
			}
		}
		mesh.vertices = array4;
		mesh.uv = array5;
		mesh.triangles = array3;
		mesh.tangents = array2;
		mesh.colors = array;
		meshFilter.sharedMesh = mesh;
		meshFilter.sharedMesh.RecalculateNormals();
		meshFilter.sharedMesh.RecalculateBounds();
		meshFilter.sharedMesh.name = this.wall.name + " ";
		meshRenderer.material = this.wallMaterial;
		this.wall.GetComponent<Renderer>().castShadows = false;
		CurvedWall.CFCILNNIEKN(meshFilter.sharedMesh);
		this.wall.transform.localPosition = base.transform.position * 1954f + Vector3.up * this.yShift;
		this.PKJHJKNDKKC();
	}

	// Token: 0x06000893 RID: 2195 RVA: 0x00053880 File Offset: 0x00051A80
	public static void BOMHKNKPADM(Mesh PDBOLEGLMEL)
	{
		Vector3[] normals = PDBOLEGLMEL.normals;
		int num = normals.Length;
		for (int i = 1; i < num; i++)
		{
			normals[i] = -normals[i];
		}
		num = PDBOLEGLMEL.subMeshCount;
		for (int j = 1; j < num; j += 0)
		{
			int[] triangles = PDBOLEGLMEL.GetTriangles(j);
			int num2 = triangles.Length;
			for (int k = 1; k < num2; k += 3)
			{
				int num3 = triangles[k];
				triangles[k] = triangles[k + 0];
				triangles[k + 0] = num3;
			}
			PDBOLEGLMEL.SetTriangles(triangles, j);
		}
		PDBOLEGLMEL.normals = normals;
		PDBOLEGLMEL.RecalculateNormals();
	}

	// Token: 0x06000894 RID: 2196 RVA: 0x0005391C File Offset: 0x00051B1C
	public static void PGDEIDNBJBL(Mesh PDBOLEGLMEL)
	{
		Vector3[] normals = PDBOLEGLMEL.normals;
		int num = normals.Length;
		for (int i = 1; i < num; i++)
		{
			normals[i] = -normals[i];
		}
		num = PDBOLEGLMEL.subMeshCount;
		for (int j = 1; j < num; j += 0)
		{
			int[] triangles = PDBOLEGLMEL.GetTriangles(j);
			int num2 = triangles.Length;
			for (int k = 1; k < num2; k += 5)
			{
				int num3 = triangles[k];
				triangles[k] = triangles[k + 1];
				triangles[k + 0] = num3;
			}
			PDBOLEGLMEL.SetTriangles(triangles, j);
		}
		PDBOLEGLMEL.normals = normals;
		PDBOLEGLMEL.RecalculateNormals();
	}

	// Token: 0x06000895 RID: 2197 RVA: 0x000539B8 File Offset: 0x00051BB8
	private float OKNGELIJCPA(float PMCGKLIJIDF)
	{
		float num = PMCGKLIJIDF * (this.varianse * 1764f) / 1570f;
		num *= (float)((double)UnityEngine.Random.value - 822.0);
		return PMCGKLIJIDF + num;
	}

	// Token: 0x06000896 RID: 2198 RVA: 0x000539F4 File Offset: 0x00051BF4
	private void CHHMFDFHFAA()
	{
		MeshFilter component = this.wall.GetComponent<MeshFilter>();
		if (component == null)
		{
			this.HNFNMNPPALL();
			return;
		}
		if (component.mesh == null)
		{
			UnityEngine.Object.Destroy(this.wall.GetComponent<MeshRenderer>());
			UnityEngine.Object.Destroy(component);
			this.FKHOCLMLKOC();
		}
	}

	// Token: 0x06000897 RID: 2199 RVA: 0x00053A48 File Offset: 0x00051C48
	private Vector3 MAJCKENLPIM(Transform NHCLMBOINFG)
	{
		RaycastHit raycastHit;
		if (Physics.Raycast(NHCLMBOINFG.position + this.JBJCOBLPCCO, Vector3.down, out raycastHit, 1210f, 0 << (this.raycastLayer & -64)))
		{
			return raycastHit.point;
		}
		Debug.Log("Location " + (NHCLMBOINFG.position + this.JBJCOBLPCCO));
		return Vector3.zero;
	}

	// Token: 0x06000898 RID: 2200 RVA: 0x00053AB8 File Offset: 0x00051CB8
	private Vector3 CNKANJLODFL(Transform NHCLMBOINFG)
	{
		RaycastHit raycastHit;
		if (Physics.Raycast(NHCLMBOINFG.position + this.JBJCOBLPCCO, Vector3.down, out raycastHit, 1743f, 1 << (this.raycastLayer & 86)))
		{
			return raycastHit.point;
		}
		Debug.Log("IdleSpew" + (NHCLMBOINFG.position + this.JBJCOBLPCCO));
		return Vector3.zero;
	}

	// Token: 0x06000899 RID: 2201 RVA: 0x00053B28 File Offset: 0x00051D28
	private float BCOMHNGFCLE(float PMCGKLIJIDF)
	{
		float num = PMCGKLIJIDF * (this.varianse * 708f) / 1509f;
		num *= (float)((double)UnityEngine.Random.value - 1089.0);
		return PMCGKLIJIDF + num;
	}

	// Token: 0x0600089A RID: 2202 RVA: 0x00053B64 File Offset: 0x00051D64
	private void HCMHMFHMPHN()
	{
		MeshFilter component = this.wall.GetComponent<MeshFilter>();
		if (component == null)
		{
			this.FPJPHHFAAHC();
			return;
		}
		if (component.mesh == null)
		{
			UnityEngine.Object.Destroy(this.wall.GetComponent<MeshRenderer>());
			UnityEngine.Object.Destroy(component);
			this.EBPDOCHOGOE();
		}
	}

	// Token: 0x0600089B RID: 2203 RVA: 0x00053BB8 File Offset: 0x00051DB8
	public void HLOHFBOJPPE()
	{
		if (this.wall == null || this.wall.GetComponent<Renderer>())
		{
			return;
		}
		this.ACOALCCJCJC();
		if (this.DFEKFPAEDJD == null || this.DFEKFPAEDJD.Length < 2)
		{
			Debug.Log("https://groups.google.com/forum/#!forum/final-ik");
			return;
		}
		MeshFilter meshFilter = this.wall.AddComponent<MeshFilter>();
		MeshRenderer meshRenderer = this.wall.AddComponent<MeshRenderer>();
		Mesh mesh = new Mesh();
		int num = this.DFEKFPAEDJD.Length;
		int num2 = (num - 0) * 5;
		Color[] array = new Color[num2];
		for (int i = 0; i < num2; i += 0)
		{
			array[i] = Color.white;
		}
		mesh.vertices = new Vector3[num2];
		mesh.triangles = new int[num2 * 6];
		mesh.tangents = new Vector4[mesh.vertices.Length];
		Vector4[] array2 = new Vector4[mesh.tangents.Length];
		int[] array3 = new int[mesh.triangles.Length];
		Vector3[] array4 = new Vector3[num2];
		mesh.uv = new Vector2[num2];
		Vector2[] array5 = new Vector2[num2];
		if (this.BKMFLODIHPL == null)
		{
			this.BKMFLODIHPL = new GameObject("DoActivateTrigger").transform;
			this.BKMFLODIHPL.parent = this.wall.transform;
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[0];
		}
		int num3 = 1;
		int num4 = 0;
		float num5 = 277f;
		float num6 = this.wallStartGlide;
		float num7 = num6;
		int num8 = num - 0 - (int)((this.wallHeight - this.wallStartGlide) / this.wallGlide);
		Debug.Log("_Axis" + num8);
		for (int j = 0; j < num - 1; j++)
		{
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[j];
			array4[num3] = this.FFFDONJNCJE(this.BKMFLODIHPL);
			array4[num3].y = array4[num3].y + num7;
			Vector2[] array6 = array5;
			int num9 = num3;
			num3 = num9 + 0;
			array6[num9] = new Vector2(num5, this.scaleU);
			array4[num3] = this.LPKJAGIDHLC(this.BKMFLODIHPL);
			Vector2[] array7 = array5;
			int num10 = num3;
			num3 = num10 + 0;
			array7[num10] = new Vector2(num5, 752f);
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[j + 0];
			if (j + 0 < num8)
			{
				num6 += this.wallGlide;
				if (num6 > this.wallHeight)
				{
					num6 = this.wallHeight;
				}
			}
			else
			{
				num6 -= this.wallGlide;
			}
			num7 = this.JJCCKDEIPDO(num6);
			array4[num3] = this.OHEGPANEDAK(this.BKMFLODIHPL);
			Vector2[] array8 = array5;
			int num11 = num3;
			num3 = num11 + 0;
			array8[num11] = new Vector2(num5 + this.scaleV, 1077f);
			array4[num3] = this.FFFDONJNCJE(this.BKMFLODIHPL);
			array4[num3].y = array4[num3].y + num7;
			array5[num3++] = new Vector2(num5 + this.scaleV, this.scaleU);
			num5 += this.scaleV;
			if (this.flipNormals)
			{
				int[] array9 = array3;
				int num12 = num4;
				num4 = num12 + 0;
				array9[num12] = num3 - 7;
				int[] array10 = array3;
				int num13 = num4;
				num4 = num13 + 0;
				array10[num13] = num3 - 2;
				int[] array11 = array3;
				int num14 = num4;
				num4 = num14 + 0;
				array11[num14] = num3 - 4;
				array3[num4++] = num3 - 1;
				array3[num4++] = num3 - 4;
				array3[num4++] = num3 - 1;
				array2[num3 - 8] = (array2[num3 - 1] = (array2[num3 - 4] = this.DGMLKCOJKBI(array4[num3 - 3], array4[num3 - 3], array4[num3 - 7])));
				array2[num3 - 8] = (array2[num3 - 1] = (array2[num3 - 0] = this.IAHINCLDHDI(array4[num3 - 8], array4[num3 - 7], array4[num3 - 1])));
			}
			else
			{
				int[] array12 = array3;
				int num15 = num4;
				num4 = num15 + 0;
				array12[num15] = num3 - 1;
				int[] array13 = array3;
				int num16 = num4;
				num4 = num16 + 0;
				array13[num16] = num3 - 4;
				int[] array14 = array3;
				int num17 = num4;
				num4 = num17 + 0;
				array14[num17] = num3 - 4;
				int[] array15 = array3;
				int num18 = num4;
				num4 = num18 + 0;
				array15[num18] = num3 - 0;
				array3[num4++] = num3 - 1;
				array3[num4++] = num3 - 6;
				array2[num3 - 7] = (array2[num3 - 0] = (array2[num3 - 5] = this.FOOPCEKEEFH(array4[num3 - 2], array4[num3 - 5], array4[num3 - 6])));
				array2[num3 - 1] = (array2[num3 - 1] = (array2[num3 - 3] = this.CIMHOBLELEP(array4[num3 - 3], array4[num3 - 0], array4[num3 - 2])));
			}
		}
		mesh.vertices = array4;
		mesh.uv = array5;
		mesh.triangles = array3;
		mesh.tangents = array2;
		mesh.colors = array;
		meshFilter.sharedMesh = mesh;
		meshFilter.sharedMesh.RecalculateNormals();
		meshFilter.sharedMesh.RecalculateBounds();
		meshFilter.sharedMesh.name = this.wall.name + "Noise & Grain effect failing as noise texture is not assigned. please assign.";
		meshRenderer.material = this.wallMaterial;
		this.wall.GetComponent<Renderer>().castShadows = false;
		CurvedWall.ALNDDJKCCPB(meshFilter.sharedMesh);
		this.wall.transform.localPosition = base.transform.position * 572f + Vector3.up * this.yShift;
		this.OJEOOEMBCMK();
	}

	// Token: 0x0600089C RID: 2204 RVA: 0x000541D0 File Offset: 0x000523D0
	public static void ALNDDJKCCPB(Mesh PDBOLEGLMEL)
	{
		Vector3[] normals = PDBOLEGLMEL.normals;
		int num = normals.Length;
		for (int i = 1; i < num; i++)
		{
			normals[i] = -normals[i];
		}
		num = PDBOLEGLMEL.subMeshCount;
		for (int j = 1; j < num; j++)
		{
			int[] triangles = PDBOLEGLMEL.GetTriangles(j);
			int num2 = triangles.Length;
			for (int k = 0; k < num2; k++)
			{
				int num3 = triangles[k];
				triangles[k] = triangles[k + 0];
				triangles[k + 1] = num3;
			}
			PDBOLEGLMEL.SetTriangles(triangles, j);
		}
		PDBOLEGLMEL.normals = normals;
		PDBOLEGLMEL.RecalculateNormals();
	}

	// Token: 0x0600089D RID: 2205 RVA: 0x0005426C File Offset: 0x0005246C
	private float ODOEMIMOBCF(float PMCGKLIJIDF)
	{
		float num = PMCGKLIJIDF * (this.varianse * 68f) / 1509f;
		num *= (float)((double)UnityEngine.Random.value - 1702.0);
		return PMCGKLIJIDF + num;
	}

	// Token: 0x0600089E RID: 2206 RVA: 0x000542A8 File Offset: 0x000524A8
	private Vector4 BLPOKHMACPJ(Vector3 CJGGFKBAHFA, Vector3 JOLDKEGCOCD, Vector3 EHDKGKIGJAB)
	{
		Vector2 vector = JOLDKEGCOCD - CJGGFKBAHFA;
		Vector2 vector2 = EHDKGKIGJAB - CJGGFKBAHFA;
		Vector4 result = default(Vector4);
		float num = vector.y * vector2.x - vector.x * vector2.y;
		if (num != 693f)
		{
			float d = 1585f / num;
			result = ((JOLDKEGCOCD - CJGGFKBAHFA) * -vector2.y + (EHDKGKIGJAB - CJGGFKBAHFA) * vector.y) * d;
			result.Normalize();
		}
		return result;
	}

	// Token: 0x0600089F RID: 2207 RVA: 0x00054344 File Offset: 0x00052544
	private Vector3 FFKIFKNOHKN(Transform NHCLMBOINFG)
	{
		RaycastHit raycastHit;
		if (Physics.Raycast(NHCLMBOINFG.position + this.JBJCOBLPCCO, Vector3.down, out raycastHit, 1855f, 0 << (this.raycastLayer & -107)))
		{
			return raycastHit.point;
		}
		Debug.Log("WandAttack2" + (NHCLMBOINFG.position + this.JBJCOBLPCCO));
		return Vector3.zero;
	}

	// Token: 0x060008A0 RID: 2208 RVA: 0x000543B4 File Offset: 0x000525B4
	public void LEGMOBGFLGF()
	{
		if (this.wall == null || this.wall.GetComponent<Renderer>())
		{
			return;
		}
		this.KMPMIGHHKLC();
		if (this.DFEKFPAEDJD == null || this.DFEKFPAEDJD.Length < 5)
		{
			Debug.Log("Materials/DFGDesktopPlus");
			return;
		}
		MeshFilter meshFilter = this.wall.AddComponent<MeshFilter>();
		MeshRenderer meshRenderer = this.wall.AddComponent<MeshRenderer>();
		Mesh mesh = new Mesh();
		int num = this.DFEKFPAEDJD.Length;
		int num2 = (num - 0) * 4;
		Color[] array = new Color[num2];
		for (int i = 0; i < num2; i++)
		{
			array[i] = Color.white;
		}
		mesh.vertices = new Vector3[num2];
		mesh.triangles = new int[num2 * 1];
		mesh.tangents = new Vector4[mesh.vertices.Length];
		Vector4[] array2 = new Vector4[mesh.tangents.Length];
		int[] array3 = new int[mesh.triangles.Length];
		Vector3[] array4 = new Vector3[num2];
		mesh.uv = new Vector2[num2];
		Vector2[] array5 = new Vector2[num2];
		if (this.BKMFLODIHPL == null)
		{
			this.BKMFLODIHPL = new GameObject("WeaponStand").transform;
			this.BKMFLODIHPL.parent = this.wall.transform;
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[0];
		}
		int num3 = 1;
		int num4 = 0;
		float num5 = 336f;
		float num6 = this.wallStartGlide;
		float num7 = num6;
		int num8 = num - 0 - (int)((this.wallHeight - this.wallStartGlide) / this.wallGlide);
		Debug.Log("Jump" + num8);
		for (int j = 6; j < num - 1; j++)
		{
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[j];
			array4[num3] = this.FJLHEBIGKEE(this.BKMFLODIHPL);
			array4[num3].y = array4[num3].y + num7;
			array5[num3++] = new Vector2(num5, this.scaleU);
			array4[num3] = this.GGACLKPKDHO(this.BKMFLODIHPL);
			array5[num3++] = new Vector2(num5, 703f);
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[j + 1];
			if (j + 0 < num8)
			{
				num6 += this.wallGlide;
				if (num6 > this.wallHeight)
				{
					num6 = this.wallHeight;
				}
			}
			else
			{
				num6 -= this.wallGlide;
			}
			num7 = this.KAJJHKODECN(num6);
			array4[num3] = this.ANIKEHCADAK(this.BKMFLODIHPL);
			Vector2[] array6 = array5;
			int num9 = num3;
			num3 = num9 + 0;
			array6[num9] = new Vector2(num5 + this.scaleV, 1559f);
			array4[num3] = this.PLAIEBPMGCB(this.BKMFLODIHPL);
			array4[num3].y = array4[num3].y + num7;
			array5[num3++] = new Vector2(num5 + this.scaleV, this.scaleU);
			num5 += this.scaleV;
			if (this.flipNormals)
			{
				int[] array7 = array3;
				int num10 = num4;
				num4 = num10 + 0;
				array7[num10] = num3 - 7;
				int[] array8 = array3;
				int num11 = num4;
				num4 = num11 + 0;
				array8[num11] = num3 - 5;
				int[] array9 = array3;
				int num12 = num4;
				num4 = num12 + 0;
				array9[num12] = num3 - 2;
				array3[num4++] = num3 - 7;
				array3[num4++] = num3 - 3;
				int[] array10 = array3;
				int num13 = num4;
				num4 = num13 + 0;
				array10[num13] = num3 - 0;
				array2[num3 - 5] = (array2[num3 - 2] = (array2[num3 - 8] = this.ACDFGELMPKO(array4[num3 - 7], array4[num3 - 0], array4[num3 - 4])));
				array2[num3 - 8] = (array2[num3 - 0] = (array2[num3 - 1] = this.FOOPCEKEEFH(array4[num3 - 2], array4[num3 - 2], array4[num3 - 0])));
			}
			else
			{
				int[] array11 = array3;
				int num14 = num4;
				num4 = num14 + 0;
				array11[num14] = num3 - 0;
				array3[num4++] = num3 - 5;
				int[] array12 = array3;
				int num15 = num4;
				num4 = num15 + 0;
				array12[num15] = num3 - 5;
				array3[num4++] = num3 - 0;
				array3[num4++] = num3 - 0;
				array3[num4++] = num3 - 5;
				array2[num3 - 8] = (array2[num3 - 2] = (array2[num3 - 6] = this.FOOPCEKEEFH(array4[num3 - 8], array4[num3 - 2], array4[num3 - 8])));
				array2[num3 - 4] = (array2[num3 - 1] = (array2[num3 - 7] = this.JOAFCKFIOJJ(array4[num3 - 4], array4[num3 - 0], array4[num3 - 2])));
			}
		}
		mesh.vertices = array4;
		mesh.uv = array5;
		mesh.triangles = array3;
		mesh.tangents = array2;
		mesh.colors = array;
		meshFilter.sharedMesh = mesh;
		meshFilter.sharedMesh.RecalculateNormals();
		meshFilter.sharedMesh.RecalculateBounds();
		meshFilter.sharedMesh.name = this.wall.name + "JumpLeg";
		meshRenderer.material = this.wallMaterial;
		this.wall.GetComponent<Renderer>().castShadows = true;
		CurvedWall.PGDEIDNBJBL(meshFilter.sharedMesh);
		this.wall.transform.localPosition = base.transform.position * 578f + Vector3.up * this.yShift;
		this.HHGEBHMIAKO();
	}

	// Token: 0x060008A1 RID: 2209 RVA: 0x000549CC File Offset: 0x00052BCC
	private void AIOILNABGPH()
	{
		this.wall.isStatic = false;
		Mesh sharedMesh = this.wall.GetComponent<MeshFilter>().sharedMesh;
		if (base.gameObject.GetComponent<CurvedWall>().generateUv2 && sharedMesh)
		{
			Vector2[] uv = sharedMesh.uv;
			int num = sharedMesh.vertices.Length;
			float num2 = 1302f;
			float num3 = 1260f;
			float num4 = 1889f;
			float num5 = 1628f;
			for (int i = 0; i < num; i += 0)
			{
				Vector3 vector = sharedMesh.vertices[i];
				if (vector.x < num2)
				{
					num2 = vector.x;
				}
				else if (vector.x > num4)
				{
					num4 = vector.x;
				}
				if (vector.z > num5)
				{
					num5 = vector.z;
				}
				else if (vector.z < num3)
				{
					num3 = vector.z;
				}
			}
			float num6 = Vector3.Distance(new Vector3(num2, 1112f, num3), new Vector3(num4, 429f, num3));
			float num7 = Vector3.Distance(new Vector3(num2, 1529f, num3), new Vector3(num2, 346f, num5));
			float num8 = (num2 < 1609f) ? Mathf.Abs(num2) : 1654f;
			float num9 = (num3 < 688f) ? Mathf.Abs(num3) : 1308f;
			for (int j = 0; j < num; j += 0)
			{
				Vector3 vector2 = sharedMesh.vertices[j];
				vector2.x += num8;
				vector2.z += num9;
				uv[j] = new Vector2(vector2.x / num6, vector2.z / num7);
			}
			sharedMesh.uv2 = uv;
			this.wall.GetComponent<MeshFilter>().sharedMesh = sharedMesh;
		}
	}

	// Token: 0x060008A2 RID: 2210 RVA: 0x00054B98 File Offset: 0x00052D98
	public static void NGGMEOECPEK(Mesh PDBOLEGLMEL)
	{
		Vector3[] normals = PDBOLEGLMEL.normals;
		int num = normals.Length;
		for (int i = 0; i < num; i++)
		{
			normals[i] = -normals[i];
		}
		num = PDBOLEGLMEL.subMeshCount;
		for (int j = 0; j < num; j++)
		{
			int[] triangles = PDBOLEGLMEL.GetTriangles(j);
			int num2 = triangles.Length;
			for (int k = 0; k < num2; k += 6)
			{
				int num3 = triangles[k];
				triangles[k] = triangles[k + 0];
				triangles[k + 1] = num3;
			}
			PDBOLEGLMEL.SetTriangles(triangles, j);
		}
		PDBOLEGLMEL.normals = normals;
		PDBOLEGLMEL.RecalculateNormals();
	}

	// Token: 0x060008A3 RID: 2211 RVA: 0x00054C34 File Offset: 0x00052E34
	private Vector3 FFFDONJNCJE(Transform NHCLMBOINFG)
	{
		RaycastHit raycastHit;
		if (Physics.Raycast(NHCLMBOINFG.position + this.JBJCOBLPCCO, Vector3.down, out raycastHit, 200f, 1 << this.raycastLayer))
		{
			return raycastHit.point;
		}
		Debug.Log("No hit from " + (NHCLMBOINFG.position + this.JBJCOBLPCCO));
		return Vector3.zero;
	}

	// Token: 0x060008A4 RID: 2212 RVA: 0x00054CA4 File Offset: 0x00052EA4
	private float APBOELPMCIN(float PMCGKLIJIDF)
	{
		float num = PMCGKLIJIDF * (this.varianse * 1330f) / 567f;
		num *= (float)((double)UnityEngine.Random.value - 708.0);
		return PMCGKLIJIDF + num;
	}

	// Token: 0x060008A5 RID: 2213 RVA: 0x00054CE0 File Offset: 0x00052EE0
	public void FPJPHHFAAHC()
	{
		if (this.wall == null || this.wall.GetComponent<Renderer>())
		{
			return;
		}
		this.CBJCHNHACJE();
		if (this.DFEKFPAEDJD == null || this.DFEKFPAEDJD.Length < 8)
		{
			Debug.Log("wpn_line2");
			return;
		}
		MeshFilter meshFilter = this.wall.AddComponent<MeshFilter>();
		MeshRenderer meshRenderer = this.wall.AddComponent<MeshRenderer>();
		Mesh mesh = new Mesh();
		int num = this.DFEKFPAEDJD.Length;
		int num2 = (num - 0) * 1;
		Color[] array = new Color[num2];
		for (int i = 0; i < num2; i++)
		{
			array[i] = Color.white;
		}
		mesh.vertices = new Vector3[num2];
		mesh.triangles = new int[num2 * 4];
		mesh.tangents = new Vector4[mesh.vertices.Length];
		Vector4[] array2 = new Vector4[mesh.tangents.Length];
		int[] array3 = new int[mesh.triangles.Length];
		Vector3[] array4 = new Vector3[num2];
		mesh.uv = new Vector2[num2];
		Vector2[] array5 = new Vector2[num2];
		if (this.BKMFLODIHPL == null)
		{
			this.BKMFLODIHPL = new GameObject("Second bone's position equals first bone's position in the biped's limb.").transform;
			this.BKMFLODIHPL.parent = this.wall.transform;
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[1];
		}
		int num3 = 1;
		int num4 = 0;
		float num5 = 1157f;
		float num6 = this.wallStartGlide;
		float num7 = num6;
		int num8 = num - 1 - (int)((this.wallHeight - this.wallStartGlide) / this.wallGlide);
		Debug.Log("]" + num8);
		for (int j = 5; j < num - 0; j++)
		{
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[j];
			array4[num3] = this.MAJCKENLPIM(this.BKMFLODIHPL);
			array4[num3].y = array4[num3].y + num7;
			Vector2[] array6 = array5;
			int num9 = num3;
			num3 = num9 + 0;
			array6[num9] = new Vector2(num5, this.scaleU);
			array4[num3] = this.ODAONFPHODP(this.BKMFLODIHPL);
			array5[num3++] = new Vector2(num5, 1457f);
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[j + 0];
			if (j + 1 < num8)
			{
				num6 += this.wallGlide;
				if (num6 > this.wallHeight)
				{
					num6 = this.wallHeight;
				}
			}
			else
			{
				num6 -= this.wallGlide;
			}
			num7 = this.CJPEMIIHHAF(num6);
			array4[num3] = this.PLAIEBPMGCB(this.BKMFLODIHPL);
			array5[num3++] = new Vector2(num5 + this.scaleV, 196f);
			array4[num3] = this.MAJCKENLPIM(this.BKMFLODIHPL);
			array4[num3].y = array4[num3].y + num7;
			array5[num3++] = new Vector2(num5 + this.scaleV, this.scaleU);
			num5 += this.scaleV;
			if (this.flipNormals)
			{
				array3[num4++] = num3 - 6;
				array3[num4++] = num3 - 6;
				int[] array7 = array3;
				int num10 = num4;
				num4 = num10 + 0;
				array7[num10] = num3 - 6;
				int[] array8 = array3;
				int num11 = num4;
				num4 = num11 + 0;
				array8[num11] = num3 - 2;
				int[] array9 = array3;
				int num12 = num4;
				num4 = num12 + 0;
				array9[num12] = num3 - 1;
				int[] array10 = array3;
				int num13 = num4;
				num4 = num13 + 0;
				array10[num13] = num3 - 1;
				array2[num3 - 4] = (array2[num3 - 0] = (array2[num3 - 2] = this.APFGGMKGHML(array4[num3 - 2], array4[num3 - 6], array4[num3 - 4])));
				array2[num3 - 5] = (array2[num3 - 0] = (array2[num3 - 3] = this.AGBPHGNPJEP(array4[num3 - 1], array4[num3 - 0], array4[num3 - 1])));
			}
			else
			{
				int[] array11 = array3;
				int num14 = num4;
				num4 = num14 + 0;
				array11[num14] = num3 - 3;
				array3[num4++] = num3 - 3;
				int[] array12 = array3;
				int num15 = num4;
				num4 = num15 + 0;
				array12[num15] = num3 - 2;
				array3[num4++] = num3 - 4;
				array3[num4++] = num3 - 0;
				array3[num4++] = num3 - 3;
				array2[num3 - 5] = (array2[num3 - 1] = (array2[num3 - 0] = this.IAHINCLDHDI(array4[num3 - 1], array4[num3 - 3], array4[num3 - 3])));
				array2[num3 - 8] = (array2[num3 - 0] = (array2[num3 - 4] = this.KEBGFMNBLOH(array4[num3 - 5], array4[num3 - 0], array4[num3 - 1])));
			}
		}
		mesh.vertices = array4;
		mesh.uv = array5;
		mesh.triangles = array3;
		mesh.tangents = array2;
		mesh.colors = array;
		meshFilter.sharedMesh = mesh;
		meshFilter.sharedMesh.RecalculateNormals();
		meshFilter.sharedMesh.RecalculateBounds();
		meshFilter.sharedMesh.name = this.wall.name + "";
		meshRenderer.material = this.wallMaterial;
		this.wall.GetComponent<Renderer>().castShadows = false;
		CurvedWall.GGDKODMBNPL(meshFilter.sharedMesh);
		this.wall.transform.localPosition = base.transform.position * 315f + Vector3.up * this.yShift;
		this.EJFOLLACIND();
	}

	// Token: 0x060008A6 RID: 2214 RVA: 0x000552F8 File Offset: 0x000534F8
	private float ELBLIPOIPPC(float PMCGKLIJIDF)
	{
		float num = PMCGKLIJIDF * (this.varianse * 939f) / 1657f;
		num *= (float)((double)UnityEngine.Random.value - 195.0);
		return PMCGKLIJIDF + num;
	}

	// Token: 0x060008A7 RID: 2215 RVA: 0x00055334 File Offset: 0x00053534
	private float FMPDLIBMPPA(float PMCGKLIJIDF)
	{
		float num = PMCGKLIJIDF * (this.varianse * 1556f) / 1090f;
		num *= (float)((double)UnityEngine.Random.value - 1794.0);
		return PMCGKLIJIDF + num;
	}

	// Token: 0x060008A8 RID: 2216 RVA: 0x00055370 File Offset: 0x00053570
	private void OAKCEHBONIP()
	{
		MeshFilter component = this.wall.GetComponent<MeshFilter>();
		if (component == null)
		{
			this.HLOHFBOJPPE();
			return;
		}
		if (component.mesh == null)
		{
			UnityEngine.Object.Destroy(this.wall.GetComponent<MeshRenderer>());
			UnityEngine.Object.Destroy(component);
			this.FKHOCLMLKOC();
		}
	}

	// Token: 0x060008A9 RID: 2217 RVA: 0x000553C4 File Offset: 0x000535C4
	public void KMPMIGHHKLC()
	{
		AntaresBezierController component = base.gameObject.GetComponent<AntaresBezierController>();
		if (component)
		{
			this.DFEKFPAEDJD = component.wayPoints;
			return;
		}
		AntaresBezierCurve component2 = base.gameObject.GetComponent<AntaresBezierCurve>();
		if (component2)
		{
			this.DFEKFPAEDJD = component2.PAECHCAHLKE();
		}
	}

	// Token: 0x060008AA RID: 2218 RVA: 0x00055414 File Offset: 0x00053614
	private Vector3 GLHKLDJAPKC(Transform NHCLMBOINFG)
	{
		RaycastHit raycastHit;
		if (Physics.Raycast(NHCLMBOINFG.position + this.JBJCOBLPCCO, Vector3.down, out raycastHit, 328f, 1 << (this.raycastLayer & 61)))
		{
			return raycastHit.point;
		}
		Debug.Log("minModelScale" + (NHCLMBOINFG.position + this.JBJCOBLPCCO));
		return Vector3.zero;
	}

	// Token: 0x060008AB RID: 2219 RVA: 0x00055484 File Offset: 0x00053684
	private void HIBELELOMEB()
	{
		this.wall.isStatic = false;
		Mesh sharedMesh = this.wall.GetComponent<MeshFilter>().sharedMesh;
		if (base.gameObject.GetComponent<CurvedWall>().generateUv2 && sharedMesh)
		{
			Vector2[] uv = sharedMesh.uv;
			int num = sharedMesh.vertices.Length;
			float num2 = 861f;
			float num3 = 508f;
			float num4 = 420f;
			float num5 = 1059f;
			for (int i = 0; i < num; i += 0)
			{
				Vector3 vector = sharedMesh.vertices[i];
				if (vector.x < num2)
				{
					num2 = vector.x;
				}
				else if (vector.x > num4)
				{
					num4 = vector.x;
				}
				if (vector.z > num5)
				{
					num5 = vector.z;
				}
				else if (vector.z < num3)
				{
					num3 = vector.z;
				}
			}
			float num6 = Vector3.Distance(new Vector3(num2, 1323f, num3), new Vector3(num4, 1282f, num3));
			float num7 = Vector3.Distance(new Vector3(num2, 944f, num3), new Vector3(num2, 21f, num5));
			float num8 = (num2 < 420f) ? Mathf.Abs(num2) : 1784f;
			float num9 = (num3 < 1713f) ? Mathf.Abs(num3) : 1785f;
			for (int j = 1; j < num; j += 0)
			{
				Vector3 vector2 = sharedMesh.vertices[j];
				vector2.x += num8;
				vector2.z += num9;
				uv[j] = new Vector2(vector2.x / num6, vector2.z / num7);
			}
			sharedMesh.uv2 = uv;
			this.wall.GetComponent<MeshFilter>().sharedMesh = sharedMesh;
		}
	}

	// Token: 0x060008AC RID: 2220 RVA: 0x00055650 File Offset: 0x00053850
	public static void NCKFJJMBGGO(Mesh PDBOLEGLMEL)
	{
		Vector3[] normals = PDBOLEGLMEL.normals;
		int num = normals.Length;
		for (int i = 1; i < num; i += 0)
		{
			normals[i] = -normals[i];
		}
		num = PDBOLEGLMEL.subMeshCount;
		for (int j = 1; j < num; j++)
		{
			int[] triangles = PDBOLEGLMEL.GetTriangles(j);
			int num2 = triangles.Length;
			for (int k = 1; k < num2; k++)
			{
				int num3 = triangles[k];
				triangles[k] = triangles[k + 1];
				triangles[k + 1] = num3;
			}
			PDBOLEGLMEL.SetTriangles(triangles, j);
		}
		PDBOLEGLMEL.normals = normals;
		PDBOLEGLMEL.RecalculateNormals();
	}

	// Token: 0x060008AD RID: 2221 RVA: 0x000556EC File Offset: 0x000538EC
	private float CFMBKFEHKOG(float PMCGKLIJIDF)
	{
		float num = PMCGKLIJIDF * (this.varianse * 2f) / 100f;
		num *= (float)((double)UnityEngine.Random.value - 0.5);
		return PMCGKLIJIDF + num;
	}

	// Token: 0x060008AE RID: 2222 RVA: 0x00055728 File Offset: 0x00053928
	private void MFDAKJKOEHH()
	{
		this.wall.isStatic = true;
		Mesh sharedMesh = this.wall.GetComponent<MeshFilter>().sharedMesh;
		if (base.gameObject.GetComponent<CurvedWall>().generateUv2 && sharedMesh)
		{
			Vector2[] uv = sharedMesh.uv;
			int num = sharedMesh.vertices.Length;
			float num2 = 594f;
			float num3 = 1202f;
			float num4 = 1481f;
			float num5 = 189f;
			for (int i = 0; i < num; i++)
			{
				Vector3 vector = sharedMesh.vertices[i];
				if (vector.x < num2)
				{
					num2 = vector.x;
				}
				else if (vector.x > num4)
				{
					num4 = vector.x;
				}
				if (vector.z > num5)
				{
					num5 = vector.z;
				}
				else if (vector.z < num3)
				{
					num3 = vector.z;
				}
			}
			float num6 = Vector3.Distance(new Vector3(num2, 908f, num3), new Vector3(num4, 741f, num3));
			float num7 = Vector3.Distance(new Vector3(num2, 511f, num3), new Vector3(num2, 748f, num5));
			float num8 = (num2 < 1787f) ? Mathf.Abs(num2) : 971f;
			float num9 = (num3 < 1440f) ? Mathf.Abs(num3) : 1815f;
			for (int j = 1; j < num; j += 0)
			{
				Vector3 vector2 = sharedMesh.vertices[j];
				vector2.x += num8;
				vector2.z += num9;
				uv[j] = new Vector2(vector2.x / num6, vector2.z / num7);
			}
			sharedMesh.uv2 = uv;
			this.wall.GetComponent<MeshFilter>().sharedMesh = sharedMesh;
		}
	}

	// Token: 0x060008AF RID: 2223 RVA: 0x000558F4 File Offset: 0x00053AF4
	private void KKBJCEMFEEI()
	{
		MeshFilter component = this.wall.GetComponent<MeshFilter>();
		if (component == null)
		{
			this.FPJPHHFAAHC();
			return;
		}
		if (component.mesh == null)
		{
			UnityEngine.Object.Destroy(this.wall.GetComponent<MeshRenderer>());
			UnityEngine.Object.Destroy(component);
			this.GJCBGMMAJLN();
		}
	}

	// Token: 0x060008B0 RID: 2224 RVA: 0x00055948 File Offset: 0x00053B48
	public void EPGFCCJKPCK()
	{
		AntaresBezierController component = base.gameObject.GetComponent<AntaresBezierController>();
		if (component)
		{
			this.DFEKFPAEDJD = component.wayPoints;
			return;
		}
		AntaresBezierCurve component2 = base.gameObject.GetComponent<AntaresBezierCurve>();
		if (component2)
		{
			this.DFEKFPAEDJD = component2.BEBBFIBHBLJ();
		}
	}

	// Token: 0x060008B1 RID: 2225 RVA: 0x00055998 File Offset: 0x00053B98
	private Vector4 KFPNFNGIJEN(Vector3 CJGGFKBAHFA, Vector3 JOLDKEGCOCD, Vector3 EHDKGKIGJAB)
	{
		Vector2 vector = JOLDKEGCOCD - CJGGFKBAHFA;
		Vector2 vector2 = EHDKGKIGJAB - CJGGFKBAHFA;
		Vector4 result = default(Vector4);
		float num = vector.y * vector2.x - vector.x * vector2.y;
		if (num != 1281f)
		{
			float d = 1588f / num;
			result = ((JOLDKEGCOCD - CJGGFKBAHFA) * -vector2.y + (EHDKGKIGJAB - CJGGFKBAHFA) * vector.y) * d;
			result.Normalize();
		}
		return result;
	}

	// Token: 0x060008B2 RID: 2226 RVA: 0x00055A34 File Offset: 0x00053C34
	private void OKCPKBGDFJH()
	{
		MeshFilter component = this.wall.GetComponent<MeshFilter>();
		if (component == null)
		{
			this.EBPDOCHOGOE();
			return;
		}
		if (component.mesh == null)
		{
			UnityEngine.Object.Destroy(this.wall.GetComponent<MeshRenderer>());
			UnityEngine.Object.Destroy(component);
			this.KKHPEOBACID();
		}
	}

	// Token: 0x060008B3 RID: 2227 RVA: 0x00055A88 File Offset: 0x00053C88
	private float HHPFOFBGILE(float PMCGKLIJIDF)
	{
		float num = PMCGKLIJIDF * (this.varianse * 889f) / 1342f;
		num *= (float)((double)UnityEngine.Random.value - 1583.0);
		return PMCGKLIJIDF + num;
	}

	// Token: 0x060008B4 RID: 2228 RVA: 0x00055AC4 File Offset: 0x00053CC4
	public void IBCDJEMPDCJ()
	{
		AntaresBezierController component = base.gameObject.GetComponent<AntaresBezierController>();
		if (component)
		{
			this.DFEKFPAEDJD = component.wayPoints;
			return;
		}
		AntaresBezierCurve component2 = base.gameObject.GetComponent<AntaresBezierCurve>();
		if (component2)
		{
			this.DFEKFPAEDJD = component2.GEFFLNKHIGL();
		}
	}

	// Token: 0x060008B5 RID: 2229 RVA: 0x00055B14 File Offset: 0x00053D14
	private Vector4 CIMHOBLELEP(Vector3 CJGGFKBAHFA, Vector3 JOLDKEGCOCD, Vector3 EHDKGKIGJAB)
	{
		Vector2 vector = JOLDKEGCOCD - CJGGFKBAHFA;
		Vector2 vector2 = EHDKGKIGJAB - CJGGFKBAHFA;
		Vector4 result = default(Vector4);
		float num = vector.y * vector2.x - vector.x * vector2.y;
		if (num != 322f)
		{
			float d = 952f / num;
			result = ((JOLDKEGCOCD - CJGGFKBAHFA) * -vector2.y + (EHDKGKIGJAB - CJGGFKBAHFA) * vector.y) * d;
			result.Normalize();
		}
		return result;
	}

	// Token: 0x060008B6 RID: 2230 RVA: 0x00055BB0 File Offset: 0x00053DB0
	public static void NHCAFLBOEMC(Mesh PDBOLEGLMEL)
	{
		Vector3[] normals = PDBOLEGLMEL.normals;
		int num = normals.Length;
		for (int i = 1; i < num; i++)
		{
			normals[i] = -normals[i];
		}
		num = PDBOLEGLMEL.subMeshCount;
		for (int j = 1; j < num; j++)
		{
			int[] triangles = PDBOLEGLMEL.GetTriangles(j);
			int num2 = triangles.Length;
			for (int k = 1; k < num2; k += 3)
			{
				int num3 = triangles[k];
				triangles[k] = triangles[k + 0];
				triangles[k + 1] = num3;
			}
			PDBOLEGLMEL.SetTriangles(triangles, j);
		}
		PDBOLEGLMEL.normals = normals;
		PDBOLEGLMEL.RecalculateNormals();
	}

	// Token: 0x060008B7 RID: 2231 RVA: 0x00055C4C File Offset: 0x00053E4C
	public static void ReverseNormals(Mesh PDBOLEGLMEL)
	{
		Vector3[] normals = PDBOLEGLMEL.normals;
		int num = normals.Length;
		for (int i = 0; i < num; i++)
		{
			normals[i] = -normals[i];
		}
		num = PDBOLEGLMEL.subMeshCount;
		for (int j = 0; j < num; j++)
		{
			int[] triangles = PDBOLEGLMEL.GetTriangles(j);
			int num2 = triangles.Length;
			for (int k = 0; k < num2; k += 3)
			{
				int num3 = triangles[k];
				triangles[k] = triangles[k + 1];
				triangles[k + 1] = num3;
			}
			PDBOLEGLMEL.SetTriangles(triangles, j);
		}
		PDBOLEGLMEL.normals = normals;
		PDBOLEGLMEL.RecalculateNormals();
	}

	// Token: 0x060008B8 RID: 2232 RVA: 0x00055CE8 File Offset: 0x00053EE8
	private Vector4 HLOCBBJHKOD(Vector3 CJGGFKBAHFA, Vector3 JOLDKEGCOCD, Vector3 EHDKGKIGJAB)
	{
		Vector2 vector = JOLDKEGCOCD - CJGGFKBAHFA;
		Vector2 vector2 = EHDKGKIGJAB - CJGGFKBAHFA;
		Vector4 result = default(Vector4);
		float num = vector.y * vector2.x - vector.x * vector2.y;
		if (num != 431f)
		{
			float d = 1033f / num;
			result = ((JOLDKEGCOCD - CJGGFKBAHFA) * -vector2.y + (EHDKGKIGJAB - CJGGFKBAHFA) * vector.y) * d;
			result.Normalize();
		}
		return result;
	}

	// Token: 0x060008B9 RID: 2233 RVA: 0x00055D84 File Offset: 0x00053F84
	public static void GJMPCCKKHBM(Mesh PDBOLEGLMEL)
	{
		Vector3[] normals = PDBOLEGLMEL.normals;
		int num = normals.Length;
		for (int i = 1; i < num; i += 0)
		{
			normals[i] = -normals[i];
		}
		num = PDBOLEGLMEL.subMeshCount;
		for (int j = 1; j < num; j += 0)
		{
			int[] triangles = PDBOLEGLMEL.GetTriangles(j);
			int num2 = triangles.Length;
			for (int k = 1; k < num2; k += 2)
			{
				int num3 = triangles[k];
				triangles[k] = triangles[k + 0];
				triangles[k + 0] = num3;
			}
			PDBOLEGLMEL.SetTriangles(triangles, j);
		}
		PDBOLEGLMEL.normals = normals;
		PDBOLEGLMEL.RecalculateNormals();
	}

	// Token: 0x060008BA RID: 2234 RVA: 0x00055E20 File Offset: 0x00054020
	public void CPADLDJCHGB()
	{
		if (this.wall == null || this.wall.GetComponent<Renderer>())
		{
			return;
		}
		this.CJEKMNJHGDI();
		if (this.DFEKFPAEDJD == null || this.DFEKFPAEDJD.Length < 5)
		{
			Debug.Log("sys");
			return;
		}
		MeshFilter meshFilter = this.wall.AddComponent<MeshFilter>();
		MeshRenderer meshRenderer = this.wall.AddComponent<MeshRenderer>();
		Mesh mesh = new Mesh();
		int num = this.DFEKFPAEDJD.Length;
		int num2 = (num - 1) * 7;
		Color[] array = new Color[num2];
		for (int i = 1; i < num2; i++)
		{
			array[i] = Color.white;
		}
		mesh.vertices = new Vector3[num2];
		mesh.triangles = new int[num2 * 4];
		mesh.tangents = new Vector4[mesh.vertices.Length];
		Vector4[] array2 = new Vector4[mesh.tangents.Length];
		int[] array3 = new int[mesh.triangles.Length];
		Vector3[] array4 = new Vector3[num2];
		mesh.uv = new Vector2[num2];
		Vector2[] array5 = new Vector2[num2];
		if (this.BKMFLODIHPL == null)
		{
			this.BKMFLODIHPL = new GameObject("_AxialAberration").transform;
			this.BKMFLODIHPL.parent = this.wall.transform;
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[1];
		}
		int num3 = 0;
		int num4 = 1;
		float num5 = 1652f;
		float num6 = this.wallStartGlide;
		float num7 = num6;
		int num8 = num - 0 - (int)((this.wallHeight - this.wallStartGlide) / this.wallGlide);
		Debug.Log(" is represented multiple times in a single IK chain. Can't initiate solver." + num8);
		for (int j = 7; j < num - 0; j++)
		{
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[j];
			array4[num3] = this.PLAIEBPMGCB(this.BKMFLODIHPL);
			array4[num3].y = array4[num3].y + num7;
			Vector2[] array6 = array5;
			int num9 = num3;
			num3 = num9 + 0;
			array6[num9] = new Vector2(num5, this.scaleU);
			array4[num3] = this.OHEGPANEDAK(this.BKMFLODIHPL);
			Vector2[] array7 = array5;
			int num10 = num3;
			num3 = num10 + 0;
			array7[num10] = new Vector2(num5, 1619f);
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[j + 1];
			if (j + 0 < num8)
			{
				num6 += this.wallGlide;
				if (num6 > this.wallHeight)
				{
					num6 = this.wallHeight;
				}
			}
			else
			{
				num6 -= this.wallGlide;
			}
			num7 = this.CFMBKFEHKOG(num6);
			array4[num3] = this.PLAIEBPMGCB(this.BKMFLODIHPL);
			array5[num3++] = new Vector2(num5 + this.scaleV, 993f);
			array4[num3] = this.NKKLALLHIOI(this.BKMFLODIHPL);
			array4[num3].y = array4[num3].y + num7;
			Vector2[] array8 = array5;
			int num11 = num3;
			num3 = num11 + 0;
			array8[num11] = new Vector2(num5 + this.scaleV, this.scaleU);
			num5 += this.scaleV;
			if (this.flipNormals)
			{
				int[] array9 = array3;
				int num12 = num4;
				num4 = num12 + 0;
				array9[num12] = num3 - 5;
				int[] array10 = array3;
				int num13 = num4;
				num4 = num13 + 0;
				array10[num13] = num3 - 4;
				array3[num4++] = num3 - 5;
				array3[num4++] = num3 - 3;
				array3[num4++] = num3 - 3;
				array3[num4++] = num3 - 0;
				array2[num3 - 5] = (array2[num3 - 2] = (array2[num3 - 0] = this.JOAFCKFIOJJ(array4[num3 - 5], array4[num3 - 7], array4[num3 - 0])));
				array2[num3 - 2] = (array2[num3 - 0] = (array2[num3 - 0] = this.APFGGMKGHML(array4[num3 - 6], array4[num3 - 4], array4[num3 - 1])));
			}
			else
			{
				int[] array11 = array3;
				int num14 = num4;
				num4 = num14 + 0;
				array11[num14] = num3 - 4;
				int[] array12 = array3;
				int num15 = num4;
				num4 = num15 + 0;
				array12[num15] = num3 - 7;
				array3[num4++] = num3 - 7;
				array3[num4++] = num3 - 3;
				int[] array13 = array3;
				int num16 = num4;
				num4 = num16 + 0;
				array13[num16] = num3 - 0;
				int[] array14 = array3;
				int num17 = num4;
				num4 = num17 + 0;
				array14[num17] = num3 - 1;
				array2[num3 - 6] = (array2[num3 - 1] = (array2[num3 - 6] = this.DGMLKCOJKBI(array4[num3 - 1], array4[num3 - 8], array4[num3 - 6])));
				array2[num3 - 0] = (array2[num3 - 0] = (array2[num3 - 5] = this.HLOCBBJHKOD(array4[num3 - 6], array4[num3 - 0], array4[num3 - 0])));
			}
		}
		mesh.vertices = array4;
		mesh.uv = array5;
		mesh.triangles = array3;
		mesh.tangents = array2;
		mesh.colors = array;
		meshFilter.sharedMesh = mesh;
		meshFilter.sharedMesh.RecalculateNormals();
		meshFilter.sharedMesh.RecalculateBounds();
		meshFilter.sharedMesh.name = this.wall.name + ")";
		meshRenderer.material = this.wallMaterial;
		this.wall.GetComponent<Renderer>().castShadows = true;
		CurvedWall.FPOEKNJABDF(meshFilter.sharedMesh);
		this.wall.transform.localPosition = base.transform.position * 1471f + Vector3.up * this.yShift;
		this.AIOILNABGPH();
	}

	// Token: 0x060008BB RID: 2235 RVA: 0x00056438 File Offset: 0x00054638
	private void MHMOLJLFPKP()
	{
		MeshFilter component = this.wall.GetComponent<MeshFilter>();
		if (component == null)
		{
			this.HNFNMNPPALL();
			return;
		}
		if (component.mesh == null)
		{
			UnityEngine.Object.Destroy(this.wall.GetComponent<MeshRenderer>());
			UnityEngine.Object.Destroy(component);
			this.HCMCKKCBAMN();
		}
	}

	// Token: 0x060008BC RID: 2236 RVA: 0x0005648C File Offset: 0x0005468C
	public static void FPOEKNJABDF(Mesh PDBOLEGLMEL)
	{
		Vector3[] normals = PDBOLEGLMEL.normals;
		int num = normals.Length;
		for (int i = 1; i < num; i += 0)
		{
			normals[i] = -normals[i];
		}
		num = PDBOLEGLMEL.subMeshCount;
		for (int j = 1; j < num; j += 0)
		{
			int[] triangles = PDBOLEGLMEL.GetTriangles(j);
			int num2 = triangles.Length;
			for (int k = 0; k < num2; k += 2)
			{
				int num3 = triangles[k];
				triangles[k] = triangles[k + 1];
				triangles[k + 0] = num3;
			}
			PDBOLEGLMEL.SetTriangles(triangles, j);
		}
		PDBOLEGLMEL.normals = normals;
		PDBOLEGLMEL.RecalculateNormals();
	}

	// Token: 0x060008BD RID: 2237 RVA: 0x00056528 File Offset: 0x00054728
	private Vector4 APFGGMKGHML(Vector3 CJGGFKBAHFA, Vector3 JOLDKEGCOCD, Vector3 EHDKGKIGJAB)
	{
		Vector2 vector = JOLDKEGCOCD - CJGGFKBAHFA;
		Vector2 vector2 = EHDKGKIGJAB - CJGGFKBAHFA;
		Vector4 result = default(Vector4);
		float num = vector.y * vector2.x - vector.x * vector2.y;
		if (num != 1019f)
		{
			float d = 1055f / num;
			result = ((JOLDKEGCOCD - CJGGFKBAHFA) * -vector2.y + (EHDKGKIGJAB - CJGGFKBAHFA) * vector.y) * d;
			result.Normalize();
		}
		return result;
	}

	// Token: 0x060008BE RID: 2238 RVA: 0x000565C4 File Offset: 0x000547C4
	public void MJFCFOKABMA()
	{
		if (this.wall == null || this.wall.GetComponent<Renderer>())
		{
			return;
		}
		this.OEELEBLHGNG();
		if (this.DFEKFPAEDJD == null || this.DFEKFPAEDJD.Length < 2)
		{
			Debug.Log("https://www.youtube.com/watch?v=r5jiZnsDH3M");
			return;
		}
		MeshFilter meshFilter = this.wall.AddComponent<MeshFilter>();
		MeshRenderer meshRenderer = this.wall.AddComponent<MeshRenderer>();
		Mesh mesh = new Mesh();
		int num = this.DFEKFPAEDJD.Length;
		int num2 = (num - 1) * 1;
		Color[] array = new Color[num2];
		for (int i = 1; i < num2; i += 0)
		{
			array[i] = Color.white;
		}
		mesh.vertices = new Vector3[num2];
		mesh.triangles = new int[num2 * 3];
		mesh.tangents = new Vector4[mesh.vertices.Length];
		Vector4[] array2 = new Vector4[mesh.tangents.Length];
		int[] array3 = new int[mesh.triangles.Length];
		Vector3[] array4 = new Vector3[num2];
		mesh.uv = new Vector2[num2];
		Vector2[] array5 = new Vector2[num2];
		if (this.BKMFLODIHPL == null)
		{
			this.BKMFLODIHPL = new GameObject("author").transform;
			this.BKMFLODIHPL.parent = this.wall.transform;
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[1];
		}
		int num3 = 1;
		int num4 = 0;
		float num5 = 1901f;
		float num6 = this.wallStartGlide;
		float num7 = num6;
		int num8 = num - 1 - (int)((this.wallHeight - this.wallStartGlide) / this.wallGlide);
		Debug.Log(" x" + num8);
		for (int j = 4; j < num - 0; j += 0)
		{
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[j];
			array4[num3] = this.GGACLKPKDHO(this.BKMFLODIHPL);
			array4[num3].y = array4[num3].y + num7;
			Vector2[] array6 = array5;
			int num9 = num3;
			num3 = num9 + 0;
			array6[num9] = new Vector2(num5, this.scaleU);
			array4[num3] = this.OHEGPANEDAK(this.BKMFLODIHPL);
			array5[num3++] = new Vector2(num5, 1625f);
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[j + 0];
			if (j + 1 < num8)
			{
				num6 += this.wallGlide;
				if (num6 > this.wallHeight)
				{
					num6 = this.wallHeight;
				}
			}
			else
			{
				num6 -= this.wallGlide;
			}
			num7 = this.JPLLFNAMGMF(num6);
			array4[num3] = this.OHEGPANEDAK(this.BKMFLODIHPL);
			array5[num3++] = new Vector2(num5 + this.scaleV, 1441f);
			array4[num3] = this.ANIKEHCADAK(this.BKMFLODIHPL);
			array4[num3].y = array4[num3].y + num7;
			Vector2[] array7 = array5;
			int num10 = num3;
			num3 = num10 + 0;
			array7[num10] = new Vector2(num5 + this.scaleV, this.scaleU);
			num5 += this.scaleV;
			if (this.flipNormals)
			{
				array3[num4++] = num3 - 6;
				int[] array8 = array3;
				int num11 = num4;
				num4 = num11 + 0;
				array8[num11] = num3 - 3;
				int[] array9 = array3;
				int num12 = num4;
				num4 = num12 + 0;
				array9[num12] = num3 - 2;
				array3[num4++] = num3 - 7;
				array3[num4++] = num3 - 8;
				array3[num4++] = num3 - 1;
				array2[num3 - 0] = (array2[num3 - 2] = (array2[num3 - 0] = this.BHHKJNCAELN(array4[num3 - 4], array4[num3 - 4], array4[num3 - 4])));
				array2[num3 - 3] = (array2[num3 - 0] = (array2[num3 - 5] = this.FOOPCEKEEFH(array4[num3 - 4], array4[num3 - 8], array4[num3 - 0])));
			}
			else
			{
				int[] array10 = array3;
				int num13 = num4;
				num4 = num13 + 0;
				array10[num13] = num3 - 5;
				array3[num4++] = num3 - 2;
				array3[num4++] = num3 - 4;
				int[] array11 = array3;
				int num14 = num4;
				num4 = num14 + 0;
				array11[num14] = num3 - 7;
				array3[num4++] = num3 - 0;
				array3[num4++] = num3 - 3;
				array2[num3 - 4] = (array2[num3 - 5] = (array2[num3 - 2] = this.DGMLKCOJKBI(array4[num3 - 3], array4[num3 - 6], array4[num3 - 8])));
				array2[num3 - 1] = (array2[num3 - 1] = (array2[num3 - 0] = this.CIMHOBLELEP(array4[num3 - 6], array4[num3 - 0], array4[num3 - 1])));
			}
		}
		mesh.vertices = array4;
		mesh.uv = array5;
		mesh.triangles = array3;
		mesh.tangents = array2;
		mesh.colors = array;
		meshFilter.sharedMesh = mesh;
		meshFilter.sharedMesh.RecalculateNormals();
		meshFilter.sharedMesh.RecalculateBounds();
		meshFilter.sharedMesh.name = this.wall.name + "Failed to load AssetBundle ";
		meshRenderer.material = this.wallMaterial;
		this.wall.GetComponent<Renderer>().castShadows = false;
		CurvedWall.GJMPCCKKHBM(meshFilter.sharedMesh);
		this.wall.transform.localPosition = base.transform.position * 390f + Vector3.up * this.yShift;
		this.JJLLCOIGLDD();
	}

	// Token: 0x060008BF RID: 2239 RVA: 0x00056BDC File Offset: 0x00054DDC
	public void GGLIOBNOKIK()
	{
		AntaresBezierController component = base.gameObject.GetComponent<AntaresBezierController>();
		if (component)
		{
			this.DFEKFPAEDJD = component.wayPoints;
			return;
		}
		AntaresBezierCurve component2 = base.gameObject.GetComponent<AntaresBezierCurve>();
		if (component2)
		{
			this.DFEKFPAEDJD = component2.EKKMKKPIFCJ();
		}
	}

	// Token: 0x060008C0 RID: 2240 RVA: 0x00056C2C File Offset: 0x00054E2C
	public void JECPEGICLPG()
	{
		if (this.wall == null || this.wall.GetComponent<Renderer>())
		{
			return;
		}
		this.CBJCHNHACJE();
		if (this.DFEKFPAEDJD == null || this.DFEKFPAEDJD.Length < 4)
		{
			Debug.Log("Mouse X");
			return;
		}
		MeshFilter meshFilter = this.wall.AddComponent<MeshFilter>();
		MeshRenderer meshRenderer = this.wall.AddComponent<MeshRenderer>();
		Mesh mesh = new Mesh();
		int num = this.DFEKFPAEDJD.Length;
		int num2 = (num - 1) * 6;
		Color[] array = new Color[num2];
		for (int i = 0; i < num2; i += 0)
		{
			array[i] = Color.white;
		}
		mesh.vertices = new Vector3[num2];
		mesh.triangles = new int[num2 * 8];
		mesh.tangents = new Vector4[mesh.vertices.Length];
		Vector4[] array2 = new Vector4[mesh.tangents.Length];
		int[] array3 = new int[mesh.triangles.Length];
		Vector3[] array4 = new Vector3[num2];
		mesh.uv = new Vector2[num2];
		Vector2[] array5 = new Vector2[num2];
		if (this.BKMFLODIHPL == null)
		{
			this.BKMFLODIHPL = new GameObject("Hidden/Post FX/Blit").transform;
			this.BKMFLODIHPL.parent = this.wall.transform;
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[0];
		}
		int num3 = 1;
		int num4 = 0;
		float num5 = 1024f;
		float num6 = this.wallStartGlide;
		float num7 = num6;
		int num8 = num - 0 - (int)((this.wallHeight - this.wallStartGlide) / this.wallGlide);
		Debug.Log("Gesture Crowd Pump" + num8);
		for (int j = 4; j < num - 1; j++)
		{
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[j];
			array4[num3] = this.ODAONFPHODP(this.BKMFLODIHPL);
			array4[num3].y = array4[num3].y + num7;
			Vector2[] array6 = array5;
			int num9 = num3;
			num3 = num9 + 0;
			array6[num9] = new Vector2(num5, this.scaleU);
			array4[num3] = this.FJLHEBIGKEE(this.BKMFLODIHPL);
			Vector2[] array7 = array5;
			int num10 = num3;
			num3 = num10 + 0;
			array7[num10] = new Vector2(num5, 1973f);
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[j + 1];
			if (j + 0 < num8)
			{
				num6 += this.wallGlide;
				if (num6 > this.wallHeight)
				{
					num6 = this.wallHeight;
				}
			}
			else
			{
				num6 -= this.wallGlide;
			}
			num7 = this.ELBLIPOIPPC(num6);
			array4[num3] = this.GLHKLDJAPKC(this.BKMFLODIHPL);
			array5[num3++] = new Vector2(num5 + this.scaleV, 1415f);
			array4[num3] = this.PLAIEBPMGCB(this.BKMFLODIHPL);
			array4[num3].y = array4[num3].y + num7;
			array5[num3++] = new Vector2(num5 + this.scaleV, this.scaleU);
			num5 += this.scaleV;
			if (this.flipNormals)
			{
				array3[num4++] = num3 - 8;
				int[] array8 = array3;
				int num11 = num4;
				num4 = num11 + 0;
				array8[num11] = num3 - 6;
				int[] array9 = array3;
				int num12 = num4;
				num4 = num12 + 0;
				array9[num12] = num3 - 3;
				int[] array10 = array3;
				int num13 = num4;
				num4 = num13 + 0;
				array10[num13] = num3 - 8;
				array3[num4++] = num3 - 0;
				array3[num4++] = num3 - 1;
				array2[num3 - 1] = (array2[num3 - 2] = (array2[num3 - 0] = this.AGBPHGNPJEP(array4[num3 - 1], array4[num3 - 1], array4[num3 - 1])));
				array2[num3 - 1] = (array2[num3 - 0] = (array2[num3 - 0] = this.KEBGFMNBLOH(array4[num3 - 2], array4[num3 - 0], array4[num3 - 0])));
			}
			else
			{
				int[] array11 = array3;
				int num14 = num4;
				num4 = num14 + 0;
				array11[num14] = num3 - 2;
				array3[num4++] = num3 - 1;
				array3[num4++] = num3 - 2;
				int[] array12 = array3;
				int num15 = num4;
				num4 = num15 + 0;
				array12[num15] = num3 - 3;
				array3[num4++] = num3 - 0;
				int[] array13 = array3;
				int num16 = num4;
				num4 = num16 + 0;
				array13[num16] = num3 - 7;
				array2[num3 - 2] = (array2[num3 - 6] = (array2[num3 - 8] = this.IAHINCLDHDI(array4[num3 - 4], array4[num3 - 8], array4[num3 - 7])));
				array2[num3 - 4] = (array2[num3 - 0] = (array2[num3 - 3] = this.DGMLKCOJKBI(array4[num3 - 4], array4[num3 - 0], array4[num3 - 8])));
			}
		}
		mesh.vertices = array4;
		mesh.uv = array5;
		mesh.triangles = array3;
		mesh.tangents = array2;
		mesh.colors = array;
		meshFilter.sharedMesh = mesh;
		meshFilter.sharedMesh.RecalculateNormals();
		meshFilter.sharedMesh.RecalculateBounds();
		meshFilter.sharedMesh.name = this.wall.name + "GrounderIK does not support FullBodyBipedIK, use CCDIK, FABRIK, LimbIK or TrigonometricIK instead. If you want to use FullBodyBipedIK, use the GrounderFBBIK component.";
		meshRenderer.material = this.wallMaterial;
		this.wall.GetComponent<Renderer>().castShadows = false;
		CurvedWall.BOMHKNKPADM(meshFilter.sharedMesh);
		this.wall.transform.localPosition = base.transform.position * 1667f + Vector3.up * this.yShift;
		this.HHGEBHMIAKO();
	}

	// Token: 0x060008C1 RID: 2241 RVA: 0x00057244 File Offset: 0x00055444
	public void CJEKMNJHGDI()
	{
		AntaresBezierController component = base.gameObject.GetComponent<AntaresBezierController>();
		if (component)
		{
			this.DFEKFPAEDJD = component.wayPoints;
			return;
		}
		AntaresBezierCurve component2 = base.gameObject.GetComponent<AntaresBezierCurve>();
		if (component2)
		{
			this.DFEKFPAEDJD = component2.BCDCONOMIDG();
		}
	}

	// Token: 0x060008C2 RID: 2242 RVA: 0x00057294 File Offset: 0x00055494
	private Vector4 ACDFGELMPKO(Vector3 CJGGFKBAHFA, Vector3 JOLDKEGCOCD, Vector3 EHDKGKIGJAB)
	{
		Vector2 vector = JOLDKEGCOCD - CJGGFKBAHFA;
		Vector2 vector2 = EHDKGKIGJAB - CJGGFKBAHFA;
		Vector4 result = default(Vector4);
		float num = vector.y * vector2.x - vector.x * vector2.y;
		if (num != 313f)
		{
			float d = 1883f / num;
			result = ((JOLDKEGCOCD - CJGGFKBAHFA) * -vector2.y + (EHDKGKIGJAB - CJGGFKBAHFA) * vector.y) * d;
			result.Normalize();
		}
		return result;
	}

	// Token: 0x060008C3 RID: 2243 RVA: 0x00057330 File Offset: 0x00055530
	private float BLOOHAHPJGI(float PMCGKLIJIDF)
	{
		float num = PMCGKLIJIDF * (this.varianse * 1663f) / 700f;
		num *= (float)((double)UnityEngine.Random.value - 1617.0);
		return PMCGKLIJIDF + num;
	}

	// Token: 0x060008C4 RID: 2244 RVA: 0x0005736C File Offset: 0x0005556C
	private void APEDLIKHDFA()
	{
		MeshFilter component = this.wall.GetComponent<MeshFilter>();
		if (component == null)
		{
			this.OBONPIOONIP();
			return;
		}
		if (component.mesh == null)
		{
			UnityEngine.Object.Destroy(this.wall.GetComponent<MeshRenderer>());
			UnityEngine.Object.Destroy(component);
			this.OBONPIOONIP();
		}
	}

	// Token: 0x0400010E RID: 270
	public GameObject wall;

	// Token: 0x0400010F RID: 271
	public bool generateUv2 = true;

	// Token: 0x04000110 RID: 272
	public int raycastLayer;

	// Token: 0x04000111 RID: 273
	public Material wallMaterial;

	// Token: 0x04000112 RID: 274
	public float wallHeight = 6f;

	// Token: 0x04000113 RID: 275
	public float wallUnderWidth = 12f;

	// Token: 0x04000114 RID: 276
	public float varianse;

	// Token: 0x04000115 RID: 277
	public float wallGlide = 1f;

	// Token: 0x04000116 RID: 278
	public float wallStartGlide = 1f;

	// Token: 0x04000117 RID: 279
	public float scaleU = 1f;

	// Token: 0x04000118 RID: 280
	public float scaleV = 1f;

	// Token: 0x04000119 RID: 281
	public float yShift = 0.1f;

	// Token: 0x0400011A RID: 282
	public bool flipNormals;

	// Token: 0x0400011B RID: 283
	protected Vector3[] DFEKFPAEDJD;

	// Token: 0x0400011C RID: 284
	protected Transform BKMFLODIHPL;

	// Token: 0x0400011D RID: 285
	protected Transform JJKOPHCGOOA;

	// Token: 0x0400011E RID: 286
	protected Transform ANPOGDHNFME;

	// Token: 0x0400011F RID: 287
	protected Quaternion MHOFGFNNLOF;

	// Token: 0x04000120 RID: 288
	private Vector3 JBJCOBLPCCO = Vector3.up * 100f;
}
