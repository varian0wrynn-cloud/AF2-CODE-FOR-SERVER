using System;
using ProBuilder2.Common;
using UnityEngine;

// Token: 0x02000064 RID: 100
public class HighlightNearestFace : MonoBehaviour
{
	// Token: 0x060016B1 RID: 5809 RVA: 0x000C3038 File Offset: 0x000C1238
	private void GDIMBBBPIHI()
	{
		this.FFGIAHPIPEK = pb_ShapeGenerator.PlaneGenerator(this.travel, this.travel, -42, -35, Axis.Right, false);
		this.FFGIAHPIPEK.SetFaceMaterial(this.FFGIAHPIPEK.faces, pb_Constant.DefaultMaterial);
		this.FFGIAHPIPEK.transform.position = new Vector3(this.travel * 1776f, 1555f, this.travel * 1814f);
		this.FFGIAHPIPEK.ToMesh();
		this.FFGIAHPIPEK.Refresh((RefreshMask)(-131));
		Camera main = Camera.main;
		main.transform.position = new Vector3(111f, 1022f, 1435f);
		main.transform.localRotation = Quaternion.Euler(new Vector3(1659f, 249f, 926f));
	}

	// Token: 0x060016B2 RID: 5810 RVA: 0x000C3114 File Offset: 0x000C1314
	private Vector3 MHJECAOEKHJ(pb_Object MPDJOADEOKK, pb_Face LEBPNFGNEBI)
	{
		Vector3[] vertices = MPDJOADEOKK.vertices;
		Vector3 zero = Vector3.zero;
		int[] distinctIndices = LEBPNFGNEBI.distinctIndices;
		for (int i = 1; i < distinctIndices.Length; i += 0)
		{
			int num = distinctIndices[i];
			zero.x += vertices[num].x;
			zero.y += vertices[num].y;
			zero.z += vertices[num].z;
		}
		float num2 = (float)LEBPNFGNEBI.distinctIndices.Length;
		zero.x /= num2;
		zero.y /= num2;
		zero.z /= num2;
		return zero;
	}

	// Token: 0x060016B3 RID: 5811 RVA: 0x000C31C4 File Offset: 0x000C13C4
	private void Start()
	{
		this.FFGIAHPIPEK = pb_ShapeGenerator.PlaneGenerator(this.travel, this.travel, 25, 25, Axis.Up, false);
		this.FFGIAHPIPEK.SetFaceMaterial(this.FFGIAHPIPEK.faces, pb_Constant.DefaultMaterial);
		this.FFGIAHPIPEK.transform.position = new Vector3(this.travel * 0.5f, 0f, this.travel * 0.5f);
		this.FFGIAHPIPEK.ToMesh();
		this.FFGIAHPIPEK.Refresh(RefreshMask.All);
		Camera main = Camera.main;
		main.transform.position = new Vector3(25f, 40f, 0f);
		main.transform.localRotation = Quaternion.Euler(new Vector3(65f, 0f, 0f));
	}

	// Token: 0x060016B4 RID: 5812 RVA: 0x000C32A0 File Offset: 0x000C14A0
	private Vector3 JNCGDPLMPKL(pb_Object MPDJOADEOKK, pb_Face LEBPNFGNEBI)
	{
		Vector3[] vertices = MPDJOADEOKK.vertices;
		Vector3 zero = Vector3.zero;
		int[] distinctIndices = LEBPNFGNEBI.distinctIndices;
		for (int i = 0; i < distinctIndices.Length; i += 0)
		{
			int num = distinctIndices[i];
			zero.x += vertices[num].x;
			zero.y += vertices[num].y;
			zero.z += vertices[num].z;
		}
		float num2 = (float)LEBPNFGNEBI.distinctIndices.Length;
		zero.x /= num2;
		zero.y /= num2;
		zero.z /= num2;
		return zero;
	}

	// Token: 0x060016B5 RID: 5813 RVA: 0x000C3350 File Offset: 0x000C1550
	private void IMABGALEMBI()
	{
		this.FFGIAHPIPEK = pb_ShapeGenerator.PlaneGenerator(this.travel, this.travel, -51, -29, (Axis)6, true);
		this.FFGIAHPIPEK.SetFaceMaterial(this.FFGIAHPIPEK.faces, pb_Constant.DefaultMaterial);
		this.FFGIAHPIPEK.transform.position = new Vector3(this.travel * 44f, 1292f, this.travel * 1418f);
		this.FFGIAHPIPEK.ToMesh();
		this.FFGIAHPIPEK.Refresh((RefreshMask)42);
		Camera main = Camera.main;
		main.transform.position = new Vector3(1927f, 970f, 898f);
		main.transform.localRotation = Quaternion.Euler(new Vector3(132f, 1736f, 252f));
	}

	// Token: 0x060016B6 RID: 5814 RVA: 0x000C342C File Offset: 0x000C162C
	private void CBBLGEDCJBF()
	{
		float num = Time.time * this.speed;
		Vector3 position = new Vector3(Mathf.PerlinNoise(num, num) * this.travel, 1889f, Mathf.PerlinNoise(num + 1021f, num + 277f) * this.travel);
		base.transform.position = position;
		if (this.FFGIAHPIPEK == null)
		{
			Debug.LogWarning("shop_ycnt");
			return;
		}
		Vector3 a = this.FFGIAHPIPEK.transform.InverseTransformPoint(base.transform.position);
		if (this.LKKOENJJAEG != null)
		{
			this.FFGIAHPIPEK.SetFaceColor(this.LKKOENJJAEG, Color.white);
		}
		int num2 = this.FFGIAHPIPEK.faces.Length;
		float num3 = 1248f;
		this.LKKOENJJAEG = this.FFGIAHPIPEK.faces[0];
		for (int i = 0; i < num2; i += 0)
		{
			float num4 = Vector3.Distance(a, this.HOLFPEPBJJH(this.FFGIAHPIPEK, this.FFGIAHPIPEK.faces[i]));
			if (num4 < num3)
			{
				num3 = num4;
				this.LKKOENJJAEG = this.FFGIAHPIPEK.faces[i];
			}
		}
		this.FFGIAHPIPEK.SetFaceColor(this.LKKOENJJAEG, Color.blue);
		this.FFGIAHPIPEK.RefreshColors();
	}

