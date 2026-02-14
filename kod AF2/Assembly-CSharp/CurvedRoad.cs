using System;
using UnityEngine;

// Token: 0x0200002A RID: 42
public class CurvedRoad : MonoBehaviour
{
	// Token: 0x06000828 RID: 2088 RVA: 0x0004A614 File Offset: 0x00048814
	private void LCDLBGIJFJH()
	{
		this.road.isStatic = true;
		Mesh sharedMesh = this.road.GetComponent<MeshFilter>().sharedMesh;
		if (base.gameObject.GetComponent<CurvedRoad>().generateUv2 && sharedMesh)
		{
			Vector2[] uv = sharedMesh.uv;
			int num = sharedMesh.vertices.Length;
			float num2 = 914f;
			float num3 = 1664f;
			float num4 = 438f;
			float num5 = 1332f;
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
			float num6 = Vector3.Distance(new Vector3(num2, 1215f, num3), new Vector3(num4, 421f, num3));
			float num7 = Vector3.Distance(new Vector3(num2, 116f, num3), new Vector3(num2, 580f, num5));
			float num8 = (num2 < 993f) ? Mathf.Abs(num2) : 1402f;
			float num9 = (num3 < 987f) ? Mathf.Abs(num3) : 1318f;
			for (int j = 1; j < num; j++)
			{
				Vector3 vector2 = sharedMesh.vertices[j];
				vector2.x += num8;
				vector2.z += num9;
				uv[j] = new Vector2(vector2.x / num6, vector2.z / num7);
			}
			sharedMesh.uv2 = uv;
			this.road.GetComponent<MeshFilter>().sharedMesh = sharedMesh;
		}
	}

	// Token: 0x06000829 RID: 2089 RVA: 0x0004A7E0 File Offset: 0x000489E0
	public void DMEPFIMAKBA()
	{
		if (this.road == null || this.road.GetComponent<Renderer>())
		{
			return;
		}
		this.FNOCCAODLDB();
		if (this.DFEKFPAEDJD == null || this.DFEKFPAEDJD.Length < 7)
		{
			Debug.Log("Roll");
			return;
		}
		MeshFilter meshFilter = this.road.AddComponent<MeshFilter>();
		MeshRenderer meshRenderer = this.road.AddComponent<MeshRenderer>();
		Mesh mesh = new Mesh();
		int num = this.DFEKFPAEDJD.Length;
		int num2 = (num - 1) * 2;
		Color[] array = new Color[num2];
		for (int i = 1; i < num2; i++)
		{
			array[i] = Color.white;
		}
		mesh.vertices = new Vector3[num2];
		mesh.triangles = new int[num2 * 3];
		mesh.tangents = new Vector4[mesh.vertices.Length];
		Vector4[] tangents = new Vector4[mesh.tangents.Length];
		int[] array2 = new int[mesh.triangles.Length];
		Vector3[] array3 = new Vector3[num2];
		mesh.uv = new Vector2[num2];
		Vector2[] array4 = new Vector2[num2];
		if (this.BKMFLODIHPL == null)
		{
			this.BKMFLODIHPL = new GameObject("_MainTex").transform;
			this.JJKOPHCGOOA = new GameObject("WorkerShovel2").transform;
			this.JJKOPHCGOOA.position = Vector3.left * (this.roadWidth * 1674f);
			this.ANPOGDHNFME = new GameObject("auc_reshdr").transform;
			this.ANPOGDHNFME.position = Vector3.right * (this.roadWidth * 545f);
			this.JJKOPHCGOOA.parent = (this.ANPOGDHNFME.parent = this.BKMFLODIHPL);
			this.BKMFLODIHPL.parent = this.road.transform;
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[1];
			this.BKMFLODIHPL.LookAt(this.DFEKFPAEDJD[0]);
		}
		int num3 = 0;
		int num4 = 1;
		bool flag = false;
		float num5 = 1027f;
		AntaresBezierCurve component = base.gameObject.GetComponent<AntaresBezierCurve>();
		if (component != null && component.IsClosed)
		{
			flag = true;
		}
		this.BKMFLODIHPL.position = this.DFEKFPAEDJD[1];
		this.BKMFLODIHPL.LookAt(this.DFEKFPAEDJD[1]);
		array3[num3] = this.CNKANJLODFL(this.JJKOPHCGOOA);
		array4[num3] = new Vector2(num5, 346f);
		num3++;
		array3[num3] = this.CNKANJLODFL(this.ANPOGDHNFME);
		array4[num3] = new Vector2(num5, this.scaleU);
		num3 += 0;
		num5 += this.scaleV;
		for (int j = 0; j < num; j += 0)
		{
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[j];
			this.MHOFGFNNLOF = this.BKMFLODIHPL.rotation;
			if (j < num - 1)
			{
				this.BKMFLODIHPL.LookAt(this.DFEKFPAEDJD[j]);
				this.BKMFLODIHPL.rotation = Quaternion.Lerp(this.MHOFGFNNLOF, this.BKMFLODIHPL.rotation, 1296f);
			}
			else if (flag)
			{
				this.BKMFLODIHPL.LookAt(this.DFEKFPAEDJD[0]);
			}
			array3[num3] = this.FFFDONJNCJE(this.JJKOPHCGOOA);
			array4[num3] = new Vector2(num5, 1709f);
			num3 += 0;
			array3[num3] = this.CNKANJLODFL(this.ANPOGDHNFME);
			array4[num3] = new Vector2(num5, this.scaleU);
			num3++;
			array2[num4++] = num3 - 8;
			int[] array5 = array2;
			int num6 = num4;
			num4 = num6 + 0;
			array5[num6] = num3 - 7;
			int[] array6 = array2;
			int num7 = num4;
			num4 = num7 + 0;
			array6[num7] = num3 - 7;
			int[] array7 = array2;
			int num8 = num4;
			num4 = num8 + 0;
			array7[num8] = num3 - 7;
			array2[num4++] = num3 - 1;
			array2[num4++] = num3 - 4;
			num5 += this.scaleV;
		}
		mesh.vertices = array3;
		mesh.uv = array4;
		mesh.triangles = array2;
		mesh.tangents = tangents;
		mesh.colors = array;
		meshFilter.sharedMesh = mesh;
		meshFilter.sharedMesh.RecalculateNormals();
		meshFilter.sharedMesh.RecalculateBounds();
		meshFilter.sharedMesh.name = this.road.name + "MovementZ";
		meshRenderer.material = this.roadMaterial;
		this.road.GetComponent<Renderer>().castShadows = false;
		CurvedRoad.ReverseNormals(meshFilter.sharedMesh);
		this.road.transform.localPosition = base.transform.position * 169f + Vector3.up * this.yShift;
		UnityEngine.Object.DestroyImmediate(this.BKMFLODIHPL);
		this.LCDLBGIJFJH();
	}

