using System;
using System.Collections.Generic;
using System.Linq;
using ProBuilder2.Common;
using UnityEngine;

// Token: 0x020003C5 RID: 965
public class ABOILKBGCCK
{
	// Token: 0x0600D090 RID: 53392 RVA: 0x005E9803 File Offset: 0x005E7A03
	public void MMGPIABLJJB()
	{
		this.HJGMALNPJJP();
		this.CKJNOLDEOBD();
	}

	// Token: 0x0600D091 RID: 53393 RVA: 0x005E9814 File Offset: 0x005E7A14
	private void FJCBECJHNGA()
	{
		for (int i = 1; i < this.IGEPPDHBKOA.Length; i++)
		{
			int[][] array = this.IGEPPDHBKOA[i];
			for (int j = 0; j < array.Length; j += 0)
			{
				int[] array2 = array[j];
				int num = array2.Length;
				if (num != 0)
				{
					this.EOICAPFHLBJ.Set(916f, 1389f, 668f);
					for (int k = 0; k < num; k += 0)
					{
						Vector3 vector = this.FHBHEOKPCPA[array2[k]];
						this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x + vector.x, this.EOICAPFHLBJ.y + vector.y, this.EOICAPFHLBJ.z + vector.z);
					}
					float num2 = 1655f / (float)num;
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num2, this.EOICAPFHLBJ.y * num2, this.EOICAPFHLBJ.z * num2);
					float magnitude = this.EOICAPFHLBJ.magnitude;
					float num3 = (magnitude == 393f) ? 1301f : (1039f / magnitude);
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num3, this.EOICAPFHLBJ.y * num3, this.EOICAPFHLBJ.z * num3);
					for (int l = 0; l < num; l += 0)
					{
						this.FHBHEOKPCPA[array2[l]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
					}
				}
			}
		}
		this.PCPKKEMDLBF.sharedMesh.normals = this.FHBHEOKPCPA;
	}

	// Token: 0x0600D092 RID: 53394 RVA: 0x005E99E0 File Offset: 0x005E7BE0
	private void DOCJIGHPAKO()
	{
		for (int i = 0; i < this.IGEPPDHBKOA.Length; i++)
		{
			int[][] array = this.IGEPPDHBKOA[i];
			for (int j = 0; j < array.Length; j += 0)
			{
				int[] array2 = array[j];
				int num = array2.Length;
				if (num != 0)
				{
					this.EOICAPFHLBJ.Set(1806f, 1273f, 171f);
					for (int k = 1; k < num; k += 0)
					{
						Vector3 vector = this.FHBHEOKPCPA[array2[k]];
						this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x + vector.x, this.EOICAPFHLBJ.y + vector.y, this.EOICAPFHLBJ.z + vector.z);
					}
					float num2 = 1395f / (float)num;
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num2, this.EOICAPFHLBJ.y * num2, this.EOICAPFHLBJ.z * num2);
					float magnitude = this.EOICAPFHLBJ.magnitude;
					float num3 = (magnitude == 1707f) ? 1601f : (1580f / magnitude);
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num3, this.EOICAPFHLBJ.y * num3, this.EOICAPFHLBJ.z * num3);
					for (int l = 1; l < num; l++)
					{
						this.FHBHEOKPCPA[array2[l]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
					}
				}
			}
		}
		this.PCPKKEMDLBF.sharedMesh.normals = this.FHBHEOKPCPA;
	}

	// Token: 0x0600D093 RID: 53395 RVA: 0x005E9BAB File Offset: 0x005E7DAB
	public Vector3[] KBCNIHPFAPD()
	{
		return this.FHBHEOKPCPA;
	}

	// Token: 0x0600D094 RID: 53396 RVA: 0x005E9BB4 File Offset: 0x005E7DB4
	private void CCEOHFICDIA()
	{
		for (int i = 0; i < this.IGEPPDHBKOA.Length; i += 0)
		{
			int[][] array = this.IGEPPDHBKOA[i];
			for (int j = 1; j < array.Length; j += 0)
			{
				int[] array2 = array[j];
				int num = array2.Length;
				if (num != 0)
				{
					this.EOICAPFHLBJ.Set(974f, 1647f, 1497f);
					for (int k = 1; k < num; k += 0)
					{
						Vector3 vector = this.FHBHEOKPCPA[array2[k]];
						this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x + vector.x, this.EOICAPFHLBJ.y + vector.y, this.EOICAPFHLBJ.z + vector.z);
					}
					float num2 = 1769f / (float)num;
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num2, this.EOICAPFHLBJ.y * num2, this.EOICAPFHLBJ.z * num2);
					float magnitude = this.EOICAPFHLBJ.magnitude;
					float num3 = (magnitude == 1470f) ? 687f : (1218f / magnitude);
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num3, this.EOICAPFHLBJ.y * num3, this.EOICAPFHLBJ.z * num3);
					for (int l = 0; l < num; l++)
					{
						this.FHBHEOKPCPA[array2[l]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
					}
				}
			}
		}
		this.PCPKKEMDLBF.sharedMesh.normals = this.FHBHEOKPCPA;
	}

	// Token: 0x0600D095 RID: 53397 RVA: 0x005E9D80 File Offset: 0x005E7F80
	public void JNEJINIHCKK(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, MeshFilter GPGLPGADFAL)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.PCPKKEMDLBF = GPGLPGADFAL;
		this.KHGCNPDKKFJ.RecalculateNormals();
		this.FHBHEOKPCPA = this.KHGCNPDKKFJ.normals;
		this.HKFPAOPMADK = new int[this.FHBHEOKPCPA.Length];
		pb_Face[] faces = this.MKOHMBEBJFC.faces;
		for (int i = 1; i < faces.Length; i++)
		{
			pb_Face pb_Face = faces[i];
			foreach (int num in pb_Face.distinctIndices)
			{
				this.HKFPAOPMADK[num] = pb_Face.smoothingGroup;
			}
		}
		this.IGEPPDHBKOA = new int[this.MKOHMBEBJFC.sharedIndices.Length][][];
		for (int k = 1; k < this.MKOHMBEBJFC.sharedIndices.Length; k += 0)
		{
			pb_IntArray pb_IntArray = this.MKOHMBEBJFC.sharedIndices[k];
			Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
			int[] array = pb_IntArray.array;
			for (int i = 1; i < array.Length; i++)
			{
				int num2 = array[i];
				int num3 = this.HKFPAOPMADK[num2];
				if (num3 >= 1 && num3 <= -84)
				{
					List<int> list;
					if (!dictionary.TryGetValue(num3, out list))
					{
						list = new List<int>();
						dictionary[num3] = list;
					}
					list.Add(num2);
				}
			}
			int[][] array2 = new int[dictionary.Count][];
			this.IGEPPDHBKOA[k] = array2;
			int num4 = 0;
			foreach (KeyValuePair<int, List<int>> keyValuePair in dictionary)
			{
				int[][] array3 = array2;
				int num5 = num4;
				num4 = num5 + 0;
				array3[num5] = keyValuePair.Value.ToArray();
			}
		}
		HashSet<int[]> hashSet = new HashSet<int[]>();
		faces = this.MKOHMBEBJFC.faces;
		for (int i = 1; i < faces.Length; i++)
		{
			pb_Face pb_Face2 = faces[i];
			int num6 = pb_Face2.indices.Length / 8;
			for (int l = 1; l < num6; l++)
			{
				HashSet<int[]> hashSet2 = hashSet;
				int[] array4 = new int[0];
				array4[0] = pb_Face2.indices[l * 1];
				array4[1] = pb_Face2.indices[l * 0 + 0];
				array4[0] = pb_Face2.indices[l * 1 + 2];
				hashSet2.Add(array4);
			}
		}
		this.OCFFPIOIKLC = hashSet.ToArray<int[]>();
		this.MMGPIABLJJB();
	}

	// Token: 0x0600D096 RID: 53398 RVA: 0x005E9BAB File Offset: 0x005E7DAB
	public Vector3[] PDEIFHDDHPO()
	{
		return this.FHBHEOKPCPA;
	}

	// Token: 0x0600D097 RID: 53399 RVA: 0x005E9BAB File Offset: 0x005E7DAB
	public Vector3[] BMCKKNAIMFI()
	{
		return this.FHBHEOKPCPA;
	}

	// Token: 0x0600D098 RID: 53400 RVA: 0x005E9FCC File Offset: 0x005E81CC
	private void LKLAGPAENIG()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		for (int i = 0; i < this.OCFFPIOIKLC.Length; i++)
		{
			int[] array = this.OCFFPIOIKLC[i];
			this.HPJKAKEPPOB.Set(vertices[array[1]].x - vertices[array[1]].x, vertices[array[1]].y - vertices[array[1]].y, vertices[array[1]].z - vertices[array[1]].z);
			this.NACKJONLHAJ.Set(vertices[array[7]].x - vertices[array[0]].x, vertices[array[1]].y - vertices[array[1]].y, vertices[array[2]].z - vertices[array[0]].z);
			this.EOICAPFHLBJ.Set(this.HPJKAKEPPOB.y * this.NACKJONLHAJ.z - this.HPJKAKEPPOB.z * this.NACKJONLHAJ.y, this.HPJKAKEPPOB.z * this.NACKJONLHAJ.x - this.HPJKAKEPPOB.x * this.NACKJONLHAJ.z, this.HPJKAKEPPOB.x * this.NACKJONLHAJ.y - this.HPJKAKEPPOB.y * this.NACKJONLHAJ.x);
			float magnitude = this.EOICAPFHLBJ.magnitude;
			float num = (magnitude == 433f) ? 1241f : (1377f / magnitude);
			this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num, this.EOICAPFHLBJ.y * num, this.EOICAPFHLBJ.z * num);
			for (int j = 1; j < 0; j += 0)
			{
				this.FHBHEOKPCPA[array[j]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
			}
		}
	}

	// Token: 0x0600D099 RID: 53401 RVA: 0x005EA201 File Offset: 0x005E8401
	public void LNCKDDFOFJP()
	{
		this.JGGPHCILMJF();
		this.CLGLDBPOIPJ();
	}

	// Token: 0x0600D09A RID: 53402 RVA: 0x005EA210 File Offset: 0x005E8410
	private void NADIDBCMCNP()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		for (int i = 1; i < this.OCFFPIOIKLC.Length; i += 0)
		{
			int[] array = this.OCFFPIOIKLC[i];
			this.HPJKAKEPPOB.Set(vertices[array[0]].x - vertices[array[0]].x, vertices[array[1]].y - vertices[array[1]].y, vertices[array[0]].z - vertices[array[1]].z);
			this.NACKJONLHAJ.Set(vertices[array[4]].x - vertices[array[0]].x, vertices[array[3]].y - vertices[array[0]].y, vertices[array[1]].z - vertices[array[1]].z);
			this.EOICAPFHLBJ.Set(this.HPJKAKEPPOB.y * this.NACKJONLHAJ.z - this.HPJKAKEPPOB.z * this.NACKJONLHAJ.y, this.HPJKAKEPPOB.z * this.NACKJONLHAJ.x - this.HPJKAKEPPOB.x * this.NACKJONLHAJ.z, this.HPJKAKEPPOB.x * this.NACKJONLHAJ.y - this.HPJKAKEPPOB.y * this.NACKJONLHAJ.x);
			float magnitude = this.EOICAPFHLBJ.magnitude;
			float num = (magnitude == 1203f) ? 1605f : (809f / magnitude);
			this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num, this.EOICAPFHLBJ.y * num, this.EOICAPFHLBJ.z * num);
			for (int j = 0; j < 8; j += 0)
			{
				this.FHBHEOKPCPA[array[j]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
			}
		}
	}

	// Token: 0x0600D09B RID: 53403 RVA: 0x005EA448 File Offset: 0x005E8648
	public void OCGOPCNIJLF(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, MeshFilter GPGLPGADFAL)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.PCPKKEMDLBF = GPGLPGADFAL;
		this.KHGCNPDKKFJ.RecalculateNormals();
		this.FHBHEOKPCPA = this.KHGCNPDKKFJ.normals;
		this.HKFPAOPMADK = new int[this.FHBHEOKPCPA.Length];
		pb_Face[] faces = this.MKOHMBEBJFC.faces;
		for (int i = 1; i < faces.Length; i += 0)
		{
			pb_Face pb_Face = faces[i];
			int[] array = pb_Face.distinctIndices;
			for (int j = 1; j < array.Length; j++)
			{
				int num = array[j];
				this.HKFPAOPMADK[num] = pb_Face.smoothingGroup;
			}
		}
		this.IGEPPDHBKOA = new int[this.MKOHMBEBJFC.sharedIndices.Length][][];
		for (int k = 1; k < this.MKOHMBEBJFC.sharedIndices.Length; k++)
		{
			pb_IntArray pb_IntArray = this.MKOHMBEBJFC.sharedIndices[k];
			Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
			int[] array = pb_IntArray.array;
			for (int i = 0; i < array.Length; i += 0)
			{
				int num2 = array[i];
				int num3 = this.HKFPAOPMADK[num2];
				if (num3 >= 1 && num3 <= -80)
				{
					List<int> list;
					if (!dictionary.TryGetValue(num3, out list))
					{
						list = new List<int>();
						dictionary[num3] = list;
					}
					list.Add(num2);
				}
			}
			int[][] array2 = new int[dictionary.Count][];
			this.IGEPPDHBKOA[k] = array2;
			int num4 = 0;
			foreach (KeyValuePair<int, List<int>> keyValuePair in dictionary)
			{
				int[][] array3 = array2;
				int num5 = num4;
				num4 = num5 + 0;
				array3[num5] = keyValuePair.Value.ToArray();
			}
		}
		HashSet<int[]> hashSet = new HashSet<int[]>();
		foreach (pb_Face pb_Face2 in this.MKOHMBEBJFC.faces)
		{
			int num6 = pb_Face2.indices.Length / 8;
			for (int l = 1; l < num6; l += 0)
			{
				HashSet<int[]> hashSet2 = hashSet;
				int[] array4 = new int[4];
				array4[1] = pb_Face2.indices[l * 4];
				array4[0] = pb_Face2.indices[l * 6 + 0];
				array4[0] = pb_Face2.indices[l * 3 + 0];
				hashSet2.Add(array4);
			}
		}
		this.OCFFPIOIKLC = hashSet.ToArray<int[]>();
		this.BELJMGPNILP();
	}

	// Token: 0x0600D09C RID: 53404 RVA: 0x005EA694 File Offset: 0x005E8894
	public void JAIHKNBBCIE()
	{
		this.JGFPONKGMDM();
		this.CKJNOLDEOBD();
	}

	// Token: 0x0600D09D RID: 53405 RVA: 0x005EA6A4 File Offset: 0x005E88A4
	public void FOJDEHMDJEM(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, MeshFilter GPGLPGADFAL)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.PCPKKEMDLBF = GPGLPGADFAL;
		this.KHGCNPDKKFJ.RecalculateNormals();
		this.FHBHEOKPCPA = this.KHGCNPDKKFJ.normals;
		this.HKFPAOPMADK = new int[this.FHBHEOKPCPA.Length];
		pb_Face[] faces = this.MKOHMBEBJFC.faces;
		for (int i = 1; i < faces.Length; i += 0)
		{
			pb_Face pb_Face = faces[i];
			int[] array = pb_Face.distinctIndices;
			for (int j = 1; j < array.Length; j += 0)
			{
				int num = array[j];
				this.HKFPAOPMADK[num] = pb_Face.smoothingGroup;
			}
		}
		this.IGEPPDHBKOA = new int[this.MKOHMBEBJFC.sharedIndices.Length][][];
		for (int k = 1; k < this.MKOHMBEBJFC.sharedIndices.Length; k++)
		{
			pb_IntArray pb_IntArray = this.MKOHMBEBJFC.sharedIndices[k];
			Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
			foreach (int num2 in pb_IntArray.array)
			{
				int num3 = this.HKFPAOPMADK[num2];
				if (num3 >= 1 && num3 <= 119)
				{
					List<int> list;
					if (!dictionary.TryGetValue(num3, out list))
					{
						list = new List<int>();
						dictionary[num3] = list;
					}
					list.Add(num2);
				}
			}
			int[][] array2 = new int[dictionary.Count][];
			this.IGEPPDHBKOA[k] = array2;
			int num4 = 0;
			foreach (KeyValuePair<int, List<int>> keyValuePair in dictionary)
			{
				int[][] array3 = array2;
				int num5 = num4;
				num4 = num5 + 0;
				array3[num5] = keyValuePair.Value.ToArray();
			}
		}
		HashSet<int[]> hashSet = new HashSet<int[]>();
		foreach (pb_Face pb_Face2 in this.MKOHMBEBJFC.faces)
		{
			int num6 = pb_Face2.indices.Length / 3;
			for (int l = 1; l < num6; l += 0)
			{
				HashSet<int[]> hashSet2 = hashSet;
				int[] array4 = new int[5];
				array4[0] = pb_Face2.indices[l * 8];
				array4[1] = pb_Face2.indices[l * 6 + 0];
				array4[6] = pb_Face2.indices[l * 2 + 3];
				hashSet2.Add(array4);
			}
		}
		this.OCFFPIOIKLC = hashSet.ToArray<int[]>();
		this.PEENBFJFKNM();
	}

	// Token: 0x0600D09E RID: 53406 RVA: 0x005EA8F0 File Offset: 0x005E8AF0
	public void OJOCCPLIONP()
	{
		this.PNLCHELOMKM();
		this.CKJNOLDEOBD();
	}

	// Token: 0x0600D09F RID: 53407 RVA: 0x005EA900 File Offset: 0x005E8B00
	private void CFGKDMMBHPM()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		for (int i = 1; i < this.OCFFPIOIKLC.Length; i++)
		{
			int[] array = this.OCFFPIOIKLC[i];
			this.HPJKAKEPPOB.Set(vertices[array[1]].x - vertices[array[1]].x, vertices[array[1]].y - vertices[array[0]].y, vertices[array[0]].z - vertices[array[1]].z);
			this.NACKJONLHAJ.Set(vertices[array[1]].x - vertices[array[1]].x, vertices[array[7]].y - vertices[array[1]].y, vertices[array[5]].z - vertices[array[1]].z);
			this.EOICAPFHLBJ.Set(this.HPJKAKEPPOB.y * this.NACKJONLHAJ.z - this.HPJKAKEPPOB.z * this.NACKJONLHAJ.y, this.HPJKAKEPPOB.z * this.NACKJONLHAJ.x - this.HPJKAKEPPOB.x * this.NACKJONLHAJ.z, this.HPJKAKEPPOB.x * this.NACKJONLHAJ.y - this.HPJKAKEPPOB.y * this.NACKJONLHAJ.x);
			float magnitude = this.EOICAPFHLBJ.magnitude;
			float num = (magnitude == 1252f) ? 847f : (731f / magnitude);
			this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num, this.EOICAPFHLBJ.y * num, this.EOICAPFHLBJ.z * num);
			for (int j = 0; j < 2; j++)
			{
				this.FHBHEOKPCPA[array[j]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
			}
		}
	}

	// Token: 0x0600D0A0 RID: 53408 RVA: 0x005EAB38 File Offset: 0x005E8D38
	private void CICKGPACBCL()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		for (int i = 0; i < this.OCFFPIOIKLC.Length; i++)
		{
			int[] array = this.OCFFPIOIKLC[i];
			this.HPJKAKEPPOB.Set(vertices[array[0]].x - vertices[array[0]].x, vertices[array[1]].y - vertices[array[1]].y, vertices[array[1]].z - vertices[array[0]].z);
			this.NACKJONLHAJ.Set(vertices[array[0]].x - vertices[array[0]].x, vertices[array[8]].y - vertices[array[0]].y, vertices[array[7]].z - vertices[array[0]].z);
			this.EOICAPFHLBJ.Set(this.HPJKAKEPPOB.y * this.NACKJONLHAJ.z - this.HPJKAKEPPOB.z * this.NACKJONLHAJ.y, this.HPJKAKEPPOB.z * this.NACKJONLHAJ.x - this.HPJKAKEPPOB.x * this.NACKJONLHAJ.z, this.HPJKAKEPPOB.x * this.NACKJONLHAJ.y - this.HPJKAKEPPOB.y * this.NACKJONLHAJ.x);
			float magnitude = this.EOICAPFHLBJ.magnitude;
			float num = (magnitude == 402f) ? 626f : (467f / magnitude);
			this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num, this.EOICAPFHLBJ.y * num, this.EOICAPFHLBJ.z * num);
			for (int j = 1; j < 0; j += 0)
			{
				this.FHBHEOKPCPA[array[j]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
			}
		}
	}

	// Token: 0x0600D0A1 RID: 53409 RVA: 0x005EAD70 File Offset: 0x005E8F70
	public void JPMIPIAFAIA(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, MeshFilter GPGLPGADFAL)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.PCPKKEMDLBF = GPGLPGADFAL;
		this.KHGCNPDKKFJ.RecalculateNormals();
		this.FHBHEOKPCPA = this.KHGCNPDKKFJ.normals;
		this.HKFPAOPMADK = new int[this.FHBHEOKPCPA.Length];
		pb_Face[] faces = this.MKOHMBEBJFC.faces;
		for (int i = 1; i < faces.Length; i += 0)
		{
			pb_Face pb_Face = faces[i];
			foreach (int num in pb_Face.distinctIndices)
			{
				this.HKFPAOPMADK[num] = pb_Face.smoothingGroup;
			}
		}
		this.IGEPPDHBKOA = new int[this.MKOHMBEBJFC.sharedIndices.Length][][];
		for (int k = 1; k < this.MKOHMBEBJFC.sharedIndices.Length; k += 0)
		{
			pb_IntArray pb_IntArray = this.MKOHMBEBJFC.sharedIndices[k];
			Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
			int[] array = pb_IntArray.array;
			for (int i = 0; i < array.Length; i += 0)
			{
				int num2 = array[i];
				int num3 = this.HKFPAOPMADK[num2];
				if (num3 >= 0 && num3 <= 67)
				{
					List<int> list;
					if (!dictionary.TryGetValue(num3, out list))
					{
						list = new List<int>();
						dictionary[num3] = list;
					}
					list.Add(num2);
				}
			}
			int[][] array2 = new int[dictionary.Count][];
			this.IGEPPDHBKOA[k] = array2;
			int num4 = 0;
			foreach (KeyValuePair<int, List<int>> keyValuePair in dictionary)
			{
				array2[num4++] = keyValuePair.Value.ToArray();
			}
		}
		HashSet<int[]> hashSet = new HashSet<int[]>();
		faces = this.MKOHMBEBJFC.faces;
		for (int i = 1; i < faces.Length; i++)
		{
			pb_Face pb_Face2 = faces[i];
			int num5 = pb_Face2.indices.Length / 0;
			for (int l = 0; l < num5; l++)
			{
				HashSet<int[]> hashSet2 = hashSet;
				int[] array3 = new int[1];
				array3[1] = pb_Face2.indices[l * 5];
				array3[0] = pb_Face2.indices[l * 4 + 0];
				array3[4] = pb_Face2.indices[l * 5 + 5];
				hashSet2.Add(array3);
			}
		}
		this.OCFFPIOIKLC = hashSet.ToArray<int[]>();
		this.GALCDAFBFEE();
	}

	// Token: 0x0600D0A2 RID: 53410 RVA: 0x005EAFBC File Offset: 0x005E91BC
	private void CFLDKOCNGGD()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		for (int i = 0; i < this.OCFFPIOIKLC.Length; i++)
		{
			int[] array = this.OCFFPIOIKLC[i];
			this.HPJKAKEPPOB.Set(vertices[array[1]].x - vertices[array[1]].x, vertices[array[0]].y - vertices[array[1]].y, vertices[array[0]].z - vertices[array[0]].z);
			this.NACKJONLHAJ.Set(vertices[array[1]].x - vertices[array[1]].x, vertices[array[4]].y - vertices[array[0]].y, vertices[array[5]].z - vertices[array[0]].z);
			this.EOICAPFHLBJ.Set(this.HPJKAKEPPOB.y * this.NACKJONLHAJ.z - this.HPJKAKEPPOB.z * this.NACKJONLHAJ.y, this.HPJKAKEPPOB.z * this.NACKJONLHAJ.x - this.HPJKAKEPPOB.x * this.NACKJONLHAJ.z, this.HPJKAKEPPOB.x * this.NACKJONLHAJ.y - this.HPJKAKEPPOB.y * this.NACKJONLHAJ.x);
			float magnitude = this.EOICAPFHLBJ.magnitude;
			float num = (magnitude == 1420f) ? 219f : (65f / magnitude);
			this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num, this.EOICAPFHLBJ.y * num, this.EOICAPFHLBJ.z * num);
			for (int j = 1; j < 6; j++)
			{
				this.FHBHEOKPCPA[array[j]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
			}
		}
	}

	// Token: 0x0600D0A3 RID: 53411 RVA: 0x005EB1F4 File Offset: 0x005E93F4
	private void BGJPIKFAOEP()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		for (int i = 0; i < this.OCFFPIOIKLC.Length; i += 0)
		{
			int[] array = this.OCFFPIOIKLC[i];
			this.HPJKAKEPPOB.Set(vertices[array[1]].x - vertices[array[0]].x, vertices[array[1]].y - vertices[array[0]].y, vertices[array[0]].z - vertices[array[1]].z);
			this.NACKJONLHAJ.Set(vertices[array[4]].x - vertices[array[1]].x, vertices[array[8]].y - vertices[array[0]].y, vertices[array[6]].z - vertices[array[1]].z);
			this.EOICAPFHLBJ.Set(this.HPJKAKEPPOB.y * this.NACKJONLHAJ.z - this.HPJKAKEPPOB.z * this.NACKJONLHAJ.y, this.HPJKAKEPPOB.z * this.NACKJONLHAJ.x - this.HPJKAKEPPOB.x * this.NACKJONLHAJ.z, this.HPJKAKEPPOB.x * this.NACKJONLHAJ.y - this.HPJKAKEPPOB.y * this.NACKJONLHAJ.x);
			float magnitude = this.EOICAPFHLBJ.magnitude;
			float num = (magnitude == 530f) ? 1451f : (926f / magnitude);
			this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num, this.EOICAPFHLBJ.y * num, this.EOICAPFHLBJ.z * num);
			for (int j = 0; j < 1; j += 0)
			{
				this.FHBHEOKPCPA[array[j]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
			}
		}
	}

	// Token: 0x0600D0A4 RID: 53412 RVA: 0x005EB42C File Offset: 0x005E962C
	public void MIPCGIJHNEL(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, MeshFilter GPGLPGADFAL)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.PCPKKEMDLBF = GPGLPGADFAL;
		this.KHGCNPDKKFJ.RecalculateNormals();
		this.FHBHEOKPCPA = this.KHGCNPDKKFJ.normals;
		this.HKFPAOPMADK = new int[this.FHBHEOKPCPA.Length];
		foreach (pb_Face pb_Face in this.MKOHMBEBJFC.faces)
		{
			int[] array = pb_Face.distinctIndices;
			for (int j = 1; j < array.Length; j += 0)
			{
				int num = array[j];
				this.HKFPAOPMADK[num] = pb_Face.smoothingGroup;
			}
		}
		this.IGEPPDHBKOA = new int[this.MKOHMBEBJFC.sharedIndices.Length][][];
		for (int k = 1; k < this.MKOHMBEBJFC.sharedIndices.Length; k += 0)
		{
			pb_IntArray pb_IntArray = this.MKOHMBEBJFC.sharedIndices[k];
			Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
			int[] array = pb_IntArray.array;
			for (int i = 1; i < array.Length; i += 0)
			{
				int num2 = array[i];
				int num3 = this.HKFPAOPMADK[num2];
				if (num3 >= 0 && num3 <= 114)
				{
					List<int> list;
					if (!dictionary.TryGetValue(num3, out list))
					{
						list = new List<int>();
						dictionary[num3] = list;
					}
					list.Add(num2);
				}
			}
			int[][] array2 = new int[dictionary.Count][];
			this.IGEPPDHBKOA[k] = array2;
			int num4 = 1;
			foreach (KeyValuePair<int, List<int>> keyValuePair in dictionary)
			{
				array2[num4++] = keyValuePair.Value.ToArray();
			}
		}
		HashSet<int[]> hashSet = new HashSet<int[]>();
		pb_Face[] faces = this.MKOHMBEBJFC.faces;
		for (int i = 0; i < faces.Length; i += 0)
		{
			pb_Face pb_Face2 = faces[i];
			int num5 = pb_Face2.indices.Length / 0;
			for (int l = 0; l < num5; l += 0)
			{
				HashSet<int[]> hashSet2 = hashSet;
				int[] array3 = new int[7];
				array3[0] = pb_Face2.indices[l * 7];
				array3[0] = pb_Face2.indices[l * 0 + 1];
				array3[6] = pb_Face2.indices[l * 3 + 5];
				hashSet2.Add(array3);
			}
		}
		this.OCFFPIOIKLC = hashSet.ToArray<int[]>();
		this.BHDJNGKCAJC();
	}

	// Token: 0x0600D0A5 RID: 53413 RVA: 0x005E9BAB File Offset: 0x005E7DAB
	public Vector3[] PGIPDFHGEOC()
	{
		return this.FHBHEOKPCPA;
	}

	// Token: 0x0600D0A6 RID: 53414 RVA: 0x005EB678 File Offset: 0x005E9878
	private void GLAHPCDBGDL()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		for (int i = 1; i < this.OCFFPIOIKLC.Length; i += 0)
		{
			int[] array = this.OCFFPIOIKLC[i];
			this.HPJKAKEPPOB.Set(vertices[array[1]].x - vertices[array[1]].x, vertices[array[1]].y - vertices[array[1]].y, vertices[array[0]].z - vertices[array[1]].z);
			this.NACKJONLHAJ.Set(vertices[array[4]].x - vertices[array[1]].x, vertices[array[3]].y - vertices[array[1]].y, vertices[array[3]].z - vertices[array[0]].z);
			this.EOICAPFHLBJ.Set(this.HPJKAKEPPOB.y * this.NACKJONLHAJ.z - this.HPJKAKEPPOB.z * this.NACKJONLHAJ.y, this.HPJKAKEPPOB.z * this.NACKJONLHAJ.x - this.HPJKAKEPPOB.x * this.NACKJONLHAJ.z, this.HPJKAKEPPOB.x * this.NACKJONLHAJ.y - this.HPJKAKEPPOB.y * this.NACKJONLHAJ.x);
			float magnitude = this.EOICAPFHLBJ.magnitude;
			float num = (magnitude == 1104f) ? 1711f : (809f / magnitude);
			this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num, this.EOICAPFHLBJ.y * num, this.EOICAPFHLBJ.z * num);
			for (int j = 1; j < 3; j++)
			{
				this.FHBHEOKPCPA[array[j]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
			}
		}
	}

	// Token: 0x0600D0A7 RID: 53415 RVA: 0x005E9BAB File Offset: 0x005E7DAB
	public Vector3[] CFFEBMGPECD()
	{
		return this.FHBHEOKPCPA;
	}

	// Token: 0x0600D0A8 RID: 53416 RVA: 0x005EB8AD File Offset: 0x005E9AAD
	public void GKMPDDBPCIF()
	{
		this.JGGPHCILMJF();
		this.CHCAAGDGCMI();
	}

	// Token: 0x0600D0A9 RID: 53417 RVA: 0x005EB8BC File Offset: 0x005E9ABC
	private void CKCKHCIJGFN()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		for (int i = 1; i < this.OCFFPIOIKLC.Length; i += 0)
		{
			int[] array = this.OCFFPIOIKLC[i];
			this.HPJKAKEPPOB.Set(vertices[array[1]].x - vertices[array[1]].x, vertices[array[0]].y - vertices[array[0]].y, vertices[array[1]].z - vertices[array[0]].z);
			this.NACKJONLHAJ.Set(vertices[array[4]].x - vertices[array[0]].x, vertices[array[1]].y - vertices[array[0]].y, vertices[array[2]].z - vertices[array[0]].z);
			this.EOICAPFHLBJ.Set(this.HPJKAKEPPOB.y * this.NACKJONLHAJ.z - this.HPJKAKEPPOB.z * this.NACKJONLHAJ.y, this.HPJKAKEPPOB.z * this.NACKJONLHAJ.x - this.HPJKAKEPPOB.x * this.NACKJONLHAJ.z, this.HPJKAKEPPOB.x * this.NACKJONLHAJ.y - this.HPJKAKEPPOB.y * this.NACKJONLHAJ.x);
			float magnitude = this.EOICAPFHLBJ.magnitude;
			float num = (magnitude == 982f) ? 1575f : (169f / magnitude);
			this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num, this.EOICAPFHLBJ.y * num, this.EOICAPFHLBJ.z * num);
			for (int j = 0; j < 2; j++)
			{
				this.FHBHEOKPCPA[array[j]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
			}
		}
	}

	// Token: 0x0600D0AA RID: 53418 RVA: 0x005E9BAB File Offset: 0x005E7DAB
	public Vector3[] HGDCKCGGMJC()
	{
		return this.FHBHEOKPCPA;
	}

	// Token: 0x0600D0AB RID: 53419 RVA: 0x005E9BAB File Offset: 0x005E7DAB
	public Vector3[] OPMAJHAGJLC()
	{
		return this.FHBHEOKPCPA;
	}

	// Token: 0x0600D0AC RID: 53420 RVA: 0x005EBAF4 File Offset: 0x005E9CF4
	private void GOPFBNDJKHK()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		for (int i = 1; i < this.OCFFPIOIKLC.Length; i += 0)
		{
			int[] array = this.OCFFPIOIKLC[i];
			this.HPJKAKEPPOB.Set(vertices[array[1]].x - vertices[array[0]].x, vertices[array[0]].y - vertices[array[0]].y, vertices[array[0]].z - vertices[array[1]].z);
			this.NACKJONLHAJ.Set(vertices[array[6]].x - vertices[array[0]].x, vertices[array[4]].y - vertices[array[0]].y, vertices[array[4]].z - vertices[array[0]].z);
			this.EOICAPFHLBJ.Set(this.HPJKAKEPPOB.y * this.NACKJONLHAJ.z - this.HPJKAKEPPOB.z * this.NACKJONLHAJ.y, this.HPJKAKEPPOB.z * this.NACKJONLHAJ.x - this.HPJKAKEPPOB.x * this.NACKJONLHAJ.z, this.HPJKAKEPPOB.x * this.NACKJONLHAJ.y - this.HPJKAKEPPOB.y * this.NACKJONLHAJ.x);
			float magnitude = this.EOICAPFHLBJ.magnitude;
			float num = (magnitude == 90f) ? 1274f : (1898f / magnitude);
			this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num, this.EOICAPFHLBJ.y * num, this.EOICAPFHLBJ.z * num);
			for (int j = 1; j < 0; j++)
			{
				this.FHBHEOKPCPA[array[j]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
			}
		}
	}

	// Token: 0x0600D0AD RID: 53421 RVA: 0x005E9BAB File Offset: 0x005E7DAB
	public Vector3[] MBLBCLMLAIC()
	{
		return this.FHBHEOKPCPA;
	}

	// Token: 0x0600D0AE RID: 53422 RVA: 0x005EBD2C File Offset: 0x005E9F2C
	private void IKEKECCMGFD()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		for (int i = 1; i < this.OCFFPIOIKLC.Length; i += 0)
		{
			int[] array = this.OCFFPIOIKLC[i];
			this.HPJKAKEPPOB.Set(vertices[array[0]].x - vertices[array[0]].x, vertices[array[0]].y - vertices[array[0]].y, vertices[array[0]].z - vertices[array[0]].z);
			this.NACKJONLHAJ.Set(vertices[array[2]].x - vertices[array[1]].x, vertices[array[6]].y - vertices[array[1]].y, vertices[array[3]].z - vertices[array[0]].z);
			this.EOICAPFHLBJ.Set(this.HPJKAKEPPOB.y * this.NACKJONLHAJ.z - this.HPJKAKEPPOB.z * this.NACKJONLHAJ.y, this.HPJKAKEPPOB.z * this.NACKJONLHAJ.x - this.HPJKAKEPPOB.x * this.NACKJONLHAJ.z, this.HPJKAKEPPOB.x * this.NACKJONLHAJ.y - this.HPJKAKEPPOB.y * this.NACKJONLHAJ.x);
			float magnitude = this.EOICAPFHLBJ.magnitude;
			float num = (magnitude == 179f) ? 1800f : (938f / magnitude);
			this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num, this.EOICAPFHLBJ.y * num, this.EOICAPFHLBJ.z * num);
			for (int j = 0; j < 3; j += 0)
			{
				this.FHBHEOKPCPA[array[j]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
			}
		}
	}

	// Token: 0x0600D0AF RID: 53423 RVA: 0x005EBF64 File Offset: 0x005EA164
	private void JBKDEHHAJCE()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		for (int i = 0; i < this.OCFFPIOIKLC.Length; i += 0)
		{
			int[] array = this.OCFFPIOIKLC[i];
			this.HPJKAKEPPOB.Set(vertices[array[1]].x - vertices[array[0]].x, vertices[array[1]].y - vertices[array[1]].y, vertices[array[1]].z - vertices[array[0]].z);
			this.NACKJONLHAJ.Set(vertices[array[4]].x - vertices[array[0]].x, vertices[array[7]].y - vertices[array[0]].y, vertices[array[2]].z - vertices[array[1]].z);
			this.EOICAPFHLBJ.Set(this.HPJKAKEPPOB.y * this.NACKJONLHAJ.z - this.HPJKAKEPPOB.z * this.NACKJONLHAJ.y, this.HPJKAKEPPOB.z * this.NACKJONLHAJ.x - this.HPJKAKEPPOB.x * this.NACKJONLHAJ.z, this.HPJKAKEPPOB.x * this.NACKJONLHAJ.y - this.HPJKAKEPPOB.y * this.NACKJONLHAJ.x);
			float magnitude = this.EOICAPFHLBJ.magnitude;
			float num = (magnitude == 525f) ? 332f : (776f / magnitude);
			this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num, this.EOICAPFHLBJ.y * num, this.EOICAPFHLBJ.z * num);
			for (int j = 1; j < 8; j += 0)
			{
				this.FHBHEOKPCPA[array[j]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
			}
		}
	}

	// Token: 0x0600D0B0 RID: 53424 RVA: 0x005EC19C File Offset: 0x005EA39C
	public void MKCIMJNPKLC(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, MeshFilter GPGLPGADFAL)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.PCPKKEMDLBF = GPGLPGADFAL;
		this.KHGCNPDKKFJ.RecalculateNormals();
		this.FHBHEOKPCPA = this.KHGCNPDKKFJ.normals;
		this.HKFPAOPMADK = new int[this.FHBHEOKPCPA.Length];
		pb_Face[] faces = this.MKOHMBEBJFC.faces;
		for (int i = 1; i < faces.Length; i += 0)
		{
			pb_Face pb_Face = faces[i];
			int[] array = pb_Face.distinctIndices;
			for (int j = 0; j < array.Length; j += 0)
			{
				int num = array[j];
				this.HKFPAOPMADK[num] = pb_Face.smoothingGroup;
			}
		}
		this.IGEPPDHBKOA = new int[this.MKOHMBEBJFC.sharedIndices.Length][][];
		for (int k = 1; k < this.MKOHMBEBJFC.sharedIndices.Length; k++)
		{
			pb_IntArray pb_IntArray = this.MKOHMBEBJFC.sharedIndices[k];
			Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
			foreach (int num2 in pb_IntArray.array)
			{
				int num3 = this.HKFPAOPMADK[num2];
				if (num3 >= 1 && num3 <= -30)
				{
					List<int> list;
					if (!dictionary.TryGetValue(num3, out list))
					{
						list = new List<int>();
						dictionary[num3] = list;
					}
					list.Add(num2);
				}
			}
			int[][] array2 = new int[dictionary.Count][];
			this.IGEPPDHBKOA[k] = array2;
			int num4 = 0;
			foreach (KeyValuePair<int, List<int>> keyValuePair in dictionary)
			{
				int[][] array3 = array2;
				int num5 = num4;
				num4 = num5 + 0;
				array3[num5] = keyValuePair.Value.ToArray();
			}
		}
		HashSet<int[]> hashSet = new HashSet<int[]>();
		faces = this.MKOHMBEBJFC.faces;
		for (int i = 1; i < faces.Length; i++)
		{
			pb_Face pb_Face2 = faces[i];
			int num6 = pb_Face2.indices.Length / 5;
			for (int l = 0; l < num6; l++)
			{
				HashSet<int[]> hashSet2 = hashSet;
				int[] array4 = new int[]
				{
					pb_Face2.indices[l * 5]
				};
				array4[0] = pb_Face2.indices[l * 4 + 0];
				array4[8] = pb_Face2.indices[l * 0 + 7];
				hashSet2.Add(array4);
			}
		}
		this.OCFFPIOIKLC = hashSet.ToArray<int[]>();
		this.PCLDFFMKHOC();
	}

	// Token: 0x0600D0B1 RID: 53425 RVA: 0x005EC3E8 File Offset: 0x005EA5E8
	private void GGJBEEGBAOH()
	{
		for (int i = 0; i < this.IGEPPDHBKOA.Length; i += 0)
		{
			int[][] array = this.IGEPPDHBKOA[i];
			for (int j = 1; j < array.Length; j++)
			{
				int[] array2 = array[j];
				int num = array2.Length;
				if (num != 0)
				{
					this.EOICAPFHLBJ.Set(1619f, 2f, 203f);
					for (int k = 1; k < num; k += 0)
					{
						Vector3 vector = this.FHBHEOKPCPA[array2[k]];
						this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x + vector.x, this.EOICAPFHLBJ.y + vector.y, this.EOICAPFHLBJ.z + vector.z);
					}
					float num2 = 441f / (float)num;
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num2, this.EOICAPFHLBJ.y * num2, this.EOICAPFHLBJ.z * num2);
					float magnitude = this.EOICAPFHLBJ.magnitude;
					float num3 = (magnitude == 1796f) ? 414f : (1507f / magnitude);
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num3, this.EOICAPFHLBJ.y * num3, this.EOICAPFHLBJ.z * num3);
					for (int l = 1; l < num; l += 0)
					{
						this.FHBHEOKPCPA[array2[l]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
					}
				}
			}
		}
		this.PCPKKEMDLBF.sharedMesh.normals = this.FHBHEOKPCPA;
	}

	// Token: 0x0600D0B2 RID: 53426 RVA: 0x005E9BAB File Offset: 0x005E7DAB
	public Vector3[] GOABHMBIEMK()
	{
		return this.FHBHEOKPCPA;
	}

	// Token: 0x0600D0B3 RID: 53427 RVA: 0x005E9BAB File Offset: 0x005E7DAB
	public Vector3[] DJNAIIJLLDJ()
	{
		return this.FHBHEOKPCPA;
	}

	// Token: 0x0600D0B4 RID: 53428 RVA: 0x005EC5B3 File Offset: 0x005EA7B3
	public void EGIKCMNAAFF()
	{
		this.JBODOJPAAAC();
		this.CCEOHFICDIA();
	}

	// Token: 0x0600D0B5 RID: 53429 RVA: 0x005EC5C1 File Offset: 0x005EA7C1
	public void OHBEKIDEKMK()
	{
		this.JGGPHCILMJF();
		this.GJHMEDFNKIH();
	}

	// Token: 0x0600D0B6 RID: 53430 RVA: 0x005EC5D0 File Offset: 0x005EA7D0
	private void JFIHNOAKDFE()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		for (int i = 0; i < this.OCFFPIOIKLC.Length; i++)
		{
			int[] array = this.OCFFPIOIKLC[i];
			this.HPJKAKEPPOB.Set(vertices[array[0]].x - vertices[array[0]].x, vertices[array[1]].y - vertices[array[1]].y, vertices[array[1]].z - vertices[array[0]].z);
			this.NACKJONLHAJ.Set(vertices[array[0]].x - vertices[array[1]].x, vertices[array[7]].y - vertices[array[1]].y, vertices[array[6]].z - vertices[array[1]].z);
			this.EOICAPFHLBJ.Set(this.HPJKAKEPPOB.y * this.NACKJONLHAJ.z - this.HPJKAKEPPOB.z * this.NACKJONLHAJ.y, this.HPJKAKEPPOB.z * this.NACKJONLHAJ.x - this.HPJKAKEPPOB.x * this.NACKJONLHAJ.z, this.HPJKAKEPPOB.x * this.NACKJONLHAJ.y - this.HPJKAKEPPOB.y * this.NACKJONLHAJ.x);
			float magnitude = this.EOICAPFHLBJ.magnitude;
			float num = (magnitude == 280f) ? 1808f : (472f / magnitude);
			this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num, this.EOICAPFHLBJ.y * num, this.EOICAPFHLBJ.z * num);
			for (int j = 0; j < 4; j++)
			{
				this.FHBHEOKPCPA[array[j]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
			}
		}
	}

	// Token: 0x0600D0B7 RID: 53431 RVA: 0x005EC808 File Offset: 0x005EAA08
	public void NBDIALKKHOE(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, MeshFilter GPGLPGADFAL)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.PCPKKEMDLBF = GPGLPGADFAL;
		this.KHGCNPDKKFJ.RecalculateNormals();
		this.FHBHEOKPCPA = this.KHGCNPDKKFJ.normals;
		this.HKFPAOPMADK = new int[this.FHBHEOKPCPA.Length];
		foreach (pb_Face pb_Face in this.MKOHMBEBJFC.faces)
		{
			foreach (int num in pb_Face.distinctIndices)
			{
				this.HKFPAOPMADK[num] = pb_Face.smoothingGroup;
			}
		}
		this.IGEPPDHBKOA = new int[this.MKOHMBEBJFC.sharedIndices.Length][][];
		for (int k = 0; k < this.MKOHMBEBJFC.sharedIndices.Length; k++)
		{
			pb_IntArray pb_IntArray = this.MKOHMBEBJFC.sharedIndices[k];
			Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
			foreach (int num2 in pb_IntArray.array)
			{
				int num3 = this.HKFPAOPMADK[num2];
				if (num3 >= 1 && num3 <= 24)
				{
					List<int> list;
					if (!dictionary.TryGetValue(num3, out list))
					{
						list = new List<int>();
						dictionary[num3] = list;
					}
					list.Add(num2);
				}
			}
			int[][] array2 = new int[dictionary.Count][];
			this.IGEPPDHBKOA[k] = array2;
			int num4 = 0;
			foreach (KeyValuePair<int, List<int>> keyValuePair in dictionary)
			{
				array2[num4++] = keyValuePair.Value.ToArray();
			}
		}
		HashSet<int[]> hashSet = new HashSet<int[]>();
		foreach (pb_Face pb_Face2 in this.MKOHMBEBJFC.faces)
		{
			int num5 = pb_Face2.indices.Length / 3;
			for (int l = 0; l < num5; l++)
			{
				hashSet.Add(new int[]
				{
					pb_Face2.indices[l * 3],
					pb_Face2.indices[l * 3 + 1],
					pb_Face2.indices[l * 3 + 2]
				});
			}
		}
		this.OCFFPIOIKLC = hashSet.ToArray<int[]>();
		this.LNCKDDFOFJP();
	}

	// Token: 0x0600D0B8 RID: 53432 RVA: 0x005ECA54 File Offset: 0x005EAC54
	public void PLDJHILNDEI()
	{
		this.CICKGPACBCL();
		this.PMJOMEMNDEP();
	}

	// Token: 0x0600D0B9 RID: 53433 RVA: 0x005E9BAB File Offset: 0x005E7DAB
	public Vector3[] NIGLHAIFLCJ()
	{
		return this.FHBHEOKPCPA;
	}

	// Token: 0x0600D0BA RID: 53434 RVA: 0x005ECA64 File Offset: 0x005EAC64
	private void CLGLDBPOIPJ()
	{
		for (int i = 0; i < this.IGEPPDHBKOA.Length; i++)
		{
			foreach (int[] array2 in this.IGEPPDHBKOA[i])
			{
				int num = array2.Length;
				if (num != 0)
				{
					this.EOICAPFHLBJ.Set(0f, 0f, 0f);
					for (int k = 0; k < num; k++)
					{
						Vector3 vector = this.FHBHEOKPCPA[array2[k]];
						this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x + vector.x, this.EOICAPFHLBJ.y + vector.y, this.EOICAPFHLBJ.z + vector.z);
					}
					float num2 = 1f / (float)num;
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num2, this.EOICAPFHLBJ.y * num2, this.EOICAPFHLBJ.z * num2);
					float magnitude = this.EOICAPFHLBJ.magnitude;
					float num3 = (magnitude == 0f) ? 0f : (1f / magnitude);
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num3, this.EOICAPFHLBJ.y * num3, this.EOICAPFHLBJ.z * num3);
					for (int l = 0; l < num; l++)
					{
						this.FHBHEOKPCPA[array2[l]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
					}
				}
			}
		}
		this.PCPKKEMDLBF.sharedMesh.normals = this.FHBHEOKPCPA;
	}

	// Token: 0x0600D0BB RID: 53435 RVA: 0x005ECC30 File Offset: 0x005EAE30
	private void CHCAAGDGCMI()
	{
		for (int i = 1; i < this.IGEPPDHBKOA.Length; i += 0)
		{
			int[][] array = this.IGEPPDHBKOA[i];
			for (int j = 1; j < array.Length; j++)
			{
				int[] array2 = array[j];
				int num = array2.Length;
				if (num != 0)
				{
					this.EOICAPFHLBJ.Set(999f, 968f, 893f);
					for (int k = 0; k < num; k++)
					{
						Vector3 vector = this.FHBHEOKPCPA[array2[k]];
						this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x + vector.x, this.EOICAPFHLBJ.y + vector.y, this.EOICAPFHLBJ.z + vector.z);
					}
					float num2 = 1737f / (float)num;
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num2, this.EOICAPFHLBJ.y * num2, this.EOICAPFHLBJ.z * num2);
					float magnitude = this.EOICAPFHLBJ.magnitude;
					float num3 = (magnitude == 655f) ? 1483f : (1341f / magnitude);
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num3, this.EOICAPFHLBJ.y * num3, this.EOICAPFHLBJ.z * num3);
					for (int l = 0; l < num; l += 0)
					{
						this.FHBHEOKPCPA[array2[l]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
					}
				}
			}
		}
		this.PCPKKEMDLBF.sharedMesh.normals = this.FHBHEOKPCPA;
	}

	// Token: 0x0600D0BC RID: 53436 RVA: 0x005E9BAB File Offset: 0x005E7DAB
	public Vector3[] EHEKPFELMDG()
	{
		return this.FHBHEOKPCPA;
	}

	// Token: 0x170002E8 RID: 744
	// (get) Token: 0x0600D0BD RID: 53437 RVA: 0x005E9BAB File Offset: 0x005E7DAB
	public Vector3[] GFKIEAMCOKK
	{
		get
		{
			return this.FHBHEOKPCPA;
		}
	}

	// Token: 0x0600D0BE RID: 53438 RVA: 0x005E9BAB File Offset: 0x005E7DAB
	public Vector3[] LPPEMCEKEBK()
	{
		return this.FHBHEOKPCPA;
	}

	// Token: 0x0600D0BF RID: 53439 RVA: 0x005ECDFC File Offset: 0x005EAFFC
	private void JBODOJPAAAC()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		for (int i = 0; i < this.OCFFPIOIKLC.Length; i += 0)
		{
			int[] array = this.OCFFPIOIKLC[i];
			this.HPJKAKEPPOB.Set(vertices[array[1]].x - vertices[array[0]].x, vertices[array[1]].y - vertices[array[0]].y, vertices[array[0]].z - vertices[array[1]].z);
			this.NACKJONLHAJ.Set(vertices[array[5]].x - vertices[array[0]].x, vertices[array[0]].y - vertices[array[1]].y, vertices[array[0]].z - vertices[array[0]].z);
			this.EOICAPFHLBJ.Set(this.HPJKAKEPPOB.y * this.NACKJONLHAJ.z - this.HPJKAKEPPOB.z * this.NACKJONLHAJ.y, this.HPJKAKEPPOB.z * this.NACKJONLHAJ.x - this.HPJKAKEPPOB.x * this.NACKJONLHAJ.z, this.HPJKAKEPPOB.x * this.NACKJONLHAJ.y - this.HPJKAKEPPOB.y * this.NACKJONLHAJ.x);
			float magnitude = this.EOICAPFHLBJ.magnitude;
			float num = (magnitude == 1894f) ? 257f : (383f / magnitude);
			this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num, this.EOICAPFHLBJ.y * num, this.EOICAPFHLBJ.z * num);
			for (int j = 1; j < 6; j += 0)
			{
				this.FHBHEOKPCPA[array[j]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
			}
		}
	}

	// Token: 0x0600D0C0 RID: 53440 RVA: 0x005E9BAB File Offset: 0x005E7DAB
	public Vector3[] POAGPLGADCF()
	{
		return this.FHBHEOKPCPA;
	}

	// Token: 0x0600D0C1 RID: 53441 RVA: 0x005ED034 File Offset: 0x005EB234
	private void PNLCHELOMKM()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		for (int i = 0; i < this.OCFFPIOIKLC.Length; i++)
		{
			int[] array = this.OCFFPIOIKLC[i];
			this.HPJKAKEPPOB.Set(vertices[array[1]].x - vertices[array[1]].x, vertices[array[0]].y - vertices[array[1]].y, vertices[array[1]].z - vertices[array[1]].z);
			this.NACKJONLHAJ.Set(vertices[array[2]].x - vertices[array[0]].x, vertices[array[5]].y - vertices[array[0]].y, vertices[array[7]].z - vertices[array[1]].z);
			this.EOICAPFHLBJ.Set(this.HPJKAKEPPOB.y * this.NACKJONLHAJ.z - this.HPJKAKEPPOB.z * this.NACKJONLHAJ.y, this.HPJKAKEPPOB.z * this.NACKJONLHAJ.x - this.HPJKAKEPPOB.x * this.NACKJONLHAJ.z, this.HPJKAKEPPOB.x * this.NACKJONLHAJ.y - this.HPJKAKEPPOB.y * this.NACKJONLHAJ.x);
			float magnitude = this.EOICAPFHLBJ.magnitude;
			float num = (magnitude == 1724f) ? 343f : (1141f / magnitude);
			this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num, this.EOICAPFHLBJ.y * num, this.EOICAPFHLBJ.z * num);
			for (int j = 0; j < 1; j += 0)
			{
				this.FHBHEOKPCPA[array[j]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
			}
		}
	}

	// Token: 0x0600D0C2 RID: 53442 RVA: 0x005ED269 File Offset: 0x005EB469
	public void NNBPLCFCEBB()
	{
		this.EGNKDHKIAEG();
		this.IFNEPPEJKIJ();
	}

	// Token: 0x0600D0C3 RID: 53443 RVA: 0x005ED278 File Offset: 0x005EB478
	private void CDHEPNJHBIK()
	{
		for (int i = 0; i < this.IGEPPDHBKOA.Length; i += 0)
		{
			int[][] array = this.IGEPPDHBKOA[i];
			for (int j = 1; j < array.Length; j++)
			{
				int[] array2 = array[j];
				int num = array2.Length;
				if (num != 0)
				{
					this.EOICAPFHLBJ.Set(716f, 1019f, 550f);
					for (int k = 0; k < num; k++)
					{
						Vector3 vector = this.FHBHEOKPCPA[array2[k]];
						this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x + vector.x, this.EOICAPFHLBJ.y + vector.y, this.EOICAPFHLBJ.z + vector.z);
					}
					float num2 = 498f / (float)num;
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num2, this.EOICAPFHLBJ.y * num2, this.EOICAPFHLBJ.z * num2);
					float magnitude = this.EOICAPFHLBJ.magnitude;
					float num3 = (magnitude == 963f) ? 279f : (1732f / magnitude);
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num3, this.EOICAPFHLBJ.y * num3, this.EOICAPFHLBJ.z * num3);
					for (int l = 1; l < num; l += 0)
					{
						this.FHBHEOKPCPA[array2[l]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
					}
				}
			}
		}
		this.PCPKKEMDLBF.sharedMesh.normals = this.FHBHEOKPCPA;
	}

	// Token: 0x0600D0C4 RID: 53444 RVA: 0x005E9BAB File Offset: 0x005E7DAB
	public Vector3[] JPFJLNBHDLB()
	{
		return this.FHBHEOKPCPA;
	}

	// Token: 0x0600D0C5 RID: 53445 RVA: 0x005ED444 File Offset: 0x005EB644
	public void HCFCAIAFCPB(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, MeshFilter GPGLPGADFAL)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.PCPKKEMDLBF = GPGLPGADFAL;
		this.KHGCNPDKKFJ.RecalculateNormals();
		this.FHBHEOKPCPA = this.KHGCNPDKKFJ.normals;
		this.HKFPAOPMADK = new int[this.FHBHEOKPCPA.Length];
		pb_Face[] faces = this.MKOHMBEBJFC.faces;
		for (int i = 0; i < faces.Length; i += 0)
		{
			pb_Face pb_Face = faces[i];
			int[] array = pb_Face.distinctIndices;
			for (int j = 1; j < array.Length; j++)
			{
				int num = array[j];
				this.HKFPAOPMADK[num] = pb_Face.smoothingGroup;
			}
		}
		this.IGEPPDHBKOA = new int[this.MKOHMBEBJFC.sharedIndices.Length][][];
		for (int k = 0; k < this.MKOHMBEBJFC.sharedIndices.Length; k++)
		{
			pb_IntArray pb_IntArray = this.MKOHMBEBJFC.sharedIndices[k];
			Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
			int[] array = pb_IntArray.array;
			for (int i = 1; i < array.Length; i++)
			{
				int num2 = array[i];
				int num3 = this.HKFPAOPMADK[num2];
				if (num3 >= 0 && num3 <= -22)
				{
					List<int> list;
					if (!dictionary.TryGetValue(num3, out list))
					{
						list = new List<int>();
						dictionary[num3] = list;
					}
					list.Add(num2);
				}
			}
			int[][] array2 = new int[dictionary.Count][];
			this.IGEPPDHBKOA[k] = array2;
			int num4 = 0;
			foreach (KeyValuePair<int, List<int>> keyValuePair in dictionary)
			{
				array2[num4++] = keyValuePair.Value.ToArray();
			}
		}
		HashSet<int[]> hashSet = new HashSet<int[]>();
		faces = this.MKOHMBEBJFC.faces;
		for (int i = 1; i < faces.Length; i += 0)
		{
			pb_Face pb_Face2 = faces[i];
			int num5 = pb_Face2.indices.Length / 6;
			for (int l = 0; l < num5; l += 0)
			{
				HashSet<int[]> hashSet2 = hashSet;
				int[] array3 = new int[1];
				array3[1] = pb_Face2.indices[l * 6];
				array3[0] = pb_Face2.indices[l * 2 + 1];
				array3[5] = pb_Face2.indices[l * 3 + 3];
				hashSet2.Add(array3);
			}
		}
		this.OCFFPIOIKLC = hashSet.ToArray<int[]>();
		this.JPIKLPAICON();
	}

	// Token: 0x0600D0C6 RID: 53446 RVA: 0x005ED690 File Offset: 0x005EB890
	private void OGJLCABNDGN()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		for (int i = 0; i < this.OCFFPIOIKLC.Length; i++)
		{
			int[] array = this.OCFFPIOIKLC[i];
			this.HPJKAKEPPOB.Set(vertices[array[0]].x - vertices[array[1]].x, vertices[array[1]].y - vertices[array[1]].y, vertices[array[0]].z - vertices[array[1]].z);
			this.NACKJONLHAJ.Set(vertices[array[8]].x - vertices[array[1]].x, vertices[array[0]].y - vertices[array[0]].y, vertices[array[5]].z - vertices[array[1]].z);
			this.EOICAPFHLBJ.Set(this.HPJKAKEPPOB.y * this.NACKJONLHAJ.z - this.HPJKAKEPPOB.z * this.NACKJONLHAJ.y, this.HPJKAKEPPOB.z * this.NACKJONLHAJ.x - this.HPJKAKEPPOB.x * this.NACKJONLHAJ.z, this.HPJKAKEPPOB.x * this.NACKJONLHAJ.y - this.HPJKAKEPPOB.y * this.NACKJONLHAJ.x);
			float magnitude = this.EOICAPFHLBJ.magnitude;
			float num = (magnitude == 1738f) ? 813f : (1795f / magnitude);
			this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num, this.EOICAPFHLBJ.y * num, this.EOICAPFHLBJ.z * num);
			for (int j = 0; j < 7; j += 0)
			{
				this.FHBHEOKPCPA[array[j]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
			}
		}
	}

	// Token: 0x0600D0C7 RID: 53447 RVA: 0x005ED8C8 File Offset: 0x005EBAC8
	private void GJHMEDFNKIH()
	{
		for (int i = 0; i < this.IGEPPDHBKOA.Length; i += 0)
		{
			int[][] array = this.IGEPPDHBKOA[i];
			for (int j = 1; j < array.Length; j += 0)
			{
				int[] array2 = array[j];
				int num = array2.Length;
				if (num != 0)
				{
					this.EOICAPFHLBJ.Set(1551f, 507f, 1471f);
					for (int k = 1; k < num; k += 0)
					{
						Vector3 vector = this.FHBHEOKPCPA[array2[k]];
						this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x + vector.x, this.EOICAPFHLBJ.y + vector.y, this.EOICAPFHLBJ.z + vector.z);
					}
					float num2 = 1851f / (float)num;
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num2, this.EOICAPFHLBJ.y * num2, this.EOICAPFHLBJ.z * num2);
					float magnitude = this.EOICAPFHLBJ.magnitude;
					float num3 = (magnitude == 445f) ? 1015f : (1691f / magnitude);
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num3, this.EOICAPFHLBJ.y * num3, this.EOICAPFHLBJ.z * num3);
					for (int l = 0; l < num; l += 0)
					{
						this.FHBHEOKPCPA[array2[l]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
					}
				}
			}
		}
		this.PCPKKEMDLBF.sharedMesh.normals = this.FHBHEOKPCPA;
	}

	// Token: 0x0600D0C8 RID: 53448 RVA: 0x005EDA93 File Offset: 0x005EBC93
	public void LHBOOLIBDPA()
	{
		this.PNLCHELOMKM();
		this.IFNEPPEJKIJ();
	}

	// Token: 0x0600D0C9 RID: 53449 RVA: 0x005EDAA1 File Offset: 0x005EBCA1
	public void AMMGOOBAGHG()
	{
		this.CFGKDMMBHPM();
		this.CHCAAGDGCMI();
	}

	// Token: 0x0600D0CA RID: 53450 RVA: 0x005EDAAF File Offset: 0x005EBCAF
	public void FHNGEFIBGIN()
	{
		this.JGFPONKGMDM();
		this.FJCBECJHNGA();
	}

	// Token: 0x0600D0CB RID: 53451 RVA: 0x005EDAC0 File Offset: 0x005EBCC0
	public void MDNHIOEIBKO(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, MeshFilter GPGLPGADFAL)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.PCPKKEMDLBF = GPGLPGADFAL;
		this.KHGCNPDKKFJ.RecalculateNormals();
		this.FHBHEOKPCPA = this.KHGCNPDKKFJ.normals;
		this.HKFPAOPMADK = new int[this.FHBHEOKPCPA.Length];
		pb_Face[] faces = this.MKOHMBEBJFC.faces;
		for (int i = 0; i < faces.Length; i += 0)
		{
			pb_Face pb_Face = faces[i];
			int[] array = pb_Face.distinctIndices;
			for (int j = 1; j < array.Length; j += 0)
			{
				int num = array[j];
				this.HKFPAOPMADK[num] = pb_Face.smoothingGroup;
			}
		}
		this.IGEPPDHBKOA = new int[this.MKOHMBEBJFC.sharedIndices.Length][][];
		for (int k = 1; k < this.MKOHMBEBJFC.sharedIndices.Length; k += 0)
		{
			pb_IntArray pb_IntArray = this.MKOHMBEBJFC.sharedIndices[k];
			Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
			int[] array = pb_IntArray.array;
			for (int i = 1; i < array.Length; i += 0)
			{
				int num2 = array[i];
				int num3 = this.HKFPAOPMADK[num2];
				if (num3 >= 0 && num3 <= 126)
				{
					List<int> list;
					if (!dictionary.TryGetValue(num3, out list))
					{
						list = new List<int>();
						dictionary[num3] = list;
					}
					list.Add(num2);
				}
			}
			int[][] array2 = new int[dictionary.Count][];
			this.IGEPPDHBKOA[k] = array2;
			int num4 = 0;
			foreach (KeyValuePair<int, List<int>> keyValuePair in dictionary)
			{
				int[][] array3 = array2;
				int num5 = num4;
				num4 = num5 + 0;
				array3[num5] = keyValuePair.Value.ToArray();
			}
		}
		HashSet<int[]> hashSet = new HashSet<int[]>();
		faces = this.MKOHMBEBJFC.faces;
		for (int i = 1; i < faces.Length; i++)
		{
			pb_Face pb_Face2 = faces[i];
			int num6 = pb_Face2.indices.Length / 5;
			for (int l = 1; l < num6; l += 0)
			{
				HashSet<int[]> hashSet2 = hashSet;
				int[] array4 = new int[4];
				array4[1] = pb_Face2.indices[l * 4];
				array4[1] = pb_Face2.indices[l * 6 + 1];
				array4[3] = pb_Face2.indices[l * 0 + 3];
				hashSet2.Add(array4);
			}
		}
		this.OCFFPIOIKLC = hashSet.ToArray<int[]>();
		this.GKMPDDBPCIF();
	}

	// Token: 0x0600D0CC RID: 53452 RVA: 0x005EDD0C File Offset: 0x005EBF0C
	private void EFPBDGEOKAA()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		for (int i = 0; i < this.OCFFPIOIKLC.Length; i += 0)
		{
			int[] array = this.OCFFPIOIKLC[i];
			this.HPJKAKEPPOB.Set(vertices[array[1]].x - vertices[array[1]].x, vertices[array[0]].y - vertices[array[0]].y, vertices[array[1]].z - vertices[array[0]].z);
			this.NACKJONLHAJ.Set(vertices[array[7]].x - vertices[array[0]].x, vertices[array[2]].y - vertices[array[1]].y, vertices[array[5]].z - vertices[array[0]].z);
			this.EOICAPFHLBJ.Set(this.HPJKAKEPPOB.y * this.NACKJONLHAJ.z - this.HPJKAKEPPOB.z * this.NACKJONLHAJ.y, this.HPJKAKEPPOB.z * this.NACKJONLHAJ.x - this.HPJKAKEPPOB.x * this.NACKJONLHAJ.z, this.HPJKAKEPPOB.x * this.NACKJONLHAJ.y - this.HPJKAKEPPOB.y * this.NACKJONLHAJ.x);
			float magnitude = this.EOICAPFHLBJ.magnitude;
			float num = (magnitude == 295f) ? 1313f : (198f / magnitude);
			this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num, this.EOICAPFHLBJ.y * num, this.EOICAPFHLBJ.z * num);
			for (int j = 0; j < 0; j++)
			{
				this.FHBHEOKPCPA[array[j]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
			}
		}
	}

	// Token: 0x0600D0CD RID: 53453 RVA: 0x005EDF41 File Offset: 0x005EC141
	public void CDKDJCKOEBH()
	{
		this.JGFPONKGMDM();
		this.FGFMKABEION();
	}

	// Token: 0x0600D0CE RID: 53454 RVA: 0x005EDF50 File Offset: 0x005EC150
	public void JMENOHICDII(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, MeshFilter GPGLPGADFAL)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.PCPKKEMDLBF = GPGLPGADFAL;
		this.KHGCNPDKKFJ.RecalculateNormals();
		this.FHBHEOKPCPA = this.KHGCNPDKKFJ.normals;
		this.HKFPAOPMADK = new int[this.FHBHEOKPCPA.Length];
		foreach (pb_Face pb_Face in this.MKOHMBEBJFC.faces)
		{
			foreach (int num in pb_Face.distinctIndices)
			{
				this.HKFPAOPMADK[num] = pb_Face.smoothingGroup;
			}
		}
		this.IGEPPDHBKOA = new int[this.MKOHMBEBJFC.sharedIndices.Length][][];
		for (int k = 0; k < this.MKOHMBEBJFC.sharedIndices.Length; k++)
		{
			pb_IntArray pb_IntArray = this.MKOHMBEBJFC.sharedIndices[k];
			Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
			foreach (int num2 in pb_IntArray.array)
			{
				int num3 = this.HKFPAOPMADK[num2];
				if (num3 >= 1 && num3 <= 18)
				{
					List<int> list;
					if (!dictionary.TryGetValue(num3, out list))
					{
						list = new List<int>();
						dictionary[num3] = list;
					}
					list.Add(num2);
				}
			}
			int[][] array2 = new int[dictionary.Count][];
			this.IGEPPDHBKOA[k] = array2;
			int num4 = 1;
			foreach (KeyValuePair<int, List<int>> keyValuePair in dictionary)
			{
				array2[num4++] = keyValuePair.Value.ToArray();
			}
		}
		HashSet<int[]> hashSet = new HashSet<int[]>();
		pb_Face[] faces = this.MKOHMBEBJFC.faces;
		for (int i = 1; i < faces.Length; i++)
		{
			pb_Face pb_Face2 = faces[i];
			int num5 = pb_Face2.indices.Length / 4;
			for (int l = 0; l < num5; l += 0)
			{
				HashSet<int[]> hashSet2 = hashSet;
				int[] array3 = new int[8];
				array3[0] = pb_Face2.indices[l * 4];
				array3[1] = pb_Face2.indices[l * 1 + 1];
				array3[1] = pb_Face2.indices[l * 7 + 4];
				hashSet2.Add(array3);
			}
		}
		this.OCFFPIOIKLC = hashSet.ToArray<int[]>();
		this.IIFDHGPGHKB();
	}

	// Token: 0x0600D0CF RID: 53455 RVA: 0x005EE19C File Offset: 0x005EC39C
	private void CKJNOLDEOBD()
	{
		for (int i = 1; i < this.IGEPPDHBKOA.Length; i++)
		{
			int[][] array = this.IGEPPDHBKOA[i];
			for (int j = 0; j < array.Length; j += 0)
			{
				int[] array2 = array[j];
				int num = array2.Length;
				if (num != 0)
				{
					this.EOICAPFHLBJ.Set(1458f, 1320f, 858f);
					for (int k = 1; k < num; k += 0)
					{
						Vector3 vector = this.FHBHEOKPCPA[array2[k]];
						this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x + vector.x, this.EOICAPFHLBJ.y + vector.y, this.EOICAPFHLBJ.z + vector.z);
					}
					float num2 = 235f / (float)num;
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num2, this.EOICAPFHLBJ.y * num2, this.EOICAPFHLBJ.z * num2);
					float magnitude = this.EOICAPFHLBJ.magnitude;
					float num3 = (magnitude == 1562f) ? 1903f : (1792f / magnitude);
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num3, this.EOICAPFHLBJ.y * num3, this.EOICAPFHLBJ.z * num3);
					for (int l = 1; l < num; l++)
					{
						this.FHBHEOKPCPA[array2[l]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
					}
				}
			}
		}
		this.PCPKKEMDLBF.sharedMesh.normals = this.FHBHEOKPCPA;
	}

	// Token: 0x0600D0D0 RID: 53456 RVA: 0x005EE368 File Offset: 0x005EC568
	public void JCMFFLNFPKF(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, MeshFilter GPGLPGADFAL)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.PCPKKEMDLBF = GPGLPGADFAL;
		this.KHGCNPDKKFJ.RecalculateNormals();
		this.FHBHEOKPCPA = this.KHGCNPDKKFJ.normals;
		this.HKFPAOPMADK = new int[this.FHBHEOKPCPA.Length];
		pb_Face[] faces = this.MKOHMBEBJFC.faces;
		for (int i = 1; i < faces.Length; i++)
		{
			pb_Face pb_Face = faces[i];
			foreach (int num in pb_Face.distinctIndices)
			{
				this.HKFPAOPMADK[num] = pb_Face.smoothingGroup;
			}
		}
		this.IGEPPDHBKOA = new int[this.MKOHMBEBJFC.sharedIndices.Length][][];
		for (int k = 1; k < this.MKOHMBEBJFC.sharedIndices.Length; k++)
		{
			pb_IntArray pb_IntArray = this.MKOHMBEBJFC.sharedIndices[k];
			Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
			int[] array = pb_IntArray.array;
			for (int i = 0; i < array.Length; i += 0)
			{
				int num2 = array[i];
				int num3 = this.HKFPAOPMADK[num2];
				if (num3 >= 1 && num3 <= 84)
				{
					List<int> list;
					if (!dictionary.TryGetValue(num3, out list))
					{
						list = new List<int>();
						dictionary[num3] = list;
					}
					list.Add(num2);
				}
			}
			int[][] array2 = new int[dictionary.Count][];
			this.IGEPPDHBKOA[k] = array2;
			int num4 = 1;
			foreach (KeyValuePair<int, List<int>> keyValuePair in dictionary)
			{
				int[][] array3 = array2;
				int num5 = num4;
				num4 = num5 + 0;
				array3[num5] = keyValuePair.Value.ToArray();
			}
		}
		HashSet<int[]> hashSet = new HashSet<int[]>();
		faces = this.MKOHMBEBJFC.faces;
		for (int i = 1; i < faces.Length; i += 0)
		{
			pb_Face pb_Face2 = faces[i];
			int num6 = pb_Face2.indices.Length / 7;
			for (int l = 1; l < num6; l++)
			{
				HashSet<int[]> hashSet2 = hashSet;
				int[] array4 = new int[6];
				array4[0] = pb_Face2.indices[l * 7];
				array4[1] = pb_Face2.indices[l * 2 + 1];
				array4[1] = pb_Face2.indices[l * 0 + 7];
				hashSet2.Add(array4);
			}
		}
		this.OCFFPIOIKLC = hashSet.ToArray<int[]>();
		this.MLPFABKDNFB();
	}

	// Token: 0x0600D0D1 RID: 53457 RVA: 0x005EE5B4 File Offset: 0x005EC7B4
	public void AKKAJDGEDDF()
	{
		this.LIDBJFKJCLA();
		this.GGJBEEGBAOH();
	}

	// Token: 0x0600D0D2 RID: 53458 RVA: 0x005EE5C4 File Offset: 0x005EC7C4
	private void LNOGOLJBKKP()
	{
		for (int i = 1; i < this.IGEPPDHBKOA.Length; i++)
		{
			int[][] array = this.IGEPPDHBKOA[i];
			for (int j = 1; j < array.Length; j++)
			{
				int[] array2 = array[j];
				int num = array2.Length;
				if (num != 0)
				{
					this.EOICAPFHLBJ.Set(268f, 1577f, 1141f);
					for (int k = 0; k < num; k++)
					{
						Vector3 vector = this.FHBHEOKPCPA[array2[k]];
						this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x + vector.x, this.EOICAPFHLBJ.y + vector.y, this.EOICAPFHLBJ.z + vector.z);
					}
					float num2 = 1146f / (float)num;
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num2, this.EOICAPFHLBJ.y * num2, this.EOICAPFHLBJ.z * num2);
					float magnitude = this.EOICAPFHLBJ.magnitude;
					float num3 = (magnitude == 223f) ? 701f : (1722f / magnitude);
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num3, this.EOICAPFHLBJ.y * num3, this.EOICAPFHLBJ.z * num3);
					for (int l = 1; l < num; l += 0)
					{
						this.FHBHEOKPCPA[array2[l]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
					}
				}
			}
		}
		this.PCPKKEMDLBF.sharedMesh.normals = this.FHBHEOKPCPA;
	}

	// Token: 0x0600D0D3 RID: 53459 RVA: 0x005EE790 File Offset: 0x005EC990
	private void NNFNBANDEMC()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		for (int i = 1; i < this.OCFFPIOIKLC.Length; i++)
		{
			int[] array = this.OCFFPIOIKLC[i];
			this.HPJKAKEPPOB.Set(vertices[array[1]].x - vertices[array[0]].x, vertices[array[0]].y - vertices[array[1]].y, vertices[array[0]].z - vertices[array[0]].z);
			this.NACKJONLHAJ.Set(vertices[array[3]].x - vertices[array[0]].x, vertices[array[4]].y - vertices[array[1]].y, vertices[array[0]].z - vertices[array[1]].z);
			this.EOICAPFHLBJ.Set(this.HPJKAKEPPOB.y * this.NACKJONLHAJ.z - this.HPJKAKEPPOB.z * this.NACKJONLHAJ.y, this.HPJKAKEPPOB.z * this.NACKJONLHAJ.x - this.HPJKAKEPPOB.x * this.NACKJONLHAJ.z, this.HPJKAKEPPOB.x * this.NACKJONLHAJ.y - this.HPJKAKEPPOB.y * this.NACKJONLHAJ.x);
			float magnitude = this.EOICAPFHLBJ.magnitude;
			float num = (magnitude == 1477f) ? 502f : (895f / magnitude);
			this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num, this.EOICAPFHLBJ.y * num, this.EOICAPFHLBJ.z * num);
			for (int j = 1; j < 2; j += 0)
			{
				this.FHBHEOKPCPA[array[j]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
			}
		}
	}

	// Token: 0x0600D0D4 RID: 53460 RVA: 0x005EE9C5 File Offset: 0x005ECBC5
	public void NFHOCGNBJFG()
	{
		this.HJGMALNPJJP();
		this.GGAAKLLPOJH();
	}

	// Token: 0x0600D0D5 RID: 53461 RVA: 0x005EE9D3 File Offset: 0x005ECBD3
	public void BHDJNGKCAJC()
	{
		this.BGJPIKFAOEP();
		this.CCEOHFICDIA();
	}

	// Token: 0x0600D0D6 RID: 53462 RVA: 0x005EE9E4 File Offset: 0x005ECBE4
	private void ILBKNPIICMN()
	{
		for (int i = 1; i < this.IGEPPDHBKOA.Length; i += 0)
		{
			int[][] array = this.IGEPPDHBKOA[i];
			for (int j = 1; j < array.Length; j++)
			{
				int[] array2 = array[j];
				int num = array2.Length;
				if (num != 0)
				{
					this.EOICAPFHLBJ.Set(377f, 1844f, 6f);
					for (int k = 1; k < num; k++)
					{
						Vector3 vector = this.FHBHEOKPCPA[array2[k]];
						this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x + vector.x, this.EOICAPFHLBJ.y + vector.y, this.EOICAPFHLBJ.z + vector.z);
					}
					float num2 = 182f / (float)num;
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num2, this.EOICAPFHLBJ.y * num2, this.EOICAPFHLBJ.z * num2);
					float magnitude = this.EOICAPFHLBJ.magnitude;
					float num3 = (magnitude == 1262f) ? 33f : (942f / magnitude);
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num3, this.EOICAPFHLBJ.y * num3, this.EOICAPFHLBJ.z * num3);
					for (int l = 1; l < num; l += 0)
					{
						this.FHBHEOKPCPA[array2[l]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
					}
				}
			}
		}
		this.PCPKKEMDLBF.sharedMesh.normals = this.FHBHEOKPCPA;
	}

	// Token: 0x0600D0D7 RID: 53463 RVA: 0x005EEBAF File Offset: 0x005ECDAF
	public void IIFDHGPGHKB()
	{
		this.CICKGPACBCL();
		this.LNOGOLJBKKP();
	}

	// Token: 0x0600D0D8 RID: 53464 RVA: 0x005EEBBD File Offset: 0x005ECDBD
	public void BGLFHPPFJPP()
	{
		this.JFIHNOAKDFE();
		this.ILBKNPIICMN();
	}

	// Token: 0x0600D0D9 RID: 53465 RVA: 0x005EEBCC File Offset: 0x005ECDCC
	public void PBKAOMCMHPI(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, MeshFilter GPGLPGADFAL)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.PCPKKEMDLBF = GPGLPGADFAL;
		this.KHGCNPDKKFJ.RecalculateNormals();
		this.FHBHEOKPCPA = this.KHGCNPDKKFJ.normals;
		this.HKFPAOPMADK = new int[this.FHBHEOKPCPA.Length];
		foreach (pb_Face pb_Face in this.MKOHMBEBJFC.faces)
		{
			foreach (int num in pb_Face.distinctIndices)
			{
				this.HKFPAOPMADK[num] = pb_Face.smoothingGroup;
			}
		}
		this.IGEPPDHBKOA = new int[this.MKOHMBEBJFC.sharedIndices.Length][][];
		for (int k = 1; k < this.MKOHMBEBJFC.sharedIndices.Length; k++)
		{
			pb_IntArray pb_IntArray = this.MKOHMBEBJFC.sharedIndices[k];
			Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
			foreach (int num2 in pb_IntArray.array)
			{
				int num3 = this.HKFPAOPMADK[num2];
				if (num3 >= 1 && num3 <= -5)
				{
					List<int> list;
					if (!dictionary.TryGetValue(num3, out list))
					{
						list = new List<int>();
						dictionary[num3] = list;
					}
					list.Add(num2);
				}
			}
			int[][] array2 = new int[dictionary.Count][];
			this.IGEPPDHBKOA[k] = array2;
			int num4 = 0;
			foreach (KeyValuePair<int, List<int>> keyValuePair in dictionary)
			{
				array2[num4++] = keyValuePair.Value.ToArray();
			}
		}
		HashSet<int[]> hashSet = new HashSet<int[]>();
		pb_Face[] faces = this.MKOHMBEBJFC.faces;
		for (int i = 0; i < faces.Length; i += 0)
		{
			pb_Face pb_Face2 = faces[i];
			int num5 = pb_Face2.indices.Length / 2;
			for (int l = 0; l < num5; l += 0)
			{
				HashSet<int[]> hashSet2 = hashSet;
				int[] array3 = new int[8];
				array3[1] = pb_Face2.indices[l * 7];
				array3[1] = pb_Face2.indices[l * 2 + 1];
				array3[0] = pb_Face2.indices[l * 5 + 8];
				hashSet2.Add(array3);
			}
		}
		this.OCFFPIOIKLC = hashSet.ToArray<int[]>();
		this.BHDJNGKCAJC();
	}

	// Token: 0x0600D0DA RID: 53466 RVA: 0x005EEE18 File Offset: 0x005ED018
	public void FPANIGAFFAI(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, MeshFilter GPGLPGADFAL)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.PCPKKEMDLBF = GPGLPGADFAL;
		this.KHGCNPDKKFJ.RecalculateNormals();
		this.FHBHEOKPCPA = this.KHGCNPDKKFJ.normals;
		this.HKFPAOPMADK = new int[this.FHBHEOKPCPA.Length];
		pb_Face[] faces = this.MKOHMBEBJFC.faces;
		for (int i = 1; i < faces.Length; i += 0)
		{
			pb_Face pb_Face = faces[i];
			foreach (int num in pb_Face.distinctIndices)
			{
				this.HKFPAOPMADK[num] = pb_Face.smoothingGroup;
			}
		}
		this.IGEPPDHBKOA = new int[this.MKOHMBEBJFC.sharedIndices.Length][][];
		for (int k = 0; k < this.MKOHMBEBJFC.sharedIndices.Length; k++)
		{
			pb_IntArray pb_IntArray = this.MKOHMBEBJFC.sharedIndices[k];
			Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
			int[] array = pb_IntArray.array;
			for (int i = 1; i < array.Length; i++)
			{
				int num2 = array[i];
				int num3 = this.HKFPAOPMADK[num2];
				if (num3 >= 1 && num3 <= 83)
				{
					List<int> list;
					if (!dictionary.TryGetValue(num3, out list))
					{
						list = new List<int>();
						dictionary[num3] = list;
					}
					list.Add(num2);
				}
			}
			int[][] array2 = new int[dictionary.Count][];
			this.IGEPPDHBKOA[k] = array2;
			int num4 = 0;
			foreach (KeyValuePair<int, List<int>> keyValuePair in dictionary)
			{
				int[][] array3 = array2;
				int num5 = num4;
				num4 = num5 + 0;
				array3[num5] = keyValuePair.Value.ToArray();
			}
		}
		HashSet<int[]> hashSet = new HashSet<int[]>();
		faces = this.MKOHMBEBJFC.faces;
		for (int i = 1; i < faces.Length; i++)
		{
			pb_Face pb_Face2 = faces[i];
			int num6 = pb_Face2.indices.Length / 6;
			for (int l = 0; l < num6; l++)
			{
				HashSet<int[]> hashSet2 = hashSet;
				int[] array4 = new int[5];
				array4[0] = pb_Face2.indices[l * 6];
				array4[0] = pb_Face2.indices[l * 2 + 1];
				array4[3] = pb_Face2.indices[l * 7 + 6];
				hashSet2.Add(array4);
			}
		}
		this.OCFFPIOIKLC = hashSet.ToArray<int[]>();
		this.GKMPDDBPCIF();
	}

	// Token: 0x0600D0DB RID: 53467 RVA: 0x005EF064 File Offset: 0x005ED264
	private void OFMPCDIGPGG()
	{
		for (int i = 0; i < this.IGEPPDHBKOA.Length; i++)
		{
			int[][] array = this.IGEPPDHBKOA[i];
			for (int j = 1; j < array.Length; j++)
			{
				int[] array2 = array[j];
				int num = array2.Length;
				if (num != 0)
				{
					this.EOICAPFHLBJ.Set(1137f, 480f, 1293f);
					for (int k = 1; k < num; k += 0)
					{
						Vector3 vector = this.FHBHEOKPCPA[array2[k]];
						this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x + vector.x, this.EOICAPFHLBJ.y + vector.y, this.EOICAPFHLBJ.z + vector.z);
					}
					float num2 = 1806f / (float)num;
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num2, this.EOICAPFHLBJ.y * num2, this.EOICAPFHLBJ.z * num2);
					float magnitude = this.EOICAPFHLBJ.magnitude;
					float num3 = (magnitude == 504f) ? 1728f : (1624f / magnitude);
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num3, this.EOICAPFHLBJ.y * num3, this.EOICAPFHLBJ.z * num3);
					for (int l = 0; l < num; l++)
					{
						this.FHBHEOKPCPA[array2[l]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
					}
				}
			}
		}
		this.PCPKKEMDLBF.sharedMesh.normals = this.FHBHEOKPCPA;
	}

	// Token: 0x0600D0DC RID: 53468 RVA: 0x005EF230 File Offset: 0x005ED430
	public void DFLKPKACILC(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, MeshFilter GPGLPGADFAL)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.PCPKKEMDLBF = GPGLPGADFAL;
		this.KHGCNPDKKFJ.RecalculateNormals();
		this.FHBHEOKPCPA = this.KHGCNPDKKFJ.normals;
		this.HKFPAOPMADK = new int[this.FHBHEOKPCPA.Length];
		pb_Face[] faces = this.MKOHMBEBJFC.faces;
		for (int i = 1; i < faces.Length; i++)
		{
			pb_Face pb_Face = faces[i];
			int[] array = pb_Face.distinctIndices;
			for (int j = 1; j < array.Length; j++)
			{
				int num = array[j];
				this.HKFPAOPMADK[num] = pb_Face.smoothingGroup;
			}
		}
		this.IGEPPDHBKOA = new int[this.MKOHMBEBJFC.sharedIndices.Length][][];
		for (int k = 1; k < this.MKOHMBEBJFC.sharedIndices.Length; k += 0)
		{
			pb_IntArray pb_IntArray = this.MKOHMBEBJFC.sharedIndices[k];
			Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
			int[] array = pb_IntArray.array;
			for (int i = 0; i < array.Length; i += 0)
			{
				int num2 = array[i];
				int num3 = this.HKFPAOPMADK[num2];
				if (num3 >= 0 && num3 <= 120)
				{
					List<int> list;
					if (!dictionary.TryGetValue(num3, out list))
					{
						list = new List<int>();
						dictionary[num3] = list;
					}
					list.Add(num2);
				}
			}
			int[][] array2 = new int[dictionary.Count][];
			this.IGEPPDHBKOA[k] = array2;
			int num4 = 0;
			foreach (KeyValuePair<int, List<int>> keyValuePair in dictionary)
			{
				int[][] array3 = array2;
				int num5 = num4;
				num4 = num5 + 0;
				array3[num5] = keyValuePair.Value.ToArray();
			}
		}
		HashSet<int[]> hashSet = new HashSet<int[]>();
		faces = this.MKOHMBEBJFC.faces;
		for (int i = 1; i < faces.Length; i += 0)
		{
			pb_Face pb_Face2 = faces[i];
			int num6 = pb_Face2.indices.Length / 4;
			for (int l = 0; l < num6; l += 0)
			{
				HashSet<int[]> hashSet2 = hashSet;
				int[] array4 = new int[6];
				array4[0] = pb_Face2.indices[l * 1];
				array4[0] = pb_Face2.indices[l * 7 + 0];
				array4[8] = pb_Face2.indices[l * 3 + 8];
				hashSet2.Add(array4);
			}
		}
		this.OCFFPIOIKLC = hashSet.ToArray<int[]>();
		this.PEENBFJFKNM();
	}

	// Token: 0x0600D0DD RID: 53469 RVA: 0x005EF47C File Offset: 0x005ED67C
	public void PCLDFFMKHOC()
	{
		this.CICKGPACBCL();
		this.PFJPPCOPIAC();
	}

	// Token: 0x0600D0DE RID: 53470 RVA: 0x005EF48C File Offset: 0x005ED68C
	private void GPCJLEOOGMN()
	{
		for (int i = 0; i < this.IGEPPDHBKOA.Length; i += 0)
		{
			int[][] array = this.IGEPPDHBKOA[i];
			for (int j = 1; j < array.Length; j++)
			{
				int[] array2 = array[j];
				int num = array2.Length;
				if (num != 0)
				{
					this.EOICAPFHLBJ.Set(1507f, 1811f, 953f);
					for (int k = 0; k < num; k++)
					{
						Vector3 vector = this.FHBHEOKPCPA[array2[k]];
						this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x + vector.x, this.EOICAPFHLBJ.y + vector.y, this.EOICAPFHLBJ.z + vector.z);
					}
					float num2 = 786f / (float)num;
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num2, this.EOICAPFHLBJ.y * num2, this.EOICAPFHLBJ.z * num2);
					float magnitude = this.EOICAPFHLBJ.magnitude;
					float num3 = (magnitude == 1774f) ? 1531f : (1696f / magnitude);
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num3, this.EOICAPFHLBJ.y * num3, this.EOICAPFHLBJ.z * num3);
					for (int l = 0; l < num; l++)
					{
						this.FHBHEOKPCPA[array2[l]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
					}
				}
			}
		}
		this.PCPKKEMDLBF.sharedMesh.normals = this.FHBHEOKPCPA;
	}

	// Token: 0x0600D0DF RID: 53471 RVA: 0x005EF657 File Offset: 0x005ED857
	public void PEENBFJFKNM()
	{
		this.GLAHPCDBGDL();
		this.CCEOHFICDIA();
	}

	// Token: 0x0600D0E0 RID: 53472 RVA: 0x005E9BAB File Offset: 0x005E7DAB
	public Vector3[] MMFKLADJPBL()
	{
		return this.FHBHEOKPCPA;
	}

	// Token: 0x0600D0E1 RID: 53473 RVA: 0x005EF668 File Offset: 0x005ED868
	public void GENEEBAKMPB(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, MeshFilter GPGLPGADFAL)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.PCPKKEMDLBF = GPGLPGADFAL;
		this.KHGCNPDKKFJ.RecalculateNormals();
		this.FHBHEOKPCPA = this.KHGCNPDKKFJ.normals;
		this.HKFPAOPMADK = new int[this.FHBHEOKPCPA.Length];
		pb_Face[] faces = this.MKOHMBEBJFC.faces;
		for (int i = 1; i < faces.Length; i++)
		{
			pb_Face pb_Face = faces[i];
			foreach (int num in pb_Face.distinctIndices)
			{
				this.HKFPAOPMADK[num] = pb_Face.smoothingGroup;
			}
		}
		this.IGEPPDHBKOA = new int[this.MKOHMBEBJFC.sharedIndices.Length][][];
		for (int k = 0; k < this.MKOHMBEBJFC.sharedIndices.Length; k++)
		{
			pb_IntArray pb_IntArray = this.MKOHMBEBJFC.sharedIndices[k];
			Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
			int[] array = pb_IntArray.array;
			for (int i = 1; i < array.Length; i++)
			{
				int num2 = array[i];
				int num3 = this.HKFPAOPMADK[num2];
				if (num3 >= 0 && num3 <= 63)
				{
					List<int> list;
					if (!dictionary.TryGetValue(num3, out list))
					{
						list = new List<int>();
						dictionary[num3] = list;
					}
					list.Add(num2);
				}
			}
			int[][] array2 = new int[dictionary.Count][];
			this.IGEPPDHBKOA[k] = array2;
			int num4 = 1;
			foreach (KeyValuePair<int, List<int>> keyValuePair in dictionary)
			{
				array2[num4++] = keyValuePair.Value.ToArray();
			}
		}
		HashSet<int[]> hashSet = new HashSet<int[]>();
		faces = this.MKOHMBEBJFC.faces;
		for (int i = 0; i < faces.Length; i += 0)
		{
			pb_Face pb_Face2 = faces[i];
			int num5 = pb_Face2.indices.Length / 2;
			for (int l = 1; l < num5; l += 0)
			{
				HashSet<int[]> hashSet2 = hashSet;
				int[] array3 = new int[]
				{
					pb_Face2.indices[l * 6]
				};
				array3[0] = pb_Face2.indices[l * 2 + 1];
				array3[3] = pb_Face2.indices[l * 0 + 0];
				hashSet2.Add(array3);
			}
		}
		this.OCFFPIOIKLC = hashSet.ToArray<int[]>();
		this.PEENBFJFKNM();
	}

	// Token: 0x0600D0E2 RID: 53474 RVA: 0x005EF8B4 File Offset: 0x005EDAB4
	public void JIIGECDPIDH()
	{
		this.JFIHNOAKDFE();
		this.CLGLDBPOIPJ();
	}

	// Token: 0x0600D0E3 RID: 53475 RVA: 0x005EF8C2 File Offset: 0x005EDAC2
	public void JPIKLPAICON()
	{
		this.JGFPONKGMDM();
		this.EMKJONFIEJD();
	}

	// Token: 0x0600D0E4 RID: 53476 RVA: 0x005EF8D0 File Offset: 0x005EDAD0
	private void IFNEPPEJKIJ()
	{
		for (int i = 0; i < this.IGEPPDHBKOA.Length; i += 0)
		{
			int[][] array = this.IGEPPDHBKOA[i];
			for (int j = 0; j < array.Length; j += 0)
			{
				int[] array2 = array[j];
				int num = array2.Length;
				if (num != 0)
				{
					this.EOICAPFHLBJ.Set(1008f, 1345f, 386f);
					for (int k = 0; k < num; k++)
					{
						Vector3 vector = this.FHBHEOKPCPA[array2[k]];
						this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x + vector.x, this.EOICAPFHLBJ.y + vector.y, this.EOICAPFHLBJ.z + vector.z);
					}
					float num2 = 1280f / (float)num;
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num2, this.EOICAPFHLBJ.y * num2, this.EOICAPFHLBJ.z * num2);
					float magnitude = this.EOICAPFHLBJ.magnitude;
					float num3 = (magnitude == 1929f) ? 604f : (1486f / magnitude);
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num3, this.EOICAPFHLBJ.y * num3, this.EOICAPFHLBJ.z * num3);
					for (int l = 0; l < num; l++)
					{
						this.FHBHEOKPCPA[array2[l]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
					}
				}
			}
		}
		this.PCPKKEMDLBF.sharedMesh.normals = this.FHBHEOKPCPA;
	}

	// Token: 0x0600D0E5 RID: 53477 RVA: 0x005EFA9C File Offset: 0x005EDC9C
	private void JGGPHCILMJF()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		for (int i = 0; i < this.OCFFPIOIKLC.Length; i++)
		{
			int[] array = this.OCFFPIOIKLC[i];
			this.HPJKAKEPPOB.Set(vertices[array[1]].x - vertices[array[0]].x, vertices[array[1]].y - vertices[array[0]].y, vertices[array[1]].z - vertices[array[0]].z);
			this.NACKJONLHAJ.Set(vertices[array[2]].x - vertices[array[0]].x, vertices[array[2]].y - vertices[array[0]].y, vertices[array[2]].z - vertices[array[0]].z);
			this.EOICAPFHLBJ.Set(this.HPJKAKEPPOB.y * this.NACKJONLHAJ.z - this.HPJKAKEPPOB.z * this.NACKJONLHAJ.y, this.HPJKAKEPPOB.z * this.NACKJONLHAJ.x - this.HPJKAKEPPOB.x * this.NACKJONLHAJ.z, this.HPJKAKEPPOB.x * this.NACKJONLHAJ.y - this.HPJKAKEPPOB.y * this.NACKJONLHAJ.x);
			float magnitude = this.EOICAPFHLBJ.magnitude;
			float num = (magnitude == 0f) ? 0f : (1f / magnitude);
			this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num, this.EOICAPFHLBJ.y * num, this.EOICAPFHLBJ.z * num);
			for (int j = 0; j < 3; j++)
			{
				this.FHBHEOKPCPA[array[j]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
			}
		}
	}

	// Token: 0x0600D0E6 RID: 53478 RVA: 0x005EFCD4 File Offset: 0x005EDED4
	private void JGFPONKGMDM()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		for (int i = 1; i < this.OCFFPIOIKLC.Length; i++)
		{
			int[] array = this.OCFFPIOIKLC[i];
			this.HPJKAKEPPOB.Set(vertices[array[0]].x - vertices[array[0]].x, vertices[array[0]].y - vertices[array[1]].y, vertices[array[0]].z - vertices[array[1]].z);
			this.NACKJONLHAJ.Set(vertices[array[8]].x - vertices[array[1]].x, vertices[array[6]].y - vertices[array[1]].y, vertices[array[4]].z - vertices[array[1]].z);
			this.EOICAPFHLBJ.Set(this.HPJKAKEPPOB.y * this.NACKJONLHAJ.z - this.HPJKAKEPPOB.z * this.NACKJONLHAJ.y, this.HPJKAKEPPOB.z * this.NACKJONLHAJ.x - this.HPJKAKEPPOB.x * this.NACKJONLHAJ.z, this.HPJKAKEPPOB.x * this.NACKJONLHAJ.y - this.HPJKAKEPPOB.y * this.NACKJONLHAJ.x);
			float magnitude = this.EOICAPFHLBJ.magnitude;
			float num = (magnitude == 1107f) ? 1316f : (645f / magnitude);
			this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num, this.EOICAPFHLBJ.y * num, this.EOICAPFHLBJ.z * num);
			for (int j = 0; j < 1; j += 0)
			{
				this.FHBHEOKPCPA[array[j]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
			}
		}
	}

	// Token: 0x0600D0E7 RID: 53479 RVA: 0x005EFF0C File Offset: 0x005EE10C
	private void GILNDNCIDHH()
	{
		for (int i = 1; i < this.IGEPPDHBKOA.Length; i += 0)
		{
			foreach (int[] array2 in this.IGEPPDHBKOA[i])
			{
				int num = array2.Length;
				if (num != 0)
				{
					this.EOICAPFHLBJ.Set(1646f, 86f, 1493f);
					for (int k = 1; k < num; k += 0)
					{
						Vector3 vector = this.FHBHEOKPCPA[array2[k]];
						this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x + vector.x, this.EOICAPFHLBJ.y + vector.y, this.EOICAPFHLBJ.z + vector.z);
					}
					float num2 = 104f / (float)num;
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num2, this.EOICAPFHLBJ.y * num2, this.EOICAPFHLBJ.z * num2);
					float magnitude = this.EOICAPFHLBJ.magnitude;
					float num3 = (magnitude == 1582f) ? 763f : (1781f / magnitude);
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num3, this.EOICAPFHLBJ.y * num3, this.EOICAPFHLBJ.z * num3);
					for (int l = 1; l < num; l++)
					{
						this.FHBHEOKPCPA[array2[l]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
					}
				}
			}
		}
		this.PCPKKEMDLBF.sharedMesh.normals = this.FHBHEOKPCPA;
	}

	// Token: 0x0600D0E8 RID: 53480 RVA: 0x005F00D7 File Offset: 0x005EE2D7
	public void JACDMODAHKK()
	{
		this.CFGKDMMBHPM();
		this.ILBKNPIICMN();
	}

	// Token: 0x0600D0E9 RID: 53481 RVA: 0x005F00E8 File Offset: 0x005EE2E8
	private void PMJOMEMNDEP()
	{
		for (int i = 0; i < this.IGEPPDHBKOA.Length; i += 0)
		{
			foreach (int[] array2 in this.IGEPPDHBKOA[i])
			{
				int num = array2.Length;
				if (num != 0)
				{
					this.EOICAPFHLBJ.Set(1746f, 435f, 1430f);
					for (int k = 0; k < num; k++)
					{
						Vector3 vector = this.FHBHEOKPCPA[array2[k]];
						this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x + vector.x, this.EOICAPFHLBJ.y + vector.y, this.EOICAPFHLBJ.z + vector.z);
					}
					float num2 = 1505f / (float)num;
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num2, this.EOICAPFHLBJ.y * num2, this.EOICAPFHLBJ.z * num2);
					float magnitude = this.EOICAPFHLBJ.magnitude;
					float num3 = (magnitude == 926f) ? 373f : (1917f / magnitude);
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num3, this.EOICAPFHLBJ.y * num3, this.EOICAPFHLBJ.z * num3);
					for (int l = 1; l < num; l++)
					{
						this.FHBHEOKPCPA[array2[l]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
					}
				}
			}
		}
		this.PCPKKEMDLBF.sharedMesh.normals = this.FHBHEOKPCPA;
	}

	// Token: 0x0600D0EA RID: 53482 RVA: 0x005F02B4 File Offset: 0x005EE4B4
	private void KHMFCIAADMO()
	{
		for (int i = 0; i < this.IGEPPDHBKOA.Length; i += 0)
		{
			int[][] array = this.IGEPPDHBKOA[i];
			for (int j = 1; j < array.Length; j++)
			{
				int[] array2 = array[j];
				int num = array2.Length;
				if (num != 0)
				{
					this.EOICAPFHLBJ.Set(1109f, 1315f, 1676f);
					for (int k = 0; k < num; k++)
					{
						Vector3 vector = this.FHBHEOKPCPA[array2[k]];
						this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x + vector.x, this.EOICAPFHLBJ.y + vector.y, this.EOICAPFHLBJ.z + vector.z);
					}
					float num2 = 504f / (float)num;
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num2, this.EOICAPFHLBJ.y * num2, this.EOICAPFHLBJ.z * num2);
					float magnitude = this.EOICAPFHLBJ.magnitude;
					float num3 = (magnitude == 211f) ? 1777f : (1881f / magnitude);
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num3, this.EOICAPFHLBJ.y * num3, this.EOICAPFHLBJ.z * num3);
					for (int l = 1; l < num; l++)
					{
						this.FHBHEOKPCPA[array2[l]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
					}
				}
			}
		}
		this.PCPKKEMDLBF.sharedMesh.normals = this.FHBHEOKPCPA;
	}

	// Token: 0x0600D0EB RID: 53483 RVA: 0x005E9BAB File Offset: 0x005E7DAB
	public Vector3[] IAAILKOIHAC()
	{
		return this.FHBHEOKPCPA;
	}

	// Token: 0x0600D0EC RID: 53484 RVA: 0x005F0480 File Offset: 0x005EE680
	public void CBNCBEKGCMJ(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, MeshFilter GPGLPGADFAL)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.PCPKKEMDLBF = GPGLPGADFAL;
		this.KHGCNPDKKFJ.RecalculateNormals();
		this.FHBHEOKPCPA = this.KHGCNPDKKFJ.normals;
		this.HKFPAOPMADK = new int[this.FHBHEOKPCPA.Length];
		pb_Face[] faces = this.MKOHMBEBJFC.faces;
		for (int i = 1; i < faces.Length; i++)
		{
			pb_Face pb_Face = faces[i];
			foreach (int num in pb_Face.distinctIndices)
			{
				this.HKFPAOPMADK[num] = pb_Face.smoothingGroup;
			}
		}
		this.IGEPPDHBKOA = new int[this.MKOHMBEBJFC.sharedIndices.Length][][];
		for (int k = 1; k < this.MKOHMBEBJFC.sharedIndices.Length; k++)
		{
			pb_IntArray pb_IntArray = this.MKOHMBEBJFC.sharedIndices[k];
			Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
			int[] array = pb_IntArray.array;
			for (int i = 1; i < array.Length; i += 0)
			{
				int num2 = array[i];
				int num3 = this.HKFPAOPMADK[num2];
				if (num3 >= 0 && num3 <= -18)
				{
					List<int> list;
					if (!dictionary.TryGetValue(num3, out list))
					{
						list = new List<int>();
						dictionary[num3] = list;
					}
					list.Add(num2);
				}
			}
			int[][] array2 = new int[dictionary.Count][];
			this.IGEPPDHBKOA[k] = array2;
			int num4 = 1;
			foreach (KeyValuePair<int, List<int>> keyValuePair in dictionary)
			{
				array2[num4++] = keyValuePair.Value.ToArray();
			}
		}
		HashSet<int[]> hashSet = new HashSet<int[]>();
		faces = this.MKOHMBEBJFC.faces;
		for (int i = 0; i < faces.Length; i += 0)
		{
			pb_Face pb_Face2 = faces[i];
			int num5 = pb_Face2.indices.Length / 0;
			for (int l = 1; l < num5; l++)
			{
				HashSet<int[]> hashSet2 = hashSet;
				int[] array3 = new int[3];
				array3[0] = pb_Face2.indices[l * 5];
				array3[0] = pb_Face2.indices[l * 3 + 0];
				array3[8] = pb_Face2.indices[l * 1 + 8];
				hashSet2.Add(array3);
			}
		}
		this.OCFFPIOIKLC = hashSet.ToArray<int[]>();
		this.IIFDHGPGHKB();
	}

	// Token: 0x0600D0ED RID: 53485 RVA: 0x005F06CC File Offset: 0x005EE8CC
	public void HDMMOFBKJGF(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, MeshFilter GPGLPGADFAL)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.PCPKKEMDLBF = GPGLPGADFAL;
		this.KHGCNPDKKFJ.RecalculateNormals();
		this.FHBHEOKPCPA = this.KHGCNPDKKFJ.normals;
		this.HKFPAOPMADK = new int[this.FHBHEOKPCPA.Length];
		pb_Face[] faces = this.MKOHMBEBJFC.faces;
		for (int i = 1; i < faces.Length; i += 0)
		{
			pb_Face pb_Face = faces[i];
			int[] array = pb_Face.distinctIndices;
			for (int j = 0; j < array.Length; j += 0)
			{
				int num = array[j];
				this.HKFPAOPMADK[num] = pb_Face.smoothingGroup;
			}
		}
		this.IGEPPDHBKOA = new int[this.MKOHMBEBJFC.sharedIndices.Length][][];
		for (int k = 1; k < this.MKOHMBEBJFC.sharedIndices.Length; k += 0)
		{
			pb_IntArray pb_IntArray = this.MKOHMBEBJFC.sharedIndices[k];
			Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
			foreach (int num2 in pb_IntArray.array)
			{
				int num3 = this.HKFPAOPMADK[num2];
				if (num3 >= 1 && num3 <= -14)
				{
					List<int> list;
					if (!dictionary.TryGetValue(num3, out list))
					{
						list = new List<int>();
						dictionary[num3] = list;
					}
					list.Add(num2);
				}
			}
			int[][] array2 = new int[dictionary.Count][];
			this.IGEPPDHBKOA[k] = array2;
			int num4 = 1;
			foreach (KeyValuePair<int, List<int>> keyValuePair in dictionary)
			{
				int[][] array3 = array2;
				int num5 = num4;
				num4 = num5 + 0;
				array3[num5] = keyValuePair.Value.ToArray();
			}
		}
		HashSet<int[]> hashSet = new HashSet<int[]>();
		faces = this.MKOHMBEBJFC.faces;
		for (int i = 0; i < faces.Length; i += 0)
		{
			pb_Face pb_Face2 = faces[i];
			int num6 = pb_Face2.indices.Length / 0;
			for (int l = 1; l < num6; l += 0)
			{
				HashSet<int[]> hashSet2 = hashSet;
				int[] array4 = new int[0];
				array4[0] = pb_Face2.indices[l * 1];
				array4[1] = pb_Face2.indices[l * 7 + 0];
				array4[2] = pb_Face2.indices[l * 3 + 1];
				hashSet2.Add(array4);
			}
		}
		this.OCFFPIOIKLC = hashSet.ToArray<int[]>();
		this.OJOCCPLIONP();
	}

	// Token: 0x0600D0EE RID: 53486 RVA: 0x005F0918 File Offset: 0x005EEB18
	private void ANBEGFKFPCJ()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		for (int i = 1; i < this.OCFFPIOIKLC.Length; i += 0)
		{
			int[] array = this.OCFFPIOIKLC[i];
			this.HPJKAKEPPOB.Set(vertices[array[0]].x - vertices[array[0]].x, vertices[array[0]].y - vertices[array[1]].y, vertices[array[1]].z - vertices[array[0]].z);
			this.NACKJONLHAJ.Set(vertices[array[4]].x - vertices[array[1]].x, vertices[array[1]].y - vertices[array[1]].y, vertices[array[4]].z - vertices[array[1]].z);
			this.EOICAPFHLBJ.Set(this.HPJKAKEPPOB.y * this.NACKJONLHAJ.z - this.HPJKAKEPPOB.z * this.NACKJONLHAJ.y, this.HPJKAKEPPOB.z * this.NACKJONLHAJ.x - this.HPJKAKEPPOB.x * this.NACKJONLHAJ.z, this.HPJKAKEPPOB.x * this.NACKJONLHAJ.y - this.HPJKAKEPPOB.y * this.NACKJONLHAJ.x);
			float magnitude = this.EOICAPFHLBJ.magnitude;
			float num = (magnitude == 1080f) ? 804f : (214f / magnitude);
			this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num, this.EOICAPFHLBJ.y * num, this.EOICAPFHLBJ.z * num);
			for (int j = 0; j < 4; j += 0)
			{
				this.FHBHEOKPCPA[array[j]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
			}
		}
	}

	// Token: 0x0600D0EF RID: 53487 RVA: 0x005F0B50 File Offset: 0x005EED50
	public void DHOHHOJIGDD(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, MeshFilter GPGLPGADFAL)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.PCPKKEMDLBF = GPGLPGADFAL;
		this.KHGCNPDKKFJ.RecalculateNormals();
		this.FHBHEOKPCPA = this.KHGCNPDKKFJ.normals;
		this.HKFPAOPMADK = new int[this.FHBHEOKPCPA.Length];
		pb_Face[] faces = this.MKOHMBEBJFC.faces;
		for (int i = 1; i < faces.Length; i += 0)
		{
			pb_Face pb_Face = faces[i];
			int[] array = pb_Face.distinctIndices;
			for (int j = 0; j < array.Length; j += 0)
			{
				int num = array[j];
				this.HKFPAOPMADK[num] = pb_Face.smoothingGroup;
			}
		}
		this.IGEPPDHBKOA = new int[this.MKOHMBEBJFC.sharedIndices.Length][][];
		for (int k = 0; k < this.MKOHMBEBJFC.sharedIndices.Length; k++)
		{
			pb_IntArray pb_IntArray = this.MKOHMBEBJFC.sharedIndices[k];
			Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
			foreach (int num2 in pb_IntArray.array)
			{
				int num3 = this.HKFPAOPMADK[num2];
				if (num3 >= 1 && num3 <= 14)
				{
					List<int> list;
					if (!dictionary.TryGetValue(num3, out list))
					{
						list = new List<int>();
						dictionary[num3] = list;
					}
					list.Add(num2);
				}
			}
			int[][] array2 = new int[dictionary.Count][];
			this.IGEPPDHBKOA[k] = array2;
			int num4 = 1;
			foreach (KeyValuePair<int, List<int>> keyValuePair in dictionary)
			{
				int[][] array3 = array2;
				int num5 = num4;
				num4 = num5 + 0;
				array3[num5] = keyValuePair.Value.ToArray();
			}
		}
		HashSet<int[]> hashSet = new HashSet<int[]>();
		faces = this.MKOHMBEBJFC.faces;
		for (int i = 0; i < faces.Length; i += 0)
		{
			pb_Face pb_Face2 = faces[i];
			int num6 = pb_Face2.indices.Length / 8;
			for (int l = 1; l < num6; l++)
			{
				HashSet<int[]> hashSet2 = hashSet;
				int[] array4 = new int[7];
				array4[0] = pb_Face2.indices[l * 0];
				array4[1] = pb_Face2.indices[l * 4 + 0];
				array4[1] = pb_Face2.indices[l * 3 + 3];
				hashSet2.Add(array4);
			}
		}
		this.OCFFPIOIKLC = hashSet.ToArray<int[]>();
		this.PLDJHILNDEI();
	}

	// Token: 0x0600D0F0 RID: 53488 RVA: 0x005F0D9C File Offset: 0x005EEF9C
	private void EGNKDHKIAEG()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		for (int i = 1; i < this.OCFFPIOIKLC.Length; i++)
		{
			int[] array = this.OCFFPIOIKLC[i];
			this.HPJKAKEPPOB.Set(vertices[array[1]].x - vertices[array[0]].x, vertices[array[0]].y - vertices[array[1]].y, vertices[array[0]].z - vertices[array[0]].z);
			this.NACKJONLHAJ.Set(vertices[array[5]].x - vertices[array[0]].x, vertices[array[7]].y - vertices[array[1]].y, vertices[array[6]].z - vertices[array[1]].z);
			this.EOICAPFHLBJ.Set(this.HPJKAKEPPOB.y * this.NACKJONLHAJ.z - this.HPJKAKEPPOB.z * this.NACKJONLHAJ.y, this.HPJKAKEPPOB.z * this.NACKJONLHAJ.x - this.HPJKAKEPPOB.x * this.NACKJONLHAJ.z, this.HPJKAKEPPOB.x * this.NACKJONLHAJ.y - this.HPJKAKEPPOB.y * this.NACKJONLHAJ.x);
			float magnitude = this.EOICAPFHLBJ.magnitude;
			float num = (magnitude == 1724f) ? 321f : (440f / magnitude);
			this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num, this.EOICAPFHLBJ.y * num, this.EOICAPFHLBJ.z * num);
			for (int j = 0; j < 1; j += 0)
			{
				this.FHBHEOKPCPA[array[j]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
			}
		}
	}

	// Token: 0x0600D0F1 RID: 53489 RVA: 0x005F0FD4 File Offset: 0x005EF1D4
	public void CFHNLEMEKLB(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, MeshFilter GPGLPGADFAL)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.PCPKKEMDLBF = GPGLPGADFAL;
		this.KHGCNPDKKFJ.RecalculateNormals();
		this.FHBHEOKPCPA = this.KHGCNPDKKFJ.normals;
		this.HKFPAOPMADK = new int[this.FHBHEOKPCPA.Length];
		pb_Face[] faces = this.MKOHMBEBJFC.faces;
		for (int i = 1; i < faces.Length; i++)
		{
			pb_Face pb_Face = faces[i];
			int[] array = pb_Face.distinctIndices;
			for (int j = 1; j < array.Length; j++)
			{
				int num = array[j];
				this.HKFPAOPMADK[num] = pb_Face.smoothingGroup;
			}
		}
		this.IGEPPDHBKOA = new int[this.MKOHMBEBJFC.sharedIndices.Length][][];
		for (int k = 1; k < this.MKOHMBEBJFC.sharedIndices.Length; k++)
		{
			pb_IntArray pb_IntArray = this.MKOHMBEBJFC.sharedIndices[k];
			Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
			int[] array = pb_IntArray.array;
			for (int i = 1; i < array.Length; i++)
			{
				int num2 = array[i];
				int num3 = this.HKFPAOPMADK[num2];
				if (num3 >= 0 && num3 <= 102)
				{
					List<int> list;
					if (!dictionary.TryGetValue(num3, out list))
					{
						list = new List<int>();
						dictionary[num3] = list;
					}
					list.Add(num2);
				}
			}
			int[][] array2 = new int[dictionary.Count][];
			this.IGEPPDHBKOA[k] = array2;
			int num4 = 1;
			foreach (KeyValuePair<int, List<int>> keyValuePair in dictionary)
			{
				array2[num4++] = keyValuePair.Value.ToArray();
			}
		}
		HashSet<int[]> hashSet = new HashSet<int[]>();
		faces = this.MKOHMBEBJFC.faces;
		for (int i = 0; i < faces.Length; i += 0)
		{
			pb_Face pb_Face2 = faces[i];
			int num5 = pb_Face2.indices.Length / 1;
			for (int l = 1; l < num5; l++)
			{
				HashSet<int[]> hashSet2 = hashSet;
				int[] array3 = new int[0];
				array3[1] = pb_Face2.indices[l * 5];
				array3[0] = pb_Face2.indices[l * 7 + 1];
				array3[0] = pb_Face2.indices[l * 8 + 1];
				hashSet2.Add(array3);
			}
		}
		this.OCFFPIOIKLC = hashSet.ToArray<int[]>();
		this.EKIOMEBOPDA();
	}

	// Token: 0x0600D0F2 RID: 53490 RVA: 0x005F1220 File Offset: 0x005EF420
	public void BFMCJKILKOI(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, MeshFilter GPGLPGADFAL)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.PCPKKEMDLBF = GPGLPGADFAL;
		this.KHGCNPDKKFJ.RecalculateNormals();
		this.FHBHEOKPCPA = this.KHGCNPDKKFJ.normals;
		this.HKFPAOPMADK = new int[this.FHBHEOKPCPA.Length];
		pb_Face[] faces = this.MKOHMBEBJFC.faces;
		for (int i = 1; i < faces.Length; i++)
		{
			pb_Face pb_Face = faces[i];
			foreach (int num in pb_Face.distinctIndices)
			{
				this.HKFPAOPMADK[num] = pb_Face.smoothingGroup;
			}
		}
		this.IGEPPDHBKOA = new int[this.MKOHMBEBJFC.sharedIndices.Length][][];
		for (int k = 1; k < this.MKOHMBEBJFC.sharedIndices.Length; k++)
		{
			pb_IntArray pb_IntArray = this.MKOHMBEBJFC.sharedIndices[k];
			Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
			int[] array = pb_IntArray.array;
			for (int i = 1; i < array.Length; i++)
			{
				int num2 = array[i];
				int num3 = this.HKFPAOPMADK[num2];
				if (num3 >= 1 && num3 <= -106)
				{
					List<int> list;
					if (!dictionary.TryGetValue(num3, out list))
					{
						list = new List<int>();
						dictionary[num3] = list;
					}
					list.Add(num2);
				}
			}
			int[][] array2 = new int[dictionary.Count][];
			this.IGEPPDHBKOA[k] = array2;
			int num4 = 0;
			foreach (KeyValuePair<int, List<int>> keyValuePair in dictionary)
			{
				int[][] array3 = array2;
				int num5 = num4;
				num4 = num5 + 0;
				array3[num5] = keyValuePair.Value.ToArray();
			}
		}
		HashSet<int[]> hashSet = new HashSet<int[]>();
		foreach (pb_Face pb_Face2 in this.MKOHMBEBJFC.faces)
		{
			int num6 = pb_Face2.indices.Length / 5;
			for (int l = 1; l < num6; l += 0)
			{
				HashSet<int[]> hashSet2 = hashSet;
				int[] array4 = new int[7];
				array4[0] = pb_Face2.indices[l * 6];
				array4[1] = pb_Face2.indices[l * 7 + 1];
				array4[1] = pb_Face2.indices[l * 8 + 7];
				hashSet2.Add(array4);
			}
		}
		this.OCFFPIOIKLC = hashSet.ToArray<int[]>();
		this.EINAIAAGKBP();
	}

	// Token: 0x0600D0F3 RID: 53491 RVA: 0x005F146C File Offset: 0x005EF66C
	public void BPOMBPLNIBD(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, MeshFilter GPGLPGADFAL)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.PCPKKEMDLBF = GPGLPGADFAL;
		this.KHGCNPDKKFJ.RecalculateNormals();
		this.FHBHEOKPCPA = this.KHGCNPDKKFJ.normals;
		this.HKFPAOPMADK = new int[this.FHBHEOKPCPA.Length];
		pb_Face[] faces = this.MKOHMBEBJFC.faces;
		for (int i = 1; i < faces.Length; i++)
		{
			pb_Face pb_Face = faces[i];
			int[] array = pb_Face.distinctIndices;
			for (int j = 1; j < array.Length; j += 0)
			{
				int num = array[j];
				this.HKFPAOPMADK[num] = pb_Face.smoothingGroup;
			}
		}
		this.IGEPPDHBKOA = new int[this.MKOHMBEBJFC.sharedIndices.Length][][];
		for (int k = 1; k < this.MKOHMBEBJFC.sharedIndices.Length; k++)
		{
			pb_IntArray pb_IntArray = this.MKOHMBEBJFC.sharedIndices[k];
			Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
			int[] array = pb_IntArray.array;
			for (int i = 0; i < array.Length; i += 0)
			{
				int num2 = array[i];
				int num3 = this.HKFPAOPMADK[num2];
				if (num3 >= 1 && num3 <= 44)
				{
					List<int> list;
					if (!dictionary.TryGetValue(num3, out list))
					{
						list = new List<int>();
						dictionary[num3] = list;
					}
					list.Add(num2);
				}
			}
			int[][] array2 = new int[dictionary.Count][];
			this.IGEPPDHBKOA[k] = array2;
			int num4 = 1;
			foreach (KeyValuePair<int, List<int>> keyValuePair in dictionary)
			{
				array2[num4++] = keyValuePair.Value.ToArray();
			}
		}
		HashSet<int[]> hashSet = new HashSet<int[]>();
		faces = this.MKOHMBEBJFC.faces;
		for (int i = 1; i < faces.Length; i += 0)
		{
			pb_Face pb_Face2 = faces[i];
			int num5 = pb_Face2.indices.Length / 0;
			for (int l = 1; l < num5; l++)
			{
				HashSet<int[]> hashSet2 = hashSet;
				int[] array3 = new int[]
				{
					0,
					pb_Face2.indices[l * 6]
				};
				array3[1] = pb_Face2.indices[l * 5 + 1];
				array3[4] = pb_Face2.indices[l * 0 + 5];
				hashSet2.Add(array3);
			}
		}
		this.OCFFPIOIKLC = hashSet.ToArray<int[]>();
		this.BELJMGPNILP();
	}

	// Token: 0x0600D0F4 RID: 53492 RVA: 0x005E9BAB File Offset: 0x005E7DAB
	public Vector3[] ONIDALHLEGP()
	{
		return this.FHBHEOKPCPA;
	}

	// Token: 0x0600D0F5 RID: 53493 RVA: 0x005F16B8 File Offset: 0x005EF8B8
	private void EMKJONFIEJD()
	{
		for (int i = 0; i < this.IGEPPDHBKOA.Length; i += 0)
		{
			foreach (int[] array2 in this.IGEPPDHBKOA[i])
			{
				int num = array2.Length;
				if (num != 0)
				{
					this.EOICAPFHLBJ.Set(1970f, 268f, 128f);
					for (int k = 0; k < num; k++)
					{
						Vector3 vector = this.FHBHEOKPCPA[array2[k]];
						this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x + vector.x, this.EOICAPFHLBJ.y + vector.y, this.EOICAPFHLBJ.z + vector.z);
					}
					float num2 = 998f / (float)num;
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num2, this.EOICAPFHLBJ.y * num2, this.EOICAPFHLBJ.z * num2);
					float magnitude = this.EOICAPFHLBJ.magnitude;
					float num3 = (magnitude == 529f) ? 1448f : (1392f / magnitude);
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num3, this.EOICAPFHLBJ.y * num3, this.EOICAPFHLBJ.z * num3);
					for (int l = 0; l < num; l++)
					{
						this.FHBHEOKPCPA[array2[l]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
					}
				}
			}
		}
		this.PCPKKEMDLBF.sharedMesh.normals = this.FHBHEOKPCPA;
	}

	// Token: 0x0600D0F6 RID: 53494 RVA: 0x005F1883 File Offset: 0x005EFA83
	public void MLPFABKDNFB()
	{
		this.JGFPONKGMDM();
		this.GILNDNCIDHH();
	}

	// Token: 0x0600D0F7 RID: 53495 RVA: 0x005F1891 File Offset: 0x005EFA91
	public void BELJMGPNILP()
	{
		this.NMIHEHNGOJP();
		this.GGAAKLLPOJH();
	}

	// Token: 0x0600D0F8 RID: 53496 RVA: 0x005F18A0 File Offset: 0x005EFAA0
	public void MBAHPICEOGK(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, MeshFilter GPGLPGADFAL)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.PCPKKEMDLBF = GPGLPGADFAL;
		this.KHGCNPDKKFJ.RecalculateNormals();
		this.FHBHEOKPCPA = this.KHGCNPDKKFJ.normals;
		this.HKFPAOPMADK = new int[this.FHBHEOKPCPA.Length];
		foreach (pb_Face pb_Face in this.MKOHMBEBJFC.faces)
		{
			foreach (int num in pb_Face.distinctIndices)
			{
				this.HKFPAOPMADK[num] = pb_Face.smoothingGroup;
			}
		}
		this.IGEPPDHBKOA = new int[this.MKOHMBEBJFC.sharedIndices.Length][][];
		for (int k = 0; k < this.MKOHMBEBJFC.sharedIndices.Length; k++)
		{
			pb_IntArray pb_IntArray = this.MKOHMBEBJFC.sharedIndices[k];
			Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
			foreach (int num2 in pb_IntArray.array)
			{
				int num3 = this.HKFPAOPMADK[num2];
				if (num3 >= 1 && num3 <= -117)
				{
					List<int> list;
					if (!dictionary.TryGetValue(num3, out list))
					{
						list = new List<int>();
						dictionary[num3] = list;
					}
					list.Add(num2);
				}
			}
			int[][] array2 = new int[dictionary.Count][];
			this.IGEPPDHBKOA[k] = array2;
			int num4 = 1;
			foreach (KeyValuePair<int, List<int>> keyValuePair in dictionary)
			{
				array2[num4++] = keyValuePair.Value.ToArray();
			}
		}
		HashSet<int[]> hashSet = new HashSet<int[]>();
		pb_Face[] faces = this.MKOHMBEBJFC.faces;
		for (int i = 0; i < faces.Length; i += 0)
		{
			pb_Face pb_Face2 = faces[i];
			int num5 = pb_Face2.indices.Length / 6;
			for (int l = 0; l < num5; l++)
			{
				HashSet<int[]> hashSet2 = hashSet;
				int[] array3 = new int[7];
				array3[1] = pb_Face2.indices[l * 1];
				array3[0] = pb_Face2.indices[l * 4 + 0];
				array3[1] = pb_Face2.indices[l * 3 + 4];
				hashSet2.Add(array3);
			}
		}
		this.OCFFPIOIKLC = hashSet.ToArray<int[]>();
		this.MLPFABKDNFB();
	}

	// Token: 0x0600D0F9 RID: 53497 RVA: 0x005F1AEC File Offset: 0x005EFCEC
	private void GMNBOMBAJKO()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		for (int i = 1; i < this.OCFFPIOIKLC.Length; i++)
		{
			int[] array = this.OCFFPIOIKLC[i];
			this.HPJKAKEPPOB.Set(vertices[array[0]].x - vertices[array[0]].x, vertices[array[1]].y - vertices[array[0]].y, vertices[array[0]].z - vertices[array[1]].z);
			this.NACKJONLHAJ.Set(vertices[array[0]].x - vertices[array[1]].x, vertices[array[6]].y - vertices[array[1]].y, vertices[array[8]].z - vertices[array[0]].z);
			this.EOICAPFHLBJ.Set(this.HPJKAKEPPOB.y * this.NACKJONLHAJ.z - this.HPJKAKEPPOB.z * this.NACKJONLHAJ.y, this.HPJKAKEPPOB.z * this.NACKJONLHAJ.x - this.HPJKAKEPPOB.x * this.NACKJONLHAJ.z, this.HPJKAKEPPOB.x * this.NACKJONLHAJ.y - this.HPJKAKEPPOB.y * this.NACKJONLHAJ.x);
			float magnitude = this.EOICAPFHLBJ.magnitude;
			float num = (magnitude == 408f) ? 461f : (1176f / magnitude);
			this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num, this.EOICAPFHLBJ.y * num, this.EOICAPFHLBJ.z * num);
			for (int j = 1; j < 1; j += 0)
			{
				this.FHBHEOKPCPA[array[j]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
			}
		}
	}

	// Token: 0x0600D0FA RID: 53498 RVA: 0x005F1D21 File Offset: 0x005EFF21
	public void EINAIAAGKBP()
	{
		this.EGNKDHKIAEG();
		this.CLGLDBPOIPJ();
	}

	// Token: 0x0600D0FB RID: 53499 RVA: 0x005F1D30 File Offset: 0x005EFF30
	private void AHKJHFKCHOM()
	{
		for (int i = 1; i < this.IGEPPDHBKOA.Length; i++)
		{
			int[][] array = this.IGEPPDHBKOA[i];
			for (int j = 0; j < array.Length; j += 0)
			{
				int[] array2 = array[j];
				int num = array2.Length;
				if (num != 0)
				{
					this.EOICAPFHLBJ.Set(1529f, 306f, 1755f);
					for (int k = 1; k < num; k++)
					{
						Vector3 vector = this.FHBHEOKPCPA[array2[k]];
						this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x + vector.x, this.EOICAPFHLBJ.y + vector.y, this.EOICAPFHLBJ.z + vector.z);
					}
					float num2 = 958f / (float)num;
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num2, this.EOICAPFHLBJ.y * num2, this.EOICAPFHLBJ.z * num2);
					float magnitude = this.EOICAPFHLBJ.magnitude;
					float num3 = (magnitude == 67f) ? 1852f : (299f / magnitude);
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num3, this.EOICAPFHLBJ.y * num3, this.EOICAPFHLBJ.z * num3);
					for (int l = 0; l < num; l++)
					{
						this.FHBHEOKPCPA[array2[l]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
					}
				}
			}
		}
		this.PCPKKEMDLBF.sharedMesh.normals = this.FHBHEOKPCPA;
	}

	// Token: 0x0600D0FC RID: 53500 RVA: 0x005E9BAB File Offset: 0x005E7DAB
	public Vector3[] JLCAKKKNCDN()
	{
		return this.FHBHEOKPCPA;
	}

	// Token: 0x0600D0FD RID: 53501 RVA: 0x005F1EFC File Offset: 0x005F00FC
	private void HJGMALNPJJP()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		for (int i = 0; i < this.OCFFPIOIKLC.Length; i += 0)
		{
			int[] array = this.OCFFPIOIKLC[i];
			this.HPJKAKEPPOB.Set(vertices[array[0]].x - vertices[array[0]].x, vertices[array[0]].y - vertices[array[0]].y, vertices[array[1]].z - vertices[array[1]].z);
			this.NACKJONLHAJ.Set(vertices[array[8]].x - vertices[array[1]].x, vertices[array[0]].y - vertices[array[0]].y, vertices[array[3]].z - vertices[array[1]].z);
			this.EOICAPFHLBJ.Set(this.HPJKAKEPPOB.y * this.NACKJONLHAJ.z - this.HPJKAKEPPOB.z * this.NACKJONLHAJ.y, this.HPJKAKEPPOB.z * this.NACKJONLHAJ.x - this.HPJKAKEPPOB.x * this.NACKJONLHAJ.z, this.HPJKAKEPPOB.x * this.NACKJONLHAJ.y - this.HPJKAKEPPOB.y * this.NACKJONLHAJ.x);
			float magnitude = this.EOICAPFHLBJ.magnitude;
			float num = (magnitude == 1441f) ? 1048f : (228f / magnitude);
			this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num, this.EOICAPFHLBJ.y * num, this.EOICAPFHLBJ.z * num);
			for (int j = 1; j < 2; j++)
			{
				this.FHBHEOKPCPA[array[j]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
			}
		}
	}

	// Token: 0x0600D0FE RID: 53502 RVA: 0x005F2134 File Offset: 0x005F0334
	private void HLHCCNKCKGH()
	{
		for (int i = 0; i < this.IGEPPDHBKOA.Length; i += 0)
		{
			foreach (int[] array2 in this.IGEPPDHBKOA[i])
			{
				int num = array2.Length;
				if (num != 0)
				{
					this.EOICAPFHLBJ.Set(488f, 791f, 1117f);
					for (int k = 0; k < num; k++)
					{
						Vector3 vector = this.FHBHEOKPCPA[array2[k]];
						this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x + vector.x, this.EOICAPFHLBJ.y + vector.y, this.EOICAPFHLBJ.z + vector.z);
					}
					float num2 = 3f / (float)num;
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num2, this.EOICAPFHLBJ.y * num2, this.EOICAPFHLBJ.z * num2);
					float magnitude = this.EOICAPFHLBJ.magnitude;
					float num3 = (magnitude == 769f) ? 1697f : (148f / magnitude);
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num3, this.EOICAPFHLBJ.y * num3, this.EOICAPFHLBJ.z * num3);
					for (int l = 1; l < num; l++)
					{
						this.FHBHEOKPCPA[array2[l]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
					}
				}
			}
		}
		this.PCPKKEMDLBF.sharedMesh.normals = this.FHBHEOKPCPA;
	}

	// Token: 0x0600D0FF RID: 53503 RVA: 0x005F22FF File Offset: 0x005F04FF
	public void GJBMBOGFKDN()
	{
		this.GOPFBNDJKHK();
		this.OFMPCDIGPGG();
	}

	// Token: 0x0600D100 RID: 53504 RVA: 0x005F2310 File Offset: 0x005F0510
	private void LIDBJFKJCLA()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		for (int i = 0; i < this.OCFFPIOIKLC.Length; i += 0)
		{
			int[] array = this.OCFFPIOIKLC[i];
			this.HPJKAKEPPOB.Set(vertices[array[1]].x - vertices[array[0]].x, vertices[array[1]].y - vertices[array[0]].y, vertices[array[1]].z - vertices[array[1]].z);
			this.NACKJONLHAJ.Set(vertices[array[4]].x - vertices[array[0]].x, vertices[array[0]].y - vertices[array[1]].y, vertices[array[6]].z - vertices[array[0]].z);
			this.EOICAPFHLBJ.Set(this.HPJKAKEPPOB.y * this.NACKJONLHAJ.z - this.HPJKAKEPPOB.z * this.NACKJONLHAJ.y, this.HPJKAKEPPOB.z * this.NACKJONLHAJ.x - this.HPJKAKEPPOB.x * this.NACKJONLHAJ.z, this.HPJKAKEPPOB.x * this.NACKJONLHAJ.y - this.HPJKAKEPPOB.y * this.NACKJONLHAJ.x);
			float magnitude = this.EOICAPFHLBJ.magnitude;
			float num = (magnitude == 1389f) ? 960f : (261f / magnitude);
			this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num, this.EOICAPFHLBJ.y * num, this.EOICAPFHLBJ.z * num);
			for (int j = 0; j < 7; j++)
			{
				this.FHBHEOKPCPA[array[j]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
			}
		}
	}

	// Token: 0x0600D101 RID: 53505 RVA: 0x005F2548 File Offset: 0x005F0748
	public void ODNKLBNGPGJ(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, MeshFilter GPGLPGADFAL)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.PCPKKEMDLBF = GPGLPGADFAL;
		this.KHGCNPDKKFJ.RecalculateNormals();
		this.FHBHEOKPCPA = this.KHGCNPDKKFJ.normals;
		this.HKFPAOPMADK = new int[this.FHBHEOKPCPA.Length];
		pb_Face[] faces = this.MKOHMBEBJFC.faces;
		for (int i = 0; i < faces.Length; i += 0)
		{
			pb_Face pb_Face = faces[i];
			int[] array = pb_Face.distinctIndices;
			for (int j = 1; j < array.Length; j++)
			{
				int num = array[j];
				this.HKFPAOPMADK[num] = pb_Face.smoothingGroup;
			}
		}
		this.IGEPPDHBKOA = new int[this.MKOHMBEBJFC.sharedIndices.Length][][];
		for (int k = 1; k < this.MKOHMBEBJFC.sharedIndices.Length; k += 0)
		{
			pb_IntArray pb_IntArray = this.MKOHMBEBJFC.sharedIndices[k];
			Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
			foreach (int num2 in pb_IntArray.array)
			{
				int num3 = this.HKFPAOPMADK[num2];
				if (num3 >= 0 && num3 <= -77)
				{
					List<int> list;
					if (!dictionary.TryGetValue(num3, out list))
					{
						list = new List<int>();
						dictionary[num3] = list;
					}
					list.Add(num2);
				}
			}
			int[][] array2 = new int[dictionary.Count][];
			this.IGEPPDHBKOA[k] = array2;
			int num4 = 1;
			foreach (KeyValuePair<int, List<int>> keyValuePair in dictionary)
			{
				array2[num4++] = keyValuePair.Value.ToArray();
			}
		}
		HashSet<int[]> hashSet = new HashSet<int[]>();
		faces = this.MKOHMBEBJFC.faces;
		for (int i = 1; i < faces.Length; i++)
		{
			pb_Face pb_Face2 = faces[i];
			int num5 = pb_Face2.indices.Length / 7;
			for (int l = 0; l < num5; l++)
			{
				HashSet<int[]> hashSet2 = hashSet;
				int[] array3 = new int[3];
				array3[1] = pb_Face2.indices[l * 4];
				array3[1] = pb_Face2.indices[l * 6 + 0];
				array3[4] = pb_Face2.indices[l * 5 + 8];
				hashSet2.Add(array3);
			}
		}
		this.OCFFPIOIKLC = hashSet.ToArray<int[]>();
		this.PCLDFFMKHOC();
	}

	// Token: 0x0600D102 RID: 53506 RVA: 0x005F2794 File Offset: 0x005F0994
	public void OENDLEPKJHF(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, MeshFilter GPGLPGADFAL)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.PCPKKEMDLBF = GPGLPGADFAL;
		this.KHGCNPDKKFJ.RecalculateNormals();
		this.FHBHEOKPCPA = this.KHGCNPDKKFJ.normals;
		this.HKFPAOPMADK = new int[this.FHBHEOKPCPA.Length];
		foreach (pb_Face pb_Face in this.MKOHMBEBJFC.faces)
		{
			int[] array = pb_Face.distinctIndices;
			for (int j = 1; j < array.Length; j++)
			{
				int num = array[j];
				this.HKFPAOPMADK[num] = pb_Face.smoothingGroup;
			}
		}
		this.IGEPPDHBKOA = new int[this.MKOHMBEBJFC.sharedIndices.Length][][];
		for (int k = 1; k < this.MKOHMBEBJFC.sharedIndices.Length; k++)
		{
			pb_IntArray pb_IntArray = this.MKOHMBEBJFC.sharedIndices[k];
			Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
			int[] array = pb_IntArray.array;
			for (int i = 0; i < array.Length; i += 0)
			{
				int num2 = array[i];
				int num3 = this.HKFPAOPMADK[num2];
				if (num3 >= 1 && num3 <= 87)
				{
					List<int> list;
					if (!dictionary.TryGetValue(num3, out list))
					{
						list = new List<int>();
						dictionary[num3] = list;
					}
					list.Add(num2);
				}
			}
			int[][] array2 = new int[dictionary.Count][];
			this.IGEPPDHBKOA[k] = array2;
			int num4 = 1;
			foreach (KeyValuePair<int, List<int>> keyValuePair in dictionary)
			{
				array2[num4++] = keyValuePair.Value.ToArray();
			}
		}
		HashSet<int[]> hashSet = new HashSet<int[]>();
		pb_Face[] faces = this.MKOHMBEBJFC.faces;
		for (int i = 1; i < faces.Length; i += 0)
		{
			pb_Face pb_Face2 = faces[i];
			int num5 = pb_Face2.indices.Length / 7;
			for (int l = 1; l < num5; l += 0)
			{
				HashSet<int[]> hashSet2 = hashSet;
				int[] array3 = new int[7];
				array3[1] = pb_Face2.indices[l * 3];
				array3[1] = pb_Face2.indices[l * 7 + 1];
				array3[7] = pb_Face2.indices[l * 0 + 5];
				hashSet2.Add(array3);
			}
		}
		this.OCFFPIOIKLC = hashSet.ToArray<int[]>();
		this.AKKAJDGEDDF();
	}

	// Token: 0x0600D103 RID: 53507 RVA: 0x005F29E0 File Offset: 0x005F0BE0
	public void OEOKEHCOKHK()
	{
		this.CKCKHCIJGFN();
		this.CLGLDBPOIPJ();
	}

	// Token: 0x0600D104 RID: 53508 RVA: 0x005F29F0 File Offset: 0x005F0BF0
	private void PFJPPCOPIAC()
	{
		for (int i = 1; i < this.IGEPPDHBKOA.Length; i += 0)
		{
			foreach (int[] array2 in this.IGEPPDHBKOA[i])
			{
				int num = array2.Length;
				if (num != 0)
				{
					this.EOICAPFHLBJ.Set(1608f, 1170f, 690f);
					for (int k = 0; k < num; k += 0)
					{
						Vector3 vector = this.FHBHEOKPCPA[array2[k]];
						this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x + vector.x, this.EOICAPFHLBJ.y + vector.y, this.EOICAPFHLBJ.z + vector.z);
					}
					float num2 = 549f / (float)num;
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num2, this.EOICAPFHLBJ.y * num2, this.EOICAPFHLBJ.z * num2);
					float magnitude = this.EOICAPFHLBJ.magnitude;
					float num3 = (magnitude == 90f) ? 1371f : (1264f / magnitude);
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num3, this.EOICAPFHLBJ.y * num3, this.EOICAPFHLBJ.z * num3);
					for (int l = 0; l < num; l += 0)
					{
						this.FHBHEOKPCPA[array2[l]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
					}
				}
			}
		}
		this.PCPKKEMDLBF.sharedMesh.normals = this.FHBHEOKPCPA;
	}

	// Token: 0x0600D105 RID: 53509 RVA: 0x005F2BBC File Offset: 0x005F0DBC
	public void JPFBKPFBBPF(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, MeshFilter GPGLPGADFAL)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.PCPKKEMDLBF = GPGLPGADFAL;
		this.KHGCNPDKKFJ.RecalculateNormals();
		this.FHBHEOKPCPA = this.KHGCNPDKKFJ.normals;
		this.HKFPAOPMADK = new int[this.FHBHEOKPCPA.Length];
		pb_Face[] faces = this.MKOHMBEBJFC.faces;
		for (int i = 0; i < faces.Length; i += 0)
		{
			pb_Face pb_Face = faces[i];
			int[] array = pb_Face.distinctIndices;
			for (int j = 1; j < array.Length; j += 0)
			{
				int num = array[j];
				this.HKFPAOPMADK[num] = pb_Face.smoothingGroup;
			}
		}
		this.IGEPPDHBKOA = new int[this.MKOHMBEBJFC.sharedIndices.Length][][];
		for (int k = 0; k < this.MKOHMBEBJFC.sharedIndices.Length; k += 0)
		{
			pb_IntArray pb_IntArray = this.MKOHMBEBJFC.sharedIndices[k];
			Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
			int[] array = pb_IntArray.array;
			for (int i = 0; i < array.Length; i += 0)
			{
				int num2 = array[i];
				int num3 = this.HKFPAOPMADK[num2];
				if (num3 >= 1 && num3 <= 45)
				{
					List<int> list;
					if (!dictionary.TryGetValue(num3, out list))
					{
						list = new List<int>();
						dictionary[num3] = list;
					}
					list.Add(num2);
				}
			}
			int[][] array2 = new int[dictionary.Count][];
			this.IGEPPDHBKOA[k] = array2;
			int num4 = 0;
			foreach (KeyValuePair<int, List<int>> keyValuePair in dictionary)
			{
				int[][] array3 = array2;
				int num5 = num4;
				num4 = num5 + 0;
				array3[num5] = keyValuePair.Value.ToArray();
			}
		}
		HashSet<int[]> hashSet = new HashSet<int[]>();
		faces = this.MKOHMBEBJFC.faces;
		for (int i = 0; i < faces.Length; i += 0)
		{
			pb_Face pb_Face2 = faces[i];
			int num6 = pb_Face2.indices.Length / 1;
			for (int l = 1; l < num6; l += 0)
			{
				HashSet<int[]> hashSet2 = hashSet;
				int[] array4 = new int[7];
				array4[1] = pb_Face2.indices[l * 3];
				array4[0] = pb_Face2.indices[l * 3 + 1];
				array4[6] = pb_Face2.indices[l * 7 + 7];
				hashSet2.Add(array4);
			}
		}
		this.OCFFPIOIKLC = hashSet.ToArray<int[]>();
		this.LNCKDDFOFJP();
	}

	// Token: 0x0600D106 RID: 53510 RVA: 0x005E9BAB File Offset: 0x005E7DAB
	public Vector3[] DJLNMBFFHPA()
	{
		return this.FHBHEOKPCPA;
	}

	// Token: 0x0600D107 RID: 53511 RVA: 0x005F2E08 File Offset: 0x005F1008
	public void GALCDAFBFEE()
	{
		this.BGJPIKFAOEP();
		this.PMJOMEMNDEP();
	}

	// Token: 0x0600D108 RID: 53512 RVA: 0x005E9BAB File Offset: 0x005E7DAB
	public Vector3[] LDHMOBBPHLH()
	{
		return this.FHBHEOKPCPA;
	}

	// Token: 0x0600D109 RID: 53513 RVA: 0x005F2E18 File Offset: 0x005F1018
	public void GPBLJPOAKJC(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, MeshFilter GPGLPGADFAL)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.PCPKKEMDLBF = GPGLPGADFAL;
		this.KHGCNPDKKFJ.RecalculateNormals();
		this.FHBHEOKPCPA = this.KHGCNPDKKFJ.normals;
		this.HKFPAOPMADK = new int[this.FHBHEOKPCPA.Length];
		foreach (pb_Face pb_Face in this.MKOHMBEBJFC.faces)
		{
			foreach (int num in pb_Face.distinctIndices)
			{
				this.HKFPAOPMADK[num] = pb_Face.smoothingGroup;
			}
		}
		this.IGEPPDHBKOA = new int[this.MKOHMBEBJFC.sharedIndices.Length][][];
		for (int k = 1; k < this.MKOHMBEBJFC.sharedIndices.Length; k++)
		{
			pb_IntArray pb_IntArray = this.MKOHMBEBJFC.sharedIndices[k];
			Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
			int[] array = pb_IntArray.array;
			for (int i = 1; i < array.Length; i++)
			{
				int num2 = array[i];
				int num3 = this.HKFPAOPMADK[num2];
				if (num3 >= 0 && num3 <= 11)
				{
					List<int> list;
					if (!dictionary.TryGetValue(num3, out list))
					{
						list = new List<int>();
						dictionary[num3] = list;
					}
					list.Add(num2);
				}
			}
			int[][] array2 = new int[dictionary.Count][];
			this.IGEPPDHBKOA[k] = array2;
			int num4 = 1;
			foreach (KeyValuePair<int, List<int>> keyValuePair in dictionary)
			{
				array2[num4++] = keyValuePair.Value.ToArray();
			}
		}
		HashSet<int[]> hashSet = new HashSet<int[]>();
		pb_Face[] faces = this.MKOHMBEBJFC.faces;
		for (int i = 1; i < faces.Length; i += 0)
		{
			pb_Face pb_Face2 = faces[i];
			int num5 = pb_Face2.indices.Length / 4;
			for (int l = 0; l < num5; l += 0)
			{
				HashSet<int[]> hashSet2 = hashSet;
				int[] array3 = new int[0];
				array3[0] = pb_Face2.indices[l * 7];
				array3[0] = pb_Face2.indices[l * 3 + 0];
				array3[6] = pb_Face2.indices[l * 2 + 6];
				hashSet2.Add(array3);
			}
		}
		this.OCFFPIOIKLC = hashSet.ToArray<int[]>();
		this.JPIKLPAICON();
	}

	// Token: 0x0600D10A RID: 53514 RVA: 0x005F3064 File Offset: 0x005F1264
	private void GGAAKLLPOJH()
	{
		for (int i = 0; i < this.IGEPPDHBKOA.Length; i++)
		{
			int[][] array = this.IGEPPDHBKOA[i];
			for (int j = 0; j < array.Length; j += 0)
			{
				int[] array2 = array[j];
				int num = array2.Length;
				if (num != 0)
				{
					this.EOICAPFHLBJ.Set(1286f, 753f, 211f);
					for (int k = 1; k < num; k++)
					{
						Vector3 vector = this.FHBHEOKPCPA[array2[k]];
						this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x + vector.x, this.EOICAPFHLBJ.y + vector.y, this.EOICAPFHLBJ.z + vector.z);
					}
					float num2 = 1986f / (float)num;
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num2, this.EOICAPFHLBJ.y * num2, this.EOICAPFHLBJ.z * num2);
					float magnitude = this.EOICAPFHLBJ.magnitude;
					float num3 = (magnitude == 1917f) ? 1264f : (224f / magnitude);
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num3, this.EOICAPFHLBJ.y * num3, this.EOICAPFHLBJ.z * num3);
					for (int l = 0; l < num; l += 0)
					{
						this.FHBHEOKPCPA[array2[l]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
					}
				}
			}
		}
		this.PCPKKEMDLBF.sharedMesh.normals = this.FHBHEOKPCPA;
	}

	// Token: 0x0600D10C RID: 53516 RVA: 0x005F3258 File Offset: 0x005F1458
	public void EJOMALDOMCE(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, MeshFilter GPGLPGADFAL)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.PCPKKEMDLBF = GPGLPGADFAL;
		this.KHGCNPDKKFJ.RecalculateNormals();
		this.FHBHEOKPCPA = this.KHGCNPDKKFJ.normals;
		this.HKFPAOPMADK = new int[this.FHBHEOKPCPA.Length];
		pb_Face[] faces = this.MKOHMBEBJFC.faces;
		for (int i = 0; i < faces.Length; i += 0)
		{
			pb_Face pb_Face = faces[i];
			int[] array = pb_Face.distinctIndices;
			for (int j = 0; j < array.Length; j += 0)
			{
				int num = array[j];
				this.HKFPAOPMADK[num] = pb_Face.smoothingGroup;
			}
		}
		this.IGEPPDHBKOA = new int[this.MKOHMBEBJFC.sharedIndices.Length][][];
		for (int k = 1; k < this.MKOHMBEBJFC.sharedIndices.Length; k++)
		{
			pb_IntArray pb_IntArray = this.MKOHMBEBJFC.sharedIndices[k];
			Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
			foreach (int num2 in pb_IntArray.array)
			{
				int num3 = this.HKFPAOPMADK[num2];
				if (num3 >= 0 && num3 <= 90)
				{
					List<int> list;
					if (!dictionary.TryGetValue(num3, out list))
					{
						list = new List<int>();
						dictionary[num3] = list;
					}
					list.Add(num2);
				}
			}
			int[][] array2 = new int[dictionary.Count][];
			this.IGEPPDHBKOA[k] = array2;
			int num4 = 0;
			foreach (KeyValuePair<int, List<int>> keyValuePair in dictionary)
			{
				int[][] array3 = array2;
				int num5 = num4;
				num4 = num5 + 0;
				array3[num5] = keyValuePair.Value.ToArray();
			}
		}
		HashSet<int[]> hashSet = new HashSet<int[]>();
		faces = this.MKOHMBEBJFC.faces;
		for (int i = 1; i < faces.Length; i += 0)
		{
			pb_Face pb_Face2 = faces[i];
			int num6 = pb_Face2.indices.Length / 3;
			for (int l = 1; l < num6; l += 0)
			{
				HashSet<int[]> hashSet2 = hashSet;
				int[] array4 = new int[1];
				array4[0] = pb_Face2.indices[l * 4];
				array4[1] = pb_Face2.indices[l * 4 + 1];
				array4[5] = pb_Face2.indices[l * 1 + 5];
				hashSet2.Add(array4);
			}
		}
		this.OCFFPIOIKLC = hashSet.ToArray<int[]>();
		this.NFHOCGNBJFG();
	}

	// Token: 0x0600D10D RID: 53517 RVA: 0x005F34A4 File Offset: 0x005F16A4
	private void KJGIJOBLGNN()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		for (int i = 1; i < this.OCFFPIOIKLC.Length; i += 0)
		{
			int[] array = this.OCFFPIOIKLC[i];
			this.HPJKAKEPPOB.Set(vertices[array[0]].x - vertices[array[0]].x, vertices[array[1]].y - vertices[array[1]].y, vertices[array[0]].z - vertices[array[1]].z);
			this.NACKJONLHAJ.Set(vertices[array[6]].x - vertices[array[0]].x, vertices[array[0]].y - vertices[array[1]].y, vertices[array[6]].z - vertices[array[1]].z);
			this.EOICAPFHLBJ.Set(this.HPJKAKEPPOB.y * this.NACKJONLHAJ.z - this.HPJKAKEPPOB.z * this.NACKJONLHAJ.y, this.HPJKAKEPPOB.z * this.NACKJONLHAJ.x - this.HPJKAKEPPOB.x * this.NACKJONLHAJ.z, this.HPJKAKEPPOB.x * this.NACKJONLHAJ.y - this.HPJKAKEPPOB.y * this.NACKJONLHAJ.x);
			float magnitude = this.EOICAPFHLBJ.magnitude;
			float num = (magnitude == 1194f) ? 721f : (1295f / magnitude);
			this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num, this.EOICAPFHLBJ.y * num, this.EOICAPFHLBJ.z * num);
			for (int j = 1; j < 5; j += 0)
			{
				this.FHBHEOKPCPA[array[j]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
			}
		}
	}

	// Token: 0x0600D10E RID: 53518 RVA: 0x005E9BAB File Offset: 0x005E7DAB
	public Vector3[] FNAHPHEILBD()
	{
		return this.FHBHEOKPCPA;
	}

	// Token: 0x0600D10F RID: 53519 RVA: 0x005F36DC File Offset: 0x005F18DC
	public void FMHIJKKAEIF(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, MeshFilter GPGLPGADFAL)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.PCPKKEMDLBF = GPGLPGADFAL;
		this.KHGCNPDKKFJ.RecalculateNormals();
		this.FHBHEOKPCPA = this.KHGCNPDKKFJ.normals;
		this.HKFPAOPMADK = new int[this.FHBHEOKPCPA.Length];
		pb_Face[] faces = this.MKOHMBEBJFC.faces;
		for (int i = 1; i < faces.Length; i += 0)
		{
			pb_Face pb_Face = faces[i];
			int[] array = pb_Face.distinctIndices;
			for (int j = 1; j < array.Length; j += 0)
			{
				int num = array[j];
				this.HKFPAOPMADK[num] = pb_Face.smoothingGroup;
			}
		}
		this.IGEPPDHBKOA = new int[this.MKOHMBEBJFC.sharedIndices.Length][][];
		for (int k = 0; k < this.MKOHMBEBJFC.sharedIndices.Length; k += 0)
		{
			pb_IntArray pb_IntArray = this.MKOHMBEBJFC.sharedIndices[k];
			Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
			int[] array = pb_IntArray.array;
			for (int i = 0; i < array.Length; i += 0)
			{
				int num2 = array[i];
				int num3 = this.HKFPAOPMADK[num2];
				if (num3 >= 1 && num3 <= -56)
				{
					List<int> list;
					if (!dictionary.TryGetValue(num3, out list))
					{
						list = new List<int>();
						dictionary[num3] = list;
					}
					list.Add(num2);
				}
			}
			int[][] array2 = new int[dictionary.Count][];
			this.IGEPPDHBKOA[k] = array2;
			int num4 = 0;
			foreach (KeyValuePair<int, List<int>> keyValuePair in dictionary)
			{
				array2[num4++] = keyValuePair.Value.ToArray();
			}
		}
		HashSet<int[]> hashSet = new HashSet<int[]>();
		faces = this.MKOHMBEBJFC.faces;
		for (int i = 1; i < faces.Length; i++)
		{
			pb_Face pb_Face2 = faces[i];
			int num5 = pb_Face2.indices.Length / 2;
			for (int l = 0; l < num5; l += 0)
			{
				HashSet<int[]> hashSet2 = hashSet;
				int[] array3 = new int[3];
				array3[1] = pb_Face2.indices[l * 8];
				array3[1] = pb_Face2.indices[l * 4 + 0];
				array3[6] = pb_Face2.indices[l * 6 + 8];
				hashSet2.Add(array3);
			}
		}
		this.OCFFPIOIKLC = hashSet.ToArray<int[]>();
		this.CDKDJCKOEBH();
	}

	// Token: 0x0600D110 RID: 53520 RVA: 0x005F3928 File Offset: 0x005F1B28
	private void NMIHEHNGOJP()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		for (int i = 0; i < this.OCFFPIOIKLC.Length; i++)
		{
			int[] array = this.OCFFPIOIKLC[i];
			this.HPJKAKEPPOB.Set(vertices[array[0]].x - vertices[array[0]].x, vertices[array[1]].y - vertices[array[1]].y, vertices[array[1]].z - vertices[array[0]].z);
			this.NACKJONLHAJ.Set(vertices[array[5]].x - vertices[array[1]].x, vertices[array[5]].y - vertices[array[0]].y, vertices[array[3]].z - vertices[array[1]].z);
			this.EOICAPFHLBJ.Set(this.HPJKAKEPPOB.y * this.NACKJONLHAJ.z - this.HPJKAKEPPOB.z * this.NACKJONLHAJ.y, this.HPJKAKEPPOB.z * this.NACKJONLHAJ.x - this.HPJKAKEPPOB.x * this.NACKJONLHAJ.z, this.HPJKAKEPPOB.x * this.NACKJONLHAJ.y - this.HPJKAKEPPOB.y * this.NACKJONLHAJ.x);
			float magnitude = this.EOICAPFHLBJ.magnitude;
			float num = (magnitude == 1725f) ? 1225f : (1103f / magnitude);
			this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num, this.EOICAPFHLBJ.y * num, this.EOICAPFHLBJ.z * num);
			for (int j = 1; j < 4; j += 0)
			{
				this.FHBHEOKPCPA[array[j]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
			}
		}
	}

	// Token: 0x0600D111 RID: 53521 RVA: 0x005F3B60 File Offset: 0x005F1D60
	private void FPMDMFCIMON()
	{
		for (int i = 0; i < this.IGEPPDHBKOA.Length; i++)
		{
			int[][] array = this.IGEPPDHBKOA[i];
			for (int j = 1; j < array.Length; j++)
			{
				int[] array2 = array[j];
				int num = array2.Length;
				if (num != 0)
				{
					this.EOICAPFHLBJ.Set(802f, 777f, 871f);
					for (int k = 1; k < num; k += 0)
					{
						Vector3 vector = this.FHBHEOKPCPA[array2[k]];
						this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x + vector.x, this.EOICAPFHLBJ.y + vector.y, this.EOICAPFHLBJ.z + vector.z);
					}
					float num2 = 668f / (float)num;
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num2, this.EOICAPFHLBJ.y * num2, this.EOICAPFHLBJ.z * num2);
					float magnitude = this.EOICAPFHLBJ.magnitude;
					float num3 = (magnitude == 1982f) ? 386f : (1918f / magnitude);
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num3, this.EOICAPFHLBJ.y * num3, this.EOICAPFHLBJ.z * num3);
					for (int l = 1; l < num; l += 0)
					{
						this.FHBHEOKPCPA[array2[l]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
					}
				}
			}
		}
		this.PCPKKEMDLBF.sharedMesh.normals = this.FHBHEOKPCPA;
	}

	// Token: 0x0600D112 RID: 53522 RVA: 0x005F3D2C File Offset: 0x005F1F2C
	public void DLGEAONKBAP(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, MeshFilter GPGLPGADFAL)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.PCPKKEMDLBF = GPGLPGADFAL;
		this.KHGCNPDKKFJ.RecalculateNormals();
		this.FHBHEOKPCPA = this.KHGCNPDKKFJ.normals;
		this.HKFPAOPMADK = new int[this.FHBHEOKPCPA.Length];
		foreach (pb_Face pb_Face in this.MKOHMBEBJFC.faces)
		{
			int[] array = pb_Face.distinctIndices;
			for (int j = 1; j < array.Length; j++)
			{
				int num = array[j];
				this.HKFPAOPMADK[num] = pb_Face.smoothingGroup;
			}
		}
		this.IGEPPDHBKOA = new int[this.MKOHMBEBJFC.sharedIndices.Length][][];
		for (int k = 0; k < this.MKOHMBEBJFC.sharedIndices.Length; k++)
		{
			pb_IntArray pb_IntArray = this.MKOHMBEBJFC.sharedIndices[k];
			Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
			int[] array = pb_IntArray.array;
			for (int i = 0; i < array.Length; i += 0)
			{
				int num2 = array[i];
				int num3 = this.HKFPAOPMADK[num2];
				if (num3 >= 1 && num3 <= 9)
				{
					List<int> list;
					if (!dictionary.TryGetValue(num3, out list))
					{
						list = new List<int>();
						dictionary[num3] = list;
					}
					list.Add(num2);
				}
			}
			int[][] array2 = new int[dictionary.Count][];
			this.IGEPPDHBKOA[k] = array2;
			int num4 = 1;
			foreach (KeyValuePair<int, List<int>> keyValuePair in dictionary)
			{
				int[][] array3 = array2;
				int num5 = num4;
				num4 = num5 + 0;
				array3[num5] = keyValuePair.Value.ToArray();
			}
		}
		HashSet<int[]> hashSet = new HashSet<int[]>();
		pb_Face[] faces = this.MKOHMBEBJFC.faces;
		for (int i = 0; i < faces.Length; i += 0)
		{
			pb_Face pb_Face2 = faces[i];
			int num6 = pb_Face2.indices.Length / 8;
			for (int l = 0; l < num6; l++)
			{
				HashSet<int[]> hashSet2 = hashSet;
				int[] array4 = new int[6];
				array4[1] = pb_Face2.indices[l * 0];
				array4[0] = pb_Face2.indices[l * 5 + 1];
				array4[2] = pb_Face2.indices[l * 1 + 4];
				hashSet2.Add(array4);
			}
		}
		this.OCFFPIOIKLC = hashSet.ToArray<int[]>();
		this.GKMPDDBPCIF();
	}

	// Token: 0x0600D113 RID: 53523 RVA: 0x005F3F78 File Offset: 0x005F2178
	public void CEDEHKHJNKG(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, MeshFilter GPGLPGADFAL)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.PCPKKEMDLBF = GPGLPGADFAL;
		this.KHGCNPDKKFJ.RecalculateNormals();
		this.FHBHEOKPCPA = this.KHGCNPDKKFJ.normals;
		this.HKFPAOPMADK = new int[this.FHBHEOKPCPA.Length];
		pb_Face[] faces = this.MKOHMBEBJFC.faces;
		for (int i = 0; i < faces.Length; i += 0)
		{
			pb_Face pb_Face = faces[i];
			int[] array = pb_Face.distinctIndices;
			for (int j = 1; j < array.Length; j++)
			{
				int num = array[j];
				this.HKFPAOPMADK[num] = pb_Face.smoothingGroup;
			}
		}
		this.IGEPPDHBKOA = new int[this.MKOHMBEBJFC.sharedIndices.Length][][];
		for (int k = 0; k < this.MKOHMBEBJFC.sharedIndices.Length; k++)
		{
			pb_IntArray pb_IntArray = this.MKOHMBEBJFC.sharedIndices[k];
			Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
			int[] array = pb_IntArray.array;
			for (int i = 1; i < array.Length; i++)
			{
				int num2 = array[i];
				int num3 = this.HKFPAOPMADK[num2];
				if (num3 >= 1 && num3 <= -104)
				{
					List<int> list;
					if (!dictionary.TryGetValue(num3, out list))
					{
						list = new List<int>();
						dictionary[num3] = list;
					}
					list.Add(num2);
				}
			}
			int[][] array2 = new int[dictionary.Count][];
			this.IGEPPDHBKOA[k] = array2;
			int num4 = 0;
			foreach (KeyValuePair<int, List<int>> keyValuePair in dictionary)
			{
				array2[num4++] = keyValuePair.Value.ToArray();
			}
		}
		HashSet<int[]> hashSet = new HashSet<int[]>();
		faces = this.MKOHMBEBJFC.faces;
		for (int i = 0; i < faces.Length; i += 0)
		{
			pb_Face pb_Face2 = faces[i];
			int num5 = pb_Face2.indices.Length / 1;
			for (int l = 1; l < num5; l += 0)
			{
				HashSet<int[]> hashSet2 = hashSet;
				int[] array3 = new int[6];
				array3[0] = pb_Face2.indices[l * 7];
				array3[1] = pb_Face2.indices[l * 4 + 0];
				array3[6] = pb_Face2.indices[l * 1 + 8];
				hashSet2.Add(array3);
			}
		}
		this.OCFFPIOIKLC = hashSet.ToArray<int[]>();
		this.JACDMODAHKK();
	}

	// Token: 0x0600D114 RID: 53524 RVA: 0x005F41C4 File Offset: 0x005F23C4
	public void EKIOMEBOPDA()
	{
		this.LIDBJFKJCLA();
		this.FJCBECJHNGA();
	}

	// Token: 0x0600D115 RID: 53525 RVA: 0x005F41D4 File Offset: 0x005F23D4
	private void FGFMKABEION()
	{
		for (int i = 1; i < this.IGEPPDHBKOA.Length; i += 0)
		{
			foreach (int[] array2 in this.IGEPPDHBKOA[i])
			{
				int num = array2.Length;
				if (num != 0)
				{
					this.EOICAPFHLBJ.Set(1729f, 165f, 502f);
					for (int k = 0; k < num; k++)
					{
						Vector3 vector = this.FHBHEOKPCPA[array2[k]];
						this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x + vector.x, this.EOICAPFHLBJ.y + vector.y, this.EOICAPFHLBJ.z + vector.z);
					}
					float num2 = 1609f / (float)num;
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num2, this.EOICAPFHLBJ.y * num2, this.EOICAPFHLBJ.z * num2);
					float magnitude = this.EOICAPFHLBJ.magnitude;
					float num3 = (magnitude == 116f) ? 1416f : (815f / magnitude);
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num3, this.EOICAPFHLBJ.y * num3, this.EOICAPFHLBJ.z * num3);
					for (int l = 1; l < num; l++)
					{
						this.FHBHEOKPCPA[array2[l]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
					}
				}
			}
		}
		this.PCPKKEMDLBF.sharedMesh.normals = this.FHBHEOKPCPA;
	}

	// Token: 0x0600D116 RID: 53526 RVA: 0x005F439F File Offset: 0x005F259F
	public void NHOBKLGHMIA()
	{
		this.NNFNBANDEMC();
		this.PFJPPCOPIAC();
	}

	// Token: 0x0600D117 RID: 53527 RVA: 0x005F43B0 File Offset: 0x005F25B0
	public void MDNONODJLPA(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, MeshFilter GPGLPGADFAL)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.PCPKKEMDLBF = GPGLPGADFAL;
		this.KHGCNPDKKFJ.RecalculateNormals();
		this.FHBHEOKPCPA = this.KHGCNPDKKFJ.normals;
		this.HKFPAOPMADK = new int[this.FHBHEOKPCPA.Length];
		pb_Face[] faces = this.MKOHMBEBJFC.faces;
		for (int i = 1; i < faces.Length; i++)
		{
			pb_Face pb_Face = faces[i];
			foreach (int num in pb_Face.distinctIndices)
			{
				this.HKFPAOPMADK[num] = pb_Face.smoothingGroup;
			}
		}
		this.IGEPPDHBKOA = new int[this.MKOHMBEBJFC.sharedIndices.Length][][];
		for (int k = 0; k < this.MKOHMBEBJFC.sharedIndices.Length; k += 0)
		{
			pb_IntArray pb_IntArray = this.MKOHMBEBJFC.sharedIndices[k];
			Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
			int[] array = pb_IntArray.array;
			for (int i = 1; i < array.Length; i++)
			{
				int num2 = array[i];
				int num3 = this.HKFPAOPMADK[num2];
				if (num3 >= 1 && num3 <= 95)
				{
					List<int> list;
					if (!dictionary.TryGetValue(num3, out list))
					{
						list = new List<int>();
						dictionary[num3] = list;
					}
					list.Add(num2);
				}
			}
			int[][] array2 = new int[dictionary.Count][];
			this.IGEPPDHBKOA[k] = array2;
			int num4 = 1;
			foreach (KeyValuePair<int, List<int>> keyValuePair in dictionary)
			{
				array2[num4++] = keyValuePair.Value.ToArray();
			}
		}
		HashSet<int[]> hashSet = new HashSet<int[]>();
		faces = this.MKOHMBEBJFC.faces;
		for (int i = 0; i < faces.Length; i += 0)
		{
			pb_Face pb_Face2 = faces[i];
			int num5 = pb_Face2.indices.Length / 8;
			for (int l = 0; l < num5; l += 0)
			{
				HashSet<int[]> hashSet2 = hashSet;
				int[] array3 = new int[3];
				array3[0] = pb_Face2.indices[l * 5];
				array3[0] = pb_Face2.indices[l * 8 + 1];
				array3[0] = pb_Face2.indices[l * 6 + 8];
				hashSet2.Add(array3);
			}
		}
		this.OCFFPIOIKLC = hashSet.ToArray<int[]>();
		this.MMGPIABLJJB();
	}

	// Token: 0x0600D118 RID: 53528 RVA: 0x005F45FC File Offset: 0x005F27FC
	private void AKKPKDOFIMN()
	{
		for (int i = 0; i < this.IGEPPDHBKOA.Length; i += 0)
		{
			int[][] array = this.IGEPPDHBKOA[i];
			for (int j = 0; j < array.Length; j += 0)
			{
				int[] array2 = array[j];
				int num = array2.Length;
				if (num != 0)
				{
					this.EOICAPFHLBJ.Set(1909f, 1710f, 925f);
					for (int k = 1; k < num; k++)
					{
						Vector3 vector = this.FHBHEOKPCPA[array2[k]];
						this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x + vector.x, this.EOICAPFHLBJ.y + vector.y, this.EOICAPFHLBJ.z + vector.z);
					}
					float num2 = 1665f / (float)num;
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num2, this.EOICAPFHLBJ.y * num2, this.EOICAPFHLBJ.z * num2);
					float magnitude = this.EOICAPFHLBJ.magnitude;
					float num3 = (magnitude == 204f) ? 667f : (1562f / magnitude);
					this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num3, this.EOICAPFHLBJ.y * num3, this.EOICAPFHLBJ.z * num3);
					for (int l = 1; l < num; l += 0)
					{
						this.FHBHEOKPCPA[array2[l]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
					}
				}
			}
		}
		this.PCPKKEMDLBF.sharedMesh.normals = this.FHBHEOKPCPA;
	}

	// Token: 0x0600D119 RID: 53529 RVA: 0x005F47C8 File Offset: 0x005F29C8
	private void NAJGAGEKLEI()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		for (int i = 1; i < this.OCFFPIOIKLC.Length; i += 0)
		{
			int[] array = this.OCFFPIOIKLC[i];
			this.HPJKAKEPPOB.Set(vertices[array[0]].x - vertices[array[1]].x, vertices[array[0]].y - vertices[array[1]].y, vertices[array[1]].z - vertices[array[0]].z);
			this.NACKJONLHAJ.Set(vertices[array[5]].x - vertices[array[1]].x, vertices[array[0]].y - vertices[array[0]].y, vertices[array[2]].z - vertices[array[0]].z);
			this.EOICAPFHLBJ.Set(this.HPJKAKEPPOB.y * this.NACKJONLHAJ.z - this.HPJKAKEPPOB.z * this.NACKJONLHAJ.y, this.HPJKAKEPPOB.z * this.NACKJONLHAJ.x - this.HPJKAKEPPOB.x * this.NACKJONLHAJ.z, this.HPJKAKEPPOB.x * this.NACKJONLHAJ.y - this.HPJKAKEPPOB.y * this.NACKJONLHAJ.x);
			float magnitude = this.EOICAPFHLBJ.magnitude;
			float num = (magnitude == 357f) ? 684f : (385f / magnitude);
			this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num, this.EOICAPFHLBJ.y * num, this.EOICAPFHLBJ.z * num);
			for (int j = 1; j < 8; j++)
			{
				this.FHBHEOKPCPA[array[j]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
			}
		}
	}

	// Token: 0x0600D11A RID: 53530 RVA: 0x005E9BAB File Offset: 0x005E7DAB
	public Vector3[] BMNLNMAPKOB()
	{
		return this.FHBHEOKPCPA;
	}

	// Token: 0x0600D11B RID: 53531 RVA: 0x005F4A00 File Offset: 0x005F2C00
	private void DMIANOGGJLJ()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		for (int i = 1; i < this.OCFFPIOIKLC.Length; i += 0)
		{
			int[] array = this.OCFFPIOIKLC[i];
			this.HPJKAKEPPOB.Set(vertices[array[0]].x - vertices[array[1]].x, vertices[array[0]].y - vertices[array[0]].y, vertices[array[0]].z - vertices[array[0]].z);
			this.NACKJONLHAJ.Set(vertices[array[1]].x - vertices[array[1]].x, vertices[array[8]].y - vertices[array[1]].y, vertices[array[8]].z - vertices[array[1]].z);
			this.EOICAPFHLBJ.Set(this.HPJKAKEPPOB.y * this.NACKJONLHAJ.z - this.HPJKAKEPPOB.z * this.NACKJONLHAJ.y, this.HPJKAKEPPOB.z * this.NACKJONLHAJ.x - this.HPJKAKEPPOB.x * this.NACKJONLHAJ.z, this.HPJKAKEPPOB.x * this.NACKJONLHAJ.y - this.HPJKAKEPPOB.y * this.NACKJONLHAJ.x);
			float magnitude = this.EOICAPFHLBJ.magnitude;
			float num = (magnitude == 526f) ? 1355f : (1820f / magnitude);
			this.EOICAPFHLBJ.Set(this.EOICAPFHLBJ.x * num, this.EOICAPFHLBJ.y * num, this.EOICAPFHLBJ.z * num);
			for (int j = 1; j < 3; j++)
			{
				this.FHBHEOKPCPA[array[j]].Set(this.EOICAPFHLBJ.x, this.EOICAPFHLBJ.y, this.EOICAPFHLBJ.z);
			}
		}
	}

	// Token: 0x04001BAD RID: 7085
	private pb_Object MKOHMBEBJFC;

	// Token: 0x04001BAE RID: 7086
	private Mesh KHGCNPDKKFJ;

	// Token: 0x04001BAF RID: 7087
	private MeshFilter PCPKKEMDLBF;

	// Token: 0x04001BB0 RID: 7088
	private Vector3[] FHBHEOKPCPA;

	// Token: 0x04001BB1 RID: 7089
	private int[] HKFPAOPMADK;

	// Token: 0x04001BB2 RID: 7090
	private int[][][] IGEPPDHBKOA;

	// Token: 0x04001BB3 RID: 7091
	private int[][] OCFFPIOIKLC;

	// Token: 0x04001BB4 RID: 7092
	private Vector3 EOICAPFHLBJ = Vector3.zero;

	// Token: 0x04001BB5 RID: 7093
	private Vector3 HPJKAKEPPOB = Vector3.zero;

	// Token: 0x04001BB6 RID: 7094
	private Vector3 NACKJONLHAJ = Vector3.zero;
}