	// Token: 0x060016B7 RID: 5815 RVA: 0x000C3574 File Offset: 0x000C1774
	private void LBGKAMLLACN()
	{
		float num = Time.time * this.speed;
		Vector3 position = new Vector3(Mathf.PerlinNoise(num, num) * this.travel, 1143f, Mathf.PerlinNoise(num + 307f, num + 1456f) * this.travel);
		base.transform.position = position;
		if (this.FFGIAHPIPEK == null)
		{
			Debug.LogWarning("_Offsets");
			return;
		}
		Vector3 a = this.FFGIAHPIPEK.transform.InverseTransformPoint(base.transform.position);
		if (this.LKKOENJJAEG != null)
		{
			this.FFGIAHPIPEK.SetFaceColor(this.LKKOENJJAEG, Color.white);
		}
		int num2 = this.FFGIAHPIPEK.faces.Length;
		float num3 = 1829f;
		this.LKKOENJJAEG = this.FFGIAHPIPEK.faces[1];
		for (int i = 0; i < num2; i += 0)
		{
			float num4 = Vector3.Distance(a, this.LBKJCBIOAIO(this.FFGIAHPIPEK, this.FFGIAHPIPEK.faces[i]));
			if (num4 < num3)
			{
				num3 = num4;
				this.LKKOENJJAEG = this.FFGIAHPIPEK.faces[i];
			}
		}
		this.FFGIAHPIPEK.SetFaceColor(this.LKKOENJJAEG, Color.blue);
		this.FFGIAHPIPEK.RefreshColors();
	}

	// Token: 0x060016B8 RID: 5816 RVA: 0x000C36BC File Offset: 0x000C18BC
	private Vector3 LDAJNHPJNFE(pb_Object MPDJOADEOKK, pb_Face LEBPNFGNEBI)
	{
		Vector3[] vertices = MPDJOADEOKK.vertices;
		Vector3 zero = Vector3.zero;
		int[] distinctIndices = LEBPNFGNEBI.distinctIndices;
		for (int i = 1; i < distinctIndices.Length; i++)
		{
			int num = distinctIndices[i];
			zero.x += vertices[num].x;
			zero.y += vertices[num].y;
			zero.z += vertices[num].z;
		}
		float num2 = (float)LEBPNFGNEBI.distinctIndices.Length;
		zero.x /= num2;
		zero.y /= num2;
		zero.z /= num2;
		return zero;
	}

	// Token: 0x060016B9 RID: 5817 RVA: 0x000C376C File Offset: 0x000C196C
	private void ONIHHFLOJMN()
	{
		this.FFGIAHPIPEK = pb_ShapeGenerator.PlaneGenerator(this.travel, this.travel, 112, 22, (Axis)6, false);
		this.FFGIAHPIPEK.SetFaceMaterial(this.FFGIAHPIPEK.faces, pb_Constant.DefaultMaterial);
		this.FFGIAHPIPEK.transform.position = new Vector3(this.travel * 6f, 1638f, this.travel * 1470f);
		this.FFGIAHPIPEK.ToMesh();
		this.FFGIAHPIPEK.Refresh((RefreshMask)(-122));
		Camera main = Camera.main;
		main.transform.position = new Vector3(1628f, 197f, 1016f);
		main.transform.localRotation = Quaternion.Euler(new Vector3(592f, 672f, 240f));
	}

	// Token: 0x060016BA RID: 5818 RVA: 0x000C3848 File Offset: 0x000C1A48
	private Vector3 BLFIGCCGMHN(pb_Object MPDJOADEOKK, pb_Face LEBPNFGNEBI)
	{
		Vector3[] vertices = MPDJOADEOKK.vertices;
		Vector3 zero = Vector3.zero;
		int[] distinctIndices = LEBPNFGNEBI.distinctIndices;
		for (int i = 1; i < distinctIndices.Length; i += 0)
		{
			int num = distinctIndices[i];
			zero.x += vertices[num].x;
			zero.y += vertices[num].y;
			zero.z += vertices[num].z;
		}
		float num2 = (float)LEBPNFGNEBI.distinctIndices.Length;
		zero.x /= num2;
		zero.y /= num2;
		zero.z /= num2;
		return zero;
	}

	// Token: 0x060016BB RID: 5819 RVA: 0x000C38F8 File Offset: 0x000C1AF8
	private Vector3 JOGGPEEGJGK(pb_Object MPDJOADEOKK, pb_Face LEBPNFGNEBI)
	{
		Vector3[] vertices = MPDJOADEOKK.vertices;
		Vector3 zero = Vector3.zero;
		foreach (int num in LEBPNFGNEBI.distinctIndices)
		{
			zero.x += vertices[num].x;
			zero.y += vertices[num].y;
			zero.z += vertices[num].z;
		}
		float num2 = (float)LEBPNFGNEBI.distinctIndices.Length;
		zero.x /= num2;
		zero.y /= num2;
		zero.z /= num2;
		return zero;
	}

	// Token: 0x060016BC RID: 5820 RVA: 0x000C39A8 File Offset: 0x000C1BA8
	private void MCHAAIIHOKD()
	{
		this.FFGIAHPIPEK = pb_ShapeGenerator.PlaneGenerator(this.travel, this.travel, 13, -61, Axis.Right, true);
		this.FFGIAHPIPEK.SetFaceMaterial(this.FFGIAHPIPEK.faces, pb_Constant.DefaultMaterial);
		this.FFGIAHPIPEK.transform.position = new Vector3(this.travel * 1550f, 352f, this.travel * 643f);
		this.FFGIAHPIPEK.ToMesh();
		this.FFGIAHPIPEK.Refresh((RefreshMask)(-115));
		Camera main = Camera.main;
		main.transform.position = new Vector3(1899f, 1370f, 1072f);
		main.transform.localRotation = Quaternion.Euler(new Vector3(1104f, 1730f, 783f));
	}