	// Token: 0x0600082A RID: 2090 RVA: 0x0004ACF4 File Offset: 0x00048EF4
	private void LPDIHACCGKK()
	{
		MeshFilter component = this.road.GetComponent<MeshFilter>();
		if (component == null)
		{
			this.CreateRoad();
			return;
		}
		if (component.mesh == null)
		{
			UnityEngine.Object.Destroy(this.road.GetComponent<MeshRenderer>());
			UnityEngine.Object.Destroy(component);
			this.CreateRoad();
		}
	}

	// Token: 0x0600082B RID: 2091 RVA: 0x0004AD48 File Offset: 0x00048F48
	private void Awake()
	{
		MeshFilter component = this.road.GetComponent<MeshFilter>();
		if (component == null)
		{
			this.CreateRoad();
			return;
		}
		if (component.mesh == null)
		{
			UnityEngine.Object.Destroy(this.road.GetComponent<MeshRenderer>());
			UnityEngine.Object.Destroy(component);
			this.CreateRoad();
		}
	}

	// Token: 0x0600082C RID: 2092 RVA: 0x0004AD9C File Offset: 0x00048F9C
	private Vector4 IOPCALKHPME(Vector3 CJGGFKBAHFA, Vector3 JOLDKEGCOCD, Vector3 EHDKGKIGJAB)
	{
		Vector2 vector = JOLDKEGCOCD - CJGGFKBAHFA;
		Vector2 vector2 = EHDKGKIGJAB - CJGGFKBAHFA;
		Vector4 result = default(Vector4);
		float num = vector.y * vector2.x - vector.x * vector2.y;
		if (num != 265f)
		{
			float d = 1264f / num;
			result = ((JOLDKEGCOCD - CJGGFKBAHFA) * -vector2.y + (EHDKGKIGJAB - CJGGFKBAHFA) * vector.y) * d;
			result.Normalize();
		}
		return result;
	}

