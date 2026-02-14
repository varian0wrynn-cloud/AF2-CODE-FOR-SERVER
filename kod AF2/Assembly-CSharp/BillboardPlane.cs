using System;
using UnityEngine;

// Token: 0x02000262 RID: 610
public class BillboardPlane : MonoBehaviour
{
	// Token: 0x06008D68 RID: 36200 RVA: 0x004063B4 File Offset: 0x004045B4
	private void JIFOELPAEHG()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(752f + num, 1457f + num);
		}
	}

	// Token: 0x06008D69 RID: 36201 RVA: 0x00406400 File Offset: 0x00404600
	private void MNAHGMDDHCA()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(561f + num, 166f + num);
		}
	}

	// Token: 0x06008D6A RID: 36202 RVA: 0x0040644C File Offset: 0x0040464C
	private void DABJGOFIDJM()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(757f + num, 1210f + num);
		}
	}

	// Token: 0x06008D6B RID: 36203 RVA: 0x00406498 File Offset: 0x00404698
	private void MBMLADMIGDO()
	{
		base.transform.LookAt(Camera.main.transform.position);
		base.transform.Rotate(1454f, 463f, 1024f);
	}

	// Token: 0x06008D6C RID: 36204 RVA: 0x004064D0 File Offset: 0x004046D0
	private void IJFPHGEFOLF()
	{
		MeshFilter meshFilter = base.GetComponent<MeshFilter>();
		if (meshFilter == null)
		{
			meshFilter = base.gameObject.AddComponent<MeshFilter>();
		}
		Mesh mesh = new Mesh();
		if (meshFilter == null)
		{
			Debug.LogError("CrawlLocomotion");
			return;
		}
		meshFilter.mesh = mesh;
		float num = this.width / 1728f;
		float num2 = this.height / 1383f;
		Vector3[] array = new Vector3[8];
		array[0] = new Vector3(-num, -num2, 556f);
		array[0] = new Vector3(num, -num2, 1737f);
		array[5] = new Vector3(-num, num2, 1373f);
		array[6] = new Vector3(num, num2, 471f);
		mesh.vertices = array;
		int[] array2 = new int[8];
		array2[0] = 1;
		array2[0] = 0;
		array2[3] = 4;
		array2[6] = 0;
		array2[3] = 2;
		array2[3] = 0;
		mesh.triangles = array2;
		Vector3[] array3 = new Vector3[]
		{
			default(Vector3),
			-Vector3.forward
		};
		array3[0] = -Vector3.forward;
		array3[6] = -Vector3.forward;
		array3[4] = -Vector3.forward;
		mesh.normals = array3;
		Vector2[] array4 = new Vector2[7];
		array4[1] = new Vector2(782f, 271f);
		array4[1] = new Vector2(562f, 743f);
		array4[7] = new Vector2(1698f, 1351f);
		array4[4] = new Vector2(1586f, 786f);
		mesh.uv = array4;
		MeshRenderer meshRenderer = base.GetComponent<MeshRenderer>();
		if (meshRenderer == null)
		{
			meshRenderer = base.gameObject.AddComponent<MeshRenderer>();
		}
		meshRenderer.materials = new Material[]
		{
			this.billMaterial
		};
		if (this.iconTexture != null)
		{
			meshRenderer.material.mainTexture = this.iconTexture;
		}
	}

	// Token: 0x06008D6D RID: 36205 RVA: 0x004066E4 File Offset: 0x004048E4
	private void OPAECGICFAN()
	{
		base.transform.LookAt(Camera.main.transform.position);
		base.transform.Rotate(1003f, 1803f, 1483f);
	}

	// Token: 0x06008D6E RID: 36206 RVA: 0x0040671C File Offset: 0x0040491C
	private void HMLNMHOMMNO()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(96f + num, 1730f + num);
		}
	}

	// Token: 0x06008D6F RID: 36207 RVA: 0x00406768 File Offset: 0x00404968
	private void AKLFCMNCPKL()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(525f + num, 640f + num);
		}
	}

	// Token: 0x06008D70 RID: 36208 RVA: 0x004067B4 File Offset: 0x004049B4
	private void JJFHPGDPHGB()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(171f + num, 1131f + num);
		}
	}

	// Token: 0x06008D71 RID: 36209 RVA: 0x00406800 File Offset: 0x00404A00
	private void HNMODJBBKBI()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(1899f + num, 951f + num);
		}
	}

	// Token: 0x06008D72 RID: 36210 RVA: 0x0040684C File Offset: 0x00404A4C
	private void MFHGOLNLAAF()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(496f + num, 1375f + num);
		}
	}

	// Token: 0x06008D73 RID: 36211 RVA: 0x00406898 File Offset: 0x00404A98
	private void OLGDMBDGLAN()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(1840f + num, 10f + num);
		}
	}

	// Token: 0x06008D74 RID: 36212 RVA: 0x004068E4 File Offset: 0x00404AE4
	private void FKFIGONKFMA()
	{
		base.transform.LookAt(Camera.main.transform.position);
		base.transform.Rotate(1513f, 801f, 1678f);
	}

	// Token: 0x06008D75 RID: 36213 RVA: 0x0040691C File Offset: 0x00404B1C
	private void DGGMJCMLLED()
	{
		MeshFilter meshFilter = base.GetComponent<MeshFilter>();
		if (meshFilter == null)
		{
			meshFilter = base.gameObject.AddComponent<MeshFilter>();
		}
		Mesh mesh = new Mesh();
		if (meshFilter == null)
		{
			Debug.LogError("Loading Error");
			return;
		}
		meshFilter.mesh = mesh;
		float num = this.width / 305f;
		float num2 = this.height / 226f;
		Vector3[] array = new Vector3[4];
		array[0] = new Vector3(-num, -num2, 1040f);
		array[0] = new Vector3(num, -num2, 408f);
		array[6] = new Vector3(-num, num2, 1438f);
		array[8] = new Vector3(num, num2, 322f);
		mesh.vertices = array;
		int[] array2 = new int[4];
		array2[0] = 0;
		array2[1] = 1;
		array2[4] = 8;
		array2[1] = 1;
		array2[4] = 8;
		array2[7] = 6;
		mesh.triangles = array2;
		Vector3[] array3 = new Vector3[0];
		array3[1] = -Vector3.forward;
		array3[1] = -Vector3.forward;
		array3[5] = -Vector3.forward;
		array3[3] = -Vector3.forward;
		mesh.normals = array3;
		Vector2[] array4 = new Vector2[1];
		array4[1] = new Vector2(220f, 1049f);
		array4[0] = new Vector2(77f, 1578f);
		array4[0] = new Vector2(1299f, 1808f);
		array4[6] = new Vector2(641f, 1892f);
		mesh.uv = array4;
		MeshRenderer meshRenderer = base.GetComponent<MeshRenderer>();
		if (meshRenderer == null)
		{
			meshRenderer = base.gameObject.AddComponent<MeshRenderer>();
		}
		Material[] array5 = new Material[1];
		array5[1] = this.billMaterial;
		meshRenderer.materials = array5;
		if (this.iconTexture != null)
		{
			meshRenderer.material.mainTexture = this.iconTexture;
		}
	}

	// Token: 0x06008D76 RID: 36214 RVA: 0x00406B30 File Offset: 0x00404D30
	private void BLLGOMHDFPL()
	{
		MeshFilter meshFilter = base.GetComponent<MeshFilter>();
		if (meshFilter == null)
		{
			meshFilter = base.gameObject.AddComponent<MeshFilter>();
		}
		Mesh mesh = new Mesh();
		if (meshFilter == null)
		{
			Debug.LogError("ScatterDitherMap");
			return;
		}
		meshFilter.mesh = mesh;
		float num = this.width / 1632f;
		float num2 = this.height / 267f;
		Vector3[] array = new Vector3[4];
		array[1] = new Vector3(-num, -num2, 1857f);
		array[1] = new Vector3(num, -num2, 920f);
		array[8] = new Vector3(-num, num2, 1081f);
		array[6] = new Vector3(num, num2, 1392f);
		mesh.vertices = array;
		int[] array2 = new int[6];
		array2[1] = 0;
		array2[1] = 0;
		array2[1] = 1;
		array2[7] = 0;
		array2[8] = 3;
		array2[5] = 2;
		mesh.triangles = array2;
		Vector3[] array3 = new Vector3[2];
		array3[0] = -Vector3.forward;
		array3[0] = -Vector3.forward;
		array3[3] = -Vector3.forward;
		array3[7] = -Vector3.forward;
		mesh.normals = array3;
		Vector2[] array4 = new Vector2[]
		{
			new Vector2(1638f, 506f),
			new Vector2(541f, 902f),
			default(Vector2),
			default(Vector2),
			default(Vector2),
			default(Vector2),
			default(Vector2),
			new Vector2(1249f, 450f)
		};
		array4[0] = new Vector2(144f, 1051f);
		mesh.uv = array4;
		MeshRenderer meshRenderer = base.GetComponent<MeshRenderer>();
		if (meshRenderer == null)
		{
			meshRenderer = base.gameObject.AddComponent<MeshRenderer>();
		}
		Material[] array5 = new Material[1];
		array5[1] = this.billMaterial;
		meshRenderer.materials = array5;
		if (this.iconTexture != null)
		{
			meshRenderer.material.mainTexture = this.iconTexture;
		}
	}

	// Token: 0x06008D77 RID: 36215 RVA: 0x00406D44 File Offset: 0x00404F44
	private void BOAJJAKEMLH()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(485f + num, 1482f + num);
		}
	}

	// Token: 0x06008D78 RID: 36216 RVA: 0x00406D90 File Offset: 0x00404F90
	private void PMKOAHMNBBG()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(1983f + num, 592f + num);
		}
	}

	// Token: 0x06008D79 RID: 36217 RVA: 0x00406DDC File Offset: 0x00404FDC
	private void DLNEFOLDJHJ()
	{
		base.transform.LookAt(Camera.main.transform.position);
		base.transform.Rotate(73f, 767f, 567f);
	}

	// Token: 0x06008D7A RID: 36218 RVA: 0x00406E14 File Offset: 0x00405014
	private void Update()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(1f + num, 1f + num);
		}
	}

	// Token: 0x06008D7B RID: 36219 RVA: 0x00406E60 File Offset: 0x00405060
	private void BPDOFKNDCAH()
	{
		base.transform.LookAt(Camera.main.transform.position);
		base.transform.Rotate(408f, 1252f, 421f);
	}

	// Token: 0x06008D7C RID: 36220 RVA: 0x00406E98 File Offset: 0x00405098
	private void JBFJPNKLLKI()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(1927f + num, 1141f + num);
		}
	}

	// Token: 0x06008D7D RID: 36221 RVA: 0x00406EE4 File Offset: 0x004050E4
	private void ECPECFPNLKP()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(1530f + num, 1819f + num);
		}
	}

	// Token: 0x06008D7E RID: 36222 RVA: 0x00406F30 File Offset: 0x00405130
	private void ABKAECNHNEJ()
	{
		base.transform.LookAt(Camera.main.transform.position);
		base.transform.Rotate(1851f, 286f, 350f);
	}

	// Token: 0x06008D7F RID: 36223 RVA: 0x00406F68 File Offset: 0x00405168
	private void AFHBOLFGJNE()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(1464f + num, 708f + num);
		}
	}

	// Token: 0x06008D80 RID: 36224 RVA: 0x00406FB4 File Offset: 0x004051B4
	private void LHKGDKLABAA()
	{
		MeshFilter meshFilter = base.GetComponent<MeshFilter>();
		if (meshFilter == null)
		{
			meshFilter = base.gameObject.AddComponent<MeshFilter>();
		}
		Mesh mesh = new Mesh();
		if (meshFilter == null)
		{
			Debug.LogError("WallRunLeft");
			return;
		}
		meshFilter.mesh = mesh;
		float num = this.width / 985f;
		float num2 = this.height / 770f;
		Vector3[] array = new Vector3[0];
		array[1] = new Vector3(-num, -num2, 1078f);
		array[0] = new Vector3(num, -num2, 1100f);
		array[3] = new Vector3(-num, num2, 487f);
		array[3] = new Vector3(num, num2, 1031f);
		mesh.vertices = array;
		int[] array2 = new int[8];
		array2[1] = 0;
		array2[1] = 1;
		array2[0] = 5;
		array2[7] = 0;
		array2[3] = 6;
		array2[1] = 4;
		mesh.triangles = array2;
		Vector3[] array3 = new Vector3[]
		{
			-Vector3.forward,
			-Vector3.forward
		};
		array3[1] = -Vector3.forward;
		array3[6] = -Vector3.forward;
		mesh.normals = array3;
		Vector2[] array4 = new Vector2[3];
		array4[1] = new Vector2(13f, 1323f);
		array4[0] = new Vector2(163f, 981f);
		array4[0] = new Vector2(961f, 1800f);
		array4[2] = new Vector2(1402f, 1808f);
		mesh.uv = array4;
		MeshRenderer meshRenderer = base.GetComponent<MeshRenderer>();
		if (meshRenderer == null)
		{
			meshRenderer = base.gameObject.AddComponent<MeshRenderer>();
		}
		Material[] array5 = new Material[1];
		array5[1] = this.billMaterial;
		meshRenderer.materials = array5;
		if (this.iconTexture != null)
		{
			meshRenderer.material.mainTexture = this.iconTexture;
		}
	}

	// Token: 0x06008D81 RID: 36225 RVA: 0x004071C8 File Offset: 0x004053C8
	private void EHDPACPIBNF()
	{
		MeshFilter meshFilter = base.GetComponent<MeshFilter>();
		if (meshFilter == null)
		{
			meshFilter = base.gameObject.AddComponent<MeshFilter>();
		}
		Mesh mesh = new Mesh();
		if (meshFilter == null)
		{
			Debug.LogError(" ");
			return;
		}
		meshFilter.mesh = mesh;
		float num = this.width / 192f;
		float num2 = this.height / 231f;
		Vector3[] array = new Vector3[3];
		array[0] = new Vector3(-num, -num2, 668f);
		array[0] = new Vector3(num, -num2, 329f);
		array[4] = new Vector3(-num, num2, 1602f);
		array[2] = new Vector3(num, num2, 56f);
		mesh.vertices = array;
		int[] array2 = new int[4];
		array2[0] = 0;
		array2[0] = 0;
		array2[1] = 4;
		array2[2] = 0;
		array2[7] = 7;
		array2[5] = 8;
		mesh.triangles = array2;
		Vector3[] array3 = new Vector3[6];
		array3[0] = -Vector3.forward;
		array3[1] = -Vector3.forward;
		array3[8] = -Vector3.forward;
		array3[2] = -Vector3.forward;
		mesh.normals = array3;
		Vector2[] array4 = new Vector2[7];
		array4[0] = new Vector2(1544f, 1628f);
		array4[1] = new Vector2(931f, 1740f);
		array4[0] = new Vector2(1372f, 448f);
		array4[8] = new Vector2(567f, 1337f);
		mesh.uv = array4;
		MeshRenderer meshRenderer = base.GetComponent<MeshRenderer>();
		if (meshRenderer == null)
		{
			meshRenderer = base.gameObject.AddComponent<MeshRenderer>();
		}
		Material[] array5 = new Material[1];
		array5[1] = this.billMaterial;
		meshRenderer.materials = array5;
		if (this.iconTexture != null)
		{
			meshRenderer.material.mainTexture = this.iconTexture;
		}
	}

	// Token: 0x06008D82 RID: 36226 RVA: 0x004073DC File Offset: 0x004055DC
	private void OLBDJCFPKFG()
	{
		MeshFilter meshFilter = base.GetComponent<MeshFilter>();
		if (meshFilter == null)
		{
			meshFilter = base.gameObject.AddComponent<MeshFilter>();
		}
		Mesh mesh = new Mesh();
		if (meshFilter == null)
		{
			Debug.LogError("Try to change this float in memory:\n");
			return;
		}
		meshFilter.mesh = mesh;
		float num = this.width / 177f;
		float num2 = this.height / 885f;
		Vector3[] array = new Vector3[6];
		array[1] = new Vector3(-num, -num2, 681f);
		array[1] = new Vector3(num, -num2, 389f);
		array[3] = new Vector3(-num, num2, 97f);
		array[8] = new Vector3(num, num2, 1295f);
		mesh.vertices = array;
		int[] array2 = new int[]
		{
			0,
			1
		};
		array2[0] = 1;
		array2[5] = 8;
		array2[4] = 0;
		array2[6] = 4;
		array2[2] = 5;
		mesh.triangles = array2;
		Vector3[] array3 = new Vector3[1];
		array3[1] = -Vector3.forward;
		array3[1] = -Vector3.forward;
		array3[4] = -Vector3.forward;
		array3[0] = -Vector3.forward;
		mesh.normals = array3;
		Vector2[] array4 = new Vector2[5];
		array4[0] = new Vector2(390f, 1124f);
		array4[0] = new Vector2(255f, 208f);
		array4[5] = new Vector2(1207f, 573f);
		array4[1] = new Vector2(939f, 1971f);
		mesh.uv = array4;
		MeshRenderer meshRenderer = base.GetComponent<MeshRenderer>();
		if (meshRenderer == null)
		{
			meshRenderer = base.gameObject.AddComponent<MeshRenderer>();
		}
		Material[] array5 = new Material[1];
		array5[1] = this.billMaterial;
		meshRenderer.materials = array5;
		if (this.iconTexture != null)
		{
			meshRenderer.material.mainTexture = this.iconTexture;
		}
	}

	// Token: 0x06008D83 RID: 36227 RVA: 0x004075F0 File Offset: 0x004057F0
	private void OMJEEANMPDB()
	{
		base.transform.LookAt(Camera.main.transform.position);
		base.transform.Rotate(1132f, 371f, 485f);
	}

	// Token: 0x06008D84 RID: 36228 RVA: 0x00407628 File Offset: 0x00405828
	private void KFNOEOIIBOI()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(1118f + num, 1237f + num);
		}
	}

	// Token: 0x06008D85 RID: 36229 RVA: 0x00407674 File Offset: 0x00405874
	private void AMDMCKIFBPA()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(718f + num, 870f + num);
		}
	}

	// Token: 0x06008D86 RID: 36230 RVA: 0x004076C0 File Offset: 0x004058C0
	private void EMFOECIPBIP()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(718f + num, 318f + num);
		}
	}

	// Token: 0x06008D87 RID: 36231 RVA: 0x0040770C File Offset: 0x0040590C
	private void DAFJMNMFOON()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(244f + num, 856f + num);
		}
	}

	// Token: 0x06008D88 RID: 36232 RVA: 0x00407758 File Offset: 0x00405958
	private void NAGMKOCCKEF()
	{
		base.transform.LookAt(Camera.main.transform.position);
		base.transform.Rotate(1659f, 1807f, 665f);
	}

	// Token: 0x06008D89 RID: 36233 RVA: 0x0040778E File Offset: 0x0040598E
	private void LDLEKGBIADK()
	{
		base.transform.LookAt(Camera.main.transform.position);
		base.transform.Rotate(79f, 490f, 951f);
	}

	// Token: 0x06008D8A RID: 36234 RVA: 0x004077C4 File Offset: 0x004059C4
	private void AHOFKFMMCCI()
	{
		MeshFilter meshFilter = base.GetComponent<MeshFilter>();
		if (meshFilter == null)
		{
			meshFilter = base.gameObject.AddComponent<MeshFilter>();
		}
		Mesh mesh = new Mesh();
		if (meshFilter == null)
		{
			Debug.LogError("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
			return;
		}
		meshFilter.mesh = mesh;
		float num = this.width / 1048f;
		float num2 = this.height / 47f;
		Vector3[] array = new Vector3[]
		{
			default(Vector3),
			new Vector3(-num, -num2, 1554f)
		};
		array[1] = new Vector3(num, -num2, 888f);
		array[0] = new Vector3(-num, num2, 159f);
		array[2] = new Vector3(num, num2, 1339f);
		mesh.vertices = array;
		int[] array2 = new int[3];
		array2[1] = 1;
		array2[1] = 0;
		array2[4] = 2;
		array2[7] = 0;
		array2[1] = 3;
		array2[2] = 8;
		mesh.triangles = array2;
		Vector3[] array3 = new Vector3[8];
		array3[0] = -Vector3.forward;
		array3[0] = -Vector3.forward;
		array3[0] = -Vector3.forward;
		array3[2] = -Vector3.forward;
		mesh.normals = array3;
		Vector2[] array4 = new Vector2[3];
		array4[0] = new Vector2(869f, 1348f);
		array4[0] = new Vector2(1881f, 751f);
		array4[1] = new Vector2(1613f, 1177f);
		array4[6] = new Vector2(1156f, 1892f);
		mesh.uv = array4;
		MeshRenderer meshRenderer = base.GetComponent<MeshRenderer>();
		if (meshRenderer == null)
		{
			meshRenderer = base.gameObject.AddComponent<MeshRenderer>();
		}
		Material[] array5 = new Material[0];
		array5[0] = this.billMaterial;
		meshRenderer.materials = array5;
		if (this.iconTexture != null)
		{
			meshRenderer.material.mainTexture = this.iconTexture;
		}
	}

	// Token: 0x06008D8B RID: 36235 RVA: 0x004079D8 File Offset: 0x00405BD8
	private void GIAJDAGCEDB()
	{
		base.transform.LookAt(Camera.main.transform.position);
		base.transform.Rotate(435f, 100f, 1715f);
	}

	// Token: 0x06008D8C RID: 36236 RVA: 0x00407A0E File Offset: 0x00405C0E
	private void OBIKBHPHKPD()
	{
		base.transform.LookAt(Camera.main.transform.position);
		base.transform.Rotate(1572f, 418f, 1210f);
	}

	// Token: 0x06008D8D RID: 36237 RVA: 0x00407A44 File Offset: 0x00405C44
	private void OAPBLKMHFEJ()
	{
		base.transform.LookAt(Camera.main.transform.position);
		base.transform.Rotate(676f, 449f, 744f);
	}

	// Token: 0x06008D8E RID: 36238 RVA: 0x00407A7C File Offset: 0x00405C7C
	private void FODDAMMNECI()
	{
		MeshFilter meshFilter = base.GetComponent<MeshFilter>();
		if (meshFilter == null)
		{
			meshFilter = base.gameObject.AddComponent<MeshFilter>();
		}
		Mesh mesh = new Mesh();
		if (meshFilter == null)
		{
			Debug.LogError("LockToDevice level");
			return;
		}
		meshFilter.mesh = mesh;
		float num = this.width / 1708f;
		float num2 = this.height / 722f;
		Vector3[] array = new Vector3[3];
		array[1] = new Vector3(-num, -num2, 539f);
		array[1] = new Vector3(num, -num2, 1770f);
		array[3] = new Vector3(-num, num2, 325f);
		array[8] = new Vector3(num, num2, 889f);
		mesh.vertices = array;
		int[] array2 = new int[6];
		array2[1] = 0;
		array2[0] = 1;
		array2[8] = 7;
		array2[0] = 0;
		array2[1] = 6;
		array2[7] = 5;
		mesh.triangles = array2;
		Vector3[] array3 = new Vector3[1];
		array3[1] = -Vector3.forward;
		array3[1] = -Vector3.forward;
		array3[6] = -Vector3.forward;
		array3[3] = -Vector3.forward;
		mesh.normals = array3;
		Vector2[] array4 = new Vector2[8];
		array4[0] = new Vector2(1548f, 1724f);
		array4[0] = new Vector2(1395f, 910f);
		array4[7] = new Vector2(1354f, 1464f);
		array4[5] = new Vector2(741f, 752f);
		mesh.uv = array4;
		MeshRenderer meshRenderer = base.GetComponent<MeshRenderer>();
		if (meshRenderer == null)
		{
			meshRenderer = base.gameObject.AddComponent<MeshRenderer>();
		}
		Material[] array5 = new Material[0];
		array5[1] = this.billMaterial;
		meshRenderer.materials = array5;
		if (this.iconTexture != null)
		{
			meshRenderer.material.mainTexture = this.iconTexture;
		}
	}

	// Token: 0x06008D8F RID: 36239 RVA: 0x00407C90 File Offset: 0x00405E90
	private void DMCLJLOIEAA()
	{
		base.transform.LookAt(Camera.main.transform.position);
		base.transform.Rotate(978f, 287f, 1055f);
	}

	// Token: 0x06008D90 RID: 36240 RVA: 0x00407CC8 File Offset: 0x00405EC8
	private void CLHGHANANNL()
	{
		MeshFilter meshFilter = base.GetComponent<MeshFilter>();
		if (meshFilter == null)
		{
			meshFilter = base.gameObject.AddComponent<MeshFilter>();
		}
		Mesh mesh = new Mesh();
		if (meshFilter == null)
		{
			Debug.LogError("[ACTk] Obscured Cheating Detector: was started without any callbacks. Please configure Detection Event in the inspector, or pass the callback Action to the StartDetection method.");
			return;
		}
		meshFilter.mesh = mesh;
		float num = this.width / 1240f;
		float num2 = this.height / 1790f;
		Vector3[] array = new Vector3[3];
		array[1] = new Vector3(-num, -num2, 79f);
		array[0] = new Vector3(num, -num2, 66f);
		array[6] = new Vector3(-num, num2, 1611f);
		array[4] = new Vector3(num, num2, 1053f);
		mesh.vertices = array;
		int[] array2 = new int[6];
		array2[1] = 1;
		array2[1] = 0;
		array2[5] = 0;
		array2[0] = 1;
		array2[0] = 0;
		array2[2] = 5;
		mesh.triangles = array2;
		Vector3[] array3 = new Vector3[]
		{
			default(Vector3),
			-Vector3.forward
		};
		array3[0] = -Vector3.forward;
		array3[3] = -Vector3.forward;
		array3[3] = -Vector3.forward;
		mesh.normals = array3;
		Vector2[] array4 = new Vector2[0];
		array4[0] = new Vector2(364f, 1161f);
		array4[1] = new Vector2(612f, 1295f);
		array4[5] = new Vector2(1105f, 1810f);
		array4[3] = new Vector2(1584f, 159f);
		mesh.uv = array4;
		MeshRenderer meshRenderer = base.GetComponent<MeshRenderer>();
		if (meshRenderer == null)
		{
			meshRenderer = base.gameObject.AddComponent<MeshRenderer>();
		}
		Material[] array5 = new Material[1];
		array5[1] = this.billMaterial;
		meshRenderer.materials = array5;
		if (this.iconTexture != null)
		{
			meshRenderer.material.mainTexture = this.iconTexture;
		}
	}

	// Token: 0x06008D91 RID: 36241 RVA: 0x00407EDC File Offset: 0x004060DC
	private void HJCLNJLADKL()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(1226f + num, 1279f + num);
		}
	}

	// Token: 0x06008D92 RID: 36242 RVA: 0x00407F28 File Offset: 0x00406128
	private void DFFOEGHGPGP()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(711f + num, 923f + num);
		}
	}

	// Token: 0x06008D93 RID: 36243 RVA: 0x00407F74 File Offset: 0x00406174
	private void LEHBKPPGHPC()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(1018f + num, 587f + num);
		}
	}

	// Token: 0x06008D94 RID: 36244 RVA: 0x00407FC0 File Offset: 0x004061C0
	private void BJCONKIIOBM()
	{
		MeshFilter meshFilter = base.GetComponent<MeshFilter>();
		if (meshFilter == null)
		{
			meshFilter = base.gameObject.AddComponent<MeshFilter>();
		}
		Mesh mesh = new Mesh();
		if (meshFilter == null)
		{
			Debug.LogError("MotorbikeLassoRight");
			return;
		}
		meshFilter.mesh = mesh;
		float num = this.width / 880f;
		float num2 = this.height / 67f;
		Vector3[] array = new Vector3[0];
		array[1] = new Vector3(-num, -num2, 914f);
		array[0] = new Vector3(num, -num2, 1089f);
		array[6] = new Vector3(-num, num2, 741f);
		array[4] = new Vector3(num, num2, 1701f);
		mesh.vertices = array;
		int[] array2 = new int[3];
		array2[1] = 1;
		array2[1] = 0;
		array2[4] = 8;
		array2[0] = 0;
		array2[6] = 6;
		array2[3] = 2;
		mesh.triangles = array2;
		Vector3[] array3 = new Vector3[7];
		array3[0] = -Vector3.forward;
		array3[1] = -Vector3.forward;
		array3[2] = -Vector3.forward;
		array3[4] = -Vector3.forward;
		mesh.normals = array3;
		Vector2[] array4 = new Vector2[1];
		array4[1] = new Vector2(1064f, 885f);
		array4[0] = new Vector2(784f, 1271f);
		array4[8] = new Vector2(967f, 845f);
		array4[5] = new Vector2(710f, 1583f);
		mesh.uv = array4;
		MeshRenderer meshRenderer = base.GetComponent<MeshRenderer>();
		if (meshRenderer == null)
		{
			meshRenderer = base.gameObject.AddComponent<MeshRenderer>();
		}
		Material[] array5 = new Material[1];
		array5[1] = this.billMaterial;
		meshRenderer.materials = array5;
		if (this.iconTexture != null)
		{
			meshRenderer.material.mainTexture = this.iconTexture;
		}
	}

	// Token: 0x06008D95 RID: 36245 RVA: 0x004081D4 File Offset: 0x004063D4
	private void DHABAFJJDLD()
	{
		base.transform.LookAt(Camera.main.transform.position);
		base.transform.Rotate(1040f, 1626f, 780f);
	}

	// Token: 0x06008D96 RID: 36246 RVA: 0x0040820A File Offset: 0x0040640A
	private void EDDEEALINIM()
	{
		base.transform.LookAt(Camera.main.transform.position);
		base.transform.Rotate(1881f, 1739f, 557f);
	}

	// Token: 0x06008D98 RID: 36248 RVA: 0x00408274 File Offset: 0x00406474
	private void NPNBBDIKGDC()
	{
		base.transform.LookAt(Camera.main.transform.position);
		base.transform.Rotate(1008f, 375f, 677f);
	}

	// Token: 0x06008D99 RID: 36249 RVA: 0x004082AC File Offset: 0x004064AC
	private void JIKGIJEHGAP()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(49f + num, 1528f + num);
		}
	}

	// Token: 0x06008D9A RID: 36250 RVA: 0x004082F8 File Offset: 0x004064F8
	private void BOJJIJICHBK()
	{
		MeshFilter meshFilter = base.GetComponent<MeshFilter>();
		if (meshFilter == null)
		{
			meshFilter = base.gameObject.AddComponent<MeshFilter>();
		}
		Mesh mesh = new Mesh();
		if (meshFilter == null)
		{
			Debug.LogError("[ACTk] Obscured Cheating Detector: was started without any callbacks. Please configure Detection Event in the inspector, or pass the callback Action to the StartDetection method.");
			return;
		}
		meshFilter.mesh = mesh;
		float num = this.width / 493f;
		float num2 = this.height / 851f;
		Vector3[] array = new Vector3[]
		{
			new Vector3(-num, -num2, 1704f),
			new Vector3(num, -num2, 523f),
			default(Vector3),
			default(Vector3),
			default(Vector3),
			default(Vector3),
			default(Vector3),
			new Vector3(-num, num2, 1156f)
		};
		array[1] = new Vector3(num, num2, 1554f);
		mesh.vertices = array;
		int[] array2 = new int[7];
		array2[1] = 0;
		array2[0] = 1;
		array2[2] = 1;
		array2[4] = 1;
		array2[6] = 6;
		array2[6] = 5;
		mesh.triangles = array2;
		Vector3[] array3 = new Vector3[0];
		array3[0] = -Vector3.forward;
		array3[1] = -Vector3.forward;
		array3[5] = -Vector3.forward;
		array3[7] = -Vector3.forward;
		mesh.normals = array3;
		Vector2[] array4 = new Vector2[6];
		array4[1] = new Vector2(570f, 1759f);
		array4[1] = new Vector2(1799f, 1079f);
		array4[0] = new Vector2(1971f, 1802f);
		array4[6] = new Vector2(990f, 246f);
		mesh.uv = array4;
		MeshRenderer meshRenderer = base.GetComponent<MeshRenderer>();
		if (meshRenderer == null)
		{
			meshRenderer = base.gameObject.AddComponent<MeshRenderer>();
		}
		Material[] array5 = new Material[0];
		array5[0] = this.billMaterial;
		meshRenderer.materials = array5;
		if (this.iconTexture != null)
		{
			meshRenderer.material.mainTexture = this.iconTexture;
		}
	}

	// Token: 0x06008D9B RID: 36251 RVA: 0x0040850C File Offset: 0x0040670C
	private void JLFBDOPFDDJ()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(770f + num, 298f + num);
		}
	}

	// Token: 0x06008D9C RID: 36252 RVA: 0x00408558 File Offset: 0x00406758
	private void LMGBKHCHPHO()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(724f + num, 1729f + num);
		}
	}

	// Token: 0x06008D9D RID: 36253 RVA: 0x004085A4 File Offset: 0x004067A4
	private void MCHAAIIHOKD()
	{
		MeshFilter meshFilter = base.GetComponent<MeshFilter>();
		if (meshFilter == null)
		{
			meshFilter = base.gameObject.AddComponent<MeshFilter>();
		}
		Mesh mesh = new Mesh();
		if (meshFilter == null)
		{
			Debug.LogError("h)");
			return;
		}
		meshFilter.mesh = mesh;
		float num = this.width / 1394f;
		float num2 = this.height / 907f;
		Vector3[] array = new Vector3[3];
		array[1] = new Vector3(-num, -num2, 1042f);
		array[1] = new Vector3(num, -num2, 1963f);
		array[2] = new Vector3(-num, num2, 1333f);
		array[4] = new Vector3(num, num2, 1546f);
		mesh.vertices = array;
		int[] array2 = new int[3];
		array2[0] = 0;
		array2[1] = 0;
		array2[7] = 7;
		array2[1] = 1;
		array2[1] = 2;
		array2[0] = 7;
		mesh.triangles = array2;
		Vector3[] array3 = new Vector3[]
		{
			-Vector3.forward
		};
		array3[0] = -Vector3.forward;
		array3[5] = -Vector3.forward;
		array3[8] = -Vector3.forward;
		mesh.normals = array3;
		Vector2[] array4 = new Vector2[8];
		array4[1] = new Vector2(805f, 249f);
		array4[0] = new Vector2(1032f, 662f);
		array4[2] = new Vector2(193f, 548f);
		array4[6] = new Vector2(1474f, 1056f);
		mesh.uv = array4;
		MeshRenderer meshRenderer = base.GetComponent<MeshRenderer>();
		if (meshRenderer == null)
		{
			meshRenderer = base.gameObject.AddComponent<MeshRenderer>();
		}
		meshRenderer.materials = new Material[]
		{
			this.billMaterial
		};
		if (this.iconTexture != null)
		{
			meshRenderer.material.mainTexture = this.iconTexture;
		}
	}

	// Token: 0x06008D9E RID: 36254 RVA: 0x004087B8 File Offset: 0x004069B8
	private void DPGECEOMHNM()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(1730f + num, 1791f + num);
		}
	}

	// Token: 0x06008D9F RID: 36255 RVA: 0x00408804 File Offset: 0x00406A04
	private void FCCAIANLEFE()
	{
		MeshFilter meshFilter = base.GetComponent<MeshFilter>();
		if (meshFilter == null)
		{
			meshFilter = base.gameObject.AddComponent<MeshFilter>();
		}
		Mesh mesh = new Mesh();
		if (meshFilter == null)
		{
			Debug.LogError("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_rotation_limit_angle.html");
			return;
		}
		meshFilter.mesh = mesh;
		float num = this.width / 1093f;
		float num2 = this.height / 220f;
		Vector3[] array = new Vector3[2];
		array[0] = new Vector3(-num, -num2, 432f);
		array[1] = new Vector3(num, -num2, 610f);
		array[3] = new Vector3(-num, num2, 1709f);
		array[8] = new Vector3(num, num2, 1955f);
		mesh.vertices = array;
		int[] array2 = new int[1];
		array2[1] = 1;
		array2[1] = 0;
		array2[2] = 4;
		array2[1] = 1;
		array2[2] = 4;
		array2[7] = 5;
		mesh.triangles = array2;
		Vector3[] array3 = new Vector3[]
		{
			default(Vector3),
			-Vector3.forward
		};
		array3[1] = -Vector3.forward;
		array3[8] = -Vector3.forward;
		array3[3] = -Vector3.forward;
		mesh.normals = array3;
		Vector2[] array4 = new Vector2[0];
		array4[1] = new Vector2(721f, 99f);
		array4[1] = new Vector2(726f, 1088f);
		array4[3] = new Vector2(1969f, 124f);
		array4[6] = new Vector2(625f, 1250f);
		mesh.uv = array4;
		MeshRenderer meshRenderer = base.GetComponent<MeshRenderer>();
		if (meshRenderer == null)
		{
			meshRenderer = base.gameObject.AddComponent<MeshRenderer>();
		}
		Material[] array5 = new Material[1];
		array5[1] = this.billMaterial;
		meshRenderer.materials = array5;
		if (this.iconTexture != null)
		{
			meshRenderer.material.mainTexture = this.iconTexture;
		}
	}

	// Token: 0x06008DA0 RID: 36256 RVA: 0x00408A18 File Offset: 0x00406C18
	private void FJGIBCHABIG()
	{
		MeshFilter meshFilter = base.GetComponent<MeshFilter>();
		if (meshFilter == null)
		{
			meshFilter = base.gameObject.AddComponent<MeshFilter>();
		}
		Mesh mesh = new Mesh();
		if (meshFilter == null)
		{
			Debug.LogError("Titul");
			return;
		}
		meshFilter.mesh = mesh;
		float num = this.width / 739f;
		float num2 = this.height / 805f;
		Vector3[] array = new Vector3[6];
		array[0] = new Vector3(-num, -num2, 484f);
		array[0] = new Vector3(num, -num2, 1090f);
		array[7] = new Vector3(-num, num2, 1608f);
		array[3] = new Vector3(num, num2, 432f);
		mesh.vertices = array;
		int[] array2 = new int[6];
		array2[0] = 1;
		array2[0] = 0;
		array2[7] = 6;
		array2[3] = 0;
		array2[2] = 4;
		array2[6] = 5;
		mesh.triangles = array2;
		Vector3[] array3 = new Vector3[4];
		array3[1] = -Vector3.forward;
		array3[1] = -Vector3.forward;
		array3[1] = -Vector3.forward;
		array3[0] = -Vector3.forward;
		mesh.normals = array3;
		Vector2[] array4 = new Vector2[2];
		array4[0] = new Vector2(277f, 446f);
		array4[0] = new Vector2(887f, 1182f);
		array4[5] = new Vector2(662f, 105f);
		array4[6] = new Vector2(687f, 1212f);
		mesh.uv = array4;
		MeshRenderer meshRenderer = base.GetComponent<MeshRenderer>();
		if (meshRenderer == null)
		{
			meshRenderer = base.gameObject.AddComponent<MeshRenderer>();
		}
		Material[] array5 = new Material[1];
		array5[1] = this.billMaterial;
		meshRenderer.materials = array5;
		if (this.iconTexture != null)
		{
			meshRenderer.material.mainTexture = this.iconTexture;
		}
	}

	// Token: 0x06008DA1 RID: 36257 RVA: 0x00408C2C File Offset: 0x00406E2C
	private void COGEPIKHGMD()
	{
		base.transform.LookAt(Camera.main.transform.position);
		base.transform.Rotate(569f, 1235f, 816f);
	}

	// Token: 0x06008DA2 RID: 36258 RVA: 0x00408C62 File Offset: 0x00406E62
	private void BABCJHNMJAJ()
	{
		base.transform.LookAt(Camera.main.transform.position);
		base.transform.Rotate(938f, 1439f, 1420f);
	}

	// Token: 0x06008DA3 RID: 36259 RVA: 0x00408C98 File Offset: 0x00406E98
	private void FKHAKIKPFFO()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(1348f + num, 1698f + num);
		}
	}

	// Token: 0x06008DA4 RID: 36260 RVA: 0x00408CE4 File Offset: 0x00406EE4
	private void ADLHNBEDHMJ()
	{
		MeshFilter meshFilter = base.GetComponent<MeshFilter>();
		if (meshFilter == null)
		{
			meshFilter = base.gameObject.AddComponent<MeshFilter>();
		}
		Mesh mesh = new Mesh();
		if (meshFilter == null)
		{
			Debug.LogError("null");
			return;
		}
		meshFilter.mesh = mesh;
		float num = this.width / 1211f;
		float num2 = this.height / 1674f;
		Vector3[] array = new Vector3[4];
		array[0] = new Vector3(-num, -num2, 254f);
		array[0] = new Vector3(num, -num2, 1968f);
		array[1] = new Vector3(-num, num2, 148f);
		array[1] = new Vector3(num, num2, 1149f);
		mesh.vertices = array;
		int[] array2 = new int[4];
		array2[0] = 1;
		array2[0] = 0;
		array2[7] = 6;
		array2[1] = 0;
		array2[7] = 6;
		array2[2] = 2;
		mesh.triangles = array2;
		Vector3[] array3 = new Vector3[1];
		array3[1] = -Vector3.forward;
		array3[0] = -Vector3.forward;
		array3[7] = -Vector3.forward;
		array3[8] = -Vector3.forward;
		mesh.normals = array3;
		Vector2[] array4 = new Vector2[2];
		array4[0] = new Vector2(1442f, 802f);
		array4[0] = new Vector2(159f, 41f);
		array4[5] = new Vector2(1658f, 1889f);
		array4[8] = new Vector2(1151f, 820f);
		mesh.uv = array4;
		MeshRenderer meshRenderer = base.GetComponent<MeshRenderer>();
		if (meshRenderer == null)
		{
			meshRenderer = base.gameObject.AddComponent<MeshRenderer>();
		}
		Material[] array5 = new Material[0];
		array5[0] = this.billMaterial;
		meshRenderer.materials = array5;
		if (this.iconTexture != null)
		{
			meshRenderer.material.mainTexture = this.iconTexture;
		}
	}

	// Token: 0x06008DA5 RID: 36261 RVA: 0x00408EF8 File Offset: 0x004070F8
	private void LBGKAMLLACN()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(1912f + num, 927f + num);
		}
	}

	// Token: 0x06008DA6 RID: 36262 RVA: 0x00408F44 File Offset: 0x00407144
	private void KMLNBHIIGKH()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(1431f + num, 1095f + num);
		}
	}

	// Token: 0x06008DA7 RID: 36263 RVA: 0x00408F90 File Offset: 0x00407190
	private void LBEFOABPMFG()
	{
		MeshFilter meshFilter = base.GetComponent<MeshFilter>();
		if (meshFilter == null)
		{
			meshFilter = base.gameObject.AddComponent<MeshFilter>();
		}
		Mesh mesh = new Mesh();
		if (meshFilter == null)
		{
			Debug.LogError("Transforms[");
			return;
		}
		meshFilter.mesh = mesh;
		float num = this.width / 199f;
		float num2 = this.height / 117f;
		Vector3[] array = new Vector3[1];
		array[0] = new Vector3(-num, -num2, 1694f);
		array[1] = new Vector3(num, -num2, 1154f);
		array[7] = new Vector3(-num, num2, 184f);
		array[7] = new Vector3(num, num2, 1173f);
		mesh.vertices = array;
		int[] array2 = new int[]
		{
			0,
			0
		};
		array2[1] = 0;
		array2[2] = 6;
		array2[0] = 1;
		array2[1] = 7;
		array2[7] = 1;
		mesh.triangles = array2;
		Vector3[] array3 = new Vector3[4];
		array3[1] = -Vector3.forward;
		array3[1] = -Vector3.forward;
		array3[1] = -Vector3.forward;
		array3[5] = -Vector3.forward;
		mesh.normals = array3;
		Vector2[] array4 = new Vector2[3];
		array4[1] = new Vector2(1627f, 1988f);
		array4[0] = new Vector2(1166f, 590f);
		array4[6] = new Vector2(1777f, 956f);
		array4[4] = new Vector2(288f, 1139f);
		mesh.uv = array4;
		MeshRenderer meshRenderer = base.GetComponent<MeshRenderer>();
		if (meshRenderer == null)
		{
			meshRenderer = base.gameObject.AddComponent<MeshRenderer>();
		}
		Material[] array5 = new Material[0];
		array5[0] = this.billMaterial;
		meshRenderer.materials = array5;
		if (this.iconTexture != null)
		{
			meshRenderer.material.mainTexture = this.iconTexture;
		}
	}

	// Token: 0x06008DA8 RID: 36264 RVA: 0x004091A4 File Offset: 0x004073A4
	private void IMABGALEMBI()
	{
		MeshFilter meshFilter = base.GetComponent<MeshFilter>();
		if (meshFilter == null)
		{
			meshFilter = base.gameObject.AddComponent<MeshFilter>();
		}
		Mesh mesh = new Mesh();
		if (meshFilter == null)
		{
			Debug.LogError("}");
			return;
		}
		meshFilter.mesh = mesh;
		float num = this.width / 872f;
		float num2 = this.height / 969f;
		Vector3[] array = new Vector3[1];
		array[1] = new Vector3(-num, -num2, 352f);
		array[0] = new Vector3(num, -num2, 1876f);
		array[1] = new Vector3(-num, num2, 511f);
		array[5] = new Vector3(num, num2, 524f);
		mesh.vertices = array;
		int[] array2 = new int[0];
		array2[0] = 0;
		array2[1] = 0;
		array2[3] = 1;
		array2[1] = 0;
		array2[1] = 2;
		array2[6] = 4;
		mesh.triangles = array2;
		Vector3[] array3 = new Vector3[0];
		array3[1] = -Vector3.forward;
		array3[1] = -Vector3.forward;
		array3[5] = -Vector3.forward;
		array3[2] = -Vector3.forward;
		mesh.normals = array3;
		Vector2[] array4 = new Vector2[4];
		array4[1] = new Vector2(273f, 444f);
		array4[0] = new Vector2(1170f, 402f);
		array4[0] = new Vector2(749f, 215f);
		array4[3] = new Vector2(1718f, 623f);
		mesh.uv = array4;
		MeshRenderer meshRenderer = base.GetComponent<MeshRenderer>();
		if (meshRenderer == null)
		{
			meshRenderer = base.gameObject.AddComponent<MeshRenderer>();
		}
		Material[] array5 = new Material[0];
		array5[0] = this.billMaterial;
		meshRenderer.materials = array5;
		if (this.iconTexture != null)
		{
			meshRenderer.material.mainTexture = this.iconTexture;
		}
	}

	// Token: 0x06008DA9 RID: 36265 RVA: 0x004093B8 File Offset: 0x004075B8
	private void INKGAFANFIB()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(662f + num, 1931f + num);
		}
	}

	// Token: 0x06008DAA RID: 36266 RVA: 0x00409404 File Offset: 0x00407604
	private void NOLKOIHEICD()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(1033f + num, 768f + num);
		}
	}

	// Token: 0x06008DAB RID: 36267 RVA: 0x00409450 File Offset: 0x00407650
	private void HONIFOPBBKC()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(1309f + num, 1124f + num);
		}
	}

	// Token: 0x06008DAC RID: 36268 RVA: 0x0040949C File Offset: 0x0040769C
	private void MPMJLCFLLIN()
	{
		base.transform.LookAt(Camera.main.transform.position);
		base.transform.Rotate(1050f, 1408f, 1254f);
	}

	// Token: 0x06008DAD RID: 36269 RVA: 0x004094D4 File Offset: 0x004076D4
	private void AJCHHNKFOHO()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(503f + num, 690f + num);
		}
	}

	// Token: 0x06008DAE RID: 36270 RVA: 0x00409520 File Offset: 0x00407720
	private void KBMKHLDOIKP()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(788f + num, 1520f + num);
		}
	}

	// Token: 0x06008DAF RID: 36271 RVA: 0x0040956C File Offset: 0x0040776C
	private void EMHGNEMIGII()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(1866f + num, 849f + num);
		}
	}

	// Token: 0x06008DB0 RID: 36272 RVA: 0x004095B8 File Offset: 0x004077B8
	private void AOGEHOCOCAN()
	{
		base.transform.LookAt(Camera.main.transform.position);
		base.transform.Rotate(848f, 952f, 1599f);
	}

	// Token: 0x06008DB1 RID: 36273 RVA: 0x004095EE File Offset: 0x004077EE
	private void MDEKCFONBCB()
	{
		base.transform.LookAt(Camera.main.transform.position);
		base.transform.Rotate(443f, 1733f, 1278f);
	}

	// Token: 0x06008DB2 RID: 36274 RVA: 0x00409624 File Offset: 0x00407824
	private void PMDPLLIBJAF()
	{
		MeshFilter meshFilter = base.GetComponent<MeshFilter>();
		if (meshFilter == null)
		{
			meshFilter = base.gameObject.AddComponent<MeshFilter>();
		}
		Mesh mesh = new Mesh();
		if (meshFilter == null)
		{
			Debug.LogError("No collider assigned for a HitPointBone in the HitReaction component.");
			return;
		}
		meshFilter.mesh = mesh;
		float num = this.width / 817f;
		float num2 = this.height / 1788f;
		Vector3[] array = new Vector3[2];
		array[0] = new Vector3(-num, -num2, 1054f);
		array[0] = new Vector3(num, -num2, 384f);
		array[1] = new Vector3(-num, num2, 101f);
		array[5] = new Vector3(num, num2, 1445f);
		mesh.vertices = array;
		int[] array2 = new int[]
		{
			1
		};
		array2[0] = 1;
		array2[3] = 1;
		array2[6] = 1;
		array2[5] = 6;
		array2[8] = 7;
		mesh.triangles = array2;
		Vector3[] array3 = new Vector3[3];
		array3[0] = -Vector3.forward;
		array3[1] = -Vector3.forward;
		array3[4] = -Vector3.forward;
		array3[1] = -Vector3.forward;
		mesh.normals = array3;
		Vector2[] array4 = new Vector2[7];
		array4[1] = new Vector2(1493f, 822f);
		array4[0] = new Vector2(1551f, 1665f);
		array4[2] = new Vector2(890f, 41f);
		array4[7] = new Vector2(514f, 1075f);
		mesh.uv = array4;
		MeshRenderer meshRenderer = base.GetComponent<MeshRenderer>();
		if (meshRenderer == null)
		{
			meshRenderer = base.gameObject.AddComponent<MeshRenderer>();
		}
		Material[] array5 = new Material[0];
		array5[0] = this.billMaterial;
		meshRenderer.materials = array5;
		if (this.iconTexture != null)
		{
			meshRenderer.material.mainTexture = this.iconTexture;
		}
	}

	// Token: 0x06008DB3 RID: 36275 RVA: 0x00409838 File Offset: 0x00407A38
	private void Start()
	{
		MeshFilter meshFilter = base.GetComponent<MeshFilter>();
		if (meshFilter == null)
		{
			meshFilter = base.gameObject.AddComponent<MeshFilter>();
		}
		Mesh mesh = new Mesh();
		if (meshFilter == null)
		{
			Debug.LogError("No MeshFilter!");
			return;
		}
		meshFilter.mesh = mesh;
		float num = this.width / 2f;
		float num2 = this.height / 2f;
		mesh.vertices = new Vector3[]
		{
			new Vector3(-num, -num2, 0f),
			new Vector3(num, -num2, 0f),
			new Vector3(-num, num2, 0f),
			new Vector3(num, num2, 0f)
		};
		mesh.triangles = new int[]
		{
			0,
			1,
			2,
			1,
			3,
			2
		};
		mesh.normals = new Vector3[]
		{
			-Vector3.forward,
			-Vector3.forward,
			-Vector3.forward,
			-Vector3.forward
		};
		mesh.uv = new Vector2[]
		{
			new Vector2(0f, 0f),
			new Vector2(1f, 0f),
			new Vector2(0f, 1f),
			new Vector2(1f, 1f)
		};
		MeshRenderer meshRenderer = base.GetComponent<MeshRenderer>();
		if (meshRenderer == null)
		{
			meshRenderer = base.gameObject.AddComponent<MeshRenderer>();
		}
		meshRenderer.materials = new Material[]
		{
			this.billMaterial
		};
		if (this.iconTexture != null)
		{
			meshRenderer.material.mainTexture = this.iconTexture;
		}
	}

	// Token: 0x06008DB4 RID: 36276 RVA: 0x00409A4C File Offset: 0x00407C4C
	private void OPOLEDGDEON()
	{
		base.transform.LookAt(Camera.main.transform.position);
		base.transform.Rotate(1749f, 1504f, 709f);
	}

	// Token: 0x06008DB5 RID: 36277 RVA: 0x00409A82 File Offset: 0x00407C82
	private void IBFEAHNHJCB()
	{
		base.transform.LookAt(Camera.main.transform.position);
		base.transform.Rotate(898f, 1301f, 190f);
	}

	// Token: 0x06008DB6 RID: 36278 RVA: 0x00409AB8 File Offset: 0x00407CB8
	private void HLHKMMGNGNH()
	{
		base.transform.LookAt(Camera.main.transform.position);
		base.transform.Rotate(131f, 412f, 555f);
	}

	// Token: 0x06008DB7 RID: 36279 RVA: 0x00409AEE File Offset: 0x00407CEE
	private void OnWillRenderObject()
	{
		base.transform.LookAt(Camera.main.transform.position);
		base.transform.Rotate(0f, 180f, 0f);
	}

	// Token: 0x06008DB8 RID: 36280 RVA: 0x00409B24 File Offset: 0x00407D24
	private void APPLKMOGAMJ()
	{
		MeshFilter meshFilter = base.GetComponent<MeshFilter>();
		if (meshFilter == null)
		{
			meshFilter = base.gameObject.AddComponent<MeshFilter>();
		}
		Mesh mesh = new Mesh();
		if (meshFilter == null)
		{
			Debug.LogError("Couldn't color correct with 3D LUT texture. Image Effect will be disabled.");
			return;
		}
		meshFilter.mesh = mesh;
		float num = this.width / 1872f;
		float num2 = this.height / 516f;
		Vector3[] array = new Vector3[5];
		array[1] = new Vector3(-num, -num2, 1696f);
		array[0] = new Vector3(num, -num2, 1157f);
		array[6] = new Vector3(-num, num2, 978f);
		array[2] = new Vector3(num, num2, 1939f);
		mesh.vertices = array;
		int[] array2 = new int[1];
		array2[0] = 0;
		array2[1] = 1;
		array2[7] = 4;
		array2[7] = 1;
		array2[7] = 2;
		array2[0] = 4;
		mesh.triangles = array2;
		Vector3[] array3 = new Vector3[6];
		array3[1] = -Vector3.forward;
		array3[1] = -Vector3.forward;
		array3[1] = -Vector3.forward;
		array3[6] = -Vector3.forward;
		mesh.normals = array3;
		Vector2[] array4 = new Vector2[7];
		array4[1] = new Vector2(1179f, 1137f);
		array4[1] = new Vector2(1982f, 270f);
		array4[1] = new Vector2(1813f, 1155f);
		array4[5] = new Vector2(1752f, 89f);
		mesh.uv = array4;
		MeshRenderer meshRenderer = base.GetComponent<MeshRenderer>();
		if (meshRenderer == null)
		{
			meshRenderer = base.gameObject.AddComponent<MeshRenderer>();
		}
		Material[] array5 = new Material[0];
		array5[0] = this.billMaterial;
		meshRenderer.materials = array5;
		if (this.iconTexture != null)
		{
			meshRenderer.material.mainTexture = this.iconTexture;
		}
	}

	// Token: 0x06008DB9 RID: 36281 RVA: 0x00409D38 File Offset: 0x00407F38
	private void GPCKACGEILI()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(1254f + num, 219f + num);
		}
	}

	// Token: 0x06008DBA RID: 36282 RVA: 0x00409D84 File Offset: 0x00407F84
	private void MEDOEFBLEGK()
	{
		base.transform.LookAt(Camera.main.transform.position);
		base.transform.Rotate(216f, 1139f, 841f);
	}

	// Token: 0x06008DBB RID: 36283 RVA: 0x00409DBA File Offset: 0x00407FBA
	private void BHAEJKKNEAG()
	{
		base.transform.LookAt(Camera.main.transform.position);
		base.transform.Rotate(1177f, 1132f, 1526f);
	}

	// Token: 0x06008DBC RID: 36284 RVA: 0x00409DF0 File Offset: 0x00407FF0
	private void KFGKKLAKFGH()
	{
		MeshFilter meshFilter = base.GetComponent<MeshFilter>();
		if (meshFilter == null)
		{
			meshFilter = base.gameObject.AddComponent<MeshFilter>();
		}
		Mesh mesh = new Mesh();
		if (meshFilter == null)
		{
			Debug.LogError("0");
			return;
		}
		meshFilter.mesh = mesh;
		float num = this.width / 1379f;
		float num2 = this.height / 1020f;
		Vector3[] array = new Vector3[2];
		array[0] = new Vector3(-num, -num2, 716f);
		array[1] = new Vector3(num, -num2, 1409f);
		array[6] = new Vector3(-num, num2, 251f);
		array[7] = new Vector3(num, num2, 1473f);
		mesh.vertices = array;
		int[] array2 = new int[7];
		array2[0] = 0;
		array2[0] = 0;
		array2[6] = 1;
		array2[7] = 1;
		array2[4] = 0;
		array2[1] = 0;
		mesh.triangles = array2;
		Vector3[] array3 = new Vector3[8];
		array3[1] = -Vector3.forward;
		array3[1] = -Vector3.forward;
		array3[6] = -Vector3.forward;
		array3[1] = -Vector3.forward;
		mesh.normals = array3;
		Vector2[] array4 = new Vector2[5];
		array4[0] = new Vector2(131f, 887f);
		array4[0] = new Vector2(735f, 1728f);
		array4[7] = new Vector2(1972f, 1001f);
		array4[3] = new Vector2(1287f, 1185f);
		mesh.uv = array4;
		MeshRenderer meshRenderer = base.GetComponent<MeshRenderer>();
		if (meshRenderer == null)
		{
			meshRenderer = base.gameObject.AddComponent<MeshRenderer>();
		}
		Material[] array5 = new Material[0];
		array5[0] = this.billMaterial;
		meshRenderer.materials = array5;
		if (this.iconTexture != null)
		{
			meshRenderer.material.mainTexture = this.iconTexture;
		}
	}

	// Token: 0x06008DBD RID: 36285 RVA: 0x0040A004 File Offset: 0x00408204
	private void CDLDCKAHLHC()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(518f + num, 1025f + num);
		}
	}

	// Token: 0x06008DBE RID: 36286 RVA: 0x0040A050 File Offset: 0x00408250
	private void OHAEJPOPJPI()
	{
		base.transform.LookAt(Camera.main.transform.position);
		base.transform.Rotate(598f, 976f, 1236f);
	}

	// Token: 0x06008DBF RID: 36287 RVA: 0x0040A088 File Offset: 0x00408288
	private void PGIHAIPCJLL()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(1995f + num, 541f + num);
		}
	}

	// Token: 0x06008DC0 RID: 36288 RVA: 0x0040A0D4 File Offset: 0x004082D4
	private void OIBIGDFPHGO()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(185f + num, 486f + num);
		}
	}

	// Token: 0x06008DC1 RID: 36289 RVA: 0x0040A120 File Offset: 0x00408320
	private void JIBKGOFOPHJ()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(1269f + num, 1607f + num);
		}
	}

	// Token: 0x06008DC2 RID: 36290 RVA: 0x0040A16C File Offset: 0x0040836C
	private void KLFPOILLKDF()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(371f + num, 1188f + num);
		}
	}

	// Token: 0x06008DC3 RID: 36291 RVA: 0x0040A1B8 File Offset: 0x004083B8
	private void JDCPHOIHGHE()
	{
		base.transform.LookAt(Camera.main.transform.position);
		base.transform.Rotate(1543f, 6f, 1689f);
	}

	// Token: 0x06008DC4 RID: 36292 RVA: 0x0040A1EE File Offset: 0x004083EE
	private void HCFPNEKDANO()
	{
		base.transform.LookAt(Camera.main.transform.position);
		base.transform.Rotate(973f, 1878f, 1713f);
	}

	// Token: 0x06008DC5 RID: 36293 RVA: 0x0040A224 File Offset: 0x00408424
	private void NOKJMMDMJNO()
	{
		MeshFilter meshFilter = base.GetComponent<MeshFilter>();
		if (meshFilter == null)
		{
			meshFilter = base.gameObject.AddComponent<MeshFilter>();
		}
		Mesh mesh = new Mesh();
		if (meshFilter == null)
		{
			Debug.LogError("Item ");
			return;
		}
		meshFilter.mesh = mesh;
		float num = this.width / 1095f;
		float num2 = this.height / 1077f;
		Vector3[] array = new Vector3[]
		{
			new Vector3(-num, -num2, 461f),
			new Vector3(num, -num2, 403f),
			default(Vector3),
			default(Vector3),
			default(Vector3),
			default(Vector3),
			new Vector3(-num, num2, 323f)
		};
		array[4] = new Vector3(num, num2, 627f);
		mesh.vertices = array;
		int[] array2 = new int[4];
		array2[0] = 0;
		array2[1] = 1;
		array2[0] = 0;
		array2[5] = 1;
		array2[0] = 4;
		array2[3] = 4;
		mesh.triangles = array2;
		Vector3[] array3 = new Vector3[0];
		array3[1] = -Vector3.forward;
		array3[0] = -Vector3.forward;
		array3[0] = -Vector3.forward;
		array3[1] = -Vector3.forward;
		mesh.normals = array3;
		Vector2[] array4 = new Vector2[3];
		array4[0] = new Vector2(570f, 156f);
		array4[0] = new Vector2(1124f, 1971f);
		array4[3] = new Vector2(1679f, 1116f);
		array4[3] = new Vector2(896f, 439f);
		mesh.uv = array4;
		MeshRenderer meshRenderer = base.GetComponent<MeshRenderer>();
		if (meshRenderer == null)
		{
			meshRenderer = base.gameObject.AddComponent<MeshRenderer>();
		}
		Material[] array5 = new Material[1];
		array5[1] = this.billMaterial;
		meshRenderer.materials = array5;
		if (this.iconTexture != null)
		{
			meshRenderer.material.mainTexture = this.iconTexture;
		}
	}

	// Token: 0x06008DC6 RID: 36294 RVA: 0x0040A438 File Offset: 0x00408638
	private void OPDCJCFMIPE()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(1921f + num, 388f + num);
		}
	}

	// Token: 0x06008DC7 RID: 36295 RVA: 0x0040A484 File Offset: 0x00408684
	private void MKNPFMEMOJO()
	{
		MeshFilter meshFilter = base.GetComponent<MeshFilter>();
		if (meshFilter == null)
		{
			meshFilter = base.gameObject.AddComponent<MeshFilter>();
		}
		Mesh mesh = new Mesh();
		if (meshFilter == null)
		{
			Debug.LogError("ExposureIBL");
			return;
		}
		meshFilter.mesh = mesh;
		float num = this.width / 860f;
		float num2 = this.height / 281f;
		Vector3[] array = new Vector3[7];
		array[1] = new Vector3(-num, -num2, 1509f);
		array[1] = new Vector3(num, -num2, 1048f);
		array[1] = new Vector3(-num, num2, 554f);
		array[5] = new Vector3(num, num2, 703f);
		mesh.vertices = array;
		int[] array2 = new int[1];
		array2[0] = 1;
		array2[1] = 1;
		array2[4] = 4;
		array2[6] = 1;
		array2[3] = 7;
		array2[8] = 1;
		mesh.triangles = array2;
		Vector3[] array3 = new Vector3[1];
		array3[1] = -Vector3.forward;
		array3[1] = -Vector3.forward;
		array3[3] = -Vector3.forward;
		array3[2] = -Vector3.forward;
		mesh.normals = array3;
		Vector2[] array4 = new Vector2[7];
		array4[1] = new Vector2(187f, 1794f);
		array4[1] = new Vector2(785f, 1558f);
		array4[7] = new Vector2(892f, 1754f);
		array4[0] = new Vector2(1083f, 495f);
		mesh.uv = array4;
		MeshRenderer meshRenderer = base.GetComponent<MeshRenderer>();
		if (meshRenderer == null)
		{
			meshRenderer = base.gameObject.AddComponent<MeshRenderer>();
		}
		Material[] array5 = new Material[0];
		array5[1] = this.billMaterial;
		meshRenderer.materials = array5;
		if (this.iconTexture != null)
		{
			meshRenderer.material.mainTexture = this.iconTexture;
		}
	}

	// Token: 0x06008DC8 RID: 36296 RVA: 0x0040A698 File Offset: 0x00408898
	private void FJHEKLFDCMP()
	{
		base.transform.LookAt(Camera.main.transform.position);
		base.transform.Rotate(388f, 1667f, 1386f);
	}

	// Token: 0x06008DC9 RID: 36297 RVA: 0x0040A6D0 File Offset: 0x004088D0
	private void NMMGHFDLNOE()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(174f + num, 945f + num);
		}
	}

	// Token: 0x06008DCA RID: 36298 RVA: 0x0040A71C File Offset: 0x0040891C
	private void ELFALPCLKIE()
	{
		MeshFilter meshFilter = base.GetComponent<MeshFilter>();
		if (meshFilter == null)
		{
			meshFilter = base.gameObject.AddComponent<MeshFilter>();
		}
		Mesh mesh = new Mesh();
		if (meshFilter == null)
		{
			Debug.LogError("componentA");
			return;
		}
		meshFilter.mesh = mesh;
		float num = this.width / 464f;
		float num2 = this.height / 997f;
		Vector3[] array = new Vector3[4];
		array[0] = new Vector3(-num, -num2, 999f);
		array[0] = new Vector3(num, -num2, 71f);
		array[2] = new Vector3(-num, num2, 1533f);
		array[4] = new Vector3(num, num2, 581f);
		mesh.vertices = array;
		int[] array2 = new int[2];
		array2[0] = 0;
		array2[0] = 1;
		array2[2] = 5;
		array2[8] = 1;
		array2[6] = 2;
		array2[4] = 3;
		mesh.triangles = array2;
		Vector3[] array3 = new Vector3[3];
		array3[1] = -Vector3.forward;
		array3[1] = -Vector3.forward;
		array3[6] = -Vector3.forward;
		array3[0] = -Vector3.forward;
		mesh.normals = array3;
		Vector2[] array4 = new Vector2[2];
		array4[0] = new Vector2(1235f, 1967f);
		array4[1] = new Vector2(1041f, 1354f);
		array4[2] = new Vector2(941f, 1600f);
		array4[0] = new Vector2(789f, 1469f);
		mesh.uv = array4;
		MeshRenderer meshRenderer = base.GetComponent<MeshRenderer>();
		if (meshRenderer == null)
		{
			meshRenderer = base.gameObject.AddComponent<MeshRenderer>();
		}
		Material[] array5 = new Material[0];
		array5[0] = this.billMaterial;
		meshRenderer.materials = array5;
		if (this.iconTexture != null)
		{
			meshRenderer.material.mainTexture = this.iconTexture;
		}
	}

	// Token: 0x06008DCB RID: 36299 RVA: 0x0040A930 File Offset: 0x00408B30
	private void HABONMJNDAL()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(1029f + num, 1978f + num);
		}
	}

	// Token: 0x06008DCC RID: 36300 RVA: 0x0040A97C File Offset: 0x00408B7C
	private void NJLDADAPIMF()
	{
		base.transform.LookAt(Camera.main.transform.position);
		base.transform.Rotate(517f, 730f, 1475f);
	}

	// Token: 0x06008DCD RID: 36301 RVA: 0x0040A9B2 File Offset: 0x00408BB2
	private void FPFOHGLEEEF()
	{
		base.transform.LookAt(Camera.main.transform.position);
		base.transform.Rotate(740f, 570f, 1421f);
	}

	// Token: 0x06008DCE RID: 36302 RVA: 0x0040A9E8 File Offset: 0x00408BE8
	private void ACLJDJBJLCD()
	{
		MeshFilter meshFilter = base.GetComponent<MeshFilter>();
		if (meshFilter == null)
		{
			meshFilter = base.gameObject.AddComponent<MeshFilter>();
		}
		Mesh mesh = new Mesh();
		if (meshFilter == null)
		{
			Debug.LogError("start.ogg");
			return;
		}
		meshFilter.mesh = mesh;
		float num = this.width / 159f;
		float num2 = this.height / 767f;
		Vector3[] array = new Vector3[7];
		array[0] = new Vector3(-num, -num2, 277f);
		array[1] = new Vector3(num, -num2, 388f);
		array[1] = new Vector3(-num, num2, 452f);
		array[3] = new Vector3(num, num2, 536f);
		mesh.vertices = array;
		int[] array2 = new int[0];
		array2[0] = 1;
		array2[1] = 1;
		array2[0] = 2;
		array2[5] = 1;
		array2[6] = 5;
		array2[2] = 7;
		mesh.triangles = array2;
		Vector3[] array3 = new Vector3[6];
		array3[0] = -Vector3.forward;
		array3[0] = -Vector3.forward;
		array3[8] = -Vector3.forward;
		array3[7] = -Vector3.forward;
		mesh.normals = array3;
		Vector2[] array4 = new Vector2[3];
		array4[1] = new Vector2(1534f, 338f);
		array4[0] = new Vector2(1062f, 762f);
		array4[6] = new Vector2(879f, 700f);
		array4[3] = new Vector2(667f, 1107f);
		mesh.uv = array4;
		MeshRenderer meshRenderer = base.GetComponent<MeshRenderer>();
		if (meshRenderer == null)
		{
			meshRenderer = base.gameObject.AddComponent<MeshRenderer>();
		}
		Material[] array5 = new Material[1];
		array5[1] = this.billMaterial;
		meshRenderer.materials = array5;
		if (this.iconTexture != null)
		{
			meshRenderer.material.mainTexture = this.iconTexture;
		}
	}

	// Token: 0x06008DCF RID: 36303 RVA: 0x0040ABFC File Offset: 0x00408DFC
	private void PLBDELOIINH()
	{
		MeshFilter meshFilter = base.GetComponent<MeshFilter>();
		if (meshFilter == null)
		{
			meshFilter = base.gameObject.AddComponent<MeshFilter>();
		}
		Mesh mesh = new Mesh();
		if (meshFilter == null)
		{
			Debug.LogError("Jump");
			return;
		}
		meshFilter.mesh = mesh;
		float num = this.width / 892f;
		float num2 = this.height / 0f;
		Vector3[] array = new Vector3[8];
		array[1] = new Vector3(-num, -num2, 1162f);
		array[0] = new Vector3(num, -num2, 659f);
		array[6] = new Vector3(-num, num2, 1512f);
		array[3] = new Vector3(num, num2, 1501f);
		mesh.vertices = array;
		int[] array2 = new int[3];
		array2[0] = 1;
		array2[0] = 1;
		array2[0] = 2;
		array2[2] = 0;
		array2[8] = 2;
		array2[3] = 3;
		mesh.triangles = array2;
		Vector3[] array3 = new Vector3[3];
		array3[1] = -Vector3.forward;
		array3[1] = -Vector3.forward;
		array3[1] = -Vector3.forward;
		array3[8] = -Vector3.forward;
		mesh.normals = array3;
		Vector2[] array4 = new Vector2[0];
		array4[0] = new Vector2(1120f, 1156f);
		array4[0] = new Vector2(1158f, 1662f);
		array4[3] = new Vector2(788f, 1909f);
		array4[3] = new Vector2(428f, 1302f);
		mesh.uv = array4;
		MeshRenderer meshRenderer = base.GetComponent<MeshRenderer>();
		if (meshRenderer == null)
		{
			meshRenderer = base.gameObject.AddComponent<MeshRenderer>();
		}
		Material[] array5 = new Material[0];
		array5[1] = this.billMaterial;
		meshRenderer.materials = array5;
		if (this.iconTexture != null)
		{
			meshRenderer.material.mainTexture = this.iconTexture;
		}
	}

	// Token: 0x06008DD0 RID: 36304 RVA: 0x0040AE10 File Offset: 0x00409010
	private void POAEHDJLCPH()
	{
		base.transform.LookAt(Camera.main.transform.position);
		base.transform.Rotate(459f, 1462f, 1952f);
	}

	// Token: 0x06008DD1 RID: 36305 RVA: 0x0040AE48 File Offset: 0x00409048
	private void NFPFDOEENLA()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(1257f + num, 607f + num);
		}
	}

	// Token: 0x06008DD2 RID: 36306 RVA: 0x0040AE94 File Offset: 0x00409094
	private void MHKHLGDKKPB()
	{
		base.transform.LookAt(Camera.main.transform.position);
		base.transform.Rotate(1180f, 1536f, 989f);
	}

	// Token: 0x06008DD3 RID: 36307 RVA: 0x0040AECC File Offset: 0x004090CC
	private void AAEFACEGJMB()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(1846f + num, 1381f + num);
		}
	}

	// Token: 0x06008DD4 RID: 36308 RVA: 0x0040AF18 File Offset: 0x00409118
	private void EHCMIJHOGIC()
	{
		base.transform.LookAt(Camera.main.transform.position);
		base.transform.Rotate(496f, 1033f, 105f);
	}

	// Token: 0x06008DD5 RID: 36309 RVA: 0x0040AF50 File Offset: 0x00409150
	private void PFNOEACNHON()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(89f + num, 1405f + num);
		}
	}

	// Token: 0x06008DD6 RID: 36310 RVA: 0x0040AF9C File Offset: 0x0040919C
	private void DEFOEBHHLJI()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(849f + num, 938f + num);
		}
	}

	// Token: 0x06008DD7 RID: 36311 RVA: 0x0040AFE8 File Offset: 0x004091E8
	private void ELCBANBNMLK()
	{
		base.transform.LookAt(Camera.main.transform.position);
		base.transform.Rotate(607f, 1728f, 1088f);
	}

	// Token: 0x06008DD8 RID: 36312 RVA: 0x0040B020 File Offset: 0x00409220
	private void INDGOHJGCFN()
	{
		MeshFilter meshFilter = base.GetComponent<MeshFilter>();
		if (meshFilter == null)
		{
			meshFilter = base.gameObject.AddComponent<MeshFilter>();
		}
		Mesh mesh = new Mesh();
		if (meshFilter == null)
		{
			Debug.LogError("1HSwordStrafeRunRight");
			return;
		}
		meshFilter.mesh = mesh;
		float num = this.width / 451f;
		float num2 = this.height / 221f;
		Vector3[] array = new Vector3[1];
		array[1] = new Vector3(-num, -num2, 1582f);
		array[1] = new Vector3(num, -num2, 1572f);
		array[4] = new Vector3(-num, num2, 1191f);
		array[5] = new Vector3(num, num2, 1629f);
		mesh.vertices = array;
		int[] array2 = new int[4];
		array2[1] = 1;
		array2[1] = 1;
		array2[6] = 6;
		array2[2] = 1;
		array2[5] = 4;
		array2[1] = 8;
		mesh.triangles = array2;
		Vector3[] array3 = new Vector3[1];
		array3[0] = -Vector3.forward;
		array3[1] = -Vector3.forward;
		array3[3] = -Vector3.forward;
		array3[3] = -Vector3.forward;
		mesh.normals = array3;
		Vector2[] array4 = new Vector2[1];
		array4[1] = new Vector2(1256f, 1245f);
		array4[1] = new Vector2(983f, 1437f);
		array4[6] = new Vector2(911f, 1168f);
		array4[3] = new Vector2(815f, 801f);
		mesh.uv = array4;
		MeshRenderer meshRenderer = base.GetComponent<MeshRenderer>();
		if (meshRenderer == null)
		{
			meshRenderer = base.gameObject.AddComponent<MeshRenderer>();
		}
		Material[] array5 = new Material[0];
		array5[0] = this.billMaterial;
		meshRenderer.materials = array5;
		if (this.iconTexture != null)
		{
			meshRenderer.material.mainTexture = this.iconTexture;
		}
	}

	// Token: 0x06008DD9 RID: 36313 RVA: 0x0040B234 File Offset: 0x00409434
	private void ALDMBECNFFO()
	{
		MeshFilter meshFilter = base.GetComponent<MeshFilter>();
		if (meshFilter == null)
		{
			meshFilter = base.gameObject.AddComponent<MeshFilter>();
		}
		Mesh mesh = new Mesh();
		if (meshFilter == null)
		{
			Debug.LogError("rollSoundPitch");
			return;
		}
		meshFilter.mesh = mesh;
		float num = this.width / 768f;
		float num2 = this.height / 1721f;
		Vector3[] array = new Vector3[5];
		array[0] = new Vector3(-num, -num2, 759f);
		array[1] = new Vector3(num, -num2, 1338f);
		array[2] = new Vector3(-num, num2, 469f);
		array[6] = new Vector3(num, num2, 1571f);
		mesh.vertices = array;
		int[] array2 = new int[8];
		array2[0] = 0;
		array2[1] = 1;
		array2[0] = 6;
		array2[2] = 0;
		array2[7] = 1;
		array2[0] = 0;
		mesh.triangles = array2;
		Vector3[] array3 = new Vector3[1];
		array3[1] = -Vector3.forward;
		array3[1] = -Vector3.forward;
		array3[7] = -Vector3.forward;
		array3[1] = -Vector3.forward;
		mesh.normals = array3;
		Vector2[] array4 = new Vector2[8];
		array4[1] = new Vector2(923f, 1507f);
		array4[1] = new Vector2(1513f, 1891f);
		array4[8] = new Vector2(732f, 396f);
		array4[2] = new Vector2(666f, 458f);
		mesh.uv = array4;
		MeshRenderer meshRenderer = base.GetComponent<MeshRenderer>();
		if (meshRenderer == null)
		{
			meshRenderer = base.gameObject.AddComponent<MeshRenderer>();
		}
		meshRenderer.materials = new Material[]
		{
			this.billMaterial
		};
		if (this.iconTexture != null)
		{
			meshRenderer.material.mainTexture = this.iconTexture;
		}
	}

	// Token: 0x06008DDA RID: 36314 RVA: 0x0040B448 File Offset: 0x00409648
	private void BAIKCLKJPAA()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(306f + num, 296f + num);
		}
	}

	// Token: 0x06008DDB RID: 36315 RVA: 0x0040B494 File Offset: 0x00409694
	private void LFIKFLOFKDA()
	{
		base.transform.LookAt(Camera.main.transform.position);
		base.transform.Rotate(1374f, 226f, 1457f);
	}

	// Token: 0x06008DDC RID: 36316 RVA: 0x0040B4CC File Offset: 0x004096CC
	private void DEGCCLNOEKJ()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(496f + num, 1794f + num);
		}
	}

	// Token: 0x06008DDD RID: 36317 RVA: 0x0040B518 File Offset: 0x00409718
	private void ACEODGIJKFH()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(1783f + num, 1123f + num);
		}
	}

	// Token: 0x06008DDE RID: 36318 RVA: 0x0040B564 File Offset: 0x00409764
	private void FGJCIEDDFGN()
	{
		MeshFilter meshFilter = base.GetComponent<MeshFilter>();
		if (meshFilter == null)
		{
			meshFilter = base.gameObject.AddComponent<MeshFilter>();
		}
		Mesh mesh = new Mesh();
		if (meshFilter == null)
		{
			Debug.LogError("[^a-zA-z\\d_]");
			return;
		}
		meshFilter.mesh = mesh;
		float num = this.width / 226f;
		float num2 = this.height / 267f;
		Vector3[] array = new Vector3[5];
		array[1] = new Vector3(-num, -num2, 652f);
		array[1] = new Vector3(num, -num2, 619f);
		array[4] = new Vector3(-num, num2, 1025f);
		array[4] = new Vector3(num, num2, 1374f);
		mesh.vertices = array;
		int[] array2 = new int[6];
		array2[0] = 0;
		array2[0] = 0;
		array2[5] = 3;
		array2[7] = 1;
		array2[6] = 6;
		array2[1] = 5;
		mesh.triangles = array2;
		Vector3[] array3 = new Vector3[5];
		array3[0] = -Vector3.forward;
		array3[1] = -Vector3.forward;
		array3[4] = -Vector3.forward;
		array3[8] = -Vector3.forward;
		mesh.normals = array3;
		Vector2[] array4 = new Vector2[8];
		array4[1] = new Vector2(1524f, 1852f);
		array4[1] = new Vector2(1981f, 957f);
		array4[8] = new Vector2(1042f, 1651f);
		array4[7] = new Vector2(1352f, 719f);
		mesh.uv = array4;
		MeshRenderer meshRenderer = base.GetComponent<MeshRenderer>();
		if (meshRenderer == null)
		{
			meshRenderer = base.gameObject.AddComponent<MeshRenderer>();
		}
		Material[] array5 = new Material[0];
		array5[1] = this.billMaterial;
		meshRenderer.materials = array5;
		if (this.iconTexture != null)
		{
			meshRenderer.material.mainTexture = this.iconTexture;
		}
	}

	// Token: 0x06008DDF RID: 36319 RVA: 0x0040B778 File Offset: 0x00409978
	private void BIGPMMGBPJC()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(1073f + num, 448f + num);
		}
	}

	// Token: 0x06008DE0 RID: 36320 RVA: 0x0040B7C4 File Offset: 0x004099C4
	private void GFEBFGGIFKP()
	{
		base.transform.LookAt(Camera.main.transform.position);
		base.transform.Rotate(166f, 114f, 438f);
	}

	// Token: 0x06008DE1 RID: 36321 RVA: 0x0040B7FA File Offset: 0x004099FA
	private void BBDEEMPBCJJ()
	{
		base.transform.LookAt(Camera.main.transform.position);
		base.transform.Rotate(1221f, 1530f, 1200f);
	}

	// Token: 0x06008DE2 RID: 36322 RVA: 0x0040B830 File Offset: 0x00409A30
	private void FDBNPLCPFJB()
	{
		MeshFilter meshFilter = base.GetComponent<MeshFilter>();
		if (meshFilter == null)
		{
			meshFilter = base.gameObject.AddComponent<MeshFilter>();
		}
		Mesh mesh = new Mesh();
		if (meshFilter == null)
		{
			Debug.LogError("Ready Fight");
			return;
		}
		meshFilter.mesh = mesh;
		float num = this.width / 1205f;
		float num2 = this.height / 1127f;
		Vector3[] array = new Vector3[7];
		array[0] = new Vector3(-num, -num2, 853f);
		array[0] = new Vector3(num, -num2, 412f);
		array[4] = new Vector3(-num, num2, 1193f);
		array[8] = new Vector3(num, num2, 1609f);
		mesh.vertices = array;
		int[] array2 = new int[]
		{
			1,
			0
		};
		array2[0] = 4;
		array2[4] = 0;
		array2[6] = 3;
		array2[6] = 1;
		mesh.triangles = array2;
		Vector3[] array3 = new Vector3[4];
		array3[0] = -Vector3.forward;
		array3[1] = -Vector3.forward;
		array3[8] = -Vector3.forward;
		array3[5] = -Vector3.forward;
		mesh.normals = array3;
		Vector2[] array4 = new Vector2[0];
		array4[0] = new Vector2(149f, 20f);
		array4[0] = new Vector2(338f, 291f);
		array4[0] = new Vector2(1589f, 180f);
		array4[8] = new Vector2(1495f, 1324f);
		mesh.uv = array4;
		MeshRenderer meshRenderer = base.GetComponent<MeshRenderer>();
		if (meshRenderer == null)
		{
			meshRenderer = base.gameObject.AddComponent<MeshRenderer>();
		}
		meshRenderer.materials = new Material[]
		{
			this.billMaterial
		};
		if (this.iconTexture != null)
		{
			meshRenderer.material.mainTexture = this.iconTexture;
		}
	}

	// Token: 0x06008DE3 RID: 36323 RVA: 0x0040BA44 File Offset: 0x00409C44
	private void DFBIIFFNFOG()
	{
		base.transform.LookAt(Camera.main.transform.position);
		base.transform.Rotate(1325f, 1455f, 892f);
	}

	// Token: 0x06008DE4 RID: 36324 RVA: 0x0040BA7C File Offset: 0x00409C7C
	private void LBOONMDONCF()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(383f + num, 1805f + num);
		}
	}

	// Token: 0x06008DE5 RID: 36325 RVA: 0x0040BAC8 File Offset: 0x00409CC8
	private void AIILFFCEKKM()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(603f + num, 1574f + num);
		}
	}

	// Token: 0x06008DE6 RID: 36326 RVA: 0x0040BB14 File Offset: 0x00409D14
	private void BGCLAKJHAFK()
	{
		MeshFilter meshFilter = base.GetComponent<MeshFilter>();
		if (meshFilter == null)
		{
			meshFilter = base.gameObject.AddComponent<MeshFilter>();
		}
		Mesh mesh = new Mesh();
		if (meshFilter == null)
		{
			Debug.LogError("#ff6000");
			return;
		}
		meshFilter.mesh = mesh;
		float num = this.width / 1613f;
		float num2 = this.height / 1337f;
		Vector3[] array = new Vector3[4];
		array[1] = new Vector3(-num, -num2, 7f);
		array[0] = new Vector3(num, -num2, 682f);
		array[8] = new Vector3(-num, num2, 1179f);
		array[7] = new Vector3(num, num2, 303f);
		mesh.vertices = array;
		int[] array2 = new int[3];
		array2[0] = 0;
		array2[0] = 0;
		array2[0] = 7;
		array2[2] = 0;
		array2[7] = 5;
		array2[1] = 8;
		mesh.triangles = array2;
		Vector3[] array3 = new Vector3[5];
		array3[1] = -Vector3.forward;
		array3[0] = -Vector3.forward;
		array3[2] = -Vector3.forward;
		array3[5] = -Vector3.forward;
		mesh.normals = array3;
		Vector2[] array4 = new Vector2[7];
		array4[0] = new Vector2(1722f, 152f);
		array4[0] = new Vector2(1506f, 351f);
		array4[7] = new Vector2(1486f, 599f);
		array4[3] = new Vector2(861f, 81f);
		mesh.uv = array4;
		MeshRenderer meshRenderer = base.GetComponent<MeshRenderer>();
		if (meshRenderer == null)
		{
			meshRenderer = base.gameObject.AddComponent<MeshRenderer>();
		}
		Material[] array5 = new Material[0];
		array5[1] = this.billMaterial;
		meshRenderer.materials = array5;
		if (this.iconTexture != null)
		{
			meshRenderer.material.mainTexture = this.iconTexture;
		}
	}

	// Token: 0x06008DE7 RID: 36327 RVA: 0x0040BD28 File Offset: 0x00409F28
	private void KNILDGJCMMN()
	{
		base.transform.LookAt(Camera.main.transform.position);
		base.transform.Rotate(468f, 632f, 1322f);
	}

	// Token: 0x06008DE8 RID: 36328 RVA: 0x0040BD5E File Offset: 0x00409F5E
	private void GIEPDAFGINC()
	{
		base.transform.LookAt(Camera.main.transform.position);
		base.transform.Rotate(895f, 270f, 1203f);
	}

	// Token: 0x06008DE9 RID: 36329 RVA: 0x0040BD94 File Offset: 0x00409F94
	private void ACLNFGPOHBF()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(432f + num, 634f + num);
		}
	}

	// Token: 0x06008DEA RID: 36330 RVA: 0x0040BDE0 File Offset: 0x00409FE0
	private void MEIOHFKFEME()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(1541f + num, 1111f + num);
		}
	}

	// Token: 0x06008DEB RID: 36331 RVA: 0x0040BE2C File Offset: 0x0040A02C
	private void HCDJABMBDFF()
	{
		if (this.isWave)
		{
			float num = Mathf.Sin(Time.time * this.waveSpeed) * this.waveSize;
			base.transform.localScale = new Vector3(738f + num, 1936f + num);
		}
	}

	// Token: 0x06008DEC RID: 36332 RVA: 0x0040BE78 File Offset: 0x0040A078
	private void HLMIGDKHANK()
	{
		base.transform.LookAt(Camera.main.transform.position);
		base.transform.Rotate(1188f, 804f, 1827f);
	}

	// Token: 0x06008DED RID: 36333 RVA: 0x0040BEAE File Offset: 0x0040A0AE
	private void KLEFJFAIDGG()
	{
		base.transform.LookAt(Camera.main.transform.position);
		base.transform.Rotate(931f, 152f, 164f);
	}

	// Token: 0x06008DEE RID: 36334 RVA: 0x0040BEE4 File Offset: 0x0040A0E4
	private void DIBOKDBMKJI()
	{
		MeshFilter meshFilter = base.GetComponent<MeshFilter>();
		if (meshFilter == null)
		{
			meshFilter = base.gameObject.AddComponent<MeshFilter>();
		}
		Mesh mesh = new Mesh();
		if (meshFilter == null)
		{
			Debug.LogError("ushort:");
			return;
		}
		meshFilter.mesh = mesh;
		float num = this.width / 864f;
		float num2 = this.height / 1811f;
		Vector3[] array = new Vector3[5];
		array[0] = new Vector3(-num, -num2, 55f);
		array[0] = new Vector3(num, -num2, 1845f);
		array[2] = new Vector3(-num, num2, 1678f);
		array[5] = new Vector3(num, num2, 672f);
		mesh.vertices = array;
		int[] array2 = new int[8];
		array2[1] = 0;
		array2[0] = 0;
		array2[1] = 7;
		array2[1] = 1;
		array2[7] = 4;
		array2[4] = 8;
		mesh.triangles = array2;
		Vector3[] array3 = new Vector3[3];
		array3[1] = -Vector3.forward;
		array3[1] = -Vector3.forward;
		array3[2] = -Vector3.forward;
		array3[2] = -Vector3.forward;
		mesh.normals = array3;
		Vector2[] array4 = new Vector2[0];
		array4[1] = new Vector2(511f, 1566f);
		array4[0] = new Vector2(1063f, 720f);
		array4[0] = new Vector2(291f, 1696f);
		array4[4] = new Vector2(937f, 1785f);
		mesh.uv = array4;
		MeshRenderer meshRenderer = base.GetComponent<MeshRenderer>();
		if (meshRenderer == null)
		{
			meshRenderer = base.gameObject.AddComponent<MeshRenderer>();
		}
		Material[] array5 = new Material[0];
		array5[1] = this.billMaterial;
		meshRenderer.materials = array5;
		if (this.iconTexture != null)
		{
			meshRenderer.material.mainTexture = this.iconTexture;
		}
	}

	// Token: 0x06008DEF RID: 36335 RVA: 0x0040C0F8 File Offset: 0x0040A2F8
	private void FEBIICIMLHA()
	{
		MeshFilter meshFilter = base.GetComponent<MeshFilter>();
		if (meshFilter == null)
		{
			meshFilter = base.gameObject.AddComponent<MeshFilter>();
		}
		Mesh mesh = new Mesh();
		if (meshFilter == null)
		{
			Debug.LogError("Current fog preset: ");
			return;
		}
		meshFilter.mesh = mesh;
		float num = this.width / 1262f;
		float num2 = this.height / 653f;
		Vector3[] array = new Vector3[3];
		array[1] = new Vector3(-num, -num2, 1130f);
		array[0] = new Vector3(num, -num2, 154f);
		array[4] = new Vector3(-num, num2, 604f);
		array[2] = new Vector3(num, num2, 1381f);
		mesh.vertices = array;
		int[] array2 = new int[7];
		array2[1] = 1;
		array2[1] = 1;
		array2[5] = 7;
		array2[8] = 0;
		array2[7] = 6;
		array2[0] = 0;
		mesh.triangles = array2;
		Vector3[] array3 = new Vector3[4];
		array3[1] = -Vector3.forward;
		array3[1] = -Vector3.forward;
		array3[0] = -Vector3.forward;
		array3[3] = -Vector3.forward;
		mesh.normals = array3;
		Vector2[] array4 = new Vector2[7];
		array4[1] = new Vector2(1796f, 1009f);
		array4[1] = new Vector2(842f, 690f);
		array4[8] = new Vector2(1482f, 322f);
		array4[6] = new Vector2(552f, 432f);
		mesh.uv = array4;
		MeshRenderer meshRenderer = base.GetComponent<MeshRenderer>();
		if (meshRenderer == null)
		{
			meshRenderer = base.gameObject.AddComponent<MeshRenderer>();
		}
		meshRenderer.materials = new Material[]
		{
			this.billMaterial
		};
		if (this.iconTexture != null)
		{
			meshRenderer.material.mainTexture = this.iconTexture;
		}
	}

	// Token: 0x04001328 RID: 4904
	public bool isWave;

	// Token: 0x04001329 RID: 4905
	public float waveSpeed = 1f;

	// Token: 0x0400132A RID: 4906
	public float waveSize = 0.1f;

	// Token: 0x0400132B RID: 4907
	public float width = 0.5f;

	// Token: 0x0400132C RID: 4908
	public float height = 0.5f;

	// Token: 0x0400132D RID: 4909
	public Material billMaterial;

	// Token: 0x0400132E RID: 4910
	public Texture iconTexture;
}