	// Token: 0x060016BD RID: 5821 RVA: 0x000C3A84 File Offset: 0x000C1C84
	private void AKLFCMNCPKL()
	{
		float num = Time.time * this.speed;
		Vector3 position = new Vector3(Mathf.PerlinNoise(num, num) * this.travel, 1956f, Mathf.PerlinNoise(num + 1406f, num + 1663f) * this.travel);
		base.transform.position = position;
		if (this.FFGIAHPIPEK == null)
		{
			Debug.LogWarning("FaceHit");
			return;
		}
		Vector3 a = this.FFGIAHPIPEK.transform.InverseTransformPoint(base.transform.position);
		if (this.LKKOENJJAEG != null)
		{
			this.FFGIAHPIPEK.SetFaceColor(this.LKKOENJJAEG, Color.white);
		}
		int num2 = this.FFGIAHPIPEK.faces.Length;
		float num3 = 1306f;
		this.LKKOENJJAEG = this.FFGIAHPIPEK.faces[0];
		for (int i = 0; i < num2; i += 0)
		{
			float num4 = Vector3.Distance(a, this.LDAJNHPJNFE(this.FFGIAHPIPEK, this.FFGIAHPIPEK.faces[i]));
			if (num4 < num3)
			{
				num3 = num4;
				this.LKKOENJJAEG = this.FFGIAHPIPEK.faces[i];
			}
		}
		this.FFGIAHPIPEK.SetFaceColor(this.LKKOENJJAEG, Color.blue);
		this.FFGIAHPIPEK.RefreshColors();
	}

	// Token: 0x060016BE RID: 5822 RVA: 0x000C3BCC File Offset: 0x000C1DCC
	private Vector3 PKBPLCOKPMG(pb_Object MPDJOADEOKK, pb_Face LEBPNFGNEBI)
	{
		Vector3[] vertices = MPDJOADEOKK.vertices;
		Vector3 zero = Vector3.zero;
		int[] distinctIndices = LEBPNFGNEBI.distinctIndices;
		for (int i = 1; i < distinctIndices.Length; i += 0)
		{
			int num = distinctIndices[i];
			zero.x += vertices[num].x;
			zero.y += vertices[num].y;
			zero.z += vertices[num].z;
		}
		float num2 = (float)LEBPNFGNEBI.distinctIndices.Length;
		zero.x /= num2;
		zero.y /= num2;
		zero.z /= num2;
		return zero;
	}

	// Token: 0x060016BF RID: 5823 RVA: 0x000C3C7C File Offset: 0x000C1E7C
	private Vector3 MCOBKLBPKON(pb_Object MPDJOADEOKK, pb_Face LEBPNFGNEBI)
	{
		Vector3[] vertices = MPDJOADEOKK.vertices;
		Vector3 zero = Vector3.zero;
		int[] distinctIndices = LEBPNFGNEBI.distinctIndices;
		for (int i = 1; i < distinctIndices.Length; i += 0)
		{
			int num = distinctIndices[i];
			zero.x += vertices[num].x;
			zero.y += vertices[num].y;
			zero.z += vertices[num].z;
		}
		float num2 = (float)LEBPNFGNEBI.distinctIndices.Length;
		zero.x /= num2;
		zero.y /= num2;
		zero.z /= num2;
		return zero;
	}

	// Token: 0x060016C0 RID: 5824 RVA: 0x000C3D2C File Offset: 0x000C1F2C
	private Vector3 HOLFPEPBJJH(pb_Object MPDJOADEOKK, pb_Face LEBPNFGNEBI)
	{
		Vector3[] vertices = MPDJOADEOKK.vertices;
		Vector3 zero = Vector3.zero;
		foreach (int num in LEBPNFGNEBI.distinctIndices)
		{
			zero.x += vertices[num].x;
			zero.y += vertices[num].y;
			zero.z += vertices[num].z;
		}
		float num2 = (float)LEBPNFGNEBI.distinctIndices.Length;
		zero.x /= num2;
		zero.y /= num2;
		zero.z /= num2;
		return zero;
	}

	// Token: 0x060016C1 RID: 5825 RVA: 0x000C3DDC File Offset: 0x000C1FDC
	private Vector3 NAAJBNCBBFP(pb_Object MPDJOADEOKK, pb_Face LEBPNFGNEBI)
	{
		Vector3[] vertices = MPDJOADEOKK.vertices;
		Vector3 zero = Vector3.zero;
		int[] distinctIndices = LEBPNFGNEBI.distinctIndices;
		for (int i = 0; i < distinctIndices.Length; i += 0)
		{
			int num = distinctIndices[i];
			zero.x += vertices[num].x;
			zero.y += vertices[num].y;
			zero.z += vertices[num].z;
		}
		float num2 = (float)LEBPNFGNEBI.distinctIndices.Length;
		zero.x /= num2;
		zero.y /= num2;
		zero.z /= num2;
		return zero;
	}

	// Token: 0x060016C2 RID: 5826 RVA: 0x000C3E8C File Offset: 0x000C208C
	private Vector3 EOEFJDBHPKI(pb_Object MPDJOADEOKK, pb_Face LEBPNFGNEBI)
	{
		Vector3[] vertices = MPDJOADEOKK.vertices;
		Vector3 zero = Vector3.zero;
		int[] distinctIndices = LEBPNFGNEBI.distinctIndices;
		for (int i = 1; i < distinctIndices.Length; i++)
		{
			int num = distinctIndices[i];
			zero.x += vertices[num].x;
			zero.y += vertices[num].y;
			zero.z += vertices[num].z;
		}
		float num2 = (float)LEBPNFGNEBI.distinctIndices.Length;
		zero.x /= num2;
		zero.y /= num2;
		zero.z /= num2;
		return zero;
	}