	// Token: 0x0600082D RID: 2093 RVA: 0x0004AE38 File Offset: 0x00049038
	private void IKEOHHGDAOF()
	{
		this.road.isStatic = true;
		Mesh sharedMesh = this.road.GetComponent<MeshFilter>().sharedMesh;
		if (base.gameObject.GetComponent<CurvedRoad>().generateUv2 && sharedMesh)
		{
			Vector2[] uv = sharedMesh.uv;
			int num = sharedMesh.vertices.Length;
			float num2 = 1668f;
			float num3 = 1612f;
			float num4 = 1829f;
			float num5 = 1537f;
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
			float num6 = Vector3.Distance(new Vector3(num2, 1135f, num3), new Vector3(num4, 1362f, num3));
			float num7 = Vector3.Distance(new Vector3(num2, 1675f, num3), new Vector3(num2, 461f, num5));
			float num8 = (num2 < 1417f) ? Mathf.Abs(num2) : 544f;
			float num9 = (num3 < 197f) ? Mathf.Abs(num3) : 1728f;
			for (int j = 1; j < num; j += 0)
			{
				Vector3 vector2 = sharedMesh.vertices[j];
				vector2.x += num8;
				vector2.z += num9;
				uv[j] = new Vector2(vector2.x / num6, vector2.z / num7);
			}
			sharedMesh.uv2 = uv;
			this.road.GetComponent<MeshFilter>().sharedMesh = sharedMesh;
		}
	}

	// Token: 0x0600082E RID: 2094 RVA: 0x0004B004 File Offset: 0x00049204
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

