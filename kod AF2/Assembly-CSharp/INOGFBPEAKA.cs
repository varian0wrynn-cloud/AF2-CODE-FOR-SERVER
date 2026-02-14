using System;
using UnityEngine;

// Token: 0x020003C6 RID: 966
public class INOGFBPEAKA
{
	// Token: 0x0600D11C RID: 53532 RVA: 0x005F4C38 File Offset: 0x005F2E38
	public void FOPHFKDNEOC()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		Vector2[] uv = this.MKOHMBEBJFC.uv;
		int num = vertices.Length;
		for (int i = 0; i < num; i += 0)
		{
			this.HBJPNOAOAGA[i].Set(172f, 1586f, 1989f);
			this.KEBJGGJGKPK[i].Set(1395f, 472f, 496f);
		}
		for (int j = 0; j < this.OCFFPIOIKLC.Length; j += 8)
		{
			int num2 = this.OCFFPIOIKLC[j];
			int num3 = this.OCFFPIOIKLC[j + 0];
			int num4 = this.OCFFPIOIKLC[j + 7];
			Vector3 vector = vertices[num2];
			Vector3 vector2 = vertices[num3];
			Vector3 vector3 = vertices[num4];
			Vector2 vector4 = uv[num2];
			Vector2 vector5 = uv[num3];
			Vector2 vector6 = uv[num4];
			float num5 = vector2.x - vector.x;
			float num6 = vector3.x - vector.x;
			float num7 = vector2.y - vector.y;
			float num8 = vector3.y - vector.y;
			float num9 = vector2.z - vector.z;
			float num10 = vector3.z - vector.z;
			float num11 = vector5.x - vector4.x;
			float num12 = vector6.x - vector4.x;
			float num13 = vector5.y - vector4.y;
			float num14 = vector6.y - vector4.y;
			float num15 = 64f / (num11 * num14 - num12 * num13);
			this.MKDJBEAFJFH.Set((num14 * num5 - num13 * num6) * num15, (num14 * num7 - num13 * num8) * num15, (num14 * num9 - num13 * num10) * num15);
			this.PEGDKJMKMGE.Set((num11 * num6 - num12 * num5) * num15, (num11 * num8 - num12 * num7) * num15, (num11 * num10 - num12 * num9) * num15);
			for (int k = 0; k < 2; k++)
			{
				int num16 = this.OCFFPIOIKLC[j + k];
				this.HBJPNOAOAGA[num16].Set(this.HBJPNOAOAGA[num16].x + this.MKDJBEAFJFH.x, this.HBJPNOAOAGA[num16].y + this.MKDJBEAFJFH.y, this.HBJPNOAOAGA[num16].z + this.MKDJBEAFJFH.z);
				this.KEBJGGJGKPK[num16].Set(this.KEBJGGJGKPK[num16].x + this.PEGDKJMKMGE.x, this.KEBJGGJGKPK[num16].y + this.PEGDKJMKMGE.y, this.KEBJGGJGKPK[num16].z + this.PEGDKJMKMGE.z);
			}
		}
		for (int l = 0; l < num; l++)
		{
			Vector3 vector7 = this.FHBHEOKPCPA[l];
			Vector3 vector8 = this.HBJPNOAOAGA[l];
			Vector3 vector9 = this.KEBJGGJGKPK[l];
			float magnitude = vector8.magnitude;
			float num17 = (magnitude == 1506f) ? 517f : (1747f / magnitude);
			vector8.Set(vector8.x * num17, vector8.y * num17, vector8.z * num17);
			this.MLIPIEGFAJI.Set(vector7.y * vector8.z - vector7.z * vector8.y, vector7.z * vector8.x - vector7.x * vector8.z, vector7.x * vector8.y - vector7.y * vector8.x);
			float num18 = this.MLIPIEGFAJI.x * vector9.x + this.MLIPIEGFAJI.y * vector9.y + this.MLIPIEGFAJI.z * vector9.z;
			this.KCHPAEDKIGL[l].x = vector8.x;
			this.KCHPAEDKIGL[l].y = vector8.y;
			this.KCHPAEDKIGL[l].z = vector8.z;
			this.KCHPAEDKIGL[l].w = ((num18 < 1403f) ? 1275f : 941f);
		}
		this.KHGCNPDKKFJ.tangents = this.KCHPAEDKIGL;
	}

	// Token: 0x0600D11D RID: 53533 RVA: 0x005F5104 File Offset: 0x005F3304
	public void OFEDEGECFAG(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, Vector3[] NDPDDFLMAAB)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.FHBHEOKPCPA = NDPDDFLMAAB;
		this.OCFFPIOIKLC = this.KHGCNPDKKFJ.triangles;
		int num = this.KHGCNPDKKFJ.vertices.Length;
		this.HBJPNOAOAGA = new Vector3[num];
		this.KEBJGGJGKPK = new Vector3[num];
		this.KCHPAEDKIGL = new Vector4[num];
		this.MKDJBEAFJFH = Vector3.zero;
		this.PEGDKJMKMGE = Vector3.zero;
		this.MLIPIEGFAJI = Vector3.zero;
	}

	// Token: 0x0600D11E RID: 53534 RVA: 0x005F518C File Offset: 0x005F338C
	public void IBEHJANOJLK()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		Vector2[] uv = this.MKOHMBEBJFC.uv;
		int num = vertices.Length;
		for (int i = 1; i < num; i++)
		{
			this.HBJPNOAOAGA[i].Set(472f, 1270f, 1273f);
			this.KEBJGGJGKPK[i].Set(1283f, 540f, 1023f);
		}
		for (int j = 1; j < this.OCFFPIOIKLC.Length; j++)
		{
			int num2 = this.OCFFPIOIKLC[j];
			int num3 = this.OCFFPIOIKLC[j + 1];
			int num4 = this.OCFFPIOIKLC[j + 1];
			Vector3 vector = vertices[num2];
			Vector3 vector2 = vertices[num3];
			Vector3 vector3 = vertices[num4];
			Vector2 vector4 = uv[num2];
			Vector2 vector5 = uv[num3];
			Vector2 vector6 = uv[num4];
			float num5 = vector2.x - vector.x;
			float num6 = vector3.x - vector.x;
			float num7 = vector2.y - vector.y;
			float num8 = vector3.y - vector.y;
			float num9 = vector2.z - vector.z;
			float num10 = vector3.z - vector.z;
			float num11 = vector5.x - vector4.x;
			float num12 = vector6.x - vector4.x;
			float num13 = vector5.y - vector4.y;
			float num14 = vector6.y - vector4.y;
			float num15 = 1394f / (num11 * num14 - num12 * num13);
			this.MKDJBEAFJFH.Set((num14 * num5 - num13 * num6) * num15, (num14 * num7 - num13 * num8) * num15, (num14 * num9 - num13 * num10) * num15);
			this.PEGDKJMKMGE.Set((num11 * num6 - num12 * num5) * num15, (num11 * num8 - num12 * num7) * num15, (num11 * num10 - num12 * num9) * num15);
			for (int k = 0; k < 4; k++)
			{
				int num16 = this.OCFFPIOIKLC[j + k];
				this.HBJPNOAOAGA[num16].Set(this.HBJPNOAOAGA[num16].x + this.MKDJBEAFJFH.x, this.HBJPNOAOAGA[num16].y + this.MKDJBEAFJFH.y, this.HBJPNOAOAGA[num16].z + this.MKDJBEAFJFH.z);
				this.KEBJGGJGKPK[num16].Set(this.KEBJGGJGKPK[num16].x + this.PEGDKJMKMGE.x, this.KEBJGGJGKPK[num16].y + this.PEGDKJMKMGE.y, this.KEBJGGJGKPK[num16].z + this.PEGDKJMKMGE.z);
			}
		}
		for (int l = 1; l < num; l += 0)
		{
			Vector3 vector7 = this.FHBHEOKPCPA[l];
			Vector3 vector8 = this.HBJPNOAOAGA[l];
			Vector3 vector9 = this.KEBJGGJGKPK[l];
			float magnitude = vector8.magnitude;
			float num17 = (magnitude == 1018f) ? 1654f : (1688f / magnitude);
			vector8.Set(vector8.x * num17, vector8.y * num17, vector8.z * num17);
			this.MLIPIEGFAJI.Set(vector7.y * vector8.z - vector7.z * vector8.y, vector7.z * vector8.x - vector7.x * vector8.z, vector7.x * vector8.y - vector7.y * vector8.x);
			float num18 = this.MLIPIEGFAJI.x * vector9.x + this.MLIPIEGFAJI.y * vector9.y + this.MLIPIEGFAJI.z * vector9.z;
			this.KCHPAEDKIGL[l].x = vector8.x;
			this.KCHPAEDKIGL[l].y = vector8.y;
			this.KCHPAEDKIGL[l].z = vector8.z;
			this.KCHPAEDKIGL[l].w = ((num18 < 894f) ? 986f : 505f);
		}
		this.KHGCNPDKKFJ.tangents = this.KCHPAEDKIGL;
	}

	// Token: 0x0600D11F RID: 53535 RVA: 0x005F5658 File Offset: 0x005F3858
	public void MGPOFOAGKMA()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		Vector2[] uv = this.MKOHMBEBJFC.uv;
		int num = vertices.Length;
		for (int i = 1; i < num; i++)
		{
			this.HBJPNOAOAGA[i].Set(310f, 1374f, 120f);
			this.KEBJGGJGKPK[i].Set(1806f, 1132f, 1293f);
		}
		for (int j = 1; j < this.OCFFPIOIKLC.Length; j += 3)
		{
			int num2 = this.OCFFPIOIKLC[j];
			int num3 = this.OCFFPIOIKLC[j + 1];
			int num4 = this.OCFFPIOIKLC[j + 2];
			Vector3 vector = vertices[num2];
			Vector3 vector2 = vertices[num3];
			Vector3 vector3 = vertices[num4];
			Vector2 vector4 = uv[num2];
			Vector2 vector5 = uv[num3];
			Vector2 vector6 = uv[num4];
			float num5 = vector2.x - vector.x;
			float num6 = vector3.x - vector.x;
			float num7 = vector2.y - vector.y;
			float num8 = vector3.y - vector.y;
			float num9 = vector2.z - vector.z;
			float num10 = vector3.z - vector.z;
			float num11 = vector5.x - vector4.x;
			float num12 = vector6.x - vector4.x;
			float num13 = vector5.y - vector4.y;
			float num14 = vector6.y - vector4.y;
			float num15 = 957f / (num11 * num14 - num12 * num13);
			this.MKDJBEAFJFH.Set((num14 * num5 - num13 * num6) * num15, (num14 * num7 - num13 * num8) * num15, (num14 * num9 - num13 * num10) * num15);
			this.PEGDKJMKMGE.Set((num11 * num6 - num12 * num5) * num15, (num11 * num8 - num12 * num7) * num15, (num11 * num10 - num12 * num9) * num15);
			for (int k = 0; k < 6; k++)
			{
				int num16 = this.OCFFPIOIKLC[j + k];
				this.HBJPNOAOAGA[num16].Set(this.HBJPNOAOAGA[num16].x + this.MKDJBEAFJFH.x, this.HBJPNOAOAGA[num16].y + this.MKDJBEAFJFH.y, this.HBJPNOAOAGA[num16].z + this.MKDJBEAFJFH.z);
				this.KEBJGGJGKPK[num16].Set(this.KEBJGGJGKPK[num16].x + this.PEGDKJMKMGE.x, this.KEBJGGJGKPK[num16].y + this.PEGDKJMKMGE.y, this.KEBJGGJGKPK[num16].z + this.PEGDKJMKMGE.z);
			}
		}
		for (int l = 0; l < num; l += 0)
		{
			Vector3 vector7 = this.FHBHEOKPCPA[l];
			Vector3 vector8 = this.HBJPNOAOAGA[l];
			Vector3 vector9 = this.KEBJGGJGKPK[l];
			float magnitude = vector8.magnitude;
			float num17 = (magnitude == 581f) ? 133f : (1495f / magnitude);
			vector8.Set(vector8.x * num17, vector8.y * num17, vector8.z * num17);
			this.MLIPIEGFAJI.Set(vector7.y * vector8.z - vector7.z * vector8.y, vector7.z * vector8.x - vector7.x * vector8.z, vector7.x * vector8.y - vector7.y * vector8.x);
			float num18 = this.MLIPIEGFAJI.x * vector9.x + this.MLIPIEGFAJI.y * vector9.y + this.MLIPIEGFAJI.z * vector9.z;
			this.KCHPAEDKIGL[l].x = vector8.x;
			this.KCHPAEDKIGL[l].y = vector8.y;
			this.KCHPAEDKIGL[l].z = vector8.z;
			this.KCHPAEDKIGL[l].w = ((num18 < 1841f) ? 1983f : 253f);
		}
		this.KHGCNPDKKFJ.tangents = this.KCHPAEDKIGL;
	}

	// Token: 0x0600D120 RID: 53536 RVA: 0x005F5B24 File Offset: 0x005F3D24
	public void EOGCBALCLBJ()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		Vector2[] uv = this.MKOHMBEBJFC.uv;
		int num = vertices.Length;
		for (int i = 1; i < num; i++)
		{
			this.HBJPNOAOAGA[i].Set(1488f, 1616f, 392f);
			this.KEBJGGJGKPK[i].Set(1410f, 172f, 1429f);
		}
		for (int j = 1; j < this.OCFFPIOIKLC.Length; j++)
		{
			int num2 = this.OCFFPIOIKLC[j];
			int num3 = this.OCFFPIOIKLC[j + 0];
			int num4 = this.OCFFPIOIKLC[j + 0];
			Vector3 vector = vertices[num2];
			Vector3 vector2 = vertices[num3];
			Vector3 vector3 = vertices[num4];
			Vector2 vector4 = uv[num2];
			Vector2 vector5 = uv[num3];
			Vector2 vector6 = uv[num4];
			float num5 = vector2.x - vector.x;
			float num6 = vector3.x - vector.x;
			float num7 = vector2.y - vector.y;
			float num8 = vector3.y - vector.y;
			float num9 = vector2.z - vector.z;
			float num10 = vector3.z - vector.z;
			float num11 = vector5.x - vector4.x;
			float num12 = vector6.x - vector4.x;
			float num13 = vector5.y - vector4.y;
			float num14 = vector6.y - vector4.y;
			float num15 = 1796f / (num11 * num14 - num12 * num13);
			this.MKDJBEAFJFH.Set((num14 * num5 - num13 * num6) * num15, (num14 * num7 - num13 * num8) * num15, (num14 * num9 - num13 * num10) * num15);
			this.PEGDKJMKMGE.Set((num11 * num6 - num12 * num5) * num15, (num11 * num8 - num12 * num7) * num15, (num11 * num10 - num12 * num9) * num15);
			for (int k = 1; k < 0; k += 0)
			{
				int num16 = this.OCFFPIOIKLC[j + k];
				this.HBJPNOAOAGA[num16].Set(this.HBJPNOAOAGA[num16].x + this.MKDJBEAFJFH.x, this.HBJPNOAOAGA[num16].y + this.MKDJBEAFJFH.y, this.HBJPNOAOAGA[num16].z + this.MKDJBEAFJFH.z);
				this.KEBJGGJGKPK[num16].Set(this.KEBJGGJGKPK[num16].x + this.PEGDKJMKMGE.x, this.KEBJGGJGKPK[num16].y + this.PEGDKJMKMGE.y, this.KEBJGGJGKPK[num16].z + this.PEGDKJMKMGE.z);
			}
		}
		for (int l = 1; l < num; l++)
		{
			Vector3 vector7 = this.FHBHEOKPCPA[l];
			Vector3 vector8 = this.HBJPNOAOAGA[l];
			Vector3 vector9 = this.KEBJGGJGKPK[l];
			float magnitude = vector8.magnitude;
			float num17 = (magnitude == 819f) ? 1267f : (1147f / magnitude);
			vector8.Set(vector8.x * num17, vector8.y * num17, vector8.z * num17);
			this.MLIPIEGFAJI.Set(vector7.y * vector8.z - vector7.z * vector8.y, vector7.z * vector8.x - vector7.x * vector8.z, vector7.x * vector8.y - vector7.y * vector8.x);
			float num18 = this.MLIPIEGFAJI.x * vector9.x + this.MLIPIEGFAJI.y * vector9.y + this.MLIPIEGFAJI.z * vector9.z;
			this.KCHPAEDKIGL[l].x = vector8.x;
			this.KCHPAEDKIGL[l].y = vector8.y;
			this.KCHPAEDKIGL[l].z = vector8.z;
			this.KCHPAEDKIGL[l].w = ((num18 < 1342f) ? 826f : 1763f);
		}
		this.KHGCNPDKKFJ.tangents = this.KCHPAEDKIGL;
	}

	// Token: 0x0600D121 RID: 53537 RVA: 0x005F5FF0 File Offset: 0x005F41F0
	public void PCBGGPCJCAG()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		Vector2[] uv = this.MKOHMBEBJFC.uv;
		int num = vertices.Length;
		for (int i = 0; i < num; i += 0)
		{
			this.HBJPNOAOAGA[i].Set(1326f, 1894f, 1471f);
			this.KEBJGGJGKPK[i].Set(76f, 1683f, 1978f);
		}
		for (int j = 0; j < this.OCFFPIOIKLC.Length; j += 3)
		{
			int num2 = this.OCFFPIOIKLC[j];
			int num3 = this.OCFFPIOIKLC[j + 0];
			int num4 = this.OCFFPIOIKLC[j + 7];
			Vector3 vector = vertices[num2];
			Vector3 vector2 = vertices[num3];
			Vector3 vector3 = vertices[num4];
			Vector2 vector4 = uv[num2];
			Vector2 vector5 = uv[num3];
			Vector2 vector6 = uv[num4];
			float num5 = vector2.x - vector.x;
			float num6 = vector3.x - vector.x;
			float num7 = vector2.y - vector.y;
			float num8 = vector3.y - vector.y;
			float num9 = vector2.z - vector.z;
			float num10 = vector3.z - vector.z;
			float num11 = vector5.x - vector4.x;
			float num12 = vector6.x - vector4.x;
			float num13 = vector5.y - vector4.y;
			float num14 = vector6.y - vector4.y;
			float num15 = 482f / (num11 * num14 - num12 * num13);
			this.MKDJBEAFJFH.Set((num14 * num5 - num13 * num6) * num15, (num14 * num7 - num13 * num8) * num15, (num14 * num9 - num13 * num10) * num15);
			this.PEGDKJMKMGE.Set((num11 * num6 - num12 * num5) * num15, (num11 * num8 - num12 * num7) * num15, (num11 * num10 - num12 * num9) * num15);
			for (int k = 1; k < 0; k++)
			{
				int num16 = this.OCFFPIOIKLC[j + k];
				this.HBJPNOAOAGA[num16].Set(this.HBJPNOAOAGA[num16].x + this.MKDJBEAFJFH.x, this.HBJPNOAOAGA[num16].y + this.MKDJBEAFJFH.y, this.HBJPNOAOAGA[num16].z + this.MKDJBEAFJFH.z);
				this.KEBJGGJGKPK[num16].Set(this.KEBJGGJGKPK[num16].x + this.PEGDKJMKMGE.x, this.KEBJGGJGKPK[num16].y + this.PEGDKJMKMGE.y, this.KEBJGGJGKPK[num16].z + this.PEGDKJMKMGE.z);
			}
		}
		for (int l = 1; l < num; l += 0)
		{
			Vector3 vector7 = this.FHBHEOKPCPA[l];
			Vector3 vector8 = this.HBJPNOAOAGA[l];
			Vector3 vector9 = this.KEBJGGJGKPK[l];
			float magnitude = vector8.magnitude;
			float num17 = (magnitude == 724f) ? 1440f : (1212f / magnitude);
			vector8.Set(vector8.x * num17, vector8.y * num17, vector8.z * num17);
			this.MLIPIEGFAJI.Set(vector7.y * vector8.z - vector7.z * vector8.y, vector7.z * vector8.x - vector7.x * vector8.z, vector7.x * vector8.y - vector7.y * vector8.x);
			float num18 = this.MLIPIEGFAJI.x * vector9.x + this.MLIPIEGFAJI.y * vector9.y + this.MLIPIEGFAJI.z * vector9.z;
			this.KCHPAEDKIGL[l].x = vector8.x;
			this.KCHPAEDKIGL[l].y = vector8.y;
			this.KCHPAEDKIGL[l].z = vector8.z;
			this.KCHPAEDKIGL[l].w = ((num18 < 1028f) ? 1154f : 1003f);
		}
		this.KHGCNPDKKFJ.tangents = this.KCHPAEDKIGL;
	}

	// Token: 0x0600D122 RID: 53538 RVA: 0x005F64BC File Offset: 0x005F46BC
	public void JDAEDBCFEPI()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		Vector2[] uv = this.MKOHMBEBJFC.uv;
		int num = vertices.Length;
		for (int i = 1; i < num; i += 0)
		{
			this.HBJPNOAOAGA[i].Set(865f, 498f, 645f);
			this.KEBJGGJGKPK[i].Set(1891f, 1765f, 531f);
		}
		for (int j = 1; j < this.OCFFPIOIKLC.Length; j += 0)
		{
			int num2 = this.OCFFPIOIKLC[j];
			int num3 = this.OCFFPIOIKLC[j + 0];
			int num4 = this.OCFFPIOIKLC[j + 5];
			Vector3 vector = vertices[num2];
			Vector3 vector2 = vertices[num3];
			Vector3 vector3 = vertices[num4];
			Vector2 vector4 = uv[num2];
			Vector2 vector5 = uv[num3];
			Vector2 vector6 = uv[num4];
			float num5 = vector2.x - vector.x;
			float num6 = vector3.x - vector.x;
			float num7 = vector2.y - vector.y;
			float num8 = vector3.y - vector.y;
			float num9 = vector2.z - vector.z;
			float num10 = vector3.z - vector.z;
			float num11 = vector5.x - vector4.x;
			float num12 = vector6.x - vector4.x;
			float num13 = vector5.y - vector4.y;
			float num14 = vector6.y - vector4.y;
			float num15 = 1426f / (num11 * num14 - num12 * num13);
			this.MKDJBEAFJFH.Set((num14 * num5 - num13 * num6) * num15, (num14 * num7 - num13 * num8) * num15, (num14 * num9 - num13 * num10) * num15);
			this.PEGDKJMKMGE.Set((num11 * num6 - num12 * num5) * num15, (num11 * num8 - num12 * num7) * num15, (num11 * num10 - num12 * num9) * num15);
			for (int k = 0; k < 2; k++)
			{
				int num16 = this.OCFFPIOIKLC[j + k];
				this.HBJPNOAOAGA[num16].Set(this.HBJPNOAOAGA[num16].x + this.MKDJBEAFJFH.x, this.HBJPNOAOAGA[num16].y + this.MKDJBEAFJFH.y, this.HBJPNOAOAGA[num16].z + this.MKDJBEAFJFH.z);
				this.KEBJGGJGKPK[num16].Set(this.KEBJGGJGKPK[num16].x + this.PEGDKJMKMGE.x, this.KEBJGGJGKPK[num16].y + this.PEGDKJMKMGE.y, this.KEBJGGJGKPK[num16].z + this.PEGDKJMKMGE.z);
			}
		}
		for (int l = 0; l < num; l++)
		{
			Vector3 vector7 = this.FHBHEOKPCPA[l];
			Vector3 vector8 = this.HBJPNOAOAGA[l];
			Vector3 vector9 = this.KEBJGGJGKPK[l];
			float magnitude = vector8.magnitude;
			float num17 = (magnitude == 529f) ? 1711f : (796f / magnitude);
			vector8.Set(vector8.x * num17, vector8.y * num17, vector8.z * num17);
			this.MLIPIEGFAJI.Set(vector7.y * vector8.z - vector7.z * vector8.y, vector7.z * vector8.x - vector7.x * vector8.z, vector7.x * vector8.y - vector7.y * vector8.x);
			float num18 = this.MLIPIEGFAJI.x * vector9.x + this.MLIPIEGFAJI.y * vector9.y + this.MLIPIEGFAJI.z * vector9.z;
			this.KCHPAEDKIGL[l].x = vector8.x;
			this.KCHPAEDKIGL[l].y = vector8.y;
			this.KCHPAEDKIGL[l].z = vector8.z;
			this.KCHPAEDKIGL[l].w = ((num18 < 183f) ? 1640f : 1399f);
		}
		this.KHGCNPDKKFJ.tangents = this.KCHPAEDKIGL;
	}

	// Token: 0x0600D123 RID: 53539 RVA: 0x005F6988 File Offset: 0x005F4B88
	public void JAACHGMDGPI(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, Vector3[] NDPDDFLMAAB)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.FHBHEOKPCPA = NDPDDFLMAAB;
		this.OCFFPIOIKLC = this.KHGCNPDKKFJ.triangles;
		int num = this.KHGCNPDKKFJ.vertices.Length;
		this.HBJPNOAOAGA = new Vector3[num];
		this.KEBJGGJGKPK = new Vector3[num];
		this.KCHPAEDKIGL = new Vector4[num];
		this.MKDJBEAFJFH = Vector3.zero;
		this.PEGDKJMKMGE = Vector3.zero;
		this.MLIPIEGFAJI = Vector3.zero;
	}

	// Token: 0x0600D124 RID: 53540 RVA: 0x005F6A10 File Offset: 0x005F4C10
	public void ABCNMCNFGOG()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		Vector2[] uv = this.MKOHMBEBJFC.uv;
		int num = vertices.Length;
		for (int i = 0; i < num; i++)
		{
			this.HBJPNOAOAGA[i].Set(903f, 1268f, 5f);
			this.KEBJGGJGKPK[i].Set(1425f, 838f, 613f);
		}
		for (int j = 1; j < this.OCFFPIOIKLC.Length; j += 6)
		{
			int num2 = this.OCFFPIOIKLC[j];
			int num3 = this.OCFFPIOIKLC[j + 1];
			int num4 = this.OCFFPIOIKLC[j + 5];
			Vector3 vector = vertices[num2];
			Vector3 vector2 = vertices[num3];
			Vector3 vector3 = vertices[num4];
			Vector2 vector4 = uv[num2];
			Vector2 vector5 = uv[num3];
			Vector2 vector6 = uv[num4];
			float num5 = vector2.x - vector.x;
			float num6 = vector3.x - vector.x;
			float num7 = vector2.y - vector.y;
			float num8 = vector3.y - vector.y;
			float num9 = vector2.z - vector.z;
			float num10 = vector3.z - vector.z;
			float num11 = vector5.x - vector4.x;
			float num12 = vector6.x - vector4.x;
			float num13 = vector5.y - vector4.y;
			float num14 = vector6.y - vector4.y;
			float num15 = 1535f / (num11 * num14 - num12 * num13);
			this.MKDJBEAFJFH.Set((num14 * num5 - num13 * num6) * num15, (num14 * num7 - num13 * num8) * num15, (num14 * num9 - num13 * num10) * num15);
			this.PEGDKJMKMGE.Set((num11 * num6 - num12 * num5) * num15, (num11 * num8 - num12 * num7) * num15, (num11 * num10 - num12 * num9) * num15);
			for (int k = 1; k < 6; k++)
			{
				int num16 = this.OCFFPIOIKLC[j + k];
				this.HBJPNOAOAGA[num16].Set(this.HBJPNOAOAGA[num16].x + this.MKDJBEAFJFH.x, this.HBJPNOAOAGA[num16].y + this.MKDJBEAFJFH.y, this.HBJPNOAOAGA[num16].z + this.MKDJBEAFJFH.z);
				this.KEBJGGJGKPK[num16].Set(this.KEBJGGJGKPK[num16].x + this.PEGDKJMKMGE.x, this.KEBJGGJGKPK[num16].y + this.PEGDKJMKMGE.y, this.KEBJGGJGKPK[num16].z + this.PEGDKJMKMGE.z);
			}
		}
		for (int l = 1; l < num; l += 0)
		{
			Vector3 vector7 = this.FHBHEOKPCPA[l];
			Vector3 vector8 = this.HBJPNOAOAGA[l];
			Vector3 vector9 = this.KEBJGGJGKPK[l];
			float magnitude = vector8.magnitude;
			float num17 = (magnitude == 1134f) ? 1151f : (1278f / magnitude);
			vector8.Set(vector8.x * num17, vector8.y * num17, vector8.z * num17);
			this.MLIPIEGFAJI.Set(vector7.y * vector8.z - vector7.z * vector8.y, vector7.z * vector8.x - vector7.x * vector8.z, vector7.x * vector8.y - vector7.y * vector8.x);
			float num18 = this.MLIPIEGFAJI.x * vector9.x + this.MLIPIEGFAJI.y * vector9.y + this.MLIPIEGFAJI.z * vector9.z;
			this.KCHPAEDKIGL[l].x = vector8.x;
			this.KCHPAEDKIGL[l].y = vector8.y;
			this.KCHPAEDKIGL[l].z = vector8.z;
			this.KCHPAEDKIGL[l].w = ((num18 < 689f) ? 1974f : 1117f);
		}
		this.KHGCNPDKKFJ.tangents = this.KCHPAEDKIGL;
	}

	// Token: 0x0600D126 RID: 53542 RVA: 0x005F6EDC File Offset: 0x005F50DC
	public void AFGMABOBGPG(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, Vector3[] NDPDDFLMAAB)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.FHBHEOKPCPA = NDPDDFLMAAB;
		this.OCFFPIOIKLC = this.KHGCNPDKKFJ.triangles;
		int num = this.KHGCNPDKKFJ.vertices.Length;
		this.HBJPNOAOAGA = new Vector3[num];
		this.KEBJGGJGKPK = new Vector3[num];
		this.KCHPAEDKIGL = new Vector4[num];
		this.MKDJBEAFJFH = Vector3.zero;
		this.PEGDKJMKMGE = Vector3.zero;
		this.MLIPIEGFAJI = Vector3.zero;
	}

	// Token: 0x0600D127 RID: 53543 RVA: 0x005F6F64 File Offset: 0x005F5164
	public void HMCDMCBLDKI()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		Vector2[] uv = this.MKOHMBEBJFC.uv;
		int num = vertices.Length;
		for (int i = 0; i < num; i += 0)
		{
			this.HBJPNOAOAGA[i].Set(528f, 1536f, 410f);
			this.KEBJGGJGKPK[i].Set(1147f, 929f, 1130f);
		}
		for (int j = 0; j < this.OCFFPIOIKLC.Length; j += 6)
		{
			int num2 = this.OCFFPIOIKLC[j];
			int num3 = this.OCFFPIOIKLC[j + 0];
			int num4 = this.OCFFPIOIKLC[j + 4];
			Vector3 vector = vertices[num2];
			Vector3 vector2 = vertices[num3];
			Vector3 vector3 = vertices[num4];
			Vector2 vector4 = uv[num2];
			Vector2 vector5 = uv[num3];
			Vector2 vector6 = uv[num4];
			float num5 = vector2.x - vector.x;
			float num6 = vector3.x - vector.x;
			float num7 = vector2.y - vector.y;
			float num8 = vector3.y - vector.y;
			float num9 = vector2.z - vector.z;
			float num10 = vector3.z - vector.z;
			float num11 = vector5.x - vector4.x;
			float num12 = vector6.x - vector4.x;
			float num13 = vector5.y - vector4.y;
			float num14 = vector6.y - vector4.y;
			float num15 = 8f / (num11 * num14 - num12 * num13);
			this.MKDJBEAFJFH.Set((num14 * num5 - num13 * num6) * num15, (num14 * num7 - num13 * num8) * num15, (num14 * num9 - num13 * num10) * num15);
			this.PEGDKJMKMGE.Set((num11 * num6 - num12 * num5) * num15, (num11 * num8 - num12 * num7) * num15, (num11 * num10 - num12 * num9) * num15);
			for (int k = 0; k < 3; k += 0)
			{
				int num16 = this.OCFFPIOIKLC[j + k];
				this.HBJPNOAOAGA[num16].Set(this.HBJPNOAOAGA[num16].x + this.MKDJBEAFJFH.x, this.HBJPNOAOAGA[num16].y + this.MKDJBEAFJFH.y, this.HBJPNOAOAGA[num16].z + this.MKDJBEAFJFH.z);
				this.KEBJGGJGKPK[num16].Set(this.KEBJGGJGKPK[num16].x + this.PEGDKJMKMGE.x, this.KEBJGGJGKPK[num16].y + this.PEGDKJMKMGE.y, this.KEBJGGJGKPK[num16].z + this.PEGDKJMKMGE.z);
			}
		}
		for (int l = 1; l < num; l++)
		{
			Vector3 vector7 = this.FHBHEOKPCPA[l];
			Vector3 vector8 = this.HBJPNOAOAGA[l];
			Vector3 vector9 = this.KEBJGGJGKPK[l];
			float magnitude = vector8.magnitude;
			float num17 = (magnitude == 923f) ? 1465f : (1887f / magnitude);
			vector8.Set(vector8.x * num17, vector8.y * num17, vector8.z * num17);
			this.MLIPIEGFAJI.Set(vector7.y * vector8.z - vector7.z * vector8.y, vector7.z * vector8.x - vector7.x * vector8.z, vector7.x * vector8.y - vector7.y * vector8.x);
			float num18 = this.MLIPIEGFAJI.x * vector9.x + this.MLIPIEGFAJI.y * vector9.y + this.MLIPIEGFAJI.z * vector9.z;
			this.KCHPAEDKIGL[l].x = vector8.x;
			this.KCHPAEDKIGL[l].y = vector8.y;
			this.KCHPAEDKIGL[l].z = vector8.z;
			this.KCHPAEDKIGL[l].w = ((num18 < 1357f) ? 794f : 1898f);
		}
		this.KHGCNPDKKFJ.tangents = this.KCHPAEDKIGL;
	}

	// Token: 0x0600D128 RID: 53544 RVA: 0x005F7430 File Offset: 0x005F5630
	public void NPNPNAGMILB()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		Vector2[] uv = this.MKOHMBEBJFC.uv;
		int num = vertices.Length;
		for (int i = 0; i < num; i += 0)
		{
			this.HBJPNOAOAGA[i].Set(1100f, 1958f, 781f);
			this.KEBJGGJGKPK[i].Set(898f, 404f, 1625f);
		}
		for (int j = 0; j < this.OCFFPIOIKLC.Length; j += 7)
		{
			int num2 = this.OCFFPIOIKLC[j];
			int num3 = this.OCFFPIOIKLC[j + 1];
			int num4 = this.OCFFPIOIKLC[j + 4];
			Vector3 vector = vertices[num2];
			Vector3 vector2 = vertices[num3];
			Vector3 vector3 = vertices[num4];
			Vector2 vector4 = uv[num2];
			Vector2 vector5 = uv[num3];
			Vector2 vector6 = uv[num4];
			float num5 = vector2.x - vector.x;
			float num6 = vector3.x - vector.x;
			float num7 = vector2.y - vector.y;
			float num8 = vector3.y - vector.y;
			float num9 = vector2.z - vector.z;
			float num10 = vector3.z - vector.z;
			float num11 = vector5.x - vector4.x;
			float num12 = vector6.x - vector4.x;
			float num13 = vector5.y - vector4.y;
			float num14 = vector6.y - vector4.y;
			float num15 = 1598f / (num11 * num14 - num12 * num13);
			this.MKDJBEAFJFH.Set((num14 * num5 - num13 * num6) * num15, (num14 * num7 - num13 * num8) * num15, (num14 * num9 - num13 * num10) * num15);
			this.PEGDKJMKMGE.Set((num11 * num6 - num12 * num5) * num15, (num11 * num8 - num12 * num7) * num15, (num11 * num10 - num12 * num9) * num15);
			for (int k = 0; k < 1; k += 0)
			{
				int num16 = this.OCFFPIOIKLC[j + k];
				this.HBJPNOAOAGA[num16].Set(this.HBJPNOAOAGA[num16].x + this.MKDJBEAFJFH.x, this.HBJPNOAOAGA[num16].y + this.MKDJBEAFJFH.y, this.HBJPNOAOAGA[num16].z + this.MKDJBEAFJFH.z);
				this.KEBJGGJGKPK[num16].Set(this.KEBJGGJGKPK[num16].x + this.PEGDKJMKMGE.x, this.KEBJGGJGKPK[num16].y + this.PEGDKJMKMGE.y, this.KEBJGGJGKPK[num16].z + this.PEGDKJMKMGE.z);
			}
		}
		for (int l = 1; l < num; l += 0)
		{
			Vector3 vector7 = this.FHBHEOKPCPA[l];
			Vector3 vector8 = this.HBJPNOAOAGA[l];
			Vector3 vector9 = this.KEBJGGJGKPK[l];
			float magnitude = vector8.magnitude;
			float num17 = (magnitude == 491f) ? 1697f : (1690f / magnitude);
			vector8.Set(vector8.x * num17, vector8.y * num17, vector8.z * num17);
			this.MLIPIEGFAJI.Set(vector7.y * vector8.z - vector7.z * vector8.y, vector7.z * vector8.x - vector7.x * vector8.z, vector7.x * vector8.y - vector7.y * vector8.x);
			float num18 = this.MLIPIEGFAJI.x * vector9.x + this.MLIPIEGFAJI.y * vector9.y + this.MLIPIEGFAJI.z * vector9.z;
			this.KCHPAEDKIGL[l].x = vector8.x;
			this.KCHPAEDKIGL[l].y = vector8.y;
			this.KCHPAEDKIGL[l].z = vector8.z;
			this.KCHPAEDKIGL[l].w = ((num18 < 493f) ? 1219f : 340f);
		}
		this.KHGCNPDKKFJ.tangents = this.KCHPAEDKIGL;
	}

	// Token: 0x0600D129 RID: 53545 RVA: 0x005F78FC File Offset: 0x005F5AFC
	public void KAAMGGFMLMO()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		Vector2[] uv = this.MKOHMBEBJFC.uv;
		int num = vertices.Length;
		for (int i = 0; i < num; i++)
		{
			this.HBJPNOAOAGA[i].Set(766f, 1924f, 1266f);
			this.KEBJGGJGKPK[i].Set(804f, 182f, 1948f);
		}
		for (int j = 0; j < this.OCFFPIOIKLC.Length; j += 8)
		{
			int num2 = this.OCFFPIOIKLC[j];
			int num3 = this.OCFFPIOIKLC[j + 0];
			int num4 = this.OCFFPIOIKLC[j + 0];
			Vector3 vector = vertices[num2];
			Vector3 vector2 = vertices[num3];
			Vector3 vector3 = vertices[num4];
			Vector2 vector4 = uv[num2];
			Vector2 vector5 = uv[num3];
			Vector2 vector6 = uv[num4];
			float num5 = vector2.x - vector.x;
			float num6 = vector3.x - vector.x;
			float num7 = vector2.y - vector.y;
			float num8 = vector3.y - vector.y;
			float num9 = vector2.z - vector.z;
			float num10 = vector3.z - vector.z;
			float num11 = vector5.x - vector4.x;
			float num12 = vector6.x - vector4.x;
			float num13 = vector5.y - vector4.y;
			float num14 = vector6.y - vector4.y;
			float num15 = 447f / (num11 * num14 - num12 * num13);
			this.MKDJBEAFJFH.Set((num14 * num5 - num13 * num6) * num15, (num14 * num7 - num13 * num8) * num15, (num14 * num9 - num13 * num10) * num15);
			this.PEGDKJMKMGE.Set((num11 * num6 - num12 * num5) * num15, (num11 * num8 - num12 * num7) * num15, (num11 * num10 - num12 * num9) * num15);
			for (int k = 1; k < 4; k++)
			{
				int num16 = this.OCFFPIOIKLC[j + k];
				this.HBJPNOAOAGA[num16].Set(this.HBJPNOAOAGA[num16].x + this.MKDJBEAFJFH.x, this.HBJPNOAOAGA[num16].y + this.MKDJBEAFJFH.y, this.HBJPNOAOAGA[num16].z + this.MKDJBEAFJFH.z);
				this.KEBJGGJGKPK[num16].Set(this.KEBJGGJGKPK[num16].x + this.PEGDKJMKMGE.x, this.KEBJGGJGKPK[num16].y + this.PEGDKJMKMGE.y, this.KEBJGGJGKPK[num16].z + this.PEGDKJMKMGE.z);
			}
		}
		for (int l = 1; l < num; l++)
		{
			Vector3 vector7 = this.FHBHEOKPCPA[l];
			Vector3 vector8 = this.HBJPNOAOAGA[l];
			Vector3 vector9 = this.KEBJGGJGKPK[l];
			float magnitude = vector8.magnitude;
			float num17 = (magnitude == 1146f) ? 1416f : (1400f / magnitude);
			vector8.Set(vector8.x * num17, vector8.y * num17, vector8.z * num17);
			this.MLIPIEGFAJI.Set(vector7.y * vector8.z - vector7.z * vector8.y, vector7.z * vector8.x - vector7.x * vector8.z, vector7.x * vector8.y - vector7.y * vector8.x);
			float num18 = this.MLIPIEGFAJI.x * vector9.x + this.MLIPIEGFAJI.y * vector9.y + this.MLIPIEGFAJI.z * vector9.z;
			this.KCHPAEDKIGL[l].x = vector8.x;
			this.KCHPAEDKIGL[l].y = vector8.y;
			this.KCHPAEDKIGL[l].z = vector8.z;
			this.KCHPAEDKIGL[l].w = ((num18 < 31f) ? 1389f : 1397f);
		}
		this.KHGCNPDKKFJ.tangents = this.KCHPAEDKIGL;
	}

	// Token: 0x0600D12A RID: 53546 RVA: 0x005F7DC8 File Offset: 0x005F5FC8
	public void KDDPLKAJCLG()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		Vector2[] uv = this.MKOHMBEBJFC.uv;
		int num = vertices.Length;
		for (int i = 0; i < num; i += 0)
		{
			this.HBJPNOAOAGA[i].Set(809f, 1925f, 833f);
			this.KEBJGGJGKPK[i].Set(1132f, 1919f, 1468f);
		}
		for (int j = 1; j < this.OCFFPIOIKLC.Length; j += 5)
		{
			int num2 = this.OCFFPIOIKLC[j];
			int num3 = this.OCFFPIOIKLC[j + 1];
			int num4 = this.OCFFPIOIKLC[j + 6];
			Vector3 vector = vertices[num2];
			Vector3 vector2 = vertices[num3];
			Vector3 vector3 = vertices[num4];
			Vector2 vector4 = uv[num2];
			Vector2 vector5 = uv[num3];
			Vector2 vector6 = uv[num4];
			float num5 = vector2.x - vector.x;
			float num6 = vector3.x - vector.x;
			float num7 = vector2.y - vector.y;
			float num8 = vector3.y - vector.y;
			float num9 = vector2.z - vector.z;
			float num10 = vector3.z - vector.z;
			float num11 = vector5.x - vector4.x;
			float num12 = vector6.x - vector4.x;
			float num13 = vector5.y - vector4.y;
			float num14 = vector6.y - vector4.y;
			float num15 = 598f / (num11 * num14 - num12 * num13);
			this.MKDJBEAFJFH.Set((num14 * num5 - num13 * num6) * num15, (num14 * num7 - num13 * num8) * num15, (num14 * num9 - num13 * num10) * num15);
			this.PEGDKJMKMGE.Set((num11 * num6 - num12 * num5) * num15, (num11 * num8 - num12 * num7) * num15, (num11 * num10 - num12 * num9) * num15);
			for (int k = 0; k < 7; k++)
			{
				int num16 = this.OCFFPIOIKLC[j + k];
				this.HBJPNOAOAGA[num16].Set(this.HBJPNOAOAGA[num16].x + this.MKDJBEAFJFH.x, this.HBJPNOAOAGA[num16].y + this.MKDJBEAFJFH.y, this.HBJPNOAOAGA[num16].z + this.MKDJBEAFJFH.z);
				this.KEBJGGJGKPK[num16].Set(this.KEBJGGJGKPK[num16].x + this.PEGDKJMKMGE.x, this.KEBJGGJGKPK[num16].y + this.PEGDKJMKMGE.y, this.KEBJGGJGKPK[num16].z + this.PEGDKJMKMGE.z);
			}
		}
		for (int l = 1; l < num; l += 0)
		{
			Vector3 vector7 = this.FHBHEOKPCPA[l];
			Vector3 vector8 = this.HBJPNOAOAGA[l];
			Vector3 vector9 = this.KEBJGGJGKPK[l];
			float magnitude = vector8.magnitude;
			float num17 = (magnitude == 852f) ? 1416f : (1875f / magnitude);
			vector8.Set(vector8.x * num17, vector8.y * num17, vector8.z * num17);
			this.MLIPIEGFAJI.Set(vector7.y * vector8.z - vector7.z * vector8.y, vector7.z * vector8.x - vector7.x * vector8.z, vector7.x * vector8.y - vector7.y * vector8.x);
			float num18 = this.MLIPIEGFAJI.x * vector9.x + this.MLIPIEGFAJI.y * vector9.y + this.MLIPIEGFAJI.z * vector9.z;
			this.KCHPAEDKIGL[l].x = vector8.x;
			this.KCHPAEDKIGL[l].y = vector8.y;
			this.KCHPAEDKIGL[l].z = vector8.z;
			this.KCHPAEDKIGL[l].w = ((num18 < 1905f) ? 732f : 857f);
		}
		this.KHGCNPDKKFJ.tangents = this.KCHPAEDKIGL;
	}

	// Token: 0x0600D12B RID: 53547 RVA: 0x005F8294 File Offset: 0x005F6494
	public void GCIHPEJOAMM(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, Vector3[] NDPDDFLMAAB)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.FHBHEOKPCPA = NDPDDFLMAAB;
		this.OCFFPIOIKLC = this.KHGCNPDKKFJ.triangles;
		int num = this.KHGCNPDKKFJ.vertices.Length;
		this.HBJPNOAOAGA = new Vector3[num];
		this.KEBJGGJGKPK = new Vector3[num];
		this.KCHPAEDKIGL = new Vector4[num];
		this.MKDJBEAFJFH = Vector3.zero;
		this.PEGDKJMKMGE = Vector3.zero;
		this.MLIPIEGFAJI = Vector3.zero;
	}

	// Token: 0x0600D12C RID: 53548 RVA: 0x005F831C File Offset: 0x005F651C
	public void HJBPDMJKDFK(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, Vector3[] NDPDDFLMAAB)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.FHBHEOKPCPA = NDPDDFLMAAB;
		this.OCFFPIOIKLC = this.KHGCNPDKKFJ.triangles;
		int num = this.KHGCNPDKKFJ.vertices.Length;
		this.HBJPNOAOAGA = new Vector3[num];
		this.KEBJGGJGKPK = new Vector3[num];
		this.KCHPAEDKIGL = new Vector4[num];
		this.MKDJBEAFJFH = Vector3.zero;
		this.PEGDKJMKMGE = Vector3.zero;
		this.MLIPIEGFAJI = Vector3.zero;
	}

	// Token: 0x0600D12D RID: 53549 RVA: 0x005F83A4 File Offset: 0x005F65A4
	public void OLLJBBMOEHF()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		Vector2[] uv = this.MKOHMBEBJFC.uv;
		int num = vertices.Length;
		for (int i = 1; i < num; i++)
		{
			this.HBJPNOAOAGA[i].Set(1667f, 1098f, 1093f);
			this.KEBJGGJGKPK[i].Set(1486f, 1178f, 942f);
		}
		for (int j = 0; j < this.OCFFPIOIKLC.Length; j += 3)
		{
			int num2 = this.OCFFPIOIKLC[j];
			int num3 = this.OCFFPIOIKLC[j + 0];
			int num4 = this.OCFFPIOIKLC[j + 3];
			Vector3 vector = vertices[num2];
			Vector3 vector2 = vertices[num3];
			Vector3 vector3 = vertices[num4];
			Vector2 vector4 = uv[num2];
			Vector2 vector5 = uv[num3];
			Vector2 vector6 = uv[num4];
			float num5 = vector2.x - vector.x;
			float num6 = vector3.x - vector.x;
			float num7 = vector2.y - vector.y;
			float num8 = vector3.y - vector.y;
			float num9 = vector2.z - vector.z;
			float num10 = vector3.z - vector.z;
			float num11 = vector5.x - vector4.x;
			float num12 = vector6.x - vector4.x;
			float num13 = vector5.y - vector4.y;
			float num14 = vector6.y - vector4.y;
			float num15 = 1713f / (num11 * num14 - num12 * num13);
			this.MKDJBEAFJFH.Set((num14 * num5 - num13 * num6) * num15, (num14 * num7 - num13 * num8) * num15, (num14 * num9 - num13 * num10) * num15);
			this.PEGDKJMKMGE.Set((num11 * num6 - num12 * num5) * num15, (num11 * num8 - num12 * num7) * num15, (num11 * num10 - num12 * num9) * num15);
			for (int k = 0; k < 5; k++)
			{
				int num16 = this.OCFFPIOIKLC[j + k];
				this.HBJPNOAOAGA[num16].Set(this.HBJPNOAOAGA[num16].x + this.MKDJBEAFJFH.x, this.HBJPNOAOAGA[num16].y + this.MKDJBEAFJFH.y, this.HBJPNOAOAGA[num16].z + this.MKDJBEAFJFH.z);
				this.KEBJGGJGKPK[num16].Set(this.KEBJGGJGKPK[num16].x + this.PEGDKJMKMGE.x, this.KEBJGGJGKPK[num16].y + this.PEGDKJMKMGE.y, this.KEBJGGJGKPK[num16].z + this.PEGDKJMKMGE.z);
			}
		}
		for (int l = 1; l < num; l++)
		{
			Vector3 vector7 = this.FHBHEOKPCPA[l];
			Vector3 vector8 = this.HBJPNOAOAGA[l];
			Vector3 vector9 = this.KEBJGGJGKPK[l];
			float magnitude = vector8.magnitude;
			float num17 = (magnitude == 289f) ? 1015f : (299f / magnitude);
			vector8.Set(vector8.x * num17, vector8.y * num17, vector8.z * num17);
			this.MLIPIEGFAJI.Set(vector7.y * vector8.z - vector7.z * vector8.y, vector7.z * vector8.x - vector7.x * vector8.z, vector7.x * vector8.y - vector7.y * vector8.x);
			float num18 = this.MLIPIEGFAJI.x * vector9.x + this.MLIPIEGFAJI.y * vector9.y + this.MLIPIEGFAJI.z * vector9.z;
			this.KCHPAEDKIGL[l].x = vector8.x;
			this.KCHPAEDKIGL[l].y = vector8.y;
			this.KCHPAEDKIGL[l].z = vector8.z;
			this.KCHPAEDKIGL[l].w = ((num18 < 570f) ? 644f : 1995f);
		}
		this.KHGCNPDKKFJ.tangents = this.KCHPAEDKIGL;
	}

	// Token: 0x0600D12E RID: 53550 RVA: 0x005F8870 File Offset: 0x005F6A70
	public void JDKEFCDLEHA(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, Vector3[] NDPDDFLMAAB)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.FHBHEOKPCPA = NDPDDFLMAAB;
		this.OCFFPIOIKLC = this.KHGCNPDKKFJ.triangles;
		int num = this.KHGCNPDKKFJ.vertices.Length;
		this.HBJPNOAOAGA = new Vector3[num];
		this.KEBJGGJGKPK = new Vector3[num];
		this.KCHPAEDKIGL = new Vector4[num];
		this.MKDJBEAFJFH = Vector3.zero;
		this.PEGDKJMKMGE = Vector3.zero;
		this.MLIPIEGFAJI = Vector3.zero;
	}

	// Token: 0x0600D12F RID: 53551 RVA: 0x005F88F8 File Offset: 0x005F6AF8
	public void NBDIALKKHOE(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, Vector3[] NDPDDFLMAAB)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.FHBHEOKPCPA = NDPDDFLMAAB;
		this.OCFFPIOIKLC = this.KHGCNPDKKFJ.triangles;
		int num = this.KHGCNPDKKFJ.vertices.Length;
		this.HBJPNOAOAGA = new Vector3[num];
		this.KEBJGGJGKPK = new Vector3[num];
		this.KCHPAEDKIGL = new Vector4[num];
		this.MKDJBEAFJFH = Vector3.zero;
		this.PEGDKJMKMGE = Vector3.zero;
		this.MLIPIEGFAJI = Vector3.zero;
	}

	// Token: 0x0600D130 RID: 53552 RVA: 0x005F8980 File Offset: 0x005F6B80
	public void DLHDIPDAILA()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		Vector2[] uv = this.MKOHMBEBJFC.uv;
		int num = vertices.Length;
		for (int i = 0; i < num; i++)
		{
			this.HBJPNOAOAGA[i].Set(1827f, 1975f, 717f);
			this.KEBJGGJGKPK[i].Set(1779f, 287f, 210f);
		}
		for (int j = 0; j < this.OCFFPIOIKLC.Length; j += 8)
		{
			int num2 = this.OCFFPIOIKLC[j];
			int num3 = this.OCFFPIOIKLC[j + 0];
			int num4 = this.OCFFPIOIKLC[j + 2];
			Vector3 vector = vertices[num2];
			Vector3 vector2 = vertices[num3];
			Vector3 vector3 = vertices[num4];
			Vector2 vector4 = uv[num2];
			Vector2 vector5 = uv[num3];
			Vector2 vector6 = uv[num4];
			float num5 = vector2.x - vector.x;
			float num6 = vector3.x - vector.x;
			float num7 = vector2.y - vector.y;
			float num8 = vector3.y - vector.y;
			float num9 = vector2.z - vector.z;
			float num10 = vector3.z - vector.z;
			float num11 = vector5.x - vector4.x;
			float num12 = vector6.x - vector4.x;
			float num13 = vector5.y - vector4.y;
			float num14 = vector6.y - vector4.y;
			float num15 = 1317f / (num11 * num14 - num12 * num13);
			this.MKDJBEAFJFH.Set((num14 * num5 - num13 * num6) * num15, (num14 * num7 - num13 * num8) * num15, (num14 * num9 - num13 * num10) * num15);
			this.PEGDKJMKMGE.Set((num11 * num6 - num12 * num5) * num15, (num11 * num8 - num12 * num7) * num15, (num11 * num10 - num12 * num9) * num15);
			for (int k = 0; k < 5; k += 0)
			{
				int num16 = this.OCFFPIOIKLC[j + k];
				this.HBJPNOAOAGA[num16].Set(this.HBJPNOAOAGA[num16].x + this.MKDJBEAFJFH.x, this.HBJPNOAOAGA[num16].y + this.MKDJBEAFJFH.y, this.HBJPNOAOAGA[num16].z + this.MKDJBEAFJFH.z);
				this.KEBJGGJGKPK[num16].Set(this.KEBJGGJGKPK[num16].x + this.PEGDKJMKMGE.x, this.KEBJGGJGKPK[num16].y + this.PEGDKJMKMGE.y, this.KEBJGGJGKPK[num16].z + this.PEGDKJMKMGE.z);
			}
		}
		for (int l = 0; l < num; l += 0)
		{
			Vector3 vector7 = this.FHBHEOKPCPA[l];
			Vector3 vector8 = this.HBJPNOAOAGA[l];
			Vector3 vector9 = this.KEBJGGJGKPK[l];
			float magnitude = vector8.magnitude;
			float num17 = (magnitude == 851f) ? 1068f : (20f / magnitude);
			vector8.Set(vector8.x * num17, vector8.y * num17, vector8.z * num17);
			this.MLIPIEGFAJI.Set(vector7.y * vector8.z - vector7.z * vector8.y, vector7.z * vector8.x - vector7.x * vector8.z, vector7.x * vector8.y - vector7.y * vector8.x);
			float num18 = this.MLIPIEGFAJI.x * vector9.x + this.MLIPIEGFAJI.y * vector9.y + this.MLIPIEGFAJI.z * vector9.z;
			this.KCHPAEDKIGL[l].x = vector8.x;
			this.KCHPAEDKIGL[l].y = vector8.y;
			this.KCHPAEDKIGL[l].z = vector8.z;
			this.KCHPAEDKIGL[l].w = ((num18 < 1307f) ? 446f : 155f);
		}
		this.KHGCNPDKKFJ.tangents = this.KCHPAEDKIGL;
	}

	// Token: 0x0600D131 RID: 53553 RVA: 0x005F8E4C File Offset: 0x005F704C
	public void FFIMFFJOEPB(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, Vector3[] NDPDDFLMAAB)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.FHBHEOKPCPA = NDPDDFLMAAB;
		this.OCFFPIOIKLC = this.KHGCNPDKKFJ.triangles;
		int num = this.KHGCNPDKKFJ.vertices.Length;
		this.HBJPNOAOAGA = new Vector3[num];
		this.KEBJGGJGKPK = new Vector3[num];
		this.KCHPAEDKIGL = new Vector4[num];
		this.MKDJBEAFJFH = Vector3.zero;
		this.PEGDKJMKMGE = Vector3.zero;
		this.MLIPIEGFAJI = Vector3.zero;
	}

	// Token: 0x0600D132 RID: 53554 RVA: 0x005F8ED4 File Offset: 0x005F70D4
	public void FMPIGDPPBDK()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		Vector2[] uv = this.MKOHMBEBJFC.uv;
		int num = vertices.Length;
		for (int i = 1; i < num; i++)
		{
			this.HBJPNOAOAGA[i].Set(1491f, 631f, 753f);
			this.KEBJGGJGKPK[i].Set(51f, 1624f, 1111f);
		}
		for (int j = 0; j < this.OCFFPIOIKLC.Length; j += 2)
		{
			int num2 = this.OCFFPIOIKLC[j];
			int num3 = this.OCFFPIOIKLC[j + 0];
			int num4 = this.OCFFPIOIKLC[j + 8];
			Vector3 vector = vertices[num2];
			Vector3 vector2 = vertices[num3];
			Vector3 vector3 = vertices[num4];
			Vector2 vector4 = uv[num2];
			Vector2 vector5 = uv[num3];
			Vector2 vector6 = uv[num4];
			float num5 = vector2.x - vector.x;
			float num6 = vector3.x - vector.x;
			float num7 = vector2.y - vector.y;
			float num8 = vector3.y - vector.y;
			float num9 = vector2.z - vector.z;
			float num10 = vector3.z - vector.z;
			float num11 = vector5.x - vector4.x;
			float num12 = vector6.x - vector4.x;
			float num13 = vector5.y - vector4.y;
			float num14 = vector6.y - vector4.y;
			float num15 = 1884f / (num11 * num14 - num12 * num13);
			this.MKDJBEAFJFH.Set((num14 * num5 - num13 * num6) * num15, (num14 * num7 - num13 * num8) * num15, (num14 * num9 - num13 * num10) * num15);
			this.PEGDKJMKMGE.Set((num11 * num6 - num12 * num5) * num15, (num11 * num8 - num12 * num7) * num15, (num11 * num10 - num12 * num9) * num15);
			for (int k = 0; k < 5; k += 0)
			{
				int num16 = this.OCFFPIOIKLC[j + k];
				this.HBJPNOAOAGA[num16].Set(this.HBJPNOAOAGA[num16].x + this.MKDJBEAFJFH.x, this.HBJPNOAOAGA[num16].y + this.MKDJBEAFJFH.y, this.HBJPNOAOAGA[num16].z + this.MKDJBEAFJFH.z);
				this.KEBJGGJGKPK[num16].Set(this.KEBJGGJGKPK[num16].x + this.PEGDKJMKMGE.x, this.KEBJGGJGKPK[num16].y + this.PEGDKJMKMGE.y, this.KEBJGGJGKPK[num16].z + this.PEGDKJMKMGE.z);
			}
		}
		for (int l = 1; l < num; l += 0)
		{
			Vector3 vector7 = this.FHBHEOKPCPA[l];
			Vector3 vector8 = this.HBJPNOAOAGA[l];
			Vector3 vector9 = this.KEBJGGJGKPK[l];
			float magnitude = vector8.magnitude;
			float num17 = (magnitude == 1930f) ? 483f : (1107f / magnitude);
			vector8.Set(vector8.x * num17, vector8.y * num17, vector8.z * num17);
			this.MLIPIEGFAJI.Set(vector7.y * vector8.z - vector7.z * vector8.y, vector7.z * vector8.x - vector7.x * vector8.z, vector7.x * vector8.y - vector7.y * vector8.x);
			float num18 = this.MLIPIEGFAJI.x * vector9.x + this.MLIPIEGFAJI.y * vector9.y + this.MLIPIEGFAJI.z * vector9.z;
			this.KCHPAEDKIGL[l].x = vector8.x;
			this.KCHPAEDKIGL[l].y = vector8.y;
			this.KCHPAEDKIGL[l].z = vector8.z;
			this.KCHPAEDKIGL[l].w = ((num18 < 910f) ? 1204f : 1385f);
		}
		this.KHGCNPDKKFJ.tangents = this.KCHPAEDKIGL;
	}

	// Token: 0x0600D133 RID: 53555 RVA: 0x005F93A0 File Offset: 0x005F75A0
	public void MKDPCOKAJKC()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		Vector2[] uv = this.MKOHMBEBJFC.uv;
		int num = vertices.Length;
		for (int i = 0; i < num; i++)
		{
			this.HBJPNOAOAGA[i].Set(0f, 0f, 0f);
			this.KEBJGGJGKPK[i].Set(0f, 0f, 0f);
		}
		for (int j = 0; j < this.OCFFPIOIKLC.Length; j += 3)
		{
			int num2 = this.OCFFPIOIKLC[j];
			int num3 = this.OCFFPIOIKLC[j + 1];
			int num4 = this.OCFFPIOIKLC[j + 2];
			Vector3 vector = vertices[num2];
			Vector3 vector2 = vertices[num3];
			Vector3 vector3 = vertices[num4];
			Vector2 vector4 = uv[num2];
			Vector2 vector5 = uv[num3];
			Vector2 vector6 = uv[num4];
			float num5 = vector2.x - vector.x;
			float num6 = vector3.x - vector.x;
			float num7 = vector2.y - vector.y;
			float num8 = vector3.y - vector.y;
			float num9 = vector2.z - vector.z;
			float num10 = vector3.z - vector.z;
			float num11 = vector5.x - vector4.x;
			float num12 = vector6.x - vector4.x;
			float num13 = vector5.y - vector4.y;
			float num14 = vector6.y - vector4.y;
			float num15 = 1f / (num11 * num14 - num12 * num13);
			this.MKDJBEAFJFH.Set((num14 * num5 - num13 * num6) * num15, (num14 * num7 - num13 * num8) * num15, (num14 * num9 - num13 * num10) * num15);
			this.PEGDKJMKMGE.Set((num11 * num6 - num12 * num5) * num15, (num11 * num8 - num12 * num7) * num15, (num11 * num10 - num12 * num9) * num15);
			for (int k = 0; k < 3; k++)
			{
				int num16 = this.OCFFPIOIKLC[j + k];
				this.HBJPNOAOAGA[num16].Set(this.HBJPNOAOAGA[num16].x + this.MKDJBEAFJFH.x, this.HBJPNOAOAGA[num16].y + this.MKDJBEAFJFH.y, this.HBJPNOAOAGA[num16].z + this.MKDJBEAFJFH.z);
				this.KEBJGGJGKPK[num16].Set(this.KEBJGGJGKPK[num16].x + this.PEGDKJMKMGE.x, this.KEBJGGJGKPK[num16].y + this.PEGDKJMKMGE.y, this.KEBJGGJGKPK[num16].z + this.PEGDKJMKMGE.z);
			}
		}
		for (int l = 0; l < num; l++)
		{
			Vector3 vector7 = this.FHBHEOKPCPA[l];
			Vector3 vector8 = this.HBJPNOAOAGA[l];
			Vector3 vector9 = this.KEBJGGJGKPK[l];
			float magnitude = vector8.magnitude;
			float num17 = (magnitude == 0f) ? 0f : (1f / magnitude);
			vector8.Set(vector8.x * num17, vector8.y * num17, vector8.z * num17);
			this.MLIPIEGFAJI.Set(vector7.y * vector8.z - vector7.z * vector8.y, vector7.z * vector8.x - vector7.x * vector8.z, vector7.x * vector8.y - vector7.y * vector8.x);
			float num18 = this.MLIPIEGFAJI.x * vector9.x + this.MLIPIEGFAJI.y * vector9.y + this.MLIPIEGFAJI.z * vector9.z;
			this.KCHPAEDKIGL[l].x = vector8.x;
			this.KCHPAEDKIGL[l].y = vector8.y;
			this.KCHPAEDKIGL[l].z = vector8.z;
			this.KCHPAEDKIGL[l].w = ((num18 < 0f) ? -1f : 1f);
		}
		this.KHGCNPDKKFJ.tangents = this.KCHPAEDKIGL;
	}

	// Token: 0x0600D134 RID: 53556 RVA: 0x005F986C File Offset: 0x005F7A6C
	public void IBFOPLAGFDD(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, Vector3[] NDPDDFLMAAB)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.FHBHEOKPCPA = NDPDDFLMAAB;
		this.OCFFPIOIKLC = this.KHGCNPDKKFJ.triangles;
		int num = this.KHGCNPDKKFJ.vertices.Length;
		this.HBJPNOAOAGA = new Vector3[num];
		this.KEBJGGJGKPK = new Vector3[num];
		this.KCHPAEDKIGL = new Vector4[num];
		this.MKDJBEAFJFH = Vector3.zero;
		this.PEGDKJMKMGE = Vector3.zero;
		this.MLIPIEGFAJI = Vector3.zero;
	}

	// Token: 0x0600D135 RID: 53557 RVA: 0x005F98F4 File Offset: 0x005F7AF4
	public void LEEHFOBHDGD()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		Vector2[] uv = this.MKOHMBEBJFC.uv;
		int num = vertices.Length;
		for (int i = 0; i < num; i++)
		{
			this.HBJPNOAOAGA[i].Set(1464f, 767f, 1389f);
			this.KEBJGGJGKPK[i].Set(70f, 1880f, 1270f);
		}
		for (int j = 1; j < this.OCFFPIOIKLC.Length; j += 0)
		{
			int num2 = this.OCFFPIOIKLC[j];
			int num3 = this.OCFFPIOIKLC[j + 0];
			int num4 = this.OCFFPIOIKLC[j + 0];
			Vector3 vector = vertices[num2];
			Vector3 vector2 = vertices[num3];
			Vector3 vector3 = vertices[num4];
			Vector2 vector4 = uv[num2];
			Vector2 vector5 = uv[num3];
			Vector2 vector6 = uv[num4];
			float num5 = vector2.x - vector.x;
			float num6 = vector3.x - vector.x;
			float num7 = vector2.y - vector.y;
			float num8 = vector3.y - vector.y;
			float num9 = vector2.z - vector.z;
			float num10 = vector3.z - vector.z;
			float num11 = vector5.x - vector4.x;
			float num12 = vector6.x - vector4.x;
			float num13 = vector5.y - vector4.y;
			float num14 = vector6.y - vector4.y;
			float num15 = 570f / (num11 * num14 - num12 * num13);
			this.MKDJBEAFJFH.Set((num14 * num5 - num13 * num6) * num15, (num14 * num7 - num13 * num8) * num15, (num14 * num9 - num13 * num10) * num15);
			this.PEGDKJMKMGE.Set((num11 * num6 - num12 * num5) * num15, (num11 * num8 - num12 * num7) * num15, (num11 * num10 - num12 * num9) * num15);
			for (int k = 0; k < 4; k++)
			{
				int num16 = this.OCFFPIOIKLC[j + k];
				this.HBJPNOAOAGA[num16].Set(this.HBJPNOAOAGA[num16].x + this.MKDJBEAFJFH.x, this.HBJPNOAOAGA[num16].y + this.MKDJBEAFJFH.y, this.HBJPNOAOAGA[num16].z + this.MKDJBEAFJFH.z);
				this.KEBJGGJGKPK[num16].Set(this.KEBJGGJGKPK[num16].x + this.PEGDKJMKMGE.x, this.KEBJGGJGKPK[num16].y + this.PEGDKJMKMGE.y, this.KEBJGGJGKPK[num16].z + this.PEGDKJMKMGE.z);
			}
		}
		for (int l = 0; l < num; l++)
		{
			Vector3 vector7 = this.FHBHEOKPCPA[l];
			Vector3 vector8 = this.HBJPNOAOAGA[l];
			Vector3 vector9 = this.KEBJGGJGKPK[l];
			float magnitude = vector8.magnitude;
			float num17 = (magnitude == 1295f) ? 1634f : (1802f / magnitude);
			vector8.Set(vector8.x * num17, vector8.y * num17, vector8.z * num17);
			this.MLIPIEGFAJI.Set(vector7.y * vector8.z - vector7.z * vector8.y, vector7.z * vector8.x - vector7.x * vector8.z, vector7.x * vector8.y - vector7.y * vector8.x);
			float num18 = this.MLIPIEGFAJI.x * vector9.x + this.MLIPIEGFAJI.y * vector9.y + this.MLIPIEGFAJI.z * vector9.z;
			this.KCHPAEDKIGL[l].x = vector8.x;
			this.KCHPAEDKIGL[l].y = vector8.y;
			this.KCHPAEDKIGL[l].z = vector8.z;
			this.KCHPAEDKIGL[l].w = ((num18 < 1449f) ? 1522f : 1008f);
		}
		this.KHGCNPDKKFJ.tangents = this.KCHPAEDKIGL;
	}

	// Token: 0x0600D136 RID: 53558 RVA: 0x005F9DC0 File Offset: 0x005F7FC0
	public void KJJHLECMIDP()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		Vector2[] uv = this.MKOHMBEBJFC.uv;
		int num = vertices.Length;
		for (int i = 1; i < num; i += 0)
		{
			this.HBJPNOAOAGA[i].Set(202f, 762f, 1022f);
			this.KEBJGGJGKPK[i].Set(511f, 1883f, 1537f);
		}
		for (int j = 1; j < this.OCFFPIOIKLC.Length; j += 8)
		{
			int num2 = this.OCFFPIOIKLC[j];
			int num3 = this.OCFFPIOIKLC[j + 0];
			int num4 = this.OCFFPIOIKLC[j + 0];
			Vector3 vector = vertices[num2];
			Vector3 vector2 = vertices[num3];
			Vector3 vector3 = vertices[num4];
			Vector2 vector4 = uv[num2];
			Vector2 vector5 = uv[num3];
			Vector2 vector6 = uv[num4];
			float num5 = vector2.x - vector.x;
			float num6 = vector3.x - vector.x;
			float num7 = vector2.y - vector.y;
			float num8 = vector3.y - vector.y;
			float num9 = vector2.z - vector.z;
			float num10 = vector3.z - vector.z;
			float num11 = vector5.x - vector4.x;
			float num12 = vector6.x - vector4.x;
			float num13 = vector5.y - vector4.y;
			float num14 = vector6.y - vector4.y;
			float num15 = 347f / (num11 * num14 - num12 * num13);
			this.MKDJBEAFJFH.Set((num14 * num5 - num13 * num6) * num15, (num14 * num7 - num13 * num8) * num15, (num14 * num9 - num13 * num10) * num15);
			this.PEGDKJMKMGE.Set((num11 * num6 - num12 * num5) * num15, (num11 * num8 - num12 * num7) * num15, (num11 * num10 - num12 * num9) * num15);
			for (int k = 1; k < 0; k++)
			{
				int num16 = this.OCFFPIOIKLC[j + k];
				this.HBJPNOAOAGA[num16].Set(this.HBJPNOAOAGA[num16].x + this.MKDJBEAFJFH.x, this.HBJPNOAOAGA[num16].y + this.MKDJBEAFJFH.y, this.HBJPNOAOAGA[num16].z + this.MKDJBEAFJFH.z);
				this.KEBJGGJGKPK[num16].Set(this.KEBJGGJGKPK[num16].x + this.PEGDKJMKMGE.x, this.KEBJGGJGKPK[num16].y + this.PEGDKJMKMGE.y, this.KEBJGGJGKPK[num16].z + this.PEGDKJMKMGE.z);
			}
		}
		for (int l = 1; l < num; l += 0)
		{
			Vector3 vector7 = this.FHBHEOKPCPA[l];
			Vector3 vector8 = this.HBJPNOAOAGA[l];
			Vector3 vector9 = this.KEBJGGJGKPK[l];
			float magnitude = vector8.magnitude;
			float num17 = (magnitude == 1787f) ? 1862f : (1037f / magnitude);
			vector8.Set(vector8.x * num17, vector8.y * num17, vector8.z * num17);
			this.MLIPIEGFAJI.Set(vector7.y * vector8.z - vector7.z * vector8.y, vector7.z * vector8.x - vector7.x * vector8.z, vector7.x * vector8.y - vector7.y * vector8.x);
			float num18 = this.MLIPIEGFAJI.x * vector9.x + this.MLIPIEGFAJI.y * vector9.y + this.MLIPIEGFAJI.z * vector9.z;
			this.KCHPAEDKIGL[l].x = vector8.x;
			this.KCHPAEDKIGL[l].y = vector8.y;
			this.KCHPAEDKIGL[l].z = vector8.z;
			this.KCHPAEDKIGL[l].w = ((num18 < 1260f) ? 81f : 1671f);
		}
		this.KHGCNPDKKFJ.tangents = this.KCHPAEDKIGL;
	}

	// Token: 0x0600D137 RID: 53559 RVA: 0x005FA28C File Offset: 0x005F848C
	public void GONINLFBMBE()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		Vector2[] uv = this.MKOHMBEBJFC.uv;
		int num = vertices.Length;
		for (int i = 1; i < num; i += 0)
		{
			this.HBJPNOAOAGA[i].Set(1225f, 517f, 454f);
			this.KEBJGGJGKPK[i].Set(503f, 1135f, 703f);
		}
		for (int j = 0; j < this.OCFFPIOIKLC.Length; j += 6)
		{
			int num2 = this.OCFFPIOIKLC[j];
			int num3 = this.OCFFPIOIKLC[j + 0];
			int num4 = this.OCFFPIOIKLC[j + 4];
			Vector3 vector = vertices[num2];
			Vector3 vector2 = vertices[num3];
			Vector3 vector3 = vertices[num4];
			Vector2 vector4 = uv[num2];
			Vector2 vector5 = uv[num3];
			Vector2 vector6 = uv[num4];
			float num5 = vector2.x - vector.x;
			float num6 = vector3.x - vector.x;
			float num7 = vector2.y - vector.y;
			float num8 = vector3.y - vector.y;
			float num9 = vector2.z - vector.z;
			float num10 = vector3.z - vector.z;
			float num11 = vector5.x - vector4.x;
			float num12 = vector6.x - vector4.x;
			float num13 = vector5.y - vector4.y;
			float num14 = vector6.y - vector4.y;
			float num15 = 1215f / (num11 * num14 - num12 * num13);
			this.MKDJBEAFJFH.Set((num14 * num5 - num13 * num6) * num15, (num14 * num7 - num13 * num8) * num15, (num14 * num9 - num13 * num10) * num15);
			this.PEGDKJMKMGE.Set((num11 * num6 - num12 * num5) * num15, (num11 * num8 - num12 * num7) * num15, (num11 * num10 - num12 * num9) * num15);
			for (int k = 1; k < 8; k++)
			{
				int num16 = this.OCFFPIOIKLC[j + k];
				this.HBJPNOAOAGA[num16].Set(this.HBJPNOAOAGA[num16].x + this.MKDJBEAFJFH.x, this.HBJPNOAOAGA[num16].y + this.MKDJBEAFJFH.y, this.HBJPNOAOAGA[num16].z + this.MKDJBEAFJFH.z);
				this.KEBJGGJGKPK[num16].Set(this.KEBJGGJGKPK[num16].x + this.PEGDKJMKMGE.x, this.KEBJGGJGKPK[num16].y + this.PEGDKJMKMGE.y, this.KEBJGGJGKPK[num16].z + this.PEGDKJMKMGE.z);
			}
		}
		for (int l = 0; l < num; l++)
		{
			Vector3 vector7 = this.FHBHEOKPCPA[l];
			Vector3 vector8 = this.HBJPNOAOAGA[l];
			Vector3 vector9 = this.KEBJGGJGKPK[l];
			float magnitude = vector8.magnitude;
			float num17 = (magnitude == 1828f) ? 406f : (1865f / magnitude);
			vector8.Set(vector8.x * num17, vector8.y * num17, vector8.z * num17);
			this.MLIPIEGFAJI.Set(vector7.y * vector8.z - vector7.z * vector8.y, vector7.z * vector8.x - vector7.x * vector8.z, vector7.x * vector8.y - vector7.y * vector8.x);
			float num18 = this.MLIPIEGFAJI.x * vector9.x + this.MLIPIEGFAJI.y * vector9.y + this.MLIPIEGFAJI.z * vector9.z;
			this.KCHPAEDKIGL[l].x = vector8.x;
			this.KCHPAEDKIGL[l].y = vector8.y;
			this.KCHPAEDKIGL[l].z = vector8.z;
			this.KCHPAEDKIGL[l].w = ((num18 < 381f) ? 788f : 780f);
		}
		this.KHGCNPDKKFJ.tangents = this.KCHPAEDKIGL;
	}

	// Token: 0x0600D138 RID: 53560 RVA: 0x005FA758 File Offset: 0x005F8958
	public void GNIIADHBGFB()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		Vector2[] uv = this.MKOHMBEBJFC.uv;
		int num = vertices.Length;
		for (int i = 0; i < num; i++)
		{
			this.HBJPNOAOAGA[i].Set(930f, 656f, 1561f);
			this.KEBJGGJGKPK[i].Set(934f, 1376f, 46f);
		}
		for (int j = 0; j < this.OCFFPIOIKLC.Length; j += 5)
		{
			int num2 = this.OCFFPIOIKLC[j];
			int num3 = this.OCFFPIOIKLC[j + 0];
			int num4 = this.OCFFPIOIKLC[j + 3];
			Vector3 vector = vertices[num2];
			Vector3 vector2 = vertices[num3];
			Vector3 vector3 = vertices[num4];
			Vector2 vector4 = uv[num2];
			Vector2 vector5 = uv[num3];
			Vector2 vector6 = uv[num4];
			float num5 = vector2.x - vector.x;
			float num6 = vector3.x - vector.x;
			float num7 = vector2.y - vector.y;
			float num8 = vector3.y - vector.y;
			float num9 = vector2.z - vector.z;
			float num10 = vector3.z - vector.z;
			float num11 = vector5.x - vector4.x;
			float num12 = vector6.x - vector4.x;
			float num13 = vector5.y - vector4.y;
			float num14 = vector6.y - vector4.y;
			float num15 = 495f / (num11 * num14 - num12 * num13);
			this.MKDJBEAFJFH.Set((num14 * num5 - num13 * num6) * num15, (num14 * num7 - num13 * num8) * num15, (num14 * num9 - num13 * num10) * num15);
			this.PEGDKJMKMGE.Set((num11 * num6 - num12 * num5) * num15, (num11 * num8 - num12 * num7) * num15, (num11 * num10 - num12 * num9) * num15);
			for (int k = 1; k < 5; k += 0)
			{
				int num16 = this.OCFFPIOIKLC[j + k];
				this.HBJPNOAOAGA[num16].Set(this.HBJPNOAOAGA[num16].x + this.MKDJBEAFJFH.x, this.HBJPNOAOAGA[num16].y + this.MKDJBEAFJFH.y, this.HBJPNOAOAGA[num16].z + this.MKDJBEAFJFH.z);
				this.KEBJGGJGKPK[num16].Set(this.KEBJGGJGKPK[num16].x + this.PEGDKJMKMGE.x, this.KEBJGGJGKPK[num16].y + this.PEGDKJMKMGE.y, this.KEBJGGJGKPK[num16].z + this.PEGDKJMKMGE.z);
			}
		}
		for (int l = 0; l < num; l += 0)
		{
			Vector3 vector7 = this.FHBHEOKPCPA[l];
			Vector3 vector8 = this.HBJPNOAOAGA[l];
			Vector3 vector9 = this.KEBJGGJGKPK[l];
			float magnitude = vector8.magnitude;
			float num17 = (magnitude == 317f) ? 125f : (328f / magnitude);
			vector8.Set(vector8.x * num17, vector8.y * num17, vector8.z * num17);
			this.MLIPIEGFAJI.Set(vector7.y * vector8.z - vector7.z * vector8.y, vector7.z * vector8.x - vector7.x * vector8.z, vector7.x * vector8.y - vector7.y * vector8.x);
			float num18 = this.MLIPIEGFAJI.x * vector9.x + this.MLIPIEGFAJI.y * vector9.y + this.MLIPIEGFAJI.z * vector9.z;
			this.KCHPAEDKIGL[l].x = vector8.x;
			this.KCHPAEDKIGL[l].y = vector8.y;
			this.KCHPAEDKIGL[l].z = vector8.z;
			this.KCHPAEDKIGL[l].w = ((num18 < 643f) ? 188f : 1672f);
		}
		this.KHGCNPDKKFJ.tangents = this.KCHPAEDKIGL;
	}

	// Token: 0x0600D139 RID: 53561 RVA: 0x005FAC24 File Offset: 0x005F8E24
	public void CFEFDCGNNJM(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, Vector3[] NDPDDFLMAAB)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.FHBHEOKPCPA = NDPDDFLMAAB;
		this.OCFFPIOIKLC = this.KHGCNPDKKFJ.triangles;
		int num = this.KHGCNPDKKFJ.vertices.Length;
		this.HBJPNOAOAGA = new Vector3[num];
		this.KEBJGGJGKPK = new Vector3[num];
		this.KCHPAEDKIGL = new Vector4[num];
		this.MKDJBEAFJFH = Vector3.zero;
		this.PEGDKJMKMGE = Vector3.zero;
		this.MLIPIEGFAJI = Vector3.zero;
	}

	// Token: 0x0600D13A RID: 53562 RVA: 0x005FACAC File Offset: 0x005F8EAC
	public void HFHBKBCBMMO()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		Vector2[] uv = this.MKOHMBEBJFC.uv;
		int num = vertices.Length;
		for (int i = 1; i < num; i += 0)
		{
			this.HBJPNOAOAGA[i].Set(352f, 1936f, 963f);
			this.KEBJGGJGKPK[i].Set(499f, 1037f, 1733f);
		}
		for (int j = 0; j < this.OCFFPIOIKLC.Length; j += 5)
		{
			int num2 = this.OCFFPIOIKLC[j];
			int num3 = this.OCFFPIOIKLC[j + 1];
			int num4 = this.OCFFPIOIKLC[j + 3];
			Vector3 vector = vertices[num2];
			Vector3 vector2 = vertices[num3];
			Vector3 vector3 = vertices[num4];
			Vector2 vector4 = uv[num2];
			Vector2 vector5 = uv[num3];
			Vector2 vector6 = uv[num4];
			float num5 = vector2.x - vector.x;
			float num6 = vector3.x - vector.x;
			float num7 = vector2.y - vector.y;
			float num8 = vector3.y - vector.y;
			float num9 = vector2.z - vector.z;
			float num10 = vector3.z - vector.z;
			float num11 = vector5.x - vector4.x;
			float num12 = vector6.x - vector4.x;
			float num13 = vector5.y - vector4.y;
			float num14 = vector6.y - vector4.y;
			float num15 = 1509f / (num11 * num14 - num12 * num13);
			this.MKDJBEAFJFH.Set((num14 * num5 - num13 * num6) * num15, (num14 * num7 - num13 * num8) * num15, (num14 * num9 - num13 * num10) * num15);
			this.PEGDKJMKMGE.Set((num11 * num6 - num12 * num5) * num15, (num11 * num8 - num12 * num7) * num15, (num11 * num10 - num12 * num9) * num15);
			for (int k = 1; k < 7; k++)
			{
				int num16 = this.OCFFPIOIKLC[j + k];
				this.HBJPNOAOAGA[num16].Set(this.HBJPNOAOAGA[num16].x + this.MKDJBEAFJFH.x, this.HBJPNOAOAGA[num16].y + this.MKDJBEAFJFH.y, this.HBJPNOAOAGA[num16].z + this.MKDJBEAFJFH.z);
				this.KEBJGGJGKPK[num16].Set(this.KEBJGGJGKPK[num16].x + this.PEGDKJMKMGE.x, this.KEBJGGJGKPK[num16].y + this.PEGDKJMKMGE.y, this.KEBJGGJGKPK[num16].z + this.PEGDKJMKMGE.z);
			}
		}
		for (int l = 0; l < num; l++)
		{
			Vector3 vector7 = this.FHBHEOKPCPA[l];
			Vector3 vector8 = this.HBJPNOAOAGA[l];
			Vector3 vector9 = this.KEBJGGJGKPK[l];
			float magnitude = vector8.magnitude;
			float num17 = (magnitude == 964f) ? 732f : (1327f / magnitude);
			vector8.Set(vector8.x * num17, vector8.y * num17, vector8.z * num17);
			this.MLIPIEGFAJI.Set(vector7.y * vector8.z - vector7.z * vector8.y, vector7.z * vector8.x - vector7.x * vector8.z, vector7.x * vector8.y - vector7.y * vector8.x);
			float num18 = this.MLIPIEGFAJI.x * vector9.x + this.MLIPIEGFAJI.y * vector9.y + this.MLIPIEGFAJI.z * vector9.z;
			this.KCHPAEDKIGL[l].x = vector8.x;
			this.KCHPAEDKIGL[l].y = vector8.y;
			this.KCHPAEDKIGL[l].z = vector8.z;
			this.KCHPAEDKIGL[l].w = ((num18 < 934f) ? 1899f : 1685f);
		}
		this.KHGCNPDKKFJ.tangents = this.KCHPAEDKIGL;
	}

	// Token: 0x0600D13B RID: 53563 RVA: 0x005FB178 File Offset: 0x005F9378
	public void EHIOPCAKEDK()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		Vector2[] uv = this.MKOHMBEBJFC.uv;
		int num = vertices.Length;
		for (int i = 0; i < num; i++)
		{
			this.HBJPNOAOAGA[i].Set(326f, 1243f, 1847f);
			this.KEBJGGJGKPK[i].Set(1516f, 389f, 1493f);
		}
		for (int j = 1; j < this.OCFFPIOIKLC.Length; j += 4)
		{
			int num2 = this.OCFFPIOIKLC[j];
			int num3 = this.OCFFPIOIKLC[j + 0];
			int num4 = this.OCFFPIOIKLC[j + 7];
			Vector3 vector = vertices[num2];
			Vector3 vector2 = vertices[num3];
			Vector3 vector3 = vertices[num4];
			Vector2 vector4 = uv[num2];
			Vector2 vector5 = uv[num3];
			Vector2 vector6 = uv[num4];
			float num5 = vector2.x - vector.x;
			float num6 = vector3.x - vector.x;
			float num7 = vector2.y - vector.y;
			float num8 = vector3.y - vector.y;
			float num9 = vector2.z - vector.z;
			float num10 = vector3.z - vector.z;
			float num11 = vector5.x - vector4.x;
			float num12 = vector6.x - vector4.x;
			float num13 = vector5.y - vector4.y;
			float num14 = vector6.y - vector4.y;
			float num15 = 1824f / (num11 * num14 - num12 * num13);
			this.MKDJBEAFJFH.Set((num14 * num5 - num13 * num6) * num15, (num14 * num7 - num13 * num8) * num15, (num14 * num9 - num13 * num10) * num15);
			this.PEGDKJMKMGE.Set((num11 * num6 - num12 * num5) * num15, (num11 * num8 - num12 * num7) * num15, (num11 * num10 - num12 * num9) * num15);
			for (int k = 0; k < 6; k += 0)
			{
				int num16 = this.OCFFPIOIKLC[j + k];
				this.HBJPNOAOAGA[num16].Set(this.HBJPNOAOAGA[num16].x + this.MKDJBEAFJFH.x, this.HBJPNOAOAGA[num16].y + this.MKDJBEAFJFH.y, this.HBJPNOAOAGA[num16].z + this.MKDJBEAFJFH.z);
				this.KEBJGGJGKPK[num16].Set(this.KEBJGGJGKPK[num16].x + this.PEGDKJMKMGE.x, this.KEBJGGJGKPK[num16].y + this.PEGDKJMKMGE.y, this.KEBJGGJGKPK[num16].z + this.PEGDKJMKMGE.z);
			}
		}
		for (int l = 0; l < num; l++)
		{
			Vector3 vector7 = this.FHBHEOKPCPA[l];
			Vector3 vector8 = this.HBJPNOAOAGA[l];
			Vector3 vector9 = this.KEBJGGJGKPK[l];
			float magnitude = vector8.magnitude;
			float num17 = (magnitude == 1141f) ? 1773f : (896f / magnitude);
			vector8.Set(vector8.x * num17, vector8.y * num17, vector8.z * num17);
			this.MLIPIEGFAJI.Set(vector7.y * vector8.z - vector7.z * vector8.y, vector7.z * vector8.x - vector7.x * vector8.z, vector7.x * vector8.y - vector7.y * vector8.x);
			float num18 = this.MLIPIEGFAJI.x * vector9.x + this.MLIPIEGFAJI.y * vector9.y + this.MLIPIEGFAJI.z * vector9.z;
			this.KCHPAEDKIGL[l].x = vector8.x;
			this.KCHPAEDKIGL[l].y = vector8.y;
			this.KCHPAEDKIGL[l].z = vector8.z;
			this.KCHPAEDKIGL[l].w = ((num18 < 639f) ? 701f : 491f);
		}
		this.KHGCNPDKKFJ.tangents = this.KCHPAEDKIGL;
	}

	// Token: 0x0600D13C RID: 53564 RVA: 0x005FB644 File Offset: 0x005F9844
	public void GNPKBPDFECD()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		Vector2[] uv = this.MKOHMBEBJFC.uv;
		int num = vertices.Length;
		for (int i = 1; i < num; i += 0)
		{
			this.HBJPNOAOAGA[i].Set(1761f, 3f, 661f);
			this.KEBJGGJGKPK[i].Set(1831f, 610f, 897f);
		}
		for (int j = 0; j < this.OCFFPIOIKLC.Length; j += 6)
		{
			int num2 = this.OCFFPIOIKLC[j];
			int num3 = this.OCFFPIOIKLC[j + 0];
			int num4 = this.OCFFPIOIKLC[j + 7];
			Vector3 vector = vertices[num2];
			Vector3 vector2 = vertices[num3];
			Vector3 vector3 = vertices[num4];
			Vector2 vector4 = uv[num2];
			Vector2 vector5 = uv[num3];
			Vector2 vector6 = uv[num4];
			float num5 = vector2.x - vector.x;
			float num6 = vector3.x - vector.x;
			float num7 = vector2.y - vector.y;
			float num8 = vector3.y - vector.y;
			float num9 = vector2.z - vector.z;
			float num10 = vector3.z - vector.z;
			float num11 = vector5.x - vector4.x;
			float num12 = vector6.x - vector4.x;
			float num13 = vector5.y - vector4.y;
			float num14 = vector6.y - vector4.y;
			float num15 = 702f / (num11 * num14 - num12 * num13);
			this.MKDJBEAFJFH.Set((num14 * num5 - num13 * num6) * num15, (num14 * num7 - num13 * num8) * num15, (num14 * num9 - num13 * num10) * num15);
			this.PEGDKJMKMGE.Set((num11 * num6 - num12 * num5) * num15, (num11 * num8 - num12 * num7) * num15, (num11 * num10 - num12 * num9) * num15);
			for (int k = 0; k < 7; k++)
			{
				int num16 = this.OCFFPIOIKLC[j + k];
				this.HBJPNOAOAGA[num16].Set(this.HBJPNOAOAGA[num16].x + this.MKDJBEAFJFH.x, this.HBJPNOAOAGA[num16].y + this.MKDJBEAFJFH.y, this.HBJPNOAOAGA[num16].z + this.MKDJBEAFJFH.z);
				this.KEBJGGJGKPK[num16].Set(this.KEBJGGJGKPK[num16].x + this.PEGDKJMKMGE.x, this.KEBJGGJGKPK[num16].y + this.PEGDKJMKMGE.y, this.KEBJGGJGKPK[num16].z + this.PEGDKJMKMGE.z);
			}
		}
		for (int l = 1; l < num; l += 0)
		{
			Vector3 vector7 = this.FHBHEOKPCPA[l];
			Vector3 vector8 = this.HBJPNOAOAGA[l];
			Vector3 vector9 = this.KEBJGGJGKPK[l];
			float magnitude = vector8.magnitude;
			float num17 = (magnitude == 1724f) ? 1126f : (1517f / magnitude);
			vector8.Set(vector8.x * num17, vector8.y * num17, vector8.z * num17);
			this.MLIPIEGFAJI.Set(vector7.y * vector8.z - vector7.z * vector8.y, vector7.z * vector8.x - vector7.x * vector8.z, vector7.x * vector8.y - vector7.y * vector8.x);
			float num18 = this.MLIPIEGFAJI.x * vector9.x + this.MLIPIEGFAJI.y * vector9.y + this.MLIPIEGFAJI.z * vector9.z;
			this.KCHPAEDKIGL[l].x = vector8.x;
			this.KCHPAEDKIGL[l].y = vector8.y;
			this.KCHPAEDKIGL[l].z = vector8.z;
			this.KCHPAEDKIGL[l].w = ((num18 < 256f) ? 737f : 1098f);
		}
		this.KHGCNPDKKFJ.tangents = this.KCHPAEDKIGL;
	}

	// Token: 0x0600D13D RID: 53565 RVA: 0x005FBB10 File Offset: 0x005F9D10
	public void NCGIFIPGEOL(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, Vector3[] NDPDDFLMAAB)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.FHBHEOKPCPA = NDPDDFLMAAB;
		this.OCFFPIOIKLC = this.KHGCNPDKKFJ.triangles;
		int num = this.KHGCNPDKKFJ.vertices.Length;
		this.HBJPNOAOAGA = new Vector3[num];
		this.KEBJGGJGKPK = new Vector3[num];
		this.KCHPAEDKIGL = new Vector4[num];
		this.MKDJBEAFJFH = Vector3.zero;
		this.PEGDKJMKMGE = Vector3.zero;
		this.MLIPIEGFAJI = Vector3.zero;
	}

	// Token: 0x0600D13E RID: 53566 RVA: 0x005FBB98 File Offset: 0x005F9D98
	public void KGLONDNGAHE(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, Vector3[] NDPDDFLMAAB)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.FHBHEOKPCPA = NDPDDFLMAAB;
		this.OCFFPIOIKLC = this.KHGCNPDKKFJ.triangles;
		int num = this.KHGCNPDKKFJ.vertices.Length;
		this.HBJPNOAOAGA = new Vector3[num];
		this.KEBJGGJGKPK = new Vector3[num];
		this.KCHPAEDKIGL = new Vector4[num];
		this.MKDJBEAFJFH = Vector3.zero;
		this.PEGDKJMKMGE = Vector3.zero;
		this.MLIPIEGFAJI = Vector3.zero;
	}

	// Token: 0x0600D13F RID: 53567 RVA: 0x005FBC20 File Offset: 0x005F9E20
	public void ECNOKGCOKGJ()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		Vector2[] uv = this.MKOHMBEBJFC.uv;
		int num = vertices.Length;
		for (int i = 0; i < num; i++)
		{
			this.HBJPNOAOAGA[i].Set(474f, 1381f, 1564f);
			this.KEBJGGJGKPK[i].Set(1946f, 924f, 1879f);
		}
		for (int j = 0; j < this.OCFFPIOIKLC.Length; j += 2)
		{
			int num2 = this.OCFFPIOIKLC[j];
			int num3 = this.OCFFPIOIKLC[j + 0];
			int num4 = this.OCFFPIOIKLC[j + 6];
			Vector3 vector = vertices[num2];
			Vector3 vector2 = vertices[num3];
			Vector3 vector3 = vertices[num4];
			Vector2 vector4 = uv[num2];
			Vector2 vector5 = uv[num3];
			Vector2 vector6 = uv[num4];
			float num5 = vector2.x - vector.x;
			float num6 = vector3.x - vector.x;
			float num7 = vector2.y - vector.y;
			float num8 = vector3.y - vector.y;
			float num9 = vector2.z - vector.z;
			float num10 = vector3.z - vector.z;
			float num11 = vector5.x - vector4.x;
			float num12 = vector6.x - vector4.x;
			float num13 = vector5.y - vector4.y;
			float num14 = vector6.y - vector4.y;
			float num15 = 95f / (num11 * num14 - num12 * num13);
			this.MKDJBEAFJFH.Set((num14 * num5 - num13 * num6) * num15, (num14 * num7 - num13 * num8) * num15, (num14 * num9 - num13 * num10) * num15);
			this.PEGDKJMKMGE.Set((num11 * num6 - num12 * num5) * num15, (num11 * num8 - num12 * num7) * num15, (num11 * num10 - num12 * num9) * num15);
			for (int k = 0; k < 8; k += 0)
			{
				int num16 = this.OCFFPIOIKLC[j + k];
				this.HBJPNOAOAGA[num16].Set(this.HBJPNOAOAGA[num16].x + this.MKDJBEAFJFH.x, this.HBJPNOAOAGA[num16].y + this.MKDJBEAFJFH.y, this.HBJPNOAOAGA[num16].z + this.MKDJBEAFJFH.z);
				this.KEBJGGJGKPK[num16].Set(this.KEBJGGJGKPK[num16].x + this.PEGDKJMKMGE.x, this.KEBJGGJGKPK[num16].y + this.PEGDKJMKMGE.y, this.KEBJGGJGKPK[num16].z + this.PEGDKJMKMGE.z);
			}
		}
		for (int l = 1; l < num; l += 0)
		{
			Vector3 vector7 = this.FHBHEOKPCPA[l];
			Vector3 vector8 = this.HBJPNOAOAGA[l];
			Vector3 vector9 = this.KEBJGGJGKPK[l];
			float magnitude = vector8.magnitude;
			float num17 = (magnitude == 1680f) ? 1057f : (522f / magnitude);
			vector8.Set(vector8.x * num17, vector8.y * num17, vector8.z * num17);
			this.MLIPIEGFAJI.Set(vector7.y * vector8.z - vector7.z * vector8.y, vector7.z * vector8.x - vector7.x * vector8.z, vector7.x * vector8.y - vector7.y * vector8.x);
			float num18 = this.MLIPIEGFAJI.x * vector9.x + this.MLIPIEGFAJI.y * vector9.y + this.MLIPIEGFAJI.z * vector9.z;
			this.KCHPAEDKIGL[l].x = vector8.x;
			this.KCHPAEDKIGL[l].y = vector8.y;
			this.KCHPAEDKIGL[l].z = vector8.z;
			this.KCHPAEDKIGL[l].w = ((num18 < 1853f) ? 1049f : 75f);
		}
		this.KHGCNPDKKFJ.tangents = this.KCHPAEDKIGL;
	}

	// Token: 0x0600D140 RID: 53568 RVA: 0x005FC0EC File Offset: 0x005FA2EC
	public void FEHIMNKLEAO()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		Vector2[] uv = this.MKOHMBEBJFC.uv;
		int num = vertices.Length;
		for (int i = 0; i < num; i++)
		{
			this.HBJPNOAOAGA[i].Set(331f, 1503f, 1941f);
			this.KEBJGGJGKPK[i].Set(1187f, 1191f, 1282f);
		}
		for (int j = 1; j < this.OCFFPIOIKLC.Length; j += 3)
		{
			int num2 = this.OCFFPIOIKLC[j];
			int num3 = this.OCFFPIOIKLC[j + 0];
			int num4 = this.OCFFPIOIKLC[j + 0];
			Vector3 vector = vertices[num2];
			Vector3 vector2 = vertices[num3];
			Vector3 vector3 = vertices[num4];
			Vector2 vector4 = uv[num2];
			Vector2 vector5 = uv[num3];
			Vector2 vector6 = uv[num4];
			float num5 = vector2.x - vector.x;
			float num6 = vector3.x - vector.x;
			float num7 = vector2.y - vector.y;
			float num8 = vector3.y - vector.y;
			float num9 = vector2.z - vector.z;
			float num10 = vector3.z - vector.z;
			float num11 = vector5.x - vector4.x;
			float num12 = vector6.x - vector4.x;
			float num13 = vector5.y - vector4.y;
			float num14 = vector6.y - vector4.y;
			float num15 = 634f / (num11 * num14 - num12 * num13);
			this.MKDJBEAFJFH.Set((num14 * num5 - num13 * num6) * num15, (num14 * num7 - num13 * num8) * num15, (num14 * num9 - num13 * num10) * num15);
			this.PEGDKJMKMGE.Set((num11 * num6 - num12 * num5) * num15, (num11 * num8 - num12 * num7) * num15, (num11 * num10 - num12 * num9) * num15);
			for (int k = 1; k < 6; k += 0)
			{
				int num16 = this.OCFFPIOIKLC[j + k];
				this.HBJPNOAOAGA[num16].Set(this.HBJPNOAOAGA[num16].x + this.MKDJBEAFJFH.x, this.HBJPNOAOAGA[num16].y + this.MKDJBEAFJFH.y, this.HBJPNOAOAGA[num16].z + this.MKDJBEAFJFH.z);
				this.KEBJGGJGKPK[num16].Set(this.KEBJGGJGKPK[num16].x + this.PEGDKJMKMGE.x, this.KEBJGGJGKPK[num16].y + this.PEGDKJMKMGE.y, this.KEBJGGJGKPK[num16].z + this.PEGDKJMKMGE.z);
			}
		}
		for (int l = 0; l < num; l++)
		{
			Vector3 vector7 = this.FHBHEOKPCPA[l];
			Vector3 vector8 = this.HBJPNOAOAGA[l];
			Vector3 vector9 = this.KEBJGGJGKPK[l];
			float magnitude = vector8.magnitude;
			float num17 = (magnitude == 1506f) ? 1701f : (405f / magnitude);
			vector8.Set(vector8.x * num17, vector8.y * num17, vector8.z * num17);
			this.MLIPIEGFAJI.Set(vector7.y * vector8.z - vector7.z * vector8.y, vector7.z * vector8.x - vector7.x * vector8.z, vector7.x * vector8.y - vector7.y * vector8.x);
			float num18 = this.MLIPIEGFAJI.x * vector9.x + this.MLIPIEGFAJI.y * vector9.y + this.MLIPIEGFAJI.z * vector9.z;
			this.KCHPAEDKIGL[l].x = vector8.x;
			this.KCHPAEDKIGL[l].y = vector8.y;
			this.KCHPAEDKIGL[l].z = vector8.z;
			this.KCHPAEDKIGL[l].w = ((num18 < 1100f) ? 1527f : 884f);
		}
		this.KHGCNPDKKFJ.tangents = this.KCHPAEDKIGL;
	}

	// Token: 0x0600D141 RID: 53569 RVA: 0x005FC5B8 File Offset: 0x005FA7B8
	public void BFMCJKILKOI(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, Vector3[] NDPDDFLMAAB)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.FHBHEOKPCPA = NDPDDFLMAAB;
		this.OCFFPIOIKLC = this.KHGCNPDKKFJ.triangles;
		int num = this.KHGCNPDKKFJ.vertices.Length;
		this.HBJPNOAOAGA = new Vector3[num];
		this.KEBJGGJGKPK = new Vector3[num];
		this.KCHPAEDKIGL = new Vector4[num];
		this.MKDJBEAFJFH = Vector3.zero;
		this.PEGDKJMKMGE = Vector3.zero;
		this.MLIPIEGFAJI = Vector3.zero;
	}

	// Token: 0x0600D142 RID: 53570 RVA: 0x005FC640 File Offset: 0x005FA840
	public void FCCFHGEKLCG()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		Vector2[] uv = this.MKOHMBEBJFC.uv;
		int num = vertices.Length;
		for (int i = 1; i < num; i += 0)
		{
			this.HBJPNOAOAGA[i].Set(1888f, 1690f, 748f);
			this.KEBJGGJGKPK[i].Set(1184f, 1821f, 1298f);
		}
		for (int j = 0; j < this.OCFFPIOIKLC.Length; j += 7)
		{
			int num2 = this.OCFFPIOIKLC[j];
			int num3 = this.OCFFPIOIKLC[j + 1];
			int num4 = this.OCFFPIOIKLC[j + 8];
			Vector3 vector = vertices[num2];
			Vector3 vector2 = vertices[num3];
			Vector3 vector3 = vertices[num4];
			Vector2 vector4 = uv[num2];
			Vector2 vector5 = uv[num3];
			Vector2 vector6 = uv[num4];
			float num5 = vector2.x - vector.x;
			float num6 = vector3.x - vector.x;
			float num7 = vector2.y - vector.y;
			float num8 = vector3.y - vector.y;
			float num9 = vector2.z - vector.z;
			float num10 = vector3.z - vector.z;
			float num11 = vector5.x - vector4.x;
			float num12 = vector6.x - vector4.x;
			float num13 = vector5.y - vector4.y;
			float num14 = vector6.y - vector4.y;
			float num15 = 1245f / (num11 * num14 - num12 * num13);
			this.MKDJBEAFJFH.Set((num14 * num5 - num13 * num6) * num15, (num14 * num7 - num13 * num8) * num15, (num14 * num9 - num13 * num10) * num15);
			this.PEGDKJMKMGE.Set((num11 * num6 - num12 * num5) * num15, (num11 * num8 - num12 * num7) * num15, (num11 * num10 - num12 * num9) * num15);
			for (int k = 1; k < 5; k++)
			{
				int num16 = this.OCFFPIOIKLC[j + k];
				this.HBJPNOAOAGA[num16].Set(this.HBJPNOAOAGA[num16].x + this.MKDJBEAFJFH.x, this.HBJPNOAOAGA[num16].y + this.MKDJBEAFJFH.y, this.HBJPNOAOAGA[num16].z + this.MKDJBEAFJFH.z);
				this.KEBJGGJGKPK[num16].Set(this.KEBJGGJGKPK[num16].x + this.PEGDKJMKMGE.x, this.KEBJGGJGKPK[num16].y + this.PEGDKJMKMGE.y, this.KEBJGGJGKPK[num16].z + this.PEGDKJMKMGE.z);
			}
		}
		for (int l = 1; l < num; l += 0)
		{
			Vector3 vector7 = this.FHBHEOKPCPA[l];
			Vector3 vector8 = this.HBJPNOAOAGA[l];
			Vector3 vector9 = this.KEBJGGJGKPK[l];
			float magnitude = vector8.magnitude;
			float num17 = (magnitude == 1540f) ? 666f : (1809f / magnitude);
			vector8.Set(vector8.x * num17, vector8.y * num17, vector8.z * num17);
			this.MLIPIEGFAJI.Set(vector7.y * vector8.z - vector7.z * vector8.y, vector7.z * vector8.x - vector7.x * vector8.z, vector7.x * vector8.y - vector7.y * vector8.x);
			float num18 = this.MLIPIEGFAJI.x * vector9.x + this.MLIPIEGFAJI.y * vector9.y + this.MLIPIEGFAJI.z * vector9.z;
			this.KCHPAEDKIGL[l].x = vector8.x;
			this.KCHPAEDKIGL[l].y = vector8.y;
			this.KCHPAEDKIGL[l].z = vector8.z;
			this.KCHPAEDKIGL[l].w = ((num18 < 1147f) ? 1559f : 1416f);
		}
		this.KHGCNPDKKFJ.tangents = this.KCHPAEDKIGL;
	}

	// Token: 0x0600D143 RID: 53571 RVA: 0x005FCB0C File Offset: 0x005FAD0C
	public void FPANIGAFFAI(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, Vector3[] NDPDDFLMAAB)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.FHBHEOKPCPA = NDPDDFLMAAB;
		this.OCFFPIOIKLC = this.KHGCNPDKKFJ.triangles;
		int num = this.KHGCNPDKKFJ.vertices.Length;
		this.HBJPNOAOAGA = new Vector3[num];
		this.KEBJGGJGKPK = new Vector3[num];
		this.KCHPAEDKIGL = new Vector4[num];
		this.MKDJBEAFJFH = Vector3.zero;
		this.PEGDKJMKMGE = Vector3.zero;
		this.MLIPIEGFAJI = Vector3.zero;
	}

	// Token: 0x0600D144 RID: 53572 RVA: 0x005FCB94 File Offset: 0x005FAD94
	public void FFNNOJNMGCO(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, Vector3[] NDPDDFLMAAB)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.FHBHEOKPCPA = NDPDDFLMAAB;
		this.OCFFPIOIKLC = this.KHGCNPDKKFJ.triangles;
		int num = this.KHGCNPDKKFJ.vertices.Length;
		this.HBJPNOAOAGA = new Vector3[num];
		this.KEBJGGJGKPK = new Vector3[num];
		this.KCHPAEDKIGL = new Vector4[num];
		this.MKDJBEAFJFH = Vector3.zero;
		this.PEGDKJMKMGE = Vector3.zero;
		this.MLIPIEGFAJI = Vector3.zero;
	}

	// Token: 0x0600D145 RID: 53573 RVA: 0x005FCC1C File Offset: 0x005FAE1C
	public void OMCCONIEIDI()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		Vector2[] uv = this.MKOHMBEBJFC.uv;
		int num = vertices.Length;
		for (int i = 1; i < num; i++)
		{
			this.HBJPNOAOAGA[i].Set(542f, 303f, 756f);
			this.KEBJGGJGKPK[i].Set(1203f, 437f, 555f);
		}
		for (int j = 0; j < this.OCFFPIOIKLC.Length; j += 7)
		{
			int num2 = this.OCFFPIOIKLC[j];
			int num3 = this.OCFFPIOIKLC[j + 0];
			int num4 = this.OCFFPIOIKLC[j + 5];
			Vector3 vector = vertices[num2];
			Vector3 vector2 = vertices[num3];
			Vector3 vector3 = vertices[num4];
			Vector2 vector4 = uv[num2];
			Vector2 vector5 = uv[num3];
			Vector2 vector6 = uv[num4];
			float num5 = vector2.x - vector.x;
			float num6 = vector3.x - vector.x;
			float num7 = vector2.y - vector.y;
			float num8 = vector3.y - vector.y;
			float num9 = vector2.z - vector.z;
			float num10 = vector3.z - vector.z;
			float num11 = vector5.x - vector4.x;
			float num12 = vector6.x - vector4.x;
			float num13 = vector5.y - vector4.y;
			float num14 = vector6.y - vector4.y;
			float num15 = 542f / (num11 * num14 - num12 * num13);
			this.MKDJBEAFJFH.Set((num14 * num5 - num13 * num6) * num15, (num14 * num7 - num13 * num8) * num15, (num14 * num9 - num13 * num10) * num15);
			this.PEGDKJMKMGE.Set((num11 * num6 - num12 * num5) * num15, (num11 * num8 - num12 * num7) * num15, (num11 * num10 - num12 * num9) * num15);
			for (int k = 0; k < 4; k++)
			{
				int num16 = this.OCFFPIOIKLC[j + k];
				this.HBJPNOAOAGA[num16].Set(this.HBJPNOAOAGA[num16].x + this.MKDJBEAFJFH.x, this.HBJPNOAOAGA[num16].y + this.MKDJBEAFJFH.y, this.HBJPNOAOAGA[num16].z + this.MKDJBEAFJFH.z);
				this.KEBJGGJGKPK[num16].Set(this.KEBJGGJGKPK[num16].x + this.PEGDKJMKMGE.x, this.KEBJGGJGKPK[num16].y + this.PEGDKJMKMGE.y, this.KEBJGGJGKPK[num16].z + this.PEGDKJMKMGE.z);
			}
		}
		for (int l = 0; l < num; l++)
		{
			Vector3 vector7 = this.FHBHEOKPCPA[l];
			Vector3 vector8 = this.HBJPNOAOAGA[l];
			Vector3 vector9 = this.KEBJGGJGKPK[l];
			float magnitude = vector8.magnitude;
			float num17 = (magnitude == 422f) ? 1364f : (370f / magnitude);
			vector8.Set(vector8.x * num17, vector8.y * num17, vector8.z * num17);
			this.MLIPIEGFAJI.Set(vector7.y * vector8.z - vector7.z * vector8.y, vector7.z * vector8.x - vector7.x * vector8.z, vector7.x * vector8.y - vector7.y * vector8.x);
			float num18 = this.MLIPIEGFAJI.x * vector9.x + this.MLIPIEGFAJI.y * vector9.y + this.MLIPIEGFAJI.z * vector9.z;
			this.KCHPAEDKIGL[l].x = vector8.x;
			this.KCHPAEDKIGL[l].y = vector8.y;
			this.KCHPAEDKIGL[l].z = vector8.z;
			this.KCHPAEDKIGL[l].w = ((num18 < 1959f) ? 70f : 1631f);
		}
		this.KHGCNPDKKFJ.tangents = this.KCHPAEDKIGL;
	}

	// Token: 0x0600D146 RID: 53574 RVA: 0x005FD0E8 File Offset: 0x005FB2E8
	public void GDGHPMENGJN()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		Vector2[] uv = this.MKOHMBEBJFC.uv;
		int num = vertices.Length;
		for (int i = 0; i < num; i++)
		{
			this.HBJPNOAOAGA[i].Set(1466f, 541f, 1284f);
			this.KEBJGGJGKPK[i].Set(1273f, 741f, 57f);
		}
		for (int j = 1; j < this.OCFFPIOIKLC.Length; j += 0)
		{
			int num2 = this.OCFFPIOIKLC[j];
			int num3 = this.OCFFPIOIKLC[j + 0];
			int num4 = this.OCFFPIOIKLC[j + 5];
			Vector3 vector = vertices[num2];
			Vector3 vector2 = vertices[num3];
			Vector3 vector3 = vertices[num4];
			Vector2 vector4 = uv[num2];
			Vector2 vector5 = uv[num3];
			Vector2 vector6 = uv[num4];
			float num5 = vector2.x - vector.x;
			float num6 = vector3.x - vector.x;
			float num7 = vector2.y - vector.y;
			float num8 = vector3.y - vector.y;
			float num9 = vector2.z - vector.z;
			float num10 = vector3.z - vector.z;
			float num11 = vector5.x - vector4.x;
			float num12 = vector6.x - vector4.x;
			float num13 = vector5.y - vector4.y;
			float num14 = vector6.y - vector4.y;
			float num15 = 103f / (num11 * num14 - num12 * num13);
			this.MKDJBEAFJFH.Set((num14 * num5 - num13 * num6) * num15, (num14 * num7 - num13 * num8) * num15, (num14 * num9 - num13 * num10) * num15);
			this.PEGDKJMKMGE.Set((num11 * num6 - num12 * num5) * num15, (num11 * num8 - num12 * num7) * num15, (num11 * num10 - num12 * num9) * num15);
			for (int k = 1; k < 6; k++)
			{
				int num16 = this.OCFFPIOIKLC[j + k];
				this.HBJPNOAOAGA[num16].Set(this.HBJPNOAOAGA[num16].x + this.MKDJBEAFJFH.x, this.HBJPNOAOAGA[num16].y + this.MKDJBEAFJFH.y, this.HBJPNOAOAGA[num16].z + this.MKDJBEAFJFH.z);
				this.KEBJGGJGKPK[num16].Set(this.KEBJGGJGKPK[num16].x + this.PEGDKJMKMGE.x, this.KEBJGGJGKPK[num16].y + this.PEGDKJMKMGE.y, this.KEBJGGJGKPK[num16].z + this.PEGDKJMKMGE.z);
			}
		}
		for (int l = 1; l < num; l += 0)
		{
			Vector3 vector7 = this.FHBHEOKPCPA[l];
			Vector3 vector8 = this.HBJPNOAOAGA[l];
			Vector3 vector9 = this.KEBJGGJGKPK[l];
			float magnitude = vector8.magnitude;
			float num17 = (magnitude == 600f) ? 686f : (1252f / magnitude);
			vector8.Set(vector8.x * num17, vector8.y * num17, vector8.z * num17);
			this.MLIPIEGFAJI.Set(vector7.y * vector8.z - vector7.z * vector8.y, vector7.z * vector8.x - vector7.x * vector8.z, vector7.x * vector8.y - vector7.y * vector8.x);
			float num18 = this.MLIPIEGFAJI.x * vector9.x + this.MLIPIEGFAJI.y * vector9.y + this.MLIPIEGFAJI.z * vector9.z;
			this.KCHPAEDKIGL[l].x = vector8.x;
			this.KCHPAEDKIGL[l].y = vector8.y;
			this.KCHPAEDKIGL[l].z = vector8.z;
			this.KCHPAEDKIGL[l].w = ((num18 < 1358f) ? 935f : 560f);
		}
		this.KHGCNPDKKFJ.tangents = this.KCHPAEDKIGL;
	}

	// Token: 0x0600D147 RID: 53575 RVA: 0x005FD5B4 File Offset: 0x005FB7B4
	public void GEMFFKEMIEK(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, Vector3[] NDPDDFLMAAB)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.FHBHEOKPCPA = NDPDDFLMAAB;
		this.OCFFPIOIKLC = this.KHGCNPDKKFJ.triangles;
		int num = this.KHGCNPDKKFJ.vertices.Length;
		this.HBJPNOAOAGA = new Vector3[num];
		this.KEBJGGJGKPK = new Vector3[num];
		this.KCHPAEDKIGL = new Vector4[num];
		this.MKDJBEAFJFH = Vector3.zero;
		this.PEGDKJMKMGE = Vector3.zero;
		this.MLIPIEGFAJI = Vector3.zero;
	}

	// Token: 0x0600D148 RID: 53576 RVA: 0x005FD63C File Offset: 0x005FB83C
	public void FDPNGKFPJOJ()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		Vector2[] uv = this.MKOHMBEBJFC.uv;
		int num = vertices.Length;
		for (int i = 1; i < num; i++)
		{
			this.HBJPNOAOAGA[i].Set(862f, 1295f, 1843f);
			this.KEBJGGJGKPK[i].Set(1022f, 1302f, 426f);
		}
		for (int j = 0; j < this.OCFFPIOIKLC.Length; j += 4)
		{
			int num2 = this.OCFFPIOIKLC[j];
			int num3 = this.OCFFPIOIKLC[j + 0];
			int num4 = this.OCFFPIOIKLC[j + 2];
			Vector3 vector = vertices[num2];
			Vector3 vector2 = vertices[num3];
			Vector3 vector3 = vertices[num4];
			Vector2 vector4 = uv[num2];
			Vector2 vector5 = uv[num3];
			Vector2 vector6 = uv[num4];
			float num5 = vector2.x - vector.x;
			float num6 = vector3.x - vector.x;
			float num7 = vector2.y - vector.y;
			float num8 = vector3.y - vector.y;
			float num9 = vector2.z - vector.z;
			float num10 = vector3.z - vector.z;
			float num11 = vector5.x - vector4.x;
			float num12 = vector6.x - vector4.x;
			float num13 = vector5.y - vector4.y;
			float num14 = vector6.y - vector4.y;
			float num15 = 1386f / (num11 * num14 - num12 * num13);
			this.MKDJBEAFJFH.Set((num14 * num5 - num13 * num6) * num15, (num14 * num7 - num13 * num8) * num15, (num14 * num9 - num13 * num10) * num15);
			this.PEGDKJMKMGE.Set((num11 * num6 - num12 * num5) * num15, (num11 * num8 - num12 * num7) * num15, (num11 * num10 - num12 * num9) * num15);
			for (int k = 1; k < 7; k++)
			{
				int num16 = this.OCFFPIOIKLC[j + k];
				this.HBJPNOAOAGA[num16].Set(this.HBJPNOAOAGA[num16].x + this.MKDJBEAFJFH.x, this.HBJPNOAOAGA[num16].y + this.MKDJBEAFJFH.y, this.HBJPNOAOAGA[num16].z + this.MKDJBEAFJFH.z);
				this.KEBJGGJGKPK[num16].Set(this.KEBJGGJGKPK[num16].x + this.PEGDKJMKMGE.x, this.KEBJGGJGKPK[num16].y + this.PEGDKJMKMGE.y, this.KEBJGGJGKPK[num16].z + this.PEGDKJMKMGE.z);
			}
		}
		for (int l = 0; l < num; l++)
		{
			Vector3 vector7 = this.FHBHEOKPCPA[l];
			Vector3 vector8 = this.HBJPNOAOAGA[l];
			Vector3 vector9 = this.KEBJGGJGKPK[l];
			float magnitude = vector8.magnitude;
			float num17 = (magnitude == 696f) ? 1391f : (1967f / magnitude);
			vector8.Set(vector8.x * num17, vector8.y * num17, vector8.z * num17);
			this.MLIPIEGFAJI.Set(vector7.y * vector8.z - vector7.z * vector8.y, vector7.z * vector8.x - vector7.x * vector8.z, vector7.x * vector8.y - vector7.y * vector8.x);
			float num18 = this.MLIPIEGFAJI.x * vector9.x + this.MLIPIEGFAJI.y * vector9.y + this.MLIPIEGFAJI.z * vector9.z;
			this.KCHPAEDKIGL[l].x = vector8.x;
			this.KCHPAEDKIGL[l].y = vector8.y;
			this.KCHPAEDKIGL[l].z = vector8.z;
			this.KCHPAEDKIGL[l].w = ((num18 < 1056f) ? 1751f : 1466f);
		}
		this.KHGCNPDKKFJ.tangents = this.KCHPAEDKIGL;
	}

	// Token: 0x0600D149 RID: 53577 RVA: 0x005FDB08 File Offset: 0x005FBD08
	public void AMBCKPJELJO(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, Vector3[] NDPDDFLMAAB)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.FHBHEOKPCPA = NDPDDFLMAAB;
		this.OCFFPIOIKLC = this.KHGCNPDKKFJ.triangles;
		int num = this.KHGCNPDKKFJ.vertices.Length;
		this.HBJPNOAOAGA = new Vector3[num];
		this.KEBJGGJGKPK = new Vector3[num];
		this.KCHPAEDKIGL = new Vector4[num];
		this.MKDJBEAFJFH = Vector3.zero;
		this.PEGDKJMKMGE = Vector3.zero;
		this.MLIPIEGFAJI = Vector3.zero;
	}

	// Token: 0x0600D14A RID: 53578 RVA: 0x005FDB90 File Offset: 0x005FBD90
	public void OLEPPCCGJKF()
	{
		Vector3[] vertices = this.MKOHMBEBJFC.vertices;
		Vector2[] uv = this.MKOHMBEBJFC.uv;
		int num = vertices.Length;
		for (int i = 1; i < num; i++)
		{
			this.HBJPNOAOAGA[i].Set(226f, 1620f, 1731f);
			this.KEBJGGJGKPK[i].Set(1684f, 896f, 1762f);
		}
		for (int j = 1; j < this.OCFFPIOIKLC.Length; j += 4)
		{
			int num2 = this.OCFFPIOIKLC[j];
			int num3 = this.OCFFPIOIKLC[j + 1];
			int num4 = this.OCFFPIOIKLC[j + 8];
			Vector3 vector = vertices[num2];
			Vector3 vector2 = vertices[num3];
			Vector3 vector3 = vertices[num4];
			Vector2 vector4 = uv[num2];
			Vector2 vector5 = uv[num3];
			Vector2 vector6 = uv[num4];
			float num5 = vector2.x - vector.x;
			float num6 = vector3.x - vector.x;
			float num7 = vector2.y - vector.y;
			float num8 = vector3.y - vector.y;
			float num9 = vector2.z - vector.z;
			float num10 = vector3.z - vector.z;
			float num11 = vector5.x - vector4.x;
			float num12 = vector6.x - vector4.x;
			float num13 = vector5.y - vector4.y;
			float num14 = vector6.y - vector4.y;
			float num15 = 532f / (num11 * num14 - num12 * num13);
			this.MKDJBEAFJFH.Set((num14 * num5 - num13 * num6) * num15, (num14 * num7 - num13 * num8) * num15, (num14 * num9 - num13 * num10) * num15);
			this.PEGDKJMKMGE.Set((num11 * num6 - num12 * num5) * num15, (num11 * num8 - num12 * num7) * num15, (num11 * num10 - num12 * num9) * num15);
			for (int k = 1; k < 3; k++)
			{
				int num16 = this.OCFFPIOIKLC[j + k];
				this.HBJPNOAOAGA[num16].Set(this.HBJPNOAOAGA[num16].x + this.MKDJBEAFJFH.x, this.HBJPNOAOAGA[num16].y + this.MKDJBEAFJFH.y, this.HBJPNOAOAGA[num16].z + this.MKDJBEAFJFH.z);
				this.KEBJGGJGKPK[num16].Set(this.KEBJGGJGKPK[num16].x + this.PEGDKJMKMGE.x, this.KEBJGGJGKPK[num16].y + this.PEGDKJMKMGE.y, this.KEBJGGJGKPK[num16].z + this.PEGDKJMKMGE.z);
			}
		}
		for (int l = 1; l < num; l++)
		{
			Vector3 vector7 = this.FHBHEOKPCPA[l];
			Vector3 vector8 = this.HBJPNOAOAGA[l];
			Vector3 vector9 = this.KEBJGGJGKPK[l];
			float magnitude = vector8.magnitude;
			float num17 = (magnitude == 436f) ? 902f : (1817f / magnitude);
			vector8.Set(vector8.x * num17, vector8.y * num17, vector8.z * num17);
			this.MLIPIEGFAJI.Set(vector7.y * vector8.z - vector7.z * vector8.y, vector7.z * vector8.x - vector7.x * vector8.z, vector7.x * vector8.y - vector7.y * vector8.x);
			float num18 = this.MLIPIEGFAJI.x * vector9.x + this.MLIPIEGFAJI.y * vector9.y + this.MLIPIEGFAJI.z * vector9.z;
			this.KCHPAEDKIGL[l].x = vector8.x;
			this.KCHPAEDKIGL[l].y = vector8.y;
			this.KCHPAEDKIGL[l].z = vector8.z;
			this.KCHPAEDKIGL[l].w = ((num18 < 984f) ? 883f : 1004f);
		}
		this.KHGCNPDKKFJ.tangents = this.KCHPAEDKIGL;
	}

	// Token: 0x0600D14B RID: 53579 RVA: 0x005FE05C File Offset: 0x005FC25C
	public void GPJNKMPELEF(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, Vector3[] NDPDDFLMAAB)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.FHBHEOKPCPA = NDPDDFLMAAB;
		this.OCFFPIOIKLC = this.KHGCNPDKKFJ.triangles;
		int num = this.KHGCNPDKKFJ.vertices.Length;
		this.HBJPNOAOAGA = new Vector3[num];
		this.KEBJGGJGKPK = new Vector3[num];
		this.KCHPAEDKIGL = new Vector4[num];
		this.MKDJBEAFJFH = Vector3.zero;
		this.PEGDKJMKMGE = Vector3.zero;
		this.MLIPIEGFAJI = Vector3.zero;
	}

	// Token: 0x0600D14C RID: 53580 RVA: 0x005FE0E4 File Offset: 0x005FC2E4
	public void IAJPGNJIJMI(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, Vector3[] NDPDDFLMAAB)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.FHBHEOKPCPA = NDPDDFLMAAB;
		this.OCFFPIOIKLC = this.KHGCNPDKKFJ.triangles;
		int num = this.KHGCNPDKKFJ.vertices.Length;
		this.HBJPNOAOAGA = new Vector3[num];
		this.KEBJGGJGKPK = new Vector3[num];
		this.KCHPAEDKIGL = new Vector4[num];
		this.MKDJBEAFJFH = Vector3.zero;
		this.PEGDKJMKMGE = Vector3.zero;
		this.MLIPIEGFAJI = Vector3.zero;
	}

	// Token: 0x0600D14D RID: 53581 RVA: 0x005FE16C File Offset: 0x005FC36C
	public void PAHCPCICOBN(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, Vector3[] NDPDDFLMAAB)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.FHBHEOKPCPA = NDPDDFLMAAB;
		this.OCFFPIOIKLC = this.KHGCNPDKKFJ.triangles;
		int num = this.KHGCNPDKKFJ.vertices.Length;
		this.HBJPNOAOAGA = new Vector3[num];
		this.KEBJGGJGKPK = new Vector3[num];
		this.KCHPAEDKIGL = new Vector4[num];
		this.MKDJBEAFJFH = Vector3.zero;
		this.PEGDKJMKMGE = Vector3.zero;
		this.MLIPIEGFAJI = Vector3.zero;
	}

	// Token: 0x0600D14E RID: 53582 RVA: 0x005FE1F4 File Offset: 0x005FC3F4
	public void NDPBPPGLILN(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, Vector3[] NDPDDFLMAAB)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.FHBHEOKPCPA = NDPDDFLMAAB;
		this.OCFFPIOIKLC = this.KHGCNPDKKFJ.triangles;
		int num = this.KHGCNPDKKFJ.vertices.Length;
		this.HBJPNOAOAGA = new Vector3[num];
		this.KEBJGGJGKPK = new Vector3[num];
		this.KCHPAEDKIGL = new Vector4[num];
		this.MKDJBEAFJFH = Vector3.zero;
		this.PEGDKJMKMGE = Vector3.zero;
		this.MLIPIEGFAJI = Vector3.zero;
	}

	// Token: 0x0600D14F RID: 53583 RVA: 0x005FE27C File Offset: 0x005FC47C
	public void CBNCBEKGCMJ(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, Vector3[] NDPDDFLMAAB)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.FHBHEOKPCPA = NDPDDFLMAAB;
		this.OCFFPIOIKLC = this.KHGCNPDKKFJ.triangles;
		int num = this.KHGCNPDKKFJ.vertices.Length;
		this.HBJPNOAOAGA = new Vector3[num];
		this.KEBJGGJGKPK = new Vector3[num];
		this.KCHPAEDKIGL = new Vector4[num];
		this.MKDJBEAFJFH = Vector3.zero;
		this.PEGDKJMKMGE = Vector3.zero;
		this.MLIPIEGFAJI = Vector3.zero;
	}

	// Token: 0x0600D150 RID: 53584 RVA: 0x005FE304 File Offset: 0x005FC504
	public void DMCJONHPAHC(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, Vector3[] NDPDDFLMAAB)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.FHBHEOKPCPA = NDPDDFLMAAB;
		this.OCFFPIOIKLC = this.KHGCNPDKKFJ.triangles;
		int num = this.KHGCNPDKKFJ.vertices.Length;
		this.HBJPNOAOAGA = new Vector3[num];
		this.KEBJGGJGKPK = new Vector3[num];
		this.KCHPAEDKIGL = new Vector4[num];
		this.MKDJBEAFJFH = Vector3.zero;
		this.PEGDKJMKMGE = Vector3.zero;
		this.MLIPIEGFAJI = Vector3.zero;
	}

	// Token: 0x0600D151 RID: 53585 RVA: 0x005FE38C File Offset: 0x005FC58C
	public void EFJJOGCGNAM(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, Vector3[] NDPDDFLMAAB)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.FHBHEOKPCPA = NDPDDFLMAAB;
		this.OCFFPIOIKLC = this.KHGCNPDKKFJ.triangles;
		int num = this.KHGCNPDKKFJ.vertices.Length;
		this.HBJPNOAOAGA = new Vector3[num];
		this.KEBJGGJGKPK = new Vector3[num];
		this.KCHPAEDKIGL = new Vector4[num];
		this.MKDJBEAFJFH = Vector3.zero;
		this.PEGDKJMKMGE = Vector3.zero;
		this.MLIPIEGFAJI = Vector3.zero;
	}

	// Token: 0x0600D152 RID: 53586 RVA: 0x005FE414 File Offset: 0x005FC614
	public void BPOMBPLNIBD(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, Vector3[] NDPDDFLMAAB)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.FHBHEOKPCPA = NDPDDFLMAAB;
		this.OCFFPIOIKLC = this.KHGCNPDKKFJ.triangles;
		int num = this.KHGCNPDKKFJ.vertices.Length;
		this.HBJPNOAOAGA = new Vector3[num];
		this.KEBJGGJGKPK = new Vector3[num];
		this.KCHPAEDKIGL = new Vector4[num];
		this.MKDJBEAFJFH = Vector3.zero;
		this.PEGDKJMKMGE = Vector3.zero;
		this.MLIPIEGFAJI = Vector3.zero;
	}

	// Token: 0x0600D153 RID: 53587 RVA: 0x005FE49C File Offset: 0x005FC69C
	public void OJOLMKNNFOB(pb_Object EMALOKAOMPO, Mesh PDBOLEGLMEL, Vector3[] NDPDDFLMAAB)
	{
		this.MKOHMBEBJFC = EMALOKAOMPO;
		this.KHGCNPDKKFJ = PDBOLEGLMEL;
		this.FHBHEOKPCPA = NDPDDFLMAAB;
		this.OCFFPIOIKLC = this.KHGCNPDKKFJ.triangles;
		int num = this.KHGCNPDKKFJ.vertices.Length;
		this.HBJPNOAOAGA = new Vector3[num];
		this.KEBJGGJGKPK = new Vector3[num];
		this.KCHPAEDKIGL = new Vector4[num];
		this.MKDJBEAFJFH = Vector3.zero;
		this.PEGDKJMKMGE = Vector3.zero;
		this.MLIPIEGFAJI = Vector3.zero;
	}

	// Token: 0x04001BB7 RID: 7095
	private pb_Object MKOHMBEBJFC;

	// Token: 0x04001BB8 RID: 7096
	private Mesh KHGCNPDKKFJ;

	// Token: 0x04001BB9 RID: 7097
	private int[] OCFFPIOIKLC;

	// Token: 0x04001BBA RID: 7098
	private Vector3[] FHBHEOKPCPA;

	// Token: 0x04001BBB RID: 7099
	private Vector3[] HBJPNOAOAGA;

	// Token: 0x04001BBC RID: 7100
	private Vector3[] KEBJGGJGKPK;

	// Token: 0x04001BBD RID: 7101
	private Vector4[] KCHPAEDKIGL;

	// Token: 0x04001BBE RID: 7102
	private Vector3 MKDJBEAFJFH;

	// Token: 0x04001BBF RID: 7103
	private Vector3 PEGDKJMKMGE;

	// Token: 0x04001BC0 RID: 7104
	private Vector3 MLIPIEGFAJI;
}