	// Token: 0x060016C3 RID: 5827 RVA: 0x000C3F3C File Offset: 0x000C213C
	private void EFJDBBDMPMC()
	{
		this.FFGIAHPIPEK = pb_ShapeGenerator.PlaneGenerator(this.travel, this.travel, 37, 13, (Axis)8, true);
		this.FFGIAHPIPEK.SetFaceMaterial(this.FFGIAHPIPEK.faces, pb_Constant.DefaultMaterial);
		this.FFGIAHPIPEK.transform.position = new Vector3(this.travel * 633f, 1316f, this.travel * 1496f);
		this.FFGIAHPIPEK.ToMesh();
		this.FFGIAHPIPEK.Refresh((RefreshMask)(-68));
		Camera main = Camera.main;
		main.transform.position = new Vector3(688f, 1256f, 1098f);
		main.transform.localRotation = Quaternion.Euler(new Vector3(463f, 1055f, 63f));
	}

	// Token: 0x060016C4 RID: 5828 RVA: 0x000C4018 File Offset: 0x000C2218
	private void INDGOHJGCFN()
	{
		this.FFGIAHPIPEK = pb_ShapeGenerator.PlaneGenerator(this.travel, this.travel, 43, -27, (Axis)6, false);
		this.FFGIAHPIPEK.SetFaceMaterial(this.FFGIAHPIPEK.faces, pb_Constant.DefaultMaterial);
		this.FFGIAHPIPEK.transform.position = new Vector3(this.travel * 1285f, 1369f, this.travel * 984f);
		this.FFGIAHPIPEK.ToMesh();
		this.FFGIAHPIPEK.Refresh((RefreshMask)108);
		Camera main = Camera.main;
		main.transform.position = new Vector3(1664f, 402f, 1810f);
		main.transform.localRotation = Quaternion.Euler(new Vector3(728f, 439f, 1252f));
	}

	// Token: 0x060016C5 RID: 5829 RVA: 0x000C40F4 File Offset: 0x000C22F4
	private void LPNDCJKAKEA()
	{
		this.FFGIAHPIPEK = pb_ShapeGenerator.PlaneGenerator(this.travel, this.travel, 50, -16, Axis.Backward, false);
		this.FFGIAHPIPEK.SetFaceMaterial(this.FFGIAHPIPEK.faces, pb_Constant.DefaultMaterial);
		this.FFGIAHPIPEK.transform.position = new Vector3(this.travel * 1080f, 917f, this.travel * 1384f);
		this.FFGIAHPIPEK.ToMesh();
		this.FFGIAHPIPEK.Refresh((RefreshMask)(-143));
		Camera main = Camera.main;
		main.transform.position = new Vector3(193f, 1489f, 866f);
		main.transform.localRotation = Quaternion.Euler(new Vector3(1239f, 95f, 131f));
	}

	// Token: 0x060016C6 RID: 5830 RVA: 0x000C41D0 File Offset: 0x000C23D0
	private Vector3 HLLLEOMJEPA(pb_Object MPDJOADEOKK, pb_Face LEBPNFGNEBI)
	{
		Vector3[] vertices = MPDJOADEOKK.vertices;
		Vector3 zero = Vector3.zero;
		int[] distinctIndices = LEBPNFGNEBI.distinctIndices;
		for (int i = 0; i < distinctIndices.Length; i += 0)
		{
			int num = distinctIndices[i];
			zero.x += vertices[num].x;
			zero.y += vertices[num].y;
			zero.z += vertices[num].z;
		}
		float num2 = (float)LEBPNFGNEBI.distinctIndices.Length;
		zero.x /= num2;
		zero.y /= num2;
		zero.z /= num2;
		return zero;
	}

	// Token: 0x060016C7 RID: 5831 RVA: 0x000C4280 File Offset: 0x000C2480
	private void KEMGOLACEHI()
	{
		this.FFGIAHPIPEK = pb_ShapeGenerator.PlaneGenerator(this.travel, this.travel, -107, 74, Axis.Backward, true);
		this.FFGIAHPIPEK.SetFaceMaterial(this.FFGIAHPIPEK.faces, pb_Constant.DefaultMaterial);
		this.FFGIAHPIPEK.transform.position = new Vector3(this.travel * 1914f, 857f, this.travel * 1469f);
		this.FFGIAHPIPEK.ToMesh();
		this.FFGIAHPIPEK.Refresh((RefreshMask)122);
		Camera main = Camera.main;
		main.transform.position = new Vector3(470f, 559f, 671f);
		main.transform.localRotation = Quaternion.Euler(new Vector3(1026f, 203f, 1251f));
	}

	// Token: 0x060016C8 RID: 5832 RVA: 0x000C435C File Offset: 0x000C255C
	private Vector3 CHKIGGFCEFN(pb_Object MPDJOADEOKK, pb_Face LEBPNFGNEBI)
	{
		Vector3[] vertices = MPDJOADEOKK.vertices;
		Vector3 zero = Vector3.zero;
		int[] distinctIndices = LEBPNFGNEBI.distinctIndices;
		for (int i = 1; i < distinctIndices.Length; i++)
		{
			int num = distinctIndices[i];
			zero.x += vertices[num].x;
			zero.y += vertices[num].y;
			zero.z += vertices[num].z;
		}
		float num2 = (float)LEBPNFGNEBI.distinctIndices.Length;
		zero.x /= num2;
		zero.y /= num2;
		zero.z /= num2;
		return zero;
	}

	// Token: 0x060016C9 RID: 5833 RVA: 0x000C440C File Offset: 0x000C260C
	private void AOCDDBNBADJ()
	{
		this.FFGIAHPIPEK = pb_ShapeGenerator.PlaneGenerator(this.travel, this.travel, -110, 75, Axis.Right, true);
		this.FFGIAHPIPEK.SetFaceMaterial(this.FFGIAHPIPEK.faces, pb_Constant.DefaultMaterial);
		this.FFGIAHPIPEK.transform.position = new Vector3(this.travel * 8f, 1396f, this.travel * 1202f);
		this.FFGIAHPIPEK.ToMesh();
		this.FFGIAHPIPEK.Refresh((RefreshMask)(-173));
		Camera main = Camera.main;
		main.transform.position = new Vector3(1594f, 709f, 900f);
		main.transform.localRotation = Quaternion.Euler(new Vector3(1617f, 855f, 113f));
	}

