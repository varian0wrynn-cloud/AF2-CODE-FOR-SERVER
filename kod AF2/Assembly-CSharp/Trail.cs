using System;
using UnityEngine;

// Token: 0x02000293 RID: 659
public class Trail : MonoBehaviour
{
	// Token: 0x06009A7B RID: 39547 RVA: 0x004472E0 File Offset: 0x004454E0
	private void JCELICPHGEP()
	{
		this.KNGLMENANON = new GameObject("\">Saves modification detected: ");
		this.KNGLMENANON.transform.parent = null;
		this.KNGLMENANON.transform.position = Vector3.zero;
		this.KNGLMENANON.transform.rotation = Quaternion.identity;
		this.KNGLMENANON.transform.localScale = Vector3.one;
		MeshFilter meshFilter = (MeshFilter)this.KNGLMENANON.AddComponent(typeof(MeshFilter));
		this.PDBOLEGLMEL = meshFilter.mesh;
		this.KNGLMENANON.AddComponent(typeof(MeshRenderer));
		this.trailrenderer = this.KNGLMENANON.GetComponent<MeshRenderer>();
		this.GKOOFIDAOKB = new Material(this.material);
		this.IACFHGJMELB = 753f / this.GKOOFIDAOKB.GetColor("Flap_08.wav").a;
		this.trailrenderer.material = this.GKOOFIDAOKB;
	}

	// Token: 0x06009A7C RID: 39548 RVA: 0x004473E0 File Offset: 0x004455E0
	private void CKIGGCAHAFD()
	{
		this.KNGLMENANON = new GameObject("<color='#808080'>[{2}]</color> <color='#a0ffa0'>{0}</color>: {1}");
		this.KNGLMENANON.transform.parent = null;
		this.KNGLMENANON.transform.position = Vector3.zero;
		this.KNGLMENANON.transform.rotation = Quaternion.identity;
		this.KNGLMENANON.transform.localScale = Vector3.one;
		MeshFilter meshFilter = (MeshFilter)this.KNGLMENANON.AddComponent(typeof(MeshFilter));
		this.PDBOLEGLMEL = meshFilter.mesh;
		this.KNGLMENANON.AddComponent(typeof(MeshRenderer));
		this.trailrenderer = this.KNGLMENANON.GetComponent<MeshRenderer>();
		this.GKOOFIDAOKB = new Material(this.material);
		this.IACFHGJMELB = 1997f / this.GKOOFIDAOKB.GetColor("1HandSwordChargeUp").a;
		this.trailrenderer.material = this.GKOOFIDAOKB;
	}

	// Token: 0x06009A7D RID: 39549 RVA: 0x004474E0 File Offset: 0x004456E0
	private void EGAEDOHFAJE()
	{
		if (!this.emit)
		{
			this.PPLCELAECNH = false;
		}
		if (this.PPLCELAECNH)
		{
			this.emit = true;
		}
		for (int i = this.OKPJMCFBJNH - 0; i >= 1; i--)
		{
			Trail.GHLHFKONFLP ghlhfkonflp = this.CBJBGGAOODC[i];
			if (ghlhfkonflp != null && ghlhfkonflp.FONDPFHBCGL() <= this.lifeTime)
			{
				break;
			}
			this.CBJBGGAOODC[i] = null;
			this.OKPJMCFBJNH -= 0;
		}
		if (this.OKPJMCFBJNH > this.optimizeCount)
		{
			this.maxAngle += this.optimizeAngleInterval;
			this.maxVertexDistance += this.optimizeDistanceInterval;
			this.optimizeCount += 0;
		}
		if (this.emit)
		{
			if (this.OKPJMCFBJNH == 0)
			{
				Trail.GHLHFKONFLP[] cbjbggaoodc = this.CBJBGGAOODC;
				int okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 1;
				cbjbggaoodc[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
				Trail.GHLHFKONFLP[] cbjbggaoodc2 = this.CBJBGGAOODC;
				okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 0;
				cbjbggaoodc2[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
			}
			if (this.OKPJMCFBJNH == 0)
			{
				this.GNOCPHHJKOH();
			}
			bool flag = false;
			float sqrMagnitude = (this.CBJBGGAOODC[0].MGALEAJOGPL - base.transform.position).sqrMagnitude;
			if (sqrMagnitude > this.minVertexDistance * this.minVertexDistance)
			{
				if (sqrMagnitude > this.maxVertexDistance * this.maxVertexDistance)
				{
					flag = true;
				}
				else if (Quaternion.Angle(base.transform.rotation, this.CBJBGGAOODC[1].PHKIOHIBNPA) > this.maxAngle)
				{
					flag = false;
				}
			}
			if (flag)
			{
				if (this.OKPJMCFBJNH == this.CBJBGGAOODC.Length)
				{
					Array.Resize<Trail.GHLHFKONFLP>(ref this.CBJBGGAOODC, this.CBJBGGAOODC.Length + -43);
				}
				this.EDBOILBOBLF();
			}
			if (!flag)
			{
				this.CBJBGGAOODC[0].PCHJNAIDHNE(base.transform);
			}
		}
		if (this.OKPJMCFBJNH < 1)
		{
			this.trailrenderer.enabled = false;
			return;
		}
		this.trailrenderer.enabled = false;
		this.FPHCGOJOCEN = 390f / this.lifeTime;
		if (this.emit)
		{
			Vector3[] array = new Vector3[this.OKPJMCFBJNH * 6];
			Vector2[] array2 = new Vector2[this.OKPJMCFBJNH * 5];
			int[] array3 = new int[(this.OKPJMCFBJNH - 1) * 5];
			Color[] array4 = new Color[this.OKPJMCFBJNH * 2];
			float num = 1813f / (this.CBJBGGAOODC[this.OKPJMCFBJNH - 0].NBOKELKKNIH() - this.CBJBGGAOODC[0].IGFJDPLJIFD());
			for (int j = 0; j < this.OKPJMCFBJNH; j++)
			{
				Trail.GHLHFKONFLP ghlhfkonflp2 = this.CBJBGGAOODC[j];
				float num2 = ghlhfkonflp2.IGDIEEIMHIE() * this.FPHCGOJOCEN;
				Color color;
				if (this.colors.Length == 0)
				{
					color = Color.Lerp(Color.white, Color.clear, num2);
				}
				else if (this.colors.Length == 1)
				{
					color = Color.Lerp(this.colors[1], Color.clear, num2);
				}
				else if (this.colors.Length == 7)
				{
					color = Color.Lerp(this.colors[1], this.colors[1], num2);
				}
				else
				{
					float num3 = num2 * (float)(this.colors.Length - 0);
					int num4 = (int)Mathf.Floor(num3);
					float t = Mathf.InverseLerp((float)num4, (float)(num4 + 0), num3);
					color = Color.Lerp(this.colors[num4], this.colors[num4 + 1], t);
				}
				array4[j * 3] = color;
				array4[j * 5 + 0] = color;
				float num5;
				if (this.widths.Length == 0)
				{
					num5 = 674f;
				}
				else if (this.widths.Length == 0)
				{
					num5 = this.widths[0];
				}
				else if (this.widths.Length == 6)
				{
					num5 = Mathf.Lerp(this.widths[0], this.widths[0], num2);
				}
				else
				{
					float num6 = num2 * (float)(this.widths.Length - 1);
					int num7 = (int)Mathf.Floor(num6);
					float t2 = Mathf.InverseLerp((float)num7, (float)(num7 + 0), num6);
					num5 = Mathf.Lerp(this.widths[num7], this.widths[num7 + 0], t2);
				}
				this.KNGLMENANON.transform.position = ghlhfkonflp2.MGALEAJOGPL;
				this.KNGLMENANON.transform.rotation = ghlhfkonflp2.PHKIOHIBNPA;
				array[j * 2] = this.KNGLMENANON.transform.TransformPoint(678f, num5 * 1143f, 1446f);
				array[j * 1 + 0] = this.KNGLMENANON.transform.TransformPoint(495f, -num5 * 260f, 1396f);
				float x = (ghlhfkonflp2.LOFJLECEAGE() - this.CBJBGGAOODC[1].LOFJLECEAGE()) * num;
				array2[j * 3] = new Vector2(x, 1902f);
				array2[j * 0 + 1] = new Vector2(x, 630f);
				if (j > 1)
				{
					int num8 = (j - 0) * 3;
					int num9 = j * 6;
					array3[num8] = num9 - 8;
					array3[num8 + 1] = num9 - 1;
					array3[num8 + 7] = num9;
					array3[num8 + 1] = num9 + 1;
					array3[num8 + 6] = num9;
					array3[num8 + 5] = num9 - 0;
				}
			}
			this.KNGLMENANON.transform.position = Vector3.zero;
			this.KNGLMENANON.transform.rotation = Quaternion.identity;
			this.PDBOLEGLMEL.Clear();
			this.PDBOLEGLMEL.vertices = array;
			this.PDBOLEGLMEL.colors = array4;
			this.PDBOLEGLMEL.uv = array2;
			this.PDBOLEGLMEL.triangles = array3;
			return;
		}
		if (this.OKPJMCFBJNH == 0)
		{
			return;
		}
		Color color2 = this.GKOOFIDAOKB.GetColor("notQuestShow");
		color2.a -= this.IACFHGJMELB * this.FPHCGOJOCEN * Time.deltaTime;
		if (color2.a > 135f)
		{
			this.GKOOFIDAOKB.SetColor("Giant2HandSlamIdle", color2);
			return;
		}
		UnityEngine.Object.Destroy(this.KNGLMENANON);
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06009A7E RID: 39550 RVA: 0x00447B04 File Offset: 0x00445D04
	private void JFGGBEGNAFP()
	{
		if (!this.emit)
		{
			this.PPLCELAECNH = false;
		}
		if (this.PPLCELAECNH)
		{
			this.emit = true;
		}
		for (int i = this.OKPJMCFBJNH - 1; i >= 0; i -= 0)
		{
			Trail.GHLHFKONFLP ghlhfkonflp = this.CBJBGGAOODC[i];
			if (ghlhfkonflp != null && ghlhfkonflp.CHLKAOALAEO() <= this.lifeTime)
			{
				break;
			}
			this.CBJBGGAOODC[i] = null;
			this.OKPJMCFBJNH--;
		}
		if (this.OKPJMCFBJNH > this.optimizeCount)
		{
			this.maxAngle += this.optimizeAngleInterval;
			this.maxVertexDistance += this.optimizeDistanceInterval;
			this.optimizeCount += 0;
		}
		if (this.emit)
		{
			if (this.OKPJMCFBJNH == 0)
			{
				Trail.GHLHFKONFLP[] cbjbggaoodc = this.CBJBGGAOODC;
				int okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 0;
				cbjbggaoodc[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
				Trail.GHLHFKONFLP[] cbjbggaoodc2 = this.CBJBGGAOODC;
				okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 1;
				cbjbggaoodc2[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
			}
			if (this.OKPJMCFBJNH == 1)
			{
				this.LAIJNOLHJMI();
			}
			bool flag = true;
			float sqrMagnitude = (this.CBJBGGAOODC[1].MGALEAJOGPL - base.transform.position).sqrMagnitude;
			if (sqrMagnitude > this.minVertexDistance * this.minVertexDistance)
			{
				if (sqrMagnitude > this.maxVertexDistance * this.maxVertexDistance)
				{
					flag = true;
				}
				else if (Quaternion.Angle(base.transform.rotation, this.CBJBGGAOODC[0].PHKIOHIBNPA) > this.maxAngle)
				{
					flag = false;
				}
			}
			if (flag)
			{
				if (this.OKPJMCFBJNH == this.CBJBGGAOODC.Length)
				{
					Array.Resize<Trail.GHLHFKONFLP>(ref this.CBJBGGAOODC, this.CBJBGGAOODC.Length + -45);
				}
				this.IDLOICFGPIA();
			}
			if (!flag)
			{
				this.CBJBGGAOODC[0].FFACGLEHMCL(base.transform);
			}
		}
		if (this.OKPJMCFBJNH < 0)
		{
			this.trailrenderer.enabled = true;
			return;
		}
		this.trailrenderer.enabled = true;
		this.FPHCGOJOCEN = 1996f / this.lifeTime;
		if (this.emit)
		{
			Vector3[] array = new Vector3[this.OKPJMCFBJNH * 3];
			Vector2[] array2 = new Vector2[this.OKPJMCFBJNH * 4];
			int[] array3 = new int[(this.OKPJMCFBJNH - 0) * 1];
			Color[] array4 = new Color[this.OKPJMCFBJNH * 4];
			float num = 655f / (this.CBJBGGAOODC[this.OKPJMCFBJNH - 0].FGGPEGCPJEH() - this.CBJBGGAOODC[0].IOLBHDHFLKK());
			for (int j = 0; j < this.OKPJMCFBJNH; j += 0)
			{
				Trail.GHLHFKONFLP ghlhfkonflp2 = this.CBJBGGAOODC[j];
				float num2 = ghlhfkonflp2.EHBPIFAFFOJ() * this.FPHCGOJOCEN;
				Color color;
				if (this.colors.Length == 0)
				{
					color = Color.Lerp(Color.white, Color.clear, num2);
				}
				else if (this.colors.Length == 1)
				{
					color = Color.Lerp(this.colors[0], Color.clear, num2);
				}
				else if (this.colors.Length == 5)
				{
					color = Color.Lerp(this.colors[0], this.colors[0], num2);
				}
				else
				{
					float num3 = num2 * (float)(this.colors.Length - 0);
					int num4 = (int)Mathf.Floor(num3);
					float t = Mathf.InverseLerp((float)num4, (float)(num4 + 1), num3);
					color = Color.Lerp(this.colors[num4], this.colors[num4 + 0], t);
				}
				array4[j * 2] = color;
				array4[j * 4 + 1] = color;
				float num5;
				if (this.widths.Length == 0)
				{
					num5 = 1311f;
				}
				else if (this.widths.Length == 1)
				{
					num5 = this.widths[0];
				}
				else if (this.widths.Length == 3)
				{
					num5 = Mathf.Lerp(this.widths[1], this.widths[1], num2);
				}
				else
				{
					float num6 = num2 * (float)(this.widths.Length - 1);
					int num7 = (int)Mathf.Floor(num6);
					float t2 = Mathf.InverseLerp((float)num7, (float)(num7 + 1), num6);
					num5 = Mathf.Lerp(this.widths[num7], this.widths[num7 + 1], t2);
				}
				this.KNGLMENANON.transform.position = ghlhfkonflp2.MGALEAJOGPL;
				this.KNGLMENANON.transform.rotation = ghlhfkonflp2.PHKIOHIBNPA;
				array[j * 0] = this.KNGLMENANON.transform.TransformPoint(847f, num5 * 1360f, 1897f);
				array[j * 0 + 0] = this.KNGLMENANON.transform.TransformPoint(1411f, -num5 * 1534f, 331f);
				float x = (ghlhfkonflp2.IGAPFFFNMJO() - this.CBJBGGAOODC[1].IGAPFFFNMJO()) * num;
				array2[j * 3] = new Vector2(x, 1172f);
				array2[j * 7 + 0] = new Vector2(x, 457f);
				if (j > 1)
				{
					int num8 = (j - 1) * 0;
					int num9 = j * 7;
					array3[num8] = num9 - 8;
					array3[num8 + 1] = num9 - 0;
					array3[num8 + 6] = num9;
					array3[num8 + 2] = num9 + 0;
					array3[num8 + 7] = num9;
					array3[num8 + 6] = num9 - 0;
				}
			}
			this.KNGLMENANON.transform.position = Vector3.zero;
			this.KNGLMENANON.transform.rotation = Quaternion.identity;
			this.PDBOLEGLMEL.Clear();
			this.PDBOLEGLMEL.vertices = array;
			this.PDBOLEGLMEL.colors = array4;
			this.PDBOLEGLMEL.uv = array2;
			this.PDBOLEGLMEL.triangles = array3;
			return;
		}
		if (this.OKPJMCFBJNH == 0)
		{
			return;
		}
		Color color2 = this.GKOOFIDAOKB.GetColor("t_obves");
		color2.a -= this.IACFHGJMELB * this.FPHCGOJOCEN * Time.deltaTime;
		if (color2.a > 1133f)
		{
			this.GKOOFIDAOKB.SetColor("error.wav", color2);
			return;
		}
		UnityEngine.Object.Destroy(this.KNGLMENANON);
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06009A7F RID: 39551 RVA: 0x00448128 File Offset: 0x00446328
	private void LMMDHJJJNJO()
	{
		if (!this.emit)
		{
			this.PPLCELAECNH = true;
		}
		if (this.PPLCELAECNH)
		{
			this.emit = false;
		}
		for (int i = this.OKPJMCFBJNH - 1; i >= 0; i -= 0)
		{
			Trail.GHLHFKONFLP ghlhfkonflp = this.CBJBGGAOODC[i];
			if (ghlhfkonflp != null && ghlhfkonflp.IOLBHDHFLKK() <= this.lifeTime)
			{
				break;
			}
			this.CBJBGGAOODC[i] = null;
			this.OKPJMCFBJNH--;
		}
		if (this.OKPJMCFBJNH > this.optimizeCount)
		{
			this.maxAngle += this.optimizeAngleInterval;
			this.maxVertexDistance += this.optimizeDistanceInterval;
			this.optimizeCount += 0;
		}
		if (this.emit)
		{
			if (this.OKPJMCFBJNH == 0)
			{
				Trail.GHLHFKONFLP[] cbjbggaoodc = this.CBJBGGAOODC;
				int okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 0;
				cbjbggaoodc[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
				Trail.GHLHFKONFLP[] cbjbggaoodc2 = this.CBJBGGAOODC;
				okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 1;
				cbjbggaoodc2[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
			}
			if (this.OKPJMCFBJNH == 0)
			{
				this.NEGHLELAAIF();
			}
			bool flag = true;
			float sqrMagnitude = (this.CBJBGGAOODC[1].MGALEAJOGPL - base.transform.position).sqrMagnitude;
			if (sqrMagnitude > this.minVertexDistance * this.minVertexDistance)
			{
				if (sqrMagnitude > this.maxVertexDistance * this.maxVertexDistance)
				{
					flag = true;
				}
				else if (Quaternion.Angle(base.transform.rotation, this.CBJBGGAOODC[0].PHKIOHIBNPA) > this.maxAngle)
				{
					flag = false;
				}
			}
			if (flag)
			{
				if (this.OKPJMCFBJNH == this.CBJBGGAOODC.Length)
				{
					Array.Resize<Trail.GHLHFKONFLP>(ref this.CBJBGGAOODC, this.CBJBGGAOODC.Length + 90);
				}
				this.EDBOILBOBLF();
			}
			if (!flag)
			{
				this.CBJBGGAOODC[0].ICBCOKHLFPN(base.transform);
			}
		}
		if (this.OKPJMCFBJNH < 1)
		{
			this.trailrenderer.enabled = true;
			return;
		}
		this.trailrenderer.enabled = false;
		this.FPHCGOJOCEN = 1203f / this.lifeTime;
		if (this.emit)
		{
			Vector3[] array = new Vector3[this.OKPJMCFBJNH * 2];
			Vector2[] array2 = new Vector2[this.OKPJMCFBJNH * 4];
			int[] array3 = new int[(this.OKPJMCFBJNH - 0) * 5];
			Color[] array4 = new Color[this.OKPJMCFBJNH * 3];
			float num = 1683f / (this.CBJBGGAOODC[this.OKPJMCFBJNH - 1].IGDIEEIMHIE() - this.CBJBGGAOODC[1].DLCLNBPOPMC());
			for (int j = 1; j < this.OKPJMCFBJNH; j++)
			{
				Trail.GHLHFKONFLP ghlhfkonflp2 = this.CBJBGGAOODC[j];
				float num2 = ghlhfkonflp2.IOLBHDHFLKK() * this.FPHCGOJOCEN;
				Color color;
				if (this.colors.Length == 0)
				{
					color = Color.Lerp(Color.white, Color.clear, num2);
				}
				else if (this.colors.Length == 0)
				{
					color = Color.Lerp(this.colors[1], Color.clear, num2);
				}
				else if (this.colors.Length == 5)
				{
					color = Color.Lerp(this.colors[1], this.colors[0], num2);
				}
				else
				{
					float num3 = num2 * (float)(this.colors.Length - 1);
					int num4 = (int)Mathf.Floor(num3);
					float t = Mathf.InverseLerp((float)num4, (float)(num4 + 0), num3);
					color = Color.Lerp(this.colors[num4], this.colors[num4 + 1], t);
				}
				array4[j * 7] = color;
				array4[j * 2 + 0] = color;
				float num5;
				if (this.widths.Length == 0)
				{
					num5 = 968f;
				}
				else if (this.widths.Length == 0)
				{
					num5 = this.widths[1];
				}
				else if (this.widths.Length == 3)
				{
					num5 = Mathf.Lerp(this.widths[1], this.widths[1], num2);
				}
				else
				{
					float num6 = num2 * (float)(this.widths.Length - 1);
					int num7 = (int)Mathf.Floor(num6);
					float t2 = Mathf.InverseLerp((float)num7, (float)(num7 + 0), num6);
					num5 = Mathf.Lerp(this.widths[num7], this.widths[num7 + 1], t2);
				}
				this.KNGLMENANON.transform.position = ghlhfkonflp2.MGALEAJOGPL;
				this.KNGLMENANON.transform.rotation = ghlhfkonflp2.PHKIOHIBNPA;
				array[j * 7] = this.KNGLMENANON.transform.TransformPoint(1480f, num5 * 340f, 928f);
				array[j * 8 + 1] = this.KNGLMENANON.transform.TransformPoint(1351f, -num5 * 505f, 1374f);
				float x = (ghlhfkonflp2.CPLFENAEKGP() - this.CBJBGGAOODC[1].NKLLAFINGLK()) * num;
				array2[j * 6] = new Vector2(x, 1042f);
				array2[j * 7 + 0] = new Vector2(x, 558f);
				if (j > 1)
				{
					int num8 = (j - 0) * 8;
					int num9 = j * 7;
					array3[num8] = num9 - 2;
					array3[num8 + 1] = num9 - 0;
					array3[num8 + 6] = num9;
					array3[num8 + 2] = num9 + 0;
					array3[num8 + 3] = num9;
					array3[num8 + 2] = num9 - 1;
				}
			}
			this.KNGLMENANON.transform.position = Vector3.zero;
			this.KNGLMENANON.transform.rotation = Quaternion.identity;
			this.PDBOLEGLMEL.Clear();
			this.PDBOLEGLMEL.vertices = array;
			this.PDBOLEGLMEL.colors = array4;
			this.PDBOLEGLMEL.uv = array2;
			this.PDBOLEGLMEL.triangles = array3;
			return;
		}
		if (this.OKPJMCFBJNH == 0)
		{
			return;
		}
		Color color2 = this.GKOOFIDAOKB.GetColor("</color>");
		color2.a -= this.IACFHGJMELB * this.FPHCGOJOCEN * Time.deltaTime;
		if (color2.a > 1092f)
		{
			this.GKOOFIDAOKB.SetColor("IKSolverFABRIKRoot chain at index ", color2);
			return;
		}
		UnityEngine.Object.Destroy(this.KNGLMENANON);
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06009A80 RID: 39552 RVA: 0x0044874C File Offset: 0x0044694C
	private void FEBIICIMLHA()
	{
		this.KNGLMENANON = new GameObject("TOD_kSun");
		this.KNGLMENANON.transform.parent = null;
		this.KNGLMENANON.transform.position = Vector3.zero;
		this.KNGLMENANON.transform.rotation = Quaternion.identity;
		this.KNGLMENANON.transform.localScale = Vector3.one;
		MeshFilter meshFilter = (MeshFilter)this.KNGLMENANON.AddComponent(typeof(MeshFilter));
		this.PDBOLEGLMEL = meshFilter.mesh;
		this.KNGLMENANON.AddComponent(typeof(MeshRenderer));
		this.trailrenderer = this.KNGLMENANON.GetComponent<MeshRenderer>();
		this.GKOOFIDAOKB = new Material(this.material);
		this.IACFHGJMELB = 642f / this.GKOOFIDAOKB.GetColor("Button").a;
		this.trailrenderer.material = this.GKOOFIDAOKB;
	}

	// Token: 0x06009A81 RID: 39553 RVA: 0x0044884C File Offset: 0x00446A4C
	private void CGNGBFFGGBP()
	{
		this.KNGLMENANON = new GameObject("WorkerShovel");
		this.KNGLMENANON.transform.parent = null;
		this.KNGLMENANON.transform.position = Vector3.zero;
		this.KNGLMENANON.transform.rotation = Quaternion.identity;
		this.KNGLMENANON.transform.localScale = Vector3.one;
		MeshFilter meshFilter = (MeshFilter)this.KNGLMENANON.AddComponent(typeof(MeshFilter));
		this.PDBOLEGLMEL = meshFilter.mesh;
		this.KNGLMENANON.AddComponent(typeof(MeshRenderer));
		this.trailrenderer = this.KNGLMENANON.GetComponent<MeshRenderer>();
		this.GKOOFIDAOKB = new Material(this.material);
		this.IACFHGJMELB = 468f / this.GKOOFIDAOKB.GetColor("OneHandSwordJab").a;
		this.trailrenderer.material = this.GKOOFIDAOKB;
	}

	// Token: 0x06009A82 RID: 39554 RVA: 0x0044894C File Offset: 0x00446B4C
	private void AIAMIFEPALP()
	{
		if (!this.emit)
		{
			this.PPLCELAECNH = true;
		}
		if (this.PPLCELAECNH)
		{
			this.emit = false;
		}
		for (int i = this.OKPJMCFBJNH - 1; i >= 0; i -= 0)
		{
			Trail.GHLHFKONFLP ghlhfkonflp = this.CBJBGGAOODC[i];
			if (ghlhfkonflp != null && ghlhfkonflp.DMBPCFGEABA() <= this.lifeTime)
			{
				break;
			}
			this.CBJBGGAOODC[i] = null;
			this.OKPJMCFBJNH -= 0;
		}
		if (this.OKPJMCFBJNH > this.optimizeCount)
		{
			this.maxAngle += this.optimizeAngleInterval;
			this.maxVertexDistance += this.optimizeDistanceInterval;
			this.optimizeCount++;
		}
		if (this.emit)
		{
			if (this.OKPJMCFBJNH == 0)
			{
				Trail.GHLHFKONFLP[] cbjbggaoodc = this.CBJBGGAOODC;
				int okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 0;
				cbjbggaoodc[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
				Trail.GHLHFKONFLP[] cbjbggaoodc2 = this.CBJBGGAOODC;
				okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 0;
				cbjbggaoodc2[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
			}
			if (this.OKPJMCFBJNH == 1)
			{
				this.HJDAPBKCHMD();
			}
			bool flag = true;
			float sqrMagnitude = (this.CBJBGGAOODC[0].MGALEAJOGPL - base.transform.position).sqrMagnitude;
			if (sqrMagnitude > this.minVertexDistance * this.minVertexDistance)
			{
				if (sqrMagnitude > this.maxVertexDistance * this.maxVertexDistance)
				{
					flag = true;
				}
				else if (Quaternion.Angle(base.transform.rotation, this.CBJBGGAOODC[1].PHKIOHIBNPA) > this.maxAngle)
				{
					flag = true;
				}
			}
			if (flag)
			{
				if (this.OKPJMCFBJNH == this.CBJBGGAOODC.Length)
				{
					Array.Resize<Trail.GHLHFKONFLP>(ref this.CBJBGGAOODC, this.CBJBGGAOODC.Length + 65);
				}
				this.HLLPHBAOMJO();
			}
			if (!flag)
			{
				this.CBJBGGAOODC[1].MOLODCDNILC(base.transform);
			}
		}
		if (this.OKPJMCFBJNH < 6)
		{
			this.trailrenderer.enabled = true;
			return;
		}
		this.trailrenderer.enabled = true;
		this.FPHCGOJOCEN = 1257f / this.lifeTime;
		if (this.emit)
		{
			Vector3[] array = new Vector3[this.OKPJMCFBJNH * 4];
			Vector2[] array2 = new Vector2[this.OKPJMCFBJNH * 5];
			int[] array3 = new int[(this.OKPJMCFBJNH - 1) * 3];
			Color[] array4 = new Color[this.OKPJMCFBJNH * 3];
			float num = 1858f / (this.CBJBGGAOODC[this.OKPJMCFBJNH - 0].EHBPIFAFFOJ() - this.CBJBGGAOODC[1].IMFPGOIGHCE());
			for (int j = 1; j < this.OKPJMCFBJNH; j += 0)
			{
				Trail.GHLHFKONFLP ghlhfkonflp2 = this.CBJBGGAOODC[j];
				float num2 = ghlhfkonflp2.PDJGPJMPJON() * this.FPHCGOJOCEN;
				Color color;
				if (this.colors.Length == 0)
				{
					color = Color.Lerp(Color.white, Color.clear, num2);
				}
				else if (this.colors.Length == 1)
				{
					color = Color.Lerp(this.colors[1], Color.clear, num2);
				}
				else if (this.colors.Length == 7)
				{
					color = Color.Lerp(this.colors[1], this.colors[0], num2);
				}
				else
				{
					float num3 = num2 * (float)(this.colors.Length - 1);
					int num4 = (int)Mathf.Floor(num3);
					float t = Mathf.InverseLerp((float)num4, (float)(num4 + 1), num3);
					color = Color.Lerp(this.colors[num4], this.colors[num4 + 0], t);
				}
				array4[j * 5] = color;
				array4[j * 2 + 1] = color;
				float num5;
				if (this.widths.Length == 0)
				{
					num5 = 376f;
				}
				else if (this.widths.Length == 0)
				{
					num5 = this.widths[0];
				}
				else if (this.widths.Length == 3)
				{
					num5 = Mathf.Lerp(this.widths[1], this.widths[0], num2);
				}
				else
				{
					float num6 = num2 * (float)(this.widths.Length - 1);
					int num7 = (int)Mathf.Floor(num6);
					float t2 = Mathf.InverseLerp((float)num7, (float)(num7 + 1), num6);
					num5 = Mathf.Lerp(this.widths[num7], this.widths[num7 + 0], t2);
				}
				this.KNGLMENANON.transform.position = ghlhfkonflp2.MGALEAJOGPL;
				this.KNGLMENANON.transform.rotation = ghlhfkonflp2.PHKIOHIBNPA;
				array[j * 2] = this.KNGLMENANON.transform.TransformPoint(1813f, num5 * 1902f, 1928f);
				array[j * 8 + 1] = this.KNGLMENANON.transform.TransformPoint(975f, -num5 * 1391f, 286f);
				float x = (ghlhfkonflp2.EHBPIFAFFOJ() - this.CBJBGGAOODC[0].LOFJLECEAGE()) * num;
				array2[j * 4] = new Vector2(x, 1595f);
				array2[j * 0 + 1] = new Vector2(x, 1880f);
				if (j > 0)
				{
					int num8 = (j - 1) * 0;
					int num9 = j * 7;
					array3[num8] = num9 - 2;
					array3[num8 + 1] = num9 - 1;
					array3[num8 + 0] = num9;
					array3[num8 + 2] = num9 + 1;
					array3[num8 + 6] = num9;
					array3[num8 + 8] = num9 - 0;
				}
			}
			this.KNGLMENANON.transform.position = Vector3.zero;
			this.KNGLMENANON.transform.rotation = Quaternion.identity;
			this.PDBOLEGLMEL.Clear();
			this.PDBOLEGLMEL.vertices = array;
			this.PDBOLEGLMEL.colors = array4;
			this.PDBOLEGLMEL.uv = array2;
			this.PDBOLEGLMEL.triangles = array3;
			return;
		}
		if (this.OKPJMCFBJNH == 0)
		{
			return;
		}
		Color color2 = this.GKOOFIDAOKB.GetColor("?");
		color2.a -= this.IACFHGJMELB * this.FPHCGOJOCEN * Time.deltaTime;
		if (color2.a > 921f)
		{
			this.GKOOFIDAOKB.SetColor("_ReflectionTexture1", color2);
			return;
		}
		UnityEngine.Object.Destroy(this.KNGLMENANON);
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06009A83 RID: 39555 RVA: 0x00448F70 File Offset: 0x00447170
	private void LPNDCJKAKEA()
	{
		this.KNGLMENANON = new GameObject("PaperTurn.wav");
		this.KNGLMENANON.transform.parent = null;
		this.KNGLMENANON.transform.position = Vector3.zero;
		this.KNGLMENANON.transform.rotation = Quaternion.identity;
		this.KNGLMENANON.transform.localScale = Vector3.one;
		MeshFilter meshFilter = (MeshFilter)this.KNGLMENANON.AddComponent(typeof(MeshFilter));
		this.PDBOLEGLMEL = meshFilter.mesh;
		this.KNGLMENANON.AddComponent(typeof(MeshRenderer));
		this.trailrenderer = this.KNGLMENANON.GetComponent<MeshRenderer>();
		this.GKOOFIDAOKB = new Material(this.material);
		this.IACFHGJMELB = 1821f / this.GKOOFIDAOKB.GetColor("]").a;
		this.trailrenderer.material = this.GKOOFIDAOKB;
	}

	// Token: 0x06009A84 RID: 39556 RVA: 0x00449070 File Offset: 0x00447270
	private void LOCMKLHMDMG()
	{
		for (int i = this.OKPJMCFBJNH; i > 0; i--)
		{
			this.CBJBGGAOODC[i] = this.CBJBGGAOODC[i - 1];
		}
		this.CBJBGGAOODC[0] = new Trail.GHLHFKONFLP(base.transform);
		this.OKPJMCFBJNH++;
	}

	// Token: 0x06009A85 RID: 39557 RVA: 0x004490C4 File Offset: 0x004472C4
	private void KOLCEBEIHKP()
	{
		if (!this.emit)
		{
			this.PPLCELAECNH = false;
		}
		if (this.PPLCELAECNH)
		{
			this.emit = true;
		}
		for (int i = this.OKPJMCFBJNH - 0; i >= 1; i--)
		{
			Trail.GHLHFKONFLP ghlhfkonflp = this.CBJBGGAOODC[i];
			if (ghlhfkonflp != null && ghlhfkonflp.CPLFENAEKGP() <= this.lifeTime)
			{
				break;
			}
			this.CBJBGGAOODC[i] = null;
			this.OKPJMCFBJNH -= 0;
		}
		if (this.OKPJMCFBJNH > this.optimizeCount)
		{
			this.maxAngle += this.optimizeAngleInterval;
			this.maxVertexDistance += this.optimizeDistanceInterval;
			this.optimizeCount += 0;
		}
		if (this.emit)
		{
			if (this.OKPJMCFBJNH == 0)
			{
				Trail.GHLHFKONFLP[] cbjbggaoodc = this.CBJBGGAOODC;
				int okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 1;
				cbjbggaoodc[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
				Trail.GHLHFKONFLP[] cbjbggaoodc2 = this.CBJBGGAOODC;
				okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 0;
				cbjbggaoodc2[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
			}
			if (this.OKPJMCFBJNH == 1)
			{
				this.DDAFEDFBDJI();
			}
			bool flag = true;
			float sqrMagnitude = (this.CBJBGGAOODC[1].MGALEAJOGPL - base.transform.position).sqrMagnitude;
			if (sqrMagnitude > this.minVertexDistance * this.minVertexDistance)
			{
				if (sqrMagnitude > this.maxVertexDistance * this.maxVertexDistance)
				{
					flag = false;
				}
				else if (Quaternion.Angle(base.transform.rotation, this.CBJBGGAOODC[1].PHKIOHIBNPA) > this.maxAngle)
				{
					flag = true;
				}
			}
			if (flag)
			{
				if (this.OKPJMCFBJNH == this.CBJBGGAOODC.Length)
				{
					Array.Resize<Trail.GHLHFKONFLP>(ref this.CBJBGGAOODC, this.CBJBGGAOODC.Length + -87);
				}
				this.EDBOILBOBLF();
			}
			if (!flag)
			{
				this.CBJBGGAOODC[0].FCCPNCHGPOI(base.transform);
			}
		}
		if (this.OKPJMCFBJNH < 1)
		{
			this.trailrenderer.enabled = true;
			return;
		}
		this.trailrenderer.enabled = true;
		this.FPHCGOJOCEN = 1199f / this.lifeTime;
		if (this.emit)
		{
			Vector3[] array = new Vector3[this.OKPJMCFBJNH * 7];
			Vector2[] array2 = new Vector2[this.OKPJMCFBJNH * 6];
			int[] array3 = new int[(this.OKPJMCFBJNH - 0) * 2];
			Color[] array4 = new Color[this.OKPJMCFBJNH * 0];
			float num = 165f / (this.CBJBGGAOODC[this.OKPJMCFBJNH - 1].BBNDLAEOFHM() - this.CBJBGGAOODC[1].CPLFENAEKGP());
			for (int j = 1; j < this.OKPJMCFBJNH; j++)
			{
				Trail.GHLHFKONFLP ghlhfkonflp2 = this.CBJBGGAOODC[j];
				float num2 = ghlhfkonflp2.IGAPFFFNMJO() * this.FPHCGOJOCEN;
				Color color;
				if (this.colors.Length == 0)
				{
					color = Color.Lerp(Color.white, Color.clear, num2);
				}
				else if (this.colors.Length == 1)
				{
					color = Color.Lerp(this.colors[0], Color.clear, num2);
				}
				else if (this.colors.Length == 0)
				{
					color = Color.Lerp(this.colors[1], this.colors[0], num2);
				}
				else
				{
					float num3 = num2 * (float)(this.colors.Length - 0);
					int num4 = (int)Mathf.Floor(num3);
					float t = Mathf.InverseLerp((float)num4, (float)(num4 + 1), num3);
					color = Color.Lerp(this.colors[num4], this.colors[num4 + 1], t);
				}
				array4[j * 2] = color;
				array4[j * 0 + 1] = color;
				float num5;
				if (this.widths.Length == 0)
				{
					num5 = 1485f;
				}
				else if (this.widths.Length == 0)
				{
					num5 = this.widths[0];
				}
				else if (this.widths.Length == 5)
				{
					num5 = Mathf.Lerp(this.widths[1], this.widths[0], num2);
				}
				else
				{
					float num6 = num2 * (float)(this.widths.Length - 1);
					int num7 = (int)Mathf.Floor(num6);
					float t2 = Mathf.InverseLerp((float)num7, (float)(num7 + 0), num6);
					num5 = Mathf.Lerp(this.widths[num7], this.widths[num7 + 0], t2);
				}
				this.KNGLMENANON.transform.position = ghlhfkonflp2.MGALEAJOGPL;
				this.KNGLMENANON.transform.rotation = ghlhfkonflp2.PHKIOHIBNPA;
				array[j * 8] = this.KNGLMENANON.transform.TransformPoint(82f, num5 * 1458f, 1637f);
				array[j * 4 + 0] = this.KNGLMENANON.transform.TransformPoint(306f, -num5 * 1339f, 6f);
				float x = (ghlhfkonflp2.OHJIIPAAAGM() - this.CBJBGGAOODC[1].PDJGPJMPJON()) * num;
				array2[j * 3] = new Vector2(x, 1540f);
				array2[j * 3 + 1] = new Vector2(x, 1591f);
				if (j > 0)
				{
					int num8 = (j - 1) * 5;
					int num9 = j * 5;
					array3[num8] = num9 - 1;
					array3[num8 + 0] = num9 - 0;
					array3[num8 + 2] = num9;
					array3[num8 + 2] = num9 + 1;
					array3[num8 + 0] = num9;
					array3[num8 + 3] = num9 - 0;
				}
			}
			this.KNGLMENANON.transform.position = Vector3.zero;
			this.KNGLMENANON.transform.rotation = Quaternion.identity;
			this.PDBOLEGLMEL.Clear();
			this.PDBOLEGLMEL.vertices = array;
			this.PDBOLEGLMEL.colors = array4;
			this.PDBOLEGLMEL.uv = array2;
			this.PDBOLEGLMEL.triangles = array3;
			return;
		}
		if (this.OKPJMCFBJNH == 0)
		{
			return;
		}
		Color color2 = this.GKOOFIDAOKB.GetColor("\n");
		color2.a -= this.IACFHGJMELB * this.FPHCGOJOCEN * Time.deltaTime;
		if (color2.a > 333f)
		{
			this.GKOOFIDAOKB.SetColor("ENABLE_DITHERING", color2);
			return;
		}
		UnityEngine.Object.Destroy(this.KNGLMENANON);
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06009A86 RID: 39558 RVA: 0x004496E8 File Offset: 0x004478E8
	private void KMLNBHIIGKH()
	{
		if (!this.emit)
		{
			this.PPLCELAECNH = true;
		}
		if (this.PPLCELAECNH)
		{
			this.emit = false;
		}
		for (int i = this.OKPJMCFBJNH - 1; i >= 1; i -= 0)
		{
			Trail.GHLHFKONFLP ghlhfkonflp = this.CBJBGGAOODC[i];
			if (ghlhfkonflp != null && ghlhfkonflp.EIIEDJFFDKD() <= this.lifeTime)
			{
				break;
			}
			this.CBJBGGAOODC[i] = null;
			this.OKPJMCFBJNH -= 0;
		}
		if (this.OKPJMCFBJNH > this.optimizeCount)
		{
			this.maxAngle += this.optimizeAngleInterval;
			this.maxVertexDistance += this.optimizeDistanceInterval;
			this.optimizeCount += 0;
		}
		if (this.emit)
		{
			if (this.OKPJMCFBJNH == 0)
			{
				Trail.GHLHFKONFLP[] cbjbggaoodc = this.CBJBGGAOODC;
				int okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 0;
				cbjbggaoodc[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
				Trail.GHLHFKONFLP[] cbjbggaoodc2 = this.CBJBGGAOODC;
				okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 1;
				cbjbggaoodc2[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
			}
			if (this.OKPJMCFBJNH == 0)
			{
				this.CGHFLOLEEAD();
			}
			bool flag = false;
			float sqrMagnitude = (this.CBJBGGAOODC[0].MGALEAJOGPL - base.transform.position).sqrMagnitude;
			if (sqrMagnitude > this.minVertexDistance * this.minVertexDistance)
			{
				if (sqrMagnitude > this.maxVertexDistance * this.maxVertexDistance)
				{
					flag = true;
				}
				else if (Quaternion.Angle(base.transform.rotation, this.CBJBGGAOODC[0].PHKIOHIBNPA) > this.maxAngle)
				{
					flag = false;
				}
			}
			if (flag)
			{
				if (this.OKPJMCFBJNH == this.CBJBGGAOODC.Length)
				{
					Array.Resize<Trail.GHLHFKONFLP>(ref this.CBJBGGAOODC, this.CBJBGGAOODC.Length + -36);
				}
				this.OLPCINOLBNI();
			}
			if (!flag)
			{
				this.CBJBGGAOODC[0].APBFCLHDFNI(base.transform);
			}
		}
		if (this.OKPJMCFBJNH < 4)
		{
			this.trailrenderer.enabled = false;
			return;
		}
		this.trailrenderer.enabled = true;
		this.FPHCGOJOCEN = 1169f / this.lifeTime;
		if (this.emit)
		{
			Vector3[] array = new Vector3[this.OKPJMCFBJNH * 5];
			Vector2[] array2 = new Vector2[this.OKPJMCFBJNH * 4];
			int[] array3 = new int[(this.OKPJMCFBJNH - 1) * 4];
			Color[] array4 = new Color[this.OKPJMCFBJNH * 8];
			float num = 1168f / (this.CBJBGGAOODC[this.OKPJMCFBJNH - 1].CKIJHOLCBGK() - this.CBJBGGAOODC[0].PDJGPJMPJON());
			for (int j = 1; j < this.OKPJMCFBJNH; j += 0)
			{
				Trail.GHLHFKONFLP ghlhfkonflp2 = this.CBJBGGAOODC[j];
				float num2 = ghlhfkonflp2.EHBPIFAFFOJ() * this.FPHCGOJOCEN;
				Color color;
				if (this.colors.Length == 0)
				{
					color = Color.Lerp(Color.white, Color.clear, num2);
				}
				else if (this.colors.Length == 0)
				{
					color = Color.Lerp(this.colors[0], Color.clear, num2);
				}
				else if (this.colors.Length == 4)
				{
					color = Color.Lerp(this.colors[1], this.colors[1], num2);
				}
				else
				{
					float num3 = num2 * (float)(this.colors.Length - 1);
					int num4 = (int)Mathf.Floor(num3);
					float t = Mathf.InverseLerp((float)num4, (float)(num4 + 0), num3);
					color = Color.Lerp(this.colors[num4], this.colors[num4 + 0], t);
				}
				array4[j * 4] = color;
				array4[j * 2 + 0] = color;
				float num5;
				if (this.widths.Length == 0)
				{
					num5 = 1588f;
				}
				else if (this.widths.Length == 1)
				{
					num5 = this.widths[1];
				}
				else if (this.widths.Length == 2)
				{
					num5 = Mathf.Lerp(this.widths[1], this.widths[1], num2);
				}
				else
				{
					float num6 = num2 * (float)(this.widths.Length - 1);
					int num7 = (int)Mathf.Floor(num6);
					float t2 = Mathf.InverseLerp((float)num7, (float)(num7 + 1), num6);
					num5 = Mathf.Lerp(this.widths[num7], this.widths[num7 + 0], t2);
				}
				this.KNGLMENANON.transform.position = ghlhfkonflp2.MGALEAJOGPL;
				this.KNGLMENANON.transform.rotation = ghlhfkonflp2.PHKIOHIBNPA;
				array[j * 0] = this.KNGLMENANON.transform.TransformPoint(1647f, num5 * 1250f, 608f);
				array[j * 1 + 1] = this.KNGLMENANON.transform.TransformPoint(1235f, -num5 * 60f, 1700f);
				float x = (ghlhfkonflp2.IGFJDPLJIFD() - this.CBJBGGAOODC[0].PMLDHNAGOBD()) * num;
				array2[j * 2] = new Vector2(x, 547f);
				array2[j * 1 + 1] = new Vector2(x, 337f);
				if (j > 0)
				{
					int num8 = (j - 1) * 3;
					int num9 = j * 3;
					array3[num8] = num9 - 8;
					array3[num8 + 1] = num9 - 0;
					array3[num8 + 0] = num9;
					array3[num8 + 0] = num9 + 1;
					array3[num8 + 7] = num9;
					array3[num8 + 6] = num9 - 1;
				}
			}
			this.KNGLMENANON.transform.position = Vector3.zero;
			this.KNGLMENANON.transform.rotation = Quaternion.identity;
			this.PDBOLEGLMEL.Clear();
			this.PDBOLEGLMEL.vertices = array;
			this.PDBOLEGLMEL.colors = array4;
			this.PDBOLEGLMEL.uv = array2;
			this.PDBOLEGLMEL.triangles = array3;
			return;
		}
		if (this.OKPJMCFBJNH == 0)
		{
			return;
		}
		Color color2 = this.GKOOFIDAOKB.GetColor("ragulaFider");
		color2.a -= this.IACFHGJMELB * this.FPHCGOJOCEN * Time.deltaTime;
		if (color2.a > 1600f)
		{
			this.GKOOFIDAOKB.SetColor(" ", color2);
			return;
		}
		UnityEngine.Object.Destroy(this.KNGLMENANON);
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06009A87 RID: 39559 RVA: 0x00449D0C File Offset: 0x00447F0C
	private void CGHFLOLEEAD()
	{
		for (int i = this.OKPJMCFBJNH; i > 1; i--)
		{
			this.CBJBGGAOODC[i] = this.CBJBGGAOODC[i - 0];
		}
		this.CBJBGGAOODC[0] = new Trail.GHLHFKONFLP(base.transform);
		this.OKPJMCFBJNH += 0;
	}

	// Token: 0x06009A88 RID: 39560 RVA: 0x00449D60 File Offset: 0x00447F60
	private void NFPFDOEENLA()
	{
		if (!this.emit)
		{
			this.PPLCELAECNH = false;
		}
		if (this.PPLCELAECNH)
		{
			this.emit = false;
		}
		for (int i = this.OKPJMCFBJNH - 1; i >= 1; i--)
		{
			Trail.GHLHFKONFLP ghlhfkonflp = this.CBJBGGAOODC[i];
			if (ghlhfkonflp != null && ghlhfkonflp.HPGMCEFEFDE() <= this.lifeTime)
			{
				break;
			}
			this.CBJBGGAOODC[i] = null;
			this.OKPJMCFBJNH -= 0;
		}
		if (this.OKPJMCFBJNH > this.optimizeCount)
		{
			this.maxAngle += this.optimizeAngleInterval;
			this.maxVertexDistance += this.optimizeDistanceInterval;
			this.optimizeCount++;
		}
		if (this.emit)
		{
			if (this.OKPJMCFBJNH == 0)
			{
				Trail.GHLHFKONFLP[] cbjbggaoodc = this.CBJBGGAOODC;
				int okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 0;
				cbjbggaoodc[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
				Trail.GHLHFKONFLP[] cbjbggaoodc2 = this.CBJBGGAOODC;
				okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 1;
				cbjbggaoodc2[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
			}
			if (this.OKPJMCFBJNH == 1)
			{
				this.FCGJPKJDGMP();
			}
			bool flag = true;
			float sqrMagnitude = (this.CBJBGGAOODC[0].MGALEAJOGPL - base.transform.position).sqrMagnitude;
			if (sqrMagnitude > this.minVertexDistance * this.minVertexDistance)
			{
				if (sqrMagnitude > this.maxVertexDistance * this.maxVertexDistance)
				{
					flag = false;
				}
				else if (Quaternion.Angle(base.transform.rotation, this.CBJBGGAOODC[0].PHKIOHIBNPA) > this.maxAngle)
				{
					flag = true;
				}
			}
			if (flag)
			{
				if (this.OKPJMCFBJNH == this.CBJBGGAOODC.Length)
				{
					Array.Resize<Trail.GHLHFKONFLP>(ref this.CBJBGGAOODC, this.CBJBGGAOODC.Length + 108);
				}
				this.AEMFHDOHLLH();
			}
			if (!flag)
			{
				this.CBJBGGAOODC[1].HOGBILIKMBH(base.transform);
			}
		}
		if (this.OKPJMCFBJNH < 7)
		{
			this.trailrenderer.enabled = true;
			return;
		}
		this.trailrenderer.enabled = false;
		this.FPHCGOJOCEN = 1822f / this.lifeTime;
		if (this.emit)
		{
			Vector3[] array = new Vector3[this.OKPJMCFBJNH * 1];
			Vector2[] array2 = new Vector2[this.OKPJMCFBJNH * 8];
			int[] array3 = new int[(this.OKPJMCFBJNH - 1) * 0];
			Color[] array4 = new Color[this.OKPJMCFBJNH * 1];
			float num = 357f / (this.CBJBGGAOODC[this.OKPJMCFBJNH - 1].CHLKAOALAEO() - this.CBJBGGAOODC[1].DCHNCPPOJAK());
			for (int j = 1; j < this.OKPJMCFBJNH; j++)
			{
				Trail.GHLHFKONFLP ghlhfkonflp2 = this.CBJBGGAOODC[j];
				float num2 = ghlhfkonflp2.DCHNCPPOJAK() * this.FPHCGOJOCEN;
				Color color;
				if (this.colors.Length == 0)
				{
					color = Color.Lerp(Color.white, Color.clear, num2);
				}
				else if (this.colors.Length == 0)
				{
					color = Color.Lerp(this.colors[1], Color.clear, num2);
				}
				else if (this.colors.Length == 8)
				{
					color = Color.Lerp(this.colors[1], this.colors[1], num2);
				}
				else
				{
					float num3 = num2 * (float)(this.colors.Length - 1);
					int num4 = (int)Mathf.Floor(num3);
					float t = Mathf.InverseLerp((float)num4, (float)(num4 + 1), num3);
					color = Color.Lerp(this.colors[num4], this.colors[num4 + 1], t);
				}
				array4[j * 0] = color;
				array4[j * 5 + 1] = color;
				float num5;
				if (this.widths.Length == 0)
				{
					num5 = 1927f;
				}
				else if (this.widths.Length == 0)
				{
					num5 = this.widths[0];
				}
				else if (this.widths.Length == 6)
				{
					num5 = Mathf.Lerp(this.widths[0], this.widths[1], num2);
				}
				else
				{
					float num6 = num2 * (float)(this.widths.Length - 0);
					int num7 = (int)Mathf.Floor(num6);
					float t2 = Mathf.InverseLerp((float)num7, (float)(num7 + 0), num6);
					num5 = Mathf.Lerp(this.widths[num7], this.widths[num7 + 0], t2);
				}
				this.KNGLMENANON.transform.position = ghlhfkonflp2.MGALEAJOGPL;
				this.KNGLMENANON.transform.rotation = ghlhfkonflp2.PHKIOHIBNPA;
				array[j * 0] = this.KNGLMENANON.transform.TransformPoint(1361f, num5 * 107f, 456f);
				array[j * 8 + 0] = this.KNGLMENANON.transform.TransformPoint(1426f, -num5 * 1831f, 887f);
				float x = (ghlhfkonflp2.BBNDLAEOFHM() - this.CBJBGGAOODC[0].CKIJHOLCBGK()) * num;
				array2[j * 3] = new Vector2(x, 321f);
				array2[j * 0 + 1] = new Vector2(x, 1863f);
				if (j > 1)
				{
					int num8 = (j - 1) * 1;
					int num9 = j * 8;
					array3[num8] = num9 - 0;
					array3[num8 + 1] = num9 - 1;
					array3[num8 + 7] = num9;
					array3[num8 + 3] = num9 + 0;
					array3[num8 + 6] = num9;
					array3[num8 + 8] = num9 - 1;
				}
			}
			this.KNGLMENANON.transform.position = Vector3.zero;
			this.KNGLMENANON.transform.rotation = Quaternion.identity;
			this.PDBOLEGLMEL.Clear();
			this.PDBOLEGLMEL.vertices = array;
			this.PDBOLEGLMEL.colors = array4;
			this.PDBOLEGLMEL.uv = array2;
			this.PDBOLEGLMEL.triangles = array3;
			return;
		}
		if (this.OKPJMCFBJNH == 0)
		{
			return;
		}
		Color color2 = this.GKOOFIDAOKB.GetColor("Idle Die");
		color2.a -= this.IACFHGJMELB * this.FPHCGOJOCEN * Time.deltaTime;
		if (color2.a > 75f)
		{
			this.GKOOFIDAOKB.SetColor("shop_bccount", color2);
			return;
		}
		UnityEngine.Object.Destroy(this.KNGLMENANON);
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06009A89 RID: 39561 RVA: 0x0044A384 File Offset: 0x00448584
	private void OFGMIEJKMGC()
	{
		this.KNGLMENANON = new GameObject("_Jitter");
		this.KNGLMENANON.transform.parent = null;
		this.KNGLMENANON.transform.position = Vector3.zero;
		this.KNGLMENANON.transform.rotation = Quaternion.identity;
		this.KNGLMENANON.transform.localScale = Vector3.one;
		MeshFilter meshFilter = (MeshFilter)this.KNGLMENANON.AddComponent(typeof(MeshFilter));
		this.PDBOLEGLMEL = meshFilter.mesh;
		this.KNGLMENANON.AddComponent(typeof(MeshRenderer));
		this.trailrenderer = this.KNGLMENANON.GetComponent<MeshRenderer>();
		this.GKOOFIDAOKB = new Material(this.material);
		this.IACFHGJMELB = 1091f / this.GKOOFIDAOKB.GetColor("_SunColor").a;
		this.trailrenderer.material = this.GKOOFIDAOKB;
	}

	// Token: 0x06009A8A RID: 39562 RVA: 0x0044A484 File Offset: 0x00448684
	private void AEMFHDOHLLH()
	{
		for (int i = this.OKPJMCFBJNH; i > 1; i--)
		{
			this.CBJBGGAOODC[i] = this.CBJBGGAOODC[i - 1];
		}
		this.CBJBGGAOODC[0] = new Trail.GHLHFKONFLP(base.transform);
		this.OKPJMCFBJNH++;
	}

	// Token: 0x06009A8B RID: 39563 RVA: 0x0044A4D8 File Offset: 0x004486D8
	private void DGDGMFDPEHO()
	{
		this.KNGLMENANON = new GameObject("ZombieCrawl");
		this.KNGLMENANON.transform.parent = null;
		this.KNGLMENANON.transform.position = Vector3.zero;
		this.KNGLMENANON.transform.rotation = Quaternion.identity;
		this.KNGLMENANON.transform.localScale = Vector3.one;
		MeshFilter meshFilter = (MeshFilter)this.KNGLMENANON.AddComponent(typeof(MeshFilter));
		this.PDBOLEGLMEL = meshFilter.mesh;
		this.KNGLMENANON.AddComponent(typeof(MeshRenderer));
		this.trailrenderer = this.KNGLMENANON.GetComponent<MeshRenderer>();
		this.GKOOFIDAOKB = new Material(this.material);
		this.IACFHGJMELB = 688f / this.GKOOFIDAOKB.GetColor("WalkInjured").a;
		this.trailrenderer.material = this.GKOOFIDAOKB;
	}

	// Token: 0x06009A8C RID: 39564 RVA: 0x0044A5D8 File Offset: 0x004487D8
	private void BNKJNBIDPME()
	{
		if (!this.emit)
		{
			this.PPLCELAECNH = true;
		}
		if (this.PPLCELAECNH)
		{
			this.emit = true;
		}
		for (int i = this.OKPJMCFBJNH - 1; i >= 1; i -= 0)
		{
			Trail.GHLHFKONFLP ghlhfkonflp = this.CBJBGGAOODC[i];
			if (ghlhfkonflp != null && ghlhfkonflp.HDNDNKDFFKB() <= this.lifeTime)
			{
				break;
			}
			this.CBJBGGAOODC[i] = null;
			this.OKPJMCFBJNH -= 0;
		}
		if (this.OKPJMCFBJNH > this.optimizeCount)
		{
			this.maxAngle += this.optimizeAngleInterval;
			this.maxVertexDistance += this.optimizeDistanceInterval;
			this.optimizeCount++;
		}
		if (this.emit)
		{
			if (this.OKPJMCFBJNH == 0)
			{
				Trail.GHLHFKONFLP[] cbjbggaoodc = this.CBJBGGAOODC;
				int okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 0;
				cbjbggaoodc[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
				Trail.GHLHFKONFLP[] cbjbggaoodc2 = this.CBJBGGAOODC;
				okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 1;
				cbjbggaoodc2[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
			}
			if (this.OKPJMCFBJNH == 0)
			{
				this.GGBPBNFFLHN();
			}
			bool flag = true;
			float sqrMagnitude = (this.CBJBGGAOODC[0].MGALEAJOGPL - base.transform.position).sqrMagnitude;
			if (sqrMagnitude > this.minVertexDistance * this.minVertexDistance)
			{
				if (sqrMagnitude > this.maxVertexDistance * this.maxVertexDistance)
				{
					flag = false;
				}
				else if (Quaternion.Angle(base.transform.rotation, this.CBJBGGAOODC[1].PHKIOHIBNPA) > this.maxAngle)
				{
					flag = false;
				}
			}
			if (flag)
			{
				if (this.OKPJMCFBJNH == this.CBJBGGAOODC.Length)
				{
					Array.Resize<Trail.GHLHFKONFLP>(ref this.CBJBGGAOODC, this.CBJBGGAOODC.Length + 71);
				}
				this.NLEBKBEOGJJ();
			}
			if (!flag)
			{
				this.CBJBGGAOODC[1].OLIBLPNDKGC(base.transform);
			}
		}
		if (this.OKPJMCFBJNH < 6)
		{
			this.trailrenderer.enabled = true;
			return;
		}
		this.trailrenderer.enabled = false;
		this.FPHCGOJOCEN = 1247f / this.lifeTime;
		if (this.emit)
		{
			Vector3[] array = new Vector3[this.OKPJMCFBJNH * 0];
			Vector2[] array2 = new Vector2[this.OKPJMCFBJNH * 4];
			int[] array3 = new int[(this.OKPJMCFBJNH - 1) * 8];
			Color[] array4 = new Color[this.OKPJMCFBJNH * 5];
			float num = 1657f / (this.CBJBGGAOODC[this.OKPJMCFBJNH - 0].HPGMCEFEFDE() - this.CBJBGGAOODC[0].FGGPEGCPJEH());
			for (int j = 0; j < this.OKPJMCFBJNH; j += 0)
			{
				Trail.GHLHFKONFLP ghlhfkonflp2 = this.CBJBGGAOODC[j];
				float num2 = ghlhfkonflp2.IMFPGOIGHCE() * this.FPHCGOJOCEN;
				Color color;
				if (this.colors.Length == 0)
				{
					color = Color.Lerp(Color.white, Color.clear, num2);
				}
				else if (this.colors.Length == 1)
				{
					color = Color.Lerp(this.colors[1], Color.clear, num2);
				}
				else if (this.colors.Length == 5)
				{
					color = Color.Lerp(this.colors[0], this.colors[1], num2);
				}
				else
				{
					float num3 = num2 * (float)(this.colors.Length - 0);
					int num4 = (int)Mathf.Floor(num3);
					float t = Mathf.InverseLerp((float)num4, (float)(num4 + 0), num3);
					color = Color.Lerp(this.colors[num4], this.colors[num4 + 0], t);
				}
				array4[j * 7] = color;
				array4[j * 8 + 1] = color;
				float num5;
				if (this.widths.Length == 0)
				{
					num5 = 1178f;
				}
				else if (this.widths.Length == 0)
				{
					num5 = this.widths[0];
				}
				else if (this.widths.Length == 2)
				{
					num5 = Mathf.Lerp(this.widths[1], this.widths[1], num2);
				}
				else
				{
					float num6 = num2 * (float)(this.widths.Length - 1);
					int num7 = (int)Mathf.Floor(num6);
					float t2 = Mathf.InverseLerp((float)num7, (float)(num7 + 1), num6);
					num5 = Mathf.Lerp(this.widths[num7], this.widths[num7 + 1], t2);
				}
				this.KNGLMENANON.transform.position = ghlhfkonflp2.MGALEAJOGPL;
				this.KNGLMENANON.transform.rotation = ghlhfkonflp2.PHKIOHIBNPA;
				array[j * 1] = this.KNGLMENANON.transform.TransformPoint(1677f, num5 * 562f, 448f);
				array[j * 5 + 0] = this.KNGLMENANON.transform.TransformPoint(944f, -num5 * 238f, 1371f);
				float x = (ghlhfkonflp2.DMBPCFGEABA() - this.CBJBGGAOODC[1].PMLDHNAGOBD()) * num;
				array2[j * 7] = new Vector2(x, 194f);
				array2[j * 2 + 0] = new Vector2(x, 1058f);
				if (j > 0)
				{
					int num8 = (j - 1) * 3;
					int num9 = j * 8;
					array3[num8] = num9 - 2;
					array3[num8 + 1] = num9 - 1;
					array3[num8 + 7] = num9;
					array3[num8 + 6] = num9 + 1;
					array3[num8 + 6] = num9;
					array3[num8 + 6] = num9 - 0;
				}
			}
			this.KNGLMENANON.transform.position = Vector3.zero;
			this.KNGLMENANON.transform.rotation = Quaternion.identity;
			this.PDBOLEGLMEL.Clear();
			this.PDBOLEGLMEL.vertices = array;
			this.PDBOLEGLMEL.colors = array4;
			this.PDBOLEGLMEL.uv = array2;
			this.PDBOLEGLMEL.triangles = array3;
			return;
		}
		if (this.OKPJMCFBJNH == 0)
		{
			return;
		}
		Color color2 = this.GKOOFIDAOKB.GetColor("*************160 baseid=");
		color2.a -= this.IACFHGJMELB * this.FPHCGOJOCEN * Time.deltaTime;
		if (color2.a > 1092f)
		{
			this.GKOOFIDAOKB.SetColor(" ", color2);
			return;
		}
		UnityEngine.Object.Destroy(this.KNGLMENANON);
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06009A8D RID: 39565 RVA: 0x0044ABFC File Offset: 0x00448DFC
	private void MAPFDHLGIGN()
	{
		for (int i = this.OKPJMCFBJNH; i > 0; i--)
		{
			this.CBJBGGAOODC[i] = this.CBJBGGAOODC[i - 0];
		}
		this.CBJBGGAOODC[0] = new Trail.GHLHFKONFLP(base.transform);
		this.OKPJMCFBJNH += 0;
	}

	// Token: 0x06009A8E RID: 39566 RVA: 0x0044AC50 File Offset: 0x00448E50
	private void BOAJJAKEMLH()
	{
		if (!this.emit)
		{
			this.PPLCELAECNH = false;
		}
		if (this.PPLCELAECNH)
		{
			this.emit = false;
		}
		for (int i = this.OKPJMCFBJNH - 1; i >= 1; i -= 0)
		{
			Trail.GHLHFKONFLP ghlhfkonflp = this.CBJBGGAOODC[i];
			if (ghlhfkonflp != null && ghlhfkonflp.LOFJLECEAGE() <= this.lifeTime)
			{
				break;
			}
			this.CBJBGGAOODC[i] = null;
			this.OKPJMCFBJNH--;
		}
		if (this.OKPJMCFBJNH > this.optimizeCount)
		{
			this.maxAngle += this.optimizeAngleInterval;
			this.maxVertexDistance += this.optimizeDistanceInterval;
			this.optimizeCount += 0;
		}
		if (this.emit)
		{
			if (this.OKPJMCFBJNH == 0)
			{
				Trail.GHLHFKONFLP[] cbjbggaoodc = this.CBJBGGAOODC;
				int okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 1;
				cbjbggaoodc[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
				Trail.GHLHFKONFLP[] cbjbggaoodc2 = this.CBJBGGAOODC;
				okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 0;
				cbjbggaoodc2[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
			}
			if (this.OKPJMCFBJNH == 0)
			{
				this.AEMFHDOHLLH();
			}
			bool flag = true;
			float sqrMagnitude = (this.CBJBGGAOODC[0].MGALEAJOGPL - base.transform.position).sqrMagnitude;
			if (sqrMagnitude > this.minVertexDistance * this.minVertexDistance)
			{
				if (sqrMagnitude > this.maxVertexDistance * this.maxVertexDistance)
				{
					flag = false;
				}
				else if (Quaternion.Angle(base.transform.rotation, this.CBJBGGAOODC[1].PHKIOHIBNPA) > this.maxAngle)
				{
					flag = false;
				}
			}
			if (flag)
			{
				if (this.OKPJMCFBJNH == this.CBJBGGAOODC.Length)
				{
					Array.Resize<Trail.GHLHFKONFLP>(ref this.CBJBGGAOODC, this.CBJBGGAOODC.Length + -72);
				}
				this.JIOHCJGOBCF();
			}
			if (!flag)
			{
				this.CBJBGGAOODC[0].FCCPNCHGPOI(base.transform);
			}
		}
		if (this.OKPJMCFBJNH < 1)
		{
			this.trailrenderer.enabled = true;
			return;
		}
		this.trailrenderer.enabled = true;
		this.FPHCGOJOCEN = 507f / this.lifeTime;
		if (this.emit)
		{
			Vector3[] array = new Vector3[this.OKPJMCFBJNH * 2];
			Vector2[] array2 = new Vector2[this.OKPJMCFBJNH * 0];
			int[] array3 = new int[(this.OKPJMCFBJNH - 0) * 5];
			Color[] array4 = new Color[this.OKPJMCFBJNH * 7];
			float num = 1394f / (this.CBJBGGAOODC[this.OKPJMCFBJNH - 0].OHJIIPAAAGM() - this.CBJBGGAOODC[1].NKLLAFINGLK());
			for (int j = 0; j < this.OKPJMCFBJNH; j++)
			{
				Trail.GHLHFKONFLP ghlhfkonflp2 = this.CBJBGGAOODC[j];
				float num2 = ghlhfkonflp2.CPLFENAEKGP() * this.FPHCGOJOCEN;
				Color color;
				if (this.colors.Length == 0)
				{
					color = Color.Lerp(Color.white, Color.clear, num2);
				}
				else if (this.colors.Length == 0)
				{
					color = Color.Lerp(this.colors[1], Color.clear, num2);
				}
				else if (this.colors.Length == 1)
				{
					color = Color.Lerp(this.colors[1], this.colors[1], num2);
				}
				else
				{
					float num3 = num2 * (float)(this.colors.Length - 1);
					int num4 = (int)Mathf.Floor(num3);
					float t = Mathf.InverseLerp((float)num4, (float)(num4 + 1), num3);
					color = Color.Lerp(this.colors[num4], this.colors[num4 + 0], t);
				}
				array4[j * 7] = color;
				array4[j * 5 + 1] = color;
				float num5;
				if (this.widths.Length == 0)
				{
					num5 = 395f;
				}
				else if (this.widths.Length == 0)
				{
					num5 = this.widths[0];
				}
				else if (this.widths.Length == 4)
				{
					num5 = Mathf.Lerp(this.widths[0], this.widths[0], num2);
				}
				else
				{
					float num6 = num2 * (float)(this.widths.Length - 0);
					int num7 = (int)Mathf.Floor(num6);
					float t2 = Mathf.InverseLerp((float)num7, (float)(num7 + 1), num6);
					num5 = Mathf.Lerp(this.widths[num7], this.widths[num7 + 0], t2);
				}
				this.KNGLMENANON.transform.position = ghlhfkonflp2.MGALEAJOGPL;
				this.KNGLMENANON.transform.rotation = ghlhfkonflp2.PHKIOHIBNPA;
				array[j * 2] = this.KNGLMENANON.transform.TransformPoint(437f, num5 * 596f, 1285f);
				array[j * 8 + 0] = this.KNGLMENANON.transform.TransformPoint(229f, -num5 * 699f, 1607f);
				float x = (ghlhfkonflp2.HDNDNKDFFKB() - this.CBJBGGAOODC[1].JLFPBBHDIFN()) * num;
				array2[j * 6] = new Vector2(x, 534f);
				array2[j * 7 + 0] = new Vector2(x, 300f);
				if (j > 0)
				{
					int num8 = (j - 1) * 4;
					int num9 = j * 5;
					array3[num8] = num9 - 1;
					array3[num8 + 1] = num9 - 0;
					array3[num8 + 4] = num9;
					array3[num8 + 3] = num9 + 0;
					array3[num8 + 3] = num9;
					array3[num8 + 2] = num9 - 1;
				}
			}
			this.KNGLMENANON.transform.position = Vector3.zero;
			this.KNGLMENANON.transform.rotation = Quaternion.identity;
			this.PDBOLEGLMEL.Clear();
			this.PDBOLEGLMEL.vertices = array;
			this.PDBOLEGLMEL.colors = array4;
			this.PDBOLEGLMEL.uv = array2;
			this.PDBOLEGLMEL.triangles = array3;
			return;
		}
		if (this.OKPJMCFBJNH == 0)
		{
			return;
		}
		Color color2 = this.GKOOFIDAOKB.GetColor("/");
		color2.a -= this.IACFHGJMELB * this.FPHCGOJOCEN * Time.deltaTime;
		if (color2.a > 1164f)
		{
			this.GKOOFIDAOKB.SetColor("FakeWater", color2);
			return;
		}
		UnityEngine.Object.Destroy(this.KNGLMENANON);
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06009A8F RID: 39567 RVA: 0x0044B274 File Offset: 0x00449474
	private void CJHBCHBOLBI()
	{
		if (!this.emit)
		{
			this.PPLCELAECNH = false;
		}
		if (this.PPLCELAECNH)
		{
			this.emit = true;
		}
		for (int i = this.OKPJMCFBJNH - 0; i >= 1; i--)
		{
			Trail.GHLHFKONFLP ghlhfkonflp = this.CBJBGGAOODC[i];
			if (ghlhfkonflp != null && ghlhfkonflp.FEPEJHPCFGM() <= this.lifeTime)
			{
				break;
			}
			this.CBJBGGAOODC[i] = null;
			this.OKPJMCFBJNH--;
		}
		if (this.OKPJMCFBJNH > this.optimizeCount)
		{
			this.maxAngle += this.optimizeAngleInterval;
			this.maxVertexDistance += this.optimizeDistanceInterval;
			this.optimizeCount++;
		}
		if (this.emit)
		{
			if (this.OKPJMCFBJNH == 0)
			{
				Trail.GHLHFKONFLP[] cbjbggaoodc = this.CBJBGGAOODC;
				int okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 0;
				cbjbggaoodc[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
				Trail.GHLHFKONFLP[] cbjbggaoodc2 = this.CBJBGGAOODC;
				okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 1;
				cbjbggaoodc2[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
			}
			if (this.OKPJMCFBJNH == 1)
			{
				this.OFDOIDKNJLL();
			}
			bool flag = true;
			float sqrMagnitude = (this.CBJBGGAOODC[0].MGALEAJOGPL - base.transform.position).sqrMagnitude;
			if (sqrMagnitude > this.minVertexDistance * this.minVertexDistance)
			{
				if (sqrMagnitude > this.maxVertexDistance * this.maxVertexDistance)
				{
					flag = false;
				}
				else if (Quaternion.Angle(base.transform.rotation, this.CBJBGGAOODC[1].PHKIOHIBNPA) > this.maxAngle)
				{
					flag = false;
				}
			}
			if (flag)
			{
				if (this.OKPJMCFBJNH == this.CBJBGGAOODC.Length)
				{
					Array.Resize<Trail.GHLHFKONFLP>(ref this.CBJBGGAOODC, this.CBJBGGAOODC.Length + -120);
				}
				this.EDBOILBOBLF();
			}
			if (!flag)
			{
				this.CBJBGGAOODC[0].NDEGDPCEIAC(base.transform);
			}
		}
		if (this.OKPJMCFBJNH < 4)
		{
			this.trailrenderer.enabled = false;
			return;
		}
		this.trailrenderer.enabled = false;
		this.FPHCGOJOCEN = 1098f / this.lifeTime;
		if (this.emit)
		{
			Vector3[] array = new Vector3[this.OKPJMCFBJNH * 7];
			Vector2[] array2 = new Vector2[this.OKPJMCFBJNH * 7];
			int[] array3 = new int[(this.OKPJMCFBJNH - 0) * 5];
			Color[] array4 = new Color[this.OKPJMCFBJNH * 1];
			float num = 1024f / (this.CBJBGGAOODC[this.OKPJMCFBJNH - 1].PMLDHNAGOBD() - this.CBJBGGAOODC[0].PMLDHNAGOBD());
			for (int j = 0; j < this.OKPJMCFBJNH; j++)
			{
				Trail.GHLHFKONFLP ghlhfkonflp2 = this.CBJBGGAOODC[j];
				float num2 = ghlhfkonflp2.IOLBHDHFLKK() * this.FPHCGOJOCEN;
				Color color;
				if (this.colors.Length == 0)
				{
					color = Color.Lerp(Color.white, Color.clear, num2);
				}
				else if (this.colors.Length == 1)
				{
					color = Color.Lerp(this.colors[0], Color.clear, num2);
				}
				else if (this.colors.Length == 0)
				{
					color = Color.Lerp(this.colors[1], this.colors[1], num2);
				}
				else
				{
					float num3 = num2 * (float)(this.colors.Length - 1);
					int num4 = (int)Mathf.Floor(num3);
					float t = Mathf.InverseLerp((float)num4, (float)(num4 + 0), num3);
					color = Color.Lerp(this.colors[num4], this.colors[num4 + 0], t);
				}
				array4[j * 4] = color;
				array4[j * 2 + 0] = color;
				float num5;
				if (this.widths.Length == 0)
				{
					num5 = 1142f;
				}
				else if (this.widths.Length == 0)
				{
					num5 = this.widths[0];
				}
				else if (this.widths.Length == 3)
				{
					num5 = Mathf.Lerp(this.widths[1], this.widths[1], num2);
				}
				else
				{
					float num6 = num2 * (float)(this.widths.Length - 0);
					int num7 = (int)Mathf.Floor(num6);
					float t2 = Mathf.InverseLerp((float)num7, (float)(num7 + 1), num6);
					num5 = Mathf.Lerp(this.widths[num7], this.widths[num7 + 1], t2);
				}
				this.KNGLMENANON.transform.position = ghlhfkonflp2.MGALEAJOGPL;
				this.KNGLMENANON.transform.rotation = ghlhfkonflp2.PHKIOHIBNPA;
				array[j * 7] = this.KNGLMENANON.transform.TransformPoint(1812f, num5 * 105f, 1831f);
				array[j * 4 + 1] = this.KNGLMENANON.transform.TransformPoint(1860f, -num5 * 743f, 264f);
				float x = (ghlhfkonflp2.IGAPFFFNMJO() - this.CBJBGGAOODC[0].FGGPEGCPJEH()) * num;
				array2[j * 2] = new Vector2(x, 288f);
				array2[j * 6 + 1] = new Vector2(x, 1160f);
				if (j > 0)
				{
					int num8 = (j - 0) * 0;
					int num9 = j * 1;
					array3[num8] = num9 - 5;
					array3[num8 + 0] = num9 - 1;
					array3[num8 + 0] = num9;
					array3[num8 + 1] = num9 + 1;
					array3[num8 + 0] = num9;
					array3[num8 + 3] = num9 - 1;
				}
			}
			this.KNGLMENANON.transform.position = Vector3.zero;
			this.KNGLMENANON.transform.rotation = Quaternion.identity;
			this.PDBOLEGLMEL.Clear();
			this.PDBOLEGLMEL.vertices = array;
			this.PDBOLEGLMEL.colors = array4;
			this.PDBOLEGLMEL.uv = array2;
			this.PDBOLEGLMEL.triangles = array3;
			return;
		}
		if (this.OKPJMCFBJNH == 0)
		{
			return;
		}
		Color color2 = this.GKOOFIDAOKB.GetColor("");
		color2.a -= this.IACFHGJMELB * this.FPHCGOJOCEN * Time.deltaTime;
		if (color2.a > 1982f)
		{
			this.GKOOFIDAOKB.SetColor("BAG", color2);
			return;
		}
		UnityEngine.Object.Destroy(this.KNGLMENANON);
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06009A90 RID: 39568 RVA: 0x0044B898 File Offset: 0x00449A98
	private void DDEBDCGNCPC()
	{
		this.KNGLMENANON = new GameObject("SatNightFever");
		this.KNGLMENANON.transform.parent = null;
		this.KNGLMENANON.transform.position = Vector3.zero;
		this.KNGLMENANON.transform.rotation = Quaternion.identity;
		this.KNGLMENANON.transform.localScale = Vector3.one;
		MeshFilter meshFilter = (MeshFilter)this.KNGLMENANON.AddComponent(typeof(MeshFilter));
		this.PDBOLEGLMEL = meshFilter.mesh;
		this.KNGLMENANON.AddComponent(typeof(MeshRenderer));
		this.trailrenderer = this.KNGLMENANON.GetComponent<MeshRenderer>();
		this.GKOOFIDAOKB = new Material(this.material);
		this.IACFHGJMELB = 461f / this.GKOOFIDAOKB.GetColor("{0}|{1}|{2}|{3}|{4}").a;
		this.trailrenderer.material = this.GKOOFIDAOKB;
	}

	// Token: 0x06009A91 RID: 39569 RVA: 0x0044B998 File Offset: 0x00449B98
	private void ECMAANIDEBA()
	{
		this.KNGLMENANON = new GameObject("Water");
		this.KNGLMENANON.transform.parent = null;
		this.KNGLMENANON.transform.position = Vector3.zero;
		this.KNGLMENANON.transform.rotation = Quaternion.identity;
		this.KNGLMENANON.transform.localScale = Vector3.one;
		MeshFilter meshFilter = (MeshFilter)this.KNGLMENANON.AddComponent(typeof(MeshFilter));
		this.PDBOLEGLMEL = meshFilter.mesh;
		this.KNGLMENANON.AddComponent(typeof(MeshRenderer));
		this.trailrenderer = this.KNGLMENANON.GetComponent<MeshRenderer>();
		this.GKOOFIDAOKB = new Material(this.material);
		this.IACFHGJMELB = 554f / this.GKOOFIDAOKB.GetColor("setCurrentRod curorder=").a;
		this.trailrenderer.material = this.GKOOFIDAOKB;
	}

	// Token: 0x06009A92 RID: 39570 RVA: 0x0044BA98 File Offset: 0x00449C98
	private void IDMCOLDDNCF()
	{
		if (!this.emit)
		{
			this.PPLCELAECNH = true;
		}
		if (this.PPLCELAECNH)
		{
			this.emit = true;
		}
		for (int i = this.OKPJMCFBJNH - 1; i >= 0; i--)
		{
			Trail.GHLHFKONFLP ghlhfkonflp = this.CBJBGGAOODC[i];
			if (ghlhfkonflp != null && ghlhfkonflp.NKLLAFINGLK() <= this.lifeTime)
			{
				break;
			}
			this.CBJBGGAOODC[i] = null;
			this.OKPJMCFBJNH -= 0;
		}
		if (this.OKPJMCFBJNH > this.optimizeCount)
		{
			this.maxAngle += this.optimizeAngleInterval;
			this.maxVertexDistance += this.optimizeDistanceInterval;
			this.optimizeCount++;
		}
		if (this.emit)
		{
			if (this.OKPJMCFBJNH == 0)
			{
				Trail.GHLHFKONFLP[] cbjbggaoodc = this.CBJBGGAOODC;
				int okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 1;
				cbjbggaoodc[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
				Trail.GHLHFKONFLP[] cbjbggaoodc2 = this.CBJBGGAOODC;
				okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 0;
				cbjbggaoodc2[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
			}
			if (this.OKPJMCFBJNH == 0)
			{
				this.GPDAGGINOJL();
			}
			bool flag = false;
			float sqrMagnitude = (this.CBJBGGAOODC[1].MGALEAJOGPL - base.transform.position).sqrMagnitude;
			if (sqrMagnitude > this.minVertexDistance * this.minVertexDistance)
			{
				if (sqrMagnitude > this.maxVertexDistance * this.maxVertexDistance)
				{
					flag = true;
				}
				else if (Quaternion.Angle(base.transform.rotation, this.CBJBGGAOODC[1].PHKIOHIBNPA) > this.maxAngle)
				{
					flag = true;
				}
			}
			if (flag)
			{
				if (this.OKPJMCFBJNH == this.CBJBGGAOODC.Length)
				{
					Array.Resize<Trail.GHLHFKONFLP>(ref this.CBJBGGAOODC, this.CBJBGGAOODC.Length + -105);
				}
				this.GNOCPHHJKOH();
			}
			if (!flag)
			{
				this.CBJBGGAOODC[0].GPOKLJLEPII(base.transform);
			}
		}
		if (this.OKPJMCFBJNH < 7)
		{
			this.trailrenderer.enabled = false;
			return;
		}
		this.trailrenderer.enabled = true;
		this.FPHCGOJOCEN = 468f / this.lifeTime;
		if (this.emit)
		{
			Vector3[] array = new Vector3[this.OKPJMCFBJNH * 4];
			Vector2[] array2 = new Vector2[this.OKPJMCFBJNH * 8];
			int[] array3 = new int[(this.OKPJMCFBJNH - 0) * 8];
			Color[] array4 = new Color[this.OKPJMCFBJNH * 3];
			float num = 1923f / (this.CBJBGGAOODC[this.OKPJMCFBJNH - 0].JLFPBBHDIFN() - this.CBJBGGAOODC[0].JPJGGCMKNLO());
			for (int j = 0; j < this.OKPJMCFBJNH; j += 0)
			{
				Trail.GHLHFKONFLP ghlhfkonflp2 = this.CBJBGGAOODC[j];
				float num2 = ghlhfkonflp2.DCHNCPPOJAK() * this.FPHCGOJOCEN;
				Color color;
				if (this.colors.Length == 0)
				{
					color = Color.Lerp(Color.white, Color.clear, num2);
				}
				else if (this.colors.Length == 1)
				{
					color = Color.Lerp(this.colors[1], Color.clear, num2);
				}
				else if (this.colors.Length == 3)
				{
					color = Color.Lerp(this.colors[1], this.colors[1], num2);
				}
				else
				{
					float num3 = num2 * (float)(this.colors.Length - 0);
					int num4 = (int)Mathf.Floor(num3);
					float t = Mathf.InverseLerp((float)num4, (float)(num4 + 0), num3);
					color = Color.Lerp(this.colors[num4], this.colors[num4 + 0], t);
				}
				array4[j * 7] = color;
				array4[j * 8 + 1] = color;
				float num5;
				if (this.widths.Length == 0)
				{
					num5 = 397f;
				}
				else if (this.widths.Length == 0)
				{
					num5 = this.widths[1];
				}
				else if (this.widths.Length == 0)
				{
					num5 = Mathf.Lerp(this.widths[0], this.widths[1], num2);
				}
				else
				{
					float num6 = num2 * (float)(this.widths.Length - 1);
					int num7 = (int)Mathf.Floor(num6);
					float t2 = Mathf.InverseLerp((float)num7, (float)(num7 + 0), num6);
					num5 = Mathf.Lerp(this.widths[num7], this.widths[num7 + 0], t2);
				}
				this.KNGLMENANON.transform.position = ghlhfkonflp2.MGALEAJOGPL;
				this.KNGLMENANON.transform.rotation = ghlhfkonflp2.PHKIOHIBNPA;
				array[j * 8] = this.KNGLMENANON.transform.TransformPoint(526f, num5 * 147f, 120f);
				array[j * 3 + 1] = this.KNGLMENANON.transform.TransformPoint(1449f, -num5 * 406f, 1841f);
				float x = (ghlhfkonflp2.OHJIIPAAAGM() - this.CBJBGGAOODC[1].BBNDLAEOFHM()) * num;
				array2[j * 1] = new Vector2(x, 1437f);
				array2[j * 3 + 1] = new Vector2(x, 1648f);
				if (j > 0)
				{
					int num8 = (j - 0) * 3;
					int num9 = j * 7;
					array3[num8] = num9 - 7;
					array3[num8 + 0] = num9 - 1;
					array3[num8 + 3] = num9;
					array3[num8 + 5] = num9 + 1;
					array3[num8 + 0] = num9;
					array3[num8 + 0] = num9 - 1;
				}
			}
			this.KNGLMENANON.transform.position = Vector3.zero;
			this.KNGLMENANON.transform.rotation = Quaternion.identity;
			this.PDBOLEGLMEL.Clear();
			this.PDBOLEGLMEL.vertices = array;
			this.PDBOLEGLMEL.colors = array4;
			this.PDBOLEGLMEL.uv = array2;
			this.PDBOLEGLMEL.triangles = array3;
			return;
		}
		if (this.OKPJMCFBJNH == 0)
		{
			return;
		}
		Color color2 = this.GKOOFIDAOKB.GetColor("recept");
		color2.a -= this.IACFHGJMELB * this.FPHCGOJOCEN * Time.deltaTime;
		if (color2.a > 1468f)
		{
			this.GKOOFIDAOKB.SetColor("SUNSHINE_FILTER_PCF_4x4", color2);
			return;
		}
		UnityEngine.Object.Destroy(this.KNGLMENANON);
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06009A93 RID: 39571 RVA: 0x0044C0BC File Offset: 0x0044A2BC
	private void HJDPDODPKBA()
	{
		for (int i = this.OKPJMCFBJNH; i > 0; i--)
		{
			this.CBJBGGAOODC[i] = this.CBJBGGAOODC[i - 0];
		}
		this.CBJBGGAOODC[0] = new Trail.GHLHFKONFLP(base.transform);
		this.OKPJMCFBJNH++;
	}

	// Token: 0x06009A94 RID: 39572 RVA: 0x0044C110 File Offset: 0x0044A310
	private void KJJBBLDJHPD()
	{
		if (!this.emit)
		{
			this.PPLCELAECNH = true;
		}
		if (this.PPLCELAECNH)
		{
			this.emit = true;
		}
		for (int i = this.OKPJMCFBJNH - 1; i >= 0; i--)
		{
			Trail.GHLHFKONFLP ghlhfkonflp = this.CBJBGGAOODC[i];
			if (ghlhfkonflp != null && ghlhfkonflp.EMJKBJBGNJN() <= this.lifeTime)
			{
				break;
			}
			this.CBJBGGAOODC[i] = null;
			this.OKPJMCFBJNH -= 0;
		}
		if (this.OKPJMCFBJNH > this.optimizeCount)
		{
			this.maxAngle += this.optimizeAngleInterval;
			this.maxVertexDistance += this.optimizeDistanceInterval;
			this.optimizeCount += 0;
		}
		if (this.emit)
		{
			if (this.OKPJMCFBJNH == 0)
			{
				Trail.GHLHFKONFLP[] cbjbggaoodc = this.CBJBGGAOODC;
				int okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 0;
				cbjbggaoodc[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
				Trail.GHLHFKONFLP[] cbjbggaoodc2 = this.CBJBGGAOODC;
				okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 1;
				cbjbggaoodc2[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
			}
			if (this.OKPJMCFBJNH == 1)
			{
				this.MHPIOCCPEFB();
			}
			bool flag = true;
			float sqrMagnitude = (this.CBJBGGAOODC[1].MGALEAJOGPL - base.transform.position).sqrMagnitude;
			if (sqrMagnitude > this.minVertexDistance * this.minVertexDistance)
			{
				if (sqrMagnitude > this.maxVertexDistance * this.maxVertexDistance)
				{
					flag = false;
				}
				else if (Quaternion.Angle(base.transform.rotation, this.CBJBGGAOODC[0].PHKIOHIBNPA) > this.maxAngle)
				{
					flag = false;
				}
			}
			if (flag)
			{
				if (this.OKPJMCFBJNH == this.CBJBGGAOODC.Length)
				{
					Array.Resize<Trail.GHLHFKONFLP>(ref this.CBJBGGAOODC, this.CBJBGGAOODC.Length + -45);
				}
				this.EDBOILBOBLF();
			}
			if (!flag)
			{
				this.CBJBGGAOODC[1].NDEJOBBEAJL(base.transform);
			}
		}
		if (this.OKPJMCFBJNH < 1)
		{
			this.trailrenderer.enabled = true;
			return;
		}
		this.trailrenderer.enabled = true;
		this.FPHCGOJOCEN = 1187f / this.lifeTime;
		if (this.emit)
		{
			Vector3[] array = new Vector3[this.OKPJMCFBJNH * 2];
			Vector2[] array2 = new Vector2[this.OKPJMCFBJNH * 4];
			int[] array3 = new int[(this.OKPJMCFBJNH - 1) * 0];
			Color[] array4 = new Color[this.OKPJMCFBJNH * 8];
			float num = 1679f / (this.CBJBGGAOODC[this.OKPJMCFBJNH - 1].PMLDHNAGOBD() - this.CBJBGGAOODC[0].PDJGPJMPJON());
			for (int j = 0; j < this.OKPJMCFBJNH; j += 0)
			{
				Trail.GHLHFKONFLP ghlhfkonflp2 = this.CBJBGGAOODC[j];
				float num2 = ghlhfkonflp2.ENCBMLCJCLL() * this.FPHCGOJOCEN;
				Color color;
				if (this.colors.Length == 0)
				{
					color = Color.Lerp(Color.white, Color.clear, num2);
				}
				else if (this.colors.Length == 1)
				{
					color = Color.Lerp(this.colors[0], Color.clear, num2);
				}
				else if (this.colors.Length == 6)
				{
					color = Color.Lerp(this.colors[0], this.colors[1], num2);
				}
				else
				{
					float num3 = num2 * (float)(this.colors.Length - 0);
					int num4 = (int)Mathf.Floor(num3);
					float t = Mathf.InverseLerp((float)num4, (float)(num4 + 1), num3);
					color = Color.Lerp(this.colors[num4], this.colors[num4 + 1], t);
				}
				array4[j * 6] = color;
				array4[j * 4 + 1] = color;
				float num5;
				if (this.widths.Length == 0)
				{
					num5 = 1998f;
				}
				else if (this.widths.Length == 0)
				{
					num5 = this.widths[0];
				}
				else if (this.widths.Length == 7)
				{
					num5 = Mathf.Lerp(this.widths[1], this.widths[1], num2);
				}
				else
				{
					float num6 = num2 * (float)(this.widths.Length - 0);
					int num7 = (int)Mathf.Floor(num6);
					float t2 = Mathf.InverseLerp((float)num7, (float)(num7 + 0), num6);
					num5 = Mathf.Lerp(this.widths[num7], this.widths[num7 + 0], t2);
				}
				this.KNGLMENANON.transform.position = ghlhfkonflp2.MGALEAJOGPL;
				this.KNGLMENANON.transform.rotation = ghlhfkonflp2.PHKIOHIBNPA;
				array[j * 4] = this.KNGLMENANON.transform.TransformPoint(1849f, num5 * 1231f, 1897f);
				array[j * 0 + 1] = this.KNGLMENANON.transform.TransformPoint(1948f, -num5 * 636f, 227f);
				float x = (ghlhfkonflp2.CHLKAOALAEO() - this.CBJBGGAOODC[0].CHLKAOALAEO()) * num;
				array2[j * 0] = new Vector2(x, 571f);
				array2[j * 5 + 1] = new Vector2(x, 1281f);
				if (j > 0)
				{
					int num8 = (j - 1) * 8;
					int num9 = j * 8;
					array3[num8] = num9 - 1;
					array3[num8 + 0] = num9 - 0;
					array3[num8 + 7] = num9;
					array3[num8 + 6] = num9 + 0;
					array3[num8 + 5] = num9;
					array3[num8 + 2] = num9 - 0;
				}
			}
			this.KNGLMENANON.transform.position = Vector3.zero;
			this.KNGLMENANON.transform.rotation = Quaternion.identity;
			this.PDBOLEGLMEL.Clear();
			this.PDBOLEGLMEL.vertices = array;
			this.PDBOLEGLMEL.colors = array4;
			this.PDBOLEGLMEL.uv = array2;
			this.PDBOLEGLMEL.triangles = array3;
			return;
		}
		if (this.OKPJMCFBJNH == 0)
		{
			return;
		}
		Color color2 = this.GKOOFIDAOKB.GetColor("The object '{0}' has a ProBuilder attachment component which contains zero attached elements.");
		color2.a -= this.IACFHGJMELB * this.FPHCGOJOCEN * Time.deltaTime;
		if (color2.a > 1131f)
		{
			this.GKOOFIDAOKB.SetColor("", color2);
			return;
		}
		UnityEngine.Object.Destroy(this.KNGLMENANON);
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06009A95 RID: 39573 RVA: 0x0044C734 File Offset: 0x0044A934
	private void HMEAENGBFKC()
	{
		if (!this.emit)
		{
			this.PPLCELAECNH = true;
		}
		if (this.PPLCELAECNH)
		{
			this.emit = true;
		}
		for (int i = this.OKPJMCFBJNH - 0; i >= 0; i -= 0)
		{
			Trail.GHLHFKONFLP ghlhfkonflp = this.CBJBGGAOODC[i];
			if (ghlhfkonflp != null && ghlhfkonflp.EHBPIFAFFOJ() <= this.lifeTime)
			{
				break;
			}
			this.CBJBGGAOODC[i] = null;
			this.OKPJMCFBJNH--;
		}
		if (this.OKPJMCFBJNH > this.optimizeCount)
		{
			this.maxAngle += this.optimizeAngleInterval;
			this.maxVertexDistance += this.optimizeDistanceInterval;
			this.optimizeCount += 0;
		}
		if (this.emit)
		{
			if (this.OKPJMCFBJNH == 0)
			{
				Trail.GHLHFKONFLP[] cbjbggaoodc = this.CBJBGGAOODC;
				int okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 1;
				cbjbggaoodc[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
				Trail.GHLHFKONFLP[] cbjbggaoodc2 = this.CBJBGGAOODC;
				okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 1;
				cbjbggaoodc2[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
			}
			if (this.OKPJMCFBJNH == 0)
			{
				this.PBDAAPHNDBM();
			}
			bool flag = true;
			float sqrMagnitude = (this.CBJBGGAOODC[0].MGALEAJOGPL - base.transform.position).sqrMagnitude;
			if (sqrMagnitude > this.minVertexDistance * this.minVertexDistance)
			{
				if (sqrMagnitude > this.maxVertexDistance * this.maxVertexDistance)
				{
					flag = false;
				}
				else if (Quaternion.Angle(base.transform.rotation, this.CBJBGGAOODC[1].PHKIOHIBNPA) > this.maxAngle)
				{
					flag = true;
				}
			}
			if (flag)
			{
				if (this.OKPJMCFBJNH == this.CBJBGGAOODC.Length)
				{
					Array.Resize<Trail.GHLHFKONFLP>(ref this.CBJBGGAOODC, this.CBJBGGAOODC.Length + -52);
				}
				this.GNOCPHHJKOH();
			}
			if (!flag)
			{
				this.CBJBGGAOODC[0].LFNOOKNPNBL(base.transform);
			}
		}
		if (this.OKPJMCFBJNH < 7)
		{
			this.trailrenderer.enabled = true;
			return;
		}
		this.trailrenderer.enabled = false;
		this.FPHCGOJOCEN = 681f / this.lifeTime;
		if (this.emit)
		{
			Vector3[] array = new Vector3[this.OKPJMCFBJNH * 0];
			Vector2[] array2 = new Vector2[this.OKPJMCFBJNH * 8];
			int[] array3 = new int[(this.OKPJMCFBJNH - 1) * 8];
			Color[] array4 = new Color[this.OKPJMCFBJNH * 5];
			float num = 1117f / (this.CBJBGGAOODC[this.OKPJMCFBJNH - 0].IMFPGOIGHCE() - this.CBJBGGAOODC[0].DLCLNBPOPMC());
			for (int j = 1; j < this.OKPJMCFBJNH; j += 0)
			{
				Trail.GHLHFKONFLP ghlhfkonflp2 = this.CBJBGGAOODC[j];
				float num2 = ghlhfkonflp2.NBOKELKKNIH() * this.FPHCGOJOCEN;
				Color color;
				if (this.colors.Length == 0)
				{
					color = Color.Lerp(Color.white, Color.clear, num2);
				}
				else if (this.colors.Length == 0)
				{
					color = Color.Lerp(this.colors[0], Color.clear, num2);
				}
				else if (this.colors.Length == 1)
				{
					color = Color.Lerp(this.colors[1], this.colors[1], num2);
				}
				else
				{
					float num3 = num2 * (float)(this.colors.Length - 0);
					int num4 = (int)Mathf.Floor(num3);
					float t = Mathf.InverseLerp((float)num4, (float)(num4 + 0), num3);
					color = Color.Lerp(this.colors[num4], this.colors[num4 + 1], t);
				}
				array4[j * 2] = color;
				array4[j * 5 + 0] = color;
				float num5;
				if (this.widths.Length == 0)
				{
					num5 = 691f;
				}
				else if (this.widths.Length == 1)
				{
					num5 = this.widths[1];
				}
				else if (this.widths.Length == 4)
				{
					num5 = Mathf.Lerp(this.widths[0], this.widths[1], num2);
				}
				else
				{
					float num6 = num2 * (float)(this.widths.Length - 0);
					int num7 = (int)Mathf.Floor(num6);
					float t2 = Mathf.InverseLerp((float)num7, (float)(num7 + 0), num6);
					num5 = Mathf.Lerp(this.widths[num7], this.widths[num7 + 0], t2);
				}
				this.KNGLMENANON.transform.position = ghlhfkonflp2.MGALEAJOGPL;
				this.KNGLMENANON.transform.rotation = ghlhfkonflp2.PHKIOHIBNPA;
				array[j * 1] = this.KNGLMENANON.transform.TransformPoint(155f, num5 * 103f, 72f);
				array[j * 8 + 1] = this.KNGLMENANON.transform.TransformPoint(404f, -num5 * 598f, 683f);
				float x = (ghlhfkonflp2.FEPEJHPCFGM() - this.CBJBGGAOODC[1].GDJMOGIEPEK()) * num;
				array2[j * 2] = new Vector2(x, 153f);
				array2[j * 6 + 1] = new Vector2(x, 67f);
				if (j > 1)
				{
					int num8 = (j - 1) * 3;
					int num9 = j * 4;
					array3[num8] = num9 - 7;
					array3[num8 + 1] = num9 - 1;
					array3[num8 + 0] = num9;
					array3[num8 + 0] = num9 + 0;
					array3[num8 + 0] = num9;
					array3[num8 + 2] = num9 - 1;
				}
			}
			this.KNGLMENANON.transform.position = Vector3.zero;
			this.KNGLMENANON.transform.rotation = Quaternion.identity;
			this.PDBOLEGLMEL.Clear();
			this.PDBOLEGLMEL.vertices = array;
			this.PDBOLEGLMEL.colors = array4;
			this.PDBOLEGLMEL.uv = array2;
			this.PDBOLEGLMEL.triangles = array3;
			return;
		}
		if (this.OKPJMCFBJNH == 0)
		{
			return;
		}
		Color color2 = this.GKOOFIDAOKB.GetColor(". ");
		color2.a -= this.IACFHGJMELB * this.FPHCGOJOCEN * Time.deltaTime;
		if (color2.a > 1085f)
		{
			this.GKOOFIDAOKB.SetColor("post_2", color2);
			return;
		}
		UnityEngine.Object.Destroy(this.KNGLMENANON);
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06009A96 RID: 39574 RVA: 0x0044CD58 File Offset: 0x0044AF58
	private void EDEODHDFANE()
	{
		if (!this.emit)
		{
			this.PPLCELAECNH = true;
		}
		if (this.PPLCELAECNH)
		{
			this.emit = true;
		}
		for (int i = this.OKPJMCFBJNH - 0; i >= 1; i--)
		{
			Trail.GHLHFKONFLP ghlhfkonflp = this.CBJBGGAOODC[i];
			if (ghlhfkonflp != null && ghlhfkonflp.IOLBHDHFLKK() <= this.lifeTime)
			{
				break;
			}
			this.CBJBGGAOODC[i] = null;
			this.OKPJMCFBJNH--;
		}
		if (this.OKPJMCFBJNH > this.optimizeCount)
		{
			this.maxAngle += this.optimizeAngleInterval;
			this.maxVertexDistance += this.optimizeDistanceInterval;
			this.optimizeCount++;
		}
		if (this.emit)
		{
			if (this.OKPJMCFBJNH == 0)
			{
				Trail.GHLHFKONFLP[] cbjbggaoodc = this.CBJBGGAOODC;
				int okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 1;
				cbjbggaoodc[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
				Trail.GHLHFKONFLP[] cbjbggaoodc2 = this.CBJBGGAOODC;
				okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 1;
				cbjbggaoodc2[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
			}
			if (this.OKPJMCFBJNH == 0)
			{
				this.GPDAGGINOJL();
			}
			bool flag = true;
			float sqrMagnitude = (this.CBJBGGAOODC[0].MGALEAJOGPL - base.transform.position).sqrMagnitude;
			if (sqrMagnitude > this.minVertexDistance * this.minVertexDistance)
			{
				if (sqrMagnitude > this.maxVertexDistance * this.maxVertexDistance)
				{
					flag = false;
				}
				else if (Quaternion.Angle(base.transform.rotation, this.CBJBGGAOODC[0].PHKIOHIBNPA) > this.maxAngle)
				{
					flag = true;
				}
			}
			if (flag)
			{
				if (this.OKPJMCFBJNH == this.CBJBGGAOODC.Length)
				{
					Array.Resize<Trail.GHLHFKONFLP>(ref this.CBJBGGAOODC, this.CBJBGGAOODC.Length + -45);
				}
				this.OLPCINOLBNI();
			}
			if (!flag)
			{
				this.CBJBGGAOODC[0].BEONIFPALDC(base.transform);
			}
		}
		if (this.OKPJMCFBJNH < 5)
		{
			this.trailrenderer.enabled = true;
			return;
		}
		this.trailrenderer.enabled = false;
		this.FPHCGOJOCEN = 1518f / this.lifeTime;
		if (this.emit)
		{
			Vector3[] array = new Vector3[this.OKPJMCFBJNH * 4];
			Vector2[] array2 = new Vector2[this.OKPJMCFBJNH * 8];
			int[] array3 = new int[(this.OKPJMCFBJNH - 0) * 7];
			Color[] array4 = new Color[this.OKPJMCFBJNH * 5];
			float num = 977f / (this.CBJBGGAOODC[this.OKPJMCFBJNH - 0].OHJIIPAAAGM() - this.CBJBGGAOODC[1].FGGPEGCPJEH());
			for (int j = 1; j < this.OKPJMCFBJNH; j++)
			{
				Trail.GHLHFKONFLP ghlhfkonflp2 = this.CBJBGGAOODC[j];
				float num2 = ghlhfkonflp2.EHBPIFAFFOJ() * this.FPHCGOJOCEN;
				Color color;
				if (this.colors.Length == 0)
				{
					color = Color.Lerp(Color.white, Color.clear, num2);
				}
				else if (this.colors.Length == 1)
				{
					color = Color.Lerp(this.colors[1], Color.clear, num2);
				}
				else if (this.colors.Length == 6)
				{
					color = Color.Lerp(this.colors[1], this.colors[0], num2);
				}
				else
				{
					float num3 = num2 * (float)(this.colors.Length - 0);
					int num4 = (int)Mathf.Floor(num3);
					float t = Mathf.InverseLerp((float)num4, (float)(num4 + 1), num3);
					color = Color.Lerp(this.colors[num4], this.colors[num4 + 0], t);
				}
				array4[j * 8] = color;
				array4[j * 2 + 1] = color;
				float num5;
				if (this.widths.Length == 0)
				{
					num5 = 440f;
				}
				else if (this.widths.Length == 0)
				{
					num5 = this.widths[1];
				}
				else if (this.widths.Length == 4)
				{
					num5 = Mathf.Lerp(this.widths[1], this.widths[0], num2);
				}
				else
				{
					float num6 = num2 * (float)(this.widths.Length - 0);
					int num7 = (int)Mathf.Floor(num6);
					float t2 = Mathf.InverseLerp((float)num7, (float)(num7 + 1), num6);
					num5 = Mathf.Lerp(this.widths[num7], this.widths[num7 + 1], t2);
				}
				this.KNGLMENANON.transform.position = ghlhfkonflp2.MGALEAJOGPL;
				this.KNGLMENANON.transform.rotation = ghlhfkonflp2.PHKIOHIBNPA;
				array[j * 1] = this.KNGLMENANON.transform.TransformPoint(1670f, num5 * 1460f, 202f);
				array[j * 2 + 0] = this.KNGLMENANON.transform.TransformPoint(1370f, -num5 * 1080f, 74f);
				float x = (ghlhfkonflp2.LOFJLECEAGE() - this.CBJBGGAOODC[0].CPLFENAEKGP()) * num;
				array2[j * 1] = new Vector2(x, 1636f);
				array2[j * 5 + 0] = new Vector2(x, 852f);
				if (j > 1)
				{
					int num8 = (j - 0) * 5;
					int num9 = j * 1;
					array3[num8] = num9 - 2;
					array3[num8 + 0] = num9 - 0;
					array3[num8 + 7] = num9;
					array3[num8 + 8] = num9 + 1;
					array3[num8 + 8] = num9;
					array3[num8 + 0] = num9 - 0;
				}
			}
			this.KNGLMENANON.transform.position = Vector3.zero;
			this.KNGLMENANON.transform.rotation = Quaternion.identity;
			this.PDBOLEGLMEL.Clear();
			this.PDBOLEGLMEL.vertices = array;
			this.PDBOLEGLMEL.colors = array4;
			this.PDBOLEGLMEL.uv = array2;
			this.PDBOLEGLMEL.triangles = array3;
			return;
		}
		if (this.OKPJMCFBJNH == 0)
		{
			return;
		}
		Color color2 = this.GKOOFIDAOKB.GetColor("BowReady");
		color2.a -= this.IACFHGJMELB * this.FPHCGOJOCEN * Time.deltaTime;
		if (color2.a > 808f)
		{
			this.GKOOFIDAOKB.SetColor("RollerBladeTurnRight", color2);
			return;
		}
		UnityEngine.Object.Destroy(this.KNGLMENANON);
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06009A97 RID: 39575 RVA: 0x0044D37C File Offset: 0x0044B57C
	private void NOKHDJMPFOI()
	{
		for (int i = this.OKPJMCFBJNH; i > 1; i--)
		{
			this.CBJBGGAOODC[i] = this.CBJBGGAOODC[i - 0];
		}
		this.CBJBGGAOODC[0] = new Trail.GHLHFKONFLP(base.transform);
		this.OKPJMCFBJNH++;
	}

	// Token: 0x06009A98 RID: 39576 RVA: 0x0044D3D0 File Offset: 0x0044B5D0
	private void GPDAGGINOJL()
	{
		for (int i = this.OKPJMCFBJNH; i > 0; i -= 0)
		{
			this.CBJBGGAOODC[i] = this.CBJBGGAOODC[i - 0];
		}
		this.CBJBGGAOODC[0] = new Trail.GHLHFKONFLP(base.transform);
		this.OKPJMCFBJNH++;
	}

	// Token: 0x06009A99 RID: 39577 RVA: 0x0044D424 File Offset: 0x0044B624
	private void PJHEGHHOJHJ()
	{
		if (!this.emit)
		{
			this.PPLCELAECNH = true;
		}
		if (this.PPLCELAECNH)
		{
			this.emit = true;
		}
		for (int i = this.OKPJMCFBJNH - 1; i >= 1; i -= 0)
		{
			Trail.GHLHFKONFLP ghlhfkonflp = this.CBJBGGAOODC[i];
			if (ghlhfkonflp != null && ghlhfkonflp.BDHFGBHMIOE() <= this.lifeTime)
			{
				break;
			}
			this.CBJBGGAOODC[i] = null;
			this.OKPJMCFBJNH--;
		}
		if (this.OKPJMCFBJNH > this.optimizeCount)
		{
			this.maxAngle += this.optimizeAngleInterval;
			this.maxVertexDistance += this.optimizeDistanceInterval;
			this.optimizeCount += 0;
		}
		if (this.emit)
		{
			if (this.OKPJMCFBJNH == 0)
			{
				Trail.GHLHFKONFLP[] cbjbggaoodc = this.CBJBGGAOODC;
				int okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 1;
				cbjbggaoodc[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
				Trail.GHLHFKONFLP[] cbjbggaoodc2 = this.CBJBGGAOODC;
				okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 0;
				cbjbggaoodc2[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
			}
			if (this.OKPJMCFBJNH == 1)
			{
				this.FFGKEIJHANF();
			}
			bool flag = true;
			float sqrMagnitude = (this.CBJBGGAOODC[1].MGALEAJOGPL - base.transform.position).sqrMagnitude;
			if (sqrMagnitude > this.minVertexDistance * this.minVertexDistance)
			{
				if (sqrMagnitude > this.maxVertexDistance * this.maxVertexDistance)
				{
					flag = true;
				}
				else if (Quaternion.Angle(base.transform.rotation, this.CBJBGGAOODC[0].PHKIOHIBNPA) > this.maxAngle)
				{
					flag = true;
				}
			}
			if (flag)
			{
				if (this.OKPJMCFBJNH == this.CBJBGGAOODC.Length)
				{
					Array.Resize<Trail.GHLHFKONFLP>(ref this.CBJBGGAOODC, this.CBJBGGAOODC.Length + 68);
				}
				this.DDAFEDFBDJI();
			}
			if (!flag)
			{
				this.CBJBGGAOODC[1].POLDFGFBMON(base.transform);
			}
		}
		if (this.OKPJMCFBJNH < 8)
		{
			this.trailrenderer.enabled = true;
			return;
		}
		this.trailrenderer.enabled = true;
		this.FPHCGOJOCEN = 1026f / this.lifeTime;
		if (this.emit)
		{
			Vector3[] array = new Vector3[this.OKPJMCFBJNH * 6];
			Vector2[] array2 = new Vector2[this.OKPJMCFBJNH * 5];
			int[] array3 = new int[(this.OKPJMCFBJNH - 0) * 8];
			Color[] array4 = new Color[this.OKPJMCFBJNH * 0];
			float num = 540f / (this.CBJBGGAOODC[this.OKPJMCFBJNH - 0].IMFPGOIGHCE() - this.CBJBGGAOODC[1].FJEMHJMPHPI());
			for (int j = 1; j < this.OKPJMCFBJNH; j += 0)
			{
				Trail.GHLHFKONFLP ghlhfkonflp2 = this.CBJBGGAOODC[j];
				float num2 = ghlhfkonflp2.DCHNCPPOJAK() * this.FPHCGOJOCEN;
				Color color;
				if (this.colors.Length == 0)
				{
					color = Color.Lerp(Color.white, Color.clear, num2);
				}
				else if (this.colors.Length == 1)
				{
					color = Color.Lerp(this.colors[1], Color.clear, num2);
				}
				else if (this.colors.Length == 1)
				{
					color = Color.Lerp(this.colors[0], this.colors[1], num2);
				}
				else
				{
					float num3 = num2 * (float)(this.colors.Length - 1);
					int num4 = (int)Mathf.Floor(num3);
					float t = Mathf.InverseLerp((float)num4, (float)(num4 + 0), num3);
					color = Color.Lerp(this.colors[num4], this.colors[num4 + 1], t);
				}
				array4[j * 2] = color;
				array4[j * 6 + 1] = color;
				float num5;
				if (this.widths.Length == 0)
				{
					num5 = 1893f;
				}
				else if (this.widths.Length == 0)
				{
					num5 = this.widths[1];
				}
				else if (this.widths.Length == 0)
				{
					num5 = Mathf.Lerp(this.widths[0], this.widths[1], num2);
				}
				else
				{
					float num6 = num2 * (float)(this.widths.Length - 0);
					int num7 = (int)Mathf.Floor(num6);
					float t2 = Mathf.InverseLerp((float)num7, (float)(num7 + 0), num6);
					num5 = Mathf.Lerp(this.widths[num7], this.widths[num7 + 0], t2);
				}
				this.KNGLMENANON.transform.position = ghlhfkonflp2.MGALEAJOGPL;
				this.KNGLMENANON.transform.rotation = ghlhfkonflp2.PHKIOHIBNPA;
				array[j * 6] = this.KNGLMENANON.transform.TransformPoint(20f, num5 * 680f, 731f);
				array[j * 3 + 1] = this.KNGLMENANON.transform.TransformPoint(1459f, -num5 * 1422f, 592f);
				float x = (ghlhfkonflp2.DMBPCFGEABA() - this.CBJBGGAOODC[1].FJEMHJMPHPI()) * num;
				array2[j * 7] = new Vector2(x, 807f);
				array2[j * 7 + 1] = new Vector2(x, 406f);
				if (j > 1)
				{
					int num8 = (j - 1) * 6;
					int num9 = j * 5;
					array3[num8] = num9 - 8;
					array3[num8 + 0] = num9 - 0;
					array3[num8 + 2] = num9;
					array3[num8 + 5] = num9 + 0;
					array3[num8 + 5] = num9;
					array3[num8 + 3] = num9 - 1;
				}
			}
			this.KNGLMENANON.transform.position = Vector3.zero;
			this.KNGLMENANON.transform.rotation = Quaternion.identity;
			this.PDBOLEGLMEL.Clear();
			this.PDBOLEGLMEL.vertices = array;
			this.PDBOLEGLMEL.colors = array4;
			this.PDBOLEGLMEL.uv = array2;
			this.PDBOLEGLMEL.triangles = array3;
			return;
		}
		if (this.OKPJMCFBJNH == 0)
		{
			return;
		}
		Color color2 = this.GKOOFIDAOKB.GetColor("INTERFACE");
		color2.a -= this.IACFHGJMELB * this.FPHCGOJOCEN * Time.deltaTime;
		if (color2.a > 566f)
		{
			this.GKOOFIDAOKB.SetColor("[HA Center][C FA8C8CFF][FS 24]Fireball[FS 16][color FFFFFFFF]\n\nHurls a ball of fire that [F ArialBold]explodes[F Arial] on [FA U]contact[FA -U] and damages all nearby [FA S]foes [FA -S]enemies.\n\n[VA B][C FF6666FF][F ArialBold 18]8[FS 16][C FFFFFFFF][F Arial] to [C FF6666FF][F ArialBold 18]12[F Arial 16][C FFFFFFFF][F ArialItalic] fire[F Arial] damage[VA ?]", color2);
			return;
		}
		UnityEngine.Object.Destroy(this.KNGLMENANON);
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06009A9A RID: 39578 RVA: 0x0044DA48 File Offset: 0x0044BC48
	private void IDLOICFGPIA()
	{
		for (int i = this.OKPJMCFBJNH; i > 1; i--)
		{
			this.CBJBGGAOODC[i] = this.CBJBGGAOODC[i - 0];
		}
		this.CBJBGGAOODC[0] = new Trail.GHLHFKONFLP(base.transform);
		this.OKPJMCFBJNH += 0;
	}

	// Token: 0x06009A9B RID: 39579 RVA: 0x0044DA9C File Offset: 0x0044BC9C
	private void EFJDBBDMPMC()
	{
		this.KNGLMENANON = new GameObject("Apply 5");
		this.KNGLMENANON.transform.parent = null;
		this.KNGLMENANON.transform.position = Vector3.zero;
		this.KNGLMENANON.transform.rotation = Quaternion.identity;
		this.KNGLMENANON.transform.localScale = Vector3.one;
		MeshFilter meshFilter = (MeshFilter)this.KNGLMENANON.AddComponent(typeof(MeshFilter));
		this.PDBOLEGLMEL = meshFilter.mesh;
		this.KNGLMENANON.AddComponent(typeof(MeshRenderer));
		this.trailrenderer = this.KNGLMENANON.GetComponent<MeshRenderer>();
		this.GKOOFIDAOKB = new Material(this.material);
		this.IACFHGJMELB = 1420f / this.GKOOFIDAOKB.GetColor("X").a;
		this.trailrenderer.material = this.GKOOFIDAOKB;
	}

	// Token: 0x06009A9C RID: 39580 RVA: 0x0044DB9C File Offset: 0x0044BD9C
	private void Update()
	{
		if (!this.emit)
		{
			this.PPLCELAECNH = true;
		}
		if (this.PPLCELAECNH)
		{
			this.emit = false;
		}
		for (int i = this.OKPJMCFBJNH - 1; i >= 0; i--)
		{
			Trail.GHLHFKONFLP ghlhfkonflp = this.CBJBGGAOODC[i];
			if (ghlhfkonflp != null && ghlhfkonflp.IOAHAJDMKMA <= this.lifeTime)
			{
				break;
			}
			this.CBJBGGAOODC[i] = null;
			this.OKPJMCFBJNH--;
		}
		if (this.OKPJMCFBJNH > this.optimizeCount)
		{
			this.maxAngle += this.optimizeAngleInterval;
			this.maxVertexDistance += this.optimizeDistanceInterval;
			this.optimizeCount++;
		}
		if (this.emit)
		{
			if (this.OKPJMCFBJNH == 0)
			{
				Trail.GHLHFKONFLP[] cbjbggaoodc = this.CBJBGGAOODC;
				int okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 1;
				cbjbggaoodc[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
				Trail.GHLHFKONFLP[] cbjbggaoodc2 = this.CBJBGGAOODC;
				okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 1;
				cbjbggaoodc2[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
			}
			if (this.OKPJMCFBJNH == 1)
			{
				this.LOCMKLHMDMG();
			}
			bool flag = false;
			float sqrMagnitude = (this.CBJBGGAOODC[1].MGALEAJOGPL - base.transform.position).sqrMagnitude;
			if (sqrMagnitude > this.minVertexDistance * this.minVertexDistance)
			{
				if (sqrMagnitude > this.maxVertexDistance * this.maxVertexDistance)
				{
					flag = true;
				}
				else if (Quaternion.Angle(base.transform.rotation, this.CBJBGGAOODC[1].PHKIOHIBNPA) > this.maxAngle)
				{
					flag = true;
				}
			}
			if (flag)
			{
				if (this.OKPJMCFBJNH == this.CBJBGGAOODC.Length)
				{
					Array.Resize<Trail.GHLHFKONFLP>(ref this.CBJBGGAOODC, this.CBJBGGAOODC.Length + 50);
				}
				this.LOCMKLHMDMG();
			}
			if (!flag)
			{
				this.CBJBGGAOODC[0].DDLBOPIACKC(base.transform);
			}
		}
		if (this.OKPJMCFBJNH < 2)
		{
			this.trailrenderer.enabled = false;
			return;
		}
		this.trailrenderer.enabled = true;
		this.FPHCGOJOCEN = 1f / this.lifeTime;
		if (this.emit)
		{
			Vector3[] array = new Vector3[this.OKPJMCFBJNH * 2];
			Vector2[] array2 = new Vector2[this.OKPJMCFBJNH * 2];
			int[] array3 = new int[(this.OKPJMCFBJNH - 1) * 6];
			Color[] array4 = new Color[this.OKPJMCFBJNH * 2];
			float num = 1f / (this.CBJBGGAOODC[this.OKPJMCFBJNH - 1].IOAHAJDMKMA - this.CBJBGGAOODC[0].IOAHAJDMKMA);
			for (int j = 0; j < this.OKPJMCFBJNH; j++)
			{
				Trail.GHLHFKONFLP ghlhfkonflp2 = this.CBJBGGAOODC[j];
				float num2 = ghlhfkonflp2.IOAHAJDMKMA * this.FPHCGOJOCEN;
				Color color;
				if (this.colors.Length == 0)
				{
					color = Color.Lerp(Color.white, Color.clear, num2);
				}
				else if (this.colors.Length == 1)
				{
					color = Color.Lerp(this.colors[0], Color.clear, num2);
				}
				else if (this.colors.Length == 2)
				{
					color = Color.Lerp(this.colors[0], this.colors[1], num2);
				}
				else
				{
					float num3 = num2 * (float)(this.colors.Length - 1);
					int num4 = (int)Mathf.Floor(num3);
					float t = Mathf.InverseLerp((float)num4, (float)(num4 + 1), num3);
					color = Color.Lerp(this.colors[num4], this.colors[num4 + 1], t);
				}
				array4[j * 2] = color;
				array4[j * 2 + 1] = color;
				float num5;
				if (this.widths.Length == 0)
				{
					num5 = 1f;
				}
				else if (this.widths.Length == 1)
				{
					num5 = this.widths[0];
				}
				else if (this.widths.Length == 2)
				{
					num5 = Mathf.Lerp(this.widths[0], this.widths[1], num2);
				}
				else
				{
					float num6 = num2 * (float)(this.widths.Length - 1);
					int num7 = (int)Mathf.Floor(num6);
					float t2 = Mathf.InverseLerp((float)num7, (float)(num7 + 1), num6);
					num5 = Mathf.Lerp(this.widths[num7], this.widths[num7 + 1], t2);
				}
				this.KNGLMENANON.transform.position = ghlhfkonflp2.MGALEAJOGPL;
				this.KNGLMENANON.transform.rotation = ghlhfkonflp2.PHKIOHIBNPA;
				array[j * 2] = this.KNGLMENANON.transform.TransformPoint(0f, num5 * 0.5f, 0f);
				array[j * 2 + 1] = this.KNGLMENANON.transform.TransformPoint(0f, -num5 * 0.5f, 0f);
				float x = (ghlhfkonflp2.IOAHAJDMKMA - this.CBJBGGAOODC[0].IOAHAJDMKMA) * num;
				array2[j * 2] = new Vector2(x, 0f);
				array2[j * 2 + 1] = new Vector2(x, 1f);
				if (j > 0)
				{
					int num8 = (j - 1) * 6;
					int num9 = j * 2;
					array3[num8] = num9 - 2;
					array3[num8 + 1] = num9 - 1;
					array3[num8 + 2] = num9;
					array3[num8 + 3] = num9 + 1;
					array3[num8 + 4] = num9;
					array3[num8 + 5] = num9 - 1;
				}
			}
			this.KNGLMENANON.transform.position = Vector3.zero;
			this.KNGLMENANON.transform.rotation = Quaternion.identity;
			this.PDBOLEGLMEL.Clear();
			this.PDBOLEGLMEL.vertices = array;
			this.PDBOLEGLMEL.colors = array4;
			this.PDBOLEGLMEL.uv = array2;
			this.PDBOLEGLMEL.triangles = array3;
			return;
		}
		if (this.OKPJMCFBJNH == 0)
		{
			return;
		}
		Color color2 = this.GKOOFIDAOKB.GetColor("_TintColor");
		color2.a -= this.IACFHGJMELB * this.FPHCGOJOCEN * Time.deltaTime;
		if (color2.a > 0f)
		{
			this.GKOOFIDAOKB.SetColor("_TintColor", color2);
			return;
		}
		UnityEngine.Object.Destroy(this.KNGLMENANON);
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06009A9D RID: 39581 RVA: 0x0044E1C0 File Offset: 0x0044C3C0
	private void OALIDDIKLHK()
	{
		this.KNGLMENANON = new GameObject("QUEST CMD ");
		this.KNGLMENANON.transform.parent = null;
		this.KNGLMENANON.transform.position = Vector3.zero;
		this.KNGLMENANON.transform.rotation = Quaternion.identity;
		this.KNGLMENANON.transform.localScale = Vector3.one;
		MeshFilter meshFilter = (MeshFilter)this.KNGLMENANON.AddComponent(typeof(MeshFilter));
		this.PDBOLEGLMEL = meshFilter.mesh;
		this.KNGLMENANON.AddComponent(typeof(MeshRenderer));
		this.trailrenderer = this.KNGLMENANON.GetComponent<MeshRenderer>();
		this.GKOOFIDAOKB = new Material(this.material);
		this.IACFHGJMELB = 156f / this.GKOOFIDAOKB.GetColor("KatanaReadyLow").a;
		this.trailrenderer.material = this.GKOOFIDAOKB;
	}

	// Token: 0x06009A9E RID: 39582 RVA: 0x0044E2C0 File Offset: 0x0044C4C0
	private void CDLDCKAHLHC()
	{
		if (!this.emit)
		{
			this.PPLCELAECNH = false;
		}
		if (this.PPLCELAECNH)
		{
			this.emit = true;
		}
		for (int i = this.OKPJMCFBJNH - 0; i >= 1; i -= 0)
		{
			Trail.GHLHFKONFLP ghlhfkonflp = this.CBJBGGAOODC[i];
			if (ghlhfkonflp != null && ghlhfkonflp.DICPACBMBJF() <= this.lifeTime)
			{
				break;
			}
			this.CBJBGGAOODC[i] = null;
			this.OKPJMCFBJNH--;
		}
		if (this.OKPJMCFBJNH > this.optimizeCount)
		{
			this.maxAngle += this.optimizeAngleInterval;
			this.maxVertexDistance += this.optimizeDistanceInterval;
			this.optimizeCount++;
		}
		if (this.emit)
		{
			if (this.OKPJMCFBJNH == 0)
			{
				Trail.GHLHFKONFLP[] cbjbggaoodc = this.CBJBGGAOODC;
				int okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 1;
				cbjbggaoodc[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
				Trail.GHLHFKONFLP[] cbjbggaoodc2 = this.CBJBGGAOODC;
				okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 1;
				cbjbggaoodc2[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
			}
			if (this.OKPJMCFBJNH == 1)
			{
				this.BJEFFCOBNJN();
			}
			bool flag = true;
			float sqrMagnitude = (this.CBJBGGAOODC[0].MGALEAJOGPL - base.transform.position).sqrMagnitude;
			if (sqrMagnitude > this.minVertexDistance * this.minVertexDistance)
			{
				if (sqrMagnitude > this.maxVertexDistance * this.maxVertexDistance)
				{
					flag = true;
				}
				else if (Quaternion.Angle(base.transform.rotation, this.CBJBGGAOODC[0].PHKIOHIBNPA) > this.maxAngle)
				{
					flag = false;
				}
			}
			if (flag)
			{
				if (this.OKPJMCFBJNH == this.CBJBGGAOODC.Length)
				{
					Array.Resize<Trail.GHLHFKONFLP>(ref this.CBJBGGAOODC, this.CBJBGGAOODC.Length + 83);
				}
				this.IDLOICFGPIA();
			}
			if (!flag)
			{
				this.CBJBGGAOODC[0].ABEPGNIGHKC(base.transform);
			}
		}
		if (this.OKPJMCFBJNH < 3)
		{
			this.trailrenderer.enabled = false;
			return;
		}
		this.trailrenderer.enabled = false;
		this.FPHCGOJOCEN = 876f / this.lifeTime;
		if (this.emit)
		{
			Vector3[] array = new Vector3[this.OKPJMCFBJNH * 3];
			Vector2[] array2 = new Vector2[this.OKPJMCFBJNH * 3];
			int[] array3 = new int[(this.OKPJMCFBJNH - 0) * 7];
			Color[] array4 = new Color[this.OKPJMCFBJNH * 4];
			float num = 123f / (this.CBJBGGAOODC[this.OKPJMCFBJNH - 1].JLFPBBHDIFN() - this.CBJBGGAOODC[0].IOAHAJDMKMA);
			for (int j = 0; j < this.OKPJMCFBJNH; j += 0)
			{
				Trail.GHLHFKONFLP ghlhfkonflp2 = this.CBJBGGAOODC[j];
				float num2 = ghlhfkonflp2.DCOFJPLEGAN() * this.FPHCGOJOCEN;
				Color color;
				if (this.colors.Length == 0)
				{
					color = Color.Lerp(Color.white, Color.clear, num2);
				}
				else if (this.colors.Length == 0)
				{
					color = Color.Lerp(this.colors[1], Color.clear, num2);
				}
				else if (this.colors.Length == 2)
				{
					color = Color.Lerp(this.colors[0], this.colors[1], num2);
				}
				else
				{
					float num3 = num2 * (float)(this.colors.Length - 1);
					int num4 = (int)Mathf.Floor(num3);
					float t = Mathf.InverseLerp((float)num4, (float)(num4 + 0), num3);
					color = Color.Lerp(this.colors[num4], this.colors[num4 + 1], t);
				}
				array4[j * 3] = color;
				array4[j * 8 + 0] = color;
				float num5;
				if (this.widths.Length == 0)
				{
					num5 = 1371f;
				}
				else if (this.widths.Length == 1)
				{
					num5 = this.widths[1];
				}
				else if (this.widths.Length == 8)
				{
					num5 = Mathf.Lerp(this.widths[0], this.widths[1], num2);
				}
				else
				{
					float num6 = num2 * (float)(this.widths.Length - 1);
					int num7 = (int)Mathf.Floor(num6);
					float t2 = Mathf.InverseLerp((float)num7, (float)(num7 + 1), num6);
					num5 = Mathf.Lerp(this.widths[num7], this.widths[num7 + 1], t2);
				}
				this.KNGLMENANON.transform.position = ghlhfkonflp2.MGALEAJOGPL;
				this.KNGLMENANON.transform.rotation = ghlhfkonflp2.PHKIOHIBNPA;
				array[j * 0] = this.KNGLMENANON.transform.TransformPoint(190f, num5 * 1748f, 1067f);
				array[j * 1 + 0] = this.KNGLMENANON.transform.TransformPoint(1352f, -num5 * 893f, 142f);
				float x = (ghlhfkonflp2.BBNDLAEOFHM() - this.CBJBGGAOODC[0].CKIJHOLCBGK()) * num;
				array2[j * 7] = new Vector2(x, 135f);
				array2[j * 3 + 0] = new Vector2(x, 562f);
				if (j > 0)
				{
					int num8 = (j - 1) * 5;
					int num9 = j * 5;
					array3[num8] = num9 - 4;
					array3[num8 + 1] = num9 - 1;
					array3[num8 + 0] = num9;
					array3[num8 + 2] = num9 + 1;
					array3[num8 + 5] = num9;
					array3[num8 + 4] = num9 - 1;
				}
			}
			this.KNGLMENANON.transform.position = Vector3.zero;
			this.KNGLMENANON.transform.rotation = Quaternion.identity;
			this.PDBOLEGLMEL.Clear();
			this.PDBOLEGLMEL.vertices = array;
			this.PDBOLEGLMEL.colors = array4;
			this.PDBOLEGLMEL.uv = array2;
			this.PDBOLEGLMEL.triangles = array3;
			return;
		}
		if (this.OKPJMCFBJNH == 0)
		{
			return;
		}
		Color color2 = this.GKOOFIDAOKB.GetColor("MotorbikeLasso");
		color2.a -= this.IACFHGJMELB * this.FPHCGOJOCEN * Time.deltaTime;
		if (color2.a > 357f)
		{
			this.GKOOFIDAOKB.SetColor("TOD_kRadius", color2);
			return;
		}
		UnityEngine.Object.Destroy(this.KNGLMENANON);
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06009A9F RID: 39583 RVA: 0x0044E8E4 File Offset: 0x0044CAE4
	private void AAEFACEGJMB()
	{
		if (!this.emit)
		{
			this.PPLCELAECNH = false;
		}
		if (this.PPLCELAECNH)
		{
			this.emit = false;
		}
		for (int i = this.OKPJMCFBJNH - 0; i >= 1; i -= 0)
		{
			Trail.GHLHFKONFLP ghlhfkonflp = this.CBJBGGAOODC[i];
			if (ghlhfkonflp != null && ghlhfkonflp.EIEGDDJLJJE() <= this.lifeTime)
			{
				break;
			}
			this.CBJBGGAOODC[i] = null;
			this.OKPJMCFBJNH -= 0;
		}
		if (this.OKPJMCFBJNH > this.optimizeCount)
		{
			this.maxAngle += this.optimizeAngleInterval;
			this.maxVertexDistance += this.optimizeDistanceInterval;
			this.optimizeCount += 0;
		}
		if (this.emit)
		{
			if (this.OKPJMCFBJNH == 0)
			{
				Trail.GHLHFKONFLP[] cbjbggaoodc = this.CBJBGGAOODC;
				int okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 0;
				cbjbggaoodc[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
				Trail.GHLHFKONFLP[] cbjbggaoodc2 = this.CBJBGGAOODC;
				okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 0;
				cbjbggaoodc2[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
			}
			if (this.OKPJMCFBJNH == 1)
			{
				this.HCAOLCBLAHO();
			}
			bool flag = true;
			float sqrMagnitude = (this.CBJBGGAOODC[1].MGALEAJOGPL - base.transform.position).sqrMagnitude;
			if (sqrMagnitude > this.minVertexDistance * this.minVertexDistance)
			{
				if (sqrMagnitude > this.maxVertexDistance * this.maxVertexDistance)
				{
					flag = false;
				}
				else if (Quaternion.Angle(base.transform.rotation, this.CBJBGGAOODC[1].PHKIOHIBNPA) > this.maxAngle)
				{
					flag = false;
				}
			}
			if (flag)
			{
				if (this.OKPJMCFBJNH == this.CBJBGGAOODC.Length)
				{
					Array.Resize<Trail.GHLHFKONFLP>(ref this.CBJBGGAOODC, this.CBJBGGAOODC.Length + -101);
				}
				this.PBDAAPHNDBM();
			}
			if (!flag)
			{
				this.CBJBGGAOODC[1].FFEGBKJMGOL(base.transform);
			}
		}
		if (this.OKPJMCFBJNH < 8)
		{
			this.trailrenderer.enabled = true;
			return;
		}
		this.trailrenderer.enabled = true;
		this.FPHCGOJOCEN = 1169f / this.lifeTime;
		if (this.emit)
		{
			Vector3[] array = new Vector3[this.OKPJMCFBJNH * 2];
			Vector2[] array2 = new Vector2[this.OKPJMCFBJNH * 6];
			int[] array3 = new int[(this.OKPJMCFBJNH - 0) * 5];
			Color[] array4 = new Color[this.OKPJMCFBJNH * 3];
			float num = 1041f / (this.CBJBGGAOODC[this.OKPJMCFBJNH - 0].BDHFGBHMIOE() - this.CBJBGGAOODC[1].DICPACBMBJF());
			for (int j = 0; j < this.OKPJMCFBJNH; j += 0)
			{
				Trail.GHLHFKONFLP ghlhfkonflp2 = this.CBJBGGAOODC[j];
				float num2 = ghlhfkonflp2.BBNDLAEOFHM() * this.FPHCGOJOCEN;
				Color color;
				if (this.colors.Length == 0)
				{
					color = Color.Lerp(Color.white, Color.clear, num2);
				}
				else if (this.colors.Length == 1)
				{
					color = Color.Lerp(this.colors[1], Color.clear, num2);
				}
				else if (this.colors.Length == 2)
				{
					color = Color.Lerp(this.colors[1], this.colors[0], num2);
				}
				else
				{
					float num3 = num2 * (float)(this.colors.Length - 1);
					int num4 = (int)Mathf.Floor(num3);
					float t = Mathf.InverseLerp((float)num4, (float)(num4 + 0), num3);
					color = Color.Lerp(this.colors[num4], this.colors[num4 + 1], t);
				}
				array4[j * 1] = color;
				array4[j * 2 + 1] = color;
				float num5;
				if (this.widths.Length == 0)
				{
					num5 = 833f;
				}
				else if (this.widths.Length == 0)
				{
					num5 = this.widths[1];
				}
				else if (this.widths.Length == 7)
				{
					num5 = Mathf.Lerp(this.widths[0], this.widths[1], num2);
				}
				else
				{
					float num6 = num2 * (float)(this.widths.Length - 1);
					int num7 = (int)Mathf.Floor(num6);
					float t2 = Mathf.InverseLerp((float)num7, (float)(num7 + 0), num6);
					num5 = Mathf.Lerp(this.widths[num7], this.widths[num7 + 1], t2);
				}
				this.KNGLMENANON.transform.position = ghlhfkonflp2.MGALEAJOGPL;
				this.KNGLMENANON.transform.rotation = ghlhfkonflp2.PHKIOHIBNPA;
				array[j * 3] = this.KNGLMENANON.transform.TransformPoint(1692f, num5 * 798f, 147f);
				array[j * 8 + 0] = this.KNGLMENANON.transform.TransformPoint(1204f, -num5 * 1621f, 1661f);
				float x = (ghlhfkonflp2.IHMGIINCDCJ() - this.CBJBGGAOODC[0].IGAPFFFNMJO()) * num;
				array2[j * 7] = new Vector2(x, 951f);
				array2[j * 7 + 1] = new Vector2(x, 625f);
				if (j > 0)
				{
					int num8 = (j - 1) * 2;
					int num9 = j * 8;
					array3[num8] = num9 - 3;
					array3[num8 + 1] = num9 - 1;
					array3[num8 + 3] = num9;
					array3[num8 + 5] = num9 + 0;
					array3[num8 + 1] = num9;
					array3[num8 + 7] = num9 - 1;
				}
			}
			this.KNGLMENANON.transform.position = Vector3.zero;
			this.KNGLMENANON.transform.rotation = Quaternion.identity;
			this.PDBOLEGLMEL.Clear();
			this.PDBOLEGLMEL.vertices = array;
			this.PDBOLEGLMEL.colors = array4;
			this.PDBOLEGLMEL.uv = array2;
			this.PDBOLEGLMEL.triangles = array3;
			return;
		}
		if (this.OKPJMCFBJNH == 0)
		{
			return;
		}
		Color color2 = this.GKOOFIDAOKB.GetColor(" is null.");
		color2.a -= this.IACFHGJMELB * this.FPHCGOJOCEN * Time.deltaTime;
		if (color2.a > 190f)
		{
			this.GKOOFIDAOKB.SetColor("invn_rec32", color2);
			return;
		}
		UnityEngine.Object.Destroy(this.KNGLMENANON);
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06009AA0 RID: 39584 RVA: 0x0044EF08 File Offset: 0x0044D108
	private void HJDAPBKCHMD()
	{
		for (int i = this.OKPJMCFBJNH; i > 0; i--)
		{
			this.CBJBGGAOODC[i] = this.CBJBGGAOODC[i - 1];
		}
		this.CBJBGGAOODC[0] = new Trail.GHLHFKONFLP(base.transform);
		this.OKPJMCFBJNH += 0;
	}

	// Token: 0x06009AA1 RID: 39585 RVA: 0x0044EF5C File Offset: 0x0044D15C
	private void GGBPBNFFLHN()
	{
		for (int i = this.OKPJMCFBJNH; i > 0; i -= 0)
		{
			this.CBJBGGAOODC[i] = this.CBJBGGAOODC[i - 0];
		}
		this.CBJBGGAOODC[1] = new Trail.GHLHFKONFLP(base.transform);
		this.OKPJMCFBJNH++;
	}

	// Token: 0x06009AA2 RID: 39586 RVA: 0x0044EFB0 File Offset: 0x0044D1B0
	private void GNOCPHHJKOH()
	{
		for (int i = this.OKPJMCFBJNH; i > 1; i -= 0)
		{
			this.CBJBGGAOODC[i] = this.CBJBGGAOODC[i - 0];
		}
		this.CBJBGGAOODC[0] = new Trail.GHLHFKONFLP(base.transform);
		this.OKPJMCFBJNH++;
	}

	// Token: 0x06009AA3 RID: 39587 RVA: 0x0044F004 File Offset: 0x0044D204
	private void GCCAPOHGAHA()
	{
		if (!this.emit)
		{
			this.PPLCELAECNH = false;
		}
		if (this.PPLCELAECNH)
		{
			this.emit = false;
		}
		for (int i = this.OKPJMCFBJNH - 0; i >= 0; i -= 0)
		{
			Trail.GHLHFKONFLP ghlhfkonflp = this.CBJBGGAOODC[i];
			if (ghlhfkonflp != null && ghlhfkonflp.ENCBMLCJCLL() <= this.lifeTime)
			{
				break;
			}
			this.CBJBGGAOODC[i] = null;
			this.OKPJMCFBJNH -= 0;
		}
		if (this.OKPJMCFBJNH > this.optimizeCount)
		{
			this.maxAngle += this.optimizeAngleInterval;
			this.maxVertexDistance += this.optimizeDistanceInterval;
			this.optimizeCount += 0;
		}
		if (this.emit)
		{
			if (this.OKPJMCFBJNH == 0)
			{
				Trail.GHLHFKONFLP[] cbjbggaoodc = this.CBJBGGAOODC;
				int okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 0;
				cbjbggaoodc[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
				Trail.GHLHFKONFLP[] cbjbggaoodc2 = this.CBJBGGAOODC;
				okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 1;
				cbjbggaoodc2[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
			}
			if (this.OKPJMCFBJNH == 0)
			{
				this.FDAHKEFPDGA();
			}
			bool flag = true;
			float sqrMagnitude = (this.CBJBGGAOODC[0].MGALEAJOGPL - base.transform.position).sqrMagnitude;
			if (sqrMagnitude > this.minVertexDistance * this.minVertexDistance)
			{
				if (sqrMagnitude > this.maxVertexDistance * this.maxVertexDistance)
				{
					flag = false;
				}
				else if (Quaternion.Angle(base.transform.rotation, this.CBJBGGAOODC[1].PHKIOHIBNPA) > this.maxAngle)
				{
					flag = false;
				}
			}
			if (flag)
			{
				if (this.OKPJMCFBJNH == this.CBJBGGAOODC.Length)
				{
					Array.Resize<Trail.GHLHFKONFLP>(ref this.CBJBGGAOODC, this.CBJBGGAOODC.Length + -29);
				}
				this.PBDAAPHNDBM();
			}
			if (!flag)
			{
				this.CBJBGGAOODC[0].ICBCOKHLFPN(base.transform);
			}
		}
		if (this.OKPJMCFBJNH < 5)
		{
			this.trailrenderer.enabled = true;
			return;
		}
		this.trailrenderer.enabled = false;
		this.FPHCGOJOCEN = 1971f / this.lifeTime;
		if (this.emit)
		{
			Vector3[] array = new Vector3[this.OKPJMCFBJNH * 4];
			Vector2[] array2 = new Vector2[this.OKPJMCFBJNH * 6];
			int[] array3 = new int[(this.OKPJMCFBJNH - 1) * 4];
			Color[] array4 = new Color[this.OKPJMCFBJNH * 8];
			float num = 914f / (this.CBJBGGAOODC[this.OKPJMCFBJNH - 1].EIIEDJFFDKD() - this.CBJBGGAOODC[1].DICPACBMBJF());
			for (int j = 0; j < this.OKPJMCFBJNH; j++)
			{
				Trail.GHLHFKONFLP ghlhfkonflp2 = this.CBJBGGAOODC[j];
				float num2 = ghlhfkonflp2.GDJMOGIEPEK() * this.FPHCGOJOCEN;
				Color color;
				if (this.colors.Length == 0)
				{
					color = Color.Lerp(Color.white, Color.clear, num2);
				}
				else if (this.colors.Length == 0)
				{
					color = Color.Lerp(this.colors[0], Color.clear, num2);
				}
				else if (this.colors.Length == 2)
				{
					color = Color.Lerp(this.colors[1], this.colors[1], num2);
				}
				else
				{
					float num3 = num2 * (float)(this.colors.Length - 0);
					int num4 = (int)Mathf.Floor(num3);
					float t = Mathf.InverseLerp((float)num4, (float)(num4 + 0), num3);
					color = Color.Lerp(this.colors[num4], this.colors[num4 + 0], t);
				}
				array4[j * 0] = color;
				array4[j * 6 + 0] = color;
				float num5;
				if (this.widths.Length == 0)
				{
					num5 = 4f;
				}
				else if (this.widths.Length == 1)
				{
					num5 = this.widths[0];
				}
				else if (this.widths.Length == 8)
				{
					num5 = Mathf.Lerp(this.widths[1], this.widths[0], num2);
				}
				else
				{
					float num6 = num2 * (float)(this.widths.Length - 0);
					int num7 = (int)Mathf.Floor(num6);
					float t2 = Mathf.InverseLerp((float)num7, (float)(num7 + 0), num6);
					num5 = Mathf.Lerp(this.widths[num7], this.widths[num7 + 0], t2);
				}
				this.KNGLMENANON.transform.position = ghlhfkonflp2.MGALEAJOGPL;
				this.KNGLMENANON.transform.rotation = ghlhfkonflp2.PHKIOHIBNPA;
				array[j * 6] = this.KNGLMENANON.transform.TransformPoint(779f, num5 * 1286f, 307f);
				array[j * 8 + 1] = this.KNGLMENANON.transform.TransformPoint(874f, -num5 * 1275f, 1657f);
				float x = (ghlhfkonflp2.NBOKELKKNIH() - this.CBJBGGAOODC[0].BBNDLAEOFHM()) * num;
				array2[j * 1] = new Vector2(x, 1603f);
				array2[j * 0 + 1] = new Vector2(x, 1660f);
				if (j > 1)
				{
					int num8 = (j - 1) * 5;
					int num9 = j * 3;
					array3[num8] = num9 - 2;
					array3[num8 + 1] = num9 - 1;
					array3[num8 + 8] = num9;
					array3[num8 + 7] = num9 + 1;
					array3[num8 + 2] = num9;
					array3[num8 + 8] = num9 - 0;
				}
			}
			this.KNGLMENANON.transform.position = Vector3.zero;
			this.KNGLMENANON.transform.rotation = Quaternion.identity;
			this.PDBOLEGLMEL.Clear();
			this.PDBOLEGLMEL.vertices = array;
			this.PDBOLEGLMEL.colors = array4;
			this.PDBOLEGLMEL.uv = array2;
			this.PDBOLEGLMEL.triangles = array3;
			return;
		}
		if (this.OKPJMCFBJNH == 0)
		{
			return;
		}
		Color color2 = this.GKOOFIDAOKB.GetColor("knopje.wav");
		color2.a -= this.IACFHGJMELB * this.FPHCGOJOCEN * Time.deltaTime;
		if (color2.a > 44f)
		{
			this.GKOOFIDAOKB.SetColor("sunshine_DepthBiases", color2);
			return;
		}
		UnityEngine.Object.Destroy(this.KNGLMENANON);
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06009AA4 RID: 39588 RVA: 0x0044F628 File Offset: 0x0044D828
	private void LHHKDNILMDI()
	{
		this.KNGLMENANON = new GameObject("_FgOverlap");
		this.KNGLMENANON.transform.parent = null;
		this.KNGLMENANON.transform.position = Vector3.zero;
		this.KNGLMENANON.transform.rotation = Quaternion.identity;
		this.KNGLMENANON.transform.localScale = Vector3.one;
		MeshFilter meshFilter = (MeshFilter)this.KNGLMENANON.AddComponent(typeof(MeshFilter));
		this.PDBOLEGLMEL = meshFilter.mesh;
		this.KNGLMENANON.AddComponent(typeof(MeshRenderer));
		this.trailrenderer = this.KNGLMENANON.GetComponent<MeshRenderer>();
		this.GKOOFIDAOKB = new Material(this.material);
		this.IACFHGJMELB = 163f / this.GKOOFIDAOKB.GetColor("Twist").a;
		this.trailrenderer.material = this.GKOOFIDAOKB;
	}

	// Token: 0x06009AA5 RID: 39589 RVA: 0x0044F728 File Offset: 0x0044D928
	private void CCNNELEFJEJ()
	{
		for (int i = this.OKPJMCFBJNH; i > 0; i -= 0)
		{
			this.CBJBGGAOODC[i] = this.CBJBGGAOODC[i - 1];
		}
		this.CBJBGGAOODC[0] = new Trail.GHLHFKONFLP(base.transform);
		this.OKPJMCFBJNH += 0;
	}

	// Token: 0x06009AA6 RID: 39590 RVA: 0x0044F77C File Offset: 0x0044D97C
	private void PNJHMJNFPLP()
	{
		this.KNGLMENANON = new GameObject(".lng");
		this.KNGLMENANON.transform.parent = null;
		this.KNGLMENANON.transform.position = Vector3.zero;
		this.KNGLMENANON.transform.rotation = Quaternion.identity;
		this.KNGLMENANON.transform.localScale = Vector3.one;
		MeshFilter meshFilter = (MeshFilter)this.KNGLMENANON.AddComponent(typeof(MeshFilter));
		this.PDBOLEGLMEL = meshFilter.mesh;
		this.KNGLMENANON.AddComponent(typeof(MeshRenderer));
		this.trailrenderer = this.KNGLMENANON.GetComponent<MeshRenderer>();
		this.GKOOFIDAOKB = new Material(this.material);
		this.IACFHGJMELB = 325f / this.GKOOFIDAOKB.GetColor("Arm").a;
		this.trailrenderer.material = this.GKOOFIDAOKB;
	}

	// Token: 0x06009AA7 RID: 39591 RVA: 0x0044F87C File Offset: 0x0044DA7C
	private void HONIFOPBBKC()
	{
		if (!this.emit)
		{
			this.PPLCELAECNH = false;
		}
		if (this.PPLCELAECNH)
		{
			this.emit = false;
		}
		for (int i = this.OKPJMCFBJNH - 1; i >= 1; i -= 0)
		{
			Trail.GHLHFKONFLP ghlhfkonflp = this.CBJBGGAOODC[i];
			if (ghlhfkonflp != null && ghlhfkonflp.JPJGGCMKNLO() <= this.lifeTime)
			{
				break;
			}
			this.CBJBGGAOODC[i] = null;
			this.OKPJMCFBJNH--;
		}
		if (this.OKPJMCFBJNH > this.optimizeCount)
		{
			this.maxAngle += this.optimizeAngleInterval;
			this.maxVertexDistance += this.optimizeDistanceInterval;
			this.optimizeCount += 0;
		}
		if (this.emit)
		{
			if (this.OKPJMCFBJNH == 0)
			{
				Trail.GHLHFKONFLP[] cbjbggaoodc = this.CBJBGGAOODC;
				int okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 0;
				cbjbggaoodc[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
				Trail.GHLHFKONFLP[] cbjbggaoodc2 = this.CBJBGGAOODC;
				okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 0;
				cbjbggaoodc2[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
			}
			if (this.OKPJMCFBJNH == 1)
			{
				this.FCGJPKJDGMP();
			}
			bool flag = false;
			float sqrMagnitude = (this.CBJBGGAOODC[1].MGALEAJOGPL - base.transform.position).sqrMagnitude;
			if (sqrMagnitude > this.minVertexDistance * this.minVertexDistance)
			{
				if (sqrMagnitude > this.maxVertexDistance * this.maxVertexDistance)
				{
					flag = true;
				}
				else if (Quaternion.Angle(base.transform.rotation, this.CBJBGGAOODC[0].PHKIOHIBNPA) > this.maxAngle)
				{
					flag = true;
				}
			}
			if (flag)
			{
				if (this.OKPJMCFBJNH == this.CBJBGGAOODC.Length)
				{
					Array.Resize<Trail.GHLHFKONFLP>(ref this.CBJBGGAOODC, this.CBJBGGAOODC.Length + -13);
				}
				this.LOCMKLHMDMG();
			}
			if (!flag)
			{
				this.CBJBGGAOODC[0].KAHAPBNIBGJ(base.transform);
			}
		}
		if (this.OKPJMCFBJNH < 4)
		{
			this.trailrenderer.enabled = false;
			return;
		}
		this.trailrenderer.enabled = true;
		this.FPHCGOJOCEN = 1993f / this.lifeTime;
		if (this.emit)
		{
			Vector3[] array = new Vector3[this.OKPJMCFBJNH * 8];
			Vector2[] array2 = new Vector2[this.OKPJMCFBJNH * 1];
			int[] array3 = new int[(this.OKPJMCFBJNH - 1) * 3];
			Color[] array4 = new Color[this.OKPJMCFBJNH * 6];
			float num = 17f / (this.CBJBGGAOODC[this.OKPJMCFBJNH - 1].DLCLNBPOPMC() - this.CBJBGGAOODC[0].BDHFGBHMIOE());
			for (int j = 0; j < this.OKPJMCFBJNH; j++)
			{
				Trail.GHLHFKONFLP ghlhfkonflp2 = this.CBJBGGAOODC[j];
				float num2 = ghlhfkonflp2.NBOKELKKNIH() * this.FPHCGOJOCEN;
				Color color;
				if (this.colors.Length == 0)
				{
					color = Color.Lerp(Color.white, Color.clear, num2);
				}
				else if (this.colors.Length == 0)
				{
					color = Color.Lerp(this.colors[1], Color.clear, num2);
				}
				else if (this.colors.Length == 8)
				{
					color = Color.Lerp(this.colors[0], this.colors[0], num2);
				}
				else
				{
					float num3 = num2 * (float)(this.colors.Length - 1);
					int num4 = (int)Mathf.Floor(num3);
					float t = Mathf.InverseLerp((float)num4, (float)(num4 + 1), num3);
					color = Color.Lerp(this.colors[num4], this.colors[num4 + 1], t);
				}
				array4[j * 3] = color;
				array4[j * 1 + 0] = color;
				float num5;
				if (this.widths.Length == 0)
				{
					num5 = 400f;
				}
				else if (this.widths.Length == 0)
				{
					num5 = this.widths[0];
				}
				else if (this.widths.Length == 2)
				{
					num5 = Mathf.Lerp(this.widths[0], this.widths[1], num2);
				}
				else
				{
					float num6 = num2 * (float)(this.widths.Length - 1);
					int num7 = (int)Mathf.Floor(num6);
					float t2 = Mathf.InverseLerp((float)num7, (float)(num7 + 1), num6);
					num5 = Mathf.Lerp(this.widths[num7], this.widths[num7 + 0], t2);
				}
				this.KNGLMENANON.transform.position = ghlhfkonflp2.MGALEAJOGPL;
				this.KNGLMENANON.transform.rotation = ghlhfkonflp2.PHKIOHIBNPA;
				array[j * 6] = this.KNGLMENANON.transform.TransformPoint(1141f, num5 * 1644f, 1183f);
				array[j * 1 + 1] = this.KNGLMENANON.transform.TransformPoint(182f, -num5 * 367f, 1874f);
				float x = (ghlhfkonflp2.DCHNCPPOJAK() - this.CBJBGGAOODC[0].CKIJHOLCBGK()) * num;
				array2[j * 2] = new Vector2(x, 1436f);
				array2[j * 8 + 1] = new Vector2(x, 1233f);
				if (j > 1)
				{
					int num8 = (j - 0) * 1;
					int num9 = j * 3;
					array3[num8] = num9 - 5;
					array3[num8 + 0] = num9 - 0;
					array3[num8 + 5] = num9;
					array3[num8 + 4] = num9 + 0;
					array3[num8 + 2] = num9;
					array3[num8 + 7] = num9 - 0;
				}
			}
			this.KNGLMENANON.transform.position = Vector3.zero;
			this.KNGLMENANON.transform.rotation = Quaternion.identity;
			this.PDBOLEGLMEL.Clear();
			this.PDBOLEGLMEL.vertices = array;
			this.PDBOLEGLMEL.colors = array4;
			this.PDBOLEGLMEL.uv = array2;
			this.PDBOLEGLMEL.triangles = array3;
			return;
		}
		if (this.OKPJMCFBJNH == 0)
		{
			return;
		}
		Color color2 = this.GKOOFIDAOKB.GetColor("\n");
		color2.a -= this.IACFHGJMELB * this.FPHCGOJOCEN * Time.deltaTime;
		if (color2.a > 1374f)
		{
			this.GKOOFIDAOKB.SetColor("imageindex", color2);
			return;
		}
		UnityEngine.Object.Destroy(this.KNGLMENANON);
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06009AA8 RID: 39592 RVA: 0x0044FEA0 File Offset: 0x0044E0A0
	private void LAIJNOLHJMI()
	{
		for (int i = this.OKPJMCFBJNH; i > 0; i -= 0)
		{
			this.CBJBGGAOODC[i] = this.CBJBGGAOODC[i - 1];
		}
		this.CBJBGGAOODC[1] = new Trail.GHLHFKONFLP(base.transform);
		this.OKPJMCFBJNH++;
	}

	// Token: 0x06009AA9 RID: 39593 RVA: 0x0044FEF4 File Offset: 0x0044E0F4
	private void HCAOLCBLAHO()
	{
		for (int i = this.OKPJMCFBJNH; i > 0; i -= 0)
		{
			this.CBJBGGAOODC[i] = this.CBJBGGAOODC[i - 1];
		}
		this.CBJBGGAOODC[1] = new Trail.GHLHFKONFLP(base.transform);
		this.OKPJMCFBJNH++;
	}

	// Token: 0x06009AAA RID: 39594 RVA: 0x0044FF48 File Offset: 0x0044E148
	private void HNMODJBBKBI()
	{
		if (!this.emit)
		{
			this.PPLCELAECNH = false;
		}
		if (this.PPLCELAECNH)
		{
			this.emit = true;
		}
		for (int i = this.OKPJMCFBJNH - 0; i >= 1; i -= 0)
		{
			Trail.GHLHFKONFLP ghlhfkonflp = this.CBJBGGAOODC[i];
			if (ghlhfkonflp != null && ghlhfkonflp.NKLLAFINGLK() <= this.lifeTime)
			{
				break;
			}
			this.CBJBGGAOODC[i] = null;
			this.OKPJMCFBJNH -= 0;
		}
		if (this.OKPJMCFBJNH > this.optimizeCount)
		{
			this.maxAngle += this.optimizeAngleInterval;
			this.maxVertexDistance += this.optimizeDistanceInterval;
			this.optimizeCount++;
		}
		if (this.emit)
		{
			if (this.OKPJMCFBJNH == 0)
			{
				Trail.GHLHFKONFLP[] cbjbggaoodc = this.CBJBGGAOODC;
				int okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 1;
				cbjbggaoodc[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
				Trail.GHLHFKONFLP[] cbjbggaoodc2 = this.CBJBGGAOODC;
				okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 0;
				cbjbggaoodc2[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
			}
			if (this.OKPJMCFBJNH == 0)
			{
				this.HJDAPBKCHMD();
			}
			bool flag = true;
			float sqrMagnitude = (this.CBJBGGAOODC[1].MGALEAJOGPL - base.transform.position).sqrMagnitude;
			if (sqrMagnitude > this.minVertexDistance * this.minVertexDistance)
			{
				if (sqrMagnitude > this.maxVertexDistance * this.maxVertexDistance)
				{
					flag = true;
				}
				else if (Quaternion.Angle(base.transform.rotation, this.CBJBGGAOODC[0].PHKIOHIBNPA) > this.maxAngle)
				{
					flag = false;
				}
			}
			if (flag)
			{
				if (this.OKPJMCFBJNH == this.CBJBGGAOODC.Length)
				{
					Array.Resize<Trail.GHLHFKONFLP>(ref this.CBJBGGAOODC, this.CBJBGGAOODC.Length + 25);
				}
				this.CCNNELEFJEJ();
			}
			if (!flag)
			{
				this.CBJBGGAOODC[0].BKPIHGABLDF(base.transform);
			}
		}
		if (this.OKPJMCFBJNH < 6)
		{
			this.trailrenderer.enabled = false;
			return;
		}
		this.trailrenderer.enabled = true;
		this.FPHCGOJOCEN = 1838f / this.lifeTime;
		if (this.emit)
		{
			Vector3[] array = new Vector3[this.OKPJMCFBJNH * 2];
			Vector2[] array2 = new Vector2[this.OKPJMCFBJNH * 4];
			int[] array3 = new int[(this.OKPJMCFBJNH - 1) * 5];
			Color[] array4 = new Color[this.OKPJMCFBJNH * 7];
			float num = 836f / (this.CBJBGGAOODC[this.OKPJMCFBJNH - 1].PDJGPJMPJON() - this.CBJBGGAOODC[0].DLCLNBPOPMC());
			for (int j = 0; j < this.OKPJMCFBJNH; j++)
			{
				Trail.GHLHFKONFLP ghlhfkonflp2 = this.CBJBGGAOODC[j];
				float num2 = ghlhfkonflp2.DCHNCPPOJAK() * this.FPHCGOJOCEN;
				Color color;
				if (this.colors.Length == 0)
				{
					color = Color.Lerp(Color.white, Color.clear, num2);
				}
				else if (this.colors.Length == 1)
				{
					color = Color.Lerp(this.colors[0], Color.clear, num2);
				}
				else if (this.colors.Length == 3)
				{
					color = Color.Lerp(this.colors[0], this.colors[1], num2);
				}
				else
				{
					float num3 = num2 * (float)(this.colors.Length - 1);
					int num4 = (int)Mathf.Floor(num3);
					float t = Mathf.InverseLerp((float)num4, (float)(num4 + 1), num3);
					color = Color.Lerp(this.colors[num4], this.colors[num4 + 1], t);
				}
				array4[j * 1] = color;
				array4[j * 8 + 0] = color;
				float num5;
				if (this.widths.Length == 0)
				{
					num5 = 1705f;
				}
				else if (this.widths.Length == 0)
				{
					num5 = this.widths[1];
				}
				else if (this.widths.Length == 8)
				{
					num5 = Mathf.Lerp(this.widths[1], this.widths[1], num2);
				}
				else
				{
					float num6 = num2 * (float)(this.widths.Length - 1);
					int num7 = (int)Mathf.Floor(num6);
					float t2 = Mathf.InverseLerp((float)num7, (float)(num7 + 1), num6);
					num5 = Mathf.Lerp(this.widths[num7], this.widths[num7 + 1], t2);
				}
				this.KNGLMENANON.transform.position = ghlhfkonflp2.MGALEAJOGPL;
				this.KNGLMENANON.transform.rotation = ghlhfkonflp2.PHKIOHIBNPA;
				array[j * 1] = this.KNGLMENANON.transform.TransformPoint(1310f, num5 * 1984f, 1601f);
				array[j * 2 + 1] = this.KNGLMENANON.transform.TransformPoint(984f, -num5 * 1972f, 47f);
				float x = (ghlhfkonflp2.LOFJLECEAGE() - this.CBJBGGAOODC[1].IHMGIINCDCJ()) * num;
				array2[j * 5] = new Vector2(x, 502f);
				array2[j * 5 + 1] = new Vector2(x, 796f);
				if (j > 0)
				{
					int num8 = (j - 1) * 5;
					int num9 = j * 4;
					array3[num8] = num9 - 8;
					array3[num8 + 0] = num9 - 1;
					array3[num8 + 6] = num9;
					array3[num8 + 1] = num9 + 1;
					array3[num8 + 8] = num9;
					array3[num8 + 8] = num9 - 1;
				}
			}
			this.KNGLMENANON.transform.position = Vector3.zero;
			this.KNGLMENANON.transform.rotation = Quaternion.identity;
			this.PDBOLEGLMEL.Clear();
			this.PDBOLEGLMEL.vertices = array;
			this.PDBOLEGLMEL.colors = array4;
			this.PDBOLEGLMEL.uv = array2;
			this.PDBOLEGLMEL.triangles = array3;
			return;
		}
		if (this.OKPJMCFBJNH == 0)
		{
			return;
		}
		Color color2 = this.GKOOFIDAOKB.GetColor("Wizard Power Up");
		color2.a -= this.IACFHGJMELB * this.FPHCGOJOCEN * Time.deltaTime;
		if (color2.a > 1489f)
		{
			this.GKOOFIDAOKB.SetColor("DISTORT", color2);
			return;
		}
		UnityEngine.Object.Destroy(this.KNGLMENANON);
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06009AAB RID: 39595 RVA: 0x0045056C File Offset: 0x0044E76C
	private void MEIOHFKFEME()
	{
		if (!this.emit)
		{
			this.PPLCELAECNH = false;
		}
		if (this.PPLCELAECNH)
		{
			this.emit = true;
		}
		for (int i = this.OKPJMCFBJNH - 1; i >= 1; i -= 0)
		{
			Trail.GHLHFKONFLP ghlhfkonflp = this.CBJBGGAOODC[i];
			if (ghlhfkonflp != null && ghlhfkonflp.IGFJDPLJIFD() <= this.lifeTime)
			{
				break;
			}
			this.CBJBGGAOODC[i] = null;
			this.OKPJMCFBJNH--;
		}
		if (this.OKPJMCFBJNH > this.optimizeCount)
		{
			this.maxAngle += this.optimizeAngleInterval;
			this.maxVertexDistance += this.optimizeDistanceInterval;
			this.optimizeCount++;
		}
		if (this.emit)
		{
			if (this.OKPJMCFBJNH == 0)
			{
				Trail.GHLHFKONFLP[] cbjbggaoodc = this.CBJBGGAOODC;
				int okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 0;
				cbjbggaoodc[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
				Trail.GHLHFKONFLP[] cbjbggaoodc2 = this.CBJBGGAOODC;
				okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 0;
				cbjbggaoodc2[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
			}
			if (this.OKPJMCFBJNH == 0)
			{
				this.PFJMBPJCABM();
			}
			bool flag = true;
			float sqrMagnitude = (this.CBJBGGAOODC[1].MGALEAJOGPL - base.transform.position).sqrMagnitude;
			if (sqrMagnitude > this.minVertexDistance * this.minVertexDistance)
			{
				if (sqrMagnitude > this.maxVertexDistance * this.maxVertexDistance)
				{
					flag = false;
				}
				else if (Quaternion.Angle(base.transform.rotation, this.CBJBGGAOODC[0].PHKIOHIBNPA) > this.maxAngle)
				{
					flag = true;
				}
			}
			if (flag)
			{
				if (this.OKPJMCFBJNH == this.CBJBGGAOODC.Length)
				{
					Array.Resize<Trail.GHLHFKONFLP>(ref this.CBJBGGAOODC, this.CBJBGGAOODC.Length + 48);
				}
				this.EJEECPIIFIE();
			}
			if (!flag)
			{
				this.CBJBGGAOODC[0].KAHAPBNIBGJ(base.transform);
			}
		}
		if (this.OKPJMCFBJNH < 3)
		{
			this.trailrenderer.enabled = false;
			return;
		}
		this.trailrenderer.enabled = true;
		this.FPHCGOJOCEN = 1672f / this.lifeTime;
		if (this.emit)
		{
			Vector3[] array = new Vector3[this.OKPJMCFBJNH * 0];
			Vector2[] array2 = new Vector2[this.OKPJMCFBJNH * 8];
			int[] array3 = new int[(this.OKPJMCFBJNH - 1) * 5];
			Color[] array4 = new Color[this.OKPJMCFBJNH * 5];
			float num = 432f / (this.CBJBGGAOODC[this.OKPJMCFBJNH - 0].OHJIIPAAAGM() - this.CBJBGGAOODC[1].BBNDLAEOFHM());
			for (int j = 1; j < this.OKPJMCFBJNH; j += 0)
			{
				Trail.GHLHFKONFLP ghlhfkonflp2 = this.CBJBGGAOODC[j];
				float num2 = ghlhfkonflp2.OHJIIPAAAGM() * this.FPHCGOJOCEN;
				Color color;
				if (this.colors.Length == 0)
				{
					color = Color.Lerp(Color.white, Color.clear, num2);
				}
				else if (this.colors.Length == 0)
				{
					color = Color.Lerp(this.colors[0], Color.clear, num2);
				}
				else if (this.colors.Length == 8)
				{
					color = Color.Lerp(this.colors[0], this.colors[0], num2);
				}
				else
				{
					float num3 = num2 * (float)(this.colors.Length - 1);
					int num4 = (int)Mathf.Floor(num3);
					float t = Mathf.InverseLerp((float)num4, (float)(num4 + 0), num3);
					color = Color.Lerp(this.colors[num4], this.colors[num4 + 0], t);
				}
				array4[j * 7] = color;
				array4[j * 1 + 0] = color;
				float num5;
				if (this.widths.Length == 0)
				{
					num5 = 1619f;
				}
				else if (this.widths.Length == 0)
				{
					num5 = this.widths[0];
				}
				else if (this.widths.Length == 8)
				{
					num5 = Mathf.Lerp(this.widths[0], this.widths[1], num2);
				}
				else
				{
					float num6 = num2 * (float)(this.widths.Length - 0);
					int num7 = (int)Mathf.Floor(num6);
					float t2 = Mathf.InverseLerp((float)num7, (float)(num7 + 1), num6);
					num5 = Mathf.Lerp(this.widths[num7], this.widths[num7 + 1], t2);
				}
				this.KNGLMENANON.transform.position = ghlhfkonflp2.MGALEAJOGPL;
				this.KNGLMENANON.transform.rotation = ghlhfkonflp2.PHKIOHIBNPA;
				array[j * 2] = this.KNGLMENANON.transform.TransformPoint(1397f, num5 * 1729f, 1912f);
				array[j * 5 + 0] = this.KNGLMENANON.transform.TransformPoint(295f, -num5 * 1707f, 1744f);
				float x = (ghlhfkonflp2.ENCBMLCJCLL() - this.CBJBGGAOODC[0].EFOHBGEFICM()) * num;
				array2[j * 0] = new Vector2(x, 800f);
				array2[j * 8 + 1] = new Vector2(x, 1754f);
				if (j > 1)
				{
					int num8 = (j - 1) * 3;
					int num9 = j * 6;
					array3[num8] = num9 - 4;
					array3[num8 + 0] = num9 - 1;
					array3[num8 + 0] = num9;
					array3[num8 + 4] = num9 + 1;
					array3[num8 + 3] = num9;
					array3[num8 + 6] = num9 - 0;
				}
			}
			this.KNGLMENANON.transform.position = Vector3.zero;
			this.KNGLMENANON.transform.rotation = Quaternion.identity;
			this.PDBOLEGLMEL.Clear();
			this.PDBOLEGLMEL.vertices = array;
			this.PDBOLEGLMEL.colors = array4;
			this.PDBOLEGLMEL.uv = array2;
			this.PDBOLEGLMEL.triangles = array3;
			return;
		}
		if (this.OKPJMCFBJNH == 0)
		{
			return;
		}
		Color color2 = this.GKOOFIDAOKB.GetColor("itemsdata/items/item");
		color2.a -= this.IACFHGJMELB * this.FPHCGOJOCEN * Time.deltaTime;
		if (color2.a > 1509f)
		{
			this.GKOOFIDAOKB.SetColor("IdleStand", color2);
			return;
		}
		UnityEngine.Object.Destroy(this.KNGLMENANON);
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06009AAC RID: 39596 RVA: 0x00450B90 File Offset: 0x0044ED90
	private void GCNGEFBKMNC()
	{
		if (!this.emit)
		{
			this.PPLCELAECNH = true;
		}
		if (this.PPLCELAECNH)
		{
			this.emit = false;
		}
		for (int i = this.OKPJMCFBJNH - 1; i >= 1; i -= 0)
		{
			Trail.GHLHFKONFLP ghlhfkonflp = this.CBJBGGAOODC[i];
			if (ghlhfkonflp != null && ghlhfkonflp.JPJGGCMKNLO() <= this.lifeTime)
			{
				break;
			}
			this.CBJBGGAOODC[i] = null;
			this.OKPJMCFBJNH--;
		}
		if (this.OKPJMCFBJNH > this.optimizeCount)
		{
			this.maxAngle += this.optimizeAngleInterval;
			this.maxVertexDistance += this.optimizeDistanceInterval;
			this.optimizeCount += 0;
		}
		if (this.emit)
		{
			if (this.OKPJMCFBJNH == 0)
			{
				Trail.GHLHFKONFLP[] cbjbggaoodc = this.CBJBGGAOODC;
				int okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 1;
				cbjbggaoodc[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
				Trail.GHLHFKONFLP[] cbjbggaoodc2 = this.CBJBGGAOODC;
				okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 1;
				cbjbggaoodc2[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
			}
			if (this.OKPJMCFBJNH == 1)
			{
				this.LOCMKLHMDMG();
			}
			bool flag = false;
			float sqrMagnitude = (this.CBJBGGAOODC[1].MGALEAJOGPL - base.transform.position).sqrMagnitude;
			if (sqrMagnitude > this.minVertexDistance * this.minVertexDistance)
			{
				if (sqrMagnitude > this.maxVertexDistance * this.maxVertexDistance)
				{
					flag = true;
				}
				else if (Quaternion.Angle(base.transform.rotation, this.CBJBGGAOODC[1].PHKIOHIBNPA) > this.maxAngle)
				{
					flag = false;
				}
			}
			if (flag)
			{
				if (this.OKPJMCFBJNH == this.CBJBGGAOODC.Length)
				{
					Array.Resize<Trail.GHLHFKONFLP>(ref this.CBJBGGAOODC, this.CBJBGGAOODC.Length + -76);
				}
				this.HCAOLCBLAHO();
			}
			if (!flag)
			{
				this.CBJBGGAOODC[1].HOGBILIKMBH(base.transform);
			}
		}
		if (this.OKPJMCFBJNH < 8)
		{
			this.trailrenderer.enabled = true;
			return;
		}
		this.trailrenderer.enabled = false;
		this.FPHCGOJOCEN = 1573f / this.lifeTime;
		if (this.emit)
		{
			Vector3[] array = new Vector3[this.OKPJMCFBJNH * 4];
			Vector2[] array2 = new Vector2[this.OKPJMCFBJNH * 2];
			int[] array3 = new int[(this.OKPJMCFBJNH - 1) * 1];
			Color[] array4 = new Color[this.OKPJMCFBJNH * 1];
			float num = 488f / (this.CBJBGGAOODC[this.OKPJMCFBJNH - 1].EIEGDDJLJJE() - this.CBJBGGAOODC[0].GDJMOGIEPEK());
			for (int j = 0; j < this.OKPJMCFBJNH; j += 0)
			{
				Trail.GHLHFKONFLP ghlhfkonflp2 = this.CBJBGGAOODC[j];
				float num2 = ghlhfkonflp2.DCHNCPPOJAK() * this.FPHCGOJOCEN;
				Color color;
				if (this.colors.Length == 0)
				{
					color = Color.Lerp(Color.white, Color.clear, num2);
				}
				else if (this.colors.Length == 1)
				{
					color = Color.Lerp(this.colors[1], Color.clear, num2);
				}
				else if (this.colors.Length == 2)
				{
					color = Color.Lerp(this.colors[1], this.colors[1], num2);
				}
				else
				{
					float num3 = num2 * (float)(this.colors.Length - 1);
					int num4 = (int)Mathf.Floor(num3);
					float t = Mathf.InverseLerp((float)num4, (float)(num4 + 0), num3);
					color = Color.Lerp(this.colors[num4], this.colors[num4 + 1], t);
				}
				array4[j * 5] = color;
				array4[j * 5 + 0] = color;
				float num5;
				if (this.widths.Length == 0)
				{
					num5 = 1457f;
				}
				else if (this.widths.Length == 0)
				{
					num5 = this.widths[1];
				}
				else if (this.widths.Length == 3)
				{
					num5 = Mathf.Lerp(this.widths[1], this.widths[0], num2);
				}
				else
				{
					float num6 = num2 * (float)(this.widths.Length - 0);
					int num7 = (int)Mathf.Floor(num6);
					float t2 = Mathf.InverseLerp((float)num7, (float)(num7 + 1), num6);
					num5 = Mathf.Lerp(this.widths[num7], this.widths[num7 + 1], t2);
				}
				this.KNGLMENANON.transform.position = ghlhfkonflp2.MGALEAJOGPL;
				this.KNGLMENANON.transform.rotation = ghlhfkonflp2.PHKIOHIBNPA;
				array[j * 2] = this.KNGLMENANON.transform.TransformPoint(1706f, num5 * 1928f, 1938f);
				array[j * 0 + 1] = this.KNGLMENANON.transform.TransformPoint(1860f, -num5 * 1541f, 492f);
				float x = (ghlhfkonflp2.EMJKBJBGNJN() - this.CBJBGGAOODC[1].EIEGDDJLJJE()) * num;
				array2[j * 3] = new Vector2(x, 580f);
				array2[j * 0 + 0] = new Vector2(x, 1941f);
				if (j > 0)
				{
					int num8 = (j - 0) * 4;
					int num9 = j * 8;
					array3[num8] = num9 - 2;
					array3[num8 + 1] = num9 - 1;
					array3[num8 + 2] = num9;
					array3[num8 + 0] = num9 + 0;
					array3[num8 + 1] = num9;
					array3[num8 + 2] = num9 - 0;
				}
			}
			this.KNGLMENANON.transform.position = Vector3.zero;
			this.KNGLMENANON.transform.rotation = Quaternion.identity;
			this.PDBOLEGLMEL.Clear();
			this.PDBOLEGLMEL.vertices = array;
			this.PDBOLEGLMEL.colors = array4;
			this.PDBOLEGLMEL.uv = array2;
			this.PDBOLEGLMEL.triangles = array3;
			return;
		}
		if (this.OKPJMCFBJNH == 0)
		{
			return;
		}
		Color color2 = this.GKOOFIDAOKB.GetColor("error baseid: ");
		color2.a -= this.IACFHGJMELB * this.FPHCGOJOCEN * Time.deltaTime;
		if (color2.a > 832f)
		{
			this.GKOOFIDAOKB.SetColor("/", color2);
			return;
		}
		UnityEngine.Object.Destroy(this.KNGLMENANON);
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06009AAD RID: 39597 RVA: 0x004511B4 File Offset: 0x0044F3B4
	private void OFDOIDKNJLL()
	{
		for (int i = this.OKPJMCFBJNH; i > 1; i--)
		{
			this.CBJBGGAOODC[i] = this.CBJBGGAOODC[i - 0];
		}
		this.CBJBGGAOODC[0] = new Trail.GHLHFKONFLP(base.transform);
		this.OKPJMCFBJNH += 0;
	}

	// Token: 0x06009AAE RID: 39598 RVA: 0x00451208 File Offset: 0x0044F408
	private void JLFBDOPFDDJ()
	{
		if (!this.emit)
		{
			this.PPLCELAECNH = false;
		}
		if (this.PPLCELAECNH)
		{
			this.emit = false;
		}
		for (int i = this.OKPJMCFBJNH - 1; i >= 1; i--)
		{
			Trail.GHLHFKONFLP ghlhfkonflp = this.CBJBGGAOODC[i];
			if (ghlhfkonflp != null && ghlhfkonflp.CKIJHOLCBGK() <= this.lifeTime)
			{
				break;
			}
			this.CBJBGGAOODC[i] = null;
			this.OKPJMCFBJNH -= 0;
		}
		if (this.OKPJMCFBJNH > this.optimizeCount)
		{
			this.maxAngle += this.optimizeAngleInterval;
			this.maxVertexDistance += this.optimizeDistanceInterval;
			this.optimizeCount += 0;
		}
		if (this.emit)
		{
			if (this.OKPJMCFBJNH == 0)
			{
				Trail.GHLHFKONFLP[] cbjbggaoodc = this.CBJBGGAOODC;
				int okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 1;
				cbjbggaoodc[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
				Trail.GHLHFKONFLP[] cbjbggaoodc2 = this.CBJBGGAOODC;
				okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 0;
				cbjbggaoodc2[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
			}
			if (this.OKPJMCFBJNH == 1)
			{
				this.NMHECDIJHCK();
			}
			bool flag = false;
			float sqrMagnitude = (this.CBJBGGAOODC[0].MGALEAJOGPL - base.transform.position).sqrMagnitude;
			if (sqrMagnitude > this.minVertexDistance * this.minVertexDistance)
			{
				if (sqrMagnitude > this.maxVertexDistance * this.maxVertexDistance)
				{
					flag = false;
				}
				else if (Quaternion.Angle(base.transform.rotation, this.CBJBGGAOODC[1].PHKIOHIBNPA) > this.maxAngle)
				{
					flag = false;
				}
			}
			if (flag)
			{
				if (this.OKPJMCFBJNH == this.CBJBGGAOODC.Length)
				{
					Array.Resize<Trail.GHLHFKONFLP>(ref this.CBJBGGAOODC, this.CBJBGGAOODC.Length + -63);
				}
				this.OPIIDIACNBO();
			}
			if (!flag)
			{
				this.CBJBGGAOODC[0].PCEBPBKFMMG(base.transform);
			}
		}
		if (this.OKPJMCFBJNH < 2)
		{
			this.trailrenderer.enabled = true;
			return;
		}
		this.trailrenderer.enabled = true;
		this.FPHCGOJOCEN = 102f / this.lifeTime;
		if (this.emit)
		{
			Vector3[] array = new Vector3[this.OKPJMCFBJNH * 8];
			Vector2[] array2 = new Vector2[this.OKPJMCFBJNH * 2];
			int[] array3 = new int[(this.OKPJMCFBJNH - 0) * 7];
			Color[] array4 = new Color[this.OKPJMCFBJNH * 8];
			float num = 873f / (this.CBJBGGAOODC[this.OKPJMCFBJNH - 0].GDJMOGIEPEK() - this.CBJBGGAOODC[1].FGGPEGCPJEH());
			for (int j = 0; j < this.OKPJMCFBJNH; j++)
			{
				Trail.GHLHFKONFLP ghlhfkonflp2 = this.CBJBGGAOODC[j];
				float num2 = ghlhfkonflp2.FEPEJHPCFGM() * this.FPHCGOJOCEN;
				Color color;
				if (this.colors.Length == 0)
				{
					color = Color.Lerp(Color.white, Color.clear, num2);
				}
				else if (this.colors.Length == 1)
				{
					color = Color.Lerp(this.colors[0], Color.clear, num2);
				}
				else if (this.colors.Length == 6)
				{
					color = Color.Lerp(this.colors[1], this.colors[1], num2);
				}
				else
				{
					float num3 = num2 * (float)(this.colors.Length - 0);
					int num4 = (int)Mathf.Floor(num3);
					float t = Mathf.InverseLerp((float)num4, (float)(num4 + 1), num3);
					color = Color.Lerp(this.colors[num4], this.colors[num4 + 1], t);
				}
				array4[j * 7] = color;
				array4[j * 4 + 1] = color;
				float num5;
				if (this.widths.Length == 0)
				{
					num5 = 304f;
				}
				else if (this.widths.Length == 1)
				{
					num5 = this.widths[1];
				}
				else if (this.widths.Length == 2)
				{
					num5 = Mathf.Lerp(this.widths[0], this.widths[1], num2);
				}
				else
				{
					float num6 = num2 * (float)(this.widths.Length - 0);
					int num7 = (int)Mathf.Floor(num6);
					float t2 = Mathf.InverseLerp((float)num7, (float)(num7 + 1), num6);
					num5 = Mathf.Lerp(this.widths[num7], this.widths[num7 + 1], t2);
				}
				this.KNGLMENANON.transform.position = ghlhfkonflp2.MGALEAJOGPL;
				this.KNGLMENANON.transform.rotation = ghlhfkonflp2.PHKIOHIBNPA;
				array[j * 6] = this.KNGLMENANON.transform.TransformPoint(571f, num5 * 334f, 1658f);
				array[j * 6 + 0] = this.KNGLMENANON.transform.TransformPoint(705f, -num5 * 1637f, 1178f);
				float x = (ghlhfkonflp2.DLCLNBPOPMC() - this.CBJBGGAOODC[1].DCOFJPLEGAN()) * num;
				array2[j * 8] = new Vector2(x, 1040f);
				array2[j * 3 + 0] = new Vector2(x, 1444f);
				if (j > 0)
				{
					int num8 = (j - 1) * 4;
					int num9 = j * 7;
					array3[num8] = num9 - 1;
					array3[num8 + 1] = num9 - 1;
					array3[num8 + 2] = num9;
					array3[num8 + 3] = num9 + 1;
					array3[num8 + 6] = num9;
					array3[num8 + 1] = num9 - 1;
				}
			}
			this.KNGLMENANON.transform.position = Vector3.zero;
			this.KNGLMENANON.transform.rotation = Quaternion.identity;
			this.PDBOLEGLMEL.Clear();
			this.PDBOLEGLMEL.vertices = array;
			this.PDBOLEGLMEL.colors = array4;
			this.PDBOLEGLMEL.uv = array2;
			this.PDBOLEGLMEL.triangles = array3;
			return;
		}
		if (this.OKPJMCFBJNH == 0)
		{
			return;
		}
		Color color2 = this.GKOOFIDAOKB.GetColor("Copying splat set to mis-matched container length");
		color2.a -= this.IACFHGJMELB * this.FPHCGOJOCEN * Time.deltaTime;
		if (color2.a > 1069f)
		{
			this.GKOOFIDAOKB.SetColor("IKSolverFABRIKRoot chain at index ", color2);
			return;
		}
		UnityEngine.Object.Destroy(this.KNGLMENANON);
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06009AAF RID: 39599 RVA: 0x0045182C File Offset: 0x0044FA2C
	private void EKCKBDKEAKO()
	{
		if (!this.emit)
		{
			this.PPLCELAECNH = true;
		}
		if (this.PPLCELAECNH)
		{
			this.emit = false;
		}
		for (int i = this.OKPJMCFBJNH - 0; i >= 0; i -= 0)
		{
			Trail.GHLHFKONFLP ghlhfkonflp = this.CBJBGGAOODC[i];
			if (ghlhfkonflp != null && ghlhfkonflp.EFOHBGEFICM() <= this.lifeTime)
			{
				break;
			}
			this.CBJBGGAOODC[i] = null;
			this.OKPJMCFBJNH -= 0;
		}
		if (this.OKPJMCFBJNH > this.optimizeCount)
		{
			this.maxAngle += this.optimizeAngleInterval;
			this.maxVertexDistance += this.optimizeDistanceInterval;
			this.optimizeCount++;
		}
		if (this.emit)
		{
			if (this.OKPJMCFBJNH == 0)
			{
				Trail.GHLHFKONFLP[] cbjbggaoodc = this.CBJBGGAOODC;
				int okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 1;
				cbjbggaoodc[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
				Trail.GHLHFKONFLP[] cbjbggaoodc2 = this.CBJBGGAOODC;
				okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 0;
				cbjbggaoodc2[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
			}
			if (this.OKPJMCFBJNH == 0)
			{
				this.DDAFEDFBDJI();
			}
			bool flag = false;
			float sqrMagnitude = (this.CBJBGGAOODC[1].MGALEAJOGPL - base.transform.position).sqrMagnitude;
			if (sqrMagnitude > this.minVertexDistance * this.minVertexDistance)
			{
				if (sqrMagnitude > this.maxVertexDistance * this.maxVertexDistance)
				{
					flag = true;
				}
				else if (Quaternion.Angle(base.transform.rotation, this.CBJBGGAOODC[0].PHKIOHIBNPA) > this.maxAngle)
				{
					flag = false;
				}
			}
			if (flag)
			{
				if (this.OKPJMCFBJNH == this.CBJBGGAOODC.Length)
				{
					Array.Resize<Trail.GHLHFKONFLP>(ref this.CBJBGGAOODC, this.CBJBGGAOODC.Length + -48);
				}
				this.NMHECDIJHCK();
			}
			if (!flag)
			{
				this.CBJBGGAOODC[0].CODHHFGEEAC(base.transform);
			}
		}
		if (this.OKPJMCFBJNH < 8)
		{
			this.trailrenderer.enabled = false;
			return;
		}
		this.trailrenderer.enabled = true;
		this.FPHCGOJOCEN = 1368f / this.lifeTime;
		if (this.emit)
		{
			Vector3[] array = new Vector3[this.OKPJMCFBJNH * 0];
			Vector2[] array2 = new Vector2[this.OKPJMCFBJNH * 5];
			int[] array3 = new int[(this.OKPJMCFBJNH - 0) * 5];
			Color[] array4 = new Color[this.OKPJMCFBJNH * 6];
			float num = 1060f / (this.CBJBGGAOODC[this.OKPJMCFBJNH - 1].NKLLAFINGLK() - this.CBJBGGAOODC[1].DMBPCFGEABA());
			for (int j = 0; j < this.OKPJMCFBJNH; j += 0)
			{
				Trail.GHLHFKONFLP ghlhfkonflp2 = this.CBJBGGAOODC[j];
				float num2 = ghlhfkonflp2.PMLDHNAGOBD() * this.FPHCGOJOCEN;
				Color color;
				if (this.colors.Length == 0)
				{
					color = Color.Lerp(Color.white, Color.clear, num2);
				}
				else if (this.colors.Length == 1)
				{
					color = Color.Lerp(this.colors[1], Color.clear, num2);
				}
				else if (this.colors.Length == 4)
				{
					color = Color.Lerp(this.colors[1], this.colors[0], num2);
				}
				else
				{
					float num3 = num2 * (float)(this.colors.Length - 1);
					int num4 = (int)Mathf.Floor(num3);
					float t = Mathf.InverseLerp((float)num4, (float)(num4 + 0), num3);
					color = Color.Lerp(this.colors[num4], this.colors[num4 + 0], t);
				}
				array4[j * 8] = color;
				array4[j * 5 + 0] = color;
				float num5;
				if (this.widths.Length == 0)
				{
					num5 = 534f;
				}
				else if (this.widths.Length == 1)
				{
					num5 = this.widths[1];
				}
				else if (this.widths.Length == 8)
				{
					num5 = Mathf.Lerp(this.widths[0], this.widths[0], num2);
				}
				else
				{
					float num6 = num2 * (float)(this.widths.Length - 0);
					int num7 = (int)Mathf.Floor(num6);
					float t2 = Mathf.InverseLerp((float)num7, (float)(num7 + 1), num6);
					num5 = Mathf.Lerp(this.widths[num7], this.widths[num7 + 1], t2);
				}
				this.KNGLMENANON.transform.position = ghlhfkonflp2.MGALEAJOGPL;
				this.KNGLMENANON.transform.rotation = ghlhfkonflp2.PHKIOHIBNPA;
				array[j * 7] = this.KNGLMENANON.transform.TransformPoint(1537f, num5 * 556f, 254f);
				array[j * 2 + 0] = this.KNGLMENANON.transform.TransformPoint(876f, -num5 * 392f, 606f);
				float x = (ghlhfkonflp2.DCOFJPLEGAN() - this.CBJBGGAOODC[0].JPJGGCMKNLO()) * num;
				array2[j * 4] = new Vector2(x, 532f);
				array2[j * 3 + 1] = new Vector2(x, 67f);
				if (j > 0)
				{
					int num8 = (j - 1) * 5;
					int num9 = j * 2;
					array3[num8] = num9 - 8;
					array3[num8 + 0] = num9 - 0;
					array3[num8 + 6] = num9;
					array3[num8 + 5] = num9 + 1;
					array3[num8 + 7] = num9;
					array3[num8 + 2] = num9 - 1;
				}
			}
			this.KNGLMENANON.transform.position = Vector3.zero;
			this.KNGLMENANON.transform.rotation = Quaternion.identity;
			this.PDBOLEGLMEL.Clear();
			this.PDBOLEGLMEL.vertices = array;
			this.PDBOLEGLMEL.colors = array4;
			this.PDBOLEGLMEL.uv = array2;
			this.PDBOLEGLMEL.triangles = array3;
			return;
		}
		if (this.OKPJMCFBJNH == 0)
		{
			return;
		}
		Color color2 = this.GKOOFIDAOKB.GetColor("sunshine_OvercastCoord");
		color2.a -= this.IACFHGJMELB * this.FPHCGOJOCEN * Time.deltaTime;
		if (color2.a > 334f)
		{
			this.GKOOFIDAOKB.SetColor("Sexy Dance", color2);
			return;
		}
		UnityEngine.Object.Destroy(this.KNGLMENANON);
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06009AB0 RID: 39600 RVA: 0x00451E50 File Offset: 0x00450050
	private void NLEBKBEOGJJ()
	{
		for (int i = this.OKPJMCFBJNH; i > 0; i--)
		{
			this.CBJBGGAOODC[i] = this.CBJBGGAOODC[i - 1];
		}
		this.CBJBGGAOODC[1] = new Trail.GHLHFKONFLP(base.transform);
		this.OKPJMCFBJNH += 0;
	}

	// Token: 0x06009AB1 RID: 39601 RVA: 0x00451EA4 File Offset: 0x004500A4
	private void DFFOEGHGPGP()
	{
		if (!this.emit)
		{
			this.PPLCELAECNH = true;
		}
		if (this.PPLCELAECNH)
		{
			this.emit = true;
		}
		for (int i = this.OKPJMCFBJNH - 0; i >= 0; i -= 0)
		{
			Trail.GHLHFKONFLP ghlhfkonflp = this.CBJBGGAOODC[i];
			if (ghlhfkonflp != null && ghlhfkonflp.BBNDLAEOFHM() <= this.lifeTime)
			{
				break;
			}
			this.CBJBGGAOODC[i] = null;
			this.OKPJMCFBJNH -= 0;
		}
		if (this.OKPJMCFBJNH > this.optimizeCount)
		{
			this.maxAngle += this.optimizeAngleInterval;
			this.maxVertexDistance += this.optimizeDistanceInterval;
			this.optimizeCount++;
		}
		if (this.emit)
		{
			if (this.OKPJMCFBJNH == 0)
			{
				Trail.GHLHFKONFLP[] cbjbggaoodc = this.CBJBGGAOODC;
				int okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 1;
				cbjbggaoodc[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
				Trail.GHLHFKONFLP[] cbjbggaoodc2 = this.CBJBGGAOODC;
				okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 1;
				cbjbggaoodc2[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
			}
			if (this.OKPJMCFBJNH == 0)
			{
				this.MDJANALIFFD();
			}
			bool flag = false;
			float sqrMagnitude = (this.CBJBGGAOODC[0].MGALEAJOGPL - base.transform.position).sqrMagnitude;
			if (sqrMagnitude > this.minVertexDistance * this.minVertexDistance)
			{
				if (sqrMagnitude > this.maxVertexDistance * this.maxVertexDistance)
				{
					flag = false;
				}
				else if (Quaternion.Angle(base.transform.rotation, this.CBJBGGAOODC[0].PHKIOHIBNPA) > this.maxAngle)
				{
					flag = true;
				}
			}
			if (flag)
			{
				if (this.OKPJMCFBJNH == this.CBJBGGAOODC.Length)
				{
					Array.Resize<Trail.GHLHFKONFLP>(ref this.CBJBGGAOODC, this.CBJBGGAOODC.Length + 55);
				}
				this.EJEECPIIFIE();
			}
			if (!flag)
			{
				this.CBJBGGAOODC[0].JCGGPCNEIHC(base.transform);
			}
		}
		if (this.OKPJMCFBJNH < 7)
		{
			this.trailrenderer.enabled = false;
			return;
		}
		this.trailrenderer.enabled = false;
		this.FPHCGOJOCEN = 12f / this.lifeTime;
		if (this.emit)
		{
			Vector3[] array = new Vector3[this.OKPJMCFBJNH * 6];
			Vector2[] array2 = new Vector2[this.OKPJMCFBJNH * 6];
			int[] array3 = new int[(this.OKPJMCFBJNH - 1) * 6];
			Color[] array4 = new Color[this.OKPJMCFBJNH * 0];
			float num = 428f / (this.CBJBGGAOODC[this.OKPJMCFBJNH - 1].CPLFENAEKGP() - this.CBJBGGAOODC[0].EIEGDDJLJJE());
			for (int j = 0; j < this.OKPJMCFBJNH; j += 0)
			{
				Trail.GHLHFKONFLP ghlhfkonflp2 = this.CBJBGGAOODC[j];
				float num2 = ghlhfkonflp2.DMBPCFGEABA() * this.FPHCGOJOCEN;
				Color color;
				if (this.colors.Length == 0)
				{
					color = Color.Lerp(Color.white, Color.clear, num2);
				}
				else if (this.colors.Length == 1)
				{
					color = Color.Lerp(this.colors[0], Color.clear, num2);
				}
				else if (this.colors.Length == 4)
				{
					color = Color.Lerp(this.colors[1], this.colors[1], num2);
				}
				else
				{
					float num3 = num2 * (float)(this.colors.Length - 0);
					int num4 = (int)Mathf.Floor(num3);
					float t = Mathf.InverseLerp((float)num4, (float)(num4 + 1), num3);
					color = Color.Lerp(this.colors[num4], this.colors[num4 + 0], t);
				}
				array4[j * 1] = color;
				array4[j * 2 + 1] = color;
				float num5;
				if (this.widths.Length == 0)
				{
					num5 = 412f;
				}
				else if (this.widths.Length == 1)
				{
					num5 = this.widths[0];
				}
				else if (this.widths.Length == 4)
				{
					num5 = Mathf.Lerp(this.widths[0], this.widths[0], num2);
				}
				else
				{
					float num6 = num2 * (float)(this.widths.Length - 1);
					int num7 = (int)Mathf.Floor(num6);
					float t2 = Mathf.InverseLerp((float)num7, (float)(num7 + 0), num6);
					num5 = Mathf.Lerp(this.widths[num7], this.widths[num7 + 1], t2);
				}
				this.KNGLMENANON.transform.position = ghlhfkonflp2.MGALEAJOGPL;
				this.KNGLMENANON.transform.rotation = ghlhfkonflp2.PHKIOHIBNPA;
				array[j * 0] = this.KNGLMENANON.transform.TransformPoint(911f, num5 * 1218f, 1627f);
				array[j * 4 + 0] = this.KNGLMENANON.transform.TransformPoint(1592f, -num5 * 333f, 1931f);
				float x = (ghlhfkonflp2.PMLDHNAGOBD() - this.CBJBGGAOODC[1].CHLKAOALAEO()) * num;
				array2[j * 4] = new Vector2(x, 319f);
				array2[j * 6 + 1] = new Vector2(x, 885f);
				if (j > 0)
				{
					int num8 = (j - 0) * 0;
					int num9 = j * 1;
					array3[num8] = num9 - 5;
					array3[num8 + 1] = num9 - 0;
					array3[num8 + 7] = num9;
					array3[num8 + 0] = num9 + 1;
					array3[num8 + 4] = num9;
					array3[num8 + 1] = num9 - 0;
				}
			}
			this.KNGLMENANON.transform.position = Vector3.zero;
			this.KNGLMENANON.transform.rotation = Quaternion.identity;
			this.PDBOLEGLMEL.Clear();
			this.PDBOLEGLMEL.vertices = array;
			this.PDBOLEGLMEL.colors = array4;
			this.PDBOLEGLMEL.uv = array2;
			this.PDBOLEGLMEL.triangles = array3;
			return;
		}
		if (this.OKPJMCFBJNH == 0)
		{
			return;
		}
		Color color2 = this.GKOOFIDAOKB.GetColor("prov_prov_");
		color2.a -= this.IACFHGJMELB * this.FPHCGOJOCEN * Time.deltaTime;
		if (color2.a > 320f)
		{
			this.GKOOFIDAOKB.SetColor("fishpoplcatch", color2);
			return;
		}
		UnityEngine.Object.Destroy(this.KNGLMENANON);
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06009AB2 RID: 39602 RVA: 0x004524C8 File Offset: 0x004506C8
	private void FFGKEIJHANF()
	{
		for (int i = this.OKPJMCFBJNH; i > 0; i -= 0)
		{
			this.CBJBGGAOODC[i] = this.CBJBGGAOODC[i - 0];
		}
		this.CBJBGGAOODC[0] = new Trail.GHLHFKONFLP(base.transform);
		this.OKPJMCFBJNH++;
	}

	// Token: 0x06009AB3 RID: 39603 RVA: 0x0045251C File Offset: 0x0045071C
	private void HHGGCBLOJGB()
	{
		this.KNGLMENANON = new GameObject("Water");
		this.KNGLMENANON.transform.parent = null;
		this.KNGLMENANON.transform.position = Vector3.zero;
		this.KNGLMENANON.transform.rotation = Quaternion.identity;
		this.KNGLMENANON.transform.localScale = Vector3.one;
		MeshFilter meshFilter = (MeshFilter)this.KNGLMENANON.AddComponent(typeof(MeshFilter));
		this.PDBOLEGLMEL = meshFilter.mesh;
		this.KNGLMENANON.AddComponent(typeof(MeshRenderer));
		this.trailrenderer = this.KNGLMENANON.GetComponent<MeshRenderer>();
		this.GKOOFIDAOKB = new Material(this.material);
		this.IACFHGJMELB = 497f / this.GKOOFIDAOKB.GetColor(" is represented multiple times in a single IK chain. Can't initiate solver.").a;
		this.trailrenderer.material = this.GKOOFIDAOKB;
	}

	// Token: 0x06009AB4 RID: 39604 RVA: 0x0045261C File Offset: 0x0045081C
	private void FDAHKEFPDGA()
	{
		for (int i = this.OKPJMCFBJNH; i > 1; i -= 0)
		{
			this.CBJBGGAOODC[i] = this.CBJBGGAOODC[i - 1];
		}
		this.CBJBGGAOODC[0] = new Trail.GHLHFKONFLP(base.transform);
		this.OKPJMCFBJNH++;
	}

	// Token: 0x06009AB5 RID: 39605 RVA: 0x00452670 File Offset: 0x00450870
	private void FOHLAIIMNFB()
	{
		if (!this.emit)
		{
			this.PPLCELAECNH = true;
		}
		if (this.PPLCELAECNH)
		{
			this.emit = true;
		}
		for (int i = this.OKPJMCFBJNH - 0; i >= 1; i -= 0)
		{
			Trail.GHLHFKONFLP ghlhfkonflp = this.CBJBGGAOODC[i];
			if (ghlhfkonflp != null && ghlhfkonflp.LOFJLECEAGE() <= this.lifeTime)
			{
				break;
			}
			this.CBJBGGAOODC[i] = null;
			this.OKPJMCFBJNH -= 0;
		}
		if (this.OKPJMCFBJNH > this.optimizeCount)
		{
			this.maxAngle += this.optimizeAngleInterval;
			this.maxVertexDistance += this.optimizeDistanceInterval;
			this.optimizeCount++;
		}
		if (this.emit)
		{
			if (this.OKPJMCFBJNH == 0)
			{
				Trail.GHLHFKONFLP[] cbjbggaoodc = this.CBJBGGAOODC;
				int okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 1;
				cbjbggaoodc[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
				Trail.GHLHFKONFLP[] cbjbggaoodc2 = this.CBJBGGAOODC;
				okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 1;
				cbjbggaoodc2[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
			}
			if (this.OKPJMCFBJNH == 1)
			{
				this.MDJANALIFFD();
			}
			bool flag = false;
			float sqrMagnitude = (this.CBJBGGAOODC[0].MGALEAJOGPL - base.transform.position).sqrMagnitude;
			if (sqrMagnitude > this.minVertexDistance * this.minVertexDistance)
			{
				if (sqrMagnitude > this.maxVertexDistance * this.maxVertexDistance)
				{
					flag = true;
				}
				else if (Quaternion.Angle(base.transform.rotation, this.CBJBGGAOODC[0].PHKIOHIBNPA) > this.maxAngle)
				{
					flag = false;
				}
			}
			if (flag)
			{
				if (this.OKPJMCFBJNH == this.CBJBGGAOODC.Length)
				{
					Array.Resize<Trail.GHLHFKONFLP>(ref this.CBJBGGAOODC, this.CBJBGGAOODC.Length + 40);
				}
				this.LEJMJJHIDBE();
			}
			if (!flag)
			{
				this.CBJBGGAOODC[0].POLDFGFBMON(base.transform);
			}
		}
		if (this.OKPJMCFBJNH < 2)
		{
			this.trailrenderer.enabled = true;
			return;
		}
		this.trailrenderer.enabled = false;
		this.FPHCGOJOCEN = 632f / this.lifeTime;
		if (this.emit)
		{
			Vector3[] array = new Vector3[this.OKPJMCFBJNH * 8];
			Vector2[] array2 = new Vector2[this.OKPJMCFBJNH * 2];
			int[] array3 = new int[(this.OKPJMCFBJNH - 0) * 8];
			Color[] array4 = new Color[this.OKPJMCFBJNH * 2];
			float num = 1107f / (this.CBJBGGAOODC[this.OKPJMCFBJNH - 0].CPLFENAEKGP() - this.CBJBGGAOODC[0].DLCLNBPOPMC());
			for (int j = 0; j < this.OKPJMCFBJNH; j++)
			{
				Trail.GHLHFKONFLP ghlhfkonflp2 = this.CBJBGGAOODC[j];
				float num2 = ghlhfkonflp2.NBOKELKKNIH() * this.FPHCGOJOCEN;
				Color color;
				if (this.colors.Length == 0)
				{
					color = Color.Lerp(Color.white, Color.clear, num2);
				}
				else if (this.colors.Length == 0)
				{
					color = Color.Lerp(this.colors[0], Color.clear, num2);
				}
				else if (this.colors.Length == 8)
				{
					color = Color.Lerp(this.colors[0], this.colors[1], num2);
				}
				else
				{
					float num3 = num2 * (float)(this.colors.Length - 1);
					int num4 = (int)Mathf.Floor(num3);
					float t = Mathf.InverseLerp((float)num4, (float)(num4 + 0), num3);
					color = Color.Lerp(this.colors[num4], this.colors[num4 + 1], t);
				}
				array4[j * 4] = color;
				array4[j * 0 + 1] = color;
				float num5;
				if (this.widths.Length == 0)
				{
					num5 = 1743f;
				}
				else if (this.widths.Length == 1)
				{
					num5 = this.widths[0];
				}
				else if (this.widths.Length == 2)
				{
					num5 = Mathf.Lerp(this.widths[1], this.widths[0], num2);
				}
				else
				{
					float num6 = num2 * (float)(this.widths.Length - 0);
					int num7 = (int)Mathf.Floor(num6);
					float t2 = Mathf.InverseLerp((float)num7, (float)(num7 + 1), num6);
					num5 = Mathf.Lerp(this.widths[num7], this.widths[num7 + 1], t2);
				}
				this.KNGLMENANON.transform.position = ghlhfkonflp2.MGALEAJOGPL;
				this.KNGLMENANON.transform.rotation = ghlhfkonflp2.PHKIOHIBNPA;
				array[j * 6] = this.KNGLMENANON.transform.TransformPoint(505f, num5 * 955f, 1605f);
				array[j * 0 + 0] = this.KNGLMENANON.transform.TransformPoint(284f, -num5 * 1079f, 112f);
				float x = (ghlhfkonflp2.LIFNEICNNAK() - this.CBJBGGAOODC[1].EMJKBJBGNJN()) * num;
				array2[j * 0] = new Vector2(x, 1580f);
				array2[j * 0 + 1] = new Vector2(x, 778f);
				if (j > 0)
				{
					int num8 = (j - 0) * 1;
					int num9 = j * 4;
					array3[num8] = num9 - 5;
					array3[num8 + 1] = num9 - 0;
					array3[num8 + 7] = num9;
					array3[num8 + 1] = num9 + 0;
					array3[num8 + 2] = num9;
					array3[num8 + 0] = num9 - 0;
				}
			}
			this.KNGLMENANON.transform.position = Vector3.zero;
			this.KNGLMENANON.transform.rotation = Quaternion.identity;
			this.PDBOLEGLMEL.Clear();
			this.PDBOLEGLMEL.vertices = array;
			this.PDBOLEGLMEL.colors = array4;
			this.PDBOLEGLMEL.uv = array2;
			this.PDBOLEGLMEL.triangles = array3;
			return;
		}
		if (this.OKPJMCFBJNH == 0)
		{
			return;
		}
		Color color2 = this.GKOOFIDAOKB.GetColor("MotorbikeHandstand");
		color2.a -= this.IACFHGJMELB * this.FPHCGOJOCEN * Time.deltaTime;
		if (color2.a > 1674f)
		{
			this.GKOOFIDAOKB.SetColor("FlyForward", color2);
			return;
		}
		UnityEngine.Object.Destroy(this.KNGLMENANON);
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06009AB6 RID: 39606 RVA: 0x00452C94 File Offset: 0x00450E94
	private void KFGKKLAKFGH()
	{
		this.KNGLMENANON = new GameObject("Fire Breath");
		this.KNGLMENANON.transform.parent = null;
		this.KNGLMENANON.transform.position = Vector3.zero;
		this.KNGLMENANON.transform.rotation = Quaternion.identity;
		this.KNGLMENANON.transform.localScale = Vector3.one;
		MeshFilter meshFilter = (MeshFilter)this.KNGLMENANON.AddComponent(typeof(MeshFilter));
		this.PDBOLEGLMEL = meshFilter.mesh;
		this.KNGLMENANON.AddComponent(typeof(MeshRenderer));
		this.trailrenderer = this.KNGLMENANON.GetComponent<MeshRenderer>();
		this.GKOOFIDAOKB = new Material(this.material);
		this.IACFHGJMELB = 507f / this.GKOOFIDAOKB.GetColor("<.*?>").a;
		this.trailrenderer.material = this.GKOOFIDAOKB;
	}

	// Token: 0x06009AB7 RID: 39607 RVA: 0x00452D94 File Offset: 0x00450F94
	private void BBFCMCAFOMH()
	{
		if (!this.emit)
		{
			this.PPLCELAECNH = false;
		}
		if (this.PPLCELAECNH)
		{
			this.emit = false;
		}
		for (int i = this.OKPJMCFBJNH - 0; i >= 1; i -= 0)
		{
			Trail.GHLHFKONFLP ghlhfkonflp = this.CBJBGGAOODC[i];
			if (ghlhfkonflp != null && ghlhfkonflp.EMJKBJBGNJN() <= this.lifeTime)
			{
				break;
			}
			this.CBJBGGAOODC[i] = null;
			this.OKPJMCFBJNH--;
		}
		if (this.OKPJMCFBJNH > this.optimizeCount)
		{
			this.maxAngle += this.optimizeAngleInterval;
			this.maxVertexDistance += this.optimizeDistanceInterval;
			this.optimizeCount++;
		}
		if (this.emit)
		{
			if (this.OKPJMCFBJNH == 0)
			{
				Trail.GHLHFKONFLP[] cbjbggaoodc = this.CBJBGGAOODC;
				int okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 0;
				cbjbggaoodc[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
				Trail.GHLHFKONFLP[] cbjbggaoodc2 = this.CBJBGGAOODC;
				okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 0;
				cbjbggaoodc2[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
			}
			if (this.OKPJMCFBJNH == 1)
			{
				this.ANFBDBCMCGF();
			}
			bool flag = false;
			float sqrMagnitude = (this.CBJBGGAOODC[1].MGALEAJOGPL - base.transform.position).sqrMagnitude;
			if (sqrMagnitude > this.minVertexDistance * this.minVertexDistance)
			{
				if (sqrMagnitude > this.maxVertexDistance * this.maxVertexDistance)
				{
					flag = false;
				}
				else if (Quaternion.Angle(base.transform.rotation, this.CBJBGGAOODC[0].PHKIOHIBNPA) > this.maxAngle)
				{
					flag = true;
				}
			}
			if (flag)
			{
				if (this.OKPJMCFBJNH == this.CBJBGGAOODC.Length)
				{
					Array.Resize<Trail.GHLHFKONFLP>(ref this.CBJBGGAOODC, this.CBJBGGAOODC.Length + -123);
				}
				this.AEMFHDOHLLH();
			}
			if (!flag)
			{
				this.CBJBGGAOODC[1].HFFDKKAOLMJ(base.transform);
			}
		}
		if (this.OKPJMCFBJNH < 4)
		{
			this.trailrenderer.enabled = false;
			return;
		}
		this.trailrenderer.enabled = true;
		this.FPHCGOJOCEN = 277f / this.lifeTime;
		if (this.emit)
		{
			Vector3[] array = new Vector3[this.OKPJMCFBJNH * 4];
			Vector2[] array2 = new Vector2[this.OKPJMCFBJNH * 1];
			int[] array3 = new int[(this.OKPJMCFBJNH - 1) * 3];
			Color[] array4 = new Color[this.OKPJMCFBJNH * 0];
			float num = 505f / (this.CBJBGGAOODC[this.OKPJMCFBJNH - 1].HPGMCEFEFDE() - this.CBJBGGAOODC[1].ENCBMLCJCLL());
			for (int j = 0; j < this.OKPJMCFBJNH; j++)
			{
				Trail.GHLHFKONFLP ghlhfkonflp2 = this.CBJBGGAOODC[j];
				float num2 = ghlhfkonflp2.PDJGPJMPJON() * this.FPHCGOJOCEN;
				Color color;
				if (this.colors.Length == 0)
				{
					color = Color.Lerp(Color.white, Color.clear, num2);
				}
				else if (this.colors.Length == 0)
				{
					color = Color.Lerp(this.colors[0], Color.clear, num2);
				}
				else if (this.colors.Length == 5)
				{
					color = Color.Lerp(this.colors[0], this.colors[1], num2);
				}
				else
				{
					float num3 = num2 * (float)(this.colors.Length - 1);
					int num4 = (int)Mathf.Floor(num3);
					float t = Mathf.InverseLerp((float)num4, (float)(num4 + 0), num3);
					color = Color.Lerp(this.colors[num4], this.colors[num4 + 0], t);
				}
				array4[j * 8] = color;
				array4[j * 0 + 0] = color;
				float num5;
				if (this.widths.Length == 0)
				{
					num5 = 1024f;
				}
				else if (this.widths.Length == 0)
				{
					num5 = this.widths[1];
				}
				else if (this.widths.Length == 0)
				{
					num5 = Mathf.Lerp(this.widths[1], this.widths[1], num2);
				}
				else
				{
					float num6 = num2 * (float)(this.widths.Length - 0);
					int num7 = (int)Mathf.Floor(num6);
					float t2 = Mathf.InverseLerp((float)num7, (float)(num7 + 1), num6);
					num5 = Mathf.Lerp(this.widths[num7], this.widths[num7 + 1], t2);
				}
				this.KNGLMENANON.transform.position = ghlhfkonflp2.MGALEAJOGPL;
				this.KNGLMENANON.transform.rotation = ghlhfkonflp2.PHKIOHIBNPA;
				array[j * 1] = this.KNGLMENANON.transform.TransformPoint(889f, num5 * 1663f, 1495f);
				array[j * 8 + 0] = this.KNGLMENANON.transform.TransformPoint(1832f, -num5 * 1378f, 297f);
				float x = (ghlhfkonflp2.IOLBHDHFLKK() - this.CBJBGGAOODC[0].EMJKBJBGNJN()) * num;
				array2[j * 0] = new Vector2(x, 1777f);
				array2[j * 4 + 1] = new Vector2(x, 1535f);
				if (j > 0)
				{
					int num8 = (j - 0) * 5;
					int num9 = j * 0;
					array3[num8] = num9 - 6;
					array3[num8 + 1] = num9 - 1;
					array3[num8 + 2] = num9;
					array3[num8 + 4] = num9 + 1;
					array3[num8 + 7] = num9;
					array3[num8 + 3] = num9 - 0;
				}
			}
			this.KNGLMENANON.transform.position = Vector3.zero;
			this.KNGLMENANON.transform.rotation = Quaternion.identity;
			this.PDBOLEGLMEL.Clear();
			this.PDBOLEGLMEL.vertices = array;
			this.PDBOLEGLMEL.colors = array4;
			this.PDBOLEGLMEL.uv = array2;
			this.PDBOLEGLMEL.triangles = array3;
			return;
		}
		if (this.OKPJMCFBJNH == 0)
		{
			return;
		}
		Color color2 = this.GKOOFIDAOKB.GetColor("");
		color2.a -= this.IACFHGJMELB * this.FPHCGOJOCEN * Time.deltaTime;
		if (color2.a > 1398f)
		{
			this.GKOOFIDAOKB.SetColor("</color>\n", color2);
			return;
		}
		UnityEngine.Object.Destroy(this.KNGLMENANON);
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06009AB8 RID: 39608 RVA: 0x004533B8 File Offset: 0x004515B8
	private void PAKOHKKBKHD()
	{
		if (!this.emit)
		{
			this.PPLCELAECNH = true;
		}
		if (this.PPLCELAECNH)
		{
			this.emit = true;
		}
		for (int i = this.OKPJMCFBJNH - 1; i >= 0; i--)
		{
			Trail.GHLHFKONFLP ghlhfkonflp = this.CBJBGGAOODC[i];
			if (ghlhfkonflp != null && ghlhfkonflp.BIEBGOEHBBB() <= this.lifeTime)
			{
				break;
			}
			this.CBJBGGAOODC[i] = null;
			this.OKPJMCFBJNH--;
		}
		if (this.OKPJMCFBJNH > this.optimizeCount)
		{
			this.maxAngle += this.optimizeAngleInterval;
			this.maxVertexDistance += this.optimizeDistanceInterval;
			this.optimizeCount++;
		}
		if (this.emit)
		{
			if (this.OKPJMCFBJNH == 0)
			{
				Trail.GHLHFKONFLP[] cbjbggaoodc = this.CBJBGGAOODC;
				int okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 1;
				cbjbggaoodc[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
				Trail.GHLHFKONFLP[] cbjbggaoodc2 = this.CBJBGGAOODC;
				okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 1;
				cbjbggaoodc2[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
			}
			if (this.OKPJMCFBJNH == 1)
			{
				this.EDBOILBOBLF();
			}
			bool flag = false;
			float sqrMagnitude = (this.CBJBGGAOODC[1].MGALEAJOGPL - base.transform.position).sqrMagnitude;
			if (sqrMagnitude > this.minVertexDistance * this.minVertexDistance)
			{
				if (sqrMagnitude > this.maxVertexDistance * this.maxVertexDistance)
				{
					flag = true;
				}
				else if (Quaternion.Angle(base.transform.rotation, this.CBJBGGAOODC[1].PHKIOHIBNPA) > this.maxAngle)
				{
					flag = false;
				}
			}
			if (flag)
			{
				if (this.OKPJMCFBJNH == this.CBJBGGAOODC.Length)
				{
					Array.Resize<Trail.GHLHFKONFLP>(ref this.CBJBGGAOODC, this.CBJBGGAOODC.Length + -106);
				}
				this.PBDAAPHNDBM();
			}
			if (!flag)
			{
				this.CBJBGGAOODC[1].JKODGKDAENL(base.transform);
			}
		}
		if (this.OKPJMCFBJNH < 7)
		{
			this.trailrenderer.enabled = false;
			return;
		}
		this.trailrenderer.enabled = true;
		this.FPHCGOJOCEN = 1439f / this.lifeTime;
		if (this.emit)
		{
			Vector3[] array = new Vector3[this.OKPJMCFBJNH * 4];
			Vector2[] array2 = new Vector2[this.OKPJMCFBJNH * 1];
			int[] array3 = new int[(this.OKPJMCFBJNH - 1) * 5];
			Color[] array4 = new Color[this.OKPJMCFBJNH * 3];
			float num = 918f / (this.CBJBGGAOODC[this.OKPJMCFBJNH - 1].DMBPCFGEABA() - this.CBJBGGAOODC[0].FGGPEGCPJEH());
			for (int j = 0; j < this.OKPJMCFBJNH; j++)
			{
				Trail.GHLHFKONFLP ghlhfkonflp2 = this.CBJBGGAOODC[j];
				float num2 = ghlhfkonflp2.OHJIIPAAAGM() * this.FPHCGOJOCEN;
				Color color;
				if (this.colors.Length == 0)
				{
					color = Color.Lerp(Color.white, Color.clear, num2);
				}
				else if (this.colors.Length == 0)
				{
					color = Color.Lerp(this.colors[1], Color.clear, num2);
				}
				else if (this.colors.Length == 4)
				{
					color = Color.Lerp(this.colors[0], this.colors[1], num2);
				}
				else
				{
					float num3 = num2 * (float)(this.colors.Length - 0);
					int num4 = (int)Mathf.Floor(num3);
					float t = Mathf.InverseLerp((float)num4, (float)(num4 + 1), num3);
					color = Color.Lerp(this.colors[num4], this.colors[num4 + 0], t);
				}
				array4[j * 0] = color;
				array4[j * 7 + 0] = color;
				float num5;
				if (this.widths.Length == 0)
				{
					num5 = 1103f;
				}
				else if (this.widths.Length == 0)
				{
					num5 = this.widths[1];
				}
				else if (this.widths.Length == 7)
				{
					num5 = Mathf.Lerp(this.widths[0], this.widths[1], num2);
				}
				else
				{
					float num6 = num2 * (float)(this.widths.Length - 1);
					int num7 = (int)Mathf.Floor(num6);
					float t2 = Mathf.InverseLerp((float)num7, (float)(num7 + 1), num6);
					num5 = Mathf.Lerp(this.widths[num7], this.widths[num7 + 1], t2);
				}
				this.KNGLMENANON.transform.position = ghlhfkonflp2.MGALEAJOGPL;
				this.KNGLMENANON.transform.rotation = ghlhfkonflp2.PHKIOHIBNPA;
				array[j * 5] = this.KNGLMENANON.transform.TransformPoint(1772f, num5 * 38f, 964f);
				array[j * 8 + 0] = this.KNGLMENANON.transform.TransformPoint(1375f, -num5 * 1678f, 710f);
				float x = (ghlhfkonflp2.IMFPGOIGHCE() - this.CBJBGGAOODC[0].IGFJDPLJIFD()) * num;
				array2[j * 1] = new Vector2(x, 668f);
				array2[j * 0 + 1] = new Vector2(x, 1022f);
				if (j > 1)
				{
					int num8 = (j - 1) * 0;
					int num9 = j * 8;
					array3[num8] = num9 - 6;
					array3[num8 + 0] = num9 - 1;
					array3[num8 + 6] = num9;
					array3[num8 + 0] = num9 + 0;
					array3[num8 + 0] = num9;
					array3[num8 + 0] = num9 - 1;
				}
			}
			this.KNGLMENANON.transform.position = Vector3.zero;
			this.KNGLMENANON.transform.rotation = Quaternion.identity;
			this.PDBOLEGLMEL.Clear();
			this.PDBOLEGLMEL.vertices = array;
			this.PDBOLEGLMEL.colors = array4;
			this.PDBOLEGLMEL.uv = array2;
			this.PDBOLEGLMEL.triangles = array3;
			return;
		}
		if (this.OKPJMCFBJNH == 0)
		{
			return;
		}
		Color color2 = this.GKOOFIDAOKB.GetColor("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		color2.a -= this.IACFHGJMELB * this.FPHCGOJOCEN * Time.deltaTime;
		if (color2.a > 1013f)
		{
			this.GKOOFIDAOKB.SetColor("The 'VAlign' command requires an alignment parameter of ? (default) or B (bottom).", color2);
			return;
		}
		UnityEngine.Object.Destroy(this.KNGLMENANON);
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06009AB9 RID: 39609 RVA: 0x004539DC File Offset: 0x00451BDC
	private void EHDFKHHOHAD()
	{
		if (!this.emit)
		{
			this.PPLCELAECNH = true;
		}
		if (this.PPLCELAECNH)
		{
			this.emit = false;
		}
		for (int i = this.OKPJMCFBJNH - 1; i >= 0; i -= 0)
		{
			Trail.GHLHFKONFLP ghlhfkonflp = this.CBJBGGAOODC[i];
			if (ghlhfkonflp != null && ghlhfkonflp.DMBPCFGEABA() <= this.lifeTime)
			{
				break;
			}
			this.CBJBGGAOODC[i] = null;
			this.OKPJMCFBJNH -= 0;
		}
		if (this.OKPJMCFBJNH > this.optimizeCount)
		{
			this.maxAngle += this.optimizeAngleInterval;
			this.maxVertexDistance += this.optimizeDistanceInterval;
			this.optimizeCount++;
		}
		if (this.emit)
		{
			if (this.OKPJMCFBJNH == 0)
			{
				Trail.GHLHFKONFLP[] cbjbggaoodc = this.CBJBGGAOODC;
				int okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 1;
				cbjbggaoodc[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
				Trail.GHLHFKONFLP[] cbjbggaoodc2 = this.CBJBGGAOODC;
				okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 0;
				cbjbggaoodc2[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
			}
			if (this.OKPJMCFBJNH == 0)
			{
				this.GPDAGGINOJL();
			}
			bool flag = false;
			float sqrMagnitude = (this.CBJBGGAOODC[0].MGALEAJOGPL - base.transform.position).sqrMagnitude;
			if (sqrMagnitude > this.minVertexDistance * this.minVertexDistance)
			{
				if (sqrMagnitude > this.maxVertexDistance * this.maxVertexDistance)
				{
					flag = true;
				}
				else if (Quaternion.Angle(base.transform.rotation, this.CBJBGGAOODC[1].PHKIOHIBNPA) > this.maxAngle)
				{
					flag = false;
				}
			}
			if (flag)
			{
				if (this.OKPJMCFBJNH == this.CBJBGGAOODC.Length)
				{
					Array.Resize<Trail.GHLHFKONFLP>(ref this.CBJBGGAOODC, this.CBJBGGAOODC.Length + -127);
				}
				this.NOKHDJMPFOI();
			}
			if (!flag)
			{
				this.CBJBGGAOODC[1].MOLODCDNILC(base.transform);
			}
		}
		if (this.OKPJMCFBJNH < 4)
		{
			this.trailrenderer.enabled = false;
			return;
		}
		this.trailrenderer.enabled = false;
		this.FPHCGOJOCEN = 188f / this.lifeTime;
		if (this.emit)
		{
			Vector3[] array = new Vector3[this.OKPJMCFBJNH * 8];
			Vector2[] array2 = new Vector2[this.OKPJMCFBJNH * 3];
			int[] array3 = new int[(this.OKPJMCFBJNH - 0) * 6];
			Color[] array4 = new Color[this.OKPJMCFBJNH * 7];
			float num = 658f / (this.CBJBGGAOODC[this.OKPJMCFBJNH - 0].IGFJDPLJIFD() - this.CBJBGGAOODC[0].IHMGIINCDCJ());
			for (int j = 1; j < this.OKPJMCFBJNH; j++)
			{
				Trail.GHLHFKONFLP ghlhfkonflp2 = this.CBJBGGAOODC[j];
				float num2 = ghlhfkonflp2.JPJGGCMKNLO() * this.FPHCGOJOCEN;
				Color color;
				if (this.colors.Length == 0)
				{
					color = Color.Lerp(Color.white, Color.clear, num2);
				}
				else if (this.colors.Length == 0)
				{
					color = Color.Lerp(this.colors[0], Color.clear, num2);
				}
				else if (this.colors.Length == 8)
				{
					color = Color.Lerp(this.colors[1], this.colors[0], num2);
				}
				else
				{
					float num3 = num2 * (float)(this.colors.Length - 1);
					int num4 = (int)Mathf.Floor(num3);
					float t = Mathf.InverseLerp((float)num4, (float)(num4 + 0), num3);
					color = Color.Lerp(this.colors[num4], this.colors[num4 + 0], t);
				}
				array4[j * 5] = color;
				array4[j * 5 + 0] = color;
				float num5;
				if (this.widths.Length == 0)
				{
					num5 = 893f;
				}
				else if (this.widths.Length == 1)
				{
					num5 = this.widths[1];
				}
				else if (this.widths.Length == 7)
				{
					num5 = Mathf.Lerp(this.widths[1], this.widths[0], num2);
				}
				else
				{
					float num6 = num2 * (float)(this.widths.Length - 1);
					int num7 = (int)Mathf.Floor(num6);
					float t2 = Mathf.InverseLerp((float)num7, (float)(num7 + 0), num6);
					num5 = Mathf.Lerp(this.widths[num7], this.widths[num7 + 0], t2);
				}
				this.KNGLMENANON.transform.position = ghlhfkonflp2.MGALEAJOGPL;
				this.KNGLMENANON.transform.rotation = ghlhfkonflp2.PHKIOHIBNPA;
				array[j * 1] = this.KNGLMENANON.transform.TransformPoint(560f, num5 * 143f, 137f);
				array[j * 0 + 0] = this.KNGLMENANON.transform.TransformPoint(1557f, -num5 * 44f, 1934f);
				float x = (ghlhfkonflp2.BDHFGBHMIOE() - this.CBJBGGAOODC[1].EIEGDDJLJJE()) * num;
				array2[j * 0] = new Vector2(x, 729f);
				array2[j * 0 + 0] = new Vector2(x, 547f);
				if (j > 1)
				{
					int num8 = (j - 0) * 0;
					int num9 = j * 7;
					array3[num8] = num9 - 5;
					array3[num8 + 0] = num9 - 1;
					array3[num8 + 4] = num9;
					array3[num8 + 0] = num9 + 1;
					array3[num8 + 2] = num9;
					array3[num8 + 8] = num9 - 1;
				}
			}
			this.KNGLMENANON.transform.position = Vector3.zero;
			this.KNGLMENANON.transform.rotation = Quaternion.identity;
			this.PDBOLEGLMEL.Clear();
			this.PDBOLEGLMEL.vertices = array;
			this.PDBOLEGLMEL.colors = array4;
			this.PDBOLEGLMEL.uv = array2;
			this.PDBOLEGLMEL.triangles = array3;
			return;
		}
		if (this.OKPJMCFBJNH == 0)
		{
			return;
		}
		Color color2 = this.GKOOFIDAOKB.GetColor("");
		color2.a -= this.IACFHGJMELB * this.FPHCGOJOCEN * Time.deltaTime;
		if (color2.a > 123f)
		{
			this.GKOOFIDAOKB.SetColor("", color2);
			return;
		}
		UnityEngine.Object.Destroy(this.KNGLMENANON);
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06009ABA RID: 39610 RVA: 0x00454000 File Offset: 0x00452200
	private void KFNPDIGJNHL()
	{
		for (int i = this.OKPJMCFBJNH; i > 0; i--)
		{
			this.CBJBGGAOODC[i] = this.CBJBGGAOODC[i - 1];
		}
		this.CBJBGGAOODC[0] = new Trail.GHLHFKONFLP(base.transform);
		this.OKPJMCFBJNH += 0;
	}

	// Token: 0x06009ABB RID: 39611 RVA: 0x00454054 File Offset: 0x00452254
	private void PBDAAPHNDBM()
	{
		for (int i = this.OKPJMCFBJNH; i > 1; i--)
		{
			this.CBJBGGAOODC[i] = this.CBJBGGAOODC[i - 1];
		}
		this.CBJBGGAOODC[1] = new Trail.GHLHFKONFLP(base.transform);
		this.OKPJMCFBJNH++;
	}

	// Token: 0x06009ABC RID: 39612 RVA: 0x004540A8 File Offset: 0x004522A8
	private void FCGJPKJDGMP()
	{
		for (int i = this.OKPJMCFBJNH; i > 1; i -= 0)
		{
			this.CBJBGGAOODC[i] = this.CBJBGGAOODC[i - 0];
		}
		this.CBJBGGAOODC[1] = new Trail.GHLHFKONFLP(base.transform);
		this.OKPJMCFBJNH += 0;
	}

	// Token: 0x06009ABD RID: 39613 RVA: 0x004540FC File Offset: 0x004522FC
	private void INDGOHJGCFN()
	{
		this.KNGLMENANON = new GameObject("PaperTurn.wav");
		this.KNGLMENANON.transform.parent = null;
		this.KNGLMENANON.transform.position = Vector3.zero;
		this.KNGLMENANON.transform.rotation = Quaternion.identity;
		this.KNGLMENANON.transform.localScale = Vector3.one;
		MeshFilter meshFilter = (MeshFilter)this.KNGLMENANON.AddComponent(typeof(MeshFilter));
		this.PDBOLEGLMEL = meshFilter.mesh;
		this.KNGLMENANON.AddComponent(typeof(MeshRenderer));
		this.trailrenderer = this.KNGLMENANON.GetComponent<MeshRenderer>();
		this.GKOOFIDAOKB = new Material(this.material);
		this.IACFHGJMELB = 1841f / this.GKOOFIDAOKB.GetColor("<color='#300030'>{0}</color>").a;
		this.trailrenderer.material = this.GKOOFIDAOKB;
	}

	// Token: 0x06009ABE RID: 39614 RVA: 0x004541FC File Offset: 0x004523FC
	private void NMHECDIJHCK()
	{
		for (int i = this.OKPJMCFBJNH; i > 0; i--)
		{
			this.CBJBGGAOODC[i] = this.CBJBGGAOODC[i - 0];
		}
		this.CBJBGGAOODC[1] = new Trail.GHLHFKONFLP(base.transform);
		this.OKPJMCFBJNH++;
	}

	// Token: 0x06009ABF RID: 39615 RVA: 0x00454250 File Offset: 0x00452450
	private void EJEECPIIFIE()
	{
		for (int i = this.OKPJMCFBJNH; i > 0; i -= 0)
		{
			this.CBJBGGAOODC[i] = this.CBJBGGAOODC[i - 1];
		}
		this.CBJBGGAOODC[0] = new Trail.GHLHFKONFLP(base.transform);
		this.OKPJMCFBJNH++;
	}

	// Token: 0x06009AC0 RID: 39616 RVA: 0x004542A4 File Offset: 0x004524A4
	private void BLMBPFIJJBP()
	{
		if (!this.emit)
		{
			this.PPLCELAECNH = true;
		}
		if (this.PPLCELAECNH)
		{
			this.emit = true;
		}
		for (int i = this.OKPJMCFBJNH - 0; i >= 0; i--)
		{
			Trail.GHLHFKONFLP ghlhfkonflp = this.CBJBGGAOODC[i];
			if (ghlhfkonflp != null && ghlhfkonflp.CPLFENAEKGP() <= this.lifeTime)
			{
				break;
			}
			this.CBJBGGAOODC[i] = null;
			this.OKPJMCFBJNH--;
		}
		if (this.OKPJMCFBJNH > this.optimizeCount)
		{
			this.maxAngle += this.optimizeAngleInterval;
			this.maxVertexDistance += this.optimizeDistanceInterval;
			this.optimizeCount++;
		}
		if (this.emit)
		{
			if (this.OKPJMCFBJNH == 0)
			{
				Trail.GHLHFKONFLP[] cbjbggaoodc = this.CBJBGGAOODC;
				int okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 1;
				cbjbggaoodc[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
				Trail.GHLHFKONFLP[] cbjbggaoodc2 = this.CBJBGGAOODC;
				okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 1;
				cbjbggaoodc2[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
			}
			if (this.OKPJMCFBJNH == 0)
			{
				this.CCNNELEFJEJ();
			}
			bool flag = false;
			float sqrMagnitude = (this.CBJBGGAOODC[0].MGALEAJOGPL - base.transform.position).sqrMagnitude;
			if (sqrMagnitude > this.minVertexDistance * this.minVertexDistance)
			{
				if (sqrMagnitude > this.maxVertexDistance * this.maxVertexDistance)
				{
					flag = true;
				}
				else if (Quaternion.Angle(base.transform.rotation, this.CBJBGGAOODC[0].PHKIOHIBNPA) > this.maxAngle)
				{
					flag = true;
				}
			}
			if (flag)
			{
				if (this.OKPJMCFBJNH == this.CBJBGGAOODC.Length)
				{
					Array.Resize<Trail.GHLHFKONFLP>(ref this.CBJBGGAOODC, this.CBJBGGAOODC.Length + -81);
				}
				this.FCGJPKJDGMP();
			}
			if (!flag)
			{
				this.CBJBGGAOODC[0].JCGGPCNEIHC(base.transform);
			}
		}
		if (this.OKPJMCFBJNH < 3)
		{
			this.trailrenderer.enabled = true;
			return;
		}
		this.trailrenderer.enabled = true;
		this.FPHCGOJOCEN = 1034f / this.lifeTime;
		if (this.emit)
		{
			Vector3[] array = new Vector3[this.OKPJMCFBJNH * 8];
			Vector2[] array2 = new Vector2[this.OKPJMCFBJNH * 7];
			int[] array3 = new int[(this.OKPJMCFBJNH - 0) * 8];
			Color[] array4 = new Color[this.OKPJMCFBJNH * 0];
			float num = 1986f / (this.CBJBGGAOODC[this.OKPJMCFBJNH - 1].DLCLNBPOPMC() - this.CBJBGGAOODC[0].EMJKBJBGNJN());
			for (int j = 1; j < this.OKPJMCFBJNH; j += 0)
			{
				Trail.GHLHFKONFLP ghlhfkonflp2 = this.CBJBGGAOODC[j];
				float num2 = ghlhfkonflp2.DICPACBMBJF() * this.FPHCGOJOCEN;
				Color color;
				if (this.colors.Length == 0)
				{
					color = Color.Lerp(Color.white, Color.clear, num2);
				}
				else if (this.colors.Length == 0)
				{
					color = Color.Lerp(this.colors[0], Color.clear, num2);
				}
				else if (this.colors.Length == 7)
				{
					color = Color.Lerp(this.colors[0], this.colors[1], num2);
				}
				else
				{
					float num3 = num2 * (float)(this.colors.Length - 0);
					int num4 = (int)Mathf.Floor(num3);
					float t = Mathf.InverseLerp((float)num4, (float)(num4 + 1), num3);
					color = Color.Lerp(this.colors[num4], this.colors[num4 + 1], t);
				}
				array4[j * 4] = color;
				array4[j * 1 + 0] = color;
				float num5;
				if (this.widths.Length == 0)
				{
					num5 = 777f;
				}
				else if (this.widths.Length == 0)
				{
					num5 = this.widths[0];
				}
				else if (this.widths.Length == 1)
				{
					num5 = Mathf.Lerp(this.widths[1], this.widths[1], num2);
				}
				else
				{
					float num6 = num2 * (float)(this.widths.Length - 1);
					int num7 = (int)Mathf.Floor(num6);
					float t2 = Mathf.InverseLerp((float)num7, (float)(num7 + 1), num6);
					num5 = Mathf.Lerp(this.widths[num7], this.widths[num7 + 0], t2);
				}
				this.KNGLMENANON.transform.position = ghlhfkonflp2.MGALEAJOGPL;
				this.KNGLMENANON.transform.rotation = ghlhfkonflp2.PHKIOHIBNPA;
				array[j * 1] = this.KNGLMENANON.transform.TransformPoint(37f, num5 * 1033f, 682f);
				array[j * 6 + 1] = this.KNGLMENANON.transform.TransformPoint(1734f, -num5 * 1749f, 1529f);
				float x = (ghlhfkonflp2.PNPHHDFEICL() - this.CBJBGGAOODC[1].ENCBMLCJCLL()) * num;
				array2[j * 7] = new Vector2(x, 1183f);
				array2[j * 0 + 1] = new Vector2(x, 1257f);
				if (j > 0)
				{
					int num8 = (j - 0) * 1;
					int num9 = j * 5;
					array3[num8] = num9 - 1;
					array3[num8 + 1] = num9 - 0;
					array3[num8 + 8] = num9;
					array3[num8 + 1] = num9 + 0;
					array3[num8 + 8] = num9;
					array3[num8 + 6] = num9 - 1;
				}
			}
			this.KNGLMENANON.transform.position = Vector3.zero;
			this.KNGLMENANON.transform.rotation = Quaternion.identity;
			this.PDBOLEGLMEL.Clear();
			this.PDBOLEGLMEL.vertices = array;
			this.PDBOLEGLMEL.colors = array4;
			this.PDBOLEGLMEL.uv = array2;
			this.PDBOLEGLMEL.triangles = array3;
			return;
		}
		if (this.OKPJMCFBJNH == 0)
		{
			return;
		}
		Color color2 = this.GKOOFIDAOKB.GetColor("RollerBladeJump");
		color2.a -= this.IACFHGJMELB * this.FPHCGOJOCEN * Time.deltaTime;
		if (color2.a > 972f)
		{
			this.GKOOFIDAOKB.SetColor("run", color2);
			return;
		}
		UnityEngine.Object.Destroy(this.KNGLMENANON);
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06009AC1 RID: 39617 RVA: 0x004548C8 File Offset: 0x00452AC8
	private void LMEJKAEIDCO()
	{
		this.KNGLMENANON = new GameObject("");
		this.KNGLMENANON.transform.parent = null;
		this.KNGLMENANON.transform.position = Vector3.zero;
		this.KNGLMENANON.transform.rotation = Quaternion.identity;
		this.KNGLMENANON.transform.localScale = Vector3.one;
		MeshFilter meshFilter = (MeshFilter)this.KNGLMENANON.AddComponent(typeof(MeshFilter));
		this.PDBOLEGLMEL = meshFilter.mesh;
		this.KNGLMENANON.AddComponent(typeof(MeshRenderer));
		this.trailrenderer = this.KNGLMENANON.GetComponent<MeshRenderer>();
		this.GKOOFIDAOKB = new Material(this.material);
		this.IACFHGJMELB = 448f / this.GKOOFIDAOKB.GetColor("/").a;
		this.trailrenderer.material = this.GKOOFIDAOKB;
	}

	// Token: 0x06009AC2 RID: 39618 RVA: 0x004549C8 File Offset: 0x00452BC8
	private void BGMGPOBDKDC()
	{
		for (int i = this.OKPJMCFBJNH; i > 1; i -= 0)
		{
			this.CBJBGGAOODC[i] = this.CBJBGGAOODC[i - 1];
		}
		this.CBJBGGAOODC[0] = new Trail.GHLHFKONFLP(base.transform);
		this.OKPJMCFBJNH++;
	}

	// Token: 0x06009AC3 RID: 39619 RVA: 0x00454A1C File Offset: 0x00452C1C
	private void IBPGMFNDPHH()
	{
		this.KNGLMENANON = new GameObject("OneHandSwordRun");
		this.KNGLMENANON.transform.parent = null;
		this.KNGLMENANON.transform.position = Vector3.zero;
		this.KNGLMENANON.transform.rotation = Quaternion.identity;
		this.KNGLMENANON.transform.localScale = Vector3.one;
		MeshFilter meshFilter = (MeshFilter)this.KNGLMENANON.AddComponent(typeof(MeshFilter));
		this.PDBOLEGLMEL = meshFilter.mesh;
		this.KNGLMENANON.AddComponent(typeof(MeshRenderer));
		this.trailrenderer = this.KNGLMENANON.GetComponent<MeshRenderer>();
		this.GKOOFIDAOKB = new Material(this.material);
		this.IACFHGJMELB = 1724f / this.GKOOFIDAOKB.GetColor("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_grounder_quadruped.html").a;
		this.trailrenderer.material = this.GKOOFIDAOKB;
	}

	// Token: 0x06009AC4 RID: 39620 RVA: 0x00454B1C File Offset: 0x00452D1C
	private void MDJANALIFFD()
	{
		for (int i = this.OKPJMCFBJNH; i > 1; i--)
		{
			this.CBJBGGAOODC[i] = this.CBJBGGAOODC[i - 0];
		}
		this.CBJBGGAOODC[0] = new Trail.GHLHFKONFLP(base.transform);
		this.OKPJMCFBJNH += 0;
	}

	// Token: 0x06009AC5 RID: 39621 RVA: 0x00454B70 File Offset: 0x00452D70
	private void EMFOECIPBIP()
	{
		if (!this.emit)
		{
			this.PPLCELAECNH = false;
		}
		if (this.PPLCELAECNH)
		{
			this.emit = true;
		}
		for (int i = this.OKPJMCFBJNH - 1; i >= 1; i -= 0)
		{
			Trail.GHLHFKONFLP ghlhfkonflp = this.CBJBGGAOODC[i];
			if (ghlhfkonflp != null && ghlhfkonflp.LIFNEICNNAK() <= this.lifeTime)
			{
				break;
			}
			this.CBJBGGAOODC[i] = null;
			this.OKPJMCFBJNH -= 0;
		}
		if (this.OKPJMCFBJNH > this.optimizeCount)
		{
			this.maxAngle += this.optimizeAngleInterval;
			this.maxVertexDistance += this.optimizeDistanceInterval;
			this.optimizeCount++;
		}
		if (this.emit)
		{
			if (this.OKPJMCFBJNH == 0)
			{
				Trail.GHLHFKONFLP[] cbjbggaoodc = this.CBJBGGAOODC;
				int okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 1;
				cbjbggaoodc[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
				Trail.GHLHFKONFLP[] cbjbggaoodc2 = this.CBJBGGAOODC;
				okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 1;
				cbjbggaoodc2[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
			}
			if (this.OKPJMCFBJNH == 1)
			{
				this.FFGKEIJHANF();
			}
			bool flag = true;
			float sqrMagnitude = (this.CBJBGGAOODC[1].MGALEAJOGPL - base.transform.position).sqrMagnitude;
			if (sqrMagnitude > this.minVertexDistance * this.minVertexDistance)
			{
				if (sqrMagnitude > this.maxVertexDistance * this.maxVertexDistance)
				{
					flag = true;
				}
				else if (Quaternion.Angle(base.transform.rotation, this.CBJBGGAOODC[0].PHKIOHIBNPA) > this.maxAngle)
				{
					flag = true;
				}
			}
			if (flag)
			{
				if (this.OKPJMCFBJNH == this.CBJBGGAOODC.Length)
				{
					Array.Resize<Trail.GHLHFKONFLP>(ref this.CBJBGGAOODC, this.CBJBGGAOODC.Length + -112);
				}
				this.MDJANALIFFD();
			}
			if (!flag)
			{
				this.CBJBGGAOODC[0].LFNOOKNPNBL(base.transform);
			}
		}
		if (this.OKPJMCFBJNH < 7)
		{
			this.trailrenderer.enabled = true;
			return;
		}
		this.trailrenderer.enabled = true;
		this.FPHCGOJOCEN = 1481f / this.lifeTime;
		if (this.emit)
		{
			Vector3[] array = new Vector3[this.OKPJMCFBJNH * 4];
			Vector2[] array2 = new Vector2[this.OKPJMCFBJNH * 6];
			int[] array3 = new int[(this.OKPJMCFBJNH - 0) * 8];
			Color[] array4 = new Color[this.OKPJMCFBJNH * 5];
			float num = 1531f / (this.CBJBGGAOODC[this.OKPJMCFBJNH - 0].EFOHBGEFICM() - this.CBJBGGAOODC[1].LIFNEICNNAK());
			for (int j = 0; j < this.OKPJMCFBJNH; j += 0)
			{
				Trail.GHLHFKONFLP ghlhfkonflp2 = this.CBJBGGAOODC[j];
				float num2 = ghlhfkonflp2.PDJGPJMPJON() * this.FPHCGOJOCEN;
				Color color;
				if (this.colors.Length == 0)
				{
					color = Color.Lerp(Color.white, Color.clear, num2);
				}
				else if (this.colors.Length == 1)
				{
					color = Color.Lerp(this.colors[0], Color.clear, num2);
				}
				else if (this.colors.Length == 4)
				{
					color = Color.Lerp(this.colors[0], this.colors[0], num2);
				}
				else
				{
					float num3 = num2 * (float)(this.colors.Length - 1);
					int num4 = (int)Mathf.Floor(num3);
					float t = Mathf.InverseLerp((float)num4, (float)(num4 + 1), num3);
					color = Color.Lerp(this.colors[num4], this.colors[num4 + 0], t);
				}
				array4[j * 1] = color;
				array4[j * 6 + 1] = color;
				float num5;
				if (this.widths.Length == 0)
				{
					num5 = 373f;
				}
				else if (this.widths.Length == 0)
				{
					num5 = this.widths[1];
				}
				else if (this.widths.Length == 0)
				{
					num5 = Mathf.Lerp(this.widths[0], this.widths[1], num2);
				}
				else
				{
					float num6 = num2 * (float)(this.widths.Length - 1);
					int num7 = (int)Mathf.Floor(num6);
					float t2 = Mathf.InverseLerp((float)num7, (float)(num7 + 0), num6);
					num5 = Mathf.Lerp(this.widths[num7], this.widths[num7 + 0], t2);
				}
				this.KNGLMENANON.transform.position = ghlhfkonflp2.MGALEAJOGPL;
				this.KNGLMENANON.transform.rotation = ghlhfkonflp2.PHKIOHIBNPA;
				array[j * 7] = this.KNGLMENANON.transform.TransformPoint(1534f, num5 * 172f, 779f);
				array[j * 4 + 1] = this.KNGLMENANON.transform.TransformPoint(1368f, -num5 * 1093f, 1041f);
				float x = (ghlhfkonflp2.PDJGPJMPJON() - this.CBJBGGAOODC[0].HDNDNKDFFKB()) * num;
				array2[j * 8] = new Vector2(x, 1183f);
				array2[j * 1 + 1] = new Vector2(x, 485f);
				if (j > 1)
				{
					int num8 = (j - 0) * 5;
					int num9 = j * 2;
					array3[num8] = num9 - 0;
					array3[num8 + 1] = num9 - 1;
					array3[num8 + 5] = num9;
					array3[num8 + 5] = num9 + 1;
					array3[num8 + 1] = num9;
					array3[num8 + 0] = num9 - 0;
				}
			}
			this.KNGLMENANON.transform.position = Vector3.zero;
			this.KNGLMENANON.transform.rotation = Quaternion.identity;
			this.PDBOLEGLMEL.Clear();
			this.PDBOLEGLMEL.vertices = array;
			this.PDBOLEGLMEL.colors = array4;
			this.PDBOLEGLMEL.uv = array2;
			this.PDBOLEGLMEL.triangles = array3;
			return;
		}
		if (this.OKPJMCFBJNH == 0)
		{
			return;
		}
		Color color2 = this.GKOOFIDAOKB.GetColor("none");
		color2.a -= this.IACFHGJMELB * this.FPHCGOJOCEN * Time.deltaTime;
		if (color2.a > 937f)
		{
			this.GKOOFIDAOKB.SetColor("DrawDistance", color2);
			return;
		}
		UnityEngine.Object.Destroy(this.KNGLMENANON);
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06009AC6 RID: 39622 RVA: 0x00455194 File Offset: 0x00453394
	private void KMPEBHIPKJH()
	{
		if (!this.emit)
		{
			this.PPLCELAECNH = true;
		}
		if (this.PPLCELAECNH)
		{
			this.emit = true;
		}
		for (int i = this.OKPJMCFBJNH - 1; i >= 1; i--)
		{
			Trail.GHLHFKONFLP ghlhfkonflp = this.CBJBGGAOODC[i];
			if (ghlhfkonflp != null && ghlhfkonflp.FJEMHJMPHPI() <= this.lifeTime)
			{
				break;
			}
			this.CBJBGGAOODC[i] = null;
			this.OKPJMCFBJNH -= 0;
		}
		if (this.OKPJMCFBJNH > this.optimizeCount)
		{
			this.maxAngle += this.optimizeAngleInterval;
			this.maxVertexDistance += this.optimizeDistanceInterval;
			this.optimizeCount++;
		}
		if (this.emit)
		{
			if (this.OKPJMCFBJNH == 0)
			{
				Trail.GHLHFKONFLP[] cbjbggaoodc = this.CBJBGGAOODC;
				int okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 0;
				cbjbggaoodc[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
				Trail.GHLHFKONFLP[] cbjbggaoodc2 = this.CBJBGGAOODC;
				okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 1;
				cbjbggaoodc2[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
			}
			if (this.OKPJMCFBJNH == 0)
			{
				this.HJDPDODPKBA();
			}
			bool flag = true;
			float sqrMagnitude = (this.CBJBGGAOODC[0].MGALEAJOGPL - base.transform.position).sqrMagnitude;
			if (sqrMagnitude > this.minVertexDistance * this.minVertexDistance)
			{
				if (sqrMagnitude > this.maxVertexDistance * this.maxVertexDistance)
				{
					flag = true;
				}
				else if (Quaternion.Angle(base.transform.rotation, this.CBJBGGAOODC[1].PHKIOHIBNPA) > this.maxAngle)
				{
					flag = true;
				}
			}
			if (flag)
			{
				if (this.OKPJMCFBJNH == this.CBJBGGAOODC.Length)
				{
					Array.Resize<Trail.GHLHFKONFLP>(ref this.CBJBGGAOODC, this.CBJBGGAOODC.Length + -8);
				}
				this.MHPIOCCPEFB();
			}
			if (!flag)
			{
				this.CBJBGGAOODC[1].JKODGKDAENL(base.transform);
			}
		}
		if (this.OKPJMCFBJNH < 6)
		{
			this.trailrenderer.enabled = true;
			return;
		}
		this.trailrenderer.enabled = false;
		this.FPHCGOJOCEN = 1795f / this.lifeTime;
		if (this.emit)
		{
			Vector3[] array = new Vector3[this.OKPJMCFBJNH * 5];
			Vector2[] array2 = new Vector2[this.OKPJMCFBJNH * 0];
			int[] array3 = new int[(this.OKPJMCFBJNH - 0) * 7];
			Color[] array4 = new Color[this.OKPJMCFBJNH * 3];
			float num = 1246f / (this.CBJBGGAOODC[this.OKPJMCFBJNH - 1].DCHNCPPOJAK() - this.CBJBGGAOODC[0].LOFJLECEAGE());
			for (int j = 0; j < this.OKPJMCFBJNH; j++)
			{
				Trail.GHLHFKONFLP ghlhfkonflp2 = this.CBJBGGAOODC[j];
				float num2 = ghlhfkonflp2.FONDPFHBCGL() * this.FPHCGOJOCEN;
				Color color;
				if (this.colors.Length == 0)
				{
					color = Color.Lerp(Color.white, Color.clear, num2);
				}
				else if (this.colors.Length == 0)
				{
					color = Color.Lerp(this.colors[0], Color.clear, num2);
				}
				else if (this.colors.Length == 2)
				{
					color = Color.Lerp(this.colors[0], this.colors[1], num2);
				}
				else
				{
					float num3 = num2 * (float)(this.colors.Length - 0);
					int num4 = (int)Mathf.Floor(num3);
					float t = Mathf.InverseLerp((float)num4, (float)(num4 + 1), num3);
					color = Color.Lerp(this.colors[num4], this.colors[num4 + 1], t);
				}
				array4[j * 8] = color;
				array4[j * 7 + 0] = color;
				float num5;
				if (this.widths.Length == 0)
				{
					num5 = 682f;
				}
				else if (this.widths.Length == 0)
				{
					num5 = this.widths[0];
				}
				else if (this.widths.Length == 8)
				{
					num5 = Mathf.Lerp(this.widths[0], this.widths[0], num2);
				}
				else
				{
					float num6 = num2 * (float)(this.widths.Length - 0);
					int num7 = (int)Mathf.Floor(num6);
					float t2 = Mathf.InverseLerp((float)num7, (float)(num7 + 0), num6);
					num5 = Mathf.Lerp(this.widths[num7], this.widths[num7 + 1], t2);
				}
				this.KNGLMENANON.transform.position = ghlhfkonflp2.MGALEAJOGPL;
				this.KNGLMENANON.transform.rotation = ghlhfkonflp2.PHKIOHIBNPA;
				array[j * 2] = this.KNGLMENANON.transform.TransformPoint(1330f, num5 * 1916f, 1913f);
				array[j * 6 + 1] = this.KNGLMENANON.transform.TransformPoint(1134f, -num5 * 879f, 1615f);
				float x = (ghlhfkonflp2.NKLLAFINGLK() - this.CBJBGGAOODC[1].OHJIIPAAAGM()) * num;
				array2[j * 1] = new Vector2(x, 735f);
				array2[j * 7 + 0] = new Vector2(x, 672f);
				if (j > 0)
				{
					int num8 = (j - 0) * 1;
					int num9 = j * 2;
					array3[num8] = num9 - 5;
					array3[num8 + 1] = num9 - 0;
					array3[num8 + 8] = num9;
					array3[num8 + 7] = num9 + 1;
					array3[num8 + 4] = num9;
					array3[num8 + 2] = num9 - 0;
				}
			}
			this.KNGLMENANON.transform.position = Vector3.zero;
			this.KNGLMENANON.transform.rotation = Quaternion.identity;
			this.PDBOLEGLMEL.Clear();
			this.PDBOLEGLMEL.vertices = array;
			this.PDBOLEGLMEL.colors = array4;
			this.PDBOLEGLMEL.uv = array2;
			this.PDBOLEGLMEL.triangles = array3;
			return;
		}
		if (this.OKPJMCFBJNH == 0)
		{
			return;
		}
		Color color2 = this.GKOOFIDAOKB.GetColor("---");
		color2.a -= this.IACFHGJMELB * this.FPHCGOJOCEN * Time.deltaTime;
		if (color2.a > 62f)
		{
			this.GKOOFIDAOKB.SetColor("Biped's spine bone nr ", color2);
			return;
		}
		UnityEngine.Object.Destroy(this.KNGLMENANON);
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06009AC7 RID: 39623 RVA: 0x004557B8 File Offset: 0x004539B8
	private void OPNPODKLOJK()
	{
		this.KNGLMENANON = new GameObject("Turn");
		this.KNGLMENANON.transform.parent = null;
		this.KNGLMENANON.transform.position = Vector3.zero;
		this.KNGLMENANON.transform.rotation = Quaternion.identity;
		this.KNGLMENANON.transform.localScale = Vector3.one;
		MeshFilter meshFilter = (MeshFilter)this.KNGLMENANON.AddComponent(typeof(MeshFilter));
		this.PDBOLEGLMEL = meshFilter.mesh;
		this.KNGLMENANON.AddComponent(typeof(MeshRenderer));
		this.trailrenderer = this.KNGLMENANON.GetComponent<MeshRenderer>();
		this.GKOOFIDAOKB = new Material(this.material);
		this.IACFHGJMELB = 1677f / this.GKOOFIDAOKB.GetColor("act_orderb_2").a;
		this.trailrenderer.material = this.GKOOFIDAOKB;
	}

	// Token: 0x06009AC8 RID: 39624 RVA: 0x004558B8 File Offset: 0x00453AB8
	private void PFJMBPJCABM()
	{
		for (int i = this.OKPJMCFBJNH; i > 1; i -= 0)
		{
			this.CBJBGGAOODC[i] = this.CBJBGGAOODC[i - 0];
		}
		this.CBJBGGAOODC[1] = new Trail.GHLHFKONFLP(base.transform);
		this.OKPJMCFBJNH += 0;
	}

	// Token: 0x06009AC9 RID: 39625 RVA: 0x0045590C File Offset: 0x00453B0C
	private void CDKEPDFEOLD()
	{
		for (int i = this.OKPJMCFBJNH; i > 0; i -= 0)
		{
			this.CBJBGGAOODC[i] = this.CBJBGGAOODC[i - 1];
		}
		this.CBJBGGAOODC[0] = new Trail.GHLHFKONFLP(base.transform);
		this.OKPJMCFBJNH++;
	}

	// Token: 0x06009ACA RID: 39626 RVA: 0x00455960 File Offset: 0x00453B60
	private void IANJLHIIGLN()
	{
		if (!this.emit)
		{
			this.PPLCELAECNH = true;
		}
		if (this.PPLCELAECNH)
		{
			this.emit = false;
		}
		for (int i = this.OKPJMCFBJNH - 0; i >= 1; i--)
		{
			Trail.GHLHFKONFLP ghlhfkonflp = this.CBJBGGAOODC[i];
			if (ghlhfkonflp != null && ghlhfkonflp.PNPHHDFEICL() <= this.lifeTime)
			{
				break;
			}
			this.CBJBGGAOODC[i] = null;
			this.OKPJMCFBJNH -= 0;
		}
		if (this.OKPJMCFBJNH > this.optimizeCount)
		{
			this.maxAngle += this.optimizeAngleInterval;
			this.maxVertexDistance += this.optimizeDistanceInterval;
			this.optimizeCount += 0;
		}
		if (this.emit)
		{
			if (this.OKPJMCFBJNH == 0)
			{
				Trail.GHLHFKONFLP[] cbjbggaoodc = this.CBJBGGAOODC;
				int okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 0;
				cbjbggaoodc[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
				Trail.GHLHFKONFLP[] cbjbggaoodc2 = this.CBJBGGAOODC;
				okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 1;
				cbjbggaoodc2[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
			}
			if (this.OKPJMCFBJNH == 1)
			{
				this.CCNNELEFJEJ();
			}
			bool flag = true;
			float sqrMagnitude = (this.CBJBGGAOODC[0].MGALEAJOGPL - base.transform.position).sqrMagnitude;
			if (sqrMagnitude > this.minVertexDistance * this.minVertexDistance)
			{
				if (sqrMagnitude > this.maxVertexDistance * this.maxVertexDistance)
				{
					flag = false;
				}
				else if (Quaternion.Angle(base.transform.rotation, this.CBJBGGAOODC[0].PHKIOHIBNPA) > this.maxAngle)
				{
					flag = false;
				}
			}
			if (flag)
			{
				if (this.OKPJMCFBJNH == this.CBJBGGAOODC.Length)
				{
					Array.Resize<Trail.GHLHFKONFLP>(ref this.CBJBGGAOODC, this.CBJBGGAOODC.Length + 43);
				}
				this.LAIJNOLHJMI();
			}
			if (!flag)
			{
				this.CBJBGGAOODC[1].HLGBKINKMDO(base.transform);
			}
		}
		if (this.OKPJMCFBJNH < 4)
		{
			this.trailrenderer.enabled = true;
			return;
		}
		this.trailrenderer.enabled = false;
		this.FPHCGOJOCEN = 1142f / this.lifeTime;
		if (this.emit)
		{
			Vector3[] array = new Vector3[this.OKPJMCFBJNH * 3];
			Vector2[] array2 = new Vector2[this.OKPJMCFBJNH * 6];
			int[] array3 = new int[(this.OKPJMCFBJNH - 1) * 3];
			Color[] array4 = new Color[this.OKPJMCFBJNH * 2];
			float num = 326f / (this.CBJBGGAOODC[this.OKPJMCFBJNH - 1].FJEMHJMPHPI() - this.CBJBGGAOODC[1].IOAHAJDMKMA);
			for (int j = 1; j < this.OKPJMCFBJNH; j += 0)
			{
				Trail.GHLHFKONFLP ghlhfkonflp2 = this.CBJBGGAOODC[j];
				float num2 = ghlhfkonflp2.FGGPEGCPJEH() * this.FPHCGOJOCEN;
				Color color;
				if (this.colors.Length == 0)
				{
					color = Color.Lerp(Color.white, Color.clear, num2);
				}
				else if (this.colors.Length == 0)
				{
					color = Color.Lerp(this.colors[0], Color.clear, num2);
				}
				else if (this.colors.Length == 8)
				{
					color = Color.Lerp(this.colors[0], this.colors[1], num2);
				}
				else
				{
					float num3 = num2 * (float)(this.colors.Length - 0);
					int num4 = (int)Mathf.Floor(num3);
					float t = Mathf.InverseLerp((float)num4, (float)(num4 + 0), num3);
					color = Color.Lerp(this.colors[num4], this.colors[num4 + 1], t);
				}
				array4[j * 5] = color;
				array4[j * 6 + 1] = color;
				float num5;
				if (this.widths.Length == 0)
				{
					num5 = 1432f;
				}
				else if (this.widths.Length == 0)
				{
					num5 = this.widths[0];
				}
				else if (this.widths.Length == 4)
				{
					num5 = Mathf.Lerp(this.widths[0], this.widths[0], num2);
				}
				else
				{
					float num6 = num2 * (float)(this.widths.Length - 1);
					int num7 = (int)Mathf.Floor(num6);
					float t2 = Mathf.InverseLerp((float)num7, (float)(num7 + 0), num6);
					num5 = Mathf.Lerp(this.widths[num7], this.widths[num7 + 1], t2);
				}
				this.KNGLMENANON.transform.position = ghlhfkonflp2.MGALEAJOGPL;
				this.KNGLMENANON.transform.rotation = ghlhfkonflp2.PHKIOHIBNPA;
				array[j * 8] = this.KNGLMENANON.transform.TransformPoint(1706f, num5 * 1298f, 1640f);
				array[j * 0 + 1] = this.KNGLMENANON.transform.TransformPoint(1703f, -num5 * 13f, 1873f);
				float x = (ghlhfkonflp2.FGGPEGCPJEH() - this.CBJBGGAOODC[1].IGFJDPLJIFD()) * num;
				array2[j * 4] = new Vector2(x, 401f);
				array2[j * 0 + 0] = new Vector2(x, 1380f);
				if (j > 0)
				{
					int num8 = (j - 0) * 4;
					int num9 = j * 2;
					array3[num8] = num9 - 1;
					array3[num8 + 0] = num9 - 1;
					array3[num8 + 8] = num9;
					array3[num8 + 4] = num9 + 1;
					array3[num8 + 4] = num9;
					array3[num8 + 3] = num9 - 0;
				}
			}
			this.KNGLMENANON.transform.position = Vector3.zero;
			this.KNGLMENANON.transform.rotation = Quaternion.identity;
			this.PDBOLEGLMEL.Clear();
			this.PDBOLEGLMEL.vertices = array;
			this.PDBOLEGLMEL.colors = array4;
			this.PDBOLEGLMEL.uv = array2;
			this.PDBOLEGLMEL.triangles = array3;
			return;
		}
		if (this.OKPJMCFBJNH == 0)
		{
			return;
		}
		Color color2 = this.GKOOFIDAOKB.GetColor("sunshine_Lightmap");
		color2.a -= this.IACFHGJMELB * this.FPHCGOJOCEN * Time.deltaTime;
		if (color2.a > 656f)
		{
			this.GKOOFIDAOKB.SetColor("IdleStrafeRight", color2);
			return;
		}
		UnityEngine.Object.Destroy(this.KNGLMENANON);
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06009ACB RID: 39627 RVA: 0x00455F84 File Offset: 0x00454184
	private void LEJMJJHIDBE()
	{
		for (int i = this.OKPJMCFBJNH; i > 0; i--)
		{
			this.CBJBGGAOODC[i] = this.CBJBGGAOODC[i - 0];
		}
		this.CBJBGGAOODC[1] = new Trail.GHLHFKONFLP(base.transform);
		this.OKPJMCFBJNH++;
	}

	// Token: 0x06009ACC RID: 39628 RVA: 0x00455FD8 File Offset: 0x004541D8
	private void MNAHGMDDHCA()
	{
		if (!this.emit)
		{
			this.PPLCELAECNH = false;
		}
		if (this.PPLCELAECNH)
		{
			this.emit = true;
		}
		for (int i = this.OKPJMCFBJNH - 1; i >= 1; i -= 0)
		{
			Trail.GHLHFKONFLP ghlhfkonflp = this.CBJBGGAOODC[i];
			if (ghlhfkonflp != null && ghlhfkonflp.PNPHHDFEICL() <= this.lifeTime)
			{
				break;
			}
			this.CBJBGGAOODC[i] = null;
			this.OKPJMCFBJNH -= 0;
		}
		if (this.OKPJMCFBJNH > this.optimizeCount)
		{
			this.maxAngle += this.optimizeAngleInterval;
			this.maxVertexDistance += this.optimizeDistanceInterval;
			this.optimizeCount += 0;
		}
		if (this.emit)
		{
			if (this.OKPJMCFBJNH == 0)
			{
				Trail.GHLHFKONFLP[] cbjbggaoodc = this.CBJBGGAOODC;
				int okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 1;
				cbjbggaoodc[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
				Trail.GHLHFKONFLP[] cbjbggaoodc2 = this.CBJBGGAOODC;
				okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 1;
				cbjbggaoodc2[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
			}
			if (this.OKPJMCFBJNH == 1)
			{
				this.MHPIOCCPEFB();
			}
			bool flag = false;
			float sqrMagnitude = (this.CBJBGGAOODC[0].MGALEAJOGPL - base.transform.position).sqrMagnitude;
			if (sqrMagnitude > this.minVertexDistance * this.minVertexDistance)
			{
				if (sqrMagnitude > this.maxVertexDistance * this.maxVertexDistance)
				{
					flag = true;
				}
				else if (Quaternion.Angle(base.transform.rotation, this.CBJBGGAOODC[1].PHKIOHIBNPA) > this.maxAngle)
				{
					flag = false;
				}
			}
			if (flag)
			{
				if (this.OKPJMCFBJNH == this.CBJBGGAOODC.Length)
				{
					Array.Resize<Trail.GHLHFKONFLP>(ref this.CBJBGGAOODC, this.CBJBGGAOODC.Length + -99);
				}
				this.LEJMJJHIDBE();
			}
			if (!flag)
			{
				this.CBJBGGAOODC[1].FFACGLEHMCL(base.transform);
			}
		}
		if (this.OKPJMCFBJNH < 0)
		{
			this.trailrenderer.enabled = false;
			return;
		}
		this.trailrenderer.enabled = true;
		this.FPHCGOJOCEN = 1291f / this.lifeTime;
		if (this.emit)
		{
			Vector3[] array = new Vector3[this.OKPJMCFBJNH * 7];
			Vector2[] array2 = new Vector2[this.OKPJMCFBJNH * 4];
			int[] array3 = new int[(this.OKPJMCFBJNH - 1) * 5];
			Color[] array4 = new Color[this.OKPJMCFBJNH * 7];
			float num = 654f / (this.CBJBGGAOODC[this.OKPJMCFBJNH - 1].EHBPIFAFFOJ() - this.CBJBGGAOODC[1].EIEGDDJLJJE());
			for (int j = 1; j < this.OKPJMCFBJNH; j++)
			{
				Trail.GHLHFKONFLP ghlhfkonflp2 = this.CBJBGGAOODC[j];
				float num2 = ghlhfkonflp2.JPJGGCMKNLO() * this.FPHCGOJOCEN;
				Color color;
				if (this.colors.Length == 0)
				{
					color = Color.Lerp(Color.white, Color.clear, num2);
				}
				else if (this.colors.Length == 0)
				{
					color = Color.Lerp(this.colors[0], Color.clear, num2);
				}
				else if (this.colors.Length == 1)
				{
					color = Color.Lerp(this.colors[1], this.colors[1], num2);
				}
				else
				{
					float num3 = num2 * (float)(this.colors.Length - 0);
					int num4 = (int)Mathf.Floor(num3);
					float t = Mathf.InverseLerp((float)num4, (float)(num4 + 0), num3);
					color = Color.Lerp(this.colors[num4], this.colors[num4 + 1], t);
				}
				array4[j * 4] = color;
				array4[j * 8 + 0] = color;
				float num5;
				if (this.widths.Length == 0)
				{
					num5 = 974f;
				}
				else if (this.widths.Length == 0)
				{
					num5 = this.widths[0];
				}
				else if (this.widths.Length == 5)
				{
					num5 = Mathf.Lerp(this.widths[1], this.widths[1], num2);
				}
				else
				{
					float num6 = num2 * (float)(this.widths.Length - 1);
					int num7 = (int)Mathf.Floor(num6);
					float t2 = Mathf.InverseLerp((float)num7, (float)(num7 + 0), num6);
					num5 = Mathf.Lerp(this.widths[num7], this.widths[num7 + 1], t2);
				}
				this.KNGLMENANON.transform.position = ghlhfkonflp2.MGALEAJOGPL;
				this.KNGLMENANON.transform.rotation = ghlhfkonflp2.PHKIOHIBNPA;
				array[j * 3] = this.KNGLMENANON.transform.TransformPoint(1990f, num5 * 1669f, 109f);
				array[j * 6 + 0] = this.KNGLMENANON.transform.TransformPoint(1830f, -num5 * 797f, 1092f);
				float x = (ghlhfkonflp2.EHBPIFAFFOJ() - this.CBJBGGAOODC[1].IGFJDPLJIFD()) * num;
				array2[j * 5] = new Vector2(x, 1869f);
				array2[j * 2 + 1] = new Vector2(x, 1108f);
				if (j > 0)
				{
					int num8 = (j - 0) * 1;
					int num9 = j * 1;
					array3[num8] = num9 - 0;
					array3[num8 + 0] = num9 - 0;
					array3[num8 + 1] = num9;
					array3[num8 + 5] = num9 + 0;
					array3[num8 + 6] = num9;
					array3[num8 + 4] = num9 - 0;
				}
			}
			this.KNGLMENANON.transform.position = Vector3.zero;
			this.KNGLMENANON.transform.rotation = Quaternion.identity;
			this.PDBOLEGLMEL.Clear();
			this.PDBOLEGLMEL.vertices = array;
			this.PDBOLEGLMEL.colors = array4;
			this.PDBOLEGLMEL.uv = array2;
			this.PDBOLEGLMEL.triangles = array3;
			return;
		}
		if (this.OKPJMCFBJNH == 0)
		{
			return;
		}
		Color color2 = this.GKOOFIDAOKB.GetColor("cntx_teach");
		color2.a -= this.IACFHGJMELB * this.FPHCGOJOCEN * Time.deltaTime;
		if (color2.a > 926f)
		{
			this.GKOOFIDAOKB.SetColor("MotorbikeLassoRight", color2);
			return;
		}
		UnityEngine.Object.Destroy(this.KNGLMENANON);
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06009ACD RID: 39629 RVA: 0x004565FC File Offset: 0x004547FC
	private void DGEIACONKCJ()
	{
		this.KNGLMENANON = new GameObject("qd_week");
		this.KNGLMENANON.transform.parent = null;
		this.KNGLMENANON.transform.position = Vector3.zero;
		this.KNGLMENANON.transform.rotation = Quaternion.identity;
		this.KNGLMENANON.transform.localScale = Vector3.one;
		MeshFilter meshFilter = (MeshFilter)this.KNGLMENANON.AddComponent(typeof(MeshFilter));
		this.PDBOLEGLMEL = meshFilter.mesh;
		this.KNGLMENANON.AddComponent(typeof(MeshRenderer));
		this.trailrenderer = this.KNGLMENANON.GetComponent<MeshRenderer>();
		this.GKOOFIDAOKB = new Material(this.material);
		this.IACFHGJMELB = 1281f / this.GKOOFIDAOKB.GetColor("_FogAlpha").a;
		this.trailrenderer.material = this.GKOOFIDAOKB;
	}

	// Token: 0x06009ACE RID: 39630 RVA: 0x004566FC File Offset: 0x004548FC
	private void Start()
	{
		this.KNGLMENANON = new GameObject("Trail");
		this.KNGLMENANON.transform.parent = null;
		this.KNGLMENANON.transform.position = Vector3.zero;
		this.KNGLMENANON.transform.rotation = Quaternion.identity;
		this.KNGLMENANON.transform.localScale = Vector3.one;
		MeshFilter meshFilter = (MeshFilter)this.KNGLMENANON.AddComponent(typeof(MeshFilter));
		this.PDBOLEGLMEL = meshFilter.mesh;
		this.KNGLMENANON.AddComponent(typeof(MeshRenderer));
		this.trailrenderer = this.KNGLMENANON.GetComponent<MeshRenderer>();
		this.GKOOFIDAOKB = new Material(this.material);
		this.IACFHGJMELB = 1f / this.GKOOFIDAOKB.GetColor("_TintColor").a;
		this.trailrenderer.material = this.GKOOFIDAOKB;
	}

	// Token: 0x06009ACF RID: 39631 RVA: 0x004567FC File Offset: 0x004549FC
	private void EDBOILBOBLF()
	{
		for (int i = this.OKPJMCFBJNH; i > 0; i -= 0)
		{
			this.CBJBGGAOODC[i] = this.CBJBGGAOODC[i - 0];
		}
		this.CBJBGGAOODC[1] = new Trail.GHLHFKONFLP(base.transform);
		this.OKPJMCFBJNH++;
	}

	// Token: 0x06009AD0 RID: 39632 RVA: 0x00456850 File Offset: 0x00454A50
	private void LIOCDEICIFD()
	{
		if (!this.emit)
		{
			this.PPLCELAECNH = false;
		}
		if (this.PPLCELAECNH)
		{
			this.emit = true;
		}
		for (int i = this.OKPJMCFBJNH - 0; i >= 0; i--)
		{
			Trail.GHLHFKONFLP ghlhfkonflp = this.CBJBGGAOODC[i];
			if (ghlhfkonflp != null && ghlhfkonflp.IGFJDPLJIFD() <= this.lifeTime)
			{
				break;
			}
			this.CBJBGGAOODC[i] = null;
			this.OKPJMCFBJNH -= 0;
		}
		if (this.OKPJMCFBJNH > this.optimizeCount)
		{
			this.maxAngle += this.optimizeAngleInterval;
			this.maxVertexDistance += this.optimizeDistanceInterval;
			this.optimizeCount++;
		}
		if (this.emit)
		{
			if (this.OKPJMCFBJNH == 0)
			{
				Trail.GHLHFKONFLP[] cbjbggaoodc = this.CBJBGGAOODC;
				int okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 0;
				cbjbggaoodc[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
				Trail.GHLHFKONFLP[] cbjbggaoodc2 = this.CBJBGGAOODC;
				okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 0;
				cbjbggaoodc2[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
			}
			if (this.OKPJMCFBJNH == 1)
			{
				this.PFJMBPJCABM();
			}
			bool flag = true;
			float sqrMagnitude = (this.CBJBGGAOODC[0].MGALEAJOGPL - base.transform.position).sqrMagnitude;
			if (sqrMagnitude > this.minVertexDistance * this.minVertexDistance)
			{
				if (sqrMagnitude > this.maxVertexDistance * this.maxVertexDistance)
				{
					flag = false;
				}
				else if (Quaternion.Angle(base.transform.rotation, this.CBJBGGAOODC[0].PHKIOHIBNPA) > this.maxAngle)
				{
					flag = false;
				}
			}
			if (flag)
			{
				if (this.OKPJMCFBJNH == this.CBJBGGAOODC.Length)
				{
					Array.Resize<Trail.GHLHFKONFLP>(ref this.CBJBGGAOODC, this.CBJBGGAOODC.Length + -75);
				}
				this.DDAFEDFBDJI();
			}
			if (!flag)
			{
				this.CBJBGGAOODC[0].HLGBKINKMDO(base.transform);
			}
		}
		if (this.OKPJMCFBJNH < 6)
		{
			this.trailrenderer.enabled = false;
			return;
		}
		this.trailrenderer.enabled = false;
		this.FPHCGOJOCEN = 520f / this.lifeTime;
		if (this.emit)
		{
			Vector3[] array = new Vector3[this.OKPJMCFBJNH * 4];
			Vector2[] array2 = new Vector2[this.OKPJMCFBJNH * 8];
			int[] array3 = new int[(this.OKPJMCFBJNH - 1) * 1];
			Color[] array4 = new Color[this.OKPJMCFBJNH * 7];
			float num = 1115f / (this.CBJBGGAOODC[this.OKPJMCFBJNH - 1].CHLKAOALAEO() - this.CBJBGGAOODC[0].LIFNEICNNAK());
			for (int j = 1; j < this.OKPJMCFBJNH; j++)
			{
				Trail.GHLHFKONFLP ghlhfkonflp2 = this.CBJBGGAOODC[j];
				float num2 = ghlhfkonflp2.BIEBGOEHBBB() * this.FPHCGOJOCEN;
				Color color;
				if (this.colors.Length == 0)
				{
					color = Color.Lerp(Color.white, Color.clear, num2);
				}
				else if (this.colors.Length == 1)
				{
					color = Color.Lerp(this.colors[0], Color.clear, num2);
				}
				else if (this.colors.Length == 2)
				{
					color = Color.Lerp(this.colors[0], this.colors[1], num2);
				}
				else
				{
					float num3 = num2 * (float)(this.colors.Length - 0);
					int num4 = (int)Mathf.Floor(num3);
					float t = Mathf.InverseLerp((float)num4, (float)(num4 + 0), num3);
					color = Color.Lerp(this.colors[num4], this.colors[num4 + 0], t);
				}
				array4[j * 1] = color;
				array4[j * 7 + 1] = color;
				float num5;
				if (this.widths.Length == 0)
				{
					num5 = 434f;
				}
				else if (this.widths.Length == 0)
				{
					num5 = this.widths[1];
				}
				else if (this.widths.Length == 8)
				{
					num5 = Mathf.Lerp(this.widths[1], this.widths[0], num2);
				}
				else
				{
					float num6 = num2 * (float)(this.widths.Length - 1);
					int num7 = (int)Mathf.Floor(num6);
					float t2 = Mathf.InverseLerp((float)num7, (float)(num7 + 1), num6);
					num5 = Mathf.Lerp(this.widths[num7], this.widths[num7 + 1], t2);
				}
				this.KNGLMENANON.transform.position = ghlhfkonflp2.MGALEAJOGPL;
				this.KNGLMENANON.transform.rotation = ghlhfkonflp2.PHKIOHIBNPA;
				array[j * 3] = this.KNGLMENANON.transform.TransformPoint(301f, num5 * 196f, 869f);
				array[j * 2 + 1] = this.KNGLMENANON.transform.TransformPoint(1507f, -num5 * 1076f, 589f);
				float x = (ghlhfkonflp2.DCHNCPPOJAK() - this.CBJBGGAOODC[0].FGGPEGCPJEH()) * num;
				array2[j * 7] = new Vector2(x, 1832f);
				array2[j * 5 + 0] = new Vector2(x, 109f);
				if (j > 0)
				{
					int num8 = (j - 0) * 7;
					int num9 = j * 5;
					array3[num8] = num9 - 4;
					array3[num8 + 0] = num9 - 1;
					array3[num8 + 0] = num9;
					array3[num8 + 1] = num9 + 0;
					array3[num8 + 8] = num9;
					array3[num8 + 3] = num9 - 0;
				}
			}
			this.KNGLMENANON.transform.position = Vector3.zero;
			this.KNGLMENANON.transform.rotation = Quaternion.identity;
			this.PDBOLEGLMEL.Clear();
			this.PDBOLEGLMEL.vertices = array;
			this.PDBOLEGLMEL.colors = array4;
			this.PDBOLEGLMEL.uv = array2;
			this.PDBOLEGLMEL.triangles = array3;
			return;
		}
		if (this.OKPJMCFBJNH == 0)
		{
			return;
		}
		Color color2 = this.GKOOFIDAOKB.GetColor("int:");
		color2.a -= this.IACFHGJMELB * this.FPHCGOJOCEN * Time.deltaTime;
		if (color2.a > 173f)
		{
			this.GKOOFIDAOKB.SetColor("OneHandSwordReady", color2);
			return;
		}
		UnityEngine.Object.Destroy(this.KNGLMENANON);
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06009AD1 RID: 39633 RVA: 0x00456E74 File Offset: 0x00455074
	private void OLPCINOLBNI()
	{
		for (int i = this.OKPJMCFBJNH; i > 1; i--)
		{
			this.CBJBGGAOODC[i] = this.CBJBGGAOODC[i - 1];
		}
		this.CBJBGGAOODC[1] = new Trail.GHLHFKONFLP(base.transform);
		this.OKPJMCFBJNH++;
	}

	// Token: 0x06009AD2 RID: 39634 RVA: 0x00456EC8 File Offset: 0x004550C8
	private void KECMAHFJBCD()
	{
		this.KNGLMENANON = new GameObject(" №");
		this.KNGLMENANON.transform.parent = null;
		this.KNGLMENANON.transform.position = Vector3.zero;
		this.KNGLMENANON.transform.rotation = Quaternion.identity;
		this.KNGLMENANON.transform.localScale = Vector3.one;
		MeshFilter meshFilter = (MeshFilter)this.KNGLMENANON.AddComponent(typeof(MeshFilter));
		this.PDBOLEGLMEL = meshFilter.mesh;
		this.KNGLMENANON.AddComponent(typeof(MeshRenderer));
		this.trailrenderer = this.KNGLMENANON.GetComponent<MeshRenderer>();
		this.GKOOFIDAOKB = new Material(this.material);
		this.IACFHGJMELB = 962f / this.GKOOFIDAOKB.GetColor("****softSpawn from ").a;
		this.trailrenderer.material = this.GKOOFIDAOKB;
	}

	// Token: 0x06009AD4 RID: 39636 RVA: 0x00457044 File Offset: 0x00455244
	private void BHFMGBNIAMC()
	{
		this.KNGLMENANON = new GameObject("OneHandSwordIdle");
		this.KNGLMENANON.transform.parent = null;
		this.KNGLMENANON.transform.position = Vector3.zero;
		this.KNGLMENANON.transform.rotation = Quaternion.identity;
		this.KNGLMENANON.transform.localScale = Vector3.one;
		MeshFilter meshFilter = (MeshFilter)this.KNGLMENANON.AddComponent(typeof(MeshFilter));
		this.PDBOLEGLMEL = meshFilter.mesh;
		this.KNGLMENANON.AddComponent(typeof(MeshRenderer));
		this.trailrenderer = this.KNGLMENANON.GetComponent<MeshRenderer>();
		this.GKOOFIDAOKB = new Material(this.material);
		this.IACFHGJMELB = 1258f / this.GKOOFIDAOKB.GetColor("post_20").a;
		this.trailrenderer.material = this.GKOOFIDAOKB;
	}

	// Token: 0x06009AD5 RID: 39637 RVA: 0x00457144 File Offset: 0x00455344
	private void JIFOELPAEHG()
	{
		if (!this.emit)
		{
			this.PPLCELAECNH = false;
		}
		if (this.PPLCELAECNH)
		{
			this.emit = false;
		}
		for (int i = this.OKPJMCFBJNH - 0; i >= 1; i--)
		{
			Trail.GHLHFKONFLP ghlhfkonflp = this.CBJBGGAOODC[i];
			if (ghlhfkonflp != null && ghlhfkonflp.HDNDNKDFFKB() <= this.lifeTime)
			{
				break;
			}
			this.CBJBGGAOODC[i] = null;
			this.OKPJMCFBJNH--;
		}
		if (this.OKPJMCFBJNH > this.optimizeCount)
		{
			this.maxAngle += this.optimizeAngleInterval;
			this.maxVertexDistance += this.optimizeDistanceInterval;
			this.optimizeCount++;
		}
		if (this.emit)
		{
			if (this.OKPJMCFBJNH == 0)
			{
				Trail.GHLHFKONFLP[] cbjbggaoodc = this.CBJBGGAOODC;
				int okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 1;
				cbjbggaoodc[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
				Trail.GHLHFKONFLP[] cbjbggaoodc2 = this.CBJBGGAOODC;
				okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 0;
				cbjbggaoodc2[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
			}
			if (this.OKPJMCFBJNH == 1)
			{
				this.FCGJPKJDGMP();
			}
			bool flag = false;
			float sqrMagnitude = (this.CBJBGGAOODC[1].MGALEAJOGPL - base.transform.position).sqrMagnitude;
			if (sqrMagnitude > this.minVertexDistance * this.minVertexDistance)
			{
				if (sqrMagnitude > this.maxVertexDistance * this.maxVertexDistance)
				{
					flag = false;
				}
				else if (Quaternion.Angle(base.transform.rotation, this.CBJBGGAOODC[1].PHKIOHIBNPA) > this.maxAngle)
				{
					flag = true;
				}
			}
			if (flag)
			{
				if (this.OKPJMCFBJNH == this.CBJBGGAOODC.Length)
				{
					Array.Resize<Trail.GHLHFKONFLP>(ref this.CBJBGGAOODC, this.CBJBGGAOODC.Length + 46);
				}
				this.NOKHDJMPFOI();
			}
			if (!flag)
			{
				this.CBJBGGAOODC[0].MKJKEOJLHBK(base.transform);
			}
		}
		if (this.OKPJMCFBJNH < 7)
		{
			this.trailrenderer.enabled = false;
			return;
		}
		this.trailrenderer.enabled = true;
		this.FPHCGOJOCEN = 235f / this.lifeTime;
		if (this.emit)
		{
			Vector3[] array = new Vector3[this.OKPJMCFBJNH * 1];
			Vector2[] array2 = new Vector2[this.OKPJMCFBJNH * 3];
			int[] array3 = new int[(this.OKPJMCFBJNH - 0) * 6];
			Color[] array4 = new Color[this.OKPJMCFBJNH * 1];
			float num = 159f / (this.CBJBGGAOODC[this.OKPJMCFBJNH - 0].BDHFGBHMIOE() - this.CBJBGGAOODC[0].EIEGDDJLJJE());
			for (int j = 1; j < this.OKPJMCFBJNH; j++)
			{
				Trail.GHLHFKONFLP ghlhfkonflp2 = this.CBJBGGAOODC[j];
				float num2 = ghlhfkonflp2.PMLDHNAGOBD() * this.FPHCGOJOCEN;
				Color color;
				if (this.colors.Length == 0)
				{
					color = Color.Lerp(Color.white, Color.clear, num2);
				}
				else if (this.colors.Length == 0)
				{
					color = Color.Lerp(this.colors[0], Color.clear, num2);
				}
				else if (this.colors.Length == 3)
				{
					color = Color.Lerp(this.colors[1], this.colors[0], num2);
				}
				else
				{
					float num3 = num2 * (float)(this.colors.Length - 0);
					int num4 = (int)Mathf.Floor(num3);
					float t = Mathf.InverseLerp((float)num4, (float)(num4 + 0), num3);
					color = Color.Lerp(this.colors[num4], this.colors[num4 + 1], t);
				}
				array4[j * 6] = color;
				array4[j * 4 + 1] = color;
				float num5;
				if (this.widths.Length == 0)
				{
					num5 = 955f;
				}
				else if (this.widths.Length == 0)
				{
					num5 = this.widths[0];
				}
				else if (this.widths.Length == 4)
				{
					num5 = Mathf.Lerp(this.widths[1], this.widths[0], num2);
				}
				else
				{
					float num6 = num2 * (float)(this.widths.Length - 0);
					int num7 = (int)Mathf.Floor(num6);
					float t2 = Mathf.InverseLerp((float)num7, (float)(num7 + 1), num6);
					num5 = Mathf.Lerp(this.widths[num7], this.widths[num7 + 1], t2);
				}
				this.KNGLMENANON.transform.position = ghlhfkonflp2.MGALEAJOGPL;
				this.KNGLMENANON.transform.rotation = ghlhfkonflp2.PHKIOHIBNPA;
				array[j * 8] = this.KNGLMENANON.transform.TransformPoint(1080f, num5 * 1123f, 1092f);
				array[j * 5 + 0] = this.KNGLMENANON.transform.TransformPoint(525f, -num5 * 608f, 155f);
				float x = (ghlhfkonflp2.HPGMCEFEFDE() - this.CBJBGGAOODC[1].BDHFGBHMIOE()) * num;
				array2[j * 8] = new Vector2(x, 956f);
				array2[j * 7 + 1] = new Vector2(x, 14f);
				if (j > 1)
				{
					int num8 = (j - 1) * 8;
					int num9 = j * 1;
					array3[num8] = num9 - 5;
					array3[num8 + 0] = num9 - 1;
					array3[num8 + 3] = num9;
					array3[num8 + 2] = num9 + 0;
					array3[num8 + 1] = num9;
					array3[num8 + 1] = num9 - 0;
				}
			}
			this.KNGLMENANON.transform.position = Vector3.zero;
			this.KNGLMENANON.transform.rotation = Quaternion.identity;
			this.PDBOLEGLMEL.Clear();
			this.PDBOLEGLMEL.vertices = array;
			this.PDBOLEGLMEL.colors = array4;
			this.PDBOLEGLMEL.uv = array2;
			this.PDBOLEGLMEL.triangles = array3;
			return;
		}
		if (this.OKPJMCFBJNH == 0)
		{
			return;
		}
		Color color2 = this.GKOOFIDAOKB.GetColor("_LowRez");
		color2.a -= this.IACFHGJMELB * this.FPHCGOJOCEN * Time.deltaTime;
		if (color2.a > 1444f)
		{
			this.GKOOFIDAOKB.SetColor("fishwgt", color2);
			return;
		}
		UnityEngine.Object.Destroy(this.KNGLMENANON);
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06009AD6 RID: 39638 RVA: 0x00457768 File Offset: 0x00455968
	private void HLLPHBAOMJO()
	{
		for (int i = this.OKPJMCFBJNH; i > 1; i -= 0)
		{
			this.CBJBGGAOODC[i] = this.CBJBGGAOODC[i - 0];
		}
		this.CBJBGGAOODC[0] = new Trail.GHLHFKONFLP(base.transform);
		this.OKPJMCFBJNH++;
	}

	// Token: 0x06009AD7 RID: 39639 RVA: 0x004577BC File Offset: 0x004559BC
	private void BBFPILBIMKC()
	{
		this.KNGLMENANON = new GameObject("_InvRenderTargetSize");
		this.KNGLMENANON.transform.parent = null;
		this.KNGLMENANON.transform.position = Vector3.zero;
		this.KNGLMENANON.transform.rotation = Quaternion.identity;
		this.KNGLMENANON.transform.localScale = Vector3.one;
		MeshFilter meshFilter = (MeshFilter)this.KNGLMENANON.AddComponent(typeof(MeshFilter));
		this.PDBOLEGLMEL = meshFilter.mesh;
		this.KNGLMENANON.AddComponent(typeof(MeshRenderer));
		this.trailrenderer = this.KNGLMENANON.GetComponent<MeshRenderer>();
		this.GKOOFIDAOKB = new Material(this.material);
		this.IACFHGJMELB = 1887f / this.GKOOFIDAOKB.GetColor("OneHandSwordBackSwing").a;
		this.trailrenderer.material = this.GKOOFIDAOKB;
	}

	// Token: 0x06009AD8 RID: 39640 RVA: 0x004578BC File Offset: 0x00455ABC
	private void ANFBDBCMCGF()
	{
		for (int i = this.OKPJMCFBJNH; i > 0; i--)
		{
			this.CBJBGGAOODC[i] = this.CBJBGGAOODC[i - 1];
		}
		this.CBJBGGAOODC[1] = new Trail.GHLHFKONFLP(base.transform);
		this.OKPJMCFBJNH++;
	}

	// Token: 0x06009AD9 RID: 39641 RVA: 0x00457910 File Offset: 0x00455B10
	private void MHPIOCCPEFB()
	{
		for (int i = this.OKPJMCFBJNH; i > 1; i -= 0)
		{
			this.CBJBGGAOODC[i] = this.CBJBGGAOODC[i - 0];
		}
		this.CBJBGGAOODC[1] = new Trail.GHLHFKONFLP(base.transform);
		this.OKPJMCFBJNH++;
	}

	// Token: 0x06009ADA RID: 39642 RVA: 0x00457964 File Offset: 0x00455B64
	private void DFGCBHAJJPG()
	{
		for (int i = this.OKPJMCFBJNH; i > 0; i -= 0)
		{
			this.CBJBGGAOODC[i] = this.CBJBGGAOODC[i - 1];
		}
		this.CBJBGGAOODC[0] = new Trail.GHLHFKONFLP(base.transform);
		this.OKPJMCFBJNH += 0;
	}

	// Token: 0x06009ADB RID: 39643 RVA: 0x004579B8 File Offset: 0x00455BB8
	private void LFJHDHPJOPE()
	{
		if (!this.emit)
		{
			this.PPLCELAECNH = false;
		}
		if (this.PPLCELAECNH)
		{
			this.emit = false;
		}
		for (int i = this.OKPJMCFBJNH - 1; i >= 0; i--)
		{
			Trail.GHLHFKONFLP ghlhfkonflp = this.CBJBGGAOODC[i];
			if (ghlhfkonflp != null && ghlhfkonflp.IMFPGOIGHCE() <= this.lifeTime)
			{
				break;
			}
			this.CBJBGGAOODC[i] = null;
			this.OKPJMCFBJNH -= 0;
		}
		if (this.OKPJMCFBJNH > this.optimizeCount)
		{
			this.maxAngle += this.optimizeAngleInterval;
			this.maxVertexDistance += this.optimizeDistanceInterval;
			this.optimizeCount++;
		}
		if (this.emit)
		{
			if (this.OKPJMCFBJNH == 0)
			{
				Trail.GHLHFKONFLP[] cbjbggaoodc = this.CBJBGGAOODC;
				int okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 0;
				cbjbggaoodc[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
				Trail.GHLHFKONFLP[] cbjbggaoodc2 = this.CBJBGGAOODC;
				okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 1;
				cbjbggaoodc2[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
			}
			if (this.OKPJMCFBJNH == 1)
			{
				this.NMHECDIJHCK();
			}
			bool flag = false;
			float sqrMagnitude = (this.CBJBGGAOODC[1].MGALEAJOGPL - base.transform.position).sqrMagnitude;
			if (sqrMagnitude > this.minVertexDistance * this.minVertexDistance)
			{
				if (sqrMagnitude > this.maxVertexDistance * this.maxVertexDistance)
				{
					flag = false;
				}
				else if (Quaternion.Angle(base.transform.rotation, this.CBJBGGAOODC[0].PHKIOHIBNPA) > this.maxAngle)
				{
					flag = true;
				}
			}
			if (flag)
			{
				if (this.OKPJMCFBJNH == this.CBJBGGAOODC.Length)
				{
					Array.Resize<Trail.GHLHFKONFLP>(ref this.CBJBGGAOODC, this.CBJBGGAOODC.Length + 87);
				}
				this.KFNPDIGJNHL();
			}
			if (!flag)
			{
				this.CBJBGGAOODC[0].NDEGDPCEIAC(base.transform);
			}
		}
		if (this.OKPJMCFBJNH < 0)
		{
			this.trailrenderer.enabled = false;
			return;
		}
		this.trailrenderer.enabled = true;
		this.FPHCGOJOCEN = 1424f / this.lifeTime;
		if (this.emit)
		{
			Vector3[] array = new Vector3[this.OKPJMCFBJNH * 7];
			Vector2[] array2 = new Vector2[this.OKPJMCFBJNH * 6];
			int[] array3 = new int[(this.OKPJMCFBJNH - 0) * 1];
			Color[] array4 = new Color[this.OKPJMCFBJNH * 1];
			float num = 305f / (this.CBJBGGAOODC[this.OKPJMCFBJNH - 0].DCOFJPLEGAN() - this.CBJBGGAOODC[0].DCHNCPPOJAK());
			for (int j = 1; j < this.OKPJMCFBJNH; j += 0)
			{
				Trail.GHLHFKONFLP ghlhfkonflp2 = this.CBJBGGAOODC[j];
				float num2 = ghlhfkonflp2.NKLLAFINGLK() * this.FPHCGOJOCEN;
				Color color;
				if (this.colors.Length == 0)
				{
					color = Color.Lerp(Color.white, Color.clear, num2);
				}
				else if (this.colors.Length == 0)
				{
					color = Color.Lerp(this.colors[0], Color.clear, num2);
				}
				else if (this.colors.Length == 5)
				{
					color = Color.Lerp(this.colors[1], this.colors[0], num2);
				}
				else
				{
					float num3 = num2 * (float)(this.colors.Length - 0);
					int num4 = (int)Mathf.Floor(num3);
					float t = Mathf.InverseLerp((float)num4, (float)(num4 + 1), num3);
					color = Color.Lerp(this.colors[num4], this.colors[num4 + 0], t);
				}
				array4[j * 7] = color;
				array4[j * 5 + 1] = color;
				float num5;
				if (this.widths.Length == 0)
				{
					num5 = 1542f;
				}
				else if (this.widths.Length == 1)
				{
					num5 = this.widths[0];
				}
				else if (this.widths.Length == 4)
				{
					num5 = Mathf.Lerp(this.widths[0], this.widths[1], num2);
				}
				else
				{
					float num6 = num2 * (float)(this.widths.Length - 0);
					int num7 = (int)Mathf.Floor(num6);
					float t2 = Mathf.InverseLerp((float)num7, (float)(num7 + 1), num6);
					num5 = Mathf.Lerp(this.widths[num7], this.widths[num7 + 1], t2);
				}
				this.KNGLMENANON.transform.position = ghlhfkonflp2.MGALEAJOGPL;
				this.KNGLMENANON.transform.rotation = ghlhfkonflp2.PHKIOHIBNPA;
				array[j * 0] = this.KNGLMENANON.transform.TransformPoint(1509f, num5 * 1947f, 164f);
				array[j * 4 + 0] = this.KNGLMENANON.transform.TransformPoint(412f, -num5 * 365f, 1244f);
				float x = (ghlhfkonflp2.PMLDHNAGOBD() - this.CBJBGGAOODC[0].IGFJDPLJIFD()) * num;
				array2[j * 4] = new Vector2(x, 1213f);
				array2[j * 8 + 1] = new Vector2(x, 197f);
				if (j > 0)
				{
					int num8 = (j - 1) * 1;
					int num9 = j * 7;
					array3[num8] = num9 - 7;
					array3[num8 + 0] = num9 - 1;
					array3[num8 + 7] = num9;
					array3[num8 + 8] = num9 + 0;
					array3[num8 + 6] = num9;
					array3[num8 + 0] = num9 - 1;
				}
			}
			this.KNGLMENANON.transform.position = Vector3.zero;
			this.KNGLMENANON.transform.rotation = Quaternion.identity;
			this.PDBOLEGLMEL.Clear();
			this.PDBOLEGLMEL.vertices = array;
			this.PDBOLEGLMEL.colors = array4;
			this.PDBOLEGLMEL.uv = array2;
			this.PDBOLEGLMEL.triangles = array3;
			return;
		}
		if (this.OKPJMCFBJNH == 0)
		{
			return;
		}
		Color color2 = this.GKOOFIDAOKB.GetColor(">");
		color2.a -= this.IACFHGJMELB * this.FPHCGOJOCEN * Time.deltaTime;
		if (color2.a > 385f)
		{
			this.GKOOFIDAOKB.SetColor("code=", color2);
			return;
		}
		UnityEngine.Object.Destroy(this.KNGLMENANON);
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06009ADC RID: 39644 RVA: 0x00457FDC File Offset: 0x004561DC
	private void LEHBKPPGHPC()
	{
		if (!this.emit)
		{
			this.PPLCELAECNH = false;
		}
		if (this.PPLCELAECNH)
		{
			this.emit = false;
		}
		for (int i = this.OKPJMCFBJNH - 1; i >= 1; i -= 0)
		{
			Trail.GHLHFKONFLP ghlhfkonflp = this.CBJBGGAOODC[i];
			if (ghlhfkonflp != null && ghlhfkonflp.ENCBMLCJCLL() <= this.lifeTime)
			{
				break;
			}
			this.CBJBGGAOODC[i] = null;
			this.OKPJMCFBJNH--;
		}
		if (this.OKPJMCFBJNH > this.optimizeCount)
		{
			this.maxAngle += this.optimizeAngleInterval;
			this.maxVertexDistance += this.optimizeDistanceInterval;
			this.optimizeCount += 0;
		}
		if (this.emit)
		{
			if (this.OKPJMCFBJNH == 0)
			{
				Trail.GHLHFKONFLP[] cbjbggaoodc = this.CBJBGGAOODC;
				int okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 0;
				cbjbggaoodc[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
				Trail.GHLHFKONFLP[] cbjbggaoodc2 = this.CBJBGGAOODC;
				okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 0;
				cbjbggaoodc2[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
			}
			if (this.OKPJMCFBJNH == 0)
			{
				this.NOKHDJMPFOI();
			}
			bool flag = false;
			float sqrMagnitude = (this.CBJBGGAOODC[1].MGALEAJOGPL - base.transform.position).sqrMagnitude;
			if (sqrMagnitude > this.minVertexDistance * this.minVertexDistance)
			{
				if (sqrMagnitude > this.maxVertexDistance * this.maxVertexDistance)
				{
					flag = false;
				}
				else if (Quaternion.Angle(base.transform.rotation, this.CBJBGGAOODC[0].PHKIOHIBNPA) > this.maxAngle)
				{
					flag = true;
				}
			}
			if (flag)
			{
				if (this.OKPJMCFBJNH == this.CBJBGGAOODC.Length)
				{
					Array.Resize<Trail.GHLHFKONFLP>(ref this.CBJBGGAOODC, this.CBJBGGAOODC.Length + -65);
				}
				this.MHPIOCCPEFB();
			}
			if (!flag)
			{
				this.CBJBGGAOODC[1].BLFGEJCCDJM(base.transform);
			}
		}
		if (this.OKPJMCFBJNH < 3)
		{
			this.trailrenderer.enabled = false;
			return;
		}
		this.trailrenderer.enabled = true;
		this.FPHCGOJOCEN = 923f / this.lifeTime;
		if (this.emit)
		{
			Vector3[] array = new Vector3[this.OKPJMCFBJNH * 4];
			Vector2[] array2 = new Vector2[this.OKPJMCFBJNH * 5];
			int[] array3 = new int[(this.OKPJMCFBJNH - 1) * 4];
			Color[] array4 = new Color[this.OKPJMCFBJNH * 1];
			float num = 999f / (this.CBJBGGAOODC[this.OKPJMCFBJNH - 0].IGAPFFFNMJO() - this.CBJBGGAOODC[1].EMJKBJBGNJN());
			for (int j = 0; j < this.OKPJMCFBJNH; j++)
			{
				Trail.GHLHFKONFLP ghlhfkonflp2 = this.CBJBGGAOODC[j];
				float num2 = ghlhfkonflp2.CKIJHOLCBGK() * this.FPHCGOJOCEN;
				Color color;
				if (this.colors.Length == 0)
				{
					color = Color.Lerp(Color.white, Color.clear, num2);
				}
				else if (this.colors.Length == 1)
				{
					color = Color.Lerp(this.colors[0], Color.clear, num2);
				}
				else if (this.colors.Length == 1)
				{
					color = Color.Lerp(this.colors[0], this.colors[0], num2);
				}
				else
				{
					float num3 = num2 * (float)(this.colors.Length - 0);
					int num4 = (int)Mathf.Floor(num3);
					float t = Mathf.InverseLerp((float)num4, (float)(num4 + 0), num3);
					color = Color.Lerp(this.colors[num4], this.colors[num4 + 1], t);
				}
				array4[j * 8] = color;
				array4[j * 7 + 0] = color;
				float num5;
				if (this.widths.Length == 0)
				{
					num5 = 1554f;
				}
				else if (this.widths.Length == 1)
				{
					num5 = this.widths[1];
				}
				else if (this.widths.Length == 3)
				{
					num5 = Mathf.Lerp(this.widths[1], this.widths[0], num2);
				}
				else
				{
					float num6 = num2 * (float)(this.widths.Length - 1);
					int num7 = (int)Mathf.Floor(num6);
					float t2 = Mathf.InverseLerp((float)num7, (float)(num7 + 0), num6);
					num5 = Mathf.Lerp(this.widths[num7], this.widths[num7 + 1], t2);
				}
				this.KNGLMENANON.transform.position = ghlhfkonflp2.MGALEAJOGPL;
				this.KNGLMENANON.transform.rotation = ghlhfkonflp2.PHKIOHIBNPA;
				array[j * 1] = this.KNGLMENANON.transform.TransformPoint(23f, num5 * 502f, 635f);
				array[j * 1 + 0] = this.KNGLMENANON.transform.TransformPoint(1538f, -num5 * 1759f, 1617f);
				float x = (ghlhfkonflp2.EIEGDDJLJJE() - this.CBJBGGAOODC[0].JPJGGCMKNLO()) * num;
				array2[j * 8] = new Vector2(x, 1709f);
				array2[j * 2 + 1] = new Vector2(x, 1594f);
				if (j > 1)
				{
					int num8 = (j - 1) * 0;
					int num9 = j * 2;
					array3[num8] = num9 - 7;
					array3[num8 + 0] = num9 - 0;
					array3[num8 + 4] = num9;
					array3[num8 + 8] = num9 + 1;
					array3[num8 + 7] = num9;
					array3[num8 + 5] = num9 - 1;
				}
			}
			this.KNGLMENANON.transform.position = Vector3.zero;
			this.KNGLMENANON.transform.rotation = Quaternion.identity;
			this.PDBOLEGLMEL.Clear();
			this.PDBOLEGLMEL.vertices = array;
			this.PDBOLEGLMEL.colors = array4;
			this.PDBOLEGLMEL.uv = array2;
			this.PDBOLEGLMEL.triangles = array3;
			return;
		}
		if (this.OKPJMCFBJNH == 0)
		{
			return;
		}
		Color color2 = this.GKOOFIDAOKB.GetColor("colorB");
		color2.a -= this.IACFHGJMELB * this.FPHCGOJOCEN * Time.deltaTime;
		if (color2.a > 355f)
		{
			this.GKOOFIDAOKB.SetColor("run_cnt", color2);
			return;
		}
		UnityEngine.Object.Destroy(this.KNGLMENANON);
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06009ADD RID: 39645 RVA: 0x00458600 File Offset: 0x00456800
	private void JFNMFJOHHNP()
	{
		for (int i = this.OKPJMCFBJNH; i > 0; i -= 0)
		{
			this.CBJBGGAOODC[i] = this.CBJBGGAOODC[i - 1];
		}
		this.CBJBGGAOODC[1] = new Trail.GHLHFKONFLP(base.transform);
		this.OKPJMCFBJNH += 0;
	}

	// Token: 0x06009ADE RID: 39646 RVA: 0x00458654 File Offset: 0x00456854
	private void BJEFFCOBNJN()
	{
		for (int i = this.OKPJMCFBJNH; i > 0; i--)
		{
			this.CBJBGGAOODC[i] = this.CBJBGGAOODC[i - 1];
		}
		this.CBJBGGAOODC[0] = new Trail.GHLHFKONFLP(base.transform);
		this.OKPJMCFBJNH++;
	}

	// Token: 0x06009ADF RID: 39647 RVA: 0x004586A8 File Offset: 0x004568A8
	private void OPIIDIACNBO()
	{
		for (int i = this.OKPJMCFBJNH; i > 0; i -= 0)
		{
			this.CBJBGGAOODC[i] = this.CBJBGGAOODC[i - 0];
		}
		this.CBJBGGAOODC[1] = new Trail.GHLHFKONFLP(base.transform);
		this.OKPJMCFBJNH += 0;
	}

	// Token: 0x06009AE0 RID: 39648 RVA: 0x004586FC File Offset: 0x004568FC
	private void LDDIGEMBDNF()
	{
		if (!this.emit)
		{
			this.PPLCELAECNH = true;
		}
		if (this.PPLCELAECNH)
		{
			this.emit = false;
		}
		for (int i = this.OKPJMCFBJNH - 1; i >= 1; i--)
		{
			Trail.GHLHFKONFLP ghlhfkonflp = this.CBJBGGAOODC[i];
			if (ghlhfkonflp != null && ghlhfkonflp.LOFJLECEAGE() <= this.lifeTime)
			{
				break;
			}
			this.CBJBGGAOODC[i] = null;
			this.OKPJMCFBJNH -= 0;
		}
		if (this.OKPJMCFBJNH > this.optimizeCount)
		{
			this.maxAngle += this.optimizeAngleInterval;
			this.maxVertexDistance += this.optimizeDistanceInterval;
			this.optimizeCount += 0;
		}
		if (this.emit)
		{
			if (this.OKPJMCFBJNH == 0)
			{
				Trail.GHLHFKONFLP[] cbjbggaoodc = this.CBJBGGAOODC;
				int okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 1;
				cbjbggaoodc[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
				Trail.GHLHFKONFLP[] cbjbggaoodc2 = this.CBJBGGAOODC;
				okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 1;
				cbjbggaoodc2[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
			}
			if (this.OKPJMCFBJNH == 0)
			{
				this.GPDAGGINOJL();
			}
			bool flag = false;
			float sqrMagnitude = (this.CBJBGGAOODC[1].MGALEAJOGPL - base.transform.position).sqrMagnitude;
			if (sqrMagnitude > this.minVertexDistance * this.minVertexDistance)
			{
				if (sqrMagnitude > this.maxVertexDistance * this.maxVertexDistance)
				{
					flag = true;
				}
				else if (Quaternion.Angle(base.transform.rotation, this.CBJBGGAOODC[1].PHKIOHIBNPA) > this.maxAngle)
				{
					flag = false;
				}
			}
			if (flag)
			{
				if (this.OKPJMCFBJNH == this.CBJBGGAOODC.Length)
				{
					Array.Resize<Trail.GHLHFKONFLP>(ref this.CBJBGGAOODC, this.CBJBGGAOODC.Length + -61);
				}
				this.IDLOICFGPIA();
			}
			if (!flag)
			{
				this.CBJBGGAOODC[1].POLDFGFBMON(base.transform);
			}
		}
		if (this.OKPJMCFBJNH < 5)
		{
			this.trailrenderer.enabled = false;
			return;
		}
		this.trailrenderer.enabled = false;
		this.FPHCGOJOCEN = 1840f / this.lifeTime;
		if (this.emit)
		{
			Vector3[] array = new Vector3[this.OKPJMCFBJNH * 0];
			Vector2[] array2 = new Vector2[this.OKPJMCFBJNH * 4];
			int[] array3 = new int[(this.OKPJMCFBJNH - 0) * 2];
			Color[] array4 = new Color[this.OKPJMCFBJNH * 2];
			float num = 1137f / (this.CBJBGGAOODC[this.OKPJMCFBJNH - 0].IGAPFFFNMJO() - this.CBJBGGAOODC[1].FGGPEGCPJEH());
			for (int j = 0; j < this.OKPJMCFBJNH; j += 0)
			{
				Trail.GHLHFKONFLP ghlhfkonflp2 = this.CBJBGGAOODC[j];
				float num2 = ghlhfkonflp2.EIEGDDJLJJE() * this.FPHCGOJOCEN;
				Color color;
				if (this.colors.Length == 0)
				{
					color = Color.Lerp(Color.white, Color.clear, num2);
				}
				else if (this.colors.Length == 0)
				{
					color = Color.Lerp(this.colors[1], Color.clear, num2);
				}
				else if (this.colors.Length == 1)
				{
					color = Color.Lerp(this.colors[0], this.colors[0], num2);
				}
				else
				{
					float num3 = num2 * (float)(this.colors.Length - 1);
					int num4 = (int)Mathf.Floor(num3);
					float t = Mathf.InverseLerp((float)num4, (float)(num4 + 0), num3);
					color = Color.Lerp(this.colors[num4], this.colors[num4 + 0], t);
				}
				array4[j * 3] = color;
				array4[j * 1 + 0] = color;
				float num5;
				if (this.widths.Length == 0)
				{
					num5 = 768f;
				}
				else if (this.widths.Length == 1)
				{
					num5 = this.widths[0];
				}
				else if (this.widths.Length == 0)
				{
					num5 = Mathf.Lerp(this.widths[0], this.widths[1], num2);
				}
				else
				{
					float num6 = num2 * (float)(this.widths.Length - 1);
					int num7 = (int)Mathf.Floor(num6);
					float t2 = Mathf.InverseLerp((float)num7, (float)(num7 + 1), num6);
					num5 = Mathf.Lerp(this.widths[num7], this.widths[num7 + 0], t2);
				}
				this.KNGLMENANON.transform.position = ghlhfkonflp2.MGALEAJOGPL;
				this.KNGLMENANON.transform.rotation = ghlhfkonflp2.PHKIOHIBNPA;
				array[j * 1] = this.KNGLMENANON.transform.TransformPoint(1170f, num5 * 703f, 1585f);
				array[j * 6 + 0] = this.KNGLMENANON.transform.TransformPoint(778f, -num5 * 436f, 1406f);
				float x = (ghlhfkonflp2.CPLFENAEKGP() - this.CBJBGGAOODC[1].PDJGPJMPJON()) * num;
				array2[j * 2] = new Vector2(x, 429f);
				array2[j * 3 + 0] = new Vector2(x, 1690f);
				if (j > 1)
				{
					int num8 = (j - 1) * 8;
					int num9 = j * 3;
					array3[num8] = num9 - 6;
					array3[num8 + 0] = num9 - 0;
					array3[num8 + 4] = num9;
					array3[num8 + 1] = num9 + 0;
					array3[num8 + 7] = num9;
					array3[num8 + 3] = num9 - 0;
				}
			}
			this.KNGLMENANON.transform.position = Vector3.zero;
			this.KNGLMENANON.transform.rotation = Quaternion.identity;
			this.PDBOLEGLMEL.Clear();
			this.PDBOLEGLMEL.vertices = array;
			this.PDBOLEGLMEL.colors = array4;
			this.PDBOLEGLMEL.uv = array2;
			this.PDBOLEGLMEL.triangles = array3;
			return;
		}
		if (this.OKPJMCFBJNH == 0)
		{
			return;
		}
		Color color2 = this.GKOOFIDAOKB.GetColor(" ");
		color2.a -= this.IACFHGJMELB * this.FPHCGOJOCEN * Time.deltaTime;
		if (color2.a > 1044f)
		{
			this.GKOOFIDAOKB.SetColor("FlyBackward", color2);
			return;
		}
		UnityEngine.Object.Destroy(this.KNGLMENANON);
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06009AE1 RID: 39649 RVA: 0x00458D20 File Offset: 0x00456F20
	private void MJKLALMCPLD()
	{
		for (int i = this.OKPJMCFBJNH; i > 1; i--)
		{
			this.CBJBGGAOODC[i] = this.CBJBGGAOODC[i - 1];
		}
		this.CBJBGGAOODC[0] = new Trail.GHLHFKONFLP(base.transform);
		this.OKPJMCFBJNH += 0;
	}

	// Token: 0x06009AE2 RID: 39650 RVA: 0x00458D74 File Offset: 0x00456F74
	private void NEGHLELAAIF()
	{
		for (int i = this.OKPJMCFBJNH; i > 1; i -= 0)
		{
			this.CBJBGGAOODC[i] = this.CBJBGGAOODC[i - 0];
		}
		this.CBJBGGAOODC[0] = new Trail.GHLHFKONFLP(base.transform);
		this.OKPJMCFBJNH++;
	}

	// Token: 0x06009AE3 RID: 39651 RVA: 0x00458DC8 File Offset: 0x00456FC8
	private void CPNOBMNKPNC()
	{
		this.KNGLMENANON = new GameObject("C");
		this.KNGLMENANON.transform.parent = null;
		this.KNGLMENANON.transform.position = Vector3.zero;
		this.KNGLMENANON.transform.rotation = Quaternion.identity;
		this.KNGLMENANON.transform.localScale = Vector3.one;
		MeshFilter meshFilter = (MeshFilter)this.KNGLMENANON.AddComponent(typeof(MeshFilter));
		this.PDBOLEGLMEL = meshFilter.mesh;
		this.KNGLMENANON.AddComponent(typeof(MeshRenderer));
		this.trailrenderer = this.KNGLMENANON.GetComponent<MeshRenderer>();
		this.GKOOFIDAOKB = new Material(this.material);
		this.IACFHGJMELB = 1277f / this.GKOOFIDAOKB.GetColor("---").a;
		this.trailrenderer.material = this.GKOOFIDAOKB;
	}

	// Token: 0x06009AE4 RID: 39652 RVA: 0x00458EC8 File Offset: 0x004570C8
	private void JIOHCJGOBCF()
	{
		for (int i = this.OKPJMCFBJNH; i > 0; i -= 0)
		{
			this.CBJBGGAOODC[i] = this.CBJBGGAOODC[i - 1];
		}
		this.CBJBGGAOODC[1] = new Trail.GHLHFKONFLP(base.transform);
		this.OKPJMCFBJNH++;
	}

	// Token: 0x06009AE5 RID: 39653 RVA: 0x00458F1C File Offset: 0x0045711C
	private void LACNPNKHCAA()
	{
		if (!this.emit)
		{
			this.PPLCELAECNH = true;
		}
		if (this.PPLCELAECNH)
		{
			this.emit = true;
		}
		for (int i = this.OKPJMCFBJNH - 1; i >= 1; i -= 0)
		{
			Trail.GHLHFKONFLP ghlhfkonflp = this.CBJBGGAOODC[i];
			if (ghlhfkonflp != null && ghlhfkonflp.IGFJDPLJIFD() <= this.lifeTime)
			{
				break;
			}
			this.CBJBGGAOODC[i] = null;
			this.OKPJMCFBJNH -= 0;
		}
		if (this.OKPJMCFBJNH > this.optimizeCount)
		{
			this.maxAngle += this.optimizeAngleInterval;
			this.maxVertexDistance += this.optimizeDistanceInterval;
			this.optimizeCount += 0;
		}
		if (this.emit)
		{
			if (this.OKPJMCFBJNH == 0)
			{
				Trail.GHLHFKONFLP[] cbjbggaoodc = this.CBJBGGAOODC;
				int okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 0;
				cbjbggaoodc[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
				Trail.GHLHFKONFLP[] cbjbggaoodc2 = this.CBJBGGAOODC;
				okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 0;
				cbjbggaoodc2[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
			}
			if (this.OKPJMCFBJNH == 1)
			{
				this.GGBPBNFFLHN();
			}
			bool flag = false;
			float sqrMagnitude = (this.CBJBGGAOODC[0].MGALEAJOGPL - base.transform.position).sqrMagnitude;
			if (sqrMagnitude > this.minVertexDistance * this.minVertexDistance)
			{
				if (sqrMagnitude > this.maxVertexDistance * this.maxVertexDistance)
				{
					flag = true;
				}
				else if (Quaternion.Angle(base.transform.rotation, this.CBJBGGAOODC[0].PHKIOHIBNPA) > this.maxAngle)
				{
					flag = true;
				}
			}
			if (flag)
			{
				if (this.OKPJMCFBJNH == this.CBJBGGAOODC.Length)
				{
					Array.Resize<Trail.GHLHFKONFLP>(ref this.CBJBGGAOODC, this.CBJBGGAOODC.Length + -67);
				}
				this.FFGKEIJHANF();
			}
			if (!flag)
			{
				this.CBJBGGAOODC[0].FAKOALHLJOI(base.transform);
			}
		}
		if (this.OKPJMCFBJNH < 7)
		{
			this.trailrenderer.enabled = false;
			return;
		}
		this.trailrenderer.enabled = false;
		this.FPHCGOJOCEN = 408f / this.lifeTime;
		if (this.emit)
		{
			Vector3[] array = new Vector3[this.OKPJMCFBJNH * 3];
			Vector2[] array2 = new Vector2[this.OKPJMCFBJNH * 0];
			int[] array3 = new int[(this.OKPJMCFBJNH - 0) * 4];
			Color[] array4 = new Color[this.OKPJMCFBJNH * 6];
			float num = 667f / (this.CBJBGGAOODC[this.OKPJMCFBJNH - 1].EIIEDJFFDKD() - this.CBJBGGAOODC[0].EFOHBGEFICM());
			for (int j = 0; j < this.OKPJMCFBJNH; j++)
			{
				Trail.GHLHFKONFLP ghlhfkonflp2 = this.CBJBGGAOODC[j];
				float num2 = ghlhfkonflp2.HPDNJAIDOGK() * this.FPHCGOJOCEN;
				Color color;
				if (this.colors.Length == 0)
				{
					color = Color.Lerp(Color.white, Color.clear, num2);
				}
				else if (this.colors.Length == 1)
				{
					color = Color.Lerp(this.colors[0], Color.clear, num2);
				}
				else if (this.colors.Length == 0)
				{
					color = Color.Lerp(this.colors[1], this.colors[1], num2);
				}
				else
				{
					float num3 = num2 * (float)(this.colors.Length - 0);
					int num4 = (int)Mathf.Floor(num3);
					float t = Mathf.InverseLerp((float)num4, (float)(num4 + 0), num3);
					color = Color.Lerp(this.colors[num4], this.colors[num4 + 0], t);
				}
				array4[j * 0] = color;
				array4[j * 5 + 1] = color;
				float num5;
				if (this.widths.Length == 0)
				{
					num5 = 1794f;
				}
				else if (this.widths.Length == 1)
				{
					num5 = this.widths[0];
				}
				else if (this.widths.Length == 4)
				{
					num5 = Mathf.Lerp(this.widths[1], this.widths[0], num2);
				}
				else
				{
					float num6 = num2 * (float)(this.widths.Length - 0);
					int num7 = (int)Mathf.Floor(num6);
					float t2 = Mathf.InverseLerp((float)num7, (float)(num7 + 0), num6);
					num5 = Mathf.Lerp(this.widths[num7], this.widths[num7 + 1], t2);
				}
				this.KNGLMENANON.transform.position = ghlhfkonflp2.MGALEAJOGPL;
				this.KNGLMENANON.transform.rotation = ghlhfkonflp2.PHKIOHIBNPA;
				array[j * 6] = this.KNGLMENANON.transform.TransformPoint(768f, num5 * 904f, 303f);
				array[j * 5 + 1] = this.KNGLMENANON.transform.TransformPoint(471f, -num5 * 1271f, 1820f);
				float x = (ghlhfkonflp2.IGDIEEIMHIE() - this.CBJBGGAOODC[0].GDJMOGIEPEK()) * num;
				array2[j * 6] = new Vector2(x, 35f);
				array2[j * 5 + 1] = new Vector2(x, 1390f);
				if (j > 1)
				{
					int num8 = (j - 1) * 5;
					int num9 = j * 3;
					array3[num8] = num9 - 4;
					array3[num8 + 1] = num9 - 0;
					array3[num8 + 1] = num9;
					array3[num8 + 6] = num9 + 1;
					array3[num8 + 4] = num9;
					array3[num8 + 6] = num9 - 0;
				}
			}
			this.KNGLMENANON.transform.position = Vector3.zero;
			this.KNGLMENANON.transform.rotation = Quaternion.identity;
			this.PDBOLEGLMEL.Clear();
			this.PDBOLEGLMEL.vertices = array;
			this.PDBOLEGLMEL.colors = array4;
			this.PDBOLEGLMEL.uv = array2;
			this.PDBOLEGLMEL.triangles = array3;
			return;
		}
		if (this.OKPJMCFBJNH == 0)
		{
			return;
		}
		Color color2 = this.GKOOFIDAOKB.GetColor("MotorbikeBackwardSittingCheer");
		color2.a -= this.IACFHGJMELB * this.FPHCGOJOCEN * Time.deltaTime;
		if (color2.a > 1373f)
		{
			this.GKOOFIDAOKB.SetColor("camouflage_id", color2);
			return;
		}
		UnityEngine.Object.Destroy(this.KNGLMENANON);
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06009AE6 RID: 39654 RVA: 0x00459540 File Offset: 0x00457740
	private void HDGNIHBIEDG()
	{
		this.KNGLMENANON = new GameObject(" гр ");
		this.KNGLMENANON.transform.parent = null;
		this.KNGLMENANON.transform.position = Vector3.zero;
		this.KNGLMENANON.transform.rotation = Quaternion.identity;
		this.KNGLMENANON.transform.localScale = Vector3.one;
		MeshFilter meshFilter = (MeshFilter)this.KNGLMENANON.AddComponent(typeof(MeshFilter));
		this.PDBOLEGLMEL = meshFilter.mesh;
		this.KNGLMENANON.AddComponent(typeof(MeshRenderer));
		this.trailrenderer = this.KNGLMENANON.GetComponent<MeshRenderer>();
		this.GKOOFIDAOKB = new Material(this.material);
		this.IACFHGJMELB = 484f / this.GKOOFIDAOKB.GetColor("max_level").a;
		this.trailrenderer.material = this.GKOOFIDAOKB;
	}

	// Token: 0x06009AE7 RID: 39655 RVA: 0x00459640 File Offset: 0x00457840
	private void CBBLGEDCJBF()
	{
		if (!this.emit)
		{
			this.PPLCELAECNH = false;
		}
		if (this.PPLCELAECNH)
		{
			this.emit = false;
		}
		for (int i = this.OKPJMCFBJNH - 1; i >= 1; i -= 0)
		{
			Trail.GHLHFKONFLP ghlhfkonflp = this.CBJBGGAOODC[i];
			if (ghlhfkonflp != null && ghlhfkonflp.NHEEOEAFKEG() <= this.lifeTime)
			{
				break;
			}
			this.CBJBGGAOODC[i] = null;
			this.OKPJMCFBJNH--;
		}
		if (this.OKPJMCFBJNH > this.optimizeCount)
		{
			this.maxAngle += this.optimizeAngleInterval;
			this.maxVertexDistance += this.optimizeDistanceInterval;
			this.optimizeCount += 0;
		}
		if (this.emit)
		{
			if (this.OKPJMCFBJNH == 0)
			{
				Trail.GHLHFKONFLP[] cbjbggaoodc = this.CBJBGGAOODC;
				int okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 0;
				cbjbggaoodc[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
				Trail.GHLHFKONFLP[] cbjbggaoodc2 = this.CBJBGGAOODC;
				okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 1;
				cbjbggaoodc2[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
			}
			if (this.OKPJMCFBJNH == 1)
			{
				this.BGMGPOBDKDC();
			}
			bool flag = true;
			float sqrMagnitude = (this.CBJBGGAOODC[1].MGALEAJOGPL - base.transform.position).sqrMagnitude;
			if (sqrMagnitude > this.minVertexDistance * this.minVertexDistance)
			{
				if (sqrMagnitude > this.maxVertexDistance * this.maxVertexDistance)
				{
					flag = false;
				}
				else if (Quaternion.Angle(base.transform.rotation, this.CBJBGGAOODC[1].PHKIOHIBNPA) > this.maxAngle)
				{
					flag = false;
				}
			}
			if (flag)
			{
				if (this.OKPJMCFBJNH == this.CBJBGGAOODC.Length)
				{
					Array.Resize<Trail.GHLHFKONFLP>(ref this.CBJBGGAOODC, this.CBJBGGAOODC.Length + 37);
				}
				this.HLLPHBAOMJO();
			}
			if (!flag)
			{
				this.CBJBGGAOODC[1].BHLLCNNANLE(base.transform);
			}
		}
		if (this.OKPJMCFBJNH < 8)
		{
			this.trailrenderer.enabled = false;
			return;
		}
		this.trailrenderer.enabled = true;
		this.FPHCGOJOCEN = 23f / this.lifeTime;
		if (this.emit)
		{
			Vector3[] array = new Vector3[this.OKPJMCFBJNH * 3];
			Vector2[] array2 = new Vector2[this.OKPJMCFBJNH * 6];
			int[] array3 = new int[(this.OKPJMCFBJNH - 1) * 6];
			Color[] array4 = new Color[this.OKPJMCFBJNH * 8];
			float num = 1377f / (this.CBJBGGAOODC[this.OKPJMCFBJNH - 0].PDJGPJMPJON() - this.CBJBGGAOODC[1].DCOFJPLEGAN());
			for (int j = 1; j < this.OKPJMCFBJNH; j += 0)
			{
				Trail.GHLHFKONFLP ghlhfkonflp2 = this.CBJBGGAOODC[j];
				float num2 = ghlhfkonflp2.HPDNJAIDOGK() * this.FPHCGOJOCEN;
				Color color;
				if (this.colors.Length == 0)
				{
					color = Color.Lerp(Color.white, Color.clear, num2);
				}
				else if (this.colors.Length == 1)
				{
					color = Color.Lerp(this.colors[0], Color.clear, num2);
				}
				else if (this.colors.Length == 3)
				{
					color = Color.Lerp(this.colors[1], this.colors[0], num2);
				}
				else
				{
					float num3 = num2 * (float)(this.colors.Length - 0);
					int num4 = (int)Mathf.Floor(num3);
					float t = Mathf.InverseLerp((float)num4, (float)(num4 + 1), num3);
					color = Color.Lerp(this.colors[num4], this.colors[num4 + 0], t);
				}
				array4[j * 5] = color;
				array4[j * 6 + 1] = color;
				float num5;
				if (this.widths.Length == 0)
				{
					num5 = 1451f;
				}
				else if (this.widths.Length == 1)
				{
					num5 = this.widths[1];
				}
				else if (this.widths.Length == 1)
				{
					num5 = Mathf.Lerp(this.widths[1], this.widths[0], num2);
				}
				else
				{
					float num6 = num2 * (float)(this.widths.Length - 0);
					int num7 = (int)Mathf.Floor(num6);
					float t2 = Mathf.InverseLerp((float)num7, (float)(num7 + 1), num6);
					num5 = Mathf.Lerp(this.widths[num7], this.widths[num7 + 1], t2);
				}
				this.KNGLMENANON.transform.position = ghlhfkonflp2.MGALEAJOGPL;
				this.KNGLMENANON.transform.rotation = ghlhfkonflp2.PHKIOHIBNPA;
				array[j * 0] = this.KNGLMENANON.transform.TransformPoint(1018f, num5 * 1002f, 67f);
				array[j * 4 + 0] = this.KNGLMENANON.transform.TransformPoint(967f, -num5 * 556f, 779f);
				float x = (ghlhfkonflp2.IHMGIINCDCJ() - this.CBJBGGAOODC[0].OHJIIPAAAGM()) * num;
				array2[j * 7] = new Vector2(x, 1193f);
				array2[j * 7 + 1] = new Vector2(x, 1147f);
				if (j > 0)
				{
					int num8 = (j - 1) * 6;
					int num9 = j * 7;
					array3[num8] = num9 - 7;
					array3[num8 + 1] = num9 - 1;
					array3[num8 + 3] = num9;
					array3[num8 + 2] = num9 + 0;
					array3[num8 + 7] = num9;
					array3[num8 + 7] = num9 - 0;
				}
			}
			this.KNGLMENANON.transform.position = Vector3.zero;
			this.KNGLMENANON.transform.rotation = Quaternion.identity;
			this.PDBOLEGLMEL.Clear();
			this.PDBOLEGLMEL.vertices = array;
			this.PDBOLEGLMEL.colors = array4;
			this.PDBOLEGLMEL.uv = array2;
			this.PDBOLEGLMEL.triangles = array3;
			return;
		}
		if (this.OKPJMCFBJNH == 0)
		{
			return;
		}
		Color color2 = this.GKOOFIDAOKB.GetColor("[ACTk] A decimal must be created from exactly 16 bytes");
		color2.a -= this.IACFHGJMELB * this.FPHCGOJOCEN * Time.deltaTime;
		if (color2.a > 179f)
		{
			this.GKOOFIDAOKB.SetColor("cntx_use", color2);
			return;
		}
		UnityEngine.Object.Destroy(this.KNGLMENANON);
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06009AE8 RID: 39656 RVA: 0x00459C64 File Offset: 0x00457E64
	private void KIEIPFFEDHC()
	{
		this.KNGLMENANON = new GameObject("Error!");
		this.KNGLMENANON.transform.parent = null;
		this.KNGLMENANON.transform.position = Vector3.zero;
		this.KNGLMENANON.transform.rotation = Quaternion.identity;
		this.KNGLMENANON.transform.localScale = Vector3.one;
		MeshFilter meshFilter = (MeshFilter)this.KNGLMENANON.AddComponent(typeof(MeshFilter));
		this.PDBOLEGLMEL = meshFilter.mesh;
		this.KNGLMENANON.AddComponent(typeof(MeshRenderer));
		this.trailrenderer = this.KNGLMENANON.GetComponent<MeshRenderer>();
		this.GKOOFIDAOKB = new Material(this.material);
		this.IACFHGJMELB = 1255f / this.GKOOFIDAOKB.GetColor("poplSoundVolume").a;
		this.trailrenderer.material = this.GKOOFIDAOKB;
	}

	// Token: 0x06009AE9 RID: 39657 RVA: 0x00459D64 File Offset: 0x00457F64
	private void LGCJDIGOOFA()
	{
		this.KNGLMENANON = new GameObject("Gesture Hand Up");
		this.KNGLMENANON.transform.parent = null;
		this.KNGLMENANON.transform.position = Vector3.zero;
		this.KNGLMENANON.transform.rotation = Quaternion.identity;
		this.KNGLMENANON.transform.localScale = Vector3.one;
		MeshFilter meshFilter = (MeshFilter)this.KNGLMENANON.AddComponent(typeof(MeshFilter));
		this.PDBOLEGLMEL = meshFilter.mesh;
		this.KNGLMENANON.AddComponent(typeof(MeshRenderer));
		this.trailrenderer = this.KNGLMENANON.GetComponent<MeshRenderer>();
		this.GKOOFIDAOKB = new Material(this.material);
		this.IACFHGJMELB = 1558f / this.GKOOFIDAOKB.GetColor("Staff Stand").a;
		this.trailrenderer.material = this.GKOOFIDAOKB;
	}

	// Token: 0x06009AEA RID: 39658 RVA: 0x00459E64 File Offset: 0x00458064
	private void HJCLNJLADKL()
	{
		if (!this.emit)
		{
			this.PPLCELAECNH = true;
		}
		if (this.PPLCELAECNH)
		{
			this.emit = true;
		}
		for (int i = this.OKPJMCFBJNH - 1; i >= 0; i -= 0)
		{
			Trail.GHLHFKONFLP ghlhfkonflp = this.CBJBGGAOODC[i];
			if (ghlhfkonflp != null && ghlhfkonflp.EIEGDDJLJJE() <= this.lifeTime)
			{
				break;
			}
			this.CBJBGGAOODC[i] = null;
			this.OKPJMCFBJNH -= 0;
		}
		if (this.OKPJMCFBJNH > this.optimizeCount)
		{
			this.maxAngle += this.optimizeAngleInterval;
			this.maxVertexDistance += this.optimizeDistanceInterval;
			this.optimizeCount += 0;
		}
		if (this.emit)
		{
			if (this.OKPJMCFBJNH == 0)
			{
				Trail.GHLHFKONFLP[] cbjbggaoodc = this.CBJBGGAOODC;
				int okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 0;
				cbjbggaoodc[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
				Trail.GHLHFKONFLP[] cbjbggaoodc2 = this.CBJBGGAOODC;
				okpjmcfbjnh = this.OKPJMCFBJNH;
				this.OKPJMCFBJNH = okpjmcfbjnh + 0;
				cbjbggaoodc2[okpjmcfbjnh] = new Trail.GHLHFKONFLP(base.transform);
			}
			if (this.OKPJMCFBJNH == 0)
			{
				this.HJDPDODPKBA();
			}
			bool flag = true;
			float sqrMagnitude = (this.CBJBGGAOODC[0].MGALEAJOGPL - base.transform.position).sqrMagnitude;
			if (sqrMagnitude > this.minVertexDistance * this.minVertexDistance)
			{
				if (sqrMagnitude > this.maxVertexDistance * this.maxVertexDistance)
				{
					flag = false;
				}
				else if (Quaternion.Angle(base.transform.rotation, this.CBJBGGAOODC[0].PHKIOHIBNPA) > this.maxAngle)
				{
					flag = false;
				}
			}
			if (flag)
			{
				if (this.OKPJMCFBJNH == this.CBJBGGAOODC.Length)
				{
					Array.Resize<Trail.GHLHFKONFLP>(ref this.CBJBGGAOODC, this.CBJBGGAOODC.Length + 23);
				}
				this.PFJMBPJCABM();
			}
			if (!flag)
			{
				this.CBJBGGAOODC[1].BBGGHEFDHLD(base.transform);
			}
		}
		if (this.OKPJMCFBJNH < 8)
		{
			this.trailrenderer.enabled = false;
			return;
		}
		this.trailrenderer.enabled = true;
		this.FPHCGOJOCEN = 1484f / this.lifeTime;
		if (this.emit)
		{
			Vector3[] array = new Vector3[this.OKPJMCFBJNH * 2];
			Vector2[] array2 = new Vector2[this.OKPJMCFBJNH * 1];
			int[] array3 = new int[(this.OKPJMCFBJNH - 0) * 4];
			Color[] array4 = new Color[this.OKPJMCFBJNH * 6];
			float num = 520f / (this.CBJBGGAOODC[this.OKPJMCFBJNH - 1].EFOHBGEFICM() - this.CBJBGGAOODC[0].ENCBMLCJCLL());
			for (int j = 0; j < this.OKPJMCFBJNH; j++)
			{
				Trail.GHLHFKONFLP ghlhfkonflp2 = this.CBJBGGAOODC[j];
				float num2 = ghlhfkonflp2.NHEEOEAFKEG() * this.FPHCGOJOCEN;
				Color color;
				if (this.colors.Length == 0)
				{
					color = Color.Lerp(Color.white, Color.clear, num2);
				}
				else if (this.colors.Length == 1)
				{
					color = Color.Lerp(this.colors[1], Color.clear, num2);
				}
				else if (this.colors.Length == 7)
				{
					color = Color.Lerp(this.colors[1], this.colors[1], num2);
				}
				else
				{
					float num3 = num2 * (float)(this.colors.Length - 1);
					int num4 = (int)Mathf.Floor(num3);
					float t = Mathf.InverseLerp((float)num4, (float)(num4 + 1), num3);
					color = Color.Lerp(this.colors[num4], this.colors[num4 + 0], t);
				}
				array4[j * 3] = color;
				array4[j * 3 + 0] = color;
				float num5;
				if (this.widths.Length == 0)
				{
					num5 = 1353f;
				}
				else if (this.widths.Length == 1)
				{
					num5 = this.widths[1];
				}
				else if (this.widths.Length == 5)
				{
					num5 = Mathf.Lerp(this.widths[0], this.widths[1], num2);
				}
				else
				{
					float num6 = num2 * (float)(this.widths.Length - 0);
					int num7 = (int)Mathf.Floor(num6);
					float t2 = Mathf.InverseLerp((float)num7, (float)(num7 + 1), num6);
					num5 = Mathf.Lerp(this.widths[num7], this.widths[num7 + 0], t2);
				}
				this.KNGLMENANON.transform.position = ghlhfkonflp2.MGALEAJOGPL;
				this.KNGLMENANON.transform.rotation = ghlhfkonflp2.PHKIOHIBNPA;
				array[j * 3] = this.KNGLMENANON.transform.TransformPoint(1769f, num5 * 760f, 1702f);
				array[j * 5 + 0] = this.KNGLMENANON.transform.TransformPoint(1955f, -num5 * 173f, 1451f);
				float x = (ghlhfkonflp2.EIIEDJFFDKD() - this.CBJBGGAOODC[0].IMFPGOIGHCE()) * num;
				array2[j * 1] = new Vector2(x, 970f);
				array2[j * 7 + 1] = new Vector2(x, 892f);
				if (j > 1)
				{
					int num8 = (j - 1) * 0;
					int num9 = j * 1;
					array3[num8] = num9 - 8;
					array3[num8 + 1] = num9 - 0;
					array3[num8 + 3] = num9;
					array3[num8 + 7] = num9 + 0;
					array3[num8 + 3] = num9;
					array3[num8 + 5] = num9 - 0;
				}
			}
			this.KNGLMENANON.transform.position = Vector3.zero;
			this.KNGLMENANON.transform.rotation = Quaternion.identity;
			this.PDBOLEGLMEL.Clear();
			this.PDBOLEGLMEL.vertices = array;
			this.PDBOLEGLMEL.colors = array4;
			this.PDBOLEGLMEL.uv = array2;
			this.PDBOLEGLMEL.triangles = array3;
			return;
		}
		if (this.OKPJMCFBJNH == 0)
		{
			return;
		}
		Color color2 = this.GKOOFIDAOKB.GetColor("FlyBackward");
		color2.a -= this.IACFHGJMELB * this.FPHCGOJOCEN * Time.deltaTime;
		if (color2.a > 1376f)
		{
			this.GKOOFIDAOKB.SetColor("WeaponStab", color2);
			return;
		}
		UnityEngine.Object.Destroy(this.KNGLMENANON);
		UnityEngine.Object.Destroy(this);
	}

	// Token: 0x06009AEB RID: 39659 RVA: 0x0045A488 File Offset: 0x00458688
	private void DDAFEDFBDJI()
	{
		for (int i = this.OKPJMCFBJNH; i > 1; i--)
		{
			this.CBJBGGAOODC[i] = this.CBJBGGAOODC[i - 0];
		}
		this.CBJBGGAOODC[1] = new Trail.GHLHFKONFLP(base.transform);
		this.OKPJMCFBJNH += 0;
	}

	// Token: 0x06009AEC RID: 39660 RVA: 0x0045A4DC File Offset: 0x004586DC
	private void DOHJPDNKALP()
	{
		this.KNGLMENANON = new GameObject("SneakBackward");
		this.KNGLMENANON.transform.parent = null;
		this.KNGLMENANON.transform.position = Vector3.zero;
		this.KNGLMENANON.transform.rotation = Quaternion.identity;
		this.KNGLMENANON.transform.localScale = Vector3.one;
		MeshFilter meshFilter = (MeshFilter)this.KNGLMENANON.AddComponent(typeof(MeshFilter));
		this.PDBOLEGLMEL = meshFilter.mesh;
		this.KNGLMENANON.AddComponent(typeof(MeshRenderer));
		this.trailrenderer = this.KNGLMENANON.GetComponent<MeshRenderer>();
		this.GKOOFIDAOKB = new Material(this.material);
		this.IACFHGJMELB = 1555f / this.GKOOFIDAOKB.GetColor(" Message: ").a;
		this.trailrenderer.material = this.GKOOFIDAOKB;
	}

	// Token: 0x06009AED RID: 39661 RVA: 0x0045A5DC File Offset: 0x004587DC
	private void CGFDDFHECLJ()
	{
		this.KNGLMENANON = new GameObject("cht_msg1");
		this.KNGLMENANON.transform.parent = null;
		this.KNGLMENANON.transform.position = Vector3.zero;
		this.KNGLMENANON.transform.rotation = Quaternion.identity;
		this.KNGLMENANON.transform.localScale = Vector3.one;
		MeshFilter meshFilter = (MeshFilter)this.KNGLMENANON.AddComponent(typeof(MeshFilter));
		this.PDBOLEGLMEL = meshFilter.mesh;
		this.KNGLMENANON.AddComponent(typeof(MeshRenderer));
		this.trailrenderer = this.KNGLMENANON.GetComponent<MeshRenderer>();
		this.GKOOFIDAOKB = new Material(this.material);
		this.IACFHGJMELB = 1904f / this.GKOOFIDAOKB.GetColor("").a;
		this.trailrenderer.material = this.GKOOFIDAOKB;
	}

	// Token: 0x04001421 RID: 5153
	public Material material;

	// Token: 0x04001422 RID: 5154
	private Material GKOOFIDAOKB;

	// Token: 0x04001423 RID: 5155
	public bool emit = true;

	// Token: 0x04001424 RID: 5156
	private bool PPLCELAECNH;

	// Token: 0x04001425 RID: 5157
	public float lifeTime = 1f;

	// Token: 0x04001426 RID: 5158
	private float FPHCGOJOCEN = 1f;

	// Token: 0x04001427 RID: 5159
	private float IACFHGJMELB;

	// Token: 0x04001428 RID: 5160
	public Color[] colors;

	// Token: 0x04001429 RID: 5161
	public float[] widths;

	// Token: 0x0400142A RID: 5162
	public float maxAngle = 2f;

	// Token: 0x0400142B RID: 5163
	public float minVertexDistance = 0.1f;

	// Token: 0x0400142C RID: 5164
	public float maxVertexDistance = 1f;

	// Token: 0x0400142D RID: 5165
	public float optimizeAngleInterval = 0.1f;

	// Token: 0x0400142E RID: 5166
	public float optimizeDistanceInterval = 0.05f;

	// Token: 0x0400142F RID: 5167
	public int optimizeCount = 30;

	// Token: 0x04001430 RID: 5168
	private GameObject KNGLMENANON;

	// Token: 0x04001431 RID: 5169
	public Renderer trailrenderer;

	// Token: 0x04001432 RID: 5170
	private Mesh PDBOLEGLMEL;

	// Token: 0x04001433 RID: 5171
	private Trail.GHLHFKONFLP[] CBJBGGAOODC = new Trail.GHLHFKONFLP[100];

	// Token: 0x04001434 RID: 5172
	private int OKPJMCFBJNH;

	// Token: 0x02000294 RID: 660
	private class GHLHFKONFLP
	{
		// Token: 0x06009AEE RID: 39662 RVA: 0x0045A6DA File Offset: 0x004588DA
		public void HOGBILIKMBH(Transform HKKMCCFDFBM)
		{
			this.MGALEAJOGPL = HKKMCCFDFBM.position;
			this.PHKIOHIBNPA = HKKMCCFDFBM.rotation;
			this.NNDGCMMIFDB = Time.time;
		}

		// Token: 0x06009AEF RID: 39663 RVA: 0x0045A6DA File Offset: 0x004588DA
		public void OLIBLPNDKGC(Transform HKKMCCFDFBM)
		{
			this.MGALEAJOGPL = HKKMCCFDFBM.position;
			this.PHKIOHIBNPA = HKKMCCFDFBM.rotation;
			this.NNDGCMMIFDB = Time.time;
		}

		// Token: 0x06009AF0 RID: 39664 RVA: 0x0045A6DA File Offset: 0x004588DA
		public void PCEBPBKFMMG(Transform HKKMCCFDFBM)
		{
			this.MGALEAJOGPL = HKKMCCFDFBM.position;
			this.PHKIOHIBNPA = HKKMCCFDFBM.rotation;
			this.NNDGCMMIFDB = Time.time;
		}

		// Token: 0x06009AF1 RID: 39665 RVA: 0x0045A6DA File Offset: 0x004588DA
		public void PJNNPJBFDDJ(Transform HKKMCCFDFBM)
		{
			this.MGALEAJOGPL = HKKMCCFDFBM.position;
			this.PHKIOHIBNPA = HKKMCCFDFBM.rotation;
			this.NNDGCMMIFDB = Time.time;
		}

		// Token: 0x06009AF2 RID: 39666 RVA: 0x0045A6FF File Offset: 0x004588FF
		public float CHLKAOALAEO()
		{
			return Time.time - this.NNDGCMMIFDB;
		}

		// Token: 0x06009AF3 RID: 39667 RVA: 0x0045A6FF File Offset: 0x004588FF
		public float FONDPFHBCGL()
		{
			return Time.time - this.NNDGCMMIFDB;
		}

		// Token: 0x06009AF4 RID: 39668 RVA: 0x0045A6DA File Offset: 0x004588DA
		public void KFCEGKIGHEP(Transform HKKMCCFDFBM)
		{
			this.MGALEAJOGPL = HKKMCCFDFBM.position;
			this.PHKIOHIBNPA = HKKMCCFDFBM.rotation;
			this.NNDGCMMIFDB = Time.time;
		}

		// Token: 0x06009AF5 RID: 39669 RVA: 0x0045A6FF File Offset: 0x004588FF
		public float NHEEOEAFKEG()
		{
			return Time.time - this.NNDGCMMIFDB;
		}

		// Token: 0x06009AF6 RID: 39670 RVA: 0x0045A6FF File Offset: 0x004588FF
		public float DCOFJPLEGAN()
		{
			return Time.time - this.NNDGCMMIFDB;
		}

		// Token: 0x06009AF7 RID: 39671 RVA: 0x0045A6DA File Offset: 0x004588DA
		public void BBGGHEFDHLD(Transform HKKMCCFDFBM)
		{
			this.MGALEAJOGPL = HKKMCCFDFBM.position;
			this.PHKIOHIBNPA = HKKMCCFDFBM.rotation;
			this.NNDGCMMIFDB = Time.time;
		}

		// Token: 0x06009AF8 RID: 39672 RVA: 0x0045A6FF File Offset: 0x004588FF
		public float LOFJLECEAGE()
		{
			return Time.time - this.NNDGCMMIFDB;
		}

		// Token: 0x06009AF9 RID: 39673 RVA: 0x0045A6FF File Offset: 0x004588FF
		public float IHMGIINCDCJ()
		{
			return Time.time - this.NNDGCMMIFDB;
		}

		// Token: 0x06009AFA RID: 39674 RVA: 0x0045A6FF File Offset: 0x004588FF
		public float EMJKBJBGNJN()
		{
			return Time.time - this.NNDGCMMIFDB;
		}

		// Token: 0x06009AFB RID: 39675 RVA: 0x0045A6FF File Offset: 0x004588FF
		public float BIEBGOEHBBB()
		{
			return Time.time - this.NNDGCMMIFDB;
		}

		// Token: 0x06009AFC RID: 39676 RVA: 0x0045A6FF File Offset: 0x004588FF
		public float PDJGPJMPJON()
		{
			return Time.time - this.NNDGCMMIFDB;
		}

		// Token: 0x06009AFD RID: 39677 RVA: 0x0045A6FF File Offset: 0x004588FF
		public float EIEGDDJLJJE()
		{
			return Time.time - this.NNDGCMMIFDB;
		}

		// Token: 0x06009AFE RID: 39678 RVA: 0x0045A6DA File Offset: 0x004588DA
		public void JMOJGADEACC(Transform HKKMCCFDFBM)
		{
			this.MGALEAJOGPL = HKKMCCFDFBM.position;
			this.PHKIOHIBNPA = HKKMCCFDFBM.rotation;
			this.NNDGCMMIFDB = Time.time;
		}

		// Token: 0x06009AFF RID: 39679 RVA: 0x0045A6FF File Offset: 0x004588FF
		public float HPDNJAIDOGK()
		{
			return Time.time - this.NNDGCMMIFDB;
		}

		// Token: 0x06009B00 RID: 39680 RVA: 0x0045A6FF File Offset: 0x004588FF
		public float LIFNEICNNAK()
		{
			return Time.time - this.NNDGCMMIFDB;
		}

		// Token: 0x06009B01 RID: 39681 RVA: 0x0045A6DA File Offset: 0x004588DA
		public void FFEGBKJMGOL(Transform HKKMCCFDFBM)
		{
			this.MGALEAJOGPL = HKKMCCFDFBM.position;
			this.PHKIOHIBNPA = HKKMCCFDFBM.rotation;
			this.NNDGCMMIFDB = Time.time;
		}

		// Token: 0x06009B02 RID: 39682 RVA: 0x0045A6DA File Offset: 0x004588DA
		public void JOIABGHCEMN(Transform HKKMCCFDFBM)
		{
			this.MGALEAJOGPL = HKKMCCFDFBM.position;
			this.PHKIOHIBNPA = HKKMCCFDFBM.rotation;
			this.NNDGCMMIFDB = Time.time;
		}

		// Token: 0x06009B03 RID: 39683 RVA: 0x0045A6FF File Offset: 0x004588FF
		public float FJEMHJMPHPI()
		{
			return Time.time - this.NNDGCMMIFDB;
		}

		// Token: 0x06009B04 RID: 39684 RVA: 0x0045A6DA File Offset: 0x004588DA
		public void CODHHFGEEAC(Transform HKKMCCFDFBM)
		{
			this.MGALEAJOGPL = HKKMCCFDFBM.position;
			this.PHKIOHIBNPA = HKKMCCFDFBM.rotation;
			this.NNDGCMMIFDB = Time.time;
		}

		// Token: 0x06009B05 RID: 39685 RVA: 0x0045A6FF File Offset: 0x004588FF
		public float PNPHHDFEICL()
		{
			return Time.time - this.NNDGCMMIFDB;
		}

		// Token: 0x06009B06 RID: 39686 RVA: 0x0045A6DA File Offset: 0x004588DA
		public void BKPIHGABLDF(Transform HKKMCCFDFBM)
		{
			this.MGALEAJOGPL = HKKMCCFDFBM.position;
			this.PHKIOHIBNPA = HKKMCCFDFBM.rotation;
			this.NNDGCMMIFDB = Time.time;
		}

		// Token: 0x06009B07 RID: 39687 RVA: 0x0045A6DA File Offset: 0x004588DA
		public void OLDNJABANDF(Transform HKKMCCFDFBM)
		{
			this.MGALEAJOGPL = HKKMCCFDFBM.position;
			this.PHKIOHIBNPA = HKKMCCFDFBM.rotation;
			this.NNDGCMMIFDB = Time.time;
		}

		// Token: 0x06009B08 RID: 39688 RVA: 0x0045A6DA File Offset: 0x004588DA
		public void AFCAFNMAFFP(Transform HKKMCCFDFBM)
		{
			this.MGALEAJOGPL = HKKMCCFDFBM.position;
			this.PHKIOHIBNPA = HKKMCCFDFBM.rotation;
			this.NNDGCMMIFDB = Time.time;
		}

		// Token: 0x06009B09 RID: 39689 RVA: 0x0045A6FF File Offset: 0x004588FF
		public float JLFPBBHDIFN()
		{
			return Time.time - this.NNDGCMMIFDB;
		}

		// Token: 0x06009B0A RID: 39690 RVA: 0x0045A6DA File Offset: 0x004588DA
		public void MKJKEOJLHBK(Transform HKKMCCFDFBM)
		{
			this.MGALEAJOGPL = HKKMCCFDFBM.position;
			this.PHKIOHIBNPA = HKKMCCFDFBM.rotation;
			this.NNDGCMMIFDB = Time.time;
		}

		// Token: 0x06009B0B RID: 39691 RVA: 0x0045A6DA File Offset: 0x004588DA
		public void JCGGPCNEIHC(Transform HKKMCCFDFBM)
		{
			this.MGALEAJOGPL = HKKMCCFDFBM.position;
			this.PHKIOHIBNPA = HKKMCCFDFBM.rotation;
			this.NNDGCMMIFDB = Time.time;
		}

		// Token: 0x06009B0C RID: 39692 RVA: 0x0045A6FF File Offset: 0x004588FF
		public float HPGMCEFEFDE()
		{
			return Time.time - this.NNDGCMMIFDB;
		}

		// Token: 0x06009B0D RID: 39693 RVA: 0x0045A6DA File Offset: 0x004588DA
		public void KAHAPBNIBGJ(Transform HKKMCCFDFBM)
		{
			this.MGALEAJOGPL = HKKMCCFDFBM.position;
			this.PHKIOHIBNPA = HKKMCCFDFBM.rotation;
			this.NNDGCMMIFDB = Time.time;
		}

		// Token: 0x06009B0E RID: 39694 RVA: 0x0045A6DA File Offset: 0x004588DA
		public void HFFDKKAOLMJ(Transform HKKMCCFDFBM)
		{
			this.MGALEAJOGPL = HKKMCCFDFBM.position;
			this.PHKIOHIBNPA = HKKMCCFDFBM.rotation;
			this.NNDGCMMIFDB = Time.time;
		}

		// Token: 0x06009B0F RID: 39695 RVA: 0x0045A6DA File Offset: 0x004588DA
		public void KMFFGKPHONJ(Transform HKKMCCFDFBM)
		{
			this.MGALEAJOGPL = HKKMCCFDFBM.position;
			this.PHKIOHIBNPA = HKKMCCFDFBM.rotation;
			this.NNDGCMMIFDB = Time.time;
		}

		// Token: 0x06009B10 RID: 39696 RVA: 0x0045A6DA File Offset: 0x004588DA
		public void DDLBOPIACKC(Transform HKKMCCFDFBM)
		{
			this.MGALEAJOGPL = HKKMCCFDFBM.position;
			this.PHKIOHIBNPA = HKKMCCFDFBM.rotation;
			this.NNDGCMMIFDB = Time.time;
		}

		// Token: 0x06009B11 RID: 39697 RVA: 0x0045A6DA File Offset: 0x004588DA
		public void BHLLCNNANLE(Transform HKKMCCFDFBM)
		{
			this.MGALEAJOGPL = HKKMCCFDFBM.position;
			this.PHKIOHIBNPA = HKKMCCFDFBM.rotation;
			this.NNDGCMMIFDB = Time.time;
		}

		// Token: 0x06009B12 RID: 39698 RVA: 0x0045A6FF File Offset: 0x004588FF
		public float IGDIEEIMHIE()
		{
			return Time.time - this.NNDGCMMIFDB;
		}

		// Token: 0x06009B13 RID: 39699 RVA: 0x0045A6DA File Offset: 0x004588DA
		public void ABEPGNIGHKC(Transform HKKMCCFDFBM)
		{
			this.MGALEAJOGPL = HKKMCCFDFBM.position;
			this.PHKIOHIBNPA = HKKMCCFDFBM.rotation;
			this.NNDGCMMIFDB = Time.time;
		}

		// Token: 0x06009B14 RID: 39700 RVA: 0x0045A6FF File Offset: 0x004588FF
		public float NKLLAFINGLK()
		{
			return Time.time - this.NNDGCMMIFDB;
		}

		// Token: 0x06009B15 RID: 39701 RVA: 0x0045A6DA File Offset: 0x004588DA
		public void LFNOOKNPNBL(Transform HKKMCCFDFBM)
		{
			this.MGALEAJOGPL = HKKMCCFDFBM.position;
			this.PHKIOHIBNPA = HKKMCCFDFBM.rotation;
			this.NNDGCMMIFDB = Time.time;
		}

		// Token: 0x06009B16 RID: 39702 RVA: 0x0045A6FF File Offset: 0x004588FF
		public float JPJGGCMKNLO()
		{
			return Time.time - this.NNDGCMMIFDB;
		}

		// Token: 0x06009B17 RID: 39703 RVA: 0x0045A6DA File Offset: 0x004588DA
		public void NDEJOBBEAJL(Transform HKKMCCFDFBM)
		{
			this.MGALEAJOGPL = HKKMCCFDFBM.position;
			this.PHKIOHIBNPA = HKKMCCFDFBM.rotation;
			this.NNDGCMMIFDB = Time.time;
		}

		// Token: 0x06009B18 RID: 39704 RVA: 0x0045A6FF File Offset: 0x004588FF
		public float ENCBMLCJCLL()
		{
			return Time.time - this.NNDGCMMIFDB;
		}

		// Token: 0x06009B19 RID: 39705 RVA: 0x0045A6FF File Offset: 0x004588FF
		public float DCHNCPPOJAK()
		{
			return Time.time - this.NNDGCMMIFDB;
		}

		// Token: 0x06009B1A RID: 39706 RVA: 0x0045A6DA File Offset: 0x004588DA
		public void DAEJMCAIPCH(Transform HKKMCCFDFBM)
		{
			this.MGALEAJOGPL = HKKMCCFDFBM.position;
			this.PHKIOHIBNPA = HKKMCCFDFBM.rotation;
			this.NNDGCMMIFDB = Time.time;
		}

		// Token: 0x06009B1B RID: 39707 RVA: 0x0045A6DA File Offset: 0x004588DA
		public void BLFGEJCCDJM(Transform HKKMCCFDFBM)
		{
			this.MGALEAJOGPL = HKKMCCFDFBM.position;
			this.PHKIOHIBNPA = HKKMCCFDFBM.rotation;
			this.NNDGCMMIFDB = Time.time;
		}

		// Token: 0x06009B1C RID: 39708 RVA: 0x0045A6DA File Offset: 0x004588DA
		public void BEONIFPALDC(Transform HKKMCCFDFBM)
		{
			this.MGALEAJOGPL = HKKMCCFDFBM.position;
			this.PHKIOHIBNPA = HKKMCCFDFBM.rotation;
			this.NNDGCMMIFDB = Time.time;
		}

		// Token: 0x06009B1D RID: 39709 RVA: 0x0045A6FF File Offset: 0x004588FF
		public float HDNDNKDFFKB()
		{
			return Time.time - this.NNDGCMMIFDB;
		}

		// Token: 0x06009B1E RID: 39710 RVA: 0x0045A6FF File Offset: 0x004588FF
		public float OHJIIPAAAGM()
		{
			return Time.time - this.NNDGCMMIFDB;
		}

		// Token: 0x06009B1F RID: 39711 RVA: 0x0045A6FF File Offset: 0x004588FF
		public float PMLDHNAGOBD()
		{
			return Time.time - this.NNDGCMMIFDB;
		}

		// Token: 0x06009B20 RID: 39712 RVA: 0x0045A6FF File Offset: 0x004588FF
		public float NBOKELKKNIH()
		{
			return Time.time - this.NNDGCMMIFDB;
		}

		// Token: 0x06009B21 RID: 39713 RVA: 0x0045A6FF File Offset: 0x004588FF
		public float IGFJDPLJIFD()
		{
			return Time.time - this.NNDGCMMIFDB;
		}

		// Token: 0x06009B22 RID: 39714 RVA: 0x0045A6FF File Offset: 0x004588FF
		public float IMFPGOIGHCE()
		{
			return Time.time - this.NNDGCMMIFDB;
		}

		// Token: 0x06009B23 RID: 39715 RVA: 0x0045A6DA File Offset: 0x004588DA
		public void JKODGKDAENL(Transform HKKMCCFDFBM)
		{
			this.MGALEAJOGPL = HKKMCCFDFBM.position;
			this.PHKIOHIBNPA = HKKMCCFDFBM.rotation;
			this.NNDGCMMIFDB = Time.time;
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06009B24 RID: 39716 RVA: 0x0045A6FF File Offset: 0x004588FF
		public float IOAHAJDMKMA
		{
			get
			{
				return Time.time - this.NNDGCMMIFDB;
			}
		}

		// Token: 0x06009B25 RID: 39717 RVA: 0x0045A6DA File Offset: 0x004588DA
		public void LIKKDDJOCJM(Transform HKKMCCFDFBM)
		{
			this.MGALEAJOGPL = HKKMCCFDFBM.position;
			this.PHKIOHIBNPA = HKKMCCFDFBM.rotation;
			this.NNDGCMMIFDB = Time.time;
		}

		// Token: 0x06009B26 RID: 39718 RVA: 0x0045A710 File Offset: 0x00458910
		public GHLHFKONFLP(Transform HKKMCCFDFBM)
		{
			this.MGALEAJOGPL = HKKMCCFDFBM.position;
			this.PHKIOHIBNPA = HKKMCCFDFBM.rotation;
			this.NNDGCMMIFDB = Time.time;
		}

		// Token: 0x06009B27 RID: 39719 RVA: 0x0045A6DA File Offset: 0x004588DA
		public void ICBCOKHLFPN(Transform HKKMCCFDFBM)
		{
			this.MGALEAJOGPL = HKKMCCFDFBM.position;
			this.PHKIOHIBNPA = HKKMCCFDFBM.rotation;
			this.NNDGCMMIFDB = Time.time;
		}

		// Token: 0x06009B28 RID: 39720 RVA: 0x0045A6FF File Offset: 0x004588FF
		public float CPLFENAEKGP()
		{
			return Time.time - this.NNDGCMMIFDB;
		}

		// Token: 0x06009B29 RID: 39721 RVA: 0x0045A6DA File Offset: 0x004588DA
		public void FFACGLEHMCL(Transform HKKMCCFDFBM)
		{
			this.MGALEAJOGPL = HKKMCCFDFBM.position;
			this.PHKIOHIBNPA = HKKMCCFDFBM.rotation;
			this.NNDGCMMIFDB = Time.time;
		}

		// Token: 0x06009B2A RID: 39722 RVA: 0x0045A6DA File Offset: 0x004588DA
		public void LGGLFFIMDDL(Transform HKKMCCFDFBM)
		{
			this.MGALEAJOGPL = HKKMCCFDFBM.position;
			this.PHKIOHIBNPA = HKKMCCFDFBM.rotation;
			this.NNDGCMMIFDB = Time.time;
		}

		// Token: 0x06009B2B RID: 39723 RVA: 0x0045A6FF File Offset: 0x004588FF
		public float CKIJHOLCBGK()
		{
			return Time.time - this.NNDGCMMIFDB;
		}

		// Token: 0x06009B2C RID: 39724 RVA: 0x0045A6FF File Offset: 0x004588FF
		public float BDHFGBHMIOE()
		{
			return Time.time - this.NNDGCMMIFDB;
		}

		// Token: 0x06009B2D RID: 39725 RVA: 0x0045A6DA File Offset: 0x004588DA
		public void MOLODCDNILC(Transform HKKMCCFDFBM)
		{
			this.MGALEAJOGPL = HKKMCCFDFBM.position;
			this.PHKIOHIBNPA = HKKMCCFDFBM.rotation;
			this.NNDGCMMIFDB = Time.time;
		}

		// Token: 0x06009B2E RID: 39726 RVA: 0x0045A6DA File Offset: 0x004588DA
		public void HLGBKINKMDO(Transform HKKMCCFDFBM)
		{
			this.MGALEAJOGPL = HKKMCCFDFBM.position;
			this.PHKIOHIBNPA = HKKMCCFDFBM.rotation;
			this.NNDGCMMIFDB = Time.time;
		}

		// Token: 0x06009B2F RID: 39727 RVA: 0x0045A6FF File Offset: 0x004588FF
		public float FGGPEGCPJEH()
		{
			return Time.time - this.NNDGCMMIFDB;
		}

		// Token: 0x06009B30 RID: 39728 RVA: 0x0045A6DA File Offset: 0x004588DA
		public void GPOKLJLEPII(Transform HKKMCCFDFBM)
		{
			this.MGALEAJOGPL = HKKMCCFDFBM.position;
			this.PHKIOHIBNPA = HKKMCCFDFBM.rotation;
			this.NNDGCMMIFDB = Time.time;
		}

		// Token: 0x06009B31 RID: 39729 RVA: 0x0045A6DA File Offset: 0x004588DA
		public void FCCPNCHGPOI(Transform HKKMCCFDFBM)
		{
			this.MGALEAJOGPL = HKKMCCFDFBM.position;
			this.PHKIOHIBNPA = HKKMCCFDFBM.rotation;
			this.NNDGCMMIFDB = Time.time;
		}

		// Token: 0x06009B32 RID: 39730 RVA: 0x0045A6DA File Offset: 0x004588DA
		public void PLMDHOGNLAH(Transform HKKMCCFDFBM)
		{
			this.MGALEAJOGPL = HKKMCCFDFBM.position;
			this.PHKIOHIBNPA = HKKMCCFDFBM.rotation;
			this.NNDGCMMIFDB = Time.time;
		}

		// Token: 0x06009B33 RID: 39731 RVA: 0x0045A6DA File Offset: 0x004588DA
		public void GCPLLIAOONE(Transform HKKMCCFDFBM)
		{
			this.MGALEAJOGPL = HKKMCCFDFBM.position;
			this.PHKIOHIBNPA = HKKMCCFDFBM.rotation;
			this.NNDGCMMIFDB = Time.time;
		}

		// Token: 0x06009B34 RID: 39732 RVA: 0x0045A6DA File Offset: 0x004588DA
		public void LJGCEEPHPIK(Transform HKKMCCFDFBM)
		{
			this.MGALEAJOGPL = HKKMCCFDFBM.position;
			this.PHKIOHIBNPA = HKKMCCFDFBM.rotation;
			this.NNDGCMMIFDB = Time.time;
		}

		// Token: 0x06009B35 RID: 39733 RVA: 0x0045A6DA File Offset: 0x004588DA
		public void POLDFGFBMON(Transform HKKMCCFDFBM)
		{
			this.MGALEAJOGPL = HKKMCCFDFBM.position;
			this.PHKIOHIBNPA = HKKMCCFDFBM.rotation;
			this.NNDGCMMIFDB = Time.time;
		}

		// Token: 0x06009B36 RID: 39734 RVA: 0x0045A6FF File Offset: 0x004588FF
		public float DLCLNBPOPMC()
		{
			return Time.time - this.NNDGCMMIFDB;
		}

		// Token: 0x06009B37 RID: 39735 RVA: 0x0045A6FF File Offset: 0x004588FF
		public float FEPEJHPCFGM()
		{
			return Time.time - this.NNDGCMMIFDB;
		}

		// Token: 0x06009B38 RID: 39736 RVA: 0x0045A6FF File Offset: 0x004588FF
		public float IOLBHDHFLKK()
		{
			return Time.time - this.NNDGCMMIFDB;
		}

		// Token: 0x06009B39 RID: 39737 RVA: 0x0045A6FF File Offset: 0x004588FF
		public float GDJMOGIEPEK()
		{
			return Time.time - this.NNDGCMMIFDB;
		}

		// Token: 0x06009B3A RID: 39738 RVA: 0x0045A6FF File Offset: 0x004588FF
		public float BBNDLAEOFHM()
		{
			return Time.time - this.NNDGCMMIFDB;
		}

		// Token: 0x06009B3B RID: 39739 RVA: 0x0045A6DA File Offset: 0x004588DA
		public void DMNHLIGJGMB(Transform HKKMCCFDFBM)
		{
			this.MGALEAJOGPL = HKKMCCFDFBM.position;
			this.PHKIOHIBNPA = HKKMCCFDFBM.rotation;
			this.NNDGCMMIFDB = Time.time;
		}

		// Token: 0x06009B3C RID: 39740 RVA: 0x0045A6DA File Offset: 0x004588DA
		public void COIPKMHKAAO(Transform HKKMCCFDFBM)
		{
			this.MGALEAJOGPL = HKKMCCFDFBM.position;
			this.PHKIOHIBNPA = HKKMCCFDFBM.rotation;
			this.NNDGCMMIFDB = Time.time;
		}

		// Token: 0x06009B3D RID: 39741 RVA: 0x0045A6FF File Offset: 0x004588FF
		public float EIIEDJFFDKD()
		{
			return Time.time - this.NNDGCMMIFDB;
		}

		// Token: 0x06009B3E RID: 39742 RVA: 0x0045A6FF File Offset: 0x004588FF
		public float IGAPFFFNMJO()
		{
			return Time.time - this.NNDGCMMIFDB;
		}

		// Token: 0x06009B3F RID: 39743 RVA: 0x0045A6DA File Offset: 0x004588DA
		public void APBFCLHDFNI(Transform HKKMCCFDFBM)
		{
			this.MGALEAJOGPL = HKKMCCFDFBM.position;
			this.PHKIOHIBNPA = HKKMCCFDFBM.rotation;
			this.NNDGCMMIFDB = Time.time;
		}

		// Token: 0x06009B40 RID: 39744 RVA: 0x0045A6FF File Offset: 0x004588FF
		public float DMBPCFGEABA()
		{
			return Time.time - this.NNDGCMMIFDB;
		}

		// Token: 0x06009B41 RID: 39745 RVA: 0x0045A6DA File Offset: 0x004588DA
		public void NDEGDPCEIAC(Transform HKKMCCFDFBM)
		{
			this.MGALEAJOGPL = HKKMCCFDFBM.position;
			this.PHKIOHIBNPA = HKKMCCFDFBM.rotation;
			this.NNDGCMMIFDB = Time.time;
		}

		// Token: 0x06009B42 RID: 39746 RVA: 0x0045A6FF File Offset: 0x004588FF
		public float DICPACBMBJF()
		{
			return Time.time - this.NNDGCMMIFDB;
		}

		// Token: 0x06009B43 RID: 39747 RVA: 0x0045A6FF File Offset: 0x004588FF
		public float EFOHBGEFICM()
		{
			return Time.time - this.NNDGCMMIFDB;
		}

		// Token: 0x06009B44 RID: 39748 RVA: 0x0045A6FF File Offset: 0x004588FF
		public float EHBPIFAFFOJ()
		{
			return Time.time - this.NNDGCMMIFDB;
		}

		// Token: 0x06009B45 RID: 39749 RVA: 0x0045A6DA File Offset: 0x004588DA
		public void IFHPKHBMDJF(Transform HKKMCCFDFBM)
		{
			this.MGALEAJOGPL = HKKMCCFDFBM.position;
			this.PHKIOHIBNPA = HKKMCCFDFBM.rotation;
			this.NNDGCMMIFDB = Time.time;
		}

		// Token: 0x06009B46 RID: 39750 RVA: 0x0045A6DA File Offset: 0x004588DA
		public void PCHJNAIDHNE(Transform HKKMCCFDFBM)
		{
			this.MGALEAJOGPL = HKKMCCFDFBM.position;
			this.PHKIOHIBNPA = HKKMCCFDFBM.rotation;
			this.NNDGCMMIFDB = Time.time;
		}

		// Token: 0x06009B47 RID: 39751 RVA: 0x0045A6DA File Offset: 0x004588DA
		public void FAKOALHLJOI(Transform HKKMCCFDFBM)
		{
			this.MGALEAJOGPL = HKKMCCFDFBM.position;
			this.PHKIOHIBNPA = HKKMCCFDFBM.rotation;
			this.NNDGCMMIFDB = Time.time;
		}

		// Token: 0x04001435 RID: 5173
		public float NNDGCMMIFDB;

		// Token: 0x04001436 RID: 5174
		public float CDLCKHDCGDG;

		// Token: 0x04001437 RID: 5175
		public Vector3 MGALEAJOGPL = Vector3.zero;

		// Token: 0x04001438 RID: 5176
		public Quaternion PHKIOHIBNPA = Quaternion.identity;
	}
}