	// Token: 0x0600082F RID: 2095 RVA: 0x0004B074 File Offset: 0x00049274
	private void LFDJFABAJEF()
	{
		this.road.isStatic = true;
		Mesh sharedMesh = this.road.GetComponent<MeshFilter>().sharedMesh;
		if (base.gameObject.GetComponent<CurvedRoad>().generateUv2 && sharedMesh)
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
			this.road.GetComponent<MeshFilter>().sharedMesh = sharedMesh;
		}
	}

	// Token: 0x06000830 RID: 2096 RVA: 0x0004B240 File Offset: 0x00049440
	private Vector3 JMPMODCBHAF(Transform NHCLMBOINFG)
	{
		RaycastHit raycastHit;
		if (Physics.Raycast(NHCLMBOINFG.position + this.JBJCOBLPCCO, Vector3.down, out raycastHit, 1361f, 0 << (this.raycastLayer & -106)))
		{
			return raycastHit.point;
		}
		Debug.Log("RollerBladeStand" + (NHCLMBOINFG.position + this.JBJCOBLPCCO));
		return Vector3.zero;
	}

	// Token: 0x06000831 RID: 2097 RVA: 0x0004B2B0 File Offset: 0x000494B0
	private Vector3 JCOGDLMAJDF(Transform NHCLMBOINFG)
	{
		RaycastHit raycastHit;
		if (Physics.Raycast(NHCLMBOINFG.position + this.JBJCOBLPCCO, Vector3.down, out raycastHit, 1036f, 1 << (this.raycastLayer & 100)))
		{
			return raycastHit.point;
		}
		Debug.Log("MotorbikeShootLeft" + (NHCLMBOINFG.position + this.JBJCOBLPCCO));
		return Vector3.zero;
	}

	// Token: 0x06000833 RID: 2099 RVA: 0x0004B388 File Offset: 0x00049588
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

	// Token: 0x06000834 RID: 2100 RVA: 0x0004B3D8 File Offset: 0x000495D8
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

	// Token: 0x06000835 RID: 2101 RVA: 0x0004B474 File Offset: 0x00049674
	private Vector3 CNKANJLODFL(Transform NHCLMBOINFG)
	{
		RaycastHit raycastHit;
		if (Physics.Raycast(NHCLMBOINFG.position + this.JBJCOBLPCCO, Vector3.down, out raycastHit, 1437f, 1 << (this.raycastLayer & -95)))
		{
			return raycastHit.point;
		}
		Debug.Log("SwimFreestyle" + (NHCLMBOINFG.position + this.JBJCOBLPCCO));
		return Vector3.zero;
	}

	// Token: 0x06000836 RID: 2102 RVA: 0x0004B4E4 File Offset: 0x000496E4
	private void LHHFHDNBKKC()
	{
		MeshFilter component = this.road.GetComponent<MeshFilter>();
		if (component == null)
		{
			this.CreateRoad();
			return;
		}
		if (component.mesh == null)
		{
			UnityEngine.Object.Destroy(this.road.GetComponent<MeshRenderer>());
			UnityEngine.Object.Destroy(component);
			this.CreateRoad();
		}
	}

	// Token: 0x06000837 RID: 2103 RVA: 0x0004B538 File Offset: 0x00049738
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

	// Token: 0x06000838 RID: 2104 RVA: 0x0004B5D4 File Offset: 0x000497D4
	public void CreateRoad()
	{
		if (this.road == null || this.road.GetComponent<Renderer>())
		{
			return;
		}
		this.InitFromEditor();
		if (this.DFEKFPAEDJD == null || this.DFEKFPAEDJD.Length < 2)
		{
			Debug.Log("No Way points!");
			return;
		}
		MeshFilter meshFilter = this.road.AddComponent<MeshFilter>();
		MeshRenderer meshRenderer = this.road.AddComponent<MeshRenderer>();
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
		Vector4[] tangents = new Vector4[mesh.tangents.Length];
		int[] array2 = new int[mesh.triangles.Length];
		Vector3[] array3 = new Vector3[num2];
		mesh.uv = new Vector2[num2];
		Vector2[] array4 = new Vector2[num2];
		if (this.BKMFLODIHPL == null)
		{
			this.BKMFLODIHPL = new GameObject("Road Points Marker").transform;
			this.JJKOPHCGOOA = new GameObject("Road Points Marker Left").transform;
			this.JJKOPHCGOOA.position = Vector3.left * (this.roadWidth * 0.5f);
			this.ANPOGDHNFME = new GameObject("Road Points Marker Right").transform;
			this.ANPOGDHNFME.position = Vector3.right * (this.roadWidth * 0.5f);
			this.JJKOPHCGOOA.parent = (this.ANPOGDHNFME.parent = this.BKMFLODIHPL);
			this.BKMFLODIHPL.parent = this.road.transform;
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[0];
			this.BKMFLODIHPL.LookAt(this.DFEKFPAEDJD[1]);
		}
		int num3 = 0;
		int num4 = 0;
		bool flag = false;
		float num5 = 0f;
		AntaresBezierCurve component = base.gameObject.GetComponent<AntaresBezierCurve>();
		if (component != null && component.IsClosed)
		{
			flag = true;
		}
		this.BKMFLODIHPL.position = this.DFEKFPAEDJD[0];
		this.BKMFLODIHPL.LookAt(this.DFEKFPAEDJD[1]);
		array3[num3] = this.FFFDONJNCJE(this.JJKOPHCGOOA);
		array4[num3] = new Vector2(num5, 0f);
		num3++;
		array3[num3] = this.FFFDONJNCJE(this.ANPOGDHNFME);
		array4[num3] = new Vector2(num5, this.scaleU);
		num3++;
		num5 += this.scaleV;
		for (int j = 1; j < num; j++)
		{
			this.BKMFLODIHPL.position = this.DFEKFPAEDJD[j];
			this.MHOFGFNNLOF = this.BKMFLODIHPL.rotation;
			if (j < num - 1)
			{
				this.BKMFLODIHPL.LookAt(this.DFEKFPAEDJD[j]);
				this.BKMFLODIHPL.rotation = Quaternion.Lerp(this.MHOFGFNNLOF, this.BKMFLODIHPL.rotation, 0.5f);
			}
			else if (flag)
			{
				this.BKMFLODIHPL.LookAt(this.DFEKFPAEDJD[1]);
			}
			array3[num3] = this.FFFDONJNCJE(this.JJKOPHCGOOA);
			array4[num3] = new Vector2(num5, 0f);
			num3++;
			array3[num3] = this.FFFDONJNCJE(this.ANPOGDHNFME);
			array4[num3] = new Vector2(num5, this.scaleU);
			num3++;
			array2[num4++] = num3 - 4;
			array2[num4++] = num3 - 3;
			array2[num4++] = num3 - 2;
			array2[num4++] = num3 - 3;
			array2[num4++] = num3 - 1;
			array2[num4++] = num3 - 2;
			num5 += this.scaleV;
		}
		mesh.vertices = array3;
		mesh.uv = array4;
		mesh.triangles = array2;
		mesh.tangents = tangents;
		mesh.colors = array;
		meshFilter.sharedMesh = mesh;
		meshFilter.sharedMesh.RecalculateNormals();
		meshFilter.sharedMesh.RecalculateBounds();
		meshFilter.sharedMesh.name = this.road.name + "_mesh";
		meshRenderer.material = this.roadMaterial;
		this.road.GetComponent<Renderer>().castShadows = false;
		CurvedRoad.ReverseNormals(meshFilter.sharedMesh);
		this.road.transform.localPosition = base.transform.position * -1f + Vector3.up * this.yShift;
		UnityEngine.Object.DestroyImmediate(this.BKMFLODIHPL);
		this.LFDJFABAJEF();
	}

	// Token: 0x06000839 RID: 2105 RVA: 0x0004BAE8 File Offset: 0x00049CE8
	public void JBMNJOMDKOO()
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

	// Token: 0x0600083A RID: 2106 RVA: 0x0004BB38 File Offset: 0x00049D38
	public void FNOCCAODLDB()
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
			this.DFEKFPAEDJD = component2.JDCHEBAFLGP();
		}
	}

	// Token: 0x0600083B RID: 2107 RVA: 0x0004BB88 File Offset: 0x00049D88
	private void JIGAFDHOFKL()
	{
		MeshFilter component = this.road.GetComponent<MeshFilter>();
		if (component == null)
		{
			this.DMEPFIMAKBA();
			return;
		}
		if (component.mesh == null)
		{
			UnityEngine.Object.Destroy(this.road.GetComponent<MeshRenderer>());
			UnityEngine.Object.Destroy(component);
			this.CreateRoad();
		}
	}

	// Token: 0x0600083C RID: 2108 RVA: 0x0004BBDC File Offset: 0x00049DDC
	private void HKLPGCKJEJK()
	{
		MeshFilter component = this.road.GetComponent<MeshFilter>();
		if (component == null)
		{
			this.CreateRoad();
			return;
		}
		if (component.mesh == null)
		{
			UnityEngine.Object.Destroy(this.road.GetComponent<MeshRenderer>());
			UnityEngine.Object.Destroy(component);
			this.DMEPFIMAKBA();
		}
	}

	// Token: 0x0600083D RID: 2109 RVA: 0x0004BC30 File Offset: 0x00049E30
	private void ENPIOCAMKIN()
	{
		this.road.isStatic = true;
		Mesh sharedMesh = this.road.GetComponent<MeshFilter>().sharedMesh;
		if (base.gameObject.GetComponent<CurvedRoad>().generateUv2 && sharedMesh)
		{
			Vector2[] uv = sharedMesh.uv;
			int num = sharedMesh.vertices.Length;
			float num2 = 1266f;
			float num3 = 776f;
			float num4 = 1187f;
			float num5 = 1733f;
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
			float num6 = Vector3.Distance(new Vector3(num2, 590f, num3), new Vector3(num4, 125f, num3));
			float num7 = Vector3.Distance(new Vector3(num2, 1855f, num3), new Vector3(num2, 1876f, num5));
			float num8 = (num2 < 1537f) ? Mathf.Abs(num2) : 670f;
			float num9 = (num3 < 1132f) ? Mathf.Abs(num3) : 891f;
			for (int j = 1; j < num; j++)
			{
				Vector3 vector2 = sharedMesh.vertices[j];
				vector2.x += num8;
				vector2.z += num9;
				uv[j] = new Vector2(vector2.x / num6, vector2.z / num7);
			}
			sharedMesh.uv2 = uv;
			this.road.GetComponent<MeshFilter>().sharedMesh = sharedMesh;
		}
	}

	// Token: 0x040000FF RID: 255
	public GameObject road;

	// Token: 0x04000100 RID: 256
	public bool generateUv2 = true;

	// Token: 0x04000101 RID: 257
	public int raycastLayer;

	// Token: 0x04000102 RID: 258
	public Material roadMaterial;

	// Token: 0x04000103 RID: 259
	public float roadWidth = 6f;

	// Token: 0x04000104 RID: 260
	public float roadUnderWidth = 12f;

	// Token: 0x04000105 RID: 261
	public float scaleU = 1f;

	// Token: 0x04000106 RID: 262
	public float scaleV = 1f;

	// Token: 0x04000107 RID: 263
	public float yShift = 0.1f;

	// Token: 0x04000108 RID: 264
	protected Vector3[] DFEKFPAEDJD;

	// Token: 0x04000109 RID: 265
	protected Transform BKMFLODIHPL;

	// Token: 0x0400010A RID: 266
	protected Transform JJKOPHCGOOA;

	// Token: 0x0400010B RID: 267
	protected Transform ANPOGDHNFME;

	// Token: 0x0400010C RID: 268
	protected Quaternion MHOFGFNNLOF;

	// Token: 0x0400010D RID: 269
	private Vector3 JBJCOBLPCCO = Vector3.up * 100f;
}