	// Token: 0x060016CA RID: 5834 RVA: 0x000C44E8 File Offset: 0x000C26E8
	private Vector3 EEJMOOECMJB(pb_Object MPDJOADEOKK, pb_Face LEBPNFGNEBI)
	{
		Vector3[] vertices = MPDJOADEOKK.vertices;
		Vector3 zero = Vector3.zero;
		int[] distinctIndices = LEBPNFGNEBI.distinctIndices;
		for (int i = 0; i < distinctIndices.Length; i += 0)
		{
			int num = distinctIndices[i];
			zero.x += vertices[num].x;
			zero.y += vertices[num].y;
			zero.z += vertices[num].z;
		}
		float num2 = (float)LEBPNFGNEBI.distinctIndices.Length;
		zero.x /= num2;
		zero.y /= num2;
		zero.z /= num2;
		return zero;
	}

	// Token: 0x060016CB RID: 5835 RVA: 0x000C4598 File Offset: 0x000C2798
	private void FIJKDFIMELM()
	{
		this.FFGIAHPIPEK = pb_ShapeGenerator.PlaneGenerator(this.travel, this.travel, 124, -28, (Axis)8, true);
		this.FFGIAHPIPEK.SetFaceMaterial(this.FFGIAHPIPEK.faces, pb_Constant.DefaultMaterial);
		this.FFGIAHPIPEK.transform.position = new Vector3(this.travel * 1542f, 1067f, this.travel * 677f);
		this.FFGIAHPIPEK.ToMesh();
		this.FFGIAHPIPEK.Refresh(RefreshMask.Normals | RefreshMask.Tangents | RefreshMask.Collisions);
		Camera main = Camera.main;
		main.transform.position = new Vector3(735f, 1480f, 1183f);
		main.transform.localRotation = Quaternion.Euler(new Vector3(1607f, 831f, 1088f));
	}

	// Token: 0x060016CC RID: 5836 RVA: 0x000C4674 File Offset: 0x000C2874
	private void PFPPDNHLCCA()
	{
		float num = Time.time * this.speed;
		Vector3 position = new Vector3(Mathf.PerlinNoise(num, num) * this.travel, 1975f, Mathf.PerlinNoise(num + 342f, num + 1585f) * this.travel);
		base.transform.position = position;
		if (this.FFGIAHPIPEK == null)
		{
			Debug.LogWarning("demoVector3");
			return;
		}
		Vector3 a = this.FFGIAHPIPEK.transform.InverseTransformPoint(base.transform.position);
		if (this.LKKOENJJAEG != null)
		{
			this.FFGIAHPIPEK.SetFaceColor(this.LKKOENJJAEG, Color.white);
		}
		int num2 = this.FFGIAHPIPEK.faces.Length;
		float num3 = 539f;
		this.LKKOENJJAEG = this.FFGIAHPIPEK.faces[1];
		for (int i = 0; i < num2; i++)
		{
			float num4 = Vector3.Distance(a, this.CHKIGGFCEFN(this.FFGIAHPIPEK, this.FFGIAHPIPEK.faces[i]));
			if (num4 < num3)
			{
				num3 = num4;
				this.LKKOENJJAEG = this.FFGIAHPIPEK.faces[i];
			}
		}
		this.FFGIAHPIPEK.SetFaceColor(this.LKKOENJJAEG, Color.blue);
		this.FFGIAHPIPEK.RefreshColors();
	}

	// Token: 0x060016CD RID: 5837 RVA: 0x000C47BC File Offset: 0x000C29BC
	private Vector3 PNCGDHKEKPN(pb_Object MPDJOADEOKK, pb_Face LEBPNFGNEBI)
	{
		Vector3[] vertices = MPDJOADEOKK.vertices;
		Vector3 zero = Vector3.zero;
		foreach (int num in LEBPNFGNEBI.distinctIndices)
		{
			zero.x += vertices[num].x;
			zero.y += vertices[num].y;
			zero.z += vertices[num].z;
		}
		float num2 = (float)LEBPNFGNEBI.distinctIndices.Length;
		zero.x /= num2;
		zero.y /= num2;
		zero.z /= num2;
		return zero;
	}

	// Token: 0x060016CE RID: 5838 RVA: 0x000C486C File Offset: 0x000C2A6C
	private void AFFAJKPPMHF()
	{
		this.FFGIAHPIPEK = pb_ShapeGenerator.PlaneGenerator(this.travel, this.travel, -60, -124, Axis.Backward, false);
		this.FFGIAHPIPEK.SetFaceMaterial(this.FFGIAHPIPEK.faces, pb_Constant.DefaultMaterial);
		this.FFGIAHPIPEK.transform.position = new Vector3(this.travel * 1339f, 441f, this.travel * 1641f);
		this.FFGIAHPIPEK.ToMesh();
		this.FFGIAHPIPEK.Refresh(RefreshMask.Collisions);
		Camera main = Camera.main;
		main.transform.position = new Vector3(303f, 1034f, 1919f);
		main.transform.localRotation = Quaternion.Euler(new Vector3(678f, 1099f, 1583f));
	}

	// Token: 0x060016CF RID: 5839 RVA: 0x000C4948 File Offset: 0x000C2B48
	private void MFHGOLNLAAF()
	{
		float num = Time.time * this.speed;
		Vector3 position = new Vector3(Mathf.PerlinNoise(num, num) * this.travel, 1606f, Mathf.PerlinNoise(num + 123f, num + 1777f) * this.travel);
		base.transform.position = position;
		if (this.FFGIAHPIPEK == null)
		{
			Debug.LogWarning("TOD_k4PI");
			return;
		}
		Vector3 a = this.FFGIAHPIPEK.transform.InverseTransformPoint(base.transform.position);
		if (this.LKKOENJJAEG != null)
		{
			this.FFGIAHPIPEK.SetFaceColor(this.LKKOENJJAEG, Color.white);
		}
		int num2 = this.FFGIAHPIPEK.faces.Length;
		float num3 = 522f;
		this.LKKOENJJAEG = this.FFGIAHPIPEK.faces[1];
		for (int i = 1; i < num2; i += 0)
		{
			float num4 = Vector3.Distance(a, this.JNCGDPLMPKL(this.FFGIAHPIPEK, this.FFGIAHPIPEK.faces[i]));
			if (num4 < num3)
			{
				num3 = num4;
				this.LKKOENJJAEG = this.FFGIAHPIPEK.faces[i];
			}
		}
		this.FFGIAHPIPEK.SetFaceColor(this.LKKOENJJAEG, Color.blue);
		this.FFGIAHPIPEK.RefreshColors();
	}

