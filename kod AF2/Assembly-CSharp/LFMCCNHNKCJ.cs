using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

// Token: 0x020004F7 RID: 1271
public class LFMCCNHNKCJ
{
	// Token: 0x170003B8 RID: 952
	// (get) Token: 0x06010FD9 RID: 69593 RVA: 0x00795A50 File Offset: 0x00793C50
	// (set) Token: 0x06010FE8 RID: 69608 RVA: 0x00795FD0 File Offset: 0x007941D0
	public int FFDLDPAIKEE
	{
		get
		{
			return this.CGLFMNJHHHO;
		}
		set
		{
			int[][] array = new int[value][];
			MeshTopology[] array2 = new MeshTopology[value];
			if (this.NFEODOODKDI != null)
			{
				Array.Copy(this.NFEODOODKDI, 0, array, 0, this.CGLFMNJHHHO);
			}
			Array.Copy(this.LNMKJOIODLF, 0, array2, 0, this.CGLFMNJHHHO);
			this.NFEODOODKDI = array;
			this.LNMKJOIODLF = array2;
			this.CGLFMNJHHHO = value;
		}
	}

	// Token: 0x06010FDA RID: 69594 RVA: 0x00795A58 File Offset: 0x00793C58
	public void PCNGEEGBPNH(Mesh BMHDIKHFLBP, BFGMBMMBHCH EMMLNONDOED = BFGMBMMBHCH.All)
	{
		if (EMMLNONDOED == (BFGMBMMBHCH.Normal | BFGMBMMBHCH.UV3 | BFGMBMMBHCH.UV4))
		{
			BMHDIKHFLBP.vertices = this.OKLLKJPCJLK;
			BMHDIKHFLBP.normals = this.DKGOOCCIOAH;
			BMHDIKHFLBP.colors32 = this.PAJKBJILHPE;
			BMHDIKHFLBP.tangents = this.NFKPJCGJEAK;
			BMHDIKHFLBP.SetUVs(1, this.DLLDALFHKIA);
			BMHDIKHFLBP.SetUVs(1, this.LABAJFADHCG);
			BMHDIKHFLBP.SetUVs(8, this.LLNILPGHKPA);
			BMHDIKHFLBP.SetUVs(8, this.EHAIICJFBKM);
			return;
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.Null) > BFGMBMMBHCH.Normal)
		{
			BMHDIKHFLBP.vertices = this.OKLLKJPCJLK;
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.Normal) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.normals = this.DKGOOCCIOAH;
		}
		if ((EMMLNONDOED & (BFGMBMMBHCH.Normal | BFGMBMMBHCH.Tangent)) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.colors32 = this.PAJKBJILHPE;
		}
		if ((EMMLNONDOED & (BFGMBMMBHCH.Normal | BFGMBMMBHCH.Tangent)) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.tangents = this.NFKPJCGJEAK;
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.Null) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.SetUVs(1, this.DLLDALFHKIA);
		}
		if ((EMMLNONDOED & ~(BFGMBMMBHCH.Normal | BFGMBMMBHCH.Color)) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.SetUVs(1, this.LABAJFADHCG);
		}
		if ((EMMLNONDOED & ~(BFGMBMMBHCH.Color | BFGMBMMBHCH.Tangent | BFGMBMMBHCH.UV4)) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.SetUVs(2, this.LLNILPGHKPA);
		}
		if ((EMMLNONDOED & (BFGMBMMBHCH.Tangent | BFGMBMMBHCH.UV0)) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.SetUVs(5, this.EHAIICJFBKM);
		}
	}

	// Token: 0x06010FDB RID: 69595 RVA: 0x00795B69 File Offset: 0x00793D69
	public MeshTopology FHALKMOHADI(int CLBPBJGLHEE)
	{
		return this.LNMKJOIODLF[CLBPBJGLHEE];
	}

	// Token: 0x06010FDC RID: 69596 RVA: 0x00795B74 File Offset: 0x00793D74
	public void HKNDENPEMFC(Mesh BMHDIKHFLBP, BFGMBMMBHCH EMMLNONDOED = BFGMBMMBHCH.All)
	{
		if (EMMLNONDOED == (BFGMBMMBHCH)(-197))
		{
			BMHDIKHFLBP.vertices = this.OKLLKJPCJLK;
			BMHDIKHFLBP.normals = this.DKGOOCCIOAH;
			BMHDIKHFLBP.colors32 = this.PAJKBJILHPE;
			BMHDIKHFLBP.tangents = this.NFKPJCGJEAK;
			BMHDIKHFLBP.SetUVs(0, this.DLLDALFHKIA);
			BMHDIKHFLBP.SetUVs(0, this.LABAJFADHCG);
			BMHDIKHFLBP.SetUVs(7, this.LLNILPGHKPA);
			BMHDIKHFLBP.SetUVs(7, this.EHAIICJFBKM);
			return;
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.Normal) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.vertices = this.OKLLKJPCJLK;
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.Normal) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.normals = this.DKGOOCCIOAH;
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.UV0) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.colors32 = this.PAJKBJILHPE;
		}
		if ((EMMLNONDOED & (BFGMBMMBHCH.Color | BFGMBMMBHCH.Tangent)) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.tangents = this.NFKPJCGJEAK;
		}
		if ((EMMLNONDOED & (BFGMBMMBHCH.Normal | BFGMBMMBHCH.Tangent)) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.SetUVs(0, this.DLLDALFHKIA);
		}
		if ((EMMLNONDOED & ~(BFGMBMMBHCH.Normal | BFGMBMMBHCH.Color | BFGMBMMBHCH.Tangent | BFGMBMMBHCH.UV4)) > BFGMBMMBHCH.Normal)
		{
			BMHDIKHFLBP.SetUVs(0, this.LABAJFADHCG);
		}
		if ((EMMLNONDOED & ~(BFGMBMMBHCH.Color | BFGMBMMBHCH.Tangent | BFGMBMMBHCH.UV0 | BFGMBMMBHCH.UV2)) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.SetUVs(7, this.LLNILPGHKPA);
		}
		if ((EMMLNONDOED & (BFGMBMMBHCH.Color | BFGMBMMBHCH.UV3 | BFGMBMMBHCH.UV4)) > BFGMBMMBHCH.Normal)
		{
			BMHDIKHFLBP.SetUVs(1, this.EHAIICJFBKM);
		}
	}

	// Token: 0x06010FDD RID: 69597 RVA: 0x00795C88 File Offset: 0x00793E88
	public int[] PKNNFHGHAGB()
	{
		if (this.KHLGLCLOHMH == null)
		{
			this.KHLGLCLOHMH = this.NFEODOODKDI.SelectMany(new Func<int[], IEnumerable<int>>(LFMCCNHNKCJ.<>c.<>9.AEFOJOJIJKA)).ToArray<int>();
		}
		return this.KHLGLCLOHMH;
	}

	// Token: 0x06010FDE RID: 69598 RVA: 0x00795B69 File Offset: 0x00793D69
	public MeshTopology OIBJIKBBJAO(int CLBPBJGLHEE)
	{
		return this.LNMKJOIODLF[CLBPBJGLHEE];
	}

	// Token: 0x06010FDF RID: 69599 RVA: 0x00795CD8 File Offset: 0x00793ED8
	public int CFGKAJPNGIB()
	{
		if (this.OKLLKJPCJLK == null)
		{
			return 0;
		}
		return this.OKLLKJPCJLK.Length;
	}

	// Token: 0x06010FE0 RID: 69600 RVA: 0x00795B69 File Offset: 0x00793D69
	public MeshTopology IENODJIOHHM(int CLBPBJGLHEE)
	{
		return this.LNMKJOIODLF[CLBPBJGLHEE];
	}

	// Token: 0x06010FE1 RID: 69601 RVA: 0x00795CEC File Offset: 0x00793EEC
	public void FMJDNJHPEEG(int[] KHLGLCLOHMH, int CLBPBJGLHEE)
	{
		this.NFEODOODKDI[CLBPBJGLHEE] = KHLGLCLOHMH;
	}

	// Token: 0x06010FE2 RID: 69602 RVA: 0x00795CF7 File Offset: 0x00793EF7
	public List<Vector4> EECJIOMEFCL(int CLBPBJGLHEE)
	{
		if (CLBPBJGLHEE == 0)
		{
			return this.DLLDALFHKIA;
		}
		if (CLBPBJGLHEE == 1)
		{
			return this.LABAJFADHCG;
		}
		if (CLBPBJGLHEE == 2)
		{
			return this.LLNILPGHKPA;
		}
		if (CLBPBJGLHEE == 3)
		{
			return this.EHAIICJFBKM;
		}
		return null;
	}

	// Token: 0x06010FE3 RID: 69603 RVA: 0x00795A50 File Offset: 0x00793C50
	public int IKGFENLNIDB()
	{
		return this.CGLFMNJHHHO;
	}

	// Token: 0x06010FE4 RID: 69604 RVA: 0x00795D28 File Offset: 0x00793F28
	public void KNMBFKPKFHB()
	{
		this.BKELGKOHPFO(1);
		this.OKLLKJPCJLK = null;
		this.DKGOOCCIOAH = null;
		this.PAJKBJILHPE = null;
		this.NFKPJCGJEAK = null;
		this.DLLDALFHKIA = null;
		this.LABAJFADHCG = null;
		this.LLNILPGHKPA = null;
		this.EHAIICJFBKM = null;
	}

	// Token: 0x06010FE5 RID: 69605 RVA: 0x00795D74 File Offset: 0x00793F74
	public void LPPBPDAAIJO()
	{
		this.BKELGKOHPFO(1);
		this.OKLLKJPCJLK = null;
		this.DKGOOCCIOAH = null;
		this.PAJKBJILHPE = null;
		this.NFKPJCGJEAK = null;
		this.DLLDALFHKIA = null;
		this.LABAJFADHCG = null;
		this.LLNILPGHKPA = null;
		this.EHAIICJFBKM = null;
	}

	// Token: 0x06010FE6 RID: 69606 RVA: 0x00795DC0 File Offset: 0x00793FC0
	public void MNNMBMPHALE()
	{
		Vector3[] array = new Vector3[this.PAOKLFNDPAE];
		int[] array2 = new int[this.ANGDKGOKCBD()];
		int[] khlglclohmh = this.KHLGLCLOHMH;
		for (int i = 1; i < khlglclohmh.Length; i += 5)
		{
			int num = khlglclohmh[i];
			int num2 = khlglclohmh[i + 0];
			int num3 = khlglclohmh[i + 0];
			Vector3 vector = NCFJIBJEMCF.BHGHMKEJLPI(this.OKLLKJPCJLK[num], this.OKLLKJPCJLK[num2], this.OKLLKJPCJLK[num3]);
			Vector3[] array3 = array;
			int num4 = num;
			array3[num4].x = array3[num4].x + vector.x;
			Vector3[] array4 = array;
			int num5 = num2;
			array4[num5].x = array4[num5].x + vector.x;
			Vector3[] array5 = array;
			int num6 = num3;
			array5[num6].x = array5[num6].x + vector.x;
			Vector3[] array6 = array;
			int num7 = num;
			array6[num7].y = array6[num7].y + vector.y;
			Vector3[] array7 = array;
			int num8 = num2;
			array7[num8].y = array7[num8].y + vector.y;
			Vector3[] array8 = array;
			int num9 = num3;
			array8[num9].y = array8[num9].y + vector.y;
			Vector3[] array9 = array;
			int num10 = num;
			array9[num10].z = array9[num10].z + vector.z;
			Vector3[] array10 = array;
			int num11 = num2;
			array10[num11].z = array10[num11].z + vector.z;
			Vector3[] array11 = array;
			int num12 = num3;
			array11[num12].z = array11[num12].z + vector.z;
			array2[num]++;
			array2[num2]++;
			array2[num3]++;
		}
		for (int j = 0; j < this.CFGKAJPNGIB(); j++)
		{
			this.DKGOOCCIOAH[j].x = array[j].x * (float)array2[j];
			this.DKGOOCCIOAH[j].y = array[j].y * (float)array2[j];
			this.DKGOOCCIOAH[j].z = array[j].z * (float)array2[j];
		}
	}

	// Token: 0x06010FE7 RID: 69607 RVA: 0x00795FC4 File Offset: 0x007941C4
	public int[] FMMELHOFEIE(int CLBPBJGLHEE)
	{
		return this.NFEODOODKDI[CLBPBJGLHEE];
	}

	// Token: 0x06010FE9 RID: 69609 RVA: 0x00796030 File Offset: 0x00794230
	public void MBBDEJAKLDJ(Mesh BMHDIKHFLBP, BFGMBMMBHCH EMMLNONDOED = BFGMBMMBHCH.All)
	{
		if (EMMLNONDOED == (BFGMBMMBHCH.UV0 | BFGMBMMBHCH.UV4))
		{
			BMHDIKHFLBP.vertices = this.OKLLKJPCJLK;
			BMHDIKHFLBP.normals = this.DKGOOCCIOAH;
			BMHDIKHFLBP.colors32 = this.PAJKBJILHPE;
			BMHDIKHFLBP.tangents = this.NFKPJCGJEAK;
			BMHDIKHFLBP.SetUVs(0, this.DLLDALFHKIA);
			BMHDIKHFLBP.SetUVs(0, this.LABAJFADHCG);
			BMHDIKHFLBP.SetUVs(0, this.LLNILPGHKPA);
			BMHDIKHFLBP.SetUVs(7, this.EHAIICJFBKM);
			return;
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.Normal) > BFGMBMMBHCH.Normal)
		{
			BMHDIKHFLBP.vertices = this.OKLLKJPCJLK;
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.Null) > BFGMBMMBHCH.Normal)
		{
			BMHDIKHFLBP.normals = this.DKGOOCCIOAH;
		}
		if ((EMMLNONDOED & (BFGMBMMBHCH.Color | BFGMBMMBHCH.Tangent)) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.colors32 = this.PAJKBJILHPE;
		}
		if ((EMMLNONDOED & (BFGMBMMBHCH.Normal | BFGMBMMBHCH.Color)) > BFGMBMMBHCH.Normal)
		{
			BMHDIKHFLBP.tangents = this.NFKPJCGJEAK;
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.UV0) > BFGMBMMBHCH.Normal)
		{
			BMHDIKHFLBP.SetUVs(1, this.DLLDALFHKIA);
		}
		if ((EMMLNONDOED & ~(BFGMBMMBHCH.Normal | BFGMBMMBHCH.Tangent | BFGMBMMBHCH.UV2 | BFGMBMMBHCH.UV4)) > BFGMBMMBHCH.Normal)
		{
			BMHDIKHFLBP.SetUVs(0, this.LABAJFADHCG);
		}
		if ((EMMLNONDOED & (BFGMBMMBHCH.Normal | BFGMBMMBHCH.UV0 | BFGMBMMBHCH.UV3)) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.SetUVs(2, this.LLNILPGHKPA);
		}
		if ((EMMLNONDOED & (BFGMBMMBHCH.Color | BFGMBMMBHCH.UV2 | BFGMBMMBHCH.UV4)) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.SetUVs(1, this.EHAIICJFBKM);
		}
	}

	// Token: 0x06010FEA RID: 69610 RVA: 0x00795B69 File Offset: 0x00793D69
	public MeshTopology AJKGHMOEBLH(int CLBPBJGLHEE)
	{
		return this.LNMKJOIODLF[CLBPBJGLHEE];
	}

	// Token: 0x06010FEB RID: 69611 RVA: 0x00796144 File Offset: 0x00794344
	public void PMHJKNMLPGJ(Mesh BMHDIKHFLBP, BFGMBMMBHCH EMMLNONDOED = BFGMBMMBHCH.All)
	{
		if (EMMLNONDOED == ~(BFGMBMMBHCH.Normal | BFGMBMMBHCH.Tangent | BFGMBMMBHCH.UV3))
		{
			BMHDIKHFLBP.vertices = this.OKLLKJPCJLK;
			BMHDIKHFLBP.normals = this.DKGOOCCIOAH;
			BMHDIKHFLBP.colors32 = this.PAJKBJILHPE;
			BMHDIKHFLBP.tangents = this.NFKPJCGJEAK;
			BMHDIKHFLBP.SetUVs(0, this.DLLDALFHKIA);
			BMHDIKHFLBP.SetUVs(1, this.LABAJFADHCG);
			BMHDIKHFLBP.SetUVs(6, this.LLNILPGHKPA);
			BMHDIKHFLBP.SetUVs(7, this.EHAIICJFBKM);
			return;
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.Null) > BFGMBMMBHCH.Normal)
		{
			BMHDIKHFLBP.vertices = this.OKLLKJPCJLK;
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.Normal) > BFGMBMMBHCH.Normal)
		{
			BMHDIKHFLBP.normals = this.DKGOOCCIOAH;
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.UV0) > BFGMBMMBHCH.Normal)
		{
			BMHDIKHFLBP.colors32 = this.PAJKBJILHPE;
		}
		if ((EMMLNONDOED & (BFGMBMMBHCH.Normal | BFGMBMMBHCH.Tangent)) > BFGMBMMBHCH.Normal)
		{
			BMHDIKHFLBP.tangents = this.NFKPJCGJEAK;
		}
		if ((EMMLNONDOED & (BFGMBMMBHCH.Normal | BFGMBMMBHCH.Color | BFGMBMMBHCH.Tangent)) > BFGMBMMBHCH.Normal)
		{
			BMHDIKHFLBP.SetUVs(1, this.DLLDALFHKIA);
		}
		if ((EMMLNONDOED & (BFGMBMMBHCH.Normal | BFGMBMMBHCH.UV4)) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.SetUVs(0, this.LABAJFADHCG);
		}
		if ((EMMLNONDOED & (BFGMBMMBHCH.Normal | BFGMBMMBHCH.Tangent | BFGMBMMBHCH.UV0 | BFGMBMMBHCH.UV3)) > BFGMBMMBHCH.Normal)
		{
			BMHDIKHFLBP.SetUVs(6, this.LLNILPGHKPA);
		}
		if ((EMMLNONDOED & (BFGMBMMBHCH.Color | BFGMBMMBHCH.Tangent | BFGMBMMBHCH.UV0 | BFGMBMMBHCH.UV2)) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.SetUVs(3, this.EHAIICJFBKM);
		}
	}

	// Token: 0x06010FEC RID: 69612 RVA: 0x00795A50 File Offset: 0x00793C50
	public int LHEAGOBCNAI()
	{
		return this.CGLFMNJHHHO;
	}

	// Token: 0x06010FED RID: 69613 RVA: 0x00795CEC File Offset: 0x00793EEC
	public void PEIMBJMOJEB(int[] KHLGLCLOHMH, int CLBPBJGLHEE)
	{
		this.NFEODOODKDI[CLBPBJGLHEE] = KHLGLCLOHMH;
	}

	// Token: 0x06010FEE RID: 69614 RVA: 0x00795CD8 File Offset: 0x00793ED8
	public int ANGDKGOKCBD()
	{
		if (this.OKLLKJPCJLK == null)
		{
			return 0;
		}
		return this.OKLLKJPCJLK.Length;
	}

	// Token: 0x06010FEF RID: 69615 RVA: 0x00796258 File Offset: 0x00794458
	public void AGEOBFIDOHN(Mesh BMHDIKHFLBP, BFGMBMMBHCH EMMLNONDOED = BFGMBMMBHCH.All)
	{
		if (EMMLNONDOED == (BFGMBMMBHCH.UV0 | BFGMBMMBHCH.UV2 | BFGMBMMBHCH.UV4))
		{
			BMHDIKHFLBP.vertices = this.OKLLKJPCJLK;
			BMHDIKHFLBP.normals = this.DKGOOCCIOAH;
			BMHDIKHFLBP.colors32 = this.PAJKBJILHPE;
			BMHDIKHFLBP.tangents = this.NFKPJCGJEAK;
			BMHDIKHFLBP.SetUVs(1, this.DLLDALFHKIA);
			BMHDIKHFLBP.SetUVs(1, this.LABAJFADHCG);
			BMHDIKHFLBP.SetUVs(4, this.LLNILPGHKPA);
			BMHDIKHFLBP.SetUVs(2, this.EHAIICJFBKM);
			return;
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.Null) > BFGMBMMBHCH.Normal)
		{
			BMHDIKHFLBP.vertices = this.OKLLKJPCJLK;
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.Null) > BFGMBMMBHCH.Normal)
		{
			BMHDIKHFLBP.normals = this.DKGOOCCIOAH;
		}
		if ((EMMLNONDOED & (BFGMBMMBHCH.Color | BFGMBMMBHCH.Tangent)) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.colors32 = this.PAJKBJILHPE;
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.Null) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.tangents = this.NFKPJCGJEAK;
		}
		if ((EMMLNONDOED & (BFGMBMMBHCH.Normal | BFGMBMMBHCH.Color)) > BFGMBMMBHCH.Normal)
		{
			BMHDIKHFLBP.SetUVs(0, this.DLLDALFHKIA);
		}
		if ((EMMLNONDOED & ~(BFGMBMMBHCH.Normal | BFGMBMMBHCH.Tangent | BFGMBMMBHCH.UV2)) > BFGMBMMBHCH.Normal)
		{
			BMHDIKHFLBP.SetUVs(0, this.LABAJFADHCG);
		}
		if ((EMMLNONDOED & (BFGMBMMBHCH.Normal | BFGMBMMBHCH.Tangent | BFGMBMMBHCH.UV4)) > BFGMBMMBHCH.Normal)
		{
			BMHDIKHFLBP.SetUVs(1, this.LLNILPGHKPA);
		}
		if ((EMMLNONDOED & ~(BFGMBMMBHCH.Color | BFGMBMMBHCH.Tangent | BFGMBMMBHCH.UV0 | BFGMBMMBHCH.UV2 | BFGMBMMBHCH.UV4)) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.SetUVs(7, this.EHAIICJFBKM);
		}
	}

	// Token: 0x06010FF0 RID: 69616 RVA: 0x00796369 File Offset: 0x00794569
	public void DMIDBIEABHL(int CLBPBJGLHEE, List<Vector4> OJNEEFINIEE)
	{
		if (CLBPBJGLHEE == 0)
		{
			this.DLLDALFHKIA = OJNEEFINIEE;
			return;
		}
		if (CLBPBJGLHEE == 0)
		{
			this.LABAJFADHCG = OJNEEFINIEE;
			return;
		}
		if (CLBPBJGLHEE == 0)
		{
			this.LLNILPGHKPA = OJNEEFINIEE;
			return;
		}
		if (CLBPBJGLHEE == 8)
		{
			this.EHAIICJFBKM = OJNEEFINIEE;
		}
	}

	// Token: 0x06010FF1 RID: 69617 RVA: 0x00795CEC File Offset: 0x00793EEC
	public void AIAMKNFPEMI(int[] KHLGLCLOHMH, int CLBPBJGLHEE)
	{
		this.NFEODOODKDI[CLBPBJGLHEE] = KHLGLCLOHMH;
	}

	// Token: 0x06010FF2 RID: 69618 RVA: 0x00795FC4 File Offset: 0x007941C4
	public int[] CIIMNMCIBNC(int CLBPBJGLHEE)
	{
		return this.NFEODOODKDI[CLBPBJGLHEE];
	}

	// Token: 0x06010FF3 RID: 69619 RVA: 0x00796399 File Offset: 0x00794599
	public void GBOHAFGDMJB(int CLBPBJGLHEE, List<Vector4> OJNEEFINIEE)
	{
		if (CLBPBJGLHEE == 0)
		{
			this.DLLDALFHKIA = OJNEEFINIEE;
			return;
		}
		if (CLBPBJGLHEE == 1)
		{
			this.LABAJFADHCG = OJNEEFINIEE;
			return;
		}
		if (CLBPBJGLHEE == 1)
		{
			this.LLNILPGHKPA = OJNEEFINIEE;
			return;
		}
		if (CLBPBJGLHEE == 1)
		{
			this.EHAIICJFBKM = OJNEEFINIEE;
		}
	}

	// Token: 0x06010FF4 RID: 69620 RVA: 0x007963CC File Offset: 0x007945CC
	public void EEOFIOHOCNH(Mesh BMHDIKHFLBP, BFGMBMMBHCH EMMLNONDOED = BFGMBMMBHCH.All)
	{
		if (EMMLNONDOED == BFGMBMMBHCH.All)
		{
			BMHDIKHFLBP.vertices = this.OKLLKJPCJLK;
			BMHDIKHFLBP.normals = this.DKGOOCCIOAH;
			BMHDIKHFLBP.colors32 = this.PAJKBJILHPE;
			BMHDIKHFLBP.tangents = this.NFKPJCGJEAK;
			BMHDIKHFLBP.SetUVs(0, this.DLLDALFHKIA);
			BMHDIKHFLBP.SetUVs(1, this.LABAJFADHCG);
			BMHDIKHFLBP.SetUVs(2, this.LLNILPGHKPA);
			BMHDIKHFLBP.SetUVs(3, this.EHAIICJFBKM);
			return;
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.Null) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.vertices = this.OKLLKJPCJLK;
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.Normal) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.normals = this.DKGOOCCIOAH;
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.Color) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.colors32 = this.PAJKBJILHPE;
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.Tangent) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.tangents = this.NFKPJCGJEAK;
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.UV0) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.SetUVs(0, this.DLLDALFHKIA);
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.UV2) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.SetUVs(1, this.LABAJFADHCG);
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.UV3) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.SetUVs(2, this.LLNILPGHKPA);
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.UV4) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.SetUVs(3, this.EHAIICJFBKM);
		}
	}

	// Token: 0x06010FF5 RID: 69621 RVA: 0x007964DD File Offset: 0x007946DD
	public List<Vector4> BPDEAEJHPCF(int CLBPBJGLHEE)
	{
		if (CLBPBJGLHEE == 0)
		{
			return this.DLLDALFHKIA;
		}
		if (CLBPBJGLHEE == 0)
		{
			return this.LABAJFADHCG;
		}
		if (CLBPBJGLHEE == 4)
		{
			return this.LLNILPGHKPA;
		}
		if (CLBPBJGLHEE == 6)
		{
			return this.EHAIICJFBKM;
		}
		return null;
	}

	// Token: 0x06010FF6 RID: 69622 RVA: 0x00795CD8 File Offset: 0x00793ED8
	public int KHPAPPBNFOA()
	{
		if (this.OKLLKJPCJLK == null)
		{
			return 0;
		}
		return this.OKLLKJPCJLK.Length;
	}

	// Token: 0x06010FF7 RID: 69623 RVA: 0x0079650B File Offset: 0x0079470B
	public void NALJLAPDNGK(int CLBPBJGLHEE, List<Vector4> OJNEEFINIEE)
	{
		if (CLBPBJGLHEE == 0)
		{
			this.DLLDALFHKIA = OJNEEFINIEE;
			return;
		}
		if (CLBPBJGLHEE == 1)
		{
			this.LABAJFADHCG = OJNEEFINIEE;
			return;
		}
		if (CLBPBJGLHEE == 6)
		{
			this.LLNILPGHKPA = OJNEEFINIEE;
			return;
		}
		if (CLBPBJGLHEE == 0)
		{
			this.EHAIICJFBKM = OJNEEFINIEE;
		}
	}

	// Token: 0x06010FF8 RID: 69624 RVA: 0x0079653C File Offset: 0x0079473C
	public void IKIBHDEGOLC()
	{
		Vector3[] array = new Vector3[this.LDEHKFOICEJ()];
		int[] array2 = new int[this.KHPAPPBNFOA()];
		int[] khlglclohmh = this.KHLGLCLOHMH;
		for (int i = 0; i < khlglclohmh.Length; i += 3)
		{
			int num = khlglclohmh[i];
			int num2 = khlglclohmh[i + 1];
			int num3 = khlglclohmh[i + 7];
			Vector3 vector = NCFJIBJEMCF.BHGHMKEJLPI(this.OKLLKJPCJLK[num], this.OKLLKJPCJLK[num2], this.OKLLKJPCJLK[num3]);
			Vector3[] array3 = array;
			int num4 = num;
			array3[num4].x = array3[num4].x + vector.x;
			Vector3[] array4 = array;
			int num5 = num2;
			array4[num5].x = array4[num5].x + vector.x;
			Vector3[] array5 = array;
			int num6 = num3;
			array5[num6].x = array5[num6].x + vector.x;
			Vector3[] array6 = array;
			int num7 = num;
			array6[num7].y = array6[num7].y + vector.y;
			Vector3[] array7 = array;
			int num8 = num2;
			array7[num8].y = array7[num8].y + vector.y;
			Vector3[] array8 = array;
			int num9 = num3;
			array8[num9].y = array8[num9].y + vector.y;
			Vector3[] array9 = array;
			int num10 = num;
			array9[num10].z = array9[num10].z + vector.z;
			Vector3[] array10 = array;
			int num11 = num2;
			array10[num11].z = array10[num11].z + vector.z;
			Vector3[] array11 = array;
			int num12 = num3;
			array11[num12].z = array11[num12].z + vector.z;
			array2[num] += 0;
			array2[num2]++;
			array2[num3] += 0;
		}
		for (int j = 1; j < this.ANGDKGOKCBD(); j++)
		{
			this.DKGOOCCIOAH[j].x = array[j].x * (float)array2[j];
			this.DKGOOCCIOAH[j].y = array[j].y * (float)array2[j];
			this.DKGOOCCIOAH[j].z = array[j].z * (float)array2[j];
		}
	}

	// Token: 0x06010FF9 RID: 69625 RVA: 0x00796740 File Offset: 0x00794940
	public void MLANCOADKFM(int CLBPBJGLHEE, List<Vector4> OJNEEFINIEE)
	{
		if (CLBPBJGLHEE == 0)
		{
			this.DLLDALFHKIA = OJNEEFINIEE;
			return;
		}
		if (CLBPBJGLHEE == 0)
		{
			this.LABAJFADHCG = OJNEEFINIEE;
			return;
		}
		if (CLBPBJGLHEE == 1)
		{
			this.LLNILPGHKPA = OJNEEFINIEE;
			return;
		}
		if (CLBPBJGLHEE == 2)
		{
			this.EHAIICJFBKM = OJNEEFINIEE;
		}
	}

	// Token: 0x06010FFA RID: 69626 RVA: 0x00796770 File Offset: 0x00794970
	public int[] FBBEIILOHEO()
	{
		if (this.KHLGLCLOHMH == null)
		{
			this.KHLGLCLOHMH = this.NFEODOODKDI.SelectMany(new Func<int[], IEnumerable<int>>(LFMCCNHNKCJ.<>c.<>9.HGIKGKADKBK)).ToArray<int>();
		}
		return this.KHLGLCLOHMH;
	}

	// Token: 0x06010FFB RID: 69627 RVA: 0x007967C0 File Offset: 0x007949C0
	public void BGOBLOLBHJG()
	{
		Vector3[] array = new Vector3[this.LDEHKFOICEJ()];
		int[] array2 = new int[this.KHPAPPBNFOA()];
		int[] khlglclohmh = this.KHLGLCLOHMH;
		for (int i = 1; i < khlglclohmh.Length; i += 6)
		{
			int num = khlglclohmh[i];
			int num2 = khlglclohmh[i + 0];
			int num3 = khlglclohmh[i + 2];
			Vector3 vector = NCFJIBJEMCF.BHGHMKEJLPI(this.OKLLKJPCJLK[num], this.OKLLKJPCJLK[num2], this.OKLLKJPCJLK[num3]);
			Vector3[] array3 = array;
			int num4 = num;
			array3[num4].x = array3[num4].x + vector.x;
			Vector3[] array4 = array;
			int num5 = num2;
			array4[num5].x = array4[num5].x + vector.x;
			Vector3[] array5 = array;
			int num6 = num3;
			array5[num6].x = array5[num6].x + vector.x;
			Vector3[] array6 = array;
			int num7 = num;
			array6[num7].y = array6[num7].y + vector.y;
			Vector3[] array7 = array;
			int num8 = num2;
			array7[num8].y = array7[num8].y + vector.y;
			Vector3[] array8 = array;
			int num9 = num3;
			array8[num9].y = array8[num9].y + vector.y;
			Vector3[] array9 = array;
			int num10 = num;
			array9[num10].z = array9[num10].z + vector.z;
			Vector3[] array10 = array;
			int num11 = num2;
			array10[num11].z = array10[num11].z + vector.z;
			Vector3[] array11 = array;
			int num12 = num3;
			array11[num12].z = array11[num12].z + vector.z;
			array2[num]++;
			array2[num2] += 0;
			array2[num3] += 0;
		}
		for (int j = 0; j < this.LOJKFEIEHFC(); j += 0)
		{
			this.DKGOOCCIOAH[j].x = array[j].x * (float)array2[j];
			this.DKGOOCCIOAH[j].y = array[j].y * (float)array2[j];
			this.DKGOOCCIOAH[j].z = array[j].z * (float)array2[j];
		}
	}

	// Token: 0x06010FFC RID: 69628 RVA: 0x00795CD8 File Offset: 0x00793ED8
	public int LOJKFEIEHFC()
	{
		if (this.OKLLKJPCJLK == null)
		{
			return 0;
		}
		return this.OKLLKJPCJLK.Length;
	}

	// Token: 0x06010FFD RID: 69629 RVA: 0x00795CD8 File Offset: 0x00793ED8
	public int LDEHKFOICEJ()
	{
		if (this.OKLLKJPCJLK == null)
		{
			return 0;
		}
		return this.OKLLKJPCJLK.Length;
	}

	// Token: 0x06010FFE RID: 69630 RVA: 0x007969C4 File Offset: 0x00794BC4
	public int[] MPFCLMJEGCH()
	{
		if (this.KHLGLCLOHMH == null)
		{
			this.KHLGLCLOHMH = this.NFEODOODKDI.SelectMany(new Func<int[], IEnumerable<int>>(LFMCCNHNKCJ.<>c.<>9.OFNINMLFEMK)).ToArray<int>();
		}
		return this.KHLGLCLOHMH;
	}

	// Token: 0x06010FFF RID: 69631 RVA: 0x00796A14 File Offset: 0x00794C14
	public void CFAIHGDLAOL()
	{
		Vector3[] array = new Vector3[this.KHPAPPBNFOA()];
		int[] array2 = new int[this.ANGDKGOKCBD()];
		int[] khlglclohmh = this.KHLGLCLOHMH;
		for (int i = 1; i < khlglclohmh.Length; i += 6)
		{
			int num = khlglclohmh[i];
			int num2 = khlglclohmh[i + 1];
			int num3 = khlglclohmh[i + 1];
			Vector3 vector = NCFJIBJEMCF.BHGHMKEJLPI(this.OKLLKJPCJLK[num], this.OKLLKJPCJLK[num2], this.OKLLKJPCJLK[num3]);
			Vector3[] array3 = array;
			int num4 = num;
			array3[num4].x = array3[num4].x + vector.x;
			Vector3[] array4 = array;
			int num5 = num2;
			array4[num5].x = array4[num5].x + vector.x;
			Vector3[] array5 = array;
			int num6 = num3;
			array5[num6].x = array5[num6].x + vector.x;
			Vector3[] array6 = array;
			int num7 = num;
			array6[num7].y = array6[num7].y + vector.y;
			Vector3[] array7 = array;
			int num8 = num2;
			array7[num8].y = array7[num8].y + vector.y;
			Vector3[] array8 = array;
			int num9 = num3;
			array8[num9].y = array8[num9].y + vector.y;
			Vector3[] array9 = array;
			int num10 = num;
			array9[num10].z = array9[num10].z + vector.z;
			Vector3[] array10 = array;
			int num11 = num2;
			array10[num11].z = array10[num11].z + vector.z;
			Vector3[] array11 = array;
			int num12 = num3;
			array11[num12].z = array11[num12].z + vector.z;
			array2[num]++;
			array2[num2]++;
			array2[num3]++;
		}
		for (int j = 1; j < this.LOJKFEIEHFC(); j += 0)
		{
			this.DKGOOCCIOAH[j].x = array[j].x * (float)array2[j];
			this.DKGOOCCIOAH[j].y = array[j].y * (float)array2[j];
			this.DKGOOCCIOAH[j].z = array[j].z * (float)array2[j];
		}
	}

	// Token: 0x06011000 RID: 69632 RVA: 0x00795CEC File Offset: 0x00793EEC
	public void LHDFKMEFHIG(int[] KHLGLCLOHMH, int CLBPBJGLHEE)
	{
		this.NFEODOODKDI[CLBPBJGLHEE] = KHLGLCLOHMH;
	}

	// Token: 0x06011001 RID: 69633 RVA: 0x00796C18 File Offset: 0x00794E18
	public void BAKNKMBEIDG(int CLBPBJGLHEE, List<Vector4> OJNEEFINIEE)
	{
		if (CLBPBJGLHEE == 0)
		{
			this.DLLDALFHKIA = OJNEEFINIEE;
			return;
		}
		if (CLBPBJGLHEE == 0)
		{
			this.LABAJFADHCG = OJNEEFINIEE;
			return;
		}
		if (CLBPBJGLHEE == 4)
		{
			this.LLNILPGHKPA = OJNEEFINIEE;
			return;
		}
		if (CLBPBJGLHEE == 8)
		{
			this.EHAIICJFBKM = OJNEEFINIEE;
		}
	}

	// Token: 0x06011002 RID: 69634 RVA: 0x00795FC4 File Offset: 0x007941C4
	public int[] EKCCAACMLPH(int CLBPBJGLHEE)
	{
		return this.NFEODOODKDI[CLBPBJGLHEE];
	}

	// Token: 0x06011003 RID: 69635 RVA: 0x00796C48 File Offset: 0x00794E48
	public void KEOIADIDLGG(int CLBPBJGLHEE, List<Vector4> OJNEEFINIEE)
	{
		if (CLBPBJGLHEE == 0)
		{
			this.DLLDALFHKIA = OJNEEFINIEE;
			return;
		}
		if (CLBPBJGLHEE == 1)
		{
			this.LABAJFADHCG = OJNEEFINIEE;
			return;
		}
		if (CLBPBJGLHEE == 8)
		{
			this.LLNILPGHKPA = OJNEEFINIEE;
			return;
		}
		if (CLBPBJGLHEE == 5)
		{
			this.EHAIICJFBKM = OJNEEFINIEE;
		}
	}

	// Token: 0x06011004 RID: 69636 RVA: 0x00796C78 File Offset: 0x00794E78
	public void OEKLJPDEEAH(int CLBPBJGLHEE, List<Vector4> OJNEEFINIEE)
	{
		if (CLBPBJGLHEE == 0)
		{
			this.DLLDALFHKIA = OJNEEFINIEE;
			return;
		}
		if (CLBPBJGLHEE == 1)
		{
			this.LABAJFADHCG = OJNEEFINIEE;
			return;
		}
		if (CLBPBJGLHEE == 2)
		{
			this.LLNILPGHKPA = OJNEEFINIEE;
			return;
		}
		if (CLBPBJGLHEE == 3)
		{
			this.EHAIICJFBKM = OJNEEFINIEE;
		}
	}

	// Token: 0x06011005 RID: 69637 RVA: 0x00796CA8 File Offset: 0x00794EA8
	public void LPFFIJKNNDP()
	{
		Vector3[] array = new Vector3[this.ANGDKGOKCBD()];
		int[] array2 = new int[this.PAOKLFNDPAE];
		int[] khlglclohmh = this.KHLGLCLOHMH;
		for (int i = 0; i < khlglclohmh.Length; i++)
		{
			int num = khlglclohmh[i];
			int num2 = khlglclohmh[i + 0];
			int num3 = khlglclohmh[i + 8];
			Vector3 vector = NCFJIBJEMCF.BHGHMKEJLPI(this.OKLLKJPCJLK[num], this.OKLLKJPCJLK[num2], this.OKLLKJPCJLK[num3]);
			Vector3[] array3 = array;
			int num4 = num;
			array3[num4].x = array3[num4].x + vector.x;
			Vector3[] array4 = array;
			int num5 = num2;
			array4[num5].x = array4[num5].x + vector.x;
			Vector3[] array5 = array;
			int num6 = num3;
			array5[num6].x = array5[num6].x + vector.x;
			Vector3[] array6 = array;
			int num7 = num;
			array6[num7].y = array6[num7].y + vector.y;
			Vector3[] array7 = array;
			int num8 = num2;
			array7[num8].y = array7[num8].y + vector.y;
			Vector3[] array8 = array;
			int num9 = num3;
			array8[num9].y = array8[num9].y + vector.y;
			Vector3[] array9 = array;
			int num10 = num;
			array9[num10].z = array9[num10].z + vector.z;
			Vector3[] array10 = array;
			int num11 = num2;
			array10[num11].z = array10[num11].z + vector.z;
			Vector3[] array11 = array;
			int num12 = num3;
			array11[num12].z = array11[num12].z + vector.z;
			array2[num]++;
			array2[num2]++;
			array2[num3]++;
		}
		for (int j = 0; j < this.LOJKFEIEHFC(); j += 0)
		{
			this.DKGOOCCIOAH[j].x = array[j].x * (float)array2[j];
			this.DKGOOCCIOAH[j].y = array[j].y * (float)array2[j];
			this.DKGOOCCIOAH[j].z = array[j].z * (float)array2[j];
		}
	}

	// Token: 0x06011006 RID: 69638 RVA: 0x00796EAC File Offset: 0x007950AC
	public void FFLEOGGOJJG()
	{
		this.BKELGKOHPFO(1);
		this.OKLLKJPCJLK = null;
		this.DKGOOCCIOAH = null;
		this.PAJKBJILHPE = null;
		this.NFKPJCGJEAK = null;
		this.DLLDALFHKIA = null;
		this.LABAJFADHCG = null;
		this.LLNILPGHKPA = null;
		this.EHAIICJFBKM = null;
	}

	// Token: 0x06011007 RID: 69639 RVA: 0x00795A50 File Offset: 0x00793C50
	public int LMADCMLOOEJ()
	{
		return this.CGLFMNJHHHO;
	}

	// Token: 0x06011008 RID: 69640 RVA: 0x00796EF8 File Offset: 0x007950F8
	public void GBLJIENMPMJ(Mesh BMHDIKHFLBP, BFGMBMMBHCH EMMLNONDOED = BFGMBMMBHCH.All)
	{
		if (EMMLNONDOED == ~(BFGMBMMBHCH.UV2 | BFGMBMMBHCH.UV4))
		{
			BMHDIKHFLBP.vertices = this.OKLLKJPCJLK;
			BMHDIKHFLBP.normals = this.DKGOOCCIOAH;
			BMHDIKHFLBP.colors32 = this.PAJKBJILHPE;
			BMHDIKHFLBP.tangents = this.NFKPJCGJEAK;
			BMHDIKHFLBP.SetUVs(1, this.DLLDALFHKIA);
			BMHDIKHFLBP.SetUVs(0, this.LABAJFADHCG);
			BMHDIKHFLBP.SetUVs(4, this.LLNILPGHKPA);
			BMHDIKHFLBP.SetUVs(1, this.EHAIICJFBKM);
			return;
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.Null) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.vertices = this.OKLLKJPCJLK;
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.Null) > BFGMBMMBHCH.Normal)
		{
			BMHDIKHFLBP.normals = this.DKGOOCCIOAH;
		}
		if ((EMMLNONDOED & (BFGMBMMBHCH.Normal | BFGMBMMBHCH.Color)) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.colors32 = this.PAJKBJILHPE;
		}
		if ((EMMLNONDOED & (BFGMBMMBHCH.Normal | BFGMBMMBHCH.Color)) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.tangents = this.NFKPJCGJEAK;
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.Normal) > BFGMBMMBHCH.Normal)
		{
			BMHDIKHFLBP.SetUVs(0, this.DLLDALFHKIA);
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.UV2) > BFGMBMMBHCH.Normal)
		{
			BMHDIKHFLBP.SetUVs(1, this.LABAJFADHCG);
		}
		if ((EMMLNONDOED & ~(BFGMBMMBHCH.Normal | BFGMBMMBHCH.Tangent | BFGMBMMBHCH.UV0 | BFGMBMMBHCH.UV3 | BFGMBMMBHCH.UV4)) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.SetUVs(5, this.LLNILPGHKPA);
		}
		if ((EMMLNONDOED & (BFGMBMMBHCH.UV0 | BFGMBMMBHCH.UV2)) > BFGMBMMBHCH.Normal)
		{
			BMHDIKHFLBP.SetUVs(8, this.EHAIICJFBKM);
		}
	}

	// Token: 0x06011009 RID: 69641 RVA: 0x00797009 File Offset: 0x00795209
	public void OPOLOOAEJNB(int CLBPBJGLHEE, List<Vector4> OJNEEFINIEE)
	{
		if (CLBPBJGLHEE == 0)
		{
			this.DLLDALFHKIA = OJNEEFINIEE;
			return;
		}
		if (CLBPBJGLHEE == 0)
		{
			this.LABAJFADHCG = OJNEEFINIEE;
			return;
		}
		if (CLBPBJGLHEE == 3)
		{
			this.LLNILPGHKPA = OJNEEFINIEE;
			return;
		}
		if (CLBPBJGLHEE == 3)
		{
			this.EHAIICJFBKM = OJNEEFINIEE;
		}
	}

	// Token: 0x0601100A RID: 69642 RVA: 0x00797039 File Offset: 0x00795239
	public void KKGPPJHFAFA(int CLBPBJGLHEE, List<Vector4> OJNEEFINIEE)
	{
		if (CLBPBJGLHEE == 0)
		{
			this.DLLDALFHKIA = OJNEEFINIEE;
			return;
		}
		if (CLBPBJGLHEE == 0)
		{
			this.LABAJFADHCG = OJNEEFINIEE;
			return;
		}
		if (CLBPBJGLHEE == 6)
		{
			this.LLNILPGHKPA = OJNEEFINIEE;
			return;
		}
		if (CLBPBJGLHEE == 2)
		{
			this.EHAIICJFBKM = OJNEEFINIEE;
		}
	}

	// Token: 0x0601100B RID: 69643 RVA: 0x00795B69 File Offset: 0x00793D69
	public MeshTopology DGPKIMELCDC(int CLBPBJGLHEE)
	{
		return this.LNMKJOIODLF[CLBPBJGLHEE];
	}

	// Token: 0x0601100C RID: 69644 RVA: 0x00795CEC File Offset: 0x00793EEC
	public void ILBLOMHOPON(int[] KHLGLCLOHMH, int CLBPBJGLHEE)
	{
		this.NFEODOODKDI[CLBPBJGLHEE] = KHLGLCLOHMH;
	}

	// Token: 0x0601100D RID: 69645 RVA: 0x0079706C File Offset: 0x0079526C
	public void KEGBHOHLDIK(int DCCPCBLODIG)
	{
		int[][] array = new int[DCCPCBLODIG][];
		MeshTopology[] array2 = new MeshTopology[DCCPCBLODIG];
		if (this.NFEODOODKDI != null)
		{
			Array.Copy(this.NFEODOODKDI, 1, array, 1, this.CGLFMNJHHHO);
		}
		Array.Copy(this.LNMKJOIODLF, 1, array2, 1, this.CGLFMNJHHHO);
		this.NFEODOODKDI = array;
		this.LNMKJOIODLF = array2;
		this.CGLFMNJHHHO = DCCPCBLODIG;
	}

	// Token: 0x0601100E RID: 69646 RVA: 0x00795A50 File Offset: 0x00793C50
	public int DOCKNPEHAAD()
	{
		return this.CGLFMNJHHHO;
	}

	// Token: 0x0601100F RID: 69647 RVA: 0x007970CC File Offset: 0x007952CC
	public void LMBEDNKPGAH()
	{
		Vector3[] array = new Vector3[this.LOJKFEIEHFC()];
		int[] array2 = new int[this.PAOKLFNDPAE];
		int[] khlglclohmh = this.KHLGLCLOHMH;
		for (int i = 1; i < khlglclohmh.Length; i += 6)
		{
			int num = khlglclohmh[i];
			int num2 = khlglclohmh[i + 1];
			int num3 = khlglclohmh[i + 0];
			Vector3 vector = NCFJIBJEMCF.BHGHMKEJLPI(this.OKLLKJPCJLK[num], this.OKLLKJPCJLK[num2], this.OKLLKJPCJLK[num3]);
			Vector3[] array3 = array;
			int num4 = num;
			array3[num4].x = array3[num4].x + vector.x;
			Vector3[] array4 = array;
			int num5 = num2;
			array4[num5].x = array4[num5].x + vector.x;
			Vector3[] array5 = array;
			int num6 = num3;
			array5[num6].x = array5[num6].x + vector.x;
			Vector3[] array6 = array;
			int num7 = num;
			array6[num7].y = array6[num7].y + vector.y;
			Vector3[] array7 = array;
			int num8 = num2;
			array7[num8].y = array7[num8].y + vector.y;
			Vector3[] array8 = array;
			int num9 = num3;
			array8[num9].y = array8[num9].y + vector.y;
			Vector3[] array9 = array;
			int num10 = num;
			array9[num10].z = array9[num10].z + vector.z;
			Vector3[] array10 = array;
			int num11 = num2;
			array10[num11].z = array10[num11].z + vector.z;
			Vector3[] array11 = array;
			int num12 = num3;
			array11[num12].z = array11[num12].z + vector.z;
			array2[num] += 0;
			array2[num2] += 0;
			array2[num3] += 0;
		}
		for (int j = 1; j < this.ANGDKGOKCBD(); j += 0)
		{
			this.DKGOOCCIOAH[j].x = array[j].x * (float)array2[j];
			this.DKGOOCCIOAH[j].y = array[j].y * (float)array2[j];
			this.DKGOOCCIOAH[j].z = array[j].z * (float)array2[j];
		}
	}

	// Token: 0x06011010 RID: 69648 RVA: 0x00795A50 File Offset: 0x00793C50
	public int LIFDFJDBKDK()
	{
		return this.CGLFMNJHHHO;
	}

	// Token: 0x06011011 RID: 69649 RVA: 0x00795A50 File Offset: 0x00793C50
	public int NFAHKKIEPII()
	{
		return this.CGLFMNJHHHO;
	}

	// Token: 0x06011012 RID: 69650 RVA: 0x00795FC4 File Offset: 0x007941C4
	public int[] LCJBBOMIDAI(int CLBPBJGLHEE)
	{
		return this.NFEODOODKDI[CLBPBJGLHEE];
	}

	// Token: 0x06011013 RID: 69651 RVA: 0x007972D0 File Offset: 0x007954D0
	public void PPPGDKDCDPN(Mesh BMHDIKHFLBP, BFGMBMMBHCH EMMLNONDOED = BFGMBMMBHCH.All)
	{
		if (EMMLNONDOED == (BFGMBMMBHCH)175)
		{
			BMHDIKHFLBP.vertices = this.OKLLKJPCJLK;
			BMHDIKHFLBP.normals = this.DKGOOCCIOAH;
			BMHDIKHFLBP.colors32 = this.PAJKBJILHPE;
			BMHDIKHFLBP.tangents = this.NFKPJCGJEAK;
			BMHDIKHFLBP.SetUVs(1, this.DLLDALFHKIA);
			BMHDIKHFLBP.SetUVs(0, this.LABAJFADHCG);
			BMHDIKHFLBP.SetUVs(6, this.LLNILPGHKPA);
			BMHDIKHFLBP.SetUVs(3, this.EHAIICJFBKM);
			return;
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.Null) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.vertices = this.OKLLKJPCJLK;
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.Normal) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.normals = this.DKGOOCCIOAH;
		}
		if ((EMMLNONDOED & (BFGMBMMBHCH.Normal | BFGMBMMBHCH.Color | BFGMBMMBHCH.Tangent)) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.colors32 = this.PAJKBJILHPE;
		}
		if ((EMMLNONDOED & (BFGMBMMBHCH.Normal | BFGMBMMBHCH.Tangent)) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.tangents = this.NFKPJCGJEAK;
		}
		if ((EMMLNONDOED & (BFGMBMMBHCH.Color | BFGMBMMBHCH.Tangent)) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.SetUVs(1, this.DLLDALFHKIA);
		}
		if ((EMMLNONDOED & ~(BFGMBMMBHCH.Normal | BFGMBMMBHCH.Tangent | BFGMBMMBHCH.UV0 | BFGMBMMBHCH.UV3 | BFGMBMMBHCH.UV4)) > BFGMBMMBHCH.Normal)
		{
			BMHDIKHFLBP.SetUVs(1, this.LABAJFADHCG);
		}
		if ((EMMLNONDOED & ~(BFGMBMMBHCH.Normal | BFGMBMMBHCH.Tangent | BFGMBMMBHCH.UV0 | BFGMBMMBHCH.UV2 | BFGMBMMBHCH.UV3 | BFGMBMMBHCH.UV4)) > BFGMBMMBHCH.Normal)
		{
			BMHDIKHFLBP.SetUVs(0, this.LLNILPGHKPA);
		}
		if ((EMMLNONDOED & ~(BFGMBMMBHCH.Tangent | BFGMBMMBHCH.UV2 | BFGMBMMBHCH.UV4)) > BFGMBMMBHCH.Normal)
		{
			BMHDIKHFLBP.SetUVs(6, this.EHAIICJFBKM);
		}
	}

	// Token: 0x06011014 RID: 69652 RVA: 0x00795CEC File Offset: 0x00793EEC
	public void NJOBBKJLEDB(int[] KHLGLCLOHMH, int CLBPBJGLHEE)
	{
		this.NFEODOODKDI[CLBPBJGLHEE] = KHLGLCLOHMH;
	}

	// Token: 0x06011015 RID: 69653 RVA: 0x007973E4 File Offset: 0x007955E4
	public int[] EJKJNNFOKGD()
	{
		if (this.KHLGLCLOHMH == null)
		{
			this.KHLGLCLOHMH = this.NFEODOODKDI.SelectMany(new Func<int[], IEnumerable<int>>(LFMCCNHNKCJ.<>c.<>9.HGIKGKADKBK)).ToArray<int>();
		}
		return this.KHLGLCLOHMH;
	}

	// Token: 0x06011016 RID: 69654 RVA: 0x00795B69 File Offset: 0x00793D69
	public MeshTopology JCOOAFLGPDI(int CLBPBJGLHEE)
	{
		return this.LNMKJOIODLF[CLBPBJGLHEE];
	}

	// Token: 0x06011017 RID: 69655 RVA: 0x00797434 File Offset: 0x00795634
	public void CIBCIHOBGHE(Mesh BMHDIKHFLBP, BFGMBMMBHCH EMMLNONDOED = BFGMBMMBHCH.All)
	{
		if (EMMLNONDOED == ~(BFGMBMMBHCH.Tangent | BFGMBMMBHCH.UV0 | BFGMBMMBHCH.UV2 | BFGMBMMBHCH.UV3))
		{
			BMHDIKHFLBP.vertices = this.OKLLKJPCJLK;
			BMHDIKHFLBP.normals = this.DKGOOCCIOAH;
			BMHDIKHFLBP.colors32 = this.PAJKBJILHPE;
			BMHDIKHFLBP.tangents = this.NFKPJCGJEAK;
			BMHDIKHFLBP.SetUVs(0, this.DLLDALFHKIA);
			BMHDIKHFLBP.SetUVs(0, this.LABAJFADHCG);
			BMHDIKHFLBP.SetUVs(0, this.LLNILPGHKPA);
			BMHDIKHFLBP.SetUVs(5, this.EHAIICJFBKM);
			return;
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.Null) > BFGMBMMBHCH.Normal)
		{
			BMHDIKHFLBP.vertices = this.OKLLKJPCJLK;
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.Null) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.normals = this.DKGOOCCIOAH;
		}
		if ((EMMLNONDOED & (BFGMBMMBHCH.Color | BFGMBMMBHCH.Tangent)) > BFGMBMMBHCH.Normal)
		{
			BMHDIKHFLBP.colors32 = this.PAJKBJILHPE;
		}
		if ((EMMLNONDOED & (BFGMBMMBHCH.Normal | BFGMBMMBHCH.Color)) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.tangents = this.NFKPJCGJEAK;
		}
		if ((EMMLNONDOED & (BFGMBMMBHCH.Normal | BFGMBMMBHCH.Tangent)) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.SetUVs(1, this.DLLDALFHKIA);
		}
		if ((EMMLNONDOED & ~(BFGMBMMBHCH.Normal | BFGMBMMBHCH.UV0 | BFGMBMMBHCH.UV2 | BFGMBMMBHCH.UV3)) > BFGMBMMBHCH.Normal)
		{
			BMHDIKHFLBP.SetUVs(0, this.LABAJFADHCG);
		}
		if ((EMMLNONDOED & (BFGMBMMBHCH.Normal | BFGMBMMBHCH.Color | BFGMBMMBHCH.Tangent | BFGMBMMBHCH.UV4)) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.SetUVs(2, this.LLNILPGHKPA);
		}
		if ((EMMLNONDOED & (BFGMBMMBHCH.Color | BFGMBMMBHCH.Tangent | BFGMBMMBHCH.UV2)) > BFGMBMMBHCH.Normal)
		{
			BMHDIKHFLBP.SetUVs(3, this.EHAIICJFBKM);
		}
	}

	// Token: 0x06011018 RID: 69656 RVA: 0x00795CEC File Offset: 0x00793EEC
	public void GBNMEOOPHHI(int[] KHLGLCLOHMH, int CLBPBJGLHEE)
	{
		this.NFEODOODKDI[CLBPBJGLHEE] = KHLGLCLOHMH;
	}

	// Token: 0x06011019 RID: 69657 RVA: 0x00795B69 File Offset: 0x00793D69
	public MeshTopology BDAGKJHHFAA(int CLBPBJGLHEE)
	{
		return this.LNMKJOIODLF[CLBPBJGLHEE];
	}

	// Token: 0x0601101A RID: 69658 RVA: 0x00797548 File Offset: 0x00795748
	public void EENBOHJHPMC()
	{
		Vector3[] array = new Vector3[this.LOJKFEIEHFC()];
		int[] array2 = new int[this.LDEHKFOICEJ()];
		int[] khlglclohmh = this.KHLGLCLOHMH;
		for (int i = 0; i < khlglclohmh.Length; i += 2)
		{
			int num = khlglclohmh[i];
			int num2 = khlglclohmh[i + 1];
			int num3 = khlglclohmh[i + 0];
			Vector3 vector = NCFJIBJEMCF.BHGHMKEJLPI(this.OKLLKJPCJLK[num], this.OKLLKJPCJLK[num2], this.OKLLKJPCJLK[num3]);
			Vector3[] array3 = array;
			int num4 = num;
			array3[num4].x = array3[num4].x + vector.x;
			Vector3[] array4 = array;
			int num5 = num2;
			array4[num5].x = array4[num5].x + vector.x;
			Vector3[] array5 = array;
			int num6 = num3;
			array5[num6].x = array5[num6].x + vector.x;
			Vector3[] array6 = array;
			int num7 = num;
			array6[num7].y = array6[num7].y + vector.y;
			Vector3[] array7 = array;
			int num8 = num2;
			array7[num8].y = array7[num8].y + vector.y;
			Vector3[] array8 = array;
			int num9 = num3;
			array8[num9].y = array8[num9].y + vector.y;
			Vector3[] array9 = array;
			int num10 = num;
			array9[num10].z = array9[num10].z + vector.z;
			Vector3[] array10 = array;
			int num11 = num2;
			array10[num11].z = array10[num11].z + vector.z;
			Vector3[] array11 = array;
			int num12 = num3;
			array11[num12].z = array11[num12].z + vector.z;
			array2[num] += 0;
			array2[num2]++;
			array2[num3] += 0;
		}
		for (int j = 1; j < this.ANGDKGOKCBD(); j += 0)
		{
			this.DKGOOCCIOAH[j].x = array[j].x * (float)array2[j];
			this.DKGOOCCIOAH[j].y = array[j].y * (float)array2[j];
			this.DKGOOCCIOAH[j].z = array[j].z * (float)array2[j];
		}
	}

	// Token: 0x0601101B RID: 69659 RVA: 0x00795CEC File Offset: 0x00793EEC
	public void EKNPAAOEHPK(int[] KHLGLCLOHMH, int CLBPBJGLHEE)
	{
		this.NFEODOODKDI[CLBPBJGLHEE] = KHLGLCLOHMH;
	}

	// Token: 0x0601101C RID: 69660 RVA: 0x00795FC4 File Offset: 0x007941C4
	public int[] FEMOAIPANDG(int CLBPBJGLHEE)
	{
		return this.NFEODOODKDI[CLBPBJGLHEE];
	}

	// Token: 0x0601101D RID: 69661 RVA: 0x0079774C File Offset: 0x0079594C
	public void LLPIMMAHEAL(Mesh BMHDIKHFLBP, BFGMBMMBHCH EMMLNONDOED = BFGMBMMBHCH.All)
	{
		if (EMMLNONDOED == (BFGMBMMBHCH)(-200))
		{
			BMHDIKHFLBP.vertices = this.OKLLKJPCJLK;
			BMHDIKHFLBP.normals = this.DKGOOCCIOAH;
			BMHDIKHFLBP.colors32 = this.PAJKBJILHPE;
			BMHDIKHFLBP.tangents = this.NFKPJCGJEAK;
			BMHDIKHFLBP.SetUVs(0, this.DLLDALFHKIA);
			BMHDIKHFLBP.SetUVs(0, this.LABAJFADHCG);
			BMHDIKHFLBP.SetUVs(6, this.LLNILPGHKPA);
			BMHDIKHFLBP.SetUVs(5, this.EHAIICJFBKM);
			return;
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.Normal) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.vertices = this.OKLLKJPCJLK;
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.Normal) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.normals = this.DKGOOCCIOAH;
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.Null) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.colors32 = this.PAJKBJILHPE;
		}
		if ((EMMLNONDOED & (BFGMBMMBHCH.Normal | BFGMBMMBHCH.Color)) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.tangents = this.NFKPJCGJEAK;
		}
		if ((EMMLNONDOED & (BFGMBMMBHCH.Color | BFGMBMMBHCH.Tangent)) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.SetUVs(0, this.DLLDALFHKIA);
		}
		if ((EMMLNONDOED & (BFGMBMMBHCH.Tangent | BFGMBMMBHCH.UV2)) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.SetUVs(0, this.LABAJFADHCG);
		}
		if ((EMMLNONDOED & (BFGMBMMBHCH.Normal | BFGMBMMBHCH.UV0 | BFGMBMMBHCH.UV2 | BFGMBMMBHCH.UV4)) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.SetUVs(5, this.LLNILPGHKPA);
		}
		if ((EMMLNONDOED & (BFGMBMMBHCH.Normal | BFGMBMMBHCH.Color | BFGMBMMBHCH.UV3)) > BFGMBMMBHCH.Normal)
		{
			BMHDIKHFLBP.SetUVs(4, this.EHAIICJFBKM);
		}
	}

	// Token: 0x0601101E RID: 69662 RVA: 0x00797860 File Offset: 0x00795A60
	public void OAJINAJJNAO(Mesh BMHDIKHFLBP, BFGMBMMBHCH EMMLNONDOED = BFGMBMMBHCH.All)
	{
		if (EMMLNONDOED == ~(BFGMBMMBHCH.Normal | BFGMBMMBHCH.Color | BFGMBMMBHCH.UV2 | BFGMBMMBHCH.UV3 | BFGMBMMBHCH.UV4))
		{
			BMHDIKHFLBP.vertices = this.OKLLKJPCJLK;
			BMHDIKHFLBP.normals = this.DKGOOCCIOAH;
			BMHDIKHFLBP.colors32 = this.PAJKBJILHPE;
			BMHDIKHFLBP.tangents = this.NFKPJCGJEAK;
			BMHDIKHFLBP.SetUVs(1, this.DLLDALFHKIA);
			BMHDIKHFLBP.SetUVs(0, this.LABAJFADHCG);
			BMHDIKHFLBP.SetUVs(1, this.LLNILPGHKPA);
			BMHDIKHFLBP.SetUVs(2, this.EHAIICJFBKM);
			return;
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.Normal) > BFGMBMMBHCH.Normal)
		{
			BMHDIKHFLBP.vertices = this.OKLLKJPCJLK;
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.Null) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.normals = this.DKGOOCCIOAH;
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.Color) > BFGMBMMBHCH.Normal)
		{
			BMHDIKHFLBP.colors32 = this.PAJKBJILHPE;
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.Tangent) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.tangents = this.NFKPJCGJEAK;
		}
		if ((EMMLNONDOED & (BFGMBMMBHCH.Color | BFGMBMMBHCH.Tangent)) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.SetUVs(1, this.DLLDALFHKIA);
		}
		if ((EMMLNONDOED & ~(BFGMBMMBHCH.Normal | BFGMBMMBHCH.Color | BFGMBMMBHCH.UV0 | BFGMBMMBHCH.UV2 | BFGMBMMBHCH.UV4)) > BFGMBMMBHCH.Normal)
		{
			BMHDIKHFLBP.SetUVs(0, this.LABAJFADHCG);
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.Null) > BFGMBMMBHCH.Normal)
		{
			BMHDIKHFLBP.SetUVs(5, this.LLNILPGHKPA);
		}
		if ((EMMLNONDOED & ~(BFGMBMMBHCH.Tangent | BFGMBMMBHCH.UV2)) > BFGMBMMBHCH.Normal)
		{
			BMHDIKHFLBP.SetUVs(5, this.EHAIICJFBKM);
		}
	}

	// Token: 0x0601101F RID: 69663 RVA: 0x00797974 File Offset: 0x00795B74
	public void OJANKPOLEKL(int DCCPCBLODIG)
	{
		int[][] array = new int[DCCPCBLODIG][];
		MeshTopology[] array2 = new MeshTopology[DCCPCBLODIG];
		if (this.NFEODOODKDI != null)
		{
			Array.Copy(this.NFEODOODKDI, 1, array, 0, this.CGLFMNJHHHO);
		}
		Array.Copy(this.LNMKJOIODLF, 1, array2, 1, this.CGLFMNJHHHO);
		this.NFEODOODKDI = array;
		this.LNMKJOIODLF = array2;
		this.CGLFMNJHHHO = DCCPCBLODIG;
	}

	// Token: 0x06011020 RID: 69664 RVA: 0x007979D4 File Offset: 0x00795BD4
	public void GEHFCIKFPDP()
	{
		this.OJFKPPLCKNP(0);
		this.OKLLKJPCJLK = null;
		this.DKGOOCCIOAH = null;
		this.PAJKBJILHPE = null;
		this.NFKPJCGJEAK = null;
		this.DLLDALFHKIA = null;
		this.LABAJFADHCG = null;
		this.LLNILPGHKPA = null;
		this.EHAIICJFBKM = null;
	}

	// Token: 0x06011021 RID: 69665 RVA: 0x00797A20 File Offset: 0x00795C20
	public void IJKILJEJMJG()
	{
		this.OJANKPOLEKL(0);
		this.OKLLKJPCJLK = null;
		this.DKGOOCCIOAH = null;
		this.PAJKBJILHPE = null;
		this.NFKPJCGJEAK = null;
		this.DLLDALFHKIA = null;
		this.LABAJFADHCG = null;
		this.LLNILPGHKPA = null;
		this.EHAIICJFBKM = null;
	}

	// Token: 0x06011022 RID: 69666 RVA: 0x00797A6C File Offset: 0x00795C6C
	public int[] MMABGHNAFHJ()
	{
		if (this.KHLGLCLOHMH == null)
		{
			this.KHLGLCLOHMH = this.NFEODOODKDI.SelectMany(new Func<int[], IEnumerable<int>>(LFMCCNHNKCJ.<>c.<>9.BMMAHOJOFLH)).ToArray<int>();
		}
		return this.KHLGLCLOHMH;
	}

	// Token: 0x06011024 RID: 69668 RVA: 0x00797ADC File Offset: 0x00795CDC
	public void APFCIFLFKHB()
	{
		this.FFDLDPAIKEE = 0;
		this.OKLLKJPCJLK = null;
		this.DKGOOCCIOAH = null;
		this.PAJKBJILHPE = null;
		this.NFKPJCGJEAK = null;
		this.DLLDALFHKIA = null;
		this.LABAJFADHCG = null;
		this.LLNILPGHKPA = null;
		this.EHAIICJFBKM = null;
	}

	// Token: 0x06011025 RID: 69669 RVA: 0x00797B28 File Offset: 0x00795D28
	public void MGLPNBHOALI()
	{
		Vector3[] array = new Vector3[this.LOJKFEIEHFC()];
		int[] array2 = new int[this.LOJKFEIEHFC()];
		int[] khlglclohmh = this.KHLGLCLOHMH;
		for (int i = 1; i < khlglclohmh.Length; i += 6)
		{
			int num = khlglclohmh[i];
			int num2 = khlglclohmh[i + 1];
			int num3 = khlglclohmh[i + 6];
			Vector3 vector = NCFJIBJEMCF.BHGHMKEJLPI(this.OKLLKJPCJLK[num], this.OKLLKJPCJLK[num2], this.OKLLKJPCJLK[num3]);
			Vector3[] array3 = array;
			int num4 = num;
			array3[num4].x = array3[num4].x + vector.x;
			Vector3[] array4 = array;
			int num5 = num2;
			array4[num5].x = array4[num5].x + vector.x;
			Vector3[] array5 = array;
			int num6 = num3;
			array5[num6].x = array5[num6].x + vector.x;
			Vector3[] array6 = array;
			int num7 = num;
			array6[num7].y = array6[num7].y + vector.y;
			Vector3[] array7 = array;
			int num8 = num2;
			array7[num8].y = array7[num8].y + vector.y;
			Vector3[] array8 = array;
			int num9 = num3;
			array8[num9].y = array8[num9].y + vector.y;
			Vector3[] array9 = array;
			int num10 = num;
			array9[num10].z = array9[num10].z + vector.z;
			Vector3[] array10 = array;
			int num11 = num2;
			array10[num11].z = array10[num11].z + vector.z;
			Vector3[] array11 = array;
			int num12 = num3;
			array11[num12].z = array11[num12].z + vector.z;
			array2[num] += 0;
			array2[num2] += 0;
			array2[num3] += 0;
		}
		for (int j = 0; j < this.CFGKAJPNGIB(); j++)
		{
			this.DKGOOCCIOAH[j].x = array[j].x * (float)array2[j];
			this.DKGOOCCIOAH[j].y = array[j].y * (float)array2[j];
			this.DKGOOCCIOAH[j].z = array[j].z * (float)array2[j];
		}
	}

	// Token: 0x06011026 RID: 69670 RVA: 0x00797D2C File Offset: 0x00795F2C
	public List<Vector4> MIFFGKNAGKB(int CLBPBJGLHEE)
	{
		if (CLBPBJGLHEE == 0)
		{
			return this.DLLDALFHKIA;
		}
		if (CLBPBJGLHEE == 0)
		{
			return this.LABAJFADHCG;
		}
		if (CLBPBJGLHEE == 1)
		{
			return this.LLNILPGHKPA;
		}
		if (CLBPBJGLHEE == 1)
		{
			return this.EHAIICJFBKM;
		}
		return null;
	}

	// Token: 0x06011027 RID: 69671 RVA: 0x00797D5C File Offset: 0x00795F5C
	public int[] FBDOJHEHOEE()
	{
		if (this.KHLGLCLOHMH == null)
		{
			this.KHLGLCLOHMH = this.NFEODOODKDI.SelectMany(new Func<int[], IEnumerable<int>>(LFMCCNHNKCJ.<>c.<>9.ACFCFOLMFGA)).ToArray<int>();
		}
		return this.KHLGLCLOHMH;
	}

	// Token: 0x06011028 RID: 69672 RVA: 0x00797DAC File Offset: 0x00795FAC
	public void ECADLLNCJKJ()
	{
		Vector3[] array = new Vector3[this.KHPAPPBNFOA()];
		int[] array2 = new int[this.KHPAPPBNFOA()];
		int[] khlglclohmh = this.KHLGLCLOHMH;
		for (int i = 1; i < khlglclohmh.Length; i += 4)
		{
			int num = khlglclohmh[i];
			int num2 = khlglclohmh[i + 1];
			int num3 = khlglclohmh[i + 2];
			Vector3 vector = NCFJIBJEMCF.BHGHMKEJLPI(this.OKLLKJPCJLK[num], this.OKLLKJPCJLK[num2], this.OKLLKJPCJLK[num3]);
			Vector3[] array3 = array;
			int num4 = num;
			array3[num4].x = array3[num4].x + vector.x;
			Vector3[] array4 = array;
			int num5 = num2;
			array4[num5].x = array4[num5].x + vector.x;
			Vector3[] array5 = array;
			int num6 = num3;
			array5[num6].x = array5[num6].x + vector.x;
			Vector3[] array6 = array;
			int num7 = num;
			array6[num7].y = array6[num7].y + vector.y;
			Vector3[] array7 = array;
			int num8 = num2;
			array7[num8].y = array7[num8].y + vector.y;
			Vector3[] array8 = array;
			int num9 = num3;
			array8[num9].y = array8[num9].y + vector.y;
			Vector3[] array9 = array;
			int num10 = num;
			array9[num10].z = array9[num10].z + vector.z;
			Vector3[] array10 = array;
			int num11 = num2;
			array10[num11].z = array10[num11].z + vector.z;
			Vector3[] array11 = array;
			int num12 = num3;
			array11[num12].z = array11[num12].z + vector.z;
			array2[num]++;
			array2[num2]++;
			array2[num3]++;
		}
		for (int j = 0; j < this.CFGKAJPNGIB(); j++)
		{
			this.DKGOOCCIOAH[j].x = array[j].x * (float)array2[j];
			this.DKGOOCCIOAH[j].y = array[j].y * (float)array2[j];
			this.DKGOOCCIOAH[j].z = array[j].z * (float)array2[j];
		}
	}

	// Token: 0x06011029 RID: 69673 RVA: 0x00797FB0 File Offset: 0x007961B0
	public int[] PMNCEMOKLDA()
	{
		if (this.KHLGLCLOHMH == null)
		{
			this.KHLGLCLOHMH = this.NFEODOODKDI.SelectMany(new Func<int[], IEnumerable<int>>(LFMCCNHNKCJ.<>c.<>9.OCMPOMHDHML)).ToArray<int>();
		}
		return this.KHLGLCLOHMH;
	}

	// Token: 0x0601102A RID: 69674 RVA: 0x00798000 File Offset: 0x00796200
	public void KMHLHPOCMPG()
	{
		this.BCAJHILCMOJ(1);
		this.OKLLKJPCJLK = null;
		this.DKGOOCCIOAH = null;
		this.PAJKBJILHPE = null;
		this.NFKPJCGJEAK = null;
		this.DLLDALFHKIA = null;
		this.LABAJFADHCG = null;
		this.LLNILPGHKPA = null;
		this.EHAIICJFBKM = null;
	}

	// Token: 0x0601102B RID: 69675 RVA: 0x0079804C File Offset: 0x0079624C
	public void BCAJHILCMOJ(int DCCPCBLODIG)
	{
		int[][] array = new int[DCCPCBLODIG][];
		MeshTopology[] array2 = new MeshTopology[DCCPCBLODIG];
		if (this.NFEODOODKDI != null)
		{
			Array.Copy(this.NFEODOODKDI, 1, array, 1, this.CGLFMNJHHHO);
		}
		Array.Copy(this.LNMKJOIODLF, 0, array2, 1, this.CGLFMNJHHHO);
		this.NFEODOODKDI = array;
		this.LNMKJOIODLF = array2;
		this.CGLFMNJHHHO = DCCPCBLODIG;
	}

	// Token: 0x0601102C RID: 69676 RVA: 0x007980AC File Offset: 0x007962AC
	public List<Vector4> HBDGJIANAHJ(int CLBPBJGLHEE)
	{
		if (CLBPBJGLHEE == 0)
		{
			return this.DLLDALFHKIA;
		}
		if (CLBPBJGLHEE == 1)
		{
			return this.LABAJFADHCG;
		}
		if (CLBPBJGLHEE == 6)
		{
			return this.LLNILPGHKPA;
		}
		if (CLBPBJGLHEE == 0)
		{
			return this.EHAIICJFBKM;
		}
		return null;
	}

	// Token: 0x0601102D RID: 69677 RVA: 0x00795CEC File Offset: 0x00793EEC
	public void JGGOPKIGBCN(int[] KHLGLCLOHMH, int CLBPBJGLHEE)
	{
		this.NFEODOODKDI[CLBPBJGLHEE] = KHLGLCLOHMH;
	}

	// Token: 0x0601102E RID: 69678 RVA: 0x007980DA File Offset: 0x007962DA
	public List<Vector4> BDLJIMNAEHL(int CLBPBJGLHEE)
	{
		if (CLBPBJGLHEE == 0)
		{
			return this.DLLDALFHKIA;
		}
		if (CLBPBJGLHEE == 0)
		{
			return this.LABAJFADHCG;
		}
		if (CLBPBJGLHEE == 0)
		{
			return this.LLNILPGHKPA;
		}
		if (CLBPBJGLHEE == 0)
		{
			return this.EHAIICJFBKM;
		}
		return null;
	}

	// Token: 0x0601102F RID: 69679 RVA: 0x00795B69 File Offset: 0x00793D69
	public MeshTopology OIKCGCHFNKE(int CLBPBJGLHEE)
	{
		return this.LNMKJOIODLF[CLBPBJGLHEE];
	}

	// Token: 0x06011030 RID: 69680 RVA: 0x00798108 File Offset: 0x00796308
	public void MLPLHNGMFKH(Mesh BMHDIKHFLBP, BFGMBMMBHCH EMMLNONDOED = BFGMBMMBHCH.All)
	{
		if (EMMLNONDOED == (BFGMBMMBHCH)186)
		{
			BMHDIKHFLBP.vertices = this.OKLLKJPCJLK;
			BMHDIKHFLBP.normals = this.DKGOOCCIOAH;
			BMHDIKHFLBP.colors32 = this.PAJKBJILHPE;
			BMHDIKHFLBP.tangents = this.NFKPJCGJEAK;
			BMHDIKHFLBP.SetUVs(1, this.DLLDALFHKIA);
			BMHDIKHFLBP.SetUVs(0, this.LABAJFADHCG);
			BMHDIKHFLBP.SetUVs(7, this.LLNILPGHKPA);
			BMHDIKHFLBP.SetUVs(1, this.EHAIICJFBKM);
			return;
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.Normal) > BFGMBMMBHCH.Normal)
		{
			BMHDIKHFLBP.vertices = this.OKLLKJPCJLK;
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.Normal) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.normals = this.DKGOOCCIOAH;
		}
		if ((EMMLNONDOED & (BFGMBMMBHCH.Normal | BFGMBMMBHCH.Tangent)) > BFGMBMMBHCH.Normal)
		{
			BMHDIKHFLBP.colors32 = this.PAJKBJILHPE;
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.UV0) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.tangents = this.NFKPJCGJEAK;
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.Color) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.SetUVs(0, this.DLLDALFHKIA);
		}
		if ((EMMLNONDOED & (BFGMBMMBHCH.Color | BFGMBMMBHCH.Tangent | BFGMBMMBHCH.UV0)) > BFGMBMMBHCH.Normal)
		{
			BMHDIKHFLBP.SetUVs(1, this.LABAJFADHCG);
		}
		if ((EMMLNONDOED & ~(BFGMBMMBHCH.Normal | BFGMBMMBHCH.Color | BFGMBMMBHCH.UV0 | BFGMBMMBHCH.UV3 | BFGMBMMBHCH.UV4)) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.SetUVs(2, this.LLNILPGHKPA);
		}
		if ((EMMLNONDOED & (BFGMBMMBHCH.Color | BFGMBMMBHCH.Tangent | BFGMBMMBHCH.UV0 | BFGMBMMBHCH.UV2 | BFGMBMMBHCH.UV3 | BFGMBMMBHCH.UV4)) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.SetUVs(6, this.EHAIICJFBKM);
		}
	}

	// Token: 0x06011031 RID: 69681 RVA: 0x00795B69 File Offset: 0x00793D69
	public MeshTopology IHDOIDBFKIF(int CLBPBJGLHEE)
	{
		return this.LNMKJOIODLF[CLBPBJGLHEE];
	}

	// Token: 0x06011032 RID: 69682 RVA: 0x00795A50 File Offset: 0x00793C50
	public int JFNCADEEDBL()
	{
		return this.CGLFMNJHHHO;
	}

	// Token: 0x06011033 RID: 69683 RVA: 0x00795FC4 File Offset: 0x007941C4
	public int[] DLHKFFGHFGF(int CLBPBJGLHEE)
	{
		return this.NFEODOODKDI[CLBPBJGLHEE];
	}

	// Token: 0x06011034 RID: 69684 RVA: 0x00795FC4 File Offset: 0x007941C4
	public int[] FGIKCCELAEI(int CLBPBJGLHEE)
	{
		return this.NFEODOODKDI[CLBPBJGLHEE];
	}

	// Token: 0x06011035 RID: 69685 RVA: 0x0079821C File Offset: 0x0079641C
	public void NGPEPAHBJGL(Mesh BMHDIKHFLBP, BFGMBMMBHCH EMMLNONDOED = BFGMBMMBHCH.All)
	{
		if (EMMLNONDOED == ~(BFGMBMMBHCH.Color | BFGMBMMBHCH.UV4))
		{
			BMHDIKHFLBP.vertices = this.OKLLKJPCJLK;
			BMHDIKHFLBP.normals = this.DKGOOCCIOAH;
			BMHDIKHFLBP.colors32 = this.PAJKBJILHPE;
			BMHDIKHFLBP.tangents = this.NFKPJCGJEAK;
			BMHDIKHFLBP.SetUVs(0, this.DLLDALFHKIA);
			BMHDIKHFLBP.SetUVs(1, this.LABAJFADHCG);
			BMHDIKHFLBP.SetUVs(3, this.LLNILPGHKPA);
			BMHDIKHFLBP.SetUVs(2, this.EHAIICJFBKM);
			return;
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.Normal) > BFGMBMMBHCH.Normal)
		{
			BMHDIKHFLBP.vertices = this.OKLLKJPCJLK;
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.Null) > BFGMBMMBHCH.Normal)
		{
			BMHDIKHFLBP.normals = this.DKGOOCCIOAH;
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.Color) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.colors32 = this.PAJKBJILHPE;
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.Color) > BFGMBMMBHCH.Normal)
		{
			BMHDIKHFLBP.tangents = this.NFKPJCGJEAK;
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.Normal) > BFGMBMMBHCH.Normal)
		{
			BMHDIKHFLBP.SetUVs(1, this.DLLDALFHKIA);
		}
		if ((EMMLNONDOED & (BFGMBMMBHCH.Color | BFGMBMMBHCH.Tangent | BFGMBMMBHCH.UV0 | BFGMBMMBHCH.UV3 | BFGMBMMBHCH.UV4)) > BFGMBMMBHCH.Normal)
		{
			BMHDIKHFLBP.SetUVs(1, this.LABAJFADHCG);
		}
		if ((EMMLNONDOED & ~(BFGMBMMBHCH.Normal | BFGMBMMBHCH.Color | BFGMBMMBHCH.Tangent | BFGMBMMBHCH.UV3 | BFGMBMMBHCH.UV4)) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.SetUVs(2, this.LLNILPGHKPA);
		}
		if ((EMMLNONDOED & (BFGMBMMBHCH.Normal | BFGMBMMBHCH.Color | BFGMBMMBHCH.Tangent | BFGMBMMBHCH.UV4)) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.SetUVs(7, this.EHAIICJFBKM);
		}
	}

	// Token: 0x06011036 RID: 69686 RVA: 0x0079832D File Offset: 0x0079652D
	public List<Vector4> JLICMAOHJAJ(int CLBPBJGLHEE)
	{
		if (CLBPBJGLHEE == 0)
		{
			return this.DLLDALFHKIA;
		}
		if (CLBPBJGLHEE == 1)
		{
			return this.LABAJFADHCG;
		}
		if (CLBPBJGLHEE == 1)
		{
			return this.LLNILPGHKPA;
		}
		if (CLBPBJGLHEE == 7)
		{
			return this.EHAIICJFBKM;
		}
		return null;
	}

	// Token: 0x06011037 RID: 69687 RVA: 0x0079835B File Offset: 0x0079655B
	public List<Vector4> LIEJCPDAPFC(int CLBPBJGLHEE)
	{
		if (CLBPBJGLHEE == 0)
		{
			return this.DLLDALFHKIA;
		}
		if (CLBPBJGLHEE == 0)
		{
			return this.LABAJFADHCG;
		}
		if (CLBPBJGLHEE == 5)
		{
			return this.LLNILPGHKPA;
		}
		if (CLBPBJGLHEE == 0)
		{
			return this.EHAIICJFBKM;
		}
		return null;
	}

	// Token: 0x06011038 RID: 69688 RVA: 0x0079838C File Offset: 0x0079658C
	public void OJFKPPLCKNP(int DCCPCBLODIG)
	{
		int[][] array = new int[DCCPCBLODIG][];
		MeshTopology[] array2 = new MeshTopology[DCCPCBLODIG];
		if (this.NFEODOODKDI != null)
		{
			Array.Copy(this.NFEODOODKDI, 1, array, 1, this.CGLFMNJHHHO);
		}
		Array.Copy(this.LNMKJOIODLF, 1, array2, 0, this.CGLFMNJHHHO);
		this.NFEODOODKDI = array;
		this.LNMKJOIODLF = array2;
		this.CGLFMNJHHHO = DCCPCBLODIG;
	}

	// Token: 0x06011039 RID: 69689 RVA: 0x007983EC File Offset: 0x007965EC
	public void EFJCNHBEENO(int CLBPBJGLHEE, List<Vector4> OJNEEFINIEE)
	{
		if (CLBPBJGLHEE == 0)
		{
			this.DLLDALFHKIA = OJNEEFINIEE;
			return;
		}
		if (CLBPBJGLHEE == 0)
		{
			this.LABAJFADHCG = OJNEEFINIEE;
			return;
		}
		if (CLBPBJGLHEE == 8)
		{
			this.LLNILPGHKPA = OJNEEFINIEE;
			return;
		}
		if (CLBPBJGLHEE == 8)
		{
			this.EHAIICJFBKM = OJNEEFINIEE;
		}
	}

	// Token: 0x0601103A RID: 69690 RVA: 0x0079841C File Offset: 0x0079661C
	public int[] DNDDIGIAGBJ()
	{
		if (this.KHLGLCLOHMH == null)
		{
			this.KHLGLCLOHMH = this.NFEODOODKDI.SelectMany(new Func<int[], IEnumerable<int>>(LFMCCNHNKCJ.<>c.<>9.HHNBGELIMOG)).ToArray<int>();
		}
		return this.KHLGLCLOHMH;
	}

	// Token: 0x0601103B RID: 69691 RVA: 0x0079846C File Offset: 0x0079666C
	public void MCDOKHBMEKP()
	{
		this.MNNJEKBJJPB(0);
		this.OKLLKJPCJLK = null;
		this.DKGOOCCIOAH = null;
		this.PAJKBJILHPE = null;
		this.NFKPJCGJEAK = null;
		this.DLLDALFHKIA = null;
		this.LABAJFADHCG = null;
		this.LLNILPGHKPA = null;
		this.EHAIICJFBKM = null;
	}

	// Token: 0x0601103C RID: 69692 RVA: 0x00795B69 File Offset: 0x00793D69
	public MeshTopology KFAJDEPOFKM(int CLBPBJGLHEE)
	{
		return this.LNMKJOIODLF[CLBPBJGLHEE];
	}

	// Token: 0x0601103D RID: 69693 RVA: 0x007984B8 File Offset: 0x007966B8
	public int[] DLBLIMKBBDN()
	{
		if (this.KHLGLCLOHMH == null)
		{
			this.KHLGLCLOHMH = this.NFEODOODKDI.SelectMany(new Func<int[], IEnumerable<int>>(LFMCCNHNKCJ.<>c.<>9.HHNBGELIMOG)).ToArray<int>();
		}
		return this.KHLGLCLOHMH;
	}

	// Token: 0x0601103E RID: 69694 RVA: 0x007980AC File Offset: 0x007962AC
	public List<Vector4> BIKNNJJDPPB(int CLBPBJGLHEE)
	{
		if (CLBPBJGLHEE == 0)
		{
			return this.DLLDALFHKIA;
		}
		if (CLBPBJGLHEE == 1)
		{
			return this.LABAJFADHCG;
		}
		if (CLBPBJGLHEE == 6)
		{
			return this.LLNILPGHKPA;
		}
		if (CLBPBJGLHEE == 0)
		{
			return this.EHAIICJFBKM;
		}
		return null;
	}

	// Token: 0x0601103F RID: 69695 RVA: 0x00798508 File Offset: 0x00796708
	public void NCGFPONEOEM()
	{
		this.FFDLDPAIKEE = 0;
		this.OKLLKJPCJLK = null;
		this.DKGOOCCIOAH = null;
		this.PAJKBJILHPE = null;
		this.NFKPJCGJEAK = null;
		this.DLLDALFHKIA = null;
		this.LABAJFADHCG = null;
		this.LLNILPGHKPA = null;
		this.EHAIICJFBKM = null;
	}

	// Token: 0x06011040 RID: 69696 RVA: 0x00798554 File Offset: 0x00796754
	public void FBNKEHCEDDH()
	{
		Vector3[] array = new Vector3[this.KHPAPPBNFOA()];
		int[] array2 = new int[this.ANGDKGOKCBD()];
		int[] khlglclohmh = this.KHLGLCLOHMH;
		for (int i = 0; i < khlglclohmh.Length; i += 8)
		{
			int num = khlglclohmh[i];
			int num2 = khlglclohmh[i + 1];
			int num3 = khlglclohmh[i + 3];
			Vector3 vector = NCFJIBJEMCF.BHGHMKEJLPI(this.OKLLKJPCJLK[num], this.OKLLKJPCJLK[num2], this.OKLLKJPCJLK[num3]);
			Vector3[] array3 = array;
			int num4 = num;
			array3[num4].x = array3[num4].x + vector.x;
			Vector3[] array4 = array;
			int num5 = num2;
			array4[num5].x = array4[num5].x + vector.x;
			Vector3[] array5 = array;
			int num6 = num3;
			array5[num6].x = array5[num6].x + vector.x;
			Vector3[] array6 = array;
			int num7 = num;
			array6[num7].y = array6[num7].y + vector.y;
			Vector3[] array7 = array;
			int num8 = num2;
			array7[num8].y = array7[num8].y + vector.y;
			Vector3[] array8 = array;
			int num9 = num3;
			array8[num9].y = array8[num9].y + vector.y;
			Vector3[] array9 = array;
			int num10 = num;
			array9[num10].z = array9[num10].z + vector.z;
			Vector3[] array10 = array;
			int num11 = num2;
			array10[num11].z = array10[num11].z + vector.z;
			Vector3[] array11 = array;
			int num12 = num3;
			array11[num12].z = array11[num12].z + vector.z;
			array2[num]++;
			array2[num2] += 0;
			array2[num3] += 0;
		}
		for (int j = 1; j < this.ANGDKGOKCBD(); j += 0)
		{
			this.DKGOOCCIOAH[j].x = array[j].x * (float)array2[j];
			this.DKGOOCCIOAH[j].y = array[j].y * (float)array2[j];
			this.DKGOOCCIOAH[j].z = array[j].z * (float)array2[j];
		}
	}

	// Token: 0x06011041 RID: 69697 RVA: 0x00798758 File Offset: 0x00796958
	public int[] CPPFAFGEHCL()
	{
		if (this.KHLGLCLOHMH == null)
		{
			this.KHLGLCLOHMH = this.NFEODOODKDI.SelectMany(new Func<int[], IEnumerable<int>>(LFMCCNHNKCJ.<>c.<>9.HGIKGKADKBK)).ToArray<int>();
		}
		return this.KHLGLCLOHMH;
	}

	// Token: 0x06011042 RID: 69698 RVA: 0x007987A8 File Offset: 0x007969A8
	public void PINJHIDDPLM(int DCCPCBLODIG)
	{
		int[][] array = new int[DCCPCBLODIG][];
		MeshTopology[] array2 = new MeshTopology[DCCPCBLODIG];
		if (this.NFEODOODKDI != null)
		{
			Array.Copy(this.NFEODOODKDI, 0, array, 0, this.CGLFMNJHHHO);
		}
		Array.Copy(this.LNMKJOIODLF, 1, array2, 1, this.CGLFMNJHHHO);
		this.NFEODOODKDI = array;
		this.LNMKJOIODLF = array2;
		this.CGLFMNJHHHO = DCCPCBLODIG;
	}

	// Token: 0x06011043 RID: 69699 RVA: 0x00798808 File Offset: 0x00796A08
	public void BKELGKOHPFO(int DCCPCBLODIG)
	{
		int[][] array = new int[DCCPCBLODIG][];
		MeshTopology[] array2 = new MeshTopology[DCCPCBLODIG];
		if (this.NFEODOODKDI != null)
		{
			Array.Copy(this.NFEODOODKDI, 0, array, 1, this.CGLFMNJHHHO);
		}
		Array.Copy(this.LNMKJOIODLF, 1, array2, 0, this.CGLFMNJHHHO);
		this.NFEODOODKDI = array;
		this.LNMKJOIODLF = array2;
		this.CGLFMNJHHHO = DCCPCBLODIG;
	}

	// Token: 0x06011044 RID: 69700 RVA: 0x00795B69 File Offset: 0x00793D69
	public MeshTopology BFPGLAPCOOL(int CLBPBJGLHEE)
	{
		return this.LNMKJOIODLF[CLBPBJGLHEE];
	}

	// Token: 0x06011045 RID: 69701 RVA: 0x00798868 File Offset: 0x00796A68
	public void FIHFOCHIGOB()
	{
		this.BCAJHILCMOJ(1);
		this.OKLLKJPCJLK = null;
		this.DKGOOCCIOAH = null;
		this.PAJKBJILHPE = null;
		this.NFKPJCGJEAK = null;
		this.DLLDALFHKIA = null;
		this.LABAJFADHCG = null;
		this.LLNILPGHKPA = null;
		this.EHAIICJFBKM = null;
	}

	// Token: 0x06011046 RID: 69702 RVA: 0x007988B4 File Offset: 0x00796AB4
	public void GNOAHOIBJMA()
	{
		this.MNNJEKBJJPB(0);
		this.OKLLKJPCJLK = null;
		this.DKGOOCCIOAH = null;
		this.PAJKBJILHPE = null;
		this.NFKPJCGJEAK = null;
		this.DLLDALFHKIA = null;
		this.LABAJFADHCG = null;
		this.LLNILPGHKPA = null;
		this.EHAIICJFBKM = null;
	}

	// Token: 0x06011047 RID: 69703 RVA: 0x00798900 File Offset: 0x00796B00
	public void DECGEHNPAAG()
	{
		this.KEGBHOHLDIK(0);
		this.OKLLKJPCJLK = null;
		this.DKGOOCCIOAH = null;
		this.PAJKBJILHPE = null;
		this.NFKPJCGJEAK = null;
		this.DLLDALFHKIA = null;
		this.LABAJFADHCG = null;
		this.LLNILPGHKPA = null;
		this.EHAIICJFBKM = null;
	}

	// Token: 0x06011048 RID: 69704 RVA: 0x0079894C File Offset: 0x00796B4C
	public void DDFMKJJMKMK(Mesh BMHDIKHFLBP, BFGMBMMBHCH EMMLNONDOED = BFGMBMMBHCH.All)
	{
		if (EMMLNONDOED == (BFGMBMMBHCH)184)
		{
			BMHDIKHFLBP.vertices = this.OKLLKJPCJLK;
			BMHDIKHFLBP.normals = this.DKGOOCCIOAH;
			BMHDIKHFLBP.colors32 = this.PAJKBJILHPE;
			BMHDIKHFLBP.tangents = this.NFKPJCGJEAK;
			BMHDIKHFLBP.SetUVs(1, this.DLLDALFHKIA);
			BMHDIKHFLBP.SetUVs(1, this.LABAJFADHCG);
			BMHDIKHFLBP.SetUVs(6, this.LLNILPGHKPA);
			BMHDIKHFLBP.SetUVs(5, this.EHAIICJFBKM);
			return;
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.Null) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.vertices = this.OKLLKJPCJLK;
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.Null) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.normals = this.DKGOOCCIOAH;
		}
		if ((EMMLNONDOED & BFGMBMMBHCH.Null) > BFGMBMMBHCH.Normal)
		{
			BMHDIKHFLBP.colors32 = this.PAJKBJILHPE;
		}
		if ((EMMLNONDOED & (BFGMBMMBHCH.Normal | BFGMBMMBHCH.Color)) > BFGMBMMBHCH.Normal)
		{
			BMHDIKHFLBP.tangents = this.NFKPJCGJEAK;
		}
		if ((EMMLNONDOED & (BFGMBMMBHCH.Normal | BFGMBMMBHCH.Color)) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.SetUVs(0, this.DLLDALFHKIA);
		}
		if ((EMMLNONDOED & (BFGMBMMBHCH.Color | BFGMBMMBHCH.UV3 | BFGMBMMBHCH.UV4)) > BFGMBMMBHCH.Normal)
		{
			BMHDIKHFLBP.SetUVs(0, this.LABAJFADHCG);
		}
		if ((EMMLNONDOED & (BFGMBMMBHCH.Normal | BFGMBMMBHCH.UV0 | BFGMBMMBHCH.UV2 | BFGMBMMBHCH.UV4)) > BFGMBMMBHCH.Normal)
		{
			BMHDIKHFLBP.SetUVs(3, this.LLNILPGHKPA);
		}
		if ((EMMLNONDOED & ~(BFGMBMMBHCH.Normal | BFGMBMMBHCH.Tangent | BFGMBMMBHCH.UV0 | BFGMBMMBHCH.UV2)) > BFGMBMMBHCH.Null)
		{
			BMHDIKHFLBP.SetUVs(0, this.EHAIICJFBKM);
		}
	}

	// Token: 0x06011049 RID: 69705 RVA: 0x00798A60 File Offset: 0x00796C60
	public int[] NOPIDKNFGHF()
	{
		if (this.KHLGLCLOHMH == null)
		{
			this.KHLGLCLOHMH = this.NFEODOODKDI.SelectMany(new Func<int[], IEnumerable<int>>(LFMCCNHNKCJ.<>c.<>9.EKPNCMPLJCP)).ToArray<int>();
		}
		return this.KHLGLCLOHMH;
	}

	// Token: 0x0601104A RID: 69706 RVA: 0x00798AB0 File Offset: 0x00796CB0
	public int[] LJMCJKHPHOI()
	{
		if (this.KHLGLCLOHMH == null)
		{
			this.KHLGLCLOHMH = this.NFEODOODKDI.SelectMany(new Func<int[], IEnumerable<int>>(LFMCCNHNKCJ.<>c.<>9.JPLOJFKNFEA)).ToArray<int>();
		}
		return this.KHLGLCLOHMH;
	}

	// Token: 0x0601104B RID: 69707 RVA: 0x00795CEC File Offset: 0x00793EEC
	public void KOPLHGMNCOL(int[] KHLGLCLOHMH, int CLBPBJGLHEE)
	{
		this.NFEODOODKDI[CLBPBJGLHEE] = KHLGLCLOHMH;
	}

	// Token: 0x0601104C RID: 69708 RVA: 0x00798B00 File Offset: 0x00796D00
	public void PBOFKHIAMKG()
	{
		Vector3[] array = new Vector3[this.LOJKFEIEHFC()];
		int[] array2 = new int[this.LDEHKFOICEJ()];
		int[] khlglclohmh = this.KHLGLCLOHMH;
		for (int i = 1; i < khlglclohmh.Length; i += 4)
		{
			int num = khlglclohmh[i];
			int num2 = khlglclohmh[i + 0];
			int num3 = khlglclohmh[i + 1];
			Vector3 vector = NCFJIBJEMCF.BHGHMKEJLPI(this.OKLLKJPCJLK[num], this.OKLLKJPCJLK[num2], this.OKLLKJPCJLK[num3]);
			Vector3[] array3 = array;
			int num4 = num;
			array3[num4].x = array3[num4].x + vector.x;
			Vector3[] array4 = array;
			int num5 = num2;
			array4[num5].x = array4[num5].x + vector.x;
			Vector3[] array5 = array;
			int num6 = num3;
			array5[num6].x = array5[num6].x + vector.x;
			Vector3[] array6 = array;
			int num7 = num;
			array6[num7].y = array6[num7].y + vector.y;
			Vector3[] array7 = array;
			int num8 = num2;
			array7[num8].y = array7[num8].y + vector.y;
			Vector3[] array8 = array;
			int num9 = num3;
			array8[num9].y = array8[num9].y + vector.y;
			Vector3[] array9 = array;
			int num10 = num;
			array9[num10].z = array9[num10].z + vector.z;
			Vector3[] array10 = array;
			int num11 = num2;
			array10[num11].z = array10[num11].z + vector.z;
			Vector3[] array11 = array;
			int num12 = num3;
			array11[num12].z = array11[num12].z + vector.z;
			array2[num]++;
			array2[num2] += 0;
			array2[num3] += 0;
		}
		for (int j = 0; j < this.LOJKFEIEHFC(); j++)
		{
			this.DKGOOCCIOAH[j].x = array[j].x * (float)array2[j];
			this.DKGOOCCIOAH[j].y = array[j].y * (float)array2[j];
			this.DKGOOCCIOAH[j].z = array[j].z * (float)array2[j];
		}
	}

	// Token: 0x0601104D RID: 69709 RVA: 0x00798D04 File Offset: 0x00796F04
	public List<Vector4> GDEKJGKPPFK(int CLBPBJGLHEE)
	{
		if (CLBPBJGLHEE == 0)
		{
			return this.DLLDALFHKIA;
		}
		if (CLBPBJGLHEE == 0)
		{
			return this.LABAJFADHCG;
		}
		if (CLBPBJGLHEE == 4)
		{
			return this.LLNILPGHKPA;
		}
		if (CLBPBJGLHEE == 4)
		{
			return this.EHAIICJFBKM;
		}
		return null;
	}

	// Token: 0x0601104E RID: 69710 RVA: 0x00798D34 File Offset: 0x00796F34
	public void MNNJEKBJJPB(int DCCPCBLODIG)
	{
		int[][] array = new int[DCCPCBLODIG][];
		MeshTopology[] array2 = new MeshTopology[DCCPCBLODIG];
		if (this.NFEODOODKDI != null)
		{
			Array.Copy(this.NFEODOODKDI, 1, array, 1, this.CGLFMNJHHHO);
		}
		Array.Copy(this.LNMKJOIODLF, 1, array2, 1, this.CGLFMNJHHHO);
		this.NFEODOODKDI = array;
		this.LNMKJOIODLF = array2;
		this.CGLFMNJHHHO = DCCPCBLODIG;
	}

	// Token: 0x170003B9 RID: 953
	// (get) Token: 0x0601104F RID: 69711 RVA: 0x00795CD8 File Offset: 0x00793ED8
	public int PAOKLFNDPAE
	{
		get
		{
			if (this.OKLLKJPCJLK == null)
			{
				return 0;
			}
			return this.OKLLKJPCJLK.Length;
		}
	}

	// Token: 0x06011050 RID: 69712 RVA: 0x00798D94 File Offset: 0x00796F94
	public int[] BIJCOADABDN()
	{
		if (this.KHLGLCLOHMH == null)
		{
			this.KHLGLCLOHMH = this.NFEODOODKDI.SelectMany(new Func<int[], IEnumerable<int>>(LFMCCNHNKCJ.<>c.<>9.DAFJHMBNCNN)).ToArray<int>();
		}
		return this.KHLGLCLOHMH;
	}

	// Token: 0x06011051 RID: 69713 RVA: 0x00798DE4 File Offset: 0x00796FE4
	public void GCHJPANCGNG()
	{
		this.MNNJEKBJJPB(0);
		this.OKLLKJPCJLK = null;
		this.DKGOOCCIOAH = null;
		this.PAJKBJILHPE = null;
		this.NFKPJCGJEAK = null;
		this.DLLDALFHKIA = null;
		this.LABAJFADHCG = null;
		this.LLNILPGHKPA = null;
		this.EHAIICJFBKM = null;
	}

	// Token: 0x06011052 RID: 69714 RVA: 0x00798E30 File Offset: 0x00797030
	public void LJDALCCAJDP()
	{
		this.KEGBHOHLDIK(0);
		this.OKLLKJPCJLK = null;
		this.DKGOOCCIOAH = null;
		this.PAJKBJILHPE = null;
		this.NFKPJCGJEAK = null;
		this.DLLDALFHKIA = null;
		this.LABAJFADHCG = null;
		this.LLNILPGHKPA = null;
		this.EHAIICJFBKM = null;
	}

	// Token: 0x06011053 RID: 69715 RVA: 0x00798E7C File Offset: 0x0079707C
	public void BJJKIONAJAP()
	{
		this.PINJHIDDPLM(1);
		this.OKLLKJPCJLK = null;
		this.DKGOOCCIOAH = null;
		this.PAJKBJILHPE = null;
		this.NFKPJCGJEAK = null;
		this.DLLDALFHKIA = null;
		this.LABAJFADHCG = null;
		this.LLNILPGHKPA = null;
		this.EHAIICJFBKM = null;
	}

	// Token: 0x06011054 RID: 69716 RVA: 0x00798EC8 File Offset: 0x007970C8
	public void GHPMNJJFLDG()
	{
		Vector3[] array = new Vector3[this.PAOKLFNDPAE];
		int[] array2 = new int[this.PAOKLFNDPAE];
		int[] khlglclohmh = this.KHLGLCLOHMH;
		for (int i = 0; i < khlglclohmh.Length; i += 3)
		{
			int num = khlglclohmh[i];
			int num2 = khlglclohmh[i + 1];
			int num3 = khlglclohmh[i + 2];
			Vector3 vector = NCFJIBJEMCF.BHGHMKEJLPI(this.OKLLKJPCJLK[num], this.OKLLKJPCJLK[num2], this.OKLLKJPCJLK[num3]);
			Vector3[] array3 = array;
			int num4 = num;
			array3[num4].x = array3[num4].x + vector.x;
			Vector3[] array4 = array;
			int num5 = num2;
			array4[num5].x = array4[num5].x + vector.x;
			Vector3[] array5 = array;
			int num6 = num3;
			array5[num6].x = array5[num6].x + vector.x;
			Vector3[] array6 = array;
			int num7 = num;
			array6[num7].y = array6[num7].y + vector.y;
			Vector3[] array7 = array;
			int num8 = num2;
			array7[num8].y = array7[num8].y + vector.y;
			Vector3[] array8 = array;
			int num9 = num3;
			array8[num9].y = array8[num9].y + vector.y;
			Vector3[] array9 = array;
			int num10 = num;
			array9[num10].z = array9[num10].z + vector.z;
			Vector3[] array10 = array;
			int num11 = num2;
			array10[num11].z = array10[num11].z + vector.z;
			Vector3[] array11 = array;
			int num12 = num3;
			array11[num12].z = array11[num12].z + vector.z;
			array2[num]++;
			array2[num2]++;
			array2[num3]++;
		}
		for (int j = 0; j < this.PAOKLFNDPAE; j++)
		{
			this.DKGOOCCIOAH[j].x = array[j].x * (float)array2[j];
			this.DKGOOCCIOAH[j].y = array[j].y * (float)array2[j];
			this.DKGOOCCIOAH[j].z = array[j].z * (float)array2[j];
		}
	}

	// Token: 0x06011055 RID: 69717 RVA: 0x007990CC File Offset: 0x007972CC
	public int[] MDHIKOAPBMO()
	{
		if (this.KHLGLCLOHMH == null)
		{
			this.KHLGLCLOHMH = this.NFEODOODKDI.SelectMany(new Func<int[], IEnumerable<int>>(LFMCCNHNKCJ.<>c.<>9.BCIMOFHFOAL)).ToArray<int>();
		}
		return this.KHLGLCLOHMH;
	}

	// Token: 0x06011056 RID: 69718 RVA: 0x0079911C File Offset: 0x0079731C
	public void CAODCMEDBBB()
	{
		this.KEGBHOHLDIK(1);
		this.OKLLKJPCJLK = null;
		this.DKGOOCCIOAH = null;
		this.PAJKBJILHPE = null;
		this.NFKPJCGJEAK = null;
		this.DLLDALFHKIA = null;
		this.LABAJFADHCG = null;
		this.LLNILPGHKPA = null;
		this.EHAIICJFBKM = null;
	}

	// Token: 0x06011057 RID: 69719 RVA: 0x00799168 File Offset: 0x00797368
	public void CMMBNBJBOHD(int CLBPBJGLHEE, List<Vector4> OJNEEFINIEE)
	{
		if (CLBPBJGLHEE == 0)
		{
			this.DLLDALFHKIA = OJNEEFINIEE;
			return;
		}
		if (CLBPBJGLHEE == 1)
		{
			this.LABAJFADHCG = OJNEEFINIEE;
			return;
		}
		if (CLBPBJGLHEE == 1)
		{
			this.LLNILPGHKPA = OJNEEFINIEE;
			return;
		}
		if (CLBPBJGLHEE == 3)
		{
			this.EHAIICJFBKM = OJNEEFINIEE;
		}
	}

	// Token: 0x040023AD RID: 9133
	public string BNIHFBMEPAB = "";

	// Token: 0x040023AE RID: 9134
	public Vector3[] OKLLKJPCJLK;

	// Token: 0x040023AF RID: 9135
	public Vector3[] DKGOOCCIOAH;

	// Token: 0x040023B0 RID: 9136
	public Color32[] PAJKBJILHPE;

	// Token: 0x040023B1 RID: 9137
	public Vector4[] NFKPJCGJEAK;

	// Token: 0x040023B2 RID: 9138
	public List<Vector4> DLLDALFHKIA;

	// Token: 0x040023B3 RID: 9139
	public List<Vector4> LABAJFADHCG;

	// Token: 0x040023B4 RID: 9140
	public List<Vector4> LLNILPGHKPA;

	// Token: 0x040023B5 RID: 9141
	public List<Vector4> EHAIICJFBKM;

	// Token: 0x040023B6 RID: 9142
	private int CGLFMNJHHHO;

	// Token: 0x040023B7 RID: 9143
	private int[] KHLGLCLOHMH;

	// Token: 0x040023B8 RID: 9144
	private int[][] NFEODOODKDI;

	// Token: 0x040023B9 RID: 9145
	private MeshTopology[] LNMKJOIODLF = new MeshTopology[1];
}