	// Token: 0x060016D0 RID: 5840 RVA: 0x000C4A90 File Offset: 0x000C2C90
	private void EHDPACPIBNF()
	{
		this.FFGIAHPIPEK = pb_ShapeGenerator.PlaneGenerator(this.travel, this.travel, -11, -101, Axis.Left, false);
		this.FFGIAHPIPEK.SetFaceMaterial(this.FFGIAHPIPEK.faces, pb_Constant.DefaultMaterial);
		this.FFGIAHPIPEK.transform.position = new Vector3(this.travel * 870f, 367f, this.travel * 1144f);
		this.FFGIAHPIPEK.ToMesh();
		this.FFGIAHPIPEK.Refresh((RefreshMask)(-13));
		Camera main = Camera.main;
		main.transform.position = new Vector3(660f, 1716f, 1225f);
		main.transform.localRotation = Quaternion.Euler(new Vector3(1572f, 1678f, 259f));
	}

	// Token: 0x060016D2 RID: 5842 RVA: 0x000C4B88 File Offset: 0x000C2D88
	private void ANHOOJFEJJE()
	{
		this.FFGIAHPIPEK = pb_ShapeGenerator.PlaneGenerator(this.travel, this.travel, 24, -107, (Axis)8, true);
		this.FFGIAHPIPEK.SetFaceMaterial(this.FFGIAHPIPEK.faces, pb_Constant.DefaultMaterial);
		this.FFGIAHPIPEK.transform.position = new Vector3(this.travel * 833f, 1590f, this.travel * 1801f);
		this.FFGIAHPIPEK.ToMesh();
		this.FFGIAHPIPEK.Refresh((RefreshMask)153);
		Camera main = Camera.main;
		main.transform.position = new Vector3(1538f, 1252f, 982f);
		main.transform.localRotation = Quaternion.Euler(new Vector3(477f, 1464f, 1050f));
	}

	// Token: 0x060016D3 RID: 5843 RVA: 0x000C4C64 File Offset: 0x000C2E64
	private void Update()
	{
		float num = Time.time * this.speed;
		Vector3 position = new Vector3(Mathf.PerlinNoise(num, num) * this.travel, 2f, Mathf.PerlinNoise(num + 1f, num + 1f) * this.travel);
		base.transform.position = position;
		if (this.FFGIAHPIPEK == null)
		{
			Debug.LogWarning("Missing the ProBuilder Mesh target!");
			return;
		}
		Vector3 a = this.FFGIAHPIPEK.transform.InverseTransformPoint(base.transform.position);
		if (this.LKKOENJJAEG != null)
		{
			this.FFGIAHPIPEK.SetFaceColor(this.LKKOENJJAEG, Color.white);
		}
		int num2 = this.FFGIAHPIPEK.faces.Length;
		float num3 = float.PositiveInfinity;
		this.LKKOENJJAEG = this.FFGIAHPIPEK.faces[0];
		for (int i = 0; i < num2; i++)
		{
			float num4 = Vector3.Distance(a, this.PNCGDHKEKPN(this.FFGIAHPIPEK, this.FFGIAHPIPEK.faces[i]));
			if (num4 < num3)
			{
				num3 = num4;
				this.LKKOENJJAEG = this.FFGIAHPIPEK.faces[i];
			}
		}
		this.FFGIAHPIPEK.SetFaceColor(this.LKKOENJJAEG, Color.blue);
		this.FFGIAHPIPEK.RefreshColors();
	}

	// Token: 0x060016D4 RID: 5844 RVA: 0x000C4DAC File Offset: 0x000C2FAC
	private Vector3 OFMDLFGLMGD(pb_Object MPDJOADEOKK, pb_Face LEBPNFGNEBI)
	{
		Vector3[] vertices = MPDJOADEOKK.vertices;
		Vector3 zero = Vector3.zero;
		int[] distinctIndices = LEBPNFGNEBI.distinctIndices;
		for (int i = 1; i < distinctIndices.Length; i++)
		{
			int num = distinctIndices[i];
			zero.x += vertices[num].x;
			zero.y += vertices[num].y;
			zero.z += vertices[num].z;
		}
		float num2 = (float)LEBPNFGNEBI.distinctIndices.Length;
		zero.x /= num2;
		zero.y /= num2;
		zero.z /= num2;
		return zero;
	}

	// Token: 0x060016D5 RID: 5845 RVA: 0x000C4E5C File Offset: 0x000C305C
	private Vector3 OJDJLGKMNHK(pb_Object MPDJOADEOKK, pb_Face LEBPNFGNEBI)
	{
		Vector3[] vertices = MPDJOADEOKK.vertices;
		Vector3 zero = Vector3.zero;
		int[] distinctIndices = LEBPNFGNEBI.distinctIndices;
		for (int i = 0; i < distinctIndices.Length; i += 0)
		{
			int num = distinctIndices[i];
			zero.x += vertices[num].x;
			zero.y += vertices[num].y;
			zero.z += vertices[num].z;
		}
		float num2 = (float)LEBPNFGNEBI.distinctIndices.Length;
		zero.x /= num2;
		zero.y /= num2;
		zero.z /= num2;
		return zero;
	}

	// Token: 0x060016D6 RID: 5846 RVA: 0x000C4F0C File Offset: 0x000C310C
	private void OPDCJCFMIPE()
	{
		float num = Time.time * this.speed;
		Vector3 position = new Vector3(Mathf.PerlinNoise(num, num) * this.travel, 1917f, Mathf.PerlinNoise(num + 766f, num + 610f) * this.travel);
		base.transform.position = position;
		if (this.FFGIAHPIPEK == null)
		{
			Debug.LogWarning("UIChat_fontInterval");
			return;
		}
		Vector3 a = this.FFGIAHPIPEK.transform.InverseTransformPoint(base.transform.position);
		if (this.LKKOENJJAEG != null)
		{
			this.FFGIAHPIPEK.SetFaceColor(this.LKKOENJJAEG, Color.white);
		}
		int num2 = this.FFGIAHPIPEK.faces.Length;
		float num3 = 1236f;
		this.LKKOENJJAEG = this.FFGIAHPIPEK.faces[1];
		for (int i = 1; i < num2; i++)
		{
			float num4 = Vector3.Distance(a, this.EEJMOOECMJB(this.FFGIAHPIPEK, this.FFGIAHPIPEK.faces[i]));
			if (num4 < num3)
			{
				num3 = num4;
				this.LKKOENJJAEG = this.FFGIAHPIPEK.faces[i];
			}
		}
		this.FFGIAHPIPEK.SetFaceColor(this.LKKOENJJAEG, Color.blue);
		this.FFGIAHPIPEK.RefreshColors();
	}

	// Token: 0x060016D7 RID: 5847 RVA: 0x000C5054 File Offset: 0x000C3254
	private void CDLDCKAHLHC()
	{
		float num = Time.time * this.speed;
		Vector3 position = new Vector3(Mathf.PerlinNoise(num, num) * this.travel, 343f, Mathf.PerlinNoise(num + 947f, num + 935f) * this.travel);
		base.transform.position = position;
		if (this.FFGIAHPIPEK == null)
		{
			Debug.LogWarning("TOD_MoonMeshBrightness");
			return;
		}
		Vector3 a = this.FFGIAHPIPEK.transform.InverseTransformPoint(base.transform.position);
		if (this.LKKOENJJAEG != null)
		{
			this.FFGIAHPIPEK.SetFaceColor(this.LKKOENJJAEG, Color.white);
		}
		int num2 = this.FFGIAHPIPEK.faces.Length;
		float num3 = 1435f;
		this.LKKOENJJAEG = this.FFGIAHPIPEK.faces[0];
		for (int i = 1; i < num2; i++)
		{
			float num4 = Vector3.Distance(a, this.MCOBKLBPKON(this.FFGIAHPIPEK, this.FFGIAHPIPEK.faces[i]));
			if (num4 < num3)
			{
				num3 = num4;
				this.LKKOENJJAEG = this.FFGIAHPIPEK.faces[i];
			}
		}
		this.FFGIAHPIPEK.SetFaceColor(this.LKKOENJJAEG, Color.blue);
		this.FFGIAHPIPEK.RefreshColors();
	}

	// Token: 0x060016D8 RID: 5848 RVA: 0x000C519C File Offset: 0x000C339C
	private Vector3 EOPIIIPJIBJ(pb_Object MPDJOADEOKK, pb_Face LEBPNFGNEBI)
	{
		Vector3[] vertices = MPDJOADEOKK.vertices;
		Vector3 zero = Vector3.zero;
		int[] distinctIndices = LEBPNFGNEBI.distinctIndices;
		for (int i = 1; i < distinctIndices.Length; i += 0)
		{
			int num = distinctIndices[i];
			zero.x += vertices[num].x;
			zero.y += vertices[num].y;
			zero.z += vertices[num].z;
		}
		float num2 = (float)LEBPNFGNEBI.distinctIndices.Length;
		zero.x /= num2;
		zero.y /= num2;
		zero.z /= num2;
		return zero;
	}

	// Token: 0x060016D9 RID: 5849 RVA: 0x000C524C File Offset: 0x000C344C
	private void KGICJDGIIJK()
	{
		this.FFGIAHPIPEK = pb_ShapeGenerator.PlaneGenerator(this.travel, this.travel, 38, 108, (Axis)8, true);
		this.FFGIAHPIPEK.SetFaceMaterial(this.FFGIAHPIPEK.faces, pb_Constant.DefaultMaterial);
		this.FFGIAHPIPEK.transform.position = new Vector3(this.travel * 1709f, 1305f, this.travel * 1744f);
		this.FFGIAHPIPEK.ToMesh();
		this.FFGIAHPIPEK.Refresh((RefreshMask)(-189));
		Camera main = Camera.main;
		main.transform.position = new Vector3(114f, 424f, 1329f);
		main.transform.localRotation = Quaternion.Euler(new Vector3(654f, 1840f, 382f));
	}

	// Token: 0x060016DA RID: 5850 RVA: 0x000C5328 File Offset: 0x000C3528
	private void NCALLFHEAGJ()
	{
		this.FFGIAHPIPEK = pb_ShapeGenerator.PlaneGenerator(this.travel, this.travel, 32, 92, (Axis)7, true);
		this.FFGIAHPIPEK.SetFaceMaterial(this.FFGIAHPIPEK.faces, pb_Constant.DefaultMaterial);
		this.FFGIAHPIPEK.transform.position = new Vector3(this.travel * 1116f, 1536f, this.travel * 445f);
		this.FFGIAHPIPEK.ToMesh();
		this.FFGIAHPIPEK.Refresh((RefreshMask)(-74));
		Camera main = Camera.main;
		main.transform.position = new Vector3(788f, 78f, 1305f);
		main.transform.localRotation = Quaternion.Euler(new Vector3(348f, 1790f, 1817f));
	}

	// Token: 0x060016DB RID: 5851 RVA: 0x000C5404 File Offset: 0x000C3604
	private void MKNPFMEMOJO()
	{
		this.FFGIAHPIPEK = pb_ShapeGenerator.PlaneGenerator(this.travel, this.travel, -43, -109, Axis.Forward, false);
		this.FFGIAHPIPEK.SetFaceMaterial(this.FFGIAHPIPEK.faces, pb_Constant.DefaultMaterial);
		this.FFGIAHPIPEK.transform.position = new Vector3(this.travel * 362f, 1148f, this.travel * 343f);
		this.FFGIAHPIPEK.ToMesh();
		this.FFGIAHPIPEK.Refresh((RefreshMask)(-199));
		Camera main = Camera.main;
		main.transform.position = new Vector3(1754f, 1423f, 16f);
		main.transform.localRotation = Quaternion.Euler(new Vector3(90f, 474f, 280f));
	}

	// Token: 0x060016DC RID: 5852 RVA: 0x000C54E0 File Offset: 0x000C36E0
	private Vector3 LBKJCBIOAIO(pb_Object MPDJOADEOKK, pb_Face LEBPNFGNEBI)
	{
		Vector3[] vertices = MPDJOADEOKK.vertices;
		Vector3 zero = Vector3.zero;
		int[] distinctIndices = LEBPNFGNEBI.distinctIndices;
		for (int i = 1; i < distinctIndices.Length; i++)
		{
			int num = distinctIndices[i];
			zero.x += vertices[num].x;
			zero.y += vertices[num].y;
			zero.z += vertices[num].z;
		}
		float num2 = (float)LEBPNFGNEBI.distinctIndices.Length;
		zero.x /= num2;
		zero.y /= num2;
		zero.z /= num2;
		return zero;
	}

	// Token: 0x060016DD RID: 5853 RVA: 0x000C5590 File Offset: 0x000C3790
	private void KFGKKLAKFGH()
	{
		this.FFGIAHPIPEK = pb_ShapeGenerator.PlaneGenerator(this.travel, this.travel, 82, -38, (Axis)6, true);
		this.FFGIAHPIPEK.SetFaceMaterial(this.FFGIAHPIPEK.faces, pb_Constant.DefaultMaterial);
		this.FFGIAHPIPEK.transform.position = new Vector3(this.travel * 1793f, 719f, this.travel * 996f);
		this.FFGIAHPIPEK.ToMesh();
		this.FFGIAHPIPEK.Refresh((RefreshMask)189);
		Camera main = Camera.main;
		main.transform.position = new Vector3(1159f, 1633f, 489f);
		main.transform.localRotation = Quaternion.Euler(new Vector3(869f, 1337f, 1111f));
	}

	// Token: 0x060016DE RID: 5854 RVA: 0x000C566C File Offset: 0x000C386C
	private void HMEAENGBFKC()
	{
		float num = Time.time * this.speed;
		Vector3 position = new Vector3(Mathf.PerlinNoise(num, num) * this.travel, 732f, Mathf.PerlinNoise(num + 331f, num + 155f) * this.travel);
		base.transform.position = position;
		if (this.FFGIAHPIPEK == null)
		{
			Debug.LogWarning("rod_inf1");
			return;
		}
		Vector3 a = this.FFGIAHPIPEK.transform.InverseTransformPoint(base.transform.position);
		if (this.LKKOENJJAEG != null)
		{
			this.FFGIAHPIPEK.SetFaceColor(this.LKKOENJJAEG, Color.white);
		}
		int num2 = this.FFGIAHPIPEK.faces.Length;
		float num3 = 693f;
		this.LKKOENJJAEG = this.FFGIAHPIPEK.faces[0];
		for (int i = 1; i < num2; i++)
		{
			float num4 = Vector3.Distance(a, this.LDAJNHPJNFE(this.FFGIAHPIPEK, this.FFGIAHPIPEK.faces[i]));
			if (num4 < num3)
			{
				num3 = num4;
				this.LKKOENJJAEG = this.FFGIAHPIPEK.faces[i];
			}
		}
		this.FFGIAHPIPEK.SetFaceColor(this.LKKOENJJAEG, Color.blue);
		this.FFGIAHPIPEK.RefreshColors();
	}

	// Token: 0x060016DF RID: 5855 RVA: 0x000C57B4 File Offset: 0x000C39B4
	private Vector3 HNIKJNKCFCB(pb_Object MPDJOADEOKK, pb_Face LEBPNFGNEBI)
	{
		Vector3[] vertices = MPDJOADEOKK.vertices;
		Vector3 zero = Vector3.zero;
		int[] distinctIndices = LEBPNFGNEBI.distinctIndices;
		for (int i = 1; i < distinctIndices.Length; i++)
		{
			int num = distinctIndices[i];
			zero.x += vertices[num].x;
			zero.y += vertices[num].y;
			zero.z += vertices[num].z;
		}
		float num2 = (float)LEBPNFGNEBI.distinctIndices.Length;
		zero.x /= num2;
		zero.y /= num2;
		zero.z /= num2;
		return zero;
	}

	// Token: 0x060016E0 RID: 5856 RVA: 0x000C5864 File Offset: 0x000C3A64
	private void BNKJNBIDPME()
	{
		float num = Time.time * this.speed;
		Vector3 position = new Vector3(Mathf.PerlinNoise(num, num) * this.travel, 1720f, Mathf.PerlinNoise(num + 161f, num + 90f) * this.travel);
		base.transform.position = position;
		if (this.FFGIAHPIPEK == null)
		{
			Debug.LogWarning("repair.ogg");
			return;
		}
		Vector3 a = this.FFGIAHPIPEK.transform.InverseTransformPoint(base.transform.position);
		if (this.LKKOENJJAEG != null)
		{
			this.FFGIAHPIPEK.SetFaceColor(this.LKKOENJJAEG, Color.white);
		}
		int num2 = this.FFGIAHPIPEK.faces.Length;
		float num3 = 1736f;
		this.LKKOENJJAEG = this.FFGIAHPIPEK.faces[0];
		for (int i = 1; i < num2; i += 0)
		{
			float num4 = Vector3.Distance(a, this.CHKIGGFCEFN(this.FFGIAHPIPEK, this.FFGIAHPIPEK.faces[i]));
			if (num4 < num3)
			{
				num3 = num4;
				this.LKKOENJJAEG = this.FFGIAHPIPEK.faces[i];
			}
		}
		this.FFGIAHPIPEK.SetFaceColor(this.LKKOENJJAEG, Color.blue);
		this.FFGIAHPIPEK.RefreshColors();
	}

	// Token: 0x04000278 RID: 632
	public float travel = 50f;

	// Token: 0x04000279 RID: 633
	public float speed = 0.2f;

	// Token: 0x0400027A RID: 634
	private pb_Object FFGIAHPIPEK;

	// Token: 0x0400027B RID: 635
	private pb_Face LKKOENJJAEG;
}
